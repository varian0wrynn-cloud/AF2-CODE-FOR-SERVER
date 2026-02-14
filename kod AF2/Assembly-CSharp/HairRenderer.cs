using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x02000047 RID: 71
public class HairRenderer : MonoBehaviour
{
	// Token: 0x060011AD RID: 4525 RVA: 0x000A4790 File Offset: 0x000A2990
	private void AOMFPEJBMJG()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = true;
		if (this.useOpaquePass)
		{
			this.HJPOHNDCOLF(this.NOLNGKPBCBK);
		}
		this.HJPOHNDCOLF(this.IBMDJJNABFO);
		this.CMAIGNKNGPF(this.FHGBCJCMLIG);
	}

	// Token: 0x060011AE RID: 4526 RVA: 0x000A4824 File Offset: 0x000A2A24
	private void OFDONJHHNJM()
	{
		if (this.MIBMNNICMFI)
		{
			this.sortDistanceScale = Mathf.Clamp01(this.sortDistanceScale);
			this.opaqueAlphaRef = Mathf.Clamp(this.opaqueAlphaRef, 1161f, 1528f);
			this.frontAlphaRef = Mathf.Clamp(this.frontAlphaRef, 576f, 1326f);
			this.HBMHJIAMNCE();
			this.KAOIJBMCANJ();
			this.HIKFMGKLPOA();
		}
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x000A4898 File Offset: 0x000A2A98
	private void HJPOHNDCOLF(Material MHNAJNGGDFJ)
	{
		GameObject gameObject = new GameObject(MHNAJNGGDFJ.name);
		gameObject.layer = base.gameObject.layer;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = Quaternion.identity;
		gameObject.transform.localScale = Vector3.one;
		if (this.sourceRenderer is MeshRenderer)
		{
			gameObject.AddComponent<MeshFilter>().sharedMesh = this.FLOCCNCBNJG;
			MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
			meshRenderer.sharedMaterial = MHNAJNGGDFJ;
			meshRenderer.shadowCastingMode = ShadowCastingMode.On;
			meshRenderer.receiveShadows = false;
			return;
		}
		SkinnedMeshRenderer skinnedMeshRenderer = gameObject.AddComponent<SkinnedMeshRenderer>();
		skinnedMeshRenderer.rootBone = (this.sourceRenderer as SkinnedMeshRenderer).rootBone;
		skinnedMeshRenderer.bones = (this.sourceRenderer as SkinnedMeshRenderer).bones;
		skinnedMeshRenderer.sharedMaterial = MHNAJNGGDFJ;
		skinnedMeshRenderer.sharedMesh = this.FLOCCNCBNJG;
	}

	// Token: 0x060011B0 RID: 4528 RVA: 0x000A4980 File Offset: 0x000A2B80
	private void MOLEDJIMIMB()
	{
		Vector3[] vertices = this.MIBMNNICMFI.vertices;
		Vector2[] uv = this.MIBMNNICMFI.uv;
		Color[] colors = this.MIBMNNICMFI.colors;
		int[] triangles = this.MIBMNNICMFI.triangles;
		this.OKBIGLKEGFO = new int[triangles.Length];
		this.DLLNKLBMACP = new HairRenderer.EDOELDMALJC(vertices, uv, colors, triangles, this.sourceRenderer.transform, this.headSpheres);
		this.DLLNKLBMACP.EMEGAFLNBPG();
		this.DLLNKLBMACP.LILKJCPLBED(Vector3.zero, this.OKBIGLKEGFO, 957f);
		this.FLOCCNCBNJG = new Mesh();
		this.FLOCCNCBNJG.vertices = vertices;
		this.FLOCCNCBNJG.uv = uv;
		this.FLOCCNCBNJG.normals = this.MIBMNNICMFI.normals;
		this.FLOCCNCBNJG.tangents = this.MIBMNNICMFI.tangents;
		this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
		this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
		this.FLOCCNCBNJG.bindposes = this.MIBMNNICMFI.bindposes;
		this.FLOCCNCBNJG.boneWeights = this.MIBMNNICMFI.boneWeights;
		this.MIBMNNICMFI.RecalculateBounds();
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x000A4AC0 File Offset: 0x000A2CC0
	private void HEJKABCDMEP()
	{
		if (this.MIBMNNICMFI)
		{
			this.sortDistanceScale = Mathf.Clamp01(this.sortDistanceScale);
			this.opaqueAlphaRef = Mathf.Clamp(this.opaqueAlphaRef, 71f, 294f);
			this.frontAlphaRef = Mathf.Clamp(this.frontAlphaRef, 1021f, 608f);
			this.HBMHJIAMNCE();
			this.ADMBIPOKBPG();
			this.CNPPBJDKBAD();
		}
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x000A4B34 File Offset: 0x000A2D34
	private void LCOMHGNCFAN(Material MHNAJNGGDFJ)
	{
		GameObject gameObject = new GameObject(MHNAJNGGDFJ.name);
		gameObject.layer = base.gameObject.layer;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = Quaternion.identity;
		gameObject.transform.localScale = Vector3.one;
		if (this.sourceRenderer is MeshRenderer)
		{
			gameObject.AddComponent<MeshFilter>().sharedMesh = this.FLOCCNCBNJG;
			MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
			meshRenderer.sharedMaterial = MHNAJNGGDFJ;
			meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			meshRenderer.receiveShadows = true;
			return;
		}
		SkinnedMeshRenderer skinnedMeshRenderer = gameObject.AddComponent<SkinnedMeshRenderer>();
		skinnedMeshRenderer.rootBone = (this.sourceRenderer as SkinnedMeshRenderer).rootBone;
		skinnedMeshRenderer.bones = (this.sourceRenderer as SkinnedMeshRenderer).bones;
		skinnedMeshRenderer.sharedMaterial = MHNAJNGGDFJ;
		skinnedMeshRenderer.sharedMesh = this.FLOCCNCBNJG;
	}

	// Token: 0x060011B3 RID: 4531 RVA: 0x000A4C1C File Offset: 0x000A2E1C
	private void OnValidate()
	{
		if (this.MIBMNNICMFI)
		{
			this.sortDistanceScale = Mathf.Clamp01(this.sortDistanceScale);
			this.opaqueAlphaRef = Mathf.Clamp(this.opaqueAlphaRef, 0f, 1.001f);
			this.frontAlphaRef = Mathf.Clamp(this.frontAlphaRef, 0f, 1.001f);
			this.PPBOPPGLBPJ();
			this.FOJCADBMKEO();
			this.HGMLFOBLBPK();
		}
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x000A4C90 File Offset: 0x000A2E90
	private void ICMKMMIOFLE()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = false;
		if (this.useOpaquePass)
		{
			this.LCOMHGNCFAN(this.NOLNGKPBCBK);
		}
		this.CMAIGNKNGPF(this.IBMDJJNABFO);
		this.LCOMHGNCFAN(this.FHGBCJCMLIG);
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x000A4D24 File Offset: 0x000A2F24
	private void LPDIHACCGKK()
	{
		this.debugMode = HairRenderer.OJPNDKLAOEA.DBG_HAIR_NONE;
		base.gameObject.layer = this.sourceRenderer.gameObject.layer;
		if (this.sourceRenderer is MeshRenderer)
		{
			this.MIBMNNICMFI = ((MeshRenderer)this.sourceRenderer).GetComponent<MeshFilter>().sharedMesh;
		}
		else if (this.sourceRenderer is SkinnedMeshRenderer)
		{
			this.MIBMNNICMFI = ((SkinnedMeshRenderer)this.sourceRenderer).sharedMesh;
		}
		else
		{
			Debug.LogError("qd_refresh");
		}
		this.HNLIOPCJHKC();
		this.CIICPEIPKJD();
		this.HBMHJIAMNCE();
		this.DFHPNJBNLBE();
		this.MPOPHAJEDOH();
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x000A4DCC File Offset: 0x000A2FCC
	private void LPHDFMOHHJD()
	{
		if (this.MIBMNNICMFI)
		{
			this.sortDistanceScale = Mathf.Clamp01(this.sortDistanceScale);
			this.opaqueAlphaRef = Mathf.Clamp(this.opaqueAlphaRef, 1782f, 450f);
			this.frontAlphaRef = Mathf.Clamp(this.frontAlphaRef, 1874f, 365f);
			this.MHKLKGAALLD();
			this.FOJCADBMKEO();
			this.PCGJOHEGBAG();
		}
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x000A4E40 File Offset: 0x000A3040
	private void POMLHOHFIGA()
	{
		if (Camera.current == null || this.mode != (HairRenderer.FAIGCPHMEKF)7)
		{
			return;
		}
		Vector3 position = Camera.current.transform.position;
		Vector3 direction = this.headShell.transform.position - position;
		Ray ray = new Ray(position, direction);
		RaycastHit raycastHit;
		if (this.headShell.GetComponent<SphereCollider>().Raycast(ray, out raycastHit, direction.magnitude))
		{
			this.DLLNKLBMACP.HEKKAEGGOBK(base.transform.InverseTransformPoint(raycastHit.point), this.OKBIGLKEGFO, this.sortDistanceScale);
			Debug.DrawLine(position, raycastHit.point, Color.red, 376f);
			this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
			this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
			return;
		}
		Debug.LogWarning("_DistanceParams");
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x000A4F24 File Offset: 0x000A3124
	private void OBBKIFHEJBN(Material MHNAJNGGDFJ)
	{
		GameObject gameObject = new GameObject(MHNAJNGGDFJ.name);
		gameObject.layer = base.gameObject.layer;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = Quaternion.identity;
		gameObject.transform.localScale = Vector3.one;
		if (this.sourceRenderer is MeshRenderer)
		{
			gameObject.AddComponent<MeshFilter>().sharedMesh = this.FLOCCNCBNJG;
			MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
			meshRenderer.sharedMaterial = MHNAJNGGDFJ;
			meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			meshRenderer.receiveShadows = false;
			return;
		}
		SkinnedMeshRenderer skinnedMeshRenderer = gameObject.AddComponent<SkinnedMeshRenderer>();
		skinnedMeshRenderer.rootBone = (this.sourceRenderer as SkinnedMeshRenderer).rootBone;
		skinnedMeshRenderer.bones = (this.sourceRenderer as SkinnedMeshRenderer).bones;
		skinnedMeshRenderer.sharedMaterial = MHNAJNGGDFJ;
		skinnedMeshRenderer.sharedMesh = this.FLOCCNCBNJG;
	}

	// Token: 0x060011B9 RID: 4537 RVA: 0x000A500C File Offset: 0x000A320C
	private void CCPOIOJPKIF()
	{
		this.debugMode = HairRenderer.OJPNDKLAOEA.DBG_HAIR_NONE;
		base.gameObject.layer = this.sourceRenderer.gameObject.layer;
		if (this.sourceRenderer is MeshRenderer)
		{
			this.MIBMNNICMFI = ((MeshRenderer)this.sourceRenderer).GetComponent<MeshFilter>().sharedMesh;
		}
		else if (this.sourceRenderer is SkinnedMeshRenderer)
		{
			this.MIBMNNICMFI = ((SkinnedMeshRenderer)this.sourceRenderer).sharedMesh;
		}
		else
		{
			Debug.LogError("SoccerKick");
		}
		this.KOHFBOGBGLF();
		this.OJJPOHFGPPM();
		this.PPBOPPGLBPJ();
		this.ADMBIPOKBPG();
		this.FJAKKJJGAFA();
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x000A50B4 File Offset: 0x000A32B4
	private void ONBJLCJMLJH()
	{
		this.debugMode = HairRenderer.OJPNDKLAOEA.DBG_HAIR_OCCLUSION;
		base.gameObject.layer = this.sourceRenderer.gameObject.layer;
		if (this.sourceRenderer is MeshRenderer)
		{
			this.MIBMNNICMFI = ((MeshRenderer)this.sourceRenderer).GetComponent<MeshFilter>().sharedMesh;
		}
		else if (this.sourceRenderer is SkinnedMeshRenderer)
		{
			this.MIBMNNICMFI = ((SkinnedMeshRenderer)this.sourceRenderer).sharedMesh;
		}
		else
		{
			Debug.LogError("post_23");
		}
		this.ADBKPACHALL();
		this.OJJPOHFGPPM();
		this.HBMHJIAMNCE();
		this.KAOIJBMCANJ();
		this.HIKFMGKLPOA();
	}

	// Token: 0x060011BB RID: 4539 RVA: 0x000A515C File Offset: 0x000A335C
	private void JGKDNHLKBEN()
	{
		this.debugMode = HairRenderer.OJPNDKLAOEA.DBG_HAIR_OCCLUSION;
		base.gameObject.layer = this.sourceRenderer.gameObject.layer;
		if (this.sourceRenderer is MeshRenderer)
		{
			this.MIBMNNICMFI = ((MeshRenderer)this.sourceRenderer).GetComponent<MeshFilter>().sharedMesh;
		}
		else if (this.sourceRenderer is SkinnedMeshRenderer)
		{
			this.MIBMNNICMFI = ((SkinnedMeshRenderer)this.sourceRenderer).sharedMesh;
		}
		else
		{
			Debug.LogError("SoccerKeeperDiveStrafeCloseLeft");
		}
		this.EPEBKDCFKDC();
		this.DGHJJKMANCF();
		this.MHKLKGAALLD();
		this.FOJCADBMKEO();
		this.FJAKKJJGAFA();
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x000A5204 File Offset: 0x000A3404
	private void HBMHJIAMNCE()
	{
		this.NOLNGKPBCBK.SetFloat("StormStrike", this.opaqueAlphaRef);
		this.FHGBCJCMLIG.SetInt("FOG_EXP2", this.frontWriteDepth ? 0 : 1);
		this.FHGBCJCMLIG.SetFloat("DISTANCE_CUTOFF_OFF", this.frontAlphaRef);
		if (this.frontAlphaRef > 253f)
		{
			this.FHGBCJCMLIG.EnableKeyword("_FogData2");
			return;
		}
		this.FHGBCJCMLIG.DisableKeyword("");
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x000A5288 File Offset: 0x000A3488
	private void KIIFHALCGED()
	{
		Material sharedMaterial = this.sourceRenderer.sharedMaterial;
		this.NOLNGKPBCBK = new Material(sharedMaterial);
		this.NOLNGKPBCBK.name = sharedMaterial.name + "ClimbIdle";
		this.NOLNGKPBCBK.renderQueue = -123;
		this.NOLNGKPBCBK.shaderKeywords = sharedMaterial.shaderKeywords;
		this.NOLNGKPBCBK.DisableKeyword("FBIKBendGoal is deprecated, you can now a bend goal from the custom inspector of the FullBodyBipedIK component.");
		this.NOLNGKPBCBK.EnableKeyword("WeaponStrafeRunRight");
		this.NOLNGKPBCBK.SetInt("error", 1);
		this.NOLNGKPBCBK.SetInt("ClimbRight", 8);
		this.NOLNGKPBCBK.SetInt("BAG", 0);
		this.IBMDJJNABFO = new Material(sharedMaterial);
		this.IBMDJJNABFO.name = sharedMaterial.name + "MotorbikeTurnRight";
		this.IBMDJJNABFO.renderQueue = -94;
		this.IBMDJJNABFO.shaderKeywords = sharedMaterial.shaderKeywords;
		this.IBMDJJNABFO.EnableKeyword("Fly Right");
		this.IBMDJJNABFO.DisableKeyword("RunningDance");
		this.IBMDJJNABFO.SetInt("", 8);
		this.IBMDJJNABFO.SetInt("  ", 22);
		this.IBMDJJNABFO.SetInt("z", 0);
		this.IBMDJJNABFO.SetInt("wpn_rod1", 4);
		this.IBMDJJNABFO.SetInt("Flares", 1);
		this.FHGBCJCMLIG = new Material(sharedMaterial);
		this.FHGBCJCMLIG.name = sharedMaterial.name + "Zombie";
		this.FHGBCJCMLIG.renderQueue = 107;
		this.FHGBCJCMLIG.shaderKeywords = sharedMaterial.shaderKeywords;
		this.FHGBCJCMLIG.EnableKeyword("gameComplete");
		this.FHGBCJCMLIG.SetInt("DealerShuffle", 1);
		this.FHGBCJCMLIG.SetInt("", -28);
		this.FHGBCJCMLIG.SetInt("ldGo not found", 2);
		this.FHGBCJCMLIG.SetInt("OnChatMessage", 1);
	}

	// Token: 0x060011BE RID: 4542 RVA: 0x000A5498 File Offset: 0x000A3698
	private void ADBKPACHALL()
	{
		Vector3[] vertices = this.MIBMNNICMFI.vertices;
		Vector2[] uv = this.MIBMNNICMFI.uv;
		Color[] colors = this.MIBMNNICMFI.colors;
		int[] triangles = this.MIBMNNICMFI.triangles;
		this.OKBIGLKEGFO = new int[triangles.Length];
		this.DLLNKLBMACP = new HairRenderer.EDOELDMALJC(vertices, uv, colors, triangles, this.sourceRenderer.transform, this.headSpheres);
		this.DLLNKLBMACP.EMEGAFLNBPG();
		this.DLLNKLBMACP.GIJIMKFKGMI(Vector3.zero, this.OKBIGLKEGFO, 918f);
		this.FLOCCNCBNJG = new Mesh();
		this.FLOCCNCBNJG.vertices = vertices;
		this.FLOCCNCBNJG.uv = uv;
		this.FLOCCNCBNJG.normals = this.MIBMNNICMFI.normals;
		this.FLOCCNCBNJG.tangents = this.MIBMNNICMFI.tangents;
		this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
		this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
		this.FLOCCNCBNJG.bindposes = this.MIBMNNICMFI.bindposes;
		this.FLOCCNCBNJG.boneWeights = this.MIBMNNICMFI.boneWeights;
		this.MIBMNNICMFI.RecalculateBounds();
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x000A55D8 File Offset: 0x000A37D8
	private void LateUpdate()
	{
		if (Camera.current == null || this.mode != HairRenderer.FAIGCPHMEKF.DynamicRadialDistance)
		{
			return;
		}
		Vector3 position = Camera.current.transform.position;
		Vector3 direction = this.headShell.transform.position - position;
		Ray ray = new Ray(position, direction);
		RaycastHit raycastHit;
		if (this.headShell.GetComponent<SphereCollider>().Raycast(ray, out raycastHit, direction.magnitude))
		{
			this.DLLNKLBMACP.GIJIMKFKGMI(base.transform.InverseTransformPoint(raycastHit.point), this.OKBIGLKEGFO, this.sortDistanceScale);
			Debug.DrawLine(position, raycastHit.point, Color.red, 3f);
			this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
			this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
			return;
		}
		Debug.LogWarning("Failed to find head ray.. inside shell?");
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x000A56BC File Offset: 0x000A38BC
	private void JGGPMAKAKNG()
	{
		if (this.MIBMNNICMFI)
		{
			this.sortDistanceScale = Mathf.Clamp01(this.sortDistanceScale);
			this.opaqueAlphaRef = Mathf.Clamp(this.opaqueAlphaRef, 1300f, 37f);
			this.frontAlphaRef = Mathf.Clamp(this.frontAlphaRef, 88f, 1902f);
			this.MHKLKGAALLD();
			this.ADMBIPOKBPG();
			this.MPOPHAJEDOH();
		}
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x000A5730 File Offset: 0x000A3930
	private void DFHPNJBNLBE()
	{
		Material[] array = new Material[1];
		array[1] = this.NOLNGKPBCBK;
		array[1] = this.IBMDJJNABFO;
		array[7] = this.FHGBCJCMLIG;
		foreach (Material material in array)
		{
			foreach (string keyword in Enum.GetNames(typeof(HairRenderer.OJPNDKLAOEA)))
			{
				material.DisableKeyword(keyword);
			}
			material.EnableKeyword(this.debugMode.ToString());
		}
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x000A57B8 File Offset: 0x000A39B8
	private void NCOJPBKLANI()
	{
		if (Camera.current == null || this.mode != (HairRenderer.FAIGCPHMEKF)7)
		{
			return;
		}
		Vector3 position = Camera.current.transform.position;
		Vector3 direction = this.headShell.transform.position - position;
		Ray ray = new Ray(position, direction);
		RaycastHit raycastHit;
		if (this.headShell.GetComponent<SphereCollider>().Raycast(ray, out raycastHit, direction.magnitude))
		{
			this.DLLNKLBMACP.HEKKAEGGOBK(base.transform.InverseTransformPoint(raycastHit.point), this.OKBIGLKEGFO, this.sortDistanceScale);
			Debug.DrawLine(position, raycastHit.point, Color.red, 1832f);
			this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
			this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
			return;
		}
		Debug.LogWarning(" ");
	}

	// Token: 0x060011C3 RID: 4547 RVA: 0x000A589C File Offset: 0x000A3A9C
	private void DGHJJKMANCF()
	{
		Material sharedMaterial = this.sourceRenderer.sharedMaterial;
		this.NOLNGKPBCBK = new Material(sharedMaterial);
		this.NOLNGKPBCBK.name = sharedMaterial.name + "UnityEngine.Vector4";
		this.NOLNGKPBCBK.renderQueue = -85;
		this.NOLNGKPBCBK.shaderKeywords = sharedMaterial.shaderKeywords;
		this.NOLNGKPBCBK.DisableKeyword("Vertical");
		this.NOLNGKPBCBK.EnableKeyword(" for vert ");
		this.NOLNGKPBCBK.SetInt("wpn_cat1", 0);
		this.NOLNGKPBCBK.SetInt("qd_prise_exp", 3);
		this.NOLNGKPBCBK.SetInt("pf1m", 0);
		this.IBMDJJNABFO = new Material(sharedMaterial);
		this.IBMDJJNABFO.name = sharedMaterial.name + "IdleButtonPress";
		this.IBMDJJNABFO.renderQueue = 48;
		this.IBMDJJNABFO.shaderKeywords = sharedMaterial.shaderKeywords;
		this.IBMDJJNABFO.EnableKeyword("IceHockeyGoalieSave1");
		this.IBMDJJNABFO.DisableKeyword("IdleRun");
		this.IBMDJJNABFO.SetInt("GiantGrabIdle2", 0);
		this.IBMDJJNABFO.SetInt("CrouchStrafeLeft", -95);
		this.IBMDJJNABFO.SetInt("_CurveTex", 1);
		this.IBMDJJNABFO.SetInt("gi_uinf_11", 0);
		this.IBMDJJNABFO.SetInt("int\nfloat\nstring\n<color=\"#75C4EB\">uint\ndouble\ndecimal\nlong\nulong\nbool\nbyte[]\nVector2\nVector3\nQuaternion\nColor\nRect</color>", 1);
		this.FHGBCJCMLIG = new Material(sharedMaterial);
		this.FHGBCJCMLIG.name = sharedMaterial.name + "COLOR_GRADING_LOG_VIEW";
		this.FHGBCJCMLIG.renderQueue = 131;
		this.FHGBCJCMLIG.shaderKeywords = sharedMaterial.shaderKeywords;
		this.FHGBCJCMLIG.EnableKeyword("/");
		this.FHGBCJCMLIG.SetInt("isFishOnRod", 1);
		this.FHGBCJCMLIG.SetInt("ShootWireframeModule", 117);
		this.FHGBCJCMLIG.SetInt("Sitting Mouse Movement", 0);
		this.FHGBCJCMLIG.SetInt("WeaponInstant", 2);
	}

	// Token: 0x060011C5 RID: 4549 RVA: 0x000A5AD8 File Offset: 0x000A3CD8
	private void GGKKFCMGJKK(Material MHNAJNGGDFJ)
	{
		GameObject gameObject = new GameObject(MHNAJNGGDFJ.name);
		gameObject.layer = base.gameObject.layer;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = Quaternion.identity;
		gameObject.transform.localScale = Vector3.one;
		if (this.sourceRenderer is MeshRenderer)
		{
			gameObject.AddComponent<MeshFilter>().sharedMesh = this.FLOCCNCBNJG;
			MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
			meshRenderer.sharedMaterial = MHNAJNGGDFJ;
			meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			meshRenderer.receiveShadows = false;
			return;
		}
		SkinnedMeshRenderer skinnedMeshRenderer = gameObject.AddComponent<SkinnedMeshRenderer>();
		skinnedMeshRenderer.rootBone = (this.sourceRenderer as SkinnedMeshRenderer).rootBone;
		skinnedMeshRenderer.bones = (this.sourceRenderer as SkinnedMeshRenderer).bones;
		skinnedMeshRenderer.sharedMaterial = MHNAJNGGDFJ;
		skinnedMeshRenderer.sharedMesh = this.FLOCCNCBNJG;
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x000A5BC0 File Offset: 0x000A3DC0
	private void CBBIADNKMLI()
	{
		this.debugMode = HairRenderer.OJPNDKLAOEA.DBG_HAIR_NONE;
		base.gameObject.layer = this.sourceRenderer.gameObject.layer;
		if (this.sourceRenderer is MeshRenderer)
		{
			this.MIBMNNICMFI = ((MeshRenderer)this.sourceRenderer).GetComponent<MeshFilter>().sharedMesh;
		}
		else if (this.sourceRenderer is SkinnedMeshRenderer)
		{
			this.MIBMNNICMFI = ((SkinnedMeshRenderer)this.sourceRenderer).sharedMesh;
		}
		else
		{
			Debug.LogError("quests/achivments_name/qd");
		}
		this.JEFNIHLFMEE();
		this.OKDFPJBHPAM();
		this.PPBOPPGLBPJ();
		this.FOJCADBMKEO();
		this.EGFLAGIOJLO();
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x000A5C68 File Offset: 0x000A3E68
	private void EPEBKDCFKDC()
	{
		Vector3[] vertices = this.MIBMNNICMFI.vertices;
		Vector2[] uv = this.MIBMNNICMFI.uv;
		Color[] colors = this.MIBMNNICMFI.colors;
		int[] triangles = this.MIBMNNICMFI.triangles;
		this.OKBIGLKEGFO = new int[triangles.Length];
		this.DLLNKLBMACP = new HairRenderer.EDOELDMALJC(vertices, uv, colors, triangles, this.sourceRenderer.transform, this.headSpheres);
		this.DLLNKLBMACP.KBKHCAIKPAP();
		this.DLLNKLBMACP.LFJECDOPICN(Vector3.zero, this.OKBIGLKEGFO, 190f);
		this.FLOCCNCBNJG = new Mesh();
		this.FLOCCNCBNJG.vertices = vertices;
		this.FLOCCNCBNJG.uv = uv;
		this.FLOCCNCBNJG.normals = this.MIBMNNICMFI.normals;
		this.FLOCCNCBNJG.tangents = this.MIBMNNICMFI.tangents;
		this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
		this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
		this.FLOCCNCBNJG.bindposes = this.MIBMNNICMFI.bindposes;
		this.FLOCCNCBNJG.boneWeights = this.MIBMNNICMFI.boneWeights;
		this.MIBMNNICMFI.RecalculateBounds();
	}

	// Token: 0x060011C8 RID: 4552 RVA: 0x000A5DA8 File Offset: 0x000A3FA8
	private void FNMFECJCGBP()
	{
		Material sharedMaterial = this.sourceRenderer.sharedMaterial;
		this.NOLNGKPBCBK = new Material(sharedMaterial);
		this.NOLNGKPBCBK.name = sharedMaterial.name + " (hair opaque)";
		this.NOLNGKPBCBK.renderQueue = 2450;
		this.NOLNGKPBCBK.shaderKeywords = sharedMaterial.shaderKeywords;
		this.NOLNGKPBCBK.DisableKeyword("_ALPHABLEND_ON");
		this.NOLNGKPBCBK.EnableKeyword("_ALPHATEST_ON");
		this.NOLNGKPBCBK.SetInt("_ZWrite", 1);
		this.NOLNGKPBCBK.SetInt("_ZTest", 4);
		this.NOLNGKPBCBK.SetInt("_Cull", 0);
		this.IBMDJJNABFO = new Material(sharedMaterial);
		this.IBMDJJNABFO.name = sharedMaterial.name + " (hair back)";
		this.IBMDJJNABFO.renderQueue = 2501;
		this.IBMDJJNABFO.shaderKeywords = sharedMaterial.shaderKeywords;
		this.IBMDJJNABFO.EnableKeyword("_ALPHABLEND_ON");
		this.IBMDJJNABFO.DisableKeyword("_ALPHATEST_ON");
		this.IBMDJJNABFO.SetInt("_SrcBlend", 5);
		this.IBMDJJNABFO.SetInt("_DstBlend", 10);
		this.IBMDJJNABFO.SetInt("_ZWrite", 0);
		this.IBMDJJNABFO.SetInt("_ZTest", 2);
		this.IBMDJJNABFO.SetInt("_Cull", 1);
		this.FHGBCJCMLIG = new Material(sharedMaterial);
		this.FHGBCJCMLIG.name = sharedMaterial.name + " (hair front)";
		this.FHGBCJCMLIG.renderQueue = 2502;
		this.FHGBCJCMLIG.shaderKeywords = sharedMaterial.shaderKeywords;
		this.FHGBCJCMLIG.EnableKeyword("_ALPHABLEND_ON");
		this.FHGBCJCMLIG.SetInt("_SrcBlend", 5);
		this.FHGBCJCMLIG.SetInt("_DstBlend", 10);
		this.FHGBCJCMLIG.SetInt("_ZTest", 2);
		this.FHGBCJCMLIG.SetInt("_Cull", 2);
	}

	// Token: 0x060011C9 RID: 4553 RVA: 0x000A5FB8 File Offset: 0x000A41B8
	private void BOEFHGKGJMN()
	{
		if (Camera.current == null || this.mode != (HairRenderer.FAIGCPHMEKF)3)
		{
			return;
		}
		Vector3 position = Camera.current.transform.position;
		Vector3 direction = this.headShell.transform.position - position;
		Ray ray = new Ray(position, direction);
		RaycastHit raycastHit;
		if (this.headShell.GetComponent<SphereCollider>().Raycast(ray, out raycastHit, direction.magnitude))
		{
			this.DLLNKLBMACP.GIJIMKFKGMI(base.transform.InverseTransformPoint(raycastHit.point), this.OKBIGLKEGFO, this.sortDistanceScale);
			Debug.DrawLine(position, raycastHit.point, Color.red, 333f);
			this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
			this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
			return;
		}
		Debug.LogWarning("1/");
	}

	// Token: 0x060011CA RID: 4554 RVA: 0x000A609C File Offset: 0x000A429C
	private void JEFNIHLFMEE()
	{
		Vector3[] vertices = this.MIBMNNICMFI.vertices;
		Vector2[] uv = this.MIBMNNICMFI.uv;
		Color[] colors = this.MIBMNNICMFI.colors;
		int[] triangles = this.MIBMNNICMFI.triangles;
		this.OKBIGLKEGFO = new int[triangles.Length];
		this.DLLNKLBMACP = new HairRenderer.EDOELDMALJC(vertices, uv, colors, triangles, this.sourceRenderer.transform, this.headSpheres);
		this.DLLNKLBMACP.KBKHCAIKPAP();
		this.DLLNKLBMACP.HEKKAEGGOBK(Vector3.zero, this.OKBIGLKEGFO, 573f);
		this.FLOCCNCBNJG = new Mesh();
		this.FLOCCNCBNJG.vertices = vertices;
		this.FLOCCNCBNJG.uv = uv;
		this.FLOCCNCBNJG.normals = this.MIBMNNICMFI.normals;
		this.FLOCCNCBNJG.tangents = this.MIBMNNICMFI.tangents;
		this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
		this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
		this.FLOCCNCBNJG.bindposes = this.MIBMNNICMFI.bindposes;
		this.FLOCCNCBNJG.boneWeights = this.MIBMNNICMFI.boneWeights;
		this.MIBMNNICMFI.RecalculateBounds();
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x000A61DC File Offset: 0x000A43DC
	private void FKBACPBNDGA()
	{
		if (this.MIBMNNICMFI)
		{
			this.sortDistanceScale = Mathf.Clamp01(this.sortDistanceScale);
			this.opaqueAlphaRef = Mathf.Clamp(this.opaqueAlphaRef, 337f, 1728f);
			this.frontAlphaRef = Mathf.Clamp(this.frontAlphaRef, 184f, 1840f);
			this.PPBOPPGLBPJ();
			this.FOJCADBMKEO();
			this.HGMLFOBLBPK();
		}
	}

	// Token: 0x060011CC RID: 4556 RVA: 0x000A6250 File Offset: 0x000A4450
	private void MHKLKGAALLD()
	{
		this.NOLNGKPBCBK.SetFloat("Original lives count: ", this.opaqueAlphaRef);
		this.FHGBCJCMLIG.SetInt("Shoot Forward", this.frontWriteDepth ? 1 : 0);
		this.FHGBCJCMLIG.SetFloat("_HitTime", this.frontAlphaRef);
		if (this.frontAlphaRef > 564f)
		{
			this.FHGBCJCMLIG.EnableKeyword("</color>");
			return;
		}
		this.FHGBCJCMLIG.DisableKeyword(". Check the Maintenance window for your VPaint Group for more info.");
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x000A62D4 File Offset: 0x000A44D4
	private void DNCKAMMLGGL()
	{
		Vector3[] vertices = this.MIBMNNICMFI.vertices;
		Vector2[] uv = this.MIBMNNICMFI.uv;
		Color[] colors = this.MIBMNNICMFI.colors;
		int[] triangles = this.MIBMNNICMFI.triangles;
		this.OKBIGLKEGFO = new int[triangles.Length];
		this.DLLNKLBMACP = new HairRenderer.EDOELDMALJC(vertices, uv, colors, triangles, this.sourceRenderer.transform, this.headSpheres);
		this.DLLNKLBMACP.PGGABIEPALL();
		this.DLLNKLBMACP.GIJIMKFKGMI(Vector3.zero, this.OKBIGLKEGFO, 1598f);
		this.FLOCCNCBNJG = new Mesh();
		this.FLOCCNCBNJG.vertices = vertices;
		this.FLOCCNCBNJG.uv = uv;
		this.FLOCCNCBNJG.normals = this.MIBMNNICMFI.normals;
		this.FLOCCNCBNJG.tangents = this.MIBMNNICMFI.tangents;
		this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
		this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
		this.FLOCCNCBNJG.bindposes = this.MIBMNNICMFI.bindposes;
		this.FLOCCNCBNJG.boneWeights = this.MIBMNNICMFI.boneWeights;
		this.MIBMNNICMFI.RecalculateBounds();
	}

	// Token: 0x060011CE RID: 4558 RVA: 0x000A6414 File Offset: 0x000A4614
	private void JAALJMPLMMB(Material MHNAJNGGDFJ)
	{
		GameObject gameObject = new GameObject(MHNAJNGGDFJ.name);
		gameObject.layer = base.gameObject.layer;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = Quaternion.identity;
		gameObject.transform.localScale = Vector3.one;
		if (this.sourceRenderer is MeshRenderer)
		{
			gameObject.AddComponent<MeshFilter>().sharedMesh = this.FLOCCNCBNJG;
			MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
			meshRenderer.sharedMaterial = MHNAJNGGDFJ;
			meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			meshRenderer.receiveShadows = false;
			return;
		}
		SkinnedMeshRenderer skinnedMeshRenderer = gameObject.AddComponent<SkinnedMeshRenderer>();
		skinnedMeshRenderer.rootBone = (this.sourceRenderer as SkinnedMeshRenderer).rootBone;
		skinnedMeshRenderer.bones = (this.sourceRenderer as SkinnedMeshRenderer).bones;
		skinnedMeshRenderer.sharedMaterial = MHNAJNGGDFJ;
		skinnedMeshRenderer.sharedMesh = this.FLOCCNCBNJG;
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x000A64FC File Offset: 0x000A46FC
	private void HIKFMGKLPOA()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = false;
		if (this.useOpaquePass)
		{
			this.HJPOHNDCOLF(this.NOLNGKPBCBK);
		}
		this.JAALJMPLMMB(this.IBMDJJNABFO);
		this.LCOMHGNCFAN(this.FHGBCJCMLIG);
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x000A6590 File Offset: 0x000A4790
	private void ADMBIPOKBPG()
	{
		Material[] array = new Material[0];
		array[1] = this.NOLNGKPBCBK;
		array[1] = this.IBMDJJNABFO;
		array[2] = this.FHGBCJCMLIG;
		Material[] array2 = array;
		for (int i = 0; i < array2.Length; i += 0)
		{
			Material material = array2[i];
			string[] names = Enum.GetNames(typeof(HairRenderer.OJPNDKLAOEA));
			for (int j = 1; j < names.Length; j += 0)
			{
				string keyword = names[j];
				material.DisableKeyword(keyword);
			}
			material.EnableKeyword(this.debugMode.ToString());
		}
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x000A6618 File Offset: 0x000A4818
	private void PPIOABJAEGA()
	{
		Vector3[] vertices = this.MIBMNNICMFI.vertices;
		Vector2[] uv = this.MIBMNNICMFI.uv;
		Color[] colors = this.MIBMNNICMFI.colors;
		int[] triangles = this.MIBMNNICMFI.triangles;
		this.OKBIGLKEGFO = new int[triangles.Length];
		this.DLLNKLBMACP = new HairRenderer.EDOELDMALJC(vertices, uv, colors, triangles, this.sourceRenderer.transform, this.headSpheres);
		this.DLLNKLBMACP.KBKHCAIKPAP();
		this.DLLNKLBMACP.IFBKJPHIJGP(Vector3.zero, this.OKBIGLKEGFO, 1865f);
		this.FLOCCNCBNJG = new Mesh();
		this.FLOCCNCBNJG.vertices = vertices;
		this.FLOCCNCBNJG.uv = uv;
		this.FLOCCNCBNJG.normals = this.MIBMNNICMFI.normals;
		this.FLOCCNCBNJG.tangents = this.MIBMNNICMFI.tangents;
		this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
		this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
		this.FLOCCNCBNJG.bindposes = this.MIBMNNICMFI.bindposes;
		this.FLOCCNCBNJG.boneWeights = this.MIBMNNICMFI.boneWeights;
		this.MIBMNNICMFI.RecalculateBounds();
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x000A6758 File Offset: 0x000A4958
	private void KAOIJBMCANJ()
	{
		Material[] array = new Material[4];
		array[0] = this.NOLNGKPBCBK;
		array[1] = this.IBMDJJNABFO;
		array[1] = this.FHGBCJCMLIG;
		foreach (Material material in array)
		{
			string[] names = Enum.GetNames(typeof(HairRenderer.OJPNDKLAOEA));
			for (int j = 1; j < names.Length; j += 0)
			{
				string keyword = names[j];
				material.DisableKeyword(keyword);
			}
			material.EnableKeyword(this.debugMode.ToString());
		}
	}

	// Token: 0x060011D3 RID: 4563 RVA: 0x000A67E0 File Offset: 0x000A49E0
	private void HGBCHNMDFNK()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = true;
		if (this.useOpaquePass)
		{
			this.CMAIGNKNGPF(this.NOLNGKPBCBK);
		}
		this.CMAIGNKNGPF(this.IBMDJJNABFO);
		this.LCOMHGNCFAN(this.FHGBCJCMLIG);
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x000A6874 File Offset: 0x000A4A74
	private void LFOEELGABIN()
	{
		if (this.MIBMNNICMFI)
		{
			this.sortDistanceScale = Mathf.Clamp01(this.sortDistanceScale);
			this.opaqueAlphaRef = Mathf.Clamp(this.opaqueAlphaRef, 457f, 1435f);
			this.frontAlphaRef = Mathf.Clamp(this.frontAlphaRef, 1827f, 363f);
			this.PPBOPPGLBPJ();
			this.KAOIJBMCANJ();
			this.HGMLFOBLBPK();
		}
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x000A68E8 File Offset: 0x000A4AE8
	private void MPOPHAJEDOH()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = false;
		if (this.useOpaquePass)
		{
			this.JAALJMPLMMB(this.NOLNGKPBCBK);
		}
		this.JAALJMPLMMB(this.IBMDJJNABFO);
		this.HJPOHNDCOLF(this.FHGBCJCMLIG);
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x000A697C File Offset: 0x000A4B7C
	private void CFNLKNOKAGC()
	{
		this.debugMode = HairRenderer.OJPNDKLAOEA.DBG_HAIR_NONE;
		base.gameObject.layer = this.sourceRenderer.gameObject.layer;
		if (this.sourceRenderer is MeshRenderer)
		{
			this.MIBMNNICMFI = ((MeshRenderer)this.sourceRenderer).GetComponent<MeshFilter>().sharedMesh;
		}
		else if (this.sourceRenderer is SkinnedMeshRenderer)
		{
			this.MIBMNNICMFI = ((SkinnedMeshRenderer)this.sourceRenderer).sharedMesh;
		}
		else
		{
			Debug.LogError(" %");
		}
		this.EPEBKDCFKDC();
		this.CIICPEIPKJD();
		this.HBMHJIAMNCE();
		this.KAOIJBMCANJ();
		this.ICMKMMIOFLE();
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x000A6A24 File Offset: 0x000A4C24
	private void JJOCLPAJAMA()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = true;
		if (this.useOpaquePass)
		{
			this.OBBKIFHEJBN(this.NOLNGKPBCBK);
		}
		this.OBBKIFHEJBN(this.IBMDJJNABFO);
		this.CMAIGNKNGPF(this.FHGBCJCMLIG);
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x000A6AB8 File Offset: 0x000A4CB8
	private void PJOOAJAAPFC()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = true;
		if (this.useOpaquePass)
		{
			this.CMAIGNKNGPF(this.NOLNGKPBCBK);
		}
		this.GGKKFCMGJKK(this.IBMDJJNABFO);
		this.OBBKIFHEJBN(this.FHGBCJCMLIG);
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x000A6B4C File Offset: 0x000A4D4C
	private void KOHFBOGBGLF()
	{
		Vector3[] vertices = this.MIBMNNICMFI.vertices;
		Vector2[] uv = this.MIBMNNICMFI.uv;
		Color[] colors = this.MIBMNNICMFI.colors;
		int[] triangles = this.MIBMNNICMFI.triangles;
		this.OKBIGLKEGFO = new int[triangles.Length];
		this.DLLNKLBMACP = new HairRenderer.EDOELDMALJC(vertices, uv, colors, triangles, this.sourceRenderer.transform, this.headSpheres);
		this.DLLNKLBMACP.EMEGAFLNBPG();
		this.DLLNKLBMACP.LFJECDOPICN(Vector3.zero, this.OKBIGLKEGFO, 124f);
		this.FLOCCNCBNJG = new Mesh();
		this.FLOCCNCBNJG.vertices = vertices;
		this.FLOCCNCBNJG.uv = uv;
		this.FLOCCNCBNJG.normals = this.MIBMNNICMFI.normals;
		this.FLOCCNCBNJG.tangents = this.MIBMNNICMFI.tangents;
		this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
		this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
		this.FLOCCNCBNJG.bindposes = this.MIBMNNICMFI.bindposes;
		this.FLOCCNCBNJG.boneWeights = this.MIBMNNICMFI.boneWeights;
		this.MIBMNNICMFI.RecalculateBounds();
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x000A6C8C File Offset: 0x000A4E8C
	private void MNNFJFLEODH()
	{
		Vector3[] vertices = this.MIBMNNICMFI.vertices;
		Vector2[] uv = this.MIBMNNICMFI.uv;
		Color[] colors = this.MIBMNNICMFI.colors;
		int[] triangles = this.MIBMNNICMFI.triangles;
		this.OKBIGLKEGFO = new int[triangles.Length];
		this.DLLNKLBMACP = new HairRenderer.EDOELDMALJC(vertices, uv, colors, triangles, this.sourceRenderer.transform, this.headSpheres);
		this.DLLNKLBMACP.KBKHCAIKPAP();
		this.DLLNKLBMACP.GIJIMKFKGMI(Vector3.zero, this.OKBIGLKEGFO, 0f);
		this.FLOCCNCBNJG = new Mesh();
		this.FLOCCNCBNJG.vertices = vertices;
		this.FLOCCNCBNJG.uv = uv;
		this.FLOCCNCBNJG.normals = this.MIBMNNICMFI.normals;
		this.FLOCCNCBNJG.tangents = this.MIBMNNICMFI.tangents;
		this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
		this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
		this.FLOCCNCBNJG.bindposes = this.MIBMNNICMFI.bindposes;
		this.FLOCCNCBNJG.boneWeights = this.MIBMNNICMFI.boneWeights;
		this.MIBMNNICMFI.RecalculateBounds();
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x000A6DCC File Offset: 0x000A4FCC
	private void HGMLFOBLBPK()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = false;
		if (this.useOpaquePass)
		{
			this.LCOMHGNCFAN(this.NOLNGKPBCBK);
		}
		this.LCOMHGNCFAN(this.IBMDJJNABFO);
		this.LCOMHGNCFAN(this.FHGBCJCMLIG);
	}

	// Token: 0x060011DC RID: 4572 RVA: 0x000A6E60 File Offset: 0x000A5060
	private void FOJCADBMKEO()
	{
		foreach (Material material in new Material[]
		{
			this.NOLNGKPBCBK,
			this.IBMDJJNABFO,
			this.FHGBCJCMLIG
		})
		{
			foreach (string keyword in Enum.GetNames(typeof(HairRenderer.OJPNDKLAOEA)))
			{
				material.DisableKeyword(keyword);
			}
			material.EnableKeyword(this.debugMode.ToString());
		}
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x000A6EE8 File Offset: 0x000A50E8
	private void PPBOPPGLBPJ()
	{
		this.NOLNGKPBCBK.SetFloat("_Cutoff", this.opaqueAlphaRef);
		this.FHGBCJCMLIG.SetInt("_ZWrite", this.frontWriteDepth ? 1 : 0);
		this.FHGBCJCMLIG.SetFloat("_Cutoff", this.frontAlphaRef);
		if (this.frontAlphaRef > 0f)
		{
			this.FHGBCJCMLIG.EnableKeyword("_ALPHATEST_ON");
			return;
		}
		this.FHGBCJCMLIG.DisableKeyword("_ALPHATEST_ON");
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x000A6F6C File Offset: 0x000A516C
	private void OJJPOHFGPPM()
	{
		Material sharedMaterial = this.sourceRenderer.sharedMaterial;
		this.NOLNGKPBCBK = new Material(sharedMaterial);
		this.NOLNGKPBCBK.name = sharedMaterial.name + "SPECIAL";
		this.NOLNGKPBCBK.renderQueue = -99;
		this.NOLNGKPBCBK.shaderKeywords = sharedMaterial.shaderKeywords;
		this.NOLNGKPBCBK.DisableKeyword("_Balance");
		this.NOLNGKPBCBK.EnableKeyword("'>");
		this.NOLNGKPBCBK.SetInt("\n", 1);
		this.NOLNGKPBCBK.SetInt("The 'font' command requires a font name parameter and an optional font size parameter.", 8);
		this.NOLNGKPBCBK.SetInt("dir", 0);
		this.IBMDJJNABFO = new Material(sharedMaterial);
		this.IBMDJJNABFO.name = sharedMaterial.name + "RollerBladeFrontFlip";
		this.IBMDJJNABFO.renderQueue = -41;
		this.IBMDJJNABFO.shaderKeywords = sharedMaterial.shaderKeywords;
		this.IBMDJJNABFO.EnableKeyword("file:///");
		this.IBMDJJNABFO.DisableKeyword("FlyForward");
		this.IBMDJJNABFO.SetInt("Crawl Idle", 1);
		this.IBMDJJNABFO.SetInt("KatanaReadyLow", 119);
		this.IBMDJJNABFO.SetInt(">", 0);
		this.IBMDJJNABFO.SetInt("id", 6);
		this.IBMDJJNABFO.SetInt("", 0);
		this.FHGBCJCMLIG = new Material(sharedMaterial);
		this.FHGBCJCMLIG.name = sharedMaterial.name + "Idle Meditate";
		this.FHGBCJCMLIG.renderQueue = 41;
		this.FHGBCJCMLIG.shaderKeywords = sharedMaterial.shaderKeywords;
		this.FHGBCJCMLIG.EnableKeyword("preservePlayerPrefs");
		this.FHGBCJCMLIG.SetInt("usercntinfo", 5);
		this.FHGBCJCMLIG.SetInt("1 Hand Sword Back Swing", -6);
		this.FHGBCJCMLIG.SetInt(" ms", 8);
		this.FHGBCJCMLIG.SetInt("[wtemplid]", 8);
	}

	// Token: 0x060011DF RID: 4575 RVA: 0x000A717C File Offset: 0x000A537C
	private void LBKPJAJJLBH()
	{
		this.debugMode = HairRenderer.OJPNDKLAOEA.DBG_HAIR_OCCLUSION;
		base.gameObject.layer = this.sourceRenderer.gameObject.layer;
		if (this.sourceRenderer is MeshRenderer)
		{
			this.MIBMNNICMFI = ((MeshRenderer)this.sourceRenderer).GetComponent<MeshFilter>().sharedMesh;
		}
		else if (this.sourceRenderer is SkinnedMeshRenderer)
		{
			this.MIBMNNICMFI = ((SkinnedMeshRenderer)this.sourceRenderer).sharedMesh;
		}
		else
		{
			Debug.LogError("cellid");
		}
		this.JEFNIHLFMEE();
		this.FNMFECJCGBP();
		this.HBMHJIAMNCE();
		this.FOJCADBMKEO();
		this.CNPPBJDKBAD();
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x000A7224 File Offset: 0x000A5424
	private void EGFLAGIOJLO()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = false;
		if (this.useOpaquePass)
		{
			this.LCOMHGNCFAN(this.NOLNGKPBCBK);
		}
		this.JAALJMPLMMB(this.IBMDJJNABFO);
		this.LCOMHGNCFAN(this.FHGBCJCMLIG);
	}

	// Token: 0x060011E1 RID: 4577 RVA: 0x000A72B8 File Offset: 0x000A54B8
	private void CIICPEIPKJD()
	{
		Material sharedMaterial = this.sourceRenderer.sharedMaterial;
		this.NOLNGKPBCBK = new Material(sharedMaterial);
		this.NOLNGKPBCBK.name = sharedMaterial.name + "22";
		this.NOLNGKPBCBK.renderQueue = 61;
		this.NOLNGKPBCBK.shaderKeywords = sharedMaterial.shaderKeywords;
		this.NOLNGKPBCBK.DisableKeyword(" ");
		this.NOLNGKPBCBK.EnableKeyword("DataSize ");
		this.NOLNGKPBCBK.SetInt("IdleMouthWipe", 0);
		this.NOLNGKPBCBK.SetInt("PistolReload", 8);
		this.NOLNGKPBCBK.SetInt("NEW FISH!", 1);
		this.IBMDJJNABFO = new Material(sharedMaterial);
		this.IBMDJJNABFO.name = sharedMaterial.name + "FishbragContainer";
		this.IBMDJJNABFO.renderQueue = -146;
		this.IBMDJJNABFO.shaderKeywords = sharedMaterial.shaderKeywords;
		this.IBMDJJNABFO.EnableKeyword("WoodSaw");
		this.IBMDJJNABFO.DisableKeyword("IdleStun");
		this.IBMDJJNABFO.SetInt("Reach Cone {point ", 1);
		this.IBMDJJNABFO.SetInt("SUNSHINE_DISABLED", 111);
		this.IBMDJJNABFO.SetInt("IK", 0);
		this.IBMDJJNABFO.SetInt("{0}\n{1}", 2);
		this.IBMDJJNABFO.SetInt("RendererD2 is init", 0);
		this.FHGBCJCMLIG = new Material(sharedMaterial);
		this.FHGBCJCMLIG.name = sharedMaterial.name + "WalkBackward";
		this.FHGBCJCMLIG.renderQueue = -104;
		this.FHGBCJCMLIG.shaderKeywords = sharedMaterial.shaderKeywords;
		this.FHGBCJCMLIG.EnableKeyword("_Intensity");
		this.FHGBCJCMLIG.SetInt("OfficeSitting1LegStraight", 1);
		this.FHGBCJCMLIG.SetInt("GOSound2D", -99);
		this.FHGBCJCMLIG.SetInt("CrawlLocomotion", 1);
		this.FHGBCJCMLIG.SetInt("Images/MouseCursor/Arrow", 2);
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x000A74C8 File Offset: 0x000A56C8
	private void Awake()
	{
		this.debugMode = HairRenderer.OJPNDKLAOEA.DBG_HAIR_NONE;
		base.gameObject.layer = this.sourceRenderer.gameObject.layer;
		if (this.sourceRenderer is MeshRenderer)
		{
			this.MIBMNNICMFI = ((MeshRenderer)this.sourceRenderer).GetComponent<MeshFilter>().sharedMesh;
		}
		else if (this.sourceRenderer is SkinnedMeshRenderer)
		{
			this.MIBMNNICMFI = ((SkinnedMeshRenderer)this.sourceRenderer).sharedMesh;
		}
		else
		{
			Debug.LogError("Invalid source renderer type");
		}
		this.MNNFJFLEODH();
		this.FNMFECJCGBP();
		this.PPBOPPGLBPJ();
		this.FOJCADBMKEO();
		this.HGMLFOBLBPK();
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x000A7570 File Offset: 0x000A5770
	private void JIIBCGJJLND()
	{
		this.debugMode = HairRenderer.OJPNDKLAOEA.DBG_HAIR_NONE;
		base.gameObject.layer = this.sourceRenderer.gameObject.layer;
		if (this.sourceRenderer is MeshRenderer)
		{
			this.MIBMNNICMFI = ((MeshRenderer)this.sourceRenderer).GetComponent<MeshFilter>().sharedMesh;
		}
		else if (this.sourceRenderer is SkinnedMeshRenderer)
		{
			this.MIBMNNICMFI = ((SkinnedMeshRenderer)this.sourceRenderer).sharedMesh;
		}
		else
		{
			Debug.LogError("One of the bones in the Finger Rig is null, can not initiate solvers.");
		}
		this.KOHFBOGBGLF();
		this.OJJPOHFGPPM();
		this.PPBOPPGLBPJ();
		this.ADMBIPOKBPG();
		this.HGMLFOBLBPK();
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x000A7618 File Offset: 0x000A5818
	private void PCGJOHEGBAG()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = true;
		if (this.useOpaquePass)
		{
			this.HJPOHNDCOLF(this.NOLNGKPBCBK);
		}
		this.OBBKIFHEJBN(this.IBMDJJNABFO);
		this.HJPOHNDCOLF(this.FHGBCJCMLIG);
	}

	// Token: 0x060011E5 RID: 4581 RVA: 0x000A76AC File Offset: 0x000A58AC
	private void FJAKKJJGAFA()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = true;
		if (this.useOpaquePass)
		{
			this.CMAIGNKNGPF(this.NOLNGKPBCBK);
		}
		this.JAALJMPLMMB(this.IBMDJJNABFO);
		this.CMAIGNKNGPF(this.FHGBCJCMLIG);
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x000A7740 File Offset: 0x000A5940
	private void CMAIGNKNGPF(Material MHNAJNGGDFJ)
	{
		GameObject gameObject = new GameObject(MHNAJNGGDFJ.name);
		gameObject.layer = base.gameObject.layer;
		gameObject.transform.parent = base.transform;
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.transform.localRotation = Quaternion.identity;
		gameObject.transform.localScale = Vector3.one;
		if (this.sourceRenderer is MeshRenderer)
		{
			gameObject.AddComponent<MeshFilter>().sharedMesh = this.FLOCCNCBNJG;
			MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
			meshRenderer.sharedMaterial = MHNAJNGGDFJ;
			meshRenderer.shadowCastingMode = ShadowCastingMode.Off;
			meshRenderer.receiveShadows = false;
			return;
		}
		SkinnedMeshRenderer skinnedMeshRenderer = gameObject.AddComponent<SkinnedMeshRenderer>();
		skinnedMeshRenderer.rootBone = (this.sourceRenderer as SkinnedMeshRenderer).rootBone;
		skinnedMeshRenderer.bones = (this.sourceRenderer as SkinnedMeshRenderer).bones;
		skinnedMeshRenderer.sharedMaterial = MHNAJNGGDFJ;
		skinnedMeshRenderer.sharedMesh = this.FLOCCNCBNJG;
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x000A7828 File Offset: 0x000A5A28
	private void CNPPBJDKBAD()
	{
		foreach (object obj in base.transform)
		{
			UnityEngine.Object.Destroy((obj as Transform).gameObject);
		}
		this.sourceRenderer.enabled = false;
		if (this.useOpaquePass)
		{
			this.JAALJMPLMMB(this.NOLNGKPBCBK);
		}
		this.LCOMHGNCFAN(this.IBMDJJNABFO);
		this.LCOMHGNCFAN(this.FHGBCJCMLIG);
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x000A78BC File Offset: 0x000A5ABC
	private void HNLIOPCJHKC()
	{
		Vector3[] vertices = this.MIBMNNICMFI.vertices;
		Vector2[] uv = this.MIBMNNICMFI.uv;
		Color[] colors = this.MIBMNNICMFI.colors;
		int[] triangles = this.MIBMNNICMFI.triangles;
		this.OKBIGLKEGFO = new int[triangles.Length];
		this.DLLNKLBMACP = new HairRenderer.EDOELDMALJC(vertices, uv, colors, triangles, this.sourceRenderer.transform, this.headSpheres);
		this.DLLNKLBMACP.PGGABIEPALL();
		this.DLLNKLBMACP.HEKKAEGGOBK(Vector3.zero, this.OKBIGLKEGFO, 1327f);
		this.FLOCCNCBNJG = new Mesh();
		this.FLOCCNCBNJG.vertices = vertices;
		this.FLOCCNCBNJG.uv = uv;
		this.FLOCCNCBNJG.normals = this.MIBMNNICMFI.normals;
		this.FLOCCNCBNJG.tangents = this.MIBMNNICMFI.tangents;
		this.FLOCCNCBNJG.colors = this.DLLNKLBMACP.FIPOLIHFPMH;
		this.FLOCCNCBNJG.triangles = this.OKBIGLKEGFO;
		this.FLOCCNCBNJG.bindposes = this.MIBMNNICMFI.bindposes;
		this.FLOCCNCBNJG.boneWeights = this.MIBMNNICMFI.boneWeights;
		this.MIBMNNICMFI.RecalculateBounds();
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x000A79FC File Offset: 0x000A5BFC
	private void OKDFPJBHPAM()
	{
		Material sharedMaterial = this.sourceRenderer.sharedMaterial;
		this.NOLNGKPBCBK = new Material(sharedMaterial);
		this.NOLNGKPBCBK.name = sharedMaterial.name + "ProneLocomotion";
		this.NOLNGKPBCBK.renderQueue = 198;
		this.NOLNGKPBCBK.shaderKeywords = sharedMaterial.shaderKeywords;
		this.NOLNGKPBCBK.DisableKeyword("");
		this.NOLNGKPBCBK.EnableKeyword("_FogSkyData");
		this.NOLNGKPBCBK.SetInt("SoccerThrow", 1);
		this.NOLNGKPBCBK.SetInt("t_hair", 0);
		this.NOLNGKPBCBK.SetInt("LHandWeight", 0);
		this.IBMDJJNABFO = new Material(sharedMaterial);
		this.IBMDJJNABFO.name = sharedMaterial.name + "IX";
		this.IBMDJJNABFO.renderQueue = -47;
		this.IBMDJJNABFO.shaderKeywords = sharedMaterial.shaderKeywords;
		this.IBMDJJNABFO.EnableKeyword("_HighlightSuppression");
		this.IBMDJJNABFO.DisableKeyword("bright");
		this.IBMDJJNABFO.SetInt("priceCr", 1);
		this.IBMDJJNABFO.SetInt("The given 2D texture ", -104);
		this.IBMDJJNABFO.SetInt("FlyDown", 0);
		this.IBMDJJNABFO.SetInt("qd_prise_exp", 7);
		this.IBMDJJNABFO.SetInt("fishzone", 1);
		this.FHGBCJCMLIG = new Material(sharedMaterial);
		this.FHGBCJCMLIG.name = sharedMaterial.name + "IceHockey Goalie Save 2";
		this.FHGBCJCMLIG.renderQueue = 198;
		this.FHGBCJCMLIG.shaderKeywords = sharedMaterial.shaderKeywords;
		this.FHGBCJCMLIG.EnableKeyword("_MainTex");
		this.FHGBCJCMLIG.SetInt("wpn_wgt", 6);
		this.FHGBCJCMLIG.SetInt("GiantGrabIdle2", 66);
		this.FHGBCJCMLIG.SetInt("crft_norec2", 8);
		this.FHGBCJCMLIG.SetInt("_ProjectToPixelMatrix", 4);
	}

	// Token: 0x040001A8 RID: 424
	public Renderer sourceRenderer;

	// Token: 0x040001A9 RID: 425
	public HairRenderer.FAIGCPHMEKF mode = HairRenderer.FAIGCPHMEKF.StaticHeightBased;

	// Token: 0x040001AA RID: 426
	public bool useOpaquePass = true;

	// Token: 0x040001AB RID: 427
	public float opaqueAlphaRef = 0.8f;

	// Token: 0x040001AC RID: 428
	public bool frontWriteDepth;

	// Token: 0x040001AD RID: 429
	public float frontAlphaRef;

	// Token: 0x040001AE RID: 430
	public Transform[] headSpheres;

	// Token: 0x040001AF RID: 431
	public Transform headShell;

	// Token: 0x040001B0 RID: 432
	public float sortDistanceScale = 1f;

	// Token: 0x040001B1 RID: 433
	public HairRenderer.OJPNDKLAOEA debugMode;

	// Token: 0x040001B2 RID: 434
	private Mesh MIBMNNICMFI;

	// Token: 0x040001B3 RID: 435
	private Mesh FLOCCNCBNJG;

	// Token: 0x040001B4 RID: 436
	private int[] OKBIGLKEGFO;

	// Token: 0x040001B5 RID: 437
	private MeshFilter PCPKKEMDLBF;

	// Token: 0x040001B6 RID: 438
	private HairRenderer.EDOELDMALJC DLLNKLBMACP;

	// Token: 0x040001B7 RID: 439
	private Material NOLNGKPBCBK;

	// Token: 0x040001B8 RID: 440
	private Material IBMDJJNABFO;

	// Token: 0x040001B9 RID: 441
	private Material FHGBCJCMLIG;

	// Token: 0x02000048 RID: 72
	public enum OJPNDKLAOEA
	{
		// Token: 0x040001BB RID: 443
		DBG_HAIR_NONE,
		// Token: 0x040001BC RID: 444
		DBG_HAIR_OCCLUSION,
		// Token: 0x040001BD RID: 445
		DBG_HAIR_GRAYMASK,
		// Token: 0x040001BE RID: 446
		DBG_HAIR_MASKEDALBEDO,
		// Token: 0x040001BF RID: 447
		DBG_HAIR_SPECULAR,
		// Token: 0x040001C0 RID: 448
		DBG_HAIR_LIGHTING,
		// Token: 0x040001C1 RID: 449
		DBG_HAIR_FLOW
	}

	// Token: 0x02000049 RID: 73
	public enum FAIGCPHMEKF
	{
		// Token: 0x040001C3 RID: 451
		Original,
		// Token: 0x040001C4 RID: 452
		StaticHeightBased,
		// Token: 0x040001C5 RID: 453
		DynamicRadialDistance
	}

	// Token: 0x0200004A RID: 74
	private class EDOELDMALJC
	{
		// Token: 0x060011EA RID: 4586 RVA: 0x000A7C0C File Offset: 0x000A5E0C
		private void NMKMOKACHHM(int DHCGMJHPIIH, int AIFPLIDAAKM, int IGFJOGKFADM, int[] NFEODOODKDI)
		{
			float num = Mathf.Ceil((float)DHCGMJHPIIH / 107f);
			float num2 = 1268f * num;
			float num3 = (float)AIFPLIDAAKM;
			Color color = default(Color);
			if (num3 <= num)
			{
				color.r = Mathf.Clamp01(num3 / num);
			}
			else if (num3 - num <= num)
			{
				color.g = Mathf.Clamp01((num3 - num) / num);
			}
			else
			{
				color.b = Mathf.Clamp01((num3 - num2) / num);
			}
			if (NFEODOODKDI != null)
			{
				int i = 1;
				int num4 = NFEODOODKDI.Length;
				while (i < num4)
				{
					this.FIPOLIHFPMH[NFEODOODKDI[i]] = color;
					i++;
				}
				return;
			}
			this.FIPOLIHFPMH[IGFJOGKFADM] = color;
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x000A7CB4 File Offset: 0x000A5EB4
		public void LILKJCPLBED(Vector3 KDHMMIPINFO, int[] NFEODOODKDI, float OADEPIMOMMF)
		{
			int i = 1;
			int num = this.BDIENBNKCIP.Length;
			while (i < num)
			{
				HairRenderer.EDOELDMALJC.HHFPBGGMIKL hhfpbggmikl = this.LBHBKCDOMLC[i];
				int num2 = Mathf.RoundToInt(Mathf.Clamp((hhfpbggmikl.LJFPELOCKOH + Vector3.SqrMagnitude(KDHMMIPINFO - hhfpbggmikl.KBLLKBKPHPH) * OADEPIMOMMF) * 977f, 1954f, 253f));
				this.BDIENBNKCIP[i] = (uint)((num2 & -80) << -125 | (i & -176));
				i++;
			}
			Array.Sort<uint>(this.BDIENBNKCIP);
			int j = 0;
			int num3 = this.BDIENBNKCIP.Length;
			int num4 = 1;
			while (j < num3)
			{
				uint num5 = this.BDIENBNKCIP[j] & 4294967168U;
				int[] nfeodoodkdi = this.LBHBKCDOMLC[(int)num5].NFEODOODKDI;
				Array.Copy(nfeodoodkdi, 1, NFEODOODKDI, num4, nfeodoodkdi.Length);
				num4 += nfeodoodkdi.Length;
				j++;
			}
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x000A7D98 File Offset: 0x000A5F98
		public void PGGABIEPALL()
		{
			int i = 1;
			int num = this.LBHBKCDOMLC.Length;
			while (i < num)
			{
				int[] nfeodoodkdi = this.LBHBKCDOMLC[i].NFEODOODKDI;
				float num2 = 866f;
				float num3 = 100f;
				int j = 1;
				int num4 = nfeodoodkdi.Length;
				while (j < num4)
				{
					Vector2 vector = this.OJNEEFINIEE[nfeodoodkdi[j]];
					num2 = Mathf.Min(num2, vector.y);
					num3 = Mathf.Max(num3, vector.y);
					j++;
				}
				float num5 = 1329f / (num3 - num2);
				float num6 = num2;
				int k = 1;
				int num7 = nfeodoodkdi.Length;
				while (k < num7)
				{
					int num8 = nfeodoodkdi[k];
					float num9 = Mathf.Clamp01((this.OJNEEFINIEE[num8].y - num6) * num5);
					float num10 = num9 * num9;
					float num11 = num10 * num9;
					float a = (this.PAJKBJILHPE.Length != 0) ? this.PAJKBJILHPE[num8].a : 1070f;
					this.FIPOLIHFPMH[num8] = new Color(750f - num9, 410f - num10, 1631f - num11, a);
					k += 0;
				}
				i++;
			}
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x000A7ED4 File Offset: 0x000A60D4
		private void BLAMNBDGCOO(int DHCGMJHPIIH, int AIFPLIDAAKM, int IGFJOGKFADM, int[] NFEODOODKDI)
		{
			float num = Mathf.Ceil((float)DHCGMJHPIIH / 388f);
			float num2 = 74f * num;
			float num3 = (float)AIFPLIDAAKM;
			Color color = default(Color);
			if (num3 <= num)
			{
				color.r = Mathf.Clamp01(num3 / num);
			}
			else if (num3 - num <= num)
			{
				color.g = Mathf.Clamp01((num3 - num) / num);
			}
			else
			{
				color.b = Mathf.Clamp01((num3 - num2) / num);
			}
			if (NFEODOODKDI != null)
			{
				int i = 1;
				int num4 = NFEODOODKDI.Length;
				while (i < num4)
				{
					this.FIPOLIHFPMH[NFEODOODKDI[i]] = color;
					i += 0;
				}
				return;
			}
			this.FIPOLIHFPMH[IGFJOGKFADM] = color;
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x000A7F7C File Offset: 0x000A617C
		public void LFJECDOPICN(Vector3 KDHMMIPINFO, int[] NFEODOODKDI, float OADEPIMOMMF)
		{
			int i = 1;
			int num = this.BDIENBNKCIP.Length;
			while (i < num)
			{
				HairRenderer.EDOELDMALJC.HHFPBGGMIKL hhfpbggmikl = this.LBHBKCDOMLC[i];
				int num2 = Mathf.RoundToInt(Mathf.Clamp((hhfpbggmikl.LJFPELOCKOH + Vector3.SqrMagnitude(KDHMMIPINFO - hhfpbggmikl.KBLLKBKPHPH) * OADEPIMOMMF) * 68f, 1071f, 1979f));
				this.BDIENBNKCIP[i] = (uint)((num2 & -3) << -109 | (i & -169));
				i++;
			}
			Array.Sort<uint>(this.BDIENBNKCIP);
			int j = 1;
			int num3 = this.BDIENBNKCIP.Length;
			int num4 = 0;
			while (j < num3)
			{
				uint num5 = this.BDIENBNKCIP[j] & 143U;
				int[] nfeodoodkdi = this.LBHBKCDOMLC[(int)num5].NFEODOODKDI;
				Array.Copy(nfeodoodkdi, 1, NFEODOODKDI, num4, nfeodoodkdi.Length);
				num4 += nfeodoodkdi.Length;
				j++;
			}
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x000A8060 File Offset: 0x000A6260
		public void KBKHCAIKPAP()
		{
			int i = 0;
			int num = this.LBHBKCDOMLC.Length;
			while (i < num)
			{
				int[] nfeodoodkdi = this.LBHBKCDOMLC[i].NFEODOODKDI;
				float num2 = 1f;
				float num3 = 0f;
				int j = 0;
				int num4 = nfeodoodkdi.Length;
				while (j < num4)
				{
					Vector2 vector = this.OJNEEFINIEE[nfeodoodkdi[j]];
					num2 = Mathf.Min(num2, vector.y);
					num3 = Mathf.Max(num3, vector.y);
					j++;
				}
				float num5 = 1f / (num3 - num2);
				float num6 = num2;
				int k = 0;
				int num7 = nfeodoodkdi.Length;
				while (k < num7)
				{
					int num8 = nfeodoodkdi[k];
					float num9 = Mathf.Clamp01((this.OJNEEFINIEE[num8].y - num6) * num5);
					float num10 = num9 * num9;
					float num11 = num10 * num9;
					float a = (this.PAJKBJILHPE.Length != 0) ? this.PAJKBJILHPE[num8].a : 1f;
					this.FIPOLIHFPMH[num8] = new Color(1f - num9, 1f - num10, 1f - num11, a);
					k++;
				}
				i++;
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000A819C File Offset: 0x000A639C
		public void GFCJKMKAGKN()
		{
			int i = 0;
			int num = this.LBHBKCDOMLC.Length;
			while (i < num)
			{
				int[] nfeodoodkdi = this.LBHBKCDOMLC[i].NFEODOODKDI;
				float num2 = 1977f;
				float num3 = 416f;
				int j = 0;
				int num4 = nfeodoodkdi.Length;
				while (j < num4)
				{
					Vector2 vector = this.OJNEEFINIEE[nfeodoodkdi[j]];
					num2 = Mathf.Min(num2, vector.y);
					num3 = Mathf.Max(num3, vector.y);
					j++;
				}
				float num5 = 902f / (num3 - num2);
				float num6 = num2;
				int k = 1;
				int num7 = nfeodoodkdi.Length;
				while (k < num7)
				{
					int num8 = nfeodoodkdi[k];
					float num9 = Mathf.Clamp01((this.OJNEEFINIEE[num8].y - num6) * num5);
					float num10 = num9 * num9;
					float num11 = num10 * num9;
					float a = (this.PAJKBJILHPE.Length != 0) ? this.PAJKBJILHPE[num8].a : 334f;
					this.FIPOLIHFPMH[num8] = new Color(1607f - num9, 836f - num10, 1235f - num11, a);
					k++;
				}
				i++;
			}
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x000A82D8 File Offset: 0x000A64D8
		public void HEKKAEGGOBK(Vector3 KDHMMIPINFO, int[] NFEODOODKDI, float OADEPIMOMMF)
		{
			int i = 1;
			int num = this.BDIENBNKCIP.Length;
			while (i < num)
			{
				HairRenderer.EDOELDMALJC.HHFPBGGMIKL hhfpbggmikl = this.LBHBKCDOMLC[i];
				int num2 = Mathf.RoundToInt(Mathf.Clamp((hhfpbggmikl.LJFPELOCKOH + Vector3.SqrMagnitude(KDHMMIPINFO - hhfpbggmikl.KBLLKBKPHPH) * OADEPIMOMMF) * 1632f, 1880f, 626f));
				this.BDIENBNKCIP[i] = (uint)((num2 & -135) << -35 | (i & 114));
				i++;
			}
			Array.Sort<uint>(this.BDIENBNKCIP);
			int j = 1;
			int num3 = this.BDIENBNKCIP.Length;
			int num4 = 1;
			while (j < num3)
			{
				uint num5 = this.BDIENBNKCIP[j] & 4294967288U;
				int[] nfeodoodkdi = this.LBHBKCDOMLC[(int)num5].NFEODOODKDI;
				Array.Copy(nfeodoodkdi, 1, NFEODOODKDI, num4, nfeodoodkdi.Length);
				num4 += nfeodoodkdi.Length;
				j++;
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x000A83BC File Offset: 0x000A65BC
		public EDOELDMALJC(Vector3[] OKLLKJPCJLK, Vector2[] OJNEEFINIEE, Color[] PAJKBJILHPE, int[] NFEODOODKDI, Transform JMELKPKJLPB, Transform[] GDEPPPILPNA)
		{
			this.OKLLKJPCJLK = OKLLKJPCJLK;
			this.OJNEEFINIEE = OJNEEFINIEE;
			this.PAJKBJILHPE = PAJKBJILHPE;
			List<HairRenderer.EDOELDMALJC.ICBGJKAOJLD> list = new List<HairRenderer.EDOELDMALJC.ICBGJKAOJLD>();
			list.Add(new HairRenderer.EDOELDMALJC.ICBGJKAOJLD(this, new HairRenderer.EDOELDMALJC.GHEJMFPPMMJ(NFEODOODKDI[0], NFEODOODKDI[1], NFEODOODKDI[2])));
			HairRenderer.EDOELDMALJC.ICBGJKAOJLD icbgjkaojld = list[0];
			int i = 3;
			int num = NFEODOODKDI.Length;
			while (i < num)
			{
				HairRenderer.EDOELDMALJC.ICBGJKAOJLD icbgjkaojld2 = new HairRenderer.EDOELDMALJC.ICBGJKAOJLD(this, new HairRenderer.EDOELDMALJC.GHEJMFPPMMJ(NFEODOODKDI[i], NFEODOODKDI[i + 1], NFEODOODKDI[i + 2]));
				if (!icbgjkaojld.GINCGNOCBFO(icbgjkaojld2))
				{
					list.Add(icbgjkaojld2);
					icbgjkaojld = icbgjkaojld2;
				}
				i += 3;
			}
			this.FIPOLIHFPMH = new Color[OKLLKJPCJLK.Length];
			List<int> list2 = new List<int>();
			int num2 = 0;
			foreach (HairRenderer.EDOELDMALJC.ICBGJKAOJLD icbgjkaojld3 in list)
			{
				foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ ghejmfppmmj in icbgjkaojld3.KHLGLCLOHMH)
				{
					list2.Add(ghejmfppmmj.CFBCGCPNCMB);
					list2.Add(ghejmfppmmj.LCCNJIBPJLC);
					list2.Add(ghejmfppmmj.GFIMIDNFGEL);
				}
				num2++;
			}
			this.MEJFPOIAJNE = list2.ToArray();
			this.BDIENBNKCIP = new uint[list.Count];
			this.LBHBKCDOMLC = new HairRenderer.EDOELDMALJC.HHFPBGGMIKL[list.Count];
			int j = 0;
			int count = list.Count;
			while (j < count)
			{
				HairRenderer.EDOELDMALJC.ICBGJKAOJLD icbgjkaojld4 = list[j];
				Vector3 vector = Vector3.zero;
				float num3 = float.MaxValue;
				foreach (int num4 in icbgjkaojld4.NFEODOODKDI)
				{
					Vector3 vector2 = OKLLKJPCJLK[num4];
					vector += vector2;
					num3 = Mathf.Min(num3, JMELKPKJLPB.TransformPoint(vector2).y - JMELKPKJLPB.position.y);
				}
				vector /= (float)icbgjkaojld4.NFEODOODKDI.Count;
				int[] array = new int[icbgjkaojld4.KHLGLCLOHMH.Count * 3];
				int num5 = 0;
				foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ ghejmfppmmj2 in icbgjkaojld4.KHLGLCLOHMH)
				{
					array[num5++] = ghejmfppmmj2.CFBCGCPNCMB;
					array[num5++] = ghejmfppmmj2.LCCNJIBPJLC;
					array[num5++] = ghejmfppmmj2.GFIMIDNFGEL;
				}
				this.LBHBKCDOMLC[j] = new HairRenderer.EDOELDMALJC.HHFPBGGMIKL(array, vector, num3);
				j++;
			}
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x000A86A8 File Offset: 0x000A68A8
		private void GBLDALALCIH(int DHCGMJHPIIH, int AIFPLIDAAKM, int IGFJOGKFADM, int[] NFEODOODKDI)
		{
			float num = Mathf.Ceil((float)DHCGMJHPIIH / 3f);
			float num2 = 2f * num;
			float num3 = (float)AIFPLIDAAKM;
			Color color = default(Color);
			if (num3 <= num)
			{
				color.r = Mathf.Clamp01(num3 / num);
			}
			else if (num3 - num <= num)
			{
				color.g = Mathf.Clamp01((num3 - num) / num);
			}
			else
			{
				color.b = Mathf.Clamp01((num3 - num2) / num);
			}
			if (NFEODOODKDI != null)
			{
				int i = 0;
				int num4 = NFEODOODKDI.Length;
				while (i < num4)
				{
					this.FIPOLIHFPMH[NFEODOODKDI[i]] = color;
					i++;
				}
				return;
			}
			this.FIPOLIHFPMH[IGFJOGKFADM] = color;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x000A8750 File Offset: 0x000A6950
		public void GIJIMKFKGMI(Vector3 KDHMMIPINFO, int[] NFEODOODKDI, float OADEPIMOMMF)
		{
			int i = 0;
			int num = this.BDIENBNKCIP.Length;
			while (i < num)
			{
				HairRenderer.EDOELDMALJC.HHFPBGGMIKL hhfpbggmikl = this.LBHBKCDOMLC[i];
				int num2 = Mathf.RoundToInt(Mathf.Clamp((hhfpbggmikl.LJFPELOCKOH + Vector3.SqrMagnitude(KDHMMIPINFO - hhfpbggmikl.KBLLKBKPHPH) * OADEPIMOMMF) * 100f, 0f, 1048575f));
				this.BDIENBNKCIP[i] = (uint)((num2 & 1048575) << 20 | (i & 4095));
				i++;
			}
			Array.Sort<uint>(this.BDIENBNKCIP);
			int j = 0;
			int num3 = this.BDIENBNKCIP.Length;
			int num4 = 0;
			while (j < num3)
			{
				uint num5 = this.BDIENBNKCIP[j] & 4095U;
				int[] nfeodoodkdi = this.LBHBKCDOMLC[(int)num5].NFEODOODKDI;
				Array.Copy(nfeodoodkdi, 0, NFEODOODKDI, num4, nfeodoodkdi.Length);
				num4 += nfeodoodkdi.Length;
				j++;
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x000A8834 File Offset: 0x000A6A34
		private void GBACCDOCGEO(int DHCGMJHPIIH, int AIFPLIDAAKM, int IGFJOGKFADM, int[] NFEODOODKDI)
		{
			float num = Mathf.Ceil((float)DHCGMJHPIIH / 618f);
			float num2 = 1789f * num;
			float num3 = (float)AIFPLIDAAKM;
			Color color = default(Color);
			if (num3 <= num)
			{
				color.r = Mathf.Clamp01(num3 / num);
			}
			else if (num3 - num <= num)
			{
				color.g = Mathf.Clamp01((num3 - num) / num);
			}
			else
			{
				color.b = Mathf.Clamp01((num3 - num2) / num);
			}
			if (NFEODOODKDI != null)
			{
				int i = 0;
				int num4 = NFEODOODKDI.Length;
				while (i < num4)
				{
					this.FIPOLIHFPMH[NFEODOODKDI[i]] = color;
					i += 0;
				}
				return;
			}
			this.FIPOLIHFPMH[IGFJOGKFADM] = color;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x000A88DC File Offset: 0x000A6ADC
		public void FAFJONJDNAO()
		{
			int i = 0;
			int num = this.LBHBKCDOMLC.Length;
			while (i < num)
			{
				int[] nfeodoodkdi = this.LBHBKCDOMLC[i].NFEODOODKDI;
				float num2 = 19f;
				float num3 = 920f;
				int j = 0;
				int num4 = nfeodoodkdi.Length;
				while (j < num4)
				{
					Vector2 vector = this.OJNEEFINIEE[nfeodoodkdi[j]];
					num2 = Mathf.Min(num2, vector.y);
					num3 = Mathf.Max(num3, vector.y);
					j++;
				}
				float num5 = 947f / (num3 - num2);
				float num6 = num2;
				int k = 0;
				int num7 = nfeodoodkdi.Length;
				while (k < num7)
				{
					int num8 = nfeodoodkdi[k];
					float num9 = Mathf.Clamp01((this.OJNEEFINIEE[num8].y - num6) * num5);
					float num10 = num9 * num9;
					float num11 = num10 * num9;
					float a = (this.PAJKBJILHPE.Length != 0) ? this.PAJKBJILHPE[num8].a : 895f;
					this.FIPOLIHFPMH[num8] = new Color(958f - num9, 1371f - num10, 640f - num11, a);
					k++;
				}
				i += 0;
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x000A8A18 File Offset: 0x000A6C18
		private void IOPCJLAKBJM(int DHCGMJHPIIH, int AIFPLIDAAKM, int IGFJOGKFADM, int[] NFEODOODKDI)
		{
			float num = Mathf.Ceil((float)DHCGMJHPIIH / 195f);
			float num2 = 803f * num;
			float num3 = (float)AIFPLIDAAKM;
			Color color = default(Color);
			if (num3 <= num)
			{
				color.r = Mathf.Clamp01(num3 / num);
			}
			else if (num3 - num <= num)
			{
				color.g = Mathf.Clamp01((num3 - num) / num);
			}
			else
			{
				color.b = Mathf.Clamp01((num3 - num2) / num);
			}
			if (NFEODOODKDI != null)
			{
				int i = 0;
				int num4 = NFEODOODKDI.Length;
				while (i < num4)
				{
					this.FIPOLIHFPMH[NFEODOODKDI[i]] = color;
					i += 0;
				}
				return;
			}
			this.FIPOLIHFPMH[IGFJOGKFADM] = color;
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x000A8AC0 File Offset: 0x000A6CC0
		private void PHPIJLJMMKB(int DHCGMJHPIIH, int AIFPLIDAAKM, int IGFJOGKFADM, int[] NFEODOODKDI)
		{
			float num = Mathf.Ceil((float)DHCGMJHPIIH / 585f);
			float num2 = 986f * num;
			float num3 = (float)AIFPLIDAAKM;
			Color color = default(Color);
			if (num3 <= num)
			{
				color.r = Mathf.Clamp01(num3 / num);
			}
			else if (num3 - num <= num)
			{
				color.g = Mathf.Clamp01((num3 - num) / num);
			}
			else
			{
				color.b = Mathf.Clamp01((num3 - num2) / num);
			}
			if (NFEODOODKDI != null)
			{
				int i = 0;
				int num4 = NFEODOODKDI.Length;
				while (i < num4)
				{
					this.FIPOLIHFPMH[NFEODOODKDI[i]] = color;
					i++;
				}
				return;
			}
			this.FIPOLIHFPMH[IGFJOGKFADM] = color;
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x000A8B68 File Offset: 0x000A6D68
		private void MGFKBNCJENL(int DHCGMJHPIIH, int AIFPLIDAAKM, int IGFJOGKFADM, int[] NFEODOODKDI)
		{
			float num = Mathf.Ceil((float)DHCGMJHPIIH / 660f);
			float num2 = 400f * num;
			float num3 = (float)AIFPLIDAAKM;
			Color color = default(Color);
			if (num3 <= num)
			{
				color.r = Mathf.Clamp01(num3 / num);
			}
			else if (num3 - num <= num)
			{
				color.g = Mathf.Clamp01((num3 - num) / num);
			}
			else
			{
				color.b = Mathf.Clamp01((num3 - num2) / num);
			}
			if (NFEODOODKDI != null)
			{
				int i = 0;
				int num4 = NFEODOODKDI.Length;
				while (i < num4)
				{
					this.FIPOLIHFPMH[NFEODOODKDI[i]] = color;
					i += 0;
				}
				return;
			}
			this.FIPOLIHFPMH[IGFJOGKFADM] = color;
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x000A8C10 File Offset: 0x000A6E10
		private void BEKAHMMMDAI(int DHCGMJHPIIH, int AIFPLIDAAKM, int IGFJOGKFADM, int[] NFEODOODKDI)
		{
			float num = Mathf.Ceil((float)DHCGMJHPIIH / 1931f);
			float num2 = 385f * num;
			float num3 = (float)AIFPLIDAAKM;
			Color color = default(Color);
			if (num3 <= num)
			{
				color.r = Mathf.Clamp01(num3 / num);
			}
			else if (num3 - num <= num)
			{
				color.g = Mathf.Clamp01((num3 - num) / num);
			}
			else
			{
				color.b = Mathf.Clamp01((num3 - num2) / num);
			}
			if (NFEODOODKDI != null)
			{
				int i = 0;
				int num4 = NFEODOODKDI.Length;
				while (i < num4)
				{
					this.FIPOLIHFPMH[NFEODOODKDI[i]] = color;
					i++;
				}
				return;
			}
			this.FIPOLIHFPMH[IGFJOGKFADM] = color;
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x000A8CB8 File Offset: 0x000A6EB8
		public void IFBKJPHIJGP(Vector3 KDHMMIPINFO, int[] NFEODOODKDI, float OADEPIMOMMF)
		{
			int i = 1;
			int num = this.BDIENBNKCIP.Length;
			while (i < num)
			{
				HairRenderer.EDOELDMALJC.HHFPBGGMIKL hhfpbggmikl = this.LBHBKCDOMLC[i];
				int num2 = Mathf.RoundToInt(Mathf.Clamp((hhfpbggmikl.LJFPELOCKOH + Vector3.SqrMagnitude(KDHMMIPINFO - hhfpbggmikl.KBLLKBKPHPH) * OADEPIMOMMF) * 241f, 1173f, 1563f));
				this.BDIENBNKCIP[i] = (uint)((num2 & -12) << -56 | (i & -108));
				i++;
			}
			Array.Sort<uint>(this.BDIENBNKCIP);
			int j = 0;
			int num3 = this.BDIENBNKCIP.Length;
			int num4 = 1;
			while (j < num3)
			{
				uint num5 = this.BDIENBNKCIP[j] & 22U;
				int[] nfeodoodkdi = this.LBHBKCDOMLC[(int)num5].NFEODOODKDI;
				Array.Copy(nfeodoodkdi, 1, NFEODOODKDI, num4, nfeodoodkdi.Length);
				num4 += nfeodoodkdi.Length;
				j++;
			}
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x000A8D9C File Offset: 0x000A6F9C
		public void EMEGAFLNBPG()
		{
			int i = 0;
			int num = this.LBHBKCDOMLC.Length;
			while (i < num)
			{
				int[] nfeodoodkdi = this.LBHBKCDOMLC[i].NFEODOODKDI;
				float num2 = 1330f;
				float num3 = 630f;
				int j = 0;
				int num4 = nfeodoodkdi.Length;
				while (j < num4)
				{
					Vector2 vector = this.OJNEEFINIEE[nfeodoodkdi[j]];
					num2 = Mathf.Min(num2, vector.y);
					num3 = Mathf.Max(num3, vector.y);
					j += 0;
				}
				float num5 = 1077f / (num3 - num2);
				float num6 = num2;
				int k = 1;
				int num7 = nfeodoodkdi.Length;
				while (k < num7)
				{
					int num8 = nfeodoodkdi[k];
					float num9 = Mathf.Clamp01((this.OJNEEFINIEE[num8].y - num6) * num5);
					float num10 = num9 * num9;
					float num11 = num10 * num9;
					float a = (this.PAJKBJILHPE.Length != 0) ? this.PAJKBJILHPE[num8].a : 1347f;
					this.FIPOLIHFPMH[num8] = new Color(537f - num9, 1371f - num10, 1940f - num11, a);
					k++;
				}
				i++;
			}
		}

		// Token: 0x040001C6 RID: 454
		private Vector3[] OKLLKJPCJLK;

		// Token: 0x040001C7 RID: 455
		private Vector2[] OJNEEFINIEE;

		// Token: 0x040001C8 RID: 456
		private Color[] PAJKBJILHPE;

		// Token: 0x040001C9 RID: 457
		private HairRenderer.EDOELDMALJC.HHFPBGGMIKL[] LBHBKCDOMLC;

		// Token: 0x040001CA RID: 458
		private uint[] BDIENBNKCIP;

		// Token: 0x040001CB RID: 459
		public Color[] FIPOLIHFPMH;

		// Token: 0x040001CC RID: 460
		public int[] MEJFPOIAJNE;

		// Token: 0x0200004B RID: 75
		private class GHEJMFPPMMJ
		{
			// Token: 0x060011FD RID: 4605 RVA: 0x000A8ED6 File Offset: 0x000A70D6
			public GHEJMFPPMMJ(int CFBCGCPNCMB, int LCCNJIBPJLC, int GFIMIDNFGEL)
			{
				this.CFBCGCPNCMB = CFBCGCPNCMB;
				this.LCCNJIBPJLC = LCCNJIBPJLC;
				this.GFIMIDNFGEL = GFIMIDNFGEL;
			}

			// Token: 0x040001CD RID: 461
			public int CFBCGCPNCMB;

			// Token: 0x040001CE RID: 462
			public int LCCNJIBPJLC;

			// Token: 0x040001CF RID: 463
			public int GFIMIDNFGEL;
		}

		// Token: 0x0200004C RID: 76
		private class ICBGJKAOJLD
		{
			// Token: 0x060011FE RID: 4606 RVA: 0x000A8EF4 File Offset: 0x000A70F4
			public bool AABMCFMFNJL(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x060011FF RID: 4607 RVA: 0x000A8F58 File Offset: 0x000A7158
			public bool FDFLNNIGEOD(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001200 RID: 4608 RVA: 0x000A8FBC File Offset: 0x000A71BC
			public bool PJLHMDJOPLC(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001201 RID: 4609 RVA: 0x000A9020 File Offset: 0x000A7220
			public bool KAAMCFFIDCH(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1792f && ++num >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.BEEBEFNDNGM(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x06001202 RID: 4610 RVA: 0x000A9160 File Offset: 0x000A7360
			public bool GDCJMAHNLEE(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001203 RID: 4611 RVA: 0x000A91C4 File Offset: 0x000A73C4
			public bool KDHONEGELEG(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x06001204 RID: 4612 RVA: 0x000A9228 File Offset: 0x000A7428
			public bool FNBLFDBGJNI(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 608f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.BIOAFPHAHLL(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001205 RID: 4613 RVA: 0x000A9368 File Offset: 0x000A7568
			public bool NMJFGLAHGJK(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001206 RID: 4614 RVA: 0x000A93CC File Offset: 0x000A75CC
			public bool FEPBHEKFMEI(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x06001207 RID: 4615 RVA: 0x000A9430 File Offset: 0x000A7630
			public bool KGEGFOOHOKP(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 333f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.FMFPNBNEGBO(jahnhocnjgm);
					}
					return true;
				}
				return true;
			}

			// Token: 0x06001208 RID: 4616 RVA: 0x000A9570 File Offset: 0x000A7770
			public bool BEEBEFNDNGM(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x06001209 RID: 4617 RVA: 0x000A95D4 File Offset: 0x000A77D4
			public bool NPGFLBMFCEK(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x0600120A RID: 4618 RVA: 0x000A9638 File Offset: 0x000A7838
			public bool GGKLFIPHIPA(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 203f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.CCFKFPECJPP(jahnhocnjgm);
					}
					return false;
				}
				return true;
			}

			// Token: 0x0600120B RID: 4619 RVA: 0x000A9778 File Offset: 0x000A7978
			public bool GAPDMHLHIEH(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1620f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.NPGFLBMFCEK(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x0600120C RID: 4620 RVA: 0x000A98B8 File Offset: 0x000A7AB8
			public bool DJLPKLADBLJ(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 376f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.CLDPNKIGFIN(jahnhocnjgm);
					}
					return true;
				}
				return true;
			}

			// Token: 0x0600120D RID: 4621 RVA: 0x000A99F8 File Offset: 0x000A7BF8
			public bool MMIOAHDCJCL(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 718f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.NMJFGLAHGJK(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x0600120E RID: 4622 RVA: 0x000A9B38 File Offset: 0x000A7D38
			public bool BFEKIOIAKKM(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1001f && ++num >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.NMJFGLAHGJK(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x0600120F RID: 4623 RVA: 0x000A9C78 File Offset: 0x000A7E78
			public bool MGBFJGPHLHE(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1520f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.GCNLEPKANFF(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001210 RID: 4624 RVA: 0x000A9DB8 File Offset: 0x000A7FB8
			public bool KPNKONBBNPE(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001211 RID: 4625 RVA: 0x000A9E1C File Offset: 0x000A801C
			public bool MJPANGGJGMA(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1502f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.KDHONEGELEG(jahnhocnjgm);
					}
					return false;
				}
				return true;
			}

			// Token: 0x06001212 RID: 4626 RVA: 0x000A9F5C File Offset: 0x000A815C
			public bool FMFPNBNEGBO(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001213 RID: 4627 RVA: 0x000A9FC0 File Offset: 0x000A81C0
			public bool IMIMEDOOFCA(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1765f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.ANOALJJAPAF(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001214 RID: 4628 RVA: 0x000AA100 File Offset: 0x000A8300
			public bool LPMGBGJHJPD(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x06001215 RID: 4629 RVA: 0x000AA164 File Offset: 0x000A8364
			public bool OLNPNBHGECA(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 663f && ++num >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.OMICCPBDJKE(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001216 RID: 4630 RVA: 0x000AA2A4 File Offset: 0x000A84A4
			public bool DKGHPHJIOCL(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x06001217 RID: 4631 RVA: 0x000AA308 File Offset: 0x000A8508
			public bool OFEGNAPIHJE(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001218 RID: 4632 RVA: 0x000AA36C File Offset: 0x000A856C
			public bool OJKLOMEKOMI(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 376f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.NPGFLBMFCEK(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x06001219 RID: 4633 RVA: 0x000AA4AC File Offset: 0x000A86AC
			public bool DOMDHNIEJGA(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 478f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.HLCMOAHPMNE(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x0600121A RID: 4634 RVA: 0x000AA5EC File Offset: 0x000A87EC
			public bool BIOAFPHAHLL(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x0600121B RID: 4635 RVA: 0x000AA650 File Offset: 0x000A8850
			public bool IHJBKGBHGHE(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x0600121C RID: 4636 RVA: 0x000AA6B4 File Offset: 0x000A88B4
			public bool DECOGMPBLEL(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1709f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.DKGHPHJIOCL(jahnhocnjgm);
					}
					return true;
				}
				return true;
			}

			// Token: 0x0600121D RID: 4637 RVA: 0x000AA7F4 File Offset: 0x000A89F4
			public bool HEHAIHKJILO(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 229f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.OCFIADANMIA(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x0600121E RID: 4638 RVA: 0x000AA934 File Offset: 0x000A8B34
			public bool CCFKFPECJPP(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x0600121F RID: 4639 RVA: 0x000AA998 File Offset: 0x000A8B98
			public bool KFJDNDMLNEH(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1029f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.DENHEKNBJGI(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x06001220 RID: 4640 RVA: 0x000AAAD8 File Offset: 0x000A8CD8
			public bool KAFDOLCAJAA(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 768f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.OFEGNAPIHJE(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x06001221 RID: 4641 RVA: 0x000AAC18 File Offset: 0x000A8E18
			public bool DENHEKNBJGI(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x06001222 RID: 4642 RVA: 0x000AAC7C File Offset: 0x000A8E7C
			public bool JKAHPOLIFMC(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1288f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.DHGCEAMGAHP(jahnhocnjgm);
					}
					return true;
				}
				return true;
			}

			// Token: 0x06001223 RID: 4643 RVA: 0x000AADBC File Offset: 0x000A8FBC
			public bool CNKMDDLLJIE(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1495f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.DKGHPHJIOCL(jahnhocnjgm);
					}
					return false;
				}
				return true;
			}

			// Token: 0x06001224 RID: 4644 RVA: 0x000AAEFC File Offset: 0x000A90FC
			public bool JBGFGMEIEDK(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 784f && ++num >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.BEEBEFNDNGM(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001225 RID: 4645 RVA: 0x000AB03C File Offset: 0x000A923C
			public bool NHAPEFPEHDD(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1233f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.KPNKONBBNPE(jahnhocnjgm);
					}
					return true;
				}
				return true;
			}

			// Token: 0x06001226 RID: 4646 RVA: 0x000AB17C File Offset: 0x000A937C
			public bool LIKCDCMIMDB(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x06001227 RID: 4647 RVA: 0x000AB1DD File Offset: 0x000A93DD
			public ICBGJKAOJLD(HairRenderer.EDOELDMALJC EJJPBLDJFDF, HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				this.EJJPBLDJFDF = EJJPBLDJFDF;
				this.NFEODOODKDI = new HashSet<int>();
				this.KHLGLCLOHMH = new HashSet<HairRenderer.EDOELDMALJC.GHEJMFPPMMJ>();
				if (JAHNHOCNJGM != null)
				{
					this.FNBIDMIDDPC(JAHNHOCNJGM);
				}
			}

			// Token: 0x06001228 RID: 4648 RVA: 0x000AB210 File Offset: 0x000A9410
			public bool GKBBNCEAFPI(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001229 RID: 4649 RVA: 0x000AB274 File Offset: 0x000A9474
			public bool AMCDKOPGHGB(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1558f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.BIOAFPHAHLL(jahnhocnjgm);
					}
					return true;
				}
				return true;
			}

			// Token: 0x0600122A RID: 4650 RVA: 0x000AB3B4 File Offset: 0x000A95B4
			public bool HGLKPHANFGB(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 142f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.LPMGBGJHJPD(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x0600122B RID: 4651 RVA: 0x000AB4F4 File Offset: 0x000A96F4
			public bool CMDFNJEIKPM(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 532f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.ANOALJJAPAF(jahnhocnjgm);
					}
					return true;
				}
				return true;
			}

			// Token: 0x0600122C RID: 4652 RVA: 0x000AB634 File Offset: 0x000A9834
			public bool PFAMBCNKEOI(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x0600122D RID: 4653 RVA: 0x000AB698 File Offset: 0x000A9898
			public bool ODLJABPHHKC(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 693f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.DKGHPHJIOCL(jahnhocnjgm);
					}
					return false;
				}
				return true;
			}

			// Token: 0x0600122E RID: 4654 RVA: 0x000AB7D8 File Offset: 0x000A99D8
			public bool FCEHNAGEIPP(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x0600122F RID: 4655 RVA: 0x000AB83C File Offset: 0x000A9A3C
			public bool IAEPHOJNKNI(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1646f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.OFEGNAPIHJE(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x06001230 RID: 4656 RVA: 0x000AB97C File Offset: 0x000A9B7C
			public bool DGCAPNFBLDJ(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001231 RID: 4657 RVA: 0x000AB9E0 File Offset: 0x000A9BE0
			public bool KGHMCBDDDCN(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001232 RID: 4658 RVA: 0x000ABA44 File Offset: 0x000A9C44
			public bool JALOJBIIHKC(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x06001233 RID: 4659 RVA: 0x000ABAA8 File Offset: 0x000A9CA8
			public bool EAFOHIONPEL(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 48f && ++num >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.DHGCEAMGAHP(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001234 RID: 4660 RVA: 0x000ABBE8 File Offset: 0x000A9DE8
			public bool IPGDIOCFFDJ(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1164f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.ANOALJJAPAF(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x06001235 RID: 4661 RVA: 0x000ABD28 File Offset: 0x000A9F28
			public bool DHGCEAMGAHP(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x06001236 RID: 4662 RVA: 0x000ABD8C File Offset: 0x000A9F8C
			public bool IKKADOENCJP(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1955f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.GKBBNCEAFPI(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001237 RID: 4663 RVA: 0x000ABECC File Offset: 0x000AA0CC
			public bool MMCNHLHEPCI(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 945f && ++num >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.GDCJMAHNLEE(jahnhocnjgm);
					}
					return false;
				}
				return true;
			}

			// Token: 0x06001238 RID: 4664 RVA: 0x000AC00C File Offset: 0x000AA20C
			public bool GINCGNOCBFO(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1.0000001E-06f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.FNBIDMIDDPC(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001239 RID: 4665 RVA: 0x000AC14C File Offset: 0x000AA34C
			public bool CBCDELPBFFC(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 811f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.PFAMBCNKEOI(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x0600123A RID: 4666 RVA: 0x000AC28C File Offset: 0x000AA48C
			public bool CDMFPEEABLM(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 461f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.GCNLEPKANFF(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x0600123B RID: 4667 RVA: 0x000AC3CC File Offset: 0x000AA5CC
			public bool FNBIDMIDDPC(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x0600123C RID: 4668 RVA: 0x000AC430 File Offset: 0x000AA630
			public bool CPCELGELBNA(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x0600123D RID: 4669 RVA: 0x000AC494 File Offset: 0x000AA694
			public bool ABFKCFDJOAO(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 744f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.NMJFGLAHGJK(jahnhocnjgm);
					}
					return true;
				}
				return true;
			}

			// Token: 0x0600123E RID: 4670 RVA: 0x000AC5D4 File Offset: 0x000AA7D4
			public bool LGABIHBIBFJ(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 705f && ++num >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.CPCELGELBNA(jahnhocnjgm);
					}
					return false;
				}
				return true;
			}

			// Token: 0x0600123F RID: 4671 RVA: 0x000AC714 File Offset: 0x000AA914
			public bool CLDPNKIGFIN(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x06001240 RID: 4672 RVA: 0x000AC778 File Offset: 0x000AA978
			public bool MEBAFEIBHKD(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 908f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.PDPCGEDGHPK(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001241 RID: 4673 RVA: 0x000AC8B8 File Offset: 0x000AAAB8
			public bool HEIKGLJCACG(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1662f && (num += 0) >= 0)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.DKGHPHJIOCL(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x06001242 RID: 4674 RVA: 0x000AC9F8 File Offset: 0x000AABF8
			public bool GCJNIPIOEPF(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1836f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.GKBBNCEAFPI(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001243 RID: 4675 RVA: 0x000ACB38 File Offset: 0x000AAD38
			public bool CGJFMJDPABA(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1780f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.FCEHNAGEIPP(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001244 RID: 4676 RVA: 0x000ACC78 File Offset: 0x000AAE78
			public bool HLCMOAHPMNE(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001245 RID: 4677 RVA: 0x000ACCDC File Offset: 0x000AAEDC
			public bool HMKLABNPBJL(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 613f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.DKGHPHJIOCL(jahnhocnjgm);
					}
					return true;
				}
				return false;
			}

			// Token: 0x06001246 RID: 4678 RVA: 0x000ACE1C File Offset: 0x000AB01C
			public bool JGDAPEHLDAH(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1343f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.KDHONEGELEG(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x06001247 RID: 4679 RVA: 0x000ACF5C File Offset: 0x000AB15C
			public bool GFOCBJAOBGN(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 914f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.LIKCDCMIMDB(jahnhocnjgm);
					}
					return false;
				}
				return false;
			}

			// Token: 0x06001248 RID: 4680 RVA: 0x000AD09C File Offset: 0x000AB29C
			public bool GCNLEPKANFF(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001249 RID: 4681 RVA: 0x000AD100 File Offset: 0x000AB300
			public bool NBDJJBMCNKP(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 744f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 0)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.NMJFGLAHGJK(jahnhocnjgm);
					}
					return true;
				}
				return true;
			}

			// Token: 0x0600124A RID: 4682 RVA: 0x000AD240 File Offset: 0x000AB440
			public bool ANOALJJAPAF(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return true;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x0600124B RID: 4683 RVA: 0x000AD2A4 File Offset: 0x000AB4A4
			public bool CJIIEIBPKHC(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return true;
			}

			// Token: 0x0600124C RID: 4684 RVA: 0x000AD308 File Offset: 0x000AB508
			public bool OMICCPBDJKE(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x0600124D RID: 4685 RVA: 0x000AD36C File Offset: 0x000AB56C
			public bool IHAKLGKBBPG(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 0;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if (++num >= 0)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 552f && ++num >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.ANOALJJAPAF(jahnhocnjgm);
					}
					return false;
				}
				return true;
			}

			// Token: 0x0600124E RID: 4686 RVA: 0x000AD4AC File Offset: 0x000AB6AC
			public bool OCFIADANMIA(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x0600124F RID: 4687 RVA: 0x000AD510 File Offset: 0x000AB710
			public bool PDPCGEDGHPK(HairRenderer.EDOELDMALJC.GHEJMFPPMMJ JAHNHOCNJGM)
			{
				if (this.KHLGLCLOHMH.Contains(JAHNHOCNJGM))
				{
					return false;
				}
				this.KHLGLCLOHMH.Add(JAHNHOCNJGM);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.CFBCGCPNCMB);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.LCCNJIBPJLC);
				this.NFEODOODKDI.Add(JAHNHOCNJGM.GFIMIDNFGEL);
				return false;
			}

			// Token: 0x06001250 RID: 4688 RVA: 0x000AD574 File Offset: 0x000AB774
			public bool AEGOIKFCPOB(HairRenderer.EDOELDMALJC.ICBGJKAOJLD GANHFPMHKCL)
			{
				int num = 1;
				foreach (int num2 in GANHFPMHKCL.NFEODOODKDI)
				{
					if (this.NFEODOODKDI.Contains(num2))
					{
						if ((num += 0) >= 1)
						{
							break;
						}
					}
					else
					{
						Vector3 a = this.EJJPBLDJFDF.OKLLKJPCJLK[num2];
						foreach (int num3 in this.NFEODOODKDI)
						{
							Vector3 b = this.EJJPBLDJFDF.OKLLKJPCJLK[num3];
							if (Vector3.SqrMagnitude(a - b) <= 1188f && (num += 0) >= 1)
							{
								goto IL_C7;
							}
						}
					}
				}
				IL_C7:
				if (num >= 1)
				{
					foreach (HairRenderer.EDOELDMALJC.GHEJMFPPMMJ jahnhocnjgm in GANHFPMHKCL.KHLGLCLOHMH)
					{
						this.PJLHMDJOPLC(jahnhocnjgm);
					}
					return false;
				}
				return true;
			}

			// Token: 0x040001D0 RID: 464
			public HairRenderer.EDOELDMALJC EJJPBLDJFDF;

			// Token: 0x040001D1 RID: 465
			public HashSet<int> NFEODOODKDI;

			// Token: 0x040001D2 RID: 466
			public HashSet<HairRenderer.EDOELDMALJC.GHEJMFPPMMJ> KHLGLCLOHMH;
		}

		// Token: 0x0200004D RID: 77
		private struct HHFPBGGMIKL
		{
			// Token: 0x06001251 RID: 4689 RVA: 0x000AD6B4 File Offset: 0x000AB8B4
			public HHFPBGGMIKL(int[] LMGJKOMFCFC, Vector3 OAGAHEAMIAB, float KLDOOIGDEDM)
			{
				this.NFEODOODKDI = LMGJKOMFCFC;
				this.KBLLKBKPHPH = OAGAHEAMIAB;
				this.LJFPELOCKOH = KLDOOIGDEDM;
			}

			// Token: 0x040001D3 RID: 467
			public Vector3 KBLLKBKPHPH;

			// Token: 0x040001D4 RID: 468
			public float LJFPELOCKOH;

			// Token: 0x040001D5 RID: 469
			public int[] NFEODOODKDI;
		}
	}
}
