using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000407 RID: 1031
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class PendulumExample : MonoBehaviour
	{
		// Token: 0x0600DD55 RID: 56661 RVA: 0x00652C00 File Offset: 0x00650E00
		private void MCHAAIIHOKD()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD56 RID: 56662 RVA: 0x00652D0C File Offset: 0x00650F0C
		private void OFGMIEJKMGC()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD57 RID: 56663 RVA: 0x00652E18 File Offset: 0x00651018
		private void CGNFLAOBEFN()
		{
			if (this.weight > 666f)
			{
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1759f)
				{
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 1246f;
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = 1767f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1478f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD58 RID: 56664 RVA: 0x006530EC File Offset: 0x006512EC
		private void NPDBHEONIDA()
		{
			if (this.weight > 487f)
			{
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 9f)
				{
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 388f;
					this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = 266f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1322f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD59 RID: 56665 RVA: 0x006533C0 File Offset: 0x006515C0
		private void CODAMDJCPHK()
		{
			if (this.weight > 38f)
			{
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 271f)
				{
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 1986f;
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = 110f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 900f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD5A RID: 56666 RVA: 0x00653694 File Offset: 0x00651894
		private void EIEKEPGNGPL()
		{
			if (this.weight > 1193f)
			{
				this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1696f)
				{
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 289f;
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = 1764f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1293f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD5B RID: 56667 RVA: 0x00653968 File Offset: 0x00651B68
		private void EHDPACPIBNF()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD5C RID: 56668 RVA: 0x00653A74 File Offset: 0x00651C74
		private void CGMHGDEKDEP()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD5D RID: 56669 RVA: 0x00653B80 File Offset: 0x00651D80
		private void EDGALMCHPPH()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD5E RID: 56670 RVA: 0x00653C8C File Offset: 0x00651E8C
		private void KIMKOEBBFKJ()
		{
			if (this.weight > 1271f)
			{
				this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 594f)
				{
					this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = 1561f;
					this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = 145f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 333f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD5F RID: 56671 RVA: 0x00653F60 File Offset: 0x00652160
		private void AEAPIKAENBD()
		{
			if (this.weight > 274f)
			{
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1510f)
				{
					this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 471f;
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = 1235f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 830f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD60 RID: 56672 RVA: 0x00654234 File Offset: 0x00652434
		private void LHFBEKCIKOI()
		{
			if (this.weight > 409f)
			{
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 52f)
				{
					this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 679f;
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = 186f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1238f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD61 RID: 56673 RVA: 0x00654508 File Offset: 0x00652708
		private void KCJNJBEJHFA()
		{
			if (this.weight > 1227f)
			{
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1522f)
				{
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = 1991f;
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = 1339f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1465f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD62 RID: 56674 RVA: 0x006547DC File Offset: 0x006529DC
		private void MKNPFMEMOJO()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD63 RID: 56675 RVA: 0x006548E8 File Offset: 0x00652AE8
		private void CBLGFOFHNPJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD64 RID: 56676 RVA: 0x006549F4 File Offset: 0x00652BF4
		private void PNAAHEFHPCL()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD65 RID: 56677 RVA: 0x00654B00 File Offset: 0x00652D00
		private void OKFONGOBMCC()
		{
			if (this.weight > 1810f)
			{
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 6f)
				{
					this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 433f;
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = 140f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1322f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD66 RID: 56678 RVA: 0x00654DD4 File Offset: 0x00652FD4
		private void IMEDKJNAHKK()
		{
			if (this.weight > 1596f)
			{
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1941f)
				{
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 1813f;
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = 278f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1493f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD67 RID: 56679 RVA: 0x006550A8 File Offset: 0x006532A8
		private void JJMGNAMFJGJ()
		{
			if (this.weight > 117f)
			{
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 784f)
				{
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1093f;
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = 1298f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 574f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD68 RID: 56680 RVA: 0x0065537C File Offset: 0x0065357C
		private void GFELHLPHCDN()
		{
			if (this.weight > 913f)
			{
				this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1134f)
				{
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1565f;
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = 1131f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 429f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD69 RID: 56681 RVA: 0x00655650 File Offset: 0x00653850
		private void GCJBBACOJJE()
		{
			if (this.weight > 1960f)
			{
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1541f)
				{
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 254f;
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = 427f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1515f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD6A RID: 56682 RVA: 0x00655924 File Offset: 0x00653B24
		private void LMEJKAEIDCO()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD6B RID: 56683 RVA: 0x00655A30 File Offset: 0x00653C30
		private void HJDEGPKFBNI()
		{
			if (this.weight > 305f)
			{
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1255f)
				{
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 1151f;
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = 93f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1654f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD6C RID: 56684 RVA: 0x00655D04 File Offset: 0x00653F04
		private void HDFCIACDDEK()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD6D RID: 56685 RVA: 0x00655E10 File Offset: 0x00654010
		private void FPLHODJCJDO()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD6E RID: 56686 RVA: 0x00655F1C File Offset: 0x0065411C
		private void CLHGHANANNL()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD6F RID: 56687 RVA: 0x00656028 File Offset: 0x00654228
		private void CFHDJOKLHDB()
		{
			if (this.weight > 1273f)
			{
				this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1154f)
				{
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = 1412f;
					this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotationWeight = 272f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 966f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD70 RID: 56688 RVA: 0x006562FC File Offset: 0x006544FC
		private void KCMJALIDEHB()
		{
			if (this.weight > 1782f)
			{
				this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1278f)
				{
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1959f;
					this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = 1061f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1883f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD71 RID: 56689 RVA: 0x006565D0 File Offset: 0x006547D0
		private void EFJDBBDMPMC()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD72 RID: 56690 RVA: 0x006566DC File Offset: 0x006548DC
		private void LPNDCJKAKEA()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD73 RID: 56691 RVA: 0x006567E8 File Offset: 0x006549E8
		private void DGEIACONKCJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD74 RID: 56692 RVA: 0x006568F4 File Offset: 0x00654AF4
		private void GIKJMPHFJKH()
		{
			if (this.weight > 742f)
			{
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1249f)
				{
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = 1485f;
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = 926f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1348f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD76 RID: 56694 RVA: 0x00656BF0 File Offset: 0x00654DF0
		private void KIEIPFFEDHC()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD77 RID: 56695 RVA: 0x00656CFC File Offset: 0x00654EFC
		private void LCMMGLMJPOK()
		{
			if (this.weight > 1141f)
			{
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1916f)
				{
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 1450f;
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = 666f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1493f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD78 RID: 56696 RVA: 0x00656FD0 File Offset: 0x006551D0
		private void PPIJKKNAJAC()
		{
			if (this.weight > 953f)
			{
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 952f)
				{
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1923f;
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = 1884f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 806f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD79 RID: 56697 RVA: 0x006572A4 File Offset: 0x006554A4
		private void Start()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD7A RID: 56698 RVA: 0x006573B0 File Offset: 0x006555B0
		private void CPNOBMNKPNC()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD7B RID: 56699 RVA: 0x006574BC File Offset: 0x006556BC
		private void OGFGENJAMAM()
		{
			if (this.weight > 997f)
			{
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 340f)
				{
					this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 790f;
					this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = 1719f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 623f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD7C RID: 56700 RVA: 0x00657790 File Offset: 0x00655990
		private void GDIMBBBPIHI()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD7D RID: 56701 RVA: 0x0065789C File Offset: 0x00655A9C
		private void LateUpdate()
		{
			if (this.weight > 0f)
			{
				this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 0f)
				{
					this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 0f;
					this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = 0f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 0f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.leftHandEffector.position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD7E RID: 56702 RVA: 0x00657B70 File Offset: 0x00655D70
		private void ELADFDNPOOI()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD7F RID: 56703 RVA: 0x00657C7C File Offset: 0x00655E7C
		private void CKCBGFMFNFK()
		{
			if (this.weight > 215f)
			{
				this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1604f)
				{
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = 226f;
					this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = 863f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1133f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD80 RID: 56704 RVA: 0x00657F50 File Offset: 0x00656150
		private void POCOKCJDCHK()
		{
			if (this.weight > 349f)
			{
				this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1450f)
				{
					this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = 254f;
					this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = 1011f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1770f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD81 RID: 56705 RVA: 0x00658224 File Offset: 0x00656424
		private void OOGNHIIPHBH()
		{
			if (this.weight > 1579f)
			{
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1320f)
				{
					this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = 634f;
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = 282f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 442f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD82 RID: 56706 RVA: 0x006584F8 File Offset: 0x006566F8
		private void FFIGGPHAIBP()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD83 RID: 56707 RVA: 0x00658604 File Offset: 0x00656804
		private void OFJPMLKIDEH()
		{
			if (this.weight > 1959f)
			{
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 612f)
				{
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 200f;
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = 1814f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 116f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD84 RID: 56708 RVA: 0x006588D8 File Offset: 0x00656AD8
		private void ONIHHFLOJMN()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD85 RID: 56709 RVA: 0x006589E4 File Offset: 0x00656BE4
		private void FIJKDFIMELM()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD86 RID: 56710 RVA: 0x00658AF0 File Offset: 0x00656CF0
		private void GHIJFOALMHM()
		{
			if (this.weight > 746f)
			{
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 333f)
				{
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = 1058f;
					this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotationWeight = 657f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 201f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD87 RID: 56711 RVA: 0x00658DC4 File Offset: 0x00656FC4
		private void MJBLHNGLFOE()
		{
			if (this.weight > 1123f)
			{
				this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1725f)
				{
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 1654f;
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = 1340f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 172f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD88 RID: 56712 RVA: 0x00659098 File Offset: 0x00657298
		private void OIKMLNIPLIA()
		{
			if (this.weight > 1202f)
			{
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 747f)
				{
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = 505f;
					this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = 1017f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1595f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD89 RID: 56713 RVA: 0x0065936C File Offset: 0x0065756C
		private void MKNDDFMIGDN()
		{
			if (this.weight > 1545f)
			{
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1500f)
				{
					this.OJMBOCNNLMI.solver.leftHandEffector.positionWeight = 1048f;
					this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = 1670f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1004f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD8A RID: 56714 RVA: 0x00659640 File Offset: 0x00657840
		private void KJJNMNKPNCH()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD8B RID: 56715 RVA: 0x0065974C File Offset: 0x0065794C
		private void CGNGBFFGGBP()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD8C RID: 56716 RVA: 0x00659858 File Offset: 0x00657A58
		private void JIFIMFCJDHL()
		{
			if (this.weight > 888f)
			{
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1741f)
				{
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().positionWeight = 1202f;
					this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = 357f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 823f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD8D RID: 56717 RVA: 0x00659B2C File Offset: 0x00657D2C
		private void POMLHOHFIGA()
		{
			if (this.weight > 266f)
			{
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1541f)
				{
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = 1986f;
					this.OJMBOCNNLMI.solver.CMKJIGNKIMG().rotationWeight = 1786f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 262f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD8E RID: 56718 RVA: 0x00659E00 File Offset: 0x00658000
		private void AOCDDBNBADJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD8F RID: 56719 RVA: 0x00659F0C File Offset: 0x0065810C
		private void ANHOOJFEJJE()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD90 RID: 56720 RVA: 0x0065A018 File Offset: 0x00658218
		private void CMDJHGMGLCG()
		{
			if (this.weight > 776f)
			{
				this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 1657f)
				{
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 281f;
					this.OJMBOCNNLMI.solver.leftHandEffector.rotationWeight = 808f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 1411f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.CMKJIGNKIMG().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD91 RID: 56721 RVA: 0x0065A2EC File Offset: 0x006584EC
		private void JPGFHBACEGG()
		{
			if (this.weight > 1250f)
			{
				this.OJMBOCNNLMI.solver.CMKJIGNKIMG().positionWeight = this.weight;
				this.OJMBOCNNLMI.solver.EMPOFCMIGLD().rotationWeight = this.weight;
			}
			else
			{
				this.rootTargetPosition = base.transform.position;
				this.rootTargetRotation = base.transform.rotation;
				if (this.PIJKOMKCJOG > 994f)
				{
					this.OJMBOCNNLMI.solver.DBCIMCKLHIM().positionWeight = 868f;
					this.OJMBOCNNLMI.solver.KIGACGJAJKO().rotationWeight = 1299f;
				}
			}
			this.PIJKOMKCJOG = this.weight;
			if (this.weight <= 166f)
			{
				return;
			}
			base.transform.position = Vector3.Lerp(this.rootTargetPosition, this.pelvisTarget.position + this.pelvisTarget.rotation * this.ICCNGNPAEHG * this.hangingDistanceMlp, this.weight);
			base.transform.rotation = Quaternion.Lerp(this.rootTargetRotation, this.pelvisTarget.rotation * this.FMNAEFEIPNJ, this.weight);
			this.OJMBOCNNLMI.solver.DBCIMCKLHIM().position = this.leftHandTarget.position;
			this.OJMBOCNNLMI.solver.leftHandEffector.rotation = this.leftHandTarget.rotation;
			Vector3 fromDirection = this.OJMBOCNNLMI.references.pelvis.rotation * this.pelvisDownAxis;
			Quaternion b = Quaternion.FromToRotation(fromDirection, this.rightHandTarget.position - this.headTarget.position);
			this.OJMBOCNNLMI.references.rightUpperArm.rotation = Quaternion.Lerp(Quaternion.identity, b, this.weight) * this.OJMBOCNNLMI.references.rightUpperArm.rotation;
			Quaternion b2 = Quaternion.FromToRotation(fromDirection, this.leftFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.leftThigh.rotation = Quaternion.Lerp(Quaternion.identity, b2, this.weight) * this.OJMBOCNNLMI.references.leftThigh.rotation;
			Quaternion b3 = Quaternion.FromToRotation(fromDirection, this.rightFootTarget.position - this.bodyTarget.position);
			this.OJMBOCNNLMI.references.rightThigh.rotation = Quaternion.Lerp(Quaternion.identity, b3, this.weight) * this.OJMBOCNNLMI.references.rightThigh.rotation;
		}

		// Token: 0x0600DD92 RID: 56722 RVA: 0x0065A5C0 File Offset: 0x006587C0
		private void CGFDDFHECLJ()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x0600DD93 RID: 56723 RVA: 0x0065A6CC File Offset: 0x006588CC
		private void CAJLCEPLKJG()
		{
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
			Quaternion rotation = this.target.rotation;
			this.target.rotation = this.leftHandTarget.rotation;
			this.target.gameObject.AddComponent<FixedJoint>().connectedBody = this.leftHandTarget.GetComponent<Rigidbody>();
			this.target.GetComponent<Rigidbody>().MoveRotation(rotation);
			this.FMNAEFEIPNJ = Quaternion.Inverse(this.pelvisTarget.rotation) * base.transform.rotation;
			this.ICCNGNPAEHG = Quaternion.Inverse(this.OJMBOCNNLMI.references.pelvis.rotation) * (base.transform.position - this.OJMBOCNNLMI.references.pelvis.position);
			this.rootTargetPosition = base.transform.position;
			this.rootTargetRotation = base.transform.rotation;
			this.PIJKOMKCJOG = this.weight;
		}

		// Token: 0x04001D43 RID: 7491
		[Range(0f, 1f)]
		[Tooltip("The master weight of this script.")]
		public float weight = 1f;

		// Token: 0x04001D44 RID: 7492
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp = 1.3f;

		// Token: 0x04001D45 RID: 7493
		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		// Token: 0x04001D46 RID: 7494
		[HideInInspector]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		public Quaternion rootTargetRotation;

		// Token: 0x04001D47 RID: 7495
		[SerializeField]
		private Transform target;

		// Token: 0x04001D48 RID: 7496
		[SerializeField]
		private Transform leftHandTarget;

		// Token: 0x04001D49 RID: 7497
		[SerializeField]
		private Transform rightHandTarget;

		// Token: 0x04001D4A RID: 7498
		[SerializeField]
		private Transform leftFootTarget;

		// Token: 0x04001D4B RID: 7499
		[SerializeField]
		private Transform rightFootTarget;

		// Token: 0x04001D4C RID: 7500
		[SerializeField]
		private Transform pelvisTarget;

		// Token: 0x04001D4D RID: 7501
		[SerializeField]
		private Transform bodyTarget;

		// Token: 0x04001D4E RID: 7502
		[SerializeField]
		private Transform headTarget;

		// Token: 0x04001D4F RID: 7503
		[SerializeField]
		private Vector3 pelvisDownAxis = Vector3.right;

		// Token: 0x04001D50 RID: 7504
		private FullBodyBipedIK OJMBOCNNLMI;

		// Token: 0x04001D51 RID: 7505
		private Quaternion FMNAEFEIPNJ;

		// Token: 0x04001D52 RID: 7506
		private Vector3 ICCNGNPAEHG;

		// Token: 0x04001D53 RID: 7507
		private float PIJKOMKCJOG;
	}
}
