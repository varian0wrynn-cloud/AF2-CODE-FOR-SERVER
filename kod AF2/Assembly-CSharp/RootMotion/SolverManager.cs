using System;
using UnityEngine;

namespace RootMotion
{
	// Token: 0x020003C7 RID: 967
	public class SolverManager : MonoBehaviour
	{
		// Token: 0x0600D154 RID: 53588 RVA: 0x005FE522 File Offset: 0x005FC722
		private void PCKOPPKGENK()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			this.BHALELINNDJ();
		}

		// Token: 0x0600D155 RID: 53589 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void IJOMKNCJOAO()
		{
		}

		// Token: 0x0600D156 RID: 53590 RVA: 0x005FE532 File Offset: 0x005FC732
		private void Update()
		{
			if (this.OKHNNNCKKPI)
			{
				return;
			}
			if (this.MKIDEJCAHPI)
			{
				return;
			}
			if (this.fixTransforms)
			{
				this.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600D157 RID: 53591 RVA: 0x005FE554 File Offset: 0x005FC754
		private void LateUpdate()
		{
			if (this.OKHNNNCKKPI)
			{
				return;
			}
			if (!this.MKIDEJCAHPI)
			{
				this.GFCAOALODOF = true;
			}
			if (!this.GFCAOALODOF)
			{
				return;
			}
			this.GFCAOALODOF = false;
			this.MBOPIBBAHOD();
		}

		// Token: 0x0600D158 RID: 53592 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void KJBCCKCIOLJ()
		{
		}

		// Token: 0x0600D159 RID: 53593 RVA: 0x005FE584 File Offset: 0x005FC784
		private void Start()
		{
			this.BHALELINNDJ();
		}

		// Token: 0x0600D15A RID: 53594 RVA: 0x005FE58C File Offset: 0x005FC78C
		private void AKLFCMNCPKL()
		{
			if (this.OKHNNNCKKPI)
			{
				return;
			}
			if (this.MKIDEJCAHPI)
			{
				return;
			}
			if (this.fixTransforms)
			{
				this.IJOMKNCJOAO();
			}
		}

		// Token: 0x0600D15B RID: 53595 RVA: 0x005FE5AE File Offset: 0x005FC7AE
		public void MONNCIPEBPI()
		{
			Debug.Log(" ", base.transform);
			base.enabled = false;
		}

		// Token: 0x0600D15C RID: 53596 RVA: 0x005FE5C7 File Offset: 0x005FC7C7
		private void AEAPIKAENBD()
		{
			if (this.OKHNNNCKKPI)
			{
				return;
			}
			if (!this.ENDFHNMMNDG())
			{
				this.GFCAOALODOF = true;
			}
			if (!this.GFCAOALODOF)
			{
				return;
			}
			this.GFCAOALODOF = true;
			this.KJBCCKCIOLJ();
		}

		// Token: 0x0600D15D RID: 53597 RVA: 0x005FE5F7 File Offset: 0x005FC7F7
		private bool EBOLIMMIACI()
		{
			if (this.KCLACNEILLB != null)
			{
				return this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal;
			}
			return this.OHLAKEFBHBD != null && this.OHLAKEFBHBD.animatePhysics;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x0600D15E RID: 53598 RVA: 0x005FE631 File Offset: 0x005FC831
		private bool MKIDEJCAHPI
		{
			get
			{
				if (this.KCLACNEILLB != null)
				{
					return this.KCLACNEILLB.updateMode == AnimatorUpdateMode.AnimatePhysics;
				}
				return this.OHLAKEFBHBD != null && this.OHLAKEFBHBD.animatePhysics;
			}
		}

		// Token: 0x0600D15F RID: 53599 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void NGHAJHMEKLH()
		{
		}

		// Token: 0x0600D160 RID: 53600 RVA: 0x005FE66C File Offset: 0x005FC86C
		private void LMHPJHJPPDD(Transform JAHNHOCNJGM, bool DMPKPIDHCNC)
		{
			if (this.DJLMKHBHLLP)
			{
				return;
			}
			this.KCLACNEILLB = JAHNHOCNJGM.GetComponent<Animator>();
			this.OHLAKEFBHBD = JAHNHOCNJGM.GetComponent<Animation>();
			if (this.DJLMKHBHLLP)
			{
				return;
			}
			if (this.KCLACNEILLB == null && DMPKPIDHCNC)
			{
				this.KCLACNEILLB = JAHNHOCNJGM.GetComponentInChildren<Animator>();
			}
			if (this.OHLAKEFBHBD == null && DMPKPIDHCNC)
			{
				this.OHLAKEFBHBD = JAHNHOCNJGM.GetComponentInChildren<Animation>();
			}
			if (!this.DJLMKHBHLLP && JAHNHOCNJGM.parent != null)
			{
				this.LMHPJHJPPDD(JAHNHOCNJGM.parent, true);
			}
		}

		// Token: 0x0600D161 RID: 53601 RVA: 0x005FE6FE File Offset: 0x005FC8FE
		private void BHALELINNDJ()
		{
			if (this.GHLBOIJBOHB)
			{
				return;
			}
			this.ADJFBGEELOO(base.transform, true);
			this.MPJFMFOPHKJ();
			this.GHLBOIJBOHB = true;
		}

		// Token: 0x0600D162 RID: 53602 RVA: 0x005FE631 File Offset: 0x005FC831
		private bool MEAOADDDHCJ()
		{
			if (this.KCLACNEILLB != null)
			{
				return this.KCLACNEILLB.updateMode == AnimatorUpdateMode.AnimatePhysics;
			}
			return this.OHLAKEFBHBD != null && this.OHLAKEFBHBD.animatePhysics;
		}

		// Token: 0x0600D163 RID: 53603 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void BLOEEPCIPKJ()
		{
		}

		// Token: 0x0600D164 RID: 53604 RVA: 0x005FE723 File Offset: 0x005FC923
		public void KOGNHKICPGJ()
		{
			Debug.Log("_Metrics", base.transform);
			base.enabled = true;
		}

		// Token: 0x0600D165 RID: 53605 RVA: 0x005FE73C File Offset: 0x005FC93C
		public void Disable()
		{
			Debug.Log("IK.Disable() is deprecated. Use enabled = false instead", base.transform);
			base.enabled = false;
		}

		// Token: 0x0600D166 RID: 53606 RVA: 0x005FE758 File Offset: 0x005FC958
		private void ADJFBGEELOO(Transform JAHNHOCNJGM, bool DMPKPIDHCNC)
		{
			if (this.DJLMKHBHLLP)
			{
				return;
			}
			this.KCLACNEILLB = JAHNHOCNJGM.GetComponent<Animator>();
			this.OHLAKEFBHBD = JAHNHOCNJGM.GetComponent<Animation>();
			if (this.DJLMKHBHLLP)
			{
				return;
			}
			if (this.KCLACNEILLB == null && DMPKPIDHCNC)
			{
				this.KCLACNEILLB = JAHNHOCNJGM.GetComponentInChildren<Animator>();
			}
			if (this.OHLAKEFBHBD == null && DMPKPIDHCNC)
			{
				this.OHLAKEFBHBD = JAHNHOCNJGM.GetComponentInChildren<Animation>();
			}
			if (!this.DJLMKHBHLLP && JAHNHOCNJGM.parent != null)
			{
				this.ADJFBGEELOO(JAHNHOCNJGM.parent, false);
			}
		}

		// Token: 0x0600D167 RID: 53607 RVA: 0x005FE7EA File Offset: 0x005FC9EA
		private void POCOKCJDCHK()
		{
			if (this.OKHNNNCKKPI)
			{
				return;
			}
			if (!this.MEAOADDDHCJ())
			{
				this.GFCAOALODOF = true;
			}
			if (!this.GFCAOALODOF)
			{
				return;
			}
			this.GFCAOALODOF = false;
			this.DPFGGOJNKON();
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x0600D168 RID: 53608 RVA: 0x005FE81A File Offset: 0x005FCA1A
		private bool DJLMKHBHLLP
		{
			get
			{
				return this.KCLACNEILLB != null || this.OHLAKEFBHBD != null;
			}
		}

		// Token: 0x0600D169 RID: 53609 RVA: 0x005FE838 File Offset: 0x005FCA38
		private void BHDPDDHLPOI()
		{
			if (this.OKHNNNCKKPI)
			{
				return;
			}
			if (!this.ENDFHNMMNDG())
			{
				this.GFCAOALODOF = false;
			}
			if (!this.GFCAOALODOF)
			{
				return;
			}
			this.GFCAOALODOF = false;
			this.MBOPIBBAHOD();
		}

		// Token: 0x0600D16A RID: 53610 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void MPJFMFOPHKJ()
		{
		}

		// Token: 0x0600D16B RID: 53611 RVA: 0x005FE868 File Offset: 0x005FCA68
		private void FixedUpdate()
		{
			if (this.OKHNNNCKKPI)
			{
				this.OKHNNNCKKPI = false;
			}
			this.GFCAOALODOF = true;
			if (this.MKIDEJCAHPI && this.fixTransforms)
			{
				this.BLOEEPCIPKJ();
			}
		}

		// Token: 0x0600D16C RID: 53612 RVA: 0x005FE896 File Offset: 0x005FCA96
		public void GCEFJIPMGBE()
		{
			Debug.Log("", base.transform);
			base.enabled = false;
		}

		// Token: 0x0600D16D RID: 53613 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void MBOPIBBAHOD()
		{
		}

		// Token: 0x0600D16E RID: 53614 RVA: 0x005FE584 File Offset: 0x005FC784
		private void MCHAAIIHOKD()
		{
			this.BHALELINNDJ();
		}

		// Token: 0x0600D170 RID: 53616 RVA: 0x005FE5F7 File Offset: 0x005FC7F7
		private bool ENDFHNMMNDG()
		{
			if (this.KCLACNEILLB != null)
			{
				return this.KCLACNEILLB.updateMode == AnimatorUpdateMode.Normal;
			}
			return this.OHLAKEFBHBD != null && this.OHLAKEFBHBD.animatePhysics;
		}

		// Token: 0x0600D171 RID: 53617 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void GGDKOMKKEIG()
		{
		}

		// Token: 0x0600D172 RID: 53618 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void DPFGGOJNKON()
		{
		}

		// Token: 0x0600D173 RID: 53619 RVA: 0x005FE8BE File Offset: 0x005FCABE
		public void UpdateSolverExternal()
		{
			if (!base.enabled)
			{
				return;
			}
			this.OKHNNNCKKPI = true;
			this.MBOPIBBAHOD();
		}

		// Token: 0x0600D174 RID: 53620 RVA: 0x00022FCC File Offset: 0x000211CC
		protected virtual void DKKLHMINBAN()
		{
		}

		// Token: 0x0600D175 RID: 53621 RVA: 0x005FE522 File Offset: 0x005FC722
		private void OnDisable()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			this.BHALELINNDJ();
		}

		// Token: 0x04001BC1 RID: 7105
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms = true;

		// Token: 0x04001BC2 RID: 7106
		private Animator KCLACNEILLB;

		// Token: 0x04001BC3 RID: 7107
		private Animation OHLAKEFBHBD;

		// Token: 0x04001BC4 RID: 7108
		private bool GFCAOALODOF;

		// Token: 0x04001BC5 RID: 7109
		private bool GHLBOIJBOHB;

		// Token: 0x04001BC6 RID: 7110
		private bool OKHNNNCKKPI;
	}
}
