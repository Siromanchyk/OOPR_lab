﻿using lab2.Models;

namespace lab2
{
    public partial class Abiturients : Form
    {
        public static List<Abiturient> abiturientsList = new List<Abiturient>();
        public Abiturients()
        {
            InitializeComponent();
        }

        private void Abiturients_Load(object sender, EventArgs e)
        {
            foreach (Faculty f in Facults.facultyList)
            {
                comboBox1.Items.Add(f.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Заповніть всі поля");
            }
            else
            {
                abiturientsList.Add(new Abiturient(textBox2.Text, textBox1.Text, new Faculty(comboBox1.Text)));

                textBox1.Clear();
            }
        }
    }
}
