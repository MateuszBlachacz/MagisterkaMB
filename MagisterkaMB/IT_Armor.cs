using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagisterkaMB
{
    public enum Protection
    {
        PROT_EDGE,
        PROT_BLUNT,
        PROT_POINT,
        PROT_FIRE,
        PROT_MAGIC,
    }
    public class IT_Armor : Item
    {
        public int prot_val_edge { get; set; }
        public int prot_val_blunt {get; set;}
        public int prot_val_point {get; set;}
        public int prot_val_fire {get; set;}
        public int prot_val_magic {get; set;}

        Wear wear = Wear.WEAR_TORSO;
        public string constValue {get; set;}
        int value;

        public string visual { get; set; }
        public string visual_change { get; set; }
        public int visual_skin = 0;

        public IT_Armor()
        {
            this.codeName = "ITAR_MINE";
            name = "Moja szata";
            mainflag = Mainflag.ITEM_KAT_ARMOR;
            flags = "0";

            prot_val_edge = 10;
            prot_val_blunt = 10;
            prot_val_point = 10;
            prot_val_fire = 10;
            prot_val_magic = 10;

            constValue = "VALUE_" + codeName;
            value = 20;

            visual = GetVisual();
            visual_change = GetVisualChange();
            material = Material.MAT_LEATHER;

        }

        public IT_Armor(string codeName)
        {
            this.codeName = codeName;
            name = "Moja szata";
            mainflag = Mainflag.ITEM_KAT_ARMOR;
            flags = "0";

            prot_val_edge = 10;
            prot_val_blunt = 10;
            prot_val_point = 10;
            prot_val_fire = 10;
            prot_val_magic = 10;

            constValue = "VALUE_" + codeName;
            value = 20;

            visual = GetVisual();
            visual_change = GetVisualChange();
            material = Material.MAT_LEATHER;

        }

        public IT_Armor(
            string codeName, string name, Mainflag mainflag,
            int prot_val_edge, int prot_val_blunt, int prot_val_point, int prot_val_fire, int prot_val_magic,
            string constValue, string visual,
            string visual_change, Material material
            )
        {
            this.codeName = codeName;
            this.name = name;
            this.mainflag = mainflag;
            this.flags = "0";
            this.prot_val_edge = prot_val_edge;
            this.prot_val_blunt = prot_val_blunt;
            this.prot_val_point = prot_val_point;
            this.prot_val_fire = prot_val_fire;
            this.prot_val_magic = prot_val_magic;

            this.constValue = constValue;
            this.value = 20;

            this.visual = visual;
            this.visual_change = visual_change;
            this.material = material;
        }

        public string  GetVisual()
        {
            return "ItAr_Governor.3DS";
        }

        public string GetVisualChange()
        {
            return "Armor_Judge.asc";
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        public int GetValue()
        {
            return value;
        }

        public override string ToString()
        {
            string text = "";

            text += $"INSTANCE {codeName} (C_Item)\r\n";
            text += "{\r\n";

            text += $"    name = \"{name}\";\r\n\n";

            text += $"    mainflag = {mainflag};\r\n";
            text += $"    flags = {flags};\r\n\n";

            text += $"    protection [PROT_EDGE] = {prot_val_edge};\r\n";
            text += $"    protection [PROT_BLUNT] = {prot_val_blunt};\r\n";
            text += $"    protection [PROT_POINT] = {prot_val_point};\r\n";
            text += $"    protection [PROT_FIRE] = {prot_val_fire};\r\n";
            text += $"    protection [PROT_MAGIC] = {prot_val_magic};\r\n\n";

            text += $"    value = {constValue};\r\n\n";

            text += $"    wear = {wear};\r\n\n";

            text += $"    visual = \"{visual}\";\r\n";
            text += $"    visual_change = \"{visual_change}\";\r\n";
            text += $"    visual_skin = {visual_skin};\r\n";
            text += $"    material = {material};\r\n\n";

            text += $"    description = name;\r\n\n";

            text += $"    TEXT[1] = NAME_Prot_Edge;\r\n";
            text += $"    COUNT[1] = protection[PROT_EDGE];\r\n\n";

            text += $"    TEXT[2] = NAME_Prot_Point;\r\n";
            text += $"    COUNT[2] = protection[PROT_POINT];\r\n\n";

            text += $"    TEXT[3] = NAME_Prot_Fire;\r\n";
            text += $"    COUNT[3] = protection[PROT_FIRE];\r\n\n";

            text += $"    TEXT[4] = NAME_Prot_Magic;\r\n";
            text += $"    COUNT[4] = protection[PROT_MAGIC];\r\n\n";

            text += $"    TEXT[5] = NAME_Value;\r\n";
            text += $"    COUNT[5] = value;\r\n";

            text += "};\n";
            text += "// ******************************************************\n";

            return text; 
        }
    }
}
