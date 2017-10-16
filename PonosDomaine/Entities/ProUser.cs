using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
    public class ProUser:Person
    {
        [Key]
        public int id_pro { get; set; }
        public string Status { get; set; }
        public string ActivitySector { get; set; }
        public string Category { get; set; }
        public virtual ICollection<JobOffers> listeOffres { get; set; }
        public virtual ICollection<Trainingonline> listeFormations { get; set; }
        public virtual ICollection<Event> listeEvents { get; set; }
        public virtual ICollection<Test> listeTests { get; set; }



    }
}
