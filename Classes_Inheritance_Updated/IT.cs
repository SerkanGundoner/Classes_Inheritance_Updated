using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance_Updated
{
    internal class IT:Personel
    {
        public int ProgramSayisi { get; set; }
        public new void Kaydet(List<IT> liste)
        {
            base.Kaydet();
            Console.WriteLine("ProgramSayisi:");
            this.ProgramSayisi = Convert.ToInt32(Console.ReadLine());
            liste.Add(this);
        }
        public static bool Giris(List<IT> liste, long tc)
        {
            foreach (IT item in liste)
            {
                if (item.TC == tc)
                {
                    return true;
                }
            }

            return false;
        }
        public static void Listele(List<IT> liste)
        {
            foreach (IT item in liste)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.TC);
                Console.WriteLine(item.ProgramSayisi);
            }
        }
    }
}
