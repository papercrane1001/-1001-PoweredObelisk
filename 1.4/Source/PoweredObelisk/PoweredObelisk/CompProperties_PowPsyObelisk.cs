using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RimWorld;
using PsyObelisk;
using Verse;

namespace PoweredObelisk
{
    public class CompProperties_PowPsyObelisk : CompProperties
    {
        public CompProperties_PowPsyObelisk()
        {
            this.compClass = typeof(ThingComp_PowPsyObelisk);
        }
    }
}
