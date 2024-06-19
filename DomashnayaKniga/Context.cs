using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
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
        public List<Book> Books { get; set; } = new();
        public List<Room> Rooms { get; set; } = new();
        public override string ToString() { return $"{FirstName} {LastName}"; }
    }

    public class Book
    {
        public int Id { get; set; }
        public string Author { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public int? UserId { get; set; }
        public User? User { get; set; }
        public override string ToString() { return Title; }
    }

    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<Computer> Computers { get; set; } = new();
        public int? UserId { get; set; }
        public User? User { get; set; }
        public override string ToString() { return Name; }
    }

    public class Computer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int RoomId { get; set; }
        public Room? Room { get; set; }
        public override string ToString() { return Name; }
    }

    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Room> Rooms { get; set; } = null!;
        public DbSet<Computer> Computers { get; set; } = null!;
        public Context() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../../Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelFill(modelBuilder);
            modelBuilder.Entity<Book>().HasOne(u => u.User).WithMany(b => b.Books).OnDelete(DeleteBehavior.SetNull);
            modelBuilder.Entity<Room>().HasOne(u => u.User).WithMany(r => r.Rooms).OnDelete(DeleteBehavior.SetNull);
        }

        private void ModelFill(ModelBuilder modelBuilder)
        {
            User admin = new User // пароль - password
            {
                Id = 1,
                Login = "admin",
                Password = "V3CEldEIyzVd5BvVZXBNx/QLEhaYWRA4",
                FirstName = "Иван",
                LastName = "Лапшевский"
            };
            modelBuilder.Entity<User>().HasData(admin);
        }
    }
}
