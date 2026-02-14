using System;
using UnityEngine;

// Token: 0x020003CC RID: 972
public static class KAHEHOGJPBO
{
	// Token: 0x0600D22F RID: 53807 RVA: 0x00601E54 File Offset: 0x00600054
	public static Transform[] EEKDAKBDFIG(KAHEHOGJPBO.BoneType IGFPBEPIAEE, Transform[] CKAJJHFIFBL)
	{
		Transform[] array = new Transform[0];
		foreach (Transform transform in CKAJJHFIFBL)
		{
			if (transform != null && KAHEHOGJPBO.BLKLELCLNGM(transform.name) == IGFPBEPIAEE)
			{
				Array.Resize<Transform>(ref array, array.Length + 1);
				array[array.Length - 1] = transform;
			}
		}
		return array;
	}

	// Token: 0x0600D230 RID: 53808 RVA: 0x00601EA8 File Offset: 0x006000A8
	public static Transform[] CNHGDCDNAPA(KAHEHOGJPBO.BoneSide JIDFPDKKFND, Transform[] CKAJJHFIFBL)
	{
		Transform[] array = new Transform[0];
		foreach (Transform transform in CKAJJHFIFBL)
		{
			if (transform != null && KAHEHOGJPBO.MHPFNBCLDMI(transform.name) == JIDFPDKKFND)
			{
				Array.Resize<Transform>(ref array, array.Length + 1);
				array[array.Length - 1] = transform;
			}
		}
		return array;
	}

	// Token: 0x0600D231 RID: 53809 RVA: 0x00601EFC File Offset: 0x006000FC
	public static Transform[] JEFCNPHEJCO(KAHEHOGJPBO.BoneType IGFPBEPIAEE, KAHEHOGJPBO.BoneSide JIDFPDKKFND, Transform[] CKAJJHFIFBL)
	{
		Transform[] ckajjhfifbl = KAHEHOGJPBO.EEKDAKBDFIG(IGFPBEPIAEE, CKAJJHFIFBL);
		return KAHEHOGJPBO.CNHGDCDNAPA(JIDFPDKKFND, ckajjhfifbl);
	}

	// Token: 0x0600D232 RID: 53810 RVA: 0x00601F18 File Offset: 0x00600118
	public static Transform MFOFPOMEIBE(KAHEHOGJPBO.BoneType IGFPBEPIAEE, KAHEHOGJPBO.BoneSide JIDFPDKKFND, Transform[] CKAJJHFIFBL)
	{
		Transform[] array = KAHEHOGJPBO.JEFCNPHEJCO(IGFPBEPIAEE, JIDFPDKKFND, CKAJJHFIFBL);
		if (array.Length == 0)
		{
			return null;
		}
		return array[0];
	}

	// Token: 0x0600D233 RID: 53811 RVA: 0x00601F38 File Offset: 0x00600138
	public static Transform AHCDFEAPJBA(Transform[] AKBEGDIMBGM, params string[][] CAJKHPJFOIH)
	{
		foreach (Transform transform in AKBEGDIMBGM)
		{
			bool flag = true;
			foreach (string[] bimoimpkhnj in CAJKHPJFOIH)
			{
				if (!KAHEHOGJPBO.BPEAHOPJJHH(transform.name, bimoimpkhnj))
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				return transform;
			}
		}
		return null;
	}

	// Token: 0x0600D234 RID: 53812 RVA: 0x00601F91 File Offset: 0x00600191
	public static KAHEHOGJPBO.BoneType BLKLELCLNGM(string PBMPGDKOAML)
	{
		if (KAHEHOGJPBO.CAAOIFILLFA(PBMPGDKOAML))
		{
			return KAHEHOGJPBO.BoneType.Spine;
		}
		if (KAHEHOGJPBO.MLJKCOEBHOM(PBMPGDKOAML))
		{
			return KAHEHOGJPBO.BoneType.Head;
		}
		if (KAHEHOGJPBO.HALABACKOLO(PBMPGDKOAML))
		{
			return KAHEHOGJPBO.BoneType.Arm;
		}
		if (KAHEHOGJPBO.MEAIOEAFLIG(PBMPGDKOAML))
		{
			return KAHEHOGJPBO.BoneType.Leg;
		}
		if (KAHEHOGJPBO.MDDBBBCLPEG(PBMPGDKOAML))
		{
			return KAHEHOGJPBO.BoneType.Tail;
		}
		if (KAHEHOGJPBO.JBFIJDKFNEN(PBMPGDKOAML))
		{
			return KAHEHOGJPBO.BoneType.Eye;
		}
		return KAHEHOGJPBO.BoneType.Unassigned;
	}

	// Token: 0x0600D235 RID: 53813 RVA: 0x00601FD0 File Offset: 0x006001D0
	public static KAHEHOGJPBO.BoneSide MHPFNBCLDMI(string PBMPGDKOAML)
	{
		if (KAHEHOGJPBO.ICPIPOONLIB(PBMPGDKOAML))
		{
			return KAHEHOGJPBO.BoneSide.Left;
		}
		if (KAHEHOGJPBO.LPJGMCKOOKO(PBMPGDKOAML))
		{
			return KAHEHOGJPBO.BoneSide.Right;
		}
		return KAHEHOGJPBO.BoneSide.Center;
	}

	// Token: 0x0600D236 RID: 53814 RVA: 0x00601FE7 File Offset: 0x006001E7
	public static Transform MCBJEHJPBHE(Transform[] AKBEGDIMBGM, KAHEHOGJPBO.BoneType IGFPBEPIAEE, KAHEHOGJPBO.BoneSide JIDFPDKKFND = KAHEHOGJPBO.BoneSide.Center, params string[][] CAJKHPJFOIH)
	{
		return KAHEHOGJPBO.AHCDFEAPJBA(KAHEHOGJPBO.JEFCNPHEJCO(IGFPBEPIAEE, JIDFPDKKFND, AKBEGDIMBGM), CAJKHPJFOIH);
	}

	// Token: 0x0600D237 RID: 53815 RVA: 0x00601FF7 File Offset: 0x006001F7
	private static bool ICPIPOONLIB(string PBMPGDKOAML)
	{
		return KAHEHOGJPBO.BPEAHOPJJHH(PBMPGDKOAML, KAHEHOGJPBO.COIMKIJOEKL) || KAHEHOGJPBO.GDHEIINBCJJ(PBMPGDKOAML) == "L" || KAHEHOGJPBO.AMABNPGJGPI(PBMPGDKOAML) == "L";
	}

	// Token: 0x0600D238 RID: 53816 RVA: 0x0060202A File Offset: 0x0060022A
	private static bool LPJGMCKOOKO(string PBMPGDKOAML)
	{
		return KAHEHOGJPBO.BPEAHOPJJHH(PBMPGDKOAML, KAHEHOGJPBO.CNEFKGDINGI) || KAHEHOGJPBO.GDHEIINBCJJ(PBMPGDKOAML) == "R" || KAHEHOGJPBO.AMABNPGJGPI(PBMPGDKOAML) == "R";
	}

	// Token: 0x0600D239 RID: 53817 RVA: 0x0060205D File Offset: 0x0060025D
	private static bool CAAOIFILLFA(string PBMPGDKOAML)
	{
		return KAHEHOGJPBO.BPEAHOPJJHH(PBMPGDKOAML, KAHEHOGJPBO.MDPILGIGDIJ) && !KAHEHOGJPBO.MCCJOEHHHHD(PBMPGDKOAML, KAHEHOGJPBO.MJOLINEPDMK);
	}

	// Token: 0x0600D23A RID: 53818 RVA: 0x0060207C File Offset: 0x0060027C
	private static bool MLJKCOEBHOM(string PBMPGDKOAML)
	{
		return KAHEHOGJPBO.BPEAHOPJJHH(PBMPGDKOAML, KAHEHOGJPBO.BCBFIGNEEAI) && !KAHEHOGJPBO.MCCJOEHHHHD(PBMPGDKOAML, KAHEHOGJPBO.GHIKOBADMCL);
	}

	// Token: 0x0600D23B RID: 53819 RVA: 0x0060209B File Offset: 0x0060029B
	private static bool HALABACKOLO(string PBMPGDKOAML)
	{
		return KAHEHOGJPBO.BPEAHOPJJHH(PBMPGDKOAML, KAHEHOGJPBO.HKMOEMKMBIH) && !KAHEHOGJPBO.MCCJOEHHHHD(PBMPGDKOAML, KAHEHOGJPBO.DIEJBLHPJPJ);
	}

	// Token: 0x0600D23C RID: 53820 RVA: 0x006020BA File Offset: 0x006002BA
	private static bool MEAIOEAFLIG(string PBMPGDKOAML)
	{
		return KAHEHOGJPBO.BPEAHOPJJHH(PBMPGDKOAML, KAHEHOGJPBO.FKLKFCCMLPC) && !KAHEHOGJPBO.MCCJOEHHHHD(PBMPGDKOAML, KAHEHOGJPBO.KGGKHLNGKIC);
	}

	// Token: 0x0600D23D RID: 53821 RVA: 0x006020D9 File Offset: 0x006002D9
	private static bool MDDBBBCLPEG(string PBMPGDKOAML)
	{
		return KAHEHOGJPBO.BPEAHOPJJHH(PBMPGDKOAML, KAHEHOGJPBO.NLEAAGFLLNE) && !KAHEHOGJPBO.MCCJOEHHHHD(PBMPGDKOAML, KAHEHOGJPBO.BAMALFIDJKE);
	}

	// Token: 0x0600D23E RID: 53822 RVA: 0x006020F8 File Offset: 0x006002F8
	private static bool JBFIJDKFNEN(string PBMPGDKOAML)
	{
		return KAHEHOGJPBO.BPEAHOPJJHH(PBMPGDKOAML, KAHEHOGJPBO.FOGNGFLKACM) && !KAHEHOGJPBO.MCCJOEHHHHD(PBMPGDKOAML, KAHEHOGJPBO.CIGFIAEBGMF);
	}

	// Token: 0x0600D23F RID: 53823 RVA: 0x00602117 File Offset: 0x00600317
	private static bool LDAJNOMFGJI(string PBMPGDKOAML)
	{
		return KAHEHOGJPBO.BPEAHOPJJHH(PBMPGDKOAML, KAHEHOGJPBO.ACAAIEHDFPP);
	}

	// Token: 0x0600D240 RID: 53824 RVA: 0x00602124 File Offset: 0x00600324
	private static bool BPEAHOPJJHH(string PBMPGDKOAML, string[] BIMOIMPKHNJ)
	{
		if (KAHEHOGJPBO.MCCJOEHHHHD(PBMPGDKOAML, KAHEHOGJPBO.ACAAIEHDFPP))
		{
			return false;
		}
		foreach (string value in BIMOIMPKHNJ)
		{
			if (PBMPGDKOAML.Contains(value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D241 RID: 53825 RVA: 0x00602160 File Offset: 0x00600360
	private static bool MCCJOEHHHHD(string PBMPGDKOAML, string[] BIMOIMPKHNJ)
	{
		foreach (string value in BIMOIMPKHNJ)
		{
			if (PBMPGDKOAML.Contains(value))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D242 RID: 53826 RVA: 0x00602190 File Offset: 0x00600390
	private static bool LFBJBMKLOEH(string PBMPGDKOAML, string[] BIMOIMPKHNJ)
	{
		foreach (string oiacpdbbmmp in BIMOIMPKHNJ)
		{
			if (KAHEHOGJPBO.EOMKOIAGMAE(PBMPGDKOAML, oiacpdbbmmp))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600D243 RID: 53827 RVA: 0x006021BD File Offset: 0x006003BD
	private static bool EOMKOIAGMAE(string PBMPGDKOAML, string OIACPDBBMMP)
	{
		return PBMPGDKOAML.Substring(PBMPGDKOAML.Length - 1, 1) == OIACPDBBMMP;
	}

	// Token: 0x0600D244 RID: 53828 RVA: 0x006021D4 File Offset: 0x006003D4
	private static string AMABNPGJGPI(string PBMPGDKOAML)
	{
		if (PBMPGDKOAML.Length > 0)
		{
			return PBMPGDKOAML.Substring(0, 1);
		}
		return "";
	}

	// Token: 0x0600D245 RID: 53829 RVA: 0x006021ED File Offset: 0x006003ED
	private static string GDHEIINBCJJ(string PBMPGDKOAML)
	{
		if (PBMPGDKOAML.Length > 0)
		{
			return PBMPGDKOAML.Substring(PBMPGDKOAML.Length - 1, 1);
		}
		return "";
	}

	// Token: 0x04001BD2 RID: 7122
	public static string[] COIMKIJOEKL = new string[]
	{
		" L ",
		"_L_",
		"-L-",
		" l ",
		"_l_",
		"-l-",
		"Left",
		"left",
		"CATRigL"
	};

	// Token: 0x04001BD3 RID: 7123
	public static string[] CNEFKGDINGI = new string[]
	{
		" R ",
		"_R_",
		"-R-",
		" r ",
		"_r_",
		"-r-",
		"Right",
		"right",
		"CATRigR"
	};

	// Token: 0x04001BD4 RID: 7124
	public static string[] MDPILGIGDIJ = new string[]
	{
		"Spine",
		"spine",
		"Pelvis",
		"pelvis",
		"Root",
		"root",
		"Torso",
		"torso",
		"Body",
		"body",
		"Hips",
		"hips",
		"Neck",
		"neck",
		"Chest",
		"chest"
	};

	// Token: 0x04001BD5 RID: 7125
	public static string[] BCBFIGNEEAI = new string[]
	{
		"Head",
		"head"
	};

	// Token: 0x04001BD6 RID: 7126
	public static string[] HKMOEMKMBIH = new string[]
	{
		"Arm",
		"arm",
		"Hand",
		"hand",
		"Wrist",
		"Wrist",
		"Elbow",
		"elbow",
		"Palm",
		"palm"
	};

	// Token: 0x04001BD7 RID: 7127
	public static string[] FKLKFCCMLPC = new string[]
	{
		"Leg",
		"leg",
		"Thigh",
		"thigh",
		"Calf",
		"calf",
		"Femur",
		"femur",
		"Knee",
		"knee",
		"Foot",
		"foot",
		"Ankle",
		"ankle",
		"Hip",
		"hip"
	};

	// Token: 0x04001BD8 RID: 7128
	public static string[] NLEAAGFLLNE = new string[]
	{
		"Tail",
		"tail"
	};

	// Token: 0x04001BD9 RID: 7129
	public static string[] FOGNGFLKACM = new string[]
	{
		"Eye",
		"eye"
	};

	// Token: 0x04001BDA RID: 7130
	public static string[] ACAAIEHDFPP = new string[]
	{
		"Nub",
		"Dummy",
		"dummy",
		"Tip",
		"IK",
		"Mesh"
	};

	// Token: 0x04001BDB RID: 7131
	public static string[] MJOLINEPDMK = new string[]
	{
		"Head",
		"head"
	};

	// Token: 0x04001BDC RID: 7132
	public static string[] GHIKOBADMCL = new string[]
	{
		"Top",
		"End"
	};

	// Token: 0x04001BDD RID: 7133
	public static string[] DIEJBLHPJPJ = new string[]
	{
		"Collar",
		"collar",
		"Clavicle",
		"clavicle",
		"Finger",
		"finger",
		"Index",
		"index",
		"Mid",
		"mid",
		"Pinky",
		"pinky",
		"Ring",
		"Thumb",
		"thumb",
		"Adjust",
		"adjust",
		"Twist",
		"twist"
	};

	// Token: 0x04001BDE RID: 7134
	public static string[] KGGKHLNGKIC = new string[]
	{
		"Toe",
		"toe",
		"Platform",
		"Adjust",
		"adjust",
		"Twist",
		"twist"
	};

	// Token: 0x04001BDF RID: 7135
	public static string[] BAMALFIDJKE = new string[0];

	// Token: 0x04001BE0 RID: 7136
	public static string[] CIGFIAEBGMF = new string[]
	{
		"Lid",
		"lid",
		"Brow",
		"brow",
		"Lash",
		"lash"
	};

	// Token: 0x04001BE1 RID: 7137
	public static string[] JDJEBGDKKDE = new string[]
	{
		"Pelvis",
		"pelvis",
		"Hip",
		"hip"
	};

	// Token: 0x04001BE2 RID: 7138
	public static string[] DHPPKPKKJOF = new string[]
	{
		"Hand",
		"hand",
		"Wrist",
		"wrist",
		"Palm",
		"palm"
	};

	// Token: 0x04001BE3 RID: 7139
	public static string[] PNLAHKMBLMM = new string[]
	{
		"Foot",
		"foot",
		"Ankle",
		"ankle"
	};

	// Token: 0x020003CD RID: 973
	[Serializable]
	public enum BoneType
	{
		// Token: 0x04001BE5 RID: 7141
		Unassigned,
		// Token: 0x04001BE6 RID: 7142
		Spine,
		// Token: 0x04001BE7 RID: 7143
		Head,
		// Token: 0x04001BE8 RID: 7144
		Arm,
		// Token: 0x04001BE9 RID: 7145
		Leg,
		// Token: 0x04001BEA RID: 7146
		Tail,
		// Token: 0x04001BEB RID: 7147
		Eye
	}

	// Token: 0x020003CE RID: 974
	[Serializable]
	public enum BoneSide
	{
		// Token: 0x04001BED RID: 7149
		Center,
		// Token: 0x04001BEE RID: 7150
		Left,
		// Token: 0x04001BEF RID: 7151
		Right
	}
}
