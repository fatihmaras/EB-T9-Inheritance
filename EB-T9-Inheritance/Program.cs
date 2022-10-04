using EB_T9_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi=new Kedi();
            kedi.hayvan_isim = " Toper";
            kedi.hayvan_Cinsiyet = " Dişi ";
            kedi.hayvan_Rengi = "Alaca";

            kedi.hayvanBilgisiGoster();
            Console.ReadLine();



        }
    }
}
