using System.Collections.Generic;

namespace SlayingMinionsPissOffBosses
{
    //create the class for the pissed off bosses
    public class PissedOffBoss(int Type, string Name, string Abbr, bool Worm=false, bool Parts=false)
    {
        //define the types, name, abbr and is worm/minion
        public int type = Type;
        public string name = Name;
        public string abbr = Abbr;
        public bool worm = Worm;
        public double wormModifier = 0.05;

        public bool parts = Parts;
        public double partsModifier = 0.5;

        public int killCount = 0;
        public double enrage = 0;

        public List<object[]> minions = new List<object[]>();
    }
}
