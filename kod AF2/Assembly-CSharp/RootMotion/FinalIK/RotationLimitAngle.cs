using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004A8 RID: 1192
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitAngle : RotationLimit
	{
		// Token: 0x060104C1 RID: 66753 RVA: 0x0074AE70 File Offset: 0x00749070
		private Quaternion DDDBJFDACPF(Quaternion PHKIOHIBNPA)
		{
			if (this.axis == Vector3.zero)
			{
				return PHKIOHIBNPA;
			}
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			if (this.limit >= 1505f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation = Quaternion.RotateTowards(Quaternion.identity, to, this.limit);
			return Quaternion.FromToRotation(vector, rotation * this.axis) * PHKIOHIBNPA;
		}

		// Token: 0x060104C2 RID: 66754 RVA: 0x0073845E File Offset: 0x0073665E
		private void OLNLGIKDOJK()
		{
			Application.OpenURL("help");
		}

		// Token: 0x060104C3 RID: 66755 RVA: 0x0074AEF4 File Offset: 0x007490F4
		private Quaternion BBJJIHLECPE(Quaternion PHKIOHIBNPA)
		{
			if (this.axis == Vector3.zero)
			{
				return PHKIOHIBNPA;
			}
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			if (this.limit >= 1620f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation = Quaternion.RotateTowards(Quaternion.identity, to, this.limit);
			return Quaternion.FromToRotation(vector, rotation * this.axis) * PHKIOHIBNPA;
		}

		// Token: 0x060104C4 RID: 66756 RVA: 0x0074AF78 File Offset: 0x00749178
		private Quaternion IPJHOGFCKNE(Quaternion PHKIOHIBNPA)
		{
			if (this.axis == Vector3.zero)
			{
				return PHKIOHIBNPA;
			}
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			if (this.limit >= 1754f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation = Quaternion.RotateTowards(Quaternion.identity, to, this.limit);
			return Quaternion.FromToRotation(vector, rotation * this.axis) * PHKIOHIBNPA;
		}

		// Token: 0x060104C5 RID: 66757 RVA: 0x0074AFFB File Offset: 0x007491FB
		private void KANNFIPFIKC()
		{
			Application.OpenURL("Up Hill Walk");
		}

		// Token: 0x060104C6 RID: 66758 RVA: 0x0074B007 File Offset: 0x00749207
		private void HCDBIHPOLIB()
		{
			Application.OpenURL("wpn_wgt");
		}

		// Token: 0x060104C7 RID: 66759 RVA: 0x0074B013 File Offset: 0x00749213
		private void GOCHJDILHDH()
		{
			Application.OpenURL(" Atlas: ");
		}

		// Token: 0x060104C8 RID: 66760 RVA: 0x0074B020 File Offset: 0x00749220
		private Quaternion BECMBPNGOIG(Quaternion PHKIOHIBNPA)
		{
			if (this.axis == Vector3.zero)
			{
				return PHKIOHIBNPA;
			}
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			if (this.limit >= 180f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation = Quaternion.RotateTowards(Quaternion.identity, to, this.limit);
			return Quaternion.FromToRotation(vector, rotation * this.axis) * PHKIOHIBNPA;
		}

		// Token: 0x060104C9 RID: 66761 RVA: 0x0074B0A3 File Offset: 0x007492A3
		protected virtual Quaternion DOKAIINEAJO(Quaternion PHKIOHIBNPA)
		{
			return RotationLimit.HPOGCBKEDCE(this.BECMBPNGOIG(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x060104CA RID: 66762 RVA: 0x0069992F File Offset: 0x00697B2F
		private void IOCKIDJKDJK()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x060104CB RID: 66763 RVA: 0x0074B0C3 File Offset: 0x007492C3
		private void JIMEIANEAPG()
		{
			Application.OpenURL("Watering Can Watering");
		}

		// Token: 0x060104CC RID: 66764 RVA: 0x0074B0D0 File Offset: 0x007492D0
		private Quaternion IJKPJIHEAIE(Quaternion PHKIOHIBNPA)
		{
			if (this.axis == Vector3.zero)
			{
				return PHKIOHIBNPA;
			}
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			if (this.limit >= 540f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation = Quaternion.RotateTowards(Quaternion.identity, to, this.limit);
			return Quaternion.FromToRotation(vector, rotation * this.axis) * PHKIOHIBNPA;
		}

		// Token: 0x060104CD RID: 66765 RVA: 0x0074B154 File Offset: 0x00749354
		private Quaternion MNHBBOHPJGM(Quaternion PHKIOHIBNPA)
		{
			if (this.axis == Vector3.zero)
			{
				return PHKIOHIBNPA;
			}
			if (PHKIOHIBNPA == Quaternion.identity)
			{
				return PHKIOHIBNPA;
			}
			if (this.limit >= 921f)
			{
				return PHKIOHIBNPA;
			}
			Vector3 vector = PHKIOHIBNPA * this.axis;
			Quaternion to = Quaternion.FromToRotation(this.axis, vector);
			Quaternion rotation = Quaternion.RotateTowards(Quaternion.identity, to, this.limit);
			return Quaternion.FromToRotation(vector, rotation * this.axis) * PHKIOHIBNPA;
		}

		// Token: 0x060104CE RID: 66766 RVA: 0x0074B1D7 File Offset: 0x007493D7
		protected virtual Quaternion AIEEOLCKPJM(Quaternion PHKIOHIBNPA)
		{
			return RotationLimit.HPOGCBKEDCE(this.BBJJIHLECPE(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x060104CF RID: 66767 RVA: 0x006B6DD2 File Offset: 0x006B4FD2
		private void FCJCNHOELLJ()
		{
			Application.OpenURL(" ");
		}

		// Token: 0x060104D0 RID: 66768 RVA: 0x006A86AC File Offset: 0x006A68AC
		private void FMOMEKLAOIK()
		{
			Application.OpenURL("BlackSmithHammer");
		}

		// Token: 0x060104D1 RID: 66769 RVA: 0x0074B1F7 File Offset: 0x007493F7
		protected virtual Quaternion AGIMFHPCGEP(Quaternion PHKIOHIBNPA)
		{
			return RotationLimit.HPOGCBKEDCE(this.MNHBBOHPJGM(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x060104D2 RID: 66770 RVA: 0x006991BC File Offset: 0x006973BC
		private void PMODNONJCGE()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x060104D3 RID: 66771 RVA: 0x006B6F55 File Offset: 0x006B5155
		private void BLOIBECPHAL()
		{
			Application.OpenURL("_MainTex");
		}

		// Token: 0x060104D4 RID: 66772 RVA: 0x006B99E7 File Offset: 0x006B7BE7
		private void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page12.html");
		}

		// Token: 0x060104D5 RID: 66773 RVA: 0x0074B217 File Offset: 0x00749417
		private void GOBPKNJPLFB()
		{
			Application.OpenURL("StartControllerModule");
		}

		// Token: 0x060104D6 RID: 66774 RVA: 0x0074B223 File Offset: 0x00749423
		private void BLIPLMEEAND()
		{
			Application.OpenURL("repair.ogg");
		}

		// Token: 0x060104D7 RID: 66775 RVA: 0x0074B22F File Offset: 0x0074942F
		private void HBNIBCMMOML()
		{
			Application.OpenURL("Weapon Reload");
		}

		// Token: 0x060104D8 RID: 66776 RVA: 0x0074B23B File Offset: 0x0074943B
		private void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_angle.html");
		}

		// Token: 0x060104D9 RID: 66777 RVA: 0x006B933E File Offset: 0x006B753E
		private void FALEAGFLCFH()
		{
			Application.OpenURL("Giant2HandSlamIdle");
		}

		// Token: 0x060104DA RID: 66778 RVA: 0x006B96BD File Offset: 0x006B78BD
		private void KIOBNGIOBBJ()
		{
			Application.OpenURL("DeadmanFloat");
		}

		// Token: 0x060104DB RID: 66779 RVA: 0x0074B247 File Offset: 0x00749447
		private void NHDBJMJIDNC()
		{
			Application.OpenURL("____________________________________");
		}

		// Token: 0x060104DC RID: 66780 RVA: 0x0074B0A3 File Offset: 0x007492A3
		protected override Quaternion BIMJCOEIPML(Quaternion PHKIOHIBNPA)
		{
			return RotationLimit.HPOGCBKEDCE(this.BECMBPNGOIG(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x060104DD RID: 66781 RVA: 0x0074B253 File Offset: 0x00749453
		protected virtual Quaternion ABDLHOBMKJJ(Quaternion PHKIOHIBNPA)
		{
			return RotationLimit.HPOGCBKEDCE(this.DDDBJFDACPF(PHKIOHIBNPA), this.axis, base.FMCLNAMOGLE, this.twistLimit);
		}

		// Token: 0x0400222F RID: 8751
		[Range(0f, 180f)]
		public float limit = 45f;

		// Token: 0x04002230 RID: 8752
		[Range(0f, 180f)]
		public float twistLimit = 180f;
	}
}
