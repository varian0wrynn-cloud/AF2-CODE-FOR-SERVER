using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000317 RID: 791
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	[RequireComponent(typeof(Camera))]
	public class DepthOfField : PostEffectsBase
	{
		// Token: 0x0600B681 RID: 46721 RVA: 0x0050F8B4 File Offset: 0x0050DAB4
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(true);
			this.FDBNGFGDPKM = base.DJFOEIJIMJB(this.dofHdrShader, this.FDBNGFGDPKM);
			if (this.PKDDLGKEIBG && this.blurType == DepthOfField.NMPPINHBJME.DX11)
			{
				this.DGKGPFFLICL = base.DJFOEIJIMJB(this.dx11BokehShader, this.DGKGPFFLICL);
				this.LJIBHNKFLDB();
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B682 RID: 46722 RVA: 0x0050F924 File Offset: 0x0050DB24
		private void BPFMCOKJKAN()
		{
			if (this.IHIKEKIHMFP != null)
			{
				this.IHIKEKIHMFP.Release();
			}
			this.IHIKEKIHMFP = null;
			if (this.PKINDKDKDOD != null)
			{
				this.PKINDKDKDOD.Release();
			}
			this.PKINDKDKDOD = null;
		}

		// Token: 0x0600B683 RID: 46723 RVA: 0x0050F924 File Offset: 0x0050DB24
		private void ILBHLNIIHNH()
		{
			if (this.IHIKEKIHMFP != null)
			{
				this.IHIKEKIHMFP.Release();
			}
			this.IHIKEKIHMFP = null;
			if (this.PKINDKDKDOD != null)
			{
				this.PKINDKDKDOD.Release();
			}
			this.PKINDKDKDOD = null;
		}

		// Token: 0x0600B684 RID: 46724 RVA: 0x0050F95C File Offset: 0x0050DB5C
		private void CLFCBCGNLOI()
		{
			if (this.IHIKEKIHMFP == null)
			{
				this.IHIKEKIHMFP = new ComputeBuffer(1, 45, (ComputeBufferType)64);
				int[] array = new int[3];
				array[1] = 1;
				array[1] = 0;
				array[3] = 0;
				array[8] = 0;
				this.IHIKEKIHMFP.SetData(array);
			}
			if (this.PKINDKDKDOD == null)
			{
				this.PKINDKDKDOD = new ComputeBuffer(159, -73, ComputeBufferType.Default);
			}
		}

		// Token: 0x0600B685 RID: 46725 RVA: 0x0050F9C4 File Offset: 0x0050DBC4
		private void OnDisable()
		{
			this.CNHAMOLGDEO();
			if (this.FDBNGFGDPKM)
			{
				UnityEngine.Object.DestroyImmediate(this.FDBNGFGDPKM);
			}
			this.FDBNGFGDPKM = null;
			if (this.DGKGPFFLICL)
			{
				UnityEngine.Object.DestroyImmediate(this.DGKGPFFLICL);
			}
			this.DGKGPFFLICL = null;
		}

		// Token: 0x0600B686 RID: 46726 RVA: 0x0050FA18 File Offset: 0x0050DC18
		private void LHOGKGDMBNH(RenderTexture HHBECEKFGFM, bool BEBLAFNJFML)
		{
			this.FDBNGFGDPKM.SetTexture("Vertical", null);
			if (this.nearBlur && BEBLAFNJFML)
			{
				int width = HHBECEKFGFM.width / 3;
				int height = HHBECEKFGFM.height / 0;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HHBECEKFGFM.format);
				Graphics.Blit(HHBECEKFGFM, temporary, this.FDBNGFGDPKM, 8);
				float num = this.EPANEEKKBDM * this.foregroundOverlap;
				this.FDBNGFGDPKM.SetVector("<color='#b0a0c0'>", new Vector4(1230f, num, 1898f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, HHBECEKFGFM.format);
				Graphics.Blit(temporary, temporary2, this.FDBNGFGDPKM, 3);
				RenderTexture.ReleaseTemporary(temporary);
				this.FDBNGFGDPKM.SetVector("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_full_body_biped_i_k.html", new Vector4(num, 1723f, 1456f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, HHBECEKFGFM.format);
				Graphics.Blit(temporary2, temporary, this.FDBNGFGDPKM, 8);
				RenderTexture.ReleaseTemporary(temporary2);
				this.FDBNGFGDPKM.SetTexture("demoByteArray", temporary);
				HHBECEKFGFM.MarkRestoreExpected();
				Graphics.Blit(HHBECEKFGFM, HHBECEKFGFM, this.FDBNGFGDPKM, 68);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			HHBECEKFGFM.MarkRestoreExpected();
			Graphics.Blit(HHBECEKFGFM, HHBECEKFGFM, this.FDBNGFGDPKM, 1);
		}

		// Token: 0x0600B687 RID: 46727 RVA: 0x0050FB48 File Offset: 0x0050DD48
		private void PPMLOADNIHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.aperture < 1798f)
			{
				this.aperture = 1979f;
			}
			if (this.maxBlurSize < 1457f)
			{
				this.maxBlurSize = 379f;
			}
			this.focalSize = Mathf.Clamp(this.focalSize, 516f, 1076f);
			this.EPANEEKKBDM = Mathf.Max(this.maxBlurSize, 27f);
			this.MHJDKBOLOBD = (this.focalTransform ? (this.IOANGNFACJF.WorldToViewportPoint(this.focalTransform.position).z / this.IOANGNFACJF.farClipPlane) : this.EIJGEHFDHLP(this.focalLength));
			this.FDBNGFGDPKM.SetVector("/Localization/", new Vector4(37f, this.focalSize, 534f / (905f - this.aperture) - 1019f, this.MHJDKBOLOBD));
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			float num = this.EPANEEKKBDM * this.foregroundOverlap;
			if (this.visualizeFocus)
			{
				this.DNOECGEHDKD(JONJODLFAEN, false);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FDBNGFGDPKM, -48);
			}
			else if (this.blurType == DepthOfField.NMPPINHBJME.DX11 && this.DGKGPFFLICL)
			{
				if (this.highResolution)
				{
					this.EPANEEKKBDM = ((this.EPANEEKKBDM < 936f) ? 1972f : this.EPANEEKKBDM);
					num = this.EPANEEKKBDM * this.foregroundOverlap;
					renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
					RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
					this.LHOGKGDMBNH(JONJODLFAEN, true);
					RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width >> 0, JONJODLFAEN.height >> 0, 1, JONJODLFAEN.format);
					RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width >> 1, JONJODLFAEN.height >> 0, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, temporary2, this.FDBNGFGDPKM, 41);
					this.FDBNGFGDPKM.SetVector("sunshine_ShadowCoordDepthRayZ", new Vector4(1743f, 1597f, 511f, 708f));
					Graphics.Blit(temporary2, temporary3, this.FDBNGFGDPKM, -8);
					this.FDBNGFGDPKM.SetVector("ragulaFider", new Vector4(123f, 915f, 1772f, 1519f));
					Graphics.Blit(temporary3, temporary2, this.FDBNGFGDPKM, -115);
					if (this.nearBlur)
					{
						Graphics.Blit(JONJODLFAEN, temporary3, this.FDBNGFGDPKM, 7);
					}
					this.DGKGPFFLICL.SetTexture("Animator unassigned in AnimationWarping", temporary2);
					this.DGKGPFFLICL.SetFloat("RollerBladeCrossoverRight", this.dx11SpawnHeuristic);
					this.DGKGPFFLICL.SetVector("iNPC", new Vector4(this.dx11BokehScale, this.dx11BokehIntensity, Mathf.Clamp(this.dx11BokehThreshold, 1652f, 913f), this.EPANEEKKBDM));
					this.DGKGPFFLICL.SetTexture("", this.nearBlur ? temporary3 : null);
					Graphics.SetRandomWriteTarget(1, this.PKINDKDKDOD);
					Graphics.Blit(JONJODLFAEN, renderTexture, this.DGKGPFFLICL, 0);
					Graphics.ClearRandomWriteTargets();
					if (this.nearBlur)
					{
						this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(1411f, num, 54f, num));
						Graphics.Blit(temporary3, temporary2, this.FDBNGFGDPKM, 5);
						this.FDBNGFGDPKM.SetVector("box", new Vector4(num, 1948f, 1251f, num));
						Graphics.Blit(temporary2, temporary3, this.FDBNGFGDPKM, 5);
						Graphics.Blit(temporary3, renderTexture, this.FDBNGFGDPKM, 3);
					}
					Graphics.Blit(renderTexture, temporary, this.FDBNGFGDPKM, -122);
					this.FDBNGFGDPKM.SetVector("_RgbTex", new Vector4(this.EPANEEKKBDM, 353f, 1755f, this.EPANEEKKBDM));
					Graphics.Blit(renderTexture, JONJODLFAEN, this.FDBNGFGDPKM, 6);
					this.FDBNGFGDPKM.SetVector("FOG_OF_WAR_ON", new Vector4(439f, this.EPANEEKKBDM, 22f, this.EPANEEKKBDM));
					Graphics.Blit(JONJODLFAEN, temporary, this.FDBNGFGDPKM, -103);
					Graphics.SetRenderTarget(temporary);
					ComputeBuffer.CopyCount(this.PKINDKDKDOD, this.IHIKEKIHMFP, 0);
					this.DGKGPFFLICL.SetBuffer("", this.PKINDKDKDOD);
					this.DGKGPFFLICL.SetTexture("WeaponInstant", this.dx11BokehTexture);
					this.DGKGPFFLICL.SetVector("IdleSad", new Vector3(1164f / (453f * (float)JONJODLFAEN.width), 784f / (1254f * (float)JONJODLFAEN.height), this.EPANEEKKBDM));
					this.DGKGPFFLICL.SetPass(6);
					Graphics.DrawProceduralIndirectNow((MeshTopology)1, this.IHIKEKIHMFP, 1);
					Graphics.Blit(temporary, OKIIDHIJBEA);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(temporary2);
					RenderTexture.ReleaseTemporary(temporary3);
				}
				else
				{
					renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> 1, JONJODLFAEN.height >> 0, 1, JONJODLFAEN.format);
					renderTexture2 = RenderTexture.GetTemporary(JONJODLFAEN.width >> 1, JONJODLFAEN.height >> 0, 1, JONJODLFAEN.format);
					num = this.EPANEEKKBDM * this.foregroundOverlap;
					this.LHOGKGDMBNH(JONJODLFAEN, false);
					JONJODLFAEN.filterMode = FilterMode.Bilinear;
					Graphics.Blit(JONJODLFAEN, renderTexture, this.FDBNGFGDPKM, 6);
					RenderTexture temporary2 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 0, 1, renderTexture.format);
					RenderTexture temporary3 = RenderTexture.GetTemporary(renderTexture.width >> 0, renderTexture.height >> 0, 1, renderTexture.format);
					Graphics.Blit(renderTexture, temporary2, this.FDBNGFGDPKM, 121);
					this.FDBNGFGDPKM.SetVector("Bend Constraint is referencing to a bone '", new Vector4(1951f, 277f, 947f, 979f));
					Graphics.Blit(temporary2, temporary3, this.FDBNGFGDPKM, 80);
					this.FDBNGFGDPKM.SetVector("wpn_rod1", new Vector4(958f, 1286f, 5f, 1173f));
					Graphics.Blit(temporary3, temporary2, this.FDBNGFGDPKM, -97);
					RenderTexture renderTexture3 = null;
					if (this.nearBlur)
					{
						renderTexture3 = RenderTexture.GetTemporary(JONJODLFAEN.width >> 1, JONJODLFAEN.height >> 0, 1, JONJODLFAEN.format);
						Graphics.Blit(JONJODLFAEN, renderTexture3, this.FDBNGFGDPKM, 2);
					}
					this.DGKGPFFLICL.SetTexture("inv_buymsg", temporary2);
					this.DGKGPFFLICL.SetFloat("The shader ", this.dx11SpawnHeuristic);
					this.DGKGPFFLICL.SetVector("21,22,23", new Vector4(this.dx11BokehScale, this.dx11BokehIntensity, Mathf.Clamp(this.dx11BokehThreshold, 1553f, 1798f), this.EPANEEKKBDM));
					this.DGKGPFFLICL.SetTexture("shop_t7", renderTexture3);
					Graphics.SetRandomWriteTarget(0, this.PKINDKDKDOD);
					Graphics.Blit(renderTexture, renderTexture2, this.DGKGPFFLICL, 0);
					Graphics.ClearRandomWriteTargets();
					RenderTexture.ReleaseTemporary(temporary2);
					RenderTexture.ReleaseTemporary(temporary3);
					if (this.nearBlur)
					{
						this.FDBNGFGDPKM.SetVector("Mouse ScrollWheel", new Vector4(897f, num, 687f, num));
						Graphics.Blit(renderTexture3, renderTexture, this.FDBNGFGDPKM, 2);
						this.FDBNGFGDPKM.SetVector("buyVIP OK", new Vector4(num, 399f, 1608f, num));
						Graphics.Blit(renderTexture, renderTexture3, this.FDBNGFGDPKM, 1);
						Graphics.Blit(renderTexture3, renderTexture2, this.FDBNGFGDPKM, 6);
					}
					this.FDBNGFGDPKM.SetVector("WeaponRun", new Vector4(this.EPANEEKKBDM, 1033f, 1303f, this.EPANEEKKBDM));
					Graphics.Blit(renderTexture2, renderTexture, this.FDBNGFGDPKM, 5);
					this.FDBNGFGDPKM.SetVector("fshop_msg2", new Vector4(177f, this.EPANEEKKBDM, 1893f, this.EPANEEKKBDM));
					Graphics.Blit(renderTexture, renderTexture2, this.FDBNGFGDPKM, 8);
					Graphics.SetRenderTarget(renderTexture2);
					ComputeBuffer.CopyCount(this.PKINDKDKDOD, this.IHIKEKIHMFP, 0);
					this.DGKGPFFLICL.SetBuffer("medium", this.PKINDKDKDOD);
					this.DGKGPFFLICL.SetTexture("<color='#003000'>", this.dx11BokehTexture);
					this.DGKGPFFLICL.SetVector("_Radius", new Vector3(85f / (1940f * (float)renderTexture2.width), 941f / (1790f * (float)renderTexture2.height), this.EPANEEKKBDM));
					this.DGKGPFFLICL.SetPass(0);
					Graphics.DrawProceduralIndirectNow((MeshTopology)1, this.IHIKEKIHMFP, 0);
					this.FDBNGFGDPKM.SetTexture("wpn_rec2", renderTexture2);
					this.FDBNGFGDPKM.SetTexture("2000", renderTexture3);
					this.FDBNGFGDPKM.SetVector("1 Hand Sword Run", 473f * (float)JONJODLFAEN.width / (1003f * (float)renderTexture2.width) * this.EPANEEKKBDM * Vector4.one);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FDBNGFGDPKM, 108);
					if (renderTexture3)
					{
						RenderTexture.ReleaseTemporary(renderTexture3);
					}
				}
			}
			else
			{
				JONJODLFAEN.filterMode = FilterMode.Bilinear;
				if (this.highResolution)
				{
					this.EPANEEKKBDM *= 81f;
				}
				this.GNHIHEFCKBK(JONJODLFAEN, false);
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> 0, JONJODLFAEN.height >> 1, 0, JONJODLFAEN.format);
				renderTexture2 = RenderTexture.GetTemporary(JONJODLFAEN.width >> 0, JONJODLFAEN.height >> 0, 0, JONJODLFAEN.format);
				int pass = (this.blurSampleCount == (DepthOfField.PIDJOPKJMED)4 || this.blurSampleCount == DepthOfField.PIDJOPKJMED.Medium) ? 31 : -61;
				if (this.highResolution)
				{
					this.FDBNGFGDPKM.SetVector("Press R or LMB for procedural recoil.", new Vector4(1890f, this.EPANEEKKBDM, 1387f, this.EPANEEKKBDM));
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FDBNGFGDPKM, pass);
				}
				else
				{
					this.FDBNGFGDPKM.SetVector("InteractionObject Multiplier 'Curve' ", new Vector4(986f, this.EPANEEKKBDM, 1486f, this.EPANEEKKBDM));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.FDBNGFGDPKM, 0);
					Graphics.Blit(renderTexture, renderTexture2, this.FDBNGFGDPKM, pass);
					this.FDBNGFGDPKM.SetTexture("SunshinePreferences", renderTexture2);
					this.FDBNGFGDPKM.SetTexture("?", null);
					this.FDBNGFGDPKM.SetVector("", Vector4.one * (1746f * (float)JONJODLFAEN.width / (784f * (float)renderTexture2.width)) * this.EPANEEKKBDM);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FDBNGFGDPKM, (this.blurSampleCount == DepthOfField.PIDJOPKJMED.High) ? -29 : -127);
				}
			}
			if (renderTexture)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if (renderTexture2)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
		}

		// Token: 0x0600B688 RID: 46728 RVA: 0x005105FA File Offset: 0x0050E7FA
		private void BGKOJIDABKB()
		{
			this.IOANGNFACJF = base.GetComponent<Camera>();
			this.IOANGNFACJF.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B689 RID: 46729 RVA: 0x0051061C File Offset: 0x0050E81C
		private void GNHIHEFCKBK(RenderTexture HHBECEKFGFM, bool BEBLAFNJFML)
		{
			this.FDBNGFGDPKM.SetTexture("_FgOverlap", null);
			if (this.nearBlur && BEBLAFNJFML)
			{
				int width = HHBECEKFGFM.width / 2;
				int height = HHBECEKFGFM.height / 2;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HHBECEKFGFM.format);
				Graphics.Blit(HHBECEKFGFM, temporary, this.FDBNGFGDPKM, 4);
				float num = this.EPANEEKKBDM * this.foregroundOverlap;
				this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, HHBECEKFGFM.format);
				Graphics.Blit(temporary, temporary2, this.FDBNGFGDPKM, 2);
				RenderTexture.ReleaseTemporary(temporary);
				this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, HHBECEKFGFM.format);
				Graphics.Blit(temporary2, temporary, this.FDBNGFGDPKM, 2);
				RenderTexture.ReleaseTemporary(temporary2);
				this.FDBNGFGDPKM.SetTexture("_FgOverlap", temporary);
				HHBECEKFGFM.MarkRestoreExpected();
				Graphics.Blit(HHBECEKFGFM, HHBECEKFGFM, this.FDBNGFGDPKM, 13);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			HHBECEKFGFM.MarkRestoreExpected();
			Graphics.Blit(HHBECEKFGFM, HHBECEKFGFM, this.FDBNGFGDPKM, 0);
		}

		// Token: 0x0600B68A RID: 46730 RVA: 0x0051074C File Offset: 0x0050E94C
		private float HCOAKODMBKC(float DFCBOEMAOIJ)
		{
			return this.IOANGNFACJF.WorldToViewportPoint((DFCBOEMAOIJ - this.IOANGNFACJF.nearClipPlane) * this.IOANGNFACJF.transform.forward + this.IOANGNFACJF.transform.position).z / (this.IOANGNFACJF.farClipPlane - this.IOANGNFACJF.nearClipPlane);
		}

		// Token: 0x0600B68B RID: 46731 RVA: 0x005107B8 File Offset: 0x0050E9B8
		public virtual bool CFHOHAOFPIO()
		{
			base.CGEGCOKMPHN(false);
			this.FDBNGFGDPKM = base.JBHLGBPJFEL(this.dofHdrShader, this.FDBNGFGDPKM);
			if (this.PKDDLGKEIBG && this.blurType == DepthOfField.NMPPINHBJME.DX11)
			{
				this.DGKGPFFLICL = base.BOOFEOGDMBI(this.dx11BokehShader, this.DGKGPFFLICL);
				this.LJIBHNKFLDB();
			}
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B68C RID: 46732 RVA: 0x0050F924 File Offset: 0x0050DB24
		private void CNHAMOLGDEO()
		{
			if (this.IHIKEKIHMFP != null)
			{
				this.IHIKEKIHMFP.Release();
			}
			this.IHIKEKIHMFP = null;
			if (this.PKINDKDKDOD != null)
			{
				this.PKINDKDKDOD.Release();
			}
			this.PKINDKDKDOD = null;
		}

		// Token: 0x0600B68D RID: 46733 RVA: 0x00510828 File Offset: 0x0050EA28
		private void MPNHAGONKBG()
		{
			this.IOANGNFACJF = base.GetComponent<Camera>();
			this.IOANGNFACJF.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B68E RID: 46734 RVA: 0x0051084C File Offset: 0x0050EA4C
		private float KBELECENEKO(float DFCBOEMAOIJ)
		{
			return this.IOANGNFACJF.WorldToViewportPoint((DFCBOEMAOIJ - this.IOANGNFACJF.nearClipPlane) * this.IOANGNFACJF.transform.forward + this.IOANGNFACJF.transform.position).z / (this.IOANGNFACJF.farClipPlane - this.IOANGNFACJF.nearClipPlane);
		}

		// Token: 0x0600B68F RID: 46735 RVA: 0x005108B8 File Offset: 0x0050EAB8
		private void DNOECGEHDKD(RenderTexture HHBECEKFGFM, bool BEBLAFNJFML)
		{
			this.FDBNGFGDPKM.SetTexture("Boxed", null);
			if (this.nearBlur && BEBLAFNJFML)
			{
				int width = HHBECEKFGFM.width / 4;
				int height = HHBECEKFGFM.height / 7;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, HHBECEKFGFM.format);
				Graphics.Blit(HHBECEKFGFM, temporary, this.FDBNGFGDPKM, 4);
				float num = this.EPANEEKKBDM * this.foregroundOverlap;
				this.FDBNGFGDPKM.SetVector("ComeHere", new Vector4(956f, num, 1280f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, HHBECEKFGFM.format);
				Graphics.Blit(temporary, temporary2, this.FDBNGFGDPKM, 7);
				RenderTexture.ReleaseTemporary(temporary);
				this.FDBNGFGDPKM.SetVector("languageid", new Vector4(num, 1290f, 666f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, HHBECEKFGFM.format);
				Graphics.Blit(temporary2, temporary, this.FDBNGFGDPKM, 6);
				RenderTexture.ReleaseTemporary(temporary2);
				this.FDBNGFGDPKM.SetTexture("LHandPunch", temporary);
				HHBECEKFGFM.MarkRestoreExpected();
				Graphics.Blit(HHBECEKFGFM, HHBECEKFGFM, this.FDBNGFGDPKM, 20);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			HHBECEKFGFM.MarkRestoreExpected();
			Graphics.Blit(HHBECEKFGFM, HHBECEKFGFM, this.FDBNGFGDPKM, 0);
		}

		// Token: 0x0600B690 RID: 46736 RVA: 0x005109E8 File Offset: 0x0050EBE8
		public virtual bool CHJBCBDIBJJ()
		{
			base.CDBNBLBOLCL(false);
			this.FDBNGFGDPKM = base.BOOFEOGDMBI(this.dofHdrShader, this.FDBNGFGDPKM);
			if (this.PKDDLGKEIBG && this.blurType == DepthOfField.NMPPINHBJME.DX11)
			{
				this.DGKGPFFLICL = base.BOOFEOGDMBI(this.dx11BokehShader, this.DGKGPFFLICL);
				this.LJIBHNKFLDB();
			}
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B692 RID: 46738 RVA: 0x00510AEC File Offset: 0x0050ECEC
		private float EIJGEHFDHLP(float DFCBOEMAOIJ)
		{
			return this.IOANGNFACJF.WorldToViewportPoint((DFCBOEMAOIJ - this.IOANGNFACJF.nearClipPlane) * this.IOANGNFACJF.transform.forward + this.IOANGNFACJF.transform.position).z / (this.IOANGNFACJF.farClipPlane - this.IOANGNFACJF.nearClipPlane);
		}

		// Token: 0x0600B693 RID: 46739 RVA: 0x00510828 File Offset: 0x0050EA28
		private void IKFFGPLEECL()
		{
			this.IOANGNFACJF = base.GetComponent<Camera>();
			this.IOANGNFACJF.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B694 RID: 46740 RVA: 0x00510B58 File Offset: 0x0050ED58
		private void JJMBNKMCMJH(RenderTexture HHBECEKFGFM, bool BEBLAFNJFML)
		{
			this.FDBNGFGDPKM.SetTexture("26", null);
			if (this.nearBlur && BEBLAFNJFML)
			{
				int width = HHBECEKFGFM.width / 0;
				int height = HHBECEKFGFM.height / 0;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, HHBECEKFGFM.format);
				Graphics.Blit(HHBECEKFGFM, temporary, this.FDBNGFGDPKM, 5);
				float num = this.EPANEEKKBDM * this.foregroundOverlap;
				this.FDBNGFGDPKM.SetVector("", new Vector4(1833f, num, 20f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, HHBECEKFGFM.format);
				Graphics.Blit(temporary, temporary2, this.FDBNGFGDPKM, 5);
				RenderTexture.ReleaseTemporary(temporary);
				this.FDBNGFGDPKM.SetVector("_MainTexBlurred", new Vector4(num, 1442f, 113f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, HHBECEKFGFM.format);
				Graphics.Blit(temporary2, temporary, this.FDBNGFGDPKM, 4);
				RenderTexture.ReleaseTemporary(temporary2);
				this.FDBNGFGDPKM.SetTexture("Make sure you are not placing 2 or more FBBIK effectors of the same chain to exactly the same position.", temporary);
				HHBECEKFGFM.MarkRestoreExpected();
				Graphics.Blit(HHBECEKFGFM, HHBECEKFGFM, this.FDBNGFGDPKM, -93);
				RenderTexture.ReleaseTemporary(temporary);
				return;
			}
			HHBECEKFGFM.MarkRestoreExpected();
			Graphics.Blit(HHBECEKFGFM, HHBECEKFGFM, this.FDBNGFGDPKM, 1);
		}

		// Token: 0x0600B695 RID: 46741 RVA: 0x005105FA File Offset: 0x0050E7FA
		private void OnEnable()
		{
			this.IOANGNFACJF = base.GetComponent<Camera>();
			this.IOANGNFACJF.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B696 RID: 46742 RVA: 0x00510C88 File Offset: 0x0050EE88
		private void PIPJPGGEFOL()
		{
			this.CNHAMOLGDEO();
			if (this.FDBNGFGDPKM)
			{
				UnityEngine.Object.DestroyImmediate(this.FDBNGFGDPKM);
			}
			this.FDBNGFGDPKM = null;
			if (this.DGKGPFFLICL)
			{
				UnityEngine.Object.DestroyImmediate(this.DGKGPFFLICL);
			}
			this.DGKGPFFLICL = null;
		}

		// Token: 0x0600B697 RID: 46743 RVA: 0x00510CDC File Offset: 0x0050EEDC
		private float FJOANFIIGFJ(float DFCBOEMAOIJ)
		{
			return this.IOANGNFACJF.WorldToViewportPoint((DFCBOEMAOIJ - this.IOANGNFACJF.nearClipPlane) * this.IOANGNFACJF.transform.forward + this.IOANGNFACJF.transform.position).z / (this.IOANGNFACJF.farClipPlane - this.IOANGNFACJF.nearClipPlane);
		}

		// Token: 0x0600B698 RID: 46744 RVA: 0x00510D48 File Offset: 0x0050EF48
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.aperture < 0f)
			{
				this.aperture = 0f;
			}
			if (this.maxBlurSize < 0.1f)
			{
				this.maxBlurSize = 0.1f;
			}
			this.focalSize = Mathf.Clamp(this.focalSize, 0f, 2f);
			this.EPANEEKKBDM = Mathf.Max(this.maxBlurSize, 0f);
			this.MHJDKBOLOBD = (this.focalTransform ? (this.IOANGNFACJF.WorldToViewportPoint(this.focalTransform.position).z / this.IOANGNFACJF.farClipPlane) : this.KBELECENEKO(this.focalLength));
			this.FDBNGFGDPKM.SetVector("_CurveParams", new Vector4(1f, this.focalSize, 1f / (1f - this.aperture) - 1f, this.MHJDKBOLOBD));
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			float num = this.EPANEEKKBDM * this.foregroundOverlap;
			if (this.visualizeFocus)
			{
				this.GNHIHEFCKBK(JONJODLFAEN, true);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FDBNGFGDPKM, 16);
			}
			else if (this.blurType == DepthOfField.NMPPINHBJME.DX11 && this.DGKGPFFLICL)
			{
				if (this.highResolution)
				{
					this.EPANEEKKBDM = ((this.EPANEEKKBDM < 0.1f) ? 0.1f : this.EPANEEKKBDM);
					num = this.EPANEEKKBDM * this.foregroundOverlap;
					renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
					RenderTexture temporary = RenderTexture.GetTemporary(JONJODLFAEN.width, JONJODLFAEN.height, 0, JONJODLFAEN.format);
					this.GNHIHEFCKBK(JONJODLFAEN, false);
					RenderTexture temporary2 = RenderTexture.GetTemporary(JONJODLFAEN.width >> 1, JONJODLFAEN.height >> 1, 0, JONJODLFAEN.format);
					RenderTexture temporary3 = RenderTexture.GetTemporary(JONJODLFAEN.width >> 1, JONJODLFAEN.height >> 1, 0, JONJODLFAEN.format);
					Graphics.Blit(JONJODLFAEN, temporary2, this.FDBNGFGDPKM, 15);
					this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(temporary2, temporary3, this.FDBNGFGDPKM, 19);
					this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(temporary3, temporary2, this.FDBNGFGDPKM, 19);
					if (this.nearBlur)
					{
						Graphics.Blit(JONJODLFAEN, temporary3, this.FDBNGFGDPKM, 4);
					}
					this.DGKGPFFLICL.SetTexture("_BlurredColor", temporary2);
					this.DGKGPFFLICL.SetFloat("_SpawnHeuristic", this.dx11SpawnHeuristic);
					this.DGKGPFFLICL.SetVector("_BokehParams", new Vector4(this.dx11BokehScale, this.dx11BokehIntensity, Mathf.Clamp(this.dx11BokehThreshold, 0.005f, 4f), this.EPANEEKKBDM));
					this.DGKGPFFLICL.SetTexture("_FgCocMask", this.nearBlur ? temporary3 : null);
					Graphics.SetRandomWriteTarget(1, this.PKINDKDKDOD);
					Graphics.Blit(JONJODLFAEN, renderTexture, this.DGKGPFFLICL, 0);
					Graphics.ClearRandomWriteTargets();
					if (this.nearBlur)
					{
						this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(temporary3, temporary2, this.FDBNGFGDPKM, 2);
						this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(temporary2, temporary3, this.FDBNGFGDPKM, 2);
						Graphics.Blit(temporary3, renderTexture, this.FDBNGFGDPKM, 3);
					}
					Graphics.Blit(renderTexture, temporary, this.FDBNGFGDPKM, 20);
					this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(this.EPANEEKKBDM, 0f, 0f, this.EPANEEKKBDM));
					Graphics.Blit(renderTexture, JONJODLFAEN, this.FDBNGFGDPKM, 5);
					this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(0f, this.EPANEEKKBDM, 0f, this.EPANEEKKBDM));
					Graphics.Blit(JONJODLFAEN, temporary, this.FDBNGFGDPKM, 21);
					Graphics.SetRenderTarget(temporary);
					ComputeBuffer.CopyCount(this.PKINDKDKDOD, this.IHIKEKIHMFP, 0);
					this.DGKGPFFLICL.SetBuffer("pointBuffer", this.PKINDKDKDOD);
					this.DGKGPFFLICL.SetTexture("_MainTex", this.dx11BokehTexture);
					this.DGKGPFFLICL.SetVector("_Screen", new Vector3(1f / (1f * (float)JONJODLFAEN.width), 1f / (1f * (float)JONJODLFAEN.height), this.EPANEEKKBDM));
					this.DGKGPFFLICL.SetPass(2);
					Graphics.DrawProceduralIndirectNow(MeshTopology.Points, this.IHIKEKIHMFP, 0);
					Graphics.Blit(temporary, OKIIDHIJBEA);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(temporary2);
					RenderTexture.ReleaseTemporary(temporary3);
				}
				else
				{
					renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> 1, JONJODLFAEN.height >> 1, 0, JONJODLFAEN.format);
					renderTexture2 = RenderTexture.GetTemporary(JONJODLFAEN.width >> 1, JONJODLFAEN.height >> 1, 0, JONJODLFAEN.format);
					num = this.EPANEEKKBDM * this.foregroundOverlap;
					this.GNHIHEFCKBK(JONJODLFAEN, false);
					JONJODLFAEN.filterMode = FilterMode.Bilinear;
					Graphics.Blit(JONJODLFAEN, renderTexture, this.FDBNGFGDPKM, 6);
					RenderTexture temporary2 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					RenderTexture temporary3 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					Graphics.Blit(renderTexture, temporary2, this.FDBNGFGDPKM, 15);
					this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(temporary2, temporary3, this.FDBNGFGDPKM, 19);
					this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(temporary3, temporary2, this.FDBNGFGDPKM, 19);
					RenderTexture renderTexture3 = null;
					if (this.nearBlur)
					{
						renderTexture3 = RenderTexture.GetTemporary(JONJODLFAEN.width >> 1, JONJODLFAEN.height >> 1, 0, JONJODLFAEN.format);
						Graphics.Blit(JONJODLFAEN, renderTexture3, this.FDBNGFGDPKM, 4);
					}
					this.DGKGPFFLICL.SetTexture("_BlurredColor", temporary2);
					this.DGKGPFFLICL.SetFloat("_SpawnHeuristic", this.dx11SpawnHeuristic);
					this.DGKGPFFLICL.SetVector("_BokehParams", new Vector4(this.dx11BokehScale, this.dx11BokehIntensity, Mathf.Clamp(this.dx11BokehThreshold, 0.005f, 4f), this.EPANEEKKBDM));
					this.DGKGPFFLICL.SetTexture("_FgCocMask", renderTexture3);
					Graphics.SetRandomWriteTarget(1, this.PKINDKDKDOD);
					Graphics.Blit(renderTexture, renderTexture2, this.DGKGPFFLICL, 0);
					Graphics.ClearRandomWriteTargets();
					RenderTexture.ReleaseTemporary(temporary2);
					RenderTexture.ReleaseTemporary(temporary3);
					if (this.nearBlur)
					{
						this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture3, renderTexture, this.FDBNGFGDPKM, 2);
						this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture, renderTexture3, this.FDBNGFGDPKM, 2);
						Graphics.Blit(renderTexture3, renderTexture2, this.FDBNGFGDPKM, 3);
					}
					this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(this.EPANEEKKBDM, 0f, 0f, this.EPANEEKKBDM));
					Graphics.Blit(renderTexture2, renderTexture, this.FDBNGFGDPKM, 5);
					this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(0f, this.EPANEEKKBDM, 0f, this.EPANEEKKBDM));
					Graphics.Blit(renderTexture, renderTexture2, this.FDBNGFGDPKM, 5);
					Graphics.SetRenderTarget(renderTexture2);
					ComputeBuffer.CopyCount(this.PKINDKDKDOD, this.IHIKEKIHMFP, 0);
					this.DGKGPFFLICL.SetBuffer("pointBuffer", this.PKINDKDKDOD);
					this.DGKGPFFLICL.SetTexture("_MainTex", this.dx11BokehTexture);
					this.DGKGPFFLICL.SetVector("_Screen", new Vector3(1f / (1f * (float)renderTexture2.width), 1f / (1f * (float)renderTexture2.height), this.EPANEEKKBDM));
					this.DGKGPFFLICL.SetPass(1);
					Graphics.DrawProceduralIndirectNow(MeshTopology.Points, this.IHIKEKIHMFP, 0);
					this.FDBNGFGDPKM.SetTexture("_LowRez", renderTexture2);
					this.FDBNGFGDPKM.SetTexture("_FgOverlap", renderTexture3);
					this.FDBNGFGDPKM.SetVector("_Offsets", 1f * (float)JONJODLFAEN.width / (1f * (float)renderTexture2.width) * this.EPANEEKKBDM * Vector4.one);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FDBNGFGDPKM, 9);
					if (renderTexture3)
					{
						RenderTexture.ReleaseTemporary(renderTexture3);
					}
				}
			}
			else
			{
				JONJODLFAEN.filterMode = FilterMode.Bilinear;
				if (this.highResolution)
				{
					this.EPANEEKKBDM *= 2f;
				}
				this.GNHIHEFCKBK(JONJODLFAEN, true);
				renderTexture = RenderTexture.GetTemporary(JONJODLFAEN.width >> 1, JONJODLFAEN.height >> 1, 0, JONJODLFAEN.format);
				renderTexture2 = RenderTexture.GetTemporary(JONJODLFAEN.width >> 1, JONJODLFAEN.height >> 1, 0, JONJODLFAEN.format);
				int pass = (this.blurSampleCount == DepthOfField.PIDJOPKJMED.High || this.blurSampleCount == DepthOfField.PIDJOPKJMED.Medium) ? 17 : 11;
				if (this.highResolution)
				{
					this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(0f, this.EPANEEKKBDM, 0.025f, this.EPANEEKKBDM));
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FDBNGFGDPKM, pass);
				}
				else
				{
					this.FDBNGFGDPKM.SetVector("_Offsets", new Vector4(0f, this.EPANEEKKBDM, 0.1f, this.EPANEEKKBDM));
					Graphics.Blit(JONJODLFAEN, renderTexture, this.FDBNGFGDPKM, 6);
					Graphics.Blit(renderTexture, renderTexture2, this.FDBNGFGDPKM, pass);
					this.FDBNGFGDPKM.SetTexture("_LowRez", renderTexture2);
					this.FDBNGFGDPKM.SetTexture("_FgOverlap", null);
					this.FDBNGFGDPKM.SetVector("_Offsets", Vector4.one * (1f * (float)JONJODLFAEN.width / (1f * (float)renderTexture2.width)) * this.EPANEEKKBDM);
					Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.FDBNGFGDPKM, (this.blurSampleCount == DepthOfField.PIDJOPKJMED.High) ? 18 : 12);
				}
			}
			if (renderTexture)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if (renderTexture2)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
		}

		// Token: 0x0600B699 RID: 46745 RVA: 0x005117FC File Offset: 0x0050F9FC
		private void LJIBHNKFLDB()
		{
			if (this.IHIKEKIHMFP == null)
			{
				this.IHIKEKIHMFP = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
				int[] data = new int[]
				{
					0,
					1,
					0,
					0
				};
				this.IHIKEKIHMFP.SetData(data);
			}
			if (this.PKINDKDKDOD == null)
			{
				this.PKINDKDKDOD = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
			}
		}

		// Token: 0x0400178D RID: 6029
		public bool visualizeFocus;

		// Token: 0x0400178E RID: 6030
		public float focalLength = 10f;

		// Token: 0x0400178F RID: 6031
		public float focalSize = 0.05f;

		// Token: 0x04001790 RID: 6032
		public float aperture = 0.5f;

		// Token: 0x04001791 RID: 6033
		public Transform focalTransform;

		// Token: 0x04001792 RID: 6034
		public float maxBlurSize = 2f;

		// Token: 0x04001793 RID: 6035
		public bool highResolution;

		// Token: 0x04001794 RID: 6036
		public DepthOfField.NMPPINHBJME blurType;

		// Token: 0x04001795 RID: 6037
		public DepthOfField.PIDJOPKJMED blurSampleCount = DepthOfField.PIDJOPKJMED.High;

		// Token: 0x04001796 RID: 6038
		public bool nearBlur;

		// Token: 0x04001797 RID: 6039
		public float foregroundOverlap = 1f;

		// Token: 0x04001798 RID: 6040
		public Shader dofHdrShader;

		// Token: 0x04001799 RID: 6041
		private Material FDBNGFGDPKM;

		// Token: 0x0400179A RID: 6042
		public Shader dx11BokehShader;

		// Token: 0x0400179B RID: 6043
		private Material DGKGPFFLICL;

		// Token: 0x0400179C RID: 6044
		public float dx11BokehThreshold = 0.5f;

		// Token: 0x0400179D RID: 6045
		public float dx11SpawnHeuristic = 0.0875f;

		// Token: 0x0400179E RID: 6046
		public Texture2D dx11BokehTexture;

		// Token: 0x0400179F RID: 6047
		public float dx11BokehScale = 1.2f;

		// Token: 0x040017A0 RID: 6048
		public float dx11BokehIntensity = 2.5f;

		// Token: 0x040017A1 RID: 6049
		private float MHJDKBOLOBD = 10f;

		// Token: 0x040017A2 RID: 6050
		private ComputeBuffer IHIKEKIHMFP;

		// Token: 0x040017A3 RID: 6051
		private ComputeBuffer PKINDKDKDOD;

		// Token: 0x040017A4 RID: 6052
		private float EPANEEKKBDM = 1f;

		// Token: 0x040017A5 RID: 6053
		private Camera IOANGNFACJF;

		// Token: 0x02000318 RID: 792
		public enum NMPPINHBJME
		{
			// Token: 0x040017A7 RID: 6055
			DiscBlur,
			// Token: 0x040017A8 RID: 6056
			DX11
		}

		// Token: 0x02000319 RID: 793
		public enum PIDJOPKJMED
		{
			// Token: 0x040017AA RID: 6058
			Low,
			// Token: 0x040017AB RID: 6059
			Medium,
			// Token: 0x040017AC RID: 6060
			High
		}
	}
}
