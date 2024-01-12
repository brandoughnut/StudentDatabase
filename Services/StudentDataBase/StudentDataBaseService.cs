
using StudentDatabase.Data;
using StudentDatabase.Models;

namespace StudentDatabase.Services.StudentDataBase;

public class StudentDataBaseService : IStudentDataBaseService
{
    private readonly DataContext _db;
    public StudentDataBaseService(DataContext db)
    {
        _db = db;
    }
    public List<Student> CreateStudent(string firstName, string lastName, string hobbies)
    {
        Student newStudent = new();
        newStudent.FirstName = firstName;
        newStudent.LastName = lastName;
        newStudent.Hobbies = hobbies;

        _db.Students.Add(newStudent);
        _db.SaveChanges();

        return _db.Students.ToList();
    }

    public List<Student> DeleteStudent(string firstName)
    {
        var student = _db.Students.FirstOrDefault(foundStudent => foundStudent.FirstName == firstName);
        if(student != null){
            _db.Students.Remove(student);
            _db.SaveChanges();
        }
        return _db.Students.ToList();
    }

    public List<Student> ReadStudent()
    {
        return _db.Students.ToList();
    }
}
