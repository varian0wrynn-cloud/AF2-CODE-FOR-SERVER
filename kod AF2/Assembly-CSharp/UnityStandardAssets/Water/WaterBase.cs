using System;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x020002F9 RID: 761
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		// Token: 0x0600B1A1 RID: 45473 RVA: 0x004D838C File Offset: 0x004D658C
		public void GJJKECONNIG()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 159;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -49;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -90;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("_Offsets");
				Shader.DisableKeyword("_Params1");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("");
				Shader.DisableKeyword("Idle Meditate");
			}
		}

		// Token: 0x0600B1A2 RID: 45474 RVA: 0x004D844C File Offset: 0x004D664C
		public void EHHEMMHBOKK()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 28;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -191;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -64;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("IdleStand");
				Shader.DisableKeyword("OfficeSittingBack");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("ok");
				Shader.DisableKeyword("Quadruped");
			}
		}

		// Token: 0x0600B1A3 RID: 45475 RVA: 0x004D850C File Offset: 0x004D670C
		public void IBFPHPEMKLE(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1A4 RID: 45476 RVA: 0x004D852C File Offset: 0x004D672C
		public void AOLOBKGAIAA()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 41;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -43;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -145;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword(" {0}");
				Shader.DisableKeyword("Wall Sit");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword(":");
				Shader.DisableKeyword("BlackSmithHammer");
			}
		}

		// Token: 0x0600B1A5 RID: 45477 RVA: 0x004D85EC File Offset: 0x004D67EC
		public void LMGBKHCHPHO()
		{
			if (this.sharedMaterial)
			{
				this.EHJILFJHOCJ();
			}
		}

		// Token: 0x0600B1A6 RID: 45478 RVA: 0x004D8604 File Offset: 0x004D6804
		public void KOGJMBIGFCG()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 98;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -134;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -198;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("1 Hand Sword");
				Shader.DisableKeyword("KatanaReady");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("=");
				Shader.DisableKeyword("SUNSHINE_FILTER_HARD");
			}
		}

		// Token: 0x0600B1A7 RID: 45479 RVA: 0x004D86C4 File Offset: 0x004D68C4
		public void HOOFICFEFGD()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 72;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 38;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 79;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("x");
				Shader.DisableKeyword("/");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("\n");
				Shader.DisableKeyword("_Offsets");
			}
		}

		// Token: 0x0600B1A8 RID: 45480 RVA: 0x004D8784 File Offset: 0x004D6984
		public void GAAMDJCPJNC()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -57;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -125;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -69;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("Scuba Swim");
				Shader.DisableKeyword("10");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("toquality=");
				Shader.DisableKeyword("_Parameter");
			}
		}

		// Token: 0x0600B1A9 RID: 45481 RVA: 0x004D8844 File Offset: 0x004D6A44
		public void BNKJNBIDPME()
		{
			if (this.sharedMaterial)
			{
				this.BMEBKDKHCMM();
			}
		}

		// Token: 0x0600B1AA RID: 45482 RVA: 0x004D85EC File Offset: 0x004D67EC
		public void PNBGJBMJLFM()
		{
			if (this.sharedMaterial)
			{
				this.EHJILFJHOCJ();
			}
		}

		// Token: 0x0600B1AB RID: 45483 RVA: 0x004D885C File Offset: 0x004D6A5C
		public void INKCCNHGEIP()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -60;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -165;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 17;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("gameComplete");
				Shader.DisableKeyword("");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("?");
				Shader.DisableKeyword("TONEMAPPING_FILMIC");
			}
		}

		// Token: 0x0600B1AC RID: 45484 RVA: 0x004D850C File Offset: 0x004D670C
		public void PCECKLDJGAB(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1AD RID: 45485 RVA: 0x004D891C File Offset: 0x004D6B1C
		public void EOOCPBGCCBE()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -65;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -66;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 170;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("qd_taskcount");
				Shader.DisableKeyword("GestureCutThroat");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("_ToneCurveRange");
				Shader.DisableKeyword("WalkInjured");
			}
		}

		// Token: 0x0600B1AE RID: 45486 RVA: 0x004D89DC File Offset: 0x004D6BDC
		public void IOGAKGCADBL()
		{
			if (this.sharedMaterial)
			{
				this.OMFCMEIOPNH();
			}
		}

		// Token: 0x0600B1AF RID: 45487 RVA: 0x004D89F4 File Offset: 0x004D6BF4
		public void FPGBBJEIAMK()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -30;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 125;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -165;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("1HandSwordRollAttack");
				Shader.DisableKeyword("SPECIAL");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("#80ff00");
				Shader.DisableKeyword("gi_fridgiceno");
			}
		}

		// Token: 0x0600B1B0 RID: 45488 RVA: 0x004D850C File Offset: 0x004D670C
		public void WaterTileBeingRendered(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1B1 RID: 45489 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void MNMIINCGLGI(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B1B2 RID: 45490 RVA: 0x004D8AD4 File Offset: 0x004D6CD4
		public void NKMKLOOKAME()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 183;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 151;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 183;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("KatanaHorizontalSwing");
				Shader.DisableKeyword("");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("");
				Shader.DisableKeyword("ObscuredByte:");
			}
		}

		// Token: 0x0600B1B3 RID: 45491 RVA: 0x004D8B94 File Offset: 0x004D6D94
		public void BDBLFNPGEJA()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -3;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 21;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -51;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("{0}|{1}|{2}|{3}|{4}");
				Shader.DisableKeyword("час");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("WeaponReady");
				Shader.DisableKeyword("The 'color' command requires a color parameter of RRGGBBAA or '?'.");
			}
		}

		// Token: 0x0600B1B4 RID: 45492 RVA: 0x004D89DC File Offset: 0x004D6BDC
		public void KCBECEFNGMO()
		{
			if (this.sharedMaterial)
			{
				this.OMFCMEIOPNH();
			}
		}

		// Token: 0x0600B1B5 RID: 45493 RVA: 0x004D8C54 File Offset: 0x004D6E54
		public void HMLNMHOMMNO()
		{
			if (this.sharedMaterial)
			{
				this.DGFENFPMNFG();
			}
		}

		// Token: 0x0600B1B6 RID: 45494 RVA: 0x004D8C6C File Offset: 0x004D6E6C
		public void MJCBMPIEKNN()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -85;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 198;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 26;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("_History2Weight");
				Shader.DisableKeyword("Account.getI.servSteamID=");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("rod_inf1");
				Shader.DisableKeyword("");
			}
		}

		// Token: 0x0600B1B7 RID: 45495 RVA: 0x004D8D2C File Offset: 0x004D6F2C
		public void EPEABDHNFOF()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 31;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -186;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -45;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("BipedReferences contains one or more missing Transforms.");
				Shader.DisableKeyword("run_cnt");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("BlackSmithHammer");
				Shader.DisableKeyword("_RayStepSize");
			}
		}

		// Token: 0x0600B1B8 RID: 45496 RVA: 0x004D8DEC File Offset: 0x004D6FEC
		public void AFHBOLFGJNE()
		{
			if (this.sharedMaterial)
			{
				this.ELCGOJJCBDD();
			}
		}

		// Token: 0x0600B1B9 RID: 45497 RVA: 0x004D8E04 File Offset: 0x004D7004
		public void ABFHCKHNFIC()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 91;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 162;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 139;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("__MirrorReflection");
				Shader.DisableKeyword("wpn/");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("NOISE_OFF");
				Shader.DisableKeyword("IdleStand");
			}
		}

		// Token: 0x0600B1BA RID: 45498 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void GADDIBGNHDH(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B1BB RID: 45499 RVA: 0x004D8EC4 File Offset: 0x004D70C4
		public void PMMPMDNCAEH()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -13;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 67;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -45;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("nowp");
				Shader.DisableKeyword("__b");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("crft_to");
				Shader.DisableKeyword("B");
			}
		}

		// Token: 0x0600B1BC RID: 45500 RVA: 0x004D8F84 File Offset: 0x004D7184
		public void MPLCAGFGEBO()
		{
			if (this.sharedMaterial)
			{
				this.NBNICGFIPBC();
			}
		}

		// Token: 0x0600B1BD RID: 45501 RVA: 0x004D8F9C File Offset: 0x004D719C
		public void MAJFDEKCLLG()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 177;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 80;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 172;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
				Shader.DisableKeyword("weight");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("Couldn't get avatar.");
				Shader.DisableKeyword("CrouchStrafeLeft");
			}
		}

		// Token: 0x0600B1BE RID: 45502 RVA: 0x004D905C File Offset: 0x004D725C
		public void PMKOAHMNBBG()
		{
			if (this.sharedMaterial)
			{
				this.EOOCPBGCCBE();
			}
		}

		// Token: 0x0600B1BF RID: 45503 RVA: 0x004D9074 File Offset: 0x004D7274
		public void MJJBPIGKDIH()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -4;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -189;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 132;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("Life bar: ");
				Shader.DisableKeyword("{not_found}");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword(" has been unloaded successfully");
				Shader.DisableKeyword("Open tinfo");
			}
		}

		// Token: 0x0600B1C0 RID: 45504 RVA: 0x004D9134 File Offset: 0x004D7334
		public void IIEBLJACFMM()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 14;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -137;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 4;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("");
				Shader.DisableKeyword("");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("Steam Overlay has been activated");
				Shader.DisableKeyword("1");
			}
		}

		// Token: 0x0600B1C1 RID: 45505 RVA: 0x004D91F4 File Offset: 0x004D73F4
		public void NHLPGKLMPKF()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 47;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 0;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -145;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("PistolReload");
				Shader.DisableKeyword("\n");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("The object '{0}' has a ProBuilder attachment component which contains zero attached elements.");
				Shader.DisableKeyword("\n");
			}
		}

		// Token: 0x0600B1C2 RID: 45506 RVA: 0x004D92B4 File Offset: 0x004D74B4
		public void UpdateShader()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 501;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 301;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 201;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("WATER_EDGEBLEND_ON");
				Shader.DisableKeyword("WATER_EDGEBLEND_OFF");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("WATER_EDGEBLEND_OFF");
				Shader.DisableKeyword("WATER_EDGEBLEND_ON");
			}
		}

		// Token: 0x0600B1C3 RID: 45507 RVA: 0x004D9374 File Offset: 0x004D7574
		public void Update()
		{
			if (this.sharedMaterial)
			{
				this.UpdateShader();
			}
		}

		// Token: 0x0600B1C4 RID: 45508 RVA: 0x004D9389 File Offset: 0x004D7589
		public void HAIMGCDKPDC()
		{
			if (this.sharedMaterial)
			{
				this.MAJFDEKCLLG();
			}
		}

		// Token: 0x0600B1C5 RID: 45509 RVA: 0x004D93A0 File Offset: 0x004D75A0
		public void PEAIJKHDKPD()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 5;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -39;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 98;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("_StereoToPrevViewProjCombined0");
				Shader.DisableKeyword("http://www.root-motion.com/finalikdox/html/page6.html");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("Null");
				Shader.DisableKeyword("error");
			}
		}

		// Token: 0x0600B1C6 RID: 45510 RVA: 0x004D9460 File Offset: 0x004D7660
		public void MJABOOEEJMK()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -17;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 89;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -59;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("WizardOverhead");
				Shader.DisableKeyword("fishdrop_3");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("Sitting Hand Rest Finger Tap");
				Shader.DisableKeyword("ShotgunReloadMagazine");
			}
		}

		// Token: 0x0600B1C7 RID: 45511 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void GEEIBHMFPBB(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B1C8 RID: 45512 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void PLLAGKCGNII(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B1C9 RID: 45513 RVA: 0x004D9520 File Offset: 0x004D7720
		public void KMPEBHIPKJH()
		{
			if (this.sharedMaterial)
			{
				this.LDGOLGNOFJP();
			}
		}

		// Token: 0x0600B1CA RID: 45514 RVA: 0x004D9538 File Offset: 0x004D7738
		public void PMKGGLLNCIG()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 90;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -107;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -4;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("Attached object");
				Shader.DisableKeyword("1HandSmallWeaponCombo");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("");
				Shader.DisableKeyword("Reset");
			}
		}

		// Token: 0x0600B1CB RID: 45515 RVA: 0x004D95F8 File Offset: 0x004D77F8
		public void OFFBHJCEPAO()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 148;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -2;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 52;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("iPoint");
				Shader.DisableKeyword("Soccer Sprint");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("WeaponRunBackward");
				Shader.DisableKeyword("_Cull");
			}
		}

		// Token: 0x0600B1CC RID: 45516 RVA: 0x004D96B8 File Offset: 0x004D78B8
		public void BMEBKDKHCMM()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -148;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -82;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 135;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("Shaders/EyeHistogram");
				Shader.DisableKeyword("UNDERLINE");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("aa=");
				Shader.DisableKeyword("");
			}
		}

		// Token: 0x0600B1CD RID: 45517 RVA: 0x004D9778 File Offset: 0x004D7978
		public void JOHDLNOKCOK()
		{
			if (this.sharedMaterial)
			{
				this.DEICNAGAGJP();
			}
		}

		// Token: 0x0600B1CE RID: 45518 RVA: 0x004D978D File Offset: 0x004D798D
		public void NOLKOIHEICD()
		{
			if (this.sharedMaterial)
			{
				this.AJOBIKKLCPF();
			}
		}

		// Token: 0x0600B1CF RID: 45519 RVA: 0x004D97A2 File Offset: 0x004D79A2
		public void JLFBDOPFDDJ()
		{
			if (this.sharedMaterial)
			{
				this.PIPEIGJDDLG();
			}
		}

		// Token: 0x0600B1D0 RID: 45520 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void OPKMFJGDNGC(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B1D1 RID: 45521 RVA: 0x004D850C File Offset: 0x004D670C
		public void BNMNMGMEPKB(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1D2 RID: 45522 RVA: 0x004D850C File Offset: 0x004D670C
		public void GPHAFBEKAGP(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1D3 RID: 45523 RVA: 0x004D97B7 File Offset: 0x004D79B7
		public void DEFOEBHHLJI()
		{
			if (this.sharedMaterial)
			{
				this.JCOFGAMGPIP();
			}
		}

		// Token: 0x0600B1D4 RID: 45524 RVA: 0x004D850C File Offset: 0x004D670C
		public void HLJLDCFAHDO(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1D5 RID: 45525 RVA: 0x004D97CC File Offset: 0x004D79CC
		public void LJIONNODEAF()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -98;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -134;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -116;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("offsets");
				Shader.DisableKeyword("RollerBladeTurnLeft");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("");
				Shader.DisableKeyword("_BaseTex");
			}
		}

		// Token: 0x0600B1D6 RID: 45526 RVA: 0x004D988C File Offset: 0x004D7A8C
		public void BJOICAKCPLI()
		{
			if (this.sharedMaterial)
			{
				this.GJJKECONNIG();
			}
		}

		// Token: 0x0600B1D8 RID: 45528 RVA: 0x004D98B8 File Offset: 0x004D7AB8
		public void AONEMNOIDKN()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -182;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 0;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -130;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("WaypointHeading.tif");
				Shader.DisableKeyword("DENSITY");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("neck");
				Shader.DisableKeyword("shop_ycnt");
			}
		}

		// Token: 0x0600B1D9 RID: 45529 RVA: 0x004D9978 File Offset: 0x004D7B78
		public void ELCGOJJCBDD()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -100;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -88;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -126;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("IdleWalk");
				Shader.DisableKeyword("lash");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("run");
				Shader.DisableKeyword("WizardOverhead");
			}
		}

		// Token: 0x0600B1DA RID: 45530 RVA: 0x004D850C File Offset: 0x004D670C
		public void ALPEMJCKEDO(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1DB RID: 45531 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void KAMMNPGOOMI(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B1DC RID: 45532 RVA: 0x004D9A38 File Offset: 0x004D7C38
		public void OMFCMEIOPNH()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -19;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -156;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 26;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("A");
				Shader.DisableKeyword("_MainTex");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("Anti-Cheat Toolkit Detectors");
				Shader.DisableKeyword("Swim");
			}
		}

		// Token: 0x0600B1DD RID: 45533 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void JCBJHGGIDLN(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B1DE RID: 45534 RVA: 0x004D850C File Offset: 0x004D670C
		public void LFPHCKLMJPF(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1DF RID: 45535 RVA: 0x004D9AF8 File Offset: 0x004D7CF8
		public void FLDHBBPNFBI()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 95;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 137;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -30;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("ok");
				Shader.DisableKeyword("StaffHeal");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("_Distance");
				Shader.DisableKeyword("Grounded");
			}
		}

		// Token: 0x0600B1E0 RID: 45536 RVA: 0x004D850C File Offset: 0x004D670C
		public void ICBLEOLOHHC(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1E1 RID: 45537 RVA: 0x004D9BB8 File Offset: 0x004D7DB8
		public void IKHCCAANGOP()
		{
			if (this.sharedMaterial)
			{
				this.MJABOOEEJMK();
			}
		}

		// Token: 0x0600B1E2 RID: 45538 RVA: 0x004D9BD0 File Offset: 0x004D7DD0
		public void LEPMHGNDCMK()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 105;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -40;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 172;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("KatanaReady");
				Shader.DisableKeyword("cntx_use");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("ShotgunReloadChamber");
				Shader.DisableKeyword("post_5");
			}
		}

		// Token: 0x0600B1E3 RID: 45539 RVA: 0x004D9C90 File Offset: 0x004D7E90
		public void DKFEBENGBKF()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -67;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 40;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -150;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("shop_t15");
				Shader.DisableKeyword("gi_inte_1");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("wpn_add/base");
				Shader.DisableKeyword("#> _Shadow Camera < ");
			}
		}

		// Token: 0x0600B1E4 RID: 45540 RVA: 0x004D9D50 File Offset: 0x004D7F50
		public void LHNKPOCAIOA()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 20;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -108;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -125;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("cht_msg14");
				Shader.DisableKeyword("");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("auk_pstavka");
				Shader.DisableKeyword("_WaveOffset");
			}
		}

		// Token: 0x0600B1E5 RID: 45541 RVA: 0x004D9E10 File Offset: 0x004D8010
		public void LDDIGEMBDNF()
		{
			if (this.sharedMaterial)
			{
				this.INKCCNHGEIP();
			}
		}

		// Token: 0x0600B1E6 RID: 45542 RVA: 0x004D9E25 File Offset: 0x004D8025
		public void KOLCEBEIHKP()
		{
			if (this.sharedMaterial)
			{
				this.MCEAMNKJANN();
			}
		}

		// Token: 0x0600B1E7 RID: 45543 RVA: 0x004D9E3A File Offset: 0x004D803A
		public void NFPFDOEENLA()
		{
			if (this.sharedMaterial)
			{
				this.LHNKPOCAIOA();
			}
		}

		// Token: 0x0600B1E8 RID: 45544 RVA: 0x004D89DC File Offset: 0x004D6BDC
		public void BEDAJLJFAFO()
		{
			if (this.sharedMaterial)
			{
				this.OMFCMEIOPNH();
			}
		}

		// Token: 0x0600B1E9 RID: 45545 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void MCOFNLDMNEK(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B1EA RID: 45546 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void GGNDDOKHOEL(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B1EB RID: 45547 RVA: 0x004D9E4F File Offset: 0x004D804F
		public void FOHLAIIMNFB()
		{
			if (this.sharedMaterial)
			{
				this.MJCBMPIEKNN();
			}
		}

		// Token: 0x0600B1EC RID: 45548 RVA: 0x004D9E64 File Offset: 0x004D8064
		public void DEICNAGAGJP()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 45;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 0;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 58;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("<b>Speed Hack Detector</b>");
				Shader.DisableKeyword(" **** Error=");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("category");
				Shader.DisableKeyword("Billboards reference not set.");
			}
		}

		// Token: 0x0600B1ED RID: 45549 RVA: 0x004D8844 File Offset: 0x004D6A44
		public void KJJBBLDJHPD()
		{
			if (this.sharedMaterial)
			{
				this.BMEBKDKHCMM();
			}
		}

		// Token: 0x0600B1EE RID: 45550 RVA: 0x004D9E4F File Offset: 0x004D804F
		public void DHDGPGOONBC()
		{
			if (this.sharedMaterial)
			{
				this.MJCBMPIEKNN();
			}
		}

		// Token: 0x0600B1EF RID: 45551 RVA: 0x004D9F24 File Offset: 0x004D8124
		public void EFHGGFEKAGP()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -118;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -133;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 74;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("_WaveScale");
				Shader.DisableKeyword("__c");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("Flares");
				Shader.DisableKeyword("type_");
			}
		}

		// Token: 0x0600B1F0 RID: 45552 RVA: 0x004D9FE4 File Offset: 0x004D81E4
		public void CPMGLGLDHCB()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 28;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 147;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 197;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("wpn_add/addoptions/klevprop");
				Shader.DisableKeyword("wpn_cat4");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("prisefond");
				Shader.DisableKeyword("some kind of resizing horror");
			}
		}

		// Token: 0x0600B1F1 RID: 45553 RVA: 0x004DA0A4 File Offset: 0x004D82A4
		public void CJHBCHBOLBI()
		{
			if (this.sharedMaterial)
			{
				this.EIHAMJKAKKG();
			}
		}

		// Token: 0x0600B1F2 RID: 45554 RVA: 0x004DA0BC File Offset: 0x004D82BC
		public void BMMIHAJKAFE()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -122;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 62;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 80;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("IdleSpew");
				Shader.DisableKeyword("WalkInjured");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("_Axis");
				Shader.DisableKeyword("_VelTex");
			}
		}

		// Token: 0x0600B1F3 RID: 45555 RVA: 0x004D8844 File Offset: 0x004D6A44
		public void KLFPOILLKDF()
		{
			if (this.sharedMaterial)
			{
				this.BMEBKDKHCMM();
			}
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x004DA17C File Offset: 0x004D837C
		public void EDEODHDFANE()
		{
			if (this.sharedMaterial)
			{
				this.PADOPPAIIFM();
			}
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void KMMINDLBNBJ(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B1F6 RID: 45558 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void KCOFBPBABGF(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x004DA194 File Offset: 0x004D8394
		public void NBNICGFIPBC()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -164;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -26;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 120;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("_Metrics");
				Shader.DisableKeyword("IdleTurns");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("Mech");
				Shader.DisableKeyword("MidBlendLut");
			}
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x004DA254 File Offset: 0x004D8454
		public void AMDMCKIFBPA()
		{
			if (this.sharedMaterial)
			{
				this.FCPNFCGLOAH();
			}
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x004D850C File Offset: 0x004D670C
		public void BGPPMFDGNBJ(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1FA RID: 45562 RVA: 0x004DA269 File Offset: 0x004D8469
		public void AAEFACEGJMB()
		{
			if (this.sharedMaterial)
			{
				this.HOOFICFEFGD();
			}
		}

		// Token: 0x0600B1FB RID: 45563 RVA: 0x004DA280 File Offset: 0x004D8480
		public void AJOBIKKLCPF()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 35;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -129;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 15;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_interaction_system.html");
				Shader.DisableKeyword("pelvis");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("IKMappingLimb is referencing to a bone '");
				Shader.DisableKeyword("sunshine_ShadowCoordDepthStart");
			}
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x004D850C File Offset: 0x004D670C
		public void MDGEHGHGHPC(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1FD RID: 45565 RVA: 0x004DA340 File Offset: 0x004D8540
		public void MEIOHFKFEME()
		{
			if (this.sharedMaterial)
			{
				this.AOLOBKGAIAA();
			}
		}

		// Token: 0x0600B1FE RID: 45566 RVA: 0x004D850C File Offset: 0x004D670C
		public void KKHGOBOHEPN(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B1FF RID: 45567 RVA: 0x004D850C File Offset: 0x004D670C
		public void BHCCJFONEFM(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B200 RID: 45568 RVA: 0x004DA358 File Offset: 0x004D8558
		public void LBEKGNLKJJJ()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 117;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 64;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -116;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("costwpn=");
				Shader.DisableKeyword("dir");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("WoodSaw");
				Shader.DisableKeyword("WateringCanWatering");
			}
		}

		// Token: 0x0600B201 RID: 45569 RVA: 0x004DA418 File Offset: 0x004D8618
		public void LDGOLGNOFJP()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 23;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 158;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -94;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("OneHandSwordReady");
				Shader.DisableKeyword("VIGNETTE_FILMIC");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("_TapMedium");
				Shader.DisableKeyword("<color='#000000'>--------------------------------------------------------</color>");
			}
		}

		// Token: 0x0600B202 RID: 45570 RVA: 0x004DA4D8 File Offset: 0x004D86D8
		public void LHBDFAHFNOK()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -6;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 77;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 104;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("WandAttack");
				Shader.DisableKeyword("IceHockey Goalie Ready");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("UI_DynamicWindow");
				Shader.DisableKeyword("null");
			}
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x004D850C File Offset: 0x004D670C
		public void MLBEPLKPFHO(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x004D850C File Offset: 0x004D670C
		public void LEKLDJFOJAI(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B205 RID: 45573 RVA: 0x004D850C File Offset: 0x004D670C
		public void LOOEOMGFBGM(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B206 RID: 45574 RVA: 0x004DA598 File Offset: 0x004D8798
		public void PADOPPAIIFM()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -134;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -135;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 189;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("Y (G)");
				Shader.DisableKeyword("ignorelist");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("shop_t14");
				Shader.DisableKeyword("{0} FPS");
			}
		}

		// Token: 0x0600B207 RID: 45575 RVA: 0x004DA658 File Offset: 0x004D8858
		public void IPOGJHOHFDL()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -120;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -120;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -39;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("{not_found}");
				Shader.DisableKeyword("Footsteps");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("_Offsets");
				Shader.DisableKeyword("cnt_energ");
			}
		}

		// Token: 0x0600B208 RID: 45576 RVA: 0x004DA718 File Offset: 0x004D8918
		public void EIHAMJKAKKG()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -17;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -41;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -128;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword(" (hair opaque)");
				Shader.DisableKeyword("Error");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("_FresnelFade");
				Shader.DisableKeyword("_MinVelocity");
			}
		}

		// Token: 0x0600B209 RID: 45577 RVA: 0x004DA7D8 File Offset: 0x004D89D8
		public void FKHAKIKPFFO()
		{
			if (this.sharedMaterial)
			{
				this.AONEMNOIDKN();
			}
		}

		// Token: 0x0600B20A RID: 45578 RVA: 0x004D8844 File Offset: 0x004D6A44
		public void IANJLHIIGLN()
		{
			if (this.sharedMaterial)
			{
				this.BMEBKDKHCMM();
			}
		}

		// Token: 0x0600B20B RID: 45579 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void EOCJAEMELDE(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B20C RID: 45580 RVA: 0x004DA7ED File Offset: 0x004D89ED
		public void HJCLNJLADKL()
		{
			if (this.sharedMaterial)
			{
				this.IPOGJHOHFDL();
			}
		}

		// Token: 0x0600B20D RID: 45581 RVA: 0x004DA804 File Offset: 0x004D8A04
		public void EHJILFJHOCJ()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -32;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 134;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -108;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("IdleFly");
				Shader.DisableKeyword("Worker Pickaxe");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("");
				Shader.DisableKeyword(" x");
			}
		}

		// Token: 0x0600B20E RID: 45582 RVA: 0x004D97A2 File Offset: 0x004D79A2
		public void HNMODJBBKBI()
		{
			if (this.sharedMaterial)
			{
				this.PIPEIGJDDLG();
			}
		}

		// Token: 0x0600B20F RID: 45583 RVA: 0x004DA8C4 File Offset: 0x004D8AC4
		public void CFEKBDAPBLC()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -113;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 64;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -124;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("");
				Shader.DisableKeyword("Neck");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("IdleStrafeRight");
				Shader.DisableKeyword("fanfare.wav");
			}
		}

		// Token: 0x0600B210 RID: 45584 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void FNKNJCMBAND(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B211 RID: 45585 RVA: 0x004DA984 File Offset: 0x004D8B84
		public void LFJHDHPJOPE()
		{
			if (this.sharedMaterial)
			{
				this.LHBDFAHFNOK();
			}
		}

		// Token: 0x0600B212 RID: 45586 RVA: 0x004D850C File Offset: 0x004D670C
		public void OJLNFCEAMDM(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B213 RID: 45587 RVA: 0x004D850C File Offset: 0x004D670C
		public void DLMLACACBHN(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B214 RID: 45588 RVA: 0x004DA99C File Offset: 0x004D8B9C
		public void JCOFGAMGPIP()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 156;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -96;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -95;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("wpn_eat4");
				Shader.DisableKeyword("Giant3HitCombo2");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("MidBlendLut");
				Shader.DisableKeyword("text");
			}
		}

		// Token: 0x0600B215 RID: 45589 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void BMGBAHBFBAH(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B216 RID: 45590 RVA: 0x004D850C File Offset: 0x004D670C
		public void CHDHAKCAOAD(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B217 RID: 45591 RVA: 0x004DAA5C File Offset: 0x004D8C5C
		public void PIPEIGJDDLG()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -90;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 41;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 51;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("Hey, you can't change me in memory!");
				Shader.DisableKeyword("CATRigL");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("26");
				Shader.DisableKeyword("buykey");
			}
		}

		// Token: 0x0600B218 RID: 45592 RVA: 0x004D8F84 File Offset: 0x004D7184
		public void IEOICHPKEMD()
		{
			if (this.sharedMaterial)
			{
				this.NBNICGFIPBC();
			}
		}

		// Token: 0x0600B219 RID: 45593 RVA: 0x004DAB1C File Offset: 0x004D8D1C
		public void GGNKNIDNOHN()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 36;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -51;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 142;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("_ReflectionBufferSize");
				Shader.DisableKeyword("WalkDehydrated");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("</color>");
				Shader.DisableKeyword("Orthographic");
			}
		}

		// Token: 0x0600B21A RID: 45594 RVA: 0x004DABDC File Offset: 0x004D8DDC
		public void ANGLCGONAON()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -143;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 121;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 26;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = false;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("C");
				Shader.DisableKeyword("position");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("_Offsets");
				Shader.DisableKeyword("gi_frac_max");
			}
		}

		// Token: 0x0600B21B RID: 45595 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void LCOJBNJCCGP(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B21C RID: 45596 RVA: 0x004D850C File Offset: 0x004D670C
		public void DHCCCDPDOKE(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B21D RID: 45597 RVA: 0x004D850C File Offset: 0x004D670C
		public void EEAKLLGKIMH(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B21E RID: 45598 RVA: 0x004DAC9C File Offset: 0x004D8E9C
		public void FCPNFCGLOAH()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -171;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 23;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 52;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("<color='#FF8C42'>[{2}]</color> <color='#FF8C42'>{0}: {1}</color>");
				Shader.DisableKeyword("Hidden/Post FX/Grain Generator");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("Mouse ScrollWheel");
				Shader.DisableKeyword("Titul");
			}
		}

		// Token: 0x0600B21F RID: 45599 RVA: 0x004DAD5C File Offset: 0x004D8F5C
		public void BBFCMCAFOMH()
		{
			if (this.sharedMaterial)
			{
				this.ANGLCGONAON();
			}
		}

		// Token: 0x0600B220 RID: 45600 RVA: 0x004DAD74 File Offset: 0x004D8F74
		public void MCEAMNKJANN()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = -181;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 19;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -29;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("_Intensity");
				Shader.DisableKeyword("");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("https://www.youtube.com/watch?v=tgRMsTphjJo");
				Shader.DisableKeyword("1HandSwordJabCombo");
			}
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x004DAE34 File Offset: 0x004D9034
		public void DEPPBFBDOLB()
		{
			if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = -76;
			}
			else if (this.waterQuality > PKDAFAELGDN.Low)
			{
				this.sharedMaterial.shader.maximumLOD = 65;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = 189;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("_BgColor");
				Shader.DisableKeyword("RollerBladeRoll");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.Depth;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("");
				Shader.DisableKeyword("IdleReadyCrouch");
			}
		}

		// Token: 0x0600B222 RID: 45602 RVA: 0x004D850C File Offset: 0x004D670C
		public void ONKGDNDDMCC(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x004D850C File Offset: 0x004D670C
		public void PNDAGKJKIID(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.Depth;
			}
		}

		// Token: 0x0600B224 RID: 45604 RVA: 0x004DAEF4 File Offset: 0x004D90F4
		public void EMHGNEMIGII()
		{
			if (this.sharedMaterial)
			{
				this.BDBLFNPGEJA();
			}
		}

		// Token: 0x0600B225 RID: 45605 RVA: 0x004DAF0C File Offset: 0x004D910C
		public void DGFENFPMNFG()
		{
			if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 49;
			}
			else if (this.waterQuality > PKDAFAELGDN.Medium)
			{
				this.sharedMaterial.shader.maximumLOD = 112;
			}
			else
			{
				this.sharedMaterial.shader.maximumLOD = -88;
			}
			if (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.edgeBlend = true;
			}
			if (this.edgeBlend)
			{
				Shader.EnableKeyword("");
				Shader.DisableKeyword("_ZWrite");
				if (Camera.main)
				{
					Camera.main.depthTextureMode |= DepthTextureMode.None;
					return;
				}
			}
			else
			{
				Shader.EnableKeyword("catid");
				Shader.DisableKeyword("_info");
			}
		}

		// Token: 0x0600B226 RID: 45606 RVA: 0x004D8AB4 File Offset: 0x004D6CB4
		public void BHCFIAAJGOE(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			if (NKMIENLLMCJ && this.edgeBlend)
			{
				NKMIENLLMCJ.depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600B227 RID: 45607 RVA: 0x004DAFCC File Offset: 0x004D91CC
		public void HCDJABMBDFF()
		{
			if (this.sharedMaterial)
			{
				this.DEPPBFBDOLB();
			}
		}

		// Token: 0x0400168D RID: 5773
		public Material sharedMaterial;

		// Token: 0x0400168E RID: 5774
		public PKDAFAELGDN waterQuality = PKDAFAELGDN.High;

		// Token: 0x0400168F RID: 5775
		public bool edgeBlend = true;
	}
}
