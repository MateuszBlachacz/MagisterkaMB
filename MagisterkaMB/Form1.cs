using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace MagisterkaMB
{
    public partial class Form1 : Form
    {
        public string path;
        public bool testmode = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                tbPath.Text = path;
                readFile(path);
            }
        }

        private void makeThing(string line)
        {
            string patternSkipComment = "^//";

            //TestBox.Text += line + "\n";

            if (!Regex.IsMatch(line, patternSkipComment))
            {
              TestBox.Text += line + "\n";
            }
            
        }
        private void readFile(string fileName)
        {
            try
            {
                
                StreamReader sr = new StreamReader(fileName);
                string line;
                line = "";
                int i = 0;
                
                while (line != null && (i < 25 || !testmode))
                {
                    
                    line = sr.ReadLine();

                    makeThing(line);

                    i++;
                }
                //close the file
                sr.Close();
                //Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }

}
