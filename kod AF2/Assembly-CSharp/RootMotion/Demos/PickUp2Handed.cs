using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000408 RID: 1032
	public abstract class PickUp2Handed : MonoBehaviour
	{
		// Token: 0x0600DD94 RID: 56724 RVA: 0x0065A7D8 File Offset: 0x006589D8
		private void OnGUI()
		{
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
			GUILayout.Space((float)this.GUIspace);
			if (!this.DKOJKFIDKGJ)
			{
				if (GUILayout.Button("Pick Up " + this.obj.name, Array.Empty<GUILayoutOption>()))
				{
					this.interactionSystem.StartInteraction(FullBodyBipedEffector.LeftHand, this.obj, false);
					this.interactionSystem.StartInteraction(FullBodyBipedEffector.RightHand, this.obj, false);
				}
			}
			else if (GUILayout.Button("Drop " + this.obj.name, Array.Empty<GUILayoutOption>()))
			{
				this.interactionSystem.ResumeAll();
			}
			GUILayout.EndHorizontal();
		}

		// Token: 0x0600DD95 RID: 56725
		protected abstract void NPOEABEHPJD();

		// Token: 0x0600DD96 RID: 56726 RVA: 0x0065A880 File Offset: 0x00658A80
		private void Start()
		{
			InteractionSystem interactionSystem = this.interactionSystem;
			interactionSystem.OnInteractionStart = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(interactionSystem.OnInteractionStart, new InteractionSystem.FOKJDOCGHHO(this.CGKHMKMMBNG));
			InteractionSystem interactionSystem2 = this.interactionSystem;
			interactionSystem2.OnInteractionPause = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(interactionSystem2.OnInteractionPause, new InteractionSystem.FOKJDOCGHHO(this.JMDPJNHHPHL));
			InteractionSystem interactionSystem3 = this.interactionSystem;
			interactionSystem3.OnInteractionResume = (InteractionSystem.FOKJDOCGHHO)Delegate.Combine(interactionSystem3.OnInteractionResume, new InteractionSystem.FOKJDOCGHHO(this.MHIHPNPDLAE));
		}

		// Token: 0x0600DD97 RID: 56727 RVA: 0x0065A904 File Offset: 0x00658B04
		private void JMDPJNHHPHL(FullBodyBipedEffector LPOHBKJJIBO, InteractionObject AILKAAAEFOA)
		{
			if (LPOHBKJJIBO != FullBodyBipedEffector.LeftHand)
			{
				return;
			}
			if (AILKAAAEFOA != this.obj)
			{
				return;
			}
			this.obj.transform.parent = this.interactionSystem.transform;
			Rigidbody component = this.obj.GetComponent<Rigidbody>();
			if (component != null)
			{
				component.isKinematic = true;
			}
			this.JBDMEDLPDKB = this.obj.transform.position;
			this.ONCNOLIEMOI = this.obj.transform.rotation;
			this.HIPEOMJLHKO = 0f;
			this.NCFFHBOFPHI = 0f;
		}

		// Token: 0x0600DD98 RID: 56728 RVA: 0x0065A99E File Offset: 0x00658B9E
		private void CGKHMKMMBNG(FullBodyBipedEffector LPOHBKJJIBO, InteractionObject AILKAAAEFOA)
		{
			if (LPOHBKJJIBO != FullBodyBipedEffector.LeftHand)
			{
				return;
			}
			if (AILKAAAEFOA != this.obj)
			{
				return;
			}
			this.NPOEABEHPJD();
			this.holdPoint.rotation = this.obj.transform.rotation;
		}

		// Token: 0x0600DD99 RID: 56729 RVA: 0x0065A9D8 File Offset: 0x00658BD8
		private void MHIHPNPDLAE(FullBodyBipedEffector LPOHBKJJIBO, InteractionObject AILKAAAEFOA)
		{
			if (LPOHBKJJIBO != FullBodyBipedEffector.LeftHand)
			{
				return;
			}
			if (AILKAAAEFOA != this.obj)
			{
				return;
			}
			this.obj.transform.parent = null;
			if (this.obj.GetComponent<Rigidbody>() != null)
			{
				this.obj.GetComponent<Rigidbody>().isKinematic = false;
			}
		}

		// Token: 0x0600DD9A RID: 56730 RVA: 0x0065AA30 File Offset: 0x00658C30
		private void LateUpdate()
		{
			if (this.DKOJKFIDKGJ)
			{
				this.HIPEOMJLHKO = Mathf.SmoothDamp(this.HIPEOMJLHKO, 1f, ref this.NCFFHBOFPHI, this.pickUpTime);
				this.obj.transform.position = Vector3.Lerp(this.JBDMEDLPDKB, this.holdPoint.position, this.HIPEOMJLHKO);
				this.obj.transform.rotation = Quaternion.Lerp(this.ONCNOLIEMOI, this.holdPoint.rotation, this.HIPEOMJLHKO);
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x0600DD9B RID: 56731 RVA: 0x0065AABF File Offset: 0x00658CBF
		private bool DKOJKFIDKGJ
		{
			get
			{
				return this.interactionSystem.IsPaused(FullBodyBipedEffector.LeftHand);
			}
		}

		// Token: 0x0600DD9C RID: 56732 RVA: 0x0065AAD0 File Offset: 0x00658CD0
		private void OnDestroy()
		{
			if (this.interactionSystem == null)
			{
				return;
			}
			InteractionSystem interactionSystem = this.interactionSystem;
			interactionSystem.OnInteractionStart = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(interactionSystem.OnInteractionStart, new InteractionSystem.FOKJDOCGHHO(this.CGKHMKMMBNG));
			InteractionSystem interactionSystem2 = this.interactionSystem;
			interactionSystem2.OnInteractionPause = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(interactionSystem2.OnInteractionPause, new InteractionSystem.FOKJDOCGHHO(this.JMDPJNHHPHL));
			InteractionSystem interactionSystem3 = this.interactionSystem;
			interactionSystem3.OnInteractionResume = (InteractionSystem.FOKJDOCGHHO)Delegate.Remove(interactionSystem3.OnInteractionResume, new InteractionSystem.FOKJDOCGHHO(this.MHIHPNPDLAE));
		}

		// Token: 0x04001D54 RID: 7508
		[SerializeField]
		private int GUIspace;

		// Token: 0x04001D55 RID: 7509
		public InteractionSystem interactionSystem;

		// Token: 0x04001D56 RID: 7510
		public InteractionObject obj;

		// Token: 0x04001D57 RID: 7511
		public Transform pivot;

		// Token: 0x04001D58 RID: 7512
		public Transform holdPoint;

		// Token: 0x04001D59 RID: 7513
		public float pickUpTime = 0.3f;

		// Token: 0x04001D5A RID: 7514
		private float HIPEOMJLHKO;

		// Token: 0x04001D5B RID: 7515
		private float NCFFHBOFPHI;

		// Token: 0x04001D5C RID: 7516
		private Vector3 JBDMEDLPDKB;

		// Token: 0x04001D5D RID: 7517
		private Quaternion ONCNOLIEMOI;
	}
}
