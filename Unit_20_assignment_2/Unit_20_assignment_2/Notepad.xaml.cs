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
    /// Interaction logic for Notepad.xaml
    /// </summary>
    public partial class Notepad : Window
    {
        public Notepad()
        {
            try
            {
                InitializeComponent();
                string text = System.IO.File.ReadAllText(@"H:\HNC\Marjory\Visual Studio 2015\Projects\Unit_20_assignment_2\Notepad.txt");   //Loading any text that may already be in the file.
                textBox.Text = text;        //Displaying the loaded text in the text box.
            }
            catch
            {
                MessageBox.Show("Cannot access the Notepad file, please contact tech support.");
                this.Close();
            }
            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)     //Event handler for saving to the text file Notepad.txt and then closing the current form.
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"H:\HNC\Marjory\Visual Studio 2015\Projects\Unit_20_assignment_2\Notepad.txt", false))     //False causes any text in the file to be... 
            {                                                                                                                                                           //...overwritten to avoid duplication.
                file.WriteLine(textBox.Text);       //Writing the text from the text box to the file.
                this.Close();                       //Closing the notepad.
            }
        }
    }
}
