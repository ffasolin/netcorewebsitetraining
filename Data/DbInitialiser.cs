using System;
using System.Collections.Generic;
using System.Linq;

namespace Employee.Data
{
    public static class DbInitialiser
    {
        public static void Initialise(UniversityDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();

            if (dbContext.Students.Any())
            {
                return;
            }

            var students = new List<Student>()
            {
                new Student { FirstName = "Daniel", LastName = "Trunley", DateEnrolled = DateTime.UtcNow.AddYears(-2)},
                new Student { FirstName = "Jess", LastName = "Barclay", DateEnrolled = DateTime.UtcNow.AddYears(-1)},
                new Student { FirstName = "Filipe", LastName = "Fasolin", DateEnrolled = DateTime.UtcNow.AddYears(-1)},
                new Student { FirstName = "Agata", LastName = "Sumowska", DateEnrolled = DateTime.UtcNow.AddMonths(-18)},
            };

            foreach(var student in students)
            {
                dbContext.Students.Add(student);
            }

            dbContext.SaveChanges();
        }
    }
}
