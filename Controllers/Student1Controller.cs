
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class StudentRequestController : ControllerBase
{
    [HttpPost]
    public object Post(Students students)
    {
        List<Students> student=new List<Students>
        {
            new Students("Rahul",21,"CSE")
        };
        return new
        {
            msg="Student",
            name=students.name,
            age=students.age,
            course=students.course

        };
    }
}
public record class Students(string name,int age,string course);
