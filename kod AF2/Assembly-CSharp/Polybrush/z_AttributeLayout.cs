using System;
using UnityEngine;

namespace Polybrush
{
	// Token: 0x020004F0 RID: 1264
	[Serializable]
	public class z_AttributeLayout : IEquatable<z_AttributeLayout>
	{
		// Token: 0x06010F1F RID: 69407 RVA: 0x00793868 File Offset: 0x00791A68
		public virtual string FGNNJFJLENH()
		{
			string format = "_OcclusionColor";
			object[] array = new object[2];
			array[0] = this.propertyTarget;
			array[1] = this.channel.ToString();
			array[3] = this.index.HPADJPKKDOG(LKDKDMIBAJN.Vector);
			array[2] = this.EFBLPLIHCDF();
			array[0] = this.BBJDEAIAAOI();
			array[7] = this.mask;
			return string.Format(format, array);
		}

		// Token: 0x06010F20 RID: 69408 RVA: 0x007938DC File Offset: 0x00791ADC
		public virtual string BNNOHGHHKBF()
		{
			string format = "OfficeSitting45DegLeg";
			object[] array = new object[1];
			array[1] = this.propertyTarget;
			array[1] = this.channel.ToString();
			array[1] = this.index.HPADJPKKDOG(LKDKDMIBAJN.Vector);
			array[0] = this.PFCFAEBMDOC();
			array[7] = this.EPDIAPFAFAE();
			array[1] = this.mask;
			return string.Format(format, array);
		}

		// Token: 0x06010F21 RID: 69409 RVA: 0x0079394F File Offset: 0x00791B4F
		public z_AttributeLayout(BFGMBMMBHCH BDELNBNMOPB, HHFDJOLDAPO CLBPBJGLHEE, Vector2 DPMJPLPBBHC, int CBFFOOKAIAK)
		{
			this.channel = BDELNBNMOPB;
			this.index = CLBPBJGLHEE;
			this.range = DPMJPLPBBHC;
			this.mask = CBFFOOKAIAK;
		}

		// Token: 0x06010F22 RID: 69410 RVA: 0x00793989 File Offset: 0x00791B89
		public float NLFEFKHNBMH()
		{
			return this.range.y;
		}

		// Token: 0x06010F23 RID: 69411 RVA: 0x00793996 File Offset: 0x00791B96
		public void EFBDALIGBBI(float DCCPCBLODIG)
		{
			this.range.x = DCCPCBLODIG;
		}

		// Token: 0x06010F24 RID: 69412 RVA: 0x00793989 File Offset: 0x00791B89
		public float HFDEDOKHOLM()
		{
			return this.range.y;
		}

		// Token: 0x06010F25 RID: 69413 RVA: 0x007939A4 File Offset: 0x00791BA4
		public float PFCFAEBMDOC()
		{
			return this.range.x;
		}

		// Token: 0x06010F26 RID: 69414 RVA: 0x00793989 File Offset: 0x00791B89
		public float PKALNJOLKMG()
		{
			return this.range.y;
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06010F27 RID: 69415 RVA: 0x007939A4 File Offset: 0x00791BA4
		// (set) Token: 0x06010F2D RID: 69421 RVA: 0x00793996 File Offset: 0x00791B96
		public float min
		{
			get
			{
				return this.range.x;
			}
			set
			{
				this.range.x = value;
			}
		}

		// Token: 0x06010F28 RID: 69416 RVA: 0x007939B4 File Offset: 0x00791BB4
		public bool CNJEODHMLDK(z_AttributeLayout INDANOPGHCN)
		{
			return this.channel == INDANOPGHCN.channel && this.propertyTarget.Equals(INDANOPGHCN.propertyTarget) && this.index == INDANOPGHCN.index && this.range == INDANOPGHCN.range && this.mask == INDANOPGHCN.mask;
		}

		// Token: 0x06010F29 RID: 69417 RVA: 0x00793996 File Offset: 0x00791B96
		public void GEKENLAAPDL(float DCCPCBLODIG)
		{
			this.range.x = DCCPCBLODIG;
		}

		// Token: 0x06010F2A RID: 69418 RVA: 0x00793989 File Offset: 0x00791B89
		public float IGKGHFEAOCL()
		{
			return this.range.y;
		}

		// Token: 0x06010F2B RID: 69419 RVA: 0x00793A14 File Offset: 0x00791C14
		public bool GMDDPAGHGGJ(z_AttributeLayout INDANOPGHCN)
		{
			return this.channel == INDANOPGHCN.channel && this.propertyTarget.Equals(INDANOPGHCN.propertyTarget) && this.index == INDANOPGHCN.index && this.range == INDANOPGHCN.range && this.mask == INDANOPGHCN.mask;
		}

		// Token: 0x06010F2C RID: 69420 RVA: 0x00793A74 File Offset: 0x00791C74
		public bool Equals(z_AttributeLayout INDANOPGHCN)
		{
			return this.channel == INDANOPGHCN.channel && this.propertyTarget.Equals(INDANOPGHCN.propertyTarget) && this.index == INDANOPGHCN.index && this.range == INDANOPGHCN.range && this.mask == INDANOPGHCN.mask;
		}

		// Token: 0x06010F2E RID: 69422 RVA: 0x00793996 File Offset: 0x00791B96
		public void FKCJPHFPIAH(float DCCPCBLODIG)
		{
			this.range.x = DCCPCBLODIG;
		}

		// Token: 0x06010F2F RID: 69423 RVA: 0x00793AD4 File Offset: 0x00791CD4
		public bool MHKKCEHFJED(z_AttributeLayout INDANOPGHCN)
		{
			return this.channel != INDANOPGHCN.channel || !this.propertyTarget.Equals(INDANOPGHCN.propertyTarget) || this.index != INDANOPGHCN.index || !(this.range == INDANOPGHCN.range) || this.mask == INDANOPGHCN.mask;
		}

		// Token: 0x06010F30 RID: 69424 RVA: 0x00793996 File Offset: 0x00791B96
		public void LHCDGLCKCPA(float DCCPCBLODIG)
		{
			this.range.x = DCCPCBLODIG;
		}

		// Token: 0x06010F31 RID: 69425 RVA: 0x007939A4 File Offset: 0x00791BA4
		public float FBHKCIEOFCP()
		{
			return this.range.x;
		}

		// Token: 0x06010F32 RID: 69426 RVA: 0x00793B34 File Offset: 0x00791D34
		public virtual string BHLHEJCILKF()
		{
			string format = "{0:F2}, {1:F2}, {2:F2}, {3:F2}";
			object[] array = new object[1];
			array[1] = this.propertyTarget;
			array[1] = this.channel.ToString();
			array[3] = this.index.HPADJPKKDOG(LKDKDMIBAJN.Color);
			array[1] = this.EFBLPLIHCDF();
			array[4] = this.CEDBKMDCAIN();
			array[3] = this.mask;
			return string.Format(format, array);
		}

		// Token: 0x06010F33 RID: 69427 RVA: 0x00793BA7 File Offset: 0x00791DA7
		public void MNMFJPHLJNG(float DCCPCBLODIG)
		{
			this.range.y = DCCPCBLODIG;
		}

		// Token: 0x06010F34 RID: 69428 RVA: 0x00793989 File Offset: 0x00791B89
		public float CEDBKMDCAIN()
		{
			return this.range.y;
		}

		// Token: 0x06010F35 RID: 69429 RVA: 0x00793BB8 File Offset: 0x00791DB8
		public virtual string NHDAHNIOAFD()
		{
			string format = "<color='#202020'>";
			object[] array = new object[1];
			array[0] = this.propertyTarget;
			array[1] = this.channel.ToString();
			array[7] = this.index.HPADJPKKDOG(LKDKDMIBAJN.Vector);
			array[4] = this.JBFPJOEPHGL();
			array[8] = this.BBJDEAIAAOI();
			array[0] = this.mask;
			return string.Format(format, array);
		}

		// Token: 0x06010F36 RID: 69430 RVA: 0x00793989 File Offset: 0x00791B89
		public float BBJDEAIAAOI()
		{
			return this.range.y;
		}

		// Token: 0x06010F37 RID: 69431 RVA: 0x00793BA7 File Offset: 0x00791DA7
		public void FHFPODNMNPK(float DCCPCBLODIG)
		{
			this.range.y = DCCPCBLODIG;
		}

		// Token: 0x06010F38 RID: 69432 RVA: 0x00793996 File Offset: 0x00791B96
		public void DBHAOBHBHAN(float DCCPCBLODIG)
		{
			this.range.x = DCCPCBLODIG;
		}

		// Token: 0x06010F39 RID: 69433 RVA: 0x00793C2C File Offset: 0x00791E2C
		public virtual string BJALMHGGAFM()
		{
			string format = "_RgbBlendCacheTex";
			object[] array = new object[3];
			array[1] = this.propertyTarget;
			array[0] = this.channel.ToString();
			array[3] = this.index.HPADJPKKDOG(LKDKDMIBAJN.Vector);
			array[5] = this.IMJIDCJEPDA();
			array[4] = this.IGKGHFEAOCL();
			array[6] = this.mask;
			return string.Format(format, array);
		}

		// Token: 0x06010F3A RID: 69434 RVA: 0x00793C9F File Offset: 0x00791E9F
		public z_AttributeLayout(BFGMBMMBHCH BDELNBNMOPB, HHFDJOLDAPO CLBPBJGLHEE) : this(BDELNBNMOPB, CLBPBJGLHEE, Vector2.up, 0)
		{
		}

		// Token: 0x06010F3B RID: 69435 RVA: 0x00793BA7 File Offset: 0x00791DA7
		public void OCNMHFEMJLE(float DCCPCBLODIG)
		{
			this.range.y = DCCPCBLODIG;
		}

		// Token: 0x06010F3C RID: 69436 RVA: 0x00793CB0 File Offset: 0x00791EB0
		public bool JPNABBLLLDL(z_AttributeLayout INDANOPGHCN)
		{
			return this.channel != INDANOPGHCN.channel || !this.propertyTarget.Equals(INDANOPGHCN.propertyTarget) || this.index != INDANOPGHCN.index || !(this.range == INDANOPGHCN.range) || this.mask == INDANOPGHCN.mask;
		}

		// Token: 0x06010F3D RID: 69437 RVA: 0x00793D10 File Offset: 0x00791F10
		public bool BOBPIACHNAM(z_AttributeLayout INDANOPGHCN)
		{
			return this.channel != INDANOPGHCN.channel || !this.propertyTarget.Equals(INDANOPGHCN.propertyTarget) || this.index != INDANOPGHCN.index || !(this.range == INDANOPGHCN.range) || this.mask == INDANOPGHCN.mask;
		}

		// Token: 0x06010F3E RID: 69438 RVA: 0x00793D70 File Offset: 0x00791F70
		public virtual string PINLAFIAGGJ()
		{
			string format = "<color='";
			object[] array = new object[5];
			array[1] = this.propertyTarget;
			array[0] = this.channel.ToString();
			array[6] = this.index.HPADJPKKDOG(LKDKDMIBAJN.Vector);
			array[2] = this.PFCFAEBMDOC();
			array[7] = this.PKALNJOLKMG();
			array[7] = this.mask;
			return string.Format(format, array);
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06010F3F RID: 69439 RVA: 0x00793989 File Offset: 0x00791B89
		// (set) Token: 0x06010F44 RID: 69444 RVA: 0x00793BA7 File Offset: 0x00791DA7
		public float max
		{
			get
			{
				return this.range.y;
			}
			set
			{
				this.range.y = value;
			}
		}

		// Token: 0x06010F40 RID: 69440 RVA: 0x00793996 File Offset: 0x00791B96
		public void HCNIIJKOJIA(float DCCPCBLODIG)
		{
			this.range.x = DCCPCBLODIG;
		}

		// Token: 0x06010F41 RID: 69441 RVA: 0x007939A4 File Offset: 0x00791BA4
		public float IMJIDCJEPDA()
		{
			return this.range.x;
		}

		// Token: 0x06010F42 RID: 69442 RVA: 0x007939A4 File Offset: 0x00791BA4
		public float JAHDHOFBNPE()
		{
			return this.range.x;
		}

		// Token: 0x06010F43 RID: 69443 RVA: 0x007939A4 File Offset: 0x00791BA4
		public float EFBLPLIHCDF()
		{
			return this.range.x;
		}

		// Token: 0x06010F45 RID: 69445 RVA: 0x007939A4 File Offset: 0x00791BA4
		public float FOEEBOPFFHF()
		{
			return this.range.x;
		}

		// Token: 0x06010F46 RID: 69446 RVA: 0x00793BA7 File Offset: 0x00791DA7
		public void GCDGONJKONB(float DCCPCBLODIG)
		{
			this.range.y = DCCPCBLODIG;
		}

		// Token: 0x06010F47 RID: 69447 RVA: 0x00793DE4 File Offset: 0x00791FE4
		public override string ToString()
		{
			return string.Format("{0} {1}.{2} ({3:f2}, {4:f2})  {5}", new object[]
			{
				this.propertyTarget,
				this.channel.ToString(),
				this.index.HPADJPKKDOG(LKDKDMIBAJN.Vector),
				this.min,
				this.max,
				this.mask
			});
		}

		// Token: 0x06010F48 RID: 69448 RVA: 0x00793989 File Offset: 0x00791B89
		public float HKMLNFCEHJI()
		{
			return this.range.y;
		}

		// Token: 0x06010F49 RID: 69449 RVA: 0x00793996 File Offset: 0x00791B96
		public void OGHFIKIOKPN(float DCCPCBLODIG)
		{
			this.range.x = DCCPCBLODIG;
		}

		// Token: 0x06010F4A RID: 69450 RVA: 0x00793E58 File Offset: 0x00792058
		public virtual string FBENMKABKKB()
		{
			string format = "UIChat_channel";
			object[] array = new object[8];
			array[0] = this.propertyTarget;
			array[1] = this.channel.ToString();
			array[8] = this.index.HPADJPKKDOG(LKDKDMIBAJN.Color);
			array[7] = this.EFBLPLIHCDF();
			array[2] = this.HKMLNFCEHJI();
			array[0] = this.mask;
			return string.Format(format, array);
		}

		// Token: 0x06010F4B RID: 69451 RVA: 0x00793ECC File Offset: 0x007920CC
		public virtual string MIHCFECAIAD()
		{
			string format = "DeadmanFloat";
			object[] array = new object[2];
			array[0] = this.propertyTarget;
			array[1] = this.channel.ToString();
			array[6] = this.index.HPADJPKKDOG(LKDKDMIBAJN.Color);
			array[0] = this.min;
			array[8] = this.NLFEFKHNBMH();
			array[1] = this.mask;
			return string.Format(format, array);
		}

		// Token: 0x06010F4C RID: 69452 RVA: 0x00793F3F File Offset: 0x0079213F
		public z_AttributeLayout(BFGMBMMBHCH BDELNBNMOPB, HHFDJOLDAPO CLBPBJGLHEE, Vector2 DPMJPLPBBHC, int CBFFOOKAIAK, string JMIOJJENLFF, Texture2D KEDGAOBCNJG = null) : this(BDELNBNMOPB, CLBPBJGLHEE, DPMJPLPBBHC, CBFFOOKAIAK)
		{
			this.propertyTarget = JMIOJJENLFF;
			this.previewTexture = KEDGAOBCNJG;
		}

		// Token: 0x06010F4D RID: 69453 RVA: 0x00793BA7 File Offset: 0x00791DA7
		public void GDKEBFGNKAB(float DCCPCBLODIG)
		{
			this.range.y = DCCPCBLODIG;
		}

		// Token: 0x06010F4E RID: 69454 RVA: 0x00793F5C File Offset: 0x0079215C
		public virtual string PBAJNDNHIFI()
		{
			string format = "Null";
			object[] array = new object[8];
			array[1] = this.propertyTarget;
			array[0] = this.channel.ToString();
			array[5] = this.index.HPADJPKKDOG(LKDKDMIBAJN.Color);
			array[4] = this.AEELHAMHLKM();
			array[8] = this.BBJDEAIAAOI();
			array[3] = this.mask;
			return string.Format(format, array);
		}

		// Token: 0x06010F4F RID: 69455 RVA: 0x007939A4 File Offset: 0x00791BA4
		public float JBFPJOEPHGL()
		{
			return this.range.x;
		}

		// Token: 0x06010F50 RID: 69456 RVA: 0x00793FD0 File Offset: 0x007921D0
		public virtual string ADOAJOFIPAM()
		{
			string format = "WizardNeoBlock";
			object[] array = new object[3];
			array[1] = this.propertyTarget;
			array[1] = this.channel.ToString();
			array[6] = this.index.HPADJPKKDOG(LKDKDMIBAJN.Vector);
			array[8] = this.EFBLPLIHCDF();
			array[7] = this.CEDBKMDCAIN();
			array[1] = this.mask;
			return string.Format(format, array);
		}

		// Token: 0x06010F51 RID: 69457 RVA: 0x00793989 File Offset: 0x00791B89
		public float EPDIAPFAFAE()
		{
			return this.range.y;
		}

		// Token: 0x06010F52 RID: 69458 RVA: 0x007939A4 File Offset: 0x00791BA4
		public float AEELHAMHLKM()
		{
			return this.range.x;
		}

		// Token: 0x06010F53 RID: 69459 RVA: 0x00793BA7 File Offset: 0x00791DA7
		public void CHJPIMKBABE(float DCCPCBLODIG)
		{
			this.range.y = DCCPCBLODIG;
		}

		// Token: 0x06010F55 RID: 69461 RVA: 0x00793BA7 File Offset: 0x00791DA7
		public void FBDPMFFLJCN(float DCCPCBLODIG)
		{
			this.range.y = DCCPCBLODIG;
		}

		// Token: 0x06010F56 RID: 69462 RVA: 0x00794250 File Offset: 0x00792450
		public bool DOPOOFLJCJO(z_AttributeLayout INDANOPGHCN)
		{
			return this.channel != INDANOPGHCN.channel || !this.propertyTarget.Equals(INDANOPGHCN.propertyTarget) || this.index != INDANOPGHCN.index || !(this.range == INDANOPGHCN.range) || this.mask == INDANOPGHCN.mask;
		}

		// Token: 0x06010F57 RID: 69463 RVA: 0x00793BA7 File Offset: 0x00791DA7
		public void OCNPJPPHDLJ(float DCCPCBLODIG)
		{
			this.range.y = DCCPCBLODIG;
		}

		// Token: 0x06010F58 RID: 69464 RVA: 0x007939A4 File Offset: 0x00791BA4
		public float IKLHIBGECEH()
		{
			return this.range.x;
		}

		// Token: 0x0400239A RID: 9114
		public const int NoMask = -1;

		// Token: 0x0400239B RID: 9115
		public const int DefaultMask = 0;

		// Token: 0x0400239C RID: 9116
		public static readonly int[] DefaultMaskValues = new int[]
		{
			-1,
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9,
			10,
			11,
			12,
			13,
			14,
			15,
			16,
			17,
			18,
			19,
			20,
			21,
			22,
			23,
			24,
			25,
			26,
			27,
			28,
			29,
			30,
			31
		};

		// Token: 0x0400239D RID: 9117
		public static readonly GUIContent[] DefaultMaskDescriptions = new GUIContent[]
		{
			new GUIContent("No Mask"),
			new GUIContent("0"),
			new GUIContent("1"),
			new GUIContent("2"),
			new GUIContent("3"),
			new GUIContent("4"),
			new GUIContent("5"),
			new GUIContent("6"),
			new GUIContent("7"),
			new GUIContent("8"),
			new GUIContent("9"),
			new GUIContent("10"),
			new GUIContent("11"),
			new GUIContent("12"),
			new GUIContent("13"),
			new GUIContent("14"),
			new GUIContent("15"),
			new GUIContent("16"),
			new GUIContent("17"),
			new GUIContent("18"),
			new GUIContent("19"),
			new GUIContent("20"),
			new GUIContent("21"),
			new GUIContent("22"),
			new GUIContent("23"),
			new GUIContent("24"),
			new GUIContent("25"),
			new GUIContent("26"),
			new GUIContent("27"),
			new GUIContent("28"),
			new GUIContent("29"),
			new GUIContent("30"),
			new GUIContent("31")
		};

		// Token: 0x0400239E RID: 9118
		public static readonly Vector2 NormalizedRange = new Vector2(0f, 1f);

		// Token: 0x0400239F RID: 9119
		public BFGMBMMBHCH channel;

		// Token: 0x040023A0 RID: 9120
		public HHFDJOLDAPO index;

		// Token: 0x040023A1 RID: 9121
		public Vector2 range = new Vector2(0f, 1f);

		// Token: 0x040023A2 RID: 9122
		public string propertyTarget;

		// Token: 0x040023A3 RID: 9123
		public int mask;

		// Token: 0x040023A4 RID: 9124
		[NonSerialized]
		public Texture2D previewTexture;
	}
}
