using Microsoft.AspNetCore.Mvc;
using ClientServerLoginPoC.Models;

namespace ClientServerLoginPoC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name = "Carlos", Career = "Software Engineering"},
                new Student { Id = 2, Name = "Maria", Career = "Cybersecurity"},
                new Student { Id = 3, Name = "Luis", Career = "Networks"}
            };
        }
    }
}