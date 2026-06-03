using ApiTestingWithJenkins.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiTestingWithJenkins.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StudentAPIontroller : ControllerBase
    {
        public static List<Student> studentlist;
        public StudentAPIontroller()
        {
            studentlist = new List<Student>();
        }

        [HttpGet]
        [Route("api/allstudents")]
        public List<Student> GetAll()
        {
            List<Student> lst = GenerateInitialData();

            return lst;
        }
        [HttpGet]
        [Route("api/student/{id}")]
        public Student GetById(int id)
        {
            return GenerateInitialData().FirstOrDefault(e => e.StudentId.Equals(id));
        }
        [HttpGet]
        [Route("api/studentnameById/{id}")]
        public string GetNameById(int id)
        {
            Student st = GenerateInitialData().FirstOrDefault(e => e.StudentId.Equals(id));
            return st.StudentName;
        }


        [NonAction]
        public List<Student> GenerateInitialData()
        {
            studentlist.Add(new Student() { StudentId = 1, StudentName = "Ajay", Qualification = "BE", Percentage = 78 });
            studentlist.Add(new Student() { StudentId = 2, StudentName = "Anita", Qualification = "BSC", Percentage = 58 });
            studentlist.Add(new Student() { StudentId = 3, StudentName = "Divya", Qualification = "BA", Percentage = 71 });
            studentlist.Add(new Student() { StudentId = 4, StudentName = "Mahesh", Qualification = "BBA", Percentage = 6 });
            studentlist.Add(new Student() { StudentId = 5, StudentName = "Dinesh", Qualification = "BCOM", Percentage = 28 });
            studentlist.Add(new Student() { StudentId = 6, StudentName = "Meena", Qualification = "BSC", Percentage = 21 });
            studentlist.Add(new Student() { StudentId = 7, StudentName = "Kumar", Qualification = "BA", Percentage = 89 });
            studentlist.Add(new Student() { StudentId = 8, StudentName = "Krishna", Qualification = "BCA", Percentage = 89 });
            studentlist.Add(new Student() { StudentId = 9, StudentName = "Leena", Qualification = "BBA", Percentage = 82 });
            studentlist.Add(new Student() { StudentId = 10, StudentName = "Manoj", Qualification = "BCOM", Percentage = 19 });
            studentlist.Add(new Student() { StudentId = 11, StudentName = "Suhas", Qualification = "MA", Percentage = 45 });
            studentlist.Add(new Student() { StudentId = 12, StudentName = "Anushka", Qualification = "BE", Percentage = 95 });
            studentlist.Add(new Student() { StudentId = 13, StudentName = "kajal", Qualification = "BTech", Percentage = 85 });
            studentlist.Add(new Student() { StudentId = 14, StudentName = "Sush", Qualification = "BCA", Percentage = 75 });

            return studentlist;
        }
    }
}
