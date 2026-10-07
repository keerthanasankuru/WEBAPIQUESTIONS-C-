using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class AddNumbersController : ControllerBase
{
    [HttpPost]
    public int Post(PostRequest request)
    {
        return request.a+request.b;

    }
}
public record class PostRequest(int a,int b);