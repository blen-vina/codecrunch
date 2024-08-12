using CodeCrunch.GetMaxItemNo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace CodeCrunch
{
    public partial class TakeQuiz : Form
    {
        public string sql = "";
        public int questionIndex;
        public int question_ID;
        public string userAnswer;
        public string correctAnswer;
        public string student_name= Login.sendtext;
        public int check;
        public int totalpoint=0;
        public int question_count=0;
        public static int question_limit;
        public int time_limit;
        public static int sendvalue;
        public int time_left, time_limit_temp;
        public int duration;
        public int durationtemp = 0;
        public string validateArraySizeMsg;
        public TakeQuiz()
        {
            InitializeComponent();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            //Check if user chose a category and a difficulty level
            if (string.IsNullOrEmpty(cboCategory.Text) || string.IsNullOrEmpty(cboDifficulty.Text))
            {
                MessageBox.Show("Choose a difficulty and category.");
                //resetFields();
                cboCategory.Enabled = true;
                cboDifficulty.Enabled = true;
                return;
            }
            //Setting visibility
            btnStartQuiz.Visible = false;
            btnBackDB.Visible = false;
            cboCategory.Enabled = false;
            cboDifficulty.Enabled = false;
            txtTimerLabel.Visible = true;
            txtQuestion.Visible = true;
            gboQuestion.Visible = true;
            gboChoices.Visible = true;
            btnNext.Visible = true;

            
            try
            {
                //Get and Store question IDs based on the category and difficulty user selected
                GetData.getCategoryID(cboCategory.Text);
                GetData.getQuestionID_Array(GlobalDeclaration.category_ID, cboDifficulty.Text);

                // set question limit base on difficulty level
                setQuestionLimit(cboDifficulty.Text);

                // set time limit base on difficulty level
                setTimeLimit(cboDifficulty.Text);
                time_limit = (int)TimeSpan.FromMinutes(GlobalDeclaration.timeLimit).TotalSeconds;
                time_left = time_limit;
                time_limit_temp = time_limit;
                tmrQuiz.Start();

                //Validate if quiz for category and difficulty is not empty
                if (validateArraySize() == false)
                {
                    resetFields();
                    MessageBox.Show(validateArraySizeMsg + " Choose another difficulty and category.");
                    cboCategory.Enabled = true;
                    cboDifficulty.Enabled = true;
                    return;
                }
                
                //shuffle the retrieved question IDs
                ShuffleQuestionIDs();

                //method to pull questions and answers from sql
                questionIndex = GlobalDeclaration.shuffledQuestionIDs.Length-1; //change number of questions base on difficulty level               
                //questionIndex = SelectRandomQuestionID();
                txtQuestion.Text = getQuestion(); //make random

                getAnswer(); //make random sort
                ShuffleAndSetChoices();
                

                //after displaying sytem will wait for user to click button next
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ----> Start Quiz, " + ex.Message);
            }

        }
        public static void setQuestionLimit(string difficulty) 
        {
            GetData.setQuestionLimit(difficulty);
            question_limit = GlobalDeclaration.questionLimit;
        }

        public static void setTimeLimit(string difficulty) 
        {
            GetData.setTimeLimit(difficulty);
        }

        //Shuffle question IDs in questionIDArr and store in shuffledQuestionIDs
        private void ShuffleQuestionIDs()
        {
            /*if (GlobalDeclaration.questionID_Arr == null || GlobalDeclaration.questionID_Arr.Length == 0)
            {
                MessageBox.Show("Question ID array cannot be null or empty");
                resetFields();
                return;
            }*/

            GlobalDeclaration.shuffledQuestionIDs = (int[])GlobalDeclaration.questionID_Arr.Clone();

            Random random = new Random();
            int n = GlobalDeclaration.shuffledQuestionIDs.Length;
            for (int i = n - 1; i > 0; i--)
            {
                int randomIndex = random.Next(i + 1);
                int temp = GlobalDeclaration.shuffledQuestionIDs[i];
                GlobalDeclaration.shuffledQuestionIDs[i] = GlobalDeclaration.shuffledQuestionIDs[randomIndex];
                GlobalDeclaration.shuffledQuestionIDs[randomIndex] = temp;
            }
        }

        //Get random question ID from the questionID array in global declation
        /*        public static int SelectRandomQuestionID()
                {
                    try
                    {
                        // Check if the array is empty
                        if (GlobalDeclaration.questionID_Arr == null || GlobalDeclaration.questionID_Arr.Length == 0)
                        {
                            throw new ArgumentException("Question ID array cannot be null or empty");
                        }

                        //Get a random index to get the question ID randomly
                        Random random = new Random();
                        int randomIndex = random.Next(GlobalDeclaration.questionID_Arr.Length);

                        //storing the selected question ID to the array selected list for viewing results
                        GlobalDeclaration.selectedQuestionID = GlobalDeclaration.questionID_Arr[randomIndex];
                        List<int> selectedList = new List<int>();
                        selectedList.Add(GlobalDeclaration.selectedQuestionID);

                        GlobalDeclaration.selectedQuestionID_Arr = selectedList.ToArray();

                        // Remove the selected question ID from the original array
                        List<int> remainingList = new List<int>(GlobalDeclaration.questionID_Arr);
                        remainingList.RemoveAt(randomIndex);
                        GlobalDeclaration.questionID_Arr = remainingList.ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error ----> Select Random QuestionID, " + ex.Message);
                    }
                    return GlobalDeclaration.selectedQuestionID;
                }

                private string getQuestion()
                {
                    try
                    {
                        question_ID = SelectRandomQuestionID();
                        GetData.getQuestion(question_ID);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error ----> Get Question, " + ex.Message);
                    }
                    return GlobalDeclaration.question;

                }*/


        private string getQuestion()
        {
            try
            {
                //check if 
                question_ID = GlobalDeclaration.shuffledQuestionIDs[questionIndex]; //question index should be random
                GetData.getQuestion(question_ID);

                // storing the selected question ID to the array selected list for viewing results
                GlobalDeclaration.selectedQuestionID = GlobalDeclaration.shuffledQuestionIDs[questionIndex];
                List<int> selectedList = new List<int>();
                selectedList.Add(GlobalDeclaration.selectedQuestionID);

                // Remove the selected question ID from the original array
                List<int> remainingList = new List<int>(GlobalDeclaration.shuffledQuestionIDs);
                remainingList.RemoveAt(questionIndex);
                GlobalDeclaration.shuffledQuestionIDs = remainingList.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ----> Get Question, " + ex.Message);
            }

            //#transaction
            //counting questions displayed to check later with the question limit based on the difficulty level
            question_count += 1;
            return GlobalDeclaration.question;

        }

        private Boolean validateArraySize() 
        {
            if (GlobalDeclaration.questionID_Arr == null || GlobalDeclaration.questionID_Arr.Length == 0)
            {
                validateArraySizeMsg = "The Quiz is Empty!";
                return false;
            }
            else if (GlobalDeclaration.questionID_Arr.Length < question_limit)
            {
                validateArraySizeMsg = "The Quiz is incomplete!";
                return false;
            }
            return true;
        }

        private void resetFields() 
        {
            btnStartQuiz.Visible = true;
            btnBackDB.Visible = true;
            txtTimerLabel.Visible = false;
            txtQuestion.Visible = false;
            gboQuestion.Visible = false;
            gboChoices.Visible = false;
            btnNext.Visible = false;
            cboCategory.Text = "";
            cboDifficulty.Text = "";
        }

        private void getAnswer()
        {           
            GetData.getAnswer_Array(question_ID);            
        }

        private Boolean validAnswer() 
        {
            if (rbtnChoice1.Checked == true)
            {
                userAnswer = rbtnChoice1.Text;
                return true;
            }
            else if (rbtnChoice2.Checked == true)
            {
                userAnswer = rbtnChoice2.Text;
                return true;
            }
            else if (rbtnChoice3.Checked == true)
            {
                userAnswer = rbtnChoice3.Text;
                return true;
            }

            return false;
        }

        private void clearChoices() 
        {
            rbtnChoice1.Checked = false; 
            rbtnChoice2.Checked = false; 
            rbtnChoice3.Checked = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            //check answer if exist
            if (validAnswer() == false)
            {
                MessageBox.Show("Please choose an answer.");
                return;
            }
            else 
            {   //get correct answer
                GetData.getCorrectAnswer(question_ID);
                correctAnswer = GlobalDeclaration.correct_answer;
                //validate answers if correct
                check = validateAnswer();
                if (check == 1)
                {
                    MessageBox.Show("Your answer is correct!");
                    addTotalPoints(check);
                }
                else 
                {
                    MessageBox.Show("Your answer is incorrect. The right answer is " + correctAnswer);
                }
                
                //#transaction
                //Measure how long student took to answer every question to use later in the report on how is his speed in answering the whole quiz
                duration = time_limit_temp - time_left;
                time_limit_temp = time_left;
                
                //store data in result table for report form
                addQuizResult();

                //clear radio button choices from the previous question
                clearChoices();

                //validate if quiz is not empty
                if (question_count == question_limit)
                {
                    resetFields();
                    btnStartQuiz.Visible = false;
                    btnBackDB.Visible = false;
                    btnNext.Visible = false;
                    btnViewResult.Visible = true;
                    MessageBox.Show("You have successfully finished the quiz!");
                    tmrQuiz.Stop();
                    return;

                    //system will wait for user action which is to view result
                }

                //if not empty display new question
                //create method for setting questions
                questionIndex = questionIndex - 1;
                //questionIndex = SelectRandomQuestionID();
                txtQuestion.Text = getQuestion();

                //create method for setting choices randomly
                getAnswer();
                ShuffleAndSetChoices();

                //sytem again will wait for user to click next button to decide next step
            }           
        }

        public void ShuffleAndSetChoices()
        {
            // set answerArrLength same with length of GlobalDeclaration.answer_Arr
            int answerArrLength = GlobalDeclaration.answer_Arr.Length;

            // Shuffling the array
            Random random = new Random();
            for (int i = answerArrLength - 1; i > 0; i--)
            {
                int randomIndex = random.Next(i + 1);
                // Swap elements
                var temp = GlobalDeclaration.answer_Arr[i];
                GlobalDeclaration.answer_Arr[i] = GlobalDeclaration.answer_Arr[randomIndex];
                GlobalDeclaration.answer_Arr[randomIndex] = temp;
            }

            // Setting shuffled choices to radio buttons
            rbtnChoice1.Text = GlobalDeclaration.answer_Arr[0];
            rbtnChoice2.Text = GlobalDeclaration.answer_Arr[1];
            rbtnChoice3.Text = GlobalDeclaration.answer_Arr[2];

            // System again will wait for user to click next button to decide next step
        }

        //validate if answer is correct
        public int validateAnswer() 
        {
            if (correctAnswer == userAnswer) 
            {
                return 1;
            }
            return 0;
        }

        //#transaction
        //count points
        public void addTotalPoints(int value) 
        {
            totalpoint = totalpoint + value;
        }

        //#transaction
        private void addQuizResult() 
        {
            student_name = GetData.capitalizeFirstLetter(student_name);

            try 
            {
                //if(check == 1) (point = 1)
                sql = "INSERT INTO result (question_ID, question, correct_answer, user_answer, student_name, difficulty, category_name, point, correct, durationSec) "
                    + "VALUES (" + question_ID + ","
                    + " '" + txtQuestion.Text + "',"
                    //+ " '" + GlobalDeclaration.correct_answer.ToString() + "',"
                    + " '" + correctAnswer + "',"
                    + " '" + userAnswer + "',"
                    + " '" + student_name + "',"
                    + " '" + cboDifficulty.Text + "',"
                    + " '" + cboCategory.Text + "'," 
                    + " " + check + "," 
                    + " " + check + "," //a yes/no data type for db
                    + " " + duration + ")";
                DBHelper.DBHelper.ModifyRecord(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ----> Student addQuizResult, " + ex.Message);
            }
        }

        private void btnViewResult_Click(object sender, EventArgs e)
        {
            sendvalue = totalpoint;
            ResultViewer rv = new ResultViewer();
            this.Close();
            rv.Show();

        }




        private void btnBackDB_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            this.Close();
            student.Show();
        }

        private void TakeQuiz_Load(object sender, EventArgs e)
        {
            //Welcome label
            lblWelcome.Text = "Start Training, " + GetData.capitalizeFirstLetter(student_name) + "!";

            //Delete all records inside result table from previous quiz.
            //create a delete records method for result table and call dbhelper to execute the query
            deleteResultRecords();

            //make sure no other items are inside combo box category and difficulty
            cboCategory.Items.Clear();
            cboDifficulty.Items.Clear();
            //set combo box collection
            setCategoryItems();
            setDifficultyItems();

        }

        private void setCategoryItems() 
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

        private void deleteResultRecords() 
        {
            try
            {
                //check if result table has records to be deleted before performing query
                //checking is not necessary because DELETE sql command removes ZERO or MORE records of a table
                sql = "Delete result.* " +
                      "From result";
                DBHelper.DBHelper.ModifyRecord(sql);
            }

            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET DELETE RESULT RECORDS , " + ex.Message);
            }
        }
    

        private void tmrQuiz_Tick(object sender, EventArgs e)
        {
            
            //initialize time limit of quiz
            //int time_limit = 3;                    
            if (time_left > 0)
            {

                //#transaction
                time_left = time_left - 1;
                TimeSpan timeSpan = TimeSpan.FromSeconds(time_left);
                txtTimerLabel.Text = "Time left : " + timeSpan.Minutes + " Minutes : " + timeSpan.Seconds + " Seconds";

                //Measure how long student took to finish the quiz
                //duration = duration + 1;
            }
            else 
            {
                resetFields();
                btnStartQuiz.Visible = false;
                btnBackDB.Visible = false;
                btnNext.Visible = false;
                btnViewResult.Visible = true;
                txtTimerLabel.Visible = true;
                txtTimerLabel.Text = "Time is Up!";

                tmrQuiz.Stop();
                
            }
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
