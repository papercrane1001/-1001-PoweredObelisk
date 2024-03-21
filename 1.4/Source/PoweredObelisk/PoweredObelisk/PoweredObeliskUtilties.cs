using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Verse;

namespace PoweredObelisk
{
    public class PoweredObeliskUtilties
    {
        public static PoweredObeliskSettings Settings
        {
            get
            {
                return LoadedModManager.GetMod<PoweredObeliskMod>().GetSettings<Settings>();
            }
        }
    }
}
