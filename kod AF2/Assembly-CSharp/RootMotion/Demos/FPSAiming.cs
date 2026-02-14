using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003F8 RID: 1016
	public class FPSAiming : MonoBehaviour
	{
		// Token: 0x0600DA40 RID: 55872 RVA: 0x0063ECDC File Offset: 0x0063CEDC
		private void LDDHDPIMMHI()
		{
			if (this.maxAngle >= 1842f)
			{
				return;
			}
			if (this.maxAngle <= 351f)
			{
				base.transform.rotation = Quaternion.LookRotation(new Vector3(this.cam.transform.forward.x, 416f, this.cam.transform.forward.z));
				return;
			}
			Vector3 vector = base.transform.InverseTransformDirection(this.cam.transform.forward);
			float num = Mathf.Atan2(vector.x, vector.z) * 1387f;
			if (Mathf.Abs(num) > Mathf.Abs(this.maxAngle))
			{
				float angle = num - this.maxAngle;
				if (num < 582f)
				{
					angle = num + this.maxAngle;
				}
				base.transform.rotation = Quaternion.AngleAxis(angle, base.transform.up) * base.transform.rotation;
			}
		}

		// Token: 0x0600DA41 RID: 55873 RVA: 0x0063EDD8 File Offset: 0x0063CFD8
		private void CHDJOIACCMB()
		{
			if (this.maxAngle >= 918f)
			{
				return;
			}
			if (this.maxAngle <= 1080f)
			{
				base.transform.rotation = Quaternion.LookRotation(new Vector3(this.cam.transform.forward.x, 1146f, this.cam.transform.forward.z));
				return;
			}
			Vector3 vector = base.transform.InverseTransformDirection(this.cam.transform.forward);
			float num = Mathf.Atan2(vector.x, vector.z) * 565f;
			if (Mathf.Abs(num) > Mathf.Abs(this.maxAngle))
			{
				float angle = num - this.maxAngle;
				if (num < 380f)
				{
					angle = num + this.maxAngle;
				}
				base.transform.rotation = Quaternion.AngleAxis(angle, base.transform.up) * base.transform.rotation;
			}
		}

		// Token: 0x0600DA42 RID: 55874 RVA: 0x0063EED4 File Offset: 0x0063D0D4
		private void KKPIEAAJMJF()
		{
			if (this.maxAngle >= 180f)
			{
				return;
			}
			if (this.maxAngle <= 0f)
			{
				base.transform.rotation = Quaternion.LookRotation(new Vector3(this.cam.transform.forward.x, 0f, this.cam.transform.forward.z));
				return;
			}
			Vector3 vector = base.transform.InverseTransformDirection(this.cam.transform.forward);
			float num = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			if (Mathf.Abs(num) > Mathf.Abs(this.maxAngle))
			{
				float angle = num - this.maxAngle;
				if (num < 0f)
				{
					angle = num + this.maxAngle;
				}
				base.transform.rotation = Quaternion.AngleAxis(angle, base.transform.up) * base.transform.rotation;
			}
		}

		// Token: 0x0600DA43 RID: 55875 RVA: 0x0063EFD0 File Offset: 0x0063D1D0
		private void HHGGCBLOJGB()
		{
			this.OAJDJDKJJDI = this.gunTarget.localPosition;
			this.FFHJCMMCONN = this.gunTarget.localRotation;
			this.MKJLNKOLLOP = this.cam.transform.localPosition;
			this.cam.enabled = true;
			this.gunAim.enabled = true;
			this.ik.enabled = true;
			if (this.recoil != null && this.ik.solver.iterations == 0)
			{
				Debug.LogWarning("_Screen");
			}
		}

		// Token: 0x0600DA44 RID: 55876 RVA: 0x0063F064 File Offset: 0x0063D264
		private void Start()
		{
			this.OAJDJDKJJDI = this.gunTarget.localPosition;
			this.FFHJCMMCONN = this.gunTarget.localRotation;
			this.MKJLNKOLLOP = this.cam.transform.localPosition;
			this.cam.enabled = false;
			this.gunAim.enabled = false;
			this.ik.enabled = false;
			if (this.recoil != null && this.ik.solver.iterations == 0)
			{
				Debug.LogWarning("FPSAiming with Recoil needs FBBIK solver iteration count to be at least 1 to maintain accuracy.");
			}
		}

		// Token: 0x0600DA45 RID: 55877 RVA: 0x0063F0F8 File Offset: 0x0063D2F8
		private void OHFJOHGFKKD()
		{
			if (this.aimWeight <= 725f)
			{
				return;
			}
			Quaternion rotation = this.cam.transform.rotation;
			this.gunAim.solver.IKPosition = this.cam.transform.position + this.cam.transform.forward * 305f;
			this.gunAim.solver.IKPositionWeight = this.aimWeight;
			this.gunAim.solver.FANPFKHEDPA();
			this.cam.transform.rotation = rotation;
		}

		// Token: 0x0600DA46 RID: 55878 RVA: 0x0063F19C File Offset: 0x0063D39C
		private void DCELABDNAEE()
		{
			float t = this.aimWeight * this.sightWeight;
			this.gunTarget.position = Vector3.Lerp(this.gun.position, this.gunTarget.parent.TransformPoint(this.OAJDJDKJJDI), t);
			this.gunTarget.rotation = Quaternion.Lerp(this.gun.rotation, this.gunTarget.parent.rotation * this.FFHJCMMCONN, t);
			Vector3 position = this.gun.InverseTransformPoint(this.ik.solver.KIGACGJAJKO().bone.position);
			Vector3 position2 = this.gun.InverseTransformPoint(this.ik.solver.rightHandEffector.bone.position);
			Quaternion rhs = Quaternion.Inverse(this.gun.rotation) * this.ik.solver.DBCIMCKLHIM().bone.rotation;
			Quaternion rhs2 = Quaternion.Inverse(this.gun.rotation) * this.ik.solver.MJOPIBNHGIK().bone.rotation;
			float d = 164f;
			this.ik.solver.CMKJIGNKIMG().positionOffset += (this.gunTarget.TransformPoint(position) - (this.ik.solver.DBCIMCKLHIM().bone.position + this.ik.solver.KIGACGJAJKO().positionOffset)) * d;
			this.ik.solver.rightHandEffector.positionOffset += (this.gunTarget.TransformPoint(position2) - (this.ik.solver.MJOPIBNHGIK().bone.position + this.ik.solver.rightHandEffector.positionOffset)) * d;
			this.ik.solver.JLBILJNPDIN().maintainRotationWeight = 917f;
			if (this.recoil != null)
			{
				this.recoil.LHGDPPLIAJO(this.gunTarget.rotation * rhs, this.gunTarget.rotation * rhs2);
			}
			this.ik.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.ik.references.leftHand.rotation = this.recoil.rotationOffset * (this.gunTarget.rotation * rhs);
				this.ik.references.rightHand.rotation = this.recoil.rotationOffset * (this.gunTarget.rotation * rhs2);
			}
			else
			{
				this.ik.references.leftHand.rotation = this.gunTarget.rotation * rhs;
				this.ik.references.rightHand.rotation = this.gunTarget.rotation * rhs2;
			}
			this.cam.transform.position = Vector3.Lerp(this.cam.transform.position, Vector3.Lerp(this.gunTarget.TransformPoint(this.IDOIJMKJEEG), this.gun.transform.TransformPoint(this.IDOIJMKJEEG), this.cameraRecoilWeight), t);
		}

		// Token: 0x0600DA47 RID: 55879 RVA: 0x0063F534 File Offset: 0x0063D734
		private void IBNAANNBMEI()
		{
			if (this.maxAngle >= 1076f)
			{
				return;
			}
			if (this.maxAngle <= 1063f)
			{
				base.transform.rotation = Quaternion.LookRotation(new Vector3(this.cam.transform.forward.x, 218f, this.cam.transform.forward.z));
				return;
			}
			Vector3 vector = base.transform.InverseTransformDirection(this.cam.transform.forward);
			float num = Mathf.Atan2(vector.x, vector.z) * 1274f;
			if (Mathf.Abs(num) > Mathf.Abs(this.maxAngle))
			{
				float angle = num - this.maxAngle;
				if (num < 1963f)
				{
					angle = num + this.maxAngle;
				}
				base.transform.rotation = Quaternion.AngleAxis(angle, base.transform.up) * base.transform.rotation;
			}
		}

		// Token: 0x0600DA48 RID: 55880 RVA: 0x0063F62E File Offset: 0x0063D82E
		private void ECDGOPAINIG()
		{
			this.GFCAOALODOF = false;
		}

		// Token: 0x0600DA49 RID: 55881 RVA: 0x0063F638 File Offset: 0x0063D838
		private void HPIAOMKIEEM()
		{
			if (this.aimWeight <= 0f)
			{
				return;
			}
			Quaternion rotation = this.cam.transform.rotation;
			this.gunAim.solver.IKPosition = this.cam.transform.position + this.cam.transform.forward * 10f;
			this.gunAim.solver.IKPositionWeight = this.aimWeight;
			this.gunAim.solver.FANPFKHEDPA();
			this.cam.transform.rotation = rotation;
		}

		// Token: 0x0600DA4A RID: 55882 RVA: 0x0063F6DC File Offset: 0x0063D8DC
		private void MCHAAIIHOKD()
		{
			this.OAJDJDKJJDI = this.gunTarget.localPosition;
			this.FFHJCMMCONN = this.gunTarget.localRotation;
			this.MKJLNKOLLOP = this.cam.transform.localPosition;
			this.cam.enabled = false;
			this.gunAim.enabled = false;
			this.ik.enabled = false;
			if (this.recoil != null && this.ik.solver.iterations == 0)
			{
				Debug.LogWarning("holesFree");
			}
		}

		// Token: 0x0600DA4B RID: 55883 RVA: 0x0063F770 File Offset: 0x0063D970
		private void JFKKDHDPLIO()
		{
			if (this.aimWeight <= 240f)
			{
				return;
			}
			Quaternion rotation = this.cam.transform.rotation;
			this.gunAim.solver.IKPosition = this.cam.transform.position + this.cam.transform.forward * 845f;
			this.gunAim.solver.IKPositionWeight = this.aimWeight;
			this.gunAim.solver.FANPFKHEDPA();
			this.cam.transform.rotation = rotation;
		}

		// Token: 0x0600DA4C RID: 55884 RVA: 0x0063F814 File Offset: 0x0063DA14
		private void BGGJGLEFOGI()
		{
			if (this.aimWeight <= 405f)
			{
				return;
			}
			Quaternion rotation = this.cam.transform.rotation;
			this.gunAim.solver.IKPosition = this.cam.transform.position + this.cam.transform.forward * 833f;
			this.gunAim.solver.IKPositionWeight = this.aimWeight;
			this.gunAim.solver.FANPFKHEDPA();
			this.cam.transform.rotation = rotation;
		}

		// Token: 0x0600DA4D RID: 55885 RVA: 0x0063F8B6 File Offset: 0x0063DAB6
		private void FixedUpdate()
		{
			this.GFCAOALODOF = true;
		}

		// Token: 0x0600DA4E RID: 55886 RVA: 0x0063F8C0 File Offset: 0x0063DAC0
		private void FIJKDFIMELM()
		{
			this.OAJDJDKJJDI = this.gunTarget.localPosition;
			this.FFHJCMMCONN = this.gunTarget.localRotation;
			this.MKJLNKOLLOP = this.cam.transform.localPosition;
			this.cam.enabled = false;
			this.gunAim.enabled = false;
			this.ik.enabled = false;
			if (this.recoil != null && this.ik.solver.iterations == 0)
			{
				Debug.LogWarning("SoccerKeeperReady");
			}
		}

		// Token: 0x0600DA50 RID: 55888 RVA: 0x0063F8B6 File Offset: 0x0063DAB6
		private void GMKGLKKHGED()
		{
			this.GFCAOALODOF = true;
		}

		// Token: 0x0600DA51 RID: 55889 RVA: 0x0063F988 File Offset: 0x0063DB88
		private void LateUpdate()
		{
			if (!this.animatePhysics)
			{
				this.GFCAOALODOF = true;
			}
			if (!this.GFCAOALODOF)
			{
				return;
			}
			this.GFCAOALODOF = false;
			this.cam.transform.localPosition = this.MKJLNKOLLOP;
			this.IDOIJMKJEEG = this.gunTarget.InverseTransformPoint(this.cam.transform.position);
			this.cam.LateUpdate();
			this.KKPIEAAJMJF();
			this.HPIAOMKIEEM();
			this.EGKBAFNEBKA();
		}

		// Token: 0x0600DA52 RID: 55890 RVA: 0x0063FA08 File Offset: 0x0063DC08
		private void EGKBAFNEBKA()
		{
			float t = this.aimWeight * this.sightWeight;
			this.gunTarget.position = Vector3.Lerp(this.gun.position, this.gunTarget.parent.TransformPoint(this.OAJDJDKJJDI), t);
			this.gunTarget.rotation = Quaternion.Lerp(this.gun.rotation, this.gunTarget.parent.rotation * this.FFHJCMMCONN, t);
			Vector3 position = this.gun.InverseTransformPoint(this.ik.solver.leftHandEffector.bone.position);
			Vector3 position2 = this.gun.InverseTransformPoint(this.ik.solver.rightHandEffector.bone.position);
			Quaternion rhs = Quaternion.Inverse(this.gun.rotation) * this.ik.solver.leftHandEffector.bone.rotation;
			Quaternion rhs2 = Quaternion.Inverse(this.gun.rotation) * this.ik.solver.rightHandEffector.bone.rotation;
			float d = 1f;
			this.ik.solver.leftHandEffector.positionOffset += (this.gunTarget.TransformPoint(position) - (this.ik.solver.leftHandEffector.bone.position + this.ik.solver.leftHandEffector.positionOffset)) * d;
			this.ik.solver.rightHandEffector.positionOffset += (this.gunTarget.TransformPoint(position2) - (this.ik.solver.rightHandEffector.bone.position + this.ik.solver.rightHandEffector.positionOffset)) * d;
			this.ik.solver.headMapping.maintainRotationWeight = 1f;
			if (this.recoil != null)
			{
				this.recoil.SetHandRotations(this.gunTarget.rotation * rhs, this.gunTarget.rotation * rhs2);
			}
			this.ik.solver.FANPFKHEDPA();
			if (this.recoil != null)
			{
				this.ik.references.leftHand.rotation = this.recoil.rotationOffset * (this.gunTarget.rotation * rhs);
				this.ik.references.rightHand.rotation = this.recoil.rotationOffset * (this.gunTarget.rotation * rhs2);
			}
			else
			{
				this.ik.references.leftHand.rotation = this.gunTarget.rotation * rhs;
				this.ik.references.rightHand.rotation = this.gunTarget.rotation * rhs2;
			}
			this.cam.transform.position = Vector3.Lerp(this.cam.transform.position, Vector3.Lerp(this.gunTarget.TransformPoint(this.IDOIJMKJEEG), this.gun.transform.TransformPoint(this.IDOIJMKJEEG), this.cameraRecoilWeight), t);
		}

		// Token: 0x0600DA53 RID: 55891 RVA: 0x0063FDA0 File Offset: 0x0063DFA0
		private void ANHOOJFEJJE()
		{
			this.OAJDJDKJJDI = this.gunTarget.localPosition;
			this.FFHJCMMCONN = this.gunTarget.localRotation;
			this.MKJLNKOLLOP = this.cam.transform.localPosition;
			this.cam.enabled = true;
			this.gunAim.enabled = true;
			this.ik.enabled = false;
			if (this.recoil != null && this.ik.solver.iterations == 0)
			{
				Debug.LogWarning("_TaaParams");
			}
		}

		// Token: 0x0600DA54 RID: 55892 RVA: 0x0063FE34 File Offset: 0x0063E034
		private void HKJHIANMOPG()
		{
			if (!this.animatePhysics)
			{
				this.GFCAOALODOF = true;
			}
			if (!this.GFCAOALODOF)
			{
				return;
			}
			this.GFCAOALODOF = false;
			this.cam.transform.localPosition = this.MKJLNKOLLOP;
			this.IDOIJMKJEEG = this.gunTarget.InverseTransformPoint(this.cam.transform.position);
			this.cam.DFNJNCCPKJF();
			this.CHDJOIACCMB();
			this.BGGJGLEFOGI();
			this.EGKBAFNEBKA();
		}

		// Token: 0x0600DA55 RID: 55893 RVA: 0x0063F62E File Offset: 0x0063D82E
		private void GPNKIPJNFNF()
		{
			this.GFCAOALODOF = false;
		}

		// Token: 0x0600DA56 RID: 55894 RVA: 0x0063FEB4 File Offset: 0x0063E0B4
		private void CPNOBMNKPNC()
		{
			this.OAJDJDKJJDI = this.gunTarget.localPosition;
			this.FFHJCMMCONN = this.gunTarget.localRotation;
			this.MKJLNKOLLOP = this.cam.transform.localPosition;
			this.cam.enabled = true;
			this.gunAim.enabled = true;
			this.ik.enabled = true;
			if (this.recoil != null && this.ik.solver.iterations == 0)
			{
				Debug.LogWarning("qualityLevel");
			}
		}

		// Token: 0x04001CEF RID: 7407
		[Range(0f, 1f)]
		public float aimWeight = 1f;

		// Token: 0x04001CF0 RID: 7408
		[Range(0f, 1f)]
		public float sightWeight = 1f;

		// Token: 0x04001CF1 RID: 7409
		[Range(0f, 180f)]
		public float maxAngle = 80f;

		// Token: 0x04001CF2 RID: 7410
		[SerializeField]
		private bool animatePhysics;

		// Token: 0x04001CF3 RID: 7411
		[SerializeField]
		private Transform gun;

		// Token: 0x04001CF4 RID: 7412
		[SerializeField]
		private Transform gunTarget;

		// Token: 0x04001CF5 RID: 7413
		[SerializeField]
		private FullBodyBipedIK ik;

		// Token: 0x04001CF6 RID: 7414
		[SerializeField]
		private AimIK gunAim;

		// Token: 0x04001CF7 RID: 7415
		[SerializeField]
		private CameraControllerFPS cam;

		// Token: 0x04001CF8 RID: 7416
		[SerializeField]
		private Recoil recoil;

		// Token: 0x04001CF9 RID: 7417
		[Range(0f, 1f)]
		[SerializeField]
		private float cameraRecoilWeight = 0.5f;

		// Token: 0x04001CFA RID: 7418
		private Vector3 OAJDJDKJJDI;

		// Token: 0x04001CFB RID: 7419
		private Quaternion FFHJCMMCONN;

		// Token: 0x04001CFC RID: 7420
		private Vector3 MKJLNKOLLOP;

		// Token: 0x04001CFD RID: 7421
		private Vector3 IDOIJMKJEEG;

		// Token: 0x04001CFE RID: 7422
		private bool GFCAOALODOF;
	}
}
