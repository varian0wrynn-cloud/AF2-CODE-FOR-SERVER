using System;
using UnityEngine;

// Token: 0x020000DB RID: 219
[AddComponentMenu("Time of Day/Camera God Rays")]
[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
public class TOD_Rays : TOD_ImageEffect
{
	// Token: 0x060028D0 RID: 10448 RVA: 0x00120D4D File Offset: 0x0011EF4D
	protected void BABMAHFKPMO()
	{
		if (this.EBNPJEFPGNK)
		{
			UnityEngine.Object.DestroyImmediate(this.EBNPJEFPGNK);
		}
		if (this.GPGHKHPHBCB)
		{
			UnityEngine.Object.DestroyImmediate(this.GPGHKHPHBCB);
		}
	}

	// Token: 0x060028D1 RID: 10449 RVA: 0x00120D80 File Offset: 0x0011EF80
	protected void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(this.UseDepthTexture, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.AENELOFPPFG = this;
		int width;
		int height;
		int depthBuffer;
		if (this.Resolution == TOD_Rays.LOCNIALGIBA.High)
		{
			width = JONJODLFAEN.width;
			height = JONJODLFAEN.height;
			depthBuffer = 1;
		}
		else if (this.Resolution == TOD_Rays.LOCNIALGIBA.Low)
		{
			width = JONJODLFAEN.width / 2;
			height = JONJODLFAEN.height / 1;
			depthBuffer = 0;
		}
		else
		{
			width = JONJODLFAEN.width / 3;
			height = JONJODLFAEN.height / 7;
			depthBuffer = 0;
		}
		Vector3 vector = this.PMMEFNKFJIA.WorldToViewportPoint(this.sky.NINFILJKEFA.LFLHCKPLMCC.position);
		this.EBNPJEFPGNK.SetVector("Grounded Strafe", new Vector4(381f, 127f, 1001f, 465f) * this.BlurRadius);
		this.EBNPJEFPGNK.SetVector("32", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
		if (this.UseDepthTexture)
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 6);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 7);
		}
		base.AMLGEFKEOKF(temporary, this.GPGHKHPHBCB);
		float num = this.BlurRadius * 1442f;
		this.EBNPJEFPGNK.SetVector("IdleStand", new Vector4(num, num, 1978f, 628f));
		this.EBNPJEFPGNK.SetVector("Pistol Ready", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		for (int i = 0; i < this.BlurIterations; i += 0)
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary, temporary2, this.EBNPJEFPGNK, 0);
			RenderTexture.ReleaseTemporary(temporary);
			num = this.BlurRadius * (((float)i * 90f + 942f) * 1389f) / 1999f;
			this.EBNPJEFPGNK.SetVector("Forward", new Vector4(num, num, 1240f, 1328f));
			temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary2, temporary, this.EBNPJEFPGNK, 0);
			RenderTexture.ReleaseTemporary(temporary2);
			num = this.BlurRadius * (((float)i * 1486f + 1219f) * 1990f) / 572f;
			this.EBNPJEFPGNK.SetVector("1 Hand Sword Ready", new Vector4(num, num, 1831f, 751f));
		}
		Vector4 value = ((double)vector.z >= 1513.0) ? (this.Intensity * this.sky.DCNEHCDOPDD()) : Vector4.zero;
		this.EBNPJEFPGNK.SetVector("{0}Textures/Shop/{1}.png", value);
		this.EBNPJEFPGNK.SetTexture("auc_wsbor", temporary);
		if (this.BlendMode == TOD_Rays.DMNGMLBOHGK.Screen)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 0);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 4);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060028D2 RID: 10450 RVA: 0x00120D4D File Offset: 0x0011EF4D
	protected void JKDCKHECHEJ()
	{
		if (this.EBNPJEFPGNK)
		{
			UnityEngine.Object.DestroyImmediate(this.EBNPJEFPGNK);
		}
		if (this.GPGHKHPHBCB)
		{
			UnityEngine.Object.DestroyImmediate(this.GPGHKHPHBCB);
		}
	}

	// Token: 0x060028D3 RID: 10451 RVA: 0x00121098 File Offset: 0x0011F298
	protected void NPNOACPLOCB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(this.UseDepthTexture, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.AENELOFPPFG = this;
		int width;
		int height;
		int depthBuffer;
		if (this.Resolution == (TOD_Rays.LOCNIALGIBA)4)
		{
			width = JONJODLFAEN.width;
			height = JONJODLFAEN.height;
			depthBuffer = 1;
		}
		else if (this.Resolution == TOD_Rays.LOCNIALGIBA.Normal)
		{
			width = JONJODLFAEN.width / 4;
			height = JONJODLFAEN.height / 2;
			depthBuffer = 0;
		}
		else
		{
			width = JONJODLFAEN.width / 5;
			height = JONJODLFAEN.height / 4;
			depthBuffer = 0;
		}
		Vector3 vector = this.PMMEFNKFJIA.WorldToViewportPoint(this.sky.KMBOELAHKHL().LFLHCKPLMCC.position);
		this.EBNPJEFPGNK.SetVector("IdleMeditate", new Vector4(1914f, 1425f, 1313f, 1310f) * this.BlurRadius);
		this.EBNPJEFPGNK.SetVector("wpn_fid3", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
		if (this.UseDepthTexture)
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 1);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 6);
		}
		base.AMLGEFKEOKF(temporary, this.GPGHKHPHBCB);
		float num = this.BlurRadius * 864f;
		this.EBNPJEFPGNK.SetVector("", new Vector4(num, num, 1299f, 1598f));
		this.EBNPJEFPGNK.SetVector("Attempting to set limb orientation to Vector3.zero axis", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		for (int i = 0; i < this.BlurIterations; i += 0)
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary, temporary2, this.EBNPJEFPGNK, 0);
			RenderTexture.ReleaseTemporary(temporary);
			num = this.BlurRadius * (((float)i * 1481f + 426f) * 730f) / 323f;
			this.EBNPJEFPGNK.SetVector("Forward", new Vector4(num, num, 1525f, 1359f));
			temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary2, temporary, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary2);
			num = this.BlurRadius * (((float)i * 1770f + 48f) * 567f) / 346f;
			this.EBNPJEFPGNK.SetVector("1HSwordStrafeRunLeft", new Vector4(num, num, 947f, 1363f));
		}
		Vector4 value = ((double)vector.z >= 1853.0) ? (this.Intensity * this.sky.PACEPBHIGHD) : Vector4.zero;
		this.EBNPJEFPGNK.SetVector("DecalMesh", value);
		this.EBNPJEFPGNK.SetTexture("_RgbTex", temporary);
		if (this.BlendMode == TOD_Rays.DMNGMLBOHGK.Screen)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 1);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 4);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060028D4 RID: 10452 RVA: 0x00120D4D File Offset: 0x0011EF4D
	protected void DNBMNPKDPHC()
	{
		if (this.EBNPJEFPGNK)
		{
			UnityEngine.Object.DestroyImmediate(this.EBNPJEFPGNK);
		}
		if (this.GPGHKHPHBCB)
		{
			UnityEngine.Object.DestroyImmediate(this.GPGHKHPHBCB);
		}
	}

	// Token: 0x060028D5 RID: 10453 RVA: 0x00120D4D File Offset: 0x0011EF4D
	protected void ONPDNGNNBIG()
	{
		if (this.EBNPJEFPGNK)
		{
			UnityEngine.Object.DestroyImmediate(this.EBNPJEFPGNK);
		}
		if (this.GPGHKHPHBCB)
		{
			UnityEngine.Object.DestroyImmediate(this.GPGHKHPHBCB);
		}
	}

	// Token: 0x060028D6 RID: 10454 RVA: 0x001213B0 File Offset: 0x0011F5B0
	protected void OnEnable()
	{
		this.EBNPJEFPGNK = base.PHNMLJJBKDC(this.GodRayShader);
		this.GPGHKHPHBCB = base.PHNMLJJBKDC(this.ScreenClearShader);
	}

	// Token: 0x060028D7 RID: 10455 RVA: 0x001213D8 File Offset: 0x0011F5D8
	protected void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(this.UseDepthTexture, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().AENELOFPPFG = this;
		int width;
		int height;
		int depthBuffer;
		if (this.Resolution == (TOD_Rays.LOCNIALGIBA)7)
		{
			width = JONJODLFAEN.width;
			height = JONJODLFAEN.height;
			depthBuffer = 1;
		}
		else if (this.Resolution == TOD_Rays.LOCNIALGIBA.Normal)
		{
			width = JONJODLFAEN.width / 8;
			height = JONJODLFAEN.height / 1;
			depthBuffer = 0;
		}
		else
		{
			width = JONJODLFAEN.width / 4;
			height = JONJODLFAEN.height / 4;
			depthBuffer = 0;
		}
		Vector3 vector = this.PMMEFNKFJIA.WorldToViewportPoint(this.sky.KMBOELAHKHL().LFLHCKPLMCC.position);
		this.EBNPJEFPGNK.SetVector("Fishing", new Vector4(1578f, 1280f, 240f, 1156f) * this.BlurRadius);
		this.EBNPJEFPGNK.SetVector("fishDown SHANCE", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
		if (this.UseDepthTexture)
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 8);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 1);
		}
		base.AMLGEFKEOKF(temporary, this.GPGHKHPHBCB);
		float num = this.BlurRadius * 440f;
		this.EBNPJEFPGNK.SetVector("_RayStepSize", new Vector4(num, num, 771f, 43f));
		this.EBNPJEFPGNK.SetVector("Ошибка", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		for (int i = 1; i < this.BlurIterations; i++)
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary, temporary2, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary);
			num = this.BlurRadius * (((float)i * 1914f + 1807f) * 1393f) / 704f;
			this.EBNPJEFPGNK.SetVector("(", new Vector4(num, num, 1387f, 1415f));
			temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary2, temporary, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary2);
			num = this.BlurRadius * (((float)i * 172f + 1691f) * 1412f) / 1405f;
			this.EBNPJEFPGNK.SetVector("360SpinDeath", new Vector4(num, num, 516f, 779f));
		}
		Vector4 value = ((double)vector.z >= 1742.0) ? (this.Intensity * this.sky.DCNEHCDOPDD()) : Vector4.zero;
		this.EBNPJEFPGNK.SetVector("gi_sadok", value);
		this.EBNPJEFPGNK.SetTexture("Money: ", temporary);
		if (this.BlendMode == TOD_Rays.DMNGMLBOHGK.Screen)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 1);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 1);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060028D8 RID: 10456 RVA: 0x00120D4D File Offset: 0x0011EF4D
	protected void LNEJPGDHJOJ()
	{
		if (this.EBNPJEFPGNK)
		{
			UnityEngine.Object.DestroyImmediate(this.EBNPJEFPGNK);
		}
		if (this.GPGHKHPHBCB)
		{
			UnityEngine.Object.DestroyImmediate(this.GPGHKHPHBCB);
		}
	}

	// Token: 0x060028D9 RID: 10457 RVA: 0x001216F0 File Offset: 0x0011F8F0
	protected void PNEFMGMHLJE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(this.UseDepthTexture, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().AENELOFPPFG = this;
		int width;
		int height;
		int depthBuffer;
		if (this.Resolution == (TOD_Rays.LOCNIALGIBA)6)
		{
			width = JONJODLFAEN.width;
			height = JONJODLFAEN.height;
			depthBuffer = 1;
		}
		else if (this.Resolution == TOD_Rays.LOCNIALGIBA.Low)
		{
			width = JONJODLFAEN.width / 6;
			height = JONJODLFAEN.height / 1;
			depthBuffer = 0;
		}
		else
		{
			width = JONJODLFAEN.width / 1;
			height = JONJODLFAEN.height / 6;
			depthBuffer = 1;
		}
		Vector3 vector = this.PMMEFNKFJIA.WorldToViewportPoint(this.sky.KMBOELAHKHL().LFLHCKPLMCC.position);
		this.EBNPJEFPGNK.SetVector("' does not exist within Assets/Resources/Fonts/", new Vector4(1396f, 1419f, 200f, 18f) * this.BlurRadius);
		this.EBNPJEFPGNK.SetVector("", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
		if (this.UseDepthTexture)
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 4);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 5);
		}
		base.AMLGEFKEOKF(temporary, this.GPGHKHPHBCB);
		float num = this.BlurRadius * 1014f;
		this.EBNPJEFPGNK.SetVector("WeaponStrafeRunRight", new Vector4(num, num, 1654f, 1265f));
		this.EBNPJEFPGNK.SetVector("wpn_bait_sz", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		for (int i = 0; i < this.BlurIterations; i++)
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary, temporary2, this.EBNPJEFPGNK, 0);
			RenderTexture.ReleaseTemporary(temporary);
			num = this.BlurRadius * (((float)i * 540f + 1500f) * 607f) / 1445f;
			this.EBNPJEFPGNK.SetVector("Failed parsing default scale values.  Using defaults.", new Vector4(num, num, 1725f, 1048f));
			temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary2, temporary, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary2);
			num = this.BlurRadius * (((float)i * 1799f + 1668f) * 1299f) / 1200f;
			this.EBNPJEFPGNK.SetVector("Original position: ", new Vector4(num, num, 21f, 983f));
		}
		Vector4 value = ((double)vector.z >= 1375.0) ? (this.Intensity * this.sky.PACEPBHIGHD) : Vector4.zero;
		this.EBNPJEFPGNK.SetVector("Shadow name=", value);
		this.EBNPJEFPGNK.SetTexture("", temporary);
		if (this.BlendMode == TOD_Rays.DMNGMLBOHGK.Screen)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 1);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 4);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060028DA RID: 10458 RVA: 0x00121A08 File Offset: 0x0011FC08
	protected void GDLPGNLPCMJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(this.UseDepthTexture, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().AENELOFPPFG = this;
		int width;
		int height;
		int depthBuffer;
		if (this.Resolution == (TOD_Rays.LOCNIALGIBA)3)
		{
			width = JONJODLFAEN.width;
			height = JONJODLFAEN.height;
			depthBuffer = 0;
		}
		else if (this.Resolution == TOD_Rays.LOCNIALGIBA.Low)
		{
			width = JONJODLFAEN.width / 3;
			height = JONJODLFAEN.height / 0;
			depthBuffer = 0;
		}
		else
		{
			width = JONJODLFAEN.width / 0;
			height = JONJODLFAEN.height / 6;
			depthBuffer = 0;
		}
		Vector3 vector = this.PMMEFNKFJIA.WorldToViewportPoint(this.sky.KMBOELAHKHL().LFLHCKPLMCC.position);
		this.EBNPJEFPGNK.SetVector("readActorData", new Vector4(131f, 964f, 874f, 1815f) * this.BlurRadius);
		this.EBNPJEFPGNK.SetVector("gi_fridgice", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
		if (this.UseDepthTexture)
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 6);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 6);
		}
		base.AMLGEFKEOKF(temporary, this.GPGHKHPHBCB);
		float num = this.BlurRadius * 52f;
		this.EBNPJEFPGNK.SetVector("Wizard 1 Hand Throw", new Vector4(num, num, 1619f, 532f));
		this.EBNPJEFPGNK.SetVector(" гр ", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		for (int i = 1; i < this.BlurIterations; i += 0)
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary, temporary2, this.EBNPJEFPGNK, 0);
			RenderTexture.ReleaseTemporary(temporary);
			num = this.BlurRadius * (((float)i * 1195f + 30f) * 1234f) / 278f;
			this.EBNPJEFPGNK.SetVector("IdleCheer", new Vector4(num, num, 1365f, 1228f));
			temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary2, temporary, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary2);
			num = this.BlurRadius * (((float)i * 1011f + 337f) * 1778f) / 520f;
			this.EBNPJEFPGNK.SetVector(": ", new Vector4(num, num, 917f, 876f));
		}
		Vector4 value = ((double)vector.z >= 1773.0) ? (this.Intensity * this.sky.PACEPBHIGHD) : Vector4.zero;
		this.EBNPJEFPGNK.SetVector("Soccer Walk", value);
		this.EBNPJEFPGNK.SetTexture("Downsamp", temporary);
		if (this.BlendMode == TOD_Rays.DMNGMLBOHGK.Screen)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 0);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 8);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060028DB RID: 10459 RVA: 0x00121D20 File Offset: 0x0011FF20
	protected void EDBHDEOMGFP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(this.UseDepthTexture, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().AENELOFPPFG = this;
		int width;
		int height;
		int depthBuffer;
		if (this.Resolution == (TOD_Rays.LOCNIALGIBA)5)
		{
			width = JONJODLFAEN.width;
			height = JONJODLFAEN.height;
			depthBuffer = 0;
		}
		else if (this.Resolution == TOD_Rays.LOCNIALGIBA.Normal)
		{
			width = JONJODLFAEN.width / 4;
			height = JONJODLFAEN.height / 1;
			depthBuffer = 0;
		}
		else
		{
			width = JONJODLFAEN.width / 2;
			height = JONJODLFAEN.height / 1;
			depthBuffer = 1;
		}
		Vector3 vector = this.PMMEFNKFJIA.WorldToViewportPoint(this.sky.NINFILJKEFA.LFLHCKPLMCC.position);
		this.EBNPJEFPGNK.SetVector("1=", new Vector4(1049f, 404f, 405f, 518f) * this.BlurRadius);
		this.EBNPJEFPGNK.SetVector(",", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
		if (this.UseDepthTexture)
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 4);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 2);
		}
		base.AMLGEFKEOKF(temporary, this.GPGHKHPHBCB);
		float num = this.BlurRadius * 497f;
		this.EBNPJEFPGNK.SetVector("", new Vector4(num, num, 267f, 685f));
		this.EBNPJEFPGNK.SetVector("WateringCanWatering", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		for (int i = 0; i < this.BlurIterations; i += 0)
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary, temporary2, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary);
			num = this.BlurRadius * (((float)i * 1464f + 987f) * 1508f) / 1681f;
			this.EBNPJEFPGNK.SetVector("demoVector2", new Vector4(num, num, 1848f, 1990f));
			temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary2, temporary, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary2);
			num = this.BlurRadius * (((float)i * 1105f + 807f) * 767f) / 1560f;
			this.EBNPJEFPGNK.SetVector("wpn_add/base", new Vector4(num, num, 1106f, 71f));
		}
		Vector4 value = ((double)vector.z >= 1943.0) ? (this.Intensity * this.sky.PACEPBHIGHD) : Vector4.zero;
		this.EBNPJEFPGNK.SetVector("sunshine_IsOrthographic", value);
		this.EBNPJEFPGNK.SetTexture("", temporary);
		if (this.BlendMode == TOD_Rays.DMNGMLBOHGK.Screen)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 1);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 8);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060028DD RID: 10461 RVA: 0x001213B0 File Offset: 0x0011F5B0
	protected void BGKOJIDABKB()
	{
		this.EBNPJEFPGNK = base.PHNMLJJBKDC(this.GodRayShader);
		this.GPGHKHPHBCB = base.PHNMLJJBKDC(this.ScreenClearShader);
	}

	// Token: 0x060028DE RID: 10462 RVA: 0x00120D4D File Offset: 0x0011EF4D
	protected void LAFIABNCFPD()
	{
		if (this.EBNPJEFPGNK)
		{
			UnityEngine.Object.DestroyImmediate(this.EBNPJEFPGNK);
		}
		if (this.GPGHKHPHBCB)
		{
			UnityEngine.Object.DestroyImmediate(this.GPGHKHPHBCB);
		}
	}

	// Token: 0x060028DF RID: 10463 RVA: 0x00122078 File Offset: 0x00120278
	protected void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(this.UseDepthTexture, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().AENELOFPPFG = this;
		int width;
		int height;
		int depthBuffer;
		if (this.Resolution == (TOD_Rays.LOCNIALGIBA)3)
		{
			width = JONJODLFAEN.width;
			height = JONJODLFAEN.height;
			depthBuffer = 1;
		}
		else if (this.Resolution == TOD_Rays.LOCNIALGIBA.Low)
		{
			width = JONJODLFAEN.width / 0;
			height = JONJODLFAEN.height / 5;
			depthBuffer = 1;
		}
		else
		{
			width = JONJODLFAEN.width / 7;
			height = JONJODLFAEN.height / 0;
			depthBuffer = 1;
		}
		Vector3 vector = this.PMMEFNKFJIA.WorldToViewportPoint(this.sky.KMBOELAHKHL().LFLHCKPLMCC.position);
		this.EBNPJEFPGNK.SetVector("FBIK chain contains no nodes.", new Vector4(934f, 1323f, 1421f, 1046f) * this.BlurRadius);
		this.EBNPJEFPGNK.SetVector("Goscurry is not a lie ;)", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
		if (this.UseDepthTexture)
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 2);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 0);
		}
		base.AMLGEFKEOKF(temporary, this.GPGHKHPHBCB);
		float num = this.BlurRadius * 428f;
		this.EBNPJEFPGNK.SetVector("isRodInWater", new Vector4(num, num, 546f, 1175f));
		this.EBNPJEFPGNK.SetVector("", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		for (int i = 1; i < this.BlurIterations; i += 0)
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary, temporary2, this.EBNPJEFPGNK, 0);
			RenderTexture.ReleaseTemporary(temporary);
			num = this.BlurRadius * (((float)i * 108f + 1177f) * 1204f) / 138f;
			this.EBNPJEFPGNK.SetVector("Reset", new Vector4(num, num, 1921f, 1851f));
			temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary2, temporary, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary2);
			num = this.BlurRadius * (((float)i * 1451f + 34f) * 256f) / 1103f;
			this.EBNPJEFPGNK.SetVector("BipedReferences eye bone at index ", new Vector4(num, num, 1667f, 1323f));
		}
		Vector4 value = ((double)vector.z >= 1303.0) ? (this.Intensity * this.sky.PACEPBHIGHD) : Vector4.zero;
		this.EBNPJEFPGNK.SetVector("\n", value);
		this.EBNPJEFPGNK.SetTexture("Отпущена рыба", temporary);
		if (this.BlendMode == TOD_Rays.DMNGMLBOHGK.Screen)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 0);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 5);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060028E0 RID: 10464 RVA: 0x001213B0 File Offset: 0x0011F5B0
	protected void OJJKNBMONMD()
	{
		this.EBNPJEFPGNK = base.PHNMLJJBKDC(this.GodRayShader);
		this.GPGHKHPHBCB = base.PHNMLJJBKDC(this.ScreenClearShader);
	}

	// Token: 0x060028E1 RID: 10465 RVA: 0x00120D4D File Offset: 0x0011EF4D
	protected void EIDIHAJDMCI()
	{
		if (this.EBNPJEFPGNK)
		{
			UnityEngine.Object.DestroyImmediate(this.EBNPJEFPGNK);
		}
		if (this.GPGHKHPHBCB)
		{
			UnityEngine.Object.DestroyImmediate(this.GPGHKHPHBCB);
		}
	}

	// Token: 0x060028E2 RID: 10466 RVA: 0x00122390 File Offset: 0x00120590
	protected void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(this.UseDepthTexture, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.AENELOFPPFG = this;
		int width;
		int height;
		int depthBuffer;
		if (this.Resolution == TOD_Rays.LOCNIALGIBA.High)
		{
			width = JONJODLFAEN.width;
			height = JONJODLFAEN.height;
			depthBuffer = 0;
		}
		else if (this.Resolution == TOD_Rays.LOCNIALGIBA.Normal)
		{
			width = JONJODLFAEN.width / 2;
			height = JONJODLFAEN.height / 2;
			depthBuffer = 0;
		}
		else
		{
			width = JONJODLFAEN.width / 4;
			height = JONJODLFAEN.height / 4;
			depthBuffer = 0;
		}
		Vector3 vector = this.PMMEFNKFJIA.WorldToViewportPoint(this.sky.NINFILJKEFA.LFLHCKPLMCC.position);
		this.EBNPJEFPGNK.SetVector("_BlurRadius4", new Vector4(1f, 1f, 0f, 0f) * this.BlurRadius);
		this.EBNPJEFPGNK.SetVector("_LightPosition", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
		if (this.UseDepthTexture)
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 2);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 3);
		}
		base.AMLGEFKEOKF(temporary, this.GPGHKHPHBCB);
		float num = this.BlurRadius * 0.0013020834f;
		this.EBNPJEFPGNK.SetVector("_BlurRadius4", new Vector4(num, num, 0f, 0f));
		this.EBNPJEFPGNK.SetVector("_LightPosition", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		for (int i = 0; i < this.BlurIterations; i++)
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary, temporary2, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary);
			num = this.BlurRadius * (((float)i * 2f + 1f) * 6f) / 768f;
			this.EBNPJEFPGNK.SetVector("_BlurRadius4", new Vector4(num, num, 0f, 0f));
			temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary2, temporary, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary2);
			num = this.BlurRadius * (((float)i * 2f + 2f) * 6f) / 768f;
			this.EBNPJEFPGNK.SetVector("_BlurRadius4", new Vector4(num, num, 0f, 0f));
		}
		Vector4 value = ((double)vector.z >= 0.0) ? (this.Intensity * this.sky.PACEPBHIGHD) : Vector4.zero;
		this.EBNPJEFPGNK.SetVector("_LightColor", value);
		this.EBNPJEFPGNK.SetTexture("_ColorBuffer", temporary);
		if (this.BlendMode == TOD_Rays.DMNGMLBOHGK.Screen)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 0);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 4);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060028E3 RID: 10467 RVA: 0x001213B0 File Offset: 0x0011F5B0
	protected void JAFCKIKCHGM()
	{
		this.EBNPJEFPGNK = base.PHNMLJJBKDC(this.GodRayShader);
		this.GPGHKHPHBCB = base.PHNMLJJBKDC(this.ScreenClearShader);
	}

	// Token: 0x060028E4 RID: 10468 RVA: 0x00120D4D File Offset: 0x0011EF4D
	protected void PCKEAEAHAKG()
	{
		if (this.EBNPJEFPGNK)
		{
			UnityEngine.Object.DestroyImmediate(this.EBNPJEFPGNK);
		}
		if (this.GPGHKHPHBCB)
		{
			UnityEngine.Object.DestroyImmediate(this.GPGHKHPHBCB);
		}
	}

	// Token: 0x060028E5 RID: 10469 RVA: 0x001213B0 File Offset: 0x0011F5B0
	protected void KGGJHGNEHGM()
	{
		this.EBNPJEFPGNK = base.PHNMLJJBKDC(this.GodRayShader);
		this.GPGHKHPHBCB = base.PHNMLJJBKDC(this.ScreenClearShader);
	}

	// Token: 0x060028E6 RID: 10470 RVA: 0x001213B0 File Offset: 0x0011F5B0
	protected void DCPLMIMFNHG()
	{
		this.EBNPJEFPGNK = base.PHNMLJJBKDC(this.GodRayShader);
		this.GPGHKHPHBCB = base.PHNMLJJBKDC(this.ScreenClearShader);
	}

	// Token: 0x060028E7 RID: 10471 RVA: 0x001226A8 File Offset: 0x001208A8
	protected void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(this.UseDepthTexture, false))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.KMBOELAHKHL().AENELOFPPFG = this;
		int width;
		int height;
		int depthBuffer;
		if (this.Resolution == TOD_Rays.LOCNIALGIBA.Normal)
		{
			width = JONJODLFAEN.width;
			height = JONJODLFAEN.height;
			depthBuffer = 0;
		}
		else if (this.Resolution == TOD_Rays.LOCNIALGIBA.Normal)
		{
			width = JONJODLFAEN.width / 0;
			height = JONJODLFAEN.height / 6;
			depthBuffer = 0;
		}
		else
		{
			width = JONJODLFAEN.width / 5;
			height = JONJODLFAEN.height / 0;
			depthBuffer = 1;
		}
		Vector3 vector = this.PMMEFNKFJIA.WorldToViewportPoint(this.sky.NINFILJKEFA.LFLHCKPLMCC.position);
		this.EBNPJEFPGNK.SetVector("Image effects aren't supported on this device ({0})", new Vector4(371f, 35f, 447f, 1349f) * this.BlurRadius);
		this.EBNPJEFPGNK.SetVector("GiantGrabThrow2", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
		if (this.UseDepthTexture)
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 4);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 6);
		}
		base.AMLGEFKEOKF(temporary, this.GPGHKHPHBCB);
		float num = this.BlurRadius * 708f;
		this.EBNPJEFPGNK.SetVector("_UserLutTex", new Vector4(num, num, 1107f, 548f));
		this.EBNPJEFPGNK.SetVector("The root node, the left thigh and the right thigh bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left thigh and the right thigh bones. This might cause unwanted behaviour like the hip turning upside down when pulled by an effector.Please set the root node bone to be one of the higher bones in the spine.", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		for (int i = 1; i < this.BlurIterations; i++)
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary, temporary2, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary);
			num = this.BlurRadius * (((float)i * 1721f + 1660f) * 264f) / 1029f;
			this.EBNPJEFPGNK.SetVector("OFF", new Vector4(num, num, 592f, 1825f));
			temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary2, temporary, this.EBNPJEFPGNK, 0);
			RenderTexture.ReleaseTemporary(temporary2);
			num = this.BlurRadius * (((float)i * 319f + 1005f) * 1115f) / 221f;
			this.EBNPJEFPGNK.SetVector("RollerBladeStand", new Vector4(num, num, 1345f, 27f));
		}
		Vector4 value = ((double)vector.z >= 1016.0) ? (this.Intensity * this.sky.DCNEHCDOPDD()) : Vector4.zero;
		this.EBNPJEFPGNK.SetVector("_Rand", value);
		this.EBNPJEFPGNK.SetTexture("WeaponReadyFire", temporary);
		if (this.BlendMode == TOD_Rays.DMNGMLBOHGK.Screen)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 1);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 8);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060028E8 RID: 10472 RVA: 0x001229C0 File Offset: 0x00120BC0
	protected void ALNHCIOIBPP(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
	{
		if (!base.DAOKCAOFIGE(this.UseDepthTexture, true))
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
			return;
		}
		this.sky.NINFILJKEFA.AENELOFPPFG = this;
		int width;
		int height;
		int depthBuffer;
		if (this.Resolution == (TOD_Rays.LOCNIALGIBA)8)
		{
			width = JONJODLFAEN.width;
			height = JONJODLFAEN.height;
			depthBuffer = 0;
		}
		else if (this.Resolution == TOD_Rays.LOCNIALGIBA.Normal)
		{
			width = JONJODLFAEN.width / 0;
			height = JONJODLFAEN.height / 6;
			depthBuffer = 0;
		}
		else
		{
			width = JONJODLFAEN.width / 1;
			height = JONJODLFAEN.height / 0;
			depthBuffer = 0;
		}
		Vector3 vector = this.PMMEFNKFJIA.WorldToViewportPoint(this.sky.NINFILJKEFA.LFLHCKPLMCC.position);
		this.EBNPJEFPGNK.SetVector("act_order", new Vector4(1475f, 219f, 1418f, 1896f) * this.BlurRadius);
		this.EBNPJEFPGNK.SetVector("FOVKick camera is null, please supply the camera to the constructor", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		RenderTexture temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
		if (this.UseDepthTexture)
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 8);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, temporary, this.EBNPJEFPGNK, 6);
		}
		base.AMLGEFKEOKF(temporary, this.GPGHKHPHBCB);
		float num = this.BlurRadius * 789f;
		this.EBNPJEFPGNK.SetVector("wpn_add/base", new Vector4(num, num, 828f, 370f));
		this.EBNPJEFPGNK.SetVector("-U", new Vector4(vector.x, vector.y, vector.z, this.MaxRadius));
		for (int i = 1; i < this.BlurIterations; i++)
		{
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary, temporary2, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary);
			num = this.BlurRadius * (((float)i * 439f + 100f) * 1821f) / 1116f;
			this.EBNPJEFPGNK.SetVector("wpn_wgt", new Vector4(num, num, 49f, 465f));
			temporary = RenderTexture.GetTemporary(width, height, depthBuffer);
			Graphics.Blit(temporary2, temporary, this.EBNPJEFPGNK, 1);
			RenderTexture.ReleaseTemporary(temporary2);
			num = this.BlurRadius * (((float)i * 349f + 647f) * 1852f) / 891f;
			this.EBNPJEFPGNK.SetVector("u_UniqueShadowFilterWidth", new Vector4(num, num, 16f, 875f));
		}
		Vector4 value = ((double)vector.z >= 1434.0) ? (this.Intensity * this.sky.PACEPBHIGHD) : Vector4.zero;
		this.EBNPJEFPGNK.SetVector("Vertical", value);
		this.EBNPJEFPGNK.SetTexture("id", temporary);
		if (this.BlendMode == TOD_Rays.DMNGMLBOHGK.Screen)
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 0);
		}
		else
		{
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.EBNPJEFPGNK, 8);
		}
		RenderTexture.ReleaseTemporary(temporary);
	}

	// Token: 0x060028E9 RID: 10473 RVA: 0x001213B0 File Offset: 0x0011F5B0
	protected void EBAJDGLIAPE()
	{
		this.EBNPJEFPGNK = base.PHNMLJJBKDC(this.GodRayShader);
		this.GPGHKHPHBCB = base.PHNMLJJBKDC(this.ScreenClearShader);
	}

	// Token: 0x060028EA RID: 10474 RVA: 0x00120D4D File Offset: 0x0011EF4D
	protected void OnDisable()
	{
		if (this.EBNPJEFPGNK)
		{
			UnityEngine.Object.DestroyImmediate(this.EBNPJEFPGNK);
		}
		if (this.GPGHKHPHBCB)
		{
			UnityEngine.Object.DestroyImmediate(this.GPGHKHPHBCB);
		}
	}

	// Token: 0x0400053E RID: 1342
	public Shader GodRayShader;

	// Token: 0x0400053F RID: 1343
	public Shader ScreenClearShader;

	// Token: 0x04000540 RID: 1344
	public TOD_Rays.LOCNIALGIBA Resolution = TOD_Rays.LOCNIALGIBA.Normal;

	// Token: 0x04000541 RID: 1345
	public TOD_Rays.DMNGMLBOHGK BlendMode;

	// Token: 0x04000542 RID: 1346
	[AKOPBLFCONA(0f, 4f)]
	public int BlurIterations = 2;

	// Token: 0x04000543 RID: 1347
	[DOBCLPBCHFP(0f)]
	public float BlurRadius = 2f;

	// Token: 0x04000544 RID: 1348
	[DOBCLPBCHFP(0f)]
	public float Intensity = 1f;

	// Token: 0x04000545 RID: 1349
	[DOBCLPBCHFP(0f)]
	public float MaxRadius = 0.5f;

	// Token: 0x04000546 RID: 1350
	public bool UseDepthTexture = true;

	// Token: 0x04000547 RID: 1351
	private Material EBNPJEFPGNK;

	// Token: 0x04000548 RID: 1352
	private Material GPGHKHPHBCB;

	// Token: 0x04000549 RID: 1353
	private const int NPLDAGBIBIN = 2;

	// Token: 0x0400054A RID: 1354
	private const int HNMEFBDFPGC = 3;

	// Token: 0x0400054B RID: 1355
	private const int MHOCPGFCPMB = 1;

	// Token: 0x0400054C RID: 1356
	private const int PLLJADLMMBO = 0;

	// Token: 0x0400054D RID: 1357
	private const int AOGMBCLELNI = 4;

	// Token: 0x020000DC RID: 220
	public enum LOCNIALGIBA
	{
		// Token: 0x0400054F RID: 1359
		Low,
		// Token: 0x04000550 RID: 1360
		Normal,
		// Token: 0x04000551 RID: 1361
		High
	}

	// Token: 0x020000DD RID: 221
	public enum DMNGMLBOHGK
	{
		// Token: 0x04000553 RID: 1363
		Screen,
		// Token: 0x04000554 RID: 1364
		Add
	}
}
