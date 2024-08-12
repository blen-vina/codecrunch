using CodeCrunch.Connections;
using CodeCrunch.GetMaxItemNo;
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
    public partial class Registration : Form
    {
        public static string sendtext = "";
        private string sql = "";
        public Registration()
        {
            InitializeComponent();
        }



        private void btnRegister_Click(object sender, EventArgs e)
        {
            try 
            {
                //Get Role ID using role name
                getRoleID();
                sql = "INSERT INTO [users] (user_ID, user_name, user_password, email, registration_date, role_ID)"
                    + "Values (" + txtUserID.Text + "," +
                    " '" + txtUserName.Text + "'," +
                    " '"  + txtPassword.Text +"'," +
                    " '" + txtEmail.Text + "'," +
                    " '" + DateTime.Now.ToShortDateString() + "'," +
                    " " + GetMaxItemNo.GlobalDeclaration.role_ID.ToString() + ")";
                DBHelper.DBHelper.ModifyRecord(sql);
                MessageBox.Show("You have registered successfully...", "Create new Account?",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Registration_Load(sender, e);
                clearFields();
            } 
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getRoleID() 
        {
            GetMaxItemNo.GetData.getRoleID(cboRole.Text);
        }

        private void clearFields() 
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            cboRole.SelectedItem = null;
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            //make sure no other items are inside combo box collections
            cboRole.Items.Clear();
            //set combo box role items/collections
            setRoleItems();
            GetMaxItemNo.GetData.getMaxUserID();
            txtUserID.Text = GetMaxItemNo.GlobalDeclaration.user_ID.ToString();
        }
        private void setRoleItems()
        {
            GetData.setcboRoleNames();
            int size = GlobalDeclaration.roleNames.Length;
            for (int i = 0; i < size; i++)
            {
                cboRole.Items.Add(GlobalDeclaration.roleNames[i]);
            }
            return;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnBacktoAdmin_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            this.Close();
            a.Show();
        }
        //Disable close button to avoid user closing the form
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

    }
}
