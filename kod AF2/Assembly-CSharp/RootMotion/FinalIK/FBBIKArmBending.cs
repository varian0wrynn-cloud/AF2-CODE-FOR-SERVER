using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200045C RID: 1116
	public class FBBIKArmBending : MonoBehaviour
	{
		// Token: 0x0600F1AD RID: 61869 RVA: 0x006C0E65 File Offset: 0x006BF065
		private void KDKONDIFHHK()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DFNDDPJBCBO));
			}
		}

		// Token: 0x0600F1AE RID: 61870 RVA: 0x006C0EA4 File Offset: 0x006BF0A4
		private void GIKJMPHFJKH()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GOHPNIHIGFN));
				this.EOFDOPLDFCG = false;
			}
			if (this.ik.solver.EMPOFCMIGLD().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.direction = this.ik.solver.EMPOFCMIGLD().target.rotation * left + this.ik.solver.KIGACGJAJKO().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.CHANDBAAMII().bendConstraint.weight = 1017f;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.HAFFDJFFPME().bendConstraint.direction = this.ik.solver.MJOPIBNHGIK().target.rotation * right + this.ik.solver.MJOPIBNHGIK().target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.KAPMOCHHMDF().bendConstraint.weight = 1014f;
			}
		}

		// Token: 0x0600F1AF RID: 61871 RVA: 0x006C108D File Offset: 0x006BF28D
		private void AGGIPMOOBBP()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FHDABLNCMKA));
			}
		}

		// Token: 0x0600F1B0 RID: 61872 RVA: 0x006C10CC File Offset: 0x006BF2CC
		private void LELCLMEJJEO()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.KIGACGJAJKO().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.DBCIMCKLHIM().target.rotation;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.MJOPIBNHGIK().target.rotation;
			}
		}

		// Token: 0x0600F1B1 RID: 61873 RVA: 0x006C1180 File Offset: 0x006BF380
		private void NKNDJENDPDJ()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KNENODFBOIF));
			}
		}

		// Token: 0x0600F1B2 RID: 61874 RVA: 0x006C11BC File Offset: 0x006BF3BC
		private void MHELHINDCCD()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.KIGACGJAJKO().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.EMPOFCMIGLD().target.rotation;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.MJOPIBNHGIK().target.rotation;
			}
		}

		// Token: 0x0600F1B3 RID: 61875 RVA: 0x006C1270 File Offset: 0x006BF470
		private void HHJKBKLPLIM()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FHDABLNCMKA));
				this.EOFDOPLDFCG = true;
			}
			if (this.ik.solver.DBCIMCKLHIM().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.direction = this.ik.solver.DBCIMCKLHIM().target.rotation * left + this.ik.solver.DBCIMCKLHIM().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.weight = 1259f;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.rightArmChain.bendConstraint.direction = this.ik.solver.MJOPIBNHGIK().target.rotation * right + this.ik.solver.rightHandEffector.target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.HAFFDJFFPME().bendConstraint.weight = 683f;
			}
		}

		// Token: 0x0600F1B4 RID: 61876 RVA: 0x006C145C File Offset: 0x006BF65C
		private void GOHPNIHIGFN()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.DBCIMCKLHIM().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.EMPOFCMIGLD().target.rotation;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.IANMIEDIJPJ().target.rotation;
			}
		}

		// Token: 0x0600F1B5 RID: 61877 RVA: 0x006C1510 File Offset: 0x006BF710
		private void LateUpdate()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LMEABKOGPNA));
				this.EOFDOPLDFCG = true;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.leftArmChain.bendConstraint.direction = this.ik.solver.leftHandEffector.target.rotation * left + this.ik.solver.leftHandEffector.target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.leftArmChain.bendConstraint.weight = 1f;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.rightArmChain.bendConstraint.direction = this.ik.solver.rightHandEffector.target.rotation * right + this.ik.solver.rightHandEffector.target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.rightArmChain.bendConstraint.weight = 1f;
			}
		}

		// Token: 0x0600F1B6 RID: 61878 RVA: 0x006C16FC File Offset: 0x006BF8FC
		private void JDAJEPAHIFC()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.DBCIMCKLHIM().target.rotation;
			}
			if (this.ik.solver.MJOPIBNHGIK().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x0600F1B7 RID: 61879 RVA: 0x006C108D File Offset: 0x006BF28D
		private void AGNGEJGGBGB()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FHDABLNCMKA));
			}
		}

		// Token: 0x0600F1B8 RID: 61880 RVA: 0x006C17B0 File Offset: 0x006BF9B0
		private void FMLLPNOMFHD()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.CMKJIGNKIMG().target.rotation;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.IANMIEDIJPJ().target.rotation;
			}
		}

		// Token: 0x0600F1B9 RID: 61881 RVA: 0x006C1864 File Offset: 0x006BFA64
		private void NEIEILMBEOD()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.EMPOFCMIGLD().target.rotation;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.MJOPIBNHGIK().target.rotation;
			}
		}

		// Token: 0x0600F1BA RID: 61882 RVA: 0x006C1918 File Offset: 0x006BFB18
		private void OKFONGOBMCC()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DFNDDPJBCBO));
				this.EOFDOPLDFCG = false;
			}
			if (this.ik.solver.EMPOFCMIGLD().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.leftArmChain.bendConstraint.direction = this.ik.solver.leftHandEffector.target.rotation * left + this.ik.solver.KIGACGJAJKO().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.weight = 160f;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.rightArmChain.bendConstraint.direction = this.ik.solver.IANMIEDIJPJ().target.rotation * right + this.ik.solver.rightHandEffector.target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.KAPMOCHHMDF().bendConstraint.weight = 168f;
			}
		}

		// Token: 0x0600F1BB RID: 61883 RVA: 0x006C1B04 File Offset: 0x006BFD04
		private void LNBKBOJPNMP()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.CMKJIGNKIMG().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.leftHandEffector.target.rotation;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.MJOPIBNHGIK().target.rotation;
			}
		}

		// Token: 0x0600F1BC RID: 61884 RVA: 0x006C1BB8 File Offset: 0x006BFDB8
		private void BBNCMBGFJHE()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.EMPOFCMIGLD().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.KIGACGJAJKO().target.rotation;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x0600F1BD RID: 61885 RVA: 0x006C1C6C File Offset: 0x006BFE6C
		private void AEAPIKAENBD()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FHDABLNCMKA));
				this.EOFDOPLDFCG = true;
			}
			if (this.ik.solver.DBCIMCKLHIM().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.direction = this.ik.solver.EMPOFCMIGLD().target.rotation * left + this.ik.solver.leftHandEffector.target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.weight = 1439f;
			}
			if (this.ik.solver.MJOPIBNHGIK().target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.AFIIFEDPGAP().bendConstraint.direction = this.ik.solver.IANMIEDIJPJ().target.rotation * right + this.ik.solver.rightHandEffector.target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.HAFFDJFFPME().bendConstraint.weight = 501f;
			}
		}

		// Token: 0x0600F1BE RID: 61886 RVA: 0x006C1180 File Offset: 0x006BF380
		private void PNAPPHLKMIG()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KNENODFBOIF));
			}
		}

		// Token: 0x0600F1BF RID: 61887 RVA: 0x006C1E55 File Offset: 0x006C0055
		private void NJHJLHBNPOM()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CAIGBKPHNLA));
			}
		}

		// Token: 0x0600F1C0 RID: 61888 RVA: 0x006C1E91 File Offset: 0x006C0091
		private void DAJCCMDCMIK()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JDAJEPAHIFC));
			}
		}

		// Token: 0x0600F1C1 RID: 61889 RVA: 0x006C1ECD File Offset: 0x006C00CD
		private void OBMPEBPAOFJ()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BBNCMBGFJHE));
			}
		}

		// Token: 0x0600F1C2 RID: 61890 RVA: 0x006C1F0C File Offset: 0x006C010C
		private void PIEDGJCBCBO()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GOHPNIHIGFN));
				this.EOFDOPLDFCG = true;
			}
			if (this.ik.solver.KIGACGJAJKO().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.leftArmChain.bendConstraint.direction = this.ik.solver.EMPOFCMIGLD().target.rotation * left + this.ik.solver.CMKJIGNKIMG().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.weight = 1812f;
			}
			if (this.ik.solver.MJOPIBNHGIK().target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.KAPMOCHHMDF().bendConstraint.direction = this.ik.solver.rightHandEffector.target.rotation * right + this.ik.solver.IANMIEDIJPJ().target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.AFIIFEDPGAP().bendConstraint.weight = 290f;
			}
		}

		// Token: 0x0600F1C3 RID: 61891 RVA: 0x006C20F8 File Offset: 0x006C02F8
		private void BJILHFNDDKC()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DFNDDPJBCBO));
				this.EOFDOPLDFCG = true;
			}
			if (this.ik.solver.CMKJIGNKIMG().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.direction = this.ik.solver.CMKJIGNKIMG().target.rotation * left + this.ik.solver.CMKJIGNKIMG().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.leftArmChain.bendConstraint.weight = 1825f;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.AFIIFEDPGAP().bendConstraint.direction = this.ik.solver.IANMIEDIJPJ().target.rotation * right + this.ik.solver.MJOPIBNHGIK().target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.KAPMOCHHMDF().bendConstraint.weight = 1593f;
			}
		}

		// Token: 0x0600F1C4 RID: 61892 RVA: 0x006C22E1 File Offset: 0x006C04E1
		private void MIPHMELJJJD()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GJFCLCIFINB));
			}
		}

		// Token: 0x0600F1C5 RID: 61893 RVA: 0x006C2320 File Offset: 0x006C0520
		private void HBKAEIJLKPM()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NDKEHAGOCMI));
				this.EOFDOPLDFCG = true;
			}
			if (this.ik.solver.KIGACGJAJKO().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.leftArmChain.bendConstraint.direction = this.ik.solver.leftHandEffector.target.rotation * left + this.ik.solver.KIGACGJAJKO().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.weight = 1971f;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.rightArmChain.bendConstraint.direction = this.ik.solver.rightHandEffector.target.rotation * right + this.ik.solver.MJOPIBNHGIK().target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.rightArmChain.bendConstraint.weight = 89f;
			}
		}

		// Token: 0x0600F1C6 RID: 61894 RVA: 0x006C2509 File Offset: 0x006C0709
		private void JGOIIKJIDNH()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GOHPNIHIGFN));
			}
		}

		// Token: 0x0600F1C7 RID: 61895 RVA: 0x006C2545 File Offset: 0x006C0745
		private void HMDACKBGNJL()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LMEABKOGPNA));
			}
		}

		// Token: 0x0600F1C8 RID: 61896 RVA: 0x006C2584 File Offset: 0x006C0784
		private void MJFJPFJICDH()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FHDABLNCMKA));
				this.EOFDOPLDFCG = false;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.direction = this.ik.solver.KIGACGJAJKO().target.rotation * left + this.ik.solver.DBCIMCKLHIM().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.leftArmChain.bendConstraint.weight = 1748f;
			}
			if (this.ik.solver.MJOPIBNHGIK().target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.AFIIFEDPGAP().bendConstraint.direction = this.ik.solver.IANMIEDIJPJ().target.rotation * right + this.ik.solver.rightHandEffector.target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.HAFFDJFFPME().bendConstraint.weight = 1641f;
			}
		}

		// Token: 0x0600F1C9 RID: 61897 RVA: 0x006C2770 File Offset: 0x006C0970
		private void GJFCLCIFINB()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.CMKJIGNKIMG().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.DBCIMCKLHIM().target.rotation;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.MJOPIBNHGIK().target.rotation;
			}
		}

		// Token: 0x0600F1CB RID: 61899 RVA: 0x006C2545 File Offset: 0x006C0745
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LMEABKOGPNA));
			}
		}

		// Token: 0x0600F1CC RID: 61900 RVA: 0x006C2824 File Offset: 0x006C0A24
		private void ONFNBCCCPCE()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.EMPOFCMIGLD().target.rotation;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.IANMIEDIJPJ().target.rotation;
			}
		}

		// Token: 0x0600F1CD RID: 61901 RVA: 0x006C28D8 File Offset: 0x006C0AD8
		private void GEOHOHNFIAF()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MHELHINDCCD));
			}
		}

		// Token: 0x0600F1CE RID: 61902 RVA: 0x006C2914 File Offset: 0x006C0B14
		private void GPEFDPEAMNE()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LMEABKOGPNA));
				this.EOFDOPLDFCG = false;
			}
			if (this.ik.solver.DBCIMCKLHIM().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.leftArmChain.bendConstraint.direction = this.ik.solver.leftHandEffector.target.rotation * left + this.ik.solver.leftHandEffector.target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.weight = 386f;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.HAFFDJFFPME().bendConstraint.direction = this.ik.solver.MJOPIBNHGIK().target.rotation * right + this.ik.solver.MJOPIBNHGIK().target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.HAFFDJFFPME().bendConstraint.weight = 1315f;
			}
		}

		// Token: 0x0600F1CF RID: 61903 RVA: 0x006C2B00 File Offset: 0x006C0D00
		private void KNENODFBOIF()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.DBCIMCKLHIM().target.rotation;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x0600F1D0 RID: 61904 RVA: 0x006C2BB4 File Offset: 0x006C0DB4
		private void IMEDKJNAHKK()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BBNCMBGFJHE));
				this.EOFDOPLDFCG = false;
			}
			if (this.ik.solver.CMKJIGNKIMG().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.leftArmChain.bendConstraint.direction = this.ik.solver.leftHandEffector.target.rotation * left + this.ik.solver.CMKJIGNKIMG().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.leftArmChain.bendConstraint.weight = 493f;
			}
			if (this.ik.solver.MJOPIBNHGIK().target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.KAPMOCHHMDF().bendConstraint.direction = this.ik.solver.MJOPIBNHGIK().target.rotation * right + this.ik.solver.IANMIEDIJPJ().target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.HAFFDJFFPME().bendConstraint.weight = 1664f;
			}
		}

		// Token: 0x0600F1D1 RID: 61905 RVA: 0x006C1E91 File Offset: 0x006C0091
		private void MIEEAACIPJH()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.JDAJEPAHIFC));
			}
		}

		// Token: 0x0600F1D2 RID: 61906 RVA: 0x006C2D9D File Offset: 0x006C0F9D
		private void DICPGKGKODM()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NEIEILMBEOD));
			}
		}

		// Token: 0x0600F1D3 RID: 61907 RVA: 0x006C2DDC File Offset: 0x006C0FDC
		private void BNCNCJGNKJI()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.DBCIMCKLHIM().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.EMPOFCMIGLD().target.rotation;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x0600F1D4 RID: 61908 RVA: 0x006C1180 File Offset: 0x006BF380
		private void CGMBLNCHALB()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KNENODFBOIF));
			}
		}

		// Token: 0x0600F1D5 RID: 61909 RVA: 0x006C2E90 File Offset: 0x006C1090
		private void CGNFLAOBEFN()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GOHPNIHIGFN));
				this.EOFDOPLDFCG = false;
			}
			if (this.ik.solver.DBCIMCKLHIM().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.CHANDBAAMII().bendConstraint.direction = this.ik.solver.DBCIMCKLHIM().target.rotation * left + this.ik.solver.CMKJIGNKIMG().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.CHANDBAAMII().bendConstraint.weight = 1305f;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.rightArmChain.bendConstraint.direction = this.ik.solver.rightHandEffector.target.rotation * right + this.ik.solver.IANMIEDIJPJ().target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.rightArmChain.bendConstraint.weight = 1157f;
			}
		}

		// Token: 0x0600F1D6 RID: 61910 RVA: 0x006C307C File Offset: 0x006C127C
		private void DFNJNCCPKJF()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KNENODFBOIF));
				this.EOFDOPLDFCG = true;
			}
			if (this.ik.solver.KIGACGJAJKO().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.direction = this.ik.solver.KIGACGJAJKO().target.rotation * left + this.ik.solver.CMKJIGNKIMG().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.weight = 1523f;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.AFIIFEDPGAP().bendConstraint.direction = this.ik.solver.MJOPIBNHGIK().target.rotation * right + this.ik.solver.MJOPIBNHGIK().target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.AFIIFEDPGAP().bendConstraint.weight = 848f;
			}
		}

		// Token: 0x0600F1D7 RID: 61911 RVA: 0x006C3265 File Offset: 0x006C1465
		private void PKPGIGEEEJI()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.OFCKGMOANAN));
			}
		}

		// Token: 0x0600F1D8 RID: 61912 RVA: 0x006C1180 File Offset: 0x006BF380
		private void GNPJEGPCBOD()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.KNENODFBOIF));
			}
		}

		// Token: 0x0600F1D9 RID: 61913 RVA: 0x006C32A4 File Offset: 0x006C14A4
		private void LCMMGLMJPOK()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BBNCMBGFJHE));
				this.EOFDOPLDFCG = false;
			}
			if (this.ik.solver.DBCIMCKLHIM().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.leftArmChain.bendConstraint.direction = this.ik.solver.EMPOFCMIGLD().target.rotation * left + this.ik.solver.EMPOFCMIGLD().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.weight = 1613f;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.rightArmChain.bendConstraint.direction = this.ik.solver.rightHandEffector.target.rotation * right + this.ik.solver.IANMIEDIJPJ().target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.AFIIFEDPGAP().bendConstraint.weight = 1781f;
			}
		}

		// Token: 0x0600F1DA RID: 61914 RVA: 0x006C348D File Offset: 0x006C168D
		private void PEGLBMGDMIP()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FJFAEHMGALO));
			}
		}

		// Token: 0x0600F1DB RID: 61915 RVA: 0x006C2D9D File Offset: 0x006C0F9D
		private void BCNGPIGDICE()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NEIEILMBEOD));
			}
		}

		// Token: 0x0600F1DC RID: 61916 RVA: 0x006C34C9 File Offset: 0x006C16C9
		private void DOEMHIKKCKB()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FMLLPNOMFHD));
			}
		}

		// Token: 0x0600F1DD RID: 61917 RVA: 0x006C3508 File Offset: 0x006C1708
		private void CAIGBKPHNLA()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.leftHandEffector.target.rotation;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x0600F1DE RID: 61918 RVA: 0x006C35BC File Offset: 0x006C17BC
		private void OFCKGMOANAN()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.KIGACGJAJKO().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.KIGACGJAJKO().target.rotation;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.IANMIEDIJPJ().target.rotation;
			}
		}

		// Token: 0x0600F1DF RID: 61919 RVA: 0x006C3670 File Offset: 0x006C1870
		private void LMEABKOGPNA()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.leftHandEffector.target.rotation;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x0600F1E0 RID: 61920 RVA: 0x006C3724 File Offset: 0x006C1924
		private void KCMJALIDEHB()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LELCLMEJJEO));
				this.EOFDOPLDFCG = false;
			}
			if (this.ik.solver.EMPOFCMIGLD().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.leftArmChain.bendConstraint.direction = this.ik.solver.KIGACGJAJKO().target.rotation * left + this.ik.solver.CMKJIGNKIMG().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.leftArmChain.bendConstraint.weight = 1198f;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.rightArmChain.bendConstraint.direction = this.ik.solver.MJOPIBNHGIK().target.rotation * right + this.ik.solver.IANMIEDIJPJ().target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.KAPMOCHHMDF().bendConstraint.weight = 107f;
			}
		}

		// Token: 0x0600F1E1 RID: 61921 RVA: 0x006C0E65 File Offset: 0x006BF065
		private void MOILNLOMCAK()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DFNDDPJBCBO));
			}
		}

		// Token: 0x0600F1E2 RID: 61922 RVA: 0x006C1ECD File Offset: 0x006C00CD
		private void LJLHAJMJDCE()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BBNCMBGFJHE));
			}
		}

		// Token: 0x0600F1E3 RID: 61923 RVA: 0x006C3910 File Offset: 0x006C1B10
		private void NDKEHAGOCMI()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.KIGACGJAJKO().target.rotation;
			}
			if (this.ik.solver.MJOPIBNHGIK().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x0600F1E4 RID: 61924 RVA: 0x006C39C4 File Offset: 0x006C1BC4
		private void FHDABLNCMKA()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.DBCIMCKLHIM().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.EMPOFCMIGLD().target.rotation;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x0600F1E5 RID: 61925 RVA: 0x006C3A78 File Offset: 0x006C1C78
		private void MJHFHPFPECI()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.CMKJIGNKIMG().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.KIGACGJAJKO().target.rotation;
			}
			if (this.ik.solver.MJOPIBNHGIK().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x0600F1E6 RID: 61926 RVA: 0x006C3B2C File Offset: 0x006C1D2C
		private void EIEKEPGNGPL()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NDKEHAGOCMI));
				this.EOFDOPLDFCG = false;
			}
			if (this.ik.solver.DBCIMCKLHIM().target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.OPEJJGIIIDO().bendConstraint.direction = this.ik.solver.KIGACGJAJKO().target.rotation * left + this.ik.solver.EMPOFCMIGLD().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.leftArmChain.bendConstraint.weight = 1891f;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.KAPMOCHHMDF().bendConstraint.direction = this.ik.solver.MJOPIBNHGIK().target.rotation * right + this.ik.solver.rightHandEffector.target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.AFIIFEDPGAP().bendConstraint.weight = 1763f;
			}
		}

		// Token: 0x0600F1E7 RID: 61927 RVA: 0x006C3D18 File Offset: 0x006C1F18
		private void DFNDDPJBCBO()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.CMKJIGNKIMG().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.CMKJIGNKIMG().target.rotation;
			}
			if (this.ik.solver.rightHandEffector.target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x0600F1E8 RID: 61928 RVA: 0x006C3DCC File Offset: 0x006C1FCC
		private void OIKMLNIPLIA()
		{
			if (this.ik == null)
			{
				return;
			}
			if (!this.EOFDOPLDFCG)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FMLLPNOMFHD));
				this.EOFDOPLDFCG = true;
			}
			if (this.ik.solver.leftHandEffector.target != null)
			{
				Vector3 left = Vector3.left;
				this.ik.solver.leftArmChain.bendConstraint.direction = this.ik.solver.EMPOFCMIGLD().target.rotation * left + this.ik.solver.EMPOFCMIGLD().target.rotation * this.bendDirectionOffsetLeft + this.ik.transform.rotation * this.characterSpaceBendOffsetLeft;
				this.ik.solver.leftArmChain.bendConstraint.weight = 443f;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				Vector3 right = Vector3.right;
				this.ik.solver.rightArmChain.bendConstraint.direction = this.ik.solver.IANMIEDIJPJ().target.rotation * right + this.ik.solver.MJOPIBNHGIK().target.rotation * this.bendDirectionOffsetRight + this.ik.transform.rotation * this.characterSpaceBendOffsetRight;
				this.ik.solver.AFIIFEDPGAP().bendConstraint.weight = 1563f;
			}
		}

		// Token: 0x0600F1E9 RID: 61929 RVA: 0x006C3FB8 File Offset: 0x006C21B8
		private void FJFAEHMGALO()
		{
			if (this.ik == null)
			{
				return;
			}
			if (this.ik.solver.KIGACGJAJKO().target != null)
			{
				this.ik.references.leftHand.rotation = this.ik.solver.KIGACGJAJKO().target.rotation;
			}
			if (this.ik.solver.IANMIEDIJPJ().target != null)
			{
				this.ik.references.rightHand.rotation = this.ik.solver.rightHandEffector.target.rotation;
			}
		}

		// Token: 0x04001F60 RID: 8032
		public FullBodyBipedIK ik;

		// Token: 0x04001F61 RID: 8033
		public Vector3 bendDirectionOffsetLeft;

		// Token: 0x04001F62 RID: 8034
		public Vector3 bendDirectionOffsetRight;

		// Token: 0x04001F63 RID: 8035
		public Vector3 characterSpaceBendOffsetLeft;

		// Token: 0x04001F64 RID: 8036
		public Vector3 characterSpaceBendOffsetRight;

		// Token: 0x04001F65 RID: 8037
		private Quaternion AMKBMCIAGEM;

		// Token: 0x04001F66 RID: 8038
		private Quaternion AAENLMCMLJK;

		// Token: 0x04001F67 RID: 8039
		private bool EOFDOPLDFCG;
	}
}
