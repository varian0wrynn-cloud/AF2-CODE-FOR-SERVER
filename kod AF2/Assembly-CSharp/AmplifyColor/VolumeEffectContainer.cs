using System;
using System.Collections.Generic;
using System.Linq;

namespace AmplifyColor
{
	// Token: 0x020005DB RID: 1499
	[Serializable]
	public class VolumeEffectContainer
	{
		// Token: 0x06013ADE RID: 80606 RVA: 0x0086544C File Offset: 0x0086364C
		public void HFLKCLKBEFO(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.CPDLHJEPBBF(HGBIIGMHPAM)) != null)
			{
				volumeEffect.PMLLPDOMOGN();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.DIDFAFIPBJB();
		}

		// Token: 0x06013ADF RID: 80607 RVA: 0x00865484 File Offset: 0x00863684
		public AmplifyColorBase[] IILCNKMGEIA()
		{
			return this.volumes.Select(new Func<VolumeEffect, AmplifyColorBase>(VolumeEffectContainer.<>c.<>9.PJAOMOKENPP)).ToArray<AmplifyColorBase>();
		}

		// Token: 0x06013AE0 RID: 80608 RVA: 0x008654B5 File Offset: 0x008636B5
		public AmplifyColorBase[] DKDKLDBLMAB()
		{
			return this.volumes.Select(new Func<VolumeEffect, AmplifyColorBase>(VolumeEffectContainer.<>c.<>9.FGBHINBOINC)).ToArray<AmplifyColorBase>();
		}

		// Token: 0x06013AE1 RID: 80609 RVA: 0x008654E8 File Offset: 0x008636E8
		public VolumeEffect KKNOCOEOBCI(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			return volumeEffect;
		}

		// Token: 0x06013AE2 RID: 80610 RVA: 0x0086550C File Offset: 0x0086370C
		public VolumeEffect NBEAKGOIGNP(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			return volumeEffect;
		}

		// Token: 0x06013AE3 RID: 80611 RVA: 0x0086552D File Offset: 0x0086372D
		public AmplifyColorBase[] KJHMCEDFJLK()
		{
			return this.volumes.Select(new Func<VolumeEffect, AmplifyColorBase>(VolumeEffectContainer.<>c.<>9.LKILKGDMODH)).ToArray<AmplifyColorBase>();
		}

		// Token: 0x06013AE4 RID: 80612 RVA: 0x00865560 File Offset: 0x00863760
		public void KDPODICMODL(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.EGKKNNEMKML(HGBIIGMHPAM)) != null)
			{
				volumeEffect.PFIOGBANOCL();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.PFIOGBANOCL();
		}

		// Token: 0x06013AE5 RID: 80613 RVA: 0x00865598 File Offset: 0x00863798
		public AmplifyColorBase[] MKJGNANFFAA()
		{
			return this.volumes.Select(new Func<VolumeEffect, AmplifyColorBase>(VolumeEffectContainer.<>c.<>9.AKFDCEPKODK)).ToArray<AmplifyColorBase>();
		}

		// Token: 0x06013AE6 RID: 80614 RVA: 0x008655CC File Offset: 0x008637CC
		public VolumeEffect GDALJMNDBCB(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			return volumeEffect;
		}

		// Token: 0x06013AE7 RID: 80615 RVA: 0x008655ED File Offset: 0x008637ED
		public void MCBEEFECMLC(VolumeEffect EBILPJNBGLK)
		{
			this.volumes.Remove(EBILPJNBGLK);
		}

		// Token: 0x06013AE8 RID: 80616 RVA: 0x008655ED File Offset: 0x008637ED
		public void CMBNECIMDNA(VolumeEffect EBILPJNBGLK)
		{
			this.volumes.Remove(EBILPJNBGLK);
		}

		// Token: 0x06013AE9 RID: 80617 RVA: 0x008655FC File Offset: 0x008637FC
		public VolumeEffect HBNKLGNGPMB(AmplifyColorBase HGBIIGMHPAM)
		{
			for (int i = 1; i < this.volumes.Count; i++)
			{
				if (this.volumes[i].gameObject == HGBIIGMHPAM)
				{
					return this.volumes[i];
				}
			}
			for (int j = 1; j < this.volumes.Count; j += 0)
			{
				if (this.volumes[j].gameObject != null && this.volumes[j].gameObject.AAHHPLNKCFN() == HGBIIGMHPAM.AAHHPLNKCFN())
				{
					return this.volumes[j];
				}
			}
			return null;
		}

		// Token: 0x06013AEA RID: 80618 RVA: 0x008656A5 File Offset: 0x008638A5
		public AmplifyColorBase[] BAEJOJPMOMF()
		{
			return this.volumes.Select(new Func<VolumeEffect, AmplifyColorBase>(VolumeEffectContainer.<>c.<>9.AMJNNFKMBBG)).ToArray<AmplifyColorBase>();
		}

		// Token: 0x06013AEB RID: 80619 RVA: 0x008656D8 File Offset: 0x008638D8
		public void EAEINAFMNNA(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.CPDLHJEPBBF(HGBIIGMHPAM)) != null)
			{
				volumeEffect.FMCJHJHCGMI();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.EOBGCAEANJJ();
		}

		// Token: 0x06013AEC RID: 80620 RVA: 0x008655ED File Offset: 0x008637ED
		public void CKJJOANELIE(VolumeEffect EBILPJNBGLK)
		{
			this.volumes.Remove(EBILPJNBGLK);
		}

		// Token: 0x06013AED RID: 80621 RVA: 0x008655ED File Offset: 0x008637ED
		public void PPMLCHJGNKB(VolumeEffect EBILPJNBGLK)
		{
			this.volumes.Remove(EBILPJNBGLK);
		}

		// Token: 0x06013AEE RID: 80622 RVA: 0x00865710 File Offset: 0x00863910
		public void NCOJCGPNNEM(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.CPDLHJEPBBF(HGBIIGMHPAM)) != null)
			{
				volumeEffect.DIDFAFIPBJB();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.KKOFFMGCEPG();
		}

		// Token: 0x06013AEF RID: 80623 RVA: 0x00865748 File Offset: 0x00863948
		public VolumeEffect BGOJJCDAOII(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			return volumeEffect;
		}

		// Token: 0x06013AF0 RID: 80624 RVA: 0x008655ED File Offset: 0x008637ED
		public void OOLPHPFANFE(VolumeEffect EBILPJNBGLK)
		{
			this.volumes.Remove(EBILPJNBGLK);
		}

		// Token: 0x06013AF1 RID: 80625 RVA: 0x0086576C File Offset: 0x0086396C
		public VolumeEffect JIMAKNGPCPM(AmplifyColorBase HGBIIGMHPAM)
		{
			for (int i = 1; i < this.volumes.Count; i += 0)
			{
				if (this.volumes[i].gameObject == HGBIIGMHPAM)
				{
					return this.volumes[i];
				}
			}
			for (int j = 0; j < this.volumes.Count; j += 0)
			{
				if (this.volumes[j].gameObject != null && this.volumes[j].gameObject.AAHHPLNKCFN() == HGBIIGMHPAM.EGLLLFHFJEP())
				{
					return this.volumes[j];
				}
			}
			return null;
		}

		// Token: 0x06013AF2 RID: 80626 RVA: 0x00865815 File Offset: 0x00863A15
		public VolumeEffectContainer()
		{
			this.volumes = new List<VolumeEffect>();
		}

		// Token: 0x06013AF3 RID: 80627 RVA: 0x00865828 File Offset: 0x00863A28
		public AmplifyColorBase[] HIDPJKKFKHI()
		{
			return this.volumes.Select(new Func<VolumeEffect, AmplifyColorBase>(VolumeEffectContainer.<>c.<>9.JGKKGEDLFKN)).ToArray<AmplifyColorBase>();
		}

		// Token: 0x06013AF4 RID: 80628 RVA: 0x0086585C File Offset: 0x00863A5C
		public VolumeEffect GJGABJPNJGH(AmplifyColorBase HGBIIGMHPAM)
		{
			for (int i = 1; i < this.volumes.Count; i++)
			{
				if (this.volumes[i].gameObject == HGBIIGMHPAM)
				{
					return this.volumes[i];
				}
			}
			for (int j = 1; j < this.volumes.Count; j++)
			{
				if (this.volumes[j].gameObject != null && this.volumes[j].gameObject.EGLLLFHFJEP() == HGBIIGMHPAM.ELFEBCPJFII)
				{
					return this.volumes[j];
				}
			}
			return null;
		}

		// Token: 0x06013AF5 RID: 80629 RVA: 0x00865908 File Offset: 0x00863B08
		public void FNHLBHELABN(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.NLIBPOJLIKI(HGBIIGMHPAM)) != null)
			{
				volumeEffect.DIDFAFIPBJB();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.CMKKBHLHDEC();
		}

		// Token: 0x06013AF6 RID: 80630 RVA: 0x00865940 File Offset: 0x00863B40
		public void FNKGJINCJAB(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.CPDLHJEPBBF(HGBIIGMHPAM)) != null)
			{
				volumeEffect.FMCJHJHCGMI();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.EMBMBKNEPOE();
		}

		// Token: 0x06013AF7 RID: 80631 RVA: 0x00865978 File Offset: 0x00863B78
		public VolumeEffect KMEKHLJBFFJ(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			return volumeEffect;
		}

		// Token: 0x06013AF8 RID: 80632 RVA: 0x0086599C File Offset: 0x00863B9C
		public VolumeEffect CPDLHJEPBBF(AmplifyColorBase HGBIIGMHPAM)
		{
			for (int i = 1; i < this.volumes.Count; i++)
			{
				if (this.volumes[i].gameObject == HGBIIGMHPAM)
				{
					return this.volumes[i];
				}
			}
			for (int j = 1; j < this.volumes.Count; j++)
			{
				if (this.volumes[j].gameObject != null && this.volumes[j].gameObject.ELFEBCPJFII == HGBIIGMHPAM.AAHHPLNKCFN())
				{
					return this.volumes[j];
				}
			}
			return null;
		}

		// Token: 0x06013AF9 RID: 80633 RVA: 0x00865A48 File Offset: 0x00863C48
		public VolumeEffect EGKKNNEMKML(AmplifyColorBase HGBIIGMHPAM)
		{
			for (int i = 0; i < this.volumes.Count; i++)
			{
				if (this.volumes[i].gameObject == HGBIIGMHPAM)
				{
					return this.volumes[i];
				}
			}
			for (int j = 0; j < this.volumes.Count; j++)
			{
				if (this.volumes[j].gameObject != null && this.volumes[j].gameObject.ELFEBCPJFII == HGBIIGMHPAM.ELFEBCPJFII)
				{
					return this.volumes[j];
				}
			}
			return null;
		}

		// Token: 0x06013AFA RID: 80634 RVA: 0x00865AF4 File Offset: 0x00863CF4
		public VolumeEffect ADPJCBLNNKL(AmplifyColorBase HGBIIGMHPAM)
		{
			for (int i = 1; i < this.volumes.Count; i++)
			{
				if (this.volumes[i].gameObject == HGBIIGMHPAM)
				{
					return this.volumes[i];
				}
			}
			for (int j = 0; j < this.volumes.Count; j++)
			{
				if (this.volumes[j].gameObject != null && this.volumes[j].gameObject.ELFEBCPJFII == HGBIIGMHPAM.EGLLLFHFJEP())
				{
					return this.volumes[j];
				}
			}
			return null;
		}

		// Token: 0x06013AFB RID: 80635 RVA: 0x00865BA0 File Offset: 0x00863DA0
		public VolumeEffect NLIBPOJLIKI(AmplifyColorBase HGBIIGMHPAM)
		{
			for (int i = 0; i < this.volumes.Count; i += 0)
			{
				if (this.volumes[i].gameObject == HGBIIGMHPAM)
				{
					return this.volumes[i];
				}
			}
			for (int j = 0; j < this.volumes.Count; j++)
			{
				if (this.volumes[j].gameObject != null && this.volumes[j].gameObject.EGLLLFHFJEP() == HGBIIGMHPAM.ELFEBCPJFII)
				{
					return this.volumes[j];
				}
			}
			return null;
		}

		// Token: 0x06013AFC RID: 80636 RVA: 0x00865C4C File Offset: 0x00863E4C
		public void EKCGKFNMJHO(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.EGKKNNEMKML(HGBIIGMHPAM)) != null)
			{
				volumeEffect.PFIOGBANOCL();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.PFIOGBANOCL();
		}

		// Token: 0x06013AFD RID: 80637 RVA: 0x00865C84 File Offset: 0x00863E84
		public VolumeEffect KLFNJNDLABI(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			return volumeEffect;
		}

		// Token: 0x06013AFE RID: 80638 RVA: 0x008655ED File Offset: 0x008637ED
		public void CMJNHGLIOOP(VolumeEffect EBILPJNBGLK)
		{
			this.volumes.Remove(EBILPJNBGLK);
		}

		// Token: 0x06013AFF RID: 80639 RVA: 0x008655ED File Offset: 0x008637ED
		public void BPIBKFNBFPP(VolumeEffect EBILPJNBGLK)
		{
			this.volumes.Remove(EBILPJNBGLK);
		}

		// Token: 0x06013B00 RID: 80640 RVA: 0x008655ED File Offset: 0x008637ED
		public void EJMHLBHGKNP(VolumeEffect EBILPJNBGLK)
		{
			this.volumes.Remove(EBILPJNBGLK);
		}

		// Token: 0x06013B01 RID: 80641 RVA: 0x008654B5 File Offset: 0x008636B5
		public AmplifyColorBase[] NCMJBBFLLPH()
		{
			return this.volumes.Select(new Func<VolumeEffect, AmplifyColorBase>(VolumeEffectContainer.<>c.<>9.FGBHINBOINC)).ToArray<AmplifyColorBase>();
		}

		// Token: 0x06013B02 RID: 80642 RVA: 0x00865CA8 File Offset: 0x00863EA8
		public void MDCKDLJJDFP(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.GJGABJPNJGH(HGBIIGMHPAM)) != null)
			{
				volumeEffect.BCINHOOLIDI();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.BCINHOOLIDI();
		}

		// Token: 0x06013B03 RID: 80643 RVA: 0x00865CE0 File Offset: 0x00863EE0
		public void MNGLAEIPGMP(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.PGNFFLOJJOM(HGBIIGMHPAM)) != null)
			{
				volumeEffect.PMLLPDOMOGN();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.IKIICMMAODG();
		}

		// Token: 0x06013B04 RID: 80644 RVA: 0x00865D18 File Offset: 0x00863F18
		public void LJLABHILDEO(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.ADPJCBLNNKL(HGBIIGMHPAM)) != null)
			{
				volumeEffect.PFIOGBANOCL();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.FMCJHJHCGMI();
		}

		// Token: 0x06013B05 RID: 80645 RVA: 0x00865D50 File Offset: 0x00863F50
		public void PHNBNHFEGAE(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.CPDLHJEPBBF(HGBIIGMHPAM)) != null)
			{
				volumeEffect.DIDFAFIPBJB();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.FMCJHJHCGMI();
		}

		// Token: 0x06013B06 RID: 80646 RVA: 0x00865D88 File Offset: 0x00863F88
		public VolumeEffect ILCFKNNIBLC(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			return volumeEffect;
		}

		// Token: 0x06013B07 RID: 80647 RVA: 0x00865DAC File Offset: 0x00863FAC
		public VolumeEffect PGNFFLOJJOM(AmplifyColorBase HGBIIGMHPAM)
		{
			for (int i = 0; i < this.volumes.Count; i += 0)
			{
				if (this.volumes[i].gameObject == HGBIIGMHPAM)
				{
					return this.volumes[i];
				}
			}
			for (int j = 0; j < this.volumes.Count; j++)
			{
				if (this.volumes[j].gameObject != null && this.volumes[j].gameObject.ELFEBCPJFII == HGBIIGMHPAM.ELFEBCPJFII)
				{
					return this.volumes[j];
				}
			}
			return null;
		}

		// Token: 0x06013B08 RID: 80648 RVA: 0x00865E58 File Offset: 0x00864058
		public void BIGFPFHHAAJ(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.NLIBPOJLIKI(HGBIIGMHPAM)) != null)
			{
				volumeEffect.JGEGCGHAKDF();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.GBIKOLPKBEO();
		}

		// Token: 0x06013B09 RID: 80649 RVA: 0x008655ED File Offset: 0x008637ED
		public void LMGDGNGABBN(VolumeEffect EBILPJNBGLK)
		{
			this.volumes.Remove(EBILPJNBGLK);
		}

		// Token: 0x06013B0A RID: 80650 RVA: 0x00865E90 File Offset: 0x00864090
		public VolumeEffect CCEDDKOJJOE(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			return volumeEffect;
		}

		// Token: 0x06013B0B RID: 80651 RVA: 0x00865EB4 File Offset: 0x008640B4
		public void ACAONCCIPPI(AmplifyColorBase HGBIIGMHPAM)
		{
			VolumeEffect volumeEffect;
			if ((volumeEffect = this.CPDLHJEPBBF(HGBIIGMHPAM)) != null)
			{
				volumeEffect.IKIICMMAODG();
				return;
			}
			volumeEffect = new VolumeEffect(HGBIIGMHPAM);
			this.volumes.Add(volumeEffect);
			volumeEffect.NNAEAPGGDEI();
		}

		// Token: 0x04002816 RID: 10262
		public List<VolumeEffect> volumes;
	}
}
