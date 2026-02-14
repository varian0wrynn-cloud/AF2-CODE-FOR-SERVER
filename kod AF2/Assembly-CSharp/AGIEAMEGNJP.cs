using System;
using UnityEngine;

// Token: 0x02000097 RID: 151
public static class AGIEAMEGNJP
{
	// Token: 0x0600206A RID: 8298 RVA: 0x000F5DE4 File Offset: 0x000F3FE4
	public static int GDFNMPDNEGA(DPFNGGGKNDJ MNNMDGCANBI)
	{
		if (MNNMDGCANBI == DPFNGGGKNDJ.Custom)
		{
			return 0;
		}
		int num = Mathf.NextPowerOfTwo((int)((float)Mathf.Max(Screen.width, Screen.height) * 1.9f));
		int a = 2048;
		if (SystemInfo.graphicsMemorySize >= 512)
		{
			a = 4096;
		}
		num = Mathf.Min(a, num);
		switch (MNNMDGCANBI)
		{
		case DPFNGGGKNDJ.LowResolution:
			num /= 4;
			break;
		case DPFNGGGKNDJ.MediumResolution:
			num /= 2;
			break;
		case DPFNGGGKNDJ.VeryHighResolution:
			num *= 2;
			break;
		}
		return Mathf.Min(a, num);
	}

	// Token: 0x0600206B RID: 8299 RVA: 0x000F5E65 File Offset: 0x000F4065
	public static float ILFFKFEIPOG(float MNNMDGCANBI, float PEMAEDKONON)
	{
		return PEMAEDKONON * 2f / MNNMDGCANBI;
	}

	// Token: 0x0600206C RID: 8300 RVA: 0x000F5E70 File Offset: 0x000F4070
	public static Matrix4x4 JIAGAFDEGMP(Rect OCHCODJIPHJ)
	{
		return Matrix4x4.TRS(new Vector3(OCHCODJIPHJ.width * 0.5f + OCHCODJIPHJ.x, OCHCODJIPHJ.height * 0.5f + OCHCODJIPHJ.y, 0f), Quaternion.identity, new Vector3(OCHCODJIPHJ.width * 0.5f, OCHCODJIPHJ.height * 0.5f, 1f));
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x000F5EDF File Offset: 0x000F40DF
	public static void IGLCHAAHILP(ref Matrix4x4 BBBIBODABBK, float ANPCCJBHPNE)
	{
		BBBIBODABBK.SetRow(2, new Vector4(0f, 0f, -1f / ANPCCJBHPNE, 0f));
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x000F5F03 File Offset: 0x000F4103
	public static Matrix4x4 IGLCHAAHILP(Matrix4x4 BBBIBODABBK, float ANPCCJBHPNE)
	{
		AGIEAMEGNJP.IGLCHAAHILP(ref BBBIBODABBK, ANPCCJBHPNE);
		return BBBIBODABBK;
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x000F5F0E File Offset: 0x000F410E
	public static Vector2 HIOCFNMBINI(Vector3 ONPHLHKAGFP)
	{
		return new Vector2(ONPHLHKAGFP.x, ONPHLHKAGFP.y);
	}

	// Token: 0x06002070 RID: 8304 RVA: 0x000F5F21 File Offset: 0x000F4121
	public static Vector2 HIOCFNMBINI(Vector4 ONPHLHKAGFP)
	{
		return new Vector2(ONPHLHKAGFP.x, ONPHLHKAGFP.y);
	}

	// Token: 0x06002071 RID: 8305 RVA: 0x000F5F34 File Offset: 0x000F4134
	public static Vector3 LJJAIHIEDND(Vector4 ONPHLHKAGFP)
	{
		return new Vector3(ONPHLHKAGFP.x, ONPHLHKAGFP.y, ONPHLHKAGFP.z);
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x000F5F4D File Offset: 0x000F414D
	public static Vector3 CJJEBFEBNNC(Vector2 ONPHLHKAGFP)
	{
		return new Vector3(ONPHLHKAGFP.x, ONPHLHKAGFP.y, 0f);
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x000F5F65 File Offset: 0x000F4165
	public static Vector3 CJJEBFEBNNC(Vector3 ONPHLHKAGFP)
	{
		return new Vector3(ONPHLHKAGFP.x, ONPHLHKAGFP.y, 0f);
	}

	// Token: 0x06002074 RID: 8308 RVA: 0x000F5F7D File Offset: 0x000F417D
	public static Vector3 CJJEBFEBNNC(Vector4 ONPHLHKAGFP)
	{
		return new Vector3(ONPHLHKAGFP.x, ONPHLHKAGFP.y, 0f);
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x000F5F95 File Offset: 0x000F4195
	public static Vector4 HMBAHIOHNOJ(Vector2 ONPHLHKAGFP)
	{
		return new Vector4(ONPHLHKAGFP.x, ONPHLHKAGFP.y, 0f, 0f);
	}

	// Token: 0x06002076 RID: 8310 RVA: 0x000F5FB2 File Offset: 0x000F41B2
	public static Vector4 HMBAHIOHNOJ(Vector3 ONPHLHKAGFP)
	{
		return new Vector4(ONPHLHKAGFP.x, ONPHLHKAGFP.y, 0f, 0f);
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x000F5FCF File Offset: 0x000F41CF
	public static Vector4 HMBAHIOHNOJ(Vector4 ONPHLHKAGFP)
	{
		return new Vector4(ONPHLHKAGFP.x, ONPHLHKAGFP.y, 0f, 0f);
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x000F5FEC File Offset: 0x000F41EC
	public static Vector4 MFOKANNCADD(Vector3 ONPHLHKAGFP)
	{
		return new Vector4(ONPHLHKAGFP.x, ONPHLHKAGFP.y, ONPHLHKAGFP.z, 0f);
	}

	// Token: 0x06002079 RID: 8313 RVA: 0x000F600A File Offset: 0x000F420A
	public static Vector4 MFOKANNCADD(Vector4 ONPHLHKAGFP)
	{
		return new Vector4(ONPHLHKAGFP.x, ONPHLHKAGFP.y, ONPHLHKAGFP.z, 0f);
	}

	// Token: 0x0600207A RID: 8314 RVA: 0x000F6028 File Offset: 0x000F4228
	public static int KKBKGPPHBHC(ILPBNIJPPGA MNNMDGCANBI)
	{
		switch (MNNMDGCANBI)
		{
		case ILPBNIJPPGA.Full:
			return 1;
		case ILPBNIJPPGA.Half:
			return 2;
		case ILPBNIJPPGA.Third:
			return 3;
		case ILPBNIJPPGA.Quarter:
			return 4;
		case ILPBNIJPPGA.Fifth:
			return 5;
		case ILPBNIJPPGA.Sixth:
			return 6;
		case ILPBNIJPPGA.Seventh:
			return 7;
		case ILPBNIJPPGA.Eighth:
			return 8;
		default:
			return 1;
		}
	}

	// Token: 0x0600207B RID: 8315 RVA: 0x000F6063 File Offset: 0x000F4263
	public static float KEJDOOOLMGL(MEFKFFFFOGB LKLFHDACGMN)
	{
		switch (LKLFHDACGMN)
		{
		case MEFKFFFFOGB.PCF2x2:
			return 1.414214f;
		case MEFKFFFFOGB.PCF3x3:
			return 2.12132f;
		case MEFKFFFFOGB.PCF4x4:
			return 2.828427f;
		}
		return 0.7071068f;
	}

	// Token: 0x0600207C RID: 8316 RVA: 0x000F6094 File Offset: 0x000F4294
	public static float GHIFPNHBHGE(float JKJCDBEAPAJ, float IKDOAIAGEAB)
	{
		return Mathf.Floor(JKJCDBEAPAJ / IKDOAIAGEAB + 0.5f) * IKDOAIAGEAB;
	}

	// Token: 0x0600207D RID: 8317 RVA: 0x000F60A8 File Offset: 0x000F42A8
	public static float FOLADPBFABK(float JKJCDBEAPAJ, float IKDOAIAGEAB, float OEMFNBAEPMK)
	{
		float num = AGIEAMEGNJP.GHIFPNHBHGE(JKJCDBEAPAJ, IKDOAIAGEAB);
		if (Mathf.Abs(num - JKJCDBEAPAJ) * 4f < Mathf.Abs(OEMFNBAEPMK - JKJCDBEAPAJ))
		{
			return num;
		}
		return OEMFNBAEPMK;
	}

	// Token: 0x0600207E RID: 8318 RVA: 0x000F60D8 File Offset: 0x000F42D8
	public static float GHIFPNHBHGE(float JKJCDBEAPAJ, int MNNMDGCANBI)
	{
		return AGIEAMEGNJP.GHIFPNHBHGE(JKJCDBEAPAJ, 1f / (float)MNNMDGCANBI);
	}

	// Token: 0x0600207F RID: 8319 RVA: 0x000F60E8 File Offset: 0x000F42E8
	public static float FOLADPBFABK(float JKJCDBEAPAJ, int MNNMDGCANBI, float OEMFNBAEPMK)
	{
		return AGIEAMEGNJP.FOLADPBFABK(JKJCDBEAPAJ, 1f / (float)MNNMDGCANBI, OEMFNBAEPMK);
	}

	// Token: 0x06002080 RID: 8320 RVA: 0x000F60FC File Offset: 0x000F42FC
	public static float GDEEFAPALEL(Camera PMMEFNKFJIA)
	{
		Ray ray = PMMEFNKFJIA.ViewportPointToRay(new Vector3(0f, 0f, 0f));
		return PMMEFNKFJIA.transform.InverseTransformDirection(ray.direction).z;
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x000F613C File Offset: 0x000F433C
	public static float FGGABHFBMKI(Vector3 PFJKGIJGDBH, Vector3[] CBJBGGAOODC)
	{
		float num = 0f;
		for (int i = 0; i < CBJBGGAOODC.Length; i++)
		{
			float sqrMagnitude = (CBJBGGAOODC[i] - PFJKGIJGDBH).sqrMagnitude;
			if (sqrMagnitude > num)
			{
				num = sqrMagnitude;
			}
		}
		return num;
	}

	// Token: 0x06002082 RID: 8322 RVA: 0x000F617C File Offset: 0x000F437C
	public static AGIEAMEGNJP.DOMJMOILBDJ GIIACLLKPHP(Camera LBCHLCGOCOD, float NGHBEDKDJLP, float ANPCCJBHPNE, bool EKIOPIMFAPK, float HLPDGICLOIJ, float HGIIOFEGBFC = 0.01f, int LHDIKBHBNBN = 100)
	{
		float num = AGIEAMEGNJP.GDEEFAPALEL(LBCHLCGOCOD);
		float z = EKIOPIMFAPK ? (NGHBEDKDJLP * num) : NGHBEDKDJLP;
		float z2 = EKIOPIMFAPK ? (ANPCCJBHPNE * num) : ANPCCJBHPNE;
		Vector3 a = LBCHLCGOCOD.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, NGHBEDKDJLP));
		Vector3 b = LBCHLCGOCOD.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, z2));
		Vector3 vector = LBCHLCGOCOD.ViewportToWorldPoint(new Vector3(0f, 0f, z));
		Vector3 vector2 = LBCHLCGOCOD.ViewportToWorldPoint(new Vector3(1f, 1f, ANPCCJBHPNE));
		Vector3 vector3 = EKIOPIMFAPK ? LBCHLCGOCOD.ViewportToWorldPoint(new Vector3(1f, 1f, z2)) : vector2;
		AGIEAMEGNJP.EHBENPAHLGN[0] = vector;
		AGIEAMEGNJP.EHBENPAHLGN[1] = vector3;
		float num2 = float.MaxValue;
		Vector3 pfjkgijgdbh = Vector3.zero;
		float num3 = 0f;
		float num4 = 0.2f;
		for (int i = 0; i < LHDIKBHBNBN; i++)
		{
			Vector3 vector4 = Vector3.Lerp(a, b, num3);
			float num5 = AGIEAMEGNJP.FGGABHFBMKI(vector4, AGIEAMEGNJP.EHBENPAHLGN);
			if (num5 < num2)
			{
				num2 = num5;
				pfjkgijgdbh = vector4;
			}
			else
			{
				num4 *= -0.5f;
				if (Mathf.Abs(num4) < HGIIOFEGBFC)
				{
					break;
				}
			}
			num3 += num4;
		}
		return new AGIEAMEGNJP.DOMJMOILBDJ
		{
			PFJKGIJGDBH = pfjkgijgdbh,
			AEIAFIIMHEL = Mathf.Sqrt(num2) + HLPDGICLOIJ
		};
	}

	// Token: 0x06002083 RID: 8323 RVA: 0x000F62D4 File Offset: 0x000F44D4
	public static void PAHAACFAHPK(Light PBMKOGEGDGG, Camera AFENJJHIMHH, Camera PMPDLMABPEJ, float HJHCCAGACBE, float FNJJFMPHDAJ, float APDLENCHHEN, float CCDHMAMMAGD, int JCPMDICANHD, ref AGIEAMEGNJP.DOMJMOILBDJ PEKBNDJPMFD, ref AGIEAMEGNJP.AEEKALJNCCL ABFABJFFNDL)
	{
		AGIEAMEGNJP.DOMJMOILBDJ domjmoilbdj = default(AGIEAMEGNJP.DOMJMOILBDJ);
		if (Sunshine.Instance.GMNIFMPBILE)
		{
			APDLENCHHEN = PMPDLMABPEJ.farClipPlane;
			domjmoilbdj = Sunshine.Instance.EKNNFKILDEO;
		}
		else
		{
			domjmoilbdj = AGIEAMEGNJP.GIIACLLKPHP(PMPDLMABPEJ, HJHCCAGACBE, FNJJFMPHDAJ, true, CCDHMAMMAGD, 0.01f, 20);
		}
		float num = AGIEAMEGNJP.FOLADPBFABK(domjmoilbdj.AEIAFIIMHEL, 100, ABFABJFFNDL.ELDCMJLHHBK);
		ABFABJFFNDL.ELDCMJLHHBK = num;
		float num2 = num * 2f;
		AFENJJHIMHH.aspect = 1f;
		AFENJJHIMHH.orthographic = true;
		AFENJJHIMHH.nearClipPlane = PMPDLMABPEJ.nearClipPlane;
		AFENJJHIMHH.farClipPlane = PEKBNDJPMFD.AEIAFIIMHEL * 2f + APDLENCHHEN + AFENJJHIMHH.nearClipPlane;
		AFENJJHIMHH.orthographicSize = num2 * 0.5f;
		AFENJJHIMHH.transform.rotation = Quaternion.LookRotation(PBMKOGEGDGG.transform.forward);
		AFENJJHIMHH.transform.position = domjmoilbdj.PFJKGIJGDBH;
		Vector3 vector = AFENJJHIMHH.transform.InverseTransformPoint(Vector3.zero);
		float ikdoaiageab = num2 / (float)JCPMDICANHD;
		vector.x = AGIEAMEGNJP.FOLADPBFABK(vector.x, ikdoaiageab, ABFABJFFNDL.OHICOEHEJHO.x);
		vector.y = AGIEAMEGNJP.FOLADPBFABK(vector.y, ikdoaiageab, ABFABJFFNDL.OHICOEHEJHO.y);
		ABFABJFFNDL.OHICOEHEJHO = vector;
		AFENJJHIMHH.transform.position -= AFENJJHIMHH.transform.TransformPoint(vector);
		Vector3 vector2 = AFENJJHIMHH.transform.InverseTransformPoint(PEKBNDJPMFD.PFJKGIJGDBH);
		AFENJJHIMHH.transform.position += AFENJJHIMHH.transform.forward * (vector2.z - (PEKBNDJPMFD.AEIAFIIMHEL + AFENJJHIMHH.nearClipPlane + (Sunshine.Instance.GMNIFMPBILE ? 0f : APDLENCHHEN)));
	}

	// Token: 0x06002084 RID: 8324 RVA: 0x000F649F File Offset: 0x000F469F
	public static void NODBGEOENGP(ref Vector4 BDJDLDAEDLI, ref Rect OCHCODJIPHJ)
	{
		BDJDLDAEDLI.x = Mathf.Lerp(OCHCODJIPHJ.xMin, OCHCODJIPHJ.xMax, BDJDLDAEDLI.x);
		BDJDLDAEDLI.y = Mathf.Lerp(OCHCODJIPHJ.yMin, OCHCODJIPHJ.yMax, BDJDLDAEDLI.y);
	}

	// Token: 0x06002085 RID: 8325 RVA: 0x000F64DB File Offset: 0x000F46DB
	public static void IJBPJGDAEHO(ref Vector4 EADJGPLPEIO, ref Rect OCHCODJIPHJ)
	{
		EADJGPLPEIO.x *= OCHCODJIPHJ.width;
		EADJGPLPEIO.y *= OCHCODJIPHJ.height;
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x000F64FD File Offset: 0x000F46FD
	public static LayerMask CJAKJAHCIJB(LayerMask CBFFOOKAIAK, LayerMask IMLAKKIFNIE)
	{
		return CBFFOOKAIAK & ~IMLAKKIFNIE;
	}

	// Token: 0x040003E1 RID: 993
	public static readonly Matrix4x4 DHKPIHFCBAO = Matrix4x4.TRS(new Vector3(0.5f, 0.5f, 0f), Quaternion.identity, new Vector3(0.5f, 0.5f, 1f));

	// Token: 0x040003E2 RID: 994
	public static readonly Rect[][] CGOBAJKMGDD = new Rect[][]
	{
		new Rect[]
		{
			new Rect(0f, 0f, 1f, 1f)
		},
		new Rect[]
		{
			new Rect(0f, 0f, 1f, 0.5f),
			new Rect(0f, 0.5f, 1f, 0.5f)
		},
		new Rect[]
		{
			new Rect(0f, 0f, 0.5f, 1f),
			new Rect(0.5f, 0f, 0.5f, 0.5f),
			new Rect(0.5f, 0.5f, 0.5f, 0.5f)
		},
		new Rect[]
		{
			new Rect(0f, 0f, 0.5f, 0.5f),
			new Rect(0f, 0.5f, 0.5f, 0.5f),
			new Rect(0.5f, 0f, 0.5f, 0.5f),
			new Rect(0.5f, 0.5f, 0.5f, 0.5f)
		}
	};

	// Token: 0x040003E3 RID: 995
	private static Vector3[] EHBENPAHLGN = new Vector3[2];

	// Token: 0x02000098 RID: 152
	public struct DOMJMOILBDJ
	{
		// Token: 0x040003E4 RID: 996
		public Vector3 PFJKGIJGDBH;

		// Token: 0x040003E5 RID: 997
		public float AEIAFIIMHEL;
	}

	// Token: 0x02000099 RID: 153
	public struct AEEKALJNCCL
	{
		// Token: 0x040003E6 RID: 998
		public float ELDCMJLHHBK;

		// Token: 0x040003E7 RID: 999
		public Vector3 OHICOEHEJHO;
	}
}
