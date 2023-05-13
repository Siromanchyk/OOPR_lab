namespace lab2.Models
{
    public sealed class Faculty
    {
        private string _name = "";
        private List<Department> _department = new List<Department>();
        private List<Abiturient> _acceptedAbiturients = new List<Abiturient>();
        private int _minimumGrade;

        public Faculty(string name)
        {
            this._name = name;
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public List<Department> Department
        {
            get { return this._department; }
            set { this._department = value; }
        }
        public int MinimumGrade
        {
            get { return this._minimumGrade; }
            set { this._minimumGrade = value; }
        }
        public List<Abiturient> AcceptedAbiturients
        {
            get { return this._acceptedAbiturients; }
            set { this._acceptedAbiturients = value; }
        }
        public void WriteToFile()
        {
            using (StreamWriter sw = new StreamWriter($"{this.Name}.txt"))
            {
                foreach (Abiturient abit in _acceptedAbiturients)
                {
                    sw.WriteLine($"{abit.Surname} {abit.Name} {abit.Marks[0]} {abit.Marks[1]} {abit.Marks[2]} {abit.Department.Name}");
                }
            }
        }
    }
}
