using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using TAiO.AlgorithmSolver;

namespace TAiO
{
    public partial class ProjectForm : Form
    {
        public static Dictionary<int, RichTextBox> RichTextBoxDictionary;
        public static ProblemRepresentation ProblemRepresentation;
        public static TextPresenter CommentsBox;

        public ProjectForm()
        {
            InitializeComponent();

            RichTextBoxDictionary = new Dictionary<int, RichTextBox>
            {
                {1, RichTextBoxGraph1 },
                {2, RichtextBoxGraph2 }
            };

            CommentsBox = new TextPresenter(RichTextBoxComments);
        }

        private void ReadFileButtonClick(object sender, EventArgs e)
        {
            CommentsBox.Clean();
            FileReader fileReader = new FileReader();
            try
            {
                var (graph1, graph2) = fileReader.ProccessFile();
                ProblemRepresentation = new ProblemRepresentation(graph1, graph2);
            }
            catch
            {
                CommentsBox.AddTextLine("Wybrany plik ma zły format.");
                return;
            }

            foreach(var line in ProblemRepresentation.GetComments())
            {
                CommentsBox.AddTextLine(line);
            }
        }

        private void StartCalculationsButtonClick(object sender, EventArgs e)
        {
            IAlgorithmSolver solver;
            if (ProblemRepresentation.IsSmall)
                solver = new BaseAlgorithmSolver(ProblemRepresentation);
            else
                solver = new HeuristicAlgoritmSolver(ProblemRepresentation);

            var sw = new Stopwatch();
            sw.Start();
            var result = solver.CalculateSimilarity();
            sw.Stop();

            if (ProblemRepresentation.IsSmall)
                ProblemRepresentation.Graph2.UpdateMatrix(((BaseAlgorithmSolver)solver).GetBestMatrix());

            LabelCalculationsResult.Text = result.ToString();
            LabelTimeResult.Text = sw.Elapsed.TotalSeconds.ToString("F") + " sekund";
        }
    }
}
