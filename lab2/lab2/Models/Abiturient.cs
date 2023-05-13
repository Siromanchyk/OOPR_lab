namespace lab2.Models
{
    public class Abiturient : Person
    {
        private Department _department;
        private Faculty _faculty;
        private List<Discipline> _disciplines = new List<Discipline>();
        private List<int> _marks = new List<int>();
        private bool _isAccepted;

        public Abiturient(string name, string surname)
        {
            this._name = name;
            this._surname = surname;
        }
        public Abiturient(string name, string surname, Faculty faculty)
        {
            this._name = name;
            this._surname = surname;
            this._faculty = faculty;
        }
        public Abiturient(string name, string surname, string dateOfBirthsday) 
        {
            this._name = name;
            this._surname = surname;
            this._dateOfBirthsday = dateOfBirthsday;
        }
        public List<Discipline> Discipline
        { 
            get { return _disciplines; }
            set { _disciplines = value; }
        }
        public bool IsAccepted
        {
            get { return this._isAccepted; }
            set { this._isAccepted = value; }
        }
        public Department Department
        { 
            get { return _department; } 
            set { this._department = value; }
        }
        public Faculty Faculty
        {
            get { return _faculty; }
            set { this._faculty = value; }
        }
        public List<int> Marks 
        {
            get { return this._marks; }
            set { this._marks = value; } 
        }
        public void WriteToFile()
        {
            using (StreamWriter sw = new StreamWriter("Abiturient.txt", true)) 
            {
                sw.WriteLine($"{this._name} {this._surname} {this._department} {this._faculty}");
            }
        }
        public double CalculateMiddleMark()
        {
            return Marks.Average();
        }
        public override string toString()
        {
            return $"{this._name} {this._surname} {this._dateOfBirthsday}";
        }
    }
}