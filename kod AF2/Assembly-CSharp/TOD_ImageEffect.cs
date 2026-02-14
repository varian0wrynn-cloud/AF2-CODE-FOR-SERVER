using System;
using UnityEngine;

// Token: 0x020000CC RID: 204
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public abstract class TOD_ImageEffect : MonoBehaviour
{
	// Token: 0x0600284A RID: 10314 RVA: 0x0011CCD0 File Offset: 0x0011AED0
	protected Material PHNMLJJBKDC(Shader BAKBIMBKKNP)
	{
		if (!BAKBIMBKKNP)
		{
			Debug.Log("Missing shader in " + this.ToString());
			base.enabled = false;
			return null;
		}
		if (!BAKBIMBKKNP.isSupported)
		{
			Debug.LogError(string.Concat(new string[]
			{
				"The shader ",
				BAKBIMBKKNP.ToString(),
				" on effect ",
				this.ToString(),
				" is not supported on this platform!"
			}));
			base.enabled = false;
			return null;
		}
		return new Material(BAKBIMBKKNP)
		{
			hideFlags = HideFlags.DontSave
		};
	}

	// Token: 0x0600284B RID: 10315 RVA: 0x0011CD5C File Offset: 0x0011AF5C
	protected void Awake()
	{
		if (!this.PMMEFNKFJIA)
		{
			this.PMMEFNKFJIA = base.GetComponent<Camera>();
		}
		if (!this.sky)
		{
			this.sky = (UnityEngine.Object.FindObjectOfType(typeof(TOD_Sky)) as TOD_Sky);
		}
	}

	// Token: 0x0600284C RID: 10316 RVA: 0x0011CDAC File Offset: 0x0011AFAC
	protected bool DAOKCAOFIGE(bool AEAEPFBMGOM = false, bool PEIGGOMHOFH = false)
	{
		if (!this.PMMEFNKFJIA)
		{
			return false;
		}
		if (!this.sky || !this.sky.FPAKOLIPIND)
		{
			return false;
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarning("The image effect " + this.ToString() + " has been disabled as it's not supported on the current platform.");
			base.enabled = false;
			return false;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			Debug.LogWarning("The image effect " + this.ToString() + " has been disabled as it requires a depth texture.");
			base.enabled = false;
			return false;
		}
		if (PEIGGOMHOFH && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			Debug.LogWarning("The image effect " + this.ToString() + " has been disabled as it requires HDR.");
			base.enabled = false;
			return false;
		}
		if (AEAEPFBMGOM)
		{
			this.PMMEFNKFJIA.depthTextureMode |= DepthTextureMode.Depth;
		}
		if (PEIGGOMHOFH)
		{
			this.PMMEFNKFJIA.allowHDR = true;
		}
		return true;
	}

	// Token: 0x0600284D RID: 10317 RVA: 0x0011CE98 File Offset: 0x0011B098
	protected void AMLGEFKEOKF(RenderTexture OLFKAHHACBC, Material MHNAJNGGDFJ)
	{
		RenderTexture.active = OLFKAHHACBC;
		bool flag = true;
		GL.PushMatrix();
		GL.LoadOrtho();
		for (int i = 0; i < MHNAJNGGDFJ.passCount; i++)
		{
			MHNAJNGGDFJ.SetPass(i);
			float y;
			float y2;
			if (flag)
			{
				y = 1f;
				y2 = 0f;
			}
			else
			{
				y = 0f;
				y2 = 1f;
			}
			float x = 0f;
			float x2 = 0f + 1f / ((float)OLFKAHHACBC.width * 1f);
			float y3 = 0f;
			float y4 = 1f;
			GL.Begin(7);
			GL.TexCoord2(0f, y);
			GL.Vertex3(x, y3, 0.1f);
			GL.TexCoord2(1f, y);
			GL.Vertex3(x2, y3, 0.1f);
			GL.TexCoord2(1f, y2);
			GL.Vertex3(x2, y4, 0.1f);
			GL.TexCoord2(0f, y2);
			GL.Vertex3(x, y4, 0.1f);
			float x3 = 1f - 1f / ((float)OLFKAHHACBC.width * 1f);
			x2 = 1f;
			y3 = 0f;
			y4 = 1f;
			GL.TexCoord2(0f, y);
			GL.Vertex3(x3, y3, 0.1f);
			GL.TexCoord2(1f, y);
			GL.Vertex3(x2, y3, 0.1f);
			GL.TexCoord2(1f, y2);
			GL.Vertex3(x2, y4, 0.1f);
			GL.TexCoord2(0f, y2);
			GL.Vertex3(x3, y4, 0.1f);
			float x4 = 0f;
			x2 = 1f;
			y3 = 0f;
			y4 = 0f + 1f / ((float)OLFKAHHACBC.height * 1f);
			GL.TexCoord2(0f, y);
			GL.Vertex3(x4, y3, 0.1f);
			GL.TexCoord2(1f, y);
			GL.Vertex3(x2, y3, 0.1f);
			GL.TexCoord2(1f, y2);
			GL.Vertex3(x2, y4, 0.1f);
			GL.TexCoord2(0f, y2);
			GL.Vertex3(x4, y4, 0.1f);
			float x5 = 0f;
			x2 = 1f;
			y3 = 1f - 1f / ((float)OLFKAHHACBC.height * 1f);
			y4 = 1f;
			GL.TexCoord2(0f, y);
			GL.Vertex3(x5, y3, 0.1f);
			GL.TexCoord2(1f, y);
			GL.Vertex3(x2, y3, 0.1f);
			GL.TexCoord2(1f, y2);
			GL.Vertex3(x2, y4, 0.1f);
			GL.TexCoord2(0f, y2);
			GL.Vertex3(x5, y4, 0.1f);
			GL.End();
		}
		GL.PopMatrix();
	}

	// Token: 0x0600284E RID: 10318 RVA: 0x0011D134 File Offset: 0x0011B334
	protected void OMIKKBOOPEC(RenderTexture JONJODLFAEN, RenderTexture OLFKAHHACBC, Material FLNBPAKOMAH, int DELLNONMMHJ = 0)
	{
		RenderTexture.active = OLFKAHHACBC;
		FLNBPAKOMAH.SetTexture("_MainTex", JONJODLFAEN);
		GL.PushMatrix();
		GL.LoadOrtho();
		FLNBPAKOMAH.SetPass(DELLNONMMHJ);
		GL.Begin(7);
		GL.MultiTexCoord2(0, 0f, 0f);
		GL.Vertex3(0f, 0f, 3f);
		GL.MultiTexCoord2(0, 1f, 0f);
		GL.Vertex3(1f, 0f, 2f);
		GL.MultiTexCoord2(0, 1f, 1f);
		GL.Vertex3(1f, 1f, 1f);
		GL.MultiTexCoord2(0, 0f, 1f);
		GL.Vertex3(0f, 1f, 0f);
		GL.End();
		GL.PopMatrix();
	}

	// Token: 0x040004EE RID: 1262
	public TOD_Sky sky;

	// Token: 0x040004EF RID: 1263
	protected Camera PMMEFNKFJIA;
}
