namespace _2048WinFormsApp
{
    public partial class GameForm : Form
    {
        private int _mapSize;
        private Label[,] _labelsMap;
        private static Random _random = new Random();
        private int _score = 0;
        private User _user;
        private List<User> _users = [];
        private UsersResultStorage _usersResultStorage = new UsersResultStorage();
        private int _cellSize = 70;
        public GameForm(string _name, int mapsize)
        {
            InitializeComponent();
            _user = new User(_name, _score)
            {
                Name = _name
            };
            _mapSize = mapsize;
            LoadSizeForm();
        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            InitMap();
            LoadForm();
            UpCellsColor(_labelsMap);
            GenerateNumber();
            ShowScore();
        }
        private Label CreateMap(int indexRow, int indexColumn)
        {
            var label = new Label
            {
                BackColor = Color.LightGray,
                Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204),
                Size = new Size(70, 70),
                TextAlign = ContentAlignment.MiddleCenter
            };
            var startX = 10;
            var cellSpacing = 6;
            var x = startX + (indexColumn * (_cellSize + cellSpacing));
            var y = _cellSize + (indexRow * (_cellSize + cellSpacing));
            label.Location = new Point(x, y);
            return label;
        }
        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            var isMoved = false;
            if (e.KeyCode == Keys.Right)
            {
                isMoved = true;
                for (int i = 0; i < _mapSize; i++)
                {
                    for (int j = _mapSize - 1; j >= 0; j--)
                    {
                        if (_labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (_labelsMap[i, k].Text != string.Empty)
                                {
                                    if (_labelsMap[i, j].Text == _labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(_labelsMap[i, j].Text);
                                        _user.Score += number * 2;
                                        _labelsMap[i, j].Text = (number * 2).ToString();
                                        _labelsMap[i, k].Text = string.Empty;
                                    }
                                    break;
                                }
                            }

                        }
                    }
                }
            }
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = _mapSize - 1; j > 0; j--)
                {
                    if (_labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k > 0; k--)
                        {
                            if (_labelsMap[i, k].Text != string.Empty)
                            {
                                _labelsMap[i, j].Text = _labelsMap[i, k].Text;
                                _labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Left)
            {
                isMoved = true;
                for (int i = 0; i < _mapSize; i++)
                {
                    for (int j = 0; j < _mapSize; j++)
                    {
                        if (_labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < _mapSize; k++)
                            {
                                if (_labelsMap[i, k].Text != string.Empty)
                                {
                                    if (_labelsMap[i, j].Text == _labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(_labelsMap[i, j].Text);
                                        _user.Score += number * 2;
                                        _labelsMap[i, j].Text = (number * 2).ToString();
                                        _labelsMap[i, k].Text = string.Empty;
                                    }
                                    break;
                                }
                            }

                        }
                    }
                }
                for (int i = 0; i < _mapSize; i++)
                {
                    for (int j = 0; j < _mapSize; j++)
                    {
                        if (_labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < _mapSize; k++)
                            {
                                if (_labelsMap[i, k].Text != string.Empty)
                                {
                                    _labelsMap[i, j].Text = _labelsMap[i, k].Text;
                                    _labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                isMoved = true;
                for (int j = 0; j < _mapSize; j++)
                {
                    for (int i = 0; i < _mapSize; i++)
                    {
                        if (_labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i + 1; k < _mapSize; k++)
                            {
                                if (_labelsMap[k, j].Text != string.Empty)
                                {
                                    if (_labelsMap[i, j].Text == _labelsMap[k, j].Text)
                                    {
                                        var number = int.Parse(_labelsMap[i, j].Text);
                                        _user.Score += number * 2;
                                        _labelsMap[i, j].Text = (number * 2).ToString();
                                        _labelsMap[k, j].Text = string.Empty;
                                    }
                                    break;
                                }
                            }

                        }
                    }
                }
                for (int j = 0; j < _mapSize; j++)
                {
                    for (int i = 0; i < _mapSize; i++)
                    {
                        if (_labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i + 1; k < _mapSize; k++)
                            {
                                if (_labelsMap[k, j].Text != string.Empty)
                                {
                                    _labelsMap[i, j].Text = _labelsMap[k, j].Text;
                                    _labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                isMoved = true;
                for (int j = 0; j < _mapSize; j++)
                {
                    for (int i = _mapSize - 1; i >= 0; i--)
                    {
                        if (_labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (_labelsMap[k, j].Text != string.Empty)
                                {
                                    if (_labelsMap[i, j].Text == _labelsMap[k, j].Text)
                                    {
                                        var number = int.Parse(_labelsMap[i, j].Text);
                                        _user.Score += number * 2;
                                        _labelsMap[i, j].Text = (number * 2).ToString();
                                        _labelsMap[k, j].Text = string.Empty;
                                    }
                                    break;
                                }
                            }

                        }
                    }
                }
                for (int j = 0; j < _mapSize; j++)
                {
                    for (int i = _mapSize - 1; i >= 0; i--)
                    {
                        if (_labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (_labelsMap[k, j].Text != string.Empty)
                                {
                                    _labelsMap[i, j].Text = _labelsMap[k, j].Text;
                                    _labelsMap[k, j].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (isMoved)
            {
                GenerateNumber();
                UpCellsColor(_labelsMap);
                ShowScore();
            }
            if (IsEndGame())
            {
                MessageBox.Show("Вы проиграли!");
                SaveAllResults(); ;
                Close();
            }
        }
        private void LoadSizeForm()
        {
            var horizontalSpacing = 15;
            var verticalSpacing = 40;
            Width = _mapSize * (_cellSize + horizontalSpacing);
            Height = _mapSize * (_cellSize + verticalSpacing);
        }
        private void LoadForm()
        {
            maxScoreLabel.Text = _usersResultStorage.GetMaxScore();
            _users = _usersResultStorage.GetResults();
        }
        private void SaveAllResults()
        {
            FileProvider.Write(_usersResultStorage._maxScoreFile, maxScoreLabel.Text);
            _users.Add(_user);
            _usersResultStorage.SaveResults(_usersResultStorage._resultsFile, _users);
        }
        private void InitMap()
        {
            _labelsMap = new Label[_mapSize, _mapSize];
            {
                for (int i = 0; i < _mapSize; i++)
                {
                    for (int j = 0; j < _mapSize; j++)
                    {
                        var newLabel = CreateMap(i, j);
                        _labelsMap[i, j] = newLabel;
                        Controls.Add(newLabel);
                    }
                }
            }
        }
        private void GenerateNumber()
        {
            var emptyCells = false;
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                    if (_labelsMap[i, j].Text == string.Empty)
                    {
                        emptyCells = true;
                        break;
                    }
                }
                if (emptyCells)
                {
                    break;
                }
            }
            if (!emptyCells)
            {
                return;
            }
            while (true)
            {
                var randomNumberLabel = _random.Next(_mapSize * _mapSize);
                var indexRow = randomNumberLabel / _mapSize;
                var indexColumn = randomNumberLabel % _mapSize;
                if (_labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    var randomIndex = _random.Next(0, 100);
                    _labelsMap[indexRow, indexColumn].Text = randomIndex <= 75 ? "2" : "4";
                    break;
                }
            }
        }
        private void ShowScore()
        {
            scoreLabel.Text = _user.Score.ToString();
            if (int.Parse(scoreLabel.Text) > int.Parse(maxScoreLabel.Text))
            {
                maxScoreLabel.Text = _user.Score.ToString();
            }
        }
        private void UpCellsColor(Label[,] _labelsMap)
        {
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                    var value = _labelsMap[i, j].Text;
                    switch (value)
                    {
                        case "2": _labelsMap[i, j].BackColor = Color.LightYellow; break;
                        case "4": _labelsMap[i, j].BackColor = Color.Lime; break;
                        case "8": _labelsMap[i, j].BackColor = Color.Yellow; break;
                        case "16": _labelsMap[i, j].BackColor = Color.YellowGreen; break;
                        case "32": _labelsMap[i, j].BackColor = Color.LimeGreen; break;
                        case "64": _labelsMap[i, j].BackColor = Color.GreenYellow; break;
                        case "128": _labelsMap[i, j].BackColor = Color.Green; break;
                        case "512": _labelsMap[i, j].BackColor = Color.Orange; break;
                        case "1024": _labelsMap[i, j].BackColor = Color.OrangeRed; break;
                        case "2048": _labelsMap[i, j].BackColor = Color.Red; break;
                        default: _labelsMap[i, j].BackColor = Color.LightGray; break;
                    }
                }
            }
        }
        private bool IsEndGame()
        {
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                    if (_labelsMap[i, j].Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            for (int i = 0; i < _mapSize; i++)
            {
                for (int j = 0; j < _mapSize; j++)
                {
                    if (i < _mapSize - 1 && _labelsMap[i, j].Text == _labelsMap[i + 1, j].Text)
                    {
                        return false;
                    }
                    if (j < _mapSize - 1 && _labelsMap[i, j].Text == _labelsMap[i, j + 1].Text)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void RestartMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}