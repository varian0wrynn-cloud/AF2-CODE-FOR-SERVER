using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200057B RID: 1403
	[Serializable]
	public struct ObscuredBool : IEquatable<ObscuredBool>
	{
		// Token: 0x06012537 RID: 75063 RVA: 0x0080CA65 File Offset: 0x0080AC65
		public static bool KMAKGFIJCNF(int DCCPCBLODIG)
		{
			return ObscuredBool.PNDEPLCIBDL(DCCPCBLODIG, 0);
		}

		// Token: 0x06012538 RID: 75064 RVA: 0x0080CA70 File Offset: 0x0080AC70
		public void IONEIKPMOFM()
		{
			bool dccpcblodig = this.PHNCMMLFIFO();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(1, -63);
			this.hiddenValue = ObscuredBool.HBJHGHOKFDK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012539 RID: 75065 RVA: 0x0080CAA8 File Offset: 0x0080ACA8
		public static bool BEKJFKPBMEI(int DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			DCCPCBLODIG ^= (int)JMBKDINHDLO;
			return DCCPCBLODIG != 41;
		}

		// Token: 0x0601253A RID: 75066 RVA: 0x0080CAC4 File Offset: 0x0080ACC4
		public int INBJCNPLJBH()
		{
			return this.HMKNGLCANDE().GetHashCode();
		}

		// Token: 0x0601253B RID: 75067 RVA: 0x0080CAE0 File Offset: 0x0080ACE0
		public int FODNLDKAAEC()
		{
			return this.BFOBOHBCOPN().GetHashCode();
		}

		// Token: 0x0601253C RID: 75068 RVA: 0x0080CAFC File Offset: 0x0080ACFC
		private bool HMKNGLCANDE()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredBool.cryptoKey;
				this.hiddenValue = ObscuredBool.PEOEIHHAONH(true);
				this.fakeValue = true;
				this.fakeValueActive = true;
				this.inited = true;
				return true;
			}
			bool flag = (this.hiddenValue ^ (int)this.currentCryptoKey) != 194;
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && flag != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return flag;
		}

		// Token: 0x0601253D RID: 75069 RVA: 0x0080CB7A File Offset: 0x0080AD7A
		public static int NGGMBKEAILP(bool DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			return (DCCPCBLODIG ? -106 : 19) ^ (int)JMBKDINHDLO;
		}

		// Token: 0x0601253E RID: 75070 RVA: 0x0080CB97 File Offset: 0x0080AD97
		public int LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x0601253F RID: 75071 RVA: 0x0080CBA5 File Offset: 0x0080ADA5
		public static bool IMJELMNHEFL(int DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			DCCPCBLODIG ^= (int)JMBKDINHDLO;
			return DCCPCBLODIG == -126;
		}

		// Token: 0x06012540 RID: 75072 RVA: 0x0080CBC4 File Offset: 0x0080ADC4
		public void HDNPCJCDGOD()
		{
			bool dccpcblodig = this.MJFIFINDLAM();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(1, -143);
			this.hiddenValue = ObscuredBool.NHGNDCDDNNA(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012541 RID: 75073 RVA: 0x0080CBFC File Offset: 0x0080ADFC
		public static int IACCCBJHJPL(bool DCCPCBLODIG)
		{
			return ObscuredBool.HKNJMBMKGFN(DCCPCBLODIG, 1);
		}

		// Token: 0x06012542 RID: 75074 RVA: 0x0080CC05 File Offset: 0x0080AE05
		public static int HBJHGHOKFDK(bool DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			return (int)((DCCPCBLODIG ? 213 : 181) ^ JMBKDINHDLO);
		}

		// Token: 0x06012543 RID: 75075 RVA: 0x0080CC22 File Offset: 0x0080AE22
		public static bool IJEGDPCOKOE(int DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			DCCPCBLODIG ^= (int)JMBKDINHDLO;
			return DCCPCBLODIG == -87;
		}

		// Token: 0x06012544 RID: 75076 RVA: 0x0080CC3E File Offset: 0x0080AE3E
		public void PHPMDIGBAEM(int LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				this.fakeValue = this.JJCDLJIGDPL();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012545 RID: 75077 RVA: 0x0080CC70 File Offset: 0x0080AE70
		public bool LHNMACPIMDE()
		{
			return this.JJCDLJIGDPL();
		}

		// Token: 0x06012546 RID: 75078 RVA: 0x0080CC78 File Offset: 0x0080AE78
		public string IBNCBKOPEOC()
		{
			return this.LHIFOBAECHJ().ToString();
		}

		// Token: 0x06012547 RID: 75079 RVA: 0x0080CC94 File Offset: 0x0080AE94
		public bool LCBEDPPBPAH(ObscuredBool MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredBool.IJEGDPCOKOE(this.hiddenValue, this.currentCryptoKey) == ObscuredBool.IJEGDPCOKOE(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012548 RID: 75080 RVA: 0x0080CCE2 File Offset: 0x0080AEE2
		public static bool DHPGAJEHAFD(int DCCPCBLODIG)
		{
			return ObscuredBool.DHPGAJEHAFD(DCCPCBLODIG, 0);
		}

		// Token: 0x06012549 RID: 75081 RVA: 0x0080CCEC File Offset: 0x0080AEEC
		private bool BFOBOHBCOPN()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredBool.cryptoKey;
				this.hiddenValue = ObscuredBool.FCKPJEGGHFO(false);
				this.fakeValue = false;
				this.fakeValueActive = false;
				this.inited = false;
				return false;
			}
			bool flag = (this.hiddenValue ^ (int)this.currentCryptoKey) == -102;
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && flag != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return flag;
		}

		// Token: 0x0601254A RID: 75082 RVA: 0x0080CD6A File Offset: 0x0080AF6A
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.HBJHGHOKFDK(this.MJFIFINDLAM(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x0601254B RID: 75083 RVA: 0x0080CD9C File Offset: 0x0080AF9C
		private ObscuredBool(bool DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredBool.cryptoKey;
			this.hiddenValue = ObscuredBool.HBJHGHOKFDK(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag && DCCPCBLODIG);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x0601254C RID: 75084 RVA: 0x0080CDE4 File Offset: 0x0080AFE4
		public int OJEDIMJIDCE()
		{
			return this.LHIFOBAECHJ().GetHashCode();
		}

		// Token: 0x0601254D RID: 75085 RVA: 0x0080CE00 File Offset: 0x0080B000
		public string GIOCLFJADKN()
		{
			return this.LHIFOBAECHJ().ToString();
		}

		// Token: 0x0601254E RID: 75086 RVA: 0x0080CE1B File Offset: 0x0080B01B
		public static int NPECCNEFJCN(bool DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			return (DCCPCBLODIG ? -4 : -149) ^ (int)JMBKDINHDLO;
		}

		// Token: 0x0601254F RID: 75087 RVA: 0x0080CB97 File Offset: 0x0080AD97
		public int PPOLGPGMJBG()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012550 RID: 75088 RVA: 0x0080CE38 File Offset: 0x0080B038
		public static int NHGNDCDDNNA(bool DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			return (int)((DCCPCBLODIG ? 67 : 140) ^ JMBKDINHDLO);
		}

		// Token: 0x06012551 RID: 75089 RVA: 0x0080CE58 File Offset: 0x0080B058
		public bool HPBIIOBONBL(ObscuredBool MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredBool.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredBool.BEKJFKPBMEI(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012552 RID: 75090 RVA: 0x0080CEA6 File Offset: 0x0080B0A6
		public void CJNJONEKFHA()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.NPECCNEFJCN(this.JJCDLJIGDPL(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x06012553 RID: 75091 RVA: 0x0080CED8 File Offset: 0x0080B0D8
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012554 RID: 75092 RVA: 0x0080CEF3 File Offset: 0x0080B0F3
		public static int CEKHNKMMONO(bool DCCPCBLODIG)
		{
			return ObscuredBool.KGMBCPDFKEL(DCCPCBLODIG, 0);
		}

		// Token: 0x06012555 RID: 75093 RVA: 0x0080CEFC File Offset: 0x0080B0FC
		public string JJPMKNKFPPN()
		{
			return this.BFOBOHBCOPN().ToString();
		}

		// Token: 0x06012556 RID: 75094 RVA: 0x0080CF17 File Offset: 0x0080B117
		public static ObscuredBool IJMOCOKPGEG(bool DCCPCBLODIG)
		{
			return new ObscuredBool(DCCPCBLODIG);
		}

		// Token: 0x06012557 RID: 75095 RVA: 0x0080CF20 File Offset: 0x0080B120
		public void OJFAJIJBEFD()
		{
			bool dccpcblodig = this.MJFIFINDLAM();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(1, 150);
			this.hiddenValue = ObscuredBool.HBJHGHOKFDK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012558 RID: 75096 RVA: 0x0080CF58 File Offset: 0x0080B158
		public static bool IBFEFGCIOHO(int DCCPCBLODIG)
		{
			return ObscuredBool.BIHICOOKCOA(DCCPCBLODIG, 0);
		}

		// Token: 0x06012559 RID: 75097 RVA: 0x0080CC70 File Offset: 0x0080AE70
		public bool FNPBBGIIBPO()
		{
			return this.JJCDLJIGDPL();
		}

		// Token: 0x0601255A RID: 75098 RVA: 0x0080CF61 File Offset: 0x0080B161
		public static bool DHPGAJEHAFD(int DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			DCCPCBLODIG ^= (int)JMBKDINHDLO;
			return DCCPCBLODIG != 181;
		}

		// Token: 0x0601255B RID: 75099 RVA: 0x0080CF7D File Offset: 0x0080B17D
		public int NBKCHAOJBKN()
		{
			this.CENNMGGKPDB();
			return this.hiddenValue;
		}

		// Token: 0x0601255C RID: 75100 RVA: 0x0080CF8C File Offset: 0x0080B18C
		public bool KAAJNHMODLF(ObscuredBool MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredBool.PNDEPLCIBDL(this.hiddenValue, this.currentCryptoKey) == ObscuredBool.GPKNLEIHFOP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x0601255D RID: 75101 RVA: 0x0080CFDC File Offset: 0x0080B1DC
		public string LCDALFMOKBH()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x0601255E RID: 75102 RVA: 0x0080CFF8 File Offset: 0x0080B1F8
		public void OPFLADPPNJD()
		{
			bool dccpcblodig = this.PHNCMMLFIFO();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(0, 31);
			this.hiddenValue = ObscuredBool.NPECCNEFJCN(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601255F RID: 75103 RVA: 0x0080D030 File Offset: 0x0080B230
		private bool PHNCMMLFIFO()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredBool.cryptoKey;
				this.hiddenValue = ObscuredBool.HBJHGHOKFDK(false);
				this.fakeValue = false;
				this.fakeValueActive = true;
				this.inited = false;
				return false;
			}
			bool flag = (this.hiddenValue ^ (int)this.currentCryptoKey) == 31;
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && flag != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return flag;
		}

		// Token: 0x06012560 RID: 75104 RVA: 0x0080D0AE File Offset: 0x0080B2AE
		public void FCCINBLDFDA()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.NHGNDCDDNNA(this.BFOBOHBCOPN(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x06012561 RID: 75105 RVA: 0x0080D0DE File Offset: 0x0080B2DE
		public bool LBBEEFEEDOA(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredBool && this.MBEJDANGDKJ((ObscuredBool)MBKPMBPLIJN);
		}

		// Token: 0x06012562 RID: 75106 RVA: 0x0080D0F8 File Offset: 0x0080B2F8
		public void DIJFHEPLDCC()
		{
			bool dccpcblodig = this.LHIFOBAECHJ();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(0, -175);
			this.hiddenValue = ObscuredBool.BEGDPMLFGOO(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012563 RID: 75107 RVA: 0x0080D130 File Offset: 0x0080B330
		public bool JKCBHABNLPK()
		{
			return this.JMJDPBABFHO();
		}

		// Token: 0x06012564 RID: 75108 RVA: 0x0080D138 File Offset: 0x0080B338
		public static bool CINIKOHABJJ(ObscuredBool DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012565 RID: 75109 RVA: 0x0080CF17 File Offset: 0x0080B117
		public static ObscuredBool ALBBIEKFLJF(bool DCCPCBLODIG)
		{
			return new ObscuredBool(DCCPCBLODIG);
		}

		// Token: 0x06012566 RID: 75110 RVA: 0x0080D144 File Offset: 0x0080B344
		public string MIHCFECAIAD()
		{
			return this.LHIFOBAECHJ().ToString();
		}

		// Token: 0x06012567 RID: 75111 RVA: 0x0080D138 File Offset: 0x0080B338
		public static bool DODJMPNDCOB(ObscuredBool DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012568 RID: 75112 RVA: 0x0080D15F File Offset: 0x0080B35F
		public int DCCPLAOEFFE()
		{
			this.BNHILNMJKPL();
			return this.hiddenValue;
		}

		// Token: 0x06012569 RID: 75113 RVA: 0x0080D16D File Offset: 0x0080B36D
		public void PJKFKACLPIJ(int LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.BFOBOHBCOPN();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x0601256A RID: 75114 RVA: 0x0080D19F File Offset: 0x0080B39F
		public bool FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x0601256C RID: 75116 RVA: 0x0080D1B4 File Offset: 0x0080B3B4
		public void NNGNJGOIKKF()
		{
			bool dccpcblodig = this.BFOBOHBCOPN();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(1, -81);
			this.hiddenValue = ObscuredBool.HKNJMBMKGFN(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601256D RID: 75117 RVA: 0x0080D1EC File Offset: 0x0080B3EC
		public int NBDJPCPAFGN()
		{
			return this.HMKNGLCANDE().GetHashCode();
		}

		// Token: 0x0601256E RID: 75118 RVA: 0x0080D138 File Offset: 0x0080B338
		public static bool LPDGJCGPEBD(ObscuredBool DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x0601256F RID: 75119 RVA: 0x0080D207 File Offset: 0x0080B407
		public int ALNLLOGIAMB()
		{
			this.EHPGKFFHJNL();
			return this.hiddenValue;
		}

		// Token: 0x06012570 RID: 75120 RVA: 0x0080D138 File Offset: 0x0080B338
		public static bool GOOIABGKMHK(ObscuredBool DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012571 RID: 75121 RVA: 0x0080D218 File Offset: 0x0080B418
		private bool LHIFOBAECHJ()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredBool.cryptoKey;
				this.hiddenValue = ObscuredBool.CEKHNKMMONO(false);
				this.fakeValue = true;
				this.fakeValueActive = false;
				this.inited = true;
				return false;
			}
			bool flag = (this.hiddenValue ^ (int)this.currentCryptoKey) != 159;
			if (ObscuredCheatingDetector.LHMMLFNJOMC() && this.fakeValueActive && flag != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return flag;
		}

		// Token: 0x06012572 RID: 75122 RVA: 0x0080CF17 File Offset: 0x0080B117
		public static ObscuredBool GOOIABGKMHK(bool DCCPCBLODIG)
		{
			return new ObscuredBool(DCCPCBLODIG);
		}

		// Token: 0x06012573 RID: 75123 RVA: 0x0080CF17 File Offset: 0x0080B117
		public static ObscuredBool LBDMFALMOLD(bool DCCPCBLODIG)
		{
			return new ObscuredBool(DCCPCBLODIG);
		}

		// Token: 0x06012574 RID: 75124 RVA: 0x0080D296 File Offset: 0x0080B496
		public int IMLIDNCBNOM()
		{
			this.FCCINBLDFDA();
			return this.hiddenValue;
		}

		// Token: 0x06012575 RID: 75125 RVA: 0x0080D2A4 File Offset: 0x0080B4A4
		public void LNBLECJHDND(int LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue = this.HMKNGLCANDE();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012576 RID: 75126 RVA: 0x0080D2D6 File Offset: 0x0080B4D6
		public bool JFGMGBHIJKF()
		{
			return this.HMKNGLCANDE();
		}

		// Token: 0x06012577 RID: 75127 RVA: 0x0080D2DE File Offset: 0x0080B4DE
		public bool IIBBNMMMBBF(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredBool) || this.Equals((ObscuredBool)MBKPMBPLIJN);
		}

		// Token: 0x06012578 RID: 75128 RVA: 0x0080D2F8 File Offset: 0x0080B4F8
		public bool Equals(ObscuredBool MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredBool.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredBool.DHPGAJEHAFD(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012579 RID: 75129 RVA: 0x0080D346 File Offset: 0x0080B546
		public static int GGIBCLJMFLF(bool DCCPCBLODIG)
		{
			return ObscuredBool.NPECCNEFJCN(DCCPCBLODIG, 0);
		}

		// Token: 0x0601257A RID: 75130 RVA: 0x0080D34F File Offset: 0x0080B54F
		public void GBAPEMIGFJC()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.HBJHGHOKFDK(this.LHIFOBAECHJ(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x0601257B RID: 75131 RVA: 0x0080D37F File Offset: 0x0080B57F
		public static int HBJHGHOKFDK(bool DCCPCBLODIG)
		{
			return ObscuredBool.HBJHGHOKFDK(DCCPCBLODIG, 0);
		}

		// Token: 0x0601257C RID: 75132 RVA: 0x0080D388 File Offset: 0x0080B588
		public bool JJALCADHNHE(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredBool && this.JNPNPCHPJAG((ObscuredBool)MBKPMBPLIJN);
		}

		// Token: 0x0601257D RID: 75133 RVA: 0x0080D3A0 File Offset: 0x0080B5A0
		public static void KHFMLLFDFOB(byte JODDIMFACHN)
		{
			ObscuredBool.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601257E RID: 75134 RVA: 0x0080D3A8 File Offset: 0x0080B5A8
		public void EKJHMBNCBBH()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.JFEEOHBBGFN(this.AKDOEIEENOJ(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x0601257F RID: 75135 RVA: 0x0080D3D8 File Offset: 0x0080B5D8
		public static int BEGDPMLFGOO(bool DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			return (DCCPCBLODIG ? 161 : -179) ^ (int)JMBKDINHDLO;
		}

		// Token: 0x06012580 RID: 75136 RVA: 0x0080D3F8 File Offset: 0x0080B5F8
		public string KJFKHMONBLB()
		{
			return this.BFOBOHBCOPN().ToString();
		}

		// Token: 0x06012581 RID: 75137 RVA: 0x0080D3A0 File Offset: 0x0080B5A0
		public static void EIMCIBAFNMF(byte JODDIMFACHN)
		{
			ObscuredBool.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012582 RID: 75138 RVA: 0x0080D414 File Offset: 0x0080B614
		public bool KENMLFOLLIN(ObscuredBool MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredBool.BIHICOOKCOA(this.hiddenValue, this.currentCryptoKey) == ObscuredBool.PNDEPLCIBDL(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012583 RID: 75139 RVA: 0x0080D462 File Offset: 0x0080B662
		public void BNHILNMJKPL()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.BEGDPMLFGOO(this.BFOBOHBCOPN(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x06012584 RID: 75140 RVA: 0x0080D492 File Offset: 0x0080B692
		public int LAGPIGGFLIA()
		{
			this.MACKEHOHJMC();
			return this.hiddenValue;
		}

		// Token: 0x06012585 RID: 75141 RVA: 0x0080CF17 File Offset: 0x0080B117
		public static ObscuredBool DMILLCHBEAG(bool DCCPCBLODIG)
		{
			return new ObscuredBool(DCCPCBLODIG);
		}

		// Token: 0x06012586 RID: 75142 RVA: 0x0080D4A0 File Offset: 0x0080B6A0
		public static bool GPKNLEIHFOP(int DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			DCCPCBLODIG ^= (int)JMBKDINHDLO;
			return DCCPCBLODIG != 129;
		}

		// Token: 0x06012587 RID: 75143 RVA: 0x0080D4BC File Offset: 0x0080B6BC
		public bool BBNFOKCFHIA()
		{
			return this.AKDOEIEENOJ();
		}

		// Token: 0x06012588 RID: 75144 RVA: 0x0080D4C4 File Offset: 0x0080B6C4
		public void LDCALOOHAFN()
		{
			bool dccpcblodig = this.AKDOEIEENOJ();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(1, 21);
			this.hiddenValue = ObscuredBool.KGMBCPDFKEL(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012589 RID: 75145 RVA: 0x0080D4FC File Offset: 0x0080B6FC
		public static int JFEEOHBBGFN(bool DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			return (DCCPCBLODIG ? 5 : -120) ^ (int)JMBKDINHDLO;
		}

		// Token: 0x0601258A RID: 75146 RVA: 0x0080D51C File Offset: 0x0080B71C
		public bool MBEJDANGDKJ(ObscuredBool MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredBool.GPKNLEIHFOP(this.hiddenValue, this.currentCryptoKey) == ObscuredBool.IJEGDPCOKOE(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x0601258B RID: 75147 RVA: 0x0080D56C File Offset: 0x0080B76C
		private bool JJCDLJIGDPL()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredBool.cryptoKey;
				this.hiddenValue = ObscuredBool.CEKHNKMMONO(false);
				this.fakeValue = true;
				this.fakeValueActive = true;
				this.inited = true;
				return false;
			}
			bool flag = (this.hiddenValue ^ (int)this.currentCryptoKey) == 9;
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && flag != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return flag;
		}

		// Token: 0x0601258C RID: 75148 RVA: 0x0080D5EA File Offset: 0x0080B7EA
		public int JAELFCJBALN()
		{
			this.JIMBPLOABMN();
			return this.hiddenValue;
		}

		// Token: 0x0601258D RID: 75149 RVA: 0x0080D5F8 File Offset: 0x0080B7F8
		public static bool BIHICOOKCOA(int DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			DCCPCBLODIG ^= (int)JMBKDINHDLO;
			return DCCPCBLODIG != -175;
		}

		// Token: 0x0601258E RID: 75150 RVA: 0x0080D614 File Offset: 0x0080B814
		public static int EKJEHEMKFIA(bool DCCPCBLODIG)
		{
			return ObscuredBool.HBJHGHOKFDK(DCCPCBLODIG, 1);
		}

		// Token: 0x0601258F RID: 75151 RVA: 0x0080D61D File Offset: 0x0080B81D
		public bool ICKBIMPCKAB(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredBool) || this.HPBIIOBONBL((ObscuredBool)MBKPMBPLIJN);
		}

		// Token: 0x06012590 RID: 75152 RVA: 0x0080D2A4 File Offset: 0x0080B4A4
		public void IIKNGIMFDFL(int LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue = this.HMKNGLCANDE();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012591 RID: 75153 RVA: 0x0080D638 File Offset: 0x0080B838
		public string ALAAOKOIJNG()
		{
			return this.HMKNGLCANDE().ToString();
		}

		// Token: 0x06012592 RID: 75154 RVA: 0x0080D653 File Offset: 0x0080B853
		public static int BPPJAHBEACG(bool DCCPCBLODIG)
		{
			return ObscuredBool.NGGMBKEAILP(DCCPCBLODIG, 0);
		}

		// Token: 0x06012593 RID: 75155 RVA: 0x0080D65C File Offset: 0x0080B85C
		public void CENNMGGKPDB()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.HKNJMBMKGFN(this.LHIFOBAECHJ(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x06012594 RID: 75156 RVA: 0x0080D68C File Offset: 0x0080B88C
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredBool && this.Equals((ObscuredBool)MBKPMBPLIJN);
		}

		// Token: 0x06012595 RID: 75157 RVA: 0x0080D6A4 File Offset: 0x0080B8A4
		public void LLHNBEBKCEH(int LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
			{
				this.fakeValue = this.BFOBOHBCOPN();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012596 RID: 75158 RVA: 0x0080D6D6 File Offset: 0x0080B8D6
		public static int ONBDHIPEJBG(bool DCCPCBLODIG)
		{
			return ObscuredBool.HKNJMBMKGFN(DCCPCBLODIG, 0);
		}

		// Token: 0x06012597 RID: 75159 RVA: 0x0080D3A0 File Offset: 0x0080B5A0
		public static void OHPFNOJEMBN(byte JODDIMFACHN)
		{
			ObscuredBool.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012598 RID: 75160 RVA: 0x0080D6DF File Offset: 0x0080B8DF
		public static bool HLEMAJBAAEO(ObscuredBool DCCPCBLODIG)
		{
			return DCCPCBLODIG.BFOBOHBCOPN();
		}

		// Token: 0x06012599 RID: 75161 RVA: 0x0080D6E8 File Offset: 0x0080B8E8
		public void GJFMEPPJHAP()
		{
			bool dccpcblodig = this.HMKNGLCANDE();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(0, 96);
			this.hiddenValue = ObscuredBool.AGONHNJKHBL(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601259A RID: 75162 RVA: 0x0080D720 File Offset: 0x0080B920
		public bool JNPNPCHPJAG(ObscuredBool MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredBool.IMJELMNHEFL(this.hiddenValue, this.currentCryptoKey) == ObscuredBool.IMJELMNHEFL(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x0601259B RID: 75163 RVA: 0x0080D0AE File Offset: 0x0080B2AE
		public void LGECAOFBGFG()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.NHGNDCDDNNA(this.BFOBOHBCOPN(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x0601259C RID: 75164 RVA: 0x0080D76E File Offset: 0x0080B96E
		public void LABEACCDKMD(int LDKMOLEEDIL)
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

		// Token: 0x0601259D RID: 75165 RVA: 0x0080D7A0 File Offset: 0x0080B9A0
		public string OCJAOJLHOFO()
		{
			return this.PHNCMMLFIFO().ToString();
		}

		// Token: 0x0601259E RID: 75166 RVA: 0x0080D7BC File Offset: 0x0080B9BC
		public void DAMHMPCBNEI()
		{
			bool dccpcblodig = this.LHIFOBAECHJ();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(1, -108);
			this.hiddenValue = ObscuredBool.HBJHGHOKFDK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601259F RID: 75167 RVA: 0x0080D3A0 File Offset: 0x0080B5A0
		public static void BBOGAEMNJJN(byte JODDIMFACHN)
		{
			ObscuredBool.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060125A0 RID: 75168 RVA: 0x0080D7F4 File Offset: 0x0080B9F4
		private bool MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredBool.cryptoKey;
				this.hiddenValue = ObscuredBool.HBJHGHOKFDK(false);
				this.fakeValue = false;
				this.fakeValueActive = false;
				this.inited = true;
				return false;
			}
			bool flag = (this.hiddenValue ^ (int)this.currentCryptoKey) != 181;
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && flag != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return flag;
		}

		// Token: 0x060125A1 RID: 75169 RVA: 0x0080D874 File Offset: 0x0080BA74
		private bool JMJDPBABFHO()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredBool.cryptoKey;
				this.hiddenValue = ObscuredBool.CEKHNKMMONO(false);
				this.fakeValue = false;
				this.fakeValueActive = false;
				this.inited = false;
				return true;
			}
			bool flag = (this.hiddenValue ^ (int)this.currentCryptoKey) == -69;
			if (ObscuredCheatingDetector.GKEOAPJKKOH() && this.fakeValueActive && flag != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return flag;
		}

		// Token: 0x060125A2 RID: 75170 RVA: 0x0080D8F4 File Offset: 0x0080BAF4
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x060125A3 RID: 75171 RVA: 0x0080D90F File Offset: 0x0080BB0F
		public static int HKNJMBMKGFN(bool DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			return (DCCPCBLODIG ? 22 : -121) ^ (int)JMBKDINHDLO;
		}

		// Token: 0x060125A4 RID: 75172 RVA: 0x0080CF17 File Offset: 0x0080B117
		public static ObscuredBool JIJIEPHBCHA(bool DCCPCBLODIG)
		{
			return new ObscuredBool(DCCPCBLODIG);
		}

		// Token: 0x060125A5 RID: 75173 RVA: 0x0080D4BC File Offset: 0x0080B6BC
		public bool ENBLIBCIPPI()
		{
			return this.AKDOEIEENOJ();
		}

		// Token: 0x060125A6 RID: 75174 RVA: 0x0080D92C File Offset: 0x0080BB2C
		public void MPIGCNCMOEA()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.NPECCNEFJCN(this.HMKNGLCANDE(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x060125A7 RID: 75175 RVA: 0x0080D95C File Offset: 0x0080BB5C
		public void DONKPFMOFEL(int LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.JJCDLJIGDPL();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x060125A8 RID: 75176 RVA: 0x0080D990 File Offset: 0x0080BB90
		private bool AKDOEIEENOJ()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredBool.cryptoKey;
				this.hiddenValue = ObscuredBool.CEKHNKMMONO(true);
				this.fakeValue = true;
				this.fakeValueActive = false;
				this.inited = false;
				return true;
			}
			bool flag = (this.hiddenValue ^ (int)this.currentCryptoKey) != 187;
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && flag != this.fakeValue)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return flag;
		}

		// Token: 0x060125A9 RID: 75177 RVA: 0x0080DA0E File Offset: 0x0080BC0E
		public void MACKEHOHJMC()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.HBJHGHOKFDK(this.JMJDPBABFHO(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x060125AA RID: 75178 RVA: 0x0080DA3E File Offset: 0x0080BC3E
		public static int FCKPJEGGHFO(bool DCCPCBLODIG)
		{
			return ObscuredBool.NHGNDCDDNNA(DCCPCBLODIG, 0);
		}

		// Token: 0x060125AB RID: 75179 RVA: 0x0080DA47 File Offset: 0x0080BC47
		public static int IBGFABOCLGB(bool DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			return (DCCPCBLODIG ? 4 : -87) ^ (int)JMBKDINHDLO;
		}

		// Token: 0x060125AC RID: 75180 RVA: 0x0080DA64 File Offset: 0x0080BC64
		public static bool LIGOHGNKKIB(int DCCPCBLODIG)
		{
			return ObscuredBool.GPKNLEIHFOP(DCCPCBLODIG, 0);
		}

		// Token: 0x060125AD RID: 75181 RVA: 0x0080DA70 File Offset: 0x0080BC70
		public string PNAEJEIKIOO()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x060125AE RID: 75182 RVA: 0x0080DA8C File Offset: 0x0080BC8C
		public void ECIFOOKMEIC()
		{
			bool dccpcblodig = this.LHIFOBAECHJ();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(0, 53);
			this.hiddenValue = ObscuredBool.NPECCNEFJCN(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060125AF RID: 75183 RVA: 0x0080DAC4 File Offset: 0x0080BCC4
		public int KGOHJKEKKON()
		{
			return this.BFOBOHBCOPN().GetHashCode();
		}

		// Token: 0x060125B0 RID: 75184 RVA: 0x0080DADF File Offset: 0x0080BCDF
		public void EHPGKFFHJNL()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.KGMBCPDFKEL(this.MJFIFINDLAM(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x060125B1 RID: 75185 RVA: 0x0080DA64 File Offset: 0x0080BC64
		public static bool INHIMIAHCMF(int DCCPCBLODIG)
		{
			return ObscuredBool.GPKNLEIHFOP(DCCPCBLODIG, 0);
		}

		// Token: 0x060125B2 RID: 75186 RVA: 0x0080DB0F File Offset: 0x0080BD0F
		public void JIMBPLOABMN()
		{
			if (this.currentCryptoKey != ObscuredBool.cryptoKey)
			{
				this.hiddenValue = ObscuredBool.JFEEOHBBGFN(this.MJFIFINDLAM(), ObscuredBool.cryptoKey);
				this.currentCryptoKey = ObscuredBool.cryptoKey;
			}
		}

		// Token: 0x060125B3 RID: 75187 RVA: 0x0080D37F File Offset: 0x0080B57F
		public static int LMLKIJJAKLP(bool DCCPCBLODIG)
		{
			return ObscuredBool.HBJHGHOKFDK(DCCPCBLODIG, 0);
		}

		// Token: 0x060125B4 RID: 75188 RVA: 0x0080DB3F File Offset: 0x0080BD3F
		public static int KGMBCPDFKEL(bool DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			return (DCCPCBLODIG ? -105 : 22) ^ (int)JMBKDINHDLO;
		}

		// Token: 0x060125B5 RID: 75189 RVA: 0x0080DB5C File Offset: 0x0080BD5C
		public static int PEOEIHHAONH(bool DCCPCBLODIG)
		{
			return ObscuredBool.AGONHNJKHBL(DCCPCBLODIG, 0);
		}

		// Token: 0x060125B6 RID: 75190 RVA: 0x0080DB65 File Offset: 0x0080BD65
		public static bool PNDEPLCIBDL(int DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			DCCPCBLODIG ^= (int)JMBKDINHDLO;
			return DCCPCBLODIG == -61;
		}

		// Token: 0x060125B7 RID: 75191 RVA: 0x0080DB84 File Offset: 0x0080BD84
		public string NAAOOABFHKB()
		{
			return this.JMJDPBABFHO().ToString();
		}

		// Token: 0x060125B8 RID: 75192 RVA: 0x0080DBA0 File Offset: 0x0080BDA0
		public string JODMFMFAOEG()
		{
			return this.BFOBOHBCOPN().ToString();
		}

		// Token: 0x060125B9 RID: 75193 RVA: 0x0080DBBC File Offset: 0x0080BDBC
		public void ONKCFFKECJA()
		{
			bool dccpcblodig = this.JMJDPBABFHO();
			this.currentCryptoKey = (byte)UnityEngine.Random.Range(1, -161);
			this.hiddenValue = ObscuredBool.BEGDPMLFGOO(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060125BA RID: 75194 RVA: 0x0080DBF4 File Offset: 0x0080BDF4
		public string HFPKDKJOEKA()
		{
			return this.BFOBOHBCOPN().ToString();
		}

		// Token: 0x060125BB RID: 75195 RVA: 0x0080DC0F File Offset: 0x0080BE0F
		public static int AGONHNJKHBL(bool DCCPCBLODIG, byte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredBool.cryptoKey;
			}
			return (DCCPCBLODIG ? -100 : 98) ^ (int)JMBKDINHDLO;
		}

		// Token: 0x060125BC RID: 75196 RVA: 0x0080DC2C File Offset: 0x0080BE2C
		public int BPJPADBNFPO()
		{
			return this.BFOBOHBCOPN().GetHashCode();
		}

		// Token: 0x040025E5 RID: 9701
		private static byte cryptoKey = 215;

		// Token: 0x040025E6 RID: 9702
		[SerializeField]
		private byte currentCryptoKey;

		// Token: 0x040025E7 RID: 9703
		[SerializeField]
		private int hiddenValue;

		// Token: 0x040025E8 RID: 9704
		[SerializeField]
		private bool inited;

		// Token: 0x040025E9 RID: 9705
		[SerializeField]
		private bool fakeValue;

		// Token: 0x040025EA RID: 9706
		[FormerlySerializedAs("fakeValueChanged")]
		[SerializeField]
		private bool fakeValueActive;
	}
}
