using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KickMe.Data.Models
{
    public class Unit
    {
        [Key]
        public int Id { get; set; }

        public string Description { get; set; }
        public string Suffix { get; set; }
        public string Prefix { get; set; }
    }
}
