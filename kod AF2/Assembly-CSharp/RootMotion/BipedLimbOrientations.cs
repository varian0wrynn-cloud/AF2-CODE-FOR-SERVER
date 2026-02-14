using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x020003CA RID: 970
	[Serializable]
	public class BipedLimbOrientations
	{
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600D1D3 RID: 53715 RVA: 0x005FFAEC File Offset: 0x005FDCEC
		public static BipedLimbOrientations MaxBiped
		{
			get
			{
				return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
			}
		}

		// Token: 0x0600D1D4 RID: 53716 RVA: 0x005FFB50 File Offset: 0x005FDD50
		public static BipedLimbOrientations ENMPEJFCFLB()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1D5 RID: 53717 RVA: 0x005FFBB4 File Offset: 0x005FDDB4
		public static BipedLimbOrientations JCMBLFDMGEA()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1D6 RID: 53718 RVA: 0x005FFC18 File Offset: 0x005FDE18
		public static BipedLimbOrientations HHNIAGEPOFA()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1D7 RID: 53719 RVA: 0x005FFC7C File Offset: 0x005FDE7C
		public static BipedLimbOrientations PLEINNEHDPM()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1D8 RID: 53720 RVA: 0x005FFCE0 File Offset: 0x005FDEE0
		public static BipedLimbOrientations NLJLLIJHLIJ()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1D9 RID: 53721 RVA: 0x005FFD44 File Offset: 0x005FDF44
		public static BipedLimbOrientations LGCAPJEHHNO()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1DA RID: 53722 RVA: 0x005FFDA8 File Offset: 0x005FDFA8
		public static BipedLimbOrientations FDLIJMNFNLD()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1DB RID: 53723 RVA: 0x005FFE0C File Offset: 0x005FE00C
		public static BipedLimbOrientations NKNDMKMJHCM()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1DC RID: 53724 RVA: 0x005FFE70 File Offset: 0x005FE070
		public static BipedLimbOrientations BNNFDGACDLC()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1DD RID: 53725 RVA: 0x005FFED4 File Offset: 0x005FE0D4
		public static BipedLimbOrientations HKPPECCHCCC()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1DE RID: 53726 RVA: 0x005FFF38 File Offset: 0x005FE138
		public static BipedLimbOrientations HDIFJIHFDOI()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1DF RID: 53727 RVA: 0x005FFF9C File Offset: 0x005FE19C
		public static BipedLimbOrientations KENCKEDCELH()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1E0 RID: 53728 RVA: 0x00600000 File Offset: 0x005FE200
		public static BipedLimbOrientations OLNFIHHFHDI()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1E1 RID: 53729 RVA: 0x00600064 File Offset: 0x005FE264
		public static BipedLimbOrientations OBAJKKPJAGN()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1E2 RID: 53730 RVA: 0x006000C8 File Offset: 0x005FE2C8
		public static BipedLimbOrientations MBEKIBELNBK()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1E3 RID: 53731 RVA: 0x0060012C File Offset: 0x005FE32C
		public static BipedLimbOrientations JBLCOONFHEC()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1E4 RID: 53732 RVA: 0x00600190 File Offset: 0x005FE390
		public static BipedLimbOrientations FBNHHHPIGDE()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1E5 RID: 53733 RVA: 0x006001F4 File Offset: 0x005FE3F4
		public static BipedLimbOrientations ANCMFAMFPCE()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1E6 RID: 53734 RVA: 0x00600258 File Offset: 0x005FE458
		public static BipedLimbOrientations AIOHNCLJCKB()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1E7 RID: 53735 RVA: 0x006002BC File Offset: 0x005FE4BC
		public static BipedLimbOrientations JENPDOLAINK()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1E8 RID: 53736 RVA: 0x00600320 File Offset: 0x005FE520
		public static BipedLimbOrientations BHCBPHBCABP()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1E9 RID: 53737 RVA: 0x00600384 File Offset: 0x005FE584
		public static BipedLimbOrientations ANHDBHABDFD()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1EA RID: 53738 RVA: 0x006003E8 File Offset: 0x005FE5E8
		public static BipedLimbOrientations GJBPJCGGFEM()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1EB RID: 53739 RVA: 0x0060044C File Offset: 0x005FE64C
		public static BipedLimbOrientations HHMMALLDMKO()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1EC RID: 53740 RVA: 0x006004B0 File Offset: 0x005FE6B0
		public static BipedLimbOrientations MBGEHKAGPPE()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1ED RID: 53741 RVA: 0x00600514 File Offset: 0x005FE714
		public static BipedLimbOrientations BFEJODGNDPI()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1EE RID: 53742 RVA: 0x00600578 File Offset: 0x005FE778
		public static BipedLimbOrientations OAOCNIGHOPD()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1EF RID: 53743 RVA: 0x006005DC File Offset: 0x005FE7DC
		public static BipedLimbOrientations OCOMKNBLBGF()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1F0 RID: 53744 RVA: 0x00600640 File Offset: 0x005FE840
		public static BipedLimbOrientations JCBBMAJENFN()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1F1 RID: 53745 RVA: 0x006006A4 File Offset: 0x005FE8A4
		public static BipedLimbOrientations EGCGLCOHJKD()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1F2 RID: 53746 RVA: 0x00600708 File Offset: 0x005FE908
		public static BipedLimbOrientations INILCDHGHKJ()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1F3 RID: 53747 RVA: 0x0060076C File Offset: 0x005FE96C
		public static BipedLimbOrientations NICNACCNJFE()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1F4 RID: 53748 RVA: 0x006007D0 File Offset: 0x005FE9D0
		public static BipedLimbOrientations BMGLNBBCNEK()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1F5 RID: 53749 RVA: 0x00600832 File Offset: 0x005FEA32
		public BipedLimbOrientations(BipedLimbOrientations.LimbOrientation NBCODHAOBPB, BipedLimbOrientations.LimbOrientation DEKDDELAFMG, BipedLimbOrientations.LimbOrientation NMBNMHHBBGH, BipedLimbOrientations.LimbOrientation BJHFDEDCMLF)
		{
			this.leftArm = NBCODHAOBPB;
			this.rightArm = DEKDDELAFMG;
			this.leftLeg = NMBNMHHBBGH;
			this.rightLeg = BJHFDEDCMLF;
		}

		// Token: 0x0600D1F6 RID: 53750 RVA: 0x00600858 File Offset: 0x005FEA58
		public static BipedLimbOrientations GGPNIKFEHLP()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1F7 RID: 53751 RVA: 0x006008BC File Offset: 0x005FEABC
		public static BipedLimbOrientations ENHKCGCIPIA()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1F8 RID: 53752 RVA: 0x00600920 File Offset: 0x005FEB20
		public static BipedLimbOrientations PPLPKKIFBEN()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1F9 RID: 53753 RVA: 0x00600984 File Offset: 0x005FEB84
		public static BipedLimbOrientations KGKNGEGPFJI()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1FA RID: 53754 RVA: 0x006009E8 File Offset: 0x005FEBE8
		public static BipedLimbOrientations DEIFGMELJIK()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1FB RID: 53755 RVA: 0x00600A4C File Offset: 0x005FEC4C
		public static BipedLimbOrientations MGEKJICMFAL()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1FC RID: 53756 RVA: 0x00600AB0 File Offset: 0x005FECB0
		public static BipedLimbOrientations HFGGGNHCLNN()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D1FD RID: 53757 RVA: 0x00600B14 File Offset: 0x005FED14
		public static BipedLimbOrientations GJEEOFHHIPE()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1FE RID: 53758 RVA: 0x00600B78 File Offset: 0x005FED78
		public static BipedLimbOrientations FMHKMONCIIO()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D1FF RID: 53759 RVA: 0x00600BDC File Offset: 0x005FEDDC
		public static BipedLimbOrientations KFIPCODFMKM()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D200 RID: 53760 RVA: 0x00600C40 File Offset: 0x005FEE40
		public static BipedLimbOrientations OLAIOHHJALA()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D201 RID: 53761 RVA: 0x00600CA4 File Offset: 0x005FEEA4
		public static BipedLimbOrientations IFMMJLJMLDD()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D202 RID: 53762 RVA: 0x00600D08 File Offset: 0x005FEF08
		public static BipedLimbOrientations IMLOAHKBNCP()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D203 RID: 53763 RVA: 0x00600D6C File Offset: 0x005FEF6C
		public static BipedLimbOrientations EHEAAAHLPPF()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D204 RID: 53764 RVA: 0x00600DD0 File Offset: 0x005FEFD0
		public static BipedLimbOrientations OPABDBHDBMP()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D205 RID: 53765 RVA: 0x00600E34 File Offset: 0x005FF034
		public static BipedLimbOrientations JIEMHNCBEAG()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D206 RID: 53766 RVA: 0x00600E98 File Offset: 0x005FF098
		public static BipedLimbOrientations JOOOEPBELML()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D207 RID: 53767 RVA: 0x00600EFC File Offset: 0x005FF0FC
		public static BipedLimbOrientations PPMPOPMAEPL()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D208 RID: 53768 RVA: 0x00600F60 File Offset: 0x005FF160
		public static BipedLimbOrientations PPODPNOMJEP()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D209 RID: 53769 RVA: 0x00600FC4 File Offset: 0x005FF1C4
		public static BipedLimbOrientations DIKAOJODDKL()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D20A RID: 53770 RVA: 0x00601028 File Offset: 0x005FF228
		public static BipedLimbOrientations JAJIKGDPOIL()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D20B RID: 53771 RVA: 0x0060108C File Offset: 0x005FF28C
		public static BipedLimbOrientations HLFADOJFHBB()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D20C RID: 53772 RVA: 0x006010F0 File Offset: 0x005FF2F0
		public static BipedLimbOrientations PGLKMEFFDPH()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D20D RID: 53773 RVA: 0x00601154 File Offset: 0x005FF354
		public static BipedLimbOrientations CDGKHJNDEFJ()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D20E RID: 53774 RVA: 0x006011B8 File Offset: 0x005FF3B8
		public static BipedLimbOrientations LLEBJGHCDLE()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D20F RID: 53775 RVA: 0x0060121C File Offset: 0x005FF41C
		public static BipedLimbOrientations IBIBFOAPMOE()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D210 RID: 53776 RVA: 0x00601280 File Offset: 0x005FF480
		public static BipedLimbOrientations KLPNMLDNMJP()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D211 RID: 53777 RVA: 0x006012E4 File Offset: 0x005FF4E4
		public static BipedLimbOrientations KEKFNHMBFHI()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D212 RID: 53778 RVA: 0x00601348 File Offset: 0x005FF548
		public static BipedLimbOrientations EFDDCMPICPM()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600D213 RID: 53779 RVA: 0x006013AC File Offset: 0x005FF5AC
		public static BipedLimbOrientations UMA
		{
			get
			{
				return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
			}
		}

		// Token: 0x0600D214 RID: 53780 RVA: 0x00601410 File Offset: 0x005FF610
		public static BipedLimbOrientations CBCDBKLFENB()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D215 RID: 53781 RVA: 0x00601474 File Offset: 0x005FF674
		public static BipedLimbOrientations CDGFJIFLDIJ()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D216 RID: 53782 RVA: 0x006014D8 File Offset: 0x005FF6D8
		public static BipedLimbOrientations HIGJLGMFLLN()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D217 RID: 53783 RVA: 0x0060153C File Offset: 0x005FF73C
		public static BipedLimbOrientations LNMGDDGDLML()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D218 RID: 53784 RVA: 0x006015A0 File Offset: 0x005FF7A0
		public static BipedLimbOrientations MJDGHHJOHGO()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D219 RID: 53785 RVA: 0x00601604 File Offset: 0x005FF804
		public static BipedLimbOrientations CGJFJMLHDOB()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D21A RID: 53786 RVA: 0x00601668 File Offset: 0x005FF868
		public static BipedLimbOrientations BCLCHCIEPCO()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D21B RID: 53787 RVA: 0x006016CC File Offset: 0x005FF8CC
		public static BipedLimbOrientations COJBCGBIFHE()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D21C RID: 53788 RVA: 0x00601730 File Offset: 0x005FF930
		public static BipedLimbOrientations KELNDJIHKKO()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D21D RID: 53789 RVA: 0x00601794 File Offset: 0x005FF994
		public static BipedLimbOrientations DBACMCFIJAD()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D21E RID: 53790 RVA: 0x006017F8 File Offset: 0x005FF9F8
		public static BipedLimbOrientations PIJDKFLECAO()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D21F RID: 53791 RVA: 0x0060185C File Offset: 0x005FFA5C
		public static BipedLimbOrientations KBLJGKFMFIC()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D220 RID: 53792 RVA: 0x006018C0 File Offset: 0x005FFAC0
		public static BipedLimbOrientations OGPAKMJDOAN()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D221 RID: 53793 RVA: 0x00601924 File Offset: 0x005FFB24
		public static BipedLimbOrientations EFJCBHEOFHP()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D222 RID: 53794 RVA: 0x00601988 File Offset: 0x005FFB88
		public static BipedLimbOrientations AJHBLFDMMCO()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D223 RID: 53795 RVA: 0x006019EC File Offset: 0x005FFBEC
		public static BipedLimbOrientations FHEGFPPPPIH()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D224 RID: 53796 RVA: 0x00601A50 File Offset: 0x005FFC50
		public static BipedLimbOrientations LKKKCEMENAK()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D225 RID: 53797 RVA: 0x00601AB4 File Offset: 0x005FFCB4
		public static BipedLimbOrientations CEJKAIFPOAL()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D226 RID: 53798 RVA: 0x00601B18 File Offset: 0x005FFD18
		public static BipedLimbOrientations MLEAGNBLIDD()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D227 RID: 53799 RVA: 0x00601B7C File Offset: 0x005FFD7C
		public static BipedLimbOrientations PHMOGMCFNJJ()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D228 RID: 53800 RVA: 0x00601BE0 File Offset: 0x005FFDE0
		public static BipedLimbOrientations NPDFIOIEMJL()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D229 RID: 53801 RVA: 0x00601C44 File Offset: 0x005FFE44
		public static BipedLimbOrientations MCKFMDJEGCD()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D22A RID: 53802 RVA: 0x00601CA8 File Offset: 0x005FFEA8
		public static BipedLimbOrientations OJOELKNHAPC()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D22B RID: 53803 RVA: 0x00601D0C File Offset: 0x005FFF0C
		public static BipedLimbOrientations HNEAPOGIJMB()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x0600D22C RID: 53804 RVA: 0x00601D70 File Offset: 0x005FFF70
		public static BipedLimbOrientations FAPEAIGICAJ()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.down, Vector3.down, Vector3.up), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.up, Vector3.up, Vector3.back));
		}

		// Token: 0x0600D22D RID: 53805 RVA: 0x00601DD4 File Offset: 0x005FFFD4
		public static BipedLimbOrientations PMABCOFKJPH()
		{
			return new BipedLimbOrientations(new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.forward), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.back), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down), new BipedLimbOrientations.LimbOrientation(Vector3.forward, Vector3.forward, Vector3.down));
		}

		// Token: 0x04001BCB RID: 7115
		public BipedLimbOrientations.LimbOrientation leftArm;

		// Token: 0x04001BCC RID: 7116
		public BipedLimbOrientations.LimbOrientation rightArm;

		// Token: 0x04001BCD RID: 7117
		public BipedLimbOrientations.LimbOrientation leftLeg;

		// Token: 0x04001BCE RID: 7118
		public BipedLimbOrientations.LimbOrientation rightLeg;

		// Token: 0x020003CB RID: 971
		[Serializable]
		public class LimbOrientation
		{
			// Token: 0x0600D22E RID: 53806 RVA: 0x00601E36 File Offset: 0x00600036
			public LimbOrientation(Vector3 DFHDLHCNGKH, Vector3 GOMLKICHCOF, Vector3 EBPBBDCJFDB)
			{
				this.upperBoneForwardAxis = DFHDLHCNGKH;
				this.lowerBoneForwardAxis = GOMLKICHCOF;
				this.lastBoneLeftAxis = EBPBBDCJFDB;
			}

			// Token: 0x04001BCF RID: 7119
			public Vector3 upperBoneForwardAxis;

			// Token: 0x04001BD0 RID: 7120
			public Vector3 lowerBoneForwardAxis;

			// Token: 0x04001BD1 RID: 7121
			public Vector3 lastBoneLeftAxis;
		}
	}
}
