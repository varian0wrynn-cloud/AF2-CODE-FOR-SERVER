using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200042B RID: 1067
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		// Token: 0x0600E6A7 RID: 59047 RVA: 0x00048599 File Offset: 0x00046799
		public virtual Vector3 GetPivotPoint()
		{
			return base.transform.position;
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x0600E6A8 RID: 59048 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		public virtual bool DEJEBGPIADO
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600E6A9 RID: 59049 RVA: 0x0068B3B4 File Offset: 0x006895B4
		public float GetAngleFromForward(Vector3 IJEJCGNPCED)
		{
			Vector3 vector = base.transform.InverseTransformDirection(IJEJCGNPCED);
			return Mathf.Atan2(vector.x, vector.z) * 57.29578f;
		}

		// Token: 0x0600E6AA RID: 59050 RVA: 0x0068B3E8 File Offset: 0x006895E8
		protected virtual void Start()
		{
			if (base.transform.parent.GetComponent<CharacterBase>() == null)
			{
				Debug.LogWarning("Animation controllers should be parented to character controllers!", base.transform);
			}
			this.IABMNPENOFE = base.transform.position;
			this.BACHFGBDKMM = base.transform.parent.InverseTransformPoint(base.transform.position);
			this.MHNMPOMNDBH = base.transform.rotation;
			this.JJCLNGDAJLC = Quaternion.Inverse(base.transform.parent.rotation) * base.transform.rotation;
		}

		// Token: 0x0600E6AB RID: 59051 RVA: 0x0068B48C File Offset: 0x0068968C
		protected virtual void LateUpdate()
		{
			if (this.smoothFollow)
			{
				base.transform.position = Vector3.Lerp(this.IABMNPENOFE, base.transform.parent.TransformPoint(this.BACHFGBDKMM), Time.deltaTime * this.smoothFollowSpeed);
				base.transform.rotation = Quaternion.Lerp(this.MHNMPOMNDBH, base.transform.parent.rotation * this.JJCLNGDAJLC, Time.deltaTime * this.smoothFollowSpeed);
			}
			this.IABMNPENOFE = base.transform.position;
			this.MHNMPOMNDBH = base.transform.rotation;
		}

		// Token: 0x04001E17 RID: 7703
		public bool smoothFollow = true;

		// Token: 0x04001E18 RID: 7704
		public float smoothFollowSpeed = 20f;

		// Token: 0x04001E19 RID: 7705
		private Vector3 IABMNPENOFE;

		// Token: 0x04001E1A RID: 7706
		private Vector3 BACHFGBDKMM;

		// Token: 0x04001E1B RID: 7707
		private Quaternion JJCLNGDAJLC;

		// Token: 0x04001E1C RID: 7708
		private Quaternion MHNMPOMNDBH;
	}
}
