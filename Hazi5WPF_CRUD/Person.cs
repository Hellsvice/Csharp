using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hazi5WPF_CRUD
{
    // Modell osztály -> Adatszerkezet
    public class Person
    {
        // key -> elsődleges kulcs
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Automata generálás
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age {  get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is Person)
            {
                Person other = obj as Person;
                return this.Name == other.Name && this.Age == other.Age;
            }
            else
            {
                return false;
            }
        }
    }
}
