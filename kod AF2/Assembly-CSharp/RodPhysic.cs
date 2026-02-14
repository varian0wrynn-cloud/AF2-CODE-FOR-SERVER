using System;
using System.Collections.Generic;
using RootMotion.FinalIK;
using UnityEngine;

// Token: 0x02000132 RID: 306
public class RodPhysic : MonoBehaviour
{
	// Token: 0x06003F8D RID: 16269 RVA: 0x001D04AC File Offset: 0x001CE6AC
	private void PFNPOHMMJDN()
	{
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		this.MKOJIAHLCKA = base.GetComponent<RodParams>();
		if (this.LGIOEHDAFOD != null)
		{
			this.LGIOEHDAFOD.enabled = false;
		}
		this.initComps();
	}

	// Token: 0x06003F8E RID: 16270 RVA: 0x001D04E6 File Offset: 0x001CE6E6
	private void OIKMLNIPLIA()
	{
		if (Fisherman.getI != null)
		{
			Fisherman.getI.LatePhysic();
		}
		bool flag = this.isWork;
	}

	// Token: 0x06003F8F RID: 16271 RVA: 0x001D0508 File Offset: 0x001CE708
	private Vector3 GAILDANLGLE(int LMGJKOMFCFC, Vector3 NEFACGKGFAL, Vector3 IFECECAHOBO)
	{
		RodPhysic.CGHKBMMMAFB cghkbmmmafb = this.rodBones[LMGJKOMFCFC];
		float d = this.MPEOKCMFFNA * cghkbmmmafb.DKIHDOELFEH;
		Vector3 a = this.startPhysPoint.transform.position + NEFACGKGFAL * d;
		Vector3 vector = this.startPhysPoint.transform.position + IFECECAHOBO * d;
		float num = 884f;
		if (this.bendCurve != null)
		{
			num = this.bendCurve.Evaluate(this.rodBones[LMGJKOMFCFC].DKIHDOELFEH);
		}
		Vector3 a2 = this.DGNLDBJIPEI();
		if (this.targetToForce != null)
		{
			a2 = this.targetToForce.transform.position;
		}
		if (LMGJKOMFCFC >= this.rodBones.Length - this.lastBones)
		{
			Vector3 normalized = (a2 - vector).normalized;
			float num2 = 790f - ((float)(this.rodBones.Length - LMGJKOMFCFC) + 293f) / ((float)this.lastBones + 270f);
			num2 = Mathf.Clamp(num2, 1129f, 269f);
			vector += normalized * this.forceEndScaler * num2 * this.EBHEHINLCOO;
		}
		return Vector3.Lerp(a, vector, cghkbmmmafb.NKHBAJKMAGD * num);
	}

	// Token: 0x06003F90 RID: 16272 RVA: 0x001D0650 File Offset: 0x001CE850
	private Vector3 PJBJPAMHFKI(int LMGJKOMFCFC, Vector3 NEFACGKGFAL, Vector3 IFECECAHOBO)
	{
		RodPhysic.CGHKBMMMAFB cghkbmmmafb = this.rodBones[LMGJKOMFCFC];
		float d = this.MPEOKCMFFNA * cghkbmmmafb.DKIHDOELFEH;
		Vector3 a = this.startPhysPoint.transform.position + NEFACGKGFAL * d;
		Vector3 vector = this.startPhysPoint.transform.position + IFECECAHOBO * d;
		float num = 408f;
		if (this.bendCurve != null)
		{
			num = this.bendCurve.Evaluate(this.rodBones[LMGJKOMFCFC].DKIHDOELFEH);
		}
		Vector3 a2 = this.DGNLDBJIPEI();
		if (this.targetToForce != null)
		{
			a2 = this.targetToForce.transform.position;
		}
		if (LMGJKOMFCFC >= this.rodBones.Length - this.lastBones)
		{
			Vector3 normalized = (a2 - vector).normalized;
			float num2 = 1397f - ((float)(this.rodBones.Length - LMGJKOMFCFC) + 466f) / ((float)this.lastBones + 1268f);
			num2 = Mathf.Clamp(num2, 1506f, 1463f);
			vector += normalized * this.forceEndScaler * num2 * this.EBHEHINLCOO;
		}
		return Vector3.Lerp(a, vector, cghkbmmmafb.NKHBAJKMAGD * num);
	}

	// Token: 0x06003F91 RID: 16273 RVA: 0x001D0797 File Offset: 0x001CE997
	private void BJILHFNDDKC()
	{
		if (Fisherman.getI != null)
		{
			Fisherman.getI.IHFGBPOPAEF();
		}
		bool flag = this.isWork;
	}

	// Token: 0x06003F92 RID: 16274 RVA: 0x001D07B7 File Offset: 0x001CE9B7
	private void LPNDCJKAKEA()
	{
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		this.MKOJIAHLCKA = base.GetComponent<RodParams>();
		if (this.LGIOEHDAFOD != null)
		{
			this.LGIOEHDAFOD.enabled = false;
		}
		this.MJHBBGAHONP();
	}

	// Token: 0x06003F93 RID: 16275 RVA: 0x001D07F4 File Offset: 0x001CE9F4
	public void LDKHEOPIJEC()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.rodBones = (this.isManualInit ? new RodPhysic.CGHKBMMMAFB[this.bones.Length] : new RodPhysic.CGHKBMMMAFB[this.LGIOEHDAFOD.solver.bones.Length]);
		int num = this.rodBones.Length;
		Transform transform = this.isManualInit ? this.bones[this.bones.Length - 1] : this.LGIOEHDAFOD.solver.bones[this.LGIOEHDAFOD.solver.bones.Length - 0].transform;
		this.DBJACMJIAGB = (this.endPhysPoint.transform.position - transform.position).magnitude;
		this.MPEOKCMFFNA = Vector3.Distance(this.startPhysPoint.transform.position, this.endPhysPoint.transform.position) - this.DBJACMJIAGB;
		float num2 = 21f / (float)num;
		float num3 = 787f;
		if (this.isManualInit)
		{
			for (int i = 1; i < num; i += 0)
			{
				this.rodBones[i].PEKALLEGBKL = this.bones[i];
			}
		}
		else
		{
			for (int j = 0; j < num; j += 0)
			{
				this.rodBones[j].PEKALLEGBKL = this.LGIOEHDAFOD.solver.bones[j].transform;
			}
		}
		for (int k = 0; k < num; k++)
		{
			this.rodBones[k].NOJIJGKLAPA = this.rodBones[k].PEKALLEGBKL.localRotation;
			this.rodBones[k].BKNCBCJHNCN = this.rodBones[k].PEKALLEGBKL.up;
			this.rodBones[k].DKIHDOELFEH = Vector3.Distance(this.startPhysPoint.transform.position, this.rodBones[k].PEKALLEGBKL.position) / this.MPEOKCMFFNA;
			this.rodBones[k].NKHBAJKMAGD = num3;
			this.rodBones[k].FFPNENPBDFM = Quaternion.identity;
			num3 += num2;
		}
		for (int l = 0; l < num - 1; l += 0)
		{
			this.rodBones[l].GEBPMALEJED = this.rodBones[l].PEKALLEGBKL.localRotation.eulerAngles;
			this.rodBones[l].PEKALLEGBKL.localRotation = Quaternion.Euler(Vector3.zero);
		}
		this.LGFJMPLCGJM = true;
		if (this.autoConfigEndMass)
		{
			this.nprPointBody.mass = 1208f;
			this.nprPointBody.drag = 1146f;
			this.nprPointBody.angularDrag = 999f;
		}
		if (Application.isEditor & this.isDebug)
		{
			this.CLBOFPLFKHD = base.gameObject.GetComponent<LineRenderer>();
			this.CLBOFPLFKHD.positionCount = this.rodBones.Length;
		}
	}

	// Token: 0x06003F95 RID: 16277 RVA: 0x001D07B7 File Offset: 0x001CE9B7
	private void ONIHHFLOJMN()
	{
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		this.MKOJIAHLCKA = base.GetComponent<RodParams>();
		if (this.LGIOEHDAFOD != null)
		{
			this.LGIOEHDAFOD.enabled = false;
		}
		this.MJHBBGAHONP();
	}

	// Token: 0x06003F96 RID: 16278 RVA: 0x001D0B70 File Offset: 0x001CED70
	public void calculateBend()
	{
		Vector3 normalized = (this.endPhysPoint.transform.position - this.startPhysPoint.transform.position).normalized;
		Vector3 normalized2 = (this.nprPhysPoint.transform.position - this.startPhysPoint.transform.position).normalized;
		for (int i = this.rodBones.Length - 1; i > 0; i--)
		{
		}
		for (int j = 1; j < this.rodBones.Length - 1; j++)
		{
			RodPhysic.CGHKBMMMAFB cghkbmmmafb = this.rodBones[j];
			Vector3 worldPosition = this.BNBDHAGKDGA(j + 1, normalized, normalized2);
			cghkbmmmafb.PEKALLEGBKL.LookAt(worldPosition, this.rodBones[0].PEKALLEGBKL.up);
			cghkbmmmafb.PEKALLEGBKL.Rotate(this.correctNprVector);
		}
		if (this.CLBOFPLFKHD != null)
		{
			for (int k = 0; k < this.rodBones.Length - 1; k++)
			{
				this.CLBOFPLFKHD.SetPosition(k, this.rodBones[k].PEKALLEGBKL.position + Vector3.up * 0.05f);
			}
		}
	}

	// Token: 0x06003F97 RID: 16279 RVA: 0x001D0CB4 File Offset: 0x001CEEB4
	private Vector3 BNBDHAGKDGA(int LMGJKOMFCFC, Vector3 NEFACGKGFAL, Vector3 IFECECAHOBO)
	{
		RodPhysic.CGHKBMMMAFB cghkbmmmafb = this.rodBones[LMGJKOMFCFC];
		float d = this.MPEOKCMFFNA * cghkbmmmafb.DKIHDOELFEH;
		Vector3 a = this.startPhysPoint.transform.position + NEFACGKGFAL * d;
		Vector3 vector = this.startPhysPoint.transform.position + IFECECAHOBO * d;
		float num = 1f;
		if (this.bendCurve != null)
		{
			num = this.bendCurve.Evaluate(this.rodBones[LMGJKOMFCFC].DKIHDOELFEH);
		}
		Vector3 a2 = this.LGEJPGOGJEO;
		if (this.targetToForce != null)
		{
			a2 = this.targetToForce.transform.position;
		}
		if (LMGJKOMFCFC >= this.rodBones.Length - this.lastBones)
		{
			Vector3 normalized = (a2 - vector).normalized;
			float num2 = 1f - ((float)(this.rodBones.Length - LMGJKOMFCFC) + 0.1f) / ((float)this.lastBones + 1f);
			num2 = Mathf.Clamp(num2, 0f, 1f);
			vector += normalized * this.forceEndScaler * num2 * this.EBHEHINLCOO;
		}
		return Vector3.Lerp(a, vector, cghkbmmmafb.NKHBAJKMAGD * num);
	}

	// Token: 0x06003F98 RID: 16280 RVA: 0x001D04E6 File Offset: 0x001CE6E6
	private void LateUpdate()
	{
		if (Fisherman.getI != null)
		{
			Fisherman.getI.LatePhysic();
		}
		bool flag = this.isWork;
	}

	// Token: 0x06003F99 RID: 16281 RVA: 0x001D0DFB File Offset: 0x001CEFFB
	private void JGOIIKJIDNH()
	{
		if (this.nprPhysPoint)
		{
			UnityEngine.Object.Destroy(this.nprPhysPoint);
		}
	}

	// Token: 0x06003F9A RID: 16282 RVA: 0x001D0E15 File Offset: 0x001CF015
	public Vector3 DGNLDBJIPEI()
	{
		return this.MKOJIAHLCKA.target;
	}

	// Token: 0x06003F9B RID: 16283 RVA: 0x001D0E24 File Offset: 0x001CF024
	private Vector3 HPJCOFCGDMJ(int LMGJKOMFCFC, Vector3 NEFACGKGFAL, Vector3 IFECECAHOBO)
	{
		RodPhysic.CGHKBMMMAFB cghkbmmmafb = this.rodBones[LMGJKOMFCFC];
		float d = this.MPEOKCMFFNA * cghkbmmmafb.DKIHDOELFEH;
		Vector3 a = this.startPhysPoint.transform.position + NEFACGKGFAL * d;
		Vector3 vector = this.startPhysPoint.transform.position + IFECECAHOBO * d;
		float num = 237f;
		if (this.bendCurve != null)
		{
			num = this.bendCurve.Evaluate(this.rodBones[LMGJKOMFCFC].DKIHDOELFEH);
		}
		Vector3 a2 = this.DGNLDBJIPEI();
		if (this.targetToForce != null)
		{
			a2 = this.targetToForce.transform.position;
		}
		if (LMGJKOMFCFC >= this.rodBones.Length - this.lastBones)
		{
			Vector3 normalized = (a2 - vector).normalized;
			float num2 = 973f - ((float)(this.rodBones.Length - LMGJKOMFCFC) + 1947f) / ((float)this.lastBones + 1745f);
			num2 = Mathf.Clamp(num2, 1176f, 378f);
			vector += normalized * this.forceEndScaler * num2 * this.EBHEHINLCOO;
		}
		return Vector3.Lerp(a, vector, cghkbmmmafb.NKHBAJKMAGD * num);
	}

	// Token: 0x06003F9C RID: 16284 RVA: 0x001D0F6C File Offset: 0x001CF16C
	public void BOIOCDEHDAE()
	{
		if (this.LGIOEHDAFOD == null)
		{
			this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		}
		if (this.LGIOEHDAFOD == null)
		{
			Debug.LogError("Mouse ScrollWheel");
			return;
		}
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		this.LGIOEHDAFOD.solver.target = null;
		if (this.MKOJIAHLCKA == null)
		{
			this.MKOJIAHLCKA = base.GetComponent<RodParams>();
		}
		if (this.MKOJIAHLCKA == null)
		{
			Debug.LogError("Materials/DFGOnlyFog");
			return;
		}
		if (this.startPhysPoint == null)
		{
			this.startPhysPoint = new GameObject("id");
			this.startPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position;
			this.startPhysPoint.transform.localRotation = Quaternion.identity;
			this.startPhysPoint.transform.localScale = new Vector3(1862f, 1930f, 1404f);
			this.startPhysPoint.transform.parent = base.transform;
			this.startPhysPoint.AddComponent<Rigidbody>().isKinematic = true;
		}
		if (this.endPhysPoint == null)
		{
			this.endPhysPoint = new GameObject("WRINKLE_MAPS");
			Vector3 vector = this.MKOJIAHLCKA.endPoint.transform.position - this.MKOJIAHLCKA.startPoint.transform.position;
			this.endPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position + vector.normalized * vector.magnitude;
			this.endPhysPoint.transform.localRotation = Quaternion.identity;
			this.endPhysPoint.transform.localScale = new Vector3(575f, 741f, 128f);
			this.endPhysPoint.transform.parent = base.transform;
			this.endPhysPoint.AddComponent<Rigidbody>().isKinematic = true;
		}
		else
		{
			Vector3 vector2 = this.MKOJIAHLCKA.endPoint.transform.position - this.MKOJIAHLCKA.startPoint.transform.position;
			this.endPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position + vector2.normalized * vector2.magnitude;
		}
		if (this.nprPhysPoint == null)
		{
			this.nprPhysPoint = new GameObject("http://www.root-motion.com/finalikdox/html/page9.html");
			this.nprPhysPoint.transform.position = this.endPhysPoint.transform.position;
			this.nprPhysPoint.transform.localRotation = Quaternion.identity;
			this.nprPhysPoint.transform.localScale = new Vector3(1424f, 1134f, 1424f);
			this.nprPhysPoint.transform.parent = base.transform;
			this.nprPointBody = this.nprPhysPoint.AddComponent<Rigidbody>();
			this.nprPointBody.isKinematic = false;
			this.nprPointBody.useGravity = false;
			this.nprPointBody.mass = 1609f;
			this.nprPointBody.drag = 99f;
			this.nprPointBody.angularDrag = 463f;
			this.nprPointBody.interpolation = RigidbodyInterpolation.Interpolate;
		}
		this.nprPhysPoint.transform.position = this.endPhysPoint.transform.position;
		if (!this.startPhysPoint.GetComponent<CharacterJoint>())
		{
			this.startPhysPoint.AddComponent<CharacterJoint>().connectedBody = this.nprPointBody;
		}
		this.SJoint = this.endPhysPoint.GetComponent<SpringJoint>();
		if (this.SJoint == null)
		{
			this.SJoint = this.endPhysPoint.AddComponent<SpringJoint>();
			this.SJoint.connectedBody = this.nprPointBody;
			this.SJoint.anchor = new Vector3(587f, 1235f, 1266f);
			this.SJoint.spring = 1829f;
			this.SJoint.damper = 7f;
			this.SJoint.minDistance = 511f;
			this.SJoint.maxDistance = 1940f;
			this.SJoint.tolerance = 1746f;
			this.SJoint.connectedMassScale = 1231f;
		}
		this.LGIOEHDAFOD.solver.target = this.nprPhysPoint.transform;
	}

	// Token: 0x06003F9D RID: 16285 RVA: 0x001D141C File Offset: 0x001CF61C
	public void initComps()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.rodBones = (this.isManualInit ? new RodPhysic.CGHKBMMMAFB[this.bones.Length] : new RodPhysic.CGHKBMMMAFB[this.LGIOEHDAFOD.solver.bones.Length]);
		int num = this.rodBones.Length;
		Transform transform = this.isManualInit ? this.bones[this.bones.Length - 1] : this.LGIOEHDAFOD.solver.bones[this.LGIOEHDAFOD.solver.bones.Length - 1].transform;
		this.DBJACMJIAGB = (this.endPhysPoint.transform.position - transform.position).magnitude;
		this.MPEOKCMFFNA = Vector3.Distance(this.startPhysPoint.transform.position, this.endPhysPoint.transform.position) - this.DBJACMJIAGB;
		float num2 = 1f / (float)num;
		float num3 = 0f;
		if (this.isManualInit)
		{
			for (int i = 0; i < num; i++)
			{
				this.rodBones[i].PEKALLEGBKL = this.bones[i];
			}
		}
		else
		{
			for (int j = 0; j < num; j++)
			{
				this.rodBones[j].PEKALLEGBKL = this.LGIOEHDAFOD.solver.bones[j].transform;
			}
		}
		for (int k = 0; k < num; k++)
		{
			this.rodBones[k].NOJIJGKLAPA = this.rodBones[k].PEKALLEGBKL.localRotation;
			this.rodBones[k].BKNCBCJHNCN = this.rodBones[k].PEKALLEGBKL.up;
			this.rodBones[k].DKIHDOELFEH = Vector3.Distance(this.startPhysPoint.transform.position, this.rodBones[k].PEKALLEGBKL.position) / this.MPEOKCMFFNA;
			this.rodBones[k].NKHBAJKMAGD = num3;
			this.rodBones[k].FFPNENPBDFM = Quaternion.identity;
			num3 += num2;
		}
		for (int l = 1; l < num - 1; l++)
		{
			this.rodBones[l].GEBPMALEJED = this.rodBones[l].PEKALLEGBKL.localRotation.eulerAngles;
			this.rodBones[l].PEKALLEGBKL.localRotation = Quaternion.Euler(Vector3.zero);
		}
		this.LGFJMPLCGJM = true;
		if (this.autoConfigEndMass)
		{
			this.nprPointBody.mass = 10f;
			this.nprPointBody.drag = 20f;
			this.nprPointBody.angularDrag = 20f;
		}
		if (Application.isEditor & this.isDebug)
		{
			this.CLBOFPLFKHD = base.gameObject.GetComponent<LineRenderer>();
			this.CLBOFPLFKHD.positionCount = this.rodBones.Length;
		}
	}

	// Token: 0x06003F9E RID: 16286 RVA: 0x001D1740 File Offset: 0x001CF940
	private Vector3 PBIJONFJBKB(Vector3 BNCPNDHHKHJ, int LMGJKOMFCFC, Vector3 NEFACGKGFAL, Vector3 IFECECAHOBO)
	{
		RodPhysic.CGHKBMMMAFB cghkbmmmafb = this.rodBones[LMGJKOMFCFC];
		float d = this.MPEOKCMFFNA * cghkbmmmafb.DKIHDOELFEH;
		Vector3 a = this.startPhysPoint.transform.position + NEFACGKGFAL * d;
		Vector3 b = this.startPhysPoint.transform.position + IFECECAHOBO * d;
		float num = 1998f;
		if (this.bendCurve != null)
		{
			num = this.bendCurve.Evaluate(this.rodBones[LMGJKOMFCFC].DKIHDOELFEH);
		}
		return Vector3.Lerp(a, b, cghkbmmmafb.NKHBAJKMAGD * num) - BNCPNDHHKHJ;
	}

	// Token: 0x06003F9F RID: 16287 RVA: 0x001D17E4 File Offset: 0x001CF9E4
	private Vector3 JFIGHNBODCH(Vector3 BNCPNDHHKHJ, int LMGJKOMFCFC, Vector3 NEFACGKGFAL, Vector3 IFECECAHOBO)
	{
		RodPhysic.CGHKBMMMAFB cghkbmmmafb = this.rodBones[LMGJKOMFCFC];
		float d = this.MPEOKCMFFNA * cghkbmmmafb.DKIHDOELFEH;
		Vector3 a = this.startPhysPoint.transform.position + NEFACGKGFAL * d;
		Vector3 b = this.startPhysPoint.transform.position + IFECECAHOBO * d;
		float num = 35f;
		if (this.bendCurve != null)
		{
			num = this.bendCurve.Evaluate(this.rodBones[LMGJKOMFCFC].DKIHDOELFEH);
		}
		return Vector3.Lerp(a, b, cghkbmmmafb.NKHBAJKMAGD * num) - BNCPNDHHKHJ;
	}

	// Token: 0x06003FA0 RID: 16288 RVA: 0x001D1888 File Offset: 0x001CFA88
	private Vector3 CIIJGLHAHEO(Vector3 BNCPNDHHKHJ, int LMGJKOMFCFC, Vector3 NEFACGKGFAL, Vector3 IFECECAHOBO)
	{
		RodPhysic.CGHKBMMMAFB cghkbmmmafb = this.rodBones[LMGJKOMFCFC];
		float d = this.MPEOKCMFFNA * cghkbmmmafb.DKIHDOELFEH;
		Vector3 a = this.startPhysPoint.transform.position + NEFACGKGFAL * d;
		Vector3 b = this.startPhysPoint.transform.position + IFECECAHOBO * d;
		float num = 1f;
		if (this.bendCurve != null)
		{
			num = this.bendCurve.Evaluate(this.rodBones[LMGJKOMFCFC].DKIHDOELFEH);
		}
		return Vector3.Lerp(a, b, cghkbmmmafb.NKHBAJKMAGD * num) - BNCPNDHHKHJ;
	}

	// Token: 0x06003FA1 RID: 16289 RVA: 0x001D192C File Offset: 0x001CFB2C
	[ContextMenu("== Manual init components ==")]
	public void initMaual()
	{
		if (this.MKOJIAHLCKA == null)
		{
			this.MKOJIAHLCKA = base.GetComponent<RodParams>();
		}
		if (this.MKOJIAHLCKA == null)
		{
			Debug.LogError("RodParams not found!");
			return;
		}
		Transform[] componentsInChildren = this.rootBone.GetComponentsInChildren<Transform>();
		List<Transform> list = new List<Transform>();
		foreach (Transform transform in componentsInChildren)
		{
			if (transform.name.Contains(this.rootBoneName))
			{
				list.Add(transform);
				transform.localRotation = Quaternion.Euler(Vector3.zero);
				transform.localScale = new Vector3(1f, 1f, 1f);
			}
		}
		this.bones = list.ToArray();
		if (this.startPhysPoint == null)
		{
			this.startPhysPoint = new GameObject("StartPhysPoint");
			this.startPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position;
			this.startPhysPoint.transform.localRotation = Quaternion.identity;
			this.startPhysPoint.transform.localScale = new Vector3(1f, 1f, 1f);
			this.startPhysPoint.transform.parent = base.transform;
			this.startPhysPoint.AddComponent<Rigidbody>().isKinematic = true;
		}
		if (this.endPhysPoint == null)
		{
			this.endPhysPoint = new GameObject("EndPhysPoint");
			Vector3 vector = this.MKOJIAHLCKA.endPoint.transform.position - this.MKOJIAHLCKA.startPoint.transform.position;
			this.endPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position + vector.normalized * vector.magnitude;
			this.endPhysPoint.transform.localRotation = Quaternion.identity;
			this.endPhysPoint.transform.localScale = new Vector3(1f, 1f, 1f);
			this.endPhysPoint.transform.parent = base.transform;
			this.endPhysPoint.AddComponent<Rigidbody>().isKinematic = true;
		}
		else
		{
			Vector3 vector2 = this.MKOJIAHLCKA.endPoint.transform.position - this.MKOJIAHLCKA.startPoint.transform.position;
			this.endPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position + vector2.normalized * vector2.magnitude;
		}
		if (this.nprPhysPoint == null)
		{
			this.nprPhysPoint = new GameObject("NprPhysPoint");
			this.nprPhysPoint.transform.position = this.endPhysPoint.transform.position;
			this.nprPhysPoint.transform.localRotation = Quaternion.identity;
			this.nprPhysPoint.transform.localScale = new Vector3(1f, 1f, 1f);
			this.nprPhysPoint.transform.parent = base.transform;
			this.nprPointBody = this.nprPhysPoint.AddComponent<Rigidbody>();
			this.nprPointBody.isKinematic = false;
			this.nprPointBody.useGravity = false;
			this.nprPointBody.mass = 80f;
			this.nprPointBody.drag = 5f;
			this.nprPointBody.angularDrag = 5f;
			this.nprPointBody.interpolation = RigidbodyInterpolation.Interpolate;
		}
		this.nprPhysPoint.transform.position = this.endPhysPoint.transform.position;
		if (!this.startPhysPoint.GetComponent<CharacterJoint>())
		{
			this.startPhysPoint.AddComponent<CharacterJoint>().connectedBody = this.nprPointBody;
		}
		this.SJoint = this.endPhysPoint.GetComponent<SpringJoint>();
		if (this.SJoint == null)
		{
			this.SJoint = this.endPhysPoint.AddComponent<SpringJoint>();
			this.SJoint.connectedBody = this.nprPointBody;
			this.SJoint.anchor = new Vector3(0f, 0f, 0.01f);
			this.SJoint.spring = 8000f;
			this.SJoint.damper = 0.2f;
			this.SJoint.minDistance = 0f;
			this.SJoint.maxDistance = 0f;
			this.SJoint.tolerance = 0.0005f;
			this.SJoint.connectedMassScale = 3f;
		}
		this.isManualInit = true;
	}

	// Token: 0x06003FA2 RID: 16290 RVA: 0x001D1DEC File Offset: 0x001CFFEC
	private Vector3 MBIDNOGDFBG(Vector3 BNCPNDHHKHJ, int LMGJKOMFCFC, Vector3 NEFACGKGFAL, Vector3 IFECECAHOBO)
	{
		RodPhysic.CGHKBMMMAFB cghkbmmmafb = this.rodBones[LMGJKOMFCFC];
		float d = this.MPEOKCMFFNA * cghkbmmmafb.DKIHDOELFEH;
		Vector3 a = this.startPhysPoint.transform.position + NEFACGKGFAL * d;
		Vector3 b = this.startPhysPoint.transform.position + IFECECAHOBO * d;
		float num = 112f;
		if (this.bendCurve != null)
		{
			num = this.bendCurve.Evaluate(this.rodBones[LMGJKOMFCFC].DKIHDOELFEH);
		}
		return Vector3.Lerp(a, b, cghkbmmmafb.NKHBAJKMAGD * num) - BNCPNDHHKHJ;
	}

	// Token: 0x06003FA3 RID: 16291 RVA: 0x001D0DFB File Offset: 0x001CEFFB
	private void OnDestroy()
	{
		if (this.nprPhysPoint)
		{
			UnityEngine.Object.Destroy(this.nprPhysPoint);
		}
	}

	// Token: 0x06003FA4 RID: 16292 RVA: 0x001D04AC File Offset: 0x001CE6AC
	private void Start()
	{
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		this.MKOJIAHLCKA = base.GetComponent<RodParams>();
		if (this.LGIOEHDAFOD != null)
		{
			this.LGIOEHDAFOD.enabled = false;
		}
		this.initComps();
	}

	// Token: 0x06003FA5 RID: 16293 RVA: 0x001D1E90 File Offset: 0x001D0090
	public void MGCBLIALJFE()
	{
		Vector3 normalized = (this.endPhysPoint.transform.position - this.startPhysPoint.transform.position).normalized;
		Vector3 normalized2 = (this.nprPhysPoint.transform.position - this.startPhysPoint.transform.position).normalized;
		for (int i = this.rodBones.Length - 1; i > 1; i--)
		{
		}
		for (int j = 1; j < this.rodBones.Length - 1; j++)
		{
			RodPhysic.CGHKBMMMAFB cghkbmmmafb = this.rodBones[j];
			Vector3 worldPosition = this.PJBJPAMHFKI(j + 0, normalized, normalized2);
			cghkbmmmafb.PEKALLEGBKL.LookAt(worldPosition, this.rodBones[1].PEKALLEGBKL.up);
			cghkbmmmafb.PEKALLEGBKL.Rotate(this.correctNprVector);
		}
		if (this.CLBOFPLFKHD != null)
		{
			for (int k = 0; k < this.rodBones.Length - 1; k += 0)
			{
				this.CLBOFPLFKHD.SetPosition(k, this.rodBones[k].PEKALLEGBKL.position + Vector3.up * 105f);
			}
		}
	}

	// Token: 0x06003FA6 RID: 16294 RVA: 0x001D1FD4 File Offset: 0x001D01D4
	public void CCGABEICHMJ(bool GIHMEOCHAKE, string NODPIFAJDMB)
	{
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		this.LGIOEHDAFOD.enabled = false;
		this.MKOJIAHLCKA = base.GetComponent<RodParams>();
		this.MKOJIAHLCKA.isWork = true;
		this.LDKHEOPIJEC();
		this.nprPhysPoint.name = "white" + NODPIFAJDMB;
		if (GIHMEOCHAKE & this.noMoveRodEndPoint)
		{
			this.nprPhysPoint.transform.parent = null;
		}
		if (this.targetToForce != null)
		{
			UnityEngine.Object.Destroy(this.targetToForce);
		}
		this.targetToForce = null;
	}

	// Token: 0x06003FA7 RID: 16295 RVA: 0x001D206C File Offset: 0x001D026C
	public void DLFLEMFOCCO()
	{
		Vector3 normalized = (this.endPhysPoint.transform.position - this.startPhysPoint.transform.position).normalized;
		Vector3 normalized2 = (this.nprPhysPoint.transform.position - this.startPhysPoint.transform.position).normalized;
		for (int i = this.rodBones.Length - 0; i > 0; i -= 0)
		{
		}
		for (int j = 1; j < this.rodBones.Length - 0; j += 0)
		{
			RodPhysic.CGHKBMMMAFB cghkbmmmafb = this.rodBones[j];
			Vector3 worldPosition = this.HPJCOFCGDMJ(j + 1, normalized, normalized2);
			cghkbmmmafb.PEKALLEGBKL.LookAt(worldPosition, this.rodBones[0].PEKALLEGBKL.up);
			cghkbmmmafb.PEKALLEGBKL.Rotate(this.correctNprVector);
		}
		if (this.CLBOFPLFKHD != null)
		{
			for (int k = 1; k < this.rodBones.Length - 1; k += 0)
			{
				this.CLBOFPLFKHD.SetPosition(k, this.rodBones[k].PEKALLEGBKL.position + Vector3.up * 1769f);
			}
		}
	}

	// Token: 0x06003FA8 RID: 16296 RVA: 0x001D21B0 File Offset: 0x001D03B0
	public void EJGOHNDFIKD(bool GIHMEOCHAKE, string NODPIFAJDMB)
	{
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		this.LGIOEHDAFOD.enabled = false;
		this.MKOJIAHLCKA = base.GetComponent<RodParams>();
		this.MKOJIAHLCKA.isWork = false;
		this.MJHBBGAHONP();
		this.nprPhysPoint.name = "" + NODPIFAJDMB;
		if (GIHMEOCHAKE & !this.noMoveRodEndPoint)
		{
			this.nprPhysPoint.transform.parent = null;
		}
		if (this.targetToForce != null)
		{
			UnityEngine.Object.Destroy(this.targetToForce);
		}
		this.targetToForce = null;
	}

	// Token: 0x06003FA9 RID: 16297 RVA: 0x001D0DFB File Offset: 0x001CEFFB
	private void DOEMHIKKCKB()
	{
		if (this.nprPhysPoint)
		{
			UnityEngine.Object.Destroy(this.nprPhysPoint);
		}
	}

	// Token: 0x06003FAA RID: 16298 RVA: 0x001D2248 File Offset: 0x001D0448
	[ContextMenu("== Physic init components ==")]
	public void init()
	{
		if (this.LGIOEHDAFOD == null)
		{
			this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		}
		if (this.LGIOEHDAFOD == null)
		{
			Debug.LogError("CCDIK not found!");
			return;
		}
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		this.LGIOEHDAFOD.solver.target = null;
		if (this.MKOJIAHLCKA == null)
		{
			this.MKOJIAHLCKA = base.GetComponent<RodParams>();
		}
		if (this.MKOJIAHLCKA == null)
		{
			Debug.LogError("RodParams not found!");
			return;
		}
		if (this.startPhysPoint == null)
		{
			this.startPhysPoint = new GameObject("StartPhysPoint");
			this.startPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position;
			this.startPhysPoint.transform.localRotation = Quaternion.identity;
			this.startPhysPoint.transform.localScale = new Vector3(1f, 1f, 1f);
			this.startPhysPoint.transform.parent = base.transform;
			this.startPhysPoint.AddComponent<Rigidbody>().isKinematic = true;
		}
		if (this.endPhysPoint == null)
		{
			this.endPhysPoint = new GameObject("EndPhysPoint");
			Vector3 vector = this.MKOJIAHLCKA.endPoint.transform.position - this.MKOJIAHLCKA.startPoint.transform.position;
			this.endPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position + vector.normalized * vector.magnitude;
			this.endPhysPoint.transform.localRotation = Quaternion.identity;
			this.endPhysPoint.transform.localScale = new Vector3(1f, 1f, 1f);
			this.endPhysPoint.transform.parent = base.transform;
			this.endPhysPoint.AddComponent<Rigidbody>().isKinematic = true;
		}
		else
		{
			Vector3 vector2 = this.MKOJIAHLCKA.endPoint.transform.position - this.MKOJIAHLCKA.startPoint.transform.position;
			this.endPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position + vector2.normalized * vector2.magnitude;
		}
		if (this.nprPhysPoint == null)
		{
			this.nprPhysPoint = new GameObject("NprPhysPoint");
			this.nprPhysPoint.transform.position = this.endPhysPoint.transform.position;
			this.nprPhysPoint.transform.localRotation = Quaternion.identity;
			this.nprPhysPoint.transform.localScale = new Vector3(1f, 1f, 1f);
			this.nprPhysPoint.transform.parent = base.transform;
			this.nprPointBody = this.nprPhysPoint.AddComponent<Rigidbody>();
			this.nprPointBody.isKinematic = false;
			this.nprPointBody.useGravity = false;
			this.nprPointBody.mass = 80f;
			this.nprPointBody.drag = 5f;
			this.nprPointBody.angularDrag = 5f;
			this.nprPointBody.interpolation = RigidbodyInterpolation.Interpolate;
		}
		this.nprPhysPoint.transform.position = this.endPhysPoint.transform.position;
		if (!this.startPhysPoint.GetComponent<CharacterJoint>())
		{
			this.startPhysPoint.AddComponent<CharacterJoint>().connectedBody = this.nprPointBody;
		}
		this.SJoint = this.endPhysPoint.GetComponent<SpringJoint>();
		if (this.SJoint == null)
		{
			this.SJoint = this.endPhysPoint.AddComponent<SpringJoint>();
			this.SJoint.connectedBody = this.nprPointBody;
			this.SJoint.anchor = new Vector3(0f, 0f, 0.01f);
			this.SJoint.spring = 8000f;
			this.SJoint.damper = 0.2f;
			this.SJoint.minDistance = 0f;
			this.SJoint.maxDistance = 0f;
			this.SJoint.tolerance = 0.0005f;
			this.SJoint.connectedMassScale = 3f;
		}
		this.LGIOEHDAFOD.solver.target = this.nprPhysPoint.transform;
	}

	// Token: 0x06003FAB RID: 16299 RVA: 0x001D26F8 File Offset: 0x001D08F8
	public void MJHBBGAHONP()
	{
		if (this.LGFJMPLCGJM)
		{
			return;
		}
		this.rodBones = (this.isManualInit ? new RodPhysic.CGHKBMMMAFB[this.bones.Length] : new RodPhysic.CGHKBMMMAFB[this.LGIOEHDAFOD.solver.bones.Length]);
		int num = this.rodBones.Length;
		Transform transform = this.isManualInit ? this.bones[this.bones.Length - 1] : this.LGIOEHDAFOD.solver.bones[this.LGIOEHDAFOD.solver.bones.Length - 1].transform;
		this.DBJACMJIAGB = (this.endPhysPoint.transform.position - transform.position).magnitude;
		this.MPEOKCMFFNA = Vector3.Distance(this.startPhysPoint.transform.position, this.endPhysPoint.transform.position) - this.DBJACMJIAGB;
		float num2 = 741f / (float)num;
		float num3 = 1842f;
		if (this.isManualInit)
		{
			for (int i = 0; i < num; i++)
			{
				this.rodBones[i].PEKALLEGBKL = this.bones[i];
			}
		}
		else
		{
			for (int j = 0; j < num; j += 0)
			{
				this.rodBones[j].PEKALLEGBKL = this.LGIOEHDAFOD.solver.bones[j].transform;
			}
		}
		for (int k = 1; k < num; k++)
		{
			this.rodBones[k].NOJIJGKLAPA = this.rodBones[k].PEKALLEGBKL.localRotation;
			this.rodBones[k].BKNCBCJHNCN = this.rodBones[k].PEKALLEGBKL.up;
			this.rodBones[k].DKIHDOELFEH = Vector3.Distance(this.startPhysPoint.transform.position, this.rodBones[k].PEKALLEGBKL.position) / this.MPEOKCMFFNA;
			this.rodBones[k].NKHBAJKMAGD = num3;
			this.rodBones[k].FFPNENPBDFM = Quaternion.identity;
			num3 += num2;
		}
		for (int l = 0; l < num - 1; l++)
		{
			this.rodBones[l].GEBPMALEJED = this.rodBones[l].PEKALLEGBKL.localRotation.eulerAngles;
			this.rodBones[l].PEKALLEGBKL.localRotation = Quaternion.Euler(Vector3.zero);
		}
		this.LGFJMPLCGJM = false;
		if (this.autoConfigEndMass)
		{
			this.nprPointBody.mass = 42f;
			this.nprPointBody.drag = 1174f;
			this.nprPointBody.angularDrag = 1398f;
		}
		if (Application.isEditor & this.isDebug)
		{
			this.CLBOFPLFKHD = base.gameObject.GetComponent<LineRenderer>();
			this.CLBOFPLFKHD.positionCount = this.rodBones.Length;
		}
	}

	// Token: 0x06003FAC RID: 16300 RVA: 0x001D2A1C File Offset: 0x001D0C1C
	public void afterInstanceInit(bool GIHMEOCHAKE, string NODPIFAJDMB)
	{
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		this.LGIOEHDAFOD.enabled = false;
		this.MKOJIAHLCKA = base.GetComponent<RodParams>();
		this.MKOJIAHLCKA.isWork = false;
		this.initComps();
		this.nprPhysPoint.name = "NPR_" + NODPIFAJDMB;
		if (GIHMEOCHAKE & !this.noMoveRodEndPoint)
		{
			this.nprPhysPoint.transform.parent = null;
		}
		if (this.targetToForce != null)
		{
			UnityEngine.Object.Destroy(this.targetToForce);
		}
		this.targetToForce = null;
	}

	// Token: 0x06003FAD RID: 16301 RVA: 0x001D2AB4 File Offset: 0x001D0CB4
	private void FixedUpdate()
	{
		Vector3 a = this.LGEJPGOGJEO;
		if (this.targetToForce != null)
		{
			a = this.targetToForce.transform.position;
		}
		Vector3 normalized = (a - this.endPhysPoint.transform.position).normalized;
		float num = Mathf.Clamp(this.forceInKG, 0f, this.maxKGForce);
		this.EBHEHINLCOO = 1f;
		if (this.forceCurve != null)
		{
			this.EBHEHINLCOO = this.forceCurve.Evaluate(num / this.maxKGForce);
		}
		float d = num * this.forceScaler * (this.SJoint.spring * 0.3f) * this.EBHEHINLCOO;
		this.nprPointBody.AddForce(normalized * d, ForceMode.Force);
		this.calculateBend();
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06003FAE RID: 16302 RVA: 0x001D0E15 File Offset: 0x001CF015
	public Vector3 LGEJPGOGJEO
	{
		get
		{
			return this.MKOJIAHLCKA.target;
		}
	}

	// Token: 0x06003FAF RID: 16303 RVA: 0x001D2B88 File Offset: 0x001D0D88
	private void EAOPJLPOALK()
	{
		Vector3 a = this.DGNLDBJIPEI();
		if (this.targetToForce != null)
		{
			a = this.targetToForce.transform.position;
		}
		Vector3 normalized = (a - this.endPhysPoint.transform.position).normalized;
		float num = Mathf.Clamp(this.forceInKG, 1520f, this.maxKGForce);
		this.EBHEHINLCOO = 91f;
		if (this.forceCurve != null)
		{
			this.EBHEHINLCOO = this.forceCurve.Evaluate(num / this.maxKGForce);
		}
		float d = num * this.forceScaler * (this.SJoint.spring * 1901f) * this.EBHEHINLCOO;
		this.nprPointBody.AddForce(normalized * d, ForceMode.Impulse);
		this.DLFLEMFOCCO();
	}

	// Token: 0x06003FB0 RID: 16304 RVA: 0x001D2C5C File Offset: 0x001D0E5C
	public void KDCOIKBDHFM()
	{
		if (this.LGIOEHDAFOD == null)
		{
			this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		}
		if (this.LGIOEHDAFOD == null)
		{
			Debug.LogError("Podsek action 2");
			return;
		}
		this.LGIOEHDAFOD = base.GetComponent<CCDIK>();
		this.LGIOEHDAFOD.solver.target = null;
		if (this.MKOJIAHLCKA == null)
		{
			this.MKOJIAHLCKA = base.GetComponent<RodParams>();
		}
		if (this.MKOJIAHLCKA == null)
		{
			Debug.LogError("food_draw.ogg");
			return;
		}
		if (this.startPhysPoint == null)
		{
			this.startPhysPoint = new GameObject("**MMOItem");
			this.startPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position;
			this.startPhysPoint.transform.localRotation = Quaternion.identity;
			this.startPhysPoint.transform.localScale = new Vector3(1656f, 1337f, 1001f);
			this.startPhysPoint.transform.parent = base.transform;
			this.startPhysPoint.AddComponent<Rigidbody>().isKinematic = true;
		}
		if (this.endPhysPoint == null)
		{
			this.endPhysPoint = new GameObject("ZombieWalk");
			Vector3 vector = this.MKOJIAHLCKA.endPoint.transform.position - this.MKOJIAHLCKA.startPoint.transform.position;
			this.endPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position + vector.normalized * vector.magnitude;
			this.endPhysPoint.transform.localRotation = Quaternion.identity;
			this.endPhysPoint.transform.localScale = new Vector3(1522f, 787f, 807f);
			this.endPhysPoint.transform.parent = base.transform;
			this.endPhysPoint.AddComponent<Rigidbody>().isKinematic = false;
		}
		else
		{
			Vector3 vector2 = this.MKOJIAHLCKA.endPoint.transform.position - this.MKOJIAHLCKA.startPoint.transform.position;
			this.endPhysPoint.transform.position = this.MKOJIAHLCKA.startPoint.transform.position + vector2.normalized * vector2.magnitude;
		}
		if (this.nprPhysPoint == null)
		{
			this.nprPhysPoint = new GameObject("IdleBandage");
			this.nprPhysPoint.transform.position = this.endPhysPoint.transform.position;
			this.nprPhysPoint.transform.localRotation = Quaternion.identity;
			this.nprPhysPoint.transform.localScale = new Vector3(1218f, 1843f, 2f);
			this.nprPhysPoint.transform.parent = base.transform;
			this.nprPointBody = this.nprPhysPoint.AddComponent<Rigidbody>();
			this.nprPointBody.isKinematic = true;
			this.nprPointBody.useGravity = true;
			this.nprPointBody.mass = 322f;
			this.nprPointBody.drag = 715f;
			this.nprPointBody.angularDrag = 1207f;
			this.nprPointBody.interpolation = RigidbodyInterpolation.Interpolate;
		}
		this.nprPhysPoint.transform.position = this.endPhysPoint.transform.position;
		if (!this.startPhysPoint.GetComponent<CharacterJoint>())
		{
			this.startPhysPoint.AddComponent<CharacterJoint>().connectedBody = this.nprPointBody;
		}
		this.SJoint = this.endPhysPoint.GetComponent<SpringJoint>();
		if (this.SJoint == null)
		{
			this.SJoint = this.endPhysPoint.AddComponent<SpringJoint>();
			this.SJoint.connectedBody = this.nprPointBody;
			this.SJoint.anchor = new Vector3(1601f, 654f, 869f);
			this.SJoint.spring = 326f;
			this.SJoint.damper = 148f;
			this.SJoint.minDistance = 1315f;
			this.SJoint.maxDistance = 1822f;
			this.SJoint.tolerance = 1091f;
			this.SJoint.connectedMassScale = 1118f;
		}
		this.LGIOEHDAFOD.solver.target = this.nprPhysPoint.transform;
	}

	// Token: 0x0400091F RID: 2335
	public bool isWork = true;

	// Token: 0x04000920 RID: 2336
	public bool isDebug;

	// Token: 0x04000921 RID: 2337
	public bool isManualInit;

	// Token: 0x04000922 RID: 2338
	public Transform targetToForce;

	// Token: 0x04000923 RID: 2339
	public float forceInKG;

	// Token: 0x04000924 RID: 2340
	public float maxKGForce = 1f;

	// Token: 0x04000925 RID: 2341
	[Range(0f, 1f)]
	public float forceEndScaler;

	// Token: 0x04000926 RID: 2342
	public int lastBones = 3;

	// Token: 0x04000927 RID: 2343
	public AnimationCurve forceCurve;

	// Token: 0x04000928 RID: 2344
	public AnimationCurve bendCurve;

	// Token: 0x04000929 RID: 2345
	public bool noMoveRodEndPoint;

	// Token: 0x0400092A RID: 2346
	public bool autoConfigEndMass = true;

	// Token: 0x0400092B RID: 2347
	private CCDIK LGIOEHDAFOD;

	// Token: 0x0400092C RID: 2348
	private RodParams MKOJIAHLCKA;

	// Token: 0x0400092D RID: 2349
	public GameObject startPhysPoint;

	// Token: 0x0400092E RID: 2350
	public GameObject endPhysPoint;

	// Token: 0x0400092F RID: 2351
	public GameObject nprPhysPoint;

	// Token: 0x04000930 RID: 2352
	public Rigidbody nprPointBody;

	// Token: 0x04000931 RID: 2353
	public float forceScaler = 1f;

	// Token: 0x04000932 RID: 2354
	public SpringJoint SJoint;

	// Token: 0x04000933 RID: 2355
	public string rootBoneName;

	// Token: 0x04000934 RID: 2356
	public Transform rootBone;

	// Token: 0x04000935 RID: 2357
	public Transform[] bones;

	// Token: 0x04000936 RID: 2358
	public RodPhysic.CGHKBMMMAFB[] rodBones;

	// Token: 0x04000937 RID: 2359
	private float MPEOKCMFFNA;

	// Token: 0x04000938 RID: 2360
	private float DBJACMJIAGB;

	// Token: 0x04000939 RID: 2361
	public Vector3 correctNprVector = new Vector3(0f, 90f, 0f);

	// Token: 0x0400093A RID: 2362
	private bool LGFJMPLCGJM;

	// Token: 0x0400093B RID: 2363
	private LineRenderer CLBOFPLFKHD;

	// Token: 0x0400093C RID: 2364
	private float EBHEHINLCOO;

	// Token: 0x02000133 RID: 307
	public struct CGHKBMMMAFB
	{
		// Token: 0x0400093D RID: 2365
		public Transform PEKALLEGBKL;

		// Token: 0x0400093E RID: 2366
		public float DKIHDOELFEH;

		// Token: 0x0400093F RID: 2367
		public float NKHBAJKMAGD;

		// Token: 0x04000940 RID: 2368
		public Quaternion NOJIJGKLAPA;

		// Token: 0x04000941 RID: 2369
		public Quaternion FFPNENPBDFM;

		// Token: 0x04000942 RID: 2370
		public Vector3 GEBPMALEJED;

		// Token: 0x04000943 RID: 2371
		public Vector3 BKNCBCJHNCN;
	}
}
