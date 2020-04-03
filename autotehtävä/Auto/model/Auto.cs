using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Autokauppa.model
{

    public class Auto
    {
        private int iD;
        private decimal hinta;
        private DateTime rekisteri_Päivämäärä;
        private decimal moottorin_Tilavuus;
        private int mittarilukema;
        private int autonMerkkiID;
        private int autonMalliID;
        private int varitID;
        private int polttoaineID;
        private int autonMerkki;
        private int autonMalli;

        public int ID
        {
            get { return iD; }
            set { iD = value; }
        }

        public decimal Hinta
        {
            get { return hinta; }
            set { hinta = value; }
        }

        public DateTime Rekisteri_Päivämäärä
        {
            get { return rekisteri_Päivämäärä; }
            set { rekisteri_Päivämäärä = value; }
        }

        public decimal Moottorin_Tilavuus
        {
            get { return moottorin_Tilavuus; }
            set { moottorin_Tilavuus = value; }
        }

        public int Mittarilukema
        {
            get { return mittarilukema; }
            set { mittarilukema = value; }
        }
        
        public int AutonMerkkiID
        {
            get { return autonMerkkiID; }
            set { autonMerkkiID = value; }
        }

        public int AutonMalliID
        {
            get { return autonMalliID; }
            set { autonMalliID = value; }
        }

        public int VaritID
        {
            get { return varitID; }
            set { varitID = value; }
        }

        public int PolttoaineID
        {
            get { return polttoaineID; }
            set { polttoaineID = value; }
        }

        public int AutonMerkki
        {
            get { return autonMerkki; }
            set { autonMerkki = value; }
        }

        public int AutonMalli
        {
            get { return autonMalli; }
            set { autonMalli = value; }
        }
    }
}
