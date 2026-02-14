using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000443 RID: 1091
	public abstract class Grounder : MonoBehaviour
	{
		// Token: 0x0600EB0A RID: 60170
		public abstract void ResetPosition();

		// Token: 0x0600EB0B RID: 60171 RVA: 0x006A4BE4 File Offset: 0x006A2DE4
		protected Vector3 LBBIAAIKLNC()
		{
			Vector3 vector = Vector3.zero;
			for (int i = 0; i < this.solver.legs.Length; i++)
			{
				vector += this.HNDCAEGEMOO(this.solver.legs[i]);
			}
			return vector;
		}

		// Token: 0x0600EB0C RID: 60172 RVA: 0x006992DE File Offset: 0x006974DE
		protected void AIPEHBKNFNL(string EDAPHMJENPK)
		{
			PMCOMMEEGMC.ICAFGKHAAED(EDAPHMJENPK, base.transform, false);
		}

		// Token: 0x0600EB0D RID: 60173 RVA: 0x006A4C2C File Offset: 0x006A2E2C
		private Vector3 HNDCAEGEMOO(Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			Vector3 a = this.ACKPAGLBIHI(AKIBINJJMHH);
			float d = (Vector3.Dot(this.solver.root.forward, a.normalized) + 1f) * 0.5f;
			float magnitude = (AKIBINJJMHH.CGAMODJNLAC - AKIBINJJMHH.LPBDALAMAEM.position).magnitude;
			return a * magnitude * d;
		}

		// Token: 0x0600EB0E RID: 60174 RVA: 0x006A4C98 File Offset: 0x006A2E98
		private Vector3 ACKPAGLBIHI(Grounding.IKFNCHNNKNK AKIBINJJMHH)
		{
			Vector3 vector = AKIBINJJMHH.LPBDALAMAEM.position - this.solver.root.position;
			if (!this.solver.rotateSolver || this.solver.root.up == Vector3.up)
			{
				return new Vector3(vector.x, 0f, vector.z);
			}
			Vector3 up = this.solver.root.up;
			Vector3.OrthoNormalize(ref up, ref vector);
			return vector;
		}

		// Token: 0x0600EB0F RID: 60175
		protected abstract void NLLHEACBOPP();

		// Token: 0x0600EB10 RID: 60176
		protected abstract void AFEMLFIOJIA();

		// Token: 0x04001EC4 RID: 7876
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x04001EC5 RID: 7877
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver = new Grounding();

		// Token: 0x04001EC6 RID: 7878
		public Grounder.HDALKKDPBKN OnPreGrounder;

		// Token: 0x04001EC7 RID: 7879
		public Grounder.HDALKKDPBKN OnPostGrounder;

		// Token: 0x04001EC8 RID: 7880
		protected bool EOFDOPLDFCG;

		// Token: 0x02000444 RID: 1092
		// (Invoke) Token: 0x0600EB13 RID: 60179
		public delegate void HDALKKDPBKN();
	}
}
