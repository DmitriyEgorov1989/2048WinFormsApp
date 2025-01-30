namespace _2048WinFormsApp
{
    partial class ResultsForm
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
            resultsDataGridView = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            ScoreColumn = new DataGridViewTextBoxColumn();
            resultsabel = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { NameColumn, ScoreColumn });
            resultsDataGridView.Location = new Point(12, 50);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.RowHeadersWidth = 51;
            resultsDataGridView.Size = new Size(655, 357);
            resultsDataGridView.TabIndex = 0;
            // 
            // NameColumn
            // 
            NameColumn.DataPropertyName = "Name";
            NameColumn.HeaderText = "Имя";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 300;
            // 
            // ScoreColumn
            // 
            ScoreColumn.DataPropertyName = "Score";
            ScoreColumn.HeaderText = "Очки";
            ScoreColumn.MinimumWidth = 6;
            ScoreColumn.Name = "ScoreColumn";
            ScoreColumn.Width = 300;
            // 
            // resultsabel
            // 
            resultsabel.AutoSize = true;
            resultsabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            resultsabel.Location = new Point(287, 9);
            resultsabel.Name = "resultsabel";
            resultsabel.Size = new Size(219, 28);
            resultsabel.TabIndex = 1;
            resultsabel.Text = "История результатов";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(587, 8);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 2;
            exitButton.Text = "Выход";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 437);
            Controls.Add(exitButton);
            Controls.Add(resultsabel);
            Controls.Add(resultsDataGridView);
            Name = "ResultsForm";
            Text = "Просмотр_результатов";
            Load += ResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView resultsDataGridView;
        private Label resultsabel;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ScoreColumn;
        private Button exitButton;
    }
}