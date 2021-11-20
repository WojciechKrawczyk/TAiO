using System;
using System.Linq;
using TAiO.Graphs;

namespace TAiO.AlgorithmSolver
{
    public class BaseAlgorithmSolver : IAlgorithmSolver
    {
        private Graph _graph1;
        private Graph _graph2;
        private int n;
        private int _initialCost;
        private string _toPermutations;
        private int _bestCost = int.MaxValue;
        private int[,] _bestCostMatrix;
        private string _bestPermutation;

        public (int bestCost, int[,] bestMatrix, int[] bestPermutation) CalculateSimilarity(ProblemRepresentation problem)
        {
            _graph1 = new Graph(problem.Graph1.IncidenceMatrix, problem.Size);
            _graph2 = new Graph(problem.Graph2.IncidenceMatrix, problem.Size);
            _initialCost = problem.InitialCost;
            n = problem.Size;
            _toPermutations = string.Empty;
            for (int i = 0; i < n; i++)
                _toPermutations += i.ToString();
            _bestPermutation = new string(_toPermutations);

            StartPermutations(_toPermutations, 0, n - 1);
            return (_bestCost + _initialCost, _bestCostMatrix, _bestPermutation.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray());
        }

        private bool StartPermutations(string input, int l, int r)
        {
            if (l == r)
            {
                if (AnalyzePermutation(input) == 0)
                    return true;
                return false;
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    input = SwapSymbols(input, l, i);
                    var stop = StartPermutations(input, l + 1, r);
                    if (!stop)
                        input = SwapSymbols(input, l, i);
                    else
                        return true;
                }
                return false;
            }
        }

        private string SwapSymbols(string input, int i, int j)
        {
            var charArray = input.ToCharArray();
            var temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            return new string(charArray);
        }

        private int AnalyzePermutation(string permutation)
        {
            var basicPermutation = _toPermutations;
            var tmpGraph = new Graph(_graph2.IncidenceMatrix, n);
            for (int i = 0; i < n; i++)
            {
                int index = basicPermutation.IndexOf(permutation[i]);
                tmpGraph.SwapVertexes(index, i);
                basicPermutation = SwapSymbols(basicPermutation, index, i);
            }
            int result = CalculateMetrics(_graph1, tmpGraph);
            if (result < _bestCost)
            {
                _bestCost = result;
                _bestCostMatrix = tmpGraph.IncidenceMatrix;
                _bestPermutation = permutation;
            }
            return result;
        }

        private int CalculateMetrics(Graph graph1, Graph graph2)
        {
            int n = graph1.Size;
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    m += Math.Abs(graph1.IncidenceMatrix[i, j] - graph2.IncidenceMatrix[i, j]);
                }
            }
            return m;
        }
    }
}