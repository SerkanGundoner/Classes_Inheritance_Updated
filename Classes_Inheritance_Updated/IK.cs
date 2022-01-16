using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance_Updated
{
    internal class IK : Personel
    {
        public int PersonelSayisi { get; set; }

        public new void Kaydet(List<IK> liste)
        {
            base.Kaydet();
            Console.WriteLine("PersonelSayisi:");
            this.PersonelSayisi = Convert.ToInt32(Console.ReadLine());
            liste.Add(this);
        }

        public static bool Giris(List<IK> liste, long tc)
        {
            foreach (IK item in liste)
            {
                if (item.TC == tc)
                {
                    return true;
                }
            }

            return false;
        }

        public static void Listele(List<IK> liste)
        {
            foreach (IK item in liste)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.TC);
                Console.WriteLine(item.PersonelSayisi);
            }
        }
    }
}
