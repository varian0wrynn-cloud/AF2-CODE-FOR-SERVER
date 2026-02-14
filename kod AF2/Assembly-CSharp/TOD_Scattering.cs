using System;
using UnityEngine;

// Token: 0x020000DF RID: 223
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
[AddComponentMenu("Time of Day/Camera Scattering")]
public class TOD_Scattering : TOD_ImageEffect
{
	// Token: 0x0600293E RID: 10558 RVA: 0x0012EE28 File Offset: 0x0012D028
	protected void ICIEPDMDONC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 328f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 205f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1449f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(2, vector3);
		identity.SetRow(8, vector4);
		this.GAOONCPEHGP.SetMatrix("IdleStun", identity);
		this.GAOONCPEHGP.SetTexture("DropType", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 1);
	}

	// Token: 0x0600293F RID: 10559 RVA: 0x0012F050 File Offset: 0x0012D250
	protected void DLOGCPJNGLM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 1234f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 31f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1849f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(6, vector3);
		identity.SetRow(8, vector4);
		this.GAOONCPEHGP.SetMatrix("tail", identity);
		this.GAOONCPEHGP.SetTexture("One of the Reach Cones in the polygon has negative volume. Make sure Axis vector is in the reachable area and the polygon is convex.", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x06002940 RID: 10560 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void FLENJDPPMBK()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002941 RID: 10561 RVA: 0x0012F28C File Offset: 0x0012D48C
	protected void EFPADLBDKCC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 96f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 702f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 740f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(1, vector3);
		identity.SetRow(3, vector4);
		this.GAOONCPEHGP.SetMatrix("t_much", identity);
		this.GAOONCPEHGP.SetTexture("ragulaEventProc", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x06002942 RID: 10562 RVA: 0x0012F4B2 File Offset: 0x0012D6B2
	protected void OOIGPKOCEDO()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x06002943 RID: 10563 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void DFCJDHJGILP()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002944 RID: 10564 RVA: 0x0012F4FE File Offset: 0x0012D6FE
	protected void KHMHHBPCPCF()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x06002945 RID: 10565 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void OnEnable()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002946 RID: 10566 RVA: 0x0012F530 File Offset: 0x0012D730
	protected void HKIFJANIGPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 1811f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 100f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 357f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(6, vector3);
		identity.SetRow(6, vector4);
		this.GAOONCPEHGP.SetMatrix("harvestmsg3", identity);
		this.GAOONCPEHGP.SetTexture("reel_type1", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x06002947 RID: 10567 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void OLHGBCBHDBF()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002948 RID: 10568 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void NFLJAJCOGFM()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002949 RID: 10569 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void DFLLLNDKNBB()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x0600294A RID: 10570 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void IABPIBODNNG()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x0600294B RID: 10571 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void OPLLGBIPEKL()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x0600294C RID: 10572 RVA: 0x0012F758 File Offset: 0x0012D958
	protected void CIBNKGCHHJC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 434f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1415f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 222f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(7, vector3);
		identity.SetRow(7, vector4);
		this.GAOONCPEHGP.SetMatrix("Tip", identity);
		this.GAOONCPEHGP.SetTexture("BowIdle", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 1);
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x0012F980 File Offset: 0x0012DB80
	protected void PKNBABMJLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 433f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 204f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 827f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(7, vector3);
		identity.SetRow(1, vector4);
		this.GAOONCPEHGP.SetMatrix("Trying to solve uninitiated FABRIK chain.", identity);
		this.GAOONCPEHGP.SetTexture("cht_tofrend", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x0600294E RID: 10574 RVA: 0x0012FBA8 File Offset: 0x0012DDA8
	protected void EAODOAGNHIK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 1656f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1856f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1474f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(3, vector3);
		identity.SetRow(0, vector4);
		this.GAOONCPEHGP.SetMatrix("wpn_add/base", identity);
		this.GAOONCPEHGP.SetTexture("FBBIKSettings is deprecated, you can now edit all the settings from the custom inspector of the FullBodyBipedIK component.", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 1);
	}

	// Token: 0x0600294F RID: 10575 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void GBAEKFJBEFM()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002950 RID: 10576 RVA: 0x0012FDD0 File Offset: 0x0012DFD0
	protected void JECCAAPKJCK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 406f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1012f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1844f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(6, vector3);
		identity.SetRow(3, vector4);
		this.GAOONCPEHGP.SetMatrix("Textures/Weapons/", identity);
		this.GAOONCPEHGP.SetTexture("wpn_sost", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x06002951 RID: 10577 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void IDGIPDDGDFN()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002952 RID: 10578 RVA: 0x0012FFF8 File Offset: 0x0012E1F8
	protected void IAPMIJOBNKG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 1275f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1139f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 270f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(3, vector3);
		identity.SetRow(7, vector4);
		this.GAOONCPEHGP.SetMatrix("post_11", identity);
		this.GAOONCPEHGP.SetTexture("", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x06002953 RID: 10579 RVA: 0x00130220 File Offset: 0x0012E420
	protected void AJNJJBMCNAP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 638f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 659f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1149f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(5, vector3);
		identity.SetRow(3, vector4);
		this.GAOONCPEHGP.SetMatrix("droplinemsg1", identity);
		this.GAOONCPEHGP.SetTexture("IdleFly", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x06002954 RID: 10580 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void EKOENFCHNKL()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002955 RID: 10581 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void CIDFLCGOBKO()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002956 RID: 10582 RVA: 0x00130446 File Offset: 0x0012E646
	protected void LFKOHBPGANM()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x06002957 RID: 10583 RVA: 0x00130478 File Offset: 0x0012E678
	protected void EBKLGGFBOOI()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x06002958 RID: 10584 RVA: 0x001304AC File Offset: 0x0012E6AC
	protected void PPMLOADNIHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 173f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 973f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1276f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(1, vector3);
		identity.SetRow(8, vector4);
		this.GAOONCPEHGP.SetMatrix("\n", identity);
		this.GAOONCPEHGP.SetTexture("PistolLeftHandStab", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x06002959 RID: 10585 RVA: 0x001306D4 File Offset: 0x0012E8D4
	protected void ANHFNJJHGPO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 828f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 346f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 14f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(2, vector3);
		identity.SetRow(8, vector4);
		this.GAOONCPEHGP.SetMatrix("ShootRaycastModule", identity);
		this.GAOONCPEHGP.SetTexture("OnChatMessage", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x0600295A RID: 10586 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void FLPMJFEGJLG()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x0600295B RID: 10587 RVA: 0x0012F4FE File Offset: 0x0012D6FE
	protected void OnPreCull()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x0600295C RID: 10588 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void FGHHAIDJNMM()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x0600295D RID: 10589 RVA: 0x001308FA File Offset: 0x0012EAFA
	protected void IFNADJCIPCC()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x0600295E RID: 10590 RVA: 0x00130478 File Offset: 0x0012E678
	protected void KMFBINHFJDM()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x0600295F RID: 10591 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void JCGPLGBIMAF()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002960 RID: 10592 RVA: 0x0013092C File Offset: 0x0012EB2C
	protected void JMOCCOHFBCI()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x06002961 RID: 10593 RVA: 0x0012F4FE File Offset: 0x0012D6FE
	protected void BCHEOJCIEPK()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x06002962 RID: 10594 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void ENBMEFPBNLK()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002963 RID: 10595 RVA: 0x0013095E File Offset: 0x0012EB5E
	protected void OGBBCGJFHFB()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x06002964 RID: 10596 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void KFLFNGGBAEB()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002965 RID: 10597 RVA: 0x00130990 File Offset: 0x0012EB90
	protected void HNPNJCMJKKK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 747f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1368f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 268f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(2, vector3);
		identity.SetRow(7, vector4);
		this.GAOONCPEHGP.SetMatrix("StartRigidModule", identity);
		this.GAOONCPEHGP.SetTexture("BowIdle", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x06002966 RID: 10598 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void INEHANLJIEM()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002967 RID: 10599 RVA: 0x001308FA File Offset: 0x0012EAFA
	protected void PDLCGJMHDHE()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x06002968 RID: 10600 RVA: 0x001308FA File Offset: 0x0012EAFA
	protected void MFHIDOJKDBI()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x06002969 RID: 10601 RVA: 0x0012F4FE File Offset: 0x0012D6FE
	protected void KKKHAFBDPNC()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x0600296A RID: 10602 RVA: 0x00130446 File Offset: 0x0012E646
	protected void PBBMKGIIKCL()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x0600296B RID: 10603 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void BGKOJIDABKB()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x0600296C RID: 10604 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void KHJJKPCKNKM()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x0600296D RID: 10605 RVA: 0x00130BB8 File Offset: 0x0012EDB8
	protected void PLOEFNMCMEF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 299f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 926f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 90f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(8, vector3);
		identity.SetRow(5, vector4);
		this.GAOONCPEHGP.SetMatrix("Grounding layers are set to nothing. Please add a ground layer.", identity);
		this.GAOONCPEHGP.SetTexture("error: already initialized", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x0600296E RID: 10606 RVA: 0x00130446 File Offset: 0x0012E646
	protected void OnPostRender()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x0600296F RID: 10607 RVA: 0x00130DDE File Offset: 0x0012EFDE
	protected void IGCJBOFOEFM()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x06002970 RID: 10608 RVA: 0x00130E10 File Offset: 0x0012F010
	protected void BEBHPCOPMMD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 1728f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 943f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1257f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(7, vector3);
		identity.SetRow(3, vector4);
		this.GAOONCPEHGP.SetMatrix("gi_uinf_1", identity);
		this.GAOONCPEHGP.SetTexture("[ACTk] WallHack Detector: can't find 'Hidden/ACTk/WallHackTexture' shader!\nPlease make sure you have it included at the Editor > Project Settings > Graphics.", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 1);
	}

	// Token: 0x06002971 RID: 10609 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void BFOBDCCJIBG()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002972 RID: 10610 RVA: 0x0012F4FE File Offset: 0x0012D6FE
	protected void JFJJDDLDPOJ()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x06002973 RID: 10611 RVA: 0x0013092C File Offset: 0x0012EB2C
	protected void MFNIAEKFLOP()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x06002974 RID: 10612 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void LFJPJFCLGKE()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002975 RID: 10613 RVA: 0x00130478 File Offset: 0x0012E678
	protected void POLPNCCCGHG()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x06002976 RID: 10614 RVA: 0x00131038 File Offset: 0x0012F238
	protected void IFAEDEGLCPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 1237f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1401f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 147f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(7, vector3);
		identity.SetRow(0, vector4);
		this.GAOONCPEHGP.SetMatrix("", identity);
		this.GAOONCPEHGP.SetTexture("Scuba Swim", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x06002977 RID: 10615 RVA: 0x0013092C File Offset: 0x0012EB2C
	protected void OIOAEHEHIAB()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x06002978 RID: 10616 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void HACJAOEBLFG()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002979 RID: 10617 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void LICGFFPIDCM()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x0600297A RID: 10618 RVA: 0x00131260 File Offset: 0x0012F460
	protected void JCOOPIFFNNH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 132f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1824f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 629f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(5, vector3);
		identity.SetRow(4, vector4);
		this.GAOONCPEHGP.SetMatrix("ArmFlex5", identity);
		this.GAOONCPEHGP.SetTexture("WalkBackward", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x0600297B RID: 10619 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void ANHJAOPPMCI()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x0600297C RID: 10620 RVA: 0x00131488 File Offset: 0x0012F688
	protected void LEICKKKLDAD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 13f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1311f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1961f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(5, vector3);
		identity.SetRow(5, vector4);
		this.GAOONCPEHGP.SetMatrix("Smoking2", identity);
		this.GAOONCPEHGP.SetTexture("", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x0600297D RID: 10621 RVA: 0x00130DDE File Offset: 0x0012EFDE
	protected void EELIKFPHIJI()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x0600297E RID: 10622 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void MPFBAEGNPFK()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x0600297F RID: 10623 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void BIDOGNIGPED()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002980 RID: 10624 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void MHIKAMHDEOB()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002981 RID: 10625 RVA: 0x001316B0 File Offset: 0x0012F8B0
	protected void DHBJPMCMCJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 1277f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 414f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 647f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(4, vector3);
		identity.SetRow(5, vector4);
		this.GAOONCPEHGP.SetMatrix("Reset", identity);
		this.GAOONCPEHGP.SetTexture("gi_um_0", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x06002982 RID: 10626 RVA: 0x00130478 File Offset: 0x0012E678
	protected void HMOGOFDGPLB()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x06002983 RID: 10627 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void IFJEIFBOPCI()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002984 RID: 10628 RVA: 0x0012F4FE File Offset: 0x0012D6FE
	protected void OGKKMMMIKDA()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x06002985 RID: 10629 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void NGKEFEKCMOD()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002986 RID: 10630 RVA: 0x001318D8 File Offset: 0x0012FAD8
	protected void NPNOACPLOCB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 151f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 702f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 93f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(6, vector3);
		identity.SetRow(2, vector4);
		this.GAOONCPEHGP.SetMatrix("_DepthCurveLut", identity);
		this.GAOONCPEHGP.SetTexture("", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 1);
	}

	// Token: 0x06002987 RID: 10631 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void OJJKNBMONMD()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002988 RID: 10632 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void IDLLAMOBGGO()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002989 RID: 10633 RVA: 0x00130446 File Offset: 0x0012E646
	protected void EIIILBGLLLN()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x0600298A RID: 10634 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void LLFANOGKPKM()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x0600298B RID: 10635 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void HGHMNMOCPJC()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x0600298C RID: 10636 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void EILDKNMOKBB()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x0600298D RID: 10637 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void OnDisable()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x0600298E RID: 10638 RVA: 0x0012F4FE File Offset: 0x0012D6FE
	protected void NJMBNMDNOPG()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x0600298F RID: 10639 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void CEPJCKHACIP()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002990 RID: 10640 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void OFDECDNDGJI()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002991 RID: 10641 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void DJCLHHNFHHG()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x06002992 RID: 10642 RVA: 0x00130446 File Offset: 0x0012E646
	protected void LFPJCGDJBFD()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x06002993 RID: 10643 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void PBOFGPLACEL()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x06002994 RID: 10644 RVA: 0x00130478 File Offset: 0x0012E678
	protected void IDAENACLLOA()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x06002995 RID: 10645 RVA: 0x0012F4B2 File Offset: 0x0012D6B2
	protected void OILPAIGLMPP()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x06002996 RID: 10646 RVA: 0x0012F4FE File Offset: 0x0012D6FE
	protected void OLBNJKCLCJC()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x06002997 RID: 10647 RVA: 0x0013092C File Offset: 0x0012EB2C
	protected void BKIFIOFMBHB()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x06002998 RID: 10648 RVA: 0x00130DDE File Offset: 0x0012EFDE
	protected void PMANKDGKDJH()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x06002999 RID: 10649 RVA: 0x00130446 File Offset: 0x0012E646
	protected void EPOJLAKECDD()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x0600299A RID: 10650 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void GNDPBDHENFI()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x0600299B RID: 10651 RVA: 0x001308FA File Offset: 0x0012EAFA
	protected void NEHNPOFACMM()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x0600299C RID: 10652 RVA: 0x0012F4B2 File Offset: 0x0012D6B2
	protected void IMLFLEEOFJD()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x0600299D RID: 10653 RVA: 0x00131B00 File Offset: 0x0012FD00
	[ImageEffectOpaque]
	protected void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 0.5f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 0.017453292f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 0.017453292f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(2, vector3);
		identity.SetRow(3, vector4);
		this.GAOONCPEHGP.SetMatrix("_FrustumCornersWS", identity);
		this.GAOONCPEHGP.SetTexture("_DitheringTexture", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x0600299E RID: 10654 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void MOJBLBHKCCM()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x0600299F RID: 10655 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void DENHKOPGLDK()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x060029A0 RID: 10656 RVA: 0x0013092C File Offset: 0x0012EB2C
	protected void ELOEBKBLKEE()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x060029A1 RID: 10657 RVA: 0x00131D28 File Offset: 0x0012FF28
	protected void OOPLKCEGELE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 333f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 225f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1651f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(6, vector3);
		identity.SetRow(8, vector4);
		this.GAOONCPEHGP.SetMatrix("err: rect is null", identity);
		this.GAOONCPEHGP.SetTexture("\n", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x060029A2 RID: 10658 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void KLHDJKDMCJN()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x060029A3 RID: 10659 RVA: 0x0012F4B2 File Offset: 0x0012D6B2
	protected void CDKLNAFBOMD()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x060029A4 RID: 10660 RVA: 0x0012F4B2 File Offset: 0x0012D6B2
	protected void MBOEBAMFFEE()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x060029A5 RID: 10661 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void JFALIJPNCNL()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x060029A6 RID: 10662 RVA: 0x00131F50 File Offset: 0x00130150
	protected void HHLIKPOMGPF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 695f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1705f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1705f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(1, vector3);
		identity.SetRow(8, vector4);
		this.GAOONCPEHGP.SetMatrix("cht_msg31", identity);
		this.GAOONCPEHGP.SetTexture("WATER_SIMPLE", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x060029A7 RID: 10663 RVA: 0x00130DDE File Offset: 0x0012EFDE
	protected void IEBABOKHKPC()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x060029A8 RID: 10664 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void NOLGMGLINIJ()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x060029A9 RID: 10665 RVA: 0x001308FA File Offset: 0x0012EAFA
	protected void KNGNGIJHELJ()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x060029AA RID: 10666 RVA: 0x00130DDE File Offset: 0x0012EFDE
	protected void FLLLFPMKBFN()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x060029AB RID: 10667 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void OPPKDEDJGID()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x060029AC RID: 10668 RVA: 0x0013092C File Offset: 0x0012EB2C
	protected void FHHJCFAOIDO()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x060029AD RID: 10669 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void IMEIOFGKMDK()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x060029AE RID: 10670 RVA: 0x00132178 File Offset: 0x00130378
	protected void GHJHBHOMELE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 961f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 711f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 263f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(8, vector3);
		identity.SetRow(1, vector4);
		this.GAOONCPEHGP.SetMatrix("NadeThrow", identity);
		this.GAOONCPEHGP.SetTexture("change channel press", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x060029AF RID: 10671 RVA: 0x001323A0 File Offset: 0x001305A0
	protected void IDLPAPLFPLJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 1721f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 522f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 540f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(5, vector3);
		identity.SetRow(4, vector4);
		this.GAOONCPEHGP.SetMatrix("WallRunLeft", identity);
		this.GAOONCPEHGP.SetTexture("cntx_close", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x060029B0 RID: 10672 RVA: 0x00130478 File Offset: 0x0012E678
	protected void OLEOOEBDOFJ()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x060029B1 RID: 10673 RVA: 0x001325C8 File Offset: 0x001307C8
	protected void GAJNNKIFMOG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 1871f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1136f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1600f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(4, vector3);
		identity.SetRow(2, vector4);
		this.GAOONCPEHGP.SetMatrix("App QUIT", identity);
		this.GAOONCPEHGP.SetTexture("wpn_add/base", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x060029B2 RID: 10674 RVA: 0x001327F0 File Offset: 0x001309F0
	protected void ENEONPFCPMP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 904f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1088f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 597f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(1, vector3);
		identity.SetRow(4, vector4);
		this.GAOONCPEHGP.SetMatrix("", identity);
		this.GAOONCPEHGP.SetTexture("u_pin", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 1);
	}

	// Token: 0x060029B3 RID: 10675 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void CMCJAPGDFAE()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x060029B4 RID: 10676 RVA: 0x00132A18 File Offset: 0x00130C18
	protected void BMJCNICLDEK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 816f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 98f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1372f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(1, vector3);
		identity.SetRow(1, vector4);
		this.GAOONCPEHGP.SetMatrix("Mesh", identity);
		this.GAOONCPEHGP.SetTexture("Overlay Mesh: ", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x060029B5 RID: 10677 RVA: 0x0013095E File Offset: 0x0012EB5E
	protected void BAOOJOBIFGH()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x060029B6 RID: 10678 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void DKGAOLLKDPD()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x060029B7 RID: 10679 RVA: 0x001308FA File Offset: 0x0012EAFA
	protected void DGFENLJAPHH()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x060029B8 RID: 10680 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void HMLMENDFKHA()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x060029B9 RID: 10681 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void BBAGNFIALFG()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x060029BA RID: 10682 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void DKJJFKFFOHI()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x060029BB RID: 10683 RVA: 0x0012F4FE File Offset: 0x0012D6FE
	protected void PLLMELMEKGJ()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x060029BC RID: 10684 RVA: 0x0012F4FE File Offset: 0x0012D6FE
	protected void AKGDLDFODAI()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x060029BD RID: 10685 RVA: 0x00132C40 File Offset: 0x00130E40
	protected void PBALCCGGFNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 605f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 87f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 777f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(4, vector3);
		identity.SetRow(7, vector4);
		this.GAOONCPEHGP.SetMatrix("wpn_rem3", identity);
		this.GAOONCPEHGP.SetTexture("1HandSwordChargeUp", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 1);
	}

	// Token: 0x060029BE RID: 10686 RVA: 0x00130446 File Offset: 0x0012E646
	protected void EHCCPEDPEMD()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x060029BF RID: 10687 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void CCMOKEDKMNJ()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x060029C0 RID: 10688 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void GICMHNKKECK()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x060029C1 RID: 10689 RVA: 0x00130478 File Offset: 0x0012E678
	protected void HJFELCPKFFN()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x060029C2 RID: 10690 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void FFIBIADBGJB()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x060029C3 RID: 10691 RVA: 0x00132E68 File Offset: 0x00131068
	protected void FHHLPEFGHID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 346f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 881f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1246f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(4, vector3);
		identity.SetRow(8, vector4);
		this.GAOONCPEHGP.SetMatrix("Downsamp", identity);
		this.GAOONCPEHGP.SetTexture("ArmFlex", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 1);
	}

	// Token: 0x060029C4 RID: 10692 RVA: 0x00130478 File Offset: 0x0012E678
	protected void CPEFGMPEMOL()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x060029C5 RID: 10693 RVA: 0x00130478 File Offset: 0x0012E678
	protected void OOOOACFBHKN()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x060029C6 RID: 10694 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void BNCAPAJOMIA()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x060029C7 RID: 10695 RVA: 0x00133090 File Offset: 0x00131290
	protected void DHJHEGHEGOH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 207f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 1026f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 648f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(1, vector3);
		identity.SetRow(3, vector4);
		this.GAOONCPEHGP.SetMatrix("SoccerPassLight", identity);
		this.GAOONCPEHGP.SetTexture("IdleButtonPress", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x060029C9 RID: 10697 RVA: 0x00130446 File Offset: 0x0012E646
	protected void MKHJNDDEODD()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x060029CA RID: 10698 RVA: 0x00130446 File Offset: 0x0012E646
	protected void GKMBJMMJBEG()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.NINFILJKEFA.JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x060029CB RID: 10699 RVA: 0x001332C0 File Offset: 0x001314C0
	protected void MPFCIBPIGGB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(false, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 823f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 154f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 692f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(0, vector3);
		identity.SetRow(2, vector4);
		this.GAOONCPEHGP.SetMatrix("addpar", identity);
		this.GAOONCPEHGP.SetTexture("food_draw.ogg", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 1);
	}

	// Token: 0x060029CC RID: 10700 RVA: 0x00130DDE File Offset: 0x0012EFDE
	protected void EAMEHJGKAOI()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x060029CD RID: 10701 RVA: 0x001334E8 File Offset: 0x001316E8
	protected void LOPLBCLLCID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 1543f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 697f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 156f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(0, vector);
		identity.SetRow(0, vector2);
		identity.SetRow(5, vector3);
		identity.SetRow(1, vector4);
		this.GAOONCPEHGP.SetMatrix("-------------- capId=", identity);
		this.GAOONCPEHGP.SetTexture("myrec", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 1);
	}

	// Token: 0x060029CE RID: 10702 RVA: 0x0012F4E4 File Offset: 0x0012D6E4
	protected void NDHFCDEKJPC()
	{
		if (this.GAOONCPEHGP)
		{
			UnityEngine.Object.DestroyImmediate(this.GAOONCPEHGP);
		}
	}

	// Token: 0x060029CF RID: 10703 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void MNKOLABGENB()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x060029D0 RID: 10704 RVA: 0x00130DDE File Offset: 0x0012EFDE
	protected void HNHPEHMLJFE()
	{
		if (this.sky && this.sky.PNFINJHPEHJ())
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = false;
		}
	}

	// Token: 0x060029D1 RID: 10705 RVA: 0x00133710 File Offset: 0x00131910
	protected void OKPIEJLJHAA(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 765f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 958f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 1603f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(4, vector3);
		identity.SetRow(2, vector4);
		this.GAOONCPEHGP.SetMatrix("_NormalAndRoughnessTexture", identity);
		this.GAOONCPEHGP.SetTexture("SoccerKeeperStrafeRight", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x060029D2 RID: 10706 RVA: 0x0012F276 File Offset: 0x0012D476
	protected void OHPHJCGMNGD()
	{
		this.GAOONCPEHGP = base.PHNMLJJBKDC(this.ScatteringShader);
	}

	// Token: 0x060029D3 RID: 10707 RVA: 0x00133938 File Offset: 0x00131B38
	protected void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(true, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().BDMMNJCHJEK = this;
		float nearClipPlane = this.PMMEFNKFJIA.nearClipPlane;
		float farClipPlane = this.PMMEFNKFJIA.farClipPlane;
		float fieldOfView = this.PMMEFNKFJIA.fieldOfView;
		float aspect = this.PMMEFNKFJIA.aspect;
		Matrix4x4 identity = Matrix4x4.identity;
		float num = fieldOfView * 1484f;
		Vector3 b = this.PMMEFNKFJIA.transform.right * nearClipPlane * Mathf.Tan(num * 701f) * aspect;
		Vector3 b2 = this.PMMEFNKFJIA.transform.up * nearClipPlane * Mathf.Tan(num * 327f);
		Vector3 vector = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b + b2;
		float d = vector.magnitude * farClipPlane / nearClipPlane;
		vector.Normalize();
		vector *= d;
		Vector3 vector2 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b + b2;
		vector2.Normalize();
		vector2 *= d;
		Vector3 vector3 = this.PMMEFNKFJIA.transform.forward * nearClipPlane + b - b2;
		vector3.Normalize();
		vector3 *= d;
		Vector3 vector4 = this.PMMEFNKFJIA.transform.forward * nearClipPlane - b - b2;
		vector4.Normalize();
		vector4 *= d;
		identity.SetRow(1, vector);
		identity.SetRow(1, vector2);
		identity.SetRow(1, vector3);
		identity.SetRow(2, vector4);
		this.GAOONCPEHGP.SetMatrix("%", identity);
		this.GAOONCPEHGP.SetTexture("file://", this.DitheringTexture);
		base.OMIKKBOOPEC(JONJODLFAEN, OKIIDHIJBEA, this.GAOONCPEHGP, 0);
	}

	// Token: 0x060029D4 RID: 10708 RVA: 0x00130478 File Offset: 0x0012E678
	protected void NEAHNADAEMI()
	{
		if (this.sky && this.sky.FPAKOLIPIND)
		{
			this.sky.KMBOELAHKHL().JFBEDPHIDII.enabled = true;
		}
	}

	// Token: 0x0400058E RID: 1422
	public Shader ScatteringShader;

	// Token: 0x0400058F RID: 1423
	public Texture2D DitheringTexture;

	// Token: 0x04000590 RID: 1424
	private Material GAOONCPEHGP;
}
