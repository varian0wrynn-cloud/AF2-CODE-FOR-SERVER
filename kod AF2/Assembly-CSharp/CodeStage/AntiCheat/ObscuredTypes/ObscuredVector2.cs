using System;
using CodeStage.AntiCheat.Detectors;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	// Token: 0x02000592 RID: 1426
	[Serializable]
	public struct ObscuredVector2
	{
		// Token: 0x06012CB4 RID: 76980 RVA: 0x0081EDA9 File Offset: 0x0081CFA9
		public void AFOKAPKGHJH()
		{
			if (this.currentCryptoKey != ObscuredVector2.cryptoKey)
			{
				this.hiddenValue = ObscuredVector2.HBJHGHOKFDK(this.MJFIFINDLAM(), ObscuredVector2.cryptoKey);
				this.currentCryptoKey = ObscuredVector2.cryptoKey;
			}
		}

		// Token: 0x06012CB5 RID: 76981 RVA: 0x0081EDD9 File Offset: 0x0081CFD9
		public ObscuredVector2.RawEncryptedVector2 BBBDDDDJAFI()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012CB6 RID: 76982 RVA: 0x0081EDE7 File Offset: 0x0081CFE7
		public void JLAIFJAABML()
		{
			if (this.currentCryptoKey != ObscuredVector2.cryptoKey)
			{
				this.hiddenValue = ObscuredVector2.HBJHGHOKFDK(this.HMKNGLCANDE(), ObscuredVector2.cryptoKey);
				this.currentCryptoKey = ObscuredVector2.cryptoKey;
			}
		}

		// Token: 0x06012CB7 RID: 76983 RVA: 0x0081EE18 File Offset: 0x0081D018
		public string NHDAHNIOAFD()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012CB8 RID: 76984 RVA: 0x0081EE39 File Offset: 0x0081D039
		public float IMBMFCCJIKJ(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE == 0)
			{
				return this.x;
			}
			if (CLBPBJGLHEE != 1)
			{
				throw new IndexOutOfRangeException("800000");
			}
			return this.GEDGMMBKPPN();
		}

		// Token: 0x06012CB9 RID: 76985 RVA: 0x0081EE5C File Offset: 0x0081D05C
		public static Vector2 OGMPPMCDBBB(ObscuredVector2.RawEncryptedVector2 DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredVector2.cryptoKey;
			}
			Vector2 result;
			result.x = ObscuredFloat.DLEINJOAHNM(DCCPCBLODIG.x, JMBKDINHDLO);
			result.y = ObscuredFloat.GGPGJEHDJHK(DCCPCBLODIG.y, JMBKDINHDLO);
			return result;
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06012CBA RID: 76986 RVA: 0x0081EE9C File Offset: 0x0081D09C
		// (set) Token: 0x06012CCC RID: 77004 RVA: 0x0081F1D0 File Offset: 0x0081D3D0
		public float y
		{
			get
			{
				float num = this.OCOLLENJFNG(this.hiddenValue.y);
				if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && Math.Abs(num - this.fakeValue.y) > ObscuredCheatingDetector.ELOBJGIDGCP.vector2Epsilon)
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
					this.fakeValueActive = true;
					return;
				}
				this.fakeValueActive = false;
			}
		}

		// Token: 0x06012CBB RID: 76987 RVA: 0x0081EEF4 File Offset: 0x0081D0F4
		public ObscuredVector2(float OCNGPCPMCPM, float ADMFAEOOOHD)
		{
			this.currentCryptoKey = ObscuredVector2.cryptoKey;
			this.hiddenValue = ObscuredVector2.HBJHGHOKFDK(OCNGPCPMCPM, ADMFAEOOOHD, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue.x = OCNGPCPMCPM;
				this.fakeValue.y = ADMFAEOOOHD;
				this.fakeValueActive = true;
			}
			else
			{
				this.fakeValue = ObscuredVector2.zero;
				this.fakeValueActive = false;
			}
			this.inited = true;
		}

		// Token: 0x06012CBC RID: 76988 RVA: 0x0081EF60 File Offset: 0x0081D160
		public void KDGMAKHNFED(int CLBPBJGLHEE, float DCCPCBLODIG)
		{
			if (CLBPBJGLHEE == 0)
			{
				this.HKHHJDOPJGK(DCCPCBLODIG);
				return;
			}
			if (CLBPBJGLHEE != 0)
			{
				throw new IndexOutOfRangeException("LMB to shoot the Dummy, RMB to rotate the camera.");
			}
			this.y = DCCPCBLODIG;
		}

		// Token: 0x06012CBD RID: 76989 RVA: 0x0081EF85 File Offset: 0x0081D185
		public static Vector2 DHPGAJEHAFD(ObscuredVector2.RawEncryptedVector2 DCCPCBLODIG)
		{
			return ObscuredVector2.DHPGAJEHAFD(DCCPCBLODIG, 0);
		}

		// Token: 0x06012CBE RID: 76990 RVA: 0x0081EF85 File Offset: 0x0081D185
		public static Vector2 PCCEJJLFKIH(ObscuredVector2.RawEncryptedVector2 DCCPCBLODIG)
		{
			return ObscuredVector2.DHPGAJEHAFD(DCCPCBLODIG, 0);
		}

		// Token: 0x06012CBF RID: 76991 RVA: 0x0081EDD9 File Offset: 0x0081CFD9
		public ObscuredVector2.RawEncryptedVector2 LPKJBCBADMN()
		{
			this.AFOKAPKGHJH();
			return this.hiddenValue;
		}

		// Token: 0x06012CC0 RID: 76992 RVA: 0x0081EF8E File Offset: 0x0081D18E
		public float GKHCIEGFGHE(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE == 0)
			{
				return this.MBLPBAEAECN();
			}
			if (CLBPBJGLHEE != 0)
			{
				throw new IndexOutOfRangeException("**MMOItem");
			}
			return this.CLACOMDHCIK();
		}

		// Token: 0x06012CC1 RID: 76993 RVA: 0x0081EFB4 File Offset: 0x0081D1B4
		public static Vector3 EMFOKHGIMFM(ObscuredVector2 DCCPCBLODIG)
		{
			Vector2 vector = DCCPCBLODIG.HMKNGLCANDE();
			return new Vector3(vector.x, vector.y, 1527f);
		}

		// Token: 0x06012CC2 RID: 76994 RVA: 0x0081EFE0 File Offset: 0x0081D1E0
		public void OJFAJIJBEFD()
		{
			Vector2 dccpcblodig = this.MJFIFINDLAM();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(int.MinValue, int.MaxValue);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredVector2.HBJHGHOKFDK(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012CC3 RID: 76995 RVA: 0x0081F024 File Offset: 0x0081D224
		public float CLACOMDHCIK()
		{
			float num = this.IBOJIHMEHOB(this.hiddenValue.y);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && Math.Abs(num - this.fakeValue.y) > ObscuredCheatingDetector.BLJNHIFIBDC().vector2Epsilon)
			{
				ObscuredCheatingDetector.GGOEIHCJEHP().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012CC4 RID: 76996 RVA: 0x0081F07C File Offset: 0x0081D27C
		public static ObscuredVector2.RawEncryptedVector2 HBJHGHOKFDK(float OCNGPCPMCPM, float ADMFAEOOOHD, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredVector2.cryptoKey;
			}
			ObscuredVector2.RawEncryptedVector2 result;
			result.x = ObscuredFloat.HBJHGHOKFDK(OCNGPCPMCPM, JMBKDINHDLO);
			result.y = ObscuredFloat.HBJHGHOKFDK(ADMFAEOOOHD, JMBKDINHDLO);
			return result;
		}

		// Token: 0x06012CC5 RID: 76997 RVA: 0x0081F0B0 File Offset: 0x0081D2B0
		public static ObscuredVector2 GOOIABGKMHK(Vector2 DCCPCBLODIG)
		{
			return new ObscuredVector2(DCCPCBLODIG);
		}

		// Token: 0x06012CC6 RID: 76998 RVA: 0x0081F0B8 File Offset: 0x0081D2B8
		public ObscuredVector2.RawEncryptedVector2 PPOLGPGMJBG()
		{
			this.JLAIFJAABML();
			return this.hiddenValue;
		}

		// Token: 0x06012CC7 RID: 76999 RVA: 0x0081F0C8 File Offset: 0x0081D2C8
		private bool CCJFIMABELM(Vector2 DKOLICIIGGI, Vector2 DFMEODBCGHJ)
		{
			float vector2Epsilon = ObscuredCheatingDetector.ELOBJGIDGCP.vector2Epsilon;
			return Math.Abs(DKOLICIIGGI.x - DFMEODBCGHJ.x) < vector2Epsilon && Math.Abs(DKOLICIIGGI.y - DFMEODBCGHJ.y) < vector2Epsilon;
		}

		// Token: 0x06012CC8 RID: 77000 RVA: 0x0081F10C File Offset: 0x0081D30C
		public int KEPLOAFMIPO()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012CC9 RID: 77001 RVA: 0x0081F130 File Offset: 0x0081D330
		public int NBDJPCPAFGN()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06012CCA RID: 77002 RVA: 0x0081F154 File Offset: 0x0081D354
		// (set) Token: 0x06012CF5 RID: 77045 RVA: 0x0081F910 File Offset: 0x0081DB10
		public float x
		{
			get
			{
				float num = this.OCOLLENJFNG(this.hiddenValue.x);
				if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && Math.Abs(num - this.fakeValue.x) > ObscuredCheatingDetector.ELOBJGIDGCP.vector2Epsilon)
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
					this.fakeValueActive = true;
					return;
				}
				this.fakeValueActive = false;
			}
		}

		// Token: 0x06012CCB RID: 77003 RVA: 0x0081F1AB File Offset: 0x0081D3AB
		public float DEPHBDNPEEN(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE == 0)
			{
				return this.MBLPBAEAECN();
			}
			if (CLBPBJGLHEE != 1)
			{
				throw new IndexOutOfRangeException("RoundHouse");
			}
			return this.GPKLPGHCAHH();
		}

		// Token: 0x06012CCD RID: 77005 RVA: 0x0081F22D File Offset: 0x0081D42D
		public static void NLJCLDBEEPM(int JODDIMFACHN)
		{
			ObscuredVector2.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012CCE RID: 77006 RVA: 0x0081F238 File Offset: 0x0081D438
		public void CLMHNDAHOJD(float DCCPCBLODIG)
		{
			this.hiddenValue.y = this.LHKLJGDDEFF(DCCPCBLODIG);
			if (ObscuredCheatingDetector.GOGDGKDDIPG)
			{
				this.fakeValue.x = this.IBOJIHMEHOB(this.hiddenValue.x);
				this.fakeValue.y = DCCPCBLODIG;
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012CCF RID: 77007 RVA: 0x0081F295 File Offset: 0x0081D495
		public float JFEKBOKHGFG(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE == 0)
			{
				return this.x;
			}
			if (CLBPBJGLHEE != 0)
			{
				throw new IndexOutOfRangeException("<color='#200080'>");
			}
			return this.GPKLPGHCAHH();
		}

		// Token: 0x06012CD0 RID: 77008 RVA: 0x0081F2B8 File Offset: 0x0081D4B8
		public void JCJGHNCMNLE()
		{
			Vector2 dccpcblodig = this.HMKNGLCANDE();
			do
			{
				this.currentCryptoKey = UnityEngine.Random.Range(-177, -141);
			}
			while (this.currentCryptoKey == 0);
			this.hiddenValue = ObscuredVector2.HAMKOCCHOBN(dccpcblodig, this.currentCryptoKey);
		}

		// Token: 0x06012CD1 RID: 77009 RVA: 0x0081F2FC File Offset: 0x0081D4FC
		private float HPLKDAFELLC(int LDKMOLEEDIL)
		{
			int jmbkdinhdlo = ObscuredVector2.cryptoKey;
			if (this.currentCryptoKey != ObscuredVector2.cryptoKey)
			{
				jmbkdinhdlo = this.currentCryptoKey;
			}
			return ObscuredFloat.DHPGAJEHAFD(LDKMOLEEDIL, jmbkdinhdlo);
		}

		// Token: 0x06012CD2 RID: 77010 RVA: 0x0081F32A File Offset: 0x0081D52A
		private int LHKLJGDDEFF(float LDKMOLEEDIL)
		{
			return ObscuredFloat.HBJHGHOKFDK(LDKMOLEEDIL, ObscuredVector2.cryptoKey);
		}

		// Token: 0x06012CD3 RID: 77011 RVA: 0x0081F338 File Offset: 0x0081D538
		public int GNFDGHGCPDH()
		{
			return this.HMKNGLCANDE().GetHashCode();
		}

		// Token: 0x06012CD4 RID: 77012 RVA: 0x0081F0B8 File Offset: 0x0081D2B8
		public ObscuredVector2.RawEncryptedVector2 GJBBPLGAHHF()
		{
			this.JLAIFJAABML();
			return this.hiddenValue;
		}

		// Token: 0x06012CD5 RID: 77013 RVA: 0x0081F35C File Offset: 0x0081D55C
		public static Vector3 GOOIABGKMHK(ObscuredVector2 DCCPCBLODIG)
		{
			Vector2 vector = DCCPCBLODIG.MJFIFINDLAM();
			return new Vector3(vector.x, vector.y, 0f);
		}

		// Token: 0x06012CD6 RID: 77014 RVA: 0x0081F0B0 File Offset: 0x0081D2B0
		public static ObscuredVector2 NNJCOKFNJAG(Vector2 DCCPCBLODIG)
		{
			return new ObscuredVector2(DCCPCBLODIG);
		}

		// Token: 0x06012CD7 RID: 77015 RVA: 0x0081F22D File Offset: 0x0081D42D
		public static void EDHLDKJEBNF(int JODDIMFACHN)
		{
			ObscuredVector2.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012CD9 RID: 77017 RVA: 0x0081F39D File Offset: 0x0081D59D
		public static ObscuredVector2.RawEncryptedVector2 HBJHGHOKFDK(Vector2 DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredVector2.HBJHGHOKFDK(DCCPCBLODIG.x, DCCPCBLODIG.y, JMBKDINHDLO);
		}

		// Token: 0x06012CDA RID: 77018 RVA: 0x0081F39D File Offset: 0x0081D59D
		public static ObscuredVector2.RawEncryptedVector2 HAMKOCCHOBN(Vector2 DCCPCBLODIG, int JMBKDINHDLO)
		{
			return ObscuredVector2.HBJHGHOKFDK(DCCPCBLODIG.x, DCCPCBLODIG.y, JMBKDINHDLO);
		}

		// Token: 0x06012CDB RID: 77019 RVA: 0x0081F3B4 File Offset: 0x0081D5B4
		public string NIDKKALEJIM()
		{
			return this.HMKNGLCANDE().ToString();
		}

		// Token: 0x06012CDC RID: 77020 RVA: 0x0081F3D8 File Offset: 0x0081D5D8
		private ObscuredVector2(Vector2 DCCPCBLODIG)
		{
			this.currentCryptoKey = ObscuredVector2.cryptoKey;
			this.hiddenValue = ObscuredVector2.HBJHGHOKFDK(DCCPCBLODIG);
			bool flag = ObscuredCheatingDetector.GOGDGKDDIPG;
			this.fakeValue = (flag ? DCCPCBLODIG : ObscuredVector2.zero);
			this.fakeValueActive = flag;
			this.inited = true;
		}

		// Token: 0x06012CDD RID: 77021 RVA: 0x0081F424 File Offset: 0x0081D624
		public string JODMFMFAOEG(string LJCEDKCLBDB)
		{
			return this.HMKNGLCANDE().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012CDE RID: 77022 RVA: 0x0081F440 File Offset: 0x0081D640
		public string LHNOBJDFOOJ(string LJCEDKCLBDB)
		{
			return this.MJFIFINDLAM().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012CDF RID: 77023 RVA: 0x0081F45C File Offset: 0x0081D65C
		public static Vector2 NNKOGMGCJOK(ObscuredVector2.RawEncryptedVector2 DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredVector2.cryptoKey;
			}
			Vector2 result;
			result.x = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.x, JMBKDINHDLO);
			result.y = ObscuredFloat.DLEINJOAHNM(DCCPCBLODIG.y, JMBKDINHDLO);
			return result;
		}

		// Token: 0x06012CE0 RID: 77024 RVA: 0x0081F49A File Offset: 0x0081D69A
		public float GHJPENMGPGN(int CLBPBJGLHEE)
		{
			if (CLBPBJGLHEE == 0)
			{
				return this.x;
			}
			if (CLBPBJGLHEE != 0)
			{
				throw new IndexOutOfRangeException("VIGNETTE_FILMIC");
			}
			return this.GPKLPGHCAHH();
		}

		// Token: 0x06012CE1 RID: 77025 RVA: 0x0081F4C0 File Offset: 0x0081D6C0
		public void BNGGIDBNGIL(float DCCPCBLODIG)
		{
			this.hiddenValue.y = this.FLAJBJBMOPJ(DCCPCBLODIG);
			if (ObscuredCheatingDetector.GKEOAPJKKOH())
			{
				this.fakeValue.x = this.MGHOCIGLBBK(this.hiddenValue.x);
				this.fakeValue.y = DCCPCBLODIG;
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = true;
		}

		// Token: 0x06012CE2 RID: 77026 RVA: 0x0081F520 File Offset: 0x0081D720
		public float MBLPBAEAECN()
		{
			float num = this.OCOLLENJFNG(this.hiddenValue.x);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && Math.Abs(num - this.fakeValue.x) > ObscuredCheatingDetector.BLJNHIFIBDC().vector2Epsilon)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012CE3 RID: 77027 RVA: 0x0081F578 File Offset: 0x0081D778
		private float MGHOCIGLBBK(int LDKMOLEEDIL)
		{
			int jmbkdinhdlo = ObscuredVector2.cryptoKey;
			if (this.currentCryptoKey != ObscuredVector2.cryptoKey)
			{
				jmbkdinhdlo = this.currentCryptoKey;
			}
			return ObscuredFloat.GGPGJEHDJHK(LDKMOLEEDIL, jmbkdinhdlo);
		}

		// Token: 0x06012CE4 RID: 77028 RVA: 0x0081F5A8 File Offset: 0x0081D7A8
		private Vector2 MJFIFINDLAM()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredVector2.cryptoKey;
				this.hiddenValue = ObscuredVector2.HBJHGHOKFDK(ObscuredVector2.zero);
				this.fakeValue = ObscuredVector2.zero;
				this.fakeValueActive = false;
				this.inited = true;
				return ObscuredVector2.zero;
			}
			Vector2 vector;
			vector.x = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.x, this.currentCryptoKey);
			vector.y = ObscuredFloat.DHPGAJEHAFD(this.hiddenValue.y, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && !this.CCJFIMABELM(vector, this.fakeValue))
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return vector;
		}

		// Token: 0x06012CE5 RID: 77029 RVA: 0x0081F65A File Offset: 0x0081D85A
		public static ObscuredVector2.RawEncryptedVector2 HBJHGHOKFDK(Vector2 DCCPCBLODIG)
		{
			return ObscuredVector2.HBJHGHOKFDK(DCCPCBLODIG, 0);
		}

		// Token: 0x06012CE6 RID: 77030 RVA: 0x0081F664 File Offset: 0x0081D864
		public static ObscuredVector2.RawEncryptedVector2 AHJGHFGPPNJ(float OCNGPCPMCPM, float ADMFAEOOOHD, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredVector2.cryptoKey;
			}
			ObscuredVector2.RawEncryptedVector2 result;
			result.x = ObscuredFloat.HBJHGHOKFDK(OCNGPCPMCPM, JMBKDINHDLO);
			result.y = ObscuredFloat.ALHMMAGENAF(ADMFAEOOOHD, JMBKDINHDLO);
			return result;
		}

		// Token: 0x06012CE7 RID: 77031 RVA: 0x0081F698 File Offset: 0x0081D898
		public override string ToString()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012CE8 RID: 77032 RVA: 0x0081F6BC File Offset: 0x0081D8BC
		public override int GetHashCode()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012CE9 RID: 77033 RVA: 0x0081F6E0 File Offset: 0x0081D8E0
		public string JDPKKGOOKDF()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012CEA RID: 77034 RVA: 0x0081F22D File Offset: 0x0081D42D
		public static void ENJDNMEJFIO(int JODDIMFACHN)
		{
			ObscuredVector2.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012CEB RID: 77035 RVA: 0x0081F704 File Offset: 0x0081D904
		public static Vector2 DHPGAJEHAFD(ObscuredVector2.RawEncryptedVector2 DCCPCBLODIG, int JMBKDINHDLO)
		{
			if (JMBKDINHDLO == 0)
			{
				JMBKDINHDLO = ObscuredVector2.cryptoKey;
			}
			Vector2 result;
			result.x = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.x, JMBKDINHDLO);
			result.y = ObscuredFloat.DHPGAJEHAFD(DCCPCBLODIG.y, JMBKDINHDLO);
			return result;
		}

		// Token: 0x06012CEC RID: 77036 RVA: 0x0081F742 File Offset: 0x0081D942
		public static Vector2 GOOIABGKMHK(ObscuredVector2 DCCPCBLODIG)
		{
			return DCCPCBLODIG.MJFIFINDLAM();
		}

		// Token: 0x06012CED RID: 77037 RVA: 0x0081F74C File Offset: 0x0081D94C
		public string FGNNJFJLENH()
		{
			return this.MJFIFINDLAM().ToString();
		}

		// Token: 0x06012CEE RID: 77038 RVA: 0x0081F770 File Offset: 0x0081D970
		public int DOCDAEHCNKH()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012CEF RID: 77039 RVA: 0x0081F794 File Offset: 0x0081D994
		public int OMBPNCLIJGA()
		{
			return this.MJFIFINDLAM().GetHashCode();
		}

		// Token: 0x06012CF0 RID: 77040 RVA: 0x0081F7B8 File Offset: 0x0081D9B8
		public void HKHHJDOPJGK(float DCCPCBLODIG)
		{
			this.hiddenValue.x = this.FLAJBJBMOPJ(DCCPCBLODIG);
			if (ObscuredCheatingDetector.DDNJPGNOAKP())
			{
				this.fakeValue.x = DCCPCBLODIG;
				this.fakeValue.y = this.OCOLLENJFNG(this.hiddenValue.y);
				this.fakeValueActive = true;
				return;
			}
			this.fakeValueActive = false;
		}

		// Token: 0x06012CF1 RID: 77041 RVA: 0x0081F818 File Offset: 0x0081DA18
		private float IBOJIHMEHOB(int LDKMOLEEDIL)
		{
			int jmbkdinhdlo = ObscuredVector2.cryptoKey;
			if (this.currentCryptoKey != ObscuredVector2.cryptoKey)
			{
				jmbkdinhdlo = this.currentCryptoKey;
			}
			return ObscuredFloat.DHPGAJEHAFD(LDKMOLEEDIL, jmbkdinhdlo);
		}

		// Token: 0x06012CF2 RID: 77042 RVA: 0x0081F846 File Offset: 0x0081DA46
		public Vector2 FHADCHOIEKP()
		{
			return this.HMKNGLCANDE();
		}

		// Token: 0x06012CF3 RID: 77043 RVA: 0x0081F84E File Offset: 0x0081DA4E
		private int FLAJBJBMOPJ(float LDKMOLEEDIL)
		{
			return ObscuredFloat.ALHMMAGENAF(LDKMOLEEDIL, ObscuredVector2.cryptoKey);
		}

		// Token: 0x06012CF4 RID: 77044 RVA: 0x0081F85C File Offset: 0x0081DA5C
		private Vector2 HMKNGLCANDE()
		{
			if (!this.inited)
			{
				this.currentCryptoKey = ObscuredVector2.cryptoKey;
				this.hiddenValue = ObscuredVector2.HBJHGHOKFDK(ObscuredVector2.zero);
				this.fakeValue = ObscuredVector2.zero;
				this.fakeValueActive = false;
				this.inited = true;
				return ObscuredVector2.zero;
			}
			Vector2 vector;
			vector.x = ObscuredFloat.GGPGJEHDJHK(this.hiddenValue.x, this.currentCryptoKey);
			vector.y = ObscuredFloat.GGPGJEHDJHK(this.hiddenValue.y, this.currentCryptoKey);
			if (ObscuredCheatingDetector.GOGDGKDDIPG && this.fakeValueActive && !this.CCJFIMABELM(vector, this.fakeValue))
			{
				ObscuredCheatingDetector.LNANLECJDDA().DDINBCFIGNH();
			}
			return vector;
		}

		// Token: 0x06012CF6 RID: 77046 RVA: 0x0081F96D File Offset: 0x0081DB6D
		public void LABEACCDKMD(ObscuredVector2.RawEncryptedVector2 LDKMOLEEDIL)
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

		// Token: 0x06012CF7 RID: 77047 RVA: 0x0081F9A0 File Offset: 0x0081DBA0
		private float OCOLLENJFNG(int LDKMOLEEDIL)
		{
			int jmbkdinhdlo = ObscuredVector2.cryptoKey;
			if (this.currentCryptoKey != ObscuredVector2.cryptoKey)
			{
				jmbkdinhdlo = this.currentCryptoKey;
			}
			return ObscuredFloat.DHPGAJEHAFD(LDKMOLEEDIL, jmbkdinhdlo);
		}

		// Token: 0x06012CF8 RID: 77048 RVA: 0x0081F9CE File Offset: 0x0081DBCE
		public void CKDGMMNHNLF()
		{
			if (this.currentCryptoKey != ObscuredVector2.cryptoKey)
			{
				this.hiddenValue = ObscuredVector2.HAMKOCCHOBN(this.HMKNGLCANDE(), ObscuredVector2.cryptoKey);
				this.currentCryptoKey = ObscuredVector2.cryptoKey;
			}
		}

		// Token: 0x06012CF9 RID: 77049 RVA: 0x0081FA00 File Offset: 0x0081DC00
		public float GEDGMMBKPPN()
		{
			float num = this.IBOJIHMEHOB(this.hiddenValue.y);
			if (ObscuredCheatingDetector.IHLFNHKJJGN() && this.fakeValueActive && Math.Abs(num - this.fakeValue.y) > ObscuredCheatingDetector.BLJNHIFIBDC().vector2Epsilon)
			{
				ObscuredCheatingDetector.ELOBJGIDGCP.DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x1700041A RID: 1050
		public float this[int CLBPBJGLHEE]
		{
			get
			{
				if (CLBPBJGLHEE == 0)
				{
					return this.x;
				}
				if (CLBPBJGLHEE != 1)
				{
					throw new IndexOutOfRangeException("Invalid ObscuredVector2 index!");
				}
				return this.y;
			}
			set
			{
				if (CLBPBJGLHEE == 0)
				{
					this.x = value;
					return;
				}
				if (CLBPBJGLHEE != 1)
				{
					throw new IndexOutOfRangeException("Invalid ObscuredVector2 index!");
				}
				this.y = value;
			}
		}

		// Token: 0x06012CFB RID: 77051 RVA: 0x0081FA7C File Offset: 0x0081DC7C
		public float GPKLPGHCAHH()
		{
			float num = this.MGHOCIGLBBK(this.hiddenValue.y);
			if (ObscuredCheatingDetector.DDNJPGNOAKP() && this.fakeValueActive && Math.Abs(num - this.fakeValue.y) > ObscuredCheatingDetector.BLJNHIFIBDC().vector2Epsilon)
			{
				ObscuredCheatingDetector.BLJNHIFIBDC().DDINBCFIGNH();
			}
			return num;
		}

		// Token: 0x06012CFC RID: 77052 RVA: 0x0081FAD3 File Offset: 0x0081DCD3
		public Vector2 FGHNJDFIJPC()
		{
			return this.MJFIFINDLAM();
		}

		// Token: 0x06012CFD RID: 77053 RVA: 0x0081FADC File Offset: 0x0081DCDC
		public string BHLHEJCILKF(string LJCEDKCLBDB)
		{
			return this.HMKNGLCANDE().ToString(LJCEDKCLBDB);
		}

		// Token: 0x06012CFF RID: 77055 RVA: 0x0081F22D File Offset: 0x0081D42D
		public static void EKGJMGJFGDP(int JODDIMFACHN)
		{
			ObscuredVector2.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x06012D00 RID: 77056 RVA: 0x0081F22D File Offset: 0x0081D42D
		public static void BBOGAEMNJJN(int JODDIMFACHN)
		{
			ObscuredVector2.cryptoKey = JODDIMFACHN;
		}

		// Token: 0x04002674 RID: 9844
		private static int cryptoKey = 120206;

		// Token: 0x04002675 RID: 9845
		private static readonly Vector2 zero = Vector2.zero;

		// Token: 0x04002676 RID: 9846
		[SerializeField]
		private int currentCryptoKey;

		// Token: 0x04002677 RID: 9847
		[SerializeField]
		private ObscuredVector2.RawEncryptedVector2 hiddenValue;

		// Token: 0x04002678 RID: 9848
		[SerializeField]
		private bool inited;

		// Token: 0x04002679 RID: 9849
		[SerializeField]
		private Vector2 fakeValue;

		// Token: 0x0400267A RID: 9850
		[SerializeField]
		private bool fakeValueActive;

		// Token: 0x02000593 RID: 1427
		[Serializable]
		public struct RawEncryptedVector2
		{
			// Token: 0x0400267B RID: 9851
			public int x;

			// Token: 0x0400267C RID: 9852
			public int y;
		}
	}
}
