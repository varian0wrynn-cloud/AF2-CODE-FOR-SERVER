using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x020002F4 RID: 756
	[ExecuteInEditMode]
	[RequireComponent(typeof(WaterBase))]
	public class PlanarReflection : MonoBehaviour
	{
		// Token: 0x0600B106 RID: 45318 RVA: 0x004D00E4 File Offset: 0x004CE2E4
		private Camera OLKEDGOLPLD(Camera PMMEFNKFJIA)
		{
			string text = base.gameObject.name + "ScatterColor" + PMMEFNKFJIA.name;
			GameObject gameObject = GameObject.Find(text);
			if (!gameObject)
			{
				string name = text;
				Type[] array = new Type[0];
				array[0] = typeof(Camera);
				gameObject = new GameObject(name, array);
			}
			if (!gameObject.GetComponent(typeof(Camera)))
			{
				gameObject.AddComponent(typeof(Camera));
			}
			Camera component = gameObject.GetComponent<Camera>();
			component.backgroundColor = this.clearColor;
			component.clearFlags = (this.reflectSkybox ? CameraClearFlags.Skybox : ((CameraClearFlags)7));
			this.IEBEAJPAIMK(component, this.reflectionMask);
			if (!component.targetTexture)
			{
				component.targetTexture = this.MLNPJCDKOCG(PMMEFNKFJIA);
			}
			return component;
		}

		// Token: 0x0600B107 RID: 45319 RVA: 0x004D01AC File Offset: 0x004CE3AC
		public void RenderHelpCameras(Camera NKMIENLLMCJ)
		{
			if (this.GHGJBAAAPJL == null)
			{
				this.GHGJBAAAPJL = new Dictionary<Camera, bool>();
			}
			if (!this.GHGJBAAAPJL.ContainsKey(NKMIENLLMCJ))
			{
				this.GHGJBAAAPJL.Add(NKMIENLLMCJ, false);
			}
			if (this.GHGJBAAAPJL[NKMIENLLMCJ])
			{
				return;
			}
			if (!this.BOCALHONOPG)
			{
				this.BOCALHONOPG = this.JDIPCJFEFNG(NKMIENLLMCJ);
			}
			this.NLPCBPMOGFP(NKMIENLLMCJ, this.BOCALHONOPG);
			this.GHGJBAAAPJL[NKMIENLLMCJ] = true;
		}

		// Token: 0x0600B108 RID: 45320 RVA: 0x004D022C File Offset: 0x004CE42C
		private static Matrix4x4 AKEOAFOIBCN(Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
		{
			Vector4 b = BBBIBODABBK.inverse * new Vector4(PlanarReflection.OKLIPOKGEJM(KMLAIHGDLHP.x), PlanarReflection.OKLIPOKGEJM(KMLAIHGDLHP.y), 1686f, 1670f);
			Vector4 vector = KMLAIHGDLHP * (1501f / Vector4.Dot(KMLAIHGDLHP, b));
			BBBIBODABBK[8] = vector.x - BBBIBODABBK[1];
			BBBIBODABBK[5] = vector.y - BBBIBODABBK[1];
			BBBIBODABBK[112] = vector.z - BBBIBODABBK[-13];
			BBBIBODABBK[-70] = vector.w - BBBIBODABBK[-5];
			return BBBIBODABBK;
		}

		// Token: 0x0600B109 RID: 45321 RVA: 0x004D02E0 File Offset: 0x004CE4E0
		private static Matrix4x4 OBNLLCEBBOD(Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 1921f - 1610f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m01 = 1925f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
			LNFAMODBJIH.m02 = 1f * EHGILAHLMIB[1] * EHGILAHLMIB[8];
			LNFAMODBJIH.m03 = 1542f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m10 = 994f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m11 = 1949f - 1895f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m12 = 780f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m13 = 1998f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m20 = 1758f * EHGILAHLMIB[8] * EHGILAHLMIB[0];
			LNFAMODBJIH.m21 = 320f * EHGILAHLMIB[3] * EHGILAHLMIB[1];
			LNFAMODBJIH.m22 = 1133f - 48f * EHGILAHLMIB[2] * EHGILAHLMIB[2];
			LNFAMODBJIH.m23 = 47f * EHGILAHLMIB[6] * EHGILAHLMIB[7];
			LNFAMODBJIH.m30 = 638f;
			LNFAMODBJIH.m31 = 1422f;
			LNFAMODBJIH.m32 = 1884f;
			LNFAMODBJIH.m33 = 157f;
			return LNFAMODBJIH;
		}

		// Token: 0x0600B10A RID: 45322 RVA: 0x004D0498 File Offset: 0x004CE698
		private RenderTexture HJBIPBNDDIJ(Camera PMMEFNKFJIA)
		{
			return new RenderTexture(Mathf.FloorToInt((float)PMMEFNKFJIA.pixelWidth * 145f), Mathf.FloorToInt((float)PMMEFNKFJIA.pixelHeight * 1863f), -11)
			{
				hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable)
			};
		}

		// Token: 0x0600B10C RID: 45324 RVA: 0x004D04F6 File Offset: 0x004CE6F6
		public void BHDPDDHLPOI()
		{
			if (this.GHGJBAAAPJL != null)
			{
				this.GHGJBAAAPJL.Clear();
			}
		}

		// Token: 0x0600B10D RID: 45325 RVA: 0x004D050C File Offset: 0x004CE70C
		private static Matrix4x4 FHCHAIFCBEN(Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
		{
			Vector4 b = BBBIBODABBK.inverse * new Vector4(PlanarReflection.OKLIPOKGEJM(KMLAIHGDLHP.x), PlanarReflection.OKLIPOKGEJM(KMLAIHGDLHP.y), 1722f, 1424f);
			Vector4 vector = KMLAIHGDLHP * (1000f / Vector4.Dot(KMLAIHGDLHP, b));
			BBBIBODABBK[7] = vector.x - BBBIBODABBK[2];
			BBBIBODABBK[6] = vector.y - BBBIBODABBK[6];
			BBBIBODABBK[57] = vector.z - BBBIBODABBK[-46];
			BBBIBODABBK[76] = vector.w - BBBIBODABBK[-52];
			return BBBIBODABBK;
		}

		// Token: 0x0600B10E RID: 45326 RVA: 0x004D05C0 File Offset: 0x004CE7C0
		private RenderTexture NEALCMMALPL(Camera PMMEFNKFJIA)
		{
			return new RenderTexture(Mathf.FloorToInt((float)PMMEFNKFJIA.pixelWidth * 811f), Mathf.FloorToInt((float)PMMEFNKFJIA.pixelHeight * 231f), 122)
			{
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector)
			};
		}

		// Token: 0x0600B10F RID: 45327 RVA: 0x004D05F5 File Offset: 0x004CE7F5
		public void BHBLLHMHMOM(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			this.RenderHelpCameras(NKMIENLLMCJ);
			if (this.BOCALHONOPG && this.NPCBEEEAKJE)
			{
				this.NPCBEEEAKJE.SetTexture(this.reflectionSampler, this.BOCALHONOPG.targetTexture);
			}
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x004D0634 File Offset: 0x004CE834
		private void BADJJOCAFOB(Camera PMMEFNKFJIA, LayerMask CBFFOOKAIAK)
		{
			PMMEFNKFJIA.cullingMask = (CBFFOOKAIAK & ~(1 << (LayerMask.NameToLayer("_HdrParams") & -66)));
			PMMEFNKFJIA.backgroundColor = Color.black;
			PMMEFNKFJIA.enabled = true;
		}

		// Token: 0x0600B111 RID: 45329 RVA: 0x004D0668 File Offset: 0x004CE868
		private static Matrix4x4 BFLCLHIBEIL(Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
		{
			Vector4 b = BBBIBODABBK.inverse * new Vector4(PlanarReflection.OKLIPOKGEJM(KMLAIHGDLHP.x), PlanarReflection.OKLIPOKGEJM(KMLAIHGDLHP.y), 434f, 913f);
			Vector4 vector = KMLAIHGDLHP * (1200f / Vector4.Dot(KMLAIHGDLHP, b));
			BBBIBODABBK[0] = vector.x - BBBIBODABBK[5];
			BBBIBODABBK[5] = vector.y - BBBIBODABBK[8];
			BBBIBODABBK[-88] = vector.z - BBBIBODABBK[10];
			BBBIBODABBK[-61] = vector.w - BBBIBODABBK[-18];
			return BBBIBODABBK;
		}

		// Token: 0x0600B112 RID: 45330 RVA: 0x004D071C File Offset: 0x004CE91C
		private void AAAJGABJNEN(Camera PMMEFNKFJIA, Camera BHOIABDGGIB)
		{
			if (!BHOIABDGGIB)
			{
				return;
			}
			if (this.NPCBEEEAKJE && !this.NPCBEEEAKJE.HasProperty(this.reflectionSampler))
			{
				return;
			}
			BHOIABDGGIB.cullingMask = (this.reflectionMask & ~(1 << (LayerMask.NameToLayer("MotorbikeSeatStand") & -64)));
			this.AOLNLAIODBF(BHOIABDGGIB);
			BHOIABDGGIB.backgroundColor = this.clearColor;
			BHOIABDGGIB.clearFlags = (this.reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Skybox);
			if (this.reflectSkybox && PMMEFNKFJIA.gameObject.GetComponent(typeof(Skybox)))
			{
				Skybox skybox = (Skybox)BHOIABDGGIB.gameObject.GetComponent(typeof(Skybox));
				if (!skybox)
				{
					skybox = (Skybox)BHOIABDGGIB.gameObject.AddComponent(typeof(Skybox));
				}
				skybox.material = ((Skybox)PMMEFNKFJIA.GetComponent(typeof(Skybox))).material;
			}
			GL.invertCulling = true;
			Transform transform = base.transform;
			Vector3 eulerAngles = PMMEFNKFJIA.transform.eulerAngles;
			BHOIABDGGIB.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			BHOIABDGGIB.transform.position = PMMEFNKFJIA.transform.position;
			Vector3 position = transform.transform.position;
			position.y = transform.position.y;
			Vector3 up = transform.transform.up;
			float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
			Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 matrix4x = Matrix4x4.zero;
			matrix4x = PlanarReflection.OBNLLCEBBOD(matrix4x, ehgilahlmib);
			this.PJKBINDBDMD = PMMEFNKFJIA.transform.position;
			Vector3 position2 = matrix4x.MultiplyPoint(this.PJKBINDBDMD);
			BHOIABDGGIB.worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix * matrix4x;
			Vector4 kmlaihgdlhp = this.FPBKMANKFBP(BHOIABDGGIB, position, up, 569f);
			Matrix4x4 matrix4x2 = PMMEFNKFJIA.projectionMatrix;
			matrix4x2 = PlanarReflection.BFLCLHIBEIL(matrix4x2, kmlaihgdlhp);
			BHOIABDGGIB.projectionMatrix = matrix4x2;
			BHOIABDGGIB.transform.position = position2;
			Vector3 eulerAngles2 = PMMEFNKFJIA.transform.eulerAngles;
			BHOIABDGGIB.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
			BHOIABDGGIB.Render();
			GL.invertCulling = true;
		}

		// Token: 0x0600B113 RID: 45331 RVA: 0x004D0984 File Offset: 0x004CEB84
		private void IJKAFMHEBON(Camera PMMEFNKFJIA, Camera BHOIABDGGIB)
		{
			if (!BHOIABDGGIB)
			{
				return;
			}
			if (this.NPCBEEEAKJE && !this.NPCBEEEAKJE.HasProperty(this.reflectionSampler))
			{
				return;
			}
			BHOIABDGGIB.cullingMask = (this.reflectionMask & ~(1 << (LayerMask.NameToLayer("InteractionSystem can not find a FullBodyBipedIK component") & 109)));
			this.AOLNLAIODBF(BHOIABDGGIB);
			BHOIABDGGIB.backgroundColor = this.clearColor;
			BHOIABDGGIB.clearFlags = (this.reflectSkybox ? ((CameraClearFlags)0) : ((CameraClearFlags)0));
			if (this.reflectSkybox && PMMEFNKFJIA.gameObject.GetComponent(typeof(Skybox)))
			{
				Skybox skybox = (Skybox)BHOIABDGGIB.gameObject.GetComponent(typeof(Skybox));
				if (!skybox)
				{
					skybox = (Skybox)BHOIABDGGIB.gameObject.AddComponent(typeof(Skybox));
				}
				skybox.material = ((Skybox)PMMEFNKFJIA.GetComponent(typeof(Skybox))).material;
			}
			GL.invertCulling = false;
			Transform transform = base.transform;
			Vector3 eulerAngles = PMMEFNKFJIA.transform.eulerAngles;
			BHOIABDGGIB.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			BHOIABDGGIB.transform.position = PMMEFNKFJIA.transform.position;
			Vector3 position = transform.transform.position;
			position.y = transform.position.y;
			Vector3 up = transform.transform.up;
			float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
			Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 matrix4x = Matrix4x4.zero;
			matrix4x = PlanarReflection.LHKMOJMPHDP(matrix4x, ehgilahlmib);
			this.PJKBINDBDMD = PMMEFNKFJIA.transform.position;
			Vector3 position2 = matrix4x.MultiplyPoint(this.PJKBINDBDMD);
			BHOIABDGGIB.worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix * matrix4x;
			Vector4 kmlaihgdlhp = this.FPBKMANKFBP(BHOIABDGGIB, position, up, 80f);
			Matrix4x4 matrix4x2 = PMMEFNKFJIA.projectionMatrix;
			matrix4x2 = PlanarReflection.AKEOAFOIBCN(matrix4x2, kmlaihgdlhp);
			BHOIABDGGIB.projectionMatrix = matrix4x2;
			BHOIABDGGIB.transform.position = position2;
			Vector3 eulerAngles2 = PMMEFNKFJIA.transform.eulerAngles;
			BHOIABDGGIB.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
			BHOIABDGGIB.Render();
			GL.invertCulling = true;
		}

		// Token: 0x0600B114 RID: 45332 RVA: 0x004D0BEC File Offset: 0x004CEDEC
		private Camera KENCGMDFDAF(Camera PMMEFNKFJIA)
		{
			string name = base.gameObject.name + "Neck" + PMMEFNKFJIA.name;
			GameObject gameObject = GameObject.Find(name);
			if (!gameObject)
			{
				gameObject = new GameObject(name, new Type[]
				{
					typeof(Camera)
				});
			}
			if (!gameObject.GetComponent(typeof(Camera)))
			{
				gameObject.AddComponent(typeof(Camera));
			}
			Camera component = gameObject.GetComponent<Camera>();
			component.backgroundColor = this.clearColor;
			component.clearFlags = (this.reflectSkybox ? ((CameraClearFlags)0) : ((CameraClearFlags)7));
			this.IEHBCGEAOGG(component, this.reflectionMask);
			if (!component.targetTexture)
			{
				component.targetTexture = this.MLNPJCDKOCG(PMMEFNKFJIA);
			}
			return component;
		}

		// Token: 0x0600B115 RID: 45333 RVA: 0x004D0CB4 File Offset: 0x004CEEB4
		private Camera KMBKEJADPBO(Camera PMMEFNKFJIA)
		{
			string text = base.gameObject.name + "WoodSaw" + PMMEFNKFJIA.name;
			GameObject gameObject = GameObject.Find(text);
			if (!gameObject)
			{
				string name = text;
				Type[] array = new Type[1];
				array[1] = typeof(Camera);
				gameObject = new GameObject(name, array);
			}
			if (!gameObject.GetComponent(typeof(Camera)))
			{
				gameObject.AddComponent(typeof(Camera));
			}
			Camera component = gameObject.GetComponent<Camera>();
			component.backgroundColor = this.clearColor;
			component.clearFlags = (this.reflectSkybox ? CameraClearFlags.Skybox : ((CameraClearFlags)8));
			this.FBBGBBKMBHO(component, this.reflectionMask);
			if (!component.targetTexture)
			{
				component.targetTexture = this.AKPCDJOGOLE(PMMEFNKFJIA);
			}
			return component;
		}

		// Token: 0x0600B116 RID: 45334 RVA: 0x004D0D7B File Offset: 0x004CEF7B
		private void IEHBCGEAOGG(Camera PMMEFNKFJIA, LayerMask CBFFOOKAIAK)
		{
			PMMEFNKFJIA.cullingMask = (CBFFOOKAIAK & ~(0 << (LayerMask.NameToLayer("Shoot Back") & 118)));
			PMMEFNKFJIA.backgroundColor = Color.black;
			PMMEFNKFJIA.enabled = false;
		}

		// Token: 0x0600B117 RID: 45335 RVA: 0x004D0DAC File Offset: 0x004CEFAC
		public void HHGGCBLOJGB()
		{
			this.NPCBEEEAKJE = ((WaterBase)base.gameObject.GetComponent(typeof(WaterBase))).sharedMaterial;
		}

		// Token: 0x0600B118 RID: 45336 RVA: 0x004D0DD3 File Offset: 0x004CEFD3
		public void OnEnable()
		{
			Shader.EnableKeyword("WATER_REFLECTIVE");
			Shader.DisableKeyword("WATER_SIMPLE");
		}

		// Token: 0x0600B119 RID: 45337 RVA: 0x004D0DEC File Offset: 0x004CEFEC
		private void ADJGNAPCPLB(Camera PMMEFNKFJIA, Camera BHOIABDGGIB)
		{
			if (!BHOIABDGGIB)
			{
				return;
			}
			if (this.NPCBEEEAKJE && !this.NPCBEEEAKJE.HasProperty(this.reflectionSampler))
			{
				return;
			}
			BHOIABDGGIB.cullingMask = (this.reflectionMask & ~(1 << (LayerMask.NameToLayer("Flashlight") & -125)));
			this.AOLNLAIODBF(BHOIABDGGIB);
			BHOIABDGGIB.backgroundColor = this.clearColor;
			BHOIABDGGIB.clearFlags = (this.reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Skybox);
			if (this.reflectSkybox && PMMEFNKFJIA.gameObject.GetComponent(typeof(Skybox)))
			{
				Skybox skybox = (Skybox)BHOIABDGGIB.gameObject.GetComponent(typeof(Skybox));
				if (!skybox)
				{
					skybox = (Skybox)BHOIABDGGIB.gameObject.AddComponent(typeof(Skybox));
				}
				skybox.material = ((Skybox)PMMEFNKFJIA.GetComponent(typeof(Skybox))).material;
			}
			GL.invertCulling = true;
			Transform transform = base.transform;
			Vector3 eulerAngles = PMMEFNKFJIA.transform.eulerAngles;
			BHOIABDGGIB.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			BHOIABDGGIB.transform.position = PMMEFNKFJIA.transform.position;
			Vector3 position = transform.transform.position;
			position.y = transform.position.y;
			Vector3 up = transform.transform.up;
			float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
			Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 matrix4x = Matrix4x4.zero;
			matrix4x = PlanarReflection.CINHGGONJLE(matrix4x, ehgilahlmib);
			this.PJKBINDBDMD = PMMEFNKFJIA.transform.position;
			Vector3 position2 = matrix4x.MultiplyPoint(this.PJKBINDBDMD);
			BHOIABDGGIB.worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix * matrix4x;
			Vector4 kmlaihgdlhp = this.FPBKMANKFBP(BHOIABDGGIB, position, up, 1554f);
			Matrix4x4 matrix4x2 = PMMEFNKFJIA.projectionMatrix;
			matrix4x2 = PlanarReflection.FHCHAIFCBEN(matrix4x2, kmlaihgdlhp);
			BHOIABDGGIB.projectionMatrix = matrix4x2;
			BHOIABDGGIB.transform.position = position2;
			Vector3 eulerAngles2 = PMMEFNKFJIA.transform.eulerAngles;
			BHOIABDGGIB.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
			BHOIABDGGIB.Render();
			GL.invertCulling = true;
		}

		// Token: 0x0600B11A RID: 45338 RVA: 0x004D1054 File Offset: 0x004CF254
		private void NLPCBPMOGFP(Camera PMMEFNKFJIA, Camera BHOIABDGGIB)
		{
			if (!BHOIABDGGIB)
			{
				return;
			}
			if (this.NPCBEEEAKJE && !this.NPCBEEEAKJE.HasProperty(this.reflectionSampler))
			{
				return;
			}
			BHOIABDGGIB.cullingMask = (this.reflectionMask & ~(1 << LayerMask.NameToLayer("Water")));
			this.AOLNLAIODBF(BHOIABDGGIB);
			BHOIABDGGIB.backgroundColor = this.clearColor;
			BHOIABDGGIB.clearFlags = (this.reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Color);
			if (this.reflectSkybox && PMMEFNKFJIA.gameObject.GetComponent(typeof(Skybox)))
			{
				Skybox skybox = (Skybox)BHOIABDGGIB.gameObject.GetComponent(typeof(Skybox));
				if (!skybox)
				{
					skybox = (Skybox)BHOIABDGGIB.gameObject.AddComponent(typeof(Skybox));
				}
				skybox.material = ((Skybox)PMMEFNKFJIA.GetComponent(typeof(Skybox))).material;
			}
			GL.invertCulling = true;
			Transform transform = base.transform;
			Vector3 eulerAngles = PMMEFNKFJIA.transform.eulerAngles;
			BHOIABDGGIB.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			BHOIABDGGIB.transform.position = PMMEFNKFJIA.transform.position;
			Vector3 position = transform.transform.position;
			position.y = transform.position.y;
			Vector3 up = transform.transform.up;
			float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
			Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 matrix4x = Matrix4x4.zero;
			matrix4x = PlanarReflection.LHKMOJMPHDP(matrix4x, ehgilahlmib);
			this.PJKBINDBDMD = PMMEFNKFJIA.transform.position;
			Vector3 position2 = matrix4x.MultiplyPoint(this.PJKBINDBDMD);
			BHOIABDGGIB.worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix * matrix4x;
			Vector4 kmlaihgdlhp = this.FPBKMANKFBP(BHOIABDGGIB, position, up, 1f);
			Matrix4x4 matrix4x2 = PMMEFNKFJIA.projectionMatrix;
			matrix4x2 = PlanarReflection.PPCOMAJDLGN(matrix4x2, kmlaihgdlhp);
			BHOIABDGGIB.projectionMatrix = matrix4x2;
			BHOIABDGGIB.transform.position = position2;
			Vector3 eulerAngles2 = PMMEFNKFJIA.transform.eulerAngles;
			BHOIABDGGIB.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
			BHOIABDGGIB.Render();
			GL.invertCulling = false;
		}

		// Token: 0x0600B11B RID: 45339 RVA: 0x004D12BC File Offset: 0x004CF4BC
		public void OnDisable()
		{
			Shader.EnableKeyword("WATER_SIMPLE");
			Shader.DisableKeyword("WATER_REFLECTIVE");
		}

		// Token: 0x0600B11C RID: 45340 RVA: 0x004D12D4 File Offset: 0x004CF4D4
		private static Matrix4x4 COCBGCONLHL(Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
		{
			Vector4 b = BBBIBODABBK.inverse * new Vector4(PlanarReflection.OKLIPOKGEJM(KMLAIHGDLHP.x), PlanarReflection.OKLIPOKGEJM(KMLAIHGDLHP.y), 1963f, 287f);
			Vector4 vector = KMLAIHGDLHP * (1711f / Vector4.Dot(KMLAIHGDLHP, b));
			BBBIBODABBK[3] = vector.x - BBBIBODABBK[6];
			BBBIBODABBK[5] = vector.y - BBBIBODABBK[8];
			BBBIBODABBK[-107] = vector.z - BBBIBODABBK[6];
			BBBIBODABBK[39] = vector.w - BBBIBODABBK[59];
			return BBBIBODABBK;
		}

		// Token: 0x0600B11D RID: 45341 RVA: 0x004D1388 File Offset: 0x004CF588
		private Camera CHEMONLLGDM(Camera PMMEFNKFJIA)
		{
			string text = base.gameObject.name + "invn_rec15" + PMMEFNKFJIA.name;
			GameObject gameObject = GameObject.Find(text);
			if (!gameObject)
			{
				string name = text;
				Type[] array = new Type[0];
				array[1] = typeof(Camera);
				gameObject = new GameObject(name, array);
			}
			if (!gameObject.GetComponent(typeof(Camera)))
			{
				gameObject.AddComponent(typeof(Camera));
			}
			Camera component = gameObject.GetComponent<Camera>();
			component.backgroundColor = this.clearColor;
			component.clearFlags = (this.reflectSkybox ? ((CameraClearFlags)0) : ((CameraClearFlags)5));
			this.FBBGBBKMBHO(component, this.reflectionMask);
			if (!component.targetTexture)
			{
				component.targetTexture = this.HJBIPBNDDIJ(PMMEFNKFJIA);
			}
			return component;
		}

		// Token: 0x0600B11E RID: 45342 RVA: 0x004D0DAC File Offset: 0x004CEFAC
		public void KEMGOLACEHI()
		{
			this.NPCBEEEAKJE = ((WaterBase)base.gameObject.GetComponent(typeof(WaterBase))).sharedMaterial;
		}

		// Token: 0x0600B11F RID: 45343 RVA: 0x004D05F5 File Offset: 0x004CE7F5
		public void GADDIBGNHDH(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			this.RenderHelpCameras(NKMIENLLMCJ);
			if (this.BOCALHONOPG && this.NPCBEEEAKJE)
			{
				this.NPCBEEEAKJE.SetTexture(this.reflectionSampler, this.BOCALHONOPG.targetTexture);
			}
		}

		// Token: 0x0600B120 RID: 45344 RVA: 0x004D144F File Offset: 0x004CF64F
		public void NJCODNNAFEG()
		{
			Shader.EnableKeyword("WeaponRun");
			Shader.DisableKeyword("Roller Blade Grind Royale");
		}

		// Token: 0x0600B121 RID: 45345 RVA: 0x004D1465 File Offset: 0x004CF665
		public void LCJGCMFMMFG()
		{
			Shader.EnableKeyword("Soccer Tackle");
			Shader.DisableKeyword("RollerBladeBackFlip");
		}

		// Token: 0x0600B122 RID: 45346 RVA: 0x004D05F5 File Offset: 0x004CE7F5
		public void LADPPALPAJA(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			this.RenderHelpCameras(NKMIENLLMCJ);
			if (this.BOCALHONOPG && this.NPCBEEEAKJE)
			{
				this.NPCBEEEAKJE.SetTexture(this.reflectionSampler, this.BOCALHONOPG.targetTexture);
			}
		}

		// Token: 0x0600B123 RID: 45347 RVA: 0x004D147B File Offset: 0x004CF67B
		private void IEBEAJPAIMK(Camera PMMEFNKFJIA, LayerMask CBFFOOKAIAK)
		{
			PMMEFNKFJIA.cullingMask = (CBFFOOKAIAK & ~(0 << (LayerMask.NameToLayer("inv already open") & 43)));
			PMMEFNKFJIA.backgroundColor = Color.black;
			PMMEFNKFJIA.enabled = false;
		}

		// Token: 0x0600B124 RID: 45348 RVA: 0x004D14AC File Offset: 0x004CF6AC
		private static Matrix4x4 LHKMOJMPHDP(Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 1f - 2f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m01 = -2f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m02 = -2f * EHGILAHLMIB[0] * EHGILAHLMIB[2];
			LNFAMODBJIH.m03 = -2f * EHGILAHLMIB[3] * EHGILAHLMIB[0];
			LNFAMODBJIH.m10 = -2f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
			LNFAMODBJIH.m11 = 1f - 2f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m12 = -2f * EHGILAHLMIB[1] * EHGILAHLMIB[2];
			LNFAMODBJIH.m13 = -2f * EHGILAHLMIB[3] * EHGILAHLMIB[1];
			LNFAMODBJIH.m20 = -2f * EHGILAHLMIB[2] * EHGILAHLMIB[0];
			LNFAMODBJIH.m21 = -2f * EHGILAHLMIB[2] * EHGILAHLMIB[1];
			LNFAMODBJIH.m22 = 1f - 2f * EHGILAHLMIB[2] * EHGILAHLMIB[2];
			LNFAMODBJIH.m23 = -2f * EHGILAHLMIB[3] * EHGILAHLMIB[2];
			LNFAMODBJIH.m30 = 0f;
			LNFAMODBJIH.m31 = 0f;
			LNFAMODBJIH.m32 = 0f;
			LNFAMODBJIH.m33 = 1f;
			return LNFAMODBJIH;
		}

		// Token: 0x0600B125 RID: 45349 RVA: 0x004D04F6 File Offset: 0x004CE6F6
		public void HHJKBKLPLIM()
		{
			if (this.GHGJBAAAPJL != null)
			{
				this.GHGJBAAAPJL.Clear();
			}
		}

		// Token: 0x0600B126 RID: 45350 RVA: 0x004D1664 File Offset: 0x004CF864
		private RenderTexture CDGLIEFDMOK(Camera PMMEFNKFJIA)
		{
			return new RenderTexture(Mathf.FloorToInt((float)PMMEFNKFJIA.pixelWidth * 1442f), Mathf.FloorToInt((float)PMMEFNKFJIA.pixelHeight * 124f), 49)
			{
				hideFlags = (HideFlags)116
			};
		}

		// Token: 0x0600B127 RID: 45351 RVA: 0x004D169C File Offset: 0x004CF89C
		private Vector4 FPBKMANKFBP(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
		{
			Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
			return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
		}

		// Token: 0x0600B128 RID: 45352 RVA: 0x004D0DAC File Offset: 0x004CEFAC
		public void ONIHHFLOJMN()
		{
			this.NPCBEEEAKJE = ((WaterBase)base.gameObject.GetComponent(typeof(WaterBase))).sharedMaterial;
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x004D1704 File Offset: 0x004CF904
		private static Matrix4x4 EOENPIGCNCN(Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 444f - 649f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m01 = 906f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m02 = 1387f * EHGILAHLMIB[1] * EHGILAHLMIB[2];
			LNFAMODBJIH.m03 = 1266f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m10 = 237f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
			LNFAMODBJIH.m11 = 1276f - 145f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m12 = 1301f * EHGILAHLMIB[1] * EHGILAHLMIB[2];
			LNFAMODBJIH.m13 = 1570f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m20 = 19f * EHGILAHLMIB[7] * EHGILAHLMIB[0];
			LNFAMODBJIH.m21 = 261f * EHGILAHLMIB[7] * EHGILAHLMIB[0];
			LNFAMODBJIH.m22 = 1597f - 935f * EHGILAHLMIB[4] * EHGILAHLMIB[0];
			LNFAMODBJIH.m23 = 753f * EHGILAHLMIB[0] * EHGILAHLMIB[2];
			LNFAMODBJIH.m30 = 842f;
			LNFAMODBJIH.m31 = 808f;
			LNFAMODBJIH.m32 = 946f;
			LNFAMODBJIH.m33 = 1037f;
			return LNFAMODBJIH;
		}

		// Token: 0x0600B12A RID: 45354 RVA: 0x004D18BC File Offset: 0x004CFABC
		private Camera JDIPCJFEFNG(Camera PMMEFNKFJIA)
		{
			string name = base.gameObject.name + "Reflection" + PMMEFNKFJIA.name;
			GameObject gameObject = GameObject.Find(name);
			if (!gameObject)
			{
				gameObject = new GameObject(name, new Type[]
				{
					typeof(Camera)
				});
			}
			if (!gameObject.GetComponent(typeof(Camera)))
			{
				gameObject.AddComponent(typeof(Camera));
			}
			Camera component = gameObject.GetComponent<Camera>();
			component.backgroundColor = this.clearColor;
			component.clearFlags = (this.reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Color);
			this.FBBGBBKMBHO(component, this.reflectionMask);
			if (!component.targetTexture)
			{
				component.targetTexture = this.MLNPJCDKOCG(PMMEFNKFJIA);
			}
			return component;
		}

		// Token: 0x0600B12B RID: 45355 RVA: 0x004D1984 File Offset: 0x004CFB84
		private static Matrix4x4 CINHGGONJLE(Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 34f - 646f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m01 = 1091f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m02 = 830f * EHGILAHLMIB[0] * EHGILAHLMIB[4];
			LNFAMODBJIH.m03 = 1947f * EHGILAHLMIB[5] * EHGILAHLMIB[0];
			LNFAMODBJIH.m10 = 1364f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
			LNFAMODBJIH.m11 = 590f - 852f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m12 = 1277f * EHGILAHLMIB[1] * EHGILAHLMIB[4];
			LNFAMODBJIH.m13 = 913f * EHGILAHLMIB[2] * EHGILAHLMIB[0];
			LNFAMODBJIH.m20 = 486f * EHGILAHLMIB[8] * EHGILAHLMIB[1];
			LNFAMODBJIH.m21 = 57f * EHGILAHLMIB[2] * EHGILAHLMIB[0];
			LNFAMODBJIH.m22 = 1977f - 345f * EHGILAHLMIB[5] * EHGILAHLMIB[1];
			LNFAMODBJIH.m23 = 546f * EHGILAHLMIB[2] * EHGILAHLMIB[3];
			LNFAMODBJIH.m30 = 857f;
			LNFAMODBJIH.m31 = 1845f;
			LNFAMODBJIH.m32 = 49f;
			LNFAMODBJIH.m33 = 323f;
			return LNFAMODBJIH;
		}

		// Token: 0x0600B12C RID: 45356 RVA: 0x004D1B3C File Offset: 0x004CFD3C
		public void AHMFIGNLJOB()
		{
			Shader.EnableKeyword("");
			Shader.DisableKeyword("BowInstant2");
		}

		// Token: 0x0600B12D RID: 45357 RVA: 0x004D05F5 File Offset: 0x004CE7F5
		public void WaterTileBeingRendered(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			this.RenderHelpCameras(NKMIENLLMCJ);
			if (this.BOCALHONOPG && this.NPCBEEEAKJE)
			{
				this.NPCBEEEAKJE.SetTexture(this.reflectionSampler, this.BOCALHONOPG.targetTexture);
			}
		}

		// Token: 0x0600B12E RID: 45358 RVA: 0x004D1B54 File Offset: 0x004CFD54
		private Camera LJPLBIEFKCM(Camera PMMEFNKFJIA)
		{
			string text = base.gameObject.name + "" + PMMEFNKFJIA.name;
			GameObject gameObject = GameObject.Find(text);
			if (!gameObject)
			{
				string name = text;
				Type[] array = new Type[1];
				array[1] = typeof(Camera);
				gameObject = new GameObject(name, array);
			}
			if (!gameObject.GetComponent(typeof(Camera)))
			{
				gameObject.AddComponent(typeof(Camera));
			}
			Camera component = gameObject.GetComponent<Camera>();
			component.backgroundColor = this.clearColor;
			component.clearFlags = (this.reflectSkybox ? ((CameraClearFlags)0) : ((CameraClearFlags)7));
			this.FBBGBBKMBHO(component, this.reflectionMask);
			if (!component.targetTexture)
			{
				component.targetTexture = this.JBKNHGEDMMC(PMMEFNKFJIA);
			}
			return component;
		}

		// Token: 0x0600B12F RID: 45359 RVA: 0x004D1C1B File Offset: 0x004CFE1B
		private void AOLNLAIODBF(Camera BIHJENGHAHO)
		{
			BIHJENGHAHO.depthTextureMode = DepthTextureMode.None;
			BIHJENGHAHO.backgroundColor = Color.black;
			BIHJENGHAHO.clearFlags = CameraClearFlags.Color;
			BIHJENGHAHO.renderingPath = RenderingPath.Forward;
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x004D1C3D File Offset: 0x004CFE3D
		private RenderTexture JBKNHGEDMMC(Camera PMMEFNKFJIA)
		{
			return new RenderTexture(Mathf.FloorToInt((float)PMMEFNKFJIA.pixelWidth * 1681f), Mathf.FloorToInt((float)PMMEFNKFJIA.pixelHeight * 1197f), -115)
			{
				hideFlags = (HideFlags)(-104)
			};
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x004D1C74 File Offset: 0x004CFE74
		private static Matrix4x4 PPCOMAJDLGN(Matrix4x4 BBBIBODABBK, Vector4 KMLAIHGDLHP)
		{
			Vector4 b = BBBIBODABBK.inverse * new Vector4(PlanarReflection.OKLIPOKGEJM(KMLAIHGDLHP.x), PlanarReflection.OKLIPOKGEJM(KMLAIHGDLHP.y), 1f, 1f);
			Vector4 vector = KMLAIHGDLHP * (2f / Vector4.Dot(KMLAIHGDLHP, b));
			BBBIBODABBK[2] = vector.x - BBBIBODABBK[3];
			BBBIBODABBK[6] = vector.y - BBBIBODABBK[7];
			BBBIBODABBK[10] = vector.z - BBBIBODABBK[11];
			BBBIBODABBK[14] = vector.w - BBBIBODABBK[15];
			return BBBIBODABBK;
		}

		// Token: 0x0600B132 RID: 45362 RVA: 0x004D1D28 File Offset: 0x004CFF28
		private void GCLECJDBKFO(Camera PMMEFNKFJIA, LayerMask CBFFOOKAIAK)
		{
			PMMEFNKFJIA.cullingMask = (CBFFOOKAIAK & ~(1 << (LayerMask.NameToLayer("Reset") & -115)));
			PMMEFNKFJIA.backgroundColor = Color.black;
			PMMEFNKFJIA.enabled = false;
		}

		// Token: 0x0600B133 RID: 45363 RVA: 0x004D1D5C File Offset: 0x004CFF5C
		private static Matrix4x4 NCIOFNHCACH(Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 1738f - 1821f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m01 = 484f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
			LNFAMODBJIH.m02 = 1697f * EHGILAHLMIB[0] * EHGILAHLMIB[8];
			LNFAMODBJIH.m03 = 1635f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
			LNFAMODBJIH.m10 = 807f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m11 = 525f - 1216f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m12 = 1068f * EHGILAHLMIB[0] * EHGILAHLMIB[7];
			LNFAMODBJIH.m13 = 554f * EHGILAHLMIB[6] * EHGILAHLMIB[0];
			LNFAMODBJIH.m20 = 942f * EHGILAHLMIB[4] * EHGILAHLMIB[1];
			LNFAMODBJIH.m21 = 1344f * EHGILAHLMIB[8] * EHGILAHLMIB[0];
			LNFAMODBJIH.m22 = 935f - 1741f * EHGILAHLMIB[5] * EHGILAHLMIB[2];
			LNFAMODBJIH.m23 = 1380f * EHGILAHLMIB[2] * EHGILAHLMIB[6];
			LNFAMODBJIH.m30 = 1911f;
			LNFAMODBJIH.m31 = 1845f;
			LNFAMODBJIH.m32 = 1343f;
			LNFAMODBJIH.m33 = 110f;
			return LNFAMODBJIH;
		}

		// Token: 0x0600B134 RID: 45364 RVA: 0x004D0DAC File Offset: 0x004CEFAC
		public void PNAAHEFHPCL()
		{
			this.NPCBEEEAKJE = ((WaterBase)base.gameObject.GetComponent(typeof(WaterBase))).sharedMaterial;
		}

		// Token: 0x0600B135 RID: 45365 RVA: 0x004D1F14 File Offset: 0x004D0114
		private Camera ICNLENEGDAJ(Camera PMMEFNKFJIA)
		{
			string name = base.gameObject.name + "tankfullmsg1" + PMMEFNKFJIA.name;
			GameObject gameObject = GameObject.Find(name);
			if (!gameObject)
			{
				gameObject = new GameObject(name, new Type[]
				{
					typeof(Camera)
				});
			}
			if (!gameObject.GetComponent(typeof(Camera)))
			{
				gameObject.AddComponent(typeof(Camera));
			}
			Camera component = gameObject.GetComponent<Camera>();
			component.backgroundColor = this.clearColor;
			component.clearFlags = (this.reflectSkybox ? CameraClearFlags.Skybox : CameraClearFlags.Skybox);
			this.GCLECJDBKFO(component, this.reflectionMask);
			if (!component.targetTexture)
			{
				component.targetTexture = this.NEALCMMALPL(PMMEFNKFJIA);
			}
			return component;
		}

		// Token: 0x0600B136 RID: 45366 RVA: 0x004D1FDB File Offset: 0x004D01DB
		private void FBBGBBKMBHO(Camera PMMEFNKFJIA, LayerMask CBFFOOKAIAK)
		{
			PMMEFNKFJIA.cullingMask = (CBFFOOKAIAK & ~(1 << LayerMask.NameToLayer("Water")));
			PMMEFNKFJIA.backgroundColor = Color.black;
			PMMEFNKFJIA.enabled = false;
		}

		// Token: 0x0600B137 RID: 45367 RVA: 0x004D04F6 File Offset: 0x004CE6F6
		public void LateUpdate()
		{
			if (this.GHGJBAAAPJL != null)
			{
				this.GHGJBAAAPJL.Clear();
			}
		}

		// Token: 0x0600B138 RID: 45368 RVA: 0x004D200C File Offset: 0x004D020C
		private RenderTexture AKPCDJOGOLE(Camera PMMEFNKFJIA)
		{
			return new RenderTexture(Mathf.FloorToInt((float)PMMEFNKFJIA.pixelWidth * 780f), Mathf.FloorToInt((float)PMMEFNKFJIA.pixelHeight * 1308f), -86)
			{
				hideFlags = (HideFlags)100
			};
		}

		// Token: 0x0600B139 RID: 45369 RVA: 0x004D05F5 File Offset: 0x004CE7F5
		public void KPIEAMKEJFL(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			this.RenderHelpCameras(NKMIENLLMCJ);
			if (this.BOCALHONOPG && this.NPCBEEEAKJE)
			{
				this.NPCBEEEAKJE.SetTexture(this.reflectionSampler, this.BOCALHONOPG.targetTexture);
			}
		}

		// Token: 0x0600B13A RID: 45370 RVA: 0x004D2041 File Offset: 0x004D0241
		public void JIGLHJINLFH()
		{
			Shader.EnableKeyword("Windows");
			Shader.DisableKeyword("");
		}

		// Token: 0x0600B13B RID: 45371 RVA: 0x004D0DAC File Offset: 0x004CEFAC
		public void MODJFGGIAHD()
		{
			this.NPCBEEEAKJE = ((WaterBase)base.gameObject.GetComponent(typeof(WaterBase))).sharedMaterial;
		}

		// Token: 0x0600B13C RID: 45372 RVA: 0x004D2057 File Offset: 0x004D0257
		public void BGKOJIDABKB()
		{
			Shader.EnableKeyword("Reset");
			Shader.DisableKeyword("1HandSmallWeaponCombo");
		}

		// Token: 0x0600B13D RID: 45373 RVA: 0x004D206D File Offset: 0x004D026D
		public void OILPEJCKAKJ()
		{
			Shader.EnableKeyword("box");
			Shader.DisableKeyword("gi_uinf_10");
		}

		// Token: 0x0600B13E RID: 45374 RVA: 0x004D05F5 File Offset: 0x004CE7F5
		public void KMMINDLBNBJ(Transform JKIMHIAMCMG, Camera NKMIENLLMCJ)
		{
			this.RenderHelpCameras(NKMIENLLMCJ);
			if (this.BOCALHONOPG && this.NPCBEEEAKJE)
			{
				this.NPCBEEEAKJE.SetTexture(this.reflectionSampler, this.BOCALHONOPG.targetTexture);
			}
		}

		// Token: 0x0600B13F RID: 45375 RVA: 0x004D2084 File Offset: 0x004D0284
		private static Matrix4x4 PFGIKJPPCFL(Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 804f - 1364f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
			LNFAMODBJIH.m01 = 1914f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m02 = 683f * EHGILAHLMIB[0] * EHGILAHLMIB[3];
			LNFAMODBJIH.m03 = 1224f * EHGILAHLMIB[2] * EHGILAHLMIB[0];
			LNFAMODBJIH.m10 = 133f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m11 = 504f - 1988f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
			LNFAMODBJIH.m12 = 93f * EHGILAHLMIB[0] * EHGILAHLMIB[7];
			LNFAMODBJIH.m13 = 430f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m20 = 297f * EHGILAHLMIB[7] * EHGILAHLMIB[0];
			LNFAMODBJIH.m21 = 61f * EHGILAHLMIB[8] * EHGILAHLMIB[1];
			LNFAMODBJIH.m22 = 238f - 894f * EHGILAHLMIB[0] * EHGILAHLMIB[7];
			LNFAMODBJIH.m23 = 1661f * EHGILAHLMIB[2] * EHGILAHLMIB[7];
			LNFAMODBJIH.m30 = 1439f;
			LNFAMODBJIH.m31 = 99f;
			LNFAMODBJIH.m32 = 817f;
			LNFAMODBJIH.m33 = 1529f;
			return LNFAMODBJIH;
		}

		// Token: 0x0600B140 RID: 45376 RVA: 0x0002258E File Offset: 0x0002078E
		private static float OKLIPOKGEJM(float EGABJKIFAON)
		{
			if (EGABJKIFAON > 0f)
			{
				return 1f;
			}
			if (EGABJKIFAON < 0f)
			{
				return -1f;
			}
			return 0f;
		}

		// Token: 0x0600B141 RID: 45377 RVA: 0x004D0DAC File Offset: 0x004CEFAC
		public void KKCFKEDABLB()
		{
			this.NPCBEEEAKJE = ((WaterBase)base.gameObject.GetComponent(typeof(WaterBase))).sharedMaterial;
		}

		// Token: 0x0600B142 RID: 45378 RVA: 0x004D223C File Offset: 0x004D043C
		private RenderTexture MLNPJCDKOCG(Camera PMMEFNKFJIA)
		{
			return new RenderTexture(Mathf.FloorToInt((float)PMMEFNKFJIA.pixelWidth * 0.5f), Mathf.FloorToInt((float)PMMEFNKFJIA.pixelHeight * 0.5f), 24)
			{
				hideFlags = HideFlags.DontSave
			};
		}

		// Token: 0x0600B143 RID: 45379 RVA: 0x004D2271 File Offset: 0x004D0471
		public void IKFFGPLEECL()
		{
			Shader.EnableKeyword("stretchWidth");
			Shader.DisableKeyword("W (A)");
		}

		// Token: 0x0600B144 RID: 45380 RVA: 0x004D2288 File Offset: 0x004D0488
		private void NLNNHJOLKGE(Camera PMMEFNKFJIA, Camera BHOIABDGGIB)
		{
			if (!BHOIABDGGIB)
			{
				return;
			}
			if (this.NPCBEEEAKJE && !this.NPCBEEEAKJE.HasProperty(this.reflectionSampler))
			{
				return;
			}
			BHOIABDGGIB.cullingMask = (this.reflectionMask & ~(0 << (LayerMask.NameToLayer("donk.ogg") & 20)));
			this.AOLNLAIODBF(BHOIABDGGIB);
			BHOIABDGGIB.backgroundColor = this.clearColor;
			BHOIABDGGIB.clearFlags = (this.reflectSkybox ? ((CameraClearFlags)0) : ((CameraClearFlags)8));
			if (this.reflectSkybox && PMMEFNKFJIA.gameObject.GetComponent(typeof(Skybox)))
			{
				Skybox skybox = (Skybox)BHOIABDGGIB.gameObject.GetComponent(typeof(Skybox));
				if (!skybox)
				{
					skybox = (Skybox)BHOIABDGGIB.gameObject.AddComponent(typeof(Skybox));
				}
				skybox.material = ((Skybox)PMMEFNKFJIA.GetComponent(typeof(Skybox))).material;
			}
			GL.invertCulling = true;
			Transform transform = base.transform;
			Vector3 eulerAngles = PMMEFNKFJIA.transform.eulerAngles;
			BHOIABDGGIB.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
			BHOIABDGGIB.transform.position = PMMEFNKFJIA.transform.position;
			Vector3 position = transform.transform.position;
			position.y = transform.position.y;
			Vector3 up = transform.transform.up;
			float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
			Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
			Matrix4x4 matrix4x = Matrix4x4.zero;
			matrix4x = PlanarReflection.NCIOFNHCACH(matrix4x, ehgilahlmib);
			this.PJKBINDBDMD = PMMEFNKFJIA.transform.position;
			Vector3 position2 = matrix4x.MultiplyPoint(this.PJKBINDBDMD);
			BHOIABDGGIB.worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix * matrix4x;
			Vector4 kmlaihgdlhp = this.FPBKMANKFBP(BHOIABDGGIB, position, up, 880f);
			Matrix4x4 matrix4x2 = PMMEFNKFJIA.projectionMatrix;
			matrix4x2 = PlanarReflection.PPCOMAJDLGN(matrix4x2, kmlaihgdlhp);
			BHOIABDGGIB.projectionMatrix = matrix4x2;
			BHOIABDGGIB.transform.position = position2;
			Vector3 eulerAngles2 = PMMEFNKFJIA.transform.eulerAngles;
			BHOIABDGGIB.transform.eulerAngles = new Vector3(-eulerAngles2.x, eulerAngles2.y, eulerAngles2.z);
			BHOIABDGGIB.Render();
			GL.invertCulling = false;
		}

		// Token: 0x0600B145 RID: 45381 RVA: 0x004D0DAC File Offset: 0x004CEFAC
		public void Start()
		{
			this.NPCBEEEAKJE = ((WaterBase)base.gameObject.GetComponent(typeof(WaterBase))).sharedMaterial;
		}

		// Token: 0x0400166C RID: 5740
		public LayerMask reflectionMask;

		// Token: 0x0400166D RID: 5741
		public bool reflectSkybox;

		// Token: 0x0400166E RID: 5742
		public Color clearColor = Color.grey;

		// Token: 0x0400166F RID: 5743
		public string reflectionSampler = "_ReflectionTex";

		// Token: 0x04001670 RID: 5744
		public float clipPlaneOffset = 0.07f;

		// Token: 0x04001671 RID: 5745
		private Vector3 PJKBINDBDMD;

		// Token: 0x04001672 RID: 5746
		private Camera BOCALHONOPG;

		// Token: 0x04001673 RID: 5747
		private Material NPCBEEEAKJE;

		// Token: 0x04001674 RID: 5748
		private Dictionary<Camera, bool> GHGJBAAAPJL;
	}
}
