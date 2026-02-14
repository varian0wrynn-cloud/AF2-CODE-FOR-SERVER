using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003EE RID: 1006
	[RequireComponent(typeof(AimIK))]
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		// Token: 0x0600D88B RID: 55435 RVA: 0x0062E7F8 File Offset: 0x0062C9F8
		private void MHEJBNPECDF()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.KMCGJBCOINN(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D88C RID: 55436 RVA: 0x0062E953 File Offset: 0x0062CB53
		private void OnDestroy()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.PHLHKALHHPF));
			}
		}

		// Token: 0x0600D88D RID: 55437 RVA: 0x0062E990 File Offset: 0x0062CB90
		private void JCAIHMBPNOK()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.GGCAOEAOCMM(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D88E RID: 55438 RVA: 0x0062EAEC File Offset: 0x0062CCEC
		protected override void ANHOOJFEJJE()
		{
			base.CKIGGCAHAFD();
			this.OGCIJGNCBOA = base.GetComponent<AimIK>();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.GMDCJMIJPBP));
			this.OGCIJGNCBOA.enabled = true;
			this.OJMBOCNNLMI.enabled = true;
			this.BCMLGALCHFN = this.OJMBOCNNLMI.references.head.InverseTransformVector(this.OJMBOCNNLMI.references.root.forward);
			this.KCLACNEILLB.SetLayerWeight(0, 433f);
		}

		// Token: 0x0600D88F RID: 55439 RVA: 0x0062EB9C File Offset: 0x0062CD9C
		public override void Move(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			base.Move(OMHLINDNFBG, JMJEFKLOKLL, OEGGGHKNDKE, PNLDMKEJGCF);
			this.PNLDMKEJGCF = PNLDMKEJGCF;
			this.INELKGAHFBJ();
			this.AOGMIOLBCCK();
			this.GEDNCBBJOAN();
			this.NGMBNMKLDIJ(PNLDMKEJGCF);
		}

		// Token: 0x0600D890 RID: 55440 RVA: 0x0062EBCC File Offset: 0x0062CDCC
		private void NGMBNMKLDIJ(Vector3 JJDCAAEOKJN)
		{
			Quaternion b = Quaternion.FromToRotation(this.OJMBOCNNLMI.references.head.rotation * this.BCMLGALCHFN, JJDCAAEOKJN - this.OJMBOCNNLMI.references.head.position);
			this.OJMBOCNNLMI.references.head.rotation = Quaternion.Lerp(Quaternion.identity, b, this.headLookWeight) * this.OJMBOCNNLMI.references.head.rotation;
		}

		// Token: 0x0600D891 RID: 55441 RVA: 0x0062EC5C File Offset: 0x0062CE5C
		private void MMCPMEHKALJ()
		{
			Quaternion rotation = (this.recoil != null) ? (this.recoil.rotationOffset * this.CALJLNNIIML) : this.CALJLNNIIML;
			Vector3 a = this.OJMBOCNNLMI.references.rightHand.position + this.OJMBOCNNLMI.solver.rightHandEffector.positionOffset + rotation * this.JLNPMIKHBBA;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionOffset += a - this.OJMBOCNNLMI.references.leftHand.position - this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionOffset + rotation * this.leftHandOffset;
		}

		// Token: 0x0600D892 RID: 55442 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void KINEINDGPPH()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D893 RID: 55443 RVA: 0x0062ED68 File Offset: 0x0062CF68
		private void KANFDKCNEFP(Vector3 JJDCAAEOKJN)
		{
			Quaternion b = Quaternion.FromToRotation(this.OJMBOCNNLMI.references.head.rotation * this.BCMLGALCHFN, JJDCAAEOKJN - this.OJMBOCNNLMI.references.head.position);
			this.OJMBOCNNLMI.references.head.rotation = Quaternion.Lerp(Quaternion.identity, b, this.headLookWeight) * this.OJMBOCNNLMI.references.head.rotation;
		}

		// Token: 0x0600D894 RID: 55444 RVA: 0x0062EDF8 File Offset: 0x0062CFF8
		private void MNMPOMMKNJD()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.KEBFNEHJCGN(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D895 RID: 55445 RVA: 0x0062EF53 File Offset: 0x0062D153
		public override void IHEGIHFJFJF(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			base.DJHCIHACNAA(OMHLINDNFBG, JMJEFKLOKLL, OEGGGHKNDKE, PNLDMKEJGCF);
			this.PNLDMKEJGCF = PNLDMKEJGCF;
			this.AJLBODJACDH();
			this.BHDCEBLGPJI();
			this.PNGEOIIECAI();
			this.NGMBNMKLDIJ(PNLDMKEJGCF);
		}

		// Token: 0x0600D896 RID: 55446 RVA: 0x0062EF84 File Offset: 0x0062D184
		private void INELKGAHFBJ()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D897 RID: 55447 RVA: 0x0062EFFC File Offset: 0x0062D1FC
		private void MKPGIJHFMHD()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.SetHandRotations(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D898 RID: 55448 RVA: 0x0062F158 File Offset: 0x0062D358
		private void EHIHFJKBCNK()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D899 RID: 55449 RVA: 0x0062F1CF File Offset: 0x0062D3CF
		public virtual void DHLKFAFGPLF(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			base.HPGBIANDJPO(OMHLINDNFBG, JMJEFKLOKLL, OEGGGHKNDKE, PNLDMKEJGCF);
			this.PNLDMKEJGCF = PNLDMKEJGCF;
			this.INELKGAHFBJ();
			this.BGBDOBADBAH();
			this.MNMPOMMKNJD();
			this.NGMBNMKLDIJ(PNLDMKEJGCF);
		}

		// Token: 0x0600D89A RID: 55450 RVA: 0x0062F200 File Offset: 0x0062D400
		private void LJGIHGIEMHK(Vector3 JJDCAAEOKJN)
		{
			Quaternion b = Quaternion.FromToRotation(this.OJMBOCNNLMI.references.head.rotation * this.BCMLGALCHFN, JJDCAAEOKJN - this.OJMBOCNNLMI.references.head.position);
			this.OJMBOCNNLMI.references.head.rotation = Quaternion.Lerp(Quaternion.identity, b, this.headLookWeight) * this.OJMBOCNNLMI.references.head.rotation;
		}

		// Token: 0x0600D89B RID: 55451 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void PMACKBHHACG()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D89C RID: 55452 RVA: 0x0062F28E File Offset: 0x0062D48E
		public virtual void NLEDHPFIMPO(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			base.HPGBIANDJPO(OMHLINDNFBG, JMJEFKLOKLL, OEGGGHKNDKE, PNLDMKEJGCF);
			this.PNLDMKEJGCF = PNLDMKEJGCF;
			this.EHIHFJKBCNK();
			this.BGBDOBADBAH();
			this.JCAIHMBPNOK();
			this.NOFFKEMINDG(PNLDMKEJGCF);
		}

		// Token: 0x0600D89D RID: 55453 RVA: 0x0062F2BD File Offset: 0x0062D4BD
		public virtual void IMIJBDFMCAH(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			base.NMJLAEAIBDK(OMHLINDNFBG, JMJEFKLOKLL, OEGGGHKNDKE, PNLDMKEJGCF);
			this.PNLDMKEJGCF = PNLDMKEJGCF;
			this.FAFKDCBJBKO();
			this.MNDAAGMIAHM();
			this.MHEJBNPECDF();
			this.MGPHMKMFCFM(PNLDMKEJGCF);
		}

		// Token: 0x0600D89E RID: 55454 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void AOGMIOLBCCK()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D89F RID: 55455 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void BGBDOBADBAH()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D8A0 RID: 55456 RVA: 0x0062F2EC File Offset: 0x0062D4EC
		private void MEMOGAJFGKN()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.LEIBDJFFIOE(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D8A1 RID: 55457 RVA: 0x0062F448 File Offset: 0x0062D648
		private void FBLLLFGMGKG()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D8A2 RID: 55458 RVA: 0x0062F4C0 File Offset: 0x0062D6C0
		private void ADBHBBDNBDN()
		{
			Quaternion rotation = (this.recoil != null) ? (this.recoil.rotationOffset * this.CALJLNNIIML) : this.CALJLNNIIML;
			Vector3 a = this.OJMBOCNNLMI.references.rightHand.position + this.OJMBOCNNLMI.solver.rightHandEffector.positionOffset + rotation * this.JLNPMIKHBBA;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionOffset += a - this.OJMBOCNNLMI.references.leftHand.position - this.OJMBOCNNLMI.solver.leftHandEffector.positionOffset + rotation * this.leftHandOffset;
		}

		// Token: 0x0600D8A3 RID: 55459 RVA: 0x0062F5A1 File Offset: 0x0062D7A1
		public override void LPLKMLKEFLM(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			base.CDPIFBKGEIJ(OMHLINDNFBG, JMJEFKLOKLL, OEGGGHKNDKE, PNLDMKEJGCF);
			this.PNLDMKEJGCF = PNLDMKEJGCF;
			this.HEFDLOJDMAD();
			this.KINEINDGPPH();
			this.LKMODMJBEGM();
			this.CJHCBKABIBL(PNLDMKEJGCF);
		}

		// Token: 0x0600D8A4 RID: 55460 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void DNAPAAHCHNF()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D8A5 RID: 55461 RVA: 0x0062F5D0 File Offset: 0x0062D7D0
		public virtual void JLFBLPKNCMO(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			base.NMJLAEAIBDK(OMHLINDNFBG, JMJEFKLOKLL, OEGGGHKNDKE, PNLDMKEJGCF);
			this.PNLDMKEJGCF = PNLDMKEJGCF;
			this.OBFMNOACIGG();
			this.MPMAGDJMECD();
			this.ILBLKMPHNLO();
			this.GFFJLAPJNEH(PNLDMKEJGCF);
		}

		// Token: 0x0600D8A6 RID: 55462 RVA: 0x0062F600 File Offset: 0x0062D800
		private void HEFDLOJDMAD()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D8A7 RID: 55463 RVA: 0x0062F678 File Offset: 0x0062D878
		private void GEFFCPJDOCD()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.EAPEFABCBKH(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D8A8 RID: 55464 RVA: 0x0062F7D3 File Offset: 0x0062D9D3
		public virtual void OGFBDGOAMOP(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			base.HOCPKBIPCKE(OMHLINDNFBG, JMJEFKLOKLL, OEGGGHKNDKE, PNLDMKEJGCF);
			this.PNLDMKEJGCF = PNLDMKEJGCF;
			this.DDFIKLOJCKP();
			this.MPMAGDJMECD();
			this.OBBEDIMMLDG();
			this.NGMBNMKLDIJ(PNLDMKEJGCF);
		}

		// Token: 0x0600D8A9 RID: 55465 RVA: 0x0062F804 File Offset: 0x0062DA04
		private void OBFMNOACIGG()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D8AA RID: 55466 RVA: 0x0062F87C File Offset: 0x0062DA7C
		private void MENBNCNMHPP()
		{
			Quaternion rotation = (this.recoil != null) ? (this.recoil.rotationOffset * this.CALJLNNIIML) : this.CALJLNNIIML;
			Vector3 a = this.OJMBOCNNLMI.references.rightHand.position + this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionOffset + rotation * this.JLNPMIKHBBA;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionOffset += a - this.OJMBOCNNLMI.references.leftHand.position - this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionOffset + rotation * this.leftHandOffset;
		}

		// Token: 0x0600D8AB RID: 55467 RVA: 0x0062F960 File Offset: 0x0062DB60
		private void BABBCHKMOOP(Vector3 JJDCAAEOKJN)
		{
			Quaternion b = Quaternion.FromToRotation(this.OJMBOCNNLMI.references.head.rotation * this.BCMLGALCHFN, JJDCAAEOKJN - this.OJMBOCNNLMI.references.head.position);
			this.OJMBOCNNLMI.references.head.rotation = Quaternion.Lerp(Quaternion.identity, b, this.headLookWeight) * this.OJMBOCNNLMI.references.head.rotation;
		}

		// Token: 0x0600D8AC RID: 55468 RVA: 0x0062F9F0 File Offset: 0x0062DBF0
		protected virtual void MCHAAIIHOKD()
		{
			base.IMABGALEMBI();
			this.OGCIJGNCBOA = base.GetComponent<AimIK>();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.PHLHKALHHPF));
			this.OGCIJGNCBOA.enabled = true;
			this.OJMBOCNNLMI.enabled = true;
			this.BCMLGALCHFN = this.OJMBOCNNLMI.references.head.InverseTransformVector(this.OJMBOCNNLMI.references.root.forward);
			this.KCLACNEILLB.SetLayerWeight(0, 1907f);
		}

		// Token: 0x0600D8AD RID: 55469 RVA: 0x0062FAA0 File Offset: 0x0062DCA0
		protected virtual void KIEIPFFEDHC()
		{
			base.DGDGMFDPEHO();
			this.OGCIJGNCBOA = base.GetComponent<AimIK>();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.OLFFFMFMFMP));
			this.OGCIJGNCBOA.enabled = true;
			this.OJMBOCNNLMI.enabled = false;
			this.BCMLGALCHFN = this.OJMBOCNNLMI.references.head.InverseTransformVector(this.OJMBOCNNLMI.references.root.forward);
			this.KCLACNEILLB.SetLayerWeight(0, 1799f);
		}

		// Token: 0x0600D8AE RID: 55470 RVA: 0x0062FB50 File Offset: 0x0062DD50
		private void OBBEDIMMLDG()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.BPBPMJAKIIK(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D8AF RID: 55471 RVA: 0x0062FCAC File Offset: 0x0062DEAC
		protected override void INDGOHJGCFN()
		{
			base.PFNPOHMMJDN();
			this.OGCIJGNCBOA = base.GetComponent<AimIK>();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.OLFFFMFMFMP));
			this.OGCIJGNCBOA.enabled = false;
			this.OJMBOCNNLMI.enabled = false;
			this.BCMLGALCHFN = this.OJMBOCNNLMI.references.head.InverseTransformVector(this.OJMBOCNNLMI.references.root.forward);
			this.KCLACNEILLB.SetLayerWeight(1, 915f);
		}

		// Token: 0x0600D8B0 RID: 55472 RVA: 0x0062FD5C File Offset: 0x0062DF5C
		private void PHLHKALHHPF()
		{
			Quaternion rotation = (this.recoil != null) ? (this.recoil.rotationOffset * this.CALJLNNIIML) : this.CALJLNNIIML;
			Vector3 a = this.OJMBOCNNLMI.references.rightHand.position + this.OJMBOCNNLMI.solver.rightHandEffector.positionOffset + rotation * this.JLNPMIKHBBA;
			this.OJMBOCNNLMI.solver.leftHandEffector.positionOffset += a - this.OJMBOCNNLMI.references.leftHand.position - this.OJMBOCNNLMI.solver.leftHandEffector.positionOffset + rotation * this.leftHandOffset;
		}

		// Token: 0x0600D8B1 RID: 55473 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void MPMAGDJMECD()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D8B2 RID: 55474 RVA: 0x0062FE40 File Offset: 0x0062E040
		private void NOFFKEMINDG(Vector3 JJDCAAEOKJN)
		{
			Quaternion b = Quaternion.FromToRotation(this.OJMBOCNNLMI.references.head.rotation * this.BCMLGALCHFN, JJDCAAEOKJN - this.OJMBOCNNLMI.references.head.position);
			this.OJMBOCNNLMI.references.head.rotation = Quaternion.Lerp(Quaternion.identity, b, this.headLookWeight) * this.OJMBOCNNLMI.references.head.rotation;
		}

		// Token: 0x0600D8B3 RID: 55475 RVA: 0x0062FECE File Offset: 0x0062E0CE
		private void IDFGJIHLHDH()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.KGCKFADFANB));
			}
		}

		// Token: 0x0600D8B4 RID: 55476 RVA: 0x0062FF0C File Offset: 0x0062E10C
		protected override void LHHKDNILMDI()
		{
			base.BBFPILBIMKC();
			this.OGCIJGNCBOA = base.GetComponent<AimIK>();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.ADBHBBDNBDN));
			this.OGCIJGNCBOA.enabled = true;
			this.OJMBOCNNLMI.enabled = true;
			this.BCMLGALCHFN = this.OJMBOCNNLMI.references.head.InverseTransformVector(this.OJMBOCNNLMI.references.root.forward);
			this.KCLACNEILLB.SetLayerWeight(1, 1343f);
		}

		// Token: 0x0600D8B5 RID: 55477 RVA: 0x0062FFBC File Offset: 0x0062E1BC
		protected override void Start()
		{
			base.Start();
			this.OGCIJGNCBOA = base.GetComponent<AimIK>();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.PHLHKALHHPF));
			this.OGCIJGNCBOA.enabled = false;
			this.OJMBOCNNLMI.enabled = false;
			this.BCMLGALCHFN = this.OJMBOCNNLMI.references.head.InverseTransformVector(this.OJMBOCNNLMI.references.root.forward);
			this.KCLACNEILLB.SetLayerWeight(1, 1f);
		}

		// Token: 0x0600D8B6 RID: 55478 RVA: 0x0063006C File Offset: 0x0062E26C
		private void MGPHMKMFCFM(Vector3 JJDCAAEOKJN)
		{
			Quaternion b = Quaternion.FromToRotation(this.OJMBOCNNLMI.references.head.rotation * this.BCMLGALCHFN, JJDCAAEOKJN - this.OJMBOCNNLMI.references.head.position);
			this.OJMBOCNNLMI.references.head.rotation = Quaternion.Lerp(Quaternion.identity, b, this.headLookWeight) * this.OJMBOCNNLMI.references.head.rotation;
		}

		// Token: 0x0600D8B7 RID: 55479 RVA: 0x006300FC File Offset: 0x0062E2FC
		private void GFFJLAPJNEH(Vector3 JJDCAAEOKJN)
		{
			Quaternion b = Quaternion.FromToRotation(this.OJMBOCNNLMI.references.head.rotation * this.BCMLGALCHFN, JJDCAAEOKJN - this.OJMBOCNNLMI.references.head.position);
			this.OJMBOCNNLMI.references.head.rotation = Quaternion.Lerp(Quaternion.identity, b, this.headLookWeight) * this.OJMBOCNNLMI.references.head.rotation;
		}

		// Token: 0x0600D8B8 RID: 55480 RVA: 0x0063018C File Offset: 0x0062E38C
		private void AJLBODJACDH()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D8B9 RID: 55481 RVA: 0x00630204 File Offset: 0x0062E404
		protected virtual void AOCDDBNBADJ()
		{
			base.DPPAAIJCFLC();
			this.OGCIJGNCBOA = base.GetComponent<AimIK>();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.KGCKFADFANB));
			this.OGCIJGNCBOA.enabled = false;
			this.OJMBOCNNLMI.enabled = false;
			this.BCMLGALCHFN = this.OJMBOCNNLMI.references.head.InverseTransformVector(this.OJMBOCNNLMI.references.root.forward);
			this.KCLACNEILLB.SetLayerWeight(1, 1609f);
		}

		// Token: 0x0600D8BA RID: 55482 RVA: 0x006302B4 File Offset: 0x0062E4B4
		private void KGCKFADFANB()
		{
			Quaternion rotation = (this.recoil != null) ? (this.recoil.rotationOffset * this.CALJLNNIIML) : this.CALJLNNIIML;
			Vector3 a = this.OJMBOCNNLMI.references.rightHand.position + this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionOffset + rotation * this.JLNPMIKHBBA;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionOffset += a - this.OJMBOCNNLMI.references.leftHand.position - this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionOffset + rotation * this.leftHandOffset;
		}

		// Token: 0x0600D8BB RID: 55483 RVA: 0x00630398 File Offset: 0x0062E598
		private void DIIDHPGGNAK()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.SetHandRotations(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D8BC RID: 55484 RVA: 0x006304F3 File Offset: 0x0062E6F3
		public override void CNGEKJMPFBJ(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			base.PCCFANHAHMO(OMHLINDNFBG, JMJEFKLOKLL, OEGGGHKNDKE, PNLDMKEJGCF);
			this.PNLDMKEJGCF = PNLDMKEJGCF;
			this.AJLBODJACDH();
			this.DCCLADLNGAM();
			this.GEFFCPJDOCD();
			this.MGPHMKMFCFM(PNLDMKEJGCF);
		}

		// Token: 0x0600D8BD RID: 55485 RVA: 0x00630524 File Offset: 0x0062E724
		private void LKMODMJBEGM()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.KMCGJBCOINN(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D8BE RID: 55486 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void PLDGCOEOCKB()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D8BF RID: 55487 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void NCEPBKJHHHB()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D8C0 RID: 55488 RVA: 0x0063067F File Offset: 0x0062E87F
		public virtual void IJOMECAMCED(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			base.JNENPACLMAJ(OMHLINDNFBG, JMJEFKLOKLL, OEGGGHKNDKE, PNLDMKEJGCF);
			this.PNLDMKEJGCF = PNLDMKEJGCF;
			this.DDFIKLOJCKP();
			this.BGBDOBADBAH();
			this.GEDNCBBJOAN();
			this.CJHCBKABIBL(PNLDMKEJGCF);
		}

		// Token: 0x0600D8C1 RID: 55489 RVA: 0x006306B0 File Offset: 0x0062E8B0
		private void INEJENKNDIJ(Vector3 JJDCAAEOKJN)
		{
			Quaternion b = Quaternion.FromToRotation(this.OJMBOCNNLMI.references.head.rotation * this.BCMLGALCHFN, JJDCAAEOKJN - this.OJMBOCNNLMI.references.head.position);
			this.OJMBOCNNLMI.references.head.rotation = Quaternion.Lerp(Quaternion.identity, b, this.headLookWeight) * this.OJMBOCNNLMI.references.head.rotation;
		}

		// Token: 0x0600D8C2 RID: 55490 RVA: 0x00630740 File Offset: 0x0062E940
		private void PMIIBFOONKJ()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D8C3 RID: 55491 RVA: 0x006307B8 File Offset: 0x0062E9B8
		private void PNGEOIIECAI()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.KDGOMELOGFD(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D8C4 RID: 55492 RVA: 0x00630913 File Offset: 0x0062EB13
		public virtual void EEIHMCHIKEF(Vector3 OMHLINDNFBG, bool JMJEFKLOKLL, Vector3 OEGGGHKNDKE, Vector3 PNLDMKEJGCF)
		{
			base.Move(OMHLINDNFBG, JMJEFKLOKLL, OEGGGHKNDKE, PNLDMKEJGCF);
			this.PNLDMKEJGCF = PNLDMKEJGCF;
			this.EHIHFJKBCNK();
			this.DCCLADLNGAM();
			this.KCHGPCEELOB();
			this.LJGIHGIEMHK(PNLDMKEJGCF);
		}

		// Token: 0x0600D8C5 RID: 55493 RVA: 0x00630944 File Offset: 0x0062EB44
		private void KCHGPCEELOB()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.LEIBDJFFIOE(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D8C6 RID: 55494 RVA: 0x00630AA0 File Offset: 0x0062ECA0
		private void PBNIBMFHOKO()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D8C7 RID: 55495 RVA: 0x00630B18 File Offset: 0x0062ED18
		protected override void PBMPJPIMJBF()
		{
			base.FFIGGPHAIBP();
			this.OGCIJGNCBOA = base.GetComponent<AimIK>();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.GMDCJMIJPBP));
			this.OGCIJGNCBOA.enabled = false;
			this.OJMBOCNNLMI.enabled = false;
			this.BCMLGALCHFN = this.OJMBOCNNLMI.references.head.InverseTransformVector(this.OJMBOCNNLMI.references.root.forward);
			this.KCLACNEILLB.SetLayerWeight(1, 341f);
		}

		// Token: 0x0600D8C8 RID: 55496 RVA: 0x00630BC8 File Offset: 0x0062EDC8
		private void GEDNCBBJOAN()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.rightHandEffector.positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.SetHandRotations(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D8C9 RID: 55497 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void MNDAAGMIAHM()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D8CA RID: 55498 RVA: 0x00630D24 File Offset: 0x0062EF24
		protected virtual void IJOCHELLKJH()
		{
			base.JPHBPEAMNHB();
			this.OGCIJGNCBOA = base.GetComponent<AimIK>();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.OLFFFMFMFMP));
			this.OGCIJGNCBOA.enabled = true;
			this.OJMBOCNNLMI.enabled = true;
			this.BCMLGALCHFN = this.OJMBOCNNLMI.references.head.InverseTransformVector(this.OJMBOCNNLMI.references.root.forward);
			this.KCLACNEILLB.SetLayerWeight(0, 1620f);
		}

		// Token: 0x0600D8CB RID: 55499 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void DCCLADLNGAM()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D8CC RID: 55500 RVA: 0x00630DD4 File Offset: 0x0062EFD4
		private void BGPHDBCDADD()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.SetHandRotations(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D8CD RID: 55501 RVA: 0x00630F30 File Offset: 0x0062F130
		private void DPNIGJKGLME(Vector3 JJDCAAEOKJN)
		{
			Quaternion b = Quaternion.FromToRotation(this.OJMBOCNNLMI.references.head.rotation * this.BCMLGALCHFN, JJDCAAEOKJN - this.OJMBOCNNLMI.references.head.position);
			this.OJMBOCNNLMI.references.head.rotation = Quaternion.Lerp(Quaternion.identity, b, this.headLookWeight) * this.OJMBOCNNLMI.references.head.rotation;
		}

		// Token: 0x0600D8CE RID: 55502 RVA: 0x00630FC0 File Offset: 0x0062F1C0
		private void OLFFFMFMFMP()
		{
			Quaternion rotation = (this.recoil != null) ? (this.recoil.rotationOffset * this.CALJLNNIIML) : this.CALJLNNIIML;
			Vector3 a = this.OJMBOCNNLMI.references.rightHand.position + this.OJMBOCNNLMI.solver.IANMIEDIJPJ().positionOffset + rotation * this.JLNPMIKHBBA;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionOffset += a - this.OJMBOCNNLMI.references.leftHand.position - this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionOffset + rotation * this.leftHandOffset;
		}

		// Token: 0x0600D8CF RID: 55503 RVA: 0x006310A4 File Offset: 0x0062F2A4
		private void GMDCJMIJPBP()
		{
			Quaternion rotation = (this.recoil != null) ? (this.recoil.rotationOffset * this.CALJLNNIIML) : this.CALJLNNIIML;
			Vector3 a = this.OJMBOCNNLMI.references.rightHand.position + this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionOffset + rotation * this.JLNPMIKHBBA;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionOffset += a - this.OJMBOCNNLMI.references.leftHand.position - this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionOffset + rotation * this.leftHandOffset;
		}

		// Token: 0x0600D8D0 RID: 55504 RVA: 0x00631188 File Offset: 0x0062F388
		private void FAFKDCBJBKO()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D8D1 RID: 55505 RVA: 0x00631200 File Offset: 0x0062F400
		private void BHMKJIAMBAD()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D8D3 RID: 55507 RVA: 0x0063128C File Offset: 0x0062F48C
		private void DDFIKLOJCKP()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D8D4 RID: 55508 RVA: 0x00631304 File Offset: 0x0062F504
		private void OLFHCOHFGDM()
		{
			this.JLNPMIKHBBA = this.OJMBOCNNLMI.references.rightHand.InverseTransformPoint(this.OJMBOCNNLMI.references.leftHand.position);
			this.BMLPNJBNDOL = Quaternion.Inverse(this.OJMBOCNNLMI.references.rightHand.rotation) * this.OJMBOCNNLMI.references.leftHand.rotation;
		}

		// Token: 0x0600D8D5 RID: 55509 RVA: 0x0063137C File Offset: 0x0062F57C
		private void ILBLKMPHNLO()
		{
			this.CALJLNNIIML = this.OJMBOCNNLMI.references.rightHand.rotation;
			Vector3 b = this.OJMBOCNNLMI.references.rightHand.rotation * this.gunHoldOffset;
			this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionOffset += b;
			if (this.recoil != null)
			{
				this.recoil.DPBOJCODOLJ(this.CALJLNNIIML * this.BMLPNJBNDOL, this.CALJLNNIIML);
			}
			this.OJMBOCNNLMI.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.OJMBOCNNLMI.references.rightHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML;
				this.OJMBOCNNLMI.references.leftHand.rotation = this.recoil.rotationOffset * this.CALJLNNIIML * this.BMLPNJBNDOL;
				return;
			}
			this.OJMBOCNNLMI.references.rightHand.rotation = this.CALJLNNIIML;
			this.OJMBOCNNLMI.references.leftHand.rotation = this.CALJLNNIIML * this.BMLPNJBNDOL;
		}

		// Token: 0x0600D8D6 RID: 55510 RVA: 0x006314D8 File Offset: 0x0062F6D8
		private void FENEHMNIEEF()
		{
			Quaternion rotation = (this.recoil != null) ? (this.recoil.rotationOffset * this.CALJLNNIIML) : this.CALJLNNIIML;
			Vector3 a = this.OJMBOCNNLMI.references.rightHand.position + this.OJMBOCNNLMI.solver.MJOPIBNHGIK().positionOffset + rotation * this.JLNPMIKHBBA;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionOffset += a - this.OJMBOCNNLMI.references.leftHand.position - this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionOffset + rotation * this.leftHandOffset;
		}

		// Token: 0x0600D8D7 RID: 55511 RVA: 0x006315BC File Offset: 0x0062F7BC
		protected virtual void DGEIACONKCJ()
		{
			base.MMACLBBMDLA();
			this.OGCIJGNCBOA = base.GetComponent<AimIK>();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.GMDCJMIJPBP));
			this.OGCIJGNCBOA.enabled = false;
			this.OJMBOCNNLMI.enabled = false;
			this.BCMLGALCHFN = this.OJMBOCNNLMI.references.head.InverseTransformVector(this.OJMBOCNNLMI.references.root.forward);
			this.KCLACNEILLB.SetLayerWeight(1, 391f);
		}

		// Token: 0x0600D8D8 RID: 55512 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void NHGEPDHIDEC()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D8D9 RID: 55513 RVA: 0x0063166C File Offset: 0x0062F86C
		private void FDEEGGAAOPL()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.FENEHMNIEEF));
			}
		}

		// Token: 0x0600D8DA RID: 55514 RVA: 0x006316A8 File Offset: 0x0062F8A8
		protected virtual void ONIHHFLOJMN()
		{
			base.HDFCIACDDEK();
			this.OGCIJGNCBOA = base.GetComponent<AimIK>();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
			solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.PHLHKALHHPF));
			this.OGCIJGNCBOA.enabled = false;
			this.OJMBOCNNLMI.enabled = false;
			this.BCMLGALCHFN = this.OJMBOCNNLMI.references.head.InverseTransformVector(this.OJMBOCNNLMI.references.root.forward);
			this.KCLACNEILLB.SetLayerWeight(0, 1572f);
		}

		// Token: 0x0600D8DB RID: 55515 RVA: 0x00631758 File Offset: 0x0062F958
		private void OIICPEBHHKA()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.OLFFFMFMFMP));
			}
		}

		// Token: 0x0600D8DC RID: 55516 RVA: 0x0062ED3D File Offset: 0x0062CF3D
		private void BHDCEBLGPJI()
		{
			this.OGCIJGNCBOA.solver.IKPosition = this.PNLDMKEJGCF;
			this.OGCIJGNCBOA.solver.FANPFKHEDPA();
		}

		// Token: 0x0600D8DD RID: 55517 RVA: 0x00631794 File Offset: 0x0062F994
		private void CJHCBKABIBL(Vector3 JJDCAAEOKJN)
		{
			Quaternion b = Quaternion.FromToRotation(this.OJMBOCNNLMI.references.head.rotation * this.BCMLGALCHFN, JJDCAAEOKJN - this.OJMBOCNNLMI.references.head.position);
			this.OJMBOCNNLMI.references.head.rotation = Quaternion.Lerp(Quaternion.identity, b, this.headLookWeight) * this.OJMBOCNNLMI.references.head.rotation;
		}

		// Token: 0x0600D8DE RID: 55518 RVA: 0x0062FECE File Offset: 0x0062E0CE
		private void FGBEFAILDDL()
		{
			if (this.OJMBOCNNLMI != null)
			{
				IKSolverFullBodyBiped solver = this.OJMBOCNNLMI.solver;
				solver.OnPreRead = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreRead, new IKSolver.LGGEKCCEELN(this.KGCKFADFANB));
			}
		}

		// Token: 0x04001CB4 RID: 7348
		[Range(0f, 1f)]
		public float headLookWeight = 1f;

		// Token: 0x04001CB5 RID: 7349
		public Vector3 gunHoldOffset;

		// Token: 0x04001CB6 RID: 7350
		public Vector3 leftHandOffset;

		// Token: 0x04001CB7 RID: 7351
		public Recoil recoil;

		// Token: 0x04001CB8 RID: 7352
		private AimIK OGCIJGNCBOA;

		// Token: 0x04001CB9 RID: 7353
		private FullBodyBipedIK OJMBOCNNLMI;

		// Token: 0x04001CBA RID: 7354
		private Vector3 BCMLGALCHFN;

		// Token: 0x04001CBB RID: 7355
		private Vector3 JLNPMIKHBBA;

		// Token: 0x04001CBC RID: 7356
		private Quaternion BMLPNJBNDOL;

		// Token: 0x04001CBD RID: 7357
		private Vector3 PNLDMKEJGCF;

		// Token: 0x04001CBE RID: 7358
		private Quaternion CALJLNNIIML;
	}
}
