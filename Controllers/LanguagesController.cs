using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class LanguagesController : ControllerBase
{
 [HttpGet]
 public string[] Get()
    {
        return [
  "C#",
  "Java",
  "Python",
  "JavaScript",
  "Go"
];
    }   
}