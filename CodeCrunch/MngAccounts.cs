using CodeCrunch.GetMaxItemNo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCrunch
{
    public partial class MngAccounts : Form
    {
        private string sql;
        public MngAccounts()
        {
            InitializeComponent();
        }

        private void MngAccounts_Load(object sender, EventArgs e)
        {
            cboRole.Items.Clear();
            //set cbo role items
            setRoleItems();

            //user can't do any unless they choose a record
            setAccesibility();

            //sql = "SELECT * from users";
            sql = "SELECT users.*, role.role_name " +
                  "FROM users INNER JOIN role ON users.role_ID = role.role_ID;";
            DBHelper.DBHelper.fill(sql, dgvAccounts);

            //set dgv headers
            set_dgvHeaders();

        }
        private void set_dgvHeaders() 
        {
            dgvAccounts.Columns[0].HeaderCell.Value = "User ID";
            dgvAccounts.Columns[1].HeaderCell.Value = "User Name";
            dgvAccounts.Columns[2].HeaderCell.Value = "Password";
            dgvAccounts.Columns[3].HeaderCell.Value = "Email Add";
            dgvAccounts.Columns[4].HeaderCell.Value = "Registered On";
            dgvAccounts.Columns[5].HeaderCell.Value = "Role ID";
            dgvAccounts.Columns[6].HeaderCell.Value = "Role";
        }

        private void setAccesibility() 
        {
            //set all text boxes to read only
            txtUserName.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtEmail.ReadOnly = true;
            cboRole.Enabled = false;
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

        private void dgvAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Populating the text fields from retrieved data inside data grid
            txtUserID.Text = dgvAccounts[0, e.RowIndex].Value.ToString();
            txtUserName.Text = dgvAccounts[1, e.RowIndex].Value.ToString();
            txtPassword.Text = dgvAccounts[2, e.RowIndex].Value.ToString();
            txtEmail.Text = dgvAccounts[3, e.RowIndex].Value.ToString();

            //if colum role is empty assign role to empty string if not the proceed
            if (String.IsNullOrEmpty(dgvAccounts[5, e.RowIndex].Value.ToString()))
            {
                clearfields();
            }
            else
            {
                GetData.getRoleName(Convert.ToInt32(dgvAccounts[5, e.RowIndex].Value));
                cboRole.Text = GlobalDeclaration.role_name;
            }

            //set all text boxes to enable user edit
            txtUserName.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtEmail.ReadOnly = false;
            cboRole.Enabled = true;

        }

        private void btnBacktoAdmin_Click(object sender, EventArgs e)
        {
            Admin a =new Admin();
            this.Close();
            a.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this record?",
                                      "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                sql = "Delete * from users where user_ID =" + txtUserID.Text;
                DBHelper.DBHelper.ModifyRecord(sql);
                MngAccounts_Load(sender, e);
                clearfields();
                setAccesibility();
            }
        }

        public void clearfields() 
        {
            txtUserID.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            cboRole.SelectedItem = null;
            dgvAccounts.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get role ID
            GetMaxItemNo.GetData.getRoleID(cboRole.Text);
            sql = "Update users SET user_name = '"+ txtUserName.Text + 
                "', user_password = '"+ txtPassword.Text + 
                "', users.email = '"+txtEmail.Text+ 
                "', role_ID = "+ GetMaxItemNo.GlobalDeclaration.role_ID.ToString()+
                " Where user_ID = "+ txtUserID.Text;
            DBHelper.DBHelper.ModifyRecord(sql);
            MessageBox.Show("Users has been updated...", "Update User Accounts",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            MngAccounts_Load(sender, e);
            clearfields();
            setAccesibility();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearfields();
            setAccesibility();
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
