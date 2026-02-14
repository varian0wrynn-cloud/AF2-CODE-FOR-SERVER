using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

// Token: 0x020005CE RID: 1486
public static class CPIFONKDAFJ
{
	// Token: 0x06013787 RID: 79751 RVA: 0x008567C8 File Offset: 0x008549C8
	public static void INHFGFEAENI(this Transform LPBDALAMAEM, float OCNGPCPMCPM)
	{
		if (LPBDALAMAEM == null)
		{
			return;
		}
		Vector3 position = LPBDALAMAEM.position;
		position.x = OCNGPCPMCPM;
		LPBDALAMAEM.position = position;
	}

	// Token: 0x06013788 RID: 79752 RVA: 0x008567F8 File Offset: 0x008549F8
	public static void HOLFAJCOIMC(this Transform LPBDALAMAEM, float ADMFAEOOOHD)
	{
		if (LPBDALAMAEM == null)
		{
			return;
		}
		Vector3 position = LPBDALAMAEM.position;
		position.y = ADMFAEOOOHD;
		LPBDALAMAEM.position = position;
	}

	// Token: 0x06013789 RID: 79753 RVA: 0x00856828 File Offset: 0x00854A28
	public static void HMNHPDJABFG(this Transform LPBDALAMAEM, float DOCOLPILEAF)
	{
		if (LPBDALAMAEM == null)
		{
			return;
		}
		Vector3 position = LPBDALAMAEM.position;
		position.z = DOCOLPILEAF;
		LPBDALAMAEM.position = position;
	}

	// Token: 0x0601378A RID: 79754 RVA: 0x00856858 File Offset: 0x00854A58
	public static void PKHAKKOBPOP(this Camera LBCHLCGOCOD, int LJFPELOCKOH)
	{
		LayerMask mask = LBCHLCGOCOD.cullingMask;
		if (mask == (mask | 1 >> LJFPELOCKOH))
		{
			mask += (int)Mathf.Pow(2f, (float)LJFPELOCKOH);
		}
		LBCHLCGOCOD.cullingMask = mask;
	}

	// Token: 0x0601378B RID: 79755 RVA: 0x008568AC File Offset: 0x00854AAC
	public static void EGOAOBFABBG(this Camera LBCHLCGOCOD, int LJFPELOCKOH)
	{
		LayerMask mask = LBCHLCGOCOD.cullingMask;
		if (mask == (mask | 1 << LJFPELOCKOH))
		{
			mask -= (int)Mathf.Pow(2f, (float)LJFPELOCKOH);
		}
		LBCHLCGOCOD.cullingMask = mask;
	}

	// Token: 0x0601378C RID: 79756 RVA: 0x00856900 File Offset: 0x00854B00
	public static void PKHAKKOBPOP(this Light PBMKOGEGDGG, int LJFPELOCKOH)
	{
		LayerMask mask = PBMKOGEGDGG.cullingMask;
		if (mask == (mask | 1 >> LJFPELOCKOH))
		{
			mask += (int)Mathf.Pow(2f, (float)LJFPELOCKOH);
		}
		PBMKOGEGDGG.cullingMask = mask;
	}

	// Token: 0x0601378D RID: 79757 RVA: 0x00856954 File Offset: 0x00854B54
	public static void EGOAOBFABBG(this Light PBMKOGEGDGG, int LJFPELOCKOH)
	{
		LayerMask mask = PBMKOGEGDGG.cullingMask;
		if (mask == (mask | 1 << LJFPELOCKOH))
		{
			mask -= (int)Mathf.Pow(2f, (float)LJFPELOCKOH);
		}
		PBMKOGEGDGG.cullingMask = mask;
	}

	// Token: 0x0601378E RID: 79758 RVA: 0x008569A8 File Offset: 0x00854BA8
	public static Color FAHEBPEFDPM(this Color LBCGACKJCJB, float CGFLAIMHHOO)
	{
		return new Color(LBCGACKJCJB.r, LBCGACKJCJB.g, LBCGACKJCJB.b, CGFLAIMHHOO);
	}

	// Token: 0x0601378F RID: 79759 RVA: 0x008569C2 File Offset: 0x00854BC2
	public static Color DJKNBNJHELH(this Color LBCGACKJCJB, float MALGCGGMBLD)
	{
		return new Color(MALGCGGMBLD, LBCGACKJCJB.g, LBCGACKJCJB.b, LBCGACKJCJB.a);
	}

	// Token: 0x06013790 RID: 79760 RVA: 0x008569DC File Offset: 0x00854BDC
	public static Color CDLKJFOFLGO(this Color LBCGACKJCJB, float FFKAEKMAKAM)
	{
		return new Color(LBCGACKJCJB.r, FFKAEKMAKAM, LBCGACKJCJB.b, LBCGACKJCJB.a);
	}

	// Token: 0x06013791 RID: 79761 RVA: 0x008569F6 File Offset: 0x00854BF6
	public static Color OPCECFKBACA(this Color LBCGACKJCJB, float DJGMLINPIFN)
	{
		return new Color(LBCGACKJCJB.r, LBCGACKJCJB.g, DJGMLINPIFN, LBCGACKJCJB.a);
	}

	// Token: 0x06013792 RID: 79762 RVA: 0x00856A10 File Offset: 0x00854C10
	public static string AIEMCFGNIIC(this string JKLOOEDHHJP)
	{
		return JKLOOEDHHJP.Remove(0, JKLOOEDHHJP.LastIndexOf(Path.DirectorySeparatorChar) + 1);
	}

	// Token: 0x06013793 RID: 79763 RVA: 0x00856A28 File Offset: 0x00854C28
	public static bool IBNDOMBBAIA(string ODFEKBJCFMN)
	{
		try
		{
			GameObject.FindGameObjectWithTag(ODFEKBJCFMN);
		}
		catch
		{
			return false;
		}
		return true;
	}

	// Token: 0x06013794 RID: 79764 RVA: 0x00856A58 File Offset: 0x00854C58
	public static List<GameObject> DMECFPKMLCC(this GameObject BNKBOICOODI, params string[] KEGBNGJBADP)
	{
		AntaresAddon[] array = UnityEngine.Object.FindObjectsOfType(typeof(AntaresAddon)) as AntaresAddon[];
		List<GameObject> list = new List<GameObject>();
		int num = array.Length;
		int num2 = KEGBNGJBADP.Length;
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				if (array[i].multitags.Contains(KEGBNGJBADP[j]) && !list.Contains(array[i].gameObject))
				{
					list.Add(array[i].gameObject);
				}
			}
		}
		return list;
	}

	// Token: 0x06013795 RID: 79765 RVA: 0x00856AE0 File Offset: 0x00854CE0
	public static List<GameObject> PEIFDFBFFMF(params string[] KEGBNGJBADP)
	{
		AntaresAddon[] array = UnityEngine.Object.FindObjectsOfType(typeof(AntaresAddon)) as AntaresAddon[];
		List<GameObject> list = new List<GameObject>();
		int num = array.Length;
		int num2 = KEGBNGJBADP.Length;
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				if (array[i].multitags.Contains(KEGBNGJBADP[j]) && !list.Contains(array[i].gameObject))
				{
					list.Add(array[i].gameObject);
				}
			}
		}
		return list;
	}

	// Token: 0x06013796 RID: 79766 RVA: 0x00856B68 File Offset: 0x00854D68
	public static bool GMMNLGJJINP(this GameObject BNKBOICOODI, string OFBPHKGNMFB)
	{
		AntaresAddon component = BNKBOICOODI.GetComponent<AntaresAddon>();
		return component != null && component.multitags.Contains(OFBPHKGNMFB);
	}

	// Token: 0x06013797 RID: 79767 RVA: 0x00856B94 File Offset: 0x00854D94
	public static bool GBIHDBHCPFP(this GameObject BNKBOICOODI, params string[] KEGBNGJBADP)
	{
		AntaresAddon component = BNKBOICOODI.GetComponent<AntaresAddon>();
		if (component == null)
		{
			return false;
		}
		int num = KEGBNGJBADP.Length;
		for (int i = 0; i < num; i++)
		{
			if (component.multitags.Contains(KEGBNGJBADP[i]))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06013798 RID: 79768 RVA: 0x00856BD8 File Offset: 0x00854DD8
	public static bool CICACMOGFJG(this GameObject BNKBOICOODI, params string[] KEGBNGJBADP)
	{
		AntaresAddon component = BNKBOICOODI.GetComponent<AntaresAddon>();
		if (component == null)
		{
			return false;
		}
		int num = KEGBNGJBADP.Length;
		for (int i = 0; i < num; i++)
		{
			if (!component.multitags.Contains(KEGBNGJBADP[i]))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06013799 RID: 79769 RVA: 0x00856C1C File Offset: 0x00854E1C
	public static int BKHFGJNBOOM(this GameObject BNKBOICOODI)
	{
		AntaresAddon component = BNKBOICOODI.GetComponent<AntaresAddon>();
		if (!(component != null))
		{
			return 0;
		}
		return component.multitags.Count;
	}

	// Token: 0x0601379A RID: 79770 RVA: 0x00856C48 File Offset: 0x00854E48
	public static void IEBEFBPHHMF(this GameObject BNKBOICOODI, params string[] KEGBNGJBADP)
	{
		AntaresAddon antaresAddon = BNKBOICOODI.GetComponent<AntaresAddon>();
		if (antaresAddon == null)
		{
			antaresAddon = BNKBOICOODI.AddComponent<AntaresAddon>();
		}
		int num = KEGBNGJBADP.Length;
		for (int i = 0; i < num; i++)
		{
			if (!antaresAddon.multitags.Contains(KEGBNGJBADP[i]))
			{
				antaresAddon.multitags.Add(KEGBNGJBADP[i]);
			}
		}
	}

	// Token: 0x0601379B RID: 79771 RVA: 0x00856C9C File Offset: 0x00854E9C
	public static void MEGAJIAKJJG(this GameObject BNKBOICOODI, params string[] KEGBNGJBADP)
	{
		AntaresAddon component = BNKBOICOODI.GetComponent<AntaresAddon>();
		if (component == null)
		{
			return;
		}
		int num = KEGBNGJBADP.Length;
		for (int i = 0; i < num; i++)
		{
			if (component.multitags.Contains(KEGBNGJBADP[i]))
			{
				component.multitags.Remove(KEGBNGJBADP[i]);
			}
		}
	}

	// Token: 0x0601379C RID: 79772 RVA: 0x00856CEC File Offset: 0x00854EEC
	public static void AAIDIOIPABC(this GameObject FCKIJKHNAEL, GameObject NGIDONLPFBH)
	{
		AntaresAddon component = FCKIJKHNAEL.GetComponent<AntaresAddon>();
		if (component == null)
		{
			return;
		}
		AntaresAddon antaresAddon = NGIDONLPFBH.GetComponent<AntaresAddon>();
		if (antaresAddon == null)
		{
			antaresAddon = NGIDONLPFBH.AddComponent<AntaresAddon>();
		}
		antaresAddon.multitags = new List<string>(component.multitags);
	}

	// Token: 0x0601379D RID: 79773 RVA: 0x00856D34 File Offset: 0x00854F34
	public static List<string> COMLEHBBOKB(this GameObject BNKBOICOODI)
	{
		AntaresAddon component = BNKBOICOODI.GetComponent<AntaresAddon>();
		if (!(component != null))
		{
			return new List<string>();
		}
		return component.multitags;
	}

	// Token: 0x0601379E RID: 79774 RVA: 0x00856D60 File Offset: 0x00854F60
	public static void FDCNOMOCECM(this GameObject BNKBOICOODI)
	{
		AntaresAddon component = BNKBOICOODI.GetComponent<AntaresAddon>();
		if (component == null)
		{
			return;
		}
		component.multitags.Clear();
	}
}
