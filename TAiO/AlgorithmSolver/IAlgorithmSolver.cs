namespace TAiO.AlgorithmSolver
{
    public interface IAlgorithmSolver
    {
        public (int bestCost, int[,] bestMatrix, int[] bestPermutation) CalculateSimilarity(ProblemRepresentation problem);
    }
}