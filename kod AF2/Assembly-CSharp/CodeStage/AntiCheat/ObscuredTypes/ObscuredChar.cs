using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200057D RID: 1405
	[Serializable]
	public struct ObscuredChar : IEquatable<ObscuredChar>
	{
		// Token: 0x06012639 RID: 75321 RVA: 0x0080ECF7 File Offset: 0x0080CEF7
		public static ObscuredChar GOOIABGKMHK(char DCCPCBLODIG)
		{
			return new ObscuredChar(DCCPCBLODIG);
		}

		// Token: 0x0601263A RID: 75322 RVA: 0x0080ECF7 File Offset: 0x0080CEF7
		public static ObscuredChar KNFNKGJGDAB(char DCCPCBLODIG)
		{
			return new ObscuredChar(DCCPCBLODIG);
		}

		// Token: 0x0601263B RID: 75323 RVA: 0x0080ECFF File Offset: 0x0080CEFF
		public void FGOMIBCGPOB(char LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x0601263C RID: 75324 RVA: 0x0080ED34 File Offset: 0x0080CF34
		public void OJFAJIJBEFD()
		{
			char dccpcblodig = this.MJFIFINDLAM();
			this.currentCryptoKey = (char)UnityEngine.Random.Range(1, 65535);
			this.hiddenValue = ObscuredChar.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601263D RID: 75325 RVA: 0x0080ED6C File Offset: 0x0080CF6C
		private char OHBABIDAIPJ()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredChar.cryptoKey;
				this.hiddenValue = ObscuredChar.GNNHJEHHMHE('\u0001');
				this.fakeValue = '\u0001';
				this.fakeValueActive = true;
				this.inited = true;
				return '\0';
			}
			char c = ObscuredChar.IBNGELFOACA(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && c != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return c;
		}

		// Token: 0x0601263E RID: 75326 RVA: 0x0080EDE4 File Offset: 0x0080CFE4
		public bool FFGIMBGINCG(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredChar && this.FEKPJCEOAJK((ObscuredChar)MBKPMBPLIJN);
		}

		// Token: 0x0601263F RID: 75327 RVA: 0x0080EDFC File Offset: 0x0080CFFC
		public bool AKNGIFMHCKC(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredChar) || this.Equals((ObscuredChar)MBKPMBPLIJN);
		}

		// Token: 0x06012640 RID: 75328 RVA: 0x0080EE14 File Offset: 0x0080D014
		public static ObscuredChar ABFBJIGEJCP(ObscuredChar NFKFMIIAKFN)
		{
			char dccpcblodig = NFKFMIIAKFN.IPNLOIPBMGC() - '\0';
			NFKFMIIAKFN.hiddenValue = ObscuredChar.IBNGELFOACA(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012641 RID: 75329 RVA: 0x0080EE61 File Offset: 0x0080D061
		public char GMOJBMODFDI()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012642 RID: 75330 RVA: 0x0080EE6F File Offset: 0x0080D06F
		public char CNDKGPMFKPI()
		{
			return this.GLIIBCLNIPD();
		}

		// Token: 0x06012643 RID: 75331 RVA: 0x0080EE78 File Offset: 0x0080D078
		public int OJEDIMJIDCE()
		{
			return this.OHBABIDAIPJ().GetHashCode();
		}

		// Token: 0x06012644 RID: 75332 RVA: 0x0080EE93 File Offset: 0x0080D093
		public bool AFDHOIDFLJA(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredChar) || this.FEKPJCEOAJK((ObscuredChar)MBKPMBPLIJN);
		}

		// Token: 0x06012645 RID: 75333 RVA: 0x0080EEAC File Offset: 0x0080D0AC
		public bool FEKPJCEOAJK(ObscuredChar MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredChar.IBNGELFOACA(this.hiddenValue, this.currentCryptoKey) == ObscuredChar.LODBMHGCJFC(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012646 RID: 75334 RVA: 0x0080EEFA File Offset: 0x0080D0FA
		public static char GNNHJEHHMHE(char DCCPCBLODIG)
		{
			return ObscuredChar.LODBMHGCJFC(DCCPCBLODIG, '\0');
		}

		// Token: 0x06012647 RID: 75335 RVA: 0x0080EF03 File Offset: 0x0080D103
		public static char GOOIABGKMHK(ObscuredChar DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012648 RID: 75336 RVA: 0x0080EF0C File Offset: 0x0080D10C
		public char IGHNNEPINAM()
		{
			this.NHOCPGGBGAD();
			return this.hiddenValue;
		}

		// Token: 0x06012649 RID: 75337 RVA: 0x0080EE61 File Offset: 0x0080D061
		public char LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x0601264A RID: 75338 RVA: 0x0080EF1A File Offset: 0x0080D11A
		public static void ABIDDAAKMFN(char JODDIMFACHN)
		{
			ObscuredChar.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601264B RID: 75339 RVA: 0x0080EF24 File Offset: 0x0080D124
		private char IPNLOIPBMGC()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredChar.cryptoKey;
				this.hiddenValue = ObscuredChar.BAGJLCKPIND('\0');
				this.fakeValue = '\0';
				this.fakeValueActive = true;
				this.inited = true;
				return '\0';
			}
			char c = ObscuredChar.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.CKFIDHHGLGO() && this.fakeValueActive && c != this.fakeValue)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return c;
		}

		// Token: 0x0601264C RID: 75340 RVA: 0x0080EF9C File Offset: 0x0080D19C
		public static char LODBMHGCJFC(char DCCPCBLODIG, char JMBKDINHDLO)
		{
			if (JMBKDINHDLO == '\0')
			{
				return DCCPCBLODIG ^ ObscuredChar.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x0601264D RID: 75341 RVA: 0x0080EFB0 File Offset: 0x0080D1B0
		private char OOEKLDBGDBB()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredChar.cryptoKey;
				this.hiddenValue = ObscuredChar.HCJBAFMJBBJ('\0');
				this.fakeValue = '\u0001';
				this.fakeValueActive = true;
				this.inited = true;
				return '\0';
			}
			char c = ObscuredChar.LODBMHGCJFC(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && c != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return c;
		}

		// Token: 0x0601264F RID: 75343 RVA: 0x0080EF1A File Offset: 0x0080D11A
		public static void BBOGAEMNJJN(char JODDIMFACHN)
		{
			ObscuredChar.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012650 RID: 75344 RVA: 0x0080F034 File Offset: 0x0080D234
		private ObscuredChar(char DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredChar.cryptoKey;
			this.hiddenValue = ObscuredChar.KOJLJMMMJGP(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : '\0');
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x06012651 RID: 75345 RVA: 0x0080F07C File Offset: 0x0080D27C
		public string JKGHGFFFGEH()
		{
			return this.IPNLOIPBMGC().ToString();
		}

		// Token: 0x06012652 RID: 75346 RVA: 0x0080ECF7 File Offset: 0x0080CEF7
		public static ObscuredChar BCLJOMMFGEN(char DCCPCBLODIG)
		{
			return new ObscuredChar(DCCPCBLODIG);
		}

		// Token: 0x06012653 RID: 75347 RVA: 0x0080F098 File Offset: 0x0080D298
		private char GLIIBCLNIPD()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredChar.cryptoKey;
				this.hiddenValue = ObscuredChar.BAGJLCKPIND('\0');
				this.fakeValue = '\u0001';
				this.fakeValueActive = true;
				this.inited = false;
				return '\u0001';
			}
			char c = ObscuredChar.IBNGELFOACA(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.CKFIDHHGLGO() && this.fakeValueActive && c != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return c;
		}

		// Token: 0x06012654 RID: 75348 RVA: 0x0080F110 File Offset: 0x0080D310
		public static ObscuredChar HIBLFIAPCJE(ObscuredChar NFKFMIIAKFN)
		{
			char dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + '\u0001';
			NFKFMIIAKFN.hiddenValue = ObscuredChar.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012655 RID: 75349 RVA: 0x0080F160 File Offset: 0x0080D360
		public string DHCBHNAAJKI(IFormatProvider MCGFPOIAPGJ)
		{
			return this.GLIIBCLNIPD().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012656 RID: 75350 RVA: 0x0080F17C File Offset: 0x0080D37C
		public static char PHAFMAPMOJD(char DCCPCBLODIG)
		{
			return ObscuredChar.LODBMHGCJFC(DCCPCBLODIG, '\u0001');
		}

		// Token: 0x06012657 RID: 75351 RVA: 0x0080F185 File Offset: 0x0080D385
		public void LABEACCDKMD(char LDKMOLEEDIL)
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

		// Token: 0x06012658 RID: 75352 RVA: 0x0080F1B8 File Offset: 0x0080D3B8
		public static ObscuredChar EADJAADOFKL(ObscuredChar NFKFMIIAKFN)
		{
			char dccpcblodig = NFKFMIIAKFN.OHBABIDAIPJ() - '\0';
			NFKFMIIAKFN.hiddenValue = ObscuredChar.IBNGELFOACA(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
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

		// Token: 0x06012659 RID: 75353 RVA: 0x0080F208 File Offset: 0x0080D408
		public static ObscuredChar IDJOHNGNPGH(ObscuredChar NFKFMIIAKFN)
		{
			char dccpcblodig = NFKFMIIAKFN.OHBABIDAIPJ() + '\0';
			NFKFMIIAKFN.hiddenValue = ObscuredChar.LODBMHGCJFC(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
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

		// Token: 0x0601265A RID: 75354 RVA: 0x0080F255 File Offset: 0x0080D455
		public char ALNLLOGIAMB()
		{
			this.DCPMKLBOCDA();
			return this.hiddenValue;
		}

		// Token: 0x0601265B RID: 75355 RVA: 0x0080EF9C File Offset: 0x0080D19C
		public static char IBNGELFOACA(char DCCPCBLODIG, char JMBKDINHDLO)
		{
			if (JMBKDINHDLO == '\0')
			{
				return DCCPCBLODIG ^ ObscuredChar.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x0601265C RID: 75356 RVA: 0x0080F263 File Offset: 0x0080D463
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredChar && this.Equals((ObscuredChar)MBKPMBPLIJN);
		}

		// Token: 0x0601265D RID: 75357 RVA: 0x0080F27B File Offset: 0x0080D47B
		public void DCPMKLBOCDA()
		{
			if (this.currentCryptoKey != ObscuredChar.cryptoKey)
			{
				this.hiddenValue = ObscuredChar.KOJLJMMMJGP(this.IPNLOIPBMGC(), ObscuredChar.cryptoKey);
				this.currentCryptoKey = ObscuredChar.cryptoKey;
			}
		}

		// Token: 0x0601265E RID: 75358 RVA: 0x0080F2AB File Offset: 0x0080D4AB
		public static char KOJLJMMMJGP(char DCCPCBLODIG)
		{
			return ObscuredChar.KOJLJMMMJGP(DCCPCBLODIG, '\0');
		}

		// Token: 0x0601265F RID: 75359 RVA: 0x0080F2B4 File Offset: 0x0080D4B4
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredChar.cryptoKey)
			{
				this.hiddenValue = ObscuredChar.KOJLJMMMJGP(this.MJFIFINDLAM(), ObscuredChar.cryptoKey);
				this.currentCryptoKey = ObscuredChar.cryptoKey;
			}
		}

		// Token: 0x06012660 RID: 75360 RVA: 0x0080F2E4 File Offset: 0x0080D4E4
		public bool Equals(ObscuredChar MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredChar.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredChar.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012661 RID: 75361 RVA: 0x0080F332 File Offset: 0x0080D532
		public void NHOCPGGBGAD()
		{
			if (this.currentCryptoKey != ObscuredChar.cryptoKey)
			{
				this.hiddenValue = ObscuredChar.IBNGELFOACA(this.GLIIBCLNIPD(), ObscuredChar.cryptoKey);
				this.currentCryptoKey = ObscuredChar.cryptoKey;
			}
		}

		// Token: 0x06012662 RID: 75362 RVA: 0x0080F364 File Offset: 0x0080D564
		public static ObscuredChar ALCAEIGIKKG(ObscuredChar NFKFMIIAKFN)
		{
			char dccpcblodig = NFKFMIIAKFN.OOEKLDBGDBB() - '\u0001';
			NFKFMIIAKFN.hiddenValue = ObscuredChar.IBNGELFOACA(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
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

		// Token: 0x06012663 RID: 75363 RVA: 0x0080F3B4 File Offset: 0x0080D5B4
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012664 RID: 75364 RVA: 0x0080F3D0 File Offset: 0x0080D5D0
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012665 RID: 75365 RVA: 0x0080F3EC File Offset: 0x0080D5EC
		public void OAIEKILBONK()
		{
			char dccpcblodig = this.OOEKLDBGDBB();
			this.currentCryptoKey = (char)UnityEngine.Random.Range(1, 159);
			this.hiddenValue = ObscuredChar.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012666 RID: 75366 RVA: 0x0080F424 File Offset: 0x0080D624
		public static ObscuredChar HBPINGNDEFF(ObscuredChar NFKFMIIAKFN)
		{
			char dccpcblodig = NFKFMIIAKFN.OOEKLDBGDBB() - '\0';
			NFKFMIIAKFN.hiddenValue = ObscuredChar.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
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

		// Token: 0x06012667 RID: 75367 RVA: 0x0080F474 File Offset: 0x0080D674
		public static ObscuredChar DPCDNMHLOJF(ObscuredChar NFKFMIIAKFN)
		{
			char dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - '\u0001';
			NFKFMIIAKFN.hiddenValue = ObscuredChar.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012668 RID: 75368 RVA: 0x0080EDFC File Offset: 0x0080CFFC
		public bool CNKPPKOFCNH(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredChar) || this.Equals((ObscuredChar)MBKPMBPLIJN);
		}

		// Token: 0x06012669 RID: 75369 RVA: 0x0080F4C4 File Offset: 0x0080D6C4
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x0601266A RID: 75370 RVA: 0x0080F4E0 File Offset: 0x0080D6E0
		private char MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredChar.cryptoKey;
				this.hiddenValue = ObscuredChar.KOJLJMMMJGP('\0');
				this.fakeValue = '\0';
				this.fakeValueActive = false;
				this.inited = true;
				return '\0';
			}
			char c = ObscuredChar.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && c != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return c;
		}

		// Token: 0x0601266B RID: 75371 RVA: 0x0080EF9C File Offset: 0x0080D19C
		public static char KOJLJMMMJGP(char DCCPCBLODIG, char JMBKDINHDLO)
		{
			if (JMBKDINHDLO == '\0')
			{
				return DCCPCBLODIG ^ ObscuredChar.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x0601266C RID: 75372 RVA: 0x0080F2AB File Offset: 0x0080D4AB
		public static char HCJBAFMJBBJ(char DCCPCBLODIG)
		{
			return ObscuredChar.KOJLJMMMJGP(DCCPCBLODIG, '\0');
		}

		// Token: 0x0601266D RID: 75373 RVA: 0x0080F558 File Offset: 0x0080D758
		public char FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x0601266E RID: 75374 RVA: 0x0080F560 File Offset: 0x0080D760
		public string HDPLEBMIHFA(IFormatProvider MCGFPOIAPGJ)
		{
			return this.IPNLOIPBMGC().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x0601266F RID: 75375 RVA: 0x0080EF0C File Offset: 0x0080D10C
		public char MCCJEFAFGNM()
		{
			this.NHOCPGGBGAD();
			return this.hiddenValue;
		}

		// Token: 0x06012670 RID: 75376 RVA: 0x0080EEFA File Offset: 0x0080D0FA
		public static char BAGJLCKPIND(char DCCPCBLODIG)
		{
			return ObscuredChar.LODBMHGCJFC(DCCPCBLODIG, '\0');
		}

		// Token: 0x040025F1 RID: 9713
		private static char cryptoKey = '—';

		// Token: 0x040025F2 RID: 9714
		private char currentCryptoKey;

		// Token: 0x040025F3 RID: 9715
		private char hiddenValue;

		// Token: 0x040025F4 RID: 9716
		private bool inited;

		// Token: 0x040025F5 RID: 9717
		private char fakeValue;

		// Token: 0x040025F6 RID: 9718
		private bool fakeValueActive;
	}
}
