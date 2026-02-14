using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020003D7 RID: 983
public static class ABNOLHMCNFK
{
	// Token: 0x0600D440 RID: 54336 RVA: 0x0060E4BA File Offset: 0x0060C6BA
	public static bool EHJLMMFMAKO(LayerMask CBFFOOKAIAK, int LJFPELOCKOH)
	{
		return CBFFOOKAIAK == (CBFFOOKAIAK | 1 << LJFPELOCKOH);
	}

	// Token: 0x0600D441 RID: 54337 RVA: 0x0060E4D1 File Offset: 0x0060C6D1
	public static LayerMask KKOCOBIBMEL(params string[] AOBMHDGCJKK)
	{
		return ABNOLHMCNFK.BDEAHINIBDC(AOBMHDGCJKK);
	}

	// Token: 0x0600D442 RID: 54338 RVA: 0x0060E4D9 File Offset: 0x0060C6D9
	public static LayerMask KKOCOBIBMEL(params int[] CKEBPIPJLNB)
	{
		return ABNOLHMCNFK.OLCALEMEOPG(CKEBPIPJLNB);
	}

	// Token: 0x0600D443 RID: 54339 RVA: 0x0060E4E4 File Offset: 0x0060C6E4
	public static LayerMask BDEAHINIBDC(params string[] AOBMHDGCJKK)
	{
		LayerMask layerMask = 0;
		foreach (string layerName in AOBMHDGCJKK)
		{
			layerMask |= 1 << LayerMask.NameToLayer(layerName);
		}
		return layerMask;
	}

	// Token: 0x0600D444 RID: 54340 RVA: 0x0060E528 File Offset: 0x0060C728
	public static LayerMask OLCALEMEOPG(params int[] CKEBPIPJLNB)
	{
		LayerMask layerMask = 0;
		foreach (int num in CKEBPIPJLNB)
		{
			layerMask |= 1 << num;
		}
		return layerMask;
	}

	// Token: 0x0600D445 RID: 54341 RVA: 0x0060E564 File Offset: 0x0060C764
	public static LayerMask IDIBPCFDEIC(this LayerMask GNLKOIAIBNH)
	{
		return ~GNLKOIAIBNH;
	}

	// Token: 0x0600D446 RID: 54342 RVA: 0x0060E572 File Offset: 0x0060C772
	public static LayerMask OHOIPEFFMJP(this LayerMask GNLKOIAIBNH, params string[] AOBMHDGCJKK)
	{
		return GNLKOIAIBNH | ABNOLHMCNFK.BDEAHINIBDC(AOBMHDGCJKK);
	}

	// Token: 0x0600D447 RID: 54343 RVA: 0x0060E58B File Offset: 0x0060C78B
	public static LayerMask GPHIFCLDJMG(this LayerMask GNLKOIAIBNH, params string[] AOBMHDGCJKK)
	{
		return ~(~GNLKOIAIBNH | ABNOLHMCNFK.BDEAHINIBDC(AOBMHDGCJKK));
	}

	// Token: 0x0600D448 RID: 54344 RVA: 0x0060E5B0 File Offset: 0x0060C7B0
	public static string[] KMLMGEKNGLI(this LayerMask GNLKOIAIBNH)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < 32; i++)
		{
			int num = 1 << i;
			if ((GNLKOIAIBNH & num) == num)
			{
				string text = LayerMask.LayerToName(i);
				if (!string.IsNullOrEmpty(text))
				{
					list.Add(text);
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600D449 RID: 54345 RVA: 0x0060E600 File Offset: 0x0060C800
	public static int[] OFNGEGGLNGH(this LayerMask GNLKOIAIBNH)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < 32; i++)
		{
			int num = 1 << i;
			if ((GNLKOIAIBNH & num) == num)
			{
				list.Add(i);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600D44A RID: 54346 RVA: 0x0060E63F File Offset: 0x0060C83F
	public static string JJKBIAJEHKC(this LayerMask GNLKOIAIBNH)
	{
		return GNLKOIAIBNH.JJKBIAJEHKC(", ");
	}

	// Token: 0x0600D44B RID: 54347 RVA: 0x0060E64C File Offset: 0x0060C84C
	public static string JJKBIAJEHKC(this LayerMask GNLKOIAIBNH, string IJKIHEGEHFB)
	{
		return string.Join(IJKIHEGEHFB, GNLKOIAIBNH.KMLMGEKNGLI());
	}
}
