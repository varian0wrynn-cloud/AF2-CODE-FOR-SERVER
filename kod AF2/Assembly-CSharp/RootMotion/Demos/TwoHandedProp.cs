using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000414 RID: 1044
	public class TwoHandedProp : MonoBehaviour
	{
		// Token: 0x0600E03F RID: 57407 RVA: 0x00666570 File Offset: 0x00664770
		private void HBKAEIJLKPM()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.rightHandEffector.target.position + this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation = this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E040 RID: 57408 RVA: 0x00666668 File Offset: 0x00664868
		private void LPPCOLNIMGM()
		{
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().bone.rotation = this.OJMBOCNNLMI.solver.leftHandEffector.rotation;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.rotation;
		}

		// Token: 0x0600E041 RID: 57409 RVA: 0x006666D4 File Offset: 0x006648D4
		private void NCBLFNKNEDK()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HCNEOLCJHGD));
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 1566f;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = 1848f;
			if (this.OJMBOCNNLMI.solver.rightHandEffector.target == null)
			{
				Debug.LogError("1 Hand Sword Charge Up");
			}
		}

		// Token: 0x0600E042 RID: 57410 RVA: 0x00666774 File Offset: 0x00664974
		private void ELLDPCIAICH()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.OHLFOJDMCGH));
			}
		}

		// Token: 0x0600E043 RID: 57411 RVA: 0x006667B0 File Offset: 0x006649B0
		private void NCOJPBKLANI()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E044 RID: 57412 RVA: 0x006668A8 File Offset: 0x00664AA8
		private void ALNLHBJOONB()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.leftHandEffector.rotation;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.rotation;
		}

		// Token: 0x0600E045 RID: 57413 RVA: 0x00666914 File Offset: 0x00664B14
		private void ALADPMILHEN()
		{
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.rotation = this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x0600E046 RID: 57414 RVA: 0x00666980 File Offset: 0x00664B80
		private void CJNBMPCNKHP()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HCNEOLCJHGD));
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 378f;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = 1822f;
			if (this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target == null)
			{
				Debug.LogError("MotorbikeWheely");
			}
		}

		// Token: 0x0600E047 RID: 57415 RVA: 0x00666A20 File Offset: 0x00664C20
		private void LKOLHNPIBLM()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E048 RID: 57416 RVA: 0x00666B16 File Offset: 0x00664D16
		private void JJHAIFDONLP()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GCCDIPKGDGP));
			}
		}

		// Token: 0x0600E049 RID: 57417 RVA: 0x00666B54 File Offset: 0x00664D54
		private void BENCPPPLDIC()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.rightHandEffector.target.position + this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E04A RID: 57418 RVA: 0x00666C4C File Offset: 0x00664E4C
		private void GHIJFOALMHM()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E04B RID: 57419 RVA: 0x00666D44 File Offset: 0x00664F44
		private void BCDEKLBIDEF()
		{
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().bone.rotation = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation;
			this.OJMBOCNNLMI.solver.rightHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().rotation;
		}

		// Token: 0x0600E04C RID: 57420 RVA: 0x00666DB0 File Offset: 0x00664FB0
		private void ONIHHFLOJMN()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LKNBJODGMNI));
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 1970f;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = 349f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("lifeBar");
			}
		}

		// Token: 0x0600E04E RID: 57422 RVA: 0x00666E50 File Offset: 0x00665050
		private void GBANNFDMGDD()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BCDEKLBIDEF));
			}
		}

		// Token: 0x0600E04F RID: 57423 RVA: 0x00666E8C File Offset: 0x0066508C
		private void LBBGAADLMOM()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().position = this.OJMBOCNNLMI.solver.rightHandEffector.target.position + this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E050 RID: 57424 RVA: 0x00666F82 File Offset: 0x00665182
		private void MPJEHEBNLDH()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BMFHLIKMDLJ));
			}
		}

		// Token: 0x0600E051 RID: 57425 RVA: 0x00666FBE File Offset: 0x006651BE
		private void FHPOOMAIJIC()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DIIBEGNFFME));
			}
		}

		// Token: 0x0600E052 RID: 57426 RVA: 0x00666FFC File Offset: 0x006651FC
		private void DGDGMFDPEHO()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.ALADPMILHEN));
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = 1772f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 655f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("HALIGN");
			}
		}

		// Token: 0x0600E053 RID: 57427 RVA: 0x0066709C File Offset: 0x0066529C
		private void FEBIICIMLHA()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NPEBLDGFPKB));
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 1802f;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = 915f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("KatanaReady");
			}
		}

		// Token: 0x0600E054 RID: 57428 RVA: 0x0066713C File Offset: 0x0066533C
		private void ELCNJDNCAEP()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FEBKCOIDDME));
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1841f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 599f;
			if (this.OJMBOCNNLMI.solver.rightHandEffector.target == null)
			{
				Debug.LogError("innerPerk");
			}
		}

		// Token: 0x0600E055 RID: 57429 RVA: 0x006671DC File Offset: 0x006653DC
		private void JPGFHBACEGG()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().position = this.OJMBOCNNLMI.solver.rightHandEffector.target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E056 RID: 57430 RVA: 0x006672D4 File Offset: 0x006654D4
		private void Start()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 1f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 1f;
			if (this.OJMBOCNNLMI.solver.rightHandEffector.target == null)
			{
				Debug.LogError("Right Hand Effector needs a Target in this demo.");
			}
		}

		// Token: 0x0600E057 RID: 57431 RVA: 0x00667374 File Offset: 0x00665574
		private void OIICPEBHHKA()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MBGGADCLHDC));
			}
		}

		// Token: 0x0600E058 RID: 57432 RVA: 0x006673B0 File Offset: 0x006655B0
		private void IDFHJDDHFPP()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CHOOLBPOCGE));
			}
		}

		// Token: 0x0600E059 RID: 57433 RVA: 0x006673EC File Offset: 0x006655EC
		private void LHFBEKCIKOI()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E05A RID: 57434 RVA: 0x006674E4 File Offset: 0x006656E4
		private void GCCDIPKGDGP()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x0600E05B RID: 57435 RVA: 0x00667550 File Offset: 0x00665750
		private void MMOFMEDKJGD()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x0600E05C RID: 57436 RVA: 0x006675BC File Offset: 0x006657BC
		private void FEBKCOIDDME()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation;
			this.OJMBOCNNLMI.solver.rightHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.rotation;
		}

		// Token: 0x0600E05D RID: 57437 RVA: 0x00667628 File Offset: 0x00665828
		private void BAGANMBKFMB()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().rotation;
		}

		// Token: 0x0600E05E RID: 57438 RVA: 0x006673B0 File Offset: 0x006655B0
		private void LLKLLMDFALO()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CHOOLBPOCGE));
			}
		}

		// Token: 0x0600E05F RID: 57439 RVA: 0x00667693 File Offset: 0x00665893
		private void KDKONDIFHHK()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PGNJCGEKMLB));
			}
		}

		// Token: 0x0600E060 RID: 57440 RVA: 0x006676CF File Offset: 0x006658CF
		private void MCIJGNDJODM()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HCNEOLCJHGD));
			}
		}

		// Token: 0x0600E061 RID: 57441 RVA: 0x0066770C File Offset: 0x0066590C
		private void KEACPNJHBIL()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.rightHandEffector.target.position + this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation = this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E062 RID: 57442 RVA: 0x00667804 File Offset: 0x00665A04
		private void IGADEOFAIOF()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E063 RID: 57443 RVA: 0x006678FA File Offset: 0x00665AFA
		private void EGIPIGJNNJP()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LIEDFGPNLOB));
			}
		}

		// Token: 0x0600E064 RID: 57444 RVA: 0x00667938 File Offset: 0x00665B38
		private void MBGGADCLHDC()
		{
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.rotation = this.OJMBOCNNLMI.solver.leftHandEffector.rotation;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.rotation;
		}

		// Token: 0x0600E065 RID: 57445 RVA: 0x00666774 File Offset: 0x00664974
		private void DNJOPHOLBNB()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.OHLFOJDMCGH));
			}
		}

		// Token: 0x0600E066 RID: 57446 RVA: 0x006679A4 File Offset: 0x00665BA4
		private void KJJNMNKPNCH()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BCDEKLBIDEF));
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 1054f;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = 463f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("WeaponInstant");
			}
		}

		// Token: 0x0600E067 RID: 57447 RVA: 0x00667A44 File Offset: 0x00665C44
		private void ANHOOJFEJJE()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BMFHLIKMDLJ));
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1102f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 1366f;
			if (this.OJMBOCNNLMI.solver.rightHandEffector.target == null)
			{
				Debug.LogError("OfficeSittingLegCross");
			}
		}

		// Token: 0x0600E068 RID: 57448 RVA: 0x00667AE4 File Offset: 0x00665CE4
		private void OnDestroy()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			}
		}

		// Token: 0x0600E069 RID: 57449 RVA: 0x00667B20 File Offset: 0x00665D20
		private void NANEAKKPDBH()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E06A RID: 57450 RVA: 0x00667C18 File Offset: 0x00665E18
		private void LIEDFGPNLOB()
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.rotation;
		}

		// Token: 0x0600E06B RID: 57451 RVA: 0x00667C84 File Offset: 0x00665E84
		private void KFGKKLAKFGH()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BDHPEBHCEID));
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 219f;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = 491f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("Katana45DegSwing");
			}
		}

		// Token: 0x0600E06C RID: 57452 RVA: 0x00667D24 File Offset: 0x00665F24
		private void BGCLAKJHAFK()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MBGGADCLHDC));
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 1035f;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = 1735f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("<b>WallHack Detector</b>");
			}
		}

		// Token: 0x0600E06D RID: 57453 RVA: 0x00666B16 File Offset: 0x00664D16
		private void MIPHMELJJJD()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GCCDIPKGDGP));
			}
		}

		// Token: 0x0600E06E RID: 57454 RVA: 0x00667DC4 File Offset: 0x00665FC4
		private void LJLHAJMJDCE()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CKIBCNCEGPM));
			}
		}

		// Token: 0x0600E06F RID: 57455 RVA: 0x00667E00 File Offset: 0x00666000
		private void CPINFJNCLMI()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E070 RID: 57456 RVA: 0x00667EF8 File Offset: 0x006660F8
		private void DIIBEGNFFME()
		{
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.rotation = this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation;
			this.OJMBOCNNLMI.solver.rightHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x0600E071 RID: 57457 RVA: 0x00667F64 File Offset: 0x00666164
		private void HEMEEOGJDOE()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BMFHLIKMDLJ));
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 560f;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = 1012f;
			if (this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target == null)
			{
				Debug.LogError("_Intensity");
			}
		}

		// Token: 0x0600E072 RID: 57458 RVA: 0x00668004 File Offset: 0x00666204
		private void IJOCHELLKJH()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DIIBEGNFFME));
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = 869f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 1843f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("rodUpDelta=");
			}
		}

		// Token: 0x0600E073 RID: 57459 RVA: 0x006680A4 File Offset: 0x006662A4
		private void CHOOLBPOCGE()
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x0600E074 RID: 57460 RVA: 0x00668110 File Offset: 0x00666310
		private void GJOFBAONFJF()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.leftHandEffector.rotation;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().rotation;
		}

		// Token: 0x0600E075 RID: 57461 RVA: 0x0066817C File Offset: 0x0066637C
		private void MLKCOBKDPCK()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation = this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E076 RID: 57462 RVA: 0x00668274 File Offset: 0x00666474
		private void BFLLJDGKKFP()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x0600E077 RID: 57463 RVA: 0x006682E0 File Offset: 0x006664E0
		private void CKCBGFMFNFK()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E078 RID: 57464 RVA: 0x006683D6 File Offset: 0x006665D6
		private void BNHHKABAFHK()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LPPCOLNIMGM));
			}
		}

		// Token: 0x0600E079 RID: 57465 RVA: 0x00668414 File Offset: 0x00666614
		private void PLKIPDHMFBH()
		{
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.rotation = this.OJMBOCNNLMI.solver.leftHandEffector.rotation;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.rotation;
		}

		// Token: 0x0600E07A RID: 57466 RVA: 0x00668480 File Offset: 0x00666680
		private void NPEBLDGFPKB()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x0600E07B RID: 57467 RVA: 0x006684EC File Offset: 0x006666EC
		private void CKGPEFOKKNL()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.HCNEOLCJHGD));
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 1277f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 148f;
			if (this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target == null)
			{
				Debug.LogError("");
			}
		}

		// Token: 0x0600E07C RID: 57468 RVA: 0x0066858C File Offset: 0x0066678C
		private void GCJBBACOJJE()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E07D RID: 57469 RVA: 0x00668684 File Offset: 0x00666884
		private void DFNJNCCPKJF()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().position = this.OJMBOCNNLMI.solver.rightHandEffector.target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E07E RID: 57470 RVA: 0x0066877A File Offset: 0x0066697A
		private void LPNHJCGGBPH()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BFLLJDGKKFP));
			}
		}

		// Token: 0x0600E07F RID: 57471 RVA: 0x006687B8 File Offset: 0x006669B8
		private void MMACLBBMDLA()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.ALNLHBJOONB));
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = 1683f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 233f;
			if (this.OJMBOCNNLMI.solver.rightHandEffector.target == null)
			{
				Debug.LogError("ArmFlex6");
			}
		}

		// Token: 0x0600E080 RID: 57472 RVA: 0x00668858 File Offset: 0x00666A58
		private void MPCIGAPGLIB()
		{
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.rotation = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation;
			this.OJMBOCNNLMI.solver.rightHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().rotation;
		}

		// Token: 0x0600E081 RID: 57473 RVA: 0x006688C3 File Offset: 0x00666AC3
		private void FLGGHNOABOA()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BDHPEBHCEID));
			}
		}

		// Token: 0x0600E082 RID: 57474 RVA: 0x00668900 File Offset: 0x00666B00
		private void OEFDEEOHNJB()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation = this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E083 RID: 57475 RVA: 0x006689F8 File Offset: 0x00666BF8
		private void PGNJCGEKMLB()
		{
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.rotation = this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation;
			this.OJMBOCNNLMI.solver.rightHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x0600E084 RID: 57476 RVA: 0x00668A64 File Offset: 0x00666C64
		private void HCNEOLCJHGD()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation;
			this.OJMBOCNNLMI.solver.rightHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x0600E085 RID: 57477 RVA: 0x00668AD0 File Offset: 0x00666CD0
		private void ELADFDNPOOI()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BFLLJDGKKFP));
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1662f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 426f;
			if (this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target == null)
			{
				Debug.LogError(" ");
			}
		}

		// Token: 0x0600E086 RID: 57478 RVA: 0x00668B70 File Offset: 0x00666D70
		private void LateUpdate()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.OJMBOCNNLMI.solver.rightHandEffector.target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E087 RID: 57479 RVA: 0x00668C68 File Offset: 0x00666E68
		private void KMOHGOOEJOI()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E088 RID: 57480 RVA: 0x00667AE4 File Offset: 0x00665CE4
		private void CABMDBPACPO()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			}
		}

		// Token: 0x0600E089 RID: 57481 RVA: 0x00668D60 File Offset: 0x00666F60
		private void FFIGGPHAIBP()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GJOFBAONFJF));
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 1754f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 1925f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("SneakRight");
			}
		}

		// Token: 0x0600E08A RID: 57482 RVA: 0x00668E00 File Offset: 0x00667000
		private void ALPOPEGDHBL()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MPCIGAPGLIB));
			}
		}

		// Token: 0x0600E08B RID: 57483 RVA: 0x00668E3C File Offset: 0x0066703C
		private void IJFPHGEFOLF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FEBKCOIDDME));
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 743f;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = 1109f;
			if (this.OJMBOCNNLMI.solver.rightHandEffector.target == null)
			{
				Debug.LogError("isRealView");
			}
		}

		// Token: 0x0600E08C RID: 57484 RVA: 0x00668EDC File Offset: 0x006670DC
		private void DOHJPDNKALP()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PFNCMMBADLM));
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 76f;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = 877f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("");
			}
		}

		// Token: 0x0600E08D RID: 57485 RVA: 0x00668F7C File Offset: 0x0066717C
		private void OHAOGONDAHA()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E08E RID: 57486 RVA: 0x00669074 File Offset: 0x00667274
		private void EBPAOHJNAKD()
		{
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().bone.rotation = this.OJMBOCNNLMI.solver.leftHandEffector.rotation;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().rotation;
		}

		// Token: 0x0600E08F RID: 57487 RVA: 0x006690E0 File Offset: 0x006672E0
		private void OBJCOJEHLBE()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LPJKBGNEJED));
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1640f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 322f;
			if (this.OJMBOCNNLMI.solver.rightHandEffector.target == null)
			{
				Debug.LogError("TOD_CloudDensity");
			}
		}

		// Token: 0x0600E090 RID: 57488 RVA: 0x00669180 File Offset: 0x00667380
		private void LKNBJODGMNI()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x0600E091 RID: 57489 RVA: 0x006691EB File Offset: 0x006673EB
		private void EDFBGLOHBDG()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PFNCMMBADLM));
			}
		}

		// Token: 0x0600E092 RID: 57490 RVA: 0x00669228 File Offset: 0x00667428
		private void PFNCMMBADLM()
		{
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.rotation = this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation;
			this.OJMBOCNNLMI.solver.rightHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.rotation;
		}

		// Token: 0x0600E093 RID: 57491 RVA: 0x00669294 File Offset: 0x00667494
		private void ADPIMKDHDEH()
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().rotation;
		}

		// Token: 0x0600E094 RID: 57492 RVA: 0x006692FF File Offset: 0x006674FF
		private void BCNGPIGDICE()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LPJKBGNEJED));
			}
		}

		// Token: 0x0600E095 RID: 57493 RVA: 0x0066933B File Offset: 0x0066753B
		private void EIMMHKNMIKI()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PLKIPDHMFBH));
			}
		}

		// Token: 0x0600E096 RID: 57494 RVA: 0x00669377 File Offset: 0x00667577
		private void PGOIIHGJIHE()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FEBKCOIDDME));
			}
		}

		// Token: 0x0600E097 RID: 57495 RVA: 0x006693B4 File Offset: 0x006675B4
		private void FODDAMMNECI()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.DIIBEGNFFME));
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1092f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 1771f;
			if (this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target == null)
			{
				Debug.LogError("IdleFeedThrow");
			}
		}

		// Token: 0x0600E098 RID: 57496 RVA: 0x00667AE4 File Offset: 0x00665CE4
		private void IOFCKOOCIMG()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.NBEGFDOMFJP));
			}
		}

		// Token: 0x0600E099 RID: 57497 RVA: 0x00669454 File Offset: 0x00667654
		private void NCALLFHEAGJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.EBPAOHJNAKD));
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 1332f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 584f;
			if (this.OJMBOCNNLMI.solver.rightHandEffector.target == null)
			{
				Debug.LogError("crft_wpnpr");
			}
		}

		// Token: 0x0600E09A RID: 57498 RVA: 0x006694F4 File Offset: 0x006676F4
		private void GJKCGGCCIAJ()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E09B RID: 57499 RVA: 0x006695EC File Offset: 0x006677EC
		private void ADLHNBEDHMJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GCCDIPKGDGP));
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 229f;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = 1132f;
			if (this.OJMBOCNNLMI.solver.rightHandEffector.target == null)
			{
				Debug.LogError("Turn");
			}
		}

		// Token: 0x0600E09C RID: 57500 RVA: 0x0066968C File Offset: 0x0066788C
		private void NBEGFDOMFJP()
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.leftHandEffector.rotation;
			this.OJMBOCNNLMI.solver.rightHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.rotation;
		}

		// Token: 0x0600E09D RID: 57501 RVA: 0x006696F8 File Offset: 0x006678F8
		private void GOAIDNCOCIB()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.rightHandEffector.target.position + this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E09E RID: 57502 RVA: 0x006697F0 File Offset: 0x006679F0
		private void LCMMGLMJPOK()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E09F RID: 57503 RVA: 0x006678FA File Offset: 0x00665AFA
		private void KFFJIJMDBOF()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LIEDFGPNLOB));
			}
		}

		// Token: 0x0600E0A0 RID: 57504 RVA: 0x006698E8 File Offset: 0x00667AE8
		private void POMLHOHFIGA()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E0A1 RID: 57505 RVA: 0x00666F82 File Offset: 0x00665182
		private void MOILNLOMCAK()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BMFHLIKMDLJ));
			}
		}

		// Token: 0x0600E0A2 RID: 57506 RVA: 0x006699E0 File Offset: 0x00667BE0
		private void IAAOGAPJDID()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MBGGADCLHDC));
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 1393f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 1344f;
			if (this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target == null)
			{
				Debug.LogError("");
			}
		}

		// Token: 0x0600E0A3 RID: 57507 RVA: 0x00669A80 File Offset: 0x00667C80
		private void MCPKECOLINL()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MMOFMEDKJGD));
			}
		}

		// Token: 0x0600E0A4 RID: 57508 RVA: 0x00669ABC File Offset: 0x00667CBC
		private void CHDJGEOFHEE()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GCCDIPKGDGP));
			this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 1800f;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = 1237f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("FaceHit");
			}
		}

		// Token: 0x0600E0A5 RID: 57509 RVA: 0x00669B5C File Offset: 0x00667D5C
		private void CHGHJOFGPGH()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GJOFBAONFJF));
			}
		}

		// Token: 0x0600E0A6 RID: 57510 RVA: 0x00669B98 File Offset: 0x00667D98
		private void BDHPEBHCEID()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.rotation;
		}

		// Token: 0x0600E0A7 RID: 57511 RVA: 0x00669A80 File Offset: 0x00667C80
		private void IPEPMDODMED()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.MMOFMEDKJGD));
			}
		}

		// Token: 0x0600E0A8 RID: 57512 RVA: 0x00669C04 File Offset: 0x00667E04
		private void NENOAPOICLA()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.position + this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E0A9 RID: 57513 RVA: 0x00669CFC File Offset: 0x00667EFC
		private void CLHGHANANNL()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BDHPEBHCEID));
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1786f;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = 1324f;
			if (this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target == null)
			{
				Debug.LogError(", ");
			}
		}

		// Token: 0x0600E0AA RID: 57514 RVA: 0x00669D9C File Offset: 0x00667F9C
		private void KEMGOLACEHI()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.FEBKCOIDDME));
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 163f;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = 323f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("F3");
			}
		}

		// Token: 0x0600E0AB RID: 57515 RVA: 0x00667DC4 File Offset: 0x00665FC4
		private void ICIIKJJJOEJ()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.CKIBCNCEGPM));
			}
		}

		// Token: 0x0600E0AC RID: 57516 RVA: 0x006692FF File Offset: 0x006674FF
		private void PNAPPHLKMIG()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LPJKBGNEJED));
			}
		}

		// Token: 0x0600E0AD RID: 57517 RVA: 0x00669E3C File Offset: 0x0066803C
		private void IBPGMFNDPHH()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.GCCDIPKGDGP));
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1506f;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionWeight = 711f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("IdleStrafeRight");
			}
		}

		// Token: 0x0600E0AE RID: 57518 RVA: 0x00669EDC File Offset: 0x006680DC
		private void JHAKJAMBNAH()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.ALNLHBJOONB));
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = 1184f;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = 1612f;
			if (this.OJMBOCNNLMI.solver.rightHandEffector.target == null)
			{
				Debug.LogError("** Panel save position");
			}
		}

		// Token: 0x0600E0AF RID: 57519 RVA: 0x00669F7C File Offset: 0x0066817C
		private void BMFHLIKMDLJ()
		{
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().bone.rotation = this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x0600E0B0 RID: 57520 RVA: 0x00669FE8 File Offset: 0x006681E8
		private void HFHGBPFDMGJ()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().position = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E0B1 RID: 57521 RVA: 0x0066A0E0 File Offset: 0x006682E0
		private void OHLFOJDMCGH()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.leftHandEffector.rotation;
			this.OJMBOCNNLMI.solver.rightHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().rotation;
		}

		// Token: 0x0600E0B2 RID: 57522 RVA: 0x0066A14C File Offset: 0x0066834C
		private void CGMHGDEKDEP()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.BDHPEBHCEID));
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 243f;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionWeight = 1184f;
			if (this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target == null)
			{
				Debug.LogError("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_trigonometric_i_k.html");
			}
		}

		// Token: 0x0600E0B3 RID: 57523 RVA: 0x0066A1EC File Offset: 0x006683EC
		private void LPJKBGNEJED()
		{
			this.OJMBOCNNLMI.solver.leftHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.rotation = this.OJMBOCNNLMI.solver.rightHandEffector.rotation;
		}

		// Token: 0x0600E0B4 RID: 57524 RVA: 0x0066A257 File Offset: 0x00668457
		private void NKNDJENDPDJ()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.ADPIMKDHDEH));
			}
		}

		// Token: 0x0600E0B5 RID: 57525 RVA: 0x0066933B File Offset: 0x0066753B
		private void JPJDMNNLBKG()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.PLKIPDHMFBH));
			}
		}

		// Token: 0x0600E0B6 RID: 57526 RVA: 0x0066A294 File Offset: 0x00668494
		private void CBLGFOFHNPJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPostUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPostUpdate, new IKSolver.LGGEKCCEELN(this.LIEDFGPNLOB));
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1707f;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionWeight = 1221f;
			if (this.OJMBOCNNLMI.solver.IANMIEDIJPJ().target == null)
			{
				Debug.LogError("WATER_SIMPLE");
			}
		}

		// Token: 0x0600E0B7 RID: 57527 RVA: 0x0066A334 File Offset: 0x00668534
		private void HHJKBKLPLIM()
		{
			this.GIJGIOIGIDD = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.leftHandTarget.position);
			this.FOPBNALIHPO = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.leftHandTarget.rotation;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().position = this.OJMBOCNNLMI.solver.rightHandEffector.target.position + this.OJMBOCNNLMI.solver.rightHandEffector.target.rotation * this.GIJGIOIGIDD;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation = this.OJMBOCNNLMI.solver.MJOPIBNHGIK().target.rotation * this.FOPBNALIHPO;
		}

		// Token: 0x0600E0B8 RID: 57528 RVA: 0x0066A42C File Offset: 0x0066862C
		private void CKIBCNCEGPM()
		{
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.rotation = this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation;
			this.OJMBOCNNLMI.solver.rightHandEffector.bone.rotation = this.OJMBOCNNLMI.solver.IANMIEDIJPJ().rotation;
		}

		// Token: 0x04001D8B RID: 7563
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		// Token: 0x04001D8C RID: 7564
		private FullBodyBipedIK OJMBOCNNLMI;

		// Token: 0x04001D8D RID: 7565
		private Vector3 GIJGIOIGIDD;

		// Token: 0x04001D8E RID: 7566
		private Quaternion FOPBNALIHPO;
	}
}
