using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public Employee Post(EmployeeRequest request)
    {
        List <Employee> emp=new List<Employee>()
        {
            new Employee(1,"A","x"),
            new Employee(2,"B","y"),
            new Employee(3,"C","z")
            
        };
        foreach (Employee e in emp)
        {
            if (request.id == e.id)
            {
                return e;
            }
        }
        return null;
    }
}
public  record Employee(int id,string name,string department);

public  record EmployeeRequest(int id);