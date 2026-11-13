using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi5WPF_CRUD
{
    // Repository szerepe kommunikálás az adatbázissal, adatbázis műveletek elvégzése
    internal class PersonRepository
    {
        public List<Person> GetAll()
        {
            using (var context = new PersonDbContext())
            {
                return context.People.ToList();
            }
        }

        public void Add(Person person)
        {
            using (var context = new PersonDbContext())
            {
                context.People.Add(person);

                // Elmenti a véltozásokat az adatbázisban
                context.SaveChanges();
            }
        }

        public void Update(Person person)
        {
            using (var context = new PersonDbContext())
            {
                context.People.Update(person);
                context.SaveChanges();  
            }
        }

        public void Delete(int id)
        {
            using (var context = new PersonDbContext())
            {
                var person = context.People.Find(id);

                if (person != null)
                {
                    context.People.Remove(person);
                    context.SaveChanges();  
                }
            }
        }
    }
}
