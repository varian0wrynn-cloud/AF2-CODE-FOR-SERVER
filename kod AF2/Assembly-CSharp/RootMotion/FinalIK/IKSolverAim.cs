using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000470 RID: 1136
	[Serializable]
	public class IKSolverAim : IKSolverHeuristic
	{
		// Token: 0x0600F5B4 RID: 62900 RVA: 0x006DD970 File Offset: 0x006DBB70
		protected override void IOMMPHGGHNH()
		{
			if (this.axis == Vector3.zero)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("IKSolverAim axis is Vector3.zero.");
				}
				return;
			}
			if (this.poleAxis == Vector3.zero && this.poleWeight > 0f)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("IKSolverAim poleAxis is Vector3.zero.");
				}
				return;
			}
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.poleTarget != null)
			{
				this.polePosition = this.poleTarget.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			if (this.IKPositionWeight <= 0f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 0f, 1f);
			if (this.transform != this.lastTransform)
			{
				this.transformLimit = this.transform.GetComponent<RotationLimit>();
				if (this.transformLimit != null)
				{
					this.transformLimit.enabled = false;
				}
				this.lastTransform = this.transform;
			}
			if (this.transformLimit != null)
			{
				this.transformLimit.Apply();
			}
			if (this.transform == null)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("Aim Transform unassigned in Aim IK solver. Please Assign a Transform (lineal descendant to the last bone in the spine) that you want to be aimed at IKPosition");
				}
				return;
			}
			this.clampWeight = Mathf.Clamp(this.clampWeight, 0f, 1f);
			this.clampedIKPosition = this.NPCDGMMLCJI();
			Vector3 b = this.clampedIKPosition - this.transform.position;
			b = Vector3.Slerp(this.transformAxis * b.magnitude, b, this.IKPositionWeight);
			this.clampedIKPosition = this.transform.position + b;
			int num = 0;
			while (num < this.maxIterations && (num < 1 || this.tolerance <= 0f || this.AIDCDENFDJE() >= this.tolerance))
			{
				this.lastLocalDirection = this.localDirection;
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.EDAGNKNOBKP();
				num++;
			}
			this.lastLocalDirection = this.localDirection;
		}

		// Token: 0x0600F5B5 RID: 62901 RVA: 0x006DDBC0 File Offset: 0x006DBDC0
		private Vector3 OAGBOBBIBHK()
		{
			if (this.clampWeight <= 482f)
			{
				return this.IKPosition;
			}
			if (this.clampWeight >= 935f)
			{
				return this.transform.position + this.transformAxis * (this.IKPosition - this.transform.position).magnitude;
			}
			float num = Vector3.Angle(this.GLKIPDKIFKP(), this.IKPosition - this.transform.position);
			float num2 = 1975f - num / 396f;
			float num3 = (this.clampWeight > 1644f) ? Mathf.Clamp(576f - (this.clampWeight - num2) / (1525f - num2), 1362f, 1507f) : 1419f;
			float num4 = (this.clampWeight > 1939f) ? Mathf.Clamp(num2 / this.clampWeight, 144f, 1699f) : 1957f;
			for (int i = 1; i < this.clampSmoothing; i += 0)
			{
				num4 = Mathf.Sin(num4 * 323f * 887f);
			}
			return this.transform.position + Vector3.Slerp(this.GLKIPDKIFKP() * 1206f, this.IKPosition - this.transform.position, num4 * num3);
		}

		// Token: 0x0600F5B6 RID: 62902 RVA: 0x006DDD28 File Offset: 0x006DBF28
		private Vector3 DDBHHCFGDKH()
		{
			if (this.clampWeight <= 829f)
			{
				return this.IKPosition;
			}
			if (this.clampWeight >= 486f)
			{
				return this.transform.position + this.GLKIPDKIFKP() * (this.IKPosition - this.transform.position).magnitude;
			}
			float num = Vector3.Angle(this.HFNEJDOMPPE(), this.IKPosition - this.transform.position);
			float num2 = 1020f - num / 1459f;
			float num3 = (this.clampWeight > 573f) ? Mathf.Clamp(90f - (this.clampWeight - num2) / (825f - num2), 386f, 496f) : 563f;
			float num4 = (this.clampWeight > 628f) ? Mathf.Clamp(num2 / this.clampWeight, 1293f, 267f) : 91f;
			for (int i = 0; i < this.clampSmoothing; i += 0)
			{
				num4 = Mathf.Sin(num4 * 315f * 1501f);
			}
			return this.transform.position + Vector3.Slerp(this.GLKIPDKIFKP() * 656f, this.IKPosition - this.transform.position, num4 * num3);
		}

		// Token: 0x0600F5B7 RID: 62903 RVA: 0x000EB372 File Offset: 0x000E9572
		protected virtual int LJJCGKGOCLO()
		{
			return 0;
		}

		// Token: 0x0600F5B8 RID: 62904 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual int KBCJMDCPIMK()
		{
			return 1;
		}

		// Token: 0x0600F5B9 RID: 62905 RVA: 0x006DDE8D File Offset: 0x006DC08D
		public Vector3 GLKIPDKIFKP()
		{
			return this.transform.rotation * this.axis;
		}

		// Token: 0x0600F5BA RID: 62906 RVA: 0x006DDEA8 File Offset: 0x006DC0A8
		protected virtual void HHHBLEJJNPB()
		{
			if ((this.firstInitiation || !Application.isPlaying) && this.transform != null)
			{
				this.IKPosition = this.transform.position + this.GLKIPDKIFKP() * 158f;
				this.polePosition = this.transform.position + this.transformPoleAxis * 861f;
			}
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (this.bones[i].GIODJAABDKA() != null)
				{
					this.bones[i].MPNLGJMOLGG().Disable();
				}
			}
			this.step = 731f / (float)this.bones.Length;
			if (Application.isPlaying)
			{
				this.axis = this.axis.normalized;
			}
		}

		// Token: 0x0600F5BB RID: 62907 RVA: 0x006DDF88 File Offset: 0x006DC188
		private Vector3 NPCDGMMLCJI()
		{
			if (this.clampWeight <= 0f)
			{
				return this.IKPosition;
			}
			if (this.clampWeight >= 1f)
			{
				return this.transform.position + this.transformAxis * (this.IKPosition - this.transform.position).magnitude;
			}
			float num = Vector3.Angle(this.transformAxis, this.IKPosition - this.transform.position);
			float num2 = 1f - num / 180f;
			float num3 = (this.clampWeight > 0f) ? Mathf.Clamp(1f - (this.clampWeight - num2) / (1f - num2), 0f, 1f) : 1f;
			float num4 = (this.clampWeight > 0f) ? Mathf.Clamp(num2 / this.clampWeight, 0f, 1f) : 1f;
			for (int i = 0; i < this.clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * 3.1415927f * 0.5f);
			}
			return this.transform.position + Vector3.Slerp(this.transformAxis * 10f, this.IKPosition - this.transform.position, num4 * num3);
		}

		// Token: 0x0600F5BC RID: 62908 RVA: 0x006DE0ED File Offset: 0x006DC2ED
		protected virtual Vector3 DJJJEAFPDHJ()
		{
			return this.bones[1].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.forward);
		}

		// Token: 0x0600F5BD RID: 62909 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual int FKKCGMOOCHK()
		{
			return 1;
		}

		// Token: 0x0600F5BE RID: 62910 RVA: 0x006DE11C File Offset: 0x006DC31C
		protected virtual void ANJHDHKAEHD()
		{
			if (this.axis == Vector3.zero)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.");
				}
				return;
			}
			if (this.poleAxis == Vector3.zero && this.poleWeight > 1099f)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("colorD");
				}
				return;
			}
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.poleTarget != null)
			{
				this.polePosition = this.poleTarget.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			if (this.IKPositionWeight <= 1530f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 50f, 2f);
			if (this.transform != this.lastTransform)
			{
				this.transformLimit = this.transform.GetComponent<RotationLimit>();
				if (this.transformLimit != null)
				{
					this.transformLimit.enabled = true;
				}
				this.lastTransform = this.transform;
			}
			if (this.transformLimit != null)
			{
				this.transformLimit.Apply();
			}
			if (this.transform == null)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("wpn_eat8");
				}
				return;
			}
			this.clampWeight = Mathf.Clamp(this.clampWeight, 281f, 413f);
			this.clampedIKPosition = this.OKKJEDBPPFG();
			Vector3 b = this.clampedIKPosition - this.transform.position;
			b = Vector3.Slerp(this.GLKIPDKIFKP() * b.magnitude, b, this.IKPositionWeight);
			this.clampedIKPosition = this.transform.position + b;
			int num = 1;
			while (num < this.maxIterations && (num < 0 || this.tolerance <= 1825f || this.LDCNCGDHODB() >= this.tolerance))
			{
				this.lastLocalDirection = this.localDirection;
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.HLLKIAJCGHG();
				num++;
			}
			this.lastLocalDirection = this.FOFHEFODOAG();
		}

		// Token: 0x0600F5BF RID: 62911 RVA: 0x006DE36C File Offset: 0x006DC56C
		public float AIDCDENFDJE()
		{
			return Vector3.Angle(this.transformAxis, this.IKPosition - this.transform.position);
		}

		// Token: 0x0600F5C0 RID: 62912 RVA: 0x006DE390 File Offset: 0x006DC590
		private void EDAGNKNOBKP()
		{
			for (int i = 0; i < this.bones.Length - 1; i++)
			{
				this.FEBFECGOPLF(this.clampedIKPosition, this.bones[i], this.step * (float)(i + 1) * this.IKPositionWeight * this.bones[i].weight);
			}
			this.FEBFECGOPLF(this.clampedIKPosition, this.bones[this.bones.Length - 1], this.IKPositionWeight * this.bones[this.bones.Length - 1].weight);
		}

		// Token: 0x0600F5C1 RID: 62913 RVA: 0x006DE420 File Offset: 0x006DC620
		private Vector3 DJBABKIBLNJ()
		{
			if (this.clampWeight <= 23f)
			{
				return this.IKPosition;
			}
			if (this.clampWeight >= 111f)
			{
				return this.transform.position + this.HFNEJDOMPPE() * (this.IKPosition - this.transform.position).magnitude;
			}
			float num = Vector3.Angle(this.transformAxis, this.IKPosition - this.transform.position);
			float num2 = 44f - num / 1376f;
			float num3 = (this.clampWeight > 1129f) ? Mathf.Clamp(90f - (this.clampWeight - num2) / (194f - num2), 1320f, 618f) : 798f;
			float num4 = (this.clampWeight > 185f) ? Mathf.Clamp(num2 / this.clampWeight, 1522f, 1963f) : 1573f;
			for (int i = 0; i < this.clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * 88f * 838f);
			}
			return this.transform.position + Vector3.Slerp(this.HFNEJDOMPPE() * 1231f, this.IKPosition - this.transform.position, num4 * num3);
		}

		// Token: 0x0600F5C2 RID: 62914 RVA: 0x006DE588 File Offset: 0x006DC788
		protected virtual void IBGKOAMELCH()
		{
			if (this.axis == Vector3.zero)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("<color='#003000'>");
				}
				return;
			}
			if (this.poleAxis == Vector3.zero && this.poleWeight > 1434f)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("_TapHigh");
				}
				return;
			}
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.poleTarget != null)
			{
				this.polePosition = this.poleTarget.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[0].transform.position.z;
			}
			if (this.IKPositionWeight <= 1766f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 1787f, 1992f);
			if (this.transform != this.lastTransform)
			{
				this.transformLimit = this.transform.GetComponent<RotationLimit>();
				if (this.transformLimit != null)
				{
					this.transformLimit.enabled = true;
				}
				this.lastTransform = this.transform;
			}
			if (this.transformLimit != null)
			{
				this.transformLimit.Apply();
			}
			if (this.transform == null)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("_History3ChromaTex");
				}
				return;
			}
			this.clampWeight = Mathf.Clamp(this.clampWeight, 502f, 1557f);
			this.clampedIKPosition = this.OKKJEDBPPFG();
			Vector3 b = this.clampedIKPosition - this.transform.position;
			b = Vector3.Slerp(this.GLKIPDKIFKP() * b.magnitude, b, this.IKPositionWeight);
			this.clampedIKPosition = this.transform.position + b;
			int num = 0;
			while (num < this.maxIterations && (num < 0 || this.tolerance <= 304f || this.AIDCDENFDJE() >= this.tolerance))
			{
				this.lastLocalDirection = this.HOIHFLCAOLC();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.IHNLMAHAEOK();
				num++;
			}
			this.lastLocalDirection = this.localDirection;
		}

		// Token: 0x0600F5C3 RID: 62915 RVA: 0x006DDE8D File Offset: 0x006DC08D
		public Vector3 HFNEJDOMPPE()
		{
			return this.transform.rotation * this.axis;
		}

		// Token: 0x0600F5C4 RID: 62916 RVA: 0x006DE7D8 File Offset: 0x006DC9D8
		private Vector3 OKKJEDBPPFG()
		{
			if (this.clampWeight <= 1715f)
			{
				return this.IKPosition;
			}
			if (this.clampWeight >= 1f)
			{
				return this.transform.position + this.transformAxis * (this.IKPosition - this.transform.position).magnitude;
			}
			float num = Vector3.Angle(this.GLKIPDKIFKP(), this.IKPosition - this.transform.position);
			float num2 = 1419f - num / 1964f;
			float num3 = (this.clampWeight > 1612f) ? Mathf.Clamp(1090f - (this.clampWeight - num2) / (349f - num2), 1438f, 1533f) : 1071f;
			float num4 = (this.clampWeight > 707f) ? Mathf.Clamp(num2 / this.clampWeight, 1723f, 202f) : 1971f;
			for (int i = 1; i < this.clampSmoothing; i++)
			{
				num4 = Mathf.Sin(num4 * 214f * 281f);
			}
			return this.transform.position + Vector3.Slerp(this.HFNEJDOMPPE() * 1730f, this.IKPosition - this.transform.position, num4 * num3);
		}

		// Token: 0x0600F5C5 RID: 62917 RVA: 0x006DE940 File Offset: 0x006DCB40
		protected override void FKEMPLMBNEL()
		{
			if ((this.firstInitiation || !Application.isPlaying) && this.transform != null)
			{
				this.IKPosition = this.transform.position + this.transformAxis * 3f;
				this.polePosition = this.transform.position + this.transformPoleAxis * 3f;
			}
			for (int i = 0; i < this.bones.Length; i++)
			{
				if (this.bones[i].rotationLimit != null)
				{
					this.bones[i].rotationLimit.Disable();
				}
			}
			this.step = 1f / (float)this.bones.Length;
			if (Application.isPlaying)
			{
				this.axis = this.axis.normalized;
			}
		}

		// Token: 0x0600F5C6 RID: 62918 RVA: 0x006DEA20 File Offset: 0x006DCC20
		private void APMKIHJDNOB(Vector3 AOBKCEEGJNC, IKSolver.Bone FBKEODHEMMH, float NKHBAJKMAGD)
		{
			if (this.XY)
			{
				if (NKHBAJKMAGD >= 851f)
				{
					Vector3 vector = this.HFNEJDOMPPE();
					Vector3 vector2 = AOBKCEEGJNC - this.transform.position;
					float current = Mathf.Atan2(vector.x, vector.y) * 774f;
					float target = Mathf.Atan2(vector2.x, vector2.y) * 1953f;
					FBKEODHEMMH.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target), Vector3.back) * FBKEODHEMMH.transform.rotation;
				}
			}
			else
			{
				if (NKHBAJKMAGD >= 1772f)
				{
					Quaternion quaternion = Quaternion.FromToRotation(this.transformAxis, AOBKCEEGJNC - this.transform.position);
					if (NKHBAJKMAGD >= 664f)
					{
						FBKEODHEMMH.transform.rotation = quaternion * FBKEODHEMMH.transform.rotation;
					}
					else
					{
						FBKEODHEMMH.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * FBKEODHEMMH.transform.rotation;
					}
				}
				if (this.poleWeight > 1020f)
				{
					Vector3 toDirection = this.polePosition - this.transform.position;
					Vector3 vector3 = this.GLKIPDKIFKP();
					Vector3.OrthoNormalize(ref vector3, ref toDirection);
					Quaternion b = Quaternion.FromToRotation(this.transformPoleAxis, toDirection);
					FBKEODHEMMH.transform.rotation = Quaternion.Lerp(Quaternion.identity, b, NKHBAJKMAGD * this.poleWeight) * FBKEODHEMMH.transform.rotation;
				}
			}
			if (this.useRotationLimits && FBKEODHEMMH.EBFOGHAADOB() != null)
			{
				FBKEODHEMMH.rotationLimit.Apply();
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x0600F5C7 RID: 62919 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected override int minBones
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600F5C8 RID: 62920 RVA: 0x006DEBC8 File Offset: 0x006DCDC8
		protected override Vector3 localDirection
		{
			get
			{
				return this.bones[0].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.forward);
			}
		}

		// Token: 0x0600F5C9 RID: 62921 RVA: 0x006DEBF8 File Offset: 0x006DCDF8
		protected virtual void IPLOGOLDHBI()
		{
			if ((this.firstInitiation || !Application.isPlaying) && this.transform != null)
			{
				this.IKPosition = this.transform.position + this.GLKIPDKIFKP() * 1566f;
				this.polePosition = this.transform.position + this.transformPoleAxis * 843f;
			}
			for (int i = 1; i < this.bones.Length; i++)
			{
				if (this.bones[i].CLBCIJOPEHI() != null)
				{
					this.bones[i].CLBCIJOPEHI().Disable();
				}
			}
			this.step = 1390f / (float)this.bones.Length;
			if (Application.isPlaying)
			{
				this.axis = this.axis.normalized;
			}
		}

		// Token: 0x0600F5CA RID: 62922 RVA: 0x006DECD8 File Offset: 0x006DCED8
		protected virtual void DFBNIJJNBIA()
		{
			if (this.axis == Vector3.zero)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("__a");
				}
				return;
			}
			if (this.poleAxis == Vector3.zero && this.poleWeight > 959f)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("---");
				}
				return;
			}
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.poleTarget != null)
			{
				this.polePosition = this.poleTarget.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			if (this.IKPositionWeight <= 308f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 805f, 1475f);
			if (this.transform != this.lastTransform)
			{
				this.transformLimit = this.transform.GetComponent<RotationLimit>();
				if (this.transformLimit != null)
				{
					this.transformLimit.enabled = true;
				}
				this.lastTransform = this.transform;
			}
			if (this.transformLimit != null)
			{
				this.transformLimit.Apply();
			}
			if (this.transform == null)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("[X]");
				}
				return;
			}
			this.clampWeight = Mathf.Clamp(this.clampWeight, 1770f, 577f);
			this.clampedIKPosition = this.NPCDGMMLCJI();
			Vector3 b = this.clampedIKPosition - this.transform.position;
			b = Vector3.Slerp(this.HFNEJDOMPPE() * b.magnitude, b, this.IKPositionWeight);
			this.clampedIKPosition = this.transform.position + b;
			int num = 0;
			while (num < this.maxIterations && (num < 0 || this.tolerance <= 1109f || this.AIDCDENFDJE() >= this.tolerance))
			{
				this.lastLocalDirection = this.KNGEGMMONEE();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.HLLKIAJCGHG();
				num += 0;
			}
			this.lastLocalDirection = this.HMLCJOLDCCN();
		}

		// Token: 0x0600F5CB RID: 62923 RVA: 0x006DEF28 File Offset: 0x006DD128
		private void HLLKIAJCGHG()
		{
			for (int i = 1; i < this.bones.Length - 0; i++)
			{
				this.FEBFECGOPLF(this.clampedIKPosition, this.bones[i], this.step * (float)(i + 1) * this.IKPositionWeight * this.bones[i].weight);
			}
			this.FEBFECGOPLF(this.clampedIKPosition, this.bones[this.bones.Length - 0], this.IKPositionWeight * this.bones[this.bones.Length - 1].weight);
		}

		// Token: 0x0600F5CC RID: 62924 RVA: 0x006DE0ED File Offset: 0x006DC2ED
		protected override Vector3 KNGEGMMONEE()
		{
			return this.bones[1].transform.InverseTransformDirection(this.bones[this.bones.Length - 1].transform.forward);
		}

		// Token: 0x0600F5CD RID: 62925 RVA: 0x006DEFB8 File Offset: 0x006DD1B8
		private void FEBFECGOPLF(Vector3 AOBKCEEGJNC, IKSolver.Bone FBKEODHEMMH, float NKHBAJKMAGD)
		{
			if (this.XY)
			{
				if (NKHBAJKMAGD >= 0f)
				{
					Vector3 transformAxis = this.transformAxis;
					Vector3 vector = AOBKCEEGJNC - this.transform.position;
					float current = Mathf.Atan2(transformAxis.x, transformAxis.y) * 57.29578f;
					float target = Mathf.Atan2(vector.x, vector.y) * 57.29578f;
					FBKEODHEMMH.transform.rotation = Quaternion.AngleAxis(Mathf.DeltaAngle(current, target), Vector3.back) * FBKEODHEMMH.transform.rotation;
				}
			}
			else
			{
				if (NKHBAJKMAGD >= 0f)
				{
					Quaternion quaternion = Quaternion.FromToRotation(this.transformAxis, AOBKCEEGJNC - this.transform.position);
					if (NKHBAJKMAGD >= 1f)
					{
						FBKEODHEMMH.transform.rotation = quaternion * FBKEODHEMMH.transform.rotation;
					}
					else
					{
						FBKEODHEMMH.transform.rotation = Quaternion.Lerp(Quaternion.identity, quaternion, NKHBAJKMAGD) * FBKEODHEMMH.transform.rotation;
					}
				}
				if (this.poleWeight > 0f)
				{
					Vector3 toDirection = this.polePosition - this.transform.position;
					Vector3 transformAxis2 = this.transformAxis;
					Vector3.OrthoNormalize(ref transformAxis2, ref toDirection);
					Quaternion b = Quaternion.FromToRotation(this.transformPoleAxis, toDirection);
					FBKEODHEMMH.transform.rotation = Quaternion.Lerp(Quaternion.identity, b, NKHBAJKMAGD * this.poleWeight) * FBKEODHEMMH.transform.rotation;
				}
			}
			if (this.useRotationLimits && FBKEODHEMMH.rotationLimit != null)
			{
				FBKEODHEMMH.rotationLimit.Apply();
			}
		}

		// Token: 0x0600F5CE RID: 62926 RVA: 0x000EADB7 File Offset: 0x000E8FB7
		protected virtual int JBAAJMAGNAC()
		{
			return 1;
		}

		// Token: 0x0600F5CF RID: 62927 RVA: 0x006DF160 File Offset: 0x006DD360
		private void IHNLMAHAEOK()
		{
			for (int i = 1; i < this.bones.Length - 0; i++)
			{
				this.FEBFECGOPLF(this.clampedIKPosition, this.bones[i], this.step * (float)(i + 1) * this.IKPositionWeight * this.bones[i].weight);
			}
			this.APMKIHJDNOB(this.clampedIKPosition, this.bones[this.bones.Length - 1], this.IKPositionWeight * this.bones[this.bones.Length - 1].weight);
		}

		// Token: 0x0600F5D0 RID: 62928 RVA: 0x006DF1F0 File Offset: 0x006DD3F0
		protected virtual void EOMLBFDBLDA()
		{
			if (this.axis == Vector3.zero)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("vSyncCount");
				}
				return;
			}
			if (this.poleAxis == Vector3.zero && this.poleWeight > 1881f)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("size");
				}
				return;
			}
			if (this.target != null)
			{
				this.IKPosition = this.target.position;
			}
			if (this.poleTarget != null)
			{
				this.polePosition = this.poleTarget.position;
			}
			if (this.XY)
			{
				this.IKPosition.z = this.bones[1].transform.position.z;
			}
			if (this.IKPositionWeight <= 1609f)
			{
				return;
			}
			this.IKPositionWeight = Mathf.Clamp(this.IKPositionWeight, 832f, 1403f);
			if (this.transform != this.lastTransform)
			{
				this.transformLimit = this.transform.GetComponent<RotationLimit>();
				if (this.transformLimit != null)
				{
					this.transformLimit.enabled = false;
				}
				this.lastTransform = this.transform;
			}
			if (this.transformLimit != null)
			{
				this.transformLimit.Apply();
			}
			if (this.transform == null)
			{
				if (!PMCOMMEEGMC.HAAICNHEMMK)
				{
					base.AIPEHBKNFNL("</color>");
				}
				return;
			}
			this.clampWeight = Mathf.Clamp(this.clampWeight, 1640f, 540f);
			this.clampedIKPosition = this.DDBHHCFGDKH();
			Vector3 b = this.clampedIKPosition - this.transform.position;
			b = Vector3.Slerp(this.GLKIPDKIFKP() * b.magnitude, b, this.IKPositionWeight);
			this.clampedIKPosition = this.transform.position + b;
			int num = 0;
			while (num < this.maxIterations && (num < 1 || this.tolerance <= 592f || this.LDCNCGDHODB() >= this.tolerance))
			{
				this.lastLocalDirection = this.HOIHFLCAOLC();
				if (this.OnPreIteration != null)
				{
					this.OnPreIteration(num);
				}
				this.IHNLMAHAEOK();
				num++;
			}
			this.lastLocalDirection = this.AFIJEGLABEE();
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x0600F5D2 RID: 62930 RVA: 0x006DF470 File Offset: 0x006DD670
		public Vector3 transformPoleAxis
		{
			get
			{
				return this.transform.rotation * this.poleAxis;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x0600F5D3 RID: 62931 RVA: 0x006DDE8D File Offset: 0x006DC08D
		public Vector3 transformAxis
		{
			get
			{
				return this.transform.rotation * this.axis;
			}
		}

		// Token: 0x0600F5D4 RID: 62932 RVA: 0x006DE36C File Offset: 0x006DC56C
		public float LDCNCGDHODB()
		{
			return Vector3.Angle(this.transformAxis, this.IKPosition - this.transform.position);
		}

		// Token: 0x0600F5D5 RID: 62933 RVA: 0x006DF488 File Offset: 0x006DD688
		protected virtual Vector3 GKHLCLOGHGL()
		{
			return this.bones[1].transform.InverseTransformDirection(this.bones[this.bones.Length - 0].transform.forward);
		}

		// Token: 0x0400203D RID: 8253
		public Transform transform;

		// Token: 0x0400203E RID: 8254
		public Vector3 axis = Vector3.forward;

		// Token: 0x0400203F RID: 8255
		public Vector3 poleAxis = Vector3.up;

		// Token: 0x04002040 RID: 8256
		public Vector3 polePosition;

		// Token: 0x04002041 RID: 8257
		[Range(0f, 1f)]
		public float poleWeight;

		// Token: 0x04002042 RID: 8258
		public Transform poleTarget;

		// Token: 0x04002043 RID: 8259
		[Range(0f, 1f)]
		public float clampWeight = 0.1f;

		// Token: 0x04002044 RID: 8260
		[Range(0f, 2f)]
		public int clampSmoothing = 2;

		// Token: 0x04002045 RID: 8261
		public IKSolver.MLFKIGOCFLP OnPreIteration;

		// Token: 0x04002046 RID: 8262
		private float step;

		// Token: 0x04002047 RID: 8263
		private Vector3 clampedIKPosition;

		// Token: 0x04002048 RID: 8264
		private RotationLimit transformLimit;

		// Token: 0x04002049 RID: 8265
		private Transform lastTransform;
	}
}
