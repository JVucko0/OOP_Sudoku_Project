namespace Sudoku
{
    partial class SudokuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudokuForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            b6 = new Button();
            b5 = new Button();
            b4 = new Button();
            b9 = new Button();
            b8 = new Button();
            b7 = new Button();
            ClearButton = new Button();
            newGame = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            mistakeLabel = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newSudokuToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            hToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            hintButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111088F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.Location = new Point(41, 47);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111116F));
            tableLayoutPanel1.Size = new Size(540, 540);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // b1
            // 
            b1.BackColor = Color.LightBlue;
            b1.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            b1.ForeColor = Color.RoyalBlue;
            b1.Location = new Point(669, 296);
            b1.Name = "b1";
            b1.Size = new Size(75, 75);
            b1.TabIndex = 1;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = false;
            b1.Click += NumberButton_Click;
            // 
            // b2
            // 
            b2.BackColor = Color.LightBlue;
            b2.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            b2.ForeColor = Color.RoyalBlue;
            b2.Location = new Point(750, 296);
            b2.Name = "b2";
            b2.Size = new Size(75, 75);
            b2.TabIndex = 2;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = false;
            b2.Click += NumberButton_Click;
            // 
            // b3
            // 
            b3.BackColor = Color.LightBlue;
            b3.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            b3.ForeColor = Color.RoyalBlue;
            b3.Location = new Point(831, 296);
            b3.Name = "b3";
            b3.Size = new Size(75, 75);
            b3.TabIndex = 3;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = false;
            b3.Click += NumberButton_Click;
            // 
            // b6
            // 
            b6.BackColor = Color.LightBlue;
            b6.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            b6.ForeColor = Color.RoyalBlue;
            b6.Location = new Point(831, 377);
            b6.Name = "b6";
            b6.Size = new Size(75, 75);
            b6.TabIndex = 6;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = false;
            b6.Click += NumberButton_Click;
            // 
            // b5
            // 
            b5.BackColor = Color.LightBlue;
            b5.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            b5.ForeColor = Color.RoyalBlue;
            b5.Location = new Point(750, 377);
            b5.Name = "b5";
            b5.Size = new Size(75, 75);
            b5.TabIndex = 5;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = false;
            b5.Click += NumberButton_Click;
            // 
            // b4
            // 
            b4.BackColor = Color.LightBlue;
            b4.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            b4.ForeColor = Color.RoyalBlue;
            b4.Location = new Point(669, 377);
            b4.Name = "b4";
            b4.Size = new Size(75, 75);
            b4.TabIndex = 4;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = false;
            b4.Click += NumberButton_Click;
            // 
            // b9
            // 
            b9.BackColor = Color.LightBlue;
            b9.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            b9.ForeColor = Color.RoyalBlue;
            b9.Location = new Point(831, 458);
            b9.Name = "b9";
            b9.Size = new Size(75, 75);
            b9.TabIndex = 9;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = false;
            b9.Click += NumberButton_Click;
            // 
            // b8
            // 
            b8.BackColor = Color.LightBlue;
            b8.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            b8.ForeColor = Color.RoyalBlue;
            b8.Location = new Point(750, 458);
            b8.Name = "b8";
            b8.Size = new Size(75, 75);
            b8.TabIndex = 8;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = false;
            b8.Click += NumberButton_Click;
            // 
            // b7
            // 
            b7.BackColor = Color.LightBlue;
            b7.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            b7.ForeColor = Color.RoyalBlue;
            b7.Location = new Point(669, 458);
            b7.Name = "b7";
            b7.Size = new Size(75, 75);
            b7.TabIndex = 7;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = false;
            b7.Click += NumberButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.Location = new Point(800, 554);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(74, 33);
            ClearButton.TabIndex = 11;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // newGame
            // 
            newGame.BackColor = Color.CornflowerBlue;
            newGame.Font = new Font("Cooper Black", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            newGame.ForeColor = Color.White;
            newGame.Location = new Point(669, 214);
            newGame.Name = "newGame";
            newGame.Size = new Size(237, 73);
            newGame.TabIndex = 12;
            newGame.Text = "New Game";
            newGame.UseVisualStyleBackColor = false;
            newGame.Click += newGame_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(689, 170);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(773, 170);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 14;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(860, 170);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 15;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(669, 134);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 16;
            label1.Text = "Easy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(739, 134);
            label2.Name = "label2";
            label2.Size = new Size(86, 23);
            label2.TabIndex = 17;
            label2.Text = "Medium";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(840, 134);
            label3.Name = "label3";
            label3.Size = new Size(56, 23);
            label3.TabIndex = 18;
            label3.Text = "Hard";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(669, 82);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 19;
            label4.Text = "Mistakes: ";
            // 
            // mistakeLabel
            // 
            mistakeLabel.AutoSize = true;
            mistakeLabel.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            mistakeLabel.Location = new Point(762, 82);
            mistakeLabel.Name = "mistakeLabel";
            mistakeLabel.Size = new Size(0, 23);
            mistakeLabel.TabIndex = 20;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(962, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newSudokuToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newSudokuToolStripMenuItem
            // 
            newSudokuToolStripMenuItem.Name = "newSudokuToolStripMenuItem";
            newSudokuToolStripMenuItem.Size = new Size(98, 22);
            newSudokuToolStripMenuItem.Text = "&New";
            newSudokuToolStripMenuItem.Click += saveSudokuToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(98, 22);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(98, 22);
            exitToolStripMenuItem.Text = "&Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hToolStripMenuItem, aboutToolStripMenuItem1 });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // hToolStripMenuItem
            // 
            hToolStripMenuItem.Name = "hToolStripMenuItem";
            hToolStripMenuItem.Size = new Size(180, 22);
            hToolStripMenuItem.Text = "What is Sud&oku?";
            hToolStripMenuItem.Click += hToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(180, 22);
            aboutToolStripMenuItem1.Text = "&About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
            // 
            // hintButton
            // 
            hintButton.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hintButton.Location = new Point(696, 554);
            hintButton.Name = "hintButton";
            hintButton.Size = new Size(74, 33);
            hintButton.TabIndex = 22;
            hintButton.Text = "Hint";
            hintButton.UseVisualStyleBackColor = true;
            hintButton.Click += hintButton_Click;
            // 
            // SudokuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(962, 619);
            Controls.Add(hintButton);
            Controls.Add(mistakeLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(newGame);
            Controls.Add(ClearButton);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SudokuForm";
            Text = "Sudoku";
            Load += SudokuForm_Load;
            KeyPress += SudokuForm_KeyPress;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button b9;
        private Button b8;
        private Button b7;
        private Button ClearButton;
        private Button newGame;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label mistakeLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newSudokuToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button hintButton;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem hToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
    }
}