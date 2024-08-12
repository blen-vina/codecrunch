using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CodeCrunch.GetMaxItemNo
{
    internal class GetData
    {
        public static string sql;
        //To retrieve the highest number currently in users table and set a number if no user exist yet
        public static void getMaxUserID()
        {
            try
            {
                sql = "Select MAX(user_ID) from users";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    sql = GlobalDeclaration.reader[0].ToString();
                    if (sql == "")
                    {
                        GlobalDeclaration.user_ID = 1;
                    }
                    else
                    {
                        GlobalDeclaration.user_ID = Convert.ToInt32(GlobalDeclaration.reader[0].ToString()) + 1;
                    }
                    GlobalDeclaration.reader.Close();
                }
                Connections.Connections.conn.Close();
            }

            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET MAX USER ID " + ex.Message);
            }
        }

        //Retrieve highest value of question ID in questions table
        public static void getMaxQuestionID()
        {
            try
            {
                sql = "Select MAX(question_ID) from questions";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    sql = GlobalDeclaration.reader[0].ToString();
                    if (sql == "")
                    {
                        GlobalDeclaration.question_ID = 1;
                    }
                    else
                    {
                        GlobalDeclaration.question_ID = Convert.ToInt32(GlobalDeclaration.reader[0].ToString()) + 1;
                    }
                    GlobalDeclaration.reader.Close();
                }
                Connections.Connections.conn.Close();
            }

            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET MAX QUESTION ID " + ex.Message);
            }
        }

        //Retrieve highest value of correct answer ID in correct answer table
        public static void getMaxCorrectAnsID()
        {
            try
            {
                sql = "Select MAX(correct_answer_ID) from correct_answer";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    sql = GlobalDeclaration.reader[0].ToString();
                    if (sql == "")
                    {
                        GlobalDeclaration.correct_answer_ID = 1;
                    }
                    else
                    {
                        GlobalDeclaration.correct_answer_ID = Convert.ToInt32(GlobalDeclaration.reader[0].ToString()) + 1;
                    }
                    GlobalDeclaration.reader.Close();
                }
                Connections.Connections.conn.Close();
            }

            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET MAX CORRECT ANSWER ID " + ex.Message);
            }
        }
        //Retrieve highest value of wrong answer ID in wrong answer table
        public static void getMaxWrongAnsID()
        {
            try
            {
                sql = "Select MAX(wrong_answer_ID) from wrong_answer";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    sql = GlobalDeclaration.reader[0].ToString();
                    if (sql == "")
                    {
                        GlobalDeclaration.wrong_answer_ID = 1;
                    }
                    else
                    {
                        GlobalDeclaration.wrong_answer_ID = Convert.ToInt32(GlobalDeclaration.reader[0].ToString()) + 1;
                    }
                    GlobalDeclaration.reader.Close();
                }
                Connections.Connections.conn.Close();
            }

            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET MAX WRONG ANSWER ID, " + ex.Message);
            }
        }
        
        public static void getRoleName(int role_ID)
        {
            try
            {
                sql = " Select [role_name]"
                    + " from [role]"
                    + " where [role_ID] = " + role_ID;

                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    GlobalDeclaration.role_name = GlobalDeclaration.reader[0].ToString();
                    GlobalDeclaration.reader.Close();
                }
                Connections.Connections.conn.Close();
            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET ROLE Name, " + ex.Message);
            }

        }

        //Get equivalent role ID for a role assigned to user
        public static void getRoleID(string role_name)
        {
            try
            {
                sql = " Select [role_ID]"
                    + " from [role]"
                    + " where [role_name] = '" + role_name + "'";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    GlobalDeclaration.role_ID = Convert.ToInt32(GlobalDeclaration.reader[0].ToString());
                    GlobalDeclaration.reader.Close();
                }
                Connections.Connections.conn.Close();
            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET ROLE ID, " + ex.Message);
            }

        }

        //Get equivalent category ID for category assigned to question
        public static void getCategoryID(string category_name)
        {
            try
            {
                sql = " Select category_ID"
                    + " From category"
                    + " Where category_name = '" + category_name + "'";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    GlobalDeclaration.category_ID = Convert.ToInt32(GlobalDeclaration.reader[0].ToString());
                    GlobalDeclaration.reader.Close();
                }
                Connections.Connections.conn.Close();

            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET CATEGORY ID, " + ex.Message);
            }
        }

        //Get questions IDs base on category and difficulty
        public static void getQuestionID_Array(int category_ID, string difficulty)
        {
            try
            {
                // SQL query to get question IDs based on category and difficulty
                string sql = "SELECT question_ID " +
                             " FROM questions WHERE category_ID = " + category_ID +
                             " AND difficulty = '" + difficulty + "'" +
                             " AND enabled = " + true + "";


                // Open the database connection
                Connections.Connections.DB();

                // Create and execute the SQL command
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();

                // Create a list to temporarily hold the question IDs
                List<int> questionIDs = new List<int>();

                // Read all the question IDs from the query result
                while (GlobalDeclaration.reader.Read())
                {
                    int questionID = Convert.ToInt32(GlobalDeclaration.reader["question_ID"]);
                    questionIDs.Add(questionID);
                }

                // Close the reader and Connection
                GlobalDeclaration.reader.Close();
                Connections.Connections.conn.Close();

                // Convert the list to an array and store it in the global variable
                GlobalDeclaration.questionID_Arr = questionIDs.ToArray();
            }
            catch (Exception ex)
            {
                // Close the connection in case of an error
                Connections.Connections.conn.Close();

                // Display the error message
                MessageBox.Show("Error ----> GET QUESTION ID ARRAY, " + ex.Message);
            }
        }

        //Get Question using question ID
        public static void getQuestion(int question_ID)
        {
            try
            {
                sql = "Select question "
                + "From questions "
                + "Where question_ID = " + question_ID + "";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    GlobalDeclaration.question = GlobalDeclaration.reader[0].ToString();
                }
                GlobalDeclaration.reader.Close();
                Connections.Connections.conn.Close();
            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET Question, " + ex.Message);
            }
        }

        //Get answer array both correct and wrong for the shuffling of choices
        public static void getAnswer_Array(int question_ID)
        {
            try
            {
                sql = "SELECT ca.correct_answer, wa.wrong_answer1, wa.wrong_answer2 " +
                      "FROM (questions AS q INNER JOIN wrong_answer AS wa ON q.question_ID = wa.question_ID) " +
                      "INNER JOIN correct_answer AS ca ON q.question_ID = ca.question_ID " +
                      "WHERE q.question_ID = " + question_ID;
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();

                List<string> answersList = new List<string>();
                while (GlobalDeclaration.reader.Read())
                {
                    string correctAnswer = GlobalDeclaration.reader["correct_answer"].ToString();
                    string wrongAnswer1 = GlobalDeclaration.reader["wrong_answer1"].ToString();
                    string wrongAnswer2 = GlobalDeclaration.reader["wrong_answer2"].ToString();

                    answersList.Add(correctAnswer);
                    answersList.Add(wrongAnswer1);
                    answersList.Add(wrongAnswer2);
                }
                GlobalDeclaration.reader.Close();
                Connections.Connections.conn.Close();

                //Store answers in global answer array
                GlobalDeclaration.answer_Arr = answersList.ToArray();
            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> Get Answer Array, " + ex.Message);
            }
        }

        //get correct answer using question ID
        public static void getCorrectAnswer(int question_ID)
        {
            try
            {
                sql = "Select correct_answer "
                    + "From correct_answer "
                    + "Where question_ID = " + question_ID;
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();
                if (GlobalDeclaration.reader.Read())
                {
                    GlobalDeclaration.correct_answer = GlobalDeclaration.reader[0].ToString();
                }
                GlobalDeclaration.reader.Close();
                Connections.Connections.conn.Close();
            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET Question, " + ex.Message);
            }
        }

        public static void setcboCategoryNames() 
        {
            try
            {
                sql = "Select category_name From category";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();

                List<string> categoryList = new List<string>();
                while (GlobalDeclaration.reader.Read())
                {
                    categoryList.Add(GlobalDeclaration.reader[0].ToString());
                }
                GlobalDeclaration.reader.Close();
                Connections.Connections.conn.Close();

                //Store answers in global answer array
                GlobalDeclaration.categoryNames = categoryList.ToArray();
            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET Category Names, " + ex.Message);
            }
        }

        public static void setcboDifficultyNames() 
        {
            try
            {
                sql = "Select level_name From difficulty";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();

                List<string> difficultyList = new List<string>();
                while (GlobalDeclaration.reader.Read())
                {
                    difficultyList.Add(GlobalDeclaration.reader[0].ToString());
                }
                GlobalDeclaration.reader.Close();
                Connections.Connections.conn.Close();

                //Store answers in global answer array
                GlobalDeclaration.difficultyNames = difficultyList.ToArray();
            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET Difficulty Names, " + ex.Message);
            }
        }
        
        public static void setcboRoleNames()
        {
            try
            {
                sql = "Select role_name From role";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();

                List<string> roleList = new List<string>();
                while (GlobalDeclaration.reader.Read())
                {
                    roleList.Add(GlobalDeclaration.reader[0].ToString());
                }
                GlobalDeclaration.reader.Close();
                Connections.Connections.conn.Close();

                //Store answers in global answer array
                GlobalDeclaration.roleNames = roleList.ToArray();
            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> GET Difficulty Names, " + ex.Message);
            }
        }

        public static void setQuestionLimit(string difficulty) 
        {

            //GlobalDeclaration.questionLimit = 0;
            try
            {
                sql = "Select number_of_questions From difficulty Where level_name = '" + difficulty + "'";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();

                if (GlobalDeclaration.reader.Read())
                {
                    GlobalDeclaration.questionLimit = Convert.ToInt32(GlobalDeclaration.reader[0].ToString());
                }
                
                GlobalDeclaration.reader.Close();
                Connections.Connections.conn.Close();
                
            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> SET QUESTION LIMIT, " + ex.Message);
            }
        }

        public static void setTimeLimit(string difficulty) 
        {
            //GlobalDeclaration.timeLimit = 0;
            try
            {
                sql = "Select time_limit From difficulty Where level_name = '" + difficulty + "'";
                Connections.Connections.DB();
                GlobalDeclaration.command = new OleDbCommand(sql, Connections.Connections.conn);
                GlobalDeclaration.reader = GlobalDeclaration.command.ExecuteReader();

                if (GlobalDeclaration.reader.Read())
                {
                    GlobalDeclaration.timeLimit = Convert.ToInt32(GlobalDeclaration.reader[0].ToString());
                }

                GlobalDeclaration.reader.Close();
                Connections.Connections.conn.Close();

            }
            catch (Exception ex)
            {
                Connections.Connections.conn.Close();
                MessageBox.Show("Error ----> SET QUESTION LIMIT, " + ex.Message);
            }

        }
        //Capitalize first letter of user name
        public static string capitalizeFirstLetter(string student_name)
        {
            if (string.IsNullOrEmpty(student_name))
            {
                MessageBox.Show("Error ----> Capitalize First Letter Parameter Value is Null!");
            }

            return char.ToUpper(student_name[0]) + student_name.Substring(1);
        }

    }
}
