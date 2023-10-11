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
        protected string name;
        protected Mainflag mainflag;
        protected int flags = 0;
        protected string descriptionText;
        protected Material material;

        public abstract override string ToString();

    }
}
