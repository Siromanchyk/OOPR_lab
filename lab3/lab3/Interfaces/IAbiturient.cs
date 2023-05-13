using lab2.Models;

namespace lab2.Interfaces
{
    public interface IAbiturient
    {
        List<Discipline> Discipline { get; set; }
        bool IsAccepted { get; set; }
        Department Department { get; set; }
        Faculty Faculty { get; set; }
        List<int> Marks { get; set; }
        void WriteToFile();
    }
}