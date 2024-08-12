namespace CodeCrunch
{
    partial class TakeQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TakeQuiz));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.cboDifficulty = new System.Windows.Forms.ComboBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.rbtnChoice1 = new System.Windows.Forms.RadioButton();
            this.rbtnChoice2 = new System.Windows.Forms.RadioButton();
            this.rbtnChoice3 = new System.Windows.Forms.RadioButton();
            this.gboChoices = new System.Windows.Forms.GroupBox();
            this.lblChoice3 = new System.Windows.Forms.Label();
            this.lblChoice2 = new System.Windows.Forms.Label();
            this.lblChoice1 = new System.Windows.Forms.Label();
            this.btnViewResult = new System.Windows.Forms.Button();
            this.btnBackDB = new System.Windows.Forms.Button();
            this.tmrQuiz = new System.Windows.Forms.Timer(this.components);
            this.txtTimerLabel = new System.Windows.Forms.TextBox();
            this.gboQuestion = new System.Windows.Forms.GroupBox();
            this.gboChoices.SuspendLayout();
            this.gboQuestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 22);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(206, 28);
            this.lblWelcome.TabIndex = 4;
            this.lblWelcome.Text = "Welcome Student!";
            // 
            // cboDifficulty
            // 
            this.cboDifficulty.AutoCompleteCustomSource.AddRange(new string[] {
            "Easy",
            "Normal",
            "Hard"});
            this.cboDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDifficulty.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDifficulty.FormattingEnabled = true;
            this.cboDifficulty.Location = new System.Drawing.Point(426, 86);
            this.cboDifficulty.Name = "cboDifficulty";
            this.cboDifficulty.Size = new System.Drawing.Size(184, 29);
            this.cboDifficulty.TabIndex = 6;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(334, 90);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(84, 21);
            this.lblDifficulty.TabIndex = 7;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuiz.Location = new System.Drawing.Point(1102, 70);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(213, 57);
            this.btnStartQuiz.TabIndex = 8;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = true;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(714, 86);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(295, 29);
            this.cboCategory.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(626, 89);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(82, 21);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(13, 29);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(1274, 96);
            this.txtQuestion.TabIndex = 9;
            this.txtQuestion.Text = "Question";
            this.txtQuestion.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(619, 618);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(201, 63);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rbtnChoice1
            // 
            this.rbtnChoice1.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnChoice1.AutoSize = true;
            this.rbtnChoice1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChoice1.Location = new System.Drawing.Point(138, 46);
            this.rbtnChoice1.Name = "rbtnChoice1";
            this.rbtnChoice1.Size = new System.Drawing.Size(91, 32);
            this.rbtnChoice1.TabIndex = 10;
            this.rbtnChoice1.Text = "Choice 1";
            this.rbtnChoice1.UseVisualStyleBackColor = true;
            // 
            // rbtnChoice2
            // 
            this.rbtnChoice2.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnChoice2.AutoSize = true;
            this.rbtnChoice2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChoice2.Location = new System.Drawing.Point(138, 124);
            this.rbtnChoice2.Name = "rbtnChoice2";
            this.rbtnChoice2.Size = new System.Drawing.Size(91, 32);
            this.rbtnChoice2.TabIndex = 10;
            this.rbtnChoice2.Text = "Choice 2";
            this.rbtnChoice2.UseVisualStyleBackColor = true;
            // 
            // rbtnChoice3
            // 
            this.rbtnChoice3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtnChoice3.AutoSize = true;
            this.rbtnChoice3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChoice3.Location = new System.Drawing.Point(138, 205);
            this.rbtnChoice3.Name = "rbtnChoice3";
            this.rbtnChoice3.Size = new System.Drawing.Size(91, 32);
            this.rbtnChoice3.TabIndex = 10;
            this.rbtnChoice3.Text = "Choice 3";
            this.rbtnChoice3.UseVisualStyleBackColor = true;
            // 
            // gboChoices
            // 
            this.gboChoices.BackColor = System.Drawing.SystemColors.Control;
            this.gboChoices.Controls.Add(this.lblChoice3);
            this.gboChoices.Controls.Add(this.lblChoice2);
            this.gboChoices.Controls.Add(this.lblChoice1);
            this.gboChoices.Controls.Add(this.rbtnChoice1);
            this.gboChoices.Controls.Add(this.rbtnChoice3);
            this.gboChoices.Controls.Add(this.rbtnChoice2);
            this.gboChoices.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboChoices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gboChoices.Location = new System.Drawing.Point(23, 278);
            this.gboChoices.Name = "gboChoices";
            this.gboChoices.Size = new System.Drawing.Size(1300, 301);
            this.gboChoices.TabIndex = 11;
            this.gboChoices.TabStop = false;
            this.gboChoices.Text = "Choose your answer";
            this.gboChoices.Visible = false;
            // 
            // lblChoice3
            // 
            this.lblChoice3.AutoSize = true;
            this.lblChoice3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice3.Location = new System.Drawing.Point(43, 211);
            this.lblChoice3.Name = "lblChoice3";
            this.lblChoice3.Size = new System.Drawing.Size(77, 21);
            this.lblChoice3.TabIndex = 16;
            this.lblChoice3.Text = "Choice 3";
            // 
            // lblChoice2
            // 
            this.lblChoice2.AutoSize = true;
            this.lblChoice2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice2.Location = new System.Drawing.Point(43, 130);
            this.lblChoice2.Name = "lblChoice2";
            this.lblChoice2.Size = new System.Drawing.Size(77, 21);
            this.lblChoice2.TabIndex = 16;
            this.lblChoice2.Text = "Choice 2";
            // 
            // lblChoice1
            // 
            this.lblChoice1.AutoSize = true;
            this.lblChoice1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice1.Location = new System.Drawing.Point(43, 53);
            this.lblChoice1.Name = "lblChoice1";
            this.lblChoice1.Size = new System.Drawing.Size(77, 21);
            this.lblChoice1.TabIndex = 16;
            this.lblChoice1.Text = "Choice 1";
            // 
            // btnViewResult
            // 
            this.btnViewResult.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewResult.Location = new System.Drawing.Point(1102, 69);
            this.btnViewResult.Name = "btnViewResult";
            this.btnViewResult.Size = new System.Drawing.Size(213, 59);
            this.btnViewResult.TabIndex = 12;
            this.btnViewResult.Text = "View Result";
            this.btnViewResult.UseVisualStyleBackColor = true;
            this.btnViewResult.UseWaitCursor = true;
            this.btnViewResult.Visible = false;
            this.btnViewResult.Click += new System.EventHandler(this.btnViewResult_Click);
            // 
            // btnBackDB
            // 
            this.btnBackDB.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackDB.Location = new System.Drawing.Point(44, 69);
            this.btnBackDB.Name = "btnBackDB";
            this.btnBackDB.Size = new System.Drawing.Size(213, 57);
            this.btnBackDB.TabIndex = 13;
            this.btnBackDB.Text = "Back";
            this.btnBackDB.UseVisualStyleBackColor = true;
            this.btnBackDB.Click += new System.EventHandler(this.btnBackDB_Click);
            // 
            // tmrQuiz
            // 
            this.tmrQuiz.Interval = 1000;
            this.tmrQuiz.Tick += new System.EventHandler(this.tmrQuiz_Tick);
            // 
            // txtTimerLabel
            // 
            this.txtTimerLabel.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimerLabel.Location = new System.Drawing.Point(426, 22);
            this.txtTimerLabel.Name = "txtTimerLabel";
            this.txtTimerLabel.ReadOnly = true;
            this.txtTimerLabel.Size = new System.Drawing.Size(583, 34);
            this.txtTimerLabel.TabIndex = 14;
            this.txtTimerLabel.Text = "Timer";
            this.txtTimerLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTimerLabel.Visible = false;
            // 
            // gboQuestion
            // 
            this.gboQuestion.BackColor = System.Drawing.SystemColors.Control;
            this.gboQuestion.Controls.Add(this.txtQuestion);
            this.gboQuestion.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboQuestion.Location = new System.Drawing.Point(24, 134);
            this.gboQuestion.Name = "gboQuestion";
            this.gboQuestion.Size = new System.Drawing.Size(1300, 134);
            this.gboQuestion.TabIndex = 15;
            this.gboQuestion.TabStop = false;
            this.gboQuestion.Text = "Question";
            this.gboQuestion.Visible = false;
            // 
            // TakeQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1352, 709);
            this.Controls.Add(this.txtTimerLabel);
            this.Controls.Add(this.btnBackDB);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboDifficulty);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.gboChoices);
            this.Controls.Add(this.gboQuestion);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.btnViewResult);
            this.Controls.Add(this.btnNext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TakeQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Take Quiz";
            this.Load += new System.EventHandler(this.TakeQuiz_Load);
            this.gboChoices.ResumeLayout(false);
            this.gboChoices.PerformLayout();
            this.gboQuestion.ResumeLayout(false);
            this.gboQuestion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ComboBox cboDifficulty;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rbtnChoice1;
        private System.Windows.Forms.RadioButton rbtnChoice2;
        private System.Windows.Forms.RadioButton rbtnChoice3;
        private System.Windows.Forms.GroupBox gboChoices;
        private System.Windows.Forms.Button btnViewResult;
        private System.Windows.Forms.Button btnBackDB;
        private System.Windows.Forms.Timer tmrQuiz;
        private System.Windows.Forms.TextBox txtTimerLabel;
        private System.Windows.Forms.GroupBox gboQuestion;
        private System.Windows.Forms.Label lblChoice1;
        private System.Windows.Forms.Label lblChoice3;
        private System.Windows.Forms.Label lblChoice2;
    }
}