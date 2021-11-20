using System.IO;
using System.Windows.Forms;
using TAiO.Graphs;

namespace TAiO
{
    public class FileReader
    {
        private OpenFileDialog FileDialog;

        public FileReader()
        {
            FileDialog = new OpenFileDialog();
            FileDialog.Filter = "txt files (*.txt)|*.txt";
            FileDialog.RestoreDirectory = true;
        }

        public (GraphWithRepresentation graph1, GraphWithRepresentation graph2) ProccessFile()
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                using var reader = new StreamReader(FileDialog.OpenFile());
                GraphWithRepresentation graph1 = new GraphWithRepresentation(reader, 1);
                GraphWithRepresentation graph2 = new GraphWithRepresentation(reader, 2);

                return (graph1, graph2);
            }
            return (null, null);
        }

        public void ErrorHandle() => MessageBox.Show("Nie udało się wczytać pliku.\nUpewnij się, że wybrany plik ma dobry format.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}