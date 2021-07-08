using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("Artefacts", "Name", IdentifierID = "ArtefactID")]
    class Artefact : DBObject
    {

        public int ID;
        [SearchCustomDataSource("ArtefactRarities")]
        public int Rarity;
        public string Name;
        [SearchOptions(Hidden = true)]
        public string Description;
        public float SeeFrequency;
        public float AcquireFrequency;
        public bool UnlockedByDefault;


        public int OnUseContext;
        public List<int> Fragments;
        
        public Artefact()
        {
            Name = "";
            Description = "";
            SeeFrequency = 3f;
            AcquireFrequency = 3f;
            UnlockedByDefault = true;
            OnUseContext = 0;
            Rarity = 0;

            Fragments = new List<int>();
        }

    }
}
