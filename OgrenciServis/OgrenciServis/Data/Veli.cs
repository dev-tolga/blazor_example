using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciServis.Data
{
    public class Veli
    {
        public int Id { get; set; }
        public int OkulId { get; set; }
        public int OgrenciId { get; set; }
        public string OkulAd { get; set; }
        public string OgrenciAd { get; set; }
    }
}
