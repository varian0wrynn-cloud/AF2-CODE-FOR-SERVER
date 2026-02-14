using System;
using UnityEngine;
using UnityEngine.Events;

namespace CodeStage.AntiCheat.Detectors
{
	// Token: 0x02000596 RID: 1430
	[AddComponentMenu("")]
	public abstract class ActDetectorBase : MonoBehaviour
	{
		// Token: 0x06012D7A RID: 77178 RVA: 0x00820B38 File Offset: 0x0081ED38
		private void Start()
		{
			if (ActDetectorBase.ACFEJFHNHPH == null && base.gameObject.name == "Anti-Cheat Toolkit Detectors")
			{
				ActDetectorBase.ACFEJFHNHPH = base.gameObject;
			}
			if (this.autoStart && !this.JEEGDFAGAAM)
			{
				this.MDFJEOGCPHB();
			}
		}

		// Token: 0x06012D7B RID: 77179 RVA: 0x00820B8A File Offset: 0x0081ED8A
		private void OnEnable()
		{
			if (!this.JEEGDFAGAAM || (!this.detectionEventHasListener && this.IDIOOPABEMA == null && !this.PNHNJJNMODE()))
			{
				return;
			}
			this.KBIADJEBIDO();
		}

		// Token: 0x06012D7C RID: 77180 RVA: 0x00820BB3 File Offset: 0x0081EDB3
		private void OnDisable()
		{
			if (!this.JEEGDFAGAAM)
			{
				return;
			}
			this.FHMIHHDHAAF();
		}

		// Token: 0x06012D7D RID: 77181 RVA: 0x00820BC4 File Offset: 0x0081EDC4
		private void OnApplicationQuit()
		{
			this.LPDEBEBJDJF();
		}

		// Token: 0x06012D7E RID: 77182 RVA: 0x00820BCC File Offset: 0x0081EDCC
		protected virtual void OnDestroy()
		{
			this.GKKIAKCDDGN();
			if (base.transform.childCount == 0 && base.GetComponentsInChildren<Component>().Length <= 2)
			{
				UnityEngine.Object.Destroy(base.gameObject);
				return;
			}
			if (base.name == "Anti-Cheat Toolkit Detectors" && base.GetComponentsInChildren<ActDetectorBase>().Length <= 1)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
		}

		// Token: 0x06012D7F RID: 77183 RVA: 0x00820C2C File Offset: 0x0081EE2C
		protected virtual bool PINLMCCKKNA(ActDetectorBase COIPKPKLDAH, string BDOHNLMDNHJ)
		{
			if (COIPKPKLDAH != null && COIPKPKLDAH != this && COIPKPKLDAH.keepAlive)
			{
				Debug.LogWarning("[ACTk] " + base.name + ": self-destroying, other instance already exists & only one instance allowed!", base.gameObject);
				UnityEngine.Object.Destroy(this);
				return false;
			}
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			return true;
		}

		// Token: 0x06012D80 RID: 77184 RVA: 0x00820C87 File Offset: 0x0081EE87
		protected virtual void LPDEBEBJDJF()
		{
			UnityEngine.Object.Destroy(this);
		}

		// Token: 0x06012D81 RID: 77185 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual bool PNHNJJNMODE()
		{
			return false;
		}

		// Token: 0x06012D82 RID: 77186 RVA: 0x00820C8F File Offset: 0x0081EE8F
		internal virtual void DDINBCFIGNH()
		{
			if (this.IDIOOPABEMA != null)
			{
				this.IDIOOPABEMA();
			}
			if (this.detectionEventHasListener)
			{
				this.detectionEvent.Invoke();
			}
			if (this.autoDispose)
			{
				this.LPDEBEBJDJF();
				return;
			}
			this.GKKIAKCDDGN();
		}

		// Token: 0x06012D83 RID: 77187
		protected abstract void MDFJEOGCPHB();

		// Token: 0x06012D84 RID: 77188
		protected abstract void GKKIAKCDDGN();

		// Token: 0x06012D85 RID: 77189
		protected abstract void FHMIHHDHAAF();

		// Token: 0x06012D86 RID: 77190
		protected abstract void KBIADJEBIDO();

		// Token: 0x04002687 RID: 9863
		protected static GameObject ACFEJFHNHPH;

		// Token: 0x04002688 RID: 9864
		[Tooltip("Automatically start detector. Detection Event will be called on detection.")]
		public bool autoStart = true;

		// Token: 0x04002689 RID: 9865
		[Tooltip("Detector will survive new level (scene) load if checked.")]
		public bool keepAlive = true;

		// Token: 0x0400268A RID: 9866
		[Tooltip("Automatically dispose Detector after firing callback.")]
		public bool autoDispose = true;

		// Token: 0x0400268B RID: 9867
		[SerializeField]
		protected UnityEvent detectionEvent;

		// Token: 0x0400268C RID: 9868
		protected UnityAction IDIOOPABEMA;

		// Token: 0x0400268D RID: 9869
		[SerializeField]
		protected bool detectionEventHasListener;

		// Token: 0x0400268E RID: 9870
		protected bool OIOJMFCCDLH;

		// Token: 0x0400268F RID: 9871
		protected bool JEEGDFAGAAM;

		// Token: 0x04002690 RID: 9872
		protected static string GMMJGPLJOGC = "Anti-Cheat Toolkit Detectors";

		// Token: 0x04002691 RID: 9873
		protected static string HMGFHDBDCNL = "Code Stage/Anti-Cheat Toolkit/";

		// Token: 0x04002692 RID: 9874
		protected static string OANNPGCNNOO = "GameObject/Create Other/Code Stage/Anti-Cheat Toolkit/";
	}
}
