using System;
using RootMotion;
using UnityEngine;

// Token: 0x020003C9 RID: 969
public class IMPMMNPAHKJ
{
	// Token: 0x0600D176 RID: 53622 RVA: 0x005FE8D8 File Offset: 0x005FCAD8
	public static Axis DKELMDIPEDB(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		Vector3 lhs = IMPMMNPAHKJ.NBBFPJEOGDC(JAHNHOCNJGM, NEMFIHCKJPE);
		if (lhs == Vector3.right)
		{
			return Axis.Y;
		}
		if (lhs == Vector3.up)
		{
			return Axis.X;
		}
		return (Axis)4;
	}

	// Token: 0x0600D177 RID: 53623 RVA: 0x005FE90C File Offset: 0x005FCB0C
	public static Vector3 NOHAJJPNEEK(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D178 RID: 53624 RVA: 0x005FE926 File Offset: 0x005FCB26
	public static Vector3 KJBOJNCAAAI(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.EABAGDNMEHC(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D17A RID: 53626 RVA: 0x005FE93A File Offset: 0x005FCB3A
	public static Vector3 FDBNCLFDFBB(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.FKEAAPCGPEN(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D17B RID: 53627 RVA: 0x005FE950 File Offset: 0x005FCB50
	public static Axis OHAEBKGAPBA(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		Vector3 lhs = IMPMMNPAHKJ.DPDFPEKJBJL(JAHNHOCNJGM, NEMFIHCKJPE);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return Axis.Z;
	}

	// Token: 0x0600D17C RID: 53628 RVA: 0x005FE984 File Offset: 0x005FCB84
	public static Axis PALJNMMCHAO(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.X;
		}
		if (num3 > num && num3 > num2)
		{
			result = (Axis)3;
		}
		return result;
	}

	// Token: 0x0600D17D RID: 53629 RVA: 0x005FE9CC File Offset: 0x005FCBCC
	public static Vector3 KCHHCAINFAF(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D17E RID: 53630 RVA: 0x005FEA48 File Offset: 0x005FCC48
	public static Axis LILOGDEOOPJ(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.LNIDECBNHOG(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.Y;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return Axis.X;
	}

	// Token: 0x0600D17F RID: 53631 RVA: 0x005FEA7C File Offset: 0x005FCC7C
	public static Vector3 JMCEMAIJILF(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.JAELJPJPBFB(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D180 RID: 53632 RVA: 0x005FEA90 File Offset: 0x005FCC90
	public static Axis EFJGOCGLLKE(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.Y;
		}
		if (num3 > num && num3 > num2)
		{
			result = Axis.Y;
		}
		return result;
	}

	// Token: 0x0600D181 RID: 53633 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 HAOMEPDJHBP(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D182 RID: 53634 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 OAPMBKKENPK(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D183 RID: 53635 RVA: 0x005FE90C File Offset: 0x005FCB0C
	public static Vector3 CCGPHELNHAP(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D184 RID: 53636 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 GPJBJFJFNMM(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D185 RID: 53637 RVA: 0x005FE926 File Offset: 0x005FCB26
	public static Vector3 AHNDHBHMCCN(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.EABAGDNMEHC(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D186 RID: 53638 RVA: 0x005FEAF4 File Offset: 0x005FCCF4
	public static Axis HADMCKICEMH(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		Vector3 lhs = IMPMMNPAHKJ.KCHHCAINFAF(JAHNHOCNJGM, NEMFIHCKJPE);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.X;
		}
		return Axis.Z;
	}

	// Token: 0x0600D187 RID: 53639 RVA: 0x005FEB28 File Offset: 0x005FCD28
	public static Vector3 JAELJPJPBFB(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D188 RID: 53640 RVA: 0x005FEBA2 File Offset: 0x005FCDA2
	public static Vector3 NAJJLFGABGM(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.DFCIJCHNBOL(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D189 RID: 53641 RVA: 0x005FEBB8 File Offset: 0x005FCDB8
	public static Axis AGOEBHMLPNC(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.BCLMNDGBECO(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.X;
		}
		return (Axis)7;
	}

	// Token: 0x0600D18A RID: 53642 RVA: 0x005FEBEC File Offset: 0x005FCDEC
	public static Axis NEEFJDEFECI(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		Vector3 lhs = IMPMMNPAHKJ.JGBFNKHKFEP(JAHNHOCNJGM, NEMFIHCKJPE);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.X;
		}
		return Axis.Y;
	}

	// Token: 0x0600D18B RID: 53643 RVA: 0x005FEC20 File Offset: 0x005FCE20
	public static Axis KADPHLEMOHI(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.CEHEEFAKFKA(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.Y;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return Axis.Y;
	}

	// Token: 0x0600D18C RID: 53644 RVA: 0x005FEC54 File Offset: 0x005FCE54
	public static Axis NCGIFFJIJJL(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		Vector3 lhs = IMPMMNPAHKJ.DFCIJCHNBOL(JAHNHOCNJGM, NEMFIHCKJPE);
		if (lhs == Vector3.right)
		{
			return Axis.Y;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return (Axis)5;
	}

	// Token: 0x0600D18D RID: 53645 RVA: 0x005FEC88 File Offset: 0x005FCE88
	public static Axis NNNJLBFPJNA(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.X;
		}
		if (num3 > num && num3 > num2)
		{
			result = (Axis)3;
		}
		return result;
	}

	// Token: 0x0600D18E RID: 53646 RVA: 0x005FECD0 File Offset: 0x005FCED0
	public static Vector3 DPDFPEKJBJL(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D18F RID: 53647 RVA: 0x005FED4C File Offset: 0x005FCF4C
	public static Axis FHBKAILLGFI(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.X;
		}
		if (num3 > num && num3 > num2)
		{
			result = Axis.Y;
		}
		return result;
	}

	// Token: 0x0600D190 RID: 53648 RVA: 0x005FED94 File Offset: 0x005FCF94
	public static Axis HPNEMJAFKPF(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.X;
		if (num2 > num && num2 > num3)
		{
			result = Axis.Y;
		}
		if (num3 > num && num3 > num2)
		{
			result = Axis.Z;
		}
		return result;
	}

	// Token: 0x0600D191 RID: 53649 RVA: 0x005FEDDC File Offset: 0x005FCFDC
	public static Axis KKLAHCHMLEK(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.Y;
		}
		if (num3 > num && num3 > num2)
		{
			result = (Axis)7;
		}
		return result;
	}

	// Token: 0x0600D192 RID: 53650 RVA: 0x005FEE24 File Offset: 0x005FD024
	public static Vector3 FMHLIKEFKKB(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D193 RID: 53651 RVA: 0x005FEEA0 File Offset: 0x005FD0A0
	public static Axis IONMLDPEJFO(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.X;
		if (num2 > num && num2 > num3)
		{
			result = Axis.X;
		}
		if (num3 > num && num3 > num2)
		{
			result = (Axis)3;
		}
		return result;
	}

	// Token: 0x0600D194 RID: 53652 RVA: 0x005FEEE8 File Offset: 0x005FD0E8
	public static Axis OOCKNPFIPFO(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.KJBOJNCAAAI(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.Y;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return (Axis)3;
	}

	// Token: 0x0600D195 RID: 53653 RVA: 0x005FEF1C File Offset: 0x005FD11C
	public static Axis GLDAEFDEKNM(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.FDBNCLFDFBB(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return (Axis)7;
	}

	// Token: 0x0600D196 RID: 53654 RVA: 0x005FEF50 File Offset: 0x005FD150
	public static Vector3 DFCIJCHNBOL(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D197 RID: 53655 RVA: 0x005FEFCC File Offset: 0x005FD1CC
	public static Axis MFBFJFNDIKP(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.IEKNBKCOHCH(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return (Axis)4;
	}

	// Token: 0x0600D198 RID: 53656 RVA: 0x005FEBA2 File Offset: 0x005FCDA2
	public static Vector3 JADLJPHLJIF(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.DFCIJCHNBOL(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D199 RID: 53657 RVA: 0x005FE90C File Offset: 0x005FCB0C
	public static Vector3 OHLPOHNGANH(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D19A RID: 53658 RVA: 0x005FF000 File Offset: 0x005FD200
	public static Vector3 BCLMNDGBECO(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.FMHLIKEFKKB(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D19B RID: 53659 RVA: 0x005FF014 File Offset: 0x005FD214
	public static Axis PMNGLPLGCNN(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.X;
		}
		if (num3 > num && num3 > num2)
		{
			result = Axis.Y;
		}
		return result;
	}

	// Token: 0x0600D19C RID: 53660 RVA: 0x005FF05C File Offset: 0x005FD25C
	public static Vector3 DELIEJAAHEI(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D19D RID: 53661 RVA: 0x005FF0D8 File Offset: 0x005FD2D8
	public static Vector3 KCHFFCFMNDA(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D19E RID: 53662 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 DJFIIEHHJDI(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D19F RID: 53663 RVA: 0x005FF154 File Offset: 0x005FD354
	public static Axis APGCIAGJJFC(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		Vector3 lhs = IMPMMNPAHKJ.EABAGDNMEHC(JAHNHOCNJGM, NEMFIHCKJPE);
		if (lhs == Vector3.right)
		{
			return Axis.Y;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return Axis.X;
	}

	// Token: 0x0600D1A0 RID: 53664 RVA: 0x005FF188 File Offset: 0x005FD388
	public static Axis IEMLBAIFOGM(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.DOOHOFDNCLC(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.X;
		}
		return (Axis)7;
	}

	// Token: 0x0600D1A1 RID: 53665 RVA: 0x005FF1BC File Offset: 0x005FD3BC
	public static Vector3 LDBCMHMIPJB(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D1A2 RID: 53666 RVA: 0x005FE90C File Offset: 0x005FCB0C
	public static Vector3 EBLDJJLFIJO(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1A3 RID: 53667 RVA: 0x005FF238 File Offset: 0x005FD438
	public static Axis ONCGHJCOODE(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.FDBNCLFDFBB(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return Axis.Y;
	}

	// Token: 0x0600D1A4 RID: 53668 RVA: 0x005FF26C File Offset: 0x005FD46C
	public static Axis KPOINDOBDAB(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.IEKNBKCOHCH(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return (Axis)8;
	}

	// Token: 0x0600D1A5 RID: 53669 RVA: 0x005FF2A0 File Offset: 0x005FD4A0
	public static Vector3 NANKPGFJKPB(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.HLAEEBDBCJH(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D1A6 RID: 53670 RVA: 0x005FF2B4 File Offset: 0x005FD4B4
	public static Axis ALONBCKAECN(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.LNIDECBNHOG(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return Axis.Z;
	}

	// Token: 0x0600D1A7 RID: 53671 RVA: 0x005FF2E8 File Offset: 0x005FD4E8
	public static Vector3 NGEJAGAKDED(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D1A8 RID: 53672 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 NPCHOPOJHHH(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1A9 RID: 53673 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 CEFMCOPLENH(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1AA RID: 53674 RVA: 0x005FEBA2 File Offset: 0x005FCDA2
	public static Vector3 MGDDIJBLEON(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.DFCIJCHNBOL(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D1AB RID: 53675 RVA: 0x005FF364 File Offset: 0x005FD564
	public static Vector3 NBBFPJEOGDC(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D1AC RID: 53676 RVA: 0x005FF3E0 File Offset: 0x005FD5E0
	public static Vector3 EABAGDNMEHC(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D1AD RID: 53677 RVA: 0x005FF45C File Offset: 0x005FD65C
	public static Axis OLLEMMGHCAK(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.JMCEMAIJILF(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.Y;
		}
		if (lhs == Vector3.up)
		{
			return Axis.X;
		}
		return (Axis)5;
	}

	// Token: 0x0600D1AE RID: 53678 RVA: 0x005FF490 File Offset: 0x005FD690
	public static Axis BCNGGANIBJI(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.X;
		if (num2 > num && num2 > num3)
		{
			result = Axis.Y;
		}
		if (num3 > num && num3 > num2)
		{
			result = Axis.Z;
		}
		return result;
	}

	// Token: 0x0600D1AF RID: 53679 RVA: 0x005FF4D8 File Offset: 0x005FD6D8
	public static Vector3 LNIDECBNHOG(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.DPDFPEKJBJL(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D1B0 RID: 53680 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 OJCMBDNOEJI(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1B1 RID: 53681 RVA: 0x005FE90C File Offset: 0x005FCB0C
	public static Vector3 EEKHAOCPOOP(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1B2 RID: 53682 RVA: 0x005FF4EC File Offset: 0x005FD6EC
	public static Axis FKJKAMLEBGM(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.X;
		}
		if (num3 > num && num3 > num2)
		{
			result = Axis.Z;
		}
		return result;
	}

	// Token: 0x0600D1B3 RID: 53683 RVA: 0x005FF534 File Offset: 0x005FD734
	public static Axis GFKIGGNMLJH(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.X;
		if (num2 > num && num2 > num3)
		{
			result = Axis.Y;
		}
		if (num3 > num && num3 > num2)
		{
			result = Axis.Y;
		}
		return result;
	}

	// Token: 0x0600D1B4 RID: 53684 RVA: 0x005FF57C File Offset: 0x005FD77C
	public static Axis ANAEBEJDCIK(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.ACLIJBPJKKM(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return (Axis)5;
	}

	// Token: 0x0600D1B5 RID: 53685 RVA: 0x005FF5B0 File Offset: 0x005FD7B0
	public static Axis GMNEHMJNNIJ(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.X;
		}
		if (num3 > num && num3 > num2)
		{
			result = Axis.Y;
		}
		return result;
	}

	// Token: 0x0600D1B6 RID: 53686 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 PIGKJCMOEBK(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1B7 RID: 53687 RVA: 0x005FF5F8 File Offset: 0x005FD7F8
	public static Axis PDLIPGNOJOB(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		Vector3 lhs = IMPMMNPAHKJ.KCHFFCFMNDA(JAHNHOCNJGM, NEMFIHCKJPE);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.Y;
		}
		return Axis.X;
	}

	// Token: 0x0600D1B8 RID: 53688 RVA: 0x005FF62C File Offset: 0x005FD82C
	public static Axis EEIOFGGALON(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.Y;
		}
		if (num3 > num && num3 > num2)
		{
			result = Axis.Z;
		}
		return result;
	}

	// Token: 0x0600D1B9 RID: 53689 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 AFHEMOHEJOI(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1BA RID: 53690 RVA: 0x005FF674 File Offset: 0x005FD874
	public static Vector3 IBIHMLEBCPM(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.PNPJIHICPEN(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D1BB RID: 53691 RVA: 0x005FE93A File Offset: 0x005FCB3A
	public static Vector3 GGFDNFHPJOH(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.FKEAAPCGPEN(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D1BC RID: 53692 RVA: 0x005FF688 File Offset: 0x005FD888
	public static Axis OACJEJFBNMO(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.DOOHOFDNCLC(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.Y;
		}
		if (lhs == Vector3.up)
		{
			return Axis.X;
		}
		return (Axis)5;
	}

	// Token: 0x0600D1BD RID: 53693 RVA: 0x005FE926 File Offset: 0x005FCB26
	public static Vector3 FMHPBEHFODH(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.EABAGDNMEHC(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D1BE RID: 53694 RVA: 0x005FF6BC File Offset: 0x005FD8BC
	public static Axis GEBAJHDNMCO(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.X;
		}
		if (num3 > num && num3 > num2)
		{
			result = (Axis)3;
		}
		return result;
	}

	// Token: 0x0600D1BF RID: 53695 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 CDKBIAMOLMJ(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1C0 RID: 53696 RVA: 0x005FE93A File Offset: 0x005FCB3A
	public static Vector3 IEKNBKCOHCH(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.FKEAAPCGPEN(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D1C1 RID: 53697 RVA: 0x005FF704 File Offset: 0x005FD904
	public static Vector3 FKEAAPCGPEN(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D1C2 RID: 53698 RVA: 0x005FF77E File Offset: 0x005FD97E
	public static Vector3 BNKMKPBKCAD(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.DELIEJAAHEI(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D1C3 RID: 53699 RVA: 0x005FF794 File Offset: 0x005FD994
	public static Axis BDOPODDLNCD(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.Y;
		}
		if (num3 > num && num3 > num2)
		{
			result = (Axis)5;
		}
		return result;
	}

	// Token: 0x0600D1C4 RID: 53700 RVA: 0x005FF7DC File Offset: 0x005FD9DC
	public static Axis LHBPPFKOPEO(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.JMCEMAIJILF(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.Y;
		}
		if (lhs == Vector3.up)
		{
			return Axis.X;
		}
		return Axis.X;
	}

	// Token: 0x0600D1C5 RID: 53701 RVA: 0x005FF810 File Offset: 0x005FDA10
	public static Vector3 ACLIJBPJKKM(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.KCHHCAINFAF(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D1C6 RID: 53702 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 HHPKAKFOOCD(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1C7 RID: 53703 RVA: 0x005FF824 File Offset: 0x005FDA24
	public static Axis DIDIMBEBLCD(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.Y;
		if (num2 > num && num2 > num3)
		{
			result = Axis.X;
		}
		if (num3 > num && num3 > num2)
		{
			result = (Axis)3;
		}
		return result;
	}

	// Token: 0x0600D1C8 RID: 53704 RVA: 0x005FF86C File Offset: 0x005FDA6C
	public static Vector3 PNPJIHICPEN(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D1C9 RID: 53705 RVA: 0x005FE90C File Offset: 0x005FCB0C
	public static Vector3 GBCHJIMEOMI(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1CA RID: 53706 RVA: 0x005FF8E6 File Offset: 0x005FDAE6
	public static Vector3 CEHEEFAKFKA(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.NBBFPJEOGDC(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D1CB RID: 53707 RVA: 0x005FEAD8 File Offset: 0x005FCCD8
	public static Vector3 FCJKDKKBIKC(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.Y)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1CC RID: 53708 RVA: 0x005FF8FC File Offset: 0x005FDAFC
	public static Axis AMKDPCFOMGH(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		Vector3 lhs = IMPMMNPAHKJ.FMHPBEHFODH(JAHNHOCNJGM, JNFPCCIKFPP);
		if (lhs == Vector3.right)
		{
			return Axis.X;
		}
		if (lhs == Vector3.up)
		{
			return Axis.X;
		}
		return (Axis)8;
	}

	// Token: 0x0600D1CD RID: 53709 RVA: 0x005FEBA2 File Offset: 0x005FCDA2
	public static Vector3 DOOHOFDNCLC(Transform JAHNHOCNJGM, Vector3 JNFPCCIKFPP)
	{
		return IMPMMNPAHKJ.DFCIJCHNBOL(JAHNHOCNJGM, JNFPCCIKFPP - JAHNHOCNJGM.position);
	}

	// Token: 0x0600D1CE RID: 53710 RVA: 0x005FF930 File Offset: 0x005FDB30
	public static Vector3 JGBFNKHKFEP(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D1CF RID: 53711 RVA: 0x005FF9AC File Offset: 0x005FDBAC
	public static Axis DDKKDDMEPLG(Vector3 LIBEPMOMPID)
	{
		float num = Mathf.Abs(LIBEPMOMPID.x);
		float num2 = Mathf.Abs(LIBEPMOMPID.y);
		float num3 = Mathf.Abs(LIBEPMOMPID.z);
		Axis result = Axis.X;
		if (num2 > num && num2 > num3)
		{
			result = Axis.Y;
		}
		if (num3 > num && num3 > num2)
		{
			result = (Axis)8;
		}
		return result;
	}

	// Token: 0x0600D1D0 RID: 53712 RVA: 0x005FF9F4 File Offset: 0x005FDBF4
	public static Vector3 DICACMFCMDG(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}

	// Token: 0x0600D1D1 RID: 53713 RVA: 0x005FE90C File Offset: 0x005FCB0C
	public static Vector3 HBFIHBBKIEH(Axis HNANBJENIHC)
	{
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.right;
		}
		if (HNANBJENIHC == Axis.X)
		{
			return Vector3.up;
		}
		return Vector3.forward;
	}

	// Token: 0x0600D1D2 RID: 53714 RVA: 0x005FFA70 File Offset: 0x005FDC70
	public static Vector3 HLAEEBDBCJH(Transform JAHNHOCNJGM, Vector3 NEMFIHCKJPE)
	{
		NEMFIHCKJPE = NEMFIHCKJPE.normalized;
		Vector3 result = Vector3.right;
		float num = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.right), NEMFIHCKJPE));
		float num2 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.up), NEMFIHCKJPE));
		if (num2 > num)
		{
			result = Vector3.up;
		}
		float num3 = Mathf.Abs(Vector3.Dot(Vector3.Normalize(JAHNHOCNJGM.forward), NEMFIHCKJPE));
		if (num3 > num && num3 > num2)
		{
			result = Vector3.forward;
		}
		return result;
	}
}
