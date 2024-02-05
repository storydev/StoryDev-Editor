using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    internal class StoryItem
    {

        public string Name { get; set; }
        public StoryItemType ItemType { get; set; }
        public List<TagValue> Tags { get; set; }
        public string GroupName { get; set; }
        
        // Conversation
        public string FilePath { get; set; }

        // Event
        public List<string> CommandList { get; set; }

        // Place
        public string Discovery { get; set; }
        public List<string> Features { get; set; }

        // Feature
        public string FeatureName { get; set; }
        public List<int> FeatureData { get; set; }

        public StoryItem()
        {
            Name = string.Empty;
            ItemType = StoryItemType.Conversation;
            GroupName = string.Empty;
            Tags = new List<TagValue>();
            FilePath = string.Empty;
            CommandList = new List<string>();
            Discovery = string.Empty;
            Features = new List<string>();
            FeatureName = string.Empty;
            FeatureData = new List<int>();
        }
        

    }
}
