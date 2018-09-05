using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using log4net.Config;

namespace GoatAppFramework
{
    public class Data
    {
        

        static Dictionary<String, String> myData = new Dictionary<string, string>();

        public static void LoadData()
        {
           try { 
            String connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";", System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.xls"));
            String selectCommand = "SELECT * FROM [Data$]";
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(selectCommand, connectionString))
            {
                using (DataSet ds = new DataSet())
                {
                    adapter.Fill(ds);
                    myData = ds.Tables[0].AsEnumerable().ToDictionary(row => row[1].ToString(), row => row[2].ToString());
                
                    }
            }
        }
            catch (Exception e)
            {
               
                throw new Exception();
            }
        }


                public static String get(String Key)
                {
                    return myData[Key];
                }
            
    }

}

