using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance_Updated
{
    internal class MUH:Personel
    {
        public int DefterSayisi { get; set; }
        public new void Kaydet(List<MUH> liste)
        {
            base.Kaydet();
            Console.WriteLine("DefterSayisi:");
            this.DefterSayisi = Convert.ToInt32(Console.ReadLine());
            liste.Add(this);

        }

        public static bool Giris(List<MUH> liste, long tc)
        {
            foreach (MUH item in liste)
            {
                if (item.TC == tc)
                {
                    return true;
                }
            }

            return false;
        }

        public static void Listele(List<MUH> liste)
        {
            foreach (MUH item in liste)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.TC);
                Console.WriteLine(item.DefterSayisi);
            }
        }
    }
}
