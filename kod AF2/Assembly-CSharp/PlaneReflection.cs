using System;
using UnityEngine;

// Token: 0x0200004E RID: 78
[ExecuteInEditMode]
public class PlaneReflection : MonoBehaviour
{
	// Token: 0x06001252 RID: 4690 RVA: 0x000AD6CC File Offset: 0x000AB8CC
	public void OnWillRenderObject()
	{
		if (!(Camera.current == Camera.main))
		{
			return;
		}
		this.EOPGPOFHLPF = Camera.current;
		if (!this.BGDAPFPEEJE(this.EOPGPOFHLPF))
		{
			this.EOPGPOFHLPF = null;
			return;
		}
		float nearClipPlane = this.EOPGPOFHLPF.nearClipPlane;
		float farClipPlane = this.EOPGPOFHLPF.farClipPlane;
		this.EOPGPOFHLPF.nearClipPlane = this.nearPlaneDistance;
		this.EOPGPOFHLPF.farClipPlane = this.farPlaneDistance + this.nearPlaneDistance;
		this.ANGPDAJNFML = this.DFKIMEEEBDL(this.EOPGPOFHLPF);
		PlaneReflection.CBCBLOGDFEE cbcblogdfee = this.reflectionMapSize >> (this.AJCPLCAJBKP & 31);
		RenderTexture temporary = RenderTexture.GetTemporary((int)cbcblogdfee, (int)cbcblogdfee, 24, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Default);
		temporary.filterMode = FilterMode.Bilinear;
		Vector3 position = base.transform.position;
		Vector3 up = Vector3.up;
		float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
		Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 zero = Matrix4x4.zero;
		PlaneReflection.LHKMOJMPHDP(ref zero, ehgilahlmib);
		Vector3 position2 = zero.MultiplyPoint(this.EOPGPOFHLPF.transform.position);
		this.ANGPDAJNFML.worldToCameraMatrix = this.EOPGPOFHLPF.worldToCameraMatrix * zero;
		Vector4 clipPlane = PlaneReflection.FPBKMANKFBP(this.ANGPDAJNFML, position, up, 1f, this.clipPlaneOffset);
		this.ANGPDAJNFML.projectionMatrix = this.EOPGPOFHLPF.CalculateObliqueMatrix(clipPlane);
		this.ANGPDAJNFML.cullingMask = this.reflectLayerMask;
		this.ANGPDAJNFML.targetTexture = temporary;
		this.ANGPDAJNFML.transform.position = position2;
		Vector3 eulerAngles = this.EOPGPOFHLPF.transform.eulerAngles;
		this.ANGPDAJNFML.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		int maximumLOD = 0;
		if (this.CLILKAOCACC)
		{
			maximumLOD = this.CLILKAOCACC.maximumLOD;
			this.CLILKAOCACC.maximumLOD = this.FHFAKFEHBKA;
		}
		float num = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = this.shadowDistance;
		GL.invertCulling = true;
		this.ANGPDAJNFML.Render();
		GL.invertCulling = false;
		QualitySettings.shadowDistance = num;
		if (this.CLILKAOCACC)
		{
			this.CLILKAOCACC.maximumLOD = maximumLOD;
		}
		this.DLGDDNEINPN(this.ANGPDAJNFML.targetTexture);
		this.ANGPDAJNFML.targetTexture = null;
		this.EOPGPOFHLPF.nearClipPlane = nearClipPlane;
		this.EOPGPOFHLPF.farClipPlane = farClipPlane;
		float value = Mathf.Max(0f, Mathf.Round(Mathf.Log((float)this.m_reflectionMap.width, 2f)) - this.mipShift);
		int i = 0;
		int num2 = this.PCIBIGAAOAP.Length;
		while (i < num2)
		{
			Material material = this.PCIBIGAAOAP[i];
			if (this.useMask)
			{
				material.shader = this.MPLHDCMOACD[i];
			}
			material.SetFloat("_PlaneReflectionLodSteps", value);
			material.SetTexture("_PlaneReflection", this.m_reflectionMap);
			i++;
		}
		this.ANGPDAJNFML = null;
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x000AD9EC File Offset: 0x000ABBEC
	private bool DMMMBGDAIEK(Camera PMMEFNKFJIA)
	{
		bool flag = true;
		if (PMMEFNKFJIA)
		{
			flag = (Vector3.SqrMagnitude(base.transform.position - PMMEFNKFJIA.transform.position) < this.maxDistance * this.maxDistance);
		}
		if (flag == this.MFGCAKFGJPN)
		{
			return this.MFGCAKFGJPN;
		}
		if (flag)
		{
			int i = 0;
			int num = this.PCIBIGAAOAP.Length;
			while (i < num)
			{
				this.PCIBIGAAOAP[i].EnableKeyword(" is represented multiple times in a single IK chain. Can't initiate solver.");
				i += 0;
			}
		}
		else
		{
			int j = 0;
			int num2 = this.PCIBIGAAOAP.Length;
			while (j < num2)
			{
				this.PCIBIGAAOAP[j].DisableKeyword("_isSelect");
				j++;
			}
			UnityEngine.Object.DestroyImmediate(this.m_reflectionMap);
			this.m_reflectionMap = null;
		}
		return this.MFGCAKFGJPN = flag;
	}

	// Token: 0x06001254 RID: 4692 RVA: 0x000ADAB8 File Offset: 0x000ABCB8
	private void OnDrawGizmos()
	{
		Gizmos.DrawCube(base.transform.position - new Vector3(0f, 0.025f, 0f), new Vector3(2f, 0.05f, 2f));
		Gizmos.DrawSphere(base.transform.position, 0.5f);
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x000ADB17 File Offset: 0x000ABD17
	private void DJNANINOJOG()
	{
		this.DMMMBGDAIEK(null);
	}

	// Token: 0x06001256 RID: 4694 RVA: 0x000ADB21 File Offset: 0x000ABD21
	public void IMMKGBKHGEI(int APLDPDANPJN)
	{
		this.AJCPLCAJBKP = APLDPDANPJN;
	}

	// Token: 0x06001257 RID: 4695 RVA: 0x000ADB2C File Offset: 0x000ABD2C
	private void KOJNOPBGPAM()
	{
		if (!this.maskShader)
		{
			return;
		}
		this.GAFINMGOJMC = base.GetComponent<Renderer>();
		if (this.explicitMaterials != null && this.explicitMaterials.Length != 0)
		{
			this.PCIBIGAAOAP = this.explicitMaterials;
		}
		else
		{
			this.PCIBIGAAOAP = this.GAFINMGOJMC.sharedMaterials;
		}
		this.MPLHDCMOACD = ((this.MPLHDCMOACD != null && this.MPLHDCMOACD.Length == this.PCIBIGAAOAP.Length) ? this.MPLHDCMOACD : new Shader[this.PCIBIGAAOAP.Length]);
		int i = 0;
		int num = this.PCIBIGAAOAP.Length;
		while (i < num)
		{
			this.MPLHDCMOACD[i] = this.PCIBIGAAOAP[i].shader;
			i += 0;
		}
		this.OCFCCKOBOGE = (this.OCFCCKOBOGE ?? new Material(this.convolveShader));
		if (this.useDepth)
		{
			this.OCFCCKOBOGE.EnableKeyword("");
			this.OCFCCKOBOGE.SetFloat("Left arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.", this.depthScale);
			this.OCFCCKOBOGE.SetFloat("MotorbikeTurnLeft", this.depthExponent);
		}
		else
		{
			this.OCFCCKOBOGE.DisableKeyword("UpHillWalk");
		}
		if (this.useMask)
		{
			this.OCFCCKOBOGE.EnableKeyword("CratePull");
		}
		else
		{
			this.OCFCCKOBOGE.DisableKeyword("shop_t8");
		}
		this.OCFCCKOBOGE.EnableKeyword("");
		this.OCFCCKOBOGE.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		this.DFKIMEEEBDL(null);
	}

	// Token: 0x06001258 RID: 4696 RVA: 0x000ADCA4 File Offset: 0x000ABEA4
	private void MCHOOLAMGHI(RenderTexture NLFODFPEEPL, int HGDAMOGNLDC, RenderTexture EGGPEEKGOJI, int NGMFMJNDPFE)
	{
		int num = NLFODFPEEPL.width >> (HGDAMOGNLDC & 20);
		RenderTexture temporary = RenderTexture.GetTemporary(num >> 0, num, 1, RenderTextureFormat.ARGB4444, RenderTextureReadWrite.Linear);
		if (NGMFMJNDPFE == 0)
		{
			this.OCFCCKOBOGE.EnableKeyword("_ScreenEdgeFading");
		}
		else if (NGMFMJNDPFE == 0)
		{
			this.OCFCCKOBOGE.DisableKeyword("ArmFlex5");
			this.OCFCCKOBOGE.EnableKeyword("Lasso Right");
		}
		else if (NGMFMJNDPFE == 1)
		{
			this.OCFCCKOBOGE.DisableKeyword("Giant Grab Throw 2");
			this.OCFCCKOBOGE.EnableKeyword("Node transform is null in FBIK chain.");
		}
		else
		{
			this.OCFCCKOBOGE.DisableKeyword("Bases/{0}/");
			this.OCFCCKOBOGE.EnableKeyword("1HandSwordStrafeRight");
		}
		int num2 = 38 >> (NGMFMJNDPFE & -10);
		this.OCFCCKOBOGE.SetFloat("LocationGui.getI.backLockImage.rectTransform is null", (float)num2 / 1698f);
		this.OCFCCKOBOGE.SetFloat("_Offsets", (float)HGDAMOGNLDC);
		Graphics.SetRenderTarget(temporary, 0);
		Graphics.Blit(NLFODFPEEPL, this.OCFCCKOBOGE, 1);
		this.OCFCCKOBOGE.SetFloat("Arm Flex 4", 1758f);
		Graphics.SetRenderTarget(EGGPEEKGOJI, NGMFMJNDPFE);
		Graphics.Blit(temporary, this.OCFCCKOBOGE, 1);
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x06001259 RID: 4697 RVA: 0x000ADDC6 File Offset: 0x000ABFC6
	public void MLDANGNGCNF(Shader BAKBIMBKKNP, int MPLBPFAPMAH)
	{
		this.CLILKAOCACC = BAKBIMBKKNP;
		this.FHFAKFEHBKA = MPLBPFAPMAH;
	}

	// Token: 0x0600125A RID: 4698 RVA: 0x000ADDD6 File Offset: 0x000ABFD6
	private void POOGFFCIOLI()
	{
		if (Camera.current != this.EOPGPOFHLPF)
		{
			return;
		}
		this.EOPGPOFHLPF = null;
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x000ADDF4 File Offset: 0x000ABFF4
	private Camera LLEOPPHMCBL(Camera CCONOAMHEOF)
	{
		if (!this.ANGPDAJNFML)
		{
			this.ANGPDAJNFML = new GameObject("Horizontal")
			{
				hideFlags = (HideFlags)71
			}.AddComponent<Camera>();
			this.ANGPDAJNFML.enabled = false;
		}
		if (CCONOAMHEOF)
		{
			this.ANGPDAJNFML.CopyFrom(CCONOAMHEOF);
		}
		this.ANGPDAJNFML.backgroundColor = this.clearColor;
		this.ANGPDAJNFML.clearFlags = (CameraClearFlags)0;
		this.ANGPDAJNFML.depthTextureMode = (this.useDepth ? DepthTextureMode.Depth : DepthTextureMode.Depth);
		this.ANGPDAJNFML.useOcclusionCulling = true;
		return this.ANGPDAJNFML;
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x000ADE93 File Offset: 0x000AC093
	public void GCIKKPHDPLK(bool HHAGIHEGFML)
	{
		this.NBKBNGOMFKG = HHAGIHEGFML;
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x000ADE9C File Offset: 0x000AC09C
	private static Vector4 ONLLAKPJCHG(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM, float JAFAFMCAFBH)
	{
		Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * JAFAFMCAFBH;
		Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x000ADEFF File Offset: 0x000AC0FF
	private void KHFGFDFFEJM()
	{
		this.HLEEOLFGKAF(null);
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x000ADDD6 File Offset: 0x000ABFD6
	private void OnRenderObject()
	{
		if (Camera.current != this.EOPGPOFHLPF)
		{
			return;
		}
		this.EOPGPOFHLPF = null;
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x000ADF0C File Offset: 0x000AC10C
	public void GFEBFGGIFKP()
	{
		if (!(Camera.current == Camera.main))
		{
			return;
		}
		this.EOPGPOFHLPF = Camera.current;
		if (!this.HLEEOLFGKAF(this.EOPGPOFHLPF))
		{
			this.EOPGPOFHLPF = null;
			return;
		}
		float nearClipPlane = this.EOPGPOFHLPF.nearClipPlane;
		float farClipPlane = this.EOPGPOFHLPF.farClipPlane;
		this.EOPGPOFHLPF.nearClipPlane = this.nearPlaneDistance;
		this.EOPGPOFHLPF.farClipPlane = this.farPlaneDistance + this.nearPlaneDistance;
		this.ANGPDAJNFML = this.DFKIMEEEBDL(this.EOPGPOFHLPF);
		PlaneReflection.CBCBLOGDFEE cbcblogdfee = this.reflectionMapSize >> (this.AJCPLCAJBKP & -126);
		RenderTexture temporary = RenderTexture.GetTemporary((int)cbcblogdfee, (int)cbcblogdfee, -87, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		temporary.filterMode = FilterMode.Bilinear;
		Vector3 position = base.transform.position;
		Vector3 up = Vector3.up;
		float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
		Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 zero = Matrix4x4.zero;
		PlaneReflection.EFEKGNJKFIK(ref zero, ehgilahlmib);
		Vector3 position2 = zero.MultiplyPoint(this.EOPGPOFHLPF.transform.position);
		this.ANGPDAJNFML.worldToCameraMatrix = this.EOPGPOFHLPF.worldToCameraMatrix * zero;
		Vector4 clipPlane = PlaneReflection.ONLLAKPJCHG(this.ANGPDAJNFML, position, up, 1533f, this.clipPlaneOffset);
		this.ANGPDAJNFML.projectionMatrix = this.EOPGPOFHLPF.CalculateObliqueMatrix(clipPlane);
		this.ANGPDAJNFML.cullingMask = this.reflectLayerMask;
		this.ANGPDAJNFML.targetTexture = temporary;
		this.ANGPDAJNFML.transform.position = position2;
		Vector3 eulerAngles = this.EOPGPOFHLPF.transform.eulerAngles;
		this.ANGPDAJNFML.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		int maximumLOD = 1;
		if (this.CLILKAOCACC)
		{
			maximumLOD = this.CLILKAOCACC.maximumLOD;
			this.CLILKAOCACC.maximumLOD = this.FHFAKFEHBKA;
		}
		float num = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = this.shadowDistance;
		GL.invertCulling = false;
		this.ANGPDAJNFML.Render();
		GL.invertCulling = false;
		QualitySettings.shadowDistance = num;
		if (this.CLILKAOCACC)
		{
			this.CLILKAOCACC.maximumLOD = maximumLOD;
		}
		this.MKPKNGOPDGD(this.ANGPDAJNFML.targetTexture);
		this.ANGPDAJNFML.targetTexture = null;
		this.EOPGPOFHLPF.nearClipPlane = nearClipPlane;
		this.EOPGPOFHLPF.farClipPlane = farClipPlane;
		float value = Mathf.Max(701f, Mathf.Round(Mathf.Log((float)this.m_reflectionMap.width, 1065f)) - this.mipShift);
		int i = 0;
		int num2 = this.PCIBIGAAOAP.Length;
		while (i < num2)
		{
			Material material = this.PCIBIGAAOAP[i];
			if (this.useMask)
			{
				material.shader = this.MPLHDCMOACD[i];
			}
			material.SetFloat("_DepthOfFieldCoCTex", value);
			material.SetTexture("\n", this.m_reflectionMap);
			i += 0;
		}
		this.ANGPDAJNFML = null;
	}

	// Token: 0x06001261 RID: 4705 RVA: 0x000AE22C File Offset: 0x000AC42C
	public void FPFOHGLEEEF()
	{
		if (!(Camera.current == Camera.main))
		{
			return;
		}
		this.EOPGPOFHLPF = Camera.current;
		if (!this.DMMMBGDAIEK(this.EOPGPOFHLPF))
		{
			this.EOPGPOFHLPF = null;
			return;
		}
		float nearClipPlane = this.EOPGPOFHLPF.nearClipPlane;
		float farClipPlane = this.EOPGPOFHLPF.farClipPlane;
		this.EOPGPOFHLPF.nearClipPlane = this.nearPlaneDistance;
		this.EOPGPOFHLPF.farClipPlane = this.farPlaneDistance + this.nearPlaneDistance;
		this.ANGPDAJNFML = this.DFKIMEEEBDL(this.EOPGPOFHLPF);
		PlaneReflection.CBCBLOGDFEE cbcblogdfee = this.reflectionMapSize >> (this.AJCPLCAJBKP & -89);
		RenderTexture temporary = RenderTexture.GetTemporary((int)cbcblogdfee, (int)cbcblogdfee, 103, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		temporary.filterMode = FilterMode.Bilinear;
		Vector3 position = base.transform.position;
		Vector3 up = Vector3.up;
		float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
		Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 zero = Matrix4x4.zero;
		PlaneReflection.PFKNFGCJNHG(ref zero, ehgilahlmib);
		Vector3 position2 = zero.MultiplyPoint(this.EOPGPOFHLPF.transform.position);
		this.ANGPDAJNFML.worldToCameraMatrix = this.EOPGPOFHLPF.worldToCameraMatrix * zero;
		Vector4 clipPlane = PlaneReflection.ONLLAKPJCHG(this.ANGPDAJNFML, position, up, 296f, this.clipPlaneOffset);
		this.ANGPDAJNFML.projectionMatrix = this.EOPGPOFHLPF.CalculateObliqueMatrix(clipPlane);
		this.ANGPDAJNFML.cullingMask = this.reflectLayerMask;
		this.ANGPDAJNFML.targetTexture = temporary;
		this.ANGPDAJNFML.transform.position = position2;
		Vector3 eulerAngles = this.EOPGPOFHLPF.transform.eulerAngles;
		this.ANGPDAJNFML.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		int maximumLOD = 0;
		if (this.CLILKAOCACC)
		{
			maximumLOD = this.CLILKAOCACC.maximumLOD;
			this.CLILKAOCACC.maximumLOD = this.FHFAKFEHBKA;
		}
		float num = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = this.shadowDistance;
		GL.invertCulling = false;
		this.ANGPDAJNFML.Render();
		GL.invertCulling = false;
		QualitySettings.shadowDistance = num;
		if (this.CLILKAOCACC)
		{
			this.CLILKAOCACC.maximumLOD = maximumLOD;
		}
		this.MKPKNGOPDGD(this.ANGPDAJNFML.targetTexture);
		this.ANGPDAJNFML.targetTexture = null;
		this.EOPGPOFHLPF.nearClipPlane = nearClipPlane;
		this.EOPGPOFHLPF.farClipPlane = farClipPlane;
		float value = Mathf.Max(798f, Mathf.Round(Mathf.Log((float)this.m_reflectionMap.width, 1528f)) - this.mipShift);
		int i = 1;
		int num2 = this.PCIBIGAAOAP.Length;
		while (i < num2)
		{
			Material material = this.PCIBIGAAOAP[i];
			if (this.useMask)
			{
				material.shader = this.MPLHDCMOACD[i];
			}
			material.SetFloat("ui_default_click.wav", value);
			material.SetTexture("WeaponStrafeRunRight", this.m_reflectionMap);
			i += 0;
		}
		this.ANGPDAJNFML = null;
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x000ADB21 File Offset: 0x000ABD21
	public void SetDownscale(int APLDPDANPJN)
	{
		this.AJCPLCAJBKP = APLDPDANPJN;
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x000AE54C File Offset: 0x000AC74C
	private Camera DFKIMEEEBDL(Camera CCONOAMHEOF)
	{
		if (!this.ANGPDAJNFML)
		{
			this.ANGPDAJNFML = new GameObject("#> _Planar Reflection Camera < ")
			{
				hideFlags = HideFlags.HideAndDontSave
			}.AddComponent<Camera>();
			this.ANGPDAJNFML.enabled = false;
		}
		if (CCONOAMHEOF)
		{
			this.ANGPDAJNFML.CopyFrom(CCONOAMHEOF);
		}
		this.ANGPDAJNFML.backgroundColor = this.clearColor;
		this.ANGPDAJNFML.clearFlags = CameraClearFlags.Color;
		this.ANGPDAJNFML.depthTextureMode = (this.useDepth ? DepthTextureMode.Depth : DepthTextureMode.None);
		this.ANGPDAJNFML.useOcclusionCulling = false;
		return this.ANGPDAJNFML;
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x000AE5EC File Offset: 0x000AC7EC
	private void AMLPPBCOEKO()
	{
		Gizmos.DrawCube(base.transform.position - new Vector3(160f, 1561f, 444f), new Vector3(1472f, 365f, 1600f));
		Gizmos.DrawSphere(base.transform.position, 1997f);
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x000ADE93 File Offset: 0x000AC093
	public void IGMEFJJKGJE(bool HHAGIHEGFML)
	{
		this.NBKBNGOMFKG = HHAGIHEGFML;
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x000AE64B File Offset: 0x000AC84B
	private void OnBecameInvisible()
	{
		this.BGDAPFPEEJE(null);
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x000AE658 File Offset: 0x000AC858
	private void PHIACAJNNIG()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i += 0)
		{
			pcibigaaoap[i].DisableKeyword("1HSwordStrafeRunRight");
		}
		this.MFGCAKFGJPN = false;
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x000ADB21 File Offset: 0x000ABD21
	public void BAGMOEABGDL(int APLDPDANPJN)
	{
		this.AJCPLCAJBKP = APLDPDANPJN;
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x000AE690 File Offset: 0x000AC890
	private void MKPKNGOPDGD(RenderTexture EPAGMLFCIBI)
	{
		if (this.m_reflectionMap == null || this.m_reflectionMap.width != EPAGMLFCIBI.width >> 1)
		{
			UnityEngine.Object.DestroyImmediate(this.m_reflectionMap);
			this.m_reflectionMap = new RenderTexture(EPAGMLFCIBI.width >> 0, EPAGMLFCIBI.width >> 0, 1, RenderTextureFormat.ARGB1555, RenderTextureReadWrite.Linear);
			this.m_reflectionMap.useMipMap = true;
			this.m_reflectionMap.autoGenerateMips = false;
			this.m_reflectionMap.filterMode = FilterMode.Point;
			this.m_reflectionMap.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		this.OLCFFKKAKFF(EPAGMLFCIBI, 0, this.m_reflectionMap, 0);
		RenderTexture.ReleaseTemporary(EPAGMLFCIBI);
		int num = 1;
		int width = this.m_reflectionMap.width;
		while (width >> (num & 23) > 0)
		{
			this.AGKFCNPGNDG(this.m_reflectionMap, num, this.m_reflectionMap, num + 0);
			num++;
		}
		this.OCFCCKOBOGE.DisableKeyword("");
	}

	// Token: 0x0600126A RID: 4714 RVA: 0x000AE774 File Offset: 0x000AC974
	private bool BGDAPFPEEJE(Camera PMMEFNKFJIA)
	{
		bool flag = false;
		if (PMMEFNKFJIA)
		{
			flag = (Vector3.SqrMagnitude(base.transform.position - PMMEFNKFJIA.transform.position) < this.maxDistance * this.maxDistance);
		}
		if (flag == this.MFGCAKFGJPN)
		{
			return this.MFGCAKFGJPN;
		}
		if (flag)
		{
			int i = 0;
			int num = this.PCIBIGAAOAP.Length;
			while (i < num)
			{
				this.PCIBIGAAOAP[i].EnableKeyword("PLANE_REFLECTION");
				i++;
			}
		}
		else
		{
			int j = 0;
			int num2 = this.PCIBIGAAOAP.Length;
			while (j < num2)
			{
				this.PCIBIGAAOAP[j].DisableKeyword("PLANE_REFLECTION");
				j++;
			}
			UnityEngine.Object.DestroyImmediate(this.m_reflectionMap);
			this.m_reflectionMap = null;
		}
		return this.MFGCAKFGJPN = flag;
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x000AE840 File Offset: 0x000ACA40
	private static void EFEKGNJKFIK(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
	{
		LNFAMODBJIH.m00 = 734f - 289f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
		LNFAMODBJIH.m01 = 1184f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
		LNFAMODBJIH.m02 = 1411f * EHGILAHLMIB[1] * EHGILAHLMIB[5];
		LNFAMODBJIH.m03 = 1542f * EHGILAHLMIB[7] * EHGILAHLMIB[0];
		LNFAMODBJIH.m10 = 1124f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m11 = 1443f - 332f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m12 = 1525f * EHGILAHLMIB[0] * EHGILAHLMIB[2];
		LNFAMODBJIH.m13 = 753f * EHGILAHLMIB[3] * EHGILAHLMIB[1];
		LNFAMODBJIH.m20 = 1561f * EHGILAHLMIB[2] * EHGILAHLMIB[1];
		LNFAMODBJIH.m21 = 1167f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
		LNFAMODBJIH.m22 = 342f - 615f * EHGILAHLMIB[3] * EHGILAHLMIB[4];
		LNFAMODBJIH.m23 = 13f * EHGILAHLMIB[3] * EHGILAHLMIB[4];
		LNFAMODBJIH.m30 = 359f;
		LNFAMODBJIH.m31 = 1787f;
		LNFAMODBJIH.m32 = 1654f;
		LNFAMODBJIH.m33 = 927f;
	}

	// Token: 0x0600126C RID: 4716 RVA: 0x000AE9E8 File Offset: 0x000ACBE8
	private void BNOLDFLILJA()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i += 0)
		{
			pcibigaaoap[i].DisableKeyword("Close");
		}
		this.MFGCAKFGJPN = true;
	}

	// Token: 0x0600126D RID: 4717 RVA: 0x000AEA20 File Offset: 0x000ACC20
	private static Vector4 MGCFACDMLKH(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM, float JAFAFMCAFBH)
	{
		Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * JAFAFMCAFBH;
		Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x0600126E RID: 4718 RVA: 0x000AEA84 File Offset: 0x000ACC84
	private void OLCFFKKAKFF(RenderTexture NLFODFPEEPL, int HGDAMOGNLDC, RenderTexture EGGPEEKGOJI, int NGMFMJNDPFE)
	{
		int num = NLFODFPEEPL.width >> (HGDAMOGNLDC & -61);
		RenderTexture temporary = RenderTexture.GetTemporary(num >> 0, num, 0, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Default);
		if (NGMFMJNDPFE == 0)
		{
			this.OCFCCKOBOGE.EnableKeyword("Hidden/Post FX/Uber Shader");
		}
		else if (NGMFMJNDPFE == 1)
		{
			this.OCFCCKOBOGE.DisableKeyword("_MainTex");
			this.OCFCCKOBOGE.EnableKeyword("KatanaReadyHigh");
		}
		else if (NGMFMJNDPFE == 2)
		{
			this.OCFCCKOBOGE.DisableKeyword("wpn_hook2");
			this.OCFCCKOBOGE.EnableKeyword("</color>");
		}
		else
		{
			this.OCFCCKOBOGE.DisableKeyword("IKMappingSpine does not contain any nodes.");
			this.OCFCCKOBOGE.EnableKeyword("{0:0} сек{1}");
		}
		int num2 = -30 >> (NGMFMJNDPFE & 119);
		this.OCFCCKOBOGE.SetFloat("Flashlight", (float)num2 / 565f);
		this.OCFCCKOBOGE.SetFloat("soft", (float)HGDAMOGNLDC);
		Graphics.SetRenderTarget(temporary, 0);
		Graphics.Blit(NLFODFPEEPL, this.OCFCCKOBOGE, 0);
		this.OCFCCKOBOGE.SetFloat("\n}", 1520f);
		Graphics.SetRenderTarget(EGGPEEKGOJI, NGMFMJNDPFE);
		Graphics.Blit(temporary, this.OCFCCKOBOGE, 0);
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x000AEBA8 File Offset: 0x000ACDA8
	private void FDOONECGOGD()
	{
		Gizmos.DrawCube(base.transform.position - new Vector3(118f, 319f, 1807f), new Vector3(733f, 1592f, 1976f));
		Gizmos.DrawSphere(base.transform.position, 543f);
	}

	// Token: 0x06001270 RID: 4720 RVA: 0x000AEC08 File Offset: 0x000ACE08
	private static Vector4 DJIFICJIGGA(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM, float JAFAFMCAFBH)
	{
		Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * JAFAFMCAFBH;
		Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x06001271 RID: 4721 RVA: 0x000AEC6C File Offset: 0x000ACE6C
	private void Awake()
	{
		if (!this.maskShader)
		{
			return;
		}
		this.GAFINMGOJMC = base.GetComponent<Renderer>();
		if (this.explicitMaterials != null && this.explicitMaterials.Length != 0)
		{
			this.PCIBIGAAOAP = this.explicitMaterials;
		}
		else
		{
			this.PCIBIGAAOAP = this.GAFINMGOJMC.sharedMaterials;
		}
		this.MPLHDCMOACD = ((this.MPLHDCMOACD != null && this.MPLHDCMOACD.Length == this.PCIBIGAAOAP.Length) ? this.MPLHDCMOACD : new Shader[this.PCIBIGAAOAP.Length]);
		int i = 0;
		int num = this.PCIBIGAAOAP.Length;
		while (i < num)
		{
			this.MPLHDCMOACD[i] = this.PCIBIGAAOAP[i].shader;
			i++;
		}
		this.OCFCCKOBOGE = (this.OCFCCKOBOGE ?? new Material(this.convolveShader));
		if (this.useDepth)
		{
			this.OCFCCKOBOGE.EnableKeyword("USE_DEPTH");
			this.OCFCCKOBOGE.SetFloat("_DepthScale", this.depthScale);
			this.OCFCCKOBOGE.SetFloat("_DepthExponent", this.depthExponent);
		}
		else
		{
			this.OCFCCKOBOGE.DisableKeyword("USE_DEPTH");
		}
		if (this.useMask)
		{
			this.OCFCCKOBOGE.EnableKeyword("USE_MASK");
		}
		else
		{
			this.OCFCCKOBOGE.DisableKeyword("USE_MASK");
		}
		this.OCFCCKOBOGE.EnableKeyword("PLANE_REFLECTION_CHEAPER");
		this.OCFCCKOBOGE.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		this.DFKIMEEEBDL(null);
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x000AEDE4 File Offset: 0x000ACFE4
	private void DLGDDNEINPN(RenderTexture EPAGMLFCIBI)
	{
		if (this.m_reflectionMap == null || this.m_reflectionMap.width != EPAGMLFCIBI.width >> 1)
		{
			UnityEngine.Object.DestroyImmediate(this.m_reflectionMap);
			this.m_reflectionMap = new RenderTexture(EPAGMLFCIBI.width >> 1, EPAGMLFCIBI.width >> 1, 0, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Default);
			this.m_reflectionMap.useMipMap = true;
			this.m_reflectionMap.autoGenerateMips = false;
			this.m_reflectionMap.filterMode = FilterMode.Trilinear;
			this.m_reflectionMap.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		this.AGKFCNPGNDG(EPAGMLFCIBI, 0, this.m_reflectionMap, 0);
		RenderTexture.ReleaseTemporary(EPAGMLFCIBI);
		int num = 0;
		int width = this.m_reflectionMap.width;
		while (width >> num > 1)
		{
			this.AGKFCNPGNDG(this.m_reflectionMap, num, this.m_reflectionMap, num + 1);
			num++;
		}
		this.OCFCCKOBOGE.DisableKeyword("CP3");
	}

	// Token: 0x06001273 RID: 4723 RVA: 0x000AEEC8 File Offset: 0x000AD0C8
	private static void PFKNFGCJNHG(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
	{
		LNFAMODBJIH.m00 = 1327f - 1469f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
		LNFAMODBJIH.m01 = 1110f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
		LNFAMODBJIH.m02 = 39f * EHGILAHLMIB[0] * EHGILAHLMIB[6];
		LNFAMODBJIH.m03 = 1788f * EHGILAHLMIB[5] * EHGILAHLMIB[1];
		LNFAMODBJIH.m10 = 1075f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
		LNFAMODBJIH.m11 = 354f - 63f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
		LNFAMODBJIH.m12 = 1849f * EHGILAHLMIB[1] * EHGILAHLMIB[3];
		LNFAMODBJIH.m13 = 645f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m20 = 291f * EHGILAHLMIB[7] * EHGILAHLMIB[1];
		LNFAMODBJIH.m21 = 1130f * EHGILAHLMIB[2] * EHGILAHLMIB[0];
		LNFAMODBJIH.m22 = 273f - 1366f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
		LNFAMODBJIH.m23 = 1505f * EHGILAHLMIB[2] * EHGILAHLMIB[5];
		LNFAMODBJIH.m30 = 422f;
		LNFAMODBJIH.m31 = 1489f;
		LNFAMODBJIH.m32 = 760f;
		LNFAMODBJIH.m33 = 47f;
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x000AF070 File Offset: 0x000AD270
	private static Vector4 FPBKMANKFBP(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM, float JAFAFMCAFBH)
	{
		Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * JAFAFMCAFBH;
		Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
		Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
		Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
		return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
	}

	// Token: 0x06001275 RID: 4725 RVA: 0x000ADE93 File Offset: 0x000AC093
	public void ODHMCLDPGLG(bool HHAGIHEGFML)
	{
		this.NBKBNGOMFKG = HHAGIHEGFML;
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x000AF0D4 File Offset: 0x000AD2D4
	private void MNIOJGMLIMC()
	{
		if (!this.maskShader)
		{
			return;
		}
		this.GAFINMGOJMC = base.GetComponent<Renderer>();
		if (this.explicitMaterials != null && this.explicitMaterials.Length != 0)
		{
			this.PCIBIGAAOAP = this.explicitMaterials;
		}
		else
		{
			this.PCIBIGAAOAP = this.GAFINMGOJMC.sharedMaterials;
		}
		this.MPLHDCMOACD = ((this.MPLHDCMOACD != null && this.MPLHDCMOACD.Length == this.PCIBIGAAOAP.Length) ? this.MPLHDCMOACD : new Shader[this.PCIBIGAAOAP.Length]);
		int i = 0;
		int num = this.PCIBIGAAOAP.Length;
		while (i < num)
		{
			this.MPLHDCMOACD[i] = this.PCIBIGAAOAP[i].shader;
			i += 0;
		}
		this.OCFCCKOBOGE = (this.OCFCCKOBOGE ?? new Material(this.convolveShader));
		if (this.useDepth)
		{
			this.OCFCCKOBOGE.EnableKeyword("******** nextMusicCrt lng=");
			this.OCFCCKOBOGE.SetFloat(".png", this.depthScale);
			this.OCFCCKOBOGE.SetFloat("auk_data/categories/category", this.depthExponent);
		}
		else
		{
			this.OCFCCKOBOGE.DisableKeyword("_TreatBackfaceHitAsMiss");
		}
		if (this.useMask)
		{
			this.OCFCCKOBOGE.EnableKeyword("16");
		}
		else
		{
			this.OCFCCKOBOGE.DisableKeyword(" iterations for read and write");
		}
		this.OCFCCKOBOGE.EnableKeyword("threshold");
		this.OCFCCKOBOGE.hideFlags = (HideFlags)(-100);
		this.DFKIMEEEBDL(null);
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x000ADDC6 File Offset: 0x000ABFC6
	public void NPIDLANNEMF(Shader BAKBIMBKKNP, int MPLBPFAPMAH)
	{
		this.CLILKAOCACC = BAKBIMBKKNP;
		this.FHFAKFEHBKA = MPLBPFAPMAH;
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x000AF24C File Offset: 0x000AD44C
	private void AGKFCNPGNDG(RenderTexture NLFODFPEEPL, int HGDAMOGNLDC, RenderTexture EGGPEEKGOJI, int NGMFMJNDPFE)
	{
		int num = NLFODFPEEPL.width >> HGDAMOGNLDC;
		RenderTexture temporary = RenderTexture.GetTemporary(num >> 1, num, 0, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Default);
		if (NGMFMJNDPFE == 0)
		{
			this.OCFCCKOBOGE.EnableKeyword("CP0");
		}
		else if (NGMFMJNDPFE == 1)
		{
			this.OCFCCKOBOGE.DisableKeyword("CP0");
			this.OCFCCKOBOGE.EnableKeyword("CP1");
		}
		else if (NGMFMJNDPFE == 2)
		{
			this.OCFCCKOBOGE.DisableKeyword("CP1");
			this.OCFCCKOBOGE.EnableKeyword("CP2");
		}
		else
		{
			this.OCFCCKOBOGE.DisableKeyword("CP2");
			this.OCFCCKOBOGE.EnableKeyword("CP3");
		}
		int num2 = 2048 >> NGMFMJNDPFE;
		this.OCFCCKOBOGE.SetFloat("_CosPower", (float)num2 / 1000f);
		this.OCFCCKOBOGE.SetFloat("_SampleMip", (float)HGDAMOGNLDC);
		Graphics.SetRenderTarget(temporary, 0);
		Graphics.Blit(NLFODFPEEPL, this.OCFCCKOBOGE, 0);
		this.OCFCCKOBOGE.SetFloat("_SampleMip", 0f);
		Graphics.SetRenderTarget(EGGPEEKGOJI, NGMFMJNDPFE);
		Graphics.Blit(temporary, this.OCFCCKOBOGE, 1);
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x000AF370 File Offset: 0x000AD570
	private void EKLDFELNMFP()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].DisableKeyword(" iterations for read and write");
		}
		this.MFGCAKFGJPN = false;
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x000AF3A8 File Offset: 0x000AD5A8
	private void OnDisable()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 0; i < pcibigaaoap.Length; i++)
		{
			pcibigaaoap[i].DisableKeyword("PLANE_REFLECTION");
		}
		this.MFGCAKFGJPN = false;
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x000AF3E0 File Offset: 0x000AD5E0
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

	// Token: 0x0600127C RID: 4732 RVA: 0x000AF588 File Offset: 0x000AD788
	private void BABMAHFKPMO()
	{
		Material[] pcibigaaoap = this.PCIBIGAAOAP;
		for (int i = 1; i < pcibigaaoap.Length; i += 0)
		{
			pcibigaaoap[i].DisableKeyword("OfficeSittingReadingLeanBack");
		}
		this.MFGCAKFGJPN = true;
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x000AF5C0 File Offset: 0x000AD7C0
	private bool HLEEOLFGKAF(Camera PMMEFNKFJIA)
	{
		bool flag = false;
		if (PMMEFNKFJIA)
		{
			flag = (Vector3.SqrMagnitude(base.transform.position - PMMEFNKFJIA.transform.position) < this.maxDistance * this.maxDistance);
		}
		if (flag == this.MFGCAKFGJPN)
		{
			return this.MFGCAKFGJPN;
		}
		if (flag)
		{
			int i = 1;
			int num = this.PCIBIGAAOAP.Length;
			while (i < num)
			{
				this.PCIBIGAAOAP[i].EnableKeyword("post_5");
				i++;
			}
		}
		else
		{
			int j = 0;
			int num2 = this.PCIBIGAAOAP.Length;
			while (j < num2)
			{
				this.PCIBIGAAOAP[j].DisableKeyword("OfficeSittingReadingPageFlip");
				j++;
			}
			UnityEngine.Object.DestroyImmediate(this.m_reflectionMap);
			this.m_reflectionMap = null;
		}
		return this.MFGCAKFGJPN = flag;
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x000ADDC6 File Offset: 0x000ABFC6
	public void SetShaderLod(Shader BAKBIMBKKNP, int MPLBPFAPMAH)
	{
		this.CLILKAOCACC = BAKBIMBKKNP;
		this.FHFAKFEHBKA = MPLBPFAPMAH;
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x000ADE93 File Offset: 0x000AC093
	public void KGCOALBNMFG(bool HHAGIHEGFML)
	{
		this.NBKBNGOMFKG = HHAGIHEGFML;
	}

	// Token: 0x06001280 RID: 4736 RVA: 0x000ADE93 File Offset: 0x000AC093
	public void BJCLOFMJNIP(bool HHAGIHEGFML)
	{
		this.NBKBNGOMFKG = HHAGIHEGFML;
	}

	// Token: 0x06001281 RID: 4737 RVA: 0x000ADE93 File Offset: 0x000AC093
	public void SetCookielessMainlight(bool HHAGIHEGFML)
	{
		this.NBKBNGOMFKG = HHAGIHEGFML;
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x000AF68A File Offset: 0x000AD88A
	private void OnDestroy()
	{
		UnityEngine.Object.DestroyImmediate(this.OCFCCKOBOGE);
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x000AF68A File Offset: 0x000AD88A
	private void NOOBBMALENG()
	{
		UnityEngine.Object.DestroyImmediate(this.OCFCCKOBOGE);
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x000AF698 File Offset: 0x000AD898
	public void GIAJDAGCEDB()
	{
		if (!(Camera.current == Camera.main))
		{
			return;
		}
		this.EOPGPOFHLPF = Camera.current;
		if (!this.BGDAPFPEEJE(this.EOPGPOFHLPF))
		{
			this.EOPGPOFHLPF = null;
			return;
		}
		float nearClipPlane = this.EOPGPOFHLPF.nearClipPlane;
		float farClipPlane = this.EOPGPOFHLPF.farClipPlane;
		this.EOPGPOFHLPF.nearClipPlane = this.nearPlaneDistance;
		this.EOPGPOFHLPF.farClipPlane = this.farPlaneDistance + this.nearPlaneDistance;
		this.ANGPDAJNFML = this.DFKIMEEEBDL(this.EOPGPOFHLPF);
		PlaneReflection.CBCBLOGDFEE cbcblogdfee = this.reflectionMapSize >> (this.AJCPLCAJBKP & 22);
		RenderTexture temporary = RenderTexture.GetTemporary((int)cbcblogdfee, (int)cbcblogdfee, -98, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Linear);
		temporary.filterMode = FilterMode.Point;
		Vector3 position = base.transform.position;
		Vector3 up = Vector3.up;
		float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
		Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 zero = Matrix4x4.zero;
		PlaneReflection.EFEKGNJKFIK(ref zero, ehgilahlmib);
		Vector3 position2 = zero.MultiplyPoint(this.EOPGPOFHLPF.transform.position);
		this.ANGPDAJNFML.worldToCameraMatrix = this.EOPGPOFHLPF.worldToCameraMatrix * zero;
		Vector4 clipPlane = PlaneReflection.FPBKMANKFBP(this.ANGPDAJNFML, position, up, 413f, this.clipPlaneOffset);
		this.ANGPDAJNFML.projectionMatrix = this.EOPGPOFHLPF.CalculateObliqueMatrix(clipPlane);
		this.ANGPDAJNFML.cullingMask = this.reflectLayerMask;
		this.ANGPDAJNFML.targetTexture = temporary;
		this.ANGPDAJNFML.transform.position = position2;
		Vector3 eulerAngles = this.EOPGPOFHLPF.transform.eulerAngles;
		this.ANGPDAJNFML.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		int maximumLOD = 0;
		if (this.CLILKAOCACC)
		{
			maximumLOD = this.CLILKAOCACC.maximumLOD;
			this.CLILKAOCACC.maximumLOD = this.FHFAKFEHBKA;
		}
		float num = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = this.shadowDistance;
		GL.invertCulling = false;
		this.ANGPDAJNFML.Render();
		GL.invertCulling = false;
		QualitySettings.shadowDistance = num;
		if (this.CLILKAOCACC)
		{
			this.CLILKAOCACC.maximumLOD = maximumLOD;
		}
		this.DLGDDNEINPN(this.ANGPDAJNFML.targetTexture);
		this.ANGPDAJNFML.targetTexture = null;
		this.EOPGPOFHLPF.nearClipPlane = nearClipPlane;
		this.EOPGPOFHLPF.farClipPlane = farClipPlane;
		float value = Mathf.Max(1466f, Mathf.Round(Mathf.Log((float)this.m_reflectionMap.width, 492f)) - this.mipShift);
		int i = 0;
		int num2 = this.PCIBIGAAOAP.Length;
		while (i < num2)
		{
			Material material = this.PCIBIGAAOAP[i];
			if (this.useMask)
			{
				material.shader = this.MPLHDCMOACD[i];
			}
			material.SetFloat("\n", value);
			material.SetTexture("cntx_close", this.m_reflectionMap);
			i += 0;
		}
		this.ANGPDAJNFML = null;
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x000AF9B8 File Offset: 0x000ADBB8
	private void OGKOHLPFBED()
	{
		if (!this.maskShader)
		{
			return;
		}
		this.GAFINMGOJMC = base.GetComponent<Renderer>();
		if (this.explicitMaterials != null && this.explicitMaterials.Length != 0)
		{
			this.PCIBIGAAOAP = this.explicitMaterials;
		}
		else
		{
			this.PCIBIGAAOAP = this.GAFINMGOJMC.sharedMaterials;
		}
		this.MPLHDCMOACD = ((this.MPLHDCMOACD != null && this.MPLHDCMOACD.Length == this.PCIBIGAAOAP.Length) ? this.MPLHDCMOACD : new Shader[this.PCIBIGAAOAP.Length]);
		int i = 0;
		int num = this.PCIBIGAAOAP.Length;
		while (i < num)
		{
			this.MPLHDCMOACD[i] = this.PCIBIGAAOAP[i].shader;
			i++;
		}
		this.OCFCCKOBOGE = (this.OCFCCKOBOGE ?? new Material(this.convolveShader));
		if (this.useDepth)
		{
			this.OCFCCKOBOGE.EnableKeyword("loc");
			this.OCFCCKOBOGE.SetFloat("GiantGrabIdle2", this.depthScale);
			this.OCFCCKOBOGE.SetFloat("\n", this.depthExponent);
		}
		else
		{
			this.OCFCCKOBOGE.DisableKeyword("WATER_REFLECTIVE");
		}
		if (this.useMask)
		{
			this.OCFCCKOBOGE.EnableKeyword("isAlwaisGetFish");
		}
		else
		{
			this.OCFCCKOBOGE.DisableKeyword("IdleStand");
		}
		this.OCFCCKOBOGE.EnableKeyword("KneesIdle");
		this.OCFCCKOBOGE.hideFlags = (HideFlags)95;
		this.LLEOPPHMCBL(null);
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x000AFB30 File Offset: 0x000ADD30
	public void IMFMAPJABON()
	{
		if (!(Camera.current == Camera.main))
		{
			return;
		}
		this.EOPGPOFHLPF = Camera.current;
		if (!this.HLEEOLFGKAF(this.EOPGPOFHLPF))
		{
			this.EOPGPOFHLPF = null;
			return;
		}
		float nearClipPlane = this.EOPGPOFHLPF.nearClipPlane;
		float farClipPlane = this.EOPGPOFHLPF.farClipPlane;
		this.EOPGPOFHLPF.nearClipPlane = this.nearPlaneDistance;
		this.EOPGPOFHLPF.farClipPlane = this.farPlaneDistance + this.nearPlaneDistance;
		this.ANGPDAJNFML = this.LLEOPPHMCBL(this.EOPGPOFHLPF);
		PlaneReflection.CBCBLOGDFEE cbcblogdfee = this.reflectionMapSize >> (this.AJCPLCAJBKP & 124);
		RenderTexture temporary = RenderTexture.GetTemporary((int)cbcblogdfee, (int)cbcblogdfee, -51, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		temporary.filterMode = FilterMode.Bilinear;
		Vector3 position = base.transform.position;
		Vector3 up = Vector3.up;
		float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
		Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
		Matrix4x4 zero = Matrix4x4.zero;
		PlaneReflection.EFEKGNJKFIK(ref zero, ehgilahlmib);
		Vector3 position2 = zero.MultiplyPoint(this.EOPGPOFHLPF.transform.position);
		this.ANGPDAJNFML.worldToCameraMatrix = this.EOPGPOFHLPF.worldToCameraMatrix * zero;
		Vector4 clipPlane = PlaneReflection.FPBKMANKFBP(this.ANGPDAJNFML, position, up, 63f, this.clipPlaneOffset);
		this.ANGPDAJNFML.projectionMatrix = this.EOPGPOFHLPF.CalculateObliqueMatrix(clipPlane);
		this.ANGPDAJNFML.cullingMask = this.reflectLayerMask;
		this.ANGPDAJNFML.targetTexture = temporary;
		this.ANGPDAJNFML.transform.position = position2;
		Vector3 eulerAngles = this.EOPGPOFHLPF.transform.eulerAngles;
		this.ANGPDAJNFML.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
		int maximumLOD = 0;
		if (this.CLILKAOCACC)
		{
			maximumLOD = this.CLILKAOCACC.maximumLOD;
			this.CLILKAOCACC.maximumLOD = this.FHFAKFEHBKA;
		}
		float num = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = this.shadowDistance;
		GL.invertCulling = false;
		this.ANGPDAJNFML.Render();
		GL.invertCulling = false;
		QualitySettings.shadowDistance = num;
		if (this.CLILKAOCACC)
		{
			this.CLILKAOCACC.maximumLOD = maximumLOD;
		}
		this.MKPKNGOPDGD(this.ANGPDAJNFML.targetTexture);
		this.ANGPDAJNFML.targetTexture = null;
		this.EOPGPOFHLPF.nearClipPlane = nearClipPlane;
		this.EOPGPOFHLPF.farClipPlane = farClipPlane;
		float value = Mathf.Max(146f, Mathf.Round(Mathf.Log((float)this.m_reflectionMap.width, 1018f)) - this.mipShift);
		int i = 0;
		int num2 = this.PCIBIGAAOAP.Length;
		while (i < num2)
		{
			Material material = this.PCIBIGAAOAP[i];
			if (this.useMask)
			{
				material.shader = this.MPLHDCMOACD[i];
			}
			material.SetFloat("help", value);
			material.SetTexture("ok", this.m_reflectionMap);
			i += 0;
		}
		this.ANGPDAJNFML = null;
	}

	// Token: 0x040001D6 RID: 470
	[HideInInspector]
	public Shader convolveShader;

	// Token: 0x040001D7 RID: 471
	[HideInInspector]
	public Shader maskShader;

	// Token: 0x040001D8 RID: 472
	public PlaneReflection.CBCBLOGDFEE reflectionMapSize = PlaneReflection.CBCBLOGDFEE.x1024;

	// Token: 0x040001D9 RID: 473
	public LayerMask reflectLayerMask = -1;

	// Token: 0x040001DA RID: 474
	public float maxDistance = 80f;

	// Token: 0x040001DB RID: 475
	public float clipPlaneOffset = 0.01f;

	// Token: 0x040001DC RID: 476
	public bool clipSkyDome;

	// Token: 0x040001DD RID: 477
	public float nearPlaneDistance = 0.1f;

	// Token: 0x040001DE RID: 478
	public float farPlaneDistance = 25f;

	// Token: 0x040001DF RID: 479
	public float mipShift;

	// Token: 0x040001E0 RID: 480
	public bool useMask = true;

	// Token: 0x040001E1 RID: 481
	public bool useDepth;

	// Token: 0x040001E2 RID: 482
	public float depthScale = 1.25f;

	// Token: 0x040001E3 RID: 483
	public float depthExponent = 2.25f;

	// Token: 0x040001E4 RID: 484
	public Material[] explicitMaterials;

	// Token: 0x040001E5 RID: 485
	public bool disableScattering;

	// Token: 0x040001E6 RID: 486
	public float scatterWorldFakePush = -1f;

	// Token: 0x040001E7 RID: 487
	public float scatterHeightFakePush = -1f;

	// Token: 0x040001E8 RID: 488
	public float shadowDistance = 200f;

	// Token: 0x040001E9 RID: 489
	public Color clearColor = Color.gray;

	// Token: 0x040001EA RID: 490
	private int AJCPLCAJBKP;

	// Token: 0x040001EB RID: 491
	private Shader CLILKAOCACC;

	// Token: 0x040001EC RID: 492
	private int FHFAKFEHBKA;

	// Token: 0x040001ED RID: 493
	private bool NBKBNGOMFKG;

	// Token: 0x040001EE RID: 494
	public RenderTexture m_reflectionMap;

	// Token: 0x040001EF RID: 495
	private Camera ANGPDAJNFML;

	// Token: 0x040001F0 RID: 496
	private Camera EOPGPOFHLPF;

	// Token: 0x040001F1 RID: 497
	private Material[] PCIBIGAAOAP;

	// Token: 0x040001F2 RID: 498
	private Shader[] MPLHDCMOACD;

	// Token: 0x040001F3 RID: 499
	private Material OCFCCKOBOGE;

	// Token: 0x040001F4 RID: 500
	private bool MFGCAKFGJPN;

	// Token: 0x040001F5 RID: 501
	private Renderer GAFINMGOJMC;

	// Token: 0x0200004F RID: 79
	public enum CBCBLOGDFEE
	{
		// Token: 0x040001F7 RID: 503
		x128 = 128,
		// Token: 0x040001F8 RID: 504
		x256 = 256,
		// Token: 0x040001F9 RID: 505
		x512 = 512,
		// Token: 0x040001FA RID: 506
		x1024 = 1024,
		// Token: 0x040001FB RID: 507
		x2048 = 2048
	}
}
