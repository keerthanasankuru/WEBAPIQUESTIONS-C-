using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    [HttpGet]
    public Product Get()
    {
        return new Product(1,"Laptop",75000,"Dell");
 
    }
}
public sealed record Product(int id,string name,double price,string brand);