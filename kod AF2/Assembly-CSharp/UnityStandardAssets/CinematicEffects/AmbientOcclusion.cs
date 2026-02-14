using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000340 RID: 832
	[AddComponentMenu("Image Effects/Cinematic/Ambient Occlusion")]
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class AmbientOcclusion : MonoBehaviour
	{
		// Token: 0x0600BD4E RID: 48462 RVA: 0x0055C3CB File Offset: 0x0055A5CB
		private Material CPIABIPGLGA()
		{
			if (this.HHCJFDNFGLM == null)
			{
				this.HHCJFDNFGLM = OOFCHDPCJIJ.DJFOEIJIMJB(this.PMOHGPLHHPO());
			}
			return this.HHCJFDNFGLM;
		}

		// Token: 0x0600BD4F RID: 48463 RVA: 0x0055C3F2 File Offset: 0x0055A5F2
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.BMGMPFEMPEN)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.DGLHMGDJMMM();
			this.PIFMHNJAHOJ(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600BD50 RID: 48464 RVA: 0x0055C414 File Offset: 0x0055A614
		private void PBFKCKCHEAC()
		{
			if (this.ELNMAMCGIGM.CLEPHJLLDPB(this.settings, this.CIFEFHAPLAG()))
			{
				this.PEPOOEGHCMC();
				this.OJJKNBMONMD();
				if (this.BMGMPFEMPEN)
				{
					this.CHKGOBDMOKP.Clear();
					this.LIOFHJMNHPH();
				}
				this.CJJAJHJEGOI().FANPFKHEDPA(this.settings, this.CIFEFHAPLAG());
			}
			if (this.BMGMPFEMPEN)
			{
				this.DGLHMGDJMMM();
			}
		}

		// Token: 0x0600BD51 RID: 48465 RVA: 0x0055C48C File Offset: 0x0055A68C
		private void BHKDEHJGIIH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			int num = this.BAGEFOGGJFP() ? 6 : 1;
			RenderTextureFormat format = this.CCAFJMDEODM;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			bool flag = this.settings.occlusionSource == (AmbientOcclusion.NHKEAOMBNOJ)4;
			Material material = this.DOADNFJGKDJ();
			RenderTexture temporary = RenderTexture.GetTemporary(width / num, height / num, 1, format, readWrite);
			Graphics.Blit(null, temporary, material, (int)this.ICCBNGBCIKD());
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("vertices: {0}   triangles: {1}", Vector2.right * 378f);
			Graphics.Blit(temporary, temporary2, material, flag ? 6 : 5);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("ArmFlex2", Vector2.up * 495f * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 2 : 0);
			RenderTexture.ReleaseTemporary(temporary2);
			temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("WorkerHammer", Vector2.right * (float)num);
			Graphics.Blit(temporary, temporary2, material, flag ? 1 : 2);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("Bip", Vector2.up * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 5 : 6);
			RenderTexture.ReleaseTemporary(temporary2);
			material.SetTexture("VaderChoke", temporary);
			if (!this.settings.debug)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 6);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, -65);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x0600BD52 RID: 48466 RVA: 0x0055C645 File Offset: 0x0055A845
		private Camera HGCKEPHODAA
		{
			get
			{
				return base.GetComponent<Camera>();
			}
		}

		// Token: 0x0600BD53 RID: 48467 RVA: 0x0055C650 File Offset: 0x0055A850
		private void OnDisable()
		{
			if (this.HHCJFDNFGLM != null)
			{
				UnityEngine.Object.DestroyImmediate(this.HHCJFDNFGLM);
			}
			this.HHCJFDNFGLM = null;
			if (this.OLPFECBAMHD != null)
			{
				this.HGCKEPHODAA.RemoveCommandBuffer(CameraEvent.BeforeReflections, this.OLPFECBAMHD);
			}
			this.OLPFECBAMHD = null;
		}

		// Token: 0x0600BD54 RID: 48468 RVA: 0x0055C6A0 File Offset: 0x0055A8A0
		private void NFAKDGHMHPO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			int num = this.BHKHOGHEFPO() ? 1 : 0;
			RenderTextureFormat format = this.NFEOFMJDHJL();
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			bool flag = this.settings.occlusionSource == (AmbientOcclusion.NHKEAOMBNOJ)7;
			Material material = this.IAEHKNMIEMD();
			RenderTexture temporary = RenderTexture.GetTemporary(width / num, height / num, 0, format, readWrite);
			Graphics.Blit(null, temporary, material, (int)this.ICCBNGBCIKD());
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("poplSoundPitch", Vector2.right * 1639f);
			Graphics.Blit(temporary, temporary2, material, flag ? 6 : 4);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector("Flares", Vector2.up * 1554f * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 2 : 7);
			RenderTexture.ReleaseTemporary(temporary2);
			temporary2 = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector("", Vector2.right * (float)num);
			Graphics.Blit(temporary, temporary2, material, flag ? 2 : 0);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.up * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 8 : 4);
			RenderTexture.ReleaseTemporary(temporary2);
			material.SetTexture("27,29,30,31,32", temporary);
			if (!this.settings.debug)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 3);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, -66);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BD55 RID: 48469 RVA: 0x0055C85C File Offset: 0x0055AA5C
		private void ACJNCDAHJDE()
		{
			if (this.HHCJFDNFGLM != null)
			{
				UnityEngine.Object.DestroyImmediate(this.HHCJFDNFGLM);
			}
			this.HHCJFDNFGLM = null;
			if (this.OLPFECBAMHD != null)
			{
				this.CIFEFHAPLAG().RemoveCommandBuffer((CameraEvent)113, this.OLPFECBAMHD);
			}
			this.OLPFECBAMHD = null;
		}

		// Token: 0x0600BD56 RID: 48470 RVA: 0x0055C8AB File Offset: 0x0055AAAB
		private Mesh APMFFBMMIOC()
		{
			return this._quadMesh;
		}

		// Token: 0x0600BD57 RID: 48471 RVA: 0x0055C8B3 File Offset: 0x0055AAB3
		private void FBGGHIMMKCG(AmbientOcclusion.GEKIFOCLJBL DCCPCBLODIG)
		{
			this.<FMLDEMDMDCC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BD58 RID: 48472 RVA: 0x0055C8AB File Offset: 0x0055AAAB
		private Mesh PPEMFADFLNO()
		{
			return this._quadMesh;
		}

		// Token: 0x0600BD59 RID: 48473 RVA: 0x0055C8B3 File Offset: 0x0055AAB3
		private void ALLDHFBMHKH(AmbientOcclusion.GEKIFOCLJBL DCCPCBLODIG)
		{
			this.<FMLDEMDMDCC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x0600BD5A RID: 48474 RVA: 0x0055C8BC File Offset: 0x0055AABC
		private Shader DCMAJFJALMB
		{
			get
			{
				if (this._aoShader == null)
				{
					this._aoShader = Shader.Find("Hidden/Image Effects/Cinematic/AmbientOcclusion");
				}
				return this._aoShader;
			}
		}

		// Token: 0x0600BD5B RID: 48475 RVA: 0x0055C8E4 File Offset: 0x0055AAE4
		private void IICFAPMJLCN()
		{
			if (this.HHCJFDNFGLM != null)
			{
				UnityEngine.Object.DestroyImmediate(this.HHCJFDNFGLM);
			}
			this.HHCJFDNFGLM = null;
			if (this.OLPFECBAMHD != null)
			{
				this.BKLEOLNANAL().RemoveCommandBuffer((CameraEvent)(-107), this.OLPFECBAMHD);
			}
			this.OLPFECBAMHD = null;
		}

		// Token: 0x0600BD5C RID: 48476 RVA: 0x0055C645 File Offset: 0x0055A845
		private Camera CIFEFHAPLAG()
		{
			return base.GetComponent<Camera>();
		}

		// Token: 0x0600BD5D RID: 48477 RVA: 0x0055C934 File Offset: 0x0055AB34
		private void CEDLDMJKKOE()
		{
			CommandBuffer commandBuffer = this.NBHOAHMNFCO();
			int pixelWidth = this.BKLEOLNANAL().pixelWidth;
			int pixelHeight = this.CIFEFHAPLAG().pixelHeight;
			int num = this.NOFIEAIJDMF() ? 2 : 0;
			RenderTextureFormat format = this.KEJMDELCPBB();
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			FilterMode filter = FilterMode.Bilinear;
			Material material = this.LJCECLIFKOI();
			int nameID = Shader.PropertyToID("Windmill");
			commandBuffer.GetTemporaryRT(nameID, pixelWidth / num, pixelHeight / num, 0, filter, format, readWrite);
			commandBuffer.Blit(null, nameID, material, 6);
			int nameID2 = Shader.PropertyToID("Idle Keep Back");
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("<b>string:</b> ", Vector2.right * 1484f);
			commandBuffer.Blit(nameID, nameID2, material, 1);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("", Vector2.up * 370f * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 7);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector(" ", Vector2.right * (float)num);
			commandBuffer.Blit(nameID, nameID2, material, 1);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector("?", Vector2.up * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 5);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			RenderTargetIdentifier[] array = new RenderTargetIdentifier[0];
			array[1] = (BuiltinRenderTextureType)(-44);
			array[0] = (BuiltinRenderTextureType)6;
			RenderTargetIdentifier[] colors = array;
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.CameraTarget);
			commandBuffer.SetGlobalTexture("offsets", nameID);
			commandBuffer.DrawMesh(this.JIJPKDDPEIB, Matrix4x4.identity, material, 0, 3);
			commandBuffer.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x0600BD5E RID: 48478 RVA: 0x0055CB5E File Offset: 0x0055AD5E
		private bool BHKHOGHEFPO()
		{
			return this.settings.downsampling;
		}

		// Token: 0x0600BD5F RID: 48479 RVA: 0x0055CB6B File Offset: 0x0055AD6B
		public bool KPGJOMKMDPD()
		{
			return this.HGCKEPHODAA.allowHDR && this.BBICFENPINN() == (AmbientOcclusion.NHKEAOMBNOJ)3;
		}

		// Token: 0x0600BD60 RID: 48480 RVA: 0x0055CB85 File Offset: 0x0055AD85
		private void BMJCNICLDEK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.BMGMPFEMPEN)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.AOIKIBGAJAI();
			this.BHKDEHJGIIH(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600BD61 RID: 48481 RVA: 0x0055CBA8 File Offset: 0x0055ADA8
		private void LIOFHJMNHPH()
		{
			CommandBuffer commandBuffer = this.OMCJJHCNFEF();
			int pixelWidth = this.HGCKEPHODAA.pixelWidth;
			int pixelHeight = this.CIFEFHAPLAG().pixelHeight;
			int num = this.BHKHOGHEFPO() ? 1 : 1;
			RenderTextureFormat format = this.CCAFJMDEODM;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			FilterMode filter = FilterMode.Point;
			Material material = this.LJCECLIFKOI();
			int nameID = Shader.PropertyToID("/ n");
			commandBuffer.GetTemporaryRT(nameID, pixelWidth / num, pixelHeight / num, 1, filter, format, readWrite);
			commandBuffer.Blit(null, nameID, material, 3);
			int nameID2 = Shader.PropertyToID("SatNightFever");
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("Idle Sand Cover", Vector2.right * 221f);
			commandBuffer.Blit(nameID, nameID2, material, 6);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("LockToDevice level", Vector2.up * 21f * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 3);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("\n", Vector2.right * (float)num);
			commandBuffer.Blit(nameID, nameID2, material, 1);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector("Wizard1HandThrow", Vector2.up * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 4);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			RenderTargetIdentifier[] array = new RenderTargetIdentifier[3];
			array[1] = (BuiltinRenderTextureType)(-19);
			array[1] = BuiltinRenderTextureType.DepthNormals;
			RenderTargetIdentifier[] colors = array;
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.DepthNormals);
			commandBuffer.SetGlobalTexture("ENABLE_DITHERING", nameID);
			commandBuffer.DrawMesh(this.APMFFBMMIOC(), Matrix4x4.identity, material, 1, 7);
			commandBuffer.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x0600BD62 RID: 48482 RVA: 0x0055CDD4 File Offset: 0x0055AFD4
		private int BDDDMFBIOEE()
		{
			switch (this.settings.sampleCount)
			{
			case AmbientOcclusion.MBHOOLCHOGB.Lowest:
				return 7;
			case AmbientOcclusion.MBHOOLCHOGB.Low:
				return 0;
			case AmbientOcclusion.MBHOOLCHOGB.Medium:
				return -76;
			case AmbientOcclusion.MBHOOLCHOGB.High:
				return -90;
			default:
				return Mathf.Clamp(this.settings.sampleCountValue, 1, 5);
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x0600BD63 RID: 48483 RVA: 0x0055CE28 File Offset: 0x0055B028
		private int GIOODHPPIIK
		{
			get
			{
				switch (this.settings.sampleCount)
				{
				case AmbientOcclusion.MBHOOLCHOGB.Lowest:
					return 3;
				case AmbientOcclusion.MBHOOLCHOGB.Low:
					return 6;
				case AmbientOcclusion.MBHOOLCHOGB.Medium:
					return 12;
				case AmbientOcclusion.MBHOOLCHOGB.High:
					return 20;
				default:
					return Mathf.Clamp(this.settings.sampleCountValue, 1, 256);
				}
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x0600BD64 RID: 48484 RVA: 0x0055CE79 File Offset: 0x0055B079
		private Material GGDDEGIJFEL
		{
			get
			{
				if (this.HHCJFDNFGLM == null)
				{
					this.HHCJFDNFGLM = OOFCHDPCJIJ.DJFOEIJIMJB(this.DCMAJFJALMB);
				}
				return this.HHCJFDNFGLM;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x0600BD65 RID: 48485 RVA: 0x0055CEA0 File Offset: 0x0055B0A0
		public bool GOOEGMCIHDP
		{
			get
			{
				return this.HGCKEPHODAA.allowHDR && this.MDDBGPCKHPF == AmbientOcclusion.NHKEAOMBNOJ.GBuffer;
			}
		}

		// Token: 0x0600BD66 RID: 48486 RVA: 0x0055CB5E File Offset: 0x0055AD5E
		private bool IMFBFOJAMBL()
		{
			return this.settings.downsampling;
		}

		// Token: 0x0600BD67 RID: 48487 RVA: 0x0055CEBA File Offset: 0x0055B0BA
		private RenderTextureFormat NFEOFMJDHJL()
		{
			if (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-23)))
			{
				return (RenderTextureFormat)(-16);
			}
			return RenderTextureFormat.ARGB2101010;
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x0600BD68 RID: 48488 RVA: 0x0055CEC9 File Offset: 0x0055B0C9
		public bool GLJKDPBAPKJ
		{
			get
			{
				return this.HGCKEPHODAA.actualRenderingPath == RenderingPath.DeferredShading;
			}
		}

		// Token: 0x0600BD6A RID: 48490 RVA: 0x0055CEEC File Offset: 0x0055B0EC
		private Shader PMOHGPLHHPO()
		{
			if (this._aoShader == null)
			{
				this._aoShader = Shader.Find("checkPet 2");
			}
			return this._aoShader;
		}

		// Token: 0x0600BD6B RID: 48491 RVA: 0x0055CF12 File Offset: 0x0055B112
		public bool KCHEGEGLEEK()
		{
			return this.HGCKEPHODAA.allowHDR && this.ICCBNGBCIKD() == (AmbientOcclusion.NHKEAOMBNOJ)7;
		}

		// Token: 0x0600BD6C RID: 48492 RVA: 0x0055C3CB File Offset: 0x0055A5CB
		private Material LJCECLIFKOI()
		{
			if (this.HHCJFDNFGLM == null)
			{
				this.HHCJFDNFGLM = OOFCHDPCJIJ.DJFOEIJIMJB(this.PMOHGPLHHPO());
			}
			return this.HHCJFDNFGLM;
		}

		// Token: 0x0600BD6D RID: 48493 RVA: 0x0055C645 File Offset: 0x0055A845
		private Camera BKLEOLNANAL()
		{
			return base.GetComponent<Camera>();
		}

		// Token: 0x0600BD6E RID: 48494 RVA: 0x0055C8B3 File Offset: 0x0055AAB3
		private void MHEPFELLOMN(AmbientOcclusion.GEKIFOCLJBL DCCPCBLODIG)
		{
			this.<FMLDEMDMDCC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BD6F RID: 48495 RVA: 0x0055CF2C File Offset: 0x0055B12C
		private void MCOOHLFKKPJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			int num = this.IMFBFOJAMBL() ? 4 : 0;
			RenderTextureFormat format = this.AIANHNLGEGC();
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			bool flag = this.settings.occlusionSource == AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture;
			Material material = this.GGDDEGIJFEL;
			RenderTexture temporary = RenderTexture.GetTemporary(width / num, height / num, 0, format, readWrite);
			Graphics.Blit(null, temporary, material, (int)this.BBICFENPINN());
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector("holesAll", Vector2.right * 395f);
			Graphics.Blit(temporary, temporary2, material, flag ? 5 : 3);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_FgOverlap", Vector2.up * 351f * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 4 : 7);
			RenderTexture.ReleaseTemporary(temporary2);
			temporary2 = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector(";", Vector2.right * (float)num);
			Graphics.Blit(temporary, temporary2, material, flag ? 3 : 5);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("inventoryOpen", Vector2.up * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 0 : 1);
			RenderTexture.ReleaseTemporary(temporary2);
			material.SetTexture("] ", temporary);
			if (!this.settings.debug)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 2);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, -95);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BD70 RID: 48496 RVA: 0x0055D0E8 File Offset: 0x0055B2E8
		private void OJJKNBMONMD()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.PALEEBLKOHC(), false, false, this))
			{
				base.enabled = false;
				return;
			}
			if (this.BMGMPFEMPEN)
			{
				this.HGCKEPHODAA.AddCommandBuffer((CameraEvent)31, this.HFEMLDPGDBK());
			}
			if (this.BBICFENPINN() == AmbientOcclusion.NHKEAOMBNOJ.DepthTexture)
			{
				this.IJGCNLLEODE().depthTextureMode |= DepthTextureMode.Depth;
			}
			if (this.ICCBNGBCIKD() != AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture)
			{
				this.CIFEFHAPLAG().depthTextureMode |= (DepthTextureMode)8;
			}
		}

		// Token: 0x0600BD71 RID: 48497 RVA: 0x0055D15F File Offset: 0x0055B35F
		private void GGIKBEHBAPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.BMGMPFEMPEN)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.AOIKIBGAJAI();
			this.PIFMHNJAHOJ(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x0600BD72 RID: 48498 RVA: 0x0055D17F File Offset: 0x0055B37F
		private CommandBuffer CHKGOBDMOKP
		{
			get
			{
				if (this.OLPFECBAMHD == null)
				{
					this.OLPFECBAMHD = new CommandBuffer();
					this.OLPFECBAMHD.name = "AmbientOcclusion";
				}
				return this.OLPFECBAMHD;
			}
		}

		// Token: 0x0600BD73 RID: 48499 RVA: 0x0055D1AA File Offset: 0x0055B3AA
		private void LOPLBCLLCID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.BMGMPFEMPEN)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.EOBJEKDOLOL();
			this.PIFMHNJAHOJ(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600BD74 RID: 48500 RVA: 0x0055D1CC File Offset: 0x0055B3CC
		private void Update()
		{
			if (this.ELNMAMCGIGM.CKPBDNFMDJL(this.settings, this.HGCKEPHODAA))
			{
				this.OnDisable();
				this.OnEnable();
				if (this.BMGMPFEMPEN)
				{
					this.CHKGOBDMOKP.Clear();
					this.CIIHDBPBICO();
				}
				this.ELNMAMCGIGM.FANPFKHEDPA(this.settings, this.HGCKEPHODAA);
			}
			if (this.BMGMPFEMPEN)
			{
				this.DGLHMGDJMMM();
			}
		}

		// Token: 0x0600BD75 RID: 48501 RVA: 0x0055C8B3 File Offset: 0x0055AAB3
		private void MCJLOHHAIAD(AmbientOcclusion.GEKIFOCLJBL DCCPCBLODIG)
		{
			this.<FMLDEMDMDCC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BD76 RID: 48502 RVA: 0x0055D244 File Offset: 0x0055B444
		private void GKIKPEPIJBL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			int num = this.OJIECMNALGE ? 3 : 1;
			RenderTextureFormat format = this.CCAFJMDEODM;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			bool flag = this.settings.occlusionSource == AmbientOcclusion.NHKEAOMBNOJ.DepthTexture;
			Material material = this.DOADNFJGKDJ();
			RenderTexture temporary = RenderTexture.GetTemporary(width / num, height / num, 1, format, readWrite);
			Graphics.Blit(null, temporary, material, (int)this.BBICFENPINN());
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector("sys", Vector2.right * 1377f);
			Graphics.Blit(temporary, temporary2, material, flag ? 8 : 5);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("id", Vector2.up * 1195f * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 3 : 7);
			RenderTexture.ReleaseTemporary(temporary2);
			temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("<[^>]+>", Vector2.right * (float)num);
			Graphics.Blit(temporary, temporary2, material, flag ? 7 : 1);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector("", Vector2.up * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 0 : 8);
			RenderTexture.ReleaseTemporary(temporary2);
			material.SetTexture("bone", temporary);
			if (!this.settings.debug)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 6);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 71);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BD77 RID: 48503 RVA: 0x0055D400 File Offset: 0x0055B600
		private void KEBDEJIAODF()
		{
			if (this.CJJAJHJEGOI().CLEPHJLLDPB(this.settings, this.BKLEOLNANAL()))
			{
				this.PEPOOEGHCMC();
				this.OnEnable();
				if (this.BMGMPFEMPEN)
				{
					this.HFEMLDPGDBK().Clear();
					this.LIOFHJMNHPH();
				}
				this.ELNMAMCGIGM.JBFJPNKLLKI(this.settings, this.HGCKEPHODAA);
			}
			if (this.BMGMPFEMPEN)
			{
				this.AOIKIBGAJAI();
			}
		}

		// Token: 0x0600BD78 RID: 48504 RVA: 0x0055D476 File Offset: 0x0055B676
		private float GKOKKJKIOGG()
		{
			return this.settings.intensity;
		}

		// Token: 0x0600BD79 RID: 48505 RVA: 0x0055D484 File Offset: 0x0055B684
		private void IJKMOJONNNH()
		{
			if (this.HHCJFDNFGLM != null)
			{
				UnityEngine.Object.DestroyImmediate(this.HHCJFDNFGLM);
			}
			this.HHCJFDNFGLM = null;
			if (this.OLPFECBAMHD != null)
			{
				this.BKLEOLNANAL().RemoveCommandBuffer((CameraEvent)(-127), this.OLPFECBAMHD);
			}
			this.OLPFECBAMHD = null;
		}

		// Token: 0x0600BD7A RID: 48506 RVA: 0x0055CB5E File Offset: 0x0055AD5E
		private bool BAGEFOGGJFP()
		{
			return this.settings.downsampling;
		}

		// Token: 0x0600BD7B RID: 48507 RVA: 0x0055D4D4 File Offset: 0x0055B6D4
		private void PIFMHNJAHOJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			int num = this.OJIECMNALGE ? 2 : 1;
			RenderTextureFormat format = this.CCAFJMDEODM;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			bool flag = this.settings.occlusionSource == AmbientOcclusion.NHKEAOMBNOJ.GBuffer;
			Material material = this.GGDDEGIJFEL;
			RenderTexture temporary = RenderTexture.GetTemporary(width / num, height / num, 0, format, readWrite);
			Graphics.Blit(null, temporary, material, (int)this.MDDBGPCKHPF);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.right * 2f);
			Graphics.Blit(temporary, temporary2, material, flag ? 4 : 3);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.up * 2f * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 4 : 3);
			RenderTexture.ReleaseTemporary(temporary2);
			temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.right * (float)num);
			Graphics.Blit(temporary, temporary2, material, flag ? 6 : 5);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.up * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 6 : 5);
			RenderTexture.ReleaseTemporary(temporary2);
			material.SetTexture("_OcclusionTexture", temporary);
			if (!this.settings.debug)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 7);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 9);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600BD7C RID: 48508 RVA: 0x0055D690 File Offset: 0x0055B890
		private void CDDIAIHBHJN()
		{
			CommandBuffer commandBuffer = this.CHKGOBDMOKP;
			int pixelWidth = this.CIFEFHAPLAG().pixelWidth;
			int pixelHeight = this.HGCKEPHODAA.pixelHeight;
			int num = this.OJIECMNALGE ? 4 : 1;
			RenderTextureFormat format = this.CCAFJMDEODM;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			FilterMode filter = FilterMode.Bilinear;
			Material material = this.CPIABIPGLGA();
			int nameID = Shader.PropertyToID("IdleDodgeRight");
			commandBuffer.GetTemporaryRT(nameID, pixelWidth / num, pixelHeight / num, 1, filter, format, readWrite);
			commandBuffer.Blit(null, nameID, material, 3);
			int nameID2 = Shader.PropertyToID("");
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector("firsStartInfoPanel", Vector2.right * 928f);
			commandBuffer.Blit(nameID, nameID2, material, 7);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("Hidden/Post FX/Ambient Occlusion", Vector2.up * 774f * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 6);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("{0:F2}, {1:F2}, {2:F2}, {3:F2}", Vector2.right * (float)num);
			commandBuffer.Blit(nameID, nameID2, material, 6);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("Loading ", Vector2.up * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 4);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			RenderTargetIdentifier[] array = new RenderTargetIdentifier[3];
			array[1] = (BuiltinRenderTextureType)(-18);
			array[0] = BuiltinRenderTextureType.Depth;
			RenderTargetIdentifier[] colors = array;
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.PrepassLight);
			commandBuffer.SetGlobalTexture("HA ", nameID);
			commandBuffer.DrawMesh(this.APMFFBMMIOC(), Matrix4x4.identity, material, 0, 7);
			commandBuffer.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x0600BD7D RID: 48509 RVA: 0x0055C8AB File Offset: 0x0055AAAB
		private Mesh JIJPKDDPEIB
		{
			get
			{
				return this._quadMesh;
			}
		}

		// Token: 0x0600BD7E RID: 48510 RVA: 0x0055CB5E File Offset: 0x0055AD5E
		private bool FHPJIKAJAGB()
		{
			return this.settings.downsampling;
		}

		// Token: 0x0600BD7F RID: 48511 RVA: 0x0055C3CB File Offset: 0x0055A5CB
		private Material DOADNFJGKDJ()
		{
			if (this.HHCJFDNFGLM == null)
			{
				this.HHCJFDNFGLM = OOFCHDPCJIJ.DJFOEIJIMJB(this.PMOHGPLHHPO());
			}
			return this.HHCJFDNFGLM;
		}

		// Token: 0x0600BD80 RID: 48512 RVA: 0x0055D8BA File Offset: 0x0055BABA
		private float BOHPEEMGNJH()
		{
			return Mathf.Max(this.settings.radius, 738f);
		}

		// Token: 0x0600BD81 RID: 48513 RVA: 0x0055D476 File Offset: 0x0055B676
		private float GHMBFJPBAMF()
		{
			return this.settings.intensity;
		}

		// Token: 0x0600BD82 RID: 48514 RVA: 0x0055D8D1 File Offset: 0x0055BAD1
		private AmbientOcclusion.NHKEAOMBNOJ ICCBNGBCIKD()
		{
			if (this.settings.occlusionSource == AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture && !this.JOJDIHKIFPL())
			{
				return AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture;
			}
			return this.settings.occlusionSource;
		}

		// Token: 0x0600BD83 RID: 48515 RVA: 0x0055D8F6 File Offset: 0x0055BAF6
		public bool MOGDIBDBAAH()
		{
			return this.CIFEFHAPLAG().actualRenderingPath == RenderingPath.DeferredShading;
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x0600BD84 RID: 48516 RVA: 0x0055D906 File Offset: 0x0055BB06
		private AmbientOcclusion.MBHOOLCHOGB EDADEJBEFNH
		{
			get
			{
				return this.settings.sampleCount;
			}
		}

		// Token: 0x0600BD85 RID: 48517 RVA: 0x0055C8AB File Offset: 0x0055AAAB
		private Mesh IBMILNMCBGG()
		{
			return this._quadMesh;
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x0600BD86 RID: 48518 RVA: 0x0055D913 File Offset: 0x0055BB13
		private RenderTextureFormat CCAFJMDEODM
		{
			get
			{
				if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.R8))
				{
					return RenderTextureFormat.R8;
				}
				return RenderTextureFormat.Default;
			}
		}

		// Token: 0x0600BD87 RID: 48519 RVA: 0x0055CE79 File Offset: 0x0055B079
		private Material IAEHKNMIEMD()
		{
			if (this.HHCJFDNFGLM == null)
			{
				this.HHCJFDNFGLM = OOFCHDPCJIJ.DJFOEIJIMJB(this.DCMAJFJALMB);
			}
			return this.HHCJFDNFGLM;
		}

		// Token: 0x0600BD88 RID: 48520 RVA: 0x0055CE79 File Offset: 0x0055B079
		private Material HDFJEIKCBAC()
		{
			if (this.HHCJFDNFGLM == null)
			{
				this.HHCJFDNFGLM = OOFCHDPCJIJ.DJFOEIJIMJB(this.DCMAJFJALMB);
			}
			return this.HHCJFDNFGLM;
		}

		// Token: 0x0600BD89 RID: 48521 RVA: 0x0055D922 File Offset: 0x0055BB22
		public bool FNLKNDGGDEB()
		{
			return this.CIFEFHAPLAG().allowHDR && this.MDDBGPCKHPF == AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture;
		}

		// Token: 0x0600BD8A RID: 48522 RVA: 0x0055D93C File Offset: 0x0055BB3C
		private void DGLHMGDJMMM()
		{
			Material material = this.GGDDEGIJFEL;
			material.SetFloat("_Intensity", this.INAEHEBPLNN);
			material.SetFloat("_Radius", this.AEIAFIIMHEL);
			material.SetFloat("_TargetScale", this.OJIECMNALGE ? 0.5f : 1f);
			material.SetInt("_SampleCount", this.GIOODHPPIIK);
		}

		// Token: 0x0600BD8B RID: 48523 RVA: 0x0055D9A0 File Offset: 0x0055BBA0
		private CommandBuffer OMCJJHCNFEF()
		{
			if (this.OLPFECBAMHD == null)
			{
				this.OLPFECBAMHD = new CommandBuffer();
				this.OLPFECBAMHD.name = "BowInstant";
			}
			return this.OLPFECBAMHD;
		}

		// Token: 0x0600BD8C RID: 48524 RVA: 0x0055CB5E File Offset: 0x0055AD5E
		private bool NOFIEAIJDMF()
		{
			return this.settings.downsampling;
		}

		// Token: 0x0600BD8D RID: 48525 RVA: 0x0055D9CB File Offset: 0x0055BBCB
		private AmbientOcclusion.GEKIFOCLJBL CJJAJHJEGOI()
		{
			return this.<FMLDEMDMDCC>k__BackingField;
		}

		// Token: 0x0600BD8E RID: 48526 RVA: 0x0055D15F File Offset: 0x0055B35F
		private void MIJCMMIJPEE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.BMGMPFEMPEN)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.AOIKIBGAJAI();
			this.PIFMHNJAHOJ(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600BD8F RID: 48527 RVA: 0x0055D9D3 File Offset: 0x0055BBD3
		private AmbientOcclusion.NHKEAOMBNOJ BBICFENPINN()
		{
			if (this.settings.occlusionSource == (AmbientOcclusion.NHKEAOMBNOJ)4 && !this.JOJDIHKIFPL())
			{
				return AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture;
			}
			return this.settings.occlusionSource;
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x0600BD90 RID: 48528 RVA: 0x0055D9F8 File Offset: 0x0055BBF8
		private AmbientOcclusion.NHKEAOMBNOJ MDDBGPCKHPF
		{
			get
			{
				if (this.settings.occlusionSource == AmbientOcclusion.NHKEAOMBNOJ.GBuffer && !this.GLJKDPBAPKJ)
				{
					return AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture;
				}
				return this.settings.occlusionSource;
			}
		}

		// Token: 0x0600BD91 RID: 48529 RVA: 0x0055C8AB File Offset: 0x0055AAAB
		private Mesh MJEJKFFIFAG()
		{
			return this._quadMesh;
		}

		// Token: 0x0600BD92 RID: 48530 RVA: 0x0055DA20 File Offset: 0x0055BC20
		private void EOBJEKDOLOL()
		{
			Material material = this.MLCOEEDDBMC();
			material.SetFloat("Images/MouseCursor/Link", this.INAEHEBPLNN);
			material.SetFloat("IK.Disable() is deprecated. Use enabled = false instead", this.KDFFEFGBDAL());
			material.SetFloat("inv_pcs1", this.FHPJIKAJAGB() ? 1546f : 91f);
			material.SetInt("Weapon Strafe Run Left", this.GIOODHPPIIK);
		}

		// Token: 0x0600BD93 RID: 48531 RVA: 0x0055DA84 File Offset: 0x0055BC84
		private void CIIHDBPBICO()
		{
			CommandBuffer commandBuffer = this.CHKGOBDMOKP;
			int pixelWidth = this.HGCKEPHODAA.pixelWidth;
			int pixelHeight = this.HGCKEPHODAA.pixelHeight;
			int num = this.OJIECMNALGE ? 2 : 1;
			RenderTextureFormat format = this.CCAFJMDEODM;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			FilterMode filter = FilterMode.Bilinear;
			Material material = this.GGDDEGIJFEL;
			int nameID = Shader.PropertyToID("_OcclusionTexture");
			commandBuffer.GetTemporaryRT(nameID, pixelWidth / num, pixelHeight / num, 0, filter, format, readWrite);
			commandBuffer.Blit(null, nameID, material, 2);
			int nameID2 = Shader.PropertyToID("_OcclusionBlurTexture");
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.right * 2f);
			commandBuffer.Blit(nameID, nameID2, material, 4);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.up * 2f * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 4);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.right * (float)num);
			commandBuffer.Blit(nameID, nameID2, material, 6);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.up * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 6);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			RenderTargetIdentifier[] colors = new RenderTargetIdentifier[]
			{
				BuiltinRenderTextureType.GBuffer0,
				BuiltinRenderTextureType.CameraTarget
			};
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.CameraTarget);
			commandBuffer.SetGlobalTexture("_OcclusionTexture", nameID);
			commandBuffer.DrawMesh(this.JIJPKDDPEIB, Matrix4x4.identity, material, 0, 8);
			commandBuffer.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x0600BD94 RID: 48532 RVA: 0x0055DCAE File Offset: 0x0055BEAE
		private RenderTextureFormat KEJMDELCPBB()
		{
			if (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-70)))
			{
				return (RenderTextureFormat)(-70);
			}
			return RenderTextureFormat.RGB565;
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x0600BD95 RID: 48533 RVA: 0x0055D9CB File Offset: 0x0055BBCB
		// (set) Token: 0x0600BDB8 RID: 48568 RVA: 0x0055C8B3 File Offset: 0x0055AAB3
		private AmbientOcclusion.GEKIFOCLJBL ELNMAMCGIGM { get; set; }

		// Token: 0x0600BD96 RID: 48534 RVA: 0x0055C645 File Offset: 0x0055A845
		private Camera IJGCNLLEODE()
		{
			return base.GetComponent<Camera>();
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x0600BD97 RID: 48535 RVA: 0x0055CB5E File Offset: 0x0055AD5E
		private bool OJIECMNALGE
		{
			get
			{
				return this.settings.downsampling;
			}
		}

		// Token: 0x0600BD98 RID: 48536 RVA: 0x0055DCBD File Offset: 0x0055BEBD
		private CommandBuffer NBHOAHMNFCO()
		{
			if (this.OLPFECBAMHD == null)
			{
				this.OLPFECBAMHD = new CommandBuffer();
				this.OLPFECBAMHD.name = "Water";
			}
			return this.OLPFECBAMHD;
		}

		// Token: 0x0600BD99 RID: 48537 RVA: 0x0055DCE8 File Offset: 0x0055BEE8
		private void ECHEFJNILJO()
		{
			CommandBuffer commandBuffer = this.OMCJJHCNFEF();
			int pixelWidth = this.HGCKEPHODAA.pixelWidth;
			int pixelHeight = this.CIFEFHAPLAG().pixelHeight;
			int num = this.BHKHOGHEFPO() ? 3 : 0;
			RenderTextureFormat format = this.NFEOFMJDHJL();
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			FilterMode filter = FilterMode.Point;
			Material material = this.CPIABIPGLGA();
			int nameID = Shader.PropertyToID("ENABLE_USER_LUT");
			commandBuffer.GetTemporaryRT(nameID, pixelWidth / num, pixelHeight / num, 1, filter, format, readWrite);
			commandBuffer.Blit(null, nameID, material, 3);
			int nameID2 = Shader.PropertyToID("Horizontal");
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector("MotorbikeHeadstand", Vector2.right * 1800f);
			commandBuffer.Blit(nameID, nameID2, material, 2);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_UnderwaterMode", Vector2.up * 1882f * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 1);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector("", Vector2.right * (float)num);
			commandBuffer.Blit(nameID, nameID2, material, 3);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("auk_whead", Vector2.up * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 3);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			RenderTargetIdentifier[] array = new RenderTargetIdentifier[6];
			array[1] = (BuiltinRenderTextureType)(-112);
			array[1] = BuiltinRenderTextureType.Depth;
			RenderTargetIdentifier[] colors = array;
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.PrepassLight);
			commandBuffer.SetGlobalTexture("", nameID);
			commandBuffer.DrawMesh(this.JIJPKDDPEIB, Matrix4x4.identity, material, 1, 1);
			commandBuffer.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x0600BD9A RID: 48538 RVA: 0x0055DF14 File Offset: 0x0055C114
		private void DPGECEOMHNM()
		{
			if (this.CJJAJHJEGOI().KPCGMDNGIGP(this.settings, this.BKLEOLNANAL()))
			{
				this.PEPOOEGHCMC();
				this.OnEnable();
				if (this.BMGMPFEMPEN)
				{
					this.CHKGOBDMOKP.Clear();
					this.BAOHJPJCNFP();
				}
				this.ELNMAMCGIGM.JFGGBEGNAFP(this.settings, this.BKLEOLNANAL());
			}
			if (this.BMGMPFEMPEN)
			{
				this.EOBJEKDOLOL();
			}
		}

		// Token: 0x0600BD9B RID: 48539 RVA: 0x0055DF8A File Offset: 0x0055C18A
		private float KDFFEFGBDAL()
		{
			return Mathf.Max(this.settings.radius, 742f);
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x0600BD9C RID: 48540 RVA: 0x0055DFA1 File Offset: 0x0055C1A1
		private float AEIAFIIMHEL
		{
			get
			{
				return Mathf.Max(this.settings.radius, 0.0001f);
			}
		}

		// Token: 0x0600BD9D RID: 48541 RVA: 0x0055DFB8 File Offset: 0x0055C1B8
		private void GCNGEFBKMNC()
		{
			if (this.ELNMAMCGIGM.GOOGEHFKKJH(this.settings, this.HGCKEPHODAA))
			{
				this.IICFAPMJLCN();
				this.OJJKNBMONMD();
				if (this.BMGMPFEMPEN)
				{
					this.HFEMLDPGDBK().Clear();
					this.BAOHJPJCNFP();
				}
				this.ELNMAMCGIGM.OFPGMNGFLNH(this.settings, this.CIFEFHAPLAG());
			}
			if (this.BMGMPFEMPEN)
			{
				this.AOIKIBGAJAI();
			}
		}

		// Token: 0x0600BD9E RID: 48542 RVA: 0x0055E030 File Offset: 0x0055C230
		private void PEPOOEGHCMC()
		{
			if (this.HHCJFDNFGLM != null)
			{
				UnityEngine.Object.DestroyImmediate(this.HHCJFDNFGLM);
			}
			this.HHCJFDNFGLM = null;
			if (this.OLPFECBAMHD != null)
			{
				this.HGCKEPHODAA.RemoveCommandBuffer((CameraEvent)58, this.OLPFECBAMHD);
			}
			this.OLPFECBAMHD = null;
		}

		// Token: 0x0600BD9F RID: 48543 RVA: 0x0055E07F File Offset: 0x0055C27F
		private Shader PALEEBLKOHC()
		{
			if (this._aoShader == null)
			{
				this._aoShader = Shader.Find("---");
			}
			return this._aoShader;
		}

		// Token: 0x0600BDA0 RID: 48544 RVA: 0x0055E0A5 File Offset: 0x0055C2A5
		private void MCCMFFLILNN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.BMGMPFEMPEN)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.EOBJEKDOLOL();
			this.MCOOHLFKKPJ(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600BDA1 RID: 48545 RVA: 0x0055E0C5 File Offset: 0x0055C2C5
		private RenderTextureFormat NLCOLDAFJGL()
		{
			if (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-128)))
			{
				return (RenderTextureFormat)(-112);
			}
			return RenderTextureFormat.ARGB32;
		}

		// Token: 0x0600BDA2 RID: 48546 RVA: 0x0055E0D4 File Offset: 0x0055C2D4
		private void GNFGGOGEHII(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			int width = JONJODLFAEN.width;
			int height = JONJODLFAEN.height;
			int num = this.BHKHOGHEFPO() ? 5 : 0;
			RenderTextureFormat format = this.KEJMDELCPBB();
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			bool flag = this.settings.occlusionSource == (AmbientOcclusion.NHKEAOMBNOJ)8;
			Material material = this.GGDDEGIJFEL;
			RenderTexture temporary = RenderTexture.GetTemporary(width / num, height / num, 0, format, readWrite);
			Graphics.Blit(null, temporary, material, (int)this.BBICFENPINN());
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector(" x", Vector2.right * 649f);
			Graphics.Blit(temporary, temporary2, material, flag ? 8 : 7);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("18", Vector2.up * 546f * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 3 : 6);
			RenderTexture.ReleaseTemporary(temporary2);
			temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("", Vector2.right * (float)num);
			Graphics.Blit(temporary, temporary2, material, flag ? 0 : 0);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("Windmill", Vector2.up * (float)num);
			Graphics.Blit(temporary2, temporary, material, flag ? 2 : 3);
			RenderTexture.ReleaseTemporary(temporary2);
			material.SetTexture("Keeper Strafe Dive Close Left", temporary);
			if (!this.settings.debug)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, 3);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, material, -79);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x0600BDA3 RID: 48547 RVA: 0x0055D476 File Offset: 0x0055B676
		private float INAEHEBPLNN
		{
			get
			{
				return this.settings.intensity;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x0600BDA4 RID: 48548 RVA: 0x0055E28D File Offset: 0x0055C48D
		private bool BMGMPFEMPEN
		{
			get
			{
				return this.settings.ambientOnly && !this.settings.debug && this.GOOEGMCIHDP;
			}
		}

		// Token: 0x0600BDA5 RID: 48549 RVA: 0x0055E2B1 File Offset: 0x0055C4B1
		private RenderTextureFormat AIANHNLGEGC()
		{
			if (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)68))
			{
				return (RenderTextureFormat)(-36);
			}
			return RenderTextureFormat.Default;
		}

		// Token: 0x0600BDA6 RID: 48550 RVA: 0x0055D476 File Offset: 0x0055B676
		private float PPEAHLKKNNC()
		{
			return this.settings.intensity;
		}

		// Token: 0x0600BDA7 RID: 48551 RVA: 0x0055C3CB File Offset: 0x0055A5CB
		private Material MLCOEEDDBMC()
		{
			if (this.HHCJFDNFGLM == null)
			{
				this.HHCJFDNFGLM = OOFCHDPCJIJ.DJFOEIJIMJB(this.PMOHGPLHHPO());
			}
			return this.HHCJFDNFGLM;
		}

		// Token: 0x0600BDA8 RID: 48552 RVA: 0x0055C3F2 File Offset: 0x0055A5F2
		private void EIMKKKCGJLO(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.BMGMPFEMPEN)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.DGLHMGDJMMM();
			this.PIFMHNJAHOJ(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600BDA9 RID: 48553 RVA: 0x0055E2C0 File Offset: 0x0055C4C0
		private int AKEGHNEAGAD()
		{
			switch (this.settings.sampleCount)
			{
			case AmbientOcclusion.MBHOOLCHOGB.Lowest:
				return 1;
			case AmbientOcclusion.MBHOOLCHOGB.Low:
				return 4;
			case AmbientOcclusion.MBHOOLCHOGB.Medium:
				return 18;
			case AmbientOcclusion.MBHOOLCHOGB.High:
				return 63;
			default:
				return Mathf.Clamp(this.settings.sampleCountValue, 1, -82);
			}
		}

		// Token: 0x0600BDAA RID: 48554 RVA: 0x0055D906 File Offset: 0x0055BB06
		private AmbientOcclusion.MBHOOLCHOGB IMJLOPICMGN()
		{
			return this.settings.sampleCount;
		}

		// Token: 0x0600BDAB RID: 48555 RVA: 0x0055E314 File Offset: 0x0055C514
		private void GPCKACGEILI()
		{
			if (this.ELNMAMCGIGM.OOINCOKIDCP(this.settings, this.HGCKEPHODAA))
			{
				this.ACJNCDAHJDE();
				this.OnEnable();
				if (this.BMGMPFEMPEN)
				{
					this.NBHOAHMNFCO().Clear();
					this.CIIHDBPBICO();
				}
				this.CJJAJHJEGOI().KMPEBHIPKJH(this.settings, this.BKLEOLNANAL());
			}
			if (this.BMGMPFEMPEN)
			{
				this.DGLHMGDJMMM();
			}
		}

		// Token: 0x0600BDAC RID: 48556 RVA: 0x0055E38C File Offset: 0x0055C58C
		private void OnEnable()
		{
			if (!OOFCHDPCJIJ.MLBELGPBEFK(this.DCMAJFJALMB, true, false, this))
			{
				base.enabled = false;
				return;
			}
			if (this.BMGMPFEMPEN)
			{
				this.HGCKEPHODAA.AddCommandBuffer(CameraEvent.BeforeReflections, this.CHKGOBDMOKP);
			}
			if (this.MDDBGPCKHPF == AmbientOcclusion.NHKEAOMBNOJ.DepthTexture)
			{
				this.HGCKEPHODAA.depthTextureMode |= DepthTextureMode.Depth;
			}
			if (this.MDDBGPCKHPF != AmbientOcclusion.NHKEAOMBNOJ.GBuffer)
			{
				this.HGCKEPHODAA.depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		// Token: 0x0600BDAD RID: 48557 RVA: 0x0055E404 File Offset: 0x0055C604
		private void BAOHJPJCNFP()
		{
			CommandBuffer commandBuffer = this.OMCJJHCNFEF();
			int pixelWidth = this.BKLEOLNANAL().pixelWidth;
			int pixelHeight = this.IJGCNLLEODE().pixelHeight;
			int num = this.IMFBFOJAMBL() ? 3 : 1;
			RenderTextureFormat format = this.AIANHNLGEGC();
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			FilterMode filter = FilterMode.Bilinear;
			Material material = this.DOADNFJGKDJ();
			int nameID = Shader.PropertyToID("base_{0}");
			commandBuffer.GetTemporaryRT(nameID, pixelWidth / num, pixelHeight / num, 0, filter, format, readWrite);
			commandBuffer.Blit(null, nameID, material, 4);
			int nameID2 = Shader.PropertyToID("\n");
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("<color='#000000'>", Vector2.right * 300f);
			commandBuffer.Blit(nameID, nameID2, material, 2);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("Third bone's position equals second bone's position in the biped's limb.", Vector2.up * 856f * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 3);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_OcclusionTexture", Vector2.right * (float)num);
			commandBuffer.Blit(nameID, nameID2, material, 4);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector("IceHockeyIdle", Vector2.up * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 4);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			RenderTargetIdentifier[] array = new RenderTargetIdentifier[3];
			array[0] = BuiltinRenderTextureType.BindableTexture;
			array[0] = BuiltinRenderTextureType.CurrentActive;
			RenderTargetIdentifier[] colors = array;
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.PrepassLight);
			commandBuffer.SetGlobalTexture("I'm obscured string", nameID);
			commandBuffer.DrawMesh(this.MJEJKFFIFAG(), Matrix4x4.identity, material, 0, 1);
			commandBuffer.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x0600BDAE RID: 48558 RVA: 0x0055E62E File Offset: 0x0055C82E
		private CommandBuffer HFEMLDPGDBK()
		{
			if (this.OLPFECBAMHD == null)
			{
				this.OLPFECBAMHD = new CommandBuffer();
				this.OLPFECBAMHD.name = "HDR";
			}
			return this.OLPFECBAMHD;
		}

		// Token: 0x0600BDAF RID: 48559 RVA: 0x0055C8B3 File Offset: 0x0055AAB3
		private void GEFMDFKNJAJ(AmbientOcclusion.GEKIFOCLJBL DCCPCBLODIG)
		{
			this.<FMLDEMDMDCC>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600BDB0 RID: 48560 RVA: 0x0055E659 File Offset: 0x0055C859
		public bool MKMPHMMLLDJ()
		{
			return this.BKLEOLNANAL().allowHDR && this.MDDBGPCKHPF == (AmbientOcclusion.NHKEAOMBNOJ)3;
		}

		// Token: 0x0600BDB1 RID: 48561 RVA: 0x0055E674 File Offset: 0x0055C874
		private void AOIKIBGAJAI()
		{
			Material material = this.IAEHKNMIEMD();
			material.SetFloat("_Parameter", this.GHMBFJPBAMF());
			material.SetFloat("titul_data/tituls/titul", this.AEIAFIIMHEL);
			material.SetFloat("OfficeSittingHandRestFingerTap", this.IMFBFOJAMBL() ? 1264f : 774f);
			material.SetInt("pb_Object: ", this.AKEGHNEAGAD());
		}

		// Token: 0x0600BDB2 RID: 48562 RVA: 0x0055E6D8 File Offset: 0x0055C8D8
		private void GCBBLJNJAHM(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (this.BMGMPFEMPEN)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			this.AOIKIBGAJAI();
			this.NFAKDGHMHPO(JONJODLFAEN, OKIIDHIJBEA);
		}

		// Token: 0x0600BDB3 RID: 48563 RVA: 0x0055E6F8 File Offset: 0x0055C8F8
		public bool JOJDIHKIFPL()
		{
			return this.CIFEFHAPLAG().actualRenderingPath == (RenderingPath)7;
		}

		// Token: 0x0600BDB4 RID: 48564 RVA: 0x0055E708 File Offset: 0x0055C908
		private float FCNLHKAAOEN()
		{
			return Mathf.Max(this.settings.radius, 1778f);
		}

		// Token: 0x0600BDB5 RID: 48565 RVA: 0x0055E720 File Offset: 0x0055C920
		private int FOGLKJOANFC()
		{
			switch (this.settings.sampleCount)
			{
			case AmbientOcclusion.MBHOOLCHOGB.Lowest:
				return 1;
			case AmbientOcclusion.MBHOOLCHOGB.Low:
				return 4;
			case AmbientOcclusion.MBHOOLCHOGB.Medium:
				return -84;
			case AmbientOcclusion.MBHOOLCHOGB.High:
				return -6;
			default:
				return Mathf.Clamp(this.settings.sampleCountValue, 1, -122);
			}
		}

		// Token: 0x0600BDB6 RID: 48566 RVA: 0x0055D906 File Offset: 0x0055BB06
		private AmbientOcclusion.MBHOOLCHOGB OLJCBEIALFD()
		{
			return this.settings.sampleCount;
		}

		// Token: 0x0600BDB7 RID: 48567 RVA: 0x0055E774 File Offset: 0x0055C974
		private void OIBIGDFPHGO()
		{
			if (this.CJJAJHJEGOI().NMMKJMNEPMH(this.settings, this.HGCKEPHODAA))
			{
				this.ACJNCDAHJDE();
				this.OnEnable();
				if (this.BMGMPFEMPEN)
				{
					this.HFEMLDPGDBK().Clear();
					this.JONKDACFAGL();
				}
				this.ELNMAMCGIGM.KOLCEBEIHKP(this.settings, this.CIFEFHAPLAG());
			}
			if (this.BMGMPFEMPEN)
			{
				this.EOBJEKDOLOL();
			}
		}

		// Token: 0x0600BDB9 RID: 48569 RVA: 0x0055E7EC File Offset: 0x0055C9EC
		private void JONKDACFAGL()
		{
			CommandBuffer commandBuffer = this.HFEMLDPGDBK();
			int pixelWidth = this.BKLEOLNANAL().pixelWidth;
			int pixelHeight = this.IJGCNLLEODE().pixelHeight;
			int num = this.OJIECMNALGE ? 7 : 0;
			RenderTextureFormat format = this.NLCOLDAFJGL();
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			FilterMode filter = FilterMode.Point;
			Material material = this.LJCECLIFKOI();
			int nameID = Shader.PropertyToID("RussianDance");
			commandBuffer.GetTemporaryRT(nameID, pixelWidth / num, pixelHeight / num, 0, filter, format, readWrite);
			commandBuffer.Blit(null, nameID, material, 0);
			int nameID2 = Shader.PropertyToID("_Cutoff");
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("BowInstant2", Vector2.right * 159f);
			commandBuffer.Blit(nameID, nameID2, material, 1);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("Head", Vector2.up * 493f * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 8);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("Unarmed", Vector2.right * (float)num);
			commandBuffer.Blit(nameID, nameID2, material, 4);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("__a", Vector2.up * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 6);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			RenderTargetIdentifier[] array = new RenderTargetIdentifier[3];
			array[1] = (BuiltinRenderTextureType)(-16);
			array[0] = BuiltinRenderTextureType.PrepassLight;
			RenderTargetIdentifier[] colors = array;
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.PrepassLight);
			commandBuffer.SetGlobalTexture("MENU.WAV", nameID);
			commandBuffer.DrawMesh(this.APMFFBMMIOC(), Matrix4x4.identity, material, 0, 1);
			commandBuffer.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x040018B2 RID: 6322
		[SerializeField]
		public AmbientOcclusion.Settings settings = AmbientOcclusion.Settings.defaultSettings;

		// Token: 0x040018B3 RID: 6323
		[SerializeField]
		private Shader _aoShader;

		// Token: 0x040018B4 RID: 6324
		private Material HHCJFDNFGLM;

		// Token: 0x040018B5 RID: 6325
		private CommandBuffer OLPFECBAMHD;

		// Token: 0x040018B7 RID: 6327
		[SerializeField]
		private Mesh _quadMesh;

		// Token: 0x02000341 RID: 833
		private struct GEKIFOCLJBL
		{
			// Token: 0x0600BDBA RID: 48570 RVA: 0x0055EA18 File Offset: 0x0055CC18
			public bool EBFMPOIDHNI(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDBB RID: 48571 RVA: 0x0055EA80 File Offset: 0x0055CC80
			public bool EJFEEIOIJGB(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDBC RID: 48572 RVA: 0x0055EAE8 File Offset: 0x0055CCE8
			public bool PCEGNACDIGO(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDBD RID: 48573 RVA: 0x0055EB50 File Offset: 0x0055CD50
			public void HMEAENGBFKC(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDBE RID: 48574 RVA: 0x0055EBA8 File Offset: 0x0055CDA8
			public void LMGBKHCHPHO(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDBF RID: 48575 RVA: 0x0055EC00 File Offset: 0x0055CE00
			public bool AJGIONPGOGI(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDC0 RID: 48576 RVA: 0x0055EC68 File Offset: 0x0055CE68
			public void PFPPDNHLCCA(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDC1 RID: 48577 RVA: 0x0055ECC0 File Offset: 0x0055CEC0
			public bool HEOPKPGCHBC(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDC2 RID: 48578 RVA: 0x0055ED28 File Offset: 0x0055CF28
			public void AKLFCMNCPKL(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDC3 RID: 48579 RVA: 0x0055ED80 File Offset: 0x0055CF80
			public void OHKHOAKCENL(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDC4 RID: 48580 RVA: 0x0055EDD8 File Offset: 0x0055CFD8
			public void BOAJJAKEMLH(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDC5 RID: 48581 RVA: 0x0055EE30 File Offset: 0x0055D030
			public void JIKGIJEHGAP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDC6 RID: 48582 RVA: 0x0055EE88 File Offset: 0x0055D088
			public void HONIFOPBBKC(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDC7 RID: 48583 RVA: 0x0055EEE0 File Offset: 0x0055D0E0
			public bool EIOLPHAGLNL(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDC8 RID: 48584 RVA: 0x0055EF48 File Offset: 0x0055D148
			public void IKHCCAANGOP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDC9 RID: 48585 RVA: 0x0055EFA0 File Offset: 0x0055D1A0
			public void MPLCAGFGEBO(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDCA RID: 48586 RVA: 0x0055EFF8 File Offset: 0x0055D1F8
			public bool APCHLNCJFIB(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDCB RID: 48587 RVA: 0x0055F060 File Offset: 0x0055D260
			public void AAEFACEGJMB(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDCC RID: 48588 RVA: 0x0055F0B8 File Offset: 0x0055D2B8
			public void HMGBHPPNEMP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDCD RID: 48589 RVA: 0x0055F110 File Offset: 0x0055D310
			public void FANPFKHEDPA(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDCE RID: 48590 RVA: 0x0055F168 File Offset: 0x0055D368
			public bool AOOCFPOHFMN(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDCF RID: 48591 RVA: 0x0055F1D0 File Offset: 0x0055D3D0
			public bool CKPBDNFMDJL(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDD0 RID: 48592 RVA: 0x0055F238 File Offset: 0x0055D438
			public void AIAMIFEPALP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDD1 RID: 48593 RVA: 0x0055F290 File Offset: 0x0055D490
			public void GCCAPOHGAHA(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDD2 RID: 48594 RVA: 0x0055F2E8 File Offset: 0x0055D4E8
			public bool IGKICKKFMPM(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDD3 RID: 48595 RVA: 0x0055F350 File Offset: 0x0055D550
			public void HAIMGCDKPDC(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDD4 RID: 48596 RVA: 0x0055F3A8 File Offset: 0x0055D5A8
			public void DEGCCLNOEKJ(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDD5 RID: 48597 RVA: 0x0055F400 File Offset: 0x0055D600
			public bool FBKMEINBBCE(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDD6 RID: 48598 RVA: 0x0055F468 File Offset: 0x0055D668
			public bool JHDDGGKNEJB(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDD7 RID: 48599 RVA: 0x0055F4D0 File Offset: 0x0055D6D0
			public void PGIHAIPCJLL(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDD8 RID: 48600 RVA: 0x0055F528 File Offset: 0x0055D728
			public bool IOIMAKLPBDC(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDD9 RID: 48601 RVA: 0x0055F590 File Offset: 0x0055D790
			public bool DOJMJLJGCGF(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDDA RID: 48602 RVA: 0x0055F5F8 File Offset: 0x0055D7F8
			public void MIFLHGMPLJD(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDDB RID: 48603 RVA: 0x0055F650 File Offset: 0x0055D850
			public bool OOINCOKIDCP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDDC RID: 48604 RVA: 0x0055F6B8 File Offset: 0x0055D8B8
			public bool IEJBOFPDHLM(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDDD RID: 48605 RVA: 0x0055F720 File Offset: 0x0055D920
			public void FPLNDDMFFKG(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDDE RID: 48606 RVA: 0x0055F778 File Offset: 0x0055D978
			public void KMPEBHIPKJH(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDDF RID: 48607 RVA: 0x0055F7D0 File Offset: 0x0055D9D0
			public void MEIOHFKFEME(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDE0 RID: 48608 RVA: 0x0055F828 File Offset: 0x0055DA28
			public bool JMCLBHMLGDF(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDE1 RID: 48609 RVA: 0x0055F890 File Offset: 0x0055DA90
			public void KBMKHLDOIKP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDE2 RID: 48610 RVA: 0x0055F8E8 File Offset: 0x0055DAE8
			public bool CLEPHJLLDPB(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDE3 RID: 48611 RVA: 0x0055F950 File Offset: 0x0055DB50
			public void IOGAKGCADBL(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDE4 RID: 48612 RVA: 0x0055F9A8 File Offset: 0x0055DBA8
			public bool KMCDNOMILFL(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDE5 RID: 48613 RVA: 0x0055FA10 File Offset: 0x0055DC10
			public void KLFPOILLKDF(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDE6 RID: 48614 RVA: 0x0055FA68 File Offset: 0x0055DC68
			public void IDMCOLDDNCF(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDE7 RID: 48615 RVA: 0x0055FAC0 File Offset: 0x0055DCC0
			public bool ONHCKLDNMCO(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDE8 RID: 48616 RVA: 0x0055FB28 File Offset: 0x0055DD28
			public bool GOOGEHFKKJH(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDE9 RID: 48617 RVA: 0x0055FB90 File Offset: 0x0055DD90
			public bool DFHMFPCIOBE(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDEA RID: 48618 RVA: 0x0055FBF8 File Offset: 0x0055DDF8
			public void OIBIGDFPHGO(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDEB RID: 48619 RVA: 0x0055FC50 File Offset: 0x0055DE50
			public void LBGKAMLLACN(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDEC RID: 48620 RVA: 0x0055FCA8 File Offset: 0x0055DEA8
			public bool EDMIMAJIGOC(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDED RID: 48621 RVA: 0x0055FD10 File Offset: 0x0055DF10
			public bool JKBIFNJNCNK(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDEE RID: 48622 RVA: 0x0055FD78 File Offset: 0x0055DF78
			public bool EDOGJAJHKPO(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDEF RID: 48623 RVA: 0x0055FDE0 File Offset: 0x0055DFE0
			public bool OANPBHDFIKP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDF0 RID: 48624 RVA: 0x0055FE48 File Offset: 0x0055E048
			public bool HKPNHGLAMGM(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDF1 RID: 48625 RVA: 0x0055FEB0 File Offset: 0x0055E0B0
			public bool HANAFBIMLFH(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDF2 RID: 48626 RVA: 0x0055FF18 File Offset: 0x0055E118
			public void PFNOEACNHON(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDF3 RID: 48627 RVA: 0x0055FF70 File Offset: 0x0055E170
			public void GPCKACGEILI(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDF4 RID: 48628 RVA: 0x0055FFC8 File Offset: 0x0055E1C8
			public void JBFJPNKLLKI(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDF5 RID: 48629 RVA: 0x00560020 File Offset: 0x0055E220
			public bool DJFCEEGANEN(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDF6 RID: 48630 RVA: 0x00560088 File Offset: 0x0055E288
			public bool NMMKJMNEPMH(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDF7 RID: 48631 RVA: 0x005600F0 File Offset: 0x0055E2F0
			public void JPHLMNIMDHH(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDF8 RID: 48632 RVA: 0x00560148 File Offset: 0x0055E348
			public void KOLCEBEIHKP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDF9 RID: 48633 RVA: 0x005601A0 File Offset: 0x0055E3A0
			public bool MPDNPIBHDIG(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDFA RID: 48634 RVA: 0x00560208 File Offset: 0x0055E408
			public bool HAPDACHOOBP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDFB RID: 48635 RVA: 0x00560270 File Offset: 0x0055E470
			public void BEDAJLJFAFO(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDFC RID: 48636 RVA: 0x005602C8 File Offset: 0x0055E4C8
			public void DKOIOBMMAGN(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDFD RID: 48637 RVA: 0x00560320 File Offset: 0x0055E520
			public void OFPGMNGFLNH(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDFE RID: 48638 RVA: 0x00560378 File Offset: 0x0055E578
			public bool BDJFKBAPCKB(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BDFF RID: 48639 RVA: 0x005603E0 File Offset: 0x0055E5E0
			public void CJHBCHBOLBI(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE00 RID: 48640 RVA: 0x00560438 File Offset: 0x0055E638
			public void JFGGBEGNAFP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE01 RID: 48641 RVA: 0x00560490 File Offset: 0x0055E690
			public void MEFOGCFJBNE(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE02 RID: 48642 RVA: 0x005604E8 File Offset: 0x0055E6E8
			public bool HDLMJFLPCAN(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE03 RID: 48643 RVA: 0x00560550 File Offset: 0x0055E750
			public bool KBDFOOOEBMP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE04 RID: 48644 RVA: 0x005605B8 File Offset: 0x0055E7B8
			public bool OPEKJEEKHHD(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE05 RID: 48645 RVA: 0x00560620 File Offset: 0x0055E820
			public bool KPCGMDNGIGP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE06 RID: 48646 RVA: 0x00560688 File Offset: 0x0055E888
			public void EGAEDOHFAJE(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE07 RID: 48647 RVA: 0x005606E0 File Offset: 0x0055E8E0
			public bool JFCAMHEPJOD(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE08 RID: 48648 RVA: 0x00560748 File Offset: 0x0055E948
			public void BNKJNBIDPME(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE09 RID: 48649 RVA: 0x005607A0 File Offset: 0x0055E9A0
			public void HFPPENPGGAI(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE0A RID: 48650 RVA: 0x005607F8 File Offset: 0x0055E9F8
			public void GDBBAMFMKII(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE0B RID: 48651 RVA: 0x00560850 File Offset: 0x0055EA50
			public void LACNPNKHCAA(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE0C RID: 48652 RVA: 0x005608A8 File Offset: 0x0055EAA8
			public void PBFKCKCHEAC(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE0D RID: 48653 RVA: 0x00560900 File Offset: 0x0055EB00
			public bool NMHHFDMHHNP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE0E RID: 48654 RVA: 0x00560968 File Offset: 0x0055EB68
			public void JOHDLNOKCOK(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE0F RID: 48655 RVA: 0x005609C0 File Offset: 0x0055EBC0
			public void KEBDEJIAODF(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE10 RID: 48656 RVA: 0x00560A18 File Offset: 0x0055EC18
			public void HNMODJBBKBI(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE11 RID: 48657 RVA: 0x00560A70 File Offset: 0x0055EC70
			public bool AFBLAGAJLFB(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE12 RID: 48658 RVA: 0x00560AD8 File Offset: 0x0055ECD8
			public bool JPFPACHKEJG(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE13 RID: 48659 RVA: 0x00560B40 File Offset: 0x0055ED40
			public void INKGAFANFIB(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE14 RID: 48660 RVA: 0x00560B98 File Offset: 0x0055ED98
			public bool GELMGBKKKLJ(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO == IJJEJBACBHM.downsampling && this.FPBBEHFKCNK == IJJEJBACBHM.occlusionSource && this.FOOLFPPBBND == IJJEJBACBHM.ambientOnly && this.KKODLBNNAHJ == IJJEJBACBHM.debug && this.AHCNBEFFHPM == LBCHLCGOCOD.pixelWidth && this.JMPIIPPEFAB != LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE15 RID: 48661 RVA: 0x00560C00 File Offset: 0x0055EE00
			public void EMFOECIPBIP(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE16 RID: 48662 RVA: 0x00560C58 File Offset: 0x0055EE58
			public bool MEOALJNONIO(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				return this.LJCEMJHEPPO != IJJEJBACBHM.downsampling || this.FPBBEHFKCNK != IJJEJBACBHM.occlusionSource || this.FOOLFPPBBND != IJJEJBACBHM.ambientOnly || this.KKODLBNNAHJ != IJJEJBACBHM.debug || this.AHCNBEFFHPM != LBCHLCGOCOD.pixelWidth || this.JMPIIPPEFAB == LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x0600BE17 RID: 48663 RVA: 0x00560CC0 File Offset: 0x0055EEC0
			public void IEOICHPKEMD(AmbientOcclusion.Settings IJJEJBACBHM, Camera LBCHLCGOCOD)
			{
				this.LJCEMJHEPPO = IJJEJBACBHM.downsampling;
				this.FPBBEHFKCNK = IJJEJBACBHM.occlusionSource;
				this.FOOLFPPBBND = IJJEJBACBHM.ambientOnly;
				this.KKODLBNNAHJ = IJJEJBACBHM.debug;
				this.AHCNBEFFHPM = LBCHLCGOCOD.pixelWidth;
				this.JMPIIPPEFAB = LBCHLCGOCOD.pixelHeight;
			}

			// Token: 0x040018B8 RID: 6328
			private bool LJCEMJHEPPO;

			// Token: 0x040018B9 RID: 6329
			private AmbientOcclusion.NHKEAOMBNOJ FPBBEHFKCNK;

			// Token: 0x040018BA RID: 6330
			private bool FOOLFPPBBND;

			// Token: 0x040018BB RID: 6331
			private bool KKODLBNNAHJ;

			// Token: 0x040018BC RID: 6332
			private int AHCNBEFFHPM;

			// Token: 0x040018BD RID: 6333
			private int JMPIIPPEFAB;
		}

		// Token: 0x02000342 RID: 834
		public enum MBHOOLCHOGB
		{
			// Token: 0x040018BF RID: 6335
			Lowest,
			// Token: 0x040018C0 RID: 6336
			Low,
			// Token: 0x040018C1 RID: 6337
			Medium,
			// Token: 0x040018C2 RID: 6338
			High,
			// Token: 0x040018C3 RID: 6339
			Variable
		}

		// Token: 0x02000343 RID: 835
		public enum NHKEAOMBNOJ
		{
			// Token: 0x040018C5 RID: 6341
			DepthTexture,
			// Token: 0x040018C6 RID: 6342
			DepthNormalsTexture,
			// Token: 0x040018C7 RID: 6343
			GBuffer
		}

		// Token: 0x02000344 RID: 836
		[Serializable]
		public class Settings
		{
			// Token: 0x0600BE18 RID: 48664 RVA: 0x00560D18 File Offset: 0x0055EF18
			public static AmbientOcclusion.Settings GDKPNHJPBKJ()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 217f,
					radius = 1960f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.Lowest,
					sampleCountValue = -126,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
				};
			}

			// Token: 0x0600BE19 RID: 48665 RVA: 0x00560D64 File Offset: 0x0055EF64
			public static AmbientOcclusion.Settings NJJBBDIFPKH()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 36f,
					radius = 1582f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.High,
					sampleCountValue = -31,
					downsampling = false,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
				};
			}

			// Token: 0x0600BE1A RID: 48666 RVA: 0x00560DB0 File Offset: 0x0055EFB0
			public static AmbientOcclusion.Settings PIAJOHPDMNA()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 851f,
					radius = 1258f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.Variable,
					sampleCountValue = 7,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
				};
			}

			// Token: 0x0600BE1B RID: 48667 RVA: 0x00560DFC File Offset: 0x0055EFFC
			public static AmbientOcclusion.Settings MDDFLLOCDEA()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 233f,
					radius = 77f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.Lowest,
					sampleCountValue = -114,
					downsampling = false,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
				};
			}

			// Token: 0x0600BE1C RID: 48668 RVA: 0x00560E48 File Offset: 0x0055F048
			public static AmbientOcclusion.Settings MDDBLMDKDAO()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 714f,
					radius = 252f,
					sampleCount = (AmbientOcclusion.MBHOOLCHOGB)8,
					sampleCountValue = 52,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
				};
			}

			// Token: 0x0600BE1D RID: 48669 RVA: 0x00560E94 File Offset: 0x0055F094
			public static AmbientOcclusion.Settings HMDLEIJHKEP()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 242f,
					radius = 848f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.High,
					sampleCountValue = 43,
					downsampling = false,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthTexture
				};
			}

			// Token: 0x0600BE1E RID: 48670 RVA: 0x00560EE0 File Offset: 0x0055F0E0
			public static AmbientOcclusion.Settings NLCHLENDMLI()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1884f,
					radius = 1226f,
					sampleCount = (AmbientOcclusion.MBHOOLCHOGB)8,
					sampleCountValue = 119,
					downsampling = false,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthTexture
				};
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x0600BE1F RID: 48671 RVA: 0x00560F2C File Offset: 0x0055F12C
			public static AmbientOcclusion.Settings defaultSettings
			{
				get
				{
					return new AmbientOcclusion.Settings
					{
						intensity = 1f,
						radius = 0.3f,
						sampleCount = AmbientOcclusion.MBHOOLCHOGB.Medium,
						sampleCountValue = 24,
						downsampling = false,
						ambientOnly = false,
						occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
					};
				}
			}

			// Token: 0x0600BE20 RID: 48672 RVA: 0x00560F78 File Offset: 0x0055F178
			public static AmbientOcclusion.Settings JPGMEJNEOCC()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1463f,
					radius = 446f,
					sampleCount = (AmbientOcclusion.MBHOOLCHOGB)8,
					sampleCountValue = -117,
					downsampling = false,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
				};
			}

			// Token: 0x0600BE21 RID: 48673 RVA: 0x00560FC4 File Offset: 0x0055F1C4
			public static AmbientOcclusion.Settings FBBLPICJODA()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 893f,
					radius = 89f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.Lowest,
					sampleCountValue = 74,
					downsampling = true,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
				};
			}

			// Token: 0x0600BE22 RID: 48674 RVA: 0x00561010 File Offset: 0x0055F210
			public static AmbientOcclusion.Settings MDGIIBPIGJC()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 229f,
					radius = 125f,
					sampleCount = (AmbientOcclusion.MBHOOLCHOGB)6,
					sampleCountValue = 34,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthTexture
				};
			}

			// Token: 0x0600BE23 RID: 48675 RVA: 0x0056105C File Offset: 0x0055F25C
			public static AmbientOcclusion.Settings MEFEDCEEAMK()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 794f,
					radius = 67f,
					sampleCount = (AmbientOcclusion.MBHOOLCHOGB)6,
					sampleCountValue = 112,
					downsampling = false,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthTexture
				};
			}

			// Token: 0x0600BE24 RID: 48676 RVA: 0x005610A8 File Offset: 0x0055F2A8
			public static AmbientOcclusion.Settings OOFOKHIDMDG()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1988f,
					radius = 476f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.Medium,
					sampleCountValue = 100,
					downsampling = false,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthTexture
				};
			}

			// Token: 0x0600BE25 RID: 48677 RVA: 0x005610F4 File Offset: 0x0055F2F4
			public static AmbientOcclusion.Settings MJLLLKFIDOE()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 680f,
					radius = 880f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.High,
					sampleCountValue = -27,
					downsampling = true,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthTexture
				};
			}

			// Token: 0x0600BE26 RID: 48678 RVA: 0x00561140 File Offset: 0x0055F340
			public static AmbientOcclusion.Settings OCIMBHLOOGC()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1013f,
					radius = 1564f,
					sampleCount = (AmbientOcclusion.MBHOOLCHOGB)5,
					sampleCountValue = -49,
					downsampling = true,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthTexture
				};
			}

			// Token: 0x0600BE27 RID: 48679 RVA: 0x0056118C File Offset: 0x0055F38C
			public static AmbientOcclusion.Settings OOKKEMFPNBJ()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1391f,
					radius = 1708f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.Medium,
					sampleCountValue = 42,
					downsampling = true,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
				};
			}

			// Token: 0x0600BE28 RID: 48680 RVA: 0x005611D8 File Offset: 0x0055F3D8
			public static AmbientOcclusion.Settings IGIKNGLDPJB()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 220f,
					radius = 35f,
					sampleCount = (AmbientOcclusion.MBHOOLCHOGB)5,
					sampleCountValue = -110,
					downsampling = true,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
				};
			}

			// Token: 0x0600BE29 RID: 48681 RVA: 0x00561224 File Offset: 0x0055F424
			public static AmbientOcclusion.Settings MKEJGGFNILJ()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1889f,
					radius = 1124f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.Variable,
					sampleCountValue = -88,
					downsampling = false,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
				};
			}

			// Token: 0x0600BE2A RID: 48682 RVA: 0x00561270 File Offset: 0x0055F470
			public static AmbientOcclusion.Settings COINKHKLJAP()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 624f,
					radius = 956f,
					sampleCount = (AmbientOcclusion.MBHOOLCHOGB)6,
					sampleCountValue = 88,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthNormalsTexture
				};
			}

			// Token: 0x0600BE2B RID: 48683 RVA: 0x005612BC File Offset: 0x0055F4BC
			public static AmbientOcclusion.Settings HLLBKJENCLA()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 572f,
					radius = 948f,
					sampleCount = (AmbientOcclusion.MBHOOLCHOGB)5,
					sampleCountValue = -47,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthTexture
				};
			}

			// Token: 0x0600BE2C RID: 48684 RVA: 0x00561308 File Offset: 0x0055F508
			public static AmbientOcclusion.Settings NNNMNENCOBC()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 21f,
					radius = 1388f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.Variable,
					sampleCountValue = -84,
					downsampling = false,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthTexture
				};
			}

			// Token: 0x0600BE2D RID: 48685 RVA: 0x00561354 File Offset: 0x0055F554
			public static AmbientOcclusion.Settings CGGMKBADCBM()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 867f,
					radius = 1230f,
					sampleCount = AmbientOcclusion.MBHOOLCHOGB.Medium,
					sampleCountValue = 123,
					downsampling = false,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.NHKEAOMBNOJ.DepthTexture
				};
			}

			// Token: 0x040018C8 RID: 6344
			[Tooltip("Degree of darkness produced by the effect.")]
			[Range(0f, 4f)]
			[SerializeField]
			public float intensity;

			// Token: 0x040018C9 RID: 6345
			[SerializeField]
			[Tooltip("Radius of sample points, which affects extent of darkened areas.")]
			public float radius;

			// Token: 0x040018CA RID: 6346
			[Tooltip("Number of sample points, which affects quality and performance.")]
			[SerializeField]
			public AmbientOcclusion.MBHOOLCHOGB sampleCount;

			// Token: 0x040018CB RID: 6347
			[Tooltip("Determines the sample count when SampleCount.Variable is used.")]
			[SerializeField]
			public int sampleCountValue;

			// Token: 0x040018CC RID: 6348
			[SerializeField]
			[Tooltip("Halves the resolution of the effect to increase performance.")]
			public bool downsampling;

			// Token: 0x040018CD RID: 6349
			[SerializeField]
			[Tooltip("If checked, the effect only affects ambient lighting.")]
			public bool ambientOnly;

			// Token: 0x040018CE RID: 6350
			[SerializeField]
			[Tooltip("Source buffer on which the occlusion estimator is based.")]
			public AmbientOcclusion.NHKEAOMBNOJ occlusionSource;

			// Token: 0x040018CF RID: 6351
			[SerializeField]
			[Tooltip("Displays occlusion for debug purpose.")]
			public bool debug;
		}
	}
}
