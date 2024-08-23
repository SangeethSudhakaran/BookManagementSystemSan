using EmployeeWebAPI.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebAPI.Controllers
{
    //[ApiVersion("1.0")]
    //[Route("api/v{version:apiVersion}/[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public static List<Employee> employeeList = new List<Employee>();
        [HttpGet("GetEmployees")]
        public IEnumerable<Employee> GetEmployee()
        {
            return employeeList;
        }
        [HttpGet("GetEmployee")]
        public Employee GetEmployee(int Id)
        {
            return employeeList.Where(x => x.Id == Id).FirstOrDefault();
        }
        [HttpPost("AddEmployee")]
        public IActionResult PostEmployee(Employee employee)
        {
            employeeList.Add(employee);
            return Ok("Record added successfully");
        }
        
        [HttpPut("UpdateEmployee")]
        public IActionResult PutEmployee(Employee employee)
        {
            var employeeData = employeeList.Where(x => x.Id == employee.Id).FirstOrDefault();
            employeeList.Remove(employeeData);
            employeeList.Add(employee);
            return Ok("Record updated successfully");
        }
        
        [HttpDelete("DeleteEmployee")]
        public IActionResult DeleteEmployee(int Id)
        {
            var employeeData = employeeList.Where(x => x.Id == Id).FirstOrDefault();
            employeeList.Remove(employeeData);
            return Ok("Record deleted successfully");
        }
    }
}