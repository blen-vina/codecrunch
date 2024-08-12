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
    public partial class Student : Form
    {
        public string student_name = Login.sendtext;
        public string form;
        public Student()
        {
            InitializeComponent();           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();      
            this.Close();
            l.Show();
            
        }

        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {          
            TakeQuiz t = new TakeQuiz();
            this.Close();
            t.Show();
        }        

        private void Student_Load(object sender, EventArgs e)
        {
            //Welcome label
            lblWelcome.Text = "Hello " + GetData.capitalizeFirstLetter(student_name) + "!";
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
