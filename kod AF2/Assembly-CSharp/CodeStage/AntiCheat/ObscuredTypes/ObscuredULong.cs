using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200058F RID: 1423
	[Serializable]
	public struct ObscuredULong : IEquatable<ObscuredULong>, IFormattable
	{
		// Token: 0x06012B35 RID: 76597 RVA: 0x0081BA6C File Offset: 0x00819C6C
		public string NDCLLIMPLEE(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.LHIFOBAECHJ().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012B36 RID: 76598 RVA: 0x0081BA89 File Offset: 0x00819C89
		public ulong LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012B37 RID: 76599 RVA: 0x0081BA97 File Offset: 0x00819C97
		public static void KEGPDCOKIJC(ulong JODDIMFACHN)
		{
			ObscuredULong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012B38 RID: 76600 RVA: 0x0081BA9F File Offset: 0x00819C9F
		public void FJKNFFMJDMJ(ulong LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue = this.CHIBGKNJLDB();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012B39 RID: 76601 RVA: 0x0081BAD1 File Offset: 0x00819CD1
		public static ulong ALHMMAGENAF(ulong DCCPCBLODIG)
		{
			return ObscuredULong.MPHCOFBOKOO(DCCPCBLODIG, 0UL);
		}

		// Token: 0x06012B3A RID: 76602 RVA: 0x0081BADB File Offset: 0x00819CDB
		public static ulong MPHCOFBOKOO(ulong DCCPCBLODIG, ulong JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0UL)
			{
				return DCCPCBLODIG ^ ObscuredULong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012B3B RID: 76603 RVA: 0x0081BAEC File Offset: 0x00819CEC
		public static ObscuredULong OBMHNNEAODP(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.PDFJIFJIOJN() + 1UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.EKKPPKGFFCH(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012B3D RID: 76605 RVA: 0x0081BB48 File Offset: 0x00819D48
		public string FEIJPDKNKKG(IFormatProvider MCGFPOIAPGJ)
		{
			return this.LHIFOBAECHJ().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012B3E RID: 76606 RVA: 0x0081BB64 File Offset: 0x00819D64
		public static ulong GOOIABGKMHK(ObscuredULong DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012B3F RID: 76607 RVA: 0x0081BB70 File Offset: 0x00819D70
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012B40 RID: 76608 RVA: 0x0081BB8C File Offset: 0x00819D8C
		public int NMNJMEMAHOF()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012B41 RID: 76609 RVA: 0x0081BBA7 File Offset: 0x00819DA7
		public ulong AEPDPCMKKGE()
		{
			return this.LDHDCODNNJO();
		}

		// Token: 0x06012B42 RID: 76610 RVA: 0x0081BBB0 File Offset: 0x00819DB0
		public static ObscuredULong GOFDLDGBNEG(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.LDHDCODNNJO() - 0UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
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

		// Token: 0x06012B43 RID: 76611 RVA: 0x0081BC00 File Offset: 0x00819E00
		public string MIHCFECAIAD()
		{
			return this.LHIFOBAECHJ().ToString();
		}

		// Token: 0x06012B44 RID: 76612 RVA: 0x0081BC1C File Offset: 0x00819E1C
		public int IFFMNFIJMPM()
		{
			return this.CHIBGKNJLDB().GetHashCode();
		}

		// Token: 0x06012B45 RID: 76613 RVA: 0x0081BC38 File Offset: 0x00819E38
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012B46 RID: 76614 RVA: 0x0081BC54 File Offset: 0x00819E54
		public static ObscuredULong LOMHAKCJMFD(ulong DCCPCBLODIG)
		{
			return new ObscuredULong(DCCPCBLODIG);
		}

		// Token: 0x06012B47 RID: 76615 RVA: 0x0081BC5C File Offset: 0x00819E5C
		public static ulong LPDGJCGPEBD(ObscuredULong DCCPCBLODIG)
		{
			return DCCPCBLODIG.LDHDCODNNJO();
		}

		// Token: 0x06012B48 RID: 76616 RVA: 0x0081BC65 File Offset: 0x00819E65
		public static ulong HBJHGHOKFDK(ulong DCCPCBLODIG)
		{
			return ObscuredULong.HBJHGHOKFDK(DCCPCBLODIG, 0UL);
		}

		// Token: 0x06012B49 RID: 76617 RVA: 0x0081BC70 File Offset: 0x00819E70
		public static ObscuredULong KCHCJENJDKA(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.PDFJIFJIOJN() - 0UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.EKKPPKGFFCH(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
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

		// Token: 0x06012B4A RID: 76618 RVA: 0x0081BCC0 File Offset: 0x00819EC0
		public string OEAEGBAEEPP()
		{
			return this.HHMPNEIPKHE().ToString();
		}

		// Token: 0x06012B4B RID: 76619 RVA: 0x0081BCDC File Offset: 0x00819EDC
		public string BACHFNMDOLO(string LJCEDKCLBDB)
		{
			return this.PDFJIFJIOJN().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012B4C RID: 76620 RVA: 0x0081BCF8 File Offset: 0x00819EF8
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012B4D RID: 76621 RVA: 0x0081BD14 File Offset: 0x00819F14
		public bool JMJAHECALNC(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredULong) || this.ECJDCKCFAMP((ObscuredULong)MBKPMBPLIJN);
		}

		// Token: 0x06012B4E RID: 76622 RVA: 0x0081BD2C File Offset: 0x00819F2C
		public static ObscuredULong KKLMKKJAEEK(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.PDFJIFJIOJN() - 0UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.EKKPPKGFFCH(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
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

		// Token: 0x06012B4F RID: 76623 RVA: 0x0081BD79 File Offset: 0x00819F79
		public static ulong HKGNPLLLIAF(ulong DCCPCBLODIG)
		{
			return ObscuredULong.IBFEFGCIOHO(DCCPCBLODIG, 1UL);
		}

		// Token: 0x06012B50 RID: 76624 RVA: 0x0081BD84 File Offset: 0x00819F84
		public static ObscuredULong KCAOJMGEHFL(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.LHIFOBAECHJ() - 0UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.EKKPPKGFFCH(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012B51 RID: 76625 RVA: 0x0081BC54 File Offset: 0x00819E54
		public static ObscuredULong BDLBFKPDOIH(ulong DCCPCBLODIG)
		{
			return new ObscuredULong(DCCPCBLODIG);
		}

		// Token: 0x06012B52 RID: 76626 RVA: 0x0081BDD1 File Offset: 0x00819FD1
		public void GGCEAECEGJA(ulong LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.HHMPNEIPKHE();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012B53 RID: 76627 RVA: 0x0081BE04 File Offset: 0x0081A004
		public static ObscuredULong HIFKIMHICPC(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.HHMPNEIPKHE() + 0UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.MPHCOFBOKOO(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012B54 RID: 76628 RVA: 0x0081BE54 File Offset: 0x0081A054
		public string NILBMGFGPPB(string LJCEDKCLBDB)
		{
			return this.LDHDCODNNJO().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012B55 RID: 76629 RVA: 0x0081BE70 File Offset: 0x0081A070
		public static ulong KDGJHAMOABL(ulong DCCPCBLODIG)
		{
			return ObscuredULong.EKKPPKGFFCH(DCCPCBLODIG, 0UL);
		}

		// Token: 0x06012B56 RID: 76630 RVA: 0x0081BE7A File Offset: 0x0081A07A
		public void DENNCLANHJI(ulong LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue = this.LHIFOBAECHJ();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012B57 RID: 76631 RVA: 0x0081BADB File Offset: 0x00819CDB
		public static ulong KMAKGFIJCNF(ulong DCCPCBLODIG, ulong JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0UL)
			{
				return DCCPCBLODIG ^ ObscuredULong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012B58 RID: 76632 RVA: 0x0081BEAC File Offset: 0x0081A0AC
		public bool KAAJNHMODLF(ObscuredULong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredULong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredULong.DHPGAJEHAFD(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012B59 RID: 76633 RVA: 0x0081BEFC File Offset: 0x0081A0FC
		public string NEIAHJGEINP(string LJCEDKCLBDB)
		{
			return this.HHMPNEIPKHE().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012B5A RID: 76634 RVA: 0x0081BF18 File Offset: 0x0081A118
		public string NKFOGFFPKFN(string LJCEDKCLBDB)
		{
			return this.HHMPNEIPKHE().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012B5B RID: 76635 RVA: 0x0081BF34 File Offset: 0x0081A134
		public string KCBJCGOINMK(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.LDHDCODNNJO().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012B5C RID: 76636 RVA: 0x0081BF54 File Offset: 0x0081A154
		public string OBJBIEJJJFN(IFormatProvider MCGFPOIAPGJ)
		{
			return this.PDFJIFJIOJN().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012B5D RID: 76637 RVA: 0x0081BADB File Offset: 0x00819CDB
		public static ulong EKKPPKGFFCH(ulong DCCPCBLODIG, ulong JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0UL)
			{
				return DCCPCBLODIG ^ ObscuredULong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012B5E RID: 76638 RVA: 0x0081BF70 File Offset: 0x0081A170
		public void ACDNFFBFKOB()
		{
			ulong dccpcblodig = this.LHIFOBAECHJ();
			this.currentCryptoKey = (ulong)((long)UnityEngine.Random.Range(0, -91));
			this.hiddenValue = ObscuredULong.MPHCOFBOKOO(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012B5F RID: 76639 RVA: 0x0081BFA8 File Offset: 0x0081A1A8
		public bool Equals(ObscuredULong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredULong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredULong.DHPGAJEHAFD(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012B60 RID: 76640 RVA: 0x0081BADB File Offset: 0x00819CDB
		public static ulong DHPGAJEHAFD(ulong DCCPCBLODIG, ulong JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0UL)
			{
				return DCCPCBLODIG ^ ObscuredULong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012B61 RID: 76641 RVA: 0x0081BFF8 File Offset: 0x0081A1F8
		private ulong PDFJIFJIOJN()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredULong.cryptoKey;
				this.hiddenValue = ObscuredULong.KDGJHAMOABL(0UL);
				this.fakeValue = 1UL;
				this.fakeValueActive = false;
				this.inited = false;
				return 0UL;
			}
			ulong num = ObscuredULong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012B62 RID: 76642 RVA: 0x0081BD79 File Offset: 0x00819F79
		public static ulong IMFMIKEKOPL(ulong DCCPCBLODIG)
		{
			return ObscuredULong.IBFEFGCIOHO(DCCPCBLODIG, 1UL);
		}

		// Token: 0x06012B63 RID: 76643 RVA: 0x0081BC54 File Offset: 0x00819E54
		public static ObscuredULong GOOIABGKMHK(ulong DCCPCBLODIG)
		{
			return new ObscuredULong(DCCPCBLODIG);
		}

		// Token: 0x06012B64 RID: 76644 RVA: 0x0081C073 File Offset: 0x0081A273
		public static ulong GAABDMDGPMF(ulong DCCPCBLODIG)
		{
			return ObscuredULong.PLHFEAMCLFH(DCCPCBLODIG, 1UL);
		}

		// Token: 0x06012B65 RID: 76645 RVA: 0x0081C080 File Offset: 0x0081A280
		public void LDCALOOHAFN()
		{
			ulong dccpcblodig = this.PDFJIFJIOJN();
			this.currentCryptoKey = (ulong)((long)UnityEngine.Random.Range(1, 110));
			this.hiddenValue = ObscuredULong.EKKPPKGFFCH(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012B66 RID: 76646 RVA: 0x0081C0B8 File Offset: 0x0081A2B8
		public int AGLPOBPIFCC()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012B67 RID: 76647 RVA: 0x0081C0D4 File Offset: 0x0081A2D4
		public bool EFBDACNFKPA(ObscuredULong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredULong.IBFEFGCIOHO(this.hiddenValue, this.currentCryptoKey) == ObscuredULong.NLGJCBOGJGM(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012B68 RID: 76648 RVA: 0x0081BADB File Offset: 0x00819CDB
		public static ulong PLHFEAMCLFH(ulong DCCPCBLODIG, ulong JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0UL)
			{
				return DCCPCBLODIG ^ ObscuredULong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012B69 RID: 76649 RVA: 0x0081C124 File Offset: 0x0081A324
		public static ObscuredULong OBIJKNFNBMD(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.HHMPNEIPKHE() + 0UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.FCOANDFELKJ(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012B6A RID: 76650 RVA: 0x0081C171 File Offset: 0x0081A371
		public static ulong IAAKNFGKDEJ(ObscuredULong DCCPCBLODIG)
		{
			return DCCPCBLODIG.PDFJIFJIOJN();
		}

		// Token: 0x06012B6B RID: 76651 RVA: 0x0081C17C File Offset: 0x0081A37C
		public static ObscuredULong ELKIBGLHKFA(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 0UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.GLNAMMAFCGO(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012B6C RID: 76652 RVA: 0x0081C1CC File Offset: 0x0081A3CC
		public void OJFAJIJBEFD()
		{
			ulong dccpcblodig = this.MJFIFINDLAM();
			this.currentCryptoKey = (ulong)((long)UnityEngine.Random.Range(1, int.MaxValue));
			this.hiddenValue = ObscuredULong.HBJHGHOKFDK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012B6D RID: 76653 RVA: 0x0081C204 File Offset: 0x0081A404
		public static ObscuredULong PNBEJGJHEHA(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.LHIFOBAECHJ() - 0UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.EKKPPKGFFCH(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012B6E RID: 76654 RVA: 0x0081C251 File Offset: 0x0081A451
		public void GKLHELOGJKC(ulong LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
			{
				this.fakeValue = this.LHIFOBAECHJ();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012B6F RID: 76655 RVA: 0x0081BAD1 File Offset: 0x00819CD1
		public static ulong EFOPLMAGNBD(ulong DCCPCBLODIG)
		{
			return ObscuredULong.MPHCOFBOKOO(DCCPCBLODIG, 0UL);
		}

		// Token: 0x06012B70 RID: 76656 RVA: 0x0081C284 File Offset: 0x0081A484
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012B71 RID: 76657 RVA: 0x0081C2A0 File Offset: 0x0081A4A0
		public string BHLHEJCILKF()
		{
			return this.LHIFOBAECHJ().ToString();
		}

		// Token: 0x06012B72 RID: 76658 RVA: 0x0081C2BB File Offset: 0x0081A4BB
		public static ulong EHHAIMMMLFD(ulong DCCPCBLODIG)
		{
			return ObscuredULong.GLNAMMAFCGO(DCCPCBLODIG, 1UL);
		}

		// Token: 0x06012B73 RID: 76659 RVA: 0x0081C2C5 File Offset: 0x0081A4C5
		public void EEKBCNHPFJG(ulong LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
			{
				this.fakeValue = this.LDHDCODNNJO();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012B74 RID: 76660 RVA: 0x0081C2F8 File Offset: 0x0081A4F8
		public static ObscuredULong DPCDNMHLOJF(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012B75 RID: 76661 RVA: 0x0081C345 File Offset: 0x0081A545
		public static ulong OJHPKFLMOLO(ObscuredULong DCCPCBLODIG)
		{
			return DCCPCBLODIG.CHIBGKNJLDB();
		}

		// Token: 0x06012B76 RID: 76662 RVA: 0x0081C34E File Offset: 0x0081A54E
		public void LABFCHOFAMC(ulong LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012B77 RID: 76663 RVA: 0x0081C380 File Offset: 0x0081A580
		public static ObscuredULong HCFGLLFCDGK(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.CHIBGKNJLDB() - 0UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.FCOANDFELKJ(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
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

		// Token: 0x06012B78 RID: 76664 RVA: 0x0081C3CD File Offset: 0x0081A5CD
		public static ulong EJFMGKHLHOA(ulong DCCPCBLODIG)
		{
			return ObscuredULong.IBFEFGCIOHO(DCCPCBLODIG, 0UL);
		}

		// Token: 0x06012B79 RID: 76665 RVA: 0x0081BADB File Offset: 0x00819CDB
		public static ulong GLNAMMAFCGO(ulong DCCPCBLODIG, ulong JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0UL)
			{
				return DCCPCBLODIG ^ ObscuredULong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012B7A RID: 76666 RVA: 0x0081C3D7 File Offset: 0x0081A5D7
		public bool NMMLCKHECMA(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredULong && this.ECJDCKCFAMP((ObscuredULong)MBKPMBPLIJN);
		}

		// Token: 0x06012B7B RID: 76667 RVA: 0x0081C3EF File Offset: 0x0081A5EF
		public static ulong AEAHOGBNNBO(ulong DCCPCBLODIG)
		{
			return ObscuredULong.DHPGAJEHAFD(DCCPCBLODIG, 0UL);
		}

		// Token: 0x06012B7C RID: 76668 RVA: 0x0081BA97 File Offset: 0x00819C97
		public static void DIKOKKOFHGF(ulong JODDIMFACHN)
		{
			ObscuredULong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012B7D RID: 76669 RVA: 0x0081C3FC File Offset: 0x0081A5FC
		public int CCKILENDOPH()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012B7E RID: 76670 RVA: 0x0081BC54 File Offset: 0x00819E54
		public static ObscuredULong JNOLMICLJBL(ulong DCCPCBLODIG)
		{
			return new ObscuredULong(DCCPCBLODIG);
		}

		// Token: 0x06012B7F RID: 76671 RVA: 0x0081C418 File Offset: 0x0081A618
		public bool PAEOAGPCDEC(ObscuredULong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredULong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredULong.NLGJCBOGJGM(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012B80 RID: 76672 RVA: 0x0081C466 File Offset: 0x0081A666
		public void LABEACCDKMD(ulong LDKMOLEEDIL)
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

		// Token: 0x06012B81 RID: 76673 RVA: 0x0081C498 File Offset: 0x0081A698
		private ulong LHIFOBAECHJ()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredULong.cryptoKey;
				this.hiddenValue = ObscuredULong.KDGJHAMOABL(1UL);
				this.fakeValue = 1UL;
				this.fakeValueActive = false;
				this.inited = false;
				return 1UL;
			}
			ulong num = ObscuredULong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012B82 RID: 76674 RVA: 0x0081C513 File Offset: 0x0081A713
		public ulong EBHHKIBOGME()
		{
			return this.HHMPNEIPKHE();
		}

		// Token: 0x06012B83 RID: 76675 RVA: 0x0081C51C File Offset: 0x0081A71C
		public bool GGAIFHHGFAP(ObscuredULong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredULong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredULong.DHPGAJEHAFD(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012B84 RID: 76676 RVA: 0x0081BA89 File Offset: 0x00819C89
		public ulong PJEIEDPPMKJ()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012B85 RID: 76677 RVA: 0x0081C56A File Offset: 0x0081A76A
		public static ulong PGOAHMBLNAF(ulong DCCPCBLODIG)
		{
			return ObscuredULong.MPHCOFBOKOO(DCCPCBLODIG, 1UL);
		}

		// Token: 0x06012B86 RID: 76678 RVA: 0x0081C574 File Offset: 0x0081A774
		public string NKOIIHFDNHP()
		{
			return this.HHMPNEIPKHE().ToString();
		}

		// Token: 0x06012B87 RID: 76679 RVA: 0x0081C58F File Offset: 0x0081A78F
		public static ulong FIAJPHMJDPA(ulong DCCPCBLODIG)
		{
			return ObscuredULong.KMAKGFIJCNF(DCCPCBLODIG, 0UL);
		}

		// Token: 0x06012B88 RID: 76680 RVA: 0x0081C599 File Offset: 0x0081A799
		public ulong FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012B89 RID: 76681 RVA: 0x0081C5A4 File Offset: 0x0081A7A4
		public static ObscuredULong HIBLFIAPCJE(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012B8A RID: 76682 RVA: 0x0081C5F4 File Offset: 0x0081A7F4
		private ObscuredULong(ulong DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredULong.cryptoKey;
			this.hiddenValue = ObscuredULong.HBJHGHOKFDK(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : 0UL);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x06012B8B RID: 76683 RVA: 0x0081BADB File Offset: 0x00819CDB
		public static ulong NLGJCBOGJGM(ulong DCCPCBLODIG, ulong JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0UL)
			{
				return DCCPCBLODIG ^ ObscuredULong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012B8C RID: 76684 RVA: 0x0081C63A File Offset: 0x0081A83A
		public void JGHPHGOLNEJ()
		{
			if (this.currentCryptoKey != ObscuredULong.cryptoKey)
			{
				this.hiddenValue = ObscuredULong.FCOANDFELKJ(this.CHIBGKNJLDB(), ObscuredULong.cryptoKey);
				this.currentCryptoKey = ObscuredULong.cryptoKey;
			}
		}

		// Token: 0x06012B8D RID: 76685 RVA: 0x0081C66C File Offset: 0x0081A86C
		public int JHDHJANBGDJ()
		{
			return this.CHIBGKNJLDB().GetHashCode();
		}

		// Token: 0x06012B8E RID: 76686 RVA: 0x0081C688 File Offset: 0x0081A888
		public string HADJJLJNBOE(IFormatProvider MCGFPOIAPGJ)
		{
			return this.LHIFOBAECHJ().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012B8F RID: 76687 RVA: 0x0081C6A4 File Offset: 0x0081A8A4
		public string BFOFMHGHALI(string LJCEDKCLBDB)
		{
			return this.HHMPNEIPKHE().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012B90 RID: 76688 RVA: 0x0081C6C0 File Offset: 0x0081A8C0
		public bool IKONKPHGOAB(ObscuredULong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredULong.IBFEFGCIOHO(this.hiddenValue, this.currentCryptoKey) == ObscuredULong.IBFEFGCIOHO(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012B91 RID: 76689 RVA: 0x0081C710 File Offset: 0x0081A910
		public string IGPNJMFIDOD(IFormatProvider MCGFPOIAPGJ)
		{
			return this.LDHDCODNNJO().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012B92 RID: 76690 RVA: 0x0081C72C File Offset: 0x0081A92C
		public static ObscuredULong CGKGALODNMM(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.CHIBGKNJLDB() + 1UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012B93 RID: 76691 RVA: 0x0081C77C File Offset: 0x0081A97C
		public static ObscuredULong AFCHIAIJPKJ(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.LHIFOBAECHJ() - 1UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.EKKPPKGFFCH(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012B94 RID: 76692 RVA: 0x0081C7C9 File Offset: 0x0081A9C9
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredULong && this.Equals((ObscuredULong)MBKPMBPLIJN);
		}

		// Token: 0x06012B95 RID: 76693 RVA: 0x0081C7E4 File Offset: 0x0081A9E4
		public int MKOBBBOOMDE()
		{
			return this.HHMPNEIPKHE().GetHashCode();
		}

		// Token: 0x06012B96 RID: 76694 RVA: 0x0081BA97 File Offset: 0x00819C97
		public static void BBOGAEMNJJN(ulong JODDIMFACHN)
		{
			ObscuredULong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012B97 RID: 76695 RVA: 0x0081C800 File Offset: 0x0081AA00
		private ulong HHMPNEIPKHE()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredULong.cryptoKey;
				this.hiddenValue = ObscuredULong.GAABDMDGPMF(0UL);
				this.fakeValue = 1UL;
				this.fakeValueActive = false;
				this.inited = false;
				return 1UL;
			}
			ulong num = ObscuredULong.NLGJCBOGJGM(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012B98 RID: 76696 RVA: 0x0081BE70 File Offset: 0x0081A070
		public static ulong PABNGNONILM(ulong DCCPCBLODIG)
		{
			return ObscuredULong.EKKPPKGFFCH(DCCPCBLODIG, 0UL);
		}

		// Token: 0x06012B99 RID: 76697 RVA: 0x0081C87B File Offset: 0x0081AA7B
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredULong.cryptoKey)
			{
				this.hiddenValue = ObscuredULong.HBJHGHOKFDK(this.MJFIFINDLAM(), ObscuredULong.cryptoKey);
				this.currentCryptoKey = ObscuredULong.cryptoKey;
			}
		}

		// Token: 0x06012B9A RID: 76698 RVA: 0x0081C8AB File Offset: 0x0081AAAB
		public static ulong BPFCDOLEMAK(ObscuredULong DCCPCBLODIG)
		{
			return DCCPCBLODIG.HHMPNEIPKHE();
		}

		// Token: 0x06012B9B RID: 76699 RVA: 0x0081BADB File Offset: 0x00819CDB
		public static ulong HBJHGHOKFDK(ulong DCCPCBLODIG, ulong JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0UL)
			{
				return DCCPCBLODIG ^ ObscuredULong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012B9C RID: 76700 RVA: 0x0081C8B4 File Offset: 0x0081AAB4
		public static ulong LNFBKAHKAIJ(ulong DCCPCBLODIG)
		{
			return ObscuredULong.NLGJCBOGJGM(DCCPCBLODIG, 1UL);
		}

		// Token: 0x06012B9D RID: 76701 RVA: 0x0081C8C0 File Offset: 0x0081AAC0
		public string FBENMKABKKB()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012B9E RID: 76702 RVA: 0x0081C8DC File Offset: 0x0081AADC
		public string JCAONLDGMCJ()
		{
			return this.PDFJIFJIOJN().ToString();
		}

		// Token: 0x06012B9F RID: 76703 RVA: 0x0081C8F8 File Offset: 0x0081AAF8
		public string IBLEHFEBIMG(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.LHIFOBAECHJ().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012BA0 RID: 76704 RVA: 0x0081C915 File Offset: 0x0081AB15
		public bool EBFMGEOEHBH(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredULong) || this.KAAJNHMODLF((ObscuredULong)MBKPMBPLIJN);
		}

		// Token: 0x06012BA1 RID: 76705 RVA: 0x0081C930 File Offset: 0x0081AB30
		private ulong CHIBGKNJLDB()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredULong.cryptoKey;
				this.hiddenValue = ObscuredULong.PABNGNONILM(1UL);
				this.fakeValue = 1UL;
				this.fakeValueActive = false;
				this.inited = false;
				return 0UL;
			}
			ulong num = ObscuredULong.KMAKGFIJCNF(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012BA2 RID: 76706 RVA: 0x0081C9AC File Offset: 0x0081ABAC
		public int KMBAMCKNAIK()
		{
			return this.PDFJIFJIOJN().GetHashCode();
		}

		// Token: 0x06012BA3 RID: 76707 RVA: 0x0081C9C8 File Offset: 0x0081ABC8
		public void CEJJLKNKCIK()
		{
			ulong dccpcblodig = this.CHIBGKNJLDB();
			this.currentCryptoKey = (ulong)((long)UnityEngine.Random.Range(0, 62));
			this.hiddenValue = ObscuredULong.FCOANDFELKJ(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012BA4 RID: 76708 RVA: 0x0081C3EF File Offset: 0x0081A5EF
		public static ulong DHPGAJEHAFD(ulong DCCPCBLODIG)
		{
			return ObscuredULong.DHPGAJEHAFD(DCCPCBLODIG, 0UL);
		}

		// Token: 0x06012BA5 RID: 76709 RVA: 0x0081CA00 File Offset: 0x0081AC00
		public string ToString(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012BA6 RID: 76710 RVA: 0x0081BADB File Offset: 0x00819CDB
		public static ulong FCOANDFELKJ(ulong DCCPCBLODIG, ulong JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0UL)
			{
				return DCCPCBLODIG ^ ObscuredULong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012BA7 RID: 76711 RVA: 0x0081CA20 File Offset: 0x0081AC20
		public static ObscuredULong MCKMMFAPLAC(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.PDFJIFJIOJN() + 0UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012BA8 RID: 76712 RVA: 0x0081CA70 File Offset: 0x0081AC70
		public int KGOHJKEKKON()
		{
			return this.LHIFOBAECHJ().GetHashCode();
		}

		// Token: 0x06012BA9 RID: 76713 RVA: 0x0081C7C9 File Offset: 0x0081A9C9
		public bool OCCFLLIPACC(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredULong && this.Equals((ObscuredULong)MBKPMBPLIJN);
		}

		// Token: 0x06012BAA RID: 76714 RVA: 0x0081CA8C File Offset: 0x0081AC8C
		public int KANDOCKKGBO()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012BAB RID: 76715 RVA: 0x0081BC54 File Offset: 0x00819E54
		public static ObscuredULong EJKAEEKCFGN(ulong DCCPCBLODIG)
		{
			return new ObscuredULong(DCCPCBLODIG);
		}

		// Token: 0x06012BAC RID: 76716 RVA: 0x0081BADB File Offset: 0x00819CDB
		public static ulong IBFEFGCIOHO(ulong DCCPCBLODIG, ulong JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0UL)
			{
				return DCCPCBLODIG ^ ObscuredULong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012BAD RID: 76717 RVA: 0x0081CAA8 File Offset: 0x0081ACA8
		public bool ECJDCKCFAMP(ObscuredULong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredULong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredULong.NLGJCBOGJGM(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012BAE RID: 76718 RVA: 0x0081CAF8 File Offset: 0x0081ACF8
		public static ObscuredULong BKMHIPFPPNF(ObscuredULong NFKFMIIAKFN)
		{
			ulong dccpcblodig = NFKFMIIAKFN.LDHDCODNNJO() + 1UL;
			NFKFMIIAKFN.hiddenValue = ObscuredULong.GLNAMMAFCGO(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012BAF RID: 76719 RVA: 0x0081CB48 File Offset: 0x0081AD48
		private ulong LDHDCODNNJO()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredULong.cryptoKey;
				this.hiddenValue = ObscuredULong.ALHMMAGENAF(0UL);
				this.fakeValue = 0UL;
				this.fakeValueActive = false;
				this.inited = false;
				return 0UL;
			}
			ulong num = ObscuredULong.IBFEFGCIOHO(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.LHMMLFNJOMC() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012BB0 RID: 76720 RVA: 0x0081CBC4 File Offset: 0x0081ADC4
		private ulong MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredULong.cryptoKey;
				this.hiddenValue = ObscuredULong.HBJHGHOKFDK(0UL);
				this.fakeValue = 0UL;
				this.fakeValueActive = false;
				this.inited = true;
				return 0UL;
			}
			ulong num = ObscuredULong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012BB1 RID: 76721 RVA: 0x0081C513 File Offset: 0x0081A713
		public ulong BAPJHEHHPHM()
		{
			return this.HHMPNEIPKHE();
		}

		// Token: 0x04002662 RID: 9826
		private static ulong cryptoKey = 444443UL;

		// Token: 0x04002663 RID: 9827
		[SerializeField]
		private ulong currentCryptoKey;

		// Token: 0x04002664 RID: 9828
		[SerializeField]
		private ulong hiddenValue;

		// Token: 0x04002665 RID: 9829
		[SerializeField]
		private bool inited;

		// Token: 0x04002666 RID: 9830
		[SerializeField]
		private ulong fakeValue;

		// Token: 0x04002667 RID: 9831
		[SerializeField]
		private bool fakeValueActive;
	}
}
