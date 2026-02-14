using System;
using System.Collections;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004B4 RID: 1204
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060106F5 RID: 67317 RVA: 0x007549CA File Offset: 0x00752BCA
		protected float ENLHBNBNPJN
		{
			get
			{
				return Time.time - this.EDCFDDLFAHG;
			}
		}

		// Token: 0x060106F6 RID: 67318
		protected abstract void HEHOBGDMLOK();

		// Token: 0x060106F7 RID: 67319 RVA: 0x007549D8 File Offset: 0x00752BD8
		protected virtual void Start()
		{
			base.StartCoroutine(this.BHALELINNDJ());
		}

		// Token: 0x060106F8 RID: 67320 RVA: 0x007549E7 File Offset: 0x00752BE7
		private IEnumerator BHALELINNDJ()
		{
			while (this.ik == null)
			{
				yield return null;
			}
			IKSolverVR solver = this.ik.solver;
			solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Combine(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.MEGDOKAPBOL));
			this.EDCFDDLFAHG = Time.time;
			yield break;
		}

		// Token: 0x060106F9 RID: 67321 RVA: 0x007549F8 File Offset: 0x00752BF8
		private void MEGDOKAPBOL()
		{
			if (!base.enabled)
			{
				return;
			}
			if (this.weight <= 0f)
			{
				return;
			}
			if (this.ENLHBNBNPJN <= 0f)
			{
				return;
			}
			if (this.ik == null)
			{
				return;
			}
			this.weight = Mathf.Clamp(this.weight, 0f, 1f);
			this.HEHOBGDMLOK();
			this.EDCFDDLFAHG = Time.time;
		}

		// Token: 0x060106FA RID: 67322 RVA: 0x00754A65 File Offset: 0x00752C65
		protected virtual void OnDestroy()
		{
			if (this.ik != null)
			{
				IKSolverVR solver = this.ik.solver;
				solver.OnPreUpdate = (IKSolver.LGGEKCCEELN)Delegate.Remove(solver.OnPreUpdate, new IKSolver.LGGEKCCEELN(this.MEGDOKAPBOL));
			}
		}

		// Token: 0x0400225F RID: 8799
		[Tooltip("The master weight")]
		public float weight = 1f;

		// Token: 0x04002260 RID: 8800
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		// Token: 0x04002261 RID: 8801
		private float EDCFDDLFAHG;
	}
}
