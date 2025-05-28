using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_ve_Struct1
{
    internal class Program
    {
        // Enum: Sipariş Durumları
        enum SiparisDurumu
        {
            Hazirlaniyor,
            KargoyaVerildi,
            TeslimEdildi,
            IptalEdildi
        }

        // Struct: Sipariş Yapısı
        struct Siparis
        {
            public int SiparisID;
            public string MusteriAdi;
            public SiparisDurumu Durum;

            // Bilgileri Yazdırma Metodu
            public void Yazdir()
            {
                Console.WriteLine($"Sipariş ID: {SiparisID}, Müşteri: {MusteriAdi}, Durum: {Durum}");
            }
        }
        static void Main(string[] args)
        {
            Siparis siparis1;
            siparis1.SiparisID = 1001;
            siparis1.MusteriAdi = "Ahmet Yılmaz";
            siparis1.Durum = SiparisDurumu.Hazirlaniyor;

            siparis1.Yazdir();

            // Enum değerini değiştirme
            siparis1.Durum = SiparisDurumu.KargoyaVerildi;
            siparis1.Yazdir();
        }
    }
}
