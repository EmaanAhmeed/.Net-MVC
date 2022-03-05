using System.ComponentModel.DataAnnotations;

namespace Vacationcycle.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }

        public string? Jobtitle { get; set; }
        public string? HiringDate { get; set; }
        public string? ProfileImage { get; set; }
        public string? Birthdate { get; set; }
        public int MobileNo { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

    }
}
