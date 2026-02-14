using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000446 RID: 1094
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	public class GrounderFBBIK : Grounder
	{
		// Token: 0x0600EB86 RID: 60294 RVA: 0x006A86C4 File Offset: 0x006A68C4
		public virtual void DPCPLFGDPEH()
		{
			this.solver.Reset();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB87 RID: 60295 RVA: 0x006A86DC File Offset: 0x006A68DC
		private void PCLFLGAODPO()
		{
			if (this.ik == null)
			{
				this.ik = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInParent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		// Token: 0x0600EB88 RID: 60296 RVA: 0x006A8737 File Offset: 0x006A6937
		private void FJJDBAIJDIM()
		{
			this.IJJMEFAMPNM = false;
		}

		// Token: 0x0600EB89 RID: 60297 RVA: 0x006A8740 File Offset: 0x006A6940
		private bool ENICBAONHDE()
		{
			return !(this.ik == null) && (this.ik.solver.initiated || true);
		}

		// Token: 0x0600EB8A RID: 60298 RVA: 0x006A8768 File Offset: 0x006A6968
		private void NBENFONBILP()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGJCCAKNIIA));
			}
		}

		// Token: 0x0600EB8B RID: 60299 RVA: 0x006A87B8 File Offset: 0x006A69B8
		private void LLPMNHOBPAJ()
		{
			this.ik.solver.leftLegMapping.maintainRotationWeight = 1324f;
			this.ik.solver.rightLegMapping.maintainRotationWeight = 1735f;
			this.CJLCHFDCNDM = new Transform[5];
			this.CJLCHFDCNDM[0] = this.ik.solver.IAGDDAJGGGE().bone;
			this.CJLCHFDCNDM[1] = this.ik.solver.rightFootEffector.bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
			this.solver.MLDCEKHOLLI(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EB8C RID: 60300 RVA: 0x006A8894 File Offset: 0x006A6A94
		private void OnDrawGizmosSelected()
		{
			if (this.ik == null)
			{
				this.ik = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInParent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		// Token: 0x0600EB8D RID: 60301 RVA: 0x006A88F0 File Offset: 0x006A6AF0
		private void NMBDJDNEFFM()
		{
			this.ik.solver.leftLegMapping.maintainRotationWeight = 786f;
			this.ik.solver.OJHGEFAGPOH().maintainRotationWeight = 1693f;
			this.CJLCHFDCNDM = new Transform[8];
			this.CJLCHFDCNDM[1] = this.ik.solver.IAGDDAJGGGE().bone;
			this.CJLCHFDCNDM[1] = this.ik.solver.ANFNMIKKLOM().bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.IBDFLHHGELP));
			this.solver.CAAINGFBNHG(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EB8E RID: 60302 RVA: 0x006A89CC File Offset: 0x006A6BCC
		private void NKECALBCKBA()
		{
			this.ik.solver.DJAJGGAOAMO().maintainRotationWeight = 1329f;
			this.ik.solver.rightLegMapping.maintainRotationWeight = 192f;
			this.CJLCHFDCNDM = new Transform[5];
			this.CJLCHFDCNDM[1] = this.ik.solver.IAGDDAJGGGE().bone;
			this.CJLCHFDCNDM[1] = this.ik.solver.ANFNMIKKLOM().bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.BEFLBHOCJKC));
			this.solver.DLNCBJIIBAL(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EB8F RID: 60303 RVA: 0x006A8AA8 File Offset: 0x006A6CA8
		private void FGJCCAKNIIA()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = false;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 976f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.JLFBDOPFDDJ();
			this.ik.references.pelvis.position += this.solver.DLIDADHGILM().DCPJAAHBKMB() * this.weight;
			this.KALHCAGEPBB(this.ik.solver.IAGDDAJGGGE(), this.solver.MMPFHLEJIOI()[1]);
			this.PDDALPHGOKK(this.ik.solver.JFOHJFFFPGJ(), this.solver.MMPFHLEJIOI()[1]);
			if (this.spineBend != 696f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 1984f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 1; i < this.spine.Length; i++)
				{
					this.ik.solver.OEEPHOCHILL(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB90 RID: 60304 RVA: 0x006A8C8B File Offset: 0x006A6E8B
		protected virtual void CEJFNEJIKDN()
		{
			Application.OpenURL("_RcpAspect");
		}

		// Token: 0x0600EB91 RID: 60305 RVA: 0x006A8C97 File Offset: 0x006A6E97
		private void BCAJMNABENM()
		{
			Application.OpenURL("Joint_");
		}

		// Token: 0x0600EB92 RID: 60306 RVA: 0x006A86C4 File Offset: 0x006A68C4
		public virtual void MLHELGGCENL()
		{
			this.solver.Reset();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB93 RID: 60307 RVA: 0x006A8CA3 File Offset: 0x006A6EA3
		protected virtual void CBNMHIMNCJM()
		{
			Application.OpenURL("WRINKLE_MAPS");
		}

		// Token: 0x0600EB94 RID: 60308 RVA: 0x006A8CB0 File Offset: 0x006A6EB0
		private void OLBNLLBBGLI()
		{
			if (this.ik == null)
			{
				this.ik = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInParent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		// Token: 0x0600EB95 RID: 60309 RVA: 0x006A8D0C File Offset: 0x006A6F0C
		private void FJEEADNCKAG()
		{
			this.IJJMEFAMPNM = true;
			this.weight = Mathf.Clamp(this.weight, 553f, 1912f);
			if (this.weight <= 1553f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.CHEFFEHAHJM())
			{
				return;
			}
			this.MBBFJMFDCEA();
		}

		// Token: 0x0600EB96 RID: 60310 RVA: 0x006A8D64 File Offset: 0x006A6F64
		private void ECPECFPNLKP()
		{
			this.IJJMEFAMPNM = true;
			this.weight = Mathf.Clamp(this.weight, 647f, 404f);
			if (this.weight <= 1452f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.JEFMKEFGKIO())
			{
				return;
			}
			this.NMBDJDNEFFM();
		}

		// Token: 0x0600EB97 RID: 60311 RVA: 0x006A8DB9 File Offset: 0x006A6FB9
		private bool JEFMKEFGKIO()
		{
			return !(this.ik == null) && !this.ik.solver.initiated;
		}

		// Token: 0x0600EB98 RID: 60312 RVA: 0x006A8737 File Offset: 0x006A6937
		private void AEOPIOEJMKO()
		{
			this.IJJMEFAMPNM = false;
		}

		// Token: 0x0600EB99 RID: 60313 RVA: 0x006A8DE0 File Offset: 0x006A6FE0
		private void LGCKHPFEGNM()
		{
			if (this.ik == null)
			{
				this.ik = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInParent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		// Token: 0x0600EB9A RID: 60314 RVA: 0x006A8E3C File Offset: 0x006A703C
		private void KBOOODIBLAN()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = false;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 359f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.FANPFKHEDPA();
			this.ik.references.pelvis.position += this.solver.pelvis.BCCMNDJMEPG() * this.weight;
			this.FKJJNLDMMEB(this.ik.solver.leftFootEffector, this.solver.LFDJHHNIIMK()[1]);
			this.CIAEDBLBPNL(this.ik.solver.JFOHJFFFPGJ(), this.solver.legs[1]);
			if (this.spineBend != 1385f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 774f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 0; i < this.spine.Length; i++)
				{
					this.ik.solver.DAMGOIIBHCN(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB9B RID: 60315 RVA: 0x006A9020 File Offset: 0x006A7220
		private void DPGECEOMHNM()
		{
			this.IJJMEFAMPNM = false;
			this.weight = Mathf.Clamp(this.weight, 834f, 1305f);
			if (this.weight <= 1212f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.NLNKCGDMEPI())
			{
				return;
			}
			this.CIPOOAEKLCF();
		}

		// Token: 0x0600EB9C RID: 60316 RVA: 0x006A9075 File Offset: 0x006A7275
		public virtual void JDHFLEFJFON()
		{
			this.solver.EPLEHFCNKDJ();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB9D RID: 60317 RVA: 0x006A908D File Offset: 0x006A728D
		private void JJMGNAMFJGJ()
		{
			this.IJJMEFAMPNM = true;
		}

		// Token: 0x0600EB9E RID: 60318 RVA: 0x006A9098 File Offset: 0x006A7298
		private void KALHCAGEPBB(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.AGKMPPLKBDJ() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.HNPADDHKIAM(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EB9F RID: 60319 RVA: 0x006A908D File Offset: 0x006A728D
		private void LateUpdate()
		{
			this.IJJMEFAMPNM = true;
		}

		// Token: 0x0600EBA0 RID: 60320 RVA: 0x006A908D File Offset: 0x006A728D
		private void MNMGBKMJNEG()
		{
			this.IJJMEFAMPNM = true;
		}

		// Token: 0x0600EBA1 RID: 60321 RVA: 0x006A9075 File Offset: 0x006A7275
		public virtual void BFBEOPFOAEN()
		{
			this.solver.EPLEHFCNKDJ();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EBA2 RID: 60322 RVA: 0x006A9108 File Offset: 0x006A7308
		protected virtual void NDDBDOBAKAG()
		{
			Application.OpenURL("_Jitter");
		}

		// Token: 0x0600EBA3 RID: 60323 RVA: 0x006A9114 File Offset: 0x006A7314
		private void IGEICBNMPAD()
		{
			this.IJJMEFAMPNM = true;
			this.weight = Mathf.Clamp(this.weight, 287f, 320f);
			if (this.weight <= 196f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.AELGDILJNAF())
			{
				return;
			}
			this.CIPOOAEKLCF();
		}

		// Token: 0x0600EBA4 RID: 60324 RVA: 0x006A916C File Offset: 0x006A736C
		private void PDDALPHGOKK(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.CGAMODJNLAC - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.JNHPAAAFGKC, this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBA5 RID: 60325 RVA: 0x006A91DC File Offset: 0x006A73DC
		private void GDFCLMDGGNJ()
		{
			if (this.ik == null)
			{
				this.ik = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInParent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		// Token: 0x0600EBA6 RID: 60326 RVA: 0x006A9238 File Offset: 0x006A7438
		private void BEMAKGADCIJ()
		{
			this.ik.solver.DJAJGGAOAMO().maintainRotationWeight = 180f;
			this.ik.solver.OJHGEFAGPOH().maintainRotationWeight = 1699f;
			this.CJLCHFDCNDM = new Transform[6];
			this.CJLCHFDCNDM[1] = this.ik.solver.JHKNHMMGKCG().bone;
			this.CJLCHFDCNDM[1] = this.ik.solver.ANGCEEAGHCB().bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
			this.solver.ENLPEHMBNJC(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EBA7 RID: 60327 RVA: 0x006A9313 File Offset: 0x006A7513
		protected virtual void KMOEOAGCNPP()
		{
			Application.OpenURL("WorkerHammer");
		}

		// Token: 0x0600EBA8 RID: 60328 RVA: 0x006A9320 File Offset: 0x006A7520
		private void ADJKGBACCMC(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.AGKMPPLKBDJ() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.PGOCIAGCACN(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBA9 RID: 60329 RVA: 0x006A9390 File Offset: 0x006A7590
		private void MBBFJMFDCEA()
		{
			this.ik.solver.DJAJGGAOAMO().maintainRotationWeight = 1923f;
			this.ik.solver.rightLegMapping.maintainRotationWeight = 178f;
			this.CJLCHFDCNDM = new Transform[1];
			this.CJLCHFDCNDM[0] = this.ik.solver.JHKNHMMGKCG().bone;
			this.CJLCHFDCNDM[0] = this.ik.solver.ANFNMIKKLOM().bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.MLFHKJODJGO));
			this.solver.DLNCBJIIBAL(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EBAA RID: 60330 RVA: 0x006A946B File Offset: 0x006A766B
		public virtual void FOBOOBNEABF()
		{
			this.solver.EGADMJMBCCK();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EBAB RID: 60331 RVA: 0x006A9484 File Offset: 0x006A7684
		private void Update()
		{
			this.IJJMEFAMPNM = true;
			this.weight = Mathf.Clamp(this.weight, 0f, 1f);
			if (this.weight <= 0f)
			{
				return;
			}
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

		// Token: 0x0600EBAC RID: 60332 RVA: 0x006A94D9 File Offset: 0x006A76D9
		private bool NLNKCGDMEPI()
		{
			return this.ik == null || !this.ik.solver.initiated;
		}

		// Token: 0x0600EBAD RID: 60333 RVA: 0x006A8740 File Offset: 0x006A6940
		private bool GBENCOAIEHF()
		{
			return !(this.ik == null) && (this.ik.solver.initiated || true);
		}

		// Token: 0x0600EBAE RID: 60334 RVA: 0x006A9500 File Offset: 0x006A7700
		private void CJFGPPKLBMH()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.BEFLBHOCJKC));
			}
		}

		// Token: 0x0600EBAF RID: 60335 RVA: 0x006A954F File Offset: 0x006A774F
		private void LAMGJCKEPFC()
		{
			Application.OpenURL("RollerBladeGrindRoyale");
		}

		// Token: 0x0600EBB0 RID: 60336 RVA: 0x006A955C File Offset: 0x006A775C
		private void DAADPPPNFKM(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.AGKMPPLKBDJ() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.BHPMHHGJHME(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBB1 RID: 60337 RVA: 0x006A95CC File Offset: 0x006A77CC
		private void MDLALJJCINP(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.BKEKFBNJBDN() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.PGOCIAGCACN(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBB2 RID: 60338 RVA: 0x006A963C File Offset: 0x006A783C
		protected virtual void FCIMKNKIDBA()
		{
			Application.OpenURL("<color='#80ff60'>");
		}

		// Token: 0x0600EBB3 RID: 60339 RVA: 0x006A8737 File Offset: 0x006A6937
		private void MBLOIDAAJHH()
		{
			this.IJJMEFAMPNM = false;
		}

		// Token: 0x0600EBB4 RID: 60340 RVA: 0x006A9648 File Offset: 0x006A7848
		private void OLMJNMAEAEH()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = false;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1439f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.EMHGNEMIGII();
			this.ik.references.pelvis.position += this.solver.JKCAIBBPEHP().DCPJAAHBKMB() * this.weight;
			this.CIAEDBLBPNL(this.ik.solver.leftFootEffector, this.solver.BGCPOHLJIDN()[0]);
			this.FKJJNLDMMEB(this.ik.solver.ANFNMIKKLOM(), this.solver.BJLLBFABCBL()[0]);
			if (this.spineBend != 19f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 907f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 1; i < this.spine.Length; i += 0)
				{
					this.ik.solver.LOOAPOLICLC(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EBB5 RID: 60341 RVA: 0x006A982C File Offset: 0x006A7A2C
		private void AMGIJEGCAEG()
		{
			this.ik.solver.leftLegMapping.maintainRotationWeight = 22f;
			this.ik.solver.OJHGEFAGPOH().maintainRotationWeight = 436f;
			this.CJLCHFDCNDM = new Transform[1];
			this.CJLCHFDCNDM[0] = this.ik.solver.leftFootEffector.bone;
			this.CJLCHFDCNDM[1] = this.ik.solver.JFOHJFFFPGJ().bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.MFELAIGACGH));
			this.solver.MLDCEKHOLLI(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EBB6 RID: 60342 RVA: 0x006A9907 File Offset: 0x006A7B07
		protected virtual void HGOPLMHDDNH()
		{
			Application.OpenURL("[F_EXP]");
		}

		// Token: 0x0600EBB7 RID: 60343 RVA: 0x006A86C4 File Offset: 0x006A68C4
		public virtual void FHGMAGLBDPJ()
		{
			this.solver.Reset();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EBB8 RID: 60344 RVA: 0x006A9914 File Offset: 0x006A7B14
		private void DDCEEEIDDIP(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.NDGGJPEHKBC() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.PGOCIAGCACN(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBB9 RID: 60345 RVA: 0x006A9984 File Offset: 0x006A7B84
		private void PEICGDAOCEN()
		{
			if (this.ik == null)
			{
				this.ik = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInParent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		// Token: 0x0600EBBA RID: 60346 RVA: 0x006A99E0 File Offset: 0x006A7BE0
		private void DICDCCJIDOI(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.AGKMPPLKBDJ() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.HNPADDHKIAM(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBBB RID: 60347 RVA: 0x006A8737 File Offset: 0x006A6937
		private void OIIMEOFJIFP()
		{
			this.IJJMEFAMPNM = false;
		}

		// Token: 0x0600EBBC RID: 60348 RVA: 0x006A9A50 File Offset: 0x006A7C50
		private void CLCJEODNIGJ()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.OLMJNMAEAEH));
			}
		}

		// Token: 0x0600EBBD RID: 60349 RVA: 0x006A9AA0 File Offset: 0x006A7CA0
		private void IBDFLHHGELP()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = true;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 564f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.NFPFDOEENLA();
			this.ik.references.pelvis.position += this.solver.DLIDADHGILM().DFFHLACPDNO() * this.weight;
			this.PDDALPHGOKK(this.ik.solver.JHKNHMMGKCG(), this.solver.BGCPOHLJIDN()[1]);
			this.DICDCCJIDOI(this.ik.solver.JIHGEPGJDEC(), this.solver.MMPFHLEJIOI()[1]);
			if (this.spineBend != 896f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 14f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 1; i < this.spine.Length; i += 0)
				{
					this.ik.solver.DAMGOIIBHCN(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EBBE RID: 60350 RVA: 0x006A9C84 File Offset: 0x006A7E84
		private void HHKHPJLGPBB()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = false;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 327f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.HMGBHPPNEMP();
			this.ik.references.pelvis.position += this.solver.DLIDADHGILM().BCCMNDJMEPG() * this.weight;
			this.EKPIEJEBBBL(this.ik.solver.leftFootEffector, this.solver.legs[0]);
			this.PNIKNHHFLJC(this.ik.solver.ANFNMIKKLOM(), this.solver.BGCPOHLJIDN()[1]);
			if (this.spineBend != 1854f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 1272f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 1; i < this.spine.Length; i++)
				{
					this.ik.solver.EEKAOKNJLKH(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EBBF RID: 60351 RVA: 0x006A9E68 File Offset: 0x006A8068
		private void JAOCMCMBJCM()
		{
			this.ik.solver.leftLegMapping.maintainRotationWeight = 1836f;
			this.ik.solver.rightLegMapping.maintainRotationWeight = 784f;
			this.CJLCHFDCNDM = new Transform[1];
			this.CJLCHFDCNDM[0] = this.ik.solver.JHKNHMMGKCG().bone;
			this.CJLCHFDCNDM[0] = this.ik.solver.ANGCEEAGHCB().bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.KBOOODIBLAN));
			this.solver.CAAINGFBNHG(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EBC0 RID: 60352 RVA: 0x006A9F43 File Offset: 0x006A8143
		private bool AELGDILJNAF()
		{
			return !(this.ik == null) && this.ik.solver.initiated;
		}

		// Token: 0x0600EBC1 RID: 60353 RVA: 0x006A9F6C File Offset: 0x006A816C
		private void FKJJNLDMMEB(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.NDGGJPEHKBC() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.HNPADDHKIAM(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBC2 RID: 60354 RVA: 0x006A9FDC File Offset: 0x006A81DC
		private void FMCNLLIBIAC()
		{
			if (this.ik == null)
			{
				this.ik = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInParent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		// Token: 0x0600EBC3 RID: 60355 RVA: 0x006AA038 File Offset: 0x006A8238
		private void JAIKDCHGKGH()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = true;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1554f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.FANPFKHEDPA();
			this.ik.references.pelvis.position += this.solver.JKCAIBBPEHP().NLAAJNKCEIF() * this.weight;
			this.PNIKNHHFLJC(this.ik.solver.JHKNHMMGKCG(), this.solver.BJLLBFABCBL()[1]);
			this.PDDALPHGOKK(this.ik.solver.rightFootEffector, this.solver.BGCPOHLJIDN()[1]);
			if (this.spineBend != 1517f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 876f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 1; i < this.spine.Length; i += 0)
				{
					this.ik.solver.EEKAOKNJLKH(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EBC4 RID: 60356 RVA: 0x006AA21C File Offset: 0x006A841C
		private void IOPIPGONEMI(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.IEACGFIGBEE() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.PKMFKFAFKCK(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBC5 RID: 60357 RVA: 0x006A8737 File Offset: 0x006A6937
		private void DOCCKNGPJGO()
		{
			this.IJJMEFAMPNM = false;
		}

		// Token: 0x0600EBC6 RID: 60358 RVA: 0x006A86C4 File Offset: 0x006A68C4
		public override void ResetPosition()
		{
			this.solver.Reset();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EBC7 RID: 60359 RVA: 0x006A908D File Offset: 0x006A728D
		private void FixedUpdate()
		{
			this.IJJMEFAMPNM = true;
		}

		// Token: 0x0600EBC8 RID: 60360 RVA: 0x006A9F43 File Offset: 0x006A8143
		private bool HDLIKPOMIOI()
		{
			return !(this.ik == null) && this.ik.solver.initiated;
		}

		// Token: 0x0600EBC9 RID: 60361 RVA: 0x006AA28C File Offset: 0x006A848C
		protected virtual void CBGOGFBGFMI()
		{
			Application.OpenURL("wpn_onlyw");
		}

		// Token: 0x0600EBCA RID: 60362 RVA: 0x006AA298 File Offset: 0x006A8498
		private void CIAEDBLBPNL(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.IEACGFIGBEE() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.CJFGACCPDEH(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBCB RID: 60363 RVA: 0x006AA308 File Offset: 0x006A8508
		private void GALINFCJCLO(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.NDGGJPEHKBC() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.BHPMHHGJHME(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBCC RID: 60364 RVA: 0x006AA378 File Offset: 0x006A8578
		protected override void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_f_b_b_i_k.html");
		}

		// Token: 0x0600EBCD RID: 60365 RVA: 0x006AA384 File Offset: 0x006A8584
		private void HHNFPGKAAMF()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.OLMJNMAEAEH));
			}
		}

		// Token: 0x0600EBCE RID: 60366 RVA: 0x006AA3D3 File Offset: 0x006A85D3
		protected virtual void PHFCOOCEPIM()
		{
			Application.OpenURL("usr_inf_a1");
		}

		// Token: 0x0600EBCF RID: 60367 RVA: 0x006AA3E0 File Offset: 0x006A85E0
		private void DKNPMEFBGAK(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.IEACGFIGBEE() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.JNHPAAAFGKC, this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBD0 RID: 60368 RVA: 0x006AA450 File Offset: 0x006A8650
		protected virtual void OCJBHALPDON()
		{
			Application.OpenURL("FaceHit");
		}

		// Token: 0x0600EBD1 RID: 60369 RVA: 0x006AA45C File Offset: 0x006A865C
		protected virtual void PHPHECAIDIH()
		{
			Application.OpenURL("Text node is empy!");
		}

		// Token: 0x0600EBD2 RID: 60370 RVA: 0x006AA468 File Offset: 0x006A8668
		private void PNIKNHHFLJC(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.NHIOCAIOLFD() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.PMMFCIFLLMD(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBD3 RID: 60371 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void CCDICLIELPJ()
		{
			Application.OpenURL("");
		}

		// Token: 0x0600EBD4 RID: 60372 RVA: 0x006A8740 File Offset: 0x006A6940
		private bool EDNALGDKEPL()
		{
			return !(this.ik == null) && (this.ik.solver.initiated || true);
		}

		// Token: 0x0600EBD6 RID: 60374 RVA: 0x006A94D9 File Offset: 0x006A76D9
		private bool ALOBPJENHLE()
		{
			return this.ik == null || !this.ik.solver.initiated;
		}

		// Token: 0x0600EBD7 RID: 60375 RVA: 0x006AA510 File Offset: 0x006A8710
		private void CIPOOAEKLCF()
		{
			this.ik.solver.DJAJGGAOAMO().maintainRotationWeight = 656f;
			this.ik.solver.rightLegMapping.maintainRotationWeight = 186f;
			this.CJLCHFDCNDM = new Transform[3];
			this.CJLCHFDCNDM[0] = this.ik.solver.JHKNHMMGKCG().bone;
			this.CJLCHFDCNDM[1] = this.ik.solver.JIHGEPGJDEC().bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.OGJNLKMJBNA));
			this.solver.ENLPEHMBNJC(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EBD8 RID: 60376 RVA: 0x006AA5EB File Offset: 0x006A87EB
		private void BCDMJFNAJLD()
		{
			Application.OpenURL("isLocalServer");
		}

		// Token: 0x0600EBD9 RID: 60377 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void GHMLKHGCKMK()
		{
			Application.OpenURL("");
		}

		// Token: 0x0600EBDA RID: 60378 RVA: 0x006AA5F8 File Offset: 0x006A87F8
		private void FPLNDDMFFKG()
		{
			this.IJJMEFAMPNM = false;
			this.weight = Mathf.Clamp(this.weight, 492f, 1231f);
			if (this.weight <= 1154f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.BDMLEOCCJLL())
			{
				return;
			}
			this.BOHLLJEAHAE();
		}

		// Token: 0x0600EBDB RID: 60379 RVA: 0x006AA650 File Offset: 0x006A8850
		private void JGOIIKJIDNH()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
			}
		}

		// Token: 0x0600EBDC RID: 60380 RVA: 0x006AA69F File Offset: 0x006A889F
		protected virtual void NEMAPKKAPOF()
		{
			Application.OpenURL("error");
		}

		// Token: 0x0600EBDD RID: 60381 RVA: 0x006A908D File Offset: 0x006A728D
		private void PCGMJEBLBLD()
		{
			this.IJJMEFAMPNM = true;
		}

		// Token: 0x0600EBDE RID: 60382 RVA: 0x006AA6AC File Offset: 0x006A88AC
		private void JJHAIFDONLP()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.HHKHPJLGPBB));
			}
		}

		// Token: 0x0600EBDF RID: 60383 RVA: 0x006AA6FC File Offset: 0x006A88FC
		private void BOHLLJEAHAE()
		{
			this.ik.solver.DJAJGGAOAMO().maintainRotationWeight = 942f;
			this.ik.solver.OJHGEFAGPOH().maintainRotationWeight = 1255f;
			this.CJLCHFDCNDM = new Transform[1];
			this.CJLCHFDCNDM[0] = this.ik.solver.leftFootEffector.bone;
			this.CJLCHFDCNDM[0] = this.ik.solver.ANFNMIKKLOM().bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.OGJNLKMJBNA));
			this.solver.DLNCBJIIBAL(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EBE0 RID: 60384 RVA: 0x006AA7D8 File Offset: 0x006A89D8
		private void OnDestroy()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
			}
		}

		// Token: 0x0600EBE1 RID: 60385 RVA: 0x006AA827 File Offset: 0x006A8A27
		private bool CHEFFEHAHJM()
		{
			return !(this.ik == null) && !this.ik.solver.initiated && false;
		}

		// Token: 0x0600EBE2 RID: 60386 RVA: 0x006A946B File Offset: 0x006A766B
		public virtual void LAMLMGCBHKB()
		{
			this.solver.EGADMJMBCCK();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EBE3 RID: 60387 RVA: 0x006AA850 File Offset: 0x006A8A50
		private void GJMJOLCIGKG(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.NHIOCAIOLFD() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.PMMFCIFLLMD(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBE4 RID: 60388 RVA: 0x006A8737 File Offset: 0x006A6937
		private void JGCOLIFLHLP()
		{
			this.IJJMEFAMPNM = false;
		}

		// Token: 0x0600EBE5 RID: 60389 RVA: 0x006AA8C0 File Offset: 0x006A8AC0
		private void GEHJHMEBHHE()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.AHCCFPGFBKI));
			}
		}

		// Token: 0x0600EBE6 RID: 60390 RVA: 0x006AA910 File Offset: 0x006A8B10
		private void KNCAKAJHFJB(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.BKEKFBNJBDN() - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.JNHPAAAFGKC, this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBE7 RID: 60391 RVA: 0x006AA980 File Offset: 0x006A8B80
		private void PAKOHKKBKHD()
		{
			this.IJJMEFAMPNM = true;
			this.weight = Mathf.Clamp(this.weight, 1588f, 1509f);
			if (this.weight <= 52f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.NLNKCGDMEPI())
			{
				return;
			}
			this.NMBDJDNEFFM();
		}

		// Token: 0x0600EBE8 RID: 60392 RVA: 0x006AA9D8 File Offset: 0x006A8BD8
		private void BEFLBHOCJKC()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = true;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 989f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.EMHGNEMIGII();
			this.ik.references.pelvis.position += this.solver.DLIDADHGILM().CIJMPJDKKGC * this.weight;
			this.PNIKNHHFLJC(this.ik.solver.JHKNHMMGKCG(), this.solver.BJLLBFABCBL()[1]);
			this.CIAEDBLBPNL(this.ik.solver.JFOHJFFFPGJ(), this.solver.MMPFHLEJIOI()[1]);
			if (this.spineBend != 1846f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 807f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 0; i < this.spine.Length; i += 0)
				{
					this.ik.solver.LOOAPOLICLC(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EBE9 RID: 60393 RVA: 0x006A8737 File Offset: 0x006A6937
		private void PFLHNDLBELI()
		{
			this.IJJMEFAMPNM = false;
		}

		// Token: 0x0600EBEA RID: 60394 RVA: 0x006AABBC File Offset: 0x006A8DBC
		private void ENLPEHMBNJC()
		{
			this.ik.solver.leftLegMapping.maintainRotationWeight = 1763f;
			this.ik.solver.rightLegMapping.maintainRotationWeight = 6f;
			this.CJLCHFDCNDM = new Transform[7];
			this.CJLCHFDCNDM[1] = this.ik.solver.JHKNHMMGKCG().bone;
			this.CJLCHFDCNDM[1] = this.ik.solver.EAIGBIHMAGB().bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.JAIKDCHGKGH));
			this.solver.JPGOKPACOIC(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EBEB RID: 60395 RVA: 0x006AAC97 File Offset: 0x006A8E97
		protected virtual void EEDAPNHCBBC()
		{
			Application.OpenURL("_FogParams");
		}

		// Token: 0x0600EBEC RID: 60396 RVA: 0x006AACA3 File Offset: 0x006A8EA3
		private void ADIJBIFFOKF()
		{
			Application.OpenURL("Textures/Perks/");
		}

		// Token: 0x0600EBED RID: 60397 RVA: 0x006AACAF File Offset: 0x006A8EAF
		private void HHKNNPENEJE()
		{
			Application.OpenURL("Space reference not set.");
		}

		// Token: 0x0600EBEE RID: 60398 RVA: 0x006A908D File Offset: 0x006A728D
		private void NNNJNKDGLDF()
		{
			this.IJJMEFAMPNM = true;
		}

		// Token: 0x0600EBEF RID: 60399 RVA: 0x006AACBB File Offset: 0x006A8EBB
		public virtual void HICMKIJKGKK()
		{
			this.solver.PLMHLKJMKHP();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EBF0 RID: 60400 RVA: 0x006AACD3 File Offset: 0x006A8ED3
		protected virtual void OHDDEDPECAH()
		{
			Application.OpenURL("Eat");
		}

		// Token: 0x0600EBF1 RID: 60401 RVA: 0x006AACE0 File Offset: 0x006A8EE0
		private void DHEDHOINIAC()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.KBOOODIBLAN));
			}
		}

		// Token: 0x0600EBF2 RID: 60402 RVA: 0x006AAD30 File Offset: 0x006A8F30
		private void DAAHJFNPBIF()
		{
			this.ik.solver.DJAJGGAOAMO().maintainRotationWeight = 82f;
			this.ik.solver.OJHGEFAGPOH().maintainRotationWeight = 83f;
			this.CJLCHFDCNDM = new Transform[3];
			this.CJLCHFDCNDM[1] = this.ik.solver.JHKNHMMGKCG().bone;
			this.CJLCHFDCNDM[1] = this.ik.solver.rightFootEffector.bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.OGJNLKMJBNA));
			this.solver.ENLPEHMBNJC(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EBF3 RID: 60403 RVA: 0x006AAE0C File Offset: 0x006A900C
		private void FGAJABOJNLJ()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = false;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.FANPFKHEDPA();
			this.ik.references.pelvis.position += this.solver.pelvis.CIJMPJDKKGC * this.weight;
			this.PDDALPHGOKK(this.ik.solver.leftFootEffector, this.solver.legs[0]);
			this.PDDALPHGOKK(this.ik.solver.rightFootEffector, this.solver.legs[1]);
			if (this.spineBend != 0f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 0f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 0; i < this.spine.Length; i++)
				{
					this.ik.solver.OEEPHOCHILL(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EBF4 RID: 60404 RVA: 0x006AAFEF File Offset: 0x006A91EF
		public virtual void CMIBCLHCOIP()
		{
			this.solver.MIFKCBJPDDI();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EBF5 RID: 60405 RVA: 0x006AB008 File Offset: 0x006A9208
		private void EKPIEJEBBBL(IKEffector JEFKLIBDHKK, Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			JEFKLIBDHKK.positionOffset += (AKIBINJJMHH.CGAMODJNLAC - JEFKLIBDHKK.bone.position) * this.weight;
			JEFKLIBDHKK.bone.rotation = Quaternion.Slerp(Quaternion.identity, AKIBINJJMHH.PGOCIAGCACN(), this.weight) * JEFKLIBDHKK.bone.rotation;
		}

		// Token: 0x0600EBF6 RID: 60406 RVA: 0x006AB078 File Offset: 0x006A9278
		private void DFFOEGHGPGP()
		{
			this.IJJMEFAMPNM = true;
			this.weight = Mathf.Clamp(this.weight, 692f, 1804f);
			if (this.weight <= 81f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.EDNALGDKEPL())
			{
				return;
			}
			this.DMOINNLLGBO();
		}

		// Token: 0x0600EBF7 RID: 60407 RVA: 0x006AB0D0 File Offset: 0x006A92D0
		private void MFELAIGACGH()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = false;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 818f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.KEBDEJIAODF();
			this.ik.references.pelvis.position += this.solver.pelvis.KPLDCDCLKLC() * this.weight;
			this.CIAEDBLBPNL(this.ik.solver.JHKNHMMGKCG(), this.solver.MMPFHLEJIOI()[0]);
			this.GJMJOLCIGKG(this.ik.solver.rightFootEffector, this.solver.legs[1]);
			if (this.spineBend != 1152f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 1476f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 0; i < this.spine.Length; i += 0)
				{
					this.ik.solver.LOOAPOLICLC(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EBF8 RID: 60408 RVA: 0x006AB2B3 File Offset: 0x006A94B3
		private void ENPJAPNHOKC()
		{
			Application.OpenURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6");
		}

		// Token: 0x0600EBF9 RID: 60409 RVA: 0x006AB2BF File Offset: 0x006A94BF
		protected virtual void GAFCIEJAMOK()
		{
			Application.OpenURL("3");
		}

		// Token: 0x0600EBFA RID: 60410 RVA: 0x006AB2CC File Offset: 0x006A94CC
		private void ECKGFMENAKF()
		{
			if (this.ik == null)
			{
				this.ik = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInParent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		// Token: 0x0600EBFB RID: 60411 RVA: 0x006A8737 File Offset: 0x006A6937
		private void CHEILLPPMIJ()
		{
			this.IJJMEFAMPNM = false;
		}

		// Token: 0x0600EBFC RID: 60412 RVA: 0x006AB328 File Offset: 0x006A9528
		private void DPGENEMNAPC()
		{
			if (this.ik == null)
			{
				this.ik = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInParent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		// Token: 0x0600EBFD RID: 60413 RVA: 0x006AB384 File Offset: 0x006A9584
		private void MLFHKJODJGO()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = true;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1949f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.KEBDEJIAODF();
			this.ik.references.pelvis.position += this.solver.DLIDADHGILM().PICADOHNEIC() * this.weight;
			this.GALINFCJCLO(this.ik.solver.leftFootEffector, this.solver.MMPFHLEJIOI()[1]);
			this.DAADPPPNFKM(this.ik.solver.EAIGBIHMAGB(), this.solver.BJLLBFABCBL()[1]);
			if (this.spineBend != 1272f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 620f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 0; i < this.spine.Length; i++)
				{
					this.ik.solver.DAMGOIIBHCN(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EBFE RID: 60414 RVA: 0x006AB567 File Offset: 0x006A9767
		protected virtual void EEDHMJPJNNM()
		{
			Application.OpenURL("1704 wpn id=");
		}

		// Token: 0x0600EBFF RID: 60415 RVA: 0x006A8740 File Offset: 0x006A6940
		private bool BDMLEOCCJLL()
		{
			return !(this.ik == null) && (this.ik.solver.initiated || true);
		}

		// Token: 0x0600EC00 RID: 60416 RVA: 0x006AB574 File Offset: 0x006A9774
		private void DMOINNLLGBO()
		{
			this.ik.solver.DJAJGGAOAMO().maintainRotationWeight = 1561f;
			this.ik.solver.rightLegMapping.maintainRotationWeight = 227f;
			this.CJLCHFDCNDM = new Transform[6];
			this.CJLCHFDCNDM[0] = this.ik.solver.JHKNHMMGKCG().bone;
			this.CJLCHFDCNDM[1] = this.ik.solver.JIHGEPGJDEC().bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.MLFHKJODJGO));
			this.solver.ENLPEHMBNJC(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EC01 RID: 60417 RVA: 0x006A908D File Offset: 0x006A728D
		private void JKDBDEGLIJN()
		{
			this.IJJMEFAMPNM = true;
		}

		// Token: 0x0600EC02 RID: 60418 RVA: 0x006AB650 File Offset: 0x006A9850
		private void BHALELINNDJ()
		{
			this.ik.solver.leftLegMapping.maintainRotationWeight = 1f;
			this.ik.solver.rightLegMapping.maintainRotationWeight = 1f;
			this.CJLCHFDCNDM = new Transform[2];
			this.CJLCHFDCNDM[0] = this.ik.solver.leftFootEffector.bone;
			this.CJLCHFDCNDM[1] = this.ik.solver.rightFootEffector.bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
			this.solver.BHALELINNDJ(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EC03 RID: 60419 RVA: 0x006AB72B File Offset: 0x006A992B
		protected virtual void DMJHBJIJDGI()
		{
			Application.OpenURL("IdleTurns");
		}

		// Token: 0x0600EC04 RID: 60420 RVA: 0x006A8737 File Offset: 0x006A6937
		private void KJOMAENNOGH()
		{
			this.IJJMEFAMPNM = false;
		}

		// Token: 0x0600EC05 RID: 60421 RVA: 0x006A8737 File Offset: 0x006A6937
		private void EKOMJLLJNFL()
		{
			this.IJJMEFAMPNM = false;
		}

		// Token: 0x0600EC06 RID: 60422 RVA: 0x006AB737 File Offset: 0x006A9937
		protected virtual void BAEEDLHGLBK()
		{
			Application.OpenURL("auk_wavg");
		}

		// Token: 0x0600EC07 RID: 60423 RVA: 0x006AB744 File Offset: 0x006A9944
		private void OGJNLKMJBNA()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = false;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1805f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.JLFBDOPFDDJ();
			this.ik.references.pelvis.position += this.solver.pelvis.BCCMNDJMEPG() * this.weight;
			this.CIAEDBLBPNL(this.ik.solver.IAGDDAJGGGE(), this.solver.legs[0]);
			this.GALINFCJCLO(this.ik.solver.JFOHJFFFPGJ(), this.solver.BJLLBFABCBL()[0]);
			if (this.spineBend != 854f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 550f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 1; i < this.spine.Length; i += 0)
				{
					this.ik.solver.EEKAOKNJLKH(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EC08 RID: 60424 RVA: 0x006AB928 File Offset: 0x006A9B28
		private void DHFEGOKNDHL()
		{
			if (this.ik == null)
			{
				this.ik = base.GetComponent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInParent<FullBodyBipedIK>();
			}
			if (this.ik == null)
			{
				this.ik = base.GetComponentInChildren<FullBodyBipedIK>();
			}
		}

		// Token: 0x0600EC09 RID: 60425 RVA: 0x006AB983 File Offset: 0x006A9B83
		private void AIJOBGLNPAA()
		{
			Application.OpenURL("Kernel");
		}

		// Token: 0x0600EC0A RID: 60426 RVA: 0x006AB98F File Offset: 0x006A9B8F
		protected virtual void HNJDJKMFENE()
		{
			Application.OpenURL("Invalid ObscuredVector3 index!");
		}

		// Token: 0x0600EC0B RID: 60427 RVA: 0x006AB99C File Offset: 0x006A9B9C
		private void KNEEBLNAGLM()
		{
			this.ik.solver.leftLegMapping.maintainRotationWeight = 798f;
			this.ik.solver.rightLegMapping.maintainRotationWeight = 1454f;
			this.CJLCHFDCNDM = new Transform[3];
			this.CJLCHFDCNDM[0] = this.ik.solver.JHKNHMMGKCG().bone;
			this.CJLCHFDCNDM[0] = this.ik.solver.rightFootEffector.bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.KBOOODIBLAN));
			this.solver.CAAINGFBNHG(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EC0C RID: 60428 RVA: 0x006ABA78 File Offset: 0x006A9C78
		private void CLCJPEDHFJA()
		{
			this.IJJMEFAMPNM = true;
			this.weight = Mathf.Clamp(this.weight, 1177f, 736f);
			if (this.weight <= 535f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.HDLIKPOMIOI())
			{
				return;
			}
			this.BEMAKGADCIJ();
		}

		// Token: 0x0600EC0D RID: 60429 RVA: 0x006ABAD0 File Offset: 0x006A9CD0
		private void BHCIAIKKLJA()
		{
			this.ik.solver.DJAJGGAOAMO().maintainRotationWeight = 1348f;
			this.ik.solver.rightLegMapping.maintainRotationWeight = 479f;
			this.CJLCHFDCNDM = new Transform[1];
			this.CJLCHFDCNDM[1] = this.ik.solver.IAGDDAJGGGE().bone;
			this.CJLCHFDCNDM[0] = this.ik.solver.EAIGBIHMAGB().bone;
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
			this.solver.CAAINGFBNHG(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EC0E RID: 60430 RVA: 0x006A67EA File Offset: 0x006A49EA
		protected override void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page11.html");
		}

		// Token: 0x0600EC0F RID: 60431 RVA: 0x006ABBAB File Offset: 0x006A9DAB
		private void PBIKKNLCOKD()
		{
			Application.OpenURL("#FF4040");
		}

		// Token: 0x0600EC10 RID: 60432 RVA: 0x006A8737 File Offset: 0x006A6937
		private void BOPHHDCKKLB()
		{
			this.IJJMEFAMPNM = false;
		}

		// Token: 0x0600EC11 RID: 60433 RVA: 0x006AA827 File Offset: 0x006A8A27
		private bool OKFDPMEBDCA()
		{
			return !(this.ik == null) && !this.ik.solver.initiated && false;
		}

		// Token: 0x0600EC12 RID: 60434 RVA: 0x006ABBB8 File Offset: 0x006A9DB8
		private void AHCCFPGFBKI()
		{
			if (!this.IJJMEFAMPNM)
			{
				return;
			}
			this.IJJMEFAMPNM = false;
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 633f)
			{
				return;
			}
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			this.solver.EMHGNEMIGII();
			this.ik.references.pelvis.position += this.solver.DLIDADHGILM().PEKMJMNKKPE() * this.weight;
			this.EKPIEJEBBBL(this.ik.solver.IAGDDAJGGGE(), this.solver.BGCPOHLJIDN()[1]);
			this.DDCEEEIDDIP(this.ik.solver.ANGCEEAGHCB(), this.solver.legs[0]);
			if (this.spineBend != 1179f)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 1237f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Vector3 a2 = this.ik.references.root.up * this.ANGFDBKNLJA.magnitude;
				for (int i = 1; i < this.spine.Length; i++)
				{
					this.ik.solver.EEKAOKNJLKH(this.spine[i].effectorType).positionOffset += this.ANGFDBKNLJA * this.spine[i].horizontalWeight + a2 * this.spine[i].verticalWeight;
				}
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EC13 RID: 60435 RVA: 0x006A908D File Offset: 0x006A728D
		private void IAGDKFGKPGG()
		{
			this.IJJMEFAMPNM = true;
		}

		// Token: 0x0600EC14 RID: 60436 RVA: 0x006ABD9C File Offset: 0x006A9F9C
		private void JFGGBEGNAFP()
		{
			this.IJJMEFAMPNM = false;
			this.weight = Mathf.Clamp(this.weight, 758f, 764f);
			if (this.weight <= 1913f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.HDLIKPOMIOI())
			{
				return;
			}
			this.NMBDJDNEFFM();
		}

		// Token: 0x0600EC15 RID: 60437 RVA: 0x006ABDF1 File Offset: 0x006A9FF1
		private void FHIEDOBGFLP()
		{
			Application.OpenURL("Wait");
		}

		// Token: 0x0600EC16 RID: 60438 RVA: 0x006ABDFD File Offset: 0x006A9FFD
		protected virtual void GCPHJMNEICI()
		{
			Application.OpenURL("wpn_add/addoptions/klevprop");
		}

		// Token: 0x04001ED2 RID: 7890
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		// Token: 0x04001ED3 RID: 7891
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend = 2f;

		// Token: 0x04001ED4 RID: 7892
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed = 3f;

		// Token: 0x04001ED5 RID: 7893
		public GrounderFBBIK.SpineEffector[] spine = new GrounderFBBIK.SpineEffector[0];

		// Token: 0x04001ED6 RID: 7894
		private Transform[] CJLCHFDCNDM = new Transform[2];

		// Token: 0x04001ED7 RID: 7895
		private Vector3 ANGFDBKNLJA;

		// Token: 0x04001ED8 RID: 7896
		private bool IJJMEFAMPNM;

		// Token: 0x02000447 RID: 1095
		[Serializable]
		public class SpineEffector
		{
			// Token: 0x04001ED9 RID: 7897
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			// Token: 0x04001EDA RID: 7898
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight = 1f;

			// Token: 0x04001EDB RID: 7899
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;
		}
	}
}
