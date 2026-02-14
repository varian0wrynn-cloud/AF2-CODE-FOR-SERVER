using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x02000599 RID: 1433
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Obscured Cheating Detector")]
	public class ObscuredCheatingDetector : ActDetectorBase
	{
		// Token: 0x06012DB2 RID: 77234 RVA: 0x008216D1 File Offset: 0x0081F8D1
		protected virtual void BOGMAOKBBDL()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012DB3 RID: 77235 RVA: 0x008216F1 File Offset: 0x0081F8F1
		private static void MCBCDOCEAAA(ObscuredCheatingDetector DCCPCBLODIG)
		{
			ObscuredCheatingDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012DB4 RID: 77236 RVA: 0x008216F9 File Offset: 0x0081F8F9
		private void PAEJDFOKLEO()
		{
			if (ObscuredCheatingDetector.MHEKHLHNDMK < 1)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && ObscuredCheatingDetector.GGOEIHCJEHP() != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012DB5 RID: 77237 RVA: 0x0082172D File Offset: 0x0081F92D
		protected virtual void BEOLGNLCLIP()
		{
			base.LPDEBEBJDJF();
			if (ObscuredCheatingDetector.BLJNHIFIBDC() == this)
			{
				ObscuredCheatingDetector.MFOGCEDFEPO(null);
			}
		}

		// Token: 0x06012DB6 RID: 77238 RVA: 0x00821748 File Offset: 0x0081F948
		public static void FAJLIELKCOC(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.IMLHECPNCMP().FDPLOLOAPCO(DFJFCOKENIA);
		}

		// Token: 0x06012DB7 RID: 77239 RVA: 0x00821758 File Offset: 0x0081F958
		private static ObscuredCheatingDetector IMLHECPNCMP()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				return ObscuredCheatingDetector.LNANLECJDDA();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("_MaxSteps");
			}
			ObscuredCheatingDetector.ELOBJGIDGCP = ActDetectorBase.ACFEJFHNHPH.AddComponent<ObscuredCheatingDetector>();
			return ObscuredCheatingDetector.ELOBJGIDGCP;
		}

		// Token: 0x06012DB8 RID: 77240 RVA: 0x008217A8 File Offset: 0x0081F9A8
		protected virtual void CNIABHBLBCG()
		{
			base.OnDestroy();
			ObscuredCheatingDetector.MHEKHLHNDMK--;
		}

		// Token: 0x06012DB9 RID: 77241 RVA: 0x008217BC File Offset: 0x0081F9BC
		private void DKEEFLHGKGD(UnityAction DFJFCOKENIA)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("RollerBladeBackFlip", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("ArmFlex4", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("Internal LUT", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("+ ", this);
				base.enabled = false;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012DBA RID: 77242 RVA: 0x0082183C File Offset: 0x0081FA3C
		private void MNNOLBPHDAI(UnityAction DFJFCOKENIA)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("Identity LUT", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("code=", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("Invalid ObscuredVector2 index!", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("paper.wav", this);
				base.enabled = true;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012DBB RID: 77243 RVA: 0x008218BA File Offset: 0x0081FABA
		private void NJKHAJHNHII()
		{
			if (ObscuredCheatingDetector.MHEKHLHNDMK < 2)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && ObscuredCheatingDetector.ELOBJGIDGCP != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012DBC RID: 77244 RVA: 0x008218F0 File Offset: 0x0081FAF0
		private static ObscuredCheatingDetector KOGGFPOCIBG()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				return ObscuredCheatingDetector.LNANLECJDDA();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("---");
			}
			ObscuredCheatingDetector.HDMGPLNGPPG(ActDetectorBase.ACFEJFHNHPH.AddComponent<ObscuredCheatingDetector>());
			return ObscuredCheatingDetector.BLJNHIFIBDC();
		}

		// Token: 0x06012DBD RID: 77245 RVA: 0x008216F1 File Offset: 0x0081F8F1
		private static void OEADKLJGJLL(ObscuredCheatingDetector DCCPCBLODIG)
		{
			ObscuredCheatingDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012DBE RID: 77246 RVA: 0x008216F1 File Offset: 0x0081F8F1
		private static void MKFFHJHFGGE(ObscuredCheatingDetector DCCPCBLODIG)
		{
			ObscuredCheatingDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012DBF RID: 77247 RVA: 0x00821940 File Offset: 0x0081FB40
		public static void MICGBLFDPFL(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.NDALLNGCBIH().FDPLOLOAPCO(DFJFCOKENIA);
		}

		// Token: 0x06012DC0 RID: 77248 RVA: 0x0082194D File Offset: 0x0081FB4D
		internal static bool IHLFNHKJJGN()
		{
			return ObscuredCheatingDetector.GGOEIHCJEHP() == null || ObscuredCheatingDetector.ELOBJGIDGCP.OIOJMFCCDLH;
		}

		// Token: 0x06012DC1 RID: 77249 RVA: 0x00821962 File Offset: 0x0081FB62
		public static void LLBAPMJHNNG(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.KAHBJOJOFEJ().KGMFKGPBHGK(DFJFCOKENIA);
		}

		// Token: 0x06012DC2 RID: 77250 RVA: 0x0082196F File Offset: 0x0081FB6F
		public static void CHEIFOKDIBI(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.NDALLNGCBIH().MCKMHMINODD(DFJFCOKENIA);
		}

		// Token: 0x06012DC3 RID: 77251 RVA: 0x0082197C File Offset: 0x0081FB7C
		public static ObscuredCheatingDetector LNANLECJDDA()
		{
			return ObscuredCheatingDetector.<AFOLCKEELEK>k__BackingField;
		}

		// Token: 0x06012DC4 RID: 77252 RVA: 0x00821983 File Offset: 0x0081FB83
		public static void FGMNJBHEEML()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012DC5 RID: 77253 RVA: 0x0082199C File Offset: 0x0081FB9C
		public static void NKPCBNBHFKF()
		{
			if (ObscuredCheatingDetector.BLJNHIFIBDC() != null)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().MNNOLBPHDAI(null);
				return;
			}
			Debug.LogError("<color='#100000'>{0} {1}</color>");
		}

		// Token: 0x06012DC6 RID: 77254 RVA: 0x008219C1 File Offset: 0x0081FBC1
		private ObscuredCheatingDetector()
		{
		}

		// Token: 0x06012DC7 RID: 77255 RVA: 0x008219F8 File Offset: 0x0081FBF8
		private static ObscuredCheatingDetector EKPPIJJGNBE()
		{
			if (ObscuredCheatingDetector.BLJNHIFIBDC() != null)
			{
				return ObscuredCheatingDetector.ELOBJGIDGCP;
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("cht_msg20");
			}
			ObscuredCheatingDetector.MCBCDOCEAAA(ActDetectorBase.ACFEJFHNHPH.AddComponent<ObscuredCheatingDetector>());
			return ObscuredCheatingDetector.LNANLECJDDA();
		}

		// Token: 0x06012DC8 RID: 77256 RVA: 0x00821A48 File Offset: 0x0081FC48
		private static ObscuredCheatingDetector NDALLNGCBIH()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				return ObscuredCheatingDetector.GGOEIHCJEHP();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject(" ");
			}
			ObscuredCheatingDetector.MKFFHJHFGGE(ActDetectorBase.ACFEJFHNHPH.AddComponent<ObscuredCheatingDetector>());
			return ObscuredCheatingDetector.BLJNHIFIBDC();
		}

		// Token: 0x06012DC9 RID: 77257 RVA: 0x00821A98 File Offset: 0x0081FC98
		private void GIBJHJBCHOO(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.NJKHAJHNHII();
		}

		// Token: 0x06012DCA RID: 77258 RVA: 0x00821AA0 File Offset: 0x0081FCA0
		private void ECOOMJKPKCC()
		{
			ObscuredCheatingDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(ObscuredCheatingDetector.ELOBJGIDGCP, "IdleFight"))
			{
				ObscuredCheatingDetector.HDMGPLNGPPG(this);
			}
			SceneManager.sceneLoaded += this.AHOMPDJLIBD;
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06012DCB RID: 77259 RVA: 0x00821AD7 File Offset: 0x0081FCD7
		internal static bool GOGDGKDDIPG
		{
			get
			{
				return ObscuredCheatingDetector.ELOBJGIDGCP != null && ObscuredCheatingDetector.ELOBJGIDGCP.OIOJMFCCDLH;
			}
		}

		// Token: 0x06012DCC RID: 77260 RVA: 0x00821AEC File Offset: 0x0081FCEC
		protected override void LPDEBEBJDJF()
		{
			base.LPDEBEBJDJF();
			if (ObscuredCheatingDetector.ELOBJGIDGCP == this)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP = null;
			}
		}

		// Token: 0x06012DCD RID: 77261 RVA: 0x00821B07 File Offset: 0x0081FD07
		public static void KAALIGKIFFJ(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.NDALLNGCBIH().MNNOLBPHDAI(DFJFCOKENIA);
		}

		// Token: 0x06012DCE RID: 77262 RVA: 0x00821B14 File Offset: 0x0081FD14
		private void AHOMPDJLIBD(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.DFENCOKFFPH();
		}

		// Token: 0x06012DCF RID: 77263 RVA: 0x00821B1C File Offset: 0x0081FD1C
		protected virtual void HIBCONLGNPL()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012DD0 RID: 77264 RVA: 0x00821B36 File Offset: 0x0081FD36
		protected virtual void JAENOIIOMJA()
		{
			this.ENNIJCJBBNN(null);
		}

		// Token: 0x06012DD1 RID: 77265 RVA: 0x008216F1 File Offset: 0x0081F8F1
		private static void EMFAMHMCKNM(ObscuredCheatingDetector DCCPCBLODIG)
		{
			ObscuredCheatingDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012DD2 RID: 77266 RVA: 0x00821B40 File Offset: 0x0081FD40
		private static ObscuredCheatingDetector PNCMENECCNP()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				return ObscuredCheatingDetector.ELOBJGIDGCP;
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject(".ogg");
			}
			ObscuredCheatingDetector.ELOBJGIDGCP = ActDetectorBase.ACFEJFHNHPH.AddComponent<ObscuredCheatingDetector>();
			return ObscuredCheatingDetector.GGOEIHCJEHP();
		}

		// Token: 0x06012DD3 RID: 77267 RVA: 0x0082197C File Offset: 0x0081FB7C
		public static ObscuredCheatingDetector BLJNHIFIBDC()
		{
			return ObscuredCheatingDetector.<AFOLCKEELEK>k__BackingField;
		}

		// Token: 0x06012DD4 RID: 77268 RVA: 0x00821B90 File Offset: 0x0081FD90
		private void FMNLGOCNBIP(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.LDBCEIPHILL();
		}

		// Token: 0x06012DD5 RID: 77269 RVA: 0x00821B98 File Offset: 0x0081FD98
		protected virtual void PEGLBMGDMIP()
		{
			base.OnDestroy();
			ObscuredCheatingDetector.MHEKHLHNDMK -= 0;
		}

		// Token: 0x06012DD6 RID: 77270 RVA: 0x00821BAC File Offset: 0x0081FDAC
		private void ENNIJCJBBNN(UnityAction DFJFCOKENIA)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("short:", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("reel_type1", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("#url Sound ", this);
				base.enabled = false;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012DD7 RID: 77271 RVA: 0x008216D1 File Offset: 0x0081F8D1
		protected virtual void OLIONJFJNEA()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012DD8 RID: 77272 RVA: 0x00821C2C File Offset: 0x0081FE2C
		private void KGMFKGPBHGK(UnityAction DFJFCOKENIA)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("_DistanceParams", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("\">Detected: ", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("SoccerSprint", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("wpn_rec3", this);
				base.enabled = true;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012DD9 RID: 77273 RVA: 0x00821CAA File Offset: 0x0081FEAA
		private void DMCOCNPIHCG()
		{
			ObscuredCheatingDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(ObscuredCheatingDetector.BLJNHIFIBDC(), "isDrop action"))
			{
				ObscuredCheatingDetector.CNNEJFKFGBE(this);
			}
			SceneManager.sceneLoaded += this.PCHEBHDIAPP;
		}

		// Token: 0x06012DDA RID: 77274 RVA: 0x00821CE1 File Offset: 0x0081FEE1
		private void BPPMBDAOHBP(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.HIPNMJEMLHH();
		}

		// Token: 0x06012DDB RID: 77275 RVA: 0x008216F1 File Offset: 0x0081F8F1
		private static void HDMGPLNGPPG(ObscuredCheatingDetector DCCPCBLODIG)
		{
			ObscuredCheatingDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012DDC RID: 77276 RVA: 0x00821CE9 File Offset: 0x0081FEE9
		protected virtual void NLPIKJDEFML()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012DDD RID: 77277 RVA: 0x00821D09 File Offset: 0x0081FF09
		protected virtual void BANPCIDEOHG()
		{
			base.LPDEBEBJDJF();
			if (ObscuredCheatingDetector.ELOBJGIDGCP == this)
			{
				ObscuredCheatingDetector.MCBCDOCEAAA(null);
			}
		}

		// Token: 0x06012DDE RID: 77278 RVA: 0x00821D24 File Offset: 0x0081FF24
		protected override void GKKIAKCDDGN()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012DDF RID: 77279 RVA: 0x00821CE9 File Offset: 0x0081FEE9
		protected virtual void CNJBFCPKIDN()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012DE0 RID: 77280 RVA: 0x00821D44 File Offset: 0x0081FF44
		public static void HCPLBIEOKHK(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.OONGBDDPMEP().KGMFKGPBHGK(DFJFCOKENIA);
		}

		// Token: 0x06012DE1 RID: 77281 RVA: 0x00821D51 File Offset: 0x0081FF51
		private void JIGAFDHOFKL()
		{
			ObscuredCheatingDetector.MHEKHLHNDMK += 0;
			if (this.PINLMCCKKNA(ObscuredCheatingDetector.ELOBJGIDGCP, "_InvScreenSize"))
			{
				ObscuredCheatingDetector.HDMGPLNGPPG(this);
			}
			SceneManager.sceneLoaded += this.CHLCGEGALDP;
		}

		// Token: 0x06012DE2 RID: 77282 RVA: 0x00821D88 File Offset: 0x0081FF88
		protected virtual void AGAMBFPNCPF()
		{
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012DE3 RID: 77283 RVA: 0x00821D91 File Offset: 0x0081FF91
		public static void CNDANKOANCM()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				ObscuredCheatingDetector.LNANLECJDDA().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012DE4 RID: 77284 RVA: 0x00821DAA File Offset: 0x0081FFAA
		protected virtual void JIFPKDPANJA()
		{
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012DE5 RID: 77285 RVA: 0x00821D24 File Offset: 0x0081FF24
		protected virtual void FBOOACNONEI()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012DE6 RID: 77286 RVA: 0x00821B1C File Offset: 0x0081FD1C
		protected virtual void ILFHIMBKOKC()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012DE7 RID: 77287 RVA: 0x00821DB3 File Offset: 0x0081FFB3
		private void PHONLBCOJEG()
		{
			ObscuredCheatingDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(ObscuredCheatingDetector.GGOEIHCJEHP(), "qd_prise_titul"))
			{
				ObscuredCheatingDetector.EMFAMHMCKNM(this);
			}
			SceneManager.sceneLoaded += this.ANDPEOHJNHC;
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06012DE8 RID: 77288 RVA: 0x0082197C File Offset: 0x0081FB7C
		// (set) Token: 0x06012E0F RID: 77327 RVA: 0x008216F1 File Offset: 0x0081F8F1
		public static ObscuredCheatingDetector ELOBJGIDGCP { get; private set; }

		// Token: 0x06012DE9 RID: 77289 RVA: 0x00821D24 File Offset: 0x0081FF24
		protected virtual void CJOECHHKFKO()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012DEA RID: 77290 RVA: 0x00821DEA File Offset: 0x0081FFEA
		protected virtual void JFDEHOIIDBJ()
		{
			base.LPDEBEBJDJF();
			if (ObscuredCheatingDetector.LNANLECJDDA() == this)
			{
				ObscuredCheatingDetector.EPGLBMLPIHC(null);
			}
		}

		// Token: 0x06012DEB RID: 77291 RVA: 0x00821D44 File Offset: 0x0081FF44
		public static void EKDAENNADCK(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.OONGBDDPMEP().KGMFKGPBHGK(DFJFCOKENIA);
		}

		// Token: 0x06012DEC RID: 77292 RVA: 0x00821B98 File Offset: 0x0081FD98
		protected virtual void CLMGECFFLPO()
		{
			base.OnDestroy();
			ObscuredCheatingDetector.MHEKHLHNDMK -= 0;
		}

		// Token: 0x06012DED RID: 77293 RVA: 0x00821E05 File Offset: 0x00820005
		private void HIPNMJEMLHH()
		{
			if (ObscuredCheatingDetector.MHEKHLHNDMK < 8)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && ObscuredCheatingDetector.GGOEIHCJEHP() != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012DEE RID: 77294 RVA: 0x00821E39 File Offset: 0x00820039
		public static void MFOIBMCHDIE()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				ObscuredCheatingDetector.LNANLECJDDA().ENNIJCJBBNN(null);
				return;
			}
			Debug.LogError("inv_nodur");
		}

		// Token: 0x06012DEF RID: 77295 RVA: 0x00821E5E File Offset: 0x0082005E
		public static void IAGLGAEGLGO()
		{
			if (ObscuredCheatingDetector.BLJNHIFIBDC() != null)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012DF0 RID: 77296 RVA: 0x00821E78 File Offset: 0x00820078
		private static ObscuredCheatingDetector IBIBADBDEPD()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				return ObscuredCheatingDetector.LNANLECJDDA();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("ApplePick");
			}
			ObscuredCheatingDetector.MFOGCEDFEPO(ActDetectorBase.ACFEJFHNHPH.AddComponent<ObscuredCheatingDetector>());
			return ObscuredCheatingDetector.LNANLECJDDA();
		}

		// Token: 0x06012DF1 RID: 77297 RVA: 0x00821CE1 File Offset: 0x0081FEE1
		private void PBAOLONBMDO(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.HIPNMJEMLHH();
		}

		// Token: 0x06012DF2 RID: 77298 RVA: 0x008216F1 File Offset: 0x0081F8F1
		private static void MFOGCEDFEPO(ObscuredCheatingDetector DCCPCBLODIG)
		{
			ObscuredCheatingDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012DF3 RID: 77299 RVA: 0x00821EC8 File Offset: 0x008200C8
		private void DFENCOKFFPH()
		{
			if (ObscuredCheatingDetector.MHEKHLHNDMK < 6)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && ObscuredCheatingDetector.LNANLECJDDA() != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012DF4 RID: 77300 RVA: 0x00821EFC File Offset: 0x008200FC
		private static ObscuredCheatingDetector KAHBJOJOFEJ()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				return ObscuredCheatingDetector.LNANLECJDDA();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("wpn_lvf");
			}
			ObscuredCheatingDetector.OEADKLJGJLL(ActDetectorBase.ACFEJFHNHPH.AddComponent<ObscuredCheatingDetector>());
			return ObscuredCheatingDetector.BLJNHIFIBDC();
		}

		// Token: 0x06012DF5 RID: 77301 RVA: 0x00821F4C File Offset: 0x0082014C
		public static void AIJDLFIPBCB()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.GKKIAKCDDGN();
			}
		}

		// Token: 0x06012DF6 RID: 77302 RVA: 0x00821DAA File Offset: 0x0081FFAA
		protected override void FHMIHHDHAAF()
		{
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012DF7 RID: 77303 RVA: 0x00821F65 File Offset: 0x00820165
		protected virtual void PFAOPAHBLHP()
		{
			this.MNNOLBPHDAI(null);
		}

		// Token: 0x06012DF8 RID: 77304 RVA: 0x00821F6E File Offset: 0x0082016E
		internal static bool DDNJPGNOAKP()
		{
			return ObscuredCheatingDetector.BLJNHIFIBDC() != null && ObscuredCheatingDetector.ELOBJGIDGCP.OIOJMFCCDLH;
		}

		// Token: 0x06012DF9 RID: 77305 RVA: 0x00821F83 File Offset: 0x00820183
		protected virtual void KIFKBBKIOEG()
		{
			this.DKEEFLHGKGD(null);
		}

		// Token: 0x06012DFA RID: 77306 RVA: 0x00821F8C File Offset: 0x0082018C
		protected override void KBIADJEBIDO()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012DFB RID: 77307 RVA: 0x0082197C File Offset: 0x0081FB7C
		public static ObscuredCheatingDetector GGOEIHCJEHP()
		{
			return ObscuredCheatingDetector.<AFOLCKEELEK>k__BackingField;
		}

		// Token: 0x06012DFC RID: 77308 RVA: 0x00821FA6 File Offset: 0x008201A6
		protected virtual void OMHPFJCLHPJ()
		{
			base.LPDEBEBJDJF();
			if (ObscuredCheatingDetector.LNANLECJDDA() == this)
			{
				ObscuredCheatingDetector.MCBCDOCEAAA(null);
			}
		}

		// Token: 0x06012DFD RID: 77309 RVA: 0x00821FC1 File Offset: 0x008201C1
		public static void NBPJKONEAFO()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012DFE RID: 77310 RVA: 0x00821FDA File Offset: 0x008201DA
		public static void ANIKOFKKIOG()
		{
			if (ObscuredCheatingDetector.BLJNHIFIBDC() != null)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.GKKIAKCDDGN();
			}
		}

		// Token: 0x06012DFF RID: 77311 RVA: 0x00821FF3 File Offset: 0x008201F3
		private void BHMKAOBHAII()
		{
			ObscuredCheatingDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(ObscuredCheatingDetector.GGOEIHCJEHP(), ")"))
			{
				ObscuredCheatingDetector.EMFAMHMCKNM(this);
			}
			SceneManager.sceneLoaded += this.GIBJHJBCHOO;
		}

		// Token: 0x06012E00 RID: 77312 RVA: 0x0082202C File Offset: 0x0082022C
		private static ObscuredCheatingDetector OONGBDDPMEP()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				return ObscuredCheatingDetector.LNANLECJDDA();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("SUNSHINE_OVERCAST_OFF");
			}
			ObscuredCheatingDetector.CNNEJFKFGBE(ActDetectorBase.ACFEJFHNHPH.AddComponent<ObscuredCheatingDetector>());
			return ObscuredCheatingDetector.BLJNHIFIBDC();
		}

		// Token: 0x06012E01 RID: 77313 RVA: 0x0082207C File Offset: 0x0082027C
		public static void IOHHJBJBEMB(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.IBIBADBDEPD().KGMFKGPBHGK(DFJFCOKENIA);
		}

		// Token: 0x06012E02 RID: 77314 RVA: 0x00822089 File Offset: 0x00820289
		public static void DLGJEKDDFEO()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().FDPLOLOAPCO(null);
				return;
			}
			Debug.LogError("_Parameter");
		}

		// Token: 0x06012E03 RID: 77315 RVA: 0x008220AE File Offset: 0x008202AE
		protected override void MDFJEOGCPHB()
		{
			this.MCKMHMINODD(null);
		}

		// Token: 0x06012E04 RID: 77316 RVA: 0x008220B8 File Offset: 0x008202B8
		private void MCKMHMINODD(UnityAction DFJFCOKENIA)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("[ACTk] Obscured Cheating Detector: already running!", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("[ACTk] Obscured Cheating Detector: disabled but StartDetection still called from somewhere (see stack trace for this message)!", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning("[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("[ACTk] Obscured Cheating Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method.", this);
				base.enabled = false;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E05 RID: 77317 RVA: 0x00822136 File Offset: 0x00820336
		private void CFNLKNOKAGC()
		{
			ObscuredCheatingDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(ObscuredCheatingDetector.BLJNHIFIBDC(), "MotorbikeLasso"))
			{
				ObscuredCheatingDetector.MFOGCEDFEPO(this);
			}
			SceneManager.sceneLoaded += this.FMNLGOCNBIP;
		}

		// Token: 0x06012E06 RID: 77318 RVA: 0x0082216D File Offset: 0x0082036D
		private void Awake()
		{
			ObscuredCheatingDetector.MHEKHLHNDMK++;
			if (this.PINLMCCKKNA(ObscuredCheatingDetector.ELOBJGIDGCP, "Obscured Cheating Detector"))
			{
				ObscuredCheatingDetector.ELOBJGIDGCP = this;
			}
			SceneManager.sceneLoaded += this.GIBJHJBCHOO;
		}

		// Token: 0x06012E07 RID: 77319 RVA: 0x00821B1C File Offset: 0x0081FD1C
		protected virtual void ALOFGPFHDOP()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E08 RID: 77320 RVA: 0x008221A4 File Offset: 0x008203A4
		public static void FMEMNPPFGOA()
		{
			if (ObscuredCheatingDetector.BLJNHIFIBDC() != null)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E09 RID: 77321 RVA: 0x00821CE9 File Offset: 0x0081FEE9
		protected virtual void NOEBKFKMLLA()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E0A RID: 77322 RVA: 0x008221BD File Offset: 0x008203BD
		public static void LKKJHOKIIHC()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E0B RID: 77323 RVA: 0x00821CE1 File Offset: 0x0081FEE1
		private void PCHEBHDIAPP(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.HIPNMJEMLHH();
		}

		// Token: 0x06012E0C RID: 77324 RVA: 0x008221D6 File Offset: 0x008203D6
		private void NGGPJMHBJHE(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.ALJBFJGNCLD();
		}

		// Token: 0x06012E0D RID: 77325 RVA: 0x00821B98 File Offset: 0x0081FD98
		protected virtual void PKPGIGEEEJI()
		{
			base.OnDestroy();
			ObscuredCheatingDetector.MHEKHLHNDMK -= 0;
		}

		// Token: 0x06012E0E RID: 77326 RVA: 0x008217A8 File Offset: 0x0081F9A8
		protected override void OnDestroy()
		{
			base.OnDestroy();
			ObscuredCheatingDetector.MHEKHLHNDMK--;
		}

		// Token: 0x06012E10 RID: 77328 RVA: 0x008221DE File Offset: 0x008203DE
		internal static bool GKEOAPJKKOH()
		{
			return ObscuredCheatingDetector.ELOBJGIDGCP == null || ObscuredCheatingDetector.BLJNHIFIBDC().OIOJMFCCDLH;
		}

		// Token: 0x06012E11 RID: 77329 RVA: 0x008221F3 File Offset: 0x008203F3
		protected virtual void MBCDLNEEEBJ()
		{
			this.FDPLOLOAPCO(null);
		}

		// Token: 0x06012E12 RID: 77330 RVA: 0x008221FC File Offset: 0x008203FC
		public static void CNDBEBCJKKB(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.IMLHECPNCMP().DKEEFLHGKGD(DFJFCOKENIA);
		}

		// Token: 0x06012E13 RID: 77331 RVA: 0x00822209 File Offset: 0x00820409
		public static void StartDetection()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.MCKMHMINODD(null);
				return;
			}
			Debug.LogError("[ACTk] Obscured Cheating Detector: can't be started since it doesn't exists in scene or not yet initialized!");
		}

		// Token: 0x06012E14 RID: 77332 RVA: 0x00821FC1 File Offset: 0x008201C1
		public static void JFLEJALHEKF()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E15 RID: 77333 RVA: 0x0082222E File Offset: 0x0082042E
		public static void HCDEJDFNNIE(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.OONGBDDPMEP().MNNOLBPHDAI(DFJFCOKENIA);
		}

		// Token: 0x06012E16 RID: 77334 RVA: 0x00821B90 File Offset: 0x0081FD90
		private void ANDPEOHJNHC(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.LDBCEIPHILL();
		}

		// Token: 0x06012E17 RID: 77335 RVA: 0x0082223B File Offset: 0x0082043B
		public static void CCMKBMGMLPP(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.OONGBDDPMEP().DKEEFLHGKGD(DFJFCOKENIA);
		}

		// Token: 0x06012E18 RID: 77336 RVA: 0x00821F8C File Offset: 0x0082018C
		protected virtual void KGCBMDIOHMG()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E19 RID: 77337 RVA: 0x00822248 File Offset: 0x00820448
		private void LDBCEIPHILL()
		{
			if (ObscuredCheatingDetector.MHEKHLHNDMK < 7)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && ObscuredCheatingDetector.BLJNHIFIBDC() != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E1A RID: 77338 RVA: 0x00821D88 File Offset: 0x0081FF88
		protected virtual void KLMJBOHKMDA()
		{
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E1B RID: 77339 RVA: 0x00821FC1 File Offset: 0x008201C1
		public static void GLEPNGLJMKN()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E1C RID: 77340 RVA: 0x008216F1 File Offset: 0x0081F8F1
		private static void EPGLBMLPIHC(ObscuredCheatingDetector DCCPCBLODIG)
		{
			ObscuredCheatingDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012E1D RID: 77341 RVA: 0x00821D24 File Offset: 0x0081FF24
		protected virtual void GJJDKOLGPFF()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E1E RID: 77342 RVA: 0x0082227C File Offset: 0x0082047C
		public static void NJLHOGFNHCJ()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.LNANLECJDDA().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E1F RID: 77343 RVA: 0x00822295 File Offset: 0x00820495
		public static void HGACABJIFBL(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.IBIBADBDEPD().ENNIJCJBBNN(DFJFCOKENIA);
		}

		// Token: 0x06012E20 RID: 77344 RVA: 0x008222A2 File Offset: 0x008204A2
		internal static bool DNBHPCEAKMG()
		{
			return ObscuredCheatingDetector.GGOEIHCJEHP() == null || ObscuredCheatingDetector.GGOEIHCJEHP().OIOJMFCCDLH;
		}

		// Token: 0x06012E21 RID: 77345 RVA: 0x008222B7 File Offset: 0x008204B7
		private void OAKCEHBONIP()
		{
			ObscuredCheatingDetector.MHEKHLHNDMK += 0;
			if (this.PINLMCCKKNA(ObscuredCheatingDetector.GGOEIHCJEHP(), "FormattedLabel.GetTestText()"))
			{
				ObscuredCheatingDetector.HDMGPLNGPPG(this);
			}
			SceneManager.sceneLoaded += this.PCHEBHDIAPP;
		}

		// Token: 0x06012E22 RID: 77346 RVA: 0x008222EE File Offset: 0x008204EE
		private void IDNGLAGLOMA(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.PAEJDFOKLEO();
		}

		// Token: 0x06012E23 RID: 77347 RVA: 0x008222F6 File Offset: 0x008204F6
		public static void StopDetection()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E24 RID: 77348 RVA: 0x00821D24 File Offset: 0x0081FF24
		protected virtual void HLNMDACBNNG()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = false;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E25 RID: 77349 RVA: 0x0082230F File Offset: 0x0082050F
		private void ALJBFJGNCLD()
		{
			if (ObscuredCheatingDetector.MHEKHLHNDMK < 0)
			{
				if (!this.keepAlive)
				{
					this.LPDEBEBJDJF();
					return;
				}
			}
			else if (!this.keepAlive && ObscuredCheatingDetector.ELOBJGIDGCP != this)
			{
				this.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E26 RID: 77350 RVA: 0x00821B90 File Offset: 0x0081FD90
		private void CHLCGEGALDP(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.LDBCEIPHILL();
		}

		// Token: 0x06012E27 RID: 77351 RVA: 0x00822343 File Offset: 0x00820543
		public static void KNPHBLAMODH()
		{
			if (ObscuredCheatingDetector.BLJNHIFIBDC() != null)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().ENNIJCJBBNN(null);
				return;
			}
			Debug.LogError("");
		}

		// Token: 0x06012E28 RID: 77352 RVA: 0x00821DAA File Offset: 0x0081FFAA
		protected virtual void DIGMCBCPOJM()
		{
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E29 RID: 77353 RVA: 0x00822368 File Offset: 0x00820568
		private static ObscuredCheatingDetector OBNIFBKGHLF()
		{
			if (ObscuredCheatingDetector.GGOEIHCJEHP() != null)
			{
				return ObscuredCheatingDetector.BLJNHIFIBDC();
			}
			if (ActDetectorBase.ACFEJFHNHPH == null)
			{
				ActDetectorBase.ACFEJFHNHPH = new GameObject("SoccerKeeperDiveStrafeFarLeft");
			}
			ObscuredCheatingDetector.ELOBJGIDGCP = ActDetectorBase.ACFEJFHNHPH.AddComponent<ObscuredCheatingDetector>();
			return ObscuredCheatingDetector.GGOEIHCJEHP();
		}

		// Token: 0x06012E2A RID: 77354 RVA: 0x008221D6 File Offset: 0x008203D6
		private void GJKLFLOJIKL(Scene JBPBBBAOKFH, LoadSceneMode HBPAMPKAABI)
		{
			this.ALJBFJGNCLD();
		}

		// Token: 0x06012E2B RID: 77355 RVA: 0x00821B36 File Offset: 0x0081FD36
		protected virtual void NDNKDOLKNND()
		{
			this.ENNIJCJBBNN(null);
		}

		// Token: 0x06012E2C RID: 77356 RVA: 0x008223B8 File Offset: 0x008205B8
		public static void StartDetection(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.HPAMFCGOFDA.MCKMHMINODD(DFJFCOKENIA);
		}

		// Token: 0x06012E2D RID: 77357 RVA: 0x0082172D File Offset: 0x0081F92D
		protected virtual void IOHLFDKCELO()
		{
			base.LPDEBEBJDJF();
			if (ObscuredCheatingDetector.BLJNHIFIBDC() == this)
			{
				ObscuredCheatingDetector.MFOGCEDFEPO(null);
			}
		}

		// Token: 0x06012E2E RID: 77358 RVA: 0x00821B1C File Offset: 0x0081FD1C
		protected virtual void MCLOBAJGKKA()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E2F RID: 77359 RVA: 0x008223C5 File Offset: 0x008205C5
		public static void Dispose()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E30 RID: 77360 RVA: 0x008221FC File Offset: 0x008203FC
		public static void COPKMDLOJND(UnityAction DFJFCOKENIA)
		{
			ObscuredCheatingDetector.IMLHECPNCMP().DKEEFLHGKGD(DFJFCOKENIA);
		}

		// Token: 0x06012E31 RID: 77361 RVA: 0x008223DE File Offset: 0x008205DE
		protected virtual void DANGCJNMICC()
		{
			base.LPDEBEBJDJF();
			if (ObscuredCheatingDetector.GGOEIHCJEHP() == this)
			{
				ObscuredCheatingDetector.EMFAMHMCKNM(null);
			}
		}

		// Token: 0x06012E32 RID: 77362 RVA: 0x00821DAA File Offset: 0x0081FFAA
		protected virtual void KGADOCGMICF()
		{
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E33 RID: 77363 RVA: 0x00821D88 File Offset: 0x0081FF88
		protected virtual void DKFCCBIBGOE()
		{
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E34 RID: 77364 RVA: 0x00821D88 File Offset: 0x0081FF88
		protected virtual void FEJNCEDCKAN()
		{
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E35 RID: 77365 RVA: 0x008223F9 File Offset: 0x008205F9
		public static void JNNMOBBCADO()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.LNANLECJDDA().LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E36 RID: 77366 RVA: 0x00822412 File Offset: 0x00820612
		internal static bool LHMMLFNJOMC()
		{
			return ObscuredCheatingDetector.ELOBJGIDGCP == null || ObscuredCheatingDetector.GGOEIHCJEHP().OIOJMFCCDLH;
		}

		// Token: 0x06012E37 RID: 77367 RVA: 0x00821D91 File Offset: 0x0081FF91
		public static void ABDECJKKAAG()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				ObscuredCheatingDetector.LNANLECJDDA().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E38 RID: 77368 RVA: 0x008217A8 File Offset: 0x0081F9A8
		protected virtual void JOPKEFJOKIM()
		{
			base.OnDestroy();
			ObscuredCheatingDetector.MHEKHLHNDMK--;
		}

		// Token: 0x06012E39 RID: 77369 RVA: 0x00822427 File Offset: 0x00820627
		public static void EKPCIOJAGMP()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().FDPLOLOAPCO(null);
				return;
			}
			Debug.LogError("KatanaReadyHigh");
		}

		// Token: 0x06012E3A RID: 77370 RVA: 0x0082244C File Offset: 0x0082064C
		public static void PJPPMOMKMIH()
		{
			if (ObscuredCheatingDetector.GGOEIHCJEHP() != null)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E3B RID: 77371 RVA: 0x00822465 File Offset: 0x00820665
		protected virtual void BGMIPMBJMGP()
		{
			base.LPDEBEBJDJF();
			if (ObscuredCheatingDetector.LNANLECJDDA() == this)
			{
				ObscuredCheatingDetector.MKFFHJHFGGE(null);
			}
		}

		// Token: 0x06012E3C RID: 77372 RVA: 0x00821B98 File Offset: 0x0081FD98
		protected virtual void CABMDBPACPO()
		{
			base.OnDestroy();
			ObscuredCheatingDetector.MHEKHLHNDMK -= 0;
		}

		// Token: 0x06012E3D RID: 77373 RVA: 0x00821CE9 File Offset: 0x0081FEE9
		protected virtual void AMJDMCHMANP()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.IDIOOPABEMA = null;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E3E RID: 77374 RVA: 0x00821D88 File Offset: 0x0081FF88
		protected virtual void EJOPLBPLMLH()
		{
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E3F RID: 77375 RVA: 0x00821B1C File Offset: 0x0081FD1C
		protected virtual void NHJJHOGKBKI()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06012E40 RID: 77376 RVA: 0x00822480 File Offset: 0x00820680
		private static ObscuredCheatingDetector HPAMFCGOFDA
		{
			get
			{
				if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
				{
					return ObscuredCheatingDetector.ELOBJGIDGCP;
				}
				if (ActDetectorBase.ACFEJFHNHPH == null)
				{
					ActDetectorBase.ACFEJFHNHPH = new GameObject("Anti-Cheat Toolkit Detectors");
				}
				ObscuredCheatingDetector.ELOBJGIDGCP = ActDetectorBase.ACFEJFHNHPH.AddComponent<ObscuredCheatingDetector>();
				return ObscuredCheatingDetector.ELOBJGIDGCP;
			}
		}

		// Token: 0x06012E41 RID: 77377 RVA: 0x008216F1 File Offset: 0x0081F8F1
		private static void CNNEJFKFGBE(ObscuredCheatingDetector DCCPCBLODIG)
		{
			ObscuredCheatingDetector.<AFOLCKEELEK>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06012E42 RID: 77378 RVA: 0x00821B1C File Offset: 0x0081FD1C
		protected virtual void BGOGCIIOIDJ()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E43 RID: 77379 RVA: 0x008224D0 File Offset: 0x008206D0
		private void FDPLOLOAPCO(UnityAction DFJFCOKENIA)
		{
			if (this.OIOJMFCCDLH)
			{
				Debug.LogWarning("<color='#103080'>", this);
				return;
			}
			if (!base.enabled)
			{
				Debug.LogWarning("  ", this);
				return;
			}
			if (DFJFCOKENIA != null && this.detectionEventHasListener)
			{
				Debug.LogWarning(":", this);
			}
			if (DFJFCOKENIA == null && !this.detectionEventHasListener)
			{
				Debug.LogWarning("<color='{1}'>{0}</color>", this);
				base.enabled = true;
				return;
			}
			this.IDIOOPABEMA = DFJFCOKENIA;
			this.JEEGDFAGAAM = true;
			this.OIOJMFCCDLH = false;
		}

		// Token: 0x06012E44 RID: 77380 RVA: 0x0082254E File Offset: 0x0082074E
		public static void LOKBLDJJHLF()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DKEEFLHGKGD(null);
				return;
			}
			Debug.LogError(" гр ");
		}

		// Token: 0x06012E45 RID: 77381 RVA: 0x00822573 File Offset: 0x00820773
		public static void GOJKAKBMFOE()
		{
			if (ObscuredCheatingDetector.BLJNHIFIBDC() != null)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E46 RID: 77382 RVA: 0x0082227C File Offset: 0x0082047C
		public static void KDELOBEDFGM()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.LNANLECJDDA().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E47 RID: 77383 RVA: 0x0082258C File Offset: 0x0082078C
		internal static bool CKFIDHHGLGO()
		{
			return ObscuredCheatingDetector.BLJNHIFIBDC() == null || ObscuredCheatingDetector.BLJNHIFIBDC().OIOJMFCCDLH;
		}

		// Token: 0x06012E48 RID: 77384 RVA: 0x008225A1 File Offset: 0x008207A1
		public static void IMIDHPIGGIL()
		{
			if (ObscuredCheatingDetector.GGOEIHCJEHP() != null)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.FDPLOLOAPCO(null);
				return;
			}
			Debug.LogError("sunshine_CameraVToSunVP");
		}

		// Token: 0x06012E49 RID: 77385 RVA: 0x008225C6 File Offset: 0x008207C6
		public static void NIDIKIMMOON()
		{
			if (ObscuredCheatingDetector.BLJNHIFIBDC() != null)
			{
				ObscuredCheatingDetector.LNANLECJDDA().GKKIAKCDDGN();
			}
		}

		// Token: 0x06012E4A RID: 77386 RVA: 0x008225DF File Offset: 0x008207DF
		public static void MPBCPKAPDFI()
		{
			if (ObscuredCheatingDetector.ELOBJGIDGCP != null)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E4B RID: 77387 RVA: 0x00821F8C File Offset: 0x0082018C
		protected virtual void HNIOFIFPKGO()
		{
			if (this.IDIOOPABEMA == null && !this.detectionEventHasListener)
			{
				return;
			}
			this.OIOJMFCCDLH = true;
		}

		// Token: 0x06012E4C RID: 77388 RVA: 0x008225F8 File Offset: 0x008207F8
		private void MBDOEDLGJGF()
		{
			ObscuredCheatingDetector.MHEKHLHNDMK += 0;
			if (this.PINLMCCKKNA(ObscuredCheatingDetector.BLJNHIFIBDC(), "Apply 6"))
			{
				ObscuredCheatingDetector.ELOBJGIDGCP = this;
			}
			SceneManager.sceneLoaded += this.GJKLFLOJIKL;
		}

		// Token: 0x06012E4D RID: 77389 RVA: 0x00821983 File Offset: 0x0081FB83
		public static void GOODAEEMFEO()
		{
			if (ObscuredCheatingDetector.LNANLECJDDA() != null)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.LPDEBEBJDJF();
			}
		}

		// Token: 0x06012E4E RID: 77390 RVA: 0x00821B98 File Offset: 0x0081FD98
		protected virtual void BCNGPIGDICE()
		{
			base.OnDestroy();
			ObscuredCheatingDetector.MHEKHLHNDMK -= 0;
		}

		// Token: 0x0400269D RID: 9885
		private static int MHEKHLHNDMK;

		// Token: 0x0400269E RID: 9886
		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredFloat. Increase in case of false positives.")]
		public float floatEpsilon = 0.0001f;

		// Token: 0x0400269F RID: 9887
		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector2. Increase in case of false positives.")]
		public float vector2Epsilon = 0.1f;

		// Token: 0x040026A0 RID: 9888
		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredVector3. Increase in case of false positives.")]
		public float vector3Epsilon = 0.1f;

		// Token: 0x040026A1 RID: 9889
		[Tooltip("Max allowed difference between encrypted and fake values in ObscuredQuaternion. Increase in case of false positives.")]
		public float quaternionEpsilon = 0.1f;

		// Token: 0x040026A3 RID: 9891
		internal static string NOHECDAMLMH = "Obscured Cheating Detector";

		// Token: 0x040026A4 RID: 9892
		internal static string DCFKMNDDJCJ = "[ACTk] Obscured Cheating Detector: ";
	}
}
