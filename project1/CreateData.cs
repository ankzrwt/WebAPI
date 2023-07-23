using project1.Model;

namespace project1
{
    public class CreateData
    {
        //We are creating instance as static because we were facing a issue where everytime when call is coming to employee controller it was creating a 
        // new object of create data class, so whatever data we stored in the object from previous POST method was lost now. TO resolve it we created a 
        // static object of CreateData as instance. SO that this object will be created at runtime and we can use it wherever we want. As this object is 
        // static the memory will be allocated at Compile time and during runtime we do not need to create it's object. This way our changes to the list 
        // of employees will also be stored.
        // To use this : public CreateData objectName = CreateData.instance;

        public  static CreateData instance = new CreateData();
        public List<Employee> employees = new List<Employee>();
        public CreateData()
        {
            employees.Add(new Employee(1, "Gaurav", "xyz"));
            employees.Add(new Employee(2, "ank", "eng"));
            employees.Add(new Employee(3, "akh", "arts"));
        }

    }

}
