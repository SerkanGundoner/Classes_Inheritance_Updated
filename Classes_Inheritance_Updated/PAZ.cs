using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance_Updated
{
    internal class PAZ:Personel
    {
        public int TeklifSayisi { get; set; }
        public new void Kaydet(List<PAZ> liste)
        {
            base.Kaydet();
            Console.WriteLine("TeklifSayisi:");
            this.TeklifSayisi = Convert.ToInt32(Console.ReadLine());
            liste.Add(this);

        }

        public static bool Giris(List<PAZ> liste, long tc)
        {
            foreach (PAZ item in liste)
            {
                if (item.TC == tc)
                {
                    return true;
                }
            }

            return false;
        }

        public static void Listele(List<PAZ> liste)
        {
            foreach (PAZ item in liste)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.TC);
                Console.WriteLine(item.TeklifSayisi);
            }
        }
    }
}
