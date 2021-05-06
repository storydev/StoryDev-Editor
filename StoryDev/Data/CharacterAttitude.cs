using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDev.Data
{
    class CharacterAttitude
    {

        public int TowardsCharacter;
        public int Attitude;
        public int RealAttitude;

        public CharacterAttitude()
        {

        }

    }

    enum Attitude
    { 
        Hate                =   -50,
        Angry               =   -30,
        Upset               =   -10,
        Content             =   0,
        Happy               =   10,
        Joyous              =   30,
        Love                =   50
    }

}
