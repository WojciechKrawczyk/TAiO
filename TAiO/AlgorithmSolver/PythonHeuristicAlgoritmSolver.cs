using TAiO.Graphs;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace TAiO.AlgorithmSolver
{
    public class PythonHeuristicAlgoritmSolver : IAlgorithmSolver
    {
        private Graph _graph1;
        private Graph _graph2;
        private int _initialCost;
        private string _fileName;
        private string _pathToFile = System.IO.Directory.GetCurrentDirectory();

        public PythonHeuristicAlgoritmSolver(string fileName)
        {
            _fileName = fileName;
        }

        public (int bestCost, int[,] bestMatrix, int[] bestPermutation) CalculateSimilarity(ProblemRepresentation problem)
        {
            _graph1 = problem.Graph1;
            _graph2 = problem.Graph2;
            _initialCost = problem.InitialCost;

            int result = RunPythonProg();
            return (result + _initialCost, null, null);
        }

        private int RunPythonProg()
        {
            var psi = new ProcessStartInfo();
            psi.FileName = _pathToFile + $"{@"\"}{_fileName}";

            var argv = new StringBuilder();
            argv.Append(_graph1.Size.ToString());
            argv.Append(",");
            argv.Append(_graph1.ToString());
            argv.Append(",");
            argv.Append(_graph2.ToString());

            psi.Arguments = $"\"{argv}\"";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            using var process = Process.Start(psi);
            var errors = process.StandardError.ReadToEnd();
            if (errors != string.Empty)
            {
                MessageBox.Show("Wystąpił nieoczekiwany błąd. Spróbuj ponownie.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            var results = process.StandardOutput.ReadToEnd();

            System.Console.WriteLine("Results");
            System.Console.WriteLine(results);
            results = results.Replace('\n', ' ');
            results = results.Replace('\r', ' ');
            results = results.Replace('.', ',');
            results = results.Trim();
            return (int)(double.Parse(results));
        }
    }
}
