using System;
using UnityEngine;

// Token: 0x02000298 RID: 664
public class WowCamera : MonoBehaviour
{
	// Token: 0x06009BCF RID: 39887 RVA: 0x00460ACC File Offset: 0x0045ECCC
	private void KCJNJBEJHFA()
	{
		if (!this.target)
		{
			return;
		}
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 1586f, Time.deltaTime * 920f);
		this.xSpeed = 300f;
		this.ySpeed = 1940f;
		if (!JDCEFOFMGHB.IKGFHGKKCPG.JBMEDLAFJNI() && (Input.GetMouseButton(1) || Input.GetMouseButton(3)))
		{
			this.xDeg += Input.GetAxis("wpnend") * this.xSpeed * 1568f;
			this.yDeg -= Input.GetAxis("new wpn lot ") * this.ySpeed * 253f;
		}
		this.yDeg = WowCamera.ILKJPHGKMEP(this.yDeg, (float)this.yMinLimit, (float)this.yMaxLimit);
		Quaternion b = Quaternion.Euler(this.yDeg, this.xDeg, 1241f);
		Quaternion rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1682f);
		if (GuiProcessor.IKGFHGKKCPG != null && !JDCEFOFMGHB.HMJJPNDEKPP().BHBCONNDEBA() && !GuiProcessor.NKOEAPCIBKO().isPanelParamActive)
		{
			this.desiredDistance -= Input.GetAxis("CardPlayerIdle") * Time.deltaTime * (float)this.zoomRate * Mathf.Abs(this.desiredDistance);
		}
		this.desiredDistance = Mathf.Clamp(this.desiredDistance, this.minDistance, this.maxDistance);
		this.KIGBJGPCPMD = this.desiredDistance;
		Vector3 b2 = new Vector3(229f, -this.targetHeight, 200f);
		Vector3 vector = this.target.position - (rotation * Vector3.forward * this.desiredDistance + b2);
		Vector3 vector2 = new Vector3(this.target.position.x, this.target.position.y + this.targetHeight, this.target.position.z);
		bool flag = false;
		RaycastHit raycastHit;
		if (Physics.Linecast(vector2, vector, out raycastHit, this.collisionLayers.value))
		{
			this.KIGBJGPCPMD = Vector3.Distance(vector2, raycastHit.point) - this.offsetFromWall;
			flag = false;
			if (this.KIGBJGPCPMD < 207f)
			{
				this.KIGBJGPCPMD = Mathf.Clamp(this.KIGBJGPCPMD, 892f, this.maxDistance);
			}
		}
		this.currentDistance = ((!flag || this.KIGBJGPCPMD > this.currentDistance) ? Mathf.Lerp(this.currentDistance, this.KIGBJGPCPMD, Time.deltaTime * this.zoomDampening) : this.KIGBJGPCPMD);
		this.currentDistance = Mathf.Clamp(this.currentDistance, this.minDistance, this.maxDistance);
		vector = this.target.position - (rotation * Vector3.forward * this.currentDistance + b2);
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06009BD0 RID: 39888 RVA: 0x00460DDF File Offset: 0x0045EFDF
	private static float LNHHGPABLGI(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 957f)
		{
			NEPBPMGGPKM += 119f;
		}
		if (NEPBPMGGPKM > 1458f)
		{
			NEPBPMGGPKM -= 1740f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06009BD1 RID: 39889 RVA: 0x00460E0C File Offset: 0x0045F00C
	private void EDGALMCHPPH()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.yDeg = (float)this.yMinLimit + (float)(this.yMaxLimit - this.yMinLimit) / 1238f;
		this.currentDistance = this.distance;
		this.desiredDistance = this.distance;
		this.KIGBJGPCPMD = this.distance;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06009BD2 RID: 39890 RVA: 0x00460E84 File Offset: 0x0045F084
	private static float BDGKEJOCHFB(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1104f)
		{
			NEPBPMGGPKM += 233f;
		}
		if (NEPBPMGGPKM > 1764f)
		{
			NEPBPMGGPKM -= 1224f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06009BD3 RID: 39891 RVA: 0x00460EB0 File Offset: 0x0045F0B0
	private void OFGMIEJKMGC()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.yDeg = (float)this.yMinLimit + (float)(this.yMaxLimit - this.yMinLimit) / 1673f;
		this.currentDistance = this.distance;
		this.desiredDistance = this.distance;
		this.KIGBJGPCPMD = this.distance;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06009BD4 RID: 39892 RVA: 0x00460F28 File Offset: 0x0045F128
	private static float CMIJCICNPPD(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1236f)
		{
			NEPBPMGGPKM += 566f;
		}
		if (NEPBPMGGPKM > 892f)
		{
			NEPBPMGGPKM -= 1805f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06009BD5 RID: 39893 RVA: 0x00460F54 File Offset: 0x0045F154
	private void CPNOBMNKPNC()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.yDeg = (float)this.yMinLimit + (float)(this.yMaxLimit - this.yMinLimit) / 41f;
		this.currentDistance = this.distance;
		this.desiredDistance = this.distance;
		this.KIGBJGPCPMD = this.distance;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06009BD6 RID: 39894 RVA: 0x00460FCC File Offset: 0x0045F1CC
	private void FIJKDFIMELM()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.yDeg = (float)this.yMinLimit + (float)(this.yMaxLimit - this.yMinLimit) / 1790f;
		this.currentDistance = this.distance;
		this.desiredDistance = this.distance;
		this.KIGBJGPCPMD = this.distance;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06009BD7 RID: 39895 RVA: 0x00461044 File Offset: 0x0045F244
	private static float HLMFFIFJDJI(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 917f)
		{
			NEPBPMGGPKM += 1632f;
		}
		if (NEPBPMGGPKM > 1212f)
		{
			NEPBPMGGPKM -= 1801f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06009BD8 RID: 39896 RVA: 0x00461070 File Offset: 0x0045F270
	private void GPEFDPEAMNE()
	{
		if (!this.target)
		{
			return;
		}
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 766f, Time.deltaTime * 1994f);
		this.xSpeed = 1973f;
		this.ySpeed = 711f;
		if (!JDCEFOFMGHB.IKGFHGKKCPG.BHBCONNDEBA() && (Input.GetMouseButton(1) || Input.GetMouseButton(2)))
		{
			this.xDeg += Input.GetAxis("_TempRT") * this.xSpeed * 31f;
			this.yDeg -= Input.GetAxis("6") * this.ySpeed * 1998f;
		}
		this.yDeg = WowCamera.AIJHMAKGECP(this.yDeg, (float)this.yMinLimit, (float)this.yMaxLimit);
		Quaternion b = Quaternion.Euler(this.yDeg, this.xDeg, 1275f);
		Quaternion rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1674f);
		if (GuiProcessor.BBLINJLBAIL() != null && !JDCEFOFMGHB.MNJNNDHCDGG().GGCLOKODHEG() && !GuiProcessor.BBLINJLBAIL().isPanelParamActive)
		{
			this.desiredDistance -= Input.GetAxis("Current fog preset: ") * Time.deltaTime * (float)this.zoomRate * Mathf.Abs(this.desiredDistance);
		}
		this.desiredDistance = Mathf.Clamp(this.desiredDistance, this.minDistance, this.maxDistance);
		this.KIGBJGPCPMD = this.desiredDistance;
		Vector3 b2 = new Vector3(1131f, -this.targetHeight, 9f);
		Vector3 vector = this.target.position - (rotation * Vector3.forward * this.desiredDistance + b2);
		Vector3 vector2 = new Vector3(this.target.position.x, this.target.position.y + this.targetHeight, this.target.position.z);
		bool flag = false;
		RaycastHit raycastHit;
		if (Physics.Linecast(vector2, vector, out raycastHit, this.collisionLayers.value))
		{
			this.KIGBJGPCPMD = Vector3.Distance(vector2, raycastHit.point) - this.offsetFromWall;
			flag = true;
			if (this.KIGBJGPCPMD < 202f)
			{
				this.KIGBJGPCPMD = Mathf.Clamp(this.KIGBJGPCPMD, 65f, this.maxDistance);
			}
		}
		this.currentDistance = ((!flag || this.KIGBJGPCPMD > this.currentDistance) ? Mathf.Lerp(this.currentDistance, this.KIGBJGPCPMD, Time.deltaTime * this.zoomDampening) : this.KIGBJGPCPMD);
		this.currentDistance = Mathf.Clamp(this.currentDistance, this.minDistance, this.maxDistance);
		vector = this.target.position - (rotation * Vector3.forward * this.currentDistance + b2);
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06009BD9 RID: 39897 RVA: 0x00461384 File Offset: 0x0045F584
	private void PMIFCKJAFEB()
	{
		if (!this.target)
		{
			return;
		}
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 1025f, Time.deltaTime * 756f);
		this.xSpeed = 1592f;
		this.ySpeed = 1226f;
		if (!JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL && (Input.GetMouseButton(1) || Input.GetMouseButton(4)))
		{
			this.xDeg += Input.GetAxis("demoColor") * this.xSpeed * 269f;
			this.yDeg -= Input.GetAxis("gi_um_nt") * this.ySpeed * 1310f;
		}
		this.yDeg = WowCamera.CMIJCICNPPD(this.yDeg, (float)this.yMinLimit, (float)this.yMaxLimit);
		Quaternion b = Quaternion.Euler(this.yDeg, this.xDeg, 1974f);
		Quaternion rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 986f);
		if (GuiProcessor.PLGADNLAEGN() != null && !JDCEFOFMGHB.JFIDAGABKID().AMGIJECABAD() && !GuiProcessor.PLGADNLAEGN().isPanelParamActive)
		{
			this.desiredDistance -= Input.GetAxis("{0} принял задание '{1}'") * Time.deltaTime * (float)this.zoomRate * Mathf.Abs(this.desiredDistance);
		}
		this.desiredDistance = Mathf.Clamp(this.desiredDistance, this.minDistance, this.maxDistance);
		this.KIGBJGPCPMD = this.desiredDistance;
		Vector3 b2 = new Vector3(94f, -this.targetHeight, 1832f);
		Vector3 vector = this.target.position - (rotation * Vector3.forward * this.desiredDistance + b2);
		Vector3 vector2 = new Vector3(this.target.position.x, this.target.position.y + this.targetHeight, this.target.position.z);
		bool flag = true;
		RaycastHit raycastHit;
		if (Physics.Linecast(vector2, vector, out raycastHit, this.collisionLayers.value))
		{
			this.KIGBJGPCPMD = Vector3.Distance(vector2, raycastHit.point) - this.offsetFromWall;
			flag = true;
			if (this.KIGBJGPCPMD < 1390f)
			{
				this.KIGBJGPCPMD = Mathf.Clamp(this.KIGBJGPCPMD, 676f, this.maxDistance);
			}
		}
		this.currentDistance = ((!flag || this.KIGBJGPCPMD > this.currentDistance) ? Mathf.Lerp(this.currentDistance, this.KIGBJGPCPMD, Time.deltaTime * this.zoomDampening) : this.KIGBJGPCPMD);
		this.currentDistance = Mathf.Clamp(this.currentDistance, this.minDistance, this.maxDistance);
		vector = this.target.position - (rotation * Vector3.forward * this.currentDistance + b2);
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06009BDA RID: 39898 RVA: 0x00461698 File Offset: 0x0045F898
	private void ELFLOPJDAKK()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.yDeg = (float)this.yMinLimit + (float)(this.yMaxLimit - this.yMinLimit) / 1892f;
		this.currentDistance = this.distance;
		this.desiredDistance = this.distance;
		this.KIGBJGPCPMD = this.distance;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06009BDB RID: 39899 RVA: 0x00461710 File Offset: 0x0045F910
	private void LateUpdate()
	{
		if (!this.target)
		{
			return;
		}
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 60f, Time.deltaTime * 10f);
		this.xSpeed = 200f;
		this.ySpeed = 200f;
		if (!JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL && (Input.GetMouseButton(1) || Input.GetMouseButton(2)))
		{
			this.xDeg += Input.GetAxis("Mouse X") * this.xSpeed * 0.02f;
			this.yDeg -= Input.GetAxis("Mouse Y") * this.ySpeed * 0.02f;
		}
		this.yDeg = WowCamera.ILKJPHGKMEP(this.yDeg, (float)this.yMinLimit, (float)this.yMaxLimit);
		Quaternion b = Quaternion.Euler(this.yDeg, this.xDeg, 0f);
		Quaternion rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 3f);
		if (GuiProcessor.IKGFHGKKCPG != null && !JDCEFOFMGHB.IKGFHGKKCPG.GMCOPAMLIPL && !GuiProcessor.IKGFHGKKCPG.isPanelParamActive)
		{
			this.desiredDistance -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * (float)this.zoomRate * Mathf.Abs(this.desiredDistance);
		}
		this.desiredDistance = Mathf.Clamp(this.desiredDistance, this.minDistance, this.maxDistance);
		this.KIGBJGPCPMD = this.desiredDistance;
		Vector3 b2 = new Vector3(0f, -this.targetHeight, 0f);
		Vector3 vector = this.target.position - (rotation * Vector3.forward * this.desiredDistance + b2);
		Vector3 vector2 = new Vector3(this.target.position.x, this.target.position.y + this.targetHeight, this.target.position.z);
		bool flag = false;
		RaycastHit raycastHit;
		if (Physics.Linecast(vector2, vector, out raycastHit, this.collisionLayers.value))
		{
			this.KIGBJGPCPMD = Vector3.Distance(vector2, raycastHit.point) - this.offsetFromWall;
			flag = true;
			if (this.KIGBJGPCPMD < 1.45f)
			{
				this.KIGBJGPCPMD = Mathf.Clamp(this.KIGBJGPCPMD, 1.45f, this.maxDistance);
			}
		}
		this.currentDistance = ((!flag || this.KIGBJGPCPMD > this.currentDistance) ? Mathf.Lerp(this.currentDistance, this.KIGBJGPCPMD, Time.deltaTime * this.zoomDampening) : this.KIGBJGPCPMD);
		this.currentDistance = Mathf.Clamp(this.currentDistance, this.minDistance, this.maxDistance);
		vector = this.target.position - (rotation * Vector3.forward * this.currentDistance + b2);
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06009BDC RID: 39900 RVA: 0x00461A23 File Offset: 0x0045FC23
	private static float BKABIAICJEP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 346f)
		{
			NEPBPMGGPKM += 146f;
		}
		if (NEPBPMGGPKM > 303f)
		{
			NEPBPMGGPKM -= 666f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06009BDD RID: 39901 RVA: 0x00461A50 File Offset: 0x0045FC50
	private void BLOLJBHKGOH()
	{
		if (!this.target)
		{
			return;
		}
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 467f, Time.deltaTime * 1953f);
		this.xSpeed = 1946f;
		this.ySpeed = 1455f;
		if (!JDCEFOFMGHB.IKGFHGKKCPG.AMGIJECABAD() && (Input.GetMouseButton(0) || Input.GetMouseButton(6)))
		{
			this.xDeg += Input.GetAxis("Clouds reference not set.") * this.xSpeed * 1113f;
			this.yDeg -= Input.GetAxis("_AdaptionSpeed") * this.ySpeed * 640f;
		}
		this.yDeg = WowCamera.BDGKEJOCHFB(this.yDeg, (float)this.yMinLimit, (float)this.yMaxLimit);
		Quaternion b = Quaternion.Euler(this.yDeg, this.xDeg, 1298f);
		Quaternion rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 1622f);
		if (GuiProcessor.NKOEAPCIBKO() != null && !JDCEFOFMGHB.HMJJPNDEKPP().AMGIJECABAD() && !GuiProcessor.IKGFHGKKCPG.isPanelParamActive)
		{
			this.desiredDistance -= Input.GetAxis("_HueShift") * Time.deltaTime * (float)this.zoomRate * Mathf.Abs(this.desiredDistance);
		}
		this.desiredDistance = Mathf.Clamp(this.desiredDistance, this.minDistance, this.maxDistance);
		this.KIGBJGPCPMD = this.desiredDistance;
		Vector3 b2 = new Vector3(1694f, -this.targetHeight, 33f);
		Vector3 vector = this.target.position - (rotation * Vector3.forward * this.desiredDistance + b2);
		Vector3 vector2 = new Vector3(this.target.position.x, this.target.position.y + this.targetHeight, this.target.position.z);
		bool flag = true;
		RaycastHit raycastHit;
		if (Physics.Linecast(vector2, vector, out raycastHit, this.collisionLayers.value))
		{
			this.KIGBJGPCPMD = Vector3.Distance(vector2, raycastHit.point) - this.offsetFromWall;
			flag = true;
			if (this.KIGBJGPCPMD < 1174f)
			{
				this.KIGBJGPCPMD = Mathf.Clamp(this.KIGBJGPCPMD, 291f, this.maxDistance);
			}
		}
		this.currentDistance = ((!flag || this.KIGBJGPCPMD > this.currentDistance) ? Mathf.Lerp(this.currentDistance, this.KIGBJGPCPMD, Time.deltaTime * this.zoomDampening) : this.KIGBJGPCPMD);
		this.currentDistance = Mathf.Clamp(this.currentDistance, this.minDistance, this.maxDistance);
		vector = this.target.position - (rotation * Vector3.forward * this.currentDistance + b2);
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06009BDE RID: 39902 RVA: 0x00461D64 File Offset: 0x0045FF64
	private void MCHAAIIHOKD()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.yDeg = (float)this.yMinLimit + (float)(this.yMaxLimit - this.yMinLimit) / 618f;
		this.currentDistance = this.distance;
		this.desiredDistance = this.distance;
		this.KIGBJGPCPMD = this.distance;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06009BDF RID: 39903 RVA: 0x00461DDC File Offset: 0x0045FFDC
	private void KKCFKEDABLB()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.yDeg = (float)this.yMinLimit + (float)(this.yMaxLimit - this.yMinLimit) / 398f;
		this.currentDistance = this.distance;
		this.desiredDistance = this.distance;
		this.KIGBJGPCPMD = this.distance;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06009BE0 RID: 39904 RVA: 0x00461E54 File Offset: 0x00460054
	private void CFHDJOKLHDB()
	{
		if (!this.target)
		{
			return;
		}
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 1323f, Time.deltaTime * 375f);
		this.xSpeed = 837f;
		this.ySpeed = 342f;
		if (!JDCEFOFMGHB.HMJJPNDEKPP().GGCLOKODHEG() && (Input.GetMouseButton(0) || Input.GetMouseButton(2)))
		{
			this.xDeg += Input.GetAxis("UnityEngine.Vector3") * this.xSpeed * 489f;
			this.yDeg -= Input.GetAxis("IdleBandage") * this.ySpeed * 419f;
		}
		this.yDeg = WowCamera.CMIJCICNPPD(this.yDeg, (float)this.yMinLimit, (float)this.yMaxLimit);
		Quaternion b = Quaternion.Euler(this.yDeg, this.xDeg, 1563f);
		Quaternion rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 593f);
		if (GuiProcessor.BBLINJLBAIL() != null && !JDCEFOFMGHB.JFIDAGABKID().AMGIJECABAD() && !GuiProcessor.NKOEAPCIBKO().isPanelParamActive)
		{
			this.desiredDistance -= Input.GetAxis("Original health bar: ") * Time.deltaTime * (float)this.zoomRate * Mathf.Abs(this.desiredDistance);
		}
		this.desiredDistance = Mathf.Clamp(this.desiredDistance, this.minDistance, this.maxDistance);
		this.KIGBJGPCPMD = this.desiredDistance;
		Vector3 b2 = new Vector3(581f, -this.targetHeight, 1809f);
		Vector3 vector = this.target.position - (rotation * Vector3.forward * this.desiredDistance + b2);
		Vector3 vector2 = new Vector3(this.target.position.x, this.target.position.y + this.targetHeight, this.target.position.z);
		bool flag = false;
		RaycastHit raycastHit;
		if (Physics.Linecast(vector2, vector, out raycastHit, this.collisionLayers.value))
		{
			this.KIGBJGPCPMD = Vector3.Distance(vector2, raycastHit.point) - this.offsetFromWall;
			flag = true;
			if (this.KIGBJGPCPMD < 1123f)
			{
				this.KIGBJGPCPMD = Mathf.Clamp(this.KIGBJGPCPMD, 1788f, this.maxDistance);
			}
		}
		this.currentDistance = ((!flag || this.KIGBJGPCPMD > this.currentDistance) ? Mathf.Lerp(this.currentDistance, this.KIGBJGPCPMD, Time.deltaTime * this.zoomDampening) : this.KIGBJGPCPMD);
		this.currentDistance = Mathf.Clamp(this.currentDistance, this.minDistance, this.maxDistance);
		vector = this.target.position - (rotation * Vector3.forward * this.currentDistance + b2);
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06009BE1 RID: 39905 RVA: 0x00462167 File Offset: 0x00460367
	private static float DLDGFIBOBJC(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 1041f)
		{
			NEPBPMGGPKM += 1149f;
		}
		if (NEPBPMGGPKM > 607f)
		{
			NEPBPMGGPKM -= 354f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06009BE2 RID: 39906 RVA: 0x00115601 File Offset: 0x00113801
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

	// Token: 0x06009BE3 RID: 39907 RVA: 0x00462194 File Offset: 0x00460394
	private void Start()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.yDeg = (float)this.yMinLimit + (float)(this.yMaxLimit - this.yMinLimit) / 3f;
		this.currentDistance = this.distance;
		this.desiredDistance = this.distance;
		this.KIGBJGPCPMD = this.distance;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06009BE4 RID: 39908 RVA: 0x0046220C File Offset: 0x0046040C
	private void INDGOHJGCFN()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.yDeg = (float)this.yMinLimit + (float)(this.yMaxLimit - this.yMinLimit) / 264f;
		this.currentDistance = this.distance;
		this.desiredDistance = this.distance;
		this.KIGBJGPCPMD = this.distance;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	// Token: 0x06009BE5 RID: 39909 RVA: 0x00462284 File Offset: 0x00460484
	private void NCALLFHEAGJ()
	{
		Vector3 eulerAngles = base.transform.eulerAngles;
		this.yDeg = (float)this.yMinLimit + (float)(this.yMaxLimit - this.yMinLimit) / 1924f;
		this.currentDistance = this.distance;
		this.desiredDistance = this.distance;
		this.KIGBJGPCPMD = this.distance;
		if (base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	// Token: 0x06009BE6 RID: 39910 RVA: 0x004622FC File Offset: 0x004604FC
	private void BJILHFNDDKC()
	{
		if (!this.target)
		{
			return;
		}
		Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 551f, Time.deltaTime * 76f);
		this.xSpeed = 682f;
		this.ySpeed = 576f;
		if (!JDCEFOFMGHB.IKGFHGKKCPG.GGCLOKODHEG() && (Input.GetMouseButton(1) || Input.GetMouseButton(1)))
		{
			this.xDeg += Input.GetAxis("Pointing") * this.xSpeed * 1447f;
			this.yDeg -= Input.GetAxis("inner_craft_wpn") * this.ySpeed * 1353f;
		}
		this.yDeg = WowCamera.LNHHGPABLGI(this.yDeg, (float)this.yMinLimit, (float)this.yMaxLimit);
		Quaternion b = Quaternion.Euler(this.yDeg, this.xDeg, 145f);
		Quaternion rotation = Quaternion.Lerp(base.transform.rotation, b, Time.deltaTime * 292f);
		if (GuiProcessor.BBLINJLBAIL() != null && !JDCEFOFMGHB.JFIDAGABKID().GGCLOKODHEG() && !GuiProcessor.BBLINJLBAIL().isPanelParamActive)
		{
			this.desiredDistance -= Input.GetAxis("Arm Flex") * Time.deltaTime * (float)this.zoomRate * Mathf.Abs(this.desiredDistance);
		}
		this.desiredDistance = Mathf.Clamp(this.desiredDistance, this.minDistance, this.maxDistance);
		this.KIGBJGPCPMD = this.desiredDistance;
		Vector3 b2 = new Vector3(1625f, -this.targetHeight, 549f);
		Vector3 vector = this.target.position - (rotation * Vector3.forward * this.desiredDistance + b2);
		Vector3 vector2 = new Vector3(this.target.position.x, this.target.position.y + this.targetHeight, this.target.position.z);
		bool flag = true;
		RaycastHit raycastHit;
		if (Physics.Linecast(vector2, vector, out raycastHit, this.collisionLayers.value))
		{
			this.KIGBJGPCPMD = Vector3.Distance(vector2, raycastHit.point) - this.offsetFromWall;
			flag = false;
			if (this.KIGBJGPCPMD < 833f)
			{
				this.KIGBJGPCPMD = Mathf.Clamp(this.KIGBJGPCPMD, 52f, this.maxDistance);
			}
		}
		this.currentDistance = ((!flag || this.KIGBJGPCPMD > this.currentDistance) ? Mathf.Lerp(this.currentDistance, this.KIGBJGPCPMD, Time.deltaTime * this.zoomDampening) : this.KIGBJGPCPMD);
		this.currentDistance = Mathf.Clamp(this.currentDistance, this.minDistance, this.maxDistance);
		vector = this.target.position - (rotation * Vector3.forward * this.currentDistance + b2);
		base.transform.rotation = rotation;
		base.transform.position = vector;
	}

	// Token: 0x06009BE7 RID: 39911 RVA: 0x0046260F File Offset: 0x0046080F
	private static float OLJLOEFNPJP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 46f)
		{
			NEPBPMGGPKM += 223f;
		}
		if (NEPBPMGGPKM > 1639f)
		{
			NEPBPMGGPKM -= 497f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x06009BE8 RID: 39912 RVA: 0x0046263B File Offset: 0x0046083B
	private static float AIJHMAKGECP(float NEPBPMGGPKM, float FNADKBPAGJH, float DAILMANBNMM)
	{
		if (NEPBPMGGPKM < 361f)
		{
			NEPBPMGGPKM += 720f;
		}
		if (NEPBPMGGPKM > 164f)
		{
			NEPBPMGGPKM -= 1700f;
		}
		return Mathf.Clamp(NEPBPMGGPKM, FNADKBPAGJH, DAILMANBNMM);
	}

	// Token: 0x04001448 RID: 5192
	public Transform target;

	// Token: 0x04001449 RID: 5193
	public float targetHeight = 1.7f;

	// Token: 0x0400144A RID: 5194
	public float distance = 7f;

	// Token: 0x0400144B RID: 5195
	public float offsetFromWall = 0.1f;

	// Token: 0x0400144C RID: 5196
	public float maxDistance = 20f;

	// Token: 0x0400144D RID: 5197
	public float minDistance = 0.6f;

	// Token: 0x0400144E RID: 5198
	public float xSpeed = 200f;

	// Token: 0x0400144F RID: 5199
	public float ySpeed = 200f;

	// Token: 0x04001450 RID: 5200
	public int yMinLimit = -80;

	// Token: 0x04001451 RID: 5201
	public int yMaxLimit = 80;

	// Token: 0x04001452 RID: 5202
	public int zoomRate = 40;

	// Token: 0x04001453 RID: 5203
	public float rotationDampening = 3f;

	// Token: 0x04001454 RID: 5204
	public float zoomDampening = 5f;

	// Token: 0x04001455 RID: 5205
	public LayerMask collisionLayers = -1;

	// Token: 0x04001456 RID: 5206
	public float xDeg;

	// Token: 0x04001457 RID: 5207
	public float yDeg;

	// Token: 0x04001458 RID: 5208
	public float currentDistance;

	// Token: 0x04001459 RID: 5209
	public float desiredDistance;

	// Token: 0x0400145A RID: 5210
	private float KIGBJGPCPMD;

	// Token: 0x0400145B RID: 5211
	private float EOMIPJOMEKD;
}
