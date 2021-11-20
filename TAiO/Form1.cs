using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using TAiO.AlgorithmSolver;
using TAiO.Graphs;

namespace TAiO
{
    public partial class ProjectForm : Form
    {
        public static Dictionary<int, RichTextBox> RichTextBoxDictionary;
        public static ProblemRepresentation ProblemRepresentation;
        public static TextPresenter CommentsBox;
        public static IAlgorithmSolver AlgorithmSolver;
        public static FileReader FileReader;

        public ProjectForm()
        {
            InitializeComponent();

            RichTextBoxDictionary = new Dictionary<int, RichTextBox>
            {
                {1, RichTextBoxGraph1 },
                {2, RichtextBoxGraph2 }
            };

            CommentsBox = new TextPresenter(RichTextBoxComments);
            FileReader = new FileReader();

            StartCalculationsButton.Enabled = false;
            RBNetworkX.Checked = true;
        }

        private void ReadFileButtonClick(object sender, EventArgs e)
        {
            GraphWithRepresentation graph1, graph2;
            try
            {
                (graph1, graph2) = FileReader.ProccessFile();
            }
            catch
            {
                FileReader.ErrorHandle();
                return;
            }

            ProblemRepresentation = new ProblemRepresentation(graph1, graph2);

            HandleProblemSize();
            CommentsBox.Clean();
            StartCalculationsButton.Enabled = true;
            LabelCalculationsResult.Text = "-";
            LabelTimeResult.Text = "-";

            foreach (var line in ProblemRepresentation.GetComments())
            {
                CommentsBox.AddTextLine(line);
            }
        }

        private void HandleProblemSize()
        {
            if (!ProblemRepresentation.IsSmall)
            {
                MessageBox.Show(
                    "Wczytane grafy zostały zklasyfikowane jako duże.\n" +
                    "Prezentacja macierzy incydencji grafów jest niedostępna.\n" +
                    "Algorytm dokładny nie jest dostępny.", "", MessageBoxButtons.OK, MessageBoxIcon.None);

                if (RBPrecision.Checked)
                {
                    RBNetworkX.Checked = true;
                }

                RBPrecision.Enabled = false;

                RichTextBoxGraph1.Text = "Wyświetlanie niedostępne";
                RichtextBoxGraph2.Text = "Wyświetlanie niedostępne";
            }
            else
            {
                MessageBox.Show("Wczytane grafy zostały zklasyfikowane jako małe.\n" +
                    "Prezentacja macierzy incydencji grafów jest dostępna.\n" +
                    "Wszystkie algorytmy są dostępne.", "", MessageBoxButtons.OK, MessageBoxIcon.None);

                if (!RBPrecision.Enabled)
                    RBPrecision.Enabled = true;
            }
        }

        private void StartCalculationsButtonClick(object sender, EventArgs e)
        {
            var sw = new Stopwatch();
            sw.Start();
            var result = AlgorithmSolver.CalculateSimilarity(ProblemRepresentation);
            sw.Stop();

            if (result.bestMatrix != null)
            {
                ProblemRepresentation.Graph2.UpdateMatrix(result.bestMatrix, result.bestPermutation);
                var permutation = string.Join(", ", result.bestPermutation.Select(x => x + 1));
                CommentsBox.AddTextLine($"Najlepszy wynik został osiągnięty dla permutacji:\n{permutation}.");
            }

            LabelCalculationsResult.Text = result.bestCost >= 0 ? result.bestCost.ToString() : "-";
            LabelTimeResult.Text = sw.Elapsed.TotalSeconds.ToString("F") + " s";

            StartCalculationsButton.Enabled = false;
        }

        private void RBNetworkX_CheckedChanged(object sender, EventArgs e)
        {
            if (RBNetworkX.Checked)
                AlgorithmSolver = new NetworkXHeuristicAlgoritmSolver();
        }

        private void RBLSAP_CheckedChanged(object sender, EventArgs e)
        {
            if (RBLSAP.Checked)
                AlgorithmSolver = new LSAPHeuristicAlgorithmSolver();
        }

        private void RBPrecision_CheckedChanged(object sender, EventArgs e)
        {
            if (RBPrecision.Checked)
                AlgorithmSolver = new BaseAlgorithmSolver();
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aby poprawnie skorzystać z aplikacji wykonaj następujące dziłania:\n" +
                "1. Wczytaj plik.\n" +
                "2. Wybierz odpowiedni algorytm.\n" +
                "3. Wykonaj obliczenia.\n" +
                "4. Przeanalizuj wyniki.\n" +
                "5. Aby ponownie wykonać obliczenia powtórz kroki od 1 do 4.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}