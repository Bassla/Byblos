using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
   public class Course
    {
        [Key]
        public int Course_id { get; set; }
        public Person person { get; set; }
    }
}
