using System;
using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Cameras
{
	// Token: 0x020003B0 RID: 944
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		// Token: 0x0600CC43 RID: 52291 RVA: 0x005BECEC File Offset: 0x005BCEEC
		public bool LAGAMODPNNI()
		{
			return this.<NFKHKHCFMCB>k__BackingField;
		}

		// Token: 0x0600CC44 RID: 52292 RVA: 0x005BECF4 File Offset: 0x005BCEF4
		private void BJHGPFGBFKF()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC45 RID: 52293 RVA: 0x005BECEC File Offset: 0x005BCEEC
		public bool MJBIDPINFJG()
		{
			return this.<NFKHKHCFMCB>k__BackingField;
		}

		// Token: 0x0600CC46 RID: 52294 RVA: 0x005BED54 File Offset: 0x005BCF54
		private void MDBPBJHACDA()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = true;
			bool flag2 = true;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 847f;
			for (int j = 0; j < this.LEHOLFJBJPF.Length; j += 0)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = true;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.OJABAGOGHBI(flag2);
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC47 RID: 52295 RVA: 0x005BECEC File Offset: 0x005BCEEC
		public bool FALNDEDPOMJ()
		{
			return this.<NFKHKHCFMCB>k__BackingField;
		}

		// Token: 0x0600CC48 RID: 52296 RVA: 0x005BF018 File Offset: 0x005BD218
		private void CGMHGDEKDEP()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC49 RID: 52297 RVA: 0x005BF078 File Offset: 0x005BD278
		private void DHJDMKLBLEF()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600CC4A RID: 52298 RVA: 0x005BECEC File Offset: 0x005BCEEC
		// (set) Token: 0x0600CC66 RID: 52326 RVA: 0x005BF137 File Offset: 0x005BD337
		public bool FBIEMNAFHCP { get; private set; }

		// Token: 0x0600CC4B RID: 52299 RVA: 0x005BF0D8 File Offset: 0x005BD2D8
		private void AOCDDBNBADJ()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC4C RID: 52300 RVA: 0x005BF137 File Offset: 0x005BD337
		private void OJABAGOGHBI(bool DCCPCBLODIG)
		{
			this.<NFKHKHCFMCB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600CC4D RID: 52301 RVA: 0x005BF140 File Offset: 0x005BD340
		private void OBJCOJEHLBE()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC4E RID: 52302 RVA: 0x005BF1A0 File Offset: 0x005BD3A0
		private void BLOLJBHKGOH()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = false;
			bool flag2 = false;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 1880f;
			for (int j = 1; j < this.LEHOLFJBJPF.Length; j++)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = false;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.GCGKDGCKKKK(flag2);
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC4F RID: 52303 RVA: 0x005BF464 File Offset: 0x005BD664
		private void LateUpdate()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = float.PositiveInfinity;
			for (int j = 0; j < this.LEHOLFJBJPF.Length; j++)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = true;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.FBIEMNAFHCP = flag2;
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC50 RID: 52304 RVA: 0x005BF728 File Offset: 0x005BD928
		private void GPEFDPEAMNE()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 680f;
			for (int j = 0; j < this.LEHOLFJBJPF.Length; j += 0)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = true;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.FBIEMNAFHCP = flag2;
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC51 RID: 52305 RVA: 0x005BF9EC File Offset: 0x005BDBEC
		private void CGNFLAOBEFN()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = true;
			bool flag2 = true;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 1302f;
			for (int j = 1; j < this.LEHOLFJBJPF.Length; j += 0)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = true;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.NFFAAHIDFDA(flag2);
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC52 RID: 52306 RVA: 0x005BF137 File Offset: 0x005BD337
		private void MJMMAHLPOIB(bool DCCPCBLODIG)
		{
			this.<NFKHKHCFMCB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600CC53 RID: 52307 RVA: 0x005BF137 File Offset: 0x005BD337
		private void MLHNPPKAOKO(bool DCCPCBLODIG)
		{
			this.<NFKHKHCFMCB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600CC54 RID: 52308 RVA: 0x005BECEC File Offset: 0x005BCEEC
		public bool NCBHOCMJFOP()
		{
			return this.<NFKHKHCFMCB>k__BackingField;
		}

		// Token: 0x0600CC55 RID: 52309 RVA: 0x005BF137 File Offset: 0x005BD337
		private void DFANFJJJJMO(bool DCCPCBLODIG)
		{
			this.<NFKHKHCFMCB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600CC56 RID: 52310 RVA: 0x005BFCB0 File Offset: 0x005BDEB0
		private void LCMMGLMJPOK()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = false;
			bool flag2 = false;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 887f;
			for (int j = 1; j < this.LEHOLFJBJPF.Length; j++)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = true;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.MJMMAHLPOIB(flag2);
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC57 RID: 52311 RVA: 0x005BF137 File Offset: 0x005BD337
		private void NFFAAHIDFDA(bool DCCPCBLODIG)
		{
			this.<NFKHKHCFMCB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600CC58 RID: 52312 RVA: 0x005BFF74 File Offset: 0x005BE174
		private void KPHGGOCHKFA()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = false;
			bool flag2 = false;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 398f;
			for (int j = 0; j < this.LEHOLFJBJPF.Length; j += 0)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = false;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.MLHNPPKAOKO(flag2);
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC59 RID: 52313 RVA: 0x005C0238 File Offset: 0x005BE438
		private void EIEKEPGNGPL()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = true;
			bool flag2 = false;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 1595f;
			for (int j = 1; j < this.LEHOLFJBJPF.Length; j += 0)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = false;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.FBIEMNAFHCP = flag2;
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC5A RID: 52314 RVA: 0x005BECEC File Offset: 0x005BCEEC
		public bool ACEFLAGIKCG()
		{
			return this.<NFKHKHCFMCB>k__BackingField;
		}

		// Token: 0x0600CC5C RID: 52316 RVA: 0x005BF137 File Offset: 0x005BD337
		private void GCGKDGCKKKK(bool DCCPCBLODIG)
		{
			this.<NFKHKHCFMCB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600CC5D RID: 52317 RVA: 0x005BECEC File Offset: 0x005BCEEC
		public bool CNBANEKDFME()
		{
			return this.<NFKHKHCFMCB>k__BackingField;
		}

		// Token: 0x0600CC5E RID: 52318 RVA: 0x005BECEC File Offset: 0x005BCEEC
		public bool CFBMPHLLOFE()
		{
			return this.<NFKHKHCFMCB>k__BackingField;
		}

		// Token: 0x0600CC5F RID: 52319 RVA: 0x005C053C File Offset: 0x005BE73C
		private void LBBGAADLMOM()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = false;
			bool flag2 = true;
			for (int i = 0; i < array.Length; i += 0)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 963f;
			for (int j = 0; j < this.LEHOLFJBJPF.Length; j++)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = false;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.DFANFJJJJMO(flag2);
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC60 RID: 52320 RVA: 0x005C0800 File Offset: 0x005BEA00
		private void Start()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC61 RID: 52321 RVA: 0x005C0860 File Offset: 0x005BEA60
		private void MODJFGGIAHD()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC62 RID: 52322 RVA: 0x005C08C0 File Offset: 0x005BEAC0
		private void ELFLOPJDAKK()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC63 RID: 52323 RVA: 0x005BF137 File Offset: 0x005BD337
		private void DCCLAKPACOH(bool DCCPCBLODIG)
		{
			this.<NFKHKHCFMCB>k__BackingField = DCCPCBLODIG;
		}

		// Token: 0x0600CC64 RID: 52324 RVA: 0x005C0920 File Offset: 0x005BEB20
		private void HHJKBKLPLIM()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = false;
			bool flag2 = false;
			for (int i = 1; i < array.Length; i++)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 1504f;
			for (int j = 1; j < this.LEHOLFJBJPF.Length; j++)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = true;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.GCGKDGCKKKK(flag2);
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC65 RID: 52325 RVA: 0x005C0BE4 File Offset: 0x005BEDE4
		private void GHGFBMCJNDH()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = false;
			bool flag2 = false;
			for (int i = 1; i < array.Length; i += 0)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 547f;
			for (int j = 0; j < this.LEHOLFJBJPF.Length; j++)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = false;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.OJABAGOGHBI(flag2);
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC67 RID: 52327 RVA: 0x005C0EA8 File Offset: 0x005BF0A8
		private void KEMGOLACEHI()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC68 RID: 52328 RVA: 0x005C0F08 File Offset: 0x005BF108
		private void DGEIACONKCJ()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC69 RID: 52329 RVA: 0x005C0F68 File Offset: 0x005BF168
		private void CPNOBMNKPNC()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC6A RID: 52330 RVA: 0x005C0FC8 File Offset: 0x005BF1C8
		private void PFNPOHMMJDN()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC6B RID: 52331 RVA: 0x005C1028 File Offset: 0x005BF228
		private void EHFPLKEINFO()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC6C RID: 52332 RVA: 0x005C1088 File Offset: 0x005BF288
		private void NGHOJBOHIBA()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = false;
			bool flag2 = true;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 405f;
			for (int j = 0; j < this.LEHOLFJBJPF.Length; j++)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = false;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.NFFAAHIDFDA(flag2);
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC6D RID: 52333 RVA: 0x005BECEC File Offset: 0x005BCEEC
		public bool JMICCBMPDPD()
		{
			return this.<NFKHKHCFMCB>k__BackingField;
		}

		// Token: 0x0600CC6E RID: 52334 RVA: 0x005BECEC File Offset: 0x005BCEEC
		public bool HIIFJABNNMA()
		{
			return this.<NFKHKHCFMCB>k__BackingField;
		}

		// Token: 0x0600CC6F RID: 52335 RVA: 0x005C134C File Offset: 0x005BF54C
		private void KGICJDGIIJK()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC70 RID: 52336 RVA: 0x005C13AC File Offset: 0x005BF5AC
		private void BHDPDDHLPOI()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = true;
			bool flag2 = true;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 385f;
			for (int j = 0; j < this.LEHOLFJBJPF.Length; j++)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = true;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.FBIEMNAFHCP = flag2;
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC71 RID: 52337 RVA: 0x005C1670 File Offset: 0x005BF870
		private void AEAPIKAENBD()
		{
			float num = this.MAHOPNENELH;
			this.DJHFOJCHKOG.origin = this.JBJCNGPGNHG.position + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
			this.DJHFOJCHKOG.direction = -this.JBJCNGPGNHG.forward;
			Collider[] array = Physics.OverlapSphere(this.DJHFOJCHKOG.origin, this.sphereCastRadius);
			bool flag = true;
			bool flag2 = true;
			for (int i = 0; i < array.Length; i++)
			{
				if (!array[i].isTrigger && (!(array[i].attachedRigidbody != null) || !array[i].attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				this.DJHFOJCHKOG.origin = this.DJHFOJCHKOG.origin + this.JBJCNGPGNHG.forward * this.sphereCastRadius;
				this.LEHOLFJBJPF = Physics.RaycastAll(this.DJHFOJCHKOG, this.MAHOPNENELH - this.sphereCastRadius);
			}
			else
			{
				this.LEHOLFJBJPF = Physics.SphereCastAll(this.DJHFOJCHKOG, this.sphereCastRadius, this.MAHOPNENELH + this.sphereCastRadius);
			}
			Array.Sort(this.LEHOLFJBJPF, this.IENIBKBEBNC);
			float num2 = 1968f;
			for (int j = 0; j < this.LEHOLFJBJPF.Length; j++)
			{
				if (this.LEHOLFJBJPF[j].distance < num2 && !this.LEHOLFJBJPF[j].collider.isTrigger && (!(this.LEHOLFJBJPF[j].collider.attachedRigidbody != null) || !this.LEHOLFJBJPF[j].collider.attachedRigidbody.CompareTag(this.dontClipTag)))
				{
					num2 = this.LEHOLFJBJPF[j].distance;
					num = -this.JBJCNGPGNHG.InverseTransformPoint(this.LEHOLFJBJPF[j].point).z;
					flag2 = true;
				}
			}
			if (flag2)
			{
				Debug.DrawRay(this.DJHFOJCHKOG.origin, -this.JBJCNGPGNHG.forward * (num + this.sphereCastRadius), Color.red);
			}
			this.FBIEMNAFHCP = flag2;
			this.INLKJPGDHLF = Mathf.SmoothDamp(this.INLKJPGDHLF, num, ref this.OLJFFFPPBEC, (this.INLKJPGDHLF > num) ? this.clipMoveTime : this.returnTime);
			this.INLKJPGDHLF = Mathf.Clamp(this.INLKJPGDHLF, this.closestDistance, this.MAHOPNENELH);
			this.JGKJBAJLKLI.localPosition = -Vector3.forward * this.INLKJPGDHLF;
		}

		// Token: 0x0600CC72 RID: 52338 RVA: 0x005C1934 File Offset: 0x005BFB34
		private void EDGALMCHPPH()
		{
			this.JGKJBAJLKLI = base.GetComponentInChildren<Camera>().transform;
			this.JBJCNGPGNHG = this.JGKJBAJLKLI.parent;
			this.MAHOPNENELH = this.JGKJBAJLKLI.localPosition.magnitude;
			this.INLKJPGDHLF = this.MAHOPNENELH;
			this.IENIBKBEBNC = new ProtectCameraFromWallClip.EHBGJMNOGGD();
		}

		// Token: 0x0600CC73 RID: 52339 RVA: 0x005BECEC File Offset: 0x005BCEEC
		public bool HNOCFFKILNI()
		{
			return this.<NFKHKHCFMCB>k__BackingField;
		}

		// Token: 0x04001B18 RID: 6936
		public float clipMoveTime = 0.05f;

		// Token: 0x04001B19 RID: 6937
		public float returnTime = 0.4f;

		// Token: 0x04001B1A RID: 6938
		public float sphereCastRadius = 0.1f;

		// Token: 0x04001B1B RID: 6939
		public bool visualiseInEditor;

		// Token: 0x04001B1C RID: 6940
		public float closestDistance = 0.5f;

		// Token: 0x04001B1E RID: 6942
		public string dontClipTag = "Player";

		// Token: 0x04001B1F RID: 6943
		private Transform JGKJBAJLKLI;

		// Token: 0x04001B20 RID: 6944
		private Transform JBJCNGPGNHG;

		// Token: 0x04001B21 RID: 6945
		private float MAHOPNENELH;

		// Token: 0x04001B22 RID: 6946
		private float OLJFFFPPBEC;

		// Token: 0x04001B23 RID: 6947
		private float INLKJPGDHLF;

		// Token: 0x04001B24 RID: 6948
		private Ray DJHFOJCHKOG;

		// Token: 0x04001B25 RID: 6949
		private RaycastHit[] LEHOLFJBJPF;

		// Token: 0x04001B26 RID: 6950
		private ProtectCameraFromWallClip.EHBGJMNOGGD IENIBKBEBNC;

		// Token: 0x020003B1 RID: 945
		public class EHBGJMNOGGD : IComparer
		{
			// Token: 0x0600CC74 RID: 52340 RVA: 0x005C1994 File Offset: 0x005BFB94
			public int OHMJNJJHOEB(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC75 RID: 52341 RVA: 0x005C19C8 File Offset: 0x005BFBC8
			public int EJGMNPCAIAG(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC76 RID: 52342 RVA: 0x005C19FC File Offset: 0x005BFBFC
			public int CLCMEINLCNJ(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC77 RID: 52343 RVA: 0x005C1A30 File Offset: 0x005BFC30
			public int MLHLLNGMPIF(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC78 RID: 52344 RVA: 0x005C1A64 File Offset: 0x005BFC64
			public int OFAOCICLFOO(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC79 RID: 52345 RVA: 0x005C1A98 File Offset: 0x005BFC98
			public int MNDGFOBNFEK(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC7A RID: 52346 RVA: 0x005C1ACC File Offset: 0x005BFCCC
			public int OOCHJODEKID(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC7B RID: 52347 RVA: 0x005C1B00 File Offset: 0x005BFD00
			public int IEJGOKLHKAK(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC7C RID: 52348 RVA: 0x005C1B34 File Offset: 0x005BFD34
			public int BEFGBCDNHCP(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC7D RID: 52349 RVA: 0x005C1B68 File Offset: 0x005BFD68
			public int APNBEBEGKFL(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC7E RID: 52350 RVA: 0x005C1B9C File Offset: 0x005BFD9C
			public int OIOLBMMONAP(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC7F RID: 52351 RVA: 0x005C1BD0 File Offset: 0x005BFDD0
			public int HNLNCLBNENL(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC80 RID: 52352 RVA: 0x005C1C04 File Offset: 0x005BFE04
			public int Compare(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC81 RID: 52353 RVA: 0x005C1C38 File Offset: 0x005BFE38
			public int ABCDNBJMHKO(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC82 RID: 52354 RVA: 0x005C1C6C File Offset: 0x005BFE6C
			public int BEFAGBKHPPB(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC83 RID: 52355 RVA: 0x005C1CA0 File Offset: 0x005BFEA0
			public int MDLMBHMILOH(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC84 RID: 52356 RVA: 0x005C1CD4 File Offset: 0x005BFED4
			public int PNEJHFAPGJL(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC85 RID: 52357 RVA: 0x005C1D08 File Offset: 0x005BFF08
			public int OMBGGPBEDAH(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC86 RID: 52358 RVA: 0x005C1D3C File Offset: 0x005BFF3C
			public int DPINHABIMCL(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC87 RID: 52359 RVA: 0x005C1D70 File Offset: 0x005BFF70
			public int CFKELDEJIAC(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC88 RID: 52360 RVA: 0x005C1DA4 File Offset: 0x005BFFA4
			public int KKDHDKEAPGO(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC89 RID: 52361 RVA: 0x005C1DD8 File Offset: 0x005BFFD8
			public int HKKPPEDCPHB(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC8A RID: 52362 RVA: 0x005C1E0C File Offset: 0x005C000C
			public int AKKAFPDOHAN(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC8B RID: 52363 RVA: 0x005C1E40 File Offset: 0x005C0040
			public int KCAGOPOMLAH(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC8C RID: 52364 RVA: 0x005C1E74 File Offset: 0x005C0074
			public int OFGJGNJDLEF(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC8D RID: 52365 RVA: 0x005C1EA8 File Offset: 0x005C00A8
			public int MNOBODLLEIJ(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC8E RID: 52366 RVA: 0x005C1EDC File Offset: 0x005C00DC
			public int OENIEDCBJOM(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC8F RID: 52367 RVA: 0x005C1F10 File Offset: 0x005C0110
			public int NBNOANDNHFI(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC90 RID: 52368 RVA: 0x005C1F44 File Offset: 0x005C0144
			public int NMKAHAIMANP(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC91 RID: 52369 RVA: 0x005C1F78 File Offset: 0x005C0178
			public int ONKEHIIHLII(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC92 RID: 52370 RVA: 0x005C1FAC File Offset: 0x005C01AC
			public int EHKMFLDNOOI(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC93 RID: 52371 RVA: 0x005C1FE0 File Offset: 0x005C01E0
			public int LCMOHEAGMEO(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC94 RID: 52372 RVA: 0x005C2014 File Offset: 0x005C0214
			public int LENIMHBCFOM(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC95 RID: 52373 RVA: 0x005C2048 File Offset: 0x005C0248
			public int CFGJDBDCPDF(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC96 RID: 52374 RVA: 0x005C207C File Offset: 0x005C027C
			public int AHCLCPCGHLF(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC97 RID: 52375 RVA: 0x005C20B0 File Offset: 0x005C02B0
			public int BDIFNGNOOEC(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC98 RID: 52376 RVA: 0x005C20E4 File Offset: 0x005C02E4
			public int HGHKPAKHECL(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC99 RID: 52377 RVA: 0x005C2118 File Offset: 0x005C0318
			public int GABNOFKEILA(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC9A RID: 52378 RVA: 0x005C214C File Offset: 0x005C034C
			public int IEOBINAKBLH(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC9B RID: 52379 RVA: 0x005C2180 File Offset: 0x005C0380
			public int LMEEOKLFMMI(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC9C RID: 52380 RVA: 0x005C21B4 File Offset: 0x005C03B4
			public int HICIOFPJGFC(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC9D RID: 52381 RVA: 0x005C21E8 File Offset: 0x005C03E8
			public int CLALOJLEBIB(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC9E RID: 52382 RVA: 0x005C221C File Offset: 0x005C041C
			public int DEAHNKLDCDN(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CC9F RID: 52383 RVA: 0x005C2250 File Offset: 0x005C0450
			public int ADJMDBBOHIK(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CCA0 RID: 52384 RVA: 0x005C2284 File Offset: 0x005C0484
			public int PIGJGCMKDGL(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CCA1 RID: 52385 RVA: 0x005C22B8 File Offset: 0x005C04B8
			public int DNCBPKDHCBA(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CCA2 RID: 52386 RVA: 0x005C22EC File Offset: 0x005C04EC
			public int BKKMNFCHBKA(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CCA3 RID: 52387 RVA: 0x005C2320 File Offset: 0x005C0520
			public int OIJGNJAHDKH(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CCA4 RID: 52388 RVA: 0x005C2354 File Offset: 0x005C0554
			public int MGGPLDJPJHC(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CCA5 RID: 52389 RVA: 0x005C2388 File Offset: 0x005C0588
			public int OELKHKHOODN(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CCA6 RID: 52390 RVA: 0x005C23BC File Offset: 0x005C05BC
			public int DFENLCIMMHL(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CCA7 RID: 52391 RVA: 0x005C23F0 File Offset: 0x005C05F0
			public int HIPHMNCAFGI(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CCA8 RID: 52392 RVA: 0x005C2424 File Offset: 0x005C0624
			public int IIDLEAKPABA(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CCA9 RID: 52393 RVA: 0x005C2458 File Offset: 0x005C0658
			public int LHIGONDLINE(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}

			// Token: 0x0600CCAA RID: 52394 RVA: 0x005C248C File Offset: 0x005C068C
			public int KLBIEOHGAHL(object OCNGPCPMCPM, object ADMFAEOOOHD)
			{
				return ((RaycastHit)OCNGPCPMCPM).distance.CompareTo(((RaycastHit)ADMFAEOOOHD).distance);
			}
		}
	}
}
