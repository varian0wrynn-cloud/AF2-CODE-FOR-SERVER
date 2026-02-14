using System;
using UnityEngine;

// Token: 0x0200035A RID: 858
public static class OOFCHDPCJIJ
{
	// Token: 0x0600C060 RID: 49248 RVA: 0x00569F48 File Offset: 0x00568148
	public static bool MLBELGPBEFK(Shader EEOOKGDHNCO, bool AEAEPFBMGOM, bool PEIGGOMHOFH, MonoBehaviour JLEACBAILGG)
	{
		if (EEOOKGDHNCO == null || !EEOOKGDHNCO.isSupported)
		{
			Debug.LogWarningFormat("Missing shader for image effect {0}", new object[]
			{
				JLEACBAILGG
			});
			return false;
		}
		if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
		{
			Debug.LogWarningFormat("Image effects aren't supported on this device ({0})", new object[]
			{
				JLEACBAILGG
			});
			return false;
		}
		if (AEAEPFBMGOM && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			Debug.LogWarningFormat("Depth textures aren't supported on this device ({0})", new object[]
			{
				JLEACBAILGG
			});
			return false;
		}
		if (PEIGGOMHOFH && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
		{
			Debug.LogWarningFormat("Floating point textures aren't supported on this device ({0})", new object[]
			{
				JLEACBAILGG
			});
			return false;
		}
		return true;
	}

	// Token: 0x0600C061 RID: 49249 RVA: 0x00569FE3 File Offset: 0x005681E3
	public static Material DJFOEIJIMJB(Shader EEOOKGDHNCO)
	{
		if (EEOOKGDHNCO == null || !EEOOKGDHNCO.isSupported)
		{
			return null;
		}
		return new Material(EEOOKGDHNCO)
		{
			hideFlags = HideFlags.DontSave
		};
	}

	// Token: 0x1700029A RID: 666
	// (get) Token: 0x0600C062 RID: 49250 RVA: 0x0056A006 File Offset: 0x00568206
	public static bool FCKMFNPENOJ
	{
		get
		{
			return SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;
		}
	}
}
