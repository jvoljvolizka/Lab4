using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Savasci : Canli
    {
        
        private Silah _silah;
        private String name;
        private static Savasci[] savascilar = new Savasci[100];
        private static int savasci_adet = 0;
        private static int canli_savasci_adet = 0;


        public Savasci(String name,Silah _silah):base()
        {
            /* ... */
           // savascilar[...] = this;
           /*...*/
        }
       


        public void Saldir(Canli a)
        {
           //Başka bir caliya saldır. 
        }

        protected override void Ol()
        {
            base.Ol();
            //savaci ölünce ne yapılmalı ?
           
        }
    }
}
