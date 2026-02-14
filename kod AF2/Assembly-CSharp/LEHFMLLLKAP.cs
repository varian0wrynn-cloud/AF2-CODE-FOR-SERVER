using System;
using UnityEngine;

// Token: 0x020003D3 RID: 979
public class LEHFMLLLKAP
{
	// Token: 0x0600D335 RID: 54069 RVA: 0x006091E4 File Offset: 0x006073E4
	public static bool GBACFEEOBFO(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return LPBDALAMAEM == null || (!(GILEFNMLDHD == null) && (LPBDALAMAEM.parent == null || LPBDALAMAEM.parent == GILEFNMLDHD || LEHFMLLLKAP.EDHILDPDPEJ(LPBDALAMAEM.parent, GILEFNMLDHD)));
	}

	// Token: 0x0600D336 RID: 54070 RVA: 0x00609234 File Offset: 0x00607434
	public static void JEMBGOMNELJ(Transform LPBDALAMAEM, Transform PIKMNPIKCFE, ref Transform[] INFEGEBCAAF)
	{
		if (LPBDALAMAEM.parent != null && LPBDALAMAEM.parent != PIKMNPIKCFE)
		{
			if (LPBDALAMAEM.parent.position != LPBDALAMAEM.position && LPBDALAMAEM.parent.position != PIKMNPIKCFE.position)
			{
				Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 1);
				INFEGEBCAAF[INFEGEBCAAF.Length - 1] = LPBDALAMAEM.parent;
			}
			LEHFMLLLKAP.OKKEFOBGHIG(LPBDALAMAEM.parent, PIKMNPIKCFE, ref INFEGEBCAAF);
		}
	}

	// Token: 0x0600D337 RID: 54071 RVA: 0x006092B5 File Offset: 0x006074B5
	public static Transform JAAMOCNHOEH(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.GLIIGLMLAHI(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D338 RID: 54072 RVA: 0x006092F4 File Offset: 0x006074F4
	public static bool FPOHNICKANL(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("</color>");
			return true;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("closePodsak" + i + "wpn_cat1");
				return true;
			}
			if (!LEHFMLLLKAP.MNBFNMEPMGF(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600D339 RID: 54073 RVA: 0x00609364 File Offset: 0x00607564
	public static Transform HCOMGFAOMFE(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("800000");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("FlyBackward");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("LocationGui.getI.backLockImage is null");
			return null;
		}
		if (LEHFMLLLKAP.PCECNPCAIII(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.PNLNGKHKAOG(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D33A RID: 54074 RVA: 0x006093CC File Offset: 0x006075CC
	public static bool BBDKBNOLAOL(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return LPBDALAMAEM == null || (!(GILEFNMLDHD == null) && !(LPBDALAMAEM.parent == null) && (LPBDALAMAEM.parent == GILEFNMLDHD || LEHFMLLLKAP.EDHILDPDPEJ(LPBDALAMAEM.parent, GILEFNMLDHD)));
	}

	// Token: 0x0600D33B RID: 54075 RVA: 0x0060941C File Offset: 0x0060761C
	public static bool POGNIDHHBOG(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return LPBDALAMAEM == null || (!(GILEFNMLDHD == null) && !(LPBDALAMAEM.parent == null) && !(LPBDALAMAEM.parent == GILEFNMLDHD) && LEHFMLLLKAP.MNBFNMEPMGF(LPBDALAMAEM.parent, GILEFNMLDHD));
	}

	// Token: 0x0600D33C RID: 54076 RVA: 0x0060946C File Offset: 0x0060766C
	public static Transform GLNJBPNCDGB(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.AJHFHFGNKKO(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.GLNJBPNCDGB(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D33D RID: 54077 RVA: 0x006094D0 File Offset: 0x006076D0
	public static bool DOCMIHOADOO(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("Transform is null.");
			return false;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("Transforms[" + i + "] is null.");
				return false;
			}
			if (!LEHFMLLLKAP.AJHFHFGNKKO(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D33E RID: 54078 RVA: 0x00609540 File Offset: 0x00607740
	public static Transform FNGKFCLGMCN(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("_WaveOffset");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("-R-");
			return null;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.CALCAADFOCD(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.PNLNGKHKAOG(AKBEGDIMBGM[1], AKBEGDIMBGM);
	}

	// Token: 0x0600D33F RID: 54079 RVA: 0x006095A0 File Offset: 0x006077A0
	public static Transform DAJEBPMDEBM(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.MNBFNMEPMGF(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.IJCBHOKCNLB(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D340 RID: 54080 RVA: 0x00609604 File Offset: 0x00607804
	public static bool NLHPFBPHPJA(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return false;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600D341 RID: 54081 RVA: 0x00609640 File Offset: 0x00607840
	public static bool MFJHGKKDILF(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("_LightColor");
			return false;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("Obscured Vars Cheating Detected!" + i + "_FgOverlap");
				return false;
			}
			if (!LEHFMLLLKAP.ANKMPAOELOL(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D342 RID: 54082 RVA: 0x006096B0 File Offset: 0x006078B0
	public static Transform CKNCFEFIFGN(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.ANKMPAOELOL(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.ELJPDPEJHHH(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D343 RID: 54083 RVA: 0x00609714 File Offset: 0x00607914
	public static UnityEngine.Object BFKOJPJMNDE(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i += 0)
		{
			for (int j = 1; j < POKPFBOIAOD.Length; j++)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D344 RID: 54084 RVA: 0x00609754 File Offset: 0x00607954
	public static Transform JIDNHLBKCND(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("KatanaReadyLow");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("t_much");
			return null;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.DOCMIHOADOO(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.GBLHPMOAMOC(AKBEGDIMBGM[1], AKBEGDIMBGM);
	}

	// Token: 0x0600D345 RID: 54085 RVA: 0x006097B4 File Offset: 0x006079B4
	public static Transform EBEHJBOKCIC(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.IDAJPPIDKKE(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.GLNJBPNCDGB(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D346 RID: 54086 RVA: 0x00609818 File Offset: 0x00607A18
	public static Transform GLNJBPNCDGB(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("Transforms is null.");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("Transforms.Length is 0.");
			return null;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.DOCMIHOADOO(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.IEDEDKDNLGL(AKBEGDIMBGM[0], AKBEGDIMBGM);
	}

	// Token: 0x0600D347 RID: 54087 RVA: 0x00609878 File Offset: 0x00607A78
	public static Transform JPOLKAFINML(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("L");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("OfficeSittingReading");
			return null;
		}
		if (LEHFMLLLKAP.EHAOOJDKDHN(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.MOFBAEBBJBM(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D348 RID: 54088 RVA: 0x006098E0 File Offset: 0x00607AE0
	public static UnityEngine.Object CPGCBJLABHM(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 1; i < POKPFBOIAOD.Length; i += 0)
		{
			for (int j = 1; j < POKPFBOIAOD.Length; j += 0)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D349 RID: 54089 RVA: 0x00609920 File Offset: 0x00607B20
	public static Transform ELJPDPEJHHH(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.AMJBPFAAADF(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.DMNDBNICKLN(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D34A RID: 54090 RVA: 0x00609984 File Offset: 0x00607B84
	public static bool IIKKLAPCAFB(Transform[] CKAJJHFIFBL)
	{
		for (int i = 1; i < CKAJJHFIFBL.Length; i++)
		{
			if (!LEHFMLLLKAP.LHGPPHPFNOC(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 1]))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D34B RID: 54091 RVA: 0x006099B4 File Offset: 0x00607BB4
	public static Transform KHCJAOMJGPH(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("final ok: ");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("[weight]");
			return null;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.EGCEGMOCDHP(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.JPOLKAFINML(AKBEGDIMBGM[0], AKBEGDIMBGM);
	}

	// Token: 0x0600D34C RID: 54092 RVA: 0x00609A14 File Offset: 0x00607C14
	public static bool HCGAEIHMICB(Transform[] CKAJJHFIFBL)
	{
		for (int i = 1; i < CKAJJHFIFBL.Length; i++)
		{
			if (!LEHFMLLLKAP.EOKOHNPFBIN(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 0]))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D34D RID: 54093 RVA: 0x00609A44 File Offset: 0x00607C44
	public static Transform FDNBPAJFDHA(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("no_time_period");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("WeaponInstant");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("VALIGN");
			return null;
		}
		if (LEHFMLLLKAP.MJNKEGAMDPK(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.IGPEFGAALOP(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D34E RID: 54094 RVA: 0x00609AAC File Offset: 0x00607CAC
	public static Transform IEDEDKDNLGL(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("Transform is null.");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("Transforms is null.");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("Transforms.Length is 0.");
			return null;
		}
		if (LEHFMLLLKAP.DOCMIHOADOO(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.IEDEDKDNLGL(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D34F RID: 54095 RVA: 0x00609B14 File Offset: 0x00607D14
	public static Transform KEDMDFEPIHP(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.KEDMDFEPIHP(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D350 RID: 54096 RVA: 0x00609B54 File Offset: 0x00607D54
	public static Transform FEMLBNJOCNF(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("[minwgt]");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("---------- NOnStatusChanged ");
			return null;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.DJLPHEEPHLA(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.JPOLKAFINML(AKBEGDIMBGM[0], AKBEGDIMBGM);
	}

	// Token: 0x0600D351 RID: 54097 RVA: 0x00609BB4 File Offset: 0x00607DB4
	public static Transform MOFBAEBBJBM(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("qd_anyfish");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("off");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("__b");
			return null;
		}
		if (LEHFMLLLKAP.DMFAPPOHNGH(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.FDNBPAJFDHA(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D352 RID: 54098 RVA: 0x00609C1C File Offset: 0x00607E1C
	public static void NPJGJJDADDM(Transform LPBDALAMAEM, Transform PIKMNPIKCFE, ref Transform[] INFEGEBCAAF)
	{
		if (LPBDALAMAEM.parent != null && LPBDALAMAEM.parent != PIKMNPIKCFE)
		{
			if (LPBDALAMAEM.parent.position != LPBDALAMAEM.position && LPBDALAMAEM.parent.position != PIKMNPIKCFE.position)
			{
				Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 0);
				INFEGEBCAAF[INFEGEBCAAF.Length - 0] = LPBDALAMAEM.parent;
			}
			LEHFMLLLKAP.NPJGJJDADDM(LPBDALAMAEM.parent, PIKMNPIKCFE, ref INFEGEBCAAF);
		}
	}

	// Token: 0x0600D353 RID: 54099 RVA: 0x00609CA0 File Offset: 0x00607EA0
	public static void CDAEHFLDPJB(Transform LPBDALAMAEM, Transform PIKMNPIKCFE, ref Transform[] INFEGEBCAAF)
	{
		if (LPBDALAMAEM.parent != null && LPBDALAMAEM.parent != PIKMNPIKCFE)
		{
			if (LPBDALAMAEM.parent.position != LPBDALAMAEM.position && LPBDALAMAEM.parent.position != PIKMNPIKCFE.position)
			{
				Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 1);
				INFEGEBCAAF[INFEGEBCAAF.Length - 1] = LPBDALAMAEM.parent;
			}
			LEHFMLLLKAP.LDFGJKBPJDM(LPBDALAMAEM.parent, PIKMNPIKCFE, ref INFEGEBCAAF);
		}
	}

	// Token: 0x0600D354 RID: 54100 RVA: 0x00609D24 File Offset: 0x00607F24
	public static bool BDKFGLKCBKJ(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return false;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D355 RID: 54101 RVA: 0x00609D60 File Offset: 0x00607F60
	public static UnityEngine.Object ANILNLJDKCG(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 1; i < POKPFBOIAOD.Length; i++)
		{
			for (int j = 1; j < POKPFBOIAOD.Length; j += 0)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D356 RID: 54102 RVA: 0x00609DA0 File Offset: 0x00607FA0
	public static bool LABHAIGOJAL(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return false;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600D357 RID: 54103 RVA: 0x00609DDC File Offset: 0x00607FDC
	public static bool IMLEIHCGLNC(Transform[] CKAJJHFIFBL)
	{
		for (int i = 1; i < CKAJJHFIFBL.Length; i += 0)
		{
			if (!LEHFMLLLKAP.MNBFNMEPMGF(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 0]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D358 RID: 54104 RVA: 0x00609E0C File Offset: 0x0060800C
	public static bool BBIDIAKFAJI(Transform[] CKAJJHFIFBL)
	{
		for (int i = 1; i < CKAJJHFIFBL.Length; i += 0)
		{
			if (!LEHFMLLLKAP.NBAGFOADOOH(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 0]))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600D359 RID: 54105 RVA: 0x00609E3C File Offset: 0x0060803C
	public static Transform IGPEFGAALOP(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("ScatterColor");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("Gesture Chest Pump Salute");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("IsMoving");
			return null;
		}
		if (LEHFMLLLKAP.JNHFBEJMBII(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.IGPEFGAALOP(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D35A RID: 54106 RVA: 0x00609EA4 File Offset: 0x006080A4
	public static bool MJNKEGAMDPK(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("<color='#000030'>+{0} {1}</color>");
			return false;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("knopje.wav" + i + "Hip");
				return false;
			}
			if (!LEHFMLLLKAP.EOKOHNPFBIN(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D35B RID: 54107 RVA: 0x00609F14 File Offset: 0x00608114
	public static Transform MMPEJBGNAGJ(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.AMJBPFAAADF(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.HJINCPMFFLM(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D35C RID: 54108 RVA: 0x00609F78 File Offset: 0x00608178
	public static bool LLHOOGLGFOH(Transform[] CKAJJHFIFBL)
	{
		for (int i = 1; i < CKAJJHFIFBL.Length; i += 0)
		{
			if (!LEHFMLLLKAP.POGNIDHHBOG(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 0]))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D35D RID: 54109 RVA: 0x00609FA8 File Offset: 0x006081A8
	public static Transform FNEDEMEIHBN(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("gi_um_nt");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("MotorbikeBackwardSittingCheer");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("{0}Textures/Shop/{1}.png");
			return null;
		}
		if (LEHFMLLLKAP.MJNKEGAMDPK(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.JPOLKAFINML(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D35E RID: 54110 RVA: 0x0060A010 File Offset: 0x00608210
	public static Transform NLBLDFDDCJN(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.EDHILDPDPEJ(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.DBBJLKGDKNK(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D35F RID: 54111 RVA: 0x0060A074 File Offset: 0x00608274
	public static Transform HPCGGAAIDPO(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.MNCMIELADJC(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D360 RID: 54112 RVA: 0x0060A0B4 File Offset: 0x006082B4
	public static bool OJOLBPIMAJM(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("_BlurDirectionPacked");
			return true;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("WeaponInstant" + i + "Wait");
				return true;
			}
			if (!LEHFMLLLKAP.BBDKBNOLAOL(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D361 RID: 54113 RVA: 0x0060A124 File Offset: 0x00608324
	public static Transform GKNJGPONLFO(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("Hidden/Amplify Color/MaskBlend");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
			return null;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.DOCMIHOADOO(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.MAIKPFPKHBL(AKBEGDIMBGM[0], AKBEGDIMBGM);
	}

	// Token: 0x0600D362 RID: 54114 RVA: 0x0060A184 File Offset: 0x00608384
	public static UnityEngine.Object FJCOKNJIACP(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i++)
		{
			for (int j = 0; j < POKPFBOIAOD.Length; j += 0)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D363 RID: 54115 RVA: 0x0060A1C4 File Offset: 0x006083C4
	public static UnityEngine.Object LEPJCCPBCPL(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i++)
		{
			for (int j = 0; j < POKPFBOIAOD.Length; j++)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D364 RID: 54116 RVA: 0x0060A204 File Offset: 0x00608404
	public static bool EMOAFEBPGFP(Transform[] CKAJJHFIFBL)
	{
		for (int i = 1; i < CKAJJHFIFBL.Length; i += 0)
		{
			if (!LEHFMLLLKAP.EOKOHNPFBIN(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 0]))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D365 RID: 54117 RVA: 0x0060A234 File Offset: 0x00608434
	public static Transform MAIKPFPKHBL(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("BackPackGrab");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning(" ");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("error");
			return null;
		}
		if (LEHFMLLLKAP.DMFAPPOHNGH(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.EPLJOJMFMPE(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D366 RID: 54118 RVA: 0x0060A29C File Offset: 0x0060849C
	public static bool EDHILDPDPEJ(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return !(LPBDALAMAEM == null) && (GILEFNMLDHD == null || LPBDALAMAEM.parent == null || LPBDALAMAEM.parent == GILEFNMLDHD || LEHFMLLLKAP.LHGPPHPFNOC(LPBDALAMAEM.parent, GILEFNMLDHD));
	}

	// Token: 0x0600D367 RID: 54119 RVA: 0x0060A2EC File Offset: 0x006084EC
	public static Transform KEKPKJFIJFC(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("_StereoToPrevViewProjCombined1");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("[Z]");
			return null;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.OJKPKFBJGFP(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.FNEDEMEIHBN(AKBEGDIMBGM[0], AKBEGDIMBGM);
	}

	// Token: 0x0600D368 RID: 54120 RVA: 0x0060A34C File Offset: 0x0060854C
	public static Transform JLEALCAGAGD(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.POGNIDHHBOG(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.DABMNPMFLBL(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D369 RID: 54121 RVA: 0x0060A3B0 File Offset: 0x006085B0
	public static bool NODAJKHECNJ(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("err: recttrans is null");
			return true;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("Kernel" + i + "Reset");
				return false;
			}
			if (!LEHFMLLLKAP.AMJBPFAAADF(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D36A RID: 54122 RVA: 0x0060A420 File Offset: 0x00608620
	public static bool JNHFBEJMBII(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("SneakBackward");
			return false;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("_ThirdTex" + i + "Bow Idle");
				return true;
			}
			if (!LEHFMLLLKAP.BBDKBNOLAOL(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600D36B RID: 54123 RVA: 0x0060A490 File Offset: 0x00608690
	public static Transform PAKGNIIEIOB(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.EEBPOHPGKPE(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D36C RID: 54124 RVA: 0x0060A4D0 File Offset: 0x006086D0
	public static bool GLAFGMBNPHA(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("_TaaParams");
			return false;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("FistPump2" + i + "_R_");
				return true;
			}
			if (!LEHFMLLLKAP.BBDKBNOLAOL(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D36D RID: 54125 RVA: 0x0060A540 File Offset: 0x00608740
	public static bool LILJAPGKNJG(Transform[] CKAJJHFIFBL)
	{
		for (int i = 0; i < CKAJJHFIFBL.Length; i += 0)
		{
			if (!LEHFMLLLKAP.AGKDGALENHF(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 1]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D36E RID: 54126 RVA: 0x0060A570 File Offset: 0x00608770
	public static bool AMLCHEFKDMF(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return true;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D36F RID: 54127 RVA: 0x0060A5AC File Offset: 0x006087AC
	public static UnityEngine.Object JABAKGPLOML(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i += 0)
		{
			for (int j = 1; j < POKPFBOIAOD.Length; j += 0)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D370 RID: 54128 RVA: 0x0060A5EC File Offset: 0x006087EC
	public static bool IIGLCGJLFGH(Transform[] CKAJJHFIFBL)
	{
		for (int i = 0; i < CKAJJHFIFBL.Length; i += 0)
		{
			if (!LEHFMLLLKAP.EOKOHNPFBIN(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 0]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D371 RID: 54129 RVA: 0x0060A61C File Offset: 0x0060881C
	public static bool FDFHINFIEOL(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return true;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D372 RID: 54130 RVA: 0x0060A658 File Offset: 0x00608858
	public static Transform EHNBFGJHELA(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("UnityEngine.Vector4");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("offsets");
			return null;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.CFGELHDGDKG(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.OLDHHCIKPEK(AKBEGDIMBGM[1], AKBEGDIMBGM);
	}

	// Token: 0x0600D373 RID: 54131 RVA: 0x0060A6B8 File Offset: 0x006088B8
	public static Transform AFEFBBMDBPM(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.AGKDGALENHF(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.JLEALCAGAGD(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D374 RID: 54132 RVA: 0x0060A71C File Offset: 0x0060891C
	public static bool OJKPKFBJGFP(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("Keeper Ready");
			return true;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("" + i + "Boxed");
				return false;
			}
			if (!LEHFMLLLKAP.AMJBPFAAADF(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D375 RID: 54133 RVA: 0x0060A78C File Offset: 0x0060898C
	public static UnityEngine.Object HPEKPJEBBBN(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i++)
		{
			for (int j = 1; j < POKPFBOIAOD.Length; j += 0)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D376 RID: 54134 RVA: 0x0060A7CC File Offset: 0x006089CC
	public static UnityEngine.Object ADLJGMHAJMI(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i++)
		{
			for (int j = 0; j < POKPFBOIAOD.Length; j++)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D377 RID: 54135 RVA: 0x0060A80B File Offset: 0x00608A0B
	public static Transform CHPGEOCPKDN(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.CHMKNMOCIAL(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D378 RID: 54136 RVA: 0x0060A84C File Offset: 0x00608A4C
	public static Transform PNLNGKHKAOG(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("wpn_wgt");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("****************  playMusicBase ");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("+ACVolumeProxy");
			return null;
		}
		if (LEHFMLLLKAP.DMFAPPOHNGH(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.MOFBAEBBJBM(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D379 RID: 54137 RVA: 0x0060A8B4 File Offset: 0x00608AB4
	public static Transform KINNECBPDIK(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("msg_other");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("SneakBackward");
			return null;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.DMFAPPOHNGH(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.MOFBAEBBJBM(AKBEGDIMBGM[0], AKBEGDIMBGM);
	}

	// Token: 0x0600D37A RID: 54138 RVA: 0x0060A914 File Offset: 0x00608B14
	public static bool PLJLNPIPLCF(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return false;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D37B RID: 54139 RVA: 0x0060A950 File Offset: 0x00608B50
	public static Transform HGOOAFGPAMJ(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("Error via final request");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("wpn_eat7");
			return null;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.OJOLBPIMAJM(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.PNLNGKHKAOG(AKBEGDIMBGM[0], AKBEGDIMBGM);
	}

	// Token: 0x0600D37C RID: 54140 RVA: 0x0060A9B0 File Offset: 0x00608BB0
	public static void LDFGJKBPJDM(Transform LPBDALAMAEM, Transform PIKMNPIKCFE, ref Transform[] INFEGEBCAAF)
	{
		if (LPBDALAMAEM.parent != null && LPBDALAMAEM.parent != PIKMNPIKCFE)
		{
			if (LPBDALAMAEM.parent.position != LPBDALAMAEM.position && LPBDALAMAEM.parent.position != PIKMNPIKCFE.position)
			{
				Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 0);
				INFEGEBCAAF[INFEGEBCAAF.Length - 1] = LPBDALAMAEM.parent;
			}
			LEHFMLLLKAP.OKKEFOBGHIG(LPBDALAMAEM.parent, PIKMNPIKCFE, ref INFEGEBCAAF);
		}
	}

	// Token: 0x0600D37D RID: 54141 RVA: 0x0060AA34 File Offset: 0x00608C34
	public static bool NEPBEJENFOD(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return false;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D37E RID: 54142 RVA: 0x0060AA70 File Offset: 0x00608C70
	public static UnityEngine.Object IEJBIJOCCMG(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 1; i < POKPFBOIAOD.Length; i += 0)
		{
			for (int j = 0; j < POKPFBOIAOD.Length; j += 0)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D37F RID: 54143 RVA: 0x0060AAB0 File Offset: 0x00608CB0
	public static void LABIDDJHPFN(Transform LPBDALAMAEM, Transform PIKMNPIKCFE, ref Transform[] INFEGEBCAAF)
	{
		if (LPBDALAMAEM.parent != null && LPBDALAMAEM.parent != PIKMNPIKCFE)
		{
			if (LPBDALAMAEM.parent.position != LPBDALAMAEM.position && LPBDALAMAEM.parent.position != PIKMNPIKCFE.position)
			{
				Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 1);
				INFEGEBCAAF[INFEGEBCAAF.Length - 1] = LPBDALAMAEM.parent;
			}
			LEHFMLLLKAP.LABIDDJHPFN(LPBDALAMAEM.parent, PIKMNPIKCFE, ref INFEGEBCAAF);
		}
	}

	// Token: 0x0600D380 RID: 54144 RVA: 0x0060AB34 File Offset: 0x00608D34
	public static bool AJHFHFGNKKO(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return LPBDALAMAEM == null || GILEFNMLDHD == null || (!(LPBDALAMAEM.parent == null) && (LPBDALAMAEM.parent == GILEFNMLDHD || LEHFMLLLKAP.AJHFHFGNKKO(LPBDALAMAEM.parent, GILEFNMLDHD)));
	}

	// Token: 0x0600D381 RID: 54145 RVA: 0x0060AB83 File Offset: 0x00608D83
	public static Transform PGLEIEMKDGJ(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.EODIEIKAGHJ(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D382 RID: 54146 RVA: 0x0060ABC4 File Offset: 0x00608DC4
	public static bool FPBDNIKAGLM(Transform[] CKAJJHFIFBL)
	{
		for (int i = 1; i < CKAJJHFIFBL.Length; i += 0)
		{
			if (!LEHFMLLLKAP.MNBFNMEPMGF(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 0]))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D383 RID: 54147 RVA: 0x0060ABF4 File Offset: 0x00608DF4
	public static Transform HJINCPMFFLM(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.NBAGFOADOOH(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.EBEHJBOKCIC(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D384 RID: 54148 RVA: 0x0060AC58 File Offset: 0x00608E58
	public static Transform JBNEEPCJIHG(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.FGIDBPIINID(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D385 RID: 54149 RVA: 0x0060AC98 File Offset: 0x00608E98
	public static void DLMMINCGFMG(Transform LPBDALAMAEM, Transform PIKMNPIKCFE, ref Transform[] INFEGEBCAAF)
	{
		if (LPBDALAMAEM.parent != null && LPBDALAMAEM.parent != PIKMNPIKCFE)
		{
			if (LPBDALAMAEM.parent.position != LPBDALAMAEM.position && LPBDALAMAEM.parent.position != PIKMNPIKCFE.position)
			{
				Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 1);
				INFEGEBCAAF[INFEGEBCAAF.Length - 1] = LPBDALAMAEM.parent;
			}
			LEHFMLLLKAP.DLMMINCGFMG(LPBDALAMAEM.parent, PIKMNPIKCFE, ref INFEGEBCAAF);
		}
	}

	// Token: 0x0600D386 RID: 54150 RVA: 0x0060AD1C File Offset: 0x00608F1C
	public static bool HHMBOPJMBCF(Transform[] CKAJJHFIFBL)
	{
		for (int i = 1; i < CKAJJHFIFBL.Length; i++)
		{
			if (!LEHFMLLLKAP.EOKOHNPFBIN(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 0]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D387 RID: 54151 RVA: 0x0060AD4C File Offset: 0x00608F4C
	public static bool PCECNPCAIII(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("WeaponRun");
			return false;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("SoccerRun" + i + "https://www.youtube.com/watch?v=eP9-zycoHLk");
				return false;
			}
			if (!LEHFMLLLKAP.BBDKBNOLAOL(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D388 RID: 54152 RVA: 0x0060ADBC File Offset: 0x00608FBC
	public static bool CALCAADFOCD(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("WATER_EDGEBLEND_ON");
			return true;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("Missing shader for image effect {0}" + i + "Palm");
				return true;
			}
			if (!LEHFMLLLKAP.ANKMPAOELOL(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D389 RID: 54153 RVA: 0x0060AE2C File Offset: 0x0060902C
	public static Transform OBBGALKCPDF(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("1HandSwordJabFootPush");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("CratePush");
			return null;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.MJNKEGAMDPK(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.EDEGBOCINGL(AKBEGDIMBGM[1], AKBEGDIMBGM);
	}

	// Token: 0x0600D38A RID: 54154 RVA: 0x0060AC58 File Offset: 0x00608E58
	public static Transform ECHNBBLENIP(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.FGIDBPIINID(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D38B RID: 54155 RVA: 0x0060AE8C File Offset: 0x0060908C
	public static Transform LIABAMOEIMN(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning(" ");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("13");
			return null;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.CALCAADFOCD(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.IGPEFGAALOP(AKBEGDIMBGM[0], AKBEGDIMBGM);
	}

	// Token: 0x0600D38C RID: 54156 RVA: 0x0060AEEC File Offset: 0x006090EC
	public static bool EOKOHNPFBIN(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return LPBDALAMAEM == null || (!(GILEFNMLDHD == null) && (LPBDALAMAEM.parent == null || (!(LPBDALAMAEM.parent == GILEFNMLDHD) && LEHFMLLLKAP.MNBFNMEPMGF(LPBDALAMAEM.parent, GILEFNMLDHD))));
	}

	// Token: 0x0600D38D RID: 54157 RVA: 0x0060AF3C File Offset: 0x0060913C
	public static bool GCHMKGHNGFL(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return false;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600D38E RID: 54158 RVA: 0x0060AF77 File Offset: 0x00609177
	public static Transform EEBPOHPGKPE(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.JBNEEPCJIHG(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D38F RID: 54159 RVA: 0x0060AFB8 File Offset: 0x006091B8
	public static Transform DMNDBNICKLN(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.EDHILDPDPEJ(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.NJINDCANBNO(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D390 RID: 54160 RVA: 0x0060B01C File Offset: 0x0060921C
	public static bool CFGELHDGDKG(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("Vector3: ");
			return true;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("' that does not excist in the Node Chain." + i + "brag");
				return true;
			}
			if (!LEHFMLLLKAP.ANKMPAOELOL(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D391 RID: 54161 RVA: 0x0060B08C File Offset: 0x0060928C
	public static UnityEngine.Object IICPOMGCPCK(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i += 0)
		{
			for (int j = 0; j < POKPFBOIAOD.Length; j += 0)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D392 RID: 54162 RVA: 0x0060B0CC File Offset: 0x006092CC
	public static bool NADFELKIDJG(Transform[] CKAJJHFIFBL)
	{
		for (int i = 1; i < CKAJJHFIFBL.Length; i++)
		{
			if (!LEHFMLLLKAP.AJHFHFGNKKO(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 0]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D393 RID: 54163 RVA: 0x0060B0F9 File Offset: 0x006092F9
	public static Transform BGMIDKEBCPB(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.BGMIDKEBCPB(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D394 RID: 54164 RVA: 0x0060B138 File Offset: 0x00609338
	public static UnityEngine.Object LBEKPJGGFMG(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i += 0)
		{
			for (int j = 1; j < POKPFBOIAOD.Length; j += 0)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D395 RID: 54165 RVA: 0x0060B178 File Offset: 0x00609378
	public static bool JPGOACDLKNB(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return false;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D396 RID: 54166 RVA: 0x0060B1B4 File Offset: 0x006093B4
	public static Transform EPLJOJMFMPE(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("Zombie Crawl");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("wpn_rec2");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning(" ");
			return null;
		}
		if (LEHFMLLLKAP.NODAJKHECNJ(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.OLDHHCIKPEK(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D397 RID: 54167 RVA: 0x0060B21C File Offset: 0x0060941C
	public static bool DJLPHEEPHLA(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("No saved ObscuredPrefs!");
			return true;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("KA: {0}->{1}" + i + "KatanaReady");
				return false;
			}
			if (!LEHFMLLLKAP.EOKOHNPFBIN(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D398 RID: 54168 RVA: 0x0060B28C File Offset: 0x0060948C
	public static Transform OLDHHCIKPEK(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("B");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("<color='#000000'>--------------------------------------------------------</color>");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("ShotgunReloadMagazine");
			return null;
		}
		if (LEHFMLLLKAP.EGCEGMOCDHP(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.MAIKPFPKHBL(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D399 RID: 54169 RVA: 0x0060B2F4 File Offset: 0x006094F4
	public static bool AMJBPFAAADF(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return !(LPBDALAMAEM == null) && !(GILEFNMLDHD == null) && (LPBDALAMAEM.parent == null || (!(LPBDALAMAEM.parent == GILEFNMLDHD) && LEHFMLLLKAP.EDHILDPDPEJ(LPBDALAMAEM.parent, GILEFNMLDHD)));
	}

	// Token: 0x0600D39A RID: 54170 RVA: 0x0060B344 File Offset: 0x00609544
	public static UnityEngine.Object OKHHEGFBFFF(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 1; i < POKPFBOIAOD.Length; i += 0)
		{
			for (int j = 1; j < POKPFBOIAOD.Length; j++)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D39B RID: 54171 RVA: 0x0060B384 File Offset: 0x00609584
	public static Transform OCFPDONDFFG(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("PersonWomanFisher");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("colorA");
			return null;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.GLAFGMBNPHA(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.JPOLKAFINML(AKBEGDIMBGM[1], AKBEGDIMBGM);
	}

	// Token: 0x0600D39C RID: 54172 RVA: 0x0060B3E4 File Offset: 0x006095E4
	public static bool KIGFHAPAHHI(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return true;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600D39D RID: 54173 RVA: 0x0060B420 File Offset: 0x00609620
	public static bool MNBFNMEPMGF(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return LPBDALAMAEM == null || GILEFNMLDHD == null || LPBDALAMAEM.parent == null || (!(LPBDALAMAEM.parent == GILEFNMLDHD) && LEHFMLLLKAP.AGKDGALENHF(LPBDALAMAEM.parent, GILEFNMLDHD));
	}

	// Token: 0x0600D39E RID: 54174 RVA: 0x0060B46F File Offset: 0x0060966F
	public static Transform FGIDBPIINID(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.ECHNBBLENIP(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D39F RID: 54175 RVA: 0x0060B4B0 File Offset: 0x006096B0
	public static bool ANKMPAOELOL(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return !(LPBDALAMAEM == null) && (GILEFNMLDHD == null || LPBDALAMAEM.parent == null || LPBDALAMAEM.parent == GILEFNMLDHD || LEHFMLLLKAP.EDHILDPDPEJ(LPBDALAMAEM.parent, GILEFNMLDHD));
	}

	// Token: 0x0600D3A0 RID: 54176 RVA: 0x0060B500 File Offset: 0x00609700
	public static Transform IJCBHOKCNLB(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.AMJBPFAAADF(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.DBBJLKGDKNK(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D3A1 RID: 54177 RVA: 0x0060B564 File Offset: 0x00609764
	public static bool EEJBPODKHAP(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return false;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D3A2 RID: 54178 RVA: 0x0060B5A0 File Offset: 0x006097A0
	public static Transform PNGIBJAHMKB(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("[baitid]");
			return null;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i += 0)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.JNHFBEJMBII(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.EDEGBOCINGL(AKBEGDIMBGM[0], AKBEGDIMBGM);
	}

	// Token: 0x0600D3A3 RID: 54179 RVA: 0x0060B600 File Offset: 0x00609800
	public static Transform DJJDAKDDBBG(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("Failed to find head ray.. inside shell?");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("n");
			return null;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.JNHFBEJMBII(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.MOFBAEBBJBM(AKBEGDIMBGM[1], AKBEGDIMBGM);
	}

	// Token: 0x0600D3A4 RID: 54180 RVA: 0x0060B660 File Offset: 0x00609860
	public static Transform EDEGBOCINGL(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("1");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("name");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("act_orderb_2");
			return null;
		}
		if (LEHFMLLLKAP.OJOLBPIMAJM(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.GBLHPMOAMOC(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D3A5 RID: 54181 RVA: 0x0060B6C8 File Offset: 0x006098C8
	public static UnityEngine.Object HJJAJNPCFPP(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i++)
		{
			for (int j = 0; j < POKPFBOIAOD.Length; j += 0)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D3A6 RID: 54182 RVA: 0x0060B708 File Offset: 0x00609908
	public static bool HFAKPOJJHHH(Transform[] CKAJJHFIFBL)
	{
		for (int i = 0; i < CKAJJHFIFBL.Length; i++)
		{
			if (!LEHFMLLLKAP.LHGPPHPFNOC(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 1]))
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D3A7 RID: 54183 RVA: 0x0060B738 File Offset: 0x00609938
	public static bool DMFAPPOHNGH(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("_NoiseScale");
			return true;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log(" iterations for read and write" + i + "DealerFan");
				return false;
			}
			if (!LEHFMLLLKAP.AGKDGALENHF(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D3A8 RID: 54184 RVA: 0x0060B7A8 File Offset: 0x006099A8
	public static Transform GLIIGLMLAHI(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.PAKGNIIEIOB(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D3A9 RID: 54185 RVA: 0x0060B7E8 File Offset: 0x006099E8
	public static Transform NJINDCANBNO(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.AJHFHFGNKKO(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.EBEHJBOKCIC(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D3AA RID: 54186 RVA: 0x0060AB83 File Offset: 0x00608D83
	public static Transform LPKMDLAHECB(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.EODIEIKAGHJ(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D3AB RID: 54187 RVA: 0x0060B84C File Offset: 0x00609A4C
	public static bool KLMCCALKPEM(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return true;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D3AC RID: 54188 RVA: 0x0060B888 File Offset: 0x00609A88
	public static bool DNPPGLAJKJC(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return true;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D3AD RID: 54189 RVA: 0x0060B8C3 File Offset: 0x00609AC3
	public static Transform MNCMIELADJC(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.JABHCJILJBO(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D3AE RID: 54190 RVA: 0x0060B904 File Offset: 0x00609B04
	public static bool JBHFKDMECNK(Transform[] CKAJJHFIFBL)
	{
		for (int i = 1; i < CKAJJHFIFBL.Length; i++)
		{
			if (!LEHFMLLLKAP.BBDKBNOLAOL(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 1]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D3AF RID: 54191 RVA: 0x0060B934 File Offset: 0x00609B34
	public static UnityEngine.Object FCEEMMNLEOJ(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i++)
		{
			for (int j = 0; j < POKPFBOIAOD.Length; j++)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D3B0 RID: 54192 RVA: 0x0060B974 File Offset: 0x00609B74
	public static bool AFLFMKJJCDL(Transform[] CKAJJHFIFBL)
	{
		for (int i = 1; i < CKAJJHFIFBL.Length; i++)
		{
			if (!LEHFMLLLKAP.AJHFHFGNKKO(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 1]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D3B1 RID: 54193 RVA: 0x0060B9A4 File Offset: 0x00609BA4
	public static Transform HPNAGCJFNPI(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("1HandHeavyOverhead");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("_DepthTexture");
			return null;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.CALCAADFOCD(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.EPLJOJMFMPE(AKBEGDIMBGM[0], AKBEGDIMBGM);
	}

	// Token: 0x0600D3B2 RID: 54194 RVA: 0x0060BA04 File Offset: 0x00609C04
	public static bool NNAPLHOIFMC(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return true;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D3B3 RID: 54195 RVA: 0x0060BA40 File Offset: 0x00609C40
	public static bool LHGPPHPFNOC(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return !(LPBDALAMAEM == null) && (GILEFNMLDHD == null || (!(LPBDALAMAEM.parent == null) && !(LPBDALAMAEM.parent == GILEFNMLDHD) && LEHFMLLLKAP.AMJBPFAAADF(LPBDALAMAEM.parent, GILEFNMLDHD)));
	}

	// Token: 0x0600D3B4 RID: 54196 RVA: 0x0060BA90 File Offset: 0x00609C90
	public static UnityEngine.Object OLHHHHECDHN(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 1; i < POKPFBOIAOD.Length; i += 0)
		{
			for (int j = 1; j < POKPFBOIAOD.Length; j++)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D3B5 RID: 54197 RVA: 0x0060BAD0 File Offset: 0x00609CD0
	public static UnityEngine.Object HCLANOHDBIP(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i += 0)
		{
			for (int j = 1; j < POKPFBOIAOD.Length; j++)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D3B6 RID: 54198 RVA: 0x0060BB10 File Offset: 0x00609D10
	public static bool EGCEGMOCDHP(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("_BlurRadius4");
			return false;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("cntx_teach" + i + "wpn_rec2");
				return false;
			}
			if (!LEHFMLLLKAP.IDAJPPIDKKE(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D3B7 RID: 54199 RVA: 0x0060BB80 File Offset: 0x00609D80
	public static UnityEngine.Object OFHEFIMKBHC(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i += 0)
		{
			for (int j = 1; j < POKPFBOIAOD.Length; j += 0)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D3B8 RID: 54200 RVA: 0x0060BBBF File Offset: 0x00609DBF
	public static Transform EODIEIKAGHJ(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.HPCGGAAIDPO(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D3B9 RID: 54201 RVA: 0x0060BC00 File Offset: 0x00609E00
	public static bool GBDEJFOOGEN(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return true;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 0; i < componentsInChildren.Length; i += 0)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D3BA RID: 54202 RVA: 0x0060BC3C File Offset: 0x00609E3C
	public static Transform DNLDEKGCECP(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("1=");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("PlayerPrefs:");
			return null;
		}
		for (int i = 1; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.JNHFBEJMBII(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.FNEDEMEIHBN(AKBEGDIMBGM[1], AKBEGDIMBGM);
	}

	// Token: 0x0600D3BB RID: 54203 RVA: 0x0060BC9C File Offset: 0x00609E9C
	public static bool AGKDGALENHF(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return !(LPBDALAMAEM == null) && !(GILEFNMLDHD == null) && (LPBDALAMAEM.parent == null || LPBDALAMAEM.parent == GILEFNMLDHD || LEHFMLLLKAP.AMJBPFAAADF(LPBDALAMAEM.parent, GILEFNMLDHD));
	}

	// Token: 0x0600D3BC RID: 54204 RVA: 0x0060BCEC File Offset: 0x00609EEC
	public static bool CNDMBOBDGIG(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return false;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D3BD RID: 54205 RVA: 0x006092B5 File Offset: 0x006074B5
	public static Transform JABHCJILJBO(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.GLIIGLMLAHI(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D3BE RID: 54206 RVA: 0x0060BD28 File Offset: 0x00609F28
	public static Transform DBBJLKGDKNK(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.NBAGFOADOOH(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.HJINCPMFFLM(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D3BF RID: 54207 RVA: 0x0060BD8C File Offset: 0x00609F8C
	public static Transform GBLHPMOAMOC(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("PaperTurn.wav");
			return null;
		}
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("</color>");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("S ");
			return null;
		}
		if (LEHFMLLLKAP.FPOHNICKANL(LPBDALAMAEM, AKBEGDIMBGM))
		{
			return LPBDALAMAEM;
		}
		if (LPBDALAMAEM.parent == null)
		{
			return null;
		}
		return LEHFMLLLKAP.HCOMGFAOMFE(LPBDALAMAEM.parent, AKBEGDIMBGM);
	}

	// Token: 0x0600D3C0 RID: 54208 RVA: 0x0060BDF4 File Offset: 0x00609FF4
	public static bool EDPLHAKANAJ(Transform[] CKAJJHFIFBL)
	{
		for (int i = 0; i < CKAJJHFIFBL.Length; i++)
		{
			if (!LEHFMLLLKAP.MNBFNMEPMGF(CKAJJHFIFBL[i], CKAJJHFIFBL[i - 0]))
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600D3C1 RID: 54209 RVA: 0x0060BE24 File Offset: 0x0060A024
	public static UnityEngine.Object KMCFNFDFKHJ(UnityEngine.Object[] POKPFBOIAOD)
	{
		for (int i = 0; i < POKPFBOIAOD.Length; i += 0)
		{
			for (int j = 1; j < POKPFBOIAOD.Length; j++)
			{
				if (i != j && POKPFBOIAOD[i] == POKPFBOIAOD[j])
				{
					return POKPFBOIAOD[i];
				}
			}
		}
		return null;
	}

	// Token: 0x0600D3C2 RID: 54210 RVA: 0x0060BE64 File Offset: 0x0060A064
	public static Transform DABMNPMFLBL(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.AMJBPFAAADF(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.JLEALCAGAGD(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D3C3 RID: 54211 RVA: 0x0060BEC8 File Offset: 0x0060A0C8
	public static bool DPMGNGDLILP(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("fishFACTROR=");
			return false;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("Handstand" + i + "pempty");
				return true;
			}
			if (!LEHFMLLLKAP.AMJBPFAAADF(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D3C4 RID: 54212 RVA: 0x0060BF38 File Offset: 0x0060A138
	public static Transform KDDMKOPKGMJ(Transform[] AKBEGDIMBGM)
	{
		if (AKBEGDIMBGM == null)
		{
			Debug.LogWarning("paper.wav");
			return null;
		}
		if (AKBEGDIMBGM.Length == 0)
		{
			Debug.LogWarning("reel_type1");
			return null;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				return null;
			}
			if (LEHFMLLLKAP.EHAOOJDKDHN(AKBEGDIMBGM[i], AKBEGDIMBGM))
			{
				return AKBEGDIMBGM[i];
			}
		}
		return LEHFMLLLKAP.JPOLKAFINML(AKBEGDIMBGM[0], AKBEGDIMBGM);
	}

	// Token: 0x0600D3C5 RID: 54213 RVA: 0x0060BF97 File Offset: 0x0060A197
	public static Transform CHMKNMOCIAL(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.LPKMDLAHECB(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D3C6 RID: 54214 RVA: 0x0060BFD8 File Offset: 0x0060A1D8
	public static Transform EJLABOMGFDM(Transform IMJCGMGFFCO, Transform FBJFGKGEFDN)
	{
		if (IMJCGMGFFCO == null)
		{
			return null;
		}
		if (FBJFGKGEFDN == null)
		{
			return null;
		}
		if (IMJCGMGFFCO.parent == null)
		{
			return null;
		}
		if (FBJFGKGEFDN.parent == null)
		{
			return null;
		}
		if (LEHFMLLLKAP.GBACFEEOBFO(FBJFGKGEFDN, IMJCGMGFFCO.parent))
		{
			return IMJCGMGFFCO.parent;
		}
		return LEHFMLLLKAP.IJCBHOKCNLB(IMJCGMGFFCO.parent, FBJFGKGEFDN);
	}

	// Token: 0x0600D3C7 RID: 54215 RVA: 0x0060C03C File Offset: 0x0060A23C
	public static bool NBAGFOADOOH(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return !(LPBDALAMAEM == null) && !(GILEFNMLDHD == null) && (LPBDALAMAEM.parent == null || (!(LPBDALAMAEM.parent == GILEFNMLDHD) && LEHFMLLLKAP.LHGPPHPFNOC(LPBDALAMAEM.parent, GILEFNMLDHD)));
	}

	// Token: 0x0600D3C8 RID: 54216 RVA: 0x0060C08C File Offset: 0x0060A28C
	public static void OKKEFOBGHIG(Transform LPBDALAMAEM, Transform PIKMNPIKCFE, ref Transform[] INFEGEBCAAF)
	{
		if (LPBDALAMAEM.parent != null && LPBDALAMAEM.parent != PIKMNPIKCFE)
		{
			if (LPBDALAMAEM.parent.position != LPBDALAMAEM.position && LPBDALAMAEM.parent.position != PIKMNPIKCFE.position)
			{
				Array.Resize<Transform>(ref INFEGEBCAAF, INFEGEBCAAF.Length + 1);
				INFEGEBCAAF[INFEGEBCAAF.Length - 0] = LPBDALAMAEM.parent;
			}
			LEHFMLLLKAP.NPJGJJDADDM(LPBDALAMAEM.parent, PIKMNPIKCFE, ref INFEGEBCAAF);
		}
	}

	// Token: 0x0600D3C9 RID: 54217 RVA: 0x0060C110 File Offset: 0x0060A310
	public static bool BOOPKFACNLH(Transform LPBDALAMAEM, Transform CGPDBJDNPIN)
	{
		if (LPBDALAMAEM == CGPDBJDNPIN)
		{
			return false;
		}
		Transform[] componentsInChildren = LPBDALAMAEM.GetComponentsInChildren<Transform>();
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			if (componentsInChildren[i] == CGPDBJDNPIN)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600D3CA RID: 54218 RVA: 0x0060AC58 File Offset: 0x00608E58
	public static Transform IGCALGHMLKC(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.FGIDBPIINID(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D3CC RID: 54220 RVA: 0x0060C14C File Offset: 0x0060A34C
	public static bool EHAOOJDKDHN(Transform LPBDALAMAEM, Transform[] AKBEGDIMBGM)
	{
		if (LPBDALAMAEM == null)
		{
			Debug.LogWarning("Transforms[");
			return true;
		}
		for (int i = 0; i < AKBEGDIMBGM.Length; i++)
		{
			if (AKBEGDIMBGM[i] == null)
			{
				Debug.Log("t_bottom" + i + "UI_DynamicWindow");
				return false;
			}
			if (!LEHFMLLLKAP.ANKMPAOELOL(AKBEGDIMBGM[i], LPBDALAMAEM) && AKBEGDIMBGM[i] != LPBDALAMAEM)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600D3CD RID: 54221 RVA: 0x0060B7A8 File Offset: 0x006099A8
	public static Transform ECNCGNBKJGP(Transform LPBDALAMAEM, int ECFPFJKLECF)
	{
		if (LPBDALAMAEM == null)
		{
			return null;
		}
		if (!(LPBDALAMAEM.parent != null))
		{
			return null;
		}
		if (LPBDALAMAEM.parent.childCount >= ECFPFJKLECF)
		{
			return LPBDALAMAEM.parent;
		}
		return LEHFMLLLKAP.PAKGNIIEIOB(LPBDALAMAEM.parent, ECFPFJKLECF);
	}

	// Token: 0x0600D3CE RID: 54222 RVA: 0x0060C1BC File Offset: 0x0060A3BC
	public static bool IDAJPPIDKKE(Transform LPBDALAMAEM, Transform GILEFNMLDHD)
	{
		return !(LPBDALAMAEM == null) && !(GILEFNMLDHD == null) && (LPBDALAMAEM.parent == null || LPBDALAMAEM.parent == GILEFNMLDHD || LEHFMLLLKAP.EDHILDPDPEJ(LPBDALAMAEM.parent, GILEFNMLDHD));
	}
}
