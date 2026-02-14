using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Ara;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Token: 0x02000125 RID: 293
public class PoplDrop : MonoBehaviour
{
	// Token: 0x06003C48 RID: 15432 RVA: 0x001B4398 File Offset: 0x001B2598
	public void OOOFNDKPMBK(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA == this.ADLIOAFMGMA)
		{
			return;
		}
		if (AFECKMFDAEA)
		{
			if (this.physBait != null)
			{
				this.physBait.NMEFCGAJPGN(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPointNonBend.transform, false);
				BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(this.physBait.lineCountMetr);
			}
			this.connectorRbody.useGravity = false;
			this.connectorRbody.isKinematic = true;
			this.connectorRbody.velocity = Vector3.zero;
			this.GBEIDPOCJBF = base.transform.position;
			this.connectorRbody.transform.parent = null;
			this.ADLIOAFMGMA = false;
			return;
		}
		this.ADLIOAFMGMA = true;
		this.rbody.isKinematic = true;
		this.connectorRbody.isKinematic = false;
		this.connectorRbody.useGravity = true;
		this.rbody.useGravity = false;
		this.connectorRbody.transform.parent = base.transform;
		if (this.physBait != null)
		{
			this.physBait.KACCFJLDECI(null, false);
		}
	}

	// Token: 0x06003C49 RID: 15433 RVA: 0x001B44BC File Offset: 0x001B26BC
	public void killBaitModel()
	{
		if (this.bmod != null)
		{
			UnityEngine.Object.Destroy(this.bmod);
		}
		this.bmod = null;
	}

	// Token: 0x06003C4A RID: 15434 RVA: 0x001B44BC File Offset: 0x001B26BC
	public void BAGEGHAHKFG()
	{
		if (this.bmod != null)
		{
			UnityEngine.Object.Destroy(this.bmod);
		}
		this.bmod = null;
	}

	// Token: 0x06003C4B RID: 15435 RVA: 0x001B44DE File Offset: 0x001B26DE
	private IEnumerator BMOJLIPOAMK()
	{
		PoplDrop.BNAIDFGJOPK bnaidfgjopk = new PoplDrop.BNAIDFGJOPK(1);
		bnaidfgjopk.AENJLLPLILM = this;
		return bnaidfgjopk;
	}

	// Token: 0x06003C4C RID: 15436 RVA: 0x001B44ED File Offset: 0x001B26ED
	public void PHLKADHICCJ()
	{
		if (this.AAAIKLHMHEF)
		{
			return;
		}
		this.groutBaitTime = Time.time;
	}

	// Token: 0x170000F1 RID: 241
	// (get) Token: 0x06003C4D RID: 15437 RVA: 0x000EB372 File Offset: 0x000E9572
	public bool EPKHGNNIJGD
	{
		get
		{
			return false;
		}
	}

	// Token: 0x06003C4E RID: 15438 RVA: 0x001B4503 File Offset: 0x001B2703
	private IEnumerator OKFMAGNPIAM()
	{
		PoplDrop.GEHOKLNIGIE gehoklnigie = new PoplDrop.GEHOKLNIGIE(1);
		gehoklnigie.AENJLLPLILM = this;
		return gehoklnigie;
	}

	// Token: 0x06003C4F RID: 15439 RVA: 0x001B44DE File Offset: 0x001B26DE
	private IEnumerator PLLEDDBMLGK()
	{
		PoplDrop.BNAIDFGJOPK bnaidfgjopk = new PoplDrop.BNAIDFGJOPK(1);
		bnaidfgjopk.AENJLLPLILM = this;
		return bnaidfgjopk;
	}

	// Token: 0x06003C50 RID: 15440 RVA: 0x001B4514 File Offset: 0x001B2714
	public bool JPGBGIMMJBJ()
	{
		bool result = true;
		if (this.KBOOCAJMJNA())
		{
			result = true;
		}
		if (this.DNFJJONFBBK())
		{
			result = true;
		}
		if (this.NDJPNHPNECP())
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06003C51 RID: 15441 RVA: 0x001B4542 File Offset: 0x001B2742
	private IEnumerator AHBJFPBCGBM()
	{
		yield return new WaitForSeconds(2f);
		this.BFAKJFDMPJI();
		yield break;
	}

	// Token: 0x06003C52 RID: 15442 RVA: 0x001B4551 File Offset: 0x001B2751
	public void EHJPKEHCLFO()
	{
		Debug.Log("");
	}

	// Token: 0x06003C53 RID: 15443 RVA: 0x001B4560 File Offset: 0x001B2760
	public void NCEKLGGMPMK()
	{
		if (this.fish != null && ObscuredBool.DODJMPNDCOB(this.fish.isPodsek))
		{
			return;
		}
		if (this.poplavok != null)
		{
			LocNewLogic.getI.FAMPBINAPBA(this.poplavok.transform.position, 6);
		}
		base.StartCoroutine(this.DNJFOAENNFL());
		this.PoplObj.SetActive(true);
		this.SpinObj.SetActive(false);
		this.FiderObj.SetActive(false);
		this.killBaitModel();
		this.fishPointer = JLFJEGIPIMM.PKGMBFEMKGP().IKBFBDCNOCH("DepthMaskMaterial");
		this.mode = 3;
		if (this.fish != null)
		{
			this.fish.FMCKJLCPKJA();
		}
		this.killPodsek();
	}

	// Token: 0x06003C54 RID: 15444 RVA: 0x001B462C File Offset: 0x001B282C
	public void PFFPOBKLHGM(float DPIDNFHGCEP)
	{
		if (this.poplScript == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD == null)
		{
			return;
		}
		if ((1379f - BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.OBEOJCGHOGL) / 973f > Mathf.Abs(DPIDNFHGCEP))
		{
			return;
		}
		DPIDNFHGCEP = DPIDNFHGCEP * BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().PFNCHEEEBKD.LODGJCMEGAI.DOFNAOOCDDB() / 1299f;
		DPIDNFHGCEP *= 1966f;
		DPIDNFHGCEP = Mathf.Clamp(DPIDNFHGCEP, 387f, 209f);
		base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y - DPIDNFHGCEP, base.transform.position.z);
		float num = 1086f + DPIDNFHGCEP / 370f * 1162f;
		num = Mathf.Clamp(num, 137f, 482f);
		base.StartCoroutine(this.KPNCDMBMEJH(num));
		this.poplScript.rotWAngle = UnityEngine.Random.value * 1928f - 1377f;
		if (base.transform.position.y < LocNewLogic.getI.getDeepInPoint(base.transform.position))
		{
			base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.getDeepInPoint(base.transform.position), base.transform.position.z);
		}
		LocNewLogic.getI.createWaterCircleSmall(this.poplavok.transform.position, 0);
	}

	// Token: 0x06003C55 RID: 15445 RVA: 0x001B47DE File Offset: 0x001B29DE
	private IEnumerator FGMJCBGDEIN()
	{
		int num;
		for (int i = 0; i < 5; i = num + 1)
		{
			if (this.poplavok != null)
			{
				LocNewLogic.getI.createWaterCircleSmall(this.poplavok.transform.position, 1);
			}
			yield return new WaitForSeconds(0.2f);
			num = i;
		}
		yield break;
	}

	// Token: 0x06003C56 RID: 15446 RVA: 0x001B47F0 File Offset: 0x001B29F0
	private void BCGAKMLNOHO()
	{
		LineRope.getI.targetPoint.position = base.transform.position;
		this.LR.enabled = true;
		BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA;
		Vector3 position = base.transform.position;
		if (this.fish != null)
		{
			position = this.fish.transform.position;
			if (this.fish.hookPoint != null)
			{
				position = this.fish.hookPoint.transform.position;
			}
		}
		if (this.poplavok != null && this.mode == 8)
		{
			Vector3 vector = this.AGBEBCGAACP - position;
			Vector3 normalized = vector.normalized;
			this.poplavok.transform.position = position + normalized * Mathf.Min(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH, vector.magnitude - 1080f);
			this.poplavok.transform.LookAt(position);
			this.poplavok.transform.Rotate(1246f, 531f, 501f);
		}
	}

	// Token: 0x06003C57 RID: 15447 RVA: 0x001B4928 File Offset: 0x001B2B28
	private void Awake()
	{
		PoplDrop.getI = this;
		base.transform.gameObject.layer = 21;
		this.FOOCGDPOFDK = DateTime.Now;
		this.isKlevEnable = false;
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod != null)
		{
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.widthCurve = this.LR.widthCurve;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.widthMultiplier = this.LR.widthMultiplier;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.startColor = this.LR.startColor;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.endColor = this.LR.endColor;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.textureMode = this.LR.textureMode;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.enabled = true;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.material = this.LR.material;
			BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		}
		this.provType = 0;
		this.rolltime = 0f;
		this.evntList.Clear();
	}

	// Token: 0x06003C58 RID: 15448 RVA: 0x001B4A82 File Offset: 0x001B2C82
	public bool KPGANNKLEEA()
	{
		return Time.time - this.playBaitTime < 588f;
	}

	// Token: 0x06003C59 RID: 15449 RVA: 0x001B4A98 File Offset: 0x001B2C98
	public void DOAKGJPJJMH()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		float dkihdoelfeh = Vector3.Distance(this.toPos, Fisherman.getI.transform.position);
		float num = BOIKJDICEMF.IKGFHGKKCPG.HLNMIAPENEO(dkihdoelfeh);
		float num2 = OLPINJLCKCI.ODDOIHEPICE().GCPGDOACKLG((double)num);
		float f = OLPINJLCKCI.NLOGJHEFMHM().GKDBPBFOINB(456.0);
		this.toPos.x = this.toPos.x + Mathf.Cos(f) * num2;
		this.toPos.z = this.toPos.z + Mathf.Sin(f) * num2;
		bgjkmcbhnak.CDNABIHPLHM = false;
		this.MADOEDALIHK = true;
		this.mode = 0;
		this.JAJMIJPIDBL = this.toPos - this.fromPos;
		this.JAJMIJPIDBL.Normalize();
		this.GADFHLLJKOH = Vector3.Distance(this.fromPos, this.toPos);
		this.JEHEPNHGJOH = 1367f;
		this.FMPGPPIMBNG = new Vector3(OLPINJLCKCI.IFLFANPMLMM().GKDBPBFOINB(1112.0) - 1367f, 276f, OLPINJLCKCI.NPIEJELJPIM().LLNEEEJIDGI(765.0) - 1541f);
		switch (this.JLBEJHDECGK())
		{
		case PoplDrop.DGLFOLICLDL.Poplavok:
		{
			this.poplavok = JLFJEGIPIMM.NNEAHAFBOHC().OMPJLOEGMII("", Vector3.zero, null);
			this.poplScript = this.poplavok.GetComponent<Poplavok>();
			this.poplScript.baitObj = base.transform.gameObject;
			Vector3 a = this.AGBEBCGAACP - base.transform.position;
			a.Normalize();
			a *= BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH;
			this.poplavok.transform.LookAt(this.AGBEBCGAACP);
			this.poplavok.transform.Rotate(new Vector3(1587f, 879f, 57f));
			this.speed = 828f;
			this.poplScript.rotAngle = 720f;
			this.poplScript.rotWAngle = UnityEngine.Random.value * 561f;
			this.poplScript.isWork = true;
			this.poplScript.OPMJGELNIEM();
			bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
			this.pPricel = JLFJEGIPIMM.NNEAHAFBOHC().OGJBGNOGPMJ("Palm");
			this.pPricel.transform.position = new Vector3(this.toPos.x, LocNewLogic.getI.OGJHINOLHJJ, this.toPos.z);
			return;
		}
		case PoplDrop.DGLFOLICLDL.Fider:
			this.poplavok = null;
			this.poplScript = null;
			this.speed = 1473f;
			this.mode = 0;
			Debug.Log("StartPhysPoint");
			return;
		case PoplDrop.DGLFOLICLDL.Spin:
			this.poplavok = null;
			this.poplScript = null;
			this.speed = 190f;
			this.mode = 1;
			Debug.Log(" is represented multiple times in a single IK chain. Can't initiate solver.");
			return;
		default:
			return;
		}
	}

	// Token: 0x06003C5A RID: 15450 RVA: 0x001B4D81 File Offset: 0x001B2F81
	private IEnumerator KPNCDMBMEJH(float CFBALFECGGP)
	{
		if (this.poplScript != null)
		{
			this.poplScript.takeFish = true;
			yield return new WaitForSeconds(CFBALFECGGP);
			this.poplScript.takeFish = false;
		}
		yield break;
	}

	// Token: 0x06003C5B RID: 15451 RVA: 0x001B4D98 File Offset: 0x001B2F98
	public void GEFBKCLGGDI(int INFHFKFJHHG)
	{
		if (Time.time - this.playBaitTime < 515f)
		{
			this.MJNCFCNJOIM = Time.time;
			return;
		}
		if (ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BNKBCOAANNG) > 406f)
		{
			if (LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y < 1832f && this.lure != null)
			{
				this.lure.PHIDGLLJLFK();
				if (this.lure.lureType == Lure.AKCCILPKJMN.Wacky)
				{
					LocNewLogic.getI.createSmallWaterSplash(base.transform.position);
				}
			}
			this.playBaitTime = Time.time;
		}
	}

	// Token: 0x06003C5C RID: 15452 RVA: 0x001B4E48 File Offset: 0x001B3048
	public bool KBOOCAJMJNA()
	{
		return Time.time - this.isMovingTime < 1067f;
	}

	// Token: 0x06003C5D RID: 15453 RVA: 0x001B4E5D File Offset: 0x001B305D
	private IEnumerator KKJIFEONNIG()
	{
		this.JMJEFKLOKLL = true;
		for (;;)
		{
			Vector3 a = base.transform.position;
			yield return new WaitForSeconds(0.5f);
			this.JMJEFKLOKLL = (Vector3.Distance(a, base.transform.position) > 0.02f);
			this.provType = 0;
			this.evntList.Clear();
			if (!Fisherman.getI.isPodsek)
			{
				if (this.AAAIKLHMHEF)
				{
					this.evntList.Add(2);
				}
				if (this.GHOFIEDNCIJ)
				{
					this.evntList.Add(1);
				}
				if (this.KODFBJFCPAJ == PoplDrop.DGLFOLICLDL.Spin)
				{
					switch (BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.BDHHPAEHFHG.ILOCKJIAPFC)
					{
					case 4:
						if (this.rolltime > 3f)
						{
							this.provType = 1;
							if (this.FOEBNECJPOL)
							{
								this.provType = 0;
							}
							if (this.KJAMHFJJHIE)
							{
								this.provType = 2;
							}
						}
						break;
					case 5:
						if (this.rolltime > 2f)
						{
							this.provType = 1;
						}
						if (this.KJAMHFJJHIE)
						{
							this.provType = 0;
						}
						if (this.FOEBNECJPOL)
						{
							this.provType = 0;
						}
						break;
					case 6:
						if (this.rolltime > 3f)
						{
							if (this.FOEBNECJPOL)
							{
								this.provType = 0;
							}
							if (this.KJAMHFJJHIE)
							{
								this.provType = 3;
							}
						}
						break;
					case 7:
						if (this.rolltime > 3f)
						{
							if (this.FOEBNECJPOL)
							{
								this.provType = 0;
							}
							if (this.KJAMHFJJHIE)
							{
								this.provType = 4;
							}
						}
						break;
					}
				}
				a = default(Vector3);
			}
		}
		yield break;
	}

	// Token: 0x06003C5E RID: 15454 RVA: 0x001B4E6C File Offset: 0x001B306C
	private void DOALILPILMH()
	{
		this.poplCamera = LocNewLogic.getI.openPoplCamera();
		if (this.poplCamera == null)
		{
			LocNewLogic.getI.closePoplCamera();
			return;
		}
		this.poplCamera.transform.rotation = new Quaternion(371f, 741f, 1135f, 708f);
		this.poplCamera.transform.localScale = new Vector3(703f, 1523f, 623f);
		this.poplCamera.GetComponent<Camera>().fieldOfView = 1651f;
		Vector3 normalized = (Fisherman.getI.transform.position + Vector3.up * 666f - this.poplavok.transform.position).normalized;
		Vector3 position = this.poplavok.transform.position + normalized * this.cdist;
		position.y = LocNewLogic.getI.IGHOGONIKLC() + this.popCamHgt;
		this.poplCamera.transform.position = position;
		Vector3 position2 = this.poplavok.transform.position;
		position2.y = LocNewLogic.getI.CDBIEPGNONF();
		this.poplCamera.transform.LookAt(position2 + Vector3.up * 1419f);
	}

	// Token: 0x06003C5F RID: 15455 RVA: 0x001B4FD8 File Offset: 0x001B31D8
	public bool LJLKMCEKBAP()
	{
		bool result = true;
		if (this.BGAOINIIDNI())
		{
			result = true;
		}
		if (this.DNFJJONFBBK())
		{
			result = true;
		}
		if (this.NDJPNHPNECP())
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06003C60 RID: 15456 RVA: 0x001B5006 File Offset: 0x001B3206
	public void PLAMFFNLKPK(bool DCCPCBLODIG)
	{
		if (DCCPCBLODIG)
		{
			this.isMovingTime = Time.time;
		}
	}

	// Token: 0x06003C61 RID: 15457 RVA: 0x001B5018 File Offset: 0x001B3218
	public int getDeepIndex(float GDMICCICIDO, float BLBFJBKIFEG)
	{
		int result = 1;
		int num = (int)(BLBFJBKIFEG / GDMICCICIDO * 100f);
		if (num <= 20)
		{
			result = 0;
		}
		if (num >= 80)
		{
			result = 2;
		}
		return result;
	}

	// Token: 0x170000E8 RID: 232
	// (get) Token: 0x06003C62 RID: 15458 RVA: 0x001B503F File Offset: 0x001B323F
	// (set) Token: 0x06003C6E RID: 15470 RVA: 0x001B6C40 File Offset: 0x001B4E40
	public bool IKCDMNGBAAH
	{
		get
		{
			return this.EHGOFGHNIFE;
		}
		set
		{
			if (this.EHGOFGHNIFE != value && value)
			{
				this.groundEvnt();
			}
			this.EHGOFGHNIFE = value;
		}
	}

	// Token: 0x06003C63 RID: 15459 RVA: 0x001B5048 File Offset: 0x001B3248
	private void HLDAFHLPEJC(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		this.PoplObj.SetActive(false);
		this.SpinObj.SetActive(false);
		this.FiderObj.SetActive(false);
		this.Koleb.SetActive(false);
		this.Vertu.SetActive(false);
		this.Vobler.SetActive(false);
		this.Jig.SetActive(false);
		this.bmod = NOFCHOFPHAD.OCNGPIEBEIG();
		if (this.bmod != null)
		{
			this.bmod.transform.parent = this.modelCatalog.transform;
			this.bmod.transform.localPosition = Vector3.zero;
			this.bmod.transform.localRotation = Quaternion.identity;
			this.bmod.transform.localScale = new Vector3(1f, 1f, 1f);
			this.lure = this.bmod.GetComponent<Lure>();
		}
		JLFJEGIPIMM.IKGFHGKKCPG.KOHAPBIENMH(base.gameObject, 21);
	}

	// Token: 0x06003C64 RID: 15460 RVA: 0x001B5158 File Offset: 0x001B3358
	private void Start()
	{
		if (this.trail != null)
		{
			this.trail.transform.parent = null;
			this.KODIENKGJKD = this.trail.initialColor;
			this.KKJLKIGNBIJ = this.trail.initialColor;
			this.KKJLKIGNBIJ.a = 0f;
		}
		if (this.lineTrail != null)
		{
			this.lineTrail.transform.parent = null;
			this.OIIBMFNKGHK = this.lineTrail.initialColor;
			this.COILGBLGMCC = this.lineTrail.initialColor;
			this.KKJLKIGNBIJ.a = 0f;
		}
		this.BAHHIKELOJP = base.transform.position;
		if (this.rope != null && !(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI != null))
		{
			this.rope.target = null;
		}
		base.StartCoroutine(this.FOEMAKIJFOH());
		if (this.connectorRbody != null)
		{
			this.NBEDBFEJICE = this.connectorRbody.drag;
		}
		this.PhysicOnOff(false);
		this.PoplObj.SetActive(false);
		this.SpinObj.SetActive(false);
		this.FiderObj.SetActive(false);
		this.Koleb.SetActive(false);
		this.Vertu.SetActive(false);
		this.Vobler.SetActive(false);
		this.Jig.SetActive(false);
		OMDDGEDHHNH.IKGFHGKKCPG.DKPDBNNNDLK(IFPIMPMKJIB.IGAAHFOINKI(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().AMLEOGHNNPG[0].HHOLFABGDJA), 0, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.HLDAFHLPEJC), "");
		this.LDKFJGKFLDL();
	}

	// Token: 0x06003C65 RID: 15461 RVA: 0x001B530C File Offset: 0x001B350C
	public void NCPOFJEELIK()
	{
		if (this.frod != null)
		{
			UnityEngine.Object.Destroy(this.frod);
		}
		this.frod = JLFJEGIPIMM.PKGMBFEMKGP().KBBOBGJHLJG("_HalfResolution");
		this.fish = this.frod.GetComponent<FishOnRod>();
		this.fish.BCMIIMNMKNO();
		this.fish.transform.position = base.transform.position - Vector3.up * 84f;
		this.fish.baitGO = base.transform.gameObject;
		this.fish.baitScrpt = this;
		this.fish.isGetBate = true;
		this.fish.klevMode = 1;
		this.fish.toKlevMode = 0;
		JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GMLFCKNNOPJ();
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM = true;
		switch (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			if (this.isTopDown)
			{
				if (OLPINJLCKCI.IFLFANPMLMM().FJEFHAGJDID(140f))
				{
					this.fish.klevMode = 6;
					this.fish.toKlevMode = 8;
					this.fish.podsekShanceVer = 1932f;
					return;
				}
			}
			else if (OLPINJLCKCI.OBDBAABBAKB().BFOFABOONEJ(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.FIAMGODLKFA()))
			{
				this.fish.isGetBate = true;
				this.fish.toKlevMode = 0;
				this.fish.klevMode = 6;
				this.fish.actTime = 1097f;
				this.fish.podsekShanceVer = 424f;
				return;
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			this.fish.isGetBate = false;
			Fisherman.getI.isPodsek = false;
			Fisherman.getI.PodsekType = 6;
			Fisherman.getI.podsek();
			if (LocNewLogic.getI.OGJHINOLHJJ - this.IIGDEPLPNME.y < 944f)
			{
				this.fish.FFKJCHNFGAF();
				LocNewLogic.getI.KBOPHDOEBNM(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB != null && OLPINJLCKCI.ODDOIHEPICE().BKKLJJLDFDO(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.KGKNPAAMDJK))
			{
				this.fish.isGetBate = false;
				this.fish.toKlevMode = 8;
				this.fish.podsekShanceVer = 740f;
				this.fish.klevMode = 3;
				this.fish.actTime = 155f;
				return;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06003C66 RID: 15462 RVA: 0x001B55CB File Offset: 0x001B37CB
	public bool GDLBENHLCEH()
	{
		return Time.time - this.MJNCFCNJOIM < 1378f;
	}

	// Token: 0x06003C67 RID: 15463 RVA: 0x001B55E0 File Offset: 0x001B37E0
	public void GAEFKMHIKPI()
	{
		if (this.fish != null && ObscuredBool.GOOIABGKMHK(this.fish.isPodsek))
		{
			return;
		}
		if (this.poplavok != null)
		{
			LocNewLogic.getI.FAMPBINAPBA(this.poplavok.transform.position, 5);
		}
		base.StartCoroutine(this.GLOBDICMAMO());
		this.PoplObj.SetActive(true);
		this.SpinObj.SetActive(true);
		this.FiderObj.SetActive(false);
		this.BAGEGHAHKFG();
		this.fishPointer = JLFJEGIPIMM.PKGMBFEMKGP().KBBOBGJHLJG("cut.ogg");
		this.mode = 1;
		if (this.fish != null)
		{
			this.fish.FMCKJLCPKJA();
		}
		this.CNKAKCCOLFL();
	}

	// Token: 0x06003C69 RID: 15465 RVA: 0x001B57C7 File Offset: 0x001B39C7
	private void OnGUI()
	{
		float waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
		Vector3 position = base.transform.position;
		float waterLevel2 = LocNewLogic.getI.OGJHINOLHJJ;
		LocNewLogic.getI.getDeepInPoint(base.transform.position);
		bool isEditor = Application.isEditor;
	}

	// Token: 0x06003C6A RID: 15466 RVA: 0x001B5808 File Offset: 0x001B3A08
	public void HDNFPHBIDOL(int INFHFKFJHHG)
	{
		if (Time.time - this.playBaitTime < 557f)
		{
			this.MJNCFCNJOIM = Time.time;
			return;
		}
		if (ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BNKBCOAANNG) > 1407f)
		{
			if (LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y < 1862f && this.lure != null)
			{
				this.lure.PDMNGJINGEI();
				if (this.lure.lureType == Lure.AKCCILPKJMN.CRL)
				{
					LocNewLogic.getI.createSmallWaterSplash(base.transform.position);
				}
			}
			this.playBaitTime = Time.time;
		}
	}

	// Token: 0x06003C6B RID: 15467 RVA: 0x001B58B8 File Offset: 0x001B3AB8
	public PoplDrop.DGLFOLICLDL MBPICCBMGJP()
	{
		return this.KNAHCJNDKKK;
	}

	// Token: 0x06003C6C RID: 15468 RVA: 0x001B58C0 File Offset: 0x001B3AC0
	public void JAFCHNJHOEO()
	{
		UnityEngine.Object.Destroy(this.frod);
		this.frod = null;
	}

	// Token: 0x06003C6D RID: 15469 RVA: 0x001B58D4 File Offset: 0x001B3AD4
	private void CBBLGEDCJBF()
	{
		Vector3 vector = base.transform.position - this.BAHHIKELOJP;
		vector.y = 1343f;
		float num = vector.magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (this.trail != null)
		{
			Vector3 position = base.transform.position;
			if (this.lure != null && this.lure.trailPoint != null)
			{
				position = this.lure.trailPoint.position;
			}
			position.y = LocNewLogic.getI.OGJHINOLHJJ + 1620f;
			this.trail.transform.position = position;
			bool emit = true;
			if (base.transform.position.y < LocNewLogic.getI.CDBIEPGNONF() + 1794f && base.transform.position.y > LocNewLogic.getI.HKBNODJBGEL() - 1535f)
			{
				emit = false;
			}
			this.trail.emit = emit;
			this.trail.initialColor = Color.Lerp(this.KKJLKIGNBIJ, this.KODIENKGJKD, num * 1190f);
		}
		if (this.lineTrail != null)
		{
			if (base.transform.position.y < LocNewLogic.getI.CDBIEPGNONF() - 1972f)
			{
				Vector3 vector2 = Vector3.zero;
				RaycastHit raycastHit;
				if (Physics.Raycast(new Ray(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, base.transform.position - BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.CNDKCPLCGAB()), out raycastHit, 1853f, LocNewLogic.getI.waterCheckRay))
				{
					vector2 = raycastHit.point;
				}
				float num2 = (vector2 - this.ODLPDNDEEHM).magnitude / Time.deltaTime;
				this.ODLPDNDEEHM = vector2;
				Vector3 position2 = vector2;
				position2.y = LocNewLogic.getI.CDBIEPGNONF() + 874f;
				this.lineTrail.transform.position = position2;
				bool emit2 = true;
				if (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BNKBCOAANNG) > 1497f)
				{
					emit2 = false;
				}
				this.lineTrail.emit = emit2;
				this.lineTrail.initialColor = Color.Lerp(this.COILGBLGMCC, this.OIIBMFNKGHK, num2 * 1034f);
			}
			else
			{
				this.lineTrail.emit = false;
			}
		}
		if (this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(LocNewLogic.getI.IGHOGONIKLC() - base.transform.position.y) < 1876f)
			{
				float a = 1171f * Mathf.Clamp(num * 604f, 1728f, 597f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1933f, 745f, 358f, a));
			}
			else
			{
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(217f, 1672f, 1855f, 309f));
			}
		}
		if (this.mode != 3)
		{
			this.POADDIBLBJH(false);
		}
		this.isTopDown = true;
		if (Mathf.Abs(base.transform.position.y - LocNewLogic.getI.OGJHINOLHJJ) < 624f)
		{
			this.isTopDown = true;
		}
		base.transform.position.y = LocNewLogic.getI.CDBIEPGNONF() + 321f;
		this.EDDECMJHECC();
		if (this.connectorRbody.isKinematic)
		{
			float d = 73f;
			if (this.IKCDMNGBAAH)
			{
				d = 623f;
			}
			if (this.fish != null && this.fish.isGetBate)
			{
				d = 767f;
			}
			base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
			if (this.fish == null)
			{
				float num3 = Vector3.Distance(Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC, base.transform.position);
				float num4 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 522f;
				if (num3 > num4)
				{
					Vector3 vector3 = base.transform.position - Fisherman.getI.EACGPPOMFLH().CNDKCPLCGAB();
					vector3.Normalize();
					vector3 *= num4;
					base.transform.position = Fisherman.getI.IJMGCKIOBPP().CNDKCPLCGAB() + vector3;
				}
			}
			Vector3 worldPosition = Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC;
			worldPosition.y = base.transform.position.y + 1291f;
			if (this.poplavok != null)
			{
				worldPosition = this.poplavok.transform.position;
			}
			base.transform.LookAt(worldPosition);
			base.transform.Rotate(835f, 322f, 946f);
			float num5 = Vector3.Distance(base.transform.position, Fisherman.getI.IJMGCKIOBPP().ILCJJKCPBKC);
			this.SpinObj.transform.localRotation = Quaternion.Euler(509f, num5 * 75f, 503f);
		}
		this.BBKPOKNIAEG += Time.deltaTime;
		if (this.poplScript != null)
		{
			this.poplScript.takeFish = (this.fish != null && this.fish.isGetBate);
		}
		if (this.fishPointer != null && this.fish != null)
		{
			Vector3 position3 = this.fish.gameObject.transform.position;
			position3.y = LocNewLogic.getI.HKBNODJBGEL();
			this.fishPointer.transform.position = position3;
		}
		if (this.poplCamera != null)
		{
			if (Input.GetKey((KeyCode)156))
			{
				this.KBNKBLGMFAA -= 1018f;
				Debug.Log("_SampleScale" + this.KBNKBLGMFAA);
			}
			if (Input.GetKey((KeyCode)(-180)))
			{
				this.KBNKBLGMFAA += 1200f;
				Debug.Log("Bone 2 of a BipedReferences limb is null." + this.KBNKBLGMFAA);
			}
			Camera component = this.poplCamera.GetComponent<Camera>();
			if (component != null)
			{
				component.fieldOfView = this.BCKEILBFCNM;
			}
			Fisherman.getI.transform.position + Vector3.up * this.KBNKBLGMFAA;
			if (this.poplavok != null)
			{
				Vector3 normalized = (Fisherman.getI.transform.position + Vector3.up * 1918f - this.poplavok.transform.position).normalized;
				Vector3 b = this.poplavok.transform.position + normalized * this.cdist;
				b.y = LocNewLogic.getI.CDBIEPGNONF() + this.popCamHgt;
				this.poplCamera.transform.position = Vector3.Lerp(this.poplCamera.transform.position, b, Time.deltaTime * 549f);
				Vector3 position4 = this.poplavok.transform.position;
				position4.y = LocNewLogic.getI.CDBIEPGNONF();
				this.poplCamera.transform.LookAt(position4 + Vector3.up * 54f);
				if (this.pPricel != null)
				{
					this.pPricel.transform.position = position4;
				}
			}
		}
		switch (this.mode)
		{
		case 1:
		{
			this.JEHEPNHGJOH += Time.deltaTime;
			this.IIGDEPLPNME = this.fromPos + this.JAJMIJPIDBL * this.speed * this.JEHEPNHGJOH;
			float num6 = Vector3.Distance(this.fromPos, this.IIGDEPLPNME);
			float f = 1292f * num6 / this.GADFHLLJKOH;
			float num7 = 598f * this.GADFHLLJKOH * 1261f;
			float num8 = Mathf.Sin(f) * num7;
			this.IIGDEPLPNME.y = this.IIGDEPLPNME.y + num8;
			base.transform.position = this.IIGDEPLPNME;
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(Vector3.Distance(base.transform.position, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPointNonBend.transform.position) * 1469f);
			base.transform.LookAt(this.toPos);
			base.transform.Rotate(122f, Time.time * Time.deltaTime * 1680f, 530f);
			this.poplavok != null;
			if (base.transform.position.y < LocNewLogic.getI.CDBIEPGNONF())
			{
				float num9 = 480f;
				if (this.JLBEJHDECGK() == (PoplDrop.DGLFOLICLDL)6)
				{
					num9 = 444f;
				}
				BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ALKAGOMNNOK) + num9);
				this.mode = 1;
				this.waterBaitTime = Time.time;
				if (BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL != null && BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.MBKMKGABBGE == -41)
				{
					int ilockjiapfc = BOIKJDICEMF.IKGFHGKKCPG.KBNMKAMMOKM().BDHHPAEHFHG.ILOCKJIAPFC;
				}
				switch (this.MBPICCBMGJP())
				{
				case PoplDrop.DGLFOLICLDL.Poplavok:
					FBFJFAKAGJG.IKGFHGKKCPG.CGEKMDKCDGP("non MonoBehaviour", base.transform.position, 411f, 1349f, 1354f);
					LocNewLogic.getI.HALCKEHLBLM(base.transform.position);
					break;
				case PoplDrop.DGLFOLICLDL.Fider:
					FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("_MainTex", base.transform.position, 1769f, 1405f, 1650f);
					LocNewLogic.getI.createWaterJampSplash(base.transform.position, 1423f);
					LocNewLogic.getI.createWaterCircle(base.transform.position, 3);
					LocNewLogic.getI.HALCKEHLBLM(base.transform.position);
					break;
				case PoplDrop.DGLFOLICLDL.Spin:
					FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("_ScaleOffsetRes", base.transform.position, 1343f, 1889f, 836f);
					LocNewLogic.getI.CAHONDGOHFB(base.transform.position);
					base.StartCoroutine(this.LFAALHBNIDJ());
					break;
				}
			}
			break;
		}
		case 2:
		{
			this.JEHEPNHGJOH += Time.deltaTime;
			if (this.KODFBJFCPAJ == PoplDrop.DGLFOLICLDL.Poplavok && this.poplavok != null)
			{
				if (this.poplavok.transform.position.y > LocNewLogic.getI.HKBNODJBGEL())
				{
					Vector3 a2 = new Vector3(base.transform.position.x, LocNewLogic.getI.HKBNODJBGEL(), base.transform.position.z) - this.poplavok.transform.position;
					a2.Normalize();
					this.IIGDEPLPNME = this.poplavok.transform.position;
					this.IIGDEPLPNME += a2 * this.speed * 688f * Time.deltaTime;
					this.poplavok.transform.position = this.IIGDEPLPNME;
				}
				else if (this.poplScript != null)
				{
					this.poplScript.isWork = false;
				}
				if (!this.MADOEDALIHK && base.transform.position.y <= LocNewLogic.getI.CDBIEPGNONF())
				{
					if (this.poplCamera == null)
					{
						this.ANKIMABFEHM();
					}
					LocNewLogic.getI.FAMPBINAPBA(this.poplavok.transform.position, 5);
					if (this.poplScript != null)
					{
						this.poplScript.isWork = true;
					}
					this.poplavok.transform.rotation = Quaternion.Euler(706f, UnityEngine.Random.value * 551f - 266f, 780f);
					this.poplavok.transform.position = new Vector3(this.poplavok.transform.position.x, LocNewLogic.getI.HKBNODJBGEL(), this.poplavok.transform.position.z);
					this.MADOEDALIHK = false;
				}
			}
			this.IIGDEPLPNME = base.transform.position;
			this.deep = LocNewLogic.getI.getDeepInPoint(base.transform.position);
			this.wlevel = LocNewLogic.getI.CDBIEPGNONF();
			switch (this.GIGAPNDNOKC())
			{
			case PoplDrop.DGLFOLICLDL.Poplavok:
				if (this.IIGDEPLPNME.y >= this.deep)
				{
					BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
					if (LocNewLogic.getI.CDBIEPGNONF() - base.transform.position.y <= bgjkmcbhnak.FAFHKDGNCLH - 1630f)
					{
						float num10 = 253f + bgjkmcbhnak.ILOBPLGPOCO() / 187f;
						num10 = Mathf.Clamp(num10, 606f, 980f);
						bool flag = true;
						if (this.fish != null)
						{
							flag = !this.fish.isGetBate;
						}
						if (flag)
						{
							this.IIGDEPLPNME.y = this.IIGDEPLPNME.y - num10 * Time.deltaTime;
						}
						if (this.IIGDEPLPNME.y > LocNewLogic.getI.OGJHINOLHJJ)
						{
							this.IIGDEPLPNME.y = LocNewLogic.getI.CDBIEPGNONF();
						}
						if (LocNewLogic.getI.OGJHINOLHJJ - this.IIGDEPLPNME.y > bgjkmcbhnak.FAFHKDGNCLH)
						{
							this.IIGDEPLPNME.y = LocNewLogic.getI.OGJHINOLHJJ - bgjkmcbhnak.DCICGEENANE();
						}
						this.isKlevEnable = true;
						if (flag)
						{
							base.transform.position = this.IIGDEPLPNME;
						}
					}
					else
					{
						this.isKlevEnable = true;
					}
				}
				else if (LocNewLogic.getI.HKBNODJBGEL() - base.transform.position.y >= BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().FAFHKDGNCLH - 149f)
				{
					this.isKlevEnable = true;
				}
				break;
			case PoplDrop.DGLFOLICLDL.Fider:
				if (this.IIGDEPLPNME.y >= this.deep)
				{
					BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak2 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
					float num11 = 1505f + bgjkmcbhnak2.ILOBPLGPOCO() / 1052f;
					num11 = Mathf.Clamp(num11, 1169f, 1154f);
					bool flag2 = true;
					if (this.fish != null)
					{
						flag2 = !this.fish.isGetBate;
					}
					if (flag2)
					{
						this.IIGDEPLPNME.y = this.IIGDEPLPNME.y - num11 * Time.deltaTime;
					}
					if (flag2)
					{
						base.transform.position = this.IIGDEPLPNME;
					}
				}
				else
				{
					this.isKlevEnable = false;
				}
				break;
			case PoplDrop.DGLFOLICLDL.Spin:
				if (ObscuredFloat.EJGOOFALNFF(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK) > BOIKJDICEMF.IKGFHGKKCPG.CHCJILPBABD())
				{
					Fisherman.getI.CIHILMCEJND = false;
					return;
				}
				this.isKlevEnable = this.LJLKMCEKBAP();
				if (this.BGAOINIIDNI())
				{
					float num12 = LocNewLogic.getI.OGJHINOLHJJ - this.IIGDEPLPNME.y;
				}
				break;
			}
			this.IKCDMNGBAAH = (this.IIGDEPLPNME.y < this.deep + 1928f);
			Vector3 vector4 = Fisherman.getI.MOCNPMIACDL();
			vector4.y = Fisherman.getI.transform.position.y;
			float num13 = Vector3.Distance(Fisherman.getI.transform.position, vector4);
			vector4 = Fisherman.getI.transform.position;
			vector4.y = base.transform.position.y;
			if (Vector3.Distance(vector4, base.transform.position) < num13 + 1406f)
			{
				this.isKlevEnable = false;
			}
			if (this.isKlevEnable && this.JLBEJHDECGK() == PoplDrop.DGLFOLICLDL.Poplavok)
			{
				base.transform.position.y = LocNewLogic.getI.IGHOGONIKLC() - 232f;
			}
			if (!BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM && this.isKlevEnable)
			{
				TimeSpan t = new TimeSpan(0, 1, 1, 1);
				if (DateTime.Now - this.FOOCGDPOFDK > t)
				{
					EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
					try
					{
						BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak3 = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
						epmphjgalbe.JDOLCNDNFGP(BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ());
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(base.transform.position));
						epmphjgalbe.JGINHHABOGM(new IIBEEKCAAHK(JLFJEGIPIMM.IKGFHGKKCPG.GPDDENFCGKB(base.transform.position)));
						float num14 = LocNewLogic.getI.HKBNODJBGEL() - base.transform.position.y;
						float num15 = LocNewLogic.getI.HKBNODJBGEL() - LocNewLogic.getI.getDeepInPoint(base.transform.position);
						epmphjgalbe.BCOMDIELFDL(num14 * 738f);
						epmphjgalbe.HNOBFLOGNHJ(num15 * 1543f);
						epmphjgalbe.PMJPIJMHELL((bgjkmcbhnak3.AMLEOGHNNPG[0] != null) ? bgjkmcbhnak3.AMLEOGHNNPG[1].LPFKFNLHGBI : 0L);
						epmphjgalbe.MFPECHIKBCO((bgjkmcbhnak3.AMLEOGHNNPG[0] != null) ? bgjkmcbhnak3.AMLEOGHNNPG[0].LPFKFNLHGBI : 1L);
						epmphjgalbe.OACBICLGENB((bgjkmcbhnak3.AMLEOGHNNPG[3] != null) ? bgjkmcbhnak3.AMLEOGHNNPG[7].LPFKFNLHGBI : 0L);
						epmphjgalbe.APLCAMNONBD(this.KBOOCAJMJNA());
						epmphjgalbe.PJIABBIPPNH(this.IKCDMNGBAAH);
						epmphjgalbe.LNFLEDCCKKF(this.isTopDown);
						epmphjgalbe.IECHKLACNFM(this.CAAOPCDJPOM());
						epmphjgalbe.IECHKLACNFM(this.DNFJJONFBBK());
						epmphjgalbe.KJDIGAKNOAI(this.NDJPNHPNECP());
						epmphjgalbe.CFIKDLDBNHI(this.EPKHGNNIJGD);
						Vector3 vector5 = Fisherman.getI.transform.position - base.transform.position;
						vector5.y = 1184f;
						epmphjgalbe.KHMBNICGPKC(vector5.magnitude);
						NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(-108, epmphjgalbe.HDEKHFOKCKI());
						this.FOOCGDPOFDK = DateTime.Now;
					}
					finally
					{
						epmphjgalbe.PGLFHABMJPO();
					}
				}
			}
			break;
		}
		}
		if (this.lure != null)
		{
			this.lure.FKIHJALPLJK(this.MJFNOFCLLHJ, 1039f);
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06003C6F RID: 15471 RVA: 0x001B58B8 File Offset: 0x001B3AB8
	// (set) Token: 0x06003CCE RID: 15566 RVA: 0x001BB92C File Offset: 0x001B9B2C
	public PoplDrop.DGLFOLICLDL KODFBJFCPAJ
	{
		get
		{
			return this.KNAHCJNDKKK;
		}
		set
		{
			this.KNAHCJNDKKK = value;
			this.PoplObj.SetActive(false);
			this.SpinObj.SetActive(false);
			this.FiderObj.SetActive(false);
			this.Koleb.SetActive(false);
			this.Vertu.SetActive(false);
			this.Vobler.SetActive(false);
			this.Jig.SetActive(false);
			if (this.bmod == null)
			{
				if (this.KNAHCJNDKKK == PoplDrop.DGLFOLICLDL.Poplavok)
				{
					this.PoplObj.SetActive(true);
				}
				if (this.KNAHCJNDKKK == PoplDrop.DGLFOLICLDL.Fider)
				{
					this.FiderObj.SetActive(true);
				}
				if (this.KNAHCJNDKKK == PoplDrop.DGLFOLICLDL.Spin)
				{
					switch (BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.BDHHPAEHFHG.ILOCKJIAPFC)
					{
					case 4:
						this.Koleb.SetActive(true);
						return;
					case 5:
						this.Vertu.SetActive(true);
						return;
					case 6:
						this.Jig.SetActive(true);
						return;
					case 7:
						this.Vobler.SetActive(true);
						break;
					default:
						return;
					}
				}
			}
		}
	}

	// Token: 0x06003C70 RID: 15472 RVA: 0x001B6C5B File Offset: 0x001B4E5B
	public bool JBNPMPDEMLD()
	{
		return Time.time - this.groutBaitTime < 1375f;
	}

	// Token: 0x06003C71 RID: 15473 RVA: 0x001B6C70 File Offset: 0x001B4E70
	public void PhysicOnOff(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA == this.ADLIOAFMGMA)
		{
			return;
		}
		if (AFECKMFDAEA)
		{
			if (this.physBait != null)
			{
				this.physBait.init(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPointNonBend.transform, true);
				BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(this.physBait.lineCountMetr);
			}
			this.connectorRbody.useGravity = false;
			this.connectorRbody.isKinematic = false;
			this.connectorRbody.velocity = Vector3.zero;
			this.GBEIDPOCJBF = base.transform.position;
			this.connectorRbody.transform.parent = null;
			this.ADLIOAFMGMA = true;
			return;
		}
		this.ADLIOAFMGMA = false;
		this.rbody.isKinematic = true;
		this.connectorRbody.isKinematic = true;
		this.connectorRbody.useGravity = false;
		this.rbody.useGravity = false;
		this.connectorRbody.transform.parent = base.transform;
		if (this.physBait != null)
		{
			this.physBait.init(null, false);
		}
	}

	// Token: 0x06003C72 RID: 15474 RVA: 0x001B6D94 File Offset: 0x001B4F94
	public void MDAENCJKIBI(int BBOODPCDKAJ, float HOKMGFFGDDM, bool LIGPAKINNGK = true)
	{
		if (Time.time - this.CHKKHJDMMIF < 889f)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		float num = 643f + (float)BBOODPCDKAJ * 972f;
		bgjkmcbhnak.MIHODKKEDMK(ObscuredFloat.HLEMAJBAAEO(ObscuredFloat.EJGOOFALNFF(bgjkmcbhnak.GIMGAKKKHLF) + num));
		bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.AJMPAOCEPCA(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.EALPPCJHPKG) + num);
		bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.OBJFODGFMAM(bgjkmcbhnak.GIMGAKKKHLF), 28f, 1226f));
		bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.AJMPAOCEPCA(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.EALPPCJHPKG), 1363f, 1027f));
		BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.fiderForce += 379f + OLPINJLCKCI.OBDBAABBAKB().LLNEEEJIDGI((double)(num * 12f));
		if (LIGPAKINNGK)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.CFMFFHMGDPP(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, (int)(num / 759f));
		}
		this.CHKKHJDMMIF = Time.time;
	}

	// Token: 0x06003C73 RID: 15475 RVA: 0x001B6EA4 File Offset: 0x001B50A4
	public void fiderDerg(int BBOODPCDKAJ, float HOKMGFFGDDM, bool LIGPAKINNGK = true)
	{
		if (Time.time - this.CHKKHJDMMIF < 0.3f)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		float num = 3.5f + (float)BBOODPCDKAJ * 5f;
		bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMGAKKKHLF) + num);
		bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.EALPPCJHPKG) + num);
		bgjkmcbhnak.GIMGAKKKHLF = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.GIMGAKKKHLF), 0f, 80f));
		bgjkmcbhnak.EALPPCJHPKG = ObscuredFloat.GOOIABGKMHK(Mathf.Clamp(ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.EALPPCJHPKG), 0f, 80f));
		BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.fiderForce += 5f + OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)(num * 2f));
		if (LIGPAKINNGK)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DEEENJMPIHN(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, (int)(num / 8f));
		}
		this.CHKKHJDMMIF = Time.time;
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x06003C74 RID: 15476 RVA: 0x001B6FB4 File Offset: 0x001B51B4
	public bool GHOFIEDNCIJ
	{
		get
		{
			return Time.time - this.waterBaitTime < 1.5f;
		}
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06003C75 RID: 15477 RVA: 0x001B6FCC File Offset: 0x001B51CC
	private float MBBPHACDFMJ
	{
		get
		{
			float num = ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK);
			num += this.lineDelta;
			return Mathf.Lerp(this.physBait.lineCountMetr, num, Time.fixedDeltaTime * 2.2f);
		}
	}

	// Token: 0x06003C76 RID: 15478 RVA: 0x001B7018 File Offset: 0x001B5218
	public void NNNOMNMLKFB()
	{
		if (this.frod != null)
		{
			UnityEngine.Object.Destroy(this.frod);
		}
		this.frod = JLFJEGIPIMM.PKGMBFEMKGP().HDAFGAPECEO("Mouse ScrollWheel");
		this.fish = this.frod.GetComponent<FishOnRod>();
		this.fish.init();
		this.fish.transform.position = base.transform.position - Vector3.up * 892f;
		this.fish.baitGO = base.transform.gameObject;
		this.fish.baitScrpt = this;
		this.fish.isGetBate = false;
		this.fish.klevMode = 0;
		this.fish.toKlevMode = 1;
		JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.GMLFCKNNOPJ();
		BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().CDNABIHPLHM = true;
		switch (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			if (this.isTopDown)
			{
				if (OLPINJLCKCI.OBDBAABBAKB().DNACBBBFDGM(823f))
				{
					this.fish.klevMode = 4;
					this.fish.toKlevMode = 6;
					this.fish.podsekShanceVer = 1114f;
					return;
				}
			}
			else if (OLPINJLCKCI.ODDOIHEPICE().KEPABCCPCDB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.MLOEJFMIAIP()))
			{
				this.fish.isGetBate = true;
				this.fish.toKlevMode = 6;
				this.fish.klevMode = 5;
				this.fish.actTime = 1407f;
				this.fish.podsekShanceVer = 889f;
				return;
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			this.fish.isGetBate = false;
			Fisherman.getI.isPodsek = false;
			Fisherman.getI.PodsekType = 3;
			Fisherman.getI.podsek();
			if (LocNewLogic.getI.CDBIEPGNONF() - this.IIGDEPLPNME.y < 985f)
			{
				this.fish.Jamp();
				LocNewLogic.getI.AAMKFMGGMFJ(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().NKHBAJKMAGD));
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BCKECOENDLB != null && OLPINJLCKCI.NLOGJHEFMHM().GEEBEANHLFD(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BCKECOENDLB.LODGJCMEGAI.KGKNPAAMDJK))
			{
				this.fish.isGetBate = true;
				this.fish.toKlevMode = 4;
				this.fish.podsekShanceVer = 948f;
				this.fish.klevMode = 4;
				this.fish.actTime = 364f;
				return;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06003C77 RID: 15479 RVA: 0x001B72D7 File Offset: 0x001B54D7
	public bool INIDCFGHBDM()
	{
		return Time.time - this.MJNCFCNJOIM < 890f;
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06003C78 RID: 15480 RVA: 0x001B72EC File Offset: 0x001B54EC
	public bool KJAMHFJJHIE
	{
		get
		{
			return Time.time - this.playBaitTime < 4f;
		}
	}

	// Token: 0x06003C79 RID: 15481 RVA: 0x001B7301 File Offset: 0x001B5501
	public bool IAPGMKFIAGH()
	{
		return Time.time - this.groutBaitTime < 303f;
	}

	// Token: 0x06003C7A RID: 15482 RVA: 0x001B4542 File Offset: 0x001B2742
	private IEnumerator OKFKNOKDMCE()
	{
		yield return new WaitForSeconds(2f);
		this.BFAKJFDMPJI();
		yield break;
	}

	// Token: 0x06003C7B RID: 15483 RVA: 0x001B7318 File Offset: 0x001B5518
	private void LateUpdate()
	{
		this.AGBEBCGAACP = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC;
		this.EDDECMJHECC();
		int num = this.mode;
		if (!this.connectorRbody.isKinematic && Vector3.Distance(base.transform.position, this.connectorRbody.transform.position) > 0.005f)
		{
			float t = Time.deltaTime * 10f;
			Vector3 vector = this.AGBEBCGAACP - base.transform.position;
			if (base.transform.position.y < LocNewLogic.getI.OGJHINOLHJJ + 0.03f)
			{
				vector.y /= 3f;
			}
			Vector3 up = Vector3.up;
			if (this.connectorRbody.useGravity)
			{
				up = base.transform.up;
			}
			Quaternion b = Quaternion.LookRotation(vector, up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, t);
			base.transform.position = Vector3.Lerp(base.transform.position, this.connectorRbody.transform.position, t);
		}
		float num2 = LocNewLogic.getI.getDeepInPoint(this.connectorRbody.transform.position) - 0.1f;
		if (base.transform.position.y < num2)
		{
			Vector3 position = base.transform.position;
			position.y = num2;
			base.transform.position = position;
			this.IKCDMNGBAAH = true;
		}
		if (this.connectorRbody.transform.position.y < num2)
		{
			Vector3 position2 = this.connectorRbody.transform.position;
			position2.y = num2;
			this.connectorRbody.transform.position = position2;
			this.IKCDMNGBAAH = true;
		}
	}

	// Token: 0x06003C7C RID: 15484 RVA: 0x001B74F8 File Offset: 0x001B56F8
	public void drop()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		float dkihdoelfeh = Vector3.Distance(this.toPos, Fisherman.getI.transform.position);
		float num = BOIKJDICEMF.IKGFHGKKCPG.HLNMIAPENEO(dkihdoelfeh);
		float num2 = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK((double)num);
		float f = OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(6.2831854820251465);
		this.toPos.x = this.toPos.x + Mathf.Cos(f) * num2;
		this.toPos.z = this.toPos.z + Mathf.Sin(f) * num2;
		bgjkmcbhnak.CDNABIHPLHM = false;
		this.MADOEDALIHK = false;
		this.mode = 1;
		this.JAJMIJPIDBL = this.toPos - this.fromPos;
		this.JAJMIJPIDBL.Normalize();
		this.GADFHLLJKOH = Vector3.Distance(this.fromPos, this.toPos);
		this.JEHEPNHGJOH = 0f;
		this.FMPGPPIMBNG = new Vector3(OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(0.0) - 0f, 0f, OLPINJLCKCI.IKGFHGKKCPG.JNFGOGFFLKK(0.0) - 0f);
		switch (this.KODFBJFCPAJ)
		{
		case PoplDrop.DGLFOLICLDL.Poplavok:
		{
			this.poplavok = JLFJEGIPIMM.IKGFHGKKCPG.LMFEHHFPAAA("Poplavok", Vector3.zero, null);
			this.poplScript = this.poplavok.GetComponent<Poplavok>();
			this.poplScript.baitObj = base.transform.gameObject;
			Vector3 a = this.AGBEBCGAACP - base.transform.position;
			a.Normalize();
			a *= BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH;
			this.poplavok.transform.LookAt(this.AGBEBCGAACP);
			this.poplavok.transform.Rotate(new Vector3(90f, 0f, 0f));
			this.speed = 8f;
			this.poplScript.rotAngle = 0f;
			this.poplScript.rotWAngle = UnityEngine.Random.value * 360f;
			this.poplScript.isWork = false;
			this.poplScript.Init();
			bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
			this.pPricel = JLFJEGIPIMM.IKGFHGKKCPG.CPHOBOJJPFB("PPricel");
			this.pPricel.transform.position = new Vector3(this.toPos.x, LocNewLogic.getI.OGJHINOLHJJ, this.toPos.z);
			return;
		}
		case PoplDrop.DGLFOLICLDL.Fider:
			this.poplavok = null;
			this.poplScript = null;
			this.speed = 14f;
			this.mode = 1;
			Debug.Log("fider drop");
			return;
		case PoplDrop.DGLFOLICLDL.Spin:
			this.poplavok = null;
			this.poplScript = null;
			this.speed = 18f;
			this.mode = 1;
			Debug.Log("spindrop");
			return;
		default:
			return;
		}
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x06003C7D RID: 15485 RVA: 0x001B77E4 File Offset: 0x001B59E4
	public bool CMHKMKGPNJB
	{
		get
		{
			bool result = false;
			if (this.JMJEFKLOKLL)
			{
				result = true;
			}
			if (this.KJAMHFJJHIE)
			{
				result = true;
			}
			if (this.AAAIKLHMHEF)
			{
				result = true;
			}
			return result;
		}
	}

	// Token: 0x06003C7E RID: 15486 RVA: 0x001B7812 File Offset: 0x001B5A12
	public bool FOAAJFCBLIO()
	{
		return Time.time - this.MJNCFCNJOIM < 1859f;
	}

	// Token: 0x06003C7F RID: 15487 RVA: 0x001B44BC File Offset: 0x001B26BC
	public void BDMCGLGJKOF()
	{
		if (this.bmod != null)
		{
			UnityEngine.Object.Destroy(this.bmod);
		}
		this.bmod = null;
	}

	// Token: 0x06003C80 RID: 15488 RVA: 0x001B7828 File Offset: 0x001B5A28
	public void BAOONCLOIJL(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA == this.ADLIOAFMGMA)
		{
			return;
		}
		if (AFECKMFDAEA)
		{
			if (this.physBait != null)
			{
				this.physBait.IJDNNNOFGBI(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPointNonBend.transform, true);
				BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DNPDBOODCHK = ObscuredFloat.HLEMAJBAAEO(this.physBait.lineCountMetr);
			}
			this.connectorRbody.useGravity = false;
			this.connectorRbody.isKinematic = false;
			this.connectorRbody.velocity = Vector3.zero;
			this.GBEIDPOCJBF = base.transform.position;
			this.connectorRbody.transform.parent = null;
			this.ADLIOAFMGMA = true;
			return;
		}
		this.ADLIOAFMGMA = true;
		this.rbody.isKinematic = false;
		this.connectorRbody.isKinematic = true;
		this.connectorRbody.useGravity = true;
		this.rbody.useGravity = false;
		this.connectorRbody.transform.parent = base.transform;
		if (this.physBait != null)
		{
			this.physBait.NEJGJLIAOID(null, false);
		}
	}

	// Token: 0x06003C81 RID: 15489 RVA: 0x001B4542 File Offset: 0x001B2742
	private IEnumerator BCJEHOKBKEH()
	{
		yield return new WaitForSeconds(2f);
		this.BFAKJFDMPJI();
		yield break;
	}

	// Token: 0x06003C82 RID: 15490 RVA: 0x001B794C File Offset: 0x001B5B4C
	public void podsekAction()
	{
		if (this.fish != null && ObscuredBool.GOOIABGKMHK(this.fish.isPodsek))
		{
			return;
		}
		if (this.poplavok != null)
		{
			LocNewLogic.getI.createWaterCircleSmall(this.poplavok.transform.position, 2);
		}
		base.StartCoroutine(this.DNJFOAENNFL());
		this.PoplObj.SetActive(false);
		this.SpinObj.SetActive(false);
		this.FiderObj.SetActive(false);
		this.killBaitModel();
		this.fishPointer = JLFJEGIPIMM.IKGFHGKKCPG.CPHOBOJJPFB("FishPointer");
		this.mode = 4;
		if (this.fish != null)
		{
			this.fish.fishPodsek();
		}
		this.killPodsek();
	}

	// Token: 0x06003C83 RID: 15491 RVA: 0x001B7A18 File Offset: 0x001B5C18
	private void PCKLHLGIEAE()
	{
		LineRope.getI.targetPoint.position = base.transform.position;
		this.LR.enabled = true;
		BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DFBHMIIPLCA;
		Vector3 position = base.transform.position;
		if (this.fish != null)
		{
			position = this.fish.transform.position;
			if (this.fish.hookPoint != null)
			{
				position = this.fish.hookPoint.transform.position;
			}
		}
		if (this.poplavok != null && this.mode == 0)
		{
			Vector3 vector = this.AGBEBCGAACP - position;
			Vector3 normalized = vector.normalized;
			this.poplavok.transform.position = position + normalized * Mathf.Min(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH, vector.magnitude - 1077f);
			this.poplavok.transform.LookAt(position);
			this.poplavok.transform.Rotate(875f, 522f, 277f);
		}
	}

	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06003C84 RID: 15492 RVA: 0x001B7B50 File Offset: 0x001B5D50
	public bool FOEBNECJPOL
	{
		get
		{
			return Time.time - this.MJNCFCNJOIM < 3f;
		}
	}

	// Token: 0x06003C85 RID: 15493 RVA: 0x001B7B65 File Offset: 0x001B5D65
	public void LBPPLEHAJMO(bool DCCPCBLODIG)
	{
		if (this.EHGOFGHNIFE != DCCPCBLODIG && DCCPCBLODIG)
		{
			this.PHLKADHICCJ();
		}
		this.EHGOFGHNIFE = DCCPCBLODIG;
	}

	// Token: 0x06003C86 RID: 15494 RVA: 0x001B7B80 File Offset: 0x001B5D80
	public void playBaitEvnt(int INFHFKFJHHG)
	{
		if (Time.time - this.playBaitTime < 1f)
		{
			this.MJNCFCNJOIM = Time.time;
			return;
		}
		if (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BNKBCOAANNG) > 0f)
		{
			if (LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y < 0.1f && this.lure != null)
			{
				this.lure.playEvent();
				if (this.lure.lureType == Lure.AKCCILPKJMN.Popper)
				{
					LocNewLogic.getI.createSmallWaterSplash(base.transform.position);
				}
			}
			this.playBaitTime = Time.time;
		}
	}

	// Token: 0x06003C87 RID: 15495 RVA: 0x001B7C30 File Offset: 0x001B5E30
	private void DBKDHMONHNB()
	{
		if (this.connectorRbody != null)
		{
			UnityEngine.Object.Destroy(this.connectorRbody.gameObject);
		}
		if (this.trail != null)
		{
			this.trail.emit = false;
			UnityEngine.Object.Destroy(this.trail.gameObject, 890f);
		}
		if (this.lineTrail != null)
		{
			this.lineTrail.emit = false;
			UnityEngine.Object.Destroy(this.lineTrail.gameObject, 415f);
		}
		if (this.partSys != null)
		{
			this.partSys.transform.parent = null;
			this.partSys.main.startColor = new ParticleSystem.MinMaxGradient(new Color(673f, 1736f, 879f, 952f));
			UnityEngine.Object.Destroy(this.partSys.gameObject, 984f);
		}
	}

	// Token: 0x06003C88 RID: 15496 RVA: 0x001B4E5D File Offset: 0x001B305D
	private IEnumerator FOEMAKIJFOH()
	{
		this.JMJEFKLOKLL = true;
		for (;;)
		{
			a = base.transform.position;
			yield return new WaitForSeconds(0.5f);
			this.JMJEFKLOKLL = (Vector3.Distance(a, base.transform.position) > 0.02f);
			this.provType = 0;
			this.evntList.Clear();
			if (!Fisherman.getI.isPodsek)
			{
				if (this.AAAIKLHMHEF)
				{
					this.evntList.Add(2);
				}
				if (this.GHOFIEDNCIJ)
				{
					this.evntList.Add(1);
				}
				if (this.KODFBJFCPAJ == PoplDrop.DGLFOLICLDL.Spin)
				{
					switch (BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.BDHHPAEHFHG.ILOCKJIAPFC)
					{
					case 4:
						if (this.rolltime > 3f)
						{
							this.provType = 1;
							if (this.FOEBNECJPOL)
							{
								this.provType = 0;
							}
							if (this.KJAMHFJJHIE)
							{
								this.provType = 2;
							}
						}
						break;
					case 5:
						if (this.rolltime > 2f)
						{
							this.provType = 1;
						}
						if (this.KJAMHFJJHIE)
						{
							this.provType = 0;
						}
						if (this.FOEBNECJPOL)
						{
							this.provType = 0;
						}
						break;
					case 6:
						if (this.rolltime > 3f)
						{
							if (this.FOEBNECJPOL)
							{
								this.provType = 0;
							}
							if (this.KJAMHFJJHIE)
							{
								this.provType = 3;
							}
						}
						break;
					case 7:
						if (this.rolltime > 3f)
						{
							if (this.FOEBNECJPOL)
							{
								this.provType = 0;
							}
							if (this.KJAMHFJJHIE)
							{
								this.provType = 4;
							}
						}
						break;
					}
				}
				a = default(Vector3);
			}
		}
		yield break;
	}

	// Token: 0x06003C89 RID: 15497 RVA: 0x001B7D20 File Offset: 0x001B5F20
	private void Update()
	{
		Vector3 vector = base.transform.position - this.BAHHIKELOJP;
		vector.y = 0f;
		float num = vector.magnitude / Time.deltaTime;
		this.BAHHIKELOJP = base.transform.position;
		if (this.trail != null)
		{
			Vector3 position = base.transform.position;
			if (this.lure != null && this.lure.trailPoint != null)
			{
				position = this.lure.trailPoint.position;
			}
			position.y = LocNewLogic.getI.OGJHINOLHJJ + 0.02f;
			this.trail.transform.position = position;
			bool emit = false;
			if (base.transform.position.y < LocNewLogic.getI.OGJHINOLHJJ + 0.1f && base.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ - 0.15f)
			{
				emit = true;
			}
			this.trail.emit = emit;
			this.trail.initialColor = Color.Lerp(this.KKJLKIGNBIJ, this.KODIENKGJKD, num * 1f);
		}
		if (this.lineTrail != null)
		{
			if (base.transform.position.y < LocNewLogic.getI.OGJHINOLHJJ - 0.1f)
			{
				Vector3 vector2 = Vector3.zero;
				RaycastHit raycastHit;
				if (Physics.Raycast(new Ray(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC, base.transform.position - BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC), out raycastHit, 500f, LocNewLogic.getI.waterCheckRay))
				{
					vector2 = raycastHit.point;
				}
				float num2 = (vector2 - this.ODLPDNDEEHM).magnitude / Time.deltaTime;
				this.ODLPDNDEEHM = vector2;
				Vector3 position2 = vector2;
				position2.y = LocNewLogic.getI.OGJHINOLHJJ + 0.02f;
				this.lineTrail.transform.position = position2;
				bool emit2 = false;
				if (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BNKBCOAANNG) > 0.001f)
				{
					emit2 = true;
				}
				this.lineTrail.emit = emit2;
				this.lineTrail.initialColor = Color.Lerp(this.COILGBLGMCC, this.OIIBMFNKGHK, num2 * 1f);
			}
			else
			{
				this.lineTrail.emit = false;
			}
		}
		if (this.partSys != null)
		{
			ParticleSystem.MainModule main = this.partSys.main;
			if (Mathf.Abs(LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y) < 0.1f)
			{
				float a = 1f * Mathf.Clamp(num * 3f, 0f, 1f);
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1f, 1f, 1f, a));
			}
			else
			{
				main.startColor = new ParticleSystem.MinMaxGradient(new Color(1f, 1f, 1f, 0f));
			}
		}
		if (this.mode != 2)
		{
			this.PhysicOnOff(false);
		}
		this.isTopDown = false;
		if (Mathf.Abs(base.transform.position.y - LocNewLogic.getI.OGJHINOLHJJ) < 0.1f)
		{
			this.isTopDown = true;
		}
		base.transform.position.y = LocNewLogic.getI.OGJHINOLHJJ + 0.01f;
		this.EDDECMJHECC();
		if (this.connectorRbody.isKinematic)
		{
			float d = 1f;
			if (this.IKCDMNGBAAH)
			{
				d = 0f;
			}
			if (this.fish != null && this.fish.isGetBate)
			{
				d = 0f;
			}
			base.transform.position = base.transform.position + LocNewLogic.getI.flowForce * d * Time.deltaTime;
			if (this.fish == null)
			{
				float num3 = Vector3.Distance(Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC, base.transform.position);
				float num4 = BOIKJDICEMF.IKGFHGKKCPG.OIFCLNKOJHB * 1.5f;
				if (num3 > num4)
				{
					Vector3 vector3 = base.transform.position - Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
					vector3.Normalize();
					vector3 *= num4;
					base.transform.position = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC + vector3;
				}
			}
			Vector3 worldPosition = Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC;
			worldPosition.y = base.transform.position.y + 0.3f;
			if (this.poplavok != null)
			{
				worldPosition = this.poplavok.transform.position;
			}
			base.transform.LookAt(worldPosition);
			base.transform.Rotate(90f, 0f, 0f);
			float num5 = Vector3.Distance(base.transform.position, Fisherman.getI.AOEGNGOGNBI.ILCJJKCPBKC);
			this.SpinObj.transform.localRotation = Quaternion.Euler(0f, num5 * 1000f, 0f);
		}
		this.BBKPOKNIAEG += Time.deltaTime;
		if (this.poplScript != null)
		{
			this.poplScript.takeFish = (this.fish != null && this.fish.isGetBate);
		}
		if (this.fishPointer != null && this.fish != null)
		{
			Vector3 position3 = this.fish.gameObject.transform.position;
			position3.y = LocNewLogic.getI.OGJHINOLHJJ;
			this.fishPointer.transform.position = position3;
		}
		if (this.poplCamera != null)
		{
			if (Input.GetKey(KeyCode.F5))
			{
				this.KBNKBLGMFAA -= 0.1f;
				Debug.Log("hgtDst=" + this.KBNKBLGMFAA);
			}
			if (Input.GetKey(KeyCode.F6))
			{
				this.KBNKBLGMFAA += 0.1f;
				Debug.Log("hgtDst=" + this.KBNKBLGMFAA);
			}
			Camera component = this.poplCamera.GetComponent<Camera>();
			if (component != null)
			{
				component.fieldOfView = this.BCKEILBFCNM;
			}
			Fisherman.getI.transform.position + Vector3.up * this.KBNKBLGMFAA;
			if (this.poplavok != null)
			{
				Vector3 normalized = (Fisherman.getI.transform.position + Vector3.up * 1.8f - this.poplavok.transform.position).normalized;
				Vector3 b = this.poplavok.transform.position + normalized * this.cdist;
				b.y = LocNewLogic.getI.OGJHINOLHJJ + this.popCamHgt;
				this.poplCamera.transform.position = Vector3.Lerp(this.poplCamera.transform.position, b, Time.deltaTime * 3f);
				Vector3 position4 = this.poplavok.transform.position;
				position4.y = LocNewLogic.getI.OGJHINOLHJJ;
				this.poplCamera.transform.LookAt(position4 + Vector3.up * 0.03f);
				if (this.pPricel != null)
				{
					this.pPricel.transform.position = position4;
				}
			}
		}
		switch (this.mode)
		{
		case 1:
		{
			this.JEHEPNHGJOH += Time.deltaTime;
			this.IIGDEPLPNME = this.fromPos + this.JAJMIJPIDBL * this.speed * this.JEHEPNHGJOH;
			float num6 = Vector3.Distance(this.fromPos, this.IIGDEPLPNME);
			float f = 3.1415927f * num6 / this.GADFHLLJKOH;
			float num7 = 1f * this.GADFHLLJKOH * 0.05f;
			float num8 = Mathf.Sin(f) * num7;
			this.IIGDEPLPNME.y = this.IIGDEPLPNME.y + num8;
			base.transform.position = this.IIGDEPLPNME;
			BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(Vector3.Distance(base.transform.position, BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPointNonBend.transform.position) * 1.01f);
			base.transform.LookAt(this.toPos);
			base.transform.Rotate(-90f, Time.time * Time.deltaTime * 5f, 0f);
			this.poplavok != null;
			if (base.transform.position.y < LocNewLogic.getI.OGJHINOLHJJ)
			{
				float num9 = 2f;
				if (this.KODFBJFCPAJ == PoplDrop.DGLFOLICLDL.Spin)
				{
					num9 = 0.5f;
				}
				BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK = ObscuredFloat.GOOIABGKMHK(ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().ALKAGOMNNOK) + num9);
				this.mode = 2;
				this.waterBaitTime = Time.time;
				if (BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL != null && BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.MBKMKGABBGE == 12)
				{
					int ilockjiapfc = BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.BDHHPAEHFHG.ILOCKJIAPFC;
				}
				switch (this.KODFBJFCPAJ)
				{
				case PoplDrop.DGLFOLICLDL.Poplavok:
					FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("popl.ogg", base.transform.position, 0.8f, 3f, 50f);
					LocNewLogic.getI.createBigWaterCircle(base.transform.position);
					break;
				case PoplDrop.DGLFOLICLDL.Fider:
					FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("donk.ogg", base.transform.position, 1f, 3f, 50f);
					LocNewLogic.getI.createWaterJampSplash(base.transform.position, 3000f);
					LocNewLogic.getI.createWaterCircle(base.transform.position, 4);
					LocNewLogic.getI.createBigWaterCircle(base.transform.position);
					break;
				case PoplDrop.DGLFOLICLDL.Spin:
					FBFJFAKAGJG.IKGFHGKKCPG.MCOLCPGIFFN("blesna.ogg", base.transform.position, 1f, 3f, 50f);
					LocNewLogic.getI.createBigWaterCircle(base.transform.position);
					base.StartCoroutine(this.LFAALHBNIDJ());
					break;
				}
			}
			break;
		}
		case 2:
		{
			this.JEHEPNHGJOH += Time.deltaTime;
			if (this.KODFBJFCPAJ == PoplDrop.DGLFOLICLDL.Poplavok && this.poplavok != null)
			{
				if (this.poplavok.transform.position.y > LocNewLogic.getI.OGJHINOLHJJ)
				{
					Vector3 a2 = new Vector3(base.transform.position.x, LocNewLogic.getI.OGJHINOLHJJ, base.transform.position.z) - this.poplavok.transform.position;
					a2.Normalize();
					this.IIGDEPLPNME = this.poplavok.transform.position;
					this.IIGDEPLPNME += a2 * this.speed * 1f * Time.deltaTime;
					this.poplavok.transform.position = this.IIGDEPLPNME;
				}
				else if (this.poplScript != null)
				{
					this.poplScript.isWork = true;
				}
				if (!this.MADOEDALIHK && base.transform.position.y <= LocNewLogic.getI.OGJHINOLHJJ)
				{
					if (this.poplCamera == null)
					{
						this.LDKFJGKFLDL();
					}
					LocNewLogic.getI.createWaterCircleSmall(this.poplavok.transform.position, 3);
					if (this.poplScript != null)
					{
						this.poplScript.isWork = true;
					}
					this.poplavok.transform.rotation = Quaternion.Euler(90f, UnityEngine.Random.value * 100f - 50f, 0f);
					this.poplavok.transform.position = new Vector3(this.poplavok.transform.position.x, LocNewLogic.getI.OGJHINOLHJJ, this.poplavok.transform.position.z);
					this.MADOEDALIHK = true;
				}
			}
			this.IIGDEPLPNME = base.transform.position;
			this.deep = LocNewLogic.getI.getDeepInPoint(base.transform.position);
			this.wlevel = LocNewLogic.getI.OGJHINOLHJJ;
			switch (this.KODFBJFCPAJ)
			{
			case PoplDrop.DGLFOLICLDL.Poplavok:
				if (this.IIGDEPLPNME.y >= this.deep)
				{
					BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
					if (LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y <= bgjkmcbhnak.FAFHKDGNCLH - 0.01f)
					{
						float num10 = 0.1f + bgjkmcbhnak.JAHNFKLFANO() / 4f;
						num10 = Mathf.Clamp(num10, -1.9f, 1.9f);
						bool flag = true;
						if (this.fish != null)
						{
							flag = !this.fish.isGetBate;
						}
						if (flag)
						{
							this.IIGDEPLPNME.y = this.IIGDEPLPNME.y - num10 * Time.deltaTime;
						}
						if (this.IIGDEPLPNME.y > LocNewLogic.getI.OGJHINOLHJJ)
						{
							this.IIGDEPLPNME.y = LocNewLogic.getI.OGJHINOLHJJ;
						}
						if (LocNewLogic.getI.OGJHINOLHJJ - this.IIGDEPLPNME.y > bgjkmcbhnak.FAFHKDGNCLH)
						{
							this.IIGDEPLPNME.y = LocNewLogic.getI.OGJHINOLHJJ - bgjkmcbhnak.FAFHKDGNCLH;
						}
						this.isKlevEnable = true;
						if (flag)
						{
							base.transform.position = this.IIGDEPLPNME;
						}
					}
					else
					{
						this.isKlevEnable = true;
					}
				}
				else if (LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y >= BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH - 0.2f)
				{
					this.isKlevEnable = true;
				}
				break;
			case PoplDrop.DGLFOLICLDL.Fider:
				if (this.IIGDEPLPNME.y >= this.deep)
				{
					BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak2 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
					float num11 = 0.1f + bgjkmcbhnak2.JAHNFKLFANO() / 4f;
					num11 = Mathf.Clamp(num11, 0f, 1.2f);
					bool flag2 = true;
					if (this.fish != null)
					{
						flag2 = !this.fish.isGetBate;
					}
					if (flag2)
					{
						this.IIGDEPLPNME.y = this.IIGDEPLPNME.y - num11 * Time.deltaTime;
					}
					if (flag2)
					{
						base.transform.position = this.IIGDEPLPNME;
					}
				}
				else
				{
					this.isKlevEnable = true;
				}
				break;
			case PoplDrop.DGLFOLICLDL.Spin:
				if (ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK) > BOIKJDICEMF.IKGFHGKKCPG.CHCJILPBABD())
				{
					Fisherman.getI.CIHILMCEJND = false;
					return;
				}
				this.isKlevEnable = this.CMHKMKGPNJB;
				if (this.JMJEFKLOKLL)
				{
					float num12 = LocNewLogic.getI.OGJHINOLHJJ - this.IIGDEPLPNME.y;
				}
				break;
			}
			this.IKCDMNGBAAH = (this.IIGDEPLPNME.y < this.deep + 0.05f);
			Vector3 vector4 = Fisherman.getI.getFishGettingPosition();
			vector4.y = Fisherman.getI.transform.position.y;
			float num13 = Vector3.Distance(Fisherman.getI.transform.position, vector4);
			vector4 = Fisherman.getI.transform.position;
			vector4.y = base.transform.position.y;
			if (Vector3.Distance(vector4, base.transform.position) < num13 + 1f)
			{
				this.isKlevEnable = false;
			}
			if (this.isKlevEnable && this.KODFBJFCPAJ == PoplDrop.DGLFOLICLDL.Poplavok)
			{
				base.transform.position.y = LocNewLogic.getI.OGJHINOLHJJ - 0.03f;
			}
			if (!BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM && this.isKlevEnable)
			{
				TimeSpan t = new TimeSpan(0, 0, 0, 5);
				if (DateTime.Now - this.FOOCGDPOFDK > t)
				{
					EPMPHJGALBE epmphjgalbe = new EPMPHJGALBE();
					try
					{
						BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak3 = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
						epmphjgalbe.GOMLLPFFPNP(BOIKJDICEMF.IKGFHGKKCPG.FCAONKOECHJ());
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(base.transform.position));
						epmphjgalbe.BJANIMFDENK(new IIBEEKCAAHK(JLFJEGIPIMM.IKGFHGKKCPG.GJDOHJHDEMO(base.transform.position)));
						float num14 = LocNewLogic.getI.OGJHINOLHJJ - base.transform.position.y;
						float num15 = LocNewLogic.getI.OGJHINOLHJJ - LocNewLogic.getI.getDeepInPoint(base.transform.position);
						epmphjgalbe.DLAIEEJAFDG(num14 * 100f);
						epmphjgalbe.DLAIEEJAFDG(num15 * 100f);
						epmphjgalbe.OBCCLNMPGEJ((bgjkmcbhnak3.AMLEOGHNNPG[0] != null) ? bgjkmcbhnak3.AMLEOGHNNPG[0].LPFKFNLHGBI : 0L);
						epmphjgalbe.OBCCLNMPGEJ((bgjkmcbhnak3.AMLEOGHNNPG[1] != null) ? bgjkmcbhnak3.AMLEOGHNNPG[1].LPFKFNLHGBI : 0L);
						epmphjgalbe.OBCCLNMPGEJ((bgjkmcbhnak3.AMLEOGHNNPG[2] != null) ? bgjkmcbhnak3.AMLEOGHNNPG[2].LPFKFNLHGBI : 0L);
						epmphjgalbe.KJDIGAKNOAI(this.JMJEFKLOKLL);
						epmphjgalbe.KJDIGAKNOAI(this.IKCDMNGBAAH);
						epmphjgalbe.KJDIGAKNOAI(this.isTopDown);
						epmphjgalbe.KJDIGAKNOAI(this.CMHKMKGPNJB);
						epmphjgalbe.KJDIGAKNOAI(this.KJAMHFJJHIE);
						epmphjgalbe.KJDIGAKNOAI(this.AAAIKLHMHEF);
						epmphjgalbe.KJDIGAKNOAI(this.EPKHGNNIJGD);
						Vector3 vector5 = Fisherman.getI.transform.position - base.transform.position;
						vector5.y = 0f;
						epmphjgalbe.DLAIEEJAFDG(vector5.magnitude);
						NJMHLCGIAJI.IKGFHGKKCPG.AKJKNCIKBBF(1120, epmphjgalbe.JDPHBLHOLAD());
						this.FOOCGDPOFDK = DateTime.Now;
					}
					finally
					{
						epmphjgalbe.LMBPNFHKNGA();
					}
				}
			}
			break;
		}
		}
		if (this.lure != null)
		{
			this.lure.setAnimationTime(this.MJFNOFCLLHJ, 1f);
		}
	}

	// Token: 0x06003C8A RID: 15498 RVA: 0x001B908C File Offset: 0x001B728C
	public void klevActivate()
	{
		if (this.frod != null)
		{
			UnityEngine.Object.Destroy(this.frod);
		}
		this.frod = JLFJEGIPIMM.IKGFHGKKCPG.CPHOBOJJPFB("FishOnRod");
		this.fish = this.frod.GetComponent<FishOnRod>();
		this.fish.init();
		this.fish.transform.position = base.transform.position - Vector3.up * 2f;
		this.fish.baitGO = base.transform.gameObject;
		this.fish.baitScrpt = this;
		this.fish.isGetBate = false;
		this.fish.klevMode = 0;
		this.fish.toKlevMode = 1;
		JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.GMLFCKNNOPJ();
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM = true;
		switch (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			if (this.isTopDown)
			{
				if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(90f))
				{
					this.fish.klevMode = 6;
					this.fish.toKlevMode = 6;
					this.fish.podsekShanceVer = 100f;
					return;
				}
			}
			else if (OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.KGKNPAAMDJK))
			{
				this.fish.isGetBate = true;
				this.fish.toKlevMode = 6;
				this.fish.klevMode = 6;
				this.fish.actTime = 0f;
				this.fish.podsekShanceVer = 100f;
				return;
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			this.fish.isGetBate = true;
			Fisherman.getI.isPodsek = true;
			Fisherman.getI.PodsekType = 2;
			Fisherman.getI.podsek();
			if (LocNewLogic.getI.OGJHINOLHJJ - this.IIGDEPLPNME.y < 0.2f)
			{
				this.fish.Jamp();
				LocNewLogic.getI.createWaterJampSplash(base.transform.position, ObscuredFloat.GOOIABGKMHK(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB != null && OLPINJLCKCI.IKGFHGKKCPG.IMEELAOKLKE(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.KGKNPAAMDJK))
			{
				this.fish.isGetBate = true;
				this.fish.toKlevMode = 6;
				this.fish.podsekShanceVer = 100f;
				this.fish.klevMode = 6;
				this.fish.actTime = 3f;
				return;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06003C8B RID: 15499 RVA: 0x001B934B File Offset: 0x001B754B
	public void EKPFHLJBNKK()
	{
		if (this.JBNPMPDEMLD())
		{
			return;
		}
		this.groutBaitTime = Time.time;
	}

	// Token: 0x06003C8C RID: 15500 RVA: 0x001B44BC File Offset: 0x001B26BC
	public void FBCMFAHFPDJ()
	{
		if (this.bmod != null)
		{
			UnityEngine.Object.Destroy(this.bmod);
		}
		this.bmod = null;
	}

	// Token: 0x06003C8D RID: 15501 RVA: 0x001B9364 File Offset: 0x001B7564
	private void CLJFBKJAIOC()
	{
		LineRope.getI.targetPoint.position = base.transform.position;
		this.LR.enabled = false;
		BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA;
		Vector3 position = base.transform.position;
		if (this.fish != null)
		{
			position = this.fish.transform.position;
			if (this.fish.hookPoint != null)
			{
				position = this.fish.hookPoint.transform.position;
			}
		}
		if (this.poplavok != null && this.mode == 0)
		{
			Vector3 vector = this.AGBEBCGAACP - position;
			Vector3 normalized = vector.normalized;
			this.poplavok.transform.position = position + normalized * Mathf.Min(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DCICGEENANE(), vector.magnitude - 97f);
			this.poplavok.transform.LookAt(position);
			this.poplavok.transform.Rotate(1627f, 65f, 1543f);
		}
	}

	// Token: 0x06003C8E RID: 15502 RVA: 0x00022FCC File Offset: 0x000211CC
	public void stopEvnt()
	{
	}

	// Token: 0x06003C8F RID: 15503 RVA: 0x001B949C File Offset: 0x001B769C
	public void kill()
	{
		if (this.poplavok != null)
		{
			UnityEngine.Object.Destroy(this.poplavok);
		}
		if (this.fishPointer != null)
		{
			UnityEngine.Object.Destroy(this.fishPointer);
		}
		if (this.frod != null)
		{
			UnityEngine.Object.Destroy(this.frod);
		}
		if (this.poplCamera != null)
		{
			LocNewLogic.getI.closePoplCamera();
			this.poplCamera = null;
		}
		if (this.fishPointer != null)
		{
			UnityEngine.Object.Destroy(this.fishPointer);
		}
		if (this.pPricel != null)
		{
			UnityEngine.Object.Destroy(this.pPricel);
		}
		UnityEngine.Object.Destroy(base.transform.gameObject);
		Debug.Log("kill");
	}

	// Token: 0x06003C90 RID: 15504 RVA: 0x001B9560 File Offset: 0x001B7760
	private void HFHGBPFDMGJ()
	{
		this.AGBEBCGAACP = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC;
		this.CLJFBKJAIOC();
		int num = this.mode;
		if (!this.connectorRbody.isKinematic && Vector3.Distance(base.transform.position, this.connectorRbody.transform.position) > 960f)
		{
			float t = Time.deltaTime * 1985f;
			Vector3 vector = this.AGBEBCGAACP - base.transform.position;
			if (base.transform.position.y < LocNewLogic.getI.IGHOGONIKLC() + 967f)
			{
				vector.y /= 1634f;
			}
			Vector3 up = Vector3.up;
			if (this.connectorRbody.useGravity)
			{
				up = base.transform.up;
			}
			Quaternion b = Quaternion.LookRotation(vector, up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, t);
			base.transform.position = Vector3.Lerp(base.transform.position, this.connectorRbody.transform.position, t);
		}
		float num2 = LocNewLogic.getI.getDeepInPoint(this.connectorRbody.transform.position) - 567f;
		if (base.transform.position.y < num2)
		{
			Vector3 position = base.transform.position;
			position.y = num2;
			base.transform.position = position;
			this.EDHPDNPNIGJ(false);
		}
		if (this.connectorRbody.transform.position.y < num2)
		{
			Vector3 position2 = this.connectorRbody.transform.position;
			position2.y = num2;
			this.connectorRbody.transform.position = position2;
			this.JJLDACLDIDL(false);
		}
	}

	// Token: 0x06003C91 RID: 15505 RVA: 0x001B973D File Offset: 0x001B793D
	public void spinKvok()
	{
		Debug.Log("spinKvok activate");
	}

	// Token: 0x06003C92 RID: 15506 RVA: 0x001B6C40 File Offset: 0x001B4E40
	public void JJLDACLDIDL(bool DCCPCBLODIG)
	{
		if (this.EHGOFGHNIFE != DCCPCBLODIG && DCCPCBLODIG)
		{
			this.groundEvnt();
		}
		this.EHGOFGHNIFE = DCCPCBLODIG;
	}

	// Token: 0x06003C93 RID: 15507 RVA: 0x001B974C File Offset: 0x001B794C
	public void DEPHILNJKND()
	{
		if (this.fish != null && ObscuredBool.LPDGJCGPEBD(this.fish.isPodsek))
		{
			return;
		}
		if (this.poplavok != null)
		{
			LocNewLogic.getI.createWaterCircleSmall(this.poplavok.transform.position, 1);
		}
		base.StartCoroutine(this.FGMJCBGDEIN());
		this.PoplObj.SetActive(true);
		this.SpinObj.SetActive(false);
		this.FiderObj.SetActive(true);
		this.killBaitModel();
		this.fishPointer = JLFJEGIPIMM.IKGFHGKKCPG.OGJBGNOGPMJ("/");
		this.mode = 4;
		if (this.fish != null)
		{
			this.fish.FMCKJLCPKJA();
		}
		this.killPodsek();
	}

	// Token: 0x06003C94 RID: 15508 RVA: 0x001B9818 File Offset: 0x001B7A18
	public string getBaitInfo()
	{
		StringBuilder stringBuilder = new StringBuilder();
		char[] trimChars = new char[]
		{
			' ',
			'\n'
		};
		foreach (int num in this.evntList)
		{
			stringBuilder.AppendLine(JNBICAJIJMM.LEBHCLDODNI("prov_sob_" + num));
		}
		if (this.provType > 0)
		{
			stringBuilder.AppendLine(JNBICAJIJMM.LEBHCLDODNI("prov_prov_" + this.provType));
		}
		return stringBuilder.ToString().Trim(trimChars);
	}

	// Token: 0x06003C95 RID: 15509 RVA: 0x001B98D0 File Offset: 0x001B7AD0
	public bool CAAOPCDJPOM()
	{
		bool result = false;
		if (this.JMJEFKLOKLL)
		{
			result = false;
		}
		if (this.DNFJJONFBBK())
		{
			result = false;
		}
		if (this.NDJPNHPNECP())
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06003C96 RID: 15510 RVA: 0x001B9900 File Offset: 0x001B7B00
	public void ALHICJELOCK()
	{
		if (this.fish != null && ObscuredBool.HLEMAJBAAEO(this.fish.isPodsek))
		{
			return;
		}
		if (this.poplavok != null)
		{
			LocNewLogic.getI.FAMPBINAPBA(this.poplavok.transform.position, 8);
		}
		base.StartCoroutine(this.GLOBDICMAMO());
		this.PoplObj.SetActive(true);
		this.SpinObj.SetActive(true);
		this.FiderObj.SetActive(false);
		this.BDMCGLGJKOF();
		this.fishPointer = JLFJEGIPIMM.MHFDIJGJGBJ().IKBFBDCNOCH("Giant Eat");
		this.mode = 4;
		if (this.fish != null)
		{
			this.fish.GCLDGLPLKJP();
		}
		this.PILMECNJJEH();
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x06003CB8 RID: 15544 RVA: 0x001BAD63 File Offset: 0x001B8F63
	// (set) Token: 0x06003C97 RID: 15511 RVA: 0x001B5006 File Offset: 0x001B3206
	public bool JMJEFKLOKLL
	{
		get
		{
			return Time.time - this.isMovingTime < 2f;
		}
		set
		{
			if (value)
			{
				this.isMovingTime = Time.time;
			}
		}
	}

	// Token: 0x06003C98 RID: 15512 RVA: 0x00022FCC File Offset: 0x000211CC
	private void OnPostRender()
	{
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x06003C99 RID: 15513 RVA: 0x001B99C9 File Offset: 0x001B7BC9
	public bool IEHNDPMDMOI
	{
		get
		{
			return Time.time - this.playBaitTime < 0.5f;
		}
	}

	// Token: 0x06003C9A RID: 15514 RVA: 0x001B99E0 File Offset: 0x001B7BE0
	private void MDBPBJHACDA()
	{
		this.AGBEBCGAACP = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC;
		this.BCGAKMLNOHO();
		int num = this.mode;
		if (!this.connectorRbody.isKinematic && Vector3.Distance(base.transform.position, this.connectorRbody.transform.position) > 1751f)
		{
			float t = Time.deltaTime * 539f;
			Vector3 vector = this.AGBEBCGAACP - base.transform.position;
			if (base.transform.position.y < LocNewLogic.getI.IGHOGONIKLC() + 1657f)
			{
				vector.y /= 722f;
			}
			Vector3 up = Vector3.up;
			if (this.connectorRbody.useGravity)
			{
				up = base.transform.up;
			}
			Quaternion b = Quaternion.LookRotation(vector, up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, t);
			base.transform.position = Vector3.Lerp(base.transform.position, this.connectorRbody.transform.position, t);
		}
		float num2 = LocNewLogic.getI.getDeepInPoint(this.connectorRbody.transform.position) - 1164f;
		if (base.transform.position.y < num2)
		{
			Vector3 position = base.transform.position;
			position.y = num2;
			base.transform.position = position;
			this.OEJOCBIIECN(true);
		}
		if (this.connectorRbody.transform.position.y < num2)
		{
			Vector3 position2 = this.connectorRbody.transform.position;
			position2.y = num2;
			this.connectorRbody.transform.position = position2;
			this.OEJOCBIIECN(true);
		}
	}

	// Token: 0x06003C9B RID: 15515 RVA: 0x001B47DE File Offset: 0x001B29DE
	private IEnumerator DNJFOAENNFL()
	{
		int num;
		for (i = 0; i < 5; i = num + 1)
		{
			if (this.poplavok != null)
			{
				LocNewLogic.getI.createWaterCircleSmall(this.poplavok.transform.position, 1);
			}
			yield return new WaitForSeconds(0.2f);
			num = i;
		}
		yield break;
	}

	// Token: 0x06003C9C RID: 15516 RVA: 0x001B9BBD File Offset: 0x001B7DBD
	private void POFHKNCEHKF()
	{
		LocNewLogic.getI.HKBNODJBGEL();
		Vector3 position = base.transform.position;
		LocNewLogic.getI.CDBIEPGNONF();
		LocNewLogic.getI.getDeepInPoint(base.transform.position);
		bool isEditor = Application.isEditor;
	}

	// Token: 0x06003C9D RID: 15517 RVA: 0x001B503F File Offset: 0x001B323F
	public bool GMKBGCIFOOD()
	{
		return this.EHGOFGHNIFE;
	}

	// Token: 0x06003C9E RID: 15518 RVA: 0x001B9BFD File Offset: 0x001B7DFD
	public bool OFEOMLHKKBO()
	{
		return Time.time - this.MJNCFCNJOIM < 1688f;
	}

	// Token: 0x06003C9F RID: 15519 RVA: 0x001B9C14 File Offset: 0x001B7E14
	private void BFAKJFDMPJI()
	{
		this.poplCamera = LocNewLogic.getI.openPoplCamera();
		if (this.poplCamera == null)
		{
			LocNewLogic.getI.closePoplCamera();
			return;
		}
		this.poplCamera.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
		this.poplCamera.transform.localScale = new Vector3(1f, 1f, 1f);
		this.poplCamera.GetComponent<Camera>().fieldOfView = 90f;
		Vector3 normalized = (Fisherman.getI.transform.position + Vector3.up * 1.8f - this.poplavok.transform.position).normalized;
		Vector3 position = this.poplavok.transform.position + normalized * this.cdist;
		position.y = LocNewLogic.getI.OGJHINOLHJJ + this.popCamHgt;
		this.poplCamera.transform.position = position;
		Vector3 position2 = this.poplavok.transform.position;
		position2.y = LocNewLogic.getI.OGJHINOLHJJ;
		this.poplCamera.transform.LookAt(position2 + Vector3.up * 0.05f);
	}

	// Token: 0x06003CA0 RID: 15520 RVA: 0x001B9D7F File Offset: 0x001B7F7F
	private void ANKIMABFEHM()
	{
		if (this.GIGAPNDNOKC() != PoplDrop.DGLFOLICLDL.Poplavok)
		{
			return;
		}
		if (JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.LEHIJLOILNO())
		{
			base.StartCoroutine(this.OKFKNOKDMCE());
		}
	}

	// Token: 0x06003CA1 RID: 15521 RVA: 0x001B9DA8 File Offset: 0x001B7FA8
	private void OnDestroy()
	{
		if (this.connectorRbody != null)
		{
			UnityEngine.Object.Destroy(this.connectorRbody.gameObject);
		}
		if (this.trail != null)
		{
			this.trail.emit = false;
			UnityEngine.Object.Destroy(this.trail.gameObject, 3f);
		}
		if (this.lineTrail != null)
		{
			this.lineTrail.emit = false;
			UnityEngine.Object.Destroy(this.lineTrail.gameObject, 3f);
		}
		if (this.partSys != null)
		{
			this.partSys.transform.parent = null;
			this.partSys.main.startColor = new ParticleSystem.MinMaxGradient(new Color(1f, 1f, 1f, 0f));
			UnityEngine.Object.Destroy(this.partSys.gameObject, 4f);
		}
	}

	// Token: 0x06003CA2 RID: 15522 RVA: 0x001B9E96 File Offset: 0x001B8096
	private IEnumerator GLOBDICMAMO()
	{
		PoplDrop.LENODECKJDN lenodeckjdn = new PoplDrop.LENODECKJDN(1);
		lenodeckjdn.AENJLLPLILM = this;
		return lenodeckjdn;
	}

	// Token: 0x06003CA3 RID: 15523 RVA: 0x001B4E5D File Offset: 0x001B305D
	private IEnumerator AIGIPPMFMKG()
	{
		this.JMJEFKLOKLL = true;
		for (;;)
		{
			a = base.transform.position;
			yield return new WaitForSeconds(0.5f);
			this.JMJEFKLOKLL = (Vector3.Distance(a, base.transform.position) > 0.02f);
			this.provType = 0;
			this.evntList.Clear();
			if (!Fisherman.getI.isPodsek)
			{
				if (this.AAAIKLHMHEF)
				{
					this.evntList.Add(2);
				}
				if (this.GHOFIEDNCIJ)
				{
					this.evntList.Add(1);
				}
				if (this.KODFBJFCPAJ == PoplDrop.DGLFOLICLDL.Spin)
				{
					switch (BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.BDHHPAEHFHG.ILOCKJIAPFC)
					{
					case 4:
						if (this.rolltime > 3f)
						{
							this.provType = 1;
							if (this.FOEBNECJPOL)
							{
								this.provType = 0;
							}
							if (this.KJAMHFJJHIE)
							{
								this.provType = 2;
							}
						}
						break;
					case 5:
						if (this.rolltime > 2f)
						{
							this.provType = 1;
						}
						if (this.KJAMHFJJHIE)
						{
							this.provType = 0;
						}
						if (this.FOEBNECJPOL)
						{
							this.provType = 0;
						}
						break;
					case 6:
						if (this.rolltime > 3f)
						{
							if (this.FOEBNECJPOL)
							{
								this.provType = 0;
							}
							if (this.KJAMHFJJHIE)
							{
								this.provType = 3;
							}
						}
						break;
					case 7:
						if (this.rolltime > 3f)
						{
							if (this.FOEBNECJPOL)
							{
								this.provType = 0;
							}
							if (this.KJAMHFJJHIE)
							{
								this.provType = 4;
							}
						}
						break;
					}
				}
				a = default(Vector3);
			}
		}
		yield break;
	}

	// Token: 0x06003CA4 RID: 15524 RVA: 0x001B9EA5 File Offset: 0x001B80A5
	public bool HGBNKKIIFJL()
	{
		return Time.time - this.playBaitTime < 17f;
	}

	// Token: 0x06003CA5 RID: 15525 RVA: 0x001B9EBA File Offset: 0x001B80BA
	private void LDKFJGKFLDL()
	{
		if (this.KODFBJFCPAJ != PoplDrop.DGLFOLICLDL.Poplavok)
		{
			return;
		}
		if (JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.LEHIJLOILNO())
		{
			base.StartCoroutine(this.FNANCKFIKBJ());
		}
	}

	// Token: 0x06003CA6 RID: 15526 RVA: 0x00022FCC File Offset: 0x000211CC
	public void PHPGKKAJGLB()
	{
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x001B9EE3 File Offset: 0x001B80E3
	public bool AAAIKLHMHEF
	{
		get
		{
			return Time.time - this.groutBaitTime < 2f;
		}
	}

	// Token: 0x06003CA8 RID: 15528 RVA: 0x00022FCC File Offset: 0x000211CC
	private void LMAMFAHIDJO()
	{
	}

	// Token: 0x06003CA9 RID: 15529 RVA: 0x001B9EF8 File Offset: 0x001B80F8
	private float MOGPBGKJDOD()
	{
		float num = ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK);
		num += this.lineDelta;
		return Mathf.Lerp(this.physBait.lineCountMetr, num, Time.fixedDeltaTime * 1001f);
	}

	// Token: 0x06003CAA RID: 15530 RVA: 0x001B9F44 File Offset: 0x001B8144
	public void OBAKMKHHIKG()
	{
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL();
		float dkihdoelfeh = Vector3.Distance(this.toPos, Fisherman.getI.transform.position);
		float num = BOIKJDICEMF.IKGFHGKKCPG.HLNMIAPENEO(dkihdoelfeh);
		float num2 = OLPINJLCKCI.IKGFHGKKCPG.FFDDAGJJOOM((double)num);
		float f = OLPINJLCKCI.NPIEJELJPIM().GCPGDOACKLG(1102.0);
		this.toPos.x = this.toPos.x + Mathf.Cos(f) * num2;
		this.toPos.z = this.toPos.z + Mathf.Sin(f) * num2;
		bgjkmcbhnak.CDNABIHPLHM = true;
		this.MADOEDALIHK = false;
		this.mode = 0;
		this.JAJMIJPIDBL = this.toPos - this.fromPos;
		this.JAJMIJPIDBL.Normalize();
		this.GADFHLLJKOH = Vector3.Distance(this.fromPos, this.toPos);
		this.JEHEPNHGJOH = 951f;
		this.FMPGPPIMBNG = new Vector3(OLPINJLCKCI.NPIEJELJPIM().KCHMDLAGEJF(1834.0) - 767f, 1022f, OLPINJLCKCI.IFLFANPMLMM().JJKCBOPPOHJ(1878.0) - 642f);
		switch (this.KODFBJFCPAJ)
		{
		case PoplDrop.DGLFOLICLDL.Poplavok:
		{
			this.poplavok = JLFJEGIPIMM.NNEAHAFBOHC().OMPJLOEGMII("_DistortParams", Vector3.zero, null);
			this.poplScript = this.poplavok.GetComponent<Poplavok>();
			this.poplScript.baitObj = base.transform.gameObject;
			Vector3 a = this.AGBEBCGAACP - base.transform.position;
			a.Normalize();
			a *= BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DCICGEENANE();
			this.poplavok.transform.LookAt(this.AGBEBCGAACP);
			this.poplavok.transform.Rotate(new Vector3(1205f, 294f, 1955f));
			this.speed = 1989f;
			this.poplScript.rotAngle = 1322f;
			this.poplScript.rotWAngle = UnityEngine.Random.value * 1584f;
			this.poplScript.isWork = false;
			this.poplScript.GJDCJFLEGMI();
			bool knobfamemjc = HPGKIJLKCIH.IKGFHGKKCPG.KNOBFAMEMJC;
			this.pPricel = JLFJEGIPIMM.MHFDIJGJGBJ().HDAFGAPECEO("Head");
			this.pPricel.transform.position = new Vector3(this.toPos.x, LocNewLogic.getI.HKBNODJBGEL(), this.toPos.z);
			return;
		}
		case PoplDrop.DGLFOLICLDL.Fider:
			this.poplavok = null;
			this.poplScript = null;
			this.speed = 648f;
			this.mode = 1;
			Debug.Log("MotorbikeSuperman");
			return;
		case PoplDrop.DGLFOLICLDL.Spin:
			this.poplavok = null;
			this.poplScript = null;
			this.speed = 34f;
			this.mode = 1;
			Debug.Log("autherror");
			return;
		default:
			return;
		}
	}

	// Token: 0x06003CAB RID: 15531 RVA: 0x001B4542 File Offset: 0x001B2742
	private IEnumerator FNANCKFIKBJ()
	{
		yield return new WaitForSeconds(2f);
		this.BFAKJFDMPJI();
		yield break;
	}

	// Token: 0x06003CAC RID: 15532 RVA: 0x001BA230 File Offset: 0x001B8430
	private void FixedUpdate()
	{
		if (this.physBait != null)
		{
			this.physBait.lineCountMetr = this.MBBPHACDFMJ;
		}
		if (this.connectorRbody.isKinematic)
		{
			return;
		}
		EKBAPCMPANI ekbapcmpani = BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL;
		if (ekbapcmpani == null)
		{
			return;
		}
		BOIKJDICEMF.BGJKMCBHNAK bgjkmcbhnak = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP();
		if (bgjkmcbhnak == null)
		{
			return;
		}
		Vector3 normalized = (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPoint.transform.position - base.transform.position).normalized;
		normalized.y /= 2f;
		ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.BNKBCOAANNG);
		this.connectorRbody.useGravity = (this.connectorRbody.transform.position.y >= LocNewLogic.getI.OGJHINOLHJJ + 0.03f);
		this.connectorRbody.drag = (this.connectorRbody.useGravity ? this.onAirDrag : this.NBEDBFEJICE);
		this.connectorRbody.angularDrag = (this.connectorRbody.useGravity ? this.onAirDrag : this.NBEDBFEJICE);
		bool flag = !this.connectorRbody.useGravity;
		float num = 0f;
		bool flag2 = true;
		num += ekbapcmpani.BDHHPAEHFHG.MIMANMPNLPE.OBEOJCGHOGL * this.scaleDeepForce;
		Vector3 velocity = this.connectorRbody.velocity;
		bool flag3 = false;
		float num2 = -99999f;
		if (BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.BDHHPAEHFHG.ILOCKJIAPFC == 7)
		{
			flag3 = true;
			num2 = LocNewLogic.getI.OGJHINOLHJJ - BOIKJDICEMF.IKGFHGKKCPG.FMNHHGDPOHL.BDHHPAEHFHG.GLLIKKONFAJ;
		}
		if (ObscuredFloat.GOOIABGKMHK(bgjkmcbhnak.BNKBCOAANNG) > 0f)
		{
			this.velos = (this.connectorRbody.transform.position - this.GBEIDPOCJBF) / Time.fixedDeltaTime;
			this.velos.y = 0f;
			this.MJFNOFCLLHJ += this.velos.magnitude * Time.fixedDeltaTime * 3f;
			this.jforce = this.velos.magnitude * this.jforceScaler;
			float num3 = ekbapcmpani.BDHHPAEHFHG.MIMANMPNLPE.KGKNPAAMDJK * this.scaleUpForce * this.jforce;
			num += num3 * this.scaleDeepForce;
			if (flag3)
			{
				num *= this.vobblerScaler;
				if (num > 0f)
				{
					num = Mathf.Clamp(num, 0f, this.vobDownClamp);
				}
			}
		}
		num = Mathf.Clamp(num, -this.upForceClamp, this.downForceClamp);
		this.currUpForce = num;
		if (num > 0f && base.transform.position.y <= num2)
		{
			num = 0f;
		}
		float y = this.connectorRbody.transform.position.y;
		float waterLevel = LocNewLogic.getI.OGJHINOLHJJ;
		this.desiredVelocity = velocity;
		this.desiredVelocity.y = -num;
		if (!flag)
		{
			flag2 = false;
		}
		if (flag != this.HDONIMLIFDH)
		{
			this.desiredVelocity.y = 0f;
			flag2 = true;
		}
		float d = 1f;
		if (this.IKCDMNGBAAH)
		{
			d = 0.5f;
		}
		this.desiredVelocity += LocNewLogic.getI.flowForce * this.scaleFlowForce * d;
		this.velocityChange = this.desiredVelocity - this.connectorRbody.velocity;
		if (flag2)
		{
			this.connectorRbody.AddForce(this.velocityChange, ForceMode.VelocityChange);
		}
		this.GBEIDPOCJBF = this.connectorRbody.transform.position;
		this.HDONIMLIFDH = flag;
	}

	// Token: 0x06003CAD RID: 15533 RVA: 0x001BA5FC File Offset: 0x001B87FC
	private void EDDECMJHECC()
	{
		LineRope.getI.targetPoint.position = base.transform.position;
		this.LR.enabled = false;
		BOIKJDICEMF.JGHABIPEEEO dfbhmiiplca = BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DFBHMIIPLCA;
		Vector3 position = base.transform.position;
		if (this.fish != null)
		{
			position = this.fish.transform.position;
			if (this.fish.hookPoint != null)
			{
				position = this.fish.hookPoint.transform.position;
			}
		}
		if (this.poplavok != null && this.mode == 4)
		{
			Vector3 vector = this.AGBEBCGAACP - position;
			Vector3 normalized = vector.normalized;
			this.poplavok.transform.position = position + normalized * Mathf.Min(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().FAFHKDGNCLH, vector.magnitude - 0.1f);
			this.poplavok.transform.LookAt(position);
			this.poplavok.transform.Rotate(-90f, 0f, 0f);
		}
	}

	// Token: 0x06003CAE RID: 15534 RVA: 0x001BA734 File Offset: 0x001B8934
	private IEnumerator LFAALHBNIDJ()
	{
		yield return new WaitForSeconds(0.5f);
		this.PhysicOnOff(true);
		yield break;
	}

	// Token: 0x06003CAF RID: 15535 RVA: 0x001BA744 File Offset: 0x001B8944
	private void GJKCGGCCIAJ()
	{
		this.AGBEBCGAACP = BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.ILCJJKCPBKC;
		this.CLJFBKJAIOC();
		int num = this.mode;
		if (!this.connectorRbody.isKinematic && Vector3.Distance(base.transform.position, this.connectorRbody.transform.position) > 355f)
		{
			float t = Time.deltaTime * 1444f;
			Vector3 vector = this.AGBEBCGAACP - base.transform.position;
			if (base.transform.position.y < LocNewLogic.getI.CDBIEPGNONF() + 1400f)
			{
				vector.y /= 201f;
			}
			Vector3 up = Vector3.up;
			if (this.connectorRbody.useGravity)
			{
				up = base.transform.up;
			}
			Quaternion b = Quaternion.LookRotation(vector, up);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, b, t);
			base.transform.position = Vector3.Lerp(base.transform.position, this.connectorRbody.transform.position, t);
		}
		float num2 = LocNewLogic.getI.getDeepInPoint(this.connectorRbody.transform.position) - 1941f;
		if (base.transform.position.y < num2)
		{
			Vector3 position = base.transform.position;
			position.y = num2;
			base.transform.position = position;
			this.LBPPLEHAJMO(true);
		}
		if (this.connectorRbody.transform.position.y < num2)
		{
			Vector3 position2 = this.connectorRbody.transform.position;
			position2.y = num2;
			this.connectorRbody.transform.position = position2;
			this.OEJOCBIIECN(true);
		}
	}

	// Token: 0x06003CB0 RID: 15536 RVA: 0x001B58C0 File Offset: 0x001B3AC0
	public void MBOMMOCMDAG()
	{
		UnityEngine.Object.Destroy(this.frod);
		this.frod = null;
	}

	// Token: 0x06003CB1 RID: 15537 RVA: 0x001BA924 File Offset: 0x001B8B24
	public void POADDIBLBJH(bool AFECKMFDAEA)
	{
		if (AFECKMFDAEA == this.ADLIOAFMGMA)
		{
			return;
		}
		if (AFECKMFDAEA)
		{
			if (this.physBait != null)
			{
				this.physBait.EIJDBGEKPMM(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.endPointNonBend.transform, false);
				BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().DNPDBOODCHK = ObscuredFloat.AJMPAOCEPCA(this.physBait.lineCountMetr);
			}
			this.connectorRbody.useGravity = false;
			this.connectorRbody.isKinematic = false;
			this.connectorRbody.velocity = Vector3.zero;
			this.GBEIDPOCJBF = base.transform.position;
			this.connectorRbody.transform.parent = null;
			this.ADLIOAFMGMA = true;
			return;
		}
		this.ADLIOAFMGMA = false;
		this.rbody.isKinematic = true;
		this.connectorRbody.isKinematic = false;
		this.connectorRbody.useGravity = false;
		this.rbody.useGravity = true;
		this.connectorRbody.transform.parent = base.transform;
		if (this.physBait != null)
		{
			this.physBait.init(null, false);
		}
	}

	// Token: 0x06003CB2 RID: 15538 RVA: 0x001BAA48 File Offset: 0x001B8C48
	public bool BGAOINIIDNI()
	{
		return Time.time - this.isMovingTime < 285f;
	}

	// Token: 0x06003CB3 RID: 15539 RVA: 0x001B58B8 File Offset: 0x001B3AB8
	public PoplDrop.DGLFOLICLDL JLBEJHDECGK()
	{
		return this.KNAHCJNDKKK;
	}

	// Token: 0x06003CB4 RID: 15540 RVA: 0x001BAA5D File Offset: 0x001B8C5D
	public bool NDJPNHPNECP()
	{
		return Time.time - this.groutBaitTime < 776f;
	}

	// Token: 0x06003CB5 RID: 15541 RVA: 0x001BAA72 File Offset: 0x001B8C72
	public bool DNFJJONFBBK()
	{
		return Time.time - this.playBaitTime < 699f;
	}

	// Token: 0x06003CB6 RID: 15542 RVA: 0x001BAA87 File Offset: 0x001B8C87
	public void OEJOCBIIECN(bool DCCPCBLODIG)
	{
		if (this.EHGOFGHNIFE != DCCPCBLODIG && DCCPCBLODIG)
		{
			this.EKPFHLJBNKK();
		}
		this.EHGOFGHNIFE = DCCPCBLODIG;
	}

	// Token: 0x06003CB7 RID: 15543 RVA: 0x001BAAA4 File Offset: 0x001B8CA4
	public void NKGMDLPIFIA()
	{
		if (this.frod != null)
		{
			UnityEngine.Object.Destroy(this.frod);
		}
		this.frod = JLFJEGIPIMM.MHFDIJGJGBJ().OGJBGNOGPMJ("Sitting Hand Rest Finger Tap");
		this.fish = this.frod.GetComponent<FishOnRod>();
		this.fish.BCMIIMNMKNO();
		this.fish.transform.position = base.transform.position - Vector3.up * 285f;
		this.fish.baitGO = base.transform.gameObject;
		this.fish.baitScrpt = this;
		this.fish.isGetBate = true;
		this.fish.klevMode = 0;
		this.fish.toKlevMode = 1;
		JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.GMLFCKNNOPJ();
		BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().CDNABIHPLHM = true;
		switch (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().DFBHMIIPLCA)
		{
		case BOIKJDICEMF.JGHABIPEEEO.Poplavok:
			if (this.isTopDown)
			{
				if (OLPINJLCKCI.OBDBAABBAKB().HMAEKHKNNMP(1527f))
				{
					this.fish.klevMode = 3;
					this.fish.toKlevMode = 2;
					this.fish.podsekShanceVer = 1697f;
					return;
				}
			}
			else if (OLPINJLCKCI.IKGFHGKKCPG.HMAEKHKNNMP(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.NJJIBEJGLEJ()))
			{
				this.fish.isGetBate = false;
				this.fish.toKlevMode = 3;
				this.fish.klevMode = 0;
				this.fish.actTime = 674f;
				this.fish.podsekShanceVer = 1289f;
				return;
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Spinning:
			this.fish.isGetBate = true;
			Fisherman.getI.isPodsek = false;
			Fisherman.getI.PodsekType = 5;
			Fisherman.getI.podsek();
			if (LocNewLogic.getI.OGJHINOLHJJ - this.IIGDEPLPNME.y < 1020f)
			{
				this.fish.GHKEJBOAEAJ();
				LocNewLogic.getI.KBOPHDOEBNM(base.transform.position, ObscuredFloat.OBJFODGFMAM(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().NKHBAJKMAGD));
			}
			break;
		case BOIKJDICEMF.JGHABIPEEEO.Fider:
			if (BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BCKECOENDLB != null && OLPINJLCKCI.NPIEJELJPIM().JKIMAIDMNML(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().BCKECOENDLB.LODGJCMEGAI.EPPEFJDDOHN()))
			{
				this.fish.isGetBate = true;
				this.fish.toKlevMode = 5;
				this.fish.podsekShanceVer = 1730f;
				this.fish.klevMode = 2;
				this.fish.actTime = 916f;
				return;
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x06003CB9 RID: 15545 RVA: 0x001B58C0 File Offset: 0x001B3AC0
	public void CIJMDPLPBPP()
	{
		UnityEngine.Object.Destroy(this.frod);
		this.frod = null;
	}

	// Token: 0x06003CBA RID: 15546 RVA: 0x001B7B65 File Offset: 0x001B5D65
	public void EDHPDNPNIGJ(bool DCCPCBLODIG)
	{
		if (this.EHGOFGHNIFE != DCCPCBLODIG && DCCPCBLODIG)
		{
			this.PHLKADHICCJ();
		}
		this.EHGOFGHNIFE = DCCPCBLODIG;
	}

	// Token: 0x06003CBB RID: 15547 RVA: 0x001B58C0 File Offset: 0x001B3AC0
	public void klevDeactivate()
	{
		UnityEngine.Object.Destroy(this.frod);
		this.frod = null;
	}

	// Token: 0x06003CBC RID: 15548 RVA: 0x001BAD78 File Offset: 0x001B8F78
	public void HOIKDKEJJBP()
	{
		if (this.poplavok != null)
		{
			UnityEngine.Object.Destroy(this.poplavok);
		}
		if (this.fishPointer != null)
		{
			UnityEngine.Object.Destroy(this.fishPointer);
		}
		if (this.frod != null)
		{
			UnityEngine.Object.Destroy(this.frod);
		}
		if (this.poplCamera != null)
		{
			LocNewLogic.getI.ABEFPMCIICH();
			this.poplCamera = null;
		}
		if (this.fishPointer != null)
		{
			UnityEngine.Object.Destroy(this.fishPointer);
		}
		if (this.pPricel != null)
		{
			UnityEngine.Object.Destroy(this.pPricel);
		}
		UnityEngine.Object.Destroy(base.transform.gameObject);
		Debug.Log("wpn_add/base");
	}

	// Token: 0x06003CBD RID: 15549 RVA: 0x001BAE3C File Offset: 0x001B903C
	private void HEMEEOGJDOE()
	{
		if (this.trail != null)
		{
			this.trail.transform.parent = null;
			this.KODIENKGJKD = this.trail.initialColor;
			this.KKJLKIGNBIJ = this.trail.initialColor;
			this.KKJLKIGNBIJ.a = 254f;
		}
		if (this.lineTrail != null)
		{
			this.lineTrail.transform.parent = null;
			this.OIIBMFNKGHK = this.lineTrail.initialColor;
			this.COILGBLGMCC = this.lineTrail.initialColor;
			this.KKJLKIGNBIJ.a = 1055f;
		}
		this.BAHHIKELOJP = base.transform.position;
		if (this.rope != null && !(BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI != null))
		{
			this.rope.target = null;
		}
		base.StartCoroutine(this.KKJIFEONNIG());
		if (this.connectorRbody != null)
		{
			this.NBEDBFEJICE = this.connectorRbody.drag;
		}
		this.BAOONCLOIJL(false);
		this.PoplObj.SetActive(false);
		this.SpinObj.SetActive(true);
		this.FiderObj.SetActive(true);
		this.Koleb.SetActive(true);
		this.Vertu.SetActive(true);
		this.Vobler.SetActive(true);
		this.Jig.SetActive(true);
		OMDDGEDHHNH.NLIONDPCKHJ().DKPDBNNNDLK(IFPIMPMKJIB.GNJBIHDDMFE(BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().AMLEOGHNNPG[1].HHOLFABGDJA), 1, new OMDDGEDHHNH.BCDNKAGAFBM.KCKLFOBBCLP(this.HLDAFHLPEJC), "sunshine_ShadowFadeParams");
		this.LDKFJGKFLDL();
	}

	// Token: 0x06003CBE RID: 15550 RVA: 0x001B44ED File Offset: 0x001B26ED
	public void groundEvnt()
	{
		if (this.AAAIKLHMHEF)
		{
			return;
		}
		this.groutBaitTime = Time.time;
	}

	// Token: 0x06003CBF RID: 15551 RVA: 0x001BAFF0 File Offset: 0x001B91F0
	public void KHKIEPCBPKF()
	{
		this.poplavok != null;
		if (this.poplCamera != null)
		{
			LocNewLogic.getI.ABEFPMCIICH();
			this.poplCamera = null;
		}
		if (this.simpleWater != null)
		{
			UnityEngine.Object.Destroy(this.simpleWater);
		}
		if (this.pPricel != null)
		{
			UnityEngine.Object.Destroy(this.pPricel);
		}
		this.poplCamera = null;
		this.simpleWater = null;
		this.pPricel = null;
		Debug.Log("</color>");
	}

	// Token: 0x06003CC0 RID: 15552 RVA: 0x001BB07C File Offset: 0x001B927C
	private void GJECDBAKPCP(OMDDGEDHHNH.BCDNKAGAFBM NOFCHOFPHAD)
	{
		if (!NOFCHOFPHAD.DANHCOLDBDB)
		{
			return;
		}
		this.PoplObj.SetActive(true);
		this.SpinObj.SetActive(false);
		this.FiderObj.SetActive(true);
		this.Koleb.SetActive(false);
		this.Vertu.SetActive(true);
		this.Vobler.SetActive(false);
		this.Jig.SetActive(false);
		this.bmod = NOFCHOFPHAD.LFHPJGAPPCC();
		if (this.bmod != null)
		{
			this.bmod.transform.parent = this.modelCatalog.transform;
			this.bmod.transform.localPosition = Vector3.zero;
			this.bmod.transform.localRotation = Quaternion.identity;
			this.bmod.transform.localScale = new Vector3(986f, 249f, 863f);
			this.lure = this.bmod.GetComponent<Lure>();
		}
		JLFJEGIPIMM.IKGFHGKKCPG.FJFAMAOEFEF(base.gameObject, -117);
	}

	// Token: 0x06003CC1 RID: 15553 RVA: 0x000EB372 File Offset: 0x000E9572
	public bool CAAKGBLLFKN()
	{
		return false;
	}

	// Token: 0x06003CC2 RID: 15554 RVA: 0x001B9E96 File Offset: 0x001B8096
	private IEnumerator JFEMOBOOBPA()
	{
		PoplDrop.LENODECKJDN lenodeckjdn = new PoplDrop.LENODECKJDN(1);
		lenodeckjdn.AENJLLPLILM = this;
		return lenodeckjdn;
	}

	// Token: 0x06003CC3 RID: 15555 RVA: 0x001B58C0 File Offset: 0x001B3AC0
	public void KOPEJMLNJEO()
	{
		UnityEngine.Object.Destroy(this.frod);
		this.frod = null;
	}

	// Token: 0x06003CC4 RID: 15556 RVA: 0x001BB18C File Offset: 0x001B938C
	public void PILMECNJJEH()
	{
		this.poplavok != null;
		if (this.poplCamera != null)
		{
			LocNewLogic.getI.ABEFPMCIICH();
			this.poplCamera = null;
		}
		if (this.simpleWater != null)
		{
			UnityEngine.Object.Destroy(this.simpleWater);
		}
		if (this.pPricel != null)
		{
			UnityEngine.Object.Destroy(this.pPricel);
		}
		this.poplCamera = null;
		this.simpleWater = null;
		this.pPricel = null;
		Debug.Log("textAsset is NULL! Path: fishModelData");
	}

	// Token: 0x06003CC5 RID: 15557 RVA: 0x001BB216 File Offset: 0x001B9416
	public bool FGNHMGLEPNE()
	{
		return Time.time - this.MJNCFCNJOIM < 130f;
	}

	// Token: 0x06003CC6 RID: 15558 RVA: 0x001BB22C File Offset: 0x001B942C
	public void ACKNHELCOMB()
	{
		this.poplavok != null;
		if (this.poplCamera != null)
		{
			LocNewLogic.getI.closePoplCamera();
			this.poplCamera = null;
		}
		if (this.simpleWater != null)
		{
			UnityEngine.Object.Destroy(this.simpleWater);
		}
		if (this.pPricel != null)
		{
			UnityEngine.Object.Destroy(this.pPricel);
		}
		this.poplCamera = null;
		this.simpleWater = null;
		this.pPricel = null;
		Debug.Log("_Metrics");
	}

	// Token: 0x06003CC7 RID: 15559 RVA: 0x001BB2B8 File Offset: 0x001B94B8
	public void poplavokDown(float DPIDNFHGCEP)
	{
		if (this.poplScript == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD == null)
		{
			return;
		}
		if ((100f - BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.OBEOJCGHOGL) / 1000f > Mathf.Abs(DPIDNFHGCEP))
		{
			return;
		}
		DPIDNFHGCEP = DPIDNFHGCEP * BOIKJDICEMF.IKGFHGKKCPG.MPMLJCLEKJP().PFNCHEEEBKD.LODGJCMEGAI.OBEOJCGHOGL / 100f;
		DPIDNFHGCEP *= 2f;
		DPIDNFHGCEP = Mathf.Clamp(DPIDNFHGCEP, -0.15f, 0.15f);
		base.transform.position = new Vector3(base.transform.position.x, base.transform.position.y - DPIDNFHGCEP, base.transform.position.z);
		float num = 0.2f + DPIDNFHGCEP / 0.05f * 0.5f;
		num = Mathf.Clamp(num, 0.2f, 0.6f);
		base.StartCoroutine(this.KPNCDMBMEJH(num));
		this.poplScript.rotWAngle = UnityEngine.Random.value * 100f - 50f;
		if (base.transform.position.y < LocNewLogic.getI.getDeepInPoint(base.transform.position))
		{
			base.transform.position = new Vector3(base.transform.position.x, LocNewLogic.getI.getDeepInPoint(base.transform.position), base.transform.position.z);
		}
		LocNewLogic.getI.createWaterCircleSmall(this.poplavok.transform.position, 1);
	}

	// Token: 0x06003CC8 RID: 15560 RVA: 0x001BB46C File Offset: 0x001B966C
	public bool EDOGIDHDOLK()
	{
		bool result = true;
		if (this.BGAOINIIDNI())
		{
			result = true;
		}
		if (this.DNFJJONFBBK())
		{
			result = false;
		}
		if (this.JBNPMPDEMLD())
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06003CC9 RID: 15561 RVA: 0x001BB49C File Offset: 0x001B969C
	public void killPodsek()
	{
		this.poplavok != null;
		if (this.poplCamera != null)
		{
			LocNewLogic.getI.closePoplCamera();
			this.poplCamera = null;
		}
		if (this.simpleWater != null)
		{
			UnityEngine.Object.Destroy(this.simpleWater);
		}
		if (this.pPricel != null)
		{
			UnityEngine.Object.Destroy(this.pPricel);
		}
		this.poplCamera = null;
		this.simpleWater = null;
		this.pPricel = null;
		Debug.Log("killPodsek");
	}

	// Token: 0x06003CCA RID: 15562 RVA: 0x001BB528 File Offset: 0x001B9728
	private void ADNELFNPFJB()
	{
		this.poplCamera = LocNewLogic.getI.openPoplCamera();
		if (this.poplCamera == null)
		{
			LocNewLogic.getI.ABEFPMCIICH();
			return;
		}
		this.poplCamera.transform.rotation = new Quaternion(1315f, 1203f, 1567f, 192f);
		this.poplCamera.transform.localScale = new Vector3(199f, 455f, 437f);
		this.poplCamera.GetComponent<Camera>().fieldOfView = 903f;
		Vector3 normalized = (Fisherman.getI.transform.position + Vector3.up * 1406f - this.poplavok.transform.position).normalized;
		Vector3 position = this.poplavok.transform.position + normalized * this.cdist;
		position.y = LocNewLogic.getI.IGHOGONIKLC() + this.popCamHgt;
		this.poplCamera.transform.position = position;
		Vector3 position2 = this.poplavok.transform.position;
		position2.y = LocNewLogic.getI.OGJHINOLHJJ;
		this.poplCamera.transform.LookAt(position2 + Vector3.up * 1285f);
	}

	// Token: 0x06003CCB RID: 15563 RVA: 0x001BB694 File Offset: 0x001B9894
	public void CNKAKCCOLFL()
	{
		this.poplavok != null;
		if (this.poplCamera != null)
		{
			LocNewLogic.getI.closePoplCamera();
			this.poplCamera = null;
		}
		if (this.simpleWater != null)
		{
			UnityEngine.Object.Destroy(this.simpleWater);
		}
		if (this.pPricel != null)
		{
			UnityEngine.Object.Destroy(this.pPricel);
		}
		this.poplCamera = null;
		this.simpleWater = null;
		this.pPricel = null;
		Debug.Log("Noise & Grain effect failing as noise texture is not assigned. please assign.");
	}

	// Token: 0x06003CCC RID: 15564 RVA: 0x001BB720 File Offset: 0x001B9920
	private void DHIJGNHBMFJ()
	{
		PoplDrop.getI = this;
		base.transform.gameObject.layer = 36;
		this.FOOCGDPOFDK = DateTime.Now;
		this.isKlevEnable = false;
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI == null)
		{
			return;
		}
		if (BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod != null)
		{
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.widthCurve = this.LR.widthCurve;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.widthMultiplier = this.LR.widthMultiplier;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.startColor = this.LR.startColor;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.endColor = this.LR.endColor;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.textureMode = this.LR.textureMode;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.enabled = true;
			BOIKJDICEMF.IKGFHGKKCPG.AOEGNGOGNBI.LRRod.material = this.LR.material;
			BOIKJDICEMF.IKGFHGKKCPG.FBCPDABDHOB();
		}
		this.provType = 0;
		this.rolltime = 694f;
		this.evntList.Clear();
	}

	// Token: 0x06003CCD RID: 15565 RVA: 0x001BB87C File Offset: 0x001B9A7C
	public void AENBMDLDMKJ(int INFHFKFJHHG)
	{
		if (Time.time - this.playBaitTime < 1441f)
		{
			this.MJNCFCNJOIM = Time.time;
			return;
		}
		if (ObscuredFloat.PFCANBAOMCB(BOIKJDICEMF.IKGFHGKKCPG.FALNIKDDCJL().BNKBCOAANNG) > 1998f)
		{
			if (LocNewLogic.getI.CDBIEPGNONF() - base.transform.position.y < 357f && this.lure != null)
			{
				this.lure.MODKJPBNKOD();
				if (this.lure.lureType == Lure.AKCCILPKJMN.Jig)
				{
					LocNewLogic.getI.createSmallWaterSplash(base.transform.position);
				}
			}
			this.playBaitTime = Time.time;
		}
	}

	// Token: 0x06003CCF RID: 15567 RVA: 0x001B58B8 File Offset: 0x001B3AB8
	public PoplDrop.DGLFOLICLDL GIGAPNDNOKC()
	{
		return this.KNAHCJNDKKK;
	}

	// Token: 0x04000875 RID: 2165
	public AraTrail trail;

	// Token: 0x04000876 RID: 2166
	public AraTrail lineTrail;

	// Token: 0x04000877 RID: 2167
	public Vector3 correctRotate;

	// Token: 0x04000878 RID: 2168
	public Vector3 velos;

	// Token: 0x04000879 RID: 2169
	public Lure lure;

	// Token: 0x0400087A RID: 2170
	public GameObject modelCatalog;

	// Token: 0x0400087B RID: 2171
	public PhysBait physBait;

	// Token: 0x0400087C RID: 2172
	public Rigidbody connectorRbody;

	// Token: 0x0400087D RID: 2173
	public Rigidbody rbody;

	// Token: 0x0400087E RID: 2174
	public float lineDelta = -0.07f;

	// Token: 0x0400087F RID: 2175
	public float onAirDrag = 1f;

	// Token: 0x04000880 RID: 2176
	public float scaleMass = 10f;

	// Token: 0x04000881 RID: 2177
	public float scaleDeepForce = 10f;

	// Token: 0x04000882 RID: 2178
	public float scaleUpForce = 0.5f;

	// Token: 0x04000883 RID: 2179
	public float currUpForce;

	// Token: 0x04000884 RID: 2180
	public Vector3 velocityChange;

	// Token: 0x04000885 RID: 2181
	public Vector3 desiredVelocity;

	// Token: 0x04000886 RID: 2182
	public float jforce;

	// Token: 0x04000887 RID: 2183
	public float jforceScaler;

	// Token: 0x04000888 RID: 2184
	public float vobDownClamp = 1f;

	// Token: 0x04000889 RID: 2185
	public float downForceClamp = 9f;

	// Token: 0x0400088A RID: 2186
	public float upForceClamp = 5f;

	// Token: 0x0400088B RID: 2187
	public float scaleFlowForce = 10f;

	// Token: 0x0400088C RID: 2188
	public float vobblerScaler = 1f;

	// Token: 0x0400088D RID: 2189
	public float updwscaler = 0.1f;

	// Token: 0x0400088E RID: 2190
	public RopeScript rope;

	// Token: 0x0400088F RID: 2191
	public ParticleSystem partSys;

	// Token: 0x04000890 RID: 2192
	public GameObject PoplObj;

	// Token: 0x04000891 RID: 2193
	public GameObject SpinObj;

	// Token: 0x04000892 RID: 2194
	public GameObject FiderObj;

	// Token: 0x04000893 RID: 2195
	public GameObject Koleb;

	// Token: 0x04000894 RID: 2196
	public GameObject Vertu;

	// Token: 0x04000895 RID: 2197
	public GameObject Jig;

	// Token: 0x04000896 RID: 2198
	public GameObject Vobler;

	// Token: 0x04000897 RID: 2199
	public GameObject bmod;

	// Token: 0x04000898 RID: 2200
	public LineRenderer LR;

	// Token: 0x04000899 RID: 2201
	public static PoplDrop getI;

	// Token: 0x0400089A RID: 2202
	public float deep;

	// Token: 0x0400089B RID: 2203
	public float wlevel;

	// Token: 0x0400089C RID: 2204
	public const int _InHand = 0;

	// Token: 0x0400089D RID: 2205
	public const int _Dropped = 1;

	// Token: 0x0400089E RID: 2206
	public const int _Deep = 2;

	// Token: 0x0400089F RID: 2207
	public const int _Wait = 3;

	// Token: 0x040008A0 RID: 2208
	public const int _FishOn = 4;

	// Token: 0x040008A1 RID: 2209
	public int mode;

	// Token: 0x040008A2 RID: 2210
	public int spinmode;

	// Token: 0x040008A3 RID: 2211
	public Vector3 fromPos = Vector3.zero;

	// Token: 0x040008A4 RID: 2212
	public Vector3 toPos = Vector3.zero;

	// Token: 0x040008A5 RID: 2213
	public float speed = 1f;

	// Token: 0x040008A6 RID: 2214
	private Vector3 JAJMIJPIDBL = Vector3.zero;

	// Token: 0x040008A7 RID: 2215
	private Vector3 IIGDEPLPNME = Vector3.zero;

	// Token: 0x040008A8 RID: 2216
	private float GADFHLLJKOH;

	// Token: 0x040008A9 RID: 2217
	private float JEHEPNHGJOH;

	// Token: 0x040008AA RID: 2218
	private const float NINDJFFOODK = 1f;

	// Token: 0x040008AB RID: 2219
	private DateTime FOOCGDPOFDK;

	// Token: 0x040008AC RID: 2220
	public GameObject poplavok;

	// Token: 0x040008AD RID: 2221
	public Poplavok poplScript;

	// Token: 0x040008AE RID: 2222
	public GameObject poplCamera;

	// Token: 0x040008AF RID: 2223
	public GameObject pPricel;

	// Token: 0x040008B0 RID: 2224
	public GameObject fishPointer;

	// Token: 0x040008B1 RID: 2225
	public GameObject simpleWater;

	// Token: 0x040008B2 RID: 2226
	public FishOnRod fish;

	// Token: 0x040008B3 RID: 2227
	public GameObject frod;

	// Token: 0x040008B4 RID: 2228
	public const int DEEP_UP = 0;

	// Token: 0x040008B5 RID: 2229
	public const int DEEP_MIDDLE = 1;

	// Token: 0x040008B6 RID: 2230
	public const int DEEP_DOWN = 2;

	// Token: 0x040008B7 RID: 2231
	public float popCamHgt = 0.3f;

	// Token: 0x040008B8 RID: 2232
	public float cdist = 0.45f;

	// Token: 0x040008B9 RID: 2233
	public bool isKlevEnable;

	// Token: 0x040008BA RID: 2234
	public bool isTopDown;

	// Token: 0x040008BB RID: 2235
	private bool EHGOFGHNIFE;

	// Token: 0x040008BC RID: 2236
	private Vector3 AGBEBCGAACP = Vector3.zero;

	// Token: 0x040008BD RID: 2237
	private Vector3 FMPGPPIMBNG = Vector3.zero;

	// Token: 0x040008BE RID: 2238
	private PoplDrop.DGLFOLICLDL KNAHCJNDKKK;

	// Token: 0x040008BF RID: 2239
	private float BBKPOKNIAEG;

	// Token: 0x040008C0 RID: 2240
	public float rolltime;

	// Token: 0x040008C1 RID: 2241
	public List<int> evntList = new List<int>();

	// Token: 0x040008C2 RID: 2242
	public int provType;

	// Token: 0x040008C3 RID: 2243
	private float NBEDBFEJICE;

	// Token: 0x040008C4 RID: 2244
	private Vector3 BAHHIKELOJP;

	// Token: 0x040008C5 RID: 2245
	private Color KODIENKGJKD;

	// Token: 0x040008C6 RID: 2246
	private Color KKJLKIGNBIJ;

	// Token: 0x040008C7 RID: 2247
	private Color OIIBMFNKGHK;

	// Token: 0x040008C8 RID: 2248
	private Color COILGBLGMCC;

	// Token: 0x040008C9 RID: 2249
	private float CHKKHJDMMIF;

	// Token: 0x040008CA RID: 2250
	public Vector3 toMovePos;

	// Token: 0x040008CB RID: 2251
	private bool MADOEDALIHK;

	// Token: 0x040008CC RID: 2252
	private float BCKEILBFCNM = 68f;

	// Token: 0x040008CD RID: 2253
	private float KBNKBLGMFAA = 1.2f;

	// Token: 0x040008CE RID: 2254
	private Vector3 ODLPDNDEEHM = Vector3.zero;

	// Token: 0x040008CF RID: 2255
	private float MJFNOFCLLHJ;

	// Token: 0x040008D0 RID: 2256
	private bool ADLIOAFMGMA;

	// Token: 0x040008D1 RID: 2257
	private bool HDONIMLIFDH;

	// Token: 0x040008D2 RID: 2258
	private Vector3 GBEIDPOCJBF;

	// Token: 0x040008D3 RID: 2259
	private const float HIMDHKGOCKK = 0.03f;

	// Token: 0x040008D4 RID: 2260
	public float lineTension;

	// Token: 0x040008D5 RID: 2261
	public float lineOverDistance;

	// Token: 0x040008D6 RID: 2262
	public float playBaitTime;

	// Token: 0x040008D7 RID: 2263
	public float groutBaitTime;

	// Token: 0x040008D8 RID: 2264
	public float waterBaitTime;

	// Token: 0x040008D9 RID: 2265
	public float isMovingTime;

	// Token: 0x040008DA RID: 2266
	private float MJNCFCNJOIM;

	// Token: 0x02000126 RID: 294
	public enum DGLFOLICLDL
	{
		// Token: 0x040008DC RID: 2268
		Poplavok,
		// Token: 0x040008DD RID: 2269
		Fider,
		// Token: 0x040008DE RID: 2270
		Spin
	}
}
