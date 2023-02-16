using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Register_Login_Logout.Models;

namespace Register_Login_Logout.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employees> employees { get; set; }
        public DbSet<Register_Login_Logout.Models.Employees> Employees { get; set; }
    }
}
