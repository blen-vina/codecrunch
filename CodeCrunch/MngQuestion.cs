using CodeCrunch.Connections;
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
    public partial class MngQuestion : Form
    {
        private string sql;
        public MngQuestion()
        {
            InitializeComponent();
        }

        private void MngQuestion_Load(object sender, EventArgs e)
        {
            //sql = "SELECT q.question, ca.correct_answer,wa.wrong_answer1, wa.wrong_answer2, c.description FROM ((questions q INNER JOIN correct_answer ca ON q.question_ID = ca.question_ID) INNER JOIN wrong_answer wa ON q.question_ID = wa.question_ID) INNER JOIN category c ON q.categoryID = c.category_ID;";
            /*sql = "SELECT q.question, ca.correct_answer,wa.wrong_answer1, wa.wrong_answer2, c.category_name "
                + "FROM ((questions q "
                + "INNER JOIN correct_answer ca "
                + "ON q.question_ID = ca.question_ID) "
                + "INNER JOIN wrong_answer wa "
                + "ON q.question_ID = wa.question_ID) "
                + "INNER JOIN category c "
                + "ON q.categoryID = c.category_ID;";*/
            
            //button settings on form load
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            //make sure no other items are inside combo box collections
            cboDifficulty.Items.Clear();
            cboCategory.Items.Clear();
            //set combo box collection
            setCategoryItems();
            setDifficultyItems();

            sql = "SELECT q.question_ID, q.question, ca.correct_answer, wa.wrong_answer1, wa.wrong_answer2, c.category_name, q.difficulty, q.enabled "
                + "FROM ((questions AS q "
                + "INNER JOIN correct_answer AS ca "
                + "ON q.question_ID = ca.question_ID) "
                + "INNER JOIN wrong_answer AS wa "
                + "ON q.question_ID = wa.question_ID) "
                + "INNER JOIN category AS c "
                + "ON q.category_ID = c.category_ID";
            DBHelper.DBHelper.fill(sql, dgvQuestions);
            GetMaxItemNo.GetData.getMaxQuestionID();
            txtQuestionID.Text = GetMaxItemNo.GlobalDeclaration.question_ID.ToString();

            //set dgv headers
            set_dgvHeaders();
        }

        // dgvAccounts.Columns[0].HeaderCell.Value = "User ID";
        private void set_dgvHeaders() 
        {
            dgvQuestions.Columns[0].HeaderCell.Value = "Question ID";
            dgvQuestions.Columns[1].HeaderCell.Value = "Question";
            dgvQuestions.Columns[2].HeaderCell.Value = "Correct Answer";
            dgvQuestions.Columns[3].HeaderCell.Value = "Wrong Answer 1";
            dgvQuestions.Columns[4].HeaderCell.Value = "Wrong Answer 2";
            dgvQuestions.Columns[5].HeaderCell.Value = "Category";
            dgvQuestions.Columns[6].HeaderCell.Value = "Difficulty";
            dgvQuestions.Columns[7].HeaderCell.Value = "Published";
        }
        public void setCategoryItems()
        {
            GetData.setcboCategoryNames();
            int size = GlobalDeclaration.categoryNames.Length;
            for (int i = 0; i < size; i++)
            {
                cboCategory.Items.Add(GlobalDeclaration.categoryNames[i]);
            }
            return;
        }

        private void setDifficultyItems()
        {
            GetData.setcboDifficultyNames();
            int size = GlobalDeclaration.difficultyNames.Length;
            for (int i = 0; i < size; i++)
            {
                cboDifficulty.Items.Add(GlobalDeclaration.difficultyNames[i]);
            }
            return;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //btnSave.Enabled = true;
            //btnUpdate.Enabled = false;
            //btnDelete.Enabled = false;
            MngQuestion_Load(sender, e);
            clearfields();
        }

        private void clearfields() 
        {           
            cboCategory.Text = "";
            cboDifficulty.Text = "";
            chkEnable.Checked = false;
            txtQuestion.Clear();
            txtCorrectAns.Clear();  
            txtWrongAns1.Clear();
            txtWrongAns2.Clear();
            dgvQuestions.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //check if all input fields have value
            //validate user input
            if (validInputs())
            {
                AddQuestion();
                AddCorrectAns();
                AddWrongAns();
                MessageBox.Show("Questions and Answers has been added...", "Save new questions and answers",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                MngQuestion_Load(sender, e);
                clearfields();
            }
            else 
            {
                MessageBox.Show("Please complete all the required fields ('*')");
            }
            
        }

        private Boolean validInputs() 
        {
            //check if all inputs fields have data
            if (String.IsNullOrEmpty(txtQuestionID.Text) 
                || String.IsNullOrEmpty(txtQuestion.Text) 
                || String.IsNullOrEmpty(txtCorrectAns.Text) 
                || String.IsNullOrEmpty(txtWrongAns1.Text)
                || String.IsNullOrEmpty(txtWrongAns2.Text)
                || String.IsNullOrEmpty(cboCategory.Text)
                || String.IsNullOrEmpty(cboCategory.Text)) 
            {
                return false;
            }
            return true;
        }

        private void AddQuestion() 
        {
            //get category ID using category name
            getCategoryID();
            //MessageBox.Show(chkEnable.Checked.ToString());
            try
            {
                sql = "INSERT INTO questions(question_ID, question, category_ID, created_Date, enabled, difficulty)" +
                      "VALUES (" + txtQuestionID.Text + "," +
                      " '" + txtQuestion.Text + "'," +
                      " " + GetMaxItemNo.GlobalDeclaration.category_ID.ToString() + "," +
                      " '" + DateTime.Now.ToShortDateString() + "'," +
                      " " + chkEnable.Checked + "," +
                      " '" + cboDifficulty.Text + "')";
                DBHelper.DBHelper.ModifyRecord(sql);
            } 
            catch (Exception ex) 
            {
                MessageBox.Show("Error ----> Manage Questions AddQuestion, " + ex.Message);
            }
        }
        private void getCategoryID() 
        {
            GetMaxItemNo.GetData.getCategoryID(cboCategory.Text);
        }

        private void AddCorrectAns()
        {
            GetMaxItemNo.GetData.getMaxCorrectAnsID();
            try
            {
                sql = "INSERT INTO correct_answer(correct_answer_ID, question_ID, correct_answer)" +
                      "VALUES (" + GlobalDeclaration.correct_answer_ID.ToString() + "," +
                      " " + txtQuestionID.Text + "," +
                      " '" + txtCorrectAns.Text + "')";
                DBHelper.DBHelper.ModifyRecord(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ----> Manage Questions AddCorrAns, " + ex.Message);
            }
        }

        private void AddWrongAns()
        {
            GetMaxItemNo.GetData.getMaxWrongAnsID();
            try
            {
                sql = "INSERT INTO wrong_answer(wrong_answer_ID, question_ID, wrong_answer1, wrong_answer2)" +
                      "VALUES (" + GlobalDeclaration.wrong_answer_ID.ToString() + "," +
                      " " + txtQuestionID.Text + "," +
                      " '" + txtWrongAns1.Text + "'," +
                      " '" + txtWrongAns2.Text + "')";
                DBHelper.DBHelper.ModifyRecord(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ----> Manage Questions AddWrongAns, " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Instructor i = new Instructor();
            this.Close();
            i.Show();
        }
       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            getCategoryID();
            if (validInputs())
            {
                var res = MessageBox.Show("Are you sure you want to update this record?",
                                      "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    updateQuestion();
                    updateCorrectAnswer();
                    updateWrongAnswer();
                    MngQuestion_Load(sender, e);
                    clearfields();
                }
            }
            else
            {
                MessageBox.Show("Please complete all the required fields ('*')");
            }
        }

        private void updateQuestion() 
        {
           
            try
            {
                sql = "Update questions SET question = '" + txtQuestion.Text +
                "', category_ID = " + GlobalDeclaration.category_ID.ToString() +
                ", enabled = " + chkEnable.Checked +
                ", difficulty = '" + cboDifficulty.Text +
                "' Where question_ID = " + txtQuestionID.Text+ "";
                DBHelper.DBHelper.ModifyRecord(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ----> Manage Questions Update Question, " + ex.Message);
            }
        }

        private void updateCorrectAnswer()
        {
            try
            {
                sql = "Update correct_answer SET correct_answer = '" + txtCorrectAns.Text + "' Where question_ID = " + txtQuestionID.Text;
                DBHelper.DBHelper.ModifyRecord(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ----> Manage Questions AddQuestion, " + ex.Message);
            }
        }

        private void updateWrongAnswer()
        {
            try
            {
                sql = "Update wrong_answer SET wrong_answer1 = '" + txtWrongAns1.Text + 
                    "', wrong_answer2 = '" + txtWrongAns2.Text + 
                    "' Where question_ID = " + txtQuestionID.Text;
                DBHelper.DBHelper.ModifyRecord(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ----> Manage Questions AddQuestion, " + ex.Message);
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Are you sure you want to delete this record?",
                                      "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                deleteQuestion(Convert.ToInt32(txtQuestionID.Text));
                deleteCorrectAnswer(Convert.ToInt32(txtQuestionID.Text));
                deleteWrongAnswers(Convert.ToInt32(txtQuestionID.Text));
                MngQuestion_Load(sender, e);
                clearfields();
            }
        }

        private void deleteQuestion(int questionID)
        {
            try
            {
                sql = "DELETE questions.* "
                    + "FROM questions "
                    + "WHERE question_ID = " + questionID;
                DBHelper.DBHelper.ModifyRecord(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ----> Manage Questions AddQuestion, " + ex.Message);
            }
        }
        private void deleteCorrectAnswer(int questionID)
        {
            try
            {
                sql = "DELETE correct_answer.* "
                    + "FROM correct_answer "
                    + "WHERE question_ID = " + questionID;
                DBHelper.DBHelper.ModifyRecord(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ----> Manage Questions AddQuestion, " + ex.Message);
            }
        }
        private void deleteWrongAnswers(int questionID)
        {
            try
            {
                sql = "DELETE wrong_answer.* "
                    + "FROM wrong_answer "
                    + "WHERE question_ID = " + questionID;
                DBHelper.DBHelper.ModifyRecord(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ----> Manage Questions AddQuestion, " + ex.Message);
            }
        }

        private void dgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Populating the input fields from retrieved data inside data grid
            txtQuestionID.Text = dgvQuestions[0, e.RowIndex].Value.ToString();
            txtQuestion.Text = dgvQuestions[1, e.RowIndex].Value.ToString();
            txtCorrectAns.Text = dgvQuestions[2, e.RowIndex].Value.ToString();
            txtWrongAns1.Text = dgvQuestions[3, e.RowIndex].Value.ToString();
            txtWrongAns2.Text = dgvQuestions[4, e.RowIndex].Value.ToString();
            cboCategory.Text = dgvQuestions[5, e.RowIndex].Value.ToString();
            cboDifficulty.Text = dgvQuestions[6, e.RowIndex].Value.ToString();
            //chkEnable.Checked = dgvQuestions[7, e.RowIndex].Value.ToString() == "true";
            chkEnable.Checked = Convert.ToBoolean(dgvQuestions[7, e.RowIndex].Value);

            //set buttons enable or no
            btnSave.Enabled = false;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void lblCorrectAns_Click(object sender, EventArgs e)
        {

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

        private void txtWrongAns2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
