using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagisterkaMB
{
    public partial class Armor : Form
    {

        Dictionary<string, int> constITdata = new Dictionary<string, int> { };
        List<IT_Armor> armors = new List<IT_Armor>();
        public Armor()
        {
            InitializeComponent();
        }

        
        public Armor(Dictionary<string,object> data)
        {
            InitializeComponent();
            
            constITdata = data["ConstVariable"] as Dictionary<string, int>;
 
            comboBoxAddItems(ITconstBox, constITdata, "get_Key");
            
            armors = data["Armors"] as List<IT_Armor>;
            comboBoxAddItems(ITArmorBox, armors, "get_codeName");
        }

        private void comboBoxAddItems<T>(ComboBox box, IEnumerable<T> data, string method)
        {
            foreach(var item in data)
            {
                box.Items.Add(item.GetType().GetMethod(method).Invoke(item, null).ToString());
            }
        }

        private void ITvalue_TextChanged(object sender, EventArgs e)
        {
            if (ITvalue.Text == "") constITdata[ITconstBox.SelectedItem.ToString()] = 0;
            else constITdata[ITconstBox.SelectedItem.ToString()] = int.Parse(ITvalue.Text);
        }

        private void ITconstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          ITvalue.Text = constITdata[ITconstBox.SelectedItem.ToString()].ToString();  
        }
    }
}
