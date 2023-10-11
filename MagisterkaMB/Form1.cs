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
        public bool testmode = true;
        public Dictionary<string, int> constVariable = new Dictionary<string, int> { };
        public List<IT_Armor> armors = new List<IT_Armor>();
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

        private void loadArmor(string text)
        {
            MatchCollection matches;
            string pattern = @"(INSTANCE|instance)\s(?<codeName>\w+)\s\(C_Item\)
(\r\n){\r\n\s*name\s*=\s*""*(?<name>.*?)""\s*;
(\r\n)*\s*mainflag\s*=\s*(?<mainFlag>.*)\s*;
\r\n\s*flags\s*=\s*(?<flags>\d*)\s*;
(\r\n)\s*protection\s*\[PROT_EDGE\]\s*=\s*(?<edge>\d+)\s*;
(\r\n)*\s*protection\s*\[PROT_BLUNT\]\s*=\s*(?<blunt>\d+)\s*;
(\r\n)*\s*protection\s*\[PROT_POINT\]\s*=\s*(?<point>\d+)\s*;
(\r\n)*\s*protection\s*\[PROT_FIRE\]\s*=\s*(?<fire>\d+)\s*;
(\r\n)*\s*protection\s*\[PROT_MAGIC\]\s*=\s*(?<magic>\d+)\s*;
(\r\n)*\s*value\s*=\s*(?<constValue>.*)\s*;
(\r\n)*\s*wear\s*=\s*(?<wear>.*)\s*;
(\r\n)*\s*visual\s*=\s*""*(?<visual>.*)""*\s*;
(\r\n)*\s*visual_change\s*=\s*""*(?<visual_change>.*?)""*\s*;
\r\n\s*visual_skin\s*=\s*(?<visual_skin>\d*)\s*;
(\r\n)*\s*material\s*=\s*(?<material>.*)\s*;";
            
            
            matches = Regex.Matches(text,pattern, RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);

            Mainflag armor_main;
            Material armor_mat;

            int i = 0;
            foreach (Match armor in matches)
            {
                i++;
                Enum.TryParse<Mainflag>(armor.Groups["armor_main"].ToString(), out armor_main);
                Enum.TryParse<Material>(armor.Groups["material"].ToString(), out armor_mat);
                
                armors.Add(new IT_Armor(
                    armor.Groups["codeName"].ToString(),
                    armor.Groups["name"].ToString(),
                    armor_main,
                    int.Parse(armor.Groups["edge"].ToString()),
                    int.Parse(armor.Groups["blunt"].ToString()),
                    int.Parse(armor.Groups["point"].ToString()),
                    int.Parse(armor.Groups["fire"].ToString()),
                    int.Parse(armor.Groups["magic"].ToString()),
                    armor.Groups["constValue"].ToString(),
                    armor.Groups["visual"].ToString(),
                    armor.Groups["visual_change"].ToString(),
                    armor_mat)
                    );
            }
            TestBox.Text = i.ToString();
        }
        private void loadConstVariable(string line)
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


                if (fileName.Contains("Armor"))
                {
                    string FileText = sr.ReadToEnd();
                    loadArmor(FileText);
                    sr.DiscardBufferedData();
                    sr.BaseStream.Seek(0, SeekOrigin.Begin);
                }

                while (line != null)
                {
                    line = sr.ReadLine();

                    loadConstVariable(line);   
                }

               
                sr.Close();
                
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
                if (fileName.Contains("Armor"))
                {
                    changeForm("Armor", new Dictionary<string, object>() { { "ConstVariable", constVariable }, { "Armors", armors } });
                }
            }
        }


        private void changeForm(string FormName, Dictionary<string, object> kwargs = null)
        {
            
            string namespaceName = "MagisterkaMB.";
            Form form = null;
            if(kwargs != null)
            {
                if(FormName == "Armor")
                {
                    form = Activator.CreateInstance(Type.GetType(namespaceName + FormName), kwargs) as Form;
                } else
                {
                    form = Activator.CreateInstance(Type.GetType(namespaceName + FormName)) as Form;
                }
            } else
            {
                form = Activator.CreateInstance(Type.GetType(namespaceName + FormName)) as Form;
            }
            form.Show();
            this.Hide();


        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            IT_Armor arm = new IT_Armor();
            //TestBox.Text = arm.ToString();
            TestBox.Text = "";
            //TestBox.Text = arm.GetType().GetMethod("codeName").ToString();
            TestBox.Text = arm.GetType().GetMethod("get_codeName").Invoke(arm,null).ToString();
            KeyValuePair<string, int> x = new KeyValuePair<string, int>("ala",1);
            TestBox.Text += x.GetType().GetMethod("get_Key").Invoke(x, null).ToString();
            /*
            foreach(var item in arm.GetType().GetMethods())
            {
                TestBox.Text +=  "\n" +item;
            }*/
        }
    }

    

}
