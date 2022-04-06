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

namespace Unit_20_assignment_2
{
    //NIAP Healthcare Test Program created by Luke Kenny, Student ID: 140975
    //Using Microsoft Visual Studio 2015
    //Date Created 7.11.2017
    //Last edited: 14.1.2018
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        string UserInput = "";  //The user's input
        string Number1 = "";    //The first number
        string Number2 = "";    //The second number
        string Operation = "";  //The operation
        double result = 0.0;    //The answer
        public Calculator()
        {
            InitializeComponent();
        }

        private void Equals_Click(object sender, RoutedEventArgs e)     //Event for pressing Equals
        {
            try
            {
                Number2 = UserInput;
                UserInput = "";
                double int1, int2;
                double.TryParse(Number1, out int1);
                double.TryParse(Number2, out int2);         //Make sure both numbers and integers

                if (Operation == "+")                       //Calculations that take place depending on operator
                {
                    result = int1 + int2;
                    textBox.Text = result.ToString();  
                }
                else if (Operation == "-")
                {
                    result = int1 - int2;
                    textBox.Text = result.ToString();
                }
                else if (Operation == "*")
                {
                    result = int1 * int2;
                    textBox.Text = result.ToString();
                }
                else if (Operation == "/")
                {
                    if (int1 == 0)                          //Making sure that dividing by 0 is always equal to 0
                    {
                        result = 0;
                        textBox.Text = result.ToString();
                    }
                    else if (int2 == 0)
                    {
                        result = 0;
                        textBox.Text = result.ToString();
                    }
                    else
                    {
                        result = int1 / int2;
                        textBox.Text = result.ToString();
                    }
                }
            }
            catch
            {
                textBox.Text = "Not a valid calculation, please try again.";            //Error message for if the calculation isn't input correctly
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput == "")
            {
                textBox.Text = "Please enter a number first and try again/ only press an operation once.";             // Error message for if the user presses the button too many times...
            }                                                                                                          //...or if they forgot to enter a first number.
            else
            {
                Number1 = UserInput;
                Operation = "+";
                textBox.Text += Operation;
                UserInput = "";                         //Clearing userinput for the second number
            }
            
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput == "")
            {
                textBox.Text = "Please enter a number first and try again/ only press an operation once.";
            }
            else
            {
                Number1 = UserInput;
                Operation = "-";
                textBox.Text += Operation;
                UserInput = "";
            }
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput == "")
            {
                textBox.Text = "Please enter a number first and try again/ only press an operation once.";
            }
            else
            {
                Number1 = UserInput;
                Operation = "*";
                textBox.Text += Operation;
                UserInput = "";
            }
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            if (UserInput == "")
            {
                textBox.Text = "Please enter a number first and try again/ only press an operation once.";
            }
            else
            {
                Number1 = UserInput;
                Operation = "/";
                textBox.Text += Operation;
                UserInput = "";
            }
        }

        private void Decimal_Point_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";                      //Making sure the text box is clear before displaying the updated userinput.
            UserInput += ".";                       //Adding a character to userinput.
            textBox.Text += UserInput;              //Displaying the updated userinput with the new character.
        }

        private void Clear_Click(object sender, RoutedEventArgs e)          //Clearing everything so the user can start again.
        {
            UserInput = "";             
            Operation = "";
            Number1 = "";
            Number2 = "";
            textBox.Text = "";
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            UserInput += "0";
            textBox.Text += UserInput;
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            UserInput += "1";
            textBox.Text += UserInput;
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            UserInput += "2";
            textBox.Text += UserInput;
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            UserInput += "3";
            textBox.Text += UserInput;
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            UserInput += "4";
            textBox.Text += UserInput;
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            UserInput += "5";
            textBox.Text += UserInput;
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            UserInput += "6";
            textBox.Text += UserInput;
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            UserInput += "7";
            textBox.Text += UserInput;
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            UserInput += "8";
            textBox.Text += UserInput;
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            UserInput += "9";
            textBox.Text += UserInput;
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
