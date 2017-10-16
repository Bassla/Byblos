using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
    public class Event
    {
        [Key]
        public int id_event { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public virtual ICollection<SimpleUser> listeSimpleUsers { get; set; }
        public ProUser proUser { get; set; }

    }
}
