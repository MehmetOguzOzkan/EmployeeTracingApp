using System.ComponentModel.DataAnnotations;

namespace EmployeeTracingApp.Models
{
	public class Employee
	{
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string grade { get; set; }
        public Department department { get; set; }
        public Employee employee { get; set; }
    }
}
