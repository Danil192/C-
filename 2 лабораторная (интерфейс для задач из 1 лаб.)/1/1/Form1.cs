namespace _1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            l1.Text = Properties.Settings.Default.l1.ToString();
            l2.Text = Properties.Settings.Default.l2.ToString();
            l3.Text = Properties.Settings.Default.l3.ToString();
            mins.Text = Properties.Settings.Default.mins.ToString();
            proizvedenie.Text = Properties.Settings.Default.proizvedenie.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int chislo_1, chislo_2, chislo_3;
            try
            {
                chislo_1 = int.Parse(this.textBox1.Text);
                chislo_2 = int.Parse(this.textBox2.Text);
                chislo_3 = int.Parse(this.textBox3.Text);
            }
            catch (FormatException)
            {
                return;
            }

            this.l1.Text = textBox1.Text;
            this.l2.Text = textBox2.Text;
            this.l3.Text = textBox3.Text;

            int[] min = Logic.ZadachaFirts_FindMin(chislo_1, chislo_2, chislo_3);

            this.mins.Text = string.Join(", ", min);

            int pr = 0;
            for (int i = 0; i < 2; i++) // минимльные элементы записаны в виде массива, просто умножаем 1 элемент на 2 через for
            {
                pr = min[0] * min[1]; // получаем произвеение 
            }

            this.proizvedenie.Text = pr.ToString();

            this.mins.Visible = true;
            this.proizvedenie.Visible = true;
            this.label5.Visible = true;
            this.label8.Visible = true;
            this.l1.Visible = true;
            this.l2.Visible = true;
            this.l3.Visible = true;

            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();

            Properties.Settings.Default.l1 = chislo_1;
            Properties.Settings.Default.l2 = chislo_2;
            Properties.Settings.Default.l3 = chislo_3;
            Properties.Settings.Default.proizvedenie = pr;
            Properties.Settings.Default.Save(); // сохраняем переданные значения
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font, FontStyle.Bold);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Font = new Font(button1.Font, FontStyle.Regular);
        }
    }
    public class Logic // класс где будем хранить логику
    {
        public static int[] ZadachaFirts_FindMin(int chislo_1, int chislo_2, int chislo_3) // метод нахождения минимального числа для первой задачи
        {

            int min1 = 0, min2 = 0;

            // условия равенства, в случае равенства всех чисел, выводится соответствующее сообщениеи

            if ((chislo_1 == chislo_2) && (chislo_2 == chislo_3))
            {
                Console.WriteLine("Числа равны, введите другие числа");
                return null;
            }
            else
            {
                //условия нахождения минимальных чисел

                if ((chislo_1 <= chislo_2) && (chislo_1 <= chislo_3))
                {
                    min1 = chislo_1;
                }

                if ((chislo_1 >= chislo_2) && (chislo_1 <= chislo_3))
                {
                    min1 = chislo_1;
                }

                if ((chislo_2 <= chislo_1) && (chislo_2 <= chislo_3))
                {
                    min2 = chislo_2;
                }

                if ((chislo_3 <= chislo_1) && (chislo_3 <= chislo_2))
                {
                    min1 = chislo_3;
                }

                if ((chislo_1 >= chislo_2) && (chislo_1 <= chislo_3))
                {
                    min2 = chislo_1;
                }

                if ((chislo_1 <= chislo_2) && (chislo_1 >= chislo_3))
                {
                    min2 = chislo_1;
                }

                if ((chislo_2 >= chislo_1) && (chislo_2 <= chislo_3))
                {
                    min2 = chislo_2;
                }

                if ((chislo_2 <= chislo_1) && (chislo_2 >= chislo_3))
                {
                    min2 = chislo_2;
                }

                if ((chislo_3 >= chislo_1) && (chislo_3 <= chislo_2))
                {
                    min2 = chislo_3;
                }

                if ((chislo_3 <= chislo_1) && (chislo_3 >= chislo_2))
                {
                    min2 = chislo_3;
                }
            }
            int[] min = { min1, min2 }; //записываем полученные минимальные числа в массив

            return min; // вернем массив в виде двух минимльных чисел и отправим его в метод calculate_proizv для 
        }

        public static int calculate_proizv(int[] min) // метод для нахождения произедения минимальных чисел
        {
            if (min == null) // условие проверки на пустоту массива, в случае пусоты метод вернет true
            {
                Console.WriteLine("Минимальные числа отсутствуют");
                return 1;
            }
            else
            {
                int proizvedenie = 0;
                for (int i = 0; i < 2; i++) // минимльные элементы записаны в виде массива, просто умножаем 1 элемент на 2 через for
                {
                    proizvedenie = min[0] * min[1]; // получаем произвеение 
                }
                return proizvedenie; // возвращаем произведение и выводим пользователю
            }
        }

    }

    /* ИЗ 1 ЛАБОРАТОРНОЙ
     class Program // класс для взаимодействия с пользователем
{
    private static int chislo_1, chislo_2, chislo_3;

    private static int min1;
    private static int min2;

    private static void Main() // точка (метод) входа в программу
    {
        Console.WriteLine("Введите 3 числа: ");
        chislo_1 = Convert.ToInt32(Console.ReadLine());
        if (chislo_1 == null)
        {
            Console.WriteLine("Нужно ввести число");
        }
        chislo_2 = Convert.ToInt32(Console.ReadLine());
        chislo_3 = Convert.ToInt32(Console.ReadLine());
        int[] min = Logic.ZadachaFirts_FindMin(chislo_1, chislo_2, chislo_3);
        Console.Write($"Минимальные числа: ");
        for (int i = 0; i < 2; i++)
        {
            Console.Write(min[i] + " ");
        }
        int proizvedenie = Logic.calculate_proizv(min);
        Console.WriteLine($"Произведение минимальных чисел: {proizvedenie}");
    }
}
     */
}