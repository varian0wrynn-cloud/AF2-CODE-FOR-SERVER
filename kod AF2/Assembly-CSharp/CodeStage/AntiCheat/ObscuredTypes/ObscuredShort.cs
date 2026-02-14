using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200058D RID: 1421
	[Serializable]
	public struct ObscuredShort : IEquatable<ObscuredShort>, IFormattable
	{
		// Token: 0x06012A42 RID: 76354 RVA: 0x00819790 File Offset: 0x00817990
		public string GAPOIDIICOL(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.AOMANFJPLAH().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012A43 RID: 76355 RVA: 0x008197AD File Offset: 0x008179AD
		public bool CJCOEFNMNNI(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredShort) || this.MBEJDANGDKJ((ObscuredShort)MBKPMBPLIJN);
		}

		// Token: 0x06012A44 RID: 76356 RVA: 0x008197C8 File Offset: 0x008179C8
		public bool FFGIMBGINCG(ObscuredShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredShort.OFBKNLAADFM(this.hiddenValue, this.currentCryptoKey) == ObscuredShort.IIFBFMAJDJM(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012A45 RID: 76357 RVA: 0x00819818 File Offset: 0x00817A18
		public static ObscuredShort HIBLFIAPCJE(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.KOJLJMMMJGP(dccpcblodig);
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

		// Token: 0x06012A46 RID: 76358 RVA: 0x0081985F File Offset: 0x00817A5F
		public static short BJIPLCGOBII(short DCCPCBLODIG)
		{
			return ObscuredShort.ACEMEMNGCBO(DCCPCBLODIG, 1);
		}

		// Token: 0x06012A47 RID: 76359 RVA: 0x00819868 File Offset: 0x00817A68
		public static short JFMOPOGDLDH(short DCCPCBLODIG)
		{
			return ObscuredShort.HGCCBLGIMIL(DCCPCBLODIG, 1);
		}

		// Token: 0x06012A48 RID: 76360 RVA: 0x00819871 File Offset: 0x00817A71
		public bool LDHBIOHKFMA(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredShort && this.MBEJDANGDKJ((ObscuredShort)MBKPMBPLIJN);
		}

		// Token: 0x06012A49 RID: 76361 RVA: 0x00819889 File Offset: 0x00817A89
		public void JKEAIHPABOP()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.IIFBFMAJDJM(this.MJFIFINDLAM(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012A4A RID: 76362 RVA: 0x008198B9 File Offset: 0x00817AB9
		public bool PADMCNBDIJO(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredShort && this.Equals((ObscuredShort)MBKPMBPLIJN);
		}

		// Token: 0x06012A4B RID: 76363 RVA: 0x008198D1 File Offset: 0x00817AD1
		public static ObscuredShort APFECJKCPPB(short DCCPCBLODIG)
		{
			return new ObscuredShort(DCCPCBLODIG);
		}

		// Token: 0x06012A4C RID: 76364 RVA: 0x008198D9 File Offset: 0x00817AD9
		public void MDEADHLEFBC(short LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.EMMHFEBNKLG();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012A4D RID: 76365 RVA: 0x0081990C File Offset: 0x00817B0C
		private short EMMHFEBNKLG()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredShort.cryptoKey;
				this.hiddenValue = ObscuredShort.ANHANMIFKCF(0);
				this.fakeValue = 1;
				this.fakeValueActive = false;
				this.inited = true;
				return 1;
			}
			short num = ObscuredShort.IIFBFMAJDJM(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012A4E RID: 76366 RVA: 0x00819984 File Offset: 0x00817B84
		public static ObscuredShort DPCDNMHLOJF(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.KOJLJMMMJGP(dccpcblodig);
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

		// Token: 0x06012A4F RID: 76367 RVA: 0x008199CC File Offset: 0x00817BCC
		public void LHGFBJDPKMJ()
		{
			short dccpcblodig = this.NNDDLHNEONC();
			do
			{
				this.currentCryptoKey = (short)UnityEngine.Random.Range(156, -121);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredShort.HGCCBLGIMIL(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012A50 RID: 76368 RVA: 0x00819A10 File Offset: 0x00817C10
		public int JMJMLIDOFMA()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012A51 RID: 76369 RVA: 0x00819A2C File Offset: 0x00817C2C
		public bool Equals(ObscuredShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredShort.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012A52 RID: 76370 RVA: 0x00819A7C File Offset: 0x00817C7C
		public static ObscuredShort IIEMHOILFNJ(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.KFCKDEAEGNL() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.KEFENIPEPPM(dccpcblodig);
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

		// Token: 0x06012A53 RID: 76371 RVA: 0x00819AC4 File Offset: 0x00817CC4
		public void AGIGJIBMAMF()
		{
			short dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (short)UnityEngine.Random.Range(-132, -142);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredShort.IIFBFMAJDJM(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012A54 RID: 76372 RVA: 0x00819B08 File Offset: 0x00817D08
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012A55 RID: 76373 RVA: 0x00819B23 File Offset: 0x00817D23
		public void FKPGFKPKKKD()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.KOJLJMMMJGP(this.MJFIFINDLAM(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012A56 RID: 76374 RVA: 0x00819B54 File Offset: 0x00817D54
		public void LBPPPIJCOME()
		{
			short dccpcblodig = this.EMMHFEBNKLG();
			do
			{
				this.currentCryptoKey = (short)UnityEngine.Random.Range(-145, -134);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredShort.JLGFEMKEHJN(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012A57 RID: 76375 RVA: 0x008198D1 File Offset: 0x00817AD1
		public static ObscuredShort AJEAFNKCACO(short DCCPCBLODIG)
		{
			return new ObscuredShort(DCCPCBLODIG);
		}

		// Token: 0x06012A58 RID: 76376 RVA: 0x00819B98 File Offset: 0x00817D98
		public string HPBHHAKPGAD(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.KFCKDEAEGNL().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012A59 RID: 76377 RVA: 0x00819BB5 File Offset: 0x00817DB5
		public void LABEACCDKMD(short LDKMOLEEDIL)
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

		// Token: 0x06012A5A RID: 76378 RVA: 0x00819BE8 File Offset: 0x00817DE8
		public string DJDAGAEMEDD(string LJCEDKCLBDB)
		{
			return this.OEFPBHKKPPO().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012A5B RID: 76379 RVA: 0x00819C04 File Offset: 0x00817E04
		public int FBDLJALGDLJ()
		{
			return this.PGEAMCEJGGJ().GetHashCode();
		}

		// Token: 0x06012A5C RID: 76380 RVA: 0x00819C20 File Offset: 0x00817E20
		public string OLLACFDNGKI()
		{
			return this.EMMHFEBNKLG().ToString();
		}

		// Token: 0x06012A5D RID: 76381 RVA: 0x00819C3B File Offset: 0x00817E3B
		public void BNMJLMFCDKC()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.ACEMEMNGCBO(this.KFCKDEAEGNL(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012A5E RID: 76382 RVA: 0x00819C6C File Offset: 0x00817E6C
		public int OPHHONIDCEG()
		{
			return this.NNDDLHNEONC().GetHashCode();
		}

		// Token: 0x06012A5F RID: 76383 RVA: 0x00819C87 File Offset: 0x00817E87
		public short DLNBNLKAECL()
		{
			this.IEKFGJCFMFL();
			return this.hiddenValue;
		}

		// Token: 0x06012A60 RID: 76384 RVA: 0x00819C98 File Offset: 0x00817E98
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012A61 RID: 76385 RVA: 0x00819CB4 File Offset: 0x00817EB4
		public void NPDPJPLFOID()
		{
			short dccpcblodig = this.KDGIIHBKGLI();
			do
			{
				this.currentCryptoKey = (short)UnityEngine.Random.Range(-147, -86);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredShort.ACEMEMNGCBO(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012A62 RID: 76386 RVA: 0x00819CF8 File Offset: 0x00817EF8
		public static void MDAKDFDAONB(short JODDIMFACHN)
		{
			ObscuredShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012A63 RID: 76387 RVA: 0x00819D00 File Offset: 0x00817F00
		private short NNDDLHNEONC()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredShort.cryptoKey;
				this.hiddenValue = ObscuredShort.AAONAIGDNHM(0);
				this.fakeValue = 1;
				this.fakeValueActive = false;
				this.inited = true;
				return 1;
			}
			short num = ObscuredShort.GJKHHOELELP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012A64 RID: 76388 RVA: 0x00819D78 File Offset: 0x00817F78
		public static short FKNKIMHNIGL(short DCCPCBLODIG)
		{
			return ObscuredShort.JLGFEMKEHJN(DCCPCBLODIG, 1);
		}

		// Token: 0x06012A65 RID: 76389 RVA: 0x008198D1 File Offset: 0x00817AD1
		public static ObscuredShort DMILLCHBEAG(short DCCPCBLODIG)
		{
			return new ObscuredShort(DCCPCBLODIG);
		}

		// Token: 0x06012A66 RID: 76390 RVA: 0x00819CF8 File Offset: 0x00817EF8
		public static void EMGINJNJHMO(short JODDIMFACHN)
		{
			ObscuredShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012A67 RID: 76391 RVA: 0x00819D81 File Offset: 0x00817F81
		public void HKJPGDJPLNL(short LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.PGEAMCEJGGJ();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012A68 RID: 76392 RVA: 0x00819DB4 File Offset: 0x00817FB4
		public int EKBODBHLGIC()
		{
			return this.EMMHFEBNKLG().GetHashCode();
		}

		// Token: 0x06012A69 RID: 76393 RVA: 0x00819DCF File Offset: 0x00817FCF
		public static short LGFOBFAGFEK(short DCCPCBLODIG)
		{
			return ObscuredShort.IIFBFMAJDJM(DCCPCBLODIG, 1);
		}

		// Token: 0x06012A6A RID: 76394 RVA: 0x00819DD8 File Offset: 0x00817FD8
		public static short IMHGBNKHGIC(short DCCPCBLODIG)
		{
			return ObscuredShort.IIFBFMAJDJM(DCCPCBLODIG, 0);
		}

		// Token: 0x06012A6B RID: 76395 RVA: 0x00819DE1 File Offset: 0x00817FE1
		public static short KOJLJMMMJGP(short DCCPCBLODIG, short JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredShort.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012A6C RID: 76396 RVA: 0x008198D1 File Offset: 0x00817AD1
		public static ObscuredShort JJDNCFDJDMI(short DCCPCBLODIG)
		{
			return new ObscuredShort(DCCPCBLODIG);
		}

		// Token: 0x06012A6D RID: 76397 RVA: 0x00819DF4 File Offset: 0x00817FF4
		public string AHFDMABJGOL(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.PGEAMCEJGGJ().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012A6E RID: 76398 RVA: 0x00819E11 File Offset: 0x00818011
		public short GMGNBANDBLC()
		{
			this.HCFFMPAIBFL();
			return this.hiddenValue;
		}

		// Token: 0x06012A6F RID: 76399 RVA: 0x00819E20 File Offset: 0x00818020
		public string ToString(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012A70 RID: 76400 RVA: 0x00819E40 File Offset: 0x00818040
		public string NEIAHJGEINP(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.NPJOHKJAEPP().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012A71 RID: 76401 RVA: 0x00819E60 File Offset: 0x00818060
		private short KDGIIHBKGLI()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredShort.cryptoKey;
				this.hiddenValue = ObscuredShort.AAONAIGDNHM(1);
				this.fakeValue = 0;
				this.fakeValueActive = true;
				this.inited = true;
				return 0;
			}
			short num = ObscuredShort.HGCCBLGIMIL(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012A72 RID: 76402 RVA: 0x00819ED8 File Offset: 0x008180D8
		public void FKMBPFHKPIK()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.OFBKNLAADFM(this.OEFPBHKKPPO(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012A73 RID: 76403 RVA: 0x00819F08 File Offset: 0x00818108
		public string HLHHDFFDHGL(string LJCEDKCLBDB)
		{
			return this.NNDDLHNEONC().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012A74 RID: 76404 RVA: 0x00819CF8 File Offset: 0x00817EF8
		public static void KLPCNPMJLFO(short JODDIMFACHN)
		{
			ObscuredShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012A75 RID: 76405 RVA: 0x00819F24 File Offset: 0x00818124
		private short KFCKDEAEGNL()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredShort.cryptoKey;
				this.hiddenValue = ObscuredShort.ANHANMIFKCF(1);
				this.fakeValue = 0;
				this.fakeValueActive = true;
				this.inited = true;
				return 0;
			}
			short num = ObscuredShort.HGCCBLGIMIL(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.LHMMLFNJOMC() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012A76 RID: 76406 RVA: 0x00819F9C File Offset: 0x0081819C
		private short AOMANFJPLAH()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredShort.cryptoKey;
				this.hiddenValue = ObscuredShort.IMHGBNKHGIC(1);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = true;
				return 0;
			}
			short num = ObscuredShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.LHMMLFNJOMC() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012A77 RID: 76407 RVA: 0x0081A014 File Offset: 0x00818214
		public string PCCOHCNHMKN(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.EMMHFEBNKLG().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012A78 RID: 76408 RVA: 0x0081A034 File Offset: 0x00818234
		public string PFNDMCPAGLP(IFormatProvider MCGFPOIAPGJ)
		{
			return this.NNDDLHNEONC().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012A79 RID: 76409 RVA: 0x00819CF8 File Offset: 0x00817EF8
		public static void BBOGAEMNJJN(short JODDIMFACHN)
		{
			ObscuredShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012A7A RID: 76410 RVA: 0x0081A050 File Offset: 0x00818250
		public void DNDJCEDGBKP()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.OFBKNLAADFM(this.PGEAMCEJGGJ(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012A7B RID: 76411 RVA: 0x00819CF8 File Offset: 0x00817EF8
		public static void PIOJAFHACHH(short JODDIMFACHN)
		{
			ObscuredShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012A7C RID: 76412 RVA: 0x00819DE1 File Offset: 0x00817FE1
		public static short OFBKNLAADFM(short DCCPCBLODIG, short JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredShort.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012A7D RID: 76413 RVA: 0x0081A080 File Offset: 0x00818280
		public string DINGGHOCDNN(IFormatProvider MCGFPOIAPGJ)
		{
			return this.AOMANFJPLAH().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012A7E RID: 76414 RVA: 0x0081A09C File Offset: 0x0081829C
		public void HCFFMPAIBFL()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.IIFBFMAJDJM(this.KFCKDEAEGNL(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012A7F RID: 76415 RVA: 0x008198B9 File Offset: 0x00817AB9
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredShort && this.Equals((ObscuredShort)MBKPMBPLIJN);
		}

		// Token: 0x06012A80 RID: 76416 RVA: 0x0081A0CC File Offset: 0x008182CC
		public int OLKJMIDDGEE()
		{
			return this.KFCKDEAEGNL().GetHashCode();
		}

		// Token: 0x06012A81 RID: 76417 RVA: 0x00819871 File Offset: 0x00817A71
		public bool JIABCMEOFOO(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredShort && this.MBEJDANGDKJ((ObscuredShort)MBKPMBPLIJN);
		}

		// Token: 0x06012A82 RID: 76418 RVA: 0x0081A0E8 File Offset: 0x008182E8
		public static ObscuredShort FACCJNFGAGB(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.OEFPBHKKPPO() - 0;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.JFMOPOGDLDH(dccpcblodig);
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

		// Token: 0x06012A83 RID: 76419 RVA: 0x00819CF8 File Offset: 0x00817EF8
		public static void CPKJKLFDPGF(short JODDIMFACHN)
		{
			ObscuredShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012A84 RID: 76420 RVA: 0x0081A12F File Offset: 0x0081832F
		public short FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012A85 RID: 76421 RVA: 0x00819DE1 File Offset: 0x00817FE1
		public static short ACEMEMNGCBO(short DCCPCBLODIG, short JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredShort.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012A86 RID: 76422 RVA: 0x0081A138 File Offset: 0x00818338
		public bool MBEJDANGDKJ(ObscuredShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredShort.OFBKNLAADFM(this.hiddenValue, this.currentCryptoKey) == ObscuredShort.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012A87 RID: 76423 RVA: 0x0081A188 File Offset: 0x00818388
		public string ACADOFEHJBN(IFormatProvider MCGFPOIAPGJ)
		{
			return this.KDGIIHBKGLI().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012A88 RID: 76424 RVA: 0x0081A1A4 File Offset: 0x008183A4
		public int LNBHNPKAMAD()
		{
			return this.PGEAMCEJGGJ().GetHashCode();
		}

		// Token: 0x06012A89 RID: 76425 RVA: 0x00819E11 File Offset: 0x00818011
		public short JAELFCJBALN()
		{
			this.HCFFMPAIBFL();
			return this.hiddenValue;
		}

		// Token: 0x06012A8A RID: 76426 RVA: 0x0081A1BF File Offset: 0x008183BF
		public static short KOJLJMMMJGP(short DCCPCBLODIG)
		{
			return ObscuredShort.KOJLJMMMJGP(DCCPCBLODIG, 0);
		}

		// Token: 0x06012A8B RID: 76427 RVA: 0x0081A1C8 File Offset: 0x008183C8
		public void KJHDEAPGNIL()
		{
			short dccpcblodig = this.AOMANFJPLAH();
			do
			{
				this.currentCryptoKey = (short)UnityEngine.Random.Range(-5, -157);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredShort.IIFBFMAJDJM(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012A8C RID: 76428 RVA: 0x0081A20C File Offset: 0x0081840C
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012A8D RID: 76429 RVA: 0x0081A228 File Offset: 0x00818428
		public string FODPNPHBOKL(IFormatProvider MCGFPOIAPGJ)
		{
			return this.AOMANFJPLAH().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012A8E RID: 76430 RVA: 0x0081A244 File Offset: 0x00818444
		public void ECIFOOKMEIC()
		{
			short dccpcblodig = this.KFCKDEAEGNL();
			do
			{
				this.currentCryptoKey = (short)UnityEngine.Random.Range(100, -164);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredShort.HGCCBLGIMIL(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012A8F RID: 76431 RVA: 0x0081A050 File Offset: 0x00818250
		public void LLJFJNHIALN()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.OFBKNLAADFM(this.PGEAMCEJGGJ(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012A90 RID: 76432 RVA: 0x0081A288 File Offset: 0x00818488
		public string JCAONLDGMCJ(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.EMMHFEBNKLG().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012A91 RID: 76433 RVA: 0x0081A2A8 File Offset: 0x008184A8
		public void CGJDCILFKKA()
		{
			short dccpcblodig = this.EMMHFEBNKLG();
			do
			{
				this.currentCryptoKey = (short)UnityEngine.Random.Range(6, -193);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredShort.GJKHHOELELP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012A92 RID: 76434 RVA: 0x00819DE1 File Offset: 0x00817FE1
		public static short GJKHHOELELP(short DCCPCBLODIG, short JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredShort.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012A93 RID: 76435 RVA: 0x0081A2EC File Offset: 0x008184EC
		public string PBAJNDNHIFI(string LJCEDKCLBDB)
		{
			return this.EMMHFEBNKLG().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012A94 RID: 76436 RVA: 0x0081A308 File Offset: 0x00818508
		public short EPGBBBKONJP()
		{
			return this.KFCKDEAEGNL();
		}

		// Token: 0x06012A95 RID: 76437 RVA: 0x0081A310 File Offset: 0x00818510
		public void BLKMLEOBPIA()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.ACEMEMNGCBO(this.MJFIFINDLAM(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012A96 RID: 76438 RVA: 0x0081A340 File Offset: 0x00818540
		public static ObscuredShort ENJHJCFKGIE(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.NPJOHKJAEPP() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.LGFOBFAGFEK(dccpcblodig);
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

		// Token: 0x06012A97 RID: 76439 RVA: 0x0081A050 File Offset: 0x00818250
		public void OENDDFACNCF()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.OFBKNLAADFM(this.PGEAMCEJGGJ(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012A98 RID: 76440 RVA: 0x0081A387 File Offset: 0x00818587
		public bool CBGNFECKLJK(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredShort && this.NAKOEIAFAIG((ObscuredShort)MBKPMBPLIJN);
		}

		// Token: 0x06012A99 RID: 76441 RVA: 0x0081A3A0 File Offset: 0x008185A0
		public bool NAKOEIAFAIG(ObscuredShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredShort.ACEMEMNGCBO(this.hiddenValue, this.currentCryptoKey) == ObscuredShort.ACEMEMNGCBO(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012A9A RID: 76442 RVA: 0x0081A3F0 File Offset: 0x008185F0
		public string OCJAOJLHOFO(string LJCEDKCLBDB)
		{
			return this.NNDDLHNEONC().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012A9B RID: 76443 RVA: 0x008198D1 File Offset: 0x00817AD1
		public static ObscuredShort EMFOKHGIMFM(short DCCPCBLODIG)
		{
			return new ObscuredShort(DCCPCBLODIG);
		}

		// Token: 0x06012A9C RID: 76444 RVA: 0x0081A40C File Offset: 0x0081860C
		public void DIOCOANDMGN()
		{
			short dccpcblodig = this.NPJOHKJAEPP();
			do
			{
				this.currentCryptoKey = (short)UnityEngine.Random.Range(70, 92);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredShort.OFBKNLAADFM(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012A9D RID: 76445 RVA: 0x0081A450 File Offset: 0x00818650
		public string HFPKDKJOEKA(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.KDGIIHBKGLI().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012A9E RID: 76446 RVA: 0x0081A470 File Offset: 0x00818670
		public string CGGKJFBHOMJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.KFCKDEAEGNL().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012A9F RID: 76447 RVA: 0x0081A48C File Offset: 0x0081868C
		public void PJBJKGDJBPP(short LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.AOMANFJPLAH();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012AA0 RID: 76448 RVA: 0x0081A4BE File Offset: 0x008186BE
		public short LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012AA1 RID: 76449 RVA: 0x0081A4CC File Offset: 0x008186CC
		public int JJLGHJBNLOP()
		{
			return this.NPJOHKJAEPP().GetHashCode();
		}

		// Token: 0x06012AA2 RID: 76450 RVA: 0x0081A4E8 File Offset: 0x008186E8
		public int ABHNCADFAFN()
		{
			return this.KFCKDEAEGNL().GetHashCode();
		}

		// Token: 0x06012AA3 RID: 76451 RVA: 0x0081A504 File Offset: 0x00818704
		public static ObscuredShort BODKDEEHAPK(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.KDGIIHBKGLI() - 0;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.KOJLJMMMJGP(dccpcblodig);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
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

		// Token: 0x06012AA4 RID: 76452 RVA: 0x00819CF8 File Offset: 0x00817EF8
		public static void JHELONPKLPM(short JODDIMFACHN)
		{
			ObscuredShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012AA5 RID: 76453 RVA: 0x0081A54C File Offset: 0x0081874C
		public static ObscuredShort NNLDAOHMKKE(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.KDGIIHBKGLI() - 0;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.BJIPLCGOBII(dccpcblodig);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
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

		// Token: 0x06012AA6 RID: 76454 RVA: 0x0081A594 File Offset: 0x00818794
		private short MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredShort.cryptoKey;
				this.hiddenValue = ObscuredShort.KOJLJMMMJGP(0);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = true;
				return 0;
			}
			short num = ObscuredShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012AA7 RID: 76455 RVA: 0x00819CF8 File Offset: 0x00817EF8
		public static void MDLOLJNKLFN(short JODDIMFACHN)
		{
			ObscuredShort.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012AA8 RID: 76456 RVA: 0x0081A60C File Offset: 0x0081880C
		private short NPJOHKJAEPP()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredShort.cryptoKey;
				this.hiddenValue = ObscuredShort.FKNKIMHNIGL(1);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = false;
				return 0;
			}
			short num = ObscuredShort.GJKHHOELELP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012AA9 RID: 76457 RVA: 0x0081A684 File Offset: 0x00818884
		public int FLJDMOJAOPE()
		{
			return this.KDGIIHBKGLI().GetHashCode();
		}

		// Token: 0x06012AAA RID: 76458 RVA: 0x0081A6A0 File Offset: 0x008188A0
		public void OIOJAFHKHJN()
		{
			short dccpcblodig = this.EMMHFEBNKLG();
			do
			{
				this.currentCryptoKey = (short)UnityEngine.Random.Range(-1, -36);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredShort.IIFBFMAJDJM(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012AAB RID: 76459 RVA: 0x0081A6E4 File Offset: 0x008188E4
		public string IAJBLDEDMOP()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012AAC RID: 76460 RVA: 0x0081A6FF File Offset: 0x008188FF
		public void JLAIFJAABML()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.JLGFEMKEHJN(this.MJFIFINDLAM(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012AAD RID: 76461 RVA: 0x0081A730 File Offset: 0x00818930
		private short OEFPBHKKPPO()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredShort.cryptoKey;
				this.hiddenValue = ObscuredShort.KOJLJMMMJGP(1);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = false;
				return 0;
			}
			short num = ObscuredShort.JLGFEMKEHJN(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012AAE RID: 76462 RVA: 0x0081A7A8 File Offset: 0x008189A8
		public static short IAEENOFEBFM(ObscuredShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.AOMANFJPLAH();
		}

		// Token: 0x06012AAF RID: 76463 RVA: 0x0081A7B1 File Offset: 0x008189B1
		public static short KEFENIPEPPM(short DCCPCBLODIG)
		{
			return ObscuredShort.GJKHHOELELP(DCCPCBLODIG, 0);
		}

		// Token: 0x06012AB0 RID: 76464 RVA: 0x0081A7BA File Offset: 0x008189BA
		public void IEKFGJCFMFL()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.ACEMEMNGCBO(this.EMMHFEBNKLG(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012AB1 RID: 76465 RVA: 0x0081A7EA File Offset: 0x008189EA
		public static short BBJLIIEMOFN(ObscuredShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.NNDDLHNEONC();
		}

		// Token: 0x06012AB2 RID: 76466 RVA: 0x0081A7F4 File Offset: 0x008189F4
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012AB3 RID: 76467 RVA: 0x0081A810 File Offset: 0x00818A10
		public void IFDDEMKGOLJ()
		{
			short dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (short)UnityEngine.Random.Range(171, 101);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredShort.IIFBFMAJDJM(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012AB4 RID: 76468 RVA: 0x0081A854 File Offset: 0x00818A54
		public static short IMFBLMAGIDJ(ObscuredShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.OEFPBHKKPPO();
		}

		// Token: 0x06012AB5 RID: 76469 RVA: 0x0081A860 File Offset: 0x00818A60
		public string KCBJCGOINMK(string LJCEDKCLBDB)
		{
			return this.NNDDLHNEONC().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012AB6 RID: 76470 RVA: 0x0081A87C File Offset: 0x00818A7C
		public static ObscuredShort GCKHFKGKOAP(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.NNDDLHNEONC() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.AAONAIGDNHM(dccpcblodig);
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

		// Token: 0x06012AB7 RID: 76471 RVA: 0x0081A8C3 File Offset: 0x00818AC3
		public short LEDFHKMKICG()
		{
			this.NKAJBIADNNE();
			return this.hiddenValue;
		}

		// Token: 0x06012AB8 RID: 76472 RVA: 0x0081A8D4 File Offset: 0x00818AD4
		private ObscuredShort(short DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredShort.cryptoKey;
			this.hiddenValue = ObscuredShort.KOJLJMMMJGP(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : 0);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x06012AB9 RID: 76473 RVA: 0x0081A91C File Offset: 0x00818B1C
		public static ObscuredShort ABFBJIGEJCP(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.OEFPBHKKPPO() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.KOJLJMMMJGP(dccpcblodig);
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
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

		// Token: 0x06012ABA RID: 76474 RVA: 0x00819DE1 File Offset: 0x00817FE1
		public static short JLGFEMKEHJN(short DCCPCBLODIG, short JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredShort.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012ABB RID: 76475 RVA: 0x0081A964 File Offset: 0x00818B64
		public string NDCLLIMPLEE(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.EMMHFEBNKLG().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012ABC RID: 76476 RVA: 0x0081A984 File Offset: 0x00818B84
		public string JMJPJIJNGDO(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.KFCKDEAEGNL().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012ABD RID: 76477 RVA: 0x0081A9A4 File Offset: 0x00818BA4
		public int CLNFKBCNNJC()
		{
			return this.KFCKDEAEGNL().GetHashCode();
		}

		// Token: 0x06012ABE RID: 76478 RVA: 0x0081A9BF File Offset: 0x00818BBF
		public static short GOOIABGKMHK(ObscuredShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012ABF RID: 76479 RVA: 0x00819D81 File Offset: 0x00817F81
		public void OJLMPOIJIEM(short LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.PGEAMCEJGGJ();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012AC0 RID: 76480 RVA: 0x0081A9C8 File Offset: 0x00818BC8
		public bool DIJEJKHBKOF(ObscuredShort MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredShort.IIFBFMAJDJM(this.hiddenValue, this.currentCryptoKey) == ObscuredShort.GJKHHOELELP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012AC1 RID: 76481 RVA: 0x0081AA18 File Offset: 0x00818C18
		public string JMCNJFKMDKI(string LJCEDKCLBDB)
		{
			return this.KDGIIHBKGLI().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012AC2 RID: 76482 RVA: 0x0081AA34 File Offset: 0x00818C34
		public short DCCPLAOEFFE()
		{
			this.JLAIFJAABML();
			return this.hiddenValue;
		}

		// Token: 0x06012AC3 RID: 76483 RVA: 0x00819DE1 File Offset: 0x00817FE1
		public static short HGCCBLGIMIL(short DCCPCBLODIG, short JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredShort.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012AC4 RID: 76484 RVA: 0x0081AA44 File Offset: 0x00818C44
		private short PGEAMCEJGGJ()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredShort.cryptoKey;
				this.hiddenValue = ObscuredShort.AAONAIGDNHM(1);
				this.fakeValue = 0;
				this.fakeValueActive = true;
				this.inited = true;
				return 0;
			}
			short num = ObscuredShort.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012AC5 RID: 76485 RVA: 0x0081AABC File Offset: 0x00818CBC
		public short AEDLKILCKME()
		{
			return this.NPJOHKJAEPP();
		}

		// Token: 0x06012AC6 RID: 76486 RVA: 0x008198D1 File Offset: 0x00817AD1
		public static ObscuredShort KEIHFJCLPPK(short DCCPCBLODIG)
		{
			return new ObscuredShort(DCCPCBLODIG);
		}

		// Token: 0x06012AC7 RID: 76487 RVA: 0x0081AAC4 File Offset: 0x00818CC4
		public int NMNNJCJHODJ()
		{
			return this.NPJOHKJAEPP().GetHashCode();
		}

		// Token: 0x06012AC8 RID: 76488 RVA: 0x008198D1 File Offset: 0x00817AD1
		public static ObscuredShort KHJPCCFDJPA(short DCCPCBLODIG)
		{
			return new ObscuredShort(DCCPCBLODIG);
		}

		// Token: 0x06012AC9 RID: 76489 RVA: 0x0081AAE0 File Offset: 0x00818CE0
		public string CCFEPJBGCEB(string LJCEDKCLBDB)
		{
			return this.PGEAMCEJGGJ().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012ACA RID: 76490 RVA: 0x0081AAFC File Offset: 0x00818CFC
		public string DDLFNJEJPBP(IFormatProvider MCGFPOIAPGJ)
		{
			return this.KDGIIHBKGLI().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012ACB RID: 76491 RVA: 0x00819D78 File Offset: 0x00817F78
		public static short AAONAIGDNHM(short DCCPCBLODIG)
		{
			return ObscuredShort.JLGFEMKEHJN(DCCPCBLODIG, 1);
		}

		// Token: 0x06012ACC RID: 76492 RVA: 0x0081AB18 File Offset: 0x00818D18
		public void FKDDOMOBFIA()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.HGCCBLGIMIL(this.NNDDLHNEONC(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012ACD RID: 76493 RVA: 0x008198D1 File Offset: 0x00817AD1
		public static ObscuredShort GOOIABGKMHK(short DCCPCBLODIG)
		{
			return new ObscuredShort(DCCPCBLODIG);
		}

		// Token: 0x06012ACE RID: 76494 RVA: 0x0081AB48 File Offset: 0x00818D48
		public static ObscuredShort MNBABHNLGDF(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.KDGIIHBKGLI() + 0;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.BJIPLCGOBII(dccpcblodig);
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

		// Token: 0x06012ACF RID: 76495 RVA: 0x0081AB90 File Offset: 0x00818D90
		public string JODMFMFAOEG(IFormatProvider MCGFPOIAPGJ)
		{
			return this.NPJOHKJAEPP().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012AD0 RID: 76496 RVA: 0x0081AABC File Offset: 0x00818CBC
		public short DCMLKFGJOMG()
		{
			return this.NPJOHKJAEPP();
		}

		// Token: 0x06012AD1 RID: 76497 RVA: 0x0081ABAC File Offset: 0x00818DAC
		public int JPOFOILPOLM()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012AD2 RID: 76498 RVA: 0x0081ABC8 File Offset: 0x00818DC8
		public string IBNCBKOPEOC(string LJCEDKCLBDB)
		{
			return this.KDGIIHBKGLI().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012AD3 RID: 76499 RVA: 0x0081ABE4 File Offset: 0x00818DE4
		public void NKAJBIADNNE()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.HGCCBLGIMIL(this.EMMHFEBNKLG(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012AD4 RID: 76500 RVA: 0x0081AC14 File Offset: 0x00818E14
		public static short CCKAOPHIKGN(ObscuredShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.NPJOHKJAEPP();
		}

		// Token: 0x06012AD5 RID: 76501 RVA: 0x008198D1 File Offset: 0x00817AD1
		public static ObscuredShort JEABDKBEOHF(short DCCPCBLODIG)
		{
			return new ObscuredShort(DCCPCBLODIG);
		}

		// Token: 0x06012AD6 RID: 76502 RVA: 0x0081AC20 File Offset: 0x00818E20
		public static ObscuredShort OAIMEKLHKCL(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 0;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.ANHANMIFKCF(dccpcblodig);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
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

		// Token: 0x06012AD7 RID: 76503 RVA: 0x0081985F File Offset: 0x00817A5F
		public static short ANHANMIFKCF(short DCCPCBLODIG)
		{
			return ObscuredShort.ACEMEMNGCBO(DCCPCBLODIG, 1);
		}

		// Token: 0x06012AD8 RID: 76504 RVA: 0x0081AC68 File Offset: 0x00818E68
		public string NIDKKALEJIM(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.KDGIIHBKGLI().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012AD9 RID: 76505 RVA: 0x00819871 File Offset: 0x00817A71
		public bool MJDHBHHGMKC(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredShort && this.MBEJDANGDKJ((ObscuredShort)MBKPMBPLIJN);
		}

		// Token: 0x06012ADB RID: 76507 RVA: 0x0081A7EA File Offset: 0x008189EA
		public static short AJMPAOCEPCA(ObscuredShort DCCPCBLODIG)
		{
			return DCCPCBLODIG.NNDDLHNEONC();
		}

		// Token: 0x06012ADC RID: 76508 RVA: 0x0081AC94 File Offset: 0x00818E94
		public static ObscuredShort JOPHOEJJJKP(ObscuredShort NFKFMIIAKFN)
		{
			short dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 0;
			NFKFMIIAKFN.hiddenValue = ObscuredShort.KOJLJMMMJGP(dccpcblodig);
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
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

		// Token: 0x06012ADD RID: 76509 RVA: 0x0081ACDB File Offset: 0x00818EDB
		public short NPKFOPJNPGH()
		{
			return this.OEFPBHKKPPO();
		}

		// Token: 0x06012ADE RID: 76510 RVA: 0x0081ACE4 File Offset: 0x00818EE4
		public string PDMPLOPPLBI()
		{
			return this.KDGIIHBKGLI().ToString();
		}

		// Token: 0x06012ADF RID: 76511 RVA: 0x0081AD00 File Offset: 0x00818F00
		public string KBJJCMOEFOC(IFormatProvider MCGFPOIAPGJ)
		{
			return this.EMMHFEBNKLG().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012AE0 RID: 76512 RVA: 0x00819B23 File Offset: 0x00817D23
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredShort.cryptoKey)
			{
				this.hiddenValue = ObscuredShort.KOJLJMMMJGP(this.MJFIFINDLAM(), ObscuredShort.cryptoKey);
				this.currentCryptoKey = ObscuredShort.cryptoKey;
			}
		}

		// Token: 0x06012AE1 RID: 76513 RVA: 0x0081AD1C File Offset: 0x00818F1C
		public void OJFAJIJBEFD()
		{
			short dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (short)UnityEngine.Random.Range(-32768, 32767);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredShort.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012AE2 RID: 76514 RVA: 0x00819DE1 File Offset: 0x00817FE1
		public static short IIFBFMAJDJM(short DCCPCBLODIG, short JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredShort.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x04002656 RID: 9814
		private static short cryptoKey = 214;

		// Token: 0x04002657 RID: 9815
		[SerializeField]
		private short currentCryptoKey;

		// Token: 0x04002658 RID: 9816
		[SerializeField]
		private short hiddenValue;

		// Token: 0x04002659 RID: 9817
		[SerializeField]
		private bool inited;

		// Token: 0x0400265A RID: 9818
		[SerializeField]
		private short fakeValue;

		// Token: 0x0400265B RID: 9819
		[SerializeField]
		private bool fakeValueActive;
	}
}
