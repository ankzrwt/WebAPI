namespace project1.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public Employee(int id,string name,string Dept) { 
        this.Id = id;
        this.Name = name;
        this.Dept = Dept;

        }
    }
}
