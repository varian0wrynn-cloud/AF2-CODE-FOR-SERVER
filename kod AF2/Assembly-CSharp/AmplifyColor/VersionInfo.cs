using System;
using UnityEngine;

namespace AmplifyColor
{
	// Token: 0x020005D4 RID: 1492
	[Serializable]
	public class VersionInfo
	{
		// Token: 0x0601387C RID: 79996 RVA: 0x00858F90 File Offset: 0x00857190
		public static VersionInfo FJJMNEMLCKN()
		{
			return new VersionInfo(1, 6, 0);
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x0601387D RID: 79997 RVA: 0x00858F9A File Offset: 0x0085719A
		public int Number
		{
			get
			{
				return this.m_major * 100 + this.m_minor * 10 + this.m_release;
			}
		}

		// Token: 0x0601387E RID: 79998 RVA: 0x00858FB6 File Offset: 0x008571B6
		public static bool IOAJLEMEAEG(VersionInfo LEFPMHIHJCF)
		{
			return 1 == LEFPMHIHJCF.m_major && 7 == LEFPMHIHJCF.m_minor && 1 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x0601387F RID: 79999 RVA: 0x00858FD5 File Offset: 0x008571D5
		public static VersionInfo DLAOBENAHAP()
		{
			return new VersionInfo(0, 4, 0);
		}

		// Token: 0x06013880 RID: 80000 RVA: 0x00858FDF File Offset: 0x008571DF
		public virtual string IHKJGKNNIHA()
		{
			return string.Format("UIChat_channel", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013881 RID: 80001 RVA: 0x0085901B File Offset: 0x0085721B
		public static string FNECFIMHFBC()
		{
			return string.Format("1HandSwordChargeUp", 1, 3, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013882 RID: 80002 RVA: 0x00859048 File Offset: 0x00857248
		public int FLDHPCPFLBI()
		{
			return this.m_major * -127 + this.m_minor * 95 + this.m_release;
		}

		// Token: 0x06013883 RID: 80003 RVA: 0x00859064 File Offset: 0x00857264
		public static string BMALDJOHBCM()
		{
			return string.Format("_TempRT", 0, 2, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013884 RID: 80004 RVA: 0x00859091 File Offset: 0x00857291
		public virtual string LIPEANHPLJI()
		{
			return string.Format("firsStartInfoPanel", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013885 RID: 80005 RVA: 0x008590CD File Offset: 0x008572CD
		public int FLELBDPDGGL()
		{
			return this.m_major * 66 + this.m_minor * -65 + this.m_release;
		}

		// Token: 0x06013886 RID: 80006 RVA: 0x008590E9 File Offset: 0x008572E9
		public static string JBHPCGOBNFA()
		{
			return string.Format("int: ", 0, 8, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013887 RID: 80007 RVA: 0x00859116 File Offset: 0x00857316
		public static bool JCANIPFMKKB(VersionInfo LEFPMHIHJCF)
		{
			return 1 == LEFPMHIHJCF.m_major && 3 == LEFPMHIHJCF.m_minor && 0 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x06013888 RID: 80008 RVA: 0x00859135 File Offset: 0x00857335
		public static VersionInfo FHFNCHDOHNE()
		{
			return new VersionInfo(1, 7, 1);
		}

		// Token: 0x06013889 RID: 80009 RVA: 0x0085913F File Offset: 0x0085733F
		public static string NDPGLDEAHGP()
		{
			return string.Format("holesFree", 1, 0, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x0601388A RID: 80010 RVA: 0x0085916C File Offset: 0x0085736C
		public virtual string ODIEAGLLEPA()
		{
			return string.Format("<.*?>", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x0601388B RID: 80011 RVA: 0x008591A8 File Offset: 0x008573A8
		public virtual string DIPEOLHEMHK()
		{
			return string.Format("Handstand", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x0601388C RID: 80012 RVA: 0x008591E4 File Offset: 0x008573E4
		public virtual string OKJEDFNFDML()
		{
			return string.Format("Original health bar: ", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x0601388D RID: 80013 RVA: 0x00859220 File Offset: 0x00857420
		public static string HKEOCKMFGIA()
		{
			return string.Format("Flares", 1, 4, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x0601388E RID: 80014 RVA: 0x0085924D File Offset: 0x0085744D
		public static string MPIONFHHHNK()
		{
			return string.Format("0", 1, 8, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x0601388F RID: 80015 RVA: 0x0085927A File Offset: 0x0085747A
		public virtual string PMPNLAFNBBC()
		{
			return string.Format("", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013890 RID: 80016 RVA: 0x008592B6 File Offset: 0x008574B6
		public static string LPDLDBJFJBI()
		{
			return string.Format("StartRigidModule", 0, 8, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013891 RID: 80017 RVA: 0x008592E3 File Offset: 0x008574E3
		public virtual string IBLEHFEBIMG()
		{
			return string.Format("_OcclusionColor", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013892 RID: 80018 RVA: 0x0085931F File Offset: 0x0085751F
		public static string LABEIELMCLK()
		{
			return string.Format("Giant2HandGrab", 1, 5, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013893 RID: 80019 RVA: 0x0085934C File Offset: 0x0085754C
		public static bool NKIBBJMPOCB(VersionInfo LEFPMHIHJCF)
		{
			return 1 == LEFPMHIHJCF.m_major && 8 == LEFPMHIHJCF.m_minor && 0 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x06013894 RID: 80020 RVA: 0x0085936B File Offset: 0x0085756B
		public int IOAFGDNNKFD()
		{
			return this.m_major * -63 + this.m_minor * -120 + this.m_release;
		}

		// Token: 0x06013895 RID: 80021 RVA: 0x00859387 File Offset: 0x00857587
		public int MLDKKPCFLME()
		{
			return this.m_major * -22 + this.m_minor * -30 + this.m_release;
		}

		// Token: 0x06013896 RID: 80022 RVA: 0x008593A3 File Offset: 0x008575A3
		public static string FMGJLLBAKBN()
		{
			return string.Format("", 1, 7, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013897 RID: 80023 RVA: 0x008593D0 File Offset: 0x008575D0
		public virtual string IGPNJMFIDOD()
		{
			return string.Format("error.wav", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013898 RID: 80024 RVA: 0x0085940C File Offset: 0x0085760C
		public static string GKAMPEIEEIG()
		{
			return string.Format("IceHockey", 1, 5, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x06013899 RID: 80025 RVA: 0x00859439 File Offset: 0x00857639
		public static string LDJDJEPEHLO()
		{
			return string.Format("_ExposureAdjustment", 0, 0, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x0601389A RID: 80026 RVA: 0x00859466 File Offset: 0x00857666
		public virtual string FOIFFCPAJMI()
		{
			return string.Format("RussianDance", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x0601389B RID: 80027 RVA: 0x008594A2 File Offset: 0x008576A2
		public static bool DDLKIDDPEFC(VersionInfo LEFPMHIHJCF)
		{
			return 0 != LEFPMHIHJCF.m_major || 5 != LEFPMHIHJCF.m_minor || 0 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x0601389C RID: 80028 RVA: 0x008594C1 File Offset: 0x008576C1
		public static string LBAHBNCHKJL()
		{
			return string.Format("{0}.{1}.{2}", 1, 5, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x0601389D RID: 80029 RVA: 0x008594EE File Offset: 0x008576EE
		public virtual string GAOJCHIOICI()
		{
			return string.Format("file:///", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x0601389E RID: 80030 RVA: 0x0085952A File Offset: 0x0085772A
		public int CMCFPOENLKE()
		{
			return this.m_major * 67 + this.m_minor * -122 + this.m_release;
		}

		// Token: 0x0601389F RID: 80031 RVA: 0x00859546 File Offset: 0x00857746
		public virtual string CKAHIPBPLPM()
		{
			return string.Format("{0} / {1}", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138A0 RID: 80032 RVA: 0x00859582 File Offset: 0x00857782
		public static string AAFCGJNPHNK()
		{
			return string.Format("buyVIP OK", 0, 2, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138A1 RID: 80033 RVA: 0x008595AF File Offset: 0x008577AF
		public static string MKCNHJBEOIH()
		{
			return string.Format("MotorbikeLassoLeft", 0, 1, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138A2 RID: 80034 RVA: 0x008595DC File Offset: 0x008577DC
		public static bool GAEEIIJCFOH(VersionInfo LEFPMHIHJCF)
		{
			return 0 != LEFPMHIHJCF.m_major || 7 != LEFPMHIHJCF.m_minor || 0 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138A3 RID: 80035 RVA: 0x008595FB File Offset: 0x008577FB
		public static bool JAPGEMBGLBA(VersionInfo LEFPMHIHJCF)
		{
			return 1 == LEFPMHIHJCF.m_major && 5 == LEFPMHIHJCF.m_minor && 1 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138A4 RID: 80036 RVA: 0x0085961A File Offset: 0x0085781A
		public static string BGPOCPPAOOO()
		{
			return string.Format("WorkerHammer2", 1, 3, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138A5 RID: 80037 RVA: 0x00859647 File Offset: 0x00857847
		public static VersionInfo MPAAMGFOLJH()
		{
			return new VersionInfo(0, 5, 0);
		}

		// Token: 0x060138A6 RID: 80038 RVA: 0x00859651 File Offset: 0x00857851
		public virtual string EFODDEDDHCE()
		{
			return string.Format("_AxialAberration", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138A7 RID: 80039 RVA: 0x0085968D File Offset: 0x0085788D
		public virtual string ALELIIHGHGH()
		{
			return string.Format("Mouse Y", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138A8 RID: 80040 RVA: 0x008596C9 File Offset: 0x008578C9
		public static bool CEOIGBMLLFF(VersionInfo LEFPMHIHJCF)
		{
			return 0 != LEFPMHIHJCF.m_major || 8 != LEFPMHIHJCF.m_minor || 1 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138A9 RID: 80041 RVA: 0x008596E8 File Offset: 0x008578E8
		public int CFGBNNLJEHA()
		{
			return this.m_major * -111 + this.m_minor * 102 + this.m_release;
		}

		// Token: 0x060138AA RID: 80042 RVA: 0x00859704 File Offset: 0x00857904
		public static VersionInfo LGMNNNCPNHO()
		{
			return new VersionInfo(0, 8, 0);
		}

		// Token: 0x060138AB RID: 80043 RVA: 0x0085970E File Offset: 0x0085790E
		public virtual string FODPNPHBOKL()
		{
			return string.Format("focus :D", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138AC RID: 80044 RVA: 0x0085974A File Offset: 0x0085794A
		public static string DBCGEGAGDJO()
		{
			return string.Format("rait_1", 0, 5, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138AD RID: 80045 RVA: 0x00859777 File Offset: 0x00857977
		public static string GMCCIALHFME()
		{
			return string.Format("gi_uinf_10", 1, 7, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138AE RID: 80046 RVA: 0x008597A4 File Offset: 0x008579A4
		public static VersionInfo NMNAMPCJDMC()
		{
			return new VersionInfo(1, 0, 1);
		}

		// Token: 0x060138AF RID: 80047 RVA: 0x008597AE File Offset: 0x008579AE
		public static bool HGDCPPCDCML(VersionInfo LEFPMHIHJCF)
		{
			return 1 == LEFPMHIHJCF.m_major && 7 == LEFPMHIHJCF.m_minor && 0 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138B0 RID: 80048 RVA: 0x008597CD File Offset: 0x008579CD
		public virtual string IJBMEKGBNEK()
		{
			return string.Format("CrouchStrafeLeft", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138B1 RID: 80049 RVA: 0x00859809 File Offset: 0x00857A09
		public static VersionInfo FABKPPEOPNO()
		{
			return new VersionInfo(1, 4, 0);
		}

		// Token: 0x060138B2 RID: 80050 RVA: 0x00859813 File Offset: 0x00857A13
		private VersionInfo(byte NGCBNGCICEK, byte APKOCPEFHHJ, byte GMBGDJMCPAM)
		{
			this.m_major = (int)NGCBNGCICEK;
			this.m_minor = (int)APKOCPEFHHJ;
			this.m_release = (int)GMBGDJMCPAM;
		}

		// Token: 0x060138B3 RID: 80051 RVA: 0x00859830 File Offset: 0x00857A30
		public virtual string DFHAGGBIEIH()
		{
			return string.Format("_MaskTex", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138B4 RID: 80052 RVA: 0x0085986C File Offset: 0x00857A6C
		public virtual string IPDCPCECFBC()
		{
			return string.Format("}", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138B5 RID: 80053 RVA: 0x008598A8 File Offset: 0x00857AA8
		public virtual string DIACBNHNDCJ()
		{
			return string.Format("\n", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138B6 RID: 80054 RVA: 0x008598E4 File Offset: 0x00857AE4
		public virtual string KCBJCGOINMK()
		{
			return string.Format("1HandSwordChargeUp", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138B7 RID: 80055 RVA: 0x00859920 File Offset: 0x00857B20
		public static VersionInfo IPEHLIFIKBI()
		{
			return new VersionInfo(1, 5, 1);
		}

		// Token: 0x060138B8 RID: 80056 RVA: 0x008597A4 File Offset: 0x008579A4
		public static VersionInfo DGHMMMMCEGJ()
		{
			return new VersionInfo(1, 0, 1);
		}

		// Token: 0x060138B9 RID: 80057 RVA: 0x0085992A File Offset: 0x00857B2A
		public static VersionInfo HHEBKAIPFJP()
		{
			return new VersionInfo(0, 6, 1);
		}

		// Token: 0x060138BA RID: 80058 RVA: 0x00859934 File Offset: 0x00857B34
		public static bool AGKKKAOHJHO(VersionInfo LEFPMHIHJCF)
		{
			return 1 == LEFPMHIHJCF.m_major && 6 == LEFPMHIHJCF.m_minor && 1 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138BB RID: 80059 RVA: 0x00859953 File Offset: 0x00857B53
		public static string EEPNJCOFAFO()
		{
			return string.Format("<color='{2}'>{0}: {1}</color>", 0, 8, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138BC RID: 80060 RVA: 0x00859920 File Offset: 0x00857B20
		public static VersionInfo KMGEBKNCOGI()
		{
			return new VersionInfo(1, 5, 1);
		}

		// Token: 0x060138BD RID: 80061 RVA: 0x00859980 File Offset: 0x00857B80
		public static string HPOBBJOFOGP()
		{
			return string.Format("post_12", 0, 6, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138BE RID: 80062 RVA: 0x008599AD File Offset: 0x00857BAD
		public static string EKDIOBFJOHG()
		{
			return string.Format("_SecondTex", 0, 1, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138BF RID: 80063 RVA: 0x008599DA File Offset: 0x00857BDA
		public virtual string GIOCLFJADKN()
		{
			return string.Format("inv_nodur", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138C0 RID: 80064 RVA: 0x00859A16 File Offset: 0x00857C16
		public static bool NJCAHHICKHI(VersionInfo LEFPMHIHJCF)
		{
			return 0 != LEFPMHIHJCF.m_major || 2 != LEFPMHIHJCF.m_minor || 0 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138C1 RID: 80065 RVA: 0x00859A35 File Offset: 0x00857C35
		public virtual string ANJOEAHHDGC()
		{
			return string.Format("IdleReadyLook", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138C2 RID: 80066 RVA: 0x0085968D File Offset: 0x0085788D
		public virtual string OOLIOFBGDKC()
		{
			return string.Format("Mouse Y", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138C3 RID: 80067 RVA: 0x00859A71 File Offset: 0x00857C71
		public virtual string ADOAJOFIPAM()
		{
			return string.Format("Wizard2HandThrow", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138C4 RID: 80068 RVA: 0x00859AAD File Offset: 0x00857CAD
		public override string ToString()
		{
			return string.Format("{0}.{1}.{2}", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138C5 RID: 80069 RVA: 0x00859AE9 File Offset: 0x00857CE9
		public virtual string DINGGHOCDNN()
		{
			return string.Format("BowFire", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138C6 RID: 80070 RVA: 0x00859B25 File Offset: 0x00857D25
		public static VersionInfo DDNKHCCMEKJ()
		{
			return new VersionInfo(0, 1, 0);
		}

		// Token: 0x060138C7 RID: 80071 RVA: 0x00859B2F File Offset: 0x00857D2F
		public int CHOANEJEKAI()
		{
			return this.m_major * -100 + this.m_minor * -24 + this.m_release;
		}

		// Token: 0x060138C8 RID: 80072 RVA: 0x00859B4B File Offset: 0x00857D4B
		public static string BIAJGFANIJM()
		{
			return string.Format("IdleStand", 1, 4, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138C9 RID: 80073 RVA: 0x00859B78 File Offset: 0x00857D78
		public int PFBALHOJJLO()
		{
			return this.m_major * 42 + this.m_minor * -69 + this.m_release;
		}

		// Token: 0x060138CB RID: 80075 RVA: 0x00859BAA File Offset: 0x00857DAA
		public int DFDNIADKKEP()
		{
			return this.m_major * -8 + this.m_minor * -49 + this.m_release;
		}

		// Token: 0x060138CC RID: 80076 RVA: 0x00859BC6 File Offset: 0x00857DC6
		public static string CNNNFADEGCD()
		{
			return string.Format("_ContrastGainGamma", 0, 5, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138CD RID: 80077 RVA: 0x00859BF3 File Offset: 0x00857DF3
		public static bool PKOIJONFDNP(VersionInfo LEFPMHIHJCF)
		{
			return 0 != LEFPMHIHJCF.m_major || 0 != LEFPMHIHJCF.m_minor || 1 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138CE RID: 80078 RVA: 0x00859C12 File Offset: 0x00857E12
		public static string BLGCGCBAIAF()
		{
			return string.Format("Low adminlevel!", 0, 0, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138CF RID: 80079 RVA: 0x00859C3F File Offset: 0x00857E3F
		public int AJCOAEPEOEO()
		{
			return this.m_major * 92 + this.m_minor * 109 + this.m_release;
		}

		// Token: 0x060138D0 RID: 80080 RVA: 0x00859C5B File Offset: 0x00857E5B
		public static string EJGCMBCEJCH()
		{
			return string.Format(" ♦ ", 0, 3, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138D1 RID: 80081 RVA: 0x00859C88 File Offset: 0x00857E88
		private VersionInfo()
		{
			this.m_major = 1;
			this.m_minor = 5;
			this.m_release = 1;
		}

		// Token: 0x060138D2 RID: 80082 RVA: 0x00859CA5 File Offset: 0x00857EA5
		public static VersionInfo FHALGDJPMCI()
		{
			return new VersionInfo(1, 1, 0);
		}

		// Token: 0x060138D3 RID: 80083 RVA: 0x00859CAF File Offset: 0x00857EAF
		public int BIKMFKIFJKA()
		{
			return this.m_major * -54 + this.m_minor * -24 + this.m_release;
		}

		// Token: 0x060138D4 RID: 80084 RVA: 0x00859CCB File Offset: 0x00857ECB
		public static bool HBHMBMHBAHG(VersionInfo LEFPMHIHJCF)
		{
			return 0 == LEFPMHIHJCF.m_major && 7 == LEFPMHIHJCF.m_minor && 0 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138D5 RID: 80085 RVA: 0x00859CEA File Offset: 0x00857EEA
		public virtual string AOJIJIPBKPB()
		{
			return string.Format("kill", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138D6 RID: 80086 RVA: 0x00859D26 File Offset: 0x00857F26
		public static VersionInfo BDIIGLEOCJA()
		{
			return new VersionInfo(1, 8, 1);
		}

		// Token: 0x060138D7 RID: 80087 RVA: 0x00859D30 File Offset: 0x00857F30
		public static bool FHOOJLHAJFF(VersionInfo LEFPMHIHJCF)
		{
			return 0 == LEFPMHIHJCF.m_major && 3 == LEFPMHIHJCF.m_minor && 1 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138D8 RID: 80088 RVA: 0x00859D4F File Offset: 0x00857F4F
		public static VersionInfo LKCENBLCKBG()
		{
			return new VersionInfo(0, 7, 1);
		}

		// Token: 0x060138D9 RID: 80089 RVA: 0x00859D59 File Offset: 0x00857F59
		public virtual string GMLGLOOIEAA()
		{
			return string.Format("<color='#003000'>{0} на {1}</color>", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138DA RID: 80090 RVA: 0x00859D95 File Offset: 0x00857F95
		public virtual string MIHCFECAIAD()
		{
			return string.Format("wpn_eat7", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138DB RID: 80091 RVA: 0x00859DD1 File Offset: 0x00857FD1
		public static bool LBDJCAAACAP(VersionInfo LEFPMHIHJCF)
		{
			return 0 == LEFPMHIHJCF.m_major && 1 == LEFPMHIHJCF.m_minor && 0 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138DC RID: 80092 RVA: 0x00859DF0 File Offset: 0x00857FF0
		public static VersionInfo CJEKAAKMFMH()
		{
			return new VersionInfo(0, 0, 0);
		}

		// Token: 0x060138DD RID: 80093 RVA: 0x00859DFA File Offset: 0x00857FFA
		public virtual string MJODNMLNFJC()
		{
			return string.Format("RollerBladeFrontFlip", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138DE RID: 80094 RVA: 0x00859E36 File Offset: 0x00858036
		public int FIHCGDPBLHO()
		{
			return this.m_major * -88 + this.m_minor * 37 + this.m_release;
		}

		// Token: 0x060138DF RID: 80095 RVA: 0x00859E52 File Offset: 0x00858052
		public static string JLAFAOAHKPJ()
		{
			return string.Format("SPECIAL", 1, 8, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138E0 RID: 80096 RVA: 0x00859D4F File Offset: 0x00857F4F
		public static VersionInfo CFGHOLPFDJJ()
		{
			return new VersionInfo(0, 7, 1);
		}

		// Token: 0x060138E1 RID: 80097 RVA: 0x00859D26 File Offset: 0x00857F26
		public static VersionInfo OAJGDHEILFI()
		{
			return new VersionInfo(1, 8, 1);
		}

		// Token: 0x060138E2 RID: 80098 RVA: 0x00859E7F File Offset: 0x0085807F
		public virtual string EAGIBIOFDBJ()
		{
			return string.Format("bs_nodonate", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138E3 RID: 80099 RVA: 0x00859EBB File Offset: 0x008580BB
		public static VersionInfo BHOJFCNIPMO()
		{
			return new VersionInfo(0, 4, 1);
		}

		// Token: 0x060138E4 RID: 80100 RVA: 0x00858FD5 File Offset: 0x008571D5
		public static VersionInfo KPAIBACLIAD()
		{
			return new VersionInfo(0, 4, 0);
		}

		// Token: 0x060138E5 RID: 80101 RVA: 0x00859EC5 File Offset: 0x008580C5
		public static string OPCAJNKACPN()
		{
			return string.Format("paper.wav", 0, 5, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138E6 RID: 80102 RVA: 0x00859EF2 File Offset: 0x008580F2
		public int OMCGONDCPBN()
		{
			return this.m_major * -73 + this.m_minor * 47 + this.m_release;
		}

		// Token: 0x060138E7 RID: 80103 RVA: 0x00859F0E File Offset: 0x0085810E
		public static bool ICJBGKCJOBE(VersionInfo LEFPMHIHJCF)
		{
			return 1 != LEFPMHIHJCF.m_major || 7 != LEFPMHIHJCF.m_minor || 1 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138E8 RID: 80104 RVA: 0x00859F2D File Offset: 0x0085812D
		public static VersionInfo GOFNLOEPLNN()
		{
			return new VersionInfo(0, 3, 1);
		}

		// Token: 0x060138E9 RID: 80105 RVA: 0x00859F37 File Offset: 0x00858137
		public virtual string ALAAOKOIJNG()
		{
			return string.Format("<color='#300030'>{0}</color>", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138EA RID: 80106 RVA: 0x00859F73 File Offset: 0x00858173
		public virtual string FEIJPDKNKKG()
		{
			return string.Format("_DepthCurveLut", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138EB RID: 80107 RVA: 0x00859FAF File Offset: 0x008581AF
		public static bool LLEDEJGGPEG(VersionInfo LEFPMHIHJCF)
		{
			return 0 != LEFPMHIHJCF.m_major || 0 != LEFPMHIHJCF.m_minor || 0 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138EC RID: 80108 RVA: 0x00859FCE File Offset: 0x008581CE
		public static bool NAGLHGPCIDM(VersionInfo LEFPMHIHJCF)
		{
			return 1 != LEFPMHIHJCF.m_major || 5 != LEFPMHIHJCF.m_minor || 1 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138ED RID: 80109 RVA: 0x00859FED File Offset: 0x008581ED
		public static VersionInfo KPALEBEAJEA()
		{
			return new VersionInfo(1, 1, 1);
		}

		// Token: 0x060138EE RID: 80110 RVA: 0x00859FF7 File Offset: 0x008581F7
		public static bool KNPOPFFJGFE(VersionInfo LEFPMHIHJCF)
		{
			return 0 == LEFPMHIHJCF.m_major && 6 == LEFPMHIHJCF.m_minor && 1 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138EF RID: 80111 RVA: 0x00859647 File Offset: 0x00857847
		public static VersionInfo OCBOEOECABP()
		{
			return new VersionInfo(0, 5, 0);
		}

		// Token: 0x060138F0 RID: 80112 RVA: 0x0085A016 File Offset: 0x00858216
		public static string BGONCCKCEBC()
		{
			return string.Format("{not_found}", 1, 7, 1) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138F1 RID: 80113 RVA: 0x008594A2 File Offset: 0x008576A2
		public static bool OAADPMCKGOI(VersionInfo LEFPMHIHJCF)
		{
			return 0 != LEFPMHIHJCF.m_major || 5 != LEFPMHIHJCF.m_minor || 0 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x060138F2 RID: 80114 RVA: 0x0085A043 File Offset: 0x00858243
		public int JPIPGPAOCGD()
		{
			return this.m_major * 56 + this.m_minor * 7 + this.m_release;
		}

		// Token: 0x060138F3 RID: 80115 RVA: 0x0085A05F File Offset: 0x0085825F
		public static string POEMDEDBEKE()
		{
			return string.Format("Current fog preset: ", 0, 3, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138F4 RID: 80116 RVA: 0x0085A08C File Offset: 0x0085828C
		public static string MNCNHAIMPGJ()
		{
			return string.Format("teech_perk", 0, 3, 0) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138F5 RID: 80117 RVA: 0x0085A0B9 File Offset: 0x008582B9
		public virtual string DGOBKBBGGKN()
		{
			return string.Format("WalkInjured", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138F6 RID: 80118 RVA: 0x0085A0F5 File Offset: 0x008582F5
		public virtual string OKEAOIBHKIN()
		{
			return string.Format("OnGround", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138F7 RID: 80119 RVA: 0x0085A131 File Offset: 0x00858331
		public int IDLOOHILFDF()
		{
			return this.m_major * 9 + this.m_minor * 24 + this.m_release;
		}

		// Token: 0x060138F8 RID: 80120 RVA: 0x0085A14D File Offset: 0x0085834D
		public int MONKJLKDNJA()
		{
			return this.m_major * -15 + this.m_minor * 66 + this.m_release;
		}

		// Token: 0x060138F9 RID: 80121 RVA: 0x0085A169 File Offset: 0x00858369
		public virtual string FBENMKABKKB()
		{
			return string.Format("Null", this.m_major, this.m_minor, this.m_release) + VersionInfo.StageSuffix + VersionInfo.TrialSuffix;
		}

		// Token: 0x060138FA RID: 80122 RVA: 0x008596C9 File Offset: 0x008578C9
		public static bool NKFHGKBDEFE(VersionInfo LEFPMHIHJCF)
		{
			return 0 != LEFPMHIHJCF.m_major || 8 != LEFPMHIHJCF.m_minor || 1 == LEFPMHIHJCF.m_release;
		}

		// Token: 0x040027FB RID: 10235
		public const byte Major = 1;

		// Token: 0x040027FC RID: 10236
		public const byte Minor = 5;

		// Token: 0x040027FD RID: 10237
		public const byte Release = 1;

		// Token: 0x040027FE RID: 10238
		private static string StageSuffix = "_dev007";

		// Token: 0x040027FF RID: 10239
		private static string TrialSuffix = "";

		// Token: 0x04002800 RID: 10240
		[SerializeField]
		private int m_major;

		// Token: 0x04002801 RID: 10241
		[SerializeField]
		private int m_minor;

		// Token: 0x04002802 RID: 10242
		[SerializeField]
		private int m_release;
	}
}
