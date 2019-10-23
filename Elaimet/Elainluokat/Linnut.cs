using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elainluokat
{
    public abstract class Linnut : Elain
    {
        public string sulat;

        public Linnut()
        {
            sulat = "kyllä";
        }
        public string Sulat
        {
            get
            {
                return sulat;
            }
            set
            {
                sulat = value;
            }
        }
        public override string Aantele { get => base.Aantele; set => base.Aantele = value; }
    }
}
