using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003F7 RID: 1015
	public class FBIKHandsOnProp : MonoBehaviour
	{
		// Token: 0x0600DA21 RID: 55841 RVA: 0x0063DA5B File Offset: 0x0063BC5B
		private void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.PHLHKALHHPF));
			}
		}

		// Token: 0x0600DA23 RID: 55843 RVA: 0x0063DA98 File Offset: 0x0063BC98
		private void EFAODNPJKEH()
		{
			if (this.leftHanded)
			{
				this.PHHHMCAHAFK(this.ik.solver.CMKJIGNKIMG(), this.ik.solver.MJOPIBNHGIK());
				return;
			}
			this.OJPBIGDJCON(this.ik.solver.IANMIEDIJPJ(), this.ik.solver.EMPOFCMIGLD());
		}

		// Token: 0x0600DA24 RID: 55844 RVA: 0x0063DAFA File Offset: 0x0063BCFA
		private void PCJIEHPPNMH()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.MLNLDAOOHCA));
			}
		}

		// Token: 0x0600DA25 RID: 55845 RVA: 0x0063DB38 File Offset: 0x0063BD38
		private void BAJLNLGIGKC()
		{
			if (this.leftHanded)
			{
				this.CIDHNFELHBO(this.ik.solver.CMKJIGNKIMG(), this.ik.solver.rightHandEffector);
				return;
			}
			this.DBOCKLLFPKC(this.ik.solver.IANMIEDIJPJ(), this.ik.solver.leftHandEffector);
		}

		// Token: 0x0600DA26 RID: 55846 RVA: 0x0063DB9A File Offset: 0x0063BD9A
		private void NJHJLHBNPOM()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.MAJONMHNLIJ));
			}
		}

		// Token: 0x0600DA27 RID: 55847 RVA: 0x0063DBD8 File Offset: 0x0063BDD8
		private void FKHNAMDMFCF(IKEffector IHJOOJHGGAF, IKEffector ALAIGFBNNOP)
		{
			Vector3 vector = ALAIGFBNNOP.bone.position - IHJOOJHGGAF.bone.position;
			Vector3 point = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * vector;
			Vector3 b = IHJOOJHGGAF.bone.position + vector * 1488f;
			Quaternion rhs = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * ALAIGFBNNOP.bone.rotation;
			Vector3 toDirection = ALAIGFBNNOP.bone.position + ALAIGFBNNOP.positionOffset - (IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset);
			Vector3 a = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + vector * 1126f;
			IHJOOJHGGAF.position = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + (a - b);
			IHJOOJHGGAF.positionWeight = 1999f;
			Quaternion lhs = Quaternion.FromToRotation(vector, toDirection);
			IHJOOJHGGAF.rotation = lhs * IHJOOJHGGAF.bone.rotation;
			IHJOOJHGGAF.rotationWeight = 1815f;
			ALAIGFBNNOP.position = IHJOOJHGGAF.position + IHJOOJHGGAF.rotation * point;
			ALAIGFBNNOP.positionWeight = 316f;
			ALAIGFBNNOP.rotation = IHJOOJHGGAF.rotation * rhs;
			ALAIGFBNNOP.rotationWeight = 1013f;
		}

		// Token: 0x0600DA28 RID: 55848 RVA: 0x0063DD58 File Offset: 0x0063BF58
		private void MLNLDAOOHCA()
		{
			if (this.leftHanded)
			{
				this.OHBOJPCLKAP(this.ik.solver.DBCIMCKLHIM(), this.ik.solver.rightHandEffector);
				return;
			}
			this.FKHNAMDMFCF(this.ik.solver.rightHandEffector, this.ik.solver.EMPOFCMIGLD());
		}

		// Token: 0x0600DA29 RID: 55849 RVA: 0x0063DDBA File Offset: 0x0063BFBA
		private void MNIOJGMLIMC()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.OLFFFMFMFMP));
		}

		// Token: 0x0600DA2A RID: 55850 RVA: 0x0063DDE8 File Offset: 0x0063BFE8
		private void JGKDNHLKBEN()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.MAJONMHNLIJ));
		}

		// Token: 0x0600DA2B RID: 55851 RVA: 0x0063DDE8 File Offset: 0x0063BFE8
		private void CBBIADNKMLI()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.MAJONMHNLIJ));
		}

		// Token: 0x0600DA2C RID: 55852 RVA: 0x0063DE18 File Offset: 0x0063C018
		private void CIDHNFELHBO(IKEffector IHJOOJHGGAF, IKEffector ALAIGFBNNOP)
		{
			Vector3 vector = ALAIGFBNNOP.bone.position - IHJOOJHGGAF.bone.position;
			Vector3 point = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * vector;
			Vector3 b = IHJOOJHGGAF.bone.position + vector * 771f;
			Quaternion rhs = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * ALAIGFBNNOP.bone.rotation;
			Vector3 toDirection = ALAIGFBNNOP.bone.position + ALAIGFBNNOP.positionOffset - (IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset);
			Vector3 a = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + vector * 580f;
			IHJOOJHGGAF.position = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + (a - b);
			IHJOOJHGGAF.positionWeight = 1758f;
			Quaternion lhs = Quaternion.FromToRotation(vector, toDirection);
			IHJOOJHGGAF.rotation = lhs * IHJOOJHGGAF.bone.rotation;
			IHJOOJHGGAF.rotationWeight = 396f;
			ALAIGFBNNOP.position = IHJOOJHGGAF.position + IHJOOJHGGAF.rotation * point;
			ALAIGFBNNOP.positionWeight = 644f;
			ALAIGFBNNOP.rotation = IHJOOJHGGAF.rotation * rhs;
			ALAIGFBNNOP.rotationWeight = 24f;
		}

		// Token: 0x0600DA2D RID: 55853 RVA: 0x0063DF98 File Offset: 0x0063C198
		private void PHLHKALHHPF()
		{
			if (this.leftHanded)
			{
				this.PHHHMCAHAFK(this.ik.solver.leftHandEffector, this.ik.solver.rightHandEffector);
				return;
			}
			this.PHHHMCAHAFK(this.ik.solver.rightHandEffector, this.ik.solver.leftHandEffector);
		}

		// Token: 0x0600DA2E RID: 55854 RVA: 0x0063DFFA File Offset: 0x0063C1FA
		private void NKNDJENDPDJ()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.DAKOGPEEFJJ));
			}
		}

		// Token: 0x0600DA2F RID: 55855 RVA: 0x0063E038 File Offset: 0x0063C238
		private void MAJONMHNLIJ()
		{
			if (this.leftHanded)
			{
				this.OHBOJPCLKAP(this.ik.solver.KIGACGJAJKO(), this.ik.solver.rightHandEffector);
				return;
			}
			this.CIDHNFELHBO(this.ik.solver.rightHandEffector, this.ik.solver.leftHandEffector);
		}

		// Token: 0x0600DA30 RID: 55856 RVA: 0x0063E09C File Offset: 0x0063C29C
		private void MMCPMEHKALJ()
		{
			if (this.leftHanded)
			{
				this.OHBOJPCLKAP(this.ik.solver.EMPOFCMIGLD(), this.ik.solver.IANMIEDIJPJ());
				return;
			}
			this.GCAPKALEMEO(this.ik.solver.rightHandEffector, this.ik.solver.CMKJIGNKIMG());
		}

		// Token: 0x0600DA31 RID: 55857 RVA: 0x0063E100 File Offset: 0x0063C300
		private void OJPBIGDJCON(IKEffector IHJOOJHGGAF, IKEffector ALAIGFBNNOP)
		{
			Vector3 vector = ALAIGFBNNOP.bone.position - IHJOOJHGGAF.bone.position;
			Vector3 point = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * vector;
			Vector3 b = IHJOOJHGGAF.bone.position + vector * 727f;
			Quaternion rhs = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * ALAIGFBNNOP.bone.rotation;
			Vector3 toDirection = ALAIGFBNNOP.bone.position + ALAIGFBNNOP.positionOffset - (IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset);
			Vector3 a = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + vector * 1326f;
			IHJOOJHGGAF.position = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + (a - b);
			IHJOOJHGGAF.positionWeight = 594f;
			Quaternion lhs = Quaternion.FromToRotation(vector, toDirection);
			IHJOOJHGGAF.rotation = lhs * IHJOOJHGGAF.bone.rotation;
			IHJOOJHGGAF.rotationWeight = 1211f;
			ALAIGFBNNOP.position = IHJOOJHGGAF.position + IHJOOJHGGAF.rotation * point;
			ALAIGFBNNOP.positionWeight = 684f;
			ALAIGFBNNOP.rotation = IHJOOJHGGAF.rotation * rhs;
			ALAIGFBNNOP.rotationWeight = 274f;
		}

		// Token: 0x0600DA32 RID: 55858 RVA: 0x0063E280 File Offset: 0x0063C480
		private void DBOCKLLFPKC(IKEffector IHJOOJHGGAF, IKEffector ALAIGFBNNOP)
		{
			Vector3 vector = ALAIGFBNNOP.bone.position - IHJOOJHGGAF.bone.position;
			Vector3 point = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * vector;
			Vector3 b = IHJOOJHGGAF.bone.position + vector * 1884f;
			Quaternion rhs = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * ALAIGFBNNOP.bone.rotation;
			Vector3 toDirection = ALAIGFBNNOP.bone.position + ALAIGFBNNOP.positionOffset - (IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset);
			Vector3 a = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + vector * 1925f;
			IHJOOJHGGAF.position = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + (a - b);
			IHJOOJHGGAF.positionWeight = 1963f;
			Quaternion lhs = Quaternion.FromToRotation(vector, toDirection);
			IHJOOJHGGAF.rotation = lhs * IHJOOJHGGAF.bone.rotation;
			IHJOOJHGGAF.rotationWeight = 1612f;
			ALAIGFBNNOP.position = IHJOOJHGGAF.position + IHJOOJHGGAF.rotation * point;
			ALAIGFBNNOP.positionWeight = 404f;
			ALAIGFBNNOP.rotation = IHJOOJHGGAF.rotation * rhs;
			ALAIGFBNNOP.rotationWeight = 1613f;
		}

		// Token: 0x0600DA33 RID: 55859 RVA: 0x0063E400 File Offset: 0x0063C600
		private void DAKOGPEEFJJ()
		{
			if (this.leftHanded)
			{
				this.GCAPKALEMEO(this.ik.solver.DBCIMCKLHIM(), this.ik.solver.MJOPIBNHGIK());
				return;
			}
			this.OJKDBPINJNJ(this.ik.solver.rightHandEffector, this.ik.solver.leftHandEffector);
		}

		// Token: 0x0600DA34 RID: 55860 RVA: 0x0063E464 File Offset: 0x0063C664
		private void DKCLJFBLNAA(IKEffector IHJOOJHGGAF, IKEffector ALAIGFBNNOP)
		{
			Vector3 vector = ALAIGFBNNOP.bone.position - IHJOOJHGGAF.bone.position;
			Vector3 point = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * vector;
			Vector3 b = IHJOOJHGGAF.bone.position + vector * 879f;
			Quaternion rhs = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * ALAIGFBNNOP.bone.rotation;
			Vector3 toDirection = ALAIGFBNNOP.bone.position + ALAIGFBNNOP.positionOffset - (IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset);
			Vector3 a = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + vector * 1631f;
			IHJOOJHGGAF.position = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + (a - b);
			IHJOOJHGGAF.positionWeight = 1464f;
			Quaternion lhs = Quaternion.FromToRotation(vector, toDirection);
			IHJOOJHGGAF.rotation = lhs * IHJOOJHGGAF.bone.rotation;
			IHJOOJHGGAF.rotationWeight = 1482f;
			ALAIGFBNNOP.position = IHJOOJHGGAF.position + IHJOOJHGGAF.rotation * point;
			ALAIGFBNNOP.positionWeight = 972f;
			ALAIGFBNNOP.rotation = IHJOOJHGGAF.rotation * rhs;
			ALAIGFBNNOP.rotationWeight = 1560f;
		}

		// Token: 0x0600DA35 RID: 55861 RVA: 0x0063E5E2 File Offset: 0x0063C7E2
		private void Awake()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.PHLHKALHHPF));
		}

		// Token: 0x0600DA36 RID: 55862 RVA: 0x0063DB9A File Offset: 0x0063BD9A
		private void KOGGLIAMEAH()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.MAJONMHNLIJ));
			}
		}

		// Token: 0x0600DA37 RID: 55863 RVA: 0x0063E610 File Offset: 0x0063C810
		private void ECIAEIEKCCF()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.EFAODNPJKEH));
			}
		}

		// Token: 0x0600DA38 RID: 55864 RVA: 0x0063E64C File Offset: 0x0063C84C
		private void OJKDBPINJNJ(IKEffector IHJOOJHGGAF, IKEffector ALAIGFBNNOP)
		{
			Vector3 vector = ALAIGFBNNOP.bone.position - IHJOOJHGGAF.bone.position;
			Vector3 point = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * vector;
			Vector3 b = IHJOOJHGGAF.bone.position + vector * 956f;
			Quaternion rhs = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * ALAIGFBNNOP.bone.rotation;
			Vector3 toDirection = ALAIGFBNNOP.bone.position + ALAIGFBNNOP.positionOffset - (IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset);
			Vector3 a = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + vector * 264f;
			IHJOOJHGGAF.position = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + (a - b);
			IHJOOJHGGAF.positionWeight = 745f;
			Quaternion lhs = Quaternion.FromToRotation(vector, toDirection);
			IHJOOJHGGAF.rotation = lhs * IHJOOJHGGAF.bone.rotation;
			IHJOOJHGGAF.rotationWeight = 470f;
			ALAIGFBNNOP.position = IHJOOJHGGAF.position + IHJOOJHGGAF.rotation * point;
			ALAIGFBNNOP.positionWeight = 1929f;
			ALAIGFBNNOP.rotation = IHJOOJHGGAF.rotation * rhs;
			ALAIGFBNNOP.rotationWeight = 1546f;
		}

		// Token: 0x0600DA39 RID: 55865 RVA: 0x0063E7CC File Offset: 0x0063C9CC
		private void OHBOJPCLKAP(IKEffector IHJOOJHGGAF, IKEffector ALAIGFBNNOP)
		{
			Vector3 vector = ALAIGFBNNOP.bone.position - IHJOOJHGGAF.bone.position;
			Vector3 point = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * vector;
			Vector3 b = IHJOOJHGGAF.bone.position + vector * 1312f;
			Quaternion rhs = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * ALAIGFBNNOP.bone.rotation;
			Vector3 toDirection = ALAIGFBNNOP.bone.position + ALAIGFBNNOP.positionOffset - (IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset);
			Vector3 a = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + vector * 1795f;
			IHJOOJHGGAF.position = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + (a - b);
			IHJOOJHGGAF.positionWeight = 1210f;
			Quaternion lhs = Quaternion.FromToRotation(vector, toDirection);
			IHJOOJHGGAF.rotation = lhs * IHJOOJHGGAF.bone.rotation;
			IHJOOJHGGAF.rotationWeight = 28f;
			ALAIGFBNNOP.position = IHJOOJHGGAF.position + IHJOOJHGGAF.rotation * point;
			ALAIGFBNNOP.positionWeight = 1367f;
			ALAIGFBNNOP.rotation = IHJOOJHGGAF.rotation * rhs;
			ALAIGFBNNOP.rotationWeight = 1524f;
		}

		// Token: 0x0600DA3A RID: 55866 RVA: 0x0063E94A File Offset: 0x0063CB4A
		private void CNKLGMCHEBM()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.EFAODNPJKEH));
		}

		// Token: 0x0600DA3B RID: 55867 RVA: 0x0063DB9A File Offset: 0x0063BD9A
		private void MIEEAACIPJH()
		{
			if (this.ik != null)
			{
				IKSolverFullBodyBiped solver = this.ik.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.MAJONMHNLIJ));
			}
		}

		// Token: 0x0600DA3C RID: 55868 RVA: 0x0063E978 File Offset: 0x0063CB78
		private void PHHHMCAHAFK(IKEffector IHJOOJHGGAF, IKEffector ALAIGFBNNOP)
		{
			Vector3 vector = ALAIGFBNNOP.bone.position - IHJOOJHGGAF.bone.position;
			Vector3 point = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * vector;
			Vector3 b = IHJOOJHGGAF.bone.position + vector * 0.5f;
			Quaternion rhs = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * ALAIGFBNNOP.bone.rotation;
			Vector3 toDirection = ALAIGFBNNOP.bone.position + ALAIGFBNNOP.positionOffset - (IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset);
			Vector3 a = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + vector * 0.5f;
			IHJOOJHGGAF.position = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + (a - b);
			IHJOOJHGGAF.positionWeight = 1f;
			Quaternion lhs = Quaternion.FromToRotation(vector, toDirection);
			IHJOOJHGGAF.rotation = lhs * IHJOOJHGGAF.bone.rotation;
			IHJOOJHGGAF.rotationWeight = 1f;
			ALAIGFBNNOP.position = IHJOOJHGGAF.position + IHJOOJHGGAF.rotation * point;
			ALAIGFBNNOP.positionWeight = 1f;
			ALAIGFBNNOP.rotation = IHJOOJHGGAF.rotation * rhs;
			ALAIGFBNNOP.rotationWeight = 1f;
		}

		// Token: 0x0600DA3D RID: 55869 RVA: 0x0063DDE8 File Offset: 0x0063BFE8
		private void OGKOHLPFBED()
		{
			IKSolverFullBodyBiped solver = this.ik.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.MAJONMHNLIJ));
		}

		// Token: 0x0600DA3E RID: 55870 RVA: 0x0063EAF8 File Offset: 0x0063CCF8
		private void OLFFFMFMFMP()
		{
			if (this.leftHanded)
			{
				this.FKHNAMDMFCF(this.ik.solver.CMKJIGNKIMG(), this.ik.solver.MJOPIBNHGIK());
				return;
			}
			this.DKCLJFBLNAA(this.ik.solver.MJOPIBNHGIK(), this.ik.solver.CMKJIGNKIMG());
		}

		// Token: 0x0600DA3F RID: 55871 RVA: 0x0063EB5C File Offset: 0x0063CD5C
		private void GCAPKALEMEO(IKEffector IHJOOJHGGAF, IKEffector ALAIGFBNNOP)
		{
			Vector3 vector = ALAIGFBNNOP.bone.position - IHJOOJHGGAF.bone.position;
			Vector3 point = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * vector;
			Vector3 b = IHJOOJHGGAF.bone.position + vector * 928f;
			Quaternion rhs = Quaternion.Inverse(IHJOOJHGGAF.bone.rotation) * ALAIGFBNNOP.bone.rotation;
			Vector3 toDirection = ALAIGFBNNOP.bone.position + ALAIGFBNNOP.positionOffset - (IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset);
			Vector3 a = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + vector * 1629f;
			IHJOOJHGGAF.position = IHJOOJHGGAF.bone.position + IHJOOJHGGAF.positionOffset + (a - b);
			IHJOOJHGGAF.positionWeight = 1668f;
			Quaternion lhs = Quaternion.FromToRotation(vector, toDirection);
			IHJOOJHGGAF.rotation = lhs * IHJOOJHGGAF.bone.rotation;
			IHJOOJHGGAF.rotationWeight = 1603f;
			ALAIGFBNNOP.position = IHJOOJHGGAF.position + IHJOOJHGGAF.rotation * point;
			ALAIGFBNNOP.positionWeight = 96f;
			ALAIGFBNNOP.rotation = IHJOOJHGGAF.rotation * rhs;
			ALAIGFBNNOP.rotationWeight = 1958f;
		}

		// Token: 0x04001CED RID: 7405
		public FullBodyBipedIK ik;

		// Token: 0x04001CEE RID: 7406
		public bool leftHanded;
	}
}
