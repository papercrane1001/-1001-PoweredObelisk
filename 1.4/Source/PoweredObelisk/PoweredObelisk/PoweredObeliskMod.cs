using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Verse;
using UnityEngine;

namespace PoweredObelisk
{
    public class PoweredObeliskMod : Mod
    {
        public Settings settings;
        public PoweredObeliskMod(ModContentPack content) : base(content)
        { 
            this.settings = base.GetSettings<Settings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.Begin(inRect);
            listing_Standard.Gap(10f);
            listing_Standard.Label("PoweredObelisk.Settings.PsyFocusMax".Translate(this.settings.psyFocusMax), -1f, null);
            this.settings.psyFocusMax = (int)listing_Standard.Slider((float)this.settings.psyFocusMax, 0.5f, 100f);
            listing_Standard.Gap(10f);
            listing_Standard.Label("PoweredObelisk.Settings.PsyFocusGetTime".Translate(this.settings.psyFocusGetTime), -1f, null);
            this.settings.psyFocusGetTime = (float)Math.Round((double)listing_Standard.Slider(this.settings.psyFocusGetTime, 0f, 30f), 2);
            listing_Standard.End();
        }
        public override string SettingsCategory()
        {
            return "PoweredObelisk.PoweredObeliskMod".Translate();
        }
    }
}
