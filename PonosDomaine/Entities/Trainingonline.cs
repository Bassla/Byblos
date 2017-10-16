using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
    public class Trainingonline
    {
        [Key]
        public int id_training { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public DateTime start_date { get; set; }
        public string Field { get; set; }

        public virtual ICollection<SimpleUser> listeSimpleUsers { get; set; }
        public ProUser proUser { get; set; }


    }
}
