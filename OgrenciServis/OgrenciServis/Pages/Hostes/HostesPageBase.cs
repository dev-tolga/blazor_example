using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OgrenciServis.Component.BaseComponent;

namespace OgrenciServis.Pages.Hostes
{
    public class HostesPageBase : ComponentBase
    {
        public TestTextBoxComponent testTextBoxCopmonent;
        public OgrenciServis.Data.Hostes hostesObject;
        public List<OgrenciServis.Data.Hostes> hostesListesi;
        public int SelectedArabaId { get; set; } = 1;
        public List<OgrenciServis.Data.Araba> ArabaList { get; set; }
        public Dictionary<string, string> kolonVeliIsimleri;
        
        protected override void OnInitialized()
        {
            hostesObject = new Data.Hostes();
            hostesListesi = new List<Data.Hostes>();
            ArabaDoldur();
            kolonIsmiDoldur();
        }

        public void ArabaDoldur()
        {
            ArabaList = new List<Data.Araba>();
            ArabaList.Add(new Data.Araba { Id = 1, ArabaPlaka = "41 AA 4512", KoldukSayisi = 20, Marka = "ABC" });
            ArabaList.Add(new Data.Araba { Id = 2, ArabaPlaka = "41 BB 1232", KoldukSayisi = 30, Marka = "KLM" });
            ArabaList.Add(new Data.Araba { Id = 3, ArabaPlaka = "41 CC 1423", KoldukSayisi = 35, Marka = "QAZ" });
            ArabaList.Add(new Data.Araba { Id = 4, ArabaPlaka = "41 DD 1321", KoldukSayisi = 40, Marka = "OLK" });
            ArabaList.Add(new Data.Araba { Id = 5, ArabaPlaka = "41 EE 4512", KoldukSayisi = 10, Marka = "TYH" });
        }

        public void OnChangedAraba(ChangeEventArgs e)
        {
            SelectedArabaId = int.Parse(e.Value.ToString());
        }

        public void HostesKaydet()
        {
            hostesObject.HostesAd = testTextBoxCopmonent.BindValue;
            hostesListesi.Add(new Data.Hostes { Id = 0, AracId = SelectedArabaId, HostesAd = hostesObject.HostesAd, HostesSoyad = hostesObject.HostesSoyad });
        }
        public void kolonIsmiDoldur()
        {
            kolonVeliIsimleri = new Dictionary<string, string>();
            kolonVeliIsimleri.Add("Id", "Id");
            kolonVeliIsimleri.Add("AracId", "Araç");
            kolonVeliIsimleri.Add("HostesAd", "Hostes Ad");
            kolonVeliIsimleri.Add("HostesSoyad", "Hostes Soyad");
            kolonVeliIsimleri.Add("Test", "Test 1");
        }
    }
}
