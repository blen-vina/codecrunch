using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb; //MS Access
using System.Windows.Forms; //Communication to FrontEnd
using System.Data.SqlClient;

namespace CodeCrunch.DBHelper
{
    internal class DBHelper
    {
        //for database transaction
        public static string gen = ""; //holder for sql commands
        public static OleDbConnection conn; //
        public static OleDbCommand command; //execute query from gen
        public static OleDbDataReader reader; //to retrieve data and verify

        public static void fill(string sql, DataGridView dgv)
        {
            try
            {
                Connections.Connections.DB();
                DataTable dataTable = new DataTable();
                OleDbDataAdapter data = null;
                                                            //folder.class.variable/field
                OleDbCommand command = new OleDbCommand(sql, Connections.Connections.conn);
                data = new OleDbDataAdapter(command);
                data.Fill(dataTable);
                dgv.DataSource = dataTable;
                // Set the DataGridView to fill the entire space of the control
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                // Ensure each column width is adjusted based on its content
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                // Optionally, use the auto resize methods for immediate resizing
                dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgv.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);

                // Set the last column to fill the remaining space if needed
                if (dgv.Columns.Count > 0)
                {
                    dgv.Columns[dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                Connections.Connections.conn.Close();
            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> DBHELPER FILL " + ex.Message);
            }

        }
        

        //Modify Database Insert or Update or Delete
        public static void ModifyRecord(string updates) 
        {
            try 
            {
                Connections.Connections.DB();
                OleDbCommand command = new OleDbCommand(updates, Connections.Connections.conn);
                command.ExecuteNonQuery();
                Connections.Connections.conn.Close();           
            }
            catch (Exception ex) 
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> DBHELPER MODIFY RECORD" +  updates + " " + ex.Message);
            }
        }


    }
}
