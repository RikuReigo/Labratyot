using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Autokauppa.model;
using Autokauppa.view;

namespace Autokauppa.controller
{

    
    public class KaupanLogiikka
    {
        DatabaseHallinta dbModel = new DatabaseHallinta();

        public bool TestDatabaseConnection()
        {
            try
            {
                bool doesItWork = dbModel.connectDatabase();
                return doesItWork;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool saveAuto(Auto newAuto) 
        {
                bool didItGoIntoDatabase = dbModel.saveAutoIntoDatabase(newAuto);
                return didItGoIntoDatabase;
        }

        public List<string> getAllAutoMakers() 
        {

            return dbModel.getAllAutoMakersFromDatabase();
        }

        public List<string> getAutoModels(int makerId) 
        {
            return dbModel.getAutoModelsByMakerId(makerId);
        }

        public int getModelID(string valittuauto)
        {
            return dbModel.getModelIdFromDB(valittuauto);
        }

        public List<string> getAutoColor()
        {
            return dbModel.getAutocolorDB();
        }

        public List<string> getAutoGas()
        {
            return dbModel.getAutogasDB();
        }

        public int getMalliId(string valittumalli)
        {
            return dbModel.getMalliIdDB(valittumalli);
        }

        public int getVariId(string valittuvari)
        {
            return dbModel.getVariIdDB(valittuvari);
        }

        public int getBensaId(string valittubensa)
        {
            return dbModel.getBensaIdDB(valittubensa);
        }

        public void ShowDT()
        {
            dbModel.CreateDT();
        }

        public List<string> NextEntry()
        {
            return dbModel.ShowNext();
        }

        public List<string> PreviousEntry()
        {
            return dbModel.ShowPrevious();
        }
    }
}
