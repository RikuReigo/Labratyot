
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Autokauppa.controller;
using Autokauppa.view;



namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        string yhteysTiedot;
        SqlConnection dbYhteys;
        SqlDataAdapter DA;
        DataSet DS;
        
        string DTgetter = "select * from auto";

        public DatabaseHallinta()
        {
           yhteysTiedot = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AutoKauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public bool connectDatabase()
        {
            dbYhteys = new SqlConnection();
            dbYhteys.ConnectionString = yhteysTiedot;
            
            try
            { 
                dbYhteys.Open();
                return true;
            }
            catch(Exception e)
            { 
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }
            
        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            dbYhteys = new SqlConnection();
            dbYhteys.ConnectionString = yhteysTiedot;
            string sql = "insert into Auto ([Hinta], [Rekisteri_paivamaara], [Moottorin_tilavuus], [Mittarilukema], [AutonMerkkiID], [AutonMalliID], [VaritID], [PolttoaineID]), values(@Hinta, @Rekisteri_paivamaara, @Moottorin_tilavuus, @Mittarilukema, @AutonMerkkiID, @AutonMalliID, @VaritID, @PolttoaineID)";
            dbYhteys.Open();
            using (SqlCommand cmdSave = new SqlCommand(sql,dbYhteys)) 
            {
                cmdSave.Parameters.Add("@Hinta",System.Data.SqlDbType.Decimal).Value = newAuto.Hinta;
                cmdSave.Parameters.Add("@Rekisteri_paivamaara",System.Data.SqlDbType.DateTime).Value = newAuto.Rekisteri_Päivämäärä;
                cmdSave.Parameters.Add("@Moottorin_Tilavuus",System.Data.SqlDbType.Decimal).Value = newAuto.Moottorin_Tilavuus;
                cmdSave.Parameters.Add("@Mittarilukema",System.Data.SqlDbType.Int).Value = newAuto.Mittarilukema;
                cmdSave.Parameters.Add("@AutonMerkkiID",System.Data.SqlDbType.Int).Value = newAuto.AutonMerkkiID;
                cmdSave.Parameters.Add("@AutonMalliID", System.Data.SqlDbType.Int).Value = newAuto.AutonMalliID;
                cmdSave.Parameters.Add("@VaritID",System.Data.SqlDbType.Int).Value = newAuto.VaritID;
                cmdSave.Parameters.Add("@PolttoaineID",System.Data.SqlDbType.Int).Value = newAuto.PolttoaineID;
            }
            bool palaute = false;
            dbYhteys.Close();
            return palaute;          
        }

        public List<string> getAllAutoMakersFromDatabase()
        {
            List<string> palaute = new List<string>();
            dbYhteys = new SqlConnection();
            dbYhteys.ConnectionString = yhteysTiedot;
            dbYhteys.Open();
            using (SqlCommand cmdMerkki = new SqlCommand("Select Merkki from AutonMerkki", dbYhteys))
            {
                using (SqlDataReader dr = cmdMerkki.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        palaute.Add(dr[0].ToString());
                    }
                }
            }
            dbYhteys.Close();
            return palaute;

        }

        public int getModelIdFromDB(string valittuauto)
        {
            int MakerId;
            dbYhteys = new SqlConnection();
            dbYhteys.ConnectionString = yhteysTiedot;
            dbYhteys.Open();
            using (SqlCommand getid = new SqlCommand("Select ID from Autonmerkki where Merkki = '" + valittuauto + "'", dbYhteys)) 
            { MakerId = Convert.ToInt32(getid.ExecuteScalar()); }
            dbYhteys.Close();
            return MakerId;
        }

        public List<string> getAutoModelsByMakerId(int makerId)

        {
            List<string> palaute = new List<string>();
            dbYhteys = new SqlConnection();
            dbYhteys.ConnectionString = yhteysTiedot;
            dbYhteys.Open();
            using (SqlCommand cmdMalli = new SqlCommand("Select Auton_mallin_nimi from AutonMallit where AutonMerkkiID = '" + makerId + "'", dbYhteys))
            {
                using (SqlDataReader dr = cmdMalli.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        palaute.Add(dr[0].ToString());
                    }
                }
            }
            dbYhteys.Close();
            return palaute;
        }

        public List <string> getAutocolorDB()
        {
            List<string> palaute = new List<string>();
            dbYhteys = new SqlConnection();
            dbYhteys.ConnectionString = yhteysTiedot;
            dbYhteys.Open();
            using (SqlCommand cmdVarit = new SqlCommand("Select Varin_Nimi from Varit", dbYhteys))
            {
                using (SqlDataReader dr = cmdVarit.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        palaute.Add(dr[0].ToString());
                    }
                }
            }
            dbYhteys.Close();
            return palaute;
        }

        public List<string> getAutogasDB()
        {
            List<string> palaute = new List<string>();
            dbYhteys = new SqlConnection();
            dbYhteys.ConnectionString = yhteysTiedot;
            dbYhteys.Open();
            using (SqlCommand cmdBensa = new SqlCommand("Select Polttoaineen_Nimi from Polttoaine", dbYhteys))
            {
                using (SqlDataReader dr = cmdBensa.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        palaute.Add(dr[0].ToString());
                    }
                }
            }
            dbYhteys.Close();
            return palaute;
        }

        public int getVariIdDB(string valittuvari)
        {
            int VariId;
            dbYhteys = new SqlConnection();
            dbYhteys.ConnectionString = yhteysTiedot;
            dbYhteys.Open();
            using (SqlCommand getid = new SqlCommand("Select ID from Varit where Varin_nimi = '" + valittuvari + "'", dbYhteys))
            { VariId = Convert.ToInt32(getid.ExecuteScalar()); }
            dbYhteys.Close();
            return VariId;
        }

        public int getBensaIdDB(string valittubensa)
        {
            int BensaId;
            dbYhteys = new SqlConnection();
            dbYhteys.ConnectionString = yhteysTiedot;
            dbYhteys.Open();
            using (SqlCommand getid = new SqlCommand("Select ID from Polttoaine where Polttoaineen_nimi = '" + valittubensa + "'", dbYhteys))
            { BensaId = Convert.ToInt32(getid.ExecuteScalar()); }
            dbYhteys.Close();
            return BensaId;
        }
        
        public int getMalliIdDB(string valittumalli)
        {
            int MalliId;
            dbYhteys = new SqlConnection();
            dbYhteys.ConnectionString = yhteysTiedot;
            dbYhteys.Open();
            using (SqlCommand getid = new SqlCommand("Select ID from AutonMallit where Auton_mallin_nimi = '" + valittumalli + "'", dbYhteys))
            { MalliId = Convert.ToInt32(getid.ExecuteScalar()); }
            dbYhteys.Close();
            return MalliId;
        }

        public List<string> ShowNext()
        {
            List<string> palaute = new List<string>();
            return palaute;
        }

        public List<string> ShowPrevious()
        {
            List<string> palaute = new List<string>();
            return palaute;
        }

        public void CreateDT()
        {

        }

    }
}
