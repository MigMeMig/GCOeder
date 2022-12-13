using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace vonOeder.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string UserId { get; set; }
        public DateTime DT { get; set; }

    }
}
