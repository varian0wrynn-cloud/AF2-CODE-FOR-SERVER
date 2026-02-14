using System;
using UnityEngine;

// Token: 0x02000577 RID: 1399
public static class CDBICMCJFCE
{
	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x0601247F RID: 74879 RVA: 0x008056FC File Offset: 0x008038FC
	public static bool AIDPGNAEOMF
	{
		get
		{
			return QualitySettings.activeColorSpace == ColorSpace.Linear;
		}
	}

	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x06012480 RID: 74880 RVA: 0x0056A006 File Offset: 0x00568206
	public static bool FCKMFNPENOJ
	{
		get
		{
			return SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;
		}
	}

	// Token: 0x17000410 RID: 1040
	// (get) Token: 0x06012481 RID: 74881 RVA: 0x00805708 File Offset: 0x00803908
	public static Texture2D PGPDKDHFOLI
	{
		get
		{
			if (CDBICMCJFCE.PIFHPFDOPOB != null)
			{
				return CDBICMCJFCE.PIFHPFDOPOB;
			}
			CDBICMCJFCE.PIFHPFDOPOB = new Texture2D(1, 1, TextureFormat.ARGB32, false);
			CDBICMCJFCE.PIFHPFDOPOB.SetPixel(0, 0, new Color(1f, 1f, 1f, 1f));
			CDBICMCJFCE.PIFHPFDOPOB.Apply();
			return CDBICMCJFCE.PIFHPFDOPOB;
		}
	}

	// Token: 0x17000411 RID: 1041
	// (get) Token: 0x06012482 RID: 74882 RVA: 0x0080576C File Offset: 0x0080396C
	public static Mesh BHBBKCJAMNO
	{
		get
		{
			if (CDBICMCJFCE.MOGBHNIBPPJ != null)
			{
				return CDBICMCJFCE.MOGBHNIBPPJ;
			}
			Vector3[] vertices = new Vector3[]
			{
				new Vector3(-1f, -1f, 0f),
				new Vector3(1f, 1f, 0f),
				new Vector3(1f, -1f, 0f),
				new Vector3(-1f, 1f, 0f)
			};
			Vector2[] uv = new Vector2[]
			{
				new Vector2(0f, 0f),
				new Vector2(1f, 1f),
				new Vector2(1f, 0f),
				new Vector2(0f, 1f)
			};
			int[] triangles = new int[]
			{
				0,
				1,
				2,
				1,
				0,
				3
			};
			CDBICMCJFCE.MOGBHNIBPPJ = new Mesh
			{
				vertices = vertices,
				uv = uv,
				triangles = triangles
			};
			CDBICMCJFCE.MOGBHNIBPPJ.RecalculateNormals();
			CDBICMCJFCE.MOGBHNIBPPJ.RecalculateBounds();
			return CDBICMCJFCE.MOGBHNIBPPJ;
		}
	}

	// Token: 0x06012483 RID: 74883 RVA: 0x008058A8 File Offset: 0x00803AA8
	public static void OFGPPIJMEID(Material MHNAJNGGDFJ, int INEBKEDAPPN)
	{
		GL.PushMatrix();
		GL.LoadOrtho();
		MHNAJNGGDFJ.SetPass(INEBKEDAPPN);
		GL.Begin(5);
		GL.TexCoord2(0f, 0f);
		GL.Vertex3(0f, 0f, 0.1f);
		GL.TexCoord2(1f, 0f);
		GL.Vertex3(1f, 0f, 0.1f);
		GL.TexCoord2(0f, 1f);
		GL.Vertex3(0f, 1f, 0.1f);
		GL.TexCoord2(1f, 1f);
		GL.Vertex3(1f, 1f, 0.1f);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x06012484 RID: 74884 RVA: 0x00805964 File Offset: 0x00803B64
	public static void DKHMFHNPPNB(Texture JONJODLFAEN, RenderTexture OKIIDHIJBEA, Material MHNAJNGGDFJ, int INEBKEDAPPN, bool HIPGJEGFFJH = true, bool LADIHNOLHBH = false)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = OKIIDHIJBEA;
		GL.Clear(false, HIPGJEGFFJH, Color.clear);
		GL.PushMatrix();
		GL.LoadOrtho();
		MHNAJNGGDFJ.SetTexture("_MainTex", JONJODLFAEN);
		MHNAJNGGDFJ.SetPass(INEBKEDAPPN);
		GL.Begin(5);
		GL.TexCoord2(0f, 0f);
		GL.Vertex3(0f, 0f, 0.1f);
		GL.TexCoord2(1f, 0f);
		GL.Vertex3(1f, 0f, 0.1f);
		GL.TexCoord2(0f, 1f);
		GL.Vertex3(0f, 1f, 0.1f);
		GL.TexCoord2(1f, 1f);
		GL.Vertex3(1f, 1f, 0.1f);
		GL.End();
		GL.PopMatrix();
		RenderTexture.active = active;
	}

	// Token: 0x06012485 RID: 74885 RVA: 0x00805A48 File Offset: 0x00803C48
	public static void MHJKBMIOGCD(UnityEngine.Object MBKPMBPLIJN)
	{
		if (MBKPMBPLIJN != null)
		{
			UnityEngine.Object.Destroy(MBKPMBPLIJN);
		}
	}

	// Token: 0x06012486 RID: 74886 RVA: 0x00805A59 File Offset: 0x00803C59
	public static void DAGFCHOFMFP()
	{
		CDBICMCJFCE.MHJKBMIOGCD(CDBICMCJFCE.MOGBHNIBPPJ);
	}

	// Token: 0x040025DC RID: 9692
	private static Texture2D PIFHPFDOPOB;

	// Token: 0x040025DD RID: 9693
	private static Mesh MOGBHNIBPPJ;
}
