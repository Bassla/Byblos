using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
    public class Person
    {
        [Key]
        public int idPerson { get; set; }
        public string Firstname_person { get; set; }
        public string Lastname_person { get; set; }
        public string Adress_person { get; set; }
        public string Email_person { get; set; }
        public int Telephone_person { get; set; }
        public string Password_person { get; set; }

        public virtual ICollection<Course> listeCourses { get; set; }

    }
}
