using Newtonsoft.Json;

namespace _2048WinFormsApp
{
    internal class UsersResultStorage
    {
        public readonly string _maxScoreFile = "maxScore.txt";
        public readonly string _resultsFile = "results.json";

        public List<User> GetResults()
        {
            if (!File.Exists(_resultsFile))
            {
                FileProvider.Write(_resultsFile, "[]");
            }
            var fileData = FileProvider.Read(_resultsFile);

            var list = JsonConvert.DeserializeObject<List<User>>(fileData);

            return list;
        }
        public string GetMaxScore()
        {
            if (!File.Exists(_maxScoreFile))
            {
                FileProvider.Write(_maxScoreFile, "0");
            }
            return FileProvider.Read(_maxScoreFile);
        }
        public void SaveResults(string _resultsFile, List<User> _users)
        {
            var dataLine = JsonConvert.SerializeObject(_users, Formatting.Indented);
            FileProvider.Write(_resultsFile, dataLine);
        }
    }
}
