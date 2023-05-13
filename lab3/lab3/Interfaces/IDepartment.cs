using lab2.Models;

namespace lab2.Interfaces
{
    public interface IDepartment
    {
        string Name { get; set; }
        string HeaderOfDepartment { get; set; }
        List<Teacher> Teachers { get; set; }
        Faculty Faculty { get; set; }
    }
}
