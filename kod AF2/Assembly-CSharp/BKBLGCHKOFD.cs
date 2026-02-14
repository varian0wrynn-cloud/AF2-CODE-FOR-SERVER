using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x0200039B RID: 923
public abstract class BKBLGCHKOFD
{
	// Token: 0x170002D1 RID: 721
	// (get) Token: 0x0600C6A5 RID: 50853 RVA: 0x00592C5D File Offset: 0x00590E5D
	// (set) Token: 0x0600C6A6 RID: 50854 RVA: 0x00592C65 File Offset: 0x00590E65
	public Vector3 DDEPECKGGLE { get; private set; }

	// Token: 0x0600C6A7 RID: 50855 RVA: 0x00592C6E File Offset: 0x00590E6E
	public bool CICNHOLEAPA(string BNIHFBMEPAB)
	{
		return this.HIGEEEKGGLM.ContainsKey(BNIHFBMEPAB);
	}

	// Token: 0x0600C6A8 RID: 50856 RVA: 0x00592C7C File Offset: 0x00590E7C
	public bool BJDJHNHKLHE(string BNIHFBMEPAB)
	{
		return this.IBAPHCEANFO.ContainsKey(BNIHFBMEPAB);
	}

	// Token: 0x0600C6A9 RID: 50857 RVA: 0x00592C8C File Offset: 0x00590E8C
	public void DNDFOKKIBGB(CELBHNONENJ.FANBIHFODMJ HNANBJENIHC)
	{
		if (this.HIGEEEKGGLM.ContainsKey(HNANBJENIHC.BNIHFBMEPAB))
		{
			Debug.LogError("There is already a virtual axis named " + HNANBJENIHC.BNIHFBMEPAB + " registered.");
			return;
		}
		this.HIGEEEKGGLM.Add(HNANBJENIHC.BNIHFBMEPAB, HNANBJENIHC);
		if (!HNANBJENIHC.JONOPJLINNH)
		{
			this.PDOBAMGNPNI.Add(HNANBJENIHC.BNIHFBMEPAB);
		}
	}

	// Token: 0x0600C6AA RID: 50858 RVA: 0x00592CF4 File Offset: 0x00590EF4
	public void KAKMIFKHIIG(CELBHNONENJ.BFJKDNCHBGB HJDAHKKMDFC)
	{
		if (this.IBAPHCEANFO.ContainsKey(HJDAHKKMDFC.BNIHFBMEPAB))
		{
			Debug.LogError("There is already a virtual button named " + HJDAHKKMDFC.BNIHFBMEPAB + " registered.");
			return;
		}
		this.IBAPHCEANFO.Add(HJDAHKKMDFC.BNIHFBMEPAB, HJDAHKKMDFC);
		if (!HJDAHKKMDFC.JONOPJLINNH)
		{
			this.PDOBAMGNPNI.Add(HJDAHKKMDFC.BNIHFBMEPAB);
		}
	}

	// Token: 0x0600C6AB RID: 50859 RVA: 0x00592D5A File Offset: 0x00590F5A
	public void PNDBFJCDJDN(string BNIHFBMEPAB)
	{
		if (this.HIGEEEKGGLM.ContainsKey(BNIHFBMEPAB))
		{
			this.HIGEEEKGGLM.Remove(BNIHFBMEPAB);
		}
	}

	// Token: 0x0600C6AC RID: 50860 RVA: 0x00592D77 File Offset: 0x00590F77
	public void OPNENFKCBCO(string BNIHFBMEPAB)
	{
		if (this.IBAPHCEANFO.ContainsKey(BNIHFBMEPAB))
		{
			this.IBAPHCEANFO.Remove(BNIHFBMEPAB);
		}
	}

	// Token: 0x0600C6AD RID: 50861 RVA: 0x00592D94 File Offset: 0x00590F94
	public CELBHNONENJ.FANBIHFODMJ APBAGEPLCKO(string BNIHFBMEPAB)
	{
		if (!this.HIGEEEKGGLM.ContainsKey(BNIHFBMEPAB))
		{
			return null;
		}
		return this.HIGEEEKGGLM[BNIHFBMEPAB];
	}

	// Token: 0x0600C6AE RID: 50862 RVA: 0x00592DB2 File Offset: 0x00590FB2
	public void NHGIAHDGFIH(float CCAIMGAFFLD)
	{
		this.DDEPECKGGLE = new Vector3(CCAIMGAFFLD, this.DDEPECKGGLE.y, this.DDEPECKGGLE.z);
	}

	// Token: 0x0600C6AF RID: 50863 RVA: 0x00592DD6 File Offset: 0x00590FD6
	public void LAJNAAKNJCD(float CCAIMGAFFLD)
	{
		this.DDEPECKGGLE = new Vector3(this.DDEPECKGGLE.x, CCAIMGAFFLD, this.DDEPECKGGLE.z);
	}

	// Token: 0x0600C6B0 RID: 50864 RVA: 0x00592DFA File Offset: 0x00590FFA
	public void IMKLIHIGAEG(float CCAIMGAFFLD)
	{
		this.DDEPECKGGLE = new Vector3(this.DDEPECKGGLE.x, this.DDEPECKGGLE.y, CCAIMGAFFLD);
	}

	// Token: 0x0600C6B1 RID: 50865
	public abstract float LBBLPMHONLE(string BNIHFBMEPAB, bool ILMDICONFLO);

	// Token: 0x0600C6B2 RID: 50866
	public abstract bool LHOPDFALGAJ(string BNIHFBMEPAB);

	// Token: 0x0600C6B3 RID: 50867
	public abstract bool LEPAIPLBDGL(string BNIHFBMEPAB);

	// Token: 0x0600C6B4 RID: 50868
	public abstract bool PEPBJFHKAIF(string BNIHFBMEPAB);

	// Token: 0x0600C6B5 RID: 50869
	public abstract void NEHLDDLKLHL(string BNIHFBMEPAB);

	// Token: 0x0600C6B6 RID: 50870
	public abstract void EIFHGIPADDP(string BNIHFBMEPAB);

	// Token: 0x0600C6B7 RID: 50871
	public abstract void AOBGPFADGCO(string BNIHFBMEPAB);

	// Token: 0x0600C6B8 RID: 50872
	public abstract void MBDOJGHECPA(string BNIHFBMEPAB);

	// Token: 0x0600C6B9 RID: 50873
	public abstract void GIPLKEIMOCA(string BNIHFBMEPAB);

	// Token: 0x0600C6BA RID: 50874
	public abstract void BCDBFEOPNJG(string BNIHFBMEPAB, float DCCPCBLODIG);

	// Token: 0x0600C6BB RID: 50875
	public abstract Vector3 JADOJCHGEIE();

	// Token: 0x04001A79 RID: 6777
	protected Dictionary<string, CELBHNONENJ.FANBIHFODMJ> HIGEEEKGGLM = new Dictionary<string, CELBHNONENJ.FANBIHFODMJ>();

	// Token: 0x04001A7A RID: 6778
	protected Dictionary<string, CELBHNONENJ.BFJKDNCHBGB> IBAPHCEANFO = new Dictionary<string, CELBHNONENJ.BFJKDNCHBGB>();

	// Token: 0x04001A7B RID: 6779
	protected List<string> PDOBAMGNPNI = new List<string>();
}
