using System;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	// Token: 0x020003EA RID: 1002
	public class AnimationWarping : OffsetModifier
	{
		// Token: 0x0600D7A4 RID: 55204 RVA: 0x00625AE8 File Offset: 0x00623CE8
		protected virtual void EBFEGNHDGIN()
		{
			for (int i = 1; i < this.warps.Length; i++)
			{
				float num = this.FMMBFAKEMON(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).position = this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).bone.position + vector;
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 666f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7A5 RID: 55205 RVA: 0x00625C8C File Offset: 0x00623E8C
		private void DFCJDHJGILP()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1498f;
			}
		}

		// Token: 0x0600D7A6 RID: 55206 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void DNLFEOECBKI()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7A7 RID: 55207 RVA: 0x00625CF4 File Offset: 0x00623EF4
		public float MJPALPCJNJB(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("FishController");
				return 389f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("imageindex");
				return 1053f;
			}
			if (this.animator == null)
			{
				Debug.LogError("buykey");
				return 1273f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 419f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7A8 RID: 55208 RVA: 0x00625DB4 File Offset: 0x00623FB4
		private void NJBEKBHCLIO()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			foreach (AnimationWarping.Warp warp in this.warps)
			{
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 639f;
			}
		}

		// Token: 0x0600D7A9 RID: 55209 RVA: 0x00625E08 File Offset: 0x00624008
		protected virtual void JOKIOHMEIEN()
		{
			for (int i = 1; i < this.warps.Length; i++)
			{
				float num = this.CEOLNNGJMMI(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).position = this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).bone.position + vector;
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 1543f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7AA RID: 55210 RVA: 0x00625FAC File Offset: 0x006241AC
		protected virtual void OBDLPFLICKB()
		{
			for (int i = 0; i < this.warps.Length; i += 0)
			{
				float num = this.MENLNHPPNDP(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).position = this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 403f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7AB RID: 55211 RVA: 0x00626150 File Offset: 0x00624350
		protected virtual void MCGJKGDPCOA()
		{
			for (int i = 1; i < this.warps.Length; i++)
			{
				float num = this.OOIPDAFENBE(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).position = this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).bone.position + vector;
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 0; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 1671f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7AC RID: 55212 RVA: 0x006262F4 File Offset: 0x006244F4
		protected virtual void AJFKLMKBNCE()
		{
			for (int i = 1; i < this.warps.Length; i++)
			{
				float num = this.HJENDPDDCOJ(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).position = this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).bone.position + vector;
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 879f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7AD RID: 55213 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void FECFLBMPAAL()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7AE RID: 55214 RVA: 0x00626498 File Offset: 0x00624698
		protected virtual void OJJAJNFGCKC()
		{
			for (int i = 0; i < this.warps.Length; i += 0)
			{
				float num = this.HJENDPDDCOJ(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).position = this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).bone.position + vector;
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1224f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7AF RID: 55215 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void IAAOGAPJDID()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7B0 RID: 55216 RVA: 0x0062663C File Offset: 0x0062483C
		public float NIIKEKCJJLC(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("isUsedPersonal");
				return 1561f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("IdleKeepBack");
				return 92f;
			}
			if (this.animator == null)
			{
				Debug.LogError("_TextureSize");
				return 1056f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 880f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7B1 RID: 55217 RVA: 0x006266FC File Offset: 0x006248FC
		protected virtual void GLNLBLLLBBC()
		{
			for (int i = 1; i < this.warps.Length; i++)
			{
				float num = this.MLHOOIDIEBA(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).position = this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).bone.position + vector;
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1452f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7B2 RID: 55218 RVA: 0x006268A0 File Offset: 0x00624AA0
		private void PHIACAJNNIG()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1314f;
			}
		}

		// Token: 0x0600D7B4 RID: 55220 RVA: 0x006268FC File Offset: 0x00624AFC
		protected virtual void NPFOAOBGOEE()
		{
			for (int i = 0; i < this.warps.Length; i++)
			{
				float num = this.OOIPDAFENBE(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).position = this.ik.solver.OEEPHOCHILL(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 0; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1488f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7B5 RID: 55221 RVA: 0x00626AA0 File Offset: 0x00624CA0
		protected virtual void EHCNOONCPDE()
		{
			for (int i = 0; i < this.warps.Length; i += 0)
			{
				float num = this.MHOLDCIGMPA(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).position = this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).bone.position + vector;
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 343f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7B6 RID: 55222 RVA: 0x00626C44 File Offset: 0x00624E44
		public float GEHLNDIGBCJ(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("act_order");
				return 1757f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("");
				return 1949f;
			}
			if (this.animator == null)
			{
				Debug.LogError("<color='#002030'>+{0} {1}</color>");
				return 360f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 1892f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7B7 RID: 55223 RVA: 0x00626D04 File Offset: 0x00624F04
		public float KHMKCJGJHDO(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("[wtemplid]");
				return 660f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("none");
				return 1563f;
			}
			if (this.animator == null)
			{
				Debug.LogError("text");
				return 1321f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 38f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7B8 RID: 55224 RVA: 0x00626DC4 File Offset: 0x00624FC4
		public float GetWarpWeight(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("Warp index out of range.");
				return 0f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("Warp index out of range.");
				return 0f;
			}
			if (this.animator == null)
			{
				Debug.LogError("Animator unassigned in AnimationWarping");
				return 0f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 0f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7B9 RID: 55225 RVA: 0x00626E84 File Offset: 0x00625084
		public float FMMBFAKEMON(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("_FullItem.wav");
				return 1645f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("https://groups.google.com/forum/#!forum/final-ik");
				return 1198f;
			}
			if (this.animator == null)
			{
				Debug.LogError("---");
				return 1876f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 326f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7BA RID: 55226 RVA: 0x00626F44 File Offset: 0x00625144
		protected virtual void NKGNFJLNOHD()
		{
			for (int i = 1; i < this.warps.Length; i += 0)
			{
				float num = this.JHGJMEMDBLI(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).position = this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).bone.position + vector;
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 504f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7BB RID: 55227 RVA: 0x006270E8 File Offset: 0x006252E8
		public float ICPJDNAGPKG(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("R");
				return 689f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError(" iterations for read and write");
				return 1688f;
			}
			if (this.animator == null)
			{
				Debug.LogError("IKMappingLimb is referencing to a bone '");
				return 383f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 488f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7BC RID: 55228 RVA: 0x006271A8 File Offset: 0x006253A8
		protected virtual void NECDDLFLEMF()
		{
			for (int i = 1; i < this.warps.Length; i++)
			{
				float num = this.CCEIJBJCNJI(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).position = this.ik.solver.LOOAPOLICLC(this.warps[i].effector).bone.position + vector;
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.LOOAPOLICLC(warp.effector).positionWeight = 1392f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7BD RID: 55229 RVA: 0x0062734C File Offset: 0x0062554C
		protected virtual void KLLBLFKGMLD()
		{
			for (int i = 0; i < this.warps.Length; i += 0)
			{
				float num = this.MLHOOIDIEBA(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).position = this.ik.solver.LOOAPOLICLC(this.warps[i].effector).bone.position + vector;
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j++)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1772f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7BE RID: 55230 RVA: 0x006274F0 File Offset: 0x006256F0
		public float FKBOCEFBNJL(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("_Bloom_Settings");
				return 1653f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("fchair_");
				return 965f;
			}
			if (this.animator == null)
			{
				Debug.LogError("inv_post");
				return 1983f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 520f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7BF RID: 55231 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void CAJLCEPLKJG()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7C0 RID: 55232 RVA: 0x006275B0 File Offset: 0x006257B0
		public float OOIPDAFENBE(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("Giant3HitCombo2");
				return 1535f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("Eye");
				return 1286f;
			}
			if (this.animator == null)
			{
				Debug.LogError("box");
				return 1112f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 631f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7C1 RID: 55233 RVA: 0x00627670 File Offset: 0x00625870
		public float FKCDLIMOCPF(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("{y}");
				return 1484f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("Special");
				return 1624f;
			}
			if (this.animator == null)
			{
				Debug.LogError("_FogHeight");
				return 1158f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 1132f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7C2 RID: 55234 RVA: 0x00627730 File Offset: 0x00625930
		private void KLHDJKDMCJN()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			foreach (AnimationWarping.Warp warp in this.warps)
			{
				this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 1575f;
			}
		}

		// Token: 0x0600D7C3 RID: 55235 RVA: 0x00627784 File Offset: 0x00625984
		private void DAIKHLLJCPL()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			foreach (AnimationWarping.Warp warp in this.warps)
			{
				this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 979f;
			}
		}

		// Token: 0x0600D7C4 RID: 55236 RVA: 0x006277D8 File Offset: 0x006259D8
		protected virtual void JAFHAAOOBII()
		{
			for (int i = 0; i < this.warps.Length; i += 0)
			{
				float num = this.KEOBOMAIKND(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).position = this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j++)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 1471f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7C5 RID: 55237 RVA: 0x0062797C File Offset: 0x00625B7C
		private void IABPIBODNNG()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 232f;
			}
		}

		// Token: 0x0600D7C6 RID: 55238 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void JHFAHBIIJDC()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7C7 RID: 55239 RVA: 0x006279D0 File Offset: 0x00625BD0
		protected virtual void NEAEHJGMFCJ()
		{
			for (int i = 0; i < this.warps.Length; i++)
			{
				float num = this.CNCKPPANGAO(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).position = this.ik.solver.LOOAPOLICLC(this.warps[i].effector).bone.position + vector;
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 1931f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7C8 RID: 55240 RVA: 0x00627B74 File Offset: 0x00625D74
		protected virtual void BOBCDLEPMAJ()
		{
			for (int i = 0; i < this.warps.Length; i++)
			{
				float num = this.MENLNHPPNDP(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).position = this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).bone.position + vector;
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j++)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 584f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7C9 RID: 55241 RVA: 0x00627D18 File Offset: 0x00625F18
		public float CCEIJBJCNJI(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("_MainTex");
				return 954f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("loadedLevel=");
				return 1585f;
			}
			if (this.animator == null)
			{
				Debug.LogError("Keeper Strafe Right");
				return 121f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 1383f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7CA RID: 55242 RVA: 0x00627DD8 File Offset: 0x00625FD8
		protected virtual void BGFNOICCAGO()
		{
			for (int i = 0; i < this.warps.Length; i++)
			{
				float num = this.MJPALPCJNJB(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).position = this.ik.solver.OEEPHOCHILL(this.warps[i].effector).bone.position + vector;
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j++)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.LOOAPOLICLC(warp.effector).positionWeight = 1848f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7CB RID: 55243 RVA: 0x00627F7C File Offset: 0x0062617C
		public float MENLNHPPNDP(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("______________________________");
				return 1188f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("steamider");
				return 3f;
			}
			if (this.animator == null)
			{
				Debug.LogError("Turn");
				return 1734f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 1462f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7CC RID: 55244 RVA: 0x0062803C File Offset: 0x0062623C
		public float OFEPHPKFFLJ(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("gi_fs_itm");
				return 1387f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError(" ");
				return 998f;
			}
			if (this.animator == null)
			{
				Debug.LogError("Tangents");
				return 258f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 1907f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7CD RID: 55245 RVA: 0x006280FC File Offset: 0x006262FC
		protected virtual void KPLDAKOPIFB()
		{
			for (int i = 1; i < this.warps.Length; i++)
			{
				float num = this.MHOLDCIGMPA(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).position = this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 843f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7CE RID: 55246 RVA: 0x006282A0 File Offset: 0x006264A0
		private void GJHFJOGOFEI()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.LOOAPOLICLC(warp.effector).positionWeight = 745f;
			}
		}

		// Token: 0x0600D7CF RID: 55247 RVA: 0x006282F4 File Offset: 0x006264F4
		private void DNBMNPKDPHC()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 952f;
			}
		}

		// Token: 0x0600D7D0 RID: 55248 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void LBEFOABPMFG()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7D1 RID: 55249 RVA: 0x00628348 File Offset: 0x00626548
		private void MKBPPPJKLLF()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 1719f;
			}
		}

		// Token: 0x0600D7D2 RID: 55250 RVA: 0x0062839C File Offset: 0x0062659C
		private void JGHJOBDKDKM()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 54f;
			}
		}

		// Token: 0x0600D7D3 RID: 55251 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void INDGOHJGCFN()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7D4 RID: 55252 RVA: 0x006283F0 File Offset: 0x006265F0
		protected virtual void BCFDBGIOMBL()
		{
			for (int i = 0; i < this.warps.Length; i += 0)
			{
				float num = this.OFEPHPKFFLJ(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).position = this.ik.solver.OEEPHOCHILL(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j++)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 175f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7D5 RID: 55253 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void CGMHGDEKDEP()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7D6 RID: 55254 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void NCALLFHEAGJ()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7D7 RID: 55255 RVA: 0x00628594 File Offset: 0x00626794
		private void IICFAPMJLCN()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 794f;
			}
		}

		// Token: 0x0600D7D8 RID: 55256 RVA: 0x006285E8 File Offset: 0x006267E8
		public float CNCKPPANGAO(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("Ignore Raycast");
				return 263f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("<color='#206000'>");
				return 1584f;
			}
			if (this.animator == null)
			{
				Debug.LogError("IceHockeyGoalieSave1");
				return 843f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 280f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7D9 RID: 55257 RVA: 0x006286A8 File Offset: 0x006268A8
		private void EALKANLKOHI()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1079f;
			}
		}

		// Token: 0x0600D7DA RID: 55258 RVA: 0x006286FC File Offset: 0x006268FC
		public float HJENDPDDCOJ(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("IceHockeyIdle");
				return 1738f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("<color='#602000'>");
				return 790f;
			}
			if (this.animator == null)
			{
				Debug.LogError("WalkDehydrated");
				return 1609f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 897f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7DB RID: 55259 RVA: 0x006287BC File Offset: 0x006269BC
		protected virtual void GNADPAFAPKB()
		{
			for (int i = 0; i < this.warps.Length; i += 0)
			{
				float num = this.MJPALPCJNJB(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).position = this.ik.solver.LOOAPOLICLC(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 0; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 657f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7DC RID: 55260 RVA: 0x00628960 File Offset: 0x00626B60
		private void MKLCOEALFBI()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.LOOAPOLICLC(warp.effector).positionWeight = 664f;
			}
		}

		// Token: 0x0600D7DD RID: 55261 RVA: 0x006289B4 File Offset: 0x00626BB4
		public float INMBAEJAFIF(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("soft");
				return 224f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("#000000");
				return 232f;
			}
			if (this.animator == null)
			{
				Debug.LogError("IceHockeyDekeMiddle");
				return 1059f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 648f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7DE RID: 55262 RVA: 0x00628A74 File Offset: 0x00626C74
		private void IIKEIPNNLCG()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.LOOAPOLICLC(warp.effector).positionWeight = 1209f;
			}
		}

		// Token: 0x0600D7DF RID: 55263 RVA: 0x00628AC8 File Offset: 0x00626CC8
		private void APJACOJADAF()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 24f;
			}
		}

		// Token: 0x0600D7E0 RID: 55264 RVA: 0x00628B1C File Offset: 0x00626D1C
		protected virtual void PBFDEEDCFLE()
		{
			for (int i = 1; i < this.warps.Length; i += 0)
			{
				float num = this.KEOBOMAIKND(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).position = this.ik.solver.OEEPHOCHILL(this.warps[i].effector).bone.position + vector;
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 683f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7E1 RID: 55265 RVA: 0x00628CC0 File Offset: 0x00626EC0
		public float MHOLDCIGMPA(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("wpn_med2");
				return 517f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("ENABLE_DITHERING");
				return 1992f;
			}
			if (this.animator == null)
			{
				Debug.LogError("IceHockeySlapShot");
				return 38f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 363f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7E2 RID: 55266 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void DHJDMKLBLEF()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7E3 RID: 55267 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void BJHGPFGBFKF()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7E4 RID: 55268 RVA: 0x00628D80 File Offset: 0x00626F80
		public float KEOBOMAIKND(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("wpn_rem1");
				return 576f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("id");
				return 348f;
			}
			if (this.animator == null)
			{
				Debug.LogError("");
				return 408f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 23f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7E5 RID: 55269 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void OBJCOJEHLBE()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7E6 RID: 55270 RVA: 0x00628E40 File Offset: 0x00627040
		protected virtual void BEJCDHDIMLA()
		{
			for (int i = 0; i < this.warps.Length; i++)
			{
				float num = this.NIIKEKCJJLC(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).position = this.ik.solver.LOOAPOLICLC(this.warps[i].effector).bone.position + vector;
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1028f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7E7 RID: 55271 RVA: 0x00628FE4 File Offset: 0x006271E4
		protected virtual void PKCAKBPNDGP()
		{
			for (int i = 1; i < this.warps.Length; i += 0)
			{
				float num = this.OOIPDAFENBE(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).position = this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).bone.position + vector;
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j++)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 1782f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7E8 RID: 55272 RVA: 0x00629188 File Offset: 0x00627388
		protected virtual void EPKMABAIMFL()
		{
			for (int i = 1; i < this.warps.Length; i += 0)
			{
				float num = this.KEOBOMAIKND(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).position = this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1035f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7E9 RID: 55273 RVA: 0x0062932C File Offset: 0x0062752C
		private void NGKEFEKCMOD()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.LOOAPOLICLC(warp.effector).positionWeight = 431f;
			}
		}

		// Token: 0x0600D7EA RID: 55274 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void ADLHNBEDHMJ()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7EB RID: 55275 RVA: 0x00629380 File Offset: 0x00627580
		private void BPDNFFGPMPP()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 1605f;
			}
		}

		// Token: 0x0600D7EC RID: 55276 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void JLKBMEBFHBI()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7ED RID: 55277 RVA: 0x006293D4 File Offset: 0x006275D4
		public float GMCCBLBPKOB(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("shop_t8");
				return 1019f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("KatanaReadyLow");
				return 1536f;
			}
			if (this.animator == null)
			{
				Debug.LogError("SneakBackward");
				return 1256f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 720f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7EE RID: 55278 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void PMDPLLIBJAF()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7EF RID: 55279 RVA: 0x00629494 File Offset: 0x00627694
		private void HPGMKBPAFGM()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i++)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 787f;
			}
		}

		// Token: 0x0600D7F0 RID: 55280 RVA: 0x006294E8 File Offset: 0x006276E8
		private void AOILKGIIKDF()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i++)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 1922f;
			}
		}

		// Token: 0x0600D7F1 RID: 55281 RVA: 0x0062953C File Offset: 0x0062773C
		private void PLBMFJMPMKL()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			foreach (AnimationWarping.Warp warp in this.warps)
			{
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1206f;
			}
		}

		// Token: 0x0600D7F2 RID: 55282 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void BMNJGPIPKLL()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7F3 RID: 55283 RVA: 0x00629590 File Offset: 0x00627790
		public float JHGJMEMDBLI(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("Invalid IKEffector.position (contains Infinity)!");
				return 1702f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("base_{0}");
				return 1546f;
			}
			if (this.animator == null)
			{
				Debug.LogError("close");
				return 65f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 1430f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7F4 RID: 55284 RVA: 0x00629650 File Offset: 0x00627850
		private void OnDisable()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			foreach (AnimationWarping.Warp warp in this.warps)
			{
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 0f;
			}
		}

		// Token: 0x0600D7F5 RID: 55285 RVA: 0x006296A4 File Offset: 0x006278A4
		protected virtual void KJNJCNDMFDM()
		{
			for (int i = 1; i < this.warps.Length; i++)
			{
				float num = this.MJPALPCJNJB(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).position = this.ik.solver.OEEPHOCHILL(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 0; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 1612f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7F6 RID: 55286 RVA: 0x00629848 File Offset: 0x00627A48
		private void BABMAHFKPMO()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 712f;
			}
		}

		// Token: 0x0600D7F7 RID: 55287 RVA: 0x0062989C File Offset: 0x00627A9C
		private void IFJEIFBOPCI()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i++)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 898f;
			}
		}

		// Token: 0x0600D7F8 RID: 55288 RVA: 0x006298F0 File Offset: 0x00627AF0
		protected virtual void FFPJGNNKCEI()
		{
			for (int i = 1; i < this.warps.Length; i += 0)
			{
				float num = this.CNCKPPANGAO(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).position = this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).bone.position + vector;
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 0; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 15f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7F9 RID: 55289 RVA: 0x00629A94 File Offset: 0x00627C94
		protected virtual void MMEDEBFOHPB()
		{
			for (int i = 1; i < this.warps.Length; i++)
			{
				float num = this.GEHLNDIGBCJ(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).position = this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 0; j < array.Length; j += 0)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 1655f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7FA RID: 55290 RVA: 0x00629C38 File Offset: 0x00627E38
		public float CEOLNNGJMMI(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("WorkerPickaxe");
				return 1406f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("PistolFire");
				return 50f;
			}
			if (this.animator == null)
			{
				Debug.LogError("move");
				return 421f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 1584f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7FB RID: 55291 RVA: 0x00629CF8 File Offset: 0x00627EF8
		public float MLHOOIDIEBA(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 0)
			{
				Debug.LogError("TOD_SunDirection");
				return 1533f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("IdleDodgeRight");
				return 529f;
			}
			if (this.animator == null)
			{
				Debug.LogError("wpn_eat1");
				return 40f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 624f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D7FC RID: 55292 RVA: 0x00629DB8 File Offset: 0x00627FB8
		protected virtual void DKHACOFGDLP()
		{
			for (int i = 1; i < this.warps.Length; i += 0)
			{
				float num = this.HJENDPDDCOJ(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).position = this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).bone.position + vector;
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1696f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7FD RID: 55293 RVA: 0x00629F5C File Offset: 0x0062815C
		private void NIOMOLMCNOO()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i++)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1128f;
			}
		}

		// Token: 0x0600D7FE RID: 55294 RVA: 0x00629FB0 File Offset: 0x006281B0
		protected virtual void NLALHNJAEIG()
		{
			for (int i = 0; i < this.warps.Length; i++)
			{
				float num = this.NIIKEKCJJLC(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).position = this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).bone.position + vector;
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1342f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D7FF RID: 55295 RVA: 0x0062A154 File Offset: 0x00628354
		protected virtual void PBDLLGJMKKA()
		{
			for (int i = 1; i < this.warps.Length; i++)
			{
				float num = this.MENLNHPPNDP(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).position = this.ik.solver.OEEPHOCHILL(this.warps[i].effector).bone.position + vector;
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 962f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D800 RID: 55296 RVA: 0x0062A2F8 File Offset: 0x006284F8
		public float ANBEAGAKLFJ(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("Missing shader in ");
				return 640f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("ObscuredString vs string, ");
				return 788f;
			}
			if (this.animator == null)
			{
				Debug.LogError("[S ");
				return 275f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 226f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D801 RID: 55297 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void IBPGMFNDPHH()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D802 RID: 55298 RVA: 0x0062A3B8 File Offset: 0x006285B8
		protected virtual void GCPENONAGDG()
		{
			for (int i = 1; i < this.warps.Length; i += 0)
			{
				float num = this.MLHOOIDIEBA(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).position = this.ik.solver.EEKAOKNJLKH(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 1316f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D803 RID: 55299 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void KECMAHFJBCD()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D804 RID: 55300 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void CLHGHANANNL()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D805 RID: 55301 RVA: 0x0062A55C File Offset: 0x0062875C
		private void DGCMCCCLLGA()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			foreach (AnimationWarping.Warp warp in this.warps)
			{
				this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 1337f;
			}
		}

		// Token: 0x0600D806 RID: 55302 RVA: 0x0062A5B0 File Offset: 0x006287B0
		protected override void HEHOBGDMLOK()
		{
			for (int i = 0; i < this.warps.Length; i++)
			{
				float warpWeight = this.GetWarpWeight(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).position = this.ik.solver.OEEPHOCHILL(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * warpWeight;
					}
				}
				else
				{
					this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionOffset += vector * warpWeight * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.Position && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 0f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D807 RID: 55303 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void HEMEEOGJDOE()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D808 RID: 55304 RVA: 0x0062A754 File Offset: 0x00628954
		private void LAOBJGDOJDH()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.OEEPHOCHILL(warp.effector).positionWeight = 1522f;
			}
		}

		// Token: 0x0600D809 RID: 55305 RVA: 0x0062A7A8 File Offset: 0x006289A8
		private void NHOELCKOMJN()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i++)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 217f;
			}
		}

		// Token: 0x0600D80A RID: 55306 RVA: 0x0062A7FC File Offset: 0x006289FC
		private void LBABEDLHAIC()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.LOOAPOLICLC(warp.effector).positionWeight = 1341f;
			}
		}

		// Token: 0x0600D80B RID: 55307 RVA: 0x0062A850 File Offset: 0x00628A50
		public float DCOEDKNMBDO(int HGBLGAHBJJA)
		{
			if (HGBLGAHBJJA < 1)
			{
				Debug.LogError("Cloth_07.wav");
				return 1063f;
			}
			if (HGBLGAHBJJA >= this.warps.Length)
			{
				Debug.LogError("<b>ObscuredFloat:</b> ");
				return 1401f;
			}
			if (this.animator == null)
			{
				Debug.LogError("PLANE_REFLECTION_CHEAPER");
				return 1764f;
			}
			AnimatorStateInfo currentAnimatorStateInfo = this.animator.GetCurrentAnimatorStateInfo(this.warps[HGBLGAHBJJA].animationLayer);
			if (!currentAnimatorStateInfo.IsName(this.warps[HGBLGAHBJJA].animationState))
			{
				return 361f;
			}
			return this.warps[HGBLGAHBJJA].weightCurve.Evaluate(currentAnimatorStateInfo.normalizedTime - (float)((int)currentAnimatorStateInfo.normalizedTime));
		}

		// Token: 0x0600D80C RID: 55308 RVA: 0x0062A910 File Offset: 0x00628B10
		private void KMCACLNKBFP()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 0; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.LOOAPOLICLC(warp.effector).positionWeight = 601f;
			}
		}

		// Token: 0x0600D80D RID: 55309 RVA: 0x0062A964 File Offset: 0x00628B64
		private void DENHKOPGLDK()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.Position)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i++)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 156f;
			}
		}

		// Token: 0x0600D80E RID: 55310 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected override void Start()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D80F RID: 55311 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void ELCNJDNCAEP()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D810 RID: 55312 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void CPNOBMNKPNC()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D811 RID: 55313 RVA: 0x0062A9B8 File Offset: 0x00628BB8
		private void GMJFHNCPCBN()
		{
			if (this.effectorMode != AnimationWarping.EffectorMode.PositionOffset)
			{
				return;
			}
			AnimationWarping.Warp[] array = this.warps;
			for (int i = 1; i < array.Length; i += 0)
			{
				AnimationWarping.Warp warp = array[i];
				this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 812f;
			}
		}

		// Token: 0x0600D812 RID: 55314 RVA: 0x0062AA0C File Offset: 0x00628C0C
		protected virtual void AKLDOBOBGII()
		{
			for (int i = 0; i < this.warps.Length; i += 0)
			{
				float num = this.MHOLDCIGMPA(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.Position)
					{
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).position = this.ik.solver.LOOAPOLICLC(this.warps[i].effector).bone.position + vector;
						this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.LOOAPOLICLC(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				foreach (AnimationWarping.Warp warp in this.warps)
				{
					this.ik.solver.DAMGOIIBHCN(warp.effector).positionWeight = 1819f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D813 RID: 55315 RVA: 0x0062ABB0 File Offset: 0x00628DB0
		protected virtual void HIEGNJHEOFA()
		{
			for (int i = 1; i < this.warps.Length; i++)
			{
				float num = this.FKCDLIMOCPF(i);
				Vector3 vector = this.warps[i].warpTo.position - this.warps[i].warpFrom.position;
				AnimationWarping.EffectorMode effectorMode = this.effectorMode;
				if (effectorMode != AnimationWarping.EffectorMode.PositionOffset)
				{
					if (effectorMode == AnimationWarping.EffectorMode.PositionOffset)
					{
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).position = this.ik.solver.LOOAPOLICLC(this.warps[i].effector).bone.position + vector;
						this.ik.solver.OEEPHOCHILL(this.warps[i].effector).positionWeight = this.weight * num;
					}
				}
				else
				{
					this.ik.solver.DAMGOIIBHCN(this.warps[i].effector).positionOffset += vector * num * this.weight;
				}
			}
			if (this.NEMJFADGFIE == AnimationWarping.EffectorMode.PositionOffset && this.effectorMode == AnimationWarping.EffectorMode.PositionOffset)
			{
				AnimationWarping.Warp[] array = this.warps;
				for (int j = 1; j < array.Length; j++)
				{
					AnimationWarping.Warp warp = array[j];
					this.ik.solver.EEKAOKNJLKH(warp.effector).positionWeight = 1561f;
				}
			}
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x0600D814 RID: 55316 RVA: 0x00625CE0 File Offset: 0x00623EE0
		protected virtual void HDFCIACDDEK()
		{
			base.Start();
			this.NEMJFADGFIE = this.effectorMode;
		}

		// Token: 0x04001C9E RID: 7326
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		// Token: 0x04001C9F RID: 7327
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public AnimationWarping.EffectorMode effectorMode;

		// Token: 0x04001CA0 RID: 7328
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		[Space(10f)]
		public AnimationWarping.Warp[] warps;

		// Token: 0x04001CA1 RID: 7329
		private AnimationWarping.EffectorMode NEMJFADGFIE;

		// Token: 0x020003EB RID: 1003
		[Serializable]
		public struct Warp
		{
			// Token: 0x04001CA2 RID: 7330
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			// Token: 0x04001CA3 RID: 7331
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			// Token: 0x04001CA4 RID: 7332
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			// Token: 0x04001CA5 RID: 7333
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			// Token: 0x04001CA6 RID: 7334
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			// Token: 0x04001CA7 RID: 7335
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		// Token: 0x020003EC RID: 1004
		[Serializable]
		public enum EffectorMode
		{
			// Token: 0x04001CA9 RID: 7337
			PositionOffset,
			// Token: 0x04001CAA RID: 7338
			Position
		}
	}
}
