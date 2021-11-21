
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RichTextBoxComments = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxGraph1 = new System.Windows.Forms.RichTextBox();
            this.RichtextBoxGraph2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelTimeResult = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelCalculationsResult = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RBPrecision = new System.Windows.Forms.RadioButton();
            this.RBLSAP = new System.Windows.Forms.RadioButton();
            this.RBNetworkX = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReadFileButton
            // 
            this.ReadFileButton.Location = new System.Drawing.Point(5, 43);
            this.ReadFileButton.Name = "ReadFileButton";
            this.ReadFileButton.Size = new System.Drawing.Size(161, 29);
            this.ReadFileButton.TabIndex = 0;
            this.ReadFileButton.Text = "Wczytaj plik";
            this.ReadFileButton.UseVisualStyleBackColor = true;
            this.ReadFileButton.Click += new System.EventHandler(this.ReadFileButtonClick);
            // 
            // StartCalculationsButton
            // 
            this.StartCalculationsButton.BackColor = System.Drawing.Color.Transparent;
            this.StartCalculationsButton.Location = new System.Drawing.Point(5, 78);
            this.StartCalculationsButton.Name = "StartCalculationsButton";
            this.StartCalculationsButton.Size = new System.Drawing.Size(161, 29);
            this.StartCalculationsButton.TabIndex = 1;
            this.StartCalculationsButton.Text = "Wykonaj obliczenia";
            this.StartCalculationsButton.UseVisualStyleBackColor = false;
            this.StartCalculationsButton.Click += new System.EventHandler(this.StartCalculationsButtonClick);
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
            this.RichTextBoxComments.Location = new System.Drawing.Point(6, 26);
            this.RichTextBoxComments.Name = "RichTextBoxComments";
            this.RichTextBoxComments.Size = new System.Drawing.Size(520, 126);
            this.RichTextBoxComments.TabIndex = 4;
            this.RichTextBoxComments.Text = "";
            // 
            // RichTextBoxGraph1
            // 
            this.RichTextBoxGraph1.BackColor = System.Drawing.Color.White;
            this.RichTextBoxGraph1.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichTextBoxGraph1.Location = new System.Drawing.Point(9, 27);
            this.RichTextBoxGraph1.Name = "RichTextBoxGraph1";
            this.RichTextBoxGraph1.ReadOnly = true;
            this.RichTextBoxGraph1.Size = new System.Drawing.Size(365, 270);
            this.RichTextBoxGraph1.TabIndex = 5;
            this.RichTextBoxGraph1.Text = "";
            // 
            // RichtextBoxGraph2
            // 
            this.RichtextBoxGraph2.BackColor = System.Drawing.Color.White;
            this.RichtextBoxGraph2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RichtextBoxGraph2.Location = new System.Drawing.Point(6, 26);
            this.RichtextBoxGraph2.Name = "RichtextBoxGraph2";
            this.RichtextBoxGraph2.ReadOnly = true;
            this.RichtextBoxGraph2.Size = new System.Drawing.Size(365, 270);
            this.RichtextBoxGraph2.TabIndex = 6;
            this.RichtextBoxGraph2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Czas obliczeń:";
            // 
            // LabelTimeResult
            // 
            this.LabelTimeResult.AutoSize = true;
            this.LabelTimeResult.Location = new System.Drawing.Point(178, 90);
            this.LabelTimeResult.Name = "LabelTimeResult";
            this.LabelTimeResult.Size = new System.Drawing.Size(15, 20);
            this.LabelTimeResult.TabIndex = 10;
            this.LabelTimeResult.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Podobieństwo grafów:";
            // 
            // LabelCalculationsResult
            // 
            this.LabelCalculationsResult.AutoSize = true;
            this.LabelCalculationsResult.Location = new System.Drawing.Point(178, 49);
            this.LabelCalculationsResult.Name = "LabelCalculationsResult";
            this.LabelCalculationsResult.Size = new System.Drawing.Size(15, 20);
            this.LabelCalculationsResult.TabIndex = 12;
            this.LabelCalculationsResult.Text = "-";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.menuStrip1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.helpToolStripMenuItem.Text = "Pomoc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReadFileButton);
            this.groupBox1.Controls.Add(this.StartCalculationsButton);
            this.groupBox1.Location = new System.Drawing.Point(24, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 133);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Działania";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RBPrecision);
            this.groupBox2.Controls.Add(this.RBLSAP);
            this.groupBox2.Controls.Add(this.RBNetworkX);
            this.groupBox2.Location = new System.Drawing.Point(241, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 133);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Algorytmy";
            // 
            // RBPrecision
            // 
            this.RBPrecision.AutoSize = true;
            this.RBPrecision.Location = new System.Drawing.Point(6, 78);
            this.RBPrecision.Name = "RBPrecision";
            this.RBPrecision.Size = new System.Drawing.Size(155, 24);
            this.RBPrecision.TabIndex = 19;
            this.RBPrecision.TabStop = true;
            this.RBPrecision.Text = "algorytm dokładny";
            this.RBPrecision.UseVisualStyleBackColor = true;
            this.RBPrecision.CheckedChanged += new System.EventHandler(this.RBPrecision_CheckedChanged);
            // 
            // RBLSAP
            // 
            this.RBLSAP.AutoSize = true;
            this.RBLSAP.Location = new System.Drawing.Point(6, 18);
            this.RBLSAP.Name = "RBLSAP";
            this.RBLSAP.Size = new System.Drawing.Size(269, 24);
            this.RBLSAP.TabIndex = 18;
            this.RBLSAP.TabStop = true;
            this.RBLSAP.Text = "algorytm aproksymacyjny LSAP GED";
            this.RBLSAP.UseVisualStyleBackColor = true;
            this.RBLSAP.CheckedChanged += new System.EventHandler(this.RBLSAP_CheckedChanged);
            // 
            // RBNetworkX
            // 
            this.RBNetworkX.AutoSize = true;
            this.RBNetworkX.Location = new System.Drawing.Point(6, 48);
            this.RBNetworkX.Name = "RBNetworkX";
            this.RBNetworkX.Size = new System.Drawing.Size(199, 24);
            this.RBNetworkX.TabIndex = 17;
            this.RBNetworkX.TabStop = true;
            this.RBNetworkX.Text = "algorytm aproksymacyjny";
            this.RBNetworkX.UseVisualStyleBackColor = true;
            this.RBNetworkX.CheckedChanged += new System.EventHandler(this.RBNetworkX_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Location = new System.Drawing.Point(18, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(787, 340);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Macierze incydencji wczytanych grafów";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.RichtextBoxGraph2);
            this.groupBox7.Location = new System.Drawing.Point(396, 26);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(383, 305);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Graf 2";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.RichTextBoxGraph1);
            this.groupBox6.Location = new System.Drawing.Point(6, 26);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(384, 305);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Graf 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.LabelTimeResult);
            this.groupBox4.Controls.Add(this.LabelCalculationsResult);
            this.groupBox4.Location = new System.Drawing.Point(560, 538);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 165);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Wyniki";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.RichTextBoxComments);
            this.groupBox5.Location = new System.Drawing.Point(18, 538);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(536, 165);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Przebieg obliczeń";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 705);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProjectForm";
            this.Text = "TAiO Podobieństwo grafów";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadFileButton;
        private System.Windows.Forms.Button StartCalculationsButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox RichTextBoxComments;
        private System.Windows.Forms.RichTextBox RichTextBoxGraph1;
        private System.Windows.Forms.RichTextBox RichtextBoxGraph2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelTimeResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelCalculationsResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBLSAP;
        private System.Windows.Forms.RadioButton RBNetworkX;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RBPrecision;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

