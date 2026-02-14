using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004A7 RID: 1191
	public abstract class RotationLimit : MonoBehaviour
	{
		// Token: 0x060104B2 RID: 66738 RVA: 0x0074AC7D File Offset: 0x00748E7D
		public void SetDefaultLocalRotation()
		{
			this.defaultLocalRotation = base.transform.localRotation;
		}

		// Token: 0x060104B3 RID: 66739 RVA: 0x0074AC90 File Offset: 0x00748E90
		public Quaternion GetLimitedLocalRotation(Quaternion JJCLNGDAJLC, out bool LNPJAKGGGEJ)
		{
			if (!this.EOFDOPLDFCG)
			{
				this.Awake();
			}
			Quaternion quaternion = Quaternion.Inverse(this.defaultLocalRotation) * JJCLNGDAJLC;
			Quaternion quaternion2 = this.BIMJCOEIPML(quaternion);
			LNPJAKGGGEJ = (quaternion2 != quaternion);
			if (!LNPJAKGGGEJ)
			{
				return JJCLNGDAJLC;
			}
			return this.defaultLocalRotation * quaternion2;
		}

		// Token: 0x060104B4 RID: 66740 RVA: 0x0074ACE0 File Offset: 0x00748EE0
		public bool Apply()
		{
			bool result = false;
			base.transform.localRotation = this.GetLimitedLocalRotation(base.transform.localRotation, out result);
			return result;
		}

		// Token: 0x060104B5 RID: 66741 RVA: 0x0074AD0E File Offset: 0x00748F0E
		public void Disable()
		{
			if (this.EOFDOPLDFCG)
			{
				base.enabled = false;
				return;
			}
			this.Awake();
			base.enabled = false;
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060104B6 RID: 66742 RVA: 0x0074AD2D File Offset: 0x00748F2D
		public Vector3 FMCLNAMOGLE
		{
			get
			{
				return new Vector3(this.axis.y, this.axis.z, this.axis.x);
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060104B7 RID: 66743 RVA: 0x0074AD55 File Offset: 0x00748F55
		public Vector3 KNDJLKGOHKA
		{
			get
			{
				return Vector3.Cross(this.axis, this.FMCLNAMOGLE);
			}
		}

		// Token: 0x060104B8 RID: 66744
		protected abstract Quaternion BIMJCOEIPML(Quaternion PHKIOHIBNPA);

		// Token: 0x060104B9 RID: 66745 RVA: 0x0074AD68 File Offset: 0x00748F68
		private void Awake()
		{
			this.SetDefaultLocalRotation();
			if (this.axis == Vector3.zero)
			{
				Debug.LogError("Axis is Vector3.zero.");
			}
			this.EOFDOPLDFCG = true;
		}

		// Token: 0x060104BA RID: 66746 RVA: 0x0074AD93 File Offset: 0x00748F93
		private void LateUpdate()
		{
			this.Apply();
		}

		// Token: 0x060104BB RID: 66747 RVA: 0x006992DE File Offset: 0x006974DE
		public void LogWarning(string EDAPHMJENPK)
		{
			PMCOMMEEGMC.ICAFGKHAAED(EDAPHMJENPK, base.transform, false);
		}

		// Token: 0x060104BC RID: 66748 RVA: 0x0074AD9C File Offset: 0x00748F9C
		protected static Quaternion HIMOMPDCDOH(Quaternion PHKIOHIBNPA, Vector3 HNANBJENIHC)
		{
			return Quaternion.FromToRotation(PHKIOHIBNPA * HNANBJENIHC, HNANBJENIHC) * PHKIOHIBNPA;
		}

		// Token: 0x060104BD RID: 66749 RVA: 0x0074ADB4 File Offset: 0x00748FB4
		protected static Quaternion HPOGCBKEDCE(Quaternion PHKIOHIBNPA, Vector3 HNANBJENIHC, Vector3 FEJFEKONKKD, float BKDPAPJEAFL)
		{
			BKDPAPJEAFL = Mathf.Clamp(BKDPAPJEAFL, 0f, 180f);
			if (BKDPAPJEAFL >= 180f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * HNANBJENIHC;
			Vector3 toDirection = FEJFEKONKKD;
			Vector3.OrthoNormalize(ref vector, ref toDirection);
			Vector3 fromDirection = PHKIOHIBNPA * FEJFEKONKKD;
			Vector3.OrthoNormalize(ref vector, ref fromDirection);
			Quaternion quaternion = Quaternion.FromToRotation(fromDirection, toDirection) * PHKIOHIBNPA;
			if (BKDPAPJEAFL <= 0f)
			{
				return quaternion;
			}
			return Quaternion.RotateTowards(quaternion, PHKIOHIBNPA, BKDPAPJEAFL);
		}

		// Token: 0x060104BE RID: 66750 RVA: 0x0074AE21 File Offset: 0x00749021
		protected static float IAFNCPKDFNG(Vector3 JOLDKEGCOCD, Vector3 EHDKGKIGJAB, Vector3 LJGHBOFJDBJ)
		{
			Vector3.OrthoNormalize(ref LJGHBOFJDBJ, ref JOLDKEGCOCD);
			Vector3.OrthoNormalize(ref LJGHBOFJDBJ, ref EHDKGKIGJAB);
			return Vector3.Angle(JOLDKEGCOCD, EHDKGKIGJAB);
		}

		// Token: 0x0400222B RID: 8747
		public Vector3 axis = Vector3.forward;

		// Token: 0x0400222C RID: 8748
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		// Token: 0x0400222D RID: 8749
		private bool EOFDOPLDFCG;

		// Token: 0x0400222E RID: 8750
		private bool EHCHILFKNCL;
	}
}
