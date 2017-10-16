using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
    public class SimpleUser:Person
    {
        [Key]
        public int id_user { get; set; }
        public string field { get; set; }
        public virtual ICollection<Interview> listeInterviews { get; set; }
        public virtual ICollection<JobOffers> listeOffres { get; set; }
        public virtual ICollection<Experience> listeExpers { get; set; }
        public virtual ICollection<Trainingonline> listeTrainings { get; set; }
        public virtual ICollection<JobRequest> listeJobRequests { get; set; }
    }
}
