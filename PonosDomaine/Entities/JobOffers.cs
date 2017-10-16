using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
    public class JobOffers
    {
        [Key]
        public int id_offer { get; set; }
        public DateTime Publication_date { get; set; }
        public DateTime Expiration_date { get; set; }
        public string Description { get; set; }
        public int Nb_posts { get; set; }
        public string Skills_required { get; set; }
        public string Experience { get; set; }
        public string Benefits { get; set; }
        public double Salary { get; set; }
        public string Schedule { get; set; }
        public virtual ICollection<SimpleUser> listeSimpleUsers { get; set; }




    }
}
