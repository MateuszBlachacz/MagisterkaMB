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
            codeName = "ITAR_MY";
            name = "Moja szata";
            mainflag = Mainflag.ITEM_KAT_ARMOR;

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

            text += $"INSTANCE {codeName} (C_Item)\n";
            text += "{\n";

            text += $"    name = \"{name}\";\n\n";

            text += $"    mainflag = {mainflag};\n";
            text += $"    flags = {flags};\n\n";

            text += $"    protection [PROT_EDGE] = {prot_val_edge};\n";
            text += $"    protection [PROT_BLUNT] = {prot_val_blunt};\n";
            text += $"    protection [PROT_POINT] = {prot_val_point};\n";
            text += $"    protection [PROT_FIRE] = {prot_val_fire};\n";
            text += $"    protection [PROT_MAGIC] = {prot_val_magic};\n\n";

            text += $"    value = {constValue};\n\n";

            text += $"    wear = {wear};\n\n";

            text += $"    visual = \"{visual}\";\n";
            text += $"    visual_change = \"{visual_change}\";\n";
            text += $"    visual_skin = {visual_skin};\n";
            text += $"    material = {material};\n\n";

            text += $"    description = name\n\n";

            text += $"    TEXT[1] = NAME_Prot_Edge;\n";
            text += $"    COUNT[1] = protection[PROT_EDGE];\n\n";

            text += $"    TEXT[2] = NAME_Prot_Point;\n";
            text += $"    COUNT[2] = protection[PROT_POINT];\n\n";

            text += $"    TEXT[3] = NAME_Prot_Fire;\n";
            text += $"    COUNT[3] = protection[PROT_FIRE];\n\n";

            text += $"    TEXT[4] = NAME_Prot_Magic;\n";
            text += $"    COUNT[4] = protection[PROT_MAGIC];\n\n";

            text += $"    TEXT[5] = NAME_Value;\n";
            text += $"    COUNT[5] = value;\n";

            text += "};\n";
            text += "// ******************************************************\n";

            return text; 
        }
    }
}
