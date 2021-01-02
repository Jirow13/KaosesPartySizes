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
        public override string FormatType => "json2";

		/* May not be necessary w/out ModLib.
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

		public static void SetSettings(KaosesPartySizesSettings settings)
		{
			_instance = settings;
		}
		*/

		public bool BIsDebug { get; set; } = false;

		public bool BLogToFile { get; set; } = false;

		public string ModVersionOfConfig { get; set; } = "1.5.6.1";

		
		[SettingPropertyBool("Troop list creation Enabled", Order = 1, RequireRestart = false, HintText = "Enables creating a print out of all parties and unit sizes"),
		SettingPropertyGroup("KaosesPartySizesSettings/Debug")]
		public bool BPrintTroopLimits { get; set; } = false;

		
		[SettingPropertyBool("Log Spawned Parties Enabled", Order = 1, RequireRestart = false, HintText = "Enables logging number of spawned parties by type to log file"),
		SettingPropertyGroup("KaosesPartySizesSettings/Debug")]
		public bool BLogPartySpawns { get; set; } = false;

		
		[SettingPropertyInteger("Looters maximum number of parties", 100, 400, Order = 1, RequireRestart = false, HintText = "Looters maximum number of party Native=300"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population")]
		public int LootersMaximumNoLooterParties { get; set; } = 300;


		[SettingPropertyBool("Hideout Tweaks Enabled", Order = 1, RequireRestart = false, IsToggle = true, HintText = "Enable tweaking hideout populations."),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts")]
		public bool EnableHideoutTweaks { get; set; } = false;

		[SettingPropertyInteger("Number of initial Hideouts", 1, 10, Order = 1, RequireRestart = false, HintText = "Number of initial Bandit Hideouts Per Faction Native=3"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts")]
		public int NumberOfInitialHideoutsAtEachBanditFaction { get; set; } = 3;

		
		[SettingPropertyInteger("Maximum number of Hideouts per bandit Faction", 1, 20, Order = 1, RequireRestart = false, HintText = "Maximum number of Hideouts per bandit faction Native=10"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts")]
		public int NumberOfMaximumHideoutsAtEachBanditFaction { get; set; } = 10;

		
		[SettingPropertyInteger("Maximum number of Parties Per Hideout", 1, 30, Order = 1, RequireRestart = false, HintText = "Maximum number of Parties Around each Hideout for each Bandit faction Native=8"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts")]
		public int NumberOfMaximumBanditPartiesAroundEachHideout { get; set; } = 8;

		
		[SettingPropertyInteger("Maximum number of Parties in a Hideout", 1, 10, Order = 1, RequireRestart = false, HintText = "Maximum number of Parties In a Hideout for each faction Native=4"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts")]
		public int NumberOfMaximumBanditPartiesInEachHideout { get; set; } = 4;


		[SettingPropertyInteger("Minimum number of Parties in a Hideout to infest it", 1, 10, Order = 1, RequireRestart = false, HintText = "Minimum number of Parties in a Hideout to infest it Native=2"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts")]
		public int NumberOfMinimumBanditPartiesInAHideoutToInfestIt { get; set; } = 2;

/*		Jiros: Removed this as it's duplicated in Bannerlord Tweaks. Would have to be added to Harmony patch if it's to be enabled.
		[SettingPropertyInteger("PlayerMaximumTroopCountForHideoutMission", 1, 90, Order = 1, RequireRestart = false, HintText = "PlayerMaximumTroopCountForHideoutMission"),
		SettingPropertyGroup("KaosesPartySizesSettings/Bandits Population/Hideouts")]
		public int PlayerMaximumTroopCountForHideoutMission { get; set; } = 20;
*/

		[SettingPropertyFloatingInteger("Looters minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Looters minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Looters")]
		public float LootersMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Looters maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Looters maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Looters")]
		public float LootersMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Looters Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Looters stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Looters")]
		public bool LootersMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Forest bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Forest bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Forest")]
		public float ForestBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Forest bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Forest bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Forest")]
		public float ForestBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Forest Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Forest Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Forest")]
		public bool ForestBanditMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Forest Boss bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Forest Boss bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Forest")]
		public float ForestBossBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Forest Boss bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Forest Boss bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Forest")]
		public float ForestBossBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Forest Boss Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Forest Boss Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Forest")]
		public bool ForestBossBanditMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Sea bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sea bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Sea")]
		public float SeaBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Sea bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sea bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Sea")]
		public float SeaBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Sea Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Sea Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Sea")]
		public bool SeaBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Sea Boss bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sea Boss bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Sea")]
		public float SeaBossBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Sea Boss bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sea Boss bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Sea")]
		public float SeaBossBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Sea Boss Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Sea Boss Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Sea")]
		public bool SeaBossBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Mountain bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mountain bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Mountain")]
		public float MountainBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Mountain bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mountain bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Mountain")]
		public float MountainBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Mountain Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Mountain Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Mountain")]
		public bool MountainBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Mountain Boss bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mountain Boss bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Mountain")]
		public float MountainBossBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Mountain Boss bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mountain Boss bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Mountain")]
		public float MountainBossBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Mountain Boss Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Mountain Boss Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Mountain")]
		public bool MountainBossBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Desert bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Desert bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Desert")]
		public float DesertBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Desert bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Desert bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Desert")]
		public float DesertBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Desert Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Desert Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Desert")]
		public bool DesertBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Desert Boss bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Desert Boss bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Desert")]
		public float DesertBossBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Desert Boss bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Desert Boss bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Desert")]
		public float DesertBossBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Desert Boss Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Desert Boss Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Desert")]
		public bool DesertBossBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Steppe bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Steppe bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Steppe")]
		public float SteppeBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Steppe bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Steppe bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Steppe")]
		public float SteppeBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Steppe Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Steppe Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Steppe")]
		public bool SteppeBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Steppe Boss bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Steppe Boss bandits minimum party sizes"),
		SettingPropertyGroup("Native/Bandits/Steppe")]
		public float SteppeBossBanditMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Steppe Boss bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Steppe Boss bandits maximum party sizes"),
		SettingPropertyGroup("Native/Bandits/Steppe")]
		public float SteppeBossBanditMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Steppe Boss Bandit Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Steppe Boss Bandit stack Multiplier"),
		SettingPropertyGroup("Native/Bandits/Steppe")]
		public bool SteppeBossBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Empire Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Empire Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Empire")]
		public float EmpireKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Empire Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Empire Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Empire")]
		public float EmpireKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Empire Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Empire Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Empire")]
		public bool EmpireKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Sturgia Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sturgia Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Sturgia")]
		public float SturgiaKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Sturgia Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Sturgia Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Sturgia")]
		public float SturgiaKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Sturgia Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Sturgia Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Sturgia")]
		public bool SturgiaKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Aserai Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Aserai Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Aserai")]
		public float AseraiKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Aserai Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Aserai Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Aserai")]
		public float AseraiKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Aserai Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Aserai Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Aserai")]
		public bool AseraiKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Vlandia Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Vlandia Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Vlandia")]
		public float VlandiaKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Vlandia Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Vlandia Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Vlandia")]
		public float VlandiaKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Vlandia Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Vlandia Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Vlandia")]
		public bool VlandiaKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Battania Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Battania Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Battania")]
		public float BattaniaKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Battania Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Battania Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Battania")]
		public float BattaniaKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Battania Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Battania Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Battania")]
		public bool BattaniaKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Khuzait Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Khuzait Kingdom minimum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Khuzait")]
		public float KhuzaitKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Khuzait Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Khuzait Kingdom maximum party sizes"),
		SettingPropertyGroup("Native/Kingdom/Khuzait")]
		public float KhuzaitKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Khuzait Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Khuzait Kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Kingdom/Khuzait")]
		public bool KhuzaitKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Villagers Peasants minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Villagers Peasants minimum party sizes"),
		SettingPropertyGroup("Native/Villagers")]
		public float VillagersPesantsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Villagers Peasants maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Villagers Peasants maximum party sizes"),
		SettingPropertyGroup("Native/Villagers")]
		public float VillagersPesantsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Villagers Peasants Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Villagers Peasants stack Multiplier"),
		SettingPropertyGroup("Native/Villagers")]
		public bool VillagersPesantsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Mercenary Factions minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mercenary Factions minimum party sizes"),
		SettingPropertyGroup("Native/Mercenary")]
		public float MercenaryFactionsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Mercenary Factions maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Mercenary Factions maximum party sizes"),
		SettingPropertyGroup("Native/Mercenary")]
		public float MercenaryFactionsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Mercenary Factions Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Mercenary Factions stack Multiplier"),
		SettingPropertyGroup("Native/Mercenary")]
		public bool MercenaryFactionsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Outlaw Factions minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Outlaw Factions minimum party sizes"),
		SettingPropertyGroup("Native/Outlaw")]
		public float OutlawFactionsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Outlaw Factions maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Outlaw Factions maximum party sizes"),
		SettingPropertyGroup("Native/Outlaw")]
		public float OutlawFactionsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Outlaw Factions Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Outlaw Factions stack Multiplier"),
		SettingPropertyGroup("Native/Outlaw")]
		public bool OutlawFactionsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Elite Caravans minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Elite Caravans minimum party sizes"),
		SettingPropertyGroup("Native/Caravans/Elite")]
		public float EliteCaravansMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Elite Caravans maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Elite Caravans maximum party sizes"),
		SettingPropertyGroup("Native/Caravans/Elite")]
		public float EliteCaravansMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Elite Caravans Factions Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Elite Caravans Factions stack Multiplier"),
		SettingPropertyGroup("Native/Caravans/Elite")]
		public bool EliteCaravansMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Caravans minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Caravans minimum party sizes"),
		SettingPropertyGroup("Native/Caravans")]
		public float CaravansMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Caravans maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Caravans maximum party sizes"),
		SettingPropertyGroup("Native/Caravans")]
		public float CaravansMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Caravans Factions Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Caravans Factions stack Multiplier"),
		SettingPropertyGroup("Native/Caravans")]
		public bool CaravansMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Minor Factions minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Minor Factions minimum party sizes"),
		SettingPropertyGroup("Native/Minor")]
		public float MinorFactionsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Minor Factions maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Minor Factions maximum party sizes"),
		SettingPropertyGroup("Native/Minor")]
		public float MinorFactionsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Minor Factions Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Minor Factions stack Multiplier"),
		SettingPropertyGroup("Native/Minor")]
		public bool MinorFactionsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Player gamescom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Player gamescom minimum party sizes"),
		SettingPropertyGroup("Native/Player")]
		public float GamescomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Player gamescom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Player gamescom maximum party sizes"),
		SettingPropertyGroup("Native/Player")]
		public float GamescomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Player gamescom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Player gamescom stack Multiplier"),
		SettingPropertyGroup("Native/Player")]
		public bool GamescomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Player creation kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Player creation kingdom minimum party sizes Player party Sizes "),
		SettingPropertyGroup("Native/Player")]
		public float CharKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Player creation kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Player creation kingdom maximum party sizes Player party Sizes"),
		SettingPropertyGroup("Native/Player")]
		public float CharKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Player creation kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Player creation kingdom stack Multiplier"),
		SettingPropertyGroup("Native/Player")]
		public bool CharKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Other Bandits minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Bandits minimum party sizes"),
		SettingPropertyGroup("Other/Bandits")]
		public float OtherBanditsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Other Bandits maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Bandits maximum party sizes"),
		SettingPropertyGroup("Other/Bandits")]
		public float OtherBanditsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Other Bandits Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Other Bandits stack Multiplier"),
		SettingPropertyGroup("Other/Bandits")]
		public bool OtherBanditsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Other Bandits Boss minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Bandits Boss minimum party sizes"),
		SettingPropertyGroup("Other/Bandits")]
		public float OtherBanditsBossMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Other Bandits Boss maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Bandits Boss maximum party sizes"),
		SettingPropertyGroup("Other/Bandits")]
		public float OtherBanditsBossMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Other Bandits Boss Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Other Bandits Boss stack Multiplier"),
		SettingPropertyGroup("Other/Bandits")]
		public bool OtherBanditsBossMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Other Kingdom minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Kingdom minimum party sizes"),
		SettingPropertyGroup("Other/Kingdom")]
		public float OtherKingdomMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Other Kingdom maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Kingdom maximum party sizes"),
		SettingPropertyGroup("Other/Kingdom")]
		public float OtherKingdomMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Other Kingdom Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Other Kingdom stack Multiplier"),
		SettingPropertyGroup("Other/Kingdom")]
		public bool OtherKingdomMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Minor Factions Other minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Minor Factions minimum party sizes"),
		SettingPropertyGroup("Other/Minor")]
		public float OtherMinorFactionsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Minor Factions Other maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Other Minor Factions maximum party sizes"),
		SettingPropertyGroup("Other/Minor")]
		public float OtherMinorFactionsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Minor Factions Other Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Other Minor Factions stack Multiplier"),
		SettingPropertyGroup("Other/Minor")]
		public bool OtherMinorFactionsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Custom Spawn Factions minimum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Custom Spawn minimum party sizes"),
		SettingPropertyGroup("Custom Spawns/All")]
		public float CSFactionsMinMultiplier { get; set; } = 1f;

		
		[SettingPropertyFloatingInteger("Custom Spawn Factions maximum Multiplier", 0.1f, 10f, Order = 1, RequireRestart = false, HintText = "Multiply Custom Spawn maximum party sizes"),
		SettingPropertyGroup("Custom Spawns/All")]
		public float CSFactionsMaxMultiplier { get; set; } = 1f;

		
		[SettingPropertyBool("Custom Spawn Multiplier Enabled", Order = 1, RequireRestart = false, HintText = "Enables Custom Spawn Factions stack Multiplier"),
		SettingPropertyGroup("Custom Spawns/All")]
		public bool CSFactionsMultiplierEnabled { get; set; } = false;

		
		[SettingPropertyBool("Kaoses Speed Modifiers Enabled", Order = 1, RequireRestart = false, HintText = "Enables Kaoses Speed Modifiers"),
		SettingPropertyGroup("Speed/General")]
		public bool KaosesSpeedModifiersEnabled { get; set; } = true;

		public bool KaosesSpeedMinimumEnforcedEnabled { get; set; } = true;

		
		[SettingPropertyFloatingInteger("Minimum Speed for Parties ", 0.1f, 3f, Order = 1, RequireRestart = false, HintText = "Set the minimum speed a party can be reduced to"),
		SettingPropertyGroup("Speed/General")]
		public float KaosesMininumSpeedAmount { get; set; } = 1f;

		
		[SettingPropertyBool("Looter Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Looter Speed Reduction"),
		SettingPropertyGroup("Speed/Looters")]
		public bool LooterSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Looter Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Looter speeds by"),
		SettingPropertyGroup("Speed/Looters")]
		public float LooterSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Steppe Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Steppe Speed Reduction"),
		SettingPropertyGroup("Speed/Steppe")]
		public bool SteppeSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Steppe Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Steppe speeds by"),
		SettingPropertyGroup("Speed/Steppe")]
		public float SteppeSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Desert Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Desert Speed Reduction"),
		SettingPropertyGroup("Speed/Desert")]
		public bool DesertSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Desert Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Desert speeds by"),
		SettingPropertyGroup("Speed/Desert")]
		public float DesertSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Mountain Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Mountain Speed Reduction"),
		SettingPropertyGroup("Speed/Mountain")]
		public bool MountainSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Mountain Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Mountain speeds by"),
		SettingPropertyGroup("Speed/Mountain")]
		public float MountainSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Forest Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Forest Speed Reduction"),
		SettingPropertyGroup("Speed/Forest")]
		public bool ForestSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Forest Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Forest speeds by"),
		SettingPropertyGroup("Speed/Forest")]
		public float ForestSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("SeaRaider Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables SeaRaider Speed Reduction"),
		SettingPropertyGroup("Speed/SeaRaider")]
		public bool SeaRaiderSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("SeaRaider Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce SeaRaider speeds by"),
		SettingPropertyGroup("Speed/SeaRaider")]
		public float SeaRaiderSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Caravan Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Caravan Speed Reduction"),
		SettingPropertyGroup("Speed/Caravan")]
		public bool CaravanSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Caravan Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Caravan speeds by"),
		SettingPropertyGroup("Speed/Caravan")]
		public float CaravanSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Elite Caravan Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Elite Caravan Speed Reduction"),
		SettingPropertyGroup("Speed/Caravan")]
		public bool EliteCaravanSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Elite Caravan Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Elite Caravan speeds by"),
		SettingPropertyGroup("Speed/Caravan")]
		public float EliteCaravanSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Villager Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Villager Speed Reduction"),
		SettingPropertyGroup("Speed/Villager")]
		public bool VillagerSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Villager Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Villager speeds by"),
		SettingPropertyGroup("Speed/Villager")]
		public float VillagerSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Player Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables player Speed Reduction"),
		SettingPropertyGroup("Speed/Player")]
		public bool PlayerSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Player Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Player speeds by"),
		SettingPropertyGroup("Speed/Player")]
		public float PlayerSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("Player Companions Party Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Player Companions Party Speed Reduction"),
		SettingPropertyGroup("Speed/Player")]
		public bool PlayerCompanionSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("Player Companions Party Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Player Companions Party speeds by"),
		SettingPropertyGroup("Speed/Player")]
		public float PlayerCompanionSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("AI Kingdom Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables AI Kingdom Speed Reduction"),
		SettingPropertyGroup("Speed/Kingdom")]
		public bool KingdomSpeedReductiontEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("AI Kingdom Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce AI Kingdom speeds by"),
		SettingPropertyGroup("Speed/Kingdom")]
		public float KingdomSpeedReductionAmount { get; set; } = 0f;

		
		[SettingPropertyBool("AI Other Minor parties Speed Reduction Enabled", Order = 1, RequireRestart = false, HintText = "Enables Other Minor parties Speed Reductionn"),
		SettingPropertyGroup("Speed/Kingdom")]
		public bool OtherKingdomSpeedReductionEnabled { get; set; } = false;

		
		[SettingPropertyFloatingInteger("AI Other Minor parties Speed Reduction ", -3.5f, 3.5f, Order = 1, RequireRestart = false, HintText = "Amount to reduce Other Minor Fations parties speeds by "),
		SettingPropertyGroup("Speed/Kingdom")]
		public float OtherKingdomSpeedReductionAmount { get; set; } = 0f;

		public const string InstanceID = "Kaoses Party Sizes";

		public const string ModuleFolder = "KaosesPartySizes";

		//private static KaosesPartySizesSettings? _instance;
	}
}
