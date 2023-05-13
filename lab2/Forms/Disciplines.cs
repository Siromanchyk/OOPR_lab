using lab2.Models;

namespace lab2
{
    public partial class Disciplines : Form
    {
        public static List<Discipline> disciplinesList = new List<Discipline>();
        public Disciplines()
        {
            InitializeComponent();
        }

        private void Disciplines_Load(object sender, EventArgs e)
        {
            foreach (Department department in Departments.departmentList)
            {
                comboBox1.Items.Add(department.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Заповніть всі поля!");
            }
            else
            {
                Discipline discipline = new Discipline(textBox1.Text);

                string departmentName = comboBox1.Text;
                
                discipline.Name = textBox1.Text;
                //discipline.Departments = new Department(departmentName);
                //discipline.Departments.Name = departmentName;

                disciplinesList.Add(discipline);

                dataGridView1.Rows.Add(textBox1.Text, comboBox1.Text);
            }    
        }
    }
}
