using Employee.Data;
using System.Linq;

namespace Employee.Services
{
    public interface IStudentService
    {
        IQueryable<Student> GetAll();
    }
}
