using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
    public class Interview
    {
        [Key]
        public int id_interview { get; set; }
        public SimpleUser simpleUser { get; set; }
    }
}
