using System.Windows.Forms;

namespace TAiO
{
    public class TextPresenter
    {
        private readonly RichTextBox RichTextBox;
        public TextPresenter(RichTextBox richTextBox, int fontSize = 9)
        {
            RichTextBox = richTextBox;
            RichTextBox.Modified = false;
            RichTextBox.Font = new System.Drawing.Font("Calibri", fontSize);
        }

        public void AddTextLine(string text) => RichTextBox.Text += text + '\n';

        public void Clean() => RichTextBox.Text = string.Empty;
    }
}