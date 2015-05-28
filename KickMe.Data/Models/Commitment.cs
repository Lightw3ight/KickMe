using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickMe.Data.Models
{
    public class Commitment
    {
        [Key]
        public int Id { get; set; }
        public int ProjectItemId { get; set; }
        public int UserId { get; set; }
        public double Amount { get; set; }
        public double AmountPaid { get; set; }
    }
}
