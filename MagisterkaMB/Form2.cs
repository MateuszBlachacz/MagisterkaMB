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

namespace MagisterkaMB
{
    public partial class Armor : Form
    {

        Dictionary<string, int> constITdata = new Dictionary<string, int> { };
        List<IT_Armor> armors = new List<IT_Armor>();
        string path;
        public Armor()
        {
            InitializeComponent();
            hide_propertis();
        }

        void takeFilename(string path, string file_extension, ComboBox box)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            
            foreach(FileInfo file in d.GetFiles(file_extension))
            {
                box.Items.Add(file.Name);
            }
        }

        public Armor(Dictionary<string,object> data)
        {
            InitializeComponent();
            hide_propertis();
            
            constITdata = data["ConstVariable"] as Dictionary<string, int>;
 
            comboBoxAddItems(ITconstBox, constITdata, "get_Key");
            
            armors = data["Armors"] as List<IT_Armor>;
            comboBoxAddItems(ITArmorBox, armors, "get_codeName");
            comboBoxAddItems(ITvisualChangeBox, armors, "get_visual_change");
            comboBoxAddItems(ITvisualBox, armors, "get_visual");

            comboBoxAddItems(ITmainflagBox, GetEnumList<Mainflag>());
            comboBoxAddItems(ITmaterialBox, GetEnumList<Material>());

            path = data["Path"] as string;
        }

        public static List<TEnum> GetEnumList<TEnum>() where TEnum : Enum
    => ((TEnum[])Enum.GetValues(typeof(TEnum))).ToList();

        private void comboBoxAddItems<T>(ComboBox box, IEnumerable<T> data, string method = "")
        {

            if (method != "")
            {
                foreach (var item in data)
                {
                    box.Items.Add(item.GetType().GetMethod(method).Invoke(item, null).ToString());
                }
            }
            else
            {
                foreach (var item in data)
                {
                    box.Items.Add(item);
                }
            }
        }

        private void ITvalueConst_TextChanged(object sender, EventArgs e)
        {
            if (ITvalueConst.Text == "") constITdata[ITconstBox.SelectedItem.ToString()] = 0;
            else constITdata[ITconstBox.SelectedItem.ToString()] = int.Parse(ITvalueConst.Text);

        }

        private void ITconstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ITvalueConst.Text = constITdata[ITconstBox.SelectedItem.ToString()].ToString();
          
        }

        private void ITArmorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_propertis();
            IT_Armor ar = getCurrentArmor();

            ITname.Text = ar.name;
            ITmainflagBox.SelectedItem = ar.mainflag;
            //ITflagBox.Visible = false;
            ITsword.Text = ar.prot_val_edge.ToString();
            ITpoint.Text = ar.prot_val_point.ToString();
            ITfire.Text = ar.prot_val_fire.ToString();
            ITmagic.Text = ar.prot_val_magic.ToString();
            ITvalue.Text = ar.GetValue().ToString();
            ITvisualBox.SelectedItem = ar.visual;
            ITvisualChangeBox.SelectedItem = ar.visual_change;
            ITmaterialBox.SelectedItem = ar.material;

        }

        private void show_propertis()
        {
            //label visual
            ITnameLabel.Visible = true;
            ITmainflagLabel.Visible = true;
            ITflagsLabel.Visible = false;
            ITProtectionLabel.Visible = true;
            ITswordLabel.Visible = true;
            ITpointLabel.Visible = true;
            ITfireLabel.Visible = true;
            ITmagicLabel.Visible = true;
            ITvalueLabel.Visible = true;
            ITvisualLabel.Visible = true;
            ITvisualLabelds.Visible = true;
            ITvisualChangeLabel.Visible = true;
            ITmaterialLabel.Visible = true;

            //fields visual
            ITname.Visible = true;
            ITmainflagBox.Visible = true;
            ITflagBox.Visible = false;
            ITsword.Visible = true;
            ITpoint.Visible = true;
            ITfire.Visible = true;
            ITmagic.Visible = true;
            ITvalue.Visible = true;
            ITvisualBox.Visible = true;
            ITvisualChangeBox.Visible = true;
            ITmaterialBox.Visible = true;
           
        }
        
        private void hide_propertis()
        {
            //label visual
            ITnameLabel.Visible = false;
            ITmainflagLabel.Visible = false;
            ITflagsLabel.Visible = false;
            ITProtectionLabel.Visible = false;
            ITswordLabel.Visible = false;
            ITpointLabel.Visible = false;
            ITfireLabel.Visible = false;
            ITmagicLabel.Visible = false;
            ITvalueLabel.Visible = false;
            ITvisualLabel.Visible = false;
            ITvisualLabelds.Visible = false;
            ITvisualChangeLabel.Visible = false;
            ITmaterialLabel.Visible = false;

            //fields visual
            ITname.Visible = false;
            ITmainflagBox.Visible = false;
            ITflagBox.Visible = false;
            ITsword.Visible = false;
            ITpoint.Visible = false;
            ITfire.Visible = false;
            ITmagic.Visible = false;
            ITvalue.Visible = false;
            ITvisualBox.Visible = false;
            ITvisualChangeBox.Visible = false;
            ITmaterialBox.Visible = false;
        }

        private void ITsaveButton_Click(object sender, EventArgs e)
        {

            using (StreamWriter writetext = new StreamWriter(path, false, Encoding.GetEncoding(1252)))
            {
                string text = "";

                text += "// ------ Const value ------\n";

                foreach ( var item in constITdata)
                {
                    text += $"const int {item.Key}    =   {item.Value};\n";
                }

                text += "// ******************\n// 		Rüstungen\n// ******************\n";

                foreach (IT_Armor armor in armors)
                {
                    text += armor.ToString();
                }

                writetext.Write(text);
                
            }
           
        }

        private void ITCancelButton_Click(object sender, EventArgs e)
        {
            Form form = Activator.CreateInstance(Type.GetType("MagisterkaMB.Form1")) as Form;
            form.Show();
            this.Hide();
        }

         private IT_Armor getCurrentArmor()
        {
            return armors.Find(item => item.codeName == ITArmorBox.SelectedItem.ToString());
        }

        private void ITname_TextChanged(object sender, EventArgs e)
        {
            IT_Armor ar = getCurrentArmor();
            ar.name = ITname.Text;
        }

        private void ITmainflagBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IT_Armor ar = getCurrentArmor();
            Mainflag mf;
            Enum.TryParse<Mainflag>(ITmainflagBox.SelectedItem.ToString(), out mf);
            ar.mainflag = mf;
        }

        private void ITflagBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IT_Armor ar = getCurrentArmor();
            ar.flags = ITflagBox.Text;
        }
        //repare all int parse
        private void ITsword_TextChanged(object sender, EventArgs e)
        {
            IT_Armor ar = getCurrentArmor();
            if (ITsword.Text =="")
            {
                ar.prot_val_edge = 0;
                ar.prot_val_blunt = 0;
            }
            else
            {
                ar.prot_val_edge = int.Parse(ITsword.Text);
                ar.prot_val_blunt = int.Parse(ITsword.Text);
            }
        }
        private void ITpoint_TextChanged(object sender, EventArgs e)
        {
            IT_Armor ar = getCurrentArmor();
            if (ITpoint.Text == "")
            {
                ar.prot_val_point = 0;
            }
            else
            {
                ar.prot_val_point = int.Parse(ITpoint.Text);
            }
        }

        private void ITfire_TextChanged(object sender, EventArgs e)
        {
            IT_Armor ar = getCurrentArmor();
            if (ITfire.Text == "")
            {
                ar.prot_val_fire = 0;
            }
            else
            { 
                ar.prot_val_fire = int.Parse(ITfire.Text);
            }
        }

        private void ITmagic_TextChanged(object sender, EventArgs e)
        {
            IT_Armor ar = getCurrentArmor();
            if(ITmagic.Text == "")
            {
                ar.prot_val_magic = 0;
            }
            else
            {
                ar.prot_val_magic = int.Parse(ITmagic.Text);
            }
            
        }

        private void ITvisualBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IT_Armor ar = getCurrentArmor();
            ar.visual = ITvisualBox.SelectedItem.ToString();
        }

        private void ITvisualChangeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IT_Armor ar = getCurrentArmor();
            ar.visual_change = ITvisualChangeBox.SelectedItem.ToString();
        }

        private void ITmaterialBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IT_Armor ar = getCurrentArmor();
            Material m;
            Enum.TryParse<Material>(ITmaterialBox.SelectedItem.ToString(), out m);
            ar.material = m;
        }

        private void ITvalue_TextChanged(object sender, EventArgs e)
        {
            IT_Armor ar = getCurrentArmor();
            if(ITvalue.Text == "")
            {
                ar.SetValue(0);
                //constITdata[ar.constValue] = 0;
            }
            else
            {
                ar.SetValue(int.Parse(ITvalue.Text));
                if(constITdata.ContainsKey(ar.constValue))
                constITdata[ar.constValue] = int.Parse(ITvalue.Text);
            }
        }

        private void ITAddArmorButton_Click(object sender, EventArgs e)
        {
            string codeName= "ITAR_" + ITcodeName.Text;
            IT_Armor ar = new IT_Armor(codeName);
            ar.codeName = codeName;

            armors.Add(ar);
            ITArmorBox.Items.Add(codeName);
            constITdata[ar.constValue] = ar.GetValue();

        }

        private void ITdeleteButton_Click(object sender, EventArgs e)
        {        
            IT_Armor ar = getCurrentArmor();
            if (ar != null)
            {
                constITdata.Remove(ar.constValue);
                ITArmorBox.Items.Remove(ar.codeName);
                armors.Remove(ar);
            }
        }
    }
}
