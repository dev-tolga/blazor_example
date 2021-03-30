using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciServis.Pages.Ogrenci
{
    public class OgrenciPageBase : ComponentBase
    {
        public int selectedOkulId { get; set; } = 1;
        public List<OgrenciServis.Data.Okul> okulList;
        public List<OgrenciServis.Data.Ogrenci> ogrenciList;
        public Dictionary<string, string> kolonVeliIsimleri;
        public OgrenciServis.Data.Ogrenci OgrenciObject { get; set; }

        public void OnChangedOkul(ChangeEventArgs e)
        {
            selectedOkulId = int.Parse(e.Value.ToString());
        }

        protected override void OnInitialized()
        {
            OgrenciObject = new Data.Ogrenci();
            ogrenciList = new List<Data.Ogrenci>();
            okulDoldur();
            kolonIsmiDoldur();
        }

        void okulDoldur()
        {
            okulList = new List<OgrenciServis.Data.Okul>();

            okulList.Add(new OgrenciServis.Data.Okul { Id = 1, OkulAd = "Özel Atafen İlköğretim Okulu" });
            okulList.Add(new OgrenciServis.Data.Okul { Id = 2, OkulAd = "MY KOLEJ KOCAELİ MY OKULLARI" });
            okulList.Add(new OgrenciServis.Data.Okul { Id = 3, OkulAd = "Özel Kocaeli Güneş Okulları" });
            okulList.Add(new OgrenciServis.Data.Okul { Id = 4, OkulAd = "ÖZEL ADIM ANADOLU SAĞLIK MESLEK LİSESİ" });
            okulList.Add(new OgrenciServis.Data.Okul { Id = 5, OkulAd = "Bilgi Küpü Koleji" });
            okulList.Add(new OgrenciServis.Data.Okul { Id = 6, OkulAd = "ÖZEL KALE ELİT İLKOKULU" });
        }

        public void OgrenciKaydet()
        {
            ogrenciList.Add(new Data.Ogrenci { Id = 0, OkulId = selectedOkulId, AdSoyad = OgrenciObject.AdSoyad });
        }

        void kolonIsmiDoldur()
        {
            kolonVeliIsimleri = new Dictionary<string, string>();
            kolonVeliIsimleri.Add("Id", "Id");
            kolonVeliIsimleri.Add("OkulId", "Okul Id");
            kolonVeliIsimleri.Add("AdSoyad", "Ad Soyad");
        }
    }
}
