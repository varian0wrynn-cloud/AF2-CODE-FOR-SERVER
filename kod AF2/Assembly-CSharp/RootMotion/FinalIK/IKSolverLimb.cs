using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x02000479 RID: 1145
	[Serializable]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		// Token: 0x0600F944 RID: 63812 RVA: 0x006FDF74 File Offset: 0x006FC174
		protected virtual void PDEOHHBOBNK()
		{
			if (this.IKPositionWeight > 1924f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 107f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F945 RID: 63813 RVA: 0x006FDFE8 File Offset: 0x006FC1E8
		protected virtual void CACJALNOGND()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.CLBCIJOPEHI() != null)
			{
				this.bone3.GIODJAABDKA().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.HDBCMGFMELG(ref this.axisDirectionsLeft);
			this.BECEEGBCJME(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F946 RID: 63814 RVA: 0x006FE10A File Offset: 0x006FC30A
		private IKSolverLimb.AxisDirection[] KIMNFMNOGIP()
		{
			if (this.goal == (AvatarIKGoal)8)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F947 RID: 63815 RVA: 0x006FE122 File Offset: 0x006FC322
		public void EJPKAGLNACJ()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.HHEGNFAEOHL();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F948 RID: 63816 RVA: 0x006FE148 File Offset: 0x006FC348
		private void IKIKNOCOLFD(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(1059f, 118f, 1162f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(948f, 1388f, 1281f), new Vector3(951f, 1879f, 273f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(600f, 1068f, 1547f), new Vector3(779f, 1398f, 1892f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(943f, 908f, 1097f), new Vector3(339f, 1445f, 689f));
		}

		// Token: 0x0600F949 RID: 63817 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void BCMNPBCPCNJ()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F94A RID: 63818 RVA: 0x006FE242 File Offset: 0x006FC442
		public void EDIDMOKJKCN()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.BEBOIEMBNPG();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F94B RID: 63819 RVA: 0x006FE268 File Offset: 0x006FC468
		protected virtual void ILDPBLAFELN()
		{
			if (this.IKPositionWeight > 180f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1137f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F94C RID: 63820 RVA: 0x006FE2DC File Offset: 0x006FC4DC
		private Vector3 FLAPHPNPABO()
		{
			float num = this.bendModifierWeight;
			if (num <= 1998f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.LOEKLGFELMP();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.RightFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("knopje.wav");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == AvatarIKGoal.LeftHand)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.axisDirections.Length; i++)
				{
					this.ALIKBIMOMGL()[i].dot = Mathf.Clamp(Vector3.Dot(this.GFPIMDLMMKI()[i].direction, vector), 823f, 221f);
					this.GBAAHHCILJD()[i].dot = AINDCMJDEOG.NFBGBNIPMFF(this.axisDirections[i].dot, InterpolationMode.InQuadratic);
				}
				Vector3 vector2 = this.KIMNFMNOGIP()[1].axis;
				for (int j = 1; j < this.OKCICGELNFF().Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.OKCICGELNFF()[j].axis, this.MBBDEFOHBIF()[j].dot);
				}
				if (this.goal == (AvatarIKGoal)8)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1008f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("wpn_add/base");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 339f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F94D RID: 63821 RVA: 0x006FE67C File Offset: 0x006FC87C
		protected virtual void KIPJOIABDAG()
		{
			if (this.IKPositionWeight > 38f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1411f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F94E RID: 63822 RVA: 0x006FE6F0 File Offset: 0x006FC8F0
		private void AMJDNPIOEFD(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(822f, 318f, 1248f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(777f, 1569f, 1421f), new Vector3(403f, 1829f, 426f));
			DGCALAMOLNH[5] = new IKSolverLimb.AxisDirection(new Vector3(1294f, 1238f, 656f), new Vector3(1407f, 866f, 1300f));
			DGCALAMOLNH[5] = new IKSolverLimb.AxisDirection(new Vector3(268f, 1547f, 1729f), new Vector3(507f, 757f, 861f));
		}

		// Token: 0x0600F94F RID: 63823 RVA: 0x006FE7C2 File Offset: 0x006FC9C2
		public void JPOMFENFILN()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.NDAMGGBKFBH();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F950 RID: 63824 RVA: 0x006FE7E5 File Offset: 0x006FC9E5
		private IKSolverLimb.AxisDirection[] GBAAHHCILJD()
		{
			if (this.goal == AvatarIKGoal.RightHand)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F951 RID: 63825 RVA: 0x006FE800 File Offset: 0x006FCA00
		protected override void FNLGJEOHONA()
		{
			if (this.IKPositionWeight > 781f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 458f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F952 RID: 63826 RVA: 0x006FE872 File Offset: 0x006FCA72
		public void LMEJGCDILHI()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = false;
		}

		// Token: 0x0600F953 RID: 63827 RVA: 0x006FE89C File Offset: 0x006FCA9C
		private Vector3 PNLAEGKOIAK()
		{
			float num = this.bendModifierWeight;
			if (num <= 0f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.JJMFHEOEFNA();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.RightFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("Trying to use the 'Arm' bend modifier on a leg.");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == AvatarIKGoal.LeftHand)
				{
					vector.x = -vector.x;
				}
				for (int i = 1; i < this.axisDirections.Length; i++)
				{
					this.axisDirections[i].dot = Mathf.Clamp(Vector3.Dot(this.axisDirections[i].direction, vector), 0f, 1f);
					this.axisDirections[i].dot = AINDCMJDEOG.NAKHKNJFPLK(this.axisDirections[i].dot, InterpolationMode.InOutQuintic);
				}
				Vector3 vector2 = this.axisDirections[0].axis;
				for (int j = 1; j < this.axisDirections.Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.axisDirections[j].axis, this.axisDirections[j].dot);
				}
				if (this.goal == AvatarIKGoal.LeftHand)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("Trying to use the 'Goal' Bend Modifier, but the Bend Goal is unassigned.");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F954 RID: 63828 RVA: 0x006FEC3C File Offset: 0x006FCE3C
		protected virtual void HFOOICCCHKP()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.EBFOGHAADOB() != null)
			{
				this.bone3.GIODJAABDKA().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.KCGLJBNOJBN(ref this.axisDirectionsLeft);
			this.CFPOIIKMGPA(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F955 RID: 63829 RVA: 0x006FED5E File Offset: 0x006FCF5E
		private IKSolverLimb.AxisDirection[] DNPAPODBLPN()
		{
			if (this.goal == AvatarIKGoal.RightFoot)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F956 RID: 63830 RVA: 0x006FED78 File Offset: 0x006FCF78
		protected virtual void OLJOCNPIBEG()
		{
			if (this.IKPositionWeight > 1813f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1187f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F957 RID: 63831 RVA: 0x006FEDEA File Offset: 0x006FCFEA
		public void KKPMKILGNGK()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.ILPOOPFGBFJ();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F958 RID: 63832 RVA: 0x006FEE10 File Offset: 0x006FD010
		protected virtual void CLKKOIAIBKJ()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.EDOKKOOPJLP() != null)
			{
				this.bone3.rotationLimit.Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.HDBCMGFMELG(ref this.axisDirectionsLeft);
			this.LAEBBAMHKGA(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F959 RID: 63833 RVA: 0x006FEF32 File Offset: 0x006FD132
		public void IIODIAJPOHH()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.KHCHJPCLGNC();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F95A RID: 63834 RVA: 0x006FEF55 File Offset: 0x006FD155
		public void FKEJFHAFIJN()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.KHOODBDDKDJ();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F95B RID: 63835 RVA: 0x006FEF78 File Offset: 0x006FD178
		private Vector3 HMEHCINHEMN()
		{
			float num = this.bendModifierWeight;
			if (num <= 801f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.EHGMIFIEGGB();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.LeftFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("SteamManager.Initialized failed");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)7)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.GBAAHHCILJD().Length; i += 0)
				{
					this.DNPAPODBLPN()[i].dot = Mathf.Clamp(Vector3.Dot(this.KIMNFMNOGIP()[i].direction, vector), 689f, 1287f);
					this.CKPNDAOOBEM()[i].dot = AINDCMJDEOG.NAKHKNJFPLK(this.PDFGNGPJMAM()[i].dot, InterpolationMode.InElastic);
				}
				Vector3 vector2 = this.MEGGABGBKMF()[1].axis;
				for (int j = 1; j < this.CNOFMNFOEEI().Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.PDFGNGPJMAM()[j].axis, this.PAEBJOIDDNJ()[j].dot);
				}
				if (this.goal == (AvatarIKGoal)5)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1351f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("S");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1257f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F95C RID: 63836 RVA: 0x006FF318 File Offset: 0x006FD518
		public void AGMNAGMBKOJ()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.JEDGBNFNCJA();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F95D RID: 63837 RVA: 0x006FF33C File Offset: 0x006FD53C
		private void HPALLBCFPNH(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(1331f, 282f, 1224f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(398f, 1433f, 214f), new Vector3(1623f, 1218f, 1753f));
			DGCALAMOLNH[6] = new IKSolverLimb.AxisDirection(new Vector3(986f, 253f, 1764f), new Vector3(620f, 394f, 553f));
			DGCALAMOLNH[2] = new IKSolverLimb.AxisDirection(new Vector3(275f, 212f, 215f), new Vector3(585f, 197f, 859f));
		}

		// Token: 0x0600F95E RID: 63838 RVA: 0x006FF410 File Offset: 0x006FD610
		private Vector3 DOMNPCGCCBJ()
		{
			float num = this.bendModifierWeight;
			if (num <= 1143f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.KNDGNPJNCKD();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.RightFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("cntx_use");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)5)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.PAEBJOIDDNJ().Length; i++)
				{
					this.GFPIMDLMMKI()[i].dot = Mathf.Clamp(Vector3.Dot(this.IJPDGOCMEFI()[i].direction, vector), 1965f, 887f);
					this.CNOFMNFOEEI()[i].dot = AINDCMJDEOG.NAKHKNJFPLK(this.ELBPEGNJDHI()[i].dot, InterpolationMode.InQuintic);
				}
				Vector3 vector2 = this.KIMNFMNOGIP()[0].axis;
				for (int j = 1; j < this.KIMNFMNOGIP().Length; j += 0)
				{
					vector2 = Vector3.Slerp(vector2, this.MEGGABGBKMF()[j].axis, this.GBAAHHCILJD()[j].dot);
				}
				if (this.goal == AvatarIKGoal.LeftFoot)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1003f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("_ColorDownsampled");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 965f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F95F RID: 63839 RVA: 0x006FF7B0 File Offset: 0x006FD9B0
		protected virtual void KNFDEGNMLFH()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.EDOKKOOPJLP() != null)
			{
				this.bone3.GIODJAABDKA().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.BHMFBKKIGFM(ref this.axisDirectionsLeft);
			this.EDDDNDKNLBA(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F960 RID: 63840 RVA: 0x006FF8D2 File Offset: 0x006FDAD2
		private IKSolverLimb.AxisDirection[] JPMLMLCCCIO()
		{
			if (this.goal == (AvatarIKGoal)4)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F961 RID: 63841 RVA: 0x006FE10A File Offset: 0x006FC30A
		private IKSolverLimb.AxisDirection[] ELBPEGNJDHI()
		{
			if (this.goal == (AvatarIKGoal)8)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F962 RID: 63842 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void HDFOPIHIKLJ()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F963 RID: 63843 RVA: 0x006FF8EA File Offset: 0x006FDAEA
		private IKSolverLimb.AxisDirection[] OKCICGELNFF()
		{
			if (this.goal == (AvatarIKGoal)6)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F964 RID: 63844 RVA: 0x006FE872 File Offset: 0x006FCA72
		public void AMBMJPLJENA()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = false;
		}

		// Token: 0x0600F965 RID: 63845 RVA: 0x006FF904 File Offset: 0x006FDB04
		private void HDBCMGFMELG(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(794f, 1987f, 1624f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(1169f, 24f, 37f), new Vector3(1120f, 1182f, 1271f));
			DGCALAMOLNH[5] = new IKSolverLimb.AxisDirection(new Vector3(1414f, 1351f, 37f), new Vector3(1462f, 675f, 451f));
			DGCALAMOLNH[8] = new IKSolverLimb.AxisDirection(new Vector3(1172f, 1124f, 1788f), new Vector3(1384f, 266f, 1800f));
		}

		// Token: 0x0600F966 RID: 63846 RVA: 0x006FF9D8 File Offset: 0x006FDBD8
		protected virtual void KCFEFBKGOFA()
		{
			if (this.IKPositionWeight > 1278f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1616f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F967 RID: 63847 RVA: 0x006FFA4C File Offset: 0x006FDC4C
		private Vector3 JHEOOKDBLFD()
		{
			float num = this.bendModifierWeight;
			if (num <= 809f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.JJMFHEOEFNA();
				}
				this.maintainBendFor1Frame = true;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.RightFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("_Offsets");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)7)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.PDFGNGPJMAM().Length; i++)
				{
					this.PAEBJOIDDNJ()[i].dot = Mathf.Clamp(Vector3.Dot(this.axisDirections[i].direction, vector), 1682f, 631f);
					this.HIPMBICJGFA()[i].dot = AINDCMJDEOG.NAKHKNJFPLK(this.ELBPEGNJDHI()[i].dot, InterpolationMode.InQuintic);
				}
				Vector3 vector2 = this.GBAAHHCILJD()[0].axis;
				for (int j = 0; j < this.CNOFMNFOEEI().Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.GBAAHHCILJD()[j].axis, this.GBAAHHCILJD()[j].dot);
				}
				if (this.goal == AvatarIKGoal.RightFoot)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 808f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("Antares/point");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1276f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F968 RID: 63848 RVA: 0x006FFDEC File Offset: 0x006FDFEC
		protected virtual void DPOBHEJIDBL()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.GIODJAABDKA() != null)
			{
				this.bone3.BNBIOMOMICJ().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.BECEEGBCJME(ref this.axisDirectionsLeft);
			this.JPLEAPCOOCM(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F969 RID: 63849 RVA: 0x006FFF0E File Offset: 0x006FE10E
		private IKSolverLimb.AxisDirection[] CKPNDAOOBEM()
		{
			if (this.goal == (AvatarIKGoal)7)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F96A RID: 63850 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void OKCAMNNIGBG()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F96B RID: 63851 RVA: 0x006FE872 File Offset: 0x006FCA72
		public void HLEOFGAAOFN()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = false;
		}

		// Token: 0x0600F96C RID: 63852 RVA: 0x006FFF28 File Offset: 0x006FE128
		protected virtual void AHEILMAKLGD()
		{
			if (this.IKPositionWeight > 514f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 778f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F96D RID: 63853 RVA: 0x006FFF9C File Offset: 0x006FE19C
		private void EDDDNDKNLBA(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(1574f, 1034f, 560f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(575f, 1962f, 1985f), new Vector3(1419f, 1742f, 1809f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(1774f, 112f, 1977f), new Vector3(914f, 1953f, 1484f));
			DGCALAMOLNH[2] = new IKSolverLimb.AxisDirection(new Vector3(1222f, 1731f, 345f), new Vector3(1839f, 751f, 1621f));
		}

		// Token: 0x0600F96E RID: 63854 RVA: 0x006FE7E5 File Offset: 0x006FC9E5
		private IKSolverLimb.AxisDirection[] HIPMBICJGFA()
		{
			if (this.goal == AvatarIKGoal.RightHand)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F96F RID: 63855 RVA: 0x00700070 File Offset: 0x006FE270
		protected virtual void BCJENJJOLKO()
		{
			if (this.IKPositionWeight > 1554f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 612f, 1913f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 1410f, 1720f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.FLAPHPNPABO();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1824f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = false;
			}
		}

		// Token: 0x0600F970 RID: 63856 RVA: 0x0070011C File Offset: 0x006FE31C
		protected virtual void HHMAOHHACJH()
		{
			if (this.IKPositionWeight > 900f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 206f, 219f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 92f, 1303f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.JHEOOKDBLFD();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 691f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = true;
			}
		}

		// Token: 0x0600F971 RID: 63857 RVA: 0x007001C5 File Offset: 0x006FE3C5
		public void OEPLEMPBGDH()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.KIKMIGNMFPJ();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F972 RID: 63858 RVA: 0x007001E8 File Offset: 0x006FE3E8
		protected virtual void FLKGPAADNME()
		{
			if (this.IKPositionWeight > 274f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1202f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F973 RID: 63859 RVA: 0x006FE872 File Offset: 0x006FCA72
		public void NMEHHBLJLBK()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = false;
		}

		// Token: 0x0600F974 RID: 63860 RVA: 0x0070025C File Offset: 0x006FE45C
		protected virtual void EGEJHFKNPBH()
		{
			if (this.IKPositionWeight > 1614f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1331f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F975 RID: 63861 RVA: 0x007002D0 File Offset: 0x006FE4D0
		private Vector3 KAJNCOIJOKL()
		{
			float num = this.bendModifierWeight;
			if (num <= 613f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.DBMGEMOPLIC();
				}
				this.maintainBendFor1Frame = true;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.LeftFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("W");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)7)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.OKCICGELNFF().Length; i++)
				{
					this.OKCICGELNFF()[i].dot = Mathf.Clamp(Vector3.Dot(this.CNOFMNFOEEI()[i].direction, vector), 1611f, 1770f);
					this.PAEBJOIDDNJ()[i].dot = AINDCMJDEOG.PNJHHPLJDAL(this.IJPDGOCMEFI()[i].dot, InterpolationMode.InQuartic);
				}
				Vector3 vector2 = this.DNPAPODBLPN()[1].axis;
				for (int j = 1; j < this.OKCICGELNFF().Length; j += 0)
				{
					vector2 = Vector3.Slerp(vector2, this.CKPNDAOOBEM()[j].axis, this.CNOFMNFOEEI()[j].dot);
				}
				if (this.goal == (AvatarIKGoal)5)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 523f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("_BlurParams");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1359f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F976 RID: 63862 RVA: 0x00700670 File Offset: 0x006FE870
		private Vector3 JPDCFJJEKKJ()
		{
			float num = this.bendModifierWeight;
			if (num <= 1120f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.OEPLEMPBGDH();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.LeftFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("</color>");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == AvatarIKGoal.LeftHand)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.HIPMBICJGFA().Length; i += 0)
				{
					this.PAEBJOIDDNJ()[i].dot = Mathf.Clamp(Vector3.Dot(this.MEGGABGBKMF()[i].direction, vector), 1432f, 863f);
					this.PAEBJOIDDNJ()[i].dot = AINDCMJDEOG.MIFFONKAAHP(this.PAEBJOIDDNJ()[i].dot, InterpolationMode.InOutCubic);
				}
				Vector3 vector2 = this.HIPMBICJGFA()[1].axis;
				for (int j = 0; j < this.JPMLMLCCCIO().Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.IJPDGOCMEFI()[j].axis, this.GBAAHHCILJD()[j].dot);
				}
				if (this.goal == (AvatarIKGoal)5)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1593f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("Button");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1653f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F977 RID: 63863 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void OKGPJJNOMOE()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F978 RID: 63864 RVA: 0x006FE122 File Offset: 0x006FC322
		public void GDKPKGKMJNO()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.HHEGNFAEOHL();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F979 RID: 63865 RVA: 0x00700A10 File Offset: 0x006FEC10
		protected virtual void JGOMPDAGCFO()
		{
			if (this.IKPositionWeight > 986f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1829f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F97A RID: 63866 RVA: 0x00700A84 File Offset: 0x006FEC84
		protected virtual void NBINIKEMMKG()
		{
			if (this.IKPositionWeight > 810f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1182f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F97B RID: 63867 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void LNMJPEHMKMI()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F97C RID: 63868 RVA: 0x00700AF8 File Offset: 0x006FECF8
		protected virtual void CONCJEFGPMB()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.JFPDFHLHIHJ() != null)
			{
				this.bone3.KCDFHPFMOBD().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.LEBCDLCCAMK(ref this.axisDirectionsLeft);
			this.CFPOIIKMGPA(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F97D RID: 63869 RVA: 0x00700C1C File Offset: 0x006FEE1C
		protected virtual void COOOAOIEKCN()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.EDOKKOOPJLP() != null)
			{
				this.bone3.BNBIOMOMICJ().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.AMJDNPIOEFD(ref this.axisDirectionsLeft);
			this.NMCCGPCDLKI(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F97E RID: 63870 RVA: 0x00700D40 File Offset: 0x006FEF40
		private Vector3 PCIELGHIMGG()
		{
			float num = this.bendModifierWeight;
			if (num <= 157f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.OEPLEMPBGDH();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.LeftFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("_TrNewLider.ogg");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)4)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.DNPAPODBLPN().Length; i++)
				{
					this.MEGGABGBKMF()[i].dot = Mathf.Clamp(Vector3.Dot(this.IJPDGOCMEFI()[i].direction, vector), 727f, 510f);
					this.IJPDGOCMEFI()[i].dot = AINDCMJDEOG.NAKHKNJFPLK(this.MBBDEFOHBIF()[i].dot, InterpolationMode.None);
				}
				Vector3 vector2 = this.GFPIMDLMMKI()[1].axis;
				for (int j = 0; j < this.ALIKBIMOMGL().Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.GFPIMDLMMKI()[j].axis, this.KIMNFMNOGIP()[j].dot);
				}
				if (this.goal == (AvatarIKGoal)8)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 90f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL(" from ");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 319f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F97F RID: 63871 RVA: 0x006FF318 File Offset: 0x006FD518
		public void EHGMIFIEGGB()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.JEDGBNFNCJA();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F980 RID: 63872 RVA: 0x007010E0 File Offset: 0x006FF2E0
		protected virtual void KOJCPFOIAOE()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.CLBCIJOPEHI() != null)
			{
				this.bone3.IIFBJMIBPJD().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.LAEBBAMHKGA(ref this.axisDirectionsLeft);
			this.COJIFGOAACP(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F981 RID: 63873 RVA: 0x00701204 File Offset: 0x006FF404
		private Vector3 HPFEKMGJPAE()
		{
			float num = this.bendModifierWeight;
			if (num <= 194f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.DGMMHPDLFKM();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.LeftFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("TOD_MoonDirection");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)8)
				{
					vector.x = -vector.x;
				}
				for (int i = 1; i < this.IJPDGOCMEFI().Length; i++)
				{
					this.ALIKBIMOMGL()[i].dot = Mathf.Clamp(Vector3.Dot(this.MBBDEFOHBIF()[i].direction, vector), 1696f, 1354f);
					this.CNOFMNFOEEI()[i].dot = AINDCMJDEOG.NFBGBNIPMFF(this.MEGGABGBKMF()[i].dot, InterpolationMode.InOutQuintic);
				}
				Vector3 vector2 = this.DNPAPODBLPN()[0].axis;
				for (int j = 0; j < this.ELBPEGNJDHI().Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.PDFGNGPJMAM()[j].axis, this.PAEBJOIDDNJ()[j].dot);
				}
				if (this.goal == AvatarIKGoal.RightHand)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 499f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("1 Hand Sword Jab ready strafe right");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 585f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F982 RID: 63874 RVA: 0x007015A4 File Offset: 0x006FF7A4
		protected virtual void DEMLCGGLBBB()
		{
			if (this.IKPositionWeight > 1149f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 545f, 736f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 258f, 212f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.MEFKBBBKFNF();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1347f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = true;
			}
		}

		// Token: 0x0600F983 RID: 63875 RVA: 0x00701650 File Offset: 0x006FF850
		protected override void DOPPFGJOHIH()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.rotationLimit != null)
			{
				this.bone3.rotationLimit.Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.JPLEAPCOOCM(ref this.axisDirectionsLeft);
			this.JPLEAPCOOCM(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F984 RID: 63876 RVA: 0x00701774 File Offset: 0x006FF974
		protected virtual void OKJLAALJLNC()
		{
			if (this.IKPositionWeight > 1618f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 728f, 1618f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 1320f, 972f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.ACMAEOHBDMG();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 199f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = true;
			}
		}

		// Token: 0x0600F985 RID: 63877 RVA: 0x00701820 File Offset: 0x006FFA20
		protected virtual void ELKBCJBNCJH()
		{
			if (this.IKPositionWeight > 1847f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 130f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F986 RID: 63878 RVA: 0x00701894 File Offset: 0x006FFA94
		private void LEBCDLCCAMK(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(1124f, 71f, 763f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(426f, 280f, 654f), new Vector3(998f, 378f, 1944f));
			DGCALAMOLNH[8] = new IKSolverLimb.AxisDirection(new Vector3(730f, 368f, 1082f), new Vector3(846f, 256f, 1311f));
			DGCALAMOLNH[7] = new IKSolverLimb.AxisDirection(new Vector3(1154f, 1268f, 1761f), new Vector3(583f, 1367f, 407f));
		}

		// Token: 0x0600F987 RID: 63879 RVA: 0x00701968 File Offset: 0x006FFB68
		protected virtual void BEHKMGADGMG()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.CLBCIJOPEHI() != null)
			{
				this.bone3.GIODJAABDKA().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.NMCCGPCDLKI(ref this.axisDirectionsLeft);
			this.JKKODBOBCDI(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F988 RID: 63880 RVA: 0x00701A8C File Offset: 0x006FFC8C
		protected virtual void IOAOCDEBBJL()
		{
			if (this.IKPositionWeight > 941f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1921f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F989 RID: 63881 RVA: 0x00701B00 File Offset: 0x006FFD00
		protected override void DKJKADLGAKB()
		{
			if (this.IKPositionWeight > 0f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 0f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F98A RID: 63882 RVA: 0x00701B72 File Offset: 0x006FFD72
		private IKSolverLimb.AxisDirection[] PDFGNGPJMAM()
		{
			if (this.goal == AvatarIKGoal.LeftHand)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F98B RID: 63883 RVA: 0x00701B8C File Offset: 0x006FFD8C
		private void PBFNBHNBBMP(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(532f, 1700f, 51f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(121f, 1897f, 310f), new Vector3(1505f, 1244f, 1894f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(1951f, 1783f, 1921f), new Vector3(1341f, 434f, 745f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(364f, 1661f, 1795f), new Vector3(812f, 1225f, 1007f));
		}

		// Token: 0x0600F98C RID: 63884 RVA: 0x00701C60 File Offset: 0x006FFE60
		protected virtual void IPIGEBLPCOC()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.KCDFHPFMOBD() != null)
			{
				this.bone3.IAIFLBKIHEE().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.CFPOIIKMGPA(ref this.axisDirectionsLeft);
			this.DPPMDCOACFE(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F98D RID: 63885 RVA: 0x00701D84 File Offset: 0x006FFF84
		protected virtual void BJMOAFGBAHH()
		{
			if (this.IKPositionWeight > 43f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 543f, 1645f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 1931f, 230f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.BFJJAABMFNH();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1683f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = false;
			}
		}

		// Token: 0x0600F98E RID: 63886 RVA: 0x006FF8D2 File Offset: 0x006FDAD2
		private IKSolverLimb.AxisDirection[] GFPIMDLMMKI()
		{
			if (this.goal == (AvatarIKGoal)4)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F98F RID: 63887 RVA: 0x00701E30 File Offset: 0x00700030
		private Vector3 NIHNMJNHJIG()
		{
			float num = this.bendModifierWeight;
			if (num <= 1266f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.GDKPKGKMJNO();
				}
				this.maintainBendFor1Frame = true;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.LeftFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("#02C85F");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == AvatarIKGoal.LeftFoot)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.MEGGABGBKMF().Length; i += 0)
				{
					this.JPMLMLCCCIO()[i].dot = Mathf.Clamp(Vector3.Dot(this.MEGGABGBKMF()[i].direction, vector), 1693f, 1008f);
					this.OKCICGELNFF()[i].dot = AINDCMJDEOG.NAKHKNJFPLK(this.CKPNDAOOBEM()[i].dot, InterpolationMode.InOutQuintic);
				}
				Vector3 vector2 = this.PDFGNGPJMAM()[0].axis;
				for (int j = 1; j < this.HIPMBICJGFA().Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.HIPMBICJGFA()[j].axis, this.ALIKBIMOMGL()[j].dot);
				}
				if (this.goal == (AvatarIKGoal)7)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1590f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("fchair");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1676f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F990 RID: 63888 RVA: 0x007021D0 File Offset: 0x007003D0
		protected virtual void LCKEJKAFNAC()
		{
			if (this.IKPositionWeight > 1616f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1661f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F991 RID: 63889 RVA: 0x00702242 File Offset: 0x00700442
		public void GLADKHGOBLO()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.MABCBMGCMGL();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F992 RID: 63890 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void HDGANGDJBIK()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F993 RID: 63891 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void IHMPPFOHOJB()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F994 RID: 63892 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void PAPBDBLCILH()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F995 RID: 63893 RVA: 0x00702268 File Offset: 0x00700468
		private void JPLEAPCOOCM(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(-1f, 0f, 0f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(0.5f, 0f, -0.2f), new Vector3(-0.5f, -1f, 1f));
			DGCALAMOLNH[2] = new IKSolverLimb.AxisDirection(new Vector3(-0.5f, -1f, -0.2f), new Vector3(0f, 0.5f, -1f));
			DGCALAMOLNH[3] = new IKSolverLimb.AxisDirection(new Vector3(-0.5f, -0.5f, 1f), new Vector3(-1f, -1f, -1f));
		}

		// Token: 0x0600F996 RID: 63894 RVA: 0x006FF318 File Offset: 0x006FD518
		public void PKHIMFDBBAP()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.JEDGBNFNCJA();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F997 RID: 63895 RVA: 0x0070233C File Offset: 0x0070053C
		private void DPPMDCOACFE(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(607f, 588f, 759f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(10f, 204f, 709f), new Vector3(1325f, 719f, 673f));
			DGCALAMOLNH[2] = new IKSolverLimb.AxisDirection(new Vector3(1644f, 1929f, 1102f), new Vector3(633f, 470f, 1745f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(894f, 1283f, 778f), new Vector3(1313f, 1349f, 102f));
		}

		// Token: 0x0600F998 RID: 63896 RVA: 0x0070240E File Offset: 0x0070060E
		public void LOEKLGFELMP()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.KIKMIGNMFPJ();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F999 RID: 63897 RVA: 0x006FEF55 File Offset: 0x006FD155
		public void JHOJKNFFMJO()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.KHOODBDDKDJ();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F99A RID: 63898 RVA: 0x00702431 File Offset: 0x00700631
		public void BOJDNMLAHGL()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.JEDGBNFNCJA();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F99B RID: 63899 RVA: 0x00702454 File Offset: 0x00700654
		protected virtual void LGMIKGBABMJ()
		{
			if (this.IKPositionWeight > 392f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 1655f, 1306f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 617f, 975f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.GDINJOFEJHJ();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 280f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = true;
			}
		}

		// Token: 0x0600F99C RID: 63900 RVA: 0x00702500 File Offset: 0x00700700
		protected virtual void MOMLEAHDFNM()
		{
			if (this.IKPositionWeight > 341f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1841f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F99D RID: 63901 RVA: 0x00702574 File Offset: 0x00700774
		protected virtual void HJCADKPEFDA()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.IIFBJMIBPJD() != null)
			{
				this.bone3.IAIFLBKIHEE().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.CFPOIIKMGPA(ref this.axisDirectionsLeft);
			this.IKIKNOCOLFD(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F99E RID: 63902 RVA: 0x00702696 File Offset: 0x00700896
		public void KNFPNDEDHBJ()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.LFKHHOJIGNK();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F99F RID: 63903 RVA: 0x006FE10A File Offset: 0x006FC30A
		private IKSolverLimb.AxisDirection[] PGEKIDPPJPD()
		{
			if (this.goal == (AvatarIKGoal)8)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F9A0 RID: 63904 RVA: 0x007026BC File Offset: 0x007008BC
		private void LAEBBAMHKGA(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(1279f, 1360f, 736f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(1909f, 532f, 1684f), new Vector3(1892f, 995f, 124f));
			DGCALAMOLNH[6] = new IKSolverLimb.AxisDirection(new Vector3(715f, 1027f, 1633f), new Vector3(693f, 1994f, 334f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(1134f, 1157f, 1962f), new Vector3(1775f, 1965f, 747f));
		}

		// Token: 0x0600F9A1 RID: 63905 RVA: 0x00702790 File Offset: 0x00700990
		protected virtual void DDDDEHPLKIF()
		{
			if (this.IKPositionWeight > 897f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 857f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F9A2 RID: 63906 RVA: 0x006FFF0E File Offset: 0x006FE10E
		private IKSolverLimb.AxisDirection[] ALIKBIMOMGL()
		{
			if (this.goal == (AvatarIKGoal)7)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F9A3 RID: 63907 RVA: 0x00702804 File Offset: 0x00700A04
		protected virtual void NMHPCOFCGBJ()
		{
			if (this.IKPositionWeight > 15f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 683f, 1665f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 1853f, 514f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.JHEOOKDBLFD();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 263f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = true;
			}
		}

		// Token: 0x0600F9A4 RID: 63908 RVA: 0x007028B0 File Offset: 0x00700AB0
		private void MIMMHBHPJIO(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(1743f, 254f, 1979f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(128f, 1890f, 19f), new Vector3(1360f, 857f, 735f));
			DGCALAMOLNH[5] = new IKSolverLimb.AxisDirection(new Vector3(275f, 1812f, 1589f), new Vector3(1342f, 1139f, 117f));
			DGCALAMOLNH[2] = new IKSolverLimb.AxisDirection(new Vector3(1036f, 737f, 942f), new Vector3(87f, 947f, 1362f));
		}

		// Token: 0x0600F9A5 RID: 63909 RVA: 0x00702984 File Offset: 0x00700B84
		private Vector3 BMAJGPMGACH()
		{
			float num = this.bendModifierWeight;
			if (num <= 581f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.HICNGACLCMD();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.RightFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("shop_ycnt");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)8)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.MEGGABGBKMF().Length; i++)
				{
					this.CKPNDAOOBEM()[i].dot = Mathf.Clamp(Vector3.Dot(this.PAEBJOIDDNJ()[i].direction, vector), 995f, 1694f);
					this.CKPNDAOOBEM()[i].dot = AINDCMJDEOG.NFBGBNIPMFF(this.MBBDEFOHBIF()[i].dot, InterpolationMode.None);
				}
				Vector3 vector2 = this.PAEBJOIDDNJ()[0].axis;
				for (int j = 1; j < this.HIPMBICJGFA().Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.GBAAHHCILJD()[j].axis, this.IJPDGOCMEFI()[j].dot);
				}
				if (this.goal == AvatarIKGoal.LeftHand)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 446f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("MotorbikeTurnRight");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 679f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F9A6 RID: 63910 RVA: 0x00702D24 File Offset: 0x00700F24
		private void COJIFGOAACP(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(503f, 326f, 1721f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(146f, 1916f, 954f), new Vector3(203f, 222f, 1516f));
			DGCALAMOLNH[3] = new IKSolverLimb.AxisDirection(new Vector3(1392f, 493f, 1879f), new Vector3(1031f, 1735f, 282f));
			DGCALAMOLNH[4] = new IKSolverLimb.AxisDirection(new Vector3(466f, 321f, 362f), new Vector3(1085f, 1883f, 1510f));
		}

		// Token: 0x0600F9A7 RID: 63911 RVA: 0x006FE7C2 File Offset: 0x006FC9C2
		public void DMCCBEKELKM()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.NDAMGGBKFBH();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F9A8 RID: 63912 RVA: 0x00702DF8 File Offset: 0x00700FF8
		protected virtual void MKMJJACDPLC()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.MPNLGJMOLGG() != null)
			{
				this.bone3.MPNLGJMOLGG().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.LAEBBAMHKGA(ref this.axisDirectionsLeft);
			this.EDDDNDKNLBA(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F9A9 RID: 63913 RVA: 0x00702F1A File Offset: 0x0070111A
		public IKSolverLimb()
		{
		}

		// Token: 0x0600F9AA RID: 63914 RVA: 0x00702F48 File Offset: 0x00701148
		protected virtual void KHMENJHOKKF()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.IAIFLBKIHEE() != null)
			{
				this.bone3.EDOKKOOPJLP().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.HDBCMGFMELG(ref this.axisDirectionsLeft);
			this.JKKODBOBCDI(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F9AB RID: 63915 RVA: 0x0070306C File Offset: 0x0070126C
		protected virtual void KNEIFILEHPC()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.MPNLGJMOLGG() != null)
			{
				this.bone3.EDOKKOOPJLP().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.LEBCDLCCAMK(ref this.axisDirectionsLeft);
			this.CFPOIIKMGPA(ref this.axisDirectionsRight);
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x0600F9AC RID: 63916 RVA: 0x00701B72 File Offset: 0x006FFD72
		private IKSolverLimb.AxisDirection[] axisDirections
		{
			get
			{
				if (this.goal == AvatarIKGoal.LeftHand)
				{
					return this.axisDirectionsLeft;
				}
				return this.axisDirectionsRight;
			}
		}

		// Token: 0x0600F9AD RID: 63917 RVA: 0x00703190 File Offset: 0x00701390
		protected virtual void KFDDHFCPHHB()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.IIFBJMIBPJD() != null)
			{
				this.bone3.CLBCIJOPEHI().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.COJIFGOAACP(ref this.axisDirectionsLeft);
			this.HPALLBCFPNH(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F9AE RID: 63918 RVA: 0x007032B4 File Offset: 0x007014B4
		private void CFPOIIKMGPA(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(220f, 1670f, 14f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(1836f, 780f, 1377f), new Vector3(1380f, 484f, 706f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(1054f, 310f, 1015f), new Vector3(1008f, 1152f, 347f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(1891f, 810f, 15f), new Vector3(944f, 1343f, 150f));
		}

		// Token: 0x0600F9AF RID: 63919 RVA: 0x00703386 File Offset: 0x00701586
		public IKSolverLimb(AvatarIKGoal AEFBPOBJBII)
		{
			this.goal = AEFBPOBJBII;
		}

		// Token: 0x0600F9B0 RID: 63920 RVA: 0x007033B8 File Offset: 0x007015B8
		protected virtual void AFOIMBNIDKJ()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.CLBCIJOPEHI() != null)
			{
				this.bone3.GIODJAABDKA().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.EDDDNDKNLBA(ref this.axisDirectionsLeft);
			this.KCGLJBNOJBN(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F9B1 RID: 63921 RVA: 0x00701B72 File Offset: 0x006FFD72
		private IKSolverLimb.AxisDirection[] MEGGABGBKMF()
		{
			if (this.goal == AvatarIKGoal.LeftHand)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F9B2 RID: 63922 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void GAHOFLGAOBK()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F9B3 RID: 63923 RVA: 0x006FE872 File Offset: 0x006FCA72
		public void FLBCDGMOPHC()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = false;
		}

		// Token: 0x0600F9B4 RID: 63924 RVA: 0x006FE872 File Offset: 0x006FCA72
		public void IAJMACDEKGF()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = false;
		}

		// Token: 0x0600F9B5 RID: 63925 RVA: 0x007034DA File Offset: 0x007016DA
		public void DGMMHPDLFKM()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.EDIIPFKJJCB();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F9B6 RID: 63926 RVA: 0x00703500 File Offset: 0x00701700
		private Vector3 ONCIHGIMJBP()
		{
			float num = this.bendModifierWeight;
			if (num <= 1691f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.HICNGACLCMD();
				}
				this.maintainBendFor1Frame = true;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.LeftFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("WATER_REFLECTIVE");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)4)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.GFPIMDLMMKI().Length; i++)
				{
					this.MBBDEFOHBIF()[i].dot = Mathf.Clamp(Vector3.Dot(this.PDFGNGPJMAM()[i].direction, vector), 1082f, 208f);
					this.MEGGABGBKMF()[i].dot = AINDCMJDEOG.PNJHHPLJDAL(this.GBAAHHCILJD()[i].dot, InterpolationMode.InElastic);
				}
				Vector3 vector2 = this.JPMLMLCCCIO()[0].axis;
				for (int j = 0; j < this.DNPAPODBLPN().Length; j += 0)
				{
					vector2 = Vector3.Slerp(vector2, this.DNPAPODBLPN()[j].axis, this.MBBDEFOHBIF()[j].dot);
				}
				if (this.goal == (AvatarIKGoal)4)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1774f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL(" ");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1881f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F9B7 RID: 63927 RVA: 0x006FED5E File Offset: 0x006FCF5E
		private IKSolverLimb.AxisDirection[] MBBDEFOHBIF()
		{
			if (this.goal == AvatarIKGoal.RightFoot)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F9B8 RID: 63928 RVA: 0x007038A0 File Offset: 0x00701AA0
		public void MHBDLGNKGCJ()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.NDAMGGBKFBH();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F9B9 RID: 63929 RVA: 0x007038C4 File Offset: 0x00701AC4
		private void BECEEGBCJME(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(1548f, 1130f, 51f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(1308f, 1494f, 1817f), new Vector3(743f, 221f, 115f));
			DGCALAMOLNH[4] = new IKSolverLimb.AxisDirection(new Vector3(332f, 638f, 838f), new Vector3(1530f, 1541f, 180f));
			DGCALAMOLNH[7] = new IKSolverLimb.AxisDirection(new Vector3(882f, 1677f, 168f), new Vector3(1883f, 1276f, 1537f));
		}

		// Token: 0x0600F9BA RID: 63930 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void PIFJIKJOBLA()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F9BB RID: 63931 RVA: 0x007001C5 File Offset: 0x006FE3C5
		public void JJMFHEOEFNA()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.KIKMIGNMFPJ();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F9BC RID: 63932 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void EHNFBABCJMH()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F9BD RID: 63933 RVA: 0x00703998 File Offset: 0x00701B98
		protected override void KOHNIPNOJAE()
		{
			if (this.IKPositionWeight > 0f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 0f, 1f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 0f, 1f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.PNLAEGKOIAK();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 0f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = false;
			}
		}

		// Token: 0x0600F9BE RID: 63934 RVA: 0x00703A44 File Offset: 0x00701C44
		private Vector3 GKCCDPJBKFP()
		{
			float num = this.bendModifierWeight;
			if (num <= 36f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.JHOJKNFFMJO();
				}
				this.maintainBendFor1Frame = true;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.LeftFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("+ ");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == AvatarIKGoal.RightFoot)
				{
					vector.x = -vector.x;
				}
				for (int i = 1; i < this.MEGGABGBKMF().Length; i += 0)
				{
					this.IJPDGOCMEFI()[i].dot = Mathf.Clamp(Vector3.Dot(this.DNPAPODBLPN()[i].direction, vector), 687f, 1932f);
					this.HIPMBICJGFA()[i].dot = AINDCMJDEOG.NFBGBNIPMFF(this.axisDirections[i].dot, InterpolationMode.InQuartic);
				}
				Vector3 vector2 = this.PAEBJOIDDNJ()[1].axis;
				for (int j = 0; j < this.IJPDGOCMEFI().Length; j += 0)
				{
					vector2 = Vector3.Slerp(vector2, this.CNOFMNFOEEI()[j].axis, this.HIPMBICJGFA()[j].dot);
				}
				if (this.goal == AvatarIKGoal.LeftHand)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1746f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("idlist");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1940f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F9BF RID: 63935 RVA: 0x00703DE4 File Offset: 0x00701FE4
		private void KCGLJBNOJBN(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(1062f, 1718f, 1018f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(459f, 820f, 1836f), new Vector3(1397f, 953f, 1261f));
			DGCALAMOLNH[5] = new IKSolverLimb.AxisDirection(new Vector3(242f, 439f, 241f), new Vector3(127f, 1890f, 1372f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(107f, 1642f, 362f), new Vector3(1629f, 1504f, 1394f));
		}

		// Token: 0x0600F9C0 RID: 63936 RVA: 0x00703EB8 File Offset: 0x007020B8
		private Vector3 EPKBINLLHJN()
		{
			float num = this.bendModifierWeight;
			if (num <= 1119f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.GDKPKGKMJNO();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.RightFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("demoQuaternion");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)7)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.PGEKIDPPJPD().Length; i++)
				{
					this.CKPNDAOOBEM()[i].dot = Mathf.Clamp(Vector3.Dot(this.DNPAPODBLPN()[i].direction, vector), 1787f, 1890f);
					this.ALIKBIMOMGL()[i].dot = AINDCMJDEOG.NFBGBNIPMFF(this.JPMLMLCCCIO()[i].dot, InterpolationMode.None);
				}
				Vector3 vector2 = this.DNPAPODBLPN()[1].axis;
				for (int j = 0; j < this.DNPAPODBLPN().Length; j += 0)
				{
					vector2 = Vector3.Slerp(vector2, this.ALIKBIMOMGL()[j].axis, this.HIPMBICJGFA()[j].dot);
				}
				if (this.goal == AvatarIKGoal.LeftFoot)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 494f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("TOD_SunDirection");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 983f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F9C1 RID: 63937 RVA: 0x00704258 File Offset: 0x00702458
		public void HICNGACLCMD()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.LFKHHOJIGNK();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F9C2 RID: 63938 RVA: 0x0070427C File Offset: 0x0070247C
		protected virtual void LEJLEIJCHDL()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.BNBIOMOMICJ() != null)
			{
				this.bone3.GIODJAABDKA().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.KCGLJBNOJBN(ref this.axisDirectionsLeft);
			this.AMJDNPIOEFD(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F9C3 RID: 63939 RVA: 0x007043A0 File Offset: 0x007025A0
		private Vector3 MEFKBBBKFNF()
		{
			float num = this.bendModifierWeight;
			if (num <= 705f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.MHBDLGNKGCJ();
				}
				this.maintainBendFor1Frame = true;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.LeftFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)5)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.PGEKIDPPJPD().Length; i++)
				{
					this.PDFGNGPJMAM()[i].dot = Mathf.Clamp(Vector3.Dot(this.PAEBJOIDDNJ()[i].direction, vector), 792f, 1688f);
					this.MEGGABGBKMF()[i].dot = AINDCMJDEOG.PNJHHPLJDAL(this.GFPIMDLMMKI()[i].dot, InterpolationMode.InElastic);
				}
				Vector3 vector2 = this.KIMNFMNOGIP()[1].axis;
				for (int j = 1; j < this.KIMNFMNOGIP().Length; j += 0)
				{
					vector2 = Vector3.Slerp(vector2, this.PGEKIDPPJPD()[j].axis, this.MBBDEFOHBIF()[j].dot);
				}
				if (this.goal == (AvatarIKGoal)8)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1247f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("drag_onmousedown.wav");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1759f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F9C4 RID: 63940 RVA: 0x006FF8EA File Offset: 0x006FDAEA
		private IKSolverLimb.AxisDirection[] PAEBJOIDDNJ()
		{
			if (this.goal == (AvatarIKGoal)6)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F9C5 RID: 63941 RVA: 0x00702431 File Offset: 0x00700631
		public void DBMGEMOPLIC()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.JEDGBNFNCJA();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F9C6 RID: 63942 RVA: 0x00704740 File Offset: 0x00702940
		private Vector3 BFJJAABMFNH()
		{
			float num = this.bendModifierWeight;
			if (num <= 1469f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.KNFPNDEDHBJ();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.RightFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("RollerBladeSkateFwd");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)7)
				{
					vector.x = -vector.x;
				}
				for (int i = 1; i < this.PAEBJOIDDNJ().Length; i += 0)
				{
					this.GFPIMDLMMKI()[i].dot = Mathf.Clamp(Vector3.Dot(this.ELBPEGNJDHI()[i].direction, vector), 1742f, 21f);
					this.IJPDGOCMEFI()[i].dot = AINDCMJDEOG.NAKHKNJFPLK(this.OKCICGELNFF()[i].dot, InterpolationMode.InOutCubic);
				}
				Vector3 vector2 = this.IJPDGOCMEFI()[1].axis;
				for (int j = 0; j < this.ELBPEGNJDHI().Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.axisDirections[j].axis, this.IJPDGOCMEFI()[j].dot);
				}
				if (this.goal == AvatarIKGoal.RightHand)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1909f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("Wizard Eye Beam");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 849f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F9C7 RID: 63943 RVA: 0x00704AE0 File Offset: 0x00702CE0
		protected virtual void IGIAFNCFFDO()
		{
			if (this.IKPositionWeight > 1046f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 774f, 826f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 309f, 1019f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.HMEHCINHEMN();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 154f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = true;
			}
		}

		// Token: 0x0600F9C8 RID: 63944 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void BEBOBNKBGHF()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F9C9 RID: 63945 RVA: 0x00704B8C File Offset: 0x00702D8C
		protected virtual void DJODEKNEHCM()
		{
			if (this.IKPositionWeight > 253f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 1599f, 899f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 1536f, 232f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.HMEHCINHEMN();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1292f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = false;
			}
		}

		// Token: 0x0600F9CA RID: 63946 RVA: 0x00704C35 File Offset: 0x00702E35
		public void OACNJFGFFLG()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.BEBOIEMBNPG();
			this.maintainBendFor1Frame = false;
		}

		// Token: 0x0600F9CB RID: 63947 RVA: 0x00704C58 File Offset: 0x00702E58
		protected virtual void CNLDMIDKNPE()
		{
			if (this.IKPositionWeight > 966f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 408f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F9CC RID: 63948 RVA: 0x00704CCC File Offset: 0x00702ECC
		protected virtual void PILNAAFDIEL()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.JAHABHNJEPI() != null)
			{
				this.bone3.rotationLimit.Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.JKKODBOBCDI(ref this.axisDirectionsLeft);
			this.KCGLJBNOJBN(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F9CD RID: 63949 RVA: 0x00704DF0 File Offset: 0x00702FF0
		private void NMCCGPCDLKI(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(78f, 1691f, 1760f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(261f, 827f, 871f), new Vector3(929f, 1743f, 512f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(1017f, 76f, 962f), new Vector3(33f, 1096f, 1375f));
			DGCALAMOLNH[4] = new IKSolverLimb.AxisDirection(new Vector3(232f, 1532f, 653f), new Vector3(1350f, 1953f, 58f));
		}

		// Token: 0x0600F9CE RID: 63950 RVA: 0x006FF8EA File Offset: 0x006FDAEA
		private IKSolverLimb.AxisDirection[] IJPDGOCMEFI()
		{
			if (this.goal == (AvatarIKGoal)6)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F9CF RID: 63951 RVA: 0x00704EC2 File Offset: 0x007030C2
		private IKSolverLimb.AxisDirection[] CNOFMNFOEEI()
		{
			if (this.goal == AvatarIKGoal.LeftFoot)
			{
				return this.axisDirectionsLeft;
			}
			return this.axisDirectionsRight;
		}

		// Token: 0x0600F9D0 RID: 63952 RVA: 0x00704EDC File Offset: 0x007030DC
		protected virtual void DPBNIHMEBED()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.EBFOGHAADOB() != null)
			{
				this.bone3.EBFOGHAADOB().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.COJIFGOAACP(ref this.axisDirectionsLeft);
			this.BHMFBKKIGFM(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F9D1 RID: 63953 RVA: 0x00705000 File Offset: 0x00703200
		protected virtual void OBOGCFFFMOE()
		{
			if (this.IKPositionWeight > 603f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1355f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F9D2 RID: 63954 RVA: 0x006FE242 File Offset: 0x006FC442
		public void GJDCDJJBMGJ()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.BEBOIEMBNPG();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F9D3 RID: 63955 RVA: 0x006FE872 File Offset: 0x006FCA72
		public void NNPNAGDMDDG()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = false;
		}

		// Token: 0x0600F9D4 RID: 63956 RVA: 0x00705074 File Offset: 0x00703274
		private void JKKODBOBCDI(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(1043f, 1834f, 804f));
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(new Vector3(619f, 1745f, 1337f), new Vector3(1632f, 1556f, 1080f));
			DGCALAMOLNH[3] = new IKSolverLimb.AxisDirection(new Vector3(177f, 829f, 270f), new Vector3(1728f, 7f, 1402f));
			DGCALAMOLNH[7] = new IKSolverLimb.AxisDirection(new Vector3(698f, 1437f, 130f), new Vector3(775f, 201f, 663f));
		}

		// Token: 0x0600F9D5 RID: 63957 RVA: 0x007034DA File Offset: 0x007016DA
		public void KNDGNPJNCKD()
		{
			if (!base.initiated)
			{
				return;
			}
			this.animationNormal = this.bone1.EDIIPFKJJCB();
			this.maintainBendFor1Frame = true;
		}

		// Token: 0x0600F9D6 RID: 63958 RVA: 0x00705148 File Offset: 0x00703348
		protected virtual void FJAHLIMFNJN()
		{
			if (this.IKPositionWeight > 285f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 647f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F9D7 RID: 63959 RVA: 0x006FE21A File Offset: 0x006FC41A
		public void BNIFPFDCHGB()
		{
			if (!base.initiated)
			{
				return;
			}
			this.maintainRotation = this.bone3.transform.rotation;
			this.maintainRotationFor1Frame = true;
		}

		// Token: 0x0600F9D8 RID: 63960 RVA: 0x007051BC File Offset: 0x007033BC
		private Vector3 ACMAEOHBDMG()
		{
			float num = this.bendModifierWeight;
			if (num <= 1575f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.HICNGACLCMD();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.RightFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("OfficeSittingReadingPageFlip");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == (AvatarIKGoal)4)
				{
					vector.x = -vector.x;
				}
				for (int i = 1; i < this.IJPDGOCMEFI().Length; i++)
				{
					this.ALIKBIMOMGL()[i].dot = Mathf.Clamp(Vector3.Dot(this.OKCICGELNFF()[i].direction, vector), 206f, 1680f);
					this.MEGGABGBKMF()[i].dot = AINDCMJDEOG.PNJHHPLJDAL(this.MEGGABGBKMF()[i].dot, InterpolationMode.None);
				}
				Vector3 vector2 = this.IJPDGOCMEFI()[0].axis;
				for (int j = 1; j < this.KIMNFMNOGIP().Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.OKCICGELNFF()[j].axis, this.PGEKIDPPJPD()[j].dot);
				}
				if (this.goal == AvatarIKGoal.RightHand)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 535f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("BattleRoar");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1274f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F9D9 RID: 63961 RVA: 0x0070555C File Offset: 0x0070375C
		private void BHMFBKKIGFM(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(534f, 905f, 1276f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(687f, 1420f, 1206f), new Vector3(823f, 1849f, 470f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(339f, 1552f, 1645f), new Vector3(1218f, 272f, 399f));
			DGCALAMOLNH[3] = new IKSolverLimb.AxisDirection(new Vector3(849f, 1973f, 655f), new Vector3(747f, 1015f, 1144f));
		}

		// Token: 0x0600F9DA RID: 63962 RVA: 0x00705630 File Offset: 0x00703830
		protected virtual void PAGDEMHMEDM()
		{
			if (this.IKPositionWeight > 1871f)
			{
				this.bendNormal = this._bendNormal;
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 1309f)
			{
				this.bone3.transform.rotation = Quaternion.Slerp(this.bone3.transform.rotation, this.bone3RotationBeforeSolve, this.maintainRotationWeight * this.IKPositionWeight);
			}
		}

		// Token: 0x0600F9DB RID: 63963 RVA: 0x007056A4 File Offset: 0x007038A4
		private Vector3 GDINJOFEJHJ()
		{
			float num = this.bendModifierWeight;
			if (num <= 1335f)
			{
				return this.bendNormal;
			}
			switch (this.bendModifier)
			{
			case IKSolverLimb.BendModifier.Animation:
				if (!this.maintainBendFor1Frame)
				{
					this.GLADKHGOBLO();
				}
				this.maintainBendFor1Frame = false;
				return Vector3.Lerp(this.bendNormal, this.animationNormal, num);
			case IKSolverLimb.BendModifier.Target:
			{
				Quaternion b = this.IKRotation * Quaternion.Inverse(this.bone3DefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, b, num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Parent:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				Quaternion lhs = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation);
				return Quaternion.Slerp(Quaternion.identity, lhs * Quaternion.Inverse(this.defaultRootRotation), num) * this.bendNormal;
			}
			case IKSolverLimb.BendModifier.Arm:
			{
				if (this.bone1.transform.parent == null)
				{
					return this.bendNormal;
				}
				if (this.goal == AvatarIKGoal.LeftFoot || this.goal == AvatarIKGoal.RightFoot)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("gi_uinf_3");
					}
					return this.bendNormal;
				}
				Vector3 vector = (this.IKPosition - this.bone1.transform.position).normalized;
				vector = Quaternion.Inverse(this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation)) * vector;
				if (this.goal == AvatarIKGoal.RightHand)
				{
					vector.x = -vector.x;
				}
				for (int i = 0; i < this.ELBPEGNJDHI().Length; i++)
				{
					this.CKPNDAOOBEM()[i].dot = Mathf.Clamp(Vector3.Dot(this.MBBDEFOHBIF()[i].direction, vector), 355f, 527f);
					this.ALIKBIMOMGL()[i].dot = AINDCMJDEOG.PNJHHPLJDAL(this.IJPDGOCMEFI()[i].dot, InterpolationMode.InQuintic);
				}
				Vector3 vector2 = this.PGEKIDPPJPD()[0].axis;
				for (int j = 0; j < this.OKCICGELNFF().Length; j++)
				{
					vector2 = Vector3.Slerp(vector2, this.PAEBJOIDDNJ()[j].axis, this.IJPDGOCMEFI()[j].dot);
				}
				if (this.goal == (AvatarIKGoal)8)
				{
					vector2.x = -vector2.x;
					vector2 = -vector2;
				}
				Vector3 vector3 = this.bone1.transform.parent.rotation * Quaternion.Inverse(this.parentDefaultRotation) * vector2;
				if (num >= 1499f)
				{
					return vector3;
				}
				return Vector3.Lerp(this.bendNormal, vector3, num);
			}
			case IKSolverLimb.BendModifier.Goal:
			{
				if (this.bendGoal == null)
				{
					if (!PMCOMMEEGMC.HAAICNHEMMK)
					{
						base.AIPEHBKNFNL("fishdrop_2");
					}
					return this.bendNormal;
				}
				Vector3 vector4 = Vector3.Cross(this.bendGoal.position - this.bone1.transform.position, this.IKPosition - this.bone1.transform.position);
				if (vector4 == Vector3.zero)
				{
					return this.bendNormal;
				}
				if (num >= 1551f)
				{
					return vector4;
				}
				return Vector3.Lerp(this.bendNormal, vector4, num);
			}
			default:
				return this.bendNormal;
			}
		}

		// Token: 0x0600F9DC RID: 63964 RVA: 0x00705A44 File Offset: 0x00703C44
		protected virtual void OOOKKGPOJOB()
		{
			this.defaultRootRotation = this.root.rotation;
			if (this.bone1.transform.parent != null)
			{
				this.parentDefaultRotation = Quaternion.Inverse(this.defaultRootRotation) * this.bone1.transform.parent.rotation;
			}
			if (this.bone3.JAHABHNJEPI() != null)
			{
				this.bone3.IAIFLBKIHEE().Disable();
			}
			this.bone3DefaultRotation = this.bone3.transform.rotation;
			Vector3 vector = Vector3.Cross(this.bone2.transform.position - this.bone1.transform.position, this.bone3.transform.position - this.bone2.transform.position);
			if (vector != Vector3.zero)
			{
				this.bendNormal = vector;
			}
			this.animationNormal = this.bendNormal;
			this.IKIKNOCOLFD(ref this.axisDirectionsLeft);
			this.JPLEAPCOOCM(ref this.axisDirectionsRight);
		}

		// Token: 0x0600F9DD RID: 63965 RVA: 0x00705B68 File Offset: 0x00703D68
		private void MJMHMBKFBFB(ref IKSolverLimb.AxisDirection[] DGCALAMOLNH)
		{
			DGCALAMOLNH[1] = new IKSolverLimb.AxisDirection(Vector3.zero, new Vector3(840f, 327f, 1856f));
			DGCALAMOLNH[0] = new IKSolverLimb.AxisDirection(new Vector3(447f, 370f, 1601f), new Vector3(89f, 1386f, 219f));
			DGCALAMOLNH[6] = new IKSolverLimb.AxisDirection(new Vector3(906f, 38f, 440f), new Vector3(15f, 638f, 1363f));
			DGCALAMOLNH[2] = new IKSolverLimb.AxisDirection(new Vector3(355f, 936f, 713f), new Vector3(1293f, 1547f, 458f));
		}

		// Token: 0x0600F9DE RID: 63966 RVA: 0x00705C3C File Offset: 0x00703E3C
		protected virtual void OOFHOCNEECG()
		{
			if (this.IKPositionWeight > 1930f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 1074f, 1671f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 1873f, 1743f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.HMEHCINHEMN();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 445f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = false;
			}
		}

		// Token: 0x0600F9DF RID: 63967 RVA: 0x00705CE8 File Offset: 0x00703EE8
		protected virtual void BFAEDOLPCBA()
		{
			if (this.IKPositionWeight > 616f)
			{
				this.bendModifierWeight = Mathf.Clamp(this.bendModifierWeight, 1484f, 436f);
				this.maintainRotationWeight = Mathf.Clamp(this.maintainRotationWeight, 1272f, 1295f);
				this._bendNormal = this.bendNormal;
				this.bendNormal = this.HMEHCINHEMN();
			}
			if (this.maintainRotationWeight * this.IKPositionWeight > 493f)
			{
				this.bone3RotationBeforeSolve = (this.maintainRotationFor1Frame ? this.maintainRotation : this.bone3.transform.rotation);
				this.maintainRotationFor1Frame = true;
			}
		}

		// Token: 0x04002080 RID: 8320
		public AvatarIKGoal goal;

		// Token: 0x04002081 RID: 8321
		public IKSolverLimb.BendModifier bendModifier;

		// Token: 0x04002082 RID: 8322
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		// Token: 0x04002083 RID: 8323
		[Range(0f, 1f)]
		public float bendModifierWeight = 1f;

		// Token: 0x04002084 RID: 8324
		public Transform bendGoal;

		// Token: 0x04002085 RID: 8325
		private bool maintainBendFor1Frame;

		// Token: 0x04002086 RID: 8326
		private bool maintainRotationFor1Frame;

		// Token: 0x04002087 RID: 8327
		private Quaternion defaultRootRotation;

		// Token: 0x04002088 RID: 8328
		private Quaternion parentDefaultRotation;

		// Token: 0x04002089 RID: 8329
		private Quaternion bone3RotationBeforeSolve;

		// Token: 0x0400208A RID: 8330
		private Quaternion maintainRotation;

		// Token: 0x0400208B RID: 8331
		private Quaternion bone3DefaultRotation;

		// Token: 0x0400208C RID: 8332
		private Vector3 _bendNormal;

		// Token: 0x0400208D RID: 8333
		private Vector3 animationNormal;

		// Token: 0x0400208E RID: 8334
		private IKSolverLimb.AxisDirection[] axisDirectionsLeft = new IKSolverLimb.AxisDirection[4];

		// Token: 0x0400208F RID: 8335
		private IKSolverLimb.AxisDirection[] axisDirectionsRight = new IKSolverLimb.AxisDirection[4];

		// Token: 0x0200047A RID: 1146
		[Serializable]
		public enum BendModifier
		{
			// Token: 0x04002091 RID: 8337
			Animation,
			// Token: 0x04002092 RID: 8338
			Target,
			// Token: 0x04002093 RID: 8339
			Parent,
			// Token: 0x04002094 RID: 8340
			Arm,
			// Token: 0x04002095 RID: 8341
			Goal
		}

		// Token: 0x0200047B RID: 1147
		[Serializable]
		public struct AxisDirection
		{
			// Token: 0x0600F9E0 RID: 63968 RVA: 0x00705D91 File Offset: 0x00703F91
			public AxisDirection(Vector3 NEMFIHCKJPE, Vector3 HNANBJENIHC)
			{
				this.direction = NEMFIHCKJPE.normalized;
				this.axis = HNANBJENIHC.normalized;
				this.dot = 0f;
			}

			// Token: 0x04002096 RID: 8342
			public Vector3 direction;

			// Token: 0x04002097 RID: 8343
			public Vector3 axis;

			// Token: 0x04002098 RID: 8344
			public float dot;
		}
	}
}
