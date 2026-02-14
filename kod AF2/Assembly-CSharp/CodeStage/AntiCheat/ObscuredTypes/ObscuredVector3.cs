using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000594 RID: 1428
	[Serializable]
	public struct ObscuredVector3
	{
		// Token: 0x06012D01 RID: 77057 RVA: 0x0081FB1B File Offset: 0x0081DD1B
		public static void OAKAGPCJGDI(int JODDIMFACHN)
		{
			ObscuredVector3.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012D02 RID: 77058 RVA: 0x0081FB23 File Offset: 0x0081DD23
		public static ObscuredVector3 JDCMGCEFOKN(ObscuredVector3 EGABJKIFAON, float MBFGBDLOKFH)
		{
			return ObscuredVector3.BDLBFKPDOIH(EGABJKIFAON.MJFIFINDLAM() / MBFGBDLOKFH);
		}

		// Token: 0x06012D03 RID: 77059 RVA: 0x0081FB37 File Offset: 0x0081DD37
		public static ObscuredVector3 ELIGHHMMPCJ(float MBFGBDLOKFH, ObscuredVector3 EGABJKIFAON)
		{
			return ObscuredVector3.BDLBFKPDOIH(MBFGBDLOKFH * EGABJKIFAON.MJFIFINDLAM());
		}

		// Token: 0x06012D04 RID: 77060 RVA: 0x0081FB4C File Offset: 0x0081DD4C
		public float JHFMLEGPNHB()
		{
			float num = this.KLKEAJOCMBI(this.hiddenValue.y);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && Math.Abs(num - this.fakeValue.y) > ObscuredCheatingDetector.GGOEIHCJEHP().vector3Epsilon)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012D05 RID: 77061 RVA: 0x0081FBA4 File Offset: 0x0081DDA4
		public static Vector3 EKAEAJBPNBD(ObscuredVector3.RawEncryptedVector3 DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredVector3.cryptoKey;
			}
			Vector3 result;
			result.x = ObscuredFloat.GGPGJEHDJHK(DCCPCBLODIG.x, JMBKDINHDLO);
			result.y = ObscuredFloat.GGPGJEHDJHK(DCCPCBLODIG.y, JMBKDINHDLO);
			result.z = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.z, JMBKDINHDLO);
			return result;
		}

		// Token: 0x1700041E RID: 1054
		public float this[int CLBPBJGLHEE]
		{
			get
			{
				switch (CLBPBJGLHEE)
				{
				case 0:
					return this.x;
				case 1:
					return this.y;
				case 2:
					return this.z;
				default:
					throw new IndexOutOfRangeException("Invalid ObscuredVector3 index!");
				}
			}
			set
			{
				switch (CLBPBJGLHEE)
				{
				case 0:
					this.x = value;
					return;
				case 1:
					this.y = value;
					return;
				case 2:
					this.z = value;
					return;
				default:
					throw new IndexOutOfRangeException("Invalid ObscuredVector3 index!");
				}
			}
		}

		// Token: 0x06012D07 RID: 77063 RVA: 0x0081FC2A File Offset: 0x0081DE2A
		public static ObscuredVector3.RawEncryptedVector3 EKKPPKGFFCH(Vector3 DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredVector3.HAMKOCCHOBN(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, JMBKDINHDLO);
		}

		// Token: 0x06012D08 RID: 77064 RVA: 0x0081FC44 File Offset: 0x0081DE44
		public static ObscuredVector3 FEEEJDDKHMI(Vector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON - HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D09 RID: 77065 RVA: 0x0081FC58 File Offset: 0x0081DE58
		public static bool JLOEIHLIIPP(Vector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK != AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D0A RID: 77066 RVA: 0x0081FC67 File Offset: 0x0081DE67
		public static bool HLDOFLDKJNI(ObscuredVector3 HFKFJPLEAGK, Vector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK.MJFIFINDLAM() == AJFADLOIJDK;
		}

		// Token: 0x06012D0B RID: 77067 RVA: 0x0081FC78 File Offset: 0x0081DE78
		private Vector3 MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredVector3.cryptoKey;
				this.hiddenValue = ObscuredVector3.HBJHGHOKFDK(ObscuredVector3.zero, ObscuredVector3.cryptoKey);
				this.fakeValue = ObscuredVector3.zero;
				this.fakeValueActive = false;
				this.inited = true;
				return ObscuredVector3.zero;
			}
			Vector3 vector;
			vector.x = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.x, this.currentCryptoKey);
			vector.y = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.y, this.currentCryptoKey);
			vector.z = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.z, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && !this.CCJFIMABELM(vector, this.fakeValue))
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return vector;
		}

		// Token: 0x06012D0C RID: 77068 RVA: 0x0081FD4C File Offset: 0x0081DF4C
		public ObscuredVector3.RawEncryptedVector3 EHBNCDFPIJI()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012D0D RID: 77069 RVA: 0x0081FD5C File Offset: 0x0081DF5C
		private float KLKEAJOCMBI(int LDKMOLEEDIL)
		{
			int jmbkdinhdlo = ObscuredVector3.cryptoKey;
			if (this.currentCryptoKey != ObscuredVector3.cryptoKey)
			{
				jmbkdinhdlo = this.currentCryptoKey;
			}
			return ObscuredFloat.GGPGJEHDJHK(LDKMOLEEDIL, jmbkdinhdlo);
		}

		// Token: 0x06012D0E RID: 77070 RVA: 0x0081FD8C File Offset: 0x0081DF8C
		public void GNKGHCEBHBI(float DCCPCBLODIG)
		{
			this.hiddenValue.x = this.APFENCKIHBD(DCCPCBLODIG);
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				this.fakeValue.x = DCCPCBLODIG;
				this.fakeValue.y = this.KLKEAJOCMBI(this.hiddenValue.y);
				this.fakeValue.z = this.OCOLLENJFNG(this.hiddenValue.z);
				this.fakeValueActive = false;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012D0F RID: 77071 RVA: 0x0081FE08 File Offset: 0x0081E008
		public static ObscuredVector3.RawEncryptedVector3 HAMKOCCHOBN(float OCNGPCPMCPM, float ADMFAEOOOHD, float DOCOLPILEAF, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredVector3.cryptoKey;
			}
			ObscuredVector3.RawEncryptedVector3 result;
			result.x = ObscuredFloat.HBJHGHOKFDK(OCNGPCPMCPM, JMBKDINHDLO);
			result.y = ObscuredFloat.ALHMMAGENAF(ADMFAEOOOHD, JMBKDINHDLO);
			result.z = ObscuredFloat.HBJHGHOKFDK(DOCOLPILEAF, JMBKDINHDLO);
			return result;
		}

		// Token: 0x06012D10 RID: 77072 RVA: 0x0081FE4A File Offset: 0x0081E04A
		public static Vector3 GOOIABGKMHK(ObscuredVector3 DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012D11 RID: 77073 RVA: 0x0081FE53 File Offset: 0x0081E053
		public static ObscuredVector3 PPBHEODICFA(ObscuredVector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON.MJFIFINDLAM() - HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D12 RID: 77074 RVA: 0x0081FC44 File Offset: 0x0081DE44
		public static ObscuredVector3 NJDDEOHIGBJ(Vector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON - HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D13 RID: 77075 RVA: 0x0081FE6D File Offset: 0x0081E06D
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredVector3.cryptoKey)
			{
				this.hiddenValue = ObscuredVector3.HBJHGHOKFDK(this.MJFIFINDLAM(), ObscuredVector3.cryptoKey);
				this.currentCryptoKey = ObscuredVector3.cryptoKey;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06012D14 RID: 77076 RVA: 0x0081FEA0 File Offset: 0x0081E0A0
		// (set) Token: 0x06012D6E RID: 77166 RVA: 0x00820A04 File Offset: 0x0081EC04
		public float z
		{
			get
			{
				float num = this.OCOLLENJFNG(this.hiddenValue.z);
				if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && Math.Abs(num - this.fakeValue.z) > ObscuredCheatingDetector.ELOBJGIDGCP.vector3Epsilon)
				{
					ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
				}
				return num;
			}
			set
			{
				this.hiddenValue.z = this.LHKLJGDDEFF(value);
				if (ObscuredCheatingDetector.GOGDGKDDIPG)
				{
					this.fakeValue.x = this.OCOLLENJFNG(this.hiddenValue.x);
					this.fakeValue.y = this.OCOLLENJFNG(this.hiddenValue.y);
					this.fakeValue.z = value;
					this.fakeValueActive = true;
					return;
				}
				this.fakeValueActive = false;
			}
		}

		// Token: 0x06012D15 RID: 77077 RVA: 0x0081FEF7 File Offset: 0x0081E0F7
		public static bool ABGIHICDNKP(ObscuredVector3 HFKFJPLEAGK, Vector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK.MJFIFINDLAM() != AJFADLOIJDK;
		}

		// Token: 0x06012D16 RID: 77078 RVA: 0x0081FF06 File Offset: 0x0081E106
		public void ODHNGDEFHEN(int CLBPBJGLHEE, float DCCPCBLODIG)
		{
			switch (CLBPBJGLHEE)
			{
			case 0:
				this.x = DCCPCBLODIG;
				return;
			case 1:
				this.DIMMELBDJCP(DCCPCBLODIG);
				return;
			case 2:
				this.z = DCCPCBLODIG;
				return;
			default:
				throw new IndexOutOfRangeException("autherror");
			}
		}

		// Token: 0x06012D17 RID: 77079 RVA: 0x0081FF40 File Offset: 0x0081E140
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012D18 RID: 77080 RVA: 0x0081FF5C File Offset: 0x0081E15C
		private int APFENCKIHBD(float LDKMOLEEDIL)
		{
			return ObscuredFloat.ALHMMAGENAF(LDKMOLEEDIL, ObscuredVector3.cryptoKey);
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06012D19 RID: 77081 RVA: 0x0081FF6C File Offset: 0x0081E16C
		// (set) Token: 0x06012D42 RID: 77122 RVA: 0x0082052C File Offset: 0x0081E72C
		public float y
		{
			get
			{
				float num = this.OCOLLENJFNG(this.hiddenValue.y);
				if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && Math.Abs(num - this.fakeValue.y) > ObscuredCheatingDetector.ELOBJGIDGCP.vector3Epsilon)
				{
					ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
				}
				return num;
			}
			set
			{
				this.hiddenValue.y = this.LHKLJGDDEFF(value);
				if (ObscuredCheatingDetector.GOGDGKDDIPG)
				{
					this.fakeValue.x = this.OCOLLENJFNG(this.hiddenValue.x);
					this.fakeValue.y = value;
					this.fakeValue.z = this.OCOLLENJFNG(this.hiddenValue.z);
					this.fakeValueActive = true;
					return;
				}
				this.fakeValueActive = false;
			}
		}

		// Token: 0x06012D1A RID: 77082 RVA: 0x0081FB23 File Offset: 0x0081DD23
		public static ObscuredVector3 HEHLEFGHAJB(ObscuredVector3 EGABJKIFAON, float MBFGBDLOKFH)
		{
			return ObscuredVector3.BDLBFKPDOIH(EGABJKIFAON.MJFIFINDLAM() / MBFGBDLOKFH);
		}

		// Token: 0x06012D1B RID: 77083 RVA: 0x0081FFC3 File Offset: 0x0081E1C3
		public static bool BAKPLODMMOJ(ObscuredVector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK.MJFIFINDLAM() == AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D1C RID: 77084 RVA: 0x0081FC58 File Offset: 0x0081DE58
		public static bool CPJMBGMOBED(Vector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK != AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D1D RID: 77085 RVA: 0x0081FF5C File Offset: 0x0081E15C
		private int BECIIEDLLPB(float LDKMOLEEDIL)
		{
			return ObscuredFloat.ALHMMAGENAF(LDKMOLEEDIL, ObscuredVector3.cryptoKey);
		}

		// Token: 0x06012D1E RID: 77086 RVA: 0x0081FFD8 File Offset: 0x0081E1D8
		public string NHDAHNIOAFD()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012D1F RID: 77087 RVA: 0x0081FFF9 File Offset: 0x0081E1F9
		public static ObscuredVector3 MMPGJFLGJED(ObscuredVector3 EGABJKIFAON)
		{
			return ObscuredVector3.GOOIABGKMHK(-EGABJKIFAON.MJFIFINDLAM());
		}

		// Token: 0x06012D20 RID: 77088 RVA: 0x0082000C File Offset: 0x0081E20C
		public void OJFAJIJBEFD()
		{
			Vector3 dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredVector3.HBJHGHOKFDK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012D21 RID: 77089 RVA: 0x0082004F File Offset: 0x0081E24F
		public void OKOFICIBFMO()
		{
			if (this.currentCryptoKey != ObscuredVector3.cryptoKey)
			{
				this.hiddenValue = ObscuredVector3.EKKPPKGFFCH(this.MJFIFINDLAM(), ObscuredVector3.cryptoKey);
				this.currentCryptoKey = ObscuredVector3.cryptoKey;
			}
		}

		// Token: 0x06012D22 RID: 77090 RVA: 0x00820080 File Offset: 0x0081E280
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06012D23 RID: 77091 RVA: 0x008200A4 File Offset: 0x0081E2A4
		// (set) Token: 0x06012D51 RID: 77137 RVA: 0x008206D0 File Offset: 0x0081E8D0
		public float x
		{
			get
			{
				float num = this.OCOLLENJFNG(this.hiddenValue.x);
				if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && Math.Abs(num - this.fakeValue.x) > ObscuredCheatingDetector.ELOBJGIDGCP.vector3Epsilon)
				{
					ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
				}
				return num;
			}
			set
			{
				this.hiddenValue.x = this.LHKLJGDDEFF(value);
				if (ObscuredCheatingDetector.GOGDGKDDIPG)
				{
					this.fakeValue.x = value;
					this.fakeValue.y = this.OCOLLENJFNG(this.hiddenValue.y);
					this.fakeValue.z = this.OCOLLENJFNG(this.hiddenValue.z);
					this.fakeValueActive = true;
					return;
				}
				this.fakeValueActive = false;
			}
		}

		// Token: 0x06012D24 RID: 77092 RVA: 0x0081FFC3 File Offset: 0x0081E1C3
		public static bool KFLICFBHNLF(ObscuredVector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK.MJFIFINDLAM() == AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D25 RID: 77093 RVA: 0x008200FB File Offset: 0x0081E2FB
		public ObscuredVector3.RawEncryptedVector3 PPOLGPGMJBG()
		{
			this.DCPMKLBOCDA();
			return this.hiddenValue;
		}

		// Token: 0x06012D26 RID: 77094 RVA: 0x0082010C File Offset: 0x0081E30C
		public string FPPLGDMIGKI(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012D27 RID: 77095 RVA: 0x00820128 File Offset: 0x0081E328
		public ObscuredVector3.RawEncryptedVector3 NBKCHAOJBKN()
		{
			this.FLALIGLOJBM();
			return this.hiddenValue;
		}

		// Token: 0x06012D28 RID: 77096 RVA: 0x00820136 File Offset: 0x0081E336
		public Vector3 OEAMCPLDFEH()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012D29 RID: 77097 RVA: 0x00820140 File Offset: 0x0081E340
		public override bool Equals(object INDANOPGHCN)
		{
			return this.MJFIFINDLAM().Equals(INDANOPGHCN);
		}

		// Token: 0x06012D2A RID: 77098 RVA: 0x0082004F File Offset: 0x0081E24F
		public void DCPMKLBOCDA()
		{
			if (this.currentCryptoKey != ObscuredVector3.cryptoKey)
			{
				this.hiddenValue = ObscuredVector3.EKKPPKGFFCH(this.MJFIFINDLAM(), ObscuredVector3.cryptoKey);
				this.currentCryptoKey = ObscuredVector3.cryptoKey;
			}
		}

		// Token: 0x06012D2C RID: 77100 RVA: 0x0082019A File Offset: 0x0081E39A
		public static ObscuredVector3 FPEHEFFMHPM(ObscuredVector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.BDLBFKPDOIH(EGABJKIFAON.MJFIFINDLAM() - HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D2D RID: 77101 RVA: 0x008201B4 File Offset: 0x0081E3B4
		private ObscuredVector3(Vector3 DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredVector3.cryptoKey;
			this.hiddenValue = ObscuredVector3.HBJHGHOKFDK(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : ObscuredVector3.zero);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x06012D2E RID: 77102 RVA: 0x0081FB1B File Offset: 0x0081DD1B
		public static void DFBLJCKOKDL(int JODDIMFACHN)
		{
			ObscuredVector3.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012D2F RID: 77103 RVA: 0x008201FD File Offset: 0x0081E3FD
		public static ObscuredVector3.RawEncryptedVector3 EDDOPACHPFB(Vector3 DCCPCBLODIG)
		{
			return ObscuredVector3.HBJHGHOKFDK(DCCPCBLODIG, 1);
		}

		// Token: 0x06012D30 RID: 77104 RVA: 0x00820208 File Offset: 0x0081E408
		public void DAMHMPCBNEI()
		{
			Vector3 dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(61, -48);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredVector3.EKKPPKGFFCH(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012D31 RID: 77105 RVA: 0x0082024C File Offset: 0x0081E44C
		public int LNBHNPKAMAD()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012D32 RID: 77106 RVA: 0x0081FEF7 File Offset: 0x0081E0F7
		public static bool JBBNNDACBHJ(ObscuredVector3 HFKFJPLEAGK, Vector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK.MJFIFINDLAM() != AJFADLOIJDK;
		}

		// Token: 0x06012D33 RID: 77107 RVA: 0x0082026D File Offset: 0x0081E46D
		public static bool GENHOOKGPOL(Vector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK == AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D34 RID: 77108 RVA: 0x0082027C File Offset: 0x0081E47C
		public static Vector3 DHPGAJEHAFD(ObscuredVector3.RawEncryptedVector3 DCCPCBLODIG)
		{
			return ObscuredVector3.DHPGAJEHAFD(DCCPCBLODIG, 0);
		}

		// Token: 0x06012D35 RID: 77109 RVA: 0x00820288 File Offset: 0x0081E488
		public static ObscuredVector3.RawEncryptedVector3 GGIBCLJMFLF(float OCNGPCPMCPM, float ADMFAEOOOHD, float DOCOLPILEAF, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredVector3.cryptoKey;
			}
			ObscuredVector3.RawEncryptedVector3 result;
			result.x = ObscuredFloat.HBJHGHOKFDK(OCNGPCPMCPM, JMBKDINHDLO);
			result.y = ObscuredFloat.ALHMMAGENAF(ADMFAEOOOHD, JMBKDINHDLO);
			result.z = ObscuredFloat.ALHMMAGENAF(DOCOLPILEAF, JMBKDINHDLO);
			return result;
		}

		// Token: 0x06012D36 RID: 77110 RVA: 0x008202CA File Offset: 0x0081E4CA
		public static ObscuredVector3 DEJAGBDELEH(ObscuredVector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.BDLBFKPDOIH(EGABJKIFAON.MJFIFINDLAM() + HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D37 RID: 77111 RVA: 0x0082019A File Offset: 0x0081E39A
		public static ObscuredVector3 IPLFIJLGLFK(ObscuredVector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.BDLBFKPDOIH(EGABJKIFAON.MJFIFINDLAM() - HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D38 RID: 77112 RVA: 0x008202E4 File Offset: 0x0081E4E4
		private bool FIAPGCKJBAJ(Vector3 DKOLICIIGGI, Vector3 DFMEODBCGHJ)
		{
			float vector3Epsilon = ObscuredCheatingDetector.BLJNHIFIBDC().vector3Epsilon;
			return Math.Abs(DKOLICIIGGI.x - DFMEODBCGHJ.x) >= vector3Epsilon || Math.Abs(DKOLICIIGGI.y - DFMEODBCGHJ.y) >= vector3Epsilon || Math.Abs(DKOLICIIGGI.z - DFMEODBCGHJ.z) < vector3Epsilon;
		}

		// Token: 0x06012D39 RID: 77113 RVA: 0x00820340 File Offset: 0x0081E540
		public static Vector3 DHPGAJEHAFD(ObscuredVector3.RawEncryptedVector3 DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredVector3.cryptoKey;
			}
			Vector3 result;
			result.x = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.x, JMBKDINHDLO);
			result.y = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.y, JMBKDINHDLO);
			result.z = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.z, JMBKDINHDLO);
			return result;
		}

		// Token: 0x06012D3A RID: 77114 RVA: 0x00820394 File Offset: 0x0081E594
		public ObscuredVector3(float OCNGPCPMCPM, float ADMFAEOOOHD, float DOCOLPILEAF)
		{
			this.currentCryptoKey = ObscuredVector3.cryptoKey;
			this.hiddenValue = ObscuredVector3.HBJHGHOKFDK(OCNGPCPMCPM, ADMFAEOOOHD, DOCOLPILEAF, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue.x = OCNGPCPMCPM;
				this.fakeValue.y = ADMFAEOOOHD;
				this.fakeValue.z = DOCOLPILEAF;
				this.fakeValueActive = true;
			}
			else
			{
				this.fakeValue = ObscuredVector3.zero;
				this.fakeValueActive = false;
			}
			this.inited = true;
		}

		// Token: 0x06012D3B RID: 77115 RVA: 0x0081FFF9 File Offset: 0x0081E1F9
		public static ObscuredVector3 JGDDFNMLIMP(ObscuredVector3 EGABJKIFAON)
		{
			return ObscuredVector3.GOOIABGKMHK(-EGABJKIFAON.MJFIFINDLAM());
		}

		// Token: 0x06012D3C RID: 77116 RVA: 0x00820410 File Offset: 0x0081E610
		public void DIMMELBDJCP(float DCCPCBLODIG)
		{
			this.hiddenValue.y = this.APFENCKIHBD(DCCPCBLODIG);
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
			{
				this.fakeValue.x = this.OCOLLENJFNG(this.hiddenValue.x);
				this.fakeValue.y = DCCPCBLODIG;
				this.fakeValue.z = this.KLKEAJOCMBI(this.hiddenValue.z);
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012D3D RID: 77117 RVA: 0x0081FE4A File Offset: 0x0081E04A
		public static Vector3 FDINLHICIAE(ObscuredVector3 DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012D3E RID: 77118 RVA: 0x0081FC58 File Offset: 0x0081DE58
		public static bool OMLDLFHILAP(Vector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK != AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D3F RID: 77119 RVA: 0x00820489 File Offset: 0x0081E689
		public static ObscuredVector3 JHIBOEFONII(ObscuredVector3 EGABJKIFAON, Vector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON.MJFIFINDLAM() - HHAGIHEGFML);
		}

		// Token: 0x06012D40 RID: 77120 RVA: 0x008204A0 File Offset: 0x0081E6A0
		private bool CIJMIEADOPJ(Vector3 DKOLICIIGGI, Vector3 DFMEODBCGHJ)
		{
			float vector3Epsilon = ObscuredCheatingDetector.LNANLECJDDA().vector3Epsilon;
			return Math.Abs(DKOLICIIGGI.x - DFMEODBCGHJ.x) >= vector3Epsilon || Math.Abs(DKOLICIIGGI.y - DFMEODBCGHJ.y) >= vector3Epsilon || Math.Abs(DKOLICIIGGI.z - DFMEODBCGHJ.z) < vector3Epsilon;
		}

		// Token: 0x06012D41 RID: 77121 RVA: 0x008204F9 File Offset: 0x0081E6F9
		public void FLALIGLOJBM()
		{
			if (this.currentCryptoKey != ObscuredVector3.cryptoKey)
			{
				this.hiddenValue = ObscuredVector3.EFOPLMAGNBD(this.MJFIFINDLAM(), ObscuredVector3.cryptoKey);
				this.currentCryptoKey = ObscuredVector3.cryptoKey;
			}
		}

		// Token: 0x06012D43 RID: 77123 RVA: 0x008205A5 File Offset: 0x0081E7A5
		public static ObscuredVector3.RawEncryptedVector3 EFOPLMAGNBD(Vector3 DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredVector3.GGIBCLJMFLF(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, JMBKDINHDLO);
		}

		// Token: 0x06012D44 RID: 77124 RVA: 0x008205BF File Offset: 0x0081E7BF
		private int LHKLJGDDEFF(float LDKMOLEEDIL)
		{
			return ObscuredFloat.HBJHGHOKFDK(LDKMOLEEDIL, ObscuredVector3.cryptoKey);
		}

		// Token: 0x06012D45 RID: 77125 RVA: 0x0082019A File Offset: 0x0081E39A
		public static ObscuredVector3 MHCLPDCMLLI(ObscuredVector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.BDLBFKPDOIH(EGABJKIFAON.MJFIFINDLAM() - HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D46 RID: 77126 RVA: 0x0081FD4C File Offset: 0x0081DF4C
		public ObscuredVector3.RawEncryptedVector3 LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012D47 RID: 77127 RVA: 0x0081FC44 File Offset: 0x0081DE44
		public static ObscuredVector3 PPBHEODICFA(Vector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON - HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D48 RID: 77128 RVA: 0x008205CC File Offset: 0x0081E7CC
		public static ObscuredVector3 DMIPGCHEFPM(Vector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.BDLBFKPDOIH(EGABJKIFAON - HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D49 RID: 77129 RVA: 0x008205E0 File Offset: 0x0081E7E0
		public void LABEACCDKMD(ObscuredVector3.RawEncryptedVector3 LDKMOLEEDIL)
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

		// Token: 0x06012D4A RID: 77130 RVA: 0x00820612 File Offset: 0x0081E812
		public static bool PHNFIDHGFLE(ObscuredVector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK.MJFIFINDLAM() != AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D4B RID: 77131 RVA: 0x0081FD4C File Offset: 0x0081DF4C
		public ObscuredVector3.RawEncryptedVector3 AAOGABMJDGO()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012D4C RID: 77132 RVA: 0x00820627 File Offset: 0x0081E827
		public static Vector3 JJPNCEOKFHL(ObscuredVector3.RawEncryptedVector3 DCCPCBLODIG)
		{
			return ObscuredVector3.GJJDHACFMFI(DCCPCBLODIG, 0);
		}

		// Token: 0x06012D4D RID: 77133 RVA: 0x00820630 File Offset: 0x0081E830
		public void FBGFDOFEDKG(int CLBPBJGLHEE, float DCCPCBLODIG)
		{
			switch (CLBPBJGLHEE)
			{
			case 0:
				this.x = DCCPCBLODIG;
				return;
			case 1:
				this.DIMMELBDJCP(DCCPCBLODIG);
				return;
			case 2:
				this.z = DCCPCBLODIG;
				return;
			default:
				throw new IndexOutOfRangeException("_BlurVector");
			}
		}

		// Token: 0x06012D4E RID: 77134 RVA: 0x00820668 File Offset: 0x0081E868
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012D4F RID: 77135 RVA: 0x0081FC58 File Offset: 0x0081DE58
		public static bool HDFJOKAGNJC(Vector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK != AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D50 RID: 77136 RVA: 0x0082068C File Offset: 0x0081E88C
		public static ObscuredVector3.RawEncryptedVector3 HBJHGHOKFDK(float OCNGPCPMCPM, float ADMFAEOOOHD, float DOCOLPILEAF, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredVector3.cryptoKey;
			}
			ObscuredVector3.RawEncryptedVector3 result;
			result.x = ObscuredFloat.HBJHGHOKFDK(OCNGPCPMCPM, JMBKDINHDLO);
			result.y = ObscuredFloat.HBJHGHOKFDK(ADMFAEOOOHD, JMBKDINHDLO);
			result.z = ObscuredFloat.HBJHGHOKFDK(DOCOLPILEAF, JMBKDINHDLO);
			return result;
		}

		// Token: 0x06012D52 RID: 77138 RVA: 0x0082026D File Offset: 0x0081E46D
		public static bool BAKPLODMMOJ(Vector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK == AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D53 RID: 77139 RVA: 0x0082074C File Offset: 0x0081E94C
		private float OCOLLENJFNG(int LDKMOLEEDIL)
		{
			int jmbkdinhdlo = ObscuredVector3.cryptoKey;
			if (this.currentCryptoKey != ObscuredVector3.cryptoKey)
			{
				jmbkdinhdlo = this.currentCryptoKey;
			}
			return ObscuredFloat.DHPGAJEHAFD(LDKMOLEEDIL, jmbkdinhdlo);
		}

		// Token: 0x06012D54 RID: 77140 RVA: 0x0082077A File Offset: 0x0081E97A
		public static ObscuredVector3 PICCFFHAMAG(ObscuredVector3 EGABJKIFAON, Vector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON.MJFIFINDLAM() + HHAGIHEGFML);
		}

		// Token: 0x06012D55 RID: 77141 RVA: 0x0082078E File Offset: 0x0081E98E
		public static ObscuredVector3.RawEncryptedVector3 AIGEHHIJGEG(Vector3 DCCPCBLODIG)
		{
			return ObscuredVector3.EFOPLMAGNBD(DCCPCBLODIG, 0);
		}

		// Token: 0x06012D56 RID: 77142 RVA: 0x00820798 File Offset: 0x0081E998
		private bool CCJFIMABELM(Vector3 DKOLICIIGGI, Vector3 DFMEODBCGHJ)
		{
			float vector3Epsilon = ObscuredCheatingDetector.ELOBJGIDGCP.vector3Epsilon;
			return Math.Abs(DKOLICIIGGI.x - DFMEODBCGHJ.x) < vector3Epsilon && Math.Abs(DKOLICIIGGI.y - DFMEODBCGHJ.y) < vector3Epsilon && Math.Abs(DKOLICIIGGI.z - DFMEODBCGHJ.z) < vector3Epsilon;
		}

		// Token: 0x06012D57 RID: 77143 RVA: 0x008207F1 File Offset: 0x0081E9F1
		public static ObscuredVector3 PICCFFHAMAG(ObscuredVector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON.MJFIFINDLAM() + HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D58 RID: 77144 RVA: 0x0082026D File Offset: 0x0081E46D
		public static bool LPNKPOOKEFD(Vector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK == AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D59 RID: 77145 RVA: 0x0082080C File Offset: 0x0081EA0C
		public static Vector3 GJJDHACFMFI(ObscuredVector3.RawEncryptedVector3 DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredVector3.cryptoKey;
			}
			Vector3 result;
			result.x = ObscuredFloat.GGPGJEHDJHK(DCCPCBLODIG.x, JMBKDINHDLO);
			result.y = ObscuredFloat.GGPGJEHDJHK(DCCPCBLODIG.y, JMBKDINHDLO);
			result.z = ObscuredFloat.DLEINJOAHNM(DCCPCBLODIG.z, JMBKDINHDLO);
			return result;
		}

		// Token: 0x06012D5A RID: 77146 RVA: 0x00820489 File Offset: 0x0081E689
		public static ObscuredVector3 PPBHEODICFA(ObscuredVector3 EGABJKIFAON, Vector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON.MJFIFINDLAM() - HHAGIHEGFML);
		}

		// Token: 0x06012D5B RID: 77147 RVA: 0x00820860 File Offset: 0x0081EA60
		public string MDAPFDLEEGN(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012D5C RID: 77148 RVA: 0x0082087C File Offset: 0x0081EA7C
		public static ObscuredVector3.RawEncryptedVector3 AOLCDFJDHAF(Vector3 DCCPCBLODIG)
		{
			return ObscuredVector3.EKKPPKGFFCH(DCCPCBLODIG, 0);
		}

		// Token: 0x06012D5D RID: 77149 RVA: 0x00820885 File Offset: 0x0081EA85
		public static ObscuredVector3 BHEKELECGMA(ObscuredVector3 EGABJKIFAON, Vector3 HHAGIHEGFML)
		{
			return ObscuredVector3.BDLBFKPDOIH(EGABJKIFAON.MJFIFINDLAM() - HHAGIHEGFML);
		}

		// Token: 0x06012D5E RID: 77150 RVA: 0x008207F1 File Offset: 0x0081E9F1
		public static ObscuredVector3 BCLJKBLBHCG(ObscuredVector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON.MJFIFINDLAM() + HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D5F RID: 77151 RVA: 0x008205CC File Offset: 0x0081E7CC
		public static ObscuredVector3 MJALCODMNKI(Vector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.BDLBFKPDOIH(EGABJKIFAON - HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D60 RID: 77152 RVA: 0x00820899 File Offset: 0x0081EA99
		public float NMONOEMBPDL(int CLBPBJGLHEE)
		{
			switch (CLBPBJGLHEE)
			{
			case 0:
				return this.x;
			case 1:
				return this.JHFMLEGPNHB();
			case 2:
				return this.z;
			default:
				throw new IndexOutOfRangeException("IdleStand");
			}
		}

		// Token: 0x06012D61 RID: 77153 RVA: 0x008208CE File Offset: 0x0081EACE
		public static ObscuredVector3.RawEncryptedVector3 HBJHGHOKFDK(Vector3 DCCPCBLODIG)
		{
			return ObscuredVector3.HBJHGHOKFDK(DCCPCBLODIG, 0);
		}

		// Token: 0x06012D62 RID: 77154 RVA: 0x008208D7 File Offset: 0x0081EAD7
		public static ObscuredVector3 FGDFOOKKLFI(ObscuredVector3 EGABJKIFAON, float MBFGBDLOKFH)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON.MJFIFINDLAM() / MBFGBDLOKFH);
		}

		// Token: 0x06012D63 RID: 77155 RVA: 0x008208EB File Offset: 0x0081EAEB
		public static ObscuredVector3 NHIJGBPBLFC(ObscuredVector3 EGABJKIFAON, float MBFGBDLOKFH)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON.MJFIFINDLAM() * MBFGBDLOKFH);
		}

		// Token: 0x06012D64 RID: 77156 RVA: 0x00820900 File Offset: 0x0081EB00
		public void OBMCIGIPGAA(float DCCPCBLODIG)
		{
			this.hiddenValue.z = this.BECIIEDLLPB(DCCPCBLODIG);
			if (ObscuredCheatingDetector.DNBHPCEAKMG())
			{
				this.fakeValue.x = this.KLKEAJOCMBI(this.hiddenValue.x);
				this.fakeValue.y = this.OCOLLENJFNG(this.hiddenValue.y);
				this.fakeValue.z = DCCPCBLODIG;
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012D65 RID: 77157 RVA: 0x0081FC67 File Offset: 0x0081DE67
		public static bool GPLAAFDDMMF(ObscuredVector3 HFKFJPLEAGK, Vector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK.MJFIFINDLAM() == AJFADLOIJDK;
		}

		// Token: 0x06012D67 RID: 77159 RVA: 0x0082098F File Offset: 0x0081EB8F
		public static ObscuredVector3 GOOIABGKMHK(Vector3 DCCPCBLODIG)
		{
			return new ObscuredVector3(DCCPCBLODIG);
		}

		// Token: 0x06012D68 RID: 77160 RVA: 0x0081FEF7 File Offset: 0x0081E0F7
		public static bool HDFJOKAGNJC(ObscuredVector3 HFKFJPLEAGK, Vector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK.MJFIFINDLAM() != AJFADLOIJDK;
		}

		// Token: 0x06012D69 RID: 77161 RVA: 0x00820997 File Offset: 0x0081EB97
		public static ObscuredVector3 NHIJGBPBLFC(float MBFGBDLOKFH, ObscuredVector3 EGABJKIFAON)
		{
			return ObscuredVector3.GOOIABGKMHK(MBFGBDLOKFH * EGABJKIFAON.MJFIFINDLAM());
		}

		// Token: 0x06012D6A RID: 77162 RVA: 0x00820136 File Offset: 0x0081E336
		public Vector3 FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012D6B RID: 77163 RVA: 0x008209AC File Offset: 0x0081EBAC
		public float FOKFOKPABLE()
		{
			float num = this.KLKEAJOCMBI(this.hiddenValue.z);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && Math.Abs(num - this.fakeValue.z) > ObscuredCheatingDetector.GGOEIHCJEHP().vector3Epsilon)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012D6C RID: 77164 RVA: 0x00820612 File Offset: 0x0081E812
		public static bool HDFJOKAGNJC(ObscuredVector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK.MJFIFINDLAM() != AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D6D RID: 77165 RVA: 0x00820136 File Offset: 0x0081E336
		public Vector3 CLFGHCNHMAM()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012D6F RID: 77167 RVA: 0x00820A7D File Offset: 0x0081EC7D
		public static ObscuredVector3.RawEncryptedVector3 HBJHGHOKFDK(Vector3 DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredVector3.HBJHGHOKFDK(DCCPCBLODIG.x, DCCPCBLODIG.y, DCCPCBLODIG.z, JMBKDINHDLO);
		}

		// Token: 0x06012D70 RID: 77168 RVA: 0x0081FC44 File Offset: 0x0081DE44
		public static ObscuredVector3 PDFHJEIKECF(Vector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON - HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D71 RID: 77169 RVA: 0x00820A97 File Offset: 0x0081EC97
		public float NJDBCPANHAH(int CLBPBJGLHEE)
		{
			switch (CLBPBJGLHEE)
			{
			case 0:
				return this.x;
			case 1:
				return this.y;
			case 2:
				return this.z;
			default:
				throw new IndexOutOfRangeException("TOD_MoonMeshColor");
			}
		}

		// Token: 0x06012D72 RID: 77170 RVA: 0x00820136 File Offset: 0x0081E336
		public Vector3 JOCEGBNBHIG()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012D73 RID: 77171 RVA: 0x0081FC58 File Offset: 0x0081DE58
		public static bool DCJBHPOBGPB(Vector3 HFKFJPLEAGK, ObscuredVector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK != AJFADLOIJDK.MJFIFINDLAM();
		}

		// Token: 0x06012D74 RID: 77172 RVA: 0x0081FC67 File Offset: 0x0081DE67
		public static bool BAKPLODMMOJ(ObscuredVector3 HFKFJPLEAGK, Vector3 AJFADLOIJDK)
		{
			return HFKFJPLEAGK.MJFIFINDLAM() == AJFADLOIJDK;
		}

		// Token: 0x06012D75 RID: 77173 RVA: 0x0082077A File Offset: 0x0081E97A
		public static ObscuredVector3 PMFFDNNKLLD(ObscuredVector3 EGABJKIFAON, Vector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON.MJFIFINDLAM() + HHAGIHEGFML);
		}

		// Token: 0x06012D76 RID: 77174 RVA: 0x00820ACC File Offset: 0x0081ECCC
		public static ObscuredVector3 PICCFFHAMAG(Vector3 EGABJKIFAON, ObscuredVector3 HHAGIHEGFML)
		{
			return ObscuredVector3.GOOIABGKMHK(EGABJKIFAON + HHAGIHEGFML.MJFIFINDLAM());
		}

		// Token: 0x06012D77 RID: 77175 RVA: 0x00820AE0 File Offset: 0x0081ECE0
		public float CJOGBEEPMIC()
		{
			float num = this.OCOLLENJFNG(this.hiddenValue.z);
			if (ObscuredCheatingDetector.DNBHPCEAKMG() && this.fakeValueActive && Math.Abs(num - this.fakeValue.z) > ObscuredCheatingDetector.ELOBJGIDGCP.vector3Epsilon)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012D78 RID: 77176 RVA: 0x0081FB1B File Offset: 0x0081DD1B
		public static void BBOGAEMNJJN(int JODDIMFACHN)
		{
			ObscuredVector3.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012D79 RID: 77177 RVA: 0x0082098F File Offset: 0x0081EB8F
		public static ObscuredVector3 BDLBFKPDOIH(Vector3 DCCPCBLODIG)
		{
			return new ObscuredVector3(DCCPCBLODIG);
		}

		// Token: 0x0400267D RID: 9853
		private static int cryptoKey = 120207;

		// Token: 0x0400267E RID: 9854
		private static readonly Vector3 zero = Vector3.zero;

		// Token: 0x0400267F RID: 9855
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04002680 RID: 9856
		[SerializeField]
		private ObscuredVector3.RawEncryptedVector3 hiddenValue;

		// Token: 0x04002681 RID: 9857
		[SerializeField]
		private bool inited;

		// Token: 0x04002682 RID: 9858
		[SerializeField]
		private Vector3 fakeValue;

		// Token: 0x04002683 RID: 9859
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x02000595 RID: 1429
		[Serializable]
		public struct RawEncryptedVector3
		{
			// Token: 0x04002684 RID: 9860
			public int x;

			// Token: 0x04002685 RID: 9861
			public int y;

			// Token: 0x04002686 RID: 9862
			public int z;
		}
	}
}
