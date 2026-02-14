using System;
using System.Collections;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	// Token: 0x020002DC RID: 732
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		// Token: 0x0600AC6E RID: 44142 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void LLAKEBPJHLO()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC6F RID: 44143 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void CNCIDMFBJPD()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC70 RID: 44144 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator DDEBDCGNCPC()
		{
			ParticleSystem[] componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			float num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC71 RID: 44145 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void OAGCNOMAODO()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600AC72 RID: 44146 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator DGGMJCMLLED()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600AC73 RID: 44147 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator EDGALMCHPPH()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC74 RID: 44148 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void MBIEKJHECHC()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC75 RID: 44149 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void EAILKIGLAAJ()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC76 RID: 44150 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void GFAFPKOBNJH()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC77 RID: 44151 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator ELADFDNPOOI()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600AC78 RID: 44152 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void OBNDOMHCDCA()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600AC79 RID: 44153 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator AIFIEAGFIMM()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void JICOFELKMBI()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator CPNOBMNKPNC()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600AC7C RID: 44156 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator LHHKDNILMDI()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void JFAGPNEGKGM()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator PBMPJPIMJBF()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void NHEGGOGLMOE()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600AC80 RID: 44160 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator CLHGHANANNL()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC81 RID: 44161 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator LMEJKAEIDCO()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC82 RID: 44162 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator PMDPLLIBJAF()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC83 RID: 44163 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator EFJDBBDMPMC()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600AC84 RID: 44164 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void Stop()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC85 RID: 44165 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator JLKBMEBFHBI()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC86 RID: 44166 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator LPNDCJKAKEA()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC87 RID: 44167 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void DFDFHAHKCHN()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC88 RID: 44168 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void ENEAFMDCANF()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600AC89 RID: 44169 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator HHGGCBLOJGB()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600AC8A RID: 44170 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator CGNGBFFGGBP()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC8B RID: 44171 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator Start()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC8C RID: 44172 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator OFGMIEJKMGC()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600AC8D RID: 44173 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void GLKLDDBJKPA()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600AC8E RID: 44174 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator FPLHODJCJDO()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC8F RID: 44175 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator PFNPOHMMJDN()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC90 RID: 44176 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator FIJKDFIMELM()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600AC91 RID: 44177 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void EKCDEFNIGKJ()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600AC92 RID: 44178 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void AHLNFDFMGNE()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC93 RID: 44179 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void NCBLDMMOBBN()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void OGLHPCKEGPD()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600AC95 RID: 44181 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void MANEDPBAIOJ()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC96 RID: 44182 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void PIEKDPAAAJC()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC97 RID: 44183 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void NGCOMILIIII()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC98 RID: 44184 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator GDIMBBBPIHI()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600AC99 RID: 44185 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator KGICJDGIIJK()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC9A RID: 44186 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void KHKBOLDNCJP()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600AC9B RID: 44187 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator ANHOOJFEJJE()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC9C RID: 44188 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator KFGKKLAKFGH()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600AC9D RID: 44189 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void PGKIHCJABGC()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600AC9E RID: 44190 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator IMABGALEMBI()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600AC9F RID: 44191 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator DHJDMKLBLEF()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600ACA0 RID: 44192 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void BHEHOLAJOHO()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600ACA1 RID: 44193 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator NOKJMMDMJNO()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600ACA2 RID: 44194 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator BMNJGPIPKLL()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600ACA3 RID: 44195 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void CNFBINGAGCM()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600ACA4 RID: 44196 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void KCNDIOKFNMD()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600ACA5 RID: 44197 RVA: 0x004BFD49 File Offset: 0x004BDF49
		private IEnumerator DGEIACONKCJ()
		{
			componentsInChildren = base.GetComponentsInChildren<ParticleSystem>();
			foreach (ParticleSystem particleSystem in componentsInChildren)
			{
				this.LMEKDGONGPJ = Mathf.Max(particleSystem.main.startLifetime.constant, this.LMEKDGONGPJ);
			}
			num = Time.time + UnityEngine.Random.Range(this.minDuration, this.maxDuration);
			while (Time.time < num && !this.BOGMJGLKMHJ)
			{
				yield return null;
			}
			Debug.Log("stopping " + base.name);
			ParticleSystem[] array = componentsInChildren;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].emission.enabled = false;
			}
			base.BroadcastMessage("Extinguish", SendMessageOptions.DontRequireReceiver);
			yield return new WaitForSeconds(this.LMEKDGONGPJ);
			UnityEngine.Object.Destroy(base.gameObject);
			yield break;
		}

		// Token: 0x0600ACA6 RID: 44198 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator CBLGFOFHNPJ()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600ACA7 RID: 44199 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator ONIHHFLOJMN()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600ACA8 RID: 44200 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator CGFDDFHECLJ()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600ACA9 RID: 44201 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void PEDKFBFONKN()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600ACAA RID: 44202 RVA: 0x004BFD61 File Offset: 0x004BDF61
		private IEnumerator KJJNMNKPNCH()
		{
			ParticleSystemDestroyer.JDJNPIIFEJC jdjnpiifejc = new ParticleSystemDestroyer.JDJNPIIFEJC(1);
			jdjnpiifejc.AENJLLPLILM = this;
			return jdjnpiifejc;
		}

		// Token: 0x0600ACAC RID: 44204 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void PCMFAKCFDIG()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0600ACAD RID: 44205 RVA: 0x004BFD40 File Offset: 0x004BDF40
		public void DBBAKNCEKAF()
		{
			this.BOGMJGLKMHJ = true;
		}

		// Token: 0x0600ACAE RID: 44206 RVA: 0x004BFD58 File Offset: 0x004BDF58
		public void PLHPKFDOMBL()
		{
			this.BOGMJGLKMHJ = false;
		}

		// Token: 0x0400160C RID: 5644
		public float minDuration = 8f;

		// Token: 0x0400160D RID: 5645
		public float maxDuration = 10f;

		// Token: 0x0400160E RID: 5646
		private float LMEKDGONGPJ;

		// Token: 0x0400160F RID: 5647
		private bool BOGMJGLKMHJ;
	}
}
