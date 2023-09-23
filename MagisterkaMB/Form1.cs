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
        public Dictionary<string, int> constVariable = new Dictionary<string, int> { }; 
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
            Match match = Match.Empty;
            string patternSkipComment = "^//";
            string patternConst = "^const";
            string patternConstCutVarVal = @"(?<VAR>[A-Z,_,a-z]+)(?<other>\s*?)=(?<other>\s*?)(?<VAL>\d+)";


            //TestBox.Text += line + "\n";

            if (!Regex.IsMatch(line, patternSkipComment))
            {
                if (Regex.IsMatch(line, patternConst)) {

                    match = Regex.Match(line, patternConstCutVarVal);

                    constVariable[match.Groups["VAR"].Value] = int.Parse(match.Groups["VAL"].Value);
                    TestBox.Text += line + "\n";
                    TestBox.Text += "Variable: " + match.Groups["VAR"] + " VALUE:" + match.Groups["VAL"] + "\n";
                    TestBox.Text += "\n";
                }
              
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
