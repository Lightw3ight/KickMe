using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickMe.Data.Models
{
    public class ProjectItem
    {
        [Key]
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int UnitId { get; set; }
        public int ImageId { get; set; }

        public double AmountRequired { get; set; }
        public double StretchRequired { get; set; }
        public double Increment { get; set; }
        public double MimimumCommitment { get; set; }
        public double MaximumCommitment { get; set; }

        public virtual ICollection<Commitment> Commitments { get; set; }
    }
}