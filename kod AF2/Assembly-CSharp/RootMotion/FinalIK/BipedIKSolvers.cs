using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200043A RID: 1082
	[Serializable]
	public class BipedIKSolvers
	{
		// Token: 0x0600E8D6 RID: 59606 RVA: 0x00699F94 File Offset: 0x00698194
		public IKSolver[] ENBJKODOPKE()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 3))
			{
				IKSolver[] array = new IKSolver[7];
				array[0] = this.leftFoot;
				array[1] = this.rightFoot;
				array[3] = this.leftHand;
				array[5] = this.rightHand;
				array[7] = this.spine;
				array[5] = this.lookAt;
				array[0] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8D7 RID: 59607 RVA: 0x0069A010 File Offset: 0x00698210
		public IKSolver[] BFLHAEGMLMM()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 1))
			{
				IKSolver[] array = new IKSolver[6];
				array[0] = this.leftFoot;
				array[0] = this.rightFoot;
				array[5] = this.leftHand;
				array[6] = this.rightHand;
				array[1] = this.spine;
				array[3] = this.lookAt;
				array[7] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8D8 RID: 59608 RVA: 0x0069A08C File Offset: 0x0069828C
		public void FBNEDNFFMGG(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.DJEDNIBFHJC(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.GGPNLFMBAIM(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.OPOOMPAPADK(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.AOANEPNJLJN(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.EKGACACOKCG(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.NHIJFLADGAJ(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = AvatarIKGoal.RightHand;
			this.rightHand.goal = AvatarIKGoal.LeftFoot;
		}

		// Token: 0x0600E8D9 RID: 59609 RVA: 0x0069A1B0 File Offset: 0x006983B0
		public void DECIGIFCPJG(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.DNPHIDGDLIA(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.DNPHIDGDLIA(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.DNPHIDGDLIA(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.DNPHIDGDLIA(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = AvatarIKGoal.LeftHand;
			this.rightHand.goal = AvatarIKGoal.RightHand;
		}

		// Token: 0x0600E8DA RID: 59610 RVA: 0x0069A2D4 File Offset: 0x006984D4
		public void CNBIEHAMEEB(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.OPOOMPAPADK(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.AOANEPNJLJN(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.AOANEPNJLJN(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.AOANEPNJLJN(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.FEKEPLPLCKD(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.CFDLGCFBLJH(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.RightFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = AvatarIKGoal.LeftHand;
			this.rightHand.goal = (AvatarIKGoal)6;
		}

		// Token: 0x0600E8DB RID: 59611 RVA: 0x0069A3F8 File Offset: 0x006985F8
		public IKSolverLimb[] LMEEEBGPNOC()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 3))
			{
				IKSolverLimb[] array = new IKSolverLimb[5];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[4] = this.leftHand;
				array[8] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E8DC RID: 59612 RVA: 0x0069A458 File Offset: 0x00698658
		public IKSolver[] JPADINBIKKJ()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 4))
			{
				IKSolver[] array = new IKSolver[6];
				array[0] = this.leftFoot;
				array[0] = this.rightFoot;
				array[2] = this.leftHand;
				array[2] = this.rightHand;
				array[8] = this.spine;
				array[6] = this.lookAt;
				array[6] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8DD RID: 59613 RVA: 0x0069A4D4 File Offset: 0x006986D4
		public IKSolverLimb[] FJAPGAMBMGB()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 7))
			{
				IKSolverLimb[] array = new IKSolverLimb[5];
				array[1] = this.leftFoot;
				array[0] = this.rightFoot;
				array[2] = this.leftHand;
				array[3] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E8DE RID: 59614 RVA: 0x0069A534 File Offset: 0x00698734
		public IKSolver[] LMEOFMDFIJG()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 0))
			{
				IKSolver[] array = new IKSolver[7];
				array[1] = this.leftFoot;
				array[0] = this.rightFoot;
				array[6] = this.leftHand;
				array[3] = this.rightHand;
				array[6] = this.spine;
				array[2] = this.lookAt;
				array[1] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8DF RID: 59615 RVA: 0x0069A5B0 File Offset: 0x006987B0
		public void OMCGAACEGDE(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.GGPNLFMBAIM(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.AOANEPNJLJN(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.DNPHIDGDLIA(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.DNPHIDGDLIA(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.CFDLGCFBLJH(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.EKGACACOKCG(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.RightFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = (AvatarIKGoal)5;
			this.rightHand.goal = AvatarIKGoal.LeftFoot;
		}

		// Token: 0x0600E8E0 RID: 59616 RVA: 0x0069A6D4 File Offset: 0x006988D4
		public IKSolverLimb[] HKJLNNHJICJ()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 3))
			{
				IKSolverLimb[] array = new IKSolverLimb[3];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[7] = this.leftHand;
				array[1] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E8E1 RID: 59617 RVA: 0x0069A734 File Offset: 0x00698934
		public IKSolver[] HJPHGAGOGBL()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 8))
			{
				IKSolver[] array = new IKSolver[]
				{
					this.leftFoot
				};
				array[0] = this.rightFoot;
				array[1] = this.leftHand;
				array[2] = this.rightHand;
				array[6] = this.spine;
				array[0] = this.lookAt;
				array[7] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8E2 RID: 59618 RVA: 0x0069A7B0 File Offset: 0x006989B0
		public IKSolver[] PLFDGKILMHH()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 5))
			{
				IKSolver[] array = new IKSolver[7];
				array[1] = this.leftFoot;
				array[0] = this.rightFoot;
				array[5] = this.leftHand;
				array[6] = this.rightHand;
				array[8] = this.spine;
				array[1] = this.lookAt;
				array[7] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8E3 RID: 59619 RVA: 0x0069A82C File Offset: 0x00698A2C
		public void OKCEKGANANA(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.GGPNLFMBAIM(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.GGPNLFMBAIM(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.OPOOMPAPADK(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.GGPNLFMBAIM(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.NHIJFLADGAJ(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.DEBAKKBPHHG(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.LeftFoot;
			this.leftHand.goal = AvatarIKGoal.LeftHand;
			this.rightHand.goal = (AvatarIKGoal)4;
		}

		// Token: 0x0600E8E4 RID: 59620 RVA: 0x0069A950 File Offset: 0x00698B50
		public IKSolver[] JJJGMLFJLDP()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 6))
			{
				IKSolver[] array = new IKSolver[8];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[4] = this.leftHand;
				array[2] = this.rightHand;
				array[7] = this.spine;
				array[0] = this.lookAt;
				array[5] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8E5 RID: 59621 RVA: 0x0069A9CC File Offset: 0x00698BCC
		public IKSolverLimb[] OCNLLBPGKJL()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 8))
			{
				IKSolverLimb[] array = new IKSolverLimb[3];
				array[0] = this.leftFoot;
				array[1] = this.rightFoot;
				array[7] = this.leftHand;
				array[8] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E8E6 RID: 59622 RVA: 0x0069AA2C File Offset: 0x00698C2C
		public void IAKDDLFJHBL(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.DJEDNIBFHJC(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.OPOOMPAPADK(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.DNPHIDGDLIA(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.DNPHIDGDLIA(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.DEBAKKBPHHG(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.LeftFoot;
			this.leftHand.goal = AvatarIKGoal.LeftFoot;
			this.rightHand.goal = AvatarIKGoal.LeftFoot;
		}

		// Token: 0x0600E8E7 RID: 59623 RVA: 0x0069AB50 File Offset: 0x00698D50
		public IKSolver[] DIHAJCLOJFK()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 4))
			{
				IKSolver[] array = new IKSolver[1];
				array[1] = this.leftFoot;
				array[0] = this.rightFoot;
				array[0] = this.leftHand;
				array[4] = this.rightHand;
				array[0] = this.spine;
				array[1] = this.lookAt;
				array[5] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8E8 RID: 59624 RVA: 0x0069ABCC File Offset: 0x00698DCC
		public void POAHPAMPEID(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.AOANEPNJLJN(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.GGPNLFMBAIM(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.AOANEPNJLJN(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.AOANEPNJLJN(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.FEKEPLPLCKD(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.NFCENJBLLCL(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.DBIDNALGODP(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.RightFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = (AvatarIKGoal)4;
			this.rightHand.goal = AvatarIKGoal.RightHand;
		}

		// Token: 0x0600E8E9 RID: 59625 RVA: 0x0069ACF0 File Offset: 0x00698EF0
		public IKSolverLimb[] EHDPJEMLLCP()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 7))
			{
				IKSolverLimb[] array = new IKSolverLimb[7];
				array[0] = this.leftFoot;
				array[0] = this.rightFoot;
				array[8] = this.leftHand;
				array[4] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E8EA RID: 59626 RVA: 0x0069AD50 File Offset: 0x00698F50
		public void GNAJHDOBCKB(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.DNPHIDGDLIA(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.DNPHIDGDLIA(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.AOANEPNJLJN(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.DNPHIDGDLIA(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.GDOKEMADLAP(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.NFCENJBLLCL(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = (AvatarIKGoal)7;
			this.rightHand.goal = AvatarIKGoal.LeftFoot;
		}

		// Token: 0x0600E8EB RID: 59627 RVA: 0x0069AE74 File Offset: 0x00699074
		public IKSolver[] GALDFMEPPMJ()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 8))
			{
				IKSolver[] array = new IKSolver[5];
				array[1] = this.leftFoot;
				array[0] = this.rightFoot;
				array[1] = this.leftHand;
				array[2] = this.rightHand;
				array[4] = this.spine;
				array[3] = this.lookAt;
				array[7] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8EC RID: 59628 RVA: 0x0069AEF0 File Offset: 0x006990F0
		public void ELMOAMFGLNC(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.GGPNLFMBAIM(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.GGPNLFMBAIM(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.AOANEPNJLJN(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.DNPHIDGDLIA(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.CFDLGCFBLJH(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.NFCENJBLLCL(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.NHIJFLADGAJ(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.LeftFoot;
			this.leftHand.goal = (AvatarIKGoal)5;
			this.rightHand.goal = (AvatarIKGoal)4;
		}

		// Token: 0x0600E8ED RID: 59629 RVA: 0x0069B014 File Offset: 0x00699214
		public IKSolverLimb[] MPFOMCNOGEI()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 5))
			{
				IKSolverLimb[] array = new IKSolverLimb[4];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[7] = this.leftHand;
				array[2] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E8EE RID: 59630 RVA: 0x0069B074 File Offset: 0x00699274
		public IKSolver[] BONKDJKJAKJ()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 5))
			{
				IKSolver[] array = new IKSolver[5];
				array[1] = this.leftFoot;
				array[0] = this.rightFoot;
				array[0] = this.leftHand;
				array[4] = this.rightHand;
				array[0] = this.spine;
				array[6] = this.lookAt;
				array[6] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8EF RID: 59631 RVA: 0x0069B0F0 File Offset: 0x006992F0
		public IKSolver[] KHMIMOMCEFH()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 0))
			{
				IKSolver[] array = new IKSolver[2];
				array[0] = this.leftFoot;
				array[0] = this.rightFoot;
				array[1] = this.leftHand;
				array[1] = this.rightHand;
				array[0] = this.spine;
				array[7] = this.lookAt;
				array[4] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8F0 RID: 59632 RVA: 0x0069B16C File Offset: 0x0069936C
		public IKSolver[] NBCAENLLDLM()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 6))
			{
				IKSolver[] array = new IKSolver[5];
				array[1] = this.leftFoot;
				array[0] = this.rightFoot;
				array[7] = this.leftHand;
				array[3] = this.rightHand;
				array[0] = this.spine;
				array[2] = this.lookAt;
				array[7] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8F1 RID: 59633 RVA: 0x0069B1E8 File Offset: 0x006993E8
		public void DFIMDLDFNEM(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.DJEDNIBFHJC(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.DNPHIDGDLIA(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.DJEDNIBFHJC(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.DJEDNIBFHJC(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.CFDLGCFBLJH(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.FEKEPLPLCKD(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = (AvatarIKGoal)8;
			this.rightHand.goal = AvatarIKGoal.LeftHand;
		}

		// Token: 0x0600E8F2 RID: 59634 RVA: 0x0069B30C File Offset: 0x0069950C
		public IKSolverLimb[] AMNIKFGJLKD()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 8))
			{
				IKSolverLimb[] array = new IKSolverLimb[6];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[0] = this.leftHand;
				array[6] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600E8F3 RID: 59635 RVA: 0x0069B36C File Offset: 0x0069956C
		public IKSolverLimb[] limbs
		{
			get
			{
				if (this._limbs == null || (this._limbs != null && this._limbs.Length != 4))
				{
					this._limbs = new IKSolverLimb[]
					{
						this.leftFoot,
						this.rightFoot,
						this.leftHand,
						this.rightHand
					};
				}
				return this._limbs;
			}
		}

		// Token: 0x0600E8F4 RID: 59636 RVA: 0x0069B3CC File Offset: 0x006995CC
		public IKSolver[] NBCCPKCLFJE()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 3))
			{
				IKSolver[] array = new IKSolver[5];
				array[0] = this.leftFoot;
				array[1] = this.rightFoot;
				array[3] = this.leftHand;
				array[8] = this.rightHand;
				array[5] = this.spine;
				array[3] = this.lookAt;
				array[5] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8F5 RID: 59637 RVA: 0x0069B448 File Offset: 0x00699648
		public IKSolver[] LLEFNNDFBDE()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 8))
			{
				IKSolver[] array = new IKSolver[7];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[6] = this.leftHand;
				array[2] = this.rightHand;
				array[8] = this.spine;
				array[7] = this.lookAt;
				array[2] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8F6 RID: 59638 RVA: 0x0069B4C4 File Offset: 0x006996C4
		public IKSolverLimb[] KBMCKCHDCNP()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 3))
			{
				IKSolverLimb[] array = new IKSolverLimb[4];
				array[0] = this.leftFoot;
				array[0] = this.rightFoot;
				array[3] = this.leftHand;
				array[4] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E8F7 RID: 59639 RVA: 0x0069B524 File Offset: 0x00699724
		public void BBBBMPKKJHF(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.DNPHIDGDLIA(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.DJEDNIBFHJC(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.DNPHIDGDLIA(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.DNPHIDGDLIA(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.NHIJFLADGAJ(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.GDOKEMADLAP(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = AvatarIKGoal.LeftHand;
			this.rightHand.goal = AvatarIKGoal.LeftFoot;
		}

		// Token: 0x0600E8F8 RID: 59640 RVA: 0x0069B648 File Offset: 0x00699848
		public IKSolverLimb[] COOFNADNEJD()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 5))
			{
				IKSolverLimb[] array = new IKSolverLimb[3];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[1] = this.leftHand;
				array[3] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E8F9 RID: 59641 RVA: 0x0069B6A8 File Offset: 0x006998A8
		public void FEAMEPFPMNC(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.AOANEPNJLJN(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.DNPHIDGDLIA(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.AOANEPNJLJN(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.DJEDNIBFHJC(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.FEKEPLPLCKD(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.FEKEPLPLCKD(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = (AvatarIKGoal)7;
			this.rightHand.goal = (AvatarIKGoal)5;
		}

		// Token: 0x0600E8FA RID: 59642 RVA: 0x0069B7CC File Offset: 0x006999CC
		public void DCIPDHEKNFP(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.AOANEPNJLJN(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.DNPHIDGDLIA(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.DJEDNIBFHJC(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.GGPNLFMBAIM(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.DEBAKKBPHHG(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.NFCENJBLLCL(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.FEKEPLPLCKD(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.RightFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = (AvatarIKGoal)8;
			this.rightHand.goal = AvatarIKGoal.LeftFoot;
		}

		// Token: 0x0600E8FB RID: 59643 RVA: 0x0069B8F0 File Offset: 0x00699AF0
		public IKSolver[] NFIIMFAJOEH()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 3))
			{
				IKSolver[] array = new IKSolver[4];
				array[0] = this.leftFoot;
				array[0] = this.rightFoot;
				array[4] = this.leftHand;
				array[5] = this.rightHand;
				array[3] = this.spine;
				array[5] = this.lookAt;
				array[7] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E8FC RID: 59644 RVA: 0x0069B96C File Offset: 0x00699B6C
		public void IKKEKHNACND(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.DNPHIDGDLIA(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.DNPHIDGDLIA(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.DJEDNIBFHJC(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.AOANEPNJLJN(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.EKGACACOKCG(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.NFCENJBLLCL(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.GDOKEMADLAP(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.RightFoot;
			this.rightFoot.goal = AvatarIKGoal.LeftFoot;
			this.leftHand.goal = (AvatarIKGoal)4;
			this.rightHand.goal = AvatarIKGoal.RightHand;
		}

		// Token: 0x0600E8FD RID: 59645 RVA: 0x0069BA90 File Offset: 0x00699C90
		public IKSolverLimb[] LBHJFINAMKL()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 6))
			{
				IKSolverLimb[] array = new IKSolverLimb[0];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[7] = this.leftHand;
				array[4] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E8FE RID: 59646 RVA: 0x0069BAF0 File Offset: 0x00699CF0
		public IKSolverLimb[] HECNIFEOMLD()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 5))
			{
				IKSolverLimb[] array = new IKSolverLimb[4];
				array[0] = this.leftFoot;
				array[0] = this.rightFoot;
				array[4] = this.leftHand;
				array[1] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E8FF RID: 59647 RVA: 0x0069BB50 File Offset: 0x00699D50
		public void LBFFEPMKIBA(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.AOANEPNJLJN(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.DNPHIDGDLIA(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.AOANEPNJLJN(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.GGPNLFMBAIM(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.NFCENJBLLCL(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.DBIDNALGODP(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.RightFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = (AvatarIKGoal)6;
			this.rightHand.goal = AvatarIKGoal.RightHand;
		}

		// Token: 0x0600E900 RID: 59648 RVA: 0x0069BC74 File Offset: 0x00699E74
		public IKSolverLimb[] KFMLOEDDCHD()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 8))
			{
				IKSolverLimb[] array = new IKSolverLimb[]
				{
					this.leftFoot,
					this.rightFoot,
					null,
					null,
					null,
					this.leftHand
				};
				array[5] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E901 RID: 59649 RVA: 0x0069BCD4 File Offset: 0x00699ED4
		public void AGCNJCFGHNE(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.OPOOMPAPADK(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.AOANEPNJLJN(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.OPOOMPAPADK(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.GGPNLFMBAIM(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.EKGACACOKCG(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.NFCENJBLLCL(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.GDOKEMADLAP(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.RightFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = AvatarIKGoal.RightHand;
			this.rightHand.goal = AvatarIKGoal.RightHand;
		}

		// Token: 0x0600E902 RID: 59650 RVA: 0x0069BDF8 File Offset: 0x00699FF8
		public IKSolverLimb[] MHOGIPCHKGJ()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 3))
			{
				IKSolverLimb[] array = new IKSolverLimb[6];
				array[0] = this.leftFoot;
				array[0] = this.rightFoot;
				array[3] = this.leftHand;
				array[2] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E903 RID: 59651 RVA: 0x0069BE58 File Offset: 0x0069A058
		public IKSolverLimb[] JFJJPOIEAHL()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 7))
			{
				IKSolverLimb[] array = new IKSolverLimb[7];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[7] = this.leftHand;
				array[2] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E904 RID: 59652 RVA: 0x0069BEB8 File Offset: 0x0069A0B8
		public IKSolver[] IKEMDOCPFBI()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 2))
			{
				IKSolver[] array = new IKSolver[7];
				array[0] = this.leftFoot;
				array[1] = this.rightFoot;
				array[7] = this.leftHand;
				array[0] = this.rightHand;
				array[8] = this.spine;
				array[2] = this.lookAt;
				array[4] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E905 RID: 59653 RVA: 0x0069BF34 File Offset: 0x0069A134
		public void HMODNJCJLIH(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.DJEDNIBFHJC(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.GGPNLFMBAIM(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.DJEDNIBFHJC(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.GGPNLFMBAIM(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.DEBAKKBPHHG(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.DBIDNALGODP(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = AvatarIKGoal.RightHand;
			this.rightHand.goal = (AvatarIKGoal)4;
		}

		// Token: 0x0600E906 RID: 59654 RVA: 0x0069C058 File Offset: 0x0069A258
		public IKSolver[] KJMDJDFBOLP()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 3))
			{
				IKSolver[] array = new IKSolver[]
				{
					this.leftFoot,
					this.rightFoot,
					null,
					null,
					null,
					this.leftHand
				};
				array[4] = this.rightHand;
				array[1] = this.spine;
				array[2] = this.lookAt;
				array[7] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E907 RID: 59655 RVA: 0x0069C0D4 File Offset: 0x0069A2D4
		public void PEFFKDIJFBE(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.AOANEPNJLJN(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.AOANEPNJLJN(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.OPOOMPAPADK(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.DNPHIDGDLIA(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.DBIDNALGODP(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.CFDLGCFBLJH(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.RightFoot;
			this.leftHand.goal = (AvatarIKGoal)5;
			this.rightHand.goal = AvatarIKGoal.LeftFoot;
		}

		// Token: 0x0600E908 RID: 59656 RVA: 0x0069C1F8 File Offset: 0x0069A3F8
		public IKSolverLimb[] ODOHJNILJMK()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 4))
			{
				IKSolverLimb[] array = new IKSolverLimb[]
				{
					null,
					this.leftFoot
				};
				array[1] = this.rightFoot;
				array[8] = this.leftHand;
				array[1] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E909 RID: 59657 RVA: 0x0069C258 File Offset: 0x0069A458
		public IKSolver[] AIPDIGNLMHL()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 5))
			{
				IKSolver[] array = new IKSolver[4];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[7] = this.leftHand;
				array[1] = this.rightHand;
				array[7] = this.spine;
				array[0] = this.lookAt;
				array[2] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E90B RID: 59659 RVA: 0x0069C344 File Offset: 0x0069A544
		public void FIMKOKPADFM(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.AOANEPNJLJN(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.OPOOMPAPADK(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.AOANEPNJLJN(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.DJEDNIBFHJC(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.NHIJFLADGAJ(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.NFCENJBLLCL(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.FEKEPLPLCKD(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.LeftFoot;
			this.leftHand.goal = (AvatarIKGoal)5;
			this.rightHand.goal = AvatarIKGoal.RightFoot;
		}

		// Token: 0x0600E90C RID: 59660 RVA: 0x0069C468 File Offset: 0x0069A668
		public void PGDJAPLKKNN(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.DNPHIDGDLIA(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.OPOOMPAPADK(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.OPOOMPAPADK(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.DNPHIDGDLIA(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.EKGACACOKCG(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.NFCENJBLLCL(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.CFDLGCFBLJH(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.RightFoot;
			this.rightFoot.goal = AvatarIKGoal.LeftFoot;
			this.leftHand.goal = (AvatarIKGoal)8;
			this.rightHand.goal = AvatarIKGoal.RightFoot;
		}

		// Token: 0x0600E90D RID: 59661 RVA: 0x0069C58C File Offset: 0x0069A78C
		public IKSolverLimb[] GBKIHMBNCCA()
		{
			if (this._limbs == null || (this._limbs != null && this._limbs.Length != 4))
			{
				IKSolverLimb[] array = new IKSolverLimb[1];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[0] = this.leftHand;
				array[1] = this.rightHand;
				this._limbs = array;
			}
			return this._limbs;
		}

		// Token: 0x0600E90E RID: 59662 RVA: 0x0069C5EC File Offset: 0x0069A7EC
		public void JGAHJOCCCFI(BipedReferences LJPKBBNNOIC)
		{
			this.leftHand.AOANEPNJLJN(LJPKBBNNOIC.leftUpperArm, LJPKBBNNOIC.leftForearm, LJPKBBNNOIC.leftHand, LJPKBBNNOIC.root);
			this.rightHand.DJEDNIBFHJC(LJPKBBNNOIC.rightUpperArm, LJPKBBNNOIC.rightForearm, LJPKBBNNOIC.rightHand, LJPKBBNNOIC.root);
			this.leftFoot.DJEDNIBFHJC(LJPKBBNNOIC.leftThigh, LJPKBBNNOIC.leftCalf, LJPKBBNNOIC.leftFoot, LJPKBBNNOIC.root);
			this.rightFoot.OPOOMPAPADK(LJPKBBNNOIC.rightThigh, LJPKBBNNOIC.rightCalf, LJPKBBNNOIC.rightFoot, LJPKBBNNOIC.root);
			this.spine.GDOKEMADLAP(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.lookAt.DNPHIDGDLIA(LJPKBBNNOIC.spine, LJPKBBNNOIC.head, LJPKBBNNOIC.eyes, LJPKBBNNOIC.root);
			this.aim.DBIDNALGODP(LJPKBBNNOIC.spine, LJPKBBNNOIC.root);
			this.leftFoot.goal = AvatarIKGoal.LeftFoot;
			this.rightFoot.goal = AvatarIKGoal.LeftFoot;
			this.leftHand.goal = (AvatarIKGoal)4;
			this.rightHand.goal = AvatarIKGoal.RightHand;
		}

		// Token: 0x0600E90F RID: 59663 RVA: 0x0069C710 File Offset: 0x0069A910
		public IKSolver[] HEGHDJKDCPJ()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 0))
			{
				IKSolver[] array = new IKSolver[]
				{
					this.leftFoot
				};
				array[0] = this.rightFoot;
				array[5] = this.leftHand;
				array[0] = this.rightHand;
				array[3] = this.spine;
				array[5] = this.lookAt;
				array[0] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x0600E910 RID: 59664 RVA: 0x0069C78C File Offset: 0x0069A98C
		public IKSolver[] LGEOFOOPNDD()
		{
			if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 3))
			{
				IKSolver[] array = new IKSolver[0];
				array[1] = this.leftFoot;
				array[1] = this.rightFoot;
				array[5] = this.leftHand;
				array[3] = this.rightHand;
				array[4] = this.spine;
				array[7] = this.lookAt;
				array[6] = this.aim;
				this._ikSolvers = array;
			}
			return this._ikSolvers;
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600E911 RID: 59665 RVA: 0x0069C808 File Offset: 0x0069AA08
		public IKSolver[] ikSolvers
		{
			get
			{
				if (this._ikSolvers == null || (this._ikSolvers != null && this._ikSolvers.Length != 7))
				{
					this._ikSolvers = new IKSolver[]
					{
						this.leftFoot,
						this.rightFoot,
						this.leftHand,
						this.rightHand,
						this.spine,
						this.lookAt,
						this.aim
					};
				}
				return this._ikSolvers;
			}
		}

		// Token: 0x04001E97 RID: 7831
		public IKSolverLimb leftFoot = new IKSolverLimb(AvatarIKGoal.LeftFoot);

		// Token: 0x04001E98 RID: 7832
		public IKSolverLimb rightFoot = new IKSolverLimb(AvatarIKGoal.RightFoot);

		// Token: 0x04001E99 RID: 7833
		public IKSolverLimb leftHand = new IKSolverLimb(AvatarIKGoal.LeftHand);

		// Token: 0x04001E9A RID: 7834
		public IKSolverLimb rightHand = new IKSolverLimb(AvatarIKGoal.RightHand);

		// Token: 0x04001E9B RID: 7835
		public IKSolverFABRIK spine = new IKSolverFABRIK();

		// Token: 0x04001E9C RID: 7836
		public IKSolverLookAt lookAt = new IKSolverLookAt();

		// Token: 0x04001E9D RID: 7837
		public IKSolverAim aim = new IKSolverAim();

		// Token: 0x04001E9E RID: 7838
		public Constraints pelvis = new Constraints();

		// Token: 0x04001E9F RID: 7839
		private IKSolverLimb[] _limbs;

		// Token: 0x04001EA0 RID: 7840
		private IKSolver[] _ikSolvers;
	}
}
