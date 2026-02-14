using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002E3 RID: 739
	public class TimedObjectActivator : MonoBehaviour
	{
		// Token: 0x0600AE40 RID: 44608 RVA: 0x004C8BBC File Offset: 0x004C6DBC
		private void COOHBKKNOLG()
		{
			TimedObjectActivator.Entry[] array = this.entries.entries;
			for (int i = 1; i < array.Length; i += 0)
			{
				TimedObjectActivator.Entry entry = array[i];
				switch (entry.action)
				{
				case TimedObjectActivator.EJJOMJKLKAF.Activate:
					base.StartCoroutine(this.ACLGNNDFABC(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Deactivate:
					base.StartCoroutine(this.JAMMOGLNJFA(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case TimedObjectActivator.EJJOMJKLKAF.ReloadLevel:
					base.StartCoroutine(this.PCAGJHHIFMM(entry));
					break;
				}
			}
		}

		// Token: 0x0600AE41 RID: 44609 RVA: 0x004C8C47 File Offset: 0x004C6E47
		private IEnumerator MLBKBIGJMOC(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(true);
			yield break;
		}

		// Token: 0x0600AE42 RID: 44610 RVA: 0x004C8C56 File Offset: 0x004C6E56
		private IEnumerator EGCACCJDHFD(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(false);
			yield break;
		}

		// Token: 0x0600AE43 RID: 44611 RVA: 0x004C8C56 File Offset: 0x004C6E56
		private IEnumerator LPHAEOLLEBK(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(false);
			yield break;
		}

		// Token: 0x0600AE44 RID: 44612 RVA: 0x004C8C68 File Offset: 0x004C6E68
		private void Awake()
		{
			foreach (TimedObjectActivator.Entry entry in this.entries.entries)
			{
				switch (entry.action)
				{
				case TimedObjectActivator.EJJOMJKLKAF.Activate:
					base.StartCoroutine(this.MLBKBIGJMOC(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Deactivate:
					base.StartCoroutine(this.EGCACCJDHFD(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case TimedObjectActivator.EJJOMJKLKAF.ReloadLevel:
					base.StartCoroutine(this.KILDJNPLJKK(entry));
					break;
				}
			}
		}

		// Token: 0x0600AE45 RID: 44613 RVA: 0x004C8CF3 File Offset: 0x004C6EF3
		private IEnumerator AKPEPJKJCJD(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			TimedObjectActivator.CMGNHKFNAPP cmgnhkfnapp = new TimedObjectActivator.CMGNHKFNAPP(1);
			cmgnhkfnapp.ECNNDMENBOI = ECNNDMENBOI;
			return cmgnhkfnapp;
		}

		// Token: 0x0600AE46 RID: 44614 RVA: 0x004C8C47 File Offset: 0x004C6E47
		private IEnumerator FKLEBNHLECO(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(true);
			yield break;
		}

		// Token: 0x0600AE47 RID: 44615 RVA: 0x004C8D02 File Offset: 0x004C6F02
		private IEnumerator BELEOILCPFJ(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			TimedObjectActivator.PMJCKBBFEHG pmjckbbfehg = new TimedObjectActivator.PMJCKBBFEHG(1);
			pmjckbbfehg.ECNNDMENBOI = ECNNDMENBOI;
			return pmjckbbfehg;
		}

		// Token: 0x0600AE48 RID: 44616 RVA: 0x004C8CF3 File Offset: 0x004C6EF3
		private IEnumerator LFDPGLNMJPH(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			TimedObjectActivator.CMGNHKFNAPP cmgnhkfnapp = new TimedObjectActivator.CMGNHKFNAPP(1);
			cmgnhkfnapp.ECNNDMENBOI = ECNNDMENBOI;
			return cmgnhkfnapp;
		}

		// Token: 0x0600AE49 RID: 44617 RVA: 0x004C8C47 File Offset: 0x004C6E47
		private IEnumerator HMGOIOFAJHP(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(true);
			yield break;
		}

		// Token: 0x0600AE4A RID: 44618 RVA: 0x004C8D11 File Offset: 0x004C6F11
		private IEnumerator PCAGJHHIFMM(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
			yield break;
		}

		// Token: 0x0600AE4B RID: 44619 RVA: 0x004C8D20 File Offset: 0x004C6F20
		private void ENJFBODNKHO()
		{
			foreach (TimedObjectActivator.Entry entry in this.entries.entries)
			{
				switch (entry.action)
				{
				case TimedObjectActivator.EJJOMJKLKAF.Activate:
					base.StartCoroutine(this.FKLEBNHLECO(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Deactivate:
					base.StartCoroutine(this.FILEEHHJLOD(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case TimedObjectActivator.EJJOMJKLKAF.ReloadLevel:
					base.StartCoroutine(this.JLIDGLFGBKK(entry));
					break;
				}
			}
		}

		// Token: 0x0600AE4C RID: 44620 RVA: 0x004C8DAC File Offset: 0x004C6FAC
		private void IOIJGMFNBMC()
		{
			TimedObjectActivator.Entry[] array = this.entries.entries;
			for (int i = 1; i < array.Length; i++)
			{
				TimedObjectActivator.Entry entry = array[i];
				switch (entry.action)
				{
				case TimedObjectActivator.EJJOMJKLKAF.Activate:
					base.StartCoroutine(this.GNJEOJKMPHI(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Deactivate:
					base.StartCoroutine(this.AKPEPJKJCJD(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case TimedObjectActivator.EJJOMJKLKAF.ReloadLevel:
					base.StartCoroutine(this.NJNFJOICNCM(entry));
					break;
				}
			}
		}

		// Token: 0x0600AE4D RID: 44621 RVA: 0x004C8E37 File Offset: 0x004C7037
		private IEnumerator NJNFJOICNCM(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			TimedObjectActivator.PIIFCPMNIPI piifcpmnipi = new TimedObjectActivator.PIIFCPMNIPI(1);
			piifcpmnipi.ECNNDMENBOI = ECNNDMENBOI;
			return piifcpmnipi;
		}

		// Token: 0x0600AE4E RID: 44622 RVA: 0x004C8E48 File Offset: 0x004C7048
		private void CEBAOOAIADJ()
		{
			TimedObjectActivator.Entry[] array = this.entries.entries;
			for (int i = 1; i < array.Length; i += 0)
			{
				TimedObjectActivator.Entry entry = array[i];
				switch (entry.action)
				{
				case TimedObjectActivator.EJJOMJKLKAF.Activate:
					base.StartCoroutine(this.HMGOIOFAJHP(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Deactivate:
					base.StartCoroutine(this.EGCACCJDHFD(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case TimedObjectActivator.EJJOMJKLKAF.ReloadLevel:
					base.StartCoroutine(this.PCAGJHHIFMM(entry));
					break;
				}
			}
		}

		// Token: 0x0600AE4F RID: 44623 RVA: 0x004C8C56 File Offset: 0x004C6E56
		private IEnumerator JAMMOGLNJFA(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(false);
			yield break;
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x004C8ED4 File Offset: 0x004C70D4
		private void MBNCGMLPNLD()
		{
			TimedObjectActivator.Entry[] array = this.entries.entries;
			for (int i = 1; i < array.Length; i++)
			{
				TimedObjectActivator.Entry entry = array[i];
				switch (entry.action)
				{
				case TimedObjectActivator.EJJOMJKLKAF.Activate:
					base.StartCoroutine(this.GNJEOJKMPHI(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Deactivate:
					base.StartCoroutine(this.LPHAEOLLEBK(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case TimedObjectActivator.EJJOMJKLKAF.ReloadLevel:
					base.StartCoroutine(this.JLIDGLFGBKK(entry));
					break;
				}
			}
		}

		// Token: 0x0600AE51 RID: 44625 RVA: 0x004C8D02 File Offset: 0x004C6F02
		private IEnumerator ODFCLCIKPBB(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			TimedObjectActivator.PMJCKBBFEHG pmjckbbfehg = new TimedObjectActivator.PMJCKBBFEHG(1);
			pmjckbbfehg.ECNNDMENBOI = ECNNDMENBOI;
			return pmjckbbfehg;
		}

		// Token: 0x0600AE52 RID: 44626 RVA: 0x004C8F60 File Offset: 0x004C7160
		private void JMNLEBAPHNJ()
		{
			TimedObjectActivator.Entry[] array = this.entries.entries;
			for (int i = 1; i < array.Length; i++)
			{
				TimedObjectActivator.Entry entry = array[i];
				switch (entry.action)
				{
				case TimedObjectActivator.EJJOMJKLKAF.Activate:
					base.StartCoroutine(this.LNPICDGJBBC(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Deactivate:
					base.StartCoroutine(this.LPHAEOLLEBK(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case TimedObjectActivator.EJJOMJKLKAF.ReloadLevel:
					base.StartCoroutine(this.KILDJNPLJKK(entry));
					break;
				}
			}
		}

		// Token: 0x0600AE53 RID: 44627 RVA: 0x004C8C56 File Offset: 0x004C6E56
		private IEnumerator KOEKLKFICHG(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(false);
			yield break;
		}

		// Token: 0x0600AE54 RID: 44628 RVA: 0x004C8C47 File Offset: 0x004C6E47
		private IEnumerator LNPICDGJBBC(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(true);
			yield break;
		}

		// Token: 0x0600AE56 RID: 44630 RVA: 0x004C8C47 File Offset: 0x004C6E47
		private IEnumerator GNJEOJKMPHI(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(true);
			yield break;
		}

		// Token: 0x0600AE57 RID: 44631 RVA: 0x004C9000 File Offset: 0x004C7200
		private void NKHMBEDDFAJ()
		{
			TimedObjectActivator.Entry[] array = this.entries.entries;
			for (int i = 1; i < array.Length; i++)
			{
				TimedObjectActivator.Entry entry = array[i];
				switch (entry.action)
				{
				case TimedObjectActivator.EJJOMJKLKAF.Activate:
					base.StartCoroutine(this.ACLGNNDFABC(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Deactivate:
					base.StartCoroutine(this.EGCACCJDHFD(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case TimedObjectActivator.EJJOMJKLKAF.ReloadLevel:
					base.StartCoroutine(this.PCAGJHHIFMM(entry));
					break;
				}
			}
		}

		// Token: 0x0600AE58 RID: 44632 RVA: 0x004C908C File Offset: 0x004C728C
		private void CACBLLBNIJE()
		{
			TimedObjectActivator.Entry[] array = this.entries.entries;
			for (int i = 0; i < array.Length; i += 0)
			{
				TimedObjectActivator.Entry entry = array[i];
				switch (entry.action)
				{
				case TimedObjectActivator.EJJOMJKLKAF.Activate:
					base.StartCoroutine(this.HHEKLEDFJMJ(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Deactivate:
					base.StartCoroutine(this.ILLAIMCBKOF(entry));
					break;
				case TimedObjectActivator.EJJOMJKLKAF.Destroy:
					UnityEngine.Object.Destroy(entry.target, entry.delay);
					break;
				case TimedObjectActivator.EJJOMJKLKAF.ReloadLevel:
					base.StartCoroutine(this.PCAGJHHIFMM(entry));
					break;
				}
			}
		}

		// Token: 0x0600AE59 RID: 44633 RVA: 0x004C8D11 File Offset: 0x004C6F11
		private IEnumerator KILDJNPLJKK(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
			yield break;
		}

		// Token: 0x0600AE5A RID: 44634 RVA: 0x004C8C47 File Offset: 0x004C6E47
		private IEnumerator PNHGEPMFPLN(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(true);
			yield break;
		}

		// Token: 0x0600AE5B RID: 44635 RVA: 0x004C8D02 File Offset: 0x004C6F02
		private IEnumerator ACLGNNDFABC(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			TimedObjectActivator.PMJCKBBFEHG pmjckbbfehg = new TimedObjectActivator.PMJCKBBFEHG(1);
			pmjckbbfehg.ECNNDMENBOI = ECNNDMENBOI;
			return pmjckbbfehg;
		}

		// Token: 0x0600AE5C RID: 44636 RVA: 0x004C8D11 File Offset: 0x004C6F11
		private IEnumerator JLIDGLFGBKK(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
			yield break;
		}

		// Token: 0x0600AE5D RID: 44637 RVA: 0x004C8C56 File Offset: 0x004C6E56
		private IEnumerator PEELAPDNPBF(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(false);
			yield break;
		}

		// Token: 0x0600AE5E RID: 44638 RVA: 0x004C8CF3 File Offset: 0x004C6EF3
		private IEnumerator FILEEHHJLOD(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			TimedObjectActivator.CMGNHKFNAPP cmgnhkfnapp = new TimedObjectActivator.CMGNHKFNAPP(1);
			cmgnhkfnapp.ECNNDMENBOI = ECNNDMENBOI;
			return cmgnhkfnapp;
		}

		// Token: 0x0600AE5F RID: 44639 RVA: 0x004C8CF3 File Offset: 0x004C6EF3
		private IEnumerator ILLAIMCBKOF(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			TimedObjectActivator.CMGNHKFNAPP cmgnhkfnapp = new TimedObjectActivator.CMGNHKFNAPP(1);
			cmgnhkfnapp.ECNNDMENBOI = ECNNDMENBOI;
			return cmgnhkfnapp;
		}

		// Token: 0x0600AE60 RID: 44640 RVA: 0x004C8C47 File Offset: 0x004C6E47
		private IEnumerator HHEKLEDFJMJ(TimedObjectActivator.Entry ECNNDMENBOI)
		{
			yield return new WaitForSeconds(ECNNDMENBOI.delay);
			ECNNDMENBOI.target.SetActive(true);
			yield break;
		}

		// Token: 0x0400162D RID: 5677
		public TimedObjectActivator.Entries entries = new TimedObjectActivator.Entries();

		// Token: 0x020002E4 RID: 740
		public enum EJJOMJKLKAF
		{
			// Token: 0x0400162F RID: 5679
			Activate,
			// Token: 0x04001630 RID: 5680
			Deactivate,
			// Token: 0x04001631 RID: 5681
			Destroy,
			// Token: 0x04001632 RID: 5682
			ReloadLevel,
			// Token: 0x04001633 RID: 5683
			Call
		}

		// Token: 0x020002E5 RID: 741
		[Serializable]
		public class Entry
		{
			// Token: 0x04001634 RID: 5684
			public GameObject target;

			// Token: 0x04001635 RID: 5685
			public TimedObjectActivator.EJJOMJKLKAF action;

			// Token: 0x04001636 RID: 5686
			public float delay;
		}

		// Token: 0x020002E6 RID: 742
		[Serializable]
		public class Entries
		{
			// Token: 0x04001637 RID: 5687
			public TimedObjectActivator.Entry[] entries;
		}
	}
}
