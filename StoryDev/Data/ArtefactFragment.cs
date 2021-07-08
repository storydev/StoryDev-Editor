using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    [MainSourceData("Fragments", "Name", IdentifierID = "ArtefactFragmentID")]
    class ArtefactFragment : DBObject
    {

        public int ID;
        [SearchRelationship(typeof(Artefact), "ID", "Name", "Artefacts")]
        public int ArtefactID;
        public string Name;
        public int IconIndex;

        public ArtefactFragment()
        {
            Name = "";
            IconIndex = -1;
        }

    }
}
