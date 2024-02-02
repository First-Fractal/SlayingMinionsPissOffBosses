using System.Collections.Generic;

namespace SlayingMinionsPissOffBosses
{
    public class PissedOffBoss(int Type)
    {
        public int type = Type;
        public int killCount = 0;
        public double enrange = 0;

        public List<object[]> minions = new List<object[]>();
    }
}
