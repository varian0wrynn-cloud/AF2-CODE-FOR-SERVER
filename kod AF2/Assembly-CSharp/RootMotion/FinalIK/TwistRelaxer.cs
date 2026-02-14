using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	// Token: 0x0200048B RID: 1163
	public class TwistRelaxer : MonoBehaviour
	{
		// Token: 0x0600FDDC RID: 64988 RVA: 0x007254ED File Offset: 0x007236ED
		private void EIEKEPGNGPL()
		{
			this.ECJPKAIKKDB();
		}

		// Token: 0x0600FDDD RID: 64989 RVA: 0x007254F8 File Offset: 0x007236F8
		public void EKBMLJLJNEO()
		{
			if (this.weight <= 425f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 505f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDDE RID: 64990 RVA: 0x007255F8 File Offset: 0x007237F8
		public void LBFNNBPNECK()
		{
			if (this.weight <= 456f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 886f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDDF RID: 64991 RVA: 0x007256F8 File Offset: 0x007238F8
		private void FJGIBCHABIG()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FDE0 RID: 64992 RVA: 0x00725754 File Offset: 0x00723954
		private void MKNDDFMIGDN()
		{
			this.GNNBIOFBOPO();
		}

		// Token: 0x0600FDE1 RID: 64993 RVA: 0x0072575C File Offset: 0x0072395C
		private void OFGMIEJKMGC()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FDE2 RID: 64994 RVA: 0x007257B8 File Offset: 0x007239B8
		private void OEKHPJAEAAE()
		{
			this.LBFNNBPNECK();
		}

		// Token: 0x0600FDE3 RID: 64995 RVA: 0x007257C0 File Offset: 0x007239C0
		private void HFHGBPFDMGJ()
		{
			this.CNBBBNNPKEK();
		}

		// Token: 0x0600FDE4 RID: 64996 RVA: 0x007257C8 File Offset: 0x007239C8
		private void AOGONMIBGJK()
		{
			this.OFBMLIKGGKF();
		}

		// Token: 0x0600FDE5 RID: 64997 RVA: 0x007257D0 File Offset: 0x007239D0
		public void NFODJMNCMHD()
		{
			if (this.weight <= 79f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 648f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDE6 RID: 64998 RVA: 0x007258D0 File Offset: 0x00723AD0
		public void LKADOPLAOEL()
		{
			if (this.weight <= 1488f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 272f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDE7 RID: 64999 RVA: 0x007259D0 File Offset: 0x00723BD0
		private void IAJCKOGDIMM()
		{
			this.CODEIPKHKJN();
		}

		// Token: 0x0600FDE8 RID: 65000 RVA: 0x007259D8 File Offset: 0x00723BD8
		private void AEAPIKAENBD()
		{
			this.GJAMOKKPJLD();
		}

		// Token: 0x0600FDE9 RID: 65001 RVA: 0x007259E0 File Offset: 0x00723BE0
		public void EPNHKGCAGME()
		{
			if (this.weight <= 1916f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 150f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDEA RID: 65002 RVA: 0x00725AE0 File Offset: 0x00723CE0
		public void KFOJPOMCIPP()
		{
			if (this.weight <= 947f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1188f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDEB RID: 65003 RVA: 0x00725BE0 File Offset: 0x00723DE0
		public void LCBBPDECFGG()
		{
			if (this.weight <= 479f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1156f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDEC RID: 65004 RVA: 0x00725CE0 File Offset: 0x00723EE0
		public void JAHJLHGKJGG()
		{
			if (this.weight <= 782f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1908f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDED RID: 65005 RVA: 0x00725DE0 File Offset: 0x00723FE0
		public void HCKJJBCJHLP()
		{
			if (this.weight <= 85f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 932f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDEE RID: 65006 RVA: 0x00725EE0 File Offset: 0x007240E0
		private void LPNDCJKAKEA()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FDEF RID: 65007 RVA: 0x00725F3C File Offset: 0x0072413C
		private void HDGNIHBIEDG()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FDF0 RID: 65008 RVA: 0x00725F98 File Offset: 0x00724198
		public void ENBFEOJGCPD()
		{
			if (this.weight <= 1806f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 924f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDF1 RID: 65009 RVA: 0x00726098 File Offset: 0x00724298
		private void Start()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FDF2 RID: 65010 RVA: 0x007260F4 File Offset: 0x007242F4
		private void BHDPDDHLPOI()
		{
			this.HCKJJBCJHLP();
		}

		// Token: 0x0600FDF3 RID: 65011 RVA: 0x007260FC File Offset: 0x007242FC
		private void MCHAAIIHOKD()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FDF4 RID: 65012 RVA: 0x00726158 File Offset: 0x00724358
		private void CKCBGFMFNFK()
		{
			this.NFODJMNCMHD();
		}

		// Token: 0x0600FDF5 RID: 65013 RVA: 0x00726160 File Offset: 0x00724360
		private void BGCLAKJHAFK()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FDF6 RID: 65014 RVA: 0x007261BC File Offset: 0x007243BC
		private void MODJFGGIAHD()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FDF7 RID: 65015 RVA: 0x00726218 File Offset: 0x00724418
		private void APPLKMOGAMJ()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FDF8 RID: 65016 RVA: 0x00726274 File Offset: 0x00724474
		private void OIKMLNIPLIA()
		{
			this.GJOHBPDAKCJ();
		}

		// Token: 0x0600FDF9 RID: 65017 RVA: 0x0072627C File Offset: 0x0072447C
		private void KMMEMAHCFLJ()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FDFA RID: 65018 RVA: 0x007262D8 File Offset: 0x007244D8
		public void CODEIPKHKJN()
		{
			if (this.weight <= 511f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 205f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDFB RID: 65019 RVA: 0x007263D8 File Offset: 0x007245D8
		public void CKDLABLAJAG()
		{
			if (this.weight <= 1205f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 786f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDFC RID: 65020 RVA: 0x007264D8 File Offset: 0x007246D8
		private void KIMKOEBBFKJ()
		{
			this.Relax();
		}

		// Token: 0x0600FDFD RID: 65021 RVA: 0x007264E0 File Offset: 0x007246E0
		public void KJKMGGGDGKK()
		{
			if (this.weight <= 1030f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 114f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDFE RID: 65022 RVA: 0x007265E0 File Offset: 0x007247E0
		public void EGHAJOBEMND()
		{
			if (this.weight <= 231f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1862f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FDFF RID: 65023 RVA: 0x007266E0 File Offset: 0x007248E0
		public void KCHPNFILAPC()
		{
			if (this.weight <= 1235f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 626f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE00 RID: 65024 RVA: 0x007267E0 File Offset: 0x007249E0
		private void KPHGGOCHKFA()
		{
			this.KMAJGEJEJOL();
		}

		// Token: 0x0600FE01 RID: 65025 RVA: 0x007267E8 File Offset: 0x007249E8
		private void CAKBGHMOGIG()
		{
			this.EPNHKGCAGME();
		}

		// Token: 0x0600FE02 RID: 65026 RVA: 0x007267F0 File Offset: 0x007249F0
		private void LHHKDNILMDI()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE03 RID: 65027 RVA: 0x0072684C File Offset: 0x00724A4C
		public void LIJNNJOJAHF()
		{
			if (this.weight <= 808f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1781f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE04 RID: 65028 RVA: 0x0072694C File Offset: 0x00724B4C
		public void OFBMLIKGGKF()
		{
			if (this.weight <= 462f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 482f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE05 RID: 65029 RVA: 0x007259D0 File Offset: 0x00723BD0
		private void NANEAKKPDBH()
		{
			this.CODEIPKHKJN();
		}

		// Token: 0x0600FE06 RID: 65030 RVA: 0x00726A4C File Offset: 0x00724C4C
		private void GJKCGGCCIAJ()
		{
			this.LKADOPLAOEL();
		}

		// Token: 0x0600FE07 RID: 65031 RVA: 0x00726A54 File Offset: 0x00724C54
		private void PLBDELOIINH()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE08 RID: 65032 RVA: 0x00726AB0 File Offset: 0x00724CB0
		public void DJHAKGPOJAB()
		{
			if (this.weight <= 1481f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1215f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE09 RID: 65033 RVA: 0x00726BB0 File Offset: 0x00724DB0
		public void BOBCBJIKPAL()
		{
			if (this.weight <= 12f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 17f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE0A RID: 65034 RVA: 0x00726CB0 File Offset: 0x00724EB0
		private void KEACPNJHBIL()
		{
			this.EGHAJOBEMND();
		}

		// Token: 0x0600FE0B RID: 65035 RVA: 0x00726CB8 File Offset: 0x00724EB8
		public void DFDAGGPGGPF()
		{
			if (this.weight <= 298f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 204f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE0C RID: 65036 RVA: 0x00726DB8 File Offset: 0x00724FB8
		private void LKNJKBIOBEM()
		{
			this.AKPNHCDKIPG();
		}

		// Token: 0x0600FE0D RID: 65037 RVA: 0x00726DC0 File Offset: 0x00724FC0
		public void EELNPCAICOJ()
		{
			if (this.weight <= 947f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 264f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE0E RID: 65038 RVA: 0x00726EC0 File Offset: 0x007250C0
		private void DFNJNCCPKJF()
		{
			this.LCBBPDECFGG();
		}

		// Token: 0x0600FE0F RID: 65039 RVA: 0x00726EC8 File Offset: 0x007250C8
		private void CFIABPOECGJ()
		{
			this.IIAAMEJPDFN();
		}

		// Token: 0x0600FE10 RID: 65040 RVA: 0x00726ED0 File Offset: 0x007250D0
		private void CAJLCEPLKJG()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE11 RID: 65041 RVA: 0x00726F2C File Offset: 0x0072512C
		private void KFGKKLAKFGH()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE12 RID: 65042 RVA: 0x00726F88 File Offset: 0x00725188
		public void GNNBIOFBOPO()
		{
			if (this.weight <= 1855f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 96f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE13 RID: 65043 RVA: 0x00727088 File Offset: 0x00725288
		private void DGEIACONKCJ()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE14 RID: 65044 RVA: 0x007270E4 File Offset: 0x007252E4
		public void FNOFMJAFADC()
		{
			if (this.weight <= 873f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 409f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE15 RID: 65045 RVA: 0x007271E4 File Offset: 0x007253E4
		private void IEEPECJPCFD()
		{
			this.FFPAAFAKJCP();
		}

		// Token: 0x0600FE16 RID: 65046 RVA: 0x007271EC File Offset: 0x007253EC
		private void CPNOBMNKPNC()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE17 RID: 65047 RVA: 0x00727248 File Offset: 0x00725448
		private void BFBBJILCKAK()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE18 RID: 65048 RVA: 0x007272A4 File Offset: 0x007254A4
		public void FFPAAFAKJCP()
		{
			if (this.weight <= 1155f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1180f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE19 RID: 65049 RVA: 0x007257C8 File Offset: 0x007239C8
		private void PMIFCKJAFEB()
		{
			this.OFBMLIKGGKF();
		}

		// Token: 0x0600FE1A RID: 65050 RVA: 0x007273A4 File Offset: 0x007255A4
		public void GJOHBPDAKCJ()
		{
			if (this.weight <= 991f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1658f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE1B RID: 65051 RVA: 0x007274A4 File Offset: 0x007256A4
		private void ONIHHFLOJMN()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE1C RID: 65052 RVA: 0x00727500 File Offset: 0x00725700
		public void JJNHDIBADBH()
		{
			if (this.weight <= 302f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1721f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE1D RID: 65053 RVA: 0x00726274 File Offset: 0x00724474
		private void CMDJHGMGLCG()
		{
			this.GJOHBPDAKCJ();
		}

		// Token: 0x0600FE1E RID: 65054 RVA: 0x00727600 File Offset: 0x00725800
		private void JFFPLABGMNF()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE1F RID: 65055 RVA: 0x007259D0 File Offset: 0x00723BD0
		private void GHGFBMCJNDH()
		{
			this.CODEIPKHKJN();
		}

		// Token: 0x0600FE20 RID: 65056 RVA: 0x0072765C File Offset: 0x0072585C
		public void EECGGFBKPMC()
		{
			if (this.weight <= 1528f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1273f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE21 RID: 65057 RVA: 0x0072775C File Offset: 0x0072595C
		public void IAGICCIMFBA()
		{
			if (this.weight <= 1790f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 51f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE22 RID: 65058 RVA: 0x0072785C File Offset: 0x00725A5C
		private void BLOLJBHKGOH()
		{
			this.KCHPNFILAPC();
		}

		// Token: 0x0600FE23 RID: 65059 RVA: 0x007267E0 File Offset: 0x007249E0
		private void FDGKDLHLIPC()
		{
			this.KMAJGEJEJOL();
		}

		// Token: 0x0600FE24 RID: 65060 RVA: 0x00726158 File Offset: 0x00724358
		private void CFHDJOKLHDB()
		{
			this.NFODJMNCMHD();
		}

		// Token: 0x0600FE25 RID: 65061 RVA: 0x00727864 File Offset: 0x00725A64
		private void EFCCCKGCOCB()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE27 RID: 65063 RVA: 0x007278F4 File Offset: 0x00725AF4
		public void AAHOPFOBKAH()
		{
			if (this.weight <= 262f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1490f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE28 RID: 65064 RVA: 0x007259D8 File Offset: 0x00723BD8
		private void MHJBMBPKHLB()
		{
			this.GJAMOKKPJLD();
		}

		// Token: 0x0600FE29 RID: 65065 RVA: 0x007279F4 File Offset: 0x00725BF4
		private void KIEIPFFEDHC()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE2A RID: 65066 RVA: 0x00727A50 File Offset: 0x00725C50
		private void IJOCHELLKJH()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE2B RID: 65067 RVA: 0x00727AAC File Offset: 0x00725CAC
		private void FEBIICIMLHA()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE2C RID: 65068 RVA: 0x007260F4 File Offset: 0x007242F4
		private void LBBGAADLMOM()
		{
			this.HCKJJBCJHLP();
		}

		// Token: 0x0600FE2D RID: 65069 RVA: 0x00727B08 File Offset: 0x00725D08
		public void Relax()
		{
			if (this.weight <= 0f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 57.29578f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE2E RID: 65070 RVA: 0x00727C08 File Offset: 0x00725E08
		private void ELFLOPJDAKK()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE2F RID: 65071 RVA: 0x00727C64 File Offset: 0x00725E64
		private void JLKBMEBFHBI()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE30 RID: 65072 RVA: 0x00727CC0 File Offset: 0x00725EC0
		private void LHKGDKLABAA()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE31 RID: 65073 RVA: 0x00727D1C File Offset: 0x00725F1C
		public void AEBDBDBOCDE()
		{
			if (this.weight <= 189f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1977f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE32 RID: 65074 RVA: 0x00727E1C File Offset: 0x0072601C
		public void AKPNHCDKIPG()
		{
			if (this.weight <= 1114f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1930f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE33 RID: 65075 RVA: 0x00727F1C File Offset: 0x0072611C
		private void JFHOMJMKBNJ()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE34 RID: 65076 RVA: 0x00727F78 File Offset: 0x00726178
		public void CNBBBNNPKEK()
		{
			if (this.weight <= 1598f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1118f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE35 RID: 65077 RVA: 0x00728078 File Offset: 0x00726278
		public void OLOCKPOGNOD()
		{
			if (this.weight <= 273f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 332f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE36 RID: 65078 RVA: 0x00728178 File Offset: 0x00726378
		public void ODPHEKODFIN()
		{
			if (this.weight <= 1452f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1242f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE37 RID: 65079 RVA: 0x00726CB0 File Offset: 0x00724EB0
		private void ONMFGDAKHHC()
		{
			this.EGHAJOBEMND();
		}

		// Token: 0x0600FE38 RID: 65080 RVA: 0x00728278 File Offset: 0x00726478
		private void HDPICLGBICL()
		{
			this.EKBMLJLJNEO();
		}

		// Token: 0x0600FE39 RID: 65081 RVA: 0x00728280 File Offset: 0x00726480
		private void NCBLFNKNEDK()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE3A RID: 65082 RVA: 0x00726EC8 File Offset: 0x007250C8
		private void NLPHGJJOLOO()
		{
			this.IIAAMEJPDFN();
		}

		// Token: 0x0600FE3B RID: 65083 RVA: 0x007260F4 File Offset: 0x007242F4
		private void GEOHKEPJFCJ()
		{
			this.HCKJJBCJHLP();
		}

		// Token: 0x0600FE3C RID: 65084 RVA: 0x007282DC File Offset: 0x007264DC
		public void GFGGNADPAJG()
		{
			if (this.weight <= 70f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 886f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE3D RID: 65085 RVA: 0x007283DC File Offset: 0x007265DC
		private void LOFKNDCJBMN()
		{
			this.CFEKHLPKAKI();
		}

		// Token: 0x0600FE3E RID: 65086 RVA: 0x0072785C File Offset: 0x00725A5C
		private void NFMDEMOEHHG()
		{
			this.KCHPNFILAPC();
		}

		// Token: 0x0600FE3F RID: 65087 RVA: 0x007283E4 File Offset: 0x007265E4
		private void KJJNMNKPNCH()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE40 RID: 65088 RVA: 0x007264D8 File Offset: 0x007246D8
		private void GCJBBACOJJE()
		{
			this.Relax();
		}

		// Token: 0x0600FE41 RID: 65089 RVA: 0x00728440 File Offset: 0x00726640
		private void KGICJDGIIJK()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE42 RID: 65090 RVA: 0x0072849C File Offset: 0x0072669C
		private void BMNJGPIPKLL()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE43 RID: 65091 RVA: 0x007259D0 File Offset: 0x00723BD0
		private void OOGNHIIPHBH()
		{
			this.CODEIPKHKJN();
		}

		// Token: 0x0600FE44 RID: 65092 RVA: 0x007284F8 File Offset: 0x007266F8
		public void KMAJGEJEJOL()
		{
			if (this.weight <= 1767f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1475f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE45 RID: 65093 RVA: 0x007257B8 File Offset: 0x007239B8
		private void NGHOJBOHIBA()
		{
			this.LBFNNBPNECK();
		}

		// Token: 0x0600FE46 RID: 65094 RVA: 0x007285F8 File Offset: 0x007267F8
		public void GJAMOKKPJLD()
		{
			if (this.weight <= 17f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 574f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE47 RID: 65095 RVA: 0x007257C8 File Offset: 0x007239C8
		private void BENCPPPLDIC()
		{
			this.OFBMLIKGGKF();
		}

		// Token: 0x0600FE48 RID: 65096 RVA: 0x007286F8 File Offset: 0x007268F8
		public void ECJPKAIKKDB()
		{
			if (this.weight <= 967f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 755f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE49 RID: 65097 RVA: 0x007264D8 File Offset: 0x007246D8
		private void LateUpdate()
		{
			this.Relax();
		}

		// Token: 0x0600FE4A RID: 65098 RVA: 0x007287F8 File Offset: 0x007269F8
		public void CLLCPBKAKFE()
		{
			if (this.weight <= 1199f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1796f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE4B RID: 65099 RVA: 0x007288F8 File Offset: 0x00726AF8
		private void OLBDJCFPKFG()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE4C RID: 65100 RVA: 0x00728954 File Offset: 0x00726B54
		private void LMEJKAEIDCO()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE4D RID: 65101 RVA: 0x007259D8 File Offset: 0x00723BD8
		private void BDALGHGNCPE()
		{
			this.GJAMOKKPJLD();
		}

		// Token: 0x0600FE4E RID: 65102 RVA: 0x007289B0 File Offset: 0x00726BB0
		public void PPLAHMJIPJA()
		{
			if (this.weight <= 840f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 437f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE4F RID: 65103 RVA: 0x00728AB0 File Offset: 0x00726CB0
		private void FDBNPLCPFJB()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE50 RID: 65104 RVA: 0x00728B0C File Offset: 0x00726D0C
		private void ANHOOJFEJJE()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE51 RID: 65105 RVA: 0x00728B68 File Offset: 0x00726D68
		public void CFEKHLPKAKI()
		{
			if (this.weight <= 998f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 669f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE52 RID: 65106 RVA: 0x00728C68 File Offset: 0x00726E68
		private void MKNPFMEMOJO()
		{
			Vector3 point = base.transform.rotation * this.axis;
			this.IKNHPHJOKHG = Quaternion.Inverse(this.parent.rotation) * point;
			this.KONNCKFANFI = Quaternion.Inverse(this.child.rotation) * point;
		}

		// Token: 0x0600FE53 RID: 65107 RVA: 0x00728CC4 File Offset: 0x00726EC4
		public void IIAAMEJPDFN()
		{
			if (this.weight <= 1723f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 1883f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x0600FE54 RID: 65108 RVA: 0x00728DC4 File Offset: 0x00726FC4
		private void GFELHLPHCDN()
		{
			this.FNOFMJAFADC();
		}

		// Token: 0x0600FE55 RID: 65109 RVA: 0x00728DCC File Offset: 0x00726FCC
		private void KCJNJBEJHFA()
		{
			this.EECGGFBKPMC();
		}

		// Token: 0x0600FE56 RID: 65110 RVA: 0x00728DD4 File Offset: 0x00726FD4
		public void JMAJFMCJBGD()
		{
			if (this.weight <= 1393f)
			{
				return;
			}
			Vector3 a = this.parent.rotation * this.IKNHPHJOKHG;
			Vector3 b = this.child.rotation * this.KONNCKFANFI;
			Vector3 vector = Vector3.Slerp(a, b, this.parentChildCrossfade);
			vector = Quaternion.Inverse(Quaternion.LookRotation(base.transform.rotation * this.axis, base.transform.rotation * this.twistAxis)) * vector;
			float num = Mathf.Atan2(vector.x, vector.z) * 637f;
			Quaternion rotation = this.child.rotation;
			base.transform.rotation = Quaternion.AngleAxis(num * this.weight, base.transform.rotation * this.twistAxis) * base.transform.rotation;
			this.child.rotation = rotation;
		}

		// Token: 0x04002168 RID: 8552
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight = 1f;

		// Token: 0x04002169 RID: 8553
		[Range(0f, 1f)]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		public float parentChildCrossfade = 0.5f;

		// Token: 0x0400216A RID: 8554
		[Tooltip("The parent Transform, does not need to be the actual transform.parent.")]
		public Transform parent;

		// Token: 0x0400216B RID: 8555
		[Tooltip("The child Transform, does not need to be the direct child, you can skip bones in the hierarchy.")]
		public Transform child;

		// Token: 0x0400216C RID: 8556
		[Tooltip("The local axis of this Transform that it will be twisted around (the axis pointing towards the parent).")]
		public Vector3 twistAxis = Vector3.right;

		// Token: 0x0400216D RID: 8557
		[Tooltip("Another axis, orthogonal to twistAxis.")]
		public Vector3 axis = Vector3.forward;

		// Token: 0x0400216E RID: 8558
		private Vector3 IKNHPHJOKHG;

		// Token: 0x0400216F RID: 8559
		private Vector3 KONNCKFANFI;
	}
}
