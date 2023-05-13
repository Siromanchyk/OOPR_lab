namespace lab2.Models
{
    public class Discipline
    {
        private string _name = "";
        public Discipline(string name) 
        {
            this._name = name;
        }
        public string Name
        { 
            get { return _name; } 
            set { this._name = value; }
        }
    }
}
