using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003FB RID: 1019
	public class HoldingHands : MonoBehaviour
	{
		// Token: 0x0600DAF0 RID: 56048 RVA: 0x00642D2C File Offset: 0x00640F2C
		private void OEKHPJAEAAE()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.position, this.leftHandChar.solver.EMPOFCMIGLD().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.DBCIMCKLHIM().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.IANMIEDIJPJ().rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.leftHandChar.solver.CMKJIGNKIMG().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DAF1 RID: 56049 RVA: 0x00642E84 File Offset: 0x00641084
		private void LMEJKAEIDCO()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.rightHandEffector.bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.KIGACGJAJKO().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DAF2 RID: 56050 RVA: 0x00642EFC File Offset: 0x006410FC
		private void OGFGENJAMAM()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.rightHandEffector.bone.position, this.leftHandChar.solver.KIGACGJAJKO().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.KIGACGJAJKO().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.leftHandChar.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DAF3 RID: 56051 RVA: 0x00643054 File Offset: 0x00641254
		private void MODJFGGIAHD()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.leftHandEffector.bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DAF4 RID: 56052 RVA: 0x006430CC File Offset: 0x006412CC
		private void ANHOOJFEJJE()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.KIGACGJAJKO().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DAF5 RID: 56053 RVA: 0x00643144 File Offset: 0x00641344
		private void GDIMBBBPIHI()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.leftHandEffector.bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DAF6 RID: 56054 RVA: 0x006431BC File Offset: 0x006413BC
		private void LCMMGLMJPOK()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.position, this.leftHandChar.solver.DBCIMCKLHIM().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.KIGACGJAJKO().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.IANMIEDIJPJ().position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.EMPOFCMIGLD().position = this.leftHandTarget.position;
			this.leftHandChar.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DAF7 RID: 56055 RVA: 0x00643314 File Offset: 0x00641514
		private void BOEFHGKGJMN()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.position, this.leftHandChar.solver.CMKJIGNKIMG().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.EMPOFCMIGLD().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.IANMIEDIJPJ().position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.leftHandChar.solver.CMKJIGNKIMG().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DAF8 RID: 56056 RVA: 0x0064346C File Offset: 0x0064166C
		private void KGICJDGIIJK()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.rightHandEffector.bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.CMKJIGNKIMG().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DAF9 RID: 56057 RVA: 0x006434E4 File Offset: 0x006416E4
		private void KFGKKLAKFGH()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.leftHandEffector.bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DAFA RID: 56058 RVA: 0x0064355C File Offset: 0x0064175C
		private void EIEKEPGNGPL()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.rightHandEffector.bone.position, this.leftHandChar.solver.KIGACGJAJKO().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.CMKJIGNKIMG().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.MJOPIBNHGIK().rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.leftHandChar.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DAFB RID: 56059 RVA: 0x006436B4 File Offset: 0x006418B4
		private void PMDPLLIBJAF()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.DBCIMCKLHIM().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DAFC RID: 56060 RVA: 0x0064372C File Offset: 0x0064192C
		private void IIKDDILLGLF()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.EMPOFCMIGLD().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DAFD RID: 56061 RVA: 0x006437A4 File Offset: 0x006419A4
		private void GHIJFOALMHM()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.rightHandEffector.bone.position, this.leftHandChar.solver.CMKJIGNKIMG().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.KIGACGJAJKO().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.rightHandEffector.position = this.rightHandTarget.position;
			this.rightHandChar.solver.IANMIEDIJPJ().rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.leftHandChar.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DAFF RID: 56063 RVA: 0x0064390C File Offset: 0x00641B0C
		private void PIEDGJCBCBO()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.position, this.leftHandChar.solver.leftHandEffector.bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.rightHandEffector.bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.KIGACGJAJKO().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.IANMIEDIJPJ().position = this.rightHandTarget.position;
			this.rightHandChar.solver.MJOPIBNHGIK().rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.leftHandChar.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB00 RID: 56064 RVA: 0x00643A64 File Offset: 0x00641C64
		private void CFHDJOKLHDB()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.rightHandEffector.bone.position, this.leftHandChar.solver.leftHandEffector.bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.rightHandEffector.bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.DBCIMCKLHIM().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.leftHandChar.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB01 RID: 56065 RVA: 0x00643BBC File Offset: 0x00641DBC
		private void AOCDDBNBADJ()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.KIGACGJAJKO().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB02 RID: 56066 RVA: 0x00643C34 File Offset: 0x00641E34
		private void KPHGGOCHKFA()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.position, this.leftHandChar.solver.CMKJIGNKIMG().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.DBCIMCKLHIM().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.MJOPIBNHGIK().rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.KIGACGJAJKO().position = this.leftHandTarget.position;
			this.leftHandChar.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB03 RID: 56067 RVA: 0x00643D8C File Offset: 0x00641F8C
		private void OIKMLNIPLIA()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.position, this.leftHandChar.solver.DBCIMCKLHIM().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.leftHandEffector.bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.MJOPIBNHGIK().rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.EMPOFCMIGLD().position = this.leftHandTarget.position;
			this.leftHandChar.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB04 RID: 56068 RVA: 0x00643EE4 File Offset: 0x006420E4
		private void EHDPACPIBNF()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.EMPOFCMIGLD().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB05 RID: 56069 RVA: 0x00643F5C File Offset: 0x0064215C
		private void OPNPODKLOJK()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.CMKJIGNKIMG().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB06 RID: 56070 RVA: 0x00643FD4 File Offset: 0x006421D4
		private void JJMGNAMFJGJ()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.position, this.leftHandChar.solver.KIGACGJAJKO().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.rightHandEffector.bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.KIGACGJAJKO().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.rightHandEffector.position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.leftHandChar.solver.CMKJIGNKIMG().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB07 RID: 56071 RVA: 0x0064412C File Offset: 0x0064232C
		private void GIKJMPHFJKH()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.position, this.leftHandChar.solver.DBCIMCKLHIM().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.rightHandEffector.bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.CMKJIGNKIMG().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.rightHandEffector.position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.leftHandChar.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB08 RID: 56072 RVA: 0x00644284 File Offset: 0x00642484
		private void GPEFDPEAMNE()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.position, this.leftHandChar.solver.KIGACGJAJKO().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.KIGACGJAJKO().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.rightHandEffector.position = this.rightHandTarget.position;
			this.rightHandChar.solver.IANMIEDIJPJ().rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.leftHandChar.solver.CMKJIGNKIMG().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB09 RID: 56073 RVA: 0x006443DC File Offset: 0x006425DC
		private void KEMGOLACEHI()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.rightHandEffector.bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.CMKJIGNKIMG().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB0A RID: 56074 RVA: 0x00644454 File Offset: 0x00642654
		private void CPNOBMNKPNC()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.rightHandEffector.bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.DBCIMCKLHIM().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB0B RID: 56075 RVA: 0x006444CC File Offset: 0x006426CC
		private void AFFAJKPPMHF()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.rightHandEffector.bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.EMPOFCMIGLD().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB0C RID: 56076 RVA: 0x00644544 File Offset: 0x00642744
		private void HDFCIACDDEK()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.EMPOFCMIGLD().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB0D RID: 56077 RVA: 0x006445BC File Offset: 0x006427BC
		private void FPLHODJCJDO()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.DBCIMCKLHIM().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB0E RID: 56078 RVA: 0x00644634 File Offset: 0x00642834
		private void AIKJPMIHCFP()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.position, this.leftHandChar.solver.KIGACGJAJKO().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.CMKJIGNKIMG().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.IANMIEDIJPJ().rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.EMPOFCMIGLD().position = this.leftHandTarget.position;
			this.leftHandChar.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB0F RID: 56079 RVA: 0x0064478C File Offset: 0x0064298C
		private void BMNJGPIPKLL()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.EMPOFCMIGLD().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB10 RID: 56080 RVA: 0x00644804 File Offset: 0x00642A04
		private void HJDEGPKFBNI()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.position, this.leftHandChar.solver.leftHandEffector.bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.EMPOFCMIGLD().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.leftHandChar.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB11 RID: 56081 RVA: 0x0064495C File Offset: 0x00642B5C
		private void LateUpdate()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.rightHandEffector.bone.position, this.leftHandChar.solver.leftHandEffector.bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.rightHandEffector.bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.leftHandEffector.bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.rightHandEffector.position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.leftHandChar.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB12 RID: 56082 RVA: 0x00644AB4 File Offset: 0x00642CB4
		private void NCOJPBKLANI()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.rightHandEffector.bone.position, this.leftHandChar.solver.KIGACGJAJKO().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.leftHandEffector.bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.rightHandEffector.position = this.rightHandTarget.position;
			this.rightHandChar.solver.IANMIEDIJPJ().rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.KIGACGJAJKO().position = this.leftHandTarget.position;
			this.leftHandChar.solver.KIGACGJAJKO().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB13 RID: 56083 RVA: 0x00644C0C File Offset: 0x00642E0C
		private void HKJHIANMOPG()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.position, this.leftHandChar.solver.CMKJIGNKIMG().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.rightHandEffector.bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.DBCIMCKLHIM().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.leftHandChar.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB14 RID: 56084 RVA: 0x00644D64 File Offset: 0x00642F64
		private void CBLGFOFHNPJ()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.rightHandEffector.bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.CMKJIGNKIMG().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB15 RID: 56085 RVA: 0x00644DDC File Offset: 0x00642FDC
		private void OEFDEEOHNJB()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.rightHandEffector.bone.position, this.leftHandChar.solver.leftHandEffector.bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.KIGACGJAJKO().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.IANMIEDIJPJ().position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.leftHandChar.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB16 RID: 56086 RVA: 0x00644F34 File Offset: 0x00643134
		private void IMEDKJNAHKK()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.position, this.leftHandChar.solver.KIGACGJAJKO().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.CMKJIGNKIMG().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.MJOPIBNHGIK().rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.leftHandChar.solver.KIGACGJAJKO().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB17 RID: 56087 RVA: 0x0064508C File Offset: 0x0064328C
		private void NPDBHEONIDA()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.position, this.leftHandChar.solver.KIGACGJAJKO().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.rightHandEffector.bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.leftHandEffector.bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.IANMIEDIJPJ().position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.leftHandChar.solver.CMKJIGNKIMG().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB18 RID: 56088 RVA: 0x006451E4 File Offset: 0x006433E4
		private void OOGNHIIPHBH()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.position, this.leftHandChar.solver.leftHandEffector.bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.EMPOFCMIGLD().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.leftHandChar.solver.KIGACGJAJKO().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB19 RID: 56089 RVA: 0x0064533C File Offset: 0x0064353C
		private void LHFBEKCIKOI()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.position, this.leftHandChar.solver.EMPOFCMIGLD().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.KIGACGJAJKO().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.rightHandEffector.position = this.rightHandTarget.position;
			this.rightHandChar.solver.MJOPIBNHGIK().rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.KIGACGJAJKO().position = this.leftHandTarget.position;
			this.leftHandChar.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB1A RID: 56090 RVA: 0x00645494 File Offset: 0x00643694
		private void Start()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.rightHandEffector.bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.leftHandEffector.bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB1B RID: 56091 RVA: 0x0064550C File Offset: 0x0064370C
		private void MKNPFMEMOJO()
		{
			this.CALJLNNIIML = Quaternion.Inverse(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation) * base.transform.rotation;
			this.CHMDKGLDNML = Quaternion.Inverse(this.leftHandChar.solver.CMKJIGNKIMG().bone.rotation) * base.transform.rotation;
		}

		// Token: 0x0600DB1C RID: 56092 RVA: 0x00645584 File Offset: 0x00643784
		private void KCJNJBEJHFA()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.MJOPIBNHGIK().bone.position, this.leftHandChar.solver.KIGACGJAJKO().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.KIGACGJAJKO().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.rightHandEffector.position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.leftHandChar.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x0600DB1D RID: 56093 RVA: 0x006456DC File Offset: 0x006438DC
		private void DFNJNCCPKJF()
		{
			Vector3 b = Vector3.Lerp(this.rightHandChar.solver.IANMIEDIJPJ().bone.position, this.leftHandChar.solver.EMPOFCMIGLD().bone.position, this.crossFade);
			base.transform.position = Vector3.Lerp(base.transform.position, b, Time.deltaTime * this.speed);
			base.transform.rotation = Quaternion.Slerp(this.rightHandChar.solver.rightHandEffector.bone.rotation * this.CALJLNNIIML, this.leftHandChar.solver.EMPOFCMIGLD().bone.rotation * this.CHMDKGLDNML, this.crossFade);
			this.rightHandChar.solver.MJOPIBNHGIK().position = this.rightHandTarget.position;
			this.rightHandChar.solver.rightHandEffector.rotation = this.rightHandTarget.rotation;
			this.leftHandChar.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.leftHandChar.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
		}

		// Token: 0x04001D06 RID: 7430
		public FullBodyBipedIK rightHandChar;

		// Token: 0x04001D07 RID: 7431
		public FullBodyBipedIK leftHandChar;

		// Token: 0x04001D08 RID: 7432
		public Transform rightHandTarget;

		// Token: 0x04001D09 RID: 7433
		public Transform leftHandTarget;

		// Token: 0x04001D0A RID: 7434
		public float crossFade;

		// Token: 0x04001D0B RID: 7435
		public float speed = 10f;

		// Token: 0x04001D0C RID: 7436
		private Quaternion CALJLNNIIML;

		// Token: 0x04001D0D RID: 7437
		private Quaternion CHMDKGLDNML;
	}
}
