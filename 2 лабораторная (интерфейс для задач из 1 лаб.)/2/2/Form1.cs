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
            Properties.Settings.Default.Save(); // ��������� ���������� ��������, ����� ��� �������������� ��� ��������� �������

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
    public class Logic // ����� ������ ��� ������������ ����
    {
        public static float ZadachaStr(string sentence) // ����� ��� ������� ������ �� �������� (���������� % ���� � �����������)
        {
            if (string.IsNullOrEmpty(sentence)) // �������� ����������� �� ������� ��� null
            {
                Console.WriteLine("������ ������");
                return 0; // ���������� 0, ��� ��� ������� �� ����� ���� ���������
            }

            float vsego_bukv = 0; // ���������� ����
            float lenght = sentence.Length; // ����� ���������� �������� � ������, ������� ������� � ����� ����������

            foreach (char c in sentence) // ���������� ������ ������ ����� ������
            {
                if (Char.IsLetter(c)) // ���� ������ ��� �����, ����������� ������� ����
                {
                    vsego_bukv++;
                }
            }

            float procent_bukv = (vsego_bukv / lenght) * 100; // ��������� ������� ���� �� ������ ����� ��������
            return procent_bukv; // ���������� �������� �������� ����
        }
    }
}