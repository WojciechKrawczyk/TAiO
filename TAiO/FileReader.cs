using System.IO;
using System.Windows.Forms;
using TAiO.Graphs;

namespace TAiO
{
    class FileReader
    {
        //private readonly string InitialDirectoryPath = "C:\\";
        private readonly string InitialDirectoryPath = "C:\\Users\\Dell\\Desktop\\TAiO-REPO\\TAiO\\Templates";

        public (GraphWithRepresentation graph1, GraphWithRepresentation graph2) ProccessFile()
        {
            using var fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = InitialDirectoryPath;
            fileDialog.Filter = "txt files (*.txt)|*.txt";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                using var reader = new StreamReader(fileDialog.OpenFile());
                GraphWithRepresentation graph1 = new GraphWithRepresentation(reader, 1);
                GraphWithRepresentation graph2 = new GraphWithRepresentation(reader, 2);

                return (graph1, graph2);
            }
            return (null, null);
        }
    }
}
