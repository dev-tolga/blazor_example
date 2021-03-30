using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciServis.Pages.Veli
{
    public class VeliPageBase : ComponentBase
    {
        [Inject]
        public IJSRuntime JsRunTime { get; set; }
        public OgrenciServis.Data.Okul OkulObj { get; set; }
         public List<OgrenciServis.Data.Okul> okulList;
        List<OgrenciServis.Data.Ogrenci> ogrenciList;
        public List<OgrenciServis.Data.Ogrenci> ogrenciListByOkul;
        public List<OgrenciServis.Data.Veli> VeliList { get; set; }
        public string cardHeader = "";
        public int selectedOkulId { get; set; } = 1;
        public int selectedOgrenciId { get; set; } = 0;
        public int selectedpopupId = 0;
        public string EkleBtnStyleStr = "background-image: linear-gradient(90deg, #23074d 10%, #cc5333 70%)";
        public VeliPagePopupComponent veliPagePopupComponent;
        public VeliPageOgrenciPopupComponent veliPageOgrenciPopupComponent;
        protected async Task KaydetOkul()
        {
            okulList.Add(new Data.Okul { Id = 7, OkulAd = veliPagePopupComponent.GetChangeValueOkulAd });
            await JsRunTime.InvokeAsync<string>("SaveSuccess", new object[] { "Hello" });
            StateHasChanged();
        }
        protected async Task PopuptanOgrenciKaydet()
        {
            var secilenOkulNumarasi = veliPageOgrenciPopupComponent.SelectedPopupOkulId;
            ogrenciList.Add(new Data.Ogrenci { Id = 21, OkulId = secilenOkulNumarasi, AdSoyad = "77777" });
        }

        public Dictionary<string, string> kolonVeliIsimleri;
        protected override void OnInitialized()
        {
            OkulObj = new Data.Okul();
            VeliList = new List<Data.Veli>();
            okulDoldur();
            ogrenciDoldur();
            ogrenciListByOkul = new List<Data.Ogrenci>();
            ogrenciListByOkul = ogrenciyiOkulaGoreGetir(selectedOkulId);
            kolonIsmiDoldur();
        }
        void kolonIsmiDoldur()
        {
            kolonVeliIsimleri = new Dictionary<string, string>();
            kolonVeliIsimleri.Add("Id", "Id");
            kolonVeliIsimleri.Add("OgrenciAd", "Öğrenci Adı");
            kolonVeliIsimleri.Add("OkulAd", "Okul Adı");
        }
        public string okulAdGetir(int okulId)
        {
            var secilenResult = okulList.Where(x => x.Id == okulId).FirstOrDefault().OkulAd;
            return secilenResult;
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
        void ogrenciDoldur()
        {
            ogrenciList = new List<OgrenciServis.Data.Ogrenci>();

            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 0, OkulId = 0, AdSoyad = "Seçiniz" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 1, OkulId = 1, AdSoyad = "Mehmet" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 2, OkulId = 1, AdSoyad = "Hasan" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 3, OkulId = 2, AdSoyad = "Ahmet" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 4, OkulId = 2, AdSoyad = "Osman" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 5, OkulId = 3, AdSoyad = "Ali" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 6, OkulId = 4, AdSoyad = "Murat" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 7, OkulId = 5, AdSoyad = "Sercan" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 8, OkulId = 6, AdSoyad = "Sertan" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 9, OkulId = 3, AdSoyad = "Emrah" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 10, OkulId = 4, AdSoyad = "Salih" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 11, OkulId = 6, AdSoyad = "Emre" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 12, OkulId = 2, AdSoyad = "Ayşe" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 13, OkulId = 2, AdSoyad = "Haluk" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 14, OkulId = 4, AdSoyad = "Nehir" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 15, OkulId = 4, AdSoyad = "Pınar" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 16, OkulId = 5, AdSoyad = "Deniz" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 17, OkulId = 6, AdSoyad = "Hatice" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 18, OkulId = 3, AdSoyad = "Keriman" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 19, OkulId = 1, AdSoyad = "Kezban" });
            ogrenciList.Add(new OgrenciServis.Data.Ogrenci { Id = 20, OkulId = 1, AdSoyad = "Satılmış" });
        }
        public List<OgrenciServis.Data.Ogrenci> ogrenciyiOkulaGoreGetir(int okulId)
        {
            return ogrenciList.Where(x => x.OkulId == 0 || x.OkulId == okulId).ToList();
        }
        public void OnChangedOkul(ChangeEventArgs e)
        {
            selectedOkulId = int.Parse(e.Value.ToString());
            ogrenciListByOkul = ogrenciyiOkulaGoreGetir(int.Parse(e.Value.ToString()));
        }
        public void onChangedOgrenci(ChangeEventArgs e)
        {
            selectedOgrenciId = int.Parse(e.Value.ToString());
        }
        protected async Task Ekle()
        {
            if (selectedOgrenciId == 0)
            {
                await JsRunTime.InvokeAsync<string>("AlertCustom", new object[] { "Hello" });
                StateHasChanged();
            }
            else
            {
                OgrenciServis.Data.Ogrenci ogrenciObject = ogrenciListByOkul.Where(x => x.Id == selectedOgrenciId).FirstOrDefault();

                VeliList.Add(new Data.Veli
                {
                    Id = 0,
                    OgrenciId = selectedOgrenciId,
                    OkulId = selectedOkulId,
                    OgrenciAd = ogrenciObject.AdSoyad,
                    OkulAd = okulList.Where(o => o.Id == selectedOkulId).FirstOrDefault().OkulAd
                });

                ogrenciListByOkul.Remove(ogrenciObject);
                selectedOgrenciId = 0;
            }

        }
    }
}
