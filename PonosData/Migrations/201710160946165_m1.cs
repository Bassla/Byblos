namespace PonosData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Course_id = c.Int(nullable: false, identity: true),
                        person_idPerson = c.Int(),
                    })
                .PrimaryKey(t => t.Course_id)
                .ForeignKey("dbo.People", t => t.person_idPerson)
                .Index(t => t.person_idPerson);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        idPerson = c.Int(nullable: false, identity: true),
                        Firstname_person = c.String(),
                        Lastname_person = c.String(),
                        Adress_person = c.String(),
                        Email_person = c.String(),
                        Telephone_person = c.Int(nullable: false),
                        Password_person = c.String(),
                        id_pro = c.Int(),
                        Status = c.String(),
                        ActivitySector = c.String(),
                        Category = c.String(),
                        id_user = c.Int(),
                        field = c.String(),
                        id_admin = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Event_id_event = c.Int(),
                    })
                .PrimaryKey(t => t.idPerson)
                .ForeignKey("dbo.Events", t => t.Event_id_event)
                .Index(t => t.Event_id_event);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        id_event = c.Int(nullable: false, identity: true),
                        start_date = c.DateTime(nullable: false),
                        end_date = c.DateTime(nullable: false),
                        proUser_idPerson = c.Int(),
                    })
                .PrimaryKey(t => t.id_event)
                .ForeignKey("dbo.People", t => t.proUser_idPerson)
                .Index(t => t.proUser_idPerson);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        id_experience = c.Int(nullable: false, identity: true),
                        Company = c.String(),
                        user = c.String(),
                        recommandation = c.Boolean(nullable: false),
                        Mark = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id_experience);
            
            CreateTable(
                "dbo.Interviews",
                c => new
                    {
                        id_interview = c.Int(nullable: false, identity: true),
                        simpleUser_idPerson = c.Int(),
                    })
                .PrimaryKey(t => t.id_interview)
                .ForeignKey("dbo.People", t => t.simpleUser_idPerson)
                .Index(t => t.simpleUser_idPerson);
            
            CreateTable(
                "dbo.JobRequests",
                c => new
                    {
                        id_request = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Skills_required = c.String(),
                        Schedule = c.String(),
                        simpleUser_idPerson = c.Int(),
                    })
                .PrimaryKey(t => t.id_request)
                .ForeignKey("dbo.People", t => t.simpleUser_idPerson)
                .Index(t => t.simpleUser_idPerson);
            
            CreateTable(
                "dbo.JobOffers",
                c => new
                    {
                        id_offer = c.Int(nullable: false, identity: true),
                        Publication_date = c.DateTime(nullable: false),
                        Expiration_date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Nb_posts = c.Int(nullable: false),
                        Skills_required = c.String(),
                        Experience = c.String(),
                        Benefits = c.String(),
                        Salary = c.Double(nullable: false),
                        Schedule = c.String(),
                        ProUser_idPerson = c.Int(),
                    })
                .PrimaryKey(t => t.id_offer)
                .ForeignKey("dbo.People", t => t.ProUser_idPerson)
                .Index(t => t.ProUser_idPerson);
            
            CreateTable(
                "dbo.Trainingonlines",
                c => new
                    {
                        id_training = c.Int(nullable: false, identity: true),
                        Price = c.Double(nullable: false),
                        Description = c.String(),
                        Duration = c.Int(nullable: false),
                        start_date = c.DateTime(nullable: false),
                        Field = c.String(),
                        proUser_idPerson = c.Int(),
                    })
                .PrimaryKey(t => t.id_training)
                .ForeignKey("dbo.People", t => t.proUser_idPerson)
                .Index(t => t.proUser_idPerson);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        id_test = c.Int(nullable: false, identity: true),
                        Num_question = c.Int(nullable: false),
                        Question = c.String(),
                        Answer = c.String(),
                        proUser_idPerson = c.Int(),
                        simpleUser_idPerson = c.Int(),
                    })
                .PrimaryKey(t => t.id_test)
                .ForeignKey("dbo.People", t => t.proUser_idPerson)
                .ForeignKey("dbo.People", t => t.simpleUser_idPerson)
                .Index(t => t.proUser_idPerson)
                .Index(t => t.simpleUser_idPerson);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        Question_id = c.Int(nullable: false, identity: true),
                        Test_id_test = c.Int(),
                    })
                .PrimaryKey(t => t.Question_id)
                .ForeignKey("dbo.Tests", t => t.Test_id_test)
                .Index(t => t.Test_id_test);
            
            CreateTable(
                "dbo.ExperienceSimpleUsers",
                c => new
                    {
                        Experience_id_experience = c.Int(nullable: false),
                        SimpleUser_idPerson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Experience_id_experience, t.SimpleUser_idPerson })
                .ForeignKey("dbo.Experiences", t => t.Experience_id_experience, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.SimpleUser_idPerson, cascadeDelete: true)
                .Index(t => t.Experience_id_experience)
                .Index(t => t.SimpleUser_idPerson);
            
            CreateTable(
                "dbo.JobOffersSimpleUsers",
                c => new
                    {
                        JobOffers_id_offer = c.Int(nullable: false),
                        SimpleUser_idPerson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.JobOffers_id_offer, t.SimpleUser_idPerson })
                .ForeignKey("dbo.JobOffers", t => t.JobOffers_id_offer, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.SimpleUser_idPerson, cascadeDelete: true)
                .Index(t => t.JobOffers_id_offer)
                .Index(t => t.SimpleUser_idPerson);
            
            CreateTable(
                "dbo.TrainingonlineSimpleUsers",
                c => new
                    {
                        Trainingonline_id_training = c.Int(nullable: false),
                        SimpleUser_idPerson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Trainingonline_id_training, t.SimpleUser_idPerson })
                .ForeignKey("dbo.Trainingonlines", t => t.Trainingonline_id_training, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.SimpleUser_idPerson, cascadeDelete: true)
                .Index(t => t.Trainingonline_id_training)
                .Index(t => t.SimpleUser_idPerson);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tests", "simpleUser_idPerson", "dbo.People");
            DropForeignKey("dbo.Tests", "proUser_idPerson", "dbo.People");
            DropForeignKey("dbo.Questions", "Test_id_test", "dbo.Tests");
            DropForeignKey("dbo.JobOffers", "ProUser_idPerson", "dbo.People");
            DropForeignKey("dbo.Events", "proUser_idPerson", "dbo.People");
            DropForeignKey("dbo.People", "Event_id_event", "dbo.Events");
            DropForeignKey("dbo.Trainingonlines", "proUser_idPerson", "dbo.People");
            DropForeignKey("dbo.TrainingonlineSimpleUsers", "SimpleUser_idPerson", "dbo.People");
            DropForeignKey("dbo.TrainingonlineSimpleUsers", "Trainingonline_id_training", "dbo.Trainingonlines");
            DropForeignKey("dbo.JobOffersSimpleUsers", "SimpleUser_idPerson", "dbo.People");
            DropForeignKey("dbo.JobOffersSimpleUsers", "JobOffers_id_offer", "dbo.JobOffers");
            DropForeignKey("dbo.JobRequests", "simpleUser_idPerson", "dbo.People");
            DropForeignKey("dbo.Interviews", "simpleUser_idPerson", "dbo.People");
            DropForeignKey("dbo.ExperienceSimpleUsers", "SimpleUser_idPerson", "dbo.People");
            DropForeignKey("dbo.ExperienceSimpleUsers", "Experience_id_experience", "dbo.Experiences");
            DropForeignKey("dbo.Courses", "person_idPerson", "dbo.People");
            DropIndex("dbo.TrainingonlineSimpleUsers", new[] { "SimpleUser_idPerson" });
            DropIndex("dbo.TrainingonlineSimpleUsers", new[] { "Trainingonline_id_training" });
            DropIndex("dbo.JobOffersSimpleUsers", new[] { "SimpleUser_idPerson" });
            DropIndex("dbo.JobOffersSimpleUsers", new[] { "JobOffers_id_offer" });
            DropIndex("dbo.ExperienceSimpleUsers", new[] { "SimpleUser_idPerson" });
            DropIndex("dbo.ExperienceSimpleUsers", new[] { "Experience_id_experience" });
            DropIndex("dbo.Questions", new[] { "Test_id_test" });
            DropIndex("dbo.Tests", new[] { "simpleUser_idPerson" });
            DropIndex("dbo.Tests", new[] { "proUser_idPerson" });
            DropIndex("dbo.Trainingonlines", new[] { "proUser_idPerson" });
            DropIndex("dbo.JobOffers", new[] { "ProUser_idPerson" });
            DropIndex("dbo.JobRequests", new[] { "simpleUser_idPerson" });
            DropIndex("dbo.Interviews", new[] { "simpleUser_idPerson" });
            DropIndex("dbo.Events", new[] { "proUser_idPerson" });
            DropIndex("dbo.People", new[] { "Event_id_event" });
            DropIndex("dbo.Courses", new[] { "person_idPerson" });
            DropTable("dbo.TrainingonlineSimpleUsers");
            DropTable("dbo.JobOffersSimpleUsers");
            DropTable("dbo.ExperienceSimpleUsers");
            DropTable("dbo.Questions");
            DropTable("dbo.Tests");
            DropTable("dbo.Trainingonlines");
            DropTable("dbo.JobOffers");
            DropTable("dbo.JobRequests");
            DropTable("dbo.Interviews");
            DropTable("dbo.Experiences");
            DropTable("dbo.Events");
            DropTable("dbo.People");
            DropTable("dbo.Courses");
        }
    }
}
