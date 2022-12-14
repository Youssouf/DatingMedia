using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //use dependency injection here
        public DataContext(DbContextOptions options) : base(options)    { }
        
        // user class entity
        public DbSet<AppUser> AppUsers { get; set; }  
        
                
    }
}