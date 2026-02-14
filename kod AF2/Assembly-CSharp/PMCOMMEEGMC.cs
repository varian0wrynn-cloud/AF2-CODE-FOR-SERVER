using System;
using UnityEngine;

// Token: 0x020003DC RID: 988
public static class PMCOMMEEGMC
{
	// Token: 0x0600D4C1 RID: 54465 RVA: 0x0060F7B0 File Offset: 0x0060D9B0
	public static void ICAFGKHAAED(string EDAPHMJENPK, PMCOMMEEGMC.EMMJAKHFDGM MEAMDIPGFMG, bool ADFCKBJMKHK = false)
	{
		if (!ADFCKBJMKHK && !Application.isPlaying)
		{
			return;
		}
		if (PMCOMMEEGMC.HAAICNHEMMK)
		{
			return;
		}
		if (MEAMDIPGFMG != null)
		{
			MEAMDIPGFMG(EDAPHMJENPK);
		}
		PMCOMMEEGMC.HAAICNHEMMK = true;
	}

	// Token: 0x0600D4C2 RID: 54466 RVA: 0x0060F7D5 File Offset: 0x0060D9D5
	public static void ICAFGKHAAED(string EDAPHMJENPK, Transform AMCOGJHPPOC, bool ADFCKBJMKHK = false)
	{
		if (!ADFCKBJMKHK && !Application.isPlaying)
		{
			return;
		}
		if (PMCOMMEEGMC.HAAICNHEMMK)
		{
			return;
		}
		Debug.LogWarning(EDAPHMJENPK, AMCOGJHPPOC);
		PMCOMMEEGMC.HAAICNHEMMK = true;
	}

	// Token: 0x04001C26 RID: 7206
	public static bool HAAICNHEMMK;

	// Token: 0x020003DD RID: 989
	// (Invoke) Token: 0x0600D4C4 RID: 54468
	public delegate void EMMJAKHFDGM(string EDAPHMJENPK);
}
