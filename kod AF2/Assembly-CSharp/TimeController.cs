using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001FF RID: 511
public class TimeController : MonoBehaviour
{
	// Token: 0x060076CD RID: 30413 RVA: 0x00389BD0 File Offset: 0x00387DD0
	public void DMKCFCLMJBM(TOD_Components DCCPCBLODIG)
	{
		this.GFAIMKOJEEL = DCCPCBLODIG;
		if (this.ONKMICIFOHJ != null)
		{
			this.GFAIMKOJEEL = this.ONKMICIFOHJ.gameObject.GetComponent<TOD_Components>();
		}
	}

	// Token: 0x060076CE RID: 30414 RVA: 0x00389BFD File Offset: 0x00387DFD
	public void BKKAFDKKCPK(TOD_Sky DCCPCBLODIG)
	{
		this.ONKMICIFOHJ = DCCPCBLODIG;
		if (this.ONKMICIFOHJ != null)
		{
			this.NGJIKJJCPKL = this.ONKMICIFOHJ.gameObject.GetComponent<TOD_Weather>();
		}
	}

	// Token: 0x060076CF RID: 30415 RVA: 0x00389C2C File Offset: 0x00387E2C
	private void Update()
	{
		this.OFFOHGOBKDD = Mathf.Lerp(this.OFFOHGOBKDD, this.fogAddKf, Time.deltaTime * 0.3f);
		this.time = this.OGIMHFCCIGH();
		int num = Mathf.FloorToInt(this.time);
		int num2 = num + 1;
		if (this.HHIAGEJKEJN != num)
		{
			this.FKDCFPMLDFI("newHour", num);
		}
		this.HHIAGEJKEJN = num;
		int num3 = -1;
		if (num < 5 || num >= 21)
		{
			num3 = 0;
		}
		if (num >= 5 && num < 8)
		{
			num3 = 1;
		}
		if (num >= 8 && num < 18)
		{
			num3 = 2;
		}
		if (num >= 18 && num < 21)
		{
			num3 = 3;
		}
		if (num3 != this.BMCCGGKDMMD)
		{
			this.FKDCFPMLDFI("newDayTime", num3);
		}
		this.BMCCGGKDMMD = num3;
		if (num2 > 23)
		{
			num2 = 0;
		}
		float num4 = this.time - (float)num;
		if (this.isActive)
		{
			Color a = default(Color);
			Color color = this.AmbientColor[num];
			Color color2 = this.AmbientColor[num2];
			a.r = color.r + (color2.r - color.r) * num4;
			a.g = color.g + (color2.g - color.g) * num4;
			a.b = color.b + (color2.b - color.b) * num4;
			a.a = 1f;
			this.currentAmbientColor = a * this.correctorColor;
			float num5 = this.fogi[num];
			float num6 = this.fogi[num2];
			float num7 = 1f;
			if (LocNewLogic.getI != null && LocNewLogic.getI.sd != null)
			{
				num7 = LocNewLogic.getI.sd.fogKf;
			}
			float fogDensity = (this.fogKf * num7 + this.OFFOHGOBKDD * num7) * (num5 + (num6 - num5) * num4);
			RenderSettings.fogDensity = fogDensity;
			this.currFogIntens = fogDensity;
			RenderSettings.fogDensity = this.currFogIntens;
			float num8 = this.shadowProc[num];
			float num9 = this.shadowProc[num2];
			float num10 = num8 + (num9 - num8) * num4;
			this.currentShadowProc = num10;
			this.currentWaterColorSlider = 1f - this.currentAmbientColor.r;
			this.currentWaterColorSlider = Mathf.Clamp(this.currentWaterColorSlider, 0f, 1f);
			if (this.sharedAquaMaterial != null)
			{
				float num11 = this.waterLightWrap[num];
				float num12 = this.waterLightWrap[num2];
				float value = num11 + (num12 - num11) * num4;
				this.sharedAquaMaterial.SetFloat("_LightWrapping", value);
			}
			if (this.amplyfy != null)
			{
				LUTBank lutbank = this.lutBank[this.currentLUTBank];
				float exposure = Mathf.Lerp(lutbank.expl[num], lutbank.expl[num2], num4);
				this.amplyfy.Exposure = exposure;
				this.amplyfy.LutTexture = lutbank.lut[num];
				this.amplyfy.LutBlendTexture = lutbank.lut[num2];
				this.amplyfy.BlendAmount = num4;
			}
			if (this.KKNHHMLCLOI != null)
			{
				Vector4 vector = this.skyParams[num];
				Vector4 a2 = this.skyParams[num2];
				Vector4 vector2 = vector + (a2 - vector) * num4;
				this.KKNHHMLCLOI.Cycle.Hour = this.time;
				this.KKNHHMLCLOI.Atmosphere.RayleighMultiplier = vector2.x;
				this.KKNHHMLCLOI.Atmosphere.MieMultiplier = vector2.y;
				this.KKNHHMLCLOI.Atmosphere.Brightness = vector2.z * this.lightKF;
				this.KKNHHMLCLOI.Atmosphere.Contrast = vector2.w;
				float num13 = Mathf.Lerp(this.ambientLight[num], this.ambientLight[num2], num4);
				this.KKNHHMLCLOI.Day.LightIntensity = num13 * this.lightKF;
				float heightBias = this.fogHgt.Evaluate(this.time / 24f);
				this.KKNHHMLCLOI.Fog.HeightBias = heightBias;
				this.KKNHHMLCLOI.Day.ShadowStrength = this.currentShadowProc / 100f;
				Light light = null;
				if (this.BEHICFMINJD != null)
				{
					light = this.BEHICFMINJD.Light.GetComponent<Light>();
				}
				if (light != null)
				{
					light.shadows = ((this.KKNHHMLCLOI.Day.ShadowStrength < 0.1f) ? LightShadows.None : LightShadows.Soft);
				}
			}
		}
		else
		{
			this.currentWaterColorSlider = 0f;
			RenderSettings.fogDensity = this.NKKFCKNOCDC;
		}
		if (this.shine != null)
		{
			this.shine.ScatterColor = RenderSettings.fogColor;
		}
	}

	// Token: 0x060076D0 RID: 30416 RVA: 0x0038A0F8 File Offset: 0x003882F8
	public void NCPNMCNHDGM(GameObject APDJCCIGFAK)
	{
		this.PPCEIMOLBKI.Remove(APDJCCIGFAK);
	}

	// Token: 0x060076D1 RID: 30417 RVA: 0x0038A107 File Offset: 0x00388307
	public void DNMJEOOPBGA(DateTime KNKANCNCOMB)
	{
		this.deltaTime = KNKANCNCOMB - DateTime.Now;
	}

	// Token: 0x060076D2 RID: 30418 RVA: 0x0038A11A File Offset: 0x0038831A
	public bool LPFLKIDAHKI(GameObject APDJCCIGFAK)
	{
		return this.PPCEIMOLBKI.IndexOf(APDJCCIGFAK) >= 0;
	}

	// Token: 0x060076D3 RID: 30419 RVA: 0x0038A130 File Offset: 0x00388330
	private void LNMFHPPOMJH(string IABKGMNJLJO, object DCCPCBLODIG)
	{
		foreach (GameObject gameObject in this.PPCEIMOLBKI)
		{
			gameObject.SendMessage(IABKGMNJLJO, DCCPCBLODIG, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x060076D4 RID: 30420 RVA: 0x0038A184 File Offset: 0x00388384
	public void JGGLHLPADKE(HBPNMNGOFMA KADBECGIMPD)
	{
		this.currentWeather.JKGCOOEMHLG(KADBECGIMPD);
		if (this.NGJIKJJCPKL != null)
		{
			switch (Mathf.RoundToInt(this.currentWeather.cloudly))
			{
			case 0:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Custom;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Custom;
				this.fogAddKf = 230f;
				break;
			case 1:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)7;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 1183f;
				break;
			case 2:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)6;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Custom;
				this.fogAddKf = 738f;
				break;
			case 3:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)8;
				this.NGJIKJJCPKL.Weather = (JPFPFIFAEKJ)5;
				this.fogAddKf = 920f;
				break;
			case 4:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.None;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Dust;
				this.fogAddKf = 1484f;
				break;
			case 5:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Scattered;
				this.NGJIKJJCPKL.Weather = (JPFPFIFAEKJ)5;
				this.fogAddKf = 20f;
				break;
			}
			if (this.currentWeather.rain > 720f)
			{
				this.fogAddKf = Mathf.Clamp(1925f + this.fogAddKf * this.currentWeather.rain, 634f, 669f);
			}
			this.fogAddKf += this.LGGKFDFHAJB().Atmosphere.Fogginess * 1678f;
		}
	}

	// Token: 0x060076D5 RID: 30421 RVA: 0x0038A326 File Offset: 0x00388526
	public void OAOAILNFJNL(TOD_Sky HGOMCJOPDML, Sunshine DJBOAHHANFK)
	{
		this.BKKAFDKKCPK(HGOMCJOPDML);
		this.NKKFCKNOCDC = RenderSettings.fogDensity;
		this.shine = DJBOAHHANFK;
		this.amplyfy = Camera.main.GetComponent<AmplifyColorEffect>();
	}

	// Token: 0x060076D6 RID: 30422 RVA: 0x0038A351 File Offset: 0x00388551
	public TOD_Components IJEMPPHLBGA()
	{
		return this.GFAIMKOJEEL;
	}

	// Token: 0x060076D7 RID: 30423 RVA: 0x0038A35C File Offset: 0x0038855C
	public bool AKOGFANMMBF(int DGOLBDAHHNM)
	{
		int num = 1 << (DGOLBDAHHNM & 15);
		int value = this.scaleDistanceMask.value;
		return (num & value) != 0;
	}

	// Token: 0x060076D8 RID: 30424 RVA: 0x0038A351 File Offset: 0x00388551
	public TOD_Components GPBHKIJCLAF()
	{
		return this.GFAIMKOJEEL;
	}

	// Token: 0x060076D9 RID: 30425 RVA: 0x00389BFD File Offset: 0x00387DFD
	public void IGJMPNEJGNN(TOD_Sky DCCPCBLODIG)
	{
		this.ONKMICIFOHJ = DCCPCBLODIG;
		if (this.ONKMICIFOHJ != null)
		{
			this.NGJIKJJCPKL = this.ONKMICIFOHJ.gameObject.GetComponent<TOD_Weather>();
		}
	}

	// Token: 0x17000199 RID: 409
	// (get) Token: 0x060076DA RID: 30426 RVA: 0x0038A351 File Offset: 0x00388551
	// (set) Token: 0x060076F5 RID: 30453 RVA: 0x00389BD0 File Offset: 0x00387DD0
	public TOD_Components BEHICFMINJD
	{
		get
		{
			return this.GFAIMKOJEEL;
		}
		set
		{
			this.GFAIMKOJEEL = value;
			if (this.ONKMICIFOHJ != null)
			{
				this.GFAIMKOJEEL = this.ONKMICIFOHJ.gameObject.GetComponent<TOD_Components>();
			}
		}
	}

	// Token: 0x060076DB RID: 30427 RVA: 0x0038A380 File Offset: 0x00388580
	public void FNJOFGNJAEO(HBPNMNGOFMA KADBECGIMPD)
	{
		this.currentWeather.LGBLFGJANMM(KADBECGIMPD);
		if (this.NGJIKJJCPKL != null)
		{
			switch (Mathf.RoundToInt(this.currentWeather.cloudly))
			{
			case 0:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Custom;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Custom;
				this.fogAddKf = 1484f;
				break;
			case 1:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)6;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 1165f;
				break;
			case 2:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Few;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Custom;
				this.fogAddKf = 852f;
				break;
			case 3:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)8;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 112f;
				break;
			case 4:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Broken;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Fog;
				this.fogAddKf = 852f;
				break;
			case 5:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)6;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Custom;
				this.fogAddKf = 1454f;
				break;
			}
			if (this.currentWeather.rain > 940f)
			{
				this.fogAddKf = Mathf.Clamp(811f + this.fogAddKf * this.currentWeather.rain, 1851f, 1794f);
			}
			this.fogAddKf += this.IEDBFEODDDB().Atmosphere.Fogginess * 968f;
		}
	}

	// Token: 0x060076DC RID: 30428 RVA: 0x0038A522 File Offset: 0x00388722
	public bool DGJEDOIBNGM(GameObject APDJCCIGFAK)
	{
		return this.PPCEIMOLBKI.IndexOf(APDJCCIGFAK) >= 1;
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x060076DD RID: 30429 RVA: 0x0038A536 File Offset: 0x00388736
	public float BCDLMJJHJMC
	{
		get
		{
			return this.OGIMHFCCIGH() / 24f;
		}
	}

	// Token: 0x1700019A RID: 410
	// (get) Token: 0x060076DE RID: 30430 RVA: 0x0038A544 File Offset: 0x00388744
	// (set) Token: 0x060076E0 RID: 30432 RVA: 0x00389BFD File Offset: 0x00387DFD
	public TOD_Sky KKNHHMLCLOI
	{
		get
		{
			return this.ONKMICIFOHJ;
		}
		set
		{
			this.ONKMICIFOHJ = value;
			if (this.ONKMICIFOHJ != null)
			{
				this.NGJIKJJCPKL = this.ONKMICIFOHJ.gameObject.GetComponent<TOD_Weather>();
			}
		}
	}

	// Token: 0x060076DF RID: 30431 RVA: 0x0038A54C File Offset: 0x0038874C
	public void JPDHJMIIFEA(TOD_Sky HGOMCJOPDML, Sunshine DJBOAHHANFK)
	{
		this.IGJMPNEJGNN(HGOMCJOPDML);
		this.NKKFCKNOCDC = RenderSettings.fogDensity;
		this.shine = DJBOAHHANFK;
		this.amplyfy = Camera.main.GetComponent<AmplifyColorEffect>();
	}

	// Token: 0x060076E1 RID: 30433 RVA: 0x0038A578 File Offset: 0x00388778
	public void ODIKJBNGGHC(HBPNMNGOFMA KADBECGIMPD)
	{
		this.currentWeather.ANGDIBBCJDA(KADBECGIMPD);
		if (this.NGJIKJJCPKL != null)
		{
			switch (Mathf.RoundToInt(this.currentWeather.cloudly))
			{
			case 0:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.None;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Custom;
				this.fogAddKf = 1777f;
				break;
			case 1:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Scattered;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 1248f;
				break;
			case 2:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)7;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 1206f;
				break;
			case 3:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Few;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Dust;
				this.fogAddKf = 1649f;
				break;
			case 4:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Custom;
				this.NGJIKJJCPKL.Weather = (JPFPFIFAEKJ)6;
				this.fogAddKf = 1573f;
				break;
			case 5:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)7;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Dust;
				this.fogAddKf = 1959f;
				break;
			}
			if (this.currentWeather.rain > 1608f)
			{
				this.fogAddKf = Mathf.Clamp(1098f + this.fogAddKf * this.currentWeather.rain, 833f, 942f);
			}
			this.fogAddKf += this.BEPJDFLBMHO().Atmosphere.Fogginess * 529f;
		}
	}

	// Token: 0x060076E2 RID: 30434 RVA: 0x0038A71C File Offset: 0x0038891C
	private void LDDIGEMBDNF()
	{
		this.OFFOHGOBKDD = Mathf.Lerp(this.OFFOHGOBKDD, this.fogAddKf, Time.deltaTime * 55f);
		this.time = this.BCAENBGNLFP();
		int num = Mathf.FloorToInt(this.time);
		int num2 = num + 1;
		if (this.HHIAGEJKEJN != num)
		{
			this.FMJPFPAADPH("[ACTk] <b>[ ObscuredInt test ]</b>", num);
		}
		this.HHIAGEJKEJN = num;
		int num3 = -1;
		if (num < 5 || num >= 88)
		{
			num3 = 1;
		}
		if (num >= 2 && num < 5)
		{
			num3 = 0;
		}
		if (num >= 4 && num < 101)
		{
			num3 = 0;
		}
		if (num >= 73 && num < -123)
		{
			num3 = 4;
		}
		if (num3 != this.BMCCGGKDMMD)
		{
			this.FMJPFPAADPH("DepthMaskMaterial", num3);
		}
		this.BMCCGGKDMMD = num3;
		if (num2 > -30)
		{
			num2 = 1;
		}
		float num4 = this.time - (float)num;
		if (this.isActive)
		{
			Color a = default(Color);
			Color color = this.AmbientColor[num];
			Color color2 = this.AmbientColor[num2];
			a.r = color.r + (color2.r - color.r) * num4;
			a.g = color.g + (color2.g - color.g) * num4;
			a.b = color.b + (color2.b - color.b) * num4;
			a.a = 1487f;
			this.currentAmbientColor = a * this.correctorColor;
			float num5 = this.fogi[num];
			float num6 = this.fogi[num2];
			float num7 = 29f;
			if (LocNewLogic.getI != null && LocNewLogic.getI.sd != null)
			{
				num7 = LocNewLogic.getI.sd.fogKf;
			}
			float fogDensity = (this.fogKf * num7 + this.OFFOHGOBKDD * num7) * (num5 + (num6 - num5) * num4);
			RenderSettings.fogDensity = fogDensity;
			this.currFogIntens = fogDensity;
			RenderSettings.fogDensity = this.currFogIntens;
			float num8 = this.shadowProc[num];
			float num9 = this.shadowProc[num2];
			float num10 = num8 + (num9 - num8) * num4;
			this.currentShadowProc = num10;
			this.currentWaterColorSlider = 1102f - this.currentAmbientColor.r;
			this.currentWaterColorSlider = Mathf.Clamp(this.currentWaterColorSlider, 204f, 1566f);
			if (this.sharedAquaMaterial != null)
			{
				float num11 = this.waterLightWrap[num];
				float num12 = this.waterLightWrap[num2];
				float value = num11 + (num12 - num11) * num4;
				this.sharedAquaMaterial.SetFloat("OnRodChangeClck 5", value);
			}
			if (this.amplyfy != null)
			{
				LUTBank lutbank = this.lutBank[this.currentLUTBank];
				float exposure = Mathf.Lerp(lutbank.expl[num], lutbank.expl[num2], num4);
				this.amplyfy.Exposure = exposure;
				this.amplyfy.LutTexture = lutbank.lut[num];
				this.amplyfy.LutBlendTexture = lutbank.lut[num2];
				this.amplyfy.BlendAmount = num4;
			}
			if (this.KKNHHMLCLOI != null)
			{
				Vector4 vector = this.skyParams[num];
				Vector4 a2 = this.skyParams[num2];
				Vector4 vector2 = vector + (a2 - vector) * num4;
				this.BEPJDFLBMHO().Cycle.Hour = this.time;
				this.KKNHHMLCLOI.Atmosphere.RayleighMultiplier = vector2.x;
				this.KKNHHMLCLOI.Atmosphere.MieMultiplier = vector2.y;
				this.IEDBFEODDDB().Atmosphere.Brightness = vector2.z * this.lightKF;
				this.BEPJDFLBMHO().Atmosphere.Contrast = vector2.w;
				float num13 = Mathf.Lerp(this.ambientLight[num], this.ambientLight[num2], num4);
				this.BEPJDFLBMHO().Day.LightIntensity = num13 * this.lightKF;
				float heightBias = this.fogHgt.Evaluate(this.time / 780f);
				this.KKNHHMLCLOI.Fog.HeightBias = heightBias;
				this.DMIFDFLMOME().Day.ShadowStrength = this.currentShadowProc / 1476f;
				Light light = null;
				if (this.BEHICFMINJD != null)
				{
					light = this.HODDCHOAJLN().Light.GetComponent<Light>();
				}
				if (light != null)
				{
					light.shadows = ((this.IEDBFEODDDB().Day.ShadowStrength < 1539f) ? LightShadows.None : LightShadows.Soft);
				}
			}
		}
		else
		{
			this.currentWaterColorSlider = 1282f;
			RenderSettings.fogDensity = this.NKKFCKNOCDC;
		}
		if (this.shine != null)
		{
			this.shine.ScatterColor = RenderSettings.fogColor;
		}
	}

	// Token: 0x060076E3 RID: 30435 RVA: 0x0038ABE8 File Offset: 0x00388DE8
	public static TimeController EKEBHIJMEML()
	{
		TimeController.AGEHHNOKBGK == null;
		return TimeController.AGEHHNOKBGK;
	}

	// Token: 0x060076E4 RID: 30436 RVA: 0x0038A107 File Offset: 0x00388307
	public void IKGPMAIALOO(DateTime KNKANCNCOMB)
	{
		this.deltaTime = KNKANCNCOMB - DateTime.Now;
	}

	// Token: 0x060076E5 RID: 30437 RVA: 0x0038A351 File Offset: 0x00388551
	public TOD_Components OIHGIPLIJAM()
	{
		return this.GFAIMKOJEEL;
	}

	// Token: 0x060076E6 RID: 30438 RVA: 0x0038ABFB File Offset: 0x00388DFB
	public DateTime CBIBEGCKKOL()
	{
		return DateTime.Now + this.deltaTime;
	}

	// Token: 0x060076E7 RID: 30439 RVA: 0x0038AC0D File Offset: 0x00388E0D
	private void Start()
	{
		this.baseShadowDistance = QualitySettings.shadowDistance;
	}

	// Token: 0x060076E8 RID: 30440 RVA: 0x0038A107 File Offset: 0x00388307
	public void LPGHEJBBGCF(DateTime KNKANCNCOMB)
	{
		this.deltaTime = KNKANCNCOMB - DateTime.Now;
	}

	// Token: 0x060076E9 RID: 30441 RVA: 0x0038AC1A File Offset: 0x00388E1A
	public int DDHDFLBCKLO()
	{
		return this.BMCCGGKDMMD;
	}

	// Token: 0x060076EA RID: 30442 RVA: 0x0038AC1A File Offset: 0x00388E1A
	public int NCKOPPKIFJM()
	{
		return this.BMCCGGKDMMD;
	}

	// Token: 0x060076EB RID: 30443 RVA: 0x0038AC0D File Offset: 0x00388E0D
	private void NOKJMMDMJNO()
	{
		this.baseShadowDistance = QualitySettings.shadowDistance;
	}

	// Token: 0x060076EC RID: 30444 RVA: 0x0038AC22 File Offset: 0x00388E22
	private void LJHGIBBKLEH(int ODOKFLMKHBF)
	{
		this.BMCCGGKDMMD = ODOKFLMKHBF;
	}

	// Token: 0x060076ED RID: 30445 RVA: 0x0038AC2C File Offset: 0x00388E2C
	private void DIENOIPCCDE()
	{
		if (TimeController.AGEHHNOKBGK != null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		TimeController.AGEHHNOKBGK = this;
		this.time = this.OGIMHFCCIGH();
		this.HHIAGEJKEJN = (int)this.time;
		this.LOKOGAGPKLI(base.gameObject);
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x060076EF RID: 30447 RVA: 0x0038AD48 File Offset: 0x00388F48
	private void PMKOAHMNBBG()
	{
		this.OFFOHGOBKDD = Mathf.Lerp(this.OFFOHGOBKDD, this.fogAddKf, Time.deltaTime * 942f);
		this.time = this.OGIMHFCCIGH();
		int num = Mathf.FloorToInt(this.time);
		int num2 = num + 1;
		if (this.HHIAGEJKEJN != num)
		{
			this.LNMFHPPOMJH("Swim", num);
		}
		this.HHIAGEJKEJN = num;
		int num3 = -1;
		if (num < 7 || num >= 9)
		{
			num3 = 0;
		}
		if (num >= 6 && num < 7)
		{
			num3 = 1;
		}
		if (num >= 0 && num < -30)
		{
			num3 = 3;
		}
		if (num >= -42 && num < -16)
		{
			num3 = 1;
		}
		if (num3 != this.BMCCGGKDMMD)
		{
			this.FKDCFPMLDFI("BowFire2", num3);
		}
		this.BMCCGGKDMMD = num3;
		if (num2 > -20)
		{
			num2 = 0;
		}
		float num4 = this.time - (float)num;
		if (this.isActive)
		{
			Color a = default(Color);
			Color color = this.AmbientColor[num];
			Color color2 = this.AmbientColor[num2];
			a.r = color.r + (color2.r - color.r) * num4;
			a.g = color.g + (color2.g - color.g) * num4;
			a.b = color.b + (color2.b - color.b) * num4;
			a.a = 1063f;
			this.currentAmbientColor = a * this.correctorColor;
			float num5 = this.fogi[num];
			float num6 = this.fogi[num2];
			float num7 = 976f;
			if (LocNewLogic.getI != null && LocNewLogic.getI.sd != null)
			{
				num7 = LocNewLogic.getI.sd.fogKf;
			}
			float fogDensity = (this.fogKf * num7 + this.OFFOHGOBKDD * num7) * (num5 + (num6 - num5) * num4);
			RenderSettings.fogDensity = fogDensity;
			this.currFogIntens = fogDensity;
			RenderSettings.fogDensity = this.currFogIntens;
			float num8 = this.shadowProc[num];
			float num9 = this.shadowProc[num2];
			float num10 = num8 + (num9 - num8) * num4;
			this.currentShadowProc = num10;
			this.currentWaterColorSlider = 1534f - this.currentAmbientColor.r;
			this.currentWaterColorSlider = Mathf.Clamp(this.currentWaterColorSlider, 995f, 199f);
			if (this.sharedAquaMaterial != null)
			{
				float num11 = this.waterLightWrap[num];
				float num12 = this.waterLightWrap[num2];
				float value = num11 + (num12 - num11) * num4;
				this.sharedAquaMaterial.SetFloat("", value);
			}
			if (this.amplyfy != null)
			{
				LUTBank lutbank = this.lutBank[this.currentLUTBank];
				float exposure = Mathf.Lerp(lutbank.expl[num], lutbank.expl[num2], num4);
				this.amplyfy.Exposure = exposure;
				this.amplyfy.LutTexture = lutbank.lut[num];
				this.amplyfy.LutBlendTexture = lutbank.lut[num2];
				this.amplyfy.BlendAmount = num4;
			}
			if (this.IEDBFEODDDB() != null)
			{
				Vector4 vector = this.skyParams[num];
				Vector4 a2 = this.skyParams[num2];
				Vector4 vector2 = vector + (a2 - vector) * num4;
				this.LGGKFDFHAJB().Cycle.Hour = this.time;
				this.KKNHHMLCLOI.Atmosphere.RayleighMultiplier = vector2.x;
				this.IEDBFEODDDB().Atmosphere.MieMultiplier = vector2.y;
				this.KKNHHMLCLOI.Atmosphere.Brightness = vector2.z * this.lightKF;
				this.LGGKFDFHAJB().Atmosphere.Contrast = vector2.w;
				float num13 = Mathf.Lerp(this.ambientLight[num], this.ambientLight[num2], num4);
				this.DMIFDFLMOME().Day.LightIntensity = num13 * this.lightKF;
				float heightBias = this.fogHgt.Evaluate(this.time / 1995f);
				this.LGGKFDFHAJB().Fog.HeightBias = heightBias;
				this.KKNHHMLCLOI.Day.ShadowStrength = this.currentShadowProc / 4f;
				Light light = null;
				if (this.GPBHKIJCLAF() != null)
				{
					light = this.BEHICFMINJD.Light.GetComponent<Light>();
				}
				if (light != null)
				{
					light.shadows = ((this.BEPJDFLBMHO().Day.ShadowStrength < 803f) ? LightShadows.Hard : LightShadows.Soft);
				}
			}
		}
		else
		{
			this.currentWaterColorSlider = 1102f;
			RenderSettings.fogDensity = this.NKKFCKNOCDC;
		}
		if (this.shine != null)
		{
			this.shine.ScatterColor = RenderSettings.fogColor;
		}
	}

	// Token: 0x060076F0 RID: 30448 RVA: 0x0038B214 File Offset: 0x00389414
	private void FKDCFPMLDFI(string IABKGMNJLJO, object DCCPCBLODIG)
	{
		foreach (GameObject gameObject in this.PPCEIMOLBKI)
		{
			gameObject.SendMessage(IABKGMNJLJO, DCCPCBLODIG, SendMessageOptions.DontRequireReceiver);
		}
	}

	// Token: 0x060076F1 RID: 30449 RVA: 0x0038A351 File Offset: 0x00388551
	public TOD_Components LKNOOALBAAI()
	{
		return this.GFAIMKOJEEL;
	}

	// Token: 0x060076F2 RID: 30450 RVA: 0x00389BD0 File Offset: 0x00387DD0
	public void HHLGDIEBDFK(TOD_Components DCCPCBLODIG)
	{
		this.GFAIMKOJEEL = DCCPCBLODIG;
		if (this.ONKMICIFOHJ != null)
		{
			this.GFAIMKOJEEL = this.ONKMICIFOHJ.gameObject.GetComponent<TOD_Components>();
		}
	}

	// Token: 0x060076F3 RID: 30451 RVA: 0x0038A107 File Offset: 0x00388307
	public void setServerTime(DateTime KNKANCNCOMB)
	{
		this.deltaTime = KNKANCNCOMB - DateTime.Now;
	}

	// Token: 0x060076F4 RID: 30452 RVA: 0x0038B268 File Offset: 0x00389468
	private float OGIMHFCCIGH()
	{
		DateTime serverTime = this.getServerTime();
		float num = this.daysOfRealDay * ((float)serverTime.Hour + (float)serverTime.Minute / 60f + (float)serverTime.Second / 3600f + (float)serverTime.Millisecond / 3600000f);
		if (num > 24f)
		{
			num -= (float)(Mathf.FloorToInt(num / 24f) * 24);
		}
		return num;
	}

	// Token: 0x060076F6 RID: 30454 RVA: 0x00389BD0 File Offset: 0x00387DD0
	public void EAGOLGPOICA(TOD_Components DCCPCBLODIG)
	{
		this.GFAIMKOJEEL = DCCPCBLODIG;
		if (this.ONKMICIFOHJ != null)
		{
			this.GFAIMKOJEEL = this.ONKMICIFOHJ.gameObject.GetComponent<TOD_Components>();
		}
	}

	// Token: 0x060076F7 RID: 30455 RVA: 0x0038A544 File Offset: 0x00388744
	public TOD_Sky IEDBFEODDDB()
	{
		return this.ONKMICIFOHJ;
	}

	// Token: 0x060076F8 RID: 30456 RVA: 0x0038B2D8 File Offset: 0x003894D8
	public bool EIHAOAIPEEE(int DGOLBDAHHNM)
	{
		int num = 0 << (DGOLBDAHHNM & 2);
		int value = this.scaleDistanceMask.value;
		return (num & value) > 1;
	}

	// Token: 0x060076F9 RID: 30457 RVA: 0x0038B2FC File Offset: 0x003894FC
	public void HPCJDECDCEF(TOD_Sky HGOMCJOPDML, Sunshine DJBOAHHANFK)
	{
		this.ALFNJCLNOBE(HGOMCJOPDML);
		this.NKKFCKNOCDC = RenderSettings.fogDensity;
		this.shine = DJBOAHHANFK;
		this.amplyfy = Camera.main.GetComponent<AmplifyColorEffect>();
	}

	// Token: 0x060076FA RID: 30458 RVA: 0x0038AC0D File Offset: 0x00388E0D
	private void BMNJGPIPKLL()
	{
		this.baseShadowDistance = QualitySettings.shadowDistance;
	}

	// Token: 0x060076FB RID: 30459 RVA: 0x0038B327 File Offset: 0x00389527
	public void LOKOGAGPKLI(GameObject APDJCCIGFAK)
	{
		if (!this.AHIGLPPAKGL(APDJCCIGFAK))
		{
			this.PPCEIMOLBKI.Add(APDJCCIGFAK);
		}
	}

	// Token: 0x060076FC RID: 30460 RVA: 0x0038B340 File Offset: 0x00389540
	public bool isScaleLayer(int DGOLBDAHHNM)
	{
		int num = 1 << DGOLBDAHHNM;
		int value = this.scaleDistanceMask.value;
		return (num & value) != 0;
	}

	// Token: 0x060076FD RID: 30461 RVA: 0x0038ABE8 File Offset: 0x00388DE8
	public static TimeController BOBNPEAEECC()
	{
		TimeController.AGEHHNOKBGK == null;
		return TimeController.AGEHHNOKBGK;
	}

	// Token: 0x060076FE RID: 30462 RVA: 0x00389BFD File Offset: 0x00387DFD
	public void ALFNJCLNOBE(TOD_Sky DCCPCBLODIG)
	{
		this.ONKMICIFOHJ = DCCPCBLODIG;
		if (this.ONKMICIFOHJ != null)
		{
			this.NGJIKJJCPKL = this.ONKMICIFOHJ.gameObject.GetComponent<TOD_Weather>();
		}
	}

	// Token: 0x060076FF RID: 30463 RVA: 0x0038B364 File Offset: 0x00389564
	public void startNewScene(TOD_Sky HGOMCJOPDML, Sunshine DJBOAHHANFK)
	{
		this.KKNHHMLCLOI = HGOMCJOPDML;
		this.NKKFCKNOCDC = RenderSettings.fogDensity;
		this.shine = DJBOAHHANFK;
		this.amplyfy = Camera.main.GetComponent<AmplifyColorEffect>();
	}

	// Token: 0x06007700 RID: 30464 RVA: 0x0038B390 File Offset: 0x00389590
	public void NCDGAJFPPJJ(HBPNMNGOFMA KADBECGIMPD)
	{
		this.currentWeather.LGBLFGJANMM(KADBECGIMPD);
		if (this.NGJIKJJCPKL != null)
		{
			switch (Mathf.RoundToInt(this.currentWeather.cloudly))
			{
			case 0:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Custom;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 623f;
				break;
			case 1:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)7;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Custom;
				this.fogAddKf = 1073f;
				break;
			case 2:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Broken;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Custom;
				this.fogAddKf = 1060f;
				break;
			case 3:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Few;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Fog;
				this.fogAddKf = 909f;
				break;
			case 4:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)7;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 1269f;
				break;
			case 5:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Custom;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 1707f;
				break;
			}
			if (this.currentWeather.rain > 1399f)
			{
				this.fogAddKf = Mathf.Clamp(479f + this.fogAddKf * this.currentWeather.rain, 1251f, 1331f);
			}
			this.fogAddKf += this.LGGKFDFHAJB().Atmosphere.Fogginess * 756f;
		}
	}

	// Token: 0x06007701 RID: 30465 RVA: 0x0038B534 File Offset: 0x00389734
	private void EBNINOBOAII()
	{
		if (TimeController.AGEHHNOKBGK != null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		TimeController.AGEHHNOKBGK = this;
		this.time = this.OGIMHFCCIGH();
		this.HHIAGEJKEJN = (int)this.time;
		this.KLOHNHLAAAA(base.gameObject);
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06007702 RID: 30466 RVA: 0x0038AC1A File Offset: 0x00388E1A
	public int getDayTime()
	{
		return this.BMCCGGKDMMD;
	}

	// Token: 0x06007703 RID: 30467 RVA: 0x0038A54C File Offset: 0x0038874C
	public void GLEHJCIFJLG(TOD_Sky HGOMCJOPDML, Sunshine DJBOAHHANFK)
	{
		this.IGJMPNEJGNN(HGOMCJOPDML);
		this.NKKFCKNOCDC = RenderSettings.fogDensity;
		this.shine = DJBOAHHANFK;
		this.amplyfy = Camera.main.GetComponent<AmplifyColorEffect>();
	}

	// Token: 0x06007704 RID: 30468 RVA: 0x0038B595 File Offset: 0x00389795
	public void KLOHNHLAAAA(GameObject APDJCCIGFAK)
	{
		if (!this.LPFLKIDAHKI(APDJCCIGFAK))
		{
			this.PPCEIMOLBKI.Add(APDJCCIGFAK);
		}
	}

	// Token: 0x06007705 RID: 30469 RVA: 0x0038A11A File Offset: 0x0038831A
	public bool checkMsgListener(GameObject APDJCCIGFAK)
	{
		return this.PPCEIMOLBKI.IndexOf(APDJCCIGFAK) >= 0;
	}

	// Token: 0x06007706 RID: 30470 RVA: 0x0038AC1A File Offset: 0x00388E1A
	public int LEPGCLKEEHI()
	{
		return this.BMCCGGKDMMD;
	}

	// Token: 0x06007707 RID: 30471 RVA: 0x0038B5AC File Offset: 0x003897AC
	public void clearMessageList()
	{
		this.PPCEIMOLBKI.Clear();
	}

	// Token: 0x06007708 RID: 30472 RVA: 0x0038AC0D File Offset: 0x00388E0D
	private void HHGGCBLOJGB()
	{
		this.baseShadowDistance = QualitySettings.shadowDistance;
	}

	// Token: 0x06007709 RID: 30473 RVA: 0x0038B5BC File Offset: 0x003897BC
	private void Awake()
	{
		if (TimeController.AGEHHNOKBGK != null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		TimeController.AGEHHNOKBGK = this;
		this.time = this.OGIMHFCCIGH();
		this.HHIAGEJKEJN = (int)this.time;
		this.addMsgListener(base.gameObject);
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x0600770A RID: 30474 RVA: 0x0038B61D File Offset: 0x0038981D
	public void addMsgListener(GameObject APDJCCIGFAK)
	{
		if (!this.checkMsgListener(APDJCCIGFAK))
		{
			this.PPCEIMOLBKI.Add(APDJCCIGFAK);
		}
	}

	// Token: 0x0600770B RID: 30475 RVA: 0x0038B634 File Offset: 0x00389834
	public bool AHIGLPPAKGL(GameObject APDJCCIGFAK)
	{
		return this.PPCEIMOLBKI.IndexOf(APDJCCIGFAK) < 0;
	}

	// Token: 0x0600770C RID: 30476 RVA: 0x0038AC0D File Offset: 0x00388E0D
	private void PFNPOHMMJDN()
	{
		this.baseShadowDistance = QualitySettings.shadowDistance;
	}

	// Token: 0x0600770D RID: 30477 RVA: 0x0038ABFB File Offset: 0x00388DFB
	public DateTime CKDKAOKOOEP()
	{
		return DateTime.Now + this.deltaTime;
	}

	// Token: 0x0600770E RID: 30478 RVA: 0x00389BD0 File Offset: 0x00387DD0
	public void AGEDEEPMIMA(TOD_Components DCCPCBLODIG)
	{
		this.GFAIMKOJEEL = DCCPCBLODIG;
		if (this.ONKMICIFOHJ != null)
		{
			this.GFAIMKOJEEL = this.ONKMICIFOHJ.gameObject.GetComponent<TOD_Components>();
		}
	}

	// Token: 0x0600770F RID: 30479 RVA: 0x0038B5AC File Offset: 0x003897AC
	public void PKDCOBJCNJO()
	{
		this.PPCEIMOLBKI.Clear();
	}

	// Token: 0x06007710 RID: 30480 RVA: 0x0038A351 File Offset: 0x00388551
	public TOD_Components HODDCHOAJLN()
	{
		return this.GFAIMKOJEEL;
	}

	// Token: 0x06007711 RID: 30481 RVA: 0x0038B61D File Offset: 0x0038981D
	public void CPJMHCHNMJB(GameObject APDJCCIGFAK)
	{
		if (!this.checkMsgListener(APDJCCIGFAK))
		{
			this.PPCEIMOLBKI.Add(APDJCCIGFAK);
		}
	}

	// Token: 0x06007712 RID: 30482 RVA: 0x0038A107 File Offset: 0x00388307
	public void EEMKAJNDMNK(DateTime KNKANCNCOMB)
	{
		this.deltaTime = KNKANCNCOMB - DateTime.Now;
	}

	// Token: 0x06007713 RID: 30483 RVA: 0x0038B648 File Offset: 0x00389848
	public void BCILAFPBDEO(HBPNMNGOFMA KADBECGIMPD)
	{
		this.currentWeather.LCEMPJFKBCD(KADBECGIMPD);
		if (this.NGJIKJJCPKL != null)
		{
			switch (Mathf.RoundToInt(this.currentWeather.cloudly))
			{
			case 0:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Custom;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 422f;
				break;
			case 1:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)8;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 636f;
				break;
			case 2:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Few;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 1762f;
				break;
			case 3:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)7;
				this.NGJIKJJCPKL.Weather = (JPFPFIFAEKJ)8;
				this.fogAddKf = 417f;
				break;
			case 4:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)8;
				this.NGJIKJJCPKL.Weather = (JPFPFIFAEKJ)7;
				this.fogAddKf = 321f;
				break;
			case 5:
				this.NGJIKJJCPKL.Clouds = (MCDCEIKHCND)7;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Fog;
				this.fogAddKf = 1914f;
				break;
			}
			if (this.currentWeather.rain > 874f)
			{
				this.fogAddKf = Mathf.Clamp(236f + this.fogAddKf * this.currentWeather.rain, 120f, 941f);
			}
			this.fogAddKf += this.LGGKFDFHAJB().Atmosphere.Fogginess * 969f;
		}
	}

	// Token: 0x06007714 RID: 30484 RVA: 0x0038AC22 File Offset: 0x00388E22
	private void GKMEJLHPPJL(int ODOKFLMKHBF)
	{
		this.BMCCGGKDMMD = ODOKFLMKHBF;
	}

	// Token: 0x06007715 RID: 30485 RVA: 0x00389BFD File Offset: 0x00387DFD
	public void ALMAOIMEHFM(TOD_Sky DCCPCBLODIG)
	{
		this.ONKMICIFOHJ = DCCPCBLODIG;
		if (this.ONKMICIFOHJ != null)
		{
			this.NGJIKJJCPKL = this.ONKMICIFOHJ.gameObject.GetComponent<TOD_Weather>();
		}
	}

	// Token: 0x06007716 RID: 30486 RVA: 0x0038A107 File Offset: 0x00388307
	public void DIAABOELCEI(DateTime KNKANCNCOMB)
	{
		this.deltaTime = KNKANCNCOMB - DateTime.Now;
	}

	// Token: 0x17000198 RID: 408
	// (get) Token: 0x06007717 RID: 30487 RVA: 0x0038ABE8 File Offset: 0x00388DE8
	public static TimeController IKGFHGKKCPG
	{
		get
		{
			TimeController.AGEHHNOKBGK == null;
			return TimeController.AGEHHNOKBGK;
		}
	}

	// Token: 0x06007718 RID: 30488 RVA: 0x0038A0F8 File Offset: 0x003882F8
	public void CFPMJNFNBBB(GameObject APDJCCIGFAK)
	{
		this.PPCEIMOLBKI.Remove(APDJCCIGFAK);
	}

	// Token: 0x06007719 RID: 30489 RVA: 0x0038ABE8 File Offset: 0x00388DE8
	public static TimeController KOJCECHBHLO()
	{
		TimeController.AGEHHNOKBGK == null;
		return TimeController.AGEHHNOKBGK;
	}

	// Token: 0x0600771A RID: 30490 RVA: 0x0038AC22 File Offset: 0x00388E22
	private void LOKGNDBGLBA(int ODOKFLMKHBF)
	{
		this.BMCCGGKDMMD = ODOKFLMKHBF;
	}

	// Token: 0x0600771B RID: 30491 RVA: 0x0038B7EC File Offset: 0x003899EC
	private void OCPCCPOFAJF(string IABKGMNJLJO, object DCCPCBLODIG)
	{
		foreach (GameObject gameObject in this.PPCEIMOLBKI)
		{
			gameObject.SendMessage(IABKGMNJLJO, DCCPCBLODIG, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x0600771C RID: 30492 RVA: 0x0038A11A File Offset: 0x0038831A
	public bool FJGDNAANFNO(GameObject APDJCCIGFAK)
	{
		return this.PPCEIMOLBKI.IndexOf(APDJCCIGFAK) >= 0;
	}

	// Token: 0x0600771D RID: 30493 RVA: 0x0038A544 File Offset: 0x00388744
	public TOD_Sky BEPJDFLBMHO()
	{
		return this.ONKMICIFOHJ;
	}

	// Token: 0x0600771E RID: 30494 RVA: 0x0038ABFB File Offset: 0x00388DFB
	public DateTime getServerTime()
	{
		return DateTime.Now + this.deltaTime;
	}

	// Token: 0x0600771F RID: 30495 RVA: 0x0038A522 File Offset: 0x00388722
	public bool MLEFFDKGIBE(GameObject APDJCCIGFAK)
	{
		return this.PPCEIMOLBKI.IndexOf(APDJCCIGFAK) >= 1;
	}

	// Token: 0x06007720 RID: 30496 RVA: 0x0038A0F8 File Offset: 0x003882F8
	public void DOGCPCFLNCD(GameObject APDJCCIGFAK)
	{
		this.PPCEIMOLBKI.Remove(APDJCCIGFAK);
	}

	// Token: 0x06007721 RID: 30497 RVA: 0x0038AC22 File Offset: 0x00388E22
	private void PGFLAFMOKCE(int ODOKFLMKHBF)
	{
		this.BMCCGGKDMMD = ODOKFLMKHBF;
	}

	// Token: 0x06007722 RID: 30498 RVA: 0x0038B840 File Offset: 0x00389A40
	public void BEHDPOGHAGH(GameObject APDJCCIGFAK)
	{
		if (!this.DGJEDOIBNGM(APDJCCIGFAK))
		{
			this.PPCEIMOLBKI.Add(APDJCCIGFAK);
		}
	}

	// Token: 0x06007723 RID: 30499 RVA: 0x0038AC22 File Offset: 0x00388E22
	private void IBDNJILCJBB(int ODOKFLMKHBF)
	{
		this.BMCCGGKDMMD = ODOKFLMKHBF;
	}

	// Token: 0x06007724 RID: 30500 RVA: 0x0038B858 File Offset: 0x00389A58
	private float BCAENBGNLFP()
	{
		DateTime dateTime = this.CKDKAOKOOEP();
		float num = this.daysOfRealDay * ((float)dateTime.Hour + (float)dateTime.Minute / 1571f + (float)dateTime.Second / 1002f + (float)dateTime.Millisecond / 881f);
		if (num > 1961f)
		{
			num -= (float)(Mathf.FloorToInt(num / 1704f) * -35);
		}
		return num;
	}

	// Token: 0x06007725 RID: 30501 RVA: 0x0038B8C5 File Offset: 0x00389AC5
	public float BACCNIMGPFE()
	{
		return this.BCAENBGNLFP() / 1981f;
	}

	// Token: 0x06007726 RID: 30502 RVA: 0x0038A0F8 File Offset: 0x003882F8
	public void delMsgListener(GameObject APDJCCIGFAK)
	{
		this.PPCEIMOLBKI.Remove(APDJCCIGFAK);
	}

	// Token: 0x06007727 RID: 30503 RVA: 0x0038AC1A File Offset: 0x00388E1A
	public int PIEJHAKEOJO()
	{
		return this.BMCCGGKDMMD;
	}

	// Token: 0x06007728 RID: 30504 RVA: 0x0038A544 File Offset: 0x00388744
	public TOD_Sky LGGKFDFHAJB()
	{
		return this.ONKMICIFOHJ;
	}

	// Token: 0x06007729 RID: 30505 RVA: 0x0038B8D4 File Offset: 0x00389AD4
	private void FMJPFPAADPH(string IABKGMNJLJO, object DCCPCBLODIG)
	{
		foreach (GameObject gameObject in this.PPCEIMOLBKI)
		{
			gameObject.SendMessage(IABKGMNJLJO, DCCPCBLODIG, SendMessageOptions.RequireReceiver);
		}
	}

	// Token: 0x0600772A RID: 30506 RVA: 0x0038B928 File Offset: 0x00389B28
	public float PGFOGGBILBB()
	{
		return this.OGIMHFCCIGH() / 1862f;
	}

	// Token: 0x0600772B RID: 30507 RVA: 0x0038B938 File Offset: 0x00389B38
	public void WeatherDoWork(HBPNMNGOFMA KADBECGIMPD)
	{
		this.currentWeather.ANGDIBBCJDA(KADBECGIMPD);
		if (this.NGJIKJJCPKL != null)
		{
			switch (Mathf.RoundToInt(this.currentWeather.cloudly))
			{
			case 0:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.None;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 0f;
				break;
			case 1:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Few;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 1f;
				break;
			case 2:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Scattered;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Clear;
				this.fogAddKf = 2f;
				break;
			case 3:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Broken;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Dust;
				this.fogAddKf = 3f;
				break;
			case 4:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Overcast;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Dust;
				this.fogAddKf = 4f;
				break;
			case 5:
				this.NGJIKJJCPKL.Clouds = MCDCEIKHCND.Overcast;
				this.NGJIKJJCPKL.Weather = JPFPFIFAEKJ.Storm;
				this.fogAddKf = 5f;
				break;
			}
			if (this.currentWeather.rain > 0.5f)
			{
				this.fogAddKf = Mathf.Clamp(3f + this.fogAddKf * this.currentWeather.rain, 3f, 15f);
			}
			this.fogAddKf += this.KKNHHMLCLOI.Atmosphere.Fogginess * 3f;
		}
	}

	// Token: 0x0600772C RID: 30508 RVA: 0x0038BADA File Offset: 0x00389CDA
	public float GNMCODGBBDP()
	{
		return this.BCAENBGNLFP() / 292f;
	}

	// Token: 0x0600772D RID: 30509 RVA: 0x0038B5AC File Offset: 0x003897AC
	public void IPLGOBNOHCK()
	{
		this.PPCEIMOLBKI.Clear();
	}

	// Token: 0x0600772E RID: 30510 RVA: 0x00389BD0 File Offset: 0x00387DD0
	public void NGPONFPIDKC(TOD_Components DCCPCBLODIG)
	{
		this.GFAIMKOJEEL = DCCPCBLODIG;
		if (this.ONKMICIFOHJ != null)
		{
			this.GFAIMKOJEEL = this.ONKMICIFOHJ.gameObject.GetComponent<TOD_Components>();
		}
	}

	// Token: 0x0600772F RID: 30511 RVA: 0x0038BAE8 File Offset: 0x00389CE8
	private void GKJNOMMAAPO()
	{
		if (TimeController.AGEHHNOKBGK != null)
		{
			UnityEngine.Object.Destroy(base.transform.gameObject);
			return;
		}
		TimeController.AGEHHNOKBGK = this;
		this.time = this.OGIMHFCCIGH();
		this.HHIAGEJKEJN = (int)this.time;
		this.KLOHNHLAAAA(base.gameObject);
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
	}

	// Token: 0x06007730 RID: 30512 RVA: 0x0038ABFB File Offset: 0x00388DFB
	public DateTime CPEPCFJBGJI()
	{
		return DateTime.Now + this.deltaTime;
	}

	// Token: 0x06007731 RID: 30513 RVA: 0x0038AC22 File Offset: 0x00388E22
	private void FOFCDAHOHGH(int ODOKFLMKHBF)
	{
		this.BMCCGGKDMMD = ODOKFLMKHBF;
	}

	// Token: 0x06007732 RID: 30514 RVA: 0x0038A0F8 File Offset: 0x003882F8
	public void ONBAEDGHKHG(GameObject APDJCCIGFAK)
	{
		this.PPCEIMOLBKI.Remove(APDJCCIGFAK);
	}

	// Token: 0x06007733 RID: 30515 RVA: 0x0038AC22 File Offset: 0x00388E22
	private void LKMMFBMPKBE(int ODOKFLMKHBF)
	{
		this.BMCCGGKDMMD = ODOKFLMKHBF;
	}

	// Token: 0x06007734 RID: 30516 RVA: 0x0038ABE8 File Offset: 0x00388DE8
	public static TimeController EPCKOOOGNGK()
	{
		TimeController.AGEHHNOKBGK == null;
		return TimeController.AGEHHNOKBGK;
	}

	// Token: 0x06007735 RID: 30517 RVA: 0x0038A544 File Offset: 0x00388744
	public TOD_Sky DMIFDFLMOME()
	{
		return this.ONKMICIFOHJ;
	}

	// Token: 0x06007736 RID: 30518 RVA: 0x0038A522 File Offset: 0x00388722
	public bool HGNMKFGHBGF(GameObject APDJCCIGFAK)
	{
		return this.PPCEIMOLBKI.IndexOf(APDJCCIGFAK) >= 1;
	}

	// Token: 0x0400111A RID: 4378
	public AnimationCurve fogHgt;

	// Token: 0x0400111B RID: 4379
	public int currentLUTBank;

	// Token: 0x0400111C RID: 4380
	public LUTBank[] lutBank;

	// Token: 0x0400111D RID: 4381
	public LayerMask scaleDistanceMask;

	// Token: 0x0400111E RID: 4382
	public Sunshine shine;

	// Token: 0x0400111F RID: 4383
	public AmplifyColorEffect amplyfy;

	// Token: 0x04001120 RID: 4384
	public float baseShadowDistance;

	// Token: 0x04001121 RID: 4385
	public Color waterPoplColor;

	// Token: 0x04001122 RID: 4386
	public bool isActive = true;

	// Token: 0x04001123 RID: 4387
	public float daysOfRealDay = 24f;

	// Token: 0x04001124 RID: 4388
	public float time;

	// Token: 0x04001125 RID: 4389
	private int HHIAGEJKEJN = -1;

	// Token: 0x04001126 RID: 4390
	private int BMCCGGKDMMD = -1;

	// Token: 0x04001127 RID: 4391
	public float fogKf = 1f;

	// Token: 0x04001128 RID: 4392
	public float fogAddKf;

	// Token: 0x04001129 RID: 4393
	public float lightKF = 1f;

	// Token: 0x0400112A RID: 4394
	public Color correctorColor = Color.white;

	// Token: 0x0400112B RID: 4395
	public Color currentAmbientColor = Color.black;

	// Token: 0x0400112C RID: 4396
	public float currFogIntens;

	// Token: 0x0400112D RID: 4397
	public float currentShadowProc;

	// Token: 0x0400112E RID: 4398
	public float currentWaterColorSlider;

	// Token: 0x0400112F RID: 4399
	public TimeController.Weather currentWeather;

	// Token: 0x04001130 RID: 4400
	public Material sharedAquaMaterial;

	// Token: 0x04001131 RID: 4401
	private readonly List<GameObject> PPCEIMOLBKI = new List<GameObject>();

	// Token: 0x04001132 RID: 4402
	private static TimeController AGEHHNOKBGK;

	// Token: 0x04001133 RID: 4403
	public float[] shadowProc = new float[24];

	// Token: 0x04001134 RID: 4404
	public float[] fogi = new float[24];

	// Token: 0x04001135 RID: 4405
	public Color[] AmbientColor = new Color[24];

	// Token: 0x04001136 RID: 4406
	public float[] ambientLight = new float[24];

	// Token: 0x04001137 RID: 4407
	public Vector4[] skyParams = new Vector4[24];

	// Token: 0x04001138 RID: 4408
	public float[] waterLightWrap = new float[24];

	// Token: 0x04001139 RID: 4409
	private TOD_Sky ONKMICIFOHJ;

	// Token: 0x0400113A RID: 4410
	private TOD_Weather NGJIKJJCPKL;

	// Token: 0x0400113B RID: 4411
	private TOD_Components GFAIMKOJEEL;

	// Token: 0x0400113C RID: 4412
	public TimeSpan deltaTime;

	// Token: 0x0400113D RID: 4413
	private float NKKFCKNOCDC;

	// Token: 0x0400113E RID: 4414
	private float OFFOHGOBKDD;

	// Token: 0x02000200 RID: 512
	[Serializable]
	public struct Weather
	{
		// Token: 0x06007737 RID: 30519 RVA: 0x0038BB4C File Offset: 0x00389D4C
		public void ANGDIBBCJDA(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.FFDPCEAFGNF();
			this.fog = KADBECGIMPD.FFDPCEAFGNF();
			this.rain = KADBECGIMPD.FFDPCEAFGNF();
			this.snaige = KADBECGIMPD.FFDPCEAFGNF();
			this.grom = KADBECGIMPD.FFDPCEAFGNF();
			if (Application.isEditor)
			{
				string.Format("**** Weather cloudly={0} fog={1} rain={2} snaige={3} grom={4}", new object[]
				{
					this.cloudly,
					this.fog,
					this.rain,
					this.snaige,
					this.grom
				});
			}
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x0038BBF4 File Offset: 0x00389DF4
		public void JKDOIMHPBJG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.AIDAGFNHNHE();
			this.fog = KADBECGIMPD.MOBPFEEAMKD();
			this.rain = KADBECGIMPD.DNGDPHIHLBG();
			this.snaige = KADBECGIMPD.AIDAGFNHNHE();
			this.grom = KADBECGIMPD.BNDHIBEOKML();
			if (Application.isEditor)
			{
				string format = "wpn/";
				object[] array = new object[1];
				array[1] = this.cloudly;
				array[0] = this.fog;
				array[5] = this.rain;
				array[5] = this.snaige;
				array[1] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x0038BC9C File Offset: 0x00389E9C
		public void HKDGKCPGLHE(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.FFDPCEAFGNF();
			this.fog = KADBECGIMPD.BIMMPENHGMD();
			this.rain = KADBECGIMPD.AILCEJFAMGN();
			this.snaige = KADBECGIMPD.BIMMPENHGMD();
			this.grom = KADBECGIMPD.CNNEPCOAMJK();
			if (Application.isEditor)
			{
				string format = "Node transform is null in FBIK chain.";
				object[] array = new object[4];
				array[1] = this.cloudly;
				array[0] = this.fog;
				array[2] = this.rain;
				array[1] = this.snaige;
				array[2] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x0038BD44 File Offset: 0x00389F44
		public void GHKLHBGPIGI(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.CGJIINADKNH();
			this.fog = KADBECGIMPD.DNGDPHIHLBG();
			this.rain = KADBECGIMPD.FFDPCEAFGNF();
			this.snaige = KADBECGIMPD.DNGDPHIHLBG();
			this.grom = KADBECGIMPD.CNNEPCOAMJK();
			if (Application.isEditor)
			{
				string format = "MotorbikeLassoLeft";
				object[] array = new object[6];
				array[1] = this.cloudly;
				array[1] = this.fog;
				array[1] = this.rain;
				array[6] = this.snaige;
				array[1] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x0038BDEC File Offset: 0x00389FEC
		public void JEMLGIEAMEJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.DNGDPHIHLBG();
			this.fog = KADBECGIMPD.CGJIINADKNH();
			this.rain = KADBECGIMPD.MOBPFEEAMKD();
			this.snaige = KADBECGIMPD.BNDHIBEOKML();
			this.grom = KADBECGIMPD.BNDHIBEOKML();
			if (Application.isEditor)
			{
				string format = "Проверьте правильность логина и пароля!";
				object[] array = new object[7];
				array[0] = this.cloudly;
				array[0] = this.fog;
				array[1] = this.rain;
				array[4] = this.snaige;
				array[0] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x0038BE94 File Offset: 0x0038A094
		public void FJCONDOLDAP(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.BNDHIBEOKML();
			this.fog = KADBECGIMPD.AIDAGFNHNHE();
			this.rain = KADBECGIMPD.BIMMPENHGMD();
			this.snaige = KADBECGIMPD.BNDHIBEOKML();
			this.grom = KADBECGIMPD.MOBPFEEAMKD();
			if (Application.isEditor)
			{
				string format = "OfficeSittingReadingLeanBack";
				object[] array = new object[1];
				array[1] = this.cloudly;
				array[1] = this.fog;
				array[1] = this.rain;
				array[0] = this.snaige;
				array[6] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x0038BF3C File Offset: 0x0038A13C
		public void HJHAOAFLBOK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.AIDAGFNHNHE();
			this.fog = KADBECGIMPD.FFDPCEAFGNF();
			this.rain = KADBECGIMPD.DNGDPHIHLBG();
			this.snaige = KADBECGIMPD.FFDPCEAFGNF();
			this.grom = KADBECGIMPD.BNDHIBEOKML();
			if (Application.isEditor)
			{
				string format = "wpn_add/base";
				object[] array = new object[2];
				array[0] = this.cloudly;
				array[0] = this.fog;
				array[8] = this.rain;
				array[2] = this.snaige;
				array[0] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x0038BFE4 File Offset: 0x0038A1E4
		public void LBOCNHCCENN(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.AILCEJFAMGN();
			this.fog = KADBECGIMPD.AILCEJFAMGN();
			this.rain = KADBECGIMPD.CGJIINADKNH();
			this.snaige = KADBECGIMPD.FFDPCEAFGNF();
			this.grom = KADBECGIMPD.CGJIINADKNH();
			if (Application.isEditor)
			{
				string format = "buykey";
				object[] array = new object[3];
				array[1] = this.cloudly;
				array[0] = this.fog;
				array[1] = this.rain;
				array[5] = this.snaige;
				array[1] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x0038C08C File Offset: 0x0038A28C
		public void HNBMOPBBLOD(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.AIDAGFNHNHE();
			this.fog = KADBECGIMPD.BNDHIBEOKML();
			this.rain = KADBECGIMPD.AILCEJFAMGN();
			this.snaige = KADBECGIMPD.MOBPFEEAMKD();
			this.grom = KADBECGIMPD.DNGDPHIHLBG();
			if (Application.isEditor)
			{
				string format = "{0}/{1}/{2}";
				object[] array = new object[5];
				array[1] = this.cloudly;
				array[0] = this.fog;
				array[7] = this.rain;
				array[6] = this.snaige;
				array[3] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x0038C134 File Offset: 0x0038A334
		public void CAPPGIKOHHE(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.DNGDPHIHLBG();
			this.fog = KADBECGIMPD.FFDPCEAFGNF();
			this.rain = KADBECGIMPD.MOBPFEEAMKD();
			this.snaige = KADBECGIMPD.DNGDPHIHLBG();
			this.grom = KADBECGIMPD.BIMMPENHGMD();
			if (Application.isEditor)
			{
				string format = "[Attachments] Failed to find ProBuilder object on the attachments object '{0}'.";
				object[] array = new object[1];
				array[1] = this.cloudly;
				array[0] = this.fog;
				array[4] = this.rain;
				array[8] = this.snaige;
				array[1] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x0038C1DC File Offset: 0x0038A3DC
		public void OJGJPHCPDOB(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.BNDHIBEOKML();
			this.fog = KADBECGIMPD.DNGDPHIHLBG();
			this.rain = KADBECGIMPD.BIMMPENHGMD();
			this.snaige = KADBECGIMPD.MOBPFEEAMKD();
			this.grom = KADBECGIMPD.AILCEJFAMGN();
			if (Application.isEditor)
			{
				string format = "implevel";
				object[] array = new object[4];
				array[1] = this.cloudly;
				array[0] = this.fog;
				array[0] = this.rain;
				array[1] = this.snaige;
				array[0] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x0038C284 File Offset: 0x0038A484
		public void LCEMPJFKBCD(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.FFDPCEAFGNF();
			this.fog = KADBECGIMPD.ECJLJGDNFMN();
			this.rain = KADBECGIMPD.AIDAGFNHNHE();
			this.snaige = KADBECGIMPD.MOBPFEEAMKD();
			this.grom = KADBECGIMPD.CNNEPCOAMJK();
			if (Application.isEditor)
			{
				string format = "wpn_rod4";
				object[] array = new object[0];
				array[0] = this.cloudly;
				array[0] = this.fog;
				array[8] = this.rain;
				array[4] = this.snaige;
				array[6] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x0038C32C File Offset: 0x0038A52C
		public void NNBDPEIGJCM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.FFDPCEAFGNF();
			this.fog = KADBECGIMPD.AIDAGFNHNHE();
			this.rain = KADBECGIMPD.MOBPFEEAMKD();
			this.snaige = KADBECGIMPD.CNNEPCOAMJK();
			this.grom = KADBECGIMPD.CGJIINADKNH();
			if (Application.isEditor)
			{
				string format = "_DistAmount";
				object[] array = new object[4];
				array[0] = this.cloudly;
				array[1] = this.fog;
				array[5] = this.rain;
				array[0] = this.snaige;
				array[7] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x0038C3D4 File Offset: 0x0038A5D4
		public void KCAPAIEOJKK(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.AILCEJFAMGN();
			this.fog = KADBECGIMPD.FFDPCEAFGNF();
			this.rain = KADBECGIMPD.AILCEJFAMGN();
			this.snaige = KADBECGIMPD.DNGDPHIHLBG();
			this.grom = KADBECGIMPD.AILCEJFAMGN();
			if (Application.isEditor)
			{
				string format = "";
				object[] array = new object[6];
				array[0] = this.cloudly;
				array[0] = this.fog;
				array[2] = this.rain;
				array[3] = this.snaige;
				array[2] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x0038C47C File Offset: 0x0038A67C
		public void BOHADFDBHNO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.MOBPFEEAMKD();
			this.fog = KADBECGIMPD.BIMMPENHGMD();
			this.rain = KADBECGIMPD.AILCEJFAMGN();
			this.snaige = KADBECGIMPD.MOBPFEEAMKD();
			this.grom = KADBECGIMPD.AILCEJFAMGN();
			if (Application.isEditor)
			{
				string format = "KarateGreet";
				object[] array = new object[]
				{
					null,
					this.cloudly
				};
				array[0] = this.fog;
				array[2] = this.rain;
				array[6] = this.snaige;
				array[1] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x0038C524 File Offset: 0x0038A724
		public void LGBLFGJANMM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.CNNEPCOAMJK();
			this.fog = KADBECGIMPD.CGJIINADKNH();
			this.rain = KADBECGIMPD.CGJIINADKNH();
			this.snaige = KADBECGIMPD.CNNEPCOAMJK();
			this.grom = KADBECGIMPD.MOBPFEEAMKD();
			if (Application.isEditor)
			{
				string format = "MotorbikeSuperman";
				object[] array = new object[7];
				array[0] = this.cloudly;
				array[0] = this.fog;
				array[4] = this.rain;
				array[7] = this.snaige;
				array[8] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x0038C5CC File Offset: 0x0038A7CC
		public void MNKNCBDOKAO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.FFDPCEAFGNF();
			this.fog = KADBECGIMPD.ECJLJGDNFMN();
			this.rain = KADBECGIMPD.AILCEJFAMGN();
			this.snaige = KADBECGIMPD.BNDHIBEOKML();
			this.grom = KADBECGIMPD.BNDHIBEOKML();
			if (Application.isEditor)
			{
				string format = "UNIQUE_SHADOW_LIGHT_COOKIE";
				object[] array = new object[1];
				array[1] = this.cloudly;
				array[1] = this.fog;
				array[3] = this.rain;
				array[1] = this.snaige;
				array[4] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x0038C674 File Offset: 0x0038A874
		public void JHCCEELMDGJ(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.CNNEPCOAMJK();
			this.fog = KADBECGIMPD.ECJLJGDNFMN();
			this.rain = KADBECGIMPD.MOBPFEEAMKD();
			this.snaige = KADBECGIMPD.AILCEJFAMGN();
			this.grom = KADBECGIMPD.CGJIINADKNH();
			if (Application.isEditor)
			{
				string format = "crft_krit";
				object[] array = new object[8];
				array[0] = this.cloudly;
				array[0] = this.fog;
				array[6] = this.rain;
				array[8] = this.snaige;
				array[8] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x0038C71C File Offset: 0x0038A91C
		public void LCNDBJIFKCB(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.CNNEPCOAMJK();
			this.fog = KADBECGIMPD.BIMMPENHGMD();
			this.rain = KADBECGIMPD.AIDAGFNHNHE();
			this.snaige = KADBECGIMPD.ECJLJGDNFMN();
			this.grom = KADBECGIMPD.BNDHIBEOKML();
			if (Application.isEditor)
			{
				string format = "";
				object[] array = new object[0];
				array[0] = this.cloudly;
				array[0] = this.fog;
				array[6] = this.rain;
				array[4] = this.snaige;
				array[2] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x0038C7C4 File Offset: 0x0038A9C4
		public void JPKKDGLIDLL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.MOBPFEEAMKD();
			this.fog = KADBECGIMPD.CGJIINADKNH();
			this.rain = KADBECGIMPD.BNDHIBEOKML();
			this.snaige = KADBECGIMPD.AIDAGFNHNHE();
			this.grom = KADBECGIMPD.AILCEJFAMGN();
			if (Application.isEditor)
			{
				string format = "WeaponStrafeRunLeft";
				object[] array = new object[8];
				array[1] = this.cloudly;
				array[1] = this.fog;
				array[0] = this.rain;
				array[6] = this.snaige;
				array[5] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x0038C86C File Offset: 0x0038AA6C
		public void GGAKBOILJFP(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.DNGDPHIHLBG();
			this.fog = KADBECGIMPD.AILCEJFAMGN();
			this.rain = KADBECGIMPD.CGJIINADKNH();
			this.snaige = KADBECGIMPD.MOBPFEEAMKD();
			this.grom = KADBECGIMPD.DNGDPHIHLBG();
			if (Application.isEditor)
			{
				string format = "No Cell wpn.cell=";
				object[] array = new object[5];
				array[0] = this.cloudly;
				array[1] = this.fog;
				array[6] = this.rain;
				array[5] = this.snaige;
				array[1] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x0038C914 File Offset: 0x0038AB14
		public void JKGCOOEMHLG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.BNDHIBEOKML();
			this.fog = KADBECGIMPD.ECJLJGDNFMN();
			this.rain = KADBECGIMPD.BIMMPENHGMD();
			this.snaige = KADBECGIMPD.MOBPFEEAMKD();
			this.grom = KADBECGIMPD.ECJLJGDNFMN();
			if (Application.isEditor)
			{
				string format = "stretchWidth";
				object[] array = new object[7];
				array[1] = this.cloudly;
				array[0] = this.fog;
				array[0] = this.rain;
				array[0] = this.snaige;
				array[0] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x0038C9BC File Offset: 0x0038ABBC
		public void LMPMPIGLBDA(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.ECJLJGDNFMN();
			this.fog = KADBECGIMPD.MOBPFEEAMKD();
			this.rain = KADBECGIMPD.AIDAGFNHNHE();
			this.snaige = KADBECGIMPD.CGJIINADKNH();
			this.grom = KADBECGIMPD.CGJIINADKNH();
			if (Application.isEditor)
			{
				string format = "_NoiseAmount";
				object[] array = new object[0];
				array[0] = this.cloudly;
				array[1] = this.fog;
				array[4] = this.rain;
				array[5] = this.snaige;
				array[6] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x0038CA64 File Offset: 0x0038AC64
		public void IDALPHPGGID(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.DNGDPHIHLBG();
			this.fog = KADBECGIMPD.CNNEPCOAMJK();
			this.rain = KADBECGIMPD.CNNEPCOAMJK();
			this.snaige = KADBECGIMPD.DNGDPHIHLBG();
			this.grom = KADBECGIMPD.BNDHIBEOKML();
			if (Application.isEditor)
			{
				string format = "isFishGet";
				object[] array = new object[7];
				array[0] = this.cloudly;
				array[1] = this.fog;
				array[3] = this.rain;
				array[6] = this.snaige;
				array[8] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x0038CB0C File Offset: 0x0038AD0C
		public void LEEKMGLKNCM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.CNNEPCOAMJK();
			this.fog = KADBECGIMPD.CNNEPCOAMJK();
			this.rain = KADBECGIMPD.FFDPCEAFGNF();
			this.snaige = KADBECGIMPD.ECJLJGDNFMN();
			this.grom = KADBECGIMPD.FFDPCEAFGNF();
			if (Application.isEditor)
			{
				string format = "Backward Sitting Cheer";
				object[] array = new object[]
				{
					this.cloudly,
					this.fog
				};
				array[1] = this.rain;
				array[4] = this.snaige;
				array[5] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x0038CBB4 File Offset: 0x0038ADB4
		public void EFPIHGKEIAG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.CNNEPCOAMJK();
			this.fog = KADBECGIMPD.BIMMPENHGMD();
			this.rain = KADBECGIMPD.BIMMPENHGMD();
			this.snaige = KADBECGIMPD.DNGDPHIHLBG();
			this.grom = KADBECGIMPD.AIDAGFNHNHE();
			if (Application.isEditor)
			{
				string format = "crunch.ogg";
				object[] array = new object[4];
				array[1] = this.cloudly;
				array[0] = this.fog;
				array[4] = this.rain;
				array[6] = this.snaige;
				array[2] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x0038CC5C File Offset: 0x0038AE5C
		public void DNNHPJOFKNM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.ECJLJGDNFMN();
			this.fog = KADBECGIMPD.AILCEJFAMGN();
			this.rain = KADBECGIMPD.ECJLJGDNFMN();
			this.snaige = KADBECGIMPD.DNGDPHIHLBG();
			this.grom = KADBECGIMPD.AILCEJFAMGN();
			if (Application.isEditor)
			{
				string format = " ";
				object[] array = new object[0];
				array[0] = this.cloudly;
				array[0] = this.fog;
				array[5] = this.rain;
				array[3] = this.snaige;
				array[0] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x0038CD04 File Offset: 0x0038AF04
		public void GEICFPNKHMH(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.AIDAGFNHNHE();
			this.fog = KADBECGIMPD.BNDHIBEOKML();
			this.rain = KADBECGIMPD.ECJLJGDNFMN();
			this.snaige = KADBECGIMPD.MOBPFEEAMKD();
			this.grom = KADBECGIMPD.MOBPFEEAMKD();
			if (Application.isEditor)
			{
				string format = "";
				object[] array = new object[3];
				array[1] = this.cloudly;
				array[0] = this.fog;
				array[4] = this.rain;
				array[5] = this.snaige;
				array[1] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x0038CDAC File Offset: 0x0038AFAC
		public void JLOEBEENKNF(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.FFDPCEAFGNF();
			this.fog = KADBECGIMPD.CNNEPCOAMJK();
			this.rain = KADBECGIMPD.MOBPFEEAMKD();
			this.snaige = KADBECGIMPD.CNNEPCOAMJK();
			this.grom = KADBECGIMPD.ECJLJGDNFMN();
			if (Application.isEditor)
			{
				string format = "PrimaryCausticsProjector";
				object[] array = new object[0];
				array[0] = this.cloudly;
				array[1] = this.fog;
				array[8] = this.rain;
				array[4] = this.snaige;
				array[5] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x0038CE54 File Offset: 0x0038B054
		public void KPHIPNIBCGO(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.AILCEJFAMGN();
			this.fog = KADBECGIMPD.BNDHIBEOKML();
			this.rain = KADBECGIMPD.AILCEJFAMGN();
			this.snaige = KADBECGIMPD.MOBPFEEAMKD();
			this.grom = KADBECGIMPD.AILCEJFAMGN();
			if (Application.isEditor)
			{
				string format = "wpn_eat6";
				object[] array = new object[8];
				array[0] = this.cloudly;
				array[0] = this.fog;
				array[3] = this.rain;
				array[2] = this.snaige;
				array[6] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x0038CEFC File Offset: 0x0038B0FC
		public void IMLBJHCMLHL(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.DNGDPHIHLBG();
			this.fog = KADBECGIMPD.FFDPCEAFGNF();
			this.rain = KADBECGIMPD.ECJLJGDNFMN();
			this.snaige = KADBECGIMPD.BNDHIBEOKML();
			this.grom = KADBECGIMPD.CGJIINADKNH();
			if (Application.isEditor)
			{
				string.Format("Wall hack Detected!", new object[]
				{
					this.cloudly,
					this.fog,
					null,
					this.rain,
					null,
					this.snaige,
					this.grom
				});
			}
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x0038CFA4 File Offset: 0x0038B1A4
		public void PHAGGABBPBM(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.ECJLJGDNFMN();
			this.fog = KADBECGIMPD.FFDPCEAFGNF();
			this.rain = KADBECGIMPD.CNNEPCOAMJK();
			this.snaige = KADBECGIMPD.CGJIINADKNH();
			this.grom = KADBECGIMPD.ECJLJGDNFMN();
			if (Application.isEditor)
			{
				string format = "400000";
				object[] array = new object[8];
				array[1] = this.cloudly;
				array[0] = this.fog;
				array[4] = this.rain;
				array[3] = this.snaige;
				array[4] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x0038D04C File Offset: 0x0038B24C
		public void IFFOILFPPKG(HBPNMNGOFMA KADBECGIMPD)
		{
			this.cloudly = KADBECGIMPD.MOBPFEEAMKD();
			this.fog = KADBECGIMPD.BIMMPENHGMD();
			this.rain = KADBECGIMPD.AILCEJFAMGN();
			this.snaige = KADBECGIMPD.AIDAGFNHNHE();
			this.grom = KADBECGIMPD.AIDAGFNHNHE();
			if (Application.isEditor)
			{
				string format = "WizardPowerUp";
				object[] array = new object[8];
				array[1] = this.cloudly;
				array[1] = this.fog;
				array[1] = this.rain;
				array[6] = this.snaige;
				array[8] = this.grom;
				string.Format(format, array);
			}
		}

		// Token: 0x0400113F RID: 4415
		public float cloudly;

		// Token: 0x04001140 RID: 4416
		public float fog;

		// Token: 0x04001141 RID: 4417
		public float rain;

		// Token: 0x04001142 RID: 4418
		public float snaige;

		// Token: 0x04001143 RID: 4419
		public float grom;
	}
}
