using System;
using System.Xml.Serialization;
using ModLib.Definitions;
using ModLib.Definitions.Attributes;

namespace KaosesPartySizes.Settings
{
	public class ModSettings : SettingsBase
	{
		public override string ModName
		{
			get
			{
				return "Kaoses Party Sizes 0.1.11";
			}
		}

		public override string ModuleFolderName
		{
			get
			{
				return "KaosesPartySizes";
			}
		}

		[XmlElement]
		public override string ID { get; set; } = "Kaoses Party Sizes";

		public static ModSettings Instance
		{
			get
			{
				bool flag = ModSettings._instance == null;
				if (flag)
				{
					ModSettings._instance = (ModSettings)SettingsDatabase.GetSettings<ModSettings>();
				}
				return ModSettings._instance;
			}
		}

		public static void SetSettings(ModSettings settings)
		{
			ModSettings._instance = settings;
		}

		public bool bIsDebug { get; set; } = false;

		public bool bLogToFile { get; set; } = false;

		public bool bOverRideModLibSettings { get; set; } = false;

		public string modVersionOfConfig { get; set; } = "0.1.11";

		[XmlElement]
		[SettingProperty("Troop list creation Enabled", "Enables creating a print out of all parties and unit sizes")]
		[SettingPropertyGroup("ModSettings/Debug", false)]
		public bool bPrintTroopLimits { get; set; } = false;

		[XmlElement]
		[SettingProperty("Log Spawned Parties Enabled", "Enables logging number of spawned parties by type to log file")]
		[SettingPropertyGroup("ModSettings/Debug", false)]
		public bool bLogPartySpawns { get; set; } = false;

		[XmlElement]
		[SettingProperty("Looters maximum number of parties", 100, 400, "looters maximum number of party Native=300")]
		[SettingPropertyGroup("ModSettings/Bandits Population", false)]
		public int lootersMaximumNoLooterParties { get; set; } = 300;

		[XmlElement]
		[SettingProperty("Number of initial Hideouts", 1, 10, "Number of initial Bandit Hideouts Per Faction Native=3")]
		[SettingPropertyGroup("ModSettings/Bandits Population", false)]
		public int numberOfInitialHideouts { get; set; } = 3;

		[XmlElement]
		[SettingProperty("Maximum number of Hideouts per bandit Faction", 1, 20, "Maximum number of Hideouts per bandit faction Native=10")]
		[SettingPropertyGroup("ModSettings/Bandits Population", false)]
		public int maximumHideoutsAtEachBanditFaction { get; set; } = 10;

		[XmlElement]
		[SettingProperty("Maximum number of Parties Per Hideout", 1, 30, "Maximum number of Parties Around each Hideout for each Bandit faction Native=8")]
		[SettingPropertyGroup("ModSettings/Bandits Population", false)]
		public int maximumBanditPartiesAroundEachHideout { get; set; } = 8;

		[XmlElement]
		[SettingProperty("Maximum number of Parties in a Hideout", 1, 10, "Maximum number of Parties In a Hideout for each faction Native=4")]
		[SettingPropertyGroup("ModSettings/Bandits Population", false)]
		public int maximumBanditPartiesInEachHideout { get; set; } = 4;

		[XmlElement]
		[SettingProperty("Minimum number of Parties in a Hideout to infest it", 1, 10, "Minimum number of Parties in a Hideout to infest it Native=2")]
		[SettingPropertyGroup("ModSettings/Bandits Population", false)]
		public int minimumBanditPartiesInAHideoutToInfestIt { get; set; } = 2;

		[XmlElement]
		[SettingProperty("Looters minimum Multiplier", 0.1f, 10f, "Multiply looters minimum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Looters", false)]
		public float lootersMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Looters maximum Multiplier", 0.1f, 10f, "Multiply looters maximum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Looters", false)]
		public float lootersMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Looters Multiplier Enabled", "Enables Looters stack Multiplier")]
		[SettingPropertyGroup("Native/Bandits/Looters", false)]
		public bool lootersMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Forest bandits minimum Multiplier", 0.1f, 10f, "Multiply Forest bandits minimum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Forest", false)]
		public float forestBanditMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Forest bandits maximum Multiplier", 0.1f, 10f, "Multiply Forest bandits maximum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Forest", false)]
		public float forestBanditMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Forest Bandit Multiplier Enabled", "Enables Forest Bandit stack Multiplier")]
		[SettingPropertyGroup("Native/Bandits/Forest", false)]
		public bool forestBanditMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Forest Boss bandits minimum Multiplier", 0.1f, 10f, "Multiply Forest Boss bandits minimum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Forest", false)]
		public float forestBossBanditMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Forest Boss bandits maximum Multiplier", 0.1f, 10f, "Multiply Forest Boss bandits maximum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Forest", false)]
		public float forestBossBanditMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Forest Boss Bandit Multiplier Enabled", "Enables Forest Boss Bandit stack Multiplier")]
		[SettingPropertyGroup("Native/Bandits/Forest", false)]
		public bool forestBossBanditMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Sea bandits minimum Multiplier", 0.1f, 10f, "Multiply Sea bandits minimum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Sea", false)]
		public float seaBanditMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Sea bandits maximum Multiplier", 0.1f, 10f, "Multiply Sea bandits maximum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Sea", false)]
		public float seaBanditMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Sea Bandit Multiplier Enabled", "Enables Sea Bandit stack Multiplier")]
		[SettingPropertyGroup("Native/Bandits/Sea", false)]
		public bool seaBanditsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Sea Boss bandits minimum Multiplier", 0.1f, 10f, "Multiply Sea Boss bandits minimum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Sea", false)]
		public float seaBossBanditMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Sea Boss bandits maximum Multiplier", 0.1f, 10f, "Multiply Sea Boss bandits maximum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Sea", false)]
		public float seaBossBanditMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Sea Boss Bandit Multiplier Enabled", "Enables Sea Boss Bandit stack Multiplier")]
		[SettingPropertyGroup("Native/Bandits/Sea", false)]
		public bool seaBossBanditsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Mountain bandits minimum Multiplier", 0.1f, 10f, "Multiply Mountain bandits minimum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Mountain", false)]
		public float mountainBanditMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Mountain bandits maximum Multiplier", 0.1f, 10f, "Multiply Mountain bandits maximum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Mountain", false)]
		public float mountainBanditMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Mountain Bandit Multiplier Enabled", "Enables Mountain Bandit stack Multiplier")]
		[SettingPropertyGroup("Native/Bandits/Mountain", false)]
		public bool mountainBanditsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Mountain Boss bandits minimum Multiplier", 0.1f, 10f, "Multiply Mountain Boss bandits minimum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Mountain", false)]
		public float mountainBossBanditMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Mountain Boss bandits maximum Multiplier", 0.1f, 10f, "Multiply Mountain Boss bandits maximum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Mountain", false)]
		public float mountainBossBanditMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Mountain Boss Bandit Multiplier Enabled", "Enables Mountain Boss Bandit stack Multiplier")]
		[SettingPropertyGroup("Native/Bandits/Mountain", false)]
		public bool mountainBossBanditsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Desert bandits minimum Multiplier", 0.1f, 10f, "Multiply Desert bandits minimum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Desert", false)]
		public float desertBanditMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Desert bandits maximum Multiplier", 0.1f, 10f, "Multiply Desert bandits maximum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Desert", false)]
		public float desertBanditMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Desert Bandit Multiplier Enabled", "Enables Desert Bandit stack Multiplier")]
		[SettingPropertyGroup("Native/Bandits/Desert", false)]
		public bool desertBanditsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Desert Boss bandits minimum Multiplier", 0.1f, 10f, "Multiply Desert Boss bandits minimum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Desert", false)]
		public float desertBossBanditMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Desert Boss bandits maximum Multiplier", 0.1f, 10f, "Multiply Desert Boss bandits maximum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Desert", false)]
		public float desertBossBanditMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Desert Boss Bandit Multiplier Enabled", "Enables Desert Boss Bandit stack Multiplier")]
		[SettingPropertyGroup("Native/Bandits/Desert", false)]
		public bool desertBossBanditsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Steppe bandits minimum Multiplier", 0.1f, 10f, "Multiply Steppe bandits minimum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Steppe", false)]
		public float steppeBanditMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Steppe bandits maximum Multiplier", 0.1f, 10f, "Multiply Steppe bandits maximum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Steppe", false)]
		public float steppeBanditMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Steppe Bandit Multiplier Enabled", "Enables Steppe Bandit stack Multiplier")]
		[SettingPropertyGroup("Native/Bandits/Steppe", false)]
		public bool steppeBanditsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Steppe Boss bandits minimum Multiplier", 0.1f, 10f, "Multiply Steppe Boss bandits minimum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Steppe", false)]
		public float steppeBossBanditMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Steppe Boss bandits maximum Multiplier", 0.1f, 10f, "Multiply Steppe Boss bandits maximum party sizes")]
		[SettingPropertyGroup("Native/Bandits/Steppe", false)]
		public float steppeBossBanditMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Steppe Boss Bandit Multiplier Enabled", "Enables Steppe Boss Bandit stack Multiplier")]
		[SettingPropertyGroup("Native/Bandits/Steppe", false)]
		public bool steppeBossBanditsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Empire Kingdom minimum Multiplier", 0.1f, 10f, "Multiply Empire Kingdom minimum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Empire", false)]
		public float empireKingdomMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Empire Kingdom maximum Multiplier", 0.1f, 10f, "Multiply Empire Kingdom maximum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Empire", false)]
		public float empireKingdomMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Empire Kingdom Multiplier Enabled", "Enables Empire Kingdom stack Multiplier")]
		[SettingPropertyGroup("Native/Kingdom/Empire", false)]
		public bool empireKingdomMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Sturgia Kingdom minimum Multiplier", 0.1f, 10f, "Multiply Sturgia Kingdom minimum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Sturgia", false)]
		public float sturgiaKingdomMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Sturgia Kingdom maximum Multiplier", 0.1f, 10f, "Multiply Sturgia Kingdom maximum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Sturgia", false)]
		public float sturgiaKingdomMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Sturgia Kingdom Multiplier Enabled", "Enables Sturgia Kingdom stack Multiplier")]
		[SettingPropertyGroup("Native/Kingdom/Sturgia", false)]
		public bool sturgiaKingdomMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Aserai Kingdom minimum Multiplier", 0.1f, 10f, "Multiply Aserai Kingdom minimum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Aserai", false)]
		public float aseraiKingdomMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Aserai Kingdom maximum Multiplier", 0.1f, 10f, "Multiply Aserai Kingdom maximum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Aserai", false)]
		public float aseraiKingdomMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Aserai Kingdom Multiplier Enabled", "Enables Aserai Kingdom stack Multiplier")]
		[SettingPropertyGroup("Native/Kingdom/Aserai", false)]
		public bool aseraiKingdomMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Vlandia Kingdom minimum Multiplier", 0.1f, 10f, "Multiply Vlandia Kingdom minimum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Vlandia", false)]
		public float vlandiaKingdomMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Vlandia Kingdom maximum Multiplier", 0.1f, 10f, "Multiply Vlandia Kingdom maximum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Vlandia", false)]
		public float vlandiaKingdomMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Vlandia Kingdom Multiplier Enabled", "Enables Vlandia Kingdom stack Multiplier")]
		[SettingPropertyGroup("Native/Kingdom/Vlandia", false)]
		public bool vlandiaKingdomMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Battania Kingdom minimum Multiplier", 0.1f, 10f, "Multiply Battania Kingdom minimum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Battania", false)]
		public float battaniaKingdomMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Battania Kingdom maximum Multiplier", 0.1f, 10f, "Multiply Battania Kingdom maximum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Battania", false)]
		public float battaniaKingdomMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Battania Kingdom Multiplier Enabled", "Enables Battania Kingdom stack Multiplier")]
		[SettingPropertyGroup("Native/Kingdom/Battania", false)]
		public bool battaniaKingdomMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Khuzait Kingdom minimum Multiplier", 0.1f, 10f, "Multiply Khuzait Kingdom minimum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Khuzait", false)]
		public float khuzaitKingdomMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Khuzait Kingdom maximum Multiplier", 0.1f, 10f, "Multiply Khuzait Kingdom maximum party sizes")]
		[SettingPropertyGroup("Native/Kingdom/Khuzait", false)]
		public float khuzaitKingdomMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Khuzait Kingdom Multiplier Enabled", "Enables Khuzait Kingdom stack Multiplier")]
		[SettingPropertyGroup("Native/Kingdom/Khuzait", false)]
		public bool khuzaitKingdomMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Villagers Peasants minimum Multiplier", 0.1f, 10f, "Multiply Villagers Peasants minimum party sizes")]
		[SettingPropertyGroup("Native/Villagers", false)]
		public float villagersPesantsMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Villagers Peasants maximum Multiplier", 0.1f, 10f, "Multiply Villagers Peasants maximum party sizes")]
		[SettingPropertyGroup("Native/Villagers", false)]
		public float villagersPesantsMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Villagers Peasants Multiplier Enabled", "Enables Villagers Peasants stack Multiplier")]
		[SettingPropertyGroup("Native/Villagers", false)]
		public bool villagersPesantsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Mercenary Factions minimum Multiplier", 0.1f, 10f, "Multiply Mercenary Factions minimum party sizes")]
		[SettingPropertyGroup("Native/Mercenary", false)]
		public float mercenaryFactionsMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Mercenary Factions maximum Multiplier", 0.1f, 10f, "Multiply Mercenary Factions maximum party sizes")]
		[SettingPropertyGroup("Native/Mercenary", false)]
		public float mercenaryFactionsMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Mercenary Factions Multiplier Enabled", "Enables Mercenary Factions stack Multiplier")]
		[SettingPropertyGroup("Native/Mercenary", false)]
		public bool mercenaryFactionsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Outlaw Factions minimum Multiplier", 0.1f, 10f, "Multiply Outlaw Factions minimum party sizes")]
		[SettingPropertyGroup("Native/Outlaw", false)]
		public float outlawFactionsMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Outlaw Factions maximum Multiplier", 0.1f, 10f, "Multiply Outlaw Factions maximum party sizes")]
		[SettingPropertyGroup("Native/Outlaw", false)]
		public float outlawFactionsMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Outlaw Factions Multiplier Enabled", "Enables Outlaw Factions stack Multiplier")]
		[SettingPropertyGroup("Native/Outlaw", false)]
		public bool outlawFactionsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Elite Caravans minimum Multiplier", 0.1f, 10f, "Multiply Elite Caravans minimum party sizes")]
		[SettingPropertyGroup("Native/Caravans/Elite", false)]
		public float eliteCaravansMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Elite Caravans maximum Multiplier", 0.1f, 10f, "Multiply Elite Caravans maximum party sizes")]
		[SettingPropertyGroup("Native/Caravans/Elite", false)]
		public float eliteCaravansMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Elite Caravans Factions Multiplier Enabled", "Enables Elite Caravans Factions stack Multiplier")]
		[SettingPropertyGroup("Native/Caravans/Elite", false)]
		public bool eliteCaravansMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Caravans minimum Multiplier", 0.1f, 10f, "Multiply Caravans minimum party sizes")]
		[SettingPropertyGroup("Native/Caravans", false)]
		public float caravansMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Caravans maximum Multiplier", 0.1f, 10f, "Multiply Caravans maximum party sizes")]
		[SettingPropertyGroup("Native/Caravans", false)]
		public float caravansMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Caravans Factions Multiplier Enabled", "Enables Caravans Factions stack Multiplier")]
		[SettingPropertyGroup("Native/Caravans", false)]
		public bool caravansMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Minor Factions minimum Multiplier", 0.1f, 10f, "Multiply Minor Factions minimum party sizes")]
		[SettingPropertyGroup("Native/Minor", false)]
		public float minorFactionsMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Minor Factions maximum Multiplier", 0.1f, 10f, "Multiply Minor Factions maximum party sizes")]
		[SettingPropertyGroup("Native/Minor", false)]
		public float minorFactionsMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Minor Factions Multiplier Enabled", "Enables Minor Factions stack Multiplier")]
		[SettingPropertyGroup("Native/Minor", false)]
		public bool minorFactionsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Player gamescom minimum Multiplier", 0.1f, 10f, "Multiply Player gamescom minimum party sizes")]
		[SettingPropertyGroup("Native/Player", false)]
		public float gamescomMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Player gamescom maximum Multiplier", 0.1f, 10f, "Multiply Player gamescom maximum party sizes")]
		[SettingPropertyGroup("Native/Player", false)]
		public float gamescomMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Player gamescom Multiplier Enabled", "Enables Player gamescom stack Multiplier")]
		[SettingPropertyGroup("Native/Player", false)]
		public bool gamescomMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Player creation kingdom minimum Multiplier", 0.1f, 10f, "Multiply Player creation kingdom minimum party sizes Player party Sizes ")]
		[SettingPropertyGroup("Native/Player", false)]
		public float charKingdomMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Player creation kingdom maximum Multiplier", 0.1f, 10f, "Multiply Player creation kingdom maximum party sizes Player party Sizes")]
		[SettingPropertyGroup("Native/Player", false)]
		public float charKingdomMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Player creation kingdom Multiplier Enabled", "Enables Player creation kingdom stack Multiplier")]
		[SettingPropertyGroup("Native/Player", false)]
		public bool charKingdomMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Other Bandits minimum Multiplier", 0.1f, 10f, "Multiply Other Bandits minimum party sizes")]
		[SettingPropertyGroup("Other/Bandits", false)]
		public float otherBanditsMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Other Bandits maximum Multiplier", 0.1f, 10f, "Multiply Other Bandits maximum party sizes")]
		[SettingPropertyGroup("Other/Bandits", false)]
		public float otherBanditsMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Other Bandits Multiplier Enabled", "Enables Other Bandits stack Multiplier")]
		[SettingPropertyGroup("Other/Bandits", false)]
		public bool otherBanditsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Other Bandits Boss minimum Multiplier", 0.1f, 10f, "Multiply Other Bandits Boss minimum party sizes")]
		[SettingPropertyGroup("Other/Bandits", false)]
		public float otherBanditsBossMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Other Bandits Boss maximum Multiplier", 0.1f, 10f, "Multiply Other Bandits Boss maximum party sizes")]
		[SettingPropertyGroup("Other/Bandits", false)]
		public float otherBanditsBossMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Other Bandits Boss Multiplier Enabled", "Enables Other Bandits Boss stack Multiplier")]
		[SettingPropertyGroup("Other/Bandits", false)]
		public bool otherBanditsBossMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Other Kingdom minimum Multiplier", 0.1f, 10f, "Multiply Other Kingdom minimum party sizes")]
		[SettingPropertyGroup("Other/Kingdom", false)]
		public float otherKingdomMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Other Kingdom maximum Multiplier", 0.1f, 10f, "Multiply Other Kingdom maximum party sizes")]
		[SettingPropertyGroup("Other/Kingdom", false)]
		public float otherKingdomMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Other Kingdom Multiplier Enabled", "Enables Other Kingdom stack Multiplier")]
		[SettingPropertyGroup("Other/Kingdom", false)]
		public bool otherKingdomMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Minor Factions Other minimum Multiplier", 0.1f, 10f, "Multiply Other Minor Factions minimum party sizes")]
		[SettingPropertyGroup("Other/Minor", false)]
		public float otherMinorFactionsMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Minor Factions Other maximum Multiplier", 0.1f, 10f, "Multiply Other Minor Factions maximum party sizes")]
		[SettingPropertyGroup("Other/Minor", false)]
		public float otherMinorFactionsMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Minor Factions Other Multiplier Enabled", "Enables Other Minor Factions stack Multiplier")]
		[SettingPropertyGroup("Other/Minor", false)]
		public bool otherMinorFactionsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Custom Spawn Factions minimum Multiplier", 0.1f, 10f, "Multiply Custom Spawn minimum party sizes")]
		[SettingPropertyGroup("Custom Spawns/All", false)]
		public float csFactionsMinMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Custom Spawn Factions maximum Multiplier", 0.1f, 10f, "Multiply Custom Spawn maximum party sizes")]
		[SettingPropertyGroup("Custom Spawns/All", false)]
		public float csFactionsMaxMultiplier { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Custom Spawn Multiplier Enabled", "Enables Custom Spawn Factions stack Multiplier")]
		[SettingPropertyGroup("Custom Spawns/All", false)]
		public bool csFactionsMultiplierEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Kaoses Speed Modifiers Enabled", "Enables Kaoses Speed Modifiers")]
		[SettingPropertyGroup("Speed/General", false)]
		public bool kaosesSpeedModifiersEnabled { get; set; } = true;

		public bool kaosesSpeedMinimumEnforcedEnabled { get; set; } = true;

		[XmlElement]
		[SettingProperty("Minimum Speed for Parties ", 0.1f, 3f, "Set the minimum speed a party can be reduced to")]
		[SettingPropertyGroup("Speed/General", false)]
		public float kaosesmininumSpeedAmount { get; set; } = 1f;

		[XmlElement]
		[SettingProperty("Looter Speed Reduction Enabled", "Enables Looter Speed Reduction")]
		[SettingPropertyGroup("Speed/Looters", false)]
		public bool looterSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Looter Speed Reduction ", -3.5f, 3.5f, "Amount to reduce Looter speeds by")]
		[SettingPropertyGroup("Speed/Looters", false)]
		public float looterSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("Steppe Speed Reduction Enabled", "Enables Steppe Speed Reduction")]
		[SettingPropertyGroup("Speed/Steppe", false)]
		public bool steppeSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Steppe Speed Reduction ", -3.5f, 3.5f, "Amount to reduce Steppe speeds by")]
		[SettingPropertyGroup("Speed/Steppe", false)]
		public float steppeSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("Desert Speed Reduction Enabled", "Enables Desert Speed Reduction")]
		[SettingPropertyGroup("Speed/Desert", false)]
		public bool desertSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Desert Speed Reduction ", -3.5f, 3.5f, "Amount to reduce Desert speeds by")]
		[SettingPropertyGroup("Speed/Desert", false)]
		public float desertSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("Mountain Speed Reduction Enabled", "Enables Mountain Speed Reduction")]
		[SettingPropertyGroup("Speed/Mountain", false)]
		public bool mountainSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Mountain Speed Reduction ", -3.5f, 3.5f, "Amount to reduce Mountain speeds by")]
		[SettingPropertyGroup("Speed/Mountain", false)]
		public float mountainSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("Forest Speed Reduction Enabled", "Enables Forest Speed Reduction")]
		[SettingPropertyGroup("Speed/Forest", false)]
		public bool forestSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Forest Speed Reduction ", -3.5f, 3.5f, "Amount to reduce Forest speeds by")]
		[SettingPropertyGroup("Speed/Forest", false)]
		public float forestSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("SeaRaider Speed Reduction Enabled", "Enables SeaRaider Speed Reduction")]
		[SettingPropertyGroup("Speed/SeaRaider", false)]
		public bool seaRaiderSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("SeaRaider Speed Reduction ", -3.5f, 3.5f, "Amount to reduce SeaRaider speeds by")]
		[SettingPropertyGroup("Speed/SeaRaider", false)]
		public float seaRaiderSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("Caravan Speed Reduction Enabled", "Enables Caravan Speed Reduction")]
		[SettingPropertyGroup("Speed/Caravan", false)]
		public bool caravanSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Caravan Speed Reduction ", -3.5f, 3.5f, "Amount to reduce Caravan speeds by")]
		[SettingPropertyGroup("Speed/Caravan", false)]
		public float caravanSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("Elite Caravan Speed Reduction Enabled", "Enables Elite Caravan Speed Reduction")]
		[SettingPropertyGroup("Speed/Caravan", false)]
		public bool eliteCaravanSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Elite Caravan Speed Reduction ", -3.5f, 3.5f, "Amount to reduce Elite Caravan speeds by")]
		[SettingPropertyGroup("Speed/Caravan", false)]
		public float eliteCaravanSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("Villager Speed Reduction Enabled", "Enables Villager Speed Reduction")]
		[SettingPropertyGroup("Speed/Villager", false)]
		public bool villagerSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Villager Speed Reduction ", -3.5f, 3.5f, "Amount to reduce Villager speeds by")]
		[SettingPropertyGroup("Speed/Villager", false)]
		public float villagerSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("Player Speed Reduction Enabled", "Enables player Speed Reduction")]
		[SettingPropertyGroup("Speed/Player", false)]
		public bool playerSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Player Speed Reduction ", -3.5f, 3.5f, "Amount to reduce Player speeds by")]
		[SettingPropertyGroup("Speed/Player", false)]
		public float playerSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("Player Companions Party Speed Reduction Enabled", "Enables Player Companions Party Speed Reduction")]
		[SettingPropertyGroup("Speed/Player", false)]
		public bool playerCompanionSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("Player Companions Party Speed Reduction ", -3.5f, 3.5f, "Amount to reduce Player Companions Party speeds by")]
		[SettingPropertyGroup("Speed/Player", false)]
		public float playerCompanionSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("AI Kingdom Speed Reduction Enabled", "Enables AI Kingdom Speed Reduction")]
		[SettingPropertyGroup("Speed/Kingdom", false)]
		public bool kingdomSpeedReductiontEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("AI Kingdom Speed Reduction ", -3.5f, 3.5f, "Amount to reduce AI Kingdom speeds by")]
		[SettingPropertyGroup("Speed/Kingdom", false)]
		public float kingdomSpeedReductionAmount { get; set; } = 0f;

		[XmlElement]
		[SettingProperty("AI Other Minor parties Speed Reduction Enabled", "Enables Other Minor parties Speed Reductionn")]
		[SettingPropertyGroup("Speed/Kingdom", false)]
		public bool otherKingdomSpeedReductionEnabled { get; set; } = false;

		[XmlElement]
		[SettingProperty("AI Other Minor parties Speed Reduction ", -3.5f, 3.5f, "Amount to reduce Other Minor Fations parties speeds by ")]
		[SettingPropertyGroup("Speed/Kingdom", false)]
		public float otherKingdomSpeedReductionAmount { get; set; } = 0f;

		public const string InstanceID = "Kaoses Party Sizes";

		public const string ModuleFolder = "KaosesPartySizes";

		private static ModSettings _instance;
	}
}
