using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Windows.Threading;

namespace Unit_20_assignment_2
{
    //NIAP Healthcare Test Program created by Luke Kenny, Student ID: 140975
    //Using Microsoft Visual Studio 2015
    //Date Created 7.11.2017
    //Last edited: 14.1.2018

    /// <summary>
    /// Interaction logic for Form2.xaml
    /// </summary>
    public partial class Form2 : Window
    {
        public static string[,] everything = new string[5, 5];
        public int count = 0;
        public int check = 0;
        public string LineSpace = "--------------";
        public Form2()
        {         
            InitializeComponent();
            StartClock();
            string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\HNC\\Marjory\\Visual Studio 2015\\NiapDatabase.accdb";
            using (OleDbConnection connection = new OleDbConnection(conn)) 
                try
                {
                    //Open the connection
                    connection.Open();

                    //Set up the SQL command
                    string sqlString = "SELECT * FROM QuestionSet1 ORDER BY ID";
                    OleDbCommand cmd = new OleDbCommand(sqlString, connection);

                    //Set up the reader
                    OleDbDataReader reader;
                    reader = cmd.ExecuteReader();
                    for (int index = 0; index < 5;)
                    {
                        reader.Read();
                        everything[index,0] = reader.GetString(1);  //Question
                        everything[index,1] = reader.GetString(2);  //Answer 1
                        everything[index,2] = reader.GetString(3);  //Answer 2
                        everything[index,3] = reader.GetString(4);  //Answer 3
                        everything[index,4] = reader.GetString(5);  //Correct Answer
                        index = index + 1;
                    }
                }
                catch
                {
                    Questions.Text = "Cannot Open the question file, please contact tech support. ";
                }

            Questions.Text = everything[count,0];                   //Displaying the questions and answers.
            QuestionButton1.Content = everything[count, 1];
            QuestionButton2.Content = everything[count, 2];
            QuestionButton3.Content = everything[count, 3];
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"H:\HNC\Marjory\Visual Studio 2015\Projects\Unit_20_assignment_2\Answers.txt", false))     //"false" overwrites the text file
                {
                    string Title = "NIAP HealthCare Test Answers";
                    file.WriteLine(Title);
                    file.WriteLine(LineSpace);              //Writing the title and a line space to the text file.
                }
            }
            catch
            {
                Questions.Text = "Cannot access the text file, please contact tech support.";
            }
            
        }

        private void StartClock()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickevent;
            timer.Start();                              //Starting the clock and allowing it to count.
        }

        private void tickevent(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString(@"hh\:mm\:ss");      //Displaying the time in the clock text box.
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string answer = null;
            int CorrectAnswer = Int32.Parse(everything[count, 4]);
            if (check == CorrectAnswer)                                 //Checking to see if the answer is correct or incorrect.
            {
                answer = "Correct";
            }
            else if (check != CorrectAnswer)
            {
                if (check == 0)
                {
                    MessageBox.Show("You must enter an answer, try again.");        //Error message for not entering an answer.
                    return;
                }
                else
                {
                    answer = "Incorrect";
                }
            }
            try
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"H:\HNC\Marjory\Visual Studio 2015\Projects\Unit_20_assignment_2\Answers.txt", true))  //The true prevents the text in the...
                {                                                                                                                                                       //...file being overwritten.
                    file.WriteLine(answer);                 //Writing the score to the text file.
                }
            }
            catch
            {
                Questions.Text = "Cannot access the text file, please contact tech support.";
            }
            

            count = count + 1;
            if (count <5)
            {               
                Questions.Text = everything[count, 0];              //Displaying the next question.
                QuestionButton1.Content = everything[count, 1];
                QuestionButton2.Content = everything[count, 2];
                QuestionButton3.Content = everything[count, 3];
            }
            else
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"H:\HNC\Marjory\Visual Studio 2015\Projects\Unit_20_assignment_2\Answers.txt", true))
                {
                    file.WriteLine(LineSpace);                                                                  //Writing a line space to the file to divide the text up neatly.
                }
                MessageBox.Show("The test has ended, please see your line manager for your results.");          //Informing the user that the test has ended
                this.Close();                                                                                   //Closes the current form which causes the Login form to close too.
            }        
        }

        private void QuestionButton1_Checked(object sender, RoutedEventArgs e)                  //Code for selecting an answer.
        {
            check = 1;
        }

        private void QuestionButton2_Checked(object sender, RoutedEventArgs e)
        {
            check = 2;
        }

        private void QuestionButton3_Checked(object sender, RoutedEventArgs e)
        {
            check = 3;
        }

        private void Calculator_Button_Click(object sender, RoutedEventArgs e)      //Opening the calculator form.
        {
            Calculator frm = new Calculator();
            frm.ShowDialog();
        }

        private void NotepadButton_Click(object sender, RoutedEventArgs e)          //Opening the notepad form.
        {
            Notepad window = new Notepad();
            window.ShowDialog();
        }

        private void Questions_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
