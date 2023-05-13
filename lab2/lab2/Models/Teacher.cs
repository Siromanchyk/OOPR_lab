namespace lab2.Models
{
    public class Teacher : Person
    {
        private Department _department;
        private string _position = "";

        public Teacher(string name, string surname, string position, Department department) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Position = position;
            this._department = department;
        }
        public Department Departments
        {
            get { return _department; }
            set { this._department = value; }
        }
        public string Position
        {
            get { return this._position; }
            set { this._position = value; }
        }
        public void WriteToFile()
        {
            using(StreamWriter sw = new StreamWriter("Teachers.txt", true))
            {
                sw.WriteLine($"{this.Surname} {this.Name} {this.Position} {this._department.Name}");
            }
        }
    }
}
