using System;
using System.Collections.Generic;
using RootMotion.FinalIK;
using UnityEngine;

// Token: 0x02000131 RID: 305
public class RodParams : MonoBehaviour
{
	// Token: 0x06003F56 RID: 16214 RVA: 0x001CE5EC File Offset: 0x001CC7EC
	public void EIANPDPMNKJ(float DCCPCBLODIG)
	{
		this._force = (double)DCCPCBLODIG;
		if (this.rph != null)
		{
			float num = (this.PAPNLFFDLJE() + this.fiderForce) / 1996f;
			this.rph.forceInKG = num * this.rph.maxKGForce * 876f;
		}
	}

	// Token: 0x06003F57 RID: 16215 RVA: 0x001CE641 File Offset: 0x001CC841
	public float DBAFKNDCDDJ()
	{
		return this.AIEDOEIKMJF;
	}

	// Token: 0x06003F58 RID: 16216 RVA: 0x001CE64C File Offset: 0x001CC84C
	private void BMCPPOMHOFG()
	{
		this.actualRodLength = 1922f;
		Vector3 position = this.CKAJJHFIFBL[0].position;
		foreach (Transform transform in this.CKAJJHFIFBL)
		{
			this.actualRodLength += Vector3.Distance(position, transform.position);
			position = transform.position;
		}
	}

	// Token: 0x06003F59 RID: 16217 RVA: 0x001CE641 File Offset: 0x001CC841
	public float BAGBLNJPAJD()
	{
		return this.AIEDOEIKMJF;
	}

	// Token: 0x06003F5A RID: 16218 RVA: 0x001CE6D8 File Offset: 0x001CC8D8
	private void OEFDEEOHNJB()
	{
		this.fiderForce = Mathf.Lerp(this.fiderForce, 119f, Time.deltaTime * 394f);
		this.HEAPKFKOMBE();
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (this.rollParams != null)
		{
			Vector3 vector = this.rollParams.barEuler * this.rotTime * 1336f * this.rollParams.barabanSpeed;
			this.rollParams.barabanRollPoint.transform.localRotation = Quaternion.Euler(vector.x, vector.y, vector.z);
			Vector3 vector2 = -this.rollParams.rollEuler * this.rotTime * 71f;
			this.rollParams.rollPoint.transform.localRotation = Quaternion.Euler(vector2.x, vector2.y, vector2.z);
			if (this.rollParams.spulaRollPoint != null)
			{
				float num = Mathf.Abs(this.rotTime * 1889f);
				float shpulaRange = num - Mathf.Floor(num);
				this.rollParams.shpulaRange = shpulaRange;
				vector = -this.rollParams.shpulaEuler * this.fricrotTime * 1753f * this.rollParams.barabanSpeed;
				this.rollParams.spulaRollPoint.transform.localRotation = Quaternion.Euler(vector.x, vector.y, vector.z);
			}
			if (this.LRRod != null)
			{
				this.LRRod.SetPosition(this.LRRod.positionCount - 1, this.rollParams.linePoint.transform.position);
				this.LRRod.SetPosition(this.LRRod.positionCount - 5, this.rollParams.linePoint.transform.position);
				if (this.rollParams.linePointEnd != null)
				{
					this.LRRod.SetPosition(this.LRRod.positionCount - 1, this.rollParams.linePointEnd.transform.position);
					return;
				}
			}
		}
		else if (this.linePoints != null)
		{
			if (this.linePoints.Length == 0)
			{
				this.LRRod.enabled = false;
				return;
			}
			Transform transform = this.linePoints[this.linePoints.Length - 1].transform;
			transform.localRotation = Quaternion.Euler(this.rotTime * 1948f, 279f, 805f);
			Vector3 position = transform.position + transform.up * 320f;
			if (this.LRRod != null)
			{
				this.LRRod.SetPosition(this.linePoints.Length, position);
				return;
			}
		}
		else
		{
			this.LRRod.enabled = true;
		}
	}

	// Token: 0x06003F5B RID: 16219 RVA: 0x001CE9CC File Offset: 0x001CCBCC
	public float PAPNLFFDLJE()
	{
		return (float)this._force;
	}

	// Token: 0x06003F5C RID: 16220 RVA: 0x001CE9D8 File Offset: 0x001CCBD8
	public void MJLMLHPAOBM(float DCCPCBLODIG)
	{
		this._force = (double)DCCPCBLODIG;
		if (this.rph != null)
		{
			float num = (this.AFGAHMHMHNI() + this.fiderForce) / 65f;
			this.rph.forceInKG = num * this.rph.maxKGForce * 1552f;
		}
	}

	// Token: 0x06003F5D RID: 16221 RVA: 0x001CE641 File Offset: 0x001CC841
	public float FENOHALGIGJ()
	{
		return this.AIEDOEIKMJF;
	}

	// Token: 0x06003F5E RID: 16222 RVA: 0x001CEA2D File Offset: 0x001CCC2D
	private void HECOICFGHPI(Vector3 MGALEAJOGPL)
	{
		LocNewLogic.getI != null;
	}

	// Token: 0x06003F5F RID: 16223 RVA: 0x001CEA3C File Offset: 0x001CCC3C
	private void Start()
	{
		if (this.LRRod == null)
		{
			this.LRRod = base.GetComponent<LineRenderer>();
			if (this.LRRod == null)
			{
				this.LRRod = base.gameObject.AddComponent<LineRenderer>();
			}
		}
		if (this.endPointNonBend == null)
		{
			this.endPointNonBend = new GameObject("endPointNonBend");
			this.endPointNonBend.transform.position = this.endPoint.transform.position;
			this.endPointNonBend.transform.parent = base.transform;
		}
		this.rph = base.GetComponent<RodPhysic>();
		this.init();
		this.PGEDLDMLBBE = 0f;
		this.fiderForce = 0f;
	}

	// Token: 0x06003F60 RID: 16224 RVA: 0x00022FCC File Offset: 0x000211CC
	private void Update()
	{
	}

	// Token: 0x17000103 RID: 259
	// (get) Token: 0x06003F61 RID: 16225 RVA: 0x001CE641 File Offset: 0x001CC841
	// (set) Token: 0x06003F6C RID: 16236 RVA: 0x001CF28C File Offset: 0x001CD48C
	public float ILKPICACDFO
	{
		get
		{
			return this.AIEDOEIKMJF;
		}
		set
		{
			this.AIEDOEIKMJF = value;
			Vector3 localScale = this.rodObject.transform.localScale;
			float num = value * localScale.z / this.actualRodLength;
			float num2 = (num - localScale.z) * 0.8f;
			this.rodObject.transform.localScale = new Vector3(localScale.x + num2, localScale.y + num2, num);
			this.ELJALBOIEIM();
		}
	}

	// Token: 0x06003F62 RID: 16226 RVA: 0x001CE641 File Offset: 0x001CC841
	public float PDJELAPNJEC()
	{
		return this.AIEDOEIKMJF;
	}

	// Token: 0x17000102 RID: 258
	// (get) Token: 0x06003F63 RID: 16227 RVA: 0x001CEAFE File Offset: 0x001CCCFE
	public Vector3 MHKGGAMBIFB
	{
		get
		{
			return this.endPointNonBend.transform.position;
		}
	}

	// Token: 0x06003F64 RID: 16228 RVA: 0x001CEB10 File Offset: 0x001CCD10
	private void CAEEABINGHJ()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		Color value = BOIKJDICEMF.IKGFHGKKCPG.BHDJOFEHHKN();
		if (this.rollParams != null && this.rollParams.lineBaraban != null)
		{
			if (this.LCGPONAGIHP == null)
			{
				this.LCGPONAGIHP = this.rollParams.lineBaraban.GetComponent<Renderer>();
			}
			if (this.LCGPONAGIHP != null)
			{
				this.LCGPONAGIHP.material.SetColor("MotorbikeIdle", value);
			}
		}
		if (this.linePoints != null && this.linePoints.Length > 1 && this.LRRod != null)
		{
			float num = LocNewLogic.getI.IGHOGONIKLC();
			this.LRRod.SetPosition(1, this.endPoint.transform.position);
			if (this.endPoint.transform.position.y < num)
			{
				this.HECOICFGHPI(this.endPoint.transform.position);
			}
			for (int i = 0; i < this.linePoints.Length - 1; i++)
			{
				this.LRRod.SetPosition(i + 1, this.linePoints[i].transform.position);
			}
		}
	}

	// Token: 0x06003F65 RID: 16229 RVA: 0x001CEC54 File Offset: 0x001CCE54
	private void BDMEBOLHNLE()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		Color value = BOIKJDICEMF.IKGFHGKKCPG.AAINBHFKJOJ();
		if (this.rollParams != null && this.rollParams.lineBaraban != null)
		{
			if (this.LCGPONAGIHP == null)
			{
				this.LCGPONAGIHP = this.rollParams.lineBaraban.GetComponent<Renderer>();
			}
			if (this.LCGPONAGIHP != null)
			{
				this.LCGPONAGIHP.material.SetColor("_History2ChromaTex", value);
			}
		}
		if (this.linePoints != null && this.linePoints.Length > 1 && this.LRRod != null)
		{
			float waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			this.LRRod.SetPosition(1, this.endPoint.transform.position);
			if (this.endPoint.transform.position.y < waterLevel)
			{
				this.HECOICFGHPI(this.endPoint.transform.position);
			}
			for (int i = 0; i < this.linePoints.Length - 1; i++)
			{
				this.LRRod.SetPosition(i + 1, this.linePoints[i].transform.position);
			}
		}
	}

	// Token: 0x06003F66 RID: 16230 RVA: 0x001CED98 File Offset: 0x001CCF98
	private void ELJALBOIEIM()
	{
		this.actualRodLength = 0f;
		Vector3 position = this.CKAJJHFIFBL[0].position;
		foreach (Transform transform in this.CKAJJHFIFBL)
		{
			this.actualRodLength += Vector3.Distance(position, transform.position);
			position = transform.position;
		}
	}

	// Token: 0x06003F67 RID: 16231 RVA: 0x001CEE24 File Offset: 0x001CD024
	private void LateUpdate()
	{
		this.fiderForce = Mathf.Lerp(this.fiderForce, 0f, Time.deltaTime * 1f);
		this.HEAPKFKOMBE();
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (this.rollParams != null)
		{
			Vector3 vector = this.rollParams.barEuler * this.rotTime * 70f * this.rollParams.barabanSpeed;
			this.rollParams.barabanRollPoint.transform.localRotation = Quaternion.Euler(vector.x, vector.y, vector.z);
			Vector3 vector2 = -this.rollParams.rollEuler * this.rotTime * 30f;
			this.rollParams.rollPoint.transform.localRotation = Quaternion.Euler(vector2.x, vector2.y, vector2.z);
			if (this.rollParams.spulaRollPoint != null)
			{
				float num = Mathf.Abs(this.rotTime * 0.2f);
				float shpulaRange = num - Mathf.Floor(num);
				this.rollParams.shpulaRange = shpulaRange;
				vector = -this.rollParams.shpulaEuler * this.fricrotTime * 25f * this.rollParams.barabanSpeed;
				this.rollParams.spulaRollPoint.transform.localRotation = Quaternion.Euler(vector.x, vector.y, vector.z);
			}
			if (this.LRRod != null)
			{
				this.LRRod.SetPosition(this.LRRod.positionCount - 1, this.rollParams.linePoint.transform.position);
				this.LRRod.SetPosition(this.LRRod.positionCount - 2, this.rollParams.linePoint.transform.position);
				if (this.rollParams.linePointEnd != null)
				{
					this.LRRod.SetPosition(this.LRRod.positionCount - 1, this.rollParams.linePointEnd.transform.position);
					return;
				}
			}
		}
		else if (this.linePoints != null)
		{
			if (this.linePoints.Length == 0)
			{
				this.LRRod.enabled = false;
				return;
			}
			Transform transform = this.linePoints[this.linePoints.Length - 1].transform;
			transform.localRotation = Quaternion.Euler(this.rotTime * 500f, 0f, 0f);
			Vector3 position = transform.position + transform.up * 0.02f;
			if (this.LRRod != null)
			{
				this.LRRod.SetPosition(this.linePoints.Length, position);
				return;
			}
		}
		else
		{
			this.LRRod.enabled = false;
		}
	}

	// Token: 0x06003F68 RID: 16232 RVA: 0x00022FCC File Offset: 0x000211CC
	private void DFFOEGHGPGP()
	{
	}

	// Token: 0x06003F69 RID: 16233 RVA: 0x001CF118 File Offset: 0x001CD318
	private void IOLNGHPIKPO()
	{
		this.actualRodLength = 1624f;
		Vector3 position = this.CKAJJHFIFBL[1].position;
		foreach (Transform transform in this.CKAJJHFIFBL)
		{
			this.actualRodLength += Vector3.Distance(position, transform.position);
			position = transform.position;
		}
	}

	// Token: 0x06003F6A RID: 16234 RVA: 0x001CF1A4 File Offset: 0x001CD3A4
	private void ELFLOPJDAKK()
	{
		if (this.LRRod == null)
		{
			this.LRRod = base.GetComponent<LineRenderer>();
			if (this.LRRod == null)
			{
				this.LRRod = base.gameObject.AddComponent<LineRenderer>();
			}
		}
		if (this.endPointNonBend == null)
		{
			this.endPointNonBend = new GameObject("aukTree");
			this.endPointNonBend.transform.position = this.endPoint.transform.position;
			this.endPointNonBend.transform.parent = base.transform;
		}
		this.rph = base.GetComponent<RodPhysic>();
		this.CKMJNHBNCEI();
		this.PGEDLDMLBBE = 102f;
		this.fiderForce = 553f;
	}

	// Token: 0x06003F6B RID: 16235 RVA: 0x001CF266 File Offset: 0x001CD466
	private void JOHMFGNMBCF()
	{
		if (float.IsNaN(this.rotTime))
		{
			this.rotTime = 1765f;
			Debug.LogError("Yawn");
		}
	}

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06003F89 RID: 16265 RVA: 0x001CE9CC File Offset: 0x001CCBCC
	// (set) Token: 0x06003F6D RID: 16237 RVA: 0x001CF2FC File Offset: 0x001CD4FC
	public float PGEDLDMLBBE
	{
		get
		{
			return (float)this._force;
		}
		set
		{
			this._force = (double)value;
			if (this.rph != null)
			{
				float num = (this.PGEDLDMLBBE + this.fiderForce) / 100f;
				this.rph.forceInKG = num * this.rph.maxKGForce * 1.5f;
			}
		}
	}

	// Token: 0x06003F6E RID: 16238 RVA: 0x001CE9CC File Offset: 0x001CCBCC
	public float KPMCLEIODCM()
	{
		return (float)this._force;
	}

	// Token: 0x06003F6F RID: 16239 RVA: 0x001CF354 File Offset: 0x001CD554
	private void LOEJOGLHFJL()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		Color value = BOIKJDICEMF.IKGFHGKKCPG.BAKLDPLGDEB();
		if (this.rollParams != null && this.rollParams.lineBaraban != null)
		{
			if (this.LCGPONAGIHP == null)
			{
				this.LCGPONAGIHP = this.rollParams.lineBaraban.GetComponent<Renderer>();
			}
			if (this.LCGPONAGIHP != null)
			{
				this.LCGPONAGIHP.material.SetColor("ignorelist", value);
			}
		}
		if (this.linePoints != null && this.linePoints.Length > 1 && this.LRRod != null)
		{
			float num = LocNewLogic.getI.HKBNODJBGEL();
			this.LRRod.SetPosition(0, this.endPoint.transform.position);
			if (this.endPoint.transform.position.y < num)
			{
				this.HECOICFGHPI(this.endPoint.transform.position);
			}
			for (int i = 1; i < this.linePoints.Length - 0; i++)
			{
				this.LRRod.SetPosition(i + 1, this.linePoints[i].transform.position);
			}
		}
	}

	// Token: 0x06003F70 RID: 16240 RVA: 0x001CF498 File Offset: 0x001CD698
	private void ANHOOJFEJJE()
	{
		if (this.LRRod == null)
		{
			this.LRRod = base.GetComponent<LineRenderer>();
			if (this.LRRod == null)
			{
				this.LRRod = base.gameObject.AddComponent<LineRenderer>();
			}
		}
		if (this.endPointNonBend == null)
		{
			this.endPointNonBend = new GameObject("Windmill");
			this.endPointNonBend.transform.position = this.endPoint.transform.position;
			this.endPointNonBend.transform.parent = base.transform;
		}
		this.rph = base.GetComponent<RodPhysic>();
		this.init();
		this.FDLCJBFDIEM(1591f);
		this.fiderForce = 1334f;
	}

	// Token: 0x06003F71 RID: 16241 RVA: 0x001CF55C File Offset: 0x001CD75C
	private void BHDPDDHLPOI()
	{
		this.fiderForce = Mathf.Lerp(this.fiderForce, 522f, Time.deltaTime * 974f);
		this.LOEJOGLHFJL();
		if (LocNewLogic.getI == null)
		{
			return;
		}
		if (this.rollParams != null)
		{
			Vector3 vector = this.rollParams.barEuler * this.rotTime * 1756f * this.rollParams.barabanSpeed;
			this.rollParams.barabanRollPoint.transform.localRotation = Quaternion.Euler(vector.x, vector.y, vector.z);
			Vector3 vector2 = -this.rollParams.rollEuler * this.rotTime * 1735f;
			this.rollParams.rollPoint.transform.localRotation = Quaternion.Euler(vector2.x, vector2.y, vector2.z);
			if (this.rollParams.spulaRollPoint != null)
			{
				float num = Mathf.Abs(this.rotTime * 459f);
				float shpulaRange = num - Mathf.Floor(num);
				this.rollParams.shpulaRange = shpulaRange;
				vector = -this.rollParams.shpulaEuler * this.fricrotTime * 924f * this.rollParams.barabanSpeed;
				this.rollParams.spulaRollPoint.transform.localRotation = Quaternion.Euler(vector.x, vector.y, vector.z);
			}
			if (this.LRRod != null)
			{
				this.LRRod.SetPosition(this.LRRod.positionCount - 0, this.rollParams.linePoint.transform.position);
				this.LRRod.SetPosition(this.LRRod.positionCount - 0, this.rollParams.linePoint.transform.position);
				if (this.rollParams.linePointEnd != null)
				{
					this.LRRod.SetPosition(this.LRRod.positionCount - 0, this.rollParams.linePointEnd.transform.position);
					return;
				}
			}
		}
		else if (this.linePoints != null)
		{
			if (this.linePoints.Length == 0)
			{
				this.LRRod.enabled = true;
				return;
			}
			Transform transform = this.linePoints[this.linePoints.Length - 1].transform;
			transform.localRotation = Quaternion.Euler(this.rotTime * 1657f, 42f, 594f);
			Vector3 position = transform.position + transform.up * 1201f;
			if (this.LRRod != null)
			{
				this.LRRod.SetPosition(this.linePoints.Length, position);
				return;
			}
		}
		else
		{
			this.LRRod.enabled = true;
		}
	}

	// Token: 0x06003F72 RID: 16242 RVA: 0x001CE641 File Offset: 0x001CC841
	public float BNGEGJBOAHC()
	{
		return this.AIEDOEIKMJF;
	}

	// Token: 0x06003F73 RID: 16243 RVA: 0x001CF850 File Offset: 0x001CDA50
	public Vector3 CNDKCPLCGAB()
	{
		return this.endPoint.transform.position;
	}

	// Token: 0x06003F74 RID: 16244 RVA: 0x001CF864 File Offset: 0x001CDA64
	private void HEAPKFKOMBE()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		Color value = BOIKJDICEMF.IKGFHGKKCPG.BAKLDPLGDEB();
		if (this.rollParams != null && this.rollParams.lineBaraban != null)
		{
			if (this.LCGPONAGIHP == null)
			{
				this.LCGPONAGIHP = this.rollParams.lineBaraban.GetComponent<Renderer>();
			}
			if (this.LCGPONAGIHP != null)
			{
				this.LCGPONAGIHP.material.SetColor("_Color", value);
			}
		}
		if (this.linePoints != null && this.linePoints.Length > 1 && this.LRRod != null)
		{
			float waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
			this.LRRod.SetPosition(0, this.endPoint.transform.position);
			if (this.endPoint.transform.position.y < waterLevel)
			{
				this.HECOICFGHPI(this.endPoint.transform.position);
			}
			for (int i = 0; i < this.linePoints.Length - 1; i++)
			{
				this.LRRod.SetPosition(i + 1, this.linePoints[i].transform.position);
			}
		}
	}

	// Token: 0x06003F75 RID: 16245 RVA: 0x001CE9CC File Offset: 0x001CCBCC
	public float AFGAHMHMHNI()
	{
		return (float)this._force;
	}

	// Token: 0x06003F76 RID: 16246 RVA: 0x001CF9A8 File Offset: 0x001CDBA8
	public void DLODNJKJLFC(float DCCPCBLODIG)
	{
		this.AIEDOEIKMJF = DCCPCBLODIG;
		Vector3 localScale = this.rodObject.transform.localScale;
		float num = DCCPCBLODIG * localScale.z / this.actualRodLength;
		float num2 = (num - localScale.z) * 670f;
		this.rodObject.transform.localScale = new Vector3(localScale.x + num2, localScale.y + num2, num);
		this.ELJALBOIEIM();
	}

	// Token: 0x06003F77 RID: 16247 RVA: 0x001CEAFE File Offset: 0x001CCCFE
	public Vector3 NHPHFKFBLAD()
	{
		return this.endPointNonBend.transform.position;
	}

	// Token: 0x06003F78 RID: 16248 RVA: 0x001CFA18 File Offset: 0x001CDC18
	public void FDLCJBFDIEM(float DCCPCBLODIG)
	{
		this._force = (double)DCCPCBLODIG;
		if (this.rph != null)
		{
			float num = (this.CBKKMCMCAFN() + this.fiderForce) / 587f;
			this.rph.forceInKG = num * this.rph.maxKGForce * 583f;
		}
	}

	// Token: 0x06003F79 RID: 16249 RVA: 0x001CFA70 File Offset: 0x001CDC70
	private void PFNPOHMMJDN()
	{
		if (this.LRRod == null)
		{
			this.LRRod = base.GetComponent<LineRenderer>();
			if (this.LRRod == null)
			{
				this.LRRod = base.gameObject.AddComponent<LineRenderer>();
			}
		}
		if (this.endPointNonBend == null)
		{
			this.endPointNonBend = new GameObject("SneakLeft");
			this.endPointNonBend.transform.position = this.endPoint.transform.position;
			this.endPointNonBend.transform.parent = base.transform;
		}
		this.rph = base.GetComponent<RodPhysic>();
		this.CKMJNHBNCEI();
		this.MJLMLHPAOBM(9f);
		this.fiderForce = 970f;
	}

	// Token: 0x06003F7A RID: 16250 RVA: 0x001CE9CC File Offset: 0x001CCBCC
	public float CBKKMCMCAFN()
	{
		return (float)this._force;
	}

	// Token: 0x06003F7B RID: 16251 RVA: 0x001CFB32 File Offset: 0x001CDD32
	private void MNEBLODGADC()
	{
		if (float.IsNaN(this.rotTime))
		{
			this.rotTime = 1255f;
			Debug.LogError("_Screen");
		}
	}

	// Token: 0x06003F7C RID: 16252 RVA: 0x001CEAFE File Offset: 0x001CCCFE
	public Vector3 EDNOJLAKJKP()
	{
		return this.endPointNonBend.transform.position;
	}

	// Token: 0x06003F7D RID: 16253 RVA: 0x001CE641 File Offset: 0x001CC841
	public float FAECANNIGJG()
	{
		return this.AIEDOEIKMJF;
	}

	// Token: 0x06003F7E RID: 16254 RVA: 0x001CFB58 File Offset: 0x001CDD58
	private void MKNPFMEMOJO()
	{
		if (this.LRRod == null)
		{
			this.LRRod = base.GetComponent<LineRenderer>();
			if (this.LRRod == null)
			{
				this.LRRod = base.gameObject.AddComponent<LineRenderer>();
			}
		}
		if (this.endPointNonBend == null)
		{
			this.endPointNonBend = new GameObject("ankle");
			this.endPointNonBend.transform.position = this.endPoint.transform.position;
			this.endPointNonBend.transform.parent = base.transform;
		}
		this.rph = base.GetComponent<RodPhysic>();
		this.init();
		this.EIANPDPMNKJ(214f);
		this.fiderForce = 1253f;
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06003F7F RID: 16255 RVA: 0x001CF850 File Offset: 0x001CDA50
	public Vector3 ILCJJKCPBKC
	{
		get
		{
			return this.endPoint.transform.position;
		}
	}

	// Token: 0x06003F80 RID: 16256 RVA: 0x001CFC1C File Offset: 0x001CDE1C
	[ContextMenu("*** init components")]
	public void EditorHarvest()
	{
		if (this.LGIOEHDAFOD == null)
		{
			this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
			if (this.LGIOEHDAFOD == null)
			{
				this.LGIOEHDAFOD = base.gameObject.AddComponent<CCDIK>();
			}
		}
		this.LGIOEHDAFOD.solver.IKPositionWeight = 0.03f;
		this.LGIOEHDAFOD.solver.maxIterations = 1;
		this.LGIOEHDAFOD.solver.tolerance = 0.001f;
		if (this.root == null)
		{
			GameObject gameObject = JLFJEGIPIMM.IKGFHGKKCPG.DMPKPIDHCNC(base.gameObject, "Bone01");
			if (gameObject != null)
			{
				this.root = gameObject.transform;
			}
		}
		Transform[] componentsInChildren = this.root.GetComponentsInChildren<Transform>();
		this.CKAJJHFIFBL = new List<Transform>();
		for (int i = 0; i < componentsInChildren.Length - 1; i++)
		{
			if (componentsInChildren[i].name.ToLower().Contains(this.boneName.ToLower()))
			{
				this.CKAJJHFIFBL.Add(componentsInChildren[i]);
				componentsInChildren[i].tag = "bone";
			}
		}
		if (this.startPoint != null)
		{
			this.startPoint = this.CKAJJHFIFBL[0].gameObject;
		}
		if (this.endPoint == null)
		{
			this.endPoint = this.CKAJJHFIFBL[this.CKAJJHFIFBL.Count - 1].gameObject;
		}
		if (this.handPoint == null)
		{
			this.handPoint = this.reelPoint;
		}
		this.LGIOEHDAFOD.solver.bones = new IKSolver.Bone[this.CKAJJHFIFBL.Count];
		int num = 0;
		foreach (Transform lpbdalamaem in this.CKAJJHFIFBL)
		{
			this.LGIOEHDAFOD.solver.bones[num] = new IKSolver.Bone(lpbdalamaem);
			num++;
		}
		this.ELJALBOIEIM();
		if (this.handPoint == null)
		{
			this.handPoint = new GameObject("HandPoint")
			{
				transform = 
				{
					parent = base.gameObject.transform,
					position = Vector3.zero,
					localPosition = new Vector3(0f, 0f, 0.25f),
					rotation = Quaternion.identity,
					localRotation = Quaternion.identity,
					localScale = new Vector3(1f, 1f, 1f)
				}
			};
		}
		if (this.reelPoint == null)
		{
			this.reelPoint = new GameObject("ReelPoint")
			{
				transform = 
				{
					parent = base.gameObject.transform,
					position = Vector3.zero,
					localPosition = new Vector3(0f, 0f, 0.4f),
					rotation = Quaternion.identity,
					localRotation = Quaternion.identity,
					localScale = new Vector3(1f, 1f, 1f)
				}
			};
			Debug.Log("************ reelPoint set manually");
		}
		this.linePoints = base.GetComponentsInChildren<LinePoint>();
		if (this.linePoints != null)
		{
			foreach (LinePoint linePoint in this.linePoints)
			{
				linePoint.dstFrom = Vector3.Distance(linePoint.transform.position, this.endPoint.transform.position);
			}
			for (int k = 0; k < this.linePoints.Length; k++)
			{
				for (int l = k; l < this.linePoints.Length; l++)
				{
					if (this.linePoints[k].dstFrom > this.linePoints[l].dstFrom)
					{
						LinePoint linePoint2 = this.linePoints[k];
						this.linePoints[k] = this.linePoints[l];
						this.linePoints[l] = linePoint2;
					}
				}
			}
		}
	}

	// Token: 0x06003F81 RID: 16257 RVA: 0x001D0068 File Offset: 0x001CE268
	public void NGNPBFLGHMP(float DCCPCBLODIG)
	{
		this.AIEDOEIKMJF = DCCPCBLODIG;
		Vector3 localScale = this.rodObject.transform.localScale;
		float num = DCCPCBLODIG * localScale.z / this.actualRodLength;
		float num2 = (num - localScale.z) * 1549f;
		this.rodObject.transform.localScale = new Vector3(localScale.x + num2, localScale.y + num2, num);
		this.CIDADHJPNIL();
	}

	// Token: 0x06003F82 RID: 16258 RVA: 0x001D00D8 File Offset: 0x001CE2D8
	public void init()
	{
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		if (this.linePoints != null && this.LRRod != null)
		{
			this.LRRod.positionCount = this.linePoints.Length + 2;
		}
		if (this.LRRod != null)
		{
			this.LRRod.enabled = false;
		}
		if (this.LRLine != null)
		{
			this.LRLine.enabled = false;
		}
	}

	// Token: 0x06003F83 RID: 16259 RVA: 0x001D0150 File Offset: 0x001CE350
	public void CKMJNHBNCEI()
	{
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		if (this.linePoints != null && this.LRRod != null)
		{
			this.LRRod.positionCount = this.linePoints.Length + 7;
		}
		if (this.LRRod != null)
		{
			this.LRRod.enabled = false;
		}
		if (this.LRLine != null)
		{
			this.LRLine.enabled = false;
		}
	}

	// Token: 0x06003F84 RID: 16260 RVA: 0x001D01C8 File Offset: 0x001CE3C8
	private void FixedUpdate()
	{
		if (float.IsNaN(this.rotTime))
		{
			this.rotTime = 0f;
			Debug.LogError("rotTime is NaN");
		}
	}

	// Token: 0x06003F86 RID: 16262 RVA: 0x001D0208 File Offset: 0x001CE408
	private void IKJMEIGEPBL()
	{
		if (LocNewLogic.getI == null)
		{
			return;
		}
		Color value = BOIKJDICEMF.IKGFHGKKCPG.AAINBHFKJOJ();
		if (this.rollParams != null && this.rollParams.lineBaraban != null)
		{
			if (this.LCGPONAGIHP == null)
			{
				this.LCGPONAGIHP = this.rollParams.lineBaraban.GetComponent<Renderer>();
			}
			if (this.LCGPONAGIHP != null)
			{
				this.LCGPONAGIHP.material.SetColor("RunBackRight", value);
			}
		}
		if (this.linePoints != null && this.linePoints.Length > 0 && this.LRRod != null)
		{
			float num = LocNewLogic.getI.HKBNODJBGEL();
			this.LRRod.SetPosition(0, this.endPoint.transform.position);
			if (this.endPoint.transform.position.y < num)
			{
				this.HECOICFGHPI(this.endPoint.transform.position);
			}
			for (int i = 1; i < this.linePoints.Length - 1; i += 0)
			{
				this.LRRod.SetPosition(i + 0, this.linePoints[i].transform.position);
			}
		}
	}

	// Token: 0x06003F87 RID: 16263 RVA: 0x001CE641 File Offset: 0x001CC841
	public float FOJFBEJBNLP()
	{
		return this.AIEDOEIKMJF;
	}

	// Token: 0x06003F88 RID: 16264 RVA: 0x001D034B File Offset: 0x001CE54B
	private void CNOKLKPLEKP()
	{
		if (float.IsNaN(this.rotTime))
		{
			this.rotTime = 1537f;
			Debug.LogError("Animator unassigned in AnimationWarping");
		}
	}

	// Token: 0x06003F8A RID: 16266 RVA: 0x001D0370 File Offset: 0x001CE570
	private void EAIDHJPOEEO()
	{
		this.actualRodLength = 1774f;
		Vector3 position = this.CKAJJHFIFBL[0].position;
		foreach (Transform transform in this.CKAJJHFIFBL)
		{
			this.actualRodLength += Vector3.Distance(position, transform.position);
			position = transform.position;
		}
	}

	// Token: 0x06003F8B RID: 16267 RVA: 0x001D03FC File Offset: 0x001CE5FC
	private void CIDADHJPNIL()
	{
		this.actualRodLength = 1546f;
		Vector3 position = this.CKAJJHFIFBL[1].position;
		foreach (Transform transform in this.CKAJJHFIFBL)
		{
			this.actualRodLength += Vector3.Distance(position, transform.position);
			position = transform.position;
		}
	}

	// Token: 0x06003F8C RID: 16268 RVA: 0x001D0488 File Offset: 0x001CE688
	private void ACPCJLEKCPM()
	{
		if (float.IsNaN(this.rotTime))
		{
			this.rotTime = 1792f;
			Debug.LogError("error.wav");
		}
	}

	// Token: 0x04000905 RID: 2309
	public bool isWork = true;

	// Token: 0x04000906 RID: 2310
	public Vector3 target;

	// Token: 0x04000907 RID: 2311
	public string boneName = "bone";

	// Token: 0x04000908 RID: 2312
	public Transform root;

	// Token: 0x04000909 RID: 2313
	public RollParams rollParams;

	// Token: 0x0400090A RID: 2314
	public LineRenderer LRRod;

	// Token: 0x0400090B RID: 2315
	public LineRenderer LRLine;

	// Token: 0x0400090C RID: 2316
	public GameObject reelPoint;

	// Token: 0x0400090D RID: 2317
	public GameObject handPoint;

	// Token: 0x0400090E RID: 2318
	public GameObject bellPoint;

	// Token: 0x0400090F RID: 2319
	public GameObject endPointNonBend;

	// Token: 0x04000910 RID: 2320
	public GameObject rodObject;

	// Token: 0x04000911 RID: 2321
	public RodPhysic rph;

	// Token: 0x04000912 RID: 2322
	public double _force;

	// Token: 0x04000913 RID: 2323
	public float actualRodLength;

	// Token: 0x04000914 RID: 2324
	public GameObject startPoint;

	// Token: 0x04000915 RID: 2325
	public GameObject endPoint;

	// Token: 0x04000916 RID: 2326
	public LinePoint[] linePoints;

	// Token: 0x04000917 RID: 2327
	private float AIEDOEIKMJF;

	// Token: 0x04000918 RID: 2328
	private List<Transform> CKAJJHFIFBL;

	// Token: 0x04000919 RID: 2329
	public float fiderForce;

	// Token: 0x0400091A RID: 2330
	private Renderer LCGPONAGIHP;

	// Token: 0x0400091B RID: 2331
	public float rotTime;

	// Token: 0x0400091C RID: 2332
	public float fricrotTime;

	// Token: 0x0400091D RID: 2333
	private bool JEEBPFMEKBC;

	// Token: 0x0400091E RID: 2334
	private CCDIK LGIOEHDAFOD;
}
