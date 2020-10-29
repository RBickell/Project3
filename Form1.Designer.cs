namespace Project3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstWordLabel = new System.Windows.Forms.Label();
            this.LastWordLabel = new System.Windows.Forms.Label();
            this.FirstWordTextBox = new System.Windows.Forms.TextBox();
            this.LastWordTextBox = new System.Windows.Forms.TextBox();
            this.LongestWordLabel = new System.Windows.Forms.Label();
            this.WordVowelLabel = new System.Windows.Forms.Label();
            this.LongWordTextBox = new System.Windows.Forms.TextBox();
            this.VWordTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.DGVInput = new System.Windows.Forms.DataGridView();
            this.DGVWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumVowel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInput)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstWordLabel
            // 
            this.FirstWordLabel.AutoSize = true;
            this.FirstWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstWordLabel.Location = new System.Drawing.Point(95, 100);
            this.FirstWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstWordLabel.Name = "FirstWordLabel";
            this.FirstWordLabel.Size = new System.Drawing.Size(143, 20);
            this.FirstWordLabel.TabIndex = 1;
            this.FirstWordLabel.Text = "First Word (A-Z):";
            // 
            // LastWordLabel
            // 
            this.LastWordLabel.AutoSize = true;
            this.LastWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastWordLabel.Location = new System.Drawing.Point(95, 148);
            this.LastWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastWordLabel.Name = "LastWordLabel";
            this.LastWordLabel.Size = new System.Drawing.Size(142, 20);
            this.LastWordLabel.TabIndex = 2;
            this.LastWordLabel.Text = "Last Word (A-Z):";
            // 
            // FirstWordTextBox
            // 
            this.FirstWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstWordTextBox.Location = new System.Drawing.Point(268, 97);
            this.FirstWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstWordTextBox.Name = "FirstWordTextBox";
            this.FirstWordTextBox.Size = new System.Drawing.Size(148, 26);
            this.FirstWordTextBox.TabIndex = 3;
            // 
            // LastWordTextBox
            // 
            this.LastWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastWordTextBox.Location = new System.Drawing.Point(268, 145);
            this.LastWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastWordTextBox.Name = "LastWordTextBox";
            this.LastWordTextBox.Size = new System.Drawing.Size(148, 26);
            this.LastWordTextBox.TabIndex = 4;
            // 
            // LongestWordLabel
            // 
            this.LongestWordLabel.AutoSize = true;
            this.LongestWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongestWordLabel.Location = new System.Drawing.Point(111, 216);
            this.LongestWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LongestWordLabel.Name = "LongestWordLabel";
            this.LongestWordLabel.Size = new System.Drawing.Size(126, 20);
            this.LongestWordLabel.TabIndex = 5;
            this.LongestWordLabel.Text = "Longest Word:";
            // 
            // WordVowelLabel
            // 
            this.WordVowelLabel.AutoSize = true;
            this.WordVowelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordVowelLabel.Location = new System.Drawing.Point(57, 262);
            this.WordVowelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WordVowelLabel.Name = "WordVowelLabel";
            this.WordVowelLabel.Size = new System.Drawing.Size(180, 20);
            this.WordVowelLabel.TabIndex = 6;
            this.WordVowelLabel.Text = "Word w/ most vowels:";
            // 
            // LongWordTextBox
            // 
            this.LongWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongWordTextBox.Location = new System.Drawing.Point(268, 210);
            this.LongWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LongWordTextBox.Name = "LongWordTextBox";
            this.LongWordTextBox.Size = new System.Drawing.Size(148, 26);
            this.LongWordTextBox.TabIndex = 7;
            // 
            // VWordTextBox
            // 
            this.VWordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VWordTextBox.Location = new System.Drawing.Point(268, 256);
            this.VWordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.VWordTextBox.Name = "VWordTextBox";
            this.VWordTextBox.Size = new System.Drawing.Size(148, 26);
            this.VWordTextBox.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button3.Location = new System.Drawing.Point(194, 342);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 60);
            this.button3.TabIndex = 11;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.openFileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // DGVInput
            // 
            this.DGVInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInput.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGVWord,
            this.WordLength,
            this.NumVowel});
            this.DGVInput.Location = new System.Drawing.Point(566, 27);
            this.DGVInput.Name = "DGVInput";
            this.DGVInput.Size = new System.Drawing.Size(375, 505);
            this.DGVInput.TabIndex = 13;
            this.DGVInput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVInput_CellContentClick);
            // 
            // DGVWord
            // 
            this.DGVWord.DataPropertyName = "Words";
            this.DGVWord.HeaderText = "Words";
            this.DGVWord.Name = "DGVWord";
            // 
            // WordLength
            // 
            this.WordLength.DataPropertyName = "Length";
            this.WordLength.HeaderText = "Word Length";
            this.WordLength.Name = "WordLength";
            // 
            // NumVowel
            // 
            this.NumVowel.DataPropertyName = "Vowels";
            this.NumVowel.HeaderText = "Vowel";
            this.NumVowel.Name = "NumVowel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.DGVInput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.VWordTextBox);
            this.Controls.Add(this.LongWordTextBox);
            this.Controls.Add(this.WordVowelLabel);
            this.Controls.Add(this.LongestWordLabel);
            this.Controls.Add(this.LastWordTextBox);
            this.Controls.Add(this.FirstWordTextBox);
            this.Controls.Add(this.LastWordLabel);
            this.Controls.Add(this.FirstWordLabel);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FirstWordLabel;
        private System.Windows.Forms.Label LastWordLabel;
        private System.Windows.Forms.TextBox FirstWordTextBox;
        private System.Windows.Forms.TextBox LastWordTextBox;
        private System.Windows.Forms.Label LongestWordLabel;
        private System.Windows.Forms.Label WordVowelLabel;
        private System.Windows.Forms.TextBox LongWordTextBox;
        private System.Windows.Forms.TextBox VWordTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.DataGridView DGVInput;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn WordLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumVowel;
    }
}

