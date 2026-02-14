using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000584 RID: 1412
	[Serializable]
	public struct ObscuredInt : IEquatable<ObscuredInt>, IFormattable
	{
		// Token: 0x060127C2 RID: 75714 RVA: 0x00812E15 File Offset: 0x00811015
		public int LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x060127C3 RID: 75715 RVA: 0x00812E23 File Offset: 0x00811023
		public static ObscuredInt JNKANIEBCMD(int DCCPCBLODIG)
		{
			return new ObscuredInt(DCCPCBLODIG);
		}

		// Token: 0x060127C4 RID: 75716 RVA: 0x00812E2C File Offset: 0x0081102C
		public void GMEJICDHMMM()
		{
			this.hiddenValue = this.IPNLOIPBMGC();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(8, 10);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredInt.PGOAHMBLNAF(this.hiddenValue, this.currentCryptoKey);
		}

		// Token: 0x060127C5 RID: 75717 RVA: 0x00812E7C File Offset: 0x0081107C
		public string FEIJPDKNKKG(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.IPNLOIPBMGC().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x060127C6 RID: 75718 RVA: 0x00812E9C File Offset: 0x0081109C
		public void GDPFIBEKNCF()
		{
			this.hiddenValue = this.EHHMLKNKJHH();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(-147, -194);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredInt.NCJMADGLOMH(this.hiddenValue, this.currentCryptoKey);
		}

		// Token: 0x060127C7 RID: 75719 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int PGOAHMBLNAF(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060127C8 RID: 75720 RVA: 0x00812EFC File Offset: 0x008110FC
		public bool PLMGGFDKEKK(ObscuredInt MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredInt.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredInt.EOOMJIBHLLM(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x060127C9 RID: 75721 RVA: 0x00812F4C File Offset: 0x0081114C
		public string CEOAKEEKAMH()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x060127CA RID: 75722 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int CCHHNABBGCF(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060127CB RID: 75723 RVA: 0x00812F67 File Offset: 0x00811167
		public void DGLEMFLBBBB(int LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
			{
				this.fakeValue = this.MJFIFINDLAM();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x060127CC RID: 75724 RVA: 0x00812F99 File Offset: 0x00811199
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

		// Token: 0x060127CD RID: 75725 RVA: 0x00812FCB File Offset: 0x008111CB
		public int AEPDPCMKKGE()
		{
			return this.EHHMLKNKJHH();
		}

		// Token: 0x060127CE RID: 75726 RVA: 0x00812FD3 File Offset: 0x008111D3
		public void LDBNCJAELGC()
		{
			if (this.currentCryptoKey != ObscuredInt.cryptoKey)
			{
				this.hiddenValue = ObscuredInt.IKKLHPFIDED(this.GEMNKNACKBI(), ObscuredInt.cryptoKey);
				this.currentCryptoKey = ObscuredInt.cryptoKey;
			}
		}

		// Token: 0x060127CF RID: 75727 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int NNKOGMGCJOK(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060127D0 RID: 75728 RVA: 0x00813004 File Offset: 0x00811204
		public string PDMPLOPPLBI()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x060127D1 RID: 75729 RVA: 0x0081301F File Offset: 0x0081121F
		public int BBALKHNBGHL()
		{
			this.DCPMKLBOCDA();
			return this.hiddenValue;
		}

		// Token: 0x060127D2 RID: 75730 RVA: 0x0081302D File Offset: 0x0081122D
		public static int LBDMFALMOLD(ObscuredInt DCCPCBLODIG)
		{
			return DCCPCBLODIG.GEMNKNACKBI();
		}

		// Token: 0x060127D3 RID: 75731 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int GAABDMDGPMF(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060127D4 RID: 75732 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int HBJHGHOKFDK(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060127D5 RID: 75733 RVA: 0x00813038 File Offset: 0x00811238
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x060127D6 RID: 75734 RVA: 0x00813053 File Offset: 0x00811253
		public static int DGGENHECDJP(int DCCPCBLODIG)
		{
			return ObscuredInt.HBJHGHOKFDK(DCCPCBLODIG, 1);
		}

		// Token: 0x060127D7 RID: 75735 RVA: 0x0081305C File Offset: 0x0081125C
		public static ObscuredInt PMHAAGMDJLB(ObscuredInt NFKFMIIAKFN)
		{
			int dccpcblodig = NFKFMIIAKFN.IPNLOIPBMGC() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredInt.IKKLHPFIDED(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060127D8 RID: 75736 RVA: 0x008130A8 File Offset: 0x008112A8
		public static int DHPGAJEHAFD(int DCCPCBLODIG)
		{
			return ObscuredInt.DHPGAJEHAFD(DCCPCBLODIG, 0);
		}

		// Token: 0x060127D9 RID: 75737 RVA: 0x008130B4 File Offset: 0x008112B4
		public string OKEAOIBHKIN(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x060127DA RID: 75738 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int ANKJNNIIJCF(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060127DB RID: 75739 RVA: 0x008130D4 File Offset: 0x008112D4
		public int FHNIKBJNEEB()
		{
			return this.EHHMLKNKJHH().GetHashCode();
		}

		// Token: 0x060127DC RID: 75740 RVA: 0x008130F0 File Offset: 0x008112F0
		public string DIACBNHNDCJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.EHHMLKNKJHH().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060127DD RID: 75741 RVA: 0x0081310C File Offset: 0x0081130C
		public static ObscuredInt HIBLFIAPCJE(ObscuredInt NFKFMIIAKFN)
		{
			int dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredInt.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060127DE RID: 75742 RVA: 0x00812E23 File Offset: 0x00811023
		public static ObscuredInt KHJPCCFDJPA(int DCCPCBLODIG)
		{
			return new ObscuredInt(DCCPCBLODIG);
		}

		// Token: 0x060127DF RID: 75743 RVA: 0x00813158 File Offset: 0x00811358
		public void OJFAJIJBEFD()
		{
			this.hiddenValue = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredInt.HBJHGHOKFDK(this.hiddenValue, this.currentCryptoKey);
		}

		// Token: 0x060127E0 RID: 75744 RVA: 0x008131A5 File Offset: 0x008113A5
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredInt.cryptoKey)
			{
				this.hiddenValue = ObscuredInt.HBJHGHOKFDK(this.MJFIFINDLAM(), ObscuredInt.cryptoKey);
				this.currentCryptoKey = ObscuredInt.cryptoKey;
			}
		}

		// Token: 0x060127E1 RID: 75745 RVA: 0x008131D8 File Offset: 0x008113D8
		public string LHNOBJDFOOJ(IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060127E2 RID: 75746 RVA: 0x008131F4 File Offset: 0x008113F4
		public static int OIBMJHPLNPN(int DCCPCBLODIG)
		{
			return ObscuredInt.EOOMJIBHLLM(DCCPCBLODIG, 0);
		}

		// Token: 0x060127E3 RID: 75747 RVA: 0x00813200 File Offset: 0x00811400
		public static ObscuredInt DHPNHIHKEKM(ObscuredInt NFKFMIIAKFN)
		{
			int dccpcblodig = NFKFMIIAKFN.GEMNKNACKBI() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredInt.NCJMADGLOMH(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060127E4 RID: 75748 RVA: 0x0081324C File Offset: 0x0081144C
		public void DCPMKLBOCDA()
		{
			if (this.currentCryptoKey != ObscuredInt.cryptoKey)
			{
				this.hiddenValue = ObscuredInt.DFBPGGJGLKF(this.GEMNKNACKBI(), ObscuredInt.cryptoKey);
				this.currentCryptoKey = ObscuredInt.cryptoKey;
			}
		}

		// Token: 0x060127E5 RID: 75749 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int IBCBHOJGDCC(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060127E6 RID: 75750 RVA: 0x0081327C File Offset: 0x0081147C
		public static ObscuredInt MMFHEGALOCL(ObscuredInt NFKFMIIAKFN)
		{
			int dccpcblodig = NFKFMIIAKFN.IPNLOIPBMGC() - 0;
			NFKFMIIAKFN.hiddenValue = ObscuredInt.NCJMADGLOMH(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060127E7 RID: 75751 RVA: 0x008132C8 File Offset: 0x008114C8
		public static ObscuredUInt FOJDAECCDGB(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredUInt.EPDCFMMLMIF((uint)DCCPCBLODIG.GEMNKNACKBI());
		}

		// Token: 0x060127E8 RID: 75752 RVA: 0x008132D8 File Offset: 0x008114D8
		public int NMOAOIMABJK()
		{
			return this.IPNLOIPBMGC().GetHashCode();
		}

		// Token: 0x060127E9 RID: 75753 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int DFBPGGJGLKF(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060127EA RID: 75754 RVA: 0x00812FD3 File Offset: 0x008111D3
		public void GKJPOEBLLPN()
		{
			if (this.currentCryptoKey != ObscuredInt.cryptoKey)
			{
				this.hiddenValue = ObscuredInt.IKKLHPFIDED(this.GEMNKNACKBI(), ObscuredInt.cryptoKey);
				this.currentCryptoKey = ObscuredInt.cryptoKey;
			}
		}

		// Token: 0x060127EB RID: 75755 RVA: 0x008132F4 File Offset: 0x008114F4
		public static ObscuredInt KCLAMFHGMNF(ObscuredInt NFKFMIIAKFN)
		{
			int dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredInt.NCJMADGLOMH(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x060127EC RID: 75756 RVA: 0x00813340 File Offset: 0x00811540
		public static ObscuredDouble PFJMACFOKFC(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredDouble.AJMPAOCEPCA((double)DCCPCBLODIG.IPNLOIPBMGC());
		}

		// Token: 0x060127ED RID: 75757 RVA: 0x0081334F File Offset: 0x0081154F
		public static ObscuredUInt FNPJMLAKDCK(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredUInt.AMAMLPIKGLA((uint)DCCPCBLODIG.MJFIFINDLAM());
		}

		// Token: 0x060127EE RID: 75758 RVA: 0x0081335D File Offset: 0x0081155D
		public static ObscuredUInt DCNDEOCPHLF(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredUInt.KCNLJJFMBHG((uint)DCCPCBLODIG.EHHMLKNKJHH());
		}

		// Token: 0x060127EF RID: 75759 RVA: 0x0081335D File Offset: 0x0081155D
		public static ObscuredUInt JKHEIDGNJIP(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredUInt.KCNLJJFMBHG((uint)DCCPCBLODIG.EHHMLKNKJHH());
		}

		// Token: 0x060127F0 RID: 75760 RVA: 0x0081336B File Offset: 0x0081156B
		public override bool Equals(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredInt && this.Equals((ObscuredInt)MBKPMBPLIJN);
		}

		// Token: 0x060127F1 RID: 75761 RVA: 0x00813383 File Offset: 0x00811583
		public void CABALMCHCNJ()
		{
			if (this.currentCryptoKey != ObscuredInt.cryptoKey)
			{
				this.hiddenValue = ObscuredInt.PGOAHMBLNAF(this.MJFIFINDLAM(), ObscuredInt.cryptoKey);
				this.currentCryptoKey = ObscuredInt.cryptoKey;
			}
		}

		// Token: 0x060127F2 RID: 75762 RVA: 0x008133B4 File Offset: 0x008115B4
		public int NDMOBJGDENM()
		{
			return this.IPNLOIPBMGC().GetHashCode();
		}

		// Token: 0x060127F3 RID: 75763 RVA: 0x008133D0 File Offset: 0x008115D0
		public string FJGIAILHMIF(IFormatProvider MCGFPOIAPGJ)
		{
			return this.GEMNKNACKBI().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060127F4 RID: 75764 RVA: 0x008133EC File Offset: 0x008115EC
		public static int BNFKFFCNEHO(int DCCPCBLODIG)
		{
			return ObscuredInt.GHPCDGKOJAN(DCCPCBLODIG, 1);
		}

		// Token: 0x060127F5 RID: 75765 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int NCJMADGLOMH(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060127F6 RID: 75766 RVA: 0x008133F5 File Offset: 0x008115F5
		public static int GOOIABGKMHK(ObscuredInt DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x060127F7 RID: 75767 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int EOOMJIBHLLM(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060127F8 RID: 75768 RVA: 0x008133FE File Offset: 0x008115FE
		public static ObscuredDouble JGDFJPCCLFK(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredDouble.GOOIABGKMHK((double)DCCPCBLODIG.MJFIFINDLAM());
		}

		// Token: 0x060127F9 RID: 75769 RVA: 0x0081340D File Offset: 0x0081160D
		public int BECMIDIEFJN()
		{
			this.GKJPOEBLLPN();
			return this.hiddenValue;
		}

		// Token: 0x060127FA RID: 75770 RVA: 0x0081341C File Offset: 0x0081161C
		public string FGNNJFJLENH(IFormatProvider MCGFPOIAPGJ)
		{
			return this.GEMNKNACKBI().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x060127FB RID: 75771 RVA: 0x00813438 File Offset: 0x00811638
		private ObscuredInt(int DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredInt.cryptoKey;
			this.hiddenValue = ObscuredInt.HBJHGHOKFDK(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : 0);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x060127FC RID: 75772 RVA: 0x00813480 File Offset: 0x00811680
		private int IPNLOIPBMGC()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredInt.cryptoKey;
				this.hiddenValue = ObscuredInt.HBJHGHOKFDK(1);
				this.fakeValue = 0;
				this.fakeValueActive = true;
				this.inited = true;
				return 0;
			}
			int num = ObscuredInt.EOOMJIBHLLM(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x060127FD RID: 75773 RVA: 0x008134F8 File Offset: 0x008116F8
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x060127FE RID: 75774 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int DHPGAJEHAFD(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x060127FF RID: 75775 RVA: 0x00813514 File Offset: 0x00811714
		private int EHHMLKNKJHH()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredInt.cryptoKey;
				this.hiddenValue = ObscuredInt.DGGENHECDJP(0);
				this.fakeValue = 0;
				this.fakeValueActive = true;
				this.inited = true;
				return 0;
			}
			int num = ObscuredInt.IBCBHOJGDCC(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GKEOAPJKKOH() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012800 RID: 75776 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int BEKJFKPBMEI(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012801 RID: 75777 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int IKKLHPFIDED(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012802 RID: 75778 RVA: 0x0081358C File Offset: 0x0081178C
		public string IGJFJGKAFIE(IFormatProvider MCGFPOIAPGJ)
		{
			return this.EHHMLKNKJHH().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012803 RID: 75779 RVA: 0x008135A8 File Offset: 0x008117A8
		public string AOJIJIPBKPB(IFormatProvider MCGFPOIAPGJ)
		{
			return this.IPNLOIPBMGC().ToString(MCGFPOIAPGJ);
		}

		// Token: 0x06012804 RID: 75780 RVA: 0x00812E23 File Offset: 0x00811023
		public static ObscuredInt GOOIABGKMHK(int DCCPCBLODIG)
		{
			return new ObscuredInt(DCCPCBLODIG);
		}

		// Token: 0x06012805 RID: 75781 RVA: 0x008135C4 File Offset: 0x008117C4
		public static ObscuredDouble FNBHJBFLFLF(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredDouble.FNBHJBFLFLF((double)DCCPCBLODIG.GEMNKNACKBI());
		}

		// Token: 0x06012806 RID: 75782 RVA: 0x008135D4 File Offset: 0x008117D4
		public bool AFDHOIDFLJA(ObscuredInt MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredInt.MEMBDDIIPEL(this.hiddenValue, this.currentCryptoKey) == ObscuredInt.EOOMJIBHLLM(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012807 RID: 75783 RVA: 0x00813624 File Offset: 0x00811824
		public string PGOGIIBBPLM(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x06012808 RID: 75784 RVA: 0x00813644 File Offset: 0x00811844
		public static ObscuredInt DPCDNMHLOJF(ObscuredInt NFKFMIIAKFN)
		{
			int dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() - 1;
			NFKFMIIAKFN.hiddenValue = ObscuredInt.HBJHGHOKFDK(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012809 RID: 75785 RVA: 0x00813690 File Offset: 0x00811890
		public void COKOLCAGEOI(int LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue = this.GEMNKNACKBI();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x0601280A RID: 75786 RVA: 0x008136C2 File Offset: 0x008118C2
		public static int DMOFGLGMJAP(int DCCPCBLODIG)
		{
			return ObscuredInt.CCHHNABBGCF(DCCPCBLODIG, 0);
		}

		// Token: 0x0601280B RID: 75787 RVA: 0x008136CB File Offset: 0x008118CB
		public void MMCMPKLLFPG(int LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
			{
				this.fakeValue = this.IPNLOIPBMGC();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x0601280C RID: 75788 RVA: 0x008136FD File Offset: 0x008118FD
		public void HJPNPILBJDI(int LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue = this.IPNLOIPBMGC();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x0601280D RID: 75789 RVA: 0x00813730 File Offset: 0x00811930
		private int GEMNKNACKBI()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredInt.cryptoKey;
				this.hiddenValue = ObscuredInt.DGGENHECDJP(1);
				this.fakeValue = 0;
				this.fakeValueActive = true;
				this.inited = true;
				return 1;
			}
			int num = ObscuredInt.EOOMJIBHLLM(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.LHMMLFNJOMC() && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x0601280E RID: 75790 RVA: 0x008137A8 File Offset: 0x008119A8
		public bool MJDHBHHGMKC(ObscuredInt MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredInt.MEMBDDIIPEL(this.hiddenValue, this.currentCryptoKey) == ObscuredInt.MEMBDDIIPEL(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x0601280F RID: 75791 RVA: 0x008137F6 File Offset: 0x008119F6
		public static int DGOCFCFPKPI(ObscuredInt DCCPCBLODIG)
		{
			return DCCPCBLODIG.IPNLOIPBMGC();
		}

		// Token: 0x06012810 RID: 75792 RVA: 0x008137FF File Offset: 0x008119FF
		public static void CCCFFAIEKGL(int JODDIMFACHN)
		{
			ObscuredInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012811 RID: 75793 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int BPPJAHBEACG(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012812 RID: 75794 RVA: 0x00813808 File Offset: 0x00811A08
		public string OABGAIPBCLL()
		{
			return this.EHHMLKNKJHH().ToString();
		}

		// Token: 0x06012813 RID: 75795 RVA: 0x00813824 File Offset: 0x00811A24
		public static ObscuredInt NDIPOJMKAJF(ObscuredInt NFKFMIIAKFN)
		{
			int dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredInt.NCJMADGLOMH(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012814 RID: 75796 RVA: 0x00813870 File Offset: 0x00811A70
		public bool Equals(ObscuredInt MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredInt.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey) == ObscuredInt.DHPGAJEHAFD(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012815 RID: 75797 RVA: 0x008138BE File Offset: 0x00811ABE
		public static ObscuredUInt IKAKHNCLALE(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredUInt.EPDCFMMLMIF((uint)DCCPCBLODIG.MJFIFINDLAM());
		}

		// Token: 0x06012816 RID: 75798 RVA: 0x008138CC File Offset: 0x00811ACC
		public void CJIIHMIDBEN()
		{
			this.hiddenValue = this.EHHMLKNKJHH();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(59, -128);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredInt.GHPCDGKOJAN(this.hiddenValue, this.currentCryptoKey);
		}

		// Token: 0x06012817 RID: 75799 RVA: 0x00813919 File Offset: 0x00811B19
		public void CCAMBNKAECH(int LDKMOLEEDIL)
		{
			this.inited = true;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.CKFIDHHGLGO())
			{
				this.fakeValue = this.IPNLOIPBMGC();
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012818 RID: 75800 RVA: 0x0081394B File Offset: 0x00811B4B
		public int FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012819 RID: 75801 RVA: 0x00813953 File Offset: 0x00811B53
		public static int CBCAINFJGPK(int DCCPCBLODIG)
		{
			return ObscuredInt.MEMBDDIIPEL(DCCPCBLODIG, 1);
		}

		// Token: 0x0601281A RID: 75802 RVA: 0x0081395C File Offset: 0x00811B5C
		public static int GNFDMLANFKF(int DCCPCBLODIG)
		{
			return ObscuredInt.CCHHNABBGCF(DCCPCBLODIG, 1);
		}

		// Token: 0x0601281B RID: 75803 RVA: 0x00813965 File Offset: 0x00811B65
		public static ObscuredFloat GOOIABGKMHK(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredFloat.GOOIABGKMHK((float)DCCPCBLODIG.MJFIFINDLAM());
		}

		// Token: 0x0601281C RID: 75804 RVA: 0x00813974 File Offset: 0x00811B74
		public bool IGJBPJKAJAI(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredInt) || this.AFDHOIDFLJA((ObscuredInt)MBKPMBPLIJN);
		}

		// Token: 0x0601281D RID: 75805 RVA: 0x0081398C File Offset: 0x00811B8C
		public string DIJJDHMMGCA(string LJCEDKCLBDB)
		{
			return this.EHHMLKNKJHH().ToString(LJCEDKCLBDB);
		}

		// Token: 0x0601281E RID: 75806 RVA: 0x00812FCB File Offset: 0x008111CB
		public int FKBJOBGJCPG()
		{
			return this.EHHMLKNKJHH();
		}

		// Token: 0x0601281F RID: 75807 RVA: 0x00812E23 File Offset: 0x00811023
		public static ObscuredInt IGDNGFGPOFC(int DCCPCBLODIG)
		{
			return new ObscuredInt(DCCPCBLODIG);
		}

		// Token: 0x06012820 RID: 75808 RVA: 0x008139A8 File Offset: 0x00811BA8
		public string NAAOOABFHKB()
		{
			return this.EHHMLKNKJHH().ToString();
		}

		// Token: 0x06012821 RID: 75809 RVA: 0x008139C4 File Offset: 0x00811BC4
		public bool ICKBIMPCKAB(ObscuredInt MBKPMBPLIJN)
		{
			if (this.currentCryptoKey == MBKPMBPLIJN.currentCryptoKey)
			{
				return this.hiddenValue == MBKPMBPLIJN.hiddenValue;
			}
			return ObscuredInt.CCHHNABBGCF(this.hiddenValue, this.currentCryptoKey) == ObscuredInt.DHPGAJEHAFD(MBKPMBPLIJN.hiddenValue, MBKPMBPLIJN.currentCryptoKey);
		}

		// Token: 0x06012822 RID: 75810 RVA: 0x00813A14 File Offset: 0x00811C14
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012824 RID: 75812 RVA: 0x00813A3B File Offset: 0x00811C3B
		public static ObscuredFloat JJDNCFDJDMI(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredFloat.GOOIABGKMHK((float)DCCPCBLODIG.IPNLOIPBMGC());
		}

		// Token: 0x06012825 RID: 75813 RVA: 0x00813953 File Offset: 0x00811B53
		public static int BNLDICBLKOK(int DCCPCBLODIG)
		{
			return ObscuredInt.MEMBDDIIPEL(DCCPCBLODIG, 1);
		}

		// Token: 0x06012826 RID: 75814 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int GHPCDGKOJAN(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x06012827 RID: 75815 RVA: 0x00813A4C File Offset: 0x00811C4C
		public string DDLFNJEJPBP()
		{
			return this.GEMNKNACKBI().ToString();
		}

		// Token: 0x06012828 RID: 75816 RVA: 0x008137FF File Offset: 0x008119FF
		public static void CBKGECBFIHN(int JODDIMFACHN)
		{
			ObscuredInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012829 RID: 75817 RVA: 0x00813A68 File Offset: 0x00811C68
		public string ToString(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x0601282A RID: 75818 RVA: 0x00813A88 File Offset: 0x00811C88
		public string IBLEHFEBIMG(string LJCEDKCLBDB, IFormatProvider MCGFPOIAPGJ)
		{
			return this.EHHMLKNKJHH().ToString(LJCEDKCLBDB, MCGFPOIAPGJ);
		}

		// Token: 0x0601282B RID: 75819 RVA: 0x00812E15 File Offset: 0x00811015
		public int GLOINDKOLDG()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x0601282C RID: 75820 RVA: 0x008137FF File Offset: 0x008119FF
		public static void DMLCGIGHIPF(int JODDIMFACHN)
		{
			ObscuredInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x0601282D RID: 75821 RVA: 0x00812EE9 File Offset: 0x008110E9
		public static int MEMBDDIIPEL(int DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				return DCCPCBLODIG ^ ObscuredInt.cryptoKey;
			}
			return DCCPCBLODIG ^ JMBKDINHDLO;
		}

		// Token: 0x0601282E RID: 75822 RVA: 0x00813AA8 File Offset: 0x00811CA8
		public static ObscuredInt EGOFHPJKKMI(ObscuredInt NFKFMIIAKFN)
		{
			int dccpcblodig = NFKFMIIAKFN.MJFIFINDLAM() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredInt.NCJMADGLOMH(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x0601282F RID: 75823 RVA: 0x008133FE File Offset: 0x008115FE
		public static ObscuredDouble GOOIABGKMHK(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredDouble.GOOIABGKMHK((double)DCCPCBLODIG.MJFIFINDLAM());
		}

		// Token: 0x06012830 RID: 75824 RVA: 0x00813AF4 File Offset: 0x00811CF4
		public bool BJFOHGGCKNP(object MBKPMBPLIJN)
		{
			return !(MBKPMBPLIJN is ObscuredInt) || this.Equals((ObscuredInt)MBKPMBPLIJN);
		}

		// Token: 0x06012831 RID: 75825 RVA: 0x00813B0C File Offset: 0x00811D0C
		public static int HBJHGHOKFDK(int DCCPCBLODIG)
		{
			return ObscuredInt.HBJHGHOKFDK(DCCPCBLODIG, 0);
		}

		// Token: 0x06012832 RID: 75826 RVA: 0x00813B15 File Offset: 0x00811D15
		public static ObscuredUInt LFKGEAFLLCN(ObscuredInt DCCPCBLODIG)
		{
			return ObscuredUInt.GOOIABGKMHK((uint)DCCPCBLODIG.MJFIFINDLAM());
		}

		// Token: 0x06012833 RID: 75827 RVA: 0x00813B23 File Offset: 0x00811D23
		public bool OGIPCMEIIIN(object MBKPMBPLIJN)
		{
			return MBKPMBPLIJN is ObscuredInt && this.AFDHOIDFLJA((ObscuredInt)MBKPMBPLIJN);
		}

		// Token: 0x06012834 RID: 75828 RVA: 0x00813B3B File Offset: 0x00811D3B
		public void LNBLECJHDND(int LDKMOLEEDIL)
		{
			this.inited = false;
			this.hiddenValue = LDKMOLEEDIL;
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue = this.IPNLOIPBMGC();
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012835 RID: 75829 RVA: 0x008137FF File Offset: 0x008119FF
		public static void BBOGAEMNJJN(int JODDIMFACHN)
		{
			ObscuredInt.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012836 RID: 75830 RVA: 0x00813B70 File Offset: 0x00811D70
		public static ObscuredInt LILDJKCLMJH(ObscuredInt NFKFMIIAKFN)
		{
			int dccpcblodig = NFKFMIIAKFN.EHHMLKNKJHH() + 1;
			NFKFMIIAKFN.hiddenValue = ObscuredInt.PGOAHMBLNAF(dccpcblodig, NFKFMIIAKFN.currentCryptoKey);
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

		// Token: 0x06012837 RID: 75831 RVA: 0x00813BBC File Offset: 0x00811DBC
		private int MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredInt.cryptoKey;
				this.hiddenValue = ObscuredInt.HBJHGHOKFDK(0);
				this.fakeValue = 0;
				this.fakeValueActive = false;
				this.inited = true;
				return 0;
			}
			int num = ObscuredInt.DHPGAJEHAFD(this.hiddenValue, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && num != this.fakeValue)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x04002615 RID: 9749
		private static int cryptoKey = 444444;

		// Token: 0x04002616 RID: 9750
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04002617 RID: 9751
		[SerializeField]
		private int hiddenValue;

		// Token: 0x04002618 RID: 9752
		[SerializeField]
		private bool inited;

		// Token: 0x04002619 RID: 9753
		[SerializeField]
		private int fakeValue;

		// Token: 0x0400261A RID: 9754
		[SerializeField]
		private bool fakeValueActive;
	}
}
