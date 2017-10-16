using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
    public class Experience
    {
        [Key]
        public int id_experience { get; set; }
        public string Company { get; set; }
        public string user { get; set; }
        public bool recommandation { get; set; }
        public int Mark { get; set; }
        public virtual ICollection<SimpleUser> listeSimpleUsers { get; set; }
       
    }
}
