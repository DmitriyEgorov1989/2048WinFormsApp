namespace _2048WinFormsApp
{
    internal class FileProvider
    {
        public static string Read(string file)
        {
            return File.ReadAllText(file);
        }
        public static void Write(string file, string line)
        {
            File.WriteAllText(file, line);
        }
        public static void Append(string file, string addedText)
        {
            File.AppendAllText(file, addedText);
        }
    }
}
