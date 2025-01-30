namespace _2048WinFormsApp
{
    public class User
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public User(string _name, int _score)
        {
            Name = _name;
            Score = _score;
        }
    }
}
