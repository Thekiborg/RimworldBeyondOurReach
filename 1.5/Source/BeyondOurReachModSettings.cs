﻿using Verse;
using RimWorld;
using System.Collections.Generic;

namespace BeyondOurReachModSettings
{
	public class BeyondOurReachModSettings : ModSettings
	{
		public static Dictionary<ModSettingDef, bool> SettingsDict = [];
		private static List<ModSettingDef> m_;
		private static List<bool> b_;

		public override void ExposeData()
		{
			base.ExposeData();
			Scribe_Collections.Look(ref SettingsDict, "BeyondOurReachModSettings", LookMode.Def, LookMode.Value, ref m_, ref b_);

			if (Scribe.mode == LoadSaveMode.LoadingVars)
			{
				SettingsDict ??= [];
			}
		}
	}
}
