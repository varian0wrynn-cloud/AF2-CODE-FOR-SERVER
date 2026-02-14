using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x0200057E RID: 1406
	[Serializable]
	public struct ObscuredDecimal : IEquatable<ObscuredDecimal>, IFormattable
	{
		// Token: 0x06012671 RID: 75377 RVA: 0x0080F57C File Offset: 0x0080D77C
		public int ENBBIEOPHDA()
		{
			return this.FMICPGOCFJK().GetHashCode();
		}

		// Token: 0x06012672 RID: 75378 RVA: 0x0080F598 File Offset: 0x0080D798
		public string OBJBIEJJJFN(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012673 RID: 75379 RVA: 0x0080F5B4 File Offset: 0x0080D7B4
		public decimal KMMLGECJBFD()
		{
			this.LLJFJNHIALN();
			return new ObscuredDecimal.HNAOGDNDOII
			{
				LPBJJAHHPID = this.hiddenValue
			}.MBFGBDLOKFH;
		}

		// Token: 0x06012674 RID: 75380 RVA: 0x0080F5E4 File Offset: 0x0080D7E4
		public static decimal NHGNDCDDNNA(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= JMBKDINHDLO;
			hnaogdndoii.BIEDNGFEFLF ^= JMBKDINHDLO;
			return hnaogdndoii.MBFGBDLOKFH;
		}

		// Token: 0x06012675 RID: 75381 RVA: 0x0080F628 File Offset: 0x0080D828
		public void FGMFFMHJEGN()
		{
			decimal dccpcblodig = this.GKJFJFAHKPP();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(154, -53);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredDecimal.AFGMNANHHBF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012676 RID: 75382 RVA: 0x0080F66C File Offset: 0x0080D86C
		public void LLJFJNHIALN()
		{
			if (this.currentCryptoKey != ObscuredDecimal.cryptoKey)
			{
				this.hiddenValue = ObscuredDecimal.PGAJANDFPEC(this.NPEAKEPHMOP(), ObscuredDecimal.cryptoKey);
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
			}
		}

		// Token: 0x06012677 RID: 75383 RVA: 0x0080F69C File Offset: 0x0080D89C
		public static ObscuredDecimal BODABEHCPKJ(ObscuredFloat CCAIMGAFFLD)
		{
			return ObscuredDecimal.GOOIABGKMHK((decimal)ObscuredFloat.EJGOOFALNFF(CCAIMGAFFLD));
		}

		// Token: 0x06012678 RID: 75384 RVA: 0x0080F6AF File Offset: 0x0080D8AF
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredDecimal && this.Equals((ObscuredDecimal)MBKPMBPLIJN);
		}

		// Token: 0x06012679 RID: 75385 RVA: 0x0080F6C8 File Offset: 0x0080D8C8
		private decimal BBGCBDGLKOB()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
				this.hiddenValue = ObscuredDecimal.CKPKMPIBOJA(0m);
				this.fakeValue = 0m;
				this.fakeValueActive = true;
				this.inited = true;
				return 0m;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.LPBJJAHHPID = this.hiddenValue;
			hnaogdndoii.AKCACDDMIBD ^= this.currentCryptoKey;
			hnaogdndoii.BIEDNGFEFLF ^= this.currentCryptoKey;
			decimal mbfgbdlokfh = hnaogdndoii.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.LHMMLFNJOMC() && this.fakeValueActive && mbfgbdlokfh != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x0601267A RID: 75386 RVA: 0x0080F784 File Offset: 0x0080D984
		public bool BJFOHGGCKNP(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredDecimal) || this.IDCDECCMLBM((ObscuredDecimal)MBKPMBPLIJN);
		}

		// Token: 0x0601267B RID: 75387 RVA: 0x0080F79C File Offset: 0x0080D99C
		public bool JIABCMEOFOO(ObscuredDecimal MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.OEFPBHKKPPO().Equals(this.NPEAKEPHMOP());
		}

		// Token: 0x0601267C RID: 75388 RVA: 0x0080F7BE File Offset: 0x0080D9BE
		public static decimal IOOANIMFEBK(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.HBJHGHOKFDK(DCCPCBLODIG, ObscuredDecimal.cryptoKey);
		}

		// Token: 0x0601267D RID: 75389 RVA: 0x0080F7CC File Offset: 0x0080D9CC
		public static decimal MBGNCIMGFEB(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= JMBKDINHDLO;
			hnaogdndoii.BIEDNGFEFLF ^= JMBKDINHDLO;
			return hnaogdndoii.MBFGBDLOKFH;
		}

		// Token: 0x0601267E RID: 75390 RVA: 0x0080F810 File Offset: 0x0080DA10
		public static decimal MPHCOFBOKOO(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= JMBKDINHDLO;
			hnaogdndoii.BIEDNGFEFLF ^= JMBKDINHDLO;
			return hnaogdndoii.MBFGBDLOKFH;
		}

		// Token: 0x0601267F RID: 75391 RVA: 0x0080F854 File Offset: 0x0080DA54
		public string DJDAGAEMEDD(string LJCEDKCLBDB)
		{
			return this.GKJFJFAHKPP().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012680 RID: 75392 RVA: 0x0080F870 File Offset: 0x0080DA70
		public string HFPKDKJOEKA()
		{
			return this.NNDDLHNEONC().ToString();
		}

		// Token: 0x06012681 RID: 75393 RVA: 0x0080F88C File Offset: 0x0080DA8C
		public string HLHHDFFDHGL(IFormatProvider MCGFPOIAPGJ)
		{
			return this.KJBLLHBIHIL().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012682 RID: 75394 RVA: 0x0080F8A8 File Offset: 0x0080DAA8
		public static decimal LCHCLCDEPFA(ObscuredDecimal DCCPCBLODIG)
		{
			return DCCPCBLODIG.NPEAKEPHMOP();
		}

		// Token: 0x06012683 RID: 75395 RVA: 0x0080F8B4 File Offset: 0x0080DAB4
		public int IIBJGHKJPEK()
		{
			return this.FMICPGOCFJK().GetHashCode();
		}

		// Token: 0x06012684 RID: 75396 RVA: 0x0080F8D0 File Offset: 0x0080DAD0
		public int KPFDJBCDMLC()
		{
			return this.NNDDLHNEONC().GetHashCode();
		}

		// Token: 0x06012685 RID: 75397 RVA: 0x0080F8EC File Offset: 0x0080DAEC
		public int HGAGKGFEEPG()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012686 RID: 75398 RVA: 0x0080F908 File Offset: 0x0080DB08
		public string JODMFMFAOEG()
		{
			return this.NNDDLHNEONC().ToString();
		}

		// Token: 0x06012687 RID: 75399 RVA: 0x0080F924 File Offset: 0x0080DB24
		public decimal BILJGBOFJMK()
		{
			this.GKJPOEBLLPN();
			return new ObscuredDecimal.HNAOGDNDOII
			{
				LPBJJAHHPID = this.hiddenValue
			}.MBFGBDLOKFH;
		}

		// Token: 0x06012688 RID: 75400 RVA: 0x0080F954 File Offset: 0x0080DB54
		private decimal OEFPBHKKPPO()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
				this.hiddenValue = ObscuredDecimal.MJEDONGEPJM(0m);
				this.fakeValue = 0m;
				this.fakeValueActive = false;
				this.inited = true;
				return 0m;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.LPBJJAHHPID = this.hiddenValue;
			hnaogdndoii.AKCACDDMIBD ^= this.currentCryptoKey;
			hnaogdndoii.BIEDNGFEFLF ^= this.currentCryptoKey;
			decimal mbfgbdlokfh = hnaogdndoii.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && mbfgbdlokfh != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x06012689 RID: 75401 RVA: 0x0080FA10 File Offset: 0x0080DC10
		public string LCDALFMOKBH()
		{
			return this.BBGCBDGLKOB().ToString();
		}

		// Token: 0x0601268B RID: 75403 RVA: 0x0080FA38 File Offset: 0x0080DC38
		public decimal FIOLOOIKBMM()
		{
			return this.NPEAKEPHMOP();
		}

		// Token: 0x0601268C RID: 75404 RVA: 0x0080FA40 File Offset: 0x0080DC40
		public void FKPBCEAEAGD()
		{
			decimal dccpcblodig = this.GKJFJFAHKPP();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(60, -39);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredDecimal.AFGMNANHHBF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601268D RID: 75405 RVA: 0x0080FA84 File Offset: 0x0080DC84
		public string IGPNJMFIDOD(string LJCEDKCLBDB)
		{
			return this.NPEAKEPHMOP().ToString(LJCEDKCLBDB);
		}

		// Token: 0x0601268E RID: 75406 RVA: 0x0080FAA0 File Offset: 0x0080DCA0
		public void HHGBMEJFDOC(decimal LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = new ObscuredDecimal.HNAOGDNDOII
			{
				MBFGBDLOKFH = LDKMOLEEDIL
			}.LPBJJAHHPID;
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
			{
				this.fakeValue = this.NPEAKEPHMOP();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x0601268F RID: 75407 RVA: 0x0080FAF2 File Offset: 0x0080DCF2
		private static ACTkByte16 AFGMNANHHBF(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.AFGMNANHHBF(DCCPCBLODIG, 0L);
		}

		// Token: 0x06012690 RID: 75408 RVA: 0x0080FA38 File Offset: 0x0080DC38
		public decimal MGJLOCLPDHM()
		{
			return this.NPEAKEPHMOP();
		}

		// Token: 0x06012691 RID: 75409 RVA: 0x0080FAFC File Offset: 0x0080DCFC
		public static void BBOGAEMNJJN(long JODDIMFACHN)
		{
			ObscuredDecimal.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012692 RID: 75410 RVA: 0x0080FB04 File Offset: 0x0080DD04
		public static ObscuredDecimal AJMPAOCEPCA(decimal DCCPCBLODIG)
		{
			return new ObscuredDecimal(DCCPCBLODIG);
		}

		// Token: 0x06012693 RID: 75411 RVA: 0x0080FB0C File Offset: 0x0080DD0C
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012694 RID: 75412 RVA: 0x0080FB28 File Offset: 0x0080DD28
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012695 RID: 75413 RVA: 0x0080FB44 File Offset: 0x0080DD44
		public void OJFAJIJBEFD()
		{
			decimal dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredDecimal.AFGMNANHHBF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012696 RID: 75414 RVA: 0x0080FB88 File Offset: 0x0080DD88
		public string JKLONALOFEM(IFormatProvider MCGFPOIAPGJ)
		{
			return this.IAAKMGOKLCK().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012697 RID: 75415 RVA: 0x0080FBA4 File Offset: 0x0080DDA4
		private static ACTkByte16 CBIMDMOEDCD(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			long num = JMBKDINHDLO;
			if (num == 0L)
			{
				num = ObscuredDecimal.cryptoKey;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= num;
			hnaogdndoii.BIEDNGFEFLF ^= num;
			return hnaogdndoii.LPBJJAHHPID;
		}

		// Token: 0x06012698 RID: 75416 RVA: 0x0080F7BE File Offset: 0x0080D9BE
		public static decimal ALHMMAGENAF(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.HBJHGHOKFDK(DCCPCBLODIG, ObscuredDecimal.cryptoKey);
		}

		// Token: 0x06012699 RID: 75417 RVA: 0x0080FBF0 File Offset: 0x0080DDF0
		private static ACTkByte16 IFFLBIJEEME(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			long num = JMBKDINHDLO;
			if (num == 0L)
			{
				num = ObscuredDecimal.cryptoKey;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= num;
			hnaogdndoii.BIEDNGFEFLF ^= num;
			return hnaogdndoii.LPBJJAHHPID;
		}

		// Token: 0x0601269A RID: 75418 RVA: 0x0080FC3C File Offset: 0x0080DE3C
		private static ACTkByte16 GAIJJIENIMF(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.PGAJANDFPEC(DCCPCBLODIG, 0L);
		}

		// Token: 0x0601269B RID: 75419 RVA: 0x0080FC46 File Offset: 0x0080DE46
		public static ObscuredDecimal BPPBBDJFBJG(ObscuredFloat CCAIMGAFFLD)
		{
			return ObscuredDecimal.AJMPAOCEPCA((decimal)ObscuredFloat.OBJFODGFMAM(CCAIMGAFFLD));
		}

		// Token: 0x0601269C RID: 75420 RVA: 0x0080FC5C File Offset: 0x0080DE5C
		public decimal HABNANPELIH()
		{
			this.CBPHNDAFGOG();
			return new ObscuredDecimal.HNAOGDNDOII
			{
				LPBJJAHHPID = this.hiddenValue
			}.MBFGBDLOKFH;
		}

		// Token: 0x0601269D RID: 75421 RVA: 0x0080FC8C File Offset: 0x0080DE8C
		private decimal FMICPGOCFJK()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
				this.hiddenValue = ObscuredDecimal.GAIJJIENIMF(0m);
				this.fakeValue = 0m;
				this.fakeValueActive = false;
				this.inited = false;
				return 0m;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.LPBJJAHHPID = this.hiddenValue;
			hnaogdndoii.AKCACDDMIBD ^= this.currentCryptoKey;
			hnaogdndoii.BIEDNGFEFLF ^= this.currentCryptoKey;
			decimal mbfgbdlokfh = hnaogdndoii.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && mbfgbdlokfh != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x0601269E RID: 75422 RVA: 0x0080FD48 File Offset: 0x0080DF48
		public int CKAMLLMKDFM()
		{
			return this.IAAKMGOKLCK().GetHashCode();
		}

		// Token: 0x0601269F RID: 75423 RVA: 0x0080FD64 File Offset: 0x0080DF64
		public string NKFOGFFPKFN()
		{
			return this.OEFPBHKKPPO().ToString();
		}

		// Token: 0x060126A0 RID: 75424 RVA: 0x0080FD80 File Offset: 0x0080DF80
		public bool Equals(ObscuredDecimal MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.MJFIFINDLAM().Equals(this.MJFIFINDLAM());
		}

		// Token: 0x060126A1 RID: 75425 RVA: 0x0080FDA4 File Offset: 0x0080DFA4
		public static ObscuredDecimal KOIPMGGIDJE(ObscuredDecimal NFKFMIIAKFN)
		{
			decimal dccpcblodig = NFKFMIIAKFN.NNDDLHNEONC() + 1m;
			NFKFMIIAKFN.hiddenValue = ObscuredDecimal.PGAJANDFPEC(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060126A2 RID: 75426 RVA: 0x0080FDF8 File Offset: 0x0080DFF8
		public void GGHPGBJFIFF(decimal LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = new ObscuredDecimal.HNAOGDNDOII
			{
				MBFGBDLOKFH = LDKMOLEEDIL
			}.LPBJJAHHPID;
			if (ObscuredCheatingDetector.IHLFNHKJJGN())
			{
				this.fakeValue = this.NNDDLHNEONC();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x060126A3 RID: 75427 RVA: 0x0080FE4A File Offset: 0x0080E04A
		public void GKJPOEBLLPN()
		{
			if (this.currentCryptoKey != ObscuredDecimal.cryptoKey)
			{
				this.hiddenValue = ObscuredDecimal.CBIMDMOEDCD(this.NPEAKEPHMOP(), ObscuredDecimal.cryptoKey);
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
			}
		}

		// Token: 0x060126A4 RID: 75428 RVA: 0x0080FE7A File Offset: 0x0080E07A
		public decimal LGHGCNLKGHJ()
		{
			return this.NNDDLHNEONC();
		}

		// Token: 0x060126A5 RID: 75429 RVA: 0x0080FE84 File Offset: 0x0080E084
		public void LABEACCDKMD(decimal LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = new ObscuredDecimal.HNAOGDNDOII
			{
				MBFGBDLOKFH = LDKMOLEEDIL
			}.LPBJJAHHPID;
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x060126A6 RID: 75430 RVA: 0x0080FED8 File Offset: 0x0080E0D8
		public static decimal IJEGDPCOKOE(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= JMBKDINHDLO;
			hnaogdndoii.BIEDNGFEFLF ^= JMBKDINHDLO;
			return hnaogdndoii.MBFGBDLOKFH;
		}

		// Token: 0x060126A7 RID: 75431 RVA: 0x0080FF1C File Offset: 0x0080E11C
		public string CGGKJFBHOMJ()
		{
			return this.KJBLLHBIHIL().ToString();
		}

		// Token: 0x060126A8 RID: 75432 RVA: 0x0080FF38 File Offset: 0x0080E138
		private static ACTkByte16 PGAJANDFPEC(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			long num = JMBKDINHDLO;
			if (num == 0L)
			{
				num = ObscuredDecimal.cryptoKey;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= num;
			hnaogdndoii.BIEDNGFEFLF ^= num;
			return hnaogdndoii.LPBJJAHHPID;
		}

		// Token: 0x060126A9 RID: 75433 RVA: 0x0080FF84 File Offset: 0x0080E184
		public decimal DBDBBGDOJHM()
		{
			this.OBNKLDAHPNN();
			return new ObscuredDecimal.HNAOGDNDOII
			{
				LPBJJAHHPID = this.hiddenValue
			}.MBFGBDLOKFH;
		}

		// Token: 0x060126AA RID: 75434 RVA: 0x0080FFB2 File Offset: 0x0080E1B2
		public static decimal LNNHMBONIGJ(ObscuredDecimal DCCPCBLODIG)
		{
			return DCCPCBLODIG.IAAKMGOKLCK();
		}

		// Token: 0x060126AB RID: 75435 RVA: 0x0080FFBB File Offset: 0x0080E1BB
		public decimal ENBLIBCIPPI()
		{
			return this.KJBLLHBIHIL();
		}

		// Token: 0x060126AC RID: 75436 RVA: 0x0080FFC4 File Offset: 0x0080E1C4
		private decimal MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
				this.hiddenValue = ObscuredDecimal.AFGMNANHHBF(0m);
				this.fakeValue = 0m;
				this.fakeValueActive = false;
				this.inited = true;
				return 0m;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.LPBJJAHHPID = this.hiddenValue;
			hnaogdndoii.AKCACDDMIBD ^= this.currentCryptoKey;
			hnaogdndoii.BIEDNGFEFLF ^= this.currentCryptoKey;
			decimal mbfgbdlokfh = hnaogdndoii.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && mbfgbdlokfh != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x060126AD RID: 75437 RVA: 0x00810080 File Offset: 0x0080E280
		public string DIACBNHNDCJ(string LJCEDKCLBDB)
		{
			return this.NPEAKEPHMOP().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060126AE RID: 75438 RVA: 0x0081009C File Offset: 0x0080E29C
		private decimal NNDDLHNEONC()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
				this.hiddenValue = ObscuredDecimal.MJEDONGEPJM(0m);
				this.fakeValue = 0m;
				this.fakeValueActive = true;
				this.inited = true;
				return 0m;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.LPBJJAHHPID = this.hiddenValue;
			hnaogdndoii.AKCACDDMIBD ^= this.currentCryptoKey;
			hnaogdndoii.BIEDNGFEFLF ^= this.currentCryptoKey;
			decimal mbfgbdlokfh = hnaogdndoii.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && mbfgbdlokfh != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x060126AF RID: 75439 RVA: 0x00810158 File Offset: 0x0080E358
		public decimal BBALKHNBGHL()
		{
			this.GKJPOEBLLPN();
			return new ObscuredDecimal.HNAOGDNDOII
			{
				LPBJJAHHPID = this.hiddenValue
			}.MBFGBDLOKFH;
		}

		// Token: 0x060126B0 RID: 75440 RVA: 0x0080FFBB File Offset: 0x0080E1BB
		public decimal ABPAAKDIHNB()
		{
			return this.KJBLLHBIHIL();
		}

		// Token: 0x060126B1 RID: 75441 RVA: 0x0080FAFC File Offset: 0x0080DCFC
		public static void FAKKFCMLDGI(long JODDIMFACHN)
		{
			ObscuredDecimal.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060126B2 RID: 75442 RVA: 0x00810186 File Offset: 0x0080E386
		private static ACTkByte16 MJEDONGEPJM(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.IFFLBIJEEME(DCCPCBLODIG, 1L);
		}

		// Token: 0x060126B3 RID: 75443 RVA: 0x00810190 File Offset: 0x0080E390
		public static decimal GAABDMDGPMF(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= JMBKDINHDLO;
			hnaogdndoii.BIEDNGFEFLF ^= JMBKDINHDLO;
			return hnaogdndoii.MBFGBDLOKFH;
		}

		// Token: 0x060126B4 RID: 75444 RVA: 0x008101D4 File Offset: 0x0080E3D4
		public static ObscuredDecimal PMHAAGMDJLB(ObscuredDecimal NFKFMIIAKFN)
		{
			decimal dccpcblodig = NFKFMIIAKFN.FMICPGOCFJK() - 1m;
			NFKFMIIAKFN.hiddenValue = ObscuredDecimal.PGAJANDFPEC(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060126B5 RID: 75445 RVA: 0x00810228 File Offset: 0x0080E428
		public void KGGKJJEADKO(decimal LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = new ObscuredDecimal.HNAOGDNDOII
			{
				MBFGBDLOKFH = LDKMOLEEDIL
			}.LPBJJAHHPID;
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x060126B6 RID: 75446 RVA: 0x0081027A File Offset: 0x0080E47A
		public bool LNGNHLLMFHN(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredDecimal) || this.EBFMGEOEHBH((ObscuredDecimal)MBKPMBPLIJN);
		}

		// Token: 0x060126B7 RID: 75447 RVA: 0x00810292 File Offset: 0x0080E492
		public void OBNKLDAHPNN()
		{
			if (this.currentCryptoKey != ObscuredDecimal.cryptoKey)
			{
				this.hiddenValue = ObscuredDecimal.IFFLBIJEEME(this.OEFPBHKKPPO(), ObscuredDecimal.cryptoKey);
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
			}
		}

		// Token: 0x060126B8 RID: 75448 RVA: 0x008102C4 File Offset: 0x0080E4C4
		public static decimal GGPGJEHDJHK(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= JMBKDINHDLO;
			hnaogdndoii.BIEDNGFEFLF ^= JMBKDINHDLO;
			return hnaogdndoii.MBFGBDLOKFH;
		}

		// Token: 0x060126B9 RID: 75449 RVA: 0x00810305 File Offset: 0x0080E505
		public void CBPHNDAFGOG()
		{
			if (this.currentCryptoKey != ObscuredDecimal.cryptoKey)
			{
				this.hiddenValue = ObscuredDecimal.IFFLBIJEEME(this.FMICPGOCFJK(), ObscuredDecimal.cryptoKey);
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
			}
		}

		// Token: 0x060126BA RID: 75450 RVA: 0x00810338 File Offset: 0x0080E538
		public bool ICANHIGGPAL(ObscuredDecimal MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.NPEAKEPHMOP().Equals(this.NNDDLHNEONC());
		}

		// Token: 0x060126BB RID: 75451 RVA: 0x0081035C File Offset: 0x0080E55C
		public decimal DPMAKCOLPNI()
		{
			this.GKJPOEBLLPN();
			return new ObscuredDecimal.HNAOGDNDOII
			{
				LPBJJAHHPID = this.hiddenValue
			}.MBFGBDLOKFH;
		}

		// Token: 0x060126BC RID: 75452 RVA: 0x0081038C File Offset: 0x0080E58C
		public string DIPEOLHEMHK(IFormatProvider MCGFPOIAPGJ)
		{
			return this.GKJFJFAHKPP().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060126BD RID: 75453 RVA: 0x0080FC46 File Offset: 0x0080DE46
		public static ObscuredDecimal PEKJMDBNJDD(ObscuredFloat CCAIMGAFFLD)
		{
			return ObscuredDecimal.AJMPAOCEPCA((decimal)ObscuredFloat.OBJFODGFMAM(CCAIMGAFFLD));
		}

		// Token: 0x060126BE RID: 75454 RVA: 0x008103A8 File Offset: 0x0080E5A8
		public int CBDCAGHMDLG()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x060126BF RID: 75455 RVA: 0x008103C4 File Offset: 0x0080E5C4
		public decimal LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return new ObscuredDecimal.HNAOGDNDOII
			{
				LPBJJAHHPID = this.hiddenValue
			}.MBFGBDLOKFH;
		}

		// Token: 0x060126C0 RID: 75456 RVA: 0x008103F4 File Offset: 0x0080E5F4
		public static ObscuredDecimal JKLEFDHDGHG(ObscuredDecimal NFKFMIIAKFN)
		{
			decimal dccpcblodig = NFKFMIIAKFN.OEFPBHKKPPO() - 1m;
			NFKFMIIAKFN.hiddenValue = ObscuredDecimal.PGAJANDFPEC(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060126C1 RID: 75457 RVA: 0x00810448 File Offset: 0x0080E648
		public string CJMFHLIBCBM(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.OEFPBHKKPPO().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x060126C2 RID: 75458 RVA: 0x0080F7BE File Offset: 0x0080D9BE
		public static decimal HBJHGHOKFDK(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.HBJHGHOKFDK(DCCPCBLODIG, ObscuredDecimal.cryptoKey);
		}

		// Token: 0x060126C3 RID: 75459 RVA: 0x00810465 File Offset: 0x0080E665
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredDecimal.cryptoKey)
			{
				this.hiddenValue = ObscuredDecimal.AFGMNANHHBF(this.MJFIFINDLAM(), ObscuredDecimal.cryptoKey);
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
			}
		}

		// Token: 0x060126C4 RID: 75460 RVA: 0x0080FB04 File Offset: 0x0080DD04
		public static ObscuredDecimal GOOIABGKMHK(decimal DCCPCBLODIG)
		{
			return new ObscuredDecimal(DCCPCBLODIG);
		}

		// Token: 0x060126C5 RID: 75461 RVA: 0x0080F6AF File Offset: 0x0080D8AF
		public bool MLLNAFJFLDL(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredDecimal && this.Equals((ObscuredDecimal)MBKPMBPLIJN);
		}

		// Token: 0x060126C6 RID: 75462 RVA: 0x00810498 File Offset: 0x0080E698
		public string ILGDLCDGECM(IFormatProvider MCGFPOIAPGJ)
		{
			return this.IAAKMGOKLCK().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060126C7 RID: 75463 RVA: 0x008104B4 File Offset: 0x0080E6B4
		public bool IDCDECCMLBM(ObscuredDecimal MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.IAAKMGOKLCK().Equals(this.OEFPBHKKPPO());
		}

		// Token: 0x060126C8 RID: 75464 RVA: 0x0080FAFC File Offset: 0x0080DCFC
		public static void LFFDKIFABOP(long JODDIMFACHN)
		{
			ObscuredDecimal.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060126C9 RID: 75465 RVA: 0x008104D8 File Offset: 0x0080E6D8
		public int ABHNCADFAFN()
		{
			return this.GKJFJFAHKPP().GetHashCode();
		}

		// Token: 0x060126CA RID: 75466 RVA: 0x008104F3 File Offset: 0x0080E6F3
		public static decimal BKHKBGFDFBG(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.DMOFGLGMJAP(DCCPCBLODIG, ObscuredDecimal.cryptoKey);
		}

		// Token: 0x060126CB RID: 75467 RVA: 0x00810500 File Offset: 0x0080E700
		public string ALAAOKOIJNG(string LJCEDKCLBDB)
		{
			return this.NPEAKEPHMOP().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060126CC RID: 75468 RVA: 0x0081051C File Offset: 0x0080E71C
		public static decimal DHPGAJEHAFD(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= JMBKDINHDLO;
			hnaogdndoii.BIEDNGFEFLF ^= JMBKDINHDLO;
			return hnaogdndoii.MBFGBDLOKFH;
		}

		// Token: 0x060126CD RID: 75469 RVA: 0x00810560 File Offset: 0x0080E760
		public static decimal DMOFGLGMJAP(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= JMBKDINHDLO;
			hnaogdndoii.BIEDNGFEFLF ^= JMBKDINHDLO;
			return hnaogdndoii.MBFGBDLOKFH;
		}

		// Token: 0x060126CE RID: 75470 RVA: 0x008105A4 File Offset: 0x0080E7A4
		public static ObscuredDecimal FFCOIFHNIPF(ObscuredDecimal NFKFMIIAKFN)
		{
			decimal dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1m;
			NFKFMIIAKFN.hiddenValue = ObscuredDecimal.PGAJANDFPEC(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060126CF RID: 75471 RVA: 0x008105F8 File Offset: 0x0080E7F8
		public static decimal CINIKOHABJJ(ObscuredDecimal DCCPCBLODIG)
		{
			return DCCPCBLODIG.GKJFJFAHKPP();
		}

		// Token: 0x060126D0 RID: 75472 RVA: 0x00810604 File Offset: 0x0080E804
		public static ObscuredDecimal DPCDNMHLOJF(ObscuredDecimal NFKFMIIAKFN)
		{
			decimal dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1m;
			NFKFMIIAKFN.hiddenValue = ObscuredDecimal.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060126D1 RID: 75473 RVA: 0x00810658 File Offset: 0x0080E858
		public bool EBFMGEOEHBH(ObscuredDecimal MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.NNDDLHNEONC().Equals(this.FMICPGOCFJK());
		}

		// Token: 0x060126D2 RID: 75474 RVA: 0x0081067C File Offset: 0x0080E87C
		private ObscuredDecimal(decimal DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredDecimal.cryptoKey;
			this.hiddenValue = ObscuredDecimal.AFGMNANHHBF(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : 0m);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x060126D3 RID: 75475 RVA: 0x008106C8 File Offset: 0x0080E8C8
		private decimal IAAKMGOKLCK()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
				this.hiddenValue = ObscuredDecimal.GAIJJIENIMF(0m);
				this.fakeValue = 0m;
				this.fakeValueActive = true;
				this.inited = false;
				return 0m;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.LPBJJAHHPID = this.hiddenValue;
			hnaogdndoii.AKCACDDMIBD ^= this.currentCryptoKey;
			hnaogdndoii.BIEDNGFEFLF ^= this.currentCryptoKey;
			decimal mbfgbdlokfh = hnaogdndoii.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && mbfgbdlokfh != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x060126D4 RID: 75476 RVA: 0x00810784 File Offset: 0x0080E984
		public int NJOMAGEKBOB()
		{
			return this.NNDDLHNEONC().GetHashCode();
		}

		// Token: 0x060126D5 RID: 75477 RVA: 0x008107A0 File Offset: 0x0080E9A0
		private decimal NPEAKEPHMOP()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
				this.hiddenValue = ObscuredDecimal.GAIJJIENIMF(0m);
				this.fakeValue = 0m;
				this.fakeValueActive = false;
				this.inited = false;
				return 0m;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.LPBJJAHHPID = this.hiddenValue;
			hnaogdndoii.AKCACDDMIBD ^= this.currentCryptoKey;
			hnaogdndoii.BIEDNGFEFLF ^= this.currentCryptoKey;
			decimal mbfgbdlokfh = hnaogdndoii.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && mbfgbdlokfh != this.fakeValue)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x060126D6 RID: 75478 RVA: 0x0081085C File Offset: 0x0080EA5C
		public static decimal GHDKGIJEILN(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.GGPGJEHDJHK(DCCPCBLODIG, ObscuredDecimal.cryptoKey);
		}

		// Token: 0x060126D7 RID: 75479 RVA: 0x0081086C File Offset: 0x0080EA6C
		public void EINJEBBMOMA(decimal LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = new ObscuredDecimal.HNAOGDNDOII
			{
				MBFGBDLOKFH = LDKMOLEEDIL
			}.LPBJJAHHPID;
			if (ObscuredCheatingDetector.LHMMLFNJOMC())
			{
				this.fakeValue = this.NNDDLHNEONC();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x060126D8 RID: 75480 RVA: 0x008108BE File Offset: 0x0080EABE
		public static decimal DHPGAJEHAFD(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.DHPGAJEHAFD(DCCPCBLODIG, ObscuredDecimal.cryptoKey);
		}

		// Token: 0x060126D9 RID: 75481 RVA: 0x008108CC File Offset: 0x0080EACC
		public decimal HBAACEMCMML()
		{
			this.LLJFJNHIALN();
			return new ObscuredDecimal.HNAOGDNDOII
			{
				LPBJJAHHPID = this.hiddenValue
			}.MBFGBDLOKFH;
		}

		// Token: 0x060126DA RID: 75482 RVA: 0x008108FA File Offset: 0x0080EAFA
		public static decimal APACCKHKCAG(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.NHGNDCDDNNA(DCCPCBLODIG, ObscuredDecimal.cryptoKey);
		}

		// Token: 0x060126DB RID: 75483 RVA: 0x00810907 File Offset: 0x0080EB07
		public static decimal AOLCDFJDHAF(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.MPHCOFBOKOO(DCCPCBLODIG, ObscuredDecimal.cryptoKey);
		}

		// Token: 0x060126DC RID: 75484 RVA: 0x00810914 File Offset: 0x0080EB14
		public decimal BELMEGMOKPJ()
		{
			return this.BBGCBDGLKOB();
		}

		// Token: 0x060126DD RID: 75485 RVA: 0x0081091C File Offset: 0x0080EB1C
		private static ACTkByte16 EGJNKJCFPDF(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.PGAJANDFPEC(DCCPCBLODIG, 1L);
		}

		// Token: 0x060126DE RID: 75486 RVA: 0x00810928 File Offset: 0x0080EB28
		private decimal GKJFJFAHKPP()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
				this.hiddenValue = ObscuredDecimal.EGJNKJCFPDF(0m);
				this.fakeValue = 0m;
				this.fakeValueActive = false;
				this.inited = false;
				return 0m;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.LPBJJAHHPID = this.hiddenValue;
			hnaogdndoii.AKCACDDMIBD ^= this.currentCryptoKey;
			hnaogdndoii.BIEDNGFEFLF ^= this.currentCryptoKey;
			decimal mbfgbdlokfh = hnaogdndoii.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && mbfgbdlokfh != this.fakeValue)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x060126DF RID: 75487 RVA: 0x008109E4 File Offset: 0x0080EBE4
		public decimal AAOGABMJDGO()
		{
			this.CBPHNDAFGOG();
			return new ObscuredDecimal.HNAOGDNDOII
			{
				LPBJJAHHPID = this.hiddenValue
			}.MBFGBDLOKFH;
		}

		// Token: 0x060126E0 RID: 75488 RVA: 0x00810A12 File Offset: 0x0080EC12
		public static decimal ICAODGOKEHE(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.PMNJNFBCAFA(DCCPCBLODIG, ObscuredDecimal.cryptoKey);
		}

		// Token: 0x060126E1 RID: 75489 RVA: 0x00810A1F File Offset: 0x0080EC1F
		private static ACTkByte16 NOFLKOCBPHI(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.CBIMDMOEDCD(DCCPCBLODIG, 0L);
		}

		// Token: 0x060126E2 RID: 75490 RVA: 0x00810A2C File Offset: 0x0080EC2C
		public static ObscuredDecimal IDGLMIEOHML(ObscuredDecimal NFKFMIIAKFN)
		{
			decimal dccpcblodig = NFKFMIIAKFN.NNDDLHNEONC() - 1m;
			NFKFMIIAKFN.hiddenValue = ObscuredDecimal.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060126E3 RID: 75491 RVA: 0x00810A80 File Offset: 0x0080EC80
		public string ToString(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x060126E4 RID: 75492 RVA: 0x00810AA0 File Offset: 0x0080ECA0
		public bool GAAMGONJOGE(ObscuredDecimal MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.IAAKMGOKLCK().Equals(this.GKJFJFAHKPP());
		}

		// Token: 0x060126E5 RID: 75493 RVA: 0x0080FAFC File Offset: 0x0080DCFC
		public static void DNGPGIOFIEH(long JODDIMFACHN)
		{
			ObscuredDecimal.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060126E6 RID: 75494 RVA: 0x0080FC3C File Offset: 0x0080DE3C
		private static ACTkByte16 CHOMPPLJONJ(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.PGAJANDFPEC(DCCPCBLODIG, 0L);
		}

		// Token: 0x060126E7 RID: 75495 RVA: 0x00810AC4 File Offset: 0x0080ECC4
		public static ObscuredDecimal MCLDFIIGCOC(ObscuredDecimal NFKFMIIAKFN)
		{
			decimal dccpcblodig = NFKFMIIAKFN.NNDDLHNEONC() + 1m;
			NFKFMIIAKFN.hiddenValue = ObscuredDecimal.CBIMDMOEDCD(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060126E8 RID: 75496 RVA: 0x0080FAFC File Offset: 0x0080DCFC
		public static void GCDHHJLAOAI(long JODDIMFACHN)
		{
			ObscuredDecimal.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x060126E9 RID: 75497 RVA: 0x00810B18 File Offset: 0x0080ED18
		public bool NMMLCKHECMA(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredDecimal && this.GAAMGONJOGE((ObscuredDecimal)MBKPMBPLIJN);
		}

		// Token: 0x060126EA RID: 75498 RVA: 0x00810B30 File Offset: 0x0080ED30
		public static decimal HBJHGHOKFDK(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= JMBKDINHDLO;
			hnaogdndoii.BIEDNGFEFLF ^= JMBKDINHDLO;
			return hnaogdndoii.MBFGBDLOKFH;
		}

		// Token: 0x060126EB RID: 75499 RVA: 0x00810B71 File Offset: 0x0080ED71
		public decimal FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x060126EC RID: 75500 RVA: 0x00810B79 File Offset: 0x0080ED79
		public static ObscuredDecimal LFKGEAFLLCN(ObscuredFloat CCAIMGAFFLD)
		{
			return ObscuredDecimal.GOOIABGKMHK((decimal)ObscuredFloat.GOOIABGKMHK(CCAIMGAFFLD));
		}

		// Token: 0x060126ED RID: 75501 RVA: 0x00810B8C File Offset: 0x0080ED8C
		public static ObscuredDecimal HIBLFIAPCJE(ObscuredDecimal NFKFMIIAKFN)
		{
			decimal dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1m;
			NFKFMIIAKFN.hiddenValue = ObscuredDecimal.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060126EE RID: 75502 RVA: 0x00810A12 File Offset: 0x0080EC12
		public static decimal CBMEEOOBKJB(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.PMNJNFBCAFA(DCCPCBLODIG, ObscuredDecimal.cryptoKey);
		}

		// Token: 0x060126EF RID: 75503 RVA: 0x00810BE0 File Offset: 0x0080EDE0
		public bool GINFGGPEFOG(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredDecimal) || this.ICANHIGGPAL((ObscuredDecimal)MBKPMBPLIJN);
		}

		// Token: 0x060126F0 RID: 75504 RVA: 0x00810BF8 File Offset: 0x0080EDF8
		private static ACTkByte16 AFGMNANHHBF(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			long num = JMBKDINHDLO;
			if (num == 0L)
			{
				num = ObscuredDecimal.cryptoKey;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= num;
			hnaogdndoii.BIEDNGFEFLF ^= num;
			return hnaogdndoii.LPBJJAHHPID;
		}

		// Token: 0x060126F1 RID: 75505 RVA: 0x0081091C File Offset: 0x0080EB1C
		private static ACTkByte16 CKPKMPIBOJA(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.PGAJANDFPEC(DCCPCBLODIG, 1L);
		}

		// Token: 0x060126F2 RID: 75506 RVA: 0x00810C44 File Offset: 0x0080EE44
		private static ACTkByte16 FIMMGEIABBM(decimal DCCPCBLODIG)
		{
			return ObscuredDecimal.AFGMNANHHBF(DCCPCBLODIG, 1L);
		}

		// Token: 0x060126F3 RID: 75507 RVA: 0x00810C50 File Offset: 0x0080EE50
		public string NEEHKIJGJKB(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.FMICPGOCFJK().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x060126F4 RID: 75508 RVA: 0x00810C70 File Offset: 0x0080EE70
		public static ObscuredDecimal MNOFODHNPHL(ObscuredDecimal NFKFMIIAKFN)
		{
			decimal dccpcblodig = NFKFMIIAKFN.NPEAKEPHMOP() - 1m;
			NFKFMIIAKFN.hiddenValue = ObscuredDecimal.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060126F5 RID: 75509 RVA: 0x00810CC4 File Offset: 0x0080EEC4
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060126F6 RID: 75510 RVA: 0x00810CE0 File Offset: 0x0080EEE0
		public static decimal OIFOOAPHPKI(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= JMBKDINHDLO;
			hnaogdndoii.BIEDNGFEFLF ^= JMBKDINHDLO;
			return hnaogdndoii.MBFGBDLOKFH;
		}

		// Token: 0x060126F7 RID: 75511 RVA: 0x00810D21 File Offset: 0x0080EF21
		public static decimal GOOIABGKMHK(ObscuredDecimal DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x060126F8 RID: 75512 RVA: 0x00810D2C File Offset: 0x0080EF2C
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x060126F9 RID: 75513 RVA: 0x00810D48 File Offset: 0x0080EF48
		private decimal KJBLLHBIHIL()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDecimal.cryptoKey;
				this.hiddenValue = ObscuredDecimal.EGJNKJCFPDF(0m);
				this.fakeValue = 0m;
				this.fakeValueActive = false;
				this.inited = true;
				return 0m;
			}
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.LPBJJAHHPID = this.hiddenValue;
			hnaogdndoii.AKCACDDMIBD ^= this.currentCryptoKey;
			hnaogdndoii.BIEDNGFEFLF ^= this.currentCryptoKey;
			decimal mbfgbdlokfh = hnaogdndoii.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && mbfgbdlokfh != this.fakeValue)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x060126FA RID: 75514 RVA: 0x0080FB04 File Offset: 0x0080DD04
		public static ObscuredDecimal KCNLJJFMBHG(decimal DCCPCBLODIG)
		{
			return new ObscuredDecimal(DCCPCBLODIG);
		}

		// Token: 0x060126FB RID: 75515 RVA: 0x00810E04 File Offset: 0x0080F004
		public static decimal PMNJNFBCAFA(decimal DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDecimal.HNAOGDNDOII hnaogdndoii = default(ObscuredDecimal.HNAOGDNDOII);
			hnaogdndoii.MBFGBDLOKFH = DCCPCBLODIG;
			hnaogdndoii.AKCACDDMIBD ^= JMBKDINHDLO;
			hnaogdndoii.BIEDNGFEFLF ^= JMBKDINHDLO;
			return hnaogdndoii.MBFGBDLOKFH;
		}

		// Token: 0x060126FC RID: 75516 RVA: 0x00810E48 File Offset: 0x0080F048
		public int NPAKFHHNGAF()
		{
			return this.KJBLLHBIHIL().GetHashCode();
		}

		// Token: 0x060126FD RID: 75517 RVA: 0x0080F6AF File Offset: 0x0080D8AF
		public bool CJCOEFNMNNI(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredDecimal && this.Equals((ObscuredDecimal)MBKPMBPLIJN);
		}

		// Token: 0x060126FE RID: 75518 RVA: 0x00810E64 File Offset: 0x0080F064
		public string DHCBHNAAJKI(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.OEFPBHKKPPO().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x040025F7 RID: 9719
		private static long cryptoKey = 209208L;

		// Token: 0x040025F8 RID: 9720
		private long currentCryptoKey;

		// Token: 0x040025F9 RID: 9721
		private ACTkByte16 hiddenValue;

		// Token: 0x040025FA RID: 9722
		private bool inited;

		// Token: 0x040025FB RID: 9723
		private decimal fakeValue;

		// Token: 0x040025FC RID: 9724
		private bool fakeValueActive;

		// Token: 0x0200057F RID: 1407
		[StructLayout(LayoutKind.Explicit)]
		private struct HNAOGDNDOII
		{
			// Token: 0x040025FD RID: 9725
			[FieldOffset(0)]
			public decimal MBFGBDLOKFH;

			// Token: 0x040025FE RID: 9726
			[FieldOffset(0)]
			public long AKCACDDMIBD;

			// Token: 0x040025FF RID: 9727
			[FieldOffset(8)]
			public long BIEDNGFEFLF;

			// Token: 0x04002600 RID: 9728
			[FieldOffset(0)]
			public ACTkByte16 LPBJJAHHPID;
		}
	}
}
