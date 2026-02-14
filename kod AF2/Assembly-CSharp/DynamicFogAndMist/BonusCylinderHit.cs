using System;
using System.Collections;
using UnityEngine;

namespace DynamicFogAndMist
{
	// Token: 0x020002AA RID: 682
	public class BonusCylinderHit : MonoBehaviour
	{
		// Token: 0x0600A04D RID: 41037 RVA: 0x004797DC File Offset: 0x004779DC
		private void DLJNLKKAMEN(Collision LMIOFHFPLJD)
		{
			Game.ODCIPPFGLCJ().NJGPHFFNAOP(5);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.JEFNFGJGNPM(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("Crouch180").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A04E RID: 41038 RVA: 0x00479834 File Offset: 0x00477A34
		private void PCPLMOEOOGN(Collision LMIOFHFPLJD)
		{
			Game.MDEKHMGODIL().KIOGNJFOGED(40);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.NOPCKPKEGAJ(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("t_shoes").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A04F RID: 41039 RVA: 0x0047988C File Offset: 0x00477A8C
		private IEnumerator FIBOAADCFOF(GameObject HLJNLLGBHMN)
		{
			base.GetComponent<Renderer>().sharedMaterial.color = Color.cyan;
			int num;
			for (int i = 10; i > 0; i = num + 1)
			{
				base.transform.localScale *= 0.8f;
				yield return new WaitForSeconds(0.1f);
				if (HLJNLLGBHMN != null)
				{
					HLJNLLGBHMN.GetComponent<Renderer>().enabled = !HLJNLLGBHMN.GetComponent<Renderer>().enabled;
				}
				num = i;
			}
			UnityEngine.Object.Destroy(HLJNLLGBHMN);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600A050 RID: 41040 RVA: 0x004798A2 File Offset: 0x00477AA2
		private IEnumerator PDPPCNFCJJK(GameObject HLJNLLGBHMN)
		{
			BonusCylinderHit.KMGCAKNNGDH kmgcaknngdh = new BonusCylinderHit.KMGCAKNNGDH(1);
			kmgcaknngdh.AENJLLPLILM = this;
			kmgcaknngdh.HLJNLLGBHMN = HLJNLLGBHMN;
			return kmgcaknngdh;
		}

		// Token: 0x0600A052 RID: 41042 RVA: 0x0047988C File Offset: 0x00477A8C
		private IEnumerator OBJEMNFHIJC(GameObject HLJNLLGBHMN)
		{
			base.GetComponent<Renderer>().sharedMaterial.color = Color.cyan;
			int num;
			for (i = 10; i > 0; i = num + 1)
			{
				base.transform.localScale *= 0.8f;
				yield return new WaitForSeconds(0.1f);
				if (HLJNLLGBHMN != null)
				{
					HLJNLLGBHMN.GetComponent<Renderer>().enabled = !HLJNLLGBHMN.GetComponent<Renderer>().enabled;
				}
				num = i;
			}
			UnityEngine.Object.Destroy(HLJNLLGBHMN);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600A053 RID: 41043 RVA: 0x004798B8 File Offset: 0x00477AB8
		private void MHPALFDFCGA(Collision LMIOFHFPLJD)
		{
			Game.ODCIPPFGLCJ().DAHEINKFEPB(12);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.GKGLAOBLABB(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("No MeshFilter!").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A054 RID: 41044 RVA: 0x00479910 File Offset: 0x00477B10
		private void KGIICCDNAMK(Collision LMIOFHFPLJD)
		{
			Game.HKNOMPOFKLP().FAGHGFMCAMG(-105);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.FIBOAADCFOF(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("WizardNeoBlock").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A055 RID: 41045 RVA: 0x00479968 File Offset: 0x00477B68
		private void ICPKIJIEDLH(Collision LMIOFHFPLJD)
		{
			Game.IILDIFNCAHM().FHPBFCLPOIG(61);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.PDPPCNFCJJK(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("tintColor").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A056 RID: 41046 RVA: 0x004798A2 File Offset: 0x00477AA2
		private IEnumerator JEFNFGJGNPM(GameObject HLJNLLGBHMN)
		{
			BonusCylinderHit.KMGCAKNNGDH kmgcaknngdh = new BonusCylinderHit.KMGCAKNNGDH(1);
			kmgcaknngdh.AENJLLPLILM = this;
			kmgcaknngdh.HLJNLLGBHMN = HLJNLLGBHMN;
			return kmgcaknngdh;
		}

		// Token: 0x0600A057 RID: 41047 RVA: 0x0047988C File Offset: 0x00477A8C
		private IEnumerator JDJMDBEMBMI(GameObject HLJNLLGBHMN)
		{
			base.GetComponent<Renderer>().sharedMaterial.color = Color.cyan;
			int num;
			for (i = 10; i > 0; i = num + 1)
			{
				base.transform.localScale *= 0.8f;
				yield return new WaitForSeconds(0.1f);
				if (HLJNLLGBHMN != null)
				{
					HLJNLLGBHMN.GetComponent<Renderer>().enabled = !HLJNLLGBHMN.GetComponent<Renderer>().enabled;
				}
				num = i;
			}
			UnityEngine.Object.Destroy(HLJNLLGBHMN);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600A058 RID: 41048 RVA: 0x004798A2 File Offset: 0x00477AA2
		private IEnumerator DLPDJBCEJII(GameObject HLJNLLGBHMN)
		{
			BonusCylinderHit.KMGCAKNNGDH kmgcaknngdh = new BonusCylinderHit.KMGCAKNNGDH(1);
			kmgcaknngdh.AENJLLPLILM = this;
			kmgcaknngdh.HLJNLLGBHMN = HLJNLLGBHMN;
			return kmgcaknngdh;
		}

		// Token: 0x0600A059 RID: 41049 RVA: 0x004799C0 File Offset: 0x00477BC0
		private void OnCollisionEnter(Collision LMIOFHFPLJD)
		{
			Game.COIPKPKLDAH.AnnotateScore(100);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.OBJEMNFHIJC(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("Sounds/Hit").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A05A RID: 41050 RVA: 0x004798A2 File Offset: 0x00477AA2
		private IEnumerator GKGLAOBLABB(GameObject HLJNLLGBHMN)
		{
			BonusCylinderHit.KMGCAKNNGDH kmgcaknngdh = new BonusCylinderHit.KMGCAKNNGDH(1);
			kmgcaknngdh.AENJLLPLILM = this;
			kmgcaknngdh.HLJNLLGBHMN = HLJNLLGBHMN;
			return kmgcaknngdh;
		}

		// Token: 0x0600A05B RID: 41051 RVA: 0x00479A18 File Offset: 0x00477C18
		private void CMCMNNDKEOK(Collision LMIOFHFPLJD)
		{
			Game.INKFNAOOOLC().NJGPHFFNAOP(90);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.APJHMPHGBKK(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("-none-").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A05C RID: 41052 RVA: 0x00479A70 File Offset: 0x00477C70
		private void ODGJJKKHEPI(Collision LMIOFHFPLJD)
		{
			Game.NEIKJNHGHBA().LOMIKGMEMNB(51);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.JDJMDBEMBMI(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find(" has been disabled as it's not supported on the current platform.").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A05D RID: 41053 RVA: 0x00479AC8 File Offset: 0x00477CC8
		private void PBGBHJLEPOC(Collision LMIOFHFPLJD)
		{
			Game.MDEKHMGODIL().FJNJCHILDAL(60);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.FIBOAADCFOF(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("WeaponReadyFire").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A05E RID: 41054 RVA: 0x0047988C File Offset: 0x00477A8C
		private IEnumerator OJGFBMGGIFA(GameObject HLJNLLGBHMN)
		{
			base.GetComponent<Renderer>().sharedMaterial.color = Color.cyan;
			int num;
			for (i = 10; i > 0; i = num + 1)
			{
				base.transform.localScale *= 0.8f;
				yield return new WaitForSeconds(0.1f);
				if (HLJNLLGBHMN != null)
				{
					HLJNLLGBHMN.GetComponent<Renderer>().enabled = !HLJNLLGBHMN.GetComponent<Renderer>().enabled;
				}
				num = i;
			}
			UnityEngine.Object.Destroy(HLJNLLGBHMN);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600A05F RID: 41055 RVA: 0x0047988C File Offset: 0x00477A8C
		private IEnumerator CGCHJLJFJBF(GameObject HLJNLLGBHMN)
		{
			base.GetComponent<Renderer>().sharedMaterial.color = Color.cyan;
			int num;
			for (i = 10; i > 0; i = num + 1)
			{
				base.transform.localScale *= 0.8f;
				yield return new WaitForSeconds(0.1f);
				if (HLJNLLGBHMN != null)
				{
					HLJNLLGBHMN.GetComponent<Renderer>().enabled = !HLJNLLGBHMN.GetComponent<Renderer>().enabled;
				}
				num = i;
			}
			UnityEngine.Object.Destroy(HLJNLLGBHMN);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600A060 RID: 41056 RVA: 0x00479B20 File Offset: 0x00477D20
		private void FABANNDANGC(Collision LMIOFHFPLJD)
		{
			Game.MDEKHMGODIL().DAGIFGHALKD(-87);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.IHDAJONCNHB(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("Fire1").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A061 RID: 41057 RVA: 0x00479B78 File Offset: 0x00477D78
		private void DEGGJBFOKIK(Collision LMIOFHFPLJD)
		{
			Game.ODCIPPFGLCJ().FGLHMLNEDMM(-13);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.JEFNFGJGNPM(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("cntx_close").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A062 RID: 41058 RVA: 0x0047988C File Offset: 0x00477A8C
		private IEnumerator NOPCKPKEGAJ(GameObject HLJNLLGBHMN)
		{
			base.GetComponent<Renderer>().sharedMaterial.color = Color.cyan;
			int num;
			for (i = 10; i > 0; i = num + 1)
			{
				base.transform.localScale *= 0.8f;
				yield return new WaitForSeconds(0.1f);
				if (HLJNLLGBHMN != null)
				{
					HLJNLLGBHMN.GetComponent<Renderer>().enabled = !HLJNLLGBHMN.GetComponent<Renderer>().enabled;
				}
				num = i;
			}
			UnityEngine.Object.Destroy(HLJNLLGBHMN);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600A063 RID: 41059 RVA: 0x0047988C File Offset: 0x00477A8C
		private IEnumerator IHDAJONCNHB(GameObject HLJNLLGBHMN)
		{
			base.GetComponent<Renderer>().sharedMaterial.color = Color.cyan;
			int num;
			for (i = 10; i > 0; i = num + 1)
			{
				base.transform.localScale *= 0.8f;
				yield return new WaitForSeconds(0.1f);
				if (HLJNLLGBHMN != null)
				{
					HLJNLLGBHMN.GetComponent<Renderer>().enabled = !HLJNLLGBHMN.GetComponent<Renderer>().enabled;
				}
				num = i;
			}
			UnityEngine.Object.Destroy(HLJNLLGBHMN);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600A064 RID: 41060 RVA: 0x0047988C File Offset: 0x00477A8C
		private IEnumerator APJHMPHGBKK(GameObject HLJNLLGBHMN)
		{
			base.GetComponent<Renderer>().sharedMaterial.color = Color.cyan;
			int num;
			for (i = 10; i > 0; i = num + 1)
			{
				base.transform.localScale *= 0.8f;
				yield return new WaitForSeconds(0.1f);
				if (HLJNLLGBHMN != null)
				{
					HLJNLLGBHMN.GetComponent<Renderer>().enabled = !HLJNLLGBHMN.GetComponent<Renderer>().enabled;
				}
				num = i;
			}
			UnityEngine.Object.Destroy(HLJNLLGBHMN);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600A065 RID: 41061 RVA: 0x004798A2 File Offset: 0x00477AA2
		private IEnumerator DGMKNKJGNFO(GameObject HLJNLLGBHMN)
		{
			BonusCylinderHit.KMGCAKNNGDH kmgcaknngdh = new BonusCylinderHit.KMGCAKNNGDH(1);
			kmgcaknngdh.AENJLLPLILM = this;
			kmgcaknngdh.HLJNLLGBHMN = HLJNLLGBHMN;
			return kmgcaknngdh;
		}

		// Token: 0x0600A066 RID: 41062 RVA: 0x00479BD0 File Offset: 0x00477DD0
		private void NFGIFAJFGAJ(Collision LMIOFHFPLJD)
		{
			Game.MDEKHMGODIL().MJIBJNADGII(94);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.PDPPCNFCJJK(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("lifeBar").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A067 RID: 41063 RVA: 0x004798A2 File Offset: 0x00477AA2
		private IEnumerator JPBKMBPNJCC(GameObject HLJNLLGBHMN)
		{
			BonusCylinderHit.KMGCAKNNGDH kmgcaknngdh = new BonusCylinderHit.KMGCAKNNGDH(1);
			kmgcaknngdh.AENJLLPLILM = this;
			kmgcaknngdh.HLJNLLGBHMN = HLJNLLGBHMN;
			return kmgcaknngdh;
		}

		// Token: 0x0600A068 RID: 41064 RVA: 0x004798A2 File Offset: 0x00477AA2
		private IEnumerator NKALEMBKHCA(GameObject HLJNLLGBHMN)
		{
			BonusCylinderHit.KMGCAKNNGDH kmgcaknngdh = new BonusCylinderHit.KMGCAKNNGDH(1);
			kmgcaknngdh.AENJLLPLILM = this;
			kmgcaknngdh.HLJNLLGBHMN = HLJNLLGBHMN;
			return kmgcaknngdh;
		}

		// Token: 0x0600A069 RID: 41065 RVA: 0x004798A2 File Offset: 0x00477AA2
		private IEnumerator ANMIDJKCPCA(GameObject HLJNLLGBHMN)
		{
			BonusCylinderHit.KMGCAKNNGDH kmgcaknngdh = new BonusCylinderHit.KMGCAKNNGDH(1);
			kmgcaknngdh.AENJLLPLILM = this;
			kmgcaknngdh.HLJNLLGBHMN = HLJNLLGBHMN;
			return kmgcaknngdh;
		}

		// Token: 0x0600A06A RID: 41066 RVA: 0x00479C28 File Offset: 0x00477E28
		private void EPCDBAOMFCC(Collision LMIOFHFPLJD)
		{
			Game.HKNOMPOFKLP().FHPBFCLPOIG(18);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.JDJMDBEMBMI(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("GrounderIK does not support FullBodyBipedIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead. If you want to use FullBodyBipedIK, use the GrounderFBBIK component.").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x00479C80 File Offset: 0x00477E80
		private void EAAPKABJIJH(Collision LMIOFHFPLJD)
		{
			Game.MDEKHMGODIL().DKPKAIKBPLL(104);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.JPBKMBPNJCC(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("[ACTk] <b>[ ObscuredString test ]</b>").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A06C RID: 41068 RVA: 0x00479CD8 File Offset: 0x00477ED8
		private void EAOIPOGDHGP(Collision LMIOFHFPLJD)
		{
			Game.COIPKPKLDAH.MJIBJNADGII(96);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.APJHMPHGBKK(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("IdleCheer").GetComponent<AudioSource>().Play();
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x00479D30 File Offset: 0x00477F30
		private void FPDCLAEMBGP(Collision LMIOFHFPLJD)
		{
			Game.INKFNAOOOLC().DKPKAIKBPLL(-83);
			GameObject gameObject = LMIOFHFPLJD.collider.gameObject;
			base.StartCoroutine(this.NKALEMBKHCA(gameObject));
			UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
			gameObject.transform.Find("wpn_sost").GetComponent<AudioSource>().Play();
		}
	}
}
