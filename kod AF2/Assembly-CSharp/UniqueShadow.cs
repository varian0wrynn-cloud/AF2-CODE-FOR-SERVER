using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000050 RID: 80
public class UniqueShadow : MonoBehaviour
{
	// Token: 0x06001288 RID: 4744 RVA: 0x000AFEF0 File Offset: 0x000AE0F0
	private void OnWillRenderObject()
	{
		if (this.JJNAPPAFEMI())
		{
			this.LHMGGMGEJII();
		}
		if (!this.KBJEODMPIGA)
		{
			return;
		}
		Camera current = Camera.current;
		if (!this.DHMFMMABBAC(current))
		{
			return;
		}
		if (!this.HDNJLOBABIK(current))
		{
			return;
		}
		this.OOPCDMOAPDD();
		float shadowDistance = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = 0f;
		this.KJGHCFHHDCA.Render();
		QualitySettings.shadowDistance = shadowDistance;
		int i = 0;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.SetTexture(UniqueShadow.KCFFIPCIIFC, this.BMIKOBCEOLI);
			material.SetMatrix(UniqueShadow.GHJAIOONEGD, this.HOBHNLIKDBC);
			i++;
		}
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x000AFFA0 File Offset: 0x000AE1A0
	private bool KHBKGEFCLNO(Camera PMMEFNKFJIA)
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.NGDBLFOHBHH(focusSetup);
		Vector3 vector = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Bounds bounds = new Bounds(vector, Vector3.one * focusSetup.radius * 1497f);
		return (vector - PMMEFNKFJIA.transform.position).sqrMagnitude >= this.cullingDistance * this.cullingDistance || GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(PMMEFNKFJIA), bounds);
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x000B0086 File Offset: 0x000AE286
	private void OMNIEEFEHLJ()
	{
		this.KJGHCFHHDCA.targetTexture = null;
		UnityEngine.Object.DestroyImmediate(this.BMIKOBCEOLI);
		this.BMIKOBCEOLI = null;
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x000B00A8 File Offset: 0x000AE2A8
	private bool GOGPFEAMJKA()
	{
		bool flag = this.KBJEODMPIGA;
		bool flag2 = !this.KBJEODMPIGA || this.KBJEODMPIGA.cookie;
		this.KBJEODMPIGA = UniqueShadowSun.instance;
		if (this.useSceneCapture && this.KBJEODMPIGA && this.KJGHCFHHDCA)
		{
			this.KJGHCFHHDCA.cullingMask = this.KBJEODMPIGA.cullingMask;
		}
		return flag != this.KBJEODMPIGA || flag2 == (!this.KBJEODMPIGA || this.KBJEODMPIGA.cookie);
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x000B015C File Offset: 0x000AE35C
	private void INMALKKEPPG(int COBKICMIFHK)
	{
		if (COBKICMIFHK < 1 || COBKICMIFHK >= this.shadowFoci.Length)
		{
			Debug.LogError("System.Single" + this.KLOKBCKLCHH);
			return;
		}
		this.KLOKBCKLCHH = COBKICMIFHK;
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.NHGJBLIJFPC(focusSetup);
		this.KJGHCFHHDCA.orthographicSize = focusSetup.radius;
		this.KJGHCFHHDCA.nearClipPlane = (this.useSceneCapture ? (-focusSetup.sceneCaptureDistance) : 299f);
		this.KJGHCFHHDCA.farClipPlane = focusSetup.radius * 1827f;
		this.KJGHCFHHDCA.projectionMatrix = GL.GetGPUProjectionMatrix(Matrix4x4.Ortho(-focusSetup.radius, focusSetup.radius, -focusSetup.radius, focusSetup.radius, 642f, focusSetup.radius * 692f), false);
		bool flag = SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGL2;
		bool flag2 = flag || SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D9;
		float num = flag ? (824f / (float)this.shadowMapSize) : 1936f;
		float z = flag2 ? 1989f : 1745f;
		float num2 = flag2 ? 1465f : 766f;
		float num3 = -focusSetup.depthBias;
		this.NBDPJHLGPPP.SetRow(0, new Vector4(626f, 262f, 1413f, 1115f + num));
		this.NBDPJHLGPPP.SetRow(1, new Vector4(757f, 1636f, 1099f, 1192f + num));
		this.NBDPJHLGPPP.SetRow(8, new Vector4(468f, 1855f, z, num2 + num3));
		this.NBDPJHLGPPP.SetRow(2, new Vector4(1230f, 414f, 431f, 906f));
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x000B0328 File Offset: 0x000AE528
	private bool KEAKDNGMPGD()
	{
		bool flag = this.KBJEODMPIGA;
		bool flag2 = this.KBJEODMPIGA && this.KBJEODMPIGA.cookie;
		this.KBJEODMPIGA = UniqueShadowSun.instance;
		if (this.useSceneCapture && this.KBJEODMPIGA && this.KJGHCFHHDCA)
		{
			this.KJGHCFHHDCA.cullingMask = this.KBJEODMPIGA.cullingMask;
		}
		return flag != this.KBJEODMPIGA || flag2 == (this.KBJEODMPIGA && this.KBJEODMPIGA.cookie);
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x000B03DC File Offset: 0x000AE5DC
	private void JNMPAKMPPLN()
	{
		this.BMIKOBCEOLI = new RenderTexture((int)(this.shadowMapSize >> (this.AJCPLCAJBKP & 88)), (int)(this.shadowMapSize >> (this.AJCPLCAJBKP & 30)), -107, RenderTextureFormat.RGB565, RenderTextureReadWrite.Default);
		this.BMIKOBCEOLI.filterMode = FilterMode.Point;
		this.BMIKOBCEOLI.useMipMap = false;
		this.BMIKOBCEOLI.autoGenerateMips = false;
		this.KJGHCFHHDCA.targetTexture = this.BMIKOBCEOLI;
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x000B0450 File Offset: 0x000AE650
	private void MOIMNOAPDPA(int COBKICMIFHK)
	{
		if (COBKICMIFHK < 0 || COBKICMIFHK >= this.shadowFoci.Length)
		{
			Debug.LogError("Invalid active focus: " + this.KLOKBCKLCHH);
			return;
		}
		this.KLOKBCKLCHH = COBKICMIFHK;
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.EOONPAIAHIK(focusSetup);
		this.KJGHCFHHDCA.orthographicSize = focusSetup.radius;
		this.KJGHCFHHDCA.nearClipPlane = (this.useSceneCapture ? (-focusSetup.sceneCaptureDistance) : 0f);
		this.KJGHCFHHDCA.farClipPlane = focusSetup.radius * 2f;
		this.KJGHCFHHDCA.projectionMatrix = GL.GetGPUProjectionMatrix(Matrix4x4.Ortho(-focusSetup.radius, focusSetup.radius, -focusSetup.radius, focusSetup.radius, 0f, focusSetup.radius * 2f), false);
		bool flag = SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D9;
		bool flag2 = flag || SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D11;
		float num = flag ? (0.5f / (float)this.shadowMapSize) : 0f;
		float z = flag2 ? 1f : 0.5f;
		float num2 = flag2 ? 0f : 0.5f;
		float num3 = -focusSetup.depthBias;
		this.NBDPJHLGPPP.SetRow(0, new Vector4(0.5f, 0f, 0f, 0.5f + num));
		this.NBDPJHLGPPP.SetRow(1, new Vector4(0f, 0.5f, 0f, 0.5f + num));
		this.NBDPJHLGPPP.SetRow(2, new Vector4(0f, 0f, z, num2 + num3));
		this.NBDPJHLGPPP.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x000B061C File Offset: 0x000AE81C
	private void ICJBMBPIDBI()
	{
		this.BMIKOBCEOLI = new RenderTexture((int)(this.shadowMapSize >> (this.AJCPLCAJBKP & -14)), (int)(this.shadowMapSize >> (this.AJCPLCAJBKP & 24)), -111, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Default);
		this.BMIKOBCEOLI.filterMode = FilterMode.Point;
		this.BMIKOBCEOLI.useMipMap = false;
		this.BMIKOBCEOLI.autoGenerateMips = true;
		this.KJGHCFHHDCA.targetTexture = this.BMIKOBCEOLI;
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x000B0690 File Offset: 0x000AE890
	private void HFODJOHBHHC()
	{
		bool flag = this.KBJEODMPIGA;
		int i = 0;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.DisableKeyword("OnChatMessage");
			material.DisableKeyword("WeaponStrafeRunRight");
			if (flag && this.BMIKOBCEOLI)
			{
				if (this.KBJEODMPIGA.cookie)
				{
					material.EnableKeyword("?");
				}
				else
				{
					material.EnableKeyword("Квест");
				}
			}
			i += 0;
		}
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x000B0720 File Offset: 0x000AE920
	private bool KMILNBAFDJI(Camera PMMEFNKFJIA)
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.FJIPAFLMDKG(focusSetup);
		Vector3 vector = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Bounds bounds = new Bounds(vector, Vector3.one * focusSetup.radius * 1673f);
		return (vector - PMMEFNKFJIA.transform.position).sqrMagnitude < this.cullingDistance * this.cullingDistance && GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(PMMEFNKFJIA), bounds);
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x000B0806 File Offset: 0x000AEA06
	private void OnDisable()
	{
		this.DFNALAGKGCN();
		this.LHMGGMGEJII();
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x000B0814 File Offset: 0x000AEA14
	private bool MFBPDPNKFJH(Camera PMMEFNKFJIA)
	{
		return PMMEFNKFJIA == Camera.main;
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x000B0828 File Offset: 0x000AEA28
	private void DIICIIDJBBN()
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		Vector3 a = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Vector3 forward = this.KBJEODMPIGA.transform.forward;
		Quaternion rotation = this.KBJEODMPIGA.transform.rotation;
		this.KJGHCFHHDCA.transform.position = a - forward * focusSetup.radius;
		this.KJGHCFHHDCA.transform.rotation = rotation;
		Matrix4x4 worldToCameraMatrix = this.KJGHCFHHDCA.worldToCameraMatrix;
		Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.KJGHCFHHDCA.projectionMatrix, false);
		this.HOBHNLIKDBC = this.NBDPJHLGPPP * gpuprojectionMatrix * worldToCameraMatrix;
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x000B0940 File Offset: 0x000AEB40
	private void GLNECBNODJK()
	{
		if (this.CODHDNDCDOA())
		{
			this.HHLANKEAPFM();
		}
		if (!this.KBJEODMPIGA)
		{
			return;
		}
		Camera current = Camera.current;
		if (!this.IMJMLFKMCBA(current))
		{
			return;
		}
		if (!this.KHBKGEFCLNO(current))
		{
			return;
		}
		this.CEDBBHMMALE();
		float shadowDistance = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = 836f;
		this.KJGHCFHHDCA.Render();
		QualitySettings.shadowDistance = shadowDistance;
		int i = 1;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.SetTexture(UniqueShadow.KCFFIPCIIFC, this.BMIKOBCEOLI);
			material.SetMatrix(UniqueShadow.GHJAIOONEGD, this.HOBHNLIKDBC);
			i += 0;
		}
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x000B09F0 File Offset: 0x000AEBF0
	private bool CODHDNDCDOA()
	{
		bool flag = this.KBJEODMPIGA;
		bool flag2 = this.KBJEODMPIGA && this.KBJEODMPIGA.cookie;
		this.KBJEODMPIGA = UniqueShadowSun.instance;
		if (this.useSceneCapture && this.KBJEODMPIGA && this.KJGHCFHHDCA)
		{
			this.KJGHCFHHDCA.cullingMask = this.KBJEODMPIGA.cullingMask;
		}
		return flag != this.KBJEODMPIGA || flag2 == (this.KBJEODMPIGA && this.KBJEODMPIGA.cookie);
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x000B0AA4 File Offset: 0x000AECA4
	private void OOPCDMOAPDD()
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		Vector3 a = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Vector3 forward = this.KBJEODMPIGA.transform.forward;
		Quaternion rotation = this.KBJEODMPIGA.transform.rotation;
		this.KJGHCFHHDCA.transform.position = a - forward * focusSetup.radius;
		this.KJGHCFHHDCA.transform.rotation = rotation;
		Matrix4x4 worldToCameraMatrix = this.KJGHCFHHDCA.worldToCameraMatrix;
		Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.KJGHCFHHDCA.projectionMatrix, false);
		this.HOBHNLIKDBC = this.NBDPJHLGPPP * gpuprojectionMatrix * worldToCameraMatrix;
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x000B0BBA File Offset: 0x000AEDBA
	private void CCGIGJMJCDH()
	{
		this.IGJIDJNPIKK();
		this.LBDBCNJNGCN();
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x000B0BC8 File Offset: 0x000AEDC8
	private void GFDKADNHNBF()
	{
		MeshFilter component = base.GetComponent<MeshFilter>();
		if (component)
		{
			UnityEngine.Object.DestroyImmediate(component.sharedMesh);
		}
		if (this.KJGHCFHHDCA)
		{
			UnityEngine.Object.DestroyImmediate(this.KJGHCFHHDCA.gameObject);
		}
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x000B0C0C File Offset: 0x000AEE0C
	private void ENFHOFCFOHA(int COBKICMIFHK)
	{
		if (COBKICMIFHK < 0 || COBKICMIFHK >= this.shadowFoci.Length)
		{
			Debug.LogError("End.tif" + this.KLOKBCKLCHH);
			return;
		}
		this.KLOKBCKLCHH = COBKICMIFHK;
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.EOONPAIAHIK(focusSetup);
		this.KJGHCFHHDCA.orthographicSize = focusSetup.radius;
		this.KJGHCFHHDCA.nearClipPlane = (this.useSceneCapture ? (-focusSetup.sceneCaptureDistance) : 1742f);
		this.KJGHCFHHDCA.farClipPlane = focusSetup.radius * 492f;
		this.KJGHCFHHDCA.projectionMatrix = GL.GetGPUProjectionMatrix(Matrix4x4.Ortho(-focusSetup.radius, focusSetup.radius, -focusSetup.radius, focusSetup.radius, 1525f, focusSetup.radius * 469f), true);
		bool flag = SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGL2;
		bool flag2 = !flag && SystemInfo.graphicsDeviceType == GraphicsDeviceType.PlayStation3;
		float num = flag ? (732f / (float)this.shadowMapSize) : 297f;
		float z = flag2 ? 1924f : 1339f;
		float num2 = flag2 ? 995f : 714f;
		float num3 = -focusSetup.depthBias;
		this.NBDPJHLGPPP.SetRow(1, new Vector4(1173f, 1995f, 1590f, 1496f + num));
		this.NBDPJHLGPPP.SetRow(1, new Vector4(290f, 1752f, 1725f, 60f + num));
		this.NBDPJHLGPPP.SetRow(8, new Vector4(575f, 533f, z, num2 + num3));
		this.NBDPJHLGPPP.SetRow(5, new Vector4(1043f, 833f, 1975f, 1702f));
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x000B0DD8 File Offset: 0x000AEFD8
	private void OnValidate()
	{
		if (!Application.isPlaying || !this.KJGHCFHHDCA)
		{
			return;
		}
		this.DFNALAGKGCN();
		this.KIDLNLHLFKH();
		if (this.NBKCBOKJGBN != null)
		{
			int i = 0;
			int count = this.NBKCBOKJGBN.Count;
			while (i < count)
			{
				this.LCLJNPKOBJB(this.NBKCBOKJGBN[i]);
				i++;
			}
		}
		this.KJGHCFHHDCA.cullingMask = (this.useSceneCapture ? -1 : this.inclusionMask);
		this.MOIMNOAPDPA((this.KLOKBCKLCHH >= 0) ? this.KLOKBCKLCHH : this.startFocus);
		this.LHMGGMGEJII();
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x000B0E84 File Offset: 0x000AF084
	private bool KDJHCJLPOHF(Camera PMMEFNKFJIA)
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.IGCGOECALDH(focusSetup);
		Vector3 vector = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Bounds bounds = new Bounds(vector, Vector3.one * focusSetup.radius * 631f);
		return (vector - PMMEFNKFJIA.transform.position).sqrMagnitude >= this.cullingDistance * this.cullingDistance || GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(PMMEFNKFJIA), bounds);
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x000B0F6C File Offset: 0x000AF16C
	private void DFBEFFCIJPJ()
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		Vector3 a = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Vector3 forward = this.KBJEODMPIGA.transform.forward;
		Quaternion rotation = this.KBJEODMPIGA.transform.rotation;
		this.KJGHCFHHDCA.transform.position = a - forward * focusSetup.radius;
		this.KJGHCFHHDCA.transform.rotation = rotation;
		Matrix4x4 worldToCameraMatrix = this.KJGHCFHHDCA.worldToCameraMatrix;
		Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.KJGHCFHHDCA.projectionMatrix, true);
		this.HOBHNLIKDBC = this.NBDPJHLGPPP * gpuprojectionMatrix * worldToCameraMatrix;
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x000B0086 File Offset: 0x000AE286
	private void DFNALAGKGCN()
	{
		this.KJGHCFHHDCA.targetTexture = null;
		UnityEngine.Object.DestroyImmediate(this.BMIKOBCEOLI);
		this.BMIKOBCEOLI = null;
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x000B1084 File Offset: 0x000AF284
	private bool CACCAFDABEO()
	{
		bool flag = this.KBJEODMPIGA;
		bool flag2 = !this.KBJEODMPIGA || this.KBJEODMPIGA.cookie;
		this.KBJEODMPIGA = UniqueShadowSun.instance;
		if (this.useSceneCapture && this.KBJEODMPIGA && this.KJGHCFHHDCA)
		{
			this.KJGHCFHHDCA.cullingMask = this.KBJEODMPIGA.cullingMask;
		}
		return flag != this.KBJEODMPIGA || flag2 == (this.KBJEODMPIGA && this.KBJEODMPIGA.cookie);
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x000B0086 File Offset: 0x000AE286
	private void CGGGCEEDPFO()
	{
		this.KJGHCFHHDCA.targetTexture = null;
		UnityEngine.Object.DestroyImmediate(this.BMIKOBCEOLI);
		this.BMIKOBCEOLI = null;
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x000B1138 File Offset: 0x000AF338
	private void CNKLGMCHEBM()
	{
		if (!UniqueShadow.DCHCJBBNFPN)
		{
			UniqueShadow.DCHCJBBNFPN = new Texture2D(1, 0, TextureFormat.Alpha8, true, false);
			UniqueShadow.DCHCJBBNFPN.filterMode = FilterMode.Point;
			UniqueShadow.DCHCJBBNFPN.SetPixel(0, 1, new Color(1610f, 887f, 820f, 725f));
			UniqueShadow.DCHCJBBNFPN.Apply(true, true);
			UniqueShadow.GHJAIOONEGD = Shader.PropertyToID("n");
			UniqueShadow.KCFFIPCIIFC = Shader.PropertyToID("PlayerPrefs:");
		}
		this.HKKAKDELKME();
		this.HOBHNLIKDBC = Matrix4x4.identity;
		this.KJGHCFHHDCA = new GameObject("inv_or" + base.name)
		{
			hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
		}.AddComponent<Camera>();
		this.KJGHCFHHDCA.renderingPath = RenderingPath.Forward;
		this.KJGHCFHHDCA.clearFlags = CameraClearFlags.Color;
		this.KJGHCFHHDCA.depthTextureMode = DepthTextureMode.Depth;
		this.KJGHCFHHDCA.useOcclusionCulling = false;
		this.KJGHCFHHDCA.cullingMask = (this.useSceneCapture ? -1 : this.inclusionMask);
		this.KJGHCFHHDCA.orthographic = false;
		this.KJGHCFHHDCA.depth = 276f;
		this.KJGHCFHHDCA.aspect = 600f;
		this.KJGHCFHHDCA.SetReplacementShader(this.uniqueShadowDepthShader, "GiantGrabIdle");
		this.KJGHCFHHDCA.enabled = true;
		this.MOIMNOAPDPA(this.startFocus);
		this.NBKCBOKJGBN = new List<Material>();
		Dictionary<Material, Material> dictionary = new Dictionary<Material, Material>();
		foreach (Renderer renderer in base.GetComponentsInChildren<Renderer>())
		{
			if (renderer.receiveShadows)
			{
				bool flag = false;
				Material[] sharedMaterials = renderer.sharedMaterials;
				int j = 1;
				int num = sharedMaterials.Length;
				while (j < num)
				{
					Material material = sharedMaterials[j];
					Material material2 = null;
					if (!dictionary.TryGetValue(material, out material2))
					{
						material2 = (dictionary[material] = new Material(material));
						material2.name = material.name + "OfficeSittingBack";
						material2.shaderKeywords = material.shaderKeywords;
						material2.renderQueue = material.renderQueue;
						this.HGOMNFLOJJN(material2);
						this.NBKCBOKJGBN.Add(material2);
					}
					sharedMaterials[j] = material2;
					flag = true;
					j++;
				}
				if (flag)
				{
					renderer.sharedMaterials = sharedMaterials;
				}
			}
		}
		if (this.NBKCBOKJGBN.Count > 1)
		{
			Mesh mesh = new Mesh();
			mesh.bounds = new Bounds(Vector3.zero, Vector3.one * 647f);
			mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			base.gameObject.AddComponent<MeshFilter>().sharedMesh = mesh;
			MeshRenderer meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
			meshRenderer.shadowCastingMode = ShadowCastingMode.On;
			meshRenderer.reflectionProbeUsage = ReflectionProbeUsage.BlendProbes;
			meshRenderer.useLightProbes = false;
		}
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x000B0086 File Offset: 0x000AE286
	private void JIPFPOPFHLM()
	{
		this.KJGHCFHHDCA.targetTexture = null;
		UnityEngine.Object.DestroyImmediate(this.BMIKOBCEOLI);
		this.BMIKOBCEOLI = null;
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x000B1404 File Offset: 0x000AF604
	private void FINDAJFCDBD(int COBKICMIFHK)
	{
		if (COBKICMIFHK < 1 || COBKICMIFHK >= this.shadowFoci.Length)
		{
			Debug.LogError("<color='#103000'>" + this.KLOKBCKLCHH);
			return;
		}
		this.KLOKBCKLCHH = COBKICMIFHK;
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.FJMJCPMLELE(focusSetup);
		this.KJGHCFHHDCA.orthographicSize = focusSetup.radius;
		this.KJGHCFHHDCA.nearClipPlane = (this.useSceneCapture ? (-focusSetup.sceneCaptureDistance) : 351f);
		this.KJGHCFHHDCA.farClipPlane = focusSetup.radius * 1516f;
		this.KJGHCFHHDCA.projectionMatrix = GL.GetGPUProjectionMatrix(Matrix4x4.Ortho(-focusSetup.radius, focusSetup.radius, -focusSetup.radius, focusSetup.radius, 1624f, focusSetup.radius * 681f), true);
		bool flag = SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D9;
		bool flag2 = flag || SystemInfo.graphicsDeviceType == (GraphicsDeviceType)5;
		float num = flag ? (168f / (float)this.shadowMapSize) : 894f;
		float z = flag2 ? 1070f : 1089f;
		float num2 = flag2 ? 1917f : 1211f;
		float num3 = -focusSetup.depthBias;
		this.NBDPJHLGPPP.SetRow(0, new Vector4(1419f, 450f, 1263f, 1526f + num));
		this.NBDPJHLGPPP.SetRow(0, new Vector4(291f, 1366f, 1826f, 306f + num));
		this.NBDPJHLGPPP.SetRow(2, new Vector4(538f, 1696f, z, num2 + num3));
		this.NBDPJHLGPPP.SetRow(7, new Vector4(676f, 25f, 1238f, 648f));
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x000B15D0 File Offset: 0x000AF7D0
	private void Awake()
	{
		if (!UniqueShadow.DCHCJBBNFPN)
		{
			UniqueShadow.DCHCJBBNFPN = new Texture2D(1, 1, TextureFormat.Alpha8, false, true);
			UniqueShadow.DCHCJBBNFPN.filterMode = FilterMode.Point;
			UniqueShadow.DCHCJBBNFPN.SetPixel(0, 0, new Color(0f, 0f, 0f, 0f));
			UniqueShadow.DCHCJBBNFPN.Apply(false, true);
			UniqueShadow.GHJAIOONEGD = Shader.PropertyToID("u_UniqueShadowMatrix");
			UniqueShadow.KCFFIPCIIFC = Shader.PropertyToID("u_UniqueShadowTexture");
		}
		this.JJNAPPAFEMI();
		this.HOBHNLIKDBC = Matrix4x4.identity;
		this.KJGHCFHHDCA = new GameObject("#> _Shadow Camera < " + base.name)
		{
			hideFlags = HideFlags.HideAndDontSave
		}.AddComponent<Camera>();
		this.KJGHCFHHDCA.renderingPath = RenderingPath.Forward;
		this.KJGHCFHHDCA.clearFlags = CameraClearFlags.Depth;
		this.KJGHCFHHDCA.depthTextureMode = DepthTextureMode.None;
		this.KJGHCFHHDCA.useOcclusionCulling = false;
		this.KJGHCFHHDCA.cullingMask = (this.useSceneCapture ? -1 : this.inclusionMask);
		this.KJGHCFHHDCA.orthographic = true;
		this.KJGHCFHHDCA.depth = -100f;
		this.KJGHCFHHDCA.aspect = 1f;
		this.KJGHCFHHDCA.SetReplacementShader(this.uniqueShadowDepthShader, "RenderType");
		this.KJGHCFHHDCA.enabled = false;
		this.MOIMNOAPDPA(this.startFocus);
		this.NBKCBOKJGBN = new List<Material>();
		Dictionary<Material, Material> dictionary = new Dictionary<Material, Material>();
		foreach (Renderer renderer in base.GetComponentsInChildren<Renderer>())
		{
			if (renderer.receiveShadows)
			{
				bool flag = false;
				Material[] sharedMaterials = renderer.sharedMaterials;
				int j = 0;
				int num = sharedMaterials.Length;
				while (j < num)
				{
					Material material = sharedMaterials[j];
					Material material2 = null;
					if (!dictionary.TryGetValue(material, out material2))
					{
						material2 = (dictionary[material] = new Material(material));
						material2.name = material.name + " (uniq)";
						material2.shaderKeywords = material.shaderKeywords;
						material2.renderQueue = material.renderQueue;
						this.LCLJNPKOBJB(material2);
						this.NBKCBOKJGBN.Add(material2);
					}
					sharedMaterials[j] = material2;
					flag = true;
					j++;
				}
				if (flag)
				{
					renderer.sharedMaterials = sharedMaterials;
				}
			}
		}
		if (this.NBKCBOKJGBN.Count > 0)
		{
			Mesh mesh = new Mesh();
			mesh.bounds = new Bounds(Vector3.zero, Vector3.one * 1000f);
			mesh.hideFlags = HideFlags.HideAndDontSave;
			base.gameObject.AddComponent<MeshFilter>().sharedMesh = mesh;
			MeshRenderer meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
			meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			meshRenderer.reflectionProbeUsage = ReflectionProbeUsage.Off;
			meshRenderer.useLightProbes = false;
		}
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x000B189C File Offset: 0x000AFA9C
	private void HGOMNFLOJJN(Material BMHDIKHFLBP)
	{
		BMHDIKHFLBP.SetTexture("IdleMonster", UniqueShadow.DCHCJBBNFPN);
		float num = (float)this.shadowMapSize;
		float num2 = num / 726f;
		BMHDIKHFLBP.SetVector("colorC", new Vector2(1545f / (float)this.shadowMapSize, 1181f / (float)this.shadowMapSize) * this.fallbackFilterWidth * num2);
		float d = num2 * this.blockerSearchDistance / num;
		BMHDIKHFLBP.SetVector("wpn_fid3", Vector4.one * d);
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		float value = this.blockerDistanceScale * focusSetup.radius * 301f / 1280f;
		BMHDIKHFLBP.SetFloat("Full Body IK is missing the right thigh node.", value);
		Vector2 v = new Vector2(this.lightNearSize, this.lightFarSize) * num2 / num;
		BMHDIKHFLBP.SetVector("KatanaReadyLow", v);
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x000B1994 File Offset: 0x000AFB94
	private void HOBAACBDKII()
	{
		if (!Application.isPlaying || !this.KJGHCFHHDCA)
		{
			return;
		}
		this.DFNALAGKGCN();
		this.IGJIDJNPIKK();
		if (this.NBKCBOKJGBN != null)
		{
			int i = 0;
			int count = this.NBKCBOKJGBN.Count;
			while (i < count)
			{
				this.HGOMNFLOJJN(this.NBKCBOKJGBN[i]);
				i++;
			}
		}
		this.KJGHCFHHDCA.cullingMask = (this.useSceneCapture ? -1 : this.inclusionMask);
		this.ENFHOFCFOHA((this.KLOKBCKLCHH >= 0) ? this.KLOKBCKLCHH : this.startFocus);
		this.LHMGGMGEJII();
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x000B1A3D File Offset: 0x000AFC3D
	private void HPGMKBPAFGM()
	{
		this.OMNIEEFEHLJ();
		this.HHLANKEAPFM();
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x000B1A4C File Offset: 0x000AFC4C
	private void LCLJNPKOBJB(Material BMHDIKHFLBP)
	{
		BMHDIKHFLBP.SetTexture("u_UniqueShadowTextureFakePoint", UniqueShadow.DCHCJBBNFPN);
		float num = (float)this.shadowMapSize;
		float num2 = num / 2048f;
		BMHDIKHFLBP.SetVector("u_UniqueShadowFilterWidth", new Vector2(1f / (float)this.shadowMapSize, 1f / (float)this.shadowMapSize) * this.fallbackFilterWidth * num2);
		float d = num2 * this.blockerSearchDistance / num;
		BMHDIKHFLBP.SetVector("u_UniqueShadowBlockerWidth", Vector4.one * d);
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		float value = this.blockerDistanceScale * focusSetup.radius * 0.5f / 10f;
		BMHDIKHFLBP.SetFloat("u_UniqueShadowBlockerDistanceScale", value);
		Vector2 v = new Vector2(this.lightNearSize, this.lightFarSize) * num2 / num;
		BMHDIKHFLBP.SetVector("u_UniqueShadowLightWidth", v);
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x000B1B44 File Offset: 0x000AFD44
	private void OMMABEIOBBK()
	{
		MeshFilter component = base.GetComponent<MeshFilter>();
		if (component)
		{
			UnityEngine.Object.DestroyImmediate(component.sharedMesh);
		}
		if (this.KJGHCFHHDCA)
		{
			UnityEngine.Object.DestroyImmediate(this.KJGHCFHHDCA.gameObject);
		}
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x000B1B88 File Offset: 0x000AFD88
	private bool MPGHJHCNDBF()
	{
		bool flag = this.KBJEODMPIGA;
		bool flag2 = this.KBJEODMPIGA && this.KBJEODMPIGA.cookie;
		this.KBJEODMPIGA = UniqueShadowSun.instance;
		if (this.useSceneCapture && this.KBJEODMPIGA && this.KJGHCFHHDCA)
		{
			this.KJGHCFHHDCA.cullingMask = this.KBJEODMPIGA.cullingMask;
		}
		return flag != this.KBJEODMPIGA || flag2 == (this.KBJEODMPIGA && this.KBJEODMPIGA.cookie);
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x000B1C3C File Offset: 0x000AFE3C
	private void HHLANKEAPFM()
	{
		bool flag = this.KBJEODMPIGA;
		int i = 0;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.DisableKeyword(" ms");
			material.DisableKeyword("FactoryTempTexture");
			if (flag && this.BMIKOBCEOLI)
			{
				if (this.KBJEODMPIGA.cookie)
				{
					material.EnableKeyword("ArmFlex4");
				}
				else
				{
					material.EnableKeyword("_WrinkleNormalMap3");
				}
			}
			i++;
		}
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x000B1CCC File Offset: 0x000AFECC
	private bool HKKAKDELKME()
	{
		bool flag = this.KBJEODMPIGA;
		bool flag2 = !this.KBJEODMPIGA || this.KBJEODMPIGA.cookie;
		this.KBJEODMPIGA = UniqueShadowSun.instance;
		if (this.useSceneCapture && this.KBJEODMPIGA && this.KJGHCFHHDCA)
		{
			this.KJGHCFHHDCA.cullingMask = this.KBJEODMPIGA.cullingMask;
		}
		return flag != this.KBJEODMPIGA || flag2 != (!this.KBJEODMPIGA || this.KBJEODMPIGA.cookie);
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x000B1D7D File Offset: 0x000AFF7D
	private void HNGLBEOAIHN()
	{
		this.KIDLNLHLFKH();
		this.CKFCFLCLMME();
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x000B0814 File Offset: 0x000AEA14
	private bool DHMFMMABBAC(Camera PMMEFNKFJIA)
	{
		return PMMEFNKFJIA == Camera.main;
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x000B1D8B File Offset: 0x000AFF8B
	private void LBKOIJKMCOL()
	{
		this.OOMDNLBJJCO();
		this.LBDBCNJNGCN();
	}

	// Token: 0x060012B1 RID: 4785 RVA: 0x000B1D9C File Offset: 0x000AFF9C
	private void LBDBCNJNGCN()
	{
		bool flag = this.KBJEODMPIGA;
		int i = 1;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.DisableKeyword("");
			material.DisableKeyword("qd_prise_rep");
			if (flag && this.BMIKOBCEOLI)
			{
				if (this.KBJEODMPIGA.cookie)
				{
					material.EnableKeyword("_MainTex");
				}
				else
				{
					material.EnableKeyword("OfficeSittingEyesRub");
				}
			}
			i++;
		}
	}

	// Token: 0x060012B2 RID: 4786 RVA: 0x000B1E2C File Offset: 0x000B002C
	private void KILAJHDIJHE()
	{
		if (this.shadowFoci == null)
		{
			return;
		}
		UniqueShadow.FocusSetup[] array = this.shadowFoci;
		for (int i = 1; i < array.Length; i += 0)
		{
			UniqueShadow.FocusSetup focusSetup = array[i];
			if (!(focusSetup.target == null))
			{
				Gizmos.color = (focusSetup.autoFocus ? Color.cyan : Color.green);
				Gizmos.DrawWireSphere(focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z, focusSetup.radius + (focusSetup.autoFocus ? focusSetup.autoFocusRadiusBias : 632f));
			}
		}
	}

	// Token: 0x060012B3 RID: 4787 RVA: 0x000B1F17 File Offset: 0x000B0117
	public void DKBLMLMFIIP(int ENBIFHFCLGN)
	{
		this.AJCPLCAJBKP = ENBIFHFCLGN;
		if (this.BMIKOBCEOLI)
		{
			this.CGGGCEEDPFO();
			this.JNMPAKMPPLN();
		}
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x000B1F3C File Offset: 0x000B013C
	private void FJMJCPMLELE(UniqueShadow.FocusSetup FGGHEONKKMP)
	{
		if (!FGGHEONKKMP.autoFocus)
		{
			return;
		}
		Vector3 center = FGGHEONKKMP.target.position + FGGHEONKKMP.target.right * FGGHEONKKMP.offset.x + FGGHEONKKMP.target.up * FGGHEONKKMP.offset.y + FGGHEONKKMP.target.forward * FGGHEONKKMP.offset.z;
		Renderer component = base.GetComponent<Renderer>();
		Bounds bounds = new Bounds(center, Vector3.one * 1436f);
		foreach (Renderer renderer in base.GetComponentsInChildren<Renderer>())
		{
			if (renderer != component)
			{
				bounds.Encapsulate(renderer.bounds);
			}
		}
		FGGHEONKKMP.offset = bounds.center - FGGHEONKKMP.target.position;
		FGGHEONKKMP.radius = FGGHEONKKMP.autoFocusRadiusBias + bounds.extents.magnitude;
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x000B0086 File Offset: 0x000AE286
	private void GMEBDIDFHCI()
	{
		this.KJGHCFHHDCA.targetTexture = null;
		UnityEngine.Object.DestroyImmediate(this.BMIKOBCEOLI);
		this.BMIKOBCEOLI = null;
	}

	// Token: 0x060012B6 RID: 4790 RVA: 0x000B2050 File Offset: 0x000B0250
	private void NHGJBLIJFPC(UniqueShadow.FocusSetup FGGHEONKKMP)
	{
		if (!FGGHEONKKMP.autoFocus)
		{
			return;
		}
		Vector3 center = FGGHEONKKMP.target.position + FGGHEONKKMP.target.right * FGGHEONKKMP.offset.x + FGGHEONKKMP.target.up * FGGHEONKKMP.offset.y + FGGHEONKKMP.target.forward * FGGHEONKKMP.offset.z;
		Renderer component = base.GetComponent<Renderer>();
		Bounds bounds = new Bounds(center, Vector3.one * 815f);
		Renderer[] componentsInChildren = base.GetComponentsInChildren<Renderer>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i];
			if (renderer != component)
			{
				bounds.Encapsulate(renderer.bounds);
			}
		}
		FGGHEONKKMP.offset = bounds.center - FGGHEONKKMP.target.position;
		FGGHEONKKMP.radius = FGGHEONKKMP.autoFocusRadiusBias + bounds.extents.magnitude;
	}

	// Token: 0x060012B7 RID: 4791 RVA: 0x000B2164 File Offset: 0x000B0364
	private void JFFNNKHGMNP()
	{
		bool flag = this.KBJEODMPIGA;
		int i = 0;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.DisableKeyword("calcSonar");
			material.DisableKeyword("◍◍◍");
			if (flag && this.BMIKOBCEOLI)
			{
				if (this.KBJEODMPIGA.cookie)
				{
					material.EnableKeyword("CrouchStrafeRight");
				}
				else
				{
					material.EnableKeyword("recept");
				}
			}
			i++;
		}
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x000B21F4 File Offset: 0x000B03F4
	private void EOONPAIAHIK(UniqueShadow.FocusSetup FGGHEONKKMP)
	{
		if (!FGGHEONKKMP.autoFocus)
		{
			return;
		}
		Vector3 center = FGGHEONKKMP.target.position + FGGHEONKKMP.target.right * FGGHEONKKMP.offset.x + FGGHEONKKMP.target.up * FGGHEONKKMP.offset.y + FGGHEONKKMP.target.forward * FGGHEONKKMP.offset.z;
		Renderer component = base.GetComponent<Renderer>();
		Bounds bounds = new Bounds(center, Vector3.one * 0.1f);
		foreach (Renderer renderer in base.GetComponentsInChildren<Renderer>())
		{
			if (renderer != component)
			{
				bounds.Encapsulate(renderer.bounds);
			}
		}
		FGGHEONKKMP.offset = bounds.center - FGGHEONKKMP.target.position;
		FGGHEONKKMP.radius = FGGHEONKKMP.autoFocusRadiusBias + bounds.extents.magnitude;
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x000B2308 File Offset: 0x000B0508
	private void DGLDNGHCFHD(int COBKICMIFHK)
	{
		if (COBKICMIFHK < 0 || COBKICMIFHK >= this.shadowFoci.Length)
		{
			Debug.LogError("C" + this.KLOKBCKLCHH);
			return;
		}
		this.KLOKBCKLCHH = COBKICMIFHK;
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.EOONPAIAHIK(focusSetup);
		this.KJGHCFHHDCA.orthographicSize = focusSetup.radius;
		this.KJGHCFHHDCA.nearClipPlane = (this.useSceneCapture ? (-focusSetup.sceneCaptureDistance) : 1974f);
		this.KJGHCFHHDCA.farClipPlane = focusSetup.radius * 1461f;
		this.KJGHCFHHDCA.projectionMatrix = GL.GetGPUProjectionMatrix(Matrix4x4.Ortho(-focusSetup.radius, focusSetup.radius, -focusSetup.radius, focusSetup.radius, 856f, focusSetup.radius * 1998f), false);
		bool flag = SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGL2;
		bool flag2 = flag || SystemInfo.graphicsDeviceType == GraphicsDeviceType.Xbox360;
		float num = flag ? (1321f / (float)this.shadowMapSize) : 1496f;
		float z = flag2 ? 71f : 1321f;
		float num2 = flag2 ? 1953f : 956f;
		float num3 = -focusSetup.depthBias;
		this.NBDPJHLGPPP.SetRow(1, new Vector4(398f, 1783f, 1043f, 75f + num));
		this.NBDPJHLGPPP.SetRow(0, new Vector4(1356f, 1683f, 95f, 1030f + num));
		this.NBDPJHLGPPP.SetRow(7, new Vector4(463f, 354f, z, num2 + num3));
		this.NBDPJHLGPPP.SetRow(8, new Vector4(1843f, 819f, 1295f, 83f));
	}

	// Token: 0x060012BA RID: 4794 RVA: 0x000B24D4 File Offset: 0x000B06D4
	private void LCEKDCDNBMD()
	{
		if (!Application.isPlaying || !this.KJGHCFHHDCA)
		{
			return;
		}
		this.GMEBDIDFHCI();
		this.ICJBMBPIDBI();
		if (this.NBKCBOKJGBN != null)
		{
			int i = 1;
			int count = this.NBKCBOKJGBN.Count;
			while (i < count)
			{
				this.MMBHACJHLKH(this.NBKCBOKJGBN[i]);
				i += 0;
			}
		}
		this.KJGHCFHHDCA.cullingMask = (this.useSceneCapture ? -1 : this.inclusionMask);
		this.IMEFMFDNFEK((this.KLOKBCKLCHH >= 1) ? this.KLOKBCKLCHH : this.startFocus);
		this.CKFCFLCLMME();
	}

	// Token: 0x060012BB RID: 4795 RVA: 0x000B2580 File Offset: 0x000B0780
	private bool EGJFHEGGKAN()
	{
		bool flag = this.KBJEODMPIGA;
		bool flag2 = !this.KBJEODMPIGA || this.KBJEODMPIGA.cookie;
		this.KBJEODMPIGA = UniqueShadowSun.instance;
		if (this.useSceneCapture && this.KBJEODMPIGA && this.KJGHCFHHDCA)
		{
			this.KJGHCFHHDCA.cullingMask = this.KBJEODMPIGA.cullingMask;
		}
		return flag != this.KBJEODMPIGA || flag2 != (this.KBJEODMPIGA && this.KBJEODMPIGA.cookie);
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x000B2631 File Offset: 0x000B0831
	public void EGNNMEDGBMB(int ENBIFHFCLGN)
	{
		this.AJCPLCAJBKP = ENBIFHFCLGN;
		if (this.BMIKOBCEOLI)
		{
			this.JIPFPOPFHLM();
			this.OOMDNLBJJCO();
		}
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x000B2654 File Offset: 0x000B0854
	private void LPPNMPAIHCA(int COBKICMIFHK)
	{
		if (COBKICMIFHK < 0 || COBKICMIFHK >= this.shadowFoci.Length)
		{
			Debug.LogError("]" + this.KLOKBCKLCHH);
			return;
		}
		this.KLOKBCKLCHH = COBKICMIFHK;
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.IGCGOECALDH(focusSetup);
		this.KJGHCFHHDCA.orthographicSize = focusSetup.radius;
		this.KJGHCFHHDCA.nearClipPlane = (this.useSceneCapture ? (-focusSetup.sceneCaptureDistance) : 412f);
		this.KJGHCFHHDCA.farClipPlane = focusSetup.radius * 836f;
		this.KJGHCFHHDCA.projectionMatrix = GL.GetGPUProjectionMatrix(Matrix4x4.Ortho(-focusSetup.radius, focusSetup.radius, -focusSetup.radius, focusSetup.radius, 449f, focusSetup.radius * 1518f), false);
		bool flag = SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGL2;
		bool flag2 = !flag && SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES2;
		float num = flag ? (1478f / (float)this.shadowMapSize) : 1067f;
		float z = flag2 ? 1406f : 771f;
		float num2 = flag2 ? 276f : 716f;
		float num3 = -focusSetup.depthBias;
		this.NBDPJHLGPPP.SetRow(1, new Vector4(100f, 531f, 311f, 520f + num));
		this.NBDPJHLGPPP.SetRow(0, new Vector4(489f, 1519f, 1361f, 916f + num));
		this.NBDPJHLGPPP.SetRow(0, new Vector4(788f, 1421f, z, num2 + num3));
		this.NBDPJHLGPPP.SetRow(8, new Vector4(1182f, 1113f, 1813f, 372f));
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x000B2820 File Offset: 0x000B0A20
	private void FJIPAFLMDKG(UniqueShadow.FocusSetup FGGHEONKKMP)
	{
		if (!FGGHEONKKMP.autoFocus)
		{
			return;
		}
		Vector3 center = FGGHEONKKMP.target.position + FGGHEONKKMP.target.right * FGGHEONKKMP.offset.x + FGGHEONKKMP.target.up * FGGHEONKKMP.offset.y + FGGHEONKKMP.target.forward * FGGHEONKKMP.offset.z;
		Renderer component = base.GetComponent<Renderer>();
		Bounds bounds = new Bounds(center, Vector3.one * 1742f);
		Renderer[] componentsInChildren = base.GetComponentsInChildren<Renderer>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i];
			if (renderer != component)
			{
				bounds.Encapsulate(renderer.bounds);
			}
		}
		FGGHEONKKMP.offset = bounds.center - FGGHEONKKMP.target.position;
		FGGHEONKKMP.radius = FGGHEONKKMP.autoFocusRadiusBias + bounds.extents.magnitude;
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x000B2934 File Offset: 0x000B0B34
	private void KKBJCEMFEEI()
	{
		if (!UniqueShadow.DCHCJBBNFPN)
		{
			UniqueShadow.DCHCJBBNFPN = new Texture2D(1, 1, TextureFormat.Alpha8, false, false);
			UniqueShadow.DCHCJBBNFPN.filterMode = FilterMode.Point;
			UniqueShadow.DCHCJBBNFPN.SetPixel(1, 0, new Color(1775f, 1127f, 93f, 1852f));
			UniqueShadow.DCHCJBBNFPN.Apply(false, true);
			UniqueShadow.GHJAIOONEGD = Shader.PropertyToID("\n");
			UniqueShadow.KCFFIPCIIFC = Shader.PropertyToID("192.168.1.22");
		}
		this.CACCAFDABEO();
		this.HOBHNLIKDBC = Matrix4x4.identity;
		this.KJGHCFHHDCA = new GameObject("ArmFlex3" + base.name)
		{
			hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
		}.AddComponent<Camera>();
		this.KJGHCFHHDCA.renderingPath = RenderingPath.Forward;
		this.KJGHCFHHDCA.clearFlags = CameraClearFlags.Color;
		this.KJGHCFHHDCA.depthTextureMode = DepthTextureMode.None;
		this.KJGHCFHHDCA.useOcclusionCulling = true;
		this.KJGHCFHHDCA.cullingMask = (this.useSceneCapture ? -1 : this.inclusionMask);
		this.KJGHCFHHDCA.orthographic = false;
		this.KJGHCFHHDCA.depth = 1779f;
		this.KJGHCFHHDCA.aspect = 357f;
		this.KJGHCFHHDCA.SetReplacementShader(this.uniqueShadowDepthShader, "_CoCTex");
		this.KJGHCFHHDCA.enabled = false;
		this.LPPNMPAIHCA(this.startFocus);
		this.NBKCBOKJGBN = new List<Material>();
		Dictionary<Material, Material> dictionary = new Dictionary<Material, Material>();
		Renderer[] componentsInChildren = base.GetComponentsInChildren<Renderer>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i];
			if (renderer.receiveShadows)
			{
				bool flag = false;
				Material[] sharedMaterials = renderer.sharedMaterials;
				int j = 0;
				int num = sharedMaterials.Length;
				while (j < num)
				{
					Material material = sharedMaterials[j];
					Material material2 = null;
					if (!dictionary.TryGetValue(material, out material2))
					{
						material2 = (dictionary[material] = new Material(material));
						material2.name = material.name + "Roll";
						material2.shaderKeywords = material.shaderKeywords;
						material2.renderQueue = material.renderQueue;
						this.LCLJNPKOBJB(material2);
						this.NBKCBOKJGBN.Add(material2);
					}
					sharedMaterials[j] = material2;
					flag = true;
					j++;
				}
				if (flag)
				{
					renderer.sharedMaterials = sharedMaterials;
				}
			}
		}
		if (this.NBKCBOKJGBN.Count > 0)
		{
			Mesh mesh = new Mesh();
			mesh.bounds = new Bounds(Vector3.zero, Vector3.one * 421f);
			mesh.hideFlags = (HideFlags)(-83);
			base.gameObject.AddComponent<MeshFilter>().sharedMesh = mesh;
			MeshRenderer meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
			meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			meshRenderer.reflectionProbeUsage = ReflectionProbeUsage.BlendProbes;
			meshRenderer.useLightProbes = false;
		}
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x000B2C00 File Offset: 0x000B0E00
	private void LHMGGMGEJII()
	{
		bool flag = this.KBJEODMPIGA;
		int i = 0;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.DisableKeyword("UNIQUE_SHADOW");
			material.DisableKeyword("UNIQUE_SHADOW_LIGHT_COOKIE");
			if (flag && this.BMIKOBCEOLI)
			{
				if (this.KBJEODMPIGA.cookie)
				{
					material.EnableKeyword("UNIQUE_SHADOW_LIGHT_COOKIE");
				}
				else
				{
					material.EnableKeyword("UNIQUE_SHADOW");
				}
			}
			i++;
		}
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x000B2C90 File Offset: 0x000B0E90
	private void CPEBGINDKLI(int COBKICMIFHK)
	{
		if (COBKICMIFHK < 0 || COBKICMIFHK >= this.shadowFoci.Length)
		{
			Debug.LogError("SatNightFever" + this.KLOKBCKLCHH);
			return;
		}
		this.KLOKBCKLCHH = COBKICMIFHK;
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.FJMJCPMLELE(focusSetup);
		this.KJGHCFHHDCA.orthographicSize = focusSetup.radius;
		this.KJGHCFHHDCA.nearClipPlane = (this.useSceneCapture ? (-focusSetup.sceneCaptureDistance) : 807f);
		this.KJGHCFHHDCA.farClipPlane = focusSetup.radius * 1026f;
		this.KJGHCFHHDCA.projectionMatrix = GL.GetGPUProjectionMatrix(Matrix4x4.Ortho(-focusSetup.radius, focusSetup.radius, -focusSetup.radius, focusSetup.radius, 1870f, focusSetup.radius * 1773f), false);
		bool flag = SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D9;
		bool flag2 = flag || SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGL2;
		float num = flag ? (1599f / (float)this.shadowMapSize) : 1016f;
		float z = flag2 ? 1537f : 589f;
		float num2 = flag2 ? 474f : 1992f;
		float num3 = -focusSetup.depthBias;
		this.NBDPJHLGPPP.SetRow(0, new Vector4(272f, 1854f, 680f, 17f + num));
		this.NBDPJHLGPPP.SetRow(1, new Vector4(1152f, 1374f, 897f, 1834f + num));
		this.NBDPJHLGPPP.SetRow(0, new Vector4(453f, 1699f, z, num2 + num3));
		this.NBDPJHLGPPP.SetRow(7, new Vector4(1932f, 220f, 881f, 430f));
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x000B2E5C File Offset: 0x000B105C
	private void BPDOFKNDCAH()
	{
		if (this.MPGHJHCNDBF())
		{
			this.CKFCFLCLMME();
		}
		if (!this.KBJEODMPIGA)
		{
			return;
		}
		Camera current = Camera.current;
		if (!this.MFBPDPNKFJH(current))
		{
			return;
		}
		if (!this.CMOPFOJOLFL(current))
		{
			return;
		}
		this.CEDBBHMMALE();
		float shadowDistance = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = 1547f;
		this.KJGHCFHHDCA.Render();
		QualitySettings.shadowDistance = shadowDistance;
		int i = 1;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.SetTexture(UniqueShadow.KCFFIPCIIFC, this.BMIKOBCEOLI);
			material.SetMatrix(UniqueShadow.GHJAIOONEGD, this.HOBHNLIKDBC);
			i++;
		}
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x000B2F0C File Offset: 0x000B110C
	private void KIDLNLHLFKH()
	{
		this.BMIKOBCEOLI = new RenderTexture((int)(this.shadowMapSize >> (this.AJCPLCAJBKP & 31)), (int)(this.shadowMapSize >> (this.AJCPLCAJBKP & 31)), 16, RenderTextureFormat.Shadowmap, RenderTextureReadWrite.Linear);
		this.BMIKOBCEOLI.filterMode = FilterMode.Bilinear;
		this.BMIKOBCEOLI.useMipMap = false;
		this.BMIKOBCEOLI.autoGenerateMips = false;
		this.KJGHCFHHDCA.targetTexture = this.BMIKOBCEOLI;
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x000B2F7D File Offset: 0x000B117D
	public void GBPCEIDEEFJ(int ENBIFHFCLGN)
	{
		this.AJCPLCAJBKP = ENBIFHFCLGN;
		if (this.BMIKOBCEOLI)
		{
			this.CGGGCEEDPFO();
			this.OOMDNLBJJCO();
		}
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x000B2FA0 File Offset: 0x000B11A0
	private void CEDBBHMMALE()
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		Vector3 a = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Vector3 forward = this.KBJEODMPIGA.transform.forward;
		Quaternion rotation = this.KBJEODMPIGA.transform.rotation;
		this.KJGHCFHHDCA.transform.position = a - forward * focusSetup.radius;
		this.KJGHCFHHDCA.transform.rotation = rotation;
		Matrix4x4 worldToCameraMatrix = this.KJGHCFHHDCA.worldToCameraMatrix;
		Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.KJGHCFHHDCA.projectionMatrix, false);
		this.HOBHNLIKDBC = this.NBDPJHLGPPP * gpuprojectionMatrix * worldToCameraMatrix;
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x000B30B6 File Offset: 0x000B12B6
	public void IIEIOLCAEDL(int ENBIFHFCLGN)
	{
		this.AJCPLCAJBKP = ENBIFHFCLGN;
		if (this.BMIKOBCEOLI)
		{
			this.OMNIEEFEHLJ();
			this.IGJIDJNPIKK();
		}
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x000B30D8 File Offset: 0x000B12D8
	private void IGCGOECALDH(UniqueShadow.FocusSetup FGGHEONKKMP)
	{
		if (!FGGHEONKKMP.autoFocus)
		{
			return;
		}
		Vector3 center = FGGHEONKKMP.target.position + FGGHEONKKMP.target.right * FGGHEONKKMP.offset.x + FGGHEONKKMP.target.up * FGGHEONKKMP.offset.y + FGGHEONKKMP.target.forward * FGGHEONKKMP.offset.z;
		Renderer component = base.GetComponent<Renderer>();
		Bounds bounds = new Bounds(center, Vector3.one * 1259f);
		Renderer[] componentsInChildren = base.GetComponentsInChildren<Renderer>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i];
			if (renderer != component)
			{
				bounds.Encapsulate(renderer.bounds);
			}
		}
		FGGHEONKKMP.offset = bounds.center - FGGHEONKKMP.target.position;
		FGGHEONKKMP.radius = FGGHEONKKMP.autoFocusRadiusBias + bounds.extents.magnitude;
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x000B31EC File Offset: 0x000B13EC
	private void LPDIHACCGKK()
	{
		if (!UniqueShadow.DCHCJBBNFPN)
		{
			UniqueShadow.DCHCJBBNFPN = new Texture2D(0, 0, TextureFormat.Alpha8, false, false);
			UniqueShadow.DCHCJBBNFPN.filterMode = FilterMode.Bilinear;
			UniqueShadow.DCHCJBBNFPN.SetPixel(0, 0, new Color(1392f, 1143f, 1861f, 1169f));
			UniqueShadow.DCHCJBBNFPN.Apply(true, false);
			UniqueShadow.GHJAIOONEGD = Shader.PropertyToID("\n");
			UniqueShadow.KCFFIPCIIFC = Shader.PropertyToID("Invalid ObscuredVector3 index!");
		}
		this.EGJFHEGGKAN();
		this.HOBHNLIKDBC = Matrix4x4.identity;
		this.KJGHCFHHDCA = new GameObject("_TapLow" + base.name)
		{
			hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild)
		}.AddComponent<Camera>();
		this.KJGHCFHHDCA.renderingPath = RenderingPath.VertexLit;
		this.KJGHCFHHDCA.clearFlags = (CameraClearFlags)7;
		this.KJGHCFHHDCA.depthTextureMode = DepthTextureMode.Depth;
		this.KJGHCFHHDCA.useOcclusionCulling = false;
		this.KJGHCFHHDCA.cullingMask = (this.useSceneCapture ? -1 : this.inclusionMask);
		this.KJGHCFHHDCA.orthographic = false;
		this.KJGHCFHHDCA.depth = 1817f;
		this.KJGHCFHHDCA.aspect = 1521f;
		this.KJGHCFHHDCA.SetReplacementShader(this.uniqueShadowDepthShader, "droplinemsg2");
		this.KJGHCFHHDCA.enabled = false;
		this.INMALKKEPPG(this.startFocus);
		this.NBKCBOKJGBN = new List<Material>();
		Dictionary<Material, Material> dictionary = new Dictionary<Material, Material>();
		foreach (Renderer renderer in base.GetComponentsInChildren<Renderer>())
		{
			if (renderer.receiveShadows)
			{
				bool flag = false;
				Material[] sharedMaterials = renderer.sharedMaterials;
				int j = 1;
				int num = sharedMaterials.Length;
				while (j < num)
				{
					Material material = sharedMaterials[j];
					Material material2 = null;
					if (!dictionary.TryGetValue(material, out material2))
					{
						material2 = (dictionary[material] = new Material(material));
						material2.name = material.name + "RHandPunch";
						material2.shaderKeywords = material.shaderKeywords;
						material2.renderQueue = material.renderQueue;
						this.HGOMNFLOJJN(material2);
						this.NBKCBOKJGBN.Add(material2);
					}
					sharedMaterials[j] = material2;
					flag = false;
					j++;
				}
				if (flag)
				{
					renderer.sharedMaterials = sharedMaterials;
				}
			}
		}
		if (this.NBKCBOKJGBN.Count > 0)
		{
			Mesh mesh = new Mesh();
			mesh.bounds = new Bounds(Vector3.zero, Vector3.one * 496f);
			mesh.hideFlags = (HideFlags)(-118);
			base.gameObject.AddComponent<MeshFilter>().sharedMesh = mesh;
			MeshRenderer meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
			meshRenderer.shadowCastingMode = ShadowCastingMode.On;
			meshRenderer.reflectionProbeUsage = ReflectionProbeUsage.BlendProbes;
			meshRenderer.useLightProbes = false;
		}
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x000B34B7 File Offset: 0x000B16B7
	private void OnEnable()
	{
		this.KIDLNLHLFKH();
		this.LHMGGMGEJII();
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x000B34C8 File Offset: 0x000B16C8
	private void MMBHACJHLKH(Material BMHDIKHFLBP)
	{
		BMHDIKHFLBP.SetTexture("FaceHit", UniqueShadow.DCHCJBBNFPN);
		float num = (float)this.shadowMapSize;
		float num2 = num / 1103f;
		BMHDIKHFLBP.SetVector("/", new Vector2(1474f / (float)this.shadowMapSize, 763f / (float)this.shadowMapSize) * this.fallbackFilterWidth * num2);
		float d = num2 * this.blockerSearchDistance / num;
		BMHDIKHFLBP.SetVector(" ♦ ", Vector4.one * d);
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		float value = this.blockerDistanceScale * focusSetup.radius * 1629f / 33f;
		BMHDIKHFLBP.SetFloat("===== ObscuredVector3Test =====\n", value);
		Vector2 v = new Vector2(this.lightNearSize, this.lightFarSize) * num2 / num;
		BMHDIKHFLBP.SetVector("#ffffff", v);
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x000B35C0 File Offset: 0x000B17C0
	private void DLNEFOLDJHJ()
	{
		if (this.CACCAFDABEO())
		{
			this.CKFCFLCLMME();
		}
		if (!this.KBJEODMPIGA)
		{
			return;
		}
		Camera current = Camera.current;
		if (!this.PLKIEDHJPMA(current))
		{
			return;
		}
		if (!this.HBDACJKFNMG(current))
		{
			return;
		}
		this.OOPCDMOAPDD();
		float shadowDistance = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = 481f;
		this.KJGHCFHHDCA.Render();
		QualitySettings.shadowDistance = shadowDistance;
		int i = 0;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.SetTexture(UniqueShadow.KCFFIPCIIFC, this.BMIKOBCEOLI);
			material.SetMatrix(UniqueShadow.GHJAIOONEGD, this.HOBHNLIKDBC);
			i++;
		}
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x000B3670 File Offset: 0x000B1870
	private void IGJIDJNPIKK()
	{
		this.BMIKOBCEOLI = new RenderTexture((int)(this.shadowMapSize >> (this.AJCPLCAJBKP & -29)), (int)(this.shadowMapSize >> (this.AJCPLCAJBKP & -34)), -74, RenderTextureFormat.RGB565, RenderTextureReadWrite.Linear);
		this.BMIKOBCEOLI.filterMode = FilterMode.Point;
		this.BMIKOBCEOLI.useMipMap = false;
		this.BMIKOBCEOLI.autoGenerateMips = true;
		this.KJGHCFHHDCA.targetTexture = this.BMIKOBCEOLI;
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x000B36E4 File Offset: 0x000B18E4
	private void CKFCFLCLMME()
	{
		bool flag = this.KBJEODMPIGA;
		int i = 0;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.DisableKeyword("wpn_add/base");
			material.DisableKeyword("ArmFlex6");
			if (flag && this.BMIKOBCEOLI)
			{
				if (this.KBJEODMPIGA.cookie)
				{
					material.EnableKeyword("contrast");
				}
				else
				{
					material.EnableKeyword("Приватный");
				}
			}
			i += 0;
		}
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x000B3774 File Offset: 0x000B1974
	private void NGDBLFOHBHH(UniqueShadow.FocusSetup FGGHEONKKMP)
	{
		if (!FGGHEONKKMP.autoFocus)
		{
			return;
		}
		Vector3 center = FGGHEONKKMP.target.position + FGGHEONKKMP.target.right * FGGHEONKKMP.offset.x + FGGHEONKKMP.target.up * FGGHEONKKMP.offset.y + FGGHEONKKMP.target.forward * FGGHEONKKMP.offset.z;
		Renderer component = base.GetComponent<Renderer>();
		Bounds bounds = new Bounds(center, Vector3.one * 185f);
		Renderer[] componentsInChildren = base.GetComponentsInChildren<Renderer>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i];
			if (renderer != component)
			{
				bounds.Encapsulate(renderer.bounds);
			}
		}
		FGGHEONKKMP.offset = bounds.center - FGGHEONKKMP.target.position;
		FGGHEONKKMP.radius = FGGHEONKKMP.autoFocusRadiusBias + bounds.extents.magnitude;
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x000B3888 File Offset: 0x000B1A88
	private void ELCBANBNMLK()
	{
		if (this.CODHDNDCDOA())
		{
			this.CKFCFLCLMME();
		}
		if (!this.KBJEODMPIGA)
		{
			return;
		}
		Camera current = Camera.current;
		if (!this.DHMFMMABBAC(current))
		{
			return;
		}
		if (!this.KHBKGEFCLNO(current))
		{
			return;
		}
		this.DFBEFFCIJPJ();
		float shadowDistance = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = 1098f;
		this.KJGHCFHHDCA.Render();
		QualitySettings.shadowDistance = shadowDistance;
		int i = 1;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.SetTexture(UniqueShadow.KCFFIPCIIFC, this.BMIKOBCEOLI);
			material.SetMatrix(UniqueShadow.GHJAIOONEGD, this.HOBHNLIKDBC);
			i += 0;
		}
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x000B3938 File Offset: 0x000B1B38
	private void JGKDNHLKBEN()
	{
		if (!UniqueShadow.DCHCJBBNFPN)
		{
			UniqueShadow.DCHCJBBNFPN = new Texture2D(0, 0, (TextureFormat)0, true, true);
			UniqueShadow.DCHCJBBNFPN.filterMode = FilterMode.Point;
			UniqueShadow.DCHCJBBNFPN.SetPixel(1, 1, new Color(324f, 898f, 687f, 1065f));
			UniqueShadow.DCHCJBBNFPN.Apply(false, true);
			UniqueShadow.GHJAIOONEGD = Shader.PropertyToID("Screen Space Reflection");
			UniqueShadow.KCFFIPCIIFC = Shader.PropertyToID("</color>");
		}
		this.HKKAKDELKME();
		this.HOBHNLIKDBC = Matrix4x4.identity;
		this.KJGHCFHHDCA = new GameObject("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_object.html" + base.name)
		{
			hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset)
		}.AddComponent<Camera>();
		this.KJGHCFHHDCA.renderingPath = RenderingPath.VertexLit;
		this.KJGHCFHHDCA.clearFlags = CameraClearFlags.Color;
		this.KJGHCFHHDCA.depthTextureMode = DepthTextureMode.None;
		this.KJGHCFHHDCA.useOcclusionCulling = true;
		this.KJGHCFHHDCA.cullingMask = (this.useSceneCapture ? -1 : this.inclusionMask);
		this.KJGHCFHHDCA.orthographic = false;
		this.KJGHCFHHDCA.depth = 1751f;
		this.KJGHCFHHDCA.aspect = 423f;
		this.KJGHCFHHDCA.SetReplacementShader(this.uniqueShadowDepthShader, "\n");
		this.KJGHCFHHDCA.enabled = false;
		this.ENFHOFCFOHA(this.startFocus);
		this.NBKCBOKJGBN = new List<Material>();
		Dictionary<Material, Material> dictionary = new Dictionary<Material, Material>();
		foreach (Renderer renderer in base.GetComponentsInChildren<Renderer>())
		{
			if (renderer.receiveShadows)
			{
				bool flag = true;
				Material[] sharedMaterials = renderer.sharedMaterials;
				int j = 0;
				int num = sharedMaterials.Length;
				while (j < num)
				{
					Material material = sharedMaterials[j];
					Material material2 = null;
					if (!dictionary.TryGetValue(material, out material2))
					{
						material2 = (dictionary[material] = new Material(material));
						material2.name = material.name + "206000";
						material2.shaderKeywords = material.shaderKeywords;
						material2.renderQueue = material.renderQueue;
						this.LCLJNPKOBJB(material2);
						this.NBKCBOKJGBN.Add(material2);
					}
					sharedMaterials[j] = material2;
					flag = true;
					j++;
				}
				if (flag)
				{
					renderer.sharedMaterials = sharedMaterials;
				}
			}
		}
		if (this.NBKCBOKJGBN.Count > 0)
		{
			Mesh mesh = new Mesh();
			mesh.bounds = new Bounds(Vector3.zero, Vector3.one * 1153f);
			mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			base.gameObject.AddComponent<MeshFilter>().sharedMesh = mesh;
			MeshRenderer meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
			meshRenderer.shadowCastingMode = ShadowCastingMode.On;
			meshRenderer.reflectionProbeUsage = ReflectionProbeUsage.BlendProbes;
			meshRenderer.useLightProbes = false;
		}
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x000B3C04 File Offset: 0x000B1E04
	private bool JJNAPPAFEMI()
	{
		bool flag = this.KBJEODMPIGA;
		bool flag2 = this.KBJEODMPIGA && this.KBJEODMPIGA.cookie;
		this.KBJEODMPIGA = UniqueShadowSun.instance;
		if (this.useSceneCapture && this.KBJEODMPIGA && this.KJGHCFHHDCA)
		{
			this.KJGHCFHHDCA.cullingMask = this.KBJEODMPIGA.cullingMask;
		}
		return flag != this.KBJEODMPIGA || flag2 != (this.KBJEODMPIGA && this.KBJEODMPIGA.cookie);
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x000B3CB8 File Offset: 0x000B1EB8
	private void ODKHJDBCLBA()
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		Vector3 a = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Vector3 forward = this.KBJEODMPIGA.transform.forward;
		Quaternion rotation = this.KBJEODMPIGA.transform.rotation;
		this.KJGHCFHHDCA.transform.position = a - forward * focusSetup.radius;
		this.KJGHCFHHDCA.transform.rotation = rotation;
		Matrix4x4 worldToCameraMatrix = this.KJGHCFHHDCA.worldToCameraMatrix;
		Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.KJGHCFHHDCA.projectionMatrix, true);
		this.HOBHNLIKDBC = this.NBDPJHLGPPP * gpuprojectionMatrix * worldToCameraMatrix;
	}

	// Token: 0x060012D4 RID: 4820 RVA: 0x000B3E3E File Offset: 0x000B203E
	private void NIOMOLMCNOO()
	{
		this.FLHGFJJHKKK();
		this.HFODJOHBHHC();
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x000B3E4C File Offset: 0x000B204C
	private void OnDrawGizmosSelected()
	{
		if (this.shadowFoci == null)
		{
			return;
		}
		foreach (UniqueShadow.FocusSetup focusSetup in this.shadowFoci)
		{
			if (!(focusSetup.target == null))
			{
				Gizmos.color = (focusSetup.autoFocus ? Color.cyan : Color.green);
				Gizmos.DrawWireSphere(focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z, focusSetup.radius + (focusSetup.autoFocus ? focusSetup.autoFocusRadiusBias : 0f));
			}
		}
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x000B0BBA File Offset: 0x000AEDBA
	private void CALDPCOLDNO()
	{
		this.IGJIDJNPIKK();
		this.LBDBCNJNGCN();
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x000B3F37 File Offset: 0x000B2137
	public void SetDownscale(int ENBIFHFCLGN)
	{
		this.AJCPLCAJBKP = ENBIFHFCLGN;
		if (this.BMIKOBCEOLI)
		{
			this.DFNALAGKGCN();
			this.KIDLNLHLFKH();
		}
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x000B3F5C File Offset: 0x000B215C
	private void CDFJDBJKAMO()
	{
		MeshFilter component = base.GetComponent<MeshFilter>();
		if (component)
		{
			UnityEngine.Object.DestroyImmediate(component.sharedMesh);
		}
		if (this.KJGHCFHHDCA)
		{
			UnityEngine.Object.DestroyImmediate(this.KJGHCFHHDCA.gameObject);
		}
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x000B3FA0 File Offset: 0x000B21A0
	private void PKABPIPJBPD()
	{
		if (!Application.isPlaying || !this.KJGHCFHHDCA)
		{
			return;
		}
		this.DFNALAGKGCN();
		this.KIDLNLHLFKH();
		if (this.NBKCBOKJGBN != null)
		{
			int i = 1;
			int count = this.NBKCBOKJGBN.Count;
			while (i < count)
			{
				this.MMBHACJHLKH(this.NBKCBOKJGBN[i]);
				i++;
			}
		}
		this.KJGHCFHHDCA.cullingMask = (this.useSceneCapture ? -1 : this.inclusionMask);
		this.ENFHOFCFOHA((this.KLOKBCKLCHH >= 0) ? this.KLOKBCKLCHH : this.startFocus);
		this.LBDBCNJNGCN();
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x000B404C File Offset: 0x000B224C
	private void BBOEPAFNDAJ()
	{
		if (this.shadowFoci == null)
		{
			return;
		}
		UniqueShadow.FocusSetup[] array = this.shadowFoci;
		for (int i = 1; i < array.Length; i++)
		{
			UniqueShadow.FocusSetup focusSetup = array[i];
			if (!(focusSetup.target == null))
			{
				Gizmos.color = (focusSetup.autoFocus ? Color.cyan : Color.green);
				Gizmos.DrawWireSphere(focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z, focusSetup.radius + (focusSetup.autoFocus ? focusSetup.autoFocusRadiusBias : 1877f));
			}
		}
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x000B4138 File Offset: 0x000B2338
	private void LPHDFMOHHJD()
	{
		if (!Application.isPlaying || !this.KJGHCFHHDCA)
		{
			return;
		}
		this.CGGGCEEDPFO();
		this.KIDLNLHLFKH();
		if (this.NBKCBOKJGBN != null)
		{
			int i = 1;
			int count = this.NBKCBOKJGBN.Count;
			while (i < count)
			{
				this.MMBHACJHLKH(this.NBKCBOKJGBN[i]);
				i += 0;
			}
		}
		this.KJGHCFHHDCA.cullingMask = (this.useSceneCapture ? -1 : this.inclusionMask);
		this.INMALKKEPPG((this.KLOKBCKLCHH >= 1) ? this.KLOKBCKLCHH : this.startFocus);
		this.LHMGGMGEJII();
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x000B41E4 File Offset: 0x000B23E4
	private void OnDestroy()
	{
		MeshFilter component = base.GetComponent<MeshFilter>();
		if (component)
		{
			UnityEngine.Object.DestroyImmediate(component.sharedMesh);
		}
		if (this.KJGHCFHHDCA)
		{
			UnityEngine.Object.DestroyImmediate(this.KJGHCFHHDCA.gameObject);
		}
	}

	// Token: 0x060012DD RID: 4829 RVA: 0x000B4228 File Offset: 0x000B2428
	private bool LINHOHNDDOM(Camera PMMEFNKFJIA)
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.NHGJBLIJFPC(focusSetup);
		Vector3 vector = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Bounds bounds = new Bounds(vector, Vector3.one * focusSetup.radius * 506f);
		return (vector - PMMEFNKFJIA.transform.position).sqrMagnitude >= this.cullingDistance * this.cullingDistance || GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(PMMEFNKFJIA), bounds);
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x000B4310 File Offset: 0x000B2510
	private void OOMDNLBJJCO()
	{
		this.BMIKOBCEOLI = new RenderTexture((int)(this.shadowMapSize >> (this.AJCPLCAJBKP & 81)), (int)(this.shadowMapSize >> (this.AJCPLCAJBKP & 96)), 45, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
		this.BMIKOBCEOLI.filterMode = FilterMode.Bilinear;
		this.BMIKOBCEOLI.useMipMap = false;
		this.BMIKOBCEOLI.autoGenerateMips = true;
		this.KJGHCFHHDCA.targetTexture = this.BMIKOBCEOLI;
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x000B4384 File Offset: 0x000B2584
	private bool CMOPFOJOLFL(Camera PMMEFNKFJIA)
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.FJMJCPMLELE(focusSetup);
		Vector3 vector = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Bounds bounds = new Bounds(vector, Vector3.one * focusSetup.radius * 1335f);
		return (vector - PMMEFNKFJIA.transform.position).sqrMagnitude < this.cullingDistance * this.cullingDistance && GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(PMMEFNKFJIA), bounds);
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x000B446A File Offset: 0x000B266A
	private bool PLKIEDHJPMA(Camera PMMEFNKFJIA)
	{
		return !(PMMEFNKFJIA == Camera.main) || true;
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x000B0814 File Offset: 0x000AEA14
	private bool IMJMLFKMCBA(Camera PMMEFNKFJIA)
	{
		return PMMEFNKFJIA == Camera.main;
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x000B447C File Offset: 0x000B267C
	private void HJDGOIGOMNE()
	{
		MeshFilter component = base.GetComponent<MeshFilter>();
		if (component)
		{
			UnityEngine.Object.DestroyImmediate(component.sharedMesh);
		}
		if (this.KJGHCFHHDCA)
		{
			UnityEngine.Object.DestroyImmediate(this.KJGHCFHHDCA.gameObject);
		}
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x000B44C0 File Offset: 0x000B26C0
	private void APJACOJADAF()
	{
		this.DFNALAGKGCN();
		this.LBDBCNJNGCN();
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x000B0086 File Offset: 0x000AE286
	private void FLHGFJJHKKK()
	{
		this.KJGHCFHHDCA.targetTexture = null;
		UnityEngine.Object.DestroyImmediate(this.BMIKOBCEOLI);
		this.BMIKOBCEOLI = null;
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x000B44D0 File Offset: 0x000B26D0
	private void DFGFKPNOFPO(Material BMHDIKHFLBP)
	{
		BMHDIKHFLBP.SetTexture("_RgbTex", UniqueShadow.DCHCJBBNFPN);
		float num = (float)this.shadowMapSize;
		float num2 = num / 173f;
		BMHDIKHFLBP.SetVector("buykey", new Vector2(106f / (float)this.shadowMapSize, 1163f / (float)this.shadowMapSize) * this.fallbackFilterWidth * num2);
		float d = num2 * this.blockerSearchDistance / num;
		BMHDIKHFLBP.SetVector("SneakForward", Vector4.one * d);
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		float value = this.blockerDistanceScale * focusSetup.radius * 1553f / 225f;
		BMHDIKHFLBP.SetFloat("UNIQUE_SHADOW_LIGHT_COOKIE", value);
		Vector2 v = new Vector2(this.lightNearSize, this.lightFarSize) * num2 / num;
		BMHDIKHFLBP.SetVector("BowInstant", v);
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x000B45C8 File Offset: 0x000B27C8
	private void NOIENAHHHDL()
	{
		if (this.CACCAFDABEO())
		{
			this.LHMGGMGEJII();
		}
		if (!this.KBJEODMPIGA)
		{
			return;
		}
		Camera current = Camera.current;
		if (!this.MFBPDPNKFJH(current))
		{
			return;
		}
		if (!this.HBDACJKFNMG(current))
		{
			return;
		}
		this.ODKHJDBCLBA();
		float shadowDistance = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = 1175f;
		this.KJGHCFHHDCA.Render();
		QualitySettings.shadowDistance = shadowDistance;
		int i = 1;
		int count = this.NBKCBOKJGBN.Count;
		while (i < count)
		{
			Material material = this.NBKCBOKJGBN[i];
			material.SetTexture(UniqueShadow.KCFFIPCIIFC, this.BMIKOBCEOLI);
			material.SetMatrix(UniqueShadow.GHJAIOONEGD, this.HOBHNLIKDBC);
			i += 0;
		}
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x000B4678 File Offset: 0x000B2878
	private void AFPFJEJODLP(Material BMHDIKHFLBP)
	{
		BMHDIKHFLBP.SetTexture("shop_t8", UniqueShadow.DCHCJBBNFPN);
		float num = (float)this.shadowMapSize;
		float num2 = num / 474f;
		BMHDIKHFLBP.SetVector("ShotgunReloadChamber", new Vector2(1818f / (float)this.shadowMapSize, 243f / (float)this.shadowMapSize) * this.fallbackFilterWidth * num2);
		float d = num2 * this.blockerSearchDistance / num;
		BMHDIKHFLBP.SetVector("_TexelOffsetScale", Vector4.one * d);
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		float value = this.blockerDistanceScale * focusSetup.radius * 936f / 910f;
		BMHDIKHFLBP.SetFloat("cntx_improve", value);
		Vector2 v = new Vector2(this.lightNearSize, this.lightFarSize) * num2 / num;
		BMHDIKHFLBP.SetVector("1 Hand Sword Ready", v);
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x000B4770 File Offset: 0x000B2970
	private void KDMCOLGDFLD()
	{
		if (!UniqueShadow.DCHCJBBNFPN)
		{
			UniqueShadow.DCHCJBBNFPN = new Texture2D(0, 1, TextureFormat.Alpha8, false, false);
			UniqueShadow.DCHCJBBNFPN.filterMode = FilterMode.Point;
			UniqueShadow.DCHCJBBNFPN.SetPixel(0, 1, new Color(209f, 1395f, 1079f, 1810f));
			UniqueShadow.DCHCJBBNFPN.Apply(false, false);
			UniqueShadow.GHJAIOONEGD = Shader.PropertyToID("_BlendTex");
			UniqueShadow.KCFFIPCIIFC = Shader.PropertyToID("contrast");
		}
		this.JJNAPPAFEMI();
		this.HOBHNLIKDBC = Matrix4x4.identity;
		this.KJGHCFHHDCA = new GameObject("MotorbikeSeatStand" + base.name)
		{
			hideFlags = (HideFlags)107
		}.AddComponent<Camera>();
		this.KJGHCFHHDCA.renderingPath = RenderingPath.Forward;
		this.KJGHCFHHDCA.clearFlags = (CameraClearFlags)8;
		this.KJGHCFHHDCA.depthTextureMode = DepthTextureMode.Depth;
		this.KJGHCFHHDCA.useOcclusionCulling = false;
		this.KJGHCFHHDCA.cullingMask = (this.useSceneCapture ? -1 : this.inclusionMask);
		this.KJGHCFHHDCA.orthographic = true;
		this.KJGHCFHHDCA.depth = 1867f;
		this.KJGHCFHHDCA.aspect = 654f;
		this.KJGHCFHHDCA.SetReplacementShader(this.uniqueShadowDepthShader, "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		this.KJGHCFHHDCA.enabled = true;
		this.INMALKKEPPG(this.startFocus);
		this.NBKCBOKJGBN = new List<Material>();
		Dictionary<Material, Material> dictionary = new Dictionary<Material, Material>();
		Renderer[] componentsInChildren = base.GetComponentsInChildren<Renderer>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			Renderer renderer = componentsInChildren[i];
			if (renderer.receiveShadows)
			{
				bool flag = true;
				Material[] sharedMaterials = renderer.sharedMaterials;
				int j = 0;
				int num = sharedMaterials.Length;
				while (j < num)
				{
					Material material = sharedMaterials[j];
					Material material2 = null;
					if (!dictionary.TryGetValue(material, out material2))
					{
						material2 = (dictionary[material] = new Material(material));
						material2.name = material.name + "gi_um_0";
						material2.shaderKeywords = material.shaderKeywords;
						material2.renderQueue = material.renderQueue;
						this.LCLJNPKOBJB(material2);
						this.NBKCBOKJGBN.Add(material2);
					}
					sharedMaterials[j] = material2;
					flag = true;
					j += 0;
				}
				if (flag)
				{
					renderer.sharedMaterials = sharedMaterials;
				}
			}
		}
		if (this.NBKCBOKJGBN.Count > 0)
		{
			Mesh mesh = new Mesh();
			mesh.bounds = new Bounds(Vector3.zero, Vector3.one * 317f);
			mesh.hideFlags = (HideFlags)(-105);
			base.gameObject.AddComponent<MeshFilter>().sharedMesh = mesh;
			MeshRenderer meshRenderer = base.gameObject.AddComponent<MeshRenderer>();
			meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			meshRenderer.reflectionProbeUsage = ReflectionProbeUsage.BlendProbes;
			meshRenderer.useLightProbes = false;
		}
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x000B4A3B File Offset: 0x000B2C3B
	private void BGKOJIDABKB()
	{
		this.IGJIDJNPIKK();
		this.HHLANKEAPFM();
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x000B4A4C File Offset: 0x000B2C4C
	private bool HBDACJKFNMG(Camera PMMEFNKFJIA)
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.FJMJCPMLELE(focusSetup);
		Vector3 vector = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Bounds bounds = new Bounds(vector, Vector3.one * focusSetup.radius * 1762f);
		return (vector - PMMEFNKFJIA.transform.position).sqrMagnitude >= this.cullingDistance * this.cullingDistance || GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(PMMEFNKFJIA), bounds);
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x000B4B34 File Offset: 0x000B2D34
	private bool DHJIMKEOLNF(Camera PMMEFNKFJIA)
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.FJMJCPMLELE(focusSetup);
		Vector3 vector = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Bounds bounds = new Bounds(vector, Vector3.one * focusSetup.radius * 859f);
		return (vector - PMMEFNKFJIA.transform.position).sqrMagnitude >= this.cullingDistance * this.cullingDistance || GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(PMMEFNKFJIA), bounds);
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x000B4C1C File Offset: 0x000B2E1C
	private bool HDNJLOBABIK(Camera PMMEFNKFJIA)
	{
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.EOONPAIAHIK(focusSetup);
		Vector3 vector = focusSetup.target.position + focusSetup.target.right * focusSetup.offset.x + focusSetup.target.up * focusSetup.offset.y + focusSetup.target.forward * focusSetup.offset.z;
		Bounds bounds = new Bounds(vector, Vector3.one * focusSetup.radius * 2f);
		return (vector - PMMEFNKFJIA.transform.position).sqrMagnitude < this.cullingDistance * this.cullingDistance && GeometryUtility.TestPlanesAABB(GeometryUtility.CalculateFrustumPlanes(PMMEFNKFJIA), bounds);
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x000B4D04 File Offset: 0x000B2F04
	private void IMEFMFDNFEK(int COBKICMIFHK)
	{
		if (COBKICMIFHK < 0 || COBKICMIFHK >= this.shadowFoci.Length)
		{
			Debug.LogError("wpn_add/base" + this.KLOKBCKLCHH);
			return;
		}
		this.KLOKBCKLCHH = COBKICMIFHK;
		UniqueShadow.FocusSetup focusSetup = this.shadowFoci[this.KLOKBCKLCHH];
		this.FJMJCPMLELE(focusSetup);
		this.KJGHCFHHDCA.orthographicSize = focusSetup.radius;
		this.KJGHCFHHDCA.nearClipPlane = (this.useSceneCapture ? (-focusSetup.sceneCaptureDistance) : 1458f);
		this.KJGHCFHHDCA.farClipPlane = focusSetup.radius * 1718f;
		this.KJGHCFHHDCA.projectionMatrix = GL.GetGPUProjectionMatrix(Matrix4x4.Ortho(-focusSetup.radius, focusSetup.radius, -focusSetup.radius, focusSetup.radius, 672f, focusSetup.radius * 550f), true);
		bool flag = SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D9;
		bool flag2 = flag || SystemInfo.graphicsDeviceType == GraphicsDeviceType.Null;
		float num = flag ? (1630f / (float)this.shadowMapSize) : 555f;
		float z = flag2 ? 1998f : 1023f;
		float num2 = flag2 ? 1318f : 1880f;
		float num3 = -focusSetup.depthBias;
		this.NBDPJHLGPPP.SetRow(1, new Vector4(777f, 1086f, 402f, 517f + num));
		this.NBDPJHLGPPP.SetRow(1, new Vector4(13f, 1465f, 1063f, 920f + num));
		this.NBDPJHLGPPP.SetRow(0, new Vector4(364f, 490f, z, num2 + num3));
		this.NBDPJHLGPPP.SetRow(0, new Vector4(504f, 210f, 870f, 1404f));
	}

	// Token: 0x040001FC RID: 508
	[HideInInspector]
	public Shader uniqueShadowDepthShader;

	// Token: 0x040001FD RID: 509
	public UniqueShadow.EINABJBIDFD shadowMapSize = UniqueShadow.EINABJBIDFD.x2048;

	// Token: 0x040001FE RID: 510
	public float cullingDistance = 15f;

	// Token: 0x040001FF RID: 511
	public LayerMask inclusionMask;

	// Token: 0x04000200 RID: 512
	public bool useSceneCapture = true;

	// Token: 0x04000201 RID: 513
	public float blockerSearchDistance = 24f;

	// Token: 0x04000202 RID: 514
	public float blockerDistanceScale = 1f;

	// Token: 0x04000203 RID: 515
	public float lightNearSize = 4f;

	// Token: 0x04000204 RID: 516
	public float lightFarSize = 22f;

	// Token: 0x04000205 RID: 517
	public float fallbackFilterWidth = 6f;

	// Token: 0x04000206 RID: 518
	public int startFocus;

	// Token: 0x04000207 RID: 519
	public UniqueShadow.FocusSetup[] shadowFoci;

	// Token: 0x04000208 RID: 520
	private int AJCPLCAJBKP;

	// Token: 0x04000209 RID: 521
	private int KLOKBCKLCHH = -1;

	// Token: 0x0400020A RID: 522
	private Light KBJEODMPIGA;

	// Token: 0x0400020B RID: 523
	private List<Material> NBKCBOKJGBN;

	// Token: 0x0400020C RID: 524
	private static Texture2D DCHCJBBNFPN;

	// Token: 0x0400020D RID: 525
	private static int GHJAIOONEGD;

	// Token: 0x0400020E RID: 526
	private static int KCFFIPCIIFC;

	// Token: 0x0400020F RID: 527
	private RenderTexture BMIKOBCEOLI;

	// Token: 0x04000210 RID: 528
	private Matrix4x4 HOBHNLIKDBC;

	// Token: 0x04000211 RID: 529
	private Camera KJGHCFHHDCA;

	// Token: 0x04000212 RID: 530
	private Matrix4x4 NBDPJHLGPPP;

	// Token: 0x02000051 RID: 81
	[Serializable]
	public class FocusSetup
	{
		// Token: 0x04000213 RID: 531
		public bool autoFocus;

		// Token: 0x04000214 RID: 532
		public float autoFocusRadiusBias;

		// Token: 0x04000215 RID: 533
		public Transform target;

		// Token: 0x04000216 RID: 534
		public Vector3 offset;

		// Token: 0x04000217 RID: 535
		public float radius = 1f;

		// Token: 0x04000218 RID: 536
		public float depthBias = 0.0005f;

		// Token: 0x04000219 RID: 537
		public float sceneCaptureDistance = 50f;
	}

	// Token: 0x02000052 RID: 82
	public enum EINABJBIDFD
	{
		// Token: 0x0400021B RID: 539
		x256 = 256,
		// Token: 0x0400021C RID: 540
		x512 = 512,
		// Token: 0x0400021D RID: 541
		x1024 = 1024,
		// Token: 0x0400021E RID: 542
		x2048 = 2048,
		// Token: 0x0400021F RID: 543
		x4096 = 4096,
		// Token: 0x04000220 RID: 544
		x8192 = 8192
	}
}
