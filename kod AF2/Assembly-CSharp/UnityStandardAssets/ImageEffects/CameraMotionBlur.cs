using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200030E RID: 782
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	[RequireComponent(typeof(Camera))]
	public class CameraMotionBlur : PostEffectsBase
	{
		// Token: 0x0600B459 RID: 46169 RVA: 0x004F5B24 File Offset: 0x004F3D24
		private void GANOGBNNIMJ()
		{
			this.ELJIHKALJGN = this.ACMFIGCDMBD;
			this.GDFCFFGPMAM = base.transform.forward;
			this.GPODKOAAIGA = base.transform.up;
			this.GJMNAHPDKKO = base.transform.position;
			this.CCDFEIHLHHI[1] = this.CCFLCHPKCIG[0];
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[0];
		}

		// Token: 0x0600B45A RID: 46170 RVA: 0x004F5BA0 File Offset: 0x004F3DA0
		private void EHNDLEILCDM()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B45B RID: 46171 RVA: 0x004F5C10 File Offset: 0x004F3E10
		private void IGCLAAMONAI()
		{
			this.ELJIHKALJGN = this.ACMFIGCDMBD;
			this.GDFCFFGPMAM = base.transform.forward;
			this.GPODKOAAIGA = base.transform.up;
			this.GJMNAHPDKKO = base.transform.position;
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[0];
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[1];
		}

		// Token: 0x0600B45D RID: 46173 RVA: 0x004F5D34 File Offset: 0x004F3F34
		private Camera JDPDICNNKAD()
		{
			if (this.CFOLJLNGMFP == null)
			{
				string name = "_" + this.OMIJMALCLAG.name + "_MotionBlurTmpCam";
				GameObject gameObject = GameObject.Find(name);
				if (null == gameObject)
				{
					this.CFOLJLNGMFP = new GameObject(name, new Type[]
					{
						typeof(Camera)
					});
				}
				else
				{
					this.CFOLJLNGMFP = gameObject;
				}
			}
			this.CFOLJLNGMFP.hideFlags = HideFlags.DontSave;
			this.CFOLJLNGMFP.transform.position = this.OMIJMALCLAG.transform.position;
			this.CFOLJLNGMFP.transform.rotation = this.OMIJMALCLAG.transform.rotation;
			this.CFOLJLNGMFP.transform.localScale = this.OMIJMALCLAG.transform.localScale;
			this.CFOLJLNGMFP.GetComponent<Camera>().CopyFrom(this.OMIJMALCLAG);
			this.CFOLJLNGMFP.GetComponent<Camera>().enabled = false;
			this.CFOLJLNGMFP.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.CFOLJLNGMFP.GetComponent<Camera>().clearFlags = CameraClearFlags.Nothing;
			return this.CFOLJLNGMFP.GetComponent<Camera>();
		}

		// Token: 0x0600B45E RID: 46174 RVA: 0x004F5E63 File Offset: 0x004F4063
		private void OnEnable()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B45F RID: 46175 RVA: 0x004F5E94 File Offset: 0x004F4094
		private void BHCMACAGNNH()
		{
			this.ELJIHKALJGN = this.ACMFIGCDMBD;
			this.GDFCFFGPMAM = base.transform.forward;
			this.GPODKOAAIGA = base.transform.up;
			this.GJMNAHPDKKO = base.transform.position;
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[1];
			this.CCDFEIHLHHI[1] = this.CCFLCHPKCIG[0];
		}

		// Token: 0x0600B460 RID: 46176 RVA: 0x004F5F10 File Offset: 0x004F4110
		public virtual bool DGLPHOKKFDC()
		{
			base.KGKLINAKDBE(false, true);
			this.JJGFBDBCGEE = base.IIIIADNBONI(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc)
			{
				this.LBBJOIEBPIN = base.BAPJBHPEDIF(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B461 RID: 46177 RVA: 0x004F5F7C File Offset: 0x004F417C
		private void CHBJLJGCBJD()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, false);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 1; i < 4; i++)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Right);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Right);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, true);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B462 RID: 46178 RVA: 0x004F6014 File Offset: 0x004F4214
		private void INDGOHJGCFN()
		{
			this.MNDOFMMGLMO();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[5];
			this.CCDFEIHLHHI = new Matrix4x4[1];
			this.DHEAJMJGJPF();
			this.CBPKFGJAMLF();
			this.GIFGDHDIELG = false;
		}

		// Token: 0x0600B463 RID: 46179 RVA: 0x004F6080 File Offset: 0x004F4280
		private void OCNAECBANNG(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.POGFCHFGJGF();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-31)) ? ((RenderTextureFormat)(-22)) : RenderTextureFormat.ARGB2101010;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.JFJDBJMKOGC(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.DHKGDLDHAJI(JONJODLFAEN.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(359f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType != CameraMotionBlur.FDPCLLEACAB.ReconstructionDX11 || this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)6 || flag || this.filterType == (CameraMotionBlur.FDPCLLEACAB)7)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.DLJBJHFNLJJ(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.LDLKJPGAJNJ(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.AKBMHFBHBNF(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.DLJBJHFNLJJ(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Bilinear;
			temporary3.filterMode = FilterMode.Bilinear;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Point;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			this.CHBJLJGCBJD();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.LPNEAHINHOF();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("", matrix4x);
			this.JJGFBDBCGEE.SetMatrix("", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("wpn_rod4", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[2];
				array[0] = Matrix4x4.Inverse(this.CCFLCHPKCIG[0]);
				array[0] = Matrix4x4.Inverse(this.CCFLCHPKCIG[0]);
				Matrix4x4 value2 = this.CCDFEIHLHHI[1] * array[1];
				this.JJGFBDBCGEE.SetMatrix("WalkInjured", value2);
				this.JJGFBDBCGEE.SetMatrix("ClimbUp", this.CCDFEIHLHHI[0] * array[0]);
			}
			this.JJGFBDBCGEE.SetFloat("_mesh", value);
			this.JJGFBDBCGEE.SetFloat("Применить", value);
			this.JJGFBDBCGEE.SetFloat("\n", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("SecondaryCausticsProjector", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("^(", this.jitter);
			this.JJGFBDBCGEE.SetTexture("Cells", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("kfB", temporary);
			this.JJGFBDBCGEE.SetTexture("_Blurred", temporary3);
			this.JJGFBDBCGEE.SetTexture("Roar", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 566f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix("reelspd", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("wpn_rod4", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 905f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1058f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1310f);
				zero.z = this.rotationScale * (1663f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 102f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 1958f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 92f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("BowInstant", new Vector4(this.previewScale.y, this.previewScale.x, 106f, this.previewScale.z) * 186f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("knopje.wav", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 0);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.OMPBJMEGAKL();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "WalkBackward");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.LPNEAHINHOF();
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("_Lift", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 0);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)5 && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("float: ", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("addpar", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("gi_inte_4", this.jitter);
				this.LBBJOIEBPIN.SetTexture("ROPE segments=", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("id", temporary);
				this.LBBJOIEBPIN.SetTexture("KneesIdle", temporary3);
				this.LBBJOIEBPIN.SetFloat("INTERFACE", Mathf.Max(1025f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("ShotgunReadyFire", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 0);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 1);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 5);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion || flag)
			{
				this.JJGFBDBCGEE.SetFloat("27,29,30,31,32", Mathf.Max(1254f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 7);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 5);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 0);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 2);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.JJGFBDBCGEE.SetFloat("wpn_add/base", Mathf.Max(206f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 4);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 8);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 6);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 4);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B464 RID: 46180 RVA: 0x004F6990 File Offset: 0x004F4B90
		private void FFMOALDGPNE()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, false);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 0; i < 4; i++)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Right);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, true);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B465 RID: 46181 RVA: 0x004F6A28 File Offset: 0x004F4C28
		private void LDLDNOOABCF()
		{
			this.ELJIHKALJGN = this.ACMFIGCDMBD;
			this.GDFCFFGPMAM = base.transform.forward;
			this.GPODKOAAIGA = base.transform.up;
			this.GJMNAHPDKKO = base.transform.position;
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[0];
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[0];
		}

		// Token: 0x0600B466 RID: 46182 RVA: 0x004F6AA4 File Offset: 0x004F4CA4
		private void BNOLDFLILJA()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B467 RID: 46183 RVA: 0x004F6B14 File Offset: 0x004F4D14
		public virtual bool HKEDGJELFGD()
		{
			base.CKPBGEFFMLO(true, true);
			this.JJGFBDBCGEE = base.IIIIADNBONI(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDX11)
			{
				this.LBBJOIEBPIN = base.OOAOHFFDMJP(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B468 RID: 46184 RVA: 0x004F6B80 File Offset: 0x004F4D80
		private void JPHBPEAMNHB()
		{
			this.DLENDGGGMBJ();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[5];
			this.CCDFEIHLHHI = new Matrix4x4[4];
			this.EABPEPPOHCA();
			this.LPNEAHINHOF();
			this.GIFGDHDIELG = false;
		}

		// Token: 0x0600B469 RID: 46185 RVA: 0x004F6BEC File Offset: 0x004F4DEC
		private Camera HHMJADDKHGH()
		{
			if (this.CFOLJLNGMFP == null)
			{
				string text = "FlyBackward" + this.OMIJMALCLAG.name + "WizardOverhead";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					string name = text;
					Type[] array = new Type[1];
					array[1] = typeof(Camera);
					this.CFOLJLNGMFP = new GameObject(name, array);
				}
				else
				{
					this.CFOLJLNGMFP = gameObject;
				}
			}
			this.CFOLJLNGMFP.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			this.CFOLJLNGMFP.transform.position = this.OMIJMALCLAG.transform.position;
			this.CFOLJLNGMFP.transform.rotation = this.OMIJMALCLAG.transform.rotation;
			this.CFOLJLNGMFP.transform.localScale = this.OMIJMALCLAG.transform.localScale;
			this.CFOLJLNGMFP.GetComponent<Camera>().CopyFrom(this.OMIJMALCLAG);
			this.CFOLJLNGMFP.GetComponent<Camera>().enabled = false;
			this.CFOLJLNGMFP.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.CFOLJLNGMFP.GetComponent<Camera>().clearFlags = (CameraClearFlags)7;
			return this.CFOLJLNGMFP.GetComponent<Camera>();
		}

		// Token: 0x0600B46A RID: 46186 RVA: 0x004F6D1C File Offset: 0x004F4F1C
		private void ACJNCDAHJDE()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B46B RID: 46187 RVA: 0x004F6D89 File Offset: 0x004F4F89
		private static int HGMGGBINPIM(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 1) / MBFGBDLOKFH;
		}

		// Token: 0x0600B46C RID: 46188 RVA: 0x004F6D94 File Offset: 0x004F4F94
		private new void Start()
		{
			this.CheckResources();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[2];
			this.CCDFEIHLHHI = new Matrix4x4[2];
			this.EABPEPPOHCA();
			this.FEONKLCAHCN();
			this.GIFGDHDIELG = false;
		}

		// Token: 0x0600B46D RID: 46189 RVA: 0x004F6DFE File Offset: 0x004F4FFE
		private void GBLKILHJNCG()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 167f);
		}

		// Token: 0x0600B46E RID: 46190 RVA: 0x004F6E24 File Offset: 0x004F5024
		public override bool NIFOFLEPKIB()
		{
			base.DAOKCAOFIGE(true, false);
			this.JJGFBDBCGEE = base.JBHLGBPJFEL(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == (CameraMotionBlur.FDPCLLEACAB)7)
			{
				this.LBBJOIEBPIN = base.IIIIADNBONI(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B46F RID: 46191 RVA: 0x004F6E90 File Offset: 0x004F5090
		private void MINHPIONICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.ODGEBNGBEDN();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-66)) ? ((RenderTextureFormat)108) : RenderTextureFormat.Default;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.CEMBCHLHNIL(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.NMMKBBMKBMP(JONJODLFAEN.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(1968f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc && this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)8 || flag || this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.LDLKJPGAJNJ(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.DHKGDLDHAJI(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.AKBMHFBHBNF(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.LHANICIILJF(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Bilinear;
			temporary2.filterMode = FilterMode.Bilinear;
			temporary3.filterMode = FilterMode.Bilinear;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Bilinear;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Repeat;
			this.FFMOALDGPNE();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.KBBKBGFDGLG();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("LUM_CONTRIB_ON", matrix4x);
			this.JJGFBDBCGEE.SetMatrix(")", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("ECHO ON ", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[3];
				array[1] = Matrix4x4.Inverse(this.CCFLCHPKCIG[0]);
				array[0] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				Matrix4x4 value2 = this.CCDFEIHLHHI[0] * array[0];
				this.JJGFBDBCGEE.SetMatrix("<color=green>$&</color>", value2);
				this.JJGFBDBCGEE.SetMatrix("text", this.CCDFEIHLHHI[0] * array[1]);
			}
			this.JJGFBDBCGEE.SetFloat("_BlurCoe", value);
			this.JJGFBDBCGEE.SetFloat("gi_fridgice", value);
			this.JJGFBDBCGEE.SetFloat("endPointNonBend", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("Giant2HandSlamIdle", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("/", this.jitter);
			this.JJGFBDBCGEE.SetTexture("WalkBackward", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("isWoman", temporary);
			this.JJGFBDBCGEE.SetTexture("_BoobMap", temporary3);
			this.JJGFBDBCGEE.SetTexture("", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 1302f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix("pempty=0", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("Jump", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 628f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1012f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 167f);
				zero.z = this.rotationScale * (155f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 256f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 242f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 1886f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("white", new Vector4(this.previewScale.y, this.previewScale.x, 768f, this.previewScale.z) * 1848f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("SUNSHINE_TWO_CASCADES", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 0);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.PMGIJAMNFCC();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "_NeutralTonemapperParams1");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.EJHMKCIEOKK();
			}
			JONJODLFAEN.filterMode = FilterMode.Point;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("Wrist", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)7 && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("Materials/DFMLambertSolidColor", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("Cowboy1HandDraw", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("InterfaceLang.txt", this.jitter);
				this.LBBJOIEBPIN.SetTexture("_FogBaseHeight", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("MotorbikeHeartAttack", temporary);
				this.LBBJOIEBPIN.SetTexture("auc_wcswcp", temporary3);
				this.LBBJOIEBPIN.SetFloat("WorkerPickaxe", Mathf.Max(1626f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("_1.png", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 0);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 0);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 3);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)7 || flag)
			{
				this.JJGFBDBCGEE.SetFloat("", Mathf.Max(214f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 2);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 4);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 7);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.Reconstruction)
			{
				this.JJGFBDBCGEE.SetFloat("37,38,39,40", Mathf.Max(951f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 0);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 8);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 8);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 0);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B470 RID: 46192 RVA: 0x004F779D File Offset: 0x004F599D
		private void IMEIOFGKMDK()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B471 RID: 46193 RVA: 0x004F77CC File Offset: 0x004F59CC
		private void EFPADLBDKCC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.POGFCHFGJGF();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-21)) ? ((RenderTextureFormat)112) : RenderTextureFormat.Depth;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.HGMGGBINPIM(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.LDLKJPGAJNJ(JONJODLFAEN.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(637f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType == (CameraMotionBlur.FDPCLLEACAB)7 && this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)8 || flag || this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.CEMBCHLHNIL(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.DLJBJHFNLJJ(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.LDLKJPGAJNJ(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.CEMBCHLHNIL(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Bilinear;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Bilinear;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Repeat;
			temporary2.wrapMode = TextureWrapMode.Repeat;
			this.DHEAJMJGJPF();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.FEONKLCAHCN();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("Wood Cut", matrix4x);
			this.JJGFBDBCGEE.SetMatrix(".png", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[]
				{
					default(Matrix4x4),
					Matrix4x4.Inverse(this.CCFLCHPKCIG[0])
				};
				array[1] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				Matrix4x4 value2 = this.CCDFEIHLHHI[0] * array[1];
				this.JJGFBDBCGEE.SetMatrix("StaffHeal", value2);
				this.JJGFBDBCGEE.SetMatrix("_SpecCubeIBL", this.CCDFEIHLHHI[0] * array[1]);
			}
			this.JJGFBDBCGEE.SetFloat(" ", value);
			this.JJGFBDBCGEE.SetFloat("gi_sadok", value);
			this.JJGFBDBCGEE.SetFloat("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_quadruped.html", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("UIChat_fontInterval", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("Water", this.jitter);
			this.JJGFBDBCGEE.SetTexture(": ", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("---", temporary);
			this.JJGFBDBCGEE.SetTexture("Cowboy1HandDraw", temporary3);
			this.JJGFBDBCGEE.SetTexture("no_change", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 250f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, false);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix("https://groups.google.com/forum/#!forum/final-ik", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("GiantGrabThrow", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1845f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 885f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 265f);
				zero.z = this.rotationScale * (1415f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 752f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 577f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 722f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("**********  158 pointid=", new Vector4(this.previewScale.y, this.previewScale.x, 672f, this.previewScale.z) * 191f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("Walk Backward", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 1);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.IINPBAOFKLO();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "Move around with WASD or cursor keys, space to jump, F key to change fog style, T to toggle fog on/off.");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.LPNEAHINHOF();
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("BowFire", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 0);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)7 && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("type_", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("wpn_cmp", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("i shrank because the inputfield was this big", this.jitter);
				this.LBBJOIEBPIN.SetTexture("flowfrc", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("repair.ogg", temporary);
				this.LBBJOIEBPIN.SetTexture("Arm Flex 2", temporary3);
				this.LBBJOIEBPIN.SetFloat("</color>", Mathf.Max(370f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("WeaponInstant", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 1);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 1);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 8);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc || flag)
			{
				this.JJGFBDBCGEE.SetFloat("demoByteArray", Mathf.Max(1919f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 3);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 0);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 8);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 6);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)5)
			{
				this.JJGFBDBCGEE.SetFloat("_TintColor", Mathf.Max(1346f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 7);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 3);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 7);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B472 RID: 46194 RVA: 0x004F80DC File Offset: 0x004F62DC
		private void PNEFMGMHLJE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.CINEBKGHEHG();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-108)) ? ((RenderTextureFormat)113) : RenderTextureFormat.ARGBHalf;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.DHKGDLDHAJI(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.OBGOLDEPOJP(JONJODLFAEN.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(1940f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType != CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc || this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)5 || flag || this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.CEMBCHLHNIL(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.LHANICIILJF(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.AKBMHFBHBNF(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.AKBMHFBHBNF(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 1, format);
			temporary.filterMode = FilterMode.Bilinear;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Bilinear;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Bilinear;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Repeat;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			this.HBIOBBCPPIJ();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.KBBKBGFDGLG();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("Staff Attack", matrix4x);
			this.JJGFBDBCGEE.SetMatrix("ProneIdle", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("Mouse X", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[0];
				array[1] = Matrix4x4.Inverse(this.CCFLCHPKCIG[0]);
				array[1] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				Matrix4x4 value2 = this.CCDFEIHLHHI[0] * array[0];
				this.JJGFBDBCGEE.SetMatrix("MotorbikeTurnRight", value2);
				this.JJGFBDBCGEE.SetMatrix("IKMappingLimb contains a null reference.", this.CCDFEIHLHHI[1] * array[1]);
			}
			this.JJGFBDBCGEE.SetFloat("ClimbRight", value);
			this.JJGFBDBCGEE.SetFloat("Turn", value);
			this.JJGFBDBCGEE.SetFloat("-", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("<color=\"", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("SoccerTackle", this.jitter);
			this.JJGFBDBCGEE.SetTexture("[minwgt]", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("ENABLE_USER_LUT", temporary);
			this.JJGFBDBCGEE.SetTexture("", temporary3);
			this.JJGFBDBCGEE.SetTexture("", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 1521f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, false);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix("_FgOverlap", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("Clear reference not set.", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 349f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1226f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1504f);
				zero.z = this.rotationScale * (688f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 947f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 1034f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 1989f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("OfficeSittingReadingCoffeeSip", new Vector4(this.previewScale.y, this.previewScale.x, 382f, this.previewScale.z) * 302f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("[ProBuilder Attachments] Please disable the following option in the Unity preferences:", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 0);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.IINPBAOFKLO();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "Sexy Dance");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.LDLDNOOABCF();
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("Fog Areas should be created on runtime.", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.LocalBlur && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("</color>\n", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("_SampleMip", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("Reveling", this.jitter);
				this.LBBJOIEBPIN.SetTexture("KatanaReady", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture(" This is not possible to be called for standalone input. Please check your platform and code where this is called", temporary);
				this.LBBJOIEBPIN.SetTexture("CrouchStrafeLeft", temporary3);
				this.LBBJOIEBPIN.SetFloat("", Mathf.Max(1480f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("_Radius", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 0);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 1);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 6);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)8 || flag)
			{
				this.JJGFBDBCGEE.SetFloat("[^a-zA-z\\d_]", Mathf.Max(219f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 7);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 3);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 4);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 4);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.Reconstruction)
			{
				this.JJGFBDBCGEE.SetFloat("_Power", Mathf.Max(807f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 1);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 5);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 6);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B473 RID: 46195 RVA: 0x004F779D File Offset: 0x004F599D
		private void CCMOKEDKMNJ()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B474 RID: 46196 RVA: 0x004F89EC File Offset: 0x004F6BEC
		private void HBIOBBCPPIJ()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, false);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 1; i < 3; i++)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Left);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Right);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, false);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B475 RID: 46197 RVA: 0x004F8A82 File Offset: 0x004F6C82
		private void ABJPDGENFBL()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 883f);
		}

		// Token: 0x0600B476 RID: 46198 RVA: 0x004F8AA8 File Offset: 0x004F6CA8
		private Camera OMPBJMEGAKL()
		{
			if (this.CFOLJLNGMFP == null)
			{
				string text = "Cloth_05_00.wav" + this.OMIJMALCLAG.name + "";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					string name = text;
					Type[] array = new Type[0];
					array[0] = typeof(Camera);
					this.CFOLJLNGMFP = new GameObject(name, array);
				}
				else
				{
					this.CFOLJLNGMFP = gameObject;
				}
			}
			this.CFOLJLNGMFP.hideFlags = (HideFlags)(-122);
			this.CFOLJLNGMFP.transform.position = this.OMIJMALCLAG.transform.position;
			this.CFOLJLNGMFP.transform.rotation = this.OMIJMALCLAG.transform.rotation;
			this.CFOLJLNGMFP.transform.localScale = this.OMIJMALCLAG.transform.localScale;
			this.CFOLJLNGMFP.GetComponent<Camera>().CopyFrom(this.OMIJMALCLAG);
			this.CFOLJLNGMFP.GetComponent<Camera>().enabled = false;
			this.CFOLJLNGMFP.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.CFOLJLNGMFP.GetComponent<Camera>().clearFlags = (CameraClearFlags)7;
			return this.CFOLJLNGMFP.GetComponent<Camera>();
		}

		// Token: 0x0600B477 RID: 46199 RVA: 0x004F6D89 File Offset: 0x004F4F89
		private static int JFJDBJMKOGC(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 1) / MBFGBDLOKFH;
		}

		// Token: 0x0600B478 RID: 46200 RVA: 0x004F8BD8 File Offset: 0x004F6DD8
		private void OILPEJCKAKJ()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B479 RID: 46201 RVA: 0x004F8C48 File Offset: 0x004F6E48
		public virtual bool LNHMJPEKJPH()
		{
			base.AEGGCHNBPOD(false, false);
			this.JJGFBDBCGEE = base.ALJPMGLOIEG(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == CameraMotionBlur.FDPCLLEACAB.Reconstruction)
			{
				this.LBBJOIEBPIN = base.BAPJBHPEDIF(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B47A RID: 46202 RVA: 0x004F8CB4 File Offset: 0x004F6EB4
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(true, true);
			this.JJGFBDBCGEE = base.DJFOEIJIMJB(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDX11)
			{
				this.LBBJOIEBPIN = base.DJFOEIJIMJB(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B47B RID: 46203 RVA: 0x004F8D1F File Offset: 0x004F6F1F
		private void POGFCHFGJGF()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 0.75f);
		}

		// Token: 0x0600B47C RID: 46204 RVA: 0x004F8D42 File Offset: 0x004F6F42
		private static int LDLKJPGAJNJ(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 0) / MBFGBDLOKFH;
		}

		// Token: 0x0600B47D RID: 46205 RVA: 0x004F5E63 File Offset: 0x004F4063
		private void ECHEPDJBGLP()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B47E RID: 46206 RVA: 0x004F8D4C File Offset: 0x004F6F4C
		private void HNPNJCMJKKK(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.PKHJBLJFIBF())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.CIKLBNDDNIJ();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-3)) ? ((RenderTextureFormat)(-31)) : RenderTextureFormat.ARGB32;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.AKBMHFBHBNF(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.OBGOLDEPOJP(JONJODLFAEN.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(93f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType != CameraMotionBlur.FDPCLLEACAB.LocalBlur || this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)5 || flag || this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.CEMBCHLHNIL(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.LHANICIILJF(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.CEMBCHLHNIL(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.LDLKJPGAJNJ(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Bilinear;
			temporary3.filterMode = FilterMode.Point;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Point;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary3.wrapMode = TextureWrapMode.Repeat;
			temporary2.wrapMode = TextureWrapMode.Repeat;
			this.JCFAOKCHAEK();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.LPNEAHINHOF();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("OfficeSittingEyesRub", matrix4x);
			this.JJGFBDBCGEE.SetMatrix("WeaponReadyFire", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("human_move_2.wav", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[2];
				array[0] = Matrix4x4.Inverse(this.CCFLCHPKCIG[0]);
				array[0] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				Matrix4x4 value2 = this.CCDFEIHLHHI[0] * array[0];
				this.JJGFBDBCGEE.SetMatrix("titul_data/tituls/titul", value2);
				this.JJGFBDBCGEE.SetMatrix("__MirrorDeep", this.CCDFEIHLHHI[1] * array[0]);
			}
			this.JJGFBDBCGEE.SetFloat("crft_none", value);
			this.JJGFBDBCGEE.SetFloat("WireframeFore", value);
			this.JJGFBDBCGEE.SetFloat("wpn_add/base", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("SecondaryCausticsProjector", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("delaccconfirm", this.jitter);
			this.JJGFBDBCGEE.SetTexture("_Texture", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("IdleStand", temporary);
			this.JJGFBDBCGEE.SetTexture("MotorbikeShootFwd", temporary3);
			this.JJGFBDBCGEE.SetTexture("Reset", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 570f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix(" cm", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("rait_3", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1978f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1645f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1507f);
				zero.z = this.rotationScale * (1611f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 1279f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 971f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 678f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("{0:f2}", new Vector4(this.previewScale.y, this.previewScale.x, 1582f, this.previewScale.z) * 319f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("Demo 1 scene: windy mist fog style. Notice the subtle fog animation. To change look, select Main Camera and check image effect settings in inspector.", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 1);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.LLEDFABKFEL();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "{not_found}");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.IGCLAAMONAI();
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("Wand Attack 2", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)5 && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("Ring", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("invn_rec10", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("qd_taskcount", this.jitter);
				this.LBBJOIEBPIN.SetTexture("_AllowBackwardsRays", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("-H", temporary);
				this.LBBJOIEBPIN.SetTexture("onDisconnect PROCEDURE", temporary3);
				this.LBBJOIEBPIN.SetFloat("cht_msg37", Mathf.Max(1130f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("gi_nl4", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 1);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 1);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 2);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.Reconstruction || flag)
			{
				this.JJGFBDBCGEE.SetFloat("*** updateDetailWpnInfo  ", Mathf.Max(962f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 6);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 6);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 5);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 5);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDX11)
			{
				this.JJGFBDBCGEE.SetFloat("cht_maxcnt", Mathf.Max(733f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 4);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 8);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 7);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B47F RID: 46207 RVA: 0x004F965C File Offset: 0x004F785C
		public virtual bool PNMIMCJGPGL()
		{
			base.DPGMAIGIFNO(false, false);
			this.JJGFBDBCGEE = base.ALJPMGLOIEG(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == (CameraMotionBlur.FDPCLLEACAB)6)
			{
				this.LBBJOIEBPIN = base.BAPJBHPEDIF(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B480 RID: 46208 RVA: 0x004F96C8 File Offset: 0x004F78C8
		private void CBPKFGJAMLF()
		{
			this.ELJIHKALJGN = this.ACMFIGCDMBD;
			this.GDFCFFGPMAM = base.transform.forward;
			this.GPODKOAAIGA = base.transform.up;
			this.GJMNAHPDKKO = base.transform.position;
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[0];
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[0];
		}

		// Token: 0x0600B481 RID: 46209 RVA: 0x004F5E63 File Offset: 0x004F4063
		private void DKGAOLLKDPD()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B482 RID: 46210 RVA: 0x004F9744 File Offset: 0x004F7944
		private void NPAELBEDLPB()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 0; i < 4; i += 0)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Right);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, true);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B483 RID: 46211 RVA: 0x004F97DA File Offset: 0x004F79DA
		private void CINEBKGHEHG()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 1298f);
		}

		// Token: 0x0600B484 RID: 46212 RVA: 0x004F9800 File Offset: 0x004F7A00
		private void GGIKBEHBAPB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.AOJEAPEGJGF();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)126) ? ((RenderTextureFormat)(-99)) : RenderTextureFormat.Depth;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.JFJDBJMKOGC(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.DHKGDLDHAJI(JONJODLFAEN.height, this.velocityDownsample), 1, format);
			this.maxVelocity = Mathf.Max(1400f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType != CameraMotionBlur.FDPCLLEACAB.ReconstructionDX11 || this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)7 || flag || this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.LHANICIILJF(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.HGMGGBINPIM(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.AKBMHFBHBNF(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.DLJBJHFNLJJ(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Bilinear;
			temporary2.filterMode = FilterMode.Bilinear;
			temporary3.filterMode = FilterMode.Bilinear;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Bilinear;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Repeat;
			temporary2.wrapMode = TextureWrapMode.Repeat;
			this.FJHAPNODNPL();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.ACIBBEBBNBN();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("G", matrix4x);
			this.JJGFBDBCGEE.SetMatrix("", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("MotorbikeWheely", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[]
				{
					Matrix4x4.Inverse(this.CCFLCHPKCIG[0]),
					Matrix4x4.Inverse(this.CCFLCHPKCIG[1])
				};
				Matrix4x4 value2 = this.CCDFEIHLHHI[0] * array[0];
				this.JJGFBDBCGEE.SetMatrix(")", value2);
				this.JJGFBDBCGEE.SetMatrix("Mouse X", this.CCDFEIHLHHI[1] * array[1]);
			}
			this.JJGFBDBCGEE.SetFloat("#2080ff", value);
			this.JJGFBDBCGEE.SetFloat("1024", value);
			this.JJGFBDBCGEE.SetFloat("demoLong", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("MotorbikeSeatStandWheely", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("maps.txt", this.jitter);
			this.JJGFBDBCGEE.SetTexture("_info", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("", temporary);
			this.JJGFBDBCGEE.SetTexture("Channel Cast Directed", temporary3);
			this.JJGFBDBCGEE.SetTexture("#400000", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 1485f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix("", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("|", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 182f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1816f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 28f);
				zero.z = this.rotationScale * (907f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 1259f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 1060f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 181f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("минута", new Vector4(this.previewScale.y, this.previewScale.x, 1752f, this.previewScale.z) * 1225f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("<color='#300030'>{0}</color>", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 1);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.PMGIJAMNFCC();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "Gesture Wonderful");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.IGCLAAMONAI();
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("CratePull", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 0);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)5 && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("TOD_MoonMeshContrast", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("WoodSaw", this.jitter);
				this.LBBJOIEBPIN.SetTexture("wpn_bait_sz", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("Failed parsing atlas rect.  Using default.", temporary);
				this.LBBJOIEBPIN.SetTexture("_FresnelFadePower", temporary3);
				this.LBBJOIEBPIN.SetFloat("StaffAttack", Mathf.Max(404f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("cht_msg13", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 1);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 1);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 1);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc || flag)
			{
				this.JJGFBDBCGEE.SetFloat("\n", Mathf.Max(1709f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 0);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 2);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 5);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 5);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc)
			{
				this.JJGFBDBCGEE.SetFloat("<color='#200080'>", Mathf.Max(279f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 0);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 5);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 8);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 0);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B485 RID: 46213 RVA: 0x004F779D File Offset: 0x004F599D
		private void EKOENFCHNKL()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B486 RID: 46214 RVA: 0x004FA110 File Offset: 0x004F8310
		private void LHANIDMDNIK()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B487 RID: 46215 RVA: 0x004FA180 File Offset: 0x004F8380
		private void MLPCBOGCEEO()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B488 RID: 46216 RVA: 0x004F779D File Offset: 0x004F599D
		private void MEJAMIFNCGO()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B489 RID: 46217 RVA: 0x004FA1F0 File Offset: 0x004F83F0
		private void IMABGALEMBI()
		{
			this.CheckResources();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[4];
			this.CCDFEIHLHHI = new Matrix4x4[7];
			this.NPAELBEDLPB();
			this.KBBKBGFDGLG();
			this.GIFGDHDIELG = true;
		}

		// Token: 0x0600B48A RID: 46218 RVA: 0x004F6D89 File Offset: 0x004F4F89
		private static int CEMBCHLHNIL(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 1) / MBFGBDLOKFH;
		}

		// Token: 0x0600B48B RID: 46219 RVA: 0x004FA25C File Offset: 0x004F845C
		private void NCBLFNKNEDK()
		{
			this.CheckResources();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[0];
			this.CCDFEIHLHHI = new Matrix4x4[7];
			this.CHBJLJGCBJD();
			this.LPNEAHINHOF();
			this.GIFGDHDIELG = true;
		}

		// Token: 0x0600B48C RID: 46220 RVA: 0x004FA2C8 File Offset: 0x004F84C8
		private void JGHJOBDKDKM()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B48D RID: 46221 RVA: 0x004FA338 File Offset: 0x004F8538
		private void KJAGMEIKNDK()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 0; i < 0; i++)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Left);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, false);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B48E RID: 46222 RVA: 0x004FA3D0 File Offset: 0x004F85D0
		private void JLKBMEBFHBI()
		{
			this.BOFHDNBNAOA();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[7];
			this.CCDFEIHLHHI = new Matrix4x4[2];
			this.BFAMDMLHAIF();
			this.FEONKLCAHCN();
			this.GIFGDHDIELG = true;
		}

		// Token: 0x0600B48F RID: 46223 RVA: 0x004FA43C File Offset: 0x004F863C
		private void EJHMKCIEOKK()
		{
			this.ELJIHKALJGN = this.ACMFIGCDMBD;
			this.GDFCFFGPMAM = base.transform.forward;
			this.GPODKOAAIGA = base.transform.up;
			this.GJMNAHPDKKO = base.transform.position;
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[1];
			this.CCDFEIHLHHI[1] = this.CCFLCHPKCIG[0];
		}

		// Token: 0x0600B490 RID: 46224 RVA: 0x004F6D89 File Offset: 0x004F4F89
		private static int OBGOLDEPOJP(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 1) / MBFGBDLOKFH;
		}

		// Token: 0x0600B491 RID: 46225 RVA: 0x004FA4B8 File Offset: 0x004F86B8
		private void HKMHOFMNILD()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 633f);
		}

		// Token: 0x0600B492 RID: 46226 RVA: 0x004F8D42 File Offset: 0x004F6F42
		private static int DLJBJHFNLJJ(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 0) / MBFGBDLOKFH;
		}

		// Token: 0x0600B493 RID: 46227 RVA: 0x004FA4DC File Offset: 0x004F86DC
		private void LMEJKAEIDCO()
		{
			this.GGJKGIHGMGC();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[5];
			this.CCDFEIHLHHI = new Matrix4x4[5];
			this.FJHAPNODNPL();
			this.ACIBBEBBNBN();
			this.GIFGDHDIELG = true;
		}

		// Token: 0x0600B494 RID: 46228 RVA: 0x004F5E63 File Offset: 0x004F4063
		private void DHFLFGBENBF()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B495 RID: 46229 RVA: 0x004FA548 File Offset: 0x004F8748
		private void AEBGLHDGEMK()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, false);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 0; i < 3; i += 0)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Right);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, false);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B496 RID: 46230 RVA: 0x004FA5E0 File Offset: 0x004F87E0
		private Camera DJHKMKFNBMK()
		{
			if (this.CFOLJLNGMFP == null)
			{
				string name = "Water Refl Camera id" + this.OMIJMALCLAG.name + "Vertical";
				GameObject gameObject = GameObject.Find(name);
				if (null == gameObject)
				{
					this.CFOLJLNGMFP = new GameObject(name, new Type[]
					{
						typeof(Camera)
					});
				}
				else
				{
					this.CFOLJLNGMFP = gameObject;
				}
			}
			this.CFOLJLNGMFP.hideFlags = (HideFlags)106;
			this.CFOLJLNGMFP.transform.position = this.OMIJMALCLAG.transform.position;
			this.CFOLJLNGMFP.transform.rotation = this.OMIJMALCLAG.transform.rotation;
			this.CFOLJLNGMFP.transform.localScale = this.OMIJMALCLAG.transform.localScale;
			this.CFOLJLNGMFP.GetComponent<Camera>().CopyFrom(this.OMIJMALCLAG);
			this.CFOLJLNGMFP.GetComponent<Camera>().enabled = false;
			this.CFOLJLNGMFP.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.CFOLJLNGMFP.GetComponent<Camera>().clearFlags = (CameraClearFlags)8;
			return this.CFOLJLNGMFP.GetComponent<Camera>();
		}

		// Token: 0x0600B497 RID: 46231 RVA: 0x004FA710 File Offset: 0x004F8910
		private Camera FPNCMPOKACO()
		{
			if (this.CFOLJLNGMFP == null)
			{
				string text = "IceHockeyGoalieSave2" + this.OMIJMALCLAG.name + "_Refraction";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					string name = text;
					Type[] array = new Type[0];
					array[1] = typeof(Camera);
					this.CFOLJLNGMFP = new GameObject(name, array);
				}
				else
				{
					this.CFOLJLNGMFP = gameObject;
				}
			}
			this.CFOLJLNGMFP.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			this.CFOLJLNGMFP.transform.position = this.OMIJMALCLAG.transform.position;
			this.CFOLJLNGMFP.transform.rotation = this.OMIJMALCLAG.transform.rotation;
			this.CFOLJLNGMFP.transform.localScale = this.OMIJMALCLAG.transform.localScale;
			this.CFOLJLNGMFP.GetComponent<Camera>().CopyFrom(this.OMIJMALCLAG);
			this.CFOLJLNGMFP.GetComponent<Camera>().enabled = true;
			this.CFOLJLNGMFP.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.CFOLJLNGMFP.GetComponent<Camera>().clearFlags = CameraClearFlags.Color;
			return this.CFOLJLNGMFP.GetComponent<Camera>();
		}

		// Token: 0x0600B498 RID: 46232 RVA: 0x004FA840 File Offset: 0x004F8A40
		private void IOPEDDLLPPL()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B499 RID: 46233 RVA: 0x004FA8B0 File Offset: 0x004F8AB0
		private void KBBKBGFDGLG()
		{
			this.ELJIHKALJGN = this.ACMFIGCDMBD;
			this.GDFCFFGPMAM = base.transform.forward;
			this.GPODKOAAIGA = base.transform.up;
			this.GJMNAHPDKKO = base.transform.position;
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[0];
			this.CCDFEIHLHHI[1] = this.CCFLCHPKCIG[0];
		}

		// Token: 0x0600B49A RID: 46234 RVA: 0x004FA92C File Offset: 0x004F8B2C
		private void PPAAMEAPADE(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.AOJEAPEGJGF();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-46)) ? RenderTextureFormat.ARGB1555 : RenderTextureFormat.RGB565;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.JFJDBJMKOGC(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.AKBMHFBHBNF(JONJODLFAEN.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(419f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc && this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.Reconstruction || flag || this.filterType == (CameraMotionBlur.FDPCLLEACAB)5)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.DKOPGLKEOPN(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.LDLKJPGAJNJ(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.JFJDBJMKOGC(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.LDLKJPGAJNJ(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 1, format);
			temporary.filterMode = FilterMode.Bilinear;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Point;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Bilinear;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Repeat;
			temporary2.wrapMode = TextureWrapMode.Repeat;
			this.NPAELBEDLPB();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.LPNEAHINHOF();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("Swim", matrix4x);
			this.JJGFBDBCGEE.SetMatrix("SAMPLES_LOW", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("KneesIdle", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[7];
				array[1] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				array[1] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				Matrix4x4 value2 = this.CCDFEIHLHHI[0] * array[1];
				this.JJGFBDBCGEE.SetMatrix("Hidden/ScreenSpaceReflection", value2);
				this.JJGFBDBCGEE.SetMatrix("Overlay Mesh: ", this.CCDFEIHLHHI[1] * array[0]);
			}
			this.JJGFBDBCGEE.SetFloat("OfficeSittingMouseMovement", value);
			this.JJGFBDBCGEE.SetFloat("1 Hand Sword Jab", value);
			this.JJGFBDBCGEE.SetFloat("MotorbikeShootRight", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("AssetLoaderCoroutine", this.jitter);
			this.JJGFBDBCGEE.SetTexture("ChannelCastDirected", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("Warning: no main camera found. Third person character needs a Camera tagged \"MainCamera\", for camera-relative controls.", temporary);
			this.JJGFBDBCGEE.SetTexture("_DelItem.wav", temporary3);
			this.JJGFBDBCGEE.SetTexture("_BlurTexture", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 1297f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, false);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix("_HitTime", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("HookPoint", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1665f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 286f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 669f);
				zero.z = this.rotationScale * (1216f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 380f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 879f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 194f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("WandStand", new Vector4(this.previewScale.y, this.previewScale.x, 800f, this.previewScale.z) * 452f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("1HandSmallWeaponCombo", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 1);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.DJHKMKFNBMK();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "_Params1");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.BHCMACAGNNH();
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("_Curve", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)6 && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("wpn_add/base", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("bool:", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("_camScale", this.jitter);
				this.LBBJOIEBPIN.SetTexture("Hidden/Post FX/Motion Blur", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("SwimDogPaddle", temporary);
				this.LBBJOIEBPIN.SetTexture("_TintColor", temporary3);
				this.LBBJOIEBPIN.SetFloat("Flap_02.wav", Mathf.Max(1724f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 0);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 1);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 3);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc || flag)
			{
				this.JJGFBDBCGEE.SetFloat("MENU.WAV", Mathf.Max(1244f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 3);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 7);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 0);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.Reconstruction)
			{
				this.JJGFBDBCGEE.SetFloat("GiantGrabIdle", Mathf.Max(1442f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 1);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 0);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 0);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 6);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B49B RID: 46235 RVA: 0x004FB23C File Offset: 0x004F943C
		private Camera LLEDFABKFEL()
		{
			if (this.CFOLJLNGMFP == null)
			{
				string text = "choldposx" + this.OMIJMALCLAG.name + "VIGNETTE_CLASSIC";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					string name = text;
					Type[] array = new Type[1];
					array[1] = typeof(Camera);
					this.CFOLJLNGMFP = new GameObject(name, array);
				}
				else
				{
					this.CFOLJLNGMFP = gameObject;
				}
			}
			this.CFOLJLNGMFP.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			this.CFOLJLNGMFP.transform.position = this.OMIJMALCLAG.transform.position;
			this.CFOLJLNGMFP.transform.rotation = this.OMIJMALCLAG.transform.rotation;
			this.CFOLJLNGMFP.transform.localScale = this.OMIJMALCLAG.transform.localScale;
			this.CFOLJLNGMFP.GetComponent<Camera>().CopyFrom(this.OMIJMALCLAG);
			this.CFOLJLNGMFP.GetComponent<Camera>().enabled = false;
			this.CFOLJLNGMFP.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.CFOLJLNGMFP.GetComponent<Camera>().clearFlags = (CameraClearFlags)8;
			return this.CFOLJLNGMFP.GetComponent<Camera>();
		}

		// Token: 0x0600B49C RID: 46236 RVA: 0x004FB36C File Offset: 0x004F956C
		private void ACIBBEBBNBN()
		{
			this.ELJIHKALJGN = this.ACMFIGCDMBD;
			this.GDFCFFGPMAM = base.transform.forward;
			this.GPODKOAAIGA = base.transform.up;
			this.GJMNAHPDKKO = base.transform.position;
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[0];
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[0];
		}

		// Token: 0x0600B49D RID: 46237 RVA: 0x004FB3E8 File Offset: 0x004F95E8
		public virtual bool JOAPNOCFFBG()
		{
			base.LKBABPADBGG(true, false);
			this.JJGFBDBCGEE = base.ALJPMGLOIEG(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == (CameraMotionBlur.FDPCLLEACAB)5)
			{
				this.LBBJOIEBPIN = base.OOAOHFFDMJP(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B49E RID: 46238 RVA: 0x004FB454 File Offset: 0x004F9654
		private Camera PMCLHJLADGF()
		{
			if (this.CFOLJLNGMFP == null)
			{
				string text = "Antares" + this.OMIJMALCLAG.name + "medium";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					string name = text;
					Type[] array = new Type[0];
					array[1] = typeof(Camera);
					this.CFOLJLNGMFP = new GameObject(name, array);
				}
				else
				{
					this.CFOLJLNGMFP = gameObject;
				}
			}
			this.CFOLJLNGMFP.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			this.CFOLJLNGMFP.transform.position = this.OMIJMALCLAG.transform.position;
			this.CFOLJLNGMFP.transform.rotation = this.OMIJMALCLAG.transform.rotation;
			this.CFOLJLNGMFP.transform.localScale = this.OMIJMALCLAG.transform.localScale;
			this.CFOLJLNGMFP.GetComponent<Camera>().CopyFrom(this.OMIJMALCLAG);
			this.CFOLJLNGMFP.GetComponent<Camera>().enabled = true;
			this.CFOLJLNGMFP.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.CFOLJLNGMFP.GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
			return this.CFOLJLNGMFP.GetComponent<Camera>();
		}

		// Token: 0x0600B49F RID: 46239 RVA: 0x004FB584 File Offset: 0x004F9784
		private void MGOBAHLJJNL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.IKJGEPJOKLA();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-35)) ? ((RenderTextureFormat)(-54)) : RenderTextureFormat.ARGB1555;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.DKOPGLKEOPN(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.MBAJKNHMLFA(JONJODLFAEN.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(727f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType != CameraMotionBlur.FDPCLLEACAB.LocalBlur || this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)6 || flag || this.filterType == (CameraMotionBlur.FDPCLLEACAB)7)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.HGMGGBINPIM(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.DKOPGLKEOPN(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.LHANICIILJF(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.HGMGGBINPIM(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Bilinear;
			temporary3.filterMode = FilterMode.Bilinear;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Point;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Repeat;
			this.CKIMMGJJHMO();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.LDLDNOOABCF();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("FlyForward", matrix4x);
			this.JJGFBDBCGEE.SetMatrix("TOD_SunMeshContrast", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("Ignore Raycast", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[2];
				array[0] = Matrix4x4.Inverse(this.CCFLCHPKCIG[0]);
				array[0] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				Matrix4x4 value2 = this.CCDFEIHLHHI[1] * array[0];
				this.JJGFBDBCGEE.SetMatrix("AUTO_KEY_VALUE", value2);
				this.JJGFBDBCGEE.SetMatrix("IdleCheer", this.CCDFEIHLHHI[1] * array[1]);
			}
			this.JJGFBDBCGEE.SetFloat("#FF4040", value);
			this.JJGFBDBCGEE.SetFloat("ApplePick", value);
			this.JJGFBDBCGEE.SetFloat("Kernel", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("act_prof_{0}", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("Node transform is null in FBIK chain.", this.jitter);
			this.JJGFBDBCGEE.SetTexture("ok", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("Hidden/Post FX/Grain Generator", temporary);
			this.JJGFBDBCGEE.SetTexture("_TextureSize", temporary3);
			this.JJGFBDBCGEE.SetTexture("CratePull", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 875f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, false);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix("", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("ZombieIdle2", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1400f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1633f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1360f);
				zero.z = this.rotationScale * (402f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 706f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 546f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 359f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("t_eye", new Vector4(this.previewScale.y, this.previewScale.x, 678f, this.previewScale.z) * 1874f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("cht_msg34", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 1);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.OMPBJMEGAKL();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "Loading ");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.EJHMKCIEOKK();
			}
			JONJODLFAEN.filterMode = FilterMode.Point;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("MidBlendLut", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)8 && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("SUNSHINE_FILTER_PCF_3x3", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("aukTree", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("error", this.jitter);
				this.LBBJOIEBPIN.SetTexture("offsets", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("0", temporary);
				this.LBBJOIEBPIN.SetTexture("_TapLowForeground", temporary3);
				this.LBBJOIEBPIN.SetFloat("PistolFire", Mathf.Max(1437f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("Invalid ObscuredVector2 index!", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 0);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 1);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 1);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc || flag)
			{
				this.JJGFBDBCGEE.SetFloat("ObscuredVector3 vs Vector3, ", Mathf.Max(1039f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 0);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 4);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 8);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 8);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc)
			{
				this.JJGFBDBCGEE.SetFloat("pempty=0", Mathf.Max(1694f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 3);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 4);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 4);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 7);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B4A0 RID: 46240 RVA: 0x004F5E63 File Offset: 0x004F4063
		private void OPLLGBIPEKL()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B4A1 RID: 46241 RVA: 0x004FBE94 File Offset: 0x004FA094
		private void GNDPBDHENFI()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B4A2 RID: 46242 RVA: 0x004FBF04 File Offset: 0x004FA104
		private void KLKCKFDGMJN()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B4A3 RID: 46243 RVA: 0x004FBF74 File Offset: 0x004FA174
		private void EHKCHPFDNCA()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B4A4 RID: 46244 RVA: 0x004FBFE4 File Offset: 0x004FA1E4
		private Camera IINPBAOFKLO()
		{
			if (this.CFOLJLNGMFP == null)
			{
				string text = "wpn_add/addperks/addPerk" + this.OMIJMALCLAG.name + "Player";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					string name = text;
					Type[] array = new Type[0];
					array[1] = typeof(Camera);
					this.CFOLJLNGMFP = new GameObject(name, array);
				}
				else
				{
					this.CFOLJLNGMFP = gameObject;
				}
			}
			this.CFOLJLNGMFP.hideFlags = (HideFlags)(-119);
			this.CFOLJLNGMFP.transform.position = this.OMIJMALCLAG.transform.position;
			this.CFOLJLNGMFP.transform.rotation = this.OMIJMALCLAG.transform.rotation;
			this.CFOLJLNGMFP.transform.localScale = this.OMIJMALCLAG.transform.localScale;
			this.CFOLJLNGMFP.GetComponent<Camera>().CopyFrom(this.OMIJMALCLAG);
			this.CFOLJLNGMFP.GetComponent<Camera>().enabled = false;
			this.CFOLJLNGMFP.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.CFOLJLNGMFP.GetComponent<Camera>().clearFlags = (CameraClearFlags)8;
			return this.CFOLJLNGMFP.GetComponent<Camera>();
		}

		// Token: 0x0600B4A5 RID: 46245 RVA: 0x004FC114 File Offset: 0x004FA314
		private void EABPEPPOHCA()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 0; i < 2; i++)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Right);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Right);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, true);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B4A6 RID: 46246 RVA: 0x004FC1AA File Offset: 0x004FA3AA
		private void PDBJFGPOMNH()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 255f);
		}

		// Token: 0x0600B4A7 RID: 46247 RVA: 0x004FC1D0 File Offset: 0x004FA3D0
		private void CALFOKBIBIG()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B4A8 RID: 46248 RVA: 0x004FC240 File Offset: 0x004FA440
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.POGFCHFGJGF();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf) ? RenderTextureFormat.RGHalf : RenderTextureFormat.ARGBHalf;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.HGMGGBINPIM(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.HGMGGBINPIM(JONJODLFAEN.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(2f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDX11 && this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.Reconstruction || flag || this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.HGMGGBINPIM(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.HGMGGBINPIM(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.HGMGGBINPIM(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.HGMGGBINPIM(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Point;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Point;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			this.EABPEPPOHCA();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.FEONKLCAHCN();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("_InvViewProj", matrix4x);
			this.JJGFBDBCGEE.SetMatrix("_PrevViewProj", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("_ToPrevViewProjCombined", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[]
				{
					Matrix4x4.Inverse(this.CCFLCHPKCIG[0]),
					Matrix4x4.Inverse(this.CCFLCHPKCIG[1])
				};
				Matrix4x4 value2 = this.CCDFEIHLHHI[0] * array[0];
				this.JJGFBDBCGEE.SetMatrix("_StereoToPrevViewProjCombined0", value2);
				this.JJGFBDBCGEE.SetMatrix("_StereoToPrevViewProjCombined1", this.CCDFEIHLHHI[1] * array[1]);
			}
			this.JJGFBDBCGEE.SetFloat("_MaxVelocity", value);
			this.JJGFBDBCGEE.SetFloat("_MaxRadiusOrKInPaper", value);
			this.JJGFBDBCGEE.SetFloat("_MinVelocity", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("_VelocityScale", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("_Jitter", this.jitter);
			this.JJGFBDBCGEE.SetTexture("_NoiseTex", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("_VelTex", temporary);
			this.JJGFBDBCGEE.SetTexture("_NeighbourMaxTex", temporary3);
			this.JJGFBDBCGEE.SetTexture("_TileTexDebug", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 0.3333f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix("_PrevViewProj", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("_ToPrevViewProjCombined", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 0.75f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 0.75f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 0.75f);
				zero.z = this.rotationScale * (1f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 0.5f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 0.5f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 0.5f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("_BlurDirectionPacked", new Vector4(this.previewScale.y, this.previewScale.x, 0f, this.previewScale.z) * 0.5f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("_BlurDirectionPacked", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 0);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.JDPDICNNKAD();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.FEONKLCAHCN();
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("_DisplayVelocityScale", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDX11 && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("_MinVelocity", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("_VelocityScale", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("_Jitter", this.jitter);
				this.LBBJOIEBPIN.SetTexture("_NoiseTex", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("_VelTex", temporary);
				this.LBBJOIEBPIN.SetTexture("_NeighbourMaxTex", temporary3);
				this.LBBJOIEBPIN.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("_MaxRadiusOrKInPaper", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 0);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 1);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 2);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.Reconstruction || flag)
			{
				this.JJGFBDBCGEE.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 2);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 3);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 4);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 6);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc)
			{
				this.JJGFBDBCGEE.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 2);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 3);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 7);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B4A9 RID: 46249 RVA: 0x004F5E63 File Offset: 0x004F4063
		private void PIMGCFGNCJH()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B4AA RID: 46250 RVA: 0x004FCB50 File Offset: 0x004FAD50
		private void OnDisable()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B4AB RID: 46251 RVA: 0x004FCBC0 File Offset: 0x004FADC0
		private void GBAEKFJBEFM()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B4AC RID: 46252 RVA: 0x004FCC30 File Offset: 0x004FAE30
		public virtual bool JCCFBJBBHBP()
		{
			base.FEKJMLPLNGO(true, true);
			this.JJGFBDBCGEE = base.BOOFEOGDMBI(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDX11)
			{
				this.LBBJOIEBPIN = base.DJFOEIJIMJB(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.LNEHBOJIBAI();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B4AD RID: 46253 RVA: 0x004FCC9B File Offset: 0x004FAE9B
		private void ODGEBNGBEDN()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 1578f);
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x004FCCC0 File Offset: 0x004FAEC0
		private void FEONKLCAHCN()
		{
			this.ELJIHKALJGN = this.ACMFIGCDMBD;
			this.GDFCFFGPMAM = base.transform.forward;
			this.GPODKOAAIGA = base.transform.up;
			this.GJMNAHPDKKO = base.transform.position;
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[0];
			this.CCDFEIHLHHI[1] = this.CCFLCHPKCIG[1];
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x004FCD3C File Offset: 0x004FAF3C
		public virtual bool NLCKKCKGJDN()
		{
			base.DAOKCAOFIGE(true, true);
			this.JJGFBDBCGEE = base.OOAOHFFDMJP(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDX11)
			{
				this.LBBJOIEBPIN = base.BAPJBHPEDIF(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x004FCDA8 File Offset: 0x004FAFA8
		private void LENELHOAKID(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.HKMHOFMNILD();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-5)) ? ((RenderTextureFormat)(-16)) : RenderTextureFormat.Depth;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.LHANICIILJF(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.AKBMHFBHBNF(JONJODLFAEN.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(1080f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType != (CameraMotionBlur.FDPCLLEACAB)5 || this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDX11 || flag || this.filterType == (CameraMotionBlur.FDPCLLEACAB)8)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.DKOPGLKEOPN(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.NMMKBBMKBMP(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.OBGOLDEPOJP(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.AKBMHFBHBNF(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 1, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Bilinear;
			temporary3.filterMode = FilterMode.Point;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Point;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			this.FJHAPNODNPL();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.BHCMACAGNNH();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("crft_krit", matrix4x);
			this.JJGFBDBCGEE.SetMatrix("PaperTurn.wav", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("firsStartInfoPanel", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[4];
				array[1] = Matrix4x4.Inverse(this.CCFLCHPKCIG[0]);
				array[0] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				Matrix4x4 value2 = this.CCDFEIHLHHI[0] * array[1];
				this.JJGFBDBCGEE.SetMatrix("Flares", value2);
				this.JJGFBDBCGEE.SetMatrix("root is null", this.CCDFEIHLHHI[0] * array[1]);
			}
			this.JJGFBDBCGEE.SetFloat("Show History (messages : {0})", value);
			this.JJGFBDBCGEE.SetFloat(" ", value);
			this.JJGFBDBCGEE.SetFloat("Biped's spine bone nr ", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("SneakBackward", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("Floating point textures aren't supported on this device ({0})", this.jitter);
			this.JJGFBDBCGEE.SetTexture("002000", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("Climbing Idle", temporary);
			this.JJGFBDBCGEE.SetTexture("RollerBladeGrindRoyale", temporary3);
			this.JJGFBDBCGEE.SetTexture("", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 375f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, false);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix("UIChat_fontSize", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix(" ", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 5f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 267f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1160f);
				zero.z = this.rotationScale * (1334f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 690f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 1261f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 1753f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("WindZone", new Vector4(this.previewScale.y, this.previewScale.x, 1383f, this.previewScale.z) * 1843f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector(" ms", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 1);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.IINPBAOFKLO();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "1 Hand Sword Jab Combo");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.GANOGBNNIMJ();
			}
			JONJODLFAEN.filterMode = FilterMode.Point;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("Eyelashes", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)6 && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("_UV_Transform", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("#000000", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("_BlurRadius4", this.jitter);
				this.LBBJOIEBPIN.SetTexture("<color='#405000'>", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("WATERMODE", temporary);
				this.LBBJOIEBPIN.SetTexture("IdleFeedThrow", temporary3);
				this.LBBJOIEBPIN.SetFloat("_ProjectionInv", Mathf.Max(601f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("ChannelCastOmni", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 1);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 0);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 0);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)5 || flag)
			{
				this.JJGFBDBCGEE.SetFloat("post_7", Mathf.Max(268f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 7);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 3);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 4);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 8);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)8)
			{
				this.JJGFBDBCGEE.SetFloat("The 'font size' command requires a font size parameter.", Mathf.Max(809f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 6);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 8);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 3);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 6);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x004F5E63 File Offset: 0x004F4063
		private void OCIANPBJNND()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B4B2 RID: 46258 RVA: 0x004FD6B5 File Offset: 0x004FB8B5
		private void IKJGEPJOKLA()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 1616f);
		}

		// Token: 0x0600B4B3 RID: 46259 RVA: 0x004F6D89 File Offset: 0x004F4F89
		private static int DKOPGLKEOPN(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 1) / MBFGBDLOKFH;
		}

		// Token: 0x0600B4B4 RID: 46260 RVA: 0x004F8D42 File Offset: 0x004F6F42
		private static int MBAJKNHMLFA(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 0) / MBFGBDLOKFH;
		}

		// Token: 0x0600B4B5 RID: 46261 RVA: 0x004F5E63 File Offset: 0x004F4063
		private void MBGOKFGOGKM()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B4B6 RID: 46262 RVA: 0x004FD6D8 File Offset: 0x004FB8D8
		private void LPNEAHINHOF()
		{
			this.ELJIHKALJGN = this.ACMFIGCDMBD;
			this.GDFCFFGPMAM = base.transform.forward;
			this.GPODKOAAIGA = base.transform.up;
			this.GJMNAHPDKKO = base.transform.position;
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[0];
			this.CCDFEIHLHHI[0] = this.CCFLCHPKCIG[1];
		}

		// Token: 0x0600B4B7 RID: 46263 RVA: 0x004FD754 File Offset: 0x004FB954
		public virtual bool BGDALDCKGKM()
		{
			base.DAOKCAOFIGE(true, true);
			this.JJGFBDBCGEE = base.DJFOEIJIMJB(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.LBBJOIEBPIN = base.OOAOHFFDMJP(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B4B8 RID: 46264 RVA: 0x004FD7C0 File Offset: 0x004FB9C0
		public virtual bool ANEEEKFNKGI()
		{
			base.DAOKCAOFIGE(false, true);
			this.JJGFBDBCGEE = base.IIIIADNBONI(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == CameraMotionBlur.FDPCLLEACAB.LocalBlur)
			{
				this.LBBJOIEBPIN = base.BOOFEOGDMBI(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B4B9 RID: 46265 RVA: 0x004FD82C File Offset: 0x004FBA2C
		private void KECMAHFJBCD()
		{
			this.BOFHDNBNAOA();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[2];
			this.CCDFEIHLHHI = new Matrix4x4[1];
			this.HBIOBBCPPIJ();
			this.KBBKBGFDGLG();
			this.GIFGDHDIELG = true;
		}

		// Token: 0x0600B4BA RID: 46266 RVA: 0x004F5E63 File Offset: 0x004F4063
		private void DEGFGIDFFLD()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600B4BB RID: 46267 RVA: 0x004FD898 File Offset: 0x004FBA98
		private void JCFAOKCHAEK()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 1; i < 7; i += 0)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Left);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Right);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, false);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B4BC RID: 46268 RVA: 0x004FD930 File Offset: 0x004FBB30
		private void CKIMMGJJHMO()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 1; i < 4; i++)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Left);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Right);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, false);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B4BD RID: 46269 RVA: 0x004FD9C8 File Offset: 0x004FBBC8
		private void BGCLAKJHAFK()
		{
			this.DLENDGGGMBJ();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[4];
			this.CCDFEIHLHHI = new Matrix4x4[8];
			this.FJHAPNODNPL();
			this.FEONKLCAHCN();
			this.GIFGDHDIELG = true;
		}

		// Token: 0x0600B4BE RID: 46270 RVA: 0x004F6D89 File Offset: 0x004F4F89
		private static int LHANICIILJF(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 1) / MBFGBDLOKFH;
		}

		// Token: 0x0600B4BF RID: 46271 RVA: 0x004FDA34 File Offset: 0x004FBC34
		private void DHEAJMJGJPF()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, false);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 0; i < 2; i++)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Right);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Left);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, true);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x004FDACC File Offset: 0x004FBCCC
		private void AHMFIGNLJOB()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B4C1 RID: 46273 RVA: 0x004FDB39 File Offset: 0x004FBD39
		private void AOJEAPEGJGF()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 307f);
		}

		// Token: 0x0600B4C2 RID: 46274 RVA: 0x004FDB5C File Offset: 0x004FBD5C
		private void JJFLKEGMIFN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NIFOFLEPKIB())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.GBLKILHJNCG();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)76) ? ((RenderTextureFormat)29) : RenderTextureFormat.ARGB1555;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.DLJBJHFNLJJ(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.CEMBCHLHNIL(JONJODLFAEN.height, this.velocityDownsample), 1, format);
			this.maxVelocity = Mathf.Max(1797f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType == (CameraMotionBlur.FDPCLLEACAB)7 && this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.LocalBlur || flag || this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.DHKGDLDHAJI(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.DKOPGLKEOPN(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.NMMKBBMKBMP(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.DKOPGLKEOPN(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 1, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Bilinear;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Bilinear;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Repeat;
			this.EABPEPPOHCA();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.GANOGBNNIMJ();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("Rebirth", matrix4x);
			this.JJGFBDBCGEE.SetMatrix(" ", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("http://www.root-motion.com/finalikdox/html/page12.html", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[2];
				array[0] = Matrix4x4.Inverse(this.CCFLCHPKCIG[0]);
				array[0] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				Matrix4x4 value2 = this.CCDFEIHLHHI[1] * array[1];
				this.JJGFBDBCGEE.SetMatrix("demoUint", value2);
				this.JJGFBDBCGEE.SetMatrix("", this.CCDFEIHLHHI[0] * array[1]);
			}
			this.JJGFBDBCGEE.SetFloat("priceCr", value);
			this.JJGFBDBCGEE.SetFloat("Roll", value);
			this.JJGFBDBCGEE.SetFloat("inv_auklotn", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("Hidden/Amplify Color/ProcessOnly", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("Horizontal", this.jitter);
			this.JJGFBDBCGEE.SetTexture(" position is the same as it's parent spine/pelvis bone's position. Please remove this bone from the spine.", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_trigonometric_i_k.html", temporary);
			this.JJGFBDBCGEE.SetTexture("wpnlang/wpntypes/type", temporary3);
			this.JJGFBDBCGEE.SetTexture("_MainTex", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 1448f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix("type", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("<color='#a060ff'>{0}</color>: {1}", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1368f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 734f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 72f);
				zero.z = this.rotationScale * (1600f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 1445f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 206f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 1504f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("CrouchWalk", new Vector4(this.previewScale.y, this.previewScale.x, 1442f, this.previewScale.z) * 564f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("WRINKLE_MAPS", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 0);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.LLEDFABKFEL();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "inv_rl");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.LPNEAHINHOF();
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("Horizontal", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 0);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("минуты", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("wpn_onlym", this.jitter);
				this.LBBJOIEBPIN.SetTexture("Mouse X", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("", temporary);
				this.LBBJOIEBPIN.SetTexture("</color>", temporary3);
				this.LBBJOIEBPIN.SetFloat("", Mathf.Max(1316f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("Beards", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 1);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 0);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 6);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.LocalBlur || flag)
			{
				this.JJGFBDBCGEE.SetFloat("[wtemplid]", Mathf.Max(795f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 5);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 2);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)8)
			{
				this.JJGFBDBCGEE.SetFloat("MotorbikeAirWalk", Mathf.Max(1273f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 1);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 0);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 3);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x004FE469 File Offset: 0x004FC669
		private void CIKLBNDDNIJ()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 274f);
		}

		// Token: 0x0600B4C4 RID: 46276 RVA: 0x004FE48C File Offset: 0x004FC68C
		private void JJBCBLDFINC()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B4C5 RID: 46277 RVA: 0x004FE4FC File Offset: 0x004FC6FC
		private void IJKMOJONNNH()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B4C6 RID: 46278 RVA: 0x004FE569 File Offset: 0x004FC769
		private void BDFJEKPKLCC()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 697f);
		}

		// Token: 0x0600B4C7 RID: 46279 RVA: 0x004FE58C File Offset: 0x004FC78C
		private void MMLCIGHEHJJ(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.CIKLBNDDNIJ();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-11)) ? ((RenderTextureFormat)(-48)) : RenderTextureFormat.Default;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.LDLKJPGAJNJ(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.CEMBCHLHNIL(JONJODLFAEN.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(836f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType != CameraMotionBlur.FDPCLLEACAB.LocalBlur || this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc || flag || this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDX11)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.MBAJKNHMLFA(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.CEMBCHLHNIL(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.DHKGDLDHAJI(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.OBGOLDEPOJP(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 1, format);
			temporary.filterMode = FilterMode.Bilinear;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Bilinear;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Bilinear;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Repeat;
			this.AEBGLHDGEMK();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.FEONKLCAHCN();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("I'm obscured string", matrix4x);
			this.JJGFBDBCGEE.SetMatrix("CrouchStrafeLeft", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("_noinfo", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[0];
				array[1] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				array[1] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				Matrix4x4 value2 = this.CCDFEIHLHHI[0] * array[1];
				this.JJGFBDBCGEE.SetMatrix(": ", value2);
				this.JJGFBDBCGEE.SetMatrix(" R ", this.CCDFEIHLHHI[0] * array[1]);
			}
			this.JJGFBDBCGEE.SetFloat("", value);
			this.JJGFBDBCGEE.SetFloat("", value);
			this.JJGFBDBCGEE.SetFloat("Bend Constraint contains a null reference.", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("change me!", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("Mouse Y", this.jitter);
			this.JJGFBDBCGEE.SetTexture("-H", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("RHandPunch", temporary);
			this.JJGFBDBCGEE.SetTexture("IdleMonster", temporary3);
			this.JJGFBDBCGEE.SetTexture("OfficeSittingEyesRub", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 1411f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix(", ", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("id", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1129f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1382f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1917f);
				zero.z = this.rotationScale * (1121f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 1937f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 90f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 961f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("", new Vector4(this.previewScale.y, this.previewScale.x, 1979f, this.previewScale.z) * 167f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("id", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 1);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.PMGIJAMNFCC();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "<color='#80ff00'>+ </color>");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.IGCLAAMONAI();
			}
			JONJODLFAEN.filterMode = FilterMode.Point;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("_rcIn.ogg", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)7 && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("Mouse Y", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("post_13", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("RunBackLeft", this.jitter);
				this.LBBJOIEBPIN.SetTexture("206000", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("#FF4040", temporary);
				this.LBBJOIEBPIN.SetTexture("x", temporary3);
				this.LBBJOIEBPIN.SetFloat("_FogOfWarSize", Mathf.Max(890f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("RussianDance", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 0);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 1);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 0);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)5 || flag)
			{
				this.JJGFBDBCGEE.SetFloat(" rep.repa=", Mathf.Max(1763f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 1);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 5);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 6);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)7)
			{
				this.JJGFBDBCGEE.SetFloat("AntaresController", Mathf.Max(1740f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 0);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 2);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 1);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 8);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B4C8 RID: 46280 RVA: 0x004FEE9C File Offset: 0x004FD09C
		private void PFJFBKAKIEF()
		{
			this.ELJIHKALJGN = this.ACMFIGCDMBD;
			this.GDFCFFGPMAM = base.transform.forward;
			this.GPODKOAAIGA = base.transform.up;
			this.GJMNAHPDKKO = base.transform.position;
			this.CCDFEIHLHHI[1] = this.CCFLCHPKCIG[1];
			this.CCDFEIHLHHI[1] = this.CCFLCHPKCIG[1];
		}

		// Token: 0x0600B4C9 RID: 46281 RVA: 0x004FEF18 File Offset: 0x004FD118
		private void DFCJDHJGILP()
		{
			if (null != this.JJGFBDBCGEE)
			{
				UnityEngine.Object.DestroyImmediate(this.JJGFBDBCGEE);
				this.JJGFBDBCGEE = null;
			}
			if (null != this.LBBJOIEBPIN)
			{
				UnityEngine.Object.DestroyImmediate(this.LBBJOIEBPIN);
				this.LBBJOIEBPIN = null;
			}
			if (null != this.CFOLJLNGMFP)
			{
				UnityEngine.Object.DestroyImmediate(this.CFOLJLNGMFP);
				this.CFOLJLNGMFP = null;
			}
		}

		// Token: 0x0600B4CA RID: 46282 RVA: 0x004FEF88 File Offset: 0x004FD188
		private Camera PMGIJAMNFCC()
		{
			if (this.CFOLJLNGMFP == null)
			{
				string text = "reel_type" + this.OMIJMALCLAG.name + "KatanaReadyHigh";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					string name = text;
					Type[] array = new Type[1];
					array[1] = typeof(Camera);
					this.CFOLJLNGMFP = new GameObject(name, array);
				}
				else
				{
					this.CFOLJLNGMFP = gameObject;
				}
			}
			this.CFOLJLNGMFP.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
			this.CFOLJLNGMFP.transform.position = this.OMIJMALCLAG.transform.position;
			this.CFOLJLNGMFP.transform.rotation = this.OMIJMALCLAG.transform.rotation;
			this.CFOLJLNGMFP.transform.localScale = this.OMIJMALCLAG.transform.localScale;
			this.CFOLJLNGMFP.GetComponent<Camera>().CopyFrom(this.OMIJMALCLAG);
			this.CFOLJLNGMFP.GetComponent<Camera>().enabled = false;
			this.CFOLJLNGMFP.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.CFOLJLNGMFP.GetComponent<Camera>().clearFlags = (CameraClearFlags)7;
			return this.CFOLJLNGMFP.GetComponent<Camera>();
		}

		// Token: 0x0600B4CB RID: 46283 RVA: 0x004F6D89 File Offset: 0x004F4F89
		private static int DHKGDLDHAJI(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 1) / MBFGBDLOKFH;
		}

		// Token: 0x0600B4CC RID: 46284 RVA: 0x004FF0B8 File Offset: 0x004FD2B8
		private void GDIMBBBPIHI()
		{
			this.DLENDGGGMBJ();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[0];
			this.CCDFEIHLHHI = new Matrix4x4[2];
			this.FFMOALDGPNE();
			this.PFJFBKAKIEF();
			this.GIFGDHDIELG = false;
		}

		// Token: 0x0600B4CD RID: 46285 RVA: 0x004FF124 File Offset: 0x004FD324
		private void CAJNOJOCPGB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.BOFHDNBNAOA())
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				this.EGANMEGCKBK();
			}
			RenderTextureFormat format = SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-86)) ? ((RenderTextureFormat)(-106)) : RenderTextureFormat.ARGB4444;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.OBGOLDEPOJP(JONJODLFAEN.width, this.velocityDownsample), CameraMotionBlur.MBAJKNHMLFA(JONJODLFAEN.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(1385f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType != (CameraMotionBlur.FDPCLLEACAB)6 || this.LBBJOIEBPIN == null;
			int num;
			int height;
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.Reconstruction || flag || this.filterType == CameraMotionBlur.FDPCLLEACAB.ReconstructionDisc)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.NEANOOMMOOB);
				num = CameraMotionBlur.OBGOLDEPOJP(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.MBAJKNHMLFA(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.LHANICIILJF(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.DLJBJHFNLJJ(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Bilinear;
			temporary2.filterMode = FilterMode.Bilinear;
			temporary3.filterMode = FilterMode.Point;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Bilinear;
			}
			JONJODLFAEN.wrapMode = TextureWrapMode.Repeat;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Repeat;
			temporary2.wrapMode = TextureWrapMode.Repeat;
			this.HBIOBBCPPIJ();
			if (base.gameObject.activeInHierarchy && !this.GIFGDHDIELG)
			{
				this.CBPKFGJAMLF();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.ACMFIGCDMBD);
			this.JJGFBDBCGEE.SetMatrix("#606060", matrix4x);
			this.JJGFBDBCGEE.SetMatrix("error.wav", this.ELJIHKALJGN);
			this.JJGFBDBCGEE.SetMatrix("rollSoundIndex", this.ELJIHKALJGN * matrix4x);
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				Matrix4x4[] array = new Matrix4x4[6];
				array[1] = Matrix4x4.Inverse(this.CCFLCHPKCIG[0]);
				array[1] = Matrix4x4.Inverse(this.CCFLCHPKCIG[1]);
				Matrix4x4 value2 = this.CCDFEIHLHHI[0] * array[0];
				this.JJGFBDBCGEE.SetMatrix("HandPoint", value2);
				this.JJGFBDBCGEE.SetMatrix("Projector reference not set.", this.CCDFEIHLHHI[0] * array[1]);
			}
			this.JJGFBDBCGEE.SetFloat("1", value);
			this.JJGFBDBCGEE.SetFloat("_FresnelFade", value);
			this.JJGFBDBCGEE.SetFloat("emergencyMode", this.minVelocity);
			this.JJGFBDBCGEE.SetFloat("LHandPunch", this.velocityScale);
			this.JJGFBDBCGEE.SetFloat("#02C85F", this.jitter);
			this.JJGFBDBCGEE.SetTexture("error", this.noiseTexture);
			this.JJGFBDBCGEE.SetTexture("Vertical", temporary);
			this.JJGFBDBCGEE.SetTexture("Cheer Jump", temporary3);
			this.JJGFBDBCGEE.SetTexture("wpn_cat4", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 1037f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
				this.ELJIHKALJGN = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.JJGFBDBCGEE.SetMatrix("{0}KLIK_10.tif", this.ELJIHKALJGN);
				this.JJGFBDBCGEE.SetMatrix("Please assign all Bones to the IK solver.", this.ELJIHKALJGN * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.GJMNAHPDKKO - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.GPODKOAAIGA) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 42f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 297f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.GDFCFFGPMAM) / this.OMIJMALCLAG.fieldOfView * ((float)JONJODLFAEN.width * 1267f);
				zero.z = this.rotationScale * (1419f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)JONJODLFAEN.width * 802f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)JONJODLFAEN.width * 235f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)JONJODLFAEN.width * 1262f);
				}
				if (this.preview)
				{
					this.JJGFBDBCGEE.SetVector("Sitting Reading Lean Back", new Vector4(this.previewScale.y, this.previewScale.x, 675f, this.previewScale.z) * 803f * this.OMIJMALCLAG.fieldOfView);
				}
				else
				{
					this.JJGFBDBCGEE.SetVector("threshold", zero);
				}
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, temporary, this.JJGFBDBCGEE, 1);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.LLEDFABKFEL();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, "C");
				}
			}
			if (!this.preview && Time.frameCount != this.PPIIHJGPEFM)
			{
				this.PPIIHJGPEFM = Time.frameCount;
				this.BHCMACAGNNH();
			}
			JONJODLFAEN.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.JJGFBDBCGEE.SetFloat("MotorbikeLassoBack", this.showVelocityScale);
				Graphics.Blit(temporary, OKIIDHIJBEA, this.JJGFBDBCGEE, 0);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.LocalBlur && !flag)
			{
				this.LBBJOIEBPIN.SetFloat("WATER_REFLECTIVE", this.minVelocity);
				this.LBBJOIEBPIN.SetFloat("", this.velocityScale);
				this.LBBJOIEBPIN.SetFloat("abcd", this.jitter);
				this.LBBJOIEBPIN.SetTexture("_OcclusionBlurTexture", this.noiseTexture);
				this.LBBJOIEBPIN.SetTexture("Flap_02.wav", temporary);
				this.LBBJOIEBPIN.SetTexture("auk buy result: ", temporary3);
				this.LBBJOIEBPIN.SetFloat("WorkerShovel2", Mathf.Max(1257f, this.softZDistance));
				this.LBBJOIEBPIN.SetFloat("; ", value);
				Graphics.Blit(temporary, temporary2, this.LBBJOIEBPIN, 0);
				Graphics.Blit(temporary2, temporary3, this.LBBJOIEBPIN, 0);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.LBBJOIEBPIN, 1);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.Reconstruction || flag)
			{
				this.JJGFBDBCGEE.SetFloat("KarateGreet", Mathf.Max(1445f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 3);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 1);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 6);
			}
			else if (this.filterType == CameraMotionBlur.FDPCLLEACAB.CameraMotion)
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 3);
			}
			else if (this.filterType == (CameraMotionBlur.FDPCLLEACAB)5)
			{
				this.JJGFBDBCGEE.SetFloat("shop_t14", Mathf.Max(1813f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.JJGFBDBCGEE, 3);
				Graphics.Blit(temporary2, temporary3, this.JJGFBDBCGEE, 2);
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 5);
			}
			else
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.JJGFBDBCGEE, 4);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x0600B4CE RID: 46286 RVA: 0x004F779D File Offset: 0x004F599D
		private void DKEFEKOLGFB()
		{
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.OMIJMALCLAG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600B4D0 RID: 46288 RVA: 0x004FFA40 File Offset: 0x004FDC40
		public virtual bool PKLOCPBBHNH()
		{
			base.KGKLINAKDBE(false, true);
			this.JJGFBDBCGEE = base.BOOFEOGDMBI(this.shader, this.JJGFBDBCGEE);
			if (this.PKDDLGKEIBG && this.filterType == (CameraMotionBlur.FDPCLLEACAB)6)
			{
				this.LBBJOIEBPIN = base.BAPJBHPEDIF(this.dx11MotionBlurShader, this.LBBJOIEBPIN);
			}
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B4D1 RID: 46289 RVA: 0x004FFAAC File Offset: 0x004FDCAC
		private void FJHAPNODNPL()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, true);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 0; i < 6; i += 0)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Left);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Left);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, false);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B4D2 RID: 46290 RVA: 0x004FFB44 File Offset: 0x004FDD44
		private void BFAMDMLHAIF()
		{
			Matrix4x4 worldToCameraMatrix = this.OMIJMALCLAG.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.OMIJMALCLAG.projectionMatrix, false);
			this.ACMFIGCDMBD = gpuprojectionMatrix * worldToCameraMatrix;
			if (this.OMIJMALCLAG.stereoEnabled)
			{
				for (int i = 1; i < 5; i++)
				{
					Matrix4x4 stereoViewMatrix = this.OMIJMALCLAG.GetStereoViewMatrix((i == 0) ? Camera.StereoscopicEye.Right : Camera.StereoscopicEye.Left);
					Matrix4x4 matrix4x = this.OMIJMALCLAG.GetStereoProjectionMatrix((i == 0) ? Camera.StereoscopicEye.Left : Camera.StereoscopicEye.Left);
					matrix4x = GL.GetGPUProjectionMatrix(matrix4x, false);
					this.CCFLCHPKCIG[i] = matrix4x * stereoViewMatrix;
				}
			}
		}

		// Token: 0x0600B4D3 RID: 46291 RVA: 0x004FFBDA File Offset: 0x004FDDDA
		private void IDPFHDHKCGF()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 1828f);
		}

		// Token: 0x0600B4D4 RID: 46292 RVA: 0x004FFBFD File Offset: 0x004FDDFD
		private void EGANMEGCKBK()
		{
			this.GJMNAHPDKKO = Vector3.Slerp(this.GJMNAHPDKKO, base.transform.position, 562f);
		}

		// Token: 0x0600B4D5 RID: 46293 RVA: 0x004F6D89 File Offset: 0x004F4F89
		private static int AKBMHFBHBNF(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 1) / MBFGBDLOKFH;
		}

		// Token: 0x0600B4D6 RID: 46294 RVA: 0x004FFC20 File Offset: 0x004FDE20
		private void IJOCHELLKJH()
		{
			this.CheckResources();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[5];
			this.CCDFEIHLHHI = new Matrix4x4[4];
			this.AEBGLHDGEMK();
			this.EJHMKCIEOKK();
			this.GIFGDHDIELG = true;
		}

		// Token: 0x0600B4D7 RID: 46295 RVA: 0x004FFC8C File Offset: 0x004FDE8C
		private void CBLGFOFHNPJ()
		{
			this.CheckResources();
			if (this.OMIJMALCLAG == null)
			{
				this.OMIJMALCLAG = base.GetComponent<Camera>();
			}
			this.GIFGDHDIELG = base.gameObject.activeInHierarchy;
			this.CCFLCHPKCIG = new Matrix4x4[6];
			this.CCDFEIHLHHI = new Matrix4x4[2];
			this.CHBJLJGCBJD();
			this.KBBKBGFDGLG();
			this.GIFGDHDIELG = false;
		}

		// Token: 0x0600B4D8 RID: 46296 RVA: 0x004F6D89 File Offset: 0x004F4F89
		private static int NMMKBBMKBMP(int OCNGPCPMCPM, int MBFGBDLOKFH)
		{
			return (OCNGPCPMCPM + MBFGBDLOKFH - 1) / MBFGBDLOKFH;
		}

		// Token: 0x0400172A RID: 5930
		private static float NEANOOMMOOB = 10f;

		// Token: 0x0400172B RID: 5931
		public CameraMotionBlur.FDPCLLEACAB filterType = CameraMotionBlur.FDPCLLEACAB.Reconstruction;

		// Token: 0x0400172C RID: 5932
		public bool preview;

		// Token: 0x0400172D RID: 5933
		public Vector3 previewScale = Vector3.one;

		// Token: 0x0400172E RID: 5934
		public float movementScale;

		// Token: 0x0400172F RID: 5935
		public float rotationScale = 1f;

		// Token: 0x04001730 RID: 5936
		public float maxVelocity = 8f;

		// Token: 0x04001731 RID: 5937
		public float minVelocity = 0.1f;

		// Token: 0x04001732 RID: 5938
		public float velocityScale = 0.375f;

		// Token: 0x04001733 RID: 5939
		public float softZDistance = 0.005f;

		// Token: 0x04001734 RID: 5940
		public int velocityDownsample = 1;

		// Token: 0x04001735 RID: 5941
		public LayerMask excludeLayers = 0;

		// Token: 0x04001736 RID: 5942
		private GameObject CFOLJLNGMFP;

		// Token: 0x04001737 RID: 5943
		public Shader shader;

		// Token: 0x04001738 RID: 5944
		public Shader dx11MotionBlurShader;

		// Token: 0x04001739 RID: 5945
		public Shader replacementClear;

		// Token: 0x0400173A RID: 5946
		private Material JJGFBDBCGEE;

		// Token: 0x0400173B RID: 5947
		private Material LBBJOIEBPIN;

		// Token: 0x0400173C RID: 5948
		public Texture2D noiseTexture;

		// Token: 0x0400173D RID: 5949
		public float jitter = 0.05f;

		// Token: 0x0400173E RID: 5950
		public bool showVelocity;

		// Token: 0x0400173F RID: 5951
		public float showVelocityScale = 1f;

		// Token: 0x04001740 RID: 5952
		private Matrix4x4 ACMFIGCDMBD;

		// Token: 0x04001741 RID: 5953
		private Matrix4x4[] CCFLCHPKCIG;

		// Token: 0x04001742 RID: 5954
		private Matrix4x4 ELJIHKALJGN;

		// Token: 0x04001743 RID: 5955
		private Matrix4x4[] CCDFEIHLHHI;

		// Token: 0x04001744 RID: 5956
		private int PPIIHJGPEFM;

		// Token: 0x04001745 RID: 5957
		private bool GIFGDHDIELG;

		// Token: 0x04001746 RID: 5958
		private Vector3 GDFCFFGPMAM = Vector3.forward;

		// Token: 0x04001747 RID: 5959
		private Vector3 GPODKOAAIGA = Vector3.up;

		// Token: 0x04001748 RID: 5960
		private Vector3 GJMNAHPDKKO = Vector3.zero;

		// Token: 0x04001749 RID: 5961
		private Camera OMIJMALCLAG;

		// Token: 0x0200030F RID: 783
		public enum FDPCLLEACAB
		{
			// Token: 0x0400174B RID: 5963
			CameraMotion,
			// Token: 0x0400174C RID: 5964
			LocalBlur,
			// Token: 0x0400174D RID: 5965
			Reconstruction,
			// Token: 0x0400174E RID: 5966
			ReconstructionDX11,
			// Token: 0x0400174F RID: 5967
			ReconstructionDisc
		}
	}
}
