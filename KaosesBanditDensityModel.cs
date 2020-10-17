using System;
using KaosesPartySizes.Settings;
using TaleWorlds.CampaignSystem;

namespace KaosesPartySizes.Models
{
	// Token: 0x02000010 RID: 16
	internal class KaosesBanditDensityModel : BanditDensityModel
	{
		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000130 RID: 304 RVA: 0x0000419C File Offset: 0x0000239C
		public override int NumberOfMaximumLooterParties
		{
			get
			{
				return ModSettings.Instance.lootersMaximumNoLooterParties;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000041A8 File Offset: 0x000023A8
		public override int NumberOfMinimumBanditPartiesInAHideoutToInfestIt
		{
			get
			{
				return ModSettings.Instance.minimumBanditPartiesInAHideoutToInfestIt;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000132 RID: 306 RVA: 0x000041B4 File Offset: 0x000023B4
		public override int NumberOfMaximumBanditPartiesInEachHideout
		{
			get
			{
				return ModSettings.Instance.maximumBanditPartiesInEachHideout;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000133 RID: 307 RVA: 0x000041C0 File Offset: 0x000023C0
		public override int NumberOfMaximumBanditPartiesAroundEachHideout
		{
			get
			{
				return ModSettings.Instance.maximumBanditPartiesAroundEachHideout;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000134 RID: 308 RVA: 0x000041CC File Offset: 0x000023CC
		public override int NumberOfMaximumHideoutsAtEachBanditFaction
		{
			get
			{
				return ModSettings.Instance.maximumHideoutsAtEachBanditFaction;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000135 RID: 309 RVA: 0x000041D8 File Offset: 0x000023D8
		public override int NumberOfInitialHideoutsAtEachBanditFaction
		{
			get
			{
				return ModSettings.Instance.numberOfInitialHideouts;
			}
		}

		public override int NumberOfMinimumBanditTroopsInHideoutMission
		{
			get;
		}

		public override int PlayerMaximumTroopCountForHideoutMission
		{
			get;
		}

		public override float SpawnPercentageForFirstFightInHideoutMission
		{
			get;
		}

		public override int NumberOfMaximumTroopCountForFirstFightInHideout
		{
			get;
		}

		public override int NumberOfMaximumTroopCountForBossFightInHideout
		{
			get;
		}
	}
}
