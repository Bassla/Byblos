using PonosDomaine.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonosData
{
   public class PonosContext :DbContext
    {
        public PonosContext() : base("Name=ConnectionStringName")
        {

        }

        public DbSet<Person> persons { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Event> events { get; set; }
        public DbSet<Experience> experiences { get; set; }
        public DbSet<Interview> enterviews { get; set; }
        public DbSet<JobOffers> jobOffers { get; set; }
        public DbSet<JobRequest> jobRequests { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<Test> tests { get; set; }
        public DbSet<Trainingonline> trainingonline { get; set; }

    }
}
