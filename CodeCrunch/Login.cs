using CodeCrunch.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;                                        
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CodeCrunch
{
    public partial class Login : Form
    {
        public static string sendtext = "";
        public static int role;
        public Login()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Login_FormClosing);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //retrieving username and password from the database
            try
            {   
                Connections.Connections.DB();
                DBHelper.DBHelper.gen = "Select * from [users] where [user_name] = '" + txtUserName.Text + "' and [user_password] = '" + txtPassword.Text + "'";
                DBHelper.DBHelper.command = new OleDbCommand(DBHelper.DBHelper.gen, Connections.Connections.conn);
                DBHelper.DBHelper.reader = DBHelper.DBHelper.command.ExecuteReader();

                if (DBHelper.DBHelper.reader.HasRows)
                {
                    DBHelper.DBHelper.reader.Read();
                    txtUserName.Text = (DBHelper.DBHelper.reader["user_name"].ToString());
                    txtPassword.Text = (DBHelper.DBHelper.reader["user_password"].ToString());
                    role = Convert.ToInt32(DBHelper.DBHelper.reader["role_ID"]);


                    tmrLogin.Enabled = true;
                    tmrLogin.Start();
                    tmrLogin.Interval = 1;
                    pbLogin.Maximum = 200;
                    tmrLogin.Tick += new EventHandler(tmrLogin_Tick);

                }
                else
                {
                    MessageBox.Show("Invalid Username and Password");
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
                Connections.Connections.conn.Close();
            }

            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void validate_Role() 
        {
            Admin a = new Admin();
            Student s = new Student();
            Instructor i = new Instructor();
            //Display right application for user role
            //validate_Role(role).show();
            switch (role) 
            {
                case 1:
                    a.Show();
                    break;
                    
                case 2:
                    i.Show();
                    break;

                case 3:
                    s.Show();
                    break;
            }
          
        }

        private void tmrLogin_Tick(object sender, EventArgs e)
        {
            if (pbLogin.Value != 200)
            {
                pbLogin.Value++;
            }
            else
            {
                tmrLogin.Stop();
                this.Hide();

                pbLogin.Value = 0;
                sendtext = txtUserName.Text;
                validate_Role();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {

                var result = MessageBox.Show("Are you sure you want to close the form?\nThis action will close the application.",
                                         "Confirm Close",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the close action
                }
                else if (result == DialogResult.Yes) 
                {
                    // Exit the application
                    Application.Exit();
                }
                                
            }
        }        

    }

}
