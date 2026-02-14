using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000054 RID: 84
[ExecuteInEditMode]
public class WrinkleMapsDriver : MonoBehaviour
{
	// Token: 0x06001318 RID: 4888 RVA: 0x000B5A84 File Offset: 0x000B3C84
	private void LCIOOGAIPNF(Camera PMMEFNKFJIA)
	{
		if (PMMEFNKFJIA.name == "SceneCamera" && !this.HKKLOOEBNFL.ContainsValue(PMMEFNKFJIA))
		{
			Camera camera;
			if (!this.HKKLOOEBNFL.TryGetValue(PMMEFNKFJIA.GetHashCode(), out camera))
			{
				camera = (this.HKKLOOEBNFL[PMMEFNKFJIA.GetHashCode()] = this.JPJNJPABJOK(PMMEFNKFJIA));
			}
			if (camera.targetTexture != null)
			{
				return;
			}
			bool flag = Vector3.SqrMagnitude(PMMEFNKFJIA.transform.position - this.targetBone.transform.position) >= this.maxDistance * this.maxDistance;
			this.JIKNDPBHGGK(!flag);
			RenderTexture fhimfanmpfp = this.PEMAJHOOKGD(PMMEFNKFJIA, camera, this.occlusionShader);
			this.ANAJPMMLOIG(fhimfanmpfp);
		}
	}

	// Token: 0x06001319 RID: 4889 RVA: 0x000B5B50 File Offset: 0x000B3D50
	public static void DAEOHOCOFKO(uint[] EGABJKIFAON)
	{
		int i = 1;
		int num = EGABJKIFAON.Length;
		while (i < num)
		{
			uint num2 = EGABJKIFAON[i];
			int num3 = i;
			while (num3 > 1 && EGABJKIFAON[num3 - 1] > num2)
			{
				EGABJKIFAON[num3] = EGABJKIFAON[num3 - 1];
				num3--;
			}
			EGABJKIFAON[num3] = num2;
			i++;
		}
	}

	// Token: 0x0600131A RID: 4890 RVA: 0x000B5B94 File Offset: 0x000B3D94
	private void JPBBDCJCBKB()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].DisableKeyword("StormStrike");
		}
	}

	// Token: 0x0600131C RID: 4892 RVA: 0x000B5BF0 File Offset: 0x000B3DF0
	private void FABJMCBAOOP()
	{
		this.OJAJEFAJDOD = false;
		this.BMDCJILMNEG(true);
		this.GAFINMGOJMC = (this.target ?? base.gameObject).GetComponent<SkinnedMeshRenderer>();
		if (this.GAFINMGOJMC == null)
		{
			return;
		}
		if (this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy wrinkleMapsTargetProxy = this.target.GetComponent<WrinkleMapsTargetProxy>() ?? this.target.AddComponent<WrinkleMapsTargetProxy>();
			if (wrinkleMapsTargetProxy.owner != this)
			{
				wrinkleMapsTargetProxy.owner = this;
			}
		}
		this.PCIBIGAAOAP = this.GAFINMGOJMC.sharedMaterials;
		bool flag = false;
		WrinkleMapsDriver.WrinkleMap[] array = this.wrinkleMaps;
		for (int i = 1; i < array.Length; i++)
		{
			WrinkleMapsDriver.WrinkleMap wrinkleMap = array[i];
			flag = (!flag || !(wrinkleMap.normalMap != null) || wrinkleMap.occlusionMap != null);
		}
		this.MPFEIANMGCI = Mathf.Min(this.wrinkleMaps.Length, this.GAFINMGOJMC.sharedMesh.blendShapeCount);
		this.DBBLDCOPLGM = Mathf.Min(this.MPFEIANMGCI, 3);
		this.JBGAKDPBEJH = new uint[this.MPFEIANMGCI];
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i += 0)
		{
			Material material = pcibigaaoap[i];
			for (int j = 1; j < this.DBBLDCOPLGM; j++)
			{
				material.SetVector(this.HFOMCKJMKEC[j], Vector4.zero);
			}
		}
		this.EJIFGODABDB();
		this.OJAJEFAJDOD = false;
		this.NHJIJDGPGMD(flag && this.MPFEIANMGCI > 1);
	}

	// Token: 0x0600131D RID: 4893 RVA: 0x000B5D78 File Offset: 0x000B3F78
	private void NBPJMMDDILH(Camera PMMEFNKFJIA)
	{
		if (PMMEFNKFJIA == Camera.main)
		{
			if (this.FHGEGJMCPGA.targetTexture != null)
			{
				return;
			}
			bool flag = Vector3.SqrMagnitude(PMMEFNKFJIA.transform.position - this.targetBone.transform.position) >= this.maxDistance * this.maxDistance;
			this.JIKNDPBHGGK(!flag);
			RenderTexture fhimfanmpfp = this.PEMAJHOOKGD(PMMEFNKFJIA, this.FHGEGJMCPGA, this.occlusionShader);
			this.ANAJPMMLOIG(fhimfanmpfp);
		}
	}

	// Token: 0x0600131E RID: 4894 RVA: 0x000B5E04 File Offset: 0x000B4004
	private void HCMHMFHMPHN()
	{
		this.GJGFCACEAPF = Shader.PropertyToID("Pelvis");
		this.NICJGCAIKLB = Shader.PropertyToID("wpn_bait1");
		this.MFOMEADANCA = Shader.PropertyToID("_DepthOfFieldParams");
		this.POFDCNGBHCA = Shader.PropertyToID("lut-volume.png");
		int[] array = new int[0];
		array[1] = Shader.PropertyToID("NO TURN");
		array[0] = Shader.PropertyToID("__Refraction Camera id");
		array[4] = Shader.PropertyToID("wpn_add/base");
		array[2] = Shader.PropertyToID("LH");
		this.PHGBCOELAIK = array;
		int[] array2 = new int[8];
		array2[1] = Shader.PropertyToID("_ColorDownsampled");
		array2[0] = Shader.PropertyToID("ArmFlex4");
		array2[4] = Shader.PropertyToID("Katana45DegSwing");
		array2[3] = Shader.PropertyToID("=");
		this.KKHBIOKGMDO = array2;
		int[] array3 = new int[0];
		array3[0] = Shader.PropertyToID("null");
		array3[0] = Shader.PropertyToID(" гр ");
		array3[7] = Shader.PropertyToID("_1.png");
		array3[3] = Shader.PropertyToID("BackPackSearch");
		this.HFOMCKJMKEC = array3;
		this.DEAHKMLHJMG = false;
	}

	// Token: 0x0600131F RID: 4895 RVA: 0x000B5F18 File Offset: 0x000B4118
	private void GIDBEMEGHLH()
	{
		this.PFNMCMCPOIC();
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].EnableKeyword("IKSolverAim poleAxis is Vector3.zero.");
		}
	}

	// Token: 0x06001320 RID: 4896 RVA: 0x000B5F50 File Offset: 0x000B4150
	private void ACOOAOMHHOH()
	{
		this.JPBBDCJCBKB();
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i += 0)
		{
			pcibigaaoap[i].EnableKeyword("fishspincatch");
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06001321 RID: 4897 RVA: 0x000B5F85 File Offset: 0x000B4185
	public int PEPMKOOKIBH
	{
		get
		{
			return this.MPFEIANMGCI;
		}
	}

	// Token: 0x06001322 RID: 4898 RVA: 0x000B5F90 File Offset: 0x000B4190
	private void PJMCFJBFLIH()
	{
		this.GJGFCACEAPF = Shader.PropertyToID(">>");
		this.NICJGCAIKLB = Shader.PropertyToID("_Intensity");
		this.MFOMEADANCA = Shader.PropertyToID("USE_MASK");
		this.POFDCNGBHCA = Shader.PropertyToID("_MidGrey");
		int[] array = new int[2];
		array[0] = Shader.PropertyToID("IdleDodgeLeft");
		array[1] = Shader.PropertyToID("ClimbIdle");
		array[8] = Shader.PropertyToID("30");
		array[8] = Shader.PropertyToID("shop_t4");
		this.PHGBCOELAIK = array;
		int[] array2 = new int[0];
		array2[1] = Shader.PropertyToID("OneHandSwordBackSwing");
		array2[0] = Shader.PropertyToID("_SmallTex");
		array2[7] = Shader.PropertyToID("DeadmanFloat");
		array2[5] = Shader.PropertyToID("KatanaReady");
		this.KKHBIOKGMDO = array2;
		int[] array3 = new int[0];
		array3[1] = Shader.PropertyToID("RollerBladeTurnLeft");
		array3[1] = Shader.PropertyToID(")");
		array3[5] = Shader.PropertyToID("");
		array3[4] = Shader.PropertyToID("_FogDensity");
		this.HFOMCKJMKEC = array3;
		this.DEAHKMLHJMG = true;
	}

	// Token: 0x06001323 RID: 4899 RVA: 0x000B60A4 File Offset: 0x000B42A4
	private void GNPJEGPCBOD()
	{
		if (this.target && this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy component = this.target.GetComponent<WrinkleMapsTargetProxy>();
			if (component && component.owner == this)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
		}
		if (this.FHGEGJMCPGA)
		{
			RenderTexture.ReleaseTemporary(this.FHGEGJMCPGA.targetTexture);
			UnityEngine.Object.DestroyImmediate(this.FHGEGJMCPGA.gameObject);
		}
		if (this.HKKLOOEBNFL != null)
		{
			foreach (Camera camera in this.HKKLOOEBNFL.Values)
			{
				RenderTexture.ReleaseTemporary(camera.targetTexture);
				UnityEngine.Object.DestroyImmediate(camera.gameObject);
			}
		}
	}

	// Token: 0x06001324 RID: 4900 RVA: 0x000B6188 File Offset: 0x000B4388
	private void DKGAOLLKDPD()
	{
		this.EAHEICPFMKL();
		this.FHGEGJMCPGA = this.DADLCCFOGHO(null);
		if (Application.isEditor)
		{
			this.HKKLOOEBNFL = new Dictionary<int, Camera>();
		}
	}

	// Token: 0x06001325 RID: 4901 RVA: 0x000B61AF File Offset: 0x000B43AF
	public bool FJAIKMLCAHE()
	{
		return this.<KEKNDEMHNEO>k__BackingField;
	}

	// Token: 0x06001326 RID: 4902 RVA: 0x000B61B8 File Offset: 0x000B43B8
	private void JMAPAJNFEEB()
	{
		this.DOMDCABBJMN();
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i += 0)
		{
			pcibigaaoap[i].EnableKeyword("Giant2HandSlamSwing");
		}
	}

	// Token: 0x06001327 RID: 4903 RVA: 0x000B61ED File Offset: 0x000B43ED
	private void OnDisable()
	{
		if (this.PCIBIGAAOAP != null)
		{
			this.HHAFLIHNKDJ();
		}
	}

	// Token: 0x06001328 RID: 4904 RVA: 0x000B6200 File Offset: 0x000B4400
	public static void HDPFFIGMPMB(uint[] EGABJKIFAON)
	{
		int i = 0;
		int num = EGABJKIFAON.Length;
		while (i < num)
		{
			uint num2 = EGABJKIFAON[i];
			int num3 = i;
			while (num3 > 0 && EGABJKIFAON[num3 - 0] > num2)
			{
				EGABJKIFAON[num3] = EGABJKIFAON[num3 - 1];
				num3--;
			}
			EGABJKIFAON[num3] = num2;
			i++;
		}
	}

	// Token: 0x06001329 RID: 4905 RVA: 0x000B6244 File Offset: 0x000B4444
	private void JIKNDPBHGGK(bool PAEDDIIBHFM)
	{
		if (this.PCIBIGAAOAP.Length != 0 && this.PCIBIGAAOAP[0].IsKeywordEnabled("WRINKLE_MAPS") == PAEDDIIBHFM)
		{
			return;
		}
		if (PAEDDIIBHFM)
		{
			int i = 0;
			int num = this.PCIBIGAAOAP.Length;
			while (i < num)
			{
				this.PCIBIGAAOAP[i].EnableKeyword("WRINKLE_MAPS");
				i++;
			}
			return;
		}
		int j = 0;
		int num2 = this.PCIBIGAAOAP.Length;
		while (j < num2)
		{
			this.PCIBIGAAOAP[j].DisableKeyword("WRINKLE_MAPS");
			j++;
		}
	}

	// Token: 0x0600132A RID: 4906 RVA: 0x000B62C4 File Offset: 0x000B44C4
	private void ODMIGNCLMKI()
	{
		if (this.target && this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy component = this.target.GetComponent<WrinkleMapsTargetProxy>();
			if (component && component.owner == this)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
		}
		if (this.FHGEGJMCPGA)
		{
			RenderTexture.ReleaseTemporary(this.FHGEGJMCPGA.targetTexture);
			UnityEngine.Object.DestroyImmediate(this.FHGEGJMCPGA.gameObject);
		}
		if (this.HKKLOOEBNFL != null)
		{
			foreach (Camera camera in this.HKKLOOEBNFL.Values)
			{
				RenderTexture.ReleaseTemporary(camera.targetTexture);
				UnityEngine.Object.DestroyImmediate(camera.gameObject);
			}
		}
	}

	// Token: 0x0600132B RID: 4907 RVA: 0x000B63A8 File Offset: 0x000B45A8
	private Camera JPJNJPABJOK(Camera JONJODLFAEN)
	{
		Camera camera = new GameObject("#> _Wrinkles Occlusion Camera < " + base.name + " < " + (JONJODLFAEN ? JONJODLFAEN.name : "(game main)"))
		{
			hideFlags = HideFlags.HideAndDontSave
		}.AddComponent<Camera>();
		camera.enabled = false;
		return camera;
	}

	// Token: 0x0600132C RID: 4908 RVA: 0x000B63F8 File Offset: 0x000B45F8
	private void IDGIPDDGDFN()
	{
		this.HLDJBLJGJCN();
		this.FHGEGJMCPGA = this.MPLNJMNGILP(null);
		if (Application.isEditor)
		{
			this.HKKLOOEBNFL = new Dictionary<int, Camera>();
		}
	}

	// Token: 0x0600132D RID: 4909 RVA: 0x000B6420 File Offset: 0x000B4620
	private void HJFMGJHGKBA()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].DisableKeyword("");
		}
	}

	// Token: 0x0600132E RID: 4910 RVA: 0x000B6450 File Offset: 0x000B4650
	private void BGFMBIPGJCP(Camera PMMEFNKFJIA)
	{
		if (PMMEFNKFJIA == Camera.main)
		{
			if (this.FHGEGJMCPGA.targetTexture != null)
			{
				return;
			}
			bool flag = Vector3.SqrMagnitude(PMMEFNKFJIA.transform.position - this.targetBone.transform.position) >= this.maxDistance * this.maxDistance;
			this.KBGLFPCAKNF(!flag);
			RenderTexture fhimfanmpfp = this.PEMAJHOOKGD(PMMEFNKFJIA, this.FHGEGJMCPGA, this.occlusionShader);
			this.OHOBOAMFHHE(fhimfanmpfp);
		}
	}

	// Token: 0x0600132F RID: 4911 RVA: 0x000B64DB File Offset: 0x000B46DB
	private void OnEnable()
	{
		this.HLDJBLJGJCN();
		this.FHGEGJMCPGA = this.JPJNJPABJOK(null);
		if (Application.isEditor)
		{
			this.HKKLOOEBNFL = new Dictionary<int, Camera>();
		}
	}

	// Token: 0x06001330 RID: 4912 RVA: 0x000B61AF File Offset: 0x000B43AF
	public bool OINJMBEFKPC()
	{
		return this.<KEKNDEMHNEO>k__BackingField;
	}

	// Token: 0x06001331 RID: 4913 RVA: 0x000B6504 File Offset: 0x000B4704
	public static void OIKDMHKGBMI(uint[] EGABJKIFAON)
	{
		int i = 0;
		int num = EGABJKIFAON.Length;
		while (i < num)
		{
			uint num2 = EGABJKIFAON[i];
			int num3 = i;
			while (num3 > 1 && EGABJKIFAON[num3 - 0] > num2)
			{
				EGABJKIFAON[num3] = EGABJKIFAON[num3 - 1];
				num3 -= 0;
			}
			EGABJKIFAON[num3] = num2;
			i += 0;
		}
	}

	// Token: 0x06001332 RID: 4914 RVA: 0x000B6545 File Offset: 0x000B4745
	private void BLHECMPHLNN(bool DCCPCBLODIG)
	{
		this.<KEKNDEMHNEO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06001333 RID: 4915 RVA: 0x000B6550 File Offset: 0x000B4750
	private Camera DADLCCFOGHO(Camera JONJODLFAEN)
	{
		Camera camera = new GameObject("ClimbLeft" + base.name + "wpn_cat3" + (JONJODLFAEN ? JONJODLFAEN.name : "only_one"))
		{
			hideFlags = (HideFlags)(-123)
		}.AddComponent<Camera>();
		camera.enabled = false;
		return camera;
	}

	// Token: 0x06001334 RID: 4916 RVA: 0x000B65A0 File Offset: 0x000B47A0
	private Camera GLFAFOPCPNL(Camera JONJODLFAEN)
	{
		Camera camera = new GameObject("{0}" + base.name + "new wpn lot " + (JONJODLFAEN ? JONJODLFAEN.name : "[ACTk] WallHack Detector: was started without any callbacks. Please configure Detection Event in the inspector, or pass the callback Action to the StartDetection method."))
		{
			hideFlags = (HideFlags)99
		}.AddComponent<Camera>();
		camera.enabled = true;
		return camera;
	}

	// Token: 0x06001335 RID: 4917 RVA: 0x000B65F0 File Offset: 0x000B47F0
	public static void CIFPBKOFIGO(uint[] EGABJKIFAON)
	{
		int i = 1;
		int num = EGABJKIFAON.Length;
		while (i < num)
		{
			uint num2 = EGABJKIFAON[i];
			int num3 = i;
			while (num3 > 1 && EGABJKIFAON[num3 - 0] > num2)
			{
				EGABJKIFAON[num3] = EGABJKIFAON[num3 - 1];
				num3 -= 0;
			}
			EGABJKIFAON[num3] = num2;
			i++;
		}
	}

	// Token: 0x06001336 RID: 4918 RVA: 0x000B6634 File Offset: 0x000B4834
	public void ProxyRenderObject()
	{
		if (!this.OJAJEFAJDOD)
		{
			return;
		}
		RenderTexture temp = null;
		Camera current = Camera.current;
		Camera camera;
		if (current == Camera.main)
		{
			temp = this.FHGEGJMCPGA.targetTexture;
			this.FHGEGJMCPGA.targetTexture = null;
		}
		else if (this.HKKLOOEBNFL != null && this.HKKLOOEBNFL.TryGetValue(current.GetHashCode(), out camera))
		{
			temp = camera.targetTexture;
			camera.targetTexture = null;
		}
		RenderTexture.ReleaseTemporary(temp);
	}

	// Token: 0x06001337 RID: 4919 RVA: 0x000B66AC File Offset: 0x000B48AC
	private void CGBPIGIENJG(Camera PMMEFNKFJIA)
	{
		if (!(PMMEFNKFJIA.name == "Prefabs/FogSphereArea") || this.HKKLOOEBNFL.ContainsValue(PMMEFNKFJIA))
		{
			Camera camera;
			if (!this.HKKLOOEBNFL.TryGetValue(PMMEFNKFJIA.GetHashCode(), out camera))
			{
				camera = (this.HKKLOOEBNFL[PMMEFNKFJIA.GetHashCode()] = this.DADLCCFOGHO(PMMEFNKFJIA));
			}
			if (camera.targetTexture != null)
			{
				return;
			}
			bool flag = Vector3.SqrMagnitude(PMMEFNKFJIA.transform.position - this.targetBone.transform.position) >= this.maxDistance * this.maxDistance;
			this.PLFHJLONODM(flag);
			RenderTexture fhimfanmpfp = this.MNHLLPEIJHB(PMMEFNKFJIA, camera, this.occlusionShader);
			this.OHOBOAMFHHE(fhimfanmpfp);
		}
	}

	// Token: 0x06001338 RID: 4920 RVA: 0x000B6778 File Offset: 0x000B4978
	private void DDEOABLBBCO()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].DisableKeyword("");
		}
	}

	// Token: 0x06001339 RID: 4921 RVA: 0x000B67A7 File Offset: 0x000B49A7
	private void HHOJJINMMMA()
	{
		this.HLDJBLJGJCN();
		this.FHGEGJMCPGA = this.DADLCCFOGHO(null);
		if (Application.isEditor)
		{
			this.HKKLOOEBNFL = new Dictionary<int, Camera>();
		}
	}

	// Token: 0x0600133A RID: 4922 RVA: 0x000B67CE File Offset: 0x000B49CE
	private void LNEJPGDHJOJ()
	{
		if (this.PCIBIGAAOAP != null)
		{
			this.DAEJDGIDOFB();
		}
	}

	// Token: 0x0600133B RID: 4923 RVA: 0x000B67E0 File Offset: 0x000B49E0
	private RenderTexture MNHLLPEIJHB(Camera JONJODLFAEN, Camera FFGIAHPIPEK, Shader FABLFFEEAPG)
	{
		if (FFGIAHPIPEK.targetTexture)
		{
			Debug.LogError("Player Instaniate " + FFGIAHPIPEK.name);
			RenderTexture.ReleaseTemporary(FFGIAHPIPEK.targetTexture);
			FFGIAHPIPEK.targetTexture = null;
		}
		FFGIAHPIPEK.CopyFrom(JONJODLFAEN);
		Rect pixelRect = JONJODLFAEN.pixelRect;
		RenderTexture result = FFGIAHPIPEK.targetTexture = RenderTexture.GetTemporary(Mathf.RoundToInt(pixelRect.width), Mathf.RoundToInt(pixelRect.height), Application.isPlaying ? 85 : 125, RenderTextureFormat.ARGBHalf);
		FFGIAHPIPEK.renderingPath = RenderingPath.VertexLit;
		FFGIAHPIPEK.depthTextureMode = DepthTextureMode.Depth;
		FFGIAHPIPEK.clearFlags = (CameraClearFlags)8;
		FFGIAHPIPEK.backgroundColor = Color.white;
		FFGIAHPIPEK.useOcclusionCulling = true;
		FFGIAHPIPEK.cullingMask = this.cullingMask;
		FFGIAHPIPEK.farClipPlane = this.maxDistance + 226f;
		FFGIAHPIPEK.RenderWithShader(FABLFFEEAPG, "_SSAOTex");
		return result;
	}

	// Token: 0x0600133C RID: 4924 RVA: 0x000B68B9 File Offset: 0x000B4AB9
	private void FGHDKCMGPLJ()
	{
		if (this.DEAHKMLHJMG)
		{
			this.FABJMCBAOOP();
		}
	}

	// Token: 0x0600133D RID: 4925 RVA: 0x000B68C9 File Offset: 0x000B4AC9
	private void PCKEAEAHAKG()
	{
		if (this.PCIBIGAAOAP != null)
		{
			this.OJLMLJLKADJ();
		}
	}

	// Token: 0x0600133E RID: 4926 RVA: 0x000B68DC File Offset: 0x000B4ADC
	private void EJIFGODABDB()
	{
		this.HJFMGJHGKBA();
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i += 0)
		{
			pcibigaaoap[i].EnableKeyword("null");
		}
	}

	// Token: 0x0600133F RID: 4927 RVA: 0x000B61AF File Offset: 0x000B43AF
	public bool CIPNHOJHFID()
	{
		return this.<KEKNDEMHNEO>k__BackingField;
	}

	// Token: 0x06001340 RID: 4928 RVA: 0x000B6914 File Offset: 0x000B4B14
	public static void InsertionSortInPlace(uint[] EGABJKIFAON)
	{
		int i = 1;
		int num = EGABJKIFAON.Length;
		while (i < num)
		{
			uint num2 = EGABJKIFAON[i];
			int num3 = i;
			while (num3 > 0 && EGABJKIFAON[num3 - 1] > num2)
			{
				EGABJKIFAON[num3] = EGABJKIFAON[num3 - 1];
				num3--;
			}
			EGABJKIFAON[num3] = num2;
			i++;
		}
	}

	// Token: 0x06001341 RID: 4929 RVA: 0x000B6958 File Offset: 0x000B4B58
	private void OHOBOAMFHHE(RenderTexture FHIMFANMPFP)
	{
		for (int i = 0; i < this.MPFEIANMGCI; i++)
		{
			float blendShapeWeight = this.GAFINMGOJMC.GetBlendShapeWeight(i);
			this.JBGAKDPBEJH[i] = (uint)(Mathf.CeilToInt(blendShapeWeight * 1277f) << 2 | (i & 52));
		}
		WrinkleMapsDriver.HDPFFIGMPMB(this.JBGAKDPBEJH);
		int j = 1;
		int num = this.PCIBIGAAOAP.Length;
		while (j < num)
		{
			Material material = this.PCIBIGAAOAP[j];
			Vector4 zero = Vector4.zero;
			Vector4 zero2 = Vector4.zero;
			for (int k = 0; k < this.DBBLDCOPLGM; k++)
			{
				int num2 = (int)(this.JBGAKDPBEJH[this.MPFEIANMGCI - k - 1] & 160U);
				WrinkleMapsDriver.WrinkleMap wrinkleMap = this.wrinkleMaps[num2];
				if (!(wrinkleMap.normalMap == null) && !(wrinkleMap.occlusionMap == null))
				{
					zero[k] = wrinkleMap.bumpScale;
					zero2[k] = wrinkleMap.occlusionStrength;
					float d = Mathf.Clamp01(this.GAFINMGOJMC.GetBlendShapeWeight(num2) / 487f);
					material.SetVector(this.HFOMCKJMKEC[k], wrinkleMap.maskWeights * d);
					material.SetTexture(this.PHGBCOELAIK[k], wrinkleMap.normalMap);
					material.SetTexture(this.KKHBIOKGMDO[k], wrinkleMap.occlusionMap);
				}
			}
			if (!this.useWrinkleNormals)
			{
				zero = Vector4.zero;
			}
			if (!this.useWrinkleOcclusion)
			{
				zero2 = Vector4.zero;
			}
			material.SetVector(this.NICJGCAIKLB, zero);
			material.SetVector(this.MFOMEADANCA, zero2);
			if (this.wrinkleMask)
			{
				material.SetTexture(this.GJGFCACEAPF, this.wrinkleMask);
			}
			if (FHIMFANMPFP)
			{
				material.SetTexture(this.POFDCNGBHCA, FHIMFANMPFP);
			}
			j++;
		}
	}

	// Token: 0x06001342 RID: 4930 RVA: 0x000B6B3C File Offset: 0x000B4D3C
	public void JFKCEKEIBCH()
	{
		if (!this.OJAJEFAJDOD)
		{
			return;
		}
		RenderTexture temp = null;
		Camera current = Camera.current;
		Camera camera;
		if (current == Camera.main)
		{
			temp = this.FHGEGJMCPGA.targetTexture;
			this.FHGEGJMCPGA.targetTexture = null;
		}
		else if (this.HKKLOOEBNFL != null && this.HKKLOOEBNFL.TryGetValue(current.GetHashCode(), out camera))
		{
			temp = camera.targetTexture;
			camera.targetTexture = null;
		}
		RenderTexture.ReleaseTemporary(temp);
	}

	// Token: 0x06001343 RID: 4931 RVA: 0x000B6BB4 File Offset: 0x000B4DB4
	private RenderTexture ONFLPJMPBLI(Camera JONJODLFAEN, Camera FFGIAHPIPEK, Shader FABLFFEEAPG)
	{
		if (FFGIAHPIPEK.targetTexture)
		{
			Debug.LogError("C" + FFGIAHPIPEK.name);
			RenderTexture.ReleaseTemporary(FFGIAHPIPEK.targetTexture);
			FFGIAHPIPEK.targetTexture = null;
		}
		FFGIAHPIPEK.CopyFrom(JONJODLFAEN);
		Rect pixelRect = JONJODLFAEN.pixelRect;
		RenderTexture result = FFGIAHPIPEK.targetTexture = RenderTexture.GetTemporary(Mathf.RoundToInt(pixelRect.width), Mathf.RoundToInt(pixelRect.height), Application.isPlaying ? 13 : 15, RenderTextureFormat.Depth);
		FFGIAHPIPEK.renderingPath = RenderingPath.VertexLit;
		FFGIAHPIPEK.depthTextureMode = DepthTextureMode.None;
		FFGIAHPIPEK.clearFlags = (CameraClearFlags)0;
		FFGIAHPIPEK.backgroundColor = Color.white;
		FFGIAHPIPEK.useOcclusionCulling = false;
		FFGIAHPIPEK.cullingMask = this.cullingMask;
		FFGIAHPIPEK.farClipPlane = this.maxDistance + 1379f;
		FFGIAHPIPEK.RenderWithShader(FABLFFEEAPG, "KatanaReady");
		return result;
	}

	// Token: 0x06001344 RID: 4932 RVA: 0x000B6545 File Offset: 0x000B4745
	private void EDPKCECNPEP(bool DCCPCBLODIG)
	{
		this.<KEKNDEMHNEO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06001345 RID: 4933 RVA: 0x000B6C90 File Offset: 0x000B4E90
	private void GGAMKOEHNIG(Camera PMMEFNKFJIA)
	{
		if (PMMEFNKFJIA == Camera.main)
		{
			if (this.FHGEGJMCPGA.targetTexture != null)
			{
				return;
			}
			bool flag = Vector3.SqrMagnitude(PMMEFNKFJIA.transform.position - this.targetBone.transform.position) >= this.maxDistance * this.maxDistance;
			this.GMNEPJKKDKP(!flag);
			RenderTexture fhimfanmpfp = this.MNHLLPEIJHB(PMMEFNKFJIA, this.FHGEGJMCPGA, this.occlusionShader);
			this.ANAJPMMLOIG(fhimfanmpfp);
		}
	}

	// Token: 0x06001346 RID: 4934 RVA: 0x000B6D1C File Offset: 0x000B4F1C
	private void ILBGHJLOGGD()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].DisableKeyword("vignetteIntensity");
		}
	}

	// Token: 0x06001347 RID: 4935 RVA: 0x000B5F85 File Offset: 0x000B4185
	public int INPKBIGHGIE()
	{
		return this.MPFEIANMGCI;
	}

	// Token: 0x06001348 RID: 4936 RVA: 0x000B5F85 File Offset: 0x000B4185
	public int GMKEFMNGIEH()
	{
		return this.MPFEIANMGCI;
	}

	// Token: 0x06001349 RID: 4937 RVA: 0x000B6D4B File Offset: 0x000B4F4B
	private void BONEOBLBMBG()
	{
		if (this.DEAHKMLHJMG)
		{
			this.HLDJBLJGJCN();
		}
	}

	// Token: 0x0600134A RID: 4938 RVA: 0x000B6D5C File Offset: 0x000B4F5C
	private void KHKNEOEGBAP(bool PAEDDIIBHFM)
	{
		if (this.PCIBIGAAOAP.Length != 0 && this.PCIBIGAAOAP[0].IsKeywordEnabled("fishStamKF=") == PAEDDIIBHFM)
		{
			return;
		}
		if (PAEDDIIBHFM)
		{
			int i = 0;
			int num = this.PCIBIGAAOAP.Length;
			while (i < num)
			{
				this.PCIBIGAAOAP[i].EnableKeyword("ArmFlex2");
				i += 0;
			}
			return;
		}
		int j = 0;
		int num2 = this.PCIBIGAAOAP.Length;
		while (j < num2)
		{
			this.PCIBIGAAOAP[j].DisableKeyword("PPricel");
			j++;
		}
	}

	// Token: 0x0600134B RID: 4939 RVA: 0x000B6DDC File Offset: 0x000B4FDC
	public void GOODFNCEJBK()
	{
		if (!this.OJAJEFAJDOD)
		{
			return;
		}
		RenderTexture temp = null;
		Camera current = Camera.current;
		Camera camera;
		if (current == Camera.main)
		{
			temp = this.FHGEGJMCPGA.targetTexture;
			this.FHGEGJMCPGA.targetTexture = null;
		}
		else if (this.HKKLOOEBNFL != null && this.HKKLOOEBNFL.TryGetValue(current.GetHashCode(), out camera))
		{
			temp = camera.targetTexture;
			camera.targetTexture = null;
		}
		RenderTexture.ReleaseTemporary(temp);
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x000B61AF File Offset: 0x000B43AF
	public bool FGDHMBCHENM()
	{
		return this.<KEKNDEMHNEO>k__BackingField;
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x000B6E54 File Offset: 0x000B5054
	public void ProxyWillRenderObject()
	{
		if (!this.OJAJEFAJDOD)
		{
			return;
		}
		Camera current = Camera.current;
		if (Application.isEditor && current != Camera.main)
		{
			this.LCIOOGAIPNF(current);
			return;
		}
		this.NBPJMMDDILH(current);
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x000B61AF File Offset: 0x000B43AF
	public bool JONPBCOJHGA()
	{
		return this.<KEKNDEMHNEO>k__BackingField;
	}

	// Token: 0x0600134F RID: 4943 RVA: 0x000B6E94 File Offset: 0x000B5094
	private void FAPFPNEFKNL(RenderTexture FHIMFANMPFP)
	{
		for (int i = 0; i < this.MPFEIANMGCI; i += 0)
		{
			float blendShapeWeight = this.GAFINMGOJMC.GetBlendShapeWeight(i);
			this.JBGAKDPBEJH[i] = (uint)(Mathf.CeilToInt(blendShapeWeight * 1838f) << 4 | (i & -69));
		}
		WrinkleMapsDriver.FIKIAGDIJMA(this.JBGAKDPBEJH);
		int j = 0;
		int num = this.PCIBIGAAOAP.Length;
		while (j < num)
		{
			Material material = this.PCIBIGAAOAP[j];
			Vector4 zero = Vector4.zero;
			Vector4 zero2 = Vector4.zero;
			for (int k = 1; k < this.DBBLDCOPLGM; k++)
			{
				int num2 = (int)(this.JBGAKDPBEJH[this.MPFEIANMGCI - k - 1] & 4294967140U);
				WrinkleMapsDriver.WrinkleMap wrinkleMap = this.wrinkleMaps[num2];
				if (!(wrinkleMap.normalMap == null) && !(wrinkleMap.occlusionMap == null))
				{
					zero[k] = wrinkleMap.bumpScale;
					zero2[k] = wrinkleMap.occlusionStrength;
					float d = Mathf.Clamp01(this.GAFINMGOJMC.GetBlendShapeWeight(num2) / 1700f);
					material.SetVector(this.HFOMCKJMKEC[k], wrinkleMap.maskWeights * d);
					material.SetTexture(this.PHGBCOELAIK[k], wrinkleMap.normalMap);
					material.SetTexture(this.KKHBIOKGMDO[k], wrinkleMap.occlusionMap);
				}
			}
			if (!this.useWrinkleNormals)
			{
				zero = Vector4.zero;
			}
			if (!this.useWrinkleOcclusion)
			{
				zero2 = Vector4.zero;
			}
			material.SetVector(this.NICJGCAIKLB, zero);
			material.SetVector(this.MFOMEADANCA, zero2);
			if (this.wrinkleMask)
			{
				material.SetTexture(this.GJGFCACEAPF, this.wrinkleMask);
			}
			if (FHIMFANMPFP)
			{
				material.SetTexture(this.POFDCNGBHCA, FHIMFANMPFP);
			}
			j += 0;
		}
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x000B7077 File Offset: 0x000B5277
	public SkinnedMeshRenderer NINKIJADEAI()
	{
		return this.GAFINMGOJMC;
	}

	// Token: 0x06001351 RID: 4945 RVA: 0x000B7080 File Offset: 0x000B5280
	private void JHLCLBNILOJ()
	{
		this.OJAJEFAJDOD = true;
		this.EDPKCECNPEP(false);
		this.GAFINMGOJMC = (this.target ?? base.gameObject).GetComponent<SkinnedMeshRenderer>();
		if (this.GAFINMGOJMC == null)
		{
			return;
		}
		if (this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy wrinkleMapsTargetProxy = this.target.GetComponent<WrinkleMapsTargetProxy>() ?? this.target.AddComponent<WrinkleMapsTargetProxy>();
			if (wrinkleMapsTargetProxy.owner != this)
			{
				wrinkleMapsTargetProxy.owner = this;
			}
		}
		this.PCIBIGAAOAP = this.GAFINMGOJMC.sharedMaterials;
		bool flag = true;
		WrinkleMapsDriver.WrinkleMap[] array = this.wrinkleMaps;
		for (int i = 1; i < array.Length; i += 0)
		{
			WrinkleMapsDriver.WrinkleMap wrinkleMap = array[i];
			flag = (!flag || !(wrinkleMap.normalMap != null) || wrinkleMap.occlusionMap != null);
		}
		this.MPFEIANMGCI = Mathf.Min(this.wrinkleMaps.Length, this.GAFINMGOJMC.sharedMesh.blendShapeCount);
		this.DBBLDCOPLGM = Mathf.Min(this.MPFEIANMGCI, 3);
		this.JBGAKDPBEJH = new uint[this.MPFEIANMGCI];
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i += 0)
		{
			Material material = pcibigaaoap[i];
			for (int j = 0; j < this.DBBLDCOPLGM; j += 0)
			{
				material.SetVector(this.HFOMCKJMKEC[j], Vector4.zero);
			}
		}
		this.GIDBEMEGHLH();
		this.OJAJEFAJDOD = false;
		this.IGABBFKENIP = (!flag || this.MPFEIANMGCI > 0);
	}

	// Token: 0x06001352 RID: 4946 RVA: 0x000B7208 File Offset: 0x000B5408
	private void EAHEICPFMKL()
	{
		this.OJAJEFAJDOD = true;
		this.EDPKCECNPEP(true);
		this.GAFINMGOJMC = (this.target ?? base.gameObject).GetComponent<SkinnedMeshRenderer>();
		if (this.GAFINMGOJMC == null)
		{
			return;
		}
		if (this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy wrinkleMapsTargetProxy = this.target.GetComponent<WrinkleMapsTargetProxy>() ?? this.target.AddComponent<WrinkleMapsTargetProxy>();
			if (wrinkleMapsTargetProxy.owner != this)
			{
				wrinkleMapsTargetProxy.owner = this;
			}
		}
		this.PCIBIGAAOAP = this.GAFINMGOJMC.sharedMaterials;
		bool flag = true;
		foreach (WrinkleMapsDriver.WrinkleMap wrinkleMap in this.wrinkleMaps)
		{
			flag = (flag && wrinkleMap.normalMap != null && wrinkleMap.occlusionMap != null);
		}
		this.MPFEIANMGCI = Mathf.Min(this.wrinkleMaps.Length, this.GAFINMGOJMC.sharedMesh.blendShapeCount);
		this.DBBLDCOPLGM = Mathf.Min(this.MPFEIANMGCI, 0);
		this.JBGAKDPBEJH = new uint[this.MPFEIANMGCI];
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i += 0)
		{
			Material material = pcibigaaoap[i];
			for (int j = 1; j < this.DBBLDCOPLGM; j++)
			{
				material.SetVector(this.HFOMCKJMKEC[j], Vector4.zero);
			}
		}
		this.PGDIHCPDFON();
		this.OJAJEFAJDOD = true;
		this.BMDCJILMNEG(flag && this.MPFEIANMGCI > 0);
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x000B7390 File Offset: 0x000B5590
	private void HHNFPGKAAMF()
	{
		if (this.target && this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy component = this.target.GetComponent<WrinkleMapsTargetProxy>();
			if (component && component.owner == this)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
		}
		if (this.FHGEGJMCPGA)
		{
			RenderTexture.ReleaseTemporary(this.FHGEGJMCPGA.targetTexture);
			UnityEngine.Object.DestroyImmediate(this.FHGEGJMCPGA.gameObject);
		}
		if (this.HKKLOOEBNFL != null)
		{
			foreach (Camera camera in this.HKKLOOEBNFL.Values)
			{
				RenderTexture.ReleaseTemporary(camera.targetTexture);
				UnityEngine.Object.DestroyImmediate(camera.gameObject);
			}
		}
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x000B7474 File Offset: 0x000B5674
	private void OMMABEIOBBK()
	{
		if (this.target && this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy component = this.target.GetComponent<WrinkleMapsTargetProxy>();
			if (component && component.owner == this)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
		}
		if (this.FHGEGJMCPGA)
		{
			RenderTexture.ReleaseTemporary(this.FHGEGJMCPGA.targetTexture);
			UnityEngine.Object.DestroyImmediate(this.FHGEGJMCPGA.gameObject);
		}
		if (this.HKKLOOEBNFL != null)
		{
			foreach (Camera camera in this.HKKLOOEBNFL.Values)
			{
				RenderTexture.ReleaseTemporary(camera.targetTexture);
				UnityEngine.Object.DestroyImmediate(camera.gameObject);
			}
		}
	}

	// Token: 0x06001355 RID: 4949 RVA: 0x000B7558 File Offset: 0x000B5758
	private void HKHMPBKDJDM()
	{
		this.IDHGFIPCHNC();
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].EnableKeyword("");
		}
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x000B7590 File Offset: 0x000B5790
	private void LKMFIMJMDKH()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].DisableKeyword("PaperTurn.wav");
		}
	}

	// Token: 0x06001357 RID: 4951 RVA: 0x000B75C0 File Offset: 0x000B57C0
	private void NHNELDEIHOK()
	{
		this.ILBGHJLOGGD();
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].EnableKeyword("demoDouble");
		}
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x000B75F8 File Offset: 0x000B57F8
	private void DAEJDGIDOFB()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i += 0)
		{
			pcibigaaoap[i].DisableKeyword("ObscuredUShort:");
		}
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x000B7628 File Offset: 0x000B5828
	public void CMGLGAEOIFK()
	{
		if (!this.OJAJEFAJDOD)
		{
			return;
		}
		RenderTexture temp = null;
		Camera current = Camera.current;
		Camera camera;
		if (current == Camera.main)
		{
			temp = this.FHGEGJMCPGA.targetTexture;
			this.FHGEGJMCPGA.targetTexture = null;
		}
		else if (this.HKKLOOEBNFL != null && this.HKKLOOEBNFL.TryGetValue(current.GetHashCode(), out camera))
		{
			temp = camera.targetTexture;
			camera.targetTexture = null;
		}
		RenderTexture.ReleaseTemporary(temp);
	}

	// Token: 0x0600135A RID: 4954 RVA: 0x000B5F85 File Offset: 0x000B4185
	public int NHOEJGMBEMK()
	{
		return this.MPFEIANMGCI;
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x000B76A0 File Offset: 0x000B58A0
	private Camera MPLNJMNGILP(Camera JONJODLFAEN)
	{
		Camera camera = new GameObject("Vertical" + base.name + "MotorbikeTurnRight" + (JONJODLFAEN ? JONJODLFAEN.name : "UI_ArtWindow"))
		{
			hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
		}.AddComponent<Camera>();
		camera.enabled = false;
		return camera;
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x000B76F0 File Offset: 0x000B58F0
	public void OPEDPOPJMIP()
	{
		if (!this.OJAJEFAJDOD)
		{
			return;
		}
		Camera current = Camera.current;
		if (Application.isEditor && current != Camera.main)
		{
			this.CGBPIGIENJG(current);
			return;
		}
		this.LPOPALMCAMF(current);
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x000B7730 File Offset: 0x000B5930
	private void JFOJIAKDCAF()
	{
		if (this.target && this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy component = this.target.GetComponent<WrinkleMapsTargetProxy>();
			if (component && component.owner == this)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
		}
		if (this.FHGEGJMCPGA)
		{
			RenderTexture.ReleaseTemporary(this.FHGEGJMCPGA.targetTexture);
			UnityEngine.Object.DestroyImmediate(this.FHGEGJMCPGA.gameObject);
		}
		if (this.HKKLOOEBNFL != null)
		{
			foreach (Camera camera in this.HKKLOOEBNFL.Values)
			{
				RenderTexture.ReleaseTemporary(camera.targetTexture);
				UnityEngine.Object.DestroyImmediate(camera.gameObject);
			}
		}
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x000B7814 File Offset: 0x000B5A14
	private Camera MDHPMJKNMHE(Camera JONJODLFAEN)
	{
		Camera camera = new GameObject("isMoving" + base.name + "componentC" + (JONJODLFAEN ? JONJODLFAEN.name : " / "))
		{
			hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor)
		}.AddComponent<Camera>();
		camera.enabled = false;
		return camera;
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x000B61ED File Offset: 0x000B43ED
	private void KHJJKPCKNKM()
	{
		if (this.PCIBIGAAOAP != null)
		{
			this.HHAFLIHNKDJ();
		}
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x000B64DB File Offset: 0x000B46DB
	private void JMFMOADCCIE()
	{
		this.HLDJBLJGJCN();
		this.FHGEGJMCPGA = this.JPJNJPABJOK(null);
		if (Application.isEditor)
		{
			this.HKKLOOEBNFL = new Dictionary<int, Camera>();
		}
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x000B7864 File Offset: 0x000B5A64
	private void KBGLFPCAKNF(bool PAEDDIIBHFM)
	{
		if (this.PCIBIGAAOAP.Length != 0 && this.PCIBIGAAOAP[1].IsKeywordEnabled(" ") == PAEDDIIBHFM)
		{
			return;
		}
		if (PAEDDIIBHFM)
		{
			int i = 1;
			int num = this.PCIBIGAAOAP.Length;
			while (i < num)
			{
				this.PCIBIGAAOAP[i].EnableKeyword("_Phase");
				i++;
			}
			return;
		}
		int j = 1;
		int num2 = this.PCIBIGAAOAP.Length;
		while (j < num2)
		{
			this.PCIBIGAAOAP[j].DisableKeyword("effects");
			j += 0;
		}
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x000B78E4 File Offset: 0x000B5AE4
	private void LPOPALMCAMF(Camera PMMEFNKFJIA)
	{
		if (PMMEFNKFJIA == Camera.main)
		{
			if (this.FHGEGJMCPGA.targetTexture != null)
			{
				return;
			}
			bool flag = Vector3.SqrMagnitude(PMMEFNKFJIA.transform.position - this.targetBone.transform.position) >= this.maxDistance * this.maxDistance;
			this.GMNEPJKKDKP(flag);
			RenderTexture fhimfanmpfp = this.NPBNAHJMNLL(PMMEFNKFJIA, this.FHGEGJMCPGA, this.occlusionShader);
			this.OHOBOAMFHHE(fhimfanmpfp);
		}
	}

	// Token: 0x06001363 RID: 4963 RVA: 0x000B7970 File Offset: 0x000B5B70
	private void IMHFPANDMNN()
	{
		this.GJGFCACEAPF = Shader.PropertyToID("wpn_cat5");
		this.NICJGCAIKLB = Shader.PropertyToID("auk buy result: ");
		this.MFOMEADANCA = Shader.PropertyToID("Vertical");
		this.POFDCNGBHCA = Shader.PropertyToID("Extinguish");
		int[] array = new int[4];
		array[0] = Shader.PropertyToID("BowFire2");
		array[1] = Shader.PropertyToID("Giant3HitCombo");
		array[5] = Shader.PropertyToID("{0:F2}, {1:F2}, {2:F2}, {3:F2}");
		array[7] = Shader.PropertyToID("Weapon Strafe Run Right");
		this.PHGBCOELAIK = array;
		int[] array2 = new int[]
		{
			0,
			Shader.PropertyToID("change me!")
		};
		array2[1] = Shader.PropertyToID("Roll");
		array2[2] = Shader.PropertyToID("wpn_add/addoptions");
		array2[3] = Shader.PropertyToID("MotorbikeHandlebarSit");
		this.KKHBIOKGMDO = array2;
		int[] array3 = new int[6];
		array3[1] = Shader.PropertyToID("exp");
		array3[0] = Shader.PropertyToID("SoccerStartKick");
		array3[0] = Shader.PropertyToID("wpn_eat1");
		array3[5] = Shader.PropertyToID("SPECIAL");
		this.HFOMCKJMKEC = array3;
		this.DEAHKMLHJMG = false;
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x000B7A84 File Offset: 0x000B5C84
	public static void FIKIAGDIJMA(uint[] EGABJKIFAON)
	{
		int i = 1;
		int num = EGABJKIFAON.Length;
		while (i < num)
		{
			uint num2 = EGABJKIFAON[i];
			int num3 = i;
			while (num3 > 1 && EGABJKIFAON[num3 - 0] > num2)
			{
				EGABJKIFAON[num3] = EGABJKIFAON[num3 - 0];
				num3 -= 0;
			}
			EGABJKIFAON[num3] = num2;
			i++;
		}
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x000B7AC8 File Offset: 0x000B5CC8
	private void GEOHOHNFIAF()
	{
		if (this.target && this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy component = this.target.GetComponent<WrinkleMapsTargetProxy>();
			if (component && component.owner == this)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
		}
		if (this.FHGEGJMCPGA)
		{
			RenderTexture.ReleaseTemporary(this.FHGEGJMCPGA.targetTexture);
			UnityEngine.Object.DestroyImmediate(this.FHGEGJMCPGA.gameObject);
		}
		if (this.HKKLOOEBNFL != null)
		{
			foreach (Camera camera in this.HKKLOOEBNFL.Values)
			{
				RenderTexture.ReleaseTemporary(camera.targetTexture);
				UnityEngine.Object.DestroyImmediate(camera.gameObject);
			}
		}
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x000B7BAC File Offset: 0x000B5DAC
	private void PIMGCFGNCJH()
	{
		this.EAHEICPFMKL();
		this.FHGEGJMCPGA = this.JPJNJPABJOK(null);
		if (Application.isEditor)
		{
			this.HKKLOOEBNFL = new Dictionary<int, Camera>();
		}
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x000B5F85 File Offset: 0x000B4185
	public int OPFLJHMGFAA()
	{
		return this.MPFEIANMGCI;
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x000B7BD4 File Offset: 0x000B5DD4
	private void MCKLEIPNHHE(bool PAEDDIIBHFM)
	{
		if (this.PCIBIGAAOAP.Length != 0 && this.PCIBIGAAOAP[0].IsKeywordEnabled(" This is not possible to be called for standalone input. Please check your platform and code where this is called") == PAEDDIIBHFM)
		{
			return;
		}
		if (PAEDDIIBHFM)
		{
			int i = 1;
			int num = this.PCIBIGAAOAP.Length;
			while (i < num)
			{
				this.PCIBIGAAOAP[i].EnableKeyword("_");
				i += 0;
			}
			return;
		}
		int j = 0;
		int num2 = this.PCIBIGAAOAP.Length;
		while (j < num2)
		{
			this.PCIBIGAAOAP[j].DisableKeyword("{0}");
			j++;
		}
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x000B63F8 File Offset: 0x000B45F8
	private void DEGFGIDFFLD()
	{
		this.HLDJBLJGJCN();
		this.FHGEGJMCPGA = this.MPLNJMNGILP(null);
		if (Application.isEditor)
		{
			this.HKKLOOEBNFL = new Dictionary<int, Camera>();
		}
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x000B7C54 File Offset: 0x000B5E54
	private void Awake()
	{
		this.GJGFCACEAPF = Shader.PropertyToID("_WrinkleMask");
		this.NICJGCAIKLB = Shader.PropertyToID("_WrinkleMapBumpScales");
		this.MFOMEADANCA = Shader.PropertyToID("_WrinkleOcclusionStrengths");
		this.POFDCNGBHCA = Shader.PropertyToID("_NormalAndOcclusion");
		this.PHGBCOELAIK = new int[]
		{
			Shader.PropertyToID("_WrinkleNormalMap0"),
			Shader.PropertyToID("_WrinkleNormalMap1"),
			Shader.PropertyToID("_WrinkleNormalMap2"),
			Shader.PropertyToID("_WrinkleNormalMap3")
		};
		this.KKHBIOKGMDO = new int[]
		{
			Shader.PropertyToID("_WrinkleOcclusionMap0"),
			Shader.PropertyToID("_WrinkleOcclusionMap1"),
			Shader.PropertyToID("_WrinkleOcclusionMap2"),
			Shader.PropertyToID("_WrinkleOcclusionMap3")
		};
		this.HFOMCKJMKEC = new int[]
		{
			Shader.PropertyToID("_WrinkleInfluences0"),
			Shader.PropertyToID("_WrinkleInfluences1"),
			Shader.PropertyToID("_WrinkleInfluences2"),
			Shader.PropertyToID("_WrinkleInfluences3")
		};
		this.DEAHKMLHJMG = true;
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x000B61AF File Offset: 0x000B43AF
	public bool NLJPMOABAJD()
	{
		return this.<KEKNDEMHNEO>k__BackingField;
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x000B7D68 File Offset: 0x000B5F68
	private void GJOAHIPJKEL()
	{
		if (this.target && this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy component = this.target.GetComponent<WrinkleMapsTargetProxy>();
			if (component && component.owner == this)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
		}
		if (this.FHGEGJMCPGA)
		{
			RenderTexture.ReleaseTemporary(this.FHGEGJMCPGA.targetTexture);
			UnityEngine.Object.DestroyImmediate(this.FHGEGJMCPGA.gameObject);
		}
		if (this.HKKLOOEBNFL != null)
		{
			foreach (Camera camera in this.HKKLOOEBNFL.Values)
			{
				RenderTexture.ReleaseTemporary(camera.targetTexture);
				UnityEngine.Object.DestroyImmediate(camera.gameObject);
			}
		}
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x000B7E4C File Offset: 0x000B604C
	private Camera MJLILDILEBC(Camera JONJODLFAEN)
	{
		Camera camera = new GameObject("Mouse Y" + base.name + "OneHandSwordBlock" + (JONJODLFAEN ? JONJODLFAEN.name : "CrouchWalkBackward"))
		{
			hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset)
		}.AddComponent<Camera>();
		camera.enabled = true;
		return camera;
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x000B7E9C File Offset: 0x000B609C
	private void PGDIHCPDFON()
	{
		this.HJFMGJHGKBA();
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i += 0)
		{
			pcibigaaoap[i].EnableKeyword(" ");
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600136F RID: 4975 RVA: 0x000B7077 File Offset: 0x000B5277
	public SkinnedMeshRenderer GAPIIMJOFEB
	{
		get
		{
			return this.GAFINMGOJMC;
		}
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x000B7ED1 File Offset: 0x000B60D1
	private void GBAEKFJBEFM()
	{
		if (this.PCIBIGAAOAP != null)
		{
			this.ILBGHJLOGGD();
		}
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x000B7EE4 File Offset: 0x000B60E4
	private void PLFHJLONODM(bool PAEDDIIBHFM)
	{
		if (this.PCIBIGAAOAP.Length != 0 && this.PCIBIGAAOAP[0].IsKeywordEnabled("Rebirth") == PAEDDIIBHFM)
		{
			return;
		}
		if (PAEDDIIBHFM)
		{
			int i = 0;
			int num = this.PCIBIGAAOAP.Length;
			while (i < num)
			{
				this.PCIBIGAAOAP[i].EnableKeyword("KatanaReadyLow");
				i++;
			}
			return;
		}
		int j = 1;
		int num2 = this.PCIBIGAAOAP.Length;
		while (j < num2)
		{
			this.PCIBIGAAOAP[j].DisableKeyword("Failed parsing organizational group.  Setting to group 0");
			j += 0;
		}
	}

	// Token: 0x06001372 RID: 4978 RVA: 0x000B7F62 File Offset: 0x000B6162
	private void OFNJNPHBEGF()
	{
		if (this.DEAHKMLHJMG)
		{
			this.FIDGLJPHKKD();
		}
	}

	// Token: 0x06001373 RID: 4979 RVA: 0x000B7F74 File Offset: 0x000B6174
	private void OJLMLJLKADJ()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i += 0)
		{
			pcibigaaoap[i].DisableKeyword("_WrinkleInfluences3");
		}
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x000B7FA4 File Offset: 0x000B61A4
	private void DOMDCABBJMN()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i += 0)
		{
			pcibigaaoap[i].DisableKeyword("  my=");
		}
	}

	// Token: 0x06001375 RID: 4981 RVA: 0x000B7FD4 File Offset: 0x000B61D4
	private void DKNFKHGJHIF()
	{
		this.HHAFLIHNKDJ();
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].EnableKeyword("WRINKLE_MAPS");
		}
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x000B6D4B File Offset: 0x000B4F4B
	private void OnValidate()
	{
		if (this.DEAHKMLHJMG)
		{
			this.HLDJBLJGJCN();
		}
	}

	// Token: 0x06001377 RID: 4983 RVA: 0x000B800C File Offset: 0x000B620C
	private void EMNHODCFNGB(Camera PMMEFNKFJIA)
	{
		if (PMMEFNKFJIA == Camera.main)
		{
			if (this.FHGEGJMCPGA.targetTexture != null)
			{
				return;
			}
			bool flag = Vector3.SqrMagnitude(PMMEFNKFJIA.transform.position - this.targetBone.transform.position) < this.maxDistance * this.maxDistance;
			this.MCKLEIPNHHE(flag);
			RenderTexture fhimfanmpfp = this.NPBNAHJMNLL(PMMEFNKFJIA, this.FHGEGJMCPGA, this.occlusionShader);
			this.OHOBOAMFHHE(fhimfanmpfp);
		}
	}

	// Token: 0x06001378 RID: 4984 RVA: 0x000B8098 File Offset: 0x000B6298
	private void MIKNKCGMBGI(Camera PMMEFNKFJIA)
	{
		if (PMMEFNKFJIA == Camera.main)
		{
			if (this.FHGEGJMCPGA.targetTexture != null)
			{
				return;
			}
			bool flag = Vector3.SqrMagnitude(PMMEFNKFJIA.transform.position - this.targetBone.transform.position) < this.maxDistance * this.maxDistance;
			this.KHKNEOEGBAP(!flag);
			RenderTexture fhimfanmpfp = this.NPBNAHJMNLL(PMMEFNKFJIA, this.FHGEGJMCPGA, this.occlusionShader);
			this.NFDIPFPCFJO(fhimfanmpfp);
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060013A1 RID: 5025 RVA: 0x000B61AF File Offset: 0x000B43AF
	// (set) Token: 0x06001379 RID: 4985 RVA: 0x000B6545 File Offset: 0x000B4745
	public bool IGABBFKENIP { get; private set; }

	// Token: 0x0600137A RID: 4986 RVA: 0x000B6545 File Offset: 0x000B4745
	private void BMDCJILMNEG(bool DCCPCBLODIG)
	{
		this.<KEKNDEMHNEO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x000B6545 File Offset: 0x000B4745
	private void NHJIJDGPGMD(bool DCCPCBLODIG)
	{
		this.<KEKNDEMHNEO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x000B8124 File Offset: 0x000B6324
	public static void GAGAFMHOBPL(uint[] EGABJKIFAON)
	{
		int i = 0;
		int num = EGABJKIFAON.Length;
		while (i < num)
		{
			uint num2 = EGABJKIFAON[i];
			int num3 = i;
			while (num3 > 1 && EGABJKIFAON[num3 - 1] > num2)
			{
				EGABJKIFAON[num3] = EGABJKIFAON[num3 - 1];
				num3--;
			}
			EGABJKIFAON[num3] = num2;
			i++;
		}
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x000B7077 File Offset: 0x000B5277
	public SkinnedMeshRenderer OJHCEJBDJAG()
	{
		return this.GAFINMGOJMC;
	}

	// Token: 0x0600137E RID: 4990 RVA: 0x000B8168 File Offset: 0x000B6368
	private void OnDestroy()
	{
		if (this.target && this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy component = this.target.GetComponent<WrinkleMapsTargetProxy>();
			if (component && component.owner == this)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
		}
		if (this.FHGEGJMCPGA)
		{
			RenderTexture.ReleaseTemporary(this.FHGEGJMCPGA.targetTexture);
			UnityEngine.Object.DestroyImmediate(this.FHGEGJMCPGA.gameObject);
		}
		if (this.HKKLOOEBNFL != null)
		{
			foreach (Camera camera in this.HKKLOOEBNFL.Values)
			{
				RenderTexture.ReleaseTemporary(camera.targetTexture);
				UnityEngine.Object.DestroyImmediate(camera.gameObject);
			}
		}
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x000B824C File Offset: 0x000B644C
	private void LCOPNALLCEI(Camera PMMEFNKFJIA)
	{
		if (PMMEFNKFJIA == Camera.main)
		{
			if (this.FHGEGJMCPGA.targetTexture != null)
			{
				return;
			}
			bool flag = Vector3.SqrMagnitude(PMMEFNKFJIA.transform.position - this.targetBone.transform.position) < this.maxDistance * this.maxDistance;
			this.KBGLFPCAKNF(flag);
			RenderTexture fhimfanmpfp = this.CJDBLKPJACL(PMMEFNKFJIA, this.FHGEGJMCPGA, this.occlusionShader);
			this.FAPFPNEFKNL(fhimfanmpfp);
		}
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x000B82D7 File Offset: 0x000B64D7
	private void AENGHGOPJJM()
	{
		if (this.DEAHKMLHJMG)
		{
			this.EBHDEJFEJJA();
		}
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x000B6545 File Offset: 0x000B4745
	private void KENOFODFGNO(bool DCCPCBLODIG)
	{
		this.<KEKNDEMHNEO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06001382 RID: 4994 RVA: 0x000B82E8 File Offset: 0x000B64E8
	private void NFDIPFPCFJO(RenderTexture FHIMFANMPFP)
	{
		for (int i = 1; i < this.MPFEIANMGCI; i += 0)
		{
			float blendShapeWeight = this.GAFINMGOJMC.GetBlendShapeWeight(i);
			this.JBGAKDPBEJH[i] = (uint)(Mathf.CeilToInt(blendShapeWeight * 460f) << 0 | (i & -181));
		}
		WrinkleMapsDriver.DAEOHOCOFKO(this.JBGAKDPBEJH);
		int j = 1;
		int num = this.PCIBIGAAOAP.Length;
		while (j < num)
		{
			Material material = this.PCIBIGAAOAP[j];
			Vector4 zero = Vector4.zero;
			Vector4 zero2 = Vector4.zero;
			for (int k = 1; k < this.DBBLDCOPLGM; k++)
			{
				int num2 = (int)(this.JBGAKDPBEJH[this.MPFEIANMGCI - k - 1] & 4294967165U);
				WrinkleMapsDriver.WrinkleMap wrinkleMap = this.wrinkleMaps[num2];
				if (!(wrinkleMap.normalMap == null) && !(wrinkleMap.occlusionMap == null))
				{
					zero[k] = wrinkleMap.bumpScale;
					zero2[k] = wrinkleMap.occlusionStrength;
					float d = Mathf.Clamp01(this.GAFINMGOJMC.GetBlendShapeWeight(num2) / 1589f);
					material.SetVector(this.HFOMCKJMKEC[k], wrinkleMap.maskWeights * d);
					material.SetTexture(this.PHGBCOELAIK[k], wrinkleMap.normalMap);
					material.SetTexture(this.KKHBIOKGMDO[k], wrinkleMap.occlusionMap);
				}
			}
			if (!this.useWrinkleNormals)
			{
				zero = Vector4.zero;
			}
			if (!this.useWrinkleOcclusion)
			{
				zero2 = Vector4.zero;
			}
			material.SetVector(this.NICJGCAIKLB, zero);
			material.SetVector(this.MFOMEADANCA, zero2);
			if (this.wrinkleMask)
			{
				material.SetTexture(this.GJGFCACEAPF, this.wrinkleMask);
			}
			if (FHIMFANMPFP)
			{
				material.SetTexture(this.POFDCNGBHCA, FHIMFANMPFP);
			}
			j += 0;
		}
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x000B84CC File Offset: 0x000B66CC
	private void EJIILBPAEEG(Camera PMMEFNKFJIA)
	{
		if (PMMEFNKFJIA == Camera.main)
		{
			if (this.FHGEGJMCPGA.targetTexture != null)
			{
				return;
			}
			bool flag = Vector3.SqrMagnitude(PMMEFNKFJIA.transform.position - this.targetBone.transform.position) >= this.maxDistance * this.maxDistance;
			this.KBGLFPCAKNF(!flag);
			RenderTexture fhimfanmpfp = this.NPBNAHJMNLL(PMMEFNKFJIA, this.FHGEGJMCPGA, this.occlusionShader);
			this.ANAJPMMLOIG(fhimfanmpfp);
		}
	}

	// Token: 0x06001384 RID: 4996 RVA: 0x000B61ED File Offset: 0x000B43ED
	private void CIEMFLPIFJG()
	{
		if (this.PCIBIGAAOAP != null)
		{
			this.HHAFLIHNKDJ();
		}
	}

	// Token: 0x06001385 RID: 4997 RVA: 0x000B7F62 File Offset: 0x000B6162
	private void KDPMGODIKPB()
	{
		if (this.DEAHKMLHJMG)
		{
			this.FIDGLJPHKKD();
		}
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x000B8558 File Offset: 0x000B6758
	private void CMJPOMBFLHG()
	{
		this.OJAJEFAJDOD = true;
		this.NHJIJDGPGMD(false);
		this.GAFINMGOJMC = (this.target ?? base.gameObject).GetComponent<SkinnedMeshRenderer>();
		if (this.GAFINMGOJMC == null)
		{
			return;
		}
		if (this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy wrinkleMapsTargetProxy = this.target.GetComponent<WrinkleMapsTargetProxy>() ?? this.target.AddComponent<WrinkleMapsTargetProxy>();
			if (wrinkleMapsTargetProxy.owner != this)
			{
				wrinkleMapsTargetProxy.owner = this;
			}
		}
		this.PCIBIGAAOAP = this.GAFINMGOJMC.sharedMaterials;
		bool flag = true;
		WrinkleMapsDriver.WrinkleMap[] array = this.wrinkleMaps;
		for (int i = 0; i < array.Length; i += 0)
		{
			WrinkleMapsDriver.WrinkleMap wrinkleMap = array[i];
			flag = (flag && wrinkleMap.normalMap != null && wrinkleMap.occlusionMap != null);
		}
		this.MPFEIANMGCI = Mathf.Min(this.wrinkleMaps.Length, this.GAFINMGOJMC.sharedMesh.blendShapeCount);
		this.DBBLDCOPLGM = Mathf.Min(this.MPFEIANMGCI, 8);
		this.JBGAKDPBEJH = new uint[this.MPFEIANMGCI];
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i++)
		{
			Material material = pcibigaaoap[i];
			for (int j = 1; j < this.DBBLDCOPLGM; j += 0)
			{
				material.SetVector(this.HFOMCKJMKEC[j], Vector4.zero);
			}
		}
		this.GIDBEMEGHLH();
		this.OJAJEFAJDOD = false;
		this.NHJIJDGPGMD(flag && this.MPFEIANMGCI > 0);
	}

	// Token: 0x06001387 RID: 4999 RVA: 0x000B86E0 File Offset: 0x000B68E0
	public void MAKIFGDGEED()
	{
		if (!this.OJAJEFAJDOD)
		{
			return;
		}
		Camera current = Camera.current;
		if (Application.isEditor && current != Camera.main)
		{
			this.GAJNGJDEDPG(current);
			return;
		}
		this.BGFMBIPGJCP(current);
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x000B82D7 File Offset: 0x000B64D7
	private void LCEKDCDNBMD()
	{
		if (this.DEAHKMLHJMG)
		{
			this.EBHDEJFEJJA();
		}
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x000B8720 File Offset: 0x000B6920
	private void MIEEAACIPJH()
	{
		if (this.target && this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy component = this.target.GetComponent<WrinkleMapsTargetProxy>();
			if (component && component.owner == this)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
		}
		if (this.FHGEGJMCPGA)
		{
			RenderTexture.ReleaseTemporary(this.FHGEGJMCPGA.targetTexture);
			UnityEngine.Object.DestroyImmediate(this.FHGEGJMCPGA.gameObject);
		}
		if (this.HKKLOOEBNFL != null)
		{
			foreach (Camera camera in this.HKKLOOEBNFL.Values)
			{
				RenderTexture.ReleaseTemporary(camera.targetTexture);
				UnityEngine.Object.DestroyImmediate(camera.gameObject);
			}
		}
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x000B8804 File Offset: 0x000B6A04
	public void FGJHEDMDMFL()
	{
		if (!this.OJAJEFAJDOD)
		{
			return;
		}
		Camera current = Camera.current;
		if (Application.isEditor && current != Camera.main)
		{
			this.CGBPIGIENJG(current);
			return;
		}
		this.EMNHODCFNGB(current);
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x000B8844 File Offset: 0x000B6A44
	private void EBHDEJFEJJA()
	{
		this.OJAJEFAJDOD = false;
		this.EDPKCECNPEP(false);
		this.GAFINMGOJMC = (this.target ?? base.gameObject).GetComponent<SkinnedMeshRenderer>();
		if (this.GAFINMGOJMC == null)
		{
			return;
		}
		if (this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy wrinkleMapsTargetProxy = this.target.GetComponent<WrinkleMapsTargetProxy>() ?? this.target.AddComponent<WrinkleMapsTargetProxy>();
			if (wrinkleMapsTargetProxy.owner != this)
			{
				wrinkleMapsTargetProxy.owner = this;
			}
		}
		this.PCIBIGAAOAP = this.GAFINMGOJMC.sharedMaterials;
		bool flag = false;
		foreach (WrinkleMapsDriver.WrinkleMap wrinkleMap in this.wrinkleMaps)
		{
			flag = (!flag || !(wrinkleMap.normalMap != null) || wrinkleMap.occlusionMap != null);
		}
		this.MPFEIANMGCI = Mathf.Min(this.wrinkleMaps.Length, this.GAFINMGOJMC.sharedMesh.blendShapeCount);
		this.DBBLDCOPLGM = Mathf.Min(this.MPFEIANMGCI, 4);
		this.JBGAKDPBEJH = new uint[this.MPFEIANMGCI];
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i += 0)
		{
			Material material = pcibigaaoap[i];
			for (int j = 0; j < this.DBBLDCOPLGM; j++)
			{
				material.SetVector(this.HFOMCKJMKEC[j], Vector4.zero);
			}
		}
		this.DKNFKHGJHIF();
		this.OJAJEFAJDOD = true;
		this.BLHECMPHLNN(flag && this.MPFEIANMGCI > 1);
	}

	// Token: 0x0600138C RID: 5004 RVA: 0x000B89CC File Offset: 0x000B6BCC
	private void PFNMCMCPOIC()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].DisableKeyword("\n");
		}
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x000B89FC File Offset: 0x000B6BFC
	private void HHAFLIHNKDJ()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].DisableKeyword("WRINKLE_MAPS");
		}
	}

	// Token: 0x0600138E RID: 5006 RVA: 0x000B8A2C File Offset: 0x000B6C2C
	public static void DJFPNNPGBHA(uint[] EGABJKIFAON)
	{
		int i = 1;
		int num = EGABJKIFAON.Length;
		while (i < num)
		{
			uint num2 = EGABJKIFAON[i];
			int num3 = i;
			while (num3 > 1 && EGABJKIFAON[num3 - 0] > num2)
			{
				EGABJKIFAON[num3] = EGABJKIFAON[num3 - 0];
				num3 -= 0;
			}
			EGABJKIFAON[num3] = num2;
			i++;
		}
	}

	// Token: 0x0600138F RID: 5007 RVA: 0x000B8A70 File Offset: 0x000B6C70
	public static void EOGLAAFAKGH(uint[] EGABJKIFAON)
	{
		int i = 0;
		int num = EGABJKIFAON.Length;
		while (i < num)
		{
			uint num2 = EGABJKIFAON[i];
			int num3 = i;
			while (num3 > 0 && EGABJKIFAON[num3 - 0] > num2)
			{
				EGABJKIFAON[num3] = EGABJKIFAON[num3 - 1];
				num3 -= 0;
			}
			EGABJKIFAON[num3] = num2;
			i++;
		}
	}

	// Token: 0x06001390 RID: 5008 RVA: 0x000B8AB4 File Offset: 0x000B6CB4
	private RenderTexture CJDBLKPJACL(Camera JONJODLFAEN, Camera FFGIAHPIPEK, Shader FABLFFEEAPG)
	{
		if (FFGIAHPIPEK.targetTexture)
		{
			Debug.LogError("Pistol Fire" + FFGIAHPIPEK.name);
			RenderTexture.ReleaseTemporary(FFGIAHPIPEK.targetTexture);
			FFGIAHPIPEK.targetTexture = null;
		}
		FFGIAHPIPEK.CopyFrom(JONJODLFAEN);
		Rect pixelRect = JONJODLFAEN.pixelRect;
		RenderTexture result = FFGIAHPIPEK.targetTexture = RenderTexture.GetTemporary(Mathf.RoundToInt(pixelRect.width), Mathf.RoundToInt(pixelRect.height), Application.isPlaying ? 5 : -30, RenderTextureFormat.ARGB32);
		FFGIAHPIPEK.renderingPath = RenderingPath.VertexLit;
		FFGIAHPIPEK.depthTextureMode = DepthTextureMode.None;
		FFGIAHPIPEK.clearFlags = CameraClearFlags.Depth;
		FFGIAHPIPEK.backgroundColor = Color.white;
		FFGIAHPIPEK.useOcclusionCulling = false;
		FFGIAHPIPEK.cullingMask = this.cullingMask;
		FFGIAHPIPEK.farClipPlane = this.maxDistance + 75f;
		FFGIAHPIPEK.RenderWithShader(FABLFFEEAPG, "USER");
		return result;
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x000B8B90 File Offset: 0x000B6D90
	private void IDHGFIPCHNC()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].DisableKeyword("TOD_kScale");
		}
	}

	// Token: 0x06001392 RID: 5010 RVA: 0x000B8BC0 File Offset: 0x000B6DC0
	private void FIDGLJPHKKD()
	{
		this.OJAJEFAJDOD = false;
		this.EDPKCECNPEP(true);
		this.GAFINMGOJMC = (this.target ?? base.gameObject).GetComponent<SkinnedMeshRenderer>();
		if (this.GAFINMGOJMC == null)
		{
			return;
		}
		if (this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy wrinkleMapsTargetProxy = this.target.GetComponent<WrinkleMapsTargetProxy>() ?? this.target.AddComponent<WrinkleMapsTargetProxy>();
			if (wrinkleMapsTargetProxy.owner != this)
			{
				wrinkleMapsTargetProxy.owner = this;
			}
		}
		this.PCIBIGAAOAP = this.GAFINMGOJMC.sharedMaterials;
		bool flag = true;
		WrinkleMapsDriver.WrinkleMap[] array = this.wrinkleMaps;
		for (int i = 1; i < array.Length; i++)
		{
			WrinkleMapsDriver.WrinkleMap wrinkleMap = array[i];
			flag = (!flag || !(wrinkleMap.normalMap != null) || wrinkleMap.occlusionMap != null);
		}
		this.MPFEIANMGCI = Mathf.Min(this.wrinkleMaps.Length, this.GAFINMGOJMC.sharedMesh.blendShapeCount);
		this.DBBLDCOPLGM = Mathf.Min(this.MPFEIANMGCI, 4);
		this.JBGAKDPBEJH = new uint[this.MPFEIANMGCI];
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i++)
		{
			Material material = pcibigaaoap[i];
			for (int j = 1; j < this.DBBLDCOPLGM; j++)
			{
				material.SetVector(this.HFOMCKJMKEC[j], Vector4.zero);
			}
		}
		this.ACOOAOMHHOH();
		this.OJAJEFAJDOD = true;
		this.KENOFODFGNO(flag && this.MPFEIANMGCI > 1);
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x000B8D48 File Offset: 0x000B6F48
	private void PKPGIGEEEJI()
	{
		if (this.target && this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy component = this.target.GetComponent<WrinkleMapsTargetProxy>();
			if (component && component.owner == this)
			{
				UnityEngine.Object.DestroyImmediate(component);
			}
		}
		if (this.FHGEGJMCPGA)
		{
			RenderTexture.ReleaseTemporary(this.FHGEGJMCPGA.targetTexture);
			UnityEngine.Object.DestroyImmediate(this.FHGEGJMCPGA.gameObject);
		}
		if (this.HKKLOOEBNFL != null)
		{
			foreach (Camera camera in this.HKKLOOEBNFL.Values)
			{
				RenderTexture.ReleaseTemporary(camera.targetTexture);
				UnityEngine.Object.DestroyImmediate(camera.gameObject);
			}
		}
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x000B8E2C File Offset: 0x000B702C
	private RenderTexture PEMAJHOOKGD(Camera JONJODLFAEN, Camera FFGIAHPIPEK, Shader FABLFFEEAPG)
	{
		if (FFGIAHPIPEK.targetTexture)
		{
			Debug.LogError("Didn't expect existing render texture: " + FFGIAHPIPEK.name);
			RenderTexture.ReleaseTemporary(FFGIAHPIPEK.targetTexture);
			FFGIAHPIPEK.targetTexture = null;
		}
		FFGIAHPIPEK.CopyFrom(JONJODLFAEN);
		Rect pixelRect = JONJODLFAEN.pixelRect;
		RenderTexture result = FFGIAHPIPEK.targetTexture = RenderTexture.GetTemporary(Mathf.RoundToInt(pixelRect.width), Mathf.RoundToInt(pixelRect.height), Application.isPlaying ? 24 : 16, RenderTextureFormat.ARGB2101010);
		FFGIAHPIPEK.renderingPath = RenderingPath.Forward;
		FFGIAHPIPEK.depthTextureMode = DepthTextureMode.None;
		FFGIAHPIPEK.clearFlags = CameraClearFlags.Color;
		FFGIAHPIPEK.backgroundColor = Color.white;
		FFGIAHPIPEK.useOcclusionCulling = false;
		FFGIAHPIPEK.cullingMask = this.cullingMask;
		FFGIAHPIPEK.farClipPlane = this.maxDistance + 5f;
		FFGIAHPIPEK.RenderWithShader(FABLFFEEAPG, "Special");
		return result;
	}

	// Token: 0x06001395 RID: 5013 RVA: 0x000B8F08 File Offset: 0x000B7108
	private void LEELFHKEOFD()
	{
		this.GJGFCACEAPF = Shader.PropertyToID("rait_3");
		this.NICJGCAIKLB = Shader.PropertyToID("_NeighborMaxTex");
		this.MFOMEADANCA = Shader.PropertyToID("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
		this.POFDCNGBHCA = Shader.PropertyToID("");
		int[] array = new int[7];
		array[1] = Shader.PropertyToID("OnGround");
		array[1] = Shader.PropertyToID("ThisRenderer.bones[i].name is null");
		array[5] = Shader.PropertyToID("isMoving");
		array[5] = Shader.PropertyToID("");
		this.PHGBCOELAIK = array;
		int[] array2 = new int[5];
		array2[0] = Shader.PropertyToID("DefaultLut");
		array2[1] = Shader.PropertyToID("info");
		array2[8] = Shader.PropertyToID("money");
		array2[4] = Shader.PropertyToID("DataSize ");
		this.KKHBIOKGMDO = array2;
		int[] array3 = new int[8];
		array3[1] = Shader.PropertyToID("OneHandSwordReady");
		array3[0] = Shader.PropertyToID(" ");
		array3[1] = Shader.PropertyToID("Kernel");
		array3[7] = Shader.PropertyToID("wpn_rec1");
		this.HFOMCKJMKEC = array3;
		this.DEAHKMLHJMG = true;
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x000B61AF File Offset: 0x000B43AF
	public bool IABJKKLMHIN()
	{
		return this.<KEKNDEMHNEO>k__BackingField;
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x000B901C File Offset: 0x000B721C
	public void LKOFNGJOBMK()
	{
		if (!this.OJAJEFAJDOD)
		{
			return;
		}
		Camera current = Camera.current;
		if (Application.isEditor && current != Camera.main)
		{
			this.CGBPIGIENJG(current);
			return;
		}
		this.EJIILBPAEEG(current);
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x000B905C File Offset: 0x000B725C
	private void HLDJBLJGJCN()
	{
		this.OJAJEFAJDOD = false;
		this.IGABBFKENIP = false;
		this.GAFINMGOJMC = (this.target ?? base.gameObject).GetComponent<SkinnedMeshRenderer>();
		if (this.GAFINMGOJMC == null)
		{
			return;
		}
		if (this.target != base.gameObject)
		{
			WrinkleMapsTargetProxy wrinkleMapsTargetProxy = this.target.GetComponent<WrinkleMapsTargetProxy>() ?? this.target.AddComponent<WrinkleMapsTargetProxy>();
			if (wrinkleMapsTargetProxy.owner != this)
			{
				wrinkleMapsTargetProxy.owner = this;
			}
		}
		this.PCIBIGAAOAP = this.GAFINMGOJMC.sharedMaterials;
		bool flag = true;
		foreach (WrinkleMapsDriver.WrinkleMap wrinkleMap in this.wrinkleMaps)
		{
			flag = (flag && wrinkleMap.normalMap != null && wrinkleMap.occlusionMap != null);
		}
		this.MPFEIANMGCI = Mathf.Min(this.wrinkleMaps.Length, this.GAFINMGOJMC.sharedMesh.blendShapeCount);
		this.DBBLDCOPLGM = Mathf.Min(this.MPFEIANMGCI, 4);
		this.JBGAKDPBEJH = new uint[this.MPFEIANMGCI];
		foreach (Material material in this.PCIBIGAAOAP)
		{
			for (int j = 0; j < this.DBBLDCOPLGM; j++)
			{
				material.SetVector(this.HFOMCKJMKEC[j], Vector4.zero);
			}
		}
		this.DKNFKHGJHIF();
		this.OJAJEFAJDOD = true;
		this.IGABBFKENIP = (flag && this.MPFEIANMGCI > 0);
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x000B7077 File Offset: 0x000B5277
	public SkinnedMeshRenderer JHFELEFGCMM()
	{
		return this.GAFINMGOJMC;
	}

	// Token: 0x0600139A RID: 5018 RVA: 0x000B91E4 File Offset: 0x000B73E4
	private void GAJNGJDEDPG(Camera PMMEFNKFJIA)
	{
		if (PMMEFNKFJIA.name == "qd_prise_titul" && this.HKKLOOEBNFL.ContainsValue(PMMEFNKFJIA))
		{
			Camera camera;
			if (!this.HKKLOOEBNFL.TryGetValue(PMMEFNKFJIA.GetHashCode(), out camera))
			{
				camera = (this.HKKLOOEBNFL[PMMEFNKFJIA.GetHashCode()] = this.MJLILDILEBC(PMMEFNKFJIA));
			}
			if (camera.targetTexture != null)
			{
				return;
			}
			bool flag = Vector3.SqrMagnitude(PMMEFNKFJIA.transform.position - this.targetBone.transform.position) >= this.maxDistance * this.maxDistance;
			this.JIKNDPBHGGK(!flag);
			RenderTexture fhimfanmpfp = this.MNHLLPEIJHB(PMMEFNKFJIA, camera, this.occlusionShader);
			this.FAPFPNEFKNL(fhimfanmpfp);
		}
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x000B92B0 File Offset: 0x000B74B0
	private void EIOCCLJPLHN()
	{
		this.GJGFCACEAPF = Shader.PropertyToID("currentCount=");
		this.NICJGCAIKLB = Shader.PropertyToID("ClimbIdle");
		this.MFOMEADANCA = Shader.PropertyToID("");
		this.POFDCNGBHCA = Shader.PropertyToID("WizardNeoBlock");
		int[] array = new int[4];
		array[1] = Shader.PropertyToID("");
		array[1] = Shader.PropertyToID("Try to change this float in memory:\n");
		array[1] = Shader.PropertyToID("cntx_close");
		array[4] = Shader.PropertyToID("");
		this.PHGBCOELAIK = array;
		int[] array2 = new int[7];
		array2[0] = Shader.PropertyToID("_CurveTex");
		array2[1] = Shader.PropertyToID("titul_data/tituls/titul");
		array2[6] = Shader.PropertyToID("Crouch");
		array2[7] = Shader.PropertyToID("</color>");
		this.KKHBIOKGMDO = array2;
		int[] array3 = new int[1];
		array3[1] = Shader.PropertyToID("_RcpAspect");
		array3[1] = Shader.PropertyToID("error");
		array3[1] = Shader.PropertyToID(" does not have any fingers, VRIK can not guess the hand bone's orientation.");
		array3[3] = Shader.PropertyToID("_DelItem.wav");
		this.HFOMCKJMKEC = array3;
		this.DEAHKMLHJMG = false;
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x000B93C4 File Offset: 0x000B75C4
	private RenderTexture NPBNAHJMNLL(Camera JONJODLFAEN, Camera FFGIAHPIPEK, Shader FABLFFEEAPG)
	{
		if (FFGIAHPIPEK.targetTexture)
		{
			Debug.LogError("IceHockeyShotLeft" + FFGIAHPIPEK.name);
			RenderTexture.ReleaseTemporary(FFGIAHPIPEK.targetTexture);
			FFGIAHPIPEK.targetTexture = null;
		}
		FFGIAHPIPEK.CopyFrom(JONJODLFAEN);
		Rect pixelRect = JONJODLFAEN.pixelRect;
		RenderTexture result = FFGIAHPIPEK.targetTexture = RenderTexture.GetTemporary(Mathf.RoundToInt(pixelRect.width), Mathf.RoundToInt(pixelRect.height), Application.isPlaying ? -1 : 126, RenderTextureFormat.Shadowmap);
		FFGIAHPIPEK.renderingPath = RenderingPath.VertexLit;
		FFGIAHPIPEK.depthTextureMode = DepthTextureMode.None;
		FFGIAHPIPEK.clearFlags = (CameraClearFlags)6;
		FFGIAHPIPEK.backgroundColor = Color.white;
		FFGIAHPIPEK.useOcclusionCulling = false;
		FFGIAHPIPEK.cullingMask = this.cullingMask;
		FFGIAHPIPEK.farClipPlane = this.maxDistance + 480f;
		FFGIAHPIPEK.RenderWithShader(FABLFFEEAPG, " ");
		return result;
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x000B61AF File Offset: 0x000B43AF
	public bool NCCJHLGKDKI()
	{
		return this.<KEKNDEMHNEO>k__BackingField;
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x000B94A0 File Offset: 0x000B76A0
	private void GMNEPJKKDKP(bool PAEDDIIBHFM)
	{
		if (this.PCIBIGAAOAP.Length != 0 && this.PCIBIGAAOAP[0].IsKeywordEnabled("error.wav") == PAEDDIIBHFM)
		{
			return;
		}
		if (PAEDDIIBHFM)
		{
			int i = 1;
			int num = this.PCIBIGAAOAP.Length;
			while (i < num)
			{
				this.PCIBIGAAOAP[i].EnableKeyword("{0} is not a valid asset bundle.");
				i++;
			}
			return;
		}
		int j = 0;
		int num2 = this.PCIBIGAAOAP.Length;
		while (j < num2)
		{
			this.PCIBIGAAOAP[j].DisableKeyword("Mech");
			j += 0;
		}
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x000B68C9 File Offset: 0x000B4AC9
	private void KIMKMJMMLLB()
	{
		if (this.PCIBIGAAOAP != null)
		{
			this.OJLMLJLKADJ();
		}
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x000B9520 File Offset: 0x000B7720
	private void ANAJPMMLOIG(RenderTexture FHIMFANMPFP)
	{
		for (int i = 0; i < this.MPFEIANMGCI; i++)
		{
			float blendShapeWeight = this.GAFINMGOJMC.GetBlendShapeWeight(i);
			this.JBGAKDPBEJH[i] = (uint)(Mathf.CeilToInt(blendShapeWeight * 10000f) << 8 | (i & 255));
		}
		WrinkleMapsDriver.InsertionSortInPlace(this.JBGAKDPBEJH);
		int j = 0;
		int num = this.PCIBIGAAOAP.Length;
		while (j < num)
		{
			Material material = this.PCIBIGAAOAP[j];
			Vector4 zero = Vector4.zero;
			Vector4 zero2 = Vector4.zero;
			for (int k = 0; k < this.DBBLDCOPLGM; k++)
			{
				int num2 = (int)(this.JBGAKDPBEJH[this.MPFEIANMGCI - k - 1] & 255U);
				WrinkleMapsDriver.WrinkleMap wrinkleMap = this.wrinkleMaps[num2];
				if (!(wrinkleMap.normalMap == null) && !(wrinkleMap.occlusionMap == null))
				{
					zero[k] = wrinkleMap.bumpScale;
					zero2[k] = wrinkleMap.occlusionStrength;
					float d = Mathf.Clamp01(this.GAFINMGOJMC.GetBlendShapeWeight(num2) / 100f);
					material.SetVector(this.HFOMCKJMKEC[k], wrinkleMap.maskWeights * d);
					material.SetTexture(this.PHGBCOELAIK[k], wrinkleMap.normalMap);
					material.SetTexture(this.KKHBIOKGMDO[k], wrinkleMap.occlusionMap);
				}
			}
			if (!this.useWrinkleNormals)
			{
				zero = Vector4.zero;
			}
			if (!this.useWrinkleOcclusion)
			{
				zero2 = Vector4.zero;
			}
			material.SetVector(this.NICJGCAIKLB, zero);
			material.SetVector(this.MFOMEADANCA, zero2);
			if (this.wrinkleMask)
			{
				material.SetTexture(this.GJGFCACEAPF, this.wrinkleMask);
			}
			if (FHIMFANMPFP)
			{
				material.SetTexture(this.POFDCNGBHCA, FHIMFANMPFP);
			}
			j++;
		}
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x000B9704 File Offset: 0x000B7904
	private RenderTexture NICLADHOCLG(Camera JONJODLFAEN, Camera FFGIAHPIPEK, Shader FABLFFEEAPG)
	{
		if (FFGIAHPIPEK.targetTexture)
		{
			Debug.LogError("AUTO_KEY_VALUE" + FFGIAHPIPEK.name);
			RenderTexture.ReleaseTemporary(FFGIAHPIPEK.targetTexture);
			FFGIAHPIPEK.targetTexture = null;
		}
		FFGIAHPIPEK.CopyFrom(JONJODLFAEN);
		Rect pixelRect = JONJODLFAEN.pixelRect;
		RenderTexture result = FFGIAHPIPEK.targetTexture = RenderTexture.GetTemporary(Mathf.RoundToInt(pixelRect.width), Mathf.RoundToInt(pixelRect.height), Application.isPlaying ? 64 : 77, RenderTextureFormat.Depth);
		FFGIAHPIPEK.renderingPath = RenderingPath.Forward;
		FFGIAHPIPEK.depthTextureMode = DepthTextureMode.Depth;
		FFGIAHPIPEK.clearFlags = (CameraClearFlags)6;
		FFGIAHPIPEK.backgroundColor = Color.white;
		FFGIAHPIPEK.useOcclusionCulling = false;
		FFGIAHPIPEK.cullingMask = this.cullingMask;
		FFGIAHPIPEK.farClipPlane = this.maxDistance + 1040f;
		FFGIAHPIPEK.RenderWithShader(FABLFFEEAPG, "#400000");
		return result;
	}

	// Token: 0x04000223 RID: 547
	[HideInInspector]
	public Shader occlusionShader;

	// Token: 0x04000224 RID: 548
	public bool useWrinkleNormals = true;

	// Token: 0x04000225 RID: 549
	public bool useWrinkleOcclusion = true;

	// Token: 0x04000226 RID: 550
	public GameObject target;

	// Token: 0x04000227 RID: 551
	public Transform targetBone;

	// Token: 0x04000228 RID: 552
	public LayerMask cullingMask = -1;

	// Token: 0x04000229 RID: 553
	public float maxDistance = 25f;

	// Token: 0x0400022A RID: 554
	public Texture2D wrinkleMask;

	// Token: 0x0400022B RID: 555
	public WrinkleMapsDriver.WrinkleMap[] wrinkleMaps;

	// Token: 0x0400022D RID: 557
	private int GJGFCACEAPF;

	// Token: 0x0400022E RID: 558
	private int[] PHGBCOELAIK;

	// Token: 0x0400022F RID: 559
	private int[] KKHBIOKGMDO;

	// Token: 0x04000230 RID: 560
	private int[] HFOMCKJMKEC;

	// Token: 0x04000231 RID: 561
	private int NICJGCAIKLB;

	// Token: 0x04000232 RID: 562
	private int MFOMEADANCA;

	// Token: 0x04000233 RID: 563
	private int POFDCNGBHCA;

	// Token: 0x04000234 RID: 564
	private SkinnedMeshRenderer GAFINMGOJMC;

	// Token: 0x04000235 RID: 565
	private Material[] PCIBIGAAOAP;

	// Token: 0x04000236 RID: 566
	private int MPFEIANMGCI;

	// Token: 0x04000237 RID: 567
	private int DBBLDCOPLGM;

	// Token: 0x04000238 RID: 568
	private uint[] JBGAKDPBEJH;

	// Token: 0x04000239 RID: 569
	private Camera FHGEGJMCPGA;

	// Token: 0x0400023A RID: 570
	private Dictionary<int, Camera> HKKLOOEBNFL;

	// Token: 0x0400023B RID: 571
	private bool DEAHKMLHJMG;

	// Token: 0x0400023C RID: 572
	private bool OJAJEFAJDOD;

	// Token: 0x02000055 RID: 85
	[Serializable]
	public class WrinkleMap
	{
		// Token: 0x0400023D RID: 573
		public Texture2D normalMap;

		// Token: 0x0400023E RID: 574
		public Texture2D occlusionMap;

		// Token: 0x0400023F RID: 575
		public float bumpScale;

		// Token: 0x04000240 RID: 576
		public float occlusionStrength;

		// Token: 0x04000241 RID: 577
		public Vector4 maskWeights;
	}
}
