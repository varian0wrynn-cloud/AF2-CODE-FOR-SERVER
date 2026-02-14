using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200058C RID: 1420
	[Serializable]
	public struct ObscuredSByte : IEquatable<ObscuredSByte>, IFormattable
	{
		// Token: 0x060129EF RID: 76271 RVA: 0x00818D2B File Offset: 0x00816F2B
		public static sbyte EOLOGKBEGAC(sbyte DCCPCBLODIG, sbyte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredSByte.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060129F0 RID: 76272 RVA: 0x00818D3D File Offset: 0x00816F3D
		public sbyte LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x060129F1 RID: 76273 RVA: 0x00818D4C File Offset: 0x00816F4C
		public string GJCCJEINDDC(string LJCEDKCLBDB)
		{
			return this.GLIIBCLNIPD().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060129F2 RID: 76274 RVA: 0x00818D68 File Offset: 0x00816F68
		public void OJFAJIJBEFD()
		{
			sbyte dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (sbyte)UnityEngine.Random.Range(-128, 127);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredSByte.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060129F3 RID: 76275 RVA: 0x00818D3D File Offset: 0x00816F3D
		public sbyte BPCAFCNMMOK()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x060129F4 RID: 76276 RVA: 0x00818DA8 File Offset: 0x00816FA8
		public static ObscuredSByte MMFHEGALOCL(ObscuredSByte NFKFMIIAKFN)
		{
			sbyte dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 0;
			NFKFMIIAKFN.hiddenValue = ObscuredSByte.AIGJJNLGFAO(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060129F5 RID: 76277 RVA: 0x00818DF8 File Offset: 0x00816FF8
		public void PEOJJBLHOEN()
		{
			sbyte dccpcblodig = this.PGEAMCEJGGJ();
			do
			{
				this.currentCryptoKey = (sbyte)UnityEngine.Random.Range(-4, 92);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredSByte.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x060129F6 RID: 76278 RVA: 0x00818E36 File Offset: 0x00817036
		public static sbyte MFKAFAHBCEM(sbyte DCCPCBLODIG)
		{
			return ObscuredSByte.KOJLJMMMJGP(DCCPCBLODIG, 0);
		}

		// Token: 0x060129F7 RID: 76279 RVA: 0x00818E40 File Offset: 0x00817040
		public bool ICKBIMPCKAB(ObscuredSByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredSByte.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredSByte.EOLOGKBEGAC(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x060129F8 RID: 76280 RVA: 0x00818E8E File Offset: 0x0081708E
		public void DGLEMFLBBBB(sbyte LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.GLIIBCLNIPD();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x060129F9 RID: 76281 RVA: 0x00818EC0 File Offset: 0x008170C0
		public string MFPEPELOHBL()
		{
			return this.GLIIBCLNIPD().ToString();
		}

		// Token: 0x060129FA RID: 76282 RVA: 0x00818EDC File Offset: 0x008170DC
		public string DINGGHOCDNN(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.PGEAMCEJGGJ().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x060129FB RID: 76283 RVA: 0x00818EF9 File Offset: 0x008170F9
		public sbyte BEBBOOGPCGL()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x060129FC RID: 76284 RVA: 0x00818F04 File Offset: 0x00817104
		public string BJALMHGGAFM()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x060129FD RID: 76285 RVA: 0x00818F1F File Offset: 0x0081711F
		public static sbyte JLGFEMKEHJN(sbyte DCCPCBLODIG)
		{
			return ObscuredSByte.AIGJJNLGFAO(DCCPCBLODIG, 0);
		}

		// Token: 0x060129FE RID: 76286 RVA: 0x00818F28 File Offset: 0x00817128
		public static ObscuredSByte LDIELCLANJE(ObscuredSByte NFKFMIIAKFN)
		{
			sbyte dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 0;
			NFKFMIIAKFN.hiddenValue = ObscuredSByte.EOLOGKBEGAC(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060129FF RID: 76287 RVA: 0x00818F75 File Offset: 0x00817175
		public static void BBOGAEMNJJN(sbyte JODDIMFACHN)
		{
			ObscuredSByte.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012A00 RID: 76288 RVA: 0x00818D2B File Offset: 0x00816F2B
		public static sbyte KOJLJMMMJGP(sbyte DCCPCBLODIG, sbyte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredSByte.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012A01 RID: 76289 RVA: 0x00818F80 File Offset: 0x00817180
		public void BMAHAKGPIAN()
		{
			sbyte dccpcblodig = this.GLIIBCLNIPD();
			do
			{
				this.currentCryptoKey = (sbyte)UnityEngine.Random.Range(-54, 40);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredSByte.KOJLJMMMJGP(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012A02 RID: 76290 RVA: 0x00818FBE File Offset: 0x008171BE
		public static sbyte LDAFLBOIKGG(sbyte DCCPCBLODIG)
		{
			return ObscuredSByte.KOJLJMMMJGP(DCCPCBLODIG, 1);
		}

		// Token: 0x06012A03 RID: 76291 RVA: 0x00818FC7 File Offset: 0x008171C7
		public static sbyte JNKANIEBCMD(ObscuredSByte DCCPCBLODIG)
		{
			return DCCPCBLODIG.PGEAMCEJGGJ();
		}

		// Token: 0x06012A04 RID: 76292 RVA: 0x00818FD0 File Offset: 0x008171D0
		public string ADOAJOFIPAM(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012A05 RID: 76293 RVA: 0x00818FED File Offset: 0x008171ED
		public void HJPNPILBJDI(sbyte LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.GLIIBCLNIPD();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012A06 RID: 76294 RVA: 0x0081901F File Offset: 0x0081721F
		public void JKFJGLDLMOF(sbyte LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012A07 RID: 76295 RVA: 0x00819051 File Offset: 0x00817251
		public sbyte CLFGHCNHMAM()
		{
			return this.GLIIBCLNIPD();
		}

		// Token: 0x06012A08 RID: 76296 RVA: 0x00819059 File Offset: 0x00817259
		public sbyte CNDKGPMFKPI()
		{
			return this.PGEAMCEJGGJ();
		}

		// Token: 0x06012A09 RID: 76297 RVA: 0x00819064 File Offset: 0x00817264
		private sbyte PGEAMCEJGGJ()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredSByte.cryptoKey;
				this.hiddenValue = ObscuredSByte.MFKAFAHBCEM(0);
				this.fakeValue = 1;
				this.fakeValueActive = false;
				this.inited = false;
				return 1;
			}
			sbyte b = ObscuredSByte.EOLOGKBEGAC(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && b != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return b;
		}

		// Token: 0x06012A0A RID: 76298 RVA: 0x008190DC File Offset: 0x008172DC
		public bool ODJGALICGLD(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredSByte && this.ICKBIMPCKAB((ObscuredSByte)MBKPMBPLIJN);
		}

		// Token: 0x06012A0B RID: 76299 RVA: 0x00818EF9 File Offset: 0x008170F9
		public sbyte BBNFOKCFHIA()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012A0C RID: 76300 RVA: 0x008190F4 File Offset: 0x008172F4
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012A0D RID: 76301 RVA: 0x00819110 File Offset: 0x00817310
		public static ObscuredSByte CELJOKBBJJG(ObscuredSByte NFKFMIIAKFN)
		{
			sbyte dccpcblodig = NFKFMIIAKFN.GLIIBCLNIPD() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredSByte.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012A0E RID: 76302 RVA: 0x00819160 File Offset: 0x00817360
		public static ObscuredSByte EGIEJOKKMGP(ObscuredSByte NFKFMIIAKFN)
		{
			sbyte dccpcblodig = NFKFMIIAKFN.PGEAMCEJGGJ() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredSByte.AIGJJNLGFAO(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012A0F RID: 76303 RVA: 0x008191B0 File Offset: 0x008173B0
		public string IHKJGKNNIHA(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012A10 RID: 76304 RVA: 0x008191CC File Offset: 0x008173CC
		public void LABEACCDKMD(sbyte LDKMOLEEDIL)
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

		// Token: 0x06012A11 RID: 76305 RVA: 0x00819200 File Offset: 0x00817400
		public static ObscuredSByte IDIADEICPFJ(ObscuredSByte NFKFMIIAKFN)
		{
			sbyte dccpcblodig = NFKFMIIAKFN.GLIIBCLNIPD() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredSByte.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012A12 RID: 76306 RVA: 0x0081924D File Offset: 0x0081744D
		public bool GINFGGPEFOG(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredSByte) || this.ICKBIMPCKAB((ObscuredSByte)MBKPMBPLIJN);
		}

		// Token: 0x06012A13 RID: 76307 RVA: 0x00819268 File Offset: 0x00817468
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012A14 RID: 76308 RVA: 0x00819283 File Offset: 0x00817483
		public static sbyte OADLNEPCDPK(ObscuredSByte DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012A15 RID: 76309 RVA: 0x00819283 File Offset: 0x00817483
		public static sbyte EJKAEEKCFGN(ObscuredSByte DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012A16 RID: 76310 RVA: 0x0081928C File Offset: 0x0081748C
		public string CEOAKEEKAMH()
		{
			return this.GLIIBCLNIPD().ToString();
		}

		// Token: 0x06012A17 RID: 76311 RVA: 0x00818D3D File Offset: 0x00816F3D
		public sbyte AAOGABMJDGO()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012A18 RID: 76312 RVA: 0x00818D2B File Offset: 0x00816F2B
		public static sbyte AIGJJNLGFAO(sbyte DCCPCBLODIG, sbyte JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredSByte.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012A19 RID: 76313 RVA: 0x008192A8 File Offset: 0x008174A8
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012A1A RID: 76314 RVA: 0x008192C4 File Offset: 0x008174C4
		private sbyte GLIIBCLNIPD()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredSByte.cryptoKey;
				this.hiddenValue = ObscuredSByte.MFKAFAHBCEM(0);
				this.fakeValue = 1;
				this.fakeValueActive = false;
				this.inited = true;
				return 1;
			}
			sbyte b = ObscuredSByte.AIGJJNLGFAO(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && b != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return b;
		}

		// Token: 0x06012A1B RID: 76315 RVA: 0x0081933C File Offset: 0x0081753C
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredSByte && this.Equals((ObscuredSByte)MBKPMBPLIJN);
		}

		// Token: 0x06012A1C RID: 76316 RVA: 0x00819354 File Offset: 0x00817554
		public string FPPLGDMIGKI(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012A1E RID: 76318 RVA: 0x00819379 File Offset: 0x00817579
		public static ObscuredSByte IBPCIBGOIBB(sbyte DCCPCBLODIG)
		{
			return new ObscuredSByte(DCCPCBLODIG);
		}

		// Token: 0x06012A1F RID: 76319 RVA: 0x00819051 File Offset: 0x00817251
		public sbyte PCFMCFFHEEO()
		{
			return this.GLIIBCLNIPD();
		}

		// Token: 0x06012A20 RID: 76320 RVA: 0x00819384 File Offset: 0x00817584
		public string HDPLEBMIHFA(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012A21 RID: 76321 RVA: 0x00819283 File Offset: 0x00817483
		public static sbyte GOOIABGKMHK(ObscuredSByte DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012A22 RID: 76322 RVA: 0x00819059 File Offset: 0x00817259
		public sbyte JNIKFPNOJBB()
		{
			return this.PGEAMCEJGGJ();
		}

		// Token: 0x06012A23 RID: 76323 RVA: 0x008193A0 File Offset: 0x008175A0
		public static ObscuredSByte HIBLFIAPCJE(ObscuredSByte NFKFMIIAKFN)
		{
			sbyte dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredSByte.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012A24 RID: 76324 RVA: 0x008193ED File Offset: 0x008175ED
		public static sbyte BCLJOMMFGEN(ObscuredSByte DCCPCBLODIG)
		{
			return DCCPCBLODIG.GLIIBCLNIPD();
		}

		// Token: 0x06012A25 RID: 76325 RVA: 0x008193F6 File Offset: 0x008175F6
		public bool MIOFJLDJHCA(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredSByte && this.CNKPPKOFCNH((ObscuredSByte)MBKPMBPLIJN);
		}

		// Token: 0x06012A26 RID: 76326 RVA: 0x00818E36 File Offset: 0x00817036
		public static sbyte KOJLJMMMJGP(sbyte DCCPCBLODIG)
		{
			return ObscuredSByte.KOJLJMMMJGP(DCCPCBLODIG, 0);
		}

		// Token: 0x06012A27 RID: 76327 RVA: 0x00819410 File Offset: 0x00817610
		public string ToString(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012A28 RID: 76328 RVA: 0x008193ED File Offset: 0x008175ED
		public static sbyte OJHPKFLMOLO(ObscuredSByte DCCPCBLODIG)
		{
			return DCCPCBLODIG.GLIIBCLNIPD();
		}

		// Token: 0x06012A29 RID: 76329 RVA: 0x00819430 File Offset: 0x00817630
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012A2A RID: 76330 RVA: 0x00818D3D File Offset: 0x00816F3D
		public sbyte PNNBEFMFEAF()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012A2B RID: 76331 RVA: 0x0081944C File Offset: 0x0081764C
		public string PBAJNDNHIFI()
		{
			return this.GLIIBCLNIPD().ToString();
		}

		// Token: 0x06012A2C RID: 76332 RVA: 0x00819379 File Offset: 0x00817579
		public static ObscuredSByte JJDNCFDJDMI(sbyte DCCPCBLODIG)
		{
			return new ObscuredSByte(DCCPCBLODIG);
		}

		// Token: 0x06012A2D RID: 76333 RVA: 0x00819468 File Offset: 0x00817668
		public static ObscuredSByte HBPINGNDEFF(ObscuredSByte NFKFMIIAKFN)
		{
			sbyte dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredSByte.AIGJJNLGFAO(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012A2E RID: 76334 RVA: 0x008194B5 File Offset: 0x008176B5
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredSByte.cryptoKey)
			{
				this.hiddenValue = ObscuredSByte.KOJLJMMMJGP(this.MJFIFINDLAM(), ObscuredSByte.cryptoKey);
				this.currentCryptoKey = ObscuredSByte.cryptoKey;
			}
		}

		// Token: 0x06012A2F RID: 76335 RVA: 0x00818D3D File Offset: 0x00816F3D
		public sbyte BHNJJGIMDLO()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012A30 RID: 76336 RVA: 0x008194E8 File Offset: 0x008176E8
		public string NIDKKALEJIM()
		{
			return this.GLIIBCLNIPD().ToString();
		}

		// Token: 0x06012A31 RID: 76337 RVA: 0x00819504 File Offset: 0x00817704
		private ObscuredSByte(sbyte DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredSByte.cryptoKey;
			this.hiddenValue = ObscuredSByte.KOJLJMMMJGP(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : 0);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x06012A32 RID: 76338 RVA: 0x00819379 File Offset: 0x00817579
		public static ObscuredSByte ALBBIEKFLJF(sbyte DCCPCBLODIG)
		{
			return new ObscuredSByte(DCCPCBLODIG);
		}

		// Token: 0x06012A33 RID: 76339 RVA: 0x0081933C File Offset: 0x0081753C
		public bool AKNGIFMHCKC(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredSByte && this.Equals((ObscuredSByte)MBKPMBPLIJN);
		}

		// Token: 0x06012A34 RID: 76340 RVA: 0x0081954C File Offset: 0x0081774C
		public void PMLOCOGKJMD()
		{
			sbyte dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (sbyte)UnityEngine.Random.Range(15, -124);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredSByte.AIGJJNLGFAO(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012A35 RID: 76341 RVA: 0x0081958C File Offset: 0x0081778C
		private sbyte MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredSByte.cryptoKey;
				this.hiddenValue = ObscuredSByte.KOJLJMMMJGP(0);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = true;
				return 0;
			}
			sbyte b = ObscuredSByte.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && b != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return b;
		}

		// Token: 0x06012A36 RID: 76342 RVA: 0x00819604 File Offset: 0x00817804
		public bool Equals(ObscuredSByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredSByte.KOJLJMMMJGP(this.hiddenValue, this.currentCryptoKey) == ObscuredSByte.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012A37 RID: 76343 RVA: 0x00819654 File Offset: 0x00817854
		public static ObscuredSByte DPCDNMHLOJF(ObscuredSByte NFKFMIIAKFN)
		{
			sbyte dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredSByte.KOJLJMMMJGP(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012A38 RID: 76344 RVA: 0x008196A4 File Offset: 0x008178A4
		public bool CNKPPKOFCNH(ObscuredSByte MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredSByte.AIGJJNLGFAO(this.hiddenValue, this.currentCryptoKey) == ObscuredSByte.KOJLJMMMJGP(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012A39 RID: 76345 RVA: 0x00818EF9 File Offset: 0x008170F9
		public sbyte FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012A3A RID: 76346 RVA: 0x00819379 File Offset: 0x00817579
		public static ObscuredSByte IPMKPELEKGK(sbyte DCCPCBLODIG)
		{
			return new ObscuredSByte(DCCPCBLODIG);
		}

		// Token: 0x06012A3B RID: 76347 RVA: 0x008196F2 File Offset: 0x008178F2
		public static sbyte OOOAGFBJMPD(sbyte DCCPCBLODIG)
		{
			return ObscuredSByte.AIGJJNLGFAO(DCCPCBLODIG, 1);
		}

		// Token: 0x06012A3C RID: 76348 RVA: 0x00819379 File Offset: 0x00817579
		public static ObscuredSByte GOOIABGKMHK(sbyte DCCPCBLODIG)
		{
			return new ObscuredSByte(DCCPCBLODIG);
		}

		// Token: 0x06012A3D RID: 76349 RVA: 0x00819051 File Offset: 0x00817251
		public sbyte JFIMLIODKOB()
		{
			return this.GLIIBCLNIPD();
		}

		// Token: 0x06012A3E RID: 76350 RVA: 0x008196FC File Offset: 0x008178FC
		public string JKGHGFFFGEH(string LJCEDKCLBDB)
		{
			return this.GLIIBCLNIPD().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012A3F RID: 76351 RVA: 0x00819718 File Offset: 0x00817918
		public string JCAONLDGMCJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.PGEAMCEJGGJ().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012A40 RID: 76352 RVA: 0x00819734 File Offset: 0x00817934
		public string FJGIAILHMIF(IFormatProvider MCGFPOIAPGJ)
		{
			return this.GLIIBCLNIPD().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012A41 RID: 76353 RVA: 0x00819750 File Offset: 0x00817950
		public void MKHMKJNPOFE()
		{
			sbyte dccpcblodig = this.PGEAMCEJGGJ();
			do
			{
				this.currentCryptoKey = (sbyte)UnityEngine.Random.Range(-8, 11);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredSByte.EOLOGKBEGAC(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x04002650 RID: 9808
		private static sbyte cryptoKey = 112;

		// Token: 0x04002651 RID: 9809
		private sbyte currentCryptoKey;

		// Token: 0x04002652 RID: 9810
		private sbyte hiddenValue;

		// Token: 0x04002653 RID: 9811
		private bool inited;

		// Token: 0x04002654 RID: 9812
		private sbyte fakeValue;

		// Token: 0x04002655 RID: 9813
		private bool fakeValueActive;
	}
}
