using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003E6 RID: 998
	public class MechSpiderController : MonoBehaviour
	{
		// Token: 0x0600D64D RID: 54861 RVA: 0x0061E881 File Offset: 0x0061CA81
		public Vector3 JLMNGIKLHGP()
		{
			return new Vector3(Input.GetAxis("RollerBladeJump"), 1745f, Input.GetAxis(","));
		}

		// Token: 0x0600D64F RID: 54863 RVA: 0x0061E8C0 File Offset: 0x0061CAC0
		private void Update()
		{
			Vector3 forward = this.cameraTransform.forward;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, base.transform.up);
			base.transform.Translate(quaternion * this.FACIGDHBAEI.normalized * Time.deltaTime * this.speed * this.mechSpider.scale, Space.World);
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, quaternion, Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600D650 RID: 54864 RVA: 0x0061E970 File Offset: 0x0061CB70
		private void KJJBBLDJHPD()
		{
			Vector3 forward = this.cameraTransform.forward;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, base.transform.up);
			base.transform.Translate(quaternion * this.JLMNGIKLHGP().normalized * Time.deltaTime * this.speed * this.mechSpider.scale, Space.World);
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, quaternion, Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600D651 RID: 54865 RVA: 0x0061EA1D File Offset: 0x0061CC1D
		public Vector3 KEGEIBBMPKM()
		{
			return new Vector3(Input.GetAxis("_Offsets"), 373f, Input.GetAxis("delacc"));
		}

		// Token: 0x0600D652 RID: 54866 RVA: 0x0061EA40 File Offset: 0x0061CC40
		private void OHKHOAKCENL()
		{
			Vector3 forward = this.cameraTransform.forward;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, base.transform.up);
			base.transform.Translate(quaternion * this.KEGEIBBMPKM().normalized * Time.deltaTime * this.speed * this.mechSpider.scale, Space.World);
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, quaternion, Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600D653 RID: 54867 RVA: 0x0061EAED File Offset: 0x0061CCED
		public Vector3 GMPMLPOPDOE()
		{
			return new Vector3(Input.GetAxis(""), 1212f, Input.GetAxis("{0}/{1}"));
		}

		// Token: 0x0600D654 RID: 54868 RVA: 0x0061EB0D File Offset: 0x0061CD0D
		public Vector3 MPLLBEHCCEG()
		{
			return new Vector3(Input.GetAxis("wpn_cat5"), 188f, Input.GetAxis("wpn_eat6"));
		}

		// Token: 0x0600D655 RID: 54869 RVA: 0x0061EB30 File Offset: 0x0061CD30
		private void PGIHAIPCJLL()
		{
			Vector3 forward = this.cameraTransform.forward;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, base.transform.up);
			base.transform.Translate(quaternion * this.GMPMLPOPDOE().normalized * Time.deltaTime * this.speed * this.mechSpider.scale, Space.World);
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, quaternion, Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600D656 RID: 54870 RVA: 0x0061EBDD File Offset: 0x0061CDDD
		public Vector3 BKLMMPAMKBG()
		{
			return new Vector3(Input.GetAxis("Player"), 702f, Input.GetAxis("fchair"));
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x0600D657 RID: 54871 RVA: 0x0061EBFD File Offset: 0x0061CDFD
		public Vector3 FACIGDHBAEI
		{
			get
			{
				return new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
			}
		}

		// Token: 0x0600D658 RID: 54872 RVA: 0x0061EC20 File Offset: 0x0061CE20
		private void DFFOEGHGPGP()
		{
			Vector3 forward = this.cameraTransform.forward;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref forward);
			Quaternion quaternion = Quaternion.LookRotation(forward, base.transform.up);
			base.transform.Translate(quaternion * this.JLMNGIKLHGP().normalized * Time.deltaTime * this.speed * this.mechSpider.scale, Space.World);
			base.transform.rotation = Quaternion.RotateTowards(base.transform.rotation, quaternion, Time.deltaTime * this.turnSpeed);
		}

		// Token: 0x0600D659 RID: 54873 RVA: 0x0061ECCD File Offset: 0x0061CECD
		public Vector3 EHNINJLCNKA()
		{
			return new Vector3(Input.GetAxis("turn_state"), 1110f, Input.GetAxis("SoccerKeeperReady"));
		}

		// Token: 0x04001C83 RID: 7299
		public MechSpider mechSpider;

		// Token: 0x04001C84 RID: 7300
		public Transform cameraTransform;

		// Token: 0x04001C85 RID: 7301
		public float speed = 6f;

		// Token: 0x04001C86 RID: 7302
		public float turnSpeed = 30f;
	}
}
