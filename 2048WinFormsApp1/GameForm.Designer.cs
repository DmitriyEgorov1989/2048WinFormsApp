
namespace _2048WinFormsApp
{
    partial class GameForm
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
            scoreLabel = new Label();
            maxScoreLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            stripMenuItem = new ToolStripMenuItem();
            restartMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Location = new Point(215, 29);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(17, 20);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "0";
            // 
            // maxScoreLabel
            // 
            maxScoreLabel.AutoSize = true;
            maxScoreLabel.Location = new Point(265, 29);
            maxScoreLabel.Name = "maxScoreLabel";
            maxScoreLabel.Size = new Size(17, 20);
            maxScoreLabel.TabIndex = 1;
            maxScoreLabel.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "Счет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 9);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "Топ";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { stripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(424, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // stripMenuItem
            // 
            stripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { restartMenuItem, exitMenuItem });
            stripMenuItem.Name = "stripMenuItem";
            stripMenuItem.Size = new Size(65, 24);
            stripMenuItem.Text = "Меню";
            // 
            // restartMenuItem
            // 
            restartMenuItem.Name = "restartMenuItem";
            restartMenuItem.Size = new Size(144, 26);
            restartMenuItem.Text = "Рестарт";
            restartMenuItem.Click += RestartMenuItem_Click;
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(144, 26);
            exitMenuItem.Text = "Выход";
            exitMenuItem.Click += ExitMenuItem_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 488);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(maxScoreLabel);
            Controls.Add(scoreLabel);
            Controls.Add(menuStrip1);
            Name = "GameForm";
            Text = "2048";
            Load += GameForm_Load;
            KeyDown += GameForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreLabel;
        private Label maxScoreLabel;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem stripMenuItem;
        private ToolStripMenuItem restartMenuItem;
        private ToolStripMenuItem exitMenuItem;
    }
}