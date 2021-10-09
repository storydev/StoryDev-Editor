using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class GlobalSettings
    {

        public string SourcePath;
        public string SubFolder;
        public bool CharactersModule = true;
        public bool PlacesModule = true;
        public bool ActivitiesModule = true;
        public bool ArtefactsModule = true;
        public bool AchievementsModule = true;
        public bool ItemsModule = true;
        public bool VendorsModule = true;
        public bool SpecialFeature = true;
        public bool GossipsSystem = true;

        public Dictionary<string, int> ArtefactContextNames;
        [Obsolete("Not to be used in any context. Removed in a later patch.", true)]
        public List<FormComponent> FormComponents;

        public GlobalSettings()
        {
            ArtefactContextNames = new Dictionary<string, int>();
        }

    }
}
