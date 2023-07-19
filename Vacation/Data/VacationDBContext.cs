using Microsoft.EntityFrameworkCore;
using Vacation.model;
using Vacation.Model;
using Vacation.Models;

namespace Vacation.Data
{
    public class VacationDBContext : DbContext
    {
        public VacationDBContext()
        {
        }

        public VacationDBContext(DbContextOptions<VacationDBContext> options) : base(options) { }


       

        public DbSet<Slide> Slide { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Deals> Deals { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Best> Best { get; set; }

    }
}
