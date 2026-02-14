using System;
using System.Collections;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x0200040D RID: 1037
	public class ResetInteractionObject : MonoBehaviour
	{
		// Token: 0x0600DE01 RID: 56833 RVA: 0x0065CCCA File Offset: 0x0065AECA
		private void CCKHBDPIBIM(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.CBNBIOFMLOI(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE02 RID: 56834 RVA: 0x0065CCEB File Offset: 0x0065AEEB
		private void BHHDDFIOKMB(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.LINAEIJGNOC(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE03 RID: 56835 RVA: 0x0065CD0C File Offset: 0x0065AF0C
		private IEnumerator LKMDEDPJHBC(float DLJFFHHCKJJ)
		{
			while (Time.time < DLJFFHHCKJJ)
			{
				yield return null;
			}
			Poser component = base.transform.parent.GetComponent<Poser>();
			if (component != null)
			{
				component.poseRoot = null;
				component.weight = 0f;
			}
			base.transform.parent = this.DFGCKFEFDII;
			base.transform.position = this.GIIKIGDLJGB;
			base.transform.rotation = this.FPGKHBHIGNB;
			if (this.AJMNDCHJPNK != null)
			{
				this.AJMNDCHJPNK.isKinematic = false;
			}
			yield break;
		}

		// Token: 0x0600DE04 RID: 56836 RVA: 0x0065CD22 File Offset: 0x0065AF22
		private void DCMFCOPANHP(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.PAAAOEHBEGO(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE06 RID: 56838 RVA: 0x0065CD58 File Offset: 0x0065AF58
		private void ANHOOJFEJJE()
		{
			this.GIIKIGDLJGB = base.transform.position;
			this.FPGKHBHIGNB = base.transform.rotation;
			this.DFGCKFEFDII = base.transform.parent;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600DE07 RID: 56839 RVA: 0x0065CDA4 File Offset: 0x0065AFA4
		private void NKMCCPBMMBL(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.LKMDEDPJHBC(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE08 RID: 56840 RVA: 0x0065CD0C File Offset: 0x0065AF0C
		private IEnumerator EMEEJNIBOEE(float DLJFFHHCKJJ)
		{
			while (Time.time < DLJFFHHCKJJ)
			{
				yield return null;
			}
			Poser component = base.transform.parent.GetComponent<Poser>();
			if (component != null)
			{
				component.poseRoot = null;
				component.weight = 0f;
			}
			base.transform.parent = this.DFGCKFEFDII;
			base.transform.position = this.GIIKIGDLJGB;
			base.transform.rotation = this.FPGKHBHIGNB;
			if (this.AJMNDCHJPNK != null)
			{
				this.AJMNDCHJPNK.isKinematic = false;
			}
			yield break;
		}

		// Token: 0x0600DE09 RID: 56841 RVA: 0x0065CD0C File Offset: 0x0065AF0C
		private IEnumerator CBNBIOFMLOI(float DLJFFHHCKJJ)
		{
			while (Time.time < DLJFFHHCKJJ)
			{
				yield return null;
			}
			Poser component = base.transform.parent.GetComponent<Poser>();
			if (component != null)
			{
				component.poseRoot = null;
				component.weight = 0f;
			}
			base.transform.parent = this.DFGCKFEFDII;
			base.transform.position = this.GIIKIGDLJGB;
			base.transform.rotation = this.FPGKHBHIGNB;
			if (this.AJMNDCHJPNK != null)
			{
				this.AJMNDCHJPNK.isKinematic = false;
			}
			yield break;
		}

		// Token: 0x0600DE0A RID: 56842 RVA: 0x0065CDC5 File Offset: 0x0065AFC5
		private IEnumerator CMEMCGNNDNO(float DLJFFHHCKJJ)
		{
			ResetInteractionObject.CFBBJJAPOEH cfbbjjapoeh = new ResetInteractionObject.CFBBJJAPOEH(1);
			cfbbjjapoeh.AENJLLPLILM = this;
			cfbbjjapoeh.DLJFFHHCKJJ = DLJFFHHCKJJ;
			return cfbbjjapoeh;
		}

		// Token: 0x0600DE0B RID: 56843 RVA: 0x0065CDDC File Offset: 0x0065AFDC
		private void EDGALMCHPPH()
		{
			this.GIIKIGDLJGB = base.transform.position;
			this.FPGKHBHIGNB = base.transform.rotation;
			this.DFGCKFEFDII = base.transform.parent;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600DE0C RID: 56844 RVA: 0x0065CD0C File Offset: 0x0065AF0C
		private IEnumerator LKHOEFIOAIF(float DLJFFHHCKJJ)
		{
			while (Time.time < DLJFFHHCKJJ)
			{
				yield return null;
			}
			Poser component = base.transform.parent.GetComponent<Poser>();
			if (component != null)
			{
				component.poseRoot = null;
				component.weight = 0f;
			}
			base.transform.parent = this.DFGCKFEFDII;
			base.transform.position = this.GIIKIGDLJGB;
			base.transform.rotation = this.FPGKHBHIGNB;
			if (this.AJMNDCHJPNK != null)
			{
				this.AJMNDCHJPNK.isKinematic = false;
			}
			yield break;
		}

		// Token: 0x0600DE0D RID: 56845 RVA: 0x0065CD0C File Offset: 0x0065AF0C
		private IEnumerator PAAAOEHBEGO(float DLJFFHHCKJJ)
		{
			while (Time.time < DLJFFHHCKJJ)
			{
				yield return null;
			}
			Poser component = base.transform.parent.GetComponent<Poser>();
			if (component != null)
			{
				component.poseRoot = null;
				component.weight = 0f;
			}
			base.transform.parent = this.DFGCKFEFDII;
			base.transform.position = this.GIIKIGDLJGB;
			base.transform.rotation = this.FPGKHBHIGNB;
			if (this.AJMNDCHJPNK != null)
			{
				this.AJMNDCHJPNK.isKinematic = false;
			}
			yield break;
		}

		// Token: 0x0600DE0E RID: 56846 RVA: 0x0065CE28 File Offset: 0x0065B028
		private void APPNBACDMIF(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.LKHOEFIOAIF(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE0F RID: 56847 RVA: 0x0065CE4C File Offset: 0x0065B04C
		private void Start()
		{
			this.GIIKIGDLJGB = base.transform.position;
			this.FPGKHBHIGNB = base.transform.rotation;
			this.DFGCKFEFDII = base.transform.parent;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600DE10 RID: 56848 RVA: 0x0065CE98 File Offset: 0x0065B098
		private void JCBDJJPIPAN(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.MKBDPPCBIOB(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE11 RID: 56849 RVA: 0x0065CEBC File Offset: 0x0065B0BC
		private void MCHAAIIHOKD()
		{
			this.GIIKIGDLJGB = base.transform.position;
			this.FPGKHBHIGNB = base.transform.rotation;
			this.DFGCKFEFDII = base.transform.parent;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600DE12 RID: 56850 RVA: 0x0065CE98 File Offset: 0x0065B098
		private void GAPCEAHAMAJ(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.MKBDPPCBIOB(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE13 RID: 56851 RVA: 0x0065CD0C File Offset: 0x0065AF0C
		private IEnumerator MMCCOMBOAFM(float DLJFFHHCKJJ)
		{
			while (Time.time < DLJFFHHCKJJ)
			{
				yield return null;
			}
			Poser component = base.transform.parent.GetComponent<Poser>();
			if (component != null)
			{
				component.poseRoot = null;
				component.weight = 0f;
			}
			base.transform.parent = this.DFGCKFEFDII;
			base.transform.position = this.GIIKIGDLJGB;
			base.transform.rotation = this.FPGKHBHIGNB;
			if (this.AJMNDCHJPNK != null)
			{
				this.AJMNDCHJPNK.isKinematic = false;
			}
			yield break;
		}

		// Token: 0x0600DE14 RID: 56852 RVA: 0x0065CF08 File Offset: 0x0065B108
		private void KEMGOLACEHI()
		{
			this.GIIKIGDLJGB = base.transform.position;
			this.FPGKHBHIGNB = base.transform.rotation;
			this.DFGCKFEFDII = base.transform.parent;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600DE15 RID: 56853 RVA: 0x0065CCCA File Offset: 0x0065AECA
		private void LGNJADLGMLE(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.CBNBIOFMLOI(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE16 RID: 56854 RVA: 0x0065CE28 File Offset: 0x0065B028
		private void DELNKJDAPGC(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.LKHOEFIOAIF(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE17 RID: 56855 RVA: 0x0065CF54 File Offset: 0x0065B154
		private void KFIKOLPJHLE(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.EMEEJNIBOEE(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE18 RID: 56856 RVA: 0x0065CD0C File Offset: 0x0065AF0C
		private IEnumerator MKBDPPCBIOB(float DLJFFHHCKJJ)
		{
			while (Time.time < DLJFFHHCKJJ)
			{
				yield return null;
			}
			Poser component = base.transform.parent.GetComponent<Poser>();
			if (component != null)
			{
				component.poseRoot = null;
				component.weight = 0f;
			}
			base.transform.parent = this.DFGCKFEFDII;
			base.transform.position = this.GIIKIGDLJGB;
			base.transform.rotation = this.FPGKHBHIGNB;
			if (this.AJMNDCHJPNK != null)
			{
				this.AJMNDCHJPNK.isKinematic = false;
			}
			yield break;
		}

		// Token: 0x0600DE19 RID: 56857 RVA: 0x0065CD0C File Offset: 0x0065AF0C
		private IEnumerator LINAEIJGNOC(float DLJFFHHCKJJ)
		{
			while (Time.time < DLJFFHHCKJJ)
			{
				yield return null;
			}
			Poser component = base.transform.parent.GetComponent<Poser>();
			if (component != null)
			{
				component.poseRoot = null;
				component.weight = 0f;
			}
			base.transform.parent = this.DFGCKFEFDII;
			base.transform.position = this.GIIKIGDLJGB;
			base.transform.rotation = this.FPGKHBHIGNB;
			if (this.AJMNDCHJPNK != null)
			{
				this.AJMNDCHJPNK.isKinematic = false;
			}
			yield break;
		}

		// Token: 0x0600DE1A RID: 56858 RVA: 0x0065CD22 File Offset: 0x0065AF22
		private void HFBDOFCCEFI(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.PAAAOEHBEGO(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE1B RID: 56859 RVA: 0x0065CF78 File Offset: 0x0065B178
		private void AFFAJKPPMHF()
		{
			this.GIIKIGDLJGB = base.transform.position;
			this.FPGKHBHIGNB = base.transform.rotation;
			this.DFGCKFEFDII = base.transform.parent;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600DE1C RID: 56860 RVA: 0x0065CD0C File Offset: 0x0065AF0C
		private IEnumerator CCOLOOKJJPK(float DLJFFHHCKJJ)
		{
			while (Time.time < DLJFFHHCKJJ)
			{
				yield return null;
			}
			Poser component = base.transform.parent.GetComponent<Poser>();
			if (component != null)
			{
				component.poseRoot = null;
				component.weight = 0f;
			}
			base.transform.parent = this.DFGCKFEFDII;
			base.transform.position = this.GIIKIGDLJGB;
			base.transform.rotation = this.FPGKHBHIGNB;
			if (this.AJMNDCHJPNK != null)
			{
				this.AJMNDCHJPNK.isKinematic = false;
			}
			yield break;
		}

		// Token: 0x0600DE1D RID: 56861 RVA: 0x0065CFC4 File Offset: 0x0065B1C4
		private void AMFIIBDMPNJ(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.CMEMCGNNDNO(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE1E RID: 56862 RVA: 0x0065CE98 File Offset: 0x0065B098
		private void LJJLJFBMMML(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.MKBDPPCBIOB(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE1F RID: 56863 RVA: 0x0065CF54 File Offset: 0x0065B154
		private void AGIKEJNILJG(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.EMEEJNIBOEE(Time.time + this.resetDelay));
		}

		// Token: 0x0600DE20 RID: 56864 RVA: 0x0065CFE8 File Offset: 0x0065B1E8
		private void OBJCOJEHLBE()
		{
			this.GIIKIGDLJGB = base.transform.position;
			this.FPGKHBHIGNB = base.transform.rotation;
			this.DFGCKFEFDII = base.transform.parent;
			this.AJMNDCHJPNK = base.GetComponent<Rigidbody>();
		}

		// Token: 0x0600DE21 RID: 56865 RVA: 0x0065CF54 File Offset: 0x0065B154
		private void MHHKCGLAGKJ(Transform JAHNHOCNJGM)
		{
			base.StopAllCoroutines();
			base.StartCoroutine(this.EMEEJNIBOEE(Time.time + this.resetDelay));
		}

		// Token: 0x04001D63 RID: 7523
		public float resetDelay = 1f;

		// Token: 0x04001D64 RID: 7524
		private Vector3 GIIKIGDLJGB;

		// Token: 0x04001D65 RID: 7525
		private Quaternion FPGKHBHIGNB;

		// Token: 0x04001D66 RID: 7526
		private Transform DFGCKFEFDII;

		// Token: 0x04001D67 RID: 7527
		private Rigidbody AJMNDCHJPNK;
	}
}
