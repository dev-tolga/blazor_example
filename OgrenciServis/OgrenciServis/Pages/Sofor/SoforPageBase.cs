using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciServis.Pages.Sofor
{
    public class SoforPageBase : ComponentBase
    {
        public int SelectedArabaId = 1;
        public List<OgrenciServis.Data.Araba> ArabaList;
        public OgrenciServis.Data.Sofor SoforObject;
        public List<OgrenciServis.Data.Sofor> soforList;
        public Dictionary<string, string> kolonVeliIsimleri;

        protected override void OnInitialized()
        {
            SoforObject = new Data.Sofor();
            soforList = new List<Data.Sofor>();
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

        public void SoforKaydet()
        {
            soforList.Add(new Data.Sofor { Id = 0, AracId = SelectedArabaId, SoforAd = SoforObject.SoforAd, SoforSoyad = SoforObject.SoforSoyad });
        }

        public void kolonIsmiDoldur()
        {
            kolonVeliIsimleri = new Dictionary<string, string>();
            kolonVeliIsimleri.Add("Id", "Id");
            kolonVeliIsimleri.Add("AracId", "Araç");
            kolonVeliIsimleri.Add("SoforAd", "Şoför Ad");
            kolonVeliIsimleri.Add("SoforSoyad", "Şoför Soyad");
        }
    }
}
