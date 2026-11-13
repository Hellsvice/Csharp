using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi5WPF_CRUD
{
    // PersonDbContext -> adatbázis létrehozása és fenttartása
    internal class PersonDbContext : DbContext
    {
        // Minden egyes osztályhoz fog tartozni egy tábla az adatbázisban, amiből létrehozunk DbSet-et
        // Létre tudunk hozni kapcsoló táblát, azt nemn DbSet-tel kell
        public DbSet<Person> People { get; set; }

        internal static void InitializeDatabase()
        {
            using (var context = new PersonDbContext())
            {
                context.Database.EnsureCreated();

                // Ha nincs adat az adatbázisban
                if (!context.People.Any())
                {
                    context.People.AddRange(new[]
                    {
                        new Person() { Name = "Person 1", Age=25 },
                        new Person() { Name = "Person 2", Age=21 },
                        new Person() { Name = "Person 3", Age=35 },
                    });

                    context.SaveChanges();  
                }
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Szerver elérhetősége -> csak lokális szerver
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=PersonDB2;Trusted_Connection=True;");
        }
    }
}
