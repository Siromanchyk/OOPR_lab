using lab1.Models;

// Сформувати файл, що містить інформацію про N студентів (прізвище та ім'я, дата народження).
// Впорядкувати інформацію та вивести її по днях народження в даному місяці з вказанням дати.


// objListOrder.Sort((x, y) => x.OrderDate.CompareTo(y.OrderDate));

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // List<Student> students = new List<Student>();

        // функція запису у файл
        void WriteFile(string name, string surname, string dateOfBirthday)
        {
            using (StreamWriter file = new("StudentList.txt", append: true))
            {
                file.WriteLine(surname, name, dateOfBirthday);
                file.Close();
            }
        }

        // функція зчитування з файлу
        List<StudentViewModel> ReadFromFile(List<StudentViewModel> studentsList)
        {
            using (StreamReader read = new StreamReader("StudentList.txt"))
            {
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    string[] val = line.Split(" ");
                    studentsList.Add(new StudentViewModel(val[0], val[1], val[2]));
                }
            }
            return studentsList;
        }

        List<StudentViewModel> printMonth(List<StudentViewModel> studentsList)
        {
            List<StudentViewModel> list = new List<StudentViewModel>();

            string indexOfMonth = "";

            if (comboBox1.SelectedIndex < 10)
            {
                indexOfMonth = "0" + (comboBox1.SelectedIndex + 1).ToString();
            }
            else
            {
                indexOfMonth = (comboBox1.SelectedIndex + 1).ToString();
            }

            foreach (StudentViewModel student in studentsList)
            {
                if (student.DayOfBirthday.Split('.')[1] == indexOfMonth)
                {
                    //richTextBox1.AppendText($"{student.Surname} {student.Name} {student.DayOfBirthday}\n");
                    list.Add(student);
                }
            }
            studentsList.Clear();
            return list;
        }

        void sortMonth(List<StudentViewModel> studentsList)
        {
            studentsList.Sort((x, y) => Convert.ToInt32(x.DayOfBirthday.Split(".")[0]).CompareTo(Convert.ToInt32(y.DayOfBirthday.Split(".")[0])));

            foreach (StudentViewModel student in studentsList)
            {
                richTextBox1.AppendText($"{student.Surname} {student.Name} {student.DayOfBirthday}\n");
            }
        }

        // кнопка "Внести"
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Заповніть всі поля!");
            }
            else
            {
                WriteFile(textBox1.Text, textBox2.Text, textBox3.Text);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        // Кнопка "Вивести"
        private void button2_Click(object sender, EventArgs e)
        {
            List<StudentViewModel> students = new List<StudentViewModel>(); 
            richTextBox1.Clear();
            ReadFromFile(students);

            List<StudentViewModel> names = new List<StudentViewModel>();
            names = printMonth(students);
            sortMonth(names);
        }
    }
}