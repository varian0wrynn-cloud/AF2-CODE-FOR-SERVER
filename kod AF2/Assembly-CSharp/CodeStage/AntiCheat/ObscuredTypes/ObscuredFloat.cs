using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000582 RID: 1410
	[Serializable]
	public struct ObscuredFloat : IEquatable<ObscuredFloat>, IFormattable
	{
		// Token: 0x0601276C RID: 75628 RVA: 0x00812042 File Offset: 0x00810242
		public static float DHPGAJEHAFD(int DCCPCBLODIG)
		{
			return ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG, ObscuredFloat.cryptoKey);
		}

		// Token: 0x0601276D RID: 75629 RVA: 0x00812050 File Offset: 0x00810250
		public void KJBOPMELKGK()
		{
			float dccpcblodig = this.AGABNIKJNAA();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(122, 11);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredFloat.OJGHFAEGCDA(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601276E RID: 75630 RVA: 0x00812093 File Offset: 0x00810293
		public static void EDHLDKJEBNF(int JODDIMFACHN)
		{
			ObscuredFloat.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601276F RID: 75631 RVA: 0x0081209B File Offset: 0x0081029B
		public bool FFGIMBGINCG(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredFloat && this.IAKGECBDHMF((ObscuredFloat)MBKPMBPLIJN);
		}

		// Token: 0x06012770 RID: 75632 RVA: 0x008120B3 File Offset: 0x008102B3
		public void AHJPPPIODAB()
		{
			if (this.currentCryptoKey != ObscuredFloat.cryptoKey)
			{
				this.hiddenValue = ObscuredFloat.AFGMNANHHBF(this.AGABNIKJNAA(), ObscuredFloat.cryptoKey);
				this.currentCryptoKey = ObscuredFloat.cryptoKey;
			}
		}

		// Token: 0x06012771 RID: 75633 RVA: 0x008120E4 File Offset: 0x008102E4
		public static ObscuredFloat DPCDNMHLOJF(ObscuredFloat NFKFMIIAKFN)
		{
			float dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1f;
			NFKFMIIAKFN.hiddenValue = ObscuredFloat.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = true;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = false;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x06012772 RID: 75634 RVA: 0x00812134 File Offset: 0x00810334
		public string JCAONLDGMCJ()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012773 RID: 75635 RVA: 0x00812150 File Offset: 0x00810350
		public static ObscuredFloat BEKOICIMIFO(ObscuredFloat NFKFMIIAKFN)
		{
			float dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 549f;
			NFKFMIIAKFN.hiddenValue = ObscuredFloat.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = false;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = false;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x06012775 RID: 75637 RVA: 0x008121AC File Offset: 0x008103AC
		public float FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012776 RID: 75638 RVA: 0x008121B4 File Offset: 0x008103B4
		public static ObscuredFloat AJMPAOCEPCA(float DCCPCBLODIG)
		{
			return new ObscuredFloat(DCCPCBLODIG);
		}

		// Token: 0x06012777 RID: 75639 RVA: 0x00812093 File Offset: 0x00810293
		public static void CENPPCOOGIL(int JODDIMFACHN)
		{
			ObscuredFloat.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012778 RID: 75640 RVA: 0x008121BC File Offset: 0x008103BC
		public string GOLHDFBFJFI(IFormatProvider MCGFPOIAPGJ)
		{
			return this.AGABNIKJNAA().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012779 RID: 75641 RVA: 0x008121D8 File Offset: 0x008103D8
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x0601277A RID: 75642 RVA: 0x008121F4 File Offset: 0x008103F4
		public string ToString(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x0601277B RID: 75643 RVA: 0x00812214 File Offset: 0x00810414
		private float AGABNIKJNAA()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredFloat.cryptoKey;
				this.hiddenValue = ObscuredFloat.LMDHOACGCGM(1779f);
				this.fakeValue = 644f;
				this.fakeValueActive = true;
				this.inited = false;
				return 966f;
			}
			ObscuredFloat.FEAPFFLGINB feapfflginb = default(ObscuredFloat.FEAPFFLGINB);
			feapfflginb.HDHKNPPNGGA = this.hiddenValue;
			feapfflginb.LMGJKOMFCFC ^= this.currentCryptoKey;
			float ccaimgaffld = feapfflginb.CCAIMGAFFLD;
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && Math.Abs(ccaimgaffld - this.fakeValue) > ObscuredCheatingDetector.GGOEIHCJEHP().floatEpsilon)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return ccaimgaffld;
		}

		// Token: 0x0601277C RID: 75644 RVA: 0x008122C8 File Offset: 0x008104C8
		public static ObscuredFloat IDIADEICPFJ(ObscuredFloat NFKFMIIAKFN)
		{
			float dccpcblodig = NFKFMIIAKFN.AGABNIKJNAA() - 75f;
			NFKFMIIAKFN.hiddenValue = ObscuredFloat.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = false;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = false;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x0601277D RID: 75645 RVA: 0x00812318 File Offset: 0x00810518
		public static int ALHMMAGENAF(float DCCPCBLODIG, int JMBKDINHDLO)
		{
			ObscuredFloat.FEAPFFLGINB feapfflginb = default(ObscuredFloat.FEAPFFLGINB);
			feapfflginb.CCAIMGAFFLD = DCCPCBLODIG;
			feapfflginb.LMGJKOMFCFC ^= JMBKDINHDLO;
			return feapfflginb.LMGJKOMFCFC;
		}

		// Token: 0x0601277E RID: 75646 RVA: 0x0081234C File Offset: 0x0081054C
		public int MCCJEFAFGNM()
		{
			this.AHJPPPIODAB();
			return new ObscuredFloat.FEAPFFLGINB
			{
				HDHKNPPNGGA = this.hiddenValue
			}.LMGJKOMFCFC;
		}

		// Token: 0x0601277F RID: 75647 RVA: 0x0081237C File Offset: 0x0081057C
		public int KGAFKNELBAK()
		{
			this.HNHCOGLEBEH();
			return new ObscuredFloat.FEAPFFLGINB
			{
				HDHKNPPNGGA = this.hiddenValue
			}.LMGJKOMFCFC;
		}

		// Token: 0x06012780 RID: 75648 RVA: 0x008123AC File Offset: 0x008105AC
		public void LABFCHOFAMC(int LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = new ObscuredFloat.FEAPFFLGINB
			{
				LMGJKOMFCFC = LDKMOLEEDIL
			}.HDHKNPPNGGA;
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
			{
				this.fakeValue = this.KJBLLHBIHIL();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012781 RID: 75649 RVA: 0x008123FE File Offset: 0x008105FE
		public void HNHCOGLEBEH()
		{
			if (this.currentCryptoKey != ObscuredFloat.cryptoKey)
			{
				this.hiddenValue = ObscuredFloat.OJGHFAEGCDA(this.KJBLLHBIHIL(), ObscuredFloat.cryptoKey);
				this.currentCryptoKey = ObscuredFloat.cryptoKey;
			}
		}

		// Token: 0x06012782 RID: 75650 RVA: 0x00812430 File Offset: 0x00810630
		public int OMBPNCLIJGA()
		{
			return this.KOGNLJBGPCP().GetHashCode();
		}

		// Token: 0x06012783 RID: 75651 RVA: 0x0081244C File Offset: 0x0081064C
		private float NNDDLHNEONC()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredFloat.cryptoKey;
				this.hiddenValue = ObscuredFloat.LMDHOACGCGM(467f);
				this.fakeValue = 819f;
				this.fakeValueActive = false;
				this.inited = true;
				return 1531f;
			}
			ObscuredFloat.FEAPFFLGINB feapfflginb = default(ObscuredFloat.FEAPFFLGINB);
			feapfflginb.HDHKNPPNGGA = this.hiddenValue;
			feapfflginb.LMGJKOMFCFC ^= this.currentCryptoKey;
			float ccaimgaffld = feapfflginb.CCAIMGAFFLD;
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && Math.Abs(ccaimgaffld - this.fakeValue) > ObscuredCheatingDetector.GGOEIHCJEHP().floatEpsilon)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return ccaimgaffld;
		}

		// Token: 0x06012784 RID: 75652 RVA: 0x00812500 File Offset: 0x00810700
		public static ObscuredFloat HIBLFIAPCJE(ObscuredFloat NFKFMIIAKFN)
		{
			float dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1f;
			NFKFMIIAKFN.hiddenValue = ObscuredFloat.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = true;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = false;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x06012785 RID: 75653 RVA: 0x00812550 File Offset: 0x00810750
		public static float EJGOOFALNFF(ObscuredFloat DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012786 RID: 75654 RVA: 0x0081255C File Offset: 0x0081075C
		private static ACTkByte4 AFGMNANHHBF(float DCCPCBLODIG, int JMBKDINHDLO)
		{
			int num = JMBKDINHDLO;
			if (num == 0)
			{
				num = ObscuredFloat.cryptoKey;
			}
			ObscuredFloat.FEAPFFLGINB feapfflginb = default(ObscuredFloat.FEAPFFLGINB);
			feapfflginb.CCAIMGAFFLD = DCCPCBLODIG;
			feapfflginb.LMGJKOMFCFC ^= num;
			return feapfflginb.HDHKNPPNGGA;
		}

		// Token: 0x06012787 RID: 75655 RVA: 0x0081259C File Offset: 0x0081079C
		public bool IAKGECBDHMF(ObscuredFloat MBKPMBPLIJN)
		{
			double num = (double)MBKPMBPLIJN.KOGNLJBGPCP();
			double obj = (double)this.NNDDLHNEONC();
			return num.Equals(obj);
		}

		// Token: 0x06012788 RID: 75656 RVA: 0x008125C4 File Offset: 0x008107C4
		public bool KAAJNHMODLF(ObscuredFloat MBKPMBPLIJN)
		{
			double num = (double)MBKPMBPLIJN.MJFIFINDLAM();
			double obj = (double)this.KOGNLJBGPCP();
			return num.Equals(obj);
		}

		// Token: 0x06012789 RID: 75657 RVA: 0x008125EA File Offset: 0x008107EA
		public static int HJMJBNIEGAM(float DCCPCBLODIG)
		{
			return ObscuredFloat.HBJHGHOKFDK(DCCPCBLODIG, ObscuredFloat.cryptoKey);
		}

		// Token: 0x0601278A RID: 75658 RVA: 0x008125EA File Offset: 0x008107EA
		public static int HBJHGHOKFDK(float DCCPCBLODIG)
		{
			return ObscuredFloat.HBJHGHOKFDK(DCCPCBLODIG, ObscuredFloat.cryptoKey);
		}

		// Token: 0x0601278B RID: 75659 RVA: 0x008125EA File Offset: 0x008107EA
		public static int LNAAECIGKKL(float DCCPCBLODIG)
		{
			return ObscuredFloat.HBJHGHOKFDK(DCCPCBLODIG, ObscuredFloat.cryptoKey);
		}

		// Token: 0x0601278C RID: 75660 RVA: 0x00812093 File Offset: 0x00810293
		public static void BBOGAEMNJJN(int JODDIMFACHN)
		{
			ObscuredFloat.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601278D RID: 75661 RVA: 0x008125F8 File Offset: 0x008107F8
		private float KJBLLHBIHIL()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredFloat.cryptoKey;
				this.hiddenValue = ObscuredFloat.LMDHOACGCGM(76f);
				this.fakeValue = 401f;
				this.fakeValueActive = true;
				this.inited = true;
				return 233f;
			}
			ObscuredFloat.FEAPFFLGINB feapfflginb = default(ObscuredFloat.FEAPFFLGINB);
			feapfflginb.HDHKNPPNGGA = this.hiddenValue;
			feapfflginb.LMGJKOMFCFC ^= this.currentCryptoKey;
			float ccaimgaffld = feapfflginb.CCAIMGAFFLD;
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && Math.Abs(ccaimgaffld - this.fakeValue) > ObscuredCheatingDetector.BLJNHIFIBDC().floatEpsilon)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return ccaimgaffld;
		}

		// Token: 0x0601278E RID: 75662 RVA: 0x008126AC File Offset: 0x008108AC
		public void IGGELCJGMBF(int LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = new ObscuredFloat.FEAPFFLGINB
			{
				LMGJKOMFCFC = LDKMOLEEDIL
			}.HDHKNPPNGGA;
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
			{
				this.fakeValue = this.NNDDLHNEONC();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x0601278F RID: 75663 RVA: 0x00812700 File Offset: 0x00810900
		public void FGOMIBCGPOB(int LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = new ObscuredFloat.FEAPFFLGINB
			{
				LMGJKOMFCFC = LDKMOLEEDIL
			}.HDHKNPPNGGA;
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				this.fakeValue = this.AGABNIKJNAA();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012790 RID: 75664 RVA: 0x008125EA File Offset: 0x008107EA
		public static int EHIJHIOIGEG(float DCCPCBLODIG)
		{
			return ObscuredFloat.HBJHGHOKFDK(DCCPCBLODIG, ObscuredFloat.cryptoKey);
		}

		// Token: 0x06012791 RID: 75665 RVA: 0x00812754 File Offset: 0x00810954
		public string GJCCJEINDDC()
		{
			return this.KOGNLJBGPCP().ToString();
		}

		// Token: 0x06012792 RID: 75666 RVA: 0x00812770 File Offset: 0x00810970
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012793 RID: 75667 RVA: 0x008121B4 File Offset: 0x008103B4
		public static ObscuredFloat GOOIABGKMHK(float DCCPCBLODIG)
		{
			return new ObscuredFloat(DCCPCBLODIG);
		}

		// Token: 0x06012794 RID: 75668 RVA: 0x0081278C File Offset: 0x0081098C
		private float KOGNLJBGPCP()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredFloat.cryptoKey;
				this.hiddenValue = ObscuredFloat.LMDHOACGCGM(1040f);
				this.fakeValue = 1246f;
				this.fakeValueActive = false;
				this.inited = false;
				return 890f;
			}
			ObscuredFloat.FEAPFFLGINB feapfflginb = default(ObscuredFloat.FEAPFFLGINB);
			feapfflginb.HDHKNPPNGGA = this.hiddenValue;
			feapfflginb.LMGJKOMFCFC ^= this.currentCryptoKey;
			float ccaimgaffld = feapfflginb.CCAIMGAFFLD;
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && Math.Abs(ccaimgaffld - this.fakeValue) > ObscuredCheatingDetector.ELOBJGIDGCP.floatEpsilon)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return ccaimgaffld;
		}

		// Token: 0x06012795 RID: 75669 RVA: 0x00812840 File Offset: 0x00810A40
		public static ObscuredFloat BHJCLHCHKFK(ObscuredFloat NFKFMIIAKFN)
		{
			float dccpcblodig = NFKFMIIAKFN.KJBLLHBIHIL() - 1302f;
			NFKFMIIAKFN.hiddenValue = ObscuredFloat.OJGHFAEGCDA(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = false;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = true;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x06012796 RID: 75670 RVA: 0x00812890 File Offset: 0x00810A90
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012797 RID: 75671 RVA: 0x008121AC File Offset: 0x008103AC
		public float JDACALOIPKE()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012798 RID: 75672 RVA: 0x008128AC File Offset: 0x00810AAC
		private static ACTkByte4 BDNGDMDGIMF(float DCCPCBLODIG)
		{
			return ObscuredFloat.OJGHFAEGCDA(DCCPCBLODIG, 1);
		}

		// Token: 0x06012799 RID: 75673 RVA: 0x00812093 File Offset: 0x00810293
		public static void DIKGINLFEGG(int JODDIMFACHN)
		{
			ObscuredFloat.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601279A RID: 75674 RVA: 0x00812093 File Offset: 0x00810293
		public static void DLBCCHJKPAD(int JODDIMFACHN)
		{
			ObscuredFloat.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601279B RID: 75675 RVA: 0x008128B5 File Offset: 0x00810AB5
		private static ACTkByte4 AFGMNANHHBF(float DCCPCBLODIG)
		{
			return ObscuredFloat.AFGMNANHHBF(DCCPCBLODIG, 0);
		}

		// Token: 0x0601279C RID: 75676 RVA: 0x008128C0 File Offset: 0x00810AC0
		public int LDJIMIOFKLG()
		{
			return this.KJBLLHBIHIL().GetHashCode();
		}

		// Token: 0x0601279D RID: 75677 RVA: 0x008128DB File Offset: 0x00810ADB
		public float JHGGCODDJDK()
		{
			return this.KJBLLHBIHIL();
		}

		// Token: 0x0601279E RID: 75678 RVA: 0x008128E3 File Offset: 0x00810AE3
		public void IKAKFNHNKEK()
		{
			if (this.currentCryptoKey != ObscuredFloat.cryptoKey)
			{
				this.hiddenValue = ObscuredFloat.AFGMNANHHBF(this.MJFIFINDLAM(), ObscuredFloat.cryptoKey);
				this.currentCryptoKey = ObscuredFloat.cryptoKey;
			}
		}

		// Token: 0x0601279F RID: 75679 RVA: 0x008128B5 File Offset: 0x00810AB5
		private static ACTkByte4 LMDHOACGCGM(float DCCPCBLODIG)
		{
			return ObscuredFloat.AFGMNANHHBF(DCCPCBLODIG, 0);
		}

		// Token: 0x060127A0 RID: 75680 RVA: 0x00812913 File Offset: 0x00810B13
		public void EEOJCDICBND()
		{
			if (this.currentCryptoKey != ObscuredFloat.cryptoKey)
			{
				this.hiddenValue = ObscuredFloat.OJGHFAEGCDA(this.NNDDLHNEONC(), ObscuredFloat.cryptoKey);
				this.currentCryptoKey = ObscuredFloat.cryptoKey;
			}
		}

		// Token: 0x060127A1 RID: 75681 RVA: 0x00812944 File Offset: 0x00810B44
		public string BJALMHGGAFM(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060127A2 RID: 75682 RVA: 0x00812960 File Offset: 0x00810B60
		public void BDGPKIPNMPP()
		{
			float dccpcblodig = this.AGABNIKJNAA();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(169, 191);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredFloat.OJGHFAEGCDA(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060127A3 RID: 75683 RVA: 0x008129A4 File Offset: 0x00810BA4
		public void LABEACCDKMD(int LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = new ObscuredFloat.FEAPFFLGINB
			{
				LMGJKOMFCFC = LDKMOLEEDIL
			}.HDHKNPPNGGA;
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x060127A4 RID: 75684 RVA: 0x008129F6 File Offset: 0x00810BF6
		public static float PFCANBAOMCB(ObscuredFloat DCCPCBLODIG)
		{
			return DCCPCBLODIG.KJBLLHBIHIL();
		}

		// Token: 0x060127A5 RID: 75685 RVA: 0x00812A00 File Offset: 0x00810C00
		public bool NJBGJFCNKFI(ObscuredFloat MBKPMBPLIJN)
		{
			double num = (double)MBKPMBPLIJN.MJFIFINDLAM();
			double obj = (double)this.KOGNLJBGPCP();
			return num.Equals(obj);
		}

		// Token: 0x060127A6 RID: 75686 RVA: 0x00812042 File Offset: 0x00810242
		public static float GPKNLEIHFOP(int DCCPCBLODIG)
		{
			return ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG, ObscuredFloat.cryptoKey);
		}

		// Token: 0x060127A7 RID: 75687 RVA: 0x00812A28 File Offset: 0x00810C28
		private float MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredFloat.cryptoKey;
				this.hiddenValue = ObscuredFloat.AFGMNANHHBF(0f);
				this.fakeValue = 0f;
				this.fakeValueActive = false;
				this.inited = true;
				return 0f;
			}
			ObscuredFloat.FEAPFFLGINB feapfflginb = default(ObscuredFloat.FEAPFFLGINB);
			feapfflginb.HDHKNPPNGGA = this.hiddenValue;
			feapfflginb.LMGJKOMFCFC ^= this.currentCryptoKey;
			float ccaimgaffld = feapfflginb.CCAIMGAFFLD;
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && Math.Abs(ccaimgaffld - this.fakeValue) > ObscuredCheatingDetector.ELOBJGIDGCP.floatEpsilon)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return ccaimgaffld;
		}

		// Token: 0x060127A8 RID: 75688 RVA: 0x008128E3 File Offset: 0x00810AE3
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredFloat.cryptoKey)
			{
				this.hiddenValue = ObscuredFloat.AFGMNANHHBF(this.MJFIFINDLAM(), ObscuredFloat.cryptoKey);
				this.currentCryptoKey = ObscuredFloat.cryptoKey;
			}
		}

		// Token: 0x060127A9 RID: 75689 RVA: 0x00812ADC File Offset: 0x00810CDC
		public bool Equals(ObscuredFloat MBKPMBPLIJN)
		{
			double num = (double)MBKPMBPLIJN.MJFIFINDLAM();
			double obj = (double)this.MJFIFINDLAM();
			return num.Equals(obj);
		}

		// Token: 0x060127AA RID: 75690 RVA: 0x00812550 File Offset: 0x00810750
		public static float GOOIABGKMHK(ObscuredFloat DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x060127AB RID: 75691 RVA: 0x00812B04 File Offset: 0x00810D04
		public static ObscuredFloat LFDLJBGJONF(ObscuredFloat NFKFMIIAKFN)
		{
			float dccpcblodig = NFKFMIIAKFN.KOGNLJBGPCP() + 1657f;
			NFKFMIIAKFN.hiddenValue = ObscuredFloat.OJGHFAEGCDA(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				NFKFMIIAKFN.fakeValue = dccpcblodig;
				NFKFMIIAKFN.fakeValueActive = true;
			}
			else
			{
				NFKFMIIAKFN.fakeValueActive = true;
			}
			return NFKFMIIAKFN;
		}

		// Token: 0x060127AC RID: 75692 RVA: 0x00812B54 File Offset: 0x00810D54
		public static float DHPGAJEHAFD(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			return new ObscuredFloat.FEAPFFLGINB
			{
				LMGJKOMFCFC = (DCCPCBLODIG ^ JMBKDINHDLO)
			}.CCAIMGAFFLD;
		}

		// Token: 0x060127AD RID: 75693 RVA: 0x00812B79 File Offset: 0x00810D79
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredFloat && this.Equals((ObscuredFloat)MBKPMBPLIJN);
		}

		// Token: 0x060127AE RID: 75694 RVA: 0x00812B94 File Offset: 0x00810D94
		public static float GGPGJEHDJHK(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			return new ObscuredFloat.FEAPFFLGINB
			{
				LMGJKOMFCFC = (DCCPCBLODIG ^ JMBKDINHDLO)
			}.CCAIMGAFFLD;
		}

		// Token: 0x060127AF RID: 75695 RVA: 0x00812BBC File Offset: 0x00810DBC
		private ObscuredFloat(float DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredFloat.cryptoKey;
			this.hiddenValue = ObscuredFloat.AFGMNANHHBF(DCCPCBLODIG);
			this.hiddenValueOld = null;
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : 0f);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x060127B0 RID: 75696 RVA: 0x00812C0C File Offset: 0x00810E0C
		private static ACTkByte4 OJGHFAEGCDA(float DCCPCBLODIG, int JMBKDINHDLO)
		{
			int num = JMBKDINHDLO;
			if (num == 0)
			{
				num = ObscuredFloat.cryptoKey;
			}
			ObscuredFloat.FEAPFFLGINB feapfflginb = default(ObscuredFloat.FEAPFFLGINB);
			feapfflginb.CCAIMGAFFLD = DCCPCBLODIG;
			feapfflginb.LMGJKOMFCFC ^= num;
			return feapfflginb.HDHKNPPNGGA;
		}

		// Token: 0x060127B1 RID: 75697 RVA: 0x00812C49 File Offset: 0x00810E49
		public static float ICBAHKBKJDB(int DCCPCBLODIG)
		{
			return ObscuredFloat.GGPGJEHDJHK(DCCPCBLODIG, ObscuredFloat.cryptoKey);
		}

		// Token: 0x060127B2 RID: 75698 RVA: 0x00812C58 File Offset: 0x00810E58
		public int NBDJPCPAFGN()
		{
			return this.KOGNLJBGPCP().GetHashCode();
		}

		// Token: 0x060127B3 RID: 75699 RVA: 0x00812C74 File Offset: 0x00810E74
		public int LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return new ObscuredFloat.FEAPFFLGINB
			{
				HDHKNPPNGGA = this.hiddenValue
			}.LMGJKOMFCFC;
		}

		// Token: 0x060127B4 RID: 75700 RVA: 0x00812CA4 File Offset: 0x00810EA4
		public string IPDCPCECFBC(IFormatProvider MCGFPOIAPGJ)
		{
			return this.KJBLLHBIHIL().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060127B5 RID: 75701 RVA: 0x008121B4 File Offset: 0x008103B4
		public static ObscuredFloat HLEMAJBAAEO(float DCCPCBLODIG)
		{
			return new ObscuredFloat(DCCPCBLODIG);
		}

		// Token: 0x060127B6 RID: 75702 RVA: 0x00812CC0 File Offset: 0x00810EC0
		public string MFPEPELOHBL()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x060127B7 RID: 75703 RVA: 0x00812CDC File Offset: 0x00810EDC
		public void OJFAJIJBEFD()
		{
			float dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredFloat.AFGMNANHHBF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060127B8 RID: 75704 RVA: 0x00812D20 File Offset: 0x00810F20
		public static float DLEINJOAHNM(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			return new ObscuredFloat.FEAPFFLGINB
			{
				LMGJKOMFCFC = (DCCPCBLODIG ^ JMBKDINHDLO)
			}.CCAIMGAFFLD;
		}

		// Token: 0x060127B9 RID: 75705 RVA: 0x00812D45 File Offset: 0x00810F45
		public bool EBFMGEOEHBH(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredFloat) || this.Equals((ObscuredFloat)MBKPMBPLIJN);
		}

		// Token: 0x060127BA RID: 75706 RVA: 0x00812D5D File Offset: 0x00810F5D
		public bool GBLGDIFFDCK(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredFloat) || this.KAAJNHMODLF((ObscuredFloat)MBKPMBPLIJN);
		}

		// Token: 0x060127BB RID: 75707 RVA: 0x00812D75 File Offset: 0x00810F75
		public float IMIIBABPEDP()
		{
			return this.KOGNLJBGPCP();
		}

		// Token: 0x060127BC RID: 75708 RVA: 0x00812D80 File Offset: 0x00810F80
		public static int HBJHGHOKFDK(float DCCPCBLODIG, int JMBKDINHDLO)
		{
			ObscuredFloat.FEAPFFLGINB feapfflginb = default(ObscuredFloat.FEAPFFLGINB);
			feapfflginb.CCAIMGAFFLD = DCCPCBLODIG;
			feapfflginb.LMGJKOMFCFC ^= JMBKDINHDLO;
			return feapfflginb.LMGJKOMFCFC;
		}

		// Token: 0x060127BD RID: 75709 RVA: 0x00812DB4 File Offset: 0x00810FB4
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x060127BE RID: 75710 RVA: 0x00812DD0 File Offset: 0x00810FD0
		public string JDPKKGOOKDF(IFormatProvider MCGFPOIAPGJ)
		{
			return this.KOGNLJBGPCP().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060127BF RID: 75711 RVA: 0x00812DEC File Offset: 0x00810FEC
		public static float OBJFODGFMAM(ObscuredFloat DCCPCBLODIG)
		{
			return DCCPCBLODIG.KOGNLJBGPCP();
		}

		// Token: 0x060127C0 RID: 75712 RVA: 0x00812D5D File Offset: 0x00810F5D
		public bool EFBDACNFKPA(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredFloat) || this.KAAJNHMODLF((ObscuredFloat)MBKPMBPLIJN);
		}

		// Token: 0x060127C1 RID: 75713 RVA: 0x00812DF8 File Offset: 0x00810FF8
		public string EOAGNAKKDMK(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.KJBLLHBIHIL().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x0400260B RID: 9739
		private static int cryptoKey = 230887;

		// Token: 0x0400260C RID: 9740
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x0400260D RID: 9741
		[SerializeField]
		private ACTkByte4 hiddenValue;

		// Token: 0x0400260E RID: 9742
		[FormerlySerializedAs("hiddenValue")]
		[SerializeField]
		private byte[] hiddenValueOld;

		// Token: 0x0400260F RID: 9743
		[SerializeField]
		private bool inited;

		// Token: 0x04002610 RID: 9744
		[SerializeField]
		private float fakeValue;

		// Token: 0x04002611 RID: 9745
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x02000583 RID: 1411
		[StructLayout(LayoutKind.Explicit)]
		private struct FEAPFFLGINB
		{
			// Token: 0x04002612 RID: 9746
			[FieldOffset(0)]
			public float CCAIMGAFFLD;

			// Token: 0x04002613 RID: 9747
			[FieldOffset(0)]
			public int LMGJKOMFCFC;

			// Token: 0x04002614 RID: 9748
			[FieldOffset(0)]
			public ACTkByte4 HDHKNPPNGGA;
		}
	}
}
