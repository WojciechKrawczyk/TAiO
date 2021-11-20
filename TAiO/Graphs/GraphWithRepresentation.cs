using System.IO;

namespace TAiO.Graphs
{
    public class GraphWithRepresentation : Graph
    {
        private readonly TextPresenter _matrixPresenter;
        private readonly int _presenterThreshold = 10;
        private readonly int _fontSize = 10;
        private int[] _permutation;
        public GraphWithRepresentation(StreamReader reader, int key) : base(null, 0)
        {
            Size = int.Parse(reader.ReadLine());
            IncidenceMatrix = new int[Size, Size];
            _matrixPresenter = new TextPresenter(ProjectForm.RichTextBoxDictionary[key], _fontSize);
            _permutation = new int[Size];

            for (int i = 0; i < Size; i++)
            {
                var values = reader.ReadLine().Split(' ');
                for (int j = 0; j < Size; j++)
                {
                    IncidenceMatrix[i, j] = int.Parse(values[j]);
                }
                _permutation[i] = i;
            }

            UpdateMatrixPresenter();
        }

        public override void Extend(int size)
        {
            base.Extend(size);
            _permutation = new int[Size];
            for (int i = 0; i < Size; i++)
            {
                _permutation[i] = i;
            }
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

            var indexesLine = "  |";
            var breakLine = "---";
            foreach (var index in _permutation)
            {
                indexesLine += index < 9 ? $"{index + 1}  " : $"{index + 1} ";
                breakLine += "---";
            }
            var k = Size > 9 ? 2 : 1;
            indexesLine.Remove(indexesLine.Length - k, k);
            breakLine.Remove(breakLine.Length - k, k);
            _matrixPresenter.AddTextLine(indexesLine);
            _matrixPresenter.AddTextLine(breakLine);

            for (int i = 0; i < Size; i++)
            {
                var index = _permutation[i];
                var line = index < 9 ? $" {index + 1}|" : $"{index + 1}|";
                for (int j = 0; j < Size; j++)
                {
                    line += $"{IncidenceMatrix[i, j]}  ";
                }
                line.Remove(line.Length - 2, 2);
                _matrixPresenter.AddTextLine(line);
            }
        }

        public void UpdateMatrix(int[,] matrix, int[] permutation)
        {
            base.UpdateMatrix(matrix);
            _permutation = permutation;
            UpdateMatrixPresenter();
        }
    }
}