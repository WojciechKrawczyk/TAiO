using TAiO.Graphs;
using System.Diagnostics;
using System.Text;

namespace TAiO.AlgorithmSolver
{
    public class HeuristicAlgoritmSolver : IAlgorithmSolver
    {
        private readonly Graph _graph1;
        private readonly Graph _graph2;
        private readonly int _initialCost;
        private const string _pathToScript = @"C:\Users\Dell\Desktop\TAiO-REPO\TAiO\PythonScripts\LIB-aprox.py";
        private const string _pathToPython = @"C:\Users\Dell\AppData\Local\Programs\Python\Python38-32\python.exe";

        public HeuristicAlgoritmSolver(ProblemRepresentation problem)
        {
            _graph1 = problem.Graph1;
            _graph2 = problem.Graph2;
            _initialCost = problem.InitialCost;
        }

        public int CalculateSimilarity()
        {
            int result = RunPythonProg();
            return result + _initialCost;
        }

        private int RunPythonProg()
        {
            var psi = new ProcessStartInfo();
            psi.FileName = _pathToPython;

            var argv = new StringBuilder();
            argv.Append(_graph1.Size.ToString());
            argv.Append(",");
            argv.Append(_graph1.ToString());
            argv.Append(",");
            argv.Append(_graph2.ToString());

            psi.Arguments = $"\"{_pathToScript}\" \"{argv}\"";
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            //Execute python and get output
            var errors = string.Empty;
            var results = string.Empty;

            using var process = Process.Start(psi);
            errors = process.StandardError.ReadToEnd();
            results = process.StandardOutput.ReadToEnd();

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
