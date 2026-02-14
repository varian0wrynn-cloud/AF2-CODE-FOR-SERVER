using System;
using UnityEngine;

namespace UnityStandardAssets.Cameras
{
	// Token: 0x020003A9 RID: 937
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		// Token: 0x0600CB0B RID: 51979 RVA: 0x005ACA3F File Offset: 0x005AAC3F
		protected virtual void Start()
		{
			if (this.m_AutoTargetPlayer)
			{
				this.FindAndTargetPlayer();
			}
			if (this.m_Target == null)
			{
				return;
			}
			this.FOJMMNLBFDK = this.m_Target.GetComponent<Rigidbody>();
		}

		// Token: 0x0600CB0C RID: 51980 RVA: 0x005ACA70 File Offset: 0x005AAC70
		private void FixedUpdate()
		{
			if (this.m_AutoTargetPlayer && (this.m_Target == null || !this.m_Target.gameObject.activeSelf))
			{
				this.FindAndTargetPlayer();
			}
			if (this.m_UpdateType == AbstractTargetFollower.OODENAMJHCM.FixedUpdate)
			{
				this.IJLMPHHOJIH(Time.deltaTime);
			}
		}

		// Token: 0x0600CB0D RID: 51981 RVA: 0x005ACAC0 File Offset: 0x005AACC0
		private void LateUpdate()
		{
			if (this.m_AutoTargetPlayer && (this.m_Target == null || !this.m_Target.gameObject.activeSelf))
			{
				this.FindAndTargetPlayer();
			}
			if (this.m_UpdateType == AbstractTargetFollower.OODENAMJHCM.LateUpdate)
			{
				this.IJLMPHHOJIH(Time.deltaTime);
			}
		}

		// Token: 0x0600CB0E RID: 51982 RVA: 0x005ACB10 File Offset: 0x005AAD10
		public void ManualUpdate()
		{
			if (this.m_AutoTargetPlayer && (this.m_Target == null || !this.m_Target.gameObject.activeSelf))
			{
				this.FindAndTargetPlayer();
			}
			if (this.m_UpdateType == AbstractTargetFollower.OODENAMJHCM.ManualUpdate)
			{
				this.IJLMPHHOJIH(Time.deltaTime);
			}
		}

		// Token: 0x0600CB0F RID: 51983
		protected abstract void IJLMPHHOJIH(float ENLHBNBNPJN);

		// Token: 0x0600CB10 RID: 51984 RVA: 0x005ACB60 File Offset: 0x005AAD60
		public void FindAndTargetPlayer()
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
			if (gameObject)
			{
				this.SetTarget(gameObject.transform);
			}
		}

		// Token: 0x0600CB11 RID: 51985 RVA: 0x005ACB8C File Offset: 0x005AAD8C
		public virtual void SetTarget(Transform BDDKPGKJACO)
		{
			this.m_Target = BDDKPGKJACO;
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600CB12 RID: 51986 RVA: 0x005ACB95 File Offset: 0x005AAD95
		public Transform HHCIFHIPEAC
		{
			get
			{
				return this.m_Target;
			}
		}

		// Token: 0x04001AEB RID: 6891
		[SerializeField]
		protected Transform m_Target;

		// Token: 0x04001AEC RID: 6892
		[SerializeField]
		private bool m_AutoTargetPlayer = true;

		// Token: 0x04001AED RID: 6893
		[SerializeField]
		private AbstractTargetFollower.OODENAMJHCM m_UpdateType;

		// Token: 0x04001AEE RID: 6894
		protected Rigidbody FOJMMNLBFDK;

		// Token: 0x020003AA RID: 938
		public enum OODENAMJHCM
		{
			// Token: 0x04001AF0 RID: 6896
			FixedUpdate,
			// Token: 0x04001AF1 RID: 6897
			LateUpdate,
			// Token: 0x04001AF2 RID: 6898
			ManualUpdate
		}
	}
}
