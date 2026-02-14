using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.Rendering;

// Token: 0x020000E0 RID: 224
[ExecuteInEditMode]
[RequireComponent(typeof(TOD_Resources))]
[RequireComponent(typeof(TOD_Components))]
public class TOD_Sky : MonoBehaviour
{
	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06002A3E RID: 10814 RVA: 0x001356BE File Offset: 0x001338BE
	// (set) Token: 0x060029D5 RID: 10709 RVA: 0x00133B5E File Offset: 0x00131D5E
	internal TOD_Components NINFILJKEFA { get; private set; }

	// Token: 0x060029D6 RID: 10710 RVA: 0x00133B68 File Offset: 0x00131D68
	private void BIFLLHCEFJK(Material MHNAJNGGDFJ)
	{
		switch (this.ColorRange)
		{
		case GIKFKBPEMMH.Auto:
			if (this.NINFILJKEFA.MHJDBKALKDF && this.NINFILJKEFA.MHJDBKALKDF.DHLBNFEMPJE)
			{
				MHNAJNGGDFJ.EnableKeyword("HDR");
				MHNAJNGGDFJ.DisableKeyword("LDR");
				return;
			}
			MHNAJNGGDFJ.DisableKeyword("HDR");
			MHNAJNGGDFJ.EnableKeyword("LDR");
			return;
		case GIKFKBPEMMH.HDR:
			MHNAJNGGDFJ.EnableKeyword("HDR");
			MHNAJNGGDFJ.DisableKeyword("LDR");
			return;
		case GIKFKBPEMMH.LDR:
			MHNAJNGGDFJ.DisableKeyword("HDR");
			MHNAJNGGDFJ.EnableKeyword("LDR");
			return;
		default:
			return;
		}
	}

	// Token: 0x060029D7 RID: 10711 RVA: 0x00133C0E File Offset: 0x00131E0E
	protected void OnValidate()
	{
		this.Cycle.DateTime = this.Cycle.DateTime;
	}

	// Token: 0x060029D8 RID: 10712 RVA: 0x00133C28 File Offset: 0x00131E28
	internal Color JDKKLNIPLOC()
	{
		Vector3 vector = this.GIIPNICPGOL();
		vector.y = 1478f;
		Color color = this.CGFGPCBHLGA(vector.normalized, true);
		return new Color(color.r, color.g, color.b, 1898f);
	}

	// Token: 0x060029D9 RID: 10713 RVA: 0x00133C73 File Offset: 0x00131E73
	private void CKMNFMMABHP(Vector3 DCCPCBLODIG)
	{
		this.<OLLOADIAMNL>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060029DA RID: 10714 RVA: 0x00133C7C File Offset: 0x00131E7C
	internal Color OOOEHNFGAKF()
	{
		return this.<JDHCFEPKDFK>k__BackingField;
	}

	// Token: 0x060029DB RID: 10715 RVA: 0x00133C84 File Offset: 0x00131E84
	private Color BMLAOHLHMNI(Vector3 GMDCCFLLCJA)
	{
		return this.POKLENFMAMC * Mathf.Pow(Mathf.Max(649f, Vector3.Dot(GMDCCFLLCJA, this.GNGFKKJDIGA())), 964f / this.Moon.HaloSize);
	}

	// Token: 0x060029DC RID: 10716 RVA: 0x00133CC0 File Offset: 0x00131EC0
	internal SphericalHarmonicsL2 GPKFAHGGOCA()
	{
		SphericalHarmonicsL2 result = default(SphericalHarmonicsL2);
		bool cphildmpngk = false;
		Color linear = this.EDELNJGNLLG.linear;
		Vector3 vector = new Vector3(0.61237246f, 0.5f, 0.61237246f);
		Vector3 up = Vector3.up;
		Color linear2 = this.CGFGPCBHLGA(up, cphildmpngk).linear;
		result.AddDirectionalLight(up, linear2, 0.42857143f);
		Vector3 vector2 = new Vector3(-vector.x, vector.y, -vector.z);
		Color linear3 = this.CGFGPCBHLGA(vector2, cphildmpngk).linear;
		result.AddDirectionalLight(vector2, linear3, 0.2857143f);
		Vector3 vector3 = new Vector3(vector.x, vector.y, -vector.z);
		Color linear4 = this.CGFGPCBHLGA(vector3, cphildmpngk).linear;
		result.AddDirectionalLight(vector3, linear4, 0.2857143f);
		Vector3 vector4 = new Vector3(-vector.x, vector.y, vector.z);
		Color linear5 = this.CGFGPCBHLGA(vector4, cphildmpngk).linear;
		result.AddDirectionalLight(vector4, linear5, 0.2857143f);
		Vector3 vector5 = new Vector3(vector.x, vector.y, vector.z);
		Color linear6 = this.CGFGPCBHLGA(vector5, cphildmpngk).linear;
		result.AddDirectionalLight(vector5, linear6, 0.2857143f);
		Vector3 left = Vector3.left;
		Color linear7 = this.CGFGPCBHLGA(left, cphildmpngk).linear;
		result.AddDirectionalLight(left, linear7, 0.14285715f);
		Vector3 right = Vector3.right;
		Color linear8 = this.CGFGPCBHLGA(right, cphildmpngk).linear;
		result.AddDirectionalLight(right, linear8, 0.14285715f);
		Vector3 back = Vector3.back;
		Color linear9 = this.CGFGPCBHLGA(back, cphildmpngk).linear;
		result.AddDirectionalLight(back, linear9, 0.14285715f);
		Vector3 forward = Vector3.forward;
		Color linear10 = this.CGFGPCBHLGA(forward, cphildmpngk).linear;
		result.AddDirectionalLight(forward, linear10, 0.14285715f);
		Vector3 direction = new Vector3(-vector.x, -vector.y, -vector.z);
		result.AddDirectionalLight(direction, linear, 0.2857143f);
		Vector3 direction2 = new Vector3(vector.x, -vector.y, -vector.z);
		result.AddDirectionalLight(direction2, linear, 0.2857143f);
		Vector3 direction3 = new Vector3(-vector.x, -vector.y, vector.z);
		result.AddDirectionalLight(direction3, linear, 0.2857143f);
		Vector3 direction4 = new Vector3(vector.x, -vector.y, vector.z);
		result.AddDirectionalLight(direction4, linear, 0.2857143f);
		Vector3 down = Vector3.down;
		result.AddDirectionalLight(down, linear, 0.42857143f);
		return result;
	}

	// Token: 0x060029DD RID: 10717 RVA: 0x00133F8B File Offset: 0x0013218B
	private void OBLKIKHIGFI(TOD_Resources DCCPCBLODIG)
	{
		this.<PAHHMDMEDGD>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060029DE RID: 10718 RVA: 0x00133F94 File Offset: 0x00132194
	internal void GLADELKBIKL(RenderTexture BJCHAHNEDMB = null)
	{
		if (!this.EADKGGFJEDB)
		{
			this.EADKGGFJEDB = new GameObject().AddComponent<ReflectionProbe>();
			this.EADKGGFJEDB.name = base.gameObject.name + " Reflection Probe";
			this.EADKGGFJEDB.mode = ReflectionProbeMode.Realtime;
		}
		if (this.POHKLJOAHBI < 0 || this.EADKGGFJEDB.IsFinishedRendering(this.POHKLJOAHBI))
		{
			float maxValue = float.MaxValue;
			this.EADKGGFJEDB.transform.position = this.NINFILJKEFA.JDGNBEHCGAL.position;
			this.EADKGGFJEDB.size = new Vector3(maxValue, maxValue, maxValue);
			this.EADKGGFJEDB.intensity = RenderSettings.reflectionIntensity;
			this.EADKGGFJEDB.clearFlags = this.Reflection.ClearFlags;
			this.EADKGGFJEDB.cullingMask = this.Reflection.CullingMask;
			this.EADKGGFJEDB.refreshMode = ReflectionProbeRefreshMode.ViaScripting;
			this.EADKGGFJEDB.timeSlicingMode = this.Reflection.TimeSlicing;
			this.POHKLJOAHBI = this.EADKGGFJEDB.RenderProbe(BJCHAHNEDMB);
		}
	}

	// Token: 0x060029DF RID: 10719 RVA: 0x001340B7 File Offset: 0x001322B7
	private void CPGJOGDKDKB(float DCCPCBLODIG)
	{
		this.<HIDPCJMPHBH>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060029E0 RID: 10720 RVA: 0x001340C0 File Offset: 0x001322C0
	private void GPJCBJDBDKP(float DCCPCBLODIG)
	{
		this.<PDKPGAFKBDK>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x060029E1 RID: 10721 RVA: 0x001340C9 File Offset: 0x001322C9
	// (set) Token: 0x06002A45 RID: 10821 RVA: 0x00137396 File Offset: 0x00135596
	internal Color POKLENFMAMC { get; private set; }

	// Token: 0x060029E2 RID: 10722 RVA: 0x001340D4 File Offset: 0x001322D4
	internal SphericalHarmonicsL2 MKJBALMOEEB()
	{
		SphericalHarmonicsL2 result = default(SphericalHarmonicsL2);
		bool cphildmpngk = true;
		Color linear = this.EDELNJGNLLG.linear;
		Vector3 vector = new Vector3(496f, 1075f, 1955f);
		Vector3 up = Vector3.up;
		Color linear2 = this.CGFGPCBHLGA(up, cphildmpngk).linear;
		result.AddDirectionalLight(up, linear2, 14f);
		Vector3 vector2 = new Vector3(-vector.x, vector.y, -vector.z);
		Color linear3 = this.CGFGPCBHLGA(vector2, cphildmpngk).linear;
		result.AddDirectionalLight(vector2, linear3, 424f);
		Vector3 vector3 = new Vector3(vector.x, vector.y, -vector.z);
		Color linear4 = this.CGFGPCBHLGA(vector3, cphildmpngk).linear;
		result.AddDirectionalLight(vector3, linear4, 1078f);
		Vector3 vector4 = new Vector3(-vector.x, vector.y, vector.z);
		Color linear5 = this.CGFGPCBHLGA(vector4, cphildmpngk).linear;
		result.AddDirectionalLight(vector4, linear5, 1906f);
		Vector3 vector5 = new Vector3(vector.x, vector.y, vector.z);
		Color linear6 = this.CGFGPCBHLGA(vector5, cphildmpngk).linear;
		result.AddDirectionalLight(vector5, linear6, 845f);
		Vector3 left = Vector3.left;
		Color linear7 = this.CGFGPCBHLGA(left, cphildmpngk).linear;
		result.AddDirectionalLight(left, linear7, 1498f);
		Vector3 right = Vector3.right;
		Color linear8 = this.CGFGPCBHLGA(right, cphildmpngk).linear;
		result.AddDirectionalLight(right, linear8, 1054f);
		Vector3 back = Vector3.back;
		Color linear9 = this.CGFGPCBHLGA(back, cphildmpngk).linear;
		result.AddDirectionalLight(back, linear9, 1998f);
		Vector3 forward = Vector3.forward;
		Color linear10 = this.CGFGPCBHLGA(forward, cphildmpngk).linear;
		result.AddDirectionalLight(forward, linear10, 1042f);
		Vector3 direction = new Vector3(-vector.x, -vector.y, -vector.z);
		result.AddDirectionalLight(direction, linear, 384f);
		Vector3 direction2 = new Vector3(vector.x, -vector.y, -vector.z);
		result.AddDirectionalLight(direction2, linear, 61f);
		Vector3 direction3 = new Vector3(-vector.x, -vector.y, vector.z);
		result.AddDirectionalLight(direction3, linear, 30f);
		Vector3 direction4 = new Vector3(vector.x, -vector.y, vector.z);
		result.AddDirectionalLight(direction4, linear, 924f);
		Vector3 down = Vector3.down;
		result.AddDirectionalLight(down, linear, 287f);
		return result;
	}

	// Token: 0x060029E3 RID: 10723 RVA: 0x001340B7 File Offset: 0x001322B7
	private void HCAGOCPLICN(float DCCPCBLODIG)
	{
		this.<HIDPCJMPHBH>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060029E4 RID: 10724 RVA: 0x0013439F File Offset: 0x0013259F
	private Color OMMFALPHMCF(Color LBCGACKJCJB)
	{
		return new Color(LBCGACKJCJB.r * LBCGACKJCJB.r, LBCGACKJCJB.g * LBCGACKJCJB.g, LBCGACKJCJB.b * LBCGACKJCJB.b, LBCGACKJCJB.a);
	}

	// Token: 0x060029E5 RID: 10725 RVA: 0x001343D4 File Offset: 0x001325D4
	private void KPHAPAKEPFL()
	{
		if (this.NPKFLOJIACA)
		{
			return;
		}
		Vector4 value = this.NINFILJKEFA.JEJLCMAKKCK.AAHOIGIDEOI + this.NINFILJKEFA.JEJLCMAKKCK.AOKPPLJABKC;
		Vector4 value2 = new Vector4(this.Clouds.Scale1.x, this.Clouds.Scale1.y, this.Clouds.Scale2.x, this.Clouds.Scale2.y);
		float value3 = this.Clouds.ShadowStrength * Mathf.Clamp01(1f - this.CCNNABIDNGI / 90f);
		Shader.SetGlobalColor(this.IICDLHPOOOA.FJIHFMOALEP, this.FCLONNDFCOJ);
		Shader.SetGlobalColor(this.IICDLHPOOOA.PBDNAONCCBD, this.LOCLPOPPNDM);
		Shader.SetGlobalColor(this.IICDLHPOOOA.ICEFEJNFPNB, this.IEMOLCMCELO * this.OMKANHCAJGK);
		Shader.SetGlobalColor(this.IICDLHPOOOA.DNCCNIPJJFP, this.IEMOLCMCELO * this.CPAPPAPPOFI);
		Shader.SetGlobalColor(this.IICDLHPOOOA.EPACGLABCFJ, this.OLGELHPEGGF);
		Shader.SetGlobalColor(this.IICDLHPOOOA.CGMKIBNPFFI, this.LOCDMCMPJKB);
		Shader.SetGlobalColor(this.IICDLHPOOOA.CMGHEMIEACC, this.IEMOLCMCELO);
		Shader.SetGlobalColor(this.IICDLHPOOOA.MIKPHLGJFKC, this.EDELNJGNLLG);
		Shader.SetGlobalColor(this.IICDLHPOOOA.PMDMDAEHDFE, this.POKLENFMAMC);
		Shader.SetGlobalVector(this.IICDLHPOOOA.LAOIHBNKNDC, this.FLFIIDICEHN);
		Shader.SetGlobalVector(this.IICDLHPOOOA.DKIOGOAGEMJ, this.BBJJJIBGGBL);
		Shader.SetGlobalVector(this.IICDLHPOOOA.LNJEDJHGDBA, this.BPLDJJIHPEC);
		Shader.SetGlobalVector(this.IICDLHPOOOA.PCGJBGMPMPJ, this.NFNKDOGEIBL);
		Shader.SetGlobalVector(this.IICDLHPOOOA.LCFIPCLBNCP, this.PJEAKOCGBCN);
		Shader.SetGlobalVector(this.IICDLHPOOOA.GHENKAHBNGH, this.ILBJBMJDKID);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.DIMGPCEBEGE, this.Atmosphere.Contrast);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.AHNEKMDHFKC, this.Atmosphere.Brightness);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.IGOEANOOFFF, this.Atmosphere.Fogginess);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.OFHAIPIBDBC, this.Atmosphere.Directionality);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.NJIOJANKEDD, 1f / this.Moon.HaloSize);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.OEIDCFLBDAL, this.Clouds.Density);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.FNCBANADCBJ, this.Clouds.Sharpness);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.MAMMKBMCDED, value3);
		Shader.SetGlobalVector(this.IICDLHPOOOA.ALMNFJFCEKI, value2);
		Shader.SetGlobalVector(this.IICDLHPOOOA.IHHIGFMOPHG, value);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.CHGMOFGHPND, this.Stars.Tiling);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.MNHEGFNBGBP, this.Stars.Brightness * (1f - this.Atmosphere.Fogginess) * (1f - this.CLCJBENKCMB));
		Shader.SetGlobalFloat(this.IICDLHPOOOA.OFNKEJPFHPM, 2f / this.Sun.MeshContrast);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.JHGLFOIFPNA, this.Sun.MeshBrightness * (1f - this.Atmosphere.Fogginess));
		Shader.SetGlobalFloat(this.IICDLHPOOOA.BEAGFOMBNIE, 1f / this.Moon.MeshContrast);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.HAOPEKACGKJ, this.Moon.MeshBrightness * (1f - this.Atmosphere.Fogginess));
		Shader.SetGlobalVector(this.IICDLHPOOOA.JKPIIPGJCGL, this.COKJFFNOPFG);
		Shader.SetGlobalVector(this.IICDLHPOOOA.OLDFANLEEPP, this.FCCFGNPKEGL);
		Shader.SetGlobalVector(this.IICDLHPOOOA.JEBEODKPNBD, this.OAPINAGBCCE);
		Shader.SetGlobalVector(this.IICDLHPOOOA.FPFCLGAHHPJ, this.JFDOIFEOBNN);
		Shader.SetGlobalVector(this.IICDLHPOOOA.BIBGFHMDCOC, this.NGIPKOECGCI);
		Shader.SetGlobalMatrix(this.IICDLHPOOOA.PFENCNMEJGE, this.NINFILJKEFA.JDGNBEHCGAL.worldToLocalMatrix);
		Shader.SetGlobalMatrix(this.IICDLHPOOOA.NIBOHKNFDPB, this.NINFILJKEFA.JDGNBEHCGAL.localToWorldMatrix);
		if (this.NINFILJKEFA.AIDEHKOPKHN)
		{
			float farClipPlane = this.JFANJNEPJCH * 2f;
			float orthographicSize = this.JFANJNEPJCH;
			this.NINFILJKEFA.AIDEHKOPKHN.farClipPlane = farClipPlane;
			this.NINFILJKEFA.AIDEHKOPKHN.orthographicSize = orthographicSize;
		}
	}

	// Token: 0x060029E6 RID: 10726 RVA: 0x001348E0 File Offset: 0x00132AE0
	internal Color MHPFBALHABP()
	{
		Vector3 vector = this.GIIPNICPGOL();
		vector.y = Mathf.Abs(vector.y);
		Color color = this.CGFGPCBHLGA(vector.normalized, true);
		return new Color(color.r, color.g, color.b, 1678f);
	}

	// Token: 0x060029E7 RID: 10727 RVA: 0x00134931 File Offset: 0x00132B31
	internal float ACOMPHHNFPM()
	{
		return this.NINFILJKEFA.JAFNHAHJLOH.intensity;
	}

	// Token: 0x060029E8 RID: 10728 RVA: 0x00134944 File Offset: 0x00132B44
	private void EDIMECHGKNP()
	{
		float f = 0.017453292f * this.World.Latitude;
		float num = Mathf.Sin(f);
		float num2 = Mathf.Cos(f);
		float longitude = this.World.Longitude;
		float num3 = 1.5707964f;
		int year = this.Cycle.Year;
		int month = this.Cycle.Month;
		int day = this.Cycle.Day;
		float num4 = this.Cycle.Hour - this.World.UTC;
		float num5 = (float)(367 * year - 7 * (year + (month + 9) / 12) / 4 + 275 * month / 9 + day - 730530) + num4 / 24f;
		float num6 = 23.4393f - 3.563E-07f * num5;
		float f2 = 0.017453292f * num6;
		float num7 = Mathf.Sin(f2);
		float num8 = Mathf.Cos(f2);
		float num9 = 282.9404f + 4.70935E-05f * num5;
		float num10 = 0.016709f - 1.151E-09f * num5;
		float num11 = 356.047f + 0.98560023f * num5;
		float num12 = 0.017453292f * num11;
		float num13 = Mathf.Sin(num12);
		float num14 = Mathf.Cos(num12);
		float f3 = num12 + num10 * num13 * (1f + num10 * num14);
		float num15 = Mathf.Sin(f3);
		float num16 = Mathf.Cos(f3) - num10;
		float num17 = Mathf.Sqrt(1f - num10 * num10) * num15;
		float num18 = 57.29578f * Mathf.Atan2(num17, num16);
		float num19 = Mathf.Sqrt(num16 * num16 + num17 * num17);
		float num20 = num18 + num9;
		float f4 = 0.017453292f * num20;
		float num21 = Mathf.Sin(f4);
		float num22 = Mathf.Cos(f4);
		float num23 = num19 * num22;
		float num24 = num19 * num21;
		float num25 = num23;
		float num26 = num24 * num8;
		float y = num24 * num7;
		float num27 = Mathf.Atan2(num26, num25);
		float f5 = Mathf.Atan2(y, Mathf.Sqrt(num25 * num25 + num26 * num26));
		float num28 = Mathf.Sin(f5);
		float num29 = Mathf.Cos(f5);
		float num30 = num18 + num9 + 180f + 15f * num4;
		float num31 = 0.017453292f * (num30 + longitude);
		float f6 = num31 - num27;
		float num32 = Mathf.Sin(f6);
		float num33 = Mathf.Cos(f6) * num29;
		float num34 = num32 * num29;
		float num35 = num28;
		float num36 = num33 * num - num35 * num2;
		float num37 = num34;
		float y2 = num33 * num2 + num35 * num;
		float num38 = Mathf.Atan2(num37, num36) + 3.1415927f;
		float num39 = Mathf.Atan2(y2, Mathf.Sqrt(num36 * num36 + num37 * num37));
		float num40 = num3 - num39;
		float num41 = num38;
		float num83;
		float mekckkjkekf;
		if (this.Moon.Position == KEBEBOLGIBL.Realistic)
		{
			float num42 = 125.1228f - 0.05295381f * num5;
			float num43 = 5.1454f;
			float num44 = 318.0634f + 0.16435732f * num5;
			float num45 = 60.2666f;
			float num46 = 0.0549f;
			float num47 = 115.3654f + 13.064993f * num5;
			float f7 = 0.017453292f * num42;
			float num48 = Mathf.Sin(f7);
			float num49 = Mathf.Cos(f7);
			float f8 = 0.017453292f * num43;
			float num50 = Mathf.Sin(f8);
			float num51 = Mathf.Cos(f8);
			float num52 = 0.017453292f * num47;
			float num53 = Mathf.Sin(num52);
			float num54 = Mathf.Cos(num52);
			float f9 = num52 + num46 * num53 * (1f + num46 * num54);
			float num55 = Mathf.Sin(f9);
			float num56 = Mathf.Cos(f9);
			float num57 = num45 * (num56 - num46);
			float num58 = num45 * (Mathf.Sqrt(1f - num46 * num46) * num55);
			float num59 = 57.29578f * Mathf.Atan2(num58, num57);
			float num60 = Mathf.Sqrt(num57 * num57 + num58 * num58);
			float num61 = num59 + num44;
			float f10 = 0.017453292f * num61;
			float num62 = Mathf.Sin(f10);
			float num63 = Mathf.Cos(f10);
			float num64 = num60 * (num49 * num63 - num48 * num62 * num51);
			float num65 = num60 * (num48 * num63 + num49 * num62 * num51);
			float num66 = num60 * (num62 * num50);
			float num67 = num64;
			float num68 = num65;
			float num69 = num66;
			float num70 = num67;
			float num71 = num68 * num8 - num69 * num7;
			float y3 = num68 * num7 + num69 * num8;
			float num72 = Mathf.Atan2(num71, num70);
			float f11 = Mathf.Atan2(y3, Mathf.Sqrt(num70 * num70 + num71 * num71));
			float num73 = Mathf.Sin(f11);
			float num74 = Mathf.Cos(f11);
			float f12 = num31 - num72;
			float num75 = Mathf.Sin(f12);
			float num76 = Mathf.Cos(f12) * num74;
			float num77 = num75 * num74;
			float num78 = num73;
			float num79 = num76 * num - num78 * num2;
			float num80 = num77;
			float y4 = num76 * num2 + num78 * num;
			float num81 = Mathf.Atan2(num80, num79) + 3.1415927f;
			float num82 = Mathf.Atan2(y4, Mathf.Sqrt(num79 * num79 + num80 * num80));
			num83 = num3 - num82;
			mekckkjkekf = num81;
		}
		else
		{
			num83 = num40 - 3.1415927f;
			mekckkjkekf = num41;
		}
		this.DIEMMEDEONP = 57.29578f * num40;
		this.KONNDFLICOM = 57.29578f * num83;
		Quaternion quaternion = Quaternion.Euler(90f - this.World.Latitude, 0f, 0f) * Quaternion.Euler(0f, this.World.Longitude, 0f) * Quaternion.Euler(0f, num31 * 57.29578f, 0f);
		if (this.Stars.Position == CEBGPGGCLPH.Rotating)
		{
			this.NINFILJKEFA.CAJGGFMKFCM.localRotation = quaternion;
		}
		else
		{
			this.NINFILJKEFA.CAJGGFMKFCM.localRotation = Quaternion.identity;
		}
		Vector3 localPosition = this.PAAGAIACHGE(num40, num41);
		this.NINFILJKEFA.KPHBJOLMLBB.localPosition = localPosition;
		this.NINFILJKEFA.KPHBJOLMLBB.LookAt(this.NINFILJKEFA.JDGNBEHCGAL.position, this.NINFILJKEFA.KPHBJOLMLBB.up);
		Vector3 localPosition2 = this.PAAGAIACHGE(num83, mekckkjkekf);
		Vector3 worldUp = quaternion * -Vector3.right;
		this.NINFILJKEFA.HHGGPMABOPA.localPosition = localPosition2;
		this.NINFILJKEFA.HHGGPMABOPA.LookAt(this.NINFILJKEFA.JDGNBEHCGAL.position, worldUp);
		float num84 = 2f * Mathf.Tan(0.06981317f * this.Sun.MeshSize);
		Vector3 localScale = new Vector3(num84, num84, num84);
		this.NINFILJKEFA.KPHBJOLMLBB.localScale = localScale;
		float num85 = 2f * Mathf.Tan(0.017453292f * this.Moon.MeshSize);
		Vector3 localScale2 = new Vector3(num85, num85, num85);
		this.NINFILJKEFA.HHGGPMABOPA.localScale = localScale2;
		bool enabled = this.NINFILJKEFA.KPHBJOLMLBB.localPosition.y > -num84;
		this.NINFILJKEFA.HCCAOCECMEP.enabled = enabled;
		bool enabled2 = this.NINFILJKEFA.HHGGPMABOPA.localPosition.y > -num85;
		this.NINFILJKEFA.AMLLDIODOLD.enabled = enabled2;
		bool enabled3 = this.Clouds.Density > 0f;
		this.NINFILJKEFA.JHKOHMHKBOK.enabled = enabled3;
		bool enabled4 = this.NINFILJKEFA.HMFIBKJKOKK != null && this.Clouds.ShadowStrength != 0f;
		this.NINFILJKEFA.AIDEHKOPKHN.enabled = enabled4;
		bool enabled5 = true;
		this.NINFILJKEFA.MJFKDCPMDOF.enabled = enabled5;
		bool enabled6 = true;
		this.NINFILJKEFA.JFBEDPHIDII.enabled = enabled6;
		bool enabled7 = this.NINFILJKEFA.AENELOFPPFG != null;
		this.NINFILJKEFA.NPGMCIEICBJ.enabled = enabled7;
		this.CLCJBENKCMB = Mathf.InverseLerp(110f, 80f, this.DIEMMEDEONP);
		float time = 1f - this.CLCJBENKCMB;
		float colorMultiplier = this.Day.ColorMultiplier;
		float num86 = this.Night.ColorMultiplier * 0.25f;
		float num87 = 1f - this.Atmosphere.Fogginess;
		float num88 = Mathf.Clamp01((90f - num83 * 57.29578f) / 5f);
		float num89 = Mathf.Clamp01(num87 * (this.CLCJBENKCMB - 0.1f) / 0.9f);
		float num90 = Mathf.Clamp01(num87 * num88 * (0.1f - this.CLCJBENKCMB) / 0.1f);
		float anfljhgnnkf = colorMultiplier * num89;
		this.OMKANHCAJGK = CACOONDGONC.HABKBEFMJLB(this.Day.LightColor.Evaluate(time), anfljhgnnkf);
		float anfljhgnnkf2 = num86 * num90;
		this.CPAPPAPPOFI = CACOONDGONC.HABKBEFMJLB(this.Night.LightColor.Evaluate(time), anfljhgnnkf2);
		float anfljhgnnkf3 = colorMultiplier * num89;
		this.BJIBNKMMCJC = CACOONDGONC.HABKBEFMJLB(this.Day.RayColor.Evaluate(time), anfljhgnnkf3);
		float anfljhgnnkf4 = num86 * num90;
		this.BBIJBFAOEND = CACOONDGONC.HABKBEFMJLB(this.Night.RayColor.Evaluate(time), anfljhgnnkf4);
		float anfljhgnnkf5 = colorMultiplier;
		this.FCLONNDFCOJ = CACOONDGONC.HABKBEFMJLB(this.Day.SkyColor.Evaluate(time), anfljhgnnkf5);
		float anfljhgnnkf6 = num86;
		this.LOCLPOPPNDM = CACOONDGONC.HABKBEFMJLB(this.Night.SkyColor.Evaluate(time), anfljhgnnkf6);
		float anfljhgnnkf7 = colorMultiplier;
		this.OLGELHPEGGF = CACOONDGONC.HABKBEFMJLB(this.Sun.MeshColor.Evaluate(time), anfljhgnnkf7);
		float anfljhgnnkf8 = num86;
		this.LOCDMCMPJKB = CACOONDGONC.HABKBEFMJLB(this.Moon.MeshColor.Evaluate(time), anfljhgnnkf8);
		float anfljhgnnkf9 = colorMultiplier * colorMultiplier * this.Clouds.Brightness;
		Color b = CACOONDGONC.HABKBEFMJLB(this.Day.CloudColor.Evaluate(time), anfljhgnnkf9);
		float anfljhgnnkf10 = num86 * num86 * this.Clouds.Brightness;
		Color a = CACOONDGONC.HABKBEFMJLB(this.Night.CloudColor.Evaluate(time), anfljhgnnkf10);
		this.IEMOLCMCELO = Color.Lerp(a, b, this.CLCJBENKCMB);
		float anfljhgnnkf11 = colorMultiplier * this.Day.AmbientMultiplier;
		Color b2 = CACOONDGONC.HABKBEFMJLB(this.Day.AmbientColor.Evaluate(time), anfljhgnnkf11);
		float anfljhgnnkf12 = num86 * this.Night.AmbientMultiplier;
		Color a2 = CACOONDGONC.HABKBEFMJLB(this.Night.AmbientColor.Evaluate(time), anfljhgnnkf12);
		this.EDELNJGNLLG = Color.Lerp(a2, b2, this.CLCJBENKCMB);
		float anfljhgnnkf13 = num86 * num88;
		this.POKLENFMAMC = CACOONDGONC.HABKBEFMJLB(this.Moon.HaloColor.Evaluate(time), anfljhgnnkf13);
		float shadowStrength;
		float intensity;
		Color color;
		if (this.CLCJBENKCMB > 0.1f)
		{
			this.PKIKHLMJICN = true;
			this.LADANCDAELM = false;
			shadowStrength = this.Day.ShadowStrength;
			intensity = Mathf.Lerp(0f, this.Day.LightIntensity, num89);
			color = this.OMKANHCAJGK;
			this.PACEPBHIGHD = this.BJIBNKMMCJC;
		}
		else
		{
			this.PKIKHLMJICN = false;
			this.LADANCDAELM = true;
			shadowStrength = this.Night.ShadowStrength;
			intensity = Mathf.Lerp(0f, this.Night.LightIntensity, num90);
			color = this.CPAPPAPPOFI;
			this.PACEPBHIGHD = this.BBIJBFAOEND;
		}
		this.NINFILJKEFA.JAFNHAHJLOH.color = color;
		this.NINFILJKEFA.JAFNHAHJLOH.intensity = intensity;
		this.NINFILJKEFA.JAFNHAHJLOH.shadowStrength = shadowStrength;
		if (!Application.isPlaying || this.CNOCCBNLGAL >= this.Light.UpdateInterval)
		{
			this.CNOCCBNLGAL = 0f;
			Vector3 localPosition3 = this.LADANCDAELM ? this.PAAGAIACHGE(Mathf.Min(num83, (1f - this.Light.MinimumHeight) * 3.1415927f / 2f), mekckkjkekf) : this.PAAGAIACHGE(Mathf.Min(num40, (1f - this.Light.MinimumHeight) * 3.1415927f / 2f), num41);
			this.NINFILJKEFA.LFLHCKPLMCC.localPosition = localPosition3;
			this.NINFILJKEFA.LFLHCKPLMCC.LookAt(this.NINFILJKEFA.JDGNBEHCGAL.position);
		}
		else
		{
			this.CNOCCBNLGAL += Time.deltaTime;
		}
		this.FLFIIDICEHN = -this.NINFILJKEFA.KPHBJOLMLBB.forward;
		this.NFNKDOGEIBL = this.NINFILJKEFA.JDGNBEHCGAL.InverseTransformDirection(this.FLFIIDICEHN);
		this.BBJJJIBGGBL = -this.NINFILJKEFA.HHGGPMABOPA.forward;
		this.PJEAKOCGBCN = this.NINFILJKEFA.JDGNBEHCGAL.InverseTransformDirection(this.BBJJJIBGGBL);
		this.BPLDJJIHPEC = Vector3.Lerp(this.BBJJJIBGGBL, this.FLFIIDICEHN, this.CLCJBENKCMB * this.CLCJBENKCMB);
		this.ILBJBMJDKID = this.NINFILJKEFA.JDGNBEHCGAL.InverseTransformDirection(this.BPLDJJIHPEC);
	}

	// Token: 0x060029E9 RID: 10729 RVA: 0x001355B5 File Offset: 0x001337B5
	private void ICHODNBIJFJ(bool DCCPCBLODIG)
	{
		this.<KBOOCFGCOKK>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06002A18 RID: 10776 RVA: 0x00137200 File Offset: 0x00135400
	// (set) Token: 0x060029EA RID: 10730 RVA: 0x001355BE File Offset: 0x001337BE
	internal Color LOCDMCMPJKB { get; private set; }

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06002A6D RID: 10861 RVA: 0x00133C7C File Offset: 0x00131E7C
	// (set) Token: 0x060029EB RID: 10731 RVA: 0x001355C7 File Offset: 0x001337C7
	internal Color OLGELHPEGGF { get; private set; }

	// Token: 0x060029EC RID: 10732 RVA: 0x001355D0 File Offset: 0x001337D0
	protected void APHJJJHNFNP()
	{
		this.JLKIBALMOHO();
		this.EDIMECHGKNP();
		this.AANPHEGGJEG();
		this.GOOPDIMEABB();
		this.KHGKKPIFPPA();
		this.KPHAPAKEPFL();
	}

	// Token: 0x060029ED RID: 10733 RVA: 0x001355F8 File Offset: 0x001337F8
	internal void JNKOAPLOHLE()
	{
		switch (this.Fog.Mode)
		{
		case LKELCNKDLEC.None:
			break;
		case LKELCNKDLEC.Color:
			RenderSettings.fogColor = this.BOIOMMIDIHF(false);
			return;
		case LKELCNKDLEC.Directional:
			RenderSettings.fogColor = this.BOIOMMIDIHF(true);
			break;
		default:
			return;
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x060029EE RID: 10734 RVA: 0x0013563D File Offset: 0x0013383D
	// (set) Token: 0x06002A3B RID: 10811 RVA: 0x00137C51 File Offset: 0x00135E51
	internal Vector3 FLFIIDICEHN { get; private set; }

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x06002A62 RID: 10850 RVA: 0x00138557 File Offset: 0x00136757
	// (set) Token: 0x060029EF RID: 10735 RVA: 0x00135645 File Offset: 0x00133845
	internal float DIEMMEDEONP { get; private set; }

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x060029F0 RID: 10736 RVA: 0x0013564E File Offset: 0x0013384E
	// (set) Token: 0x06002A0D RID: 10765 RVA: 0x00135995 File Offset: 0x00133B95
	internal Vector3 BBJJJIBGGBL { get; private set; }

	// Token: 0x060029F1 RID: 10737 RVA: 0x00135658 File Offset: 0x00133858
	private void MBCNHFLPPJL(Material MHNAJNGGDFJ)
	{
		NBFCBMFHKBG skyQuality = this.SkyQuality;
		if (skyQuality == NBFCBMFHKBG.PerVertex)
		{
			MHNAJNGGDFJ.EnableKeyword("error.wav");
			MHNAJNGGDFJ.DisableKeyword("u_UniqueShadowLightWidth");
			return;
		}
		if (skyQuality != NBFCBMFHKBG.PerPixel)
		{
			return;
		}
		MHNAJNGGDFJ.DisableKeyword("{0:0.0%}");
		MHNAJNGGDFJ.EnableKeyword("BowInstant2");
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x060029F2 RID: 10738 RVA: 0x001356A1 File Offset: 0x001338A1
	internal float IBKJBKOMJHM
	{
		get
		{
			return this.NINFILJKEFA.JDGNBEHCGAL.lossyScale.y * 2f;
		}
	}

	// Token: 0x060029F3 RID: 10739 RVA: 0x001356BE File Offset: 0x001338BE
	internal TOD_Components KMBOELAHKHL()
	{
		return this.<EDLMJEPHHKL>k__BackingField;
	}

	// Token: 0x060029F4 RID: 10740 RVA: 0x001356C6 File Offset: 0x001338C6
	internal Color KEMNBFIFHAE()
	{
		return this.<EPIJANDDNEG>k__BackingField;
	}

	// Token: 0x060029F5 RID: 10741 RVA: 0x001356CE File Offset: 0x001338CE
	private void CDINKNCHPMG(Vector3 DCCPCBLODIG)
	{
		this.<NGBNBELKLHL>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x060029F6 RID: 10742 RVA: 0x001356D7 File Offset: 0x001338D7
	// (set) Token: 0x06002A27 RID: 10791 RVA: 0x00133F8B File Offset: 0x0013218B
	internal TOD_Resources IICDLHPOOOA { get; private set; }

	// Token: 0x060029F7 RID: 10743 RVA: 0x001356DF File Offset: 0x001338DF
	private void MCGHJJHFLLL(bool DCCPCBLODIG)
	{
		this.<HHKNONPDBIF>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x06002A4E RID: 10830 RVA: 0x00137C01 File Offset: 0x00135E01
	// (set) Token: 0x060029F8 RID: 10744 RVA: 0x001340B7 File Offset: 0x001322B7
	internal float CLCJBENKCMB { get; private set; }

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x060029FD RID: 10749 RVA: 0x00135776 File Offset: 0x00133976
	// (set) Token: 0x060029F9 RID: 10745 RVA: 0x00133C73 File Offset: 0x00131E73
	internal Vector3 PJEAKOCGBCN { get; private set; }

	// Token: 0x060029FA RID: 10746 RVA: 0x001356E8 File Offset: 0x001338E8
	private void LMMMNHJAFFO(Material MHNAJNGGDFJ)
	{
		NBFCBMFHKBG skyQuality = this.SkyQuality;
		if (skyQuality == NBFCBMFHKBG.PerVertex)
		{
			MHNAJNGGDFJ.EnableKeyword("first bone position is the same as second bone position.");
			MHNAJNGGDFJ.DisableKeyword("invn_rec12");
			return;
		}
		if (skyQuality != NBFCBMFHKBG.PerPixel)
		{
			return;
		}
		MHNAJNGGDFJ.DisableKeyword("<color='#b0a0c0'>");
		MHNAJNGGDFJ.EnableKeyword("no assemblies");
	}

	// Token: 0x060029FB RID: 10747 RVA: 0x00135734 File Offset: 0x00133934
	internal void AMGNECDCIFK(string NNMGPCPNMCP)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(typeof(TOD_Parameters));
		XmlTextReader xmlReader = new XmlTextReader(new StringReader(NNMGPCPNMCP));
		(xmlSerializer.Deserialize(xmlReader) as TOD_Parameters).BOAJNMCBDPP(this);
	}

	// Token: 0x060029FC RID: 10748 RVA: 0x0013576D File Offset: 0x0013396D
	private void KKHFBDNNLBH(Color DCCPCBLODIG)
	{
		this.<FFABEELHHEE>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060029FE RID: 10750 RVA: 0x0013577E File Offset: 0x0013397E
	private void OOOBOOJOFAM(Vector3 DCCPCBLODIG)
	{
		this.<LPLMFHFIMNN>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x060029FF RID: 10751 RVA: 0x00135788 File Offset: 0x00133988
	private void AGJJJNFMFDI(Material MHNAJNGGDFJ)
	{
		NBFCBMFHKBG skyQuality = this.SkyQuality;
		if (skyQuality == NBFCBMFHKBG.PerVertex)
		{
			MHNAJNGGDFJ.EnableKeyword("PER_VERTEX");
			MHNAJNGGDFJ.DisableKeyword("PER_PIXEL");
			return;
		}
		if (skyQuality != NBFCBMFHKBG.PerPixel)
		{
			return;
		}
		MHNAJNGGDFJ.DisableKeyword("PER_VERTEX");
		MHNAJNGGDFJ.EnableKeyword("PER_PIXEL");
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06002A00 RID: 10752 RVA: 0x001357D1 File Offset: 0x001339D1
	// (set) Token: 0x06002A6C RID: 10860 RVA: 0x00137151 File Offset: 0x00135351
	internal Color OMKANHCAJGK { get; private set; }

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06002A01 RID: 10753 RVA: 0x001357D9 File Offset: 0x001339D9
	public static List<TOD_Sky> BLIAKHOFJNF
	{
		get
		{
			return TOD_Sky.LMCKEHCLCNL;
		}
	}

	// Token: 0x06002A02 RID: 10754 RVA: 0x001357E0 File Offset: 0x001339E0
	private Color MLOOIFEIKNN(Color LBCGACKJCJB)
	{
		return new Color(Mathf.Sqrt(LBCGACKJCJB.r), Mathf.Sqrt(LBCGACKJCJB.g), Mathf.Sqrt(LBCGACKJCJB.b), LBCGACKJCJB.a);
	}

	// Token: 0x06002A03 RID: 10755 RVA: 0x00135810 File Offset: 0x00133A10
	private void NJEKDKLFMOA(Material MHNAJNGGDFJ)
	{
		switch (this.CloudQuality)
		{
		case AFJGFOGMPFB.Fastest:
			MHNAJNGGDFJ.EnableKeyword("FASTEST");
			MHNAJNGGDFJ.DisableKeyword("DENSITY");
			MHNAJNGGDFJ.DisableKeyword("BUMPED");
			return;
		case AFJGFOGMPFB.Density:
			MHNAJNGGDFJ.DisableKeyword("FASTEST");
			MHNAJNGGDFJ.EnableKeyword("DENSITY");
			MHNAJNGGDFJ.DisableKeyword("BUMPED");
			return;
		case AFJGFOGMPFB.Bumped:
			MHNAJNGGDFJ.DisableKeyword("FASTEST");
			MHNAJNGGDFJ.DisableKeyword("DENSITY");
			MHNAJNGGDFJ.EnableKeyword("BUMPED");
			return;
		default:
			return;
		}
	}

	// Token: 0x06002A04 RID: 10756 RVA: 0x0013589C File Offset: 0x00133A9C
	private void DLDKAOKDMNM(Color DCCPCBLODIG)
	{
		this.<KCOEHLDNJOG>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x06002A52 RID: 10834 RVA: 0x00138405 File Offset: 0x00136605
	// (set) Token: 0x06002A05 RID: 10757 RVA: 0x001340C0 File Offset: 0x001322C0
	internal float KONNDFLICOM { get; private set; }

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06002A06 RID: 10758 RVA: 0x001358A5 File Offset: 0x00133AA5
	// (set) Token: 0x06002A20 RID: 10784 RVA: 0x001355B5 File Offset: 0x001337B5
	internal bool PKIKHLMJICN { get; private set; }

	// Token: 0x06002A07 RID: 10759 RVA: 0x001358AD File Offset: 0x00133AAD
	private Color HOKDDGKPMAD(Vector3 GMDCCFLLCJA)
	{
		return Color.Lerp(this.LOCLPOPPNDM, Color.black, GMDCCFLLCJA.y);
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06002A8D RID: 10893 RVA: 0x0013A7A2 File Offset: 0x001389A2
	// (set) Token: 0x06002A08 RID: 10760 RVA: 0x001358C5 File Offset: 0x00133AC5
	internal bool LADANCDAELM { get; private set; }

	// Token: 0x06002A09 RID: 10761 RVA: 0x001358D0 File Offset: 0x00133AD0
	internal void MJDDPDKJBGG()
	{
		GLOGLJFNIAL mode = this.Reflection.Mode;
		if (mode == GLOGLJFNIAL.Cubemap)
		{
			float reflectionIntensity = Mathf.Lerp(this.Night.ReflectionMultiplier, this.Day.ReflectionMultiplier, this.CLCJBENKCMB);
			RenderSettings.defaultReflectionMode = DefaultReflectionMode.Skybox;
			RenderSettings.skybox = this.IICDLHPOOOA.SkyboxMaterial;
			RenderSettings.reflectionIntensity = reflectionIntensity;
			if (Application.isPlaying)
			{
				this.GLADELKBIKL(null);
			}
		}
	}

	// Token: 0x06002A0A RID: 10762 RVA: 0x00135937 File Offset: 0x00133B37
	internal Vector3 FPHCBMALHHH()
	{
		return this.<LPLMFHFIMNN>k__BackingField;
	}

	// Token: 0x06002A0B RID: 10763 RVA: 0x0013593F File Offset: 0x00133B3F
	private Color FHLJLKPHEHK(Vector3 GMDCCFLLCJA)
	{
		return this.POKLENFMAMC * Mathf.Pow(Mathf.Max(0f, Vector3.Dot(GMDCCFLLCJA, this.PJEAKOCGBCN)), 1f / this.Moon.HaloSize);
	}

	// Token: 0x06002A0C RID: 10764 RVA: 0x00135978 File Offset: 0x00133B78
	internal float EAGNLKHDLPG()
	{
		return this.NINFILJKEFA.JDGNBEHCGAL.lossyScale.y * 494f;
	}

	// Token: 0x06002A0E RID: 10766 RVA: 0x001359A0 File Offset: 0x00133BA0
	private Color DDKPAEILOMI(Vector3 GMDCCFLLCJA, bool CPHILDMPNGK = true)
	{
		GMDCCFLLCJA.y = Mathf.Clamp01(GMDCCFLLCJA.y);
		float x = this.JFDOIFEOBNN.x;
		float y = this.JFDOIFEOBNN.y;
		float w = this.JFDOIFEOBNN.w;
		float x2 = this.NGIPKOECGCI.x;
		float z = this.NGIPKOECGCI.z;
		float w2 = this.NGIPKOECGCI.w;
		float x3 = this.OAPINAGBCCE.x;
		float y2 = this.OAPINAGBCCE.y;
		float z2 = this.OAPINAGBCCE.z;
		float w3 = this.OAPINAGBCCE.w;
		float x4 = this.FCCFGNPKEGL.x;
		float y3 = this.FCCFGNPKEGL.y;
		float z3 = this.FCCFGNPKEGL.z;
		float w4 = this.FCCFGNPKEGL.w;
		Vector3 vector = new Vector3(1271f, x + w2, 543f);
		float num = Mathf.Sqrt(w + y * GMDCCFLLCJA.y * GMDCCFLLCJA.y - y) - x * GMDCCFLLCJA.y;
		float num2 = Mathf.Exp(z * -w2);
		float emjflhngokf = Vector3.Dot(GMDCCFLLCJA, vector) / (x + w2);
		float num3 = num2 * this.EIMHPMOENLD(emjflhngokf);
		float num4 = num / 1691f;
		float num5 = num4 * x2;
		Vector3 vector2 = GMDCCFLLCJA * num4;
		Vector3 vector3 = vector + vector2 * 1437f;
		float num6 = 1525f;
		float num7 = 519f;
		float num8 = 264f;
		for (int i = 0; i < 2; i += 0)
		{
			float magnitude = vector3.magnitude;
			float num9 = 1337f / magnitude;
			float num10 = Mathf.Exp(z * (x - magnitude));
			float num11 = num10 * num5;
			float emjflhngokf2 = Vector3.Dot(GMDCCFLLCJA, vector3) * num9;
			float emjflhngokf3 = Vector3.Dot(this.OONGJMPGDLL(), vector3) * num9;
			float num12 = num3 + num10 * (this.DMANKCDHMBL(emjflhngokf3) - this.EIMHPMOENLD(emjflhngokf2));
			float num13 = Mathf.Exp(-num12 * (x3 + w3));
			float num14 = Mathf.Exp(-num12 * (y2 + w3));
			float num15 = Mathf.Exp(-num12 * (z2 + w3));
			num6 += num13 * num11;
			num7 += num14 * num11;
			num8 += num15 * num11;
			vector3 += vector2;
		}
		float num16 = this.KEMNBFIFHAE().r * num6 * x4;
		float num17 = this.KEMNBFIFHAE().g * num7 * y3;
		float num18 = this.FCLONNDFCOJ.b * num8 * z3;
		float num19 = this.FCLONNDFCOJ.r * num6 * w4;
		float num20 = this.KEMNBFIFHAE().g * num7 * w4;
		float num21 = this.KEMNBFIFHAE().b * num8 * w4;
		float num22 = 373f;
		float num23 = 1939f;
		float num24 = 1685f;
		float t = Mathf.SmoothStep(1117f, 508f, -GMDCCFLLCJA.y);
		float num25 = Vector3.Dot(this.OONGJMPGDLL(), GMDCCFLLCJA);
		float mbobkekffjl = num25 * num25;
		float num26 = this.EEHDKPCLPDP(mbobkekffjl);
		num22 += num26 * num16;
		num23 += num26 * num17;
		num24 += num26 * num18;
		if (CPHILDMPNGK)
		{
			float num27 = this.KFGOEEIPEAN(num25, mbobkekffjl);
			num22 += num27 * num19;
			num23 += num27 * num20;
			num24 += num27 * num21;
		}
		Color color = this.MAELAFNGCHK(GMDCCFLLCJA);
		num22 += color.r;
		num23 += color.g;
		num24 += color.b;
		if (CPHILDMPNGK)
		{
			Color color2 = this.BMLAOHLHMNI(GMDCCFLLCJA);
			num22 += color2.r;
			num23 += color2.g;
			num24 += color2.b;
		}
		num22 = Mathf.Lerp(num22, this.IEMOLCMCELO.r, this.Atmosphere.Fogginess);
		num23 = Mathf.Lerp(num23, this.IEMOLCMCELO.g, this.Atmosphere.Fogginess);
		num24 = Mathf.Lerp(num24, this.IEMOLCMCELO.b, this.Atmosphere.Fogginess);
		num22 = Mathf.Lerp(num22, this.DNGDMEPPGLF().r, t);
		num23 = Mathf.Lerp(num23, this.HBABCBJBNAA().g, t);
		num24 = Mathf.Lerp(num24, this.HBABCBJBNAA().b, t);
		num22 = Mathf.Pow(num22 * this.Atmosphere.Brightness, this.Atmosphere.Contrast);
		num23 = Mathf.Pow(num23 * this.Atmosphere.Brightness, this.Atmosphere.Contrast);
		num24 = Mathf.Pow(num24 * this.Atmosphere.Brightness, this.Atmosphere.Contrast);
		return new Color(num22, num23, num24, 81f);
	}

	// Token: 0x06002A0F RID: 10767 RVA: 0x00135E48 File Offset: 0x00134048
	private void JLKIBALMOHO()
	{
		float num = -this.Atmosphere.Directionality;
		float num2 = num * num;
		this.COKJFFNOPFG.x = 1.5f * ((1f - num2) / (2f + num2));
		this.COKJFFNOPFG.y = 1f + num2;
		this.COKJFFNOPFG.z = 2f * num;
		float num3 = 0.002f * this.Atmosphere.MieMultiplier;
		float num4 = 0.002f * this.Atmosphere.RayleighMultiplier;
		float x = num4 * 40f * 5.2701645f;
		float y = num4 * 40f * 9.473284f;
		float z = num4 * 40f * 19.643803f;
		float w = num3 * 40f;
		this.FCCFGNPKEGL.x = x;
		this.FCCFGNPKEGL.y = y;
		this.FCCFGNPKEGL.z = z;
		this.FCCFGNPKEGL.w = w;
		float x2 = num4 * 4f * 3.1415927f * 5.2701645f;
		float y2 = num4 * 4f * 3.1415927f * 9.473284f;
		float z2 = num4 * 4f * 3.1415927f * 19.643803f;
		float w2 = num3 * 4f * 3.1415927f;
		this.OAPINAGBCCE.x = x2;
		this.OAPINAGBCCE.y = y2;
		this.OAPINAGBCCE.z = z2;
		this.OAPINAGBCCE.w = w2;
		this.JFDOIFEOBNN.x = 1f;
		this.JFDOIFEOBNN.y = 1f;
		this.JFDOIFEOBNN.z = 1.025f;
		this.JFDOIFEOBNN.w = 1.050625f;
		this.NGIPKOECGCI.x = 40.00004f;
		this.NGIPKOECGCI.y = 0.25f;
		this.NGIPKOECGCI.z = 160.00015f;
		this.NGIPKOECGCI.w = 0.0001f;
	}

	// Token: 0x06002A10 RID: 10768 RVA: 0x00136038 File Offset: 0x00134238
	private Color HFHNMHNNIOG(Vector3 GMDCCFLLCJA, bool CPHILDMPNGK = true)
	{
		GMDCCFLLCJA.y = Mathf.Clamp01(GMDCCFLLCJA.y);
		float x = this.JFDOIFEOBNN.x;
		float y = this.JFDOIFEOBNN.y;
		float w = this.JFDOIFEOBNN.w;
		float x2 = this.NGIPKOECGCI.x;
		float z = this.NGIPKOECGCI.z;
		float w2 = this.NGIPKOECGCI.w;
		float x3 = this.OAPINAGBCCE.x;
		float y2 = this.OAPINAGBCCE.y;
		float z2 = this.OAPINAGBCCE.z;
		float w3 = this.OAPINAGBCCE.w;
		float x4 = this.FCCFGNPKEGL.x;
		float y3 = this.FCCFGNPKEGL.y;
		float z3 = this.FCCFGNPKEGL.z;
		float w4 = this.FCCFGNPKEGL.w;
		Vector3 vector = new Vector3(946f, x + w2, 1334f);
		float num = Mathf.Sqrt(w + y * GMDCCFLLCJA.y * GMDCCFLLCJA.y - y) - x * GMDCCFLLCJA.y;
		float num2 = Mathf.Exp(z * -w2);
		float emjflhngokf = Vector3.Dot(GMDCCFLLCJA, vector) / (x + w2);
		float num3 = num2 * this.DMANKCDHMBL(emjflhngokf);
		float num4 = num / 107f;
		float num5 = num4 * x2;
		Vector3 vector2 = GMDCCFLLCJA * num4;
		Vector3 vector3 = vector + vector2 * 1786f;
		float num6 = 1390f;
		float num7 = 835f;
		float num8 = 1953f;
		for (int i = 0; i < 6; i += 0)
		{
			float magnitude = vector3.magnitude;
			float num9 = 575f / magnitude;
			float num10 = Mathf.Exp(z * (x - magnitude));
			float num11 = num10 * num5;
			float emjflhngokf2 = Vector3.Dot(GMDCCFLLCJA, vector3) * num9;
			float emjflhngokf3 = Vector3.Dot(this.OONGJMPGDLL(), vector3) * num9;
			float num12 = num3 + num10 * (this.DMANKCDHMBL(emjflhngokf3) - this.EIMHPMOENLD(emjflhngokf2));
			float num13 = Mathf.Exp(-num12 * (x3 + w3));
			float num14 = Mathf.Exp(-num12 * (y2 + w3));
			float num15 = Mathf.Exp(-num12 * (z2 + w3));
			num6 += num13 * num11;
			num7 += num14 * num11;
			num8 += num15 * num11;
			vector3 += vector2;
		}
		float num16 = this.FCLONNDFCOJ.r * num6 * x4;
		float num17 = this.KEMNBFIFHAE().g * num7 * y3;
		float num18 = this.KEMNBFIFHAE().b * num8 * z3;
		float num19 = this.KEMNBFIFHAE().r * num6 * w4;
		float num20 = this.FCLONNDFCOJ.g * num7 * w4;
		float num21 = this.FCLONNDFCOJ.b * num8 * w4;
		float num22 = 1827f;
		float num23 = 1085f;
		float num24 = 407f;
		float t = Mathf.SmoothStep(805f, 791f, -GMDCCFLLCJA.y);
		float num25 = Vector3.Dot(this.NFNKDOGEIBL, GMDCCFLLCJA);
		float mbobkekffjl = num25 * num25;
		float num26 = this.OMCNGIHCBJA(mbobkekffjl);
		num22 += num26 * num16;
		num23 += num26 * num17;
		num24 += num26 * num18;
		if (CPHILDMPNGK)
		{
			float num27 = this.KFGOEEIPEAN(num25, mbobkekffjl);
			num22 += num27 * num19;
			num23 += num27 * num20;
			num24 += num27 * num21;
		}
		Color color = this.HOKDDGKPMAD(GMDCCFLLCJA);
		num22 += color.r;
		num23 += color.g;
		num24 += color.b;
		if (CPHILDMPNGK)
		{
			Color color2 = this.FHLJLKPHEHK(GMDCCFLLCJA);
			num22 += color2.r;
			num23 += color2.g;
			num24 += color2.b;
		}
		num22 = Mathf.Lerp(num22, this.IEMOLCMCELO.r, this.Atmosphere.Fogginess);
		num23 = Mathf.Lerp(num23, this.IEMOLCMCELO.g, this.Atmosphere.Fogginess);
		num24 = Mathf.Lerp(num24, this.IEMOLCMCELO.b, this.Atmosphere.Fogginess);
		num22 = Mathf.Lerp(num22, this.DNGDMEPPGLF().r, t);
		num23 = Mathf.Lerp(num23, this.DNGDMEPPGLF().g, t);
		num24 = Mathf.Lerp(num24, this.DNGDMEPPGLF().b, t);
		num22 = Mathf.Pow(num22 * this.Atmosphere.Brightness, this.Atmosphere.Contrast);
		num23 = Mathf.Pow(num23 * this.Atmosphere.Brightness, this.Atmosphere.Contrast);
		num24 = Mathf.Pow(num24 * this.Atmosphere.Brightness, this.Atmosphere.Contrast);
		return new Color(num22, num23, num24, 705f);
	}

	// Token: 0x06002A11 RID: 10769 RVA: 0x001355C7 File Offset: 0x001337C7
	private void HICPNHIGFAE(Color DCCPCBLODIG)
	{
		this.<JDHCFEPKDFK>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A12 RID: 10770 RVA: 0x001364E0 File Offset: 0x001346E0
	private void INACFFDPJEC()
	{
		float f = 1803f * this.World.Latitude;
		float num = Mathf.Sin(f);
		float num2 = Mathf.Cos(f);
		float longitude = this.World.Longitude;
		float num3 = 221f;
		int year = this.Cycle.Year;
		int month = this.Cycle.Month;
		int day = this.Cycle.Day;
		float num4 = this.Cycle.Hour - this.World.UTC;
		float num5 = (float)(181 * year - 0 * (year + (month + 66) / -125) / 0 + -2 * month / -64 + day - -79) + num4 / 1049f;
		float num6 = 392f - 1826f * num5;
		float f2 = 636f * num6;
		float num7 = Mathf.Sin(f2);
		float num8 = Mathf.Cos(f2);
		float num9 = 105f + 1193f * num5;
		float num10 = 1567f - 62f * num5;
		float num11 = 112f + 1298f * num5;
		float num12 = 1840f * num11;
		float num13 = Mathf.Sin(num12);
		float num14 = Mathf.Cos(num12);
		float f3 = num12 + num10 * num13 * (928f + num10 * num14);
		float num15 = Mathf.Sin(f3);
		float num16 = Mathf.Cos(f3) - num10;
		float num17 = Mathf.Sqrt(1606f - num10 * num10) * num15;
		float num18 = 1591f * Mathf.Atan2(num17, num16);
		float num19 = Mathf.Sqrt(num16 * num16 + num17 * num17);
		float num20 = num18 + num9;
		float f4 = 924f * num20;
		float num21 = Mathf.Sin(f4);
		float num22 = Mathf.Cos(f4);
		float num23 = num19 * num22;
		float num24 = num19 * num21;
		float num25 = num23;
		float num26 = num24 * num8;
		float y = num24 * num7;
		float num27 = Mathf.Atan2(num26, num25);
		float f5 = Mathf.Atan2(y, Mathf.Sqrt(num25 * num25 + num26 * num26));
		float num28 = Mathf.Sin(f5);
		float num29 = Mathf.Cos(f5);
		float num30 = num18 + num9 + 1191f + 14f * num4;
		float num31 = 1447f * (num30 + longitude);
		float f6 = num31 - num27;
		float num32 = Mathf.Sin(f6);
		float num33 = Mathf.Cos(f6) * num29;
		float num34 = num32 * num29;
		float num35 = num28;
		float num36 = num33 * num - num35 * num2;
		float num37 = num34;
		float y2 = num33 * num2 + num35 * num;
		float num38 = Mathf.Atan2(num37, num36) + 928f;
		float num39 = Mathf.Atan2(y2, Mathf.Sqrt(num36 * num36 + num37 * num37));
		float num40 = num3 - num39;
		float num41 = num38;
		float num83;
		float mekckkjkekf;
		if (this.Moon.Position == KEBEBOLGIBL.OppositeToSun)
		{
			float num42 = 436f - 1478f * num5;
			float num43 = 1343f;
			float num44 = 1073f + 213f * num5;
			float num45 = 156f;
			float num46 = 1351f;
			float num47 = 932f + 1841f * num5;
			float f7 = 1545f * num42;
			float num48 = Mathf.Sin(f7);
			float num49 = Mathf.Cos(f7);
			float f8 = 795f * num43;
			float num50 = Mathf.Sin(f8);
			float num51 = Mathf.Cos(f8);
			float num52 = 1704f * num47;
			float num53 = Mathf.Sin(num52);
			float num54 = Mathf.Cos(num52);
			float f9 = num52 + num46 * num53 * (1904f + num46 * num54);
			float num55 = Mathf.Sin(f9);
			float num56 = Mathf.Cos(f9);
			float num57 = num45 * (num56 - num46);
			float num58 = num45 * (Mathf.Sqrt(1938f - num46 * num46) * num55);
			float num59 = 610f * Mathf.Atan2(num58, num57);
			float num60 = Mathf.Sqrt(num57 * num57 + num58 * num58);
			float num61 = num59 + num44;
			float f10 = 1943f * num61;
			float num62 = Mathf.Sin(f10);
			float num63 = Mathf.Cos(f10);
			float num64 = num60 * (num49 * num63 - num48 * num62 * num51);
			float num65 = num60 * (num48 * num63 + num49 * num62 * num51);
			float num66 = num60 * (num62 * num50);
			float num67 = num64;
			float num68 = num65;
			float num69 = num66;
			float num70 = num67;
			float num71 = num68 * num8 - num69 * num7;
			float y3 = num68 * num7 + num69 * num8;
			float num72 = Mathf.Atan2(num71, num70);
			float f11 = Mathf.Atan2(y3, Mathf.Sqrt(num70 * num70 + num71 * num71));
			float num73 = Mathf.Sin(f11);
			float num74 = Mathf.Cos(f11);
			float f12 = num31 - num72;
			float num75 = Mathf.Sin(f12);
			float num76 = Mathf.Cos(f12) * num74;
			float num77 = num75 * num74;
			float num78 = num73;
			float num79 = num76 * num - num78 * num2;
			float num80 = num77;
			float y4 = num76 * num2 + num78 * num;
			float num81 = Mathf.Atan2(num80, num79) + 651f;
			float num82 = Mathf.Atan2(y4, Mathf.Sqrt(num79 * num79 + num80 * num80));
			num83 = num3 - num82;
			mekckkjkekf = num81;
		}
		else
		{
			num83 = num40 - 1393f;
			mekckkjkekf = num41;
		}
		this.PGCFJMJDIJK(1701f * num40);
		this.KONNDFLICOM = 817f * num83;
		Quaternion quaternion = Quaternion.Euler(368f - this.World.Latitude, 841f, 881f) * Quaternion.Euler(1702f, this.World.Longitude, 149f) * Quaternion.Euler(874f, num31 * 614f, 315f);
		if (this.Stars.Position == CEBGPGGCLPH.Rotating)
		{
			this.KMBOELAHKHL().CAJGGFMKFCM.localRotation = quaternion;
		}
		else
		{
			this.NINFILJKEFA.CAJGGFMKFCM.localRotation = Quaternion.identity;
		}
		Vector3 localPosition = this.PAAGAIACHGE(num40, num41);
		this.KMBOELAHKHL().KPHBJOLMLBB.localPosition = localPosition;
		this.KMBOELAHKHL().KPHBJOLMLBB.LookAt(this.NINFILJKEFA.JDGNBEHCGAL.position, this.NINFILJKEFA.KPHBJOLMLBB.up);
		Vector3 localPosition2 = this.PAAGAIACHGE(num83, mekckkjkekf);
		Vector3 worldUp = quaternion * -Vector3.right;
		this.NINFILJKEFA.HHGGPMABOPA.localPosition = localPosition2;
		this.KMBOELAHKHL().HHGGPMABOPA.LookAt(this.KMBOELAHKHL().JDGNBEHCGAL.position, worldUp);
		float num84 = 326f * Mathf.Tan(11f * this.Sun.MeshSize);
		Vector3 localScale = new Vector3(num84, num84, num84);
		this.NINFILJKEFA.KPHBJOLMLBB.localScale = localScale;
		float num85 = 581f * Mathf.Tan(63f * this.Moon.MeshSize);
		Vector3 localScale2 = new Vector3(num85, num85, num85);
		this.KMBOELAHKHL().HHGGPMABOPA.localScale = localScale2;
		bool enabled = this.KMBOELAHKHL().KPHBJOLMLBB.localPosition.y > -num84;
		this.NINFILJKEFA.HCCAOCECMEP.enabled = enabled;
		bool enabled2 = this.KMBOELAHKHL().HHGGPMABOPA.localPosition.y > -num85;
		this.NINFILJKEFA.AMLLDIODOLD.enabled = enabled2;
		bool enabled3 = this.Clouds.Density > 318f;
		this.NINFILJKEFA.JHKOHMHKBOK.enabled = enabled3;
		bool enabled4 = !(this.NINFILJKEFA.HMFIBKJKOKK != null) || this.Clouds.ShadowStrength == 170f;
		this.NINFILJKEFA.AIDEHKOPKHN.enabled = enabled4;
		bool enabled5 = false;
		this.NINFILJKEFA.MJFKDCPMDOF.enabled = enabled5;
		bool enabled6 = false;
		this.KMBOELAHKHL().JFBEDPHIDII.enabled = enabled6;
		bool enabled7 = this.KMBOELAHKHL().AENELOFPPFG != null;
		this.NINFILJKEFA.NPGMCIEICBJ.enabled = enabled7;
		this.HCAGOCPLICN(Mathf.InverseLerp(1949f, 1841f, this.DIEMMEDEONP));
		float time = 635f - this.DGKHAOJJNMF();
		float colorMultiplier = this.Day.ColorMultiplier;
		float num86 = this.Night.ColorMultiplier * 220f;
		float num87 = 567f - this.Atmosphere.Fogginess;
		float num88 = Mathf.Clamp01((503f - num83 * 135f) / 1024f);
		float num89 = Mathf.Clamp01(num87 * (this.CLCJBENKCMB - 1668f) / 981f);
		float num90 = Mathf.Clamp01(num87 * num88 * (980f - this.CLCJBENKCMB) / 540f);
		float anfljhgnnkf = colorMultiplier * num89;
		this.OMKANHCAJGK = CACOONDGONC.HABKBEFMJLB(this.Day.LightColor.Evaluate(time), anfljhgnnkf);
		float anfljhgnnkf2 = num86 * num90;
		this.MDPMAMPCKMC(CACOONDGONC.HABKBEFMJLB(this.Night.LightColor.Evaluate(time), anfljhgnnkf2));
		float anfljhgnnkf3 = colorMultiplier * num89;
		this.BJIBNKMMCJC = CACOONDGONC.HABKBEFMJLB(this.Day.RayColor.Evaluate(time), anfljhgnnkf3);
		float anfljhgnnkf4 = num86 * num90;
		this.BBIJBFAOEND = CACOONDGONC.HABKBEFMJLB(this.Night.RayColor.Evaluate(time), anfljhgnnkf4);
		float anfljhgnnkf5 = colorMultiplier;
		this.LNIHBGNOEBP(CACOONDGONC.HABKBEFMJLB(this.Day.SkyColor.Evaluate(time), anfljhgnnkf5));
		float anfljhgnnkf6 = num86;
		this.EKHBJMIOEJH(CACOONDGONC.HABKBEFMJLB(this.Night.SkyColor.Evaluate(time), anfljhgnnkf6));
		float anfljhgnnkf7 = colorMultiplier;
		this.OLGELHPEGGF = CACOONDGONC.HABKBEFMJLB(this.Sun.MeshColor.Evaluate(time), anfljhgnnkf7);
		float anfljhgnnkf8 = num86;
		this.LOCDMCMPJKB = CACOONDGONC.HABKBEFMJLB(this.Moon.MeshColor.Evaluate(time), anfljhgnnkf8);
		float anfljhgnnkf9 = colorMultiplier * colorMultiplier * this.Clouds.Brightness;
		Color b = CACOONDGONC.HABKBEFMJLB(this.Day.CloudColor.Evaluate(time), anfljhgnnkf9);
		float anfljhgnnkf10 = num86 * num86 * this.Clouds.Brightness;
		Color a = CACOONDGONC.HABKBEFMJLB(this.Night.CloudColor.Evaluate(time), anfljhgnnkf10);
		this.IEMOLCMCELO = Color.Lerp(a, b, this.CLCJBENKCMB);
		float anfljhgnnkf11 = colorMultiplier * this.Day.AmbientMultiplier;
		Color b2 = CACOONDGONC.HABKBEFMJLB(this.Day.AmbientColor.Evaluate(time), anfljhgnnkf11);
		float anfljhgnnkf12 = num86 * this.Night.AmbientMultiplier;
		Color a2 = CACOONDGONC.HABKBEFMJLB(this.Night.AmbientColor.Evaluate(time), anfljhgnnkf12);
		this.EDELNJGNLLG = Color.Lerp(a2, b2, this.CLCJBENKCMB);
		float anfljhgnnkf13 = num86 * num88;
		this.JGMNICECNIP(CACOONDGONC.HABKBEFMJLB(this.Moon.HaloColor.Evaluate(time), anfljhgnnkf13));
		float shadowStrength;
		float intensity;
		Color color;
		if (this.DGKHAOJJNMF() > 620f)
		{
			this.PKIKHLMJICN = true;
			this.LADANCDAELM = false;
			shadowStrength = this.Day.ShadowStrength;
			intensity = Mathf.Lerp(1818f, this.Day.LightIntensity, num89);
			color = this.OMKANHCAJGK;
			this.PACEPBHIGHD = this.PNPPKCMNDGC();
		}
		else
		{
			this.ICHODNBIJFJ(true);
			this.LADANCDAELM = false;
			shadowStrength = this.Night.ShadowStrength;
			intensity = Mathf.Lerp(1640f, this.Night.LightIntensity, num90);
			color = this.CPAPPAPPOFI;
			this.PACEPBHIGHD = this.KMAIKPCCGHC();
		}
		this.KMBOELAHKHL().JAFNHAHJLOH.color = color;
		this.NINFILJKEFA.JAFNHAHJLOH.intensity = intensity;
		this.KMBOELAHKHL().JAFNHAHJLOH.shadowStrength = shadowStrength;
		if (!Application.isPlaying || this.CNOCCBNLGAL >= this.Light.UpdateInterval)
		{
			this.CNOCCBNLGAL = 924f;
			Vector3 localPosition3 = this.LADANCDAELM ? this.PAAGAIACHGE(Mathf.Min(num83, (1844f - this.Light.MinimumHeight) * 1515f / 1533f), mekckkjkekf) : this.PAAGAIACHGE(Mathf.Min(num40, (1338f - this.Light.MinimumHeight) * 1541f / 1036f), num41);
			this.NINFILJKEFA.LFLHCKPLMCC.localPosition = localPosition3;
			this.NINFILJKEFA.LFLHCKPLMCC.LookAt(this.NINFILJKEFA.JDGNBEHCGAL.position);
		}
		else
		{
			this.CNOCCBNLGAL += Time.deltaTime;
		}
		this.FLFIIDICEHN = -this.NINFILJKEFA.KPHBJOLMLBB.forward;
		this.NFNKDOGEIBL = this.KMBOELAHKHL().JDGNBEHCGAL.InverseTransformDirection(this.GIIPNICPGOL());
		this.DAIIPFMBHJN(-this.NINFILJKEFA.HHGGPMABOPA.forward);
		this.PJEAKOCGBCN = this.NINFILJKEFA.JDGNBEHCGAL.InverseTransformDirection(this.JOKBJGGLOBO());
		this.BPLDJJIHPEC = Vector3.Lerp(this.FMMIKMADCJA(), this.GIIPNICPGOL(), this.DGKHAOJJNMF() * this.DGKHAOJJNMF());
		this.OOOBOOJOFAM(this.NINFILJKEFA.JDGNBEHCGAL.InverseTransformDirection(this.BPLDJJIHPEC));
	}

	// Token: 0x06002A13 RID: 10771 RVA: 0x00137151 File Offset: 0x00135351
	private void OGKELDCGGPP(Color DCCPCBLODIG)
	{
		this.<LAMIKEGBENO>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A14 RID: 10772 RVA: 0x0013715A File Offset: 0x0013535A
	private float FCIEOMJDIJP(float MBOBKEKFFJL)
	{
		return 621f + 314f * MBOBKEKFFJL;
	}

	// Token: 0x06002A15 RID: 10773 RVA: 0x0013716C File Offset: 0x0013536C
	private void IGBFPPPEOHL(Material MHNAJNGGDFJ)
	{
		switch (this.ColorSpace)
		{
		case HNMDLJHLBMH.Auto:
			if (QualitySettings.activeColorSpace == UnityEngine.ColorSpace.Linear)
			{
				MHNAJNGGDFJ.EnableKeyword("LINEAR");
				MHNAJNGGDFJ.DisableKeyword("GAMMA");
				return;
			}
			MHNAJNGGDFJ.DisableKeyword("LINEAR");
			MHNAJNGGDFJ.EnableKeyword("GAMMA");
			return;
		case HNMDLJHLBMH.Linear:
			MHNAJNGGDFJ.EnableKeyword("LINEAR");
			MHNAJNGGDFJ.DisableKeyword("GAMMA");
			return;
		case HNMDLJHLBMH.Gamma:
			MHNAJNGGDFJ.DisableKeyword("LINEAR");
			MHNAJNGGDFJ.EnableKeyword("GAMMA");
			return;
		default:
			return;
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x06002A16 RID: 10774 RVA: 0x00135937 File Offset: 0x00133B37
	// (set) Token: 0x06002A6E RID: 10862 RVA: 0x0013577E File Offset: 0x0013397E
	internal Vector3 ILBJBMJDKID { get; private set; }

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06002A17 RID: 10775 RVA: 0x001371F6 File Offset: 0x001353F6
	internal bool NPKFLOJIACA
	{
		get
		{
			return Camera.allCamerasCount == 0;
		}
	}

	// Token: 0x06002A19 RID: 10777 RVA: 0x00137208 File Offset: 0x00135408
	private void KHGKKPIFPPA()
	{
		if (this.NPKFLOJIACA)
		{
			return;
		}
		if (this.IICDLHPOOOA.CloudMaterial)
		{
			this.NJEKDKLFMOA(this.IICDLHPOOOA.CloudMaterial);
			this.IGBFPPPEOHL(this.IICDLHPOOOA.CloudMaterial);
			this.BIFLLHCEFJK(this.IICDLHPOOOA.CloudMaterial);
		}
		if (this.IICDLHPOOOA.BillboardMaterial)
		{
			this.NJEKDKLFMOA(this.IICDLHPOOOA.BillboardMaterial);
			this.IGBFPPPEOHL(this.IICDLHPOOOA.BillboardMaterial);
			this.BIFLLHCEFJK(this.IICDLHPOOOA.BillboardMaterial);
		}
		if (this.IICDLHPOOOA.ShadowMaterial)
		{
			this.NJEKDKLFMOA(this.IICDLHPOOOA.ShadowMaterial);
		}
		if (this.IICDLHPOOOA.AtmosphereMaterial)
		{
			this.AGJJJNFMFDI(this.IICDLHPOOOA.AtmosphereMaterial);
			this.IGBFPPPEOHL(this.IICDLHPOOOA.AtmosphereMaterial);
			this.BIFLLHCEFJK(this.IICDLHPOOOA.AtmosphereMaterial);
		}
		if (this.IICDLHPOOOA.SkyboxMaterial)
		{
			this.IGBFPPPEOHL(this.IICDLHPOOOA.SkyboxMaterial);
			this.BIFLLHCEFJK(this.IICDLHPOOOA.SkyboxMaterial);
		}
	}

	// Token: 0x06002A1A RID: 10778 RVA: 0x00137344 File Offset: 0x00135544
	internal Color DNGDMEPPGLF()
	{
		return this.<PNBHMFLPFAC>k__BackingField;
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06002A1B RID: 10779 RVA: 0x00137344 File Offset: 0x00135544
	// (set) Token: 0x06002A29 RID: 10793 RVA: 0x0013739F File Offset: 0x0013559F
	internal Color EDELNJGNLLG { get; private set; }

	// Token: 0x06002A1C RID: 10780 RVA: 0x001371F6 File Offset: 0x001353F6
	internal bool KDIENMKDPOO()
	{
		return Camera.allCamerasCount == 0;
	}

	// Token: 0x06002A1D RID: 10781 RVA: 0x001356CE File Offset: 0x001338CE
	private void FBNDOGPCEJD(Vector3 DCCPCBLODIG)
	{
		this.<NGBNBELKLHL>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06002A65 RID: 10853 RVA: 0x00137385 File Offset: 0x00135585
	// (set) Token: 0x06002A1E RID: 10782 RVA: 0x001356DF File Offset: 0x001338DF
	internal bool FPAKOLIPIND { get; private set; }

	// Token: 0x06002A1F RID: 10783 RVA: 0x0013734C File Offset: 0x0013554C
	internal Color CGFGPCBHLGA(Vector3 NEMFIHCKJPE, bool CPHILDMPNGK = true)
	{
		Vector3 gmdccfllcja = this.NINFILJKEFA.JDGNBEHCGAL.InverseTransformDirection(NEMFIHCKJPE);
		Color lbcgackjcjb = this.KKKAAILEJFH(gmdccfllcja, CPHILDMPNGK);
		lbcgackjcjb = this.GHIGFFFMCPN(lbcgackjcjb);
		return this.MLOOIFEIKNN(lbcgackjcjb);
	}

	// Token: 0x06002A21 RID: 10785 RVA: 0x00137385 File Offset: 0x00135585
	internal bool PNFINJHPEHJ()
	{
		return this.<HHKNONPDBIF>k__BackingField;
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06002A6F RID: 10863 RVA: 0x00138FBA File Offset: 0x001371BA
	// (set) Token: 0x06002A22 RID: 10786 RVA: 0x0013738D File Offset: 0x0013558D
	internal Vector3 BPLDJJIHPEC { get; private set; }

	// Token: 0x06002A23 RID: 10787 RVA: 0x00135776 File Offset: 0x00133976
	internal Vector3 GNGFKKJDIGA()
	{
		return this.<OLLOADIAMNL>k__BackingField;
	}

	// Token: 0x06002A24 RID: 10788 RVA: 0x00137396 File Offset: 0x00135596
	private void JGMNICECNIP(Color DCCPCBLODIG)
	{
		this.<CDCGADKBPHB>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A25 RID: 10789 RVA: 0x001357D9 File Offset: 0x001339D9
	public static List<TOD_Sky> BOEGMNKIGIA()
	{
		return TOD_Sky.LMCKEHCLCNL;
	}

	// Token: 0x06002A26 RID: 10790 RVA: 0x001340C9 File Offset: 0x001322C9
	internal Color ONHMHJEHJIC()
	{
		return this.<CDCGADKBPHB>k__BackingField;
	}

	// Token: 0x06002A28 RID: 10792 RVA: 0x00133C7C File Offset: 0x00131E7C
	internal Color NONBGAMFJIA()
	{
		return this.<JDHCFEPKDFK>k__BackingField;
	}

	// Token: 0x06002A2A RID: 10794 RVA: 0x00135995 File Offset: 0x00133B95
	private void DAIIPFMBHJN(Vector3 DCCPCBLODIG)
	{
		this.<DEECDMENKGN>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A2B RID: 10795 RVA: 0x001373A8 File Offset: 0x001355A8
	private void GOOPDIMEABB()
	{
		if (this.NPKFLOJIACA)
		{
			return;
		}
		this.JNKOAPLOHLE();
		if (!Application.isPlaying || this.KIABEBCJCCE >= this.Ambient.UpdateInterval)
		{
			this.KIABEBCJCCE = 0f;
			this.ICNADKFHODP();
		}
		else
		{
			this.KIABEBCJCCE += Time.deltaTime;
		}
		if (!Application.isPlaying || this.OOLDPNCLDKB >= this.Reflection.UpdateInterval)
		{
			this.OOLDPNCLDKB = 0f;
			this.MJDDPDKJBGG();
			return;
		}
		this.OOLDPNCLDKB += Time.deltaTime;
	}

	// Token: 0x06002A2C RID: 10796 RVA: 0x00137441 File Offset: 0x00135641
	private void JEDMMFMIENG(Color DCCPCBLODIG)
	{
		this.<HGLBDBPJFNH>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A2D RID: 10797 RVA: 0x0013744A File Offset: 0x0013564A
	protected void CMDHBHFPLBP()
	{
		this.Cycle.DateTime = this.Cycle.CPNONONLKMN();
	}

	// Token: 0x06002A2E RID: 10798 RVA: 0x00137462 File Offset: 0x00135662
	private float HLHMABGJEBK(float MBOBKEKFFJL)
	{
		return 583f + 402f * MBOBKEKFFJL;
	}

	// Token: 0x06002A2F RID: 10799 RVA: 0x00137474 File Offset: 0x00135674
	private void PLLKFCGAFLM(Material MHNAJNGGDFJ)
	{
		switch (this.ColorRange)
		{
		case GIKFKBPEMMH.Auto:
			if (this.NINFILJKEFA.MHJDBKALKDF && this.KMBOELAHKHL().MHJDBKALKDF.PBACGFLPHBA())
			{
				MHNAJNGGDFJ.EnableKeyword("first bone position is the same as second bone position.");
				MHNAJNGGDFJ.DisableKeyword("\n");
				return;
			}
			MHNAJNGGDFJ.DisableKeyword("Loot");
			MHNAJNGGDFJ.EnableKeyword("ShotgunFire");
			return;
		case GIKFKBPEMMH.HDR:
			MHNAJNGGDFJ.EnableKeyword("Crouch180");
			MHNAJNGGDFJ.DisableKeyword("signatures");
			return;
		case GIKFKBPEMMH.LDR:
			MHNAJNGGDFJ.DisableKeyword("USE_DIAG_SEARCH");
			MHNAJNGGDFJ.EnableKeyword("holesFree");
			return;
		default:
			return;
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06002A30 RID: 10800 RVA: 0x001356C6 File Offset: 0x001338C6
	// (set) Token: 0x06002A60 RID: 10848 RVA: 0x001383A9 File Offset: 0x001365A9
	internal Color FCLONNDFCOJ { get; private set; }

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06002A58 RID: 10840 RVA: 0x00138454 File Offset: 0x00136654
	// (set) Token: 0x06002A31 RID: 10801 RVA: 0x0013751A File Offset: 0x0013571A
	internal Color CPAPPAPPOFI { get; private set; }

	// Token: 0x06002A32 RID: 10802 RVA: 0x00135995 File Offset: 0x00133B95
	private void EHNHJLHBLMD(Vector3 DCCPCBLODIG)
	{
		this.<DEECDMENKGN>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A33 RID: 10803 RVA: 0x00137524 File Offset: 0x00135724
	protected void OPNPODKLOJK()
	{
		if (Application.isPlaying)
		{
			Vector2 mainTextureScale = this.IICDLHPOOOA.BillboardMaterial.mainTextureScale;
			int num = Mathf.RoundToInt(1280f / mainTextureScale.x);
			int num2 = Mathf.RoundToInt(910f / mainTextureScale.y);
			Mesh[] array = new Mesh[6 * num * num2];
			for (int i = 0; i < num2; i++)
			{
				for (int j = 1; j < num; j++)
				{
					array[i * num + j] = TOD_Resources.NFDOHCKAPDB(new Vector2((float)j, (float)i), new Vector2((float)(j + 1), (float)(i + 0)));
				}
			}
			for (int k = 0; k < num2; k += 0)
			{
				for (int l = 0; l < num; l += 0)
				{
					array[num * num2 + k * num + l] = TOD_Resources.HBCINDALCEL(new Vector2((float)(l + 0), (float)k), new Vector2((float)l, (float)(k + 1)));
				}
			}
			for (int m = 0; m < this.Clouds.Billboards; m++)
			{
				GameObject gameObject = new GameObject("_MidGrey" + m);
				gameObject.transform.parent = this.KMBOELAHKHL().Billboards.transform;
				float num3 = UnityEngine.Random.Range(1812f, 1103f);
				gameObject.transform.localScale = new Vector3(num3, num3 * 1054f, 976f);
				float f = 891f * ((float)m / (float)this.Clouds.Billboards);
				gameObject.transform.localPosition = 910f * new Vector3(Mathf.Sin(f), UnityEngine.Random.Range(807f, 354f), Mathf.Cos(f)).normalized;
				gameObject.transform.LookAt(this.NINFILJKEFA.JDGNBEHCGAL.position);
				gameObject.AddComponent<MeshFilter>().sharedMesh = array[UnityEngine.Random.Range(0, array.Length)];
				gameObject.AddComponent<MeshRenderer>().sharedMaterial = this.IICDLHPOOOA.BillboardMaterial;
			}
		}
	}

	// Token: 0x06002A34 RID: 10804 RVA: 0x00137730 File Offset: 0x00135930
	private Color KKKAAILEJFH(Vector3 GMDCCFLLCJA, bool CPHILDMPNGK = true)
	{
		GMDCCFLLCJA.y = Mathf.Clamp01(GMDCCFLLCJA.y);
		float x = this.JFDOIFEOBNN.x;
		float y = this.JFDOIFEOBNN.y;
		float w = this.JFDOIFEOBNN.w;
		float x2 = this.NGIPKOECGCI.x;
		float z = this.NGIPKOECGCI.z;
		float w2 = this.NGIPKOECGCI.w;
		float x3 = this.OAPINAGBCCE.x;
		float y2 = this.OAPINAGBCCE.y;
		float z2 = this.OAPINAGBCCE.z;
		float w3 = this.OAPINAGBCCE.w;
		float x4 = this.FCCFGNPKEGL.x;
		float y3 = this.FCCFGNPKEGL.y;
		float z3 = this.FCCFGNPKEGL.z;
		float w4 = this.FCCFGNPKEGL.w;
		Vector3 vector = new Vector3(0f, x + w2, 0f);
		float num = Mathf.Sqrt(w + y * GMDCCFLLCJA.y * GMDCCFLLCJA.y - y) - x * GMDCCFLLCJA.y;
		float num2 = Mathf.Exp(z * -w2);
		float emjflhngokf = Vector3.Dot(GMDCCFLLCJA, vector) / (x + w2);
		float num3 = num2 * this.EIMHPMOENLD(emjflhngokf);
		float num4 = num / 2f;
		float num5 = num4 * x2;
		Vector3 vector2 = GMDCCFLLCJA * num4;
		Vector3 vector3 = vector + vector2 * 0.5f;
		float num6 = 0f;
		float num7 = 0f;
		float num8 = 0f;
		for (int i = 0; i < 2; i++)
		{
			float magnitude = vector3.magnitude;
			float num9 = 1f / magnitude;
			float num10 = Mathf.Exp(z * (x - magnitude));
			float num11 = num10 * num5;
			float emjflhngokf2 = Vector3.Dot(GMDCCFLLCJA, vector3) * num9;
			float emjflhngokf3 = Vector3.Dot(this.NFNKDOGEIBL, vector3) * num9;
			float num12 = num3 + num10 * (this.EIMHPMOENLD(emjflhngokf3) - this.EIMHPMOENLD(emjflhngokf2));
			float num13 = Mathf.Exp(-num12 * (x3 + w3));
			float num14 = Mathf.Exp(-num12 * (y2 + w3));
			float num15 = Mathf.Exp(-num12 * (z2 + w3));
			num6 += num13 * num11;
			num7 += num14 * num11;
			num8 += num15 * num11;
			vector3 += vector2;
		}
		float num16 = this.FCLONNDFCOJ.r * num6 * x4;
		float num17 = this.FCLONNDFCOJ.g * num7 * y3;
		float num18 = this.FCLONNDFCOJ.b * num8 * z3;
		float num19 = this.FCLONNDFCOJ.r * num6 * w4;
		float num20 = this.FCLONNDFCOJ.g * num7 * w4;
		float num21 = this.FCLONNDFCOJ.b * num8 * w4;
		float num22 = 0f;
		float num23 = 0f;
		float num24 = 0f;
		float t = Mathf.SmoothStep(0f, 1.25f, -GMDCCFLLCJA.y);
		float num25 = Vector3.Dot(this.NFNKDOGEIBL, GMDCCFLLCJA);
		float mbobkekffjl = num25 * num25;
		float num26 = this.OMCNGIHCBJA(mbobkekffjl);
		num22 += num26 * num16;
		num23 += num26 * num17;
		num24 += num26 * num18;
		if (CPHILDMPNGK)
		{
			float num27 = this.KFGOEEIPEAN(num25, mbobkekffjl);
			num22 += num27 * num19;
			num23 += num27 * num20;
			num24 += num27 * num21;
		}
		Color color = this.NHMBHGAKJFB(GMDCCFLLCJA);
		num22 += color.r;
		num23 += color.g;
		num24 += color.b;
		if (CPHILDMPNGK)
		{
			Color color2 = this.FHLJLKPHEHK(GMDCCFLLCJA);
			num22 += color2.r;
			num23 += color2.g;
			num24 += color2.b;
		}
		num22 = Mathf.Lerp(num22, this.IEMOLCMCELO.r, this.Atmosphere.Fogginess);
		num23 = Mathf.Lerp(num23, this.IEMOLCMCELO.g, this.Atmosphere.Fogginess);
		num24 = Mathf.Lerp(num24, this.IEMOLCMCELO.b, this.Atmosphere.Fogginess);
		num22 = Mathf.Lerp(num22, this.EDELNJGNLLG.r, t);
		num23 = Mathf.Lerp(num23, this.EDELNJGNLLG.g, t);
		num24 = Mathf.Lerp(num24, this.EDELNJGNLLG.b, t);
		num22 = Mathf.Pow(num22 * this.Atmosphere.Brightness, this.Atmosphere.Contrast);
		num23 = Mathf.Pow(num23 * this.Atmosphere.Brightness, this.Atmosphere.Contrast);
		num24 = Mathf.Pow(num24 * this.Atmosphere.Brightness, this.Atmosphere.Contrast);
		return new Color(num22, num23, num24, 1f);
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06002A35 RID: 10805 RVA: 0x00137BD7 File Offset: 0x00135DD7
	internal float JFANJNEPJCH
	{
		get
		{
			return this.NINFILJKEFA.JDGNBEHCGAL.lossyScale.y;
		}
	}

	// Token: 0x06002A36 RID: 10806 RVA: 0x001340C9 File Offset: 0x001322C9
	internal Color JFGBKEHBGPL()
	{
		return this.<CDCGADKBPHB>k__BackingField;
	}

	// Token: 0x06002A37 RID: 10807 RVA: 0x00137BEE File Offset: 0x00135DEE
	internal float ELEPDHJOCNI()
	{
		return Mathf.Min(this.DIEMMEDEONP, this.KONNDFLICOM);
	}

	// Token: 0x06002A38 RID: 10808 RVA: 0x00137C01 File Offset: 0x00135E01
	internal float DGKHAOJJNMF()
	{
		return this.<HIDPCJMPHBH>k__BackingField;
	}

	// Token: 0x06002A39 RID: 10809 RVA: 0x00137C0C File Offset: 0x00135E0C
	private float EIMHPMOENLD(float EMJFLHNGOKF)
	{
		float num = 1f - EMJFLHNGOKF;
		return 0.25f * Mathf.Exp(-0.00287f + num * (0.459f + num * (3.83f + num * (-6.8f + num * 5.25f))));
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x06002A77 RID: 10871 RVA: 0x001396C7 File Offset: 0x001378C7
	// (set) Token: 0x06002A3A RID: 10810 RVA: 0x001356CE File Offset: 0x001338CE
	internal Vector3 NFNKDOGEIBL { get; private set; }

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06002A3C RID: 10812 RVA: 0x00137C5A File Offset: 0x00135E5A
	// (set) Token: 0x06002A61 RID: 10849 RVA: 0x0013589C File Offset: 0x00133A9C
	internal Color IEMOLCMCELO { get; private set; }

	// Token: 0x06002A3D RID: 10813 RVA: 0x00137C64 File Offset: 0x00135E64
	internal void LKIALCHFLGM()
	{
		switch (this.Fog.Mode)
		{
		case LKELCNKDLEC.None:
			break;
		case LKELCNKDLEC.Color:
			RenderSettings.fogColor = this.BOIOMMIDIHF(true);
			return;
		case LKELCNKDLEC.Directional:
			RenderSettings.fogColor = this.BOIOMMIDIHF(true);
			break;
		default:
			return;
		}
	}

	// Token: 0x06002A3F RID: 10815 RVA: 0x00137CA9 File Offset: 0x00135EA9
	protected void OnDisable()
	{
		TOD_Sky.LMCKEHCLCNL.Remove(this);
		if (this.EADKGGFJEDB)
		{
			UnityEngine.Object.Destroy(this.EADKGGFJEDB.gameObject);
		}
	}

	// Token: 0x06002A40 RID: 10816 RVA: 0x00137CD4 File Offset: 0x00135ED4
	internal Vector3 PAAGAIACHGE(float PNKOPJDIOMN, float MEKCKKJKEKF)
	{
		float num = Mathf.Sin(PNKOPJDIOMN);
		float y = Mathf.Cos(PNKOPJDIOMN);
		float num2 = Mathf.Sin(MEKCKKJKEKF);
		float num3 = Mathf.Cos(MEKCKKJKEKF);
		Vector3 result;
		result.z = num * num3;
		result.y = y;
		result.x = num * num2;
		return result;
	}

	// Token: 0x06002A41 RID: 10817 RVA: 0x00137D1C File Offset: 0x00135F1C
	internal Vector3 ILEFHIHELOI(float AEIAFIIMHEL, float PNKOPJDIOMN, float MEKCKKJKEKF)
	{
		float num = Mathf.Sin(PNKOPJDIOMN);
		float num2 = Mathf.Cos(PNKOPJDIOMN);
		float num3 = Mathf.Sin(MEKCKKJKEKF);
		float num4 = Mathf.Cos(MEKCKKJKEKF);
		Vector3 result;
		result.z = AEIAFIIMHEL * num * num4;
		result.y = AEIAFIIMHEL * num2;
		result.x = AEIAFIIMHEL * num * num3;
		return result;
	}

	// Token: 0x06002A42 RID: 10818 RVA: 0x00137D6C File Offset: 0x00135F6C
	private void DLAILOIOIAO()
	{
		if (this.NPKFLOJIACA)
		{
			return;
		}
		Mesh mesh = null;
		Mesh mesh2 = null;
		Mesh mesh3 = null;
		Mesh mesh4 = null;
		Mesh mesh5 = null;
		Mesh mesh6 = null;
		switch (this.MeshQuality)
		{
		case PDECLIHHEBE.Low:
			mesh = this.IICDLHPOOOA.IcosphereLow;
			mesh2 = this.IICDLHPOOOA.IcosphereLow;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereLow;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereLow;
			break;
		case PDECLIHHEBE.Medium:
			mesh = this.IICDLHPOOOA.IcosphereMedium;
			mesh2 = this.IICDLHPOOOA.IcosphereMedium;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereMedium;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereMedium;
			break;
		case PDECLIHHEBE.High:
			mesh = this.IICDLHPOOOA.IcosphereHigh;
			mesh2 = this.IICDLHPOOOA.IcosphereHigh;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereHigh;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereHigh;
			break;
		}
		if (this.NINFILJKEFA.MJFKDCPMDOF && this.NINFILJKEFA.CHKCGPGIOPB != this.IICDLHPOOOA.SpaceMaterial)
		{
			this.NINFILJKEFA.CHKCGPGIOPB = (this.NINFILJKEFA.MJFKDCPMDOF.sharedMaterial = this.IICDLHPOOOA.SpaceMaterial);
		}
		if (this.NINFILJKEFA.JFBEDPHIDII && this.NINFILJKEFA.FJKDDLPBBHD != this.IICDLHPOOOA.AtmosphereMaterial)
		{
			this.NINFILJKEFA.FJKDDLPBBHD = (this.NINFILJKEFA.JFBEDPHIDII.sharedMaterial = this.IICDLHPOOOA.AtmosphereMaterial);
		}
		if (this.NINFILJKEFA.NPGMCIEICBJ && this.NINFILJKEFA.FMBBCDILBLE != this.IICDLHPOOOA.ClearMaterial)
		{
			this.NINFILJKEFA.FMBBCDILBLE = (this.NINFILJKEFA.NPGMCIEICBJ.sharedMaterial = this.IICDLHPOOOA.ClearMaterial);
		}
		if (this.NINFILJKEFA.JHKOHMHKBOK && this.NINFILJKEFA.ENLCHIIOIBB != this.IICDLHPOOOA.CloudMaterial)
		{
			this.NINFILJKEFA.ENLCHIIOIBB = (this.NINFILJKEFA.JHKOHMHKBOK.sharedMaterial = this.IICDLHPOOOA.CloudMaterial);
		}
		if (this.NINFILJKEFA.AIDEHKOPKHN && this.NINFILJKEFA.HMFIBKJKOKK != this.IICDLHPOOOA.ShadowMaterial)
		{
			this.NINFILJKEFA.HMFIBKJKOKK = (this.NINFILJKEFA.AIDEHKOPKHN.material = this.IICDLHPOOOA.ShadowMaterial);
		}
		if (this.NINFILJKEFA.HCCAOCECMEP && this.NINFILJKEFA.FKNIPFONANF != this.IICDLHPOOOA.SunMaterial)
		{
			this.NINFILJKEFA.FKNIPFONANF = (this.NINFILJKEFA.HCCAOCECMEP.sharedMaterial = this.IICDLHPOOOA.SunMaterial);
		}
		if (this.NINFILJKEFA.AMLLDIODOLD && this.NINFILJKEFA.OHAADBJGPHL != this.IICDLHPOOOA.MoonMaterial)
		{
			this.NINFILJKEFA.OHAADBJGPHL = (this.NINFILJKEFA.AMLLDIODOLD.sharedMaterial = this.IICDLHPOOOA.MoonMaterial);
		}
		if (this.NINFILJKEFA.DJFNJPHBAFO && this.NINFILJKEFA.DJFNJPHBAFO.sharedMesh != mesh)
		{
			this.NINFILJKEFA.DJFNJPHBAFO.mesh = mesh;
		}
		if (this.NINFILJKEFA.OIDGFIJEHKM && this.NINFILJKEFA.OIDGFIJEHKM.sharedMesh != mesh2)
		{
			this.NINFILJKEFA.OIDGFIJEHKM.mesh = mesh2;
		}
		if (this.NINFILJKEFA.MBNJEJNIKDI && this.NINFILJKEFA.MBNJEJNIKDI.sharedMesh != mesh3)
		{
			this.NINFILJKEFA.MBNJEJNIKDI.mesh = mesh3;
		}
		if (this.NINFILJKEFA.DDJNNFJINJE && this.NINFILJKEFA.DDJNNFJINJE.sharedMesh != mesh4)
		{
			this.NINFILJKEFA.DDJNNFJINJE.mesh = mesh4;
		}
		if (this.NINFILJKEFA.HNCNKCJKFJO && this.NINFILJKEFA.HNCNKCJKFJO.sharedMesh != mesh5)
		{
			this.NINFILJKEFA.HNCNKCJKFJO.mesh = mesh5;
		}
		if (this.NINFILJKEFA.LPNKELBJFHK && this.NINFILJKEFA.LPNKELBJFHK.sharedMesh != mesh6)
		{
			this.NINFILJKEFA.LPNKELBJFHK.mesh = mesh6;
		}
	}

	// Token: 0x06002A43 RID: 10819 RVA: 0x00138271 File Offset: 0x00136471
	internal Color KMAIKPCCGHC()
	{
		return this.<FFABEELHHEE>k__BackingField;
	}

	// Token: 0x06002A44 RID: 10820 RVA: 0x00137396 File Offset: 0x00135596
	private void MHLNLNMMALF(Color DCCPCBLODIG)
	{
		this.<CDCGADKBPHB>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A46 RID: 10822 RVA: 0x0013827C File Offset: 0x0013647C
	internal Vector3 BDNCCEIDKLB(float AEIAFIIMHEL, float PNKOPJDIOMN, float MEKCKKJKEKF)
	{
		float num = Mathf.Sin(PNKOPJDIOMN);
		float num2 = Mathf.Cos(PNKOPJDIOMN);
		float num3 = Mathf.Sin(MEKCKKJKEKF);
		float num4 = Mathf.Cos(MEKCKKJKEKF);
		Vector3 result;
		result.z = AEIAFIIMHEL * num * num4;
		result.y = AEIAFIIMHEL * num2;
		result.x = AEIAFIIMHEL * num * num3;
		return result;
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06002A47 RID: 10823 RVA: 0x001382CA File Offset: 0x001364CA
	public static TOD_Sky ELOBJGIDGCP
	{
		get
		{
			if (TOD_Sky.LMCKEHCLCNL.Count != 0)
			{
				return TOD_Sky.LMCKEHCLCNL[TOD_Sky.LMCKEHCLCNL.Count - 1];
			}
			return null;
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06002A90 RID: 10896 RVA: 0x001383A1 File Offset: 0x001365A1
	// (set) Token: 0x06002A48 RID: 10824 RVA: 0x001382F0 File Offset: 0x001364F0
	internal Color PACEPBHIGHD { get; private set; }

	// Token: 0x06002A49 RID: 10825 RVA: 0x001382F9 File Offset: 0x001364F9
	internal Color PNPPKCMNDGC()
	{
		return this.<JOPMBOBGBEC>k__BackingField;
	}

	// Token: 0x06002A4A RID: 10826 RVA: 0x00138304 File Offset: 0x00136504
	internal Color CDGLIGGEEOO()
	{
		Vector3 vector = this.FLFIIDICEHN;
		vector.y = 575f;
		Color color = this.CGFGPCBHLGA(vector.normalized, true);
		return new Color(color.r, color.g, color.b, 193f);
	}

	// Token: 0x06002A4B RID: 10827 RVA: 0x00138350 File Offset: 0x00136550
	internal Color EDEOFJIHELL()
	{
		Vector3 vector = this.FLFIIDICEHN;
		vector.y = Mathf.Abs(vector.y);
		Color color = this.CGFGPCBHLGA(vector.normalized, false);
		return new Color(color.r, color.g, color.b, 1f);
	}

	// Token: 0x06002A4C RID: 10828 RVA: 0x00137344 File Offset: 0x00135544
	internal Color HBABCBJBNAA()
	{
		return this.<PNBHMFLPFAC>k__BackingField;
	}

	// Token: 0x06002A4D RID: 10829 RVA: 0x001383A1 File Offset: 0x001365A1
	internal Color DCNEHCDOPDD()
	{
		return this.<NLGJBMAOKHJ>k__BackingField;
	}

	// Token: 0x06002A4F RID: 10831 RVA: 0x001383A9 File Offset: 0x001365A9
	private void ONIDEIKNLAE(Color DCCPCBLODIG)
	{
		this.<EPIJANDDNEG>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A50 RID: 10832 RVA: 0x0013564E File Offset: 0x0013384E
	internal Vector3 JOKBJGGLOBO()
	{
		return this.<DEECDMENKGN>k__BackingField;
	}

	// Token: 0x06002A51 RID: 10833 RVA: 0x001383B4 File Offset: 0x001365B4
	internal Color FONAMNIEJKP()
	{
		Vector3 vector = this.GIIPNICPGOL();
		vector.y = Mathf.Abs(vector.y);
		Color color = this.CGFGPCBHLGA(vector.normalized, true);
		return new Color(color.r, color.g, color.b, 1548f);
	}

	// Token: 0x06002A54 RID: 10836 RVA: 0x0013844B File Offset: 0x0013664B
	private void APLOFCBBPJB(ReflectionProbe DCCPCBLODIG)
	{
		this.<GNMKGBIACLP>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06002A55 RID: 10837 RVA: 0x00138271 File Offset: 0x00136471
	// (set) Token: 0x06002A83 RID: 10883 RVA: 0x0013576D File Offset: 0x0013396D
	internal Color BBIJBFAOEND { get; private set; }

	// Token: 0x06002A56 RID: 10838 RVA: 0x0013577E File Offset: 0x0013397E
	private void HLLDBGOAELP(Vector3 DCCPCBLODIG)
	{
		this.<LPLMFHFIMNN>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A57 RID: 10839 RVA: 0x00135645 File Offset: 0x00133845
	private void PGCFJMJDIJK(float DCCPCBLODIG)
	{
		this.<LENMEHHBFCA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A59 RID: 10841 RVA: 0x0013845C File Offset: 0x0013665C
	internal Vector3 BPCEMFMFGNI(float AEIAFIIMHEL, float PNKOPJDIOMN, float MEKCKKJKEKF)
	{
		float num = Mathf.Sin(PNKOPJDIOMN);
		float num2 = Mathf.Cos(PNKOPJDIOMN);
		float num3 = Mathf.Sin(MEKCKKJKEKF);
		float num4 = Mathf.Cos(MEKCKKJKEKF);
		Vector3 result;
		result.z = AEIAFIIMHEL * num * num4;
		result.y = AEIAFIIMHEL * num2;
		result.x = AEIAFIIMHEL * num * num3;
		return result;
	}

	// Token: 0x06002A5A RID: 10842 RVA: 0x001383A9 File Offset: 0x001365A9
	private void LNIHBGNOEBP(Color DCCPCBLODIG)
	{
		this.<EPIJANDDNEG>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A5B RID: 10843 RVA: 0x001358AD File Offset: 0x00133AAD
	private Color NHMBHGAKJFB(Vector3 GMDCCFLLCJA)
	{
		return Color.Lerp(this.LOCLPOPPNDM, Color.black, GMDCCFLLCJA.y);
	}

	// Token: 0x06002A5D RID: 10845 RVA: 0x001384B6 File Offset: 0x001366B6
	private float KFGOEEIPEAN(float GNKNDJAABEM, float MBOBKEKFFJL)
	{
		return this.COKJFFNOPFG.x * (1f + MBOBKEKFFJL) / Mathf.Pow(this.COKJFFNOPFG.y + this.COKJFFNOPFG.z * GNKNDJAABEM, 1.5f);
	}

	// Token: 0x06002A5E RID: 10846 RVA: 0x001384F0 File Offset: 0x001366F0
	internal void MLOOMBAHCOA()
	{
		GLOGLJFNIAL mode = this.Reflection.Mode;
		if (mode == GLOGLJFNIAL.None)
		{
			float reflectionIntensity = Mathf.Lerp(this.Night.ReflectionMultiplier, this.Day.ReflectionMultiplier, this.DGKHAOJJNMF());
			RenderSettings.defaultReflectionMode = DefaultReflectionMode.Custom;
			RenderSettings.skybox = this.IICDLHPOOOA.SkyboxMaterial;
			RenderSettings.reflectionIntensity = reflectionIntensity;
			if (Application.isPlaying)
			{
				this.GLADELKBIKL(null);
			}
		}
	}

	// Token: 0x06002A5F RID: 10847 RVA: 0x00137441 File Offset: 0x00135641
	private void EKHBJMIOEJH(Color DCCPCBLODIG)
	{
		this.<HGLBDBPJFNH>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A63 RID: 10851 RVA: 0x00138560 File Offset: 0x00136760
	internal Color LMEBPPAMPGP()
	{
		Vector3 vector = this.FLFIIDICEHN;
		vector.y = 0f;
		Color color = this.CGFGPCBHLGA(vector.normalized, false);
		return new Color(color.r, color.g, color.b, 1f);
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06002A64 RID: 10852 RVA: 0x001385AB File Offset: 0x001367AB
	internal Color HCFOAHOONPJ
	{
		get
		{
			return this.NINFILJKEFA.JAFNHAHJLOH.color;
		}
	}

	// Token: 0x06002A66 RID: 10854 RVA: 0x001385BD File Offset: 0x001367BD
	internal float DLLBKEDEKHB()
	{
		return this.KMBOELAHKHL().JDGNBEHCGAL.lossyScale.y * 7f;
	}

	// Token: 0x06002A67 RID: 10855 RVA: 0x001385DC File Offset: 0x001367DC
	private void KONLKIGDELA()
	{
		if (this.KDIENMKDPOO())
		{
			return;
		}
		Mesh mesh = null;
		Mesh mesh2 = null;
		Mesh mesh3 = null;
		Mesh mesh4 = null;
		Mesh mesh5 = null;
		Mesh mesh6 = null;
		switch (this.MeshQuality)
		{
		case PDECLIHHEBE.Low:
			mesh = this.IICDLHPOOOA.IcosphereLow;
			mesh2 = this.IICDLHPOOOA.IcosphereLow;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereLow;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereLow;
			break;
		case PDECLIHHEBE.Medium:
			mesh = this.IICDLHPOOOA.IcosphereMedium;
			mesh2 = this.IICDLHPOOOA.IcosphereMedium;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereMedium;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereMedium;
			break;
		case PDECLIHHEBE.High:
			mesh = this.IICDLHPOOOA.IcosphereHigh;
			mesh2 = this.IICDLHPOOOA.IcosphereHigh;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereHigh;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereHigh;
			break;
		}
		if (this.KMBOELAHKHL().MJFKDCPMDOF && this.KMBOELAHKHL().CHKCGPGIOPB != this.IICDLHPOOOA.SpaceMaterial)
		{
			this.NINFILJKEFA.CHKCGPGIOPB = (this.NINFILJKEFA.MJFKDCPMDOF.sharedMaterial = this.IICDLHPOOOA.SpaceMaterial);
		}
		if (this.KMBOELAHKHL().JFBEDPHIDII && this.KMBOELAHKHL().FJKDDLPBBHD != this.IICDLHPOOOA.AtmosphereMaterial)
		{
			this.NINFILJKEFA.FJKDDLPBBHD = (this.NINFILJKEFA.JFBEDPHIDII.sharedMaterial = this.IICDLHPOOOA.AtmosphereMaterial);
		}
		if (this.NINFILJKEFA.NPGMCIEICBJ && this.NINFILJKEFA.FMBBCDILBLE != this.IICDLHPOOOA.ClearMaterial)
		{
			this.NINFILJKEFA.FMBBCDILBLE = (this.KMBOELAHKHL().NPGMCIEICBJ.sharedMaterial = this.IICDLHPOOOA.ClearMaterial);
		}
		if (this.NINFILJKEFA.JHKOHMHKBOK && this.KMBOELAHKHL().ENLCHIIOIBB != this.IICDLHPOOOA.CloudMaterial)
		{
			this.KMBOELAHKHL().ENLCHIIOIBB = (this.NINFILJKEFA.JHKOHMHKBOK.sharedMaterial = this.IICDLHPOOOA.CloudMaterial);
		}
		if (this.NINFILJKEFA.AIDEHKOPKHN && this.NINFILJKEFA.HMFIBKJKOKK != this.IICDLHPOOOA.ShadowMaterial)
		{
			this.KMBOELAHKHL().HMFIBKJKOKK = (this.NINFILJKEFA.AIDEHKOPKHN.material = this.IICDLHPOOOA.ShadowMaterial);
		}
		if (this.NINFILJKEFA.HCCAOCECMEP && this.NINFILJKEFA.FKNIPFONANF != this.IICDLHPOOOA.SunMaterial)
		{
			this.KMBOELAHKHL().FKNIPFONANF = (this.KMBOELAHKHL().HCCAOCECMEP.sharedMaterial = this.IICDLHPOOOA.SunMaterial);
		}
		if (this.KMBOELAHKHL().AMLLDIODOLD && this.NINFILJKEFA.OHAADBJGPHL != this.IICDLHPOOOA.MoonMaterial)
		{
			this.KMBOELAHKHL().OHAADBJGPHL = (this.NINFILJKEFA.AMLLDIODOLD.sharedMaterial = this.IICDLHPOOOA.MoonMaterial);
		}
		if (this.NINFILJKEFA.DJFNJPHBAFO && this.KMBOELAHKHL().DJFNJPHBAFO.sharedMesh != mesh)
		{
			this.NINFILJKEFA.DJFNJPHBAFO.mesh = mesh;
		}
		if (this.NINFILJKEFA.OIDGFIJEHKM && this.NINFILJKEFA.OIDGFIJEHKM.sharedMesh != mesh2)
		{
			this.KMBOELAHKHL().OIDGFIJEHKM.mesh = mesh2;
		}
		if (this.KMBOELAHKHL().MBNJEJNIKDI && this.NINFILJKEFA.MBNJEJNIKDI.sharedMesh != mesh3)
		{
			this.KMBOELAHKHL().MBNJEJNIKDI.mesh = mesh3;
		}
		if (this.NINFILJKEFA.DDJNNFJINJE && this.NINFILJKEFA.DDJNNFJINJE.sharedMesh != mesh4)
		{
			this.KMBOELAHKHL().DDJNNFJINJE.mesh = mesh4;
		}
		if (this.KMBOELAHKHL().HNCNKCJKFJO && this.KMBOELAHKHL().HNCNKCJKFJO.sharedMesh != mesh5)
		{
			this.NINFILJKEFA.HNCNKCJKFJO.mesh = mesh5;
		}
		if (this.KMBOELAHKHL().LPNKELBJFHK && this.KMBOELAHKHL().LPNKELBJFHK.sharedMesh != mesh6)
		{
			this.NINFILJKEFA.LPNKELBJFHK.mesh = mesh6;
		}
	}

	// Token: 0x06002A68 RID: 10856 RVA: 0x0013563D File Offset: 0x0013383D
	internal Vector3 GIIPNICPGOL()
	{
		return this.<LEDKDCIFBCO>k__BackingField;
	}

	// Token: 0x06002A69 RID: 10857 RVA: 0x00138AE4 File Offset: 0x00136CE4
	internal SphericalHarmonicsL2 OKBHKJLBCEH()
	{
		SphericalHarmonicsL2 result = default(SphericalHarmonicsL2);
		bool cphildmpngk = false;
		Color linear = this.EDELNJGNLLG.linear;
		Vector3 vector = new Vector3(1252f, 1260f, 1670f);
		Vector3 up = Vector3.up;
		Color linear2 = this.CGFGPCBHLGA(up, cphildmpngk).linear;
		result.AddDirectionalLight(up, linear2, 45f);
		Vector3 vector2 = new Vector3(-vector.x, vector.y, -vector.z);
		Color linear3 = this.CGFGPCBHLGA(vector2, cphildmpngk).linear;
		result.AddDirectionalLight(vector2, linear3, 1254f);
		Vector3 vector3 = new Vector3(vector.x, vector.y, -vector.z);
		Color linear4 = this.CGFGPCBHLGA(vector3, cphildmpngk).linear;
		result.AddDirectionalLight(vector3, linear4, 939f);
		Vector3 vector4 = new Vector3(-vector.x, vector.y, vector.z);
		Color linear5 = this.CGFGPCBHLGA(vector4, cphildmpngk).linear;
		result.AddDirectionalLight(vector4, linear5, 122f);
		Vector3 vector5 = new Vector3(vector.x, vector.y, vector.z);
		Color linear6 = this.CGFGPCBHLGA(vector5, cphildmpngk).linear;
		result.AddDirectionalLight(vector5, linear6, 1340f);
		Vector3 left = Vector3.left;
		Color linear7 = this.CGFGPCBHLGA(left, cphildmpngk).linear;
		result.AddDirectionalLight(left, linear7, 472f);
		Vector3 right = Vector3.right;
		Color linear8 = this.CGFGPCBHLGA(right, cphildmpngk).linear;
		result.AddDirectionalLight(right, linear8, 344f);
		Vector3 back = Vector3.back;
		Color linear9 = this.CGFGPCBHLGA(back, cphildmpngk).linear;
		result.AddDirectionalLight(back, linear9, 1063f);
		Vector3 forward = Vector3.forward;
		Color linear10 = this.CGFGPCBHLGA(forward, cphildmpngk).linear;
		result.AddDirectionalLight(forward, linear10, 16f);
		Vector3 direction = new Vector3(-vector.x, -vector.y, -vector.z);
		result.AddDirectionalLight(direction, linear, 377f);
		Vector3 direction2 = new Vector3(vector.x, -vector.y, -vector.z);
		result.AddDirectionalLight(direction2, linear, 1258f);
		Vector3 direction3 = new Vector3(-vector.x, -vector.y, vector.z);
		result.AddDirectionalLight(direction3, linear, 945f);
		Vector3 direction4 = new Vector3(vector.x, -vector.y, vector.z);
		result.AddDirectionalLight(direction4, linear, 1359f);
		Vector3 down = Vector3.down;
		result.AddDirectionalLight(down, linear, 1571f);
		return result;
	}

	// Token: 0x06002A6A RID: 10858 RVA: 0x00138DB0 File Offset: 0x00136FB0
	protected void Start()
	{
		if (Application.isPlaying)
		{
			Vector2 mainTextureScale = this.IICDLHPOOOA.BillboardMaterial.mainTextureScale;
			int num = Mathf.RoundToInt(1f / mainTextureScale.x);
			int num2 = Mathf.RoundToInt(1f / mainTextureScale.y);
			Mesh[] array = new Mesh[2 * num * num2];
			for (int i = 0; i < num2; i++)
			{
				for (int j = 0; j < num; j++)
				{
					array[i * num + j] = TOD_Resources.CreateQuad(new Vector2((float)j, (float)i), new Vector2((float)(j + 1), (float)(i + 1)));
				}
			}
			for (int k = 0; k < num2; k++)
			{
				for (int l = 0; l < num; l++)
				{
					array[num * num2 + k * num + l] = TOD_Resources.CreateQuad(new Vector2((float)(l + 1), (float)k), new Vector2((float)l, (float)(k + 1)));
				}
			}
			for (int m = 0; m < this.Clouds.Billboards; m++)
			{
				GameObject gameObject = new GameObject("Cloud " + m);
				gameObject.transform.parent = this.NINFILJKEFA.Billboards.transform;
				float num3 = UnityEngine.Random.Range(0.3f, 0.4f);
				gameObject.transform.localScale = new Vector3(num3, num3 * 0.5f, 1f);
				float f = 6.2831855f * ((float)m / (float)this.Clouds.Billboards);
				gameObject.transform.localPosition = 0.95f * new Vector3(Mathf.Sin(f), UnityEngine.Random.Range(0.1f, 0.2f), Mathf.Cos(f)).normalized;
				gameObject.transform.LookAt(this.NINFILJKEFA.JDGNBEHCGAL.position);
				gameObject.AddComponent<MeshFilter>().sharedMesh = array[UnityEngine.Random.Range(0, array.Length)];
				gameObject.AddComponent<MeshRenderer>().sharedMaterial = this.IICDLHPOOOA.BillboardMaterial;
			}
		}
	}

	// Token: 0x06002A6B RID: 10859 RVA: 0x00138FBA File Offset: 0x001371BA
	internal Vector3 PKMHDHPKIHN()
	{
		return this.<JKFCBKKHEPJ>k__BackingField;
	}

	// Token: 0x06002A70 RID: 10864 RVA: 0x00138FC4 File Offset: 0x001371C4
	internal void ICNADKFHODP()
	{
		float ambientIntensity = Mathf.Lerp(this.Night.AmbientMultiplier, this.Day.AmbientMultiplier, this.CLCJBENKCMB);
		switch (this.Ambient.Mode)
		{
		case PCFPKFJGNCG.Color:
			RenderSettings.ambientMode = AmbientMode.Flat;
			RenderSettings.ambientLight = this.EDELNJGNLLG;
			RenderSettings.ambientIntensity = ambientIntensity;
			return;
		case PCFPKFJGNCG.Gradient:
		{
			Color ambientGroundColor = this.EDELNJGNLLG;
			Color ambientEquatorColor = this.LMEBPPAMPGP();
			Color ambientSkyColor = this.EDEOFJIHELL();
			RenderSettings.ambientMode = AmbientMode.Trilight;
			RenderSettings.ambientSkyColor = ambientSkyColor;
			RenderSettings.ambientEquatorColor = ambientEquatorColor;
			RenderSettings.ambientGroundColor = ambientGroundColor;
			RenderSettings.ambientIntensity = ambientIntensity;
			return;
		}
		case PCFPKFJGNCG.Spherical:
			RenderSettings.ambientMode = AmbientMode.Skybox;
			RenderSettings.skybox = this.IICDLHPOOOA.SkyboxMaterial;
			RenderSettings.ambientLight = this.EDELNJGNLLG;
			RenderSettings.ambientIntensity = ambientIntensity;
			RenderSettings.ambientProbe = this.GPKFAHGGOCA();
			return;
		default:
			return;
		}
	}

	// Token: 0x06002A71 RID: 10865 RVA: 0x0013908C File Offset: 0x0013728C
	private Color GHIGFFFMCPN(Color LBCGACKJCJB)
	{
		return new Color(1f - Mathf.Pow(2f, -this.Atmosphere.Brightness * LBCGACKJCJB.r), 1f - Mathf.Pow(2f, -this.Atmosphere.Brightness * LBCGACKJCJB.g), 1f - Mathf.Pow(2f, -this.Atmosphere.Brightness * LBCGACKJCJB.b), LBCGACKJCJB.a);
	}

	// Token: 0x06002A72 RID: 10866 RVA: 0x00139110 File Offset: 0x00137310
	private void GCIIIBIACHH()
	{
		if (this.NPKFLOJIACA)
		{
			return;
		}
		Mesh mesh = null;
		Mesh mesh2 = null;
		Mesh mesh3 = null;
		Mesh mesh4 = null;
		Mesh mesh5 = null;
		Mesh mesh6 = null;
		switch (this.MeshQuality)
		{
		case PDECLIHHEBE.Low:
			mesh = this.IICDLHPOOOA.IcosphereLow;
			mesh2 = this.IICDLHPOOOA.IcosphereLow;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereLow;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereLow;
			break;
		case PDECLIHHEBE.Medium:
			mesh = this.IICDLHPOOOA.IcosphereMedium;
			mesh2 = this.IICDLHPOOOA.IcosphereMedium;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereMedium;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereMedium;
			break;
		case PDECLIHHEBE.High:
			mesh = this.IICDLHPOOOA.IcosphereHigh;
			mesh2 = this.IICDLHPOOOA.IcosphereHigh;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereHigh;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereHigh;
			break;
		}
		if (this.NINFILJKEFA.MJFKDCPMDOF && this.KMBOELAHKHL().CHKCGPGIOPB != this.IICDLHPOOOA.SpaceMaterial)
		{
			this.NINFILJKEFA.CHKCGPGIOPB = (this.NINFILJKEFA.MJFKDCPMDOF.sharedMaterial = this.IICDLHPOOOA.SpaceMaterial);
		}
		if (this.NINFILJKEFA.JFBEDPHIDII && this.NINFILJKEFA.FJKDDLPBBHD != this.IICDLHPOOOA.AtmosphereMaterial)
		{
			this.KMBOELAHKHL().FJKDDLPBBHD = (this.KMBOELAHKHL().JFBEDPHIDII.sharedMaterial = this.IICDLHPOOOA.AtmosphereMaterial);
		}
		if (this.KMBOELAHKHL().NPGMCIEICBJ && this.KMBOELAHKHL().FMBBCDILBLE != this.IICDLHPOOOA.ClearMaterial)
		{
			this.KMBOELAHKHL().FMBBCDILBLE = (this.KMBOELAHKHL().NPGMCIEICBJ.sharedMaterial = this.IICDLHPOOOA.ClearMaterial);
		}
		if (this.NINFILJKEFA.JHKOHMHKBOK && this.KMBOELAHKHL().ENLCHIIOIBB != this.IICDLHPOOOA.CloudMaterial)
		{
			this.NINFILJKEFA.ENLCHIIOIBB = (this.NINFILJKEFA.JHKOHMHKBOK.sharedMaterial = this.IICDLHPOOOA.CloudMaterial);
		}
		if (this.NINFILJKEFA.AIDEHKOPKHN && this.KMBOELAHKHL().HMFIBKJKOKK != this.IICDLHPOOOA.ShadowMaterial)
		{
			this.KMBOELAHKHL().HMFIBKJKOKK = (this.NINFILJKEFA.AIDEHKOPKHN.material = this.IICDLHPOOOA.ShadowMaterial);
		}
		if (this.KMBOELAHKHL().HCCAOCECMEP && this.KMBOELAHKHL().FKNIPFONANF != this.IICDLHPOOOA.SunMaterial)
		{
			this.NINFILJKEFA.FKNIPFONANF = (this.KMBOELAHKHL().HCCAOCECMEP.sharedMaterial = this.IICDLHPOOOA.SunMaterial);
		}
		if (this.NINFILJKEFA.AMLLDIODOLD && this.NINFILJKEFA.OHAADBJGPHL != this.IICDLHPOOOA.MoonMaterial)
		{
			this.NINFILJKEFA.OHAADBJGPHL = (this.KMBOELAHKHL().AMLLDIODOLD.sharedMaterial = this.IICDLHPOOOA.MoonMaterial);
		}
		if (this.KMBOELAHKHL().DJFNJPHBAFO && this.KMBOELAHKHL().DJFNJPHBAFO.sharedMesh != mesh)
		{
			this.NINFILJKEFA.DJFNJPHBAFO.mesh = mesh;
		}
		if (this.NINFILJKEFA.OIDGFIJEHKM && this.NINFILJKEFA.OIDGFIJEHKM.sharedMesh != mesh2)
		{
			this.NINFILJKEFA.OIDGFIJEHKM.mesh = mesh2;
		}
		if (this.KMBOELAHKHL().MBNJEJNIKDI && this.NINFILJKEFA.MBNJEJNIKDI.sharedMesh != mesh3)
		{
			this.NINFILJKEFA.MBNJEJNIKDI.mesh = mesh3;
		}
		if (this.NINFILJKEFA.DDJNNFJINJE && this.NINFILJKEFA.DDJNNFJINJE.sharedMesh != mesh4)
		{
			this.KMBOELAHKHL().DDJNNFJINJE.mesh = mesh4;
		}
		if (this.NINFILJKEFA.HNCNKCJKFJO && this.NINFILJKEFA.HNCNKCJKFJO.sharedMesh != mesh5)
		{
			this.KMBOELAHKHL().HNCNKCJKFJO.mesh = mesh5;
		}
		if (this.NINFILJKEFA.LPNKELBJFHK && this.NINFILJKEFA.LPNKELBJFHK.sharedMesh != mesh6)
		{
			this.KMBOELAHKHL().LPNKELBJFHK.mesh = mesh6;
		}
	}

	// Token: 0x06002A73 RID: 10867 RVA: 0x00139618 File Offset: 0x00137818
	protected void OnEnable()
	{
		this.NINFILJKEFA = base.GetComponent<TOD_Components>();
		this.NINFILJKEFA.Initialize();
		this.IICDLHPOOOA = base.GetComponent<TOD_Resources>();
		this.IICDLHPOOOA.Initialize();
		this.LateUpdate();
		TOD_Sky.LMCKEHCLCNL.Add(this);
		this.FPAKOLIPIND = true;
	}

	// Token: 0x06002A74 RID: 10868 RVA: 0x001358AD File Offset: 0x00133AAD
	private Color MAELAFNGCHK(Vector3 GMDCCFLLCJA)
	{
		return Color.Lerp(this.LOCLPOPPNDM, Color.black, GMDCCFLLCJA.y);
	}

	// Token: 0x06002A75 RID: 10869 RVA: 0x0013966B File Offset: 0x0013786B
	private float OMCNGIHCBJA(float MBOBKEKFFJL)
	{
		return 0.75f + 0.75f * MBOBKEKFFJL;
	}

	// Token: 0x06002A76 RID: 10870 RVA: 0x0013967C File Offset: 0x0013787C
	internal Color EMNPFKNBJKN()
	{
		Vector3 vector = this.GIIPNICPGOL();
		vector.y = 1684f;
		Color color = this.CGFGPCBHLGA(vector.normalized, false);
		return new Color(color.r, color.g, color.b, 536f);
	}

	// Token: 0x06002A78 RID: 10872 RVA: 0x001396D0 File Offset: 0x001378D0
	private float DMANKCDHMBL(float EMJFLHNGOKF)
	{
		float num = 1084f - EMJFLHNGOKF;
		return 1192f * Mathf.Exp(63f + num * (1486f + num * (71f + num * (1884f + num * 1344f))));
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x06002A7E RID: 10878 RVA: 0x00139724 File Offset: 0x00137924
	// (set) Token: 0x06002A79 RID: 10873 RVA: 0x0013844B File Offset: 0x0013664B
	internal ReflectionProbe EADKGGFJEDB { get; private set; }

	// Token: 0x06002A7A RID: 10874 RVA: 0x00139715 File Offset: 0x00137915
	private float EEHDKPCLPDP(float MBOBKEKFFJL)
	{
		return 142f + 1378f * MBOBKEKFFJL;
	}

	// Token: 0x06002A7B RID: 10875 RVA: 0x001340C0 File Offset: 0x001322C0
	private void HPJMBKLHNLM(float DCCPCBLODIG)
	{
		this.<PDKPGAFKBDK>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A7C RID: 10876 RVA: 0x00135645 File Offset: 0x00133845
	private void ELIGFKPNPDH(float DCCPCBLODIG)
	{
		this.<LENMEHHBFCA>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06002A7D RID: 10877 RVA: 0x00134931 File Offset: 0x00132B31
	internal float BJFMKAHHFLN
	{
		get
		{
			return this.NINFILJKEFA.JAFNHAHJLOH.intensity;
		}
	}

	// Token: 0x06002A7F RID: 10879 RVA: 0x0013972C File Offset: 0x0013792C
	private void DHIHHMFLACA()
	{
		if (this.KDIENMKDPOO())
		{
			return;
		}
		Mesh mesh = null;
		Mesh mesh2 = null;
		Mesh mesh3 = null;
		Mesh mesh4 = null;
		Mesh mesh5 = null;
		Mesh mesh6 = null;
		switch (this.MeshQuality)
		{
		case PDECLIHHEBE.Low:
			mesh = this.IICDLHPOOOA.IcosphereLow;
			mesh2 = this.IICDLHPOOOA.IcosphereLow;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereLow;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereLow;
			break;
		case PDECLIHHEBE.Medium:
			mesh = this.IICDLHPOOOA.IcosphereMedium;
			mesh2 = this.IICDLHPOOOA.IcosphereMedium;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereMedium;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereMedium;
			break;
		case PDECLIHHEBE.High:
			mesh = this.IICDLHPOOOA.IcosphereHigh;
			mesh2 = this.IICDLHPOOOA.IcosphereHigh;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereHigh;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereHigh;
			break;
		}
		if (this.NINFILJKEFA.MJFKDCPMDOF && this.KMBOELAHKHL().CHKCGPGIOPB != this.IICDLHPOOOA.SpaceMaterial)
		{
			this.NINFILJKEFA.CHKCGPGIOPB = (this.NINFILJKEFA.MJFKDCPMDOF.sharedMaterial = this.IICDLHPOOOA.SpaceMaterial);
		}
		if (this.NINFILJKEFA.JFBEDPHIDII && this.KMBOELAHKHL().FJKDDLPBBHD != this.IICDLHPOOOA.AtmosphereMaterial)
		{
			this.KMBOELAHKHL().FJKDDLPBBHD = (this.NINFILJKEFA.JFBEDPHIDII.sharedMaterial = this.IICDLHPOOOA.AtmosphereMaterial);
		}
		if (this.KMBOELAHKHL().NPGMCIEICBJ && this.KMBOELAHKHL().FMBBCDILBLE != this.IICDLHPOOOA.ClearMaterial)
		{
			this.NINFILJKEFA.FMBBCDILBLE = (this.NINFILJKEFA.NPGMCIEICBJ.sharedMaterial = this.IICDLHPOOOA.ClearMaterial);
		}
		if (this.KMBOELAHKHL().JHKOHMHKBOK && this.NINFILJKEFA.ENLCHIIOIBB != this.IICDLHPOOOA.CloudMaterial)
		{
			this.KMBOELAHKHL().ENLCHIIOIBB = (this.NINFILJKEFA.JHKOHMHKBOK.sharedMaterial = this.IICDLHPOOOA.CloudMaterial);
		}
		if (this.NINFILJKEFA.AIDEHKOPKHN && this.KMBOELAHKHL().HMFIBKJKOKK != this.IICDLHPOOOA.ShadowMaterial)
		{
			this.KMBOELAHKHL().HMFIBKJKOKK = (this.NINFILJKEFA.AIDEHKOPKHN.material = this.IICDLHPOOOA.ShadowMaterial);
		}
		if (this.NINFILJKEFA.HCCAOCECMEP && this.NINFILJKEFA.FKNIPFONANF != this.IICDLHPOOOA.SunMaterial)
		{
			this.NINFILJKEFA.FKNIPFONANF = (this.NINFILJKEFA.HCCAOCECMEP.sharedMaterial = this.IICDLHPOOOA.SunMaterial);
		}
		if (this.NINFILJKEFA.AMLLDIODOLD && this.NINFILJKEFA.OHAADBJGPHL != this.IICDLHPOOOA.MoonMaterial)
		{
			this.KMBOELAHKHL().OHAADBJGPHL = (this.NINFILJKEFA.AMLLDIODOLD.sharedMaterial = this.IICDLHPOOOA.MoonMaterial);
		}
		if (this.KMBOELAHKHL().DJFNJPHBAFO && this.KMBOELAHKHL().DJFNJPHBAFO.sharedMesh != mesh)
		{
			this.KMBOELAHKHL().DJFNJPHBAFO.mesh = mesh;
		}
		if (this.NINFILJKEFA.OIDGFIJEHKM && this.NINFILJKEFA.OIDGFIJEHKM.sharedMesh != mesh2)
		{
			this.NINFILJKEFA.OIDGFIJEHKM.mesh = mesh2;
		}
		if (this.KMBOELAHKHL().MBNJEJNIKDI && this.KMBOELAHKHL().MBNJEJNIKDI.sharedMesh != mesh3)
		{
			this.NINFILJKEFA.MBNJEJNIKDI.mesh = mesh3;
		}
		if (this.NINFILJKEFA.DDJNNFJINJE && this.KMBOELAHKHL().DDJNNFJINJE.sharedMesh != mesh4)
		{
			this.NINFILJKEFA.DDJNNFJINJE.mesh = mesh4;
		}
		if (this.NINFILJKEFA.HNCNKCJKFJO && this.KMBOELAHKHL().HNCNKCJKFJO.sharedMesh != mesh5)
		{
			this.KMBOELAHKHL().HNCNKCJKFJO.mesh = mesh5;
		}
		if (this.KMBOELAHKHL().LPNKELBJFHK && this.KMBOELAHKHL().LPNKELBJFHK.sharedMesh != mesh6)
		{
			this.NINFILJKEFA.LPNKELBJFHK.mesh = mesh6;
		}
	}

	// Token: 0x06002A80 RID: 10880 RVA: 0x0013751A File Offset: 0x0013571A
	private void MDPMAMPCKMC(Color DCCPCBLODIG)
	{
		this.<KBCGJCPFALB>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x06002A81 RID: 10881 RVA: 0x00139C34 File Offset: 0x00137E34
	private void AANPHEGGJEG()
	{
		if (this.NPKFLOJIACA)
		{
			return;
		}
		Mesh mesh = null;
		Mesh mesh2 = null;
		Mesh mesh3 = null;
		Mesh mesh4 = null;
		Mesh mesh5 = null;
		Mesh mesh6 = null;
		switch (this.MeshQuality)
		{
		case PDECLIHHEBE.Low:
			mesh = this.IICDLHPOOOA.IcosphereLow;
			mesh2 = this.IICDLHPOOOA.IcosphereLow;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereLow;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereLow;
			break;
		case PDECLIHHEBE.Medium:
			mesh = this.IICDLHPOOOA.IcosphereMedium;
			mesh2 = this.IICDLHPOOOA.IcosphereMedium;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereMedium;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereMedium;
			break;
		case PDECLIHHEBE.High:
			mesh = this.IICDLHPOOOA.IcosphereHigh;
			mesh2 = this.IICDLHPOOOA.IcosphereHigh;
			mesh3 = this.IICDLHPOOOA.IcosphereLow;
			mesh4 = this.IICDLHPOOOA.HalfIcosphereHigh;
			mesh5 = this.IICDLHPOOOA.Quad;
			mesh6 = this.IICDLHPOOOA.SphereHigh;
			break;
		}
		if (this.KMBOELAHKHL().MJFKDCPMDOF && this.NINFILJKEFA.CHKCGPGIOPB != this.IICDLHPOOOA.SpaceMaterial)
		{
			this.KMBOELAHKHL().CHKCGPGIOPB = (this.KMBOELAHKHL().MJFKDCPMDOF.sharedMaterial = this.IICDLHPOOOA.SpaceMaterial);
		}
		if (this.NINFILJKEFA.JFBEDPHIDII && this.KMBOELAHKHL().FJKDDLPBBHD != this.IICDLHPOOOA.AtmosphereMaterial)
		{
			this.KMBOELAHKHL().FJKDDLPBBHD = (this.KMBOELAHKHL().JFBEDPHIDII.sharedMaterial = this.IICDLHPOOOA.AtmosphereMaterial);
		}
		if (this.NINFILJKEFA.NPGMCIEICBJ && this.NINFILJKEFA.FMBBCDILBLE != this.IICDLHPOOOA.ClearMaterial)
		{
			this.KMBOELAHKHL().FMBBCDILBLE = (this.NINFILJKEFA.NPGMCIEICBJ.sharedMaterial = this.IICDLHPOOOA.ClearMaterial);
		}
		if (this.NINFILJKEFA.JHKOHMHKBOK && this.KMBOELAHKHL().ENLCHIIOIBB != this.IICDLHPOOOA.CloudMaterial)
		{
			this.KMBOELAHKHL().ENLCHIIOIBB = (this.KMBOELAHKHL().JHKOHMHKBOK.sharedMaterial = this.IICDLHPOOOA.CloudMaterial);
		}
		if (this.KMBOELAHKHL().AIDEHKOPKHN && this.KMBOELAHKHL().HMFIBKJKOKK != this.IICDLHPOOOA.ShadowMaterial)
		{
			this.NINFILJKEFA.HMFIBKJKOKK = (this.KMBOELAHKHL().AIDEHKOPKHN.material = this.IICDLHPOOOA.ShadowMaterial);
		}
		if (this.NINFILJKEFA.HCCAOCECMEP && this.NINFILJKEFA.FKNIPFONANF != this.IICDLHPOOOA.SunMaterial)
		{
			this.KMBOELAHKHL().FKNIPFONANF = (this.KMBOELAHKHL().HCCAOCECMEP.sharedMaterial = this.IICDLHPOOOA.SunMaterial);
		}
		if (this.NINFILJKEFA.AMLLDIODOLD && this.NINFILJKEFA.OHAADBJGPHL != this.IICDLHPOOOA.MoonMaterial)
		{
			this.NINFILJKEFA.OHAADBJGPHL = (this.NINFILJKEFA.AMLLDIODOLD.sharedMaterial = this.IICDLHPOOOA.MoonMaterial);
		}
		if (this.NINFILJKEFA.DJFNJPHBAFO && this.NINFILJKEFA.DJFNJPHBAFO.sharedMesh != mesh)
		{
			this.KMBOELAHKHL().DJFNJPHBAFO.mesh = mesh;
		}
		if (this.NINFILJKEFA.OIDGFIJEHKM && this.KMBOELAHKHL().OIDGFIJEHKM.sharedMesh != mesh2)
		{
			this.KMBOELAHKHL().OIDGFIJEHKM.mesh = mesh2;
		}
		if (this.NINFILJKEFA.MBNJEJNIKDI && this.KMBOELAHKHL().MBNJEJNIKDI.sharedMesh != mesh3)
		{
			this.KMBOELAHKHL().MBNJEJNIKDI.mesh = mesh3;
		}
		if (this.NINFILJKEFA.DDJNNFJINJE && this.NINFILJKEFA.DDJNNFJINJE.sharedMesh != mesh4)
		{
			this.KMBOELAHKHL().DDJNNFJINJE.mesh = mesh4;
		}
		if (this.KMBOELAHKHL().HNCNKCJKFJO && this.KMBOELAHKHL().HNCNKCJKFJO.sharedMesh != mesh5)
		{
			this.NINFILJKEFA.HNCNKCJKFJO.mesh = mesh5;
		}
		if (this.KMBOELAHKHL().LPNKELBJFHK && this.KMBOELAHKHL().LPNKELBJFHK.sharedMesh != mesh6)
		{
			this.KMBOELAHKHL().LPNKELBJFHK.mesh = mesh6;
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06002A82 RID: 10882 RVA: 0x00137BEE File Offset: 0x00135DEE
	internal float CCNNABIDNGI
	{
		get
		{
			return Mathf.Min(this.DIEMMEDEONP, this.KONNDFLICOM);
		}
	}

	// Token: 0x06002A84 RID: 10884 RVA: 0x0013A13C File Offset: 0x0013833C
	private void ILHPGJBLAJK(Material MHNAJNGGDFJ)
	{
		switch (this.CloudQuality)
		{
		case AFJGFOGMPFB.Fastest:
			MHNAJNGGDFJ.EnableKeyword("WoodCut");
			MHNAJNGGDFJ.DisableKeyword("MotorbikeWheely");
			MHNAJNGGDFJ.DisableKeyword("_mesh");
			return;
		case AFJGFOGMPFB.Density:
			MHNAJNGGDFJ.DisableKeyword("\npb_Face: ");
			MHNAJNGGDFJ.EnableKeyword("NextFrame");
			MHNAJNGGDFJ.DisableKeyword("</color>");
			return;
		case AFJGFOGMPFB.Bumped:
			MHNAJNGGDFJ.DisableKeyword(".png");
			MHNAJNGGDFJ.DisableKeyword("<color='#001040'>");
			MHNAJNGGDFJ.EnableKeyword(" ");
			return;
		default:
			return;
		}
	}

	// Token: 0x06002A85 RID: 10885 RVA: 0x0013564E File Offset: 0x0013384E
	internal Vector3 FMMIKMADCJA()
	{
		return this.<DEECDMENKGN>k__BackingField;
	}

	// Token: 0x06002A86 RID: 10886 RVA: 0x0013A1C8 File Offset: 0x001383C8
	internal Color BOIOMMIDIHF(bool CPHILDMPNGK = true)
	{
		Vector3 vector = Vector3.forward;
		if (this.NINFILJKEFA.MHJDBKALKDF != null)
		{
			vector = Quaternion.Euler(0f, this.NINFILJKEFA.MHJDBKALKDF.transform.rotation.eulerAngles.y, 0f) * vector;
		}
		Color color = this.CGFGPCBHLGA(Vector3.Lerp(vector, Vector3.up, this.Fog.HeightBias).normalized, CPHILDMPNGK);
		return new Color(color.r, color.g, color.b, 1f);
	}

	// Token: 0x06002A87 RID: 10887 RVA: 0x0013A268 File Offset: 0x00138468
	protected void LateUpdate()
	{
		this.JLKIBALMOHO();
		this.EDIMECHGKNP();
		this.DLAILOIOIAO();
		this.GOOPDIMEABB();
		this.KHGKKPIFPPA();
		this.KPHAPAKEPFL();
	}

	// Token: 0x06002A88 RID: 10888 RVA: 0x0013A290 File Offset: 0x00138490
	private void NKMKFKAOGDN()
	{
		if (this.NPKFLOJIACA)
		{
			return;
		}
		Vector4 value = this.KMBOELAHKHL().JEJLCMAKKCK.AAHOIGIDEOI + this.KMBOELAHKHL().JEJLCMAKKCK.KMFHELFPHBM();
		Vector4 value2 = new Vector4(this.Clouds.Scale1.x, this.Clouds.Scale1.y, this.Clouds.Scale2.x, this.Clouds.Scale2.y);
		float value3 = this.Clouds.ShadowStrength * Mathf.Clamp01(1369f - this.ELEPDHJOCNI() / 518f);
		Shader.SetGlobalColor(this.IICDLHPOOOA.FJIHFMOALEP, this.KEMNBFIFHAE());
		Shader.SetGlobalColor(this.IICDLHPOOOA.PBDNAONCCBD, this.LOCLPOPPNDM);
		Shader.SetGlobalColor(this.IICDLHPOOOA.ICEFEJNFPNB, this.IEMOLCMCELO * this.OMKANHCAJGK);
		Shader.SetGlobalColor(this.IICDLHPOOOA.DNCCNIPJJFP, this.IEMOLCMCELO * this.CPAPPAPPOFI);
		Shader.SetGlobalColor(this.IICDLHPOOOA.EPACGLABCFJ, this.OLGELHPEGGF);
		Shader.SetGlobalColor(this.IICDLHPOOOA.CGMKIBNPFFI, this.LOCDMCMPJKB);
		Shader.SetGlobalColor(this.IICDLHPOOOA.CMGHEMIEACC, this.IEMOLCMCELO);
		Shader.SetGlobalColor(this.IICDLHPOOOA.MIKPHLGJFKC, this.EDELNJGNLLG);
		Shader.SetGlobalColor(this.IICDLHPOOOA.PMDMDAEHDFE, this.POKLENFMAMC);
		Shader.SetGlobalVector(this.IICDLHPOOOA.LAOIHBNKNDC, this.FLFIIDICEHN);
		Shader.SetGlobalVector(this.IICDLHPOOOA.DKIOGOAGEMJ, this.BBJJJIBGGBL);
		Shader.SetGlobalVector(this.IICDLHPOOOA.LNJEDJHGDBA, this.PKMHDHPKIHN());
		Shader.SetGlobalVector(this.IICDLHPOOOA.PCGJBGMPMPJ, this.OONGJMPGDLL());
		Shader.SetGlobalVector(this.IICDLHPOOOA.LCFIPCLBNCP, this.GNGFKKJDIGA());
		Shader.SetGlobalVector(this.IICDLHPOOOA.GHENKAHBNGH, this.FPHCBMALHHH());
		Shader.SetGlobalFloat(this.IICDLHPOOOA.DIMGPCEBEGE, this.Atmosphere.Contrast);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.AHNEKMDHFKC, this.Atmosphere.Brightness);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.IGOEANOOFFF, this.Atmosphere.Fogginess);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.OFHAIPIBDBC, this.Atmosphere.Directionality);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.NJIOJANKEDD, 1154f / this.Moon.HaloSize);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.OEIDCFLBDAL, this.Clouds.Density);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.FNCBANADCBJ, this.Clouds.Sharpness);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.MAMMKBMCDED, value3);
		Shader.SetGlobalVector(this.IICDLHPOOOA.ALMNFJFCEKI, value2);
		Shader.SetGlobalVector(this.IICDLHPOOOA.IHHIGFMOPHG, value);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.CHGMOFGHPND, this.Stars.Tiling);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.MNHEGFNBGBP, this.Stars.Brightness * (287f - this.Atmosphere.Fogginess) * (1531f - this.DGKHAOJJNMF()));
		Shader.SetGlobalFloat(this.IICDLHPOOOA.OFNKEJPFHPM, 1066f / this.Sun.MeshContrast);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.JHGLFOIFPNA, this.Sun.MeshBrightness * (1887f - this.Atmosphere.Fogginess));
		Shader.SetGlobalFloat(this.IICDLHPOOOA.BEAGFOMBNIE, 939f / this.Moon.MeshContrast);
		Shader.SetGlobalFloat(this.IICDLHPOOOA.HAOPEKACGKJ, this.Moon.MeshBrightness * (388f - this.Atmosphere.Fogginess));
		Shader.SetGlobalVector(this.IICDLHPOOOA.JKPIIPGJCGL, this.COKJFFNOPFG);
		Shader.SetGlobalVector(this.IICDLHPOOOA.OLDFANLEEPP, this.FCCFGNPKEGL);
		Shader.SetGlobalVector(this.IICDLHPOOOA.JEBEODKPNBD, this.OAPINAGBCCE);
		Shader.SetGlobalVector(this.IICDLHPOOOA.FPFCLGAHHPJ, this.JFDOIFEOBNN);
		Shader.SetGlobalVector(this.IICDLHPOOOA.BIBGFHMDCOC, this.NGIPKOECGCI);
		Shader.SetGlobalMatrix(this.IICDLHPOOOA.PFENCNMEJGE, this.KMBOELAHKHL().JDGNBEHCGAL.worldToLocalMatrix);
		Shader.SetGlobalMatrix(this.IICDLHPOOOA.NIBOHKNFDPB, this.NINFILJKEFA.JDGNBEHCGAL.localToWorldMatrix);
		if (this.KMBOELAHKHL().AIDEHKOPKHN)
		{
			float farClipPlane = this.JFANJNEPJCH * 0f;
			float orthographicSize = this.JFANJNEPJCH;
			this.KMBOELAHKHL().AIDEHKOPKHN.farClipPlane = farClipPlane;
			this.NINFILJKEFA.AIDEHKOPKHN.orthographicSize = orthographicSize;
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06002A89 RID: 10889 RVA: 0x001382F9 File Offset: 0x001364F9
	// (set) Token: 0x06002A8B RID: 10891 RVA: 0x0013A799 File Offset: 0x00138999
	internal Color BJIBNKMMCJC { get; private set; }

	// Token: 0x06002A8A RID: 10890 RVA: 0x00137200 File Offset: 0x00135400
	internal Color IPHJGNIDBIN()
	{
		return this.<FHJHJMLIPMO>k__BackingField;
	}

	// Token: 0x06002A8C RID: 10892 RVA: 0x001396C7 File Offset: 0x001378C7
	internal Vector3 OONGJMPGDLL()
	{
		return this.<NGBNBELKLHL>k__BackingField;
	}

	// Token: 0x06002A8E RID: 10894 RVA: 0x00137441 File Offset: 0x00135641
	private void CDKPDHAMNKP(Color DCCPCBLODIG)
	{
		this.<HGLBDBPJFNH>k__BackingField = DCCPCBLODIG;
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x06002A91 RID: 10897 RVA: 0x0013A7AA File Offset: 0x001389AA
	// (set) Token: 0x06002A8F RID: 10895 RVA: 0x00137441 File Offset: 0x00135641
	internal Color LOCLPOPPNDM { get; private set; }

	// Token: 0x04000591 RID: 1425
	private static List<TOD_Sky> LMCKEHCLCNL = new List<TOD_Sky>();

	// Token: 0x04000592 RID: 1426
	private int POHKLJOAHBI = -1;

	// Token: 0x04000593 RID: 1427
	public HNMDLJHLBMH ColorSpace;

	// Token: 0x04000594 RID: 1428
	public GIKFKBPEMMH ColorRange;

	// Token: 0x04000595 RID: 1429
	public NBFCBMFHKBG SkyQuality;

	// Token: 0x04000596 RID: 1430
	public AFJGFOGMPFB CloudQuality = AFJGFOGMPFB.Bumped;

	// Token: 0x04000597 RID: 1431
	public PDECLIHHEBE MeshQuality = PDECLIHHEBE.High;

	// Token: 0x04000598 RID: 1432
	public TOD_CycleParameters Cycle;

	// Token: 0x04000599 RID: 1433
	public TOD_WorldParameters World;

	// Token: 0x0400059A RID: 1434
	public TOD_AtmosphereParameters Atmosphere;

	// Token: 0x0400059B RID: 1435
	public TOD_DayParameters Day;

	// Token: 0x0400059C RID: 1436
	public TOD_NightParameters Night;

	// Token: 0x0400059D RID: 1437
	public TOD_SunParameters Sun;

	// Token: 0x0400059E RID: 1438
	public TOD_MoonParameters Moon;

	// Token: 0x0400059F RID: 1439
	public TOD_StarParameters Stars;

	// Token: 0x040005A0 RID: 1440
	public TOD_CloudParameters Clouds;

	// Token: 0x040005A1 RID: 1441
	public TOD_LightParameters Light;

	// Token: 0x040005A2 RID: 1442
	public TOD_FogParameters Fog;

	// Token: 0x040005A3 RID: 1443
	public TOD_AmbientParameters Ambient;

	// Token: 0x040005A4 RID: 1444
	public TOD_ReflectionParameters Reflection;

	// Token: 0x040005C0 RID: 1472
	private float CNOCCBNLGAL = float.MaxValue;

	// Token: 0x040005C1 RID: 1473
	private float KIABEBCJCCE = float.MaxValue;

	// Token: 0x040005C2 RID: 1474
	private float OOLDPNCLDKB = float.MaxValue;

	// Token: 0x040005C3 RID: 1475
	private const int CHPDPCLMEFD = 2;

	// Token: 0x040005C4 RID: 1476
	private Vector3 COKJFFNOPFG;

	// Token: 0x040005C5 RID: 1477
	private Vector4 FCCFGNPKEGL;

	// Token: 0x040005C6 RID: 1478
	private Vector4 OAPINAGBCCE;

	// Token: 0x040005C7 RID: 1479
	private Vector4 JFDOIFEOBNN;

	// Token: 0x040005C8 RID: 1480
	private Vector4 NGIPKOECGCI;

	// Token: 0x040005C9 RID: 1481
	private const float JFMMNIJJODD = 3.1415927f;

	// Token: 0x040005CA RID: 1482
	private const float JBAPOECEFIA = 6.2831855f;
}
