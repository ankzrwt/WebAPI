using Microsoft.AspNetCore.Mvc;
using project1.Model;


namespace project1.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private CreateData seedData = CreateData.instance;
        
        [HttpGet]
        [Route("/getAllEmployees")]
        public List<Employee> getAllEmployees() {
            return seedData.employees;
        }

        [HttpGet]
        [Route("getById/{Id}")]
        public Employee getById(int Id)
        {
            for(int i = 0; i < seedData.employees.Count; i++)
            {
             if (seedData.employees[i].Id == Id)
                {
                    return seedData.employees[i];

               }
            }
            return null;
        }

        [HttpPost]
        [Route("/addEmployee")]
        //We are getting emp as path variable in body.
        public Employee addEmployee(Employee emp)
        {
            //Adding validation to check if employee Id already exist do not add employee
            for(int i = 0; i < seedData.employees.Count; i++)
            {
                if (seedData.employees[i].Id == emp.Id)
                {
                    return null;
                }
            }
            seedData.employees.Add(emp);
            return emp;
                 
        }

        [HttpPatch]
        [Route("/updateEmployee")]
        public Employee updateEmployee(int Id,Employee emp) { 
            for(int i = 0; i < seedData.employees.Count; i++)
            {
                if (seedData.employees[i].Id == Id)
                {
                    if (emp.Name != seedData.employees[i].Name)
                    {
                        seedData.employees[i].Name = emp.Name;
                    }
                    if (emp.Dept != seedData.employees[i].Dept)
                    {
                        seedData.employees[i].Dept = emp.Dept;
                    }
                    return seedData.employees[i];
                }

            }
            return null;
        }
    }
}
