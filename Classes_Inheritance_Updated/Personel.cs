using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Inheritance_Updated
{
    internal class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public long TC { get; set; }

        protected void Kaydet()
        {
            Console.WriteLine("Ad:");
            this.Ad = Console.ReadLine();
            Console.WriteLine("Soyad:");
            this.Soyad = Console.ReadLine();
            Console.WriteLine("Tc:");
            this.TC = Convert.ToInt64(Console.ReadLine());
        }
    }
}
