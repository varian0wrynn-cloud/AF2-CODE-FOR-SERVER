using System;
using UnityEngine;

// Token: 0x020003D8 RID: 984
public static class JEEPKFCFCLI
{
	// Token: 0x0600D44C RID: 54348 RVA: 0x0060E65A File Offset: 0x0060C85A
	public static Quaternion IIAFGICFLIF(Quaternion EEDCMLAJINK, Quaternion FPPBEDMIEGI, float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD <= 0f)
		{
			return EEDCMLAJINK;
		}
		if (NKHBAJKMAGD >= 1f)
		{
			return FPPBEDMIEGI;
		}
		return Quaternion.Lerp(EEDCMLAJINK, FPPBEDMIEGI, NKHBAJKMAGD);
	}

	// Token: 0x0600D44D RID: 54349 RVA: 0x0060E678 File Offset: 0x0060C878
	public static Quaternion ODHADLHEEFC(Quaternion EEDCMLAJINK, Quaternion FPPBEDMIEGI, float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD <= 0f)
		{
			return EEDCMLAJINK;
		}
		if (NKHBAJKMAGD >= 1f)
		{
			return FPPBEDMIEGI;
		}
		return Quaternion.Slerp(EEDCMLAJINK, FPPBEDMIEGI, NKHBAJKMAGD);
	}

	// Token: 0x0600D44E RID: 54350 RVA: 0x0060E696 File Offset: 0x0060C896
	public static Quaternion IILHEGJEPAC(Quaternion HPOGKAAEHKP, float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD <= 0f)
		{
			return Quaternion.identity;
		}
		if (NKHBAJKMAGD >= 1f)
		{
			return HPOGKAAEHKP;
		}
		return Quaternion.Lerp(Quaternion.identity, HPOGKAAEHKP, NKHBAJKMAGD);
	}

	// Token: 0x0600D44F RID: 54351 RVA: 0x0060E6BC File Offset: 0x0060C8BC
	public static Quaternion BKNCBCJDIOF(Quaternion HPOGKAAEHKP, float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD <= 0f)
		{
			return Quaternion.identity;
		}
		if (NKHBAJKMAGD >= 1f)
		{
			return HPOGKAAEHKP;
		}
		return Quaternion.Slerp(Quaternion.identity, HPOGKAAEHKP, NKHBAJKMAGD);
	}

	// Token: 0x0600D450 RID: 54352 RVA: 0x0060E6E4 File Offset: 0x0060C8E4
	public static Quaternion DLNOKBKKIBH(Vector3 ODIDEIIAHOC, Vector3 LKOJAMJMIMI, Vector3 HNANBJENIHC)
	{
		Quaternion quaternion = Quaternion.FromToRotation(ODIDEIIAHOC, LKOJAMJMIMI);
		float num = 0f;
		Vector3 zero = Vector3.zero;
		quaternion.ToAngleAxis(out num, out zero);
		if (Vector3.Dot(zero, HNANBJENIHC) < 0f)
		{
			num = -num;
		}
		return Quaternion.AngleAxis(num, HNANBJENIHC);
	}

	// Token: 0x0600D451 RID: 54353 RVA: 0x0060E728 File Offset: 0x0060C928
	public static Quaternion KBNKKMOKCON(Quaternion JMELKPKJLPB, Quaternion PHKIOHIBNPA)
	{
		return Quaternion.Inverse(Quaternion.Inverse(JMELKPKJLPB) * PHKIOHIBNPA);
	}

	// Token: 0x0600D452 RID: 54354 RVA: 0x0060E73B File Offset: 0x0060C93B
	public static Quaternion AADCPGNPHHC(Quaternion GMNLJGNOKPD, Quaternion LJGGOANMJAJ)
	{
		if (LJGGOANMJAJ == GMNLJGNOKPD)
		{
			return Quaternion.identity;
		}
		return LJGGOANMJAJ * Quaternion.Inverse(GMNLJGNOKPD);
	}

	// Token: 0x0600D453 RID: 54355 RVA: 0x0060E758 File Offset: 0x0060C958
	public static Vector3 LBBLPMHONLE(Vector3 LIBEPMOMPID)
	{
		Vector3 vector = Vector3.right;
		bool flag = false;
		float num = Vector3.Dot(LIBEPMOMPID, Vector3.right);
		float num2 = Mathf.Abs(num);
		if (num < 0f)
		{
			flag = true;
		}
		float num3 = Vector3.Dot(LIBEPMOMPID, Vector3.up);
		float num4 = Mathf.Abs(num3);
		if (num4 > num2)
		{
			num2 = num4;
			vector = Vector3.up;
			flag = (num3 < 0f);
		}
		float num5 = Vector3.Dot(LIBEPMOMPID, Vector3.forward);
		num4 = Mathf.Abs(num5);
		if (num4 > num2)
		{
			vector = Vector3.forward;
			flag = (num5 < 0f);
		}
		if (flag)
		{
			vector = -vector;
		}
		return vector;
	}

	// Token: 0x0600D454 RID: 54356 RVA: 0x0060E7EC File Offset: 0x0060C9EC
	public static Quaternion DHGGOAPDLJG(Quaternion PHKIOHIBNPA, float NAPPHEPPHKD, int BMLPAEMMIMP)
	{
		if (NAPPHEPPHKD >= 1f)
		{
			return Quaternion.identity;
		}
		if (NAPPHEPPHKD <= 0f)
		{
			return PHKIOHIBNPA;
		}
		float num = Quaternion.Angle(Quaternion.identity, PHKIOHIBNPA);
		float num2 = 1f - num / 180f;
		float num3 = Mathf.Clamp(1f - (NAPPHEPPHKD - num2) / (1f - num2), 0f, 1f);
		float num4 = Mathf.Clamp(num2 / NAPPHEPPHKD, 0f, 1f);
		for (int i = 0; i < BMLPAEMMIMP; i++)
		{
			num4 = Mathf.Sin(num4 * 3.1415927f * 0.5f);
		}
		return Quaternion.Slerp(Quaternion.identity, PHKIOHIBNPA, num4 * num3);
	}

	// Token: 0x0600D455 RID: 54357 RVA: 0x0060E890 File Offset: 0x0060CA90
	public static float ILKJPHGKMEP(float NEPBPMGGPKM, float NAPPHEPPHKD, int BMLPAEMMIMP)
	{
		if (NAPPHEPPHKD >= 1f)
		{
			return 0f;
		}
		if (NAPPHEPPHKD <= 0f)
		{
			return NEPBPMGGPKM;
		}
		float num = 1f - Mathf.Abs(NEPBPMGGPKM) / 180f;
		float num2 = Mathf.Clamp(1f - (NAPPHEPPHKD - num) / (1f - num), 0f, 1f);
		float num3 = Mathf.Clamp(num / NAPPHEPPHKD, 0f, 1f);
		for (int i = 0; i < BMLPAEMMIMP; i++)
		{
			num3 = Mathf.Sin(num3 * 3.1415927f * 0.5f);
		}
		return Mathf.Lerp(0f, NEPBPMGGPKM, num3 * num2);
	}
}
