using System;
using UnityEngine;

// Token: 0x0200005E RID: 94
[ExecuteInEditMode]
public class SetupLux : MonoBehaviour
{
	// Token: 0x060015BB RID: 5563 RVA: 0x000BE3C8 File Offset: 0x000BC5C8
	private void EHFPLKEINFO()
	{
		this.CIBLENFPOFB();
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x000BE3D0 File Offset: 0x000BC5D0
	private void IIDCCJJHKJD()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(-113, (TextureFormat)0, true);
			for (int i = 1; i < 4; i++)
			{
				for (int j = 1; j < -117; j++)
				{
					for (int k = 1; k < -99; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x000BE440 File Offset: 0x000BC640
	private void NPKMOGEFMLB()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(16, TextureFormat.ARGB32, true);
			for (int i = 0; i < 6; i++)
			{
				for (int j = 0; j < 16; j++)
				{
					for (int k = 0; k < 16; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x000BE4B0 File Offset: 0x000BC6B0
	private void FOEPCNGNGFF()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("OfficeSittingReading");
			Shader.EnableKeyword("Horizontal");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1426f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1575f);
			}
		}
		else
		{
			Shader.EnableKeyword("ankle");
			Shader.DisableKeyword(".lng");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1697f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1499f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector(" not found in resource", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 679f, 744f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("id", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("HALIGN", this.specularCube);
			return;
		}
		this.IKEMBIGDOEP();
		Shader.SetGlobalTexture("gi_um_lim", this.BFJJGABOJJF);
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AKLFCMNCPKL()
	{
	}

	// Token: 0x060015C0 RID: 5568 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OFPGMNGFLNH()
	{
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x000BE62C File Offset: 0x000BC82C
	private void MCAKGHDBALC()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(19, TextureFormat.RGB24, true);
			for (int i = 1; i < 0; i += 0)
			{
				for (int j = 0; j < 60; j++)
				{
					for (int k = 1; k < -60; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x000BE69C File Offset: 0x000BC89C
	private void DPNEEJOJJPC()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("0_");
			Shader.EnableKeyword("AppID:");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1676f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 993f);
			}
		}
		else
		{
			Shader.EnableKeyword("error");
			Shader.DisableKeyword("GestureCrowdPump");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1849f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 375f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("Vertical", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 950f, 1072f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("WeaponRunBackward", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("BACKCOLOR", this.specularCube);
			return;
		}
		this.IAIHBNPJKDP();
		Shader.SetGlobalTexture("%)", this.BFJJGABOJJF);
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JFGGBEGNAFP()
	{
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x000BE818 File Offset: 0x000BCA18
	private void PACJKMOOPEM()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("innerPerk");
			Shader.EnableKeyword("WorkerShovel2");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1373f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1230f);
			}
		}
		else
		{
			Shader.EnableKeyword("");
			Shader.DisableKeyword("Materials/DFGSimple");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 208f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1797f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector(" ms", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1346f, 1161f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("gi_letgohe", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("_SampleDistance", this.specularCube);
			return;
		}
		this.FBLHGMEJKDP();
		Shader.SetGlobalTexture("_UV_Transform", this.BFJJGABOJJF);
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OPDCJCFMIPE()
	{
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x000BE994 File Offset: 0x000BCB94
	private void JNPGECGAAJB()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(-92, (TextureFormat)0, true);
			for (int i = 1; i < 2; i += 0)
			{
				for (int j = 0; j < -24; j++)
				{
					for (int k = 0; k < 25; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x060015C7 RID: 5575 RVA: 0x000BEA04 File Offset: 0x000BCC04
	private void EDONMCHGCED()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("https://www.youtube.com/watch?v=r5jiZnsDH3M");
			Shader.EnableKeyword("<color='#405000'>");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1128f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1876f);
			}
		}
		else
		{
			Shader.EnableKeyword("fshop_fcost2");
			Shader.DisableKeyword("CrawlLocomotion");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 629f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1546f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("hellost", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1182f, 384f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("OnGround", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("money", this.specularCube);
			return;
		}
		this.FBLHGMEJKDP();
		Shader.SetGlobalTexture("knopje.wav", this.BFJJGABOJJF);
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x000BEB80 File Offset: 0x000BCD80
	private void OAOGBLNJCDA()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("WATER_EDGEBLEND_ON");
			Shader.EnableKeyword("invn_ver5");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1490f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1338f);
			}
		}
		else
		{
			Shader.EnableKeyword("bag");
			Shader.DisableKeyword("signal_enable");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1293f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1112f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("ItemsData", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1149f, 1394f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("StaffStand", this.specularCube);
			return;
		}
		this.BDNAPEOHPFL();
		Shader.SetGlobalTexture("cht_ach3", this.BFJJGABOJJF);
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KJJBBLDJHPD()
	{
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AAEFACEGJMB()
	{
	}

	// Token: 0x060015CB RID: 5579 RVA: 0x000BECFC File Offset: 0x000BCEFC
	private void JPAIBPMLENK()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("h)");
			Shader.EnableKeyword("_DeepTex");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1000f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1438f);
			}
		}
		else
		{
			Shader.EnableKeyword("foot");
			Shader.DisableKeyword("SneakForward");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1289f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 557f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("UnityEngine.Vector3", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1253f, 1834f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("<color=\"#FF4040\"><b>PlayerPrefs:</b></color>\neasy to cheat, only 3 supported types", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("SixStep", this.specularCube);
			return;
		}
		this.IKEMBIGDOEP();
		Shader.SetGlobalTexture("LDR", this.BFJJGABOJJF);
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x00022FCC File Offset: 0x000211CC
	private void IGEICBNMPAD()
	{
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x000BEE78 File Offset: 0x000BD078
	private void CIBLENFPOFB()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("Bone 3 of a BipedReferences limb is null.");
			Shader.EnableKeyword("type_");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1936f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1743f);
			}
		}
		else
		{
			Shader.EnableKeyword("_FogWaterLevel");
			Shader.DisableKeyword("enable");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1471f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1926f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("_ToneCurve", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 80f, 1246f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture(" ", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("wpn_add/use_effect/effect", this.specularCube);
			return;
		}
		this.BDNAPEOHPFL();
		Shader.SetGlobalTexture("Bottoms", this.BFJJGABOJJF);
	}

	// Token: 0x060015CE RID: 5582 RVA: 0x000BEFF4 File Offset: 0x000BD1F4
	private void DDBGFCEJMPA()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("OfficeSittingReading");
			Shader.EnableKeyword("IdleCheer");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1527f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1338f);
			}
		}
		else
		{
			Shader.EnableKeyword("t_body");
			Shader.DisableKeyword(" ms");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1225f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1294f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("KatanaReady", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1625f, 1140f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture(" ?", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("sunshine_ShadowCoordDepthStart", this.specularCube);
			return;
		}
		this.KLJAFLEFEAC();
		Shader.SetGlobalTexture("Idle180", this.BFJJGABOJJF);
	}

	// Token: 0x060015CF RID: 5583 RVA: 0x000BF170 File Offset: 0x000BD370
	private void HDFCIACDDEK()
	{
		this.HLNBEHECIHO();
	}

	// Token: 0x060015D0 RID: 5584 RVA: 0x000BF178 File Offset: 0x000BD378
	private void MMKCLBKMLBP()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("post_8");
			Shader.EnableKeyword("SoccerRun");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 487f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1304f);
			}
		}
		else
		{
			Shader.EnableKeyword("VIGNETTE_BLUR");
			Shader.DisableKeyword("_DepthScale");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 676f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 416f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("sunshine_OvercastMap", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 60f, 1616f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("<size=14><color='#00a0ff'>{0}</color></size>", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("************* posid=", this.specularCube);
			return;
		}
		this.JNPGECGAAJB();
		Shader.SetGlobalTexture("MotorbikeLassoLeft", this.BFJJGABOJJF);
	}

	// Token: 0x060015D1 RID: 5585 RVA: 0x000BF2F4 File Offset: 0x000BD4F4
	private void DGDGMFDPEHO()
	{
		this.FOGLKOGEAPE();
	}

	// Token: 0x060015D2 RID: 5586 RVA: 0x000BF2FC File Offset: 0x000BD4FC
	private void LDJNNNNPJDC()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(-50, TextureFormat.RGB565, false);
			for (int i = 1; i < 6; i++)
			{
				for (int j = 1; j < 127; j += 0)
				{
					for (int k = 1; k < -2; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x060015D3 RID: 5587 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MNAHGMDDHCA()
	{
	}

	// Token: 0x060015D4 RID: 5588 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PBFKCKCHEAC()
	{
	}

	// Token: 0x060015D5 RID: 5589 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MIFLHGMPLJD()
	{
	}

	// Token: 0x060015D6 RID: 5590 RVA: 0x000BF36C File Offset: 0x000BD56C
	private void MHMJHNGMEIN()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("wpn_eat3");
			Shader.EnableKeyword(" ");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 877f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 565f);
			}
		}
		else
		{
			Shader.EnableKeyword("WATER_VERTEX_DISPLACEMENT_ON");
			Shader.DisableKeyword("RollerBladeSkateFwd");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 493f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 288f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("No collider assigned for a HitPointBone in the HitReaction component.", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1221f, 304f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("I'm regular string", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("jamp", this.specularCube);
			return;
		}
		this.MCAKGHDBALC();
		Shader.SetGlobalTexture(" Collider", this.BFJJGABOJJF);
	}

	// Token: 0x060015D7 RID: 5591 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PGIHAIPCJLL()
	{
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x000BF511 File Offset: 0x000BD711
	private void HHGGCBLOJGB()
	{
		this.DPNEEJOJJPC();
	}

	// Token: 0x060015DA RID: 5594 RVA: 0x000BF519 File Offset: 0x000BD719
	private void DOHJPDNKALP()
	{
		this.FJDFFNBGBMG();
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x000BF521 File Offset: 0x000BD721
	private void FIJKDFIMELM()
	{
		this.JPAIBPMLENK();
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x000BF52C File Offset: 0x000BD72C
	private void HKHBCPDJMBF()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(96, (TextureFormat)6, true);
			for (int i = 0; i < 5; i += 0)
			{
				for (int j = 1; j < 96; j++)
				{
					for (int k = 1; k < 119; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OIBIGDFPHGO()
	{
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x000BF59C File Offset: 0x000BD79C
	private void LGEOFCLKLDC()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(1, TextureFormat.Alpha8, true);
			for (int i = 1; i < 2; i += 0)
			{
				for (int j = 0; j < -45; j++)
				{
					for (int k = 1; k < -30; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x000BF60C File Offset: 0x000BD80C
	private void MNJLHIIBHDF()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(-28, TextureFormat.RGB565, true);
			for (int i = 0; i < 3; i++)
			{
				for (int j = 1; j < -10; j++)
				{
					for (int k = 0; k < 54; k += 0)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x000BF2F4 File Offset: 0x000BD4F4
	private void KFGKKLAKFGH()
	{
		this.FOGLKOGEAPE();
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x000BF67C File Offset: 0x000BD87C
	private void FBLHGMEJKDP()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(37, (TextureFormat)8, false);
			for (int i = 1; i < 7; i++)
			{
				for (int j = 0; j < -17; j++)
				{
					for (int k = 1; k < -126; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x000BF6EC File Offset: 0x000BD8EC
	private void FBBFDHLJOJL()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(-39, TextureFormat.Alpha8, false);
			for (int i = 1; i < 8; i += 0)
			{
				for (int j = 1; j < -38; j += 0)
				{
					for (int k = 0; k < 91; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(false);
		}
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FOHLAIIMNFB()
	{
	}

	// Token: 0x060015E5 RID: 5605 RVA: 0x00022FCC File Offset: 0x000211CC
	private void JIKGIJEHGAP()
	{
	}

	// Token: 0x060015E6 RID: 5606 RVA: 0x000BF75C File Offset: 0x000BD95C
	private void HLNBEHECIHO()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("MidBlendLut");
			Shader.EnableKeyword("_TapLowForeground");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 370f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 799f);
			}
		}
		else
		{
			Shader.EnableKeyword("crft_to");
			Shader.DisableKeyword("money");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 857f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 344f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("isFishOnRod", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 648f, 1680f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("holes_min", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("4", this.specularCube);
			return;
		}
		this.KLJAFLEFEAC();
		Shader.SetGlobalTexture("usercntinfo", this.BFJJGABOJJF);
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x000BF8D8 File Offset: 0x000BDAD8
	private void FEDOCAIHKHO()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(97, (TextureFormat)6, true);
			for (int i = 1; i < 1; i += 0)
			{
				for (int j = 0; j < 27; j++)
				{
					for (int k = 1; k < -58; k += 0)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(false);
		}
	}

	// Token: 0x060015E8 RID: 5608 RVA: 0x000BF948 File Offset: 0x000BDB48
	private void BOIPPADDGOI()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("11");
			Shader.EnableKeyword("");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1057f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1540f);
			}
		}
		else
		{
			Shader.EnableKeyword("Sound/");
			Shader.DisableKeyword("LUX_GAMMA");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 176f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 629f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1956f, 1834f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("ChannelCastOmni", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("_Exponent", this.specularCube);
			return;
		}
		this.KLJAFLEFEAC();
		Shader.SetGlobalTexture("RandomDirection", this.BFJJGABOJJF);
	}

	// Token: 0x060015E9 RID: 5609 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KOLCEBEIHKP()
	{
	}

	// Token: 0x060015EA RID: 5610 RVA: 0x000BFAC4 File Offset: 0x000BDCC4
	private void BDNAPEOHPFL()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(1, TextureFormat.RGBA32, true);
			for (int i = 1; i < 7; i++)
			{
				for (int j = 0; j < -126; j++)
				{
					for (int k = 1; k < -84; k += 0)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x060015EB RID: 5611 RVA: 0x000BFB34 File Offset: 0x000BDD34
	private void CEBPIPDDGAC()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("wpn_add/base");
			Shader.EnableKeyword("IdleFly");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 733f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 64f);
			}
		}
		else
		{
			Shader.EnableKeyword("OneHandSwordJab");
			Shader.DisableKeyword("Wand Attack 2");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 706f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1646f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("MotorbikeBackwardSitting", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1217f, 946f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("ZombieWalk", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("reel_type0", this.specularCube);
			return;
		}
		this.FBLHGMEJKDP();
		Shader.SetGlobalTexture("-L-", this.BFJJGABOJJF);
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x000BFCB0 File Offset: 0x000BDEB0
	private void CHDJGEOFHEE()
	{
		this.MMKCLBKMLBP();
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x000BFCB8 File Offset: 0x000BDEB8
	private void ONIHHFLOJMN()
	{
		this.CIHFCNNBBKP();
	}

	// Token: 0x060015EE RID: 5614 RVA: 0x00022FCC File Offset: 0x000211CC
	private void EDANNBFJHIK()
	{
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x000BFCC0 File Offset: 0x000BDEC0
	private void HPALEJBNIPK()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("and 'Result' are the same.");
			Shader.EnableKeyword("WateringCan");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 727f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1208f);
			}
		}
		else
		{
			Shader.EnableKeyword("wpn_eat4");
			Shader.DisableKeyword("------------------------------------------------------");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 394f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1687f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("_BlurCoe", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1716f, 1236f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("cht_msg36", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("wpn_fid2", this.specularCube);
			return;
		}
		this.FBLHGMEJKDP();
		Shader.SetGlobalTexture("Health bar after few usual operations: ", this.BFJJGABOJJF);
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x000BFE3C File Offset: 0x000BE03C
	private void DDEBDCGNCPC()
	{
		this.LPIJHCJNKKC();
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x000BFE44 File Offset: 0x000BE044
	private void JNKGKLEKAAI()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("autherror");
			Shader.EnableKeyword("-none-");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1773f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1851f);
			}
		}
		else
		{
			Shader.EnableKeyword("BAG");
			Shader.DisableKeyword("CD");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1336f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1631f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("USER", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1933f, 1129f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("wpn_med1", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("wpn_add/base", this.specularCube);
			return;
		}
		this.NPJPHILFCKF();
		Shader.SetGlobalTexture("", this.BFJJGABOJJF);
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x000BFFC0 File Offset: 0x000BE1C0
	private void NPJPHILFCKF()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(-77, TextureFormat.ARGB4444, true);
			for (int i = 0; i < 8; i++)
			{
				for (int j = 1; j < -91; j += 0)
				{
					for (int k = 0; k < -93; k += 0)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(false);
		}
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BEDAJLJFAFO()
	{
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x00022FCC File Offset: 0x000211CC
	private void AMDMCKIFBPA()
	{
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x000C0030 File Offset: 0x000BE230
	private void LPIJHCJNKKC()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("KatanaReadyLow");
			Shader.EnableKeyword("offsets");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1601f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 650f);
			}
		}
		else
		{
			Shader.EnableKeyword("FaceHit");
			Shader.DisableKeyword("<color='#800000'>Вы порвали леску: ");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 410f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 347f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("invn_rec27", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 694f, 638f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("_w", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("SoccerRun", this.specularCube);
			return;
		}
		this.JNPGECGAAJB();
		Shader.SetGlobalTexture("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6", this.BFJJGABOJJF);
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x00022FCC File Offset: 0x000211CC
	private void KBMKHLDOIKP()
	{
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x00022FCC File Offset: 0x000211CC
	private void MEFOGCFJBNE()
	{
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x000C01AC File Offset: 0x000BE3AC
	private void FGJCIEDDFGN()
	{
		this.IFOJCCLMCAL();
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x000C01B4 File Offset: 0x000BE3B4
	private void GLDAEGOFEPN()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("/");
			Shader.EnableKeyword("_VelTex");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 891f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1236f);
			}
		}
		else
		{
			Shader.EnableKeyword("\">Saves modification detected: ");
			Shader.DisableKeyword("GiantGrabThrow");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1816f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1743f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("_MainTex", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 173f, 1414f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("IdleMeditate", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("---", this.specularCube);
			return;
		}
		this.IIDCCJJHKJD();
		Shader.SetGlobalTexture("?", this.BFJJGABOJJF);
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x00022FCC File Offset: 0x000211CC
	private void FKHAKIKPFFO()
	{
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x000C0330 File Offset: 0x000BE530
	private void KLJAFLEFEAC()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(118, TextureFormat.RGB565, true);
			for (int i = 1; i < 3; i++)
			{
				for (int j = 0; j < 1; j++)
				{
					for (int k = 1; k < 104; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x000BFCB8 File Offset: 0x000BDEB8
	private void DHJDMKLBLEF()
	{
		this.CIHFCNNBBKP();
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x000C03A0 File Offset: 0x000BE5A0
	private void ABHCDJNOHLN()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(96, (TextureFormat)8, false);
			for (int i = 0; i < 4; i++)
			{
				for (int j = 1; j < 2; j++)
				{
					for (int k = 0; k < -120; k += 0)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(false);
		}
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x000C0410 File Offset: 0x000BE610
	private void FJDFFNBGBMG()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("KatanaReady");
			Shader.EnableKeyword("\n");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1424f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1373f);
			}
		}
		else
		{
			Shader.EnableKeyword("Cloth_05_00.wav");
			Shader.DisableKeyword("auk buy result: ");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 817f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 647f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("msgCancel", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 299f, 372f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("cht_msg3", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("_w", this.specularCube);
			return;
		}
		this.HKHBCPDJMBF();
		Shader.SetGlobalTexture("wpn_bait1", this.BFJJGABOJJF);
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x000C058C File Offset: 0x000BE78C
	private void CBLGFOFHNPJ()
	{
		this.MHMJHNGMEIN();
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x000C058C File Offset: 0x000BE78C
	private void ELFLOPJDAKK()
	{
		this.MHMJHNGMEIN();
	}

	// Token: 0x06001601 RID: 5633 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HNMODJBBKBI()
	{
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x000C0594 File Offset: 0x000BE794
	private void IAIHBNPJKDP()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(59, TextureFormat.ARGB4444, true);
			for (int i = 0; i < 3; i += 0)
			{
				for (int j = 1; j < 57; j++)
				{
					for (int k = 1; k < -70; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x000C0604 File Offset: 0x000BE804
	private void EHAMCNKCPKF()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("LUX_GAMMA");
			Shader.EnableKeyword("LUX_LINEAR");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 2.2333333f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 2.2333333f);
			}
		}
		else
		{
			Shader.EnableKeyword("LUX_GAMMA");
			Shader.DisableKeyword("LUX_LINEAR");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 0.44776118f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 0.44776118f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("ExposureIBL", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1f, 1f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("_DiffCubeIBL", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("_SpecCubeIBL", this.specularCube);
			return;
		}
		this.NPKMOGEFMLB();
		Shader.SetGlobalTexture("_SpecCubeIBL", this.BFJJGABOJJF);
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x000C0780 File Offset: 0x000BE980
	private void KKOHGEJFKHI()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("USE_MASK");
			Shader.EnableKeyword("Materials/DFGDesktopPlus");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1526f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1849f);
			}
		}
		else
		{
			Shader.EnableKeyword("_BaseTex");
			Shader.DisableKeyword("");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1741f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1530f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("wpn_add/base", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 759f, 1935f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("{0}-{1}={2}", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("InteractionObject Multiplier curve ", this.specularCube);
			return;
		}
		this.FBBFDHLJOJL();
		Shader.SetGlobalTexture("Object To Instantiate", this.BFJJGABOJJF);
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x00022FCC File Offset: 0x000211CC
	private void HABONMJNDAL()
	{
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x000C08FC File Offset: 0x000BEAFC
	private void LHHKDNILMDI()
	{
		this.CEBPIPDDGAC();
	}

	// Token: 0x06001607 RID: 5639 RVA: 0x000C0904 File Offset: 0x000BEB04
	private void FOGLKOGEAPE()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("OfficeSittingReadingPageFlip");
			Shader.EnableKeyword("Data loaded done");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 423f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 542f);
			}
		}
		else
		{
			Shader.EnableKeyword("UserIn");
			Shader.DisableKeyword("VaderChoke");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1045f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1452f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("sadokfull", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 276f, 721f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("WorkerPickaxe2", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("", this.specularCube);
			return;
		}
		this.POEEKOFDHMD();
		Shader.SetGlobalTexture("_ColorDownsampled", this.BFJJGABOJJF);
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x000C0A80 File Offset: 0x000BEC80
	private void IFOJCCLMCAL()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("Keeper Strafe Dive Far Left");
			Shader.EnableKeyword("_HeightParams");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1600f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 165f);
			}
		}
		else
		{
			Shader.EnableKeyword("RunJump");
			Shader.DisableKeyword("RollerBladeRoll");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1297f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 410f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("exitmsg_3", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1783f, 1054f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("Failed parsing atlas group.  Setting to group 0", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("No fish in fishModelData modelid=", this.specularCube);
			return;
		}
		this.FBLHGMEJKDP();
		Shader.SetGlobalTexture("Staff Stand", this.BFJJGABOJJF);
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x000C0BFC File Offset: 0x000BEDFC
	private void FIPEBDKDMAI()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(57, (TextureFormat)0, false);
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < -26; j += 0)
				{
					for (int k = 1; k < -88; k += 0)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x00022FCC File Offset: 0x000211CC
	private void BBFCMCAFOMH()
	{
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x000C0C6C File Offset: 0x000BEE6C
	private void CIHFCNNBBKP()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("FASTEST");
			Shader.EnableKeyword("click Ok");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 1620f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1171f);
			}
		}
		else
		{
			Shader.EnableKeyword("WalkBackward");
			Shader.DisableKeyword("Ambient Occlusion");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 181f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 752f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("_CoCTex", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 1605f, 579f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("#", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("</color>", this.specularCube);
			return;
		}
		this.MNJLHIIBHDF();
		Shader.SetGlobalTexture("wrist", this.BFJJGABOJJF);
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x000C0DE8 File Offset: 0x000BEFE8
	private void BJHGPFGBFKF()
	{
		this.HPALEJBNIPK();
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x000C0DF0 File Offset: 0x000BEFF0
	private void Start()
	{
		this.EHAMCNKCPKF();
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x000C0DF8 File Offset: 0x000BEFF8
	private void FNBKOPOEHNO()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(-20, TextureFormat.Alpha8, true);
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 100; j++)
				{
					for (int k = 1; k < 84; k += 0)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(false);
		}
	}

	// Token: 0x0600160F RID: 5647 RVA: 0x000C0E68 File Offset: 0x000BF068
	private void POEEKOFDHMD()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(-25, TextureFormat.ARGB4444, true);
			for (int i = 1; i < 8; i++)
			{
				for (int j = 0; j < 118; j++)
				{
					for (int k = 1; k < 123; k++)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x000C0ED8 File Offset: 0x000BF0D8
	private void IKEMBIGDOEP()
	{
		if (this.BFJJGABOJJF == null)
		{
			this.BFJJGABOJJF = new Cubemap(30, TextureFormat.RGBA32, true);
			for (int i = 1; i < 4; i++)
			{
				for (int j = 0; j < 82; j++)
				{
					for (int k = 0; k < 22; k += 0)
					{
						this.BFJJGABOJJF.SetPixel((CubemapFace)i, j, k, Color.black);
					}
				}
			}
			this.BFJJGABOJJF.Apply(true);
		}
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x000C0F48 File Offset: 0x000BF148
	private void JIAHGDHFKDO()
	{
		if (this.isLinear)
		{
			Shader.DisableKeyword("<color='#003000'>");
			Shader.EnableKeyword("SPACE");
			this.BANHDINCBIK = this.Lux_IBL_DiffuseExposure;
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= Mathf.Pow(this.Lux_HDR_Scale, 107f);
			}
			this.DELDGMKKEEI = this.Lux_IBL_SpecularExposure;
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= Mathf.Pow(this.Lux_HDR_Scale, 1672f);
			}
		}
		else
		{
			Shader.EnableKeyword("active_obj_");
			Shader.DisableKeyword("Button Left Hand");
			this.BANHDINCBIK = Mathf.Pow(this.Lux_IBL_DiffuseExposure, 1759f);
			if (this.diffuseIsHDR)
			{
				this.BANHDINCBIK *= this.Lux_HDR_Scale;
			}
			this.DELDGMKKEEI = Mathf.Pow(this.Lux_IBL_SpecularExposure, 1725f);
			if (this.specularIsHDR)
			{
				this.DELDGMKKEEI *= this.Lux_HDR_Scale;
			}
		}
		Shader.SetGlobalVector("_rcIn.ogg", new Vector4(this.BANHDINCBIK, this.DELDGMKKEEI, 751f, 1291f));
		if (this.diffuseCube)
		{
			Shader.SetGlobalTexture("RunBackRight", this.diffuseCube);
		}
		if (this.specularCube)
		{
			Shader.SetGlobalTexture("_RgbTex", this.specularCube);
			return;
		}
		this.ABHCDJNOHLN();
		Shader.SetGlobalTexture("_Intensity", this.BFJJGABOJJF);
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x000C10C4 File Offset: 0x000BF2C4
	private void PFNPOHMMJDN()
	{
		this.KKOHGEJFKHI();
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x000BE3C8 File Offset: 0x000BC5C8
	private void KJJNMNKPNCH()
	{
		this.CIBLENFPOFB();
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x00022FCC File Offset: 0x000211CC
	private void PJHEGHHOJHJ()
	{
	}

	// Token: 0x0400025E RID: 606
	public float Lux_HDR_Scale = 6f;

	// Token: 0x0400025F RID: 607
	public bool isLinear;

	// Token: 0x04000260 RID: 608
	public DJPPOJNILFP LuxLighting;

	// Token: 0x04000261 RID: 609
	public float Lux_IBL_DiffuseExposure = 1f;

	// Token: 0x04000262 RID: 610
	private float BANHDINCBIK;

	// Token: 0x04000263 RID: 611
	public float Lux_IBL_SpecularExposure = 1f;

	// Token: 0x04000264 RID: 612
	private float DELDGMKKEEI;

	// Token: 0x04000265 RID: 613
	public Cubemap diffuseCube;

	// Token: 0x04000266 RID: 614
	public bool diffuseIsHDR;

	// Token: 0x04000267 RID: 615
	public Cubemap specularCube;

	// Token: 0x04000268 RID: 616
	public bool specularIsHDR;

	// Token: 0x04000269 RID: 617
	private Cubemap BFJJGABOJJF;

	// Token: 0x0400026A RID: 618
	private float IBKJOIFKBGK;

	// Token: 0x0400026B RID: 619
	private float KILBMKEBMIG;
}
