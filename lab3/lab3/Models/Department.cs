using lab2.Interfaces;

namespace lab2.Models
{
    public class Department : IDepartment
    {
        private string _name = "";
        private string _headerOfDepartment = "";
        private List<Teacher> _teachers = new List<Teacher>();
        private Faculty _faculty;

        public Department(string name, Faculty faculty) 
        {
            this._name = name;
            this._faculty = faculty;
        }
        public string Name 
        { 
            get { return this._name; }
            set { this._name = value; }
        }
        public string HeaderOfDepartment
        {
            get { return this._headerOfDepartment; }
            set { this._headerOfDepartment = value; }
        }
        public List<Teacher> Teachers
        { 
            get { return this._teachers; }
            set { this._teachers = value; } 
        }
        public Faculty Faculty
        { 
            get { return this._faculty; }
            set { this._faculty = value; }
        }
        public void WriteToFile()
        {
            using (StreamWriter sw = new StreamWriter("Departments.txt", true))
            {
                sw.WriteLine($"{this._name} {this._faculty.Name}");
            }
        }
    }
}
