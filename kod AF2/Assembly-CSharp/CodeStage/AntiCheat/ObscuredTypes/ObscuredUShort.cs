using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000591 RID: 1425
	[Serializable]
	public struct ObscuredUShort : IEquatable<ObscuredUShort>, IFormattable
	{
		// Token: 0x06012C5D RID: 76893 RVA: 0x0081DFB8 File Offset: 0x0081C1B8
		public string FPPLGDMIGKI(string LJCEDKCLBDB)
		{
			return this.KOGNLJBGPCP().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012C5E RID: 76894 RVA: 0x0081DFD4 File Offset: 0x0081C1D4
		public static ushort EDIGIBJKONA(ObscuredUShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012C5F RID: 76895 RVA: 0x0081DFE0 File Offset: 0x0081C1E0
		public string CJMFHLIBCBM()
		{
			return this.GEMNKNACKBI().ToString();
		}

		// Token: 0x06012C60 RID: 76896 RVA: 0x0081DFFB File Offset: 0x0081C1FB
		public static void ENJDNMEJFIO(ushort JODDIMFACHN)
		{
			ObscuredUShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012C61 RID: 76897 RVA: 0x0081E003 File Offset: 0x0081C203
		public static ObscuredUShort GOOIABGKMHK(ushort DCCPCBLODIG)
		{
			return new ObscuredUShort(DCCPCBLODIG);
		}

		// Token: 0x06012C62 RID: 76898 RVA: 0x0081E00B File Offset: 0x0081C20B
		public static ushort BGICHGJEJFI(ushort DCCPCBLODIG)
		{
			return ObscuredUShort.KOJLJMMMJGP(DCCPCBLODIG, 0);
		}

		// Token: 0x06012C63 RID: 76899 RVA: 0x0081E00B File Offset: 0x0081C20B
		public static ushort KOJLJMMMJGP(ushort DCCPCBLODIG)
		{
			return ObscuredUShort.KOJLJMMMJGP(DCCPCBLODIG, 0);
		}

		// Token: 0x06012C64 RID: 76900 RVA: 0x0081E014 File Offset: 0x0081C214
		public string KCBJCGOINMK(string LJCEDKCLBDB)
		{
			return this.KOGNLJBGPCP().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012C65 RID: 76901 RVA: 0x0081E030 File Offset: 0x0081C230
		public string MIHCFECAIAD(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.AFIIKFBGNBB().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012C66 RID: 76902 RVA: 0x0081E04D File Offset: 0x0081C24D
		public void GKAMDPEGECF(ushort LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.KOGNLJBGPCP();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012C67 RID: 76903 RVA: 0x0081E080 File Offset: 0x0081C280
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012C68 RID: 76904 RVA: 0x0081E09C File Offset: 0x0081C29C
		public bool NCIEHGOMPPI(ObscuredUShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredUShort.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012C69 RID: 76905 RVA: 0x0081E0EA File Offset: 0x0081C2EA
		public ushort PPOLGPGMJBG()
		{
			this.FKMBPFHKPIK();
			return this.hiddenValue;
		}

		// Token: 0x06012C6A RID: 76906 RVA: 0x0081E0F8 File Offset: 0x0081C2F8
		public bool NBLJOBNMJCI(ObscuredUShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredUShort.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012C6B RID: 76907 RVA: 0x0081E146 File Offset: 0x0081C346
		public static ushort BLJAADMIKLH(ObscuredUShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.NPEAKEPHMOP();
		}

		// Token: 0x06012C6C RID: 76908 RVA: 0x0081E150 File Offset: 0x0081C350
		public static ObscuredUShort HIBLFIAPCJE(ObscuredUShort NFKFMIIAKFN)
		{
			ushort dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012C6D RID: 76909 RVA: 0x0081E0EA File Offset: 0x0081C2EA
		public ushort FEPABNBIPEJ()
		{
			this.FKMBPFHKPIK();
			return this.hiddenValue;
		}

		// Token: 0x06012C6E RID: 76910 RVA: 0x0081E19D File Offset: 0x0081C39D
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredUShort.cryptoKey)
			{
				this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(this.MJFIFINDLAM(), ObscuredUShort.cryptoKey);
				this.currentCryptoKey = ObscuredUShort.cryptoKey;
			}
		}

		// Token: 0x06012C6F RID: 76911 RVA: 0x0081DFFB File Offset: 0x0081C1FB
		public static void LOHKBEGOHBM(ushort JODDIMFACHN)
		{
			ObscuredUShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012C70 RID: 76912 RVA: 0x0081E1D0 File Offset: 0x0081C3D0
		public string IPDCPCECFBC()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012C71 RID: 76913 RVA: 0x0081E1EC File Offset: 0x0081C3EC
		public void JICPNBDNKBI()
		{
			ushort dccpcblodig = this.AFIIKFBGNBB();
			this.currentCryptoKey = (ushort)UnityEngine.Random.Range(0, 64);
			this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012C72 RID: 76914 RVA: 0x0081E224 File Offset: 0x0081C424
		public static ushort FNPLIDPNCIK(ObscuredUShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.NAHJHEDHCOI();
		}

		// Token: 0x06012C73 RID: 76915 RVA: 0x0081E230 File Offset: 0x0081C430
		public string ADOAJOFIPAM(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.GEMNKNACKBI().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012C74 RID: 76916 RVA: 0x0081E24D File Offset: 0x0081C44D
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredUShort && this.Equals((ObscuredUShort)MBKPMBPLIJN);
		}

		// Token: 0x06012C75 RID: 76917 RVA: 0x0081E268 File Offset: 0x0081C468
		public string JHGPBNCOHHH()
		{
			return this.AFIIKFBGNBB().ToString();
		}

		// Token: 0x06012C76 RID: 76918 RVA: 0x0081E284 File Offset: 0x0081C484
		private ushort GEMNKNACKBI()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUShort.cryptoKey;
				this.hiddenValue = ObscuredUShort.ANHANMIFKCF(1);
				this.fakeValue = 0;
				this.fakeValueActive = true;
				this.inited = true;
				return 0;
			}
			ushort num = ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012C77 RID: 76919 RVA: 0x0081E2FC File Offset: 0x0081C4FC
		public string MJODNMLNFJC(string LJCEDKCLBDB)
		{
			return this.NAHJHEDHCOI().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012C78 RID: 76920 RVA: 0x0081E318 File Offset: 0x0081C518
		public string NIDKKALEJIM()
		{
			return this.GLIIBCLNIPD().ToString();
		}

		// Token: 0x06012C79 RID: 76921 RVA: 0x0081E334 File Offset: 0x0081C534
		public int LDJIMIOFKLG()
		{
			return this.HKIIHGMMKDA().GetHashCode();
		}

		// Token: 0x06012C7A RID: 76922 RVA: 0x0081E350 File Offset: 0x0081C550
		public string BJALMHGGAFM(string LJCEDKCLBDB)
		{
			return this.GEMNKNACKBI().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012C7B RID: 76923 RVA: 0x0081DFD4 File Offset: 0x0081C1D4
		public static ushort GOOIABGKMHK(ObscuredUShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012C7C RID: 76924 RVA: 0x0081E36C File Offset: 0x0081C56C
		public void EINJEBBMOMA(ushort LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
			{
				this.fakeValue = this.AFIIKFBGNBB();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012C7D RID: 76925 RVA: 0x0081E3A0 File Offset: 0x0081C5A0
		public string IHKJGKNNIHA(string LJCEDKCLBDB)
		{
			return this.NPEAKEPHMOP().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012C7E RID: 76926 RVA: 0x0081E3BC File Offset: 0x0081C5BC
		public ushort NAICOFCGNCP()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012C7F RID: 76927 RVA: 0x0081E3C4 File Offset: 0x0081C5C4
		public void LABEACCDKMD(ushort LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012C80 RID: 76928 RVA: 0x0081E3F8 File Offset: 0x0081C5F8
		private ushort MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUShort.cryptoKey;
				this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(0);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = true;
				return 0;
			}
			ushort num = ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012C81 RID: 76929 RVA: 0x0081E470 File Offset: 0x0081C670
		public static ushort HGCCBLGIMIL(ushort DCCPCBLODIG)
		{
			return ObscuredUShort.KOJLJMMMJGP(DCCPCBLODIG, 1);
		}

		// Token: 0x06012C82 RID: 76930 RVA: 0x0081E479 File Offset: 0x0081C679
		public void AFAHDCDCCHP()
		{
			if (this.currentCryptoKey != ObscuredUShort.cryptoKey)
			{
				this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(this.KOGNLJBGPCP(), ObscuredUShort.cryptoKey);
				this.currentCryptoKey = ObscuredUShort.cryptoKey;
			}
		}

		// Token: 0x06012C83 RID: 76931 RVA: 0x0081E4A9 File Offset: 0x0081C6A9
		public bool MFFEDGJOKKC(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredUShort) || this.GINFGGPEFOG((ObscuredUShort)MBKPMBPLIJN);
		}

		// Token: 0x06012C84 RID: 76932 RVA: 0x0081E4C4 File Offset: 0x0081C6C4
		public void OAIEKILBONK()
		{
			ushort dccpcblodig = this.GEMNKNACKBI();
			this.currentCryptoKey = (ushort)UnityEngine.Random.Range(0, -101);
			this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012C85 RID: 76933 RVA: 0x0081E4FC File Offset: 0x0081C6FC
		public bool GINFGGPEFOG(ObscuredUShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredUShort.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012C87 RID: 76935 RVA: 0x0081E558 File Offset: 0x0081C758
		private ushort NPEAKEPHMOP()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUShort.cryptoKey;
				this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(1);
				this.fakeValue = 1;
				this.fakeValueActive = false;
				this.inited = true;
				return 0;
			}
			ushort num = ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.CKFIDHHGLGO() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012C88 RID: 76936 RVA: 0x0081E5D0 File Offset: 0x0081C7D0
		public bool IALPLFHCFPI(ObscuredUShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredUShort.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012C89 RID: 76937 RVA: 0x0081DFFB File Offset: 0x0081C1FB
		public static void BBOGAEMNJJN(ushort JODDIMFACHN)
		{
			ObscuredUShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012C8A RID: 76938 RVA: 0x0081E620 File Offset: 0x0081C820
		private ushort HKIIHGMMKDA()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUShort.cryptoKey;
				this.hiddenValue = ObscuredUShort.HCPLFLOBHPH(1);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = true;
				return 1;
			}
			ushort num = ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.LHMMLFNJOMC() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012C8B RID: 76939 RVA: 0x0081E698 File Offset: 0x0081C898
		public static ObscuredUShort BPKHHKOHBDJ(ObscuredUShort NFKFMIIAKFN)
		{
			ushort dccpcblodig = NFKFMIIAKFN.GLIIBCLNIPD() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
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

		// Token: 0x06012C8C RID: 76940 RVA: 0x0081DFD4 File Offset: 0x0081C1D4
		public static ushort OADLNEPCDPK(ObscuredUShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012C8D RID: 76941 RVA: 0x0081E6E5 File Offset: 0x0081C8E5
		public ushort LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012C8E RID: 76942 RVA: 0x0081E6F4 File Offset: 0x0081C8F4
		public static ObscuredUShort CFHIKLIEJKA(ObscuredUShort NFKFMIIAKFN)
		{
			ushort dccpcblodig = NFKFMIIAKFN.GEMNKNACKBI() + 0;
			NFKFMIIAKFN.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
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

		// Token: 0x06012C8F RID: 76943 RVA: 0x0081E744 File Offset: 0x0081C944
		public bool PBLFGPOBFKB(ObscuredUShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredUShort.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012C90 RID: 76944 RVA: 0x0081E794 File Offset: 0x0081C994
		public void GJJDFCFLDGK()
		{
			ushort dccpcblodig = this.GLIIBCLNIPD();
			this.currentCryptoKey = (ushort)UnityEngine.Random.Range(1, 156);
			this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012C91 RID: 76945 RVA: 0x0081E7CC File Offset: 0x0081C9CC
		public bool AMLJMIFKGPB(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredUShort) || this.NCIEHGOMPPI((ObscuredUShort)MBKPMBPLIJN);
		}

		// Token: 0x06012C92 RID: 76946 RVA: 0x0081E7E4 File Offset: 0x0081C9E4
		public void EEKBCNHPFJG(ushort LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				this.fakeValue = this.GEMNKNACKBI();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012C93 RID: 76947 RVA: 0x0081E818 File Offset: 0x0081CA18
		public string ToString(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012C94 RID: 76948 RVA: 0x0081E838 File Offset: 0x0081CA38
		private ushort NAHJHEDHCOI()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUShort.cryptoKey;
				this.hiddenValue = ObscuredUShort.ANHANMIFKCF(1);
				this.fakeValue = 1;
				this.fakeValueActive = true;
				this.inited = false;
				return 1;
			}
			ushort num = ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012C95 RID: 76949 RVA: 0x0081E8B0 File Offset: 0x0081CAB0
		private ushort AFIIKFBGNBB()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUShort.cryptoKey;
				this.hiddenValue = ObscuredUShort.BGICHGJEJFI(1);
				this.fakeValue = 0;
				this.fakeValueActive = true;
				this.inited = true;
				return 1;
			}
			ushort num = ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012C96 RID: 76950 RVA: 0x0081E928 File Offset: 0x0081CB28
		public static ObscuredUShort INDELOJJICF(ObscuredUShort NFKFMIIAKFN)
		{
			ushort dccpcblodig = NFKFMIIAKFN.HKIIHGMMKDA() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
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

		// Token: 0x06012C97 RID: 76951 RVA: 0x0081E00B File Offset: 0x0081C20B
		public static ushort HCPLFLOBHPH(ushort DCCPCBLODIG)
		{
			return ObscuredUShort.KOJLJMMMJGP(DCCPCBLODIG, 0);
		}

		// Token: 0x06012C98 RID: 76952 RVA: 0x0081E3BC File Offset: 0x0081C5BC
		public ushort FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012C99 RID: 76953 RVA: 0x0081E978 File Offset: 0x0081CB78
		public string OCJAOJLHOFO(IFormatProvider MCGFPOIAPGJ)
		{
			return this.GEMNKNACKBI().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012C9A RID: 76954 RVA: 0x0081E994 File Offset: 0x0081CB94
		public static ushort KOJLJMMMJGP(ushort DCCPCBLODIG, ushort JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredUShort.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012C9B RID: 76955 RVA: 0x0081E9A8 File Offset: 0x0081CBA8
		public void OJFAJIJBEFD()
		{
			ushort dccpcblodig = this.MJFIFINDLAM();
			this.currentCryptoKey = (ushort)UnityEngine.Random.Range(1, 32767);
			this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012C9C RID: 76956 RVA: 0x0081E9E0 File Offset: 0x0081CBE0
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012C9D RID: 76957 RVA: 0x0081DFFB File Offset: 0x0081C1FB
		public static void KHFMLLFDFOB(ushort JODDIMFACHN)
		{
			ObscuredUShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012C9E RID: 76958 RVA: 0x0081E00B File Offset: 0x0081C20B
		public static ushort ANHANMIFKCF(ushort DCCPCBLODIG)
		{
			return ObscuredUShort.KOJLJMMMJGP(DCCPCBLODIG, 0);
		}

		// Token: 0x06012C9F RID: 76959 RVA: 0x0081E9FC File Offset: 0x0081CBFC
		public static ObscuredUShort DPCDNMHLOJF(ObscuredUShort NFKFMIIAKFN)
		{
			ushort dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012CA0 RID: 76960 RVA: 0x0081EA4C File Offset: 0x0081CC4C
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012CA1 RID: 76961 RVA: 0x0081EA68 File Offset: 0x0081CC68
		public bool EFBDACNFKPA(ObscuredUShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredUShort.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012CA2 RID: 76962 RVA: 0x0081EAB6 File Offset: 0x0081CCB6
		public static ushort NCKBEFMIPDN(ObscuredUShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.KOGNLJBGPCP();
		}

		// Token: 0x06012CA3 RID: 76963 RVA: 0x0081EABF File Offset: 0x0081CCBF
		public void FKMBPFHKPIK()
		{
			if (this.currentCryptoKey != ObscuredUShort.cryptoKey)
			{
				this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(this.GEMNKNACKBI(), ObscuredUShort.cryptoKey);
				this.currentCryptoKey = ObscuredUShort.cryptoKey;
			}
		}

		// Token: 0x06012CA4 RID: 76964 RVA: 0x0081EAF0 File Offset: 0x0081CCF0
		public static ObscuredUShort MCKMMFAPLAC(ObscuredUShort NFKFMIIAKFN)
		{
			ushort dccpcblodig = NFKFMIIAKFN.NPEAKEPHMOP() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
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

		// Token: 0x06012CA5 RID: 76965 RVA: 0x0081EB40 File Offset: 0x0081CD40
		public void IONEIKPMOFM()
		{
			ushort dccpcblodig = this.GLIIBCLNIPD();
			this.currentCryptoKey = (ushort)UnityEngine.Random.Range(1, 143);
			this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012CA6 RID: 76966 RVA: 0x0081EB78 File Offset: 0x0081CD78
		public string FGNNJFJLENH()
		{
			return this.NPEAKEPHMOP().ToString();
		}

		// Token: 0x06012CA7 RID: 76967 RVA: 0x0081E003 File Offset: 0x0081C203
		public static ObscuredUShort LMCJCHPGIJK(ushort DCCPCBLODIG)
		{
			return new ObscuredUShort(DCCPCBLODIG);
		}

		// Token: 0x06012CA8 RID: 76968 RVA: 0x0081EB94 File Offset: 0x0081CD94
		private ushort KOGNLJBGPCP()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUShort.cryptoKey;
				this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(1);
				this.fakeValue = 1;
				this.fakeValueActive = true;
				this.inited = true;
				return 1;
			}
			ushort num = ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012CA9 RID: 76969 RVA: 0x0081EC0C File Offset: 0x0081CE0C
		private ushort GLIIBCLNIPD()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUShort.cryptoKey;
				this.hiddenValue = ObscuredUShort.ANHANMIFKCF(0);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = true;
				return 1;
			}
			ushort num = ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.LHMMLFNJOMC() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012CAA RID: 76970 RVA: 0x0081DFFB File Offset: 0x0081C1FB
		public static void DELABFILBBK(ushort JODDIMFACHN)
		{
			ObscuredUShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012CAB RID: 76971 RVA: 0x0081EC84 File Offset: 0x0081CE84
		public bool Equals(ObscuredUShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredUShort.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012CAC RID: 76972 RVA: 0x0081ECD4 File Offset: 0x0081CED4
		public int NELEIIPJPOI()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012CAD RID: 76973 RVA: 0x0081ECF0 File Offset: 0x0081CEF0
		private ObscuredUShort(ushort DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredUShort.cryptoKey;
			this.hiddenValue = ObscuredUShort.KOJLJMMMJGP(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : 0);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x06012CAE RID: 76974 RVA: 0x0081ED38 File Offset: 0x0081CF38
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012CAF RID: 76975 RVA: 0x0081ED53 File Offset: 0x0081CF53
		public static ushort KKAKHLOGJOD(ObscuredUShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.HKIIHGMMKDA();
		}

		// Token: 0x06012CB0 RID: 76976 RVA: 0x0081E6E5 File Offset: 0x0081C8E5
		public ushort DKFGIMKDPMH()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012CB1 RID: 76977 RVA: 0x0081E003 File Offset: 0x0081C203
		public static ObscuredUShort DHBKOJMFDIE(ushort DCCPCBLODIG)
		{
			return new ObscuredUShort(DCCPCBLODIG);
		}

		// Token: 0x06012CB2 RID: 76978 RVA: 0x0081ED5C File Offset: 0x0081CF5C
		public static ObscuredUShort CJOFIEPHNLM(ObscuredUShort NFKFMIIAKFN)
		{
			ushort dccpcblodig = NFKFMIIAKFN.KOGNLJBGPCP() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredUShort.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
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

		// Token: 0x06012CB3 RID: 76979 RVA: 0x0081DFFB File Offset: 0x0081C1FB
		public static void KEGPDCOKIJC(ushort JODDIMFACHN)
		{
			ObscuredUShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0400266E RID: 9838
		private static ushort cryptoKey = 224;

		// Token: 0x0400266F RID: 9839
		private ushort currentCryptoKey;

		// Token: 0x04002670 RID: 9840
		private ushort hiddenValue;

		// Token: 0x04002671 RID: 9841
		private bool inited;

		// Token: 0x04002672 RID: 9842
		private ushort fakeValue;

		// Token: 0x04002673 RID: 9843
		private bool fakeValueActive;
	}
}
