using IntegerWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntegerWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var student = new List<Student>();

            student.Add(new Student()
            {
                Id = 1,
                Name = "Dede",
                Address = "Ciamis",
                Phone = "082233824398"
            });

            student.Add(new Student()
            {
                Id = 2,
                Name = "Adam",
                Address = "Ciamis",
                Phone = "082222222222"
            });

            return View(student);
        }
    }
}
