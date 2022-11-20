using Microsoft.AspNetCore.Components.Web;


namespace Employee_Management_System.Models.Employee
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public string Email { get; set; }
        public string FIN { get; set; }
        public string Code { get; set; }
        public bool IsDeleted { get; set; }
        
    }
}
