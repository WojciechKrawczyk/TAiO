
namespace TAiO
{
    partial class ProjectForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReadFileButton = new System.Windows.Forms.Button();
            this.StartCalculationsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RichTextBoxComments = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxGraph1 = new System.Windows.Forms.RichTextBox();
            this.RichtextBoxGraph2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelTimeResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelCalculationsResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReadFileButton
            // 
            this.ReadFileButton.Location = new System.Drawing.Point(12, 12);
            this.ReadFileButton.Name = "ReadFileButton";
            this.ReadFileButton.Size = new System.Drawing.Size(161, 29);
            this.ReadFileButton.TabIndex = 0;
            this.ReadFileButton.Text = "Wczytaj plik";
            this.ReadFileButton.UseVisualStyleBackColor = true;
            this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButtonClick);
            // 
            // StartCalculationsButton
            // 
            this.StartCalculationsButton.Location = new System.Drawing.Point(179, 12);
            this.StartCalculationsButton.Name = "StartCalculationsButton";
            this.StartCalculationsButton.Size = new System.Drawing.Size(161, 29);
            this.StartCalculationsButton.TabIndex = 1;
            this.StartCalculationsButton.Text = "Wykonaj obliczenia";
            this.StartCalculationsButton.UseVisualStyleBackColor = true;
            this.StartCalculationsButton.Click += new System.EventHandler(this.StartCalculationsButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Komentarze programu";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 361);
            this.textBox1.MaximumSize = new System.Drawing.Size(4, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 27);
            this.textBox1.TabIndex = 3;
            // 
            // RichTextBoxComments
            // 
            this.RichTextBoxComments.Location = new System.Drawing.Point(12, 538);
            this.RichTextBoxComments.Name = "RichTextBoxComments";
            this.RichTextBoxComments.Size = new System.Drawing.Size(705, 77);
            this.RichTextBoxComments.TabIndex = 4;
            this.RichTextBoxComments.Text = "";
            // 
            // RichTextBoxGraph1
            // 
            this.RichTextBoxGraph1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTextBoxGraph1.Location = new System.Drawing.Point(49, 103);
            this.RichTextBoxGraph1.Name = "RichTextBoxGraph1";
            this.RichTextBoxGraph1.Size = new System.Drawing.Size(295, 295);
            this.RichTextBoxGraph1.TabIndex = 5;
            this.RichTextBoxGraph1.Text = "";
            // 
            // RichtextBoxGraph2
            // 
            this.RichtextBoxGraph2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichtextBoxGraph2.Location = new System.Drawing.Point(385, 103);
            this.RichtextBoxGraph2.Name = "RichtextBoxGraph2";
            this.RichtextBoxGraph2.Size = new System.Drawing.Size(295, 295);
            this.RichtextBoxGraph2.TabIndex = 6;
            this.RichtextBoxGraph2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Graf 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Graf 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Czas obliczeń";
            // 
            // LabelTimeResult
            // 
            this.LabelTimeResult.AutoSize = true;
            this.LabelTimeResult.Location = new System.Drawing.Point(385, 425);
            this.LabelTimeResult.Name = "LabelTimeResult";
            this.LabelTimeResult.Size = new System.Drawing.Size(18, 20);
            this.LabelTimeResult.TabIndex = 10;
            this.LabelTimeResult.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Wynik";
            // 
            // LabelCalculationsResult
            // 
            this.LabelCalculationsResult.AutoSize = true;
            this.LabelCalculationsResult.Location = new System.Drawing.Point(385, 460);
            this.LabelCalculationsResult.Name = "LabelCalculationsResult";
            this.LabelCalculationsResult.Size = new System.Drawing.Size(18, 20);
            this.LabelCalculationsResult.TabIndex = 12;
            this.LabelCalculationsResult.Text = "...";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 627);
            this.Controls.Add(this.LabelCalculationsResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelTimeResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RichtextBoxGraph2);
            this.Controls.Add(this.RichTextBoxGraph1);
            this.Controls.Add(this.RichTextBoxComments);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartCalculationsButton);
            this.Controls.Add(this.ReadFileButton);
            this.Name = "ProjectForm";
            this.Text = "TAiO Podobieństwo grafów";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFileButton;
        private System.Windows.Forms.Button StartCalculationsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox RichTextBoxComments;
        private System.Windows.Forms.RichTextBox RichTextBoxGraph1;
        private System.Windows.Forms.RichTextBox RichtextBoxGraph2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelTimeResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelCalculationsResult;
    }
}

