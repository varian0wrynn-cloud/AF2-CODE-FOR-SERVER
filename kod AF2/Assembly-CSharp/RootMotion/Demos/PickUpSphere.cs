using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200040A RID: 1034
	public class PickUpSphere : PickUp2Handed
	{
		// Token: 0x0600DDAF RID: 56751 RVA: 0x0065B4BC File Offset: 0x006596BC
		protected virtual void EAPIJOPMLCM()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.leftHandEffector.bone.position, this.interactionSystem.GFHDNCHMCJI().solver.rightHandEffector.bone.position, 698f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDB0 RID: 56752 RVA: 0x0065B53C File Offset: 0x0065973C
		protected virtual void CGEHJKIEOOO()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.position, this.interactionSystem.GFHDNCHMCJI().solver.IANMIEDIJPJ().bone.position, 73f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDB1 RID: 56753 RVA: 0x0065B5BC File Offset: 0x006597BC
		protected virtual void LNPJFJHIFAL()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position, this.interactionSystem.OJMBOCNNLMI.solver.MJOPIBNHGIK().bone.position, 671f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDB2 RID: 56754 RVA: 0x0065B63C File Offset: 0x0065983C
		protected virtual void OHDFHIEPHIG()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position, this.interactionSystem.GFHDNCHMCJI().solver.rightHandEffector.bone.position, 1528f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDB3 RID: 56755 RVA: 0x0065B6BC File Offset: 0x006598BC
		protected virtual void EEEDNAEEKOF()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.GFHDNCHMCJI().solver.EMPOFCMIGLD().bone.position, this.interactionSystem.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position, 31f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDB4 RID: 56756 RVA: 0x0065B73C File Offset: 0x0065993C
		protected virtual void OKKICPKNCIK()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position, this.interactionSystem.OJMBOCNNLMI.solver.rightHandEffector.bone.position, 96f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDB5 RID: 56757 RVA: 0x0065B7BC File Offset: 0x006599BC
		protected virtual void IGMMKMAAMPB()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.KIGACGJAJKO().bone.position, this.interactionSystem.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, 913f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDB6 RID: 56758 RVA: 0x0065B83C File Offset: 0x00659A3C
		protected virtual void ALMICDMPEHF()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.GFHDNCHMCJI().solver.CMKJIGNKIMG().bone.position, this.interactionSystem.OJMBOCNNLMI.solver.rightHandEffector.bone.position, 456f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDB7 RID: 56759 RVA: 0x0065B8BC File Offset: 0x00659ABC
		protected virtual void GHAGPJHLNIN()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.GFHDNCHMCJI().solver.DBCIMCKLHIM().bone.position, this.interactionSystem.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, 524f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDB8 RID: 56760 RVA: 0x0065B93C File Offset: 0x00659B3C
		protected virtual void KPADJJIEHAA()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.position, this.interactionSystem.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position, 1081f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDB9 RID: 56761 RVA: 0x0065B9BC File Offset: 0x00659BBC
		protected virtual void DANKAGHNNGP()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.leftHandEffector.bone.position, this.interactionSystem.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, 788f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDBA RID: 56762 RVA: 0x0065BA3C File Offset: 0x00659C3C
		protected virtual void JOFLFJDLONJ()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.GFHDNCHMCJI().solver.leftHandEffector.bone.position, this.interactionSystem.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position, 531f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDBB RID: 56763 RVA: 0x0065BABC File Offset: 0x00659CBC
		protected virtual void IGMLENOJNKK()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.position, this.interactionSystem.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position, 472f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDBC RID: 56764 RVA: 0x0065BB3C File Offset: 0x00659D3C
		protected virtual void AIJKAGBFGNB()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.GFHDNCHMCJI().solver.CMKJIGNKIMG().bone.position, this.interactionSystem.GFHDNCHMCJI().solver.rightHandEffector.bone.position, 427f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDBD RID: 56765 RVA: 0x0065BBBC File Offset: 0x00659DBC
		protected virtual void PBGFIBLOCKN()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.GFHDNCHMCJI().solver.EMPOFCMIGLD().bone.position, this.interactionSystem.OJMBOCNNLMI.solver.rightHandEffector.bone.position, 504f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDBE RID: 56766 RVA: 0x0065BC3C File Offset: 0x00659E3C
		protected virtual void MAIMDFLIEGO()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.EMPOFCMIGLD().bone.position, this.interactionSystem.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position, 1836f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDC0 RID: 56768 RVA: 0x0065BCBC File Offset: 0x00659EBC
		protected virtual void LNLFHBKDOKO()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.GFHDNCHMCJI().solver.DBCIMCKLHIM().bone.position, this.interactionSystem.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position, 1304f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDC1 RID: 56769 RVA: 0x0065BD3C File Offset: 0x00659F3C
		protected override void NPOEABEHPJD()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.leftHandEffector.bone.position, this.interactionSystem.OJMBOCNNLMI.solver.rightHandEffector.bone.position, 0.5f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDC2 RID: 56770 RVA: 0x0065BDBC File Offset: 0x00659FBC
		protected virtual void JNOAFAECIMJ()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.EMPOFCMIGLD().bone.position, this.interactionSystem.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position, 1609f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDC3 RID: 56771 RVA: 0x0065BE3C File Offset: 0x0065A03C
		protected virtual void CECKLIBLBPK()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.CMKJIGNKIMG().bone.position, this.interactionSystem.OJMBOCNNLMI.solver.IANMIEDIJPJ().bone.position, 264f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDC4 RID: 56772 RVA: 0x0065BEBC File Offset: 0x0065A0BC
		protected virtual void FEKFABIBNGP()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.OJMBOCNNLMI.solver.DBCIMCKLHIM().bone.position, this.interactionSystem.GFHDNCHMCJI().solver.MJOPIBNHGIK().bone.position, 1568f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}

		// Token: 0x0600DDC5 RID: 56773 RVA: 0x0065BF3C File Offset: 0x0065A13C
		protected virtual void ALKPDAIFKMK()
		{
			Vector3 b = Vector3.Lerp(this.interactionSystem.GFHDNCHMCJI().solver.KIGACGJAJKO().bone.position, this.interactionSystem.GFHDNCHMCJI().solver.IANMIEDIJPJ().bone.position, 1713f);
			Vector3 forward = this.obj.transform.position - b;
			this.pivot.rotation = Quaternion.LookRotation(forward);
		}
	}
}
