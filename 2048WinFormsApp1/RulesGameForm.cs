namespace _2048WinFormsApp
{
    public partial class RulesGameForm : Form
    {
        public RulesGameForm()
        {
            InitializeComponent();
        }
        private void RulesGameForm_Load(object sender, EventArgs e)
        {
            rulesRichTextBox.ReadOnly = true;
            rulesRichTextBox.Text =
            "1.Сетка: Игра проходит на квадратной сетке размером 4x4(обычно).\n" +
 "2.Начинается с двумя плитками(2 или 4)\n" +
 "3.Перемещайте плитки вверх,вниз,влево,вправо.\n" +
 "4.Объединяйте плитки с одинаковыми числами.\n" +
 "5.После каждого хода появляется новая плитка.\n" +
 "6.Цель - создать плитку с числом 2048.\n" +
 "7.Игра заканчивается,когда нет доступных ходов.\n";
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}