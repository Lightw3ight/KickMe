using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KickMe.Data.EntityFramework;

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
            Console.ReadKey();
        }
    }
}
