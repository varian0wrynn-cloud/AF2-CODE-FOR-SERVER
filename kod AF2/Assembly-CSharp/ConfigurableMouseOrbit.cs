using System;
using UnityEngine;

// Token: 0x020000B8 RID: 184
[ExecuteInEditMode]
[AddComponentMenu("Camera-Control/Configurable Mouse Orbit")]
public class ConfigurableMouseOrbit : MonoBehaviour
{
	// Token: 0x06002733 RID: 10035 RVA: 0x00113120 File Offset: 0x00111320
	private void BHDPDDHLPOI()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("wpn_dress2") * this.xSpeed * 643f;
			this.ADMFAEOOOHD -= Input.GetAxis("_SunPosition") * this.ySpeed * 153f;
		}
		float axis = Input.GetAxis("CrawlLocomotion");
		if (axis != 554f)
		{
			this.distance = Mathf.Clamp(this.distance * (1693f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.KAFAPEMMINE(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 1949f);
		Vector3 vector = rotation * new Vector3(373f, 1182f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002734 RID: 10036 RVA: 0x00113294 File Offset: 0x00111494
	private void EIEKEPGNGPL()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("IceHockeyDekeMiddle") * this.xSpeed * 645f;
			this.ADMFAEOOOHD -= Input.GetAxis(" iterations for read and write") * this.ySpeed * 715f;
		}
		float axis = Input.GetAxis("Climb Right");
		if (axis != 969f)
		{
			this.distance = Mathf.Clamp(this.distance * (1724f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.OIFADEHPIJM(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 985f);
		Vector3 vector = rotation * new Vector3(543f, 868f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002735 RID: 10037 RVA: 0x00113408 File Offset: 0x00111608
	private void EMMMEIGNPCH()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("OfficeSittingMouseMovement") * this.xSpeed * 401f;
			this.ADMFAEOOOHD -= Input.GetAxis("GiantGrabIdle") * this.ySpeed * 1047f;
		}
		float axis = Input.GetAxis("gi_nlheader2");
		if (axis != 1064f)
		{
			this.distance = Mathf.Clamp(this.distance * (1420f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.EEEEHDLEFPB(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 680f);
		Vector3 vector = rotation * new Vector3(95f, 1263f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002736 RID: 10038 RVA: 0x00113579 File Offset: 0x00111779
	private static float LJPEAOINNAE(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1612f)
		{
			NEPBPMGGPKM += 1915f;
		}
		if (NEPBPMGGPKM > 570f)
		{
			NEPBPMGGPKM -= 1785f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002737 RID: 10039 RVA: 0x001135A8 File Offset: 0x001117A8
	private void OFJPMLKIDEH()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("t_shoes") * this.xSpeed * 460f;
			this.ADMFAEOOOHD -= Input.GetAxis("CrouchStrafeRight") * this.ySpeed * 1739f;
		}
		float axis = Input.GetAxis("MotorbikeTurnLeft");
		if (axis != 762f)
		{
			this.distance = Mathf.Clamp(this.distance * (218f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.JHDCNPMPMHC(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 882f);
		Vector3 vector = rotation * new Vector3(1451f, 617f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002738 RID: 10040 RVA: 0x0011371C File Offset: 0x0011191C
	private void KKCFKEDABLB()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002739 RID: 10041 RVA: 0x00113774 File Offset: 0x00111974
	private static float MMCFGHDHKGO(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 443f)
		{
			NEPBPMGGPKM += 114f;
		}
		if (NEPBPMGGPKM > 446f)
		{
			NEPBPMGGPKM -= 388f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600273A RID: 10042 RVA: 0x001137A0 File Offset: 0x001119A0
	private void GKNGOOCGMED()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("_DeepTex") * this.xSpeed * 1888f;
			this.ADMFAEOOOHD -= Input.GetAxis("PLANE_REFLECTION_CHEAPER") * this.ySpeed * 211f;
		}
		float axis = Input.GetAxis("Invalid ObscuredVector2 index!");
		if (axis != 506f)
		{
			this.distance = Mathf.Clamp(this.distance * (1226f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.FBIPBPLMKEJ(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 1718f);
		Vector3 vector = rotation * new Vector3(739f, 442f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x0600273B RID: 10043 RVA: 0x00113911 File Offset: 0x00111B11
	private static float KHPILKHKLLG(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1000f)
		{
			NEPBPMGGPKM += 280f;
		}
		if (NEPBPMGGPKM > 1899f)
		{
			NEPBPMGGPKM -= 162f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600273C RID: 10044 RVA: 0x00113940 File Offset: 0x00111B40
	private void CODAMDJCPHK()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("ObscuredByte vs byte, ") * this.xSpeed * 822f;
			this.ADMFAEOOOHD -= Input.GetAxis("Jump") * this.ySpeed * 685f;
		}
		float axis = Input.GetAxis("DataSize ");
		if (axis != 1238f)
		{
			this.distance = Mathf.Clamp(this.distance * (1825f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.EGMOBKOPJLN(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 1345f);
		Vector3 vector = rotation * new Vector3(494f, 878f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x0600273D RID: 10045 RVA: 0x00113AB4 File Offset: 0x00111CB4
	private void DNLFEOECBKI()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x0600273E RID: 10046 RVA: 0x00113B0C File Offset: 0x00111D0C
	private void BMNJGPIPKLL()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x0600273F RID: 10047 RVA: 0x00113B64 File Offset: 0x00111D64
	private static float PHMHGNBBEOB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 468f)
		{
			NEPBPMGGPKM += 1068f;
		}
		if (NEPBPMGGPKM > 638f)
		{
			NEPBPMGGPKM -= 989f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002740 RID: 10048 RVA: 0x00113B90 File Offset: 0x00111D90
	private static float FBIPBPLMKEJ(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 826f)
		{
			NEPBPMGGPKM += 1676f;
		}
		if (NEPBPMGGPKM > 366f)
		{
			NEPBPMGGPKM -= 1216f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002741 RID: 10049 RVA: 0x00113BBC File Offset: 0x00111DBC
	private void JHFAHBIIJDC()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002742 RID: 10050 RVA: 0x00113C14 File Offset: 0x00111E14
	private void JCELICPHGEP()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002743 RID: 10051 RVA: 0x00113C6C File Offset: 0x00111E6C
	private void CJNBMPCNKHP()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002744 RID: 10052 RVA: 0x00113CC4 File Offset: 0x00111EC4
	private static float EMFLBNBKFJF(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 128f)
		{
			NEPBPMGGPKM += 268f;
		}
		if (NEPBPMGGPKM > 807f)
		{
			NEPBPMGGPKM -= 1435f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002745 RID: 10053 RVA: 0x00113CF0 File Offset: 0x00111EF0
	private void NGHOJBOHIBA()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("Jump") * this.xSpeed * 307f;
			this.ADMFAEOOOHD -= Input.GetAxis("<") * this.ySpeed * 759f;
		}
		float axis = Input.GetAxis("Apply 1");
		if (axis != 1677f)
		{
			this.distance = Mathf.Clamp(this.distance * (135f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.OPKMBDODICN(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 513f);
		Vector3 vector = rotation * new Vector3(479f, 587f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002746 RID: 10054 RVA: 0x00113E61 File Offset: 0x00112061
	private static float EEEEHDLEFPB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1523f)
		{
			NEPBPMGGPKM += 552f;
		}
		if (NEPBPMGGPKM > 1571f)
		{
			NEPBPMGGPKM -= 1108f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002747 RID: 10055 RVA: 0x00113E8D File Offset: 0x0011208D
	private static float IMDGHIAGPFB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1075f)
		{
			NEPBPMGGPKM += 311f;
		}
		if (NEPBPMGGPKM > 1770f)
		{
			NEPBPMGGPKM -= 1373f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002748 RID: 10056 RVA: 0x00113EBC File Offset: 0x001120BC
	private void LPNDCJKAKEA()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002749 RID: 10057 RVA: 0x00113F14 File Offset: 0x00112114
	private void OGFGENJAMAM()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("' that does not excist in the Node Chain.") * this.xSpeed * 1496f;
			this.ADMFAEOOOHD -= Input.GetAxis("_FogDistance") * this.ySpeed * 456f;
		}
		float axis = Input.GetAxis("");
		if (axis != 1505f)
		{
			this.distance = Mathf.Clamp(this.distance * (1825f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.LJPEAOINNAE(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 1684f);
		Vector3 vector = rotation * new Vector3(1184f, 1347f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x0600274A RID: 10058 RVA: 0x00114088 File Offset: 0x00112288
	private void CGMHGDEKDEP()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x0600274B RID: 10059 RVA: 0x001140E0 File Offset: 0x001122E0
	private static float ODOPJCFIJFP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1279f)
		{
			NEPBPMGGPKM += 1173f;
		}
		if (NEPBPMGGPKM > 1836f)
		{
			NEPBPMGGPKM -= 1936f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600274C RID: 10060 RVA: 0x0011410C File Offset: 0x0011230C
	private static float CBHAMBCPPHA(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 641f)
		{
			NEPBPMGGPKM += 1107f;
		}
		if (NEPBPMGGPKM > 1175f)
		{
			NEPBPMGGPKM -= 722f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600274D RID: 10061 RVA: 0x00114138 File Offset: 0x00112338
	private static float OEELNEDCKKB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1597f)
		{
			NEPBPMGGPKM += 1850f;
		}
		if (NEPBPMGGPKM > 465f)
		{
			NEPBPMGGPKM -= 1597f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600274E RID: 10062 RVA: 0x00114164 File Offset: 0x00112364
	private void GIADAJFBIOP()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x0600274F RID: 10063 RVA: 0x001141BC File Offset: 0x001123BC
	private void LHHKDNILMDI()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x00114214 File Offset: 0x00112414
	private void JPHBPEAMNHB()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002751 RID: 10065 RVA: 0x0011426C File Offset: 0x0011246C
	private void DOHJPDNKALP()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x001142C4 File Offset: 0x001124C4
	private void CAJLCEPLKJG()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002753 RID: 10067 RVA: 0x0011431C File Offset: 0x0011251C
	private void CGNFLAOBEFN()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("Running Slide") * this.xSpeed * 1086f;
			this.ADMFAEOOOHD -= Input.GetAxis("OK auk2KeyMEditOk---1") * this.ySpeed * 1679f;
		}
		float axis = Input.GetAxis("Water Refl Camera id");
		if (axis != 846f)
		{
			this.distance = Mathf.Clamp(this.distance * (1389f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.MEHHPBOKPCI(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 990f);
		Vector3 vector = rotation * new Vector3(963f, 870f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002754 RID: 10068 RVA: 0x00114490 File Offset: 0x00112690
	private void KGICJDGIIJK()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002755 RID: 10069 RVA: 0x001144E8 File Offset: 0x001126E8
	private void KMOHGOOEJOI()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("InteractionSystem can not find a FullBodyBipedIK component") * this.xSpeed * 1503f;
			this.ADMFAEOOOHD -= Input.GetAxis("_NoiseAmount") * this.ySpeed * 1918f;
		}
		float axis = Input.GetAxis("Vertical");
		if (axis != 1637f)
		{
			this.distance = Mathf.Clamp(this.distance * (1579f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.KHPILKHKLLG(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 933f);
		Vector3 vector = rotation * new Vector3(1021f, 227f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002756 RID: 10070 RVA: 0x00114659 File Offset: 0x00112859
	private static float LHIGJDOKBFH(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 224f)
		{
			NEPBPMGGPKM += 1734f;
		}
		if (NEPBPMGGPKM > 461f)
		{
			NEPBPMGGPKM -= 1457f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002757 RID: 10071 RVA: 0x00114688 File Offset: 0x00112888
	private void ONAEKGDNBIB()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("_Parameter") * this.xSpeed * 1915f;
			this.ADMFAEOOOHD -= Input.GetAxis("") * this.ySpeed * 1480f;
		}
		float axis = Input.GetAxis("Didn't expect existing render texture: ");
		if (axis != 959f)
		{
			this.distance = Mathf.Clamp(this.distance * (13f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.BDGKEJOCHFB(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 1602f);
		Vector3 vector = rotation * new Vector3(1326f, 1590f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002758 RID: 10072 RVA: 0x001147FC File Offset: 0x001129FC
	private void PFNPOHMMJDN()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002759 RID: 10073 RVA: 0x00114854 File Offset: 0x00112A54
	private static float EGMOBKOPJLN(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1153f)
		{
			NEPBPMGGPKM += 410f;
		}
		if (NEPBPMGGPKM > 1607f)
		{
			NEPBPMGGPKM -= 144f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600275A RID: 10074 RVA: 0x00114880 File Offset: 0x00112A80
	private void FJGIBCHABIG()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x0600275B RID: 10075 RVA: 0x001148D8 File Offset: 0x00112AD8
	private static float OIFADEHPIJM(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1275f)
		{
			NEPBPMGGPKM += 1119f;
		}
		if (NEPBPMGGPKM > 469f)
		{
			NEPBPMGGPKM -= 1152f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600275C RID: 10076 RVA: 0x00114904 File Offset: 0x00112B04
	private static float DCBEKIGLKNN(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 973f)
		{
			NEPBPMGGPKM += 774f;
		}
		if (NEPBPMGGPKM > 588f)
		{
			NEPBPMGGPKM -= 893f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600275D RID: 10077 RVA: 0x00114930 File Offset: 0x00112B30
	private void KEMGOLACEHI()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x0600275E RID: 10078 RVA: 0x00114988 File Offset: 0x00112B88
	private static float ALCEMOMGDAB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1504f)
		{
			NEPBPMGGPKM += 1555f;
		}
		if (NEPBPMGGPKM > 1695f)
		{
			NEPBPMGGPKM -= 1301f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600275F RID: 10079 RVA: 0x001149B4 File Offset: 0x00112BB4
	private void DGGMJCMLLED()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002760 RID: 10080 RVA: 0x00114A0C File Offset: 0x00112C0C
	private static float CMIJCICNPPD(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 971f)
		{
			NEPBPMGGPKM += 1925f;
		}
		if (NEPBPMGGPKM > 1260f)
		{
			NEPBPMGGPKM -= 515f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002761 RID: 10081 RVA: 0x00114A38 File Offset: 0x00112C38
	private static float CIKCPMGHEOB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 722f)
		{
			NEPBPMGGPKM += 337f;
		}
		if (NEPBPMGGPKM > 711f)
		{
			NEPBPMGGPKM -= 1337f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002762 RID: 10082 RVA: 0x00114A64 File Offset: 0x00112C64
	private void AOCDDBNBADJ()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002763 RID: 10083 RVA: 0x00114ABC File Offset: 0x00112CBC
	private static float NGIMJMEJLHK(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1041f)
		{
			NEPBPMGGPKM += 1796f;
		}
		if (NEPBPMGGPKM > 637f)
		{
			NEPBPMGGPKM -= 1415f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002764 RID: 10084 RVA: 0x00114AE8 File Offset: 0x00112CE8
	private void KMMEMAHCFLJ()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002765 RID: 10085 RVA: 0x00114B40 File Offset: 0x00112D40
	private static float KPGPGHFDLKE(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 480f)
		{
			NEPBPMGGPKM += 1539f;
		}
		if (NEPBPMGGPKM > 712f)
		{
			NEPBPMGGPKM -= 459f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002766 RID: 10086 RVA: 0x00114B6C File Offset: 0x00112D6C
	private void PLBDELOIINH()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002767 RID: 10087 RVA: 0x00114BC4 File Offset: 0x00112DC4
	private static float PLABIACNDPE(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 451f)
		{
			NEPBPMGGPKM += 1533f;
		}
		if (NEPBPMGGPKM > 1218f)
		{
			NEPBPMGGPKM -= 252f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002768 RID: 10088 RVA: 0x00114BF0 File Offset: 0x00112DF0
	private static float MKIHBEAFACG(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1449f)
		{
			NEPBPMGGPKM += 920f;
		}
		if (NEPBPMGGPKM > 1947f)
		{
			NEPBPMGGPKM -= 1785f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002769 RID: 10089 RVA: 0x00114C1C File Offset: 0x00112E1C
	private void FECFLBMPAAL()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x0600276A RID: 10090 RVA: 0x00114C74 File Offset: 0x00112E74
	private static float OPKMBDODICN(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1345f)
		{
			NEPBPMGGPKM += 892f;
		}
		if (NEPBPMGGPKM > 79f)
		{
			NEPBPMGGPKM -= 1896f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600276B RID: 10091 RVA: 0x00114CA0 File Offset: 0x00112EA0
	private void HDFCIACDDEK()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x0600276C RID: 10092 RVA: 0x00114CF8 File Offset: 0x00112EF8
	private void MJFJPFJICDH()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("RollerBladeBackFlip") * this.xSpeed * 1878f;
			this.ADMFAEOOOHD -= Input.GetAxis("threshold") * this.ySpeed * 788f;
		}
		float axis = Input.GetAxis("17,18,19,20,29,33");
		if (axis != 488f)
		{
			this.distance = Mathf.Clamp(this.distance * (1462f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.CMIJCICNPPD(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 155f);
		Vector3 vector = rotation * new Vector3(1876f, 949f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x0600276D RID: 10093 RVA: 0x00114E6C File Offset: 0x0011306C
	private void MKNPFMEMOJO()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x0600276E RID: 10094 RVA: 0x00114EC4 File Offset: 0x001130C4
	private void CKIGGCAHAFD()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x0600276F RID: 10095 RVA: 0x00114F1C File Offset: 0x0011311C
	private void HEMEEOGJDOE()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002770 RID: 10096 RVA: 0x00114F74 File Offset: 0x00113174
	private void JJMGNAMFJGJ()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("Lasso Forward") * this.xSpeed * 1254f;
			this.ADMFAEOOOHD -= Input.GetAxis("") * this.ySpeed * 661f;
		}
		float axis = Input.GetAxis(" rod file=");
		if (axis != 1169f)
		{
			this.distance = Mathf.Clamp(this.distance * (465f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.MKIHBEAFACG(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 1659f);
		Vector3 vector = rotation * new Vector3(498f, 180f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002771 RID: 10097 RVA: 0x001150E8 File Offset: 0x001132E8
	private void DGEIACONKCJ()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002773 RID: 10099 RVA: 0x001151A8 File Offset: 0x001133A8
	private void LateUpdate()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("Mouse X") * this.xSpeed * 0.02f;
			this.ADMFAEOOOHD -= Input.GetAxis("Mouse Y") * this.ySpeed * 0.02f;
		}
		float axis = Input.GetAxis("Mouse ScrollWheel");
		if (axis != 0f)
		{
			this.distance = Mathf.Clamp(this.distance * (1f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.ILKJPHGKMEP(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 0f);
		Vector3 vector = rotation * new Vector3(0f, 0f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002774 RID: 10100 RVA: 0x0011531C File Offset: 0x0011351C
	private void ONMFGDAKHHC()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("RollerBladeStop") * this.xSpeed * 182f;
			this.ADMFAEOOOHD -= Input.GetAxis("WorkerPickaxe2") * this.ySpeed * 667f;
		}
		float axis = Input.GetAxis("OneHandSwordJab");
		if (axis != 1413f)
		{
			this.distance = Mathf.Clamp(this.distance * (351f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.IELALGMNBGN(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 960f);
		Vector3 vector = rotation * new Vector3(591f, 742f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002775 RID: 10101 RVA: 0x00115490 File Offset: 0x00113690
	private void FHOKOPGOBIP()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("0") * this.xSpeed * 1904f;
			this.ADMFAEOOOHD -= Input.GetAxis("14,15,16,36") * this.ySpeed * 1131f;
		}
		float axis = Input.GetAxis("Flares");
		if (axis != 1013f)
		{
			this.distance = Mathf.Clamp(this.distance * (1063f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.IELALGMNBGN(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 230f);
		Vector3 vector = rotation * new Vector3(1503f, 333f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002776 RID: 10102 RVA: 0x00115601 File Offset: 0x00113801
	private static float ILKJPHGKMEP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < -360f)
		{
			NEPBPMGGPKM += 360f;
		}
		if (NEPBPMGGPKM > 360f)
		{
			NEPBPMGGPKM -= 360f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002777 RID: 10103 RVA: 0x00115630 File Offset: 0x00113830
	private void DDEBDCGNCPC()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002778 RID: 10104 RVA: 0x00115688 File Offset: 0x00113888
	private void OHAOGONDAHA()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("") * this.xSpeed * 1320f;
			this.ADMFAEOOOHD -= Input.GetAxis("") * this.ySpeed * 373f;
		}
		float axis = Input.GetAxis("_FogSpeed");
		if (axis != 223f)
		{
			this.distance = Mathf.Clamp(this.distance * (918f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.PLABIACNDPE(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 1675f);
		Vector3 vector = rotation * new Vector3(183f, 1065f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002779 RID: 10105 RVA: 0x001157F9 File Offset: 0x001139F9
	private static float NPDNMAJFOMD(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1722f)
		{
			NEPBPMGGPKM += 610f;
		}
		if (NEPBPMGGPKM > 1746f)
		{
			NEPBPMGGPKM -= 1779f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600277A RID: 10106 RVA: 0x00115828 File Offset: 0x00113A28
	private void BFLFPNNPOMC()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("_SceneFogParams") * this.xSpeed * 172f;
			this.ADMFAEOOOHD -= Input.GetAxis("SunshinePreferences") * this.ySpeed * 1402f;
		}
		float axis = Input.GetAxis("SneakRight");
		if (axis != 1272f)
		{
			this.distance = Mathf.Clamp(this.distance * (1111f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.NGDBINCHOGJ(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 39f);
		Vector3 vector = rotation * new Vector3(1359f, 1680f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x0600277B RID: 10107 RVA: 0x00115999 File Offset: 0x00113B99
	private static float BDGKEJOCHFB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1149f)
		{
			NEPBPMGGPKM += 1370f;
		}
		if (NEPBPMGGPKM > 1954f)
		{
			NEPBPMGGPKM -= 1387f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600277C RID: 10108 RVA: 0x001159C8 File Offset: 0x00113BC8
	private void DPPAAIJCFLC()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x0600277D RID: 10109 RVA: 0x00115A20 File Offset: 0x00113C20
	private void CHDJGEOFHEE()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x0600277E RID: 10110 RVA: 0x00115A78 File Offset: 0x00113C78
	private void HPEMKDKDKFC()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("toFishPoint") * this.xSpeed * 30f;
			this.ADMFAEOOOHD -= Input.GetAxis("Hidden/Image Effects/Cinematic/Bloom") * this.ySpeed * 333f;
		}
		float axis = Input.GetAxis("Window");
		if (axis != 1924f)
		{
			this.distance = Mathf.Clamp(this.distance * (336f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.ALCEMOMGDAB(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 1928f);
		Vector3 vector = rotation * new Vector3(459f, 1864f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x0600277F RID: 10111 RVA: 0x00115BE9 File Offset: 0x00113DE9
	private static float IELALGMNBGN(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1458f)
		{
			NEPBPMGGPKM += 485f;
		}
		if (NEPBPMGGPKM > 661f)
		{
			NEPBPMGGPKM -= 1667f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002780 RID: 10112 RVA: 0x00115C18 File Offset: 0x00113E18
	private void ECMAANIDEBA()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002781 RID: 10113 RVA: 0x00115C70 File Offset: 0x00113E70
	private static float KAFAPEMMINE(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1004f)
		{
			NEPBPMGGPKM += 1222f;
		}
		if (NEPBPMGGPKM > 337f)
		{
			NEPBPMGGPKM -= 360f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002782 RID: 10114 RVA: 0x00115C9C File Offset: 0x00113E9C
	private void CGNGBFFGGBP()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002783 RID: 10115 RVA: 0x00115CF4 File Offset: 0x00113EF4
	private static float MEHHPBOKPCI(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1878f)
		{
			NEPBPMGGPKM += 588f;
		}
		if (NEPBPMGGPKM > 1865f)
		{
			NEPBPMGGPKM -= 735f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002784 RID: 10116 RVA: 0x00115D20 File Offset: 0x00113F20
	private void EHDPACPIBNF()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002785 RID: 10117 RVA: 0x00115D78 File Offset: 0x00113F78
	private static float HEMIDCDNFPD(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 237f)
		{
			NEPBPMGGPKM += 1125f;
		}
		if (NEPBPMGGPKM > 356f)
		{
			NEPBPMGGPKM -= 132f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002786 RID: 10118 RVA: 0x00115DA4 File Offset: 0x00113FA4
	private void DJODHDNKIJE()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("time") * this.xSpeed * 145f;
			this.ADMFAEOOOHD -= Input.GetAxis("RHandPunch") * this.ySpeed * 1319f;
		}
		float axis = Input.GetAxis("error baseid: ");
		if (axis != 1245f)
		{
			this.distance = Mathf.Clamp(this.distance * (289f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.ILKJPHGKMEP(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 1278f);
		Vector3 vector = rotation * new Vector3(331f, 432f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002787 RID: 10119 RVA: 0x00115F18 File Offset: 0x00114118
	private void MCHAAIIHOKD()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002788 RID: 10120 RVA: 0x00115F70 File Offset: 0x00114170
	private void Start()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002789 RID: 10121 RVA: 0x00115FC8 File Offset: 0x001141C8
	private void NPDBHEONIDA()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("val=") * this.xSpeed * 313f;
			this.ADMFAEOOOHD -= Input.GetAxis("%)") * this.ySpeed * 771f;
		}
		float axis = Input.GetAxis("btn_cancel");
		if (axis != 170f)
		{
			this.distance = Mathf.Clamp(this.distance * (1797f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.EGMOBKOPJLN(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 316f);
		Vector3 vector = rotation * new Vector3(1617f, 1124f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x0600278A RID: 10122 RVA: 0x00116139 File Offset: 0x00114339
	private static float EPIMGDFMLPA(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1653f)
		{
			NEPBPMGGPKM += 1948f;
		}
		if (NEPBPMGGPKM > 124f)
		{
			NEPBPMGGPKM -= 887f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600278B RID: 10123 RVA: 0x00116168 File Offset: 0x00114368
	private void FCCAIANLEFE()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x0600278C RID: 10124 RVA: 0x001161C0 File Offset: 0x001143C0
	private void KBKONONANKH()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("http://www.root-motion.com/finalikdox/html/page11.html") * this.xSpeed * 1194f;
			this.ADMFAEOOOHD -= Input.GetAxis("WeaponStrafeRunRight") * this.ySpeed * 533f;
		}
		float axis = Input.GetAxis("Knee");
		if (axis != 597f)
		{
			this.distance = Mathf.Clamp(this.distance * (1303f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.DCBEKIGLKNN(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 855f);
		Vector3 vector = rotation * new Vector3(921f, 1132f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x0600278D RID: 10125 RVA: 0x00116334 File Offset: 0x00114534
	private void ACLJDJBJLCD()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x0600278E RID: 10126 RVA: 0x0011638C File Offset: 0x0011458C
	private void PCGMJEBLBLD()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("WeaponStand") * this.xSpeed * 715f;
			this.ADMFAEOOOHD -= Input.GetAxis("LDR") * this.ySpeed * 979f;
		}
		float axis = Input.GetAxis("Sat Night Fever");
		if (axis != 69f)
		{
			this.distance = Mathf.Clamp(this.distance * (1682f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.NGIMJMEJLHK(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 923f);
		Vector3 vector = rotation * new Vector3(1941f, 1343f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x0600278F RID: 10127 RVA: 0x001164FD File Offset: 0x001146FD
	private static float JHDCNPMPMHC(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 644f)
		{
			NEPBPMGGPKM += 1533f;
		}
		if (NEPBPMGGPKM > 1157f)
		{
			NEPBPMGGPKM -= 60f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002790 RID: 10128 RVA: 0x00116529 File Offset: 0x00114729
	private static float FEEHPLPBAKP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 313f)
		{
			NEPBPMGGPKM += 1091f;
		}
		if (NEPBPMGGPKM > 1136f)
		{
			NEPBPMGGPKM -= 1120f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002791 RID: 10129 RVA: 0x00116555 File Offset: 0x00114755
	private static float MANAFHFALMM(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 117f)
		{
			NEPBPMGGPKM += 1154f;
		}
		if (NEPBPMGGPKM > 918f)
		{
			NEPBPMGGPKM -= 1203f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002792 RID: 10130 RVA: 0x00116584 File Offset: 0x00114784
	private void LHMNFJBJBJM()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002793 RID: 10131 RVA: 0x001165DC File Offset: 0x001147DC
	private void HHJKBKLPLIM()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("openQuest") * this.xSpeed * 1166f;
			this.ADMFAEOOOHD -= Input.GetAxis("3") * this.ySpeed * 1757f;
		}
		float axis = Input.GetAxis("[HA Center][C FA8C8CFF][FS 24]Fireball[FS 16][color FFFFFFFF]\n\nHurls a ball of fire that [F ArialBold]explodes[F Arial] on [FA U]contact[FA -U] and damages all nearby [FA S]foes [FA -S]enemies.\n\n[VA B][C FF6666FF][F ArialBold 18]8[FS 16][C FFFFFFFF][F Arial] to [C FF6666FF][F ArialBold 18]12[F Arial 16][C FFFFFFFF][F ArialItalic] fire[F Arial] damage[VA ?]");
		if (axis != 484f)
		{
			this.distance = Mathf.Clamp(this.distance * (1801f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.MMCFGHDHKGO(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 1692f);
		Vector3 vector = rotation * new Vector3(308f, 1254f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002794 RID: 10132 RVA: 0x00116750 File Offset: 0x00114950
	private void CPNOBMNKPNC()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002795 RID: 10133 RVA: 0x001167A8 File Offset: 0x001149A8
	private void AIFIEAGFIMM()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06002796 RID: 10134 RVA: 0x00116800 File Offset: 0x00114A00
	private static float NGDBINCHOGJ(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1691f)
		{
			NEPBPMGGPKM += 90f;
		}
		if (NEPBPMGGPKM > 1017f)
		{
			NEPBPMGGPKM -= 557f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06002797 RID: 10135 RVA: 0x0011682C File Offset: 0x00114A2C
	private void POMLHOHFIGA()
	{
		if (!this.target)
		{
			return;
		}
		if (Input.GetMouseButton((int)this.mouseButton))
		{
			this.OCNGPCPMCPM += Input.GetAxis("_HdrParams") * this.xSpeed * 1497f;
			this.ADMFAEOOOHD -= Input.GetAxis("1 Hand Sword Jab ready strafe left") * this.ySpeed * 1931f;
		}
		float axis = Input.GetAxis("RollerBladeStop");
		if (axis != 497f)
		{
			this.distance = Mathf.Clamp(this.distance * (1131f - axis * this.zoomSpeed), this.distanceMin, this.distanceMax);
		}
		this.ADMFAEOOOHD = ConfigurableMouseOrbit.CEAFMDGJNGI(this.ADMFAEOOOHD, this.yMinLimit, this.yMaxLimit);
		Quaternion rotation = Quaternion.Euler(this.ADMFAEOOOHD, this.OCNGPCPMCPM, 1801f);
		Vector3 vector = rotation * new Vector3(765f, 703f, -this.distance) + this.target.position;
		if (this.centerToAABB && this.target.GetComponent<Renderer>())
		{
			vector += this.target.transform.InverseTransformPoint(this.target.GetComponent<Renderer>().bounds.center);
		}
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06002798 RID: 10136 RVA: 0x001169A0 File Offset: 0x00114BA0
	private void FPLHODJCJDO()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06002799 RID: 10137 RVA: 0x001169F8 File Offset: 0x00114BF8
	private void LBEFOABPMFG()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x0600279A RID: 10138 RVA: 0x00116A50 File Offset: 0x00114C50
	private static float LEDNBINBIGB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1725f)
		{
			NEPBPMGGPKM += 1096f;
		}
		if (NEPBPMGGPKM > 648f)
		{
			NEPBPMGGPKM -= 886f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600279B RID: 10139 RVA: 0x00116A7C File Offset: 0x00114C7C
	private static float HLMFFIFJDJI(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1698f)
		{
			NEPBPMGGPKM += 1357f;
		}
		if (NEPBPMGGPKM > 616f)
		{
			NEPBPMGGPKM -= 545f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600279C RID: 10140 RVA: 0x00116AA8 File Offset: 0x00114CA8
	private void IIHNDJOIMAH()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x0600279D RID: 10141 RVA: 0x00116B00 File Offset: 0x00114D00
	private void PNAAHEFHPCL()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x0600279E RID: 10142 RVA: 0x00116B58 File Offset: 0x00114D58
	private static float CEAFMDGJNGI(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 484f)
		{
			NEPBPMGGPKM += 1931f;
		}
		if (NEPBPMGGPKM > 420f)
		{
			NEPBPMGGPKM -= 1053f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x0600279F RID: 10143 RVA: 0x00116B84 File Offset: 0x00114D84
	private void CKGPEFOKKNL()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x060027A0 RID: 10144 RVA: 0x00116BDC File Offset: 0x00114DDC
	private void CLHGHANANNL()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x060027A1 RID: 10145 RVA: 0x00116C34 File Offset: 0x00114E34
	private void NOKJMMDMJNO()
	{
		if (!this.target)
		{
			return;
		}
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.OCNGPCPMCPM = eulerAngles.y;
		this.ADMFAEOOOHD = eulerAngles.x;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x0400046F RID: 1135
	public Transform target;

	// Token: 0x04000470 RID: 1136
	public float distance = 3f;

	// Token: 0x04000471 RID: 1137
	public float zoomSpeed = 1f;

	// Token: 0x04000472 RID: 1138
	public float distanceMin = 0.2f;

	// Token: 0x04000473 RID: 1139
	public float distanceMax = 10f;

	// Token: 0x04000474 RID: 1140
	public float xSpeed = 250f;

	// Token: 0x04000475 RID: 1141
	public float ySpeed = 120f;

	// Token: 0x04000476 RID: 1142
	public float yMinLimit;

	// Token: 0x04000477 RID: 1143
	public float yMaxLimit = 90f;

	// Token: 0x04000478 RID: 1144
	private float OCNGPCPMCPM;

	// Token: 0x04000479 RID: 1145
	private float ADMFAEOOOHD;

	// Token: 0x0400047A RID: 1146
	public bool centerToAABB = true;

	// Token: 0x0400047B RID: 1147
	public ConfigurableMouseOrbit.HJEMOIDLCMI mouseButton;

	// Token: 0x020000B9 RID: 185
	public enum HJEMOIDLCMI
	{
		// Token: 0x0400047D RID: 1149
		Left,
		// Token: 0x0400047E RID: 1150
		Middle = 2,
		// Token: 0x0400047F RID: 1151
		Right = 1
	}
}
