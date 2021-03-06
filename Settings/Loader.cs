﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using KaosesPartySizes.Utils;
using Newtonsoft.Json;
using TaleWorlds.Engine;

namespace KaosesPartySizes.Settings
{
	public static class Loader
	{
		public static void LoadConfig()
		{
			bool flag = !File.Exists("..\\\\..\\\\Modules\\\\KaosesPartySizes\\config.json") && File.Exists("..\\\\..\\\\Modules\\\\KaosesPartySizes\\Config.base.json");
			if (flag)
			{
				try
				{
					File.Copy("..\\\\..\\\\Modules\\\\KaosesPartySizes\\Config.base.json", "..\\\\..\\\\Modules\\\\KaosesPartySizes\\config.json");
				}
				catch (Exception e)
				{
					Logging.lm(e.ToString());
				}
			}
			bool flag2 = !File.Exists("..\\\\..\\\\Modules\\\\KaosesPartySizes\\config.json");
			if (flag2)
			{
				Logging.lm("Config File Not FOUND");
			}
			try
			{
				Logging.lm("Config File FOUND Loading object");
				ModSettings settings = new ModSettings();
				settings = JsonConvert.DeserializeObject<ModSettings>(File.ReadAllText("..\\\\..\\\\Modules\\\\KaosesPartySizes\\config.json"));
				bool flag3 = !Loader.isModlibLoaded(settings.bOverRideModLibSettings);
				if (flag3)
				{
					Logging.lm("No Modlib or overriding Modlib  all values set from config");
					ModSettings.SetSettings(settings);
				}
				else
				{
					Logging.lm("Modlib all values set from Modlib");
				}
			}
			catch (Exception e2)
			{
				Logging.lm(e2.Message.ToString());
				Logging.lm(e2.ToString());
			}
		}

		public static bool isModlibLoaded(bool overrideSettings = true)
		{
			List<string> modnames = Utilities.GetModulesNames().ToList<string>();
			bool modLibLoaded = false;
			bool flag = modnames.Contains("ModLib") && !overrideSettings;
			if (flag)
			{
				modLibLoaded = true;
			}
			return modLibLoaded;
		}
	}
}
