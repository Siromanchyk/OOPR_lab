namespace lab2.Models
{
    public class Person
    {
        protected string _name = "";
        protected string _surname = "";
        protected string _dateOfBirthsday = "";

        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public string Surname
        {
            get { return this._surname; }
            set { this._surname = value; }
        }
        public string DateOfBirthsday
        {
            get { return this._dateOfBirthsday; }
            set { this._dateOfBirthsday = value; }
        }
        public virtual string toString()
        {
            return $"{this.Name} {this.Surname} {this.DateOfBirthsday}";
        }
    }
}
