using System;
using System.Collections.Generic;
using System.Text;
using ProCore.Decals;
using UnityEngine;

// Token: 0x020004D2 RID: 1234
public static class LOKONCPEENH
{
	// Token: 0x06010CD6 RID: 68822 RVA: 0x0077D1D4 File Offset: 0x0077B3D4
	public static GameObject[] GPNGKANKDMF(Texture2D GFHGONEHFNK)
	{
		List<GameObject> list = new List<GameObject>();
		foreach (qd_Decal qd_Decal in UnityEngine.Object.FindObjectsOfType(typeof(qd_Decal)))
		{
			if (qd_Decal.KEDGAOBCNJG == GFHGONEHFNK)
			{
				list.Add(qd_Decal.gameObject);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06010CD7 RID: 68823 RVA: 0x0077D230 File Offset: 0x0077B430
	public static void JFAMIGNEJHC(DecalGroup OPCJPLOPLLG)
	{
		if (!OPCJPLOPLLG.isPacked)
		{
			Debug.LogWarning("Attempting to RefreshSceneDecals without a packed material");
			return;
		}
		qd_Decal[] array = (qd_Decal[])UnityEngine.Object.FindObjectsOfType(typeof(qd_Decal));
		for (int i = 0; i < OPCJPLOPLLG.decals.Count; i++)
		{
			foreach (qd_Decal qd_Decal in array)
			{
				if (OPCJPLOPLLG.decals[i].texture == qd_Decal.KEDGAOBCNJG)
				{
					qd_Decal.GetComponent<MeshRenderer>().sharedMaterial = OPCJPLOPLLG.material;
					qd_Decal.SetUVRect(OPCJPLOPLLG.decals[i].atlasRect);
				}
			}
		}
	}

	// Token: 0x06010CD8 RID: 68824 RVA: 0x0077D2DC File Offset: 0x0077B4DC
	public static void BOGFEBPLOIM(ref List<Decal> AJDACCIAOKI, GCODPEEEHLM OLFHFAIHDHF)
	{
		List<Decal> list = new List<Decal>();
		foreach (Decal decal in AJDACCIAOKI)
		{
			int num = (OLFHFAIHDHF == GCODPEEEHLM.Organizational) ? decal.orgIndex : decal.atlasIndex;
			int num2 = list.Count;
			for (int i = list.Count - 1; i > -1; i--)
			{
				if (num < ((OLFHFAIHDHF == GCODPEEEHLM.Atlas) ? list[i].atlasIndex : list[i].orgIndex) && num < num2)
				{
					num2 = num;
				}
			}
			list.Insert(num2, decal);
		}
		AJDACCIAOKI = list;
	}

	// Token: 0x06010CD9 RID: 68825 RVA: 0x0077D394 File Offset: 0x0077B594
	public static bool EHJLMMFMAKO(this Dictionary<int, List<int>> IOCLPMBFPLH, int JMBKDINHDLO, int FEAGDHLLLOI)
	{
		return IOCLPMBFPLH.ContainsKey(JMBKDINHDLO) && IOCLPMBFPLH[JMBKDINHDLO].Contains(FEAGDHLLLOI);
	}

	// Token: 0x06010CDA RID: 68826 RVA: 0x0077D3B0 File Offset: 0x0077B5B0
	public static void HILNKECBANJ(this Dictionary<int, List<int>> IOCLPMBFPLH, int JMBKDINHDLO, int FEAGDHLLLOI)
	{
		if (JMBKDINHDLO < 0 || FEAGDHLLLOI < 0)
		{
			return;
		}
		if (IOCLPMBFPLH.ContainsKey(JMBKDINHDLO))
		{
			if (!IOCLPMBFPLH[JMBKDINHDLO].Contains(FEAGDHLLLOI))
			{
				IOCLPMBFPLH[JMBKDINHDLO].Add(FEAGDHLLLOI);
				return;
			}
		}
		else
		{
			IOCLPMBFPLH.Add(JMBKDINHDLO, new List<int>
			{
				FEAGDHLLLOI
			});
		}
	}

	// Token: 0x06010CDB RID: 68827 RVA: 0x0077D400 File Offset: 0x0077B600
	public static string KNKLDKBPBCM(this Dictionary<int, List<int>> IOCLPMBFPLH)
	{
		string text = "";
		foreach (KeyValuePair<int, List<int>> keyValuePair in IOCLPMBFPLH)
		{
			text = string.Concat(new object[]
			{
				text,
				keyValuePair.Key,
				" : ",
				keyValuePair.Value.KNKLDKBPBCM(", "),
				"\n"
			});
		}
		return text;
	}

	// Token: 0x06010CDC RID: 68828 RVA: 0x0077D494 File Offset: 0x0077B694
	public static string KNKLDKBPBCM<T>(this T[] JAHNHOCNJGM, string HPNLLOFFBCF)
	{
		if (JAHNHOCNJGM == null || JAHNHOCNJGM.Length < 1)
		{
			return "Empty Array.";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(JAHNHOCNJGM[0].ToString());
		for (int i = 1; i < JAHNHOCNJGM.Length; i++)
		{
			stringBuilder.Append(HPNLLOFFBCF + ((JAHNHOCNJGM[i] == null) ? "null" : JAHNHOCNJGM[i].ToString()));
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06010CDD RID: 68829 RVA: 0x0077D51B File Offset: 0x0077B71B
	public static string KNKLDKBPBCM<T>(this List<T> JAHNHOCNJGM, string HPNLLOFFBCF)
	{
		return JAHNHOCNJGM.ToArray().KNKLDKBPBCM(HPNLLOFFBCF);
	}
}
