using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000324 RID: 804
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("")]
	public class ImageEffectBase : MonoBehaviour
	{
		// Token: 0x0600B7EE RID: 47086 RVA: 0x0051E55A File Offset: 0x0051C75A
		protected virtual void MKNPFMEMOJO()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B7EF RID: 47087 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void NIOMOLMCNOO()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B7F0 RID: 47088 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void EHKCHPFDNCA()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B7F1 RID: 47089 RVA: 0x0051E5A6 File Offset: 0x0051C7A6
		protected virtual void CKGPEFOKKNL()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600B7F2 RID: 47090 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void BNOLDFLILJA()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B7F3 RID: 47091 RVA: 0x0051E5D8 File Offset: 0x0051C7D8
		protected Material OEBEDLDCPIN()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B7F4 RID: 47092 RVA: 0x0051E55A File Offset: 0x0051C75A
		protected virtual void CBLGFOFHNPJ()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B7F5 RID: 47093 RVA: 0x0051E5A6 File Offset: 0x0051C7A6
		protected virtual void LMEJKAEIDCO()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600B7F6 RID: 47094 RVA: 0x0051E60C File Offset: 0x0051C80C
		protected Material NMIDGHFFOBD()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags)116;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B7F7 RID: 47095 RVA: 0x0051E5A6 File Offset: 0x0051C7A6
		protected virtual void FPLHODJCJDO()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600B7F8 RID: 47096 RVA: 0x0051E640 File Offset: 0x0051C840
		protected Material COCHPLKIEGO()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B7F9 RID: 47097 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void OnDisable()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B7FA RID: 47098 RVA: 0x0051E674 File Offset: 0x0051C874
		protected Material JFIFDPEHNHO()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags)82;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B7FB RID: 47099 RVA: 0x0051E55A File Offset: 0x0051C75A
		protected virtual void PNJHMJNFPLP()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B7FC RID: 47100 RVA: 0x0051E5A6 File Offset: 0x0051C7A6
		protected virtual void CLHGHANANNL()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600B7FD RID: 47101 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void PHIACAJNNIG()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B7FE RID: 47102 RVA: 0x0051E6A8 File Offset: 0x0051C8A8
		protected Material IOIGFMMJKNA()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags)(-81);
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B7FF RID: 47103 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void GPCIBDPEAAE()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B800 RID: 47104 RVA: 0x0051E6DC File Offset: 0x0051C8DC
		protected Material FFADACJLLLI()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags)99;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B801 RID: 47105 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void JGHJOBDKDKM()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B802 RID: 47106 RVA: 0x0051E710 File Offset: 0x0051C910
		protected Material FIJPFGKEFLJ()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags)100;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B803 RID: 47107 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void APJACOJADAF()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B804 RID: 47108 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void KIMKMJMMLLB()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B805 RID: 47109 RVA: 0x0051E5A6 File Offset: 0x0051C7A6
		protected virtual void DDEBDCGNCPC()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600B806 RID: 47110 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void PCKEAEAHAKG()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B807 RID: 47111 RVA: 0x0051E744 File Offset: 0x0051C944
		protected virtual void KIEIPFFEDHC()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B808 RID: 47112 RVA: 0x0051E55A File Offset: 0x0051C75A
		protected virtual void AIFIEAGFIMM()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B809 RID: 47113 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void IDLLAMOBGGO()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B80A RID: 47114 RVA: 0x0051E744 File Offset: 0x0051C944
		protected virtual void BJHGPFGBFKF()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B80B RID: 47115 RVA: 0x0051E5A6 File Offset: 0x0051C7A6
		protected virtual void FJGIBCHABIG()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600B80C RID: 47116 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void EACKHNENAML()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B80D RID: 47117 RVA: 0x0051E55A File Offset: 0x0051C75A
		protected virtual void CPNOBMNKPNC()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600B80E RID: 47118 RVA: 0x0051E776 File Offset: 0x0051C976
		protected Material MHNAJNGGDFJ
		{
			get
			{
				if (this.BHHEHMIFMBD == null)
				{
					this.BHHEHMIFMBD = new Material(this.shader);
					this.BHHEHMIFMBD.hideFlags = HideFlags.HideAndDontSave;
				}
				return this.BHHEHMIFMBD;
			}
		}

		// Token: 0x0600B80F RID: 47119 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void LNEJPGDHJOJ()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B810 RID: 47120 RVA: 0x0051E7AA File Offset: 0x0051C9AA
		protected Material LHMLPBEDDOG()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags)73;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B811 RID: 47121 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void DENHKOPGLDK()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B812 RID: 47122 RVA: 0x0051E7DE File Offset: 0x0051C9DE
		protected Material ALIMBELCEAL()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B813 RID: 47123 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void CBAJAFAPINE()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B814 RID: 47124 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void LNNKANCIIFM()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B815 RID: 47125 RVA: 0x0051E744 File Offset: 0x0051C944
		protected virtual void EFJDBBDMPMC()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B816 RID: 47126 RVA: 0x0051E5A6 File Offset: 0x0051C7A6
		protected virtual void FIJKDFIMELM()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600B817 RID: 47127 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void ONPDNGNNBIG()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B818 RID: 47128 RVA: 0x0051E744 File Offset: 0x0051C944
		protected virtual void EHDPACPIBNF()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B819 RID: 47129 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void ACJNCDAHJDE()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B81A RID: 47130 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void ACEEIODKKBE()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B81B RID: 47131 RVA: 0x0051E744 File Offset: 0x0051C944
		protected virtual void MCHAAIIHOKD()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B81C RID: 47132 RVA: 0x0051E812 File Offset: 0x0051CA12
		protected Material EDJPFAGCMOF()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags)96;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B81D RID: 47133 RVA: 0x0051E55A File Offset: 0x0051C75A
		protected virtual void NCALLFHEAGJ()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B81E RID: 47134 RVA: 0x0051E846 File Offset: 0x0051CA46
		protected virtual void AOCDDBNBADJ()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600B81F RID: 47135 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void GBAEKFJBEFM()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B820 RID: 47136 RVA: 0x0051E878 File Offset: 0x0051CA78
		protected Material AGEHKELMAFL()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B821 RID: 47137 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void EIDIHAJDMCI()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B822 RID: 47138 RVA: 0x0051E55A File Offset: 0x0051C75A
		protected virtual void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B823 RID: 47139 RVA: 0x0051E8AC File Offset: 0x0051CAAC
		protected Material MFJAILMGELI()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags)117;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B824 RID: 47140 RVA: 0x0051E55A File Offset: 0x0051C75A
		protected virtual void PFNPOHMMJDN()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B825 RID: 47141 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void PIPJPGGEFOL()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B826 RID: 47142 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void DFLLLNDKNBB()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B827 RID: 47143 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void IFJEIFBOPCI()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B828 RID: 47144 RVA: 0x0051E8E0 File Offset: 0x0051CAE0
		protected Material DNCJDOFOENA()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = HideFlags.NotEditable;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B829 RID: 47145 RVA: 0x0051E914 File Offset: 0x0051CB14
		protected Material DGBBALICMFF()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = ~HideFlags.DontSaveInBuild;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B82A RID: 47146 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void FGHHAIDJNMM()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B82B RID: 47147 RVA: 0x0051E948 File Offset: 0x0051CB48
		protected Material ILEJDOCOINE()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags)104;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B82D RID: 47149 RVA: 0x0051E744 File Offset: 0x0051C944
		protected virtual void ANHOOJFEJJE()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B82E RID: 47150 RVA: 0x0051E97C File Offset: 0x0051CB7C
		protected Material OJKOJOFCLAG()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = HideFlags.DontUnloadUnusedAsset;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B82F RID: 47151 RVA: 0x0051E744 File Offset: 0x0051C944
		protected virtual void GDIMBBBPIHI()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B830 RID: 47152 RVA: 0x0051E9B0 File Offset: 0x0051CBB0
		protected Material HGIJAMABJMC()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = (HideFlags)94;
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B831 RID: 47153 RVA: 0x0051E846 File Offset: 0x0051CA46
		protected virtual void CAJLCEPLKJG()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600B832 RID: 47154 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void LKGIJBLNANI()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B833 RID: 47155 RVA: 0x0051E55A File Offset: 0x0051C75A
		protected virtual void NOKJMMDMJNO()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B834 RID: 47156 RVA: 0x0051E55A File Offset: 0x0051C75A
		protected virtual void DOHJPDNKALP()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.shader || !this.shader.isSupported)
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600B835 RID: 47157 RVA: 0x0051E9E4 File Offset: 0x0051CBE4
		protected Material DIDMFKOIPCF()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B836 RID: 47158 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void EILDKNMOKBB()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x0600B837 RID: 47159 RVA: 0x0051EA18 File Offset: 0x0051CC18
		protected Material DJDKHEANJNM()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = new Material(this.shader);
				this.BHHEHMIFMBD.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600B838 RID: 47160 RVA: 0x0051E58C File Offset: 0x0051C78C
		protected virtual void MKLCOEALFBI()
		{
			if (this.BHHEHMIFMBD)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
		}

		// Token: 0x04001807 RID: 6151
		public Shader shader;

		// Token: 0x04001808 RID: 6152
		private Material BHHEHMIFMBD;
	}
}
