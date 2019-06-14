using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JamesAmos.Models
{
    public class DailyPrayer
    {
        public int ID { get; set; }
        public string Verse { get; set; }

        public string Book { get; set; }

        public string Chapter { get; set; }

        public string Number { get; set; }
    }
}
