using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb; //MS Access
using System.Windows.Forms; //Communication to FrontEnd

namespace CodeCrunch.Connections
{
    internal class Connections
    {
        //Connection String
        public static OleDbConnection conn; // declare connection                       // To make the connection Dynamic
        private static string dbconnect = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\CodeCrunch.accdb"; // path to database

        public static void DB()
        { 
            //Exception Handling
            try 
            { 
                conn = new OleDbConnection(dbconnect);
                conn.Open(); 
            } 
            catch(Exception ex) 
            { 
                conn.Close(); 
                MessageBox.Show(ex.Message);  
            }    
        }
    
    }
}
