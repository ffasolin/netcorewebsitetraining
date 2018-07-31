using Employee.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Employee.Services
{
    public class StudentService : IStudentService
    {
        private readonly UniversityDbContext _context;

        public StudentService(UniversityDbContext context)
        {
            this._context = context;
        }

        public IQueryable<Student> GetAll()
        {
            return _context.Students;
        }
    }
}
