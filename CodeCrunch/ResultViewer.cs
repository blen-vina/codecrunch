using CodeCrunch.GetMaxItemNo;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCrunch
{
    public partial class ResultViewer : Form
    {
        //TakeQuiz tq = new TakeQuiz();
        public int total_points;
        public ResultViewer()
        {
            InitializeComponent();
        }


        /*private void Student_Load(object sender, EventArgs e)
        {
            //Default Report Visibility 
            gboDetailedReport.Visible = false;
            crptQuizResult.Visible = false;
            //
            gboOverviewReport.Visible = true;
            crptOverviewReport.Visible = true;

            lblWelcome.Text = "Hello " + Login.sendtext + "!";
        }*/
        private void loadReport()
        {
            try
            {


                //create instance of overview report
                ReportDocument rd = new ReportDocument();
                rd.Load("C:\\Users\\blenv\\source\\repos\\CSharp\\CodeCrunch\\CodeCrunch\\OverviewReport.rpt");
                //rd.Load("C:\\Users\\blenv\\source\\repos\\CSharp\\CodeCrunch\\CodeCrunch\\DeatiledReport.rpt");
                

                //set prameter value
                ParameterFieldDefinitions pfds = rd.DataDefinition.ParameterFields;
                ParameterFieldDefinition pfd = pfds["TotalPoints"];
                ParameterValues pv = new ParameterValues();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();

                //asign total points to you parameter dicrete values
                pdv.Value = total_points;
                pv.Add(pdv);
                pfd.ApplyCurrentValues(pv);

                //refresh report viewer
                crptOverviewResult.ReportSource = rd;
                crptOverviewResult.Refresh();

                //MessageBox.Show("Report loaded successfully with TotalPoints: " + total_points.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            this.Close();
            s.Show();
        }



        private void btnQuizOverview_Click(object sender, EventArgs e)
        {
            //Overview Report Visibility 
            gboDetailedReport.Visible = false;
            crptDetailedReport.Visible = false;
            //
            gboOverviewReport.Visible = true;
            crptOverviewResult.Visible = true;
        }

        private void btnDetailedReport_Click(object sender, EventArgs e)
        {
            //Detailed Report Visibility 
            gboDetailedReport.Visible = true;
            crptDetailedReport.Visible = true;
            //
            gboOverviewReport.Visible = false;
            crptOverviewResult.Visible = false;
        }

        private void ResultViewer_Load(object sender, EventArgs e)
        {
            //TakeQuiz tq = new TakeQuiz();
            total_points = TakeQuiz.sendvalue;

            //load report with param values
            loadReport();

            //Default Report Visibility 
            gboDetailedReport.Visible = false;
            crptDetailedReport.Visible = false;
            //
            gboOverviewReport.Visible = true;
            crptOverviewResult.Visible  = true;

            lblWelcome.Text = "Hello " + GetData.capitalizeFirstLetter(Login.sendtext) + "!";
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
