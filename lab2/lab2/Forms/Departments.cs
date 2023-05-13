using lab2.Models;

namespace lab2
{
    public partial class Departments : Form
    {
        public static List<Department> departmentList = new List<Department>();
        public Departments()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            foreach (Faculty f in Facults.facultyList)
            {
                comboBox2.Items.Add(f.Name);
            }
            using (StreamReader sr = new StreamReader("Departments.txt", true))
            {
                string ln;
                while ((ln = sr.ReadLine()) != null)
                {
                    departmentList.Add(new Department(ln.Split(" ")[0], new Faculty(ln.Split(" ")[1])));
                }
            }
        }

        void DispInfo()
        {
            using (StreamReader sr = new StreamReader("Departments.txt", true))
            {
                string ln;
                while ((ln = sr.ReadLine()) != null)
                {
                    dataGridView1.Rows.Add(ln.Split(" ")[1], ln.Split(" ")[0]);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Заповніть всі поля!");
            }
            else
            {
                Department department = new Department(textBox1.Text, new Faculty(comboBox2.Text));

                //string facultyName = comboBox2.SelectedText;

                //department.Faculty = new Faculty(facultyName);
                //department.Faculty.Name = facultyName;

                departmentList.Add(department);
                department.WriteToFile();
                textBox1.Clear();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DispInfo();
        }
    }
}