using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFiles
{
    public partial class Form1 : Form
    {
        FileStream fs;
        StreamWriter sw;
        int ErrorCount = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            PathInputValue.Text = "";
            ExtInputValue.Text = "";
            StringInputValue.Text = "";
            ResultsBox.Items.Clear();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            // assigning global variables equal to text and Ext box values
            var UserPathInput = PathInputValue.Text; // Text box value for Path
            var UserExtInput = ExtInputValue.Text; // Ext box value for Ext

            // getting files per user input as arguments
            var files = Directory.GetFiles(UserPathInput, "*" + UserExtInput);
            ResultsBox.Items.Clear();
            

            foreach (var file in files)
            {
                var result = SearchFile(file.ToString(), StringInputValue.Text);
                if (result)
                {
                    ResultsBox.Items.Add(file.ToString());
                }
            }

            
            try
            {
                fs = new FileStream("Log.txt", FileMode.Append, FileAccess.Write);
                sw = new StreamWriter(fs);
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "Start Process");
                WriteToLog(ResultsBox, PathInputValue.Text, ExtInputValue.Text, StringInputValue.Text);
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "End Process");
            }
            catch (IOException ex)
            {
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "IO Exception Thrown: " + ex.Message);            
            }
            catch (Exception ex)
            {
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "Exception Thrown: " + ex.Message);                
            }
            finally
            {
                sw.Close();
            }
        
            
            

            // All Text boxes are required.
            if (PathInputValue.Text == "")
            {
                PathInputValue.Text = "Please Enter a Folder Path to Search";
                ErrorCount = ErrorCount + 1;
            }
            else
            if (ExtInputValue.Text == "")
            {
                ExtInputValue.Text = "Please Enter a File Extension (ex. .DOC, XML, TXT, JSON, CONFIG)";
                ErrorCount = ErrorCount + 1;
            }
            else
            if (StringInputValue.Text == "")
            {
                StringInputValue.Text = "Please Enter a Search String";
                ErrorCount = ErrorCount + 1;
            }

            // check to see if an error has occurred. If so, then exit.
            if (ErrorCount > 0)
            {
                return;
            }
        }

        private bool SearchFile(string fileName, string searchString)
        {
             bool stringFound = false;
             FileStream file = new FileStream(fileName, FileMode.Open);
             StreamReader sr = new StreamReader(file);
            try
            {
                while (!sr.EndOfStream)
                {
                    //Read one line at a time
                    var line = sr.ReadLine();

                    //Examine each line to see if it contains searchString
                    if (line.ToUpper().Contains(searchString.ToUpper()))
                    {
                        stringFound = true;
                        break;
                    }
                }
            }
            
            catch (Exception)
            {
                
            }
            finally
            {
                file.Close();
            }


            return stringFound;

        }

        private void WriteToLog(ListBox Resultsbox, string PathInputValue, string ExtInputValue, string StingInputValue)
        {
            try
            {
                //Set directory to the user's path value.
                Directory.SetCurrentDirectory(this.PathInputValue.Text);
                
            }
            catch (DirectoryNotFoundException)
            {
                sw.WriteLine("Data Time: " + DateTime.Now + ": " + "Exception Thrown: Directory Path Not Found");
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
