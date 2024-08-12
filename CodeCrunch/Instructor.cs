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
    public partial class Instructor : Form
    {
        public string instructor_name = Login.sendtext;
        public Instructor()
        {
            InitializeComponent();
        }

        private void btnMngQuestions_Click(object sender, EventArgs e)
        {
            MngQuestion q = new MngQuestion();
            this.Close();
            q.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Close();
            l.Show();
        }

        private void Instructor_Load(object sender, EventArgs e)
        {
            //Welcome label
            lblWelcome.Text = "Hello " + GetData.capitalizeFirstLetter(instructor_name) + "!";
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
