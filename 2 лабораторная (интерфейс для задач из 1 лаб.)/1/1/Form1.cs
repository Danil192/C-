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
            for (int i = 0; i < 2; i++) // ���������� �������� �������� � ���� �������, ������ �������� 1 ������� �� 2 ����� for
            {
                pr = min[0] * min[1]; // �������� ����������� 
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
            Properties.Settings.Default.Save(); // ��������� ���������� ��������
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
    public class Logic // ����� ��� ����� ������� ������
    {
        public static int[] ZadachaFirts_FindMin(int chislo_1, int chislo_2, int chislo_3) // ����� ���������� ������������ ����� ��� ������ ������
        {

            int min1 = 0, min2 = 0;

            // ������� ���������, � ������ ��������� ���� �����, ��������� ��������������� ����������

            if ((chislo_1 == chislo_2) && (chislo_2 == chislo_3))
            {
                Console.WriteLine("����� �����, ������� ������ �����");
                return null;
            }
            else
            {
                //������� ���������� ����������� �����

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
            int[] min = { min1, min2 }; //���������� ���������� ����������� ����� � ������

            return min; // ������ ������ � ���� ���� ���������� ����� � �������� ��� � ����� calculate_proizv ��� 
        }

        public static int calculate_proizv(int[] min) // ����� ��� ���������� ����������� ����������� �����
        {
            if (min == null) // ������� �������� �� ������� �������, � ������ ������ ����� ������ true
            {
                Console.WriteLine("����������� ����� �����������");
                return 1;
            }
            else
            {
                int proizvedenie = 0;
                for (int i = 0; i < 2; i++) // ���������� �������� �������� � ���� �������, ������ �������� 1 ������� �� 2 ����� for
                {
                    proizvedenie = min[0] * min[1]; // �������� ����������� 
                }
                return proizvedenie; // ���������� ������������ � ������� ������������
            }
        }

    }

    /* �� 1 ������������
     class Program // ����� ��� �������������� � �������������
{
    private static int chislo_1, chislo_2, chislo_3;

    private static int min1;
    private static int min2;

    private static void Main() // ����� (�����) ����� � ���������
    {
        Console.WriteLine("������� 3 �����: ");
        chislo_1 = Convert.ToInt32(Console.ReadLine());
        if (chislo_1 == null)
        {
            Console.WriteLine("����� ������ �����");
        }
        chislo_2 = Convert.ToInt32(Console.ReadLine());
        chislo_3 = Convert.ToInt32(Console.ReadLine());
        int[] min = Logic.ZadachaFirts_FindMin(chislo_1, chislo_2, chislo_3);
        Console.Write($"����������� �����: ");
        for (int i = 0; i < 2; i++)
        {
            Console.Write(min[i] + " ");
        }
        int proizvedenie = Logic.calculate_proizv(min);
        Console.WriteLine($"������������ ����������� �����: {proizvedenie}");
    }
}
     */
}