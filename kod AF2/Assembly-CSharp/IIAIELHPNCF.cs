using System;
using UnityEngine;
using UnityEngine.PostProcessing;
using UnityEngine.Rendering;

// Token: 0x0200052A RID: 1322
public sealed class IIAIELHPNCF : AJIEADKHGJM<ScreenSpaceReflectionModel>
{
	// Token: 0x0601186F RID: 71791 RVA: 0x007D415C File Offset: 0x007D235C
	public void DNHJDHHPNGL(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.GOJNKFKPOKH();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 8;
		int num2 = this.AMCOGJHPPOC.GMOLEDNNPEH() / num;
		int num3 = this.AMCOGJHPPOC.GHMBALIHBOH() / num;
		float num4 = (float)this.AMCOGJHPPOC.NMEBEEHCALN;
		float num5 = (float)this.AMCOGJHPPOC.LHPBMEDMNDO();
		float num6 = num4 / 1937f;
		float num7 = num5 / 1536f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DFEMMOCHMDM("5");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.PhysicallyBased) ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 0 : 0);
		float value = num4 / (926f * Mathf.Tan(lbchlcgocod.fieldOfView / 264f * 62f * 929f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(1625f / (num4 * projectionMatrix[0]), 1022f / (num5 * projectionMatrix[0]), (710f - projectionMatrix[6]) / projectionMatrix[0], (1806f + projectionMatrix[7]) / projectionMatrix[4]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 1680f, 997f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1829f / num4, 556f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(1, new Vector4(num6, 884f, 1103f, num6));
		lhs.SetRow(1, new Vector4(1619f, num7, 544f, num7));
		lhs.SetRow(7, new Vector4(1621f, 1749f, 1860f, 1071f));
		lhs.SetRow(1, new Vector4(1369f, 1354f, 771f, 877f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.NNILENLPFDO() ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.ARGB32;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Point, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Default);
		for (int i = 1; i < 1; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -8), num3 >> (i & -21), 1, FilterMode.Point, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 1, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, fhlehncdjih, material, 6);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, phkdbefkdde, material, 5);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 1);
		for (int j = 0; j < 6; j += 0)
		{
			int nameID = this.NICOKIJMKGD[j - 0];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 4), num3 >> (num8 & -41), 0, FilterMode.Point, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1122f, 1222f, 903f, 591f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 381f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 0);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1154f, 1042f, 1302f, 757f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 0);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.PrepassNormalsSpec);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x06011870 RID: 71792 RVA: 0x007D481D File Offset: 0x007D2A1D
	public bool IOPILNONBKF()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.KFIJMIGOJEJ() && this.AMCOGJHPPOC.FBCBNOGGGOH();
	}

	// Token: 0x06011871 RID: 71793 RVA: 0x007D4849 File Offset: 0x007D2A49
	public bool IHEJAADCLIO()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.BMHMGNLEOED() || !this.AMCOGJHPPOC.HFIFOAPFKBG();
	}

	// Token: 0x06011872 RID: 71794 RVA: 0x007D4875 File Offset: 0x007D2A75
	public string NGNGNENEHBH()
	{
		return "RodParams not found!";
	}

	// Token: 0x06011873 RID: 71795 RVA: 0x007D487C File Offset: 0x007D2A7C
	public void GBLPBHKIMCC(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.CIMGEKFAAGC();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 5;
		int num2 = this.AMCOGJHPPOC.FOBPENGADNB() / num;
		int num3 = this.AMCOGJHPPOC.MMEMLJENMFF() / num;
		float num4 = (float)this.AMCOGJHPPOC.NMEBEEHCALN;
		float num5 = (float)this.AMCOGJHPPOC.LHPBMEDMNDO();
		float num6 = num4 / 699f;
		float num7 = num5 / 1847f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("knopje.wav");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 0 : 0);
		float value = num4 / (259f * Mathf.Tan(lbchlcgocod.fieldOfView / 225f * 1432f * 1779f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(965f / (num4 * projectionMatrix[0]), 975f / (num5 * projectionMatrix[0]), (1154f - projectionMatrix[3]) / projectionMatrix[0], (1379f + projectionMatrix[3]) / projectionMatrix[1]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 180f, 877f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(868f / num4, 582f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(1, new Vector4(num6, 1677f, 268f, num6));
		lhs.SetRow(1, new Vector4(666f, num7, 894f, num7));
		lhs.SetRow(0, new Vector4(555f, 569f, 1444f, 1145f));
		lhs.SetRow(8, new Vector4(463f, 659f, 71f, 1520f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? RenderTextureFormat.Depth : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Point, RenderTextureFormat.RGB565, RenderTextureReadWrite.Linear);
		for (int i = 1; i < 4; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -115), num3 >> (i & -4), 0, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 1, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 0, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, fhlehncdjih, material, 2);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, phkdbefkdde, material, 6);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[0], material, 5);
		for (int j = 0; j < 8; j += 0)
		{
			int nameID = this.NICOKIJMKGD[j - 0];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 39), num3 >> (num8 & 23), 1, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1610f, 799f, 472f, 220f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 747f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 0);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(144f, 714f, 974f, 1916f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[1], fnpebjaaafc, material, 4);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 1, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.PrepassLight);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x06011874 RID: 71796 RVA: 0x007C3969 File Offset: 0x007C1B69
	public CameraEvent JMBILFKPHLN()
	{
		return (CameraEvent)60;
	}

	// Token: 0x06011875 RID: 71797 RVA: 0x007D4F40 File Offset: 0x007D3140
	public void JCGMBPEBIJF(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.GNKPDBPBDBF();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 6;
		int num2 = this.AMCOGJHPPOC.GAIOLBJLPDL() / num;
		int num3 = this.AMCOGJHPPOC.KNKKIHDHBFD() / num;
		float num4 = (float)this.AMCOGJHPPOC.NMEBEEHCALN;
		float num5 = (float)this.AMCOGJHPPOC.KNKKIHDHBFD();
		float num6 = num4 / 966f;
		float num7 = num5 / 714f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("_Offsets");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 0 : 1);
		float value = num4 / (1435f * Mathf.Tan(lbchlcgocod.fieldOfView / 264f * 1097f * 96f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(651f / (num4 * projectionMatrix[1]), 1171f / (num5 * projectionMatrix[0]), (961f - projectionMatrix[2]) / projectionMatrix[1], (1837f + projectionMatrix[2]) / projectionMatrix[2]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 1208f, 1973f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1859f / num4, 614f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 708f, 1173f, num6));
		lhs.SetRow(1, new Vector4(1296f, num7, 1027f, num7));
		lhs.SetRow(1, new Vector4(1993f, 1579f, 624f, 838f));
		lhs.SetRow(1, new Vector4(368f, 1617f, 1714f, 1647f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.BLMBFAOCMNK() ? RenderTextureFormat.RGB565 : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 6; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -89), num3 >> (i & 112), 1, FilterMode.Point, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 1, this.LCHBDLDLLHO ? FilterMode.Point : FilterMode.Bilinear, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, fhlehncdjih, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, phkdbefkdde, material, 2);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 2);
		for (int j = 0; j < 8; j += 0)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & -113), num3 >> (num8 & -20), 0, FilterMode.Point, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(105f, 1241f, 1683f, 446f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 1986f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 0);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1617f, 20f, 860f, 1937f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 4);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, eopogikcljp, material, 0);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.PrepassLight);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x06011876 RID: 71798 RVA: 0x007D5601 File Offset: 0x007D3801
	public CameraEvent HNDAKMDADNC()
	{
		return (CameraEvent)(-82);
	}

	// Token: 0x06011877 RID: 71799 RVA: 0x007D5605 File Offset: 0x007D3805
	public string PBCDAEFPOAD()
	{
		return " on effect ";
	}

	// Token: 0x06011878 RID: 71800 RVA: 0x007D560C File Offset: 0x007D380C
	public bool EIKMLIHNIAF()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.MDGMGJOKFCL() && !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x06011879 RID: 71801 RVA: 0x007D5638 File Offset: 0x007D3838
	public void OMJOJPFCAIH(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.DOGPJECKDEG();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 3;
		int num2 = this.AMCOGJHPPOC.DHPPGHBNDEB() / num;
		int num3 = this.AMCOGJHPPOC.HJOKFIGACEC() / num;
		float num4 = (float)this.AMCOGJHPPOC.IBPMMKDPDEO();
		float num5 = (float)this.AMCOGJHPPOC.GGGEFNKEPDB();
		float num6 = num4 / 475f;
		float num7 = num5 / 1479f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JBLDPJMMJOL("req_prof");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 0 : 1);
		float value = num4 / (898f * Mathf.Tan(lbchlcgocod.fieldOfView / 1708f * 1114f * 362f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(439f / (num4 * projectionMatrix[1]), 821f / (num5 * projectionMatrix[3]), (914f - projectionMatrix[0]) / projectionMatrix[1], (830f + projectionMatrix[0]) / projectionMatrix[3]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 1040f, 136f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1761f / num4, 1473f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(1, new Vector4(num6, 823f, 1311f, num6));
		lhs.SetRow(1, new Vector4(1998f, num7, 1366f, num7));
		lhs.SetRow(7, new Vector4(1850f, 1603f, 48f, 1792f));
		lhs.SetRow(0, new Vector4(209f, 1127f, 1315f, 1231f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.PMBDOPMJOLD() ? RenderTextureFormat.ARGB2101010 : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 1, FilterMode.Point, RenderTextureFormat.ARGB4444, RenderTextureReadWrite.Linear);
		for (int i = 1; i < 7; i++)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -29), num3 >> (i & 61), 0, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 0, this.LCHBDLDLLHO ? FilterMode.Point : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, fhlehncdjih, material, 7);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, phkdbefkdde, material, 3);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[0], material, 3);
		for (int j = 1; j < 0; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 0];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 65), num3 >> (num8 & -30), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(775f, 644f, 683f, 57f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 864f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 1);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(189f, 80f, 1660f, 873f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[1], fnpebjaaafc, material, 1);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.CameraTarget);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x0601187A RID: 71802 RVA: 0x007D5CF9 File Offset: 0x007D3EF9
	public bool JJMCDBOFEOD()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.HDBIPEDBMCC() && this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x0601187B RID: 71803 RVA: 0x007D5D28 File Offset: 0x007D3F28
	public override void ADBAOPJBGHG()
	{
		this.NICOKIJMKGD[0] = Shader.PropertyToID("_ReflectionTexture0");
		this.NICOKIJMKGD[1] = Shader.PropertyToID("_ReflectionTexture1");
		this.NICOKIJMKGD[2] = Shader.PropertyToID("_ReflectionTexture2");
		this.NICOKIJMKGD[3] = Shader.PropertyToID("_ReflectionTexture3");
		this.NICOKIJMKGD[4] = Shader.PropertyToID("_ReflectionTexture4");
	}

	// Token: 0x0601187C RID: 71804 RVA: 0x007D5D8F File Offset: 0x007D3F8F
	public CameraEvent PLGAFKDFHDL()
	{
		return (CameraEvent)(-118);
	}

	// Token: 0x0601187D RID: 71805 RVA: 0x007D5D93 File Offset: 0x007D3F93
	public bool LLPDCLKLKEM()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.JLOKIEPCEGB() && this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x0601187E RID: 71806 RVA: 0x007D5DBF File Offset: 0x007D3FBF
	public bool GBGLDDNCIGM()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.KFIJMIGOJEJ() || this.AMCOGJHPPOC.ACEEFEFOCDF();
	}

	// Token: 0x0601187F RID: 71807 RVA: 0x007C8EEF File Offset: 0x007C70EF
	public CameraEvent DBCHOMGEHMO()
	{
		return (CameraEvent)(-31);
	}

	// Token: 0x06011880 RID: 71808 RVA: 0x007D5DEB File Offset: 0x007D3FEB
	public bool KAANMADDCEL()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.OFHANPNPEEJ() || !this.AMCOGJHPPOC.IPMGKDLKDHF();
	}

	// Token: 0x06011881 RID: 71809 RVA: 0x007D5E17 File Offset: 0x007D4017
	public string KIAHECBNJNH()
	{
		return "wpn_add/base";
	}

	// Token: 0x06011882 RID: 71810 RVA: 0x007ADF0A File Offset: 0x007AC10A
	public string GDABLFGNCNA()
	{
		return "fshop_ks2";
	}

	// Token: 0x06011883 RID: 71811 RVA: 0x007D5E20 File Offset: 0x007D4020
	public void BHMLILLBFLP()
	{
		this.NICOKIJMKGD[1] = Shader.PropertyToID("");
		this.NICOKIJMKGD[0] = Shader.PropertyToID("intensity");
		this.NICOKIJMKGD[5] = Shader.PropertyToID(" гр ");
		this.NICOKIJMKGD[2] = Shader.PropertyToID("langRefresh");
		this.NICOKIJMKGD[7] = Shader.PropertyToID("achive_text");
	}

	// Token: 0x06011884 RID: 71812 RVA: 0x007D5E88 File Offset: 0x007D4088
	public void FIHEJMJKCJM()
	{
		this.NICOKIJMKGD[1] = Shader.PropertyToID("Materials/DFMLambertSolidColor");
		this.NICOKIJMKGD[1] = Shader.PropertyToID("WeaponReady");
		this.NICOKIJMKGD[0] = Shader.PropertyToID("IdleStand");
		this.NICOKIJMKGD[4] = Shader.PropertyToID("_Offsets");
		this.NICOKIJMKGD[3] = Shader.PropertyToID("Weapon Stab");
	}

	// Token: 0x06011885 RID: 71813 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode OAPBLGOOHEK()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011886 RID: 71814 RVA: 0x007D5EF0 File Offset: 0x007D40F0
	public void BHEHCDDBKIE()
	{
		this.NICOKIJMKGD[0] = Shader.PropertyToID("Player");
		this.NICOKIJMKGD[0] = Shader.PropertyToID("post_19");
		this.NICOKIJMKGD[3] = Shader.PropertyToID("BowFire2");
		this.NICOKIJMKGD[0] = Shader.PropertyToID("from prefab");
		this.NICOKIJMKGD[1] = Shader.PropertyToID("RollerBladeGrindRoyale");
	}

	// Token: 0x06011887 RID: 71815 RVA: 0x007D5F57 File Offset: 0x007D4157
	public override string KPGFOFFHPOO()
	{
		return "Screen Space Reflection";
	}

	// Token: 0x06011888 RID: 71816 RVA: 0x007D5F5E File Offset: 0x007D415E
	public string AJMINCEJCAD()
	{
		return "Allows to detect Cheat Engine's speed hack (and maybe some other speed hack tools) usage.";
	}

	// Token: 0x06011889 RID: 71817 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode NMMAHDMDBEM()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0601188A RID: 71818 RVA: 0x007D5F65 File Offset: 0x007D4165
	public CameraEvent NMAGHGDHKHI()
	{
		return (CameraEvent)112;
	}

	// Token: 0x0601188B RID: 71819 RVA: 0x007D5F69 File Offset: 0x007D4169
	public bool NIPHEHICHLK()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.KFIJMIGOJEJ() || this.AMCOGJHPPOC.CHJAIAPCMDC();
	}

	// Token: 0x0601188C RID: 71820 RVA: 0x007D5F95 File Offset: 0x007D4195
	public bool BKFEHIMEKFA()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.OFHANPNPEEJ() && !this.AMCOGJHPPOC.CHJAIAPCMDC();
	}

	// Token: 0x0601188D RID: 71821 RVA: 0x007D5FC1 File Offset: 0x007D41C1
	public string AJHMPEGIBDI()
	{
		return "1 Hand Sword Jab ready strafe left";
	}

	// Token: 0x0601188E RID: 71822 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode BOJKMDJPICN()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0601188F RID: 71823 RVA: 0x007D5FC8 File Offset: 0x007D41C8
	public string LPDENGOCAOA()
	{
		return "t_obves";
	}

	// Token: 0x06011890 RID: 71824 RVA: 0x007D5FD0 File Offset: 0x007D41D0
	public void OILHFNOFNPD()
	{
		this.NICOKIJMKGD[0] = Shader.PropertyToID("SkateboardIdle");
		this.NICOKIJMKGD[1] = Shader.PropertyToID("invn_ver3");
		this.NICOKIJMKGD[6] = Shader.PropertyToID("No klev! shance=");
		this.NICOKIJMKGD[7] = Shader.PropertyToID("_AdaptTex");
		this.NICOKIJMKGD[8] = Shader.PropertyToID(" Категория ");
	}

	// Token: 0x06011891 RID: 71825 RVA: 0x007D6037 File Offset: 0x007D4237
	public string FJOMAAAJIGL()
	{
		return "_NeutralTonemapperParams1";
	}

	// Token: 0x06011892 RID: 71826 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode DDNBCODMMCP()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011893 RID: 71827 RVA: 0x007D603E File Offset: 0x007D423E
	public bool NNKFJGNCLOJ()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.HGFJIBBNAAN() && !this.AMCOGJHPPOC.POJLMOPEBLN();
	}

	// Token: 0x06011894 RID: 71828 RVA: 0x007D606C File Offset: 0x007D426C
	public void BFOBDCCJIBG()
	{
		this.NICOKIJMKGD[0] = Shader.PropertyToID("IdleDodgeLeft");
		this.NICOKIJMKGD[0] = Shader.PropertyToID("gi_um_mx");
		this.NICOKIJMKGD[5] = Shader.PropertyToID("_WaterLevel");
		this.NICOKIJMKGD[7] = Shader.PropertyToID("12");
		this.NICOKIJMKGD[4] = Shader.PropertyToID("error");
	}

	// Token: 0x06011895 RID: 71829 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode BHBFIDIJOGC()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011896 RID: 71830 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode OKIFBAHGNMI()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x06011897 RID: 71831 RVA: 0x007D5F65 File Offset: 0x007D4165
	public CameraEvent JIIIEHJPNHN()
	{
		return (CameraEvent)112;
	}

	// Token: 0x06011898 RID: 71832 RVA: 0x007D60D3 File Offset: 0x007D42D3
	public CameraEvent EAHFEGFJAHP()
	{
		return CameraEvent.AfterHaloAndLensFlares;
	}

	// Token: 0x06011899 RID: 71833 RVA: 0x007D60D8 File Offset: 0x007D42D8
	public void KFLFNGGBAEB()
	{
		this.NICOKIJMKGD[0] = Shader.PropertyToID("L");
		this.NICOKIJMKGD[1] = Shader.PropertyToID("");
		this.NICOKIJMKGD[6] = Shader.PropertyToID("StaffStand");
		this.NICOKIJMKGD[8] = Shader.PropertyToID("_Offsets");
		this.NICOKIJMKGD[2] = Shader.PropertyToID(" ");
	}

	// Token: 0x0601189A RID: 71834 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode APIPFLOFHAB()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x0601189B RID: 71835 RVA: 0x007D613F File Offset: 0x007D433F
	public string NJHALOAGMPG()
	{
		return "WeaponFire";
	}

	// Token: 0x0601189C RID: 71836 RVA: 0x007D6148 File Offset: 0x007D4348
	public void PIPLMJAOLGL(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.GFLKGIGCDBA();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 4;
		int num2 = this.AMCOGJHPPOC.LBAMMHHGCGL() / num;
		int num3 = this.AMCOGJHPPOC.HJOKFIGACEC() / num;
		float num4 = (float)this.AMCOGJHPPOC.GMOLEDNNPEH();
		float num5 = (float)this.AMCOGJHPPOC.MMEMLJENMFF();
		float num6 = num4 / 1645f;
		float num7 = num5 / 1606f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.EIJMKFHFKDG("LocationGui.getI.backLockImage.rectTransform is null");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.PhysicallyBased) ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 1 : 1);
		float value = num4 / (1080f * Mathf.Tan(lbchlcgocod.fieldOfView / 997f * 1100f * 1259f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(172f / (num4 * projectionMatrix[0]), 8f / (num5 * projectionMatrix[6]), (179f - projectionMatrix[1]) / projectionMatrix[1], (71f + projectionMatrix[3]) / projectionMatrix[5]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 1353f, 1264f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(943f / num4, 802f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 81f, 1332f, num6));
		lhs.SetRow(1, new Vector4(1836f, num7, 293f, num7));
		lhs.SetRow(1, new Vector4(1928f, 915f, 1898f, 1247f));
		lhs.SetRow(6, new Vector4(887f, 1096f, 910f, 416f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? RenderTextureFormat.Depth : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
		for (int i = 1; i < 1; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -6), num3 >> (i & 96), 1, FilterMode.Point, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 0, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, fhlehncdjih, material, 3);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, phkdbefkdde, material, 0);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[0], material, 3);
		for (int j = 1; j < 6; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 20), num3 >> (num8 & -72), 1, FilterMode.Point, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(719f, 596f, 1605f, 559f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 921f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 6);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(279f, 706f, 631f, 1369f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 4);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, eopogikcljp, material, 0);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.CameraTarget);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x0601189D RID: 71837 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode HLJFPBFGKBF()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x0601189E RID: 71838 RVA: 0x007D6809 File Offset: 0x007D4A09
	public bool KCMKDGLNNPM()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.KFIJMIGOJEJ() || this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x0601189F RID: 71839 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode OBCOPCFGDAF()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060118A0 RID: 71840 RVA: 0x007D6835 File Offset: 0x007D4A35
	public CameraEvent FPOMDHPNNLK()
	{
		return (CameraEvent)79;
	}

	// Token: 0x060118A1 RID: 71841 RVA: 0x007D6839 File Offset: 0x007D4A39
	public CameraEvent PLKGOMHPEGG()
	{
		return (CameraEvent)(-95);
	}

	// Token: 0x060118A2 RID: 71842 RVA: 0x000FAFB0 File Offset: 0x000F91B0
	public string CBGPLNLHBAM()
	{
		return "";
	}

	// Token: 0x060118A3 RID: 71843 RVA: 0x007D6840 File Offset: 0x007D4A40
	public void ILDNOHPNELN(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.COCGBMLPIPH();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 7;
		int num2 = this.AMCOGJHPPOC.IGHJHMGOGOO() / num;
		int num3 = this.AMCOGJHPPOC.ILLKFNCFGMP / num;
		float num4 = (float)this.AMCOGJHPPOC.LJJOEDIJPEM();
		float num5 = (float)this.AMCOGJHPPOC.MMEMLJENMFF();
		float num6 = num4 / 977f;
		float num7 = num5 / 1335f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.KPJNCIOMAGO("Assets/Weapons/wbootsBase.unity3d");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 0 : 1);
		float value = num4 / (306f * Mathf.Tan(lbchlcgocod.fieldOfView / 1559f * 1495f * 1670f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(685f / (num4 * projectionMatrix[0]), 1100f / (num5 * projectionMatrix[6]), (1989f - projectionMatrix[0]) / projectionMatrix[0], (827f + projectionMatrix[5]) / projectionMatrix[6]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 22f, 932f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(492f / num4, 8f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(1, new Vector4(num6, 341f, 1625f, num6));
		lhs.SetRow(1, new Vector4(1865f, num7, 658f, num7));
		lhs.SetRow(1, new Vector4(320f, 100f, 1242f, 629f));
		lhs.SetRow(2, new Vector4(913f, 863f, 449f, 1032f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.OEGOBDJNFOO() ? RenderTextureFormat.Shadowmap : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Point, RenderTextureFormat.ARGB1555, RenderTextureReadWrite.Default);
		for (int i = 1; i < 7; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & 99), num3 >> (i & -125), 1, FilterMode.Point, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 1, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, fhlehncdjih, material, 3);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, phkdbefkdde, material, 8);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[0], material, 6);
		for (int j = 1; j < 1; j += 0)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & -80), num3 >> (num8 & -102), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1450f, 827f, 1832f, 669f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 272f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 3);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1667f, 1625f, 1613f, 640f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[1], fnpebjaaafc, material, 4);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 1, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.None);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118A4 RID: 71844 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode CPMPEEDIPLL()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060118A5 RID: 71845 RVA: 0x007D6F01 File Offset: 0x007D5101
	public bool ICGMMGHLHLK()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.PBKNAKJBLDD() || this.AMCOGJHPPOC.CFABOAAPLPI;
	}

	// Token: 0x060118A6 RID: 71846 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode MBOFGOBKHPJ()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060118A7 RID: 71847 RVA: 0x007D6F2D File Offset: 0x007D512D
	public string KJCCEPOFGGO()
	{
		return "Projector reference not set.";
	}

	// Token: 0x060118A8 RID: 71848 RVA: 0x007D6F34 File Offset: 0x007D5134
	public override void DNELHGGBBOO(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.settings;
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 2;
		int num2 = this.AMCOGJHPPOC.NMEBEEHCALN / num;
		int num3 = this.AMCOGJHPPOC.ILLKFNCFGMP / num;
		float num4 = (float)this.AMCOGJHPPOC.NMEBEEHCALN;
		float num5 = (float)this.AMCOGJHPPOC.ILLKFNCFGMP;
		float num6 = num4 / 2f;
		float num7 = num5 / 2f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.AFONGIICOJG("Hidden/Post FX/Screen Space Reflection");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 1 : 0);
		float value = num4 / (-2f * Mathf.Tan(lbchlcgocod.fieldOfView / 180f * 3.1415927f * 0.5f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(-2f / (num4 * projectionMatrix[0]), -2f / (num5 * projectionMatrix[5]), (1f - projectionMatrix[2]) / projectionMatrix[0], (1f + projectionMatrix[6]) / projectionMatrix[5]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, -1f, 1f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1f / num4, 1f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 0f, 0f, num6));
		lhs.SetRow(1, new Vector4(0f, num7, 0f, num7));
		lhs.SetRow(2, new Vector4(0f, 0f, 1f, 0f));
		lhs.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.ARGB32;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 5; i++)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> i, num3 >> i, 0, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 0, this.LCHBDLDLLHO ? FilterMode.Point : FilterMode.Bilinear, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, fhlehncdjih, material, 6);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, phkdbefkdde, material, 5);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[0], material, 8);
		for (int j = 1; j < 5; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> num8, num3 >> num8, 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1f, 0f, 0f, 0f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 1f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 2);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(0f, 1f, 0f, 0f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 2);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 3);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.CameraTarget);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118A9 RID: 71849 RVA: 0x007D75F8 File Offset: 0x007D57F8
	public void KFIBDJHDJJP()
	{
		this.NICOKIJMKGD[1] = Shader.PropertyToID("SneakIdle");
		this.NICOKIJMKGD[1] = Shader.PropertyToID("torso");
		this.NICOKIJMKGD[2] = Shader.PropertyToID("Sound/Ambients/");
		this.NICOKIJMKGD[6] = Shader.PropertyToID("Trying to use the 'Arm' bend modifier on a leg.");
		this.NICOKIJMKGD[6] = Shader.PropertyToID("repa send");
	}

	// Token: 0x060118AA RID: 71850 RVA: 0x007D765F File Offset: 0x007D585F
	public string JOBIBHNOKPH()
	{
		return "Steam Overlay has been closed";
	}

	// Token: 0x060118AB RID: 71851 RVA: 0x007D7666 File Offset: 0x007D5866
	public string FFMADNBAECI()
	{
		return "IceHockey Shot Left";
	}

	// Token: 0x060118AC RID: 71852 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode PENMEIDGMKE()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060118AD RID: 71853 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode EDFAPKLAKLI()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060118AE RID: 71854 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode FFLADCCBOLM()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060118AF RID: 71855 RVA: 0x007D766D File Offset: 0x007D586D
	public CameraEvent DHKJAPGLHOD()
	{
		return (CameraEvent)(-62);
	}

	// Token: 0x060118B0 RID: 71856 RVA: 0x007D7671 File Offset: 0x007D5871
	public CameraEvent PMNIGNNODHN()
	{
		return (CameraEvent)64;
	}

	// Token: 0x060118B1 RID: 71857 RVA: 0x007D7675 File Offset: 0x007D5875
	public bool NHCLJOJLABJ()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.HDBIPEDBMCC() && this.AMCOGJHPPOC.DBAMKBECNIJ();
	}

	// Token: 0x060118B2 RID: 71858 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode BKADIFLEGCH()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060118B3 RID: 71859 RVA: 0x007D76A4 File Offset: 0x007D58A4
	public void NKKGHMHMOPH(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.MIBJNGOAOFD();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 2;
		int num2 = this.AMCOGJHPPOC.DHPPGHBNDEB() / num;
		int num3 = this.AMCOGJHPPOC.LPJJBJCIELA() / num;
		float num4 = (float)this.AMCOGJHPPOC.DJGCPIEOAFC();
		float num5 = (float)this.AMCOGJHPPOC.MMEMLJENMFF();
		float num6 = num4 / 1069f;
		float num7 = num5 / 283f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.PIPNAHLJKKD("{0:F2}, {1:F2}, {2:F2}, {3:F2}");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.PhysicallyBased) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 1 : 1);
		float value = num4 / (913f * Mathf.Tan(lbchlcgocod.fieldOfView / 1931f * 174f * 1453f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(95f / (num4 * projectionMatrix[1]), 618f / (num5 * projectionMatrix[6]), (1972f - projectionMatrix[8]) / projectionMatrix[1], (505f + projectionMatrix[6]) / projectionMatrix[3]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 1064f, 812f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1076f / num4, 1365f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(1, new Vector4(num6, 1143f, 1280f, num6));
		lhs.SetRow(0, new Vector4(1728f, num7, 1190f, num7));
		lhs.SetRow(4, new Vector4(1304f, 1842f, 13f, 595f));
		lhs.SetRow(1, new Vector4(883f, 1986f, 1816f, 775f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.OEGOBDJNFOO() ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		for (int i = 1; i < 3; i++)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & 91), num3 >> (i & 61), 1, FilterMode.Point, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 1, this.LCHBDLDLLHO ? FilterMode.Point : FilterMode.Bilinear, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, fhlehncdjih, material, 4);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, phkdbefkdde, material, 2);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[0], material, 7);
		for (int j = 0; j < 4; j += 0)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & -40), num3 >> (num8 & -32), 0, FilterMode.Point, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1917f, 246f, 1634f, 1840f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 341f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 0);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1879f, 459f, 1647f, 1287f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[1], fnpebjaaafc, material, 7);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 1, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.Depth);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118B4 RID: 71860 RVA: 0x007D7D68 File Offset: 0x007D5F68
	public void PPFGEACPLLA(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.KPDHPKHEDDM();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 4;
		int num2 = this.AMCOGJHPPOC.DJGCPIEOAFC() / num;
		int num3 = this.AMCOGJHPPOC.FHCDJOLMIMG() / num;
		float num4 = (float)this.AMCOGJHPPOC.CFDHOKHCPOJ();
		float num5 = (float)this.AMCOGJHPPOC.CICDECHCDBJ();
		float num6 = num4 / 1419f;
		float num7 = num5 / 878f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JJFELDJCAFA("help");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.PhysicallyBased) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 0 : 1);
		float value = num4 / (94f * Mathf.Tan(lbchlcgocod.fieldOfView / 328f * 804f * 419f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(22f / (num4 * projectionMatrix[0]), 61f / (num5 * projectionMatrix[3]), (1667f - projectionMatrix[2]) / projectionMatrix[0], (1245f + projectionMatrix[2]) / projectionMatrix[7]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 808f, 339f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(37f / num4, 572f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 1939f, 1701f, num6));
		lhs.SetRow(0, new Vector4(931f, num7, 1422f, num7));
		lhs.SetRow(8, new Vector4(1741f, 115f, 713f, 1124f));
		lhs.SetRow(6, new Vector4(1708f, 1884f, 74f, 1556f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.PIGJFLMCLBC() ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Linear);
		for (int i = 1; i < 1; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & 47), num3 >> (i & 75), 0, FilterMode.Point, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 0, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Bilinear, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 0, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, fhlehncdjih, material, 6);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, phkdbefkdde, material, 6);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 0);
		for (int j = 0; j < 0; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 0];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 21), num3 >> (num8 & -10), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1724f, 1578f, 1340f, 594f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 882f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 1);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(534f, 1427f, 407f, 420f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 0);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 5);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, eopogikcljp, material, 0);
		ECKPLMDEJFD.Blit(eopogikcljp, (BuiltinRenderTextureType)6);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118B5 RID: 71861 RVA: 0x007D842C File Offset: 0x007D662C
	public void LBKOIJKMCOL()
	{
		this.NICOKIJMKGD[0] = Shader.PropertyToID("_Vignette_Mask");
		this.NICOKIJMKGD[0] = Shader.PropertyToID("inv_pcs1");
		this.NICOKIJMKGD[0] = Shader.PropertyToID("_MiddleGrey");
		this.NICOKIJMKGD[0] = Shader.PropertyToID("Idle Meditate");
		this.NICOKIJMKGD[1] = Shader.PropertyToID("MENU.WAV");
	}

	// Token: 0x060118B6 RID: 71862 RVA: 0x007D8493 File Offset: 0x007D6693
	public bool MJPDFPDEDHN()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.LEIJCKEIMGH() && !this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x060118B7 RID: 71863 RVA: 0x007D84BF File Offset: 0x007D66BF
	public CameraEvent FAFMJNHLGFP()
	{
		return (CameraEvent)(-7);
	}

	// Token: 0x060118B8 RID: 71864 RVA: 0x007D84C3 File Offset: 0x007D66C3
	public string OHADIAIBGPJ()
	{
		return "z";
	}

	// Token: 0x060118B9 RID: 71865 RVA: 0x007D84CA File Offset: 0x007D66CA
	public CameraEvent FJCOKAFMCBC()
	{
		return (CameraEvent)50;
	}

	// Token: 0x060118BA RID: 71866 RVA: 0x007D84D0 File Offset: 0x007D66D0
	public void NNCODKCEPFA(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.MOFBKKKFMGJ();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 0;
		int num2 = this.AMCOGJHPPOC.CFDHOKHCPOJ() / num;
		int num3 = this.AMCOGJHPPOC.HJOKFIGACEC() / num;
		float num4 = (float)this.AMCOGJHPPOC.OJNDCCHLMNK();
		float num5 = (float)this.AMCOGJHPPOC.GHMBALIHBOH();
		float num6 = num4 / 807f;
		float num7 = num5 / 1403f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JBLDPJMMJOL("FBBIK is null. Will not update the InteractionSystem");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 0 : 1);
		float value = num4 / (473f * Mathf.Tan(lbchlcgocod.fieldOfView / 1658f * 1319f * 982f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(747f / (num4 * projectionMatrix[1]), 1590f / (num5 * projectionMatrix[2]), (904f - projectionMatrix[1]) / projectionMatrix[0], (1606f + projectionMatrix[7]) / projectionMatrix[5]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 858f, 783f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1374f / num4, 1265f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(1, new Vector4(num6, 358f, 117f, num6));
		lhs.SetRow(1, new Vector4(609f, num7, 56f, num7));
		lhs.SetRow(5, new Vector4(124f, 315f, 27f, 1375f));
		lhs.SetRow(6, new Vector4(1152f, 1613f, 1232f, 1179f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.NNILENLPFDO() ? RenderTextureFormat.Default : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.Default, RenderTextureReadWrite.Default);
		for (int i = 0; i < 1; i++)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -40), num3 >> (i & 103), 0, FilterMode.Point, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 1, this.LCHBDLDLLHO ? FilterMode.Point : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, fhlehncdjih, material, 5);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, phkdbefkdde, material, 7);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 6);
		for (int j = 1; j < 6; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 0];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & -81), num3 >> (num8 & -64), 1, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1295f, 952f, 234f, 1726f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 107f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 3);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(339f, 262f, 1210f, 536f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 1);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 5);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, eopogikcljp, material, 0);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.DepthNormals);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118BB RID: 71867 RVA: 0x007D8B94 File Offset: 0x007D6D94
	public void CGABEACDJCB(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.LIKDNAJFKMN();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 3;
		int num2 = this.AMCOGJHPPOC.GAIOLBJLPDL() / num;
		int num3 = this.AMCOGJHPPOC.MMEMLJENMFF() / num;
		float num4 = (float)this.AMCOGJHPPOC.DJGCPIEOAFC();
		float num5 = (float)this.AMCOGJHPPOC.KNKKIHDHBFD();
		float num6 = num4 / 1472f;
		float num7 = num5 / 2f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.HPAJGFGNMOH("Zombie");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 1 : 1);
		float value = num4 / (130f * Mathf.Tan(lbchlcgocod.fieldOfView / 1074f * 244f * 951f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(412f / (num4 * projectionMatrix[0]), 501f / (num5 * projectionMatrix[6]), (1531f - projectionMatrix[3]) / projectionMatrix[0], (290f + projectionMatrix[1]) / projectionMatrix[5]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 927f, 679f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(280f / num4, 260f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 941f, 13f, num6));
		lhs.SetRow(0, new Vector4(925f, num7, 479f, num7));
		lhs.SetRow(0, new Vector4(711f, 1730f, 1720f, 761f));
		lhs.SetRow(6, new Vector4(1746f, 432f, 616f, 730f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.PIGJFLMCLBC() ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.ARGB32;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.Default, RenderTextureReadWrite.Default);
		for (int i = 0; i < 6; i++)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & 11), num3 >> (i & -15), 1, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 0, this.LCHBDLDLLHO ? FilterMode.Point : FilterMode.Bilinear, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, fhlehncdjih, material, 7);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, nomalfceeba, material, 1);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, phkdbefkdde, material, 3);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[0], material, 0);
		for (int j = 0; j < 0; j += 0)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 86), num3 >> (num8 & 70), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1450f, 1230f, 563f, 947f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 909f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 1);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(512f, 370f, 139f, 1008f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[1], fnpebjaaafc, material, 8);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CurrentActive, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.Depth);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118BC RID: 71868 RVA: 0x007D9255 File Offset: 0x007D7455
	public string OEBDEKFJPKP()
	{
		return "12";
	}

	// Token: 0x060118BD RID: 71869 RVA: 0x007C237E File Offset: 0x007C057E
	public string ECGAAMPPFOO()
	{
		return "https://www.youtube.com/watch?v=eP9-zycoHLk";
	}

	// Token: 0x060118BE RID: 71870 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode PNCFJENEMDP()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060118BF RID: 71871 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode KMGGJCEPOIB()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060118C0 RID: 71872 RVA: 0x007D925C File Offset: 0x007D745C
	public CameraEvent PFOLPOIPBDJ()
	{
		return (CameraEvent)114;
	}

	// Token: 0x060118C1 RID: 71873 RVA: 0x007D9260 File Offset: 0x007D7460
	public bool AMGEDEPHDKI()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.PJKIDHFNEKH() || !this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x060118C2 RID: 71874 RVA: 0x007D928C File Offset: 0x007D748C
	public CameraEvent EGANGGJGGCE()
	{
		return (CameraEvent)87;
	}

	// Token: 0x060118C3 RID: 71875 RVA: 0x007D9290 File Offset: 0x007D7490
	public string DEKFHHKFFAM()
	{
		return "Ошибка";
	}

	// Token: 0x060118C4 RID: 71876 RVA: 0x007D9297 File Offset: 0x007D7497
	public bool DHAFPAMGDLM()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.HDBIPEDBMCC() || this.AMCOGJHPPOC.HALNOLGLEOJ();
	}

	// Token: 0x060118C5 RID: 71877 RVA: 0x007D92C3 File Offset: 0x007D74C3
	public CameraEvent BLONPEPAPFI()
	{
		return (CameraEvent)(-105);
	}

	// Token: 0x060118C6 RID: 71878 RVA: 0x007D92C7 File Offset: 0x007D74C7
	public CameraEvent MAKFOJJKJPD()
	{
		return (CameraEvent)(-30);
	}

	// Token: 0x060118C7 RID: 71879 RVA: 0x007D92CB File Offset: 0x007D74CB
	public CameraEvent AHEKDHKMNPP()
	{
		return (CameraEvent)(-48);
	}

	// Token: 0x060118C8 RID: 71880 RVA: 0x007D92CF File Offset: 0x007D74CF
	public bool DCPAEFLBLIB()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.KOIKCDLDJPD() && !this.AMCOGJHPPOC.HKJHMGJGNHJ();
	}

	// Token: 0x060118C9 RID: 71881 RVA: 0x007D92FB File Offset: 0x007D74FB
	public bool EFOGKBEBNHC()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.OFHANPNPEEJ() || !this.AMCOGJHPPOC.ANFINECKHNH();
	}

	// Token: 0x060118CA RID: 71882 RVA: 0x007D9327 File Offset: 0x007D7527
	public bool AOGEEGMGAJJ()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.GLJKDPBAPKJ || this.AMCOGJHPPOC.ODNAHJKPHKA();
	}

	// Token: 0x060118CB RID: 71883 RVA: 0x007D9354 File Offset: 0x007D7554
	public void OLFKBDFBFEM(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.GLHDFEIPFBL();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 4;
		int num2 = this.AMCOGJHPPOC.NMCCGCOKKFA() / num;
		int num3 = this.AMCOGJHPPOC.KNKKIHDHBFD() / num;
		float num4 = (float)this.AMCOGJHPPOC.LJJOEDIJPEM();
		float num5 = (float)this.AMCOGJHPPOC.GGGEFNKEPDB();
		float num6 = num4 / 1629f;
		float num7 = num5 / 87f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.BDHEBJJGFGB("FactoryTempTexture");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.PhysicallyBased) ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 1 : 0);
		float value = num4 / (486f * Mathf.Tan(lbchlcgocod.fieldOfView / 1729f * 82f * 171f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(1609f / (num4 * projectionMatrix[1]), 1792f / (num5 * projectionMatrix[5]), (781f - projectionMatrix[5]) / projectionMatrix[0], (1813f + projectionMatrix[4]) / projectionMatrix[3]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 1257f, 499f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1524f / num4, 570f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(1, new Vector4(num6, 824f, 496f, num6));
		lhs.SetRow(0, new Vector4(39f, num7, 249f, num7));
		lhs.SetRow(7, new Vector4(508f, 1737f, 1053f, 1690f));
		lhs.SetRow(8, new Vector4(834f, 874f, 220f, 11f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.BACMPNMDHBL() ? RenderTextureFormat.ARGB1555 : RenderTextureFormat.ARGB32;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 7; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & 123), num3 >> (i & 87), 0, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 1, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, fhlehncdjih, material, 8);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, nomalfceeba, material, 1);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, phkdbefkdde, material, 3);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 3);
		for (int j = 0; j < 8; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 75), num3 >> (num8 & 7), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(952f, 1608f, 343f, 1414f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 1792f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 5);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(590f, 933f, 1316f, 1751f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[1], fnpebjaaafc, material, 1);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 1, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, eopogikcljp, material, 0);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.DepthNormals);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118CC RID: 71884 RVA: 0x007D9A18 File Offset: 0x007D7C18
	public void BMPEMCPFPEF(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.MFDOHMDNEGK();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 3;
		int num2 = this.AMCOGJHPPOC.DHPPGHBNDEB() / num;
		int num3 = this.AMCOGJHPPOC.LPJJBJCIELA() / num;
		float num4 = (float)this.AMCOGJHPPOC.DJGCPIEOAFC();
		float num5 = (float)this.AMCOGJHPPOC.NIEGJHLHEEB();
		float num6 = num4 / 507f;
		float num7 = num5 / 97f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NADANHHBOLO("DrawDistance");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.PhysicallyBased) ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 1 : 0);
		float value = num4 / (1409f * Mathf.Tan(lbchlcgocod.fieldOfView / 1024f * 882f * 488f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(772f / (num4 * projectionMatrix[1]), 1348f / (num5 * projectionMatrix[3]), (435f - projectionMatrix[5]) / projectionMatrix[1], (1120f + projectionMatrix[8]) / projectionMatrix[8]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 33f, 518f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(883f / num4, 772f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 765f, 1388f, num6));
		lhs.SetRow(0, new Vector4(1953f, num7, 1163f, num7));
		lhs.SetRow(2, new Vector4(873f, 1804f, 1696f, 1511f));
		lhs.SetRow(6, new Vector4(579f, 1996f, 532f, 47f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.BLMBFAOCMNK() ? RenderTextureFormat.Shadowmap : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 6; i++)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -36), num3 >> (i & 4), 1, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 0, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Bilinear, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, fhlehncdjih, material, 7);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, nomalfceeba, material, 1);
		ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, phkdbefkdde, material, 7);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 4);
		for (int j = 0; j < 0; j += 0)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & -53), num3 >> (num8 & 95), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(893f, 1273f, 935f, 1365f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 1834f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 0);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(410f, 248f, 792f, 1751f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 8);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 0);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.Depth);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118CD RID: 71885 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode OLEMGDEFKND()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060118CE RID: 71886 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public override DepthTextureMode PPAJFNGHBCF()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060118CF RID: 71887 RVA: 0x007DA0D9 File Offset: 0x007D82D9
	public string HDPIBOJKMIL()
	{
		return "wpn_rod4";
	}

	// Token: 0x060118D0 RID: 71888 RVA: 0x007DA0E0 File Offset: 0x007D82E0
	public string KINMEMMPMGH()
	{
		return "n";
	}

	// Token: 0x060118D1 RID: 71889 RVA: 0x007DA0E7 File Offset: 0x007D82E7
	public CameraEvent MMKNKPBLCDG()
	{
		return (CameraEvent)(-112);
	}

	// Token: 0x060118D2 RID: 71890 RVA: 0x007DA0EC File Offset: 0x007D82EC
	public void NCPAMFNKHIO(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.settings;
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 5;
		int num2 = this.AMCOGJHPPOC.DJGCPIEOAFC() / num;
		int num3 = this.AMCOGJHPPOC.LHPBMEDMNDO() / num;
		float num4 = (float)this.AMCOGJHPPOC.OJNDCCHLMNK();
		float num5 = (float)this.AMCOGJHPPOC.LKLNPJICOHH();
		float num6 = num4 / 951f;
		float num7 = num5 / 927f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.OAJBECLLIEP(" is null.");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 1 : 1);
		float value = num4 / (974f * Mathf.Tan(lbchlcgocod.fieldOfView / 207f * 127f * 597f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(1323f / (num4 * projectionMatrix[1]), 982f / (num5 * projectionMatrix[8]), (1919f - projectionMatrix[2]) / projectionMatrix[1], (1327f + projectionMatrix[7]) / projectionMatrix[2]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 1746f, 389f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1667f / num4, 1174f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 716f, 778f, num6));
		lhs.SetRow(1, new Vector4(219f, num7, 1487f, num7));
		lhs.SetRow(1, new Vector4(922f, 1629f, 299f, 1487f));
		lhs.SetRow(6, new Vector4(194f, 663f, 295f, 1858f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.MAIODKMOICL ? RenderTextureFormat.Default : RenderTextureFormat.ARGB32;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Point, RenderTextureFormat.Shadowmap, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 5; i++)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -108), num3 >> (i & 44), 0, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 1, this.LCHBDLDLLHO ? FilterMode.Point : FilterMode.Bilinear, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, fhlehncdjih, material, 2);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, phkdbefkdde, material, 3);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[0], material, 1);
		for (int j = 0; j < 5; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 4), num3 >> (num8 & 115), 0, FilterMode.Point, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1566f, 1337f, 789f, 1703f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 1881f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 0);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(941f, 497f, 749f, 278f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 1);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, eopogikcljp, material, 0);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.DepthNormals);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x170003D1 RID: 977
	// (get) Token: 0x060118D3 RID: 71891 RVA: 0x007DA7AD File Offset: 0x007D89AD
	public override bool NLFEIOCKHKA
	{
		get
		{
			return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.GLJKDPBAPKJ && !this.AMCOGJHPPOC.CFABOAAPLPI;
		}
	}

	// Token: 0x060118D4 RID: 71892 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode LOENKJGKMHB()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060118D5 RID: 71893 RVA: 0x007DA7D9 File Offset: 0x007D89D9
	public string LNKLECNALNK()
	{
		return "Wall Run Left";
	}

	// Token: 0x060118D6 RID: 71894 RVA: 0x007DA7E0 File Offset: 0x007D89E0
	public void KLPHHNMKNGN()
	{
		this.NICOKIJMKGD[0] = Shader.PropertyToID("Quest loaded error");
		this.NICOKIJMKGD[1] = Shader.PropertyToID("OSX");
		this.NICOKIJMKGD[6] = Shader.PropertyToID("3");
		this.NICOKIJMKGD[0] = Shader.PropertyToID("WeaponInstant");
		this.NICOKIJMKGD[2] = Shader.PropertyToID("Speed Hack Detector");
	}

	// Token: 0x060118D7 RID: 71895 RVA: 0x007DA848 File Offset: 0x007D8A48
	public void IPEEFAIFAFI(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.GOJNKFKPOKH();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 3;
		int num2 = this.AMCOGJHPPOC.OJNDCCHLMNK() / num;
		int num3 = this.AMCOGJHPPOC.FHCDJOLMIMG() / num;
		float num4 = (float)this.AMCOGJHPPOC.DHPPGHBNDEB();
		float num5 = (float)this.AMCOGJHPPOC.GGGEFNKEPDB();
		float num6 = num4 / 1733f;
		float num7 = num5 / 1795f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.DGOMGBDLAFP(":");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.PhysicallyBased) ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 1 : 0);
		float value = num4 / (1738f * Mathf.Tan(lbchlcgocod.fieldOfView / 1279f * 955f * 1782f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(6f / (num4 * projectionMatrix[0]), 1698f / (num5 * projectionMatrix[4]), (1183f - projectionMatrix[2]) / projectionMatrix[0], (1872f + projectionMatrix[7]) / projectionMatrix[6]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 997f, 897f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1574f / num4, 865f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 1958f, 577f, num6));
		lhs.SetRow(1, new Vector4(1000f, num7, 1409f, num7));
		lhs.SetRow(3, new Vector4(1838f, 1685f, 792f, 1562f));
		lhs.SetRow(8, new Vector4(885f, 1642f, 395f, 200f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.HCHNHOFPIFK() ? RenderTextureFormat.Depth : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 1, FilterMode.Point, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Default);
		for (int i = 1; i < 8; i++)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -34), num3 >> (i & -1), 1, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 1, this.LCHBDLDLLHO ? FilterMode.Point : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CurrentActive, fhlehncdjih, material, 6);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, phkdbefkdde, material, 4);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 6);
		for (int j = 1; j < 6; j += 0)
		{
			int nameID = this.NICOKIJMKGD[j - 0];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 61), num3 >> (num8 & 50), 0, FilterMode.Point, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(119f, 1561f, 1559f, 485f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 160f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 7);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(844f, 513f, 149f, 30f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 8);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.CameraTarget);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118D8 RID: 71896 RVA: 0x007DAF09 File Offset: 0x007D9109
	public CameraEvent OCMHLBBOGMG()
	{
		return (CameraEvent)(-2);
	}

	// Token: 0x060118D9 RID: 71897 RVA: 0x007DAF0D File Offset: 0x007D910D
	public bool HNGPGKMMDCO()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.PBKNAKJBLDD() || this.AMCOGJHPPOC.DBAMKBECNIJ();
	}

	// Token: 0x060118DA RID: 71898 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode MHPHEDDKCIP()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060118DB RID: 71899 RVA: 0x007DAF3C File Offset: 0x007D913C
	public void HHOJJINMMMA()
	{
		this.NICOKIJMKGD[0] = Shader.PropertyToID("\n");
		this.NICOKIJMKGD[0] = Shader.PropertyToID("LHandWeight");
		this.NICOKIJMKGD[7] = Shader.PropertyToID("{0}/{1}");
		this.NICOKIJMKGD[7] = Shader.PropertyToID("\n");
		this.NICOKIJMKGD[7] = Shader.PropertyToID("KatanaReady");
	}

	// Token: 0x060118DC RID: 71900 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode JPPBBACPJAB()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060118DD RID: 71901 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode GOMAGPIHEFP()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060118DE RID: 71902 RVA: 0x007DAFA3 File Offset: 0x007D91A3
	public bool JFPMPCOCNHP()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.KFIJMIGOJEJ() && !this.AMCOGJHPPOC.CFABOAAPLPI;
	}

	// Token: 0x060118DF RID: 71903 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode EAHLBMKBMGK()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060118E0 RID: 71904 RVA: 0x007DAFCF File Offset: 0x007D91CF
	public string HJODOPFHGAL()
	{
		return "val=";
	}

	// Token: 0x060118E1 RID: 71905 RVA: 0x007DAFD8 File Offset: 0x007D91D8
	public void PPHOONMGPMD(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.FHADBNFJCDL();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 3;
		int num2 = this.AMCOGJHPPOC.FOBPENGADNB() / num;
		int num3 = this.AMCOGJHPPOC.HJOKFIGACEC() / num;
		float num4 = (float)this.AMCOGJHPPOC.GAIOLBJLPDL();
		float num5 = (float)this.AMCOGJHPPOC.GHMBALIHBOH();
		float num6 = num4 / 152f;
		float num7 = num5 / 1602f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NLFMCBBJHBD("Handstand");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.PhysicallyBased) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 0 : 1);
		float value = num4 / (1039f * Mathf.Tan(lbchlcgocod.fieldOfView / 348f * 1060f * 649f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(758f / (num4 * projectionMatrix[0]), 624f / (num5 * projectionMatrix[3]), (1293f - projectionMatrix[7]) / projectionMatrix[0], (57f + projectionMatrix[4]) / projectionMatrix[3]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 1600f, 1520f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1081f / num4, 142f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 425f, 1059f, num6));
		lhs.SetRow(1, new Vector4(1463f, num7, 1752f, num7));
		lhs.SetRow(2, new Vector4(679f, 483f, 627f, 1107f));
		lhs.SetRow(1, new Vector4(401f, 1243f, 950f, 1329f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.JFIIMCOAHFG() ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Point, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Default);
		for (int i = 1; i < 2; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & 110), num3 >> (i & -5), 0, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 0, this.LCHBDLDLLHO ? FilterMode.Point : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, fhlehncdjih, material, 5);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CurrentActive, phkdbefkdde, material, 8);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 3);
		for (int j = 1; j < 3; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 13), num3 >> (num8 & 73), 1, FilterMode.Point, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(427f, 127f, 686f, 1275f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 1824f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 4);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1113f, 731f, 343f, 604f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 8);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 1, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.CurrentActive);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118E2 RID: 71906 RVA: 0x000EADB7 File Offset: 0x000E8FB7
	public DepthTextureMode JNEGAGOCDPG()
	{
		return DepthTextureMode.Depth;
	}

	// Token: 0x060118E3 RID: 71907 RVA: 0x007DB699 File Offset: 0x007D9899
	public string JJHBJOOJBIM()
	{
		return "Giant2HandSlamIdle";
	}

	// Token: 0x060118E4 RID: 71908 RVA: 0x007DB6A0 File Offset: 0x007D98A0
	public void KMLMGMCKMGP(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.FHADBNFJCDL();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 8;
		int num2 = this.AMCOGJHPPOC.IGHJHMGOGOO() / num;
		int num3 = this.AMCOGJHPPOC.KNKKIHDHBFD() / num;
		float num4 = (float)this.AMCOGJHPPOC.GAIOLBJLPDL();
		float num5 = (float)this.AMCOGJHPPOC.CICDECHCDBJ();
		float num6 = num4 / 274f;
		float num7 = num5 / 248f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JKBKMPBBGBA("Soccer Walk");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 0 : 0);
		float value = num4 / (1210f * Mathf.Tan(lbchlcgocod.fieldOfView / 1915f * 543f * 1778f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(584f / (num4 * projectionMatrix[1]), 1720f / (num5 * projectionMatrix[5]), (1577f - projectionMatrix[4]) / projectionMatrix[0], (775f + projectionMatrix[1]) / projectionMatrix[1]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 476f, 1409f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(197f / num4, 1811f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 438f, 825f, num6));
		lhs.SetRow(0, new Vector4(1755f, num7, 1085f, num7));
		lhs.SetRow(6, new Vector4(1606f, 1501f, 749f, 992f));
		lhs.SetRow(6, new Vector4(565f, 1969f, 1513f, 985f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.BACMPNMDHBL() ? RenderTextureFormat.Shadowmap : RenderTextureFormat.ARGB32;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.Shadowmap, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 2; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & 125), num3 >> (i & 125), 0, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 0, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.None, fhlehncdjih, material, 6);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CurrentActive, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, phkdbefkdde, material, 4);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[0], material, 0);
		for (int j = 0; j < 4; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 0];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 33), num3 >> (num8 & 49), 1, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1678f, 1726f, 219f, 75f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 979f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 3);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1934f, 549f, 183f, 1407f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 3);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, eopogikcljp, material, 0);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.PrepassLight);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118E5 RID: 71909 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode APHNKCHFIEM()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060118E6 RID: 71910 RVA: 0x007DBD61 File Offset: 0x007D9F61
	public string FNLAFMAJIDO()
	{
		return "Grounding layers are set to nothing. Please add a ground layer.";
	}

	// Token: 0x060118E7 RID: 71911 RVA: 0x007DBD68 File Offset: 0x007D9F68
	public CameraEvent MOIIJKKDJFO()
	{
		return (CameraEvent)81;
	}

	// Token: 0x060118E8 RID: 71912 RVA: 0x007DBD6C File Offset: 0x007D9F6C
	public CameraEvent JGEPFCMOBOO()
	{
		return CameraEvent.AfterForwardAlpha;
	}

	// Token: 0x060118E9 RID: 71913 RVA: 0x007DBD70 File Offset: 0x007D9F70
	public bool FOFBLGFDDAB()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.BMHMGNLEOED() && this.AMCOGJHPPOC.MLMGNHHAOHF();
	}

	// Token: 0x060118EA RID: 71914 RVA: 0x007DBD9C File Offset: 0x007D9F9C
	public void APEJEFJCKCL(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.GNKPDBPBDBF();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 7;
		int num2 = this.AMCOGJHPPOC.FOBPENGADNB() / num;
		int num3 = this.AMCOGJHPPOC.NIEGJHLHEEB() / num;
		float num4 = (float)this.AMCOGJHPPOC.IBPMMKDPDEO();
		float num5 = (float)this.AMCOGJHPPOC.CICDECHCDBJ();
		float num6 = num4 / 1724f;
		float num7 = num5 / 1369f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.GJOHODHDPDN("Hidden/Post FX/FXAA");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 1 : 0);
		float value = num4 / (1977f * Mathf.Tan(lbchlcgocod.fieldOfView / 1480f * 1259f * 1065f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(1922f / (num4 * projectionMatrix[0]), 1238f / (num5 * projectionMatrix[4]), (873f - projectionMatrix[7]) / projectionMatrix[1], (18f + projectionMatrix[2]) / projectionMatrix[0]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 515f, 1042f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(801f / num4, 1788f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 1199f, 1668f, num6));
		lhs.SetRow(1, new Vector4(1889f, num7, 617f, num7));
		lhs.SetRow(1, new Vector4(1706f, 1052f, 256f, 1183f));
		lhs.SetRow(1, new Vector4(1944f, 400f, 394f, 797f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.DLFNPFAGPFC() ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB1555, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 3; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & 13), num3 >> (i & 0), 1, FilterMode.Point, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 1, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Bilinear, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, fhlehncdjih, material, 2);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, phkdbefkdde, material, 4);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 2);
		for (int j = 1; j < 7; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 79), num3 >> (num8 & 98), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(577f, 497f, 1851f, 934f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 1523f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 8);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1691f, 587f, 611f, 1241f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 3);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 7);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.Depth);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118EB RID: 71915 RVA: 0x007DC45D File Offset: 0x007DA65D
	public CameraEvent GAMKHMOFHIA()
	{
		return (CameraEvent)(-40);
	}

	// Token: 0x060118EC RID: 71916 RVA: 0x007DC464 File Offset: 0x007DA664
	public void NJJFDKFNBCL()
	{
		this.NICOKIJMKGD[0] = Shader.PropertyToID("_SampleMip");
		this.NICOKIJMKGD[0] = Shader.PropertyToID(" rep.repa=");
		this.NICOKIJMKGD[2] = Shader.PropertyToID("");
		this.NICOKIJMKGD[2] = Shader.PropertyToID("{0}");
		this.NICOKIJMKGD[3] = Shader.PropertyToID("<color='#003000'>");
	}

	// Token: 0x060118ED RID: 71917 RVA: 0x007DC4CC File Offset: 0x007DA6CC
	public void CPIEBNMKKMB()
	{
		this.NICOKIJMKGD[1] = Shader.PropertyToID("");
		this.NICOKIJMKGD[0] = Shader.PropertyToID("RollerBladeBackFlip");
		this.NICOKIJMKGD[7] = Shader.PropertyToID("_FogColor2");
		this.NICOKIJMKGD[7] = Shader.PropertyToID("<color='#100000'>{0} {1}</color>");
		this.NICOKIJMKGD[6] = Shader.PropertyToID("CD");
	}

	// Token: 0x060118EE RID: 71918 RVA: 0x007DC533 File Offset: 0x007DA733
	public string BCPPJILOGKJ()
	{
		return "WorkerHammer2";
	}

	// Token: 0x060118EF RID: 71919 RVA: 0x007DC53A File Offset: 0x007DA73A
	public string PMHIIDBGJDG()
	{
		return "Flap_04.wav";
	}

	// Token: 0x060118F1 RID: 71921 RVA: 0x007DC564 File Offset: 0x007DA764
	public void MGJCCOCIONI(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.BJBDFGJMJAI();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 5;
		int num2 = this.AMCOGJHPPOC.DJGCPIEOAFC() / num;
		int num3 = this.AMCOGJHPPOC.NIEGJHLHEEB() / num;
		float num4 = (float)this.AMCOGJHPPOC.LBAMMHHGCGL();
		float num5 = (float)this.AMCOGJHPPOC.ILLKFNCFGMP;
		float num6 = num4 / 943f;
		float num7 = num5 / 1184f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JKBKMPBBGBA("wpn/");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.PhysicallyBased) ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 1 : 1);
		float value = num4 / (1312f * Mathf.Tan(lbchlcgocod.fieldOfView / 1553f * 1331f * 1441f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(205f / (num4 * projectionMatrix[1]), 1974f / (num5 * projectionMatrix[7]), (1024f - projectionMatrix[3]) / projectionMatrix[1], (1489f + projectionMatrix[5]) / projectionMatrix[7]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 663f, 855f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1772f / num4, 348f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 1923f, 1999f, num6));
		lhs.SetRow(1, new Vector4(297f, num7, 1645f, num7));
		lhs.SetRow(1, new Vector4(1186f, 1719f, 69f, 487f));
		lhs.SetRow(7, new Vector4(1834f, 296f, 883f, 104f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.PMBDOPMJOLD() ? RenderTextureFormat.Default : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Point, RenderTextureFormat.Shadowmap, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 0; i++)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -103), num3 >> (i & -93), 1, FilterMode.Point, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 0, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Bilinear, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, fhlehncdjih, material, 7);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, nomalfceeba, material, 1);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, phkdbefkdde, material, 8);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 6);
		for (int j = 1; j < 6; j += 0)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & -51), num3 >> (num8 & 7), 1, FilterMode.Point, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1242f, 29f, 1892f, 1457f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 1417f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 8);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(346f, 927f, 1145f, 107f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[1], fnpebjaaafc, material, 7);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, eopogikcljp, material, 0);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.PrepassNormalsSpec);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118F2 RID: 71922 RVA: 0x007DCC28 File Offset: 0x007DAE28
	public void FBODLJMLADA(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.EDEDLPBFDAI();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 6;
		int num2 = this.AMCOGJHPPOC.LJJOEDIJPEM() / num;
		int num3 = this.AMCOGJHPPOC.LKLNPJICOHH() / num;
		float num4 = (float)this.AMCOGJHPPOC.IBPMMKDPDEO();
		float num5 = (float)this.AMCOGJHPPOC.GHMBALIHBOH();
		float num6 = num4 / 1247f;
		float num7 = num5 / 1301f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.JNKAJCFJHIP("BowReady2");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 0 : 1);
		float value = num4 / (1411f * Mathf.Tan(lbchlcgocod.fieldOfView / 1485f * 1383f * 1121f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(471f / (num4 * projectionMatrix[0]), 1865f / (num5 * projectionMatrix[5]), (203f - projectionMatrix[5]) / projectionMatrix[1], (1872f + projectionMatrix[8]) / projectionMatrix[8]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 213f, 74f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1400f / num4, 1124f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(0, new Vector4(num6, 42f, 40f, num6));
		lhs.SetRow(1, new Vector4(611f, num7, 459f, num7));
		lhs.SetRow(3, new Vector4(33f, 1052f, 546f, 603f));
		lhs.SetRow(5, new Vector4(1944f, 1569f, 1942f, 1159f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.FPIAHOMIEJP() ? RenderTextureFormat.ARGB4444 : RenderTextureFormat.ARGB32;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 1, FilterMode.Point, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 4; i++)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & 32), num3 >> (i & -76), 1, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 0, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, fhlehncdjih, material, 4);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CurrentActive, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, phkdbefkdde, material, 5);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[0], material, 4);
		for (int j = 1; j < 3; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 119), num3 >> (num8 & -25), 1, FilterMode.Point, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(210f, 1220f, 1150f, 1148f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 476f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 5);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1801f, 714f, 125f, 1450f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 7);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[0], fnpebjaaafc, material, 1);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CurrentActive, eopogikcljp, material, 0);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.None);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118F3 RID: 71923 RVA: 0x007DD2E9 File Offset: 0x007DB4E9
	public CameraEvent KKCAOIBNKFI()
	{
		return (CameraEvent)(-79);
	}

	// Token: 0x060118F4 RID: 71924 RVA: 0x007DD2ED File Offset: 0x007DB4ED
	public string NMKIECJGKLK()
	{
		return "idlist";
	}

	// Token: 0x060118F5 RID: 71925 RVA: 0x007DD2F4 File Offset: 0x007DB4F4
	public bool FOFBPEDDNHC()
	{
		return !base.BBEPCCALAFC.enabled || !this.AMCOGJHPPOC.OFHANPNPEEJ() || this.AMCOGJHPPOC.AFIPEFLJBBM();
	}

	// Token: 0x060118F6 RID: 71926 RVA: 0x007DD320 File Offset: 0x007DB520
	public void KANFBOPPFLP(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.KJNONGCAMIN();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 3;
		int num2 = this.AMCOGJHPPOC.IBPMMKDPDEO() / num;
		int num3 = this.AMCOGJHPPOC.FHCDJOLMIMG() / num;
		float num4 = (float)this.AMCOGJHPPOC.IBPMMKDPDEO();
		float num5 = (float)this.AMCOGJHPPOC.HJOKFIGACEC();
		float num6 = num4 / 643f;
		float num7 = num5 / 1354f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.EIJMKFHFKDG("name");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.PhysicallyBased) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 1 : 1);
		float value = num4 / (1930f * Mathf.Tan(lbchlcgocod.fieldOfView / 170f * 820f * 1198f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(1012f / (num4 * projectionMatrix[0]), 1306f / (num5 * projectionMatrix[3]), (612f - projectionMatrix[0]) / projectionMatrix[0], (1772f + projectionMatrix[7]) / projectionMatrix[2]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 1471f, 1741f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(1104f / num4, 626f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(1, new Vector4(num6, 1782f, 1883f, num6));
		lhs.SetRow(0, new Vector4(939f, num7, 338f, num7));
		lhs.SetRow(7, new Vector4(45f, 24f, 135f, 1548f));
		lhs.SetRow(7, new Vector4(1589f, 781f, 1868f, 550f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.FPIAHOMIEJP() ? RenderTextureFormat.ARGB2101010 : RenderTextureFormat.ARGB32;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.Shadowmap, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 1; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -119), num3 >> (i & -38), 1, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 1, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 1, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, fhlehncdjih, material, 2);
		ECKPLMDEJFD.Blit((BuiltinRenderTextureType)6, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, phkdbefkdde, material, 5);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 4);
		for (int j = 0; j < 2; j += 0)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 115), num3 >> (num8 & 7), 1, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1919f, 948f, 329f, 412f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 1866f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 0);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(1957f, 1807f, 32f, 1655f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 6);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[1], fnpebjaaafc, material, 5);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Bilinear, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.CameraTarget, eopogikcljp, material, 1);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.PrepassLight);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118F7 RID: 71927 RVA: 0x007DD9E1 File Offset: 0x007DBBE1
	public bool KMFKAAOODGG()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.MDGMGJOKFCL() && !this.AMCOGJHPPOC.FBCBNOGGGOH();
	}

	// Token: 0x060118F8 RID: 71928 RVA: 0x007C2B44 File Offset: 0x007C0D44
	public CameraEvent GBOGBKBHEGJ()
	{
		return CameraEvent.BeforeImageEffects;
	}

	// Token: 0x060118F9 RID: 71929 RVA: 0x007DDA0D File Offset: 0x007DBC0D
	public bool GPNNCNJMGNF()
	{
		return base.BBEPCCALAFC.enabled && this.AMCOGJHPPOC.GNOBCFOKNME() && !this.AMCOGJHPPOC.MLJCADOONGI();
	}

	// Token: 0x060118FA RID: 71930 RVA: 0x007DDA39 File Offset: 0x007DBC39
	public string DENMLMEOOCG()
	{
		return "RollerBladeCrossoverRight";
	}

	// Token: 0x060118FB RID: 71931 RVA: 0x007DDA40 File Offset: 0x007DBC40
	public CameraEvent AGGFGEDHCMK()
	{
		return (CameraEvent)92;
	}

	// Token: 0x060118FC RID: 71932 RVA: 0x007DDA44 File Offset: 0x007DBC44
	public void GNLLIPFJGDB(CommandBuffer ECKPLMDEJFD)
	{
		ScreenSpaceReflectionModel.Settings settings = base.BBEPCCALAFC.BJBDFGJMJAI();
		Camera lbchlcgocod = this.AMCOGJHPPOC.LBCHLCGOCOD;
		int num = (settings.reflection.reflectionQuality == ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 1 : 7;
		int num2 = this.AMCOGJHPPOC.KJDPLLFIIBK() / num;
		int num3 = this.AMCOGJHPPOC.FHCDJOLMIMG() / num;
		float num4 = (float)this.AMCOGJHPPOC.DJGCPIEOAFC();
		float num5 = (float)this.AMCOGJHPPOC.MMEMLJENMFF();
		float num6 = num4 / 1126f;
		float num7 = num5 / 648f;
		Material material = this.AMCOGJHPPOC.DJHLKHLPAGA.NLFMCBBJHBD("WandStand");
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.HIMNAMHOBIP, settings.reflection.stepSize);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.MPCLELFCCBJ, (settings.reflection.blendType == ScreenSpaceReflectionModel.ILPOPNAKCDF.Additive) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.AEMLBPGPDOO, this.LCHBDLDLLHO ? 0 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.PCPJOKLKCJH, this.LEFDIHEPFAL ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.INPIDPPACDK, settings.reflection.reflectBackfaces ? 1 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.BMNKMEFMHKP, this.IEAFDBEPMHB ? 1 : 0);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.KMPLODOGLLD, settings.reflection.iterationCount);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.JGAMGJPDHAJ, 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.LMNNBPBDKBI, (settings.reflection.reflectionQuality != ScreenSpaceReflectionModel.EJGOCEANOJF.High) ? 0 : 1);
		material.SetInt(IIAIELHPNCF.OKAHOEKKJGO.CCBMKEBFNHF, this.HJOFAIPIKDH ? 0 : 1);
		float value = num4 / (516f * Mathf.Tan(lbchlcgocod.fieldOfView / 707f * 277f * 379f));
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.ILEDKHBOBEP, value);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MHPDBDMCHHM, settings.screenEdgeMask.intensity);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.EEIBFGNMEEB, settings.reflection.reflectionBlur);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.MPFBGGPIDIM, settings.reflection.maxDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.FNMDACJBBNK, settings.intensity.fadeDistance);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DANFBPPKIBJ, settings.reflection.widthModifier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.BEFPPLGOENI, settings.intensity.reflectionMultiplier);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.OOAIPNJLKMH, settings.intensity.fresnelFade);
		material.SetFloat(IIAIELHPNCF.OKAHOEKKJGO.DGGKECCNGMC, settings.intensity.fresnelFadePower);
		Matrix4x4 projectionMatrix = lbchlcgocod.projectionMatrix;
		Vector4 value2 = new Vector4(827f / (num4 * projectionMatrix[0]), 513f / (num5 * projectionMatrix[5]), (1567f - projectionMatrix[4]) / projectionMatrix[0], (1329f + projectionMatrix[8]) / projectionMatrix[5]);
		Vector3 v = float.IsPositiveInfinity(lbchlcgocod.farClipPlane) ? new Vector3(lbchlcgocod.nearClipPlane, 150f, 1217f) : new Vector3(lbchlcgocod.nearClipPlane * lbchlcgocod.farClipPlane, lbchlcgocod.nearClipPlane - lbchlcgocod.farClipPlane, lbchlcgocod.farClipPlane);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.DGOCFNAMNGB, new Vector2((float)num2, (float)num3));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.PDKMJIFDFHL, new Vector2(num4, num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.CKDNADBPNMD, new Vector2(766f / num4, 1499f / num5));
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.LKDHHHEHHKH, value2);
		material.SetVector(IIAIELHPNCF.OKAHOEKKJGO.HGFFIHPHEPE, v);
		Matrix4x4 lhs = default(Matrix4x4);
		lhs.SetRow(1, new Vector4(num6, 1137f, 310f, num6));
		lhs.SetRow(0, new Vector4(1382f, num7, 196f, num7));
		lhs.SetRow(7, new Vector4(506f, 1496f, 283f, 1844f));
		lhs.SetRow(5, new Vector4(846f, 776f, 1888f, 1073f));
		Matrix4x4 value3 = lhs * projectionMatrix;
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.ONPEDEGAHAI, value3);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.LKDCOOPGNNK, lbchlcgocod.worldToCameraMatrix);
		material.SetMatrix(IIAIELHPNCF.OKAHOEKKJGO.AFHENOLEIBA, lbchlcgocod.worldToCameraMatrix.inverse);
		RenderTextureFormat format = this.AMCOGJHPPOC.BLMBFAOCMNK() ? RenderTextureFormat.Shadowmap : RenderTextureFormat.Depth;
		int fhlehncdjih = IIAIELHPNCF.OKAHOEKKJGO.FHLEHNCDJIH;
		int nomalfceeba = IIAIELHPNCF.OKAHOEKKJGO.NOMALFCEEBA;
		int hmiphdghego = IIAIELHPNCF.OKAHOEKKJGO.HMIPHDGHEGO;
		int phkdbefkdde = IIAIELHPNCF.OKAHOEKKJGO.PHKDBEFKDDE;
		int fnpebjaaafc = IIAIELHPNCF.OKAHOEKKJGO.FNPEBJAAAFC;
		int eopogikcljp = IIAIELHPNCF.OKAHOEKKJGO.EOPOGIKCLJP;
		ECKPLMDEJFD.GetTemporaryRT(fhlehncdjih, -1, -1, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
		ECKPLMDEJFD.GetTemporaryRT(nomalfceeba, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB1555, RenderTextureReadWrite.Linear);
		for (int i = 0; i < 1; i += 0)
		{
			ECKPLMDEJFD.GetTemporaryRT(this.NICOKIJMKGD[i], num2 >> (i & -48), num3 >> (i & 63), 0, FilterMode.Bilinear, format);
		}
		ECKPLMDEJFD.GetTemporaryRT(phkdbefkdde, num2, num3, 0, this.LCHBDLDLLHO ? FilterMode.Bilinear : FilterMode.Point, format);
		ECKPLMDEJFD.GetTemporaryRT(fnpebjaaafc, num2, num3, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.ResolvedDepth, fhlehncdjih, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.Depth, nomalfceeba, material, 0);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.DepthNormals, phkdbefkdde, material, 1);
		ECKPLMDEJFD.Blit(phkdbefkdde, this.NICOKIJMKGD[1], material, 1);
		for (int j = 0; j < 1; j++)
		{
			int nameID = this.NICOKIJMKGD[j - 1];
			int num8 = j;
			ECKPLMDEJFD.GetTemporaryRT(hmiphdghego, num2 >> (num8 & 56), num3 >> (num8 & -22), 0, FilterMode.Bilinear, format);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(367f, 496f, 33f, 177f));
			ECKPLMDEJFD.SetGlobalFloat(IIAIELHPNCF.OKAHOEKKJGO.CIGLJIGDMLP, (float)j - 198f);
			ECKPLMDEJFD.Blit(nameID, hmiphdghego, material, 4);
			ECKPLMDEJFD.SetGlobalVector(IIAIELHPNCF.OKAHOEKKJGO.DHDMGDDKKIE, new Vector4(902f, 1968f, 1799f, 956f));
			nameID = this.NICOKIJMKGD[j];
			ECKPLMDEJFD.Blit(hmiphdghego, nameID, material, 4);
			ECKPLMDEJFD.ReleaseTemporaryRT(hmiphdghego);
		}
		ECKPLMDEJFD.Blit(this.NICOKIJMKGD[1], fnpebjaaafc, material, 4);
		ECKPLMDEJFD.GetTemporaryRT(eopogikcljp, lbchlcgocod.pixelWidth, lbchlcgocod.pixelHeight, 0, FilterMode.Point, format);
		ECKPLMDEJFD.Blit(BuiltinRenderTextureType.PrepassLight, eopogikcljp, material, 0);
		ECKPLMDEJFD.Blit(eopogikcljp, BuiltinRenderTextureType.DepthNormals);
		ECKPLMDEJFD.ReleaseTemporaryRT(eopogikcljp);
	}

	// Token: 0x060118FD RID: 71933 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode MEPHIAEOOLE()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x060118FE RID: 71934 RVA: 0x007DE105 File Offset: 0x007DC305
	public override CameraEvent POJFLMAFHEI()
	{
		return CameraEvent.AfterFinalPass;
	}

	// Token: 0x060118FF RID: 71935 RVA: 0x000EB372 File Offset: 0x000E9572
	public DepthTextureMode BBEMHKKOCEC()
	{
		return DepthTextureMode.None;
	}

	// Token: 0x04002490 RID: 9360
	private bool HJOFAIPIKDH;

	// Token: 0x04002491 RID: 9361
	private bool IEAFDBEPMHB = true;

	// Token: 0x04002492 RID: 9362
	private bool LEFDIHEPFAL;

	// Token: 0x04002493 RID: 9363
	private bool LCHBDLDLLHO = true;

	// Token: 0x04002494 RID: 9364
	private readonly int[] NICOKIJMKGD = new int[5];

	// Token: 0x0200052B RID: 1323
	private static class OKAHOEKKJGO
	{
		// Token: 0x04002495 RID: 9365
		internal static readonly int HIMNAMHOBIP = Shader.PropertyToID("_RayStepSize");

		// Token: 0x04002496 RID: 9366
		internal static readonly int MPCLELFCCBJ = Shader.PropertyToID("_AdditiveReflection");

		// Token: 0x04002497 RID: 9367
		internal static readonly int AEMLBPGPDOO = Shader.PropertyToID("_BilateralUpsampling");

		// Token: 0x04002498 RID: 9368
		internal static readonly int PCPJOKLKCJH = Shader.PropertyToID("_TreatBackfaceHitAsMiss");

		// Token: 0x04002499 RID: 9369
		internal static readonly int INPIDPPACDK = Shader.PropertyToID("_AllowBackwardsRays");

		// Token: 0x0400249A RID: 9370
		internal static readonly int BMNKMEFMHKP = Shader.PropertyToID("_TraceBehindObjects");

		// Token: 0x0400249B RID: 9371
		internal static readonly int KMPLODOGLLD = Shader.PropertyToID("_MaxSteps");

		// Token: 0x0400249C RID: 9372
		internal static readonly int JGAMGJPDHAJ = Shader.PropertyToID("_FullResolutionFiltering");

		// Token: 0x0400249D RID: 9373
		internal static readonly int LMNNBPBDKBI = Shader.PropertyToID("_HalfResolution");

		// Token: 0x0400249E RID: 9374
		internal static readonly int CCBMKEBFNHF = Shader.PropertyToID("_HighlightSuppression");

		// Token: 0x0400249F RID: 9375
		internal static readonly int ILEDKHBOBEP = Shader.PropertyToID("_PixelsPerMeterAtOneMeter");

		// Token: 0x040024A0 RID: 9376
		internal static readonly int MHPDBDMCHHM = Shader.PropertyToID("_ScreenEdgeFading");

		// Token: 0x040024A1 RID: 9377
		internal static readonly int EEIBFGNMEEB = Shader.PropertyToID("_ReflectionBlur");

		// Token: 0x040024A2 RID: 9378
		internal static readonly int MPFBGGPIDIM = Shader.PropertyToID("_MaxRayTraceDistance");

		// Token: 0x040024A3 RID: 9379
		internal static readonly int FNMDACJBBNK = Shader.PropertyToID("_FadeDistance");

		// Token: 0x040024A4 RID: 9380
		internal static readonly int DANFBPPKIBJ = Shader.PropertyToID("_LayerThickness");

		// Token: 0x040024A5 RID: 9381
		internal static readonly int BEFPPLGOENI = Shader.PropertyToID("_SSRMultiplier");

		// Token: 0x040024A6 RID: 9382
		internal static readonly int OOAIPNJLKMH = Shader.PropertyToID("_FresnelFade");

		// Token: 0x040024A7 RID: 9383
		internal static readonly int DGGKECCNGMC = Shader.PropertyToID("_FresnelFadePower");

		// Token: 0x040024A8 RID: 9384
		internal static readonly int DGOCFNAMNGB = Shader.PropertyToID("_ReflectionBufferSize");

		// Token: 0x040024A9 RID: 9385
		internal static readonly int PDKMJIFDFHL = Shader.PropertyToID("_ScreenSize");

		// Token: 0x040024AA RID: 9386
		internal static readonly int CKDNADBPNMD = Shader.PropertyToID("_InvScreenSize");

		// Token: 0x040024AB RID: 9387
		internal static readonly int LKDHHHEHHKH = Shader.PropertyToID("_ProjInfo");

		// Token: 0x040024AC RID: 9388
		internal static readonly int HGFFIHPHEPE = Shader.PropertyToID("_CameraClipInfo");

		// Token: 0x040024AD RID: 9389
		internal static readonly int ONPEDEGAHAI = Shader.PropertyToID("_ProjectToPixelMatrix");

		// Token: 0x040024AE RID: 9390
		internal static readonly int LKDCOOPGNNK = Shader.PropertyToID("_WorldToCameraMatrix");

		// Token: 0x040024AF RID: 9391
		internal static readonly int AFHENOLEIBA = Shader.PropertyToID("_CameraToWorldMatrix");

		// Token: 0x040024B0 RID: 9392
		internal static readonly int DHDMGDDKKIE = Shader.PropertyToID("_Axis");

		// Token: 0x040024B1 RID: 9393
		internal static readonly int CIGLJIGDMLP = Shader.PropertyToID("_CurrentMipLevel");

		// Token: 0x040024B2 RID: 9394
		internal static readonly int FHLEHNCDJIH = Shader.PropertyToID("_NormalAndRoughnessTexture");

		// Token: 0x040024B3 RID: 9395
		internal static readonly int NOMALFCEEBA = Shader.PropertyToID("_HitPointTexture");

		// Token: 0x040024B4 RID: 9396
		internal static readonly int HMIPHDGHEGO = Shader.PropertyToID("_BlurTexture");

		// Token: 0x040024B5 RID: 9397
		internal static readonly int PHKDBEFKDDE = Shader.PropertyToID("_FilteredReflections");

		// Token: 0x040024B6 RID: 9398
		internal static readonly int FNPEBJAAAFC = Shader.PropertyToID("_FinalReflectionTexture");

		// Token: 0x040024B7 RID: 9399
		internal static readonly int EOPOGIKCLJP = Shader.PropertyToID("_TempTexture");
	}

	// Token: 0x0200052C RID: 1324
	private enum OEOIFJHMFPK
	{
		// Token: 0x040024B9 RID: 9401
		RayTraceStep,
		// Token: 0x040024BA RID: 9402
		CompositeFinal,
		// Token: 0x040024BB RID: 9403
		Blur,
		// Token: 0x040024BC RID: 9404
		CompositeSSR,
		// Token: 0x040024BD RID: 9405
		MinMipGeneration,
		// Token: 0x040024BE RID: 9406
		HitPointToReflections,
		// Token: 0x040024BF RID: 9407
		BilateralKeyPack,
		// Token: 0x040024C0 RID: 9408
		BlitDepthAsCSZ,
		// Token: 0x040024C1 RID: 9409
		PoissonBlur
	}
}
