using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003EF RID: 1007
	[RequireComponent(typeof(FullBodyBipedIK))]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		// Token: 0x0600D8DF RID: 55519 RVA: 0x00631822 File Offset: 0x0062FA22
		protected virtual void MCHAAIIHOKD()
		{
			base.PBMPJPIMJBF();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D8E0 RID: 55520 RVA: 0x00631836 File Offset: 0x0062FA36
		protected virtual void ELFLOPJDAKK()
		{
			base.NOKJMMDMJNO();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D8E1 RID: 55521 RVA: 0x0063184C File Offset: 0x0062FA4C
		private void MKNOPDBDBON(IKEffector JEFKLIBDHKK, Quaternion PHKIOHIBNPA, float PIOGNAMGLNM)
		{
			Vector3 vector = JEFKLIBDHKK.bone.position - base.transform.position;
			Vector3 a = PHKIOHIBNPA * vector - vector;
			JEFKLIBDHKK.positionOffset += a * PIOGNAMGLNM;
		}

		// Token: 0x0600D8E2 RID: 55522 RVA: 0x0063189C File Offset: 0x0062FA9C
		protected override void LateUpdate()
		{
			base.LateUpdate();
			if (Vector3.Angle(base.transform.up, Vector3.up) <= 0.01f)
			{
				return;
			}
			Quaternion phkiohibnpa = Quaternion.FromToRotation(base.transform.up, Vector3.up);
			this.EPBKEGKLEGN(this.OJMBOCNNLMI.solver.bodyEffector, phkiohibnpa, 0.1f);
			this.EPBKEGKLEGN(this.OJMBOCNNLMI.solver.leftShoulderEffector, phkiohibnpa, 0.2f);
			this.EPBKEGKLEGN(this.OJMBOCNNLMI.solver.rightShoulderEffector, phkiohibnpa, 0.2f);
			this.EPBKEGKLEGN(this.OJMBOCNNLMI.solver.leftHandEffector, phkiohibnpa, 0.1f);
			this.EPBKEGKLEGN(this.OJMBOCNNLMI.solver.rightHandEffector, phkiohibnpa, 0.1f);
		}

		// Token: 0x0600D8E3 RID: 55523 RVA: 0x00631822 File Offset: 0x0062FA22
		protected virtual void OBJCOJEHLBE()
		{
			base.PBMPJPIMJBF();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D8E5 RID: 55525 RVA: 0x00631836 File Offset: 0x0062FA36
		protected virtual void KEMGOLACEHI()
		{
			base.NOKJMMDMJNO();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D8E6 RID: 55526 RVA: 0x00631836 File Offset: 0x0062FA36
		protected override void FIJKDFIMELM()
		{
			base.NOKJMMDMJNO();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D8E7 RID: 55527 RVA: 0x00631822 File Offset: 0x0062FA22
		protected virtual void ANHOOJFEJJE()
		{
			base.PBMPJPIMJBF();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D8E8 RID: 55528 RVA: 0x00631978 File Offset: 0x0062FB78
		private void HMPOCOCDOLC(IKEffector JEFKLIBDHKK, Quaternion PHKIOHIBNPA, float PIOGNAMGLNM)
		{
			Vector3 vector = JEFKLIBDHKK.bone.position - base.transform.position;
			Vector3 a = PHKIOHIBNPA * vector - vector;
			JEFKLIBDHKK.positionOffset += a * PIOGNAMGLNM;
		}

		// Token: 0x0600D8E9 RID: 55529 RVA: 0x006319C8 File Offset: 0x0062FBC8
		protected virtual void DFNJNCCPKJF()
		{
			base.LateUpdate();
			if (Vector3.Angle(base.transform.up, Vector3.up) <= 1381f)
			{
				return;
			}
			Quaternion phkiohibnpa = Quaternion.FromToRotation(base.transform.up, Vector3.up);
			this.ALACKOCJLNC(this.OJMBOCNNLMI.solver.bodyEffector, phkiohibnpa, 1968f);
			this.MKNOPDBDBON(this.OJMBOCNNLMI.solver.ELPKPOGKHOP(), phkiohibnpa, 1594f);
			this.MKNOPDBDBON(this.OJMBOCNNLMI.solver.DMPDLFPCDFO(), phkiohibnpa, 899f);
			this.ALACKOCJLNC(this.OJMBOCNNLMI.solver.leftHandEffector, phkiohibnpa, 1948f);
			this.ALACKOCJLNC(this.OJMBOCNNLMI.solver.MJOPIBNHGIK(), phkiohibnpa, 68f);
		}

		// Token: 0x0600D8EA RID: 55530 RVA: 0x00631A9C File Offset: 0x0062FC9C
		private void ALACKOCJLNC(IKEffector JEFKLIBDHKK, Quaternion PHKIOHIBNPA, float PIOGNAMGLNM)
		{
			Vector3 vector = JEFKLIBDHKK.bone.position - base.transform.position;
			Vector3 a = PHKIOHIBNPA * vector - vector;
			JEFKLIBDHKK.positionOffset += a * PIOGNAMGLNM;
		}

		// Token: 0x0600D8EB RID: 55531 RVA: 0x00631AEB File Offset: 0x0062FCEB
		protected override void ONIHHFLOJMN()
		{
			base.ONIHHFLOJMN();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D8EC RID: 55532 RVA: 0x00631AFF File Offset: 0x0062FCFF
		protected override void Start()
		{
			base.Start();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D8ED RID: 55533 RVA: 0x00631B13 File Offset: 0x0062FD13
		protected virtual void OFGMIEJKMGC()
		{
			base.FGJCIEDDFGN();
			this.OJMBOCNNLMI = base.GetComponent<FullBodyBipedIK>();
		}

		// Token: 0x0600D8EE RID: 55534 RVA: 0x00631B28 File Offset: 0x0062FD28
		private void EPBKEGKLEGN(IKEffector JEFKLIBDHKK, Quaternion PHKIOHIBNPA, float PIOGNAMGLNM)
		{
			Vector3 vector = JEFKLIBDHKK.bone.position - base.transform.position;
			Vector3 a = PHKIOHIBNPA * vector - vector;
			JEFKLIBDHKK.positionOffset += a * PIOGNAMGLNM;
		}

		// Token: 0x04001CBF RID: 7359
		private FullBodyBipedIK OJMBOCNNLMI;
	}
}
