using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickMe.Data.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int LocationId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsDeleted { get; set; }
        public int ImageIdBanner { get; set; }
        public int ImageIdMain { get; set; }

        public virtual ICollection<ProjectItem> ProjectItems { get; set; }
    }
}
