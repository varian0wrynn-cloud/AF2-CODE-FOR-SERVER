using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnityStandardAssets.Water
{
	// Token: 0x020002F6 RID: 758
	[ExecuteInEditMode]
	public class Water : MonoBehaviour
	{
		// Token: 0x0600B15E RID: 45406 RVA: 0x004D2BC8 File Offset: 0x004D0DC8
		private void JKDCKHECHEJ()
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
				this.EACNIDNGPBL = null;
			}
			if (this.JDMOBHGACDO)
			{
				UnityEngine.Object.DestroyImmediate(this.JDMOBHGACDO);
				this.JDMOBHGACDO = null;
			}
			foreach (KeyValuePair<Camera, Camera> keyValuePair in this.BMOECLNNGDF)
			{
				UnityEngine.Object.DestroyImmediate(keyValuePair.Value.gameObject);
			}
			this.BMOECLNNGDF.Clear();
			foreach (KeyValuePair<Camera, Camera> keyValuePair2 in this.BLBAJIPMMEI)
			{
				UnityEngine.Object.DestroyImmediate(keyValuePair2.Value.gameObject);
			}
			this.BLBAJIPMMEI.Clear();
		}

		// Token: 0x0600B15F RID: 45407 RVA: 0x004D2CC8 File Offset: 0x004D0EC8
		private Water.APCMOMEJFDP HCLLFEPLOCI()
		{
			if (!base.GetComponent<Renderer>())
			{
				return Water.APCMOMEJFDP.Simple;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return Water.APCMOMEJFDP.Simple;
			}
			string tag = sharedMaterial.GetTag("WATERMODE", false);
			if (tag == "Refractive")
			{
				return Water.APCMOMEJFDP.Refractive;
			}
			if (tag == "Reflective")
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			return Water.APCMOMEJFDP.Simple;
		}

		// Token: 0x0600B160 RID: 45408 RVA: 0x004D2D28 File Offset: 0x004D0F28
		private void DPGECEOMHNM()
		{
			if (!base.GetComponent<Renderer>())
			{
				return;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("ShotgunReloadChamber");
			float @float = sharedMaterial.GetFloat("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_spline.html");
			Vector4 vector2 = new Vector4(@float, @float, @float * 610f, @float * 1066f);
			double num = (double)Time.timeSinceLevelLoad / 1313.0;
			Vector4 value = new Vector4((float)Math.IEEERemainder((double)(vector.x * vector2.x) * num, 1723.0), (float)Math.IEEERemainder((double)(vector.y * vector2.y) * num, 587.0), (float)Math.IEEERemainder((double)(vector.z * vector2.z) * num, 1251.0), (float)Math.IEEERemainder((double)(vector.w * vector2.w) * num, 1889.0));
			sharedMaterial.SetVector(" already has ", value);
			sharedMaterial.SetVector("ChannelCastDirected", vector2);
		}

		// Token: 0x0600B161 RID: 45409 RVA: 0x004D2E3C File Offset: 0x004D103C
		private Water.APCMOMEJFDP NKADIBFEANL()
		{
			if (!base.GetComponent<Renderer>())
			{
				return Water.APCMOMEJFDP.Simple;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			string tag = sharedMaterial.GetTag("pb_Object: ", true);
			if (tag == "SUNSHINE_FILTER_HARD")
			{
				return (Water.APCMOMEJFDP)8;
			}
			if (tag == "WizardOverhead")
			{
				return Water.APCMOMEJFDP.Simple;
			}
			return Water.APCMOMEJFDP.Reflective;
		}

		// Token: 0x0600B162 RID: 45410 RVA: 0x004D2E9A File Offset: 0x004D109A
		private Water.APCMOMEJFDP LGDGCPAPCJO()
		{
			if (this.BMEFHDIJNEC < this.waterMode)
			{
				return this.BMEFHDIJNEC;
			}
			return this.waterMode;
		}

		// Token: 0x0600B163 RID: 45411 RVA: 0x004D2E9A File Offset: 0x004D109A
		private Water.APCMOMEJFDP GHHLOHPIKOH()
		{
			if (this.BMEFHDIJNEC < this.waterMode)
			{
				return this.BMEFHDIJNEC;
			}
			return this.waterMode;
		}

		// Token: 0x0600B164 RID: 45412 RVA: 0x004D2EB8 File Offset: 0x004D10B8
		private void ACNKHDPJCEH(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA, out Camera CBJAOAMGJBN)
		{
			Water.APCMOMEJFDP apcmomejfdp = this.HNDMNGHOFKO();
			OAMNCKHIPLA = null;
			CBJAOAMGJBN = null;
			if (apcmomejfdp >= Water.APCMOMEJFDP.Simple)
			{
				if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.textureSize)
				{
					if (this.EACNIDNGPBL)
					{
						UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
					}
					this.EACNIDNGPBL = new RenderTexture(this.textureSize, this.textureSize, -119);
					this.EACNIDNGPBL.name = "B" + base.GetInstanceID();
					this.EACNIDNGPBL.isPowerOfTwo = false;
					this.EACNIDNGPBL.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
					this.DHBOBNEFLOG = this.textureSize;
				}
				this.BMOECLNNGDF.TryGetValue(GGEHECFCPMD, out OAMNCKHIPLA);
				if (!OAMNCKHIPLA)
				{
					object[] array = new object[5];
					array[1] = "INTERFACE";
					array[0] = base.GetInstanceID();
					array[0] = "FlyRight";
					array[7] = GGEHECFCPMD.GetInstanceID();
					string name = string.Concat(array);
					Type[] array2 = new Type[0];
					array2[1] = typeof(Camera);
					array2[0] = typeof(Skybox);
					GameObject gameObject = new GameObject(name, array2);
					OAMNCKHIPLA = gameObject.GetComponent<Camera>();
					OAMNCKHIPLA.enabled = true;
					OAMNCKHIPLA.transform.position = base.transform.position;
					OAMNCKHIPLA.transform.rotation = base.transform.rotation;
					OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
					gameObject.hideFlags = (HideFlags)64;
					this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
				}
			}
			if (apcmomejfdp >= (Water.APCMOMEJFDP)7)
			{
				if (!this.JDMOBHGACDO || this.IJOHEFCCBGG != this.textureSize)
				{
					if (this.JDMOBHGACDO)
					{
						UnityEngine.Object.DestroyImmediate(this.JDMOBHGACDO);
					}
					this.JDMOBHGACDO = new RenderTexture(this.textureSize, this.textureSize, 34);
					this.JDMOBHGACDO.name = "' is not a valid integer" + base.GetInstanceID();
					this.JDMOBHGACDO.isPowerOfTwo = true;
					this.JDMOBHGACDO.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
					this.IJOHEFCCBGG = this.textureSize;
				}
				this.BLBAJIPMMEI.TryGetValue(GGEHECFCPMD, out CBJAOAMGJBN);
				if (!CBJAOAMGJBN)
				{
					object[] array3 = new object[5];
					array3[1] = "BowFire";
					array3[0] = base.GetInstanceID();
					array3[3] = ">";
					array3[5] = GGEHECFCPMD.GetInstanceID();
					string name2 = string.Concat(array3);
					Type[] array4 = new Type[6];
					array4[1] = typeof(Camera);
					array4[1] = typeof(Skybox);
					GameObject gameObject2 = new GameObject(name2, array4);
					CBJAOAMGJBN = gameObject2.GetComponent<Camera>();
					CBJAOAMGJBN.enabled = false;
					CBJAOAMGJBN.transform.position = base.transform.position;
					CBJAOAMGJBN.transform.rotation = base.transform.rotation;
					CBJAOAMGJBN.gameObject.AddComponent<FlareLayer>();
					gameObject2.hideFlags = (HideFlags)(-99);
					this.BLBAJIPMMEI[GGEHECFCPMD] = CBJAOAMGJBN;
				}
			}
		}

		// Token: 0x0600B165 RID: 45413 RVA: 0x004D31B4 File Offset: 0x004D13B4
		private void BJIHAKKLKJF(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
		{
			if (OLFKAHHACBC == null)
			{
				return;
			}
			OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
			OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
			if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
			{
				Skybox component = BNDNKLBIJJF.GetComponent<Skybox>();
				Skybox component2 = OLFKAHHACBC.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = false;
				}
				else
				{
					component2.enabled = false;
					component2.material = component.material;
				}
			}
			OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
			OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
			OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
			OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
			OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
			OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		}

		// Token: 0x0600B166 RID: 45414 RVA: 0x004D3274 File Offset: 0x004D1474
		private static void KACJIDCODHK(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 832f - 1170f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m01 = 1849f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m02 = 251f * EHGILAHLMIB[0] * EHGILAHLMIB[3];
			LNFAMODBJIH.m03 = 1746f * EHGILAHLMIB[5] * EHGILAHLMIB[0];
			LNFAMODBJIH.m10 = 145f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m11 = 60f - 980f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m12 = 1048f * EHGILAHLMIB[1] * EHGILAHLMIB[6];
			LNFAMODBJIH.m13 = 422f * EHGILAHLMIB[8] * EHGILAHLMIB[0];
			LNFAMODBJIH.m20 = 1414f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m21 = 10f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m22 = 134f - 1442f * EHGILAHLMIB[8] * EHGILAHLMIB[2];
			LNFAMODBJIH.m23 = 261f * EHGILAHLMIB[7] * EHGILAHLMIB[4];
			LNFAMODBJIH.m30 = 1486f;
			LNFAMODBJIH.m31 = 968f;
			LNFAMODBJIH.m32 = 1128f;
			LNFAMODBJIH.m33 = 971f;
		}

		// Token: 0x0600B167 RID: 45415 RVA: 0x004D341C File Offset: 0x004D161C
		public void AKHNCEGDJKF()
		{
			if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if (!current)
			{
				return;
			}
			if (Water.EHHACHJBEND)
			{
				return;
			}
			Water.EHHACHJBEND = false;
			this.BMEFHDIJNEC = this.DKMKADGPBBM();
			Water.APCMOMEJFDP apcmomejfdp = this.HNDMNGHOFKO();
			Camera camera;
			Camera camera2;
			this.BHDHNINBLDI(current, out camera, out camera2);
			Vector3 position = base.transform.position;
			Vector3 up = base.transform.up;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = 1;
			}
			this.ACGHDPEPEHC(current, camera);
			this.HDGAGNDDKJE(current, camera2);
			if (apcmomejfdp >= Water.APCMOMEJFDP.Simple)
			{
				float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
				Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
				Matrix4x4 zero = Matrix4x4.zero;
				Water.ENPIEPOIDGI(ref zero, ehgilahlmib);
				Vector3 position2 = current.transform.position;
				Vector3 position3 = zero.MultiplyPoint(position2);
				camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
				Vector4 clipPlane = this.OJJKJIPGPEK(camera, position, up, 443f);
				camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
				camera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera.cullingMask = (87 & this.reflectLayers.value);
				camera.targetTexture = this.EACNIDNGPBL;
				bool invertCulling = GL.invertCulling;
				GL.invertCulling = invertCulling;
				camera.transform.position = position3;
				Vector3 eulerAngles = current.transform.eulerAngles;
				camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
				camera.Render();
				camera.transform.position = position2;
				GL.invertCulling = invertCulling;
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("BowInstant", this.EACNIDNGPBL);
			}
			if (apcmomejfdp >= (Water.APCMOMEJFDP)5)
			{
				camera2.worldToCameraMatrix = current.worldToCameraMatrix;
				Vector4 clipPlane2 = this.FGIFMANIMFE(camera2, position, up, 1505f);
				camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
				camera2.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera2.cullingMask = (124 & this.refractLayers.value);
				camera2.targetTexture = this.JDMOBHGACDO;
				camera2.transform.position = current.transform.position;
				camera2.transform.rotation = current.transform.rotation;
				camera2.Render();
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("Flap_08.wav", this.JDMOBHGACDO);
			}
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = pixelLightCount;
			}
			switch (apcmomejfdp)
			{
			case Water.APCMOMEJFDP.Simple:
				Shader.EnableKeyword("!");
				Shader.DisableKeyword("OneHandSwordReady");
				Shader.DisableKeyword("wpn_fid2");
				break;
			case Water.APCMOMEJFDP.Reflective:
				Shader.DisableKeyword("SAMPLES_VERY_LOW");
				Shader.EnableKeyword("WeaponStrafeRunRight");
				Shader.DisableKeyword("Assets/Weapons/wbaseJaket.unity3d");
				break;
			case Water.APCMOMEJFDP.Refractive:
				Shader.DisableKeyword("Vector2: ");
				Shader.DisableKeyword("How your lives count is stored in memory when obscured:\n");
				Shader.EnableKeyword("inv_pers");
				break;
			}
			Water.EHHACHJBEND = true;
		}

		// Token: 0x0600B168 RID: 45416 RVA: 0x004D3764 File Offset: 0x004D1964
		private Water.APCMOMEJFDP CGILAHHEGKF()
		{
			if (!base.GetComponent<Renderer>())
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return Water.APCMOMEJFDP.Simple;
			}
			string tag = sharedMaterial.GetTag("", false);
			if (tag == "MotorbikeTurnRight")
			{
				return (Water.APCMOMEJFDP)3;
			}
			if (tag == "SAMPLES_MEDIUM")
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			return Water.APCMOMEJFDP.Simple;
		}

		// Token: 0x0600B169 RID: 45417 RVA: 0x004D37C4 File Offset: 0x004D19C4
		public void EABHFHKJGCP()
		{
			if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if (!current)
			{
				return;
			}
			if (Water.EHHACHJBEND)
			{
				return;
			}
			Water.EHHACHJBEND = true;
			this.BMEFHDIJNEC = this.PKKJGMCIMBJ();
			Water.APCMOMEJFDP apcmomejfdp = this.OAPDNMDGMOJ();
			Camera camera;
			Camera camera2;
			this.ACNKHDPJCEH(current, out camera, out camera2);
			Vector3 position = base.transform.position;
			Vector3 up = base.transform.up;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = 0;
			}
			this.MHFPELLBKDG(current, camera);
			this.JIJHJOMBAPD(current, camera2);
			if (apcmomejfdp >= Water.APCMOMEJFDP.Reflective)
			{
				float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
				Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
				Matrix4x4 zero = Matrix4x4.zero;
				Water.JHEOCCJMBOD(ref zero, ehgilahlmib);
				Vector3 position2 = current.transform.position;
				Vector3 position3 = zero.MultiplyPoint(position2);
				camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
				Vector4 clipPlane = this.PEPOIHMJCGN(camera, position, up, 1396f);
				camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
				camera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera.cullingMask = (109 & this.reflectLayers.value);
				camera.targetTexture = this.EACNIDNGPBL;
				bool invertCulling = GL.invertCulling;
				GL.invertCulling = !invertCulling;
				camera.transform.position = position3;
				Vector3 eulerAngles = current.transform.eulerAngles;
				camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
				camera.Render();
				camera.transform.position = position2;
				GL.invertCulling = invertCulling;
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("getfish", this.EACNIDNGPBL);
			}
			if (apcmomejfdp >= (Water.APCMOMEJFDP)6)
			{
				camera2.worldToCameraMatrix = current.worldToCameraMatrix;
				Vector4 clipPlane2 = this.FHKEKEABFBE(camera2, position, up, 999f);
				camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
				camera2.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera2.cullingMask = (-33 & this.refractLayers.value);
				camera2.targetTexture = this.JDMOBHGACDO;
				camera2.transform.position = current.transform.position;
				camera2.transform.rotation = current.transform.rotation;
				camera2.Render();
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("BowReady2", this.JDMOBHGACDO);
			}
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = pixelLightCount;
			}
			switch (apcmomejfdp)
			{
			case Water.APCMOMEJFDP.Simple:
				Shader.EnableKeyword("_ProjInfo");
				Shader.DisableKeyword("blesna.ogg");
				Shader.DisableKeyword("_ALPHABLEND_ON");
				break;
			case Water.APCMOMEJFDP.Reflective:
				Shader.DisableKeyword("Steam Overlay has been activated");
				Shader.EnableKeyword("wpn_rod2");
				Shader.DisableKeyword("_DelItem.wav");
				break;
			case Water.APCMOMEJFDP.Refractive:
				Shader.DisableKeyword(">> 2 >>");
				Shader.DisableKeyword("{0} x {1}");
				Shader.EnableKeyword("OfficeSitting");
				break;
			}
			Water.EHHACHJBEND = false;
		}

		// Token: 0x0600B16A RID: 45418 RVA: 0x004D3B0C File Offset: 0x004D1D0C
		private void CBOPELHIMHK(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA, out Camera CBJAOAMGJBN)
		{
			Water.APCMOMEJFDP apcmomejfdp = this.NILDJEMFMEO();
			OAMNCKHIPLA = null;
			CBJAOAMGJBN = null;
			if (apcmomejfdp >= Water.APCMOMEJFDP.Reflective)
			{
				if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.textureSize)
				{
					if (this.EACNIDNGPBL)
					{
						UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
					}
					this.EACNIDNGPBL = new RenderTexture(this.textureSize, this.textureSize, -25);
					this.EACNIDNGPBL.name = "14" + base.GetInstanceID();
					this.EACNIDNGPBL.isPowerOfTwo = false;
					this.EACNIDNGPBL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
					this.DHBOBNEFLOG = this.textureSize;
				}
				this.BMOECLNNGDF.TryGetValue(GGEHECFCPMD, out OAMNCKHIPLA);
				if (!OAMNCKHIPLA)
				{
					object[] array = new object[7];
					array[0] = "SUNSHINE_OVERCAST_OFF";
					array[0] = base.GetInstanceID();
					array[4] = "gi_um_nosel";
					array[4] = GGEHECFCPMD.GetInstanceID();
					string name = string.Concat(array);
					Type[] array2 = new Type[1];
					array2[1] = typeof(Camera);
					array2[0] = typeof(Skybox);
					GameObject gameObject = new GameObject(name, array2);
					OAMNCKHIPLA = gameObject.GetComponent<Camera>();
					OAMNCKHIPLA.enabled = false;
					OAMNCKHIPLA.transform.position = base.transform.position;
					OAMNCKHIPLA.transform.rotation = base.transform.rotation;
					OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
					gameObject.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
					this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
				}
			}
			if (apcmomejfdp >= (Water.APCMOMEJFDP)5)
			{
				if (!this.JDMOBHGACDO || this.IJOHEFCCBGG != this.textureSize)
				{
					if (this.JDMOBHGACDO)
					{
						UnityEngine.Object.DestroyImmediate(this.JDMOBHGACDO);
					}
					this.JDMOBHGACDO = new RenderTexture(this.textureSize, this.textureSize, 88);
					this.JDMOBHGACDO.name = "InterfaceLang.txt" + base.GetInstanceID();
					this.JDMOBHGACDO.isPowerOfTwo = true;
					this.JDMOBHGACDO.hideFlags = (HideFlags)(-110);
					this.IJOHEFCCBGG = this.textureSize;
				}
				this.BLBAJIPMMEI.TryGetValue(GGEHECFCPMD, out CBJAOAMGJBN);
				if (!CBJAOAMGJBN)
				{
					object[] array3 = new object[8];
					array3[0] = "t_eye";
					array3[0] = base.GetInstanceID();
					array3[6] = "Reset";
					array3[6] = GGEHECFCPMD.GetInstanceID();
					string name2 = string.Concat(array3);
					Type[] array4 = new Type[7];
					array4[1] = typeof(Camera);
					array4[1] = typeof(Skybox);
					GameObject gameObject2 = new GameObject(name2, array4);
					CBJAOAMGJBN = gameObject2.GetComponent<Camera>();
					CBJAOAMGJBN.enabled = true;
					CBJAOAMGJBN.transform.position = base.transform.position;
					CBJAOAMGJBN.transform.rotation = base.transform.rotation;
					CBJAOAMGJBN.gameObject.AddComponent<FlareLayer>();
					gameObject2.hideFlags = (HideFlags)115;
					this.BLBAJIPMMEI[GGEHECFCPMD] = CBJAOAMGJBN;
				}
			}
		}

		// Token: 0x0600B16B RID: 45419 RVA: 0x004D3E08 File Offset: 0x004D2008
		private Water.APCMOMEJFDP MLODCFOBDGF()
		{
			if (!base.GetComponent<Renderer>())
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			string tag = sharedMaterial.GetTag("WeaponReload", true);
			if (tag == "Hidden/Post FX/Fog")
			{
				return (Water.APCMOMEJFDP)7;
			}
			if (tag == "FBBIKSettings is deprecated, you can now edit all the settings from the custom inspector of the FullBodyBipedIK component.")
			{
				return Water.APCMOMEJFDP.Simple;
			}
			return Water.APCMOMEJFDP.Simple;
		}

		// Token: 0x0600B16C RID: 45420 RVA: 0x004D3E68 File Offset: 0x004D2068
		private void OJNHEMINLGD(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
		{
			if (OLFKAHHACBC == null)
			{
				return;
			}
			OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
			OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
			if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
			{
				Skybox component = BNDNKLBIJJF.GetComponent<Skybox>();
				Skybox component2 = OLFKAHHACBC.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = false;
				}
				else
				{
					component2.enabled = true;
					component2.material = component.material;
				}
			}
			OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
			OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
			OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
			OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
			OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
			OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		}

		// Token: 0x0600B16D RID: 45421 RVA: 0x004D2E9A File Offset: 0x004D109A
		private Water.APCMOMEJFDP NILDJEMFMEO()
		{
			if (this.BMEFHDIJNEC < this.waterMode)
			{
				return this.BMEFHDIJNEC;
			}
			return this.waterMode;
		}

		// Token: 0x0600B16E RID: 45422 RVA: 0x004D3F28 File Offset: 0x004D2128
		private void LMMDHJJJNJO()
		{
			if (!base.GetComponent<Renderer>())
			{
				return;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("<color='#602060'>");
			float @float = sharedMaterial.GetFloat("_InverseProj");
			Vector4 vector2 = new Vector4(@float, @float, @float * 252f, @float * 1763f);
			double num = (double)Time.timeSinceLevelLoad / 1006.0;
			Vector4 value = new Vector4((float)Math.IEEERemainder((double)(vector.x * vector2.x) * num, 458.0), (float)Math.IEEERemainder((double)(vector.y * vector2.y) * num, 557.0), (float)Math.IEEERemainder((double)(vector.z * vector2.z) * num, 1971.0), (float)Math.IEEERemainder((double)(vector.w * vector2.w) * num, 1334.0));
			sharedMaterial.SetVector("Current fog preset: ", value);
			sharedMaterial.SetVector("Player", vector2);
		}

		// Token: 0x0600B16F RID: 45423 RVA: 0x004D403C File Offset: 0x004D223C
		private void MHFPELLBKDG(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
		{
			if (OLFKAHHACBC == null)
			{
				return;
			}
			OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
			OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
			if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
			{
				Skybox component = BNDNKLBIJJF.GetComponent<Skybox>();
				Skybox component2 = OLFKAHHACBC.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = true;
				}
				else
				{
					component2.enabled = false;
					component2.material = component.material;
				}
			}
			OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
			OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
			OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
			OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
			OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
			OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		}

		// Token: 0x0600B170 RID: 45424 RVA: 0x004D40FC File Offset: 0x004D22FC
		private void LIOCDEICIFD()
		{
			if (!base.GetComponent<Renderer>())
			{
				return;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("");
			float @float = sharedMaterial.GetFloat("360SpinDeath");
			Vector4 vector2 = new Vector4(@float, @float, @float * 31f, @float * 1658f);
			double num = (double)Time.timeSinceLevelLoad / 1009.0;
			Vector4 value = new Vector4((float)Math.IEEERemainder((double)(vector.x * vector2.x) * num, 467.0), (float)Math.IEEERemainder((double)(vector.y * vector2.y) * num, 27.0), (float)Math.IEEERemainder((double)(vector.z * vector2.z) * num, 316.0), (float)Math.IEEERemainder((double)(vector.w * vector2.w) * num, 1013.0));
			sharedMaterial.SetVector("\n", value);
			sharedMaterial.SetVector("_DitherTexture", vector2);
		}

		// Token: 0x0600B171 RID: 45425 RVA: 0x004D4210 File Offset: 0x004D2410
		private static void FICALOMGIJF(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 614f - 247f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m01 = 883f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
			LNFAMODBJIH.m02 = 1088f * EHGILAHLMIB[1] * EHGILAHLMIB[5];
			LNFAMODBJIH.m03 = 759f * EHGILAHLMIB[5] * EHGILAHLMIB[0];
			LNFAMODBJIH.m10 = 1975f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m11 = 787f - 1508f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m12 = 75f * EHGILAHLMIB[0] * EHGILAHLMIB[5];
			LNFAMODBJIH.m13 = 508f * EHGILAHLMIB[8] * EHGILAHLMIB[0];
			LNFAMODBJIH.m20 = 1083f * EHGILAHLMIB[2] * EHGILAHLMIB[0];
			LNFAMODBJIH.m21 = 1244f * EHGILAHLMIB[8] * EHGILAHLMIB[1];
			LNFAMODBJIH.m22 = 1879f - 1368f * EHGILAHLMIB[4] * EHGILAHLMIB[6];
			LNFAMODBJIH.m23 = 1223f * EHGILAHLMIB[1] * EHGILAHLMIB[2];
			LNFAMODBJIH.m30 = 1454f;
			LNFAMODBJIH.m31 = 661f;
			LNFAMODBJIH.m32 = 312f;
			LNFAMODBJIH.m33 = 1184f;
		}

		// Token: 0x0600B172 RID: 45426 RVA: 0x004D43B8 File Offset: 0x004D25B8
		private static void HPPHMCAJCNG(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 1098f - 636f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m01 = 1641f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m02 = 1189f * EHGILAHLMIB[0] * EHGILAHLMIB[8];
			LNFAMODBJIH.m03 = 803f * EHGILAHLMIB[5] * EHGILAHLMIB[1];
			LNFAMODBJIH.m10 = 1939f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m11 = 1568f - 1585f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m12 = 1240f * EHGILAHLMIB[1] * EHGILAHLMIB[8];
			LNFAMODBJIH.m13 = 921f * EHGILAHLMIB[7] * EHGILAHLMIB[1];
			LNFAMODBJIH.m20 = 12f * EHGILAHLMIB[7] * EHGILAHLMIB[0];
			LNFAMODBJIH.m21 = 149f * EHGILAHLMIB[4] * EHGILAHLMIB[0];
			LNFAMODBJIH.m22 = 1015f - 1619f * EHGILAHLMIB[4] * EHGILAHLMIB[5];
			LNFAMODBJIH.m23 = 1933f * EHGILAHLMIB[1] * EHGILAHLMIB[8];
			LNFAMODBJIH.m30 = 1079f;
			LNFAMODBJIH.m31 = 1180f;
			LNFAMODBJIH.m32 = 510f;
			LNFAMODBJIH.m33 = 1714f;
		}

		// Token: 0x0600B173 RID: 45427 RVA: 0x004D4560 File Offset: 0x004D2760
		private static void EOENPIGCNCN(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 495f - 569f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m01 = 1220f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m02 = 1995f * EHGILAHLMIB[0] * EHGILAHLMIB[7];
			LNFAMODBJIH.m03 = 268f * EHGILAHLMIB[5] * EHGILAHLMIB[1];
			LNFAMODBJIH.m10 = 1835f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m11 = 1645f - 540f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m12 = 153f * EHGILAHLMIB[0] * EHGILAHLMIB[7];
			LNFAMODBJIH.m13 = 870f * EHGILAHLMIB[4] * EHGILAHLMIB[1];
			LNFAMODBJIH.m20 = 950f * EHGILAHLMIB[5] * EHGILAHLMIB[0];
			LNFAMODBJIH.m21 = 1631f * EHGILAHLMIB[2] * EHGILAHLMIB[1];
			LNFAMODBJIH.m22 = 1187f - 1311f * EHGILAHLMIB[3] * EHGILAHLMIB[0];
			LNFAMODBJIH.m23 = 188f * EHGILAHLMIB[6] * EHGILAHLMIB[6];
			LNFAMODBJIH.m30 = 1787f;
			LNFAMODBJIH.m31 = 529f;
			LNFAMODBJIH.m32 = 1748f;
			LNFAMODBJIH.m33 = 1038f;
		}

		// Token: 0x0600B174 RID: 45428 RVA: 0x004D4708 File Offset: 0x004D2908
		private Water.APCMOMEJFDP AHFPFGLCBCI()
		{
			if (!base.GetComponent<Renderer>())
			{
				return Water.APCMOMEJFDP.Simple;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			string tag = sharedMaterial.GetTag("fider_Small_", true);
			if (tag == "Wall hack Detected!")
			{
				return (Water.APCMOMEJFDP)3;
			}
			if (tag == "1HandSwordJabCombo")
			{
				return Water.APCMOMEJFDP.Simple;
			}
			return Water.APCMOMEJFDP.Simple;
		}

		// Token: 0x0600B175 RID: 45429 RVA: 0x004D4768 File Offset: 0x004D2968
		private Vector4 OJJKJIPGPEK(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
		{
			Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
			return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
		}

		// Token: 0x0600B176 RID: 45430 RVA: 0x004D47D0 File Offset: 0x004D29D0
		public void PNFFAOGFGDJ()
		{
			if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if (!current)
			{
				return;
			}
			if (Water.EHHACHJBEND)
			{
				return;
			}
			Water.EHHACHJBEND = false;
			this.BMEFHDIJNEC = this.HCLLFEPLOCI();
			Water.APCMOMEJFDP apcmomejfdp = this.OAPDNMDGMOJ();
			Camera camera;
			Camera camera2;
			this.ACNKHDPJCEH(current, out camera, out camera2);
			Vector3 position = base.transform.position;
			Vector3 up = base.transform.up;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = 0;
			}
			this.NPIOCACDHJO(current, camera);
			this.HDGAGNDDKJE(current, camera2);
			if (apcmomejfdp >= Water.APCMOMEJFDP.Simple)
			{
				float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
				Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
				Matrix4x4 zero = Matrix4x4.zero;
				Water.FICALOMGIJF(ref zero, ehgilahlmib);
				Vector3 position2 = current.transform.position;
				Vector3 position3 = zero.MultiplyPoint(position2);
				camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
				Vector4 clipPlane = this.NOGIAMIBLBN(camera, position, up, 1570f);
				camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
				camera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera.cullingMask = (-12 & this.reflectLayers.value);
				camera.targetTexture = this.EACNIDNGPBL;
				bool invertCulling = GL.invertCulling;
				GL.invertCulling = !invertCulling;
				camera.transform.position = position3;
				Vector3 eulerAngles = current.transform.eulerAngles;
				camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
				camera.Render();
				camera.transform.position = position2;
				GL.invertCulling = invertCulling;
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("Hips", this.EACNIDNGPBL);
			}
			if (apcmomejfdp >= (Water.APCMOMEJFDP)8)
			{
				camera2.worldToCameraMatrix = current.worldToCameraMatrix;
				Vector4 clipPlane2 = this.NGGOBAJNHPH(camera2, position, up, 333f);
				camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
				camera2.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera2.cullingMask = (-104 & this.refractLayers.value);
				camera2.targetTexture = this.JDMOBHGACDO;
				camera2.transform.position = current.transform.position;
				camera2.transform.rotation = current.transform.rotation;
				camera2.Render();
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("", this.JDMOBHGACDO);
			}
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = pixelLightCount;
			}
			switch (apcmomejfdp)
			{
			case Water.APCMOMEJFDP.Simple:
				Shader.EnableKeyword("_Lift");
				Shader.DisableKeyword("_BlurVector");
				Shader.DisableKeyword("PrimaryCausticsProjector");
				break;
			case Water.APCMOMEJFDP.Reflective:
				Shader.DisableKeyword("_Offsets");
				Shader.EnableKeyword("* *");
				Shader.DisableKeyword("Flap_08.wav");
				break;
			case Water.APCMOMEJFDP.Refractive:
				Shader.DisableKeyword("MaskMaterial");
				Shader.DisableKeyword("error");
				Shader.EnableKeyword("ActiveIcons.xml");
				break;
			}
			Water.EHHACHJBEND = false;
		}

		// Token: 0x0600B177 RID: 45431 RVA: 0x004D4B18 File Offset: 0x004D2D18
		private Water.APCMOMEJFDP DKMKADGPBBM()
		{
			if (!base.GetComponent<Renderer>())
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			string tag = sharedMaterial.GetTag("OfficeSittingReadingCoffeeSip", true);
			if (tag == "The shader ")
			{
				return Water.APCMOMEJFDP.Refractive;
			}
			if (tag == "MAP_NAMES")
			{
				return Water.APCMOMEJFDP.Simple;
			}
			return Water.APCMOMEJFDP.Reflective;
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x004D4B78 File Offset: 0x004D2D78
		private Vector4 FHKEKEABFBE(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
		{
			Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
			return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
		}

		// Token: 0x0600B179 RID: 45433 RVA: 0x004D4BE0 File Offset: 0x004D2DE0
		public void POAEHDJLCPH()
		{
			if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if (!current)
			{
				return;
			}
			if (Water.EHHACHJBEND)
			{
				return;
			}
			Water.EHHACHJBEND = true;
			this.BMEFHDIJNEC = this.AHFPFGLCBCI();
			Water.APCMOMEJFDP apcmomejfdp = this.HNDMNGHOFKO();
			Camera camera;
			Camera camera2;
			this.FKKJAJFOHCP(current, out camera, out camera2);
			Vector3 position = base.transform.position;
			Vector3 up = base.transform.up;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = 1;
			}
			this.GJCMIDFODJD(current, camera);
			this.BJIHAKKLKJF(current, camera2);
			if (apcmomejfdp >= Water.APCMOMEJFDP.Simple)
			{
				float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
				Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
				Matrix4x4 zero = Matrix4x4.zero;
				Water.FICALOMGIJF(ref zero, ehgilahlmib);
				Vector3 position2 = current.transform.position;
				Vector3 position3 = zero.MultiplyPoint(position2);
				camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
				Vector4 clipPlane = this.GIEAAMOLKAJ(camera, position, up, 483f);
				camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
				camera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera.cullingMask = (66 & this.reflectLayers.value);
				camera.targetTexture = this.EACNIDNGPBL;
				bool invertCulling = GL.invertCulling;
				GL.invertCulling = !invertCulling;
				camera.transform.position = position3;
				Vector3 eulerAngles = current.transform.eulerAngles;
				camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
				camera.Render();
				camera.transform.position = position2;
				GL.invertCulling = invertCulling;
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("WizardOverhead", this.EACNIDNGPBL);
			}
			if (apcmomejfdp >= (Water.APCMOMEJFDP)7)
			{
				camera2.worldToCameraMatrix = current.worldToCameraMatrix;
				Vector4 clipPlane2 = this.DNKGLEKBDEC(camera2, position, up, 1240f);
				camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
				camera2.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera2.cullingMask = (111 & this.refractLayers.value);
				camera2.targetTexture = this.JDMOBHGACDO;
				camera2.transform.position = current.transform.position;
				camera2.transform.rotation = current.transform.rotation;
				camera2.Render();
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("fishRSPEED=", this.JDMOBHGACDO);
			}
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = pixelLightCount;
			}
			switch (apcmomejfdp)
			{
			case Water.APCMOMEJFDP.Simple:
				Shader.EnableKeyword("______________________________");
				Shader.DisableKeyword("No valid adaptive tonemapper type found!");
				Shader.DisableKeyword("The space size '");
				break;
			case Water.APCMOMEJFDP.Reflective:
				Shader.DisableKeyword("qd_prise_exp");
				Shader.EnableKeyword("_WaterMap");
				Shader.DisableKeyword("RollerBladeBackFlip");
				break;
			case Water.APCMOMEJFDP.Refractive:
				Shader.DisableKeyword("_Power");
				Shader.DisableKeyword("MotorbikeWheelyNoHands");
				Shader.EnableKeyword("#2080ff");
				break;
			}
			Water.EHHACHJBEND = true;
		}

		// Token: 0x0600B17A RID: 45434 RVA: 0x004D4F28 File Offset: 0x004D3128
		private Water.APCMOMEJFDP PKKJGMCIMBJ()
		{
			if (!base.GetComponent<Renderer>())
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			string tag = sharedMaterial.GetTag("_Source", false);
			if (tag == "BlurDepthTolerance")
			{
				return Water.APCMOMEJFDP.Simple;
			}
			if (tag == "OfficeSittingHandRestFingerTap")
			{
				return Water.APCMOMEJFDP.Simple;
			}
			return Water.APCMOMEJFDP.Simple;
		}

		// Token: 0x0600B17B RID: 45435 RVA: 0x004D4F88 File Offset: 0x004D3188
		private void Update()
		{
			if (!base.GetComponent<Renderer>())
			{
				return;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector("WaveSpeed");
			float @float = sharedMaterial.GetFloat("_WaveScale");
			Vector4 vector2 = new Vector4(@float, @float, @float * 0.4f, @float * 0.45f);
			double num = (double)Time.timeSinceLevelLoad / 20.0;
			Vector4 value = new Vector4((float)Math.IEEERemainder((double)(vector.x * vector2.x) * num, 1.0), (float)Math.IEEERemainder((double)(vector.y * vector2.y) * num, 1.0), (float)Math.IEEERemainder((double)(vector.z * vector2.z) * num, 1.0), (float)Math.IEEERemainder((double)(vector.w * vector2.w) * num, 1.0));
			sharedMaterial.SetVector("_WaveOffset", value);
			sharedMaterial.SetVector("_WaveScale4", vector2);
		}

		// Token: 0x0600B17C RID: 45436 RVA: 0x004D509C File Offset: 0x004D329C
		public void OPAECGICFAN()
		{
			if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if (!current)
			{
				return;
			}
			if (Water.EHHACHJBEND)
			{
				return;
			}
			Water.EHHACHJBEND = true;
			this.BMEFHDIJNEC = this.CGILAHHEGKF();
			Water.APCMOMEJFDP apcmomejfdp = this.GHHLOHPIKOH();
			Camera camera;
			Camera camera2;
			this.DPGPJFDPGOP(current, out camera, out camera2);
			Vector3 position = base.transform.position;
			Vector3 up = base.transform.up;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = 0;
			}
			this.BJIHAKKLKJF(current, camera);
			this.PJFCOKNCDEA(current, camera2);
			if (apcmomejfdp >= Water.APCMOMEJFDP.Reflective)
			{
				float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
				Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
				Matrix4x4 zero = Matrix4x4.zero;
				Water.EOENPIGCNCN(ref zero, ehgilahlmib);
				Vector3 position2 = current.transform.position;
				Vector3 position3 = zero.MultiplyPoint(position2);
				camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
				Vector4 clipPlane = this.GIEAAMOLKAJ(camera, position, up, 628f);
				camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
				camera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera.cullingMask = (96 & this.reflectLayers.value);
				camera.targetTexture = this.EACNIDNGPBL;
				bool invertCulling = GL.invertCulling;
				GL.invertCulling = invertCulling;
				camera.transform.position = position3;
				Vector3 eulerAngles = current.transform.eulerAngles;
				camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
				camera.Render();
				camera.transform.position = position2;
				GL.invertCulling = invertCulling;
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("Loading Asset Bundle ", this.EACNIDNGPBL);
			}
			if (apcmomejfdp >= (Water.APCMOMEJFDP)6)
			{
				camera2.worldToCameraMatrix = current.worldToCameraMatrix;
				Vector4 clipPlane2 = this.PEPOIHMJCGN(camera2, position, up, 276f);
				camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
				camera2.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera2.cullingMask = (29 & this.refractLayers.value);
				camera2.targetTexture = this.JDMOBHGACDO;
				camera2.transform.position = current.transform.position;
				camera2.transform.rotation = current.transform.rotation;
				camera2.Render();
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("Turn", this.JDMOBHGACDO);
			}
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = pixelLightCount;
			}
			switch (apcmomejfdp)
			{
			case Water.APCMOMEJFDP.Simple:
				Shader.EnableKeyword("&");
				Shader.DisableKeyword("");
				Shader.DisableKeyword("WorkerPickaxe2");
				break;
			case Water.APCMOMEJFDP.Reflective:
				Shader.DisableKeyword("lifeBar");
				Shader.EnableKeyword("_FresnelFadePower");
				Shader.DisableKeyword("t_much");
				break;
			case Water.APCMOMEJFDP.Refractive:
				Shader.DisableKeyword("WeaponRun");
				Shader.DisableKeyword("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
				Shader.EnableKeyword("bs_noprip");
				break;
			}
			Water.EHHACHJBEND = true;
		}

		// Token: 0x0600B17D RID: 45437 RVA: 0x004D53E4 File Offset: 0x004D35E4
		private void IEOICHPKEMD()
		{
			if (!base.GetComponent<Renderer>())
			{
				return;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return;
			}
			Vector4 vector = sharedMaterial.GetVector(" x");
			float @float = sharedMaterial.GetFloat("[wtemplid]");
			Vector4 vector2 = new Vector4(@float, @float, @float * 1571f, @float * 321f);
			double num = (double)Time.timeSinceLevelLoad / 428.0;
			Vector4 value = new Vector4((float)Math.IEEERemainder((double)(vector.x * vector2.x) * num, 1874.0), (float)Math.IEEERemainder((double)(vector.y * vector2.y) * num, 668.0), (float)Math.IEEERemainder((double)(vector.z * vector2.z) * num, 734.0), (float)Math.IEEERemainder((double)(vector.w * vector2.w) * num, 1912.0));
			sharedMaterial.SetVector("ShotgunReloadChamber", value);
			sharedMaterial.SetVector("_PixelsPerMeterAtOneMeter", vector2);
		}

		// Token: 0x0600B17E RID: 45438 RVA: 0x004D54F8 File Offset: 0x004D36F8
		private Vector4 DNKGLEKBDEC(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
		{
			Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
			return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
		}

		// Token: 0x0600B17F RID: 45439 RVA: 0x004D2E9A File Offset: 0x004D109A
		private Water.APCMOMEJFDP OAPDNMDGMOJ()
		{
			if (this.BMEFHDIJNEC < this.waterMode)
			{
				return this.BMEFHDIJNEC;
			}
			return this.waterMode;
		}

		// Token: 0x0600B181 RID: 45441 RVA: 0x004D55CC File Offset: 0x004D37CC
		private void CJGCKOAJPKD(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA, out Camera CBJAOAMGJBN)
		{
			Water.APCMOMEJFDP apcmomejfdp = this.HNDMNGHOFKO();
			OAMNCKHIPLA = null;
			CBJAOAMGJBN = null;
			if (apcmomejfdp >= Water.APCMOMEJFDP.Simple)
			{
				if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.textureSize)
				{
					if (this.EACNIDNGPBL)
					{
						UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
					}
					this.EACNIDNGPBL = new RenderTexture(this.textureSize, this.textureSize, -104);
					this.EACNIDNGPBL.name = "WateringCanWatering" + base.GetInstanceID();
					this.EACNIDNGPBL.isPowerOfTwo = false;
					this.EACNIDNGPBL.hideFlags = (HideFlags)(-73);
					this.DHBOBNEFLOG = this.textureSize;
				}
				this.BMOECLNNGDF.TryGetValue(GGEHECFCPMD, out OAMNCKHIPLA);
				if (!OAMNCKHIPLA)
				{
					object[] array = new object[8];
					array[1] = "UV2";
					array[1] = base.GetInstanceID();
					array[2] = "";
					array[3] = GGEHECFCPMD.GetInstanceID();
					string name = string.Concat(array);
					Type[] array2 = new Type[1];
					array2[1] = typeof(Camera);
					array2[1] = typeof(Skybox);
					GameObject gameObject = new GameObject(name, array2);
					OAMNCKHIPLA = gameObject.GetComponent<Camera>();
					OAMNCKHIPLA.enabled = true;
					OAMNCKHIPLA.transform.position = base.transform.position;
					OAMNCKHIPLA.transform.rotation = base.transform.rotation;
					OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
					gameObject.hideFlags = (HideFlags)(-102);
					this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
				}
			}
			if (apcmomejfdp >= Water.APCMOMEJFDP.Simple)
			{
				if (!this.JDMOBHGACDO || this.IJOHEFCCBGG != this.textureSize)
				{
					if (this.JDMOBHGACDO)
					{
						UnityEngine.Object.DestroyImmediate(this.JDMOBHGACDO);
					}
					this.JDMOBHGACDO = new RenderTexture(this.textureSize, this.textureSize, -33);
					this.JDMOBHGACDO.name = "Bend Constraint is referencing to a bone '" + base.GetInstanceID();
					this.JDMOBHGACDO.isPowerOfTwo = true;
					this.JDMOBHGACDO.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
					this.IJOHEFCCBGG = this.textureSize;
				}
				this.BLBAJIPMMEI.TryGetValue(GGEHECFCPMD, out CBJAOAMGJBN);
				if (!CBJAOAMGJBN)
				{
					object[] array3 = new object[2];
					array3[0] = "WandAttack";
					array3[0] = base.GetInstanceID();
					array3[0] = "BEREG!";
					array3[3] = GGEHECFCPMD.GetInstanceID();
					GameObject gameObject2 = new GameObject(string.Concat(array3), new Type[]
					{
						typeof(Camera),
						typeof(Skybox)
					});
					CBJAOAMGJBN = gameObject2.GetComponent<Camera>();
					CBJAOAMGJBN.enabled = true;
					CBJAOAMGJBN.transform.position = base.transform.position;
					CBJAOAMGJBN.transform.rotation = base.transform.rotation;
					CBJAOAMGJBN.gameObject.AddComponent<FlareLayer>();
					gameObject2.hideFlags = (HideFlags)(-70);
					this.BLBAJIPMMEI[GGEHECFCPMD] = CBJAOAMGJBN;
				}
			}
		}

		// Token: 0x0600B182 RID: 45442 RVA: 0x004D58C8 File Offset: 0x004D3AC8
		public void HPGAEPLKEKF()
		{
			if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if (!current)
			{
				return;
			}
			if (Water.EHHACHJBEND)
			{
				return;
			}
			Water.EHHACHJBEND = true;
			this.BMEFHDIJNEC = this.CGILAHHEGKF();
			Water.APCMOMEJFDP apcmomejfdp = this.HNDMNGHOFKO();
			Camera camera;
			Camera camera2;
			this.CJGCKOAJPKD(current, out camera, out camera2);
			Vector3 position = base.transform.position;
			Vector3 up = base.transform.up;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = 0;
			}
			this.FDBCKDFGDJB(current, camera);
			this.OJNHEMINLGD(current, camera2);
			if (apcmomejfdp >= Water.APCMOMEJFDP.Simple)
			{
				float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
				Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
				Matrix4x4 zero = Matrix4x4.zero;
				Water.KACJIDCODHK(ref zero, ehgilahlmib);
				Vector3 position2 = current.transform.position;
				Vector3 position3 = zero.MultiplyPoint(position2);
				camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
				Vector4 clipPlane = this.FGIFMANIMFE(camera, position, up, 303f);
				camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
				camera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera.cullingMask = (7 & this.reflectLayers.value);
				camera.targetTexture = this.EACNIDNGPBL;
				bool invertCulling = GL.invertCulling;
				GL.invertCulling = !invertCulling;
				camera.transform.position = position3;
				Vector3 eulerAngles = current.transform.eulerAngles;
				camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
				camera.Render();
				camera.transform.position = position2;
				GL.invertCulling = invertCulling;
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("NprPhysPoint", this.EACNIDNGPBL);
			}
			if (apcmomejfdp >= Water.APCMOMEJFDP.Reflective)
			{
				camera2.worldToCameraMatrix = current.worldToCameraMatrix;
				Vector4 clipPlane2 = this.FPBKMANKFBP(camera2, position, up, 100f);
				camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
				camera2.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera2.cullingMask = (-121 & this.refractLayers.value);
				camera2.targetTexture = this.JDMOBHGACDO;
				camera2.transform.position = current.transform.position;
				camera2.transform.rotation = current.transform.rotation;
				camera2.Render();
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("<color='#6080ff'>", this.JDMOBHGACDO);
			}
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = pixelLightCount;
			}
			switch (apcmomejfdp)
			{
			case Water.APCMOMEJFDP.Simple:
				Shader.EnableKeyword("CheerKnees");
				Shader.DisableKeyword("_DistortParams");
				Shader.DisableKeyword("OnStatusChanged UNKNOW ");
				break;
			case Water.APCMOMEJFDP.Reflective:
				Shader.DisableKeyword("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
				Shader.EnableKeyword("#606000");
				Shader.DisableKeyword("IdleSpew");
				break;
			case Water.APCMOMEJFDP.Refractive:
				Shader.DisableKeyword(" \n");
				Shader.DisableKeyword("BowReady2");
				Shader.EnableKeyword("fshop_hd2");
				break;
			}
			Water.EHHACHJBEND = false;
		}

		// Token: 0x0600B183 RID: 45443 RVA: 0x004D5C10 File Offset: 0x004D3E10
		public void DLNEFOLDJHJ()
		{
			if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if (!current)
			{
				return;
			}
			if (Water.EHHACHJBEND)
			{
				return;
			}
			Water.EHHACHJBEND = true;
			this.BMEFHDIJNEC = this.DKMKADGPBBM();
			Water.APCMOMEJFDP apcmomejfdp = this.HNDMNGHOFKO();
			Camera camera;
			Camera camera2;
			this.ACNKHDPJCEH(current, out camera, out camera2);
			Vector3 position = base.transform.position;
			Vector3 up = base.transform.up;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = 0;
			}
			this.OJNHEMINLGD(current, camera);
			this.JIJHJOMBAPD(current, camera2);
			if (apcmomejfdp >= Water.APCMOMEJFDP.Simple)
			{
				float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
				Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
				Matrix4x4 zero = Matrix4x4.zero;
				Water.KACJIDCODHK(ref zero, ehgilahlmib);
				Vector3 position2 = current.transform.position;
				Vector3 position3 = zero.MultiplyPoint(position2);
				camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
				Vector4 clipPlane = this.FGIFMANIMFE(camera, position, up, 1427f);
				camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
				camera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera.cullingMask = (81 & this.reflectLayers.value);
				camera.targetTexture = this.EACNIDNGPBL;
				bool invertCulling = GL.invertCulling;
				GL.invertCulling = !invertCulling;
				camera.transform.position = position3;
				Vector3 eulerAngles = current.transform.eulerAngles;
				camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
				camera.Render();
				camera.transform.position = position2;
				GL.invertCulling = invertCulling;
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("knopje.wav", this.EACNIDNGPBL);
			}
			if (apcmomejfdp >= (Water.APCMOMEJFDP)4)
			{
				camera2.worldToCameraMatrix = current.worldToCameraMatrix;
				Vector4 clipPlane2 = this.DNKGLEKBDEC(camera2, position, up, 840f);
				camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
				camera2.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera2.cullingMask = (124 & this.refractLayers.value);
				camera2.targetTexture = this.JDMOBHGACDO;
				camera2.transform.position = current.transform.position;
				camera2.transform.rotation = current.transform.rotation;
				camera2.Render();
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("Windows/", this.JDMOBHGACDO);
			}
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = pixelLightCount;
			}
			switch (apcmomejfdp)
			{
			case Water.APCMOMEJFDP.Simple:
				Shader.EnableKeyword("ignorelist");
				Shader.DisableKeyword("inv_or");
				Shader.DisableKeyword("t_much");
				break;
			case Water.APCMOMEJFDP.Reflective:
				Shader.DisableKeyword("ElvisLegsLoop");
				Shader.EnableKeyword("SkateboardIdle");
				Shader.DisableKeyword("No hit from ");
				break;
			case Water.APCMOMEJFDP.Refractive:
				Shader.DisableKeyword("_AllowBackwardsRays");
				Shader.DisableKeyword("MotorbikeSuperman");
				Shader.EnableKeyword("512");
				break;
			}
			Water.EHHACHJBEND = false;
		}

		// Token: 0x0600B184 RID: 45444 RVA: 0x004D5F58 File Offset: 0x004D4158
		private Water.APCMOMEJFDP FCMKLNMIKOH()
		{
			if (!base.GetComponent<Renderer>())
			{
				return Water.APCMOMEJFDP.Simple;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return Water.APCMOMEJFDP.Simple;
			}
			string tag = sharedMaterial.GetTag("wpn_hookf", true);
			if (tag == "MotorbikeHandstand")
			{
				return (Water.APCMOMEJFDP)7;
			}
			if (tag == "Channel Cast Omni")
			{
				return Water.APCMOMEJFDP.Simple;
			}
			return Water.APCMOMEJFDP.Reflective;
		}

		// Token: 0x0600B185 RID: 45445 RVA: 0x004D5FB8 File Offset: 0x004D41B8
		private void GJCMIDFODJD(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
		{
			if (OLFKAHHACBC == null)
			{
				return;
			}
			OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
			OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
			if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
			{
				Skybox component = BNDNKLBIJJF.GetComponent<Skybox>();
				Skybox component2 = OLFKAHHACBC.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = true;
				}
				else
				{
					component2.enabled = false;
					component2.material = component.material;
				}
			}
			OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
			OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
			OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
			OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
			OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
			OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		}

		// Token: 0x0600B186 RID: 45446 RVA: 0x004D6078 File Offset: 0x004D4278
		private void DPGPJFDPGOP(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA, out Camera CBJAOAMGJBN)
		{
			Water.APCMOMEJFDP apcmomejfdp = this.GHHLOHPIKOH();
			OAMNCKHIPLA = null;
			CBJAOAMGJBN = null;
			if (apcmomejfdp >= Water.APCMOMEJFDP.Reflective)
			{
				if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.textureSize)
				{
					if (this.EACNIDNGPBL)
					{
						UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
					}
					this.EACNIDNGPBL = new RenderTexture(this.textureSize, this.textureSize, 16);
					this.EACNIDNGPBL.name = "__WaterReflection" + base.GetInstanceID();
					this.EACNIDNGPBL.isPowerOfTwo = true;
					this.EACNIDNGPBL.hideFlags = HideFlags.DontSave;
					this.DHBOBNEFLOG = this.textureSize;
				}
				this.BMOECLNNGDF.TryGetValue(GGEHECFCPMD, out OAMNCKHIPLA);
				if (!OAMNCKHIPLA)
				{
					GameObject gameObject = new GameObject(string.Concat(new object[]
					{
						"Water Refl Camera id",
						base.GetInstanceID(),
						" for ",
						GGEHECFCPMD.GetInstanceID()
					}), new Type[]
					{
						typeof(Camera),
						typeof(Skybox)
					});
					OAMNCKHIPLA = gameObject.GetComponent<Camera>();
					OAMNCKHIPLA.enabled = false;
					OAMNCKHIPLA.transform.position = base.transform.position;
					OAMNCKHIPLA.transform.rotation = base.transform.rotation;
					OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
					gameObject.hideFlags = HideFlags.HideAndDontSave;
					this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
				}
			}
			if (apcmomejfdp >= Water.APCMOMEJFDP.Refractive)
			{
				if (!this.JDMOBHGACDO || this.IJOHEFCCBGG != this.textureSize)
				{
					if (this.JDMOBHGACDO)
					{
						UnityEngine.Object.DestroyImmediate(this.JDMOBHGACDO);
					}
					this.JDMOBHGACDO = new RenderTexture(this.textureSize, this.textureSize, 16);
					this.JDMOBHGACDO.name = "__WaterRefraction" + base.GetInstanceID();
					this.JDMOBHGACDO.isPowerOfTwo = true;
					this.JDMOBHGACDO.hideFlags = HideFlags.DontSave;
					this.IJOHEFCCBGG = this.textureSize;
				}
				this.BLBAJIPMMEI.TryGetValue(GGEHECFCPMD, out CBJAOAMGJBN);
				if (!CBJAOAMGJBN)
				{
					GameObject gameObject2 = new GameObject(string.Concat(new object[]
					{
						"Water Refr Camera id",
						base.GetInstanceID(),
						" for ",
						GGEHECFCPMD.GetInstanceID()
					}), new Type[]
					{
						typeof(Camera),
						typeof(Skybox)
					});
					CBJAOAMGJBN = gameObject2.GetComponent<Camera>();
					CBJAOAMGJBN.enabled = false;
					CBJAOAMGJBN.transform.position = base.transform.position;
					CBJAOAMGJBN.transform.rotation = base.transform.rotation;
					CBJAOAMGJBN.gameObject.AddComponent<FlareLayer>();
					gameObject2.hideFlags = HideFlags.HideAndDontSave;
					this.BLBAJIPMMEI[GGEHECFCPMD] = CBJAOAMGJBN;
				}
			}
		}

		// Token: 0x0600B187 RID: 45447 RVA: 0x004D6374 File Offset: 0x004D4574
		private static void ENPIEPOIDGI(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 1289f - 1906f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m01 = 1349f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m02 = 323f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m03 = 1173f * EHGILAHLMIB[8] * EHGILAHLMIB[0];
			LNFAMODBJIH.m10 = 1479f * EHGILAHLMIB[0] * EHGILAHLMIB[0];
			LNFAMODBJIH.m11 = 1942f - 374f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
			LNFAMODBJIH.m12 = 578f * EHGILAHLMIB[0] * EHGILAHLMIB[7];
			LNFAMODBJIH.m13 = 1901f * EHGILAHLMIB[4] * EHGILAHLMIB[1];
			LNFAMODBJIH.m20 = 935f * EHGILAHLMIB[3] * EHGILAHLMIB[1];
			LNFAMODBJIH.m21 = 1124f * EHGILAHLMIB[8] * EHGILAHLMIB[0];
			LNFAMODBJIH.m22 = 297f - 428f * EHGILAHLMIB[2] * EHGILAHLMIB[7];
			LNFAMODBJIH.m23 = 1895f * EHGILAHLMIB[2] * EHGILAHLMIB[2];
			LNFAMODBJIH.m30 = 1222f;
			LNFAMODBJIH.m31 = 1989f;
			LNFAMODBJIH.m32 = 326f;
			LNFAMODBJIH.m33 = 1928f;
		}

		// Token: 0x0600B188 RID: 45448 RVA: 0x004D651C File Offset: 0x004D471C
		private void NPIOCACDHJO(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
		{
			if (OLFKAHHACBC == null)
			{
				return;
			}
			OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
			OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
			if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
			{
				Skybox component = BNDNKLBIJJF.GetComponent<Skybox>();
				Skybox component2 = OLFKAHHACBC.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = false;
				}
				else
				{
					component2.enabled = true;
					component2.material = component.material;
				}
			}
			OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
			OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
			OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
			OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
			OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
			OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		}

		// Token: 0x0600B189 RID: 45449 RVA: 0x004D65DC File Offset: 0x004D47DC
		private void APJACOJADAF()
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
				this.EACNIDNGPBL = null;
			}
			if (this.JDMOBHGACDO)
			{
				UnityEngine.Object.DestroyImmediate(this.JDMOBHGACDO);
				this.JDMOBHGACDO = null;
			}
			foreach (KeyValuePair<Camera, Camera> keyValuePair in this.BMOECLNNGDF)
			{
				UnityEngine.Object.DestroyImmediate(keyValuePair.Value.gameObject);
			}
			this.BMOECLNNGDF.Clear();
			foreach (KeyValuePair<Camera, Camera> keyValuePair2 in this.BLBAJIPMMEI)
			{
				UnityEngine.Object.DestroyImmediate(keyValuePair2.Value.gameObject);
			}
			this.BLBAJIPMMEI.Clear();
		}

		// Token: 0x0600B18A RID: 45450 RVA: 0x004D66DC File Offset: 0x004D48DC
		private Vector4 FPBKMANKFBP(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
		{
			Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
			return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
		}

		// Token: 0x0600B18B RID: 45451 RVA: 0x004D6744 File Offset: 0x004D4944
		private void ACGHDPEPEHC(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
		{
			if (OLFKAHHACBC == null)
			{
				return;
			}
			OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
			OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
			if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
			{
				Skybox component = BNDNKLBIJJF.GetComponent<Skybox>();
				Skybox component2 = OLFKAHHACBC.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = true;
				}
				else
				{
					component2.enabled = true;
					component2.material = component.material;
				}
			}
			OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
			OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
			OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
			OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
			OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
			OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		}

		// Token: 0x0600B18C RID: 45452 RVA: 0x004D2E9A File Offset: 0x004D109A
		private Water.APCMOMEJFDP HNDMNGHOFKO()
		{
			if (this.BMEFHDIJNEC < this.waterMode)
			{
				return this.BMEFHDIJNEC;
			}
			return this.waterMode;
		}

		// Token: 0x0600B18D RID: 45453 RVA: 0x004D6804 File Offset: 0x004D4A04
		private Vector4 FGIFMANIMFE(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
		{
			Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
			return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
		}

		// Token: 0x0600B18E RID: 45454 RVA: 0x004D686C File Offset: 0x004D4A6C
		private void JIJHJOMBAPD(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
		{
			if (OLFKAHHACBC == null)
			{
				return;
			}
			OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
			OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
			if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
			{
				Skybox component = BNDNKLBIJJF.GetComponent<Skybox>();
				Skybox component2 = OLFKAHHACBC.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = false;
				}
				else
				{
					component2.enabled = true;
					component2.material = component.material;
				}
			}
			OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
			OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
			OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
			OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
			OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
			OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		}

		// Token: 0x0600B18F RID: 45455 RVA: 0x004D692C File Offset: 0x004D4B2C
		private void BHDHNINBLDI(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA, out Camera CBJAOAMGJBN)
		{
			Water.APCMOMEJFDP apcmomejfdp = this.OAPDNMDGMOJ();
			OAMNCKHIPLA = null;
			CBJAOAMGJBN = null;
			if (apcmomejfdp >= Water.APCMOMEJFDP.Reflective)
			{
				if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.textureSize)
				{
					if (this.EACNIDNGPBL)
					{
						UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
					}
					this.EACNIDNGPBL = new RenderTexture(this.textureSize, this.textureSize, 12);
					this.EACNIDNGPBL.name = "post_12" + base.GetInstanceID();
					this.EACNIDNGPBL.isPowerOfTwo = true;
					this.EACNIDNGPBL.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
					this.DHBOBNEFLOG = this.textureSize;
				}
				this.BMOECLNNGDF.TryGetValue(GGEHECFCPMD, out OAMNCKHIPLA);
				if (!OAMNCKHIPLA)
				{
					object[] array = new object[6];
					array[1] = "Attached object";
					array[0] = base.GetInstanceID();
					array[0] = "Formatted Label";
					array[5] = GGEHECFCPMD.GetInstanceID();
					string name = string.Concat(array);
					Type[] array2 = new Type[1];
					array2[0] = typeof(Camera);
					array2[1] = typeof(Skybox);
					GameObject gameObject = new GameObject(name, array2);
					OAMNCKHIPLA = gameObject.GetComponent<Camera>();
					OAMNCKHIPLA.enabled = true;
					OAMNCKHIPLA.transform.position = base.transform.position;
					OAMNCKHIPLA.transform.rotation = base.transform.rotation;
					OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
					gameObject.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
					this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
				}
			}
			if (apcmomejfdp >= Water.APCMOMEJFDP.Simple)
			{
				if (!this.JDMOBHGACDO || this.IJOHEFCCBGG != this.textureSize)
				{
					if (this.JDMOBHGACDO)
					{
						UnityEngine.Object.DestroyImmediate(this.JDMOBHGACDO);
					}
					this.JDMOBHGACDO = new RenderTexture(this.textureSize, this.textureSize, 111);
					this.JDMOBHGACDO.name = "short:" + base.GetInstanceID();
					this.JDMOBHGACDO.isPowerOfTwo = false;
					this.JDMOBHGACDO.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
					this.IJOHEFCCBGG = this.textureSize;
				}
				this.BLBAJIPMMEI.TryGetValue(GGEHECFCPMD, out CBJAOAMGJBN);
				if (!CBJAOAMGJBN)
				{
					object[] array3 = new object[4];
					array3[1] = "myrec";
					array3[1] = base.GetInstanceID();
					array3[7] = "ApplePick";
					array3[2] = GGEHECFCPMD.GetInstanceID();
					string name2 = string.Concat(array3);
					Type[] array4 = new Type[4];
					array4[1] = typeof(Camera);
					array4[1] = typeof(Skybox);
					GameObject gameObject2 = new GameObject(name2, array4);
					CBJAOAMGJBN = gameObject2.GetComponent<Camera>();
					CBJAOAMGJBN.enabled = false;
					CBJAOAMGJBN.transform.position = base.transform.position;
					CBJAOAMGJBN.transform.rotation = base.transform.rotation;
					CBJAOAMGJBN.gameObject.AddComponent<FlareLayer>();
					gameObject2.hideFlags = (HideFlags)(-125);
					this.BLBAJIPMMEI[GGEHECFCPMD] = CBJAOAMGJBN;
				}
			}
		}

		// Token: 0x0600B190 RID: 45456 RVA: 0x004D6C28 File Offset: 0x004D4E28
		private Vector4 PEPOIHMJCGN(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
		{
			Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
			return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
		}

		// Token: 0x0600B191 RID: 45457 RVA: 0x004D6C90 File Offset: 0x004D4E90
		private void PJFCOKNCDEA(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
		{
			if (OLFKAHHACBC == null)
			{
				return;
			}
			OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
			OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
			if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
			{
				Skybox component = BNDNKLBIJJF.GetComponent<Skybox>();
				Skybox component2 = OLFKAHHACBC.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = true;
				}
				else
				{
					component2.enabled = true;
					component2.material = component.material;
				}
			}
			OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
			OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
			OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
			OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
			OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
			OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		}

		// Token: 0x0600B192 RID: 45458 RVA: 0x004D6D50 File Offset: 0x004D4F50
		private void MKBPPPJKLLF()
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
				this.EACNIDNGPBL = null;
			}
			if (this.JDMOBHGACDO)
			{
				UnityEngine.Object.DestroyImmediate(this.JDMOBHGACDO);
				this.JDMOBHGACDO = null;
			}
			foreach (KeyValuePair<Camera, Camera> keyValuePair in this.BMOECLNNGDF)
			{
				UnityEngine.Object.DestroyImmediate(keyValuePair.Value.gameObject);
			}
			this.BMOECLNNGDF.Clear();
			foreach (KeyValuePair<Camera, Camera> keyValuePair2 in this.BLBAJIPMMEI)
			{
				UnityEngine.Object.DestroyImmediate(keyValuePair2.Value.gameObject);
			}
			this.BLBAJIPMMEI.Clear();
		}

		// Token: 0x0600B193 RID: 45459 RVA: 0x004D6E50 File Offset: 0x004D5050
		public void MPIJAMLICFH()
		{
			if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if (!current)
			{
				return;
			}
			if (Water.EHHACHJBEND)
			{
				return;
			}
			Water.EHHACHJBEND = true;
			this.BMEFHDIJNEC = this.FCMKLNMIKOH();
			Water.APCMOMEJFDP apcmomejfdp = this.LGDGCPAPCJO();
			Camera camera;
			Camera camera2;
			this.BHDHNINBLDI(current, out camera, out camera2);
			Vector3 position = base.transform.position;
			Vector3 up = base.transform.up;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = 0;
			}
			this.OJNHEMINLGD(current, camera);
			this.HDGAGNDDKJE(current, camera2);
			if (apcmomejfdp >= Water.APCMOMEJFDP.Reflective)
			{
				float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
				Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
				Matrix4x4 zero = Matrix4x4.zero;
				Water.FICALOMGIJF(ref zero, ehgilahlmib);
				Vector3 position2 = current.transform.position;
				Vector3 position3 = zero.MultiplyPoint(position2);
				camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
				Vector4 clipPlane = this.DNKGLEKBDEC(camera, position, up, 1645f);
				camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
				camera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera.cullingMask = (-98 & this.reflectLayers.value);
				camera.targetTexture = this.EACNIDNGPBL;
				bool invertCulling = GL.invertCulling;
				GL.invertCulling = !invertCulling;
				camera.transform.position = position3;
				Vector3 eulerAngles = current.transform.eulerAngles;
				camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
				camera.Render();
				camera.transform.position = position2;
				GL.invertCulling = invertCulling;
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/", this.EACNIDNGPBL);
			}
			if (apcmomejfdp >= (Water.APCMOMEJFDP)4)
			{
				camera2.worldToCameraMatrix = current.worldToCameraMatrix;
				Vector4 clipPlane2 = this.DNKGLEKBDEC(camera2, position, up, 940f);
				camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
				camera2.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera2.cullingMask = (84 & this.refractLayers.value);
				camera2.targetTexture = this.JDMOBHGACDO;
				camera2.transform.position = current.transform.position;
				camera2.transform.rotation = current.transform.rotation;
				camera2.Render();
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("The InteractionTrigger in the list 'inContact' has been destroyed", this.JDMOBHGACDO);
			}
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = pixelLightCount;
			}
			switch (apcmomejfdp)
			{
			case Water.APCMOMEJFDP.Simple:
				Shader.EnableKeyword("MotorbikeHeadstand");
				Shader.DisableKeyword("_Cutoff");
				Shader.DisableKeyword("Turn Left");
				break;
			case Water.APCMOMEJFDP.Reflective:
				Shader.DisableKeyword("_BlurPass");
				Shader.EnableKeyword("shop_t6");
				Shader.DisableKeyword(" x");
				break;
			case Water.APCMOMEJFDP.Refractive:
				Shader.DisableKeyword("**** Weather cloudly={0} fog={1} rain={2} snaige={3} grom={4}");
				Shader.DisableKeyword("#> _Shadow Camera < ");
				Shader.EnableKeyword("_FogScatteringData2");
				break;
			}
			Water.EHHACHJBEND = false;
		}

		// Token: 0x0600B194 RID: 45460 RVA: 0x004D7198 File Offset: 0x004D5398
		private void MKLCOEALFBI()
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
				this.EACNIDNGPBL = null;
			}
			if (this.JDMOBHGACDO)
			{
				UnityEngine.Object.DestroyImmediate(this.JDMOBHGACDO);
				this.JDMOBHGACDO = null;
			}
			foreach (KeyValuePair<Camera, Camera> keyValuePair in this.BMOECLNNGDF)
			{
				UnityEngine.Object.DestroyImmediate(keyValuePair.Value.gameObject);
			}
			this.BMOECLNNGDF.Clear();
			foreach (KeyValuePair<Camera, Camera> keyValuePair2 in this.BLBAJIPMMEI)
			{
				UnityEngine.Object.DestroyImmediate(keyValuePair2.Value.gameObject);
			}
			this.BLBAJIPMMEI.Clear();
		}

		// Token: 0x0600B195 RID: 45461 RVA: 0x004D7298 File Offset: 0x004D5498
		public void OnWillRenderObject()
		{
			if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if (!current)
			{
				return;
			}
			if (Water.EHHACHJBEND)
			{
				return;
			}
			Water.EHHACHJBEND = true;
			this.BMEFHDIJNEC = this.HCLLFEPLOCI();
			Water.APCMOMEJFDP apcmomejfdp = this.GHHLOHPIKOH();
			Camera camera;
			Camera camera2;
			this.DPGPJFDPGOP(current, out camera, out camera2);
			Vector3 position = base.transform.position;
			Vector3 up = base.transform.up;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = 0;
			}
			this.OJNHEMINLGD(current, camera);
			this.OJNHEMINLGD(current, camera2);
			if (apcmomejfdp >= Water.APCMOMEJFDP.Reflective)
			{
				float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
				Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
				Matrix4x4 zero = Matrix4x4.zero;
				Water.LHKMOJMPHDP(ref zero, ehgilahlmib);
				Vector3 position2 = current.transform.position;
				Vector3 position3 = zero.MultiplyPoint(position2);
				camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
				Vector4 clipPlane = this.FPBKMANKFBP(camera, position, up, 1f);
				camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
				camera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera.cullingMask = (-17 & this.reflectLayers.value);
				camera.targetTexture = this.EACNIDNGPBL;
				bool invertCulling = GL.invertCulling;
				GL.invertCulling = !invertCulling;
				camera.transform.position = position3;
				Vector3 eulerAngles = current.transform.eulerAngles;
				camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
				camera.Render();
				camera.transform.position = position2;
				GL.invertCulling = invertCulling;
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("_ReflectionTex", this.EACNIDNGPBL);
			}
			if (apcmomejfdp >= Water.APCMOMEJFDP.Refractive)
			{
				camera2.worldToCameraMatrix = current.worldToCameraMatrix;
				Vector4 clipPlane2 = this.FPBKMANKFBP(camera2, position, up, -1f);
				camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
				camera2.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera2.cullingMask = (-17 & this.refractLayers.value);
				camera2.targetTexture = this.JDMOBHGACDO;
				camera2.transform.position = current.transform.position;
				camera2.transform.rotation = current.transform.rotation;
				camera2.Render();
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("_RefractionTex", this.JDMOBHGACDO);
			}
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = pixelLightCount;
			}
			switch (apcmomejfdp)
			{
			case Water.APCMOMEJFDP.Simple:
				Shader.EnableKeyword("WATER_SIMPLE");
				Shader.DisableKeyword("WATER_REFLECTIVE");
				Shader.DisableKeyword("WATER_REFRACTIVE");
				break;
			case Water.APCMOMEJFDP.Reflective:
				Shader.DisableKeyword("WATER_SIMPLE");
				Shader.EnableKeyword("WATER_REFLECTIVE");
				Shader.DisableKeyword("WATER_REFRACTIVE");
				break;
			case Water.APCMOMEJFDP.Refractive:
				Shader.DisableKeyword("WATER_SIMPLE");
				Shader.DisableKeyword("WATER_REFLECTIVE");
				Shader.EnableKeyword("WATER_REFRACTIVE");
				break;
			}
			Water.EHHACHJBEND = false;
		}

		// Token: 0x0600B196 RID: 45462 RVA: 0x004D75E0 File Offset: 0x004D57E0
		private void FDBCKDFGDJB(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
		{
			if (OLFKAHHACBC == null)
			{
				return;
			}
			OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
			OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
			if (BNDNKLBIJJF.clearFlags == (CameraClearFlags)0)
			{
				Skybox component = BNDNKLBIJJF.GetComponent<Skybox>();
				Skybox component2 = OLFKAHHACBC.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = true;
				}
				else
				{
					component2.enabled = true;
					component2.material = component.material;
				}
			}
			OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
			OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
			OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
			OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
			OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
			OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		}

		// Token: 0x0600B197 RID: 45463 RVA: 0x004D76A0 File Offset: 0x004D58A0
		private static void JHEOCCJMBOD(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
		{
			LNFAMODBJIH.m00 = 769f - 686f * EHGILAHLMIB[1] * EHGILAHLMIB[1];
			LNFAMODBJIH.m01 = 335f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m02 = 1129f * EHGILAHLMIB[1] * EHGILAHLMIB[8];
			LNFAMODBJIH.m03 = 1986f * EHGILAHLMIB[6] * EHGILAHLMIB[0];
			LNFAMODBJIH.m10 = 604f * EHGILAHLMIB[0] * EHGILAHLMIB[1];
			LNFAMODBJIH.m11 = 1759f - 87f * EHGILAHLMIB[1] * EHGILAHLMIB[0];
			LNFAMODBJIH.m12 = 1657f * EHGILAHLMIB[1] * EHGILAHLMIB[5];
			LNFAMODBJIH.m13 = 1346f * EHGILAHLMIB[3] * EHGILAHLMIB[1];
			LNFAMODBJIH.m20 = 506f * EHGILAHLMIB[2] * EHGILAHLMIB[1];
			LNFAMODBJIH.m21 = 65f * EHGILAHLMIB[7] * EHGILAHLMIB[1];
			LNFAMODBJIH.m22 = 1914f - 1943f * EHGILAHLMIB[6] * EHGILAHLMIB[3];
			LNFAMODBJIH.m23 = 463f * EHGILAHLMIB[2] * EHGILAHLMIB[8];
			LNFAMODBJIH.m30 = 1631f;
			LNFAMODBJIH.m31 = 1907f;
			LNFAMODBJIH.m32 = 1810f;
			LNFAMODBJIH.m33 = 414f;
		}

		// Token: 0x0600B198 RID: 45464 RVA: 0x004D7848 File Offset: 0x004D5A48
		private Vector4 GIEAAMOLKAJ(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
		{
			Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
			return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
		}

		// Token: 0x0600B199 RID: 45465 RVA: 0x004D78B0 File Offset: 0x004D5AB0
		private Vector4 NGGOBAJNHPH(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
		{
			Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
			return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
		}

		// Token: 0x0600B19A RID: 45466 RVA: 0x004D7918 File Offset: 0x004D5B18
		public void AOGEHOCOCAN()
		{
			if (!base.enabled || !base.GetComponent<Renderer>() || !base.GetComponent<Renderer>().sharedMaterial || !base.GetComponent<Renderer>().enabled)
			{
				return;
			}
			Camera current = Camera.current;
			if (!current)
			{
				return;
			}
			if (Water.EHHACHJBEND)
			{
				return;
			}
			Water.EHHACHJBEND = false;
			this.BMEFHDIJNEC = this.MLODCFOBDGF();
			Water.APCMOMEJFDP apcmomejfdp = this.HNDMNGHOFKO();
			Camera camera;
			Camera camera2;
			this.DPGPJFDPGOP(current, out camera, out camera2);
			Vector3 position = base.transform.position;
			Vector3 up = base.transform.up;
			int pixelLightCount = QualitySettings.pixelLightCount;
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = 0;
			}
			this.NPIOCACDHJO(current, camera);
			this.BJIHAKKLKJF(current, camera2);
			if (apcmomejfdp >= Water.APCMOMEJFDP.Reflective)
			{
				float w = -Vector3.Dot(up, position) - this.clipPlaneOffset;
				Vector4 ehgilahlmib = new Vector4(up.x, up.y, up.z, w);
				Matrix4x4 zero = Matrix4x4.zero;
				Water.KACJIDCODHK(ref zero, ehgilahlmib);
				Vector3 position2 = current.transform.position;
				Vector3 position3 = zero.MultiplyPoint(position2);
				camera.worldToCameraMatrix = current.worldToCameraMatrix * zero;
				Vector4 clipPlane = this.GIEAAMOLKAJ(camera, position, up, 1726f);
				camera.projectionMatrix = current.CalculateObliqueMatrix(clipPlane);
				camera.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera.cullingMask = (-89 & this.reflectLayers.value);
				camera.targetTexture = this.EACNIDNGPBL;
				bool invertCulling = GL.invertCulling;
				GL.invertCulling = invertCulling;
				camera.transform.position = position3;
				Vector3 eulerAngles = current.transform.eulerAngles;
				camera.transform.eulerAngles = new Vector3(-eulerAngles.x, eulerAngles.y, eulerAngles.z);
				camera.Render();
				camera.transform.position = position2;
				GL.invertCulling = invertCulling;
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("</color></i>", this.EACNIDNGPBL);
			}
			if (apcmomejfdp >= (Water.APCMOMEJFDP)6)
			{
				camera2.worldToCameraMatrix = current.worldToCameraMatrix;
				Vector4 clipPlane2 = this.NGGOBAJNHPH(camera2, position, up, 788f);
				camera2.projectionMatrix = current.CalculateObliqueMatrix(clipPlane2);
				camera2.cullingMatrix = current.projectionMatrix * current.worldToCameraMatrix;
				camera2.cullingMask = (-3 & this.refractLayers.value);
				camera2.targetTexture = this.JDMOBHGACDO;
				camera2.transform.position = current.transform.position;
				camera2.transform.rotation = current.transform.rotation;
				camera2.Render();
				base.GetComponent<Renderer>().sharedMaterial.SetTexture("msgCancel", this.JDMOBHGACDO);
			}
			if (this.disablePixelLights)
			{
				QualitySettings.pixelLightCount = pixelLightCount;
			}
			switch (apcmomejfdp)
			{
			case Water.APCMOMEJFDP.Simple:
				Shader.EnableKeyword("_Intensity");
				Shader.DisableKeyword("_camHue");
				Shader.DisableKeyword("[X]");
				break;
			case Water.APCMOMEJFDP.Reflective:
				Shader.DisableKeyword("InteractionObject Multiplier 'Curve' ");
				Shader.EnableKeyword("gi_uinf_3");
				Shader.DisableKeyword("gi_um_1");
				break;
			case Water.APCMOMEJFDP.Refractive:
				Shader.DisableKeyword("demoQuaternion");
				Shader.DisableKeyword("<color='#804020'>");
				Shader.EnableKeyword("TOD_MoonHaloPower");
				break;
			}
			Water.EHHACHJBEND = true;
		}

		// Token: 0x0600B19B RID: 45467 RVA: 0x004D7C60 File Offset: 0x004D5E60
		private void FKKJAJFOHCP(Camera GGEHECFCPMD, out Camera OAMNCKHIPLA, out Camera CBJAOAMGJBN)
		{
			Water.APCMOMEJFDP apcmomejfdp = this.LGDGCPAPCJO();
			OAMNCKHIPLA = null;
			CBJAOAMGJBN = null;
			if (apcmomejfdp >= Water.APCMOMEJFDP.Reflective)
			{
				if (!this.EACNIDNGPBL || this.DHBOBNEFLOG != this.textureSize)
				{
					if (this.EACNIDNGPBL)
					{
						UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
					}
					this.EACNIDNGPBL = new RenderTexture(this.textureSize, this.textureSize, -59);
					this.EACNIDNGPBL.name = "" + base.GetInstanceID();
					this.EACNIDNGPBL.isPowerOfTwo = false;
					this.EACNIDNGPBL.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
					this.DHBOBNEFLOG = this.textureSize;
				}
				this.BMOECLNNGDF.TryGetValue(GGEHECFCPMD, out OAMNCKHIPLA);
				if (!OAMNCKHIPLA)
				{
					object[] array = new object[2];
					array[0] = "auc_resallcst";
					array[1] = base.GetInstanceID();
					array[3] = "inv already open";
					array[2] = GGEHECFCPMD.GetInstanceID();
					GameObject gameObject = new GameObject(string.Concat(array), new Type[]
					{
						typeof(Camera),
						typeof(Skybox)
					});
					OAMNCKHIPLA = gameObject.GetComponent<Camera>();
					OAMNCKHIPLA.enabled = false;
					OAMNCKHIPLA.transform.position = base.transform.position;
					OAMNCKHIPLA.transform.rotation = base.transform.rotation;
					OAMNCKHIPLA.gameObject.AddComponent<FlareLayer>();
					gameObject.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
					this.BMOECLNNGDF[GGEHECFCPMD] = OAMNCKHIPLA;
				}
			}
			if (apcmomejfdp >= Water.APCMOMEJFDP.Refractive)
			{
				if (!this.JDMOBHGACDO || this.IJOHEFCCBGG != this.textureSize)
				{
					if (this.JDMOBHGACDO)
					{
						UnityEngine.Object.DestroyImmediate(this.JDMOBHGACDO);
					}
					this.JDMOBHGACDO = new RenderTexture(this.textureSize, this.textureSize, -123);
					this.JDMOBHGACDO.name = "Assets/Weapons/" + base.GetInstanceID();
					this.JDMOBHGACDO.isPowerOfTwo = true;
					this.JDMOBHGACDO.hideFlags = HideFlags.HideInInspector;
					this.IJOHEFCCBGG = this.textureSize;
				}
				this.BLBAJIPMMEI.TryGetValue(GGEHECFCPMD, out CBJAOAMGJBN);
				if (!CBJAOAMGJBN)
				{
					object[] array2 = new object[6];
					array2[1] = "1 Hand Sword Charge Up";
					array2[1] = base.GetInstanceID();
					array2[4] = "PaperTurn.wav";
					array2[6] = GGEHECFCPMD.GetInstanceID();
					string name = string.Concat(array2);
					Type[] array3 = new Type[6];
					array3[1] = typeof(Camera);
					array3[1] = typeof(Skybox);
					GameObject gameObject2 = new GameObject(name, array3);
					CBJAOAMGJBN = gameObject2.GetComponent<Camera>();
					CBJAOAMGJBN.enabled = false;
					CBJAOAMGJBN.transform.position = base.transform.position;
					CBJAOAMGJBN.transform.rotation = base.transform.rotation;
					CBJAOAMGJBN.gameObject.AddComponent<FlareLayer>();
					gameObject2.hideFlags = (HideFlags)(-66);
					this.BLBAJIPMMEI[GGEHECFCPMD] = CBJAOAMGJBN;
				}
			}
		}

		// Token: 0x0600B19C RID: 45468 RVA: 0x004D7F5C File Offset: 0x004D615C
		private Water.APCMOMEJFDP ABLPNBMMHAA()
		{
			if (!base.GetComponent<Renderer>())
			{
				return Water.APCMOMEJFDP.Simple;
			}
			Material sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
			if (!sharedMaterial)
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			string tag = sharedMaterial.GetTag("Move around with WASD or cursor keys, space to jump", false);
			if (tag == "_Curve")
			{
				return (Water.APCMOMEJFDP)7;
			}
			if (tag == "#606000")
			{
				return Water.APCMOMEJFDP.Reflective;
			}
			return Water.APCMOMEJFDP.Simple;
		}

		// Token: 0x0600B19D RID: 45469 RVA: 0x004D7FBC File Offset: 0x004D61BC
		private static void LHKMOJMPHDP(ref Matrix4x4 LNFAMODBJIH, Vector4 EHGILAHLMIB)
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
		}

		// Token: 0x0600B19E RID: 45470 RVA: 0x004D8164 File Offset: 0x004D6364
		private void OnDisable()
		{
			if (this.EACNIDNGPBL)
			{
				UnityEngine.Object.DestroyImmediate(this.EACNIDNGPBL);
				this.EACNIDNGPBL = null;
			}
			if (this.JDMOBHGACDO)
			{
				UnityEngine.Object.DestroyImmediate(this.JDMOBHGACDO);
				this.JDMOBHGACDO = null;
			}
			foreach (KeyValuePair<Camera, Camera> keyValuePair in this.BMOECLNNGDF)
			{
				UnityEngine.Object.DestroyImmediate(keyValuePair.Value.gameObject);
			}
			this.BMOECLNNGDF.Clear();
			foreach (KeyValuePair<Camera, Camera> keyValuePair2 in this.BLBAJIPMMEI)
			{
				UnityEngine.Object.DestroyImmediate(keyValuePair2.Value.gameObject);
			}
			this.BLBAJIPMMEI.Clear();
		}

		// Token: 0x0600B19F RID: 45471 RVA: 0x004D8264 File Offset: 0x004D6464
		private Vector4 NOGIAMIBLBN(Camera PMMEFNKFJIA, Vector3 NHCLMBOINFG, Vector3 LJGHBOFJDBJ, float MDNFBJKMNKM)
		{
			Vector3 point = NHCLMBOINFG + LJGHBOFJDBJ * this.clipPlaneOffset;
			Matrix4x4 worldToCameraMatrix = PMMEFNKFJIA.worldToCameraMatrix;
			Vector3 lhs = worldToCameraMatrix.MultiplyPoint(point);
			Vector3 vector = worldToCameraMatrix.MultiplyVector(LJGHBOFJDBJ).normalized * MDNFBJKMNKM;
			return new Vector4(vector.x, vector.y, vector.z, -Vector3.Dot(lhs, vector));
		}

		// Token: 0x0600B1A0 RID: 45472 RVA: 0x004D82CC File Offset: 0x004D64CC
		private void HDGAGNDDKJE(Camera BNDNKLBIJJF, Camera OLFKAHHACBC)
		{
			if (OLFKAHHACBC == null)
			{
				return;
			}
			OLFKAHHACBC.clearFlags = BNDNKLBIJJF.clearFlags;
			OLFKAHHACBC.backgroundColor = BNDNKLBIJJF.backgroundColor;
			if (BNDNKLBIJJF.clearFlags == CameraClearFlags.Skybox)
			{
				Skybox component = BNDNKLBIJJF.GetComponent<Skybox>();
				Skybox component2 = OLFKAHHACBC.GetComponent<Skybox>();
				if (!component || !component.material)
				{
					component2.enabled = true;
				}
				else
				{
					component2.enabled = false;
					component2.material = component.material;
				}
			}
			OLFKAHHACBC.farClipPlane = BNDNKLBIJJF.farClipPlane;
			OLFKAHHACBC.nearClipPlane = BNDNKLBIJJF.nearClipPlane;
			OLFKAHHACBC.orthographic = BNDNKLBIJJF.orthographic;
			OLFKAHHACBC.fieldOfView = BNDNKLBIJJF.fieldOfView;
			OLFKAHHACBC.aspect = BNDNKLBIJJF.aspect;
			OLFKAHHACBC.orthographicSize = BNDNKLBIJJF.orthographicSize;
		}

		// Token: 0x04001677 RID: 5751
		public Water.APCMOMEJFDP waterMode = Water.APCMOMEJFDP.Refractive;

		// Token: 0x04001678 RID: 5752
		public bool disablePixelLights = true;

		// Token: 0x04001679 RID: 5753
		public int textureSize = 256;

		// Token: 0x0400167A RID: 5754
		public float clipPlaneOffset = 0.07f;

		// Token: 0x0400167B RID: 5755
		public LayerMask reflectLayers = -1;

		// Token: 0x0400167C RID: 5756
		public LayerMask refractLayers = -1;

		// Token: 0x0400167D RID: 5757
		private Dictionary<Camera, Camera> BMOECLNNGDF = new Dictionary<Camera, Camera>();

		// Token: 0x0400167E RID: 5758
		private Dictionary<Camera, Camera> BLBAJIPMMEI = new Dictionary<Camera, Camera>();

		// Token: 0x0400167F RID: 5759
		private RenderTexture EACNIDNGPBL;

		// Token: 0x04001680 RID: 5760
		private RenderTexture JDMOBHGACDO;

		// Token: 0x04001681 RID: 5761
		private Water.APCMOMEJFDP BMEFHDIJNEC = Water.APCMOMEJFDP.Refractive;

		// Token: 0x04001682 RID: 5762
		private int DHBOBNEFLOG;

		// Token: 0x04001683 RID: 5763
		private int IJOHEFCCBGG;

		// Token: 0x04001684 RID: 5764
		private static bool EHHACHJBEND;

		// Token: 0x020002F7 RID: 759
		public enum APCMOMEJFDP
		{
			// Token: 0x04001686 RID: 5766
			Simple,
			// Token: 0x04001687 RID: 5767
			Reflective,
			// Token: 0x04001688 RID: 5768
			Refractive
		}
	}
}
