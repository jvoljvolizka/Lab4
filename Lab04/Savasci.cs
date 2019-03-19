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

        public string Name { get => name; set => name = value; }
        public Silah silah { get => _silah; set => _silah = value; }
        public Savasci[] Savascilar { get => savascilar;}
        public int Savasci_adet { get => savasci_adet; }
        public int Canli_savasci_adet { get => canli_savasci_adet; }


        public Savasci(String name,Silah _silah):base()
        {
            this.name = name;
            this._silah = _silah;
            /* ... */
            savascilar[Savasci_adet] = this;
            savasci_adet = savasci_adet + 1;
            canli_savasci_adet = canli_savasci_adet + 1;
        }
       


        public void Saldir(Canli a)
        {
            a.Hasar(silah.SaldiriGücü);
           //Başka bir caliya saldır. 
        }

        protected override void Ol()
        {
            base.Ol();
            canli_savasci_adet = canli_savasci_adet - 1;
            //savaci ölünce ne yapılmalı ?
           
        }
    }
}
