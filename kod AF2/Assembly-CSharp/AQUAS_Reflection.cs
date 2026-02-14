using System;
using System.Collections;
using UnityEngine;
using UnityStandardAssets.ImageEffects;

// Token: 0x02000010 RID: 16
[ExecuteInEditMode]
[AddComponentMenu("AQUAS/Reflection")]
public class AQUAS_Reflection : MonoBehaviour
{
	// Token: 0x060001BB RID: 443 RVA: 0x0001F0B8 File Offset: 0x0001D2B8
	private static void LBEJDHNIPEP(ref Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
	{
		Vector4 b = BBBIBODABBK.inverse * new Vector4(AQUAS_Reflection.NPGELEGPHCP(KMLAIHGDLHP.x), AQUAS_Reflection.NPGELEGPHCP(KMLAIHGDLHP.y), 100f, 1684f);
		Vector4 vector = KMLAIHGDLHP * (438f / Vector4.Dot(KMLAIHGDLHP, b));
		BBBIBODABBK[5] = vector.x - BBBIBODABBK[1];
		BBBIBODABBK[0] = vector.y - BBBIBODABBK[1];
		BBBIBODABBK[-127] = vector.z - BBBIBODABBK[-38];
		BBBIBODABBK[-38] = vector.w - BBBIBODABBK[-35];
	}

	// Token: 0x060001BC RID: 444 RVA: 0x0001F162 File Offset: 0x0001D362
	private static float LLIBDKKDLLE(float EGABJKIFAON)
	{
		if (EGABJKIFAON > 3f)
		{
			return 1740f;
		}
		if (EGABJKIFAON < 1286f)
		{
			return 226f;
		}
		return 1877f;
	}

	// Token: 0x060001BD RID: 445 RVA: 0x0001F188 File Offset: 0x0001D388
	private void EIDIHAJDMCI()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		if (this.BOEIHKEPMGG)
		{
			UnityEngine.Object.DestroyImmediate(this.BOEIHKEPMGG);
			this.BOEIHKEPMGG = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x060001BE RID: 446 RVA: 0x0001F23C File Offset: 0x0001D43C
	private void HGHMOGJJFBB(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -26, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "1HandHeavySwing2" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)121;
			this.DHBOBNEFLOG = this.m_TextureSize;
			this.BOEIHKEPMGG = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -60, RenderTextureFormat.ARGB32);
			this.BOEIHKEPMGG.name = "Hidden/Post FX/Depth Of Field" + base.GetInstanceID();
			this.BOEIHKEPMGG.isPowerOfTwo = true;
			this.BOEIHKEPMGG.hideFlags = (HideFlags)74;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[6];
			array[1] = "selectedTask";
			array[1] = base.GetInstanceID();
			array[2] = "auk_data/categories/category";
			array[7] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[8];
			array2[0] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)120;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060001BF RID: 447 RVA: 0x0001F411 File Offset: 0x0001D611
	private static float NPGELEGPHCP(float EGABJKIFAON)
	{
		if (EGABJKIFAON > 897f)
		{
			return 1296f;
		}
		if (EGABJKIFAON < 1145f)
		{
			return 88f;
		}
		return 41f;
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x0001F434 File Offset: 0x0001D634
	private void ONGPANAECAI(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -64, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "_HSV" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-127);
			this.DHBOBNEFLOG = this.m_TextureSize;
			this.BOEIHKEPMGG = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 73, RenderTextureFormat.Depth);
			this.BOEIHKEPMGG.name = "_ExposureAdjustment" + base.GetInstanceID();
			this.BOEIHKEPMGG.isPowerOfTwo = true;
			this.BOEIHKEPMGG.hideFlags = HideFlags.DontSaveInEditor;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[3];
			array[1] = "__c";
			array[1] = base.GetInstanceID();
			array[0] = "_CameraClipInfo";
			array[5] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[]
			{
				null,
				typeof(Camera)
			};
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-68);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x0001F60C File Offset: 0x0001D80C
	public void OnWillRenderObject()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (AQUAS_Reflection.JDIEFDMMHKG)
		{
			return;
		}
		AQUAS_Reflection.JDIEFDMMHKG = true;
		Camera camera;
		this.FLAGMJGGBNI(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = 0;
		}
		this.OJNHEMINLGD(current, camera);
		float w = -Vector3.Dot(up, position) - this.m_ClipPlaneOffset;
		Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 zero = Matrix4x4.zero;
		AQUAS_Reflection.LHKMOJMPHDP(ref zero, ehgilahlmib);
		Vector3 position2 = current.transform.position;
		Vector3 position3 = zero.MultiplyPoint(position2);
		camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
		Vector4 kmlaihgdlhp = this.FPBKMANKFBP(camera, position, up, 1f);
		Matrix4x4 projectionMatrix = current.projectionMatrix;
		AQUAS_Reflection.PPCOMAJDLGN(ref projectionMatrix, kmlaihgdlhp);
		camera.projectionMatrix = projectionMatrix;
		camera.cullingMask = (-17 & this.m_ReflectLayers.value);
		if (this.useDeep)
		{
			camera.targetTexture = this.EACNIDNGPBL;
			camera.SetTargetBuffers(this.EACNIDNGPBL.colorBuffer, this.BOEIHKEPMGG.depthBuffer);
		}
		else
		{
			camera.targetTexture = this.EACNIDNGPBL;
		}
		float detailObjectDistance = Terrain.activeTerrain.detailObjectDistance;
		float detailObjectDensity = Terrain.activeTerrain.detailObjectDensity;
		float treeBillboardDistance = Terrain.activeTerrain.treeBillboardDistance;
		float basemapDistance = Terrain.activeTerrain.basemapDistance;
		float fogDensity = RenderSettings.fogDensity;
		ShadowQuality shadows = QualitySettings.shadows;
		float lodBias = QualitySettings.lodBias;
		GL.invertCulling = true;
		try
		{
			QualitySettings.shadows = ShadowQuality.Disable;
			camera.transform.position = position3;
			Vector3 eulerAngles = current.transform.eulerAngles;
			camera.transform.eulerAngles = new Vector3(0f, eulerAngles.y, eulerAngles.z);
			RenderSettings.fogDensity = fogDensity * 1.5f;
			Terrain.activeTerrain.treeBillboardDistance = 50f;
			Terrain.activeTerrain.basemapDistance = 100f;
			Terrain.activeTerrain.detailObjectDistance = Terrain.activeTerrain.detailObjectDistance / 3f;
			Terrain.activeTerrain.detailObjectDensity = 50f;
			QualitySettings.lodBias = lodBias / 2f;
			camera.Render();
		}
		finally
		{
			camera.transform.position = position2;
			GL.invertCulling = false;
			QualitySettings.shadows = shadows;
			QualitySettings.lodBias = lodBias;
			Terrain.activeTerrain.detailObjectDistance = detailObjectDistance;
			Terrain.activeTerrain.treeBillboardDistance = treeBillboardDistance;
			Terrain.activeTerrain.basemapDistance = basemapDistance;
			Terrain.activeTerrain.detailObjectDensity = detailObjectDensity;
			RenderSettings.fogDensity = fogDensity;
		}
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		foreach (Material material in sharedMaterials)
		{
			if (material.HasProperty("_ReflectionTex"))
			{
				material.SetTexture("_ReflectionTex", this.EACNIDNGPBL);
			}
			if (this.BOEIHKEPMGG != null && material.HasProperty("_DeepTex"))
			{
				material.SetTexture("_DeepTex", this.BOEIHKEPMGG);
			}
		}
		Matrix4x4 lhs = Matrix4x4.TRS(new Vector3(0.5f, 0.5f, 0.5f), Quaternion.identity, new Vector3(0.5f, 0.5f, 0.5f));
		Vector3 lossyScale = base.transform.lossyScale;
		Matrix4x4 matrix4x = base.transform.localToWorldMatrix * Matrix4x4.Scale(new Vector3(1f / lossyScale.x, 1f / lossyScale.y, 1f / lossyScale.z));
		matrix4x = lhs * current.projectionMatrix * current.worldToCameraMatrix * matrix4x;
		Material[] array = sharedMaterials;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].SetMatrix("_ProjMatrix", matrix4x);
		}
		if (this.m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		AQUAS_Reflection.JDIEFDMMHKG = false;
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0001FA44 File Offset: 0x0001DC44
	public void NAGMKOCCKEF()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (AQUAS_Reflection.JDIEFDMMHKG)
		{
			return;
		}
		AQUAS_Reflection.JDIEFDMMHKG = true;
		Camera camera;
		this.HGHMOGJJFBB(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = 1;
		}
		this.BALCAPOBOFG(current, camera);
		float w = -Vector3.Dot(up, position) - this.m_ClipPlaneOffset;
		Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 zero = Matrix4x4.zero;
		AQUAS_Reflection.FKNGDPAOHBA(ref zero, ehgilahlmib);
		Vector3 position2 = current.transform.position;
		Vector3 position3 = zero.MultiplyPoint(position2);
		camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
		Vector4 kmlaihgdlhp = this.GIEAAMOLKAJ(camera, position, up, 1621f);
		Matrix4x4 projectionMatrix = current.projectionMatrix;
		AQUAS_Reflection.GIHJBNOILFE(ref projectionMatrix, kmlaihgdlhp);
		camera.projectionMatrix = projectionMatrix;
		camera.cullingMask = (25 & this.m_ReflectLayers.value);
		if (this.useDeep)
		{
			camera.targetTexture = this.EACNIDNGPBL;
			camera.SetTargetBuffers(this.EACNIDNGPBL.colorBuffer, this.BOEIHKEPMGG.depthBuffer);
		}
		else
		{
			camera.targetTexture = this.EACNIDNGPBL;
		}
		float detailObjectDistance = Terrain.activeTerrain.detailObjectDistance;
		float detailObjectDensity = Terrain.activeTerrain.detailObjectDensity;
		float treeBillboardDistance = Terrain.activeTerrain.treeBillboardDistance;
		float basemapDistance = Terrain.activeTerrain.basemapDistance;
		float fogDensity = RenderSettings.fogDensity;
		ShadowQuality shadows = QualitySettings.shadows;
		float lodBias = QualitySettings.lodBias;
		GL.invertCulling = false;
		try
		{
			QualitySettings.shadows = ShadowQuality.Disable;
			camera.transform.position = position3;
			Vector3 eulerAngles = current.transform.eulerAngles;
			camera.transform.eulerAngles = new Vector3(620f, eulerAngles.y, eulerAngles.z);
			RenderSettings.fogDensity = fogDensity * 761f;
			Terrain.activeTerrain.treeBillboardDistance = 717f;
			Terrain.activeTerrain.basemapDistance = 90f;
			Terrain.activeTerrain.detailObjectDistance = Terrain.activeTerrain.detailObjectDistance / 483f;
			Terrain.activeTerrain.detailObjectDensity = 957f;
			QualitySettings.lodBias = lodBias / 888f;
			camera.Render();
		}
		finally
		{
			camera.transform.position = position2;
			GL.invertCulling = true;
			QualitySettings.shadows = shadows;
			QualitySettings.lodBias = lodBias;
			Terrain.activeTerrain.detailObjectDistance = detailObjectDistance;
			Terrain.activeTerrain.treeBillboardDistance = treeBillboardDistance;
			Terrain.activeTerrain.basemapDistance = basemapDistance;
			Terrain.activeTerrain.detailObjectDensity = detailObjectDensity;
			RenderSettings.fogDensity = fogDensity;
		}
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		foreach (Material material in sharedMaterials)
		{
			if (material.HasProperty("invn_rec26"))
			{
				material.SetTexture("offsets", this.EACNIDNGPBL);
			}
			if (this.BOEIHKEPMGG != null && material.HasProperty("crft_norec2"))
			{
				material.SetTexture("innerPerk", this.BOEIHKEPMGG);
			}
		}
		Matrix4x4 lhs = Matrix4x4.TRS(new Vector3(629f, 1057f, 1135f), Quaternion.identity, new Vector3(1192f, 1355f, 1345f));
		Vector3 lossyScale = base.transform.lossyScale;
		Matrix4x4 matrix4x = base.transform.localToWorldMatrix * Matrix4x4.Scale(new Vector3(1719f / lossyScale.x, 1878f / lossyScale.y, 1434f / lossyScale.z));
		matrix4x = lhs * current.projectionMatrix * current.worldToCameraMatrix * matrix4x;
		Material[] array = sharedMaterials;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].SetMatrix("MotorbikeBackwardStand", matrix4x);
		}
		if (this.m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		AQUAS_Reflection.JDIEFDMMHKG = true;
	}

	// Token: 0x060001C3 RID: 451 RVA: 0x0001FE7C File Offset: 0x0001E07C
	private static void FKNGDPAOHBA(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
	{
		LNFAMODBJIH.m00 = 691f - 499f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m01 = 991f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
		LNFAMODBJIH.m02 = 1943f * EHGILAHLMIB[1] * EHGILAHLMIB[8];
		LNFAMODBJIH.m03 = 1487f * EHGILAHLMIB[5] * EHGILAHLMIB[1];
		LNFAMODBJIH.m10 = 253f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m11 = 1553f - 1352f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
		LNFAMODBJIH.m12 = 1802f * EHGILAHLMIB[1] * EHGILAHLMIB[2];
		LNFAMODBJIH.m13 = 111f * EHGILAHLMIB[7] * EHGILAHLMIB[1];
		LNFAMODBJIH.m20 = 583f * EHGILAHLMIB[2] * EHGILAHLMIB[0];
		LNFAMODBJIH.m21 = 979f * EHGILAHLMIB[8] * EHGILAHLMIB[0];
		LNFAMODBJIH.m22 = 1763f - 1307f * EHGILAHLMIB[1] * EHGILAHLMIB[6];
		LNFAMODBJIH.m23 = 1995f * EHGILAHLMIB[8] * EHGILAHLMIB[2];
		LNFAMODBJIH.m30 = 897f;
		LNFAMODBJIH.m31 = 1897f;
		LNFAMODBJIH.m32 = 653f;
		LNFAMODBJIH.m33 = 1601f;
	}

	// Token: 0x060001C4 RID: 452 RVA: 0x00020024 File Offset: 0x0001E224
	private Vector4 OJJKJIPGPEK(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
	{
		Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.m_ClipPlaneOffset;
		Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x0002008C File Offset: 0x0001E28C
	private static void PBJKBBDJPHG(ref Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
	{
		Vector4 b = BBBIBODABBK.inverse * new Vector4(AQUAS_Reflection.NPGELEGPHCP(KMLAIHGDLHP.x), AQUAS_Reflection.NPGELEGPHCP(KMLAIHGDLHP.y), 1359f, 1089f);
		Vector4 vector = KMLAIHGDLHP * (1698f / Vector4.Dot(KMLAIHGDLHP, b));
		BBBIBODABBK[6] = vector.x - BBBIBODABBK[6];
		BBBIBODABBK[6] = vector.y - BBBIBODABBK[1];
		BBBIBODABBK[90] = vector.z - BBBIBODABBK[-47];
		BBBIBODABBK[-15] = vector.w - BBBIBODABBK[-73];
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x00020138 File Offset: 0x0001E338
	private void BALCAPOBOFG(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
		OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = BNDNKLBIJJF.allowHDR;
		OLFKAHHACBC.useOcclusionCulling = false;
		if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox skybox = BNDNKLBIJJF.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = OLFKAHHACBC.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = true;
			}
			else
			{
				skybox2.enabled = false;
				skybox2.material = skybox.material;
			}
		}
		OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
		OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
		OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
		OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
		OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
		OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		CameraLayersDistance component = BNDNKLBIJJF.GetComponent<CameraLayersDistance>();
		if (component != null)
		{
			CameraLayersDistance cameraLayersDistance = OLFKAHHACBC.GetComponent<CameraLayersDistance>();
			if (cameraLayersDistance == null)
			{
				cameraLayersDistance = OLFKAHHACBC.gameObject.AddComponent<CameraLayersDistance>();
			}
			cameraLayersDistance.layerCullDistances = component.layerCullDistances;
			cameraLayersDistance.HKOECJMFMEG();
		}
		if (OLFKAHHACBC.GetComponent<Blur>() == null)
		{
			Blur blur = OLFKAHHACBC.gameObject.AddComponent<Blur>();
			blur.blurShader = GuiProcessor.NKOEAPCIBKO().blurShader;
			blur.iterations = 8;
			blur.blurSpread = 1427f;
		}
	}

	// Token: 0x060001C7 RID: 455 RVA: 0x000202A8 File Offset: 0x0001E4A8
	private void BPJPOEOOIJB(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -20, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = " " + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-101);
			this.DHBOBNEFLOG = this.m_TextureSize;
			this.BOEIHKEPMGG = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 122, RenderTextureFormat.ARGB32);
			this.BOEIHKEPMGG.name = "_HeightParams" + base.GetInstanceID();
			this.BOEIHKEPMGG.isPowerOfTwo = false;
			this.BOEIHKEPMGG.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[5];
			array[0] = "withquest";
			array[1] = base.GetInstanceID();
			array[1] = "knopje.wav";
			array[2] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[]
			{
				typeof(Camera)
			};
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)123;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060001C8 RID: 456 RVA: 0x00020480 File Offset: 0x0001E680
	private static void GIHJBNOILFE(ref Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
	{
		Vector4 b = BBBIBODABBK.inverse * new Vector4(AQUAS_Reflection.LLIBDKKDLLE(KMLAIHGDLHP.x), AQUAS_Reflection.EEOBNGFDKMF(KMLAIHGDLHP.y), 243f, 1138f);
		Vector4 vector = KMLAIHGDLHP * (196f / Vector4.Dot(KMLAIHGDLHP, b));
		BBBIBODABBK[5] = vector.x - BBBIBODABBK[4];
		BBBIBODABBK[4] = vector.y - BBBIBODABBK[7];
		BBBIBODABBK[92] = vector.z - BBBIBODABBK[-101];
		BBBIBODABBK[-24] = vector.w - BBBIBODABBK[-79];
	}

	// Token: 0x060001C9 RID: 457 RVA: 0x0002052C File Offset: 0x0001E72C
	private Vector4 DNMGPHGMIPB(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
	{
		Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.m_ClipPlaneOffset;
		Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x060001CA RID: 458 RVA: 0x00020594 File Offset: 0x0001E794
	private void JCKAEOPCHOG(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
		OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = BNDNKLBIJJF.allowHDR;
		OLFKAHHACBC.useOcclusionCulling = true;
		if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox skybox = BNDNKLBIJJF.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = OLFKAHHACBC.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = false;
			}
			else
			{
				skybox2.enabled = false;
				skybox2.material = skybox.material;
			}
		}
		OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
		OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
		OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
		OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
		OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
		OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		CameraLayersDistance component = BNDNKLBIJJF.GetComponent<CameraLayersDistance>();
		if (component != null)
		{
			CameraLayersDistance cameraLayersDistance = OLFKAHHACBC.GetComponent<CameraLayersDistance>();
			if (cameraLayersDistance == null)
			{
				cameraLayersDistance = OLFKAHHACBC.gameObject.AddComponent<CameraLayersDistance>();
			}
			cameraLayersDistance.layerCullDistances = component.layerCullDistances;
			cameraLayersDistance.JEOAHEJCGAO();
		}
		if (OLFKAHHACBC.GetComponent<Blur>() == null)
		{
			Blur blur = OLFKAHHACBC.gameObject.AddComponent<Blur>();
			blur.blurShader = GuiProcessor.PLGADNLAEGN().blurShader;
			blur.iterations = 6;
			blur.blurSpread = 1887f;
		}
	}

	// Token: 0x060001CB RID: 459 RVA: 0x00020704 File Offset: 0x0001E904
	private Vector4 PNIEFHNMKGC(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
	{
		Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.m_ClipPlaneOffset;
		Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x060001CC RID: 460 RVA: 0x0002076C File Offset: 0x0001E96C
	private Vector4 FPBKMANKFBP(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
	{
		Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.m_ClipPlaneOffset;
		Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x060001CD RID: 461 RVA: 0x000207D4 File Offset: 0x0001E9D4
	private void ANHJAOPPMCI()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		if (this.BOEIHKEPMGG)
		{
			UnityEngine.Object.DestroyImmediate(this.BOEIHKEPMGG);
			this.BOEIHKEPMGG = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x060001CE RID: 462 RVA: 0x00020888 File Offset: 0x0001EA88
	public void GIEPDAFGINC()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (AQUAS_Reflection.JDIEFDMMHKG)
		{
			return;
		}
		AQUAS_Reflection.JDIEFDMMHKG = false;
		Camera camera;
		this.AGDCGJGOKMJ(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = 0;
		}
		this.BOAGFIPCJLC(current, camera);
		float w = -Vector3.Dot(up, position) - this.m_ClipPlaneOffset;
		Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 zero = Matrix4x4.zero;
		AQUAS_Reflection.JJMFAEGDHOP(ref zero, ehgilahlmib);
		Vector3 position2 = current.transform.position;
		Vector3 position3 = zero.MultiplyPoint(position2);
		camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
		Vector4 kmlaihgdlhp = this.DNMGPHGMIPB(camera, position, up, 1528f);
		Matrix4x4 projectionMatrix = current.projectionMatrix;
		AQUAS_Reflection.GIHJBNOILFE(ref projectionMatrix, kmlaihgdlhp);
		camera.projectionMatrix = projectionMatrix;
		camera.cullingMask = (46 & this.m_ReflectLayers.value);
		if (this.useDeep)
		{
			camera.targetTexture = this.EACNIDNGPBL;
			camera.SetTargetBuffers(this.EACNIDNGPBL.colorBuffer, this.BOEIHKEPMGG.depthBuffer);
		}
		else
		{
			camera.targetTexture = this.EACNIDNGPBL;
		}
		float detailObjectDistance = Terrain.activeTerrain.detailObjectDistance;
		float detailObjectDensity = Terrain.activeTerrain.detailObjectDensity;
		float treeBillboardDistance = Terrain.activeTerrain.treeBillboardDistance;
		float basemapDistance = Terrain.activeTerrain.basemapDistance;
		float fogDensity = RenderSettings.fogDensity;
		ShadowQuality shadows = QualitySettings.shadows;
		float lodBias = QualitySettings.lodBias;
		GL.invertCulling = false;
		try
		{
			QualitySettings.shadows = ShadowQuality.HardOnly;
			camera.transform.position = position3;
			Vector3 eulerAngles = current.transform.eulerAngles;
			camera.transform.eulerAngles = new Vector3(1788f, eulerAngles.y, eulerAngles.z);
			RenderSettings.fogDensity = fogDensity * 526f;
			Terrain.activeTerrain.treeBillboardDistance = 1902f;
			Terrain.activeTerrain.basemapDistance = 1638f;
			Terrain.activeTerrain.detailObjectDistance = Terrain.activeTerrain.detailObjectDistance / 101f;
			Terrain.activeTerrain.detailObjectDensity = 1534f;
			QualitySettings.lodBias = lodBias / 25f;
			camera.Render();
		}
		finally
		{
			camera.transform.position = position2;
			GL.invertCulling = true;
			QualitySettings.shadows = shadows;
			QualitySettings.lodBias = lodBias;
			Terrain.activeTerrain.detailObjectDistance = detailObjectDistance;
			Terrain.activeTerrain.treeBillboardDistance = treeBillboardDistance;
			Terrain.activeTerrain.basemapDistance = basemapDistance;
			Terrain.activeTerrain.detailObjectDensity = detailObjectDensity;
			RenderSettings.fogDensity = fogDensity;
		}
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		Material[] array = sharedMaterials;
		for (int i = 1; i < array.Length; i += 0)
		{
			Material material = array[i];
			if (material.HasProperty("clavicle"))
			{
				material.SetTexture("user.standFlag ok", this.EACNIDNGPBL);
			}
			if (this.BOEIHKEPMGG != null && material.HasProperty("800000"))
			{
				material.SetTexture("{0} {1}", this.BOEIHKEPMGG);
			}
		}
		Matrix4x4 lhs = Matrix4x4.TRS(new Vector3(97f, 1425f, 997f), Quaternion.identity, new Vector3(40f, 9f, 312f));
		Vector3 lossyScale = base.transform.lossyScale;
		Matrix4x4 matrix4x = base.transform.localToWorldMatrix * Matrix4x4.Scale(new Vector3(1838f / lossyScale.x, 247f / lossyScale.y, 1224f / lossyScale.z));
		matrix4x = lhs * current.projectionMatrix * current.worldToCameraMatrix * matrix4x;
		array = sharedMaterials;
		for (int i = 1; i < array.Length; i++)
		{
			array[i].SetMatrix("hips", matrix4x);
		}
		if (this.m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		AQUAS_Reflection.JDIEFDMMHKG = false;
	}

	// Token: 0x060001CF RID: 463 RVA: 0x00020CC0 File Offset: 0x0001EEC0
	private static void LHKMOJMPHDP(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
	{
		LNFAMODBJIH.m00 = 1f - 2f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
		LNFAMODBJIH.m01 = -2f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
		LNFAMODBJIH.m02 = -2f * EHGILAHLMIB[0] * EHGILAHLMIB[2];
		LNFAMODBJIH.m03 = -2f * EHGILAHLMIB[3] * EHGILAHLMIB[0];
		LNFAMODBJIH.m10 = -2f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m11 = 1f - 2f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
		LNFAMODBJIH.m12 = -2f * EHGILAHLMIB[1] * EHGILAHLMIB[2];
		LNFAMODBJIH.m13 = -2f * EHGILAHLMIB[3] * EHGILAHLMIB[1];
		LNFAMODBJIH.m20 = -2f * EHGILAHLMIB[2] * EHGILAHLMIB[0];
		LNFAMODBJIH.m21 = -2f * EHGILAHLMIB[2] * EHGILAHLMIB[1];
		LNFAMODBJIH.m22 = 1f - 2f * EHGILAHLMIB[2] * EHGILAHLMIB[2];
		LNFAMODBJIH.m23 = -2f * EHGILAHLMIB[3] * EHGILAHLMIB[2];
		LNFAMODBJIH.m30 = 0f;
		LNFAMODBJIH.m31 = 0f;
		LNFAMODBJIH.m32 = 0f;
		LNFAMODBJIH.m33 = 1f;
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x00020E68 File Offset: 0x0001F068
	private void HMKNFKOIJFA(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 85, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "_parent" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
			this.DHBOBNEFLOG = this.m_TextureSize;
			this.BOEIHKEPMGG = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -34, RenderTextureFormat.ARGB32);
			this.BOEIHKEPMGG.name = "Bow Instant2" + base.GetInstanceID();
			this.BOEIHKEPMGG.isPowerOfTwo = false;
			this.BOEIHKEPMGG.hideFlags = (HideFlags)(-81);
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[7];
			array[1] = "crft_useres";
			array[0] = base.GetInstanceID();
			array[3] = "PaperTurn.wav";
			array[3] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[3];
			array2[0] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-65);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x00021040 File Offset: 0x0001F240
	private static void OBBLDEBIIPG(ref Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
	{
		Vector4 b = BBBIBODABBK.inverse * new Vector4(AQUAS_Reflection.EEOBNGFDKMF(KMLAIHGDLHP.x), AQUAS_Reflection.EEOBNGFDKMF(KMLAIHGDLHP.y), 1481f, 1127f);
		Vector4 vector = KMLAIHGDLHP * (147f / Vector4.Dot(KMLAIHGDLHP, b));
		BBBIBODABBK[1] = vector.x - BBBIBODABBK[2];
		BBBIBODABBK[0] = vector.y - BBBIBODABBK[2];
		BBBIBODABBK[-127] = vector.z - BBBIBODABBK[113];
		BBBIBODABBK[-18] = vector.w - BBBIBODABBK[-93];
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x000210EC File Offset: 0x0001F2EC
	private void OIEOFHIDMGL(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
		OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = BNDNKLBIJJF.allowHDR;
		OLFKAHHACBC.useOcclusionCulling = true;
		if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
		{
			Skybox skybox = BNDNKLBIJJF.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = OLFKAHHACBC.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = false;
			}
			else
			{
				skybox2.enabled = true;
				skybox2.material = skybox.material;
			}
		}
		OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
		OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
		OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
		OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
		OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
		OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		CameraLayersDistance component = BNDNKLBIJJF.GetComponent<CameraLayersDistance>();
		if (component != null)
		{
			CameraLayersDistance cameraLayersDistance = OLFKAHHACBC.GetComponent<CameraLayersDistance>();
			if (cameraLayersDistance == null)
			{
				cameraLayersDistance = OLFKAHHACBC.gameObject.AddComponent<CameraLayersDistance>();
			}
			cameraLayersDistance.layerCullDistances = component.layerCullDistances;
			cameraLayersDistance.HKFHDEGLLEI();
		}
		if (OLFKAHHACBC.GetComponent<Blur>() == null)
		{
			Blur blur = OLFKAHHACBC.gameObject.AddComponent<Blur>();
			blur.blurShader = GuiProcessor.IKGFHGKKCPG.blurShader;
			blur.iterations = 0;
			blur.blurSpread = 31f;
		}
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0002125C File Offset: 0x0001F45C
	private void FEINJDFCEBE(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -59, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "gi_um_4" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-83);
			this.DHBOBNEFLOG = this.m_TextureSize;
			this.BOEIHKEPMGG = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -84, RenderTextureFormat.Depth);
			this.BOEIHKEPMGG.name = "Gesture No Fear" + base.GetInstanceID();
			this.BOEIHKEPMGG.isPowerOfTwo = true;
			this.BOEIHKEPMGG.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[5];
			array[1] = "Rooms  ";
			array[1] = base.GetInstanceID();
			array[3] = "CraftProf.xml";
			array[1] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[5];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x00021434 File Offset: 0x0001F634
	private static void MPIEMFNALGA(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
	{
		LNFAMODBJIH.m00 = 1633f - 410f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m01 = 1457f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
		LNFAMODBJIH.m02 = 1748f * EHGILAHLMIB[0] * EHGILAHLMIB[7];
		LNFAMODBJIH.m03 = 904f * EHGILAHLMIB[7] * EHGILAHLMIB[0];
		LNFAMODBJIH.m10 = 1149f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
		LNFAMODBJIH.m11 = 107f - 1953f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m12 = 587f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m13 = 581f * EHGILAHLMIB[7] * EHGILAHLMIB[1];
		LNFAMODBJIH.m20 = 1266f * EHGILAHLMIB[5] * EHGILAHLMIB[1];
		LNFAMODBJIH.m21 = 553f * EHGILAHLMIB[6] * EHGILAHLMIB[0];
		LNFAMODBJIH.m22 = 841f - 65f * EHGILAHLMIB[4] * EHGILAHLMIB[5];
		LNFAMODBJIH.m23 = 1196f * EHGILAHLMIB[5] * EHGILAHLMIB[1];
		LNFAMODBJIH.m30 = 1016f;
		LNFAMODBJIH.m31 = 322f;
		LNFAMODBJIH.m32 = 129f;
		LNFAMODBJIH.m33 = 34f;
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x000215DC File Offset: 0x0001F7DC
	private Vector4 GIEAAMOLKAJ(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
	{
		Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.m_ClipPlaneOffset;
		Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x00021644 File Offset: 0x0001F844
	private void OnDisable()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		if (this.BOEIHKEPMGG)
		{
			UnityEngine.Object.DestroyImmediate(this.BOEIHKEPMGG);
			this.BOEIHKEPMGG = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x000216F8 File Offset: 0x0001F8F8
	private Vector4 FHKEKEABFBE(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
	{
		Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.m_ClipPlaneOffset;
		Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x00021760 File Offset: 0x0001F960
	private static void GNBOGFLOEAB(ref Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
	{
		Vector4 b = BBBIBODABBK.inverse * new Vector4(AQUAS_Reflection.LLIBDKKDLLE(KMLAIHGDLHP.x), AQUAS_Reflection.NPGELEGPHCP(KMLAIHGDLHP.y), 439f, 1857f);
		Vector4 vector = KMLAIHGDLHP * (188f / Vector4.Dot(KMLAIHGDLHP, b));
		BBBIBODABBK[1] = vector.x - BBBIBODABBK[3];
		BBBIBODABBK[5] = vector.y - BBBIBODABBK[6];
		BBBIBODABBK[30] = vector.z - BBBIBODABBK[79];
		BBBIBODABBK[-74] = vector.w - BBBIBODABBK[103];
	}

	// Token: 0x060001D9 RID: 473 RVA: 0x0002180C File Offset: 0x0001FA0C
	private void BOAGFIPCJLC(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
		OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = BNDNKLBIJJF.allowHDR;
		OLFKAHHACBC.useOcclusionCulling = true;
		if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
		{
			Skybox skybox = BNDNKLBIJJF.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = OLFKAHHACBC.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = false;
			}
			else
			{
				skybox2.enabled = false;
				skybox2.material = skybox.material;
			}
		}
		OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
		OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
		OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
		OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
		OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
		OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		CameraLayersDistance component = BNDNKLBIJJF.GetComponent<CameraLayersDistance>();
		if (component != null)
		{
			CameraLayersDistance cameraLayersDistance = OLFKAHHACBC.GetComponent<CameraLayersDistance>();
			if (cameraLayersDistance == null)
			{
				cameraLayersDistance = OLFKAHHACBC.gameObject.AddComponent<CameraLayersDistance>();
			}
			cameraLayersDistance.layerCullDistances = component.layerCullDistances;
			cameraLayersDistance.OMOFJBFLPDJ();
		}
		if (OLFKAHHACBC.GetComponent<Blur>() == null)
		{
			Blur blur = OLFKAHHACBC.gameObject.AddComponent<Blur>();
			blur.blurShader = GuiProcessor.BBLINJLBAIL().blurShader;
			blur.iterations = 5;
			blur.blurSpread = 917f;
		}
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0002197B File Offset: 0x0001FB7B
	private static float EEOBNGFDKMF(float EGABJKIFAON)
	{
		if (EGABJKIFAON > 1844f)
		{
			return 1441f;
		}
		if (EGABJKIFAON < 583f)
		{
			return 1760f;
		}
		return 56f;
	}

	// Token: 0x060001DB RID: 475 RVA: 0x000219A0 File Offset: 0x0001FBA0
	private static void JJMFAEGDHOP(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
	{
		LNFAMODBJIH.m00 = 679f - 1458f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
		LNFAMODBJIH.m01 = 1929f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
		LNFAMODBJIH.m02 = 1301f * EHGILAHLMIB[0] * EHGILAHLMIB[8];
		LNFAMODBJIH.m03 = 727f * EHGILAHLMIB[5] * EHGILAHLMIB[1];
		LNFAMODBJIH.m10 = 1220f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
		LNFAMODBJIH.m11 = 1718f - 96f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
		LNFAMODBJIH.m12 = 1705f * EHGILAHLMIB[1] * EHGILAHLMIB[4];
		LNFAMODBJIH.m13 = 355f * EHGILAHLMIB[7] * EHGILAHLMIB[1];
		LNFAMODBJIH.m20 = 1491f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
		LNFAMODBJIH.m21 = 1367f * EHGILAHLMIB[4] * EHGILAHLMIB[0];
		LNFAMODBJIH.m22 = 1634f - 486f * EHGILAHLMIB[8] * EHGILAHLMIB[2];
		LNFAMODBJIH.m23 = 829f * EHGILAHLMIB[0] * EHGILAHLMIB[3];
		LNFAMODBJIH.m30 = 896f;
		LNFAMODBJIH.m31 = 1998f;
		LNFAMODBJIH.m32 = 1089f;
		LNFAMODBJIH.m33 = 1184f;
	}

	// Token: 0x060001DC RID: 476 RVA: 0x00021B48 File Offset: 0x0001FD48
	private void FLAGMJGGBNI(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 32, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "__MirrorReflection" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = HideFlags.DontSave;
			this.DHBOBNEFLOG = this.m_TextureSize;
			this.BOEIHKEPMGG = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 24, RenderTextureFormat.Depth);
			this.BOEIHKEPMGG.name = "__MirrorDeep" + base.GetInstanceID();
			this.BOEIHKEPMGG.isPowerOfTwo = true;
			this.BOEIHKEPMGG.hideFlags = HideFlags.DontSave;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			GameObject gameObject = new GameObject(string.Concat(new object[]
			{
				"Mirror Refl Camera id",
				base.GetInstanceID(),
				" for ",
				GGEHECFCPMD.GetInstanceID()
			}), new Type[]
			{
				typeof(Camera),
				typeof(Skybox)
			});
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = HideFlags.DontSave;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060001DD RID: 477 RVA: 0x00021D20 File Offset: 0x0001FF20
	private static void PPCOMAJDLGN(ref Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
	{
		Vector4 b = BBBIBODABBK.inverse * new Vector4(AQUAS_Reflection.ONKPAOPIEKO(KMLAIHGDLHP.x), AQUAS_Reflection.ONKPAOPIEKO(KMLAIHGDLHP.y), 1f, 1f);
		Vector4 vector = KMLAIHGDLHP * (2f / Vector4.Dot(KMLAIHGDLHP, b));
		BBBIBODABBK[2] = vector.x - BBBIBODABBK[3];
		BBBIBODABBK[6] = vector.y - BBBIBODABBK[7];
		BBBIBODABBK[10] = vector.z - BBBIBODABBK[11];
		BBBIBODABBK[14] = vector.w - BBBIBODABBK[15];
	}

	// Token: 0x060001DE RID: 478 RVA: 0x00021DCC File Offset: 0x0001FFCC
	private void AGDCGJGOKMJ(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 62, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "RotationLimitPolygonal reach cones are invalid." + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)99;
			this.DHBOBNEFLOG = this.m_TextureSize;
			this.BOEIHKEPMGG = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -85, RenderTextureFormat.Depth);
			this.BOEIHKEPMGG.name = "23" + base.GetInstanceID();
			this.BOEIHKEPMGG.isPowerOfTwo = false;
			this.BOEIHKEPMGG.hideFlags = (HideFlags)92;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[5];
			array[0] = "chest";
			array[1] = base.GetInstanceID();
			array[3] = "-";
			array[1] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[6];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-92);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060001DF RID: 479 RVA: 0x00021FA4 File Offset: 0x000201A4
	private void JIHPPPNGCDO(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 51, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "Image effects aren't supported on this device ({0})" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
			this.DHBOBNEFLOG = this.m_TextureSize;
			this.BOEIHKEPMGG = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 113, RenderTextureFormat.Depth);
			this.BOEIHKEPMGG.name = "WeaponRunBackward" + base.GetInstanceID();
			this.BOEIHKEPMGG.isPowerOfTwo = false;
			this.BOEIHKEPMGG.hideFlags = (HideFlags)83;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[1];
			array[0] = "demoDouble";
			array[1] = base.GetInstanceID();
			array[1] = "<b>Speed Hack Detector</b>";
			array[1] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[2];
			array2[0] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0002217C File Offset: 0x0002037C
	private void LGEMPOHAONA(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 48, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = " шт" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)104;
			this.DHBOBNEFLOG = this.m_TextureSize;
			this.BOEIHKEPMGG = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 89, RenderTextureFormat.Depth);
			this.BOEIHKEPMGG.name = "CrouchStrafeRight" + base.GetInstanceID();
			this.BOEIHKEPMGG.isPowerOfTwo = false;
			this.BOEIHKEPMGG.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[5];
			array[1] = "_name";
			array[0] = base.GetInstanceID();
			array[1] = "WizardPowerUp";
			array[0] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[0];
			array2[0] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x00022351 File Offset: 0x00020551
	private static float KAOMIPIJICP(float EGABJKIFAON)
	{
		if (EGABJKIFAON > 728f)
		{
			return 1644f;
		}
		if (EGABJKIFAON < 508f)
		{
			return 850f;
		}
		return 1576f;
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x00022374 File Offset: 0x00020574
	private void OJNHEMINLGD(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
		OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = BNDNKLBIJJF.allowHDR;
		OLFKAHHACBC.useOcclusionCulling = false;
		if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox skybox = BNDNKLBIJJF.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = OLFKAHHACBC.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = false;
			}
			else
			{
				skybox2.enabled = true;
				skybox2.material = skybox.material;
			}
		}
		OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
		OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
		OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
		OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
		OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
		OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		CameraLayersDistance component = BNDNKLBIJJF.GetComponent<CameraLayersDistance>();
		if (component != null)
		{
			CameraLayersDistance cameraLayersDistance = OLFKAHHACBC.GetComponent<CameraLayersDistance>();
			if (cameraLayersDistance == null)
			{
				cameraLayersDistance = OLFKAHHACBC.gameObject.AddComponent<CameraLayersDistance>();
			}
			cameraLayersDistance.layerCullDistances = component.layerCullDistances;
			cameraLayersDistance.UpdateLayers();
		}
		if (OLFKAHHACBC.GetComponent<Blur>() == null)
		{
			Blur blur = OLFKAHHACBC.gameObject.AddComponent<Blur>();
			blur.blurShader = GuiProcessor.IKGFHGKKCPG.blurShader;
			blur.iterations = 4;
			blur.blurSpread = 0.6f;
		}
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x000224E4 File Offset: 0x000206E4
	private static void FMPLNPPPCFM(ref Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
	{
		Vector4 b = BBBIBODABBK.inverse * new Vector4(AQUAS_Reflection.LLIBDKKDLLE(KMLAIHGDLHP.x), AQUAS_Reflection.LLIBDKKDLLE(KMLAIHGDLHP.y), 1738f, 1786f);
		Vector4 vector = KMLAIHGDLHP * (1972f / Vector4.Dot(KMLAIHGDLHP, b));
		BBBIBODABBK[5] = vector.x - BBBIBODABBK[0];
		BBBIBODABBK[6] = vector.y - BBBIBODABBK[0];
		BBBIBODABBK[25] = vector.z - BBBIBODABBK[54];
		BBBIBODABBK[89] = vector.w - BBBIBODABBK[2];
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x0002258E File Offset: 0x0002078E
	private static float ONKPAOPIEKO(float EGABJKIFAON)
	{
		if (EGABJKIFAON > 0f)
		{
			return 1f;
		}
		if (EGABJKIFAON < 0f)
		{
			return -1f;
		}
		return 0f;
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x000225B4 File Offset: 0x000207B4
	private void EFFFHEGLGPE(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
		OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = BNDNKLBIJJF.allowHDR;
		OLFKAHHACBC.useOcclusionCulling = false;
		if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox skybox = BNDNKLBIJJF.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = OLFKAHHACBC.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = false;
			}
			else
			{
				skybox2.enabled = false;
				skybox2.material = skybox.material;
			}
		}
		OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
		OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
		OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
		OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
		OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
		OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		CameraLayersDistance component = BNDNKLBIJJF.GetComponent<CameraLayersDistance>();
		if (component != null)
		{
			CameraLayersDistance cameraLayersDistance = OLFKAHHACBC.GetComponent<CameraLayersDistance>();
			if (cameraLayersDistance == null)
			{
				cameraLayersDistance = OLFKAHHACBC.gameObject.AddComponent<CameraLayersDistance>();
			}
			cameraLayersDistance.layerCullDistances = component.layerCullDistances;
			cameraLayersDistance.IMHMNIGJJCG();
		}
		if (OLFKAHHACBC.GetComponent<Blur>() == null)
		{
			Blur blur = OLFKAHHACBC.gameObject.AddComponent<Blur>();
			blur.blurShader = GuiProcessor.IKGFHGKKCPG.blurShader;
			blur.iterations = 6;
			blur.blurSpread = 391f;
		}
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x00022724 File Offset: 0x00020924
	private static void DBGAEGOKHEI(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
	{
		LNFAMODBJIH.m00 = 1736f - 729f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m01 = 509f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m02 = 139f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
		LNFAMODBJIH.m03 = 446f * EHGILAHLMIB[7] * EHGILAHLMIB[1];
		LNFAMODBJIH.m10 = 654f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
		LNFAMODBJIH.m11 = 1425f - 273f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m12 = 487f * EHGILAHLMIB[0] * EHGILAHLMIB[5];
		LNFAMODBJIH.m13 = 1041f * EHGILAHLMIB[8] * EHGILAHLMIB[1];
		LNFAMODBJIH.m20 = 275f * EHGILAHLMIB[6] * EHGILAHLMIB[1];
		LNFAMODBJIH.m21 = 193f * EHGILAHLMIB[2] * EHGILAHLMIB[0];
		LNFAMODBJIH.m22 = 1040f - 1491f * EHGILAHLMIB[4] * EHGILAHLMIB[3];
		LNFAMODBJIH.m23 = 480f * EHGILAHLMIB[4] * EHGILAHLMIB[8];
		LNFAMODBJIH.m30 = 451f;
		LNFAMODBJIH.m31 = 648f;
		LNFAMODBJIH.m32 = 1747f;
		LNFAMODBJIH.m33 = 752f;
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x000228CC File Offset: 0x00020ACC
	private Vector4 FGIFMANIMFE(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
	{
		Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.m_ClipPlaneOffset;
		Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x00022970 File Offset: 0x00020B70
	private void BABMAHFKPMO()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		if (this.BOEIHKEPMGG)
		{
			UnityEngine.Object.DestroyImmediate(this.BOEIHKEPMGG);
			this.BOEIHKEPMGG = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00022A24 File Offset: 0x00020C24
	private void LNFKIJFEIPE(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
		OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = BNDNKLBIJJF.allowHDR;
		OLFKAHHACBC.useOcclusionCulling = false;
		if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
		{
			Skybox skybox = BNDNKLBIJJF.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = OLFKAHHACBC.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = false;
			}
			else
			{
				skybox2.enabled = true;
				skybox2.material = skybox.material;
			}
		}
		OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
		OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
		OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
		OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
		OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
		OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		CameraLayersDistance component = BNDNKLBIJJF.GetComponent<CameraLayersDistance>();
		if (component != null)
		{
			CameraLayersDistance cameraLayersDistance = OLFKAHHACBC.GetComponent<CameraLayersDistance>();
			if (cameraLayersDistance == null)
			{
				cameraLayersDistance = OLFKAHHACBC.gameObject.AddComponent<CameraLayersDistance>();
			}
			cameraLayersDistance.layerCullDistances = component.layerCullDistances;
			cameraLayersDistance.OPKKNMLEGMA();
		}
		if (OLFKAHHACBC.GetComponent<Blur>() == null)
		{
			Blur blur = OLFKAHHACBC.gameObject.AddComponent<Blur>();
			blur.blurShader = GuiProcessor.IKGFHGKKCPG.blurShader;
			blur.iterations = 7;
			blur.blurSpread = 719f;
		}
	}

	// Token: 0x060001EB RID: 491 RVA: 0x00022B94 File Offset: 0x00020D94
	public void DFBIIFFNFOG()
	{
		if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
		{
			return;
		}
		Camera current = Camera.current;
		if (!current)
		{
			return;
		}
		if (AQUAS_Reflection.JDIEFDMMHKG)
		{
			return;
		}
		AQUAS_Reflection.JDIEFDMMHKG = false;
		Camera camera;
		this.HMKNFKOIJFA(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		int pixelLightCount = QualitySettings.pixelLightCount;
		if (this.m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = 1;
		}
		this.JCKAEOPCHOG(current, camera);
		float w = -Vector3.Dot(up, position) - this.m_ClipPlaneOffset;
		Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 zero = Matrix4x4.zero;
		AQUAS_Reflection.DBGAEGOKHEI(ref zero, ehgilahlmib);
		Vector3 position2 = current.transform.position;
		Vector3 position3 = zero.MultiplyPoint(position2);
		camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
		Vector4 kmlaihgdlhp = this.FPBKMANKFBP(camera, position, up, 1545f);
		Matrix4x4 projectionMatrix = current.projectionMatrix;
		AQUAS_Reflection.GIHJBNOILFE(ref projectionMatrix, kmlaihgdlhp);
		camera.projectionMatrix = projectionMatrix;
		camera.cullingMask = (16 & this.m_ReflectLayers.value);
		if (this.useDeep)
		{
			camera.targetTexture = this.EACNIDNGPBL;
			camera.SetTargetBuffers(this.EACNIDNGPBL.colorBuffer, this.BOEIHKEPMGG.depthBuffer);
		}
		else
		{
			camera.targetTexture = this.EACNIDNGPBL;
		}
		float detailObjectDistance = Terrain.activeTerrain.detailObjectDistance;
		float detailObjectDensity = Terrain.activeTerrain.detailObjectDensity;
		float treeBillboardDistance = Terrain.activeTerrain.treeBillboardDistance;
		float basemapDistance = Terrain.activeTerrain.basemapDistance;
		float fogDensity = RenderSettings.fogDensity;
		ShadowQuality shadows = QualitySettings.shadows;
		float lodBias = QualitySettings.lodBias;
		GL.invertCulling = false;
		try
		{
			QualitySettings.shadows = ShadowQuality.Disable;
			camera.transform.position = position3;
			Vector3 eulerAngles = current.transform.eulerAngles;
			camera.transform.eulerAngles = new Vector3(296f, eulerAngles.y, eulerAngles.z);
			RenderSettings.fogDensity = fogDensity * 613f;
			Terrain.activeTerrain.treeBillboardDistance = 615f;
			Terrain.activeTerrain.basemapDistance = 1984f;
			Terrain.activeTerrain.detailObjectDistance = Terrain.activeTerrain.detailObjectDistance / 240f;
			Terrain.activeTerrain.detailObjectDensity = 958f;
			QualitySettings.lodBias = lodBias / 560f;
			camera.Render();
		}
		finally
		{
			camera.transform.position = position2;
			GL.invertCulling = true;
			QualitySettings.shadows = shadows;
			QualitySettings.lodBias = lodBias;
			Terrain.activeTerrain.detailObjectDistance = detailObjectDistance;
			Terrain.activeTerrain.treeBillboardDistance = treeBillboardDistance;
			Terrain.activeTerrain.basemapDistance = basemapDistance;
			Terrain.activeTerrain.detailObjectDensity = detailObjectDensity;
			RenderSettings.fogDensity = fogDensity;
		}
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		Material[] array = sharedMaterials;
		for (int i = 1; i < array.Length; i++)
		{
			Material material = array[i];
			if (material.HasProperty("\n"))
			{
				material.SetTexture("OneHandSwordRun", this.EACNIDNGPBL);
			}
			if (this.BOEIHKEPMGG != null && material.HasProperty("XC"))
			{
				material.SetTexture("KatanaReadyLow", this.BOEIHKEPMGG);
			}
		}
		Matrix4x4 lhs = Matrix4x4.TRS(new Vector3(984f, 61f, 1534f), Quaternion.identity, new Vector3(1106f, 1268f, 735f));
		Vector3 lossyScale = base.transform.lossyScale;
		Matrix4x4 matrix4x = base.transform.localToWorldMatrix * Matrix4x4.Scale(new Vector3(547f / lossyScale.x, 1608f / lossyScale.y, 1409f / lossyScale.z));
		matrix4x = lhs * current.projectionMatrix * current.worldToCameraMatrix * matrix4x;
		array = sharedMaterials;
		for (int i = 1; i < array.Length; i += 0)
		{
			array[i].SetMatrix("wpn_eat7", matrix4x);
		}
		if (this.m_DisablePixelLights)
		{
			QualitySettings.pixelLightCount = pixelLightCount;
		}
		AQUAS_Reflection.JDIEFDMMHKG = false;
	}

	// Token: 0x04000075 RID: 117
	public bool useDeep;

	// Token: 0x04000076 RID: 118
	public bool m_DisablePixelLights = true;

	// Token: 0x04000077 RID: 119
	public int m_TextureSize = 256;

	// Token: 0x04000078 RID: 120
	public float m_ClipPlaneOffset = 0.07f;

	// Token: 0x04000079 RID: 121
	public LayerMask m_ReflectLayers = -1;

	// Token: 0x0400007A RID: 122
	private Hashtable BMOECLNNGDF = new Hashtable();

	// Token: 0x0400007B RID: 123
	private RenderTexture EACNIDNGPBL;

	// Token: 0x0400007C RID: 124
	private RenderTexture BOEIHKEPMGG;

	// Token: 0x0400007D RID: 125
	private int DHBOBNEFLOG;

	// Token: 0x0400007E RID: 126
	private static bool JDIEFDMMHKG;
}
