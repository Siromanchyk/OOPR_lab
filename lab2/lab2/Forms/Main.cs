using lab2.Models;

namespace lab2
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facults f = new Facults();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Departments f = new Departments();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teachers t = new Teachers();
            t.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Abiturients a = new Abiturients();
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Disciplines a = new Disciplines();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Exams ex = new Exams();
            ex.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }


}