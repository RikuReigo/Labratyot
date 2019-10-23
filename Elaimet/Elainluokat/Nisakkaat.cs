using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elainluokat
{
    public abstract class Nisakkaat : Elain
    {
        public string karvoitus;

        public Nisakkaat()
            {
            karvoitus = "kyllä";
            }
        public string Karvoitus
        {
            get
            {
                return karvoitus;
            }
            set
            {
                karvoitus = value;
            }
        }
        public override string Aantele { get => base.Aantele; set => base.Aantele = value; }
    }
}
