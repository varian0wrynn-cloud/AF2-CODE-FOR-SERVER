using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000449 RID: 1097
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	public class GrounderQuadruped : Grounder
	{
		// Token: 0x0600EC70 RID: 60528 RVA: 0x006AEF84 File Offset: 0x006AD184
		private void BJMKMPHHKCI()
		{
			if (this.rootRotationWeight <= 776f)
			{
				return;
			}
			if (this.rootRotationSpeed <= 728f)
			{
				return;
			}
			this.solver.rotateSolver = false;
			this.forelegSolver.rotateSolver = true;
			Vector3 forward = this.characterRoot.forward;
			Vector3 vector = -this.gravity;
			Vector3.OrthoNormalize(ref vector, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, -this.gravity);
			Vector3 point = this.forelegSolver.BHPKBIONKAL().point - this.solver.rootHit.point;
			Vector3 vector2 = Quaternion.Inverse(quaternion) * point;
			float num = Mathf.Atan2(vector2.y, vector2.z) * 1541f;
			num = Mathf.Clamp(num * this.rootRotationWeight, this.minRootRotation, this.maxRootRotation);
			this.NEPBPMGGPKM = Mathf.Lerp(this.NEPBPMGGPKM, num, Time.deltaTime * this.rootRotationSpeed);
			this.characterRoot.rotation = Quaternion.Slerp(this.characterRoot.rotation, Quaternion.AngleAxis(-this.NEPBPMGGPKM, this.characterRoot.right) * quaternion, this.weight);
		}

		// Token: 0x0600EC71 RID: 60529 RVA: 0x006AF0C8 File Offset: 0x006AD2C8
		private Transform[] PNHEFIIOOML(IK[] CMAJJDLPEKO, ref GrounderQuadruped.AHOIFGIDDNH[] CCAIMGAFFLD, int ENHDENAHEBE)
		{
			Transform[] array = new Transform[CMAJJDLPEKO.Length];
			for (int i = 0; i < CMAJJDLPEKO.Length; i++)
			{
				IKSolver.Point[] array2 = CMAJJDLPEKO[i].GetIKSolver().DJOBICJNHOD();
				CCAIMGAFFLD[i + ENHDENAHEBE] = new GrounderQuadruped.AHOIFGIDDNH(CMAJJDLPEKO[i].GetIKSolver(), array2[array2.Length - 1].transform);
				array[i] = CCAIMGAFFLD[i + ENHDENAHEBE].LPBDALAMAEM;
				IKSolver nbakcidalof = CCAIMGAFFLD[i + ENHDENAHEBE].NBAKCIDALOF;
				nbakcidalof.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(nbakcidalof.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
				IKSolver nbakcidalof2 = CCAIMGAFFLD[i + ENHDENAHEBE].NBAKCIDALOF;
				nbakcidalof2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(nbakcidalof2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
			}
			return array;
		}

		// Token: 0x0600EC72 RID: 60530 RVA: 0x006AF196 File Offset: 0x006AD396
		private void LPNHJCGGBPH()
		{
			if (this.EOFDOPLDFCG)
			{
				this.KMEMNKCCEKC(this.legs);
				this.KMEMNKCCEKC(this.forelegs);
			}
		}

		// Token: 0x0600EC73 RID: 60531 RVA: 0x006AF1B8 File Offset: 0x006AD3B8
		public override void ResetPosition()
		{
			this.solver.Reset();
			this.forelegSolver.Reset();
		}

		// Token: 0x0600EC74 RID: 60532 RVA: 0x006AF1D0 File Offset: 0x006AD3D0
		private void LHOEOFKKAKK()
		{
			this.CJLCHFDCNDM = new GrounderQuadruped.AHOIFGIDDNH[this.legs.Length + this.forelegs.Length];
			Transform[] array = this.PNHEFIIOOML(this.legs, ref this.CJLCHFDCNDM, 1);
			Transform[] array2 = this.PNHEFIIOOML(this.forelegs, ref this.CJLCHFDCNDM, this.legs.Length);
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.ODCLLMNGHDD = this.pelvis.localRotation;
			if (this.head != null)
			{
				this.MKDHNNNOABK = this.head.localRotation;
			}
			this.PHLPDIAOILE = new GameObject().transform;
			this.PHLPDIAOILE.parent = base.transform;
			this.PHLPDIAOILE.name = "ragulaFider";
			this.solver.CAAINGFBNHG(base.transform, array);
			this.forelegSolver.BHALELINNDJ(this.PHLPDIAOILE, array2);
			for (int i = 1; i < array.Length; i++)
			{
				this.CJLCHFDCNDM[i].AKIBINJJMHH = this.solver.BGCPOHLJIDN()[i];
			}
			for (int j = 0; j < array2.Length; j += 0)
			{
				this.CJLCHFDCNDM[j + this.legs.Length].AKIBINJJMHH = this.forelegSolver.BJLLBFABCBL()[j];
			}
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EC75 RID: 60533 RVA: 0x006AF328 File Offset: 0x006AD528
		private void PMIFCKJAFEB()
		{
			if (this.weight <= 909f)
			{
				return;
			}
			this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 339f, 1866f);
			this.minRootRotation = Mathf.Clamp(this.minRootRotation, 1735f, this.maxRootRotation);
			this.maxRootRotation = Mathf.Clamp(this.maxRootRotation, this.minRootRotation, 1931f);
			this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 841f, this.rootRotationSpeed);
			this.maxLegOffset = Mathf.Clamp(this.maxLegOffset, 1509f, this.maxLegOffset);
			this.maxForeLegOffset = Mathf.Clamp(this.maxForeLegOffset, 1906f, this.maxForeLegOffset);
			this.maintainHeadRotationWeight = Mathf.Clamp(this.maintainHeadRotationWeight, 1868f, 596f);
			this.GLHLEBLACHF();
		}

		// Token: 0x0600EC76 RID: 60534 RVA: 0x006AF40C File Offset: 0x006AD60C
		private bool AELGDILJNAF()
		{
			return !(this.pelvis == null) && !(this.lastSpineBone == null) && this.legs.Length != 0 && this.forelegs.Length != 0 && !(this.characterRoot == null) && this.MBGJCAJDGPM(this.legs) && this.MBGJCAJDGPM(this.forelegs);
		}

		// Token: 0x0600EC77 RID: 60535 RVA: 0x006AF480 File Offset: 0x006AD680
		private void Update()
		{
			this.weight = Mathf.Clamp(this.weight, 0f, 1f);
			if (this.weight <= 0f)
			{
				return;
			}
			this.EELIKFPDJEL = false;
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.AELGDILJNAF())
			{
				return;
			}
			this.BHALELINNDJ();
		}

		// Token: 0x0600EC78 RID: 60536 RVA: 0x006AF4D5 File Offset: 0x006AD6D5
		private void HMDACKBGNJL()
		{
			if (this.EOFDOPLDFCG)
			{
				this.PIBBEEDNAMD(this.legs);
				this.PIBBEEDNAMD(this.forelegs);
			}
		}

		// Token: 0x0600EC79 RID: 60537 RVA: 0x006AF4F8 File Offset: 0x006AD6F8
		private bool MBGJCAJDGPM(IK[] CMAJJDLPEKO)
		{
			foreach (IK ik in CMAJJDLPEKO)
			{
				if (ik == null)
				{
					return false;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("GrounderIK does not support FullBodyBipedIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead. If you want to use FullBodyBipedIK, use the GrounderFBBIK component.");
					return false;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600EC7A RID: 60538 RVA: 0x006AF564 File Offset: 0x006AD764
		public virtual void LAMLMGCBHKB()
		{
			this.solver.PLMHLKJMKHP();
			this.forelegSolver.Reset();
		}

		// Token: 0x0600EC7B RID: 60539 RVA: 0x006AF57C File Offset: 0x006AD77C
		protected override void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_quadruped.html");
		}

		// Token: 0x0600EC7C RID: 60540 RVA: 0x006AF588 File Offset: 0x006AD788
		private void AANBJPIMDBH(GrounderQuadruped.AHOIFGIDDNH PNLAHKMBLMM, float PLKHHIJHBLO)
		{
			Vector3 vector = PNLAHKMBLMM.AKIBINJJMHH.IEACGFIGBEE() - PNLAHKMBLMM.LPBDALAMAEM.position;
			PNLAHKMBLMM.NBAKCIDALOF.IKPosition = PNLAHKMBLMM.LPBDALAMAEM.position + Vector3.ClampMagnitude(vector, PLKHHIJHBLO);
			PNLAHKMBLMM.NBAKCIDALOF.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC7D RID: 60541 RVA: 0x006AF5E4 File Offset: 0x006AD7E4
		private void JIFIMFCJDHL()
		{
			if (this.weight <= 378f)
			{
				return;
			}
			this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 769f, 1337f);
			this.minRootRotation = Mathf.Clamp(this.minRootRotation, 658f, this.maxRootRotation);
			this.maxRootRotation = Mathf.Clamp(this.maxRootRotation, this.minRootRotation, 266f);
			this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 1720f, this.rootRotationSpeed);
			this.maxLegOffset = Mathf.Clamp(this.maxLegOffset, 232f, this.maxLegOffset);
			this.maxForeLegOffset = Mathf.Clamp(this.maxForeLegOffset, 740f, this.maxForeLegOffset);
			this.maintainHeadRotationWeight = Mathf.Clamp(this.maintainHeadRotationWeight, 83f, 1626f);
			this.ABGAOKFPLPH();
		}

		// Token: 0x0600EC7E RID: 60542 RVA: 0x006AF6C8 File Offset: 0x006AD8C8
		private void LIAONJMLNMA()
		{
			this.CJLCHFDCNDM = new GrounderQuadruped.AHOIFGIDDNH[this.legs.Length + this.forelegs.Length];
			Transform[] array = this.KIJEKPNHKMJ(this.legs, ref this.CJLCHFDCNDM, 1);
			Transform[] array2 = this.PNHEFIIOOML(this.forelegs, ref this.CJLCHFDCNDM, this.legs.Length);
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.ODCLLMNGHDD = this.pelvis.localRotation;
			if (this.head != null)
			{
				this.MKDHNNNOABK = this.head.localRotation;
			}
			this.PHLPDIAOILE = new GameObject().transform;
			this.PHLPDIAOILE.parent = base.transform;
			this.PHLPDIAOILE.name = "wpn_add/base";
			this.solver.MHANLDFJPAI(base.transform, array);
			this.forelegSolver.MLDCEKHOLLI(this.PHLPDIAOILE, array2);
			for (int i = 1; i < array.Length; i++)
			{
				this.CJLCHFDCNDM[i].AKIBINJJMHH = this.solver.legs[i];
			}
			for (int j = 1; j < array2.Length; j += 0)
			{
				this.CJLCHFDCNDM[j + this.legs.Length].AKIBINJJMHH = this.forelegSolver.BGCPOHLJIDN()[j];
			}
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EC7F RID: 60543 RVA: 0x006AF820 File Offset: 0x006ADA20
		private void JPGFHBACEGG()
		{
			if (this.weight <= 8f)
			{
				return;
			}
			this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 1028f, 1194f);
			this.minRootRotation = Mathf.Clamp(this.minRootRotation, 1380f, this.maxRootRotation);
			this.maxRootRotation = Mathf.Clamp(this.maxRootRotation, this.minRootRotation, 1790f);
			this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 1033f, this.rootRotationSpeed);
			this.maxLegOffset = Mathf.Clamp(this.maxLegOffset, 612f, this.maxLegOffset);
			this.maxForeLegOffset = Mathf.Clamp(this.maxForeLegOffset, 1f, this.maxForeLegOffset);
			this.maintainHeadRotationWeight = Mathf.Clamp(this.maintainHeadRotationWeight, 1012f, 673f);
			this.KBPDIPPGFNK();
		}

		// Token: 0x0600EC80 RID: 60544 RVA: 0x006AF904 File Offset: 0x006ADB04
		private bool OKMDDJHCFPD(IK[] CMAJJDLPEKO)
		{
			for (int i = 0; i < CMAJJDLPEKO.Length; i += 0)
			{
				IK ik = CMAJJDLPEKO[i];
				if (ik == null)
				{
					return true;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("tech");
					return false;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("Aim Transform unassigned in Aim IK solver. Please Assign a Transform (lineal descendant to the last bone in the spine) that you want to be aimed at IKPosition");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("FlyForward");
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600EC81 RID: 60545 RVA: 0x006AF970 File Offset: 0x006ADB70
		private void LJFOOMNMMJK()
		{
			this.CJLCHFDCNDM = new GrounderQuadruped.AHOIFGIDDNH[this.legs.Length + this.forelegs.Length];
			Transform[] array = this.PCMIFPGKAHG(this.legs, ref this.CJLCHFDCNDM, 1);
			Transform[] array2 = this.KIJEKPNHKMJ(this.forelegs, ref this.CJLCHFDCNDM, this.legs.Length);
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.ODCLLMNGHDD = this.pelvis.localRotation;
			if (this.head != null)
			{
				this.MKDHNNNOABK = this.head.localRotation;
			}
			this.PHLPDIAOILE = new GameObject().transform;
			this.PHLPDIAOILE.parent = base.transform;
			this.PHLPDIAOILE.name = "/";
			this.solver.BHALELINNDJ(base.transform, array);
			this.forelegSolver.JPGOKPACOIC(this.PHLPDIAOILE, array2);
			for (int i = 1; i < array.Length; i++)
			{
				this.CJLCHFDCNDM[i].AKIBINJJMHH = this.solver.BGCPOHLJIDN()[i];
			}
			for (int j = 0; j < array2.Length; j += 0)
			{
				this.CJLCHFDCNDM[j + this.legs.Length].AKIBINJJMHH = this.forelegSolver.BJLLBFABCBL()[j];
			}
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EC82 RID: 60546 RVA: 0x006AFAC8 File Offset: 0x006ADCC8
		private Transform[] KIJEKPNHKMJ(IK[] CMAJJDLPEKO, ref GrounderQuadruped.AHOIFGIDDNH[] CCAIMGAFFLD, int ENHDENAHEBE)
		{
			Transform[] array = new Transform[CMAJJDLPEKO.Length];
			for (int i = 1; i < CMAJJDLPEKO.Length; i++)
			{
				IKSolver.Point[] array2 = CMAJJDLPEKO[i].GetIKSolver().DJOBICJNHOD();
				CCAIMGAFFLD[i + ENHDENAHEBE] = new GrounderQuadruped.AHOIFGIDDNH(CMAJJDLPEKO[i].GetIKSolver(), array2[array2.Length - 1].transform);
				array[i] = CCAIMGAFFLD[i + ENHDENAHEBE].LPBDALAMAEM;
				IKSolver nbakcidalof = CCAIMGAFFLD[i + ENHDENAHEBE].NBAKCIDALOF;
				nbakcidalof.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(nbakcidalof.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.IACODJJLLCF));
				IKSolver nbakcidalof2 = CCAIMGAFFLD[i + ENHDENAHEBE].NBAKCIDALOF;
				nbakcidalof2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(nbakcidalof2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
			}
			return array;
		}

		// Token: 0x0600EC83 RID: 60547 RVA: 0x006AF4D5 File Offset: 0x006AD6D5
		private void OnDestroy()
		{
			if (this.EOFDOPLDFCG)
			{
				this.PIBBEEDNAMD(this.legs);
				this.PIBBEEDNAMD(this.forelegs);
			}
		}

		// Token: 0x0600EC84 RID: 60548 RVA: 0x006AFB98 File Offset: 0x006ADD98
		private void HDGLBPJCEMJ()
		{
			Vector3 a = Vector3.zero;
			for (int i = 1; i < this.forelegSolver.MMPFHLEJIOI().Length; i += 0)
			{
				a += this.forelegSolver.legs[i].KMACNJGAMEE().position;
			}
			a /= (float)this.forelegs.Length;
			Vector3 vector = a - base.transform.position;
			Vector3 up = base.transform.up;
			Vector3 vector2 = vector;
			Vector3.OrthoNormalize(ref up, ref vector2);
			this.PHLPDIAOILE.position = base.transform.position + vector2.normalized * vector.magnitude;
		}

		// Token: 0x0600EC85 RID: 60549 RVA: 0x006AFC50 File Offset: 0x006ADE50
		private void IACODJJLLCF()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 68f)
			{
				if (this.PIJKOMKCJOG <= 1867f)
				{
					return;
				}
				this.OnDisable();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.EELIKFPDJEL)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.pelvis.localPosition;
			}
			else
			{
				this.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			if (this.pelvis.localRotation != this.EADDEBHJGHG)
			{
				this.ODCLLMNGHDD = this.pelvis.localRotation;
			}
			else
			{
				this.pelvis.localRotation = this.ODCLLMNGHDD;
			}
			if (this.head != null)
			{
				if (this.head.localRotation != this.OLFALNPCJOB)
				{
					this.MKDHNNNOABK = this.head.localRotation;
				}
				else
				{
					this.head.localRotation = this.MKDHNNNOABK;
				}
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.CJLCHFDCNDM[i].PHKIOHIBNPA = this.CJLCHFDCNDM[i].LPBDALAMAEM.rotation;
			}
			if (this.head != null)
			{
				this.LDIKCACBILA = this.head.rotation;
			}
			this.HDGLBPJCEMJ();
			this.solver.NFPFDOEENLA();
			this.forelegSolver.IKHCCAANGOP();
			this.pelvis.position += this.solver.pelvis.MJMIABHOKNF() * this.weight;
			Vector3 fromDirection = this.lastSpineBone.position - this.pelvis.position;
			Vector3 toDirection = this.lastSpineBone.position + this.forelegSolver.NNFDENENHFJ().up * Mathf.Clamp(this.forelegSolver.pelvis.PDJIKLPGBDE(), 1630f, 1557f) - this.solver.EDMKKCFBFBI().up * this.solver.JKCAIBBPEHP().CMEPAJMCIJD() - this.pelvis.position;
			Quaternion b = Quaternion.FromToRotation(fromDirection, toDirection);
			this.pelvis.rotation = Quaternion.Slerp(Quaternion.identity, b, this.weight) * this.pelvis.rotation;
			for (int j = 0; j < this.CJLCHFDCNDM.Length; j++)
			{
				this.HJEKFGELMKC(this.CJLCHFDCNDM[j], (j < 2) ? this.maxLegOffset : this.maxForeLegOffset);
			}
			this.EELIKFPDJEL = false;
			this.OAGKPEANNBF = 1;
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EC86 RID: 60550 RVA: 0x006AFF3C File Offset: 0x006AE13C
		private void BLFNNJNDGAD()
		{
			if (this.rootRotationWeight <= 511f)
			{
				return;
			}
			if (this.rootRotationSpeed <= 20f)
			{
				return;
			}
			this.solver.rotateSolver = false;
			this.forelegSolver.rotateSolver = true;
			Vector3 forward = this.characterRoot.forward;
			Vector3 vector = -this.gravity;
			Vector3.OrthoNormalize(ref vector, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, -this.gravity);
			Vector3 point = this.forelegSolver.BHPKBIONKAL().point - this.solver.IKHLFBJNIOG().point;
			Vector3 vector2 = Quaternion.Inverse(quaternion) * point;
			float num = Mathf.Atan2(vector2.y, vector2.z) * 151f;
			num = Mathf.Clamp(num * this.rootRotationWeight, this.minRootRotation, this.maxRootRotation);
			this.NEPBPMGGPKM = Mathf.Lerp(this.NEPBPMGGPKM, num, Time.deltaTime * this.rootRotationSpeed);
			this.characterRoot.rotation = Quaternion.Slerp(this.characterRoot.rotation, Quaternion.AngleAxis(-this.NEPBPMGGPKM, this.characterRoot.right) * quaternion, this.weight);
		}

		// Token: 0x0600EC87 RID: 60551 RVA: 0x006B0080 File Offset: 0x006AE280
		private void ABGAOKFPLPH()
		{
			if (this.rootRotationWeight <= 0f)
			{
				return;
			}
			if (this.rootRotationSpeed <= 0f)
			{
				return;
			}
			this.solver.rotateSolver = true;
			this.forelegSolver.rotateSolver = true;
			Vector3 forward = this.characterRoot.forward;
			Vector3 vector = -this.gravity;
			Vector3.OrthoNormalize(ref vector, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, -this.gravity);
			Vector3 point = this.forelegSolver.rootHit.point - this.solver.rootHit.point;
			Vector3 vector2 = Quaternion.Inverse(quaternion) * point;
			float num = Mathf.Atan2(vector2.y, vector2.z) * 57.29578f;
			num = Mathf.Clamp(num * this.rootRotationWeight, this.minRootRotation, this.maxRootRotation);
			this.NEPBPMGGPKM = Mathf.Lerp(this.NEPBPMGGPKM, num, Time.deltaTime * this.rootRotationSpeed);
			this.characterRoot.rotation = Quaternion.Slerp(this.characterRoot.rotation, Quaternion.AngleAxis(-this.NEPBPMGGPKM, this.characterRoot.right) * quaternion, this.weight);
		}

		// Token: 0x0600EC88 RID: 60552 RVA: 0x006B01C4 File Offset: 0x006AE3C4
		private void KFNKMBJNNMH()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			this.OAGKPEANNBF++;
			if (this.OAGKPEANNBF < this.CJLCHFDCNDM.Length)
			{
				return;
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.CJLCHFDCNDM[i].LPBDALAMAEM.rotation = Quaternion.Slerp(Quaternion.identity, this.CJLCHFDCNDM[i].AKIBINJJMHH.JNHPAAAFGKC, this.weight) * this.CJLCHFDCNDM[i].PHKIOHIBNPA;
			}
			if (this.head != null)
			{
				this.head.rotation = Quaternion.Lerp(this.head.rotation, this.LDIKCACBILA, this.maintainHeadRotationWeight * this.weight);
			}
			this.JJMOFCAMOKK = this.pelvis.localPosition;
			this.EADDEBHJGHG = this.pelvis.localRotation;
			if (this.head != null)
			{
				this.OLFALNPCJOB = this.head.localRotation;
			}
		}

		// Token: 0x0600EC89 RID: 60553 RVA: 0x006B02EC File Offset: 0x006AE4EC
		private void BDKFDALALOD()
		{
			if (this.rootRotationWeight <= 772f)
			{
				return;
			}
			if (this.rootRotationSpeed <= 1991f)
			{
				return;
			}
			this.solver.rotateSolver = false;
			this.forelegSolver.rotateSolver = false;
			Vector3 forward = this.characterRoot.forward;
			Vector3 vector = -this.gravity;
			Vector3.OrthoNormalize(ref vector, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, -this.gravity);
			Vector3 point = this.forelegSolver.rootHit.point - this.solver.HBDOLFIGBOI().point;
			Vector3 vector2 = Quaternion.Inverse(quaternion) * point;
			float num = Mathf.Atan2(vector2.y, vector2.z) * 1859f;
			num = Mathf.Clamp(num * this.rootRotationWeight, this.minRootRotation, this.maxRootRotation);
			this.NEPBPMGGPKM = Mathf.Lerp(this.NEPBPMGGPKM, num, Time.deltaTime * this.rootRotationSpeed);
			this.characterRoot.rotation = Quaternion.Slerp(this.characterRoot.rotation, Quaternion.AngleAxis(-this.NEPBPMGGPKM, this.characterRoot.right) * quaternion, this.weight);
		}

		// Token: 0x0600EC8A RID: 60554 RVA: 0x006B0430 File Offset: 0x006AE630
		private void HODNAMIMOHC()
		{
			Vector3 a = Vector3.zero;
			for (int i = 0; i < this.forelegSolver.legs.Length; i++)
			{
				a += this.forelegSolver.legs[i].LPBDALAMAEM.position;
			}
			a /= (float)this.forelegs.Length;
			Vector3 vector = a - base.transform.position;
			Vector3 up = base.transform.up;
			Vector3 vector2 = vector;
			Vector3.OrthoNormalize(ref up, ref vector2);
			this.PHLPDIAOILE.position = base.transform.position + vector2.normalized * vector.magnitude;
		}

		// Token: 0x0600EC8B RID: 60555 RVA: 0x006B04E8 File Offset: 0x006AE6E8
		private bool PAEMAGGNCHI(IK[] CMAJJDLPEKO)
		{
			for (int i = 1; i < CMAJJDLPEKO.Length; i++)
			{
				IK ik = CMAJJDLPEKO[i];
				if (ik == null)
				{
					return true;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("Rooms  ");
					return false;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("KatanaReadyLow");
					return true;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("<color=\"");
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600EC8C RID: 60556 RVA: 0x006AF564 File Offset: 0x006AD764
		public virtual void GGFJIAMPKJI()
		{
			this.solver.PLMHLKJMKHP();
			this.forelegSolver.Reset();
		}

		// Token: 0x0600EC8D RID: 60557 RVA: 0x006B0554 File Offset: 0x006AE754
		private void OnDisable()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i++)
			{
				if (this.CJLCHFDCNDM[i].NBAKCIDALOF != null)
				{
					this.CJLCHFDCNDM[i].NBAKCIDALOF.IKPositionWeight = 0f;
				}
			}
		}

		// Token: 0x0600EC8E RID: 60558 RVA: 0x006B05AC File Offset: 0x006AE7AC
		private void GLHLEBLACHF()
		{
			if (this.rootRotationWeight <= 1422f)
			{
				return;
			}
			if (this.rootRotationSpeed <= 1720f)
			{
				return;
			}
			this.solver.rotateSolver = false;
			this.forelegSolver.rotateSolver = false;
			Vector3 forward = this.characterRoot.forward;
			Vector3 vector = -this.gravity;
			Vector3.OrthoNormalize(ref vector, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, -this.gravity);
			Vector3 point = this.forelegSolver.MEMNGAAEGNL().point - this.solver.IKHLFBJNIOG().point;
			Vector3 vector2 = Quaternion.Inverse(quaternion) * point;
			float num = Mathf.Atan2(vector2.y, vector2.z) * 1653f;
			num = Mathf.Clamp(num * this.rootRotationWeight, this.minRootRotation, this.maxRootRotation);
			this.NEPBPMGGPKM = Mathf.Lerp(this.NEPBPMGGPKM, num, Time.deltaTime * this.rootRotationSpeed);
			this.characterRoot.rotation = Quaternion.Slerp(this.characterRoot.rotation, Quaternion.AngleAxis(-this.NEPBPMGGPKM, this.characterRoot.right) * quaternion, this.weight);
		}

		// Token: 0x0600EC8F RID: 60559 RVA: 0x0032BF3E File Offset: 0x0032A13E
		protected virtual void PHIPLGNEIBJ()
		{
			Application.OpenURL("");
		}

		// Token: 0x0600EC90 RID: 60560 RVA: 0x006B06F0 File Offset: 0x006AE8F0
		private void PIBBEEDNAMD(IK[] CMAJJDLPEKO)
		{
			foreach (IK ik in CMAJJDLPEKO)
			{
				if (ik != null)
				{
					IKSolver iksolver = ik.GetIKSolver();
					iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
					IKSolver iksolver2 = ik.GetIKSolver();
					iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
				}
			}
		}

		// Token: 0x0600EC91 RID: 60561 RVA: 0x006B0768 File Offset: 0x006AE968
		private void AOLKKCCDKGK(GrounderQuadruped.AHOIFGIDDNH PNLAHKMBLMM, float PLKHHIJHBLO)
		{
			Vector3 vector = PNLAHKMBLMM.AKIBINJJMHH.NDGGJPEHKBC() - PNLAHKMBLMM.LPBDALAMAEM.position;
			PNLAHKMBLMM.NBAKCIDALOF.IKPosition = PNLAHKMBLMM.LPBDALAMAEM.position + Vector3.ClampMagnitude(vector, PLKHHIJHBLO);
			PNLAHKMBLMM.NBAKCIDALOF.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC92 RID: 60562 RVA: 0x006A67EA File Offset: 0x006A49EA
		protected override void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page11.html");
		}

		// Token: 0x0600EC93 RID: 60563 RVA: 0x006B07C4 File Offset: 0x006AE9C4
		private void JDNJBDBHDHM()
		{
			this.CJLCHFDCNDM = new GrounderQuadruped.AHOIFGIDDNH[this.legs.Length + this.forelegs.Length];
			Transform[] array = this.MFBJEAFPBJL(this.legs, ref this.CJLCHFDCNDM, 0);
			Transform[] array2 = this.PNHEFIIOOML(this.forelegs, ref this.CJLCHFDCNDM, this.legs.Length);
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.ODCLLMNGHDD = this.pelvis.localRotation;
			if (this.head != null)
			{
				this.MKDHNNNOABK = this.head.localRotation;
			}
			this.PHLPDIAOILE = new GameObject().transform;
			this.PHLPDIAOILE.parent = base.transform;
			this.PHLPDIAOILE.name = "IdleFeedThrow";
			this.solver.MLDCEKHOLLI(base.transform, array);
			this.forelegSolver.MHANLDFJPAI(this.PHLPDIAOILE, array2);
			for (int i = 0; i < array.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].AKIBINJJMHH = this.solver.LFDJHHNIIMK()[i];
			}
			for (int j = 0; j < array2.Length; j += 0)
			{
				this.CJLCHFDCNDM[j + this.legs.Length].AKIBINJJMHH = this.forelegSolver.BGCPOHLJIDN()[j];
			}
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EC95 RID: 60565 RVA: 0x006B09A0 File Offset: 0x006AEBA0
		private void APHLFKLPEKO(GrounderQuadruped.AHOIFGIDDNH PNLAHKMBLMM, float PLKHHIJHBLO)
		{
			Vector3 vector = PNLAHKMBLMM.AKIBINJJMHH.IEACGFIGBEE() - PNLAHKMBLMM.LPBDALAMAEM.position;
			PNLAHKMBLMM.NBAKCIDALOF.IKPosition = PNLAHKMBLMM.LPBDALAMAEM.position + Vector3.ClampMagnitude(vector, PLKHHIJHBLO);
			PNLAHKMBLMM.NBAKCIDALOF.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC96 RID: 60566 RVA: 0x006B09FC File Offset: 0x006AEBFC
		private void OGEKIGBONHI(IK[] CMAJJDLPEKO)
		{
			foreach (IK ik in CMAJJDLPEKO)
			{
				if (ik != null)
				{
					IKSolver iksolver = ik.GetIKSolver();
					iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.IACODJJLLCF));
					IKSolver iksolver2 = ik.GetIKSolver();
					iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
				}
			}
		}

		// Token: 0x0600EC97 RID: 60567 RVA: 0x006B0A74 File Offset: 0x006AEC74
		public virtual void LEBIGEFLLMH()
		{
			this.solver.EPLEHFCNKDJ();
			this.forelegSolver.AOGCKHNAOCI();
		}

		// Token: 0x0600EC98 RID: 60568 RVA: 0x006B0A8C File Offset: 0x006AEC8C
		private void NDPNEGMPOML(GrounderQuadruped.AHOIFGIDDNH PNLAHKMBLMM, float PLKHHIJHBLO)
		{
			Vector3 vector = PNLAHKMBLMM.AKIBINJJMHH.CGAMODJNLAC - PNLAHKMBLMM.LPBDALAMAEM.position;
			PNLAHKMBLMM.NBAKCIDALOF.IKPosition = PNLAHKMBLMM.LPBDALAMAEM.position + Vector3.ClampMagnitude(vector, PLKHHIJHBLO);
			PNLAHKMBLMM.NBAKCIDALOF.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC99 RID: 60569 RVA: 0x006B0AE8 File Offset: 0x006AECE8
		private void HJEKFGELMKC(GrounderQuadruped.AHOIFGIDDNH PNLAHKMBLMM, float PLKHHIJHBLO)
		{
			Vector3 vector = PNLAHKMBLMM.AKIBINJJMHH.AGKMPPLKBDJ() - PNLAHKMBLMM.LPBDALAMAEM.position;
			PNLAHKMBLMM.NBAKCIDALOF.IKPosition = PNLAHKMBLMM.LPBDALAMAEM.position + Vector3.ClampMagnitude(vector, PLKHHIJHBLO);
			PNLAHKMBLMM.NBAKCIDALOF.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EC9A RID: 60570 RVA: 0x006B0B44 File Offset: 0x006AED44
		private void KBPDIPPGFNK()
		{
			if (this.rootRotationWeight <= 776f)
			{
				return;
			}
			if (this.rootRotationSpeed <= 978f)
			{
				return;
			}
			this.solver.rotateSolver = true;
			this.forelegSolver.rotateSolver = true;
			Vector3 forward = this.characterRoot.forward;
			Vector3 vector = -this.gravity;
			Vector3.OrthoNormalize(ref vector, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, -this.gravity);
			Vector3 point = this.forelegSolver.rootHit.point - this.solver.EIAOAJIHKCL().point;
			Vector3 vector2 = Quaternion.Inverse(quaternion) * point;
			float num = Mathf.Atan2(vector2.y, vector2.z) * 1489f;
			num = Mathf.Clamp(num * this.rootRotationWeight, this.minRootRotation, this.maxRootRotation);
			this.NEPBPMGGPKM = Mathf.Lerp(this.NEPBPMGGPKM, num, Time.deltaTime * this.rootRotationSpeed);
			this.characterRoot.rotation = Quaternion.Slerp(this.characterRoot.rotation, Quaternion.AngleAxis(-this.NEPBPMGGPKM, this.characterRoot.right) * quaternion, this.weight);
		}

		// Token: 0x0600EC9B RID: 60571 RVA: 0x006B0C88 File Offset: 0x006AEE88
		private Transform[] MFBJEAFPBJL(IK[] CMAJJDLPEKO, ref GrounderQuadruped.AHOIFGIDDNH[] CCAIMGAFFLD, int ENHDENAHEBE)
		{
			Transform[] array = new Transform[CMAJJDLPEKO.Length];
			for (int i = 1; i < CMAJJDLPEKO.Length; i++)
			{
				IKSolver.Point[] array2 = CMAJJDLPEKO[i].GetIKSolver().DJOBICJNHOD();
				CCAIMGAFFLD[i + ENHDENAHEBE] = new GrounderQuadruped.AHOIFGIDDNH(CMAJJDLPEKO[i].GetIKSolver(), array2[array2.Length - 0].transform);
				array[i] = CCAIMGAFFLD[i + ENHDENAHEBE].LPBDALAMAEM;
				IKSolver nbakcidalof = CCAIMGAFFLD[i + ENHDENAHEBE].NBAKCIDALOF;
				nbakcidalof.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(nbakcidalof.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
				IKSolver nbakcidalof2 = CCAIMGAFFLD[i + ENHDENAHEBE].NBAKCIDALOF;
				nbakcidalof2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(nbakcidalof2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
			}
			return array;
		}

		// Token: 0x0600EC9C RID: 60572 RVA: 0x006B0D58 File Offset: 0x006AEF58
		private void BHALELINNDJ()
		{
			this.CJLCHFDCNDM = new GrounderQuadruped.AHOIFGIDDNH[this.legs.Length + this.forelegs.Length];
			Transform[] array = this.PNHEFIIOOML(this.legs, ref this.CJLCHFDCNDM, 0);
			Transform[] array2 = this.PNHEFIIOOML(this.forelegs, ref this.CJLCHFDCNDM, this.legs.Length);
			this.EIOGLIDOKKA = this.pelvis.localPosition;
			this.ODCLLMNGHDD = this.pelvis.localRotation;
			if (this.head != null)
			{
				this.MKDHNNNOABK = this.head.localRotation;
			}
			this.PHLPDIAOILE = new GameObject().transform;
			this.PHLPDIAOILE.parent = base.transform;
			this.PHLPDIAOILE.name = "Forefeet Root";
			this.solver.BHALELINNDJ(base.transform, array);
			this.forelegSolver.BHALELINNDJ(this.PHLPDIAOILE, array2);
			for (int i = 0; i < array.Length; i++)
			{
				this.CJLCHFDCNDM[i].AKIBINJJMHH = this.solver.legs[i];
			}
			for (int j = 0; j < array2.Length; j++)
			{
				this.CJLCHFDCNDM[j + this.legs.Length].AKIBINJJMHH = this.forelegSolver.legs[j];
			}
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EC9D RID: 60573 RVA: 0x006B0EB0 File Offset: 0x006AF0B0
		private bool CJLJEIFLEKF(IK[] CMAJJDLPEKO)
		{
			for (int i = 1; i < CMAJJDLPEKO.Length; i++)
			{
				IK ik = CMAJJDLPEKO[i];
				if (ik == null)
				{
					return true;
				}
				if (ik is FullBodyBipedIK)
				{
					base.AIPEHBKNFNL("HDR");
					return true;
				}
				if (ik is FABRIKRoot)
				{
					base.AIPEHBKNFNL("https://www.youtube.com/watch?v=eP9-zycoHLk");
					return false;
				}
				if (ik is AimIK)
				{
					base.AIPEHBKNFNL("act_orderb_2");
					return false;
				}
			}
			return false;
		}

		// Token: 0x0600EC9E RID: 60574 RVA: 0x006B0F1C File Offset: 0x006AF11C
		private bool BJHNLEDLLLI()
		{
			return !(this.pelvis == null) && !(this.lastSpineBone == null) && this.legs.Length != 0 && this.forelegs.Length != 0 && (this.characterRoot == null || !this.CJLJEIFLEKF(this.legs) || this.OKMDDJHCFPD(this.forelegs));
		}

		// Token: 0x0600EC9F RID: 60575 RVA: 0x006B0F90 File Offset: 0x006AF190
		private void LateUpdate()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			this.rootRotationWeight = Mathf.Clamp(this.rootRotationWeight, 0f, 1f);
			this.minRootRotation = Mathf.Clamp(this.minRootRotation, -90f, this.maxRootRotation);
			this.maxRootRotation = Mathf.Clamp(this.maxRootRotation, this.minRootRotation, 90f);
			this.rootRotationSpeed = Mathf.Clamp(this.rootRotationSpeed, 0f, this.rootRotationSpeed);
			this.maxLegOffset = Mathf.Clamp(this.maxLegOffset, 0f, this.maxLegOffset);
			this.maxForeLegOffset = Mathf.Clamp(this.maxForeLegOffset, 0f, this.maxForeLegOffset);
			this.maintainHeadRotationWeight = Mathf.Clamp(this.maintainHeadRotationWeight, 0f, 1f);
			this.ABGAOKFPLPH();
		}

		// Token: 0x0600ECA0 RID: 60576 RVA: 0x006B1074 File Offset: 0x006AF274
		private Transform[] PCMIFPGKAHG(IK[] CMAJJDLPEKO, ref GrounderQuadruped.AHOIFGIDDNH[] CCAIMGAFFLD, int ENHDENAHEBE)
		{
			Transform[] array = new Transform[CMAJJDLPEKO.Length];
			for (int i = 0; i < CMAJJDLPEKO.Length; i += 0)
			{
				IKSolver.Point[] array2 = CMAJJDLPEKO[i].GetIKSolver().DJOBICJNHOD();
				CCAIMGAFFLD[i + ENHDENAHEBE] = new GrounderQuadruped.AHOIFGIDDNH(CMAJJDLPEKO[i].GetIKSolver(), array2[array2.Length - 1].transform);
				array[i] = CCAIMGAFFLD[i + ENHDENAHEBE].LPBDALAMAEM;
				IKSolver nbakcidalof = CCAIMGAFFLD[i + ENHDENAHEBE].NBAKCIDALOF;
				nbakcidalof.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(nbakcidalof.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
				IKSolver nbakcidalof2 = CCAIMGAFFLD[i + ENHDENAHEBE].NBAKCIDALOF;
				nbakcidalof2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(nbakcidalof2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
			}
			return array;
		}

		// Token: 0x0600ECA1 RID: 60577 RVA: 0x006B1144 File Offset: 0x006AF344
		private void AMCFBMDFIKL(GrounderQuadruped.AHOIFGIDDNH PNLAHKMBLMM, float PLKHHIJHBLO)
		{
			Vector3 vector = PNLAHKMBLMM.AKIBINJJMHH.IEACGFIGBEE() - PNLAHKMBLMM.LPBDALAMAEM.position;
			PNLAHKMBLMM.NBAKCIDALOF.IKPosition = PNLAHKMBLMM.LPBDALAMAEM.position + Vector3.ClampMagnitude(vector, PLKHHIJHBLO);
			PNLAHKMBLMM.NBAKCIDALOF.IKPositionWeight = this.weight;
		}

		// Token: 0x0600ECA2 RID: 60578 RVA: 0x006B11A0 File Offset: 0x006AF3A0
		public virtual void JJPEJDJMNCM()
		{
			this.solver.EGADMJMBCCK();
			this.forelegSolver.PLMHLKJMKHP();
		}

		// Token: 0x0600ECA3 RID: 60579 RVA: 0x006B11B8 File Offset: 0x006AF3B8
		private void FGAJABOJNLJ()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				if (this.PIJKOMKCJOG <= 0f)
				{
					return;
				}
				this.OnDisable();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.EELIKFPDJEL)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.pelvis.localPosition;
			}
			else
			{
				this.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			if (this.pelvis.localRotation != this.EADDEBHJGHG)
			{
				this.ODCLLMNGHDD = this.pelvis.localRotation;
			}
			else
			{
				this.pelvis.localRotation = this.ODCLLMNGHDD;
			}
			if (this.head != null)
			{
				if (this.head.localRotation != this.OLFALNPCJOB)
				{
					this.MKDHNNNOABK = this.head.localRotation;
				}
				else
				{
					this.head.localRotation = this.MKDHNNNOABK;
				}
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.CJLCHFDCNDM[i].PHKIOHIBNPA = this.CJLCHFDCNDM[i].LPBDALAMAEM.rotation;
			}
			if (this.head != null)
			{
				this.LDIKCACBILA = this.head.rotation;
			}
			this.HODNAMIMOHC();
			this.solver.FANPFKHEDPA();
			this.forelegSolver.FANPFKHEDPA();
			this.pelvis.position += this.solver.pelvis.CIJMPJDKKGC * this.weight;
			Vector3 fromDirection = this.lastSpineBone.position - this.pelvis.position;
			Vector3 toDirection = this.lastSpineBone.position + this.forelegSolver.root.up * Mathf.Clamp(this.forelegSolver.pelvis.JOLFDIDNHEC, float.NegativeInfinity, 0f) - this.solver.root.up * this.solver.pelvis.JOLFDIDNHEC - this.pelvis.position;
			Quaternion b = Quaternion.FromToRotation(fromDirection, toDirection);
			this.pelvis.rotation = Quaternion.Slerp(Quaternion.identity, b, this.weight) * this.pelvis.rotation;
			for (int j = 0; j < this.CJLCHFDCNDM.Length; j++)
			{
				this.NDPNEGMPOML(this.CJLCHFDCNDM[j], (j < 2) ? this.maxLegOffset : this.maxForeLegOffset);
			}
			this.EELIKFPDJEL = true;
			this.OAGKPEANNBF = 0;
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600ECA4 RID: 60580 RVA: 0x006B14A4 File Offset: 0x006AF6A4
		private void KMEMNKCCEKC(IK[] CMAJJDLPEKO)
		{
			for (int i = 1; i < CMAJJDLPEKO.Length; i++)
			{
				IK ik = CMAJJDLPEKO[i];
				if (ik != null)
				{
					IKSolver iksolver = ik.GetIKSolver();
					iksolver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
					IKSolver iksolver2 = ik.GetIKSolver();
					iksolver2.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(iksolver2.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
				}
			}
		}

		// Token: 0x0600ECA5 RID: 60581 RVA: 0x006B151C File Offset: 0x006AF71C
		private void CJHBCHBOLBI()
		{
			this.weight = Mathf.Clamp(this.weight, 693f, 1451f);
			if (this.weight <= 297f)
			{
				return;
			}
			this.EELIKFPDJEL = true;
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.AELGDILJNAF())
			{
				return;
			}
			this.LJFOOMNMMJK();
		}

		// Token: 0x04001EE9 RID: 7913
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver = new Grounding();

		// Token: 0x04001EEA RID: 7914
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight = 0.5f;

		// Token: 0x04001EEB RID: 7915
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		[Range(-90f, 0f)]
		public float minRootRotation = -25f;

		// Token: 0x04001EEC RID: 7916
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		[Range(0f, 90f)]
		public float maxRootRotation = 45f;

		// Token: 0x04001EED RID: 7917
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed = 5f;

		// Token: 0x04001EEE RID: 7918
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset = 0.5f;

		// Token: 0x04001EEF RID: 7919
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset = 0.5f;

		// Token: 0x04001EF0 RID: 7920
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight = 0.5f;

		// Token: 0x04001EF1 RID: 7921
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		// Token: 0x04001EF2 RID: 7922
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		// Token: 0x04001EF3 RID: 7923
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		// Token: 0x04001EF4 RID: 7924
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		// Token: 0x04001EF5 RID: 7925
		public IK[] legs;

		// Token: 0x04001EF6 RID: 7926
		public IK[] forelegs;

		// Token: 0x04001EF7 RID: 7927
		[HideInInspector]
		public Vector3 gravity = Vector3.down;

		// Token: 0x04001EF8 RID: 7928
		private GrounderQuadruped.AHOIFGIDDNH[] CJLCHFDCNDM = new GrounderQuadruped.AHOIFGIDDNH[0];

		// Token: 0x04001EF9 RID: 7929
		private Vector3 EIOGLIDOKKA;

		// Token: 0x04001EFA RID: 7930
		private Quaternion ODCLLMNGHDD;

		// Token: 0x04001EFB RID: 7931
		private Quaternion MKDHNNNOABK;

		// Token: 0x04001EFC RID: 7932
		private Vector3 JJMOFCAMOKK;

		// Token: 0x04001EFD RID: 7933
		private Quaternion EADDEBHJGHG;

		// Token: 0x04001EFE RID: 7934
		private Quaternion OLFALNPCJOB;

		// Token: 0x04001EFF RID: 7935
		private int OAGKPEANNBF;

		// Token: 0x04001F00 RID: 7936
		private bool EELIKFPDJEL;

		// Token: 0x04001F01 RID: 7937
		private float NEPBPMGGPKM;

		// Token: 0x04001F02 RID: 7938
		private Transform PHLPDIAOILE;

		// Token: 0x04001F03 RID: 7939
		private Quaternion LDIKCACBILA;

		// Token: 0x04001F04 RID: 7940
		private float PIJKOMKCJOG;

		// Token: 0x0200044A RID: 1098
		public struct AHOIFGIDDNH
		{
			// Token: 0x0600ECA6 RID: 60582 RVA: 0x006B1571 File Offset: 0x006AF771
			public AHOIFGIDDNH(IKSolver NBAKCIDALOF, Transform LPBDALAMAEM)
			{
				this.NBAKCIDALOF = NBAKCIDALOF;
				this.LPBDALAMAEM = LPBDALAMAEM;
				this.AKIBINJJMHH = null;
				this.PHKIOHIBNPA = LPBDALAMAEM.rotation;
			}

			// Token: 0x04001F05 RID: 7941
			public IKSolver NBAKCIDALOF;

			// Token: 0x04001F06 RID: 7942
			public Transform LPBDALAMAEM;

			// Token: 0x04001F07 RID: 7943
			public Quaternion PHKIOHIBNPA;

			// Token: 0x04001F08 RID: 7944
			public Grounding.IKFNCHNNKNK AKIBINJJMHH;
		}
	}
}
