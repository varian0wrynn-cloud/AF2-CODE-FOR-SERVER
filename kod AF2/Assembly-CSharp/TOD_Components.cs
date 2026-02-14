using System;
using UnityEngine;

// Token: 0x020000BF RID: 191
[ExecuteInEditMode]
public class TOD_Components : MonoBehaviour
{
	// Token: 0x0600283B RID: 10299 RVA: 0x0011A538 File Offset: 0x00118738
	public void PPAPDGACKGE()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("GiantGrabIdle2");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("BowInstant2");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("SoccerPassHeavy");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("demoVector3");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("PodsekType");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("WizardEyeBeam");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError(" ");
		}
		if (!this.Billboards)
		{
			Debug.LogError("rod_inf2");
		}
	}

	// Token: 0x0600283C RID: 10300 RVA: 0x0011A80C File Offset: 0x00118A0C
	public void FEMHHBLLJHK()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("FS");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("_WrinkleMapBumpScales");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("error");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("fshop_msg1");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("_ALPHATEST_ON");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("codepage");
		}
		if (!this.Billboards)
		{
			Debug.LogError("");
		}
	}

	// Token: 0x0600283D RID: 10301 RVA: 0x0011AAE0 File Offset: 0x00118CE0
	public void Initialize()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Space reference not set.");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Atmosphere reference not set.");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Clear reference not set.");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Clouds reference not set.");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("Projector reference not set.");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("Light reference not set.");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Sun reference not set.");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Moon reference not set.");
		}
		if (!this.Billboards)
		{
			Debug.LogError("Billboards reference not set.");
		}
	}

	// Token: 0x0600283E RID: 10302 RVA: 0x0011ADB4 File Offset: 0x00118FB4
	public void LECGEEMCOLC()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("_WaterLevel");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Aim Transform unassigned in Aim IK solver. Please Assign a Transform (lineal descendant to the last bone in the spine) that you want to be aimed at IKPosition");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Roller Blade Turn Right");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("_Newitem.wav");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("StartPhysPoint");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("Vertical");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError(" ");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("OfficeSitting1LegStraight");
		}
		if (!this.Billboards)
		{
			Debug.LogError("invn_rec12");
		}
	}

	// Token: 0x0600283F RID: 10303 RVA: 0x0011B088 File Offset: 0x00119288
	public void LIENFFAPLAB()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Idle Button Press");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Missing shader for image effect {0}");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("_BlurredColor");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("MotorbikeTurnRight");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("Button Left Hand");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("RunJump");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("UserOut");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("bases/base_{0}");
		}
		if (!this.Billboards)
		{
			Debug.LogError("** Panel save position");
		}
	}

	// Token: 0x06002841 RID: 10305 RVA: 0x0011B35C File Offset: 0x0011955C
	public void IIOIFCCMEPG()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("<color='#20a000'> Требований нет </color>");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("id");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("SuicideHeadShot");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("IdleFly");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("crft_from");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("_Offsets");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("</color></i>");
		}
		if (!this.Billboards)
		{
			Debug.LogError("GiantGrabIdle2");
		}
	}

	// Token: 0x06002842 RID: 10306 RVA: 0x0011B630 File Offset: 0x00119830
	public void FKKIAGGFNAP()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("SoccerKeeperDiveStrafeCloseLeft");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Mouse ScrollWheel");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("inv_bonus");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("sunshine_ShadowCoordDepthStart");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("HeelClick");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Roller Blade Stop");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("_WrinkleOcclusionStrengths");
		}
		if (!this.Billboards)
		{
			Debug.LogError("Roar");
		}
	}

	// Token: 0x06002843 RID: 10307 RVA: 0x0011B904 File Offset: 0x00119B04
	public void MAHDPBCHGBB()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("cntx_use");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("WeaponStrafeRunLeft");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("{{ {{{0}:{1}}}, {{{2}:{3}}} }}");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("MotorbikeLassoFwd");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("_TempRT");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("Sitting Reading Page Flip");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Mirror Refl Camera id");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("ResetObject");
		}
		if (!this.Billboards)
		{
			Debug.LogError("");
		}
	}

	// Token: 0x06002844 RID: 10308 RVA: 0x0011BBD8 File Offset: 0x00119DD8
	public void LLDJDJDGNNJ()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("CrouchStrafeLeft");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("_TrStartYou.ogg");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Giant3HitCombo2");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("+ ");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("********* End INSTANIATE Level  instLevelTime=");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("value");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("<[^>]+>");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("");
		}
		if (!this.Billboards)
		{
			Debug.LogError("KatanaReady");
		}
	}

	// Token: 0x06002845 RID: 10309 RVA: 0x0011BEAC File Offset: 0x0011A0AC
	public void FMHAMHGOFLH()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Below you can try to cheat both regular PlayerPrefs and secure ObscuredPrefs:");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("IdleReady");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("UV0");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("vp");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("usr_inf_a3");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("FOG_EXP2");
		}
		if (!this.Billboards)
		{
			Debug.LogError("[fish]");
		}
	}

	// Token: 0x06002846 RID: 10310 RVA: 0x0011C180 File Offset: 0x0011A380
	public void FPGGMEKHGCH()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("_Threshold");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("cht_msg3");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("BowFire2");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("adjust");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("Eyes");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("PIN");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("#000040");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("wpn_add/base");
		}
		if (!this.Billboards)
		{
			Debug.LogError("[Z]");
		}
	}

	// Token: 0x06002847 RID: 10311 RVA: 0x0011C454 File Offset: 0x0011A654
	public void JINDMFBKGKH()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Transform is null.");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("IdleStrafeRight");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Bone");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("offsets");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("|");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("_FogSkyHaze");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("OneHandSwordBackSwing");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k.html");
		}
		if (!this.Billboards)
		{
			Debug.LogError("WeaponInstant");
		}
	}

	// Token: 0x06002848 RID: 10312 RVA: 0x0011C728 File Offset: 0x0011A928
	public void JKBJKHEOCCD()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("post_msg1");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("\n");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Giant3HitCombo2");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Horizontal");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("CardPlayerIdle");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("mastername");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Отпущена рыба");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Detects common types of wall hack cheating: walking through the walls (Rigidbody and CharacterController modules), shooting through the walls (Raycast module), looking through the walls (Wireframe module).");
		}
		if (!this.Billboards)
		{
			Debug.LogError("isMutant");
		}
	}

	// Token: 0x06002849 RID: 10313 RVA: 0x0011C9FC File Offset: 0x0011ABFC
	public void IANOPLMBIPO()
	{
		this.JDGNBEHCGAL = base.GetComponent<Transform>();
		this.JEDHJJMMKPH = base.GetComponent<TOD_Sky>();
		this.JEJLCMAKKCK = base.GetComponent<TOD_Animation>();
		this.EJHFCHDDPAJ = base.GetComponent<TOD_Time>();
		this.PHLAGOLHIMB = base.GetComponent<TOD_Weather>();
		if (this.Space)
		{
			this.CAJGGFMKFCM = this.Space.GetComponent<Transform>();
			this.MJFKDCPMDOF = this.Space.GetComponent<Renderer>();
			this.CHKCGPGIOPB = this.MJFKDCPMDOF.sharedMaterial;
			this.DJFNJPHBAFO = this.Space.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("Failed parsing atlas group.  Setting to group 0");
		}
		if (this.Atmosphere)
		{
			this.JFBEDPHIDII = this.Atmosphere.GetComponent<Renderer>();
			this.FJKDDLPBBHD = this.JFBEDPHIDII.sharedMaterial;
			this.OIDGFIJEHKM = this.Atmosphere.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("_ReflectionBufferSize");
		}
		if (this.Clear)
		{
			this.NPGMCIEICBJ = this.Clear.GetComponent<Renderer>();
			this.FMBBCDILBLE = this.NPGMCIEICBJ.sharedMaterial;
			this.MBNJEJNIKDI = this.Clear.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("gi_nl0");
		}
		if (this.Clouds)
		{
			this.JHKOHMHKBOK = this.Clouds.GetComponent<Renderer>();
			this.ENLCHIIOIBB = this.JHKOHMHKBOK.sharedMaterial;
			this.DDJNNFJINJE = this.Clouds.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("modelid");
		}
		if (this.Projector)
		{
			this.AIDEHKOPKHN = this.Projector.GetComponent<Projector>();
			this.HMFIBKJKOKK = this.AIDEHKOPKHN.material;
		}
		else
		{
			Debug.LogError("Flashlight");
		}
		if (this.Light)
		{
			this.LFLHCKPLMCC = this.Light.GetComponent<Transform>();
			this.JAFNHAHJLOH = this.Light.GetComponent<Light>();
		}
		else
		{
			Debug.LogError("[ACTk] <b>[ ObscuredString test ]</b>");
		}
		if (this.Sun)
		{
			this.KPHBJOLMLBB = this.Sun.GetComponent<Transform>();
			this.HCCAOCECMEP = this.Sun.GetComponent<Renderer>();
			this.FKNIPFONANF = this.HCCAOCECMEP.sharedMaterial;
			this.HNCNKCJKFJO = this.Sun.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("lastConfirmLic");
		}
		if (this.Moon)
		{
			this.HHGGPMABOPA = this.Moon.GetComponent<Transform>();
			this.AMLLDIODOLD = this.Moon.GetComponent<Renderer>();
			this.OHAADBJGPHL = this.AMLLDIODOLD.sharedMaterial;
			this.LPNKELBJFHK = this.Moon.GetComponent<MeshFilter>();
		}
		else
		{
			Debug.LogError("offsets");
		}
		if (!this.Billboards)
		{
			Debug.LogError("StartPhysPoint");
		}
	}

	// Token: 0x04000491 RID: 1169
	public GameObject Sun;

	// Token: 0x04000492 RID: 1170
	public GameObject Moon;

	// Token: 0x04000493 RID: 1171
	public GameObject Atmosphere;

	// Token: 0x04000494 RID: 1172
	public GameObject Clear;

	// Token: 0x04000495 RID: 1173
	public GameObject Clouds;

	// Token: 0x04000496 RID: 1174
	public GameObject Space;

	// Token: 0x04000497 RID: 1175
	public GameObject DaySpace;

	// Token: 0x04000498 RID: 1176
	public GameObject Light;

	// Token: 0x04000499 RID: 1177
	public GameObject Projector;

	// Token: 0x0400049A RID: 1178
	public GameObject Billboards;

	// Token: 0x0400049B RID: 1179
	internal Transform JDGNBEHCGAL;

	// Token: 0x0400049C RID: 1180
	internal Transform KPHBJOLMLBB;

	// Token: 0x0400049D RID: 1181
	internal Transform HHGGPMABOPA;

	// Token: 0x0400049E RID: 1182
	internal Transform LFLHCKPLMCC;

	// Token: 0x0400049F RID: 1183
	internal Transform CAJGGFMKFCM;

	// Token: 0x040004A0 RID: 1184
	internal Renderer MJFKDCPMDOF;

	// Token: 0x040004A1 RID: 1185
	internal Renderer JFBEDPHIDII;

	// Token: 0x040004A2 RID: 1186
	internal Renderer NPGMCIEICBJ;

	// Token: 0x040004A3 RID: 1187
	internal Renderer JHKOHMHKBOK;

	// Token: 0x040004A4 RID: 1188
	internal Renderer HCCAOCECMEP;

	// Token: 0x040004A5 RID: 1189
	internal Renderer AMLLDIODOLD;

	// Token: 0x040004A6 RID: 1190
	internal MeshFilter DJFNJPHBAFO;

	// Token: 0x040004A7 RID: 1191
	internal MeshFilter OIDGFIJEHKM;

	// Token: 0x040004A8 RID: 1192
	internal MeshFilter MBNJEJNIKDI;

	// Token: 0x040004A9 RID: 1193
	internal MeshFilter DDJNNFJINJE;

	// Token: 0x040004AA RID: 1194
	internal MeshFilter HNCNKCJKFJO;

	// Token: 0x040004AB RID: 1195
	internal MeshFilter LPNKELBJFHK;

	// Token: 0x040004AC RID: 1196
	internal Material CHKCGPGIOPB;

	// Token: 0x040004AD RID: 1197
	internal Material FJKDDLPBBHD;

	// Token: 0x040004AE RID: 1198
	internal Material FMBBCDILBLE;

	// Token: 0x040004AF RID: 1199
	internal Material ENLCHIIOIBB;

	// Token: 0x040004B0 RID: 1200
	internal Material FKNIPFONANF;

	// Token: 0x040004B1 RID: 1201
	internal Material OHAADBJGPHL;

	// Token: 0x040004B2 RID: 1202
	internal Material HMFIBKJKOKK;

	// Token: 0x040004B3 RID: 1203
	internal Light JAFNHAHJLOH;

	// Token: 0x040004B4 RID: 1204
	internal Projector AIDEHKOPKHN;

	// Token: 0x040004B5 RID: 1205
	internal TOD_Sky JEDHJJMMKPH;

	// Token: 0x040004B6 RID: 1206
	internal TOD_Animation JEJLCMAKKCK;

	// Token: 0x040004B7 RID: 1207
	internal TOD_Time EJHFCHDDPAJ;

	// Token: 0x040004B8 RID: 1208
	internal TOD_Weather PHLAGOLHIMB;

	// Token: 0x040004B9 RID: 1209
	internal TOD_Camera MHJDBKALKDF;

	// Token: 0x040004BA RID: 1210
	internal TOD_Rays AENELOFPPFG;

	// Token: 0x040004BB RID: 1211
	internal TOD_Scattering BDMMNJCHJEK;
}
