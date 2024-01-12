using StudentDatabase.Models;

namespace StudentDatabase.Services.StudentDataBase;

    public interface IStudentDataBaseService
    {
        List<Student> ReadStudent();
        List<Student> CreateStudent(string firstName, string lastName, string hobbies);
        List<Student> DeleteStudent(string firstName);
    }
