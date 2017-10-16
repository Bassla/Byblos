using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
    public class JobRequest
    {
        [Key]
        public int id_request { get; set; }
     
        public string Description { get; set; }
      
        public string Skills_required { get; set; }
        public string Schedule { get; set; }
        public SimpleUser simpleUser { get; set; }

    }
}
