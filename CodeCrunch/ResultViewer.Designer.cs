namespace CodeCrunch
{
    partial class ResultViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultViewer));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnQuizOverview = new System.Windows.Forms.Button();
            this.btnDetailedReport = new System.Windows.Forms.Button();
            this.gboDetailedReport = new System.Windows.Forms.GroupBox();
            this.gboOverviewReport = new System.Windows.Forms.GroupBox();
            this.crptOverviewResult = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.OverviewReport1 = new CodeCrunch.OverviewReport();
            this.overviewReport2 = new CodeCrunch.OverviewReport();
            this.crptDetailedReport = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.DeatiledReport1 = new CodeCrunch.DeatiledReport();
            this.DeatiledReport2 = new CodeCrunch.DeatiledReport();
            this.gboDetailedReport.SuspendLayout();
            this.gboOverviewReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(16, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(222, 28);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome Student!";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1080, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(235, 49);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to Dashboard";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnQuizOverview
            // 
            this.btnQuizOverview.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuizOverview.Location = new System.Drawing.Point(401, 40);
            this.btnQuizOverview.Name = "btnQuizOverview";
            this.btnQuizOverview.Size = new System.Drawing.Size(259, 44);
            this.btnQuizOverview.TabIndex = 8;
            this.btnQuizOverview.Text = "Quiz Overview";
            this.btnQuizOverview.UseVisualStyleBackColor = true;
            this.btnQuizOverview.Click += new System.EventHandler(this.btnQuizOverview_Click);
            // 
            // btnDetailedReport
            // 
            this.btnDetailedReport.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailedReport.Location = new System.Drawing.Point(666, 40);
            this.btnDetailedReport.Name = "btnDetailedReport";
            this.btnDetailedReport.Size = new System.Drawing.Size(259, 45);
            this.btnDetailedReport.TabIndex = 9;
            this.btnDetailedReport.Text = "Quiz Detailed Report";
            this.btnDetailedReport.UseVisualStyleBackColor = true;
            this.btnDetailedReport.Click += new System.EventHandler(this.btnDetailedReport_Click);
            // 
            // gboDetailedReport
            // 
            this.gboDetailedReport.BackColor = System.Drawing.Color.Azure;
            this.gboDetailedReport.Controls.Add(this.crptDetailedReport);
            this.gboDetailedReport.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDetailedReport.Location = new System.Drawing.Point(22, 92);
            this.gboDetailedReport.Name = "gboDetailedReport";
            this.gboDetailedReport.Size = new System.Drawing.Size(1297, 748);
            this.gboDetailedReport.TabIndex = 8;
            this.gboDetailedReport.TabStop = false;
            this.gboDetailedReport.Text = "Detailed Report";
            this.gboDetailedReport.Visible = false;
            // 
            // gboOverviewReport
            // 
            this.gboOverviewReport.BackColor = System.Drawing.Color.Azure;
            this.gboOverviewReport.Controls.Add(this.crptOverviewResult);
            this.gboOverviewReport.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboOverviewReport.Location = new System.Drawing.Point(20, 92);
            this.gboOverviewReport.Name = "gboOverviewReport";
            this.gboOverviewReport.Size = new System.Drawing.Size(1299, 749);
            this.gboOverviewReport.TabIndex = 7;
            this.gboOverviewReport.TabStop = false;
            this.gboOverviewReport.Text = "Overview Report";
            // 
            // crptOverviewResult
            // 
            this.crptOverviewResult.ActiveViewIndex = 0;
            this.crptOverviewResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptOverviewResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptOverviewResult.DisplayStatusBar = false;
            this.crptOverviewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptOverviewResult.EnableToolTips = false;
            this.crptOverviewResult.Location = new System.Drawing.Point(3, 19);
            this.crptOverviewResult.Name = "crptOverviewResult";
            this.crptOverviewResult.ReportSource = this.OverviewReport1;
            this.crptOverviewResult.Size = new System.Drawing.Size(1293, 727);
            this.crptOverviewResult.TabIndex = 6;
            this.crptOverviewResult.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // crptDetailedReport
            // 
            this.crptDetailedReport.ActiveViewIndex = 0;
            this.crptDetailedReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crptDetailedReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.crptDetailedReport.DisplayStatusBar = false;
            this.crptDetailedReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crptDetailedReport.EnableToolTips = false;
            this.crptDetailedReport.Location = new System.Drawing.Point(3, 19);
            this.crptDetailedReport.Name = "crptDetailedReport";
            this.crptDetailedReport.ReportSource = this.DeatiledReport1;
            this.crptDetailedReport.Size = new System.Drawing.Size(1291, 726);
            this.crptDetailedReport.TabIndex = 6;
            this.crptDetailedReport.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crptDetailedReport.Visible = false;
            // 
            // ResultViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1344, 862);
            this.Controls.Add(this.gboOverviewReport);
            this.Controls.Add(this.btnDetailedReport);
            this.Controls.Add(this.btnQuizOverview);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.gboDetailedReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result Viewer";
            this.Load += new System.EventHandler(this.ResultViewer_Load);
            this.gboDetailedReport.ResumeLayout(false);
            this.gboOverviewReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnQuizOverview;
        private System.Windows.Forms.Button btnDetailedReport;
        //private ResultNotUsed ResultNotUsed1;
        //private QuizResultOverview QuizResultOverview1;
        private OverviewReport OverviewReport1;
        //private QuizReport QuizResult1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptDetailedReport;
        private System.Windows.Forms.GroupBox gboDetailedReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crptOverviewResult;
        private System.Windows.Forms.GroupBox gboOverviewReport;
        private DeatiledReport DeatiledReport1;
        private OverviewReport overviewReport2;
        private DeatiledReport DeatiledReport2;
    }
}