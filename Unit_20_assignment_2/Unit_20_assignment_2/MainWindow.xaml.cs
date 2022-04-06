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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;

namespace Unit_20_assignment_2
{
    //NIAP Healthcare Test Program created by Luke Kenny, Student ID: 140975
    //Using Microsoft Visual Studio 2015
    //Date Created 7.11.2017
    //Last edited: 13.1.2018

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            errorBox.Text = "Connecting to database...";
            string conn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\\HNC\\Marjory\\Visual Studio 2015\\UserPasswords.accdb";
            using (OleDbConnection connection = new OleDbConnection(conn)) 
            try
            {
                //Open the connection
                connection.Open();

                //Set up the SQL command
                string sqlString = "SELECT * FROM Users";
                OleDbCommand cmd = new OleDbCommand(sqlString, connection);

                //Set up the reader
                OleDbDataReader reader;
                reader = cmd.ExecuteReader();
                    errorBox.Text = "Connection complete";
                

                //Get each item from the table and check against user input
                Boolean enter = false;
                
                while (reader.Read())
                {
                    string UserID = reader.GetString(0);
                    string Password = reader.GetString(1);
                    if (UserID == usernameBox.Text & Password == passwordBox.Password)  //Fetching the user details from the database and comparing it with...
                    {                                                                   //...what they entered.
                        enter = true;
                        break;
                    }
                }
                   
                    //valid username and password entered
                if (enter == true)
                    {
                        errorBox.Text = "Opening Test";                            
                        Form2 frm = new Form2();        //Opening the questions form and setting the login form...
                        frm.ShowDialog();               //...to close when finished.
                        this.Close();
                    }
                if (enter == false)
                    {
                        errorBox.Text = "Incorrect Username and/or Password, please try again.";
                    }
            }
            catch
            {
                errorBox.Text = "Cannot Open the password file, please contact tech support. ";
            }

        }
    }
}
