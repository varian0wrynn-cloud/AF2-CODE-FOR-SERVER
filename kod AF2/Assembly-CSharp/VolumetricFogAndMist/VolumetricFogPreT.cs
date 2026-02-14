using System;
using System.Collections;
using UnityEngine;

namespace VolumetricFogAndMist
{
	// Token: 0x020002C5 RID: 709
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera), typeof(VolumetricFog))]
	public class VolumetricFogPreT : MonoBehaviour, HPLMICNEDGL
	{
		// Token: 0x0600A727 RID: 42791 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void IMPPMGOJCFO()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600A728 RID: 42792 RVA: 0x004AEC89 File Offset: 0x004ACE89
		// (set) Token: 0x0600A79B RID: 42907 RVA: 0x004AED03 File Offset: 0x004ACF03
		public VolumetricFog ANCIMKLOHFH { get; set; }

		// Token: 0x0600A729 RID: 42793 RVA: 0x004AEC91 File Offset: 0x004ACE91
		private void DNFONOKOMCC()
		{
			if (this.CODPMNHHPLN() != null)
			{
				this.ABGKNKGNCGF().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A72A RID: 42794 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void JIAOJJEPPFD()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A72B RID: 42795 RVA: 0x004AECAC File Offset: 0x004ACEAC
		private void MMMBEOOHAME(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.MBGAFPCPMJJ() != null)
			{
				this.LAIAOEEDCIO().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A72C RID: 42796 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void DMBFEFEKAAC()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A72D RID: 42797 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog FICHHMAHDAO()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A72E RID: 42798 RVA: 0x004AECC9 File Offset: 0x004ACEC9
		private void CJBFPHKILDD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.MBGAFPCPMJJ() != null)
			{
				this.IGDHEFMFLMB().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A72F RID: 42799 RVA: 0x004AECE6 File Offset: 0x004ACEE6
		private void EBLFIONBNIO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.OFBCDCDNACM() != null)
			{
				this.HAFPGBLHGKN().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A730 RID: 42800 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void KAAGLCACDOL(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x004AED0C File Offset: 0x004ACF0C
		private IEnumerator CPEFGMPEMOL()
		{
			if (this.ANCIMKLOHFH != null && this.ANCIMKLOHFH.KJLHOBIAFKM)
			{
				yield return new WaitForEndOfFrame();
				if (this.ANCIMKLOHFH != null)
				{
					this.ANCIMKLOHFH.OEEFHDICHJD();
				}
			}
			yield break;
		}

		// Token: 0x0600A732 RID: 42802 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog LAIAOEEDCIO()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void BKPANAGGCCB(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A735 RID: 42805 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void DPIIIHDGKGJ(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A736 RID: 42806 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void CDLLGEJDEFI()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog HAFPGBLHGKN()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A738 RID: 42808 RVA: 0x004AED1B File Offset: 0x004ACF1B
		private void OnPreRender()
		{
			if (this.ANCIMKLOHFH != null)
			{
				this.ANCIMKLOHFH.PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A739 RID: 42809 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void MDLKAGKBEBM(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A73A RID: 42810 RVA: 0x004AED36 File Offset: 0x004ACF36
		private IEnumerator GNPLKNJCEAH()
		{
			VolumetricFogPreT.OJIPEJPNBHK ojipejpnbhk = new VolumetricFogPreT.OJIPEJPNBHK(1);
			ojipejpnbhk.AENJLLPLILM = this;
			return ojipejpnbhk;
		}

		// Token: 0x0600A73B RID: 42811 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog AOGMABGEJOO()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A73C RID: 42812 RVA: 0x004AED36 File Offset: 0x004ACF36
		private IEnumerator HMOGOFDGPLB()
		{
			VolumetricFogPreT.OJIPEJPNBHK ojipejpnbhk = new VolumetricFogPreT.OJIPEJPNBHK(1);
			ojipejpnbhk.AENJLLPLILM = this;
			return ojipejpnbhk;
		}

		// Token: 0x0600A73D RID: 42813 RVA: 0x004AED45 File Offset: 0x004ACF45
		private void IAKFCAIJBCF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.ABGKNKGNCGF() != null)
			{
				this.IJEJINPNOBB().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A73E RID: 42814 RVA: 0x004AED36 File Offset: 0x004ACF36
		private IEnumerator JCGBAKKIOGE()
		{
			VolumetricFogPreT.OJIPEJPNBHK ojipejpnbhk = new VolumetricFogPreT.OJIPEJPNBHK(1);
			ojipejpnbhk.AENJLLPLILM = this;
			return ojipejpnbhk;
		}

		// Token: 0x0600A73F RID: 42815 RVA: 0x004AED36 File Offset: 0x004ACF36
		private IEnumerator JEEFIADOHNP()
		{
			VolumetricFogPreT.OJIPEJPNBHK ojipejpnbhk = new VolumetricFogPreT.OJIPEJPNBHK(1);
			ojipejpnbhk.AENJLLPLILM = this;
			return ojipejpnbhk;
		}

		// Token: 0x0600A740 RID: 42816 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void AFPAICOFIAF()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A741 RID: 42817 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void IMMPNIODMDF()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A742 RID: 42818 RVA: 0x004AED0C File Offset: 0x004ACF0C
		private IEnumerator FHHJCFAOIDO()
		{
			if (this.ANCIMKLOHFH != null && this.ANCIMKLOHFH.KJLHOBIAFKM)
			{
				yield return new WaitForEndOfFrame();
				if (this.ANCIMKLOHFH != null)
				{
					this.ANCIMKLOHFH.OEEFHDICHJD();
				}
			}
			yield break;
		}

		// Token: 0x0600A743 RID: 42819 RVA: 0x004AED62 File Offset: 0x004ACF62
		private void HGBMMLPBFAL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.IGDHEFMFLMB() != null)
			{
				this.ANCIMKLOHFH.FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A744 RID: 42820 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void DestroySelf()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A745 RID: 42821 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void AHNPLKIGOGN()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A746 RID: 42822 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void IIGHNEILDGO()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A747 RID: 42823 RVA: 0x004AED36 File Offset: 0x004ACF36
		private IEnumerator MBOEBAMFFEE()
		{
			VolumetricFogPreT.OJIPEJPNBHK ojipejpnbhk = new VolumetricFogPreT.OJIPEJPNBHK(1);
			ojipejpnbhk.AENJLLPLILM = this;
			return ojipejpnbhk;
		}

		// Token: 0x0600A748 RID: 42824 RVA: 0x004AED7F File Offset: 0x004ACF7F
		private void GOJAEFGPNNI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.HAFPGBLHGKN() != null)
			{
				this.CDEMFAIBEGL().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A749 RID: 42825 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog CODPMNHHPLN()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog PFEJIEFDAMI()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void KJLEGMFNOHC()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A74C RID: 42828 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void MAGHKABJMLK(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A74D RID: 42829 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog ABGKNKGNCGF()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A74E RID: 42830 RVA: 0x004AED9C File Offset: 0x004ACF9C
		private void OFJOPKEJLCP()
		{
			if (this.HAFPGBLHGKN() != null)
			{
				this.PPIBCOJPBGJ().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A74F RID: 42831 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog EJCADBMFCGE()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A750 RID: 42832 RVA: 0x004AEDB7 File Offset: 0x004ACFB7
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.ANCIMKLOHFH != null)
			{
				this.ANCIMKLOHFH.FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A751 RID: 42833 RVA: 0x004AED0C File Offset: 0x004ACF0C
		private IEnumerator EKLMGENBKEC()
		{
			if (this.ANCIMKLOHFH != null && this.ANCIMKLOHFH.KJLHOBIAFKM)
			{
				yield return new WaitForEndOfFrame();
				if (this.ANCIMKLOHFH != null)
				{
					this.ANCIMKLOHFH.OEEFHDICHJD();
				}
			}
			yield break;
		}

		// Token: 0x0600A752 RID: 42834 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void FIPCHHKLPPK(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A753 RID: 42835 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void MFDIEEHMBLC(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A754 RID: 42836 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog AINGPMHLMFP()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A755 RID: 42837 RVA: 0x004AEDD4 File Offset: 0x004ACFD4
		private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.JAACMIDDFDC() != null)
			{
				this.MEALLNBALAE().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A756 RID: 42838 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog JAACMIDDFDC()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A757 RID: 42839 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void BDPMIOIKKBL()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A758 RID: 42840 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog OEFEOEHPDHL()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A759 RID: 42841 RVA: 0x004AEDF1 File Offset: 0x004ACFF1
		private void BMJCNICLDEK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.JAACMIDDFDC() != null)
			{
				this.PPIBCOJPBGJ().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A75A RID: 42842 RVA: 0x004AEE0E File Offset: 0x004AD00E
		private void IBJIDHEJGBN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.PPIBCOJPBGJ() != null)
			{
				this.OFBCDCDNACM().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A75B RID: 42843 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void EOKINDOLCHD(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void JKHAOPIEPAL()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A75D RID: 42845 RVA: 0x004AEE2B File Offset: 0x004AD02B
		private void NNCHCDCPJAG()
		{
			if (this.CODPMNHHPLN() != null)
			{
				this.EJCADBMFCGE().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A75E RID: 42846 RVA: 0x004AEE46 File Offset: 0x004AD046
		private void GJKMDLBDNPE()
		{
			if (this.NIKPPHFLAGK() != null)
			{
				this.ODBLPLANLJD().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void ADNPLJACLCH(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x004AED36 File Offset: 0x004ACF36
		private IEnumerator OBBCDABFEGD()
		{
			VolumetricFogPreT.OJIPEJPNBHK ojipejpnbhk = new VolumetricFogPreT.OJIPEJPNBHK(1);
			ojipejpnbhk.AENJLLPLILM = this;
			return ojipejpnbhk;
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x004AEE61 File Offset: 0x004AD061
		private void CIJGCMIIPPF()
		{
			if (this.HJFIKNCJCCA() != null)
			{
				this.IJEJINPNOBB().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x004AEE7C File Offset: 0x004AD07C
		private void ICNDELBKLLE()
		{
			if (this.MEALLNBALAE() != null)
			{
				this.MEALLNBALAE().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A763 RID: 42851 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog OFBCDCDNACM()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A764 RID: 42852 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void FENNJMFHFGD()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A765 RID: 42853 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog NIKPPHFLAGK()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A766 RID: 42854 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void MDIEMEAABKJ()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A767 RID: 42855 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog PPIBCOJPBGJ()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A768 RID: 42856 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog MEALLNBALAE()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A769 RID: 42857 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog JDCHIDALGPI()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A76A RID: 42858 RVA: 0x004AEE97 File Offset: 0x004AD097
		private void FBCLHGABFGL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.PPIBCOJPBGJ() != null)
			{
				this.ODBLPLANLJD().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A76B RID: 42859 RVA: 0x004AEEB4 File Offset: 0x004AD0B4
		private void JILLKNOPGPE()
		{
			if (this.JAACMIDDFDC() != null)
			{
				this.IJEJINPNOBB().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A76C RID: 42860 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog GJHDNNKFDCO()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A76D RID: 42861 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void BJFAEEHJGLN(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A76E RID: 42862 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void BOJIFPNLACG()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A76F RID: 42863 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog PJDMEFLBPFC()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A770 RID: 42864 RVA: 0x004AEECF File Offset: 0x004AD0CF
		private void OOCKNMICKOE()
		{
			if (this.CDEMFAIBEGL() != null)
			{
				this.FHNFAONOPBB().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A771 RID: 42865 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void CKOKMIAAMDD()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A772 RID: 42866 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog EAJHKHHHPNE()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog JIIAMAFKJOL()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A774 RID: 42868 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void MAPJPPLMIGK()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A775 RID: 42869 RVA: 0x004AEEEA File Offset: 0x004AD0EA
		private void KCMLFPCOEPG()
		{
			if (this.OEFEOEHPDHL() != null)
			{
				this.JJHKFOJPNDE().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A776 RID: 42870 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog IJEJINPNOBB()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A777 RID: 42871 RVA: 0x004AED36 File Offset: 0x004ACF36
		private IEnumerator HNAJFJNBBEK()
		{
			VolumetricFogPreT.OJIPEJPNBHK ojipejpnbhk = new VolumetricFogPreT.OJIPEJPNBHK(1);
			ojipejpnbhk.AENJLLPLILM = this;
			return ojipejpnbhk;
		}

		// Token: 0x0600A778 RID: 42872 RVA: 0x004AED36 File Offset: 0x004ACF36
		private IEnumerator GKCAKGKHAKE()
		{
			VolumetricFogPreT.OJIPEJPNBHK ojipejpnbhk = new VolumetricFogPreT.OJIPEJPNBHK(1);
			ojipejpnbhk.AENJLLPLILM = this;
			return ojipejpnbhk;
		}

		// Token: 0x0600A779 RID: 42873 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog ODBLPLANLJD()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A77A RID: 42874 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog FHNFAONOPBB()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A77B RID: 42875 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void MALBCHIGGPP(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A77C RID: 42876 RVA: 0x004AEF05 File Offset: 0x004AD105
		private void PHDDKBOHMKN()
		{
			if (this.MEALLNBALAE() != null)
			{
				this.CODPMNHHPLN().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A77D RID: 42877 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void PIJBEHLOKCE(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A77E RID: 42878 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void JHJBAGAOBNL(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A77F RID: 42879 RVA: 0x004AEF20 File Offset: 0x004AD120
		private void BPCBJBDPKPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.HJFIKNCJCCA() != null)
			{
				this.EAJHKHHHPNE().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A780 RID: 42880 RVA: 0x004AEF3D File Offset: 0x004AD13D
		private void LOPLBCLLCID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.ODBLPLANLJD() != null)
			{
				this.JDCHIDALGPI().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x004AEF5A File Offset: 0x004AD15A
		private void CCLNHACPHAH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.CDEMFAIBEGL() != null)
			{
				this.AINGPMHLMFP().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A782 RID: 42882 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void DFHKIIDFNIO()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog OOEOOBMJCCK()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void IBCHLJLLCMP()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog GOHCPFNIHBK()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void LKCHOLDNMAJ(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x004AEF77 File Offset: 0x004AD177
		private void JANBJOLLAKC()
		{
			if (this.GJHDNNKFDCO() != null)
			{
				this.JAACMIDDFDC().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void KGOGNKPEBPF(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x004AEF92 File Offset: 0x004AD192
		private void DJMCCCHACDO()
		{
			if (this.JFAKIGIIIPG() != null)
			{
				this.JJHKFOJPNDE().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A78A RID: 42890 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void MKBCCHJKMCC(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A78B RID: 42891 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void KMPFCELPMPA()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A78C RID: 42892 RVA: 0x004AED0C File Offset: 0x004ACF0C
		private IEnumerator KMFBINHFJDM()
		{
			if (this.ANCIMKLOHFH != null && this.ANCIMKLOHFH.KJLHOBIAFKM)
			{
				yield return new WaitForEndOfFrame();
				if (this.ANCIMKLOHFH != null)
				{
					this.ANCIMKLOHFH.OEEFHDICHJD();
				}
			}
			yield break;
		}

		// Token: 0x0600A78D RID: 42893 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void NCLPONLKEMI()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A78E RID: 42894 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void JIKBINDAKLJ()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A78F RID: 42895 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog MBGAFPCPMJJ()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A790 RID: 42896 RVA: 0x004AEFAD File Offset: 0x004AD1AD
		private void OCGBHGKEOKJ()
		{
			if (this.JAACMIDDFDC() != null)
			{
				this.CODPMNHHPLN().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A791 RID: 42897 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void CAKJANIJDPF()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A792 RID: 42898 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog IGDHEFMFLMB()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A793 RID: 42899 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void MDKFFBABJFE(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x004AED36 File Offset: 0x004ACF36
		private IEnumerator GJEGBPMANIH()
		{
			VolumetricFogPreT.OJIPEJPNBHK ojipejpnbhk = new VolumetricFogPreT.OJIPEJPNBHK(1);
			ojipejpnbhk.AENJLLPLILM = this;
			return ojipejpnbhk;
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog BLOGFECIIFN()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A796 RID: 42902 RVA: 0x004AED62 File Offset: 0x004ACF62
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.IGDHEFMFLMB() != null)
			{
				this.ANCIMKLOHFH.FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void ABMNAMHBMDA(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x004AED36 File Offset: 0x004ACF36
		private IEnumerator CFOBHECHHPO()
		{
			VolumetricFogPreT.OJIPEJPNBHK ojipejpnbhk = new VolumetricFogPreT.OJIPEJPNBHK(1);
			ojipejpnbhk.AENJLLPLILM = this;
			return ojipejpnbhk;
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x004AEFC8 File Offset: 0x004AD1C8
		private void LLIDCMOMECE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.JAACMIDDFDC() != null)
			{
				this.IGDHEFMFLMB().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x004AEFE5 File Offset: 0x004AD1E5
		private void LGKJKHBJFCP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.CODPMNHHPLN() != null)
			{
				this.MEALLNBALAE().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog HJFIKNCJCCA()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A79D RID: 42909 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog KLIHAMGPDND()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A79E RID: 42910 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void MBHJDHPIKCO()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A79F RID: 42911 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog CDEMFAIBEGL()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x004AF002 File Offset: 0x004AD202
		private void CDPCPJBDEDD()
		{
			if (this.JIIAMAFKJOL() != null)
			{
				this.BLOGFECIIFN().PIHLDMFCHNP();
			}
		}

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog JFAKIGIIIPG()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void NIACDIEDEKE(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x004AED0C File Offset: 0x004ACF0C
		private IEnumerator OnPostRender()
		{
			if (this.ANCIMKLOHFH != null && this.ANCIMKLOHFH.KJLHOBIAFKM)
			{
				yield return new WaitForEndOfFrame();
				if (this.ANCIMKLOHFH != null)
				{
					this.ANCIMKLOHFH.OEEFHDICHJD();
				}
			}
			yield break;
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x004AF01D File Offset: 0x004AD21D
		private void HKIFJANIGPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.JDCHIDALGPI() != null)
			{
				this.NIKPPHFLAGK().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A7A5 RID: 42917 RVA: 0x004AF03A File Offset: 0x004AD23A
		private void GGIKBEHBAPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.IJEJINPNOBB() != null)
			{
				this.IGDHEFMFLMB().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x004AF057 File Offset: 0x004AD257
		private void ENEONPFCPMP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.MEALLNBALAE() != null)
			{
				this.AINGPMHLMFP().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A7A7 RID: 42919 RVA: 0x004AF074 File Offset: 0x004AD274
		private void NBJKFLNHFOF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.HJFIKNCJCCA() != null)
			{
				this.JDCHIDALGPI().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A7A8 RID: 42920 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void AFDAPEHBGHD()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A7A9 RID: 42921 RVA: 0x004AED0C File Offset: 0x004ACF0C
		private IEnumerator BAANMKMHAHJ()
		{
			if (this.ANCIMKLOHFH != null && this.ANCIMKLOHFH.KJLHOBIAFKM)
			{
				yield return new WaitForEndOfFrame();
				if (this.ANCIMKLOHFH != null)
				{
					this.ANCIMKLOHFH.OEEFHDICHJD();
				}
			}
			yield break;
		}

		// Token: 0x0600A7AA RID: 42922 RVA: 0x004AED03 File Offset: 0x004ACF03
		public void AFDKBKPAGLI(VolumetricFog DCCPCBLODIG)
		{
			this.<BOJFMPOAEIJ>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600A7AB RID: 42923 RVA: 0x004AED0C File Offset: 0x004ACF0C
		private IEnumerator KCJHHLNJFMI()
		{
			if (this.ANCIMKLOHFH != null && this.ANCIMKLOHFH.KJLHOBIAFKM)
			{
				yield return new WaitForEndOfFrame();
				if (this.ANCIMKLOHFH != null)
				{
					this.ANCIMKLOHFH.OEEFHDICHJD();
				}
			}
			yield break;
		}

		// Token: 0x0600A7AC RID: 42924 RVA: 0x004AEC89 File Offset: 0x004ACE89
		public VolumetricFog JJHKFOJPNDE()
		{
			return this.<BOJFMPOAEIJ>k__BackingField;
		}

		// Token: 0x0600A7AD RID: 42925 RVA: 0x004AF091 File Offset: 0x004AD291
		private void DHBJPMCMCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.OFBCDCDNACM() != null)
			{
				this.IJEJINPNOBB().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A7AE RID: 42926 RVA: 0x004AF0AE File Offset: 0x004AD2AE
		private void KEMLMHGOHEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.KLIHAMGPDND() != null)
			{
				this.JFAKIGIIIPG().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A7AF RID: 42927 RVA: 0x004AED36 File Offset: 0x004ACF36
		private IEnumerator CNCHKJAFPFA()
		{
			VolumetricFogPreT.OJIPEJPNBHK ojipejpnbhk = new VolumetricFogPreT.OJIPEJPNBHK(1);
			ojipejpnbhk.AENJLLPLILM = this;
			return ojipejpnbhk;
		}

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x004AF0CB File Offset: 0x004AD2CB
		private void NJLOPOBJHAC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.OFBCDCDNACM() != null)
			{
				this.BLOGFECIIFN().FMNMOMDOLGA(JONJODLFAEN, OKIIDHIJBEA);
			}
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x004AED0C File Offset: 0x004ACF0C
		private IEnumerator AMAMLEMHNOJ()
		{
			if (this.ANCIMKLOHFH != null && this.ANCIMKLOHFH.KJLHOBIAFKM)
			{
				yield return new WaitForEndOfFrame();
				if (this.ANCIMKLOHFH != null)
				{
					this.ANCIMKLOHFH.OEEFHDICHJD();
				}
			}
			yield break;
		}

		// Token: 0x0600A7B2 RID: 42930 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void MJNHCAJGBAF()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}

		// Token: 0x0600A7B3 RID: 42931 RVA: 0x004AE9A3 File Offset: 0x004ACBA3
		public void MNAAMFFMEAN()
		{
			UnityEngine.Object.DestroyImmediate(this);
		}
	}
}
