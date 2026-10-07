using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]

public class SquareController : ControllerBase
{
    [HttpPost]
    public int Post(Squarerequest request)
    {
        return request.num*request.num;
    }
}
// public class Squarerequest
// {
//     public int num{get;set;}
// }
public sealed record Squarerequest(int num);