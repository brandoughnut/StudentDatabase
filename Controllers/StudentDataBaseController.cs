using Microsoft.AspNetCore.Mvc;
using StudentDatabase.Models;
using StudentDatabase.Services.StudentDataBase;

namespace StudentDatabase.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class StudentDataBaseController : ControllerBase
    {
    private readonly IStudentDataBaseService _studentDataBaseService;

    public StudentDataBaseController(IStudentDataBaseService studentDataBaseService)
        {
        _studentDataBaseService = studentDataBaseService;
    }

        [HttpGet]
        [Route("ReadStudent")]
        public List<Student> ReadStudent()
        {
            return _studentDataBaseService.ReadStudent();
        }
        
        [HttpPost]
        [Route("CreateStudent/{firstName}/{lastName}/{hobbies}")]
        public List<Student> CreateStudent(string firstName, string lastName, string hobbies)
        {
            return _studentDataBaseService.CreateStudent(firstName, lastName, hobbies);
        }

        [HttpDelete]
        [Route("DeleteStudent/{firstName}")]
        public List<Student> DeleteStudent(string firstName)
        {
            return _studentDataBaseService.DeleteStudent(firstName);
        }

    }
