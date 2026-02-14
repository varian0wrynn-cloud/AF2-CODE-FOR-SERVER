using System;
using UnityEngine;

// Token: 0x020003DB RID: 987
public static class OOJJKBHKGNJ
{
	// Token: 0x0600D4BA RID: 54458 RVA: 0x0060F537 File Offset: 0x0060D737
	public static Vector3 IIAFGICFLIF(Vector3 APKMHNHGDHA, Vector3 BMNPGMPOLAI, float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD <= 0f)
		{
			return APKMHNHGDHA;
		}
		if (NKHBAJKMAGD >= 1f)
		{
			return BMNPGMPOLAI;
		}
		return Vector3.Lerp(APKMHNHGDHA, BMNPGMPOLAI, NKHBAJKMAGD);
	}

	// Token: 0x0600D4BB RID: 54459 RVA: 0x0060F555 File Offset: 0x0060D755
	public static Vector3 ODHADLHEEFC(Vector3 APKMHNHGDHA, Vector3 BMNPGMPOLAI, float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD <= 0f)
		{
			return APKMHNHGDHA;
		}
		if (NKHBAJKMAGD >= 1f)
		{
			return BMNPGMPOLAI;
		}
		return Vector3.Slerp(APKMHNHGDHA, BMNPGMPOLAI, NKHBAJKMAGD);
	}

	// Token: 0x0600D4BC RID: 54460 RVA: 0x0060F573 File Offset: 0x0060D773
	public static Vector3 LGBBHCACOMH(Vector3 LIBEPMOMPID, Vector3 AAOGJELLHIL, float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD == 0f)
		{
			return Vector3.zero;
		}
		return Vector3.Project(LIBEPMOMPID, AAOGJELLHIL) * NKHBAJKMAGD;
	}

	// Token: 0x0600D4BD RID: 54461 RVA: 0x0060F590 File Offset: 0x0060D790
	public static Vector3 BNKAEBNIMLP(Vector3 LIBEPMOMPID, Vector3 LJGHBOFJDBJ, float NKHBAJKMAGD)
	{
		if (NKHBAJKMAGD == 0f)
		{
			return Vector3.zero;
		}
		Vector3 onNormal = LIBEPMOMPID;
		Vector3.OrthoNormalize(ref LJGHBOFJDBJ, ref onNormal);
		return Vector3.Project(LIBEPMOMPID, onNormal) * NKHBAJKMAGD;
	}

	// Token: 0x0600D4BE RID: 54462 RVA: 0x0060F5C4 File Offset: 0x0060D7C4
	public static Vector3 PNFHIEFDEGD(Vector3 NEMFIHCKJPE, Vector3 CPHMPIPMHGK, float NAPPHEPPHKD, int BMLPAEMMIMP, out bool LNPJAKGGGEJ)
	{
		LNPJAKGGGEJ = false;
		if (NAPPHEPPHKD <= 0f)
		{
			return NEMFIHCKJPE;
		}
		if (NAPPHEPPHKD >= 1f)
		{
			LNPJAKGGGEJ = true;
			return CPHMPIPMHGK;
		}
		float num = Vector3.Angle(CPHMPIPMHGK, NEMFIHCKJPE);
		float num2 = 1f - num / 180f;
		if (num2 > NAPPHEPPHKD)
		{
			return NEMFIHCKJPE;
		}
		LNPJAKGGGEJ = true;
		float num3 = (NAPPHEPPHKD > 0f) ? Mathf.Clamp(1f - (NAPPHEPPHKD - num2) / (1f - num2), 0f, 1f) : 1f;
		float num4 = (NAPPHEPPHKD > 0f) ? Mathf.Clamp(num2 / NAPPHEPPHKD, 0f, 1f) : 1f;
		for (int i = 0; i < BMLPAEMMIMP; i++)
		{
			num4 = Mathf.Sin(num4 * 3.1415927f * 0.5f);
		}
		return Vector3.Slerp(CPHMPIPMHGK, NEMFIHCKJPE, num4 * num3);
	}

	// Token: 0x0600D4BF RID: 54463 RVA: 0x0060F68C File Offset: 0x0060D88C
	public static Vector3 PNFHIEFDEGD(Vector3 NEMFIHCKJPE, Vector3 CPHMPIPMHGK, float NAPPHEPPHKD, int BMLPAEMMIMP, out float MJLFCFIHKDF)
	{
		MJLFCFIHKDF = 1f;
		if (NAPPHEPPHKD <= 0f)
		{
			return NEMFIHCKJPE;
		}
		if (NAPPHEPPHKD >= 1f)
		{
			return CPHMPIPMHGK;
		}
		float num = Vector3.Angle(CPHMPIPMHGK, NEMFIHCKJPE);
		float num2 = 1f - num / 180f;
		if (num2 > NAPPHEPPHKD)
		{
			MJLFCFIHKDF = 0f;
			return NEMFIHCKJPE;
		}
		float num3 = (NAPPHEPPHKD > 0f) ? Mathf.Clamp(1f - (NAPPHEPPHKD - num2) / (1f - num2), 0f, 1f) : 1f;
		float num4 = (NAPPHEPPHKD > 0f) ? Mathf.Clamp(num2 / NAPPHEPPHKD, 0f, 1f) : 1f;
		for (int i = 0; i < BMLPAEMMIMP; i++)
		{
			num4 = Mathf.Sin(num4 * 3.1415927f * 0.5f);
		}
		float num5 = num4 * num3;
		MJLFCFIHKDF = 1f - num5;
		return Vector3.Slerp(CPHMPIPMHGK, NEMFIHCKJPE, num5);
	}

	// Token: 0x0600D4C0 RID: 54464 RVA: 0x0060F768 File Offset: 0x0060D968
	public static Vector3 OFGBHBILPOE(Vector3 PFJKGIJGDBH, Vector3 NEMFIHCKJPE, Vector3 KACGOENIMCA, Vector3 AIDDGKFBIOP)
	{
		float num = Vector3.Dot(AIDDGKFBIOP - PFJKGIJGDBH, KACGOENIMCA);
		float num2 = Vector3.Dot(NEMFIHCKJPE, KACGOENIMCA);
		if (num2 == 0f)
		{
			return Vector3.zero;
		}
		float d = num / num2;
		return PFJKGIJGDBH + NEMFIHCKJPE.normalized * d;
	}
}
