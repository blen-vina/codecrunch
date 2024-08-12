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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            lblWelcome.Text = "Hello " + GetData.capitalizeFirstLetter(Login.sendtext) + "!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Close();
            l.Show();
        }

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            this.Close();
            r.Show();
        }

        private void btnManageAccounts_Click(object sender, EventArgs e)
        {
            MngAccounts m = new MngAccounts();
            this.Close();
            m.Show();
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
