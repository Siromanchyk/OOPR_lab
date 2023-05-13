namespace lab2.Models
{
    public class Student : Abiturient
    {
        private List<Discipline> _disciplines = new List<Discipline>();
        private Faculty _faculty;
        public Student(string name, string surname, string dateOfBirthsday) : base(name, surname, dateOfBirthsday){}
        public List<Discipline> Disciplines 
        {
            get { return this._disciplines; }
            set { this._disciplines = value; } 
        }
        public Faculty Faculty
        {
            get { return this._faculty; }
            set { this._faculty = value; }
        }
    }
}