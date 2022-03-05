using System.ComponentModel.DataAnnotations;

namespace Vacationcycle.Models
{
    public class VacationReq
    {
        [Key]
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string? Vfrom { get; set; }
        public string? Vto { get; set; }
        public string? Reason { get; set; }

    }
}
