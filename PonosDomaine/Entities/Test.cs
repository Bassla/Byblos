using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosDomaine.Entities
{
    public class Test
    {
        [Key]
        public int id_test { get; set; }
        public int Num_question { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public virtual ICollection<Question> listeQuestions { get; set; }
        public ProUser proUser { get; set; }
        public SimpleUser simpleUser { get; set; }

    }
}
