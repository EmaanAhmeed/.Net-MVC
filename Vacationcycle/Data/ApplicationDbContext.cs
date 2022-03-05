using Microsoft.EntityFrameworkCore;
using Vacationcycle.Models;

namespace Vacationcycle.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<OfficialVacations> OfficialVacation { get; set; }
        public DbSet<VacationReq> VacationReq { get; set; }


        
    }
}
