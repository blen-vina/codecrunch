using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;


namespace CodeCrunch.GetMaxItemNo
{
    internal class GlobalDeclaration
    {
        public static OleDbCommand command;
        public static OleDbDataReader reader;
        public static int user_ID;
        public static int role_ID;
        public static int question_ID;
        public static int category_ID;
        public static int correct_answer_ID = 0;
        public static int wrong_answer_ID = 0;
        public static int[] questionID_Arr;
        public static int[] shuffledQuestionIDs;
        public static int[] selectedQuestionID_Arr;
        public static int selectedQuestionID;
        public static string question;
        public static string[] answer_Arr;
        public static string[] categoryNames;
        public static string[] difficultyNames;
        public static string[] roleNames;
        public static string correct_answer;
        public static string role_name;
        public static int questionLimit;
        public static int timeLimit;

    }
}
