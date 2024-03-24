using System.Web;

namespace _2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            sent.Text = Properties.Settings.Default.sent.ToString();
            proc_sumbol.Text = Properties.Settings.Default.proc_sumbol.ToString();
            duble.Text = Properties.Settings.Default.duble.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sent;

            try
            {
                sent = this.sent.Text;
            }
            catch (FormatException)
            {
                return;
            }

            this.duble.Text = sent;

            float proc = Logic.ZadachaStr(sent);

            this.proc_sumbol.Text = proc.ToString();

            this.label4.Visible = true;
            this.proc_sumbol.Visible = true;
            this.duble.Visible = true;

            this.sent.Clear();

            Properties.Settings.Default.duble = sent;
            Properties.Settings.Default.proc_sumbol = proc.ToString();
            Properties.Settings.Default.sent = sent;
            Properties.Settings.Default.Save(); // сохраняем переданные значения, чтобы они восстановились пре очередном запуске

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font, FontStyle.Regular);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font, FontStyle.Bold);
        }
    }
    public class Logic // Класс логики для декомпозиции кода
    {
        public static float ZadachaStr(string sentence) // Метод для решения задачи со строками (нахождение % букв в предложении)
        {
            if (string.IsNullOrEmpty(sentence)) // Проверка предложения на пустоту или null
            {
                Console.WriteLine("Пустая строка");
                return 0; // Возвращаем 0, так как процент не может быть рассчитан
            }

            float vsego_bukv = 0; // Количество букв
            float lenght = sentence.Length; // Общее количество символов в строке, включая пробелы и знаки пунктуации

            foreach (char c in sentence) // Перебираем каждый символ нашей строки
            {
                if (Char.IsLetter(c)) // Если символ это буква, увеличиваем счетчик букв
                {
                    vsego_bukv++;
                }
            }

            float procent_bukv = (vsego_bukv / lenght) * 100; // Вычисляем процент букв от общего числа символов
            return procent_bukv; // Возвращаем значение процента букв
        }
    }
}