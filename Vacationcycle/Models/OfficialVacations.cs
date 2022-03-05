using System.ComponentModel.DataAnnotations;

namespace Vacationcycle.Models
{
    public class OfficialVacations
    {
        [Key]
        public int ID { get; set; }

        public string? Name { get; set; }

        public int Date { get; set;}

    }
}
