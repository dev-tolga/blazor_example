using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace OgrenciServis.Pages.Okul
{
    public class OkulPageBase : ComponentBase
    {
        public OgrenciServis.Data.Okul okulObject = new Data.Okul();
        public List<OgrenciServis.Data.Okul> okulList;
        public Dictionary<string, string> kolonVeliIsimleri;
        public string okulName = "";

        protected override void OnInitialized()
        {
            //okulObject = new Data.Okul();
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

       public void OkulKaydet()
        {
            var result = okulObject;
            okulList.Add(new OgrenciServis.Data.Okul { Id = 1, OkulAd = result.OkulAd });
        }

        void kolonIsmiDoldur()
        {
            kolonVeliIsimleri = new Dictionary<string, string>();
            kolonVeliIsimleri.Add("Id", "Id");
            kolonVeliIsimleri.Add("OkulAd", "Okul Adı");
        }
    }
}
