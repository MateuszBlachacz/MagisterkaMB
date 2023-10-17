using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MagisterkaMB
{
    public enum Mainflag
    {
        ITEM_KAT_ARMOR,
        ITEM_KAT_NF,
    }

    public enum Wear
    {
        WEAR_TORSO,
    }

    public enum Material
    {
        MAT_LEATHER,
        MAT_METAL,
        MAT_WOOD,
    }
    public abstract class Item
    {
        public string codeName { get; set; }
        public string name { get; set; }
        public Mainflag mainflag { get; set;}
        public string flags { get; set; }
        public string descriptionText;
        public Material material;

        public abstract override string ToString();

    }
}
