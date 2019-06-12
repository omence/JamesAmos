using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamesAmos.Models
{
    public class Vlog
    {
        public int ID { get; set; }

        public string Subject { get; set; }

        public DateTime DateCreated { get; set; }

        public string VideoUrl { get; set; }

    }
}
