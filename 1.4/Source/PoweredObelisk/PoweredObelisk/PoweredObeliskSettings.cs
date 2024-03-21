using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Verse;

namespace PoweredObelisk
{
    public class PoweredObeliskSettings : ModSettings
    {
        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Values.Look<int>(ref this.psyFocusMax, "psyFocusMax", 10, false);
            Scribe_Values.Look<float>(ref this.psyFocusGetTime, "psyFocusGetTime", 10f, false);
        }

        public int psyFocusMax = 10;

        public float psyFocusGetTime = 10f;
    }
}
