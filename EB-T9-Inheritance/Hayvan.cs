using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB_T9_Inheritance
{
    public class Hayvan
    {
        public string hayvan_isim;
        public string hayvan_Cinsiyet;
        public string hayvan_Rengi;
        private int hayvan_yas;


        public void hayvanBilgisiGoster()
        {
            Console.WriteLine("Hayvanın ismi: " + hayvan_isim);
            Console.WriteLine("Hayvanın Cinsiyeti: " + hayvan_Cinsiyet);
            Console.WriteLine("Hayvanın Rengi: " + hayvan_Rengi);
            Console.ReadLine();

        }
    }
}