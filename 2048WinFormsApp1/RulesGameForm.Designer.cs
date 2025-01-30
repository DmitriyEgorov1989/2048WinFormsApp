namespace _2048WinFormsApp
{
    partial class RulesGameForm
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
            rulesRichTextBox = new RichTextBox();
            rulesGameLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // rulesRichTextBox
            // 
            rulesRichTextBox.Location = new Point(12, 67);
            rulesRichTextBox.Name = "rulesRichTextBox";
            rulesRichTextBox.Size = new Size(776, 356);
            rulesRichTextBox.TabIndex = 0;
            rulesRichTextBox.Text = "";
            // 
            // rulesGameLabel
            // 
            rulesGameLabel.AutoSize = true;
            rulesGameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            rulesGameLabel.Location = new Point(301, 23);
            rulesGameLabel.Name = "rulesGameLabel";
            rulesGameLabel.Size = new Size(177, 31);
            rulesGameLabel.TabIndex = 1;
            rulesGameLabel.Text = "Правила Игры";
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.ButtonShadow;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            exitButton.Location = new Point(311, 445);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(211, 49);
            exitButton.TabIndex = 2;
            exitButton.Text = "Главное меню";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += ExitButton_Click;
            // 
            // RulesGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 547);
            Controls.Add(exitButton);
            Controls.Add(rulesGameLabel);
            Controls.Add(rulesRichTextBox);
            Name = "RulesGameForm";
            Text = "RulesGameForm";
            Load += RulesGameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rulesRichTextBox;
        private Label rulesGameLabel;
        private Button exitButton;
    }
}