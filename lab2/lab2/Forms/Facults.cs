using lab2.Models;

namespace lab2
{
    public partial class Facults : Form
    {
        public static List<Faculty> facultyList = new List<Faculty>();
        public Facults()
        {
            InitializeComponent();
        }

        private void Facults_Load(object sender, EventArgs e) { }

        void WriteToFile()
        {
            using (StreamWriter sw = new StreamWriter("Facults.txt", true))
            {
                sw.WriteLine($"{textBox1.Text} {textBox2.Text} {textBox3.Text}");
            }
        }
        void ReadFromFileAndPrint()
        {
            using (StreamReader sr = new StreamReader("Facults.txt", true))
            {
                string ln;
                while ((ln = sr.ReadLine()) != null)
                {
                    facultyList.Add(new Faculty(ln.Split(" ")[0]));
                    dataGridView1.Rows.Add(ln.Split(" ")[0], ln.Split(" ")[1], ln.Split(" ")[2]);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Введіть назву факультету, який Ви хочете створити");
            }
            else
            {
                WriteToFile();
                //facultyList.Add(new Faculty(textBox1.Text));
                MessageBox.Show($"Факультет {textBox1.Text} успішно доданий");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadFromFileAndPrint();
        }
    }
}