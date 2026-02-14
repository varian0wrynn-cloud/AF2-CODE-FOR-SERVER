using System;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000549 RID: 1353
	[Serializable]
	public class ColorGradingModel : PostProcessingModel
	{
		// Token: 0x06011D87 RID: 73095 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture IJMCIPCGNNI()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x06011D88 RID: 73096 RVA: 0x007EA972 File Offset: 0x007E8B72
		public void EIHBOFHHOAC(ColorGradingModel.Settings DCCPCBLODIG)
		{
			this.m_Settings = DCCPCBLODIG;
			this.GIBDKLENALN();
		}

		// Token: 0x06011D89 RID: 73097 RVA: 0x007EA981 File Offset: 0x007E8B81
		public virtual void DPMLDBFNACB()
		{
			this.FPBGFHJGGNJ(false);
		}

		// Token: 0x06011D8A RID: 73098 RVA: 0x007EA98A File Offset: 0x007E8B8A
		public virtual void OBGILMEDPAC()
		{
			this.isDirty = false;
		}

		// Token: 0x06011D8B RID: 73099 RVA: 0x007EA993 File Offset: 0x007E8B93
		public bool PMAPKCLKOEJ()
		{
			return this.<isDirty>k__BackingField;
		}

		// Token: 0x06011D8C RID: 73100 RVA: 0x007EA99B File Offset: 0x007E8B9B
		public virtual void LAAKOMDMBKK()
		{
			this.m_Settings = ColorGradingModel.Settings.MDDBLMDKDAO();
			this.GIBDKLENALN();
		}

		// Token: 0x06011D8D RID: 73101 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture PLCJLFMMBEB()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x06011D8E RID: 73102 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture GINKDDBCOEF()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x06011D8F RID: 73103 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture BFPOMDOBKEC()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06011DD4 RID: 73172 RVA: 0x007EA96A File Offset: 0x007E8B6A
		// (set) Token: 0x06011D90 RID: 73104 RVA: 0x007EA9AE File Offset: 0x007E8BAE
		public RenderTexture bakedLut { get; internal set; }

		// Token: 0x06011D91 RID: 73105 RVA: 0x007EA972 File Offset: 0x007E8B72
		public void CKFGDLGJIGF(ColorGradingModel.Settings DCCPCBLODIG)
		{
			this.m_Settings = DCCPCBLODIG;
			this.GIBDKLENALN();
		}

		// Token: 0x06011D92 RID: 73106 RVA: 0x007EA9B7 File Offset: 0x007E8BB7
		public virtual void EFAJNGMOOFP()
		{
			this.JBFJELEIOLC(true);
		}

		// Token: 0x06011D93 RID: 73107 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture MPBMAADCHBI()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06011DDC RID: 73180 RVA: 0x007EAA4C File Offset: 0x007E8C4C
		// (set) Token: 0x06011D94 RID: 73108 RVA: 0x007EA972 File Offset: 0x007E8B72
		public ColorGradingModel.Settings settings
		{
			get
			{
				return this.m_Settings;
			}
			set
			{
				this.m_Settings = value;
				this.GIBDKLENALN();
			}
		}

		// Token: 0x06011D95 RID: 73109 RVA: 0x007EA9C0 File Offset: 0x007E8BC0
		public virtual void EPLEHFCNKDJ()
		{
			this.m_Settings = ColorGradingModel.Settings.MJLLLKFIDOE();
			this.GIBDKLENALN();
		}

		// Token: 0x06011D96 RID: 73110 RVA: 0x007EA98A File Offset: 0x007E8B8A
		public virtual void MECFBGPPHEL()
		{
			this.isDirty = false;
		}

		// Token: 0x06011D97 RID: 73111 RVA: 0x007EA972 File Offset: 0x007E8B72
		public void KHEABCCDEFA(ColorGradingModel.Settings DCCPCBLODIG)
		{
			this.m_Settings = DCCPCBLODIG;
			this.GIBDKLENALN();
		}

		// Token: 0x06011D98 RID: 73112 RVA: 0x007EA9D3 File Offset: 0x007E8BD3
		public virtual void MFFJBEGHNJL()
		{
			this.m_Settings = ColorGradingModel.Settings.MEFEDCEEAMK();
			this.GIBDKLENALN();
		}

		// Token: 0x06011D99 RID: 73113 RVA: 0x007EA9E6 File Offset: 0x007E8BE6
		public virtual void CNJMDNGMKJL()
		{
			this.FPBGFHJGGNJ(true);
		}

		// Token: 0x06011D9A RID: 73114 RVA: 0x007EA9EF File Offset: 0x007E8BEF
		public virtual void EGADMJMBCCK()
		{
			this.m_Settings = ColorGradingModel.Settings.CGGMKBADCBM();
			this.GIBDKLENALN();
		}

		// Token: 0x06011D9B RID: 73115 RVA: 0x007EA9B7 File Offset: 0x007E8BB7
		public virtual void CDICGENMEED()
		{
			this.JBFJELEIOLC(true);
		}

		// Token: 0x06011D9C RID: 73116 RVA: 0x007EAA02 File Offset: 0x007E8C02
		internal void JBFJELEIOLC(bool DCCPCBLODIG)
		{
			this.<isDirty>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011D9D RID: 73117 RVA: 0x007EA993 File Offset: 0x007E8B93
		public bool JPKMBLLEHCC()
		{
			return this.<isDirty>k__BackingField;
		}

		// Token: 0x06011D9E RID: 73118 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture HCHGDJADIEB()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x06011D9F RID: 73119 RVA: 0x007EAA0B File Offset: 0x007E8C0B
		public virtual void FKIFJDCEKAM()
		{
			this.JBFJELEIOLC(false);
		}

		// Token: 0x06011DA0 RID: 73120 RVA: 0x007EAA14 File Offset: 0x007E8C14
		public virtual void LCEKDCDNBMD()
		{
			this.isDirty = true;
		}

		// Token: 0x06011DA1 RID: 73121 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture GAGGCMIJOPJ()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06011DD5 RID: 73173 RVA: 0x007EA993 File Offset: 0x007E8B93
		// (set) Token: 0x06011DA2 RID: 73122 RVA: 0x007EAA02 File Offset: 0x007E8C02
		public bool isDirty { get; internal set; }

		// Token: 0x06011DA3 RID: 73123 RVA: 0x007EA972 File Offset: 0x007E8B72
		public void IONIOEJEANO(ColorGradingModel.Settings DCCPCBLODIG)
		{
			this.m_Settings = DCCPCBLODIG;
			this.GIBDKLENALN();
		}

		// Token: 0x06011DA4 RID: 73124 RVA: 0x007EA98A File Offset: 0x007E8B8A
		public virtual void HGBEFLOFBCP()
		{
			this.isDirty = false;
		}

		// Token: 0x06011DA5 RID: 73125 RVA: 0x007EAA1D File Offset: 0x007E8C1D
		public virtual void JGGPMAKAKNG()
		{
			this.HBFELAMABLM(false);
		}

		// Token: 0x06011DA6 RID: 73126 RVA: 0x007EAA02 File Offset: 0x007E8C02
		internal void FPBGFHJGGNJ(bool DCCPCBLODIG)
		{
			this.<isDirty>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011DA7 RID: 73127 RVA: 0x007EA9AE File Offset: 0x007E8BAE
		internal void DLLNGNIOJCP(RenderTexture DCCPCBLODIG)
		{
			this.<bakedLut>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011DA8 RID: 73128 RVA: 0x007EA9AE File Offset: 0x007E8BAE
		internal void ACMDCNEAEBE(RenderTexture DCCPCBLODIG)
		{
			this.<bakedLut>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011DA9 RID: 73129 RVA: 0x007EAA26 File Offset: 0x007E8C26
		public virtual void NMMHIFFIFAL()
		{
			this.m_Settings = ColorGradingModel.Settings.GDKPNHJPBKJ();
			this.GIBDKLENALN();
		}

		// Token: 0x06011DAA RID: 73130 RVA: 0x007EAA02 File Offset: 0x007E8C02
		internal void MCGPIMGBGCA(bool DCCPCBLODIG)
		{
			this.<isDirty>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011DAB RID: 73131 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture HENONLJPBJE()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x06011DAC RID: 73132 RVA: 0x007EAA39 File Offset: 0x007E8C39
		public virtual void FOFNPGIHJGD()
		{
			this.m_Settings = ColorGradingModel.Settings.COINKHKLJAP();
			this.GIBDKLENALN();
		}

		// Token: 0x06011DAD RID: 73133 RVA: 0x007EA9AE File Offset: 0x007E8BAE
		internal void KHOJGMMFPNK(RenderTexture DCCPCBLODIG)
		{
			this.<bakedLut>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011DAE RID: 73134 RVA: 0x007EA972 File Offset: 0x007E8B72
		public void AHHIPDHIJPH(ColorGradingModel.Settings DCCPCBLODIG)
		{
			this.m_Settings = DCCPCBLODIG;
			this.GIBDKLENALN();
		}

		// Token: 0x06011DAF RID: 73135 RVA: 0x007EAA14 File Offset: 0x007E8C14
		public virtual void GOHKMKGHLEH()
		{
			this.isDirty = true;
		}

		// Token: 0x06011DB0 RID: 73136 RVA: 0x007EA993 File Offset: 0x007E8B93
		public bool BCLGNIILOFA()
		{
			return this.<isDirty>k__BackingField;
		}

		// Token: 0x06011DB1 RID: 73137 RVA: 0x007EA993 File Offset: 0x007E8B93
		public bool LMKBOCHOFPB()
		{
			return this.<isDirty>k__BackingField;
		}

		// Token: 0x06011DB2 RID: 73138 RVA: 0x007EA9D3 File Offset: 0x007E8BD3
		public virtual void OCHJAFNGOHF()
		{
			this.m_Settings = ColorGradingModel.Settings.MEFEDCEEAMK();
			this.GIBDKLENALN();
		}

		// Token: 0x06011DB3 RID: 73139 RVA: 0x007EAA4C File Offset: 0x007E8C4C
		public ColorGradingModel.Settings DGMJHJDFFAA()
		{
			return this.m_Settings;
		}

		// Token: 0x06011DB4 RID: 73140 RVA: 0x007EAA14 File Offset: 0x007E8C14
		public virtual void HDEPOFLNFDM()
		{
			this.isDirty = true;
		}

		// Token: 0x06011DB5 RID: 73141 RVA: 0x007EA993 File Offset: 0x007E8B93
		public bool IDFDELBMKLH()
		{
			return this.<isDirty>k__BackingField;
		}

		// Token: 0x06011DB6 RID: 73142 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture EDJNEMPJCDH()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x06011DB7 RID: 73143 RVA: 0x007EAA4C File Offset: 0x007E8C4C
		public ColorGradingModel.Settings AEIDMBILAPI()
		{
			return this.m_Settings;
		}

		// Token: 0x06011DB8 RID: 73144 RVA: 0x007EA972 File Offset: 0x007E8B72
		public void FDKBLADHGLH(ColorGradingModel.Settings DCCPCBLODIG)
		{
			this.m_Settings = DCCPCBLODIG;
			this.GIBDKLENALN();
		}

		// Token: 0x06011DB9 RID: 73145 RVA: 0x007EA9D3 File Offset: 0x007E8BD3
		public virtual void MLOPPPBPHNJ()
		{
			this.m_Settings = ColorGradingModel.Settings.MEFEDCEEAMK();
			this.GIBDKLENALN();
		}

		// Token: 0x06011DBA RID: 73146 RVA: 0x007EAA14 File Offset: 0x007E8C14
		public override void GIBDKLENALN()
		{
			this.isDirty = true;
		}

		// Token: 0x06011DBB RID: 73147 RVA: 0x007EA993 File Offset: 0x007E8B93
		public bool IKHEAOOBOJP()
		{
			return this.<isDirty>k__BackingField;
		}

		// Token: 0x06011DBC RID: 73148 RVA: 0x007EA98A File Offset: 0x007E8B8A
		public virtual void BKCMGFLHEBB()
		{
			this.isDirty = false;
		}

		// Token: 0x06011DBD RID: 73149 RVA: 0x007EAA4C File Offset: 0x007E8C4C
		public ColorGradingModel.Settings CIBNPGCPGPF()
		{
			return this.m_Settings;
		}

		// Token: 0x06011DBE RID: 73150 RVA: 0x007EA972 File Offset: 0x007E8B72
		public void OKJDEBPBOJD(ColorGradingModel.Settings DCCPCBLODIG)
		{
			this.m_Settings = DCCPCBLODIG;
			this.GIBDKLENALN();
		}

		// Token: 0x06011DBF RID: 73151 RVA: 0x007EAA4C File Offset: 0x007E8C4C
		public ColorGradingModel.Settings EBGFGEIIDNM()
		{
			return this.m_Settings;
		}

		// Token: 0x06011DC0 RID: 73152 RVA: 0x007EAA54 File Offset: 0x007E8C54
		public virtual void COIGADPCLOB()
		{
			this.m_Settings = ColorGradingModel.Settings.LNGBMOGJKGD();
			this.GIBDKLENALN();
		}

		// Token: 0x06011DC1 RID: 73153 RVA: 0x007EA993 File Offset: 0x007E8B93
		public bool PDAIELDJPAH()
		{
			return this.<isDirty>k__BackingField;
		}

		// Token: 0x06011DC2 RID: 73154 RVA: 0x007EAA67 File Offset: 0x007E8C67
		public virtual void BPBHECJMLPN()
		{
			this.m_Settings = ColorGradingModel.Settings.HMDLEIJHKEP();
			this.GIBDKLENALN();
		}

		// Token: 0x06011DC3 RID: 73155 RVA: 0x007EAA7A File Offset: 0x007E8C7A
		public virtual void AIHEKMKAIGM()
		{
			this.m_Settings = ColorGradingModel.Settings.NJJBBDIFPKH();
			this.GIBDKLENALN();
		}

		// Token: 0x06011DC4 RID: 73156 RVA: 0x007EAA8D File Offset: 0x007E8C8D
		public virtual void FKOENKDEHPB()
		{
			this.m_Settings = ColorGradingModel.Settings.MGIIIBAJNIE();
			this.GIBDKLENALN();
		}

		// Token: 0x06011DC5 RID: 73157 RVA: 0x007EA99B File Offset: 0x007E8B9B
		public virtual void DLPCDAIHLKP()
		{
			this.m_Settings = ColorGradingModel.Settings.MDDBLMDKDAO();
			this.GIBDKLENALN();
		}

		// Token: 0x06011DC6 RID: 73158 RVA: 0x007EAA02 File Offset: 0x007E8C02
		internal void HBFELAMABLM(bool DCCPCBLODIG)
		{
			this.<isDirty>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011DC7 RID: 73159 RVA: 0x007EA993 File Offset: 0x007E8B93
		public bool EMAGCIBBGJP()
		{
			return this.<isDirty>k__BackingField;
		}

		// Token: 0x06011DC8 RID: 73160 RVA: 0x007EAAA0 File Offset: 0x007E8CA0
		public virtual void DCLDMLEAPBB()
		{
			this.m_Settings = ColorGradingModel.Settings.DHCNIDFOOPO();
			this.GIBDKLENALN();
		}

		// Token: 0x06011DC9 RID: 73161 RVA: 0x007EAA4C File Offset: 0x007E8C4C
		public ColorGradingModel.Settings LIKDNAJFKMN()
		{
			return this.m_Settings;
		}

		// Token: 0x06011DCA RID: 73162 RVA: 0x007EA9AE File Offset: 0x007E8BAE
		internal void MCFNDPBAIGN(RenderTexture DCCPCBLODIG)
		{
			this.<bakedLut>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011DCB RID: 73163 RVA: 0x007EA972 File Offset: 0x007E8B72
		public void CLHNNJPMDBE(ColorGradingModel.Settings DCCPCBLODIG)
		{
			this.m_Settings = DCCPCBLODIG;
			this.GIBDKLENALN();
		}

		// Token: 0x06011DCC RID: 73164 RVA: 0x007EAAB3 File Offset: 0x007E8CB3
		public virtual void EICOAJNDBLJ()
		{
			this.m_Settings = ColorGradingModel.Settings.OCIMBHLOOGC();
			this.GIBDKLENALN();
		}

		// Token: 0x06011DCD RID: 73165 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture AEEFMEHPAKB()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x06011DCE RID: 73166 RVA: 0x007EA9AE File Offset: 0x007E8BAE
		internal void DKGLBFOPEJD(RenderTexture DCCPCBLODIG)
		{
			this.<bakedLut>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011DCF RID: 73167 RVA: 0x007EAA02 File Offset: 0x007E8C02
		internal void MHNGJJJINAA(bool DCCPCBLODIG)
		{
			this.<isDirty>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011DD0 RID: 73168 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture HOKEMPNMLCL()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x06011DD2 RID: 73170 RVA: 0x007EA96A File Offset: 0x007E8B6A
		public RenderTexture GCFDOFKPBBC()
		{
			return this.<bakedLut>k__BackingField;
		}

		// Token: 0x06011DD3 RID: 73171 RVA: 0x007EAAD9 File Offset: 0x007E8CD9
		public virtual void LPHDFMOHHJD()
		{
			this.MHNGJJJINAA(true);
		}

		// Token: 0x06011DD6 RID: 73174 RVA: 0x007EA9AE File Offset: 0x007E8BAE
		internal void JHCOEEJJPJF(RenderTexture DCCPCBLODIG)
		{
			this.<bakedLut>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011DD7 RID: 73175 RVA: 0x007EA9AE File Offset: 0x007E8BAE
		internal void JNJABOENMOH(RenderTexture DCCPCBLODIG)
		{
			this.<bakedLut>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x06011DD8 RID: 73176 RVA: 0x007EAAE2 File Offset: 0x007E8CE2
		public virtual void KMEDDCBFGBF()
		{
			this.HBFELAMABLM(true);
		}

		// Token: 0x06011DD9 RID: 73177 RVA: 0x007EA9B7 File Offset: 0x007E8BB7
		public virtual void HEJKABCDMEP()
		{
			this.JBFJELEIOLC(true);
		}

		// Token: 0x06011DDA RID: 73178 RVA: 0x007EAAEB File Offset: 0x007E8CEB
		public virtual void KDPMGODIKPB()
		{
			this.MCGPIMGBGCA(true);
		}

		// Token: 0x06011DDB RID: 73179 RVA: 0x007EAAF4 File Offset: 0x007E8CF4
		public override void Reset()
		{
			this.m_Settings = ColorGradingModel.Settings.defaultSettings;
			this.GIBDKLENALN();
		}

		// Token: 0x06011DDD RID: 73181 RVA: 0x007EAB07 File Offset: 0x007E8D07
		public virtual void NKJANLHLHIP()
		{
			this.m_Settings = ColorGradingModel.Settings.IGIKNGLDPJB();
			this.GIBDKLENALN();
		}

		// Token: 0x04002520 RID: 9504
		[SerializeField]
		private ColorGradingModel.Settings m_Settings = ColorGradingModel.Settings.defaultSettings;

		// Token: 0x0200054A RID: 1354
		public enum EDJOOGFJNGC
		{
			// Token: 0x04002524 RID: 9508
			None,
			// Token: 0x04002525 RID: 9509
			ACES,
			// Token: 0x04002526 RID: 9510
			Neutral
		}

		// Token: 0x0200054B RID: 1355
		[Serializable]
		public struct TonemappingSettings
		{
			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x06011DDE RID: 73182 RVA: 0x007EAB1C File Offset: 0x007E8D1C
			public static ColorGradingModel.TonemappingSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.TonemappingSettings
					{
						tonemapper = ColorGradingModel.EDJOOGFJNGC.Neutral,
						neutralBlackIn = 0.02f,
						neutralWhiteIn = 10f,
						neutralBlackOut = 0f,
						neutralWhiteOut = 10f,
						neutralWhiteLevel = 5.3f,
						neutralWhiteClip = 10f
					};
				}
			}

			// Token: 0x06011DDF RID: 73183 RVA: 0x007EAB84 File Offset: 0x007E8D84
			public static ColorGradingModel.TonemappingSettings GDKPNHJPBKJ()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.Neutral,
					neutralBlackIn = 1897f,
					neutralWhiteIn = 1540f,
					neutralBlackOut = 306f,
					neutralWhiteOut = 780f,
					neutralWhiteLevel = 575f,
					neutralWhiteClip = 1704f
				};
			}

			// Token: 0x06011DE0 RID: 73184 RVA: 0x007EABEC File Offset: 0x007E8DEC
			public static ColorGradingModel.TonemappingSettings HLLBKJENCLA()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.ACES,
					neutralBlackIn = 1503f,
					neutralWhiteIn = 1905f,
					neutralBlackOut = 216f,
					neutralWhiteOut = 116f,
					neutralWhiteLevel = 399f,
					neutralWhiteClip = 1350f
				};
			}

			// Token: 0x06011DE1 RID: 73185 RVA: 0x007EAC54 File Offset: 0x007E8E54
			public static ColorGradingModel.TonemappingSettings BNGFNAFFAME()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.None,
					neutralBlackIn = 185f,
					neutralWhiteIn = 1903f,
					neutralBlackOut = 1391f,
					neutralWhiteOut = 872f,
					neutralWhiteLevel = 82f,
					neutralWhiteClip = 1979f
				};
			}

			// Token: 0x06011DE2 RID: 73186 RVA: 0x007EACBC File Offset: 0x007E8EBC
			public static ColorGradingModel.TonemappingSettings MDDBLMDKDAO()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)8,
					neutralBlackIn = 1680f,
					neutralWhiteIn = 127f,
					neutralBlackOut = 202f,
					neutralWhiteOut = 1647f,
					neutralWhiteLevel = 1501f,
					neutralWhiteClip = 642f
				};
			}

			// Token: 0x06011DE3 RID: 73187 RVA: 0x007EAD24 File Offset: 0x007E8F24
			public static ColorGradingModel.TonemappingSettings COJPKDJKJAM()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)7,
					neutralBlackIn = 1437f,
					neutralWhiteIn = 1259f,
					neutralBlackOut = 1438f,
					neutralWhiteOut = 1259f,
					neutralWhiteLevel = 308f,
					neutralWhiteClip = 1107f
				};
			}

			// Token: 0x06011DE4 RID: 73188 RVA: 0x007EAD8C File Offset: 0x007E8F8C
			public static ColorGradingModel.TonemappingSettings AAPKKAPOLKH()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.ACES,
					neutralBlackIn = 957f,
					neutralWhiteIn = 918f,
					neutralBlackOut = 1908f,
					neutralWhiteOut = 108f,
					neutralWhiteLevel = 721f,
					neutralWhiteClip = 718f
				};
			}

			// Token: 0x06011DE5 RID: 73189 RVA: 0x007EADF4 File Offset: 0x007E8FF4
			public static ColorGradingModel.TonemappingSettings ADJNPGFJGJI()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)6,
					neutralBlackIn = 1658f,
					neutralWhiteIn = 1145f,
					neutralBlackOut = 495f,
					neutralWhiteOut = 78f,
					neutralWhiteLevel = 1316f,
					neutralWhiteClip = 1132f
				};
			}

			// Token: 0x06011DE6 RID: 73190 RVA: 0x007EAE5C File Offset: 0x007E905C
			public static ColorGradingModel.TonemappingSettings DELLGIGMFLC()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.Neutral,
					neutralBlackIn = 1586f,
					neutralWhiteIn = 1959f,
					neutralBlackOut = 1213f,
					neutralWhiteOut = 937f,
					neutralWhiteLevel = 1483f,
					neutralWhiteClip = 1589f
				};
			}

			// Token: 0x06011DE7 RID: 73191 RVA: 0x007EAEC4 File Offset: 0x007E90C4
			public static ColorGradingModel.TonemappingSettings MDDFLLOCDEA()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.None,
					neutralBlackIn = 311f,
					neutralWhiteIn = 1843f,
					neutralBlackOut = 242f,
					neutralWhiteOut = 1893f,
					neutralWhiteLevel = 300f,
					neutralWhiteClip = 1392f
				};
			}

			// Token: 0x06011DE8 RID: 73192 RVA: 0x007EAF2C File Offset: 0x007E912C
			public static ColorGradingModel.TonemappingSettings HMDLEIJHKEP()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)8,
					neutralBlackIn = 709f,
					neutralWhiteIn = 1108f,
					neutralBlackOut = 58f,
					neutralWhiteOut = 1283f,
					neutralWhiteLevel = 1254f,
					neutralWhiteClip = 930f
				};
			}

			// Token: 0x06011DE9 RID: 73193 RVA: 0x007EAF94 File Offset: 0x007E9194
			public static ColorGradingModel.TonemappingSettings LNGBMOGJKGD()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)8,
					neutralBlackIn = 637f,
					neutralWhiteIn = 1053f,
					neutralBlackOut = 312f,
					neutralWhiteOut = 1992f,
					neutralWhiteLevel = 943f,
					neutralWhiteClip = 1583f
				};
			}

			// Token: 0x06011DEA RID: 73194 RVA: 0x007EAFFC File Offset: 0x007E91FC
			public static ColorGradingModel.TonemappingSettings DHCNIDFOOPO()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.Neutral,
					neutralBlackIn = 711f,
					neutralWhiteIn = 1016f,
					neutralBlackOut = 1030f,
					neutralWhiteOut = 1532f,
					neutralWhiteLevel = 137f,
					neutralWhiteClip = 1654f
				};
			}

			// Token: 0x06011DEB RID: 73195 RVA: 0x007EB064 File Offset: 0x007E9264
			public static ColorGradingModel.TonemappingSettings CGGMKBADCBM()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)4,
					neutralBlackIn = 317f,
					neutralWhiteIn = 1671f,
					neutralBlackOut = 727f,
					neutralWhiteOut = 1654f,
					neutralWhiteLevel = 222f,
					neutralWhiteClip = 1039f
				};
			}

			// Token: 0x06011DEC RID: 73196 RVA: 0x007EB0CC File Offset: 0x007E92CC
			public static ColorGradingModel.TonemappingSettings JPGMEJNEOCC()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)7,
					neutralBlackIn = 1529f,
					neutralWhiteIn = 1677f,
					neutralBlackOut = 1371f,
					neutralWhiteOut = 1336f,
					neutralWhiteLevel = 1330f,
					neutralWhiteClip = 592f
				};
			}

			// Token: 0x06011DED RID: 73197 RVA: 0x007EB134 File Offset: 0x007E9334
			public static ColorGradingModel.TonemappingSettings OOKKEMFPNBJ()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)6,
					neutralBlackIn = 209f,
					neutralWhiteIn = 1829f,
					neutralBlackOut = 1366f,
					neutralWhiteOut = 299f,
					neutralWhiteLevel = 101f,
					neutralWhiteClip = 66f
				};
			}

			// Token: 0x06011DEE RID: 73198 RVA: 0x007EB19C File Offset: 0x007E939C
			public static ColorGradingModel.TonemappingSettings ILFHFFCIBPJ()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)8,
					neutralBlackIn = 117f,
					neutralWhiteIn = 1218f,
					neutralBlackOut = 930f,
					neutralWhiteOut = 1668f,
					neutralWhiteLevel = 585f,
					neutralWhiteClip = 449f
				};
			}

			// Token: 0x06011DEF RID: 73199 RVA: 0x007EB204 File Offset: 0x007E9404
			public static ColorGradingModel.TonemappingSettings PIAJOHPDMNA()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.None,
					neutralBlackIn = 1442f,
					neutralWhiteIn = 1643f,
					neutralBlackOut = 796f,
					neutralWhiteOut = 872f,
					neutralWhiteLevel = 208f,
					neutralWhiteClip = 827f
				};
			}

			// Token: 0x06011DF0 RID: 73200 RVA: 0x007EB26C File Offset: 0x007E946C
			public static ColorGradingModel.TonemappingSettings MDGIIBPIGJC()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)3,
					neutralBlackIn = 879f,
					neutralWhiteIn = 396f,
					neutralBlackOut = 719f,
					neutralWhiteOut = 53f,
					neutralWhiteLevel = 1767f,
					neutralWhiteClip = 769f
				};
			}

			// Token: 0x06011DF1 RID: 73201 RVA: 0x007EB2D4 File Offset: 0x007E94D4
			public static ColorGradingModel.TonemappingSettings FMLMIDJIEOP()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)6,
					neutralBlackIn = 1592f,
					neutralWhiteIn = 781f,
					neutralBlackOut = 1885f,
					neutralWhiteOut = 1753f,
					neutralWhiteLevel = 1790f,
					neutralWhiteClip = 116f
				};
			}

			// Token: 0x06011DF2 RID: 73202 RVA: 0x007EB33C File Offset: 0x007E953C
			public static ColorGradingModel.TonemappingSettings MGIIIBAJNIE()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.ACES,
					neutralBlackIn = 1470f,
					neutralWhiteIn = 772f,
					neutralBlackOut = 729f,
					neutralWhiteOut = 1788f,
					neutralWhiteLevel = 1606f,
					neutralWhiteClip = 714f
				};
			}

			// Token: 0x06011DF3 RID: 73203 RVA: 0x007EB3A4 File Offset: 0x007E95A4
			public static ColorGradingModel.TonemappingSettings NJJBBDIFPKH()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.Neutral,
					neutralBlackIn = 615f,
					neutralWhiteIn = 317f,
					neutralBlackOut = 550f,
					neutralWhiteOut = 1862f,
					neutralWhiteLevel = 553f,
					neutralWhiteClip = 1217f
				};
			}

			// Token: 0x06011DF4 RID: 73204 RVA: 0x007EB40C File Offset: 0x007E960C
			public static ColorGradingModel.TonemappingSettings COINKHKLJAP()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)8,
					neutralBlackIn = 1138f,
					neutralWhiteIn = 999f,
					neutralBlackOut = 1411f,
					neutralWhiteOut = 1548f,
					neutralWhiteLevel = 1101f,
					neutralWhiteClip = 346f
				};
			}

			// Token: 0x06011DF5 RID: 73205 RVA: 0x007EB474 File Offset: 0x007E9674
			public static ColorGradingModel.TonemappingSettings IGIKNGLDPJB()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.None,
					neutralBlackIn = 686f,
					neutralWhiteIn = 1227f,
					neutralBlackOut = 403f,
					neutralWhiteOut = 857f,
					neutralWhiteLevel = 210f,
					neutralWhiteClip = 850f
				};
			}

			// Token: 0x06011DF6 RID: 73206 RVA: 0x007EB4DC File Offset: 0x007E96DC
			public static ColorGradingModel.TonemappingSettings MJLLLKFIDOE()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.ACES,
					neutralBlackIn = 1925f,
					neutralWhiteIn = 1781f,
					neutralBlackOut = 1491f,
					neutralWhiteOut = 569f,
					neutralWhiteLevel = 549f,
					neutralWhiteClip = 932f
				};
			}

			// Token: 0x06011DF7 RID: 73207 RVA: 0x007EB544 File Offset: 0x007E9744
			public static ColorGradingModel.TonemappingSettings MKEJGGFNILJ()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)6,
					neutralBlackIn = 1884f,
					neutralWhiteIn = 1373f,
					neutralBlackOut = 1590f,
					neutralWhiteOut = 993f,
					neutralWhiteLevel = 7f,
					neutralWhiteClip = 978f
				};
			}

			// Token: 0x06011DF8 RID: 73208 RVA: 0x007EB5AC File Offset: 0x007E97AC
			public static ColorGradingModel.TonemappingSettings OCIMBHLOOGC()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.ACES,
					neutralBlackIn = 1022f,
					neutralWhiteIn = 538f,
					neutralBlackOut = 586f,
					neutralWhiteOut = 721f,
					neutralWhiteLevel = 1979f,
					neutralWhiteClip = 139f
				};
			}

			// Token: 0x06011DF9 RID: 73209 RVA: 0x007EB614 File Offset: 0x007E9814
			public static ColorGradingModel.TonemappingSettings NLCHLENDMLI()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)4,
					neutralBlackIn = 656f,
					neutralWhiteIn = 91f,
					neutralBlackOut = 427f,
					neutralWhiteOut = 594f,
					neutralWhiteLevel = 516f,
					neutralWhiteClip = 659f
				};
			}

			// Token: 0x06011DFA RID: 73210 RVA: 0x007EB67C File Offset: 0x007E987C
			public static ColorGradingModel.TonemappingSettings FBBLPICJODA()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)6,
					neutralBlackIn = 338f,
					neutralWhiteIn = 1345f,
					neutralBlackOut = 1770f,
					neutralWhiteOut = 848f,
					neutralWhiteLevel = 1449f,
					neutralWhiteClip = 1146f
				};
			}

			// Token: 0x06011DFB RID: 73211 RVA: 0x007EB6E4 File Offset: 0x007E98E4
			public static ColorGradingModel.TonemappingSettings NNNMNENCOBC()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)8,
					neutralBlackIn = 1473f,
					neutralWhiteIn = 854f,
					neutralBlackOut = 399f,
					neutralWhiteOut = 162f,
					neutralWhiteLevel = 1697f,
					neutralWhiteClip = 563f
				};
			}

			// Token: 0x06011DFC RID: 73212 RVA: 0x007EB74C File Offset: 0x007E994C
			public static ColorGradingModel.TonemappingSettings OOFOKHIDMDG()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)3,
					neutralBlackIn = 1222f,
					neutralWhiteIn = 1179f,
					neutralBlackOut = 1329f,
					neutralWhiteOut = 1829f,
					neutralWhiteLevel = 1915f,
					neutralWhiteClip = 319f
				};
			}

			// Token: 0x06011DFD RID: 73213 RVA: 0x007EB7B4 File Offset: 0x007E99B4
			public static ColorGradingModel.TonemappingSettings MEFEDCEEAMK()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = (ColorGradingModel.EDJOOGFJNGC)5,
					neutralBlackIn = 362f,
					neutralWhiteIn = 1237f,
					neutralBlackOut = 950f,
					neutralWhiteOut = 1908f,
					neutralWhiteLevel = 839f,
					neutralWhiteClip = 102f
				};
			}

			// Token: 0x06011DFE RID: 73214 RVA: 0x007EB81C File Offset: 0x007E9A1C
			public static ColorGradingModel.TonemappingSettings NPEIGPHIHFP()
			{
				return new ColorGradingModel.TonemappingSettings
				{
					tonemapper = ColorGradingModel.EDJOOGFJNGC.Neutral,
					neutralBlackIn = 1374f,
					neutralWhiteIn = 555f,
					neutralBlackOut = 1317f,
					neutralWhiteOut = 1379f,
					neutralWhiteLevel = 880f,
					neutralWhiteClip = 1451f
				};
			}

			// Token: 0x04002527 RID: 9511
			[Tooltip("Tonemapping algorithm to use at the end of the color grading process. Use \"Neutral\" if you need a customizable tonemapper or \"Filmic\" to give a standard filmic look to your scenes.")]
			public ColorGradingModel.EDJOOGFJNGC tonemapper;

			// Token: 0x04002528 RID: 9512
			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			// Token: 0x04002529 RID: 9513
			[Range(1f, 20f)]
			public float neutralWhiteIn;

			// Token: 0x0400252A RID: 9514
			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			// Token: 0x0400252B RID: 9515
			[Range(1f, 19f)]
			public float neutralWhiteOut;

			// Token: 0x0400252C RID: 9516
			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			// Token: 0x0400252D RID: 9517
			[Range(1f, 10f)]
			public float neutralWhiteClip;
		}

		// Token: 0x0200054C RID: 1356
		[Serializable]
		public struct BasicSettings
		{
			// Token: 0x06011DFF RID: 73215 RVA: 0x007EB884 File Offset: 0x007E9A84
			public static ColorGradingModel.BasicSettings OOKKEMFPNBJ()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 137f,
					temperature = 107f,
					tint = 1594f,
					hueShift = 1715f,
					saturation = 734f,
					contrast = 1413f
				};
			}

			// Token: 0x06011E00 RID: 73216 RVA: 0x007EB8E4 File Offset: 0x007E9AE4
			public static ColorGradingModel.BasicSettings OOFOKHIDMDG()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1337f,
					temperature = 301f,
					tint = 1275f,
					hueShift = 489f,
					saturation = 506f,
					contrast = 420f
				};
			}

			// Token: 0x06011E01 RID: 73217 RVA: 0x007EB944 File Offset: 0x007E9B44
			public static ColorGradingModel.BasicSettings MDDBLMDKDAO()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 352f,
					temperature = 681f,
					tint = 200f,
					hueShift = 359f,
					saturation = 367f,
					contrast = 1479f
				};
			}

			// Token: 0x06011E02 RID: 73218 RVA: 0x007EB9A4 File Offset: 0x007E9BA4
			public static ColorGradingModel.BasicSettings MDGIIBPIGJC()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 552f,
					temperature = 1775f,
					tint = 424f,
					hueShift = 212f,
					saturation = 1029f,
					contrast = 392f
				};
			}

			// Token: 0x06011E03 RID: 73219 RVA: 0x007EBA04 File Offset: 0x007E9C04
			public static ColorGradingModel.BasicSettings MDDFLLOCDEA()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1843f,
					temperature = 1892f,
					tint = 1302f,
					hueShift = 200f,
					saturation = 898f,
					contrast = 418f
				};
			}

			// Token: 0x06011E04 RID: 73220 RVA: 0x007EBA64 File Offset: 0x007E9C64
			public static ColorGradingModel.BasicSettings JPGMEJNEOCC()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 419f,
					temperature = 1841f,
					tint = 1838f,
					hueShift = 1423f,
					saturation = 1780f,
					contrast = 1477f
				};
			}

			// Token: 0x06011E05 RID: 73221 RVA: 0x007EBAC4 File Offset: 0x007E9CC4
			public static ColorGradingModel.BasicSettings HMDLEIJHKEP()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 232f,
					temperature = 770f,
					tint = 1292f,
					hueShift = 439f,
					saturation = 245f,
					contrast = 906f
				};
			}

			// Token: 0x06011E06 RID: 73222 RVA: 0x007EBB24 File Offset: 0x007E9D24
			public static ColorGradingModel.BasicSettings HLLBKJENCLA()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1837f,
					temperature = 1685f,
					tint = 1731f,
					hueShift = 725f,
					saturation = 1980f,
					contrast = 376f
				};
			}

			// Token: 0x06011E07 RID: 73223 RVA: 0x007EBB84 File Offset: 0x007E9D84
			public static ColorGradingModel.BasicSettings NLCHLENDMLI()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 61f,
					temperature = 579f,
					tint = 950f,
					hueShift = 302f,
					saturation = 1654f,
					contrast = 887f
				};
			}

			// Token: 0x06011E08 RID: 73224 RVA: 0x007EBBE4 File Offset: 0x007E9DE4
			public static ColorGradingModel.BasicSettings CGGMKBADCBM()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1559f,
					temperature = 843f,
					tint = 515f,
					hueShift = 628f,
					saturation = 1641f,
					contrast = 1499f
				};
			}

			// Token: 0x06011E09 RID: 73225 RVA: 0x007EBC44 File Offset: 0x007E9E44
			public static ColorGradingModel.BasicSettings NJJBBDIFPKH()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 277f,
					temperature = 1674f,
					tint = 1813f,
					hueShift = 1147f,
					saturation = 466f,
					contrast = 1096f
				};
			}

			// Token: 0x06011E0A RID: 73226 RVA: 0x007EBCA4 File Offset: 0x007E9EA4
			public static ColorGradingModel.BasicSettings FBBLPICJODA()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 994f,
					temperature = 867f,
					tint = 226f,
					hueShift = 1215f,
					saturation = 513f,
					contrast = 915f
				};
			}

			// Token: 0x06011E0B RID: 73227 RVA: 0x007EBD04 File Offset: 0x007E9F04
			public static ColorGradingModel.BasicSettings MKEJGGFNILJ()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1249f,
					temperature = 424f,
					tint = 673f,
					hueShift = 789f,
					saturation = 217f,
					contrast = 1718f
				};
			}

			// Token: 0x06011E0C RID: 73228 RVA: 0x007EBD64 File Offset: 0x007E9F64
			public static ColorGradingModel.BasicSettings MJLLLKFIDOE()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 220f,
					temperature = 929f,
					tint = 1614f,
					hueShift = 706f,
					saturation = 29f,
					contrast = 224f
				};
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x06011E0D RID: 73229 RVA: 0x007EBDC4 File Offset: 0x007E9FC4
			public static ColorGradingModel.BasicSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.BasicSettings
					{
						postExposure = 0f,
						temperature = 0f,
						tint = 0f,
						hueShift = 0f,
						saturation = 1f,
						contrast = 1f
					};
				}
			}

			// Token: 0x06011E0E RID: 73230 RVA: 0x007EBE24 File Offset: 0x007EA024
			public static ColorGradingModel.BasicSettings IGIKNGLDPJB()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1305f,
					temperature = 203f,
					tint = 1744f,
					hueShift = 1174f,
					saturation = 1510f,
					contrast = 1688f
				};
			}

			// Token: 0x06011E0F RID: 73231 RVA: 0x007EBE84 File Offset: 0x007EA084
			public static ColorGradingModel.BasicSettings NNNMNENCOBC()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1573f,
					temperature = 1133f,
					tint = 1578f,
					hueShift = 721f,
					saturation = 1618f,
					contrast = 615f
				};
			}

			// Token: 0x06011E10 RID: 73232 RVA: 0x007EBEE4 File Offset: 0x007EA0E4
			public static ColorGradingModel.BasicSettings OCIMBHLOOGC()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1434f,
					temperature = 1048f,
					tint = 1273f,
					hueShift = 1993f,
					saturation = 1505f,
					contrast = 483f
				};
			}

			// Token: 0x06011E11 RID: 73233 RVA: 0x007EBF44 File Offset: 0x007EA144
			public static ColorGradingModel.BasicSettings MEFEDCEEAMK()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 529f,
					temperature = 1931f,
					tint = 27f,
					hueShift = 1044f,
					saturation = 592f,
					contrast = 964f
				};
			}

			// Token: 0x06011E12 RID: 73234 RVA: 0x007EBFA4 File Offset: 0x007EA1A4
			public static ColorGradingModel.BasicSettings GDKPNHJPBKJ()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 90f,
					temperature = 693f,
					tint = 1486f,
					hueShift = 1049f,
					saturation = 16f,
					contrast = 1226f
				};
			}

			// Token: 0x06011E13 RID: 73235 RVA: 0x007EC004 File Offset: 0x007EA204
			public static ColorGradingModel.BasicSettings PIAJOHPDMNA()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 1204f,
					temperature = 1884f,
					tint = 1154f,
					hueShift = 47f,
					saturation = 829f,
					contrast = 398f
				};
			}

			// Token: 0x06011E14 RID: 73236 RVA: 0x007EC064 File Offset: 0x007EA264
			public static ColorGradingModel.BasicSettings COINKHKLJAP()
			{
				return new ColorGradingModel.BasicSettings
				{
					postExposure = 174f,
					temperature = 740f,
					tint = 166f,
					hueShift = 497f,
					saturation = 1688f,
					contrast = 366f
				};
			}

			// Token: 0x0400252E RID: 9518
			[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
			public float postExposure;

			// Token: 0x0400252F RID: 9519
			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to a custom color temperature.")]
			public float temperature;

			// Token: 0x04002530 RID: 9520
			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			// Token: 0x04002531 RID: 9521
			[Range(-180f, 180f)]
			[Tooltip("Shift the hue of all colors.")]
			public float hueShift;

			// Token: 0x04002532 RID: 9522
			[Range(0f, 2f)]
			[Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			// Token: 0x04002533 RID: 9523
			[Range(0f, 2f)]
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			public float contrast;
		}

		// Token: 0x0200054D RID: 1357
		[Serializable]
		public struct ChannelMixerSettings
		{
			// Token: 0x06011E15 RID: 73237 RVA: 0x007EC0C4 File Offset: 0x007EA2C4
			public static ColorGradingModel.ChannelMixerSettings OOFOKHIDMDG()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1909f, 1364f, 939f),
					green = new Vector3(1084f, 107f, 336f),
					blue = new Vector3(927f, 440f, 885f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x06011E16 RID: 73238 RVA: 0x007EC134 File Offset: 0x007EA334
			public static ColorGradingModel.ChannelMixerSettings NLCHLENDMLI()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(639f, 1038f, 1594f),
					green = new Vector3(1047f, 1699f, 996f),
					blue = new Vector3(1117f, 1350f, 1235f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x06011E17 RID: 73239 RVA: 0x007EC1A4 File Offset: 0x007EA3A4
			public static ColorGradingModel.ChannelMixerSettings NJJBBDIFPKH()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(930f, 924f, 480f),
					green = new Vector3(369f, 488f, 192f),
					blue = new Vector3(399f, 398f, 1902f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x06011E18 RID: 73240 RVA: 0x007EC214 File Offset: 0x007EA414
			public static ColorGradingModel.ChannelMixerSettings HMDLEIJHKEP()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(869f, 4f, 1978f),
					green = new Vector3(679f, 1155f, 35f),
					blue = new Vector3(1923f, 1558f, 235f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x06011E19 RID: 73241 RVA: 0x007EC284 File Offset: 0x007EA484
			public static ColorGradingModel.ChannelMixerSettings CGGMKBADCBM()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1687f, 718f, 1453f),
					green = new Vector3(1689f, 893f, 73f),
					blue = new Vector3(1717f, 1829f, 1066f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x06011E1A RID: 73242 RVA: 0x007EC2F4 File Offset: 0x007EA4F4
			public static ColorGradingModel.ChannelMixerSettings FBBLPICJODA()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1525f, 217f, 1261f),
					green = new Vector3(1895f, 1760f, 1692f),
					blue = new Vector3(977f, 1827f, 1345f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x06011E1B RID: 73243 RVA: 0x007EC364 File Offset: 0x007EA564
			public static ColorGradingModel.ChannelMixerSettings MDDFLLOCDEA()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1805f, 1516f, 1607f),
					green = new Vector3(1119f, 1602f, 855f),
					blue = new Vector3(1671f, 734f, 1488f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x06011E1C RID: 73244 RVA: 0x007EC3D4 File Offset: 0x007EA5D4
			public static ColorGradingModel.ChannelMixerSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.ChannelMixerSettings
					{
						red = new Vector3(1f, 0f, 0f),
						green = new Vector3(0f, 1f, 0f),
						blue = new Vector3(0f, 0f, 1f),
						currentEditingChannel = 0
					};
				}
			}

			// Token: 0x06011E1D RID: 73245 RVA: 0x007EC444 File Offset: 0x007EA644
			public static ColorGradingModel.ChannelMixerSettings MDGIIBPIGJC()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1044f, 127f, 625f),
					green = new Vector3(835f, 845f, 1800f),
					blue = new Vector3(1313f, 754f, 1785f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x06011E1E RID: 73246 RVA: 0x007EC4B4 File Offset: 0x007EA6B4
			public static ColorGradingModel.ChannelMixerSettings IGIKNGLDPJB()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(440f, 458f, 715f),
					green = new Vector3(1619f, 144f, 527f),
					blue = new Vector3(42f, 983f, 359f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x06011E1F RID: 73247 RVA: 0x007EC524 File Offset: 0x007EA724
			public static ColorGradingModel.ChannelMixerSettings MJLLLKFIDOE()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1820f, 1042f, 1763f),
					green = new Vector3(1864f, 1915f, 1122f),
					blue = new Vector3(1024f, 1844f, 1400f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x06011E20 RID: 73248 RVA: 0x007EC594 File Offset: 0x007EA794
			public static ColorGradingModel.ChannelMixerSettings GDKPNHJPBKJ()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1435f, 147f, 1109f),
					green = new Vector3(1802f, 162f, 1467f),
					blue = new Vector3(223f, 1539f, 484f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x06011E21 RID: 73249 RVA: 0x007EC604 File Offset: 0x007EA804
			public static ColorGradingModel.ChannelMixerSettings HLLBKJENCLA()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1927f, 1673f, 1326f),
					green = new Vector3(1063f, 57f, 1228f),
					blue = new Vector3(1916f, 516f, 312f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x06011E22 RID: 73250 RVA: 0x007EC674 File Offset: 0x007EA874
			public static ColorGradingModel.ChannelMixerSettings MKEJGGFNILJ()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(579f, 879f, 1428f),
					green = new Vector3(1554f, 469f, 1075f),
					blue = new Vector3(366f, 875f, 1543f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x06011E23 RID: 73251 RVA: 0x007EC6E4 File Offset: 0x007EA8E4
			public static ColorGradingModel.ChannelMixerSettings MEFEDCEEAMK()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1045f, 1103f, 1437f),
					green = new Vector3(606f, 624f, 276f),
					blue = new Vector3(1277f, 1373f, 58f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x06011E24 RID: 73252 RVA: 0x007EC754 File Offset: 0x007EA954
			public static ColorGradingModel.ChannelMixerSettings COINKHKLJAP()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1897f, 991f, 1821f),
					green = new Vector3(1465f, 747f, 76f),
					blue = new Vector3(1019f, 753f, 1056f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x06011E25 RID: 73253 RVA: 0x007EC7C4 File Offset: 0x007EA9C4
			public static ColorGradingModel.ChannelMixerSettings JPGMEJNEOCC()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1416f, 951f, 1754f),
					green = new Vector3(228f, 1405f, 1017f),
					blue = new Vector3(1138f, 958f, 1027f),
					currentEditingChannel = 0
				};
			}

			// Token: 0x06011E26 RID: 73254 RVA: 0x007EC834 File Offset: 0x007EAA34
			public static ColorGradingModel.ChannelMixerSettings OCIMBHLOOGC()
			{
				return new ColorGradingModel.ChannelMixerSettings
				{
					red = new Vector3(1156f, 1287f, 336f),
					green = new Vector3(1414f, 1390f, 1204f),
					blue = new Vector3(785f, 1428f, 946f),
					currentEditingChannel = 1
				};
			}

			// Token: 0x04002534 RID: 9524
			public Vector3 red;

			// Token: 0x04002535 RID: 9525
			public Vector3 green;

			// Token: 0x04002536 RID: 9526
			public Vector3 blue;

			// Token: 0x04002537 RID: 9527
			[HideInInspector]
			public int currentEditingChannel;
		}

		// Token: 0x0200054E RID: 1358
		[Serializable]
		public struct LogWheelsSettings
		{
			// Token: 0x06011E27 RID: 73255 RVA: 0x007EC8A4 File Offset: 0x007EAAA4
			public static ColorGradingModel.LogWheelsSettings PIAJOHPDMNA()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E28 RID: 73256 RVA: 0x007EC8E0 File Offset: 0x007EAAE0
			public static ColorGradingModel.LogWheelsSettings HLLBKJENCLA()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E29 RID: 73257 RVA: 0x007EC91C File Offset: 0x007EAB1C
			public static ColorGradingModel.LogWheelsSettings MKEJGGFNILJ()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E2A RID: 73258 RVA: 0x007EC958 File Offset: 0x007EAB58
			public static ColorGradingModel.LogWheelsSettings MDDFLLOCDEA()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E2B RID: 73259 RVA: 0x007EC994 File Offset: 0x007EAB94
			public static ColorGradingModel.LogWheelsSettings MEFEDCEEAMK()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E2C RID: 73260 RVA: 0x007EC9D0 File Offset: 0x007EABD0
			public static ColorGradingModel.LogWheelsSettings AAPKKAPOLKH()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x06011E2D RID: 73261 RVA: 0x007ECA0C File Offset: 0x007EAC0C
			public static ColorGradingModel.LogWheelsSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.LogWheelsSettings
					{
						slope = Color.clear,
						power = Color.clear,
						offset = Color.clear
					};
				}
			}

			// Token: 0x06011E2E RID: 73262 RVA: 0x007ECA48 File Offset: 0x007EAC48
			public static ColorGradingModel.LogWheelsSettings JPGMEJNEOCC()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E2F RID: 73263 RVA: 0x007ECA84 File Offset: 0x007EAC84
			public static ColorGradingModel.LogWheelsSettings NLCHLENDMLI()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E30 RID: 73264 RVA: 0x007ECAC0 File Offset: 0x007EACC0
			public static ColorGradingModel.LogWheelsSettings OOKKEMFPNBJ()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E31 RID: 73265 RVA: 0x007ECAFC File Offset: 0x007EACFC
			public static ColorGradingModel.LogWheelsSettings HMDLEIJHKEP()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E32 RID: 73266 RVA: 0x007ECB38 File Offset: 0x007EAD38
			public static ColorGradingModel.LogWheelsSettings GDKPNHJPBKJ()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E33 RID: 73267 RVA: 0x007ECB74 File Offset: 0x007EAD74
			public static ColorGradingModel.LogWheelsSettings MDGIIBPIGJC()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E34 RID: 73268 RVA: 0x007ECBB0 File Offset: 0x007EADB0
			public static ColorGradingModel.LogWheelsSettings FBBLPICJODA()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E35 RID: 73269 RVA: 0x007ECBEC File Offset: 0x007EADEC
			public static ColorGradingModel.LogWheelsSettings NNNMNENCOBC()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E36 RID: 73270 RVA: 0x007ECC28 File Offset: 0x007EAE28
			public static ColorGradingModel.LogWheelsSettings NJJBBDIFPKH()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E37 RID: 73271 RVA: 0x007ECC64 File Offset: 0x007EAE64
			public static ColorGradingModel.LogWheelsSettings FMLMIDJIEOP()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E38 RID: 73272 RVA: 0x007ECCA0 File Offset: 0x007EAEA0
			public static ColorGradingModel.LogWheelsSettings OOFOKHIDMDG()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E39 RID: 73273 RVA: 0x007ECCDC File Offset: 0x007EAEDC
			public static ColorGradingModel.LogWheelsSettings MDDBLMDKDAO()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E3A RID: 73274 RVA: 0x007ECD18 File Offset: 0x007EAF18
			public static ColorGradingModel.LogWheelsSettings DELLGIGMFLC()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E3B RID: 73275 RVA: 0x007ECD54 File Offset: 0x007EAF54
			public static ColorGradingModel.LogWheelsSettings MGIIIBAJNIE()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E3C RID: 73276 RVA: 0x007ECD90 File Offset: 0x007EAF90
			public static ColorGradingModel.LogWheelsSettings MJLLLKFIDOE()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E3D RID: 73277 RVA: 0x007ECDCC File Offset: 0x007EAFCC
			public static ColorGradingModel.LogWheelsSettings DHCNIDFOOPO()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E3E RID: 73278 RVA: 0x007ECE08 File Offset: 0x007EB008
			public static ColorGradingModel.LogWheelsSettings COINKHKLJAP()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E3F RID: 73279 RVA: 0x007ECE44 File Offset: 0x007EB044
			public static ColorGradingModel.LogWheelsSettings CGGMKBADCBM()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E40 RID: 73280 RVA: 0x007ECE80 File Offset: 0x007EB080
			public static ColorGradingModel.LogWheelsSettings IGIKNGLDPJB()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x06011E41 RID: 73281 RVA: 0x007ECEBC File Offset: 0x007EB0BC
			public static ColorGradingModel.LogWheelsSettings OCIMBHLOOGC()
			{
				return new ColorGradingModel.LogWheelsSettings
				{
					slope = Color.clear,
					power = Color.clear,
					offset = Color.clear
				};
			}

			// Token: 0x04002538 RID: 9528
			[IHCPIEJILAM("GetSlopeValue")]
			public Color slope;

			// Token: 0x04002539 RID: 9529
			[IHCPIEJILAM("GetPowerValue")]
			public Color power;

			// Token: 0x0400253A RID: 9530
			[IHCPIEJILAM("GetOffsetValue")]
			public Color offset;
		}

		// Token: 0x0200054F RID: 1359
		[Serializable]
		public struct LinearWheelsSettings
		{
			// Token: 0x06011E42 RID: 73282 RVA: 0x007ECEF8 File Offset: 0x007EB0F8
			public static ColorGradingModel.LinearWheelsSettings MDDBLMDKDAO()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E43 RID: 73283 RVA: 0x007ECF34 File Offset: 0x007EB134
			public static ColorGradingModel.LinearWheelsSettings IGIKNGLDPJB()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E44 RID: 73284 RVA: 0x007ECF70 File Offset: 0x007EB170
			public static ColorGradingModel.LinearWheelsSettings PIAJOHPDMNA()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E45 RID: 73285 RVA: 0x007ECFAC File Offset: 0x007EB1AC
			public static ColorGradingModel.LinearWheelsSettings MKEJGGFNILJ()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E46 RID: 73286 RVA: 0x007ECFE8 File Offset: 0x007EB1E8
			public static ColorGradingModel.LinearWheelsSettings CGGMKBADCBM()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E47 RID: 73287 RVA: 0x007ED024 File Offset: 0x007EB224
			public static ColorGradingModel.LinearWheelsSettings GDKPNHJPBKJ()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x06011E48 RID: 73288 RVA: 0x007ED060 File Offset: 0x007EB260
			public static ColorGradingModel.LinearWheelsSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.LinearWheelsSettings
					{
						lift = Color.clear,
						gamma = Color.clear,
						gain = Color.clear
					};
				}
			}

			// Token: 0x06011E49 RID: 73289 RVA: 0x007ED09C File Offset: 0x007EB29C
			public static ColorGradingModel.LinearWheelsSettings MEFEDCEEAMK()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E4A RID: 73290 RVA: 0x007ED0D8 File Offset: 0x007EB2D8
			public static ColorGradingModel.LinearWheelsSettings COINKHKLJAP()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E4B RID: 73291 RVA: 0x007ED114 File Offset: 0x007EB314
			public static ColorGradingModel.LinearWheelsSettings HMDLEIJHKEP()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E4C RID: 73292 RVA: 0x007ED150 File Offset: 0x007EB350
			public static ColorGradingModel.LinearWheelsSettings OCIMBHLOOGC()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E4D RID: 73293 RVA: 0x007ED18C File Offset: 0x007EB38C
			public static ColorGradingModel.LinearWheelsSettings NJJBBDIFPKH()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E4E RID: 73294 RVA: 0x007ED1C8 File Offset: 0x007EB3C8
			public static ColorGradingModel.LinearWheelsSettings NLCHLENDMLI()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E4F RID: 73295 RVA: 0x007ED204 File Offset: 0x007EB404
			public static ColorGradingModel.LinearWheelsSettings MDGIIBPIGJC()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E50 RID: 73296 RVA: 0x007ED240 File Offset: 0x007EB440
			public static ColorGradingModel.LinearWheelsSettings MJLLLKFIDOE()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E51 RID: 73297 RVA: 0x007ED27C File Offset: 0x007EB47C
			public static ColorGradingModel.LinearWheelsSettings OOFOKHIDMDG()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E52 RID: 73298 RVA: 0x007ED2B8 File Offset: 0x007EB4B8
			public static ColorGradingModel.LinearWheelsSettings MDDFLLOCDEA()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E53 RID: 73299 RVA: 0x007ED2F4 File Offset: 0x007EB4F4
			public static ColorGradingModel.LinearWheelsSettings OOKKEMFPNBJ()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E54 RID: 73300 RVA: 0x007ED330 File Offset: 0x007EB530
			public static ColorGradingModel.LinearWheelsSettings FBBLPICJODA()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E55 RID: 73301 RVA: 0x007ED36C File Offset: 0x007EB56C
			public static ColorGradingModel.LinearWheelsSettings HLLBKJENCLA()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x06011E56 RID: 73302 RVA: 0x007ED3A8 File Offset: 0x007EB5A8
			public static ColorGradingModel.LinearWheelsSettings JPGMEJNEOCC()
			{
				return new ColorGradingModel.LinearWheelsSettings
				{
					lift = Color.clear,
					gamma = Color.clear,
					gain = Color.clear
				};
			}

			// Token: 0x0400253B RID: 9531
			[IHCPIEJILAM("GetLiftValue")]
			public Color lift;

			// Token: 0x0400253C RID: 9532
			[IHCPIEJILAM("GetGammaValue")]
			public Color gamma;

			// Token: 0x0400253D RID: 9533
			[IHCPIEJILAM("GetGainValue")]
			public Color gain;
		}

		// Token: 0x02000550 RID: 1360
		public enum JOIEGPJNJPO
		{
			// Token: 0x0400253F RID: 9535
			Linear,
			// Token: 0x04002540 RID: 9536
			Log
		}

		// Token: 0x02000551 RID: 1361
		[Serializable]
		public struct ColorWheelsSettings
		{
			// Token: 0x06011E57 RID: 73303 RVA: 0x007ED3E4 File Offset: 0x007EB5E4
			public static ColorGradingModel.ColorWheelsSettings BJNIBDPAHBP()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.MDGIIBPIGJC(),
					linear = ColorGradingModel.LinearWheelsSettings.OOKKEMFPNBJ()
				};
			}

			// Token: 0x06011E58 RID: 73304 RVA: 0x007ED41C File Offset: 0x007EB61C
			public static ColorGradingModel.ColorWheelsSettings MDDBLMDKDAO()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.FMLMIDJIEOP(),
					linear = ColorGradingModel.LinearWheelsSettings.COINKHKLJAP()
				};
			}

			// Token: 0x06011E59 RID: 73305 RVA: 0x007ED454 File Offset: 0x007EB654
			public static ColorGradingModel.ColorWheelsSettings ADJNPGFJGJI()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.MDDBLMDKDAO(),
					linear = ColorGradingModel.LinearWheelsSettings.MJLLLKFIDOE()
				};
			}

			// Token: 0x06011E5A RID: 73306 RVA: 0x007ED48C File Offset: 0x007EB68C
			public static ColorGradingModel.ColorWheelsSettings FMLMIDJIEOP()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.IGIKNGLDPJB(),
					linear = ColorGradingModel.LinearWheelsSettings.GDKPNHJPBKJ()
				};
			}

			// Token: 0x06011E5B RID: 73307 RVA: 0x007ED4C4 File Offset: 0x007EB6C4
			public static ColorGradingModel.ColorWheelsSettings OCIMBHLOOGC()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.OCIMBHLOOGC(),
					linear = ColorGradingModel.LinearWheelsSettings.OOFOKHIDMDG()
				};
			}

			// Token: 0x06011E5C RID: 73308 RVA: 0x007ED4FC File Offset: 0x007EB6FC
			public static ColorGradingModel.ColorWheelsSettings HIPJDBACJDH()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.PIAJOHPDMNA(),
					linear = ColorGradingModel.LinearWheelsSettings.MKEJGGFNILJ()
				};
			}

			// Token: 0x06011E5D RID: 73309 RVA: 0x007ED534 File Offset: 0x007EB734
			public static ColorGradingModel.ColorWheelsSettings DELLGIGMFLC()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.MKEJGGFNILJ(),
					linear = ColorGradingModel.LinearWheelsSettings.PIAJOHPDMNA()
				};
			}

			// Token: 0x06011E5E RID: 73310 RVA: 0x007ED56C File Offset: 0x007EB76C
			public static ColorGradingModel.ColorWheelsSettings GDKPNHJPBKJ()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.PIAJOHPDMNA(),
					linear = ColorGradingModel.LinearWheelsSettings.GDKPNHJPBKJ()
				};
			}

			// Token: 0x06011E5F RID: 73311 RVA: 0x007ED5A4 File Offset: 0x007EB7A4
			public static ColorGradingModel.ColorWheelsSettings NLCHLENDMLI()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.GDKPNHJPBKJ(),
					linear = ColorGradingModel.LinearWheelsSettings.MEFEDCEEAMK()
				};
			}

			// Token: 0x06011E60 RID: 73312 RVA: 0x007ED5DC File Offset: 0x007EB7DC
			public static ColorGradingModel.ColorWheelsSettings COJPKDJKJAM()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.OOKKEMFPNBJ(),
					linear = ColorGradingModel.LinearWheelsSettings.MKEJGGFNILJ()
				};
			}

			// Token: 0x06011E61 RID: 73313 RVA: 0x007ED614 File Offset: 0x007EB814
			public static ColorGradingModel.ColorWheelsSettings MDGIIBPIGJC()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.GDKPNHJPBKJ(),
					linear = ColorGradingModel.LinearWheelsSettings.JPGMEJNEOCC()
				};
			}

			// Token: 0x06011E62 RID: 73314 RVA: 0x007ED64C File Offset: 0x007EB84C
			public static ColorGradingModel.ColorWheelsSettings COINKHKLJAP()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.PIAJOHPDMNA(),
					linear = ColorGradingModel.LinearWheelsSettings.FBBLPICJODA()
				};
			}

			// Token: 0x06011E63 RID: 73315 RVA: 0x007ED684 File Offset: 0x007EB884
			public static ColorGradingModel.ColorWheelsSettings JPGMEJNEOCC()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.NJJBBDIFPKH(),
					linear = ColorGradingModel.LinearWheelsSettings.GDKPNHJPBKJ()
				};
			}

			// Token: 0x06011E64 RID: 73316 RVA: 0x007ED6BC File Offset: 0x007EB8BC
			public static ColorGradingModel.ColorWheelsSettings PIAJOHPDMNA()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.DHCNIDFOOPO(),
					linear = ColorGradingModel.LinearWheelsSettings.MEFEDCEEAMK()
				};
			}

			// Token: 0x06011E65 RID: 73317 RVA: 0x007ED6F4 File Offset: 0x007EB8F4
			public static ColorGradingModel.ColorWheelsSettings AAPKKAPOLKH()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.NJJBBDIFPKH(),
					linear = ColorGradingModel.LinearWheelsSettings.PIAJOHPDMNA()
				};
			}

			// Token: 0x06011E66 RID: 73318 RVA: 0x007ED72C File Offset: 0x007EB92C
			public static ColorGradingModel.ColorWheelsSettings BFFANDBCLFI()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.OOKKEMFPNBJ(),
					linear = ColorGradingModel.LinearWheelsSettings.MDDFLLOCDEA()
				};
			}

			// Token: 0x06011E67 RID: 73319 RVA: 0x007ED764 File Offset: 0x007EB964
			public static ColorGradingModel.ColorWheelsSettings OOFOKHIDMDG()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.PIAJOHPDMNA(),
					linear = ColorGradingModel.LinearWheelsSettings.MKEJGGFNILJ()
				};
			}

			// Token: 0x06011E68 RID: 73320 RVA: 0x007ED79C File Offset: 0x007EB99C
			public static ColorGradingModel.ColorWheelsSettings NMGNPHGAGGA()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.COINKHKLJAP(),
					linear = ColorGradingModel.LinearWheelsSettings.HMDLEIJHKEP()
				};
			}

			// Token: 0x06011E69 RID: 73321 RVA: 0x007ED7D4 File Offset: 0x007EB9D4
			public static ColorGradingModel.ColorWheelsSettings MKEJGGFNILJ()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.FMLMIDJIEOP(),
					linear = ColorGradingModel.LinearWheelsSettings.PIAJOHPDMNA()
				};
			}

			// Token: 0x06011E6A RID: 73322 RVA: 0x007ED80C File Offset: 0x007EBA0C
			public static ColorGradingModel.ColorWheelsSettings CGGMKBADCBM()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.AAPKKAPOLKH(),
					linear = ColorGradingModel.LinearWheelsSettings.MKEJGGFNILJ()
				};
			}

			// Token: 0x06011E6B RID: 73323 RVA: 0x007ED844 File Offset: 0x007EBA44
			public static ColorGradingModel.ColorWheelsSettings MEBNDNNHNMB()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.MGIIIBAJNIE(),
					linear = ColorGradingModel.LinearWheelsSettings.OCIMBHLOOGC()
				};
			}

			// Token: 0x06011E6C RID: 73324 RVA: 0x007ED87C File Offset: 0x007EBA7C
			public static ColorGradingModel.ColorWheelsSettings LNGBMOGJKGD()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.MKEJGGFNILJ(),
					linear = ColorGradingModel.LinearWheelsSettings.NLCHLENDMLI()
				};
			}

			// Token: 0x06011E6D RID: 73325 RVA: 0x007ED8B4 File Offset: 0x007EBAB4
			public static ColorGradingModel.ColorWheelsSettings DHCNIDFOOPO()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.OOKKEMFPNBJ(),
					linear = ColorGradingModel.LinearWheelsSettings.FBBLPICJODA()
				};
			}

			// Token: 0x06011E6E RID: 73326 RVA: 0x007ED8EC File Offset: 0x007EBAEC
			public static ColorGradingModel.ColorWheelsSettings OOKKEMFPNBJ()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.MDDBLMDKDAO(),
					linear = ColorGradingModel.LinearWheelsSettings.MJLLLKFIDOE()
				};
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x06011E6F RID: 73327 RVA: 0x007ED924 File Offset: 0x007EBB24
			public static ColorGradingModel.ColorWheelsSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.ColorWheelsSettings
					{
						mode = ColorGradingModel.JOIEGPJNJPO.Log,
						log = ColorGradingModel.LogWheelsSettings.defaultSettings,
						linear = ColorGradingModel.LinearWheelsSettings.defaultSettings
					};
				}
			}

			// Token: 0x06011E70 RID: 73328 RVA: 0x007ED95C File Offset: 0x007EBB5C
			public static ColorGradingModel.ColorWheelsSettings ELPHMKAEDHE()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.MDDBLMDKDAO(),
					linear = ColorGradingModel.LinearWheelsSettings.MDDBLMDKDAO()
				};
			}

			// Token: 0x06011E71 RID: 73329 RVA: 0x007ED994 File Offset: 0x007EBB94
			public static ColorGradingModel.ColorWheelsSettings HLLBKJENCLA()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.FBBLPICJODA(),
					linear = ColorGradingModel.LinearWheelsSettings.GDKPNHJPBKJ()
				};
			}

			// Token: 0x06011E72 RID: 73330 RVA: 0x007ED9CC File Offset: 0x007EBBCC
			public static ColorGradingModel.ColorWheelsSettings MDDFLLOCDEA()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.COINKHKLJAP(),
					linear = ColorGradingModel.LinearWheelsSettings.NLCHLENDMLI()
				};
			}

			// Token: 0x06011E73 RID: 73331 RVA: 0x007EDA04 File Offset: 0x007EBC04
			public static ColorGradingModel.ColorWheelsSettings NJJBBDIFPKH()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.NJJBBDIFPKH(),
					linear = ColorGradingModel.LinearWheelsSettings.NJJBBDIFPKH()
				};
			}

			// Token: 0x06011E74 RID: 73332 RVA: 0x007EDA3C File Offset: 0x007EBC3C
			public static ColorGradingModel.ColorWheelsSettings MGIIIBAJNIE()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.FMLMIDJIEOP(),
					linear = ColorGradingModel.LinearWheelsSettings.PIAJOHPDMNA()
				};
			}

			// Token: 0x06011E75 RID: 73333 RVA: 0x007EDA74 File Offset: 0x007EBC74
			public static ColorGradingModel.ColorWheelsSettings IGIKNGLDPJB()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.MDGIIBPIGJC(),
					linear = ColorGradingModel.LinearWheelsSettings.MEFEDCEEAMK()
				};
			}

			// Token: 0x06011E76 RID: 73334 RVA: 0x007EDAAC File Offset: 0x007EBCAC
			public static ColorGradingModel.ColorWheelsSettings NPEIGPHIHFP()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.JPGMEJNEOCC(),
					linear = ColorGradingModel.LinearWheelsSettings.HLLBKJENCLA()
				};
			}

			// Token: 0x06011E77 RID: 73335 RVA: 0x007EDAE4 File Offset: 0x007EBCE4
			public static ColorGradingModel.ColorWheelsSettings HMDLEIJHKEP()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.defaultSettings,
					linear = ColorGradingModel.LinearWheelsSettings.GDKPNHJPBKJ()
				};
			}

			// Token: 0x06011E78 RID: 73336 RVA: 0x007EDB1C File Offset: 0x007EBD1C
			public static ColorGradingModel.ColorWheelsSettings FBBLPICJODA()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.DELLGIGMFLC(),
					linear = ColorGradingModel.LinearWheelsSettings.HMDLEIJHKEP()
				};
			}

			// Token: 0x06011E79 RID: 73337 RVA: 0x007EDB54 File Offset: 0x007EBD54
			public static ColorGradingModel.ColorWheelsSettings MEFEDCEEAMK()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.MGIIIBAJNIE(),
					linear = ColorGradingModel.LinearWheelsSettings.MJLLLKFIDOE()
				};
			}

			// Token: 0x06011E7A RID: 73338 RVA: 0x007EDB8C File Offset: 0x007EBD8C
			public static ColorGradingModel.ColorWheelsSettings ILFHFFCIBPJ()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.HMDLEIJHKEP(),
					linear = ColorGradingModel.LinearWheelsSettings.NLCHLENDMLI()
				};
			}

			// Token: 0x06011E7B RID: 73339 RVA: 0x007EDBC4 File Offset: 0x007EBDC4
			public static ColorGradingModel.ColorWheelsSettings JACPKLDIIKG()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.MDDFLLOCDEA(),
					linear = ColorGradingModel.LinearWheelsSettings.OCIMBHLOOGC()
				};
			}

			// Token: 0x06011E7C RID: 73340 RVA: 0x007EDBFC File Offset: 0x007EBDFC
			public static ColorGradingModel.ColorWheelsSettings NNNMNENCOBC()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.MKEJGGFNILJ(),
					linear = ColorGradingModel.LinearWheelsSettings.MEFEDCEEAMK()
				};
			}

			// Token: 0x06011E7D RID: 73341 RVA: 0x007EDC34 File Offset: 0x007EBE34
			public static ColorGradingModel.ColorWheelsSettings MJLLLKFIDOE()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.FMLMIDJIEOP(),
					linear = ColorGradingModel.LinearWheelsSettings.PIAJOHPDMNA()
				};
			}

			// Token: 0x06011E7E RID: 73342 RVA: 0x007EDC6C File Offset: 0x007EBE6C
			public static ColorGradingModel.ColorWheelsSettings BNGFNAFFAME()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.DHCNIDFOOPO(),
					linear = ColorGradingModel.LinearWheelsSettings.MDDBLMDKDAO()
				};
			}

			// Token: 0x06011E7F RID: 73343 RVA: 0x007EDCA4 File Offset: 0x007EBEA4
			public static ColorGradingModel.ColorWheelsSettings MCLJECOKBEJ()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Log,
					log = ColorGradingModel.LogWheelsSettings.JPGMEJNEOCC(),
					linear = ColorGradingModel.LinearWheelsSettings.HMDLEIJHKEP()
				};
			}

			// Token: 0x06011E80 RID: 73344 RVA: 0x007EDCDC File Offset: 0x007EBEDC
			public static ColorGradingModel.ColorWheelsSettings JGNKGPFJFHO()
			{
				return new ColorGradingModel.ColorWheelsSettings
				{
					mode = ColorGradingModel.JOIEGPJNJPO.Linear,
					log = ColorGradingModel.LogWheelsSettings.OCIMBHLOOGC(),
					linear = ColorGradingModel.LinearWheelsSettings.HMDLEIJHKEP()
				};
			}

			// Token: 0x04002541 RID: 9537
			public ColorGradingModel.JOIEGPJNJPO mode;

			// Token: 0x04002542 RID: 9538
			[HHIECCCHGOI]
			public ColorGradingModel.LogWheelsSettings log;

			// Token: 0x04002543 RID: 9539
			[HHIECCCHGOI]
			public ColorGradingModel.LinearWheelsSettings linear;
		}

		// Token: 0x02000552 RID: 1362
		[Serializable]
		public struct CurvesSettings
		{
			// Token: 0x06011E81 RID: 73345 RVA: 0x007EDD14 File Offset: 0x007EBF14
			public static ColorGradingModel.CurvesSettings DICKGIEMDON()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[7];
				array[0] = new Keyframe(1193f, 1130f, 371f, 440f);
				array[0] = new Keyframe(714f, 757f, 90f, 531f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 734f, true, new Vector2(368f, 243f));
				Keyframe[] array2 = new Keyframe[]
				{
					new Keyframe(1160f, 3f, 187f, 196f)
				};
				array2[0] = new Keyframe(451f, 1669f, 1673f, 739f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1679f, false, new Vector2(1580f, 1843f));
				Keyframe[] array3 = new Keyframe[4];
				array3[1] = new Keyframe(1968f, 1695f, 1373f, 384f);
				array3[1] = new Keyframe(1936f, 637f, 232f, 189f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 254f, false, new Vector2(1383f, 667f));
				Keyframe[] array4 = new Keyframe[5];
				array4[1] = new Keyframe(1672f, 62f, 1735f, 1434f);
				array4[1] = new Keyframe(887f, 1806f, 1979f, 1030f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1570f, true, new Vector2(1457f, 1632f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 761f, true, new Vector2(1133f, 913f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1193f, true, new Vector2(765f, 1629f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 995f, true, new Vector2(765f, 496f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 522f, true, new Vector2(1997f, 1942f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E82 RID: 73346 RVA: 0x007EDF9C File Offset: 0x007EC19C
			public static ColorGradingModel.CurvesSettings KGGHGENABDN()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(409f, 1110f, 286f, 161f);
				array[1] = new Keyframe(343f, 813f, 1948f, 478f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1005f, true, new Vector2(265f, 1120f));
				Keyframe[] array2 = new Keyframe[6];
				array2[0] = new Keyframe(1310f, 500f, 1964f, 676f);
				array2[0] = new Keyframe(970f, 938f, 1264f, 1116f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1808f, false, new Vector2(635f, 502f));
				Keyframe[] array3 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(487f, 754f, 1012f, 1288f)
				};
				array3[0] = new Keyframe(82f, 1071f, 604f, 1913f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 652f, true, new Vector2(816f, 17f));
				Keyframe[] array4 = new Keyframe[6];
				array4[0] = new Keyframe(1732f, 821f, 992f, 878f);
				array4[1] = new Keyframe(1907f, 1180f, 1329f, 709f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 874f, true, new Vector2(1846f, 1169f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 352f, true, new Vector2(1708f, 310f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1426f, true, new Vector2(517f, 715f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1253f, true, new Vector2(898f, 107f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 239f, true, new Vector2(51f, 24f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E83 RID: 73347 RVA: 0x007EE224 File Offset: 0x007EC424
			public static ColorGradingModel.CurvesSettings MEBNDNNHNMB()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1939f, 1325f, 1677f, 1803f)
				};
				array[1] = new Keyframe(847f, 1857f, 1082f, 1093f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1531f, true, new Vector2(1899f, 473f));
				Keyframe[] array2 = new Keyframe[0];
				array2[0] = new Keyframe(847f, 1849f, 1989f, 220f);
				array2[1] = new Keyframe(918f, 344f, 189f, 1533f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 13f, true, new Vector2(134f, 404f));
				Keyframe[] array3 = new Keyframe[6];
				array3[0] = new Keyframe(294f, 827f, 192f, 1878f);
				array3[0] = new Keyframe(1905f, 1717f, 489f, 619f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 384f, true, new Vector2(1311f, 1572f));
				Keyframe[] array4 = new Keyframe[1];
				array4[1] = new Keyframe(960f, 1093f, 398f, 1542f);
				array4[1] = new Keyframe(1599f, 786f, 1681f, 1329f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 744f, true, new Vector2(1136f, 144f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1789f, true, new Vector2(713f, 1452f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1688f, false, new Vector2(1236f, 878f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1706f, false, new Vector2(1299f, 302f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1129f, true, new Vector2(1370f, 1836f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E84 RID: 73348 RVA: 0x007EE4AC File Offset: 0x007EC6AC
			public static ColorGradingModel.CurvesSettings NMGNPHGAGGA()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[1] = new Keyframe(783f, 1831f, 1174f, 595f);
				array[0] = new Keyframe(1873f, 1836f, 1956f, 516f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1057f, false, new Vector2(1679f, 1708f));
				Keyframe[] array2 = new Keyframe[6];
				array2[0] = new Keyframe(276f, 355f, 223f, 865f);
				array2[1] = new Keyframe(222f, 565f, 167f, 1702f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1553f, true, new Vector2(968f, 1325f));
				Keyframe[] array3 = new Keyframe[0];
				array3[0] = new Keyframe(101f, 1095f, 718f, 185f);
				array3[1] = new Keyframe(315f, 1597f, 1602f, 1490f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 945f, true, new Vector2(495f, 735f));
				Keyframe[] array4 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(367f, 738f, 1568f, 1526f)
				};
				array4[0] = new Keyframe(1309f, 1638f, 1777f, 731f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1285f, false, new Vector2(1664f, 1471f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1042f, false, new Vector2(905f, 511f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1868f, true, new Vector2(955f, 1494f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 960f, true, new Vector2(1981f, 1778f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 678f, false, new Vector2(732f, 1919f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E85 RID: 73349 RVA: 0x007EE734 File Offset: 0x007EC934
			public static ColorGradingModel.CurvesSettings ADJNPGFJGJI()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(397f, 1918f, 1773f, 238f);
				array[1] = new Keyframe(1643f, 1295f, 1543f, 357f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1790f, false, new Vector2(305f, 1974f));
				Keyframe[] array2 = new Keyframe[0];
				array2[0] = new Keyframe(1977f, 560f, 1095f, 14f);
				array2[0] = new Keyframe(1395f, 1021f, 778f, 438f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 643f, true, new Vector2(1012f, 1171f));
				Keyframe[] array3 = new Keyframe[2];
				array3[0] = new Keyframe(260f, 335f, 1901f, 1660f);
				array3[0] = new Keyframe(792f, 979f, 153f, 1410f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1648f, true, new Vector2(963f, 1398f));
				Keyframe[] array4 = new Keyframe[8];
				array4[0] = new Keyframe(150f, 1816f, 1245f, 725f);
				array4[0] = new Keyframe(376f, 1067f, 1141f, 280f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 154f, true, new Vector2(1140f, 1335f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1594f, true, new Vector2(631f, 123f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1009f, false, new Vector2(1530f, 1691f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 404f, false, new Vector2(1470f, 1388f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 998f, false, new Vector2(1685f, 366f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E86 RID: 73350 RVA: 0x007EE9BC File Offset: 0x007ECBBC
			public static ColorGradingModel.CurvesSettings BNGFNAFFAME()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(708f, 1716f, 1689f, 1131f);
				array[0] = new Keyframe(1039f, 1006f, 1328f, 551f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 679f, false, new Vector2(1545f, 758f));
				Keyframe[] array2 = new Keyframe[3];
				array2[1] = new Keyframe(1671f, 605f, 383f, 373f);
				array2[0] = new Keyframe(688f, 253f, 1598f, 719f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 506f, false, new Vector2(1779f, 840f));
				Keyframe[] array3 = new Keyframe[1];
				array3[1] = new Keyframe(308f, 1020f, 1314f, 1247f);
				array3[1] = new Keyframe(1618f, 1485f, 552f, 918f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1865f, true, new Vector2(1200f, 1200f));
				result.blue = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(1313f, 865f, 1747f, 70f),
					new Keyframe(908f, 1051f, 1306f, 506f)
				}), 415f, false, new Vector2(118f, 969f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 625f, false, new Vector2(1259f, 166f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 999f, false, new Vector2(370f, 1942f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 231f, true, new Vector2(725f, 1714f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 185f, false, new Vector2(1465f, 507f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E87 RID: 73351 RVA: 0x007EEC44 File Offset: 0x007ECE44
			public static ColorGradingModel.CurvesSettings JIIODGEMCMH()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(1197f, 1283f, 617f, 1134f);
				array[0] = new Keyframe(5f, 372f, 1053f, 218f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 768f, false, new Vector2(1952f, 1127f));
				Keyframe[] array2 = new Keyframe[6];
				array2[0] = new Keyframe(1673f, 1414f, 1563f, 1463f);
				array2[1] = new Keyframe(1912f, 1837f, 1092f, 1750f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 469f, false, new Vector2(214f, 1221f));
				Keyframe[] array3 = new Keyframe[3];
				array3[1] = new Keyframe(874f, 1404f, 793f, 287f);
				array3[1] = new Keyframe(377f, 798f, 718f, 79f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 428f, true, new Vector2(925f, 1001f));
				Keyframe[] array4 = new Keyframe[7];
				array4[1] = new Keyframe(1022f, 569f, 1449f, 167f);
				array4[1] = new Keyframe(1942f, 1036f, 1182f, 981f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 59f, true, new Vector2(190f, 867f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 664f, false, new Vector2(1790f, 1151f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 348f, true, new Vector2(1894f, 1063f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1159f, false, new Vector2(1729f, 1928f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 875f, false, new Vector2(1484f, 1034f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E88 RID: 73352 RVA: 0x007EEECC File Offset: 0x007ED0CC
			public static ColorGradingModel.CurvesSettings BJNIBDPAHBP()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(331f, 300f, 132f, 334f);
				array[1] = new Keyframe(1413f, 1004f, 1910f, 1965f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1339f, false, new Vector2(1479f, 1771f));
				Keyframe[] array2 = new Keyframe[7];
				array2[1] = new Keyframe(1377f, 1731f, 1480f, 43f);
				array2[0] = new Keyframe(955f, 799f, 287f, 1108f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1219f, false, new Vector2(1092f, 550f));
				Keyframe[] array3 = new Keyframe[0];
				array3[0] = new Keyframe(1970f, 26f, 713f, 842f);
				array3[0] = new Keyframe(756f, 1799f, 1047f, 425f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1394f, false, new Vector2(708f, 534f));
				Keyframe[] array4 = new Keyframe[8];
				array4[0] = new Keyframe(187f, 1473f, 1469f, 1036f);
				array4[1] = new Keyframe(1087f, 1977f, 453f, 1864f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 487f, true, new Vector2(13f, 1024f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1114f, true, new Vector2(320f, 454f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1884f, true, new Vector2(1368f, 649f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 765f, false, new Vector2(1268f, 922f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1578f, false, new Vector2(1055f, 648f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E89 RID: 73353 RVA: 0x007EF154 File Offset: 0x007ED354
			public static ColorGradingModel.CurvesSettings HIPJDBACJDH()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[7];
				array[0] = new Keyframe(1152f, 1175f, 670f, 1872f);
				array[0] = new Keyframe(1301f, 339f, 970f, 456f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 603f, true, new Vector2(429f, 1855f));
				Keyframe[] array2 = new Keyframe[6];
				array2[1] = new Keyframe(94f, 483f, 694f, 1300f);
				array2[1] = new Keyframe(1451f, 218f, 1932f, 1241f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1348f, true, new Vector2(1016f, 1630f));
				Keyframe[] array3 = new Keyframe[8];
				array3[0] = new Keyframe(1221f, 1333f, 1622f, 270f);
				array3[0] = new Keyframe(1208f, 768f, 1200f, 1027f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 56f, false, new Vector2(735f, 1309f));
				Keyframe[] array4 = new Keyframe[5];
				array4[1] = new Keyframe(851f, 554f, 1573f, 1299f);
				array4[1] = new Keyframe(391f, 887f, 1457f, 208f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1266f, false, new Vector2(1243f, 1429f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 523f, true, new Vector2(284f, 708f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1056f, true, new Vector2(1381f, 301f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 807f, true, new Vector2(618f, 499f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1325f, true, new Vector2(1667f, 1244f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E8A RID: 73354 RVA: 0x007EF3DC File Offset: 0x007ED5DC
			public static ColorGradingModel.CurvesSettings HLLBKJENCLA()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[7];
				array[0] = new Keyframe(261f, 6f, 1678f, 210f);
				array[1] = new Keyframe(317f, 768f, 157f, 981f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1080f, true, new Vector2(1249f, 67f));
				Keyframe[] array2 = new Keyframe[5];
				array2[0] = new Keyframe(1614f, 155f, 495f, 289f);
				array2[0] = new Keyframe(1979f, 270f, 1420f, 582f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 5f, false, new Vector2(512f, 1604f));
				Keyframe[] array3 = new Keyframe[0];
				array3[0] = new Keyframe(1099f, 1996f, 404f, 1149f);
				array3[1] = new Keyframe(14f, 1022f, 939f, 439f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1734f, true, new Vector2(583f, 1148f));
				Keyframe[] array4 = new Keyframe[6];
				array4[1] = new Keyframe(1235f, 1250f, 1536f, 1982f);
				array4[0] = new Keyframe(775f, 436f, 1109f, 1592f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 369f, true, new Vector2(586f, 1095f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 205f, true, new Vector2(1804f, 1163f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 38f, false, new Vector2(1980f, 1979f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 845f, false, new Vector2(163f, 904f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 592f, true, new Vector2(55f, 555f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E8B RID: 73355 RVA: 0x007EF664 File Offset: 0x007ED864
			public static ColorGradingModel.CurvesSettings MEFEDCEEAMK()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[7];
				array[1] = new Keyframe(1958f, 450f, 500f, 649f);
				array[1] = new Keyframe(843f, 1229f, 294f, 1377f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 919f, true, new Vector2(1564f, 404f));
				Keyframe[] array2 = new Keyframe[3];
				array2[0] = new Keyframe(1744f, 1699f, 1519f, 688f);
				array2[1] = new Keyframe(1183f, 616f, 652f, 67f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 331f, false, new Vector2(1788f, 956f));
				Keyframe[] array3 = new Keyframe[7];
				array3[1] = new Keyframe(216f, 119f, 1986f, 1906f);
				array3[1] = new Keyframe(973f, 1974f, 908f, 1962f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1379f, true, new Vector2(984f, 1711f));
				Keyframe[] array4 = new Keyframe[]
				{
					new Keyframe(847f, 950f, 444f, 933f)
				};
				array4[0] = new Keyframe(838f, 352f, 620f, 1977f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 397f, true, new Vector2(1798f, 433f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 317f, false, new Vector2(1055f, 273f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 523f, false, new Vector2(703f, 1139f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1578f, false, new Vector2(1279f, 1247f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1769f, false, new Vector2(1556f, 1308f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E8C RID: 73356 RVA: 0x007EF8EC File Offset: 0x007EDAEC
			public static ColorGradingModel.CurvesSettings NPEIGPHIHFP()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[6];
				array[0] = new Keyframe(769f, 1167f, 922f, 1257f);
				array[1] = new Keyframe(807f, 832f, 1536f, 1500f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 515f, true, new Vector2(641f, 606f));
				Keyframe[] array2 = new Keyframe[5];
				array2[0] = new Keyframe(480f, 183f, 846f, 1081f);
				array2[1] = new Keyframe(1022f, 355f, 975f, 854f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1585f, false, new Vector2(1555f, 927f));
				Keyframe[] array3 = new Keyframe[6];
				array3[1] = new Keyframe(1039f, 1432f, 792f, 1227f);
				array3[1] = new Keyframe(1831f, 1797f, 1113f, 227f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1424f, false, new Vector2(1188f, 214f));
				Keyframe[] array4 = new Keyframe[7];
				array4[0] = new Keyframe(823f, 1901f, 1676f, 1287f);
				array4[0] = new Keyframe(860f, 1083f, 110f, 129f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1009f, false, new Vector2(192f, 67f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1671f, false, new Vector2(1251f, 1905f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 132f, false, new Vector2(1476f, 495f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1848f, true, new Vector2(1877f, 369f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 682f, true, new Vector2(618f, 1657f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E8D RID: 73357 RVA: 0x007EFB74 File Offset: 0x007EDD74
			public static ColorGradingModel.CurvesSettings OCIMBHLOOGC()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(694f, 652f, 635f, 1417f);
				array[0] = new Keyframe(1398f, 791f, 1803f, 1620f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1256f, false, new Vector2(1078f, 190f));
				Keyframe[] array2 = new Keyframe[8];
				array2[1] = new Keyframe(924f, 638f, 1863f, 529f);
				array2[0] = new Keyframe(255f, 127f, 552f, 868f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1595f, true, new Vector2(1148f, 1901f));
				Keyframe[] array3 = new Keyframe[6];
				array3[1] = new Keyframe(923f, 1944f, 1657f, 632f);
				array3[0] = new Keyframe(735f, 717f, 1885f, 807f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 226f, false, new Vector2(473f, 1932f));
				Keyframe[] array4 = new Keyframe[2];
				array4[0] = new Keyframe(666f, 1218f, 239f, 1353f);
				array4[0] = new Keyframe(1314f, 1275f, 297f, 127f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1445f, false, new Vector2(99f, 1766f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1822f, false, new Vector2(249f, 890f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 395f, true, new Vector2(333f, 865f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1420f, true, new Vector2(1440f, 855f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 207f, false, new Vector2(1056f, 303f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E8E RID: 73358 RVA: 0x007EFDFC File Offset: 0x007EDFFC
			public static ColorGradingModel.CurvesSettings NJJBBDIFPKH()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[5];
				array[1] = new Keyframe(483f, 429f, 430f, 1876f);
				array[0] = new Keyframe(26f, 823f, 257f, 1222f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 101f, false, new Vector2(548f, 1119f));
				Keyframe[] array2 = new Keyframe[6];
				array2[0] = new Keyframe(787f, 1680f, 655f, 1882f);
				array2[1] = new Keyframe(1772f, 1508f, 259f, 724f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1745f, false, new Vector2(1082f, 365f));
				Keyframe[] array3 = new Keyframe[4];
				array3[0] = new Keyframe(1789f, 1314f, 651f, 164f);
				array3[0] = new Keyframe(1611f, 137f, 1070f, 798f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1816f, true, new Vector2(1653f, 245f));
				Keyframe[] array4 = new Keyframe[7];
				array4[0] = new Keyframe(87f, 1995f, 719f, 1060f);
				array4[1] = new Keyframe(825f, 179f, 1350f, 104f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1302f, false, new Vector2(170f, 1706f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 130f, true, new Vector2(944f, 458f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1180f, false, new Vector2(311f, 857f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1896f, false, new Vector2(1504f, 444f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 650f, false, new Vector2(1856f, 65f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E8F RID: 73359 RVA: 0x007F0084 File Offset: 0x007EE284
			public static ColorGradingModel.CurvesSettings NLCHLENDMLI()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(690f, 615f, 380f, 401f);
				array[0] = new Keyframe(1368f, 56f, 207f, 65f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 491f, true, new Vector2(1601f, 1789f));
				Keyframe[] array2 = new Keyframe[4];
				array2[1] = new Keyframe(1710f, 1133f, 35f, 1924f);
				array2[0] = new Keyframe(1340f, 492f, 1674f, 911f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1647f, true, new Vector2(1931f, 1408f));
				Keyframe[] array3 = new Keyframe[1];
				array3[1] = new Keyframe(1560f, 742f, 409f, 187f);
				array3[1] = new Keyframe(255f, 304f, 1560f, 1483f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1057f, true, new Vector2(1424f, 1901f));
				Keyframe[] array4 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(874f, 1716f, 227f, 1683f)
				};
				array4[1] = new Keyframe(29f, 472f, 655f, 425f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1665f, false, new Vector2(941f, 1468f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 754f, true, new Vector2(1436f, 648f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1901f, true, new Vector2(931f, 273f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1192f, true, new Vector2(1608f, 779f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1405f, true, new Vector2(551f, 866f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E90 RID: 73360 RVA: 0x007F030C File Offset: 0x007EE50C
			public static ColorGradingModel.CurvesSettings OOKKEMFPNBJ()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[1] = new Keyframe(544f, 927f, 1064f, 542f);
				array[1] = new Keyframe(380f, 323f, 447f, 128f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1392f, true, new Vector2(1553f, 1052f));
				Keyframe[] array2 = new Keyframe[5];
				array2[0] = new Keyframe(219f, 1372f, 423f, 1690f);
				array2[0] = new Keyframe(560f, 924f, 1483f, 860f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1093f, false, new Vector2(1966f, 1127f));
				Keyframe[] array3 = new Keyframe[7];
				array3[0] = new Keyframe(209f, 1699f, 967f, 665f);
				array3[1] = new Keyframe(962f, 1098f, 960f, 705f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1512f, false, new Vector2(1011f, 1863f));
				Keyframe[] array4 = new Keyframe[1];
				array4[0] = new Keyframe(1787f, 1933f, 887f, 1639f);
				array4[1] = new Keyframe(1632f, 903f, 1301f, 1742f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 618f, true, new Vector2(1444f, 204f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1449f, true, new Vector2(414f, 1195f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 811f, true, new Vector2(1182f, 1840f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 586f, false, new Vector2(1543f, 31f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1121f, false, new Vector2(1718f, 177f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E91 RID: 73361 RVA: 0x007F0594 File Offset: 0x007EE794
			public static ColorGradingModel.CurvesSettings IGIKNGLDPJB()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[0] = new Keyframe(1622f, 1355f, 44f, 663f);
				array[0] = new Keyframe(811f, 779f, 1089f, 1428f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1926f, false, new Vector2(1048f, 1929f));
				Keyframe[] array2 = new Keyframe[0];
				array2[0] = new Keyframe(987f, 1441f, 1686f, 390f);
				array2[0] = new Keyframe(1372f, 1077f, 170f, 1560f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 380f, false, new Vector2(773f, 973f));
				Keyframe[] array3 = new Keyframe[3];
				array3[0] = new Keyframe(178f, 1435f, 308f, 828f);
				array3[1] = new Keyframe(682f, 116f, 1317f, 1093f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 33f, false, new Vector2(1074f, 1476f));
				Keyframe[] array4 = new Keyframe[2];
				array4[0] = new Keyframe(1006f, 625f, 692f, 850f);
				array4[0] = new Keyframe(555f, 1229f, 380f, 750f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1604f, false, new Vector2(1184f, 484f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 282f, false, new Vector2(37f, 1806f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 219f, false, new Vector2(1747f, 1299f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 740f, true, new Vector2(586f, 1862f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 870f, false, new Vector2(593f, 356f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E92 RID: 73362 RVA: 0x007F081C File Offset: 0x007EEA1C
			public static ColorGradingModel.CurvesSettings NNNMNENCOBC()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[8];
				array[1] = new Keyframe(911f, 1790f, 1209f, 1266f);
				array[0] = new Keyframe(1041f, 1770f, 48f, 1649f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 479f, false, new Vector2(437f, 972f));
				Keyframe[] array2 = new Keyframe[4];
				array2[0] = new Keyframe(676f, 1794f, 108f, 1882f);
				array2[1] = new Keyframe(1519f, 1828f, 1881f, 1672f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 574f, true, new Vector2(1197f, 1460f));
				Keyframe[] array3 = new Keyframe[0];
				array3[1] = new Keyframe(976f, 335f, 544f, 85f);
				array3[1] = new Keyframe(37f, 930f, 231f, 766f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 896f, true, new Vector2(885f, 381f));
				Keyframe[] array4 = new Keyframe[3];
				array4[0] = new Keyframe(1583f, 1390f, 19f, 915f);
				array4[1] = new Keyframe(422f, 434f, 1119f, 163f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1761f, true, new Vector2(1908f, 1537f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 691f, true, new Vector2(1844f, 310f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1890f, false, new Vector2(1502f, 1921f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1893f, false, new Vector2(1459f, 1991f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1746f, true, new Vector2(1341f, 985f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E93 RID: 73363 RVA: 0x007F0AA4 File Offset: 0x007EECA4
			public static ColorGradingModel.CurvesSettings HMKDCFKBINK()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[5];
				array[1] = new Keyframe(1624f, 830f, 1142f, 1307f);
				array[1] = new Keyframe(302f, 414f, 1032f, 236f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1902f, false, new Vector2(233f, 943f));
				Keyframe[] array2 = new Keyframe[3];
				array2[1] = new Keyframe(588f, 999f, 1584f, 479f);
				array2[0] = new Keyframe(93f, 770f, 1452f, 11f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1128f, true, new Vector2(1552f, 720f));
				Keyframe[] array3 = new Keyframe[2];
				array3[0] = new Keyframe(352f, 276f, 465f, 65f);
				array3[0] = new Keyframe(595f, 286f, 1209f, 1290f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 950f, true, new Vector2(1866f, 1871f));
				Keyframe[] array4 = new Keyframe[1];
				array4[1] = new Keyframe(1818f, 1080f, 421f, 762f);
				array4[0] = new Keyframe(747f, 1232f, 1597f, 225f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1548f, false, new Vector2(1377f, 1130f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 179f, false, new Vector2(749f, 1693f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 481f, false, new Vector2(1549f, 1975f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1767f, false, new Vector2(48f, 795f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 301f, true, new Vector2(293f, 1528f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E94 RID: 73364 RVA: 0x007F0D2C File Offset: 0x007EEF2C
			public static ColorGradingModel.CurvesSettings HMDLEIJHKEP()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[1] = new Keyframe(1653f, 1001f, 1243f, 942f);
				array[1] = new Keyframe(504f, 1863f, 1084f, 1056f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1155f, false, new Vector2(1557f, 1733f));
				Keyframe[] array2 = new Keyframe[]
				{
					new Keyframe(17f, 600f, 813f, 1631f)
				};
				array2[0] = new Keyframe(1737f, 1774f, 1319f, 1293f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 583f, false, new Vector2(1566f, 1249f));
				Keyframe[] array3 = new Keyframe[1];
				array3[1] = new Keyframe(564f, 1452f, 1401f, 1177f);
				array3[0] = new Keyframe(39f, 436f, 1234f, 1430f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 434f, true, new Vector2(1022f, 1303f));
				Keyframe[] array4 = new Keyframe[5];
				array4[1] = new Keyframe(645f, 1106f, 812f, 281f);
				array4[1] = new Keyframe(364f, 312f, 1712f, 228f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1865f, true, new Vector2(1682f, 1949f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 358f, false, new Vector2(938f, 613f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 767f, true, new Vector2(590f, 565f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 155f, false, new Vector2(186f, 752f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1580f, true, new Vector2(1383f, 1197f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E95 RID: 73365 RVA: 0x007F0FB4 File Offset: 0x007EF1B4
			public static ColorGradingModel.CurvesSettings GCAMLJAKCPF()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[1] = new Keyframe(1957f, 218f, 1350f, 1119f);
				array[0] = new Keyframe(240f, 516f, 1832f, 1217f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1155f, true, new Vector2(1170f, 200f));
				Keyframe[] array2 = new Keyframe[7];
				array2[1] = new Keyframe(1733f, 787f, 1668f, 50f);
				array2[0] = new Keyframe(373f, 1967f, 30f, 957f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 939f, false, new Vector2(653f, 1321f));
				Keyframe[] array3 = new Keyframe[8];
				array3[0] = new Keyframe(763f, 869f, 1895f, 1619f);
				array3[1] = new Keyframe(262f, 786f, 429f, 1296f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1527f, false, new Vector2(216f, 1577f));
				Keyframe[] array4 = new Keyframe[5];
				array4[0] = new Keyframe(1122f, 1327f, 1847f, 842f);
				array4[1] = new Keyframe(328f, 698f, 1259f, 21f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 757f, true, new Vector2(187f, 393f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 180f, false, new Vector2(1586f, 1195f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1877f, false, new Vector2(392f, 161f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1275f, false, new Vector2(1987f, 1122f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 947f, false, new Vector2(371f, 523f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E96 RID: 73366 RVA: 0x007F123C File Offset: 0x007EF43C
			public static ColorGradingModel.CurvesSettings ILFHFFCIBPJ()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[0] = new Keyframe(839f, 1149f, 1106f, 1658f);
				array[1] = new Keyframe(671f, 1415f, 1883f, 1336f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 180f, false, new Vector2(190f, 1698f));
				Keyframe[] array2 = new Keyframe[4];
				array2[1] = new Keyframe(1656f, 1417f, 618f, 734f);
				array2[1] = new Keyframe(71f, 1678f, 1804f, 1363f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 958f, true, new Vector2(320f, 714f));
				Keyframe[] array3 = new Keyframe[2];
				array3[0] = new Keyframe(496f, 600f, 1284f, 1250f);
				array3[0] = new Keyframe(1896f, 422f, 1664f, 1759f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1109f, true, new Vector2(667f, 845f));
				Keyframe[] array4 = new Keyframe[1];
				array4[1] = new Keyframe(1279f, 841f, 1216f, 5f);
				array4[0] = new Keyframe(472f, 1365f, 1974f, 245f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 243f, true, new Vector2(1344f, 1743f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 700f, false, new Vector2(351f, 701f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1334f, true, new Vector2(1683f, 1544f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 905f, false, new Vector2(528f, 1752f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1233f, true, new Vector2(858f, 1624f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E97 RID: 73367 RVA: 0x007F14C4 File Offset: 0x007EF6C4
			public static ColorGradingModel.CurvesSettings CHJKHAAEIDJ()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(168f, 116f, 298f, 615f);
				array[1] = new Keyframe(1357f, 190f, 944f, 978f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1365f, true, new Vector2(640f, 1087f));
				Keyframe[] array2 = new Keyframe[1];
				array2[0] = new Keyframe(1751f, 233f, 339f, 414f);
				array2[1] = new Keyframe(688f, 994f, 306f, 893f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 198f, false, new Vector2(1812f, 1291f));
				Keyframe[] array3 = new Keyframe[3];
				array3[1] = new Keyframe(955f, 1497f, 1636f, 1454f);
				array3[1] = new Keyframe(850f, 239f, 1687f, 1938f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1086f, false, new Vector2(25f, 625f));
				Keyframe[] array4 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1960f, 511f, 736f, 328f)
				};
				array4[1] = new Keyframe(1816f, 1742f, 855f, 1282f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 725f, true, new Vector2(1809f, 1404f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 417f, false, new Vector2(1544f, 898f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 230f, true, new Vector2(410f, 125f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1004f, true, new Vector2(1370f, 1211f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1511f, false, new Vector2(401f, 1327f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E98 RID: 73368 RVA: 0x007F174C File Offset: 0x007EF94C
			public static ColorGradingModel.CurvesSettings JJMHFAELDJK()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[7];
				array[1] = new Keyframe(664f, 1684f, 1042f, 894f);
				array[1] = new Keyframe(1941f, 1981f, 1283f, 1000f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1718f, true, new Vector2(767f, 371f));
				Keyframe[] array2 = new Keyframe[6];
				array2[1] = new Keyframe(296f, 1660f, 1805f, 1555f);
				array2[0] = new Keyframe(1420f, 1119f, 585f, 5f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 127f, true, new Vector2(1072f, 766f));
				Keyframe[] array3 = new Keyframe[]
				{
					new Keyframe(1415f, 187f, 323f, 1872f)
				};
				array3[0] = new Keyframe(77f, 402f, 389f, 1203f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1956f, true, new Vector2(1029f, 288f));
				Keyframe[] array4 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(858f, 143f, 1658f, 597f)
				};
				array4[0] = new Keyframe(164f, 799f, 542f, 966f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1682f, true, new Vector2(1099f, 1037f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 766f, false, new Vector2(869f, 1214f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 967f, false, new Vector2(302f, 1583f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 443f, false, new Vector2(969f, 1603f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1893f, true, new Vector2(601f, 1598f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E99 RID: 73369 RVA: 0x007F19D4 File Offset: 0x007EFBD4
			public static ColorGradingModel.CurvesSettings MCLJECOKBEJ()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(861f, 1832f, 1043f, 1508f)
				};
				array[1] = new Keyframe(863f, 1134f, 1207f, 768f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1573f, false, new Vector2(712f, 1671f));
				Keyframe[] array2 = new Keyframe[1];
				array2[1] = new Keyframe(1122f, 1146f, 1012f, 1253f);
				array2[0] = new Keyframe(1098f, 1240f, 431f, 240f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1416f, true, new Vector2(1874f, 1136f));
				Keyframe[] array3 = new Keyframe[3];
				array3[1] = new Keyframe(501f, 736f, 1355f, 976f);
				array3[0] = new Keyframe(1856f, 1406f, 1728f, 1731f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 843f, true, new Vector2(91f, 1533f));
				Keyframe[] array4 = new Keyframe[7];
				array4[0] = new Keyframe(657f, 165f, 1157f, 1984f);
				array4[1] = new Keyframe(659f, 629f, 1799f, 53f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 637f, true, new Vector2(1400f, 803f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 92f, true, new Vector2(988f, 1997f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 383f, true, new Vector2(1072f, 1964f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1357f, false, new Vector2(1706f, 1766f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1716f, true, new Vector2(1281f, 410f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E9A RID: 73370 RVA: 0x007F1C5C File Offset: 0x007EFE5C
			public static ColorGradingModel.CurvesSettings DBGPLELNOMP()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[0] = new Keyframe(434f, 1193f, 255f, 595f);
				array[1] = new Keyframe(123f, 1101f, 449f, 1783f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 432f, true, new Vector2(1482f, 2f));
				Keyframe[] array2 = new Keyframe[4];
				array2[0] = new Keyframe(656f, 519f, 409f, 1084f);
				array2[1] = new Keyframe(440f, 409f, 625f, 780f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 544f, false, new Vector2(1863f, 255f));
				Keyframe[] array3 = new Keyframe[3];
				array3[0] = new Keyframe(578f, 721f, 1048f, 67f);
				array3[1] = new Keyframe(786f, 243f, 520f, 1434f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1387f, false, new Vector2(1966f, 1089f));
				Keyframe[] array4 = new Keyframe[5];
				array4[0] = new Keyframe(1898f, 1642f, 1891f, 1057f);
				array4[1] = new Keyframe(1749f, 1444f, 184f, 1042f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1694f, false, new Vector2(567f, 1475f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 51f, true, new Vector2(259f, 846f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1660f, true, new Vector2(1853f, 616f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 434f, true, new Vector2(1979f, 1220f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 412f, true, new Vector2(974f, 1697f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E9B RID: 73371 RVA: 0x007F1EE4 File Offset: 0x007F00E4
			public static ColorGradingModel.CurvesSettings MJLLLKFIDOE()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[0] = new Keyframe(1539f, 1812f, 493f, 1751f);
				array[1] = new Keyframe(565f, 1432f, 464f, 162f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 60f, true, new Vector2(212f, 941f));
				Keyframe[] array2 = new Keyframe[1];
				array2[1] = new Keyframe(1189f, 885f, 1204f, 1933f);
				array2[0] = new Keyframe(1924f, 1204f, 1895f, 430f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 980f, false, new Vector2(232f, 375f));
				Keyframe[] array3 = new Keyframe[4];
				array3[0] = new Keyframe(757f, 1987f, 588f, 1637f);
				array3[0] = new Keyframe(1538f, 1319f, 1580f, 1459f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 523f, false, new Vector2(979f, 277f));
				Keyframe[] array4 = new Keyframe[8];
				array4[1] = new Keyframe(153f, 1900f, 531f, 1681f);
				array4[0] = new Keyframe(173f, 1340f, 1367f, 1190f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 846f, false, new Vector2(1917f, 62f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 771f, false, new Vector2(333f, 1056f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1388f, true, new Vector2(1303f, 1427f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1624f, true, new Vector2(276f, 1553f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1870f, true, new Vector2(1744f, 1409f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E9C RID: 73372 RVA: 0x007F216C File Offset: 0x007F036C
			public static ColorGradingModel.CurvesSettings DHCNIDFOOPO()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[0] = new Keyframe(1528f, 139f, 652f, 1806f);
				array[1] = new Keyframe(760f, 38f, 496f, 1414f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1530f, true, new Vector2(530f, 770f));
				Keyframe[] array2 = new Keyframe[3];
				array2[0] = new Keyframe(1375f, 1735f, 690f, 1292f);
				array2[1] = new Keyframe(1178f, 543f, 1246f, 734f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 442f, false, new Vector2(312f, 227f));
				Keyframe[] array3 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1134f, 337f, 1493f, 1980f)
				};
				array3[0] = new Keyframe(917f, 1667f, 1719f, 779f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 326f, false, new Vector2(1993f, 931f));
				Keyframe[] array4 = new Keyframe[2];
				array4[0] = new Keyframe(757f, 233f, 1095f, 886f);
				array4[0] = new Keyframe(1254f, 749f, 703f, 1401f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1133f, false, new Vector2(893f, 1917f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1363f, true, new Vector2(448f, 1810f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1971f, true, new Vector2(395f, 718f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1037f, false, new Vector2(1895f, 1161f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1707f, false, new Vector2(1910f, 966f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011E9D RID: 73373 RVA: 0x007F23F4 File Offset: 0x007F05F4
			public static ColorGradingModel.CurvesSettings JGNKGPFJFHO()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[8];
				array[1] = new Keyframe(456f, 1683f, 7f, 84f);
				array[0] = new Keyframe(517f, 1691f, 660f, 204f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 970f, false, new Vector2(714f, 1619f));
				Keyframe[] array2 = new Keyframe[5];
				array2[1] = new Keyframe(516f, 33f, 1488f, 1581f);
				array2[1] = new Keyframe(1188f, 653f, 1591f, 937f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1354f, true, new Vector2(976f, 949f));
				Keyframe[] array3 = new Keyframe[6];
				array3[0] = new Keyframe(677f, 763f, 1482f, 11f);
				array3[0] = new Keyframe(1186f, 602f, 435f, 627f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 14f, false, new Vector2(1438f, 243f));
				Keyframe[] array4 = new Keyframe[0];
				array4[0] = new Keyframe(1452f, 812f, 1313f, 1010f);
				array4[0] = new Keyframe(1131f, 874f, 1211f, 634f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 154f, true, new Vector2(92f, 1070f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 729f, false, new Vector2(1541f, 741f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1230f, true, new Vector2(293f, 171f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1232f, true, new Vector2(394f, 666f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1914f, true, new Vector2(860f, 1566f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011E9E RID: 73374 RVA: 0x007F267C File Offset: 0x007F087C
			public static ColorGradingModel.CurvesSettings MKEJGGFNILJ()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[2];
				array[0] = new Keyframe(1356f, 1914f, 537f, 1463f);
				array[0] = new Keyframe(695f, 647f, 102f, 153f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1397f, false, new Vector2(1887f, 516f));
				Keyframe[] array2 = new Keyframe[1];
				array2[0] = new Keyframe(43f, 1653f, 1941f, 452f);
				array2[1] = new Keyframe(842f, 1888f, 768f, 1504f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1552f, false, new Vector2(1075f, 802f));
				Keyframe[] array3 = new Keyframe[6];
				array3[1] = new Keyframe(886f, 1345f, 1754f, 1926f);
				array3[1] = new Keyframe(1750f, 885f, 1452f, 1935f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 952f, true, new Vector2(1581f, 350f));
				Keyframe[] array4 = new Keyframe[6];
				array4[1] = new Keyframe(1017f, 1957f, 729f, 1612f);
				array4[1] = new Keyframe(1793f, 1747f, 1369f, 1186f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1922f, true, new Vector2(1145f, 1032f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1911f, false, new Vector2(1619f, 1844f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 719f, false, new Vector2(511f, 1331f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 133f, false, new Vector2(888f, 919f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1158f, false, new Vector2(5f, 1499f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x06011E9F RID: 73375 RVA: 0x007F2904 File Offset: 0x007F0B04
			public static ColorGradingModel.CurvesSettings defaultSettings
			{
				get
				{
					return new ColorGradingModel.CurvesSettings
					{
						master = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						red = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						green = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						blue = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
						{
							new Keyframe(0f, 0f, 1f, 1f),
							new Keyframe(1f, 1f, 1f, 1f)
						}), 0f, false, new Vector2(0f, 1f)),
						hueVShue = new ColorGradingCurve(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f)),
						hueVSsat = new ColorGradingCurve(new AnimationCurve(), 0.5f, true, new Vector2(0f, 1f)),
						satVSsat = new ColorGradingCurve(new AnimationCurve(), 0.5f, false, new Vector2(0f, 1f)),
						lumVSsat = new ColorGradingCurve(new AnimationCurve(), 0.5f, false, new Vector2(0f, 1f)),
						e_CurrentEditingCurve = 0,
						e_CurveY = true,
						e_CurveR = false,
						e_CurveG = false,
						e_CurveB = false
					};
				}
			}

			// Token: 0x06011EA0 RID: 73376 RVA: 0x007F2B8C File Offset: 0x007F0D8C
			public static ColorGradingModel.CurvesSettings LNGBMOGJKGD()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(1639f, 832f, 213f, 1956f);
				array[1] = new Keyframe(663f, 218f, 983f, 1639f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1730f, true, new Vector2(1311f, 172f));
				Keyframe[] array2 = new Keyframe[3];
				array2[1] = new Keyframe(1787f, 193f, 1629f, 975f);
				array2[0] = new Keyframe(1799f, 917f, 1889f, 1790f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 464f, false, new Vector2(1453f, 1175f));
				Keyframe[] array3 = new Keyframe[]
				{
					new Keyframe(1338f, 909f, 18f, 1373f)
				};
				array3[0] = new Keyframe(1300f, 213f, 1519f, 1174f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1184f, true, new Vector2(893f, 730f));
				Keyframe[] array4 = new Keyframe[4];
				array4[1] = new Keyframe(1307f, 1485f, 1902f, 777f);
				array4[0] = new Keyframe(1112f, 1099f, 1786f, 374f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 78f, false, new Vector2(942f, 422f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1492f, false, new Vector2(1210f, 1043f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 711f, false, new Vector2(392f, 532f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1292f, false, new Vector2(507f, 1756f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1574f, false, new Vector2(455f, 1790f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011EA1 RID: 73377 RVA: 0x007F2E14 File Offset: 0x007F1014
			public static ColorGradingModel.CurvesSettings COINKHKLJAP()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(22f, 1237f, 235f, 1864f);
				array[1] = new Keyframe(8f, 1508f, 223f, 1174f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1541f, false, new Vector2(1083f, 324f));
				Keyframe[] array2 = new Keyframe[5];
				array2[0] = new Keyframe(1407f, 1644f, 1194f, 1269f);
				array2[0] = new Keyframe(1164f, 1685f, 763f, 47f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 795f, true, new Vector2(1695f, 198f));
				Keyframe[] array3 = new Keyframe[1];
				array3[1] = new Keyframe(699f, 833f, 1499f, 1710f);
				array3[0] = new Keyframe(1286f, 67f, 839f, 1640f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1570f, false, new Vector2(1056f, 73f));
				Keyframe[] array4 = new Keyframe[1];
				array4[0] = new Keyframe(473f, 984f, 1149f, 1738f);
				array4[1] = new Keyframe(660f, 539f, 214f, 926f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 179f, false, new Vector2(473f, 188f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1069f, false, new Vector2(313f, 1310f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1786f, true, new Vector2(842f, 1756f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1584f, false, new Vector2(882f, 1173f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1339f, false, new Vector2(1553f, 1699f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EA2 RID: 73378 RVA: 0x007F309C File Offset: 0x007F129C
			public static ColorGradingModel.CurvesSettings DCMDLNNCGAC()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[0] = new Keyframe(479f, 789f, 1934f, 64f);
				array[1] = new Keyframe(1874f, 861f, 1746f, 75f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 393f, false, new Vector2(687f, 1940f));
				Keyframe[] array2 = new Keyframe[5];
				array2[0] = new Keyframe(622f, 754f, 598f, 1847f);
				array2[0] = new Keyframe(1860f, 1719f, 218f, 1970f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 326f, false, new Vector2(181f, 600f));
				Keyframe[] array3 = new Keyframe[7];
				array3[1] = new Keyframe(195f, 363f, 1868f, 781f);
				array3[0] = new Keyframe(1087f, 1020f, 327f, 551f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1400f, true, new Vector2(240f, 1047f));
				result.blue = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(1684f, 582f, 673f, 1817f),
					new Keyframe(129f, 1599f, 1969f, 1994f)
				}), 944f, false, new Vector2(571f, 1963f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1737f, false, new Vector2(1692f, 260f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 147f, false, new Vector2(198f, 1885f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 819f, true, new Vector2(451f, 1251f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1601f, false, new Vector2(46f, 446f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EA3 RID: 73379 RVA: 0x007F3324 File Offset: 0x007F1524
			public static ColorGradingModel.CurvesSettings MGIIIBAJNIE()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[1] = new Keyframe(446f, 323f, 1629f, 1192f);
				array[1] = new Keyframe(1621f, 1505f, 1269f, 1652f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1643f, false, new Vector2(283f, 1017f));
				Keyframe[] array2 = new Keyframe[6];
				array2[1] = new Keyframe(1046f, 252f, 955f, 1746f);
				array2[1] = new Keyframe(1775f, 1336f, 1212f, 1969f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1382f, false, new Vector2(1096f, 1723f));
				Keyframe[] array3 = new Keyframe[7];
				array3[0] = new Keyframe(1544f, 1101f, 948f, 865f);
				array3[1] = new Keyframe(685f, 722f, 337f, 497f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 782f, false, new Vector2(201f, 1736f));
				Keyframe[] array4 = new Keyframe[6];
				array4[1] = new Keyframe(1401f, 1348f, 1803f, 476f);
				array4[0] = new Keyframe(742f, 835f, 746f, 675f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1991f, true, new Vector2(1111f, 1659f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1810f, false, new Vector2(524f, 1782f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1516f, true, new Vector2(98f, 1457f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1334f, false, new Vector2(1702f, 1269f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 324f, true, new Vector2(458f, 963f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011EA4 RID: 73380 RVA: 0x007F35AC File Offset: 0x007F17AC
			public static ColorGradingModel.CurvesSettings GDKPNHJPBKJ()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[0] = new Keyframe(1304f, 1148f, 1517f, 1610f);
				array[1] = new Keyframe(547f, 862f, 1061f, 1441f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 431f, false, new Vector2(834f, 872f));
				result.red = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(1365f, 1406f, 1259f, 191f),
					new Keyframe(1214f, 615f, 1278f, 215f)
				}), 322f, true, new Vector2(139f, 1184f));
				Keyframe[] array2 = new Keyframe[7];
				array2[1] = new Keyframe(1098f, 472f, 1744f, 580f);
				array2[1] = new Keyframe(32f, 1362f, 701f, 893f);
				result.green = new ColorGradingCurve(new AnimationCurve(array2), 1349f, false, new Vector2(442f, 1002f));
				Keyframe[] array3 = new Keyframe[0];
				array3[1] = new Keyframe(1022f, 1192f, 1368f, 1645f);
				array3[1] = new Keyframe(1135f, 1347f, 1466f, 1179f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array3), 1148f, false, new Vector2(1869f, 1302f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1287f, false, new Vector2(408f, 1677f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1351f, true, new Vector2(1332f, 466f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1089f, false, new Vector2(1443f, 440f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 2f, false, new Vector2(366f, 841f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011EA5 RID: 73381 RVA: 0x007F3834 File Offset: 0x007F1A34
			public static ColorGradingModel.CurvesSettings FBBLPICJODA()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[8];
				array[0] = new Keyframe(122f, 734f, 33f, 949f);
				array[1] = new Keyframe(1557f, 1223f, 995f, 1498f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1632f, true, new Vector2(761f, 1995f));
				Keyframe[] array2 = new Keyframe[1];
				array2[0] = new Keyframe(637f, 918f, 1181f, 266f);
				array2[1] = new Keyframe(106f, 988f, 1263f, 431f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 636f, false, new Vector2(557f, 1307f));
				Keyframe[] array3 = new Keyframe[4];
				array3[1] = new Keyframe(1404f, 908f, 403f, 1955f);
				array3[1] = new Keyframe(1485f, 806f, 798f, 243f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1183f, true, new Vector2(1590f, 364f));
				Keyframe[] array4 = new Keyframe[5];
				array4[1] = new Keyframe(1832f, 360f, 1861f, 1442f);
				array4[0] = new Keyframe(587f, 1897f, 1107f, 404f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1975f, true, new Vector2(1470f, 1601f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 312f, true, new Vector2(1000f, 1915f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 51f, true, new Vector2(227f, 126f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 357f, false, new Vector2(647f, 1370f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1831f, false, new Vector2(938f, 1082f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EA6 RID: 73382 RVA: 0x007F3ABC File Offset: 0x007F1CBC
			public static ColorGradingModel.CurvesSettings FMLMIDJIEOP()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(1246f, 1176f, 1402f, 709f);
				array[0] = new Keyframe(272f, 873f, 567f, 1573f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1063f, false, new Vector2(78f, 258f));
				Keyframe[] array2 = new Keyframe[4];
				array2[0] = new Keyframe(229f, 1255f, 390f, 66f);
				array2[1] = new Keyframe(100f, 1207f, 251f, 827f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 376f, true, new Vector2(1980f, 417f));
				Keyframe[] array3 = new Keyframe[6];
				array3[1] = new Keyframe(1537f, 1830f, 991f, 1231f);
				array3[0] = new Keyframe(339f, 105f, 1389f, 1102f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1062f, true, new Vector2(1135f, 1695f));
				Keyframe[] array4 = new Keyframe[5];
				array4[1] = new Keyframe(380f, 704f, 1668f, 888f);
				array4[1] = new Keyframe(601f, 1731f, 1913f, 230f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1192f, false, new Vector2(925f, 574f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 333f, false, new Vector2(291f, 455f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1057f, false, new Vector2(1525f, 696f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1087f, true, new Vector2(490f, 345f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 124f, true, new Vector2(1288f, 1004f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EA7 RID: 73383 RVA: 0x007F3D44 File Offset: 0x007F1F44
			public static ColorGradingModel.CurvesSettings COJPKDJKJAM()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[5];
				array[0] = new Keyframe(710f, 684f, 795f, 533f);
				array[0] = new Keyframe(504f, 30f, 468f, 73f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1410f, true, new Vector2(1009f, 616f));
				Keyframe[] array2 = new Keyframe[6];
				array2[1] = new Keyframe(1130f, 1528f, 1074f, 1804f);
				array2[0] = new Keyframe(347f, 1673f, 631f, 315f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1224f, false, new Vector2(938f, 700f));
				Keyframe[] array3 = new Keyframe[6];
				array3[0] = new Keyframe(87f, 235f, 1227f, 1783f);
				array3[0] = new Keyframe(1389f, 659f, 1454f, 1604f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1264f, false, new Vector2(693f, 1185f));
				Keyframe[] array4 = new Keyframe[3];
				array4[0] = new Keyframe(515f, 717f, 623f, 1860f);
				array4[0] = new Keyframe(1437f, 428f, 280f, 556f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 368f, true, new Vector2(52f, 479f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1309f, true, new Vector2(1566f, 1329f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1045f, true, new Vector2(1323f, 1714f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1781f, false, new Vector2(551f, 182f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 470f, false, new Vector2(1469f, 539f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EA8 RID: 73384 RVA: 0x007F3FCC File Offset: 0x007F21CC
			public static ColorGradingModel.CurvesSettings DELLGIGMFLC()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(1341f, 388f, 679f, 385f);
				array[1] = new Keyframe(92f, 846f, 1941f, 24f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1750f, false, new Vector2(1771f, 1877f));
				Keyframe[] array2 = new Keyframe[5];
				array2[0] = new Keyframe(1451f, 198f, 92f, 1720f);
				array2[1] = new Keyframe(1199f, 1725f, 430f, 1238f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 838f, true, new Vector2(713f, 1948f));
				Keyframe[] array3 = new Keyframe[6];
				array3[0] = new Keyframe(1993f, 1678f, 332f, 1231f);
				array3[0] = new Keyframe(1582f, 800f, 10f, 1084f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 945f, true, new Vector2(1953f, 1136f));
				Keyframe[] array4 = new Keyframe[8];
				array4[1] = new Keyframe(139f, 1088f, 1509f, 1162f);
				array4[0] = new Keyframe(454f, 1831f, 1964f, 1232f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 17f, true, new Vector2(1958f, 1440f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1546f, true, new Vector2(1379f, 898f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 567f, true, new Vector2(1757f, 677f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1438f, false, new Vector2(709f, 440f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 651f, false, new Vector2(1008f, 774f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EA9 RID: 73385 RVA: 0x007F4254 File Offset: 0x007F2454
			public static ColorGradingModel.CurvesSettings BFFANDBCLFI()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(1513f, 494f, 1336f, 1993f);
				array[1] = new Keyframe(849f, 355f, 845f, 742f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 775f, true, new Vector2(763f, 1074f));
				Keyframe[] array2 = new Keyframe[0];
				array2[0] = new Keyframe(993f, 617f, 1958f, 1422f);
				array2[0] = new Keyframe(201f, 113f, 1952f, 403f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 922f, true, new Vector2(1474f, 240f));
				Keyframe[] array3 = new Keyframe[5];
				array3[1] = new Keyframe(523f, 82f, 921f, 697f);
				array3[0] = new Keyframe(1390f, 204f, 1375f, 1076f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1916f, false, new Vector2(423f, 180f));
				Keyframe[] array4 = new Keyframe[3];
				array4[0] = new Keyframe(291f, 1574f, 263f, 1423f);
				array4[1] = new Keyframe(1682f, 542f, 1609f, 196f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1422f, true, new Vector2(542f, 933f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1070f, true, new Vector2(1374f, 114f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1578f, true, new Vector2(251f, 1849f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1841f, false, new Vector2(1185f, 1433f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 788f, true, new Vector2(882f, 1505f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EAA RID: 73386 RVA: 0x007F44DC File Offset: 0x007F26DC
			public static ColorGradingModel.CurvesSettings PIAJOHPDMNA()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[1] = new Keyframe(1721f, 135f, 356f, 711f);
				array[0] = new Keyframe(227f, 1601f, 1827f, 101f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1905f, true, new Vector2(168f, 1942f));
				Keyframe[] array2 = new Keyframe[6];
				array2[1] = new Keyframe(1310f, 700f, 1532f, 1353f);
				array2[1] = new Keyframe(908f, 1550f, 1740f, 664f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1915f, false, new Vector2(1447f, 1788f));
				Keyframe[] array3 = new Keyframe[3];
				array3[0] = new Keyframe(1729f, 1030f, 1229f, 187f);
				array3[1] = new Keyframe(1451f, 846f, 814f, 1329f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 513f, false, new Vector2(1834f, 1696f));
				Keyframe[] array4 = new Keyframe[3];
				array4[1] = new Keyframe(570f, 1896f, 1844f, 134f);
				array4[1] = new Keyframe(1178f, 787f, 1736f, 725f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 324f, false, new Vector2(394f, 1691f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 796f, true, new Vector2(780f, 1813f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1041f, true, new Vector2(176f, 724f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 939f, true, new Vector2(106f, 360f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 464f, true, new Vector2(203f, 839f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EAB RID: 73387 RVA: 0x007F4764 File Offset: 0x007F2964
			public static ColorGradingModel.CurvesSettings MDDBLMDKDAO()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[0];
				array[1] = new Keyframe(1488f, 408f, 1269f, 1306f);
				array[0] = new Keyframe(1224f, 47f, 145f, 1517f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 893f, true, new Vector2(1623f, 1097f));
				Keyframe[] array2 = new Keyframe[6];
				array2[0] = new Keyframe(637f, 1170f, 182f, 1200f);
				array2[1] = new Keyframe(1344f, 1608f, 106f, 1220f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1185f, true, new Vector2(1803f, 1069f));
				result.green = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(1366f, 143f, 881f, 1336f),
					new Keyframe(402f, 1955f, 1876f, 1442f)
				}), 1362f, false, new Vector2(1398f, 513f));
				Keyframe[] array3 = new Keyframe[]
				{
					new Keyframe(95f, 1080f, 570f, 1348f)
				};
				array3[0] = new Keyframe(1959f, 655f, 104f, 654f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array3), 1734f, true, new Vector2(301f, 49f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 121f, true, new Vector2(1420f, 977f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1586f, true, new Vector2(1526f, 1368f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 741f, true, new Vector2(1661f, 1797f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 682f, true, new Vector2(739f, 1838f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011EAC RID: 73388 RVA: 0x007F49EC File Offset: 0x007F2BEC
			public static ColorGradingModel.CurvesSettings AAPKKAPOLKH()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(786f, 1213f, 1785f, 161f)
				};
				array[1] = new Keyframe(1100f, 1214f, 853f, 1624f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1359f, false, new Vector2(1187f, 1566f));
				Keyframe[] array2 = new Keyframe[4];
				array2[1] = new Keyframe(1352f, 198f, 983f, 700f);
				array2[0] = new Keyframe(799f, 722f, 1508f, 266f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 823f, true, new Vector2(1734f, 771f));
				Keyframe[] array3 = new Keyframe[4];
				array3[1] = new Keyframe(1861f, 847f, 1248f, 175f);
				array3[0] = new Keyframe(1354f, 1998f, 1595f, 962f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 338f, true, new Vector2(1855f, 816f));
				Keyframe[] array4 = new Keyframe[5];
				array4[1] = new Keyframe(1821f, 1208f, 452f, 1859f);
				array4[1] = new Keyframe(275f, 595f, 1998f, 206f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 404f, false, new Vector2(1704f, 1519f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1338f, false, new Vector2(1366f, 442f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1827f, false, new Vector2(1497f, 1615f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1938f, true, new Vector2(933f, 31f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1354f, false, new Vector2(20f, 362f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011EAD RID: 73389 RVA: 0x007F4C74 File Offset: 0x007F2E74
			public static ColorGradingModel.CurvesSettings JACPKLDIIKG()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[1] = new Keyframe(817f, 1994f, 29f, 1981f);
				array[0] = new Keyframe(725f, 1274f, 1540f, 848f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1271f, false, new Vector2(1307f, 542f));
				result.red = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(1150f, 551f, 902f, 450f),
					new Keyframe(1078f, 1989f, 483f, 440f)
				}), 1660f, false, new Vector2(226f, 1644f));
				Keyframe[] array2 = new Keyframe[6];
				array2[1] = new Keyframe(1282f, 440f, 1537f, 163f);
				array2[1] = new Keyframe(1584f, 999f, 270f, 1377f);
				result.green = new ColorGradingCurve(new AnimationCurve(array2), 1116f, true, new Vector2(1645f, 585f));
				Keyframe[] array3 = new Keyframe[6];
				array3[0] = new Keyframe(1574f, 963f, 1510f, 933f);
				array3[0] = new Keyframe(597f, 748f, 180f, 1033f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array3), 132f, false, new Vector2(1510f, 1589f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 320f, false, new Vector2(499f, 1630f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 73f, true, new Vector2(1988f, 1864f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1769f, false, new Vector2(1162f, 1259f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 151f, false, new Vector2(1524f, 1334f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = true;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EAE RID: 73390 RVA: 0x007F4EFC File Offset: 0x007F30FC
			public static ColorGradingModel.CurvesSettings OAMPGBKMKFF()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[8];
				array[0] = new Keyframe(1053f, 1059f, 1267f, 1837f);
				array[0] = new Keyframe(1811f, 227f, 287f, 186f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1931f, false, new Vector2(29f, 638f));
				Keyframe[] array2 = new Keyframe[1];
				array2[0] = new Keyframe(1994f, 1749f, 466f, 1862f);
				array2[1] = new Keyframe(1720f, 239f, 770f, 1246f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1552f, false, new Vector2(836f, 1073f));
				Keyframe[] array3 = new Keyframe[2];
				array3[0] = new Keyframe(647f, 1217f, 131f, 1025f);
				array3[0] = new Keyframe(1289f, 1739f, 56f, 841f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1347f, false, new Vector2(1442f, 1741f));
				Keyframe[] array4 = new Keyframe[4];
				array4[0] = new Keyframe(1454f, 396f, 1733f, 408f);
				array4[0] = new Keyframe(1698f, 1752f, 1584f, 189f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1044f, false, new Vector2(288f, 20f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 285f, false, new Vector2(975f, 1154f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1762f, true, new Vector2(1283f, 836f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1898f, true, new Vector2(313f, 1288f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 254f, true, new Vector2(1625f, 515f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011EAF RID: 73391 RVA: 0x007F5184 File Offset: 0x007F3384
			public static ColorGradingModel.CurvesSettings OOFOKHIDMDG()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				result.master = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(1190f, 1987f, 1623f, 1138f),
					new Keyframe(567f, 3f, 1949f, 604f)
				}), 1852f, true, new Vector2(1663f, 1332f));
				Keyframe[] array = new Keyframe[6];
				array[0] = new Keyframe(1614f, 1015f, 1840f, 883f);
				array[1] = new Keyframe(1840f, 692f, 236f, 1592f);
				result.red = new ColorGradingCurve(new AnimationCurve(array), 1741f, true, new Vector2(1069f, 661f));
				Keyframe[] array2 = new Keyframe[8];
				array2[1] = new Keyframe(701f, 1376f, 1611f, 1273f);
				array2[0] = new Keyframe(732f, 1111f, 1372f, 1356f);
				result.green = new ColorGradingCurve(new AnimationCurve(array2), 1565f, false, new Vector2(939f, 314f));
				Keyframe[] array3 = new Keyframe[5];
				array3[0] = new Keyframe(342f, 167f, 720f, 399f);
				array3[1] = new Keyframe(225f, 490f, 1651f, 1293f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array3), 505f, false, new Vector2(1750f, 31f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1396f, false, new Vector2(1498f, 1342f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 20f, false, new Vector2(1150f, 164f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 52f, false, new Vector2(741f, 129f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 503f, true, new Vector2(484f, 1317f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011EB0 RID: 73392 RVA: 0x007F540C File Offset: 0x007F360C
			public static ColorGradingModel.CurvesSettings CGGMKBADCBM()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[8];
				array[0] = new Keyframe(967f, 479f, 1066f, 252f);
				array[1] = new Keyframe(1172f, 1312f, 280f, 357f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 486f, false, new Vector2(1033f, 1496f));
				Keyframe[] array2 = new Keyframe[5];
				array2[0] = new Keyframe(1677f, 718f, 1302f, 489f);
				array2[0] = new Keyframe(625f, 1528f, 256f, 998f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 929f, false, new Vector2(1978f, 1150f));
				Keyframe[] array3 = new Keyframe[6];
				array3[1] = new Keyframe(524f, 420f, 607f, 184f);
				array3[1] = new Keyframe(288f, 559f, 338f, 826f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 983f, true, new Vector2(1906f, 395f));
				Keyframe[] array4 = new Keyframe[4];
				array4[0] = new Keyframe(349f, 1700f, 972f, 459f);
				array4[0] = new Keyframe(1291f, 123f, 1448f, 1239f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 127f, true, new Vector2(222f, 68f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1322f, true, new Vector2(1193f, 162f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 871f, false, new Vector2(1961f, 455f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 425f, true, new Vector2(1631f, 1967f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1117f, false, new Vector2(475f, 1506f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011EB1 RID: 73393 RVA: 0x007F5694 File Offset: 0x007F3894
			public static ColorGradingModel.CurvesSettings FLPFAGHMGNN()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[0] = new Keyframe(269f, 540f, 1944f, 1855f);
				array[1] = new Keyframe(1194f, 1230f, 1498f, 1054f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1637f, true, new Vector2(447f, 1746f));
				Keyframe[] array2 = new Keyframe[8];
				array2[1] = new Keyframe(565f, 846f, 7f, 1850f);
				array2[1] = new Keyframe(1049f, 1318f, 1904f, 1511f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1865f, false, new Vector2(991f, 1717f));
				Keyframe[] array3 = new Keyframe[6];
				array3[0] = new Keyframe(521f, 1789f, 935f, 420f);
				array3[1] = new Keyframe(419f, 865f, 1328f, 626f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 205f, false, new Vector2(1985f, 1156f));
				Keyframe[] array4 = new Keyframe[7];
				array4[1] = new Keyframe(595f, 379f, 856f, 1282f);
				array4[0] = new Keyframe(298f, 1925f, 1976f, 812f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1318f, false, new Vector2(636f, 432f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1990f, true, new Vector2(202f, 1513f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1979f, false, new Vector2(1116f, 1248f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1511f, true, new Vector2(416f, 872f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1700f, true, new Vector2(1380f, 1645f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EB2 RID: 73394 RVA: 0x007F591C File Offset: 0x007F3B1C
			public static ColorGradingModel.CurvesSettings ELPHMKAEDHE()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[1] = new Keyframe(1799f, 1690f, 1597f, 462f);
				array[1] = new Keyframe(1986f, 900f, 1258f, 651f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 125f, false, new Vector2(619f, 40f));
				Keyframe[] array2 = new Keyframe[3];
				array2[0] = new Keyframe(1125f, 1589f, 343f, 1406f);
				array2[1] = new Keyframe(1586f, 1747f, 1717f, 556f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 906f, true, new Vector2(631f, 1557f));
				Keyframe[] array3 = new Keyframe[]
				{
					new Keyframe(1606f, 1856f, 86f, 1505f)
				};
				array3[0] = new Keyframe(178f, 12f, 492f, 175f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 974f, false, new Vector2(722f, 1126f));
				Keyframe[] array4 = new Keyframe[2];
				array4[0] = new Keyframe(113f, 1879f, 1288f, 1101f);
				array4[0] = new Keyframe(33f, 1522f, 1780f, 1569f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1813f, false, new Vector2(1973f, 1041f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1556f, true, new Vector2(1355f, 1342f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 870f, false, new Vector2(519f, 704f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 532f, false, new Vector2(99f, 448f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1113f, true, new Vector2(167f, 431f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = false;
				result.e_CurveR = false;
				result.e_CurveG = true;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011EB3 RID: 73395 RVA: 0x007F5BA4 File Offset: 0x007F3DA4
			public static ColorGradingModel.CurvesSettings MDDFLLOCDEA()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[3];
				array[0] = new Keyframe(547f, 1406f, 649f, 1647f);
				array[1] = new Keyframe(1529f, 1187f, 1795f, 635f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 950f, false, new Vector2(145f, 1976f));
				Keyframe[] array2 = new Keyframe[7];
				array2[0] = new Keyframe(275f, 279f, 1629f, 1245f);
				array2[1] = new Keyframe(799f, 498f, 1794f, 561f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 219f, true, new Vector2(43f, 1662f));
				Keyframe[] array3 = new Keyframe[]
				{
					new Keyframe(1393f, 892f, 1922f, 1340f)
				};
				array3[0] = new Keyframe(989f, 1007f, 686f, 1217f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1890f, false, new Vector2(1644f, 220f));
				Keyframe[] array4 = new Keyframe[5];
				array4[0] = new Keyframe(911f, 326f, 462f, 1704f);
				array4[1] = new Keyframe(1660f, 743f, 1684f, 1078f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 110f, false, new Vector2(1611f, 87f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1427f, true, new Vector2(1486f, 1524f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1424f, false, new Vector2(1557f, 1170f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 222f, false, new Vector2(1278f, 1088f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1267f, true, new Vector2(412f, 1354f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EB4 RID: 73396 RVA: 0x007F5E2C File Offset: 0x007F402C
			public static ColorGradingModel.CurvesSettings MDGIIBPIGJC()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[1] = new Keyframe(1724f, 882f, 1031f, 1087f);
				array[0] = new Keyframe(1983f, 522f, 1273f, 1314f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 836f, false, new Vector2(452f, 1620f));
				Keyframe[] array2 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(897f, 1694f, 1090f, 1681f)
				};
				array2[0] = new Keyframe(618f, 903f, 17f, 456f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1920f, true, new Vector2(1292f, 1749f));
				Keyframe[] array3 = new Keyframe[7];
				array3[1] = new Keyframe(1920f, 1980f, 805f, 1732f);
				array3[0] = new Keyframe(1019f, 1972f, 1844f, 185f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 1208f, true, new Vector2(335f, 1465f));
				result.blue = new ColorGradingCurve(new AnimationCurve(new Keyframe[]
				{
					new Keyframe(99f, 1245f, 526f, 392f),
					new Keyframe(1354f, 457f, 1091f, 110f)
				}), 1085f, false, new Vector2(865f, 575f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1166f, false, new Vector2(691f, 773f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1665f, true, new Vector2(915f, 825f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1647f, true, new Vector2(1683f, 504f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 924f, true, new Vector2(904f, 473f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = false;
				result.e_CurveR = true;
				result.e_CurveG = true;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x06011EB5 RID: 73397 RVA: 0x007F60B4 File Offset: 0x007F42B4
			public static ColorGradingModel.CurvesSettings JPGMEJNEOCC()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[7];
				array[0] = new Keyframe(1865f, 1980f, 1092f, 1507f);
				array[1] = new Keyframe(1998f, 1979f, 550f, 14f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 1204f, false, new Vector2(1212f, 183f));
				Keyframe[] array2 = new Keyframe[8];
				array2[1] = new Keyframe(545f, 1010f, 961f, 1474f);
				array2[0] = new Keyframe(1213f, 72f, 1132f, 467f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 959f, false, new Vector2(758f, 1460f));
				Keyframe[] array3 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(258f, 1508f, 1368f, 304f)
				};
				array3[0] = new Keyframe(70f, 726f, 720f, 325f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 359f, false, new Vector2(97f, 1356f));
				Keyframe[] array4 = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1726f, 899f, 1683f, 976f)
				};
				array4[0] = new Keyframe(1014f, 381f, 1329f, 1342f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1481f, true, new Vector2(848f, 624f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 548f, true, new Vector2(1239f, 519f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 41f, false, new Vector2(946f, 977f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 1843f, true, new Vector2(1911f, 1468f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 1819f, false, new Vector2(636f, 1114f));
				result.e_CurrentEditingCurve = 0;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = false;
				return result;
			}

			// Token: 0x06011EB6 RID: 73398 RVA: 0x007F633C File Offset: 0x007F453C
			public static ColorGradingModel.CurvesSettings NKCDNAMEFOA()
			{
				ColorGradingModel.CurvesSettings result = default(ColorGradingModel.CurvesSettings);
				Keyframe[] array = new Keyframe[1];
				array[1] = new Keyframe(962f, 1633f, 1232f, 1212f);
				array[0] = new Keyframe(353f, 728f, 1871f, 1041f);
				result.master = new ColorGradingCurve(new AnimationCurve(array), 834f, true, new Vector2(1236f, 1542f));
				Keyframe[] array2 = new Keyframe[6];
				array2[1] = new Keyframe(696f, 118f, 1524f, 956f);
				array2[0] = new Keyframe(1365f, 1117f, 1568f, 1270f);
				result.red = new ColorGradingCurve(new AnimationCurve(array2), 1340f, true, new Vector2(1947f, 62f));
				Keyframe[] array3 = new Keyframe[3];
				array3[0] = new Keyframe(160f, 180f, 268f, 468f);
				array3[1] = new Keyframe(596f, 696f, 1197f, 1483f);
				result.green = new ColorGradingCurve(new AnimationCurve(array3), 650f, false, new Vector2(1499f, 170f));
				Keyframe[] array4 = new Keyframe[3];
				array4[1] = new Keyframe(1164f, 1785f, 1925f, 868f);
				array4[1] = new Keyframe(1659f, 1719f, 1280f, 1554f);
				result.blue = new ColorGradingCurve(new AnimationCurve(array4), 1710f, true, new Vector2(65f, 1962f));
				result.hueVShue = new ColorGradingCurve(new AnimationCurve(), 1871f, true, new Vector2(406f, 666f));
				result.hueVSsat = new ColorGradingCurve(new AnimationCurve(), 1067f, true, new Vector2(673f, 1089f));
				result.satVSsat = new ColorGradingCurve(new AnimationCurve(), 968f, true, new Vector2(1473f, 1198f));
				result.lumVSsat = new ColorGradingCurve(new AnimationCurve(), 0f, false, new Vector2(40f, 306f));
				result.e_CurrentEditingCurve = 1;
				result.e_CurveY = true;
				result.e_CurveR = false;
				result.e_CurveG = false;
				result.e_CurveB = true;
				return result;
			}

			// Token: 0x04002544 RID: 9540
			public ColorGradingCurve master;

			// Token: 0x04002545 RID: 9541
			public ColorGradingCurve red;

			// Token: 0x04002546 RID: 9542
			public ColorGradingCurve green;

			// Token: 0x04002547 RID: 9543
			public ColorGradingCurve blue;

			// Token: 0x04002548 RID: 9544
			public ColorGradingCurve hueVShue;

			// Token: 0x04002549 RID: 9545
			public ColorGradingCurve hueVSsat;

			// Token: 0x0400254A RID: 9546
			public ColorGradingCurve satVSsat;

			// Token: 0x0400254B RID: 9547
			public ColorGradingCurve lumVSsat;

			// Token: 0x0400254C RID: 9548
			[HideInInspector]
			public int e_CurrentEditingCurve;

			// Token: 0x0400254D RID: 9549
			[HideInInspector]
			public bool e_CurveY;

			// Token: 0x0400254E RID: 9550
			[HideInInspector]
			public bool e_CurveR;

			// Token: 0x0400254F RID: 9551
			[HideInInspector]
			public bool e_CurveG;

			// Token: 0x04002550 RID: 9552
			[HideInInspector]
			public bool e_CurveB;
		}

		// Token: 0x02000553 RID: 1363
		[Serializable]
		public struct Settings
		{
			// Token: 0x06011EB7 RID: 73399 RVA: 0x007F65C4 File Offset: 0x007F47C4
			public static ColorGradingModel.Settings OOFOKHIDMDG()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.DELLGIGMFLC(),
					basic = ColorGradingModel.BasicSettings.NJJBBDIFPKH(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.MJLLLKFIDOE(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.ILFHFFCIBPJ(),
					curves = ColorGradingModel.CurvesSettings.HIPJDBACJDH()
				};
			}

			// Token: 0x06011EB8 RID: 73400 RVA: 0x007F6618 File Offset: 0x007F4818
			public static ColorGradingModel.Settings ADJNPGFJGJI()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.MDDFLLOCDEA(),
					basic = ColorGradingModel.BasicSettings.HLLBKJENCLA(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.NJJBBDIFPKH(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.NPEIGPHIHFP(),
					curves = ColorGradingModel.CurvesSettings.GDKPNHJPBKJ()
				};
			}

			// Token: 0x06011EB9 RID: 73401 RVA: 0x007F666C File Offset: 0x007F486C
			public static ColorGradingModel.Settings CGGMKBADCBM()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.COJPKDJKJAM(),
					basic = ColorGradingModel.BasicSettings.defaultSettings,
					channelMixer = ColorGradingModel.ChannelMixerSettings.MDGIIBPIGJC(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.BNGFNAFFAME(),
					curves = ColorGradingModel.CurvesSettings.DELLGIGMFLC()
				};
			}

			// Token: 0x06011EBA RID: 73402 RVA: 0x007F66C0 File Offset: 0x007F48C0
			public static ColorGradingModel.Settings NNNMNENCOBC()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.MDGIIBPIGJC(),
					basic = ColorGradingModel.BasicSettings.JPGMEJNEOCC(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.CGGMKBADCBM(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.GDKPNHJPBKJ(),
					curves = ColorGradingModel.CurvesSettings.NNNMNENCOBC()
				};
			}

			// Token: 0x06011EBB RID: 73403 RVA: 0x007F6714 File Offset: 0x007F4914
			public static ColorGradingModel.Settings MJLLLKFIDOE()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.AAPKKAPOLKH(),
					basic = ColorGradingModel.BasicSettings.HMDLEIJHKEP(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.COINKHKLJAP(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.MDDFLLOCDEA(),
					curves = ColorGradingModel.CurvesSettings.NMGNPHGAGGA()
				};
			}

			// Token: 0x06011EBC RID: 73404 RVA: 0x007F6768 File Offset: 0x007F4968
			public static ColorGradingModel.Settings FMLMIDJIEOP()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.MJLLLKFIDOE(),
					basic = ColorGradingModel.BasicSettings.JPGMEJNEOCC(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.FBBLPICJODA(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.BFFANDBCLFI(),
					curves = ColorGradingModel.CurvesSettings.MDDBLMDKDAO()
				};
			}

			// Token: 0x06011EBD RID: 73405 RVA: 0x007F67BC File Offset: 0x007F49BC
			public static ColorGradingModel.Settings DELLGIGMFLC()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.defaultSettings,
					basic = ColorGradingModel.BasicSettings.OCIMBHLOOGC(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.FBBLPICJODA(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.FMLMIDJIEOP(),
					curves = ColorGradingModel.CurvesSettings.FLPFAGHMGNN()
				};
			}

			// Token: 0x06011EBE RID: 73406 RVA: 0x007F6810 File Offset: 0x007F4A10
			public static ColorGradingModel.Settings OCIMBHLOOGC()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.JPGMEJNEOCC(),
					basic = ColorGradingModel.BasicSettings.OCIMBHLOOGC(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.MKEJGGFNILJ(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.CGGMKBADCBM(),
					curves = ColorGradingModel.CurvesSettings.BJNIBDPAHBP()
				};
			}

			// Token: 0x06011EBF RID: 73407 RVA: 0x007F6864 File Offset: 0x007F4A64
			public static ColorGradingModel.Settings AAPKKAPOLKH()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.DELLGIGMFLC(),
					basic = ColorGradingModel.BasicSettings.defaultSettings,
					channelMixer = ColorGradingModel.ChannelMixerSettings.FBBLPICJODA(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.MEFEDCEEAMK(),
					curves = ColorGradingModel.CurvesSettings.JGNKGPFJFHO()
				};
			}

			// Token: 0x06011EC0 RID: 73408 RVA: 0x007F68B8 File Offset: 0x007F4AB8
			public static ColorGradingModel.Settings GDKPNHJPBKJ()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.LNGBMOGJKGD(),
					basic = ColorGradingModel.BasicSettings.HLLBKJENCLA(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.NJJBBDIFPKH(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.MEFEDCEEAMK(),
					curves = ColorGradingModel.CurvesSettings.MJLLLKFIDOE()
				};
			}

			// Token: 0x06011EC1 RID: 73409 RVA: 0x007F690C File Offset: 0x007F4B0C
			public static ColorGradingModel.Settings IGIKNGLDPJB()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.FBBLPICJODA(),
					basic = ColorGradingModel.BasicSettings.JPGMEJNEOCC(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.MJLLLKFIDOE(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.CGGMKBADCBM(),
					curves = ColorGradingModel.CurvesSettings.DHCNIDFOOPO()
				};
			}

			// Token: 0x06011EC2 RID: 73410 RVA: 0x007F6960 File Offset: 0x007F4B60
			public static ColorGradingModel.Settings HMDLEIJHKEP()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.FMLMIDJIEOP(),
					basic = ColorGradingModel.BasicSettings.OCIMBHLOOGC(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.COINKHKLJAP(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.ADJNPGFJGJI(),
					curves = ColorGradingModel.CurvesSettings.NMGNPHGAGGA()
				};
			}

			// Token: 0x06011EC3 RID: 73411 RVA: 0x007F69B4 File Offset: 0x007F4BB4
			public static ColorGradingModel.Settings MDDFLLOCDEA()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.NLCHLENDMLI(),
					basic = ColorGradingModel.BasicSettings.GDKPNHJPBKJ(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.defaultSettings,
					colorWheels = ColorGradingModel.ColorWheelsSettings.defaultSettings,
					curves = ColorGradingModel.CurvesSettings.BNGFNAFFAME()
				};
			}

			// Token: 0x06011EC4 RID: 73412 RVA: 0x007F6A08 File Offset: 0x007F4C08
			public static ColorGradingModel.Settings NLCHLENDMLI()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.BNGFNAFFAME(),
					basic = ColorGradingModel.BasicSettings.GDKPNHJPBKJ(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.IGIKNGLDPJB(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.NLCHLENDMLI(),
					curves = ColorGradingModel.CurvesSettings.JJMHFAELDJK()
				};
			}

			// Token: 0x06011EC5 RID: 73413 RVA: 0x007F6A5C File Offset: 0x007F4C5C
			public static ColorGradingModel.Settings PIAJOHPDMNA()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.HLLBKJENCLA(),
					basic = ColorGradingModel.BasicSettings.COINKHKLJAP(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.GDKPNHJPBKJ(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.CGGMKBADCBM(),
					curves = ColorGradingModel.CurvesSettings.OOFOKHIDMDG()
				};
			}

			// Token: 0x06011EC6 RID: 73414 RVA: 0x007F6AB0 File Offset: 0x007F4CB0
			public static ColorGradingModel.Settings HLLBKJENCLA()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.DELLGIGMFLC(),
					basic = ColorGradingModel.BasicSettings.NLCHLENDMLI(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.MEFEDCEEAMK(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.BJNIBDPAHBP(),
					curves = ColorGradingModel.CurvesSettings.DBGPLELNOMP()
				};
			}

			// Token: 0x06011EC7 RID: 73415 RVA: 0x007F6B04 File Offset: 0x007F4D04
			public static ColorGradingModel.Settings LNGBMOGJKGD()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.ILFHFFCIBPJ(),
					basic = ColorGradingModel.BasicSettings.NNNMNENCOBC(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.FBBLPICJODA(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.BNGFNAFFAME(),
					curves = ColorGradingModel.CurvesSettings.NMGNPHGAGGA()
				};
			}

			// Token: 0x06011EC8 RID: 73416 RVA: 0x007F6B58 File Offset: 0x007F4D58
			public static ColorGradingModel.Settings JPGMEJNEOCC()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.JPGMEJNEOCC(),
					basic = ColorGradingModel.BasicSettings.PIAJOHPDMNA(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.IGIKNGLDPJB(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.NLCHLENDMLI(),
					curves = ColorGradingModel.CurvesSettings.MDDFLLOCDEA()
				};
			}

			// Token: 0x06011EC9 RID: 73417 RVA: 0x007F6BAC File Offset: 0x007F4DAC
			public static ColorGradingModel.Settings MEFEDCEEAMK()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.AAPKKAPOLKH(),
					basic = ColorGradingModel.BasicSettings.JPGMEJNEOCC(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.defaultSettings,
					colorWheels = ColorGradingModel.ColorWheelsSettings.BNGFNAFFAME(),
					curves = ColorGradingModel.CurvesSettings.OOKKEMFPNBJ()
				};
			}

			// Token: 0x06011ECA RID: 73418 RVA: 0x007F6C00 File Offset: 0x007F4E00
			public static ColorGradingModel.Settings FBBLPICJODA()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.MDGIIBPIGJC(),
					basic = ColorGradingModel.BasicSettings.NLCHLENDMLI(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.IGIKNGLDPJB(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.BNGFNAFFAME(),
					curves = ColorGradingModel.CurvesSettings.JIIODGEMCMH()
				};
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x06011ECB RID: 73419 RVA: 0x007F6C54 File Offset: 0x007F4E54
			public static ColorGradingModel.Settings defaultSettings
			{
				get
				{
					return new ColorGradingModel.Settings
					{
						tonemapping = ColorGradingModel.TonemappingSettings.defaultSettings,
						basic = ColorGradingModel.BasicSettings.defaultSettings,
						channelMixer = ColorGradingModel.ChannelMixerSettings.defaultSettings,
						colorWheels = ColorGradingModel.ColorWheelsSettings.defaultSettings,
						curves = ColorGradingModel.CurvesSettings.defaultSettings
					};
				}
			}

			// Token: 0x06011ECC RID: 73420 RVA: 0x007F6CA8 File Offset: 0x007F4EA8
			public static ColorGradingModel.Settings MKEJGGFNILJ()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.IGIKNGLDPJB(),
					basic = ColorGradingModel.BasicSettings.OOKKEMFPNBJ(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.MKEJGGFNILJ(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.ADJNPGFJGJI(),
					curves = ColorGradingModel.CurvesSettings.COJPKDJKJAM()
				};
			}

			// Token: 0x06011ECD RID: 73421 RVA: 0x007F6CFC File Offset: 0x007F4EFC
			public static ColorGradingModel.Settings OOKKEMFPNBJ()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.MKEJGGFNILJ(),
					basic = ColorGradingModel.BasicSettings.IGIKNGLDPJB(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.MJLLLKFIDOE(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.MJLLLKFIDOE(),
					curves = ColorGradingModel.CurvesSettings.KGGHGENABDN()
				};
			}

			// Token: 0x06011ECE RID: 73422 RVA: 0x007F6D50 File Offset: 0x007F4F50
			public static ColorGradingModel.Settings MDGIIBPIGJC()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.MGIIIBAJNIE(),
					basic = ColorGradingModel.BasicSettings.HLLBKJENCLA(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.NJJBBDIFPKH(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.PIAJOHPDMNA(),
					curves = ColorGradingModel.CurvesSettings.DBGPLELNOMP()
				};
			}

			// Token: 0x06011ECF RID: 73423 RVA: 0x007F6DA4 File Offset: 0x007F4FA4
			public static ColorGradingModel.Settings MGIIIBAJNIE()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.NPEIGPHIHFP(),
					basic = ColorGradingModel.BasicSettings.CGGMKBADCBM(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.HLLBKJENCLA(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.MEFEDCEEAMK(),
					curves = ColorGradingModel.CurvesSettings.HMDLEIJHKEP()
				};
			}

			// Token: 0x06011ED0 RID: 73424 RVA: 0x007F6DF8 File Offset: 0x007F4FF8
			public static ColorGradingModel.Settings MDDBLMDKDAO()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.CGGMKBADCBM(),
					basic = ColorGradingModel.BasicSettings.JPGMEJNEOCC(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.CGGMKBADCBM(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.HLLBKJENCLA(),
					curves = ColorGradingModel.CurvesSettings.DICKGIEMDON()
				};
			}

			// Token: 0x06011ED1 RID: 73425 RVA: 0x007F6E4C File Offset: 0x007F504C
			public static ColorGradingModel.Settings DHCNIDFOOPO()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.DHCNIDFOOPO(),
					basic = ColorGradingModel.BasicSettings.OCIMBHLOOGC(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.NLCHLENDMLI(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.OOKKEMFPNBJ(),
					curves = ColorGradingModel.CurvesSettings.OCIMBHLOOGC()
				};
			}

			// Token: 0x06011ED2 RID: 73426 RVA: 0x007F6EA0 File Offset: 0x007F50A0
			public static ColorGradingModel.Settings NJJBBDIFPKH()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.LNGBMOGJKGD(),
					basic = ColorGradingModel.BasicSettings.NLCHLENDMLI(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.CGGMKBADCBM(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.PIAJOHPDMNA(),
					curves = ColorGradingModel.CurvesSettings.OAMPGBKMKFF()
				};
			}

			// Token: 0x06011ED3 RID: 73427 RVA: 0x007F6EF4 File Offset: 0x007F50F4
			public static ColorGradingModel.Settings COINKHKLJAP()
			{
				return new ColorGradingModel.Settings
				{
					tonemapping = ColorGradingModel.TonemappingSettings.NPEIGPHIHFP(),
					basic = ColorGradingModel.BasicSettings.HMDLEIJHKEP(),
					channelMixer = ColorGradingModel.ChannelMixerSettings.HMDLEIJHKEP(),
					colorWheels = ColorGradingModel.ColorWheelsSettings.NPEIGPHIHFP(),
					curves = ColorGradingModel.CurvesSettings.HMKDCFKBINK()
				};
			}

			// Token: 0x04002551 RID: 9553
			public ColorGradingModel.TonemappingSettings tonemapping;

			// Token: 0x04002552 RID: 9554
			public ColorGradingModel.BasicSettings basic;

			// Token: 0x04002553 RID: 9555
			public ColorGradingModel.ChannelMixerSettings channelMixer;

			// Token: 0x04002554 RID: 9556
			public ColorGradingModel.ColorWheelsSettings colorWheels;

			// Token: 0x04002555 RID: 9557
			public ColorGradingModel.CurvesSettings curves;
		}
	}
}
