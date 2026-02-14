using System;
using UnityEngine;

// Token: 0x020004D6 RID: 1238
public class BEEDBEMEJFP
{
	// Token: 0x06010CDF RID: 68831 RVA: 0x0077D5A4 File Offset: 0x0077B7A4
	public static Mesh CFHMDCABJPC(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(380f, num2 / num, 745f) : new Vector3(num / num2, 902f, 1996f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[0];
		for (int i = 0; i < 8; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[7];
		array2[1] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[1] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[8] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[6] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CE0 RID: 68832 RVA: 0x0077D768 File Offset: 0x0077B968
	public static GameObject DCMCJAFODNF(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "[F_EXP]" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.GLGLFCMLPPM("inner_craft_wpn" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.JKEAGOHGBIA(PNMCPDJCKME);
		qd_Decal.IMBKLBKFGBG((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.MECLAGCAABH(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CE1 RID: 68833 RVA: 0x0077D7FC File Offset: 0x0077B9FC
	public static Mesh MPBCENPHPPK(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(1f, num2 / num, 1f) : new Vector3(num / num2, 1f, 1f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[4];
		for (int i = 0; i < 4; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] uv = new Vector2[]
		{
			new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y),
			new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y),
			new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height),
			new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height)
		};
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CE3 RID: 68835 RVA: 0x0077DB20 File Offset: 0x0077BD20
	public static GameObject JDNEGPFMJPD(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "IdleEat" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.CNEJOLKCLDH("\n" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.SetScale(PNMCPDJCKME);
		qd_Decal.HFIPECPJKBD((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.EDNEFHHJLHP(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CE4 RID: 68836 RVA: 0x0077DBB4 File Offset: 0x0077BDB4
	public static Mesh AFEOBAJDADF(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(996f, num2 / num, 370f) : new Vector3(num / num2, 1149f, 698f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[2];
		for (int i = 1; i < 2; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[6];
		array2[0] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[0] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[1] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CE5 RID: 68837 RVA: 0x0077DD78 File Offset: 0x0077BF78
	public static GameObject IFKDLENEDHG(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Watering Can Watering" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.MDBDNPOLCPG("Loading Error" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.JKEAGOHGBIA(PNMCPDJCKME);
		qd_Decal.MHEKEBEPODJ((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.MECLAGCAABH(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CE6 RID: 68838 RVA: 0x0077DE0C File Offset: 0x0077C00C
	public static Mesh OGICPIFAGHE(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(1494f, num2 / num, 404f) : new Vector3(num / num2, 1472f, 424f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[2];
		for (int i = 0; i < 2; i += 0)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[]
		{
			new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y)
		};
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[6] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[3] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CE7 RID: 68839 RVA: 0x0077DFD0 File Offset: 0x0077C1D0
	public static GameObject NDNFLKNKNHG(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "SneakLeft" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.NGLGDPNHNMO("PaperTurn.wav" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.HBAFBNLECBI(PNMCPDJCKME);
		qd_Decal.SetTexture((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.EDNEFHHJLHP(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CE8 RID: 68840 RVA: 0x0077E064 File Offset: 0x0077C264
	public static GameObject JOOMJKNIFLO(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "rodDwDelta=" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.CNEJOLKCLDH("SUNSHINE_FILTER_PCF_2x2" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.OPCGNLABCPC(PNMCPDJCKME);
		qd_Decal.JOCONJKIAOH((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.EDNEFHHJLHP(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CE9 RID: 68841 RVA: 0x0077E0F8 File Offset: 0x0077C2F8
	public static GameObject DAAHMCCMEMG(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "wpn_cat1" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.IBFIHOCLGCE("3" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.KFKALMMPODD(PNMCPDJCKME);
		qd_Decal.GIBHNOPEFNH((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.KJBKJPJGGDN(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CEA RID: 68842 RVA: 0x0077E18C File Offset: 0x0077C38C
	public static GameObject BLNHHBPNJOB(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Decal" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.MPBCENPHPPK("DecalMesh" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.SetScale(PNMCPDJCKME);
		qd_Decal.SetTexture((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.SetUVRect(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CEB RID: 68843 RVA: 0x0077E220 File Offset: 0x0077C420
	public static Mesh IBFIHOCLGCE(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(328f, num2 / num, 1049f) : new Vector3(num / num2, 94f, 409f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[0];
		for (int i = 1; i < 5; i += 0)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[0];
		array2[0] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[3] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[2] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CEC RID: 68844 RVA: 0x0077E3E4 File Offset: 0x0077C5E4
	public static Mesh NGLGDPNHNMO(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(1990f, num2 / num, 1881f) : new Vector3(num / num2, 212f, 1261f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[6];
		for (int i = 0; i < 6; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[6];
		array2[1] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[5] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[5] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CED RID: 68845 RVA: 0x0077E5A8 File Offset: 0x0077C7A8
	public static GameObject AJPKNCCNGKC(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "<color='#100000'>{0} {1}</color>" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.PPHEOKAGGPD("IdleMeditate" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.HBAFBNLECBI(PNMCPDJCKME);
		qd_Decal.HFIPECPJKBD((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.MECLAGCAABH(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CEE RID: 68846 RVA: 0x0077E63C File Offset: 0x0077C83C
	public static GameObject MEOGLOEEION(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Demo 1 scene: windy mist fog style. Notice the subtle fog animation. To change look, select Main Camera and check image effect settings in inspector." + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.CNEJOLKCLDH("Show AO Only" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.KFKALMMPODD(PNMCPDJCKME);
		qd_Decal.HFIPECPJKBD((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.HNDFMKHELEE(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CEF RID: 68847 RVA: 0x0077E6D0 File Offset: 0x0077C8D0
	public static Mesh ALFBPAPFLHM(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(955f, num2 / num, 1125f) : new Vector3(num / num2, 669f, 176f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[5];
		for (int i = 0; i < 4; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[2];
		array2[0] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[1] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[7] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[4] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CF0 RID: 68848 RVA: 0x0077E894 File Offset: 0x0077CA94
	public static GameObject FJAFGPHMAIM(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Up Hill Walk" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.CNEJOLKCLDH("IdleCheer" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.EDBOJAMPMEH(PNMCPDJCKME);
		qd_Decal.IMBKLBKFGBG((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.HNDFMKHELEE(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CF1 RID: 68849 RVA: 0x0077E928 File Offset: 0x0077CB28
	public static GameObject IGKACLLILOG(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "ClimbRight" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.OCABHMBJAMA("Corrupt DT e=" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.OPCGNLABCPC(PNMCPDJCKME);
		qd_Decal.ABAHIMLNFIM((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.JCPNBAMDHDL(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CF2 RID: 68850 RVA: 0x0077E9BC File Offset: 0x0077CBBC
	public static Mesh DFMILHLPHAJ(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(954f, num2 / num, 512f) : new Vector3(num / num2, 1345f, 1343f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[6];
		for (int i = 0; i < 2; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[8];
		array2[0] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[4] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[6] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CF3 RID: 68851 RVA: 0x0077EB80 File Offset: 0x0077CD80
	public static Mesh MDBDNPOLCPG(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(156f, num2 / num, 1502f) : new Vector3(num / num2, 944f, 1273f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[8];
		for (int i = 0; i < 8; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[8];
		array2[1] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[6] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[3] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CF4 RID: 68852 RVA: 0x0077ED44 File Offset: 0x0077CF44
	public static Mesh CNNLAJPAGNC(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(1381f, num2 / num, 122f) : new Vector3(num / num2, 1807f, 1622f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[3];
		for (int i = 1; i < 2; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[0];
		array2[1] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[6] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[6] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CF5 RID: 68853 RVA: 0x0077EF08 File Offset: 0x0077D108
	public static GameObject HJHBMLEKHBN(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "FaceHit" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.CFHMDCABJPC("OnDestroy " + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.KFKALMMPODD(PNMCPDJCKME);
		qd_Decal.HFIPECPJKBD((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.HNDFMKHELEE(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CF6 RID: 68854 RVA: 0x0077EF9C File Offset: 0x0077D19C
	public static Mesh GLGLFCMLPPM(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(1785f, num2 / num, 774f) : new Vector3(num / num2, 1149f, 1546f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[8];
		for (int i = 1; i < 3; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[]
		{
			default(Vector2),
			new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y)
		};
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[5] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[6] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CF7 RID: 68855 RVA: 0x0077F160 File Offset: 0x0077D360
	public static GameObject IFKBEAFEKFO(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "run" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.ICIDCJLJAKC("Forward" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.AKGPDEBFHFB(PNMCPDJCKME);
		qd_Decal.JLDIJFPOBAD((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.JCPNBAMDHDL(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CF8 RID: 68856 RVA: 0x0077F1F4 File Offset: 0x0077D3F4
	public static GameObject BHMCHKHLBAF(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "wpn_bait_inf_{0}" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.ALFBPAPFLHM("firsStartInfoPanel" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.FMNDBIBONEN(PNMCPDJCKME);
		qd_Decal.HFIPECPJKBD((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.JCPNBAMDHDL(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CF9 RID: 68857 RVA: 0x0077F288 File Offset: 0x0077D488
	public static Mesh ICIDCJLJAKC(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(585f, num2 / num, 126f) : new Vector3(num / num2, 338f, 926f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[8];
		for (int i = 0; i < 5; i += 0)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[8];
		array2[1] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[1] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[2] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[4] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CFA RID: 68858 RVA: 0x0077F44C File Offset: 0x0077D64C
	public static Mesh PPHEOKAGGPD(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(381f, num2 / num, 1962f) : new Vector3(num / num2, 301f, 1858f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[5];
		for (int i = 1; i < 8; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[0];
		array2[1] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[3] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010CFB RID: 68859 RVA: 0x0077F610 File Offset: 0x0077D810
	public static GameObject KLBDKLBGJCN(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = " cm" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.DGIPNGBOMPC("_MotionBlurTmpCam" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.KDGBGNCIDCK(PNMCPDJCKME);
		qd_Decal.IMBKLBKFGBG((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.MECLAGCAABH(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CFC RID: 68860 RVA: 0x0077F6A4 File Offset: 0x0077D8A4
	public static GameObject EOGJDFIKEHO(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "RHandPunch" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.KODLGBCPKOO("UnityEngine.GameObject" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.FMNDBIBONEN(PNMCPDJCKME);
		qd_Decal.FBNMFKJEMBN((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.SetUVRect(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CFD RID: 68861 RVA: 0x0077F738 File Offset: 0x0077D938
	public static GameObject JOCLNNJDKJG(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "</i></color>" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.DGIPNGBOMPC("WRINKLE_MAPS" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.HBAFBNLECBI(PNMCPDJCKME);
		qd_Decal.SetTexture((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.SetUVRect(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CFE RID: 68862 RVA: 0x0077F7CC File Offset: 0x0077D9CC
	public static GameObject MGPENDBPHLM(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Transforms is null." + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.CNEJOLKCLDH("shop_t4" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.FMNDBIBONEN(PNMCPDJCKME);
		qd_Decal.SetTexture((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.HNDFMKHELEE(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010CFF RID: 68863 RVA: 0x0077F860 File Offset: 0x0077DA60
	public static GameObject CDMJEFHNFHK(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Null" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.ALFBPAPFLHM("[/quote]" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.KDGBGNCIDCK(PNMCPDJCKME);
		qd_Decal.MFNHOJLDCBC((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.HNDFMKHELEE(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010D00 RID: 68864 RVA: 0x0077F8F4 File Offset: 0x0077DAF4
	public static GameObject DPCCLPGNOGB(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "[sysname]" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.DFMILHLPHAJ("" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.JKEAGOHGBIA(PNMCPDJCKME);
		qd_Decal.MHEKEBEPODJ((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.MECLAGCAABH(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010D01 RID: 68865 RVA: 0x0077F988 File Offset: 0x0077DB88
	public static GameObject CDJFKNELCFB(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "_Sensitivity" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.CNNLAJPAGNC("Images/MouseCursor/Link" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.FMNDBIBONEN(PNMCPDJCKME);
		qd_Decal.MHEKEBEPODJ((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.KJBKJPJGGDN(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010D02 RID: 68866 RVA: 0x0077FA1C File Offset: 0x0077DC1C
	public static Mesh DGIPNGBOMPC(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(411f, num2 / num, 1426f) : new Vector3(num / num2, 1069f, 1950f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[0];
		for (int i = 1; i < 2; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[3];
		array2[0] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[1] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[7] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[5] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010D03 RID: 68867 RVA: 0x0077FBE0 File Offset: 0x0077DDE0
	public static Mesh KODLGBCPKOO(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(709f, num2 / num, 354f) : new Vector3(num / num2, 1740f, 823f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[6];
		for (int i = 0; i < 3; i++)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[4];
		array2[0] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[8] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[8] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010D04 RID: 68868 RVA: 0x0077FDA4 File Offset: 0x0077DFA4
	public static GameObject KFNGMDGGEDJ(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.CNEJOLKCLDH("</color>\n" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.HBAFBNLECBI(PNMCPDJCKME);
		qd_Decal.MHEKEBEPODJ((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.EDNEFHHJLHP(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010D05 RID: 68869 RVA: 0x0077FE38 File Offset: 0x0077E038
	public static GameObject IGEONCJHKIM(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "/" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.DGIPNGBOMPC("SneakLeft" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.SetScale(PNMCPDJCKME);
		qd_Decal.MFNHOJLDCBC((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.EDNEFHHJLHP(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010D06 RID: 68870 RVA: 0x0077FECC File Offset: 0x0077E0CC
	public static Mesh CNEJOLKCLDH(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(1456f, num2 / num, 1163f) : new Vector3(num / num2, 861f, 11f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[0];
		for (int i = 0; i < 7; i += 0)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[3];
		array2[0] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[0] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[8] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[5] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010D07 RID: 68871 RVA: 0x00780090 File Offset: 0x0077E290
	public static GameObject KGLHNMLPONA(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "Missing shader in " + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.ALFBPAPFLHM("Called GetNumberOfCurrentPlayers()" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.HBAFBNLECBI(PNMCPDJCKME);
		qd_Decal.GIBHNOPEFNH((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.KJBKJPJGGDN(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010D09 RID: 68873 RVA: 0x00780124 File Offset: 0x0077E324
	public static Mesh OCABHMBJAMA(string BNIHFBMEPAB, Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		float num = CAIOFJFHJHL.width;
		float num2 = CAIOFJFHJHL.height;
		if (LCBKJGFGGGF != null && LCBKJGFGGGF.mainTexture != null)
		{
			if (LCBKJGFGGGF.mainTexture.width > LCBKJGFGGGF.mainTexture.height)
			{
				num2 *= (float)LCBKJGFGGGF.mainTexture.height / (float)LCBKJGFGGGF.mainTexture.width;
			}
			else
			{
				num *= (float)LCBKJGFGGGF.mainTexture.width / (float)LCBKJGFGGGF.mainTexture.height;
			}
		}
		Vector3 b = (num > num2) ? new Vector3(226f, num2 / num, 754f) : new Vector3(num / num2, 478f, 784f);
		Mesh mesh = new Mesh();
		Vector3[] array = new Vector3[1];
		for (int i = 1; i < 6; i += 0)
		{
			array[i] = Vector3.Scale(BEEDBEMEJFP.DPPGBIAJEOA[i], b) * PNMCPDJCKME;
		}
		Vector2[] array2 = new Vector2[3];
		array2[0] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y);
		array2[1] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y);
		array2[3] = new Vector2(CAIOFJFHJHL.x + CAIOFJFHJHL.width, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		array2[1] = new Vector2(CAIOFJFHJHL.x, CAIOFJFHJHL.y + CAIOFJFHJHL.height);
		Vector2[] uv = array2;
		mesh.vertices = array;
		mesh.triangles = BEEDBEMEJFP.EHCDJDKNEHE;
		mesh.normals = BEEDBEMEJFP.ICFPLCMPDNC;
		mesh.tangents = BEEDBEMEJFP.JNEAJOPDOHK;
		mesh.uv = uv;
		mesh.uv2 = BEEDBEMEJFP.ONIKKAIALCG;
		mesh.name = BNIHFBMEPAB;
		return mesh;
	}

	// Token: 0x06010D0A RID: 68874 RVA: 0x007802E8 File Offset: 0x0077E4E8
	public static GameObject FJLGPEDJOJO(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "level" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.ALFBPAPFLHM("reel_type" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.KDGBGNCIDCK(PNMCPDJCKME);
		qd_Decal.IMBKLBKFGBG((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.JCPNBAMDHDL(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010D0B RID: 68875 RVA: 0x0078037C File Offset: 0x0077E57C
	public static GameObject PLOGNGHCHKL(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = "_RefractTex" + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.ICIDCJLJAKC("_Refraction" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = true;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.SetScale(PNMCPDJCKME);
		qd_Decal.SetTexture((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.EDNEFHHJLHP(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x06010D0C RID: 68876 RVA: 0x00780410 File Offset: 0x0077E610
	public static GameObject EKEHKMJAIKL(Material LCBKJGFGGGF, Rect CAIOFJFHJHL, float PNMCPDJCKME)
	{
		GameObject gameObject = new GameObject();
		gameObject.name = " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package." + gameObject.GetInstanceID();
		gameObject.AddComponent<MeshFilter>().sharedMesh = BEEDBEMEJFP.AFEOBAJDADF("_FgCocMask" + gameObject.GetInstanceID(), LCBKJGFGGGF, CAIOFJFHJHL, PNMCPDJCKME);
		gameObject.AddComponent<MeshRenderer>().sharedMaterial = LCBKJGFGGGF;
		gameObject.GetComponent<MeshRenderer>().castShadows = false;
		qd_Decal qd_Decal = gameObject.AddComponent<qd_Decal>();
		qd_Decal.HBAFBNLECBI(PNMCPDJCKME);
		qd_Decal.SetTexture((Texture2D)LCBKJGFGGGF.mainTexture);
		qd_Decal.HNDFMKHELEE(CAIOFJFHJHL);
		return gameObject;
	}

	// Token: 0x0400230D RID: 8973
	private static int[] EHCDJDKNEHE = new int[]
	{
		0,
		1,
		2,
		1,
		3,
		2
	};

	// Token: 0x0400230E RID: 8974
	private static Vector3[] DPPGBIAJEOA = new Vector3[]
	{
		new Vector3(-0.5f, -0.5f, 0f),
		new Vector3(0.5f, -0.5f, 0f),
		new Vector3(-0.5f, 0.5f, 0f),
		new Vector3(0.5f, 0.5f, 0f)
	};

	// Token: 0x0400230F RID: 8975
	private static Vector3[] ICFPLCMPDNC = new Vector3[]
	{
		Vector3.forward,
		Vector3.forward,
		Vector3.forward,
		Vector3.forward
	};

	// Token: 0x04002310 RID: 8976
	private static Vector4[] JNEAJOPDOHK = new Vector4[]
	{
		Vector3.right,
		Vector3.right,
		Vector3.right,
		Vector3.right
	};

	// Token: 0x04002311 RID: 8977
	private static Vector2[] ONIKKAIALCG = new Vector2[]
	{
		Vector2.zero,
		Vector2.right,
		Vector2.up,
		Vector2.one
	};
}
