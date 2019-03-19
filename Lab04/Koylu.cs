using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Koylu : Canli
    {

        private String name;

        public string Name { get => name; set => name = value; }


        public Koylu(string isim)
        {
            this.name = isim;
        }

    }
}
