using System.IO;

namespace TAiO.Graphs
{
    public class GraphWithRepresentation : Graph
    {
        private readonly TextPresenter _matrixPresenter;
        private readonly int _presenterThreshold = 10;
        private readonly int _fontSize = 15;
        public GraphWithRepresentation(StreamReader reader, int key) : base(null, 0)
        {
            Size = int.Parse(reader.ReadLine());
            IncidenceMatrix = new int[Size, Size];
            _matrixPresenter = new TextPresenter(ProjectForm.RichTextBoxDictionary[key], _fontSize);

            for (int i = 0; i < Size; i++)
            {
                var values = reader.ReadLine().Split(' ');
                for (int j = 0; j < Size; j++)
                {
                    IncidenceMatrix[i, j] = int.Parse(values[j]);
                }
            }

            UpdateMatrixPresenter();
        }

        public override void Extend(int size)
        {
            base.Extend(size);
            UpdateMatrixPresenter();
        }

        private void UpdateMatrixPresenter()
        {
            _matrixPresenter.Clean();
            if (Size > _presenterThreshold)
            {
                _matrixPresenter.AddTextLine("Wyświetlanie niedostępne.");
                return;
            }

            for (int i = 0; i < Size; i++)
            {
                var line = string.Empty;
                for (int j = 0; j < Size; j++)
                {
                    line += $"{IncidenceMatrix[i, j]} ";
                }
                line.Remove(line.Length - 1, 1);
                _matrixPresenter.AddTextLine(line);
            }
        }

        public override void UpdateMatrix(int[,] matrix)
        {
            base.UpdateMatrix(matrix);
            UpdateMatrixPresenter();
        }
    }
}