using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab04
{
    class Program
    {
        private static ArrayList masukiye;
        static void Main(string[] args)
        {
             masukiye = new ArrayList();
             masukiye.Add(new Koylu("Ahmet"));
             masukiye.Add(new Koylu("Mehmet"));
             masukiye.Add(new Hayvan());
             masukiye.Add(new Hayvan());
             masukiye.Add(new Canli());
             masukiye.Add(new Canli());
             masukiye.Add(new Savasci("Erol",new Silah(20)));
             masukiye.Add(new Savasci("Varol", new Silah(30)));
             masukiye.Add(new Savasci("Birol", new Silah(40)));

             KoyluleriListele();
             SavascilariListele();
             Duelo();
             
         

        }

        private static void SavascilariListele()
        {
            //Kasabadaki tüm savascilar listesi
            foreach (Savasci i in masukiye)
            {
                Console.WriteLine("{0} " , i.Name);
            }
            
        }

        private static void KoyluleriListele()
        {
            foreach (Koylu i in masukiye)
            {
                Console.WriteLine("{0} ", i.Name);
            }
            //Kasabadaki tüm köylüler listesi


        }

        private static void Duelo()
        {
            Savasci yen = null;
            foreach (Savasci i in masukiye)
            {
                yen = i;//listenin son savascisi en yeni savasci
            }

            while(yen.Canli_savasci_adet < 1)
            {
                int x = 0;
                yen.Saldir(yen.Savascilar[x]);

                if (yen.Savascilar[x].Canlimi)
                {
                    yen.Savascilar[x].Saldir(yen);
                }
                while (!yen.Canlimi)
                {
                    x = x + 1;
                    yen = yen.Savascilar[x];
                }
            }

            //Kasabaya yeni gelen bir savasci diğer tüm savascilarla duello başlar taki 1 savasci kalana kadar.



        }
    }
}
