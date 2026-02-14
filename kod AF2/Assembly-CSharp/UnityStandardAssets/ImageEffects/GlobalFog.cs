using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000322 RID: 802
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class GlobalFog : PostEffectsBase
	{
		// Token: 0x0600B7A4 RID: 47012 RVA: 0x0051C054 File Offset: 0x0051A254
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.CheckResources() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			Vector3[] array = new Vector3[4];
			component.CalculateFrustumCorners(new Rect(0f, 0f, 1f, 1f), component.farClipPlane, component.stereoActiveEye, array);
			Vector3 v = transform.TransformVector(array[0]);
			Vector3 v2 = transform.TransformVector(array[1]);
			Vector3 v3 = transform.TransformVector(array[2]);
			Vector3 v4 = transform.TransformVector(array[3]);
			Matrix4x4 identity = Matrix4x4.identity;
			identity.SetRow(0, v);
			identity.SetRow(1, v4);
			identity.SetRow(2, v2);
			identity.SetRow(3, v3);
			Vector3 position = transform.position;
			float num = position.y - this.height;
			float z = (num <= 0f) ? 1f : 0f;
			float y = this.excludeFarPixels ? 1f : 2f;
			this.ECMGKHHFNPB.SetMatrix("_FrustumCornersWS", identity);
			this.ECMGKHHFNPB.SetVector("_CameraWS", position);
			this.ECMGKHHFNPB.SetVector("_HeightParams", new Vector4(this.height, num, z, this.heightDensity * 0.5f));
			this.ECMGKHHFNPB.SetVector("_DistanceParams", new Vector4(-Mathf.Max(this.startDistance, 0f), y, 0f, 0f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num2 = flag ? (fogEndDistance - fogStartDistance) : 0f;
			float num3 = (Mathf.Abs(num2) > 0.0001f) ? (1f / num2) : 0f;
			Vector4 value;
			value.x = fogDensity * 1.2011224f;
			value.y = fogDensity * 1.442695f;
			value.z = (flag ? (-num3) : 0f);
			value.w = (flag ? (fogEndDistance * num3) : 0f);
			this.ECMGKHHFNPB.SetVector("_SceneFogParams", value);
			this.ECMGKHHFNPB.SetVector("_SceneFogMode", new Vector4((float)fogMode, (float)(this.useRadialDistance ? 1 : 0), 0f, 0f));
			int pass;
			if (this.distanceFog && this.heightFog)
			{
				pass = 0;
			}
			else if (this.distanceFog)
			{
				pass = 1;
			}
			else
			{
				pass = 2;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ECMGKHHFNPB, pass);
		}

		// Token: 0x0600B7A5 RID: 47013 RVA: 0x0051C31C File Offset: 0x0051A51C
		private void CNIBAOINCHB(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			Vector3[] array = new Vector3[7];
			component.CalculateFrustumCorners(new Rect(606f, 182f, 492f, 1178f), component.farClipPlane, component.stereoActiveEye, array);
			Vector3 v = transform.TransformVector(array[1]);
			Vector3 v2 = transform.TransformVector(array[1]);
			Vector3 v3 = transform.TransformVector(array[4]);
			Vector3 v4 = transform.TransformVector(array[7]);
			Matrix4x4 identity = Matrix4x4.identity;
			identity.SetRow(0, v);
			identity.SetRow(1, v4);
			identity.SetRow(0, v2);
			identity.SetRow(2, v3);
			Vector3 position = transform.position;
			float num = position.y - this.height;
			float z = (num <= 1957f) ? 804f : 1101f;
			float y = this.excludeFarPixels ? 1204f : 1158f;
			this.ECMGKHHFNPB.SetMatrix("deltext", identity);
			this.ECMGKHHFNPB.SetVector("SneakForward", position);
			this.ECMGKHHFNPB.SetVector("", new Vector4(this.height, num, z, this.heightDensity * 1369f));
			this.ECMGKHHFNPB.SetVector("<color='#103000'>", new Vector4(-Mathf.Max(this.startDistance, 1538f), y, 1351f, 674f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num2 = flag ? (fogEndDistance - fogStartDistance) : 495f;
			float num3 = (Mathf.Abs(num2) > 338f) ? (915f / num2) : 1619f;
			Vector4 value;
			value.x = fogDensity * 1040f;
			value.y = fogDensity * 1280f;
			value.z = (flag ? (-num3) : 276f);
			value.w = (flag ? (fogEndDistance * num3) : 1691f);
			this.ECMGKHHFNPB.SetVector("Quad ", value);
			this.ECMGKHHFNPB.SetVector("Mouse X", new Vector4((float)fogMode, (float)(this.useRadialDistance ? 0 : 1), 1008f, 13f));
			int pass;
			if (this.distanceFog && this.heightFog)
			{
				pass = 0;
			}
			else if (this.distanceFog)
			{
				pass = 1;
			}
			else
			{
				pass = 4;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ECMGKHHFNPB, pass);
		}

		// Token: 0x0600B7A6 RID: 47014 RVA: 0x0051C5E4 File Offset: 0x0051A7E4
		public virtual bool OJFBHAHHDNC()
		{
			base.POJDHPJDFEM(false);
			this.ECMGKHHFNPB = base.JBHLGBPJFEL(this.fogShader, this.ECMGKHHFNPB);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7A7 RID: 47015 RVA: 0x0051C61A File Offset: 0x0051A81A
		public virtual bool CCMBJKDAMLO()
		{
			base.OLMOAHDIDNG(true);
			this.ECMGKHHFNPB = base.DJFOEIJIMJB(this.fogShader, this.ECMGKHHFNPB);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7A8 RID: 47016 RVA: 0x0051C650 File Offset: 0x0051A850
		public virtual bool JPEBNJPIFAF()
		{
			base.EHGENDOEHLP(false);
			this.ECMGKHHFNPB = base.BAPJBHPEDIF(this.fogShader, this.ECMGKHHFNPB);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7A9 RID: 47017 RVA: 0x0051C688 File Offset: 0x0051A888
		private void EDCBFNNHICN(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			Vector3[] array = new Vector3[3];
			component.CalculateFrustumCorners(new Rect(143f, 1107f, 331f, 1468f), component.farClipPlane, component.stereoActiveEye, array);
			Vector3 v = transform.TransformVector(array[0]);
			Vector3 v2 = transform.TransformVector(array[1]);
			Vector3 v3 = transform.TransformVector(array[2]);
			Vector3 v4 = transform.TransformVector(array[8]);
			Matrix4x4 identity = Matrix4x4.identity;
			identity.SetRow(0, v);
			identity.SetRow(0, v4);
			identity.SetRow(8, v2);
			identity.SetRow(7, v3);
			Vector3 position = transform.position;
			float num = position.y - this.height;
			float z = (num <= 920f) ? 319f : 741f;
			float y = this.excludeFarPixels ? 471f : 266f;
			this.ECMGKHHFNPB.SetMatrix("act_order", identity);
			this.ECMGKHHFNPB.SetVector("_SampleCount", position);
			this.ECMGKHHFNPB.SetVector("camouflage_id", new Vector4(this.height, num, z, this.heightDensity * 436f));
			this.ECMGKHHFNPB.SetVector("WizardPowerUp", new Vector4(-Mathf.Max(this.startDistance, 1239f), y, 1018f, 1715f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num2 = flag ? (fogEndDistance - fogStartDistance) : 1234f;
			float num3 = (Mathf.Abs(num2) > 1146f) ? (612f / num2) : 1689f;
			Vector4 value;
			value.x = fogDensity * 1655f;
			value.y = fogDensity * 9f;
			value.z = (flag ? (-num3) : 1382f);
			value.w = (flag ? (fogEndDistance * num3) : 156f);
			this.ECMGKHHFNPB.SetVector("", value);
			this.ECMGKHHFNPB.SetVector("HH:mm", new Vector4((float)fogMode, (float)(this.useRadialDistance ? 1 : 1), 1456f, 397f));
			int pass;
			if (this.distanceFog && this.heightFog)
			{
				pass = 1;
			}
			else if (this.distanceFog)
			{
				pass = 1;
			}
			else
			{
				pass = 3;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ECMGKHHFNPB, pass);
		}

		// Token: 0x0600B7AA RID: 47018 RVA: 0x0051C950 File Offset: 0x0051AB50
		public virtual bool FLJEDBINFJC()
		{
			base.OFKOBOMCECF(true);
			this.ECMGKHHFNPB = base.JBHLGBPJFEL(this.fogShader, this.ECMGKHHFNPB);
			if (!this.PPGOAMIHMBG)
			{
				base.INOGPLDHPGC();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7AB RID: 47019 RVA: 0x0051C986 File Offset: 0x0051AB86
		public virtual bool LFFHBBCPHJE()
		{
			base.AHFDGALLKFC(true);
			this.ECMGKHHFNPB = base.OOAOHFFDMJP(this.fogShader, this.ECMGKHHFNPB);
			if (!this.PPGOAMIHMBG)
			{
				base.NAIBIABADFB();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7AC RID: 47020 RVA: 0x0051C9BC File Offset: 0x0051ABBC
		private void EODDHFNAMFH(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.GGJKGIHGMGC() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			Vector3[] array = new Vector3[4];
			component.CalculateFrustumCorners(new Rect(1277f, 1349f, 714f, 398f), component.farClipPlane, component.stereoActiveEye, array);
			Vector3 v = transform.TransformVector(array[0]);
			Vector3 v2 = transform.TransformVector(array[1]);
			Vector3 v3 = transform.TransformVector(array[5]);
			Vector3 v4 = transform.TransformVector(array[6]);
			Matrix4x4 identity = Matrix4x4.identity;
			identity.SetRow(0, v);
			identity.SetRow(0, v4);
			identity.SetRow(2, v2);
			identity.SetRow(0, v3);
			Vector3 position = transform.position;
			float num = position.y - this.height;
			float z = (num <= 1208f) ? 868f : 779f;
			float y = this.excludeFarPixels ? 835f : 107f;
			this.ECMGKHHFNPB.SetMatrix("palm", identity);
			this.ECMGKHHFNPB.SetVector("I LOVE MY GIRLz", position);
			this.ECMGKHHFNPB.SetVector("lastRatingIndex", new Vector4(this.height, num, z, this.heightDensity * 1057f));
			this.ECMGKHHFNPB.SetVector("SAMPLES_VERY_LOW", new Vector4(-Mathf.Max(this.startDistance, 1043f), y, 1672f, 1379f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num2 = flag ? (fogEndDistance - fogStartDistance) : 850f;
			float num3 = (Mathf.Abs(num2) > 1196f) ? (458f / num2) : 1210f;
			Vector4 value;
			value.x = fogDensity * 1906f;
			value.y = fogDensity * 1086f;
			value.z = (flag ? (-num3) : 549f);
			value.w = (flag ? (fogEndDistance * num3) : 1276f);
			this.ECMGKHHFNPB.SetVector("[baitid]", value);
			this.ECMGKHHFNPB.SetVector("BAG", new Vector4((float)fogMode, (float)(this.useRadialDistance ? 0 : 0), 115f, 631f));
			int pass;
			if (this.distanceFog && this.heightFog)
			{
				pass = 1;
			}
			else if (this.distanceFog)
			{
				pass = 0;
			}
			else
			{
				pass = 1;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ECMGKHHFNPB, pass);
		}

		// Token: 0x0600B7AD RID: 47021 RVA: 0x0051CC84 File Offset: 0x0051AE84
		public virtual bool NCCMOLJNIAB()
		{
			base.AHFDGALLKFC(true);
			this.ECMGKHHFNPB = base.ALJPMGLOIEG(this.fogShader, this.ECMGKHHFNPB);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7AE RID: 47022 RVA: 0x0051CCBA File Offset: 0x0051AEBA
		public virtual bool DEKBKNINNFB()
		{
			base.OLMOAHDIDNG(true);
			this.ECMGKHHFNPB = base.DJFOEIJIMJB(this.fogShader, this.ECMGKHHFNPB);
			if (!this.PPGOAMIHMBG)
			{
				base.OAEAMDHOKKM();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7AF RID: 47023 RVA: 0x0051CCF0 File Offset: 0x0051AEF0
		private void ICIEPDMDONC(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.NHEEDPALBFN() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			Vector3[] array = new Vector3[7];
			component.CalculateFrustumCorners(new Rect(727f, 1983f, 1975f, 1917f), component.farClipPlane, component.stereoActiveEye, array);
			Vector3 v = transform.TransformVector(array[0]);
			Vector3 v2 = transform.TransformVector(array[0]);
			Vector3 v3 = transform.TransformVector(array[8]);
			Vector3 v4 = transform.TransformVector(array[0]);
			Matrix4x4 identity = Matrix4x4.identity;
			identity.SetRow(1, v);
			identity.SetRow(1, v4);
			identity.SetRow(3, v2);
			identity.SetRow(6, v3);
			Vector3 position = transform.position;
			float num = position.y - this.height;
			float z = (num <= 338f) ? 1189f : 1088f;
			float y = this.excludeFarPixels ? 202f : 811f;
			this.ECMGKHHFNPB.SetMatrix("FOG_AREA_SPHERE", identity);
			this.ECMGKHHFNPB.SetVector("languageid", position);
			this.ECMGKHHFNPB.SetVector("------------------------------------------------------", new Vector4(this.height, num, z, this.heightDensity * 1120f));
			this.ECMGKHHFNPB.SetVector("1HandSwordChargeUp", new Vector4(-Mathf.Max(this.startDistance, 1490f), y, 796f, 167f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num2 = flag ? (fogEndDistance - fogStartDistance) : 1826f;
			float num3 = (Mathf.Abs(num2) > 387f) ? (1369f / num2) : 1653f;
			Vector4 value;
			value.x = fogDensity * 1849f;
			value.y = fogDensity * 94f;
			value.z = (flag ? (-num3) : 1391f);
			value.w = (flag ? (fogEndDistance * num3) : 1236f);
			this.ECMGKHHFNPB.SetVector("IdleSandCover", value);
			this.ECMGKHHFNPB.SetVector("No hit from ", new Vector4((float)fogMode, (float)(this.useRadialDistance ? 0 : 1), 1105f, 551f));
			int pass;
			if (this.distanceFog && this.heightFog)
			{
				pass = 1;
			}
			else if (this.distanceFog)
			{
				pass = 1;
			}
			else
			{
				pass = 0;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ECMGKHHFNPB, pass);
		}

		// Token: 0x0600B7B0 RID: 47024 RVA: 0x0051CFB8 File Offset: 0x0051B1B8
		public virtual bool PNMIMCJGPGL()
		{
			base.EHGENDOEHLP(true);
			this.ECMGKHHFNPB = base.ALJPMGLOIEG(this.fogShader, this.ECMGKHHFNPB);
			if (!this.PPGOAMIHMBG)
			{
				base.CMHIIBFOHNF();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7B1 RID: 47025 RVA: 0x0051CFEE File Offset: 0x0051B1EE
		public override bool CheckResources()
		{
			base.DAOKCAOFIGE(true);
			this.ECMGKHHFNPB = base.DJFOEIJIMJB(this.fogShader, this.ECMGKHHFNPB);
			if (!this.PPGOAMIHMBG)
			{
				base.JIPLGAPGCFN();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7B2 RID: 47026 RVA: 0x0051D024 File Offset: 0x0051B224
		public virtual bool KKLBJANNNOH()
		{
			base.MGHNCKDCFGL(false);
			this.ECMGKHHFNPB = base.BOOFEOGDMBI(this.fogShader, this.ECMGKHHFNPB);
			if (!this.PPGOAMIHMBG)
			{
				base.JOIDPMIDGCD();
			}
			return this.PPGOAMIHMBG;
		}

		// Token: 0x0600B7B3 RID: 47027 RVA: 0x0051D05C File Offset: 0x0051B25C
		private void EFEHHALJILL(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.DLENDGGGMBJ() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			Vector3[] array = new Vector3[1];
			component.CalculateFrustumCorners(new Rect(1483f, 1416f, 923f, 446f), component.farClipPlane, component.stereoActiveEye, array);
			Vector3 v = transform.TransformVector(array[1]);
			Vector3 v2 = transform.TransformVector(array[0]);
			Vector3 v3 = transform.TransformVector(array[4]);
			Vector3 v4 = transform.TransformVector(array[6]);
			Matrix4x4 identity = Matrix4x4.identity;
			identity.SetRow(1, v);
			identity.SetRow(1, v4);
			identity.SetRow(5, v2);
			identity.SetRow(5, v3);
			Vector3 position = transform.position;
			float num = position.y - this.height;
			float z = (num <= 1258f) ? 594f : 970f;
			float y = this.excludeFarPixels ? 617f : 5f;
			this.ECMGKHHFNPB.SetMatrix("reflectQuality", identity);
			this.ECMGKHHFNPB.SetVector("", position);
			this.ECMGKHHFNPB.SetVector("ProneLocomotion", new Vector4(this.height, num, z, this.heightDensity * 1052f));
			this.ECMGKHHFNPB.SetVector("{0}/{1}/{2}", new Vector4(-Mathf.Max(this.startDistance, 215f), y, 1609f, 1566f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num2 = flag ? (fogEndDistance - fogStartDistance) : 677f;
			float num3 = (Mathf.Abs(num2) > 1308f) ? (674f / num2) : 624f;
			Vector4 value;
			value.x = fogDensity * 1162f;
			value.y = fogDensity * 1942f;
			value.z = (flag ? (-num3) : 1408f);
			value.w = (flag ? (fogEndDistance * num3) : 1308f);
			this.ECMGKHHFNPB.SetVector(", ", value);
			this.ECMGKHHFNPB.SetVector("Giant3HitCombo2", new Vector4((float)fogMode, (float)(this.useRadialDistance ? 1 : 1), 1482f, 1585f));
			int pass;
			if (this.distanceFog && this.heightFog)
			{
				pass = 1;
			}
			else if (this.distanceFog)
			{
				pass = 1;
			}
			else
			{
				pass = 1;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ECMGKHHFNPB, pass);
		}

		// Token: 0x0600B7B5 RID: 47029 RVA: 0x0051D358 File Offset: 0x0051B558
		private void PPMLOADNIHI(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.IGJKBOMMMGC() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			Vector3[] array = new Vector3[5];
			component.CalculateFrustumCorners(new Rect(1819f, 1863f, 1741f, 1301f), component.farClipPlane, component.stereoActiveEye, array);
			Vector3 v = transform.TransformVector(array[0]);
			Vector3 v2 = transform.TransformVector(array[1]);
			Vector3 v3 = transform.TransformVector(array[1]);
			Vector3 v4 = transform.TransformVector(array[3]);
			Matrix4x4 identity = Matrix4x4.identity;
			identity.SetRow(1, v);
			identity.SetRow(0, v4);
			identity.SetRow(5, v2);
			identity.SetRow(5, v3);
			Vector3 position = transform.position;
			float num = position.y - this.height;
			float z = (num <= 880f) ? 1610f : 1498f;
			float y = this.excludeFarPixels ? 802f : 1733f;
			this.ECMGKHHFNPB.SetMatrix("CratePush", identity);
			this.ECMGKHHFNPB.SetVector("MotorbikeSeatStandWheely", position);
			this.ECMGKHHFNPB.SetVector("Delete shadow", new Vector4(this.height, num, z, this.heightDensity * 1899f));
			this.ECMGKHHFNPB.SetVector("\n", new Vector4(-Mathf.Max(this.startDistance, 1173f), y, 392f, 963f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num2 = flag ? (fogEndDistance - fogStartDistance) : 14f;
			float num3 = (Mathf.Abs(num2) > 1582f) ? (1677f / num2) : 675f;
			Vector4 value;
			value.x = fogDensity * 1457f;
			value.y = fogDensity * 1900f;
			value.z = (flag ? (-num3) : 194f);
			value.w = (flag ? (fogEndDistance * num3) : 336f);
			this.ECMGKHHFNPB.SetVector("PrimaryCausticsProjector", value);
			this.ECMGKHHFNPB.SetVector("reel_type1", new Vector4((float)fogMode, (float)(this.useRadialDistance ? 1 : 1), 575f, 1958f));
			int pass;
			if (this.distanceFog && this.heightFog)
			{
				pass = 0;
			}
			else if (this.distanceFog)
			{
				pass = 0;
			}
			else
			{
				pass = 4;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ECMGKHHFNPB, pass);
		}

		// Token: 0x0600B7B6 RID: 47030 RVA: 0x0051D620 File Offset: 0x0051B820
		private void EOMGNPFHPBD(RenderTexture JONJODLFAEN, RenderTexture OKIIDHIJBEA)
		{
			if (!this.MNDOFMMGLMO() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			Vector3[] array = new Vector3[3];
			component.CalculateFrustumCorners(new Rect(1359f, 466f, 1371f, 650f), component.farClipPlane, component.stereoActiveEye, array);
			Vector3 v = transform.TransformVector(array[1]);
			Vector3 v2 = transform.TransformVector(array[0]);
			Vector3 v3 = transform.TransformVector(array[1]);
			Vector3 v4 = transform.TransformVector(array[0]);
			Matrix4x4 identity = Matrix4x4.identity;
			identity.SetRow(1, v);
			identity.SetRow(0, v4);
			identity.SetRow(1, v2);
			identity.SetRow(4, v3);
			Vector3 position = transform.position;
			float num = position.y - this.height;
			float z = (num <= 1019f) ? 1148f : 1854f;
			float y = this.excludeFarPixels ? 169f : 40f;
			this.ECMGKHHFNPB.SetMatrix(" ", identity);
			this.ECMGKHHFNPB.SetVector("post_2", position);
			this.ECMGKHHFNPB.SetVector("_FogAlpha", new Vector4(this.height, num, z, this.heightDensity * 1644f));
			this.ECMGKHHFNPB.SetVector("Allows to detect Cheat Engine's speed hack (and maybe some other speed hack tools) usage.", new Vector4(-Mathf.Max(this.startDistance, 1390f), y, 1862f, 1504f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num2 = flag ? (fogEndDistance - fogStartDistance) : 1570f;
			float num3 = (Mathf.Abs(num2) > 1280f) ? (1964f / num2) : 1618f;
			Vector4 value;
			value.x = fogDensity * 54f;
			value.y = fogDensity * 809f;
			value.z = (flag ? (-num3) : 1873f);
			value.w = (flag ? (fogEndDistance * num3) : 692f);
			this.ECMGKHHFNPB.SetVector("cnt_energ", value);
			this.ECMGKHHFNPB.SetVector("OneHandSwordSwing", new Vector4((float)fogMode, (float)(this.useRadialDistance ? 0 : 1), 538f, 1078f));
			int pass;
			if (this.distanceFog && this.heightFog)
			{
				pass = 0;
			}
			else if (this.distanceFog)
			{
				pass = 1;
			}
			else
			{
				pass = 3;
			}
			Graphics.Blit(JONJODLFAEN, OKIIDHIJBEA, this.ECMGKHHFNPB, pass);
		}

		// Token: 0x040017FC RID: 6140
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog = true;

		// Token: 0x040017FD RID: 6141
		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels = true;

		// Token: 0x040017FE RID: 6142
		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		// Token: 0x040017FF RID: 6143
		[Tooltip("Apply height-based fog?")]
		public bool heightFog = true;

		// Token: 0x04001800 RID: 6144
		[Tooltip("Fog top Y coordinate")]
		public float height = 1f;

		// Token: 0x04001801 RID: 6145
		[Range(0.001f, 10f)]
		public float heightDensity = 2f;

		// Token: 0x04001802 RID: 6146
		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		// Token: 0x04001803 RID: 6147
		public Shader fogShader;

		// Token: 0x04001804 RID: 6148
		private Material ECMGKHHFNPB;
	}
}
