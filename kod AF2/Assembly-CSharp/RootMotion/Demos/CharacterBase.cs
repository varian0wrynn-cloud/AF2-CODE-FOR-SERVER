using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200042E RID: 1070
	[RequireComponent(typeof(CapsuleCollider))]
	[RequireComponent(typeof(Rigidbody))]
	public abstract class CharacterBase : MonoBehaviour
	{
		// Token: 0x0600E70A RID: 59146
		public abstract void Move(Vector3 JJGHJJONFIA, Quaternion MDAFOPGGGEM);

		// Token: 0x0600E70B RID: 59147 RVA: 0x0068D7B0 File Offset: 0x0068B9B0
		protected Vector3 ELMGJAAEJCM()
		{
			if (this.gravityTarget != null)
			{
				return (this.gravityTarget.position - base.transform.position).normalized * Physics.gravity.magnitude;
			}
			return Physics.gravity;
		}

		// Token: 0x0600E70C RID: 59148 RVA: 0x0068D808 File Offset: 0x0068BA08
		protected virtual void Start()
		{
			this.HJIJJCMLPDF = (base.GetComponent<Collider>() as CapsuleCollider);
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
			this.AMCMGBACOGC = this.HJIJJCMLPDF.height;
			this.PGHKFMIJCGL = this.HJIJJCMLPDF.center;
			this.INJPEAHFEJK = new PhysicMaterial();
			this.INJPEAHFEJK.dynamicFriction = 0f;
			this.INJPEAHFEJK.staticFriction = 0f;
			this.INJPEAHFEJK.frictionCombine = PhysicMaterialCombine.Minimum;
			this.INJPEAHFEJK.bounciness = 0f;
			this.INJPEAHFEJK.bounceCombine = PhysicMaterialCombine.Minimum;
			this.FGDPJFBGINP = new PhysicMaterial();
			this.AJMNDCHJPNK.constraints = RigidbodyConstraints.FreezeRotation;
		}

		// Token: 0x0600E70D RID: 59149 RVA: 0x0068D8C0 File Offset: 0x0068BAC0
		protected virtual RaycastHit PNELEAMKFFE()
		{
			Vector3 up = base.transform.up;
			Ray ray = new Ray(this.AJMNDCHJPNK.position + up * this.airborneThreshold, -up);
			RaycastHit result = default(RaycastHit);
			result.point = base.transform.position - base.transform.transform.up * this.airborneThreshold;
			result.normal = base.transform.up;
			Physics.SphereCast(ray, this.spherecastRadius, out result, this.airborneThreshold * 2f, this.groundLayers);
			return result;
		}

		// Token: 0x0600E70E RID: 59150 RVA: 0x0068D974 File Offset: 0x0068BB74
		public float GetAngleFromForward(Vector3 IJEJCGNPCED)
		{
			Vector3 vector = base.transform.InverseTransformDirection(IJEJCGNPCED);
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		// Token: 0x0600E70F RID: 59151 RVA: 0x0068D9A8 File Offset: 0x0068BBA8
		protected void GCKIGCJNBLJ(Vector3 JJNHJKFMFLJ, Vector3 HNANBJENIHC, float NEPBPMGGPKM)
		{
			Quaternion quaternion = Quaternion.AngleAxis(NEPBPMGGPKM, HNANBJENIHC);
			Vector3 point = base.transform.position - JJNHJKFMFLJ;
			this.AJMNDCHJPNK.MovePosition(JJNHJKFMFLJ + quaternion * point);
			this.AJMNDCHJPNK.MoveRotation(quaternion * base.transform.rotation);
		}

		// Token: 0x0600E710 RID: 59152 RVA: 0x0068DA04 File Offset: 0x0068BC04
		protected void BEAHCIFHCNP(float PIOGNAMGLNM)
		{
			if (this.HJIJJCMLPDF.height != this.AMCMGBACOGC * PIOGNAMGLNM)
			{
				this.HJIJJCMLPDF.height = Mathf.MoveTowards(this.HJIJJCMLPDF.height, this.AMCMGBACOGC * PIOGNAMGLNM, Time.deltaTime * 4f);
				this.HJIJJCMLPDF.center = Vector3.MoveTowards(this.HJIJJCMLPDF.center, this.PGHKFMIJCGL * PIOGNAMGLNM, Time.deltaTime * 2f);
			}
		}

		// Token: 0x0600E711 RID: 59153 RVA: 0x0068DA86 File Offset: 0x0068BC86
		protected void MKKPLGICIGC()
		{
			this.HJIJJCMLPDF.material = this.FGDPJFBGINP;
		}

		// Token: 0x0600E712 RID: 59154 RVA: 0x0068DA99 File Offset: 0x0068BC99
		protected void KOGHHDLBDCJ()
		{
			this.HJIJJCMLPDF.material = this.INJPEAHFEJK;
		}

		// Token: 0x0600E713 RID: 59155 RVA: 0x0068DAAC File Offset: 0x0068BCAC
		protected float AEHHJKHJFKK(Vector3 APOIOHJJDDC, Vector3 KFCHHHDAGKP)
		{
			float num = 90f - Vector3.Angle(APOIOHJJDDC, KFCHHHDAGKP);
			num -= this.slopeStartAngle;
			float num2 = this.slopeEndAngle - this.slopeStartAngle;
			return 1f - Mathf.Clamp(num / num2, 0f, 1f);
		}

		// Token: 0x04001E2A RID: 7722
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		// Token: 0x04001E2B RID: 7723
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		[SerializeField]
		protected float gravityMultiplier = 2f;

		// Token: 0x04001E2C RID: 7724
		[SerializeField]
		protected float airborneThreshold = 0.6f;

		// Token: 0x04001E2D RID: 7725
		[SerializeField]
		private float slopeStartAngle = 50f;

		// Token: 0x04001E2E RID: 7726
		[SerializeField]
		private float slopeEndAngle = 85f;

		// Token: 0x04001E2F RID: 7727
		[SerializeField]
		private float spherecastRadius = 0.1f;

		// Token: 0x04001E30 RID: 7728
		[SerializeField]
		private LayerMask groundLayers;

		// Token: 0x04001E31 RID: 7729
		private PhysicMaterial INJPEAHFEJK;

		// Token: 0x04001E32 RID: 7730
		private PhysicMaterial FGDPJFBGINP;

		// Token: 0x04001E33 RID: 7731
		protected Rigidbody AJMNDCHJPNK;

		// Token: 0x04001E34 RID: 7732
		protected const float JNFIMFNHHBG = 0.5f;

		// Token: 0x04001E35 RID: 7733
		protected float AMCMGBACOGC;

		// Token: 0x04001E36 RID: 7734
		protected Vector3 PGHKFMIJCGL;

		// Token: 0x04001E37 RID: 7735
		protected CapsuleCollider HJIJJCMLPDF;
	}
}
