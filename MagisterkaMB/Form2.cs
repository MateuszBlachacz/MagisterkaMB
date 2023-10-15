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
        string filepath3ds = @"D:\Gry\GOG Galaxy\Games\Gothic 2 Gold\_Work\Data\Meshes\Items\Armor";
        string filepathasc = @"D:\Gry\GOG Galaxy\Games\Gothic 2 Gold\_Work\Data\Meshes\Items\Armor";
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

            //takeFilename(filepath3ds, @"*.3ds",ITvisualBox);
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
            IT_Armor ar = armors.Find(item => item.codeName == ITArmorBox.SelectedItem.ToString());

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

        }

        private void ITCancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
