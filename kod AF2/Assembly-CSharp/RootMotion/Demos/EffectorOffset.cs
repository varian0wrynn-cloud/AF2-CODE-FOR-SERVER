using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003F1 RID: 1009
	public class EffectorOffset : OffsetModifier
	{
		// Token: 0x0600D90A RID: 55562 RVA: 0x006321F8 File Offset: 0x006303F8
		protected virtual void OLCJGDIOBGO()
		{
			this.ik.solver.leftHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.HJPCHINGJCN().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.LLFAEIGHHBK().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.CLLKAEEHHIP().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.leftHandEffector.positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.leftFootEffector.positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.ANGCEEAGHCB().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D90B RID: 55563 RVA: 0x00632484 File Offset: 0x00630684
		protected virtual void MOBMBODBBPH()
		{
			this.ik.solver.DBCIMCKLHIM().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.IANMIEDIJPJ().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.HJPCHINGJCN().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.FKKHCIDIBLF().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.GPLFMHLNFLL().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.EBCFAJOMOFB().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.leftHandEffector.positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.MJOPIBNHGIK().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JFOHJFFFPGJ().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D90C RID: 55564 RVA: 0x00632710 File Offset: 0x00630910
		protected virtual void IMKHFLLACDF()
		{
			this.ik.solver.EMPOFCMIGLD().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.bodyEffector.positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.leftShoulderEffector.positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.EBCFAJOMOFB().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.ECCGBKELAOH().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.EMPOFCMIGLD().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JFOHJFFFPGJ().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D90D RID: 55565 RVA: 0x0063299C File Offset: 0x00630B9C
		protected virtual void GEJALLDIDKK()
		{
			this.ik.solver.CMKJIGNKIMG().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.HJPCHINGJCN().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.EEHNFKHFPGP().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.IMBHIAODACN().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.leftHandEffector.positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.JHKNHMMGKCG().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JIHGEPGJDEC().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D90E RID: 55566 RVA: 0x00632C28 File Offset: 0x00630E28
		protected virtual void CAEGFKACKIC()
		{
			this.ik.solver.KIGACGJAJKO().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.MJOPIBNHGIK().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.NEKNDGMNDHG().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.EEHNFKHFPGP().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.IMBHIAODACN().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.KIGACGJAJKO().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.MJOPIBNHGIK().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.ANFNMIKKLOM().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D90F RID: 55567 RVA: 0x00632EB4 File Offset: 0x006310B4
		protected virtual void MBGJEAMMJJN()
		{
			this.ik.solver.CMKJIGNKIMG().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.IANMIEDIJPJ().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.bodyEffector.positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.LLFAEIGHHBK().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.GPLFMHLNFLL().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.leftThighEffector.positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.ECCGBKELAOH().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.DBCIMCKLHIM().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.ANGCEEAGHCB().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D910 RID: 55568 RVA: 0x00633140 File Offset: 0x00631340
		protected virtual void GLNLBLLLBBC()
		{
			this.ik.solver.EMPOFCMIGLD().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.HJPCHINGJCN().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.FKKHCIDIBLF().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.EBCFAJOMOFB().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.FIDGAGDBPCG().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.DBCIMCKLHIM().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.IANMIEDIJPJ().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.JHKNHMMGKCG().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.ANFNMIKKLOM().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D911 RID: 55569 RVA: 0x006333CC File Offset: 0x006315CC
		protected virtual void LONPIDHHHPA()
		{
			this.ik.solver.CMKJIGNKIMG().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.HJPCHINGJCN().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.EEHNFKHFPGP().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.IMBHIAODACN().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.CMKJIGNKIMG().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.MJOPIBNHGIK().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.JHKNHMMGKCG().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.rightFootEffector.positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D912 RID: 55570 RVA: 0x00633658 File Offset: 0x00631858
		protected virtual void EJMFGGFABMH()
		{
			this.ik.solver.leftHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.MJOPIBNHGIK().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.NEKNDGMNDHG().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.FKKHCIDIBLF().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.GPLFMHLNFLL().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.EBCFAJOMOFB().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.ECCGBKELAOH().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.EMPOFCMIGLD().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.MJOPIBNHGIK().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.JHKNHMMGKCG().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JIHGEPGJDEC().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D913 RID: 55571 RVA: 0x006338E4 File Offset: 0x00631AE4
		protected virtual void LHDCDIOEODG()
		{
			this.ik.solver.KIGACGJAJKO().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.IANMIEDIJPJ().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.HJPCHINGJCN().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.EEHNFKHFPGP().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.DMPDLFPCDFO().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.leftThighEffector.positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.FIDGAGDBPCG().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.leftHandEffector.positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.MJOPIBNHGIK().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.rightFootEffector.positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D914 RID: 55572 RVA: 0x00633B70 File Offset: 0x00631D70
		protected virtual void BCFDBGIOMBL()
		{
			this.ik.solver.DBCIMCKLHIM().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.MJOPIBNHGIK().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.HJPCHINGJCN().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.FKKHCIDIBLF().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.GPLFMHLNFLL().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.IMBHIAODACN().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.FIDGAGDBPCG().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.DBCIMCKLHIM().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.IANMIEDIJPJ().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.leftFootEffector.positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.ANFNMIKKLOM().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D915 RID: 55573 RVA: 0x00633DFC File Offset: 0x00631FFC
		protected virtual void MLOBABEJJML()
		{
			this.ik.solver.KIGACGJAJKO().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.bodyEffector.positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.leftShoulderEffector.positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.DMPDLFPCDFO().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.PBMAJLNEOAJ().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.KIGACGJAJKO().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JFOHJFFFPGJ().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D916 RID: 55574 RVA: 0x00634088 File Offset: 0x00632288
		protected virtual void PMMPBOOINPD()
		{
			this.ik.solver.CMKJIGNKIMG().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.IANMIEDIJPJ().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.HJPCHINGJCN().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.LLFAEIGHHBK().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.DMPDLFPCDFO().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.IMBHIAODACN().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.ECCGBKELAOH().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.CMKJIGNKIMG().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.MJOPIBNHGIK().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.ANGCEEAGHCB().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D917 RID: 55575 RVA: 0x00634314 File Offset: 0x00632514
		protected virtual void GCPENONAGDG()
		{
			this.ik.solver.DBCIMCKLHIM().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.IANMIEDIJPJ().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.HJPCHINGJCN().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.EEHNFKHFPGP().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.DMPDLFPCDFO().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.PBMAJLNEOAJ().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.CMKJIGNKIMG().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JIHGEPGJDEC().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D918 RID: 55576 RVA: 0x006345A0 File Offset: 0x006327A0
		protected virtual void KLLBLFKGMLD()
		{
			this.ik.solver.DBCIMCKLHIM().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.HJPCHINGJCN().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.ELPKPOGKHOP().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.DMPDLFPCDFO().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.IMBHIAODACN().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.EMPOFCMIGLD().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.IANMIEDIJPJ().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.leftFootEffector.positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JFOHJFFFPGJ().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D919 RID: 55577 RVA: 0x0063482C File Offset: 0x00632A2C
		protected virtual void GEAKAHAAGIC()
		{
			this.ik.solver.DBCIMCKLHIM().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.IANMIEDIJPJ().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.bodyEffector.positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.ELPKPOGKHOP().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.leftThighEffector.positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.FIDGAGDBPCG().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.DBCIMCKLHIM().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.IANMIEDIJPJ().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.EAIGBIHMAGB().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D91A RID: 55578 RVA: 0x00634AB8 File Offset: 0x00632CB8
		protected virtual void OONMKGBFLCF()
		{
			this.ik.solver.CMKJIGNKIMG().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.MJOPIBNHGIK().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.bodyEffector.positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.FKKHCIDIBLF().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.GPLFMHLNFLL().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.CLLKAEEHHIP().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.ECCGBKELAOH().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.CMKJIGNKIMG().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.IANMIEDIJPJ().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.JHKNHMMGKCG().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.EAIGBIHMAGB().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D91B RID: 55579 RVA: 0x00634D44 File Offset: 0x00632F44
		protected virtual void EKJCBOPLALL()
		{
			this.ik.solver.KIGACGJAJKO().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.IANMIEDIJPJ().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.NEKNDGMNDHG().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.leftShoulderEffector.positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.CLLKAEEHHIP().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.ECCGBKELAOH().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.CMKJIGNKIMG().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.JHKNHMMGKCG().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JIHGEPGJDEC().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D91D RID: 55581 RVA: 0x00634FD0 File Offset: 0x006331D0
		protected virtual void HALPFPKCLAP()
		{
			this.ik.solver.DBCIMCKLHIM().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.IANMIEDIJPJ().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.NEKNDGMNDHG().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.ELPKPOGKHOP().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.GPLFMHLNFLL().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.leftThighEffector.positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.CMKJIGNKIMG().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.MJOPIBNHGIK().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.JHKNHMMGKCG().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JIHGEPGJDEC().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D91E RID: 55582 RVA: 0x0063525C File Offset: 0x0063345C
		protected virtual void NEAEHJGMFCJ()
		{
			this.ik.solver.DBCIMCKLHIM().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.bodyEffector.positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.LLFAEIGHHBK().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.DMPDLFPCDFO().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.leftThighEffector.positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.ECCGBKELAOH().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.KIGACGJAJKO().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.leftFootEffector.positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.rightFootEffector.positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D91F RID: 55583 RVA: 0x006354E8 File Offset: 0x006336E8
		protected virtual void BGFNOICCAGO()
		{
			this.ik.solver.DBCIMCKLHIM().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.MJOPIBNHGIK().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.NEKNDGMNDHG().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.leftShoulderEffector.positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.EBCFAJOMOFB().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.FIDGAGDBPCG().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.EMPOFCMIGLD().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JIHGEPGJDEC().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D920 RID: 55584 RVA: 0x00635774 File Offset: 0x00633974
		protected virtual void FNBKENOCJKD()
		{
			this.ik.solver.KIGACGJAJKO().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.NEKNDGMNDHG().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.leftShoulderEffector.positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.DMPDLFPCDFO().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.IMBHIAODACN().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.ECCGBKELAOH().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.EMPOFCMIGLD().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.JHKNHMMGKCG().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.ANGCEEAGHCB().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D921 RID: 55585 RVA: 0x00635A00 File Offset: 0x00633C00
		protected virtual void MHKIHJKOJCE()
		{
			this.ik.solver.KIGACGJAJKO().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.IANMIEDIJPJ().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.NEKNDGMNDHG().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.leftShoulderEffector.positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.DMPDLFPCDFO().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.PBMAJLNEOAJ().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.KIGACGJAJKO().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.MJOPIBNHGIK().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.leftFootEffector.positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.ANFNMIKKLOM().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D922 RID: 55586 RVA: 0x00635C8C File Offset: 0x00633E8C
		protected virtual void ODCJJGJJMFI()
		{
			this.ik.solver.KIGACGJAJKO().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.bodyEffector.positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.LLFAEIGHHBK().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.GPLFMHLNFLL().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.EBCFAJOMOFB().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.EMPOFCMIGLD().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.IANMIEDIJPJ().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.ANFNMIKKLOM().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D923 RID: 55587 RVA: 0x00635F18 File Offset: 0x00634118
		protected virtual void FADIAAGNLCG()
		{
			this.ik.solver.EMPOFCMIGLD().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.MJOPIBNHGIK().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.NEKNDGMNDHG().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.EEHNFKHFPGP().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.GPLFMHLNFLL().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.PBMAJLNEOAJ().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.FIDGAGDBPCG().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.leftHandEffector.positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.IANMIEDIJPJ().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.leftFootEffector.positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JFOHJFFFPGJ().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D924 RID: 55588 RVA: 0x006361A4 File Offset: 0x006343A4
		protected virtual void LOJCEKNCAOD()
		{
			this.ik.solver.leftHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.MJOPIBNHGIK().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.NEKNDGMNDHG().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.FKKHCIDIBLF().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.leftThighEffector.positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.ECCGBKELAOH().positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.CMKJIGNKIMG().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.leftFootEffector.positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.ANFNMIKKLOM().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D925 RID: 55589 RVA: 0x00636430 File Offset: 0x00634630
		protected override void HEHOBGDMLOK()
		{
			this.ik.solver.leftHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.bodyEffector.positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.leftShoulderEffector.positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.leftThighEffector.positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.leftHandEffector.positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.leftFootEffector.positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.rightFootEffector.positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D926 RID: 55590 RVA: 0x006366BC File Offset: 0x006348BC
		protected virtual void KGHNIEEAEHH()
		{
			this.ik.solver.leftHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.NEKNDGMNDHG().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.EEHNFKHFPGP().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.GPLFMHLNFLL().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.PBMAJLNEOAJ().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.EMPOFCMIGLD().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.leftFootEffector.positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.EAIGBIHMAGB().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D927 RID: 55591 RVA: 0x00636948 File Offset: 0x00634B48
		protected virtual void DIFPMHCBFNE()
		{
			this.ik.solver.leftHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.rightHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.bodyEffector.positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.EEHNFKHFPGP().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.rightShoulderEffector.positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.leftThighEffector.positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.DBCIMCKLHIM().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.rightHandEffector.positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.JIHGEPGJDEC().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x0600D928 RID: 55592 RVA: 0x00636BD4 File Offset: 0x00634DD4
		protected virtual void MEPOMFMNCDE()
		{
			this.ik.solver.leftHandEffector.maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.MJOPIBNHGIK().maintainRelativePositionWeight = this.handsMaintainRelativePositionWeight;
			this.ik.solver.NEKNDGMNDHG().positionOffset += base.transform.rotation * this.bodyOffset * this.weight;
			this.ik.solver.LLFAEIGHHBK().positionOffset += base.transform.rotation * this.leftShoulderOffset * this.weight;
			this.ik.solver.GPLFMHLNFLL().positionOffset += base.transform.rotation * this.rightShoulderOffset * this.weight;
			this.ik.solver.IMBHIAODACN().positionOffset += base.transform.rotation * this.leftThighOffset * this.weight;
			this.ik.solver.rightThighEffector.positionOffset += base.transform.rotation * this.rightThighOffset * this.weight;
			this.ik.solver.DBCIMCKLHIM().positionOffset += base.transform.rotation * this.leftHandOffset * this.weight;
			this.ik.solver.IANMIEDIJPJ().positionOffset += base.transform.rotation * this.rightHandOffset * this.weight;
			this.ik.solver.IAGDDAJGGGE().positionOffset += base.transform.rotation * this.leftFootOffset * this.weight;
			this.ik.solver.ANGCEEAGHCB().positionOffset += base.transform.rotation * this.rightFootOffset * this.weight;
		}

		// Token: 0x04001CC2 RID: 7362
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		// Token: 0x04001CC3 RID: 7363
		public Vector3 bodyOffset;

		// Token: 0x04001CC4 RID: 7364
		public Vector3 leftShoulderOffset;

		// Token: 0x04001CC5 RID: 7365
		public Vector3 rightShoulderOffset;

		// Token: 0x04001CC6 RID: 7366
		public Vector3 leftThighOffset;

		// Token: 0x04001CC7 RID: 7367
		public Vector3 rightThighOffset;

		// Token: 0x04001CC8 RID: 7368
		public Vector3 leftHandOffset;

		// Token: 0x04001CC9 RID: 7369
		public Vector3 rightHandOffset;

		// Token: 0x04001CCA RID: 7370
		public Vector3 leftFootOffset;

		// Token: 0x04001CCB RID: 7371
		public Vector3 rightFootOffset;
	}
}
