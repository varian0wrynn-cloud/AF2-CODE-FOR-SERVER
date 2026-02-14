using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x020004A9 RID: 1193
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	public class RotationLimitHinge : RotationLimit
	{
		// Token: 0x060104DE RID: 66782 RVA: 0x0074B273 File Offset: 0x00749473
		protected override Quaternion BIMJCOEIPML(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.FPOHFMONGPE(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x060104DF RID: 66783 RVA: 0x0074B288 File Offset: 0x00749488
		private void LAHHBFDBCGE()
		{
			Application.OpenURL("Attack");
		}

		// Token: 0x060104E0 RID: 66784 RVA: 0x006B99E7 File Offset: 0x006B7BE7
		private void NLLHEACBOPP()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/page12.html");
		}

		// Token: 0x060104E1 RID: 66785 RVA: 0x0074B294 File Offset: 0x00749494
		private void GOFKKEPMACO()
		{
			Application.OpenURL("_FogSpeed");
		}

		// Token: 0x060104E2 RID: 66786 RVA: 0x0074B2A0 File Offset: 0x007494A0
		protected virtual Quaternion EGNIMBBHLKC(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.AFPNNDPONHP(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x060104E3 RID: 66787 RVA: 0x006A8CA3 File Offset: 0x006A6EA3
		private void LDPLKAHAJHH()
		{
			Application.OpenURL("WRINKLE_MAPS");
		}

		// Token: 0x060104E4 RID: 66788 RVA: 0x0074B2B5 File Offset: 0x007494B5
		private void AFKBGCAFDFM()
		{
			Application.OpenURL("post_15");
		}

		// Token: 0x060104E5 RID: 66789 RVA: 0x0074B2A0 File Offset: 0x007494A0
		protected virtual Quaternion DOKAIINEAJO(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.AFPNNDPONHP(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x060104E6 RID: 66790 RVA: 0x0074B2C4 File Offset: 0x007494C4
		private Quaternion MCJGIAHOMLC(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 33f && this.max == 280f && this.useLimits)
			{
				return Quaternion.AngleAxis(696f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 457f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x060104E7 RID: 66791 RVA: 0x0074B3B7 File Offset: 0x007495B7
		protected virtual Quaternion NIINAAJHCBB(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.AAEGBAHNCAP(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x060104E8 RID: 66792 RVA: 0x0074B3CC File Offset: 0x007495CC
		private void IMBPHLCJONG()
		{
			Application.OpenURL("ENABLE_USER_LUT");
		}

		// Token: 0x060104E9 RID: 66793 RVA: 0x0032C110 File Offset: 0x0032A310
		private void HCGPLMOBPMM()
		{
			Application.OpenURL("_Offsets");
		}

		// Token: 0x060104EA RID: 66794 RVA: 0x0074B3D8 File Offset: 0x007495D8
		protected virtual Quaternion NLFLIJKKDCB(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.CDMJGPECHNM(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x060104EB RID: 66795 RVA: 0x0074B3F0 File Offset: 0x007495F0
		private Quaternion CDMJGPECHNM(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 1243f && this.max == 311f && this.useLimits)
			{
				return Quaternion.AngleAxis(1278f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 1251f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x060104EC RID: 66796 RVA: 0x0074B4E3 File Offset: 0x007496E3
		private void BDNGDEBOMML()
		{
			Application.OpenURL("WalkDehydrated");
		}

		// Token: 0x060104ED RID: 66797 RVA: 0x0074B4EF File Offset: 0x007496EF
		private void HKAMOEDOGJH()
		{
			Application.OpenURL("demoColor");
		}

		// Token: 0x060104EE RID: 66798 RVA: 0x006B984F File Offset: 0x006B7A4F
		private void DJDNPIPDCAN()
		{
			Application.OpenURL("[minwgt]");
		}

		// Token: 0x060104EF RID: 66799 RVA: 0x0074B4FB File Offset: 0x007496FB
		private void KAOLHAAAICG()
		{
			Application.OpenURL("_Color");
		}

		// Token: 0x060104F0 RID: 66800 RVA: 0x0074B508 File Offset: 0x00749708
		private Quaternion NBLMDIAHFGD(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 1224f && this.max == 663f && this.useLimits)
			{
				return Quaternion.AngleAxis(165f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 393f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x060104F1 RID: 66801 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void KJLPGEFKAMF()
		{
			Application.OpenURL("");
		}

		// Token: 0x060104F2 RID: 66802 RVA: 0x0074B5FB File Offset: 0x007497FB
		private void KGOIGLJNKLK()
		{
			Application.OpenURL("{0}.{1}.{2}");
		}

		// Token: 0x060104F3 RID: 66803 RVA: 0x0074B607 File Offset: 0x00749807
		protected virtual Quaternion ANFLHMKNKBJ(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.EJIAGLPCICH(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x060104F4 RID: 66804 RVA: 0x0074B61C File Offset: 0x0074981C
		private void IJMBFNNMAPC()
		{
			Application.OpenURL("Textures/Weapons/");
		}

		// Token: 0x060104F5 RID: 66805 RVA: 0x0074B628 File Offset: 0x00749828
		private void MGEFFOACDHM()
		{
			Application.OpenURL("LockToDevice level");
		}

		// Token: 0x060104F6 RID: 66806 RVA: 0x0074B634 File Offset: 0x00749834
		private void EAAIGKJCDOH()
		{
			Application.OpenURL("wpn id:");
		}

		// Token: 0x060104F7 RID: 66807 RVA: 0x0074B640 File Offset: 0x00749840
		private Quaternion LBOIJAJEFEF(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 1150f && this.max == 103f && this.useLimits)
			{
				return Quaternion.AngleAxis(1223f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 1795f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x060104F8 RID: 66808 RVA: 0x0074B734 File Offset: 0x00749934
		private Quaternion GAOJGCFGCLA(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 1454f && this.max == 538f && this.useLimits)
			{
				return Quaternion.AngleAxis(781f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 1694f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x060104F9 RID: 66809 RVA: 0x006B92BE File Offset: 0x006B74BE
		private void HOANODKDLBI()
		{
			Application.OpenURL("no_inventory");
		}

		// Token: 0x060104FA RID: 66810 RVA: 0x0074B827 File Offset: 0x00749A27
		private void OCMMDKMGCGL()
		{
			Application.OpenURL("ClimbRight");
		}

		// Token: 0x060104FB RID: 66811 RVA: 0x006B6F31 File Offset: 0x006B5131
		private void KHNOOPGDPGD()
		{
			Application.OpenURL("error.wav");
		}

		// Token: 0x060104FC RID: 66812 RVA: 0x0074B833 File Offset: 0x00749A33
		private void PHIPLGNEIBJ()
		{
			Application.OpenURL("cht_maxcnt");
		}

		// Token: 0x060104FD RID: 66813 RVA: 0x0074B840 File Offset: 0x00749A40
		private Quaternion AFPNNDPONHP(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 198f && this.max == 184f && this.useLimits)
			{
				return Quaternion.AngleAxis(1866f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 393f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x060104FE RID: 66814 RVA: 0x0074B933 File Offset: 0x00749B33
		private void JIMEIANEAPG()
		{
			Application.OpenURL(" dataid=");
		}

		// Token: 0x060104FF RID: 66815 RVA: 0x0072EF24 File Offset: 0x0072D124
		private void HBHJBOFKLID()
		{
			Application.OpenURL("MotorbikeHeartAttack");
		}

		// Token: 0x06010500 RID: 66816 RVA: 0x0074B93F File Offset: 0x00749B3F
		private void OCJBHALPDON()
		{
			Application.OpenURL("stacheaderprocess");
		}

		// Token: 0x06010501 RID: 66817 RVA: 0x0074B94B File Offset: 0x00749B4B
		private void DMLGIIPKFHC()
		{
			Application.OpenURL("dd/MM/yyyy HH:mm");
		}

		// Token: 0x06010502 RID: 66818 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void OFKECLECCEA()
		{
			Application.OpenURL("");
		}

		// Token: 0x06010503 RID: 66819 RVA: 0x0074B957 File Offset: 0x00749B57
		protected virtual Quaternion EGJKJALPMKD(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.OPCCBECBEOI(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x06010504 RID: 66820 RVA: 0x00737653 File Offset: 0x00735853
		private void NEMAPKKAPOF()
		{
			Application.OpenURL("CrawlIdle");
		}

		// Token: 0x06010505 RID: 66821 RVA: 0x0074B96C File Offset: 0x00749B6C
		protected virtual Quaternion HBBMJACAELH(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.BIFJCCLONOJ(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x06010506 RID: 66822 RVA: 0x006AA69F File Offset: 0x006A889F
		private void HANCPFPDGOI()
		{
			Application.OpenURL("error");
		}

		// Token: 0x06010507 RID: 66823 RVA: 0x0074B981 File Offset: 0x00749B81
		private void EEDHMJPJNNM()
		{
			Application.OpenURL("BowReady2");
		}

		// Token: 0x06010508 RID: 66824 RVA: 0x0074B957 File Offset: 0x00749B57
		protected virtual Quaternion GLHBKFHGPBM(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.OPCCBECBEOI(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x0601050A RID: 66826 RVA: 0x0074B9BD File Offset: 0x00749BBD
		private void EKNFBLPDEBP()
		{
			Application.OpenURL("{0,-28}{1,-28}{2,-28}{3,-28}{4,-28}{5,-28}{6,-28}");
		}

		// Token: 0x0601050B RID: 66827 RVA: 0x0074B9C9 File Offset: 0x00749BC9
		private void GFKLCOJJHPH()
		{
			Application.OpenURL("crft_norec");
		}

		// Token: 0x0601050C RID: 66828 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void KNMDJIPKMCI()
		{
			Application.OpenURL("");
		}

		// Token: 0x0601050D RID: 66829 RVA: 0x0074B9D5 File Offset: 0x00749BD5
		protected virtual Quaternion GCKIFLKAHJH(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.JGFFGGMDIPK(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x0601050E RID: 66830 RVA: 0x0074B9EA File Offset: 0x00749BEA
		private void DGEKBOCHNLD()
		{
			Application.OpenURL("IdleStun");
		}

		// Token: 0x0601050F RID: 66831 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void MMJNMJACIHE()
		{
			Application.OpenURL("");
		}

		// Token: 0x06010510 RID: 66832 RVA: 0x0074B9F6 File Offset: 0x00749BF6
		protected virtual Quaternion KKCNOIFCBJI(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.LBOIJAJEFEF(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x06010511 RID: 66833 RVA: 0x0074BA0C File Offset: 0x00749C0C
		private Quaternion JGFFGGMDIPK(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 1151f && this.max == 1882f && this.useLimits)
			{
				return Quaternion.AngleAxis(613f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 1992f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x06010512 RID: 66834 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void DOILOPFLLPB()
		{
			Application.OpenURL("");
		}

		// Token: 0x06010513 RID: 66835 RVA: 0x0074BB00 File Offset: 0x00749D00
		private Quaternion OPCCBECBEOI(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 650f && this.max == 637f && this.useLimits)
			{
				return Quaternion.AngleAxis(36f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 1554f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x06010514 RID: 66836 RVA: 0x006991C8 File Offset: 0x006973C8
		private void OHDDEDPECAH()
		{
			Application.OpenURL("</color>");
		}

		// Token: 0x06010515 RID: 66837 RVA: 0x0074BBF3 File Offset: 0x00749DF3
		private void LNMOHKPONFO()
		{
			Application.OpenURL("NprPhysPoint");
		}

		// Token: 0x06010516 RID: 66838 RVA: 0x006B7496 File Offset: 0x006B5696
		private void KIGJKNLCBEK()
		{
			Application.OpenURL("OfficeSitting45DegLeg");
		}

		// Token: 0x06010517 RID: 66839 RVA: 0x006991BC File Offset: 0x006973BC
		private void PMODNONJCGE()
		{
			Application.OpenURL("http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/");
		}

		// Token: 0x06010518 RID: 66840 RVA: 0x006A5E0D File Offset: 0x006A400D
		private void FHGPNFHLKCE()
		{
			Application.OpenURL("ok");
		}

		// Token: 0x06010519 RID: 66841 RVA: 0x0069992F File Offset: 0x00697B2F
		private void IOCKIDJKDJK()
		{
			Application.OpenURL("https://groups.google.com/forum/#!forum/final-ik");
		}

		// Token: 0x0601051A RID: 66842 RVA: 0x0074BBFF File Offset: 0x00749DFF
		private void AFEMLFIOJIA()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_hinge.html");
		}

		// Token: 0x0601051B RID: 66843 RVA: 0x0074BC0C File Offset: 0x00749E0C
		private Quaternion EJIAGLPCICH(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 1170f && this.max == 27f && this.useLimits)
			{
				return Quaternion.AngleAxis(814f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 351f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x0601051C RID: 66844 RVA: 0x0074BCFF File Offset: 0x00749EFF
		private void KIBHPKPBNLK()
		{
			Application.OpenURL("Sitting Reading Page Flip");
		}

		// Token: 0x0601051D RID: 66845 RVA: 0x0074BD0C File Offset: 0x00749F0C
		private Quaternion BIFJCCLONOJ(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 508f && this.max == 225f && this.useLimits)
			{
				return Quaternion.AngleAxis(1678f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 181f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x0601051E RID: 66846 RVA: 0x0074BDFF File Offset: 0x00749FFF
		private void HIHJCGPJCKB()
		{
			Application.OpenURL("RenderType");
		}

		// Token: 0x0601051F RID: 66847 RVA: 0x0074BE0B File Offset: 0x0074A00B
		private void IBIHPJMMGOG()
		{
			Application.OpenURL("_ALPHABLEND_ON");
		}

		// Token: 0x06010520 RID: 66848 RVA: 0x0074BE17 File Offset: 0x0074A017
		private void EDIBMGGFMMJ()
		{
			Application.OpenURL("ObscuredShort vs short, ");
		}

		// Token: 0x06010521 RID: 66849 RVA: 0x0074BE23 File Offset: 0x0074A023
		private void IHNDHAPOAFC()
		{
			Application.OpenURL("textAsset is NULL! Path: Weapons");
		}

		// Token: 0x06010522 RID: 66850 RVA: 0x0074BE2F File Offset: 0x0074A02F
		private void LJHFGPFBHLL()
		{
			Application.OpenURL("msg_other");
		}

		// Token: 0x06010523 RID: 66851 RVA: 0x0074B96C File Offset: 0x00749B6C
		protected virtual Quaternion OKCLEMKHIMD(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.BIFJCCLONOJ(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x06010524 RID: 66852 RVA: 0x0074BE3B File Offset: 0x0074A03B
		private void OHNBHGAAOGN()
		{
			Application.OpenURL("The InteractionTrigger in the list 'inContact' has been destroyed");
		}

		// Token: 0x06010525 RID: 66853 RVA: 0x006B9927 File Offset: 0x006B7B27
		private void IJDLPDLFAMM()
		{
			Application.OpenURL("OfficeSittingReadingCoffeeSip");
		}

		// Token: 0x06010526 RID: 66854 RVA: 0x0032BF3E File Offset: 0x0032A13E
		private void PKFJNILBGAJ()
		{
			Application.OpenURL("");
		}

		// Token: 0x06010527 RID: 66855 RVA: 0x0074BE47 File Offset: 0x0074A047
		private void BNNHCCJNADN()
		{
			Application.OpenURL("Blending ");
		}

		// Token: 0x06010528 RID: 66856 RVA: 0x0032C255 File Offset: 0x0032A455
		private void CMBHEBDADKB()
		{
			Application.OpenURL("\n");
		}

		// Token: 0x06010529 RID: 66857 RVA: 0x0074BE54 File Offset: 0x0074A054
		private Quaternion FPOHFMONGPE(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 0f && this.max == 0f && this.useLimits)
			{
				return Quaternion.AngleAxis(0f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 0f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x0601052A RID: 66858 RVA: 0x0074BF48 File Offset: 0x0074A148
		private Quaternion JHLFCKMCAGD(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 1957f && this.max == 1778f && this.useLimits)
			{
				return Quaternion.AngleAxis(1706f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 1839f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x0601052B RID: 66859 RVA: 0x0074C03C File Offset: 0x0074A23C
		private Quaternion FGOMCMECHGB(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 1817f && this.max == 1649f && this.useLimits)
			{
				return Quaternion.AngleAxis(1591f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 1637f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x0601052C RID: 66860 RVA: 0x0074C12F File Offset: 0x0074A32F
		protected virtual Quaternion LBGPIEPHBLM(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.MCJGIAHOMLC(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x0601052D RID: 66861 RVA: 0x0074C144 File Offset: 0x0074A344
		private void LFBJPFALGOB()
		{
			Application.OpenURL("sunshine_ShadowCoordDepthRayV");
		}

		// Token: 0x0601052E RID: 66862 RVA: 0x0074C150 File Offset: 0x0074A350
		private void PPGAKCGHHJL()
		{
			Application.OpenURL("ObscuredDouble vs double, ");
		}

		// Token: 0x0601052F RID: 66863 RVA: 0x0074C15C File Offset: 0x0074A35C
		private void PAFILAINLDK()
		{
			Application.OpenURL("Root");
		}

		// Token: 0x06010530 RID: 66864 RVA: 0x0074B96C File Offset: 0x00749B6C
		protected virtual Quaternion LEACBBNONIG(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.BIFJCCLONOJ(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x06010531 RID: 66865 RVA: 0x006AF57C File Offset: 0x006AD77C
		private void PIBCLLHPDAB()
		{
			Application.OpenURL("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_grounder_quadruped.html");
		}

		// Token: 0x06010532 RID: 66866 RVA: 0x0074C168 File Offset: 0x0074A368
		private Quaternion AAEGBAHNCAP(Quaternion PHKIOHIBNPA)
		{
			if (this.min == 609f && this.max == 1912f && this.useLimits)
			{
				return Quaternion.AngleAxis(1621f, this.axis);
			}
			Quaternion quaternion = RotationLimit.HIMOMPDCDOH(PHKIOHIBNPA, this.axis);
			if (!this.useLimits)
			{
				return quaternion;
			}
			Quaternion quaternion2 = quaternion * Quaternion.Inverse(this.MHNMPOMNDBH);
			float num = Quaternion.Angle(Quaternion.identity, quaternion2);
			Vector3 vector = new Vector3(this.axis.z, this.axis.x, this.axis.y);
			Vector3 rhs = Vector3.Cross(vector, this.axis);
			if (Vector3.Dot(quaternion2 * vector, rhs) > 698f)
			{
				num = -num;
			}
			this.AGJIGDJFNGF = Mathf.Clamp(this.AGJIGDJFNGF + num, this.min, this.max);
			return Quaternion.AngleAxis(this.AGJIGDJFNGF, this.axis);
		}

		// Token: 0x06010533 RID: 66867 RVA: 0x0074C25B File Offset: 0x0074A45B
		private void APBIKIFIAHN()
		{
			Application.OpenURL("{0}{1}{2}{3}");
		}

		// Token: 0x06010534 RID: 66868 RVA: 0x0074C267 File Offset: 0x0074A467
		private void OGPMHGBFCBK()
		{
			Application.OpenURL("Internal Curves Texture");
		}

		// Token: 0x06010535 RID: 66869 RVA: 0x0074C273 File Offset: 0x0074A473
		private void JDNGJFGHKOH()
		{
			Application.OpenURL("#ff80ff");
		}

		// Token: 0x06010536 RID: 66870 RVA: 0x006AA28C File Offset: 0x006A848C
		private void LDFOKFKEMNO()
		{
			Application.OpenURL("wpn_onlyw");
		}

		// Token: 0x06010537 RID: 66871 RVA: 0x006B933E File Offset: 0x006B753E
		private void DFONLLGOJNM()
		{
			Application.OpenURL("Giant2HandSlamIdle");
		}

		// Token: 0x06010538 RID: 66872 RVA: 0x0074B3D8 File Offset: 0x007495D8
		protected virtual Quaternion KNDEHIOMKGB(Quaternion PHKIOHIBNPA)
		{
			this.MHNMPOMNDBH = this.CDMJGPECHNM(PHKIOHIBNPA);
			return this.MHNMPOMNDBH;
		}

		// Token: 0x04002231 RID: 8753
		public bool useLimits = true;

		// Token: 0x04002232 RID: 8754
		public float min = -45f;

		// Token: 0x04002233 RID: 8755
		public float max = 90f;

		// Token: 0x04002234 RID: 8756
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		// Token: 0x04002235 RID: 8757
		private Quaternion MHNMPOMNDBH = Quaternion.identity;

		// Token: 0x04002236 RID: 8758
		private float AGJIGDJFNGF;
	}
}
