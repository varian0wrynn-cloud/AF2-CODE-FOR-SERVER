using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020004FE RID: 1278
public static class NCFJIBJEMCF
{
	// Token: 0x060111E7 RID: 70119 RVA: 0x007A05E0 File Offset: 0x0079E7E0
	public static bool KJKIKGIEPJN(Vector3 PFJKGIJGDBH, Vector3 GMDCCFLLCJA, Vector3 DJOPMIDJDLO, Vector3 FIDIDIBFPIK, Vector3 BHMOJNEFFIK, ref float DKIHDOELFEH, ref Vector3 LJGHBOFJDBJ)
	{
		POKHFFPGFLO.FLBIMMKKNDL(DJOPMIDJDLO, FIDIDIBFPIK, ref NCFJIBJEMCF.INDGMCFCAHH);
		POKHFFPGFLO.FLBIMMKKNDL(DJOPMIDJDLO, BHMOJNEFFIK, ref NCFJIBJEMCF.GCOKLIFCFLF);
		POKHFFPGFLO.BGBLGGJCIKN(GMDCCFLLCJA, NCFJIBJEMCF.GCOKLIFCFLF, ref NCFJIBJEMCF.HOMAGIBEHKG);
		float num = Vector3.Dot(NCFJIBJEMCF.INDGMCFCAHH, NCFJIBJEMCF.HOMAGIBEHKG);
		if (num < Mathf.Epsilon)
		{
			return false;
		}
		POKHFFPGFLO.FLBIMMKKNDL(DJOPMIDJDLO, PFJKGIJGDBH, ref NCFJIBJEMCF.PBCKKFOCFON);
		float num2 = Vector3.Dot(NCFJIBJEMCF.PBCKKFOCFON, NCFJIBJEMCF.HOMAGIBEHKG);
		if (num2 < 0f || num2 > num)
		{
			return false;
		}
		POKHFFPGFLO.BGBLGGJCIKN(NCFJIBJEMCF.PBCKKFOCFON, NCFJIBJEMCF.INDGMCFCAHH, ref NCFJIBJEMCF.HOMAGIBEHKG);
		float num3 = Vector3.Dot(GMDCCFLLCJA, NCFJIBJEMCF.HOMAGIBEHKG);
		if (num3 < 0f || num2 + num3 > num)
		{
			return false;
		}
		DKIHDOELFEH = Vector3.Dot(NCFJIBJEMCF.GCOKLIFCFLF, NCFJIBJEMCF.HOMAGIBEHKG) * (1f / num);
		POKHFFPGFLO.BGBLGGJCIKN(NCFJIBJEMCF.INDGMCFCAHH, NCFJIBJEMCF.GCOKLIFCFLF, ref LJGHBOFJDBJ);
		return true;
	}

	// Token: 0x060111E8 RID: 70120 RVA: 0x007A06B8 File Offset: 0x0079E8B8
	public static bool EKGAJEOBEMK(Vector3 PFJKGIJGDBH, Vector3 NEMFIHCKJPE, Vector3 DNFKMJBGMPL, Vector3 PNGGIABMOOA, Vector3 ELDNIMMHNIK, out float DHJLBHCPNKF, out Vector3 EJKEHAGOPOG)
	{
		DHJLBHCPNKF = 0f;
		EJKEHAGOPOG = new Vector3(0f, 0f, 0f);
		NCFJIBJEMCF.INDGMCFCAHH.x = PNGGIABMOOA.x - DNFKMJBGMPL.x;
		NCFJIBJEMCF.INDGMCFCAHH.y = PNGGIABMOOA.y - DNFKMJBGMPL.y;
		NCFJIBJEMCF.INDGMCFCAHH.z = PNGGIABMOOA.z - DNFKMJBGMPL.z;
		NCFJIBJEMCF.GCOKLIFCFLF.x = ELDNIMMHNIK.x - DNFKMJBGMPL.x;
		NCFJIBJEMCF.GCOKLIFCFLF.y = ELDNIMMHNIK.y - DNFKMJBGMPL.y;
		NCFJIBJEMCF.GCOKLIFCFLF.z = ELDNIMMHNIK.z - DNFKMJBGMPL.z;
		POKHFFPGFLO.BGBLGGJCIKN(NEMFIHCKJPE, NCFJIBJEMCF.GCOKLIFCFLF, ref NCFJIBJEMCF.PBCKKFOCFON.x, ref NCFJIBJEMCF.PBCKKFOCFON.y, ref NCFJIBJEMCF.PBCKKFOCFON.z);
		float num = Vector3.Dot(NCFJIBJEMCF.INDGMCFCAHH, NCFJIBJEMCF.PBCKKFOCFON);
		if (num > -Mathf.Epsilon && num < Mathf.Epsilon)
		{
			return false;
		}
		float num2 = 1f / num;
		Vector3 vector;
		vector.x = PFJKGIJGDBH.x - DNFKMJBGMPL.x;
		vector.y = PFJKGIJGDBH.y - DNFKMJBGMPL.y;
		vector.z = PFJKGIJGDBH.z - DNFKMJBGMPL.z;
		float num3 = Vector3.Dot(vector, NCFJIBJEMCF.PBCKKFOCFON) * num2;
		if (num3 < 0f || num3 > 1f)
		{
			return false;
		}
		POKHFFPGFLO.BGBLGGJCIKN(vector, NCFJIBJEMCF.INDGMCFCAHH, ref NCFJIBJEMCF.HOMAGIBEHKG.x, ref NCFJIBJEMCF.HOMAGIBEHKG.y, ref NCFJIBJEMCF.HOMAGIBEHKG.z);
		float num4 = Vector3.Dot(NEMFIHCKJPE, NCFJIBJEMCF.HOMAGIBEHKG) * num2;
		if (num4 < 0f || num3 + num4 > 1f)
		{
			return false;
		}
		float num5 = Vector3.Dot(NCFJIBJEMCF.GCOKLIFCFLF, NCFJIBJEMCF.HOMAGIBEHKG) * num2;
		if (num5 > Mathf.Epsilon)
		{
			DHJLBHCPNKF = num5;
			EJKEHAGOPOG.x = num3 * PNGGIABMOOA.x + num4 * ELDNIMMHNIK.x + (1f - (num3 + num4)) * DNFKMJBGMPL.x;
			EJKEHAGOPOG.y = num3 * PNGGIABMOOA.y + num4 * ELDNIMMHNIK.y + (1f - (num3 + num4)) * DNFKMJBGMPL.y;
			EJKEHAGOPOG.z = num3 * PNGGIABMOOA.z + num4 * ELDNIMMHNIK.z + (1f - (num3 + num4)) * DNFKMJBGMPL.z;
			return true;
		}
		return false;
	}

	// Token: 0x060111E9 RID: 70121 RVA: 0x007A0918 File Offset: 0x0079EB18
	public static Vector3 BHGHMKEJLPI(Vector3 EDLMAPJDHFL, Vector3 OELAKKHNNJC, Vector3 HPJKHGBNCPE)
	{
		float hdncfnlahhc = OELAKKHNNJC.x - EDLMAPJDHFL.x;
		float jiipijcbbfo = OELAKKHNNJC.y - EDLMAPJDHFL.y;
		float nhfdknbefoe = OELAKKHNNJC.z - EDLMAPJDHFL.z;
		float aigccmndlgb = HPJKHGBNCPE.x - EDLMAPJDHFL.x;
		float ihoeancbabj = HPJKHGBNCPE.y - EDLMAPJDHFL.y;
		float bdkoblfjhhe = HPJKHGBNCPE.z - EDLMAPJDHFL.z;
		Vector3 zero = Vector3.zero;
		POKHFFPGFLO.BGBLGGJCIKN(hdncfnlahhc, jiipijcbbfo, nhfdknbefoe, aigccmndlgb, ihoeancbabj, bdkoblfjhhe, ref zero.x, ref zero.y, ref zero.z);
		zero.Normalize();
		if (zero.magnitude < Mathf.Epsilon)
		{
			return new Vector3(0f, 0f, 0f);
		}
		return zero;
	}

	// Token: 0x060111EA RID: 70122 RVA: 0x007A09CC File Offset: 0x0079EBCC
	public static Vector3 BHGHMKEJLPI(Vector3[] GANHFPMHKCL)
	{
		if (GANHFPMHKCL.Length < 3)
		{
			return Vector3.zero;
		}
		if (GANHFPMHKCL.Length % 3 == 0)
		{
			Vector3 a = Vector3.zero;
			for (int i = 0; i < GANHFPMHKCL.Length; i += 3)
			{
				a += NCFJIBJEMCF.BHGHMKEJLPI(GANHFPMHKCL[i], GANHFPMHKCL[i + 1], GANHFPMHKCL[i + 2]);
			}
			return a / ((float)GANHFPMHKCL.Length / 3f);
		}
		Vector3 vector = Vector3.Cross(GANHFPMHKCL[1] - GANHFPMHKCL[0], GANHFPMHKCL[2] - GANHFPMHKCL[0]);
		if (vector.magnitude < Mathf.Epsilon)
		{
			return new Vector3(0f, 0f, 0f);
		}
		return vector.normalized;
	}

	// Token: 0x060111EB RID: 70123 RVA: 0x007A0A8C File Offset: 0x0079EC8C
	public static void JGDKLBELBDN(Vector3[] OKLLKJPCJLK, Vector2[] PCLAMFIICMF, int[] KDDOFNENELO, out Vector3 LJGHBOFJDBJ, out Vector3 BOGIINEDPCF, out Vector3 JOFDAAKEBAD)
	{
		LJGHBOFJDBJ = NCFJIBJEMCF.BHGHMKEJLPI(OKLLKJPCJLK[KDDOFNENELO[0]], OKLLKJPCJLK[KDDOFNENELO[1]], OKLLKJPCJLK[KDDOFNENELO[2]]);
		Vector3 vector = Vector3.zero;
		Vector3 vector2 = Vector3.zero;
		Vector4 vector3 = new Vector4(0f, 0f, 0f, 1f);
		long num = (long)KDDOFNENELO[0];
		long num2 = (long)KDDOFNENELO[1];
		long num3 = (long)KDDOFNENELO[2];
		Vector3 vector4;
		Vector3 vector5;
		Vector3 vector6;
		Vector2 vector7;
		Vector2 vector8;
		Vector2 vector9;
		checked
		{
			vector4 = OKLLKJPCJLK[(int)((IntPtr)num)];
			vector5 = OKLLKJPCJLK[(int)((IntPtr)num2)];
			vector6 = OKLLKJPCJLK[(int)((IntPtr)num3)];
			vector7 = PCLAMFIICMF[(int)((IntPtr)num)];
			vector8 = PCLAMFIICMF[(int)((IntPtr)num2)];
			vector9 = PCLAMFIICMF[(int)((IntPtr)num3)];
		}
		float num4 = vector5.x - vector4.x;
		float num5 = vector6.x - vector4.x;
		float num6 = vector5.y - vector4.y;
		float num7 = vector6.y - vector4.y;
		float num8 = vector5.z - vector4.z;
		float num9 = vector6.z - vector4.z;
		float num10 = vector8.x - vector7.x;
		float num11 = vector9.x - vector7.x;
		float num12 = vector8.y - vector7.y;
		float num13 = vector9.y - vector7.y;
		float num14 = 1f / (num10 * num13 - num11 * num12);
		Vector3 b = new Vector3((num13 * num4 - num12 * num5) * num14, (num13 * num6 - num12 * num7) * num14, (num13 * num8 - num12 * num9) * num14);
		Vector3 b2 = new Vector3((num10 * num5 - num11 * num4) * num14, (num10 * num7 - num11 * num6) * num14, (num10 * num9 - num11 * num8) * num14);
		vector += b;
		vector2 += b2;
		Vector3 lhs = LJGHBOFJDBJ;
		Vector3.OrthoNormalize(ref lhs, ref vector);
		vector3.x = vector.x;
		vector3.y = vector.y;
		vector3.z = vector.z;
		vector3.w = ((Vector3.Dot(Vector3.Cross(lhs, vector), vector2) < 0f) ? -1f : 1f);
		BOGIINEDPCF = vector3 * vector3.w;
		JOFDAAKEBAD = Vector3.Cross(LJGHBOFJDBJ, BOGIINEDPCF);
	}

	// Token: 0x060111EC RID: 70124 RVA: 0x007A0CF3 File Offset: 0x0079EEF3
	public static int HBNNDJCCGDA(int DCCPCBLODIG, int FNADKBPAGJH, int DAILMANBNMM)
	{
		if (DCCPCBLODIG < FNADKBPAGJH)
		{
			return FNADKBPAGJH;
		}
		if (DCCPCBLODIG <= DAILMANBNMM)
		{
			return DCCPCBLODIG;
		}
		return DAILMANBNMM;
	}

	// Token: 0x060111ED RID: 70125 RVA: 0x007A0D04 File Offset: 0x0079EF04
	public static Vector3 INHBIAADCCM(Vector3[] INFEGEBCAAF, IEnumerable<int> NFEODOODKDI)
	{
		Vector3 zero = Vector3.zero;
		int num = 0;
		foreach (int num2 in NFEODOODKDI)
		{
			zero.x += INFEGEBCAAF[num2].x;
			zero.y += INFEGEBCAAF[num2].y;
			zero.z += INFEGEBCAAF[num2].z;
			num++;
		}
		return zero / (float)num;
	}

	// Token: 0x060111EE RID: 70126 RVA: 0x007A0DA0 File Offset: 0x0079EFA0
	public static Vector3 ADGMEMGAPEI(Vector3[] INFEGEBCAAF, IList<int> NFEODOODKDI, float[] IIOKOEIKBDB)
	{
		float num = 0f;
		Vector3 a = Vector3.zero;
		for (int i = 0; i < NFEODOODKDI.Count; i++)
		{
			float num2 = IIOKOEIKBDB[NFEODOODKDI[i]];
			a.x += INFEGEBCAAF[NFEODOODKDI[i]].x * num2;
			a.y += INFEGEBCAAF[NFEODOODKDI[i]].y * num2;
			a.z += INFEGEBCAAF[NFEODOODKDI[i]].z * num2;
			num += num2;
		}
		if (num <= Mathf.Epsilon)
		{
			return Vector3.zero;
		}
		return a /= num;
	}

	// Token: 0x060111EF RID: 70127 RVA: 0x007A0E4C File Offset: 0x0079F04C
	public static bool KKOOKCEEHJN(Vector3 BDGECGGHECB)
	{
		return Mathf.Abs(BDGECGGHECB.x - BDGECGGHECB.y) < Mathf.Epsilon && Mathf.Abs(BDGECGGHECB.x - BDGECGGHECB.z) < Mathf.Epsilon;
	}

	// Token: 0x040023CC RID: 9164
	private static Vector3 INDGMCFCAHH;

	// Token: 0x040023CD RID: 9165
	private static Vector3 GCOKLIFCFLF;

	// Token: 0x040023CE RID: 9166
	private static Vector3 PBCKKFOCFON;

	// Token: 0x040023CF RID: 9167
	private static Vector3 HOMAGIBEHKG;
}
