using lab2.Models;

namespace lab2.Interfaces
{
    public interface IFaculty
    {
        string Name { get; set; }
        List<Department> Department { get; set; }
        int MinimumGrade { get; set; }
        List<Abiturient> AcceptedAbiturients { get; set; }
    }
}
