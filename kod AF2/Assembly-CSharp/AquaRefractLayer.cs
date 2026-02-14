using System;
using System.Collections;
using UnityEngine;

// Token: 0x02000013 RID: 19
[ExecuteInEditMode]
public class AquaRefractLayer : MonoBehaviour
{
	// Token: 0x0600021A RID: 538 RVA: 0x000233E4 File Offset: 0x000215E4
	public void AFKBBLIPIKN()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.DHCBNJHMPOL(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.MIPIIOPHNKN(current, camera);
		camera.cullingMask = (70 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("wgt="))
			{
				material.SetTexture("Загрузка: ", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x0600021B RID: 539 RVA: 0x00023504 File Offset: 0x00021704
	private void HBNDJPNJKFM()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600021C RID: 540 RVA: 0x00023598 File Offset: 0x00021798
	private void EHNDLEILCDM()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600021D RID: 541 RVA: 0x0002362C File Offset: 0x0002182C
	private void AJJDDJEAKCL(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -108, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "_ContrastGainGamma" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[8];
			array[0] = "Load";
			array[1] = base.GetInstanceID();
			array[5] = "Bases/1.base";
			array[6] = GGEHECFCPMD.GetInstanceID();
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
			gameObject.hideFlags = HideFlags.DontSaveInBuild;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x0600021E RID: 542 RVA: 0x000237AC File Offset: 0x000219AC
	public void DMCLJLOIEAA()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.FBLGGMDKAPB(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.IPNIABKAHMA(current, camera);
		camera.cullingMask = (34 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("pelvis"))
			{
				material.SetTexture("2048", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x0600021F RID: 543 RVA: 0x000238CC File Offset: 0x00021ACC
	private void OKCFBNCACNB(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 102, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = " " + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-97);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[4];
			array[0] = "INTERFACE";
			array[0] = base.GetInstanceID();
			array[7] = "The polygon must have at least 3 Limit Points.";
			array[3] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[3];
			array2[0] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000220 RID: 544 RVA: 0x00023A4C File Offset: 0x00021C4C
	public void FJHEKLFDCMP()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.LPAPOJHKGON(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.GBMOIBOFDKG(current, camera);
		camera.cullingMask = (-119 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i++)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("OneHandSwordJab"))
			{
				material.SetTexture("-- <color='#002000'>$</color>", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x06000221 RID: 545 RVA: 0x00023B6C File Offset: 0x00021D6C
	private void OAIKDCJCFBM(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -125, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "+ EXP for FISH=" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[4];
			array[1] = "<color='#100000'>{0} {1}</color>";
			array[1] = base.GetInstanceID();
			array[0] = "wpn_bait_inf_{0}";
			array[6] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[7];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)80;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000222 RID: 546 RVA: 0x00023CEC File Offset: 0x00021EEC
	private void INPHAEAEMAJ(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -29, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "maxWgtBait" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-119);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[7];
			array[0] = "Hidden/LensAberrations";
			array[1] = base.GetInstanceID();
			array[0] = "OneHandSwordBlock";
			array[4] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[1];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-117);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000223 RID: 547 RVA: 0x00023E6C File Offset: 0x0002206C
	private void KLHDJKDMCJN()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000224 RID: 548 RVA: 0x00023F00 File Offset: 0x00022100
	private void LGEMPOHAONA(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 10, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "RunBackward" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-74);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[7];
			array[0] = "\\";
			array[0] = base.GetInstanceID();
			array[6] = " iterations for read and write";
			array[0] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[1];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-97);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000225 RID: 549 RVA: 0x00024080 File Offset: 0x00022280
	private void GFJLCGKLNDK(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -90, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "Textures/Fish/" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)115;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[0];
			array[1] = "name";
			array[1] = base.GetInstanceID();
			array[5] = "[minwgt]";
			array[1] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[5];
			array2[0] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000226 RID: 550 RVA: 0x00024200 File Offset: 0x00022400
	private void DFCJDHJGILP()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000227 RID: 551 RVA: 0x00024294 File Offset: 0x00022494
	public void ELCBANBNMLK()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.NEOANBLEEJC(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PHPHNICIEIO(current, camera);
		camera.cullingMask = (25 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("\n"))
			{
				material.SetTexture("WATER_REFLECTIVE", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000228 RID: 552 RVA: 0x000243B4 File Offset: 0x000225B4
	private void OGMALNDHBEE()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000229 RID: 553 RVA: 0x00024448 File Offset: 0x00022648
	private void MIPIIOPHNKN(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Nothing;
		OLFKAHHACBC.backgroundColor = new Color(1002f, 952f, 1666f, 335f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = true;
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
			cameraLayersDistance.BGGCPOFFMFN();
		}
	}

	// Token: 0x0600022A RID: 554 RVA: 0x00024588 File Offset: 0x00022788
	private void DNBMNPKDPHC()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0002461C File Offset: 0x0002281C
	private void AHMFIGNLJOB()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600022C RID: 556 RVA: 0x000246B0 File Offset: 0x000228B0
	private void NEOANBLEEJC(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -7, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "__MirrorDeep" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-90);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[8];
			array[1] = "64";
			array[1] = base.GetInstanceID();
			array[5] = "\n";
			array[8] = GGEHECFCPMD.GetInstanceID();
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
			gameObject.hideFlags = (HideFlags)(-90);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x0600022D RID: 557 RVA: 0x00024830 File Offset: 0x00022A30
	private void GFAEFHIHJCM()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600022E RID: 558 RVA: 0x000248C4 File Offset: 0x00022AC4
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.FLAGMJGGBNI(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.OJNHEMINLGD(current, camera);
		camera.cullingMask = (-17 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		foreach (Material material in base.GetComponent<Renderer>().sharedMaterials)
		{
			if (material.HasProperty("_RefractTex"))
			{
				material.SetTexture("_RefractTex", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x0600022F RID: 559 RVA: 0x000249E4 File Offset: 0x00022BE4
	public void NPFFOGCHGNI()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.LGEMPOHAONA(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.GHMPNEMHKEB(current, camera);
		camera.cullingMask = (11 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		foreach (Material material in base.GetComponent<Renderer>().sharedMaterials)
		{
			if (material.HasProperty("11"))
			{
				material.SetTexture(" ", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000230 RID: 560 RVA: 0x00024B04 File Offset: 0x00022D04
	private void HFFCOLJKAON(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)7;
		OLFKAHHACBC.backgroundColor = new Color(968f, 1919f, 831f, 581f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = true;
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
			cameraLayersDistance.IMHMNIGJJCG();
		}
	}

	// Token: 0x06000231 RID: 561 RVA: 0x00024C44 File Offset: 0x00022E44
	private void DHCBNJHMPOL(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -62, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "FULLNAME" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[0];
			array[1] = "Anchore Right_";
			array[0] = base.GetInstanceID();
			array[1] = "R";
			array[1] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[8];
			array2[1] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000232 RID: 562 RVA: 0x00024DC4 File Offset: 0x00022FC4
	private void NPIOCACDHJO(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Skybox;
		OLFKAHHACBC.backgroundColor = new Color(784f, 1952f, 1001f, 1035f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = false;
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
			cameraLayersDistance.BGGCPOFFMFN();
		}
	}

	// Token: 0x06000233 RID: 563 RVA: 0x00024F04 File Offset: 0x00023104
	public void MHKHLGDKKPB()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.BNKNFGKAKJO(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.DIOLDBHDBGJ(current, camera);
		camera.cullingMask = (-86 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i++)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("\\,"))
			{
				material.SetTexture(" iterations for read and write", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000234 RID: 564 RVA: 0x00025024 File Offset: 0x00023224
	private void OMGBIJEPICP(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -93, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "FOG_EXP" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			string name = string.Concat(new object[]
			{
				"ENABLE_DITHERING",
				base.GetInstanceID(),
				null,
				null,
				"IdleTurns",
				GGEHECFCPMD.GetInstanceID()
			});
			Type[] array = new Type[7];
			array[1] = typeof(Camera);
			array[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000235 RID: 565 RVA: 0x000251A4 File Offset: 0x000233A4
	private void JPILCPHNAHM(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 102, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "buykey" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)97;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[6];
			array[1] = "KatanaReady";
			array[1] = base.GetInstanceID();
			array[1] = "wpn_tank1";
			array[1] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[1];
			array2[1] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000236 RID: 566 RVA: 0x00025324 File Offset: 0x00023524
	private void AJJAFODOCGL(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -19, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "_TintColor" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)69;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[6];
			array[1] = "Superman";
			array[1] = base.GetInstanceID();
			array[2] = "</color>";
			array[0] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[4];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = HideFlags.DontSave;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000237 RID: 567 RVA: 0x000254A4 File Offset: 0x000236A4
	private void OOOMOHIPACP(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 27, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "ChannelCastDirected" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = HideFlags.HideAndDontSave;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[5];
			array[1] = "_SpecCubeIBL";
			array[1] = base.GetInstanceID();
			array[6] = "gi_frac_max";
			array[5] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[3];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000238 RID: 568 RVA: 0x00025624 File Offset: 0x00023824
	public void OOOBKFIBLBF()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.LCMBFOFNAKJ(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PCMMNIJEGGH(current, camera);
		camera.cullingMask = (7 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("PistolFire"))
			{
				material.SetTexture("Root transform is null. Can't initiate Grounding.", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000239 RID: 569 RVA: 0x00025744 File Offset: 0x00023944
	private void OJNHEMINLGD(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Color;
		OLFKAHHACBC.backgroundColor = new Color(0f, 0f, 0f, 0f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = false;
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
	}

	// Token: 0x0600023A RID: 570 RVA: 0x00025884 File Offset: 0x00023A84
	private void JPBACNMHKOE()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600023B RID: 571 RVA: 0x00025918 File Offset: 0x00023B18
	private void DIHBENNEJOI(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 120, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "_InvRenderTargetSize" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = HideFlags.DontSave;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[5];
			array[1] = "---";
			array[1] = base.GetInstanceID();
			array[8] = "auk_head";
			array[5] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[0];
			array2[1] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-107);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x0600023C RID: 572 RVA: 0x00025A98 File Offset: 0x00023C98
	private void JGHJOBDKDKM()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600023D RID: 573 RVA: 0x00025B2C File Offset: 0x00023D2C
	private void AONMCCAFCGE(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 104, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "SysAlert.wav" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)79;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[7];
			array[1] = "BAG";
			array[1] = base.GetInstanceID();
			array[5] = "ArmFlex2";
			array[5] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[6];
			array2[1] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-126);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x0600023E RID: 574 RVA: 0x00025CAC File Offset: 0x00023EAC
	private void CLMEFPDAFHA(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -83, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "byte[]: {" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-112);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[7];
			array[1] = "PreserveDetails";
			array[1] = base.GetInstanceID();
			array[8] = "AssetBundleManifest";
			array[3] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[0];
			array2[1] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x0600023F RID: 575 RVA: 0x00025E2C File Offset: 0x0002402C
	private void PCKOPPKGENK()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000240 RID: 576 RVA: 0x00025EC0 File Offset: 0x000240C0
	private void IIKBAJBOIGD(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Depth;
		OLFKAHHACBC.backgroundColor = new Color(1581f, 1623f, 1288f, 1626f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = true;
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
			cameraLayersDistance.LBPCEPLOMDM();
		}
	}

	// Token: 0x06000241 RID: 577 RVA: 0x00026000 File Offset: 0x00024200
	private void NICLFONLAIJ(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 45, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "21,22,23" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-86);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[1];
			array[0] = "_DeepTex";
			array[1] = base.GetInstanceID();
			array[0] = "IdleStun";
			array[1] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[4];
			array2[0] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)96;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000242 RID: 578 RVA: 0x00026180 File Offset: 0x00024380
	private void FEINJDFCEBE(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 56, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "\n" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[1];
			array[0] = "IceHockeyDekeMiddle";
			array[1] = base.GetInstanceID();
			array[3] = "wpn_eat3";
			array[3] = GGEHECFCPMD.GetInstanceID();
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
			gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000243 RID: 579 RVA: 0x00026300 File Offset: 0x00024500
	private void BIKMJJOJJDO(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Color;
		OLFKAHHACBC.backgroundColor = new Color(733f, 1876f, 1800f, 448f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = true;
		if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
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
			cameraLayersDistance.DKKFMEFLNJN();
		}
	}

	// Token: 0x06000244 RID: 580 RVA: 0x00026440 File Offset: 0x00024640
	private void IDLLAMOBGGO()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000245 RID: 581 RVA: 0x000264D4 File Offset: 0x000246D4
	private void PONBHONJGEF(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -28, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "RollerBladeTurnRight" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)83;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[]
			{
				" ms",
				base.GetInstanceID(),
				null,
				null,
				null,
				null,
				null,
				"Special"
			};
			array[4] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[1];
			array2[1] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000246 RID: 582 RVA: 0x00026654 File Offset: 0x00024854
	private void IMOKDCHKOHM(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Skybox;
		OLFKAHHACBC.backgroundColor = new Color(1783f, 1635f, 852f, 1313f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = false;
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
			cameraLayersDistance.HKFHDEGLLEI();
		}
	}

	// Token: 0x06000247 RID: 583 RVA: 0x00026794 File Offset: 0x00024994
	public void GFEBFGGIFKP()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.AONMCCAFCGE(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PCMMNIJEGGH(current, camera);
		camera.cullingMask = (-52 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("_Rand"))
			{
				material.SetTexture("F2", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000248 RID: 584 RVA: 0x000268B4 File Offset: 0x00024AB4
	private void MIGCJEBFMJP(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Skybox;
		OLFKAHHACBC.backgroundColor = new Color(835f, 1261f, 927f, 1492f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = false;
		OLFKAHHACBC.useOcclusionCulling = true;
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
			cameraLayersDistance.DKKFMEFLNJN();
		}
	}

	// Token: 0x06000249 RID: 585 RVA: 0x000269F4 File Offset: 0x00024BF4
	public void NJLDADAPIMF()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.DHONCBLHPJO(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.IMBEHAJNHPJ(current, camera);
		camera.cullingMask = (-92 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 0; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("IdleStrafeLeft"))
			{
				material.SetTexture("_WaterLevel", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x0600024A RID: 586 RVA: 0x00026B14 File Offset: 0x00024D14
	private void NPFCGNMLMKK(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)8;
		OLFKAHHACBC.backgroundColor = new Color(1565f, 744f, 1307f, 469f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = true;
		if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
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
			cameraLayersDistance.MOEKJKGNLCI();
		}
	}

	// Token: 0x0600024B RID: 587 RVA: 0x00026C54 File Offset: 0x00024E54
	private void PLDKCCLDICG(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 14, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "_AdaptationMax" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[4];
			array[0] = "money";
			array[0] = base.GetInstanceID();
			array[2] = "";
			array[5] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[4];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x0600024C RID: 588 RVA: 0x00026DD4 File Offset: 0x00024FD4
	private void IDFEHJKAJAM()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600024D RID: 589 RVA: 0x00026E68 File Offset: 0x00025068
	private void GBMOIBOFDKG(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Nothing;
		OLFKAHHACBC.backgroundColor = new Color(1095f, 1298f, 715f, 1154f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = true;
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
			cameraLayersDistance.HJPBFHAEJHG();
		}
	}

	// Token: 0x0600024E RID: 590 RVA: 0x00026FA8 File Offset: 0x000251A8
	private void FGHHAIDJNMM()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600024F RID: 591 RVA: 0x0002703C File Offset: 0x0002523C
	private void ONMCHILMFKI(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)5;
		OLFKAHHACBC.backgroundColor = new Color(929f, 694f, 548f, 1608f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = false;
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
			cameraLayersDistance.MOEKJKGNLCI();
		}
	}

	// Token: 0x06000250 RID: 592 RVA: 0x0002717C File Offset: 0x0002537C
	private void KGCKNABGBOB(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -27, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = ", " + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-117);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[0];
			array[0] = "#ff6000";
			array[1] = base.GetInstanceID();
			array[1] = "_FadeDistance";
			array[3] = GGEHECFCPMD.GetInstanceID();
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
			gameObject.hideFlags = (HideFlags)107;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000251 RID: 593 RVA: 0x000272FC File Offset: 0x000254FC
	private void MNLJPDFIBEO(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)0;
		OLFKAHHACBC.backgroundColor = new Color(226f, 841f, 352f, 1762f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = true;
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
			cameraLayersDistance.ENDOJDMLEIJ();
		}
	}

	// Token: 0x06000252 RID: 594 RVA: 0x0002743C File Offset: 0x0002563C
	private void FBLGGMDKAPB(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 49, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "GiantGrabThrow2" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[5];
			array[0] = "_FogAreaData";
			array[0] = base.GetInstanceID();
			array[7] = "";
			array[1] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[0];
			array2[0] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000253 RID: 595 RVA: 0x000275BC File Offset: 0x000257BC
	private void BIDOGNIGPED()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000254 RID: 596 RVA: 0x00027650 File Offset: 0x00025850
	private void AGDCGJGOKMJ(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -30, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-117);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[5];
			array[0] = "paper.wav";
			array[0] = base.GetInstanceID();
			array[8] = "wgt_big.dat";
			array[7] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[4];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000255 RID: 597 RVA: 0x000277D0 File Offset: 0x000259D0
	private void BNKNFGKAKJO(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -28, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "Katana" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-107);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[8];
			array[1] = "_QualitySettings";
			array[1] = base.GetInstanceID();
			array[5] = "_WaterMap";
			array[5] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[8];
			array2[0] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-100);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00027950 File Offset: 0x00025B50
	public void DJACMACBHIF()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.LPAPOJHKGON(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.OJNHEMINLGD(current, camera);
		camera.cullingMask = (-90 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i++)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("\n"))
			{
				material.SetTexture("paramsup=", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x06000257 RID: 599 RVA: 0x00027A70 File Offset: 0x00025C70
	public void JHMKNIKCBOO()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.KGCKNABGBOB(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PHPHNICIEIO(current, camera);
		camera.cullingMask = (-52 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty(">"))
			{
				material.SetTexture(" ", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x06000258 RID: 600 RVA: 0x00027B90 File Offset: 0x00025D90
	private void PJFCOKNCDEA(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)7;
		OLFKAHHACBC.backgroundColor = new Color(1546f, 526f, 1726f, 107f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = true;
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
			cameraLayersDistance.AMAIGEONAFH();
		}
	}

	// Token: 0x06000259 RID: 601 RVA: 0x00027CD0 File Offset: 0x00025ED0
	private void FKENEAAEBBG(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -81, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "<color='#804020'>" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[1];
			array[0] = "_Opacity";
			array[1] = base.GetInstanceID();
			array[7] = "\n";
			array[7] = GGEHECFCPMD.GetInstanceID();
			GameObject gameObject = new GameObject(string.Concat(array), new Type[]
			{
				typeof(Camera),
				typeof(Skybox)
			});
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x0600025A RID: 602 RVA: 0x00027E50 File Offset: 0x00026050
	private void HFOPMECKKPF()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600025B RID: 603 RVA: 0x00027EE4 File Offset: 0x000260E4
	private void INFGHLOEKGC(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Nothing;
		OLFKAHHACBC.backgroundColor = new Color(1780f, 1828f, 86f, 1818f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = false;
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
			cameraLayersDistance.OPKKNMLEGMA();
		}
	}

	// Token: 0x0600025C RID: 604 RVA: 0x00028024 File Offset: 0x00026224
	public void HKLMGFBBJOD()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.AJJAFODOCGL(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.MIGCJEBFMJP(current, camera);
		camera.cullingMask = (49 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 0; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("RunJump"))
			{
				material.SetTexture("", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x0600025D RID: 605 RVA: 0x00028144 File Offset: 0x00026344
	private void GKGGKCKMEJE(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 11, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-78);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[4];
			array[1] = "ShootWireframeModule";
			array[0] = base.GetInstanceID();
			array[4] = "Ок";
			array[2] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[4];
			array2[1] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x0600025E RID: 606 RVA: 0x000282C4 File Offset: 0x000264C4
	public void MPMJLCFLLIN()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.FBLGGMDKAPB(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.MIPIIOPHNKN(current, camera);
		camera.cullingMask = (86 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		foreach (Material material in base.GetComponent<Renderer>().sharedMaterials)
		{
			if (material.HasProperty("Wizard 2 Hand Throw"))
			{
				material.SetTexture("22", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x0600025F RID: 607 RVA: 0x000283E4 File Offset: 0x000265E4
	private void MILHLKDHMED(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 108, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "isBreak" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)127;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[1];
			array[0] = "inv_bonus";
			array[1] = base.GetInstanceID();
			array[2] = "emergencyMode";
			array[3] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[7];
			array2[0] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~HideFlags.HideInInspector;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000260 RID: 608 RVA: 0x00028564 File Offset: 0x00026764
	private void JKPFHEMMGBJ(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Color;
		OLFKAHHACBC.backgroundColor = new Color(534f, 745f, 225f, 2f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = false;
		OLFKAHHACBC.useOcclusionCulling = true;
		if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
		{
			Skybox skybox = BNDNKLBIJJF.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = OLFKAHHACBC.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = true;
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
			cameraLayersDistance.FPNMJKPFIPL();
		}
	}

	// Token: 0x06000261 RID: 609 RVA: 0x000286A4 File Offset: 0x000268A4
	public void PPNNGMABLNH()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.BNKNFGKAKJO(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.FFPCENGBBCB(current, camera);
		camera.cullingMask = (90 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 0; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("Mouse X"))
			{
				material.SetTexture("", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000262 RID: 610 RVA: 0x000287C4 File Offset: 0x000269C4
	public void EPDIKCBACNP()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.JKNKLLHKEDN(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PLHGBEEDNJN(current, camera);
		camera.cullingMask = (-31 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i++)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("act_prof_{0}"))
			{
				material.SetTexture("[quote]", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x06000263 RID: 611 RVA: 0x000288E4 File Offset: 0x00026AE4
	public void FGHOKEKFHGG()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.OKCFBNCACNB(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PLHGBEEDNJN(current, camera);
		camera.cullingMask = (-68 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i++)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("_OcclusionBlurTexture"))
			{
				material.SetTexture("ClimbUp", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000264 RID: 612 RVA: 0x00028A04 File Offset: 0x00026C04
	private void GOPPJCGEANP(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -38, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "Water Refl Camera id" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-73);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[6];
			array[1] = "drag_onmousedown.wav";
			array[0] = base.GetInstanceID();
			array[8] = "inv_minreq";
			array[2] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[0];
			array2[0] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-97);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000265 RID: 613 RVA: 0x00028B84 File Offset: 0x00026D84
	public void LMCJNKPLCID()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.FLAGMJGGBNI(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.BIKMJJOJJDO(current, camera);
		camera.cullingMask = (63 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i++)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("\n"))
			{
				material.SetTexture("Crate Pull", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000266 RID: 614 RVA: 0x00028CA4 File Offset: 0x00026EA4
	private void GDCAKFIINFI()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000267 RID: 615 RVA: 0x00028D38 File Offset: 0x00026F38
	private void PHIACAJNNIG()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000268 RID: 616 RVA: 0x00028DCC File Offset: 0x00026FCC
	private void MKBPPPJKLLF()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000269 RID: 617 RVA: 0x00028E60 File Offset: 0x00027060
	private void GBAEKFJBEFM()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600026A RID: 618 RVA: 0x00028EF4 File Offset: 0x000270F4
	private void LPAPOJHKGON(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 120, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "_BlurPass" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-1);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[4];
			array[1] = "<color=\"";
			array[1] = base.GetInstanceID();
			array[6] = "_ZCurve";
			array[4] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[7];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
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

	// Token: 0x0600026B RID: 619 RVA: 0x00029074 File Offset: 0x00027274
	private void FKDGPHFONPB()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600026C RID: 620 RVA: 0x00029108 File Offset: 0x00027308
	private void NGKEFEKCMOD()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600026D RID: 621 RVA: 0x0002919C File Offset: 0x0002739C
	public void IBFEAHNHJCB()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.LCMBFOFNAKJ(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PHPHNICIEIO(current, camera);
		camera.cullingMask = (52 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 0; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("360SpinDeath"))
			{
				material.SetTexture("trn_reg", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x0600026E RID: 622 RVA: 0x000292BC File Offset: 0x000274BC
	public void MFAHBPKLCMF()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.EBIAKHJFNKG(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.JKPFHEMMGBJ(current, camera);
		camera.cullingMask = (22 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 0; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("_AdaptationMin"))
			{
				material.SetTexture("act_orderb_", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x0600026F RID: 623 RVA: 0x000293DC File Offset: 0x000275DC
	private void CKHKBPFMPDB(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)0;
		OLFKAHHACBC.backgroundColor = new Color(237f, 1153f, 1732f, 90f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = false;
		OLFKAHHACBC.useOcclusionCulling = false;
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
			cameraLayersDistance.IJBFMLLJONF();
		}
	}

	// Token: 0x06000270 RID: 624 RVA: 0x0002951C File Offset: 0x0002771C
	private void FFPCENGBBCB(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Color;
		OLFKAHHACBC.backgroundColor = new Color(1106f, 573f, 1895f, 756f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = false;
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
			cameraLayersDistance.FCFDNBHJEFP();
		}
	}

	// Token: 0x06000271 RID: 625 RVA: 0x0002965C File Offset: 0x0002785C
	private void LAHIHKMMDBP(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -73, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "-HYPERLINK" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-91);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[7];
			array[0] = "ZombieWalk";
			array[0] = base.GetInstanceID();
			array[7] = "RussianDance";
			array[1] = GGEHECFCPMD.GetInstanceID();
			GameObject gameObject = new GameObject(string.Concat(array), new Type[]
			{
				typeof(Camera),
				typeof(Skybox)
			});
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = HideFlags.HideInHierarchy;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000272 RID: 626 RVA: 0x000297DC File Offset: 0x000279DC
	private void IPNIABKAHMA(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)7;
		OLFKAHHACBC.backgroundColor = new Color(848f, 1882f, 171f, 1912f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = false;
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
			cameraLayersDistance.IJBFMLLJONF();
		}
	}

	// Token: 0x06000273 RID: 627 RVA: 0x0002991C File Offset: 0x00027B1C
	private void HMKNFKOIJFA(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 51, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "IdleStrafeRight" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[4];
			array[1] = "FA";
			array[1] = base.GetInstanceID();
			array[4] = "";
			array[7] = GGEHECFCPMD.GetInstanceID();
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
			gameObject.hideFlags = (HideFlags)126;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00029A9C File Offset: 0x00027C9C
	private void HGLALMHOBLO()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00029B30 File Offset: 0x00027D30
	private void PBICOFOGOLF()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000276 RID: 630 RVA: 0x00029BC4 File Offset: 0x00027DC4
	private void POPEHFLLDAI()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000277 RID: 631 RVA: 0x00029C58 File Offset: 0x00027E58
	private void DIOLDBHDBGJ(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)5;
		OLFKAHHACBC.backgroundColor = new Color(1697f, 825f, 130f, 117f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = false;
		OLFKAHHACBC.useOcclusionCulling = false;
		if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
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
			cameraLayersDistance.CICNHKJAOPH();
		}
	}

	// Token: 0x06000278 RID: 632 RVA: 0x00029D98 File Offset: 0x00027F98
	public void CHLJHJGEHCP()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.DIHBENNEJOI(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PLHGBEEDNJN(current, camera);
		camera.cullingMask = (53 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i++)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("' is not a valid integer"))
			{
				material.SetTexture("Climb Left", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000279 RID: 633 RVA: 0x00029EB8 File Offset: 0x000280B8
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
			this.EACNIDNGPBL.name = "__Refraction" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = HideFlags.DontSave;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			GameObject gameObject = new GameObject(string.Concat(new object[]
			{
				"__Refraction Camera id",
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

	// Token: 0x0600027A RID: 634 RVA: 0x0002A038 File Offset: 0x00028238
	public void KLEFJFAIDGG()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.BBONDKPHBEA(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.MNLJPDFIBEO(current, camera);
		camera.cullingMask = (-65 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i++)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("isWoman"))
			{
				material.SetTexture(" x", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x0600027B RID: 635 RVA: 0x0002A158 File Offset: 0x00028358
	private void LNNKANCIIFM()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600027C RID: 636 RVA: 0x0002A1EC File Offset: 0x000283EC
	private void GHMPNEMHKEB(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)8;
		OLFKAHHACBC.backgroundColor = new Color(682f, 1119f, 588f, 1704f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = true;
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
			cameraLayersDistance.HBEEPAEEKNE();
		}
	}

	// Token: 0x0600027D RID: 637 RVA: 0x0002A32C File Offset: 0x0002852C
	private void IHFBIDLNMAH(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -93, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "_CameraClipInfo" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[6];
			array[1] = "OneHandSwordSwing";
			array[0] = base.GetInstanceID();
			array[1] = "";
			array[1] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[]
			{
				null,
				typeof(Camera)
			};
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = HideFlags.HideAndDontSave;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x0600027E RID: 638 RVA: 0x0002A4AC File Offset: 0x000286AC
	private void MPKGAMMPEJL(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 86, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-71);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[2];
			array[0] = "MotorbikeWheelyNoHands";
			array[0] = base.GetInstanceID();
			array[4] = "PrimaryCausticsProjector";
			array[3] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[3];
			array2[1] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = HideFlags.None;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x0600027F RID: 639 RVA: 0x0002A62C File Offset: 0x0002882C
	private void PDNBJJGKOEB(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Color;
		OLFKAHHACBC.backgroundColor = new Color(534f, 863f, 1821f, 4f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = true;
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
			cameraLayersDistance.HKOECJMFMEG();
		}
	}

	// Token: 0x06000280 RID: 640 RVA: 0x0002A76C File Offset: 0x0002896C
	private void NMCIALANIHJ()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000281 RID: 641 RVA: 0x0002A800 File Offset: 0x00028A00
	private void NOLGMGLINIJ()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000282 RID: 642 RVA: 0x0002A894 File Offset: 0x00028A94
	private void LCMBFOFNAKJ(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -58, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "__c" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[0];
			array[1] = "Hidden/Post FX/Bloom";
			array[1] = base.GetInstanceID();
			array[6] = "_Direction";
			array[2] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[3];
			array2[0] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000283 RID: 643 RVA: 0x0002AA14 File Offset: 0x00028C14
	private void MEPFAJEEJLN(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 21, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "WizardPowerUp" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[4];
			array[1] = "MotorbikeShootLeft";
			array[1] = base.GetInstanceID();
			array[0] = "ComeHere";
			array[6] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[5];
			array2[0] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-66);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000285 RID: 645 RVA: 0x0002ABC0 File Offset: 0x00028DC0
	public void KLIMHPFEFHP()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.OKCFBNCACNB(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PLHGBEEDNJN(current, camera);
		camera.cullingMask = (-98 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		foreach (Material material in base.GetComponent<Renderer>().sharedMaterials)
		{
			if (material.HasProperty("_FogSkyData"))
			{
				material.SetTexture("altosad", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000286 RID: 646 RVA: 0x0002ACE0 File Offset: 0x00028EE0
	private void HNMAJPKOFEE(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -80, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = " has invalid children array. Child index is < 0." + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)82;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[2];
			array[0] = "";
			array[0] = base.GetInstanceID();
			array[8] = "Finished";
			array[3] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[8];
			array2[0] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = HideFlags.None;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x06000287 RID: 647 RVA: 0x0002AE60 File Offset: 0x00029060
	public void NJEAKIPNLME()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.MPKGAMMPEJL(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.AOKJKOHJMJI(current, camera);
		camera.cullingMask = (2 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 0; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("Sound/Ambients/"))
			{
				material.SetTexture("usr_inf_a1", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x06000288 RID: 648 RVA: 0x0002AF80 File Offset: 0x00029180
	private void LJGLOIINIIO(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Skybox;
		OLFKAHHACBC.backgroundColor = new Color(91f, 431f, 1827f, 1829f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = true;
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
			cameraLayersDistance.BGGCPOFFMFN();
		}
	}

	// Token: 0x06000289 RID: 649 RVA: 0x0002B0C0 File Offset: 0x000292C0
	private void DAIKHLLJCPL()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600028A RID: 650 RVA: 0x0002B154 File Offset: 0x00029354
	private void AOILKGIIKDF()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600028B RID: 651 RVA: 0x0002B1E8 File Offset: 0x000293E8
	private void PIPJPGGEFOL()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600028C RID: 652 RVA: 0x0002B27C File Offset: 0x0002947C
	private void PCMMNIJEGGH(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Skybox;
		OLFKAHHACBC.backgroundColor = new Color(246f, 874f, 1625f, 1410f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = true;
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
			cameraLayersDistance.IJBFMLLJONF();
		}
	}

	// Token: 0x0600028D RID: 653 RVA: 0x0002B3BC File Offset: 0x000295BC
	private void EBIAKHJFNKG(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -7, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "AssetBundleManager" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = ~HideFlags.NotEditable;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[0];
			array[1] = "crft_to";
			array[1] = base.GetInstanceID();
			array[3] = "isAlwaisGetFish";
			array[4] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[4];
			array2[1] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)86;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x0600028E RID: 654 RVA: 0x0002B53C File Offset: 0x0002973C
	private void MPFBAEGNPFK()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x0600028F RID: 655 RVA: 0x0002B5D0 File Offset: 0x000297D0
	private void MHFPELLBKDG(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)0;
		OLFKAHHACBC.backgroundColor = new Color(1048f, 1886f, 224f, 1867f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = false;
		if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
		{
			Skybox skybox = BNDNKLBIJJF.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = OLFKAHHACBC.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = true;
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
			cameraLayersDistance.LBPCEPLOMDM();
		}
	}

	// Token: 0x06000290 RID: 656 RVA: 0x0002B710 File Offset: 0x00029910
	public void IMFMAPJABON()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.DHONCBLHPJO(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.MNLJPDFIBEO(current, camera);
		camera.cullingMask = (34 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("basePar"))
			{
				material.SetTexture("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000291 RID: 657 RVA: 0x0002B830 File Offset: 0x00029A30
	private void PHPHNICIEIO(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Depth;
		OLFKAHHACBC.backgroundColor = new Color(1277f, 27f, 942f, 3f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = true;
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
			cameraLayersDistance.IMHMNIGJJCG();
		}
	}

	// Token: 0x06000292 RID: 658 RVA: 0x0002B970 File Offset: 0x00029B70
	private void BMLMKAGHDDE()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000293 RID: 659 RVA: 0x0002BA04 File Offset: 0x00029C04
	private void CFGNNEDOHJI(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Color;
		OLFKAHHACBC.backgroundColor = new Color(775f, 557f, 1417f, 821f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = true;
		OLFKAHHACBC.useOcclusionCulling = false;
		if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
		{
			Skybox skybox = BNDNKLBIJJF.GetComponent(typeof(Skybox)) as Skybox;
			Skybox skybox2 = OLFKAHHACBC.GetComponent(typeof(Skybox)) as Skybox;
			if (!skybox || !skybox.material)
			{
				skybox2.enabled = true;
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
			cameraLayersDistance.HKOECJMFMEG();
		}
	}

	// Token: 0x06000294 RID: 660 RVA: 0x0002BB44 File Offset: 0x00029D44
	public void JHAJKOCPLFH()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.OMGBIJEPICP(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PHPHNICIEIO(current, camera);
		camera.cullingMask = (68 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		foreach (Material material in base.GetComponent<Renderer>().sharedMaterials)
		{
			if (material.HasProperty("Full Body IK is missing the right upper arm node."))
			{
				material.SetTexture("reputaion/fractions/fraction", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000295 RID: 661 RVA: 0x0002BC64 File Offset: 0x00029E64
	public void ABPIKDFFNID()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.LPAPOJHKGON(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.IIKBAJBOIGD(current, camera);
		camera.cullingMask = (104 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("noresult"))
			{
				material.SetTexture("FactoryTempTexture", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x06000296 RID: 662 RVA: 0x0002BD84 File Offset: 0x00029F84
	private void EMOJPGFOHNG(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)6;
		OLFKAHHACBC.backgroundColor = new Color(633f, 1020f, 656f, 425f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = false;
		OLFKAHHACBC.useOcclusionCulling = true;
		if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
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
			cameraLayersDistance.KHAEPHLHDOE();
		}
	}

	// Token: 0x06000297 RID: 663 RVA: 0x0002BEC4 File Offset: 0x0002A0C4
	private void POAKJBMCDKL(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Depth;
		OLFKAHHACBC.backgroundColor = new Color(1462f, 896f, 629f, 1499f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = true;
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
			cameraLayersDistance.IMHMNIGJJCG();
		}
	}

	// Token: 0x06000298 RID: 664 RVA: 0x0002C004 File Offset: 0x0002A204
	private void OILPEJCKAKJ()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x06000299 RID: 665 RVA: 0x0002C098 File Offset: 0x0002A298
	public void OAPBLKMHFEJ()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.FLAGMJGGBNI(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PLHGBEEDNJN(current, camera);
		camera.cullingMask = (92 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		foreach (Material material in base.GetComponent<Renderer>().sharedMaterials)
		{
			if (material.HasProperty("#2080ff"))
			{
				material.SetTexture("_TapMedium", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x0600029A RID: 666 RVA: 0x0002C1B8 File Offset: 0x0002A3B8
	public void BABCJHNMJAJ()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.BNKNFGKAKJO(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.OJNHEMINLGD(current, camera);
		camera.cullingMask = (28 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i++)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("OfficeSittingReading"))
			{
				material.SetTexture("{not_found}", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x0600029B RID: 667 RVA: 0x0002C2D8 File Offset: 0x0002A4D8
	public void BPDOFKNDCAH()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.IHFBIDLNMAH(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.DIOLDBHDBGJ(current, camera);
		camera.cullingMask = (86 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 1; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("cht_ach3"))
			{
				material.SetTexture("BowReady", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x0600029C RID: 668 RVA: 0x0002C3F8 File Offset: 0x0002A5F8
	public void HNGBAECBONC()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.BNKNFGKAKJO(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.LJGLOIINIIO(current, camera);
		camera.cullingMask = (107 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 0; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("<color='#606080'>+{0}</color>"))
			{
				material.SetTexture("shopCount", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x0600029D RID: 669 RVA: 0x0002C518 File Offset: 0x0002A718
	public void POHBGFLGAKJ()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.FBLGGMDKAPB(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.ONMCHILMFKI(current, camera);
		camera.cullingMask = (96 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 0; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("SoccerRun"))
			{
				material.SetTexture("_MainTex", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x0600029E RID: 670 RVA: 0x0002C638 File Offset: 0x0002A838
	private void IMBEHAJNHPJ(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)8;
		OLFKAHHACBC.backgroundColor = new Color(679f, 1456f, 1196f, 427f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = false;
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
			cameraLayersDistance.UpdateLayers();
		}
	}

	// Token: 0x0600029F RID: 671 RVA: 0x0002C778 File Offset: 0x0002A978
	private void ACJNCDAHJDE()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x0002C80C File Offset: 0x0002AA0C
	private void LNEJPGDHJOJ()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x0002C8A0 File Offset: 0x0002AAA0
	private void PLHGBEEDNJN(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Depth;
		OLFKAHHACBC.backgroundColor = new Color(1444f, 1597f, 493f, 1914f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = true;
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
			cameraLayersDistance.MOEKJKGNLCI();
		}
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x0002C9E0 File Offset: 0x0002ABE0
	public void LIGGOKAONKI()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.GOPPJCGEANP(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.GHMPNEMHKEB(current, camera);
		camera.cullingMask = (51 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		foreach (Material material in base.GetComponent<Renderer>().sharedMaterials)
		{
			if (material.HasProperty("t_beard"))
			{
				material.SetTexture("body", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x0002CB00 File Offset: 0x0002AD00
	public void HNMJFCDKHLP()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.LGEMPOHAONA(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.NPIOCACDHJO(current, camera);
		camera.cullingMask = (42 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		foreach (Material material in base.GetComponent<Renderer>().sharedMaterials)
		{
			if (material.HasProperty("run"))
			{
				material.SetTexture(" %\n", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x0002CC20 File Offset: 0x0002AE20
	private void AOKJKOHJMJI(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = (CameraClearFlags)7;
		OLFKAHHACBC.backgroundColor = new Color(47f, 1431f, 124f, 249f);
		OLFKAHHACBC.allowMSAA = false;
		OLFKAHHACBC.allowHDR = true;
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
			cameraLayersDistance.FPNMJKPFIPL();
		}
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x0002CD60 File Offset: 0x0002AF60
	public void NHMGPAMANLP()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.INPHAEAEMAJ(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.PLHGBEEDNJN(current, camera);
		camera.cullingMask = (-86 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 0; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("B"))
			{
				material.SetTexture("pempty", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x0002CE80 File Offset: 0x0002B080
	private void JKNKLLHKEDN(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 29, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[8];
			array[1] = "level";
			array[0] = base.GetInstanceID();
			array[6] = "Wizard Power Up";
			array[3] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[5];
			array2[1] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-92);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x0002D000 File Offset: 0x0002B200
	public void JDKDMLMEDLD()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
		Camera camera;
		this.AGDCGJGOKMJ(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.MNLJPDFIBEO(current, camera);
		camera.cullingMask = (75 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		foreach (Material material in base.GetComponent<Renderer>().sharedMaterials)
		{
			if (material.HasProperty("https://www.youtube.com/watch?v=7__IafZGwvI"))
			{
				material.SetTexture("OfficeSittingReading", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x0002D120 File Offset: 0x0002B320
	private void ANHJAOPPMCI()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x0002D1B4 File Offset: 0x0002B3B4
	private void CKGJGPKNMPG(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 52, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "#ff6000" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags)100;
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[7];
			array[0] = "";
			array[0] = base.GetInstanceID();
			array[4] = "_MainTex";
			array[7] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[6];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)97;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060002AA RID: 682 RVA: 0x0002D334 File Offset: 0x0002B534
	private void BBONDKPHBEA(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, 102, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[1];
			array[1] = "ok";
			array[1] = base.GetInstanceID();
			array[1] = "WateringCanWatering";
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
			gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060002AB RID: 683 RVA: 0x0002D4B4 File Offset: 0x0002B6B4
	public void AOGEHOCOCAN()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.EBIAKHJFNKG(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.IIKBAJBOIGD(current, camera);
		camera.cullingMask = (-38 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 0; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("Roll"))
			{
				material.SetTexture("*************157 baseid=", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
	}

	// Token: 0x060002AC RID: 684 RVA: 0x0002D5D4 File Offset: 0x0002B7D4
	public void JDCPHOIHGHE()
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
		if (AquaRefractLayer.JDIEFDMMHKG)
		{
			return;
		}
		AquaRefractLayer.JDIEFDMMHKG = true;
		Camera camera;
		this.HNMAJPKOFEE(current, out camera);
		Vector3 position = base.transform.position;
		Vector3 up = base.transform.up;
		this.MIPIIOPHNKN(current, camera);
		camera.cullingMask = (-50 & this.m_RefractLayers.value);
		camera.targetTexture = this.EACNIDNGPBL;
		camera.transform.position = current.transform.position;
		camera.transform.rotation = current.transform.rotation;
		camera.Render();
		Material[] sharedMaterials = base.GetComponent<Renderer>().sharedMaterials;
		for (int i = 0; i < sharedMaterials.Length; i += 0)
		{
			Material material = sharedMaterials[i];
			if (material.HasProperty("Shaders/EyeHistogram"))
			{
				material.SetTexture("#b0ffa0", this.EACNIDNGPBL);
			}
		}
		AquaRefractLayer.JDIEFDMMHKG = false;
	}

	// Token: 0x060002AD RID: 685 RVA: 0x0002D6F4 File Offset: 0x0002B8F4
	private void LLNDMAIMABN(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -3, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "russian" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-124);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[7];
			array[0] = "WorkerPickaxe2";
			array[1] = base.GetInstanceID();
			array[2] = "*** updateDetailWpnInfo  ";
			array[5] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[1];
			array2[1] = typeof(Camera);
			array2[1] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = true;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)(-91);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060002AE RID: 686 RVA: 0x0002D874 File Offset: 0x0002BA74
	private void HMLMENDFKHA()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x060002AF RID: 687 RVA: 0x0002D908 File Offset: 0x0002BB08
	private void HGHMOGJJFBB(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -105, RenderTextureFormat.ARGB32);
			this.EACNIDNGPBL.name = "help" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = true;
			this.EACNIDNGPBL.hideFlags = (HideFlags)(-68);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[7];
			array[1] = "Called GetNumberOfCurrentPlayers()";
			array[0] = base.GetInstanceID();
			array[2] = "lastRatingIndex";
			array[1] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[5];
			array2[0] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = (HideFlags)83;
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x0002DA88 File Offset: 0x0002BC88
	private void BLAOOIKPENH(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
	{
		if (OLFKAHHACBC == null)
		{
			return;
		}
		OLFKAHHACBC.clearFlags = CameraClearFlags.Skybox;
		OLFKAHHACBC.backgroundColor = new Color(1913f, 1408f, 116f, 1215f);
		OLFKAHHACBC.allowMSAA = true;
		OLFKAHHACBC.allowHDR = true;
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
			cameraLayersDistance.MOEKJKGNLCI();
		}
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x0002DBC8 File Offset: 0x0002BDC8
	private void DHONCBLHPJO(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA)
	{
		OAMNCKHIPLA = null;
		if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.m_TextureSize)
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			}
			this.EACNIDNGPBL = new RenderTexture(this.m_TextureSize, this.m_TextureSize, -33, RenderTextureFormat.Depth);
			this.EACNIDNGPBL.name = "https://groups.google.com/forum/#!forum/final-ik" + base.GetInstanceID();
			this.EACNIDNGPBL.isPowerOfTwo = false;
			this.EACNIDNGPBL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
			this.DHBOBNEFLOG = this.m_TextureSize;
		}
		OAMNCKHIPLA = (this.BMOECLNNGDF[GGEHECFCPMD] as Camera);
		if (!OAMNCKHIPLA)
		{
			object[] array = new object[5];
			array[0] = "auc_wcstc";
			array[0] = base.GetInstanceID();
			array[1] = "cht_msg26";
			array[6] = GGEHECFCPMD.GetInstanceID();
			string name = string.Concat(array);
			Type[] array2 = new Type[3];
			array2[0] = typeof(Camera);
			array2[0] = typeof(Skybox);
			GameObject gameObject = new GameObject(name, array2);
			OAMNCKHIPLA = gameObject.GetComponent<Camera>();
			OAMNCKHIPLA.enabled = false;
			OAMNCKHIPLA.transform.position = base.transform.position;
			OAMNCKHIPLA.transform.rotation = base.transform.rotation;
			OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
			gameObject.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
		}
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x0002DD48 File Offset: 0x0002BF48
	private void DCPLDAKDDBG()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x0002DDDC File Offset: 0x0002BFDC
	private void OnDisable()
	{
		if (this.EACNIDNGPBL)
		{
			UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
			this.EACNIDNGPBL = null;
		}
		foreach (object obj in this.BMOECLNNGDF)
		{
			UnityEngine.Object.DestroyImmediate(((Camera)((DictionaryEntry)obj).Value).gameObject);
		}
		this.BMOECLNNGDF.Clear();
	}

	// Token: 0x04000084 RID: 132
	public int m_TextureSize = 256;

	// Token: 0x04000085 RID: 133
	public LayerMask m_RefractLayers = -1;

	// Token: 0x04000086 RID: 134
	private Hashtable BMOECLNNGDF = new Hashtable();

	// Token: 0x04000087 RID: 135
	private RenderTexture EACNIDNGPBL;

	// Token: 0x04000088 RID: 136
	private int DHBOBNEFLOG;

	// Token: 0x04000089 RID: 137
	private static bool JDIEFDMMHKG;
}
