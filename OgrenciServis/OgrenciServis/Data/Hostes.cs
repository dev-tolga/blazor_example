using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciServis.Data
{
    public class Hostes
    {
        public int Id { get; set; }
        public int AracId { get; set; }
        public string HostesAd { get; set; }
        public string HostesSoyad { get; set; }
    }
}
