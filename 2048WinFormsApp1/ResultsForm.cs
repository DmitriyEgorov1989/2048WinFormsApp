namespace _2048WinFormsApp
{
    public partial class ResultsForm : Form
    {
        private List<User> _users;
        private UsersResultStorage _fileProvider;
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            _fileProvider = new UsersResultStorage();
            _users = _fileProvider.GetResults();
            resultsDataGridView.DataSource = _users;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
