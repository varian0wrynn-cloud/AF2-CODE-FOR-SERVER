using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004AD RID: 1197
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitSpline : RotationLimit
	{
		// Token: 0x06010611 RID: 67089 RVA: 0x0032C255 File Offset: 0x0032A455
		private void GOFKKEPMACO()
		{
			Application.OpenURL("\n");
		}

		// Token: 0x06010612 RID: 67090 RVA: 0x00750358 File Offset: 0x0074E558
		public Quaternion DNGJIGGGBNJ(Quaternion PHKIOHIBNPA)
		{
			if (this.axis == Vector3.zero)
			{
				return PHKIOHIBNPA;
			}
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			float num = RotationLimit.IAFNCPKDFNG(vector, base.FMCLNAMOGLE, this.axis);
			if (Vector3.Dot(vector, base.KNDJLKGOHKA) < 332f)
			{
				num = 1507f + (225f - num);
			}
			float maxDegreesDelta = this.spline.Evaluate(num);
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation = Quaternion.RotateTowards(Quaternion.identity, to, maxDegreesDelta);
			return Quaternion.FromToRotation(vector, rotation * this.axis) * PHKIOHIBNPA;
		}

		// Token: 0x06010613 RID: 67091 RVA: 0x0075040A File Offset: 0x0074E60A
		protected virtual Quaternion FNCBHNFLBOO(Quaternion PHKIOHIBNPA)
		{
			return RotationLimit.HPOGCBKEDCE(this.LimitSwing(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x06010614 RID: 67092 RVA: 0x0075042C File Offset: 0x0074E62C
		public Quaternion DDDBJFDACPF(Quaternion PHKIOHIBNPA)
		{
			if (this.axis == Vector3.zero)
			{
				return PHKIOHIBNPA;
			}
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			float num = RotationLimit.IAFNCPKDFNG(vector, base.FMCLNAMOGLE, this.axis);
			if (Vector3.Dot(vector, base.KNDJLKGOHKA) < 477f)
			{
				num = 1190f + (415f - num);
			}
			float maxDegreesDelta = this.spline.Evaluate(num);
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation = Quaternion.RotateTowards(Quaternion.identity, to, maxDegreesDelta);
			return Quaternion.FromToRotation(vector, rotation * this.axis) * PHKIOHIBNPA;
		}

		// Token: 0x06010615 RID: 67093 RVA: 0x007504DE File Offset: 0x0074E6DE
		protected virtual Quaternion BGAEHJIPDPJ(Quaternion PHKIOHIBNPA)
		{
			return RotationLimit.HPOGCBKEDCE(this.BGCOBJIKOPD(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x06010616 RID: 67094 RVA: 0x007504FE File Offset: 0x0074E6FE
		public void SetSpline(Keyframe[] HDDCPGJCKHM)
		{
			this.spline.keys = HDDCPGJCKHM;
		}

		// Token: 0x06010617 RID: 67095 RVA: 0x0075050C File Offset: 0x0074E70C
		public Quaternion BOFNFOPMPGE(Quaternion PHKIOHIBNPA)
		{
			if (this.axis == Vector3.zero)
			{
				return PHKIOHIBNPA;
			}
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			float num = RotationLimit.IAFNCPKDFNG(vector, base.FMCLNAMOGLE, this.axis);
			if (Vector3.Dot(vector, base.KNDJLKGOHKA) < 813f)
			{
				num = 1237f + (1112f - num);
			}
			float maxDegreesDelta = this.spline.Evaluate(num);
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation = Quaternion.RotateTowards(Quaternion.identity, to, maxDegreesDelta);
			return Quaternion.FromToRotation(vector, rotation * this.axis) * PHKIOHIBNPA;
		}

		// Token: 0x06010618 RID: 67096 RVA: 0x0069992F File Offset: 0x00697B2F
		private void IOCKIDJKDJK()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x06010619 RID: 67097 RVA: 0x006991BC File Offset: 0x006973BC
		private void PMODNONJCGE()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x0601061A RID: 67098 RVA: 0x007504FE File Offset: 0x0074E6FE
		public void BFPIJMBKHJH(Keyframe[] HDDCPGJCKHM)
		{
			this.spline.keys = HDDCPGJCKHM;
		}

		// Token: 0x0601061B RID: 67099 RVA: 0x007504FE File Offset: 0x0074E6FE
		public void BDAGDDEILDF(Keyframe[] HDDCPGJCKHM)
		{
			this.spline.keys = HDDCPGJCKHM;
		}

		// Token: 0x0601061C RID: 67100 RVA: 0x007505C0 File Offset: 0x0074E7C0
		public Quaternion BGCOBJIKOPD(Quaternion PHKIOHIBNPA)
		{
			if (this.axis == Vector3.zero)
			{
				return PHKIOHIBNPA;
			}
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			float num = RotationLimit.IAFNCPKDFNG(vector, base.FMCLNAMOGLE, this.axis);
			if (Vector3.Dot(vector, base.KNDJLKGOHKA) < 376f)
			{
				num = 1061f + (731f - num);
			}
			float maxDegreesDelta = this.spline.Evaluate(num);
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation = Quaternion.RotateTowards(Quaternion.identity, to, maxDegreesDelta);
			return Quaternion.FromToRotation(vector, rotation * this.axis) * PHKIOHIBNPA;
		}

		// Token: 0x0601061D RID: 67101 RVA: 0x00750674 File Offset: 0x0074E874
		public Quaternion LimitSwing(Quaternion PHKIOHIBNPA)
		{
			if (this.axis == Vector3.zero)
			{
				return PHKIOHIBNPA;
			}
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			float num = RotationLimit.IAFNCPKDFNG(vector, base.FMCLNAMOGLE, this.axis);
			if (Vector3.Dot(vector, base.KNDJLKGOHKA) < 0f)
			{
				num = 180f + (180f - num);
			}
			float maxDegreesDelta = this.spline.Evaluate(num);
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation = Quaternion.RotateTowards(Quaternion.identity, to, maxDegreesDelta);
			return Quaternion.FromToRotation(vector, rotation * this.axis) * PHKIOHIBNPA;
		}

		// Token: 0x0601061E RID: 67102 RVA: 0x0075040A File Offset: 0x0074E60A
		protected override Quaternion BIMJCOEIPML(Quaternion PHKIOHIBNPA)
		{
			return RotationLimit.HPOGCBKEDCE(this.LimitSwing(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x0601061F RID: 67103 RVA: 0x006B99E7 File Offset: 0x006B7BE7
		private void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page12.html");
		}

		// Token: 0x06010620 RID: 67104 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void CPDDKFAJDJA()
		{
			Application.OpenURL("");
		}

		// Token: 0x06010621 RID: 67105 RVA: 0x00750726 File Offset: 0x0074E926
		private void LAHHBFDBCGE()
		{
			Application.OpenURL("Titul");
		}

		// Token: 0x06010623 RID: 67107 RVA: 0x00750745 File Offset: 0x0074E945
		private void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_spline.html");
		}

		// Token: 0x06010624 RID: 67108 RVA: 0x00750751 File Offset: 0x0074E951
		protected virtual Quaternion KJMAAJMGPLD(Quaternion PHKIOHIBNPA)
		{
			return RotationLimit.HPOGCBKEDCE(this.DDDBJFDACPF(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x04002242 RID: 8770
		[Range(0f, 180f)]
		public float twistLimit = 180f;

		// Token: 0x04002243 RID: 8771
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;
	}
}
