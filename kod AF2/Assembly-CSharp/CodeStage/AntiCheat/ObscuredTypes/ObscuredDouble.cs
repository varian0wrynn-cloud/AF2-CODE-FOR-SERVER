using System;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.Common;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;
using UnityEngine.Serialization;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000580 RID: 1408
	[Serializable]
	public struct ObscuredDouble : IEquatable<ObscuredDouble>, IFormattable
	{
		// Token: 0x060126FF RID: 75519 RVA: 0x00810E81 File Offset: 0x0080F081
		public double FOIPMIPDEBG()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012700 RID: 75520 RVA: 0x00810E89 File Offset: 0x0080F089
		public void MEHJNKMFHNO()
		{
			if (this.currentCryptoKey != ObscuredDouble.cryptoKey)
			{
				this.hiddenValue = ObscuredDouble.IADCLNKKCEL(this.PHNCMMLFIFO(), ObscuredDouble.cryptoKey);
				this.currentCryptoKey = ObscuredDouble.cryptoKey;
			}
		}

		// Token: 0x06012701 RID: 75521 RVA: 0x00810EBC File Offset: 0x0080F0BC
		public long LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return new ObscuredDouble.PCMLCFHDABC
			{
				JABFOOBMIFC = this.hiddenValue
			}.KLDOOIGDEDM;
		}

		// Token: 0x06012703 RID: 75523 RVA: 0x00810EF7 File Offset: 0x0080F0F7
		public static double AMMOJHNAPOF(ObscuredDouble DCCPCBLODIG)
		{
			return DCCPCBLODIG.IJKPGGBGAHM();
		}

		// Token: 0x06012704 RID: 75524 RVA: 0x00810F00 File Offset: 0x0080F100
		public static double GOOIABGKMHK(ObscuredDouble DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012705 RID: 75525 RVA: 0x00810F0C File Offset: 0x0080F10C
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012706 RID: 75526 RVA: 0x00810F28 File Offset: 0x0080F128
		public void ILPJJJDLOGP(long LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = new ObscuredDouble.PCMLCFHDABC
			{
				KLDOOIGDEDM = LDKMOLEEDIL
			}.JABFOOBMIFC;
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue = this.PHNCMMLFIFO();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012707 RID: 75527 RVA: 0x00810F7C File Offset: 0x0080F17C
		public bool Equals(ObscuredDouble MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.MJFIFINDLAM().Equals(this.MJFIFINDLAM());
		}

		// Token: 0x06012708 RID: 75528 RVA: 0x00810F00 File Offset: 0x0080F100
		public static double KKAKHLOGJOD(ObscuredDouble DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012709 RID: 75529 RVA: 0x00810F9E File Offset: 0x0080F19E
		public static double ECDCICLAPNI(long DCCPCBLODIG)
		{
			return ObscuredDouble.LIGOHGNKKIB(DCCPCBLODIG, ObscuredDouble.cryptoKey);
		}

		// Token: 0x0601270A RID: 75530 RVA: 0x00810FAC File Offset: 0x0080F1AC
		public void NEINBIKBPKH(long LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = new ObscuredDouble.PCMLCFHDABC
			{
				KLDOOIGDEDM = LDKMOLEEDIL
			}.JABFOOBMIFC;
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.IJKPGGBGAHM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x0601270B RID: 75531 RVA: 0x00811000 File Offset: 0x0080F200
		public void LNBLECJHDND(long LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = new ObscuredDouble.PCMLCFHDABC
			{
				KLDOOIGDEDM = LDKMOLEEDIL
			}.JABFOOBMIFC;
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				this.fakeValue = this.PHNCMMLFIFO();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x0601270C RID: 75532 RVA: 0x00811054 File Offset: 0x0080F254
		public void KLPHCBIFGAD(long LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = new ObscuredDouble.PCMLCFHDABC
			{
				KLDOOIGDEDM = LDKMOLEEDIL
			}.JABFOOBMIFC;
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				this.fakeValue = this.IJKPGGBGAHM();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x0601270D RID: 75533 RVA: 0x008110A6 File Offset: 0x0080F2A6
		public static long BEGDPMLFGOO(double DCCPCBLODIG)
		{
			return ObscuredDouble.NHGNDCDDNNA(DCCPCBLODIG, ObscuredDouble.cryptoKey);
		}

		// Token: 0x0601270E RID: 75534 RVA: 0x008110B4 File Offset: 0x0080F2B4
		public long FJPPIILEPDM()
		{
			this.MEHJNKMFHNO();
			return new ObscuredDouble.PCMLCFHDABC
			{
				JABFOOBMIFC = this.hiddenValue
			}.KLDOOIGDEDM;
		}

		// Token: 0x0601270F RID: 75535 RVA: 0x008110E4 File Offset: 0x0080F2E4
		public static ObscuredDouble AJFMKKJPPJG(ObscuredDouble NFKFMIIAKFN)
		{
			double dccpcblodig = NFKFMIIAKFN.IJKPGGBGAHM() - 1553.0;
			NFKFMIIAKFN.hiddenValue = ObscuredDouble.NLIPJNACNAD(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012710 RID: 75536 RVA: 0x00811138 File Offset: 0x0080F338
		public string DINGGHOCDNN(IFormatProvider MCGFPOIAPGJ)
		{
			return this.IJKPGGBGAHM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012711 RID: 75537 RVA: 0x00811154 File Offset: 0x0080F354
		public string KBHGJLAEMFH(IFormatProvider MCGFPOIAPGJ)
		{
			return this.PHNCMMLFIFO().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012712 RID: 75538 RVA: 0x00811170 File Offset: 0x0080F370
		private double IJKPGGBGAHM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDouble.cryptoKey;
				this.hiddenValue = ObscuredDouble.AFGMNANHHBF(513.0);
				this.fakeValue = 346.0;
				this.fakeValueActive = false;
				this.inited = true;
				return 134.0;
			}
			ObscuredDouble.PCMLCFHDABC pcmlcfhdabc = default(ObscuredDouble.PCMLCFHDABC);
			pcmlcfhdabc.JABFOOBMIFC = this.hiddenValue;
			pcmlcfhdabc.KLDOOIGDEDM ^= this.currentCryptoKey;
			double mbfgbdlokfh = pcmlcfhdabc.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && Math.Abs(mbfgbdlokfh - this.fakeValue) > 755.0)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x06012713 RID: 75539 RVA: 0x00811230 File Offset: 0x0080F430
		public long FEPABNBIPEJ()
		{
			this.AFOKAPKGHJH();
			return new ObscuredDouble.PCMLCFHDABC
			{
				JABFOOBMIFC = this.hiddenValue
			}.KLDOOIGDEDM;
		}

		// Token: 0x06012714 RID: 75540 RVA: 0x0081125E File Offset: 0x0080F45E
		public double BBNFOKCFHIA()
		{
			return this.IJKPGGBGAHM();
		}

		// Token: 0x06012715 RID: 75541 RVA: 0x00811266 File Offset: 0x0080F466
		public static void IDEHLDIJEJK(long JODDIMFACHN)
		{
			ObscuredDouble.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012716 RID: 75542 RVA: 0x0081125E File Offset: 0x0080F45E
		public double OELLGMFHJCK()
		{
			return this.IJKPGGBGAHM();
		}

		// Token: 0x06012717 RID: 75543 RVA: 0x00811270 File Offset: 0x0080F470
		public static ObscuredDouble BDDJJFJLBOM(ObscuredDouble NFKFMIIAKFN)
		{
			double dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1269.0;
			NFKFMIIAKFN.hiddenValue = ObscuredDouble.IADCLNKKCEL(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012718 RID: 75544 RVA: 0x008112C4 File Offset: 0x0080F4C4
		public string GMLGLOOIEAA(string LJCEDKCLBDB)
		{
			return this.IJKPGGBGAHM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012719 RID: 75545 RVA: 0x008112E0 File Offset: 0x0080F4E0
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredDouble.cryptoKey)
			{
				this.hiddenValue = ObscuredDouble.AFGMNANHHBF(this.MJFIFINDLAM(), ObscuredDouble.cryptoKey);
				this.currentCryptoKey = ObscuredDouble.cryptoKey;
			}
		}

		// Token: 0x0601271A RID: 75546 RVA: 0x00811310 File Offset: 0x0080F510
		public static long HBJHGHOKFDK(double DCCPCBLODIG)
		{
			return ObscuredDouble.HBJHGHOKFDK(DCCPCBLODIG, ObscuredDouble.cryptoKey);
		}

		// Token: 0x0601271B RID: 75547 RVA: 0x00811320 File Offset: 0x0080F520
		public string DFHAGGBIEIH(IFormatProvider MCGFPOIAPGJ)
		{
			return this.PHNCMMLFIFO().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x0601271C RID: 75548 RVA: 0x0081133C File Offset: 0x0080F53C
		public string NHDAHNIOAFD()
		{
			return this.IJKPGGBGAHM().ToString();
		}

		// Token: 0x0601271D RID: 75549 RVA: 0x0081125E File Offset: 0x0080F45E
		public double IIKIJFGDPDC()
		{
			return this.IJKPGGBGAHM();
		}

		// Token: 0x0601271E RID: 75550 RVA: 0x00811358 File Offset: 0x0080F558
		public static double DHPGAJEHAFD(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			return new ObscuredDouble.PCMLCFHDABC
			{
				KLDOOIGDEDM = (DCCPCBLODIG ^ JMBKDINHDLO)
			}.MBFGBDLOKFH;
		}

		// Token: 0x0601271F RID: 75551 RVA: 0x00811380 File Offset: 0x0080F580
		public static long DGGENHECDJP(double DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDouble.PCMLCFHDABC pcmlcfhdabc = default(ObscuredDouble.PCMLCFHDABC);
			pcmlcfhdabc.MBFGBDLOKFH = DCCPCBLODIG;
			pcmlcfhdabc.KLDOOIGDEDM ^= JMBKDINHDLO;
			return pcmlcfhdabc.KLDOOIGDEDM;
		}

		// Token: 0x06012720 RID: 75552 RVA: 0x008113B4 File Offset: 0x0080F5B4
		private double MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDouble.cryptoKey;
				this.hiddenValue = ObscuredDouble.AFGMNANHHBF(0.0);
				this.fakeValue = 0.0;
				this.fakeValueActive = false;
				this.inited = true;
				return 0.0;
			}
			ObscuredDouble.PCMLCFHDABC pcmlcfhdabc = default(ObscuredDouble.PCMLCFHDABC);
			pcmlcfhdabc.JABFOOBMIFC = this.hiddenValue;
			pcmlcfhdabc.KLDOOIGDEDM ^= this.currentCryptoKey;
			double mbfgbdlokfh = pcmlcfhdabc.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && Math.Abs(mbfgbdlokfh - this.fakeValue) > 1E-06)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x06012721 RID: 75553 RVA: 0x00811474 File Offset: 0x0080F674
		private static ACTkByte8 IADCLNKKCEL(double DCCPCBLODIG, long JMBKDINHDLO)
		{
			long num = JMBKDINHDLO;
			if (num == 0L)
			{
				num = ObscuredDouble.cryptoKey;
			}
			ObscuredDouble.PCMLCFHDABC pcmlcfhdabc = default(ObscuredDouble.PCMLCFHDABC);
			pcmlcfhdabc.MBFGBDLOKFH = DCCPCBLODIG;
			pcmlcfhdabc.KLDOOIGDEDM ^= num;
			return pcmlcfhdabc.JABFOOBMIFC;
		}

		// Token: 0x06012722 RID: 75554 RVA: 0x008114B1 File Offset: 0x0080F6B1
		public bool NCIEHGOMPPI(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredDouble) || this.HPBIIOBONBL((ObscuredDouble)MBKPMBPLIJN);
		}

		// Token: 0x06012723 RID: 75555 RVA: 0x008114CC File Offset: 0x0080F6CC
		public static long NHGNDCDDNNA(double DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDouble.PCMLCFHDABC pcmlcfhdabc = default(ObscuredDouble.PCMLCFHDABC);
			pcmlcfhdabc.MBFGBDLOKFH = DCCPCBLODIG;
			pcmlcfhdabc.KLDOOIGDEDM ^= JMBKDINHDLO;
			return pcmlcfhdabc.KLDOOIGDEDM;
		}

		// Token: 0x06012724 RID: 75556 RVA: 0x00810E81 File Offset: 0x0080F081
		public double FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012725 RID: 75557 RVA: 0x00811500 File Offset: 0x0080F700
		public void EINJEBBMOMA(long LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = new ObscuredDouble.PCMLCFHDABC
			{
				KLDOOIGDEDM = LDKMOLEEDIL
			}.JABFOOBMIFC;
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
			{
				this.fakeValue = this.PHNCMMLFIFO();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012726 RID: 75558 RVA: 0x00811554 File Offset: 0x0080F754
		public int JPOFOILPOLM()
		{
			return this.IJKPGGBGAHM().GetHashCode();
		}

		// Token: 0x06012727 RID: 75559 RVA: 0x0081156F File Offset: 0x0080F76F
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredDouble && this.Equals((ObscuredDouble)MBKPMBPLIJN);
		}

		// Token: 0x06012728 RID: 75560 RVA: 0x00811588 File Offset: 0x0080F788
		public bool MJDHBHHGMKC(ObscuredDouble MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.PHNCMMLFIFO().Equals(this.MJFIFINDLAM());
		}

		// Token: 0x06012729 RID: 75561 RVA: 0x00811266 File Offset: 0x0080F466
		public static void AMFPFLDEBPJ(long JODDIMFACHN)
		{
			ObscuredDouble.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601272A RID: 75562 RVA: 0x008115AC File Offset: 0x0080F7AC
		public static double NNKOGMGCJOK(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			return new ObscuredDouble.PCMLCFHDABC
			{
				KLDOOIGDEDM = (DCCPCBLODIG ^ JMBKDINHDLO)
			}.MBFGBDLOKFH;
		}

		// Token: 0x0601272B RID: 75563 RVA: 0x008115D1 File Offset: 0x0080F7D1
		public static double BKHKBGFDFBG(long DCCPCBLODIG)
		{
			return ObscuredDouble.IMFMIKEKOPL(DCCPCBLODIG, ObscuredDouble.cryptoKey);
		}

		// Token: 0x0601272C RID: 75564 RVA: 0x008115DE File Offset: 0x0080F7DE
		public static double DHPGAJEHAFD(long DCCPCBLODIG)
		{
			return ObscuredDouble.DHPGAJEHAFD(DCCPCBLODIG, ObscuredDouble.cryptoKey);
		}

		// Token: 0x0601272D RID: 75565 RVA: 0x008115EB File Offset: 0x0080F7EB
		private static ACTkByte8 OODOFOIBHGG(double DCCPCBLODIG)
		{
			return ObscuredDouble.NLIPJNACNAD(DCCPCBLODIG, 0L);
		}

		// Token: 0x0601272E RID: 75566 RVA: 0x008115F8 File Offset: 0x0080F7F8
		public int KANDOCKKGBO()
		{
			return this.PHNCMMLFIFO().GetHashCode();
		}

		// Token: 0x0601272F RID: 75567 RVA: 0x00811614 File Offset: 0x0080F814
		public string JODMFMFAOEG(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012730 RID: 75568 RVA: 0x00811630 File Offset: 0x0080F830
		private ObscuredDouble(double DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredDouble.cryptoKey;
			this.hiddenValue = ObscuredDouble.AFGMNANHHBF(DCCPCBLODIG);
			this.hiddenValueOld = null;
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : 0.0);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x06012731 RID: 75569 RVA: 0x00811684 File Offset: 0x0080F884
		public static double LIGOHGNKKIB(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			return new ObscuredDouble.PCMLCFHDABC
			{
				KLDOOIGDEDM = (DCCPCBLODIG ^ JMBKDINHDLO)
			}.MBFGBDLOKFH;
		}

		// Token: 0x06012732 RID: 75570 RVA: 0x008116AC File Offset: 0x0080F8AC
		public string KCBJCGOINMK(IFormatProvider MCGFPOIAPGJ)
		{
			return this.IJKPGGBGAHM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012733 RID: 75571 RVA: 0x008116C8 File Offset: 0x0080F8C8
		public void IFDDEMKGOLJ()
		{
			double dccpcblodig = this.PHNCMMLFIFO();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(-165, 113);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredDouble.NLIPJNACNAD(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012734 RID: 75572 RVA: 0x0081170C File Offset: 0x0080F90C
		private static ACTkByte8 NLIPJNACNAD(double DCCPCBLODIG, long JMBKDINHDLO)
		{
			long num = JMBKDINHDLO;
			if (num == 0L)
			{
				num = ObscuredDouble.cryptoKey;
			}
			ObscuredDouble.PCMLCFHDABC pcmlcfhdabc = default(ObscuredDouble.PCMLCFHDABC);
			pcmlcfhdabc.MBFGBDLOKFH = DCCPCBLODIG;
			pcmlcfhdabc.KLDOOIGDEDM ^= num;
			return pcmlcfhdabc.JABFOOBMIFC;
		}

		// Token: 0x06012735 RID: 75573 RVA: 0x00810EF7 File Offset: 0x0080F0F7
		public static double JJDNCFDJDMI(ObscuredDouble DCCPCBLODIG)
		{
			return DCCPCBLODIG.IJKPGGBGAHM();
		}

		// Token: 0x06012736 RID: 75574 RVA: 0x00811749 File Offset: 0x0080F949
		private static ACTkByte8 AFGMNANHHBF(double DCCPCBLODIG)
		{
			return ObscuredDouble.AFGMNANHHBF(DCCPCBLODIG, 0L);
		}

		// Token: 0x06012737 RID: 75575 RVA: 0x00811754 File Offset: 0x0080F954
		public static long MMBGFPEPLDE(double DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDouble.PCMLCFHDABC pcmlcfhdabc = default(ObscuredDouble.PCMLCFHDABC);
			pcmlcfhdabc.MBFGBDLOKFH = DCCPCBLODIG;
			pcmlcfhdabc.KLDOOIGDEDM ^= JMBKDINHDLO;
			return pcmlcfhdabc.KLDOOIGDEDM;
		}

		// Token: 0x06012738 RID: 75576 RVA: 0x00811786 File Offset: 0x0080F986
		public static ObscuredDouble GOOIABGKMHK(double DCCPCBLODIG)
		{
			return new ObscuredDouble(DCCPCBLODIG);
		}

		// Token: 0x06012739 RID: 75577 RVA: 0x00811266 File Offset: 0x0080F466
		public static void OHKBDEDEBKI(long JODDIMFACHN)
		{
			ObscuredDouble.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601273A RID: 75578 RVA: 0x00811790 File Offset: 0x0080F990
		public void EHCIBIIDEEH()
		{
			double dccpcblodig = this.PHNCMMLFIFO();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(128, 22);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredDouble.IADCLNKKCEL(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601273B RID: 75579 RVA: 0x008117D4 File Offset: 0x0080F9D4
		public static long HBJHGHOKFDK(double DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDouble.PCMLCFHDABC pcmlcfhdabc = default(ObscuredDouble.PCMLCFHDABC);
			pcmlcfhdabc.MBFGBDLOKFH = DCCPCBLODIG;
			pcmlcfhdabc.KLDOOIGDEDM ^= JMBKDINHDLO;
			return pcmlcfhdabc.KLDOOIGDEDM;
		}

		// Token: 0x0601273C RID: 75580 RVA: 0x00811808 File Offset: 0x0080FA08
		public string ToString(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x0601273D RID: 75581 RVA: 0x00811266 File Offset: 0x0080F466
		public static void OAKAGPCJGDI(long JODDIMFACHN)
		{
			ObscuredDouble.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601273E RID: 75582 RVA: 0x00811828 File Offset: 0x0080FA28
		public static ObscuredDouble PMHAAGMDJLB(ObscuredDouble NFKFMIIAKFN)
		{
			double dccpcblodig = NFKFMIIAKFN.IJKPGGBGAHM() - 396.0;
			NFKFMIIAKFN.hiddenValue = ObscuredDouble.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x0601273F RID: 75583 RVA: 0x0081187C File Offset: 0x0080FA7C
		public string OEAEGBAEEPP(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012740 RID: 75584 RVA: 0x0081125E File Offset: 0x0080F45E
		public double JNIKFPNOJBB()
		{
			return this.IJKPGGBGAHM();
		}

		// Token: 0x06012741 RID: 75585 RVA: 0x00811898 File Offset: 0x0080FA98
		public bool MKIDEGCGDAM(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredDouble) || this.JHHJLAIJHDG((ObscuredDouble)MBKPMBPLIJN);
		}

		// Token: 0x06012742 RID: 75586 RVA: 0x008118B0 File Offset: 0x0080FAB0
		public bool GBLGDIFFDCK(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredDouble && this.HPBIIOBONBL((ObscuredDouble)MBKPMBPLIJN);
		}

		// Token: 0x06012743 RID: 75587 RVA: 0x00811786 File Offset: 0x0080F986
		public static ObscuredDouble FNBHJBFLFLF(double DCCPCBLODIG)
		{
			return new ObscuredDouble(DCCPCBLODIG);
		}

		// Token: 0x06012744 RID: 75588 RVA: 0x008118C8 File Offset: 0x0080FAC8
		public void OJFAJIJBEFD()
		{
			double dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredDouble.AFGMNANHHBF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012745 RID: 75589 RVA: 0x0081190C File Offset: 0x0080FB0C
		public void OPMBDJDMPAG()
		{
			double dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(-196, 182);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredDouble.AFGMNANHHBF(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012746 RID: 75590 RVA: 0x00811950 File Offset: 0x0080FB50
		public static ObscuredDouble DPCDNMHLOJF(ObscuredDouble NFKFMIIAKFN)
		{
			double dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1.0;
			NFKFMIIAKFN.hiddenValue = ObscuredDouble.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012747 RID: 75591 RVA: 0x008119A4 File Offset: 0x0080FBA4
		public string HFPKDKJOEKA(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.IJKPGGBGAHM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012748 RID: 75592 RVA: 0x008119C4 File Offset: 0x0080FBC4
		public string ADOAJOFIPAM(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012749 RID: 75593 RVA: 0x008119E0 File Offset: 0x0080FBE0
		public long EHBNCDFPIJI()
		{
			this.MEHJNKMFHNO();
			return new ObscuredDouble.PCMLCFHDABC
			{
				JABFOOBMIFC = this.hiddenValue
			}.KLDOOIGDEDM;
		}

		// Token: 0x0601274A RID: 75594 RVA: 0x00811A10 File Offset: 0x0080FC10
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x0601274B RID: 75595 RVA: 0x00811A2C File Offset: 0x0080FC2C
		private static ACTkByte8 AFGMNANHHBF(double DCCPCBLODIG, long JMBKDINHDLO)
		{
			long num = JMBKDINHDLO;
			if (num == 0L)
			{
				num = ObscuredDouble.cryptoKey;
			}
			ObscuredDouble.PCMLCFHDABC pcmlcfhdabc = default(ObscuredDouble.PCMLCFHDABC);
			pcmlcfhdabc.MBFGBDLOKFH = DCCPCBLODIG;
			pcmlcfhdabc.KLDOOIGDEDM ^= num;
			return pcmlcfhdabc.JABFOOBMIFC;
		}

		// Token: 0x0601274C RID: 75596 RVA: 0x00811266 File Offset: 0x0080F466
		public static void HMPJOPABIHC(long JODDIMFACHN)
		{
			ObscuredDouble.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601274D RID: 75597 RVA: 0x00811A6C File Offset: 0x0080FC6C
		public static ObscuredDouble NKBCBILMJDE(ObscuredDouble NFKFMIIAKFN)
		{
			double dccpcblodig = NFKFMIIAKFN.PHNCMMLFIFO() + 1819.0;
			NFKFMIIAKFN.hiddenValue = ObscuredDouble.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x0601274E RID: 75598 RVA: 0x00811AC0 File Offset: 0x0080FCC0
		public void ONKCFFKECJA()
		{
			double dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(102, -151);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredDouble.IADCLNKKCEL(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x0601274F RID: 75599 RVA: 0x00811786 File Offset: 0x0080F986
		public static ObscuredDouble AJMPAOCEPCA(double DCCPCBLODIG)
		{
			return new ObscuredDouble(DCCPCBLODIG);
		}

		// Token: 0x06012750 RID: 75600 RVA: 0x00811B04 File Offset: 0x0080FD04
		public long HABNANPELIH()
		{
			this.MEHJNKMFHNO();
			return new ObscuredDouble.PCMLCFHDABC
			{
				JABFOOBMIFC = this.hiddenValue
			}.KLDOOIGDEDM;
		}

		// Token: 0x06012751 RID: 75601 RVA: 0x00811B34 File Offset: 0x0080FD34
		public void PEPPDJOPMFE(long LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = new ObscuredDouble.PCMLCFHDABC
			{
				KLDOOIGDEDM = LDKMOLEEDIL
			}.JABFOOBMIFC;
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				this.fakeValue = this.PHNCMMLFIFO();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012752 RID: 75602 RVA: 0x00811B88 File Offset: 0x0080FD88
		public void CJLOEEMMKAJ()
		{
			double dccpcblodig = this.IJKPGGBGAHM();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(-118, -53);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredDouble.IADCLNKKCEL(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012753 RID: 75603 RVA: 0x0081125E File Offset: 0x0080F45E
		public double JOCEGBNBHIG()
		{
			return this.IJKPGGBGAHM();
		}

		// Token: 0x06012754 RID: 75604 RVA: 0x00811266 File Offset: 0x0080F466
		public static void BBOGAEMNJJN(long JODDIMFACHN)
		{
			ObscuredDouble.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012755 RID: 75605 RVA: 0x00811BCC File Offset: 0x0080FDCC
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012756 RID: 75606 RVA: 0x00811BE8 File Offset: 0x0080FDE8
		private double PHNCMMLFIFO()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredDouble.cryptoKey;
				this.hiddenValue = ObscuredDouble.AFGMNANHHBF(1488.0);
				this.fakeValue = 1890.0;
				this.fakeValueActive = false;
				this.inited = true;
				return 1598.0;
			}
			ObscuredDouble.PCMLCFHDABC pcmlcfhdabc = default(ObscuredDouble.PCMLCFHDABC);
			pcmlcfhdabc.JABFOOBMIFC = this.hiddenValue;
			pcmlcfhdabc.KLDOOIGDEDM ^= this.currentCryptoKey;
			double mbfgbdlokfh = pcmlcfhdabc.MBFGBDLOKFH;
			if (ObscuredCheatingDetector.GKEOAPJKKOH() && this.fakeValueActive && Math.Abs(mbfgbdlokfh - this.fakeValue) > 88.0)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return mbfgbdlokfh;
		}

		// Token: 0x06012757 RID: 75607 RVA: 0x00811CA8 File Offset: 0x0080FEA8
		public long PGJLOAMJHLC()
		{
			this.MEHJNKMFHNO();
			return new ObscuredDouble.PCMLCFHDABC
			{
				JABFOOBMIFC = this.hiddenValue
			}.KLDOOIGDEDM;
		}

		// Token: 0x06012758 RID: 75608 RVA: 0x00811CD8 File Offset: 0x0080FED8
		public int LDJIMIOFKLG()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012759 RID: 75609 RVA: 0x00811CF3 File Offset: 0x0080FEF3
		public double KFKKFCFCKJB()
		{
			return this.PHNCMMLFIFO();
		}

		// Token: 0x0601275A RID: 75610 RVA: 0x00811CFC File Offset: 0x0080FEFC
		public string BHLHEJCILKF(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.IJKPGGBGAHM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x0601275B RID: 75611 RVA: 0x00811D1C File Offset: 0x0080FF1C
		public static ObscuredDouble IFFCKMHICPM(ObscuredDouble NFKFMIIAKFN)
		{
			double dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 495.0;
			NFKFMIIAKFN.hiddenValue = ObscuredDouble.NLIPJNACNAD(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x0601275C RID: 75612 RVA: 0x00811D70 File Offset: 0x0080FF70
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x0601275D RID: 75613 RVA: 0x00811D8C File Offset: 0x0080FF8C
		public static ObscuredDouble NOBKLDIBBCC(ObscuredDouble NFKFMIIAKFN)
		{
			double dccpcblodig = NFKFMIIAKFN.PHNCMMLFIFO() - 89.0;
			NFKFMIIAKFN.hiddenValue = ObscuredDouble.NLIPJNACNAD(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x0601275E RID: 75614 RVA: 0x00811DE0 File Offset: 0x0080FFE0
		public void LABEACCDKMD(long LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = new ObscuredDouble.PCMLCFHDABC
			{
				KLDOOIGDEDM = LDKMOLEEDIL
			}.JABFOOBMIFC;
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x0601275F RID: 75615 RVA: 0x00811E34 File Offset: 0x00810034
		public string CFPMCOPINOH(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012760 RID: 75616 RVA: 0x00811E54 File Offset: 0x00810054
		public string DHCBHNAAJKI(IFormatProvider MCGFPOIAPGJ)
		{
			return this.IJKPGGBGAHM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012761 RID: 75617 RVA: 0x00811E70 File Offset: 0x00810070
		public void NOJPHCEDDIG()
		{
			double dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = (long)UnityEngine.Random.Range(-48, -160);
			}
			while (this.currentCryptoKey == 0L);
			this.hiddenValue = ObscuredDouble.NLIPJNACNAD(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012762 RID: 75618 RVA: 0x00811266 File Offset: 0x0080F466
		public static void FAKKFCMLDGI(long JODDIMFACHN)
		{
			ObscuredDouble.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012763 RID: 75619 RVA: 0x00810E81 File Offset: 0x0080F081
		public double JLMGEJDHFNG()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012764 RID: 75620 RVA: 0x00811EB4 File Offset: 0x008100B4
		public static ObscuredDouble ICDABJMHOCP(ObscuredDouble NFKFMIIAKFN)
		{
			double dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1614.0;
			NFKFMIIAKFN.hiddenValue = ObscuredDouble.IADCLNKKCEL(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012765 RID: 75621 RVA: 0x00811F08 File Offset: 0x00810108
		public bool IALPLFHCFPI(ObscuredDouble MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.IJKPGGBGAHM().Equals(this.PHNCMMLFIFO());
		}

		// Token: 0x06012766 RID: 75622 RVA: 0x00811F2C File Offset: 0x0081012C
		public static double IMFMIKEKOPL(long DCCPCBLODIG, long JMBKDINHDLO)
		{
			return new ObscuredDouble.PCMLCFHDABC
			{
				KLDOOIGDEDM = (DCCPCBLODIG ^ JMBKDINHDLO)
			}.MBFGBDLOKFH;
		}

		// Token: 0x06012767 RID: 75623 RVA: 0x00811F54 File Offset: 0x00810154
		public bool JHHJLAIJHDG(ObscuredDouble MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.PHNCMMLFIFO().Equals(this.PHNCMMLFIFO());
		}

		// Token: 0x06012768 RID: 75624 RVA: 0x00811F78 File Offset: 0x00810178
		public bool HPBIIOBONBL(ObscuredDouble MBKPMBPLIJN)
		{
			return MBKPMBPLIJN.MJFIFINDLAM().Equals(this.IJKPGGBGAHM());
		}

		// Token: 0x06012769 RID: 75625 RVA: 0x00811F9C File Offset: 0x0081019C
		public string IPDCPCECFBC(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.IJKPGGBGAHM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x0601276A RID: 75626 RVA: 0x00811FBC File Offset: 0x008101BC
		public static ObscuredDouble HIBLFIAPCJE(ObscuredDouble NFKFMIIAKFN)
		{
			double dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1.0;
			NFKFMIIAKFN.hiddenValue = ObscuredDouble.AFGMNANHHBF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x0601276B RID: 75627 RVA: 0x00812010 File Offset: 0x00810210
		public static long EFOPLMAGNBD(double DCCPCBLODIG, long JMBKDINHDLO)
		{
			ObscuredDouble.PCMLCFHDABC pcmlcfhdabc = default(ObscuredDouble.PCMLCFHDABC);
			pcmlcfhdabc.MBFGBDLOKFH = DCCPCBLODIG;
			pcmlcfhdabc.KLDOOIGDEDM ^= JMBKDINHDLO;
			return pcmlcfhdabc.KLDOOIGDEDM;
		}

		// Token: 0x04002601 RID: 9729
		private static long cryptoKey = 210987L;

		// Token: 0x04002602 RID: 9730
		[SerializeField]
		private long currentCryptoKey;

		// Token: 0x04002603 RID: 9731
		[SerializeField]
		private ACTkByte8 hiddenValue;

		// Token: 0x04002604 RID: 9732
		[SerializeField]
		[FormerlySerializedAs("hiddenValue")]
		private byte[] hiddenValueOld;

		// Token: 0x04002605 RID: 9733
		[SerializeField]
		private bool inited;

		// Token: 0x04002606 RID: 9734
		[SerializeField]
		private double fakeValue;

		// Token: 0x04002607 RID: 9735
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x02000581 RID: 1409
		[StructLayout(LayoutKind.Explicit)]
		private struct PCMLCFHDABC
		{
			// Token: 0x04002608 RID: 9736
			[FieldOffset(0)]
			public double MBFGBDLOKFH;

			// Token: 0x04002609 RID: 9737
			[FieldOffset(0)]
			public long KLDOOIGDEDM;

			// Token: 0x0400260A RID: 9738
			[FieldOffset(0)]
			public ACTkByte8 JABFOOBMIFC;
		}
	}
}
