using lab2.Models;

namespace lab2.Interfaces
{
    public interface ITeacher
    {
        Department Departments { get; set; }
        string Position { get; set; }
    }
}
