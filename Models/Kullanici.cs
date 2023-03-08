using System;

namespace denemesql.Models
{
    public class Kullanici
    {
        public int KullaniciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Kurum { get; set; }
        public string Eposta { get; set; }
        public string Telefon { get; set; }
        public int Unvan { get; set; }
        public int KatilimBicimi { get; set; }
        public int KatilimTuru1 { get; set; }
        public int TbdUyesi { get; set; }
        public int KatilimTuru2 { get; set; }
        public string EkstraBilgi { get; set; }
        public string Notlar { get; set; }
        //public DateTime Tarih { get; set; }
        public int Toplam { get; set; }
    }
}
