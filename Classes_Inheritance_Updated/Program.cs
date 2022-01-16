using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance_Updated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Şirket: IK,IT,MUH,PAZ
            /*
            InsanKaynaklari: Ad,Soyad,TC,PersonelSayisi
            Bilgi İşlem: Ad,Soyad,TC,ProgramSayisi
            Muhasebe: Ad,Soyad,TC,DefterSayisi
            Pazarlama: Ad,Soyad,TC,TeklifSayisi

            Merhaba kayıt/giriş

            Kaydet(),Giriş(),Goster()

             */

            List<IK> insanKaynaklari = new List<IK>();
            List<IT> bilgiİslem = new List<IT>();
            List<MUH> muhasebe = new List<MUH>();
            List<PAZ> pazarlama = new List<PAZ>();

            while (true)
            {
                Console.WriteLine("******** URS SOFTWARE ***********");
                Console.WriteLine("1-Kayıt\n2-Giriş\n3-Çıkış");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("1-IK\n2-IT\n3-MUH\n4-PAZ\n\tHangi Birim:");
                        string birim = Console.ReadLine();
                        if (birim == "1")
                        {
                            IK p = new IK();
                            p.Kaydet(insanKaynaklari);
                        }
                        else if (birim == "2")
                        {
                            IT p = new IT();
                            p.Kaydet(bilgiİslem);
                        }
                        else if (birim == "3")
                        {
                            MUH p = new MUH();
                            p.Kaydet(muhasebe);
                        }
                        else if (birim == "4")
                        {
                            PAZ p = new PAZ();
                            p.Kaydet(pazarlama);
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Birim!!");
                        }

                        Console.WriteLine("Devam etmek ister misiniz? (E/H)");
                        if (Console.ReadLine().ToUpper() == "H")
                        {
                            Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz..");
                            break;
                        }
                    }

                }
                else if (secim == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("1-IK\n2-IT\n3-MUH\n4-PAZ\n\tHangi Birim:");
                        string birim = Console.ReadLine();
                        if (birim == "1")
                        {
                            Console.WriteLine("Kontrol Amaçlı TC Kimlik Numaranızı Girin: ");
                            long tc = Convert.ToInt64(Console.ReadLine());
                            if (IK.Giris(insanKaynaklari, tc))
                            {
                                IK.Listele(insanKaynaklari);
                            }

                        }
                        else if (birim == "2")
                        {
                            Console.WriteLine("Kontrol Amaçlı TC Kimlik Numaranızı Girin: ");
                            long tc = Convert.ToInt64(Console.ReadLine());
                            if (IT.Giris(bilgiİslem, tc))
                            {
                                IT.Listele(bilgiİslem);
                            }
                        }
                        else if (birim == "3")
                        {
                            Console.WriteLine("Kontrol Amaçlı TC Kimlik Numaranızı Girin: ");
                            long tc = Convert.ToInt64(Console.ReadLine());
                            if (MUH.Giris(muhasebe, tc))
                            {
                                MUH.Listele(muhasebe);
                            }
                        }
                        else if (birim == "4")
                        {
                            Console.WriteLine("Kontrol Amaçlı TC Kimlik Numaranızı Girin: ");
                            long tc = Convert.ToInt64(Console.ReadLine());
                            if (PAZ.Giris(pazarlama, tc))
                            {
                                PAZ.Listele(pazarlama);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hatalı Birim!!");
                        }

                        Console.WriteLine("Devam etmek ister misiniz? (E/H)");
                        if (Console.ReadLine().ToUpper() == "H")
                        {
                            Console.WriteLine("Ana Menüye Yönlendiriliyorsunuz..");
                            break;
                        }
                    }
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Çıkış Yapılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı Seçim!!");
                }
            }
            Console.ReadLine();
        }
    }
  
}
