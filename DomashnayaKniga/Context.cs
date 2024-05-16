using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomashnayaKniga
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }

    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public Context() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../../Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User {
                Id = 1, Login = "admin", Password = "V3CEldEIyzVd5BvVZXBNx/QLEhaYWRA4",
                FirstName = "Иван", LastName = "Лапшевский" });
        }
    }
}
