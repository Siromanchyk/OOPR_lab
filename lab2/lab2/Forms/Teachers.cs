using lab2.Models;

namespace lab2
{
    public partial class Teachers : Form
    {
        public static List<Teacher> teacherList = new List<Teacher>();
        public Teachers()
        {
            InitializeComponent();
        }
        private void Teachers_Load(object sender, EventArgs e)
        {
            foreach (Department department in Departments.departmentList)
            {
                comboBox1.Items.Add(department.Name);
            }
            foreach (Faculty faculty in Facults.facultyList)
            {
                comboBox4.Items.Add(faculty.Name);
            }
        }
        void DispInfo()
        {
            //dataGridView1.Rows.Add(comboBox2.Text, textBox1.Text, textBox2.Text, textBox3.Text);
            using (StreamReader sr = new StreamReader("Teachers.txt", true))
            {
                string ln;
                while ((ln = sr.ReadLine()) != null)
                {
                    dataGridView1.Rows.Add(ln.Split(" ")[0], ln.Split(" ")[1], ln.Split(" ")[2], ln.Split(" ")[3], ln.Split(" ")[4]);
                    
                    Teacher teacher = new Teacher(ln.Split(" ")[1], ln.Split(" ")[0], ln.Split(" ")[3], new Department(ln.Split(" ")[4], new Faculty(comboBox4.Text)));
                    teacherList.Add(teacher);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Заповніть всі поля!");
            }
            else
            {
                Teacher teacher = new Teacher(textBox2.Text, textBox1.Text, comboBox2.Text, new Department(comboBox1.Text, new Faculty(comboBox4.Text)));

                // string departmentName = comboBox2.SelectedText;

                //teacher.Departments = new Department(departmentName);
                // teacher.Departments.Name = departmentName;
                teacher.WriteToFile();
                teacherList.Add(teacher);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DispInfo();
        }
    }
}
