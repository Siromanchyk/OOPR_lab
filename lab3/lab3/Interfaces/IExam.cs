using lab2.Models;

namespace lab2.Interfaces
{
    public interface IExam
    {
        Faculty Faculty { get; set; }
        List<Department> Departments { get; set; }
        List<Abiturient> Abiturients { get; set; }
        List<Teacher> Teachers { get; set; }
        List<Discipline> Discipline { get; set; }
    }
}
