using System;
//using System.Xml.Serialization;
using MCM.Abstractions.Attributes;
using MCM.Abstractions.Attributes.v2;
using MCM.Abstractions.Settings.Base.Global;

namespace KaosesPartySizes.Settings
{
	public class KaosesPartySizesSettings : AttributeGlobalSettings<KaosesPartySizesSettings>
	{
        public override string Id => "Kaoses Party Sizes";
		public override string DisplayName => "Kaoses Party Sizes Settings";

		public override string FolderName => "KaosesPartySizes";
        public override string Format => "json";

		/* May no be necessary anymore.
		public static KaosesPartySizesSettings Instance
		{
			get
			{
				bool flag = KaosesPartySizesSettings._instance == null;
				if (flag)
				{
					KaosesPartySizesSettings._instance = (KaosesPartySizesSettings)SettingsDatabase.GetSettings<KaosesPartySizesSettings>();
				}
				return KaosesPartySizesSettings._instance;
			}
		}
		*/

		public static void SetSettings(KaosesPartySizesSettings settings)
		{
			KaosesPartySizesSettings._instance = settings;
		}

		public bool bIsDebug { get; set; } = false;

		public bool bLogToFile { get; set; } = false;

		public string modVersionOfConfig { get; set; } = "0.1.11";

		
		[SettingPropertyBool("Troop list creation Enabled", Order = 1, RequireRestart = false, HintText = "Enables creating a print out of all parties and unit sizes"),
		SettingPropertyGroup("KaosesPartySizesSettings/Debug", IsMainToggle = false)]
		public bool bPrintTroopLimits { get; set; } = false;

		
		[SettingPropertyBool("Log Spawned Parties Enabled", Order = 1, RequireRestart = false, HintText = "Enables logging number of spawned parties by type to log file"),
		SettingPropertyGroup("KaosesPartySizesSettings/Debug", IsMainToggle = false)]
		public bool bLogPartySpawns { get; set; } = false;

		
		[SettingPropertyInteger("Looters maximum number of parties", 100, 400, Order = 1, RequireRestart = false, HintText = "looters maximum number of party Native=300"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population", IsMainToggle = false)]
		public int lootersMaximumNoLooterParties { get; set; } = 300;


		[SettingPropertyBool("Hideout Tweaks Enabled", Order = 1, RequireRestart = false, HintText = "Enable tweaking hideout populations."),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts", IsMainToggle = true)]
		public bool EnableHideoutTweaks { get; set; } = false;

		[SettingPropertyInteger("Number of initial Hideouts", 1, 10, Order = 1, RequireRestart = false, HintText = "Number of initial Bandit Hideouts Per Faction Native=3"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts", IsMainToggle = false)]
		public int NumberOfInitialHideoutsAtEachBanditFaction { get; set; } = 3;

		
		[SettingPropertyInteger("Maximum number of Hideouts per bandit Faction", 1, 20, Order = 1, RequireRestart = false, HintText = "Maximum number of Hideouts per bandit faction Native=10"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts", IsMainToggle = false)]
		public int NumberOfMaximumHideoutsAtEachBanditFaction { get; set; } = 10;

		
		[SettingPropertyInteger("Maximum number of Parties Per Hideout", 1, 30, Order = 1, RequireRestart = false, HintText = "Maximum number of Parties Around each Hideout for each Bandit faction Native=8"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts", IsMainToggle = false)]
		public int NumberOfMaximumBanditPartiesAroundEachHideout { get; set; } = 8;

		
		[SettingPropertyInteger("Maximum number of Parties in a Hideout", 1, 10, Order = 1, RequireRestart = false, HintText = "Maximum number of Parties In a Hideout for each faction Native=4"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts", IsMainToggle = false)]
		public int NumberOfMaximumBanditPartiesInEachHideout { get; set; } = 4;


		[SettingPropertyInteger("Minimum number of Parties in a Hideout to infest it", 1, 10, Order = 1, RequireRestart = false, HintText = "Minimum number of Parties in a Hideout to infest it Native=2"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts", IsMainToggle = false)]
		public int NumberOfMinimumBanditPartiesInAHideoutToInfestIt { get; set; } = 2;

/*		Jiros: Removed this as it's duplicated in Bannerlord Tweaks. Would have to be added to Harmony patch if it's to be enabled.
		[SettingPropertyInteger("PlayerMaximumTroopCountForHideoutMission", 1, 90, Order = 1, RequireRestart = false, HintText = "PlayerMaximumTroopCountForHideoutMission"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts", IsMainToggle = false)]
		public int PlayerMaximumTroopCountForHideoutMission { get; set; } = 20;
*/

		[SettingPropertyFloatingInteger("Looters minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply looters minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Looters", IsMainToggle = false)]
		public float lootersMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Looters maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply looters maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Looters", IsMainToggle = false)]
		public float lootersMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Looters Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Looters stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Looters", IsMainToggle = false)]
		public bool lootersMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Forest bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Forest bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Forest", IsMainToggle = false)]
		public float forestBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Forest bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Forest bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Forest", IsMainToggle = false)]
		public float forestBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Forest Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Forest Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Forest", IsMainToggle = false)]
		public bool forestBanditMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Forest Boss bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Forest Boss bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Forest", IsMainToggle = false)]
		public float forestBossBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Forest Boss bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Forest Boss bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Forest", IsMainToggle = false)]
		public float forestBossBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Forest Boss Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Forest Boss Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Forest", IsMainToggle = false)]
		public bool forestBossBanditMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Sea bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sea bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Sea", IsMainToggle = false)]
		public float seaBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Sea bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sea bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Sea", IsMainToggle = false)]
		public float seaBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Sea Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Sea Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Sea", IsMainToggle = false)]
		public bool seaBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Sea Boss bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sea Boss bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Sea", IsMainToggle = false)]
		public float seaBossBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Sea Boss bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sea Boss bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Sea", IsMainToggle = false)]
		public float seaBossBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Sea Boss Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Sea Boss Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Sea", IsMainToggle = false)]
		public bool seaBossBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Mountain bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mountain bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Mountain", IsMainToggle = false)]
		public float mountainBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Mountain bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mountain bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Mountain", IsMainToggle = false)]
		public float mountainBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Mountain Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Mountain Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Mountain", IsMainToggle = false)]
		public bool mountainBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Mountain Boss bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mountain Boss bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Mountain", IsMainToggle = false)]
		public float mountainBossBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Mountain Boss bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mountain Boss bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Mountain", IsMainToggle = false)]
		public float mountainBossBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Mountain Boss Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Mountain Boss Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Mountain", IsMainToggle = false)]
		public bool mountainBossBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Desert bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Desert bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Desert", IsMainToggle = false)]
		public float desertBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Desert bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Desert bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Desert", IsMainToggle = false)]
		public float desertBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Desert Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Desert Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Desert", IsMainToggle = false)]
		public bool desertBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Desert Boss bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Desert Boss bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Desert", IsMainToggle = false)]
		public float desertBossBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Desert Boss bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Desert Boss bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Desert", IsMainToggle = false)]
		public float desertBossBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Desert Boss Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Desert Boss Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Desert", IsMainToggle = false)]
		public bool desertBossBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Steppe bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Steppe bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Steppe", IsMainToggle = false)]
		public float steppeBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Steppe bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Steppe bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Steppe", IsMainToggle = false)]
		public float steppeBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Steppe Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Steppe Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Steppe", IsMainToggle = false)]
		public bool steppeBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Steppe Boss bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Steppe Boss bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Steppe", IsMainToggle = false)]
		public float steppeBossBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Steppe Boss bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Steppe Boss bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Steppe", IsMainToggle = false)]
		public float steppeBossBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Steppe Boss Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Steppe Boss Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Steppe", IsMainToggle = false)]
		public bool steppeBossBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Empire Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Empire Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Empire", IsMainToggle = false)]
		public float empireKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Empire Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Empire Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Empire", IsMainToggle = false)]
		public float empireKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Empire Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Empire Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Empire", IsMainToggle = false)]
		public bool empireKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Sturgia Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sturgia Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Sturgia", IsMainToggle = false)]
		public float sturgiaKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Sturgia Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sturgia Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Sturgia", IsMainToggle = false)]
		public float sturgiaKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Sturgia Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Sturgia Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Sturgia", IsMainToggle = false)]
		public bool sturgiaKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Aserai Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Aserai Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Aserai", IsMainToggle = false)]
		public float aseraiKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Aserai Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Aserai Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Aserai", IsMainToggle = false)]
		public float aseraiKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Aserai Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Aserai Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Aserai", IsMainToggle = false)]
		public bool aseraiKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Vlandia Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Vlandia Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Vlandia", IsMainToggle = false)]
		public float vlandiaKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Vlandia Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Vlandia Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Vlandia", IsMainToggle = false)]
		public float vlandiaKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Vlandia Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Vlandia Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Vlandia", IsMainToggle = false)]
		public bool vlandiaKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Battania Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Battania Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Battania", IsMainToggle = false)]
		public float battaniaKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Battania Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Battania Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Battania", IsMainToggle = false)]
		public float battaniaKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Battania Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Battania Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Battania", IsMainToggle = false)]
		public bool battaniaKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Khuzait Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Khuzait Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Khuzait", IsMainToggle = false)]
		public float khuzaitKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Khuzait Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Khuzait Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Khuzait", IsMainToggle = false)]
		public float khuzaitKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Khuzait Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Khuzait Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Khuzait", IsMainToggle = false)]
		public bool khuzaitKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Villagers Peasants minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Villagers Peasants minimum party sizes"),
		SettingPropertyGroup("Native/Villagers", IsMainToggle = false)]
		public float villagersPesantsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Villagers Peasants maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Villagers Peasants maximum party sizes"),
		SettingPropertyGroup("Native/Villagers", IsMainToggle = false)]
		public float villagersPesantsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Villagers Peasants Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Villagers Peasants stack Multiplier"),
		SettingPropertyGroup("Native/Villagers", IsMainToggle = false)]
		public bool villagersPesantsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Mercenary Factions minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mercenary Factions minimum party sizes"),
		SettingPropertyGroup("Native/Mercenary", IsMainToggle = false)]
		public float mercenaryFactionsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Mercenary Factions maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mercenary Factions maximum party sizes"),
		SettingPropertyGroup("Native/Mercenary", IsMainToggle = false)]
		public float mercenaryFactionsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Mercenary Factions Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Mercenary Factions stack Multiplier"),
		SettingPropertyGroup("Native/Mercenary", IsMainToggle = false)]
		public bool mercenaryFactionsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Outlaw Factions minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Outlaw Factions minimum party sizes"),
		SettingPropertyGroup("Native/Outlaw", IsMainToggle = false)]
		public float outlawFactionsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Outlaw Factions maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Outlaw Factions maximum party sizes"),
		SettingPropertyGroup("Native/Outlaw", IsMainToggle = false)]
		public float outlawFactionsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Outlaw Factions Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Outlaw Factions stack Multiplier"),
		SettingPropertyGroup("Native/Outlaw", IsMainToggle = false)]
		public bool outlawFactionsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Elite Caravans minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Elite Caravans minimum party sizes"),
		SettingPropertyGroup("Native/Caravans/Elite", IsMainToggle = false)]
		public float eliteCaravansMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Elite Caravans maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Elite Caravans maximum party sizes"),
		SettingPropertyGroup("Native/Caravans/Elite", IsMainToggle = false)]
		public float eliteCaravansMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Elite Caravans Factions Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Elite Caravans Factions stack Multiplier"),
		SettingPropertyGroup("Native/Caravans/Elite", IsMainToggle = false)]
		public bool eliteCaravansMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Caravans minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Caravans minimum party sizes"),
		SettingPropertyGroup("Native/Caravans", IsMainToggle = false)]
		public float caravansMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Caravans maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Caravans maximum party sizes"),
		SettingPropertyGroup("Native/Caravans", IsMainToggle = false)]
		public float caravansMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Caravans Factions Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Caravans Factions stack Multiplier"),
		SettingPropertyGroup("Native/Caravans", IsMainToggle = false)]
		public bool caravansMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Minor Factions minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Minor Factions minimum party sizes"),
		SettingPropertyGroup("Native/Minor", IsMainToggle = false)]
		public float minorFactionsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Minor Factions maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Minor Factions maximum party sizes"),
		SettingPropertyGroup("Native/Minor", IsMainToggle = false)]
		public float minorFactionsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Minor Factions Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Minor Factions stack Multiplier"),
		SettingPropertyGroup("Native/Minor", IsMainToggle = false)]
		public bool minorFactionsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Player gamescom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Player gamescom minimum party sizes"),
		SettingPropertyGroup("Native/Player", IsMainToggle = false)]
		public float gamescomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Player gamescom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Player gamescom maximum party sizes"),
		SettingPropertyGroup("Native/Player", IsMainToggle = false)]
		public float gamescomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Player gamescom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Player gamescom stack Multiplier"),
		SettingPropertyGroup("Native/Player", IsMainToggle = false)]
		public bool gamescomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Player creation kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Player creation kingdom minimum party sizes Player party Sizes "),
		SettingPropertyGroup("Native/Player", IsMainToggle = false)]
		public float charKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Player creation kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Player creation kingdom maximum party sizes Player party Sizes"),
		SettingPropertyGroup("Native/Player", IsMainToggle = false)]
		public float charKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Player creation kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Player creation kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Player", IsMainToggle = false)]
		public bool charKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Other Bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Bandits minimum party sizes"),
		SettingPropertyGroup("Other/Bandits", IsMainToggle = false)]
		public float otherBanditsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Other Bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Bandits maximum party sizes"),
		SettingPropertyGroup("Other/Bandits", IsMainToggle = false)]
		public float otherBanditsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Other Bandits Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Other Bandits stack Multiplier"),
		SettingPropertyGroup("Other/Bandits", IsMainToggle = false)]
		public bool otherBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Other Bandits Boss minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Bandits Boss minimum party sizes"),
		SettingPropertyGroup("Other/Bandits", IsMainToggle = false)]
		public float otherBanditsBossMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Other Bandits Boss maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Bandits Boss maximum party sizes"),
		SettingPropertyGroup("Other/Bandits", IsMainToggle = false)]
		public float otherBanditsBossMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Other Bandits Boss Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Other Bandits Boss stack Multiplier"),
		SettingPropertyGroup("Other/Bandits", IsMainToggle = false)]
		public bool otherBanditsBossMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Other Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Kingdom minimum party sizes"),
		SettingPropertyGroup("Other/Kingdom", IsMainToggle = false)]
		public float otherKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Other Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Kingdom maximum party sizes"),
		SettingPropertyGroup("Other/Kingdom", IsMainToggle = false)]
		public float otherKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Other Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Other Kingdom stack Multiplier"),
		SettingPropertyGroup("Other/Kingdom", IsMainToggle = false)]
		public bool otherKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Minor Factions Other minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Minor Factions minimum party sizes"),
		SettingPropertyGroup("Other/Minor", IsMainToggle = false)]
		public float otherMinorFactionsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Minor Factions Other maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Minor Factions maximum party sizes"),
		SettingPropertyGroup("Other/Minor", IsMainToggle = false)]
		public float otherMinorFactionsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Minor Factions Other Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Other Minor Factions stack Multiplier"),
		SettingPropertyGroup("Other/Minor", IsMainToggle = false)]
		public bool otherMinorFactionsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Custom Spawn Factions minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Custom Spawn minimum party sizes"),
		SettingPropertyGroup("Custom Spawns/All", IsMainToggle = false)]
		public float csFactionsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Custom Spawn Factions maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Custom Spawn maximum party sizes"),
		SettingPropertyGroup("Custom Spawns/All", IsMainToggle = false)]
		public float csFactionsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Custom Spawn Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Custom Spawn Factions stack Multiplier"),
		SettingPropertyGroup("Custom Spawns/All", IsMainToggle = false)]
		public bool csFactionsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyBool("Kaoses Speed Modifiers Enabled", Order = 1, RequireRestart = false, HintText = "Enables Kaoses Speed Modifiers"),
		SettingPropertyGroup("Speed/General", IsMainToggle = false)]
		public bool kaosesSpeedModifiersEnabled { get; set; } = true;

		public bool kaosesSpeedMinimumEnforcedEnabled { get; set; } = true;

		
		[SettingPropertyFloatingInteger("Minimum Speed for Parties ", 0.1f, 3f, Order = 1, RequireRestart = false, HintText = "Set the minimum speed a party can be reduced to"),
		SettingPropertyGroup("Speed/General", IsMainToggle = false)]
		public float kaosesmininumSpeedAmount { get; set; } = 1f;

		
		[SettingPropertyBool("Looter Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Looter Speed Reduction"),
		SettingPropertyGroup("Speed/Looters", IsMainToggle = false)]
		public bool looterSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Looter Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Looter speeds by"),
		SettingPropertyGroup("Speed/Looters", IsMainToggle = false)]
		public float looterSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Steppe Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Steppe Speed Reduction"),
		SettingPropertyGroup("Speed/Steppe", IsMainToggle = false)]
		public bool steppeSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Steppe Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Steppe speeds by"),
		SettingPropertyGroup("Speed/Steppe", IsMainToggle = false)]
		public float steppeSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Desert Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Desert Speed Reduction"),
		SettingPropertyGroup("Speed/Desert", IsMainToggle = false)]
		public bool desertSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Desert Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Desert speeds by"),
		SettingPropertyGroup("Speed/Desert", IsMainToggle = false)]
		public float desertSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Mountain Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Mountain Speed Reduction"),
		SettingPropertyGroup("Speed/Mountain", IsMainToggle = false)]
		public bool mountainSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Mountain Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Mountain speeds by"),
		SettingPropertyGroup("Speed/Mountain", IsMainToggle = false)]
		public float mountainSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Forest Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Forest Speed Reduction"),
		SettingPropertyGroup("Speed/Forest", IsMainToggle = false)]
		public bool forestSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Forest Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Forest speeds by"),
		SettingPropertyGroup("Speed/Forest", IsMainToggle = false)]
		public float forestSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("SeaRaider Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables SeaRaider Speed Reduction"),
		SettingPropertyGroup("Speed/SeaRaider", IsMainToggle = false)]
		public bool seaRaiderSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("SeaRaider Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce SeaRaider speeds by"),
		SettingPropertyGroup("Speed/SeaRaider", IsMainToggle = false)]
		public float seaRaiderSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Caravan Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Caravan Speed Reduction"),
		SettingPropertyGroup("Speed/Caravan", IsMainToggle = false)]
		public bool caravanSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Caravan Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Caravan speeds by"),
		SettingPropertyGroup("Speed/Caravan", IsMainToggle = false)]
		public float caravanSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Elite Caravan Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Elite Caravan Speed Reduction"),
		SettingPropertyGroup("Speed/Caravan", IsMainToggle = false)]
		public bool eliteCaravanSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Elite Caravan Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Elite Caravan speeds by"),
		SettingPropertyGroup("Speed/Caravan", IsMainToggle = false)]
		public float eliteCaravanSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Villager Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Villager Speed Reduction"),
		SettingPropertyGroup("Speed/Villager", IsMainToggle = false)]
		public bool villagerSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Villager Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Villager speeds by"),
		SettingPropertyGroup("Speed/Villager", IsMainToggle = false)]
		public float villagerSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Player Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables player Speed Reduction"),
		SettingPropertyGroup("Speed/Player", IsMainToggle = false)]
		public bool playerSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Player Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Player speeds by"),
		SettingPropertyGroup("Speed/Player", IsMainToggle = false)]
		public float playerSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Player Companions Party Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Player Companions Party Speed Reduction"),
		SettingPropertyGroup("Speed/Player", IsMainToggle = false)]
		public bool playerCompanionSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Player Companions Party Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Player Companions Party speeds by"),
		SettingPropertyGroup("Speed/Player", IsMainToggle = false)]
		public float playerCompanionSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("AI Kingdom Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables AI Kingdom Speed Reduction"),
		SettingPropertyGroup("Speed/Kingdom", IsMainToggle = false)]
		public bool kingdomSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("AI Kingdom Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce AI Kingdom speeds by"),
		SettingPropertyGroup("Speed/Kingdom", IsMainToggle = false)]
		public float kingdomSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("AI Other Minor parties Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Other Minor parties Speed Reductionn"),
		SettingPropertyGroup("Speed/Kingdom", IsMainToggle = false)]
		public bool otherKingdomSpeedReductionEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("AI Other Minor parties Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Other Minor Fations parties speeds by "),
		SettingPropertyGroup("Speed/Kingdom", IsMainToggle = false)]
		public float otherKingdomSpeedReductionAmount { get; set; } = 0f;

		public const string InstanceID = "Kaoses Party Sizes";

		public const string ModuleFolder = "KaosesPartySizes";

		private static KaosesPartySizesSettings _instance;
	}
}
