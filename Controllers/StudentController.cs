using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpGet]
    public Student Get()
    {
        return new Student(1,"K","A",22);
    }
    // public List<Student> Get()
    // {
    //     List <Student> obj=new List<Student>()
    //     {
    //         new Student (1,"Keerthana","Aiml",21),
    //         new Student (1,"Keerthana","Aiml",21)
    //     };
    //     return obj;

    // }
}
// public class Student
// {
//     public int id{get;set;}
//     public string name{get;set;}
//     public string course{get;set;}
//     public int age{get;set;}

// }
public sealed record Student(int id,string name,string course,int age);