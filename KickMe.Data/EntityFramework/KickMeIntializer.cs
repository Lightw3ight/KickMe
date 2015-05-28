using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KickMe.Data.Models;

namespace KickMe.Data.EntityFramework
{
    //use DropCreateDatabaseAlways<KickMeContext> or DropCreateDatabaseIfModelChanges<KickMeContext>  
    public class KickMeInitializer : System.Data.Entity. DropCreateDatabaseAlways<KickMeContext>  
    {
        protected override void Seed(KickMeContext context)
        {
            var users = new List<User>
                {
                    new User()
                    {
                        Id = 1,
                        FirstName = "Toby",
                        LastName = "Holland",
                        Email = "toby.holland@trademe.co.nz"
                    },
                    new User()
                    {
                        Id = 2,
                        FirstName = "Natasha",
                        LastName = "Smirnova",
                        Email = "natasha.smirnova@trademe.co.nz"
                    }
                };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var projects = new List<Models.Project>
                {
                    new Models.Project{
                        Title = "2 Dozen Muffins", 
                        Description = "I would like to bake 2 dozen muffins for the office.", 
                        LocationId = 1,
                        StartDate = DateTime.Now
                    },
                    new Models.Project{  Title = "Help me move desks", 
                        Description = "Need help moving a bunch of desks from level 1 to level 2", 
                        LocationId = 1,
                        StartDate = DateTime.Now }
                };

            projects.ForEach(s => context.Projects.Add(s));
            context.SaveChanges();


            var projectAdmins = new List<ProjectAdmin>
                {
                    new ProjectAdmin()
                    {
                        ProjectId = 1,
                        UserId = 1
                    },
                    new ProjectAdmin()
                    {
                        ProjectId = 2,
                        UserId = 2
                    }
                };

            projectAdmins.ForEach(a => context.ProjectAdmins.Add(a));
            context.SaveChanges();

            var units = new List<Unit>
                {
                    new Unit()
                    {
                        Description = "Dollars",
                        Prefix = "$",
                        Suffix = null
                    },
                     new Unit()
                    {
                        Description = "Volunteer Hours",
                        Prefix = null,
                        Suffix = "hours"
                    }
                };

            units.ForEach(u => context.Units.Add(u));
            context.SaveChanges();

            var projectItems = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        ProjectId = 1,
                        Title = "Ingredient costs",
                        UnitId = 1,
                        Description = "We need to raise $30 for the ingredients, you wil recieve a muffin for every dollar you give, you can not buy more than 5 muffins",
                        AmountRequired = 30,
                        Increment = 1,
                        MaximumCommitment = 5,
                        MimimumCommitment = 1
                    },
                   new ProjectItem
                    {
                        ProjectId = 2,
                        Title = "Volunteers",
                        UnitId = 2,
                        Description = "We need 4 volunteers for half an hour",
                        AmountRequired = 2,
                        Increment = .5,
                        MimimumCommitment = .5,
                        MaximumCommitment = .5
                    },
                };

            projectItems.ForEach(s => context.ProjectItems.Add(s));
            context.SaveChanges();

            var commitments = new List<Commitment>
                {
                    new Commitment
                    {
                        ProjectItemId = 1,
                        Amount = 5,
                        UserId = 1
                    },
                    new Commitment{ ProjectItemId = 1,
                        Amount = 2,
                        UserId = 2
                    },
                     new Commitment{ ProjectItemId = 2,
                        Amount = .5,
                        UserId = 1
                    },
                     new Commitment{ ProjectItemId = 2,
                        Amount = .5,
                        UserId = 1
                    },
                   
                };

            commitments.ForEach(s => context.Commitments.Add(s));
            context.SaveChanges();
        }
    }
}
