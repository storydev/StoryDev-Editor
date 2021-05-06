using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("Items", "Name")]
    class Item : DBObject
    {

        public int ID;
        public string Name;
        [SearchOptions(Hidden = true)]
        public string Description;
        /// <summary>
        /// Unique, as in can only be acquired once.
        /// </summary>
        public bool IsUnique;
        /// <summary>
        /// Special Items cannot be deleted.
        /// </summary>
        public bool IsSpecial;
        [SearchOptions(Hidden = true)]
        public int IconIndex;
        [SearchCustomDataSource("ItemRarities")]
        public int Rarity;

        public double BuyPrice;
        public double SellPrice;

        [SearchOptions(Hidden = true)]
        public string OnUseScript;

        public int UseCooldown;
        [SearchCustomDataSource("ItemUseContexts")]
        public int UseContext;
        public bool ConsumeOnUse;

        public Item()
        {
            Name = "";
            Description = "";
            Rarity = 0;
            IsUnique = false;
            IsSpecial = false;
            IconIndex = -1;
            BuyPrice = 0;
            SellPrice = 0;
            OnUseScript = "";
            UseContext = 7;
            UseCooldown = 0;
        }

    }
}
