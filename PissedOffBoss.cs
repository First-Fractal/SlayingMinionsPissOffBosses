using System.Collections.Generic;
using Terraria.GameContent.RGB;

namespace SlayingMinionsPissOffBosses
{
    //create the class for the pissed off bosses
    public class PissedOffBoss(int Type, bool Worm=false, bool Parts=false)
    {
        //define the types and is worm/minion
        public int type = Type;
        public bool worm = Worm;
        public double wormModifier = 0.05;

        public bool parts = Parts;
        public double partsModifier = 0.5;

        public int killCount = 0;
        public double enrange = 0;

        public List<object[]> minions = new List<object[]>();
    }
}
