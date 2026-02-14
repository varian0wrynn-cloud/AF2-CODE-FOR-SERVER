using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000383 RID: 899
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Lens Aberrations")]
	public class LensAberrations : MonoBehaviour
	{
		// Token: 0x0600C358 RID: 50008 RVA: 0x00581AD2 File Offset: 0x0057FCD2
		public Material KAMHMEEIKPC()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.ANOIKBOFFCL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C359 RID: 50009 RVA: 0x00581AF9 File Offset: 0x0057FCF9
		private void AMGINIANPFJ()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.KLCBDOLKFEP(), false, true, this))
			{
				base.enabled = false;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C35A RID: 50010 RVA: 0x00581B1D File Offset: 0x0057FD1D
		private void IIKEIPNNLCG()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.OHLNIGLKOEN();
		}

		// Token: 0x0600C35B RID: 50011 RVA: 0x00581B4A File Offset: 0x0057FD4A
		private void DEGFGIDFFLD()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.OEDBNKPMCAK(), false, true, this))
			{
				base.enabled = false;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C35C RID: 50012 RVA: 0x00581B6E File Offset: 0x0057FD6E
		private void FLFFEJFEPHF()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.IFDFEOEAKOF();
		}

		// Token: 0x0600C35D RID: 50013 RVA: 0x00581B9B File Offset: 0x0057FD9B
		private void AHPHMMJMKOG()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.ANOIKBOFFCL(), true, false, this))
			{
				base.enabled = true;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C35E RID: 50014 RVA: 0x00581BBF File Offset: 0x0057FDBF
		private void OBNLNABALKH()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.BNCCHENNGMA(), true, false, this))
			{
				base.enabled = false;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C35F RID: 50015 RVA: 0x00581BE3 File Offset: 0x0057FDE3
		public Material KKHHDHBMFJB()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KLCBDOLKFEP());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C360 RID: 50016 RVA: 0x00581B1D File Offset: 0x0057FD1D
		private void LFJPJFCLGKE()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.OHLNIGLKOEN();
		}

		// Token: 0x0600C361 RID: 50017 RVA: 0x00581C0C File Offset: 0x0057FE0C
		private void AEDNIALODPG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.CLBIDDJOLHP().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 764f * Math.Max(Mathf.Abs(this.distortion.amount), 581f);
				float num = 111f * Math.Min(1649f, val);
				float y = 1628f * Mathf.Tan(num * 780f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 796f), Mathf.Max(this.distortion.amountY, 1379f));
				Vector3 v = new Vector3((this.distortion.amount >= 1956f) ? num : (1278f / num), y, 1750f / this.distortion.scale);
				this.CFJAMJGLPBF().EnableKeyword((this.distortion.amount >= 481f) ? "\\" : "Textures/alphaDemo");
				this.DEEJGFMDJBB().SetVector("OneHandSwordBlock", value);
				this.CDHGPDDEKDF().SetVector("\n", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.CDHGPDDEKDF().EnableKeyword("Hips");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1601f);
				this.LGPOFGEJNJJ().SetVector("post_2", value2);
			}
			if (this.vignette.enabled)
			{
				this.KIBLMGMPOJD().SetColor("", this.vignette.color);
				if (this.vignette.blur > 1516f)
				{
					int num2 = JONJODLFAEN.width / 5;
					int num3 = JONJODLFAEN.height / 1;
					RenderTexture renderTexture = this.JEIFLMLLOLG.CLEEDKHNPED(num2, num3, 1, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.GCJFOMJCFHM(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					this.IKDCAALOEEG().SetVector("", new Vector2(1028f / (float)num2, 1200f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.LLCJHFGBGDN(), 1);
					if (this.distortion.enabled)
					{
						this.KABDJNIDNDC().DisableKeyword("Idle Keep Back");
						this.CLBIDDJOLHP().DisableKeyword("KatanaReadyLow");
					}
					this.AGEHKELMAFL().SetVector(" ", new Vector2(1806f, 177f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.CJOMCEBOFKB(), 0);
					this.AMKGEAODCKK().SetVector("demoQuaternion", new Vector2(1205f / (float)num2, 342f));
					Graphics.Blit(renderTexture2, renderTexture, this.CLBIDDJOLHP(), 0);
					this.KKHHDHBMFJB().SetVector("ZombieCrawl", new Vector2(404f, 953f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.DJDKHEANJNM(), 0);
					this.DJDKHEANJNM().SetTexture("Sound #", renderTexture2);
					this.KIBLMGMPOJD().SetFloat("isLocalServer", this.vignette.blur * 907f);
					this.IHAKFMDJEGK().EnableKeyword("TextureLoader: ");
					if (this.distortion.enabled)
					{
						this.KAMHMEEIKPC().EnableKeyword((this.distortion.amount >= 733f) ? "_NoiseTex" : "Shaders/EyeHistogram");
					}
				}
				if (this.vignette.desaturate > 501f)
				{
					this.IKDCAALOEEG().EnableKeyword("MotorbikeSeatStandWheely");
					this.ADBDAKNGHHG().SetFloat("MotorbikeShootLeft", 1632f - this.vignette.desaturate);
				}
				this.ADBDAKNGHHG().SetVector("KatanaReady", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 125f))
				{
					this.CLAEAFBEJNN().EnableKeyword("componentA=");
					this.DJDKHEANJNM().SetVector("HitWeight", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.CJOMCEBOFKB().EnableKeyword("fishdrop_3");
					float z = (1785f - this.vignette.roundness) * 350f + this.vignette.roundness;
					this.LGPOFGEJNJJ().SetVector("<color='#003000'>+{0} {1}</color>", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 7;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 3;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled)
			{
				pass = 1;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 7;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.KKHHDHBMFJB(), pass);
			this.JEIFLMLLOLG.IFBAMKOGBFI();
		}

		// Token: 0x0600C362 RID: 50018 RVA: 0x005821F1 File Offset: 0x005803F1
		public Material CDHGPDDEKDF()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.BNCCHENNGMA());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C363 RID: 50019 RVA: 0x00582218 File Offset: 0x00580418
		private void LLLBNNNNFPJ()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.GDDOAILGPBD();
		}

		// Token: 0x0600C364 RID: 50020 RVA: 0x00581B9B File Offset: 0x0057FD9B
		private void LAHNGMMPPIM()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.ANOIKBOFFCL(), true, false, this))
			{
				base.enabled = true;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C365 RID: 50021 RVA: 0x00582245 File Offset: 0x00580445
		public Shader KPIAFEFGHIP()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("SneakRight");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C366 RID: 50022 RVA: 0x0058226C File Offset: 0x0058046C
		private void EAODOAGNHIK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.IKDCAALOEEG().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1643f * Math.Max(Mathf.Abs(this.distortion.amount), 762f);
				float num = 831f * Math.Min(791f, val);
				float y = 1955f * Mathf.Tan(num * 345f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 70f), Mathf.Max(this.distortion.amountY, 119f));
				Vector3 v = new Vector3((this.distortion.amount >= 1688f) ? num : (1554f / num), y, 1666f / this.distortion.scale);
				this.IOIGFMMJKNA().EnableKeyword((this.distortion.amount >= 453f) ? "ObscuredVector3:" : "RollerBladeSkateFwd");
				this.CLBIDDJOLHP().SetVector("", value);
				this.AMKGEAODCKK().SetVector("_TintColor", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.COCHPLKIEGO().EnableKeyword("1HandSwordChargeHeavyBash");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1153f);
				this.AGEHKELMAFL().SetVector("Idle180", value2);
			}
			if (this.vignette.enabled)
			{
				this.DEEJGFMDJBB().SetColor("ShotgunFire", this.vignette.color);
				if (this.vignette.blur > 232f)
				{
					int num2 = JONJODLFAEN.width / 1;
					int num3 = JONJODLFAEN.height / 6;
					RenderTexture renderTexture = this.JEIFLMLLOLG.HAIACDDDOCD(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.ACIOKBMAHMH(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					this.KABDJNIDNDC().SetVector("crft_to", new Vector2(1854f / (float)num2, 504f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.IHAKFMDJEGK(), 0);
					if (this.distortion.enabled)
					{
						this.KABDJNIDNDC().DisableKeyword("B");
						this.IKDCAALOEEG().DisableKeyword("_WaveScale");
					}
					this.IKDCAALOEEG().SetVector("\n<color='", new Vector2(1034f, 1057f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.JMDMNMEHAPM(), 0);
					this.KAMHMEEIKPC().SetVector("auk_wmax", new Vector2(1000f / (float)num2, 984f));
					Graphics.Blit(renderTexture2, renderTexture, this.CLBIDDJOLHP(), 1);
					this.LLCJHFGBGDN().SetVector("4 samples", new Vector2(1410f, 692f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.CBHFHFDMLKM(), 0);
					this.CFJAMJGLPBF().SetTexture("_Intensity", renderTexture2);
					this.CJOMCEBOFKB().SetFloat("isRodInWater", this.vignette.blur * 727f);
					this.NMIDGHFFOBD().EnableKeyword("minimalLevel");
					if (this.distortion.enabled)
					{
						this.CJOMCEBOFKB().EnableKeyword((this.distortion.amount >= 493f) ? "enable" : "RollerBladeRoll");
					}
				}
				if (this.vignette.desaturate > 1682f)
				{
					this.KABDJNIDNDC().EnableKeyword("StartControllerModule");
					this.DJDKHEANJNM().SetFloat("showUsersInChat", 1406f - this.vignette.desaturate);
				}
				this.AGEHKELMAFL().SetVector("fshop_hd2", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1371f))
				{
					this.DNCJDOFOENA().EnableKeyword(" ");
					this.AMKGEAODCKK().SetVector("_camHue", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.LGPOFGEJNJJ().EnableKeyword("knopje.wav");
					float z = (1269f - this.vignette.roundness) * 264f + this.vignette.roundness;
					this.DEEJGFMDJBB().SetVector("Mouse Y", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 2;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 4;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 4;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 4;
			}
			else if (this.vignette.enabled)
			{
				pass = 0;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 6;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.CFJAMJGLPBF(), pass);
			this.JEIFLMLLOLG.NEKHAHOEDII();
		}

		// Token: 0x0600C367 RID: 50023 RVA: 0x00582851 File Offset: 0x00580A51
		private void FJBPGBMDBBF()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.ONPDCPAOPIB(), true, false, this))
			{
				base.enabled = false;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C368 RID: 50024 RVA: 0x00582878 File Offset: 0x00580A78
		private void IAPMIJOBNKG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.CLAEAFBEJNN().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 409f * Math.Max(Mathf.Abs(this.distortion.amount), 964f);
				float num = 258f * Math.Min(193f, val);
				float y = 155f * Mathf.Tan(num * 423f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 239f), Mathf.Max(this.distortion.amountY, 1167f));
				Vector3 v = new Vector3((this.distortion.amount >= 511f) ? num : (974f / num), y, 922f / this.distortion.scale);
				this.MHNAJNGGDFJ.EnableKeyword((this.distortion.amount >= 1572f) ? "UnityEngine." : "gi_um_9");
				this.KKHHDHBMFJB().SetVector("CheerJump", value);
				this.NMIDGHFFOBD().SetVector("Sonar_pos", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.LLCJHFGBGDN().EnableKeyword("GestureNoFear");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1687f);
				this.DNCJDOFOENA().SetVector("---", value2);
			}
			if (this.vignette.enabled)
			{
				this.IHAKFMDJEGK().SetColor("ThisRenderer.bones[i] is null i=", this.vignette.color);
				if (this.vignette.blur > 1545f)
				{
					int num2 = JONJODLFAEN.width / 1;
					int num3 = JONJODLFAEN.height / 4;
					RenderTexture renderTexture = this.JEIFLMLLOLG.BJDKCJNLAMO(num2, num3, 0, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.BOFBBOPNHKG(num2, num3, 0, JONJODLFAEN.format, FilterMode.Point);
					this.CDHGPDDEKDF().SetVector("#url Sound ", new Vector2(1409f / (float)num2, 100f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.AMKGEAODCKK(), 0);
					if (this.distortion.enabled)
					{
						this.IHAKFMDJEGK().DisableKeyword("");
						this.CJOMCEBOFKB().DisableKeyword("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_full_body_biped_i_k.html");
					}
					this.HFABMCCBNMB().SetVector("X", new Vector2(1470f, 190f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.LGPOFGEJNJJ(), 1);
					this.KAMHMEEIKPC().SetVector("cht_msg38", new Vector2(1553f / (float)num2, 1083f));
					Graphics.Blit(renderTexture2, renderTexture, this.OMDJPBECNBJ(), 0);
					this.CJOMCEBOFKB().SetVector("Flap_08.wav", new Vector2(1793f, 758f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KABDJNIDNDC(), 0);
					this.NMIDGHFFOBD().SetTexture("Windows/", renderTexture2);
					this.KABDJNIDNDC().SetFloat("[ACTk] Obscured Cheating Detector: has properly configured Detection Event in the inspector, but still get started with Action callback. Both Action and Detection Event will be called on detection. Are you sure you wish to do this?", this.vignette.blur * 1668f);
					this.CBHFHFDMLKM().EnableKeyword("WaterQuad");
					if (this.distortion.enabled)
					{
						this.ALDNDLLLPCO().EnableKeyword((this.distortion.amount >= 336f) ? "Tail" : "ClimbUp");
					}
				}
				if (this.vignette.desaturate > 1434f)
				{
					this.HFABMCCBNMB().EnableKeyword("IdleStand");
					this.ALDNDLLLPCO().SetFloat("Idle Die", 1976f - this.vignette.desaturate);
				}
				this.LGPOFGEJNJJ().SetVector("Shaders/EyeHistogram", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1465f))
				{
					this.DEEJGFMDJBB().EnableKeyword("Road Points Marker");
					this.AMKGEAODCKK().SetVector("Transforms is null.", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.LGPOFGEJNJJ().EnableKeyword("_RampTex");
					float z = (816f - this.vignette.roundness) * 1758f + this.vignette.roundness;
					this.HFABMCCBNMB().SetVector("Wizard2HandThrow", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 2;
			}
			else if (this.vignette.enabled)
			{
				pass = 0;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 4;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.CDHGPDDEKDF(), pass);
			this.JEIFLMLLOLG.KEFNLEEAINH();
		}

		// Token: 0x0600C369 RID: 50025 RVA: 0x00582E60 File Offset: 0x00581060
		private void OJBKOLJAHAO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.CDHGPDDEKDF().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1265f * Math.Max(Mathf.Abs(this.distortion.amount), 965f);
				float num = 927f * Math.Min(487f, val);
				float y = 80f * Mathf.Tan(num * 1085f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1007f), Mathf.Max(this.distortion.amountY, 223f));
				Vector3 v = new Vector3((this.distortion.amount >= 1366f) ? num : (349f / num), y, 1463f / this.distortion.scale);
				this.LGPOFGEJNJJ().EnableKeyword((this.distortion.amount >= 219f) ? "0" : "KatanaReady");
				this.COCHPLKIEGO().SetVector("I'm regular string", value);
				this.IOIGFMMJKNA().SetVector("_TempTexture", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.MHNAJNGGDFJ.EnableKeyword("I");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 879f);
				this.LLCJHFGBGDN().SetVector("name", value2);
			}
			if (this.vignette.enabled)
			{
				this.IKDCAALOEEG().SetColor("repair.ogg", this.vignette.color);
				if (this.vignette.blur > 1544f)
				{
					int num2 = JONJODLFAEN.width / 7;
					int num3 = JONJODLFAEN.height / 6;
					RenderTexture renderTexture = this.JEIFLMLLOLG.BOFBBOPNHKG(num2, num3, 1, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.GIDNDCIFACD(num2, num3, 0, JONJODLFAEN.format, FilterMode.Point);
					this.CJOMCEBOFKB().SetVector("Forward", new Vector2(1768f / (float)num2, 534f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.IHAKFMDJEGK(), 1);
					if (this.distortion.enabled)
					{
						this.DJDKHEANJNM().DisableKeyword("http://www.root-motion.com/finalikdox/html/page8.html");
						this.LGPOFGEJNJJ().DisableKeyword("adjust");
					}
					this.DNCJDOFOENA().SetVector("OfficeSittingReadingPageFlip", new Vector2(1641f, 1247f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.CBHFHFDMLKM(), 1);
					this.JMDMNMEHAPM().SetVector("_FogDownsampled", new Vector2(76f / (float)num2, 1748f));
					Graphics.Blit(renderTexture2, renderTexture, this.NMIDGHFFOBD(), 1);
					this.DEEJGFMDJBB().SetVector("", new Vector2(1312f, 769f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.CDHGPDDEKDF(), 1);
					this.AMKGEAODCKK().SetTexture("IdleStrafeLeft", renderTexture2);
					this.CFJAMJGLPBF().SetFloat("Giant2HandSlamIdle", this.vignette.blur * 121f);
					this.AGEHKELMAFL().EnableKeyword("1HandSwordShieldBash");
					if (this.distortion.enabled)
					{
						this.NMIDGHFFOBD().EnableKeyword((this.distortion.amount >= 1685f) ? "crft_costwp" : "Failed parsing atlas group.  Setting to group 0");
					}
				}
				if (this.vignette.desaturate > 468f)
				{
					this.MHNAJNGGDFJ.EnableKeyword("UV0");
					this.DJDKHEANJNM().SetFloat("SkateboardKickPush", 1654f - this.vignette.desaturate);
				}
				this.CDHGPDDEKDF().SetVector("_ProjInfoRight", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1749f))
				{
					this.HFABMCCBNMB().EnableKeyword("money");
					this.DNCJDOFOENA().SetVector("_Offsets", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.ALDNDLLLPCO().EnableKeyword("KatanaReadyLow");
					float z = (1342f - this.vignette.roundness) * 454f + this.vignette.roundness;
					this.IHAKFMDJEGK().SetVector("", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 7;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 2;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 7;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled)
			{
				pass = 3;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 8;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IOIGFMMJKNA(), pass);
			this.JEIFLMLLOLG.KFLDHJKBEHN();
		}

		// Token: 0x0600C36A RID: 50026 RVA: 0x00583445 File Offset: 0x00581645
		public Shader ANOIKBOFFCL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("knopje.wav");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C36C RID: 50028 RVA: 0x00583494 File Offset: 0x00581694
		public Material LLCJHFGBGDN()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.GLEKFBOEOJJ());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C36D RID: 50029 RVA: 0x005834BC File Offset: 0x005816BC
		private void NHDCFLGBCNE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.MHNAJNGGDFJ.shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1356f * Math.Max(Mathf.Abs(this.distortion.amount), 1014f);
				float num = 62f * Math.Min(1663f, val);
				float y = 1923f * Mathf.Tan(num * 402f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 766f), Mathf.Max(this.distortion.amountY, 577f));
				Vector3 v = new Vector3((this.distortion.amount >= 967f) ? num : (340f / num), y, 319f / this.distortion.scale);
				this.CDHGPDDEKDF().EnableKeyword((this.distortion.amount >= 763f) ? "isRealView" : "id");
				this.CLBIDDJOLHP().SetVector("RollerBladeFrontFlip", value);
				this.NMIDGHFFOBD().SetVector("CHROMATIC_ABERRATION", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.LGPOFGEJNJJ().EnableKeyword("full");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 147f);
				this.CLBIDDJOLHP().SetVector("SoccerKeeperDiveStrafeFarLeft", value2);
			}
			if (this.vignette.enabled)
			{
				this.CLAEAFBEJNN().SetColor("_BlurSize", this.vignette.color);
				if (this.vignette.blur > 1952f)
				{
					int num2 = JONJODLFAEN.width / 0;
					int num3 = JONJODLFAEN.height / 0;
					RenderTexture renderTexture = this.JEIFLMLLOLG.BKEEIBKHILH(num2, num3, 1, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.BJDKCJNLAMO(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					this.CLAEAFBEJNN().SetVector("_NoiseTex", new Vector2(661f / (float)num2, 1006f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.AGEHKELMAFL(), 0);
					if (this.distortion.enabled)
					{
						this.DNCJDOFOENA().DisableKeyword("\n");
						this.AGEHKELMAFL().DisableKeyword("B");
					}
					this.CBHFHFDMLKM().SetVector("</color>", new Vector2(1532f, 615f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.DEEJGFMDJBB(), 1);
					this.ADBDAKNGHHG().SetVector("_DistanceParams", new Vector2(1979f / (float)num2, 727f));
					Graphics.Blit(renderTexture2, renderTexture, this.AGEHKELMAFL(), 1);
					this.COCHPLKIEGO().SetVector("colorA", new Vector2(596f, 1608f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.ADBDAKNGHHG(), 0);
					this.COCHPLKIEGO().SetTexture("repair.ogg", renderTexture2);
					this.DJDKHEANJNM().SetFloat("isend", this.vignette.blur * 77f);
					this.ADBDAKNGHHG().EnableKeyword("</i></color>");
					if (this.distortion.enabled)
					{
						this.CFJAMJGLPBF().EnableKeyword((this.distortion.amount >= 748f) ? "crunch.ogg" : "ArmFlex6");
					}
				}
				if (this.vignette.desaturate > 195f)
				{
					this.COCHPLKIEGO().EnableKeyword("Hidden/TonemappingColorGrading");
					this.KKHHDHBMFJB().SetFloat("The InteractionSystem has not been initiated yet.", 1223f - this.vignette.desaturate);
				}
				this.NMIDGHFFOBD().SetVector("Установлен <b>", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 364f))
				{
					this.MHNAJNGGDFJ.EnableKeyword("wgt_gr");
					this.LLCJHFGBGDN().SetVector("UnityEngine.Vector3", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.NMIDGHFFOBD().EnableKeyword("shop_t6");
					float z = (1167f - this.vignette.roundness) * 1916f + this.vignette.roundness;
					this.KABDJNIDNDC().SetVector("ObscuredBool:", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 7;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 7;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 4;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled)
			{
				pass = 7;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 7;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AGEHKELMAFL(), pass);
			this.JEIFLMLLOLG.ONDHPBGGNIA();
		}

		// Token: 0x0600C36E RID: 50030 RVA: 0x00583AA1 File Offset: 0x00581CA1
		private void NJJFDKFNBCL()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.GLEKFBOEOJJ(), true, true, this))
			{
				base.enabled = false;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C36F RID: 50031 RVA: 0x00583AC8 File Offset: 0x00581CC8
		private void GGIKBEHBAPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.LLCJHFGBGDN().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1436f * Math.Max(Mathf.Abs(this.distortion.amount), 782f);
				float num = 562f * Math.Min(738f, val);
				float y = 1205f * Mathf.Tan(num * 1775f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 98f), Mathf.Max(this.distortion.amountY, 1109f));
				Vector3 v = new Vector3((this.distortion.amount >= 1547f) ? num : (1434f / num), y, 608f / this.distortion.scale);
				this.IOIGFMMJKNA().EnableKeyword((this.distortion.amount >= 631f) ? "LocationGui.getI is null" : "UNDISTORT");
				this.CJOMCEBOFKB().SetVector("F3", value);
				this.JMDMNMEHAPM().SetVector("OneHandSwordSwing", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.CFJAMJGLPBF().EnableKeyword("Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off.");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 78f);
				this.DNCJDOFOENA().SetVector("cntx_close", value2);
			}
			if (this.vignette.enabled)
			{
				this.KIBLMGMPOJD().SetColor("and I needed", this.vignette.color);
				if (this.vignette.blur > 1329f)
				{
					int num2 = JONJODLFAEN.width / 3;
					int num3 = JONJODLFAEN.height / 4;
					RenderTexture renderTexture = this.JEIFLMLLOLG.EKNEEFEOGPH(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.BOFBBOPNHKG(num2, num3, 1, JONJODLFAEN.format, FilterMode.Point);
					this.DNCJDOFOENA().SetVector("showMetrInfo", new Vector2(163f / (float)num2, 908f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.ALDNDLLLPCO(), 0);
					if (this.distortion.enabled)
					{
						this.LLCJHFGBGDN().DisableKeyword("_Radius2");
						this.IKDCAALOEEG().DisableKeyword("Trying to initiate IKSolverVR with invalid bone references.");
					}
					this.KKHHDHBMFJB().SetVector("Transform is null.", new Vector2(1910f, 285f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.CFJAMJGLPBF(), 0);
					this.IHAKFMDJEGK().SetVector("inv already open", new Vector2(1636f / (float)num2, 838f));
					Graphics.Blit(renderTexture2, renderTexture, this.MHNAJNGGDFJ, 1);
					this.CJOMCEBOFKB().SetVector(" ", new Vector2(1058f, 1716f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.NMIDGHFFOBD(), 0);
					this.CLAEAFBEJNN().SetTexture("1=", renderTexture2);
					this.IHAKFMDJEGK().SetFloat("/", this.vignette.blur * 734f);
					this.HFABMCCBNMB().EnableKeyword("\n");
					if (this.distortion.enabled)
					{
						this.JMDMNMEHAPM().EnableKeyword((this.distortion.amount >= 296f) ? "Wand Stand" : "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_c_c_d_i_k.html");
					}
				}
				if (this.vignette.desaturate > 1488f)
				{
					this.AGEHKELMAFL().EnableKeyword("</i></color>");
					this.IKDCAALOEEG().SetFloat("WeaponStrafeRunLeft", 552f - this.vignette.desaturate);
				}
				this.ALDNDLLLPCO().SetVector(" has invalid children array. Child index > number of chains", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1485f))
				{
					this.COCHPLKIEGO().EnableKeyword("{0}Textures/Turnirs/{1}.png");
					this.KAMHMEEIKPC().SetVector("Called GetNumberOfCurrentPlayers()", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.CFJAMJGLPBF().EnableKeyword("loc_");
					float z = (610f - this.vignette.roundness) * 946f + this.vignette.roundness;
					this.CDHGPDDEKDF().SetVector("Cloth_01.wav", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 4;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 3;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 6;
			}
			else if (this.vignette.enabled)
			{
				pass = 6;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 2;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LLCJHFGBGDN(), pass);
			this.JEIFLMLLOLG.ABDMJODLKCB();
		}

		// Token: 0x0600C370 RID: 50032 RVA: 0x005840B0 File Offset: 0x005822B0
		private void NBJKFLNHFOF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.CLBIDDJOLHP().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1139f * Math.Max(Mathf.Abs(this.distortion.amount), 448f);
				float num = 1430f * Math.Min(1225f, val);
				float y = 1232f * Mathf.Tan(num * 459f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1394f), Mathf.Max(this.distortion.amountY, 390f));
				Vector3 v = new Vector3((this.distortion.amount >= 472f) ? num : (559f / num), y, 103f / this.distortion.scale);
				this.CLAEAFBEJNN().EnableKeyword((this.distortion.amount >= 1196f) ? "wpn_eat8" : "reel_type1");
				this.LGPOFGEJNJJ().SetVector("", value);
				this.CDHGPDDEKDF().SetVector("WizardOverhead", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.IHAKFMDJEGK().EnableKeyword("__b");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1716f);
				this.IOIGFMMJKNA().SetVector("RollerBladeCrossoverLeft", value2);
			}
			if (this.vignette.enabled)
			{
				this.DJDKHEANJNM().SetColor("val=", this.vignette.color);
				if (this.vignette.blur > 1582f)
				{
					int num2 = JONJODLFAEN.width / 0;
					int num3 = JONJODLFAEN.height / 0;
					RenderTexture renderTexture = this.JEIFLMLLOLG.EKNEEFEOGPH(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.OFFIEJNIOAL(num2, num3, 1, JONJODLFAEN.format, FilterMode.Point);
					this.CDHGPDDEKDF().SetVector("demoDouble", new Vector2(1156f / (float)num2, 265f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.DNCJDOFOENA(), 1);
					if (this.distortion.enabled)
					{
						this.CLAEAFBEJNN().DisableKeyword("RollerBladeTurnRight");
						this.CDHGPDDEKDF().DisableKeyword("_Intensity");
					}
					this.CLBIDDJOLHP().SetVector("IdleMouthWipe", new Vector2(412f, 1291f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.CLBIDDJOLHP(), 1);
					this.IKDCAALOEEG().SetVector("Quest langfile not found!", new Vector2(1559f / (float)num2, 1184f));
					Graphics.Blit(renderTexture2, renderTexture, this.AGEHKELMAFL(), 1);
					this.KIBLMGMPOJD().SetVector("RollerBladeStand", new Vector2(205f, 566f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KIBLMGMPOJD(), 1);
					this.CBHFHFDMLKM().SetTexture("NextFrame", renderTexture2);
					this.CLBIDDJOLHP().SetFloat("RollerBladeTurnLeft", this.vignette.blur * 363f);
					this.CJOMCEBOFKB().EnableKeyword("JNT_Root");
					if (this.distortion.enabled)
					{
						this.COCHPLKIEGO().EnableKeyword((this.distortion.amount >= 1466f) ? "_RefractionTex" : "BAG");
					}
				}
				if (this.vignette.desaturate > 757f)
				{
					this.LLCJHFGBGDN().EnableKeyword("rait_4");
					this.HFABMCCBNMB().SetFloat("Idle Walk", 1125f - this.vignette.desaturate);
				}
				this.ALDNDLLLPCO().SetVector("Pointing", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 251f))
				{
					this.KIBLMGMPOJD().EnableKeyword(" tm=");
					this.MHNAJNGGDFJ.SetVector("Horizontal", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.IOIGFMMJKNA().EnableKeyword("IdleTurns");
					float z = (1344f - this.vignette.roundness) * 1234f + this.vignette.roundness;
					this.LLCJHFGBGDN().SetVector("SexyDance2", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 1;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 1;
			}
			else if (this.vignette.enabled)
			{
				pass = 6;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 2;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NMIDGHFFOBD(), pass);
			this.JEIFLMLLOLG.IFBAMKOGBFI();
		}

		// Token: 0x0600C371 RID: 50033 RVA: 0x00584695 File Offset: 0x00582895
		public Shader JMNDOFCLCOL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Windows");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C372 RID: 50034 RVA: 0x005846BB File Offset: 0x005828BB
		private void OCIANPBJNND()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.EKFLJAGINLL(), true, true, this))
			{
				base.enabled = true;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C373 RID: 50035 RVA: 0x005846DF File Offset: 0x005828DF
		private void INEHANLJIEM()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.FJMJKCMFLML(), false, false, this))
			{
				base.enabled = true;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C374 RID: 50036 RVA: 0x00584703 File Offset: 0x00582903
		private void IIEOKJCJMHH()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.EKFLJAGINLL(), true, true, this))
			{
				base.enabled = false;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C375 RID: 50037 RVA: 0x00584728 File Offset: 0x00582928
		private void GFBELBBAJGD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.LLCJHFGBGDN().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 143f * Math.Max(Mathf.Abs(this.distortion.amount), 1978f);
				float num = 720f * Math.Min(1305f, val);
				float y = 82f * Mathf.Tan(num * 740f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 714f), Mathf.Max(this.distortion.amountY, 1276f));
				Vector3 v = new Vector3((this.distortion.amount >= 1871f) ? num : (208f / num), y, 1986f / this.distortion.scale);
				this.IOIGFMMJKNA().EnableKeyword((this.distortion.amount >= 1642f) ? "_InvRenderTargetSize" : "ObscuredUInt:");
				this.CDHGPDDEKDF().SetVector("WeaponStrafeRunLeft", value);
				this.IKDCAALOEEG().SetVector("***** Export OK", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.DNCJDOFOENA().EnableKeyword("1HandSwordChargeHeavyBash");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1338f);
				this.DEEJGFMDJBB().SetVector("MotorbikeLookBack", value2);
			}
			if (this.vignette.enabled)
			{
				this.CDHGPDDEKDF().SetColor("RunBackward", this.vignette.color);
				if (this.vignette.blur > 1598f)
				{
					int num2 = JONJODLFAEN.width / 8;
					int num3 = JONJODLFAEN.height / 3;
					RenderTexture renderTexture = this.JEIFLMLLOLG.LJFNLLAHDIM(num2, num3, 0, JONJODLFAEN.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.EBDILCDNIEJ(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					this.LGPOFGEJNJJ().SetVector("GiantGrabIdle", new Vector2(1311f / (float)num2, 768f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.AMKGEAODCKK(), 0);
					if (this.distortion.enabled)
					{
						this.KIBLMGMPOJD().DisableKeyword("no_time_period");
						this.IHAKFMDJEGK().DisableKeyword("cntx_close");
					}
					this.CLAEAFBEJNN().SetVector("", new Vector2(1797f, 1606f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KKHHDHBMFJB(), 1);
					this.CFJAMJGLPBF().SetVector("Start.tif", new Vector2(371f / (float)num2, 91f));
					Graphics.Blit(renderTexture2, renderTexture, this.NMIDGHFFOBD(), 1);
					this.LGPOFGEJNJJ().SetVector("DeadmanFloat", new Vector2(651f, 1517f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.CJOMCEBOFKB(), 1);
					this.ADBDAKNGHHG().SetTexture("act_order", renderTexture2);
					this.CJOMCEBOFKB().SetFloat("No saved PlayerPrefs!", this.vignette.blur * 357f);
					this.CFJAMJGLPBF().EnableKeyword("SkateboardKickPush");
					if (this.distortion.enabled)
					{
						this.KIBLMGMPOJD().EnableKeyword((this.distortion.amount >= 1652f) ? "WizardPowerUp" : "IdleFight");
					}
				}
				if (this.vignette.desaturate > 1817f)
				{
					this.JMDMNMEHAPM().EnableKeyword("SoccerTackle");
					this.OMDJPBECNBJ().SetFloat("FistPump", 262f - this.vignette.desaturate);
				}
				this.AMKGEAODCKK().SetVector("fishzone", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 410f))
				{
					this.OMDJPBECNBJ().EnableKeyword("DISTORT");
					this.CBHFHFDMLKM().SetVector("IdleStandingJump", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.IHAKFMDJEGK().EnableKeyword("<color='#6080ff'>");
					float z = (293f - this.vignette.roundness) * 1964f + this.vignette.roundness;
					this.CJOMCEBOFKB().SetVector("-UNDERLINE", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 2;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 2;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 0;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled)
			{
				pass = 3;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 2;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.NMIDGHFFOBD(), pass);
			this.JEIFLMLLOLG.IFDFEOEAKOF();
		}

		// Token: 0x0600C376 RID: 50038 RVA: 0x00584D0D File Offset: 0x00582F0D
		private void BIKPILOBGIE()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.NOPIBPGHFFB(), false, false, this))
			{
				base.enabled = true;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C377 RID: 50039 RVA: 0x00584D31 File Offset: 0x00582F31
		public Shader GLEKFBOEOJJ()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("ScatterDitherData");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C378 RID: 50040 RVA: 0x00584D58 File Offset: 0x00582F58
		private void CCIHPHKDIJL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.KABDJNIDNDC().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1607f * Math.Max(Mathf.Abs(this.distortion.amount), 87f);
				float num = 468f * Math.Min(173f, val);
				float y = 1930f * Mathf.Tan(num * 833f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 731f), Mathf.Max(this.distortion.amountY, 1488f));
				Vector3 v = new Vector3((this.distortion.amount >= 1160f) ? num : (334f / num), y, 66f / this.distortion.scale);
				this.HFABMCCBNMB().EnableKeyword((this.distortion.amount >= 1647f) ? "Bases/{0}/" : "repair.ogg");
				this.IHAKFMDJEGK().SetVector("invn_rec6", value);
				this.COCHPLKIEGO().SetVector("-none: ", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.CDHGPDDEKDF().EnableKeyword("_OcclusionTexture");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1111f);
				this.MHNAJNGGDFJ.SetVector("error.wav", value2);
			}
			if (this.vignette.enabled)
			{
				this.IOIGFMMJKNA().SetColor("ArmFlex5", this.vignette.color);
				if (this.vignette.blur > 1172f)
				{
					int num2 = JONJODLFAEN.width / 8;
					int num3 = JONJODLFAEN.height / 6;
					RenderTexture renderTexture = this.JEIFLMLLOLG.HGJGOJEFCPN(num2, num3, 1, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.KEIFPBPOIEB(num2, num3, 0, JONJODLFAEN.format, FilterMode.Point);
					this.CFJAMJGLPBF().SetVector("", new Vector2(1294f / (float)num2, 489f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.KAMHMEEIKPC(), 0);
					if (this.distortion.enabled)
					{
						this.CLBIDDJOLHP().DisableKeyword("long: ");
						this.MHNAJNGGDFJ.DisableKeyword("_Newitem.wav");
					}
					this.CFJAMJGLPBF().SetVector("Keeper Ready", new Vector2(32f, 1959f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.ALDNDLLLPCO(), 0);
					this.JMDMNMEHAPM().SetVector(" ", new Vector2(459f / (float)num2, 951f));
					Graphics.Blit(renderTexture2, renderTexture, this.LGPOFGEJNJJ(), 0);
					this.KIBLMGMPOJD().SetVector("post_2", new Vector2(1403f, 600f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KIBLMGMPOJD(), 1);
					this.ADBDAKNGHHG().SetTexture("Flap_08.wav", renderTexture2);
					this.CLBIDDJOLHP().SetFloat("FlyBackward", this.vignette.blur * 1931f);
					this.KABDJNIDNDC().EnableKeyword("Yawn");
					if (this.distortion.enabled)
					{
						this.IKDCAALOEEG().EnableKeyword((this.distortion.amount >= 1644f) ? "FaceHit" : " ");
					}
				}
				if (this.vignette.desaturate > 1346f)
				{
					this.CFJAMJGLPBF().EnableKeyword("crft_crft");
					this.IOIGFMMJKNA().SetFloat("Sunshine Project Configuration", 1670f - this.vignette.desaturate);
				}
				this.KAMHMEEIKPC().SetVector("none", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1228f))
				{
					this.HFABMCCBNMB().EnableKeyword("_");
					this.HFABMCCBNMB().SetVector("error.wav", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.CLBIDDJOLHP().EnableKeyword("_Balance");
					float z = (845f - this.vignette.roundness) * 194f + this.vignette.roundness;
					this.CJOMCEBOFKB().SetVector("PlayerPet", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 3;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled)
			{
				pass = 4;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 2;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.CLBIDDJOLHP(), pass);
			this.JEIFLMLLOLG.FMIMDCPJHMF();
		}

		// Token: 0x0600C379 RID: 50041 RVA: 0x00583494 File Offset: 0x00581694
		public Material OMDJPBECNBJ()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.GLEKFBOEOJJ());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x0600C37A RID: 50042 RVA: 0x0058533D File Offset: 0x0058353D
		public Shader BAKBIMBKKNP
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/LensAberrations");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x0600C37B RID: 50043 RVA: 0x00585364 File Offset: 0x00583564
		private void LOPLBCLLCID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.HFABMCCBNMB().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 935f * Math.Max(Mathf.Abs(this.distortion.amount), 1176f);
				float num = 450f * Math.Min(1537f, val);
				float y = 228f * Mathf.Tan(num * 1485f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 235f), Mathf.Max(this.distortion.amountY, 1763f));
				Vector3 v = new Vector3((this.distortion.amount >= 39f) ? num : (1320f / num), y, 1548f / this.distortion.scale);
				this.CFJAMJGLPBF().EnableKeyword((this.distortion.amount >= 875f) ? "WeaponReload" : "Idle Strafe Left");
				this.IKDCAALOEEG().SetVector("wpn_add/base", value);
				this.AGEHKELMAFL().SetVector("[HA ", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.IHAKFMDJEGK().EnableKeyword("Hidden/Fast Approximate Anti-aliasing");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1460f);
				this.KIBLMGMPOJD().SetVector("maxdeep", value2);
			}
			if (this.vignette.enabled)
			{
				this.ALDNDLLLPCO().SetColor("Reset", this.vignette.color);
				if (this.vignette.blur > 291f)
				{
					int num2 = JONJODLFAEN.width / 6;
					int num3 = JONJODLFAEN.height / 6;
					RenderTexture renderTexture = this.JEIFLMLLOLG.OFFIEJNIOAL(num2, num3, 0, JONJODLFAEN.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.EBDILCDNIEJ(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					this.IHAKFMDJEGK().SetVector("CratePull", new Vector2(522f / (float)num2, 1018f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.CLAEAFBEJNN(), 0);
					if (this.distortion.enabled)
					{
						this.IKDCAALOEEG().DisableKeyword("_MainTex");
						this.IOIGFMMJKNA().DisableKeyword("******** nextMusicCrt lng=");
					}
					this.CBHFHFDMLKM().SetVector("</color>\n", new Vector2(1819f, 1395f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KAMHMEEIKPC(), 0);
					this.DEEJGFMDJBB().SetVector("<b>string:</b> ", new Vector2(1779f / (float)num2, 737f));
					Graphics.Blit(renderTexture2, renderTexture, this.IOIGFMMJKNA(), 0);
					this.CDHGPDDEKDF().SetVector("Anchore Right_", new Vector2(1182f, 1312f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.CLBIDDJOLHP(), 0);
					this.OMDJPBECNBJ().SetTexture("Error key=", renderTexture2);
					this.CDHGPDDEKDF().SetFloat("wpn_eat1", this.vignette.blur * 669f);
					this.MHNAJNGGDFJ.EnableKeyword("_FogAlpha");
					if (this.distortion.enabled)
					{
						this.AMKGEAODCKK().EnableKeyword((this.distortion.amount >= 1600f) ? "reflectQuality" : "wpn_add/base");
					}
				}
				if (this.vignette.desaturate > 1880f)
				{
					this.DEEJGFMDJBB().EnableKeyword("knopje.wav");
					this.HFABMCCBNMB().SetFloat("_ColorBuffer", 1559f - this.vignette.desaturate);
				}
				this.CJOMCEBOFKB().SetVector("Biped's root Transform's position should be at ground level relative to the character (at the character's feet not at it's pelvis).", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1507f))
				{
					this.KABDJNIDNDC().EnableKeyword("WoodSaw");
					this.CJOMCEBOFKB().SetVector("IdleStand", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.MHNAJNGGDFJ.EnableKeyword("OfficeSittingLegCross");
					float z = (1732f - this.vignette.roundness) * 1240f + this.vignette.roundness;
					this.NMIDGHFFOBD().SetVector("auk_pstinf", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 7;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 6;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 6;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 2;
			}
			else if (this.vignette.enabled)
			{
				pass = 6;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 7;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.AMKGEAODCKK(), pass);
			this.JEIFLMLLOLG.BNANACPAAIJ();
		}

		// Token: 0x0600C37C RID: 50044 RVA: 0x00585949 File Offset: 0x00583B49
		public Material CLBIDDJOLHP()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.IGJCMCCJDGL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C37D RID: 50045 RVA: 0x00585970 File Offset: 0x00583B70
		public Material AMKGEAODCKK()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.BPMGJGNHONO());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C37E RID: 50046 RVA: 0x00585997 File Offset: 0x00583B97
		public Material CBHFHFDMLKM()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.ALHGJLHOKNG());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C37F RID: 50047 RVA: 0x005859BE File Offset: 0x00583BBE
		private void AOILKGIIKDF()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.JOLADLIOMFB();
		}

		// Token: 0x0600C380 RID: 50048 RVA: 0x005821F1 File Offset: 0x005803F1
		public Material KABDJNIDNDC()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.BNCCHENNGMA());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C381 RID: 50049 RVA: 0x00581BE3 File Offset: 0x0057FDE3
		public Material NMIDGHFFOBD()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KLCBDOLKFEP());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C382 RID: 50050 RVA: 0x005859EB File Offset: 0x00583BEB
		private void PNGOLEOOHCD()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.ANOIKBOFFCL(), true, false, this))
			{
				base.enabled = false;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C383 RID: 50051 RVA: 0x00585A0F File Offset: 0x00583C0F
		private void GMJFHNCPCBN()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.LIMAOKPPING();
		}

		// Token: 0x0600C384 RID: 50052 RVA: 0x00585A3C File Offset: 0x00583C3C
		public Shader CLHPPJPLKMM()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("paper.wav");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C385 RID: 50053 RVA: 0x00585A62 File Offset: 0x00583C62
		private void OnEnable()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.BAKBIMBKKNP, false, false, this))
			{
				base.enabled = false;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C386 RID: 50054 RVA: 0x00585A86 File Offset: 0x00583C86
		private void BFOBDCCJIBG()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.JMNDOFCLCOL(), false, true, this))
			{
				base.enabled = false;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C387 RID: 50055 RVA: 0x00585AAA File Offset: 0x00583CAA
		private void MFOGDJHDIDA()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.PIJMHMFFLEC(), true, true, this))
			{
				base.enabled = false;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C388 RID: 50056 RVA: 0x00581B6E File Offset: 0x0057FD6E
		private void FGHHAIDJNMM()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.IFDFEOEAKOF();
		}

		// Token: 0x0600C389 RID: 50057 RVA: 0x00583494 File Offset: 0x00581694
		public Material ALDNDLLLPCO()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.GLEKFBOEOJJ());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C38A RID: 50058 RVA: 0x00585ACE File Offset: 0x00583CCE
		public Shader GLFPKCKBIBL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("mastername");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C38B RID: 50059 RVA: 0x00585AF4 File Offset: 0x00583CF4
		private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.ADBDAKNGHHG().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1681f * Math.Max(Mathf.Abs(this.distortion.amount), 829f);
				float num = 1331f * Math.Min(1379f, val);
				float y = 41f * Mathf.Tan(num * 508f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 976f), Mathf.Max(this.distortion.amountY, 1033f));
				Vector3 v = new Vector3((this.distortion.amount >= 1184f) ? num : (1547f / num), y, 582f / this.distortion.scale);
				this.IHAKFMDJEGK().EnableKeyword((this.distortion.amount >= 609f) ? "fishdrop_1" : "Right Hand Effector needs a Target in this demo.");
				this.MHNAJNGGDFJ.SetVector("ShotgunReloadChamber", value);
				this.CLAEAFBEJNN().SetVector("Sitting Leg Cross", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.KAMHMEEIKPC().EnableKeyword("_History2Weight");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 904f);
				this.DNCJDOFOENA().SetVector("Didn't expect existing render texture: ", value2);
			}
			if (this.vignette.enabled)
			{
				this.ALDNDLLLPCO().SetColor("PersonManFisher", this.vignette.color);
				if (this.vignette.blur > 1990f)
				{
					int num2 = JONJODLFAEN.width / 2;
					int num3 = JONJODLFAEN.height / 1;
					RenderTexture renderTexture = this.JEIFLMLLOLG.KOLHIOLACPK(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.EKNEEFEOGPH(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					this.MHNAJNGGDFJ.SetVector("Fire Breath", new Vector2(1569f / (float)num2, 1123f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.IOIGFMMJKNA(), 1);
					if (this.distortion.enabled)
					{
						this.DNCJDOFOENA().DisableKeyword("_alfavis");
						this.COCHPLKIEGO().DisableKeyword("PistolFire");
					}
					this.AGEHKELMAFL().SetVector("", new Vector2(1123f, 1039f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.DEEJGFMDJBB(), 1);
					this.CDHGPDDEKDF().SetVector(".unity3d", new Vector2(266f / (float)num2, 1918f));
					Graphics.Blit(renderTexture2, renderTexture, this.CDHGPDDEKDF(), 0);
					this.DEEJGFMDJBB().SetVector(" ", new Vector2(1454f, 1390f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KIBLMGMPOJD(), 1);
					this.CJOMCEBOFKB().SetTexture("Grain Lookup Texture", renderTexture2);
					this.LGPOFGEJNJJ().SetFloat("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", this.vignette.blur * 1139f);
					this.HFABMCCBNMB().EnableKeyword("ZombieCrawl");
					if (this.distortion.enabled)
					{
						this.COCHPLKIEGO().EnableKeyword((this.distortion.amount >= 635f) ? "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_biped_i_k.html" : "SPACE");
					}
				}
				if (this.vignette.desaturate > 1851f)
				{
					this.AGEHKELMAFL().EnableKeyword("_Direction");
					this.COCHPLKIEGO().SetFloat("abcd", 1134f - this.vignette.desaturate);
				}
				this.CDHGPDDEKDF().SetVector("CrouchStrafeLeft", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 262f))
				{
					this.IHAKFMDJEGK().EnableKeyword("===== ObscuredFloatTest =====\n");
					this.NMIDGHFFOBD().SetVector("RollerBladeRoll", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.CLAEAFBEJNN().EnableKeyword("HookPoint");
					float z = (856f - this.vignette.roundness) * 1463f + this.vignette.roundness;
					this.CJOMCEBOFKB().SetVector("lifeBar", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 3;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled)
			{
				pass = 6;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 4;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, pass);
			this.JEIFLMLLOLG.ICBHFHNPKGN();
		}

		// Token: 0x0600C38C RID: 50060 RVA: 0x005860DC File Offset: 0x005842DC
		private void JCOOPIFFNNH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.AMKGEAODCKK().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 402f * Math.Max(Mathf.Abs(this.distortion.amount), 826f);
				float num = 314f * Math.Min(882f, val);
				float y = 167f * Mathf.Tan(num * 1476f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 364f), Mathf.Max(this.distortion.amountY, 1719f));
				Vector3 v = new Vector3((this.distortion.amount >= 801f) ? num : (272f / num), y, 1946f / this.distortion.scale);
				this.AGEHKELMAFL().EnableKeyword((this.distortion.amount >= 1437f) ? "Add random value" : "_TapLowForeground");
				this.COCHPLKIEGO().SetVector("RunBackward", value);
				this.IOIGFMMJKNA().SetVector("OfficeSitting", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.DEEJGFMDJBB().EnableKeyword("Hyperlink_");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 776f);
				this.KIBLMGMPOJD().SetVector(" x", value2);
			}
			if (this.vignette.enabled)
			{
				this.NMIDGHFFOBD().SetColor(" is not supported on this platform!", this.vignette.color);
				if (this.vignette.blur > 1834f)
				{
					int num2 = JONJODLFAEN.width / 2;
					int num3 = JONJODLFAEN.height / 7;
					RenderTexture renderTexture = this.JEIFLMLLOLG.OFFIEJNIOAL(num2, num3, 0, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.KOLHIOLACPK(num2, num3, 0, JONJODLFAEN.format, FilterMode.Point);
					this.IKDCAALOEEG().SetVector("Lives count: ", new Vector2(1942f / (float)num2, 1927f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.CDHGPDDEKDF(), 0);
					if (this.distortion.enabled)
					{
						this.OMDJPBECNBJ().DisableKeyword("_Offsets");
						this.ALDNDLLLPCO().DisableKeyword("BowReady");
					}
					this.COCHPLKIEGO().SetVector("_FogVoidPosition", new Vector2(250f, 430f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KKHHDHBMFJB(), 0);
					this.KAMHMEEIKPC().SetVector("Idle Stand", new Vector2(1386f / (float)num2, 326f));
					Graphics.Blit(renderTexture2, renderTexture, this.AMKGEAODCKK(), 1);
					this.ADBDAKNGHHG().SetVector("0", new Vector2(179f, 690f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KIBLMGMPOJD(), 0);
					this.CDHGPDDEKDF().SetTexture("{0} - {1} шт", renderTexture2);
					this.CBHFHFDMLKM().SetFloat("close", this.vignette.blur * 921f);
					this.IKDCAALOEEG().EnableKeyword("_CameraClipInfo");
					if (this.distortion.enabled)
					{
						this.DNCJDOFOENA().EnableKeyword((this.distortion.amount >= 901f) ? "CrawlLocomotion" : "cash.ogg");
					}
				}
				if (this.vignette.desaturate > 1892f)
				{
					this.DNCJDOFOENA().EnableKeyword("11");
					this.JMDMNMEHAPM().SetFloat("Roller Blade Roll", 1939f - this.vignette.desaturate);
				}
				this.CDHGPDDEKDF().SetVector("Select", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1820f))
				{
					this.DNCJDOFOENA().EnableKeyword(" ms");
					this.LLCJHFGBGDN().SetVector("Sitting Leg Cross", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.COCHPLKIEGO().EnableKeyword("invn_rec14");
					float z = (320f - this.vignette.roundness) * 1777f + this.vignette.roundness;
					this.ALDNDLLLPCO().SetVector("{0:00} m", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 1;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 4;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 0;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 7;
			}
			else if (this.vignette.enabled)
			{
				pass = 0;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 4;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.CDHGPDDEKDF(), pass);
			this.JEIFLMLLOLG.AIKLPJPOHFL();
		}

		// Token: 0x0600C38D RID: 50061 RVA: 0x005866C1 File Offset: 0x005848C1
		public Material DNCJDOFOENA()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.BAKBIMBKKNP);
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C38E RID: 50062 RVA: 0x005866E8 File Offset: 0x005848E8
		private void PPAAMEAPADE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.AGEHKELMAFL().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1537f * Math.Max(Mathf.Abs(this.distortion.amount), 1671f);
				float num = 1493f * Math.Min(336f, val);
				float y = 1887f * Mathf.Tan(num * 1334f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1843f), Mathf.Max(this.distortion.amountY, 1510f));
				Vector3 v = new Vector3((this.distortion.amount >= 1362f) ? num : (1308f / num), y, 1382f / this.distortion.scale);
				this.HFABMCCBNMB().EnableKeyword((this.distortion.amount >= 1935f) ? "_OcclusionTexture" : "1HSwordStrafeRunLeft");
				this.HFABMCCBNMB().SetVector("wpn_eat3", value);
				this.IOIGFMMJKNA().SetVector("base", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.DNCJDOFOENA().EnableKeyword("VALIGN");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 608f);
				this.NMIDGHFFOBD().SetVector("\n", value2);
			}
			if (this.vignette.enabled)
			{
				this.LGPOFGEJNJJ().SetColor("_ColorBuffer", this.vignette.color);
				if (this.vignette.blur > 1445f)
				{
					int num2 = JONJODLFAEN.width / 3;
					int num3 = JONJODLFAEN.height / 7;
					RenderTexture renderTexture = this.JEIFLMLLOLG.IEDCCCJOMPK(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.IEDCCCJOMPK(num2, num3, 0, JONJODLFAEN.format, FilterMode.Bilinear);
					this.AMKGEAODCKK().SetVector("PaperTurn.wav", new Vector2(391f / (float)num2, 583f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.NMIDGHFFOBD(), 0);
					if (this.distortion.enabled)
					{
						this.CDHGPDDEKDF().DisableKeyword("_BlurRadius4");
						this.KABDJNIDNDC().DisableKeyword("1HSwordStrafeRunLeft");
					}
					this.IOIGFMMJKNA().SetVector("Windmill", new Vector2(292f, 1483f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.ADBDAKNGHHG(), 1);
					this.CDHGPDDEKDF().SetVector("https://groups.google.com/forum/#!forum/final-ik", new Vector2(1839f / (float)num2, 1560f));
					Graphics.Blit(renderTexture2, renderTexture, this.AMKGEAODCKK(), 0);
					this.HFABMCCBNMB().SetVector("MotorbikeSeatStand", new Vector2(1957f, 1170f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.DNCJDOFOENA(), 1);
					this.JMDMNMEHAPM().SetTexture("1HandSwordStrafeRight", renderTexture2);
					this.ALDNDLLLPCO().SetFloat("file://", this.vignette.blur * 1094f);
					this.AGEHKELMAFL().EnableKeyword("\n");
					if (this.distortion.enabled)
					{
						this.COCHPLKIEGO().EnableKeyword((this.distortion.amount >= 42f) ? "RollerBladeRoll" : "Images/MouseCursor/Link");
					}
				}
				if (this.vignette.desaturate > 374f)
				{
					this.KIBLMGMPOJD().EnableKeyword("post_3");
					this.KKHHDHBMFJB().SetFloat("1HandSwordJabCombo", 652f - this.vignette.desaturate);
				}
				this.CDHGPDDEKDF().SetVector("_RefractTex", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 156f))
				{
					this.KABDJNIDNDC().EnableKeyword("rem");
					this.AGEHKELMAFL().SetVector("</b>\n : ", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.KABDJNIDNDC().EnableKeyword("_RgbTex");
					float z = (679f - this.vignette.roundness) * 1118f + this.vignette.roundness;
					this.CJOMCEBOFKB().SetVector("1=", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 3;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 7;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 1;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled)
			{
				pass = 5;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 6;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.HFABMCCBNMB(), pass);
			this.JEIFLMLLOLG.AIKLPJPOHFL();
		}

		// Token: 0x0600C38F RID: 50063 RVA: 0x00586CCD File Offset: 0x00584ECD
		public Shader EKFLJAGINLL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("DoActivateTrigger");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C390 RID: 50064 RVA: 0x00586CF3 File Offset: 0x00584EF3
		private void KMCACLNKBFP()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.KMDJOENEKCN();
		}

		// Token: 0x0600C391 RID: 50065 RVA: 0x00586D20 File Offset: 0x00584F20
		public Shader ONPDCPAOPIB()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("PistolFire");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C392 RID: 50066 RVA: 0x00586D48 File Offset: 0x00584F48
		private void JEHHGMJKLPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.CBHFHFDMLKM().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 711f * Math.Max(Mathf.Abs(this.distortion.amount), 1927f);
				float num = 934f * Math.Min(10f, val);
				float y = 224f * Mathf.Tan(num * 1599f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1961f), Mathf.Max(this.distortion.amountY, 1026f));
				Vector3 v = new Vector3((this.distortion.amount >= 1989f) ? num : (573f / num), y, 943f / this.distortion.scale);
				this.CJOMCEBOFKB().EnableKeyword((this.distortion.amount >= 820f) ? "langs/lang" : "\n");
				this.AMKGEAODCKK().SetVector("Current fog preset: ", value);
				this.AGEHKELMAFL().SetVector("_LerpRgbTex", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.OMDJPBECNBJ().EnableKeyword("exp");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1799f);
				this.DJDKHEANJNM().SetVector(".png", value2);
			}
			if (this.vignette.enabled)
			{
				this.IKDCAALOEEG().SetColor("19", this.vignette.color);
				if (this.vignette.blur > 1053f)
				{
					int num2 = JONJODLFAEN.width / 4;
					int num3 = JONJODLFAEN.height / 3;
					RenderTexture renderTexture = this.JEIFLMLLOLG.BJDKCJNLAMO(num2, num3, 1, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.OFFIEJNIOAL(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					this.HFABMCCBNMB().SetVector("^(", new Vector2(1461f / (float)num2, 40f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.CJOMCEBOFKB(), 1);
					if (this.distortion.enabled)
					{
						this.DNCJDOFOENA().DisableKeyword("**");
						this.KIBLMGMPOJD().DisableKeyword("OneHandSwordBackSwing");
					}
					this.CLBIDDJOLHP().SetVector("BowReady", new Vector2(1946f, 928f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.JMDMNMEHAPM(), 0);
					this.AGEHKELMAFL().SetVector("Game saved using ObscuredPrefs. Try to find and change saved data now! ;)", new Vector2(1366f / (float)num2, 1532f));
					Graphics.Blit(renderTexture2, renderTexture, this.HFABMCCBNMB(), 0);
					this.CFJAMJGLPBF().SetVector("toe", new Vector2(67f, 778f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.CDHGPDDEKDF(), 0);
					this.KIBLMGMPOJD().SetTexture("IceHockeyShotLeft", renderTexture2);
					this.OMDJPBECNBJ().SetFloat("#a02000", this.vignette.blur * 912f);
					this.KABDJNIDNDC().EnableKeyword("UserChange");
					if (this.distortion.enabled)
					{
						this.IKDCAALOEEG().EnableKeyword((this.distortion.amount >= 494f) ? "fishSPEED=" : "Hip");
					}
				}
				if (this.vignette.desaturate > 353f)
				{
					this.COCHPLKIEGO().EnableKeyword("Horizontal");
					this.AGEHKELMAFL().SetFloat("<color='#6080ff'>", 1629f - this.vignette.desaturate);
				}
				this.JMDMNMEHAPM().SetVector("button", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1257f))
				{
					this.CFJAMJGLPBF().EnableKeyword("[ACTk] Speed Hack Detector: already running!");
					this.NMIDGHFFOBD().SetVector("", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.DEEJGFMDJBB().EnableKeyword("Add random value");
					float z = (131f - this.vignette.roundness) * 1564f + this.vignette.roundness;
					this.AMKGEAODCKK().SetVector("\n", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 7;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled)
			{
				pass = 2;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 6;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IKDCAALOEEG(), pass);
			this.JEIFLMLLOLG.OBAANNPBFKE();
		}

		// Token: 0x0600C393 RID: 50067 RVA: 0x0058732D File Offset: 0x0058552D
		public Shader HBCJPBCOLIJ()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("crft_btn2");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C394 RID: 50068 RVA: 0x00587354 File Offset: 0x00585554
		private void PLOEFNMCMEF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.CBHFHFDMLKM().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 980f * Math.Max(Mathf.Abs(this.distortion.amount), 876f);
				float num = 1691f * Math.Min(1808f, val);
				float y = 1118f * Mathf.Tan(num * 980f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1251f), Mathf.Max(this.distortion.amountY, 1109f));
				Vector3 v = new Vector3((this.distortion.amount >= 1507f) ? num : (8f / num), y, 968f / this.distortion.scale);
				this.DNCJDOFOENA().EnableKeyword((this.distortion.amount >= 620f) ? "repair.ogg" : "_FogPointLightColor");
				this.LLCJHFGBGDN().SetVector("_NoiseTex", value);
				this.LLCJHFGBGDN().SetVector("TOD_SunMeshBrightness", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.ADBDAKNGHHG().EnableKeyword("Criticals");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 23f);
				this.IOIGFMMJKNA().SetVector("Seat Stand Wheely", value2);
			}
			if (this.vignette.enabled)
			{
				this.MHNAJNGGDFJ.SetColor("paper.wav", this.vignette.color);
				if (this.vignette.blur > 957f)
				{
					int num2 = JONJODLFAEN.width / 4;
					int num3 = JONJODLFAEN.height / 8;
					RenderTexture renderTexture = this.JEIFLMLLOLG.GIDNDCIFACD(num2, num3, 0, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.OFFIEJNIOAL(num2, num3, 0, JONJODLFAEN.format, FilterMode.Point);
					this.NMIDGHFFOBD().SetVector("MotorbikeSpecialFlip", new Vector2(198f / (float)num2, 820f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.DJDKHEANJNM(), 1);
					if (this.distortion.enabled)
					{
						this.DEEJGFMDJBB().DisableKeyword("Gesture No Fear");
						this.AMKGEAODCKK().DisableKeyword("OfficeSittingLegCross");
					}
					this.CLAEAFBEJNN().SetVector("Cooбщение скопировано", new Vector2(679f, 1393f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.IOIGFMMJKNA(), 1);
					this.KKHHDHBMFJB().SetVector("name", new Vector2(955f / (float)num2, 1095f));
					Graphics.Blit(renderTexture2, renderTexture, this.LLCJHFGBGDN(), 1);
					this.KIBLMGMPOJD().SetVector("Crawl Idle", new Vector2(463f, 401f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KABDJNIDNDC(), 1);
					this.AGEHKELMAFL().SetTexture("Mouse Y", renderTexture2);
					this.CLAEAFBEJNN().SetFloat(",", this.vignette.blur * 991f);
					this.IHAKFMDJEGK().EnableKeyword("</color>\n");
					if (this.distortion.enabled)
					{
						this.IOIGFMMJKNA().EnableKeyword((this.distortion.amount >= 1059f) ? "<color='#80ff60'>" : "wpn_cmp");
					}
				}
				if (this.vignette.desaturate > 1444f)
				{
					this.DNCJDOFOENA().EnableKeyword("lastConfirmLic");
					this.ADBDAKNGHHG().SetFloat("error", 1902f - this.vignette.desaturate);
				}
				this.ALDNDLLLPCO().SetVector("gi_sadoknone", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1534f))
				{
					this.CBHFHFDMLKM().EnableKeyword("contrast");
					this.MHNAJNGGDFJ.SetVector("Katana Ready Low", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.KIBLMGMPOJD().EnableKeyword("PistolLeftHandStab");
					float z = (928f - this.vignette.roundness) * 910f + this.vignette.roundness;
					this.COCHPLKIEGO().SetVector("Загрузка: ", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 3;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 1;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 1;
			}
			else if (this.vignette.enabled)
			{
				pass = 0;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 6;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OMDJPBECNBJ(), pass);
			this.JEIFLMLLOLG.OHLNIGLKOEN();
		}

		// Token: 0x0600C395 RID: 50069 RVA: 0x00587939 File Offset: 0x00585B39
		public Shader FJMJKCMFLML()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("1");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C396 RID: 50070 RVA: 0x00585949 File Offset: 0x00583B49
		public Material DEEJGFMDJBB()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.IGJCMCCJDGL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C397 RID: 50071 RVA: 0x0058795F File Offset: 0x00585B5F
		public Material DJDKHEANJNM()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.EKFLJAGINLL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C398 RID: 50072 RVA: 0x00587986 File Offset: 0x00585B86
		public Material HFABMCCBNMB()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.HMDINHDANBA());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C399 RID: 50073 RVA: 0x005879AD File Offset: 0x00585BAD
		public Shader OEDBNKPMCAK()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("минут");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C39A RID: 50074 RVA: 0x005879D3 File Offset: 0x00585BD3
		public Shader BLHCBMINFBA()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("WorkerPickaxe");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C39B RID: 50075 RVA: 0x005879F9 File Offset: 0x00585BF9
		public Material JMDMNMEHAPM()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.CLHPPJPLKMM());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C39C RID: 50076 RVA: 0x00587A20 File Offset: 0x00585C20
		private void NJBEKBHCLIO()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.JNADGOHGFIB();
		}

		// Token: 0x0600C39D RID: 50077 RVA: 0x00581AD2 File Offset: 0x0057FCD2
		public Material IOIGFMMJKNA()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.ANOIKBOFFCL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C39E RID: 50078 RVA: 0x00587A50 File Offset: 0x00585C50
		private void LIKPOPLLIDJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.AGEHKELMAFL().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1101f * Math.Max(Mathf.Abs(this.distortion.amount), 1687f);
				float num = 1476f * Math.Min(1689f, val);
				float y = 1197f * Mathf.Tan(num * 1459f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1556f), Mathf.Max(this.distortion.amountY, 929f));
				Vector3 v = new Vector3((this.distortion.amount >= 219f) ? num : (1287f / num), y, 1037f / this.distortion.scale);
				this.LLCJHFGBGDN().EnableKeyword((this.distortion.amount >= 1615f) ? "" : "lifeBar");
				this.MHNAJNGGDFJ.SetVector("wpn_add/base", value);
				this.JMDMNMEHAPM().SetVector("OfficeSittingLegCross", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.IKDCAALOEEG().EnableKeyword("ingredients");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1998f);
				this.MHNAJNGGDFJ.SetVector("", value2);
			}
			if (this.vignette.enabled)
			{
				this.KKHHDHBMFJB().SetColor("FOG_LINEAR", this.vignette.color);
				if (this.vignette.blur > 806f)
				{
					int num2 = JONJODLFAEN.width / 0;
					int num3 = JONJODLFAEN.height / 0;
					RenderTexture renderTexture = this.JEIFLMLLOLG.AIDDGPOEGHB(num2, num3, 1, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.CLEEDKHNPED(num2, num3, 0, JONJODLFAEN.format, FilterMode.Bilinear);
					this.JMDMNMEHAPM().SetVector("/", new Vector2(10f / (float)num2, 993f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.OMDJPBECNBJ(), 1);
					if (this.distortion.enabled)
					{
						this.DJDKHEANJNM().DisableKeyword("TOD_CloudUV");
						this.CLAEAFBEJNN().DisableKeyword("Water");
					}
					this.MHNAJNGGDFJ.SetVector("_BlurVector", new Vector2(567f, 721f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KKHHDHBMFJB(), 1);
					this.CDHGPDDEKDF().SetVector("WATER_REFRACTIVE", new Vector2(1008f / (float)num2, 97f));
					Graphics.Blit(renderTexture2, renderTexture, this.DNCJDOFOENA(), 0);
					this.CLBIDDJOLHP().SetVector("FacePalm", new Vector2(182f, 1047f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.JMDMNMEHAPM(), 0);
					this.DNCJDOFOENA().SetTexture("", renderTexture2);
					this.CJOMCEBOFKB().SetFloat("isRodInWater", this.vignette.blur * 267f);
					this.LGPOFGEJNJJ().EnableKeyword("BowFire");
					if (this.distortion.enabled)
					{
						this.COCHPLKIEGO().EnableKeyword((this.distortion.amount >= 759f) ? "X (R)" : "[ACTk] ObscuredPrefs.ForceLockToDeviceInit() is called, but device ID is already obtained!");
					}
				}
				if (this.vignette.desaturate > 617f)
				{
					this.HFABMCCBNMB().EnableKeyword("Forward");
					this.DEEJGFMDJBB().SetFloat("id", 1041f - this.vignette.desaturate);
				}
				this.JMDMNMEHAPM().SetVector("_VignetteDesat", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 269f))
				{
					this.CLBIDDJOLHP().EnableKeyword(" ");
					this.DJDKHEANJNM().SetVector("wpn_hook2", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.KABDJNIDNDC().EnableKeyword("_ZWrite");
					float z = (75f - this.vignette.roundness) * 918f + this.vignette.roundness;
					this.CJOMCEBOFKB().SetVector("craft/stanok", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 1;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 4;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 1;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled)
			{
				pass = 0;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 7;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ADBDAKNGHHG(), pass);
			this.JEIFLMLLOLG.GDDOAILGPBD();
		}

		// Token: 0x0600C39F RID: 50079 RVA: 0x00588035 File Offset: 0x00586235
		private void BNCAPAJOMIA()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.OBAANNPBFKE();
		}

		// Token: 0x0600C3A0 RID: 50080 RVA: 0x00588062 File Offset: 0x00586262
		private void HHOJJINMMMA()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.FJMJKCMFLML(), false, true, this))
			{
				base.enabled = false;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C3A1 RID: 50081 RVA: 0x00588086 File Offset: 0x00586286
		public Material IKDCAALOEEG()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.JMNDOFCLCOL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C3A2 RID: 50082 RVA: 0x00581B1D File Offset: 0x0057FD1D
		private void IONMMKEEEBK()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.OHLNIGLKOEN();
		}

		// Token: 0x0600C3A3 RID: 50083 RVA: 0x005880AD File Offset: 0x005862AD
		private void GGIAHHFENMK()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.FJMJKCMFLML(), false, true, this))
			{
				base.enabled = true;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C3A4 RID: 50084 RVA: 0x005879F9 File Offset: 0x00585BF9
		public Material KIBLMGMPOJD()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.CLHPPJPLKMM());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C3A5 RID: 50085 RVA: 0x005880D1 File Offset: 0x005862D1
		public Shader LOFDIJNNCNK()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("camouflage_intens");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C3A6 RID: 50086 RVA: 0x005880F7 File Offset: 0x005862F7
		public Shader HMDINHDANBA()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("SAMPLES_MEDIUM");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C3A7 RID: 50087 RVA: 0x005866C1 File Offset: 0x005848C1
		public Material ADBDAKNGHHG()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.BAKBIMBKKNP);
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C3A8 RID: 50088 RVA: 0x0058811D File Offset: 0x0058631D
		private void BHMLILLBFLP()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.BLHCBMINFBA(), true, true, this))
			{
				base.enabled = true;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C3A9 RID: 50089 RVA: 0x00588141 File Offset: 0x00586341
		public Shader BNCCHENNGMA()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("demoByteArray");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C3AA RID: 50090 RVA: 0x00588167 File Offset: 0x00586367
		private void PLLCHLCDKFA()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.BPMGJGNHONO(), true, true, this))
			{
				base.enabled = true;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C3AB RID: 50091 RVA: 0x0058818B File Offset: 0x0058638B
		public Shader CDLKBJBLAJD()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Flap_08.wav");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C3AC RID: 50092 RVA: 0x005881B1 File Offset: 0x005863B1
		private void DCPLMIMFNHG()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.IGJCMCCJDGL(), false, true, this))
			{
				base.enabled = true;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x005881D8 File Offset: 0x005863D8
		private void LCPJGMMINPK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.KAMHMEEIKPC().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1304f * Math.Max(Mathf.Abs(this.distortion.amount), 432f);
				float num = 1989f * Math.Min(1852f, val);
				float y = 893f * Mathf.Tan(num * 1252f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1587f), Mathf.Max(this.distortion.amountY, 1022f));
				Vector3 v = new Vector3((this.distortion.amount >= 33f) ? num : (1079f / num), y, 884f / this.distortion.scale);
				this.KAMHMEEIKPC().EnableKeyword((this.distortion.amount >= 114f) ? "_VignetteColor" : ")");
				this.MHNAJNGGDFJ.SetVector("OfficeSittingBack", value);
				this.AGEHKELMAFL().SetVector("-r-", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.AGEHKELMAFL().EnableKeyword(" ms");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1113f);
				this.CBHFHFDMLKM().SetVector("_", value2);
			}
			if (this.vignette.enabled)
			{
				this.LGPOFGEJNJJ().SetColor("<b>float:</b> ", this.vignette.color);
				if (this.vignette.blur > 737f)
				{
					int num2 = JONJODLFAEN.width / 8;
					int num3 = JONJODLFAEN.height / 3;
					RenderTexture renderTexture = this.JEIFLMLLOLG.EBDILCDNIEJ(num2, num3, 0, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.IEDCCCJOMPK(num2, num3, 0, JONJODLFAEN.format, FilterMode.Bilinear);
					this.AMKGEAODCKK().SetVector("baraban", new Vector2(1122f / (float)num2, 850f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.MHNAJNGGDFJ, 0);
					if (this.distortion.enabled)
					{
						this.JMDMNMEHAPM().DisableKeyword("Root Node bone is null, can not initiate the solver.");
						this.JMDMNMEHAPM().DisableKeyword("Yawn");
					}
					this.IHAKFMDJEGK().SetVector("isHarvest", new Vector2(978f, 483f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KKHHDHBMFJB(), 0);
					this.KKHHDHBMFJB().SetVector("1 Hand Sword Strafe Left", new Vector2(157f / (float)num2, 239f));
					Graphics.Blit(renderTexture2, renderTexture, this.CJOMCEBOFKB(), 0);
					this.HFABMCCBNMB().SetVector("Hidden/Amplify Color/ProcessOnly", new Vector2(871f, 465f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.HFABMCCBNMB(), 0);
					this.CBHFHFDMLKM().SetTexture("WandStand", renderTexture2);
					this.NMIDGHFFOBD().SetFloat("_HrDepthTex", this.vignette.blur * 654f);
					this.CLBIDDJOLHP().EnableKeyword("post_6");
					if (this.distortion.enabled)
					{
						this.LLCJHFGBGDN().EnableKeyword((this.distortion.amount >= 1078f) ? "IceHockey" : "Katana Ready Low");
					}
				}
				if (this.vignette.desaturate > 1695f)
				{
					this.IKDCAALOEEG().EnableKeyword("VIGNETTE_CLASSIC");
					this.LGPOFGEJNJJ().SetFloat("gi_nl2", 1335f - this.vignette.desaturate);
				}
				this.LGPOFGEJNJJ().SetVector("Open Door", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1321f))
				{
					this.NMIDGHFFOBD().EnableKeyword("cht_msg29");
					this.DEEJGFMDJBB().SetVector("GiantGrabIdle2", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.IOIGFMMJKNA().EnableKeyword("");
					float z = (740f - this.vignette.roundness) * 1899f + this.vignette.roundness;
					this.LLCJHFGBGDN().SetVector("Mouse Y", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 3;
			}
			else if (this.vignette.enabled)
			{
				pass = 8;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 8;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.IHAKFMDJEGK(), pass);
			this.JEIFLMLLOLG.OBAANNPBFKE();
		}

		// Token: 0x0600C3AE RID: 50094 RVA: 0x0058795F File Offset: 0x00585B5F
		public Material AGEHKELMAFL()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.EKFLJAGINLL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C3AF RID: 50095 RVA: 0x00581BE3 File Offset: 0x0057FDE3
		public Material CFJAMJGLPBF()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KLCBDOLKFEP());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C3B0 RID: 50096 RVA: 0x00587986 File Offset: 0x00585B86
		public Material CJOMCEBOFKB()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.HMDINHDANBA());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x0600C3B1 RID: 50097 RVA: 0x005866C1 File Offset: 0x005848C1
		public Material MHNAJNGGDFJ
		{
			get
			{
				if (this.BHHEHMIFMBD == null)
				{
					this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.BAKBIMBKKNP);
				}
				return this.BHHEHMIFMBD;
			}
		}

		// Token: 0x0600C3B2 RID: 50098 RVA: 0x005821F1 File Offset: 0x005803F1
		public Material COCHPLKIEGO()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.BNCCHENNGMA());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C3B3 RID: 50099 RVA: 0x005887BD File Offset: 0x005869BD
		private void HACJAOEBLFG()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.KFLDHJKBEHN();
		}

		// Token: 0x0600C3B4 RID: 50100 RVA: 0x005887EA File Offset: 0x005869EA
		public Shader IGJCMCCJDGL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_isSelect");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C3B5 RID: 50101 RVA: 0x00588810 File Offset: 0x00586A10
		public Shader PIJMHMFFLEC()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Current fog preset: ");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C3B6 RID: 50102 RVA: 0x00588836 File Offset: 0x00586A36
		private void OnDisable()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.IFBAMKOGBFI();
		}

		// Token: 0x0600C3B7 RID: 50103 RVA: 0x00588863 File Offset: 0x00586A63
		public Shader KNFCJFOIPLA()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("SoccerKeeperStrafeRight");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C3B8 RID: 50104 RVA: 0x00588889 File Offset: 0x00586A89
		public Shader BPMGJGNHONO()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("BackPress");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C3B9 RID: 50105 RVA: 0x005888AF File Offset: 0x00586AAF
		public Shader KLCBDOLKFEP()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("\n");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C3BA RID: 50106 RVA: 0x005888D5 File Offset: 0x00586AD5
		public Material CLAEAFBEJNN()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KNFCJFOIPLA());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C3BB RID: 50107 RVA: 0x005888FC File Offset: 0x00586AFC
		public Shader NOPIBPGHFFB()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Unable to create Lightmap");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C3BC RID: 50108 RVA: 0x00588924 File Offset: 0x00586B24
		private void JECCAAPKJCK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.JMDMNMEHAPM().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 826f * Math.Max(Mathf.Abs(this.distortion.amount), 781f);
				float num = 1265f * Math.Min(1721f, val);
				float y = 432f * Mathf.Tan(num * 463f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1948f), Mathf.Max(this.distortion.amountY, 1361f));
				Vector3 v = new Vector3((this.distortion.amount >= 183f) ? num : (1946f / num), y, 1411f / this.distortion.scale);
				this.IHAKFMDJEGK().EnableKeyword((this.distortion.amount >= 1631f) ? "_AccumulationTex" : "");
				this.CDHGPDDEKDF().SetVector(" is represented multiple times in the Bones.", value);
				this.MHNAJNGGDFJ.SetVector("", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.LLCJHFGBGDN().EnableKeyword("WATER_REFLECTIVE");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 130f);
				this.DJDKHEANJNM().SetVector("^(", value2);
			}
			if (this.vignette.enabled)
			{
				this.DJDKHEANJNM().SetColor("Left arm 'Wrist To Palm Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the wrist towards the palm. If the arrow points away from the palm, axis must be negative.", this.vignette.color);
				if (this.vignette.blur > 334f)
				{
					int num2 = JONJODLFAEN.width / 1;
					int num3 = JONJODLFAEN.height / 8;
					RenderTexture renderTexture = this.JEIFLMLLOLG.OFFIEJNIOAL(num2, num3, 1, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.IEDCCCJOMPK(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					this.DEEJGFMDJBB().SetVector("\n", new Vector2(1636f / (float)num2, 986f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.CDHGPDDEKDF(), 0);
					if (this.distortion.enabled)
					{
						this.ALDNDLLLPCO().DisableKeyword("OfficeSittingMouseMovement");
						this.CFJAMJGLPBF().DisableKeyword("IdleStand");
					}
					this.KKHHDHBMFJB().SetVector("_Grain_Params1", new Vector2(580f, 508f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.MHNAJNGGDFJ, 0);
					this.DJDKHEANJNM().SetVector("IKMappingSpine is missing the left thigh bone.", new Vector2(438f / (float)num2, 690f));
					Graphics.Blit(renderTexture2, renderTexture, this.DJDKHEANJNM(), 1);
					this.MHNAJNGGDFJ.SetVector("Textures/Perks/", new Vector2(1000f, 756f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.AGEHKELMAFL(), 1);
					this.OMDJPBECNBJ().SetTexture("100", renderTexture2);
					this.DJDKHEANJNM().SetFloat("Podsek action 3", this.vignette.blur * 1313f);
					this.ADBDAKNGHHG().EnableKeyword("FistPump2");
					if (this.distortion.enabled)
					{
						this.KAMHMEEIKPC().EnableKeyword((this.distortion.amount >= 1533f) ? "AC_QUALITY_MOBILE" : "medium");
					}
				}
				if (this.vignette.desaturate > 1551f)
				{
					this.KABDJNIDNDC().EnableKeyword("http://www.root-motion.com/finalikdox/html/page4.html");
					this.CLBIDDJOLHP().SetFloat("cntx_close", 600f - this.vignette.desaturate);
				}
				this.LLCJHFGBGDN().SetVector("Textures/Weapons/", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1644f))
				{
					this.CLAEAFBEJNN().EnableKeyword("knopje.wav");
					this.CDHGPDDEKDF().SetVector("isWoman", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.LGPOFGEJNJJ().EnableKeyword("none");
					float z = (1126f - this.vignette.roundness) * 1724f + this.vignette.roundness;
					this.DNCJDOFOENA().SetVector("u_isSave", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 0;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 4;
			}
			else if (this.vignette.enabled)
			{
				pass = 5;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 8;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ADBDAKNGHHG(), pass);
			this.JEIFLMLLOLG.GDDOAILGPBD();
		}

		// Token: 0x0600C3BD RID: 50109 RVA: 0x00588F0C File Offset: 0x0058710C
		private void DLOGCPJNGLM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.HFABMCCBNMB().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1305f * Math.Max(Mathf.Abs(this.distortion.amount), 228f);
				float num = 588f * Math.Min(289f, val);
				float y = 1848f * Mathf.Tan(num * 491f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1867f), Mathf.Max(this.distortion.amountY, 1169f));
				Vector3 v = new Vector3((this.distortion.amount >= 1948f) ? num : (117f / num), y, 773f / this.distortion.scale);
				this.DNCJDOFOENA().EnableKeyword((this.distortion.amount >= 1348f) ? "Yawn" : "Pricorm count=");
				this.LGPOFGEJNJJ().SetVector(" x", value);
				this.IHAKFMDJEGK().SetVector("_ScreenSize", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.DJDKHEANJNM().EnableKeyword("Giant3HitCombo");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1645f);
				this.CDHGPDDEKDF().SetVector(" гр ", value2);
			}
			if (this.vignette.enabled)
			{
				this.DNCJDOFOENA().SetColor("1 Hand Sword Back Swing", this.vignette.color);
				if (this.vignette.blur > 420f)
				{
					int num2 = JONJODLFAEN.width / 1;
					int num3 = JONJODLFAEN.height / 8;
					RenderTexture renderTexture = this.JEIFLMLLOLG.HAIACDDDOCD(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.OFFIEJNIOAL(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					this.CBHFHFDMLKM().SetVector("Wizard2HandThrow", new Vector2(1161f / (float)num2, 1725f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.CLBIDDJOLHP(), 1);
					if (this.distortion.enabled)
					{
						this.IOIGFMMJKNA().DisableKeyword("gi_uinf_1i");
						this.DJDKHEANJNM().DisableKeyword("Roar");
					}
					this.OMDJPBECNBJ().SetVector(" ", new Vector2(456f, 1257f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.JMDMNMEHAPM(), 0);
					this.AGEHKELMAFL().SetVector("knopje.wav", new Vector2(1344f / (float)num2, 119f));
					Graphics.Blit(renderTexture2, renderTexture, this.KABDJNIDNDC(), 1);
					this.AGEHKELMAFL().SetVector("IX", new Vector2(1370f, 884f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.MHNAJNGGDFJ, 0);
					this.DJDKHEANJNM().SetTexture("", renderTexture2);
					this.CJOMCEBOFKB().SetFloat("DecalMesh", this.vignette.blur * 1010f);
					this.DNCJDOFOENA().EnableKeyword("signal_tone");
					if (this.distortion.enabled)
					{
						this.LLCJHFGBGDN().EnableKeyword((this.distortion.amount >= 932f) ? " гр " : "Katana45DegSwing");
					}
				}
				if (this.vignette.desaturate > 1212f)
				{
					this.IHAKFMDJEGK().EnableKeyword("_WrinkleOcclusionStrengths");
					this.NMIDGHFFOBD().SetFloat("<color='#a0a0a0'>{2:D2}:{0:D2}:{1:D2}</color>", 907f - this.vignette.desaturate);
				}
				this.CBHFHFDMLKM().SetVector("OneHandSwordJab", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 596f))
				{
					this.NMIDGHFFOBD().EnableKeyword("\n");
					this.AMKGEAODCKK().SetVector("IdleTyping", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.KAMHMEEIKPC().EnableKeyword("SpinReel.ogg");
					float z = (1456f - this.vignette.roundness) * 7f + this.vignette.roundness;
					this.NMIDGHFFOBD().SetVector("IdleBandage", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 2;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled)
			{
				pass = 7;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 4;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ADBDAKNGHHG(), pass);
			this.JEIFLMLLOLG.OHLNIGLKOEN();
		}

		// Token: 0x0600C3BE RID: 50110 RVA: 0x005894F1 File Offset: 0x005876F1
		private void CPIEBNMKKMB()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.OEDBNKPMCAK(), false, false, this))
			{
				base.enabled = true;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C3BF RID: 50111 RVA: 0x00589515 File Offset: 0x00587715
		public Shader ALHGJLHOKNG()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find(" ");
			}
			return this.m_Shader;
		}

		// Token: 0x0600C3C0 RID: 50112 RVA: 0x0058953C File Offset: 0x0058773C
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.MHNAJNGGDFJ.shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1.6f * Math.Max(Mathf.Abs(this.distortion.amount), 1f);
				float num = 0.017453292f * Math.Min(160f, val);
				float y = 2f * Mathf.Tan(num * 0.5f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 0.0001f), Mathf.Max(this.distortion.amountY, 0.0001f));
				Vector3 v = new Vector3((this.distortion.amount >= 0f) ? num : (1f / num), y, 1f / this.distortion.scale);
				this.MHNAJNGGDFJ.EnableKeyword((this.distortion.amount >= 0f) ? "DISTORT" : "UNDISTORT");
				this.MHNAJNGGDFJ.SetVector("_DistCenterScale", value);
				this.MHNAJNGGDFJ.SetVector("_DistAmount", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.MHNAJNGGDFJ.EnableKeyword("CHROMATIC_ABERRATION");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 0.001f);
				this.MHNAJNGGDFJ.SetVector("_ChromaticAberration", value2);
			}
			if (this.vignette.enabled)
			{
				this.MHNAJNGGDFJ.SetColor("_VignetteColor", this.vignette.color);
				if (this.vignette.blur > 0f)
				{
					int num2 = JONJODLFAEN.width / 2;
					int num3 = JONJODLFAEN.height / 2;
					RenderTexture renderTexture = this.JEIFLMLLOLG.OFFIEJNIOAL(num2, num3, 0, JONJODLFAEN.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.OFFIEJNIOAL(num2, num3, 0, JONJODLFAEN.format, FilterMode.Bilinear);
					this.MHNAJNGGDFJ.SetVector("_BlurPass", new Vector2(1f / (float)num2, 0f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.MHNAJNGGDFJ, 0);
					if (this.distortion.enabled)
					{
						this.MHNAJNGGDFJ.DisableKeyword("DISTORT");
						this.MHNAJNGGDFJ.DisableKeyword("UNDISTORT");
					}
					this.MHNAJNGGDFJ.SetVector("_BlurPass", new Vector2(0f, 1f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.MHNAJNGGDFJ, 0);
					this.MHNAJNGGDFJ.SetVector("_BlurPass", new Vector2(1f / (float)num2, 0f));
					Graphics.Blit(renderTexture2, renderTexture, this.MHNAJNGGDFJ, 0);
					this.MHNAJNGGDFJ.SetVector("_BlurPass", new Vector2(0f, 1f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.MHNAJNGGDFJ, 0);
					this.MHNAJNGGDFJ.SetTexture("_BlurTex", renderTexture2);
					this.MHNAJNGGDFJ.SetFloat("_VignetteBlur", this.vignette.blur * 3f);
					this.MHNAJNGGDFJ.EnableKeyword("VIGNETTE_BLUR");
					if (this.distortion.enabled)
					{
						this.MHNAJNGGDFJ.EnableKeyword((this.distortion.amount >= 0f) ? "DISTORT" : "UNDISTORT");
					}
				}
				if (this.vignette.desaturate > 0f)
				{
					this.MHNAJNGGDFJ.EnableKeyword("VIGNETTE_DESAT");
					this.MHNAJNGGDFJ.SetFloat("_VignetteDesat", 1f - this.vignette.desaturate);
				}
				this.MHNAJNGGDFJ.SetVector("_VignetteCenter", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1f))
				{
					this.MHNAJNGGDFJ.EnableKeyword("VIGNETTE_CLASSIC");
					this.MHNAJNGGDFJ.SetVector("_VignetteSettings", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.MHNAJNGGDFJ.EnableKeyword("VIGNETTE_FILMIC");
					float z = (1f - this.vignette.roundness) * 6f + this.vignette.roundness;
					this.MHNAJNGGDFJ.SetVector("_VignetteSettings", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 7;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 6;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 4;
			}
			else if (this.vignette.enabled)
			{
				pass = 3;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 2;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.MHNAJNGGDFJ, pass);
			this.JEIFLMLLOLG.IFBAMKOGBFI();
		}

		// Token: 0x0600C3C1 RID: 50113 RVA: 0x00589B21 File Offset: 0x00587D21
		private void KOAEBJLNOLI()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.BPMGJGNHONO(), false, true, this))
			{
				base.enabled = true;
			}
			this.JEIFLMLLOLG = new ICADPIDCHAM();
		}

		// Token: 0x0600C3C2 RID: 50114 RVA: 0x00589B45 File Offset: 0x00587D45
		private void OKGEFINHFFL()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.EEEJNJKFCLE();
		}

		// Token: 0x0600C3C3 RID: 50115 RVA: 0x00581AD2 File Offset: 0x0057FCD2
		public Material LGPOFGEJNJJ()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.ANOIKBOFFCL());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C3C4 RID: 50116 RVA: 0x00586CF3 File Offset: 0x00584EF3
		private void BIDOGNIGPED()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.KMDJOENEKCN();
		}

		// Token: 0x0600C3C5 RID: 50117 RVA: 0x00589B72 File Offset: 0x00587D72
		private void PCKOPPKGENK()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.ONDHPBGGNIA();
		}

		// Token: 0x0600C3C6 RID: 50118 RVA: 0x00589BA0 File Offset: 0x00587DA0
		private void AHMKJAIPKMF(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.CLAEAFBEJNN().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1135f * Math.Max(Mathf.Abs(this.distortion.amount), 265f);
				float num = 534f * Math.Min(809f, val);
				float y = 207f * Mathf.Tan(num * 1824f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 495f), Mathf.Max(this.distortion.amountY, 1055f));
				Vector3 v = new Vector3((this.distortion.amount >= 1580f) ? num : (1649f / num), y, 1415f / this.distortion.scale);
				this.DJDKHEANJNM().EnableKeyword((this.distortion.amount >= 1879f) ? "IdleStand" : "");
				this.CDHGPDDEKDF().SetVector("_Offsets", value);
				this.AGEHKELMAFL().SetVector("WeaponStrafeRunRight", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.IKDCAALOEEG().EnableKeyword("shop_t18");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1014f);
				this.CBHFHFDMLKM().SetVector("_Slope", value2);
			}
			if (this.vignette.enabled)
			{
				this.AMKGEAODCKK().SetColor("qd_prise_rep", this.vignette.color);
				if (this.vignette.blur > 1105f)
				{
					int num2 = JONJODLFAEN.width / 0;
					int num3 = JONJODLFAEN.height / 3;
					RenderTexture renderTexture = this.JEIFLMLLOLG.BOFBBOPNHKG(num2, num3, 0, JONJODLFAEN.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.BOFBBOPNHKG(num2, num3, 1, JONJODLFAEN.format, FilterMode.Point);
					this.LGPOFGEJNJJ().SetVector("_FogOfWarCenterAdjusted", new Vector2(758f / (float)num2, 1230f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.LLCJHFGBGDN(), 1);
					if (this.distortion.enabled)
					{
						this.COCHPLKIEGO().DisableKeyword("Mouse Y");
						this.KKHHDHBMFJB().DisableKeyword("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_look_at_i_k.html");
					}
					this.IHAKFMDJEGK().SetVector("noresult", new Vector2(80f, 330f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.JMDMNMEHAPM(), 1);
					this.IKDCAALOEEG().SetVector("_History1Weight", new Vector2(1020f / (float)num2, 1444f));
					Graphics.Blit(renderTexture2, renderTexture, this.NMIDGHFFOBD(), 0);
					this.ALDNDLLLPCO().SetVector("</i></color>", new Vector2(1265f, 544f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.COCHPLKIEGO(), 1);
					this.DEEJGFMDJBB().SetTexture("Giant Grab Throw 2", renderTexture2);
					this.DNCJDOFOENA().SetFloat("{0}-{1}={2}", this.vignette.blur * 41f);
					this.JMDMNMEHAPM().EnableKeyword("run_cnt");
					if (this.distortion.enabled)
					{
						this.KIBLMGMPOJD().EnableKeyword((this.distortion.amount >= 811f) ? "Horizontal" : "");
					}
				}
				if (this.vignette.desaturate > 653f)
				{
					this.MHNAJNGGDFJ.EnableKeyword("H:mm:ss");
					this.OMDJPBECNBJ().SetFloat("<color='#206000'>", 987f - this.vignette.desaturate);
				}
				this.CLBIDDJOLHP().SetVector("_Intensity", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1802f))
				{
					this.KABDJNIDNDC().EnableKeyword("CheerKnees");
					this.LGPOFGEJNJJ().SetVector("Podsek action 3", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.CLBIDDJOLHP().EnableKeyword("");
					float z = (962f - this.vignette.roundness) * 297f + this.vignette.roundness;
					this.HFABMCCBNMB().SetVector("MotorbikeHandstand", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 3;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 6;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled)
			{
				pass = 5;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 6;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ADBDAKNGHHG(), pass);
			this.JEIFLMLLOLG.FMIMDCPJHMF();
		}

		// Token: 0x0600C3C7 RID: 50119 RVA: 0x0058A188 File Offset: 0x00588388
		private void LLIDCMOMECE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.HFABMCCBNMB().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1494f * Math.Max(Mathf.Abs(this.distortion.amount), 110f);
				float num = 1658f * Math.Min(259f, val);
				float y = 147f * Mathf.Tan(num * 1539f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 780f), Mathf.Max(this.distortion.amountY, 1625f));
				Vector3 v = new Vector3((this.distortion.amount >= 1535f) ? num : (418f / num), y, 1113f / this.distortion.scale);
				this.HFABMCCBNMB().EnableKeyword((this.distortion.amount >= 379f) ? "" : "Name: ");
				this.NMIDGHFFOBD().SetVector("QTaskMgr is INIT", value);
				this.LLCJHFGBGDN().SetVector("MotorbikeLasso", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.DNCJDOFOENA().EnableKeyword("WATER_EDGEBLEND_ON");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1869f);
				this.CJOMCEBOFKB().SetVector("u_isSave", value2);
			}
			if (this.vignette.enabled)
			{
				this.AGEHKELMAFL().SetColor("WalkBackward", this.vignette.color);
				if (this.vignette.blur > 1854f)
				{
					int num2 = JONJODLFAEN.width / 2;
					int num3 = JONJODLFAEN.height / 6;
					RenderTexture renderTexture = this.JEIFLMLLOLG.HGJGOJEFCPN(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.JEIFLMLLOLG.KOLHIOLACPK(num2, num3, 1, JONJODLFAEN.format, FilterMode.Bilinear);
					this.ADBDAKNGHHG().SetVector("_", new Vector2(1106f / (float)num2, 1033f));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.ADBDAKNGHHG(), 1);
					if (this.distortion.enabled)
					{
						this.DJDKHEANJNM().DisableKeyword("http://j.mp/1gxg1tf");
						this.CBHFHFDMLKM().DisableKeyword("SteamPay error:");
					}
					this.OMDJPBECNBJ().SetVector("MotorbikeHandstand", new Vector2(1395f, 182f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.COCHPLKIEGO(), 0);
					this.IOIGFMMJKNA().SetVector("<color='", new Vector2(1500f / (float)num2, 1091f));
					Graphics.Blit(renderTexture2, renderTexture, this.ALDNDLLLPCO(), 1);
					this.DNCJDOFOENA().SetVector("RollerBladeCrossoverLeft", new Vector2(253f, 465f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.COCHPLKIEGO(), 0);
					this.ADBDAKNGHHG().SetTexture("Sexy Dance 2", renderTexture2);
					this.AMKGEAODCKK().SetFloat("{0:dd/MM/yyyy в HH:mm}", this.vignette.blur * 1186f);
					this.CJOMCEBOFKB().EnableKeyword("russian");
					if (this.distortion.enabled)
					{
						this.DJDKHEANJNM().EnableKeyword((this.distortion.amount >= 679f) ? "QTaskMgr is INIT" : "root");
					}
				}
				if (this.vignette.desaturate > 1288f)
				{
					this.CDHGPDDEKDF().EnableKeyword("Idle Die 2");
					this.KKHHDHBMFJB().SetFloat("ObscuredVector3 vs Vector3, ", 925f - this.vignette.desaturate);
				}
				this.COCHPLKIEGO().SetVector("ragulaEventProc", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1986f))
				{
					this.CFJAMJGLPBF().EnableKeyword("GestureNoFear");
					this.NMIDGHFFOBD().SetVector("CCDIK not found!", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.CJOMCEBOFKB().EnableKeyword("Idle Strafe Right");
					float z = (1212f - this.vignette.roundness) * 518f + this.vignette.roundness;
					this.NMIDGHFFOBD().SetVector("IdleStrafeLeft", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 7;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled)
			{
				pass = 5;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 3;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.OMDJPBECNBJ(), pass);
			this.JEIFLMLLOLG.ONDHPBGGNIA();
		}

		// Token: 0x0600C3C8 RID: 50120 RVA: 0x0058A76D File Offset: 0x0058896D
		public Material IHAKFMDJEGK()
		{
			if (this.BHHEHMIFMBD == null)
			{
				this.BHHEHMIFMBD = OOFCHDPCJIJ.DJFOEIJIMJB(this.KPIAFEFGHIP());
			}
			return this.BHHEHMIFMBD;
		}

		// Token: 0x0600C3C9 RID: 50121 RVA: 0x00581B1D File Offset: 0x0057FD1D
		private void ONOAKBGLIGM()
		{
			if (this.BHHEHMIFMBD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.BHHEHMIFMBD);
			}
			this.BHHEHMIFMBD = null;
			this.JEIFLMLLOLG.OHLNIGLKOEN();
		}

		// Token: 0x04001A0B RID: 6667
		[LensAberrations.FEEACNPHCLD]
		public LensAberrations.DistortionSettings distortion = LensAberrations.DistortionSettings.defaultSettings;

		// Token: 0x04001A0C RID: 6668
		[LensAberrations.FEEACNPHCLD]
		public LensAberrations.VignetteSettings vignette = LensAberrations.VignetteSettings.defaultSettings;

		// Token: 0x04001A0D RID: 6669
		[LensAberrations.FEEACNPHCLD]
		public LensAberrations.ChromaticAberrationSettings chromaticAberration = LensAberrations.ChromaticAberrationSettings.defaultSettings;

		// Token: 0x04001A0E RID: 6670
		[SerializeField]
		private Shader m_Shader;

		// Token: 0x04001A0F RID: 6671
		private Material BHHEHMIFMBD;

		// Token: 0x04001A10 RID: 6672
		private ICADPIDCHAM JEIFLMLLOLG;

		// Token: 0x02000384 RID: 900
		[AttributeUsage(AttributeTargets.Field)]
		public class FEEACNPHCLD : Attribute
		{
		}

		// Token: 0x02000385 RID: 901
		[AttributeUsage(AttributeTargets.Field)]
		public class IDFJNBHPDDL : Attribute
		{
		}

		// Token: 0x02000386 RID: 902
		[Serializable]
		public struct DistortionSettings
		{
			// Token: 0x0600C3CC RID: 50124 RVA: 0x0058A794 File Offset: 0x00588994
			public static LensAberrations.DistortionSettings GDKPNHJPBKJ()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1440f,
					centerX = 247f,
					centerY = 1261f,
					amountX = 248f,
					amountY = 1614f,
					scale = 297f
				};
			}

			// Token: 0x0600C3CD RID: 50125 RVA: 0x0058A7FC File Offset: 0x005889FC
			public static LensAberrations.DistortionSettings MDGIIBPIGJC()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1338f,
					centerX = 1691f,
					centerY = 1729f,
					amountX = 118f,
					amountY = 271f,
					scale = 1449f
				};
			}

			// Token: 0x0600C3CE RID: 50126 RVA: 0x0058A864 File Offset: 0x00588A64
			public static LensAberrations.DistortionSettings OCIMBHLOOGC()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 532f,
					centerX = 903f,
					centerY = 1879f,
					amountX = 1908f,
					amountY = 662f,
					scale = 217f
				};
			}

			// Token: 0x0600C3CF RID: 50127 RVA: 0x0058A8CC File Offset: 0x00588ACC
			public static LensAberrations.DistortionSettings FMLMIDJIEOP()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 818f,
					centerX = 516f,
					centerY = 1021f,
					amountX = 1625f,
					amountY = 1305f,
					scale = 1306f
				};
			}

			// Token: 0x0600C3D0 RID: 50128 RVA: 0x0058A934 File Offset: 0x00588B34
			public static LensAberrations.DistortionSettings CGGMKBADCBM()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1173f,
					centerX = 762f,
					centerY = 501f,
					amountX = 1945f,
					amountY = 312f,
					scale = 1003f
				};
			}

			// Token: 0x0600C3D1 RID: 50129 RVA: 0x0058A99C File Offset: 0x00588B9C
			public static LensAberrations.DistortionSettings OOFOKHIDMDG()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 867f,
					centerX = 1028f,
					centerY = 1304f,
					amountX = 984f,
					amountY = 257f,
					scale = 1980f
				};
			}

			// Token: 0x0600C3D2 RID: 50130 RVA: 0x0058AA04 File Offset: 0x00588C04
			public static LensAberrations.DistortionSettings FBBLPICJODA()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 919f,
					centerX = 216f,
					centerY = 179f,
					amountX = 411f,
					amountY = 1490f,
					scale = 254f
				};
			}

			// Token: 0x0600C3D3 RID: 50131 RVA: 0x0058AA6C File Offset: 0x00588C6C
			public static LensAberrations.DistortionSettings AAPKKAPOLKH()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 679f,
					centerX = 1084f,
					centerY = 953f,
					amountX = 1579f,
					amountY = 1217f,
					scale = 566f
				};
			}

			// Token: 0x0600C3D4 RID: 50132 RVA: 0x0058AAD4 File Offset: 0x00588CD4
			public static LensAberrations.DistortionSettings JPGMEJNEOCC()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 772f,
					centerX = 134f,
					centerY = 1012f,
					amountX = 243f,
					amountY = 1665f,
					scale = 153f
				};
			}

			// Token: 0x0600C3D5 RID: 50133 RVA: 0x0058AB3C File Offset: 0x00588D3C
			public static LensAberrations.DistortionSettings HLLBKJENCLA()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 117f,
					centerX = 863f,
					centerY = 1422f,
					amountX = 651f,
					amountY = 42f,
					scale = 1674f
				};
			}

			// Token: 0x0600C3D6 RID: 50134 RVA: 0x0058ABA4 File Offset: 0x00588DA4
			public static LensAberrations.DistortionSettings MDDBLMDKDAO()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1483f,
					centerX = 1337f,
					centerY = 1295f,
					amountX = 477f,
					amountY = 1746f,
					scale = 759f
				};
			}

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x0600C3D7 RID: 50135 RVA: 0x0058AC0C File Offset: 0x00588E0C
			public static LensAberrations.DistortionSettings defaultSettings
			{
				get
				{
					return new LensAberrations.DistortionSettings
					{
						enabled = false,
						amount = 0f,
						centerX = 0f,
						centerY = 0f,
						amountX = 1f,
						amountY = 1f,
						scale = 1f
					};
				}
			}

			// Token: 0x0600C3D8 RID: 50136 RVA: 0x0058AC74 File Offset: 0x00588E74
			public static LensAberrations.DistortionSettings MEFEDCEEAMK()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1973f,
					centerX = 89f,
					centerY = 971f,
					amountX = 1243f,
					amountY = 992f,
					scale = 83f
				};
			}

			// Token: 0x0600C3D9 RID: 50137 RVA: 0x0058ACDC File Offset: 0x00588EDC
			public static LensAberrations.DistortionSettings DELLGIGMFLC()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1483f,
					centerX = 844f,
					centerY = 958f,
					amountX = 925f,
					amountY = 1265f,
					scale = 1945f
				};
			}

			// Token: 0x0600C3DA RID: 50138 RVA: 0x0058AD44 File Offset: 0x00588F44
			public static LensAberrations.DistortionSettings HMDLEIJHKEP()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 235f,
					centerX = 506f,
					centerY = 849f,
					amountX = 4f,
					amountY = 323f,
					scale = 1522f
				};
			}

			// Token: 0x0600C3DB RID: 50139 RVA: 0x0058ADAC File Offset: 0x00588FAC
			public static LensAberrations.DistortionSettings NJJBBDIFPKH()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1131f,
					centerX = 969f,
					centerY = 1f,
					amountX = 1407f,
					amountY = 27f,
					scale = 1191f
				};
			}

			// Token: 0x0600C3DC RID: 50140 RVA: 0x0058AE14 File Offset: 0x00589014
			public static LensAberrations.DistortionSettings DHCNIDFOOPO()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 298f,
					centerX = 1682f,
					centerY = 1391f,
					amountX = 956f,
					amountY = 1270f,
					scale = 888f
				};
			}

			// Token: 0x0600C3DD RID: 50141 RVA: 0x0058AE7C File Offset: 0x0058907C
			public static LensAberrations.DistortionSettings OOKKEMFPNBJ()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 423f,
					centerX = 1320f,
					centerY = 1632f,
					amountX = 1748f,
					amountY = 1135f,
					scale = 598f
				};
			}

			// Token: 0x0600C3DE RID: 50142 RVA: 0x0058AEE4 File Offset: 0x005890E4
			public static LensAberrations.DistortionSettings COINKHKLJAP()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1966f,
					centerX = 494f,
					centerY = 1211f,
					amountX = 85f,
					amountY = 88f,
					scale = 1048f
				};
			}

			// Token: 0x0600C3DF RID: 50143 RVA: 0x0058AF4C File Offset: 0x0058914C
			public static LensAberrations.DistortionSettings PIAJOHPDMNA()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1764f,
					centerX = 1001f,
					centerY = 945f,
					amountX = 221f,
					amountY = 352f,
					scale = 138f
				};
			}

			// Token: 0x0600C3E0 RID: 50144 RVA: 0x0058AFB4 File Offset: 0x005891B4
			public static LensAberrations.DistortionSettings NNNMNENCOBC()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 107f,
					centerX = 1265f,
					centerY = 564f,
					amountX = 1494f,
					amountY = 1120f,
					scale = 1216f
				};
			}

			// Token: 0x0600C3E1 RID: 50145 RVA: 0x0058B01C File Offset: 0x0058921C
			public static LensAberrations.DistortionSettings MDDFLLOCDEA()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 411f,
					centerX = 1307f,
					centerY = 1500f,
					amountX = 823f,
					amountY = 349f,
					scale = 589f
				};
			}

			// Token: 0x0600C3E2 RID: 50146 RVA: 0x0058B084 File Offset: 0x00589284
			public static LensAberrations.DistortionSettings IGIKNGLDPJB()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1367f,
					centerX = 1501f,
					centerY = 665f,
					amountX = 631f,
					amountY = 1792f,
					scale = 350f
				};
			}

			// Token: 0x0600C3E3 RID: 50147 RVA: 0x0058B0EC File Offset: 0x005892EC
			public static LensAberrations.DistortionSettings NLCHLENDMLI()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 799f,
					centerX = 1701f,
					centerY = 95f,
					amountX = 1879f,
					amountY = 1271f,
					scale = 970f
				};
			}

			// Token: 0x0600C3E4 RID: 50148 RVA: 0x0058B154 File Offset: 0x00589354
			public static LensAberrations.DistortionSettings MKEJGGFNILJ()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1765f,
					centerX = 1900f,
					centerY = 1512f,
					amountX = 629f,
					amountY = 1749f,
					scale = 280f
				};
			}

			// Token: 0x0600C3E5 RID: 50149 RVA: 0x0058B1BC File Offset: 0x005893BC
			public static LensAberrations.DistortionSettings MJLLLKFIDOE()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1031f,
					centerX = 1580f,
					centerY = 65f,
					amountX = 41f,
					amountY = 1800f,
					scale = 148f
				};
			}

			// Token: 0x04001A11 RID: 6673
			public bool enabled;

			// Token: 0x04001A12 RID: 6674
			[Range(-100f, 100f)]
			[Tooltip("Distortion amount.")]
			public float amount;

			// Token: 0x04001A13 RID: 6675
			[Range(-1f, 1f)]
			[Tooltip("Distortion center point (X axis).")]
			public float centerX;

			// Token: 0x04001A14 RID: 6676
			[Range(-1f, 1f)]
			[Tooltip("Distortion center point (Y axis).")]
			public float centerY;

			// Token: 0x04001A15 RID: 6677
			[Range(0f, 1f)]
			[Tooltip("Amount multiplier on X axis. Set it to 0 to disable distortion on this axis.")]
			public float amountX;

			// Token: 0x04001A16 RID: 6678
			[Range(0f, 1f)]
			[Tooltip("Amount multiplier on Y axis. Set it to 0 to disable distortion on this axis.")]
			public float amountY;

			// Token: 0x04001A17 RID: 6679
			[Range(0.01f, 5f)]
			[Tooltip("Global screen scaling.")]
			public float scale;
		}

		// Token: 0x02000387 RID: 903
		[Serializable]
		public struct VignetteSettings
		{
			// Token: 0x0600C3E6 RID: 50150 RVA: 0x0058B224 File Offset: 0x00589424
			public static LensAberrations.VignetteSettings OOFOKHIDMDG()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1638f, 599f, 1979f, 1627f),
					center = new Vector2(1358f, 339f),
					intensity = 421f,
					smoothness = 1275f,
					roundness = 1188f,
					blur = 675f,
					desaturate = 1334f
				};
			}

			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x0600C3E7 RID: 50151 RVA: 0x0058B2B4 File Offset: 0x005894B4
			public static LensAberrations.VignetteSettings defaultSettings
			{
				get
				{
					return new LensAberrations.VignetteSettings
					{
						enabled = false,
						color = new Color(0f, 0f, 0f, 1f),
						center = new Vector2(0.5f, 0.5f),
						intensity = 1.4f,
						smoothness = 0.8f,
						roundness = 1f,
						blur = 0f,
						desaturate = 0f
					};
				}
			}

			// Token: 0x0600C3E8 RID: 50152 RVA: 0x0058B344 File Offset: 0x00589544
			public static LensAberrations.VignetteSettings DHCNIDFOOPO()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(381f, 197f, 1338f, 719f),
					center = new Vector2(420f, 1203f),
					intensity = 179f,
					smoothness = 1090f,
					roundness = 840f,
					blur = 1549f,
					desaturate = 949f
				};
			}

			// Token: 0x0600C3E9 RID: 50153 RVA: 0x0058B3D4 File Offset: 0x005895D4
			public static LensAberrations.VignetteSettings JPGMEJNEOCC()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(224f, 1475f, 1335f, 1101f),
					center = new Vector2(791f, 1807f),
					intensity = 1344f,
					smoothness = 729f,
					roundness = 1667f,
					blur = 251f,
					desaturate = 1248f
				};
			}

			// Token: 0x0600C3EA RID: 50154 RVA: 0x0058B464 File Offset: 0x00589664
			public static LensAberrations.VignetteSettings CGGMKBADCBM()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1268f, 1776f, 1846f, 1819f),
					center = new Vector2(1290f, 1181f),
					intensity = 1270f,
					smoothness = 1397f,
					roundness = 256f,
					blur = 1926f,
					desaturate = 23f
				};
			}

			// Token: 0x0600C3EB RID: 50155 RVA: 0x0058B4F4 File Offset: 0x005896F4
			public static LensAberrations.VignetteSettings MJLLLKFIDOE()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(363f, 1004f, 366f, 1451f),
					center = new Vector2(66f, 56f),
					intensity = 539f,
					smoothness = 1922f,
					roundness = 1505f,
					blur = 1609f,
					desaturate = 804f
				};
			}

			// Token: 0x0600C3EC RID: 50156 RVA: 0x0058B584 File Offset: 0x00589784
			public static LensAberrations.VignetteSettings MDDFLLOCDEA()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1509f, 304f, 1282f, 411f),
					center = new Vector2(1529f, 659f),
					intensity = 1103f,
					smoothness = 1144f,
					roundness = 1166f,
					blur = 751f,
					desaturate = 549f
				};
			}

			// Token: 0x0600C3ED RID: 50157 RVA: 0x0058B614 File Offset: 0x00589814
			public static LensAberrations.VignetteSettings OOKKEMFPNBJ()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(7f, 1145f, 1657f, 272f),
					center = new Vector2(1675f, 413f),
					intensity = 745f,
					smoothness = 1289f,
					roundness = 717f,
					blur = 1754f,
					desaturate = 1323f
				};
			}

			// Token: 0x0600C3EE RID: 50158 RVA: 0x0058B6A4 File Offset: 0x005898A4
			public static LensAberrations.VignetteSettings FBBLPICJODA()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1119f, 318f, 1304f, 136f),
					center = new Vector2(1939f, 266f),
					intensity = 876f,
					smoothness = 907f,
					roundness = 578f,
					blur = 1803f,
					desaturate = 287f
				};
			}

			// Token: 0x0600C3EF RID: 50159 RVA: 0x0058B734 File Offset: 0x00589934
			public static LensAberrations.VignetteSettings FMLMIDJIEOP()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1947f, 1793f, 1716f, 1549f),
					center = new Vector2(397f, 1795f),
					intensity = 1966f,
					smoothness = 1807f,
					roundness = 504f,
					blur = 731f,
					desaturate = 1700f
				};
			}

			// Token: 0x0600C3F0 RID: 50160 RVA: 0x0058B7C4 File Offset: 0x005899C4
			public static LensAberrations.VignetteSettings AAPKKAPOLKH()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(486f, 425f, 1767f, 140f),
					center = new Vector2(1519f, 566f),
					intensity = 1015f,
					smoothness = 163f,
					roundness = 158f,
					blur = 673f,
					desaturate = 28f
				};
			}

			// Token: 0x0600C3F1 RID: 50161 RVA: 0x0058B854 File Offset: 0x00589A54
			public static LensAberrations.VignetteSettings MDGIIBPIGJC()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1993f, 595f, 63f, 1774f),
					center = new Vector2(1044f, 1766f),
					intensity = 135f,
					smoothness = 150f,
					roundness = 1975f,
					blur = 455f,
					desaturate = 1458f
				};
			}

			// Token: 0x0600C3F2 RID: 50162 RVA: 0x0058B8E4 File Offset: 0x00589AE4
			public static LensAberrations.VignetteSettings MKEJGGFNILJ()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1324f, 614f, 1600f, 1358f),
					center = new Vector2(1789f, 836f),
					intensity = 1228f,
					smoothness = 1988f,
					roundness = 402f,
					blur = 1937f,
					desaturate = 1490f
				};
			}

			// Token: 0x0600C3F3 RID: 50163 RVA: 0x0058B974 File Offset: 0x00589B74
			public static LensAberrations.VignetteSettings GDKPNHJPBKJ()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1905f, 1406f, 1721f, 92f),
					center = new Vector2(367f, 1739f),
					intensity = 1292f,
					smoothness = 734f,
					roundness = 349f,
					blur = 1738f,
					desaturate = 1443f
				};
			}

			// Token: 0x0600C3F4 RID: 50164 RVA: 0x0058BA04 File Offset: 0x00589C04
			public static LensAberrations.VignetteSettings DELLGIGMFLC()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(466f, 1444f, 1283f, 594f),
					center = new Vector2(517f, 1693f),
					intensity = 1449f,
					smoothness = 280f,
					roundness = 108f,
					blur = 522f,
					desaturate = 924f
				};
			}

			// Token: 0x0600C3F5 RID: 50165 RVA: 0x0058BA94 File Offset: 0x00589C94
			public static LensAberrations.VignetteSettings NNNMNENCOBC()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1506f, 1594f, 1804f, 1106f),
					center = new Vector2(244f, 766f),
					intensity = 1154f,
					smoothness = 1866f,
					roundness = 1329f,
					blur = 522f,
					desaturate = 523f
				};
			}

			// Token: 0x0600C3F6 RID: 50166 RVA: 0x0058BB24 File Offset: 0x00589D24
			public static LensAberrations.VignetteSettings COINKHKLJAP()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1732f, 324f, 1821f, 460f),
					center = new Vector2(1066f, 1357f),
					intensity = 1876f,
					smoothness = 182f,
					roundness = 547f,
					blur = 235f,
					desaturate = 639f
				};
			}

			// Token: 0x0600C3F7 RID: 50167 RVA: 0x0058BBB4 File Offset: 0x00589DB4
			public static LensAberrations.VignetteSettings NJJBBDIFPKH()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(760f, 1267f, 102f, 129f),
					center = new Vector2(1888f, 1529f),
					intensity = 1755f,
					smoothness = 916f,
					roundness = 146f,
					blur = 765f,
					desaturate = 1624f
				};
			}

			// Token: 0x0600C3F8 RID: 50168 RVA: 0x0058BC44 File Offset: 0x00589E44
			public static LensAberrations.VignetteSettings HMDLEIJHKEP()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1614f, 1715f, 860f, 788f),
					center = new Vector2(1839f, 481f),
					intensity = 406f,
					smoothness = 214f,
					roundness = 383f,
					blur = 1774f,
					desaturate = 1499f
				};
			}

			// Token: 0x0600C3F9 RID: 50169 RVA: 0x0058BCD4 File Offset: 0x00589ED4
			public static LensAberrations.VignetteSettings OCIMBHLOOGC()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(757f, 543f, 1007f, 77f),
					center = new Vector2(710f, 1710f),
					intensity = 701f,
					smoothness = 923f,
					roundness = 1902f,
					blur = 1937f,
					desaturate = 1008f
				};
			}

			// Token: 0x0600C3FA RID: 50170 RVA: 0x0058BD64 File Offset: 0x00589F64
			public static LensAberrations.VignetteSettings IGIKNGLDPJB()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(671f, 170f, 26f, 1591f),
					center = new Vector2(658f, 573f),
					intensity = 1214f,
					smoothness = 779f,
					roundness = 128f,
					blur = 1536f,
					desaturate = 171f
				};
			}

			// Token: 0x0600C3FB RID: 50171 RVA: 0x0058BDF4 File Offset: 0x00589FF4
			public static LensAberrations.VignetteSettings MDDBLMDKDAO()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(383f, 1379f, 367f, 307f),
					center = new Vector2(770f, 1255f),
					intensity = 133f,
					smoothness = 367f,
					roundness = 187f,
					blur = 1854f,
					desaturate = 475f
				};
			}

			// Token: 0x0600C3FC RID: 50172 RVA: 0x0058BE84 File Offset: 0x0058A084
			public static LensAberrations.VignetteSettings NLCHLENDMLI()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(79f, 468f, 724f, 1823f),
					center = new Vector2(1509f, 1860f),
					intensity = 422f,
					smoothness = 1772f,
					roundness = 1641f,
					blur = 417f,
					desaturate = 1507f
				};
			}

			// Token: 0x0600C3FD RID: 50173 RVA: 0x0058BF14 File Offset: 0x0058A114
			public static LensAberrations.VignetteSettings HLLBKJENCLA()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(257f, 1425f, 1700f, 103f),
					center = new Vector2(13f, 1265f),
					intensity = 1083f,
					smoothness = 929f,
					roundness = 536f,
					blur = 1807f,
					desaturate = 171f
				};
			}

			// Token: 0x0600C3FE RID: 50174 RVA: 0x0058BFA4 File Offset: 0x0058A1A4
			public static LensAberrations.VignetteSettings PIAJOHPDMNA()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(157f, 819f, 1265f, 1156f),
					center = new Vector2(1902f, 1243f),
					intensity = 231f,
					smoothness = 1305f,
					roundness = 559f,
					blur = 1870f,
					desaturate = 506f
				};
			}

			// Token: 0x0600C3FF RID: 50175 RVA: 0x0058C034 File Offset: 0x0058A234
			public static LensAberrations.VignetteSettings MEFEDCEEAMK()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1568f, 1860f, 1945f, 400f),
					center = new Vector2(1797f, 916f),
					intensity = 1643f,
					smoothness = 453f,
					roundness = 982f,
					blur = 748f,
					desaturate = 1727f
				};
			}

			// Token: 0x04001A18 RID: 6680
			public bool enabled;

			// Token: 0x04001A19 RID: 6681
			[ColorUsage(false)]
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			public Color color;

			// Token: 0x04001A1A RID: 6682
			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			// Token: 0x04001A1B RID: 6683
			[Tooltip("Amount of vignetting on screen.")]
			[Range(0f, 3f)]
			public float intensity;

			// Token: 0x04001A1C RID: 6684
			[Tooltip("Smoothness of the vignette borders.")]
			[Range(0.01f, 3f)]
			public float smoothness;

			// Token: 0x04001A1D RID: 6685
			[LensAberrations.IDFJNBHPDDL]
			[Range(0f, 1f)]
			[Tooltip("Lower values will make a square-ish vignette.")]
			public float roundness;

			// Token: 0x04001A1E RID: 6686
			[Range(0f, 1f)]
			[Tooltip("Blurs the corners of the screen. Leave this at 0 to disable it.")]
			public float blur;

			// Token: 0x04001A1F RID: 6687
			[Range(0f, 1f)]
			[Tooltip("Desaturate the corners of the screen. Leave this to 0 to disable it.")]
			public float desaturate;
		}

		// Token: 0x02000388 RID: 904
		[Serializable]
		public struct ChromaticAberrationSettings
		{
			// Token: 0x0600C400 RID: 50176 RVA: 0x0058C0C4 File Offset: 0x0058A2C4
			public static LensAberrations.ChromaticAberrationSettings BJNIBDPAHBP()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1803f
				};
			}

			// Token: 0x0600C401 RID: 50177 RVA: 0x0058C0FC File Offset: 0x0058A2FC
			public static LensAberrations.ChromaticAberrationSettings JGNKGPFJFHO()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1180f
				};
			}

			// Token: 0x0600C402 RID: 50178 RVA: 0x0058C134 File Offset: 0x0058A334
			public static LensAberrations.ChromaticAberrationSettings OCIMBHLOOGC()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 195f
				};
			}

			// Token: 0x0600C403 RID: 50179 RVA: 0x0058C16C File Offset: 0x0058A36C
			public static LensAberrations.ChromaticAberrationSettings GCAMLJAKCPF()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1364f
				};
			}

			// Token: 0x0600C404 RID: 50180 RVA: 0x0058C1A4 File Offset: 0x0058A3A4
			public static LensAberrations.ChromaticAberrationSettings MJLLLKFIDOE()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1345f
				};
			}

			// Token: 0x0600C405 RID: 50181 RVA: 0x0058C1DC File Offset: 0x0058A3DC
			public static LensAberrations.ChromaticAberrationSettings OOKKEMFPNBJ()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 877f
				};
			}

			// Token: 0x0600C406 RID: 50182 RVA: 0x0058C214 File Offset: 0x0058A414
			public static LensAberrations.ChromaticAberrationSettings BFFANDBCLFI()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1944f
				};
			}

			// Token: 0x0600C407 RID: 50183 RVA: 0x0058C24C File Offset: 0x0058A44C
			public static LensAberrations.ChromaticAberrationSettings COJPKDJKJAM()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 660f
				};
			}

			// Token: 0x0600C408 RID: 50184 RVA: 0x0058C284 File Offset: 0x0058A484
			public static LensAberrations.ChromaticAberrationSettings COINKHKLJAP()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 282f
				};
			}

			// Token: 0x0600C409 RID: 50185 RVA: 0x0058C2BC File Offset: 0x0058A4BC
			public static LensAberrations.ChromaticAberrationSettings ELPHMKAEDHE()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1450f
				};
			}

			// Token: 0x0600C40A RID: 50186 RVA: 0x0058C2F4 File Offset: 0x0058A4F4
			public static LensAberrations.ChromaticAberrationSettings MEFEDCEEAMK()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1553f
				};
			}

			// Token: 0x0600C40B RID: 50187 RVA: 0x0058C32C File Offset: 0x0058A52C
			public static LensAberrations.ChromaticAberrationSettings MKEJGGFNILJ()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1848f
				};
			}

			// Token: 0x0600C40C RID: 50188 RVA: 0x0058C364 File Offset: 0x0058A564
			public static LensAberrations.ChromaticAberrationSettings BNGFNAFFAME()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1945f
				};
			}

			// Token: 0x0600C40D RID: 50189 RVA: 0x0058C39C File Offset: 0x0058A59C
			public static LensAberrations.ChromaticAberrationSettings LNGBMOGJKGD()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1378f
				};
			}

			// Token: 0x0600C40E RID: 50190 RVA: 0x0058C3D4 File Offset: 0x0058A5D4
			public static LensAberrations.ChromaticAberrationSettings OOFOKHIDMDG()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1995f
				};
			}

			// Token: 0x0600C40F RID: 50191 RVA: 0x0058C40C File Offset: 0x0058A60C
			public static LensAberrations.ChromaticAberrationSettings NJJBBDIFPKH()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 70f
				};
			}

			// Token: 0x0600C410 RID: 50192 RVA: 0x0058C444 File Offset: 0x0058A644
			public static LensAberrations.ChromaticAberrationSettings MDDBLMDKDAO()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 454f
				};
			}

			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x0600C411 RID: 50193 RVA: 0x0058C47C File Offset: 0x0058A67C
			public static LensAberrations.ChromaticAberrationSettings defaultSettings
			{
				get
				{
					return new LensAberrations.ChromaticAberrationSettings
					{
						enabled = false,
						color = Color.green,
						amount = 0f
					};
				}
			}

			// Token: 0x0600C412 RID: 50194 RVA: 0x0058C4B4 File Offset: 0x0058A6B4
			public static LensAberrations.ChromaticAberrationSettings NPEIGPHIHFP()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1162f
				};
			}

			// Token: 0x0600C413 RID: 50195 RVA: 0x0058C4EC File Offset: 0x0058A6EC
			public static LensAberrations.ChromaticAberrationSettings AAPKKAPOLKH()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1592f
				};
			}

			// Token: 0x0600C414 RID: 50196 RVA: 0x0058C524 File Offset: 0x0058A724
			public static LensAberrations.ChromaticAberrationSettings MEBNDNNHNMB()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1669f
				};
			}

			// Token: 0x0600C415 RID: 50197 RVA: 0x0058C55C File Offset: 0x0058A75C
			public static LensAberrations.ChromaticAberrationSettings ADJNPGFJGJI()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1436f
				};
			}

			// Token: 0x0600C416 RID: 50198 RVA: 0x0058C594 File Offset: 0x0058A794
			public static LensAberrations.ChromaticAberrationSettings JPGMEJNEOCC()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 674f
				};
			}

			// Token: 0x0600C417 RID: 50199 RVA: 0x0058C5CC File Offset: 0x0058A7CC
			public static LensAberrations.ChromaticAberrationSettings NNNMNENCOBC()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1467f
				};
			}

			// Token: 0x0600C418 RID: 50200 RVA: 0x0058C604 File Offset: 0x0058A804
			public static LensAberrations.ChromaticAberrationSettings HIPJDBACJDH()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 549f
				};
			}

			// Token: 0x0600C419 RID: 50201 RVA: 0x0058C63C File Offset: 0x0058A83C
			public static LensAberrations.ChromaticAberrationSettings CGGMKBADCBM()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1320f
				};
			}

			// Token: 0x0600C41A RID: 50202 RVA: 0x0058C674 File Offset: 0x0058A874
			public static LensAberrations.ChromaticAberrationSettings HMDLEIJHKEP()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1926f
				};
			}

			// Token: 0x0600C41B RID: 50203 RVA: 0x0058C6AC File Offset: 0x0058A8AC
			public static LensAberrations.ChromaticAberrationSettings HMKDCFKBINK()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1832f
				};
			}

			// Token: 0x0600C41C RID: 50204 RVA: 0x0058C6E4 File Offset: 0x0058A8E4
			public static LensAberrations.ChromaticAberrationSettings MCLJECOKBEJ()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1426f
				};
			}

			// Token: 0x0600C41D RID: 50205 RVA: 0x0058C71C File Offset: 0x0058A91C
			public static LensAberrations.ChromaticAberrationSettings FMLMIDJIEOP()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1072f
				};
			}

			// Token: 0x0600C41E RID: 50206 RVA: 0x0058C754 File Offset: 0x0058A954
			public static LensAberrations.ChromaticAberrationSettings IGIKNGLDPJB()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1489f
				};
			}

			// Token: 0x0600C41F RID: 50207 RVA: 0x0058C78C File Offset: 0x0058A98C
			public static LensAberrations.ChromaticAberrationSettings HLLBKJENCLA()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 598f
				};
			}

			// Token: 0x0600C420 RID: 50208 RVA: 0x0058C7C4 File Offset: 0x0058A9C4
			public static LensAberrations.ChromaticAberrationSettings NMGNPHGAGGA()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 972f
				};
			}

			// Token: 0x0600C421 RID: 50209 RVA: 0x0058C7FC File Offset: 0x0058A9FC
			public static LensAberrations.ChromaticAberrationSettings ILFHFFCIBPJ()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 885f
				};
			}

			// Token: 0x0600C422 RID: 50210 RVA: 0x0058C834 File Offset: 0x0058AA34
			public static LensAberrations.ChromaticAberrationSettings FBBLPICJODA()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1077f
				};
			}

			// Token: 0x0600C423 RID: 50211 RVA: 0x0058C86C File Offset: 0x0058AA6C
			public static LensAberrations.ChromaticAberrationSettings DHCNIDFOOPO()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 903f
				};
			}

			// Token: 0x0600C424 RID: 50212 RVA: 0x0058C8A4 File Offset: 0x0058AAA4
			public static LensAberrations.ChromaticAberrationSettings JACPKLDIIKG()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1188f
				};
			}

			// Token: 0x0600C425 RID: 50213 RVA: 0x0058C8DC File Offset: 0x0058AADC
			public static LensAberrations.ChromaticAberrationSettings MGIIIBAJNIE()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 488f
				};
			}

			// Token: 0x0600C426 RID: 50214 RVA: 0x0058C914 File Offset: 0x0058AB14
			public static LensAberrations.ChromaticAberrationSettings GDKPNHJPBKJ()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1215f
				};
			}

			// Token: 0x0600C427 RID: 50215 RVA: 0x0058C94C File Offset: 0x0058AB4C
			public static LensAberrations.ChromaticAberrationSettings DCMDLNNCGAC()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1614f
				};
			}

			// Token: 0x0600C428 RID: 50216 RVA: 0x0058C984 File Offset: 0x0058AB84
			public static LensAberrations.ChromaticAberrationSettings PIAJOHPDMNA()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 702f
				};
			}

			// Token: 0x0600C429 RID: 50217 RVA: 0x0058C9BC File Offset: 0x0058ABBC
			public static LensAberrations.ChromaticAberrationSettings NLCHLENDMLI()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1246f
				};
			}

			// Token: 0x0600C42A RID: 50218 RVA: 0x0058C9F4 File Offset: 0x0058ABF4
			public static LensAberrations.ChromaticAberrationSettings MDDFLLOCDEA()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1433f
				};
			}

			// Token: 0x0600C42B RID: 50219 RVA: 0x0058CA2C File Offset: 0x0058AC2C
			public static LensAberrations.ChromaticAberrationSettings MDGIIBPIGJC()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1872f
				};
			}

			// Token: 0x0600C42C RID: 50220 RVA: 0x0058CA64 File Offset: 0x0058AC64
			public static LensAberrations.ChromaticAberrationSettings DELLGIGMFLC()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 745f
				};
			}

			// Token: 0x04001A20 RID: 6688
			public bool enabled;

			// Token: 0x04001A21 RID: 6689
			[ColorUsage(false)]
			[Tooltip("Channels to apply chromatic aberration to.")]
			public Color color;

			// Token: 0x04001A22 RID: 6690
			[Range(-50f, 50f)]
			[Tooltip("Amount of tangential distortion.")]
			public float amount;
		}

		// Token: 0x02000389 RID: 905
		private enum LLOBBEIBCHE
		{
			// Token: 0x04001A24 RID: 6692
			BlurPrePass,
			// Token: 0x04001A25 RID: 6693
			Chroma,
			// Token: 0x04001A26 RID: 6694
			Distort,
			// Token: 0x04001A27 RID: 6695
			Vignette,
			// Token: 0x04001A28 RID: 6696
			ChromaDistort,
			// Token: 0x04001A29 RID: 6697
			ChromaVignette,
			// Token: 0x04001A2A RID: 6698
			DistortVignette,
			// Token: 0x04001A2B RID: 6699
			ChromaDistortVignette
		}
	}
}
