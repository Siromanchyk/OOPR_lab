using lab2.Interfaces;

namespace lab2.Models
{
    public class Exam : IExam
    {
        private Faculty _faculty;
        private List<Department> _departments = new List<Department>();
        private List<Abiturient> _abiturients = new List<Abiturient>();
        private List<Teacher> _teachers = new List<Teacher>();
        private List<Discipline> _disciplines = new List<Discipline>();

        public Faculty Faculty
        {
            get { return _faculty; }
            set { _faculty = value; }
        }
        public List<Department> Departments
        {
            get { return this._departments; }
            set { this._departments = value; }
        }
        public List<Abiturient> Abiturients
        {
            get { return this._abiturients; }
            set { this._abiturients = value; }
        }
        public List<Teacher> Teachers
        {
            get { return this._teachers; }
            set { this._teachers = value; }
        }
        public List<Discipline> Discipline
        {
            get { return this._disciplines; }
            set { this._disciplines = value; }
        }
    }
}
