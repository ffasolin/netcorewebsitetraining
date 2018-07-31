using Employee.Data;
using Employee.Models;
using Employee.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Employee.Controllers
{
    public class StudentsController : Controller
    {
        private IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            var viewModel = this.GetStudentViewModels(students);

            return View(viewModel);
        }

        private IEnumerable<StudentViewModel> GetStudentViewModels(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                yield return new StudentViewModel
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    DateEnrolled = student.DateEnrolled.ToString("dd MMMM yyyy")
                };
            }
        }
    }
}