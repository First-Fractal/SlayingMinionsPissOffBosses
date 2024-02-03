using System.Collections.Generic;
using Terraria.GameContent.RGB;

namespace SlayingMinionsPissOffBosses
{
    public class PissedOffBoss(int Type, bool Worm=false)
    {
        public int type = Type;
        public bool worm = Worm;
        public double wormModifier = 0.05;

        public int killCount = 0;
        public double enrange = 0;

        public List<object[]> minions = new List<object[]>();
    }
}
