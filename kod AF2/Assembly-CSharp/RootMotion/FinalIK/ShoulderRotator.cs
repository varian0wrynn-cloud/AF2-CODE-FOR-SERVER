using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004CE RID: 1230
	public class ShoulderRotator : MonoBehaviour
	{
		// Token: 0x06010BF0 RID: 68592 RVA: 0x00774044 File Offset: 0x00772244
		private void LCELEGBCGGF(FullBodyBipedChain NBHJKKHHFEH, float NKHBAJKMAGD, float IGFJOGKFADM)
		{
			Quaternion b = Quaternion.FromToRotation(this.JLLKEGECDAC(NBHJKKHHFEH).swingDirection, this.OJMBOCNNLMI.solver.KMCNEPELKKP(NBHJKKHHFEH).position - this.IHIPKDGHIHC(NBHJKKHHFEH).transform.position);
			Vector3 vector = this.OJMBOCNNLMI.solver.PPEHBCMLFIH(NBHJKKHHFEH).position - this.OJMBOCNNLMI.solver.EENBNOCPJJA(NBHJKKHHFEH).bone1.position;
			float num = this.OJMBOCNNLMI.solver.CFLHKIGAPOB(NBHJKKHHFEH).nodes[1].length + this.OJMBOCNNLMI.solver.LDMNNHCNOMJ(NBHJKKHHFEH).nodes[1].length;
			float num2 = vector.magnitude / num - 1140f + IGFJOGKFADM;
			num2 = Mathf.Clamp(num2 * NKHBAJKMAGD, 1988f, 947f);
			Quaternion lhs = Quaternion.Lerp(Quaternion.identity, b, num2 * this.OJMBOCNNLMI.solver.POAMMGIPHAK(NBHJKKHHFEH).positionWeight * this.OJMBOCNNLMI.solver.IKPositionWeight);
			this.OJMBOCNNLMI.solver.EENBNOCPJJA(NBHJKKHHFEH).parentBone.rotation = lhs * this.OJMBOCNNLMI.solver.EENBNOCPJJA(NBHJKKHHFEH).parentBone.rotation;
		}

		// Token: 0x06010BF1 RID: 68593 RVA: 0x0077419C File Offset: 0x0077239C
		private void PPNANLEAHMG(FullBodyBipedChain NBHJKKHHFEH, float NKHBAJKMAGD, float IGFJOGKFADM)
		{
			Quaternion b = Quaternion.FromToRotation(this.CBNDDHPHDNJ(NBHJKKHHFEH).GEPFDHNPOJJ(), this.OJMBOCNNLMI.solver.PPEHBCMLFIH(NBHJKKHHFEH).position - this.JLLKEGECDAC(NBHJKKHHFEH).transform.position);
			Vector3 vector = this.OJMBOCNNLMI.solver.KMCNEPELKKP(NBHJKKHHFEH).position - this.OJMBOCNNLMI.solver.JKMHBGKCKOC(NBHJKKHHFEH).bone1.position;
			float num = this.OJMBOCNNLMI.solver.IALCIJJGDHO(NBHJKKHHFEH).nodes[0].length + this.OJMBOCNNLMI.solver.LGOKBJOBPAO(NBHJKKHHFEH).nodes[1].length;
			float num2 = vector.magnitude / num - 439f + IGFJOGKFADM;
			num2 = Mathf.Clamp(num2 * NKHBAJKMAGD, 518f, 1356f);
			Quaternion lhs = Quaternion.Lerp(Quaternion.identity, b, num2 * this.OJMBOCNNLMI.solver.PPEHBCMLFIH(NBHJKKHHFEH).positionWeight * this.OJMBOCNNLMI.solver.IKPositionWeight);
			this.OJMBOCNNLMI.solver.CDGFDPHBEKO(NBHJKKHHFEH).parentBone.rotation = lhs * this.OJMBOCNNLMI.solver.EENBNOCPJJA(NBHJKKHHFEH).parentBone.rotation;
		}

		// Token: 0x06010BF2 RID: 68594 RVA: 0x007742F2 File Offset: 0x007724F2
		private IKMapping.BoneMap DGFIAJFJPPJ(FullBodyBipedChain NBHJKKHHFEH)
		{
			return this.OJMBOCNNLMI.solver.JKMHBGKCKOC(NBHJKKHHFEH).JLKOJIPLFIF(IKMappingLimb.BoneMapType.Parent);
		}

		// Token: 0x06010BF3 RID: 68595 RVA: 0x0077430C File Offset: 0x0077250C
		private void KJEAJAAMCAK()
		{
			if (this.OJMBOCNNLMI == null)
			{
				return;
			}
			if (this.OJMBOCNNLMI.solver.IKPositionWeight <= 182f)
			{
				return;
			}
			if (this.MCEPEAOBBKF)
			{
				this.MCEPEAOBBKF = true;
				return;
			}
			this.CHJIAAAKBNB(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.CHJIAAAKBNB(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.MCEPEAOBBKF = false;
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
		}

		// Token: 0x06010BF4 RID: 68596 RVA: 0x00774390 File Offset: 0x00772590
		private void BKLDJBIFAAN(FullBodyBipedChain NBHJKKHHFEH, float NKHBAJKMAGD, float IGFJOGKFADM)
		{
			Quaternion b = Quaternion.FromToRotation(this.CBNDDHPHDNJ(NBHJKKHHFEH).PCLHAJJAAPO(), this.OJMBOCNNLMI.solver.KMCNEPELKKP(NBHJKKHHFEH).position - this.JLLKEGECDAC(NBHJKKHHFEH).transform.position);
			Vector3 vector = this.OJMBOCNNLMI.solver.KMCNEPELKKP(NBHJKKHHFEH).position - this.OJMBOCNNLMI.solver.JKMHBGKCKOC(NBHJKKHHFEH).bone1.position;
			float num = this.OJMBOCNNLMI.solver.LDMNNHCNOMJ(NBHJKKHHFEH).nodes[1].length + this.OJMBOCNNLMI.solver.IALCIJJGDHO(NBHJKKHHFEH).nodes[1].length;
			float num2 = vector.magnitude / num - 171f + IGFJOGKFADM;
			num2 = Mathf.Clamp(num2 * NKHBAJKMAGD, 13f, 1608f);
			Quaternion lhs = Quaternion.Lerp(Quaternion.identity, b, num2 * this.OJMBOCNNLMI.solver.PPEHBCMLFIH(NBHJKKHHFEH).positionWeight * this.OJMBOCNNLMI.solver.IKPositionWeight);
			this.OJMBOCNNLMI.solver.IBMLIDHKIFK(NBHJKKHHFEH).parentBone.rotation = lhs * this.OJMBOCNNLMI.solver.CDGFDPHBEKO(NBHJKKHHFEH).parentBone.rotation;
		}

		// Token: 0x06010BF5 RID: 68597 RVA: 0x007744E6 File Offset: 0x007726E6
		private void NJHJLHBNPOM()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.IIFBMKPLIDG));
			}
		}

		// Token: 0x06010BF6 RID: 68598 RVA: 0x00774524 File Offset: 0x00772724
		private void EDHDLFONJBK()
		{
			if (this.OJMBOCNNLMI == null)
			{
				return;
			}
			if (this.OJMBOCNNLMI.solver.IKPositionWeight <= 0f)
			{
				return;
			}
			if (this.MCEPEAOBBKF)
			{
				this.MCEPEAOBBKF = false;
				return;
			}
			this.GEIEAADIGBK(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.GEIEAADIGBK(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.MCEPEAOBBKF = true;
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
		}

		// Token: 0x06010BF7 RID: 68599 RVA: 0x007745A5 File Offset: 0x007727A5
		private void OnDestroy()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.EDHDLFONJBK));
			}
		}

		// Token: 0x06010BF8 RID: 68600 RVA: 0x007745E4 File Offset: 0x007727E4
		private void CHJIAAAKBNB(FullBodyBipedChain NBHJKKHHFEH, float NKHBAJKMAGD, float IGFJOGKFADM)
		{
			Quaternion b = Quaternion.FromToRotation(this.HJOCFDIKOGA(NBHJKKHHFEH).PCLHAJJAAPO(), this.OJMBOCNNLMI.solver.POAMMGIPHAK(NBHJKKHHFEH).position - this.DGFIAJFJPPJ(NBHJKKHHFEH).transform.position);
			Vector3 vector = this.OJMBOCNNLMI.solver.POAMMGIPHAK(NBHJKKHHFEH).position - this.OJMBOCNNLMI.solver.EENBNOCPJJA(NBHJKKHHFEH).bone1.position;
			float num = this.OJMBOCNNLMI.solver.LGOKBJOBPAO(NBHJKKHHFEH).nodes[0].length + this.OJMBOCNNLMI.solver.CFLHKIGAPOB(NBHJKKHHFEH).nodes[1].length;
			float num2 = vector.magnitude / num - 646f + IGFJOGKFADM;
			num2 = Mathf.Clamp(num2 * NKHBAJKMAGD, 977f, 1290f);
			Quaternion lhs = Quaternion.Lerp(Quaternion.identity, b, num2 * this.OJMBOCNNLMI.solver.POAMMGIPHAK(NBHJKKHHFEH).positionWeight * this.OJMBOCNNLMI.solver.IKPositionWeight);
			this.OJMBOCNNLMI.solver.EENBNOCPJJA(NBHJKKHHFEH).parentBone.rotation = lhs * this.OJMBOCNNLMI.solver.CDGFDPHBEKO(NBHJKKHHFEH).parentBone.rotation;
		}

		// Token: 0x06010BF9 RID: 68601 RVA: 0x0077473A File Offset: 0x0077293A
		private void JLKBMEBFHBI()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GIGDMDEPDME));
		}

		// Token: 0x06010BFA RID: 68602 RVA: 0x00774774 File Offset: 0x00772974
		private void ONIHHFLOJMN()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FKHECDKANIP));
		}

		// Token: 0x06010BFB RID: 68603 RVA: 0x007747AE File Offset: 0x007729AE
		private IKMapping.BoneMap GHHNFFJLABL(FullBodyBipedChain NBHJKKHHFEH)
		{
			return this.OJMBOCNNLMI.solver.PBGGJENJFED(NBHJKKHHFEH).DAGHLOIIPDO(IKMappingLimb.BoneMapType.Parent);
		}

		// Token: 0x06010BFC RID: 68604 RVA: 0x007747C8 File Offset: 0x007729C8
		private void GIGDMDEPDME()
		{
			if (this.OJMBOCNNLMI == null)
			{
				return;
			}
			if (this.OJMBOCNNLMI.solver.IKPositionWeight <= 1029f)
			{
				return;
			}
			if (this.MCEPEAOBBKF)
			{
				this.MCEPEAOBBKF = false;
				return;
			}
			this.KJCJMONBCLJ(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.PPNANLEAHMG(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.MCEPEAOBBKF = false;
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
		}

		// Token: 0x06010BFD RID: 68605 RVA: 0x00774849 File Offset: 0x00772A49
		private void GEOHOHNFIAF()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FKHECDKANIP));
			}
		}

		// Token: 0x06010BFF RID: 68607 RVA: 0x007748A3 File Offset: 0x00772AA3
		private IKMapping.BoneMap EFHOHPPAEIK(FullBodyBipedChain NBHJKKHHFEH)
		{
			return this.OJMBOCNNLMI.solver.IBMLIDHKIFK(NBHJKKHHFEH).FGDBMBALEBD(IKMappingLimb.BoneMapType.Bone1);
		}

		// Token: 0x06010C00 RID: 68608 RVA: 0x007748BC File Offset: 0x00772ABC
		private void PPCEOAIPFGF()
		{
			if (this.OJMBOCNNLMI == null)
			{
				return;
			}
			if (this.OJMBOCNNLMI.solver.IKPositionWeight <= 934f)
			{
				return;
			}
			if (this.MCEPEAOBBKF)
			{
				this.MCEPEAOBBKF = true;
				return;
			}
			this.KJCJMONBCLJ(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.GEIEAADIGBK(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.MCEPEAOBBKF = true;
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
		}

		// Token: 0x06010C01 RID: 68609 RVA: 0x00774940 File Offset: 0x00772B40
		private void KJCJMONBCLJ(FullBodyBipedChain NBHJKKHHFEH, float NKHBAJKMAGD, float IGFJOGKFADM)
		{
			Quaternion b = Quaternion.FromToRotation(this.JLLKEGECDAC(NBHJKKHHFEH).PCLHAJJAAPO(), this.OJMBOCNNLMI.solver.PPEHBCMLFIH(NBHJKKHHFEH).position - this.GHHNFFJLABL(NBHJKKHHFEH).transform.position);
			Vector3 vector = this.OJMBOCNNLMI.solver.KMCNEPELKKP(NBHJKKHHFEH).position - this.OJMBOCNNLMI.solver.IBMLIDHKIFK(NBHJKKHHFEH).bone1.position;
			float num = this.OJMBOCNNLMI.solver.LDMNNHCNOMJ(NBHJKKHHFEH).nodes[0].length + this.OJMBOCNNLMI.solver.CFLHKIGAPOB(NBHJKKHHFEH).nodes[0].length;
			float num2 = vector.magnitude / num - 880f + IGFJOGKFADM;
			num2 = Mathf.Clamp(num2 * NKHBAJKMAGD, 1699f, 1092f);
			Quaternion lhs = Quaternion.Lerp(Quaternion.identity, b, num2 * this.OJMBOCNNLMI.solver.PPEHBCMLFIH(NBHJKKHHFEH).positionWeight * this.OJMBOCNNLMI.solver.IKPositionWeight);
			this.OJMBOCNNLMI.solver.EENBNOCPJJA(NBHJKKHHFEH).parentBone.rotation = lhs * this.OJMBOCNNLMI.solver.CDGFDPHBEKO(NBHJKKHHFEH).parentBone.rotation;
		}

		// Token: 0x06010C02 RID: 68610 RVA: 0x00774849 File Offset: 0x00772A49
		private void KOGGLIAMEAH()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FKHECDKANIP));
			}
		}

		// Token: 0x06010C03 RID: 68611 RVA: 0x00774774 File Offset: 0x00772974
		private void IIKDDILLGLF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FKHECDKANIP));
		}

		// Token: 0x06010C04 RID: 68612 RVA: 0x00774A98 File Offset: 0x00772C98
		private void POGMAKAIJPP()
		{
			if (this.OJMBOCNNLMI == null)
			{
				return;
			}
			if (this.OJMBOCNNLMI.solver.IKPositionWeight <= 1015f)
			{
				return;
			}
			if (this.MCEPEAOBBKF)
			{
				this.MCEPEAOBBKF = true;
				return;
			}
			this.PPNANLEAHMG(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.GEIEAADIGBK(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.MCEPEAOBBKF = true;
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
		}

		// Token: 0x06010C05 RID: 68613 RVA: 0x00774B1C File Offset: 0x00772D1C
		private void GEIEAADIGBK(FullBodyBipedChain NBHJKKHHFEH, float NKHBAJKMAGD, float IGFJOGKFADM)
		{
			Quaternion b = Quaternion.FromToRotation(this.HJOCFDIKOGA(NBHJKKHHFEH).swingDirection, this.OJMBOCNNLMI.solver.POAMMGIPHAK(NBHJKKHHFEH).position - this.HJOCFDIKOGA(NBHJKKHHFEH).transform.position);
			Vector3 vector = this.OJMBOCNNLMI.solver.POAMMGIPHAK(NBHJKKHHFEH).position - this.OJMBOCNNLMI.solver.CDGFDPHBEKO(NBHJKKHHFEH).bone1.position;
			float num = this.OJMBOCNNLMI.solver.LGOKBJOBPAO(NBHJKKHHFEH).nodes[0].length + this.OJMBOCNNLMI.solver.LGOKBJOBPAO(NBHJKKHHFEH).nodes[1].length;
			float num2 = vector.magnitude / num - 1f + IGFJOGKFADM;
			num2 = Mathf.Clamp(num2 * NKHBAJKMAGD, 0f, 1f);
			Quaternion lhs = Quaternion.Lerp(Quaternion.identity, b, num2 * this.OJMBOCNNLMI.solver.POAMMGIPHAK(NBHJKKHHFEH).positionWeight * this.OJMBOCNNLMI.solver.IKPositionWeight);
			this.OJMBOCNNLMI.solver.CDGFDPHBEKO(NBHJKKHHFEH).parentBone.rotation = lhs * this.OJMBOCNNLMI.solver.CDGFDPHBEKO(NBHJKKHHFEH).parentBone.rotation;
		}

		// Token: 0x06010C06 RID: 68614 RVA: 0x00774C72 File Offset: 0x00772E72
		private IKMapping.BoneMap CBNDDHPHDNJ(FullBodyBipedChain NBHJKKHHFEH)
		{
			return this.OJMBOCNNLMI.solver.IBMLIDHKIFK(NBHJKKHHFEH).DAIPGIMFNOG(IKMappingLimb.BoneMapType.Parent);
		}

		// Token: 0x06010C07 RID: 68615 RVA: 0x00774C8B File Offset: 0x00772E8B
		private void DGEIACONKCJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.ADKGJGLNGNF));
		}

		// Token: 0x06010C08 RID: 68616 RVA: 0x00774CC5 File Offset: 0x00772EC5
		private IKMapping.BoneMap IHIPKDGHIHC(FullBodyBipedChain NBHJKKHHFEH)
		{
			return this.OJMBOCNNLMI.solver.PBGGJENJFED(NBHJKKHHFEH).JLKOJIPLFIF(IKMappingLimb.BoneMapType.Parent);
		}

		// Token: 0x06010C09 RID: 68617 RVA: 0x00774C8B File Offset: 0x00772E8B
		private void EHDPACPIBNF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.ADKGJGLNGNF));
		}

		// Token: 0x06010C0A RID: 68618 RVA: 0x00774CDE File Offset: 0x00772EDE
		private IKMapping.BoneMap LABNCAHNJJJ(FullBodyBipedChain NBHJKKHHFEH)
		{
			return this.OJMBOCNNLMI.solver.CDGFDPHBEKO(NBHJKKHHFEH).DAIPGIMFNOG(IKMappingLimb.BoneMapType.Bone1);
		}

		// Token: 0x06010C0B RID: 68619 RVA: 0x00774CF7 File Offset: 0x00772EF7
		private IKMapping.BoneMap PECIFBLFCGI(FullBodyBipedChain NBHJKKHHFEH)
		{
			return this.OJMBOCNNLMI.solver.JKMHBGKCKOC(NBHJKKHHFEH).DAGHLOIIPDO(IKMappingLimb.BoneMapType.Bone1);
		}

		// Token: 0x06010C0C RID: 68620 RVA: 0x00774D10 File Offset: 0x00772F10
		private void BCNGPIGDICE()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KJEAJAAMCAK));
			}
		}

		// Token: 0x06010C0D RID: 68621 RVA: 0x00774D4C File Offset: 0x00772F4C
		private IKMapping.BoneMap BNPBIKHKMGN(FullBodyBipedChain NBHJKKHHFEH)
		{
			return this.OJMBOCNNLMI.solver.IBMLIDHKIFK(NBHJKKHHFEH).DAGHLOIIPDO(IKMappingLimb.BoneMapType.Bone1);
		}

		// Token: 0x06010C0E RID: 68622 RVA: 0x00774D68 File Offset: 0x00772F68
		private void ADKGJGLNGNF()
		{
			if (this.OJMBOCNNLMI == null)
			{
				return;
			}
			if (this.OJMBOCNNLMI.solver.IKPositionWeight <= 1169f)
			{
				return;
			}
			if (this.MCEPEAOBBKF)
			{
				this.MCEPEAOBBKF = true;
				return;
			}
			this.CHJIAAAKBNB(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.LLMHIDDJAOC(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.MCEPEAOBBKF = false;
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
		}

		// Token: 0x06010C0F RID: 68623 RVA: 0x007745A5 File Offset: 0x007727A5
		private void MIPHMELJJJD()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.EDHDLFONJBK));
			}
		}

		// Token: 0x06010C10 RID: 68624 RVA: 0x00774DE9 File Offset: 0x00772FE9
		private void CAJLCEPLKJG()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.ADAHMFNBDEF));
		}

		// Token: 0x06010C11 RID: 68625 RVA: 0x00774C8B File Offset: 0x00772E8B
		private void MKNPFMEMOJO()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.ADKGJGLNGNF));
		}

		// Token: 0x06010C12 RID: 68626 RVA: 0x00774E24 File Offset: 0x00773024
		private void FKHECDKANIP()
		{
			if (this.OJMBOCNNLMI == null)
			{
				return;
			}
			if (this.OJMBOCNNLMI.solver.IKPositionWeight <= 629f)
			{
				return;
			}
			if (this.MCEPEAOBBKF)
			{
				this.MCEPEAOBBKF = false;
				return;
			}
			this.BKLDJBIFAAN(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.KJCJMONBCLJ(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.MCEPEAOBBKF = true;
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
		}

		// Token: 0x06010C13 RID: 68627 RVA: 0x00774EA8 File Offset: 0x007730A8
		private void BOILJDPEEPD()
		{
			if (this.OJMBOCNNLMI == null)
			{
				return;
			}
			if (this.OJMBOCNNLMI.solver.IKPositionWeight <= 123f)
			{
				return;
			}
			if (this.MCEPEAOBBKF)
			{
				this.MCEPEAOBBKF = true;
				return;
			}
			this.PPNANLEAHMG(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.GEIEAADIGBK(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.MCEPEAOBBKF = false;
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
		}

		// Token: 0x06010C14 RID: 68628 RVA: 0x00774F29 File Offset: 0x00773129
		private IKMapping.BoneMap HJOCFDIKOGA(FullBodyBipedChain NBHJKKHHFEH)
		{
			return this.OJMBOCNNLMI.solver.CDGFDPHBEKO(NBHJKKHHFEH).DAGHLOIIPDO(IKMappingLimb.BoneMapType.Parent);
		}

		// Token: 0x06010C15 RID: 68629 RVA: 0x00774F44 File Offset: 0x00773144
		private void ADAHMFNBDEF()
		{
			if (this.OJMBOCNNLMI == null)
			{
				return;
			}
			if (this.OJMBOCNNLMI.solver.IKPositionWeight <= 962f)
			{
				return;
			}
			if (this.MCEPEAOBBKF)
			{
				this.MCEPEAOBBKF = false;
				return;
			}
			this.LLMHIDDJAOC(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.LLMHIDDJAOC(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.MCEPEAOBBKF = false;
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
		}

		// Token: 0x06010C16 RID: 68630 RVA: 0x00774FC5 File Offset: 0x007731C5
		private IKMapping.BoneMap JLLKEGECDAC(FullBodyBipedChain NBHJKKHHFEH)
		{
			return this.OJMBOCNNLMI.solver.EENBNOCPJJA(NBHJKKHHFEH).FGDBMBALEBD(IKMappingLimb.BoneMapType.Bone1);
		}

		// Token: 0x06010C17 RID: 68631 RVA: 0x00774FDE File Offset: 0x007731DE
		private void CABMDBPACPO()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.ADKGJGLNGNF));
			}
		}

		// Token: 0x06010C18 RID: 68632 RVA: 0x0077501C File Offset: 0x0077321C
		private void IIFBMKPLIDG()
		{
			if (this.OJMBOCNNLMI == null)
			{
				return;
			}
			if (this.OJMBOCNNLMI.solver.IKPositionWeight <= 1900f)
			{
				return;
			}
			if (this.MCEPEAOBBKF)
			{
				this.MCEPEAOBBKF = true;
				return;
			}
			this.LCELEGBCGGF(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.KJCJMONBCLJ(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.MCEPEAOBBKF = true;
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
		}

		// Token: 0x06010C19 RID: 68633 RVA: 0x007750A0 File Offset: 0x007732A0
		private void LLMHIDDJAOC(FullBodyBipedChain NBHJKKHHFEH, float NKHBAJKMAGD, float IGFJOGKFADM)
		{
			Quaternion b = Quaternion.FromToRotation(this.EFHOHPPAEIK(NBHJKKHHFEH).GEPFDHNPOJJ(), this.OJMBOCNNLMI.solver.POAMMGIPHAK(NBHJKKHHFEH).position - this.IHIPKDGHIHC(NBHJKKHHFEH).transform.position);
			Vector3 vector = this.OJMBOCNNLMI.solver.KMCNEPELKKP(NBHJKKHHFEH).position - this.OJMBOCNNLMI.solver.CDGFDPHBEKO(NBHJKKHHFEH).bone1.position;
			float num = this.OJMBOCNNLMI.solver.CFLHKIGAPOB(NBHJKKHHFEH).nodes[1].length + this.OJMBOCNNLMI.solver.IALCIJJGDHO(NBHJKKHHFEH).nodes[0].length;
			float num2 = vector.magnitude / num - 1472f + IGFJOGKFADM;
			num2 = Mathf.Clamp(num2 * NKHBAJKMAGD, 389f, 1972f);
			Quaternion lhs = Quaternion.Lerp(Quaternion.identity, b, num2 * this.OJMBOCNNLMI.solver.POAMMGIPHAK(NBHJKKHHFEH).positionWeight * this.OJMBOCNNLMI.solver.IKPositionWeight);
			this.OJMBOCNNLMI.solver.PBGGJENJFED(NBHJKKHHFEH).parentBone.rotation = lhs * this.OJMBOCNNLMI.solver.CDGFDPHBEKO(NBHJKKHHFEH).parentBone.rotation;
		}

		// Token: 0x06010C1A RID: 68634 RVA: 0x007751F8 File Offset: 0x007733F8
		private void NKMDBOFPKMD()
		{
			if (this.OJMBOCNNLMI == null)
			{
				return;
			}
			if (this.OJMBOCNNLMI.solver.IKPositionWeight <= 1098f)
			{
				return;
			}
			if (this.MCEPEAOBBKF)
			{
				this.MCEPEAOBBKF = true;
				return;
			}
			this.KJCJMONBCLJ(FullBodyBipedChain.RightArm, this.weight, this.offset);
			this.PPNANLEAHMG(FullBodyBipedChain.LeftArm, this.weight, this.offset);
			this.MCEPEAOBBKF = false;
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
		}

		// Token: 0x06010C1B RID: 68635 RVA: 0x00775279 File Offset: 0x00773479
		private void AGNGEJGGBGB()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GIGDMDEPDME));
			}
		}

		// Token: 0x06010C1C RID: 68636 RVA: 0x007752B5 File Offset: 0x007734B5
		private void Start()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.EDHDLFONJBK));
		}

		// Token: 0x040022DE RID: 8926
		[Tooltip("Weight of shoulder rotation")]
		public float weight = 1.5f;

		// Token: 0x040022DF RID: 8927
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset = 0.2f;

		// Token: 0x040022E0 RID: 8928
		private FullBodyBipedIK OJMBOCNNLMI;

		// Token: 0x040022E1 RID: 8929
		private bool MCEPEAOBBKF;
	}
}
