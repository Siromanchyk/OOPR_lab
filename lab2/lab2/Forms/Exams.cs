using lab2.Models;

namespace lab2
{
    public partial class Exams : Form
    {
        public Exams()
        {
            InitializeComponent();
        }

        private void Exams_Load(object sender, EventArgs e)
        {
            foreach (Abiturient abit in Abiturients.abiturientsList)
            {
                comboBox1.Items.Add($"{abit.Surname} {abit.Name}");
            }
            foreach (Teacher teacher in Teachers.teacherList)
            {
                comboBox2.Items.Add($"{teacher.Surname} {teacher.Name}");
            }
            foreach (Discipline discipline in Disciplines.disciplinesList)
            {
                comboBox3.Items.Add(discipline.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Заповніть всі поля");
            }
            else
            {
                foreach (Abiturient abit in Abiturients.abiturientsList)
                {
                    if (abit.Surname == comboBox1.Text.Split(" ")[0] && abit.Name == comboBox1.Text.Split(" ")[1])
                    {
                        abit.Marks.Add(Convert.ToInt32(textBox1.Text));
                        abit.Marks.Add(Convert.ToInt32(textBox2.Text));
                        abit.Marks.Add(Convert.ToInt32(textBox3.Text));
                        if ((abit.Marks[0] + abit.Marks[1] + abit.Marks[2]) / 3 >= 3)
                        {
                            using (StreamWriter sw = new StreamWriter   ($"{abit.Faculty.Name}.txt", true))
                        {
                                sw.WriteLine($"{abit.Surname} {abit.Name}                   {abit.Faculty.Name}");
                        }
                            dataGridView1.Rows.Add(comboBox1.Text,              comboBox2.Text, comboBox3.Text, textBox1.Text, textBox2.Text, textBox3.Text);
                            break;
                        }
                    }
                }
            //Abiturient abit = new Abiturient(comboBox1.Text.Split(" ")[0], comboBox1.Text.Split(" ")[1]);
            //abit.AverageGrade = Convert.ToDouble(textBox1.Text);
            //dataGridView1.Rows.Add(comboBox1.Text, comboBox2.Text, abit.AverageGrade.ToString(), comboBox3.Text);
        }
        }
    }
}