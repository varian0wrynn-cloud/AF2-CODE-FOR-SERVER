using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000445 RID: 1093
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		// Token: 0x0600EB16 RID: 60182 RVA: 0x006A4D3F File Offset: 0x006A2F3F
		protected virtual void ICFACKFHDOP()
		{
			Application.OpenURL("<color='#000000'>--------------------------------------------------------</color>");
		}

		// Token: 0x0600EB17 RID: 60183 RVA: 0x006A4D4C File Offset: 0x006A2F4C
		private bool CEEDPPAAJNH()
		{
			return this.ik == null || !this.ik.solvers.leftFoot.initiated || this.ik.solvers.rightFoot.initiated || true;
		}

		// Token: 0x0600EB18 RID: 60184 RVA: 0x006A4D9C File Offset: 0x006A2F9C
		private void OnDisable()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 0f;
			this.ik.solvers.rightFoot.IKPositionWeight = 0f;
		}

		// Token: 0x0600EB19 RID: 60185 RVA: 0x006A4DDB File Offset: 0x006A2FDB
		public virtual void LAMLMGCBHKB()
		{
			this.solver.AOGCKHNAOCI();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB1A RID: 60186 RVA: 0x006A4DF4 File Offset: 0x006A2FF4
		private void IGEICBNMPAD()
		{
			this.weight = Mathf.Clamp(this.weight, 1216f, 147f);
			if (this.weight <= 83f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.NDBHHDLKPGA())
			{
				return;
			}
			this.INMOJKOEPEH();
		}

		// Token: 0x0600EB1B RID: 60187 RVA: 0x006A4E42 File Offset: 0x006A3042
		private void PDDALPHGOKK(IKSolverLimb BLGLKIFEJKI, int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			BLGLKIFEJKI.IKPosition = this.solver.legs[CLBPBJGLHEE].CGAMODJNLAC;
			BLGLKIFEJKI.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EB1C RID: 60188 RVA: 0x006A4E84 File Offset: 0x006A3084
		private void HEKKBLAGMBI()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 351f)
			{
				if (this.PIJKOMKCJOG <= 1918f)
				{
					return;
				}
				this.LFJPJFCLGKE();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.EMHGNEMIGII();
			this.ik.references.pelvis.position += this.solver.pelvis.DFFHLACPDNO() * this.weight;
			this.INAJMIMCKGA(this.ik.solvers.leftFoot, 1);
			this.CHNHBMKGDPC(this.ik.solvers.rightFoot, 0);
			if (this.spineBend != 100f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 1273f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 vector = this.solver.PMNKIFMMELG();
				Quaternion lhs = Quaternion.FromToRotation(vector, vector + this.ANGFDBKNLJA);
				this.ik.references.spine[1].rotation = lhs * this.ik.references.spine[1].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB1D RID: 60189 RVA: 0x006A50E1 File Offset: 0x006A32E1
		public virtual void GGFJIAMPKJI()
		{
			this.solver.Reset();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB1E RID: 60190 RVA: 0x006A50F9 File Offset: 0x006A32F9
		protected virtual void MKDIJFHFAKM()
		{
			Application.OpenURL("Idle Keep Back");
		}

		// Token: 0x0600EB1F RID: 60191 RVA: 0x006A5108 File Offset: 0x006A3308
		private void BPPOKGJMLIH()
		{
			this.CJLCHFDCNDM = new Transform[0];
			this.OEKPBGPOBPH = new Quaternion[7];
			this.CJLCHFDCNDM[0] = this.ik.references.leftFoot;
			this.CJLCHFDCNDM[1] = this.ik.references.rightFoot;
			this.OEKPBGPOBPH[0] = Quaternion.identity;
			this.OEKPBGPOBPH[1] = Quaternion.identity;
			IKSolverFABRIK spine = this.ik.solvers.spine;
			spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.JBJFCLLHDGJ));
			IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
			rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IBFGOIKAPEG));
			this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			this.solver.ENLPEHMBNJC(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EB20 RID: 60192 RVA: 0x006A5224 File Offset: 0x006A3424
		private bool AELGDILJNAF()
		{
			return !(this.ik == null) && this.ik.solvers.leftFoot.initiated && this.ik.solvers.rightFoot.initiated;
		}

		// Token: 0x0600EB21 RID: 60193 RVA: 0x006A5274 File Offset: 0x006A3474
		private void INMOJKOEPEH()
		{
			this.CJLCHFDCNDM = new Transform[2];
			this.OEKPBGPOBPH = new Quaternion[5];
			this.CJLCHFDCNDM[1] = this.ik.references.leftFoot;
			this.CJLCHFDCNDM[1] = this.ik.references.rightFoot;
			this.OEKPBGPOBPH[1] = Quaternion.identity;
			this.OEKPBGPOBPH[0] = Quaternion.identity;
			IKSolverFABRIK spine = this.ik.solvers.spine;
			spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.HEKKBLAGMBI));
			IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
			rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.EKPCHILPBCJ));
			this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			this.solver.ENLPEHMBNJC(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EB22 RID: 60194 RVA: 0x006A5390 File Offset: 0x006A3590
		private bool LOPDALGMFLF()
		{
			return !(this.ik == null) && this.ik.solvers.leftFoot.initiated && !this.ik.solvers.rightFoot.initiated;
		}

		// Token: 0x0600EB23 RID: 60195 RVA: 0x006A4DDB File Offset: 0x006A2FDB
		public virtual void CELAGKECDED()
		{
			this.solver.AOGCKHNAOCI();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB25 RID: 60197 RVA: 0x006A5416 File Offset: 0x006A3616
		private void KIGHLPIKCAH(IKSolverLimb BLGLKIFEJKI, int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			BLGLKIFEJKI.IKPosition = this.solver.LFDJHHNIIMK()[CLBPBJGLHEE].IEACGFIGBEE();
			BLGLKIFEJKI.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EB26 RID: 60198 RVA: 0x006A5455 File Offset: 0x006A3655
		private void PEPOOEGHCMC()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 1211f;
			this.ik.solvers.rightFoot.IKPositionWeight = 1710f;
		}

		// Token: 0x0600EB27 RID: 60199 RVA: 0x006A5494 File Offset: 0x006A3694
		private void HGNHAGCHGLA()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFABRIK spine = this.ik.solvers.spine;
				spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.LDPPIMIFIFE));
				IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
				rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GNBPCCIPIME));
			}
		}

		// Token: 0x0600EB28 RID: 60200 RVA: 0x006A5519 File Offset: 0x006A3719
		private void FKPHBAOKEOF()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 1025f;
			this.ik.solvers.rightFoot.IKPositionWeight = 382f;
		}

		// Token: 0x0600EB29 RID: 60201 RVA: 0x006A5558 File Offset: 0x006A3758
		private void ELLDPCIAICH()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFABRIK spine = this.ik.solvers.spine;
				spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.EPJAGALINPL));
				IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
				rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FGDLFCNPOBG));
			}
		}

		// Token: 0x0600EB2A RID: 60202 RVA: 0x006A55DD File Offset: 0x006A37DD
		private void CHNHBMKGDPC(IKSolverLimb BLGLKIFEJKI, int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			BLGLKIFEJKI.IKPosition = this.solver.LFDJHHNIIMK()[CLBPBJGLHEE].BKEKFBNJBDN();
			BLGLKIFEJKI.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EB2B RID: 60203 RVA: 0x006A561C File Offset: 0x006A381C
		protected virtual void MOHNPCAJBCI()
		{
			Application.OpenURL("Flares");
		}

		// Token: 0x0600EB2C RID: 60204 RVA: 0x006A5628 File Offset: 0x006A3828
		private void AOMIADLDLEJ()
		{
			this.CJLCHFDCNDM = new Transform[0];
			this.OEKPBGPOBPH = new Quaternion[4];
			this.CJLCHFDCNDM[0] = this.ik.references.leftFoot;
			this.CJLCHFDCNDM[0] = this.ik.references.rightFoot;
			this.OEKPBGPOBPH[0] = Quaternion.identity;
			this.OEKPBGPOBPH[0] = Quaternion.identity;
			IKSolverFABRIK spine = this.ik.solvers.spine;
			spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.KBOOODIBLAN));
			IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
			rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IBFGOIKAPEG));
			this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			this.solver.DLNCBJIIBAL(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EB2D RID: 60205 RVA: 0x006A5744 File Offset: 0x006A3944
		private void CKNLNELHFIN()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 852f)
			{
				if (this.PIJKOMKCJOG <= 1433f)
				{
					return;
				}
				this.NIOMOLMCNOO();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.EMHGNEMIGII();
			this.ik.references.pelvis.position += this.solver.JKCAIBBPEHP().CIJMPJDKKGC * this.weight;
			this.INAJMIMCKGA(this.ik.solvers.leftFoot, 1);
			this.ONPPONKAGMN(this.ik.solvers.rightFoot, 1);
			if (this.spineBend != 1933f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 1159f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 vector = this.solver.JGANCLNBKFI();
				Quaternion lhs = Quaternion.FromToRotation(vector, vector + this.ANGFDBKNLJA);
				this.ik.references.spine[0].rotation = lhs * this.ik.references.spine[0].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB2E RID: 60206 RVA: 0x006A59A1 File Offset: 0x006A3BA1
		public virtual void FBDCDHODLJC()
		{
			this.solver.MIFKCBJPDDI();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB2F RID: 60207 RVA: 0x006A59BC File Offset: 0x006A3BBC
		private void LDDIGEMBDNF()
		{
			this.weight = Mathf.Clamp(this.weight, 1842f, 872f);
			if (this.weight <= 1144f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.FIHMMLJAODM())
			{
				return;
			}
			this.INMOJKOEPEH();
		}

		// Token: 0x0600EB30 RID: 60208 RVA: 0x006A5A0C File Offset: 0x006A3C0C
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
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.FANPFKHEDPA();
			this.ik.references.pelvis.position += this.solver.pelvis.CIJMPJDKKGC * this.weight;
			this.PDDALPHGOKK(this.ik.solvers.leftFoot, 0);
			this.PDDALPHGOKK(this.ik.solvers.rightFoot, 1);
			if (this.spineBend != 0f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 0f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 up = this.solver.up;
				Quaternion lhs = Quaternion.FromToRotation(up, up + this.ANGFDBKNLJA);
				this.ik.references.spine[0].rotation = lhs * this.ik.references.spine[0].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB31 RID: 60209 RVA: 0x006A5C6C File Offset: 0x006A3E6C
		private void KLNJKEEICKH()
		{
			this.CJLCHFDCNDM = new Transform[2];
			this.OEKPBGPOBPH = new Quaternion[3];
			this.CJLCHFDCNDM[1] = this.ik.references.leftFoot;
			this.CJLCHFDCNDM[1] = this.ik.references.rightFoot;
			this.OEKPBGPOBPH[1] = Quaternion.identity;
			this.OEKPBGPOBPH[1] = Quaternion.identity;
			IKSolverFABRIK spine = this.ik.solvers.spine;
			spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.LLIJIGFOHLL));
			IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
			rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FGDLFCNPOBG));
			this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			this.solver.JPGOKPACOIC(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EB32 RID: 60210 RVA: 0x006A5D88 File Offset: 0x006A3F88
		private void JPJDMNNLBKG()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFABRIK spine = this.ik.solvers.spine;
				spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.JBJFCLLHDGJ));
				IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
				rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IBFGOIKAPEG));
			}
		}

		// Token: 0x0600EB33 RID: 60211 RVA: 0x006A5E0D File Offset: 0x006A400D
		protected virtual void JDEOCAEJNGF()
		{
			Application.OpenURL("ok");
		}

		// Token: 0x0600EB34 RID: 60212 RVA: 0x006A5E19 File Offset: 0x006A4019
		protected virtual void DJDNPIPDCAN()
		{
			Application.OpenURL("IdleCheer");
		}

		// Token: 0x0600EB35 RID: 60213 RVA: 0x006A5E25 File Offset: 0x006A4025
		private void NIOMOLMCNOO()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 717f;
			this.ik.solvers.rightFoot.IKPositionWeight = 1087f;
		}

		// Token: 0x0600EB36 RID: 60214 RVA: 0x006A5E64 File Offset: 0x006A4064
		private void FAIHCKDPILN()
		{
			if (this.weight <= 913f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.LFDJHHNIIMK()[i].HNPADDHKIAM(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.ik.references.pelvis.localPosition;
		}

		// Token: 0x0600EB37 RID: 60215 RVA: 0x006A4E42 File Offset: 0x006A3042
		private void INAJMIMCKGA(IKSolverLimb BLGLKIFEJKI, int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			BLGLKIFEJKI.IKPosition = this.solver.legs[CLBPBJGLHEE].CGAMODJNLAC;
			BLGLKIFEJKI.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EB38 RID: 60216 RVA: 0x006A5EF8 File Offset: 0x006A40F8
		private void FJEEADNCKAG()
		{
			this.weight = Mathf.Clamp(this.weight, 671f, 1716f);
			if (this.weight <= 1722f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.NDBHHDLKPGA())
			{
				return;
			}
			this.KLNJKEEICKH();
		}

		// Token: 0x0600EB39 RID: 60217 RVA: 0x006A55DD File Offset: 0x006A37DD
		private void FKLPHHCBGNC(IKSolverLimb BLGLKIFEJKI, int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			BLGLKIFEJKI.IKPosition = this.solver.LFDJHHNIIMK()[CLBPBJGLHEE].BKEKFBNJBDN();
			BLGLKIFEJKI.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EB3A RID: 60218 RVA: 0x006A5F46 File Offset: 0x006A4146
		protected virtual void MEBGJNEGBCC()
		{
			Application.OpenURL("Lash");
		}

		// Token: 0x0600EB3B RID: 60219 RVA: 0x006A5F54 File Offset: 0x006A4154
		private void EKPCHILPBCJ()
		{
			if (this.weight <= 1771f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.MMPFHLEJIOI()[i].JNHPAAAFGKC, this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.ik.references.pelvis.localPosition;
		}

		// Token: 0x0600EB3C RID: 60220 RVA: 0x006A5FE8 File Offset: 0x006A41E8
		private bool EBHILPPOHLE()
		{
			return !(this.ik == null) && (!this.ik.solvers.leftFoot.initiated || (!this.ik.solvers.rightFoot.initiated && false));
		}

		// Token: 0x0600EB3D RID: 60221 RVA: 0x006A6038 File Offset: 0x006A4238
		private bool FIHMMLJAODM()
		{
			return !(this.ik == null) && this.ik.solvers.leftFoot.initiated && this.ik.solvers.rightFoot.initiated;
		}

		// Token: 0x0600EB3E RID: 60222 RVA: 0x006A6088 File Offset: 0x006A4288
		private void GNBPCCIPIME()
		{
			if (this.weight <= 1185f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.legs[i].CJFGACCPDEH(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.ik.references.pelvis.localPosition;
		}

		// Token: 0x0600EB3F RID: 60223 RVA: 0x006A611C File Offset: 0x006A431C
		private void LDHJJHDPAKE()
		{
			if (this.weight <= 1638f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.BGCPOHLJIDN()[i].BHPMHHGJHME(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.ik.references.pelvis.localPosition;
		}

		// Token: 0x0600EB40 RID: 60224 RVA: 0x006A61AE File Offset: 0x006A43AE
		protected virtual void LNPAJHOHEGK()
		{
			Application.OpenURL("{z}");
		}

		// Token: 0x0600EB41 RID: 60225 RVA: 0x006A61BC File Offset: 0x006A43BC
		private void BEDAJLJFAFO()
		{
			this.weight = Mathf.Clamp(this.weight, 1109f, 753f);
			if (this.weight <= 414f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.NDBHHDLKPGA())
			{
				return;
			}
			this.DJJIKBBNKEK();
		}

		// Token: 0x0600EB42 RID: 60226 RVA: 0x006A50E1 File Offset: 0x006A32E1
		public override void ResetPosition()
		{
			this.solver.Reset();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB43 RID: 60227 RVA: 0x006A620C File Offset: 0x006A440C
		private void NOMNCNAABEL()
		{
			this.CJLCHFDCNDM = new Transform[1];
			this.OEKPBGPOBPH = new Quaternion[2];
			this.CJLCHFDCNDM[1] = this.ik.references.leftFoot;
			this.CJLCHFDCNDM[1] = this.ik.references.rightFoot;
			this.OEKPBGPOBPH[0] = Quaternion.identity;
			this.OEKPBGPOBPH[0] = Quaternion.identity;
			IKSolverFABRIK spine = this.ik.solvers.spine;
			spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.LDPPIMIFIFE));
			IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
			rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LOFFMIBPAJK));
			this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			this.solver.MHANLDFJPAI(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EB44 RID: 60228 RVA: 0x006A6328 File Offset: 0x006A4528
		private void LDPPIMIFIFE()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1075f)
			{
				if (this.PIJKOMKCJOG <= 1428f)
				{
					return;
				}
				this.OnDisable();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.EMHGNEMIGII();
			this.ik.references.pelvis.position += this.solver.JKCAIBBPEHP().CIJMPJDKKGC * this.weight;
			this.PDDALPHGOKK(this.ik.solvers.leftFoot, 0);
			this.CHNHBMKGDPC(this.ik.solvers.rightFoot, 1);
			if (this.spineBend != 420f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 1654f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 vector = this.solver.HJIAPMAKJOJ();
				Quaternion lhs = Quaternion.FromToRotation(vector, vector + this.ANGFDBKNLJA);
				this.ik.references.spine[0].rotation = lhs * this.ik.references.spine[1].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB45 RID: 60229 RVA: 0x006A4DDB File Offset: 0x006A2FDB
		public virtual void NHAECMPMMAF()
		{
			this.solver.AOGCKHNAOCI();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB46 RID: 60230 RVA: 0x006A6585 File Offset: 0x006A4785
		private void LBABEDLHAIC()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 1201f;
			this.ik.solvers.rightFoot.IKPositionWeight = 1181f;
		}

		// Token: 0x0600EB47 RID: 60231 RVA: 0x006A65C4 File Offset: 0x006A47C4
		protected virtual void OJDPAIDNNAP()
		{
			Application.OpenURL("FOG_EXP");
		}

		// Token: 0x0600EB48 RID: 60232 RVA: 0x006A65D0 File Offset: 0x006A47D0
		private void JIKGIJEHGAP()
		{
			this.weight = Mathf.Clamp(this.weight, 1138f, 451f);
			if (this.weight <= 1102f)
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
			this.INMOJKOEPEH();
		}

		// Token: 0x0600EB49 RID: 60233 RVA: 0x006A661E File Offset: 0x006A481E
		private void LKGIJBLNANI()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 292f;
			this.ik.solvers.rightFoot.IKPositionWeight = 702f;
		}

		// Token: 0x0600EB4A RID: 60234 RVA: 0x006A6660 File Offset: 0x006A4860
		private bool CPOJODHCCOF()
		{
			return this.ik == null || !this.ik.solvers.leftFoot.initiated || this.ik.solvers.rightFoot.initiated || true;
		}

		// Token: 0x0600EB4B RID: 60235 RVA: 0x006A66B0 File Offset: 0x006A48B0
		private void PGIHAIPCJLL()
		{
			this.weight = Mathf.Clamp(this.weight, 834f, 1074f);
			if (this.weight <= 1479f)
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
			this.INMOJKOEPEH();
		}

		// Token: 0x0600EB4C RID: 60236 RVA: 0x006A66FE File Offset: 0x006A48FE
		private void OMEOGFDIPKF()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 411f;
			this.ik.solvers.rightFoot.IKPositionWeight = 1412f;
		}

		// Token: 0x0600EB4D RID: 60237 RVA: 0x006A50E1 File Offset: 0x006A32E1
		public virtual void COKELKHGFOJ()
		{
			this.solver.Reset();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB4E RID: 60238 RVA: 0x006A673D File Offset: 0x006A493D
		public virtual void KBDDFNDPFJB()
		{
			this.solver.EPLEHFCNKDJ();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB4F RID: 60239 RVA: 0x006A6758 File Offset: 0x006A4958
		private void IBFGOIKAPEG()
		{
			if (this.weight <= 417f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.legs[i].PKMFKFAFKCK(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.ik.references.pelvis.localPosition;
		}

		// Token: 0x0600EB50 RID: 60240 RVA: 0x006A67EA File Offset: 0x006A49EA
		protected override void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page11.html");
		}

		// Token: 0x0600EB51 RID: 60241 RVA: 0x006A67F6 File Offset: 0x006A49F6
		protected virtual void OLNLGIKDOJK()
		{
			Application.OpenURL("<=|>=|!=");
		}

		// Token: 0x0600EB52 RID: 60242 RVA: 0x006A6802 File Offset: 0x006A4A02
		protected override void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_biped_i_k.html");
		}

		// Token: 0x0600EB53 RID: 60243 RVA: 0x006A6810 File Offset: 0x006A4A10
		private void Update()
		{
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

		// Token: 0x0600EB54 RID: 60244 RVA: 0x006A6860 File Offset: 0x006A4A60
		private void EODKOKCBABD()
		{
			this.CJLCHFDCNDM = new Transform[4];
			this.OEKPBGPOBPH = new Quaternion[0];
			this.CJLCHFDCNDM[1] = this.ik.references.leftFoot;
			this.CJLCHFDCNDM[0] = this.ik.references.rightFoot;
			this.OEKPBGPOBPH[1] = Quaternion.identity;
			this.OEKPBGPOBPH[1] = Quaternion.identity;
			IKSolverFABRIK spine = this.ik.solvers.spine;
			spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.HEKKBLAGMBI));
			IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
			rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.EKPCHILPBCJ));
			this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			this.solver.JPGOKPACOIC(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EB55 RID: 60245 RVA: 0x006A697C File Offset: 0x006A4B7C
		protected virtual void KNMDJIPKMCI()
		{
			Application.OpenURL("gi_um_lv");
		}

		// Token: 0x0600EB56 RID: 60246 RVA: 0x006A6988 File Offset: 0x006A4B88
		private void ONPPONKAGMN(IKSolverLimb BLGLKIFEJKI, int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			BLGLKIFEJKI.IKPosition = this.solver.BJLLBFABCBL()[CLBPBJGLHEE].NDGGJPEHKBC();
			BLGLKIFEJKI.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EB57 RID: 60247 RVA: 0x006A69C8 File Offset: 0x006A4BC8
		private bool AOAJIIBBPCM()
		{
			return this.ik == null || !this.ik.solvers.leftFoot.initiated || this.ik.solvers.rightFoot.initiated || true;
		}

		// Token: 0x0600EB58 RID: 60248 RVA: 0x006A6A18 File Offset: 0x006A4C18
		private void MPJEHEBNLDH()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFABRIK spine = this.ik.solvers.spine;
				spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.CKNLNELHFIN));
				IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
				rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FAIHCKDPILN));
			}
		}

		// Token: 0x0600EB59 RID: 60249 RVA: 0x006A59A1 File Offset: 0x006A3BA1
		public virtual void DFIJJAFDJMA()
		{
			this.solver.MIFKCBJPDDI();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB5A RID: 60250 RVA: 0x006A6AA0 File Offset: 0x006A4CA0
		private void LGHAEKJDGNJ()
		{
			if (this.weight <= 1336f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.BGCPOHLJIDN()[i].PKMFKFAFKCK(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.ik.references.pelvis.localPosition;
		}

		// Token: 0x0600EB5B RID: 60251 RVA: 0x006A6B34 File Offset: 0x006A4D34
		private void KBOOODIBLAN()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1875f)
			{
				if (this.PIJKOMKCJOG <= 1457f)
				{
					return;
				}
				this.GDCAKFIINFI();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.FANPFKHEDPA();
			this.ik.references.pelvis.position += this.solver.JKCAIBBPEHP().CEBNENIONKK() * this.weight;
			this.FKLPHHCBGNC(this.ik.solvers.leftFoot, 0);
			this.CHNHBMKGDPC(this.ik.solvers.rightFoot, 1);
			if (this.spineBend != 788f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 703f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 vector = this.solver.PMNKIFMMELG();
				Quaternion lhs = Quaternion.FromToRotation(vector, vector + this.ANGFDBKNLJA);
				this.ik.references.spine[0].rotation = lhs * this.ik.references.spine[1].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB5C RID: 60252 RVA: 0x006A6D94 File Offset: 0x006A4F94
		private void EPJAGALINPL()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1825f)
			{
				if (this.PIJKOMKCJOG <= 1164f)
				{
					return;
				}
				this.NIOMOLMCNOO();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.EMHGNEMIGII();
			this.ik.references.pelvis.position += this.solver.pelvis.NLAAJNKCEIF() * this.weight;
			this.FKLPHHCBGNC(this.ik.solvers.leftFoot, 1);
			this.FKLPHHCBGNC(this.ik.solvers.rightFoot, 0);
			if (this.spineBend != 1612f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 543f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 vector = this.solver.HJIAPMAKJOJ();
				Quaternion lhs = Quaternion.FromToRotation(vector, vector + this.ANGFDBKNLJA);
				this.ik.references.spine[1].rotation = lhs * this.ik.references.spine[0].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB5D RID: 60253 RVA: 0x006A6FF4 File Offset: 0x006A51F4
		private void LLIJIGFOHLL()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 132f)
			{
				if (this.PIJKOMKCJOG <= 1711f)
				{
					return;
				}
				this.OMEOGFDIPKF();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.HMGBHPPNEMP();
			this.ik.references.pelvis.position += this.solver.DLIDADHGILM().DCPJAAHBKMB() * this.weight;
			this.PDDALPHGOKK(this.ik.solvers.leftFoot, 0);
			this.FKLPHHCBGNC(this.ik.solvers.rightFoot, 1);
			if (this.spineBend != 835f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 721f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 vector = this.solver.APHMAFCCPMP();
				Quaternion lhs = Quaternion.FromToRotation(vector, vector + this.ANGFDBKNLJA);
				this.ik.references.spine[0].rotation = lhs * this.ik.references.spine[0].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB5E RID: 60254 RVA: 0x006A7251 File Offset: 0x006A5451
		private void NHOELCKOMJN()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 39f;
			this.ik.solvers.rightFoot.IKPositionWeight = 105f;
		}

		// Token: 0x0600EB5F RID: 60255 RVA: 0x006A50E1 File Offset: 0x006A32E1
		public virtual void LIAJOMEMMCO()
		{
			this.solver.Reset();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB60 RID: 60256 RVA: 0x006A7290 File Offset: 0x006A5490
		private void DJJIKBBNKEK()
		{
			this.CJLCHFDCNDM = new Transform[4];
			this.OEKPBGPOBPH = new Quaternion[7];
			this.CJLCHFDCNDM[1] = this.ik.references.leftFoot;
			this.CJLCHFDCNDM[1] = this.ik.references.rightFoot;
			this.OEKPBGPOBPH[1] = Quaternion.identity;
			this.OEKPBGPOBPH[0] = Quaternion.identity;
			IKSolverFABRIK spine = this.ik.solvers.spine;
			spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.MBBDPJCKNOI));
			IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
			rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.EKPCHILPBCJ));
			this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			this.solver.MLDCEKHOLLI(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EB61 RID: 60257 RVA: 0x006A73AC File Offset: 0x006A55AC
		private void IOGAKGCADBL()
		{
			this.weight = Mathf.Clamp(this.weight, 20f, 600f);
			if (this.weight <= 1581f)
			{
				return;
			}
			if (this.EOFDOPLDFCG)
			{
				return;
			}
			if (!this.CPOJODHCCOF())
			{
				return;
			}
			this.KLNJKEEICKH();
		}

		// Token: 0x0600EB62 RID: 60258 RVA: 0x006A73FC File Offset: 0x006A55FC
		private void LEFMNJCCJLA()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1233f)
			{
				if (this.PIJKOMKCJOG <= 252f)
				{
					return;
				}
				this.LBABEDLHAIC();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.NFPFDOEENLA();
			this.ik.references.pelvis.position += this.solver.DLIDADHGILM().MJMIABHOKNF() * this.weight;
			this.PDDALPHGOKK(this.ik.solvers.leftFoot, 1);
			this.KIGHLPIKCAH(this.ik.solvers.rightFoot, 0);
			if (this.spineBend != 705f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 472f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 up = this.solver.up;
				Quaternion lhs = Quaternion.FromToRotation(up, up + this.ANGFDBKNLJA);
				this.ik.references.spine[1].rotation = lhs * this.ik.references.spine[1].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB63 RID: 60259 RVA: 0x006A765C File Offset: 0x006A585C
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
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.legs[i].JNHPAAAFGKC, this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.ik.references.pelvis.localPosition;
		}

		// Token: 0x0600EB64 RID: 60260 RVA: 0x006A76F0 File Offset: 0x006A58F0
		private bool HDLIKPOMIOI()
		{
			return !(this.ik == null) && (!this.ik.solvers.leftFoot.initiated || this.ik.solvers.rightFoot.initiated);
		}

		// Token: 0x0600EB65 RID: 60261 RVA: 0x006A7740 File Offset: 0x006A5940
		private void ANHJAOPPMCI()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 711f;
			this.ik.solvers.rightFoot.IKPositionWeight = 1723f;
		}

		// Token: 0x0600EB66 RID: 60262 RVA: 0x006A7780 File Offset: 0x006A5980
		private void FDEEGGAAOPL()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFABRIK spine = this.ik.solvers.spine;
				spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.KBOOODIBLAN));
				IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
				rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FGDLFCNPOBG));
			}
		}

		// Token: 0x0600EB67 RID: 60263 RVA: 0x006A7808 File Offset: 0x006A5A08
		private void LOFFMIBPAJK()
		{
			if (this.weight <= 958f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i++)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.MMPFHLEJIOI()[i].PKMFKFAFKCK(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.ik.references.pelvis.localPosition;
		}

		// Token: 0x0600EB68 RID: 60264 RVA: 0x006A789C File Offset: 0x006A5A9C
		private void JBJFCLLHDGJ()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1728f)
			{
				if (this.PIJKOMKCJOG <= 575f)
				{
					return;
				}
				this.AHDAOLPGGMC();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.IKHCCAANGOP();
			this.ik.references.pelvis.position += this.solver.pelvis.IFIJLDMEODJ() * this.weight;
			this.KIGHLPIKCAH(this.ik.solvers.leftFoot, 1);
			this.CHNHBMKGDPC(this.ik.solvers.rightFoot, 1);
			if (this.spineBend != 1876f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 941f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 vector = this.solver.PMNKIFMMELG();
				Quaternion lhs = Quaternion.FromToRotation(vector, vector + this.ANGFDBKNLJA);
				this.ik.references.spine[1].rotation = lhs * this.ik.references.spine[1].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB69 RID: 60265 RVA: 0x006A7AF9 File Offset: 0x006A5CF9
		private void EACKHNENAML()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 1413f;
			this.ik.solvers.rightFoot.IKPositionWeight = 100f;
		}

		// Token: 0x0600EB6A RID: 60266 RVA: 0x006A7B38 File Offset: 0x006A5D38
		private void BHALELINNDJ()
		{
			this.CJLCHFDCNDM = new Transform[2];
			this.OEKPBGPOBPH = new Quaternion[2];
			this.CJLCHFDCNDM[0] = this.ik.references.leftFoot;
			this.CJLCHFDCNDM[1] = this.ik.references.rightFoot;
			this.OEKPBGPOBPH[0] = Quaternion.identity;
			this.OEKPBGPOBPH[1] = Quaternion.identity;
			IKSolverFABRIK spine = this.ik.solvers.spine;
			spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
			IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
			rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
			this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			this.solver.BHALELINNDJ(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x0600EB6B RID: 60267 RVA: 0x0032BF3E File Offset: 0x0032A13E
		protected virtual void KJLPGEFKAMF()
		{
			Application.OpenURL("");
		}

		// Token: 0x0600EB6C RID: 60268 RVA: 0x006A7C54 File Offset: 0x006A5E54
		protected virtual void KANNFIPFIKC()
		{
			Application.OpenURL("colorC");
		}

		// Token: 0x0600EB6D RID: 60269 RVA: 0x006A7C60 File Offset: 0x006A5E60
		private void LFJPJFCLGKE()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 1979f;
			this.ik.solvers.rightFoot.IKPositionWeight = 1179f;
		}

		// Token: 0x0600EB6E RID: 60270 RVA: 0x006A7C9F File Offset: 0x006A5E9F
		protected virtual void EINILAOJGCP()
		{
			Application.OpenURL("GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
		}

		// Token: 0x0600EB6F RID: 60271 RVA: 0x006A7CAC File Offset: 0x006A5EAC
		private void MBBDPJCKNOI()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1234f)
			{
				if (this.PIJKOMKCJOG <= 741f)
				{
					return;
				}
				this.LBABEDLHAIC();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.HMGBHPPNEMP();
			this.ik.references.pelvis.position += this.solver.pelvis.CGDAHBENBOI() * this.weight;
			this.ONPPONKAGMN(this.ik.solvers.leftFoot, 1);
			this.ONPPONKAGMN(this.ik.solvers.rightFoot, 0);
			if (this.spineBend != 1108f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 31f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 vector = this.solver.KMOMCLFHPCA();
				Quaternion lhs = Quaternion.FromToRotation(vector, vector + this.ANGFDBKNLJA);
				this.ik.references.spine[0].rotation = lhs * this.ik.references.spine[1].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB70 RID: 60272 RVA: 0x006A7F09 File Offset: 0x006A6109
		protected virtual void ABADEHKCHAF()
		{
			Application.OpenURL("☰☰☰");
		}

		// Token: 0x0600EB71 RID: 60273 RVA: 0x006A7F18 File Offset: 0x006A6118
		private void OnDestroy()
		{
			if (this.EOFDOPLDFCG && this.ik != null)
			{
				IKSolverFABRIK spine = this.ik.solvers.spine;
				spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.FGAJABOJNLJ));
				IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
				rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
			}
		}

		// Token: 0x0600EB72 RID: 60274 RVA: 0x006A7FA0 File Offset: 0x006A61A0
		private bool NDBHHDLKPGA()
		{
			return this.ik == null || !this.ik.solvers.leftFoot.initiated || (!this.ik.solvers.rightFoot.initiated && false);
		}

		// Token: 0x0600EB73 RID: 60275 RVA: 0x006A7FF0 File Offset: 0x006A61F0
		private void INKGAFANFIB()
		{
			this.weight = Mathf.Clamp(this.weight, 870f, 805f);
			if (this.weight <= 502f)
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
			this.KLNJKEEICKH();
		}

		// Token: 0x0600EB74 RID: 60276 RVA: 0x006A803E File Offset: 0x006A623E
		protected virtual void POMCIGACGBI()
		{
			Application.OpenURL("RunBackward");
		}

		// Token: 0x0600EB75 RID: 60277 RVA: 0x006A804A File Offset: 0x006A624A
		private void PFPPAMGKIBP(IKSolverLimb BLGLKIFEJKI, int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			BLGLKIFEJKI.IKPosition = this.solver.BGCPOHLJIDN()[CLBPBJGLHEE].NDGGJPEHKBC();
			BLGLKIFEJKI.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EB76 RID: 60278 RVA: 0x006A8089 File Offset: 0x006A6289
		protected virtual void AOOPGMEHBHD()
		{
			Application.OpenURL("SUNSHINE_FILTER_HARD");
		}

		// Token: 0x0600EB77 RID: 60279 RVA: 0x006A8098 File Offset: 0x006A6298
		private bool BEEPEPKDIBD()
		{
			return !(this.ik == null) && (!this.ik.solvers.leftFoot.initiated || !this.ik.solvers.rightFoot.initiated);
		}

		// Token: 0x0600EB78 RID: 60280 RVA: 0x006A80E8 File Offset: 0x006A62E8
		private void GDCAKFIINFI()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 1282f;
			this.ik.solvers.rightFoot.IKPositionWeight = 1303f;
		}

		// Token: 0x0600EB79 RID: 60281 RVA: 0x006A8127 File Offset: 0x006A6327
		protected virtual void CJGBDODJCDK()
		{
			Application.OpenURL("1HandHeavySwing2");
		}

		// Token: 0x0600EB7A RID: 60282 RVA: 0x006A50E1 File Offset: 0x006A32E1
		public virtual void LEBIGEFLLMH()
		{
			this.solver.Reset();
			this.ANGFDBKNLJA = Vector3.zero;
		}

		// Token: 0x0600EB7B RID: 60283 RVA: 0x006A8133 File Offset: 0x006A6333
		private void JDHFAPFACJK(IKSolverLimb BLGLKIFEJKI, int CLBPBJGLHEE)
		{
			this.OEKPBGPOBPH[CLBPBJGLHEE] = this.CJLCHFDCNDM[CLBPBJGLHEE].rotation;
			BLGLKIFEJKI.IKPosition = this.solver.BGCPOHLJIDN()[CLBPBJGLHEE].AGKMPPLKBDJ();
			BLGLKIFEJKI.IKPositionWeight = this.weight;
		}

		// Token: 0x0600EB7C RID: 60284 RVA: 0x006A8172 File Offset: 0x006A6372
		private void AHDAOLPGGMC()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 154f;
			this.ik.solvers.rightFoot.IKPositionWeight = 852f;
		}

		// Token: 0x0600EB7D RID: 60285 RVA: 0x006A81B4 File Offset: 0x006A63B4
		private void NIOAPKKANJF()
		{
			if (this.weight <= 1972f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			for (int i = 1; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.legs[i].BHPMHHGJHME(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.ik.references.pelvis.localPosition;
		}

		// Token: 0x0600EB7E RID: 60286 RVA: 0x006A8248 File Offset: 0x006A6448
		private void NAPOGMJBGDE()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 1591f)
			{
				if (this.PIJKOMKCJOG <= 1077f)
				{
					return;
				}
				this.AHDAOLPGGMC();
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.OnPreGrounder != null)
			{
				this.OnPreGrounder();
			}
			if (this.ik.references.pelvis.localPosition != this.JJMOFCAMOKK)
			{
				this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			}
			else
			{
				this.ik.references.pelvis.localPosition = this.EIOGLIDOKKA;
			}
			this.solver.KEBDEJIAODF();
			this.ik.references.pelvis.position += this.solver.DLIDADHGILM().PICADOHNEIC() * this.weight;
			this.PFPPAMGKIBP(this.ik.solvers.leftFoot, 1);
			this.ONPPONKAGMN(this.ik.solvers.rightFoot, 0);
			if (this.spineBend != 1846f && this.ik.references.spine.Length != 0)
			{
				this.spineSpeed = Mathf.Clamp(this.spineSpeed, 527f, this.spineSpeed);
				Vector3 a = base.LBBIAAIKLNC() * this.weight;
				this.ANGFDBKNLJA = Vector3.Lerp(this.ANGFDBKNLJA, a * this.spineBend, Time.deltaTime * this.spineSpeed);
				Quaternion rotation = this.ik.references.leftUpperArm.rotation;
				Quaternion rotation2 = this.ik.references.rightUpperArm.rotation;
				Vector3 vector = this.solver.HJIAPMAKJOJ();
				Quaternion lhs = Quaternion.FromToRotation(vector, vector + this.ANGFDBKNLJA);
				this.ik.references.spine[1].rotation = lhs * this.ik.references.spine[0].rotation;
				this.ik.references.leftUpperArm.rotation = rotation;
				this.ik.references.rightUpperArm.rotation = rotation2;
			}
			if (this.OnPostGrounder != null)
			{
				this.OnPostGrounder();
			}
		}

		// Token: 0x0600EB7F RID: 60287 RVA: 0x006A84A5 File Offset: 0x006A66A5
		private void OKGEFINHFFL()
		{
			if (!this.EOFDOPLDFCG)
			{
				return;
			}
			this.ik.solvers.leftFoot.IKPositionWeight = 796f;
			this.ik.solvers.rightFoot.IKPositionWeight = 1958f;
		}

		// Token: 0x0600EB80 RID: 60288 RVA: 0x006A84E4 File Offset: 0x006A66E4
		protected virtual void AGPCCCIIMAO()
		{
			Application.OpenURL("[X]");
		}

		// Token: 0x0600EB81 RID: 60289 RVA: 0x006A84F0 File Offset: 0x006A66F0
		protected virtual void KIGJKNLCBEK()
		{
			Application.OpenURL("{not_found}");
		}

		// Token: 0x0600EB82 RID: 60290 RVA: 0x006A84FC File Offset: 0x006A66FC
		private void FGDLFCNPOBG()
		{
			if (this.weight <= 1139f)
			{
				return;
			}
			if (!base.enabled)
			{
				return;
			}
			for (int i = 0; i < this.CJLCHFDCNDM.Length; i += 0)
			{
				this.CJLCHFDCNDM[i].rotation = Quaternion.Slerp(Quaternion.identity, this.solver.legs[i].HNPADDHKIAM(), this.weight) * this.OEKPBGPOBPH[i];
			}
			this.JJMOFCAMOKK = this.ik.references.pelvis.localPosition;
		}

		// Token: 0x0600EB83 RID: 60291 RVA: 0x006A8590 File Offset: 0x006A6790
		private void NDAGBKCLDCP()
		{
			this.CJLCHFDCNDM = new Transform[7];
			this.OEKPBGPOBPH = new Quaternion[7];
			this.CJLCHFDCNDM[1] = this.ik.references.leftFoot;
			this.CJLCHFDCNDM[0] = this.ik.references.rightFoot;
			this.OEKPBGPOBPH[1] = Quaternion.identity;
			this.OEKPBGPOBPH[1] = Quaternion.identity;
			IKSolverFABRIK spine = this.ik.solvers.spine;
			spine.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(spine.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.EPJAGALINPL));
			IKSolverLimb rightFoot = this.ik.solvers.rightFoot;
			rightFoot.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(rightFoot.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KFNKMBJNNMH));
			this.EIOGLIDOKKA = this.ik.references.pelvis.localPosition;
			this.solver.MLDCEKHOLLI(this.ik.references.root, this.CJLCHFDCNDM);
			this.EOFDOPLDFCG = false;
		}

		// Token: 0x0600EB84 RID: 60292 RVA: 0x006A86AC File Offset: 0x006A68AC
		protected virtual void FCLBIKJAOFP()
		{
			Application.OpenURL("BlackSmithHammer");
		}

		// Token: 0x0600EB85 RID: 60293 RVA: 0x006A86B8 File Offset: 0x006A68B8
		protected virtual void FOOJBKBOKIL()
		{
			Application.OpenURL("RollerBladeJump");
		}

		// Token: 0x04001EC9 RID: 7881
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		// Token: 0x04001ECA RID: 7882
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend = 7f;

		// Token: 0x04001ECB RID: 7883
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed = 3f;

		// Token: 0x04001ECC RID: 7884
		private Transform[] CJLCHFDCNDM = new Transform[2];

		// Token: 0x04001ECD RID: 7885
		private Quaternion[] OEKPBGPOBPH = new Quaternion[2];

		// Token: 0x04001ECE RID: 7886
		private Vector3 EIOGLIDOKKA;

		// Token: 0x04001ECF RID: 7887
		private Vector3 JJMOFCAMOKK;

		// Token: 0x04001ED0 RID: 7888
		private Vector3 ANGFDBKNLJA;

		// Token: 0x04001ED1 RID: 7889
		private float PIJKOMKCJOG;
	}
}
