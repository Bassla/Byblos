using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
    public class SuperAdmin:Person
    {
        [Key]
        public int id_admin { get; set; }
    }
}
