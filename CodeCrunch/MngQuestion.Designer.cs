namespace CodeCrunch
{
    partial class MngQuestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MngQuestion));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblQuestionID = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblCorrectAns = new System.Windows.Forms.Label();
            this.lblWrongAns1 = new System.Windows.Forms.Label();
            this.lblWrongAns2 = new System.Windows.Forms.Label();
            this.txtQuestionID = new System.Windows.Forms.TextBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtCorrectAns = new System.Windows.Forms.TextBox();
            this.txtWrongAns1 = new System.Windows.Forms.TextBox();
            this.txtWrongAns2 = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.chkEnable = new System.Windows.Forms.CheckBox();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cboDifficulty = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvQuestions.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvQuestions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuestions.Location = new System.Drawing.Point(35, 373);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.RowHeadersWidth = 51;
            this.dgvQuestions.RowTemplate.Height = 24;
            this.dgvQuestions.Size = new System.Drawing.Size(1499, 360);
            this.dgvQuestions.TabIndex = 5;
            this.dgvQuestions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuestions_CellClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(656, 317);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(1240, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(176, 39);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblQuestionID
            // 
            this.lblQuestionID.AutoSize = true;
            this.lblQuestionID.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionID.Location = new System.Drawing.Point(92, 57);
            this.lblQuestionID.Name = "lblQuestionID";
            this.lblQuestionID.Size = new System.Drawing.Size(133, 21);
            this.lblQuestionID.TabIndex = 4;
            this.lblQuestionID.Text = "Question ID *";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(92, 100);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(105, 21);
            this.lblQuestion.TabIndex = 4;
            this.lblQuestion.Text = "Question *";
            // 
            // lblCorrectAns
            // 
            this.lblCorrectAns.AutoSize = true;
            this.lblCorrectAns.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAns.Location = new System.Drawing.Point(92, 145);
            this.lblCorrectAns.Name = "lblCorrectAns";
            this.lblCorrectAns.Size = new System.Drawing.Size(165, 21);
            this.lblCorrectAns.TabIndex = 4;
            this.lblCorrectAns.Text = "Correct Answer *";
            this.lblCorrectAns.Click += new System.EventHandler(this.lblCorrectAns_Click);
            // 
            // lblWrongAns1
            // 
            this.lblWrongAns1.AutoSize = true;
            this.lblWrongAns1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAns1.Location = new System.Drawing.Point(92, 192);
            this.lblWrongAns1.Name = "lblWrongAns1";
            this.lblWrongAns1.Size = new System.Drawing.Size(171, 21);
            this.lblWrongAns1.TabIndex = 4;
            this.lblWrongAns1.Text = "Wrong Answer 1 *";
            // 
            // lblWrongAns2
            // 
            this.lblWrongAns2.AutoSize = true;
            this.lblWrongAns2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWrongAns2.Location = new System.Drawing.Point(92, 240);
            this.lblWrongAns2.Name = "lblWrongAns2";
            this.lblWrongAns2.Size = new System.Drawing.Size(171, 21);
            this.lblWrongAns2.TabIndex = 4;
            this.lblWrongAns2.Text = "Wrong Answer 2 *";
            // 
            // txtQuestionID
            // 
            this.txtQuestionID.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestionID.Location = new System.Drawing.Point(275, 51);
            this.txtQuestionID.Name = "txtQuestionID";
            this.txtQuestionID.ReadOnly = true;
            this.txtQuestionID.Size = new System.Drawing.Size(130, 28);
            this.txtQuestionID.TabIndex = 7;
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(275, 97);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(1139, 28);
            this.txtQuestion.TabIndex = 7;
            // 
            // txtCorrectAns
            // 
            this.txtCorrectAns.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrectAns.Location = new System.Drawing.Point(275, 142);
            this.txtCorrectAns.Name = "txtCorrectAns";
            this.txtCorrectAns.Size = new System.Drawing.Size(1139, 28);
            this.txtCorrectAns.TabIndex = 7;
            // 
            // txtWrongAns1
            // 
            this.txtWrongAns1.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWrongAns1.Location = new System.Drawing.Point(275, 189);
            this.txtWrongAns1.Name = "txtWrongAns1";
            this.txtWrongAns1.Size = new System.Drawing.Size(1139, 28);
            this.txtWrongAns1.TabIndex = 7;
            // 
            // txtWrongAns2
            // 
            this.txtWrongAns2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWrongAns2.Location = new System.Drawing.Point(275, 237);
            this.txtWrongAns2.Name = "txtWrongAns2";
            this.txtWrongAns2.Size = new System.Drawing.Size(1139, 28);
            this.txtWrongAns2.TabIndex = 7;
            this.txtWrongAns2.TextChanged += new System.EventHandler(this.txtWrongAns2_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(408, 53);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(106, 21);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category *";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(517, 51);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(246, 29);
            this.cboCategory.TabIndex = 8;
            // 
            // chkEnable
            // 
            this.chkEnable.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnable.Location = new System.Drawing.Point(1085, 54);
            this.chkEnable.Name = "chkEnable";
            this.chkEnable.Size = new System.Drawing.Size(345, 28);
            this.chkEnable.TabIndex = 9;
            this.chkEnable.Text = "Check if you want to publish question";
            this.chkEnable.UseVisualStyleBackColor = true;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(769, 54);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(110, 21);
            this.lblDifficulty.TabIndex = 4;
            this.lblDifficulty.Text = "Difficulty *";
            // 
            // cboDifficulty
            // 
            this.cboDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDifficulty.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDifficulty.FormattingEnabled = true;
            this.cboDifficulty.Location = new System.Drawing.Point(885, 51);
            this.cboDifficulty.Name = "cboDifficulty";
            this.cboDifficulty.Size = new System.Drawing.Size(172, 29);
            this.cboDifficulty.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(275, 317);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(176, 39);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(1047, 317);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 39);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(852, 317);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(176, 39);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MngQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1573, 765);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkEnable);
            this.Controls.Add(this.cboDifficulty);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.txtWrongAns2);
            this.Controls.Add(this.txtWrongAns1);
            this.Controls.Add(this.txtCorrectAns);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.txtQuestionID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.lblWrongAns2);
            this.Controls.Add(this.lblWrongAns1);
            this.Controls.Add(this.lblCorrectAns);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblQuestionID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MngQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Question";
            this.Load += new System.EventHandler(this.MngQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblQuestionID;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblCorrectAns;
        private System.Windows.Forms.Label lblWrongAns1;
        private System.Windows.Forms.Label lblWrongAns2;
        private System.Windows.Forms.TextBox txtQuestionID;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtCorrectAns;
        private System.Windows.Forms.TextBox txtWrongAns1;
        private System.Windows.Forms.TextBox txtWrongAns2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.CheckBox chkEnable;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cboDifficulty;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}