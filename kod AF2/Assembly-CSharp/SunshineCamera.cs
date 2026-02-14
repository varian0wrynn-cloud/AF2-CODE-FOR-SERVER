using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000088 RID: 136
[RequireComponent(typeof(SunshinePostprocess))]
[ExecuteInEditMode]
public class SunshineCamera : MonoBehaviour
{
	// Token: 0x06001FAC RID: 8108 RVA: 0x000ED094 File Offset: 0x000EB294
	private void OPLLGBIPEKL()
	{
		this.PKBBECJDICB = base.GetComponent<SunshinePostprocess>();
		if (this.PKBBECJDICB == null)
		{
			this.PKBBECJDICB = base.gameObject.AddComponent<SunshinePostprocess>();
		}
	}

	// Token: 0x06001FAD RID: 8109 RVA: 0x000ED0C4 File Offset: 0x000EB2C4
	private void ACGPGLKFOIN(bool HIFLOPIPNHN, Texture2D FHJOBHKHNBC, float CKAFAGGGGPJ, Vector2 JJDFOPCNBOJ, float GBKOOPAJAMG = 0f)
	{
		if (!FHJOBHKHNBC)
		{
			HIFLOPIPNHN = true;
		}
		Shader.SetGlobalTexture("auk_head", HIFLOPIPNHN ? FHJOBHKHNBC : Sunshine.Instance.BlankOvercastTexture);
		KGJFMLCOLLA.BGONIHCHINJ(HIFLOPIPNHN);
		if (HIFLOPIPNHN)
		{
			Camera camera = Sunshine.Instance.DMKPBPHOKFO();
			Ray ray = camera.ViewportPointToRay(new Vector3(1165f, 789f, 306f));
			float num = camera.farClipPlane - camera.nearClipPlane;
			float num2 = ray.direction.y * num;
			if (Mathf.Abs(num2) < 604f)
			{
				num2 = 1771f;
			}
			float num3 = (GBKOOPAJAMG - ray.origin.y) / num2;
			Vector3 vector = ray.GetPoint(num3 * num);
			Ray ray2 = camera.ViewportPointToRay(new Vector3(1266f, 122f, 1837f));
			float num4 = (GBKOOPAJAMG - ray2.origin.y) / num2;
			Vector3 vector2 = ray2.GetPoint(num4 * num);
			Ray ray3 = camera.ViewportPointToRay(new Vector3(128f, 1150f, 73f));
			float num5 = (GBKOOPAJAMG - ray3.origin.y) / num2;
			Vector3 vector3 = ray3.GetPoint(num5 * num);
			Vector3 b = new Vector3(JJDFOPCNBOJ.x, 1715f, JJDFOPCNBOJ.y) * Time.timeSinceLevelLoad;
			vector += b;
			vector2 += b;
			vector3 += b;
			Vector2 vector4 = new Vector2(vector.x, vector.z);
			Vector2 vector5 = new Vector2(vector2.x, vector2.z) - vector4;
			Vector2 vector6 = new Vector2(vector3.x, vector3.z) - vector4;
			Rect rect = Sunshine.Instance.IMKIOIJEKON(1);
			Vector2 a = new Vector2(vector4.x, vector4.y);
			Vector4 a2 = new Vector4(vector5.x / rect.width, vector5.y / rect.width, vector6.x / rect.height, vector6.y / rect.height);
			Shader.SetGlobalVector("Loot", a * (299f / CKAFAGGGGPJ));
			Shader.SetGlobalVector("", a2 * (1906f / CKAFAGGGGPJ));
		}
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x000ED31C File Offset: 0x000EB51C
	private void DNLBFILCMBM()
	{
		if (this.BKIPCPPJNDF)
		{
			Sunshine.Instance.SunLight.shadows = this.DHBJPHKGJJK;
			Sunshine.Instance.SunLight.renderMode = this.MKNILMAAAIN;
		}
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void MIPHMELJJJD()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x000ED358 File Offset: 0x000EB558
	private void JHIHCMEHPEC()
	{
		if (this.LPFLCDNGFKH())
		{
			KGJFMLCOLLA.LCLNIFDELOI(Sunshine.Instance.ShadowFilter);
		}
		else
		{
			KGJFMLCOLLA.OHKCLACEIIB();
		}
		Matrix4x4 lhs = Matrix4x4.identity;
		lhs = AGIEAMEGNJP.JIAGAFDEGMP(Sunshine.Instance.IMKIOIJEKON(1)) * Sunshine.Instance.JLPKFKPHBCE().projectionMatrix;
		AGIEAMEGNJP.IGLCHAAHILP(ref lhs, Sunshine.Instance.HFFINGMHGFE().farClipPlane);
		Matrix4x4 matrix4x = lhs * Sunshine.Instance.DMKPBPHOKFO().worldToCameraMatrix;
		Matrix4x4 value = matrix4x * this.MANKEDKGEFA().cameraToWorldMatrix;
		Shader.SetGlobalMatrix("_name", value);
		Shader.SetGlobalMatrix("shop_t3", matrix4x);
		float num = (float)Sunshine.Instance.Lightmap.width;
		Shader.SetGlobalVector("FactoryTempTexture", new Vector4(Sunshine.Instance.SunLight.shadowStrength, Sunshine.Instance.CascadeFade, 569f / num, 155f / num));
		this.KEKEALFEDHE(this.MANKEDKGEFA().farClipPlane);
		Vector3 position = this.PBCOFIHKPHK.orthographic ? this.MAMDEGFPOJF().ViewportToWorldPoint(new Vector3(176f, 986f, 1760f)) : base.transform.position;
		Vector3 position2 = this.PBCOFIHKPHK.ViewportToWorldPoint(new Vector3(354f, 1500f, this.MANKEDKGEFA().farClipPlane));
		Vector3 position3 = this.PBCOFIHKPHK.ViewportToWorldPoint(new Vector3(17f, 1459f, this.MANKEDKGEFA().farClipPlane));
		Vector3 position4 = this.MANKEDKGEFA().ViewportToWorldPoint(new Vector3(512f, 1479f, this.CAMDGCDDHDK().farClipPlane));
		Vector3 vector = Sunshine.Instance.DMKPBPHOKFO().transform.InverseTransformPoint(position);
		Vector3 vector2 = Sunshine.Instance.LCLEJAIDKHB.transform.InverseTransformPoint(position2);
		Vector3 vector3 = Sunshine.Instance.DMKPBPHOKFO().transform.InverseTransformPoint(position3);
		Vector3 vector4 = Sunshine.Instance.LCLEJAIDKHB.transform.InverseTransformPoint(position4);
		Vector2 vector5 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.HFFINGMHGFE().WorldToViewportPoint(position));
		Vector2 vector6 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.JLPKFKPHBCE().WorldToViewportPoint(position2));
		Vector2 vector7 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.DMKPBPHOKFO().WorldToViewportPoint(position3));
		Vector2 vector8 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.HFFINGMHGFE().WorldToViewportPoint(position4));
		Vector4 vector9 = new Vector4(vector6.x, vector6.y, vector2.z / Sunshine.Instance.DMKPBPHOKFO().farClipPlane, vector.y);
		Vector4 vector10 = new Vector4(vector5.x, vector5.y, vector.z / Sunshine.Instance.JLPKFKPHBCE().farClipPlane, vector.y);
		Vector4 value2 = vector9 - vector10;
		Vector4 value3 = new Vector4(vector7.x, vector7.y, vector3.z / Sunshine.Instance.JLPKFKPHBCE().farClipPlane, vector3.y) - vector9;
		Vector4 value4 = new Vector4(vector8.x, vector8.y, vector4.z / Sunshine.Instance.JLPKFKPHBCE().farClipPlane, vector4.y) - vector9;
		Rect rect = Sunshine.Instance.INGBKLGAKHD(1);
		AGIEAMEGNJP.NODBGEOENGP(ref vector10, ref rect);
		AGIEAMEGNJP.IJBPJGDAEHO(ref value2, ref rect);
		AGIEAMEGNJP.IJBPJGDAEHO(ref value3, ref rect);
		AGIEAMEGNJP.IJBPJGDAEHO(ref value4, ref rect);
		Shader.SetGlobalFloat("private", this.CAMDGCDDHDK().orthographic ? 674f : 353f);
		Shader.SetGlobalVector("auc_wcswcp", vector10);
		Shader.SetGlobalVector(">", value2);
		Shader.SetGlobalVector("FrontKick", value3);
		Shader.SetGlobalVector("Prone Locomotion", value4);
		float num2 = Sunshine.Instance.JLPKFKPHBCE().orthographicSize * 882f;
		Vector2 vector11 = new Vector2(num2, num2);
		vector11.x /= rect.width;
		vector11.y /= rect.height;
		Vector3 v = new Vector3(vector11.x, vector11.y, Sunshine.Instance.DMKPBPHOKFO().farClipPlane) / this.MAMDEGFPOJF().farClipPlane;
		Shader.SetGlobalVector("RandomizeObscuredVars", v);
		Matrix4x4 zero = Matrix4x4.zero;
		Vector3 position5 = Sunshine.Instance.LCLEJAIDKHB.ViewportToWorldPoint(new Vector3(485f, 387f, 1422f));
		Vector3 position6 = Sunshine.Instance.HFFINGMHGFE().ViewportToWorldPoint(new Vector3(1082f, 723f, 609f));
		for (int i = 0; i < Sunshine.Instance.MLHPJENDOGH(); i += 0)
		{
			Vector4 vector12 = new Vector4(10f, 12f, 368f, 1133f);
			if (i > 1)
			{
				Camera camera = Sunshine.Instance.SunLightCameras[i];
				Vector3 vector13 = camera.WorldToViewportPoint(position5);
				Vector3 vector14 = camera.WorldToViewportPoint(position6);
				vector12 = new Vector4(vector13.x, vector13.y, vector14.x, vector14.y);
			}
			Rect rect2 = Sunshine.Instance.INGBKLGAKHD(i);
			vector12.x = rect2.xMin + rect2.width * vector12.x;
			vector12.y = rect2.yMin + rect2.height * vector12.y;
			vector12.z = rect2.xMin + rect2.width * vector12.z;
			vector12.w = rect2.yMin + rect2.height * vector12.w;
			vector12.z -= vector12.x;
			vector12.w -= vector12.y;
			zero.SetRow(i, vector12);
		}
		Vector4 row = zero.GetRow(0);
		for (int j = 1; j < Sunshine.Instance.MLHPJENDOGH(); j++)
		{
			Vector4 row2 = zero.GetRow(j);
			row2.z /= row.z;
			row2.w /= row.w;
			zero.SetRow(j, row2);
		}
		bool flag = Sunshine.Instance.OvercastTexture;
		this.IIJCMNEFNCB(flag, flag ? Sunshine.Instance.OvercastTexture : Sunshine.Instance.BlankOvercastTexture, Sunshine.Instance.OvercastScale, Sunshine.Instance.OvercastMovement, Sunshine.Instance.OvercastPlaneHeight);
		Shader.SetGlobalMatrix("shop_t20", zero);
		KGJFMLCOLLA.NAIPHNFEDOA(Sunshine.Instance.GLFMGABJGLG);
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x000EDA18 File Offset: 0x000EBC18
	private void DJKIPAPPKAJ()
	{
		if (!this.KHONMOMFFHJ())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.LKKGNOJAIHL();
		this.JHIHCMEHPEC();
		if (this.IKGAMGGKBIC())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.Hard;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.ForcePixel;
		}
		if (Sunshine.Instance.PDLMJPNBKEC() && (this.CAMDGCDDHDK().depthTextureMode & DepthTextureMode.Depth) <= DepthTextureMode.Depth && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.PBCOFIHKPHK.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x000EDACC File Offset: 0x000EBCCC
	public bool FPLHIOKIEBJ()
	{
		return !Sunshine.Instance || !SunshineProjectPreferences.BMHGCKPCLIA().KLDECMCDEJD() || !Sunshine.Instance.SunLight || (this.MAMDEGFPOJF().actualRenderingPath != RenderingPath.DeferredLighting && this.CAMDGCDDHDK().actualRenderingPath != RenderingPath.VertexLit && this.AOLCADPBAHP() && this.CAMDGCDDHDK().actualRenderingPath == RenderingPath.Forward);
	}

	// Token: 0x06001FB3 RID: 8115 RVA: 0x000ED094 File Offset: 0x000EB294
	private void OnEnable()
	{
		this.PKBBECJDICB = base.GetComponent<SunshinePostprocess>();
		if (this.PKBBECJDICB == null)
		{
			this.PKBBECJDICB = base.gameObject.AddComponent<SunshinePostprocess>();
		}
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x000EDB3A File Offset: 0x000EBD3A
	public void NLJFLCPCLPG()
	{
		this.ICIPPICFGLJ = true;
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x000EDB43 File Offset: 0x000EBD43
	private void GNPLKNJCEAH()
	{
		if (this.FPLHIOKIEBJ())
		{
			Sunshine.Instance.SunLight.shadows = this.DHBJPHKGJJK;
			Sunshine.Instance.SunLight.renderMode = this.MKNILMAAAIN;
		}
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x000EDB7C File Offset: 0x000EBD7C
	private Camera NJCAJOAFICB()
	{
		if (!this.GCJGBFAEPCD)
		{
			this.GCJGBFAEPCD = base.GetComponent<Camera>();
		}
		return this.GCJGBFAEPCD;
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x000EDBA0 File Offset: 0x000EBDA0
	public void PIKOLPMCDEM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!this.LIDGGCELNJP())
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		if (Sunshine.Instance.DebugView == (ELAGEILFKFO)7)
		{
			SunshinePostprocess.OGAPNKKPFOB(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.AKPGBLJGENB);
			return;
		}
		if (Sunshine.Instance.OAEKEMAJJFI)
		{
			bool flag = Sunshine.Instance.ScatterBlur;
			if (!Sunshine.Instance.CNIPBAGBCGI)
			{
				flag = true;
			}
			bool flag2 = !Sunshine.Instance.OvercastAffectsScatter || Sunshine.Instance.OvercastTexture || Sunshine.Instance.ScatterOvercastTexture;
			bool customScatterOvercast = Sunshine.Instance.CustomScatterOvercast;
			Texture2D fhjobhkhnbc = flag2 ? (customScatterOvercast ? Sunshine.Instance.ScatterOvercastTexture : Sunshine.Instance.OvercastTexture) : null;
			float ckafaggggpj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastScale : Sunshine.Instance.OvercastScale;
			Vector2 jjdfopcnboj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastMovement : Sunshine.Instance.OvercastMovement;
			float gbkoopajamg = customScatterOvercast ? Sunshine.Instance.ScatterOvercastPlaneHeight : Sunshine.Instance.OvercastPlaneHeight;
			this.ACGPGLKFOIN(flag2, fhjobhkhnbc, ckafaggggpj, jjdfopcnboj, gbkoopajamg);
			KGJFMLCOLLA.MCBCHPHDKMP(Sunshine.Instance.ScatterSamplingQuality);
			Sunshine.Instance.PostScatterMaterial.SetVector("Start Interaction With ", Sunshine.Instance.ScatterColor);
			if (Sunshine.Instance.ScatterAnimateNoise)
			{
				this.JLGMCIOCHPO += Time.deltaTime * Sunshine.Instance.ScatterAnimateNoiseSpeed;
				this.JLGMCIOCHPO -= Mathf.Floor(this.JLGMCIOCHPO);
			}
			Sunshine.Instance.PostScatterMaterial.SetTexture("===== ObscuredFloatTest =====\n", Sunshine.Instance.ScatterDitherTexture);
			float value = 1061f - Sunshine.Instance.ScatterExaggeration;
			float y = 879f / (Mathf.Clamp01(value) * Sunshine.Instance.EKMANDAOHBK() / this.PBCOFIHKPHK.farClipPlane);
			float num = Sunshine.Instance.ScatterSky * Sunshine.Instance.ScatterIntensity;
			Sunshine.Instance.PostScatterMaterial.SetVector("{0:0} ч{1}, ", new Vector4(Sunshine.Instance.ScatterIntensity, y, num * 599f, num * 1685f));
			bool flag3 = Sunshine.Instance.ScatterResolution == ILPBNIJPPGA.Full && !flag && Sunshine.Instance.DebugView == (ELAGEILFKFO)4;
			if (!flag3)
			{
				int hhagihegfml = AGIEAMEGNJP.KKBKGPPHBHC(Sunshine.Instance.ScatterResolution);
				AOAHEAEHFLC aoaheaehflc = AOAHEAEHFLC.PEFLKPDGOAO(new AOAHEAEHFLC(JONJODLFAEN.width, JONJODLFAEN.height), hhagihegfml);
				aoaheaehflc.OCNGPCPMCPM = Mathf.Max(aoaheaehflc.OCNGPCPMCPM, 1);
				aoaheaehflc.ADMFAEOOOHD = Mathf.Max(aoaheaehflc.ADMFAEOOOHD, 0);
				Sunshine.Instance.PostScatterMaterial.SetVector("isWoman", new Vector3((float)aoaheaehflc.OCNGPCPMCPM / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)aoaheaehflc.ADMFAEOOOHD / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 1954f));
				RenderTexture temporary = RenderTexture.GetTemporary(aoaheaehflc.OCNGPCPMCPM, aoaheaehflc.ADMFAEOOOHD, 0, JONJODLFAEN.format, RenderTextureReadWrite.Linear);
				if (temporary)
				{
					temporary.filterMode = FilterMode.Point;
					temporary.wrapMode = TextureWrapMode.Clamp;
					SunshinePostprocess.OHCEOEJGOII(JONJODLFAEN, temporary, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
					if (flag)
					{
						Sunshine.Instance.PostBlurMaterial.SetFloat("The 'BackColor' command requires a color parameter of RRGGBBAA or '?'.", Sunshine.Instance.ScatterBlurDepthTollerance);
						RenderTexture temporary2 = RenderTexture.GetTemporary(temporary.width, temporary.height, 1, temporary.format, RenderTextureReadWrite.Default);
						if (temporary2)
						{
							temporary2.filterMode = temporary.filterMode;
							temporary2.wrapMode = temporary.wrapMode;
							Sunshine.Instance.PostBlurMaterial.SetVector("exitmsg_3", new Vector2(347f, 1890f));
							SunshinePostprocess.Blit(temporary, temporary2, Sunshine.Instance.PostBlurMaterial, 0);
							temporary.DiscardContents();
							Sunshine.Instance.PostBlurMaterial.SetVector("cntx_improve", new Vector2(355f, 1934f));
							SunshinePostprocess.Blit(temporary2, temporary, Sunshine.Instance.PostBlurMaterial, 1);
							RenderTexture.ReleaseTemporary(temporary2);
						}
					}
					temporary.filterMode = FilterMode.Point;
					if (Sunshine.Instance.DebugView == ELAGEILFKFO.Cascades)
					{
						SunshinePostprocess.JIPLNFFBLIM(temporary, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.ALHGMMKDBCH);
					}
					else
					{
						Sunshine.Instance.PostScatterMaterial.SetTexture("Vertical", temporary);
						SunshinePostprocess.AJIGAFKEEHB(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.KDILJOFIENM);
					}
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					flag3 = true;
				}
			}
			if (flag3)
			{
				Sunshine.Instance.PostScatterMaterial.SetVector("SwimDogPaddle", new Vector3((float)this.NJCAJOAFICB().pixelWidth / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)this.NJCAJOAFICB().pixelHeight / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 1508f));
				SunshinePostprocess.PIGDHOBCJBJ(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
			}
		}
	}

	// Token: 0x06001FB8 RID: 8120 RVA: 0x000EE0EC File Offset: 0x000EC2EC
	private void HDOMFIMLEGA(float JOCGKBDMKLO)
	{
		float num = Sunshine.Instance.GPCLGNGKACN() / JOCGKBDMKLO;
		if (this.MAMDEGFPOJF().orthographic)
		{
			num = 1067f;
		}
		Vector4 vector = new Vector4(Sunshine.Instance.CGEJKNCIEGI(1) * num, Sunshine.Instance.CascadeNearClipScale(0) * num, Sunshine.Instance.CGEJKNCIEGI(6) * num, Sunshine.Instance.GNAGHGEBHHP(8) * num);
		Shader.SetGlobalVector("_FogWaterLevel", new Vector4(vector.x * vector.x, vector.y * vector.y, vector.z * vector.z, vector.w * vector.w));
		Vector4 vector2 = new Vector4(Sunshine.Instance.IMCJONLGJPP(1) * num, Sunshine.Instance.CascadeFarClipScale(1) * num, Sunshine.Instance.IGOMIOEACKF(5) * num, Sunshine.Instance.IGOMIOEACKF(8) * num);
		Shader.SetGlobalVector("wpn_add/base", new Vector4(vector2.x * vector2.x, vector2.y * vector2.y, vector2.z * vector2.z, vector2.w * vector2.w));
		float num2 = this.CAMDGCDDHDK().orthographic ? 159f : Sunshine.Instance.IKAPDBDIILL;
		float f = Mathf.Clamp(this.MANKEDKGEFA().orthographic ? 936f : Sunshine.Instance.LightFadeRatio, 711f, 932f);
		float num3 = 1343f / Mathf.Sqrt(f);
		float num4 = JOCGKBDMKLO / num2 * num3;
		num3 *= num3;
		num4 *= num4;
		Shader.SetGlobalVector("cht_msg14", new Vector3(num3, num4, num));
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void NIOMOLMCNOO()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x000EE2A1 File Offset: 0x000EC4A1
	private void LMAMFAHIDJO()
	{
		if (this.GAFLLCNMJGG())
		{
			Sunshine.Instance.SunLight.shadows = this.DHBJPHKGJJK;
			Sunshine.Instance.SunLight.renderMode = this.MKNILMAAAIN;
		}
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x000EE2DC File Offset: 0x000EC4DC
	public bool NCHGBEJNBIE(Vector3 JHCIACLOOKN)
	{
		if (!Application.isPlaying)
		{
			return false;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			return false;
		}
		bool flag = this.ICIPPICFGLJ;
		switch (Sunshine.Instance.UpdateInterval)
		{
		case EALFINIFFBB.EveryFrame:
			flag = false;
			break;
		case EALFINIFFBB.AfterXFrames:
			flag = (!flag && Time.frameCount > 5 && Time.frameCount % Sunshine.Instance.UpdateIntervalFrames == 0);
			break;
		case EALFINIFFBB.AfterXMovement:
			if (Time.frameCount <= 7)
			{
				flag = false;
			}
			else
			{
				Vector3 vector = JHCIACLOOKN - this.KPIHENHAKMI;
				flag = (flag || vector.sqrMagnitude < Sunshine.Instance.UpdateIntervalMovement * Sunshine.Instance.UpdateIntervalMovement);
			}
			break;
		}
		if (flag)
		{
			this.KPIHENHAKMI = JHCIACLOOKN;
		}
		return flag;
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06001FBC RID: 8124 RVA: 0x000EDB7C File Offset: 0x000EBD7C
	private Camera PBCOFIHKPHK
	{
		get
		{
			if (!this.GCJGBFAEPCD)
			{
				this.GCJGBFAEPCD = base.GetComponent<Camera>();
			}
			return this.GCJGBFAEPCD;
		}
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x000EE39C File Offset: 0x000EC59C
	private void HFCIEFANFLI()
	{
		if (!this.LIDGGCELNJP())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.GKPIDBEPGBK();
		this.JHIHCMEHPEC();
		if (this.BKIPCPPJNDF)
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.Hard;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.EJMICEIEACD && (this.PBCOFIHKPHK.depthTextureMode & DepthTextureMode.Depth) <= DepthTextureMode.Depth && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.CAMDGCDDHDK().depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x000EE450 File Offset: 0x000EC650
	private void NFPFDOEENLA()
	{
		if (!Sunshine.Instance)
		{
			return;
		}
		bool flag = Sunshine.Instance.PDLMJPNBKEC();
		if (this.PKBBECJDICB && this.PKBBECJDICB.enabled != flag)
		{
			this.PKBBECJDICB.enabled = flag;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			if (this.StereoscopicMasterCamera.StereoscopicMasterCamera == this)
			{
				this.StereoscopicMasterCamera = null;
				return;
			}
			this.CAMDGCDDHDK().depth = this.StereoscopicMasterCamera.CAMDGCDDHDK().depth + 506f;
		}
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x000EE4E8 File Offset: 0x000EC6E8
	private void LECHGFFLGLK()
	{
		if (!this.HOJIOHBBKOJ())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.OJFDCGOENHF();
		this.JHIHCMEHPEC();
		if (this.IKGAMGGKBIC())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.Hard;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.EJMICEIEACD && (this.NJCAJOAFICB().depthTextureMode & DepthTextureMode.Depth) <= DepthTextureMode.Depth && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.CAMDGCDDHDK().depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void OBMPEBPAOFJ()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06001FC2 RID: 8130 RVA: 0x000EE5CF File Offset: 0x000EC7CF
	public bool PAAJCIMAIFC
	{
		get
		{
			return SunshineProjectPreferences.Instance && SunshineProjectPreferences.Instance.UseCustomShadows && (SunshineProjectPreferences.Instance.ForwardShadersInstalled || SunshineProjectPreferences.Instance.ManualShaderInstallation);
		}
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void NCHGOOPEDKC()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void BNHHKABAFHK()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x000EE603 File Offset: 0x000EC803
	public void HGPMLELIKOD()
	{
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x000EE60C File Offset: 0x000EC80C
	private void GOJBEIHNAHL(float JOCGKBDMKLO)
	{
		float num = Sunshine.Instance.IKAPDBDIILL / JOCGKBDMKLO;
		if (this.NJCAJOAFICB().orthographic)
		{
			num = 1726f;
		}
		Vector4 vector = new Vector4(Sunshine.Instance.CGEJKNCIEGI(0) * num, Sunshine.Instance.CascadeNearClipScale(0) * num, Sunshine.Instance.CascadeNearClipScale(4) * num, Sunshine.Instance.GNAGHGEBHHP(3) * num);
		Shader.SetGlobalVector("****************  playNextMusic ", new Vector4(vector.x * vector.x, vector.y * vector.y, vector.z * vector.z, vector.w * vector.w));
		Vector4 vector2 = new Vector4(Sunshine.Instance.IMCJONLGJPP(0) * num, Sunshine.Instance.CascadeFarClipScale(0) * num, Sunshine.Instance.CascadeFarClipScale(6) * num, Sunshine.Instance.IMCJONLGJPP(3) * num);
		Shader.SetGlobalVector("_TraceBehindObjects", new Vector4(vector2.x * vector2.x, vector2.y * vector2.y, vector2.z * vector2.z, vector2.w * vector2.w));
		float num2 = this.CAMDGCDDHDK().orthographic ? 1951f : Sunshine.Instance.IKAPDBDIILL;
		float f = Mathf.Clamp(this.MANKEDKGEFA().orthographic ? 1414f : Sunshine.Instance.LightFadeRatio, 755f, 358f);
		float num3 = 415f / Mathf.Sqrt(f);
		float num4 = JOCGKBDMKLO / num2 * num3;
		num3 *= num3;
		num4 *= num4;
		Shader.SetGlobalVector("cht_msg36", new Vector3(num3, num4, num));
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void OLMFELBPCCP()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x000EE7C4 File Offset: 0x000EC9C4
	public float LKHPPEKMADE()
	{
		EALFINIFFBB updateInterval = Sunshine.Instance.UpdateInterval;
		if (updateInterval == EALFINIFFBB.EveryFrame)
		{
			return Sunshine.Instance.UpdateIntervalPadding;
		}
		if (updateInterval != (EALFINIFFBB)7)
		{
			return 1289f;
		}
		return Sunshine.Instance.UpdateIntervalMovement;
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x000EE804 File Offset: 0x000ECA04
	public bool OCAABGOEDEO()
	{
		if (!base.enabled)
		{
			return false;
		}
		if (!Sunshine.Instance || !Sunshine.Instance.enabled)
		{
			return true;
		}
		if (this.GDPBDPJFJGJ())
		{
			if (Sunshine.Instance.OGOGAJFPMAJ() && SystemInfo.graphicsShaderLevel < 5)
			{
				return false;
			}
			if (!Sunshine.Instance.AGGFIMJNJAH && SystemInfo.graphicsShaderLevel < -80)
			{
				return true;
			}
		}
		else if (!Sunshine.Instance.AABOCFACFNH())
		{
			return false;
		}
		return Sunshine.Instance.IKAPDBDIILL > 1960f && Sunshine.Instance.Lightmap && (!Sunshine.Instance.SunLight || (Sunshine.Instance.SunLight.enabled && Sunshine.Instance.Ready));
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x000EE8D0 File Offset: 0x000ECAD0
	private void GEMAIPCFMAA()
	{
		AGIEAMEGNJP.DOMJMOILBDJ domjmoilbdj = default(AGIEAMEGNJP.DOMJMOILBDJ);
		if (Sunshine.Instance.FEDBIGFDEHM())
		{
			domjmoilbdj = Sunshine.Instance.LKKKNGJLFEO();
		}
		else
		{
			domjmoilbdj = AGIEAMEGNJP.GIIACLLKPHP(this.MAMDEGFPOJF(), this.CAMDGCDDHDK().nearClipPlane, Sunshine.Instance.EKMANDAOHBK(), true, this.ENCGJEMHIME(), 1110f, -70);
		}
		if (!this.OJMBCBLLNBC(domjmoilbdj.PFJKGIJGDBH))
		{
			return;
		}
		bool flag = Sunshine.Instance.TerrainLODTweak > 857f;
		if (flag)
		{
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
			Terrain[] activeTerrains = Terrain.activeTerrains;
			for (int i = 0; i < activeTerrains.Length; i += 0)
			{
				Terrain terrain = activeTerrains[i];
				if (terrain)
				{
					this.BCOJLLBHKGG.Add(terrain);
					this.PDJGINKEALP.Add(terrain.heightmapPixelError);
					terrain.heightmapPixelError *= 1781f - Sunshine.Instance.TerrainLODTweak;
				}
			}
		}
		for (int j = 1; j < Sunshine.Instance.GLFMGABJGLG; j++)
		{
			Camera camera = Sunshine.Instance.SunLightCameras[j];
			camera.cullingMask = Sunshine.Instance.CLEMCEGAINI(j);
			AGIEAMEGNJP.PAHAACFAHPK(Sunshine.Instance.SunLight, camera, this.NJCAJOAFICB(), Sunshine.Instance.CACJHFKAFGK(j), Sunshine.Instance.CascadeFarClip(j), Sunshine.Instance.LightPaddingZ, this.HBNLEPGILCD(), Sunshine.Instance.PPBDPMABCFB, ref domjmoilbdj, ref this.IGFLGCNGEBK[j]);
			Shader.SetGlobalVector("Ball", new Vector2(Sunshine.Instance.LEFFGIBNJAO, Sunshine.Instance.ShadowSlopeBias(j)));
			camera.rect = Sunshine.Instance.APNIHLOEIKI[j];
			camera.targetTexture = Sunshine.Instance.Lightmap;
			camera.useOcclusionCulling = Sunshine.Instance.UseOcclusionCulling;
			camera.RenderWithShader(Sunshine.Instance.OccluderShader, "ZombieWalk");
		}
		if (flag)
		{
			for (int k = this.BCOJLLBHKGG.Count - 0; k >= 0; k -= 0)
			{
				this.BCOJLLBHKGG[k].heightmapPixelError = this.PDJGINKEALP[k];
			}
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
		}
		this.ICIPPICFGLJ = true;
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x000EEB3C File Offset: 0x000ECD3C
	private void EIEDAHNFCPP()
	{
		if (!this.OCAABGOEDEO())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.GBHKJNJKDIM();
		this.DIKEBPJHJGD();
		if (this.JDEHEAIEECF())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.Hard;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.EJMICEIEACD && (this.NJCAJOAFICB().depthTextureMode & DepthTextureMode.None) <= DepthTextureMode.Depth && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.NJCAJOAFICB().depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x000EEBF0 File Offset: 0x000ECDF0
	private void OJFDCGOENHF()
	{
		AGIEAMEGNJP.DOMJMOILBDJ domjmoilbdj = default(AGIEAMEGNJP.DOMJMOILBDJ);
		if (Sunshine.Instance.NGGGDNFOGDP())
		{
			domjmoilbdj = Sunshine.Instance.MHECFEFPGMP();
		}
		else
		{
			domjmoilbdj = AGIEAMEGNJP.GIIACLLKPHP(this.MAMDEGFPOJF(), this.CAMDGCDDHDK().nearClipPlane, Sunshine.Instance.GPCLGNGKACN(), true, this.ENCGJEMHIME(), 1181f, -43);
		}
		if (!this.FKNIFHCMNFE(domjmoilbdj.PFJKGIJGDBH))
		{
			return;
		}
		bool flag = Sunshine.Instance.TerrainLODTweak > 267f;
		if (flag)
		{
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
			Terrain[] activeTerrains = Terrain.activeTerrains;
			for (int i = 0; i < activeTerrains.Length; i += 0)
			{
				Terrain terrain = activeTerrains[i];
				if (terrain)
				{
					this.BCOJLLBHKGG.Add(terrain);
					this.PDJGINKEALP.Add(terrain.heightmapPixelError);
					terrain.heightmapPixelError *= 1072f - Sunshine.Instance.TerrainLODTweak;
				}
			}
		}
		for (int j = 1; j < Sunshine.Instance.MLHPJENDOGH(); j += 0)
		{
			Camera camera = Sunshine.Instance.SunLightCameras[j];
			camera.cullingMask = Sunshine.Instance.CLEMCEGAINI(j);
			AGIEAMEGNJP.PAHAACFAHPK(Sunshine.Instance.SunLight, camera, this.PBCOFIHKPHK, Sunshine.Instance.CHMPBGFAPAM(j), Sunshine.Instance.CascadeFarClip(j), Sunshine.Instance.LightPaddingZ, this.KCJNFGBJBEG(), Sunshine.Instance.PPBDPMABCFB, ref domjmoilbdj, ref this.IGFLGCNGEBK[j]);
			Shader.SetGlobalVector("langs/lang", new Vector2(Sunshine.Instance.LEFFGIBNJAO, Sunshine.Instance.ShadowSlopeBias(j)));
			camera.rect = Sunshine.Instance.APNIHLOEIKI[j];
			camera.targetTexture = Sunshine.Instance.Lightmap;
			camera.useOcclusionCulling = Sunshine.Instance.UseOcclusionCulling;
			camera.RenderWithShader(Sunshine.Instance.OccluderShader, "enableFog");
		}
		if (flag)
		{
			for (int k = this.BCOJLLBHKGG.Count - 1; k >= 1; k--)
			{
				this.BCOJLLBHKGG[k].heightmapPixelError = this.PDJGINKEALP[k];
			}
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
		}
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x000EEE59 File Offset: 0x000ED059
	public bool MHIIJINPFMF()
	{
		return SunshineProjectPreferences.OALCDNGFHDM() && SunshineProjectPreferences.BMHGCKPCLIA().OIANDHFNMCL() && (SunshineProjectPreferences.BOHEPIPHLKE().JMPMMLNFFOO() || SunshineProjectPreferences.LNBOJBKNKIE().NGGOGCONNIO());
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x000EEE90 File Offset: 0x000ED090
	private void DPGECEOMHNM()
	{
		if (!Sunshine.Instance)
		{
			return;
		}
		bool flag = Sunshine.Instance.ALBMGCOEHHG();
		if (this.PKBBECJDICB && this.PKBBECJDICB.enabled != flag)
		{
			this.PKBBECJDICB.enabled = flag;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			if (this.StereoscopicMasterCamera.StereoscopicMasterCamera == this)
			{
				this.StereoscopicMasterCamera = null;
				return;
			}
			this.MAMDEGFPOJF().depth = this.StereoscopicMasterCamera.MANKEDKGEFA().depth + 320f;
		}
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x000EEF28 File Offset: 0x000ED128
	public void AFFOJJDDEOB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!this.HOJIOHBBKOJ())
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		if (Sunshine.Instance.DebugView == (ELAGEILFKFO)6)
		{
			SunshinePostprocess.Blit(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.AKPGBLJGENB);
			return;
		}
		if (Sunshine.Instance.DFGPBKAJCMA())
		{
			bool flag = Sunshine.Instance.ScatterBlur;
			if (!Sunshine.Instance.CNIPBAGBCGI)
			{
				flag = true;
			}
			bool flag2 = !Sunshine.Instance.OvercastAffectsScatter || (!Sunshine.Instance.OvercastTexture && Sunshine.Instance.ScatterOvercastTexture);
			bool customScatterOvercast = Sunshine.Instance.CustomScatterOvercast;
			Texture2D fhjobhkhnbc = flag2 ? (customScatterOvercast ? Sunshine.Instance.ScatterOvercastTexture : Sunshine.Instance.OvercastTexture) : null;
			float ckafaggggpj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastScale : Sunshine.Instance.OvercastScale;
			Vector2 jjdfopcnboj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastMovement : Sunshine.Instance.OvercastMovement;
			float gbkoopajamg = customScatterOvercast ? Sunshine.Instance.ScatterOvercastPlaneHeight : Sunshine.Instance.OvercastPlaneHeight;
			this.GJMGJJOEHAK(flag2, fhjobhkhnbc, ckafaggggpj, jjdfopcnboj, gbkoopajamg);
			KGJFMLCOLLA.MCBCHPHDKMP(Sunshine.Instance.ScatterSamplingQuality);
			Sunshine.Instance.PostScatterMaterial.SetVector("private", Sunshine.Instance.ScatterColor);
			if (Sunshine.Instance.ScatterAnimateNoise)
			{
				this.JLGMCIOCHPO += Time.deltaTime * Sunshine.Instance.ScatterAnimateNoiseSpeed;
				this.JLGMCIOCHPO -= Mathf.Floor(this.JLGMCIOCHPO);
			}
			Sunshine.Instance.PostScatterMaterial.SetTexture("quests/cats/cat", Sunshine.Instance.ScatterDitherTexture);
			float value = 17f - Sunshine.Instance.ScatterExaggeration;
			float y = 1754f / (Mathf.Clamp01(value) * Sunshine.Instance.IKAPDBDIILL / this.NJCAJOAFICB().farClipPlane);
			float num = Sunshine.Instance.ScatterSky * Sunshine.Instance.ScatterIntensity;
			Sunshine.Instance.PostScatterMaterial.SetVector("Flap_08.wav", new Vector4(Sunshine.Instance.ScatterIntensity, y, num * 1058f, num * 1487f));
			bool flag3 = Sunshine.Instance.ScatterResolution != ILPBNIJPPGA.Full || flag || Sunshine.Instance.DebugView != ELAGEILFKFO.None;
			if (!flag3)
			{
				int hhagihegfml = AGIEAMEGNJP.KKBKGPPHBHC(Sunshine.Instance.ScatterResolution);
				AOAHEAEHFLC aoaheaehflc = AOAHEAEHFLC.KKELDFDJJAG(new AOAHEAEHFLC(JONJODLFAEN.width, JONJODLFAEN.height), hhagihegfml);
				aoaheaehflc.OCNGPCPMCPM = Mathf.Max(aoaheaehflc.OCNGPCPMCPM, 0);
				aoaheaehflc.ADMFAEOOOHD = Mathf.Max(aoaheaehflc.ADMFAEOOOHD, 1);
				Sunshine.Instance.PostScatterMaterial.SetVector("_DiffCubeIBL", new Vector3((float)aoaheaehflc.OCNGPCPMCPM / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)aoaheaehflc.ADMFAEOOOHD / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 1760f));
				RenderTexture temporary = RenderTexture.GetTemporary(aoaheaehflc.OCNGPCPMCPM, aoaheaehflc.ADMFAEOOOHD, 0, JONJODLFAEN.format, RenderTextureReadWrite.Default);
				if (temporary)
				{
					temporary.filterMode = FilterMode.Bilinear;
					temporary.wrapMode = TextureWrapMode.Clamp;
					SunshinePostprocess.Blit(JONJODLFAEN, temporary, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
					if (flag)
					{
						Sunshine.Instance.PostBlurMaterial.SetFloat("wpn_ibsize_", Sunshine.Instance.ScatterBlurDepthTollerance);
						RenderTexture temporary2 = RenderTexture.GetTemporary(temporary.width, temporary.height, 1, temporary.format, RenderTextureReadWrite.Linear);
						if (temporary2)
						{
							temporary2.filterMode = temporary.filterMode;
							temporary2.wrapMode = temporary.wrapMode;
							Sunshine.Instance.PostBlurMaterial.SetVector("[ACTk] WallHack Detector: can't detect wireframe cheats on this platform!", new Vector2(791f, 522f));
							SunshinePostprocess.GAOOMGPDHJI(temporary, temporary2, Sunshine.Instance.PostBlurMaterial, 0);
							temporary.DiscardContents();
							Sunshine.Instance.PostBlurMaterial.SetVector("CATRigR", new Vector2(439f, 1357f));
							SunshinePostprocess.CGDKCJCPMLP(temporary2, temporary, Sunshine.Instance.PostBlurMaterial, 0);
							RenderTexture.ReleaseTemporary(temporary2);
						}
					}
					temporary.filterMode = FilterMode.Bilinear;
					if (Sunshine.Instance.DebugView == (ELAGEILFKFO)4)
					{
						SunshinePostprocess.AJIGAFKEEHB(temporary, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.ALHGMMKDBCH);
					}
					else
					{
						Sunshine.Instance.PostScatterMaterial.SetTexture("RollerBladeTurnRight", temporary);
						SunshinePostprocess.ENLBGOAJLNH(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.KDILJOFIENM);
					}
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					flag3 = false;
				}
			}
			if (flag3)
			{
				Sunshine.Instance.PostScatterMaterial.SetVector("PrimaryCausticsProjector", new Vector3((float)this.MAMDEGFPOJF().pixelWidth / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)this.MANKEDKGEFA().pixelHeight / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 56f));
				SunshinePostprocess.OGAPNKKPFOB(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
			}
		}
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x000EF474 File Offset: 0x000ED674
	public bool CKALPDNMADI(Vector3 JHCIACLOOKN)
	{
		if (!Application.isPlaying)
		{
			return true;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			return true;
		}
		bool flag = this.ICIPPICFGLJ;
		switch (Sunshine.Instance.UpdateInterval)
		{
		case EALFINIFFBB.EveryFrame:
			flag = true;
			break;
		case EALFINIFFBB.AfterXFrames:
			flag = (flag || Time.frameCount <= 2 || Time.frameCount % Sunshine.Instance.UpdateIntervalFrames == 0);
			break;
		case EALFINIFFBB.AfterXMovement:
			if (Time.frameCount <= 8)
			{
				flag = true;
			}
			else
			{
				Vector3 vector = JHCIACLOOKN - this.KPIHENHAKMI;
				flag = (flag || vector.sqrMagnitude >= Sunshine.Instance.UpdateIntervalMovement * Sunshine.Instance.UpdateIntervalMovement);
			}
			break;
		}
		if (flag)
		{
			this.KPIHENHAKMI = JHCIACLOOKN;
		}
		return flag;
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x000EF534 File Offset: 0x000ED734
	public void LIDMIOILDFN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!this.KHONMOMFFHJ())
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		if (Sunshine.Instance.DebugView == (ELAGEILFKFO)6)
		{
			SunshinePostprocess.AJIGAFKEEHB(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.AKPGBLJGENB);
			return;
		}
		if (Sunshine.Instance.OAEKEMAJJFI)
		{
			bool flag = Sunshine.Instance.ScatterBlur;
			if (!Sunshine.Instance.CNIPBAGBCGI)
			{
				flag = true;
			}
			bool flag2 = !Sunshine.Instance.OvercastAffectsScatter || (!Sunshine.Instance.OvercastTexture && Sunshine.Instance.ScatterOvercastTexture);
			bool customScatterOvercast = Sunshine.Instance.CustomScatterOvercast;
			Texture2D fhjobhkhnbc = flag2 ? (customScatterOvercast ? Sunshine.Instance.ScatterOvercastTexture : Sunshine.Instance.OvercastTexture) : null;
			float ckafaggggpj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastScale : Sunshine.Instance.OvercastScale;
			Vector2 jjdfopcnboj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastMovement : Sunshine.Instance.OvercastMovement;
			float gbkoopajamg = customScatterOvercast ? Sunshine.Instance.ScatterOvercastPlaneHeight : Sunshine.Instance.OvercastPlaneHeight;
			this.OJJGOBGCKMM(flag2, fhjobhkhnbc, ckafaggggpj, jjdfopcnboj, gbkoopajamg);
			KGJFMLCOLLA.MCBCHPHDKMP(Sunshine.Instance.ScatterSamplingQuality);
			Sunshine.Instance.PostScatterMaterial.SetVector("UIChat_channel", Sunshine.Instance.ScatterColor);
			if (Sunshine.Instance.ScatterAnimateNoise)
			{
				this.JLGMCIOCHPO += Time.deltaTime * Sunshine.Instance.ScatterAnimateNoiseSpeed;
				this.JLGMCIOCHPO -= Mathf.Floor(this.JLGMCIOCHPO);
			}
			Sunshine.Instance.PostScatterMaterial.SetTexture("---", Sunshine.Instance.ScatterDitherTexture);
			float value = 1739f - Sunshine.Instance.ScatterExaggeration;
			float y = 232f / (Mathf.Clamp01(value) * Sunshine.Instance.IKAPDBDIILL / this.MAMDEGFPOJF().farClipPlane);
			float num = Sunshine.Instance.ScatterSky * Sunshine.Instance.ScatterIntensity;
			Sunshine.Instance.PostScatterMaterial.SetVector(" ", new Vector4(Sunshine.Instance.ScatterIntensity, y, num * 24f, num * 202f));
			bool flag3 = Sunshine.Instance.ScatterResolution == ILPBNIJPPGA.Full && !flag && Sunshine.Instance.DebugView == ELAGEILFKFO.Status;
			if (!flag3)
			{
				int hhagihegfml = AGIEAMEGNJP.KKBKGPPHBHC(Sunshine.Instance.ScatterResolution);
				AOAHEAEHFLC aoaheaehflc = AOAHEAEHFLC.KKELDFDJJAG(new AOAHEAEHFLC(JONJODLFAEN.width, JONJODLFAEN.height), hhagihegfml);
				aoaheaehflc.OCNGPCPMCPM = Mathf.Max(aoaheaehflc.OCNGPCPMCPM, 1);
				aoaheaehflc.ADMFAEOOOHD = Mathf.Max(aoaheaehflc.ADMFAEOOOHD, 1);
				Sunshine.Instance.PostScatterMaterial.SetVector("InteractionObject Multiplier curve ", new Vector3((float)aoaheaehflc.OCNGPCPMCPM / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)aoaheaehflc.ADMFAEOOOHD / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 343f));
				RenderTexture temporary = RenderTexture.GetTemporary(aoaheaehflc.OCNGPCPMCPM, aoaheaehflc.ADMFAEOOOHD, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default);
				if (temporary)
				{
					temporary.filterMode = FilterMode.Bilinear;
					temporary.wrapMode = TextureWrapMode.Repeat;
					SunshinePostprocess.OGAPNKKPFOB(JONJODLFAEN, temporary, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
					if (flag)
					{
						Sunshine.Instance.PostBlurMaterial.SetFloat("_Refraction", Sunshine.Instance.ScatterBlurDepthTollerance);
						RenderTexture temporary2 = RenderTexture.GetTemporary(temporary.width, temporary.height, 0, temporary.format, RenderTextureReadWrite.Default);
						if (temporary2)
						{
							temporary2.filterMode = temporary.filterMode;
							temporary2.wrapMode = temporary.wrapMode;
							Sunshine.Instance.PostBlurMaterial.SetVector("\n", new Vector2(1626f, 819f));
							SunshinePostprocess.KKMMEIEIDJD(temporary, temporary2, Sunshine.Instance.PostBlurMaterial, 1);
							temporary.DiscardContents();
							Sunshine.Instance.PostBlurMaterial.SetVector("F3", new Vector2(875f, 1922f));
							SunshinePostprocess.OGAPNKKPFOB(temporary2, temporary, Sunshine.Instance.PostBlurMaterial, 0);
							RenderTexture.ReleaseTemporary(temporary2);
						}
					}
					temporary.filterMode = FilterMode.Bilinear;
					if (Sunshine.Instance.DebugView == ELAGEILFKFO.None)
					{
						SunshinePostprocess.Blit(temporary, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.ALHGMMKDBCH);
					}
					else
					{
						Sunshine.Instance.PostScatterMaterial.SetTexture("StormStrike", temporary);
						SunshinePostprocess.GAOOMGPDHJI(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.KDILJOFIENM);
					}
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					flag3 = false;
				}
			}
			if (flag3)
			{
				Sunshine.Instance.PostScatterMaterial.SetVector("usr_inf_a3", new Vector3((float)this.PBCOFIHKPHK.pixelWidth / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)this.MAMDEGFPOJF().pixelHeight / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 1565f));
				SunshinePostprocess.NLEBCJALNAF(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
			}
		}
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void HJDGOIGOMNE()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x000EFA80 File Offset: 0x000EDC80
	public void OnPostProcess(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!this.ENCODJMNOME)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		if (Sunshine.Instance.DebugView == ELAGEILFKFO.Cascades)
		{
			SunshinePostprocess.Blit(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.AKPGBLJGENB);
			return;
		}
		if (Sunshine.Instance.OAEKEMAJJFI)
		{
			bool flag = Sunshine.Instance.ScatterBlur;
			if (!Sunshine.Instance.CNIPBAGBCGI)
			{
				flag = false;
			}
			bool flag2 = Sunshine.Instance.OvercastAffectsScatter && (Sunshine.Instance.OvercastTexture || Sunshine.Instance.ScatterOvercastTexture);
			bool customScatterOvercast = Sunshine.Instance.CustomScatterOvercast;
			Texture2D fhjobhkhnbc = flag2 ? (customScatterOvercast ? Sunshine.Instance.ScatterOvercastTexture : Sunshine.Instance.OvercastTexture) : null;
			float ckafaggggpj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastScale : Sunshine.Instance.OvercastScale;
			Vector2 jjdfopcnboj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastMovement : Sunshine.Instance.OvercastMovement;
			float gbkoopajamg = customScatterOvercast ? Sunshine.Instance.ScatterOvercastPlaneHeight : Sunshine.Instance.OvercastPlaneHeight;
			this.EBDMMPDOEOL(flag2, fhjobhkhnbc, ckafaggggpj, jjdfopcnboj, gbkoopajamg);
			KGJFMLCOLLA.MCBCHPHDKMP(Sunshine.Instance.ScatterSamplingQuality);
			Sunshine.Instance.PostScatterMaterial.SetVector("ScatterColor", Sunshine.Instance.ScatterColor);
			if (Sunshine.Instance.ScatterAnimateNoise)
			{
				this.JLGMCIOCHPO += Time.deltaTime * Sunshine.Instance.ScatterAnimateNoiseSpeed;
				this.JLGMCIOCHPO -= Mathf.Floor(this.JLGMCIOCHPO);
			}
			Sunshine.Instance.PostScatterMaterial.SetTexture("ScatterDitherMap", Sunshine.Instance.ScatterDitherTexture);
			float value = 1f - Sunshine.Instance.ScatterExaggeration;
			float y = 1f / (Mathf.Clamp01(value) * Sunshine.Instance.IKAPDBDIILL / this.PBCOFIHKPHK.farClipPlane);
			float num = Sunshine.Instance.ScatterSky * Sunshine.Instance.ScatterIntensity;
			Sunshine.Instance.PostScatterMaterial.SetVector("ScatterIntensityVolumeSky", new Vector4(Sunshine.Instance.ScatterIntensity, y, num * 0.333f, num * 0.667f));
			bool flag3 = Sunshine.Instance.ScatterResolution == ILPBNIJPPGA.Full && !flag && Sunshine.Instance.DebugView != ELAGEILFKFO.Scatter;
			if (!flag3)
			{
				int hhagihegfml = AGIEAMEGNJP.KKBKGPPHBHC(Sunshine.Instance.ScatterResolution);
				AOAHEAEHFLC aoaheaehflc = AOAHEAEHFLC.FGDFOOKKLFI(new AOAHEAEHFLC(JONJODLFAEN.width, JONJODLFAEN.height), hhagihegfml);
				aoaheaehflc.OCNGPCPMCPM = Mathf.Max(aoaheaehflc.OCNGPCPMCPM, 1);
				aoaheaehflc.ADMFAEOOOHD = Mathf.Max(aoaheaehflc.ADMFAEOOOHD, 1);
				Sunshine.Instance.PostScatterMaterial.SetVector("ScatterDitherData", new Vector3((float)aoaheaehflc.OCNGPCPMCPM / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)aoaheaehflc.ADMFAEOOOHD / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(aoaheaehflc.OCNGPCPMCPM, aoaheaehflc.ADMFAEOOOHD, 0, JONJODLFAEN.format, RenderTextureReadWrite.Default);
				if (temporary)
				{
					temporary.filterMode = FilterMode.Point;
					temporary.wrapMode = TextureWrapMode.Clamp;
					SunshinePostprocess.Blit(JONJODLFAEN, temporary, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
					if (flag)
					{
						Sunshine.Instance.PostBlurMaterial.SetFloat("BlurDepthTollerance", Sunshine.Instance.ScatterBlurDepthTollerance);
						RenderTexture temporary2 = RenderTexture.GetTemporary(temporary.width, temporary.height, 0, temporary.format, RenderTextureReadWrite.Default);
						if (temporary2)
						{
							temporary2.filterMode = temporary.filterMode;
							temporary2.wrapMode = temporary.wrapMode;
							Sunshine.Instance.PostBlurMaterial.SetVector("BlurXY", new Vector2(1f, 0f));
							SunshinePostprocess.Blit(temporary, temporary2, Sunshine.Instance.PostBlurMaterial, 0);
							temporary.DiscardContents();
							Sunshine.Instance.PostBlurMaterial.SetVector("BlurXY", new Vector2(0f, 1f));
							SunshinePostprocess.Blit(temporary2, temporary, Sunshine.Instance.PostBlurMaterial, 0);
							RenderTexture.ReleaseTemporary(temporary2);
						}
					}
					temporary.filterMode = FilterMode.Bilinear;
					if (Sunshine.Instance.DebugView == ELAGEILFKFO.Scatter)
					{
						SunshinePostprocess.Blit(temporary, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.ALHGMMKDBCH);
					}
					else
					{
						Sunshine.Instance.PostScatterMaterial.SetTexture("_ScatterTexture", temporary);
						SunshinePostprocess.Blit(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.KDILJOFIENM);
					}
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					flag3 = true;
				}
			}
			if (flag3)
			{
				Sunshine.Instance.PostScatterMaterial.SetVector("ScatterDitherData", new Vector3((float)this.PBCOFIHKPHK.pixelWidth / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)this.PBCOFIHKPHK.pixelHeight / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 0f));
				SunshinePostprocess.Blit(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
			}
		}
	}

	// Token: 0x06001FD4 RID: 8148 RVA: 0x000EFFCC File Offset: 0x000EE1CC
	public bool JDEHEAIEECF()
	{
		return Sunshine.Instance && SunshineProjectPreferences.BOHEPIPHLKE().HBMFDLDIPOK() && Sunshine.Instance.SunLight && (this.MANKEDKGEFA().actualRenderingPath != (RenderingPath)5 && this.MAMDEGFPOJF().actualRenderingPath != RenderingPath.DeferredLighting) && this.MHIIJINPFMF() && this.MANKEDKGEFA().actualRenderingPath == RenderingPath.VertexLit;
	}

	// Token: 0x06001FD5 RID: 8149 RVA: 0x000F003C File Offset: 0x000EE23C
	public float CLELEIEJLPL()
	{
		EALFINIFFBB updateInterval = Sunshine.Instance.UpdateInterval;
		if (updateInterval == EALFINIFFBB.AfterXFrames)
		{
			return Sunshine.Instance.UpdateIntervalPadding;
		}
		if (updateInterval != EALFINIFFBB.EveryFrame)
		{
			return 1034f;
		}
		return Sunshine.Instance.UpdateIntervalMovement;
	}

	// Token: 0x06001FD6 RID: 8150 RVA: 0x000F0079 File Offset: 0x000EE279
	public bool OGCKIOLBGJC()
	{
		return SunshineProjectPreferences.CNMIMHNCHOL() && SunshineProjectPreferences.BMHGCKPCLIA().FOOAFBLOGGK() && !SunshineProjectPreferences.BMHGCKPCLIA().GDDEFCJIDDF() && SunshineProjectPreferences.IKNOAHKOOJE().ODIHKLNCFFB();
	}

	// Token: 0x06001FD7 RID: 8151 RVA: 0x000F00AD File Offset: 0x000EE2AD
	private void GJEGBPMANIH()
	{
		if (this.LPFLCDNGFKH())
		{
			Sunshine.Instance.SunLight.shadows = this.DHBJPHKGJJK;
			Sunshine.Instance.SunLight.renderMode = this.MKNILMAAAIN;
		}
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FD8 RID: 8152 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void LLFANOGKPKM()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FD9 RID: 8153 RVA: 0x000F00E6 File Offset: 0x000EE2E6
	private void JPENLOEBNNJ()
	{
		if (this.JDEHEAIEECF())
		{
			Sunshine.Instance.SunLight.shadows = this.DHBJPHKGJJK;
			Sunshine.Instance.SunLight.renderMode = this.MKNILMAAAIN;
		}
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FDA RID: 8154 RVA: 0x000F0120 File Offset: 0x000EE320
	public void CCFFELLGGPA(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!this.OCAABGOEDEO())
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		if (Sunshine.Instance.DebugView == ELAGEILFKFO.Status)
		{
			SunshinePostprocess.PELMNIFPDKC(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.AKPGBLJGENB);
			return;
		}
		if (Sunshine.Instance.OAEKEMAJJFI)
		{
			bool flag = Sunshine.Instance.ScatterBlur;
			if (!Sunshine.Instance.CNIPBAGBCGI)
			{
				flag = true;
			}
			bool flag2 = !Sunshine.Instance.OvercastAffectsScatter || (!Sunshine.Instance.OvercastTexture && Sunshine.Instance.ScatterOvercastTexture);
			bool customScatterOvercast = Sunshine.Instance.CustomScatterOvercast;
			Texture2D fhjobhkhnbc = flag2 ? (customScatterOvercast ? Sunshine.Instance.ScatterOvercastTexture : Sunshine.Instance.OvercastTexture) : null;
			float ckafaggggpj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastScale : Sunshine.Instance.OvercastScale;
			Vector2 jjdfopcnboj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastMovement : Sunshine.Instance.OvercastMovement;
			float gbkoopajamg = customScatterOvercast ? Sunshine.Instance.ScatterOvercastPlaneHeight : Sunshine.Instance.OvercastPlaneHeight;
			this.LNAKDJKAOHF(flag2, fhjobhkhnbc, ckafaggggpj, jjdfopcnboj, gbkoopajamg);
			KGJFMLCOLLA.MCBCHPHDKMP(Sunshine.Instance.ScatterSamplingQuality);
			Sunshine.Instance.PostScatterMaterial.SetVector("Load", Sunshine.Instance.ScatterColor);
			if (Sunshine.Instance.ScatterAnimateNoise)
			{
				this.JLGMCIOCHPO += Time.deltaTime * Sunshine.Instance.ScatterAnimateNoiseSpeed;
				this.JLGMCIOCHPO -= Mathf.Floor(this.JLGMCIOCHPO);
			}
			Sunshine.Instance.PostScatterMaterial.SetTexture("IceHockeyGoalieReady", Sunshine.Instance.ScatterDitherTexture);
			float value = 50f - Sunshine.Instance.ScatterExaggeration;
			float y = 1076f / (Mathf.Clamp01(value) * Sunshine.Instance.GPCLGNGKACN() / this.CAMDGCDDHDK().farClipPlane);
			float num = Sunshine.Instance.ScatterSky * Sunshine.Instance.ScatterIntensity;
			Sunshine.Instance.PostScatterMaterial.SetVector("OneHandSwordRun", new Vector4(Sunshine.Instance.ScatterIntensity, y, num * 1753f, num * 1392f));
			bool flag3 = Sunshine.Instance.ScatterResolution == ILPBNIJPPGA.Full && !flag && Sunshine.Instance.DebugView != (ELAGEILFKFO)4;
			if (!flag3)
			{
				int hhagihegfml = AGIEAMEGNJP.KKBKGPPHBHC(Sunshine.Instance.ScatterResolution);
				AOAHEAEHFLC aoaheaehflc = AOAHEAEHFLC.PEFLKPDGOAO(new AOAHEAEHFLC(JONJODLFAEN.width, JONJODLFAEN.height), hhagihegfml);
				aoaheaehflc.OCNGPCPMCPM = Mathf.Max(aoaheaehflc.OCNGPCPMCPM, 1);
				aoaheaehflc.ADMFAEOOOHD = Mathf.Max(aoaheaehflc.ADMFAEOOOHD, 1);
				Sunshine.Instance.PostScatterMaterial.SetVector("fishStamKF=", new Vector3((float)aoaheaehflc.OCNGPCPMCPM / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)aoaheaehflc.ADMFAEOOOHD / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 1322f));
				RenderTexture temporary = RenderTexture.GetTemporary(aoaheaehflc.OCNGPCPMCPM, aoaheaehflc.ADMFAEOOOHD, 1, JONJODLFAEN.format, RenderTextureReadWrite.Default);
				if (temporary)
				{
					temporary.filterMode = FilterMode.Bilinear;
					temporary.wrapMode = TextureWrapMode.Repeat;
					SunshinePostprocess.JIPLNFFBLIM(JONJODLFAEN, temporary, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
					if (flag)
					{
						Sunshine.Instance.PostBlurMaterial.SetFloat("Method called requires VPaint Object to be dynamic. Set VPaintObject.isDynamic to true before calling this method.", Sunshine.Instance.ScatterBlurDepthTollerance);
						RenderTexture temporary2 = RenderTexture.GetTemporary(temporary.width, temporary.height, 0, temporary.format, RenderTextureReadWrite.Linear);
						if (temporary2)
						{
							temporary2.filterMode = temporary.filterMode;
							temporary2.wrapMode = temporary.wrapMode;
							Sunshine.Instance.PostBlurMaterial.SetVector("_LerpRgbTex", new Vector2(816f, 1456f));
							SunshinePostprocess.CGDKCJCPMLP(temporary, temporary2, Sunshine.Instance.PostBlurMaterial, 0);
							temporary.DiscardContents();
							Sunshine.Instance.PostBlurMaterial.SetVector("Ready Fight", new Vector2(368f, 1933f));
							SunshinePostprocess.PELMNIFPDKC(temporary2, temporary, Sunshine.Instance.PostBlurMaterial, 0);
							RenderTexture.ReleaseTemporary(temporary2);
						}
					}
					temporary.filterMode = FilterMode.Bilinear;
					if (Sunshine.Instance.DebugView == (ELAGEILFKFO)8)
					{
						SunshinePostprocess.OGAPNKKPFOB(temporary, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.ALHGMMKDBCH);
					}
					else
					{
						Sunshine.Instance.PostScatterMaterial.SetTexture("", temporary);
						SunshinePostprocess.ICDCCJNKAMO(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.KDILJOFIENM);
					}
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					flag3 = true;
				}
			}
			if (flag3)
			{
				Sunshine.Instance.PostScatterMaterial.SetVector("Front Kick", new Vector3((float)this.CAMDGCDDHDK().pixelWidth / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)this.MANKEDKGEFA().pixelHeight / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 1362f));
				SunshinePostprocess.PIGDHOBCJBJ(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
			}
		}
	}

	// Token: 0x06001FDB RID: 8155 RVA: 0x000F066C File Offset: 0x000EE86C
	public bool GDPBDPJFJGJ()
	{
		return !Sunshine.Instance || !SunshineProjectPreferences.BMHGCKPCLIA().EPAHGPGBGFH() || !Sunshine.Instance.SunLight || (this.PBCOFIHKPHK.actualRenderingPath != (RenderingPath)8 && this.MAMDEGFPOJF().actualRenderingPath != (RenderingPath)6 && this.JNNLLODHEKB() && this.MAMDEGFPOJF().actualRenderingPath == RenderingPath.Forward);
	}

	// Token: 0x06001FDC RID: 8156 RVA: 0x000F06DC File Offset: 0x000EE8DC
	private void LFKOHBPGANM()
	{
		if (!this.ENCODJMNOME)
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.PMGLGNDMCFE();
		this.KHOPEEGJCBB();
		if (this.JDEHEAIEECF())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.None;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.LDCFMGLFIJP() && (this.MAMDEGFPOJF().depthTextureMode & DepthTextureMode.Depth) <= DepthTextureMode.None && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.MANKEDKGEFA().depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06001FDD RID: 8157 RVA: 0x000F0790 File Offset: 0x000EE990
	public bool LIDGGCELNJP()
	{
		if (!base.enabled)
		{
			return true;
		}
		if (!Sunshine.Instance || !Sunshine.Instance.enabled)
		{
			return false;
		}
		if (this.GDPBDPJFJGJ())
		{
			if (Sunshine.Instance.NBOKNEEHPHK() && SystemInfo.graphicsShaderLevel < 71)
			{
				return true;
			}
			if (!Sunshine.Instance.NBOKNEEHPHK() && SystemInfo.graphicsShaderLevel < -46)
			{
				return false;
			}
		}
		else if (!Sunshine.Instance.AABOCFACFNH())
		{
			return false;
		}
		return Sunshine.Instance.GPCLGNGKACN() > 1549f && (!Sunshine.Instance.Lightmap || !Sunshine.Instance.SunLight || (Sunshine.Instance.SunLight.enabled && Sunshine.Instance.Ready));
	}

	// Token: 0x06001FDE RID: 8158 RVA: 0x000F085C File Offset: 0x000EEA5C
	private void DEBECJLDHEM()
	{
		if (!this.KHONMOMFFHJ())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.PMGLGNDMCFE();
		this.KHOPEEGJCBB();
		if (this.LPFLCDNGFKH())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.Hard;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.AABOCFACFNH() && (this.PBCOFIHKPHK.depthTextureMode & DepthTextureMode.None) <= DepthTextureMode.Depth && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.MANKEDKGEFA().depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06001FDF RID: 8159 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void HPGMKBPAFGM()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FE0 RID: 8160 RVA: 0x000F0910 File Offset: 0x000EEB10
	public bool NeedsRefresh(Vector3 JHCIACLOOKN)
	{
		if (!Application.isPlaying)
		{
			return true;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			return false;
		}
		bool flag = this.ICIPPICFGLJ;
		switch (Sunshine.Instance.UpdateInterval)
		{
		case EALFINIFFBB.EveryFrame:
			flag = true;
			break;
		case EALFINIFFBB.AfterXFrames:
			flag = (flag || Time.frameCount <= 3 || Time.frameCount % Sunshine.Instance.UpdateIntervalFrames == 0);
			break;
		case EALFINIFFBB.AfterXMovement:
			if (Time.frameCount <= 3)
			{
				flag = true;
			}
			else
			{
				Vector3 vector = JHCIACLOOKN - this.KPIHENHAKMI;
				flag = (flag || vector.sqrMagnitude >= Sunshine.Instance.UpdateIntervalMovement * Sunshine.Instance.UpdateIntervalMovement);
			}
			break;
		}
		if (flag)
		{
			this.KPIHENHAKMI = JHCIACLOOKN;
		}
		return flag;
	}

	// Token: 0x06001FE1 RID: 8161 RVA: 0x000F09D0 File Offset: 0x000EEBD0
	private void KHOPEEGJCBB()
	{
		if (this.BKIPCPPJNDF)
		{
			KGJFMLCOLLA.LCLNIFDELOI(Sunshine.Instance.ShadowFilter);
		}
		else
		{
			KGJFMLCOLLA.OHKCLACEIIB();
		}
		Matrix4x4 lhs = Matrix4x4.identity;
		lhs = AGIEAMEGNJP.JIAGAFDEGMP(Sunshine.Instance.CascadeRect(0)) * Sunshine.Instance.LCLEJAIDKHB.projectionMatrix;
		AGIEAMEGNJP.IGLCHAAHILP(ref lhs, Sunshine.Instance.LCLEJAIDKHB.farClipPlane);
		Matrix4x4 matrix4x = lhs * Sunshine.Instance.LCLEJAIDKHB.worldToCameraMatrix;
		Matrix4x4 value = matrix4x * this.PBCOFIHKPHK.cameraToWorldMatrix;
		Shader.SetGlobalMatrix("sunshine_CameraVToSunVP", value);
		Shader.SetGlobalMatrix("sunshine_WorldToSunVP", matrix4x);
		float num = (float)Sunshine.Instance.Lightmap.width;
		Shader.SetGlobalVector("sunshine_ShadowParamsAndHalfTexel", new Vector4(Sunshine.Instance.SunLight.shadowStrength, Sunshine.Instance.CascadeFade, 0.5f / num, 0.5f / num));
		this.CFIPCAKPDKG(this.PBCOFIHKPHK.farClipPlane);
		Vector3 position = this.PBCOFIHKPHK.orthographic ? this.PBCOFIHKPHK.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)) : base.transform.position;
		Vector3 position2 = this.PBCOFIHKPHK.ViewportToWorldPoint(new Vector3(0f, 0f, this.PBCOFIHKPHK.farClipPlane));
		Vector3 position3 = this.PBCOFIHKPHK.ViewportToWorldPoint(new Vector3(1f, 0f, this.PBCOFIHKPHK.farClipPlane));
		Vector3 position4 = this.PBCOFIHKPHK.ViewportToWorldPoint(new Vector3(0f, 1f, this.PBCOFIHKPHK.farClipPlane));
		Vector3 vector = Sunshine.Instance.LCLEJAIDKHB.transform.InverseTransformPoint(position);
		Vector3 vector2 = Sunshine.Instance.LCLEJAIDKHB.transform.InverseTransformPoint(position2);
		Vector3 vector3 = Sunshine.Instance.LCLEJAIDKHB.transform.InverseTransformPoint(position3);
		Vector3 vector4 = Sunshine.Instance.LCLEJAIDKHB.transform.InverseTransformPoint(position4);
		Vector2 vector5 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.LCLEJAIDKHB.WorldToViewportPoint(position));
		Vector2 vector6 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.LCLEJAIDKHB.WorldToViewportPoint(position2));
		Vector2 vector7 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.LCLEJAIDKHB.WorldToViewportPoint(position3));
		Vector2 vector8 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.LCLEJAIDKHB.WorldToViewportPoint(position4));
		Vector4 vector9 = new Vector4(vector6.x, vector6.y, vector2.z / Sunshine.Instance.LCLEJAIDKHB.farClipPlane, vector.y);
		Vector4 vector10 = new Vector4(vector5.x, vector5.y, vector.z / Sunshine.Instance.LCLEJAIDKHB.farClipPlane, vector.y);
		Vector4 value2 = vector9 - vector10;
		Vector4 value3 = new Vector4(vector7.x, vector7.y, vector3.z / Sunshine.Instance.LCLEJAIDKHB.farClipPlane, vector3.y) - vector9;
		Vector4 value4 = new Vector4(vector8.x, vector8.y, vector4.z / Sunshine.Instance.LCLEJAIDKHB.farClipPlane, vector4.y) - vector9;
		Rect rect = Sunshine.Instance.CascadeRect(0);
		AGIEAMEGNJP.NODBGEOENGP(ref vector10, ref rect);
		AGIEAMEGNJP.IJBPJGDAEHO(ref value2, ref rect);
		AGIEAMEGNJP.IJBPJGDAEHO(ref value3, ref rect);
		AGIEAMEGNJP.IJBPJGDAEHO(ref value4, ref rect);
		Shader.SetGlobalFloat("sunshine_IsOrthographic", this.PBCOFIHKPHK.orthographic ? 1f : 0f);
		Shader.SetGlobalVector("sunshine_ShadowCoordDepthStart", vector10);
		Shader.SetGlobalVector("sunshine_ShadowCoordDepthRayZ", value2);
		Shader.SetGlobalVector("sunshine_ShadowCoordDepthRayU", value3);
		Shader.SetGlobalVector("sunshine_ShadowCoordDepthRayV", value4);
		float num2 = Sunshine.Instance.LCLEJAIDKHB.orthographicSize * 2f;
		Vector2 vector11 = new Vector2(num2, num2);
		vector11.x /= rect.width;
		vector11.y /= rect.height;
		Vector3 v = new Vector3(vector11.x, vector11.y, Sunshine.Instance.LCLEJAIDKHB.farClipPlane) / this.PBCOFIHKPHK.farClipPlane;
		Shader.SetGlobalVector("sunshine_ShadowToWorldScale", v);
		Matrix4x4 zero = Matrix4x4.zero;
		Vector3 position5 = Sunshine.Instance.LCLEJAIDKHB.ViewportToWorldPoint(new Vector3(0f, 0f, 0f));
		Vector3 position6 = Sunshine.Instance.LCLEJAIDKHB.ViewportToWorldPoint(new Vector3(1f, 1f, 0f));
		for (int i = 0; i < Sunshine.Instance.GLFMGABJGLG; i++)
		{
			Vector4 vector12 = new Vector4(0f, 0f, 1f, 1f);
			if (i > 0)
			{
				Camera camera = Sunshine.Instance.SunLightCameras[i];
				Vector3 vector13 = camera.WorldToViewportPoint(position5);
				Vector3 vector14 = camera.WorldToViewportPoint(position6);
				vector12 = new Vector4(vector13.x, vector13.y, vector14.x, vector14.y);
			}
			Rect rect2 = Sunshine.Instance.CascadeRect(i);
			vector12.x = rect2.xMin + rect2.width * vector12.x;
			vector12.y = rect2.yMin + rect2.height * vector12.y;
			vector12.z = rect2.xMin + rect2.width * vector12.z;
			vector12.w = rect2.yMin + rect2.height * vector12.w;
			vector12.z -= vector12.x;
			vector12.w -= vector12.y;
			zero.SetRow(i, vector12);
		}
		Vector4 row = zero.GetRow(0);
		for (int j = 0; j < Sunshine.Instance.GLFMGABJGLG; j++)
		{
			Vector4 row2 = zero.GetRow(j);
			row2.z /= row.z;
			row2.w /= row.w;
			zero.SetRow(j, row2);
		}
		bool flag = Sunshine.Instance.OvercastTexture;
		this.EBDMMPDOEOL(flag, flag ? Sunshine.Instance.OvercastTexture : Sunshine.Instance.BlankOvercastTexture, Sunshine.Instance.OvercastScale, Sunshine.Instance.OvercastMovement, Sunshine.Instance.OvercastPlaneHeight);
		Shader.SetGlobalMatrix("sunshine_CascadeRanges", zero);
		KGJFMLCOLLA.NAIPHNFEDOA(Sunshine.Instance.GLFMGABJGLG);
	}

	// Token: 0x06001FE2 RID: 8162 RVA: 0x000ED094 File Offset: 0x000EB294
	private void EMOFOHBMJBD()
	{
		this.PKBBECJDICB = base.GetComponent<SunshinePostprocess>();
		if (this.PKBBECJDICB == null)
		{
			this.PKBBECJDICB = base.gameObject.AddComponent<SunshinePostprocess>();
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x000F1090 File Offset: 0x000EF290
	public bool BKIPCPPJNDF
	{
		get
		{
			return Sunshine.Instance && SunshineProjectPreferences.Instance.UseCustomShadows && Sunshine.Instance.SunLight && (this.PBCOFIHKPHK.actualRenderingPath == RenderingPath.DeferredLighting || this.PBCOFIHKPHK.actualRenderingPath == RenderingPath.DeferredShading || (this.PAAJCIMAIFC && this.PBCOFIHKPHK.actualRenderingPath == RenderingPath.Forward));
		}
	}

	// Token: 0x06001FE4 RID: 8164 RVA: 0x000F1100 File Offset: 0x000EF300
	private void HPDDHIBIBNO()
	{
		if (!this.KHONMOMFFHJ())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.GKPIDBEPGBK();
		this.JHIHCMEHPEC();
		if (this.IKGAMGGKBIC())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.Hard;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.EJMICEIEACD && (this.MAMDEGFPOJF().depthTextureMode & DepthTextureMode.Depth) <= DepthTextureMode.Depth && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.MAMDEGFPOJF().depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06001FE5 RID: 8165 RVA: 0x000F11B4 File Offset: 0x000EF3B4
	public float KCJNFGBJBEG()
	{
		EALFINIFFBB updateInterval = Sunshine.Instance.UpdateInterval;
		if (updateInterval == EALFINIFFBB.EveryFrame)
		{
			return Sunshine.Instance.UpdateIntervalPadding;
		}
		if (updateInterval != (EALFINIFFBB)6)
		{
			return 1119f;
		}
		return Sunshine.Instance.UpdateIntervalMovement;
	}

	// Token: 0x06001FE6 RID: 8166 RVA: 0x000F11F4 File Offset: 0x000EF3F4
	public bool KHONMOMFFHJ()
	{
		if (!base.enabled)
		{
			return true;
		}
		if (!Sunshine.Instance || !Sunshine.Instance.enabled)
		{
			return false;
		}
		if (this.BKIPCPPJNDF)
		{
			if (Sunshine.Instance.AGGFIMJNJAH && SystemInfo.graphicsShaderLevel < 104)
			{
				return false;
			}
			if (!Sunshine.Instance.OGOGAJFPMAJ() && SystemInfo.graphicsShaderLevel < -123)
			{
				return false;
			}
		}
		else if (!Sunshine.Instance.LDCFMGLFIJP())
		{
			return false;
		}
		return Sunshine.Instance.EKMANDAOHBK() <= 1244f || !Sunshine.Instance.Lightmap || (Sunshine.Instance.SunLight && (!Sunshine.Instance.SunLight.enabled || Sunshine.Instance.Ready));
	}

	// Token: 0x06001FE7 RID: 8167 RVA: 0x000EDB3A File Offset: 0x000EBD3A
	public void HAJOBBCOGJO()
	{
		this.ICIPPICFGLJ = true;
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x000F12BF File Offset: 0x000EF4BF
	public bool CFPDFGMJFAJ()
	{
		return !SunshineProjectPreferences.BOHEPIPHLKE() || !SunshineProjectPreferences.LNBOJBKNKIE().KLDECMCDEJD() || (!SunshineProjectPreferences.LNBOJBKNKIE().OHJENNCBFLJ() && SunshineProjectPreferences.OALCDNGFHDM().IBCHOBCLCPF());
	}

	// Token: 0x06001FE9 RID: 8169 RVA: 0x000F12F3 File Offset: 0x000EF4F3
	public bool JNNLLODHEKB()
	{
		return SunshineProjectPreferences.IKNOAHKOOJE() && SunshineProjectPreferences.OALCDNGFHDM().MIDMNBFICEC() && !SunshineProjectPreferences.DGHEMKDENOC().OHJENNCBFLJ() && SunshineProjectPreferences.Instance.NGGOGCONNIO();
	}

	// Token: 0x06001FEA RID: 8170 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void NOOBBMALENG()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x000EE603 File Offset: 0x000EC803
	public void GJIEGOJCBBK()
	{
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x06001FEC RID: 8172 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void AGNGEJGGBGB()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FED RID: 8173 RVA: 0x000F1328 File Offset: 0x000EF528
	public bool JPIJIGJHOPK(Vector3 JHCIACLOOKN)
	{
		if (!Application.isPlaying)
		{
			return true;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			return true;
		}
		bool flag = this.ICIPPICFGLJ;
		switch (Sunshine.Instance.UpdateInterval)
		{
		case EALFINIFFBB.EveryFrame:
			flag = false;
			break;
		case EALFINIFFBB.AfterXFrames:
			flag = (flag || Time.frameCount <= 3 || Time.frameCount % Sunshine.Instance.UpdateIntervalFrames == 0);
			break;
		case EALFINIFFBB.AfterXMovement:
			if (Time.frameCount <= 4)
			{
				flag = false;
			}
			else
			{
				Vector3 vector = JHCIACLOOKN - this.KPIHENHAKMI;
				flag = (flag || vector.sqrMagnitude < Sunshine.Instance.UpdateIntervalMovement * Sunshine.Instance.UpdateIntervalMovement);
			}
			break;
		}
		if (flag)
		{
			this.KPIHENHAKMI = JHCIACLOOKN;
		}
		return flag;
	}

	// Token: 0x06001FEE RID: 8174 RVA: 0x000F13E8 File Offset: 0x000EF5E8
	private void PDLCGJMHDHE()
	{
		if (!this.HOJIOHBBKOJ())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.GEMAIPCFMAA();
		this.DIKEBPJHJGD();
		if (this.FPLHIOKIEBJ())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.None;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.AABOCFACFNH() && (this.CAMDGCDDHDK().depthTextureMode & DepthTextureMode.None) <= DepthTextureMode.Depth && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.NJCAJOAFICB().depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06001FEF RID: 8175 RVA: 0x000F149C File Offset: 0x000EF69C
	private void CFIPCAKPDKG(float JOCGKBDMKLO)
	{
		float num = Sunshine.Instance.IKAPDBDIILL / JOCGKBDMKLO;
		if (this.PBCOFIHKPHK.orthographic)
		{
			num = 99999f;
		}
		Vector4 vector = new Vector4(Sunshine.Instance.CascadeNearClipScale(0) * num, Sunshine.Instance.CascadeNearClipScale(1) * num, Sunshine.Instance.CascadeNearClipScale(2) * num, Sunshine.Instance.CascadeNearClipScale(3) * num);
		Shader.SetGlobalVector("sunshine_CascadeNearRatiosSq", new Vector4(vector.x * vector.x, vector.y * vector.y, vector.z * vector.z, vector.w * vector.w));
		Vector4 vector2 = new Vector4(Sunshine.Instance.CascadeFarClipScale(0) * num, Sunshine.Instance.CascadeFarClipScale(1) * num, Sunshine.Instance.CascadeFarClipScale(2) * num, Sunshine.Instance.CascadeFarClipScale(3) * num);
		Shader.SetGlobalVector("sunshine_CascadeFarRatiosSq", new Vector4(vector2.x * vector2.x, vector2.y * vector2.y, vector2.z * vector2.z, vector2.w * vector2.w));
		float num2 = this.PBCOFIHKPHK.orthographic ? 1E+09f : Sunshine.Instance.IKAPDBDIILL;
		float f = Mathf.Clamp(this.PBCOFIHKPHK.orthographic ? 1E-05f : Sunshine.Instance.LightFadeRatio, 1E-06f, 1f);
		float num3 = 1f / Mathf.Sqrt(f);
		float num4 = JOCGKBDMKLO / num2 * num3;
		num3 *= num3;
		num4 *= num4;
		Shader.SetGlobalVector("sunshine_ShadowFadeParams", new Vector3(num3, num4, num));
	}

	// Token: 0x06001FF0 RID: 8176 RVA: 0x000F1654 File Offset: 0x000EF854
	private void BKIFIOFMBHB()
	{
		if (!this.HOJIOHBBKOJ())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.GBHKJNJKDIM();
		this.DIKEBPJHJGD();
		if (this.BKIPCPPJNDF)
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.Hard;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.LDCFMGLFIJP() && (this.CAMDGCDDHDK().depthTextureMode & DepthTextureMode.None) <= DepthTextureMode.Depth && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.CAMDGCDDHDK().depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06001FF1 RID: 8177 RVA: 0x000F1708 File Offset: 0x000EF908
	private void KKKNPFAPPNB(float JOCGKBDMKLO)
	{
		float num = Sunshine.Instance.EKMANDAOHBK() / JOCGKBDMKLO;
		if (this.MANKEDKGEFA().orthographic)
		{
			num = 4f;
		}
		Vector4 vector = new Vector4(Sunshine.Instance.CascadeNearClipScale(0) * num, Sunshine.Instance.AAEINNEFIJN(0) * num, Sunshine.Instance.AAEINNEFIJN(8) * num, Sunshine.Instance.GNAGHGEBHHP(8) * num);
		Shader.SetGlobalVector("_WrinkleInfluences0", new Vector4(vector.x * vector.x, vector.y * vector.y, vector.z * vector.z, vector.w * vector.w));
		Vector4 vector2 = new Vector4(Sunshine.Instance.CascadeFarClipScale(0) * num, Sunshine.Instance.IMCJONLGJPP(1) * num, Sunshine.Instance.KIJEHCMAKMD(8) * num, Sunshine.Instance.IMCJONLGJPP(5) * num);
		Shader.SetGlobalVector("WorkerHammer", new Vector4(vector2.x * vector2.x, vector2.y * vector2.y, vector2.z * vector2.z, vector2.w * vector2.w));
		float num2 = this.CAMDGCDDHDK().orthographic ? 1720f : Sunshine.Instance.EKMANDAOHBK();
		float f = Mathf.Clamp(this.NJCAJOAFICB().orthographic ? 765f : Sunshine.Instance.LightFadeRatio, 1799f, 891f);
		float num3 = 1237f / Mathf.Sqrt(f);
		float num4 = JOCGKBDMKLO / num2 * num3;
		num3 *= num3;
		num4 *= num4;
		Shader.SetGlobalVector("ComeHere", new Vector3(num3, num4, num));
	}

	// Token: 0x06001FF2 RID: 8178 RVA: 0x000F18C0 File Offset: 0x000EFAC0
	private void ELOEBKBLKEE()
	{
		if (!this.OCAABGOEDEO())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.AIKGKLKHIIB();
		this.DIKEBPJHJGD();
		if (this.IKGAMGGKBIC())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.Hard;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.AABOCFACFNH() && (this.NJCAJOAFICB().depthTextureMode & DepthTextureMode.None) <= DepthTextureMode.Depth && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.PBCOFIHKPHK.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06001FF3 RID: 8179 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void DHNBFPLALFA()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06001FF4 RID: 8180 RVA: 0x000F1974 File Offset: 0x000EFB74
	public bool GAFLLCNMJGG()
	{
		return !Sunshine.Instance || !SunshineProjectPreferences.CNMIMHNCHOL().HBMFDLDIPOK() || !Sunshine.Instance.SunLight || (this.NJCAJOAFICB().actualRenderingPath != (RenderingPath)7 && this.PBCOFIHKPHK.actualRenderingPath != (RenderingPath)8 && (!this.OGCKIOLBGJC() || this.MANKEDKGEFA().actualRenderingPath == RenderingPath.Forward));
	}

	// Token: 0x06001FF5 RID: 8181 RVA: 0x000F19E4 File Offset: 0x000EFBE4
	private void GJMGJJOEHAK(bool HIFLOPIPNHN, Texture2D FHJOBHKHNBC, float CKAFAGGGGPJ, Vector2 JJDFOPCNBOJ, float GBKOOPAJAMG = 0f)
	{
		if (!FHJOBHKHNBC)
		{
			HIFLOPIPNHN = false;
		}
		Shader.SetGlobalTexture("512", HIFLOPIPNHN ? FHJOBHKHNBC : Sunshine.Instance.BlankOvercastTexture);
		KGJFMLCOLLA.BGONIHCHINJ(HIFLOPIPNHN);
		if (HIFLOPIPNHN)
		{
			Camera camera = Sunshine.Instance.HFFINGMHGFE();
			Ray ray = camera.ViewportPointToRay(new Vector3(1239f, 1538f, 245f));
			float num = camera.farClipPlane - camera.nearClipPlane;
			float num2 = ray.direction.y * num;
			if (Mathf.Abs(num2) < 755f)
			{
				num2 = 202f;
			}
			float num3 = (GBKOOPAJAMG - ray.origin.y) / num2;
			Vector3 vector = ray.GetPoint(num3 * num);
			Ray ray2 = camera.ViewportPointToRay(new Vector3(717f, 1742f, 1754f));
			float num4 = (GBKOOPAJAMG - ray2.origin.y) / num2;
			Vector3 vector2 = ray2.GetPoint(num4 * num);
			Ray ray3 = camera.ViewportPointToRay(new Vector3(1899f, 1370f, 594f));
			float num5 = (GBKOOPAJAMG - ray3.origin.y) / num2;
			Vector3 vector3 = ray3.GetPoint(num5 * num);
			Vector3 b = new Vector3(JJDFOPCNBOJ.x, 532f, JJDFOPCNBOJ.y) * Time.timeSinceLevelLoad;
			vector += b;
			vector2 += b;
			vector3 += b;
			Vector2 vector4 = new Vector2(vector.x, vector.z);
			Vector2 vector5 = new Vector2(vector2.x, vector2.z) - vector4;
			Vector2 vector6 = new Vector2(vector3.x, vector3.z) - vector4;
			Rect rect = Sunshine.Instance.INGBKLGAKHD(0);
			Vector2 a = new Vector2(vector4.x, vector4.y);
			Vector4 a2 = new Vector4(vector5.x / rect.width, vector5.y / rect.width, vector6.x / rect.height, vector6.y / rect.height);
			Shader.SetGlobalVector("#402000", a * (1459f / CKAFAGGGGPJ));
			Shader.SetGlobalVector("repair.ogg", a2 * (218f / CKAFAGGGGPJ));
		}
	}

	// Token: 0x06001FF6 RID: 8182 RVA: 0x000F1C3C File Offset: 0x000EFE3C
	private void LNAKDJKAOHF(bool HIFLOPIPNHN, Texture2D FHJOBHKHNBC, float CKAFAGGGGPJ, Vector2 JJDFOPCNBOJ, float GBKOOPAJAMG = 0f)
	{
		if (!FHJOBHKHNBC)
		{
			HIFLOPIPNHN = false;
		}
		Shader.SetGlobalTexture("_Rotation", HIFLOPIPNHN ? FHJOBHKHNBC : Sunshine.Instance.BlankOvercastTexture);
		KGJFMLCOLLA.BGONIHCHINJ(HIFLOPIPNHN);
		if (HIFLOPIPNHN)
		{
			Camera camera = Sunshine.Instance.DMKPBPHOKFO();
			Ray ray = camera.ViewportPointToRay(new Vector3(602f, 1713f, 521f));
			float num = camera.farClipPlane - camera.nearClipPlane;
			float num2 = ray.direction.y * num;
			if (Mathf.Abs(num2) < 1927f)
			{
				num2 = 640f;
			}
			float num3 = (GBKOOPAJAMG - ray.origin.y) / num2;
			Vector3 vector = ray.GetPoint(num3 * num);
			Ray ray2 = camera.ViewportPointToRay(new Vector3(1550f, 1235f, 747f));
			float num4 = (GBKOOPAJAMG - ray2.origin.y) / num2;
			Vector3 vector2 = ray2.GetPoint(num4 * num);
			Ray ray3 = camera.ViewportPointToRay(new Vector3(73f, 1666f, 173f));
			float num5 = (GBKOOPAJAMG - ray3.origin.y) / num2;
			Vector3 vector3 = ray3.GetPoint(num5 * num);
			Vector3 b = new Vector3(JJDFOPCNBOJ.x, 714f, JJDFOPCNBOJ.y) * Time.timeSinceLevelLoad;
			vector += b;
			vector2 += b;
			vector3 += b;
			Vector2 vector4 = new Vector2(vector.x, vector.z);
			Vector2 vector5 = new Vector2(vector2.x, vector2.z) - vector4;
			Vector2 vector6 = new Vector2(vector3.x, vector3.z) - vector4;
			Rect rect = Sunshine.Instance.IMKIOIJEKON(0);
			Vector2 a = new Vector2(vector4.x, vector4.y);
			Vector4 a2 = new Vector4(vector5.x / rect.width, vector5.y / rect.width, vector6.x / rect.height, vector6.y / rect.height);
			Shader.SetGlobalVector("CratePull", a * (154f / CKAFAGGGGPJ));
			Shader.SetGlobalVector("_RgbTex", a2 * (1029f / CKAFAGGGGPJ));
		}
	}

	// Token: 0x06001FF7 RID: 8183 RVA: 0x000F1E94 File Offset: 0x000F0094
	private void IIJCMNEFNCB(bool HIFLOPIPNHN, Texture2D FHJOBHKHNBC, float CKAFAGGGGPJ, Vector2 JJDFOPCNBOJ, float GBKOOPAJAMG = 0f)
	{
		if (!FHJOBHKHNBC)
		{
			HIFLOPIPNHN = true;
		}
		Shader.SetGlobalTexture("L", HIFLOPIPNHN ? FHJOBHKHNBC : Sunshine.Instance.BlankOvercastTexture);
		KGJFMLCOLLA.BGONIHCHINJ(HIFLOPIPNHN);
		if (HIFLOPIPNHN)
		{
			Camera camera = Sunshine.Instance.HFFINGMHGFE();
			Ray ray = camera.ViewportPointToRay(new Vector3(1928f, 457f, 1788f));
			float num = camera.farClipPlane - camera.nearClipPlane;
			float num2 = ray.direction.y * num;
			if (Mathf.Abs(num2) < 1272f)
			{
				num2 = 1538f;
			}
			float num3 = (GBKOOPAJAMG - ray.origin.y) / num2;
			Vector3 vector = ray.GetPoint(num3 * num);
			Ray ray2 = camera.ViewportPointToRay(new Vector3(1380f, 1812f, 395f));
			float num4 = (GBKOOPAJAMG - ray2.origin.y) / num2;
			Vector3 vector2 = ray2.GetPoint(num4 * num);
			Ray ray3 = camera.ViewportPointToRay(new Vector3(692f, 883f, 393f));
			float num5 = (GBKOOPAJAMG - ray3.origin.y) / num2;
			Vector3 vector3 = ray3.GetPoint(num5 * num);
			Vector3 b = new Vector3(JJDFOPCNBOJ.x, 1924f, JJDFOPCNBOJ.y) * Time.timeSinceLevelLoad;
			vector += b;
			vector2 += b;
			vector3 += b;
			Vector2 vector4 = new Vector2(vector.x, vector.z);
			Vector2 vector5 = new Vector2(vector2.x, vector2.z) - vector4;
			Vector2 vector6 = new Vector2(vector3.x, vector3.z) - vector4;
			Rect rect = Sunshine.Instance.INGBKLGAKHD(0);
			Vector2 a = new Vector2(vector4.x, vector4.y);
			Vector4 a2 = new Vector4(vector5.x / rect.width, vector5.y / rect.width, vector6.x / rect.height, vector6.y / rect.height);
			Shader.SetGlobalVector(" is represented multiple times in the Bones.", a * (753f / CKAFAGGGGPJ));
			Shader.SetGlobalVector("[ACTk] WallHack Detector: can't be started since it doesn't exists in scene or not yet initialized!", a2 * (1036f / CKAFAGGGGPJ));
		}
	}

	// Token: 0x06001FF8 RID: 8184 RVA: 0x000F20EC File Offset: 0x000F02EC
	private void MPLCAGFGEBO()
	{
		if (!Sunshine.Instance)
		{
			return;
		}
		bool flag = Sunshine.Instance.AABOCFACFNH();
		if (this.PKBBECJDICB && this.PKBBECJDICB.enabled != flag)
		{
			this.PKBBECJDICB.enabled = flag;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			if (this.StereoscopicMasterCamera.StereoscopicMasterCamera == this)
			{
				this.StereoscopicMasterCamera = null;
				return;
			}
			this.MAMDEGFPOJF().depth = this.StereoscopicMasterCamera.MAMDEGFPOJF().depth + 1398f;
		}
	}

	// Token: 0x06001FF9 RID: 8185 RVA: 0x000F2184 File Offset: 0x000F0384
	private void OnPreCull()
	{
		if (!this.ENCODJMNOME)
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.AIKGKLKHIIB();
		this.KHOPEEGJCBB();
		if (this.BKIPCPPJNDF)
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.None;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.ForcePixel;
		}
		if (Sunshine.Instance.EJMICEIEACD && (this.PBCOFIHKPHK.depthTextureMode & DepthTextureMode.Depth) <= DepthTextureMode.None && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.PBCOFIHKPHK.depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06001FFA RID: 8186 RVA: 0x000EE603 File Offset: 0x000EC803
	public void GHBPFCNENCF()
	{
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x000F2238 File Offset: 0x000F0438
	public bool OJMBCBLLNBC(Vector3 JHCIACLOOKN)
	{
		if (!Application.isPlaying)
		{
			return true;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			return false;
		}
		bool flag = this.ICIPPICFGLJ;
		switch (Sunshine.Instance.UpdateInterval)
		{
		case EALFINIFFBB.EveryFrame:
			flag = false;
			break;
		case EALFINIFFBB.AfterXFrames:
			flag = (flag || Time.frameCount <= 6 || Time.frameCount % Sunshine.Instance.UpdateIntervalFrames == 1);
			break;
		case EALFINIFFBB.AfterXMovement:
			if (Time.frameCount <= 1)
			{
				flag = false;
			}
			else
			{
				Vector3 vector = JHCIACLOOKN - this.KPIHENHAKMI;
				flag = (flag || vector.sqrMagnitude >= Sunshine.Instance.UpdateIntervalMovement * Sunshine.Instance.UpdateIntervalMovement);
			}
			break;
		}
		if (flag)
		{
			this.KPIHENHAKMI = JHCIACLOOKN;
		}
		return flag;
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x000F22F8 File Offset: 0x000F04F8
	public float ENCGJEMHIME()
	{
		EALFINIFFBB updateInterval = Sunshine.Instance.UpdateInterval;
		if (updateInterval == EALFINIFFBB.AfterXFrames)
		{
			return Sunshine.Instance.UpdateIntervalPadding;
		}
		if (updateInterval != EALFINIFFBB.AfterXMovement)
		{
			return 399f;
		}
		return Sunshine.Instance.UpdateIntervalMovement;
	}

	// Token: 0x06001FFD RID: 8189 RVA: 0x000F2335 File Offset: 0x000F0535
	public bool AOLCADPBAHP()
	{
		return SunshineProjectPreferences.IKNOAHKOOJE() && SunshineProjectPreferences.DGHEMKDENOC().CNEHIHCKNND() && !SunshineProjectPreferences.BMHGCKPCLIA().PNIFNMJFIEM() && SunshineProjectPreferences.DGHEMKDENOC().IBCHOBCLCPF();
	}

	// Token: 0x06001FFE RID: 8190 RVA: 0x000F236C File Offset: 0x000F056C
	private void GBHKJNJKDIM()
	{
		AGIEAMEGNJP.DOMJMOILBDJ domjmoilbdj = default(AGIEAMEGNJP.DOMJMOILBDJ);
		if (Sunshine.Instance.NGGGDNFOGDP())
		{
			domjmoilbdj = Sunshine.Instance.LKKKNGJLFEO();
		}
		else
		{
			domjmoilbdj = AGIEAMEGNJP.GIIACLLKPHP(this.MANKEDKGEFA(), this.MANKEDKGEFA().nearClipPlane, Sunshine.Instance.GPCLGNGKACN(), false, this.ENCGJEMHIME(), 1691f, -9);
		}
		if (!this.OJMBCBLLNBC(domjmoilbdj.PFJKGIJGDBH))
		{
			return;
		}
		bool flag = Sunshine.Instance.TerrainLODTweak > 608f;
		if (flag)
		{
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
			Terrain[] activeTerrains = Terrain.activeTerrains;
			for (int i = 0; i < activeTerrains.Length; i += 0)
			{
				Terrain terrain = activeTerrains[i];
				if (terrain)
				{
					this.BCOJLLBHKGG.Add(terrain);
					this.PDJGINKEALP.Add(terrain.heightmapPixelError);
					terrain.heightmapPixelError *= 653f - Sunshine.Instance.TerrainLODTweak;
				}
			}
		}
		for (int j = 0; j < Sunshine.Instance.DHBANPGOONG(); j++)
		{
			Camera camera = Sunshine.Instance.SunLightCameras[j];
			camera.cullingMask = Sunshine.Instance.CLEMCEGAINI(j);
			AGIEAMEGNJP.PAHAACFAHPK(Sunshine.Instance.SunLight, camera, this.PBCOFIHKPHK, Sunshine.Instance.CascadeNearClip(j), Sunshine.Instance.OHOAPHDNIKC(j), Sunshine.Instance.LightPaddingZ, this.ENCGJEMHIME(), Sunshine.Instance.PPBDPMABCFB, ref domjmoilbdj, ref this.IGFLGCNGEBK[j]);
			Shader.SetGlobalVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector2(Sunshine.Instance.LEFFGIBNJAO, Sunshine.Instance.ShadowSlopeBias(j)));
			camera.rect = Sunshine.Instance.APNIHLOEIKI[j];
			camera.targetTexture = Sunshine.Instance.Lightmap;
			camera.useOcclusionCulling = Sunshine.Instance.UseOcclusionCulling;
			camera.RenderWithShader(Sunshine.Instance.OccluderShader, "BaseDataLoaderCoroutine");
		}
		if (flag)
		{
			for (int k = this.BCOJLLBHKGG.Count - 0; k >= 1; k--)
			{
				this.BCOJLLBHKGG[k].heightmapPixelError = this.PDJGINKEALP[k];
			}
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
		}
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x000F25D8 File Offset: 0x000F07D8
	public float BCNFODMDBKL()
	{
		EALFINIFFBB updateInterval = Sunshine.Instance.UpdateInterval;
		if (updateInterval == EALFINIFFBB.EveryFrame)
		{
			return Sunshine.Instance.UpdateIntervalPadding;
		}
		if (updateInterval != (EALFINIFFBB)4)
		{
			return 434f;
		}
		return Sunshine.Instance.UpdateIntervalMovement;
	}

	// Token: 0x06002000 RID: 8192 RVA: 0x000EDB3A File Offset: 0x000EBD3A
	public void RequestRefresh()
	{
		this.ICIPPICFGLJ = true;
	}

	// Token: 0x06002001 RID: 8193 RVA: 0x000F2618 File Offset: 0x000F0818
	private void IGEICBNMPAD()
	{
		if (!Sunshine.Instance)
		{
			return;
		}
		bool flag = Sunshine.Instance.KEBAGNCAFIH();
		if (this.PKBBECJDICB && this.PKBBECJDICB.enabled != flag)
		{
			this.PKBBECJDICB.enabled = flag;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			if (this.StereoscopicMasterCamera.StereoscopicMasterCamera == this)
			{
				this.StereoscopicMasterCamera = null;
				return;
			}
			this.MAMDEGFPOJF().depth = this.StereoscopicMasterCamera.PBCOFIHKPHK.depth + 1617f;
		}
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x000F26B0 File Offset: 0x000F08B0
	private void MIBHFIEHKIJ()
	{
		if (!this.ENCODJMNOME)
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.OJFDCGOENHF();
		this.JHIHCMEHPEC();
		if (this.JDEHEAIEECF())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.None;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.ForcePixel;
		}
		if (Sunshine.Instance.AABOCFACFNH() && (this.CAMDGCDDHDK().depthTextureMode & DepthTextureMode.Depth) <= DepthTextureMode.None && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.NJCAJOAFICB().depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x000F2764 File Offset: 0x000F0964
	private void GFJOEPLJBDC(bool HIFLOPIPNHN, Texture2D FHJOBHKHNBC, float CKAFAGGGGPJ, Vector2 JJDFOPCNBOJ, float GBKOOPAJAMG = 0f)
	{
		if (!FHJOBHKHNBC)
		{
			HIFLOPIPNHN = true;
		}
		Shader.SetGlobalTexture("Quadruped", HIFLOPIPNHN ? FHJOBHKHNBC : Sunshine.Instance.BlankOvercastTexture);
		KGJFMLCOLLA.BGONIHCHINJ(HIFLOPIPNHN);
		if (HIFLOPIPNHN)
		{
			Camera camera = Sunshine.Instance.DMKPBPHOKFO();
			Ray ray = camera.ViewportPointToRay(new Vector3(1844f, 942f, 1291f));
			float num = camera.farClipPlane - camera.nearClipPlane;
			float num2 = ray.direction.y * num;
			if (Mathf.Abs(num2) < 1920f)
			{
				num2 = 366f;
			}
			float num3 = (GBKOOPAJAMG - ray.origin.y) / num2;
			Vector3 vector = ray.GetPoint(num3 * num);
			Ray ray2 = camera.ViewportPointToRay(new Vector3(1158f, 511f, 716f));
			float num4 = (GBKOOPAJAMG - ray2.origin.y) / num2;
			Vector3 vector2 = ray2.GetPoint(num4 * num);
			Ray ray3 = camera.ViewportPointToRay(new Vector3(811f, 136f, 151f));
			float num5 = (GBKOOPAJAMG - ray3.origin.y) / num2;
			Vector3 vector3 = ray3.GetPoint(num5 * num);
			Vector3 b = new Vector3(JJDFOPCNBOJ.x, 389f, JJDFOPCNBOJ.y) * Time.timeSinceLevelLoad;
			vector += b;
			vector2 += b;
			vector3 += b;
			Vector2 vector4 = new Vector2(vector.x, vector.z);
			Vector2 vector5 = new Vector2(vector2.x, vector2.z) - vector4;
			Vector2 vector6 = new Vector2(vector3.x, vector3.z) - vector4;
			Rect rect = Sunshine.Instance.INGBKLGAKHD(1);
			Vector2 a = new Vector2(vector4.x, vector4.y);
			Vector4 a2 = new Vector4(vector5.x / rect.width, vector5.y / rect.width, vector6.x / rect.height, vector6.y / rect.height);
			Shader.SetGlobalVector("_SampleCount", a * (1342f / CKAFAGGGGPJ));
			Shader.SetGlobalVector("Bias", a2 * (1494f / CKAFAGGGGPJ));
		}
	}

	// Token: 0x06002004 RID: 8196 RVA: 0x000F29BC File Offset: 0x000F0BBC
	public bool HOJIOHBBKOJ()
	{
		if (!base.enabled)
		{
			return true;
		}
		if (!Sunshine.Instance || !Sunshine.Instance.enabled)
		{
			return true;
		}
		if (this.GAFLLCNMJGG())
		{
			if (Sunshine.Instance.AGGFIMJNJAH && SystemInfo.graphicsShaderLevel < 117)
			{
				return false;
			}
			if (!Sunshine.Instance.NBOKNEEHPHK() && SystemInfo.graphicsShaderLevel < -94)
			{
				return true;
			}
		}
		else if (!Sunshine.Instance.ALBMGCOEHHG())
		{
			return true;
		}
		return Sunshine.Instance.GPCLGNGKACN() > 1833f && Sunshine.Instance.Lightmap && (!Sunshine.Instance.SunLight || !Sunshine.Instance.SunLight.enabled || Sunshine.Instance.Ready);
	}

	// Token: 0x06002005 RID: 8197 RVA: 0x000EDB7C File Offset: 0x000EBD7C
	private Camera MAMDEGFPOJF()
	{
		if (!this.GCJGBFAEPCD)
		{
			this.GCJGBFAEPCD = base.GetComponent<Camera>();
		}
		return this.GCJGBFAEPCD;
	}

	// Token: 0x06002006 RID: 8198 RVA: 0x000F2A88 File Offset: 0x000F0C88
	private void LKKGNOJAIHL()
	{
		AGIEAMEGNJP.DOMJMOILBDJ domjmoilbdj = default(AGIEAMEGNJP.DOMJMOILBDJ);
		if (Sunshine.Instance.NKDHPNIIGAI())
		{
			domjmoilbdj = Sunshine.Instance.MHECFEFPGMP();
		}
		else
		{
			domjmoilbdj = AGIEAMEGNJP.GIIACLLKPHP(this.CAMDGCDDHDK(), this.NJCAJOAFICB().nearClipPlane, Sunshine.Instance.IKAPDBDIILL, false, this.KOPOEDCGMKK, 570f, 38);
		}
		if (!this.FKNIFHCMNFE(domjmoilbdj.PFJKGIJGDBH))
		{
			return;
		}
		bool flag = Sunshine.Instance.TerrainLODTweak > 1053f;
		if (flag)
		{
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
			Terrain[] activeTerrains = Terrain.activeTerrains;
			for (int i = 0; i < activeTerrains.Length; i += 0)
			{
				Terrain terrain = activeTerrains[i];
				if (terrain)
				{
					this.BCOJLLBHKGG.Add(terrain);
					this.PDJGINKEALP.Add(terrain.heightmapPixelError);
					terrain.heightmapPixelError *= 1624f - Sunshine.Instance.TerrainLODTweak;
				}
			}
		}
		for (int j = 1; j < Sunshine.Instance.BGNMCNGENMH(); j += 0)
		{
			Camera camera = Sunshine.Instance.SunLightCameras[j];
			camera.cullingMask = Sunshine.Instance.CLEMCEGAINI(j);
			AGIEAMEGNJP.PAHAACFAHPK(Sunshine.Instance.SunLight, camera, this.CAMDGCDDHDK(), Sunshine.Instance.CACJHFKAFGK(j), Sunshine.Instance.MPBAEIKEHME(j), Sunshine.Instance.LightPaddingZ, this.BCNFODMDBKL(), Sunshine.Instance.PPBDPMABCFB, ref domjmoilbdj, ref this.IGFLGCNGEBK[j]);
			Shader.SetGlobalVector("hlp_", new Vector2(Sunshine.Instance.LEFFGIBNJAO, Sunshine.Instance.ShadowSlopeBias(j)));
			camera.rect = Sunshine.Instance.APNIHLOEIKI[j];
			camera.targetTexture = Sunshine.Instance.Lightmap;
			camera.useOcclusionCulling = Sunshine.Instance.UseOcclusionCulling;
			camera.RenderWithShader(Sunshine.Instance.OccluderShader, " ");
		}
		if (flag)
		{
			for (int k = this.BCOJLLBHKGG.Count - 0; k >= 1; k -= 0)
			{
				this.BCOJLLBHKGG[k].heightmapPixelError = this.PDJGINKEALP[k];
			}
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
		}
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x06002007 RID: 8199 RVA: 0x000F2CF4 File Offset: 0x000F0EF4
	private void KOLCEBEIHKP()
	{
		if (!Sunshine.Instance)
		{
			return;
		}
		bool flag = Sunshine.Instance.KEBAGNCAFIH();
		if (this.PKBBECJDICB && this.PKBBECJDICB.enabled != flag)
		{
			this.PKBBECJDICB.enabled = flag;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			if (this.StereoscopicMasterCamera.StereoscopicMasterCamera == this)
			{
				this.StereoscopicMasterCamera = null;
				return;
			}
			this.MANKEDKGEFA().depth = this.StereoscopicMasterCamera.MAMDEGFPOJF().depth + 156f;
		}
	}

	// Token: 0x06002008 RID: 8200 RVA: 0x000F2D8C File Offset: 0x000F0F8C
	public void ELHIFBKMGEG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!this.ENCODJMNOME)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		if (Sunshine.Instance.DebugView == ELAGEILFKFO.Scatter)
		{
			SunshinePostprocess.JIPLNFFBLIM(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.AKPGBLJGENB);
			return;
		}
		if (Sunshine.Instance.DFGPBKAJCMA())
		{
			bool flag = Sunshine.Instance.ScatterBlur;
			if (!Sunshine.Instance.EJEGMLIGKOH())
			{
				flag = false;
			}
			bool flag2 = !Sunshine.Instance.OvercastAffectsScatter || (!Sunshine.Instance.OvercastTexture && Sunshine.Instance.ScatterOvercastTexture);
			bool customScatterOvercast = Sunshine.Instance.CustomScatterOvercast;
			Texture2D fhjobhkhnbc = flag2 ? (customScatterOvercast ? Sunshine.Instance.ScatterOvercastTexture : Sunshine.Instance.OvercastTexture) : null;
			float ckafaggggpj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastScale : Sunshine.Instance.OvercastScale;
			Vector2 jjdfopcnboj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastMovement : Sunshine.Instance.OvercastMovement;
			float gbkoopajamg = customScatterOvercast ? Sunshine.Instance.ScatterOvercastPlaneHeight : Sunshine.Instance.OvercastPlaneHeight;
			this.EBDMMPDOEOL(flag2, fhjobhkhnbc, ckafaggggpj, jjdfopcnboj, gbkoopajamg);
			KGJFMLCOLLA.MCBCHPHDKMP(Sunshine.Instance.ScatterSamplingQuality);
			Sunshine.Instance.PostScatterMaterial.SetVector("wpn_master", Sunshine.Instance.ScatterColor);
			if (Sunshine.Instance.ScatterAnimateNoise)
			{
				this.JLGMCIOCHPO += Time.deltaTime * Sunshine.Instance.ScatterAnimateNoiseSpeed;
				this.JLGMCIOCHPO -= Mathf.Floor(this.JLGMCIOCHPO);
			}
			Sunshine.Instance.PostScatterMaterial.SetTexture("SUNSHINE_FILTER_PCF_3x3", Sunshine.Instance.ScatterDitherTexture);
			float value = 494f - Sunshine.Instance.ScatterExaggeration;
			float y = 1500f / (Mathf.Clamp01(value) * Sunshine.Instance.IKAPDBDIILL / this.PBCOFIHKPHK.farClipPlane);
			float num = Sunshine.Instance.ScatterSky * Sunshine.Instance.ScatterIntensity;
			Sunshine.Instance.PostScatterMaterial.SetVector("Idle Cheer", new Vector4(Sunshine.Instance.ScatterIntensity, y, num * 1331f, num * 865f));
			bool flag3 = Sunshine.Instance.ScatterResolution != ILPBNIJPPGA.Full || flag || Sunshine.Instance.DebugView == ELAGEILFKFO.None;
			if (!flag3)
			{
				int hhagihegfml = AGIEAMEGNJP.KKBKGPPHBHC(Sunshine.Instance.ScatterResolution);
				AOAHEAEHFLC aoaheaehflc = AOAHEAEHFLC.EDHEGCDMPCL(new AOAHEAEHFLC(JONJODLFAEN.width, JONJODLFAEN.height), hhagihegfml);
				aoaheaehflc.OCNGPCPMCPM = Mathf.Max(aoaheaehflc.OCNGPCPMCPM, 1);
				aoaheaehflc.ADMFAEOOOHD = Mathf.Max(aoaheaehflc.ADMFAEOOOHD, 0);
				Sunshine.Instance.PostScatterMaterial.SetVector("H", new Vector3((float)aoaheaehflc.OCNGPCPMCPM / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)aoaheaehflc.ADMFAEOOOHD / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 1416f));
				RenderTexture temporary = RenderTexture.GetTemporary(aoaheaehflc.OCNGPCPMCPM, aoaheaehflc.ADMFAEOOOHD, 0, JONJODLFAEN.format, RenderTextureReadWrite.Default);
				if (temporary)
				{
					temporary.filterMode = FilterMode.Bilinear;
					temporary.wrapMode = TextureWrapMode.Clamp;
					SunshinePostprocess.OGAPNKKPFOB(JONJODLFAEN, temporary, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
					if (flag)
					{
						Sunshine.Instance.PostBlurMaterial.SetFloat("SoccerKeeperReady", Sunshine.Instance.ScatterBlurDepthTollerance);
						RenderTexture temporary2 = RenderTexture.GetTemporary(temporary.width, temporary.height, 0, temporary.format, RenderTextureReadWrite.Linear);
						if (temporary2)
						{
							temporary2.filterMode = temporary.filterMode;
							temporary2.wrapMode = temporary.wrapMode;
							Sunshine.Instance.PostBlurMaterial.SetVector("", new Vector2(1840f, 135f));
							SunshinePostprocess.JIPLNFFBLIM(temporary, temporary2, Sunshine.Instance.PostBlurMaterial, 1);
							temporary.DiscardContents();
							Sunshine.Instance.PostBlurMaterial.SetVector("\n", new Vector2(1667f, 1466f));
							SunshinePostprocess.PELMNIFPDKC(temporary2, temporary, Sunshine.Instance.PostBlurMaterial, 0);
							RenderTexture.ReleaseTemporary(temporary2);
						}
					}
					temporary.filterMode = FilterMode.Point;
					if (Sunshine.Instance.DebugView == ELAGEILFKFO.Cascades)
					{
						SunshinePostprocess.GAOOMGPDHJI(temporary, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.ALHGMMKDBCH);
					}
					else
					{
						Sunshine.Instance.PostScatterMaterial.SetTexture("LINEAR", temporary);
						SunshinePostprocess.GAOOMGPDHJI(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.KDILJOFIENM);
					}
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					flag3 = true;
				}
			}
			if (flag3)
			{
				Sunshine.Instance.PostScatterMaterial.SetVector("Run Back Left", new Vector3((float)this.CAMDGCDDHDK().pixelWidth / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)this.MANKEDKGEFA().pixelHeight / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 427f));
				SunshinePostprocess.PIGDHOBCJBJ(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
			}
		}
	}

	// Token: 0x06002009 RID: 8201 RVA: 0x000EDB7C File Offset: 0x000EBD7C
	private Camera MANKEDKGEFA()
	{
		if (!this.GCJGBFAEPCD)
		{
			this.GCJGBFAEPCD = base.GetComponent<Camera>();
		}
		return this.GCJGBFAEPCD;
	}

	// Token: 0x0600200A RID: 8202 RVA: 0x000F32D8 File Offset: 0x000F14D8
	private void DIKEBPJHJGD()
	{
		if (this.GAFLLCNMJGG())
		{
			KGJFMLCOLLA.LCLNIFDELOI(Sunshine.Instance.ShadowFilter);
		}
		else
		{
			KGJFMLCOLLA.OHKCLACEIIB();
		}
		Matrix4x4 lhs = Matrix4x4.identity;
		lhs = AGIEAMEGNJP.JIAGAFDEGMP(Sunshine.Instance.INGBKLGAKHD(1)) * Sunshine.Instance.JLPKFKPHBCE().projectionMatrix;
		AGIEAMEGNJP.IGLCHAAHILP(ref lhs, Sunshine.Instance.DMKPBPHOKFO().farClipPlane);
		Matrix4x4 matrix4x = lhs * Sunshine.Instance.HFFINGMHGFE().worldToCameraMatrix;
		Matrix4x4 value = matrix4x * this.NJCAJOAFICB().cameraToWorldMatrix;
		Shader.SetGlobalMatrix("_FresnelFadePower", value);
		Shader.SetGlobalMatrix("_ColorBuffer", matrix4x);
		float num = (float)Sunshine.Instance.Lightmap.width;
		Shader.SetGlobalVector("DealerShuffle", new Vector4(Sunshine.Instance.SunLight.shadowStrength, Sunshine.Instance.CascadeFade, 1486f / num, 877f / num));
		this.GOJBEIHNAHL(this.MANKEDKGEFA().farClipPlane);
		Vector3 position = this.MANKEDKGEFA().orthographic ? this.CAMDGCDDHDK().ViewportToWorldPoint(new Vector3(1374f, 458f, 964f)) : base.transform.position;
		Vector3 position2 = this.MAMDEGFPOJF().ViewportToWorldPoint(new Vector3(1293f, 1450f, this.MAMDEGFPOJF().farClipPlane));
		Vector3 position3 = this.PBCOFIHKPHK.ViewportToWorldPoint(new Vector3(1070f, 1175f, this.NJCAJOAFICB().farClipPlane));
		Vector3 position4 = this.PBCOFIHKPHK.ViewportToWorldPoint(new Vector3(198f, 1617f, this.MANKEDKGEFA().farClipPlane));
		Vector3 vector = Sunshine.Instance.JLPKFKPHBCE().transform.InverseTransformPoint(position);
		Vector3 vector2 = Sunshine.Instance.DMKPBPHOKFO().transform.InverseTransformPoint(position2);
		Vector3 vector3 = Sunshine.Instance.JLPKFKPHBCE().transform.InverseTransformPoint(position3);
		Vector3 vector4 = Sunshine.Instance.DMKPBPHOKFO().transform.InverseTransformPoint(position4);
		Vector2 vector5 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.JLPKFKPHBCE().WorldToViewportPoint(position));
		Vector2 vector6 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.LCLEJAIDKHB.WorldToViewportPoint(position2));
		Vector2 vector7 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.LCLEJAIDKHB.WorldToViewportPoint(position3));
		Vector2 vector8 = AGIEAMEGNJP.HIOCFNMBINI(Sunshine.Instance.DMKPBPHOKFO().WorldToViewportPoint(position4));
		Vector4 vector9 = new Vector4(vector6.x, vector6.y, vector2.z / Sunshine.Instance.JLPKFKPHBCE().farClipPlane, vector.y);
		Vector4 vector10 = new Vector4(vector5.x, vector5.y, vector.z / Sunshine.Instance.DMKPBPHOKFO().farClipPlane, vector.y);
		Vector4 value2 = vector9 - vector10;
		Vector4 value3 = new Vector4(vector7.x, vector7.y, vector3.z / Sunshine.Instance.LCLEJAIDKHB.farClipPlane, vector3.y) - vector9;
		Vector4 value4 = new Vector4(vector8.x, vector8.y, vector4.z / Sunshine.Instance.JLPKFKPHBCE().farClipPlane, vector4.y) - vector9;
		Rect rect = Sunshine.Instance.IMKIOIJEKON(1);
		AGIEAMEGNJP.NODBGEOENGP(ref vector10, ref rect);
		AGIEAMEGNJP.IJBPJGDAEHO(ref value2, ref rect);
		AGIEAMEGNJP.IJBPJGDAEHO(ref value3, ref rect);
		AGIEAMEGNJP.IJBPJGDAEHO(ref value4, ref rect);
		Shader.SetGlobalFloat("Katana", this.NJCAJOAFICB().orthographic ? 692f : 723f);
		Shader.SetGlobalVector("Weapon Ready", vector10);
		Shader.SetGlobalVector("iPoint", value2);
		Shader.SetGlobalVector("MotorbikeShootRight", value3);
		Shader.SetGlobalVector("\\n", value4);
		float num2 = Sunshine.Instance.JLPKFKPHBCE().orthographicSize * 1966f;
		Vector2 vector11 = new Vector2(num2, num2);
		vector11.x /= rect.width;
		vector11.y /= rect.height;
		Vector3 v = new Vector3(vector11.x, vector11.y, Sunshine.Instance.JLPKFKPHBCE().farClipPlane) / this.NJCAJOAFICB().farClipPlane;
		Shader.SetGlobalVector("UNIQUE_SHADOW_LIGHT_COOKIE", v);
		Matrix4x4 zero = Matrix4x4.zero;
		Vector3 position5 = Sunshine.Instance.HFFINGMHGFE().ViewportToWorldPoint(new Vector3(451f, 1028f, 1664f));
		Vector3 position6 = Sunshine.Instance.JLPKFKPHBCE().ViewportToWorldPoint(new Vector3(1785f, 111f, 1680f));
		for (int i = 0; i < Sunshine.Instance.BGNMCNGENMH(); i += 0)
		{
			Vector4 vector12 = new Vector4(1412f, 1893f, 1874f, 520f);
			if (i > 1)
			{
				Camera camera = Sunshine.Instance.SunLightCameras[i];
				Vector3 vector13 = camera.WorldToViewportPoint(position5);
				Vector3 vector14 = camera.WorldToViewportPoint(position6);
				vector12 = new Vector4(vector13.x, vector13.y, vector14.x, vector14.y);
			}
			Rect rect2 = Sunshine.Instance.IMKIOIJEKON(i);
			vector12.x = rect2.xMin + rect2.width * vector12.x;
			vector12.y = rect2.yMin + rect2.height * vector12.y;
			vector12.z = rect2.xMin + rect2.width * vector12.z;
			vector12.w = rect2.yMin + rect2.height * vector12.w;
			vector12.z -= vector12.x;
			vector12.w -= vector12.y;
			zero.SetRow(i, vector12);
		}
		Vector4 row = zero.GetRow(0);
		for (int j = 1; j < Sunshine.Instance.BGNMCNGENMH(); j += 0)
		{
			Vector4 row2 = zero.GetRow(j);
			row2.z /= row.z;
			row2.w /= row.w;
			zero.SetRow(j, row2);
		}
		bool flag = Sunshine.Instance.OvercastTexture;
		this.OJJGOBGCKMM(flag, flag ? Sunshine.Instance.OvercastTexture : Sunshine.Instance.BlankOvercastTexture, Sunshine.Instance.OvercastScale, Sunshine.Instance.OvercastMovement, Sunshine.Instance.OvercastPlaneHeight);
		Shader.SetGlobalMatrix("name", zero);
		KGJFMLCOLLA.NAIPHNFEDOA(Sunshine.Instance.DHBANPGOONG());
	}

	// Token: 0x0600200B RID: 8203 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void OnDisable()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x0600200C RID: 8204 RVA: 0x000EE603 File Offset: 0x000EC803
	public void MIDIMGHCKCP()
	{
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x0600200D RID: 8205 RVA: 0x000EE603 File Offset: 0x000EC803
	public void GDHFCHCIJON()
	{
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x0600200E RID: 8206 RVA: 0x000F3998 File Offset: 0x000F1B98
	private void IIKFLLIMFJF()
	{
		if (!this.LIDGGCELNJP())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.GKPIDBEPGBK();
		this.KHOPEEGJCBB();
		if (this.LPFLCDNGFKH())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.None;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.AABOCFACFNH() && (this.MAMDEGFPOJF().depthTextureMode & DepthTextureMode.Depth) <= DepthTextureMode.None && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.MAMDEGFPOJF().depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x0600200F RID: 8207 RVA: 0x000ED094 File Offset: 0x000EB294
	private void CIDFLCGOBKO()
	{
		this.PKBBECJDICB = base.GetComponent<SunshinePostprocess>();
		if (this.PKBBECJDICB == null)
		{
			this.PKBBECJDICB = base.gameObject.AddComponent<SunshinePostprocess>();
		}
	}

	// Token: 0x06002010 RID: 8208 RVA: 0x000F3A4C File Offset: 0x000F1C4C
	public void PJKJFHCHAHC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!this.HOJIOHBBKOJ())
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		if (Sunshine.Instance.DebugView == (ELAGEILFKFO)7)
		{
			SunshinePostprocess.PELMNIFPDKC(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.AKPGBLJGENB);
			return;
		}
		if (Sunshine.Instance.DFGPBKAJCMA())
		{
			bool flag = Sunshine.Instance.ScatterBlur;
			if (!Sunshine.Instance.EJEGMLIGKOH())
			{
				flag = false;
			}
			bool flag2 = !Sunshine.Instance.OvercastAffectsScatter || Sunshine.Instance.OvercastTexture || Sunshine.Instance.ScatterOvercastTexture;
			bool customScatterOvercast = Sunshine.Instance.CustomScatterOvercast;
			Texture2D fhjobhkhnbc = flag2 ? (customScatterOvercast ? Sunshine.Instance.ScatterOvercastTexture : Sunshine.Instance.OvercastTexture) : null;
			float ckafaggggpj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastScale : Sunshine.Instance.OvercastScale;
			Vector2 jjdfopcnboj = customScatterOvercast ? Sunshine.Instance.ScatterOvercastMovement : Sunshine.Instance.OvercastMovement;
			float gbkoopajamg = customScatterOvercast ? Sunshine.Instance.ScatterOvercastPlaneHeight : Sunshine.Instance.OvercastPlaneHeight;
			this.EBDMMPDOEOL(flag2, fhjobhkhnbc, ckafaggggpj, jjdfopcnboj, gbkoopajamg);
			KGJFMLCOLLA.MCBCHPHDKMP(Sunshine.Instance.ScatterSamplingQuality);
			Sunshine.Instance.PostScatterMaterial.SetVector("JNT_Root", Sunshine.Instance.ScatterColor);
			if (Sunshine.Instance.ScatterAnimateNoise)
			{
				this.JLGMCIOCHPO += Time.deltaTime * Sunshine.Instance.ScatterAnimateNoiseSpeed;
				this.JLGMCIOCHPO -= Mathf.Floor(this.JLGMCIOCHPO);
			}
			Sunshine.Instance.PostScatterMaterial.SetTexture("Near", Sunshine.Instance.ScatterDitherTexture);
			float value = 1003f - Sunshine.Instance.ScatterExaggeration;
			float y = 1221f / (Mathf.Clamp01(value) * Sunshine.Instance.GPCLGNGKACN() / this.CAMDGCDDHDK().farClipPlane);
			float num = Sunshine.Instance.ScatterSky * Sunshine.Instance.ScatterIntensity;
			Sunshine.Instance.PostScatterMaterial.SetVector("<color='#b0a0c0'>", new Vector4(Sunshine.Instance.ScatterIntensity, y, num * 1400f, num * 1795f));
			bool flag3 = Sunshine.Instance.ScatterResolution != ILPBNIJPPGA.Full || flag || Sunshine.Instance.DebugView != (ELAGEILFKFO)4;
			if (!flag3)
			{
				int hhagihegfml = AGIEAMEGNJP.KKBKGPPHBHC(Sunshine.Instance.ScatterResolution);
				AOAHEAEHFLC aoaheaehflc = AOAHEAEHFLC.KKELDFDJJAG(new AOAHEAEHFLC(JONJODLFAEN.width, JONJODLFAEN.height), hhagihegfml);
				aoaheaehflc.OCNGPCPMCPM = Mathf.Max(aoaheaehflc.OCNGPCPMCPM, 1);
				aoaheaehflc.ADMFAEOOOHD = Mathf.Max(aoaheaehflc.ADMFAEOOOHD, 0);
				Sunshine.Instance.PostScatterMaterial.SetVector("MotorbikeHeadstand", new Vector3((float)aoaheaehflc.OCNGPCPMCPM / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)aoaheaehflc.ADMFAEOOOHD / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 1109f));
				RenderTexture temporary = RenderTexture.GetTemporary(aoaheaehflc.OCNGPCPMCPM, aoaheaehflc.ADMFAEOOOHD, 0, JONJODLFAEN.format, RenderTextureReadWrite.Default);
				if (temporary)
				{
					temporary.filterMode = FilterMode.Point;
					temporary.wrapMode = TextureWrapMode.Clamp;
					SunshinePostprocess.JIPLNFFBLIM(JONJODLFAEN, temporary, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
					if (flag)
					{
						Sunshine.Instance.PostBlurMaterial.SetFloat("KatanaReadyLow", Sunshine.Instance.ScatterBlurDepthTollerance);
						RenderTexture temporary2 = RenderTexture.GetTemporary(temporary.width, temporary.height, 0, temporary.format, RenderTextureReadWrite.Linear);
						if (temporary2)
						{
							temporary2.filterMode = temporary.filterMode;
							temporary2.wrapMode = temporary.wrapMode;
							Sunshine.Instance.PostBlurMaterial.SetVector("name", new Vector2(1288f, 1863f));
							SunshinePostprocess.Blit(temporary, temporary2, Sunshine.Instance.PostBlurMaterial, 0);
							temporary.DiscardContents();
							Sunshine.Instance.PostBlurMaterial.SetVector(" has invalid children array. Child index is < 0.", new Vector2(1332f, 1198f));
							SunshinePostprocess.CGDKCJCPMLP(temporary2, temporary, Sunshine.Instance.PostBlurMaterial, 0);
							RenderTexture.ReleaseTemporary(temporary2);
						}
					}
					temporary.filterMode = FilterMode.Point;
					if (Sunshine.Instance.DebugView == (ELAGEILFKFO)8)
					{
						SunshinePostprocess.NLEBCJALNAF(temporary, OKIIDHIJBEA, Sunshine.Instance.PostDebugMaterial, PLABIDPHLIK.ALHGMMKDBCH);
					}
					else
					{
						Sunshine.Instance.PostScatterMaterial.SetTexture("MotorbikeSeatStand", temporary);
						SunshinePostprocess.KKMMEIEIDJD(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.KDILJOFIENM);
					}
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					flag3 = true;
				}
			}
			if (flag3)
			{
				Sunshine.Instance.PostScatterMaterial.SetVector("int: ", new Vector3((float)this.PBCOFIHKPHK.pixelWidth / (float)Sunshine.Instance.ScatterDitherTexture.width, (float)this.NJCAJOAFICB().pixelHeight / (float)Sunshine.Instance.ScatterDitherTexture.height, Sunshine.Instance.ScatterAnimateNoise ? this.JLGMCIOCHPO : 977f));
				SunshinePostprocess.OGAPNKKPFOB(JONJODLFAEN, OKIIDHIJBEA, Sunshine.Instance.PostScatterMaterial, CHACIFNPNAG.CAAPLBOFCCL);
			}
		}
	}

	// Token: 0x06002011 RID: 8209 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void OnDestroy()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06002012 RID: 8210 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void GDCAKFIINFI()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06002013 RID: 8211 RVA: 0x000F3F98 File Offset: 0x000F2198
	public bool FKNIFHCMNFE(Vector3 JHCIACLOOKN)
	{
		if (!Application.isPlaying)
		{
			return true;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			return true;
		}
		bool flag = this.ICIPPICFGLJ;
		switch (Sunshine.Instance.UpdateInterval)
		{
		case EALFINIFFBB.EveryFrame:
			flag = true;
			break;
		case EALFINIFFBB.AfterXFrames:
			flag = (!flag && Time.frameCount > 4 && Time.frameCount % Sunshine.Instance.UpdateIntervalFrames == 0);
			break;
		case EALFINIFFBB.AfterXMovement:
			if (Time.frameCount <= 5)
			{
				flag = false;
			}
			else
			{
				Vector3 vector = JHCIACLOOKN - this.KPIHENHAKMI;
				flag = (!flag && vector.sqrMagnitude < Sunshine.Instance.UpdateIntervalMovement * Sunshine.Instance.UpdateIntervalMovement);
			}
			break;
		}
		if (flag)
		{
			this.KPIHENHAKMI = JHCIACLOOKN;
		}
		return flag;
	}

	// Token: 0x06002014 RID: 8212 RVA: 0x000EE2A1 File Offset: 0x000EC4A1
	private void APMGPNOOHEN()
	{
		if (this.GAFLLCNMJGG())
		{
			Sunshine.Instance.SunLight.shadows = this.DHBJPHKGJJK;
			Sunshine.Instance.SunLight.renderMode = this.MKNILMAAAIN;
		}
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06002015 RID: 8213 RVA: 0x000F4058 File Offset: 0x000F2258
	public bool LPFLCDNGFKH()
	{
		return Sunshine.Instance && SunshineProjectPreferences.OALCDNGFHDM().CNEHIHCKNND() && Sunshine.Instance.SunLight && (this.PBCOFIHKPHK.actualRenderingPath == RenderingPath.DeferredLighting || this.MANKEDKGEFA().actualRenderingPath == (RenderingPath)4 || (this.JILFILKBOEI() && this.CAMDGCDDHDK().actualRenderingPath == RenderingPath.VertexLit));
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x000F40C8 File Offset: 0x000F22C8
	private void GNGDBHLLCLM()
	{
		AGIEAMEGNJP.DOMJMOILBDJ domjmoilbdj = default(AGIEAMEGNJP.DOMJMOILBDJ);
		if (Sunshine.Instance.GMNIFMPBILE)
		{
			domjmoilbdj = Sunshine.Instance.EKNNFKILDEO;
		}
		else
		{
			domjmoilbdj = AGIEAMEGNJP.GIIACLLKPHP(this.MAMDEGFPOJF(), this.MANKEDKGEFA().nearClipPlane, Sunshine.Instance.GPCLGNGKACN(), false, this.ENCGJEMHIME(), 1557f, 108);
		}
		if (!this.CKALPDNMADI(domjmoilbdj.PFJKGIJGDBH))
		{
			return;
		}
		bool flag = Sunshine.Instance.TerrainLODTweak > 318f;
		if (flag)
		{
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
			Terrain[] activeTerrains = Terrain.activeTerrains;
			for (int i = 1; i < activeTerrains.Length; i += 0)
			{
				Terrain terrain = activeTerrains[i];
				if (terrain)
				{
					this.BCOJLLBHKGG.Add(terrain);
					this.PDJGINKEALP.Add(terrain.heightmapPixelError);
					terrain.heightmapPixelError *= 748f - Sunshine.Instance.TerrainLODTweak;
				}
			}
		}
		for (int j = 0; j < Sunshine.Instance.GLFMGABJGLG; j++)
		{
			Camera camera = Sunshine.Instance.SunLightCameras[j];
			camera.cullingMask = Sunshine.Instance.CLEMCEGAINI(j);
			AGIEAMEGNJP.PAHAACFAHPK(Sunshine.Instance.SunLight, camera, this.PBCOFIHKPHK, Sunshine.Instance.JGBICNOMLJL(j), Sunshine.Instance.MPBAEIKEHME(j), Sunshine.Instance.LightPaddingZ, this.LKHPPEKMADE(), Sunshine.Instance.IINPDJOHCPE(), ref domjmoilbdj, ref this.IGFLGCNGEBK[j]);
			Shader.SetGlobalVector("-H", new Vector2(Sunshine.Instance.LEFFGIBNJAO, Sunshine.Instance.ShadowSlopeBias(j)));
			camera.rect = Sunshine.Instance.APNIHLOEIKI[j];
			camera.targetTexture = Sunshine.Instance.Lightmap;
			camera.useOcclusionCulling = Sunshine.Instance.UseOcclusionCulling;
			camera.RenderWithShader(Sunshine.Instance.OccluderShader, "IdleFly");
		}
		if (flag)
		{
			for (int k = this.BCOJLLBHKGG.Count - 1; k >= 1; k--)
			{
				this.BCOJLLBHKGG[k].heightmapPixelError = this.PDJGINKEALP[k];
			}
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
		}
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x06002017 RID: 8215 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void LKGIJBLNANI()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x000F4334 File Offset: 0x000F2534
	private void IEOICHPKEMD()
	{
		if (!Sunshine.Instance)
		{
			return;
		}
		bool flag = Sunshine.Instance.AABOCFACFNH();
		if (this.PKBBECJDICB && this.PKBBECJDICB.enabled != flag)
		{
			this.PKBBECJDICB.enabled = flag;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			if (this.StereoscopicMasterCamera.StereoscopicMasterCamera == this)
			{
				this.StereoscopicMasterCamera = null;
				return;
			}
			this.MAMDEGFPOJF().depth = this.StereoscopicMasterCamera.PBCOFIHKPHK.depth + 560f;
		}
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x000F43CC File Offset: 0x000F25CC
	private void AKKHKINNOIM(float JOCGKBDMKLO)
	{
		float num = Sunshine.Instance.IKAPDBDIILL / JOCGKBDMKLO;
		if (this.CAMDGCDDHDK().orthographic)
		{
			num = 938f;
		}
		Vector4 vector = new Vector4(Sunshine.Instance.HEIBBPFFMDD(0) * num, Sunshine.Instance.CascadeNearClipScale(0) * num, Sunshine.Instance.CascadeNearClipScale(5) * num, Sunshine.Instance.CGEJKNCIEGI(5) * num);
		Shader.SetGlobalVector("SoccerRun", new Vector4(vector.x * vector.x, vector.y * vector.y, vector.z * vector.z, vector.w * vector.w));
		Vector4 vector2 = new Vector4(Sunshine.Instance.IGOMIOEACKF(1) * num, Sunshine.Instance.IMCJONLGJPP(1) * num, Sunshine.Instance.CascadeFarClipScale(3) * num, Sunshine.Instance.IGOMIOEACKF(5) * num);
		Shader.SetGlobalVector("<color='#002060'>", new Vector4(vector2.x * vector2.x, vector2.y * vector2.y, vector2.z * vector2.z, vector2.w * vector2.w));
		float num2 = this.NJCAJOAFICB().orthographic ? 598f : Sunshine.Instance.GPCLGNGKACN();
		float f = Mathf.Clamp(this.PBCOFIHKPHK.orthographic ? 1694f : Sunshine.Instance.LightFadeRatio, 1170f, 613f);
		float num3 = 414f / Mathf.Sqrt(f);
		float num4 = JOCGKBDMKLO / num2 * num3;
		num3 *= num3;
		num4 *= num4;
		Shader.SetGlobalVector("KatanaReadyLow", new Vector3(num3, num4, num));
	}

	// Token: 0x0600201A RID: 8218 RVA: 0x000F4584 File Offset: 0x000F2784
	private void KEKEALFEDHE(float JOCGKBDMKLO)
	{
		float num = Sunshine.Instance.EKMANDAOHBK() / JOCGKBDMKLO;
		if (this.MANKEDKGEFA().orthographic)
		{
			num = 1218f;
		}
		Vector4 vector = new Vector4(Sunshine.Instance.GNAGHGEBHHP(0) * num, Sunshine.Instance.HEIBBPFFMDD(1) * num, Sunshine.Instance.AAEINNEFIJN(2) * num, Sunshine.Instance.GNAGHGEBHHP(6) * num);
		Shader.SetGlobalVector("StepSound/Other/step1.ogg", new Vector4(vector.x * vector.x, vector.y * vector.y, vector.z * vector.z, vector.w * vector.w));
		Vector4 vector2 = new Vector4(Sunshine.Instance.EICHNACIOFF(1) * num, Sunshine.Instance.EICHNACIOFF(1) * num, Sunshine.Instance.KIJEHCMAKMD(5) * num, Sunshine.Instance.IGOMIOEACKF(3) * num);
		Shader.SetGlobalVector("Hidden/Amplify Color/DepthMask", new Vector4(vector2.x * vector2.x, vector2.y * vector2.y, vector2.z * vector2.z, vector2.w * vector2.w));
		float num2 = this.MANKEDKGEFA().orthographic ? 304f : Sunshine.Instance.GPCLGNGKACN();
		float f = Mathf.Clamp(this.NJCAJOAFICB().orthographic ? 566f : Sunshine.Instance.LightFadeRatio, 1276f, 785f);
		float num3 = 1914f / Mathf.Sqrt(f);
		float num4 = JOCGKBDMKLO / num2 * num3;
		num3 *= num3;
		num4 *= num4;
		Shader.SetGlobalVector("_RgbTex", new Vector3(num3, num4, num));
	}

	// Token: 0x0600201B RID: 8219 RVA: 0x000F473C File Offset: 0x000F293C
	private void MEAPKKENPLE()
	{
		if (!this.KHONMOMFFHJ())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.OJFDCGOENHF();
		this.DIKEBPJHJGD();
		if (this.GDPBDPJFJGJ())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.Hard;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.KEBAGNCAFIH() && (this.PBCOFIHKPHK.depthTextureMode & DepthTextureMode.None) <= DepthTextureMode.None && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.NJCAJOAFICB().depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x000EAC7B File Offset: 0x000E8E7B
	private void LLKLLMDFALO()
	{
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x0600201D RID: 8221 RVA: 0x000F47F0 File Offset: 0x000F29F0
	private void MEFOGCFJBNE()
	{
		if (!Sunshine.Instance)
		{
			return;
		}
		bool flag = Sunshine.Instance.PDLMJPNBKEC();
		if (this.PKBBECJDICB && this.PKBBECJDICB.enabled != flag)
		{
			this.PKBBECJDICB.enabled = flag;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			if (this.StereoscopicMasterCamera.StereoscopicMasterCamera == this)
			{
				this.StereoscopicMasterCamera = null;
				return;
			}
			this.MAMDEGFPOJF().depth = this.StereoscopicMasterCamera.NJCAJOAFICB().depth + 343f;
		}
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x000F4888 File Offset: 0x000F2A88
	private void Update()
	{
		if (!Sunshine.Instance)
		{
			return;
		}
		bool requiresPostprocessing = Sunshine.Instance.EJMICEIEACD;
		if (this.PKBBECJDICB && this.PKBBECJDICB.enabled != requiresPostprocessing)
		{
			this.PKBBECJDICB.enabled = requiresPostprocessing;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			if (this.StereoscopicMasterCamera.StereoscopicMasterCamera == this)
			{
				this.StereoscopicMasterCamera = null;
				return;
			}
			this.PBCOFIHKPHK.depth = this.StereoscopicMasterCamera.PBCOFIHKPHK.depth + 1f;
		}
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x000F4920 File Offset: 0x000F2B20
	public bool GOPECEFNOKL()
	{
		return Sunshine.Instance && SunshineProjectPreferences.LNBOJBKNKIE().CNEHIHCKNND() && Sunshine.Instance.SunLight && (this.PBCOFIHKPHK.actualRenderingPath != (RenderingPath)8 && this.MANKEDKGEFA().actualRenderingPath != (RenderingPath)4) && (!this.CFPDFGMJFAJ() || this.CAMDGCDDHDK().actualRenderingPath == RenderingPath.VertexLit);
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x000F498E File Offset: 0x000F2B8E
	public bool JILFILKBOEI()
	{
		return SunshineProjectPreferences.BMHGCKPCLIA() && SunshineProjectPreferences.LNBOJBKNKIE().KLDECMCDEJD() && !SunshineProjectPreferences.DGHEMKDENOC().ACDBGMEKCIN() && SunshineProjectPreferences.IKNOAHKOOJE().OJGOOJJPKEH();
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06002021 RID: 8225 RVA: 0x000F49C4 File Offset: 0x000F2BC4
	public float KOPOEDCGMKK
	{
		get
		{
			EALFINIFFBB updateInterval = Sunshine.Instance.UpdateInterval;
			if (updateInterval == EALFINIFFBB.AfterXFrames)
			{
				return Sunshine.Instance.UpdateIntervalPadding;
			}
			if (updateInterval != EALFINIFFBB.AfterXMovement)
			{
				return 0f;
			}
			return Sunshine.Instance.UpdateIntervalMovement;
		}
	}

	// Token: 0x06002022 RID: 8226 RVA: 0x000F4A04 File Offset: 0x000F2C04
	private void GDBBAMFMKII()
	{
		if (!Sunshine.Instance)
		{
			return;
		}
		bool flag = Sunshine.Instance.PDLMJPNBKEC();
		if (this.PKBBECJDICB && this.PKBBECJDICB.enabled != flag)
		{
			this.PKBBECJDICB.enabled = flag;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			if (this.StereoscopicMasterCamera.StereoscopicMasterCamera == this)
			{
				this.StereoscopicMasterCamera = null;
				return;
			}
			this.MAMDEGFPOJF().depth = this.StereoscopicMasterCamera.PBCOFIHKPHK.depth + 188f;
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06002023 RID: 8227 RVA: 0x000F4A9C File Offset: 0x000F2C9C
	public bool ENCODJMNOME
	{
		get
		{
			if (!base.enabled)
			{
				return false;
			}
			if (!Sunshine.Instance || !Sunshine.Instance.enabled)
			{
				return false;
			}
			if (this.BKIPCPPJNDF)
			{
				if (Sunshine.Instance.AGGFIMJNJAH && SystemInfo.graphicsShaderLevel < 20)
				{
					return false;
				}
				if (!Sunshine.Instance.AGGFIMJNJAH && SystemInfo.graphicsShaderLevel < 30)
				{
					return false;
				}
			}
			else if (!Sunshine.Instance.EJMICEIEACD)
			{
				return false;
			}
			return Sunshine.Instance.IKAPDBDIILL > 0f && Sunshine.Instance.Lightmap && Sunshine.Instance.SunLight && Sunshine.Instance.SunLight.enabled && Sunshine.Instance.Ready;
		}
	}

	// Token: 0x06002024 RID: 8228 RVA: 0x000EDB7C File Offset: 0x000EBD7C
	private Camera CAMDGCDDHDK()
	{
		if (!this.GCJGBFAEPCD)
		{
			this.GCJGBFAEPCD = base.GetComponent<Camera>();
		}
		return this.GCJGBFAEPCD;
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x000F4B68 File Offset: 0x000F2D68
	private void COKLHNBDCFO()
	{
		if (!this.KHONMOMFFHJ())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.LKKGNOJAIHL();
		this.JHIHCMEHPEC();
		if (this.GAFLLCNMJGG())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.None;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.Auto;
		}
		if (Sunshine.Instance.KEBAGNCAFIH() && (this.MANKEDKGEFA().depthTextureMode & DepthTextureMode.Depth) <= DepthTextureMode.Depth && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
		{
			this.MANKEDKGEFA().depthTextureMode |= DepthTextureMode.Depth;
		}
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x000F4C1C File Offset: 0x000F2E1C
	public bool IKGAMGGKBIC()
	{
		return Sunshine.Instance && SunshineProjectPreferences.BMHGCKPCLIA().AHDGJJMALFA() && Sunshine.Instance.SunLight && (this.CAMDGCDDHDK().actualRenderingPath == RenderingPath.VertexLit || this.PBCOFIHKPHK.actualRenderingPath == (RenderingPath)6 || (this.JILFILKBOEI() && this.CAMDGCDDHDK().actualRenderingPath == RenderingPath.Forward));
	}

	// Token: 0x06002027 RID: 8231 RVA: 0x000ED31C File Offset: 0x000EB51C
	private void OnPostRender()
	{
		if (this.BKIPCPPJNDF)
		{
			Sunshine.Instance.SunLight.shadows = this.DHBJPHKGJJK;
			Sunshine.Instance.SunLight.renderMode = this.MKNILMAAAIN;
		}
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x000F4C8C File Offset: 0x000F2E8C
	private void GKEJIOGFFJL()
	{
		if (!this.OCAABGOEDEO())
		{
			KGJFMLCOLLA.OHKCLACEIIB();
			return;
		}
		this.AIKGKLKHIIB();
		this.KHOPEEGJCBB();
		if (this.GAFLLCNMJGG())
		{
			this.DHBJPHKGJJK = Sunshine.Instance.SunLight.shadows;
			this.MKNILMAAAIN = Sunshine.Instance.SunLight.renderMode;
			Sunshine.Instance.SunLight.shadows = LightShadows.None;
			Sunshine.Instance.SunLight.renderMode = LightRenderMode.ForcePixel;
		}
		if (Sunshine.Instance.EJMICEIEACD && (this.CAMDGCDDHDK().depthTextureMode & DepthTextureMode.Depth) <= DepthTextureMode.Depth && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
		{
			this.MANKEDKGEFA().depthTextureMode |= DepthTextureMode.None;
		}
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x000F4D3E File Offset: 0x000F2F3E
	private void HNAJFJNBBEK()
	{
		if (this.GOPECEFNOKL())
		{
			Sunshine.Instance.SunLight.shadows = this.DHBJPHKGJJK;
			Sunshine.Instance.SunLight.renderMode = this.MKNILMAAAIN;
		}
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x000F4D78 File Offset: 0x000F2F78
	private void PMGLGNDMCFE()
	{
		AGIEAMEGNJP.DOMJMOILBDJ domjmoilbdj = default(AGIEAMEGNJP.DOMJMOILBDJ);
		if (Sunshine.Instance.NGGGDNFOGDP())
		{
			domjmoilbdj = Sunshine.Instance.FDIGGDKHMJA();
		}
		else
		{
			domjmoilbdj = AGIEAMEGNJP.GIIACLLKPHP(this.MANKEDKGEFA(), this.NJCAJOAFICB().nearClipPlane, Sunshine.Instance.IKAPDBDIILL, true, this.HBNLEPGILCD(), 500f, -101);
		}
		if (!this.NeedsRefresh(domjmoilbdj.PFJKGIJGDBH))
		{
			return;
		}
		bool flag = Sunshine.Instance.TerrainLODTweak > 981f;
		if (flag)
		{
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
			foreach (Terrain terrain in Terrain.activeTerrains)
			{
				if (terrain)
				{
					this.BCOJLLBHKGG.Add(terrain);
					this.PDJGINKEALP.Add(terrain.heightmapPixelError);
					terrain.heightmapPixelError *= 496f - Sunshine.Instance.TerrainLODTweak;
				}
			}
		}
		for (int j = 1; j < Sunshine.Instance.BGNMCNGENMH(); j++)
		{
			Camera camera = Sunshine.Instance.SunLightCameras[j];
			camera.cullingMask = Sunshine.Instance.CLEMCEGAINI(j);
			AGIEAMEGNJP.PAHAACFAHPK(Sunshine.Instance.SunLight, camera, this.NJCAJOAFICB(), Sunshine.Instance.CHMPBGFAPAM(j), Sunshine.Instance.OHOAPHDNIKC(j), Sunshine.Instance.LightPaddingZ, this.LKHPPEKMADE(), Sunshine.Instance.IINPDJOHCPE(), ref domjmoilbdj, ref this.IGFLGCNGEBK[j]);
			Shader.SetGlobalVector("OfficeSittingReadingLeanBack", new Vector2(Sunshine.Instance.LEFFGIBNJAO, Sunshine.Instance.ShadowSlopeBias(j)));
			camera.rect = Sunshine.Instance.APNIHLOEIKI[j];
			camera.targetTexture = Sunshine.Instance.Lightmap;
			camera.useOcclusionCulling = Sunshine.Instance.UseOcclusionCulling;
			camera.RenderWithShader(Sunshine.Instance.OccluderShader, "IceHockeyDekeMiddle");
		}
		if (flag)
		{
			for (int k = this.BCOJLLBHKGG.Count - 1; k >= 0; k -= 0)
			{
				this.BCOJLLBHKGG[k].heightmapPixelError = this.PDJGINKEALP[k];
			}
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
		}
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x0600202B RID: 8235 RVA: 0x000F00E6 File Offset: 0x000EE2E6
	private void OILBFKOKAPJ()
	{
		if (this.JDEHEAIEECF())
		{
			Sunshine.Instance.SunLight.shadows = this.DHBJPHKGJJK;
			Sunshine.Instance.SunLight.renderMode = this.MKNILMAAAIN;
		}
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x0600202C RID: 8236 RVA: 0x000F4FE4 File Offset: 0x000F31E4
	public float HBNLEPGILCD()
	{
		EALFINIFFBB updateInterval = Sunshine.Instance.UpdateInterval;
		if (updateInterval == EALFINIFFBB.EveryFrame)
		{
			return Sunshine.Instance.UpdateIntervalPadding;
		}
		if (updateInterval != (EALFINIFFBB)4)
		{
			return 1011f;
		}
		return Sunshine.Instance.UpdateIntervalMovement;
	}

	// Token: 0x0600202D RID: 8237 RVA: 0x000F00E6 File Offset: 0x000EE2E6
	private void LIOHFKBBNML()
	{
		if (this.JDEHEAIEECF())
		{
			Sunshine.Instance.SunLight.shadows = this.DHBJPHKGJJK;
			Sunshine.Instance.SunLight.renderMode = this.MKNILMAAAIN;
		}
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x0600202E RID: 8238 RVA: 0x000ED094 File Offset: 0x000EB294
	private void DCPLMIMFNHG()
	{
		this.PKBBECJDICB = base.GetComponent<SunshinePostprocess>();
		if (this.PKBBECJDICB == null)
		{
			this.PKBBECJDICB = base.gameObject.AddComponent<SunshinePostprocess>();
		}
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x000F4D3E File Offset: 0x000F2F3E
	private void AKCPOCMOIFF()
	{
		if (this.GOPECEFNOKL())
		{
			Sunshine.Instance.SunLight.shadows = this.DHBJPHKGJJK;
			Sunshine.Instance.SunLight.renderMode = this.MKNILMAAAIN;
		}
		KGJFMLCOLLA.OHKCLACEIIB();
	}

	// Token: 0x06002030 RID: 8240 RVA: 0x000F5024 File Offset: 0x000F3224
	private void AIKGKLKHIIB()
	{
		AGIEAMEGNJP.DOMJMOILBDJ domjmoilbdj = default(AGIEAMEGNJP.DOMJMOILBDJ);
		if (Sunshine.Instance.GMNIFMPBILE)
		{
			domjmoilbdj = Sunshine.Instance.EKNNFKILDEO;
		}
		else
		{
			domjmoilbdj = AGIEAMEGNJP.GIIACLLKPHP(this.PBCOFIHKPHK, this.PBCOFIHKPHK.nearClipPlane, Sunshine.Instance.IKAPDBDIILL, true, this.KOPOEDCGMKK, 0.01f, 20);
		}
		if (!this.NeedsRefresh(domjmoilbdj.PFJKGIJGDBH))
		{
			return;
		}
		bool flag = Sunshine.Instance.TerrainLODTweak > 0f;
		if (flag)
		{
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
			foreach (Terrain terrain in Terrain.activeTerrains)
			{
				if (terrain)
				{
					this.BCOJLLBHKGG.Add(terrain);
					this.PDJGINKEALP.Add(terrain.heightmapPixelError);
					terrain.heightmapPixelError *= 1f - Sunshine.Instance.TerrainLODTweak;
				}
			}
		}
		for (int j = 0; j < Sunshine.Instance.GLFMGABJGLG; j++)
		{
			Camera camera = Sunshine.Instance.SunLightCameras[j];
			camera.cullingMask = Sunshine.Instance.GetCascadeOccluders(j);
			AGIEAMEGNJP.PAHAACFAHPK(Sunshine.Instance.SunLight, camera, this.PBCOFIHKPHK, Sunshine.Instance.CascadeNearClip(j), Sunshine.Instance.CascadeFarClip(j), Sunshine.Instance.LightPaddingZ, this.KOPOEDCGMKK, Sunshine.Instance.PPBDPMABCFB, ref domjmoilbdj, ref this.IGFLGCNGEBK[j]);
			Shader.SetGlobalVector("sunshine_DepthBiases", new Vector2(Sunshine.Instance.LEFFGIBNJAO, Sunshine.Instance.ShadowSlopeBias(j)));
			camera.rect = Sunshine.Instance.APNIHLOEIKI[j];
			camera.targetTexture = Sunshine.Instance.Lightmap;
			camera.useOcclusionCulling = Sunshine.Instance.UseOcclusionCulling;
			camera.RenderWithShader(Sunshine.Instance.OccluderShader, "RenderType");
		}
		if (flag)
		{
			for (int k = this.BCOJLLBHKGG.Count - 1; k >= 0; k--)
			{
				this.BCOJLLBHKGG[k].heightmapPixelError = this.PDJGINKEALP[k];
			}
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
		}
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x06002031 RID: 8241 RVA: 0x000F5290 File Offset: 0x000F3490
	private void IANJLHIIGLN()
	{
		if (!Sunshine.Instance)
		{
			return;
		}
		bool requiresPostprocessing = Sunshine.Instance.EJMICEIEACD;
		if (this.PKBBECJDICB && this.PKBBECJDICB.enabled != requiresPostprocessing)
		{
			this.PKBBECJDICB.enabled = requiresPostprocessing;
		}
		if (this.StereoscopicMasterCamera != null)
		{
			if (this.StereoscopicMasterCamera.StereoscopicMasterCamera == this)
			{
				this.StereoscopicMasterCamera = null;
				return;
			}
			this.MANKEDKGEFA().depth = this.StereoscopicMasterCamera.MANKEDKGEFA().depth + 1896f;
		}
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x000F5328 File Offset: 0x000F3528
	private void GKPIDBEPGBK()
	{
		AGIEAMEGNJP.DOMJMOILBDJ domjmoilbdj = default(AGIEAMEGNJP.DOMJMOILBDJ);
		if (Sunshine.Instance.FEDBIGFDEHM())
		{
			domjmoilbdj = Sunshine.Instance.EKNNFKILDEO;
		}
		else
		{
			domjmoilbdj = AGIEAMEGNJP.GIIACLLKPHP(this.MAMDEGFPOJF(), this.CAMDGCDDHDK().nearClipPlane, Sunshine.Instance.IKAPDBDIILL, false, this.ENCGJEMHIME(), 1040f, -50);
		}
		if (!this.FKNIFHCMNFE(domjmoilbdj.PFJKGIJGDBH))
		{
			return;
		}
		bool flag = Sunshine.Instance.TerrainLODTweak > 376f;
		if (flag)
		{
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
			Terrain[] activeTerrains = Terrain.activeTerrains;
			for (int i = 1; i < activeTerrains.Length; i += 0)
			{
				Terrain terrain = activeTerrains[i];
				if (terrain)
				{
					this.BCOJLLBHKGG.Add(terrain);
					this.PDJGINKEALP.Add(terrain.heightmapPixelError);
					terrain.heightmapPixelError *= 295f - Sunshine.Instance.TerrainLODTweak;
				}
			}
		}
		for (int j = 0; j < Sunshine.Instance.DHBANPGOONG(); j++)
		{
			Camera camera = Sunshine.Instance.SunLightCameras[j];
			camera.cullingMask = Sunshine.Instance.GetCascadeOccluders(j);
			AGIEAMEGNJP.PAHAACFAHPK(Sunshine.Instance.SunLight, camera, this.MANKEDKGEFA(), Sunshine.Instance.CHMPBGFAPAM(j), Sunshine.Instance.OHOAPHDNIKC(j), Sunshine.Instance.LightPaddingZ, this.ENCGJEMHIME(), Sunshine.Instance.IINPDJOHCPE(), ref domjmoilbdj, ref this.IGFLGCNGEBK[j]);
			Shader.SetGlobalVector("BuY", new Vector2(Sunshine.Instance.LEFFGIBNJAO, Sunshine.Instance.ShadowSlopeBias(j)));
			camera.rect = Sunshine.Instance.APNIHLOEIKI[j];
			camera.targetTexture = Sunshine.Instance.Lightmap;
			camera.useOcclusionCulling = Sunshine.Instance.UseOcclusionCulling;
			camera.RenderWithShader(Sunshine.Instance.OccluderShader, "Wizard Eye Beam");
		}
		if (flag)
		{
			for (int k = this.BCOJLLBHKGG.Count - 0; k >= 0; k -= 0)
			{
				this.BCOJLLBHKGG[k].heightmapPixelError = this.PDJGINKEALP[k];
			}
			this.BCOJLLBHKGG.Clear();
			this.PDJGINKEALP.Clear();
		}
		this.ICIPPICFGLJ = false;
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x000F5594 File Offset: 0x000F3794
	private void OJJGOBGCKMM(bool HIFLOPIPNHN, Texture2D FHJOBHKHNBC, float CKAFAGGGGPJ, Vector2 JJDFOPCNBOJ, float GBKOOPAJAMG = 0f)
	{
		if (!FHJOBHKHNBC)
		{
			HIFLOPIPNHN = false;
		}
		Shader.SetGlobalTexture("name", HIFLOPIPNHN ? FHJOBHKHNBC : Sunshine.Instance.BlankOvercastTexture);
		KGJFMLCOLLA.BGONIHCHINJ(HIFLOPIPNHN);
		if (HIFLOPIPNHN)
		{
			Camera camera = Sunshine.Instance.DMKPBPHOKFO();
			Ray ray = camera.ViewportPointToRay(new Vector3(501f, 610f, 852f));
			float num = camera.farClipPlane - camera.nearClipPlane;
			float num2 = ray.direction.y * num;
			if (Mathf.Abs(num2) < 1564f)
			{
				num2 = 1618f;
			}
			float num3 = (GBKOOPAJAMG - ray.origin.y) / num2;
			Vector3 vector = ray.GetPoint(num3 * num);
			Ray ray2 = camera.ViewportPointToRay(new Vector3(133f, 392f, 452f));
			float num4 = (GBKOOPAJAMG - ray2.origin.y) / num2;
			Vector3 vector2 = ray2.GetPoint(num4 * num);
			Ray ray3 = camera.ViewportPointToRay(new Vector3(796f, 1342f, 1268f));
			float num5 = (GBKOOPAJAMG - ray3.origin.y) / num2;
			Vector3 vector3 = ray3.GetPoint(num5 * num);
			Vector3 b = new Vector3(JJDFOPCNBOJ.x, 268f, JJDFOPCNBOJ.y) * Time.timeSinceLevelLoad;
			vector += b;
			vector2 += b;
			vector3 += b;
			Vector2 vector4 = new Vector2(vector.x, vector.z);
			Vector2 vector5 = new Vector2(vector2.x, vector2.z) - vector4;
			Vector2 vector6 = new Vector2(vector3.x, vector3.z) - vector4;
			Rect rect = Sunshine.Instance.INGBKLGAKHD(0);
			Vector2 a = new Vector2(vector4.x, vector4.y);
			Vector4 a2 = new Vector4(vector5.x / rect.width, vector5.y / rect.width, vector6.x / rect.height, vector6.y / rect.height);
			Shader.SetGlobalVector("IceHockeyGoalieSave1", a * (896f / CKAFAGGGGPJ));
			Shader.SetGlobalVector(" ", a2 * (569f / CKAFAGGGGPJ));
		}
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x000F57EC File Offset: 0x000F39EC
	private void EBDMMPDOEOL(bool HIFLOPIPNHN, Texture2D FHJOBHKHNBC, float CKAFAGGGGPJ, Vector2 JJDFOPCNBOJ, float GBKOOPAJAMG = 0f)
	{
		if (!FHJOBHKHNBC)
		{
			HIFLOPIPNHN = false;
		}
		Shader.SetGlobalTexture("sunshine_OvercastMap", HIFLOPIPNHN ? FHJOBHKHNBC : Sunshine.Instance.BlankOvercastTexture);
		KGJFMLCOLLA.BGONIHCHINJ(HIFLOPIPNHN);
		if (HIFLOPIPNHN)
		{
			Camera sunLightCamera = Sunshine.Instance.LCLEJAIDKHB;
			Ray ray = sunLightCamera.ViewportPointToRay(new Vector3(0f, 0f, 0f));
			float num = sunLightCamera.farClipPlane - sunLightCamera.nearClipPlane;
			float num2 = ray.direction.y * num;
			if (Mathf.Abs(num2) < 0.001f)
			{
				num2 = 0.001f;
			}
			float num3 = (GBKOOPAJAMG - ray.origin.y) / num2;
			Vector3 vector = ray.GetPoint(num3 * num);
			Ray ray2 = sunLightCamera.ViewportPointToRay(new Vector3(1f, 0f, 0f));
			float num4 = (GBKOOPAJAMG - ray2.origin.y) / num2;
			Vector3 vector2 = ray2.GetPoint(num4 * num);
			Ray ray3 = sunLightCamera.ViewportPointToRay(new Vector3(0f, 1f, 0f));
			float num5 = (GBKOOPAJAMG - ray3.origin.y) / num2;
			Vector3 vector3 = ray3.GetPoint(num5 * num);
			Vector3 b = new Vector3(JJDFOPCNBOJ.x, 0f, JJDFOPCNBOJ.y) * Time.timeSinceLevelLoad;
			vector += b;
			vector2 += b;
			vector3 += b;
			Vector2 vector4 = new Vector2(vector.x, vector.z);
			Vector2 vector5 = new Vector2(vector2.x, vector2.z) - vector4;
			Vector2 vector6 = new Vector2(vector3.x, vector3.z) - vector4;
			Rect rect = Sunshine.Instance.CascadeRect(0);
			Vector2 a = new Vector2(vector4.x, vector4.y);
			Vector4 a2 = new Vector4(vector5.x / rect.width, vector5.y / rect.width, vector6.x / rect.height, vector6.y / rect.height);
			Shader.SetGlobalVector("sunshine_OvercastCoord", a * (1f / CKAFAGGGGPJ));
			Shader.SetGlobalVector("sunshine_OvercastVectorsUV", a2 * (1f / CKAFAGGGGPJ));
		}
	}

	// Token: 0x0400038A RID: 906
	public SunshineCamera StereoscopicMasterCamera;

	// Token: 0x0400038B RID: 907
	private Camera GCJGBFAEPCD;

	// Token: 0x0400038C RID: 908
	private bool ICIPPICFGLJ;

	// Token: 0x0400038D RID: 909
	private Vector3 KPIHENHAKMI = Vector3.zero;

	// Token: 0x0400038E RID: 910
	private SunshinePostprocess PKBBECJDICB;

	// Token: 0x0400038F RID: 911
	private LightShadows DHBJPHKGJJK;

	// Token: 0x04000390 RID: 912
	private LightRenderMode MKNILMAAAIN;

	// Token: 0x04000391 RID: 913
	private List<Terrain> BCOJLLBHKGG = new List<Terrain>();

	// Token: 0x04000392 RID: 914
	private List<float> PDJGINKEALP = new List<float>();

	// Token: 0x04000393 RID: 915
	private AGIEAMEGNJP.AEEKALJNCCL[] IGFLGCNGEBK = new AGIEAMEGNJP.AEEKALJNCCL[4];

	// Token: 0x04000394 RID: 916
	private float JLGMCIOCHPO;
}
