using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using KickMe.Data.EntityFramework;
using KickMe.Data.Models;

namespace EntityFrameworkTestProjectToBeDeleted
{
    class Program
    {
        static void Main(string[] args)
        {

           
            KickMeContext db = new KickMeContext();
            var projects = db.Projects.ToList();
            var users = db.Users.ToList();
            var commitments = db.Commitments.ToList();
            var comments = db.Comments.ToList();


             //var users = ActiveDirectoryService.GetAllUsers();
            var mappedUsers = new List<User>();

            mappedUsers.ForEach(u => db.Users.Add(u));
            db.SaveChanges();



            Console.ReadKey();
        }
    }
}
