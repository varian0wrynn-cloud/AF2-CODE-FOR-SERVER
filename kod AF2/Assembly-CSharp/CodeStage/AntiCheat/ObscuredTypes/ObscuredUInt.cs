using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000590 RID: 1424
	[Serializable]
	public struct ObscuredUInt : IEquatable<ObscuredUInt>, IFormattable
	{
		// Token: 0x06012BB2 RID: 76722 RVA: 0x0081CC3F File Offset: 0x0081AE3F
		public void PLDPJECNBNB(uint LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
			{
				this.fakeValue = this.IMNIKPGPFBA();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012BB3 RID: 76723 RVA: 0x0081CC71 File Offset: 0x0081AE71
		public static void PPJNNFDCMNO(uint JODDIMFACHN)
		{
			ObscuredUInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012BB4 RID: 76724 RVA: 0x0081CC79 File Offset: 0x0081AE79
		public bool JHHJLAIJHDG(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredUInt) || this.OGIPCMEIIIN((ObscuredUInt)MBKPMBPLIJN);
		}

		// Token: 0x06012BB5 RID: 76725 RVA: 0x0081CC91 File Offset: 0x0081AE91
		public static ObscuredUInt FHBLNJGMGBL(uint DCCPCBLODIG)
		{
			return new ObscuredUInt(DCCPCBLODIG);
		}

		// Token: 0x06012BB6 RID: 76726 RVA: 0x0081CC99 File Offset: 0x0081AE99
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredUInt && this.Equals((ObscuredUInt)MBKPMBPLIJN);
		}

		// Token: 0x06012BB7 RID: 76727 RVA: 0x0081CCB4 File Offset: 0x0081AEB4
		public string NJECBCLINBO(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.FACDCBAFCGK().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012BB8 RID: 76728 RVA: 0x0081CCD1 File Offset: 0x0081AED1
		public static ObscuredInt LFKGEAFLLCN(ObscuredUInt DCCPCBLODIG)
		{
			return ObscuredInt.GOOIABGKMHK((int)DCCPCBLODIG.MJFIFINDLAM());
		}

		// Token: 0x06012BB9 RID: 76729 RVA: 0x0081CCDF File Offset: 0x0081AEDF
		public static uint DIHLHKBDEJB(uint DCCPCBLODIG)
		{
			return ObscuredUInt.DHPGAJEHAFD(DCCPCBLODIG, 1U);
		}

		// Token: 0x06012BBA RID: 76730 RVA: 0x0081CCE8 File Offset: 0x0081AEE8
		public static uint GOOIABGKMHK(ObscuredUInt DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012BBB RID: 76731 RVA: 0x0081CCF4 File Offset: 0x0081AEF4
		public string CJMFHLIBCBM(IFormatProvider MCGFPOIAPGJ)
		{
			return this.FACDCBAFCGK().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012BBC RID: 76732 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint HGMPJKJKOEK(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012BBD RID: 76733 RVA: 0x0081CD20 File Offset: 0x0081AF20
		public uint MEELLNHEDNG()
		{
			return this.NPJOHKJAEPP();
		}

		// Token: 0x06012BBE RID: 76734 RVA: 0x0081CD28 File Offset: 0x0081AF28
		public static ObscuredUInt NOBKLDIBBCC(ObscuredUInt NFKFMIIAKFN)
		{
			uint dccpcblodig = NFKFMIIAKFN.CICALABIDIK() - 0U;
			NFKFMIIAKFN.hiddenValue = ObscuredUInt.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
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

		// Token: 0x06012BBF RID: 76735 RVA: 0x0081CD74 File Offset: 0x0081AF74
		public uint AEDNHGBLJAD()
		{
			this.IKGCJDFOEML();
			return this.hiddenValue;
		}

		// Token: 0x06012BC0 RID: 76736 RVA: 0x0081CD82 File Offset: 0x0081AF82
		public uint HBGHPHGIPNB()
		{
			return this.IMNIKPGPFBA();
		}

		// Token: 0x06012BC1 RID: 76737 RVA: 0x0081CC71 File Offset: 0x0081AE71
		public static void CENPPCOOGIL(uint JODDIMFACHN)
		{
			ObscuredUInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012BC2 RID: 76738 RVA: 0x0081CD8A File Offset: 0x0081AF8A
		public void IKGCJDFOEML()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.ONNPIMAJEKK(this.BNBGDFPCMBM(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012BC3 RID: 76739 RVA: 0x0081CDBA File Offset: 0x0081AFBA
		public static uint JJDNCFDJDMI(ObscuredUInt DCCPCBLODIG)
		{
			return DCCPCBLODIG.FACDCBAFCGK();
		}

		// Token: 0x06012BC4 RID: 76740 RVA: 0x0081CDC3 File Offset: 0x0081AFC3
		public static uint EABMCHNJEIM(uint DCCPCBLODIG)
		{
			return ObscuredUInt.DFGIGLEJNJP(DCCPCBLODIG, 1U);
		}

		// Token: 0x06012BC5 RID: 76741 RVA: 0x0081CDCC File Offset: 0x0081AFCC
		public bool DKAKLJIHPDP(ObscuredUInt MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUInt.IBCBHOJGDCC(this.hiddenValue, this.currentCryptoKey) == ObscuredUInt.DHPGAJEHAFD(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012BC6 RID: 76742 RVA: 0x0081CE1C File Offset: 0x0081B01C
		public int PAHIIBIJJKH()
		{
			return this.NPJOHKJAEPP().GetHashCode();
		}

		// Token: 0x06012BC7 RID: 76743 RVA: 0x0081CE37 File Offset: 0x0081B037
		public bool IJAIPHGBBAM(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredUInt) || this.IAONOEMGMGA((ObscuredUInt)MBKPMBPLIJN);
		}

		// Token: 0x06012BC8 RID: 76744 RVA: 0x0081CE4F File Offset: 0x0081B04F
		public uint GHBPDPPHEMP()
		{
			return this.CICALABIDIK();
		}

		// Token: 0x06012BC9 RID: 76745 RVA: 0x0081CC71 File Offset: 0x0081AE71
		public static void EICEIIHNHLL(uint JODDIMFACHN)
		{
			ObscuredUInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012BCA RID: 76746 RVA: 0x0081CE57 File Offset: 0x0081B057
		public void LJFJJHNDCAG()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.GAABDMDGPMF(this.NPJOHKJAEPP(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012BCB RID: 76747 RVA: 0x0081CE87 File Offset: 0x0081B087
		public bool IKONKPHGOAB(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredUInt && this.DKAKLJIHPDP((ObscuredUInt)MBKPMBPLIJN);
		}

		// Token: 0x06012BCC RID: 76748 RVA: 0x0081CE4F File Offset: 0x0081B04F
		public uint FHGFJBPNNDI()
		{
			return this.CICALABIDIK();
		}

		// Token: 0x06012BCD RID: 76749 RVA: 0x0081CEA0 File Offset: 0x0081B0A0
		private uint NPJOHKJAEPP()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
				this.hiddenValue = ObscuredUInt.HBJHGHOKFDK(0U);
				this.fakeValue = 0U;
				this.fakeValueActive = false;
				this.inited = false;
				return 0U;
			}
			uint num = ObscuredUInt.IJEGDPCOKOE(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012BCE RID: 76750 RVA: 0x0081CF18 File Offset: 0x0081B118
		public bool Equals(ObscuredUInt MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUInt.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredUInt.DHPGAJEHAFD(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012BCF RID: 76751 RVA: 0x0081CF66 File Offset: 0x0081B166
		public static uint JEABDKBEOHF(ObscuredUInt DCCPCBLODIG)
		{
			return DCCPCBLODIG.BNBGDFPCMBM();
		}

		// Token: 0x06012BD0 RID: 76752 RVA: 0x0081CF6F File Offset: 0x0081B16F
		public uint HJBPDMBIEBH()
		{
			return this.FACDCBAFCGK();
		}

		// Token: 0x06012BD1 RID: 76753 RVA: 0x0081CF77 File Offset: 0x0081B177
		public static uint FIONJLJINPK(ObscuredUInt DCCPCBLODIG)
		{
			return DCCPCBLODIG.NPJOHKJAEPP();
		}

		// Token: 0x06012BD2 RID: 76754 RVA: 0x0081CF80 File Offset: 0x0081B180
		public static ObscuredInt FPGMNLIHDDB(ObscuredUInt DCCPCBLODIG)
		{
			return ObscuredInt.GOOIABGKMHK((int)DCCPCBLODIG.NPJOHKJAEPP());
		}

		// Token: 0x06012BD3 RID: 76755 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint HBJHGHOKFDK(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012BD4 RID: 76756 RVA: 0x0081CF90 File Offset: 0x0081B190
		public static ObscuredUInt CJOFIEPHNLM(ObscuredUInt NFKFMIIAKFN)
		{
			uint dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 0U;
			NFKFMIIAKFN.hiddenValue = ObscuredUInt.IBGFABOCLGB(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
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

		// Token: 0x06012BD5 RID: 76757 RVA: 0x0081CFDC File Offset: 0x0081B1DC
		public int HGOLDCKCELE()
		{
			return this.FACDCBAFCGK().GetHashCode();
		}

		// Token: 0x06012BD6 RID: 76758 RVA: 0x0081CFF7 File Offset: 0x0081B1F7
		public static uint OLBHGCEEDLA(uint DCCPCBLODIG)
		{
			return ObscuredUInt.DHPGAJEHAFD(DCCPCBLODIG, 0U);
		}

		// Token: 0x06012BD7 RID: 76759 RVA: 0x0081D000 File Offset: 0x0081B200
		public static ObscuredUInt GCMNJFKFNME(ObscuredUInt NFKFMIIAKFN)
		{
			uint dccpcblodig = NFKFMIIAKFN.CICALABIDIK() - 1U;
			NFKFMIIAKFN.hiddenValue = ObscuredUInt.IBOKPHFCJPB(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012BD8 RID: 76760 RVA: 0x0081D04C File Offset: 0x0081B24C
		public static uint OGMPPMCDBBB(uint DCCPCBLODIG)
		{
			return ObscuredUInt.IJEGDPCOKOE(DCCPCBLODIG, 1U);
		}

		// Token: 0x06012BD9 RID: 76761 RVA: 0x0081CC71 File Offset: 0x0081AE71
		public static void BPDEIHFMDFO(uint JODDIMFACHN)
		{
			ObscuredUInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012BDA RID: 76762 RVA: 0x0081D055 File Offset: 0x0081B255
		public static ObscuredInt HLGHBKKHOFI(ObscuredUInt DCCPCBLODIG)
		{
			return ObscuredInt.GOOIABGKMHK((int)DCCPCBLODIG.BNBGDFPCMBM());
		}

		// Token: 0x06012BDB RID: 76763 RVA: 0x0081D064 File Offset: 0x0081B264
		public string PGJOHGFNAPC(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012BDC RID: 76764 RVA: 0x0081D084 File Offset: 0x0081B284
		public string NKOIIHFDNHP()
		{
			return this.BNBGDFPCMBM().ToString();
		}

		// Token: 0x06012BDD RID: 76765 RVA: 0x0081D09F File Offset: 0x0081B29F
		public uint AGKODBFKEDN()
		{
			this.EKJHMBNCBBH();
			return this.hiddenValue;
		}

		// Token: 0x06012BDE RID: 76766 RVA: 0x0081D0B0 File Offset: 0x0081B2B0
		public static ObscuredUInt IDIADEICPFJ(ObscuredUInt NFKFMIIAKFN)
		{
			uint dccpcblodig = NFKFMIIAKFN.NPJOHKJAEPP() - 0U;
			NFKFMIIAKFN.hiddenValue = ObscuredUInt.EABLEFPNHGL(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012BDF RID: 76767 RVA: 0x0081D0FC File Offset: 0x0081B2FC
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012BE0 RID: 76768 RVA: 0x0081D118 File Offset: 0x0081B318
		public string FGNNJFJLENH(IFormatProvider MCGFPOIAPGJ)
		{
			return this.CICALABIDIK().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012BE1 RID: 76769 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint DHPGAJEHAFD(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012BE2 RID: 76770 RVA: 0x0081D134 File Offset: 0x0081B334
		public int IIBJGHKJPEK()
		{
			return this.CICALABIDIK().GetHashCode();
		}

		// Token: 0x06012BE3 RID: 76771 RVA: 0x0081D150 File Offset: 0x0081B350
		public static ObscuredUInt DDAFEHEIMAL(ObscuredUInt NFKFMIIAKFN)
		{
			uint dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1U;
			NFKFMIIAKFN.hiddenValue = ObscuredUInt.ONNPIMAJEKK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012BE4 RID: 76772 RVA: 0x0081D19C File Offset: 0x0081B39C
		public static ObscuredUInt LILEPNCGPCJ(ObscuredUInt NFKFMIIAKFN)
		{
			uint dccpcblodig = NFKFMIIAKFN.CICALABIDIK() - 1U;
			NFKFMIIAKFN.hiddenValue = ObscuredUInt.FKEJPOKLDIA(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012BE5 RID: 76773 RVA: 0x0081D1E8 File Offset: 0x0081B3E8
		public bool BOBPIACHNAM(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredUInt) || this.EENJMDNDOHI((ObscuredUInt)MBKPMBPLIJN);
		}

		// Token: 0x06012BE6 RID: 76774 RVA: 0x0081D200 File Offset: 0x0081B400
		public string ABHFFOMFJFE(string LJCEDKCLBDB)
		{
			return this.CICALABIDIK().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012BE7 RID: 76775 RVA: 0x0081CDBA File Offset: 0x0081AFBA
		public static uint EJKAEEKCFGN(ObscuredUInt DCCPCBLODIG)
		{
			return DCCPCBLODIG.FACDCBAFCGK();
		}

		// Token: 0x06012BE8 RID: 76776 RVA: 0x0081D21C File Offset: 0x0081B41C
		public static uint GHPCDGKOJAN(uint DCCPCBLODIG)
		{
			return ObscuredUInt.PEAFACFIOHD(DCCPCBLODIG, 0U);
		}

		// Token: 0x06012BE9 RID: 76777 RVA: 0x0081D228 File Offset: 0x0081B428
		public void GCDDFNKCPCN()
		{
			uint dccpcblodig = this.MJFIFINDLAM();
			this.currentCryptoKey = (uint)UnityEngine.Random.Range(1, 126);
			this.hiddenValue = ObscuredUInt.ONNPIMAJEKK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012BEA RID: 76778 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint ONNPIMAJEKK(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012BEB RID: 76779 RVA: 0x0081D25F File Offset: 0x0081B45F
		public uint BILJGBOFJMK()
		{
			this.DOBNIBDLPDC();
			return this.hiddenValue;
		}

		// Token: 0x06012BEC RID: 76780 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint IBGFABOCLGB(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012BED RID: 76781 RVA: 0x0081D26D File Offset: 0x0081B46D
		public bool AJFDLCOJHGO(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredUInt && this.ICANHIGGPAL((ObscuredUInt)MBKPMBPLIJN);
		}

		// Token: 0x06012BEE RID: 76782 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint DFGIGLEJNJP(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012BEF RID: 76783 RVA: 0x0081D288 File Offset: 0x0081B488
		public void COGHGNNAPKP()
		{
			uint dccpcblodig = this.IMNIKPGPFBA();
			this.currentCryptoKey = (uint)UnityEngine.Random.Range(0, 154);
			this.hiddenValue = ObscuredUInt.PEAFACFIOHD(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012BF0 RID: 76784 RVA: 0x0081D2C0 File Offset: 0x0081B4C0
		private uint FACDCBAFCGK()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
				this.hiddenValue = ObscuredUInt.HBJHGHOKFDK(0U);
				this.fakeValue = 0U;
				this.fakeValueActive = false;
				this.inited = false;
				return 0U;
			}
			uint num = ObscuredUInt.GDPLIHIBJHE(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.CKFIDHHGLGO() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012BF1 RID: 76785 RVA: 0x0081D338 File Offset: 0x0081B538
		public static ObscuredInt ODPDKAJCNBC(ObscuredUInt DCCPCBLODIG)
		{
			return ObscuredInt.KHJPCCFDJPA((int)DCCPCBLODIG.IMNIKPGPFBA());
		}

		// Token: 0x06012BF2 RID: 76786 RVA: 0x0081CC71 File Offset: 0x0081AE71
		public static void BCKDMOOMEKB(uint JODDIMFACHN)
		{
			ObscuredUInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012BF3 RID: 76787 RVA: 0x0081CC91 File Offset: 0x0081AE91
		public static ObscuredUInt GOOIABGKMHK(uint DCCPCBLODIG)
		{
			return new ObscuredUInt(DCCPCBLODIG);
		}

		// Token: 0x06012BF4 RID: 76788 RVA: 0x0081D348 File Offset: 0x0081B548
		public void KMFFHNPIPAG()
		{
			uint dccpcblodig = this.NPJOHKJAEPP();
			this.currentCryptoKey = (uint)UnityEngine.Random.Range(0, -83);
			this.hiddenValue = ObscuredUInt.PEAFACFIOHD(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012BF5 RID: 76789 RVA: 0x0081D37F File Offset: 0x0081B57F
		public static ObscuredInt JFBDKEFGFDE(ObscuredUInt DCCPCBLODIG)
		{
			return ObscuredInt.IGDNGFGPOFC((int)DCCPCBLODIG.BNBGDFPCMBM());
		}

		// Token: 0x06012BF6 RID: 76790 RVA: 0x0081D390 File Offset: 0x0081B590
		public string OKJEDFNFDML(string LJCEDKCLBDB)
		{
			return this.IMNIKPGPFBA().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012BF7 RID: 76791 RVA: 0x0081D3AC File Offset: 0x0081B5AC
		public void MOPKKOIFKMI(uint LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
			{
				this.fakeValue = this.BNBGDFPCMBM();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012BF8 RID: 76792 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint ADPGKCKCGKB(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012BF9 RID: 76793 RVA: 0x0081D3DE File Offset: 0x0081B5DE
		public static uint HLNBDFJDDCP(uint DCCPCBLODIG)
		{
			return ObscuredUInt.ADPGKCKCGKB(DCCPCBLODIG, 1U);
		}

		// Token: 0x06012BFA RID: 76794 RVA: 0x0081CE4F File Offset: 0x0081B04F
		public uint BELCMLOAIFA()
		{
			return this.CICALABIDIK();
		}

		// Token: 0x06012BFB RID: 76795 RVA: 0x0081D3E8 File Offset: 0x0081B5E8
		public static ObscuredUInt ACDPHHDEDKE(ObscuredUInt NFKFMIIAKFN)
		{
			uint dccpcblodig = NFKFMIIAKFN.NPJOHKJAEPP() + 1U;
			NFKFMIIAKFN.hiddenValue = ObscuredUInt.IBGFABOCLGB(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012BFC RID: 76796 RVA: 0x0081D434 File Offset: 0x0081B634
		public void DOBNIBDLPDC()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.PEAFACFIOHD(this.BNBGDFPCMBM(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012BFD RID: 76797 RVA: 0x0081D464 File Offset: 0x0081B664
		public static ObscuredUInt FKNBKFFMJBJ(ObscuredUInt NFKFMIIAKFN)
		{
			uint dccpcblodig = NFKFMIIAKFN.NPJOHKJAEPP() - 1U;
			NFKFMIIAKFN.hiddenValue = ObscuredUInt.EABLEFPNHGL(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012BFE RID: 76798 RVA: 0x0081D4B0 File Offset: 0x0081B6B0
		private uint MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
				this.hiddenValue = ObscuredUInt.HBJHGHOKFDK(0U);
				this.fakeValue = 0U;
				this.fakeValueActive = false;
				this.inited = true;
				return 0U;
			}
			uint num = ObscuredUInt.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012BFF RID: 76799 RVA: 0x0081D528 File Offset: 0x0081B728
		public uint DJKLDBBMIKG()
		{
			this.ADOAONEOPKO();
			return this.hiddenValue;
		}

		// Token: 0x06012C00 RID: 76800 RVA: 0x0081D538 File Offset: 0x0081B738
		private ObscuredUInt(uint DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredUInt.cryptoKey;
			this.hiddenValue = ObscuredUInt.HBJHGHOKFDK(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : 0U);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x06012C01 RID: 76801 RVA: 0x0081D57D File Offset: 0x0081B77D
		public uint LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012C02 RID: 76802 RVA: 0x0081CC71 File Offset: 0x0081AE71
		public static void PIOJAFHACHH(uint JODDIMFACHN)
		{
			ObscuredUInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012C03 RID: 76803 RVA: 0x0081CC91 File Offset: 0x0081AE91
		public static ObscuredUInt AMAMLPIKGLA(uint DCCPCBLODIG)
		{
			return new ObscuredUInt(DCCPCBLODIG);
		}

		// Token: 0x06012C04 RID: 76804 RVA: 0x0081D58B File Offset: 0x0081B78B
		public static uint PGOAHMBLNAF(uint DCCPCBLODIG)
		{
			return ObscuredUInt.ONNPIMAJEKK(DCCPCBLODIG, 0U);
		}

		// Token: 0x06012C05 RID: 76805 RVA: 0x0081D594 File Offset: 0x0081B794
		public static uint NDHGJJICEMC(uint DCCPCBLODIG)
		{
			return ObscuredUInt.IBCBHOJGDCC(DCCPCBLODIG, 0U);
		}

		// Token: 0x06012C06 RID: 76806 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint IBCBHOJGDCC(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012C07 RID: 76807 RVA: 0x0081CC91 File Offset: 0x0081AE91
		public static ObscuredUInt EPDCFMMLMIF(uint DCCPCBLODIG)
		{
			return new ObscuredUInt(DCCPCBLODIG);
		}

		// Token: 0x06012C08 RID: 76808 RVA: 0x0081CFF7 File Offset: 0x0081B1F7
		public static uint DHPGAJEHAFD(uint DCCPCBLODIG)
		{
			return ObscuredUInt.DHPGAJEHAFD(DCCPCBLODIG, 0U);
		}

		// Token: 0x06012C09 RID: 76809 RVA: 0x0081D59D File Offset: 0x0081B79D
		public static uint HBJHGHOKFDK(uint DCCPCBLODIG)
		{
			return ObscuredUInt.HBJHGHOKFDK(DCCPCBLODIG, 0U);
		}

		// Token: 0x06012C0A RID: 76810 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint GDPLIHIBJHE(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012C0B RID: 76811 RVA: 0x0081D5A8 File Offset: 0x0081B7A8
		public static ObscuredUInt DPCDNMHLOJF(ObscuredUInt NFKFMIIAKFN)
		{
			uint dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1U;
			NFKFMIIAKFN.hiddenValue = ObscuredUInt.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012C0C RID: 76812 RVA: 0x0081D5F4 File Offset: 0x0081B7F4
		public int JJLGHJBNLOP()
		{
			return this.NPJOHKJAEPP().GetHashCode();
		}

		// Token: 0x06012C0D RID: 76813 RVA: 0x0081D60F File Offset: 0x0081B80F
		public static uint LFAMGJLFIAN(uint DCCPCBLODIG)
		{
			return ObscuredUInt.DFGIGLEJNJP(DCCPCBLODIG, 0U);
		}

		// Token: 0x06012C0E RID: 76814 RVA: 0x0081D618 File Offset: 0x0081B818
		public void EKJHMBNCBBH()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.FKEJPOKLDIA(this.IMNIKPGPFBA(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012C0F RID: 76815 RVA: 0x0081D648 File Offset: 0x0081B848
		private uint CICALABIDIK()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
				this.hiddenValue = ObscuredUInt.LFAMGJLFIAN(1U);
				this.fakeValue = 0U;
				this.fakeValueActive = false;
				this.inited = true;
				return 0U;
			}
			uint num = ObscuredUInt.ADPGKCKCGKB(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012C10 RID: 76816 RVA: 0x0081D6C0 File Offset: 0x0081B8C0
		public void LABEACCDKMD(uint LDKMOLEEDIL)
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

		// Token: 0x06012C11 RID: 76817 RVA: 0x0081D6F2 File Offset: 0x0081B8F2
		public void MFHGNKOOODH()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.EABLEFPNHGL(this.BNBGDFPCMBM(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012C12 RID: 76818 RVA: 0x0081D722 File Offset: 0x0081B922
		public void KBAAOBGMJPE()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.DGGENHECDJP(this.IMNIKPGPFBA(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012C13 RID: 76819 RVA: 0x0081D26D File Offset: 0x0081B46D
		public bool MJDHBHHGMKC(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredUInt && this.ICANHIGGPAL((ObscuredUInt)MBKPMBPLIJN);
		}

		// Token: 0x06012C14 RID: 76820 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint EABLEFPNHGL(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012C15 RID: 76821 RVA: 0x0081D754 File Offset: 0x0081B954
		public static ObscuredUInt LMCPOHBPEDC(ObscuredUInt NFKFMIIAKFN)
		{
			uint dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1U;
			NFKFMIIAKFN.hiddenValue = ObscuredUInt.ONNPIMAJEKK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012C16 RID: 76822 RVA: 0x0081D7A0 File Offset: 0x0081B9A0
		public static ObscuredInt KPBHGMHPPKN(ObscuredUInt DCCPCBLODIG)
		{
			return ObscuredInt.JNKANIEBCMD((int)DCCPCBLODIG.NPJOHKJAEPP());
		}

		// Token: 0x06012C17 RID: 76823 RVA: 0x0081D7B0 File Offset: 0x0081B9B0
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012C18 RID: 76824 RVA: 0x0081D7CB File Offset: 0x0081B9CB
		public bool JPKDEOKIAKE(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredUInt && this.IAONOEMGMGA((ObscuredUInt)MBKPMBPLIJN);
		}

		// Token: 0x06012C19 RID: 76825 RVA: 0x0081D7E3 File Offset: 0x0081B9E3
		public void IIKNGIMFDFL(uint LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				this.fakeValue = this.NPJOHKJAEPP();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012C1A RID: 76826 RVA: 0x0081D818 File Offset: 0x0081BA18
		public string IAJBLDEDMOP(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.FACDCBAFCGK().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012C1B RID: 76827 RVA: 0x0081CC71 File Offset: 0x0081AE71
		public static void NGAIBOIKGDK(uint JODDIMFACHN)
		{
			ObscuredUInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012C1C RID: 76828 RVA: 0x0081D835 File Offset: 0x0081BA35
		public static uint PCCEJJLFKIH(uint DCCPCBLODIG)
		{
			return ObscuredUInt.GDPLIHIBJHE(DCCPCBLODIG, 0U);
		}

		// Token: 0x06012C1D RID: 76829 RVA: 0x0081D83E File Offset: 0x0081BA3E
		public uint BDDIACNJIHH()
		{
			return this.BNBGDFPCMBM();
		}

		// Token: 0x06012C1E RID: 76830 RVA: 0x0081CC71 File Offset: 0x0081AE71
		public static void HMFHIAPIFCG(uint JODDIMFACHN)
		{
			ObscuredUInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012C1F RID: 76831 RVA: 0x0081D848 File Offset: 0x0081BA48
		public string IBNCBKOPEOC()
		{
			return this.NPJOHKJAEPP().ToString();
		}

		// Token: 0x06012C20 RID: 76832 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint BIHICOOKCOA(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012C21 RID: 76833 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint DGGENHECDJP(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012C22 RID: 76834 RVA: 0x0081D864 File Offset: 0x0081BA64
		public int JHDHJANBGDJ()
		{
			return this.FACDCBAFCGK().GetHashCode();
		}

		// Token: 0x06012C23 RID: 76835 RVA: 0x0081D880 File Offset: 0x0081BA80
		private uint IMNIKPGPFBA()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
				this.hiddenValue = ObscuredUInt.HGLLPLLHIHL(0U);
				this.fakeValue = 1U;
				this.fakeValueActive = true;
				this.inited = false;
				return 1U;
			}
			uint num = ObscuredUInt.ADPGKCKCGKB(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012C24 RID: 76836 RVA: 0x0081D8F8 File Offset: 0x0081BAF8
		public string ALAAOKOIJNG()
		{
			return this.CICALABIDIK().ToString();
		}

		// Token: 0x06012C25 RID: 76837 RVA: 0x0081D914 File Offset: 0x0081BB14
		public string GILBAOBCMDC(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.CICALABIDIK().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012C26 RID: 76838 RVA: 0x0081D931 File Offset: 0x0081BB31
		public void OMDHHHBGIEB()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.PEAFACFIOHD(this.FACDCBAFCGK(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012C28 RID: 76840 RVA: 0x0081D970 File Offset: 0x0081BB70
		public bool EENJMDNDOHI(ObscuredUInt MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUInt.IJEGDPCOKOE(this.hiddenValue, this.currentCryptoKey) == ObscuredUInt.BIHICOOKCOA(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012C29 RID: 76841 RVA: 0x0081D9C0 File Offset: 0x0081BBC0
		public string ADOAJOFIPAM(IFormatProvider MCGFPOIAPGJ)
		{
			return this.IMNIKPGPFBA().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012C2A RID: 76842 RVA: 0x0081D9DC File Offset: 0x0081BBDC
		public uint FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012C2B RID: 76843 RVA: 0x0081D9E4 File Offset: 0x0081BBE4
		public void IEIODLADOFO()
		{
			uint dccpcblodig = this.FACDCBAFCGK();
			this.currentCryptoKey = (uint)UnityEngine.Random.Range(1, -10);
			this.hiddenValue = ObscuredUInt.DFGIGLEJNJP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012C2C RID: 76844 RVA: 0x0081D57D File Offset: 0x0081B77D
		public uint MBJFPLDNKLG()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012C2D RID: 76845 RVA: 0x0081DA1C File Offset: 0x0081BC1C
		public string KCBJCGOINMK()
		{
			return this.IMNIKPGPFBA().ToString();
		}

		// Token: 0x06012C2E RID: 76846 RVA: 0x0081DA37 File Offset: 0x0081BC37
		public void JCEBHGDJHIJ()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.IBGFABOCLGB(this.FACDCBAFCGK(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012C2F RID: 76847 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint FKEJPOKLDIA(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012C30 RID: 76848 RVA: 0x0081DA67 File Offset: 0x0081BC67
		public void NLNPKOHNLHH(uint LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				this.fakeValue = this.IMNIKPGPFBA();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012C31 RID: 76849 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint PEAFACFIOHD(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012C32 RID: 76850 RVA: 0x0081DA9C File Offset: 0x0081BC9C
		public string ToString(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012C33 RID: 76851 RVA: 0x0081DAB9 File Offset: 0x0081BCB9
		public static uint HGLLPLLHIHL(uint DCCPCBLODIG)
		{
			return ObscuredUInt.IBGFABOCLGB(DCCPCBLODIG, 0U);
		}

		// Token: 0x06012C34 RID: 76852 RVA: 0x0081DAC4 File Offset: 0x0081BCC4
		public string OABGAIPBCLL(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.NPJOHKJAEPP().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012C35 RID: 76853 RVA: 0x0081CFF7 File Offset: 0x0081B1F7
		public static uint GEHJOMAMEOF(uint DCCPCBLODIG)
		{
			return ObscuredUInt.DHPGAJEHAFD(DCCPCBLODIG, 0U);
		}

		// Token: 0x06012C36 RID: 76854 RVA: 0x0081D25F File Offset: 0x0081B45F
		public uint AENCEDLJHJJ()
		{
			this.DOBNIBDLPDC();
			return this.hiddenValue;
		}

		// Token: 0x06012C37 RID: 76855 RVA: 0x0081DAE1 File Offset: 0x0081BCE1
		public void DPGCEKJNDNK()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.PEAFACFIOHD(this.NPJOHKJAEPP(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012C38 RID: 76856 RVA: 0x0081DB14 File Offset: 0x0081BD14
		private uint BNBGDFPCMBM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
				this.hiddenValue = ObscuredUInt.HGLLPLLHIHL(0U);
				this.fakeValue = 0U;
				this.fakeValueActive = true;
				this.inited = true;
				return 0U;
			}
			uint num = ObscuredUInt.ADPGKCKCGKB(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012C39 RID: 76857 RVA: 0x0081DB8C File Offset: 0x0081BD8C
		public bool ICANHIGGPAL(ObscuredUInt MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUInt.IJEGDPCOKOE(this.hiddenValue, this.currentCryptoKey) == ObscuredUInt.IBCBHOJGDCC(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012C3A RID: 76858 RVA: 0x0081CC71 File Offset: 0x0081AE71
		public static void BBOGAEMNJJN(uint JODDIMFACHN)
		{
			ObscuredUInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012C3B RID: 76859 RVA: 0x0081DBDC File Offset: 0x0081BDDC
		public string HLHHDFFDHGL(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.CICALABIDIK().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012C3C RID: 76860 RVA: 0x0081DBF9 File Offset: 0x0081BDF9
		public void NEINBIKBPKH(uint LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.BNBGDFPCMBM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012C3D RID: 76861 RVA: 0x0081CC91 File Offset: 0x0081AE91
		public static ObscuredUInt KCNLJJFMBHG(uint DCCPCBLODIG)
		{
			return new ObscuredUInt(DCCPCBLODIG);
		}

		// Token: 0x06012C3E RID: 76862 RVA: 0x0081DC2C File Offset: 0x0081BE2C
		public string DGOBKBBGGKN(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012C3F RID: 76863 RVA: 0x0081DC48 File Offset: 0x0081BE48
		public void OJFAJIJBEFD()
		{
			uint dccpcblodig = this.MJFIFINDLAM();
			this.currentCryptoKey = (uint)UnityEngine.Random.Range(1, int.MaxValue);
			this.hiddenValue = ObscuredUInt.HBJHGHOKFDK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012C40 RID: 76864 RVA: 0x0081DC80 File Offset: 0x0081BE80
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012C41 RID: 76865 RVA: 0x0081D055 File Offset: 0x0081B255
		public static ObscuredInt CBJIOJPIHAJ(ObscuredUInt DCCPCBLODIG)
		{
			return ObscuredInt.GOOIABGKMHK((int)DCCPCBLODIG.BNBGDFPCMBM());
		}

		// Token: 0x06012C42 RID: 76866 RVA: 0x0081DC9B File Offset: 0x0081BE9B
		public void ADOAONEOPKO()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.DGGENHECDJP(this.MJFIFINDLAM(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012C43 RID: 76867 RVA: 0x0081DCCC File Offset: 0x0081BECC
		public bool OGIPCMEIIIN(ObscuredUInt MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUInt.HGMPJKJKOEK(this.hiddenValue, this.currentCryptoKey) == ObscuredUInt.IBCBHOJGDCC(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012C44 RID: 76868 RVA: 0x0081DD1C File Offset: 0x0081BF1C
		public int EICPEJEKCDC()
		{
			return this.IMNIKPGPFBA().GetHashCode();
		}

		// Token: 0x06012C45 RID: 76869 RVA: 0x0081CE4F File Offset: 0x0081B04F
		public uint KBMHFJGGIJI()
		{
			return this.CICALABIDIK();
		}

		// Token: 0x06012C46 RID: 76870 RVA: 0x0081DD38 File Offset: 0x0081BF38
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012C47 RID: 76871 RVA: 0x0081CCE8 File Offset: 0x0081AEE8
		public static uint EJGOOFALNFF(ObscuredUInt DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012C48 RID: 76872 RVA: 0x0081DD54 File Offset: 0x0081BF54
		public string CBACNFCIOAJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012C49 RID: 76873 RVA: 0x0081DD70 File Offset: 0x0081BF70
		public string CGGKJFBHOMJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012C4A RID: 76874 RVA: 0x0081DD8C File Offset: 0x0081BF8C
		public bool IAONOEMGMGA(ObscuredUInt MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredUInt.HGMPJKJKOEK(this.hiddenValue, this.currentCryptoKey) == ObscuredUInt.IBCBHOJGDCC(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012C4B RID: 76875 RVA: 0x0081DDDC File Offset: 0x0081BFDC
		public string FPPLGDMIGKI(IFormatProvider MCGFPOIAPGJ)
		{
			return this.BNBGDFPCMBM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012C4C RID: 76876 RVA: 0x0081DDF8 File Offset: 0x0081BFF8
		public void KJBOPMELKGK()
		{
			uint dccpcblodig = this.IMNIKPGPFBA();
			this.currentCryptoKey = (uint)UnityEngine.Random.Range(0, -107);
			this.hiddenValue = ObscuredUInt.IBOKPHFCJPB(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012C4D RID: 76877 RVA: 0x0081DE30 File Offset: 0x0081C030
		public int MEACMCLEHNO()
		{
			return this.IMNIKPGPFBA().GetHashCode();
		}

		// Token: 0x06012C4E RID: 76878 RVA: 0x0081DE4B File Offset: 0x0081C04B
		public void FFCPGOMOLPJ(uint LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
			{
				this.fakeValue = this.BNBGDFPCMBM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012C4F RID: 76879 RVA: 0x0081D7CB File Offset: 0x0081B9CB
		public bool NMMLCKHECMA(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredUInt && this.IAONOEMGMGA((ObscuredUInt)MBKPMBPLIJN);
		}

		// Token: 0x06012C50 RID: 76880 RVA: 0x0081DE80 File Offset: 0x0081C080
		public int FPPMLKBCAIA()
		{
			return this.IMNIKPGPFBA().GetHashCode();
		}

		// Token: 0x06012C51 RID: 76881 RVA: 0x0081DE9C File Offset: 0x0081C09C
		public string BHLHEJCILKF(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.CICALABIDIK().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012C52 RID: 76882 RVA: 0x0081DEB9 File Offset: 0x0081C0B9
		public void NLKIBJFFAOP()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.HBJHGHOKFDK(this.MJFIFINDLAM(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012C53 RID: 76883 RVA: 0x0081CC71 File Offset: 0x0081AE71
		public static void AIBANBHAFML(uint JODDIMFACHN)
		{
			ObscuredUInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012C54 RID: 76884 RVA: 0x0081DEEC File Offset: 0x0081C0EC
		public void PKNHAAGHLLA()
		{
			uint dccpcblodig = this.MJFIFINDLAM();
			this.currentCryptoKey = (uint)UnityEngine.Random.Range(1, 92);
			this.hiddenValue = ObscuredUInt.HBJHGHOKFDK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012C55 RID: 76885 RVA: 0x0081DF23 File Offset: 0x0081C123
		public static ObscuredInt ELJKBPPKAJJ(ObscuredUInt DCCPCBLODIG)
		{
			return ObscuredInt.IGDNGFGPOFC((int)DCCPCBLODIG.CICALABIDIK());
		}

		// Token: 0x06012C56 RID: 76886 RVA: 0x0081DEB9 File Offset: 0x0081C0B9
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredUInt.cryptoKey)
			{
				this.hiddenValue = ObscuredUInt.HBJHGHOKFDK(this.MJFIFINDLAM(), ObscuredUInt.cryptoKey);
				this.currentCryptoKey = ObscuredUInt.cryptoKey;
			}
		}

		// Token: 0x06012C57 RID: 76887 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint GAABDMDGPMF(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012C58 RID: 76888 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint IBOKPHFCJPB(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012C59 RID: 76889 RVA: 0x0081CD10 File Offset: 0x0081AF10
		public static uint IJEGDPCOKOE(uint DCCPCBLODIG, uint JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0U)
			{
				return DCCPCBLODIG ^ ObscuredUInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012C5A RID: 76890 RVA: 0x0081DF34 File Offset: 0x0081C134
		public static ObscuredUInt HIBLFIAPCJE(ObscuredUInt NFKFMIIAKFN)
		{
			uint dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1U;
			NFKFMIIAKFN.hiddenValue = ObscuredUInt.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012C5B RID: 76891 RVA: 0x0081DF80 File Offset: 0x0081C180
		public string JHGPBNCOHHH()
		{
			return this.CICALABIDIK().ToString();
		}

		// Token: 0x06012C5C RID: 76892 RVA: 0x0081DF9C File Offset: 0x0081C19C
		public string NAAOOABFHKB()
		{
			return this.NPJOHKJAEPP().ToString();
		}

		// Token: 0x04002668 RID: 9832
		private static uint cryptoKey = 240513U;

		// Token: 0x04002669 RID: 9833
		[SerializeField]
		private uint currentCryptoKey;

		// Token: 0x0400266A RID: 9834
		[SerializeField]
		private uint hiddenValue;

		// Token: 0x0400266B RID: 9835
		[SerializeField]
		private bool inited;

		// Token: 0x0400266C RID: 9836
		[SerializeField]
		private uint fakeValue;

		// Token: 0x0400266D RID: 9837
		[SerializeField]
		private bool fakeValueActive;
	}
}
