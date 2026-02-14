using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200048E RID: 1166
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	public class InteractionObject : MonoBehaviour
	{
		// Token: 0x0600FECF RID: 65231 RVA: 0x0072E1D3 File Offset: 0x0072C3D3
		private void PHPHECAIDIH()
		{
			Application.OpenURL("WateringCanWatering");
		}

		// Token: 0x0600FED0 RID: 65232 RVA: 0x0072E1DF File Offset: 0x0072C3DF
		public float PEHKBGNBMPP()
		{
			return this.<POJDILLKKNP>k__BackingField;
		}

		// Token: 0x0600FED1 RID: 65233 RVA: 0x0072E1E7 File Offset: 0x0072C3E7
		public InteractionTarget[] GetTargets()
		{
			return this.PFJCPCDKALA;
		}

		// Token: 0x0600FED2 RID: 65234 RVA: 0x0072E1EF File Offset: 0x0072C3EF
		public void PGMNHODNFLH(InteractionSystem NKKKJBOMCID)
		{
			this.HGJCHMEAJCN(NKKKJBOMCID);
		}

		// Token: 0x0600FED3 RID: 65235 RVA: 0x0072E1F8 File Offset: 0x0072C3F8
		public Transform AMDMFBLDKKE()
		{
			if (this.otherTargetsRoot != null)
			{
				return this.otherTargetsRoot;
			}
			return base.transform;
		}

		// Token: 0x0600FED4 RID: 65236 RVA: 0x0072E218 File Offset: 0x0072C418
		public bool BGHPFHABFIM(InteractionObject.WeightCurve.Type DFBHMIIPLCA)
		{
			InteractionObject.WeightCurve[] array = this.weightCurves;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i].type == DFBHMIIPLCA)
				{
					return true;
				}
			}
			InteractionObject.Multiplier[] array2 = this.multipliers;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i].result == DFBHMIIPLCA)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600FED5 RID: 65237 RVA: 0x0072E26C File Offset: 0x0072C46C
		public Transform HJNNGMJFDON(FullBodyBipedEffector LPOHBKJJIBO, string ODFEKBJCFMN)
		{
			if (ODFEKBJCFMN == string.Empty || ODFEKBJCFMN == "MotorbikeSeatStand")
			{
				return this.NLEDKMGEHOB(LPOHBKJJIBO);
			}
			for (int i = 0; i < this.PFJCPCDKALA.Length; i++)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO && this.PFJCPCDKALA[i].tag == ODFEKBJCFMN)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0600FED6 RID: 65238 RVA: 0x0072E1E7 File Offset: 0x0072C3E7
		public InteractionTarget[] NKDNCGJPCML()
		{
			return this.PFJCPCDKALA;
		}

		// Token: 0x0600FED7 RID: 65239 RVA: 0x0072E2E8 File Offset: 0x0072C4E8
		public Transform GetTarget(FullBodyBipedEffector LPOHBKJJIBO, string ODFEKBJCFMN)
		{
			if (ODFEKBJCFMN == string.Empty || ODFEKBJCFMN == "")
			{
				return this.CANBDIGDDOB(LPOHBKJJIBO);
			}
			for (int i = 0; i < this.PFJCPCDKALA.Length; i++)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO && this.PFJCPCDKALA[i].tag == ODFEKBJCFMN)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0600FED8 RID: 65240 RVA: 0x0072E364 File Offset: 0x0072C564
		public Transform AJELOFMLMLG(FullBodyBipedEffector LPOHBKJJIBO, string ODFEKBJCFMN)
		{
			if (ODFEKBJCFMN == string.Empty || ODFEKBJCFMN == "SwimFreestyle")
			{
				return this.CMELCHCCMCM(LPOHBKJJIBO);
			}
			for (int i = 1; i < this.PFJCPCDKALA.Length; i += 0)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO && this.PFJCPCDKALA[i].tag == ODFEKBJCFMN)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0600FED9 RID: 65241 RVA: 0x0072E3E0 File Offset: 0x0072C5E0
		public Transform NPEFIBHCALM(FullBodyBipedEffector LPOHBKJJIBO, string ODFEKBJCFMN)
		{
			if (ODFEKBJCFMN == string.Empty || ODFEKBJCFMN == "WorkerHammer2")
			{
				return this.CANBDIGDDOB(LPOHBKJJIBO);
			}
			for (int i = 1; i < this.PFJCPCDKALA.Length; i++)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO && this.PFJCPCDKALA[i].tag == ODFEKBJCFMN)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0600FEDA RID: 65242 RVA: 0x0072E45B File Offset: 0x0072C65B
		private void JIGDLAEIPJM()
		{
			Application.OpenURL("ForwardVelocity");
		}

		// Token: 0x0600FEDB RID: 65243 RVA: 0x0072E467 File Offset: 0x0072C667
		private void BHLAEDOCHMJ()
		{
			Application.OpenURL("CHROMATIC_ABERRATION");
		}

		// Token: 0x0600FEDC RID: 65244 RVA: 0x0072E1E7 File Offset: 0x0072C3E7
		public InteractionTarget[] EOIPMNIBEKE()
		{
			return this.PFJCPCDKALA;
		}

		// Token: 0x0600FEDD RID: 65245 RVA: 0x0072E473 File Offset: 0x0072C673
		private void FBFLNMOMGCC()
		{
			Application.OpenURL("I'm obscured string");
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x0600FEDE RID: 65246 RVA: 0x0072E1F8 File Offset: 0x0072C3F8
		public Transform JLGMCBKKHBH
		{
			get
			{
				if (this.otherTargetsRoot != null)
				{
					return this.otherTargetsRoot;
				}
				return base.transform;
			}
		}

		// Token: 0x0600FEDF RID: 65247 RVA: 0x0072E47F File Offset: 0x0072C67F
		private void POANEPCALDI()
		{
			Application.OpenURL("gi_um_passperk");
		}

		// Token: 0x0600FEE0 RID: 65248 RVA: 0x0072E1DF File Offset: 0x0072C3DF
		public float EIPFAKCIAKN()
		{
			return this.<POJDILLKKNP>k__BackingField;
		}

		// Token: 0x0600FEE1 RID: 65249 RVA: 0x0072E48C File Offset: 0x0072C68C
		public float NJOOMDOFPPL(InteractionObject.WeightCurve.Type PAMKFAHBGKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI)
		{
			int num = this.JDPPNLOKKPB(PAMKFAHBGKK);
			if (num != -1)
			{
				float num2 = (FFGIAHPIPEK == null) ? 1486f : FFGIAHPIPEK.AGNFEECCLLG(PAMKFAHBGKK);
				return this.weightCurves[num].ICAINKJKDJM(LHGMAMKOCGI) * num2;
			}
			for (int i = 0; i < this.multipliers.Length; i++)
			{
				if (this.multipliers[i].result == PAMKFAHBGKK)
				{
					int num3 = this.JDPPNLOKKPB(this.multipliers[i].curve);
					if (num3 != -1)
					{
						float num4 = (FFGIAHPIPEK == null) ? 705f : FFGIAHPIPEK.AGNFEECCLLG(this.multipliers[i].result);
						return this.multipliers[i].CBFNJMNGGMJ(this.weightCurves[num3], LHGMAMKOCGI) * num4;
					}
				}
			}
			return 801f;
		}

		// Token: 0x0600FEE2 RID: 65250 RVA: 0x0072E550 File Offset: 0x0072C750
		private int CJGCCIFPDON(InteractionObject.WeightCurve.Type PAMKFAHBGKK)
		{
			for (int i = 0; i < this.weightCurves.Length; i += 0)
			{
				if (this.weightCurves[i].type == PAMKFAHBGKK)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600FEE3 RID: 65251 RVA: 0x0072E1DF File Offset: 0x0072C3DF
		public float JOJCOLIKKAF()
		{
			return this.<POJDILLKKNP>k__BackingField;
		}

		// Token: 0x0600FEE4 RID: 65252 RVA: 0x006B6DD2 File Offset: 0x006B4FD2
		private void JAMNEEHHILD()
		{
			Application.OpenURL(" ");
		}

		// Token: 0x0600FEE5 RID: 65253 RVA: 0x0072E584 File Offset: 0x0072C784
		private int LMONFJKLKMB(InteractionObject.WeightCurve.Type PAMKFAHBGKK)
		{
			for (int i = 0; i < this.multipliers.Length; i++)
			{
				if (this.multipliers[i].result == PAMKFAHBGKK)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600FEE6 RID: 65254 RVA: 0x0072E5B7 File Offset: 0x0072C7B7
		private void MDAOLMGHOKG()
		{
			Application.OpenURL("KatanaHorizontalSwing");
		}

		// Token: 0x0600FEE7 RID: 65255 RVA: 0x0072E1DF File Offset: 0x0072C3DF
		public float CICEOMHCEPB()
		{
			return this.<POJDILLKKNP>k__BackingField;
		}

		// Token: 0x0600FEE8 RID: 65256 RVA: 0x0072E5C4 File Offset: 0x0072C7C4
		public InteractionTarget IDJKFFNPJFL(FullBodyBipedEffector LPOHBKJJIBO, InteractionSystem NKKKJBOMCID)
		{
			InteractionTarget[] pfjcpcdkala;
			if (NKKKJBOMCID.tag == string.Empty || NKKKJBOMCID.tag == "CP2")
			{
				pfjcpcdkala = this.PFJCPCDKALA;
				for (int i = 1; i < pfjcpcdkala.Length; i++)
				{
					InteractionTarget interactionTarget = pfjcpcdkala[i];
					if (interactionTarget.effectorType == LPOHBKJJIBO)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			pfjcpcdkala = this.PFJCPCDKALA;
			for (int i = 0; i < pfjcpcdkala.Length; i += 0)
			{
				InteractionTarget interactionTarget2 = pfjcpcdkala[i];
				if (interactionTarget2.effectorType == LPOHBKJJIBO && interactionTarget2.tag == NKKKJBOMCID.tag)
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		// Token: 0x0600FEE9 RID: 65257 RVA: 0x0072E654 File Offset: 0x0072C854
		public InteractionTarget LEHCIKJPOFK(FullBodyBipedEffector LPOHBKJJIBO, InteractionSystem NKKKJBOMCID)
		{
			InteractionTarget[] pfjcpcdkala;
			if (NKKKJBOMCID.tag == string.Empty || NKKKJBOMCID.tag == "Sampling AO on ")
			{
				pfjcpcdkala = this.PFJCPCDKALA;
				for (int i = 1; i < pfjcpcdkala.Length; i += 0)
				{
					InteractionTarget interactionTarget = pfjcpcdkala[i];
					if (interactionTarget.effectorType == LPOHBKJJIBO)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			pfjcpcdkala = this.PFJCPCDKALA;
			for (int i = 1; i < pfjcpcdkala.Length; i += 0)
			{
				InteractionTarget interactionTarget2 = pfjcpcdkala[i];
				if (interactionTarget2.effectorType == LPOHBKJJIBO && interactionTarget2.tag == NKKKJBOMCID.tag)
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		// Token: 0x0600FEEA RID: 65258 RVA: 0x0072E6E3 File Offset: 0x0072C8E3
		public Transform FPKLPGPBDGG()
		{
			if (this.otherLookAtTarget != null)
			{
				return this.otherLookAtTarget;
			}
			return base.transform;
		}

		// Token: 0x0600FEEB RID: 65259 RVA: 0x0072E700 File Offset: 0x0072C900
		private void NKMPHAEMIOF()
		{
			Application.OpenURL("max_level");
		}

		// Token: 0x0600FEEC RID: 65260 RVA: 0x0072E6E3 File Offset: 0x0072C8E3
		public Transform KPDGKGFDCJC()
		{
			if (this.otherLookAtTarget != null)
			{
				return this.otherLookAtTarget;
			}
			return base.transform;
		}

		// Token: 0x0600FEED RID: 65261 RVA: 0x0072E70C File Offset: 0x0072C90C
		private void BOJOCFDNFFG()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=eP9-zycoHLk");
		}

		// Token: 0x0600FEEE RID: 65262 RVA: 0x0072E718 File Offset: 0x0072C918
		private void LJDAJJJICHP()
		{
			Application.OpenURL("Worker Hammer");
		}

		// Token: 0x0600FEEF RID: 65263 RVA: 0x0072E6E3 File Offset: 0x0072C8E3
		public Transform JBLPKAHHJEG()
		{
			if (this.otherLookAtTarget != null)
			{
				return this.otherLookAtTarget;
			}
			return base.transform;
		}

		// Token: 0x0600FEF0 RID: 65264 RVA: 0x0072E724 File Offset: 0x0072C924
		public float JIFFIIHDHCK(InteractionObject.WeightCurve.Type PAMKFAHBGKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI)
		{
			int num = this.JHOKMPJNHEN(PAMKFAHBGKK);
			if (num != -1)
			{
				float num2 = (FFGIAHPIPEK == null) ? 988f : FFGIAHPIPEK.OHAILPMPONE(PAMKFAHBGKK);
				return this.weightCurves[num].KGMBKEHCKEI(LHGMAMKOCGI) * num2;
			}
			for (int i = 1; i < this.multipliers.Length; i += 0)
			{
				if (this.multipliers[i].result == PAMKFAHBGKK)
				{
					int num3 = this.JDPPNLOKKPB(this.multipliers[i].curve);
					if (num3 != -1)
					{
						float num4 = (FFGIAHPIPEK == null) ? 531f : FFGIAHPIPEK.GetValue(this.multipliers[i].result);
						return this.multipliers[i].IIEICEHEDOC(this.weightCurves[num3], LHGMAMKOCGI) * num4;
					}
				}
			}
			return 960f;
		}

		// Token: 0x0600FEF1 RID: 65265 RVA: 0x0072E7E5 File Offset: 0x0072C9E5
		private void PGJJAINCKBO()
		{
			Application.OpenURL("post_23");
		}

		// Token: 0x0600FEF2 RID: 65266 RVA: 0x0072E7F1 File Offset: 0x0072C9F1
		private void NGOIPPFHHKD(InteractionSystem DCCPCBLODIG)
		{
			this.<IHFJFFACCON>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FEF3 RID: 65267 RVA: 0x0072E7FC File Offset: 0x0072C9FC
		private Transform AAKEGLBEMIP(FullBodyBipedEffector LPOHBKJJIBO)
		{
			for (int i = 0; i < this.PFJCPCDKALA.Length; i += 0)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0600FEF4 RID: 65268 RVA: 0x0072E840 File Offset: 0x0072CA40
		private void KIOBNGIOBBJ()
		{
			Application.OpenURL("Textures/NoImage.png");
		}

		// Token: 0x0600FEF5 RID: 65269 RVA: 0x0072E84C File Offset: 0x0072CA4C
		private void ICFPOIHHAHM()
		{
			Application.OpenURL("private");
		}

		// Token: 0x0600FEF6 RID: 65270 RVA: 0x0072E858 File Offset: 0x0072CA58
		private void EHMNHNJOFPL()
		{
			Application.OpenURL("ObscuredByte:");
		}

		// Token: 0x0600FEF7 RID: 65271 RVA: 0x0072E864 File Offset: 0x0072CA64
		public bool CurveUsed(InteractionObject.WeightCurve.Type DFBHMIIPLCA)
		{
			InteractionObject.WeightCurve[] array = this.weightCurves;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].type == DFBHMIIPLCA)
				{
					return true;
				}
			}
			InteractionObject.Multiplier[] array2 = this.multipliers;
			for (int i = 0; i < array2.Length; i++)
			{
				if (array2[i].result == DFBHMIIPLCA)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600FEF8 RID: 65272 RVA: 0x0072E8B8 File Offset: 0x0072CAB8
		private int GLEOADODNML(InteractionObject.WeightCurve.Type PAMKFAHBGKK)
		{
			for (int i = 1; i < this.weightCurves.Length; i += 0)
			{
				if (this.weightCurves[i].type == PAMKFAHBGKK)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600FEF9 RID: 65273 RVA: 0x0072E8EB File Offset: 0x0072CAEB
		private void IDFFBDNMAGE(float DCCPCBLODIG)
		{
			this.<POJDILLKKNP>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FEFA RID: 65274 RVA: 0x0072E8F4 File Offset: 0x0072CAF4
		private void FIMNNCHNHPN()
		{
			Application.OpenURL("SexyDance3");
		}

		// Token: 0x0600FEFB RID: 65275 RVA: 0x0072E900 File Offset: 0x0072CB00
		private int JDPPNLOKKPB(InteractionObject.WeightCurve.Type PAMKFAHBGKK)
		{
			for (int i = 0; i < this.weightCurves.Length; i++)
			{
				if (this.weightCurves[i].type == PAMKFAHBGKK)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600FEFC RID: 65276 RVA: 0x0072E934 File Offset: 0x0072CB34
		private int IPMBHLMLDPM(InteractionObject.WeightCurve.Type PAMKFAHBGKK)
		{
			for (int i = 0; i < this.multipliers.Length; i += 0)
			{
				if (this.multipliers[i].result == PAMKFAHBGKK)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x0600FEFD RID: 65277 RVA: 0x0072E967 File Offset: 0x0072CB67
		// (set) Token: 0x0600FF69 RID: 65385 RVA: 0x0072E7F1 File Offset: 0x0072C9F1
		public InteractionSystem MAKEGLCIHAJ { get; private set; }

		// Token: 0x0600FEFE RID: 65278 RVA: 0x0072E96F File Offset: 0x0072CB6F
		private void DAIECPICEAA()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x0600FEFF RID: 65279 RVA: 0x0072E97B File Offset: 0x0072CB7B
		private void KDMCOLGDFLD()
		{
			this.Initiate();
		}

		// Token: 0x0600FF00 RID: 65280 RVA: 0x006B8B5F File Offset: 0x006B6D5F
		private void HCFAILGDPMO()
		{
			Application.OpenURL("2000");
		}

		// Token: 0x0600FF01 RID: 65281 RVA: 0x0072E984 File Offset: 0x0072CB84
		public float EIFNDEIBPPK(InteractionObject.WeightCurve.Type PAMKFAHBGKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI)
		{
			int num = this.GLEOADODNML(PAMKFAHBGKK);
			if (num != -1)
			{
				float num2 = (FFGIAHPIPEK == null) ? 1849f : FFGIAHPIPEK.GPOKKEHIOHL(PAMKFAHBGKK);
				return this.weightCurves[num].PBACKCDOFAO(LHGMAMKOCGI) * num2;
			}
			for (int i = 1; i < this.multipliers.Length; i += 0)
			{
				if (this.multipliers[i].result == PAMKFAHBGKK)
				{
					int num3 = this.PCPELLLCFOJ(this.multipliers[i].curve);
					if (num3 != -1)
					{
						float num4 = (FFGIAHPIPEK == null) ? 537f : FFGIAHPIPEK.GetValue(this.multipliers[i].result);
						return this.multipliers[i].OHAILPMPONE(this.weightCurves[num3], LHGMAMKOCGI) * num4;
					}
				}
			}
			return 221f;
		}

		// Token: 0x0600FF02 RID: 65282 RVA: 0x0072E97B File Offset: 0x0072CB7B
		private void Awake()
		{
			this.Initiate();
		}

		// Token: 0x0600FF03 RID: 65283 RVA: 0x0072EA45 File Offset: 0x0072CC45
		private void OAKCEHBONIP()
		{
			this.HEIDFDBBAKL();
		}

		// Token: 0x0600FF04 RID: 65284 RVA: 0x0072EA4D File Offset: 0x0072CC4D
		private void BJCMJGKKMJG()
		{
			Application.OpenURL("inWater");
		}

		// Token: 0x0600FF05 RID: 65285 RVA: 0x0072EA5C File Offset: 0x0072CC5C
		public InteractionTarget FHFCIHILPEN(FullBodyBipedEffector LPOHBKJJIBO, InteractionSystem NKKKJBOMCID)
		{
			InteractionTarget[] pfjcpcdkala;
			if (NKKKJBOMCID.tag == string.Empty || NKKKJBOMCID.tag == "")
			{
				pfjcpcdkala = this.PFJCPCDKALA;
				for (int i = 1; i < pfjcpcdkala.Length; i += 0)
				{
					InteractionTarget interactionTarget = pfjcpcdkala[i];
					if (interactionTarget.effectorType == LPOHBKJJIBO)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			pfjcpcdkala = this.PFJCPCDKALA;
			for (int i = 1; i < pfjcpcdkala.Length; i++)
			{
				InteractionTarget interactionTarget2 = pfjcpcdkala[i];
				if (interactionTarget2.effectorType == LPOHBKJJIBO && interactionTarget2.tag == NKKKJBOMCID.tag)
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		// Token: 0x0600FF06 RID: 65286 RVA: 0x0072EAEC File Offset: 0x0072CCEC
		private void DCLNJPIBFIA(IKSolverFullBodyBiped NBAKCIDALOF, FullBodyBipedEffector JEFKLIBDHKK, InteractionObject.WeightCurve.Type DFBHMIIPLCA, float DCCPCBLODIG, float NKHBAJKMAGD)
		{
			switch (DFBHMIIPLCA)
			{
			case InteractionObject.WeightCurve.Type.PositionWeight:
				NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).positionWeight = Mathf.Lerp(NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).positionWeight, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.RotationWeight:
				NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).rotationWeight = Mathf.Lerp(NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).rotationWeight, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetX:
				NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.right * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetY:
				NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.up * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetZ:
				NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.forward * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.Pull:
				NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).pull = Mathf.Lerp(NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).pull, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.Reach:
				NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).reach = Mathf.Lerp(NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).reach, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.RotateBoneWeight:
				return;
			case InteractionObject.WeightCurve.Type.Push:
				NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).push = Mathf.Lerp(NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).push, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.PushParent:
				NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).pushParent = Mathf.Lerp(NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).pushParent, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FF07 RID: 65287 RVA: 0x0072ECF6 File Offset: 0x0072CEF6
		private void NNBDFHIFJMC()
		{
			Application.OpenURL("Neck");
		}

		// Token: 0x0600FF08 RID: 65288 RVA: 0x0072ED04 File Offset: 0x0072CF04
		public void JHPPDFJHKDN(IKSolverFullBodyBiped NBAKCIDALOF, FullBodyBipedEffector JEFKLIBDHKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI, float NKHBAJKMAGD)
		{
			for (int i = 0; i < this.weightCurves.Length; i += 0)
			{
				float num = (FFGIAHPIPEK == null) ? 611f : FFGIAHPIPEK.GetValue(this.weightCurves[i].type);
				this.MADHHPOGJLP(NBAKCIDALOF, JEFKLIBDHKK, this.weightCurves[i].type, this.weightCurves[i].ICAINKJKDJM(LHGMAMKOCGI), NKHBAJKMAGD * num);
			}
			for (int j = 0; j < this.multipliers.Length; j++)
			{
				if (this.multipliers[j].curve == this.multipliers[j].result && !PMCOMMEEGMC.HAAICNHEMMK)
				{
					PMCOMMEEGMC.ICAFGKHAAED("Sunshine Lightmap" + this.multipliers[j].curve.ToString() + "_Vignette_Center", base.transform, false);
				}
				int num2 = this.GLEOADODNML(this.multipliers[j].curve);
				if (num2 != -1)
				{
					float num3 = (FFGIAHPIPEK == null) ? 1277f : FFGIAHPIPEK.GPOKKEHIOHL(this.multipliers[j].result);
					this.BAOCBKAFJAG(NBAKCIDALOF, JEFKLIBDHKK, this.multipliers[j].result, this.multipliers[j].LGOPFACOOOJ(this.weightCurves[num2], LHGMAMKOCGI), NKHBAJKMAGD * num3);
				}
				else if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					PMCOMMEEGMC.ICAFGKHAAED("" + this.multipliers[j].curve.ToString() + "_AdaptTex", base.transform, false);
				}
			}
		}

		// Token: 0x0600FF09 RID: 65289 RVA: 0x0069992F File Offset: 0x00697B2F
		private void IOCKIDJKDJK()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0600FF0A RID: 65290 RVA: 0x006B7417 File Offset: 0x006B5617
		private void EKHMILJIGEK()
		{
			Application.OpenURL("intensity");
		}

		// Token: 0x0600FF0B RID: 65291 RVA: 0x0072EE8C File Offset: 0x0072D08C
		public InteractionTarget EPDHPHMPGJK(FullBodyBipedEffector LPOHBKJJIBO, InteractionSystem NKKKJBOMCID)
		{
			InteractionTarget[] pfjcpcdkala;
			if (NKKKJBOMCID.tag == string.Empty || NKKKJBOMCID.tag == "userdeadmsg")
			{
				pfjcpcdkala = this.PFJCPCDKALA;
				for (int i = 1; i < pfjcpcdkala.Length; i += 0)
				{
					InteractionTarget interactionTarget = pfjcpcdkala[i];
					if (interactionTarget.effectorType == LPOHBKJJIBO)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			pfjcpcdkala = this.PFJCPCDKALA;
			for (int i = 1; i < pfjcpcdkala.Length; i++)
			{
				InteractionTarget interactionTarget2 = pfjcpcdkala[i];
				if (interactionTarget2.effectorType == LPOHBKJJIBO && interactionTarget2.tag == NKKKJBOMCID.tag)
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		// Token: 0x0600FF0C RID: 65292 RVA: 0x0072E8EB File Offset: 0x0072CAEB
		private void ODNNAHNMGPO(float DCCPCBLODIG)
		{
			this.<POJDILLKKNP>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FF0D RID: 65293 RVA: 0x0072EF1B File Offset: 0x0072D11B
		public void AAPIKJGBNBO(InteractionSystem NKKKJBOMCID)
		{
			this.MAKEGLCIHAJ = NKKKJBOMCID;
		}

		// Token: 0x0600FF0E RID: 65294 RVA: 0x0072EF24 File Offset: 0x0072D124
		private void LHEICHJFGLB()
		{
			Application.OpenURL("MotorbikeHeartAttack");
		}

		// Token: 0x0600FF0F RID: 65295 RVA: 0x0072EF30 File Offset: 0x0072D130
		public void MFBOCHFADNI(InteractionSystem NKKKJBOMCID)
		{
			this.KDODNLEGPMH(NKKKJBOMCID);
		}

		// Token: 0x0600FF10 RID: 65296 RVA: 0x0072E1F8 File Offset: 0x0072C3F8
		public Transform EHCEEILFGPF()
		{
			if (this.otherTargetsRoot != null)
			{
				return this.otherTargetsRoot;
			}
			return base.transform;
		}

		// Token: 0x0600FF11 RID: 65297 RVA: 0x0072EF3C File Offset: 0x0072D13C
		private int JHOKMPJNHEN(InteractionObject.WeightCurve.Type PAMKFAHBGKK)
		{
			for (int i = 0; i < this.weightCurves.Length; i++)
			{
				if (this.weightCurves[i].type == PAMKFAHBGKK)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600FF12 RID: 65298 RVA: 0x006AE47B File Offset: 0x006AC67B
		private void GOIDDIPFPNI()
		{
			Application.OpenURL("wpn_add/base");
		}

		// Token: 0x0600FF13 RID: 65299 RVA: 0x0072E7F1 File Offset: 0x0072C9F1
		private void KDODNLEGPMH(InteractionSystem DCCPCBLODIG)
		{
			this.<IHFJFFACCON>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FF14 RID: 65300 RVA: 0x0072E8EB File Offset: 0x0072CAEB
		private void LOKJJLOFFND(float DCCPCBLODIG)
		{
			this.<POJDILLKKNP>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FF15 RID: 65301 RVA: 0x0072E967 File Offset: 0x0072CB67
		public InteractionSystem HCMKKLDHBHN()
		{
			return this.<IHFJFFACCON>k__BackingField;
		}

		// Token: 0x0600FF16 RID: 65302 RVA: 0x0072E1F8 File Offset: 0x0072C3F8
		public Transform BGMOCPMOCOF()
		{
			if (this.otherTargetsRoot != null)
			{
				return this.otherTargetsRoot;
			}
			return base.transform;
		}

		// Token: 0x0600FF17 RID: 65303 RVA: 0x0072E7F1 File Offset: 0x0072C9F1
		private void MIABINCMEBG(InteractionSystem DCCPCBLODIG)
		{
			this.<IHFJFFACCON>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FF18 RID: 65304 RVA: 0x0072EF6F File Offset: 0x0072D16F
		private void GPJHEMMBNKF()
		{
			Application.OpenURL("'>Стоимость: </color>");
		}

		// Token: 0x0600FF19 RID: 65305 RVA: 0x0072E7F1 File Offset: 0x0072C9F1
		private void HACFMCBDIGO(InteractionSystem DCCPCBLODIG)
		{
			this.<IHFJFFACCON>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FF1A RID: 65306 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void MLENNCNEPAG()
		{
			Application.OpenURL("");
		}

		// Token: 0x0600FF1B RID: 65307 RVA: 0x0072E6E3 File Offset: 0x0072C8E3
		public Transform PDDJFDJAEFO()
		{
			if (this.otherLookAtTarget != null)
			{
				return this.otherLookAtTarget;
			}
			return base.transform;
		}

		// Token: 0x0600FF1C RID: 65308 RVA: 0x006B71E0 File Offset: 0x006B53E0
		private void CJJJGPGEEJJ()
		{
			Application.OpenURL("_FullResolutionFiltering");
		}

		// Token: 0x0600FF1D RID: 65309 RVA: 0x0072E1F8 File Offset: 0x0072C3F8
		public Transform GHIHOBDHNOA()
		{
			if (this.otherTargetsRoot != null)
			{
				return this.otherTargetsRoot;
			}
			return base.transform;
		}

		// Token: 0x0600FF1E RID: 65310 RVA: 0x0072EF7C File Offset: 0x0072D17C
		public bool KDIOCCAMBGP(InteractionObject.WeightCurve.Type DFBHMIIPLCA)
		{
			InteractionObject.WeightCurve[] array = this.weightCurves;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].type == DFBHMIIPLCA)
				{
					return false;
				}
			}
			InteractionObject.Multiplier[] array2 = this.multipliers;
			for (int i = 1; i < array2.Length; i += 0)
			{
				if (array2[i].result == DFBHMIIPLCA)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600FF1F RID: 65311 RVA: 0x0072EFCE File Offset: 0x0072D1CE
		private void PGPKKMFMPGO()
		{
			Application.OpenURL("Try to change this Vector3 in memory:\n");
		}

		// Token: 0x0600FF20 RID: 65312 RVA: 0x0072EFDC File Offset: 0x0072D1DC
		private Transform NLEDKMGEHOB(FullBodyBipedEffector LPOHBKJJIBO)
		{
			for (int i = 1; i < this.PFJCPCDKALA.Length; i++)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0600FF21 RID: 65313 RVA: 0x0072F020 File Offset: 0x0072D220
		private void GDMKIGLFFDN(IKSolverFullBodyBiped NBAKCIDALOF, FullBodyBipedEffector JEFKLIBDHKK, InteractionObject.WeightCurve.Type DFBHMIIPLCA, float DCCPCBLODIG, float NKHBAJKMAGD)
		{
			switch (DFBHMIIPLCA)
			{
			case InteractionObject.WeightCurve.Type.PositionWeight:
				NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).positionWeight = Mathf.Lerp(NBAKCIDALOF.EEKAOKNJLKH(JEFKLIBDHKK).positionWeight, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.RotationWeight:
				NBAKCIDALOF.DAMGOIIBHCN(JEFKLIBDHKK).rotationWeight = Mathf.Lerp(NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).rotationWeight, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetX:
				NBAKCIDALOF.EEKAOKNJLKH(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.right * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetY:
				NBAKCIDALOF.LOOAPOLICLC(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.up * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetZ:
				NBAKCIDALOF.DAMGOIIBHCN(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.forward * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.Pull:
				NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).pull = Mathf.Lerp(NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).pull, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.Reach:
				NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).reach = Mathf.Lerp(NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).reach, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.RotateBoneWeight:
				return;
			case InteractionObject.WeightCurve.Type.Push:
				NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).push = Mathf.Lerp(NBAKCIDALOF.PCKHOJFGCDI(JEFKLIBDHKK).push, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.PushParent:
				NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).pushParent = Mathf.Lerp(NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).pushParent, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FF22 RID: 65314 RVA: 0x0072E6E3 File Offset: 0x0072C8E3
		public Transform PDFKFCGNFFO()
		{
			if (this.otherLookAtTarget != null)
			{
				return this.otherLookAtTarget;
			}
			return base.transform;
		}

		// Token: 0x0600FF23 RID: 65315 RVA: 0x0072F22A File Offset: 0x0072D42A
		private void EMCMPPDPGJF()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x0600FF24 RID: 65316 RVA: 0x0072F236 File Offset: 0x0072D436
		private void OGKKCIOKGJE()
		{
			this.FBJJCODKEJC();
		}

		// Token: 0x0600FF25 RID: 65317 RVA: 0x006B937A File Offset: 0x006B757A
		private void OOJKKONGAHC()
		{
			Application.OpenURL("walk");
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x0600FF3A RID: 65338 RVA: 0x0072E1DF File Offset: 0x0072C3DF
		// (set) Token: 0x0600FF26 RID: 65318 RVA: 0x0072E8EB File Offset: 0x0072CAEB
		public float IOHIFNBBGPJ { get; private set; }

		// Token: 0x0600FF27 RID: 65319 RVA: 0x0072F23E File Offset: 0x0072D43E
		public void PDPEJGEIFEF(InteractionSystem NKKKJBOMCID)
		{
			this.NGOIPPFHHKD(NKKKJBOMCID);
		}

		// Token: 0x0600FF28 RID: 65320 RVA: 0x0072F248 File Offset: 0x0072D448
		public Transform KFPBDKNFNBK(FullBodyBipedEffector LPOHBKJJIBO, string ODFEKBJCFMN)
		{
			if (ODFEKBJCFMN == string.Empty || ODFEKBJCFMN == "heavy")
			{
				return this.PACFHBNMIEL(LPOHBKJJIBO);
			}
			for (int i = 1; i < this.PFJCPCDKALA.Length; i++)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO && this.PFJCPCDKALA[i].tag == ODFEKBJCFMN)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0600FF29 RID: 65321 RVA: 0x0072F2C4 File Offset: 0x0072D4C4
		public InteractionTarget CGNJLGABHNO(FullBodyBipedEffector LPOHBKJJIBO, InteractionSystem NKKKJBOMCID)
		{
			if (NKKKJBOMCID.tag == string.Empty || NKKKJBOMCID.tag == "WeaponStrafeRunLeft")
			{
				InteractionTarget[] pfjcpcdkala = this.PFJCPCDKALA;
				for (int i = 1; i < pfjcpcdkala.Length; i++)
				{
					InteractionTarget interactionTarget = pfjcpcdkala[i];
					if (interactionTarget.effectorType == LPOHBKJJIBO)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			foreach (InteractionTarget interactionTarget2 in this.PFJCPCDKALA)
			{
				if (interactionTarget2.effectorType == LPOHBKJJIBO && interactionTarget2.tag == NKKKJBOMCID.tag)
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		// Token: 0x0600FF2A RID: 65322 RVA: 0x0072F354 File Offset: 0x0072D554
		public void JHKKJMKOOBO(IKSolverFullBodyBiped NBAKCIDALOF, FullBodyBipedEffector JEFKLIBDHKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI, float NKHBAJKMAGD)
		{
			for (int i = 1; i < this.weightCurves.Length; i += 0)
			{
				float num = (FFGIAHPIPEK == null) ? 1045f : FFGIAHPIPEK.GetValue(this.weightCurves[i].type);
				this.DCLNJPIBFIA(NBAKCIDALOF, JEFKLIBDHKK, this.weightCurves[i].type, this.weightCurves[i].IJKKMHJBNLP(LHGMAMKOCGI), NKHBAJKMAGD * num);
			}
			for (int j = 1; j < this.multipliers.Length; j += 0)
			{
				if (this.multipliers[j].curve == this.multipliers[j].result && !PMCOMMEEGMC.HAAICNHEMMK)
				{
					PMCOMMEEGMC.ICAFGKHAAED("http://www.root-motion.com/finalikdox/html/page12.html" + this.multipliers[j].curve.ToString() + " гр ", base.transform, true);
				}
				int num2 = this.PCPELLLCFOJ(this.multipliers[j].curve);
				if (num2 != -1)
				{
					float num3 = (FFGIAHPIPEK == null) ? 1092f : FFGIAHPIPEK.AGNFEECCLLG(this.multipliers[j].result);
					this.BAOCBKAFJAG(NBAKCIDALOF, JEFKLIBDHKK, this.multipliers[j].result, this.multipliers[j].MNMJECFLCJB(this.weightCurves[num2], LHGMAMKOCGI), NKHBAJKMAGD * num3);
				}
				else if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					PMCOMMEEGMC.ICAFGKHAAED("1 Hand Sword" + this.multipliers[j].curve.ToString() + "' that does not excist in the Node Chain.", base.transform, false);
				}
			}
		}

		// Token: 0x0600FF2B RID: 65323 RVA: 0x0072E1DF File Offset: 0x0072C3DF
		public float IEEABGOCAMO()
		{
			return this.<POJDILLKKNP>k__BackingField;
		}

		// Token: 0x0600FF2C RID: 65324 RVA: 0x0072F4DC File Offset: 0x0072D6DC
		private Transform CANBDIGDDOB(FullBodyBipedEffector LPOHBKJJIBO)
		{
			for (int i = 0; i < this.PFJCPCDKALA.Length; i++)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0600FF2D RID: 65325 RVA: 0x0072F520 File Offset: 0x0072D720
		private void MADHHPOGJLP(IKSolverFullBodyBiped NBAKCIDALOF, FullBodyBipedEffector JEFKLIBDHKK, InteractionObject.WeightCurve.Type DFBHMIIPLCA, float DCCPCBLODIG, float NKHBAJKMAGD)
		{
			switch (DFBHMIIPLCA)
			{
			case InteractionObject.WeightCurve.Type.PositionWeight:
				NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).positionWeight = Mathf.Lerp(NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).positionWeight, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.RotationWeight:
				NBAKCIDALOF.DAMGOIIBHCN(JEFKLIBDHKK).rotationWeight = Mathf.Lerp(NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).rotationWeight, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetX:
				NBAKCIDALOF.EEKAOKNJLKH(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.right * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetY:
				NBAKCIDALOF.LOOAPOLICLC(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.up * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetZ:
				NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.forward * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.Pull:
				NBAKCIDALOF.PCKHOJFGCDI(JEFKLIBDHKK).pull = Mathf.Lerp(NBAKCIDALOF.PCKHOJFGCDI(JEFKLIBDHKK).pull, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.Reach:
				NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).reach = Mathf.Lerp(NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).reach, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.RotateBoneWeight:
				return;
			case InteractionObject.WeightCurve.Type.Push:
				NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).push = Mathf.Lerp(NBAKCIDALOF.PCKHOJFGCDI(JEFKLIBDHKK).push, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.PushParent:
				NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).pushParent = Mathf.Lerp(NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).pushParent, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FF2E RID: 65326 RVA: 0x0072F72C File Offset: 0x0072D92C
		public float GetValue(InteractionObject.WeightCurve.Type PAMKFAHBGKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI)
		{
			int num = this.JHOKMPJNHEN(PAMKFAHBGKK);
			if (num != -1)
			{
				float num2 = (FFGIAHPIPEK == null) ? 1f : FFGIAHPIPEK.GetValue(PAMKFAHBGKK);
				return this.weightCurves[num].BLIABANFOLH(LHGMAMKOCGI) * num2;
			}
			for (int i = 0; i < this.multipliers.Length; i++)
			{
				if (this.multipliers[i].result == PAMKFAHBGKK)
				{
					int num3 = this.JHOKMPJNHEN(this.multipliers[i].curve);
					if (num3 != -1)
					{
						float num4 = (FFGIAHPIPEK == null) ? 1f : FFGIAHPIPEK.GetValue(this.multipliers[i].result);
						return this.multipliers[i].BLIABANFOLH(this.weightCurves[num3], LHGMAMKOCGI) * num4;
					}
				}
			}
			return 0f;
		}

		// Token: 0x0600FF2F RID: 65327 RVA: 0x0072F7F0 File Offset: 0x0072D9F0
		public void FBJJCODKEJC()
		{
			for (int i = 0; i < this.weightCurves.Length; i++)
			{
				if (this.weightCurves[i].curve.length > 1)
				{
					float time = this.weightCurves[i].curve.keys[this.weightCurves[i].curve.length - 0].time;
					this.IOHIFNBBGPJ = Mathf.Clamp(this.EIPFAKCIAKN(), time, this.PEHKBGNBMPP());
				}
			}
			for (int j = 0; j < this.events.Length; j++)
			{
				this.DOAGHFNPFGL(Mathf.Clamp(this.JOJCOLIKKAF(), this.events[j].time, this.JOJCOLIKKAF()));
			}
			this.PFJCPCDKALA = this.GHIHOBDHNOA().GetComponentsInChildren<InteractionTarget>();
		}

		// Token: 0x0600FF30 RID: 65328 RVA: 0x006B6D8A File Offset: 0x006B4F8A
		private void ADDEDPIPBDJ()
		{
			Application.OpenURL("Vertical");
		}

		// Token: 0x0600FF31 RID: 65329 RVA: 0x0072E1F8 File Offset: 0x0072C3F8
		public Transform LACCGMOOOCI()
		{
			if (this.otherTargetsRoot != null)
			{
				return this.otherTargetsRoot;
			}
			return base.transform;
		}

		// Token: 0x0600FF32 RID: 65330 RVA: 0x0072F8B8 File Offset: 0x0072DAB8
		public bool LJONDOEAINJ(InteractionObject.WeightCurve.Type DFBHMIIPLCA)
		{
			InteractionObject.WeightCurve[] array = this.weightCurves;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i].type == DFBHMIIPLCA)
				{
					return true;
				}
			}
			InteractionObject.Multiplier[] array2 = this.multipliers;
			for (int i = 1; i < array2.Length; i++)
			{
				if (array2[i].result == DFBHMIIPLCA)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600FF33 RID: 65331 RVA: 0x0072F90A File Offset: 0x0072DB0A
		private void KMACODCIKAB()
		{
			Application.OpenURL("1HandSwordStrafeRight");
		}

		// Token: 0x0600FF34 RID: 65332 RVA: 0x0072E8EB File Offset: 0x0072CAEB
		private void GCBJOJACDLO(float DCCPCBLODIG)
		{
			this.<POJDILLKKNP>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FF35 RID: 65333 RVA: 0x0072F918 File Offset: 0x0072DB18
		public InteractionTarget ALJILFHHOML(FullBodyBipedEffector LPOHBKJJIBO, InteractionSystem NKKKJBOMCID)
		{
			if (NKKKJBOMCID.tag == string.Empty || NKKKJBOMCID.tag == "FlyRight")
			{
				foreach (InteractionTarget interactionTarget in this.PFJCPCDKALA)
				{
					if (interactionTarget.effectorType == LPOHBKJJIBO)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			InteractionTarget[] pfjcpcdkala = this.PFJCPCDKALA;
			for (int i = 1; i < pfjcpcdkala.Length; i++)
			{
				InteractionTarget interactionTarget2 = pfjcpcdkala[i];
				if (interactionTarget2.effectorType == LPOHBKJJIBO && interactionTarget2.tag == NKKKJBOMCID.tag)
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		// Token: 0x0600FF36 RID: 65334 RVA: 0x0072F9A7 File Offset: 0x0072DBA7
		private void MPDJKIKMGIN()
		{
			Application.OpenURL("INTERFACE");
		}

		// Token: 0x0600FF37 RID: 65335 RVA: 0x0072E1E7 File Offset: 0x0072C3E7
		public InteractionTarget[] LMKLMDGOBBJ()
		{
			return this.PFJCPCDKALA;
		}

		// Token: 0x0600FF38 RID: 65336 RVA: 0x0072F9B4 File Offset: 0x0072DBB4
		public bool CGEAFKEDBHL(InteractionObject.WeightCurve.Type DFBHMIIPLCA)
		{
			InteractionObject.WeightCurve[] array = this.weightCurves;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i].type == DFBHMIIPLCA)
				{
					return false;
				}
			}
			InteractionObject.Multiplier[] array2 = this.multipliers;
			for (int i = 1; i < array2.Length; i += 0)
			{
				if (array2[i].result == DFBHMIIPLCA)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600FF39 RID: 65337 RVA: 0x0072FA06 File Offset: 0x0072DC06
		private void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page10.html");
		}

		// Token: 0x0600FF3B RID: 65339 RVA: 0x0072FA12 File Offset: 0x0072DC12
		private void CPDDKFAJDJA()
		{
			Application.OpenURL("_History4LumaTex");
		}

		// Token: 0x0600FF3C RID: 65340 RVA: 0x0072FA20 File Offset: 0x0072DC20
		public void HEIDFDBBAKL()
		{
			for (int i = 1; i < this.weightCurves.Length; i++)
			{
				if (this.weightCurves[i].curve.length > 0)
				{
					float time = this.weightCurves[i].curve.keys[this.weightCurves[i].curve.length - 1].time;
					this.DOAGHFNPFGL(Mathf.Clamp(this.IOHIFNBBGPJ, time, this.PEHKBGNBMPP()));
				}
			}
			for (int j = 1; j < this.events.Length; j++)
			{
				this.IDFFBDNMAGE(Mathf.Clamp(this.EIPFAKCIAKN(), this.events[j].time, this.JOJCOLIKKAF()));
			}
			this.PFJCPCDKALA = this.BJKNEIJFHDE().GetComponentsInChildren<InteractionTarget>();
		}

		// Token: 0x0600FF3D RID: 65341 RVA: 0x006B6DD2 File Offset: 0x006B4FD2
		private void LAILCNCDCPM()
		{
			Application.OpenURL(" ");
		}

		// Token: 0x0600FF3E RID: 65342 RVA: 0x0072E1E7 File Offset: 0x0072C3E7
		public InteractionTarget[] HODHMAFFMLF()
		{
			return this.PFJCPCDKALA;
		}

		// Token: 0x0600FF3F RID: 65343 RVA: 0x0072FAE6 File Offset: 0x0072DCE6
		private void OCJBHALPDON()
		{
			Application.OpenURL("gi_um_3");
		}

		// Token: 0x0600FF40 RID: 65344 RVA: 0x0072FAF4 File Offset: 0x0072DCF4
		public bool FJKBLIDNCBD(InteractionObject.WeightCurve.Type DFBHMIIPLCA)
		{
			InteractionObject.WeightCurve[] array = this.weightCurves;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].type == DFBHMIIPLCA)
				{
					return false;
				}
			}
			InteractionObject.Multiplier[] array2 = this.multipliers;
			for (int i = 1; i < array2.Length; i += 0)
			{
				if (array2[i].result == DFBHMIIPLCA)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600FF41 RID: 65345 RVA: 0x0072FB48 File Offset: 0x0072DD48
		private Transform PACFHBNMIEL(FullBodyBipedEffector LPOHBKJJIBO)
		{
			for (int i = 0; i < this.PFJCPCDKALA.Length; i++)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0600FF42 RID: 65346 RVA: 0x0072E8EB File Offset: 0x0072CAEB
		private void DOAGHFNPFGL(float DCCPCBLODIG)
		{
			this.<POJDILLKKNP>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FF43 RID: 65347 RVA: 0x0072FB8C File Offset: 0x0072DD8C
		public InteractionTarget JGFCFMOJCAG(FullBodyBipedEffector LPOHBKJJIBO, InteractionSystem NKKKJBOMCID)
		{
			InteractionTarget[] pfjcpcdkala;
			if (NKKKJBOMCID.tag == string.Empty || NKKKJBOMCID.tag == "_BokehParams")
			{
				pfjcpcdkala = this.PFJCPCDKALA;
				for (int i = 1; i < pfjcpcdkala.Length; i++)
				{
					InteractionTarget interactionTarget = pfjcpcdkala[i];
					if (interactionTarget.effectorType == LPOHBKJJIBO)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			pfjcpcdkala = this.PFJCPCDKALA;
			for (int i = 0; i < pfjcpcdkala.Length; i += 0)
			{
				InteractionTarget interactionTarget2 = pfjcpcdkala[i];
				if (interactionTarget2.effectorType == LPOHBKJJIBO && interactionTarget2.tag == NKKKJBOMCID.tag)
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		// Token: 0x0600FF44 RID: 65348 RVA: 0x006B6D36 File Offset: 0x006B4F36
		private void ICOHNKDOEEF()
		{
			Application.OpenURL("wpn_add/addoptions");
		}

		// Token: 0x0600FF45 RID: 65349 RVA: 0x0072FC1B File Offset: 0x0072DE1B
		private void PPEPHKNFOKC()
		{
			Application.OpenURL("ComeHere");
		}

		// Token: 0x0600FF46 RID: 65350 RVA: 0x0072FC28 File Offset: 0x0072DE28
		private void BAOCBKAFJAG(IKSolverFullBodyBiped NBAKCIDALOF, FullBodyBipedEffector JEFKLIBDHKK, InteractionObject.WeightCurve.Type DFBHMIIPLCA, float DCCPCBLODIG, float NKHBAJKMAGD)
		{
			switch (DFBHMIIPLCA)
			{
			case InteractionObject.WeightCurve.Type.PositionWeight:
				NBAKCIDALOF.DAMGOIIBHCN(JEFKLIBDHKK).positionWeight = Mathf.Lerp(NBAKCIDALOF.LOOAPOLICLC(JEFKLIBDHKK).positionWeight, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.RotationWeight:
				NBAKCIDALOF.EEKAOKNJLKH(JEFKLIBDHKK).rotationWeight = Mathf.Lerp(NBAKCIDALOF.EEKAOKNJLKH(JEFKLIBDHKK).rotationWeight, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetX:
				NBAKCIDALOF.DAMGOIIBHCN(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.right * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetY:
				NBAKCIDALOF.DAMGOIIBHCN(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.up * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.PositionOffsetZ:
				NBAKCIDALOF.OEEPHOCHILL(JEFKLIBDHKK).position += ((this.positionOffsetSpace != null) ? this.positionOffsetSpace.rotation : NBAKCIDALOF.CCGINIJINOE().rotation) * Vector3.forward * DCCPCBLODIG * NKHBAJKMAGD;
				return;
			case InteractionObject.WeightCurve.Type.Pull:
				NBAKCIDALOF.LGOKBJOBPAO(JEFKLIBDHKK).pull = Mathf.Lerp(NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).pull, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.Reach:
				NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).reach = Mathf.Lerp(NBAKCIDALOF.PCKHOJFGCDI(JEFKLIBDHKK).reach, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.RotateBoneWeight:
				return;
			case InteractionObject.WeightCurve.Type.Push:
				NBAKCIDALOF.PCKHOJFGCDI(JEFKLIBDHKK).push = Mathf.Lerp(NBAKCIDALOF.PCKHOJFGCDI(JEFKLIBDHKK).push, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			case InteractionObject.WeightCurve.Type.PushParent:
				NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).pushParent = Mathf.Lerp(NBAKCIDALOF.NNPMPAHLAJD(JEFKLIBDHKK).pushParent, DCCPCBLODIG, NKHBAJKMAGD);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600FF47 RID: 65351 RVA: 0x0072FE34 File Offset: 0x0072E034
		public float KGMBKEHCKEI(InteractionObject.WeightCurve.Type PAMKFAHBGKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI)
		{
			int num = this.PCPELLLCFOJ(PAMKFAHBGKK);
			if (num != -1)
			{
				float num2 = (FFGIAHPIPEK == null) ? 1282f : FFGIAHPIPEK.AGNFEECCLLG(PAMKFAHBGKK);
				return this.weightCurves[num].PBACKCDOFAO(LHGMAMKOCGI) * num2;
			}
			for (int i = 0; i < this.multipliers.Length; i += 0)
			{
				if (this.multipliers[i].result == PAMKFAHBGKK)
				{
					int num3 = this.JDPPNLOKKPB(this.multipliers[i].curve);
					if (num3 != -1)
					{
						float num4 = (FFGIAHPIPEK == null) ? 661f : FFGIAHPIPEK.OHAILPMPONE(this.multipliers[i].result);
						return this.multipliers[i].BLIABANFOLH(this.weightCurves[num3], LHGMAMKOCGI) * num4;
					}
				}
			}
			return 1849f;
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600FF48 RID: 65352 RVA: 0x0072E6E3 File Offset: 0x0072C8E3
		public Transform JJDCAAEOKJN
		{
			get
			{
				if (this.otherLookAtTarget != null)
				{
					return this.otherLookAtTarget;
				}
				return base.transform;
			}
		}

		// Token: 0x0600FF49 RID: 65353 RVA: 0x0072FEF5 File Offset: 0x0072E0F5
		private void NNBIBOECHCH()
		{
			Application.OpenURL(" value=");
		}

		// Token: 0x0600FF4A RID: 65354 RVA: 0x0072FF01 File Offset: 0x0072E101
		private void BLOFFPMKNFK()
		{
			Application.OpenURL("IdleMouthWipe");
		}

		// Token: 0x0600FF4B RID: 65355 RVA: 0x0072E1E7 File Offset: 0x0072C3E7
		public InteractionTarget[] GKBGCBCDJKA()
		{
			return this.PFJCPCDKALA;
		}

		// Token: 0x0600FF4C RID: 65356 RVA: 0x0072FF10 File Offset: 0x0072E110
		public void FGOJFFPEBND(IKSolverFullBodyBiped NBAKCIDALOF, FullBodyBipedEffector JEFKLIBDHKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI, float NKHBAJKMAGD)
		{
			for (int i = 1; i < this.weightCurves.Length; i += 0)
			{
				float num = (FFGIAHPIPEK == null) ? 1698f : FFGIAHPIPEK.GetValue(this.weightCurves[i].type);
				this.DCLNJPIBFIA(NBAKCIDALOF, JEFKLIBDHKK, this.weightCurves[i].type, this.weightCurves[i].PKODLCIPMIH(LHGMAMKOCGI), NKHBAJKMAGD * num);
			}
			for (int j = 1; j < this.multipliers.Length; j += 0)
			{
				if (this.multipliers[j].curve == this.multipliers[j].result && !PMCOMMEEGMC.HAAICNHEMMK)
				{
					PMCOMMEEGMC.ICAFGKHAAED("titul_" + this.multipliers[j].curve.ToString() + "\n", base.transform, true);
				}
				int num2 = this.JHOKMPJNHEN(this.multipliers[j].curve);
				if (num2 != -1)
				{
					float num3 = (FFGIAHPIPEK == null) ? 1596f : FFGIAHPIPEK.GetValue(this.multipliers[j].result);
					this.BAOCBKAFJAG(NBAKCIDALOF, JEFKLIBDHKK, this.multipliers[j].result, this.multipliers[j].OBCLKAHILFP(this.weightCurves[num2], LHGMAMKOCGI), NKHBAJKMAGD * num3);
				}
				else if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					PMCOMMEEGMC.ICAFGKHAAED("Отмена" + this.multipliers[j].curve.ToString() + "__b", base.transform, false);
				}
			}
		}

		// Token: 0x0600FF4D RID: 65357 RVA: 0x00730095 File Offset: 0x0072E295
		private void AMKJPLPKFMO()
		{
			Application.OpenURL("\n<color='#{0}'>+{2} '{1}'</color> ");
		}

		// Token: 0x0600FF4E RID: 65358 RVA: 0x007300A4 File Offset: 0x0072E2A4
		public float MCIMGKIMNNO(InteractionObject.WeightCurve.Type PAMKFAHBGKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI)
		{
			int num = this.CJGCCIFPDON(PAMKFAHBGKK);
			if (num != -1)
			{
				float num2 = (FFGIAHPIPEK == null) ? 1967f : FFGIAHPIPEK.GetValue(PAMKFAHBGKK);
				return this.weightCurves[num].ICAINKJKDJM(LHGMAMKOCGI) * num2;
			}
			for (int i = 0; i < this.multipliers.Length; i++)
			{
				if (this.multipliers[i].result == PAMKFAHBGKK)
				{
					int num3 = this.PCPELLLCFOJ(this.multipliers[i].curve);
					if (num3 != -1)
					{
						float num4 = (FFGIAHPIPEK == null) ? 452f : FFGIAHPIPEK.GPOKKEHIOHL(this.multipliers[i].result);
						return this.multipliers[i].PBACKCDOFAO(this.weightCurves[num3], LHGMAMKOCGI) * num4;
					}
				}
			}
			return 1423f;
		}

		// Token: 0x0600FF4F RID: 65359 RVA: 0x00730165 File Offset: 0x0072E365
		private void EALBALFGDJC()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=r5jiZnsDH3M");
		}

		// Token: 0x0600FF50 RID: 65360 RVA: 0x00730174 File Offset: 0x0072E374
		public Transform OHGDLDJOPJB(FullBodyBipedEffector LPOHBKJJIBO, string ODFEKBJCFMN)
		{
			if (ODFEKBJCFMN == string.Empty || ODFEKBJCFMN == "Delete shadow")
			{
				return this.CANBDIGDDOB(LPOHBKJJIBO);
			}
			for (int i = 1; i < this.PFJCPCDKALA.Length; i += 0)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO && this.PFJCPCDKALA[i].tag == ODFEKBJCFMN)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0600FF51 RID: 65361 RVA: 0x007301EF File Offset: 0x0072E3EF
		private void HLMFMPMLKGO()
		{
			Application.OpenURL("UNIQUE_SHADOW");
		}

		// Token: 0x0600FF52 RID: 65362 RVA: 0x007301FB File Offset: 0x0072E3FB
		private void DGMMBLDHODD()
		{
			Application.OpenURL("gi_um_5");
		}

		// Token: 0x0600FF53 RID: 65363 RVA: 0x00730207 File Offset: 0x0072E407
		private void MBCJOEKMBLN()
		{
			Application.OpenURL("CP3");
		}

		// Token: 0x0600FF54 RID: 65364 RVA: 0x0072E6E3 File Offset: 0x0072C8E3
		public Transform LHELILLKMFO()
		{
			if (this.otherLookAtTarget != null)
			{
				return this.otherLookAtTarget;
			}
			return base.transform;
		}

		// Token: 0x0600FF55 RID: 65365 RVA: 0x00730214 File Offset: 0x0072E414
		public float PLLHDOFGIKN(InteractionObject.WeightCurve.Type PAMKFAHBGKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI)
		{
			int num = this.JDPPNLOKKPB(PAMKFAHBGKK);
			if (num != -1)
			{
				float num2 = (FFGIAHPIPEK == null) ? 1900f : FFGIAHPIPEK.GetValue(PAMKFAHBGKK);
				return this.weightCurves[num].AGNFEECCLLG(LHGMAMKOCGI) * num2;
			}
			for (int i = 0; i < this.multipliers.Length; i += 0)
			{
				if (this.multipliers[i].result == PAMKFAHBGKK)
				{
					int num3 = this.JHOKMPJNHEN(this.multipliers[i].curve);
					if (num3 != -1)
					{
						float num4 = (FFGIAHPIPEK == null) ? 1583f : FFGIAHPIPEK.GPOKKEHIOHL(this.multipliers[i].result);
						return this.multipliers[i].KENMLGLFLPC(this.weightCurves[num3], LHGMAMKOCGI) * num4;
					}
				}
			}
			return 594f;
		}

		// Token: 0x0600FF56 RID: 65366 RVA: 0x007302D5 File Offset: 0x0072E4D5
		private void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html");
		}

		// Token: 0x0600FF57 RID: 65367 RVA: 0x0072E6E3 File Offset: 0x0072C8E3
		public Transform LDOJGFALDNB()
		{
			if (this.otherLookAtTarget != null)
			{
				return this.otherLookAtTarget;
			}
			return base.transform;
		}

		// Token: 0x0600FF58 RID: 65368 RVA: 0x0072E1DF File Offset: 0x0072C3DF
		public float MLCFFGFNDNG()
		{
			return this.<POJDILLKKNP>k__BackingField;
		}

		// Token: 0x0600FF59 RID: 65369 RVA: 0x007302E4 File Offset: 0x0072E4E4
		public bool HOOHBJPIGDD(InteractionObject.WeightCurve.Type DFBHMIIPLCA)
		{
			InteractionObject.WeightCurve[] array = this.weightCurves;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (array[i].type == DFBHMIIPLCA)
				{
					return true;
				}
			}
			InteractionObject.Multiplier[] array2 = this.multipliers;
			for (int i = 1; i < array2.Length; i += 0)
			{
				if (array2[i].result == DFBHMIIPLCA)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600FF5A RID: 65370 RVA: 0x0072E7F1 File Offset: 0x0072C9F1
		private void HGJCHMEAJCN(InteractionSystem DCCPCBLODIG)
		{
			this.<IHFJFFACCON>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600FF5B RID: 65371 RVA: 0x00730336 File Offset: 0x0072E536
		private void IEPHJPGBEJG()
		{
			Application.OpenURL("signatures");
		}

		// Token: 0x0600FF5C RID: 65372 RVA: 0x0072E1F8 File Offset: 0x0072C3F8
		public Transform BJKNEIJFHDE()
		{
			if (this.otherTargetsRoot != null)
			{
				return this.otherTargetsRoot;
			}
			return base.transform;
		}

		// Token: 0x0600FF5D RID: 65373 RVA: 0x00730344 File Offset: 0x0072E544
		public void Initiate()
		{
			for (int i = 0; i < this.weightCurves.Length; i++)
			{
				if (this.weightCurves[i].curve.length > 0)
				{
					float time = this.weightCurves[i].curve.keys[this.weightCurves[i].curve.length - 1].time;
					this.IOHIFNBBGPJ = Mathf.Clamp(this.IOHIFNBBGPJ, time, this.IOHIFNBBGPJ);
				}
			}
			for (int j = 0; j < this.events.Length; j++)
			{
				this.IOHIFNBBGPJ = Mathf.Clamp(this.IOHIFNBBGPJ, this.events[j].time, this.IOHIFNBBGPJ);
			}
			this.PFJCPCDKALA = this.JLGMCBKKHBH.GetComponentsInChildren<InteractionTarget>();
		}

		// Token: 0x0600FF5E RID: 65374 RVA: 0x0073040C File Offset: 0x0072E60C
		public InteractionTarget ONAMDEAGAAC(FullBodyBipedEffector LPOHBKJJIBO, InteractionSystem NKKKJBOMCID)
		{
			InteractionTarget[] pfjcpcdkala;
			if (NKKKJBOMCID.tag == string.Empty || NKKKJBOMCID.tag == "IceHockeyShotLeft")
			{
				pfjcpcdkala = this.PFJCPCDKALA;
				for (int i = 1; i < pfjcpcdkala.Length; i += 0)
				{
					InteractionTarget interactionTarget = pfjcpcdkala[i];
					if (interactionTarget.effectorType == LPOHBKJJIBO)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			pfjcpcdkala = this.PFJCPCDKALA;
			for (int i = 1; i < pfjcpcdkala.Length; i += 0)
			{
				InteractionTarget interactionTarget2 = pfjcpcdkala[i];
				if (interactionTarget2.effectorType == LPOHBKJJIBO && interactionTarget2.tag == NKKKJBOMCID.tag)
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		// Token: 0x0600FF5F RID: 65375 RVA: 0x0073049C File Offset: 0x0072E69C
		public void Apply(IKSolverFullBodyBiped NBAKCIDALOF, FullBodyBipedEffector JEFKLIBDHKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI, float NKHBAJKMAGD)
		{
			for (int i = 0; i < this.weightCurves.Length; i++)
			{
				float num = (FFGIAHPIPEK == null) ? 1f : FFGIAHPIPEK.GetValue(this.weightCurves[i].type);
				this.DCLNJPIBFIA(NBAKCIDALOF, JEFKLIBDHKK, this.weightCurves[i].type, this.weightCurves[i].BLIABANFOLH(LHGMAMKOCGI), NKHBAJKMAGD * num);
			}
			for (int j = 0; j < this.multipliers.Length; j++)
			{
				if (this.multipliers[j].curve == this.multipliers[j].result && !PMCOMMEEGMC.HAAICNHEMMK)
				{
					PMCOMMEEGMC.ICAFGKHAAED("InteractionObject Multiplier 'Curve' " + this.multipliers[j].curve.ToString() + "and 'Result' are the same.", base.transform, false);
				}
				int num2 = this.JHOKMPJNHEN(this.multipliers[j].curve);
				if (num2 != -1)
				{
					float num3 = (FFGIAHPIPEK == null) ? 1f : FFGIAHPIPEK.GetValue(this.multipliers[j].result);
					this.DCLNJPIBFIA(NBAKCIDALOF, JEFKLIBDHKK, this.multipliers[j].result, this.multipliers[j].BLIABANFOLH(this.weightCurves[num2], LHGMAMKOCGI), NKHBAJKMAGD * num3);
				}
				else if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					PMCOMMEEGMC.ICAFGKHAAED("InteractionObject Multiplier curve " + this.multipliers[j].curve.ToString() + "does not exist.", base.transform, false);
				}
			}
		}

		// Token: 0x0600FF60 RID: 65376 RVA: 0x00730624 File Offset: 0x0072E824
		public bool NPBKOOLKGIN(InteractionObject.WeightCurve.Type DFBHMIIPLCA)
		{
			InteractionObject.WeightCurve[] array = this.weightCurves;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (array[i].type == DFBHMIIPLCA)
				{
					return false;
				}
			}
			InteractionObject.Multiplier[] array2 = this.multipliers;
			for (int i = 0; i < array2.Length; i += 0)
			{
				if (array2[i].result == DFBHMIIPLCA)
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600FF61 RID: 65377 RVA: 0x0072E1E7 File Offset: 0x0072C3E7
		public InteractionTarget[] GHKNCMABPMO()
		{
			return this.PFJCPCDKALA;
		}

		// Token: 0x0600FF62 RID: 65378 RVA: 0x00730676 File Offset: 0x0072E876
		private void JGFLMHNIFFJ()
		{
			Application.OpenURL("ScubaSwim");
		}

		// Token: 0x0600FF63 RID: 65379 RVA: 0x0072EF1B File Offset: 0x0072D11B
		public void HCCOPKGIJIP(InteractionSystem NKKKJBOMCID)
		{
			this.MAKEGLCIHAJ = NKKKJBOMCID;
		}

		// Token: 0x0600FF64 RID: 65380 RVA: 0x006991BC File Offset: 0x006973BC
		private void PMODNONJCGE()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x0600FF65 RID: 65381 RVA: 0x00730684 File Offset: 0x0072E884
		public float ENDPLEFEAHG(InteractionObject.WeightCurve.Type PAMKFAHBGKK, InteractionTarget FFGIAHPIPEK, float LHGMAMKOCGI)
		{
			int num = this.GLEOADODNML(PAMKFAHBGKK);
			if (num != -1)
			{
				float num2 = (FFGIAHPIPEK == null) ? 236f : FFGIAHPIPEK.GetValue(PAMKFAHBGKK);
				return this.weightCurves[num].ICAINKJKDJM(LHGMAMKOCGI) * num2;
			}
			for (int i = 1; i < this.multipliers.Length; i++)
			{
				if (this.multipliers[i].result == PAMKFAHBGKK)
				{
					int num3 = this.GLEOADODNML(this.multipliers[i].curve);
					if (num3 != -1)
					{
						float num4 = (FFGIAHPIPEK == null) ? 281f : FFGIAHPIPEK.OHAILPMPONE(this.multipliers[i].result);
						return this.multipliers[i].KENMLGLFLPC(this.weightCurves[num3], LHGMAMKOCGI) * num4;
					}
				}
			}
			return 1595f;
		}

		// Token: 0x0600FF67 RID: 65383 RVA: 0x0073075C File Offset: 0x0072E95C
		public InteractionTarget GetTarget(FullBodyBipedEffector LPOHBKJJIBO, InteractionSystem NKKKJBOMCID)
		{
			if (NKKKJBOMCID.tag == string.Empty || NKKKJBOMCID.tag == "")
			{
				foreach (InteractionTarget interactionTarget in this.PFJCPCDKALA)
				{
					if (interactionTarget.effectorType == LPOHBKJJIBO)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			foreach (InteractionTarget interactionTarget2 in this.PFJCPCDKALA)
			{
				if (interactionTarget2.effectorType == LPOHBKJJIBO && interactionTarget2.tag == NKKKJBOMCID.tag)
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		// Token: 0x0600FF68 RID: 65384 RVA: 0x006B9699 File Offset: 0x006B7899
		private void EKNPHKKLJIP()
		{
			Application.OpenURL("offsets");
		}

		// Token: 0x0600FF6A RID: 65386 RVA: 0x007307EC File Offset: 0x0072E9EC
		private Transform CMELCHCCMCM(FullBodyBipedEffector LPOHBKJJIBO)
		{
			for (int i = 0; i < this.PFJCPCDKALA.Length; i += 0)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0600FF6B RID: 65387 RVA: 0x00730830 File Offset: 0x0072EA30
		public InteractionTarget MNAGGGOBMFB(FullBodyBipedEffector LPOHBKJJIBO, InteractionSystem NKKKJBOMCID)
		{
			if (NKKKJBOMCID.tag == string.Empty || NKKKJBOMCID.tag == "SoccerKeeperReady")
			{
				foreach (InteractionTarget interactionTarget in this.PFJCPCDKALA)
				{
					if (interactionTarget.effectorType == LPOHBKJJIBO)
					{
						return interactionTarget;
					}
				}
				return null;
			}
			InteractionTarget[] pfjcpcdkala = this.PFJCPCDKALA;
			for (int i = 1; i < pfjcpcdkala.Length; i++)
			{
				InteractionTarget interactionTarget2 = pfjcpcdkala[i];
				if (interactionTarget2.effectorType == LPOHBKJJIBO && interactionTarget2.tag == NKKKJBOMCID.tag)
				{
					return interactionTarget2;
				}
			}
			return null;
		}

		// Token: 0x0600FF6C RID: 65388 RVA: 0x006AA28C File Offset: 0x006A848C
		private void NBCOCBDNKFF()
		{
			Application.OpenURL("wpn_onlyw");
		}

		// Token: 0x0600FF6D RID: 65389 RVA: 0x007308BF File Offset: 0x0072EABF
		private void JJLHNKILFIE()
		{
			Application.OpenURL("\npb_Face: ");
		}

		// Token: 0x0600FF6E RID: 65390 RVA: 0x007308CB File Offset: 0x0072EACB
		private void GJFCMMMFFGC()
		{
			Application.OpenURL("contrast");
		}

		// Token: 0x0600FF6F RID: 65391 RVA: 0x007308D8 File Offset: 0x0072EAD8
		public bool MEHJOHCHNHH(InteractionObject.WeightCurve.Type DFBHMIIPLCA)
		{
			InteractionObject.WeightCurve[] array = this.weightCurves;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i].type == DFBHMIIPLCA)
				{
					return true;
				}
			}
			InteractionObject.Multiplier[] array2 = this.multipliers;
			for (int i = 0; i < array2.Length; i += 0)
			{
				if (array2[i].result == DFBHMIIPLCA)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600FF70 RID: 65392 RVA: 0x0073092C File Offset: 0x0072EB2C
		private int PCPELLLCFOJ(InteractionObject.WeightCurve.Type PAMKFAHBGKK)
		{
			for (int i = 1; i < this.weightCurves.Length; i++)
			{
				if (this.weightCurves[i].type == PAMKFAHBGKK)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600FF71 RID: 65393 RVA: 0x0072EF1B File Offset: 0x0072D11B
		public void OnStartInteraction(InteractionSystem NKKKJBOMCID)
		{
			this.MAKEGLCIHAJ = NKKKJBOMCID;
		}

		// Token: 0x0600FF72 RID: 65394 RVA: 0x00730960 File Offset: 0x0072EB60
		public Transform HGNLEOMAEHF(FullBodyBipedEffector LPOHBKJJIBO, string ODFEKBJCFMN)
		{
			if (ODFEKBJCFMN == string.Empty || ODFEKBJCFMN == ";")
			{
				return this.PACFHBNMIEL(LPOHBKJJIBO);
			}
			for (int i = 0; i < this.PFJCPCDKALA.Length; i++)
			{
				if (this.PFJCPCDKALA[i].effectorType == LPOHBKJJIBO && this.PFJCPCDKALA[i].tag == ODFEKBJCFMN)
				{
					return this.PFJCPCDKALA[i].transform;
				}
			}
			return base.transform;
		}

		// Token: 0x0400219A RID: 8602
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		// Token: 0x0400219B RID: 8603
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		// Token: 0x0400219C RID: 8604
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		// Token: 0x0400219D RID: 8605
		public InteractionObject.WeightCurve[] weightCurves;

		// Token: 0x0400219E RID: 8606
		public InteractionObject.Multiplier[] multipliers;

		// Token: 0x0400219F RID: 8607
		public InteractionObject.InteractionEvent[] events;

		// Token: 0x040021A2 RID: 8610
		private InteractionTarget[] PFJCPCDKALA = new InteractionTarget[0];

		// Token: 0x0200048F RID: 1167
		[Serializable]
		public class InteractionEvent
		{
			// Token: 0x0600FF73 RID: 65395 RVA: 0x007309DC File Offset: 0x0072EBDC
			public void EDBHLGJLLEO(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].NAPGNHEHMLE(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].IOMBMCEPHHM(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF74 RID: 65396 RVA: 0x00730A2C File Offset: 0x0072EC2C
			public void GCGOOPPBLOG(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].FPMCDGFNHKJ(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].LJPCBICKEOG(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF75 RID: 65397 RVA: 0x00730A7C File Offset: 0x0072EC7C
			public void MLBKBIGJMOC(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].MLBKBIGJMOC(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].ADBPJNFJINP(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF76 RID: 65398 RVA: 0x00730ACC File Offset: 0x0072ECCC
			public void HEGJBPLGAJB(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].AIGOFCACEFD(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i++)
				{
					array2[i].JGNGNNMFGNF(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF77 RID: 65399 RVA: 0x00730B1C File Offset: 0x0072ED1C
			public void ADJBBEKBHCI(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].DENHANPHJNA(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].NONJKHLFECB(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF78 RID: 65400 RVA: 0x00730B6C File Offset: 0x0072ED6C
			public void GEABKCPEPKF(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].PENFNLMCIDH(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].DDBEIIEJDLG(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF79 RID: 65401 RVA: 0x00730BBC File Offset: 0x0072EDBC
			public void HMGOIOFAJHP(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].JIMMIHMODDG(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].FAIBHNJNIGO(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF7A RID: 65402 RVA: 0x00730C0C File Offset: 0x0072EE0C
			public void INHCKLDMCMM(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].LMDIFKGJCIC(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i++)
				{
					array2[i].JNJPAGDHAMB(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF7B RID: 65403 RVA: 0x00730C5C File Offset: 0x0072EE5C
			public void CLLPMACNHFE(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].LMDIFKGJCIC(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i++)
				{
					array2[i].FAIBHNJNIGO(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF7C RID: 65404 RVA: 0x00730CAC File Offset: 0x0072EEAC
			public void OBDLDKBCBLA(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].ADJBBEKBHCI(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].JGFIMJLFDFG(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF7D RID: 65405 RVA: 0x00730CFC File Offset: 0x0072EEFC
			public void KCLJMCFJOLD(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].PENFNLMCIDH(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].FAIBHNJNIGO(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF7E RID: 65406 RVA: 0x00730D4C File Offset: 0x0072EF4C
			public void MFLECKFMCFJ(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].PENFNLMCIDH(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].BEEEIFJNGBP(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF7F RID: 65407 RVA: 0x00730D9C File Offset: 0x0072EF9C
			public void LMDIFKGJCIC(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].AIJLLBGLAOK(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i++)
				{
					array2[i].DDBEIIEJDLG(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF80 RID: 65408 RVA: 0x00730DEC File Offset: 0x0072EFEC
			public void PENFNLMCIDH(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].MLBKBIGJMOC(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].IBDHFOPFBDN(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF81 RID: 65409 RVA: 0x00730E3C File Offset: 0x0072F03C
			public void LDJBMCCHDBM(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].AIGOFCACEFD(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].JGFIMJLFDFG(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF82 RID: 65410 RVA: 0x00730E8C File Offset: 0x0072F08C
			public void LIOABCCAPIN(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].PNHGEPMFPLN(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].BHJKAJCFKIL(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF83 RID: 65411 RVA: 0x00730EDC File Offset: 0x0072F0DC
			public void HHEKLEDFJMJ(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].PNHGEPMFPLN(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].PIBDKILGNIF(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF84 RID: 65412 RVA: 0x00730F2C File Offset: 0x0072F12C
			public void ODFCLCIKPBB(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].DENHANPHJNA(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i++)
				{
					array2[i].JGNGNNMFGNF(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF85 RID: 65413 RVA: 0x00730F7C File Offset: 0x0072F17C
			public void FBLDJENDDPF(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].PNHGEPMFPLN(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].FAIBHNJNIGO(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF86 RID: 65414 RVA: 0x00730FCC File Offset: 0x0072F1CC
			public void ACLGNNDFABC(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].PENFNLMCIDH(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].ADBPJNFJINP(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF87 RID: 65415 RVA: 0x0073101C File Offset: 0x0072F21C
			public void DENHANPHJNA(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].HDLMPPCNJIP(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].PLMDOONANGG(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF88 RID: 65416 RVA: 0x0073106C File Offset: 0x0072F26C
			public void DEIGFFIHMLD(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].GEABKCPEPKF(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].PBFKPOMIDKL(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF89 RID: 65417 RVA: 0x007310BC File Offset: 0x0072F2BC
			public void OPFLALHJBNC(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].OHEBLCBPPOG(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].BHJKAJCFKIL(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF8A RID: 65418 RVA: 0x0073110C File Offset: 0x0072F30C
			public void HDLMPPCNJIP(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].OHEBLCBPPOG(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].DLJNDIGFJCF(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF8B RID: 65419 RVA: 0x0073115C File Offset: 0x0072F35C
			public void AIJLLBGLAOK(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].AIJLLBGLAOK(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].KPNEFAAHFLP(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF8C RID: 65420 RVA: 0x007311AC File Offset: 0x0072F3AC
			public void LNPICDGJBBC(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].FPMCDGFNHKJ(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i++)
				{
					array2[i].HKHIFAACBHJ(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF8D RID: 65421 RVA: 0x007311FC File Offset: 0x0072F3FC
			public void HLPOLAIBMDJ(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].IPOLFDOEOLE(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].NCNBDLFENAA(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF8E RID: 65422 RVA: 0x0073124C File Offset: 0x0072F44C
			public void PNHGEPMFPLN(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].LMDIFKGJCIC(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].KPNEFAAHFLP(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF8F RID: 65423 RVA: 0x0073129C File Offset: 0x0072F49C
			public void MHHACCNILBN(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].HDLMPPCNJIP(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].CAIOAMOBIFM(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF90 RID: 65424 RVA: 0x007312EC File Offset: 0x0072F4EC
			public void LOAGJBMLADO(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i += 0)
				{
					array[i].ODIHGICDIEH(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].IOMBMCEPHHM(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF91 RID: 65425 RVA: 0x0073133C File Offset: 0x0072F53C
			public void CCBEPCGFNMK(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].IPOLFDOEOLE(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].ENLOMHIBECF(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF92 RID: 65426 RVA: 0x0073138C File Offset: 0x0072F58C
			public void KEGEEAEJPME(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].ADJBBEKBHCI(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].DLJNDIGFJCF(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF93 RID: 65427 RVA: 0x007313DC File Offset: 0x0072F5DC
			public void JIMMIHMODDG(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].PNHGEPMFPLN(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].NCNBDLFENAA(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF94 RID: 65428 RVA: 0x0073142C File Offset: 0x0072F62C
			public void FILMFKHNOKL(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].OHEBLCBPPOG(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].NONJKHLFECB(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF95 RID: 65429 RVA: 0x0073147C File Offset: 0x0072F67C
			public void HGMOKHHHPIH(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i += 0)
				{
					array[i].GNJEOJKMPHI(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i++)
				{
					array2[i].DLJNDIGFJCF(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF96 RID: 65430 RVA: 0x007314CC File Offset: 0x0072F6CC
			public void GNJEOJKMPHI(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].AIGOFCACEFD(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i++)
				{
					array2[i].HLAPNINGHGF(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF97 RID: 65431 RVA: 0x0073151C File Offset: 0x0072F71C
			public void ODIHGICDIEH(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].FPMCDGFNHKJ(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].LJPCBICKEOG(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF98 RID: 65432 RVA: 0x0073156C File Offset: 0x0072F76C
			public void IPOLFDOEOLE(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].LOAGJBMLADO(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].IBDHFOPFBDN(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF9A RID: 65434 RVA: 0x007315BC File Offset: 0x0072F7BC
			public void IIAJPFEFAPA(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].AIGOFCACEFD(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i++)
				{
					array2[i].OCDGJANKGJD(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF9B RID: 65435 RVA: 0x0073160C File Offset: 0x0072F80C
			public void ODJIDONHMAL(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].FPMCDGFNHKJ(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i += 0)
				{
					array2[i].IOMBMCEPHHM(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF9C RID: 65436 RVA: 0x0073165C File Offset: 0x0072F85C
			public void BELEOILCPFJ(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].LDJBMCCHDBM(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 1; i < array2.Length; i++)
				{
					array2[i].HLAPNINGHGF(JAHNHOCNJGM);
				}
			}

			// Token: 0x0600FF9D RID: 65437 RVA: 0x007316AC File Offset: 0x0072F8AC
			public void FKLEBNHLECO(Transform JAHNHOCNJGM)
			{
				InteractionObject.AnimatorEvent[] array = this.animations;
				for (int i = 1; i < array.Length; i++)
				{
					array[i].AIJLLBGLAOK(this.pickUp);
				}
				InteractionObject.Message[] array2 = this.messages;
				for (int i = 0; i < array2.Length; i += 0)
				{
					array2[i].PBFKPOMIDKL(JAHNHOCNJGM);
				}
			}

			// Token: 0x040021A3 RID: 8611
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			// Token: 0x040021A4 RID: 8612
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			// Token: 0x040021A5 RID: 8613
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			// Token: 0x040021A6 RID: 8614
			[Tooltip("The animations called on this event.")]
			public InteractionObject.AnimatorEvent[] animations;

			// Token: 0x040021A7 RID: 8615
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public InteractionObject.Message[] messages;
		}

		// Token: 0x02000490 RID: 1168
		[Serializable]
		public class Message
		{
			// Token: 0x0600FF9E RID: 65438 RVA: 0x007316FC File Offset: 0x0072F8FC
			public void KHBDKCIGBAG(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "ComeHere")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FF9F RID: 65439 RVA: 0x00731750 File Offset: 0x0072F950
			public void NDINKPKABKE(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "Attempting to remove texture that was not allocated: {0}")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFA0 RID: 65440 RVA: 0x007317A4 File Offset: 0x0072F9A4
			public void KPNEFAAHFLP(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "Windmill")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFA1 RID: 65441 RVA: 0x007317F8 File Offset: 0x0072F9F8
			public void LJPCBICKEOG(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "_RandomTexture")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFA2 RID: 65442 RVA: 0x0073184C File Offset: 0x0072FA4C
			public void KHFNNNLJGAJ(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "gi_fridge")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFA3 RID: 65443 RVA: 0x007318A0 File Offset: 0x0072FAA0
			public void HGIMLIIOFDD(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "lut.ogg")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFA4 RID: 65444 RVA: 0x007318F4 File Offset: 0x0072FAF4
			public void BEEEIFJNGBP(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "Add random value")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFA5 RID: 65445 RVA: 0x00731948 File Offset: 0x0072FB48
			public void JGNGNNMFGNF(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "ProneIdle")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFA6 RID: 65446 RVA: 0x0073199C File Offset: 0x0072FB9C
			public void JHIDDKMIHPL(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "fchair")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFA7 RID: 65447 RVA: 0x007319F0 File Offset: 0x0072FBF0
			public void DLJNDIGFJCF(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "{0} FPS")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFA8 RID: 65448 RVA: 0x00731A44 File Offset: 0x0072FC44
			public void NOFLGOGPLJI(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "hip")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFA9 RID: 65449 RVA: 0x00731A98 File Offset: 0x0072FC98
			public void OCDGJANKGJD(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == " \"{0}\"")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFAA RID: 65450 RVA: 0x00731AEC File Offset: 0x0072FCEC
			public void JNJPAGDHAMB(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFAB RID: 65451 RVA: 0x00731B40 File Offset: 0x0072FD40
			public void IOMBMCEPHHM(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "error.wav")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFAC RID: 65452 RVA: 0x00731B94 File Offset: 0x0072FD94
			public void PIBDKILGNIF(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "wgt_small.dat")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFAD RID: 65453 RVA: 0x00731BE8 File Offset: 0x0072FDE8
			public void ODDNEIGOAFM(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "error")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFAE RID: 65454 RVA: 0x00731C3C File Offset: 0x0072FE3C
			public void NIMILHBDFIH(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "FPSAiming with Recoil needs FBBIK solver iteration count to be at least 1 to maintain accuracy.")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFAF RID: 65455 RVA: 0x00731C90 File Offset: 0x0072FE90
			public void OEMBBCNIIIC(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "Torso")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFB0 RID: 65456 RVA: 0x00731CE4 File Offset: 0x0072FEE4
			public void BHJKAJCFKIL(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "Pistol")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFB1 RID: 65457 RVA: 0x00731D38 File Offset: 0x0072FF38
			public void PBFKPOMIDKL(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "IceHockey Pass Right")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFB2 RID: 65458 RVA: 0x00731D8C File Offset: 0x0072FF8C
			public void JGFIMJLFDFG(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "<color='#003000'>+{0} {1}</color>")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFB3 RID: 65459 RVA: 0x00731DE0 File Offset: 0x0072FFE0
			public void CAIOAMOBIFM(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center).")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFB4 RID: 65460 RVA: 0x00731E34 File Offset: 0x00730034
			public void FHCPPIAILJK(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "Dealer Idle")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFB5 RID: 65461 RVA: 0x00731E88 File Offset: 0x00730088
			public void HKHIFAACBHJ(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "===== ObscuredStringTest =====\n")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFB6 RID: 65462 RVA: 0x00731EDC File Offset: 0x007300DC
			public void KCICBEKNFPM(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "Clavicle")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFB7 RID: 65463 RVA: 0x00731F30 File Offset: 0x00730130
			public void ENLOMHIBECF(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "Citates.xml")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFB8 RID: 65464 RVA: 0x00731F84 File Offset: 0x00730184
			public void OBKINCKKJFG(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "post_msg7")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFB9 RID: 65465 RVA: 0x00731FD8 File Offset: 0x007301D8
			public void BIMOCCBPJAJ(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "MotorbikeBackwardSittingCheer")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFBA RID: 65466 RVA: 0x0073202C File Offset: 0x0073022C
			public void HIEHOCCBKMM(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "sunshine_ShadowCoordDepthRayU")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFBB RID: 65467 RVA: 0x00732080 File Offset: 0x00730280
			public void ADBPJNFJINP(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFBC RID: 65468 RVA: 0x007320D4 File Offset: 0x007302D4
			public void HLAPNINGHGF(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "ShotgunReadyFire")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFBD RID: 65469 RVA: 0x00732128 File Offset: 0x00730328
			public void PLMDOONANGG(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == " S:")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFBE RID: 65470 RVA: 0x0073217C File Offset: 0x0073037C
			public void IBDHFOPFBDN(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "usr_inf_a4")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFBF RID: 65471 RVA: 0x007321D0 File Offset: 0x007303D0
			public void DMDGDOHIAFA(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "UnityEngine.GameObject")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFC1 RID: 65473 RVA: 0x00732224 File Offset: 0x00730424
			public void NCNBDLFENAA(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == " is not supported on this platform!")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFC2 RID: 65474 RVA: 0x00732278 File Offset: 0x00730478
			public void ILMJHKPOABP(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "DataSize ")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFC3 RID: 65475 RVA: 0x007322CC File Offset: 0x007304CC
			public void NONJKHLFECB(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "LocationGui.getI.backLockImage.rectTransform is null")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.DontRequireReceiver);
			}

			// Token: 0x0600FFC4 RID: 65476 RVA: 0x00732320 File Offset: 0x00730520
			public void DDBEIIEJDLG(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "Fish is init!")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x0600FFC5 RID: 65477 RVA: 0x00732374 File Offset: 0x00730574
			public void FAIBHNJNIGO(Transform JAHNHOCNJGM)
			{
				if (this.recipient == null)
				{
					return;
				}
				if (this.function == string.Empty || this.function == "_RandomTexture")
				{
					return;
				}
				this.recipient.SendMessage(this.function, JAHNHOCNJGM, SendMessageOptions.RequireReceiver);
			}

			// Token: 0x040021A8 RID: 8616
			[Tooltip("The name of the function called.")]
			public string function;

			// Token: 0x040021A9 RID: 8617
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			// Token: 0x040021AA RID: 8618
			private static string empty = "";
		}

		// Token: 0x02000491 RID: 1169
		[Serializable]
		public class AnimatorEvent
		{
			// Token: 0x0600FFC7 RID: 65479 RVA: 0x007323D4 File Offset: 0x007305D4
			private void DEIGFFIHMLD(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "Crouch")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 1214f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFC8 RID: 65480 RVA: 0x0073243C File Offset: 0x0073063C
			public void GEABKCPEPKF(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = false;
					}
					this.BELEOILCPFJ(this.animator);
				}
				if (this.animation != null)
				{
					this.LIOABCCAPIN(this.animation);
				}
			}

			// Token: 0x0600FFC9 RID: 65481 RVA: 0x0073248C File Offset: 0x0073068C
			private void HLPOLAIBMDJ(Animator KCLACNEILLB)
			{
				if (this.animationState == "{x}")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 1261f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFCA RID: 65482 RVA: 0x007324EC File Offset: 0x007306EC
			private void IIAJPFEFAPA(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "RunBackRight")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 39f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFCB RID: 65483 RVA: 0x00732554 File Offset: 0x00730754
			public void LOAGJBMLADO(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = false;
					}
					this.MLBKBIGJMOC(this.animator);
				}
				if (this.animation != null)
				{
					this.INHCKLDMCMM(this.animation);
				}
			}

			// Token: 0x0600FFCC RID: 65484 RVA: 0x007325A4 File Offset: 0x007307A4
			public void JIMMIHMODDG(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = false;
					}
					this.EDBHLGJLLEO(this.animator);
				}
				if (this.animation != null)
				{
					this.ODJIDONHMAL(this.animation);
				}
			}

			// Token: 0x0600FFCD RID: 65485 RVA: 0x007325F4 File Offset: 0x007307F4
			private void HEGJBPLGAJB(Animator KCLACNEILLB)
			{
				if (this.animationState == " on effect ")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 837f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFCE RID: 65486 RVA: 0x00732654 File Offset: 0x00730854
			public void PNHGEPMFPLN(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = true;
					}
					this.IJPEAAGMDPA(this.animator);
				}
				if (this.animation != null)
				{
					this.LNPICDGJBBC(this.animation);
				}
			}

			// Token: 0x0600FFCF RID: 65487 RVA: 0x007326A4 File Offset: 0x007308A4
			public void AIGOFCACEFD(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = true;
					}
					this.GBPGLHBDLNK(this.animator);
				}
				if (this.animation != null)
				{
					this.KCLJMCFJOLD(this.animation);
				}
			}

			// Token: 0x0600FFD0 RID: 65488 RVA: 0x007326F4 File Offset: 0x007308F4
			public void ODIHGICDIEH(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = true;
					}
					this.OBDLDKBCBLA(this.animator);
				}
				if (this.animation != null)
				{
					this.LNPICDGJBBC(this.animation);
				}
			}

			// Token: 0x0600FFD1 RID: 65489 RVA: 0x00732744 File Offset: 0x00730944
			private void BELEOILCPFJ(Animator KCLACNEILLB)
			{
				if (this.animationState == " ")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 530f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFD2 RID: 65490 RVA: 0x007327A4 File Offset: 0x007309A4
			private void MMIHILPCCKL(Animator KCLACNEILLB)
			{
				if (this.animationState == "gi_nl1")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 1694f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFD3 RID: 65491 RVA: 0x00732804 File Offset: 0x00730A04
			private void HHEKLEDFJMJ(Animator KCLACNEILLB)
			{
				if (this.animationState == "'>")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 998f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFD4 RID: 65492 RVA: 0x00732864 File Offset: 0x00730A64
			private void ACLGNNDFABC(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "https://groups.google.com/forum/#!forum/final-ik")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 1120f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFD5 RID: 65493 RVA: 0x007328CC File Offset: 0x00730ACC
			public void FPMCDGFNHKJ(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = false;
					}
					this.GBPGLHBDLNK(this.animator);
				}
				if (this.animation != null)
				{
					this.KCLJMCFJOLD(this.animation);
				}
			}

			// Token: 0x0600FFD6 RID: 65494 RVA: 0x0073291C File Offset: 0x00730B1C
			private void NCFFCNHCOOM(Animator KCLACNEILLB)
			{
				if (this.animationState == "WRINKLE_MAPS")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 783f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFD7 RID: 65495 RVA: 0x0073297C File Offset: 0x00730B7C
			public void MLBKBIGJMOC(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = false;
					}
					this.MLBKBIGJMOC(this.animator);
				}
				if (this.animation != null)
				{
					this.MLBKBIGJMOC(this.animation);
				}
			}

			// Token: 0x0600FFD8 RID: 65496 RVA: 0x007329CC File Offset: 0x00730BCC
			private void GCGOOPPBLOG(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "fishsplash{0}.ogg")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 1972f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFD9 RID: 65497 RVA: 0x00732A34 File Offset: 0x00730C34
			private void MFLECKFMCFJ(Animator KCLACNEILLB)
			{
				if (this.animationState == "\n")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 1329f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFDA RID: 65498 RVA: 0x00732A94 File Offset: 0x00730C94
			private void OBDLDKBCBLA(Animator KCLACNEILLB)
			{
				if (this.animationState == "CrouchStrafeRight")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 1435f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFDB RID: 65499 RVA: 0x00732AF4 File Offset: 0x00730CF4
			public void LDJBMCCHDBM(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = false;
					}
					this.MMIHILPCCKL(this.animator);
				}
				if (this.animation != null)
				{
					this.DEIGFFIHMLD(this.animation);
				}
			}

			// Token: 0x0600FFDC RID: 65500 RVA: 0x00732B44 File Offset: 0x00730D44
			public void HDLMPPCNJIP(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = false;
					}
					this.GJAINGHPLDJ(this.animator);
				}
				if (this.animation != null)
				{
					this.PAEKGHALKJK(this.animation);
				}
			}

			// Token: 0x0600FFDD RID: 65501 RVA: 0x00732B94 File Offset: 0x00730D94
			public void IPOLFDOEOLE(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = true;
					}
					this.GADKOHJMIJF(this.animator);
				}
				if (this.animation != null)
				{
					this.LNPICDGJBBC(this.animation);
				}
			}

			// Token: 0x0600FFDE RID: 65502 RVA: 0x00732BE4 File Offset: 0x00730DE4
			public void DENHANPHJNA(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = true;
					}
					this.BELEOILCPFJ(this.animator);
				}
				if (this.animation != null)
				{
					this.HGMOKHHHPIH(this.animation);
				}
			}

			// Token: 0x0600FFDF RID: 65503 RVA: 0x00732C34 File Offset: 0x00730E34
			private void HMGOIOFAJHP(Animator KCLACNEILLB)
			{
				if (this.animationState == "_TrStartYou.ogg")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 1150f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFE0 RID: 65504 RVA: 0x00732C94 File Offset: 0x00730E94
			private void GBPGLHBDLNK(Animator KCLACNEILLB)
			{
				if (this.animationState == "IdleSad")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 344f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFE1 RID: 65505 RVA: 0x00732CF4 File Offset: 0x00730EF4
			private void CCBEPCGFNMK(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "StrafeRunRight")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 1271f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFE2 RID: 65506 RVA: 0x00732D5C File Offset: 0x00730F5C
			private void MLBKBIGJMOC(Animator KCLACNEILLB)
			{
				if (this.animationState == "")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 0f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFE3 RID: 65507 RVA: 0x00732DBC File Offset: 0x00730FBC
			private void GJAINGHPLDJ(Animator KCLACNEILLB)
			{
				if (this.animationState == "_HSV")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 715f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFE4 RID: 65508 RVA: 0x00732E1C File Offset: 0x0073101C
			public void PENFNLMCIDH(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = false;
					}
					this.JFJKAAOEPLA(this.animator);
				}
				if (this.animation != null)
				{
					this.MLBKBIGJMOC(this.animation);
				}
			}

			// Token: 0x0600FFE5 RID: 65509 RVA: 0x00732E6C File Offset: 0x0073106C
			private void MHHACCNILBN(Animator KCLACNEILLB)
			{
				if (this.animationState == " R ")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 1165f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFE6 RID: 65510 RVA: 0x00732ECC File Offset: 0x007310CC
			private void IFOPKDJIAAB(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "Curve")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 952f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFE7 RID: 65511 RVA: 0x00732F34 File Offset: 0x00731134
			private void HGMOKHHHPIH(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "/")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 108f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFE8 RID: 65512 RVA: 0x00732F9C File Offset: 0x0073119C
			private void KCLJMCFJOLD(Animation IFEHIIFMFGA)
			{
				if (this.animationState == ": ")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 783f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFE9 RID: 65513 RVA: 0x00733004 File Offset: 0x00731204
			private void LIOABCCAPIN(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "Loot")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 785f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFEA RID: 65514 RVA: 0x0073306C File Offset: 0x0073126C
			private void FBLDJENDDPF(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "root")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 644f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFEB RID: 65515 RVA: 0x007330D4 File Offset: 0x007312D4
			public void OHEBLCBPPOG(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = true;
					}
					this.EDBHLGJLLEO(this.animator);
				}
				if (this.animation != null)
				{
					this.ODJIDONHMAL(this.animation);
				}
			}

			// Token: 0x0600FFEC RID: 65516 RVA: 0x00733124 File Offset: 0x00731324
			private void FKLEBNHLECO(Animator KCLACNEILLB)
			{
				if (this.animationState == "autherror")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 20f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFED RID: 65517 RVA: 0x00733184 File Offset: 0x00731384
			private void JFJKAAOEPLA(Animator KCLACNEILLB)
			{
				if (this.animationState == " ms")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 70f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFEE RID: 65518 RVA: 0x007331E4 File Offset: 0x007313E4
			private void EDBHLGJLLEO(Animator KCLACNEILLB)
			{
				if (this.animationState == "SoccerRun")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 542f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFEF RID: 65519 RVA: 0x00733244 File Offset: 0x00731444
			private void IJPEAAGMDPA(Animator KCLACNEILLB)
			{
				if (this.animationState == "_Overlay")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 1982f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFF0 RID: 65520 RVA: 0x007332A4 File Offset: 0x007314A4
			private void FDFLNPIHMCB(Animator KCLACNEILLB)
			{
				if (this.animationState == "WizardEyeBeam")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 841f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFF1 RID: 65521 RVA: 0x00733304 File Offset: 0x00731504
			private void FILMFKHNOKL(Animator KCLACNEILLB)
			{
				if (this.animationState == "Cloth_01.wav")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 1604f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFF2 RID: 65522 RVA: 0x00733364 File Offset: 0x00731564
			private void MLBKBIGJMOC(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 0f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFF3 RID: 65523 RVA: 0x007333CC File Offset: 0x007315CC
			private void KCAHBPPMDMP(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "OfficeSittingReadingLeanBack")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 1695f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFF4 RID: 65524 RVA: 0x00733434 File Offset: 0x00731634
			private void ODJIDONHMAL(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 351f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFF5 RID: 65525 RVA: 0x0073349C File Offset: 0x0073169C
			public void LMDIFKGJCIC(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = true;
					}
					this.FKLEBNHLECO(this.animator);
				}
				if (this.animation != null)
				{
					this.FBLDJENDDPF(this.animation);
				}
			}

			// Token: 0x0600FFF6 RID: 65526 RVA: 0x007334EC File Offset: 0x007316EC
			private void ODFCLCIKPBB(Animator KCLACNEILLB)
			{
				if (this.animationState == "name")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 447f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFF7 RID: 65527 RVA: 0x0073354C File Offset: 0x0073174C
			private void GADKOHJMIJF(Animator KCLACNEILLB)
			{
				if (this.animationState == "Missing shader in ")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 1111f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFF8 RID: 65528 RVA: 0x007335AC File Offset: 0x007317AC
			private void CLLPMACNHFE(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "1 Hand Sword Jab ready strafe left")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 1329f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFF9 RID: 65529 RVA: 0x00733614 File Offset: 0x00731814
			private void PAEKGHALKJK(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "\n<color='#{0}'>+{2} '{1}'</color> ")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 1737f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFFA RID: 65530 RVA: 0x0073367C File Offset: 0x0073187C
			private void EBHMABNNGDJ(Animator KCLACNEILLB)
			{
				if (this.animationState == "KatanaReady")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 779f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x0600FFFB RID: 65531 RVA: 0x007336DC File Offset: 0x007318DC
			public void GNJEOJKMPHI(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = true;
					}
					this.IJPEAAGMDPA(this.animator);
				}
				if (this.animation != null)
				{
					this.KCAHBPPMDMP(this.animation);
				}
			}

			// Token: 0x0600FFFC RID: 65532 RVA: 0x0073372C File Offset: 0x0073192C
			private void LNPICDGJBBC(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "206000")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 409f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFFD RID: 65533 RVA: 0x00733794 File Offset: 0x00731994
			private void INHCKLDMCMM(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "loc_")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 1078f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x0600FFFF RID: 65535 RVA: 0x00733810 File Offset: 0x00731A10
			private void KEGEEAEJPME(Animation IFEHIIFMFGA)
			{
				if (this.animationState == "{0}|{1}|{2}")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					IFEHIIFMFGA[this.animationState].normalizedTime = 1531f;
				}
				IFEHIIFMFGA[this.animationState].layer = this.layer;
				IFEHIIFMFGA.CrossFade(this.animationState, this.crossfadeTime);
			}

			// Token: 0x06010000 RID: 65536 RVA: 0x00733878 File Offset: 0x00731A78
			private void OPFLALHJBNC(Animator KCLACNEILLB)
			{
				if (this.animationState == "#02C85F")
				{
					return;
				}
				if (this.resetNormalizedTime)
				{
					KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer, 892f);
					return;
				}
				KCLACNEILLB.CrossFade(this.animationState, this.crossfadeTime, this.layer);
			}

			// Token: 0x06010001 RID: 65537 RVA: 0x007338D8 File Offset: 0x00731AD8
			public void ADJBBEKBHCI(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = false;
					}
					this.FILMFKHNOKL(this.animator);
				}
				if (this.animation != null)
				{
					this.KCLJMCFJOLD(this.animation);
				}
			}

			// Token: 0x06010002 RID: 65538 RVA: 0x00733928 File Offset: 0x00731B28
			public void NAPGNHEHMLE(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = false;
					}
					this.NCFFCNHCOOM(this.animator);
				}
				if (this.animation != null)
				{
					this.LNPICDGJBBC(this.animation);
				}
			}

			// Token: 0x06010003 RID: 65539 RVA: 0x00733978 File Offset: 0x00731B78
			public void AIJLLBGLAOK(bool OPCBNCDLKDL)
			{
				if (this.animator != null)
				{
					if (OPCBNCDLKDL)
					{
						this.animator.applyRootMotion = false;
					}
					this.MMIHILPCCKL(this.animator);
				}
				if (this.animation != null)
				{
					this.KCLJMCFJOLD(this.animation);
				}
			}

			// Token: 0x040021AB RID: 8619
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			// Token: 0x040021AC RID: 8620
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			// Token: 0x040021AD RID: 8621
			[Tooltip("The name of the animation state.")]
			public string animationState;

			// Token: 0x040021AE RID: 8622
			[Tooltip("The crossfading time.")]
			public float crossfadeTime = 0.3f;

			// Token: 0x040021AF RID: 8623
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			// Token: 0x040021B0 RID: 8624
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			// Token: 0x040021B1 RID: 8625
			private static string empty = "";
		}

		// Token: 0x02000492 RID: 1170
		[Serializable]
		public class WeightCurve
		{
			// Token: 0x06010005 RID: 65541 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float JJGLMHOAGCF(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010007 RID: 65543 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float IIEICEHEDOC(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010008 RID: 65544 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float IJKKMHJBNLP(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010009 RID: 65545 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float LGOPFACOOOJ(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x0601000A RID: 65546 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float PKODLCIPMIH(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x0601000B RID: 65547 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float OBCLKAHILFP(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x0601000C RID: 65548 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float GPOKKEHIOHL(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x0601000D RID: 65549 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float DJMIEGBPJBA(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x0601000E RID: 65550 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float HIFDPBABLJH(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x0601000F RID: 65551 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float BLIABANFOLH(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010010 RID: 65552 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float KENMLGLFLPC(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010011 RID: 65553 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float CBFNJMNGGMJ(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010012 RID: 65554 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float OHAILPMPONE(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010013 RID: 65555 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float GHIPGCPFAGB(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010014 RID: 65556 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float AGNFEECCLLG(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010015 RID: 65557 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float CJACPNIPIHD(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010016 RID: 65558 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float KGMBKEHCKEI(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010017 RID: 65559 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float ACJFNKKIFFH(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010018 RID: 65560 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float MNMJECFLCJB(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x06010019 RID: 65561 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float ICAINKJKDJM(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x0601001A RID: 65562 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float PBACKCDOFAO(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x0601001B RID: 65563 RVA: 0x007339D4 File Offset: 0x00731BD4
			public float JEPKJHMPHOC(float LHGMAMKOCGI)
			{
				return this.curve.Evaluate(LHGMAMKOCGI);
			}

			// Token: 0x040021B2 RID: 8626
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type type;

			// Token: 0x040021B3 RID: 8627
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			// Token: 0x02000493 RID: 1171
			[Serializable]
			public enum Type
			{
				// Token: 0x040021B5 RID: 8629
				PositionWeight,
				// Token: 0x040021B6 RID: 8630
				RotationWeight,
				// Token: 0x040021B7 RID: 8631
				PositionOffsetX,
				// Token: 0x040021B8 RID: 8632
				PositionOffsetY,
				// Token: 0x040021B9 RID: 8633
				PositionOffsetZ,
				// Token: 0x040021BA RID: 8634
				Pull,
				// Token: 0x040021BB RID: 8635
				Reach,
				// Token: 0x040021BC RID: 8636
				RotateBoneWeight,
				// Token: 0x040021BD RID: 8637
				Push,
				// Token: 0x040021BE RID: 8638
				PushParent,
				// Token: 0x040021BF RID: 8639
				PoserWeight
			}
		}

		// Token: 0x02000494 RID: 1172
		[Serializable]
		public class Multiplier
		{
			// Token: 0x0601001C RID: 65564 RVA: 0x007339E2 File Offset: 0x00731BE2
			public float IIEICEHEDOC(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.PKODLCIPMIH(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x0601001D RID: 65565 RVA: 0x007339F2 File Offset: 0x00731BF2
			public float ACJFNKKIFFH(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.CBFNJMNGGMJ(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x0601001E RID: 65566 RVA: 0x00733A02 File Offset: 0x00731C02
			public float DJMIEGBPJBA(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.JEPKJHMPHOC(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x0601001F RID: 65567 RVA: 0x00733A12 File Offset: 0x00731C12
			public float OHAILPMPONE(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.HIFDPBABLJH(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x06010020 RID: 65568 RVA: 0x00733A22 File Offset: 0x00731C22
			public float PKODLCIPMIH(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.ACJFNKKIFFH(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x06010021 RID: 65569 RVA: 0x00733A12 File Offset: 0x00731C12
			public float PBACKCDOFAO(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.HIFDPBABLJH(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x06010022 RID: 65570 RVA: 0x00733A32 File Offset: 0x00731C32
			public float CBFNJMNGGMJ(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.IIEICEHEDOC(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x06010024 RID: 65572 RVA: 0x00733A55 File Offset: 0x00731C55
			public float GHIPGCPFAGB(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.GPOKKEHIOHL(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x06010025 RID: 65573 RVA: 0x00733A65 File Offset: 0x00731C65
			public float ICAINKJKDJM(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.OHAILPMPONE(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x06010026 RID: 65574 RVA: 0x00733A75 File Offset: 0x00731C75
			public float KGMBKEHCKEI(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.DJMIEGBPJBA(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x06010027 RID: 65575 RVA: 0x00733A85 File Offset: 0x00731C85
			public float LGOPFACOOOJ(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.PBACKCDOFAO(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x06010028 RID: 65576 RVA: 0x00733A55 File Offset: 0x00731C55
			public float MNMJECFLCJB(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.GPOKKEHIOHL(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x06010029 RID: 65577 RVA: 0x00733A65 File Offset: 0x00731C65
			public float JJGLMHOAGCF(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.OHAILPMPONE(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x0601002A RID: 65578 RVA: 0x00733A95 File Offset: 0x00731C95
			public float JEPKJHMPHOC(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.MNMJECFLCJB(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x0601002B RID: 65579 RVA: 0x00733A65 File Offset: 0x00731C65
			public float CJACPNIPIHD(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.OHAILPMPONE(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x0601002C RID: 65580 RVA: 0x00733AA5 File Offset: 0x00731CA5
			public float KENMLGLFLPC(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.OBCLKAHILFP(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x0601002D RID: 65581 RVA: 0x00733AB5 File Offset: 0x00731CB5
			public float OBCLKAHILFP(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.AGNFEECCLLG(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x0601002E RID: 65582 RVA: 0x00733AC5 File Offset: 0x00731CC5
			public float BLIABANFOLH(InteractionObject.WeightCurve IDCKKGNEABD, float LHGMAMKOCGI)
			{
				return IDCKKGNEABD.BLIABANFOLH(LHGMAMKOCGI) * this.multiplier;
			}

			// Token: 0x040021C0 RID: 8640
			[Tooltip("The curve type to multiply.")]
			public InteractionObject.WeightCurve.Type curve;

			// Token: 0x040021C1 RID: 8641
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier = 1f;

			// Token: 0x040021C2 RID: 8642
			[Tooltip("The resulting value will be applied to this channel.")]
			public InteractionObject.WeightCurve.Type result;
		}
	}
}
