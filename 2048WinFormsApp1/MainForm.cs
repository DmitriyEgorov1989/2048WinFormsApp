namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private string _rightUsername = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }
        private void RulesGameMenuItem_Click(object sender, EventArgs e)
        {
            var rulesGameForm = new RulesGameForm();
            rulesGameForm.ShowDialog();
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            _rightUsername = nameTextBox.Text;

            if (string.IsNullOrEmpty(_rightUsername))
            {
                MessageBox.Show("Пожалуйста,введите корректное имя пользователя!");
                nameTextBox.Clear();
                return;
            }
            for (int i = 0; i < _rightUsername.Length; i++)
            {
                if (!char.IsLetter(_rightUsername[i]))
                {
                    MessageBox.Show("Пожалуйста,введите корректное имя пользователя!");
                    nameTextBox.Clear();
                    return;
                }
            }
            var gameForm = new GameForm(_rightUsername, int.Parse(sizeNumericUpDown.Text));
            gameForm.ShowDialog();
        }
        private void ResultsMenuItem_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultsForm(); resultsForm.ShowDialog();
        }
    }
}