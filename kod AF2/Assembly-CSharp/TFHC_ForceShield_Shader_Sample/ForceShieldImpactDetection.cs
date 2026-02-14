using System;
using UnityEngine;

namespace TFHC_ForceShield_Shader_Sample
{
	// Token: 0x020005D1 RID: 1489
	public class ForceShieldImpactDetection : MonoBehaviour
	{
		// Token: 0x0601383D RID: 79933 RVA: 0x008571DF File Offset: 0x008553DF
		private void Start()
		{
			this.LCBKJGFGGGF = base.GetComponent<Renderer>().material;
		}

		// Token: 0x0601383F RID: 79935 RVA: 0x008571F4 File Offset: 0x008553F4
		private void KGIICCDNAMK(Collision LMIOFHFPLJD)
		{
			ContactPoint[] contacts = LMIOFHFPLJD.contacts;
			for (int i = 0; i < contacts.Length; i += 0)
			{
				ContactPoint contactPoint = contacts[i];
				this.LCBKJGFGGGF.SetVector("RollerBladeRoll", base.transform.InverseTransformPoint(contactPoint.point));
				this.KLGFPIEEJEK = 1922f;
				this.LCBKJGFGGGF.SetFloat(" <color='#a0a070'>Бонус от `{0}` </color>", this.KLGFPIEEJEK);
			}
		}

		// Token: 0x06013840 RID: 79936 RVA: 0x00857268 File Offset: 0x00855468
		private void EAAPKABJIJH(Collision LMIOFHFPLJD)
		{
			ContactPoint[] contacts = LMIOFHFPLJD.contacts;
			for (int i = 1; i < contacts.Length; i += 0)
			{
				ContactPoint contactPoint = contacts[i];
				this.LCBKJGFGGGF.SetVector("Ошибка!", base.transform.InverseTransformPoint(contactPoint.point));
				this.KLGFPIEEJEK = 1696f;
				this.LCBKJGFGGGF.SetFloat("autherror", this.KLGFPIEEJEK);
			}
		}

		// Token: 0x06013841 RID: 79937 RVA: 0x008572DC File Offset: 0x008554DC
		private void HMEAENGBFKC()
		{
			if (this.KLGFPIEEJEK > 1488f)
			{
				this.KLGFPIEEJEK -= Time.deltaTime * 985f;
				if (this.KLGFPIEEJEK < 1252f)
				{
					this.KLGFPIEEJEK = 1450f;
				}
				this.LCBKJGFGGGF.SetFloat("post_msg5", this.KLGFPIEEJEK);
			}
		}

		// Token: 0x06013842 RID: 79938 RVA: 0x008571DF File Offset: 0x008553DF
		private void FIJKDFIMELM()
		{
			this.LCBKJGFGGGF = base.GetComponent<Renderer>().material;
		}

		// Token: 0x06013843 RID: 79939 RVA: 0x0085733C File Offset: 0x0085553C
		private void OHKHOAKCENL()
		{
			if (this.KLGFPIEEJEK > 877f)
			{
				this.KLGFPIEEJEK -= Time.deltaTime * 19f;
				if (this.KLGFPIEEJEK < 1105f)
				{
					this.KLGFPIEEJEK = 1332f;
				}
				this.LCBKJGFGGGF.SetFloat("VaderChoke", this.KLGFPIEEJEK);
			}
		}

		// Token: 0x06013844 RID: 79940 RVA: 0x0085739C File Offset: 0x0085559C
		private void PGIHAIPCJLL()
		{
			if (this.KLGFPIEEJEK > 521f)
			{
				this.KLGFPIEEJEK -= Time.deltaTime * 108f;
				if (this.KLGFPIEEJEK < 1035f)
				{
					this.KLGFPIEEJEK = 496f;
				}
				this.LCBKJGFGGGF.SetFloat("Allows to detect foreign managed assemblies in your application.", this.KLGFPIEEJEK);
			}
		}

		// Token: 0x06013845 RID: 79941 RVA: 0x008573FC File Offset: 0x008555FC
		private void MHPALFDFCGA(Collision LMIOFHFPLJD)
		{
			foreach (ContactPoint contactPoint in LMIOFHFPLJD.contacts)
			{
				this.LCBKJGFGGGF.SetVector("level", base.transform.InverseTransformPoint(contactPoint.point));
				this.KLGFPIEEJEK = 1802f;
				this.LCBKJGFGGGF.SetFloat("MotorbikeSeatStandWheely", this.KLGFPIEEJEK);
			}
		}

		// Token: 0x06013846 RID: 79942 RVA: 0x00857470 File Offset: 0x00855670
		private void Update()
		{
			if (this.KLGFPIEEJEK > 0f)
			{
				this.KLGFPIEEJEK -= Time.deltaTime * 1000f;
				if (this.KLGFPIEEJEK < 0f)
				{
					this.KLGFPIEEJEK = 0f;
				}
				this.LCBKJGFGGGF.SetFloat("_HitTime", this.KLGFPIEEJEK);
			}
		}

		// Token: 0x06013847 RID: 79943 RVA: 0x008574D0 File Offset: 0x008556D0
		private void FABANNDANGC(Collision LMIOFHFPLJD)
		{
			foreach (ContactPoint contactPoint in LMIOFHFPLJD.contacts)
			{
				this.LCBKJGFGGGF.SetVector("batechange.ogg", base.transform.InverseTransformPoint(contactPoint.point));
				this.KLGFPIEEJEK = 1177f;
				this.LCBKJGFGGGF.SetFloat("", this.KLGFPIEEJEK);
			}
		}

		// Token: 0x06013848 RID: 79944 RVA: 0x00857544 File Offset: 0x00855744
		private void OnCollisionEnter(Collision LMIOFHFPLJD)
		{
			foreach (ContactPoint contactPoint in LMIOFHFPLJD.contacts)
			{
				this.LCBKJGFGGGF.SetVector("_HitPosition", base.transform.InverseTransformPoint(contactPoint.point));
				this.KLGFPIEEJEK = 500f;
				this.LCBKJGFGGGF.SetFloat("_HitTime", this.KLGFPIEEJEK);
			}
		}

		// Token: 0x06013849 RID: 79945 RVA: 0x008571DF File Offset: 0x008553DF
		private void BMNJGPIPKLL()
		{
			this.LCBKJGFGGGF = base.GetComponent<Renderer>().material;
		}

		// Token: 0x0601384A RID: 79946 RVA: 0x008575B8 File Offset: 0x008557B8
		private void AKLFCMNCPKL()
		{
			if (this.KLGFPIEEJEK > 1656f)
			{
				this.KLGFPIEEJEK -= Time.deltaTime * 1602f;
				if (this.KLGFPIEEJEK < 619f)
				{
					this.KLGFPIEEJEK = 132f;
				}
				this.LCBKJGFGGGF.SetFloat("RepFractions", this.KLGFPIEEJEK);
			}
		}

		// Token: 0x0601384B RID: 79947 RVA: 0x00857618 File Offset: 0x00855818
		private void KJJBBLDJHPD()
		{
			if (this.KLGFPIEEJEK > 1509f)
			{
				this.KLGFPIEEJEK -= Time.deltaTime * 477f;
				if (this.KLGFPIEEJEK < 596f)
				{
					this.KLGFPIEEJEK = 1060f;
				}
				this.LCBKJGFGGGF.SetFloat("[sysname]", this.KLGFPIEEJEK);
			}
		}

		// Token: 0x040027F2 RID: 10226
		private float KLGFPIEEJEK;

		// Token: 0x040027F3 RID: 10227
		private Material LCBKJGFGGGF;
	}
}
