using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class SpecialFeature : DBObject
    {

        public string Name;
        public bool HasDifficulty;
        public int DifficultyMin;
        public int DifficultyMax;
        
        public bool Repeatable;
        public bool RepeatsNewScore;
        public bool AllowFrequencyChanges;

        public SpecialFeature()
        {
            Name = "";
            HasDifficulty = false;
            DifficultyMin = 0;
            DifficultyMax = 0;
            Repeatable = false;
            RepeatsNewScore = false;
            AllowFrequencyChanges = false;
        }

    }
}
