using System;
using UnityEngine;

// Token: 0x0200018A RID: 394
public class ECGGHIIGNPP
{
	// Token: 0x060057A4 RID: 22436 RVA: 0x002971C2 File Offset: 0x002953C2
	public int EBMDPCBJPOC(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.FJDEJIFCNAL(OCHCODJIPHJ, BJCLLOCGCCG, HLINPEGIHBH, "1HSwordStrafeRunRight", "ClimbLeft", KPLMNDKLEDP);
	}

	// Token: 0x060057A5 RID: 22437 RVA: 0x002971E3 File Offset: 0x002953E3
	public void AOPCKCCFDKE(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057A6 RID: 22438 RVA: 0x002971EC File Offset: 0x002953EC
	public int EHPOJHLLPLO()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057A7 RID: 22439 RVA: 0x002971F4 File Offset: 0x002953F4
	public int JKPFHFIBMEE(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		return this.DCMHCBEMPDG(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, INEPGOOBGOC, COJMPFMDFGO, KPLMNDKLEDP);
	}

	// Token: 0x060057A8 RID: 22440 RVA: 0x0029720C File Offset: 0x0029540C
	public int IFEOIOOEFNN(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		if (ECGGHIIGNPP.MMJMJDCEJDF)
		{
			ECGGHIIGNPP.MMJMJDCEJDF = false;
			this.KAECJKDMGIG = true;
		}
		if (JDCEFOFMGHB.JFIDAGABKID().OMFMENCCBMO > 0 && JDCEFOFMGHB.MNJNNDHCDGG().OMFMENCCBMO != this.MDCKFCEGACG)
		{
			return this.EDAHMMKHLDI();
		}
		bool flag = false;
		int controlID = GUIUtility.GetControlID(FocusType.Native);
		Event current = Event.current;
		EventType typeForControl = current.GetTypeForControl(controlID);
		if (typeForControl == EventType.MouseUp && this.KAECJKDMGIG)
		{
			flag = true;
		}
		if (GUI.Button(OCHCODJIPHJ, "demoLong", GUIStyle.none))
		{
			if (ECGGHIIGNPP.NMEPIOMFENM == -1)
			{
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
				this.KAECJKDMGIG = false;
			}
			if (ECGGHIIGNPP.NMEPIOMFENM != controlID)
			{
				ECGGHIIGNPP.MMJMJDCEJDF = false;
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
			}
			this.KAECJKDMGIG = false;
		}
		if (this.KAECJKDMGIG)
		{
			Rect position = new Rect(OCHCODJIPHJ.x + 902f, OCHCODJIPHJ.y + 804f, OCHCODJIPHJ.width + 1861f, KPLMNDKLEDP.CalcHeight(HLINPEGIHBH[0], 1884f) * (float)HLINPEGIHBH.Length);
			GUI.Box(new Rect(position.x - 866f, position.y - 2f - 53f, position.width + 1363f, position.height + 567f + 857f), "WATER_REFLECTIVE", COJMPFMDFGO);
			int num = GUI.SelectionGrid(position, this.PKNDKDLDEJM, HLINPEGIHBH, 1, KPLMNDKLEDP);
			if (num != this.PKNDKDLDEJM)
			{
				this.PKNDKDLDEJM = num;
				current.Use();
			}
		}
		if (flag)
		{
			this.KAECJKDMGIG = true;
		}
		if (this.KAECJKDMGIG)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().OMFMENCCBMO = this.MDCKFCEGACG;
		}
		return this.POIJGBHBJBF();
	}

	// Token: 0x060057A9 RID: 22441 RVA: 0x002971EC File Offset: 0x002953EC
	public int APCMNKHEABJ()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057AA RID: 22442 RVA: 0x002973AC File Offset: 0x002955AC
	public int MECINJMOEOH(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		if (ECGGHIIGNPP.MMJMJDCEJDF)
		{
			ECGGHIIGNPP.MMJMJDCEJDF = false;
			this.KAECJKDMGIG = true;
		}
		if (JDCEFOFMGHB.IKGFHGKKCPG.OMFMENCCBMO > 1 && JDCEFOFMGHB.IKGFHGKKCPG.OMFMENCCBMO != this.MDCKFCEGACG)
		{
			return this.BPLGDLOPODD();
		}
		bool flag = true;
		int controlID = GUIUtility.GetControlID((FocusType)5);
		Event current = Event.current;
		EventType typeForControl = current.GetTypeForControl(controlID);
		if (typeForControl == EventType.MouseDown && this.KAECJKDMGIG)
		{
			flag = true;
		}
		if (GUI.Button(OCHCODJIPHJ, "' that does not excist in the Node Chain.", GUIStyle.none))
		{
			if (ECGGHIIGNPP.NMEPIOMFENM == -1)
			{
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
				this.KAECJKDMGIG = true;
			}
			if (ECGGHIIGNPP.NMEPIOMFENM != controlID)
			{
				ECGGHIIGNPP.MMJMJDCEJDF = false;
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
			}
			this.KAECJKDMGIG = true;
		}
		if (this.KAECJKDMGIG)
		{
			Rect position = new Rect(OCHCODJIPHJ.x + 1692f, OCHCODJIPHJ.y + 538f, OCHCODJIPHJ.width + 671f, KPLMNDKLEDP.CalcHeight(HLINPEGIHBH[1], 129f) * (float)HLINPEGIHBH.Length);
			GUI.Box(new Rect(position.x - 686f, position.y - 239f - 916f, position.width + 967f, position.height + 694f + 179f), "</color>", COJMPFMDFGO);
			int num = GUI.SelectionGrid(position, this.PKNDKDLDEJM, HLINPEGIHBH, 1, KPLMNDKLEDP);
			if (num != this.PKNDKDLDEJM)
			{
				this.PKNDKDLDEJM = num;
				current.Use();
			}
		}
		if (flag)
		{
			this.KAECJKDMGIG = true;
		}
		if (this.KAECJKDMGIG)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().OMFMENCCBMO = this.MDCKFCEGACG;
		}
		return this.EHPOJHLLPLO();
	}

	// Token: 0x060057AB RID: 22443 RVA: 0x002971EC File Offset: 0x002953EC
	public int POIJGBHBJBF()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057AC RID: 22444 RVA: 0x002971E3 File Offset: 0x002953E3
	public void CJMIBIIKJNO(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057AD RID: 22445 RVA: 0x002971E3 File Offset: 0x002953E3
	public void ECBHDINJNBO(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057AE RID: 22446 RVA: 0x0029754B File Offset: 0x0029574B
	public int ICMPKFGOLJO(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.IFEOIOOEFNN(OCHCODJIPHJ, BJCLLOCGCCG, HLINPEGIHBH, "BlackSmithHammer", "wpn_line2", KPLMNDKLEDP);
	}

	// Token: 0x060057AF RID: 22447 RVA: 0x0029756C File Offset: 0x0029576C
	public int GPJNPMNJPAD(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.OLJJNNNJABG(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, "{0} : {1}", "_HalfResolution", KPLMNDKLEDP);
	}

	// Token: 0x060057B0 RID: 22448 RVA: 0x002971EC File Offset: 0x002953EC
	public int EDAHMMKHLDI()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057B1 RID: 22449 RVA: 0x002971EC File Offset: 0x002953EC
	public int EIEHOCFGHAH()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057B2 RID: 22450 RVA: 0x002971E3 File Offset: 0x002953E3
	public void KKEAIACMEEB(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057B4 RID: 22452 RVA: 0x0029759A File Offset: 0x0029579A
	public int HKGMNIEIFHD(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.ELFCOIEIHGI(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, "saleToAuk", "Roll", KPLMNDKLEDP);
	}

	// Token: 0x060057B5 RID: 22453 RVA: 0x002971EC File Offset: 0x002953EC
	public int ODPJFHKJIOK()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057B6 RID: 22454 RVA: 0x002975C0 File Offset: 0x002957C0
	public int HLGALHEOKOA(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		if (ECGGHIIGNPP.MMJMJDCEJDF)
		{
			ECGGHIIGNPP.MMJMJDCEJDF = true;
			this.KAECJKDMGIG = false;
		}
		if (JDCEFOFMGHB.JFIDAGABKID().OMFMENCCBMO > 0 && JDCEFOFMGHB.JFIDAGABKID().OMFMENCCBMO != this.MDCKFCEGACG)
		{
			return this.EPAACODOMIN();
		}
		bool flag = false;
		int controlID = GUIUtility.GetControlID((FocusType)4);
		Event current = Event.current;
		EventType typeForControl = current.GetTypeForControl(controlID);
		if (typeForControl == EventType.MouseUp && this.KAECJKDMGIG)
		{
			flag = false;
		}
		if (GUI.Button(OCHCODJIPHJ, "/Localization/", GUIStyle.none))
		{
			if (ECGGHIIGNPP.NMEPIOMFENM == -1)
			{
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
				this.KAECJKDMGIG = true;
			}
			if (ECGGHIIGNPP.NMEPIOMFENM != controlID)
			{
				ECGGHIIGNPP.MMJMJDCEJDF = true;
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
			}
			this.KAECJKDMGIG = false;
		}
		if (this.KAECJKDMGIG)
		{
			Rect position = new Rect(OCHCODJIPHJ.x + 21f, OCHCODJIPHJ.y + 1616f, OCHCODJIPHJ.width + 1826f, KPLMNDKLEDP.CalcHeight(HLINPEGIHBH[0], 899f) * (float)HLINPEGIHBH.Length);
			GUI.Box(new Rect(position.x - 268f, position.y - 760f - 1072f, position.width + 817f, position.height + 834f + 986f), "IdleDrink", COJMPFMDFGO);
			int num = GUI.SelectionGrid(position, this.PKNDKDLDEJM, HLINPEGIHBH, 0, KPLMNDKLEDP);
			if (num != this.PKNDKDLDEJM)
			{
				this.PKNDKDLDEJM = num;
				current.Use();
			}
		}
		if (flag)
		{
			this.KAECJKDMGIG = true;
		}
		if (this.KAECJKDMGIG)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.OMFMENCCBMO = this.MDCKFCEGACG;
		}
		return this.NLLCJNOADFI();
	}

	// Token: 0x060057B7 RID: 22455 RVA: 0x0029775F File Offset: 0x0029595F
	public int GLKCDIMLBCO(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.DCMHCBEMPDG(OCHCODJIPHJ, BJCLLOCGCCG, HLINPEGIHBH, "Vector2: ", "Hyperlink_", KPLMNDKLEDP);
	}

	// Token: 0x060057B8 RID: 22456 RVA: 0x002971E3 File Offset: 0x002953E3
	public void IKMHDJPEKHK(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057B9 RID: 22457 RVA: 0x00297780 File Offset: 0x00295980
	public int AEAKEOFDMEP(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		return this.HLGALHEOKOA(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, INEPGOOBGOC, COJMPFMDFGO, KPLMNDKLEDP);
	}

	// Token: 0x060057BA RID: 22458 RVA: 0x002971E3 File Offset: 0x002953E3
	public void JPDNEPPPPFE(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057BB RID: 22459 RVA: 0x002971EC File Offset: 0x002953EC
	public int BPLGDLOPODD()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057BC RID: 22460 RVA: 0x00297796 File Offset: 0x00295996
	public int ELFCOIEIHGI(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.ELFCOIEIHGI(OCHCODJIPHJ, BJCLLOCGCCG, HLINPEGIHBH, "button", "box", KPLMNDKLEDP);
	}

	// Token: 0x060057BD RID: 22461 RVA: 0x002977B7 File Offset: 0x002959B7
	public int HOAMKINBLLG(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.FJDEJIFCNAL(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, "Idle Die", "Tip", KPLMNDKLEDP);
	}

	// Token: 0x060057BE RID: 22462 RVA: 0x002977DD File Offset: 0x002959DD
	public int MACILCHJFEB(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.OLJJNNNJABG(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, "gi_inte_4", " on effect ", KPLMNDKLEDP);
	}

	// Token: 0x060057BF RID: 22463 RVA: 0x00297803 File Offset: 0x00295A03
	public int BBAGCGJDMDG(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		return this.FJDEJIFCNAL(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, INEPGOOBGOC, COJMPFMDFGO, KPLMNDKLEDP);
	}

	// Token: 0x060057C0 RID: 22464 RVA: 0x00297819 File Offset: 0x00295A19
	public int ELFCOIEIHGI(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		return this.ELFCOIEIHGI(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, INEPGOOBGOC, COJMPFMDFGO, KPLMNDKLEDP);
	}

	// Token: 0x060057C1 RID: 22465 RVA: 0x0029782F File Offset: 0x00295A2F
	public int BBEONDHAKLJ(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.NJPGODHPFPJ(OCHCODJIPHJ, BJCLLOCGCCG, HLINPEGIHBH, "DealerFan", "AntaresController", KPLMNDKLEDP);
	}

	// Token: 0x060057C2 RID: 22466 RVA: 0x002971EC File Offset: 0x002953EC
	public int NLLCJNOADFI()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057C3 RID: 22467 RVA: 0x00297850 File Offset: 0x00295A50
	public int OLLPBBHLKOM(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		if (ECGGHIIGNPP.MMJMJDCEJDF)
		{
			ECGGHIIGNPP.MMJMJDCEJDF = true;
			this.KAECJKDMGIG = false;
		}
		if (JDCEFOFMGHB.IKGFHGKKCPG.OMFMENCCBMO > 1 && JDCEFOFMGHB.HMJJPNDEKPP().OMFMENCCBMO != this.MDCKFCEGACG)
		{
			return this.EHPOJHLLPLO();
		}
		bool flag = false;
		int controlID = GUIUtility.GetControlID((FocusType)4);
		Event current = Event.current;
		EventType typeForControl = current.GetTypeForControl(controlID);
		if (typeForControl == EventType.MouseUp && this.KAECJKDMGIG)
		{
			flag = false;
		}
		if (GUI.Button(OCHCODJIPHJ, ", ", GUIStyle.none))
		{
			if (ECGGHIIGNPP.NMEPIOMFENM == -1)
			{
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
				this.KAECJKDMGIG = false;
			}
			if (ECGGHIIGNPP.NMEPIOMFENM != controlID)
			{
				ECGGHIIGNPP.MMJMJDCEJDF = true;
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
			}
			this.KAECJKDMGIG = true;
		}
		if (this.KAECJKDMGIG)
		{
			Rect position = new Rect(OCHCODJIPHJ.x + 1082f, OCHCODJIPHJ.y + 1485f, OCHCODJIPHJ.width + 1095f, KPLMNDKLEDP.CalcHeight(HLINPEGIHBH[1], 1102f) * (float)HLINPEGIHBH.Length);
			GUI.Box(new Rect(position.x - 1167f, position.y - 561f - 1072f, position.width + 832f, position.height + 1522f + 1888f), "System.Boolean", COJMPFMDFGO);
			int num = GUI.SelectionGrid(position, this.PKNDKDLDEJM, HLINPEGIHBH, 1, KPLMNDKLEDP);
			if (num != this.PKNDKDLDEJM)
			{
				this.PKNDKDLDEJM = num;
				current.Use();
			}
		}
		if (flag)
		{
			this.KAECJKDMGIG = true;
		}
		if (this.KAECJKDMGIG)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().OMFMENCCBMO = this.MDCKFCEGACG;
		}
		return this.POIJGBHBJBF();
	}

	// Token: 0x060057C4 RID: 22468 RVA: 0x002971EC File Offset: 0x002953EC
	public int KEDNJCFNKPF()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057C5 RID: 22469 RVA: 0x002979EF File Offset: 0x00295BEF
	public int GNENEEGHIKB(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.ELFCOIEIHGI(OCHCODJIPHJ, BJCLLOCGCCG, HLINPEGIHBH, "LUM_CONTRIB_ON", "3", KPLMNDKLEDP);
	}

	// Token: 0x060057C6 RID: 22470 RVA: 0x00297A10 File Offset: 0x00295C10
	public int PKKELNPIOAM(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.MECINJMOEOH(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, "", "_History3Weight", KPLMNDKLEDP);
	}

	// Token: 0x060057C7 RID: 22471 RVA: 0x002971E3 File Offset: 0x002953E3
	public void BNAPCBPBMIJ(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057C8 RID: 22472 RVA: 0x002971E3 File Offset: 0x002953E3
	public void CHMPBPELKAD(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057C9 RID: 22473 RVA: 0x002971E3 File Offset: 0x002953E3
	public void LGHGEGCALDI(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057CA RID: 22474 RVA: 0x002971E3 File Offset: 0x002953E3
	public void CMFLGBFEHBG(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057CB RID: 22475 RVA: 0x002971EC File Offset: 0x002953EC
	public int PBEJBCNBGDP()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057CC RID: 22476 RVA: 0x002971E3 File Offset: 0x002953E3
	public void JHABNJMNHDB(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057CD RID: 22477 RVA: 0x002971E3 File Offset: 0x002953E3
	public void HJCHCONFHDO(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057CE RID: 22478 RVA: 0x002971EC File Offset: 0x002953EC
	public int BEJNNOEDLPM()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057CF RID: 22479 RVA: 0x002971EC File Offset: 0x002953EC
	public int EPAACODOMIN()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057D0 RID: 22480 RVA: 0x002971EC File Offset: 0x002953EC
	public int IBNLOHIDHGO()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057D1 RID: 22481 RVA: 0x002971E3 File Offset: 0x002953E3
	public void OPLFIHHABID(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057D2 RID: 22482 RVA: 0x00297A36 File Offset: 0x00295C36
	public int DPGACMBGIGI(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.OLLPBBHLKOM(OCHCODJIPHJ, BJCLLOCGCCG, HLINPEGIHBH, "_DistAmount", "ClimbUp", KPLMNDKLEDP);
	}

	// Token: 0x060057D3 RID: 22483 RVA: 0x00297A57 File Offset: 0x00295C57
	public int GAGDFKDOKPD(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.NJPGODHPFPJ(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, "", "Wizard1HandThrow", KPLMNDKLEDP);
	}

	// Token: 0x060057D4 RID: 22484 RVA: 0x00297A7D File Offset: 0x00295C7D
	public int IJDKGNJIPCL(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.HLGALHEOKOA(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, "selectedTask", "FishController", KPLMNDKLEDP);
	}

	// Token: 0x060057D5 RID: 22485 RVA: 0x00297AA3 File Offset: 0x00295CA3
	public ECGGHIIGNPP()
	{
		this.MDCKFCEGACG = KEKOPBBEOJE.IKGFHGKKCPG.CFNJHENMMOH();
	}

	// Token: 0x060057D6 RID: 22486 RVA: 0x00297ABB File Offset: 0x00295CBB
	public int ELFCOIEIHGI(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.ELFCOIEIHGI(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, "button", "box", KPLMNDKLEDP);
	}

	// Token: 0x060057D7 RID: 22487 RVA: 0x00297AE1 File Offset: 0x00295CE1
	public int CLGHILPOLPF(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.FJDEJIFCNAL(OCHCODJIPHJ, BJCLLOCGCCG, HLINPEGIHBH, "", "* change", KPLMNDKLEDP);
	}

	// Token: 0x060057D8 RID: 22488 RVA: 0x002971EC File Offset: 0x002953EC
	public int LBMIBKIBAPD()
	{
		return this.PKNDKDLDEJM;
	}

	// Token: 0x060057D9 RID: 22489 RVA: 0x00297780 File Offset: 0x00295980
	public int NALEHAALHLC(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		return this.HLGALHEOKOA(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, INEPGOOBGOC, COJMPFMDFGO, KPLMNDKLEDP);
	}

	// Token: 0x060057DA RID: 22490 RVA: 0x00297B04 File Offset: 0x00295D04
	public int ELFCOIEIHGI(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		if (ECGGHIIGNPP.MMJMJDCEJDF)
		{
			ECGGHIIGNPP.MMJMJDCEJDF = false;
			this.KAECJKDMGIG = false;
		}
		if (JDCEFOFMGHB.IKGFHGKKCPG.OMFMENCCBMO > 0 && JDCEFOFMGHB.IKGFHGKKCPG.OMFMENCCBMO != this.MDCKFCEGACG)
		{
			return this.LBMIBKIBAPD();
		}
		bool flag = false;
		int controlID = GUIUtility.GetControlID(FocusType.Passive);
		Event current = Event.current;
		EventType typeForControl = current.GetTypeForControl(controlID);
		if (typeForControl == EventType.MouseUp && this.KAECJKDMGIG)
		{
			flag = true;
		}
		if (GUI.Button(OCHCODJIPHJ, "", GUIStyle.none))
		{
			if (ECGGHIIGNPP.NMEPIOMFENM == -1)
			{
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
				this.KAECJKDMGIG = false;
			}
			if (ECGGHIIGNPP.NMEPIOMFENM != controlID)
			{
				ECGGHIIGNPP.MMJMJDCEJDF = true;
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
			}
			this.KAECJKDMGIG = true;
		}
		if (this.KAECJKDMGIG)
		{
			Rect position = new Rect(OCHCODJIPHJ.x + 4f, OCHCODJIPHJ.y + 55f, OCHCODJIPHJ.width + 30f, KPLMNDKLEDP.CalcHeight(HLINPEGIHBH[0], 1f) * (float)HLINPEGIHBH.Length);
			GUI.Box(new Rect(position.x - 5f, position.y - 5f - 0f, position.width + 10f, position.height + 10f + 0f), "", COJMPFMDFGO);
			int num = GUI.SelectionGrid(position, this.PKNDKDLDEJM, HLINPEGIHBH, 1, KPLMNDKLEDP);
			if (num != this.PKNDKDLDEJM)
			{
				this.PKNDKDLDEJM = num;
				current.Use();
			}
		}
		if (flag)
		{
			this.KAECJKDMGIG = false;
		}
		if (this.KAECJKDMGIG)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.OMFMENCCBMO = this.MDCKFCEGACG;
		}
		return this.LBMIBKIBAPD();
	}

	// Token: 0x060057DB RID: 22491 RVA: 0x002971E3 File Offset: 0x002953E3
	public void LKNIANNDLIM(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057DC RID: 22492 RVA: 0x00297CA3 File Offset: 0x00295EA3
	public int MPEDKNCCDPK(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		return this.IFEOIOOEFNN(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, INEPGOOBGOC, COJMPFMDFGO, KPLMNDKLEDP);
	}

	// Token: 0x060057DD RID: 22493 RVA: 0x00297CB9 File Offset: 0x00295EB9
	public int JECPNFAAFMM(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.OLLPBBHLKOM(OCHCODJIPHJ, BJCLLOCGCCG, HLINPEGIHBH, "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_biped_i_k.html", "WalkBackward", KPLMNDKLEDP);
	}

	// Token: 0x060057DE RID: 22494 RVA: 0x002971E3 File Offset: 0x002953E3
	public void PMAMLDBOBMF(int CLBPBJGLHEE)
	{
		this.PKNDKDLDEJM = CLBPBJGLHEE;
	}

	// Token: 0x060057DF RID: 22495 RVA: 0x00297CDC File Offset: 0x00295EDC
	public int DCMHCBEMPDG(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		if (ECGGHIIGNPP.MMJMJDCEJDF)
		{
			ECGGHIIGNPP.MMJMJDCEJDF = false;
			this.KAECJKDMGIG = false;
		}
		if (JDCEFOFMGHB.HMJJPNDEKPP().OMFMENCCBMO > 1 && JDCEFOFMGHB.IKGFHGKKCPG.OMFMENCCBMO != this.MDCKFCEGACG)
		{
			return this.PBEJBCNBGDP();
		}
		bool flag = true;
		int controlID = GUIUtility.GetControlID((FocusType)6);
		Event current = Event.current;
		EventType typeForControl = current.GetTypeForControl(controlID);
		if (typeForControl == EventType.MouseUp && this.KAECJKDMGIG)
		{
			flag = true;
		}
		if (GUI.Button(OCHCODJIPHJ, "/", GUIStyle.none))
		{
			if (ECGGHIIGNPP.NMEPIOMFENM == -1)
			{
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
				this.KAECJKDMGIG = false;
			}
			if (ECGGHIIGNPP.NMEPIOMFENM != controlID)
			{
				ECGGHIIGNPP.MMJMJDCEJDF = false;
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
			}
			this.KAECJKDMGIG = true;
		}
		if (this.KAECJKDMGIG)
		{
			Rect position = new Rect(OCHCODJIPHJ.x + 1340f, OCHCODJIPHJ.y + 1802f, OCHCODJIPHJ.width + 61f, KPLMNDKLEDP.CalcHeight(HLINPEGIHBH[1], 954f) * (float)HLINPEGIHBH.Length);
			GUI.Box(new Rect(position.x - 1782f, position.y - 676f - 396f, position.width + 1070f, position.height + 380f + 1031f), "Roar", COJMPFMDFGO);
			int num = GUI.SelectionGrid(position, this.PKNDKDLDEJM, HLINPEGIHBH, 0, KPLMNDKLEDP);
			if (num != this.PKNDKDLDEJM)
			{
				this.PKNDKDLDEJM = num;
				current.Use();
			}
		}
		if (flag)
		{
			this.KAECJKDMGIG = false;
		}
		if (this.KAECJKDMGIG)
		{
			JDCEFOFMGHB.IKGFHGKKCPG.OMFMENCCBMO = this.MDCKFCEGACG;
		}
		return this.IBNLOHIDHGO();
	}

	// Token: 0x060057E0 RID: 22496 RVA: 0x00297E7B File Offset: 0x0029607B
	public int HBHILDMLNIL(Rect OCHCODJIPHJ, string GEKIAPEDAGB, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.NJPGODHPFPJ(OCHCODJIPHJ, new GUIContent(GEKIAPEDAGB), HLINPEGIHBH, "RollerBladeSkateFwd", "BowReady", KPLMNDKLEDP);
	}

	// Token: 0x060057E1 RID: 22497 RVA: 0x00297EA4 File Offset: 0x002960A4
	public int OLJJNNNJABG(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		if (ECGGHIIGNPP.MMJMJDCEJDF)
		{
			ECGGHIIGNPP.MMJMJDCEJDF = true;
			this.KAECJKDMGIG = false;
		}
		if (JDCEFOFMGHB.JFIDAGABKID().OMFMENCCBMO > 0 && JDCEFOFMGHB.MNJNNDHCDGG().OMFMENCCBMO != this.MDCKFCEGACG)
		{
			return this.EDAHMMKHLDI();
		}
		bool flag = false;
		int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
		Event current = Event.current;
		EventType typeForControl = current.GetTypeForControl(controlID);
		if (typeForControl == EventType.MouseUp && this.KAECJKDMGIG)
		{
			flag = false;
		}
		if (GUI.Button(OCHCODJIPHJ, "uint:", GUIStyle.none))
		{
			if (ECGGHIIGNPP.NMEPIOMFENM == -1)
			{
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
				this.KAECJKDMGIG = false;
			}
			if (ECGGHIIGNPP.NMEPIOMFENM != controlID)
			{
				ECGGHIIGNPP.MMJMJDCEJDF = true;
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
			}
			this.KAECJKDMGIG = false;
		}
		if (this.KAECJKDMGIG)
		{
			Rect position = new Rect(OCHCODJIPHJ.x + 1583f, OCHCODJIPHJ.y + 1121f, OCHCODJIPHJ.width + 184f, KPLMNDKLEDP.CalcHeight(HLINPEGIHBH[0], 691f) * (float)HLINPEGIHBH.Length);
			GUI.Box(new Rect(position.x - 1006f, position.y - 1851f - 307f, position.width + 669f, position.height + 1700f + 235f), "{0} {1} {2} {3} {4} {5}", COJMPFMDFGO);
			int num = GUI.SelectionGrid(position, this.PKNDKDLDEJM, HLINPEGIHBH, 1, KPLMNDKLEDP);
			if (num != this.PKNDKDLDEJM)
			{
				this.PKNDKDLDEJM = num;
				current.Use();
			}
		}
		if (flag)
		{
			this.KAECJKDMGIG = true;
		}
		if (this.KAECJKDMGIG)
		{
			JDCEFOFMGHB.MNJNNDHCDGG().OMFMENCCBMO = this.MDCKFCEGACG;
		}
		return this.POIJGBHBJBF();
	}

	// Token: 0x060057E2 RID: 22498 RVA: 0x00298044 File Offset: 0x00296244
	public int NJPGODHPFPJ(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		if (ECGGHIIGNPP.MMJMJDCEJDF)
		{
			ECGGHIIGNPP.MMJMJDCEJDF = false;
			this.KAECJKDMGIG = false;
		}
		if (JDCEFOFMGHB.MNJNNDHCDGG().OMFMENCCBMO > 0 && JDCEFOFMGHB.JFIDAGABKID().OMFMENCCBMO != this.MDCKFCEGACG)
		{
			return this.NLLCJNOADFI();
		}
		bool flag = false;
		int controlID = GUIUtility.GetControlID(FocusType.Keyboard);
		Event current = Event.current;
		EventType typeForControl = current.GetTypeForControl(controlID);
		if (typeForControl == EventType.MouseDown && this.KAECJKDMGIG)
		{
			flag = false;
		}
		if (GUI.Button(OCHCODJIPHJ, "gi_fridgice", GUIStyle.none))
		{
			if (ECGGHIIGNPP.NMEPIOMFENM == -1)
			{
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
				this.KAECJKDMGIG = false;
			}
			if (ECGGHIIGNPP.NMEPIOMFENM != controlID)
			{
				ECGGHIIGNPP.MMJMJDCEJDF = true;
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
			}
			this.KAECJKDMGIG = true;
		}
		if (this.KAECJKDMGIG)
		{
			Rect position = new Rect(OCHCODJIPHJ.x + 1972f, OCHCODJIPHJ.y + 966f, OCHCODJIPHJ.width + 1389f, KPLMNDKLEDP.CalcHeight(HLINPEGIHBH[0], 707f) * (float)HLINPEGIHBH.Length);
			GUI.Box(new Rect(position.x - 1933f, position.y - 1242f - 1557f, position.width + 964f, position.height + 809f + 1533f), "Twist", COJMPFMDFGO);
			int num = GUI.SelectionGrid(position, this.PKNDKDLDEJM, HLINPEGIHBH, 0, KPLMNDKLEDP);
			if (num != this.PKNDKDLDEJM)
			{
				this.PKNDKDLDEJM = num;
				current.Use();
			}
		}
		if (flag)
		{
			this.KAECJKDMGIG = false;
		}
		if (this.KAECJKDMGIG)
		{
			JDCEFOFMGHB.JFIDAGABKID().OMFMENCCBMO = this.MDCKFCEGACG;
		}
		return this.PBEJBCNBGDP();
	}

	// Token: 0x060057E3 RID: 22499 RVA: 0x002981E3 File Offset: 0x002963E3
	public int JLJHKCMJKPL(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.FJDEJIFCNAL(OCHCODJIPHJ, BJCLLOCGCCG, HLINPEGIHBH, "Chest", "KatanaReady", KPLMNDKLEDP);
	}

	// Token: 0x060057E4 RID: 22500 RVA: 0x00298204 File Offset: 0x00296404
	public int FJDEJIFCNAL(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle INEPGOOBGOC, GUIStyle COJMPFMDFGO, GUIStyle KPLMNDKLEDP)
	{
		if (ECGGHIIGNPP.MMJMJDCEJDF)
		{
			ECGGHIIGNPP.MMJMJDCEJDF = false;
			this.KAECJKDMGIG = true;
		}
		if (JDCEFOFMGHB.MNJNNDHCDGG().OMFMENCCBMO > 0 && JDCEFOFMGHB.JFIDAGABKID().OMFMENCCBMO != this.MDCKFCEGACG)
		{
			return this.BPLGDLOPODD();
		}
		bool flag = true;
		int controlID = GUIUtility.GetControlID((FocusType)8);
		Event current = Event.current;
		EventType typeForControl = current.GetTypeForControl(controlID);
		if (typeForControl == EventType.MouseUp && this.KAECJKDMGIG)
		{
			flag = false;
		}
		if (GUI.Button(OCHCODJIPHJ, "BowIdle", GUIStyle.none))
		{
			if (ECGGHIIGNPP.NMEPIOMFENM == -1)
			{
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
				this.KAECJKDMGIG = true;
			}
			if (ECGGHIIGNPP.NMEPIOMFENM != controlID)
			{
				ECGGHIIGNPP.MMJMJDCEJDF = false;
				ECGGHIIGNPP.NMEPIOMFENM = controlID;
			}
			this.KAECJKDMGIG = false;
		}
		if (this.KAECJKDMGIG)
		{
			Rect position = new Rect(OCHCODJIPHJ.x + 911f, OCHCODJIPHJ.y + 547f, OCHCODJIPHJ.width + 326f, KPLMNDKLEDP.CalcHeight(HLINPEGIHBH[1], 1031f) * (float)HLINPEGIHBH.Length);
			GUI.Box(new Rect(position.x - 438f, position.y - 1696f - 346f, position.width + 925f, position.height + 666f + 1693f), "RodParams not found!", COJMPFMDFGO);
			int num = GUI.SelectionGrid(position, this.PKNDKDLDEJM, HLINPEGIHBH, 0, KPLMNDKLEDP);
			if (num != this.PKNDKDLDEJM)
			{
				this.PKNDKDLDEJM = num;
				current.Use();
			}
		}
		if (flag)
		{
			this.KAECJKDMGIG = false;
		}
		if (this.KAECJKDMGIG)
		{
			JDCEFOFMGHB.HMJJPNDEKPP().OMFMENCCBMO = this.MDCKFCEGACG;
		}
		return this.NLLCJNOADFI();
	}

	// Token: 0x060057E5 RID: 22501 RVA: 0x002983A3 File Offset: 0x002965A3
	public int DJIECHCEFHP(Rect OCHCODJIPHJ, GUIContent BJCLLOCGCCG, GUIContent[] HLINPEGIHBH, GUIStyle KPLMNDKLEDP)
	{
		return this.ELFCOIEIHGI(OCHCODJIPHJ, BJCLLOCGCCG, HLINPEGIHBH, "isMoving", "_NoisePerChannel", KPLMNDKLEDP);
	}

	// Token: 0x04000D27 RID: 3367
	private int MDCKFCEGACG;

	// Token: 0x04000D28 RID: 3368
	private static bool MMJMJDCEJDF;

	// Token: 0x04000D29 RID: 3369
	private static int NMEPIOMFENM = -1;

	// Token: 0x04000D2A RID: 3370
	private bool KAECJKDMGIG;

	// Token: 0x04000D2B RID: 3371
	private int PKNDKDLDEJM;
}
