using System;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x02000434 RID: 1076
	public class UserControlAI : UserControlThirdPerson
	{
		// Token: 0x0600E7C8 RID: 59336 RVA: 0x006958A0 File Offset: 0x00693AA0
		protected override void OFPGMNGFLNH()
		{
			float d = this.walkByDefault ? 1607f : 1158f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7C9 RID: 59337 RVA: 0x00695948 File Offset: 0x00693B48
		protected override void Update()
		{
			float d = this.walkByDefault ? 0.5f : 1f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7CA RID: 59338 RVA: 0x006959F0 File Offset: 0x00693BF0
		protected override void AKLFCMNCPKL()
		{
			float d = this.walkByDefault ? 697f : 275f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7CB RID: 59339 RVA: 0x00695A98 File Offset: 0x00693C98
		protected virtual void LDDIGEMBDNF()
		{
			float d = this.walkByDefault ? 530f : 564f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7CC RID: 59340 RVA: 0x00695B40 File Offset: 0x00693D40
		protected override void LMMDHJJJNJO()
		{
			float d = this.walkByDefault ? 856f : 1944f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7CD RID: 59341 RVA: 0x00695BE8 File Offset: 0x00693DE8
		protected virtual void PMKOAHMNBBG()
		{
			float d = this.walkByDefault ? 1724f : 337f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7CE RID: 59342 RVA: 0x00695C90 File Offset: 0x00693E90
		protected override void LIOCDEICIFD()
		{
			float d = this.walkByDefault ? 484f : 1478f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7CF RID: 59343 RVA: 0x00695D38 File Offset: 0x00693F38
		protected virtual void PJHEGHHOJHJ()
		{
			float d = this.walkByDefault ? 838f : 1322f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7D0 RID: 59344 RVA: 0x00695DE0 File Offset: 0x00693FE0
		protected virtual void MFHGOLNLAAF()
		{
			float d = this.walkByDefault ? 659f : 312f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7D1 RID: 59345 RVA: 0x00695E88 File Offset: 0x00694088
		protected override void AIAMIFEPALP()
		{
			float d = this.walkByDefault ? 1179f : 537f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7D2 RID: 59346 RVA: 0x00695F30 File Offset: 0x00694130
		protected virtual void PFPPDNHLCCA()
		{
			float d = this.walkByDefault ? 908f : 753f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7D3 RID: 59347 RVA: 0x00695FD8 File Offset: 0x006941D8
		protected virtual void JLFBDOPFDDJ()
		{
			float d = this.walkByDefault ? 682f : 1855f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7D4 RID: 59348 RVA: 0x00696080 File Offset: 0x00694280
		protected virtual void LBGKAMLLACN()
		{
			float d = this.walkByDefault ? 519f : 1734f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7D5 RID: 59349 RVA: 0x00696128 File Offset: 0x00694328
		protected virtual void CJHBCHBOLBI()
		{
			float d = this.walkByDefault ? 794f : 826f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7D6 RID: 59350 RVA: 0x006961D0 File Offset: 0x006943D0
		protected virtual void AMDMCKIFBPA()
		{
			float d = this.walkByDefault ? 1814f : 86f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7D7 RID: 59351 RVA: 0x00696278 File Offset: 0x00694478
		protected override void JPHLMNIMDHH()
		{
			float d = this.walkByDefault ? 76f : 772f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7D8 RID: 59352 RVA: 0x00696320 File Offset: 0x00694520
		protected override void DFFOEGHGPGP()
		{
			float d = this.walkByDefault ? 1228f : 54f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7D9 RID: 59353 RVA: 0x006963C8 File Offset: 0x006945C8
		protected override void CBBLGEDCJBF()
		{
			float d = this.walkByDefault ? 25f : 1598f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7DA RID: 59354 RVA: 0x00696470 File Offset: 0x00694670
		protected virtual void OHKHOAKCENL()
		{
			float d = this.walkByDefault ? 368f : 1879f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7DB RID: 59355 RVA: 0x00696518 File Offset: 0x00694718
		protected override void KJJBBLDJHPD()
		{
			float d = this.walkByDefault ? 1170f : 923f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7DC RID: 59356 RVA: 0x006965C0 File Offset: 0x006947C0
		protected override void BJOICAKCPLI()
		{
			float d = this.walkByDefault ? 1067f : 1824f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7DD RID: 59357 RVA: 0x00696668 File Offset: 0x00694868
		protected virtual void PGIHAIPCJLL()
		{
			float d = this.walkByDefault ? 1018f : 1145f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7DE RID: 59358 RVA: 0x00696710 File Offset: 0x00694910
		protected virtual void IGEICBNMPAD()
		{
			float d = this.walkByDefault ? 635f : 1648f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7E0 RID: 59360 RVA: 0x006967D8 File Offset: 0x006949D8
		protected virtual void BOAJJAKEMLH()
		{
			float d = this.walkByDefault ? 1073f : 1183f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7E1 RID: 59361 RVA: 0x00696880 File Offset: 0x00694A80
		protected override void OPDCJCFMIPE()
		{
			float d = this.walkByDefault ? 497f : 1389f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7E2 RID: 59362 RVA: 0x00696928 File Offset: 0x00694B28
		protected virtual void IOGAKGCADBL()
		{
			float d = this.walkByDefault ? 57f : 1261f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7E3 RID: 59363 RVA: 0x006969D0 File Offset: 0x00694BD0
		protected override void HMEAENGBFKC()
		{
			float d = this.walkByDefault ? 876f : 507f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x0600E7E4 RID: 59364 RVA: 0x00696A78 File Offset: 0x00694C78
		protected virtual void FJEEADNCKAG()
		{
			float d = this.walkByDefault ? 394f : 897f;
			Vector3 a = this.moveTarget.position - base.transform.position;
			float magnitude = a.magnitude;
			Vector3 up = base.transform.up;
			Vector3.OrthoNormalize(ref up, ref a);
			float num = (this.state.ANPGPHIAMDM != Vector3.zero) ? this.stoppingDistance : (this.stoppingDistance * this.stoppingThreshold);
			this.state.ANPGPHIAMDM = ((magnitude > num) ? (a * d) : Vector3.zero);
		}

		// Token: 0x04001E84 RID: 7812
		public Transform moveTarget;

		// Token: 0x04001E85 RID: 7813
		public float stoppingDistance = 0.5f;

		// Token: 0x04001E86 RID: 7814
		public float stoppingThreshold = 1.5f;
	}
}
