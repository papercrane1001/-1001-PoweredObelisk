using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
//using PsyObelisk;
using Verse;

namespace PoweredObelisk
{
    public class ThingComp_PowPsyObelisk : ThingComp
    {
        public float focus;
        public bool powerActive = true;
        public bool getFocusActive = true;
        public int lastPoweredTick;

        public CompProperties_PowPsyObelisk Props
        {
            get
            {
                return props as CompProperties_PowPsyObelisk;
            }
        }
        public float FocusMax
        {
            get
            {
                return (float)Utilities.Settings.psyFocusMax
            }
        }

    }
}
