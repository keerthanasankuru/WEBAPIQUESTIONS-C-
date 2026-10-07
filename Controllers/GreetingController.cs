using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class GreetingController : ControllerBase
{
    [HttpPost]
    public string Post(GreetingRequest request)
    {
        return $"Hello {request.Name}!"; 
    }
}
public class GreetingRequest
{
    public string Name{get;set;}
}
