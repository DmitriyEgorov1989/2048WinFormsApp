namespace _2048WinFormsApp
{
    partial class MainForm
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
            gameLabel = new Label();
            nameTextBox = new TextBox();
            startButton = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem = new ToolStripMenuItem();
            rulesGameMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            resultMenuItem = new ToolStripMenuItem();
            resultsMenuItem = new ToolStripMenuItem();
            sizeNumericUpDown = new NumericUpDown();
            mapSizelabel = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sizeNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // gameLabel
            // 
            gameLabel.AutoSize = true;
            gameLabel.BackColor = Color.Chocolate;
            gameLabel.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            gameLabel.Location = new Point(183, 50);
            gameLabel.Name = "gameLabel";
            gameLabel.Size = new Size(106, 50);
            gameLabel.TabIndex = 0;
            gameLabel.Text = "2048";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(123, 135);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(282, 27);
            nameTextBox.TabIndex = 1;
            nameTextBox.Text = "Введите ваше имя";
            // 
            // startButton
            // 
            startButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            startButton.Location = new Point(146, 296);
            startButton.Name = "startButton";
            startButton.Size = new Size(214, 67);
            startButton.TabIndex = 2;
            startButton.Text = "Начать";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += StartButton_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(510, 28);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem
            // 
            toolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rulesGameMenuItem, exitMenuItem, resultMenuItem });
            toolStripMenuItem.Name = "toolStripMenuItem";
            toolStripMenuItem.Size = new Size(63, 24);
            toolStripMenuItem.Text = "меню";
            // 
            // rulesGameMenuItem
            // 
            rulesGameMenuItem.Name = "rulesGameMenuItem";
            rulesGameMenuItem.Size = new Size(224, 26);
            rulesGameMenuItem.Text = "Правила игры";
            rulesGameMenuItem.Click += RulesGameMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(224, 26);
            exitMenuItem.Text = "Выход";
            exitMenuItem.Click += ExitMenuItem_Click;
            // 
            // resultMenuItem
            // 
            resultMenuItem.Name = "resultMenuItem";
            resultMenuItem.Size = new Size(224, 26);
            resultMenuItem.Text = "Результаты";
            resultMenuItem.Click += ResultsMenuItem_Click;
            // 
            // resultsMenuItem
            // 
            resultsMenuItem.Name = "resultsMenuItem";
            resultsMenuItem.Size = new Size(239, 26);
            resultsMenuItem.Text = "История результатов";
            resultsMenuItem.Click += ResultsMenuItem_Click;
            // 
            // sizeNumericUpDown
            // 
            sizeNumericUpDown.Location = new Point(179, 241);
            sizeNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            sizeNumericUpDown.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            sizeNumericUpDown.Name = "sizeNumericUpDown";
            sizeNumericUpDown.Size = new Size(150, 27);
            sizeNumericUpDown.TabIndex = 4;
            sizeNumericUpDown.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // mapSizelabel
            // 
            mapSizelabel.AutoSize = true;
            mapSizelabel.BackColor = SystemColors.ButtonShadow;
            mapSizelabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            mapSizelabel.Location = new Point(123, 185);
            mapSizelabel.Name = "mapSizelabel";
            mapSizelabel.Size = new Size(252, 31);
            mapSizelabel.TabIndex = 5;
            mapSizelabel.Text = "Введите размер поля";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(510, 442);
            Controls.Add(mapSizelabel);
            Controls.Add(sizeNumericUpDown);
            Controls.Add(startButton);
            Controls.Add(nameTextBox);
            Controls.Add(gameLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sizeNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label gameLabel;
        private TextBox nameTextBox;
        private Button startButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem;
        private ToolStripMenuItem rulesGameMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private ToolStripMenuItem resultsMenuItem;
        private NumericUpDown sizeNumericUpDown;
        private Label mapSizelabel;
        private ToolStripMenuItem resultMenuItem;
    }
}