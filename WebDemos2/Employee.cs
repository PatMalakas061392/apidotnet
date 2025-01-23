using System.ComponentModel.DataAnnotations;
using System.Reflection;
using DotNetOpenAuth.OpenId.Extensions.SimpleRegistration;


namespace WebDemos2
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public required string FirstName { get; set; }
        [Required]
        public required string LastName { get; set; }
        [Required]
        public required string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public int DepartmentId { get; set; }
        public string PhotoPath { get; set; }

    }
}
