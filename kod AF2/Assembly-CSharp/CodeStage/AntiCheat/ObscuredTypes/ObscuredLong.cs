using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000585 RID: 1413
	[Serializable]
	public struct ObscuredLong : IEquatable<ObscuredLong>, IFormattable
	{
		// Token: 0x06012838 RID: 75832 RVA: 0x00813C34 File Offset: 0x00811E34
		public long PPBALHFAEHI()
		{
			return this.FMPCPHMDCIE();
		}

		// Token: 0x06012839 RID: 75833 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long HBJHGHOKFDK(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x0601283A RID: 75834 RVA: 0x00813C4C File Offset: 0x00811E4C
		public bool IJAIPHGBBAM(ObscuredLong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredLong.NNKOGMGCJOK(this.hiddenValue, this.currentCryptoKey) == ObscuredLong.CBMEEOOBKJB(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x0601283B RID: 75835 RVA: 0x00813C9C File Offset: 0x00811E9C
		private long PGGFGCEDMAD()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredLong.cryptoKey;
				this.hiddenValue = ObscuredLong.IDGEJAPPLLL(0L);
				this.fakeValue = 0L;
				this.fakeValueActive = false;
				this.inited = false;
				return 1L;
			}
			long num = ObscuredLong.CBMEEOOBKJB(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.CKFIDHHGLGO() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x0601283C RID: 75836 RVA: 0x00813D18 File Offset: 0x00811F18
		public string ToString(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x0601283D RID: 75837 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long DPMKCLKIHEF(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x0601283E RID: 75838 RVA: 0x00813D35 File Offset: 0x00811F35
		public long JFGMGBHIJKF()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x0601283F RID: 75839 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long EKHKPLPIELN(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012840 RID: 75840 RVA: 0x00813D3D File Offset: 0x00811F3D
		public static ObscuredLong BCLJOMMFGEN(long DCCPCBLODIG)
		{
			return new ObscuredLong(DCCPCBLODIG);
		}

		// Token: 0x06012841 RID: 75841 RVA: 0x00813D45 File Offset: 0x00811F45
		public void HHGBMEJFDOC(long LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.PGGFGCEDMAD();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012842 RID: 75842 RVA: 0x00813D77 File Offset: 0x00811F77
		public static void PPGLAHCNCAF(long JODDIMFACHN)
		{
			ObscuredLong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012843 RID: 75843 RVA: 0x00813D80 File Offset: 0x00811F80
		public bool GAAMGONJOGE(ObscuredLong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredLong.FJPMOKOENJO(this.hiddenValue, this.currentCryptoKey) == ObscuredLong.CGGIJFECMLD(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012844 RID: 75844 RVA: 0x00813DCE File Offset: 0x00811FCE
		public void BLCOJGALCMJ()
		{
			if (this.currentCryptoKey != ObscuredLong.cryptoKey)
			{
				this.hiddenValue = ObscuredLong.DPMKCLKIHEF(this.FMPCPHMDCIE(), ObscuredLong.cryptoKey);
				this.currentCryptoKey = ObscuredLong.cryptoKey;
			}
		}

		// Token: 0x06012845 RID: 75845 RVA: 0x00813E00 File Offset: 0x00812000
		public static ObscuredLong DPCDNMHLOJF(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012846 RID: 75846 RVA: 0x00813E4D File Offset: 0x0081204D
		public static long AJMPAOCEPCA(ObscuredLong DCCPCBLODIG)
		{
			return DCCPCBLODIG.FMPCPHMDCIE();
		}

		// Token: 0x06012847 RID: 75847 RVA: 0x00813E58 File Offset: 0x00812058
		public string KIKOCPPKJOE(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.FMPCPHMDCIE().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012848 RID: 75848 RVA: 0x00813E75 File Offset: 0x00812075
		public void OFABOJLDDLA()
		{
			if (this.currentCryptoKey != ObscuredLong.cryptoKey)
			{
				this.hiddenValue = ObscuredLong.HBJHGHOKFDK(this.FMPCPHMDCIE(), ObscuredLong.cryptoKey);
				this.currentCryptoKey = ObscuredLong.cryptoKey;
			}
		}

		// Token: 0x06012849 RID: 75849 RVA: 0x00813EA8 File Offset: 0x008120A8
		public static ObscuredLong BGHNPDLOHIP(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 0L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.DPMKCLKIHEF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x0601284A RID: 75850 RVA: 0x00813EF8 File Offset: 0x008120F8
		public string ALAAOKOIJNG(IFormatProvider MCGFPOIAPGJ)
		{
			return this.LDHDCODNNJO().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x0601284B RID: 75851 RVA: 0x00813D77 File Offset: 0x00811F77
		public static void GLJALOGDCJN(long JODDIMFACHN)
		{
			ObscuredLong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601284C RID: 75852 RVA: 0x00813F14 File Offset: 0x00812114
		public static long HFMJGLFGJIJ(long DCCPCBLODIG)
		{
			return ObscuredLong.EKHKPLPIELN(DCCPCBLODIG, 0L);
		}

		// Token: 0x0601284D RID: 75853 RVA: 0x00813F20 File Offset: 0x00812120
		private long LDHDCODNNJO()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredLong.cryptoKey;
				this.hiddenValue = ObscuredLong.HFMJGLFGJIJ(0L);
				this.fakeValue = 1L;
				this.fakeValueActive = true;
				this.inited = false;
				return 0L;
			}
			long num = ObscuredLong.FJPMOKOENJO(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x0601284E RID: 75854 RVA: 0x00813D77 File Offset: 0x00811F77
		public static void JHHJOJPEKGK(long JODDIMFACHN)
		{
			ObscuredLong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601284F RID: 75855 RVA: 0x00813F9C File Offset: 0x0081219C
		public void CAAPJGKKHEH()
		{
			long dccpcblodig = this.LDHDCODNNJO();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(-150, -118);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredLong.DPMKCLKIHEF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012850 RID: 75856 RVA: 0x00813FE0 File Offset: 0x008121E0
		public string HPBHHAKPGAD()
		{
			return this.PGGFGCEDMAD().ToString();
		}

		// Token: 0x06012851 RID: 75857 RVA: 0x00813FFB File Offset: 0x008121FB
		public long DJIMKHEIMGL()
		{
			this.CJONFLACABN();
			return this.hiddenValue;
		}

		// Token: 0x06012852 RID: 75858 RVA: 0x0081400C File Offset: 0x0081220C
		public static ObscuredLong JOPHOEJJJKP(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.PGGFGCEDMAD() + 1L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.IBGFABOCLGB(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012853 RID: 75859 RVA: 0x00814059 File Offset: 0x00812259
		public void CFJMBLIDBCM(long LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue = this.LDHDCODNNJO();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012854 RID: 75860 RVA: 0x0081408C File Offset: 0x0081228C
		public bool KENMLFOLLIN(ObscuredLong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredLong.CBMEEOOBKJB(this.hiddenValue, this.currentCryptoKey) == ObscuredLong.CGGIJFECMLD(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012855 RID: 75861 RVA: 0x008140DC File Offset: 0x008122DC
		public string FPPLGDMIGKI(string LJCEDKCLBDB)
		{
			return this.PGGFGCEDMAD().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012856 RID: 75862 RVA: 0x00813D3D File Offset: 0x00811F3D
		public static ObscuredLong GOOIABGKMHK(long DCCPCBLODIG)
		{
			return new ObscuredLong(DCCPCBLODIG);
		}

		// Token: 0x06012857 RID: 75863 RVA: 0x008140F8 File Offset: 0x008122F8
		public static long GHEHANKICON(long DCCPCBLODIG)
		{
			return ObscuredLong.EKHKPLPIELN(DCCPCBLODIG, 1L);
		}

		// Token: 0x06012858 RID: 75864 RVA: 0x00814104 File Offset: 0x00812304
		public static ObscuredLong CCBBCCHBPAG(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.FMPCPHMDCIE() + 0L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.DPMKCLKIHEF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012859 RID: 75865 RVA: 0x00814151 File Offset: 0x00812351
		public void JBFDICDJKJL()
		{
			if (this.currentCryptoKey != ObscuredLong.cryptoKey)
			{
				this.hiddenValue = ObscuredLong.IBGFABOCLGB(this.LDHDCODNNJO(), ObscuredLong.cryptoKey);
				this.currentCryptoKey = ObscuredLong.cryptoKey;
			}
		}

		// Token: 0x0601285A RID: 75866 RVA: 0x00814181 File Offset: 0x00812381
		public long AEDLKILCKME()
		{
			return this.PGGFGCEDMAD();
		}

		// Token: 0x0601285B RID: 75867 RVA: 0x00814189 File Offset: 0x00812389
		public void BFMLDJIOKGM()
		{
			if (this.currentCryptoKey != ObscuredLong.cryptoKey)
			{
				this.hiddenValue = ObscuredLong.DPMKCLKIHEF(this.MJFIFINDLAM(), ObscuredLong.cryptoKey);
				this.currentCryptoKey = ObscuredLong.cryptoKey;
			}
		}

		// Token: 0x0601285C RID: 75868 RVA: 0x008141B9 File Offset: 0x008123B9
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredLong && this.Equals((ObscuredLong)MBKPMBPLIJN);
		}

		// Token: 0x0601285D RID: 75869 RVA: 0x008141D4 File Offset: 0x008123D4
		public string CCFEPJBGCEB(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.JLBBIOPPDPK().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x0601285E RID: 75870 RVA: 0x008141F4 File Offset: 0x008123F4
		public void OJFAJIJBEFD()
		{
			long dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredLong.HBJHGHOKFDK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601285F RID: 75871 RVA: 0x00814238 File Offset: 0x00812438
		public static ObscuredLong KOIPMGGIDJE(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.FMPCPHMDCIE() + 1L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012860 RID: 75872 RVA: 0x00814288 File Offset: 0x00812488
		public string PDMPLOPPLBI(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.LDHDCODNNJO().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012861 RID: 75873 RVA: 0x008142A8 File Offset: 0x008124A8
		public string OCJAOJLHOFO(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012862 RID: 75874 RVA: 0x008142C8 File Offset: 0x008124C8
		private long JLBBIOPPDPK()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredLong.cryptoKey;
				this.hiddenValue = ObscuredLong.IDGEJAPPLLL(0L);
				this.fakeValue = 1L;
				this.fakeValueActive = false;
				this.inited = true;
				return 1L;
			}
			long num = ObscuredLong.CBMEEOOBKJB(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012863 RID: 75875 RVA: 0x00814343 File Offset: 0x00812543
		public long PPOLGPGMJBG()
		{
			this.BLCOJGALCMJ();
			return this.hiddenValue;
		}

		// Token: 0x06012864 RID: 75876 RVA: 0x00814351 File Offset: 0x00812551
		public void LABEACCDKMD(long LDKMOLEEDIL)
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

		// Token: 0x06012865 RID: 75877 RVA: 0x00814383 File Offset: 0x00812583
		public bool BJFOHGGCKNP(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredLong) || this.Equals((ObscuredLong)MBKPMBPLIJN);
		}

		// Token: 0x06012866 RID: 75878 RVA: 0x00813D35 File Offset: 0x00811F35
		public long FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012867 RID: 75879 RVA: 0x0081439B File Offset: 0x0081259B
		public long DBDBBGDOJHM()
		{
			this.BFMLDJIOKGM();
			return this.hiddenValue;
		}

		// Token: 0x06012868 RID: 75880 RVA: 0x008143AC File Offset: 0x008125AC
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012869 RID: 75881 RVA: 0x008143C8 File Offset: 0x008125C8
		public static ObscuredLong LAPIKEKJOIA(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.PGGFGCEDMAD() - 1L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x0601286A RID: 75882 RVA: 0x00814415 File Offset: 0x00812615
		public static long BIHICOOKCOA(long DCCPCBLODIG)
		{
			return ObscuredLong.JOKDAJNFKIH(DCCPCBLODIG, 1L);
		}

		// Token: 0x0601286B RID: 75883 RVA: 0x00814420 File Offset: 0x00812620
		public bool NEBNNHMFKEP(ObscuredLong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredLong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredLong.KGKMJBNAJEK(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x0601286C RID: 75884 RVA: 0x00813D3D File Offset: 0x00811F3D
		public static ObscuredLong OKLNFHAAMEL(long DCCPCBLODIG)
		{
			return new ObscuredLong(DCCPCBLODIG);
		}

		// Token: 0x0601286D RID: 75885 RVA: 0x0081446E File Offset: 0x0081266E
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredLong.cryptoKey)
			{
				this.hiddenValue = ObscuredLong.HBJHGHOKFDK(this.MJFIFINDLAM(), ObscuredLong.cryptoKey);
				this.currentCryptoKey = ObscuredLong.cryptoKey;
			}
		}

		// Token: 0x0601286E RID: 75886 RVA: 0x008144A0 File Offset: 0x008126A0
		public int MKOBBBOOMDE()
		{
			return this.LDHDCODNNJO().GetHashCode();
		}

		// Token: 0x0601286F RID: 75887 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long JOKDAJNFKIH(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012870 RID: 75888 RVA: 0x008144BC File Offset: 0x008126BC
		public string GCIGMHOJAIM()
		{
			return this.FMPCPHMDCIE().ToString();
		}

		// Token: 0x06012871 RID: 75889 RVA: 0x008144D7 File Offset: 0x008126D7
		public static long EOMLEHGNGHA(long DCCPCBLODIG)
		{
			return ObscuredLong.PCIAPDPOPEN(DCCPCBLODIG, 1L);
		}

		// Token: 0x06012872 RID: 75890 RVA: 0x008144E4 File Offset: 0x008126E4
		public bool Equals(ObscuredLong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredLong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredLong.DHPGAJEHAFD(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012873 RID: 75891 RVA: 0x00814383 File Offset: 0x00812583
		public bool OGIPCMEIIIN(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredLong) || this.Equals((ObscuredLong)MBKPMBPLIJN);
		}

		// Token: 0x06012874 RID: 75892 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long NNKOGMGCJOK(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012875 RID: 75893 RVA: 0x00814532 File Offset: 0x00812732
		public long AENCEDLJHJJ()
		{
			this.OFABOJLDDLA();
			return this.hiddenValue;
		}

		// Token: 0x06012876 RID: 75894 RVA: 0x00814540 File Offset: 0x00812740
		public string MDAPFDLEEGN(string LJCEDKCLBDB)
		{
			return this.LDHDCODNNJO().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012877 RID: 75895 RVA: 0x0081455C File Offset: 0x0081275C
		public int DILKBBPPALM()
		{
			return this.PGGFGCEDMAD().GetHashCode();
		}

		// Token: 0x06012878 RID: 75896 RVA: 0x00814577 File Offset: 0x00812777
		public void GKLHELOGJKC(long LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue = this.JLBBIOPPDPK();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012879 RID: 75897 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long IBGFABOCLGB(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x0601287A RID: 75898 RVA: 0x008145AC File Offset: 0x008127AC
		public int JOGFJBHDKAB()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x0601287B RID: 75899 RVA: 0x00813D35 File Offset: 0x00811F35
		public long BBNFOKCFHIA()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x0601287C RID: 75900 RVA: 0x008145C8 File Offset: 0x008127C8
		public static ObscuredLong MCKMMFAPLAC(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 0L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x0601287E RID: 75902 RVA: 0x00814624 File Offset: 0x00812824
		public static ObscuredLong HIBLFIAPCJE(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x0601287F RID: 75903 RVA: 0x00814674 File Offset: 0x00812874
		public int NMNJMEMAHOF()
		{
			return this.PGGFGCEDMAD().GetHashCode();
		}

		// Token: 0x06012880 RID: 75904 RVA: 0x0081468F File Offset: 0x0081288F
		public void GMMNGEGIABM()
		{
			if (this.currentCryptoKey != ObscuredLong.cryptoKey)
			{
				this.hiddenValue = ObscuredLong.IBGFABOCLGB(this.FMPCPHMDCIE(), ObscuredLong.cryptoKey);
				this.currentCryptoKey = ObscuredLong.cryptoKey;
			}
		}

		// Token: 0x06012881 RID: 75905 RVA: 0x008146C0 File Offset: 0x008128C0
		public int LDJIMIOFKLG()
		{
			return this.PGGFGCEDMAD().GetHashCode();
		}

		// Token: 0x06012882 RID: 75906 RVA: 0x008146DB File Offset: 0x008128DB
		public bool PBLFGPOBFKB(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredLong && this.GMDDPAGHGGJ((ObscuredLong)MBKPMBPLIJN);
		}

		// Token: 0x06012883 RID: 75907 RVA: 0x008146F4 File Offset: 0x008128F4
		public int KFJNBMNEILO()
		{
			return this.PGGFGCEDMAD().GetHashCode();
		}

		// Token: 0x06012884 RID: 75908 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long FDGNJNPCODG(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012885 RID: 75909 RVA: 0x00814710 File Offset: 0x00812910
		public bool PIMIMLGPKKD(ObscuredLong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredLong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredLong.FDGNJNPCODG(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012886 RID: 75910 RVA: 0x0081475E File Offset: 0x0081295E
		public static long PMNJNFBCAFA(long DCCPCBLODIG)
		{
			return ObscuredLong.DHPGAJEHAFD(DCCPCBLODIG, 0L);
		}

		// Token: 0x06012887 RID: 75911 RVA: 0x00814768 File Offset: 0x00812968
		public static ObscuredLong BBFBKGCHHID(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.FMPCPHMDCIE() - 0L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.IBGFABOCLGB(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012888 RID: 75912 RVA: 0x008147B8 File Offset: 0x008129B8
		public int IPFEPLBJLHN()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012889 RID: 75913 RVA: 0x008147D3 File Offset: 0x008129D3
		public static long GOOIABGKMHK(ObscuredLong DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x0601288A RID: 75914 RVA: 0x00813D3D File Offset: 0x00811F3D
		public static ObscuredLong LOMHAKCJMFD(long DCCPCBLODIG)
		{
			return new ObscuredLong(DCCPCBLODIG);
		}

		// Token: 0x0601288B RID: 75915 RVA: 0x00813C34 File Offset: 0x00811E34
		public long HELOADOKOKK()
		{
			return this.FMPCPHMDCIE();
		}

		// Token: 0x0601288C RID: 75916 RVA: 0x008147DC File Offset: 0x008129DC
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x0601288D RID: 75917 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long FJPMOKOENJO(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x0601288E RID: 75918 RVA: 0x008147F7 File Offset: 0x008129F7
		public void OAFKCFCCNPE(long LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.LDHDCODNNJO();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x0601288F RID: 75919 RVA: 0x0081482C File Offset: 0x00812A2C
		public int MJJAIKCEPCL()
		{
			return this.JLBBIOPPDPK().GetHashCode();
		}

		// Token: 0x06012890 RID: 75920 RVA: 0x00814847 File Offset: 0x00812A47
		public static long FCFEHHACFAC(long DCCPCBLODIG)
		{
			return ObscuredLong.DPMKCLKIHEF(DCCPCBLODIG, 0L);
		}

		// Token: 0x06012891 RID: 75921 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long KGKMJBNAJEK(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012892 RID: 75922 RVA: 0x00814851 File Offset: 0x00812A51
		public void KPBGDNCICHD()
		{
			if (this.currentCryptoKey != ObscuredLong.cryptoKey)
			{
				this.hiddenValue = ObscuredLong.EKHKPLPIELN(this.FMPCPHMDCIE(), ObscuredLong.cryptoKey);
				this.currentCryptoKey = ObscuredLong.cryptoKey;
			}
		}

		// Token: 0x06012893 RID: 75923 RVA: 0x00814881 File Offset: 0x00812A81
		public void MPIGCNCMOEA()
		{
			if (this.currentCryptoKey != ObscuredLong.cryptoKey)
			{
				this.hiddenValue = ObscuredLong.EKHKPLPIELN(this.MJFIFINDLAM(), ObscuredLong.cryptoKey);
				this.currentCryptoKey = ObscuredLong.cryptoKey;
			}
		}

		// Token: 0x06012894 RID: 75924 RVA: 0x008148B1 File Offset: 0x00812AB1
		public void JGIDOFDFNLN(long LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.FMPCPHMDCIE();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012895 RID: 75925 RVA: 0x00814847 File Offset: 0x00812A47
		public static long IDGEJAPPLLL(long DCCPCBLODIG)
		{
			return ObscuredLong.DPMKCLKIHEF(DCCPCBLODIG, 0L);
		}

		// Token: 0x06012896 RID: 75926 RVA: 0x008148E3 File Offset: 0x00812AE3
		public static long CKKGKFLLKIJ(long DCCPCBLODIG)
		{
			return ObscuredLong.DPMKCLKIHEF(DCCPCBLODIG, 1L);
		}

		// Token: 0x06012897 RID: 75927 RVA: 0x008148ED File Offset: 0x00812AED
		public long OMEJLEAJGMA()
		{
			this.KPBGDNCICHD();
			return this.hiddenValue;
		}

		// Token: 0x06012898 RID: 75928 RVA: 0x008148FC File Offset: 0x00812AFC
		public static ObscuredLong ABCAEFFNDGJ(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.LDHDCODNNJO() + 1L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.EKHKPLPIELN(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
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

		// Token: 0x06012899 RID: 75929 RVA: 0x008144D7 File Offset: 0x008126D7
		public static long LNHEDNKIKEC(long DCCPCBLODIG)
		{
			return ObscuredLong.PCIAPDPOPEN(DCCPCBLODIG, 1L);
		}

		// Token: 0x0601289A RID: 75930 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long CBMEEOOBKJB(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x0601289B RID: 75931 RVA: 0x0081494C File Offset: 0x00812B4C
		public int ALMJMHMKEDP()
		{
			return this.PGGFGCEDMAD().GetHashCode();
		}

		// Token: 0x0601289C RID: 75932 RVA: 0x00813D77 File Offset: 0x00811F77
		public static void BBOGAEMNJJN(long JODDIMFACHN)
		{
			ObscuredLong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601289D RID: 75933 RVA: 0x00814968 File Offset: 0x00812B68
		public void MALCFCGMEOO()
		{
			long dccpcblodig = this.PGGFGCEDMAD();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(90, -4);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredLong.EKHKPLPIELN(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601289E RID: 75934 RVA: 0x008149AC File Offset: 0x00812BAC
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x0601289F RID: 75935 RVA: 0x008149C7 File Offset: 0x00812BC7
		public void JIHKLCOBPMG()
		{
			if (this.currentCryptoKey != ObscuredLong.cryptoKey)
			{
				this.hiddenValue = ObscuredLong.EKHKPLPIELN(this.JLBBIOPPDPK(), ObscuredLong.cryptoKey);
				this.currentCryptoKey = ObscuredLong.cryptoKey;
			}
		}

		// Token: 0x060128A0 RID: 75936 RVA: 0x008149F7 File Offset: 0x00812BF7
		public bool JJALCADHNHE(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredLong && this.NEBNNHMFKEP((ObscuredLong)MBKPMBPLIJN);
		}

		// Token: 0x060128A1 RID: 75937 RVA: 0x00814A10 File Offset: 0x00812C10
		public int MEACMCLEHNO()
		{
			return this.JLBBIOPPDPK().GetHashCode();
		}

		// Token: 0x060128A2 RID: 75938 RVA: 0x00814532 File Offset: 0x00812732
		public long KFCGHCOHECA()
		{
			this.OFABOJLDDLA();
			return this.hiddenValue;
		}

		// Token: 0x060128A3 RID: 75939 RVA: 0x00814A2B File Offset: 0x00812C2B
		public static long HBJHGHOKFDK(long DCCPCBLODIG)
		{
			return ObscuredLong.HBJHGHOKFDK(DCCPCBLODIG, 0L);
		}

		// Token: 0x060128A4 RID: 75940 RVA: 0x00814A35 File Offset: 0x00812C35
		public void BJJCJDNNKJI(long LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.JLBBIOPPDPK();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x060128A5 RID: 75941 RVA: 0x0081475E File Offset: 0x0081295E
		public static long DHPGAJEHAFD(long DCCPCBLODIG)
		{
			return ObscuredLong.DHPGAJEHAFD(DCCPCBLODIG, 0L);
		}

		// Token: 0x060128A6 RID: 75942 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long DHPGAJEHAFD(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060128A7 RID: 75943 RVA: 0x00814A68 File Offset: 0x00812C68
		public void PHKABBEJALH()
		{
			long dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(192, -193);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredLong.EKHKPLPIELN(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060128A8 RID: 75944 RVA: 0x00814181 File Offset: 0x00812381
		public long DPNALKKDNAL()
		{
			return this.PGGFGCEDMAD();
		}

		// Token: 0x060128A9 RID: 75945 RVA: 0x00814AAC File Offset: 0x00812CAC
		public static ObscuredLong MIMIBMHNMGA(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.PGGFGCEDMAD() - 1L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.IBGFABOCLGB(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060128AA RID: 75946 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long PCIAPDPOPEN(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060128AB RID: 75947 RVA: 0x00813C3C File Offset: 0x00811E3C
		public static long CGGIJFECMLD(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0L)
			{
				return DCCPCBLODIG ^ ObscuredLong.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060128AC RID: 75948 RVA: 0x00813D3D File Offset: 0x00811F3D
		public static ObscuredLong AKPFIBEKBLP(long DCCPCBLODIG)
		{
			return new ObscuredLong(DCCPCBLODIG);
		}

		// Token: 0x060128AD RID: 75949 RVA: 0x0081439B File Offset: 0x0081259B
		public long IBDGEBNPAPA()
		{
			this.BFMLDJIOKGM();
			return this.hiddenValue;
		}

		// Token: 0x060128AE RID: 75950 RVA: 0x00814AFC File Offset: 0x00812CFC
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060128AF RID: 75951 RVA: 0x00814B18 File Offset: 0x00812D18
		public int PILBMMPHGNL()
		{
			return this.FMPCPHMDCIE().GetHashCode();
		}

		// Token: 0x060128B0 RID: 75952 RVA: 0x00814B34 File Offset: 0x00812D34
		public string DFHAGGBIEIH(IFormatProvider MCGFPOIAPGJ)
		{
			return this.FMPCPHMDCIE().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060128B1 RID: 75953 RVA: 0x00814B50 File Offset: 0x00812D50
		public void BMAHAKGPIAN()
		{
			long dccpcblodig = this.FMPCPHMDCIE();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(166, 193);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredLong.DPMKCLKIHEF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060128B2 RID: 75954 RVA: 0x00814B94 File Offset: 0x00812D94
		public int HMCGKGHAGAE()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x060128B3 RID: 75955 RVA: 0x00814BAF File Offset: 0x00812DAF
		public void ILPJJJDLOGP(long LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.JLBBIOPPDPK();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x060128B4 RID: 75956 RVA: 0x00813D77 File Offset: 0x00811F77
		public static void BDJGOLLDCCI(long JODDIMFACHN)
		{
			ObscuredLong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060128B5 RID: 75957 RVA: 0x00813D77 File Offset: 0x00811F77
		public static void BPDEIHFMDFO(long JODDIMFACHN)
		{
			ObscuredLong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060128B6 RID: 75958 RVA: 0x00814BE4 File Offset: 0x00812DE4
		public string ALELIIHGHGH()
		{
			return this.FMPCPHMDCIE().ToString();
		}

		// Token: 0x060128B7 RID: 75959 RVA: 0x00814C00 File Offset: 0x00812E00
		private long MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredLong.cryptoKey;
				this.hiddenValue = ObscuredLong.HBJHGHOKFDK(0L);
				this.fakeValue = 0L;
				this.fakeValueActive = false;
				this.inited = true;
				return 0L;
			}
			long num = ObscuredLong.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x060128B8 RID: 75960 RVA: 0x00814C7C File Offset: 0x00812E7C
		public string GJCCJEINDDC(IFormatProvider MCGFPOIAPGJ)
		{
			return this.JLBBIOPPDPK().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060128B9 RID: 75961 RVA: 0x00813D3D File Offset: 0x00811F3D
		public static ObscuredLong LBDMFALMOLD(long DCCPCBLODIG)
		{
			return new ObscuredLong(DCCPCBLODIG);
		}

		// Token: 0x060128BA RID: 75962 RVA: 0x00814C98 File Offset: 0x00812E98
		public void CJONFLACABN()
		{
			if (this.currentCryptoKey != ObscuredLong.cryptoKey)
			{
				this.hiddenValue = ObscuredLong.EKHKPLPIELN(this.PGGFGCEDMAD(), ObscuredLong.cryptoKey);
				this.currentCryptoKey = ObscuredLong.cryptoKey;
			}
		}

		// Token: 0x060128BB RID: 75963 RVA: 0x00813D77 File Offset: 0x00811F77
		public static void ABIDDAAKMFN(long JODDIMFACHN)
		{
			ObscuredLong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060128BC RID: 75964 RVA: 0x00814CC8 File Offset: 0x00812EC8
		public string BPODJNKAIEC(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060128BD RID: 75965 RVA: 0x00814CE4 File Offset: 0x00812EE4
		public string PINLAFIAGGJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.LDHDCODNNJO().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060128BE RID: 75966 RVA: 0x00814D00 File Offset: 0x00812F00
		public static ObscuredLong NIBFPLAMEEO(ObscuredLong NFKFMIIAKFN)
		{
			long dccpcblodig = NFKFMIIAKFN.FMPCPHMDCIE() + 0L;
			NFKFMIIAKFN.hiddenValue = ObscuredLong.IBGFABOCLGB(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060128BF RID: 75967 RVA: 0x00814D50 File Offset: 0x00812F50
		public void FIPHHCCLECL()
		{
			long dccpcblodig = this.PGGFGCEDMAD();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(184, 66);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredLong.DPMKCLKIHEF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060128C0 RID: 75968 RVA: 0x008148ED File Offset: 0x00812AED
		public long GJBBPLGAHHF()
		{
			this.KPBGDNCICHD();
			return this.hiddenValue;
		}

		// Token: 0x060128C1 RID: 75969 RVA: 0x00814D94 File Offset: 0x00812F94
		public void PEIEGPNLBJC(long LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x060128C2 RID: 75970 RVA: 0x00814DC8 File Offset: 0x00812FC8
		private ObscuredLong(long DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredLong.cryptoKey;
			this.hiddenValue = ObscuredLong.HBJHGHOKFDK(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : 0L);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x060128C3 RID: 75971 RVA: 0x00814E0E File Offset: 0x0081300E
		public long AEPDPCMKKGE()
		{
			return this.JLBBIOPPDPK();
		}

		// Token: 0x060128C4 RID: 75972 RVA: 0x00813D77 File Offset: 0x00811F77
		public static void OOKAKJEEJDI(long JODDIMFACHN)
		{
			ObscuredLong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060128C5 RID: 75973 RVA: 0x00813D77 File Offset: 0x00811F77
		public static void DNJOKACAOGJ(long JODDIMFACHN)
		{
			ObscuredLong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060128C6 RID: 75974 RVA: 0x00814E16 File Offset: 0x00813016
		public long LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x060128C7 RID: 75975 RVA: 0x00814E24 File Offset: 0x00813024
		public bool GMDDPAGHGGJ(ObscuredLong MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredLong.CGGIJFECMLD(this.hiddenValue, this.currentCryptoKey) == ObscuredLong.NNKOGMGCJOK(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x060128C8 RID: 75976 RVA: 0x00814E74 File Offset: 0x00813074
		private long FMPCPHMDCIE()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredLong.cryptoKey;
				this.hiddenValue = ObscuredLong.FCFEHHACFAC(1L);
				this.fakeValue = 1L;
				this.fakeValueActive = true;
				this.inited = true;
				return 0L;
			}
			long num = ObscuredLong.CBMEEOOBKJB(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x060128C9 RID: 75977 RVA: 0x00814EEF File Offset: 0x008130EF
		public static long IPMKPELEKGK(ObscuredLong DCCPCBLODIG)
		{
			return DCCPCBLODIG.PGGFGCEDMAD();
		}

		// Token: 0x060128CA RID: 75978 RVA: 0x00814E0E File Offset: 0x0081300E
		public long MKLAPECONKO()
		{
			return this.JLBBIOPPDPK();
		}

		// Token: 0x060128CB RID: 75979 RVA: 0x00814EF8 File Offset: 0x008130F8
		public void BHNOECIDFJA()
		{
			long dccpcblodig = this.LDHDCODNNJO();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(48, -152);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredLong.IBGFABOCLGB(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060128CC RID: 75980 RVA: 0x00813D77 File Offset: 0x00811F77
		public static void JFAFOEMPEDA(long JODDIMFACHN)
		{
			ObscuredLong.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060128CD RID: 75981 RVA: 0x00814F3C File Offset: 0x0081313C
		public string IHKJGKNNIHA(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.FMPCPHMDCIE().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x0400261B RID: 9755
		private static long cryptoKey = 444442L;

		// Token: 0x0400261C RID: 9756
		[SerializeField]
		private long currentCryptoKey;

		// Token: 0x0400261D RID: 9757
		[SerializeField]
		private long hiddenValue;

		// Token: 0x0400261E RID: 9758
		[SerializeField]
		private bool inited;

		// Token: 0x0400261F RID: 9759
		[SerializeField]
		private long fakeValue;

		// Token: 0x04002620 RID: 9760
		[SerializeField]
		private bool fakeValueActive;
	}
}
