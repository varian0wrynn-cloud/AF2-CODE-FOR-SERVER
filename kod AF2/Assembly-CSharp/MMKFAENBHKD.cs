using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020001AA RID: 426
public class MMKFAENBHKD : ONKDCGNBALK
{
	// Token: 0x06005F56 RID: 24406 RVA: 0x002C7AE4 File Offset: 0x002C5CE4
	public void LGLPHCMBBDP()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j++)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F57 RID: 24407 RVA: 0x002C7B73 File Offset: 0x002C5D73
	public void FPEDDFLEIBO(int KLEPFLJGHLH)
	{
		this.AHOBHGBPGKK = KLEPFLJGHLH;
	}

	// Token: 0x06005F58 RID: 24408 RVA: 0x002C7B7C File Offset: 0x002C5D7C
	public virtual void ILHLJFHLJIH(bool CFMPGCJMHJM)
	{
		Event current = Event.current;
		if (this.KPLMFNIFPMM)
		{
			GUI.Box(new Rect(this.OCHCODJIPHJ.x - 345f, this.OCHCODJIPHJ.y - 1582f, this.OCHCODJIPHJ.width + 1593f, this.OCHCODJIPHJ.height + 810f), "Escaped backslash \\\nEscaped bracket [[\nClosing bracket ]\n");
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.MiddleLeft
		};
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 947f, (float)this.LACAJHOHACK.Count * this.JHNCNHAAJCH + 612f), false, true);
		for (int i = 1; i < this.LACAJHOHACK.Count; i++)
		{
			ItemBase itemBase = this.LACAJHOHACK[i];
			float x = this.OCHCODJIPHJ.x + 1442f;
			float y = this.OCHCODJIPHJ.y + 1379f + (float)i * this.JHNCNHAAJCH;
			Rect rect = new Rect(x, y, this.OCHCODJIPHJ.width - 561f, this.JHNCNHAAJCH);
			GUI.DrawTextureWithTexCoords(rect, GuiProcessor.BBLINJLBAIL().WLBLine, (this.BMOEEJCBDJO() == i) ? new Rect(1210f, 1296f, 1532f, 1757f) : new Rect(1729f, 1191f, 1074f, 502f), true);
			if (itemBase.onRender != null)
			{
				itemBase.onRender(this, itemBase, rect, this.OEAGLNMGGDI() == i);
			}
			else
			{
				itemBase.BOHKFACPFIJ(new Rect(x, y, this.OCHCODJIPHJ.width - 1349f, this.JHNCNHAAJCH), ofpnedeamab);
			}
			if (GUI.Button(new Rect(x, y, this.OCHCODJIPHJ.width - 1905f, this.JHNCNHAAJCH), "wpn_break", GUIStyle.none))
			{
				this.OEIOEBCGMJE(i);
				if (current.button == 1)
				{
					Debug.Log("\n");
					itemBase.LBIPECNEDGE();
				}
				this.FJNDDAMCLFL();
			}
		}
		GUI.EndScrollView();
		if ((long)Environment.TickCount - this.NNKFCINLJEA > 55L)
		{
			if (Input.GetKey((KeyCode)176) && this.IHEILFHMLAG < this.LACAJHOHACK.Count - 0)
			{
				int num = this.DEFBLKPDLPM();
				this.NEKOMKJDIIE(num + 1);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.MPMFNJEJAHJ();
			}
			if (Input.GetKey((KeyCode)166) && this.HHJKOIJGNAK() > 1)
			{
				int num = this.FJNDDAMCLFL();
				this.NEKOMKJDIIE(num - 0);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.GCKGOOBOKJB();
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005F59 RID: 24409 RVA: 0x002C7E94 File Offset: 0x002C6094
	public void OEIOEBCGMJE(int DCCPCBLODIG)
	{
		int ahobhgbpgkk = this.AHOBHGBPGKK;
		this.AHOBHGBPGKK = DCCPCBLODIG;
		this.KCLMJJHBCDM(ahobhgbpgkk, this.AHOBHGBPGKK);
		int ahobhgbpgkk2 = this.AHOBHGBPGKK;
	}

	// Token: 0x06005F5A RID: 24410 RVA: 0x002C7EC8 File Offset: 0x002C60C8
	public void MCGGBEBAIJO()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j++)
			{
				if (this.LACAJHOHACK[i].JMPAIFNGBLM(this.LACAJHOHACK[j]) < 1)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F5B RID: 24411 RVA: 0x002C7F54 File Offset: 0x002C6154
	public void KINFJHFDHIC()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (string.CompareOrdinal(this.LACAJHOHACK[i].ToString(), this.LACAJHOHACK[j].ToString()) < 1)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F5C RID: 24412 RVA: 0x002C7B73 File Offset: 0x002C5D73
	public void IJMNKBHHLMF(int KLEPFLJGHLH)
	{
		this.AHOBHGBPGKK = KLEPFLJGHLH;
	}

	// Token: 0x06005F5D RID: 24413 RVA: 0x002C7FEC File Offset: 0x002C61EC
	public void AGFFDCECLBF(int DCCPCBLODIG)
	{
		int ahobhgbpgkk = this.AHOBHGBPGKK;
		this.AHOBHGBPGKK = DCCPCBLODIG;
		this.HNAMFMFHIGH(ahobhgbpgkk, this.AHOBHGBPGKK);
		int ahobhgbpgkk2 = this.AHOBHGBPGKK;
	}

	// Token: 0x06005F5E RID: 24414 RVA: 0x002C8020 File Offset: 0x002C6220
	public override void HFJFBDPNCCB(bool CFMPGCJMHJM)
	{
		Event current = Event.current;
		if (this.KPLMFNIFPMM)
		{
			GUI.Box(new Rect(this.OCHCODJIPHJ.x - 4f, this.OCHCODJIPHJ.y - 4f, this.OCHCODJIPHJ.width + 10f, this.OCHCODJIPHJ.height + 8f), "");
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.MiddleLeft
		};
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 18f, (float)this.LACAJHOHACK.Count * this.JHNCNHAAJCH + 20f), false, false);
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			ItemBase itemBase = this.LACAJHOHACK[i];
			float x = this.OCHCODJIPHJ.x + 5f;
			float y = this.OCHCODJIPHJ.y + 5f + (float)i * this.JHNCNHAAJCH;
			Rect rect = new Rect(x, y, this.OCHCODJIPHJ.width - 18f, this.JHNCNHAAJCH);
			GUI.DrawTextureWithTexCoords(rect, GuiProcessor.IKGFHGKKCPG.WLBLine, (this.IHEILFHMLAG == i) ? new Rect(0f, 0f, 1f, 0.5f) : new Rect(0f, 0.5f, 1f, 0.5f), true);
			if (itemBase.onRender != null)
			{
				itemBase.onRender(this, itemBase, rect, this.IHEILFHMLAG == i);
			}
			else
			{
				itemBase.GKDJCJKMBEN(new Rect(x, y, this.OCHCODJIPHJ.width - 10f, this.JHNCNHAAJCH), ofpnedeamab);
			}
			if (GUI.Button(new Rect(x, y, this.OCHCODJIPHJ.width - 10f, this.JHNCNHAAJCH), "", GUIStyle.none))
			{
				this.IHEILFHMLAG = i;
				if (current.button == 1)
				{
					Debug.Log("rbon");
					itemBase.INFJMKDHGJA();
				}
				this.IHEILFHMLAG;
			}
		}
		GUI.EndScrollView();
		if ((long)Environment.TickCount - this.NNKFCINLJEA > 110L)
		{
			if (Input.GetKey(KeyCode.DownArrow) && this.IHEILFHMLAG < this.LACAJHOHACK.Count - 1)
			{
				int num = this.IHEILFHMLAG;
				this.IHEILFHMLAG = num + 1;
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.MPMFNJEJAHJ();
			}
			if (Input.GetKey(KeyCode.UpArrow) && this.IHEILFHMLAG > 0)
			{
				int num = this.IHEILFHMLAG;
				this.IHEILFHMLAG = num - 1;
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.MPMFNJEJAHJ();
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005F5F RID: 24415 RVA: 0x002C8338 File Offset: 0x002C6538
	public void KAEMCCOLNMB(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.HJICBDFHNOO("' that does not excist in the Node Chain.", 167f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 0)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x06005F60 RID: 24416 RVA: 0x002C7B73 File Offset: 0x002C5D73
	public void FNDGHAKAGKP(int KLEPFLJGHLH)
	{
		this.AHOBHGBPGKK = KLEPFLJGHLH;
	}

	// Token: 0x06005F61 RID: 24417 RVA: 0x002C8394 File Offset: 0x002C6594
	public void HHKCFGAENJN()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F62 RID: 24418 RVA: 0x002C8424 File Offset: 0x002C6624
	public virtual void DLBGNLEIMPB(bool CFMPGCJMHJM)
	{
		Event current = Event.current;
		if (this.KPLMFNIFPMM)
		{
			GUI.Box(new Rect(this.OCHCODJIPHJ.x - 1359f, this.OCHCODJIPHJ.y - 904f, this.OCHCODJIPHJ.width + 623f, this.OCHCODJIPHJ.height + 1929f), "X");
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.UpperLeft
		};
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 1858f, (float)this.LACAJHOHACK.Count * this.JHNCNHAAJCH + 128f), true, true);
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			ItemBase itemBase = this.LACAJHOHACK[i];
			float x = this.OCHCODJIPHJ.x + 1615f;
			float y = this.OCHCODJIPHJ.y + 1977f + (float)i * this.JHNCNHAAJCH;
			Rect rect = new Rect(x, y, this.OCHCODJIPHJ.width - 1303f, this.JHNCNHAAJCH);
			GUI.DrawTextureWithTexCoords(rect, GuiProcessor.IKGFHGKKCPG.WLBLine, (this.OEAGLNMGGDI() == i) ? new Rect(493f, 268f, 1765f, 94f) : new Rect(1029f, 716f, 1147f, 1390f), true);
			if (itemBase.onRender != null)
			{
				itemBase.onRender(this, itemBase, rect, this.FJNDDAMCLFL() == i);
			}
			else
			{
				itemBase.GGFPEBNLLEG(new Rect(x, y, this.OCHCODJIPHJ.width - 1531f, this.JHNCNHAAJCH), ofpnedeamab);
			}
			if (GUI.Button(new Rect(x, y, this.OCHCODJIPHJ.width - 887f, this.JHNCNHAAJCH), "Running Dance", GUIStyle.none))
			{
				this.OEIOEBCGMJE(i);
				if (current.button == 1)
				{
					Debug.Log(" is null.");
					itemBase.IMKNNCCFOCK();
				}
				this.IHEILFHMLAG;
			}
		}
		GUI.EndScrollView();
		if ((long)Environment.TickCount - this.NNKFCINLJEA > -67L)
		{
			if (Input.GetKey((KeyCode)161) && this.LPENOBCEAPP() < this.LACAJHOHACK.Count - 0)
			{
				int num = this.LPENOBCEAPP();
				this.BJLCAGOJDNM(num + 1);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.JOJGBLLMGPF();
			}
			if (Input.GetKey((KeyCode)(-151)) && this.HHJKOIJGNAK() > 0)
			{
				int num = this.NAIIDOFAJKG();
				this.NEKOMKJDIIE(num - 1);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.NIJOHIBNLEI();
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005F63 RID: 24419 RVA: 0x002C873C File Offset: 0x002C693C
	public void EDIGEKABMEN(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("Near", 1555f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 0)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x06005F64 RID: 24420 RVA: 0x002C7B73 File Offset: 0x002C5D73
	public void MBCGOMPHPPI(int KLEPFLJGHLH)
	{
		this.AHOBHGBPGKK = KLEPFLJGHLH;
	}

	// Token: 0x06005F65 RID: 24421 RVA: 0x002C8798 File Offset: 0x002C6998
	public void OOJKJOCOOCB(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("human_move_2.wav", 1f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 0)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x17000162 RID: 354
	// (get) Token: 0x06005FAC RID: 24492 RVA: 0x002C8825 File Offset: 0x002C6A25
	// (set) Token: 0x06005F66 RID: 24422 RVA: 0x002C87F4 File Offset: 0x002C69F4
	public int IHEILFHMLAG
	{
		get
		{
			return this.AHOBHGBPGKK;
		}
		set
		{
			int ahobhgbpgkk = this.AHOBHGBPGKK;
			this.AHOBHGBPGKK = value;
			this.OOJKJOCOOCB(ahobhgbpgkk, this.AHOBHGBPGKK);
			int ahobhgbpgkk2 = this.AHOBHGBPGKK;
		}
	}

	// Token: 0x06005F67 RID: 24423 RVA: 0x002C8825 File Offset: 0x002C6A25
	public int NAIIDOFAJKG()
	{
		return this.AHOBHGBPGKK;
	}

	// Token: 0x06005F68 RID: 24424 RVA: 0x002C8830 File Offset: 0x002C6A30
	public void GFCKPJCIPEO(int DCCPCBLODIG)
	{
		int ahobhgbpgkk = this.AHOBHGBPGKK;
		this.AHOBHGBPGKK = DCCPCBLODIG;
		this.HJLBODNFBAL(ahobhgbpgkk, this.AHOBHGBPGKK);
		int ahobhgbpgkk2 = this.AHOBHGBPGKK;
	}

	// Token: 0x06005F69 RID: 24425 RVA: 0x002C8864 File Offset: 0x002C6A64
	public void CFIBADPGBGI()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j++)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F6A RID: 24426 RVA: 0x002C88F4 File Offset: 0x002C6AF4
	public virtual void LNNEOFFJJJA(bool CFMPGCJMHJM)
	{
		Event current = Event.current;
		if (this.KPLMFNIFPMM)
		{
			GUI.Box(new Rect(this.OCHCODJIPHJ.x - 1109f, this.OCHCODJIPHJ.y - 1146f, this.OCHCODJIPHJ.width + 348f, this.OCHCODJIPHJ.height + 359f), "IdleTyping");
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.UpperLeft
		};
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 1395f, (float)this.LACAJHOHACK.Count * this.JHNCNHAAJCH + 1111f), true, false);
		for (int i = 1; i < this.LACAJHOHACK.Count; i++)
		{
			ItemBase itemBase = this.LACAJHOHACK[i];
			float x = this.OCHCODJIPHJ.x + 262f;
			float y = this.OCHCODJIPHJ.y + 554f + (float)i * this.JHNCNHAAJCH;
			Rect rect = new Rect(x, y, this.OCHCODJIPHJ.width - 554f, this.JHNCNHAAJCH);
			GUI.DrawTextureWithTexCoords(rect, GuiProcessor.IKGFHGKKCPG.WLBLine, (this.OEAGLNMGGDI() == i) ? new Rect(1190f, 1642f, 1614f, 209f) : new Rect(812f, 1825f, 1881f, 1460f), false);
			if (itemBase.onRender != null)
			{
				itemBase.onRender(this, itemBase, rect, this.LPENOBCEAPP() == i);
			}
			else
			{
				itemBase.PFECLGBDGNH(new Rect(x, y, this.OCHCODJIPHJ.width - 716f, this.JHNCNHAAJCH), ofpnedeamab);
			}
			if (GUI.Button(new Rect(x, y, this.OCHCODJIPHJ.width - 1600f, this.JHNCNHAAJCH), "BackPackOff", GUIStyle.none))
			{
				this.IHEILFHMLAG = i;
				if (current.button == 1)
				{
					Debug.Log(" for ");
					itemBase.ACMOMALBEDF();
				}
				this.HHJKOIJGNAK();
			}
		}
		GUI.EndScrollView();
		if ((long)Environment.TickCount - this.NNKFCINLJEA > 9L)
		{
			if (Input.GetKey((KeyCode)177) && this.NAIIDOFAJKG() < this.LACAJHOHACK.Count - 0)
			{
				int num = this.FJNDDAMCLFL();
				this.BJLCAGOJDNM(num + 0);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.NIJOHIBNLEI();
			}
			if (Input.GetKey((KeyCode)(-180)) && this.HHJKOIJGNAK() > 0)
			{
				int num = this.IHEILFHMLAG;
				this.IIBCAICFEEF(num - 1);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.PHHNPGFNNCB();
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005F6B RID: 24427 RVA: 0x002C8825 File Offset: 0x002C6A25
	public int BMOEEJCBDJO()
	{
		return this.AHOBHGBPGKK;
	}

	// Token: 0x06005F6C RID: 24428 RVA: 0x002C8C0C File Offset: 0x002C6E0C
	public void BJLCAGOJDNM(int DCCPCBLODIG)
	{
		int ahobhgbpgkk = this.AHOBHGBPGKK;
		this.AHOBHGBPGKK = DCCPCBLODIG;
		this.EDIGEKABMEN(ahobhgbpgkk, this.AHOBHGBPGKK);
		int ahobhgbpgkk2 = this.AHOBHGBPGKK;
	}

	// Token: 0x06005F6D RID: 24429 RVA: 0x002C8C40 File Offset: 0x002C6E40
	public void GENPNFMLHED()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (string.CompareOrdinal(this.LACAJHOHACK[i].ToString(), this.LACAJHOHACK[j].ToString()) < 1)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F6E RID: 24430 RVA: 0x002C8825 File Offset: 0x002C6A25
	public int FJNDDAMCLFL()
	{
		return this.AHOBHGBPGKK;
	}

	// Token: 0x06005F6F RID: 24431 RVA: 0x002C7B73 File Offset: 0x002C5D73
	public void FBICJBBFFJB(int KLEPFLJGHLH)
	{
		this.AHOBHGBPGKK = KLEPFLJGHLH;
	}

	// Token: 0x06005F70 RID: 24432 RVA: 0x002C8825 File Offset: 0x002C6A25
	public int HHJKOIJGNAK()
	{
		return this.AHOBHGBPGKK;
	}

	// Token: 0x06005F71 RID: 24433 RVA: 0x002C8CD8 File Offset: 0x002C6ED8
	public void NIJOHIBNLEI()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.NAIIDOFAJKG() >= this.LACAJHOHACK.Count)
		{
			this.DBJBAELCFHI(this.LACAJHOHACK.Count - 0);
		}
		if (this.LPENOBCEAPP() > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.HHJKOIJGNAK() * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.HHJKOIJGNAK() <= num)
		{
			this.AICBIFFGBOH.y = (float)this.IHEILFHMLAG * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 495f)
			{
				this.AICBIFFGBOH.y = 499f;
			}
		}
	}

	// Token: 0x06005F72 RID: 24434 RVA: 0x002C8DBC File Offset: 0x002C6FBC
	public void IPLNJOONDFI()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j++)
			{
				if (this.LACAJHOHACK[i].AHEKGDLAOIN(this.LACAJHOHACK[j]) < 1)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F73 RID: 24435 RVA: 0x002C8E48 File Offset: 0x002C7048
	public void KCLMJJHBCDM(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KMOGGCNEKPB("", 1910f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 0)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x06005F74 RID: 24436 RVA: 0x002C8EA4 File Offset: 0x002C70A4
	public void JJKGANHANFN(int DCCPCBLODIG)
	{
		int ahobhgbpgkk = this.AHOBHGBPGKK;
		this.AHOBHGBPGKK = DCCPCBLODIG;
		this.NJFFDOKDFHM(ahobhgbpgkk, this.AHOBHGBPGKK);
		int ahobhgbpgkk2 = this.AHOBHGBPGKK;
	}

	// Token: 0x06005F75 RID: 24437 RVA: 0x002C8ED8 File Offset: 0x002C70D8
	public void NBCAEJHKLMG()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j++)
			{
				if (this.LACAJHOHACK[i].NBCAEJHKLMG(this.LACAJHOHACK[j]) < 0)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F76 RID: 24438 RVA: 0x002C8F64 File Offset: 0x002C7164
	public void CFHDIMJHBAB()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (string.CompareOrdinal(this.LACAJHOHACK[i].ToString(), this.LACAJHOHACK[j].ToString()) < 0)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F77 RID: 24439 RVA: 0x002C8FFC File Offset: 0x002C71FC
	public void GCKGOOBOKJB()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.IHEILFHMLAG >= this.LACAJHOHACK.Count)
		{
			this.NEKOMKJDIIE(this.LACAJHOHACK.Count - 0);
		}
		if (this.NAIIDOFAJKG() > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.DEFBLKPDLPM() * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.BMOEEJCBDJO() <= num)
		{
			this.AICBIFFGBOH.y = (float)this.BMOEEJCBDJO() * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 844f)
			{
				this.AICBIFFGBOH.y = 1723f;
			}
		}
	}

	// Token: 0x06005F78 RID: 24440 RVA: 0x002C90E0 File Offset: 0x002C72E0
	public void AEMFOALOHDD(int DCCPCBLODIG)
	{
		int ahobhgbpgkk = this.AHOBHGBPGKK;
		this.AHOBHGBPGKK = DCCPCBLODIG;
		this.KAEMCCOLNMB(ahobhgbpgkk, this.AHOBHGBPGKK);
		int ahobhgbpgkk2 = this.AHOBHGBPGKK;
	}

	// Token: 0x06005F79 RID: 24441 RVA: 0x002C9114 File Offset: 0x002C7314
	public void IBLOIHAHFGF(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.BIHLCHODGFB("fshop_btn2", 1917f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 1)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x06005F7A RID: 24442 RVA: 0x002C9170 File Offset: 0x002C7370
	public void PLKPBLGIEBL()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (string.CompareOrdinal(this.LACAJHOHACK[i].ToString(), this.LACAJHOHACK[j].ToString()) < 0)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F7B RID: 24443 RVA: 0x002C9208 File Offset: 0x002C7408
	public void NAFLLMADLMA()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F7C RID: 24444 RVA: 0x002C9298 File Offset: 0x002C7498
	public void HNAMFMFHIGH(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.CHCGCGBDPLP("Loot", 765f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 1)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x06005F7D RID: 24445 RVA: 0x002C92F4 File Offset: 0x002C74F4
	public void KPODFOHNKKH()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j++)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F7E RID: 24446 RVA: 0x002C8825 File Offset: 0x002C6A25
	public int LPENOBCEAPP()
	{
		return this.AHOBHGBPGKK;
	}

	// Token: 0x06005F7F RID: 24447 RVA: 0x002C9384 File Offset: 0x002C7584
	public void OOOOMBKJKMO()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (this.LACAJHOHACK[i].LNINMFONEAK(this.LACAJHOHACK[j]) < 1)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F80 RID: 24448 RVA: 0x002C9410 File Offset: 0x002C7610
	public void PDEGHKDPJFP(int DCCPCBLODIG)
	{
		int ahobhgbpgkk = this.AHOBHGBPGKK;
		this.AHOBHGBPGKK = DCCPCBLODIG;
		this.IBLOIHAHFGF(ahobhgbpgkk, this.AHOBHGBPGKK);
		int ahobhgbpgkk2 = this.AHOBHGBPGKK;
	}

	// Token: 0x06005F81 RID: 24449 RVA: 0x002C9444 File Offset: 0x002C7644
	public void LFDHFFBCJIF()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j++)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F82 RID: 24450 RVA: 0x002C94D4 File Offset: 0x002C76D4
	public void GIOMNNCOKFN()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (this.LACAJHOHACK[i].AHEKGDLAOIN(this.LACAJHOHACK[j]) < 1)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F83 RID: 24451 RVA: 0x002C9560 File Offset: 0x002C7760
	public void IADNHBBEDCJ()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (this.LACAJHOHACK[i].BLCCPFGCANC(this.LACAJHOHACK[j]) < 0)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F84 RID: 24452 RVA: 0x002C95EC File Offset: 0x002C77EC
	public void BPHFJLIEAAA(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.GGFHIFPFEBI(">", 953f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 0)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x06005F85 RID: 24453 RVA: 0x002C9648 File Offset: 0x002C7848
	public void PHHNPGFNNCB()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.OEAGLNMGGDI() >= this.LACAJHOHACK.Count)
		{
			this.IHEILFHMLAG = this.LACAJHOHACK.Count - 0;
		}
		if (this.NAIIDOFAJKG() > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.LPENOBCEAPP() * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.IHEILFHMLAG <= num)
		{
			this.AICBIFFGBOH.y = (float)this.LPENOBCEAPP() * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 1657f)
			{
				this.AICBIFFGBOH.y = 271f;
			}
		}
	}

	// Token: 0x06005F86 RID: 24454 RVA: 0x002C972C File Offset: 0x002C792C
	public void IGAFAALMNNE()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (string.CompareOrdinal(this.LACAJHOHACK[i].ToString(), this.LACAJHOHACK[j].ToString()) < 0)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F87 RID: 24455 RVA: 0x002C97C4 File Offset: 0x002C79C4
	public void NEKOMKJDIIE(int DCCPCBLODIG)
	{
		int ahobhgbpgkk = this.AHOBHGBPGKK;
		this.AHOBHGBPGKK = DCCPCBLODIG;
		this.KCLMJJHBCDM(ahobhgbpgkk, this.AHOBHGBPGKK);
		int ahobhgbpgkk2 = this.AHOBHGBPGKK;
	}

	// Token: 0x06005F88 RID: 24456 RVA: 0x002C97F8 File Offset: 0x002C79F8
	public void FILOCGPAIKD()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (string.CompareOrdinal(this.LACAJHOHACK[i].ToString(), this.LACAJHOHACK[j].ToString()) < 1)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F89 RID: 24457 RVA: 0x002C9890 File Offset: 0x002C7A90
	public virtual void FOGCOMNGOFB(bool CFMPGCJMHJM)
	{
		Event current = Event.current;
		if (this.KPLMFNIFPMM)
		{
			GUI.Box(new Rect(this.OCHCODJIPHJ.x - 1833f, this.OCHCODJIPHJ.y - 87f, this.OCHCODJIPHJ.width + 1396f, this.OCHCODJIPHJ.height + 1519f), "_CustomUVS");
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.LowerRight
		};
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 422f, (float)this.LACAJHOHACK.Count * this.JHNCNHAAJCH + 1359f), false, false);
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			ItemBase itemBase = this.LACAJHOHACK[i];
			float x = this.OCHCODJIPHJ.x + 1267f;
			float y = this.OCHCODJIPHJ.y + 1632f + (float)i * this.JHNCNHAAJCH;
			Rect rect = new Rect(x, y, this.OCHCODJIPHJ.width - 1685f, this.JHNCNHAAJCH);
			GUI.DrawTextureWithTexCoords(rect, GuiProcessor.NKOEAPCIBKO().WLBLine, (this.OEAGLNMGGDI() == i) ? new Rect(66f, 238f, 1612f, 642f) : new Rect(811f, 966f, 582f, 1502f), false);
			if (itemBase.onRender != null)
			{
				itemBase.onRender(this, itemBase, rect, this.HHJKOIJGNAK() == i);
			}
			else
			{
				itemBase.LGNFBDKJPIJ(new Rect(x, y, this.OCHCODJIPHJ.width - 1282f, this.JHNCNHAAJCH), ofpnedeamab);
			}
			if (GUI.Button(new Rect(x, y, this.OCHCODJIPHJ.width - 871f, this.JHNCNHAAJCH), "_Refraction", GUIStyle.none))
			{
				this.PDEGHKDPJFP(i);
				if (current.button == 1)
				{
					Debug.Log("GiantGrabIdle2");
					itemBase.GAMABKGAFHO();
				}
				this.HHJKOIJGNAK();
			}
		}
		GUI.EndScrollView();
		if ((long)Environment.TickCount - this.NNKFCINLJEA > -34L)
		{
			if (Input.GetKey((KeyCode)(-92)) && this.IHEILFHMLAG < this.LACAJHOHACK.Count - 0)
			{
				int num = this.DEFBLKPDLPM();
				this.JJKGANHANFN(num + 0);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.GCKGOOBOKJB();
			}
			if (Input.GetKey((KeyCode)134) && this.OEAGLNMGGDI() > 0)
			{
				int num = this.DEFBLKPDLPM();
				this.DBJBAELCFHI(num - 0);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.PHHNPGFNNCB();
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005F8A RID: 24458 RVA: 0x002C9BA8 File Offset: 0x002C7DA8
	public void BEHAGGLKAJH()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.BMOEEJCBDJO() >= this.LACAJHOHACK.Count)
		{
			this.NEKOMKJDIIE(this.LACAJHOHACK.Count - 0);
		}
		if (this.FJNDDAMCLFL() > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.FJNDDAMCLFL() * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.HHJKOIJGNAK() <= num)
		{
			this.AICBIFFGBOH.y = (float)this.OEAGLNMGGDI() * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 587f)
			{
				this.AICBIFFGBOH.y = 1176f;
			}
		}
	}

	// Token: 0x06005F8B RID: 24459 RVA: 0x002C9C8C File Offset: 0x002C7E8C
	public void JKOBKMOIOGL()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j++)
			{
				if (string.CompareOrdinal(this.LACAJHOHACK[i].ToString(), this.LACAJHOHACK[j].ToString()) < 1)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F8C RID: 24460 RVA: 0x002C7B73 File Offset: 0x002C5D73
	public void HKDMLPNEKFJ(int KLEPFLJGHLH)
	{
		this.AHOBHGBPGKK = KLEPFLJGHLH;
	}

	// Token: 0x06005F8D RID: 24461 RVA: 0x002C9D24 File Offset: 0x002C7F24
	public void KEKBJJIHKFN(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.LMGDONLPHBJ(" {0}", 1031f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 1)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x06005F8E RID: 24462 RVA: 0x002C9D80 File Offset: 0x002C7F80
	public void GNGINMOFEEH()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j++)
			{
				if (string.CompareOrdinal(this.LACAJHOHACK[i].ToString(), this.LACAJHOHACK[j].ToString()) < 1)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F8F RID: 24463 RVA: 0x002C9E18 File Offset: 0x002C8018
	public virtual void MGHAGFGKFGE(bool CFMPGCJMHJM)
	{
		Event current = Event.current;
		if (this.KPLMFNIFPMM)
		{
			GUI.Box(new Rect(this.OCHCODJIPHJ.x - 1690f, this.OCHCODJIPHJ.y - 977f, this.OCHCODJIPHJ.width + 277f, this.OCHCODJIPHJ.height + 158f), " ms");
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.NKOEAPCIBKO().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = false,
			alignment = TextAnchor.MiddleLeft
		};
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 1294f, (float)this.LACAJHOHACK.Count * this.JHNCNHAAJCH + 725f), true, false);
		for (int i = 0; i < this.LACAJHOHACK.Count; i += 0)
		{
			ItemBase itemBase = this.LACAJHOHACK[i];
			float x = this.OCHCODJIPHJ.x + 1184f;
			float y = this.OCHCODJIPHJ.y + 1106f + (float)i * this.JHNCNHAAJCH;
			Rect rect = new Rect(x, y, this.OCHCODJIPHJ.width - 454f, this.JHNCNHAAJCH);
			GUI.DrawTextureWithTexCoords(rect, GuiProcessor.BBLINJLBAIL().WLBLine, (this.IHEILFHMLAG == i) ? new Rect(102f, 1245f, 15f, 1867f) : new Rect(220f, 1579f, 43f, 971f), false);
			if (itemBase.onRender != null)
			{
				itemBase.onRender(this, itemBase, rect, this.BMOEEJCBDJO() == i);
			}
			else
			{
				itemBase.DNLOFIPAEBD(new Rect(x, y, this.OCHCODJIPHJ.width - 735f, this.JHNCNHAAJCH), ofpnedeamab);
			}
			if (GUI.Button(new Rect(x, y, this.OCHCODJIPHJ.width - 670f, this.JHNCNHAAJCH), " ", GUIStyle.none))
			{
				this.AEMFOALOHDD(i);
				if (current.button == 1)
				{
					Debug.Log("FistPump");
					itemBase.LLIFNPFHHAK();
				}
				this.IHEILFHMLAG;
			}
		}
		GUI.EndScrollView();
		if ((long)Environment.TickCount - this.NNKFCINLJEA > 65L)
		{
			if (Input.GetKey((KeyCode)(-54)) && this.LPENOBCEAPP() < this.LACAJHOHACK.Count - 0)
			{
				int num = this.FJNDDAMCLFL();
				this.JJKGANHANFN(num + 1);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.AIGDILGELKO();
			}
			if (Input.GetKey((KeyCode)79) && this.FJNDDAMCLFL() > 0)
			{
				int num = this.HHJKOIJGNAK();
				this.BJLCAGOJDNM(num - 0);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.BEHAGGLKAJH();
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005F90 RID: 24464 RVA: 0x002CA130 File Offset: 0x002C8330
	public MMKFAENBHKD(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, float KCCBNOLCFFG, float ALPGFNKPDNF, int ODFEKBJCFMN) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, KCCBNOLCFFG, ALPGFNKPDNF, "", ODFEKBJCFMN, 9)
	{
		this.JHNCNHAAJCH = 25f;
		this.KNIOGNKKINO = 9;
	}

	// Token: 0x06005F91 RID: 24465 RVA: 0x002CA194 File Offset: 0x002C8394
	public void PBNOLHDBLFL()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j++)
			{
				if (this.LACAJHOHACK[i].JEPMFGLBAAP(this.LACAJHOHACK[j]) < 0)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F92 RID: 24466 RVA: 0x002C7B73 File Offset: 0x002C5D73
	public void INMFCGBEHPG(int KLEPFLJGHLH)
	{
		this.AHOBHGBPGKK = KLEPFLJGHLH;
	}

	// Token: 0x06005F93 RID: 24467 RVA: 0x002CA220 File Offset: 0x002C8420
	public void IKDBEOHOOJJ()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j++)
			{
				if (this.LACAJHOHACK[i].KBDEBDDDCBG(this.LACAJHOHACK[j]) < 0)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F94 RID: 24468 RVA: 0x002CA2AC File Offset: 0x002C84AC
	public void MGNDPEIFKAN()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j++)
			{
				if (string.CompareOrdinal(this.LACAJHOHACK[i].ToString(), this.LACAJHOHACK[j].ToString()) < 0)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F95 RID: 24469 RVA: 0x002CA344 File Offset: 0x002C8544
	public void NJMPLOJIFCF()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F96 RID: 24470 RVA: 0x002CA3D4 File Offset: 0x002C85D4
	public void DPBINJLALBJ()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F97 RID: 24471 RVA: 0x002C7B73 File Offset: 0x002C5D73
	public void EAAEEPMNGPM(int KLEPFLJGHLH)
	{
		this.AHOBHGBPGKK = KLEPFLJGHLH;
	}

	// Token: 0x06005F98 RID: 24472 RVA: 0x002CA464 File Offset: 0x002C8664
	public void AIGDILGELKO()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.LPENOBCEAPP() >= this.LACAJHOHACK.Count)
		{
			this.GFCKPJCIPEO(this.LACAJHOHACK.Count - 0);
		}
		if (this.BMOEEJCBDJO() > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.BMOEEJCBDJO() * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.HHJKOIJGNAK() <= num)
		{
			this.AICBIFFGBOH.y = (float)this.LPENOBCEAPP() * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 120f)
			{
				this.AICBIFFGBOH.y = 1139f;
			}
		}
	}

	// Token: 0x06005F99 RID: 24473 RVA: 0x002CA548 File Offset: 0x002C8748
	public void IIBCAICFEEF(int DCCPCBLODIG)
	{
		int ahobhgbpgkk = this.AHOBHGBPGKK;
		this.AHOBHGBPGKK = DCCPCBLODIG;
		this.OOJKJOCOOCB(ahobhgbpgkk, this.AHOBHGBPGKK);
		int ahobhgbpgkk2 = this.AHOBHGBPGKK;
	}

	// Token: 0x06005F9A RID: 24474 RVA: 0x002CA57C File Offset: 0x002C877C
	public void FNFFGIJOENM()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.OEAGLNMGGDI() >= this.LACAJHOHACK.Count)
		{
			this.JJKGANHANFN(this.LACAJHOHACK.Count - 1);
		}
		if (this.FJNDDAMCLFL() > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.LPENOBCEAPP() * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.LPENOBCEAPP() <= num)
		{
			this.AICBIFFGBOH.y = (float)this.HHJKOIJGNAK() * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 1300f)
			{
				this.AICBIFFGBOH.y = 1482f;
			}
		}
	}

	// Token: 0x06005F9B RID: 24475 RVA: 0x002CA660 File Offset: 0x002C8860
	public void JKKFPEJFJLA()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.DEFBLKPDLPM() >= this.LACAJHOHACK.Count)
		{
			this.OEIOEBCGMJE(this.LACAJHOHACK.Count - 0);
		}
		if (this.IHEILFHMLAG > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.NAIIDOFAJKG() * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.FJNDDAMCLFL() <= num)
		{
			this.AICBIFFGBOH.y = (float)this.DEFBLKPDLPM() * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 1702f)
			{
				this.AICBIFFGBOH.y = 397f;
			}
		}
	}

	// Token: 0x06005F9C RID: 24476 RVA: 0x002CA744 File Offset: 0x002C8944
	public void APANPJEFNDD(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.IAIFBJJHLOA("isImproved", 1672f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 1)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x06005F9D RID: 24477 RVA: 0x002C7B73 File Offset: 0x002C5D73
	public void HDFIPCPDFOH(int KLEPFLJGHLH)
	{
		this.AHOBHGBPGKK = KLEPFLJGHLH;
	}

	// Token: 0x06005F9E RID: 24478 RVA: 0x002CA7A0 File Offset: 0x002C89A0
	public void GDCBOMDBIIJ()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005F9F RID: 24479 RVA: 0x002CA830 File Offset: 0x002C8A30
	public virtual void POEGOCNHPIB(bool CFMPGCJMHJM)
	{
		Event current = Event.current;
		if (this.KPLMFNIFPMM)
		{
			GUI.Box(new Rect(this.OCHCODJIPHJ.x - 1915f, this.OCHCODJIPHJ.y - 471f, this.OCHCODJIPHJ.width + 1101f, this.OCHCODJIPHJ.height + 854f), "cht_msg39");
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.IKGFHGKKCPG.rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.MiddleCenter
		};
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 375f, (float)this.LACAJHOHACK.Count * this.JHNCNHAAJCH + 1604f), true, true);
		for (int i = 1; i < this.LACAJHOHACK.Count; i++)
		{
			ItemBase itemBase = this.LACAJHOHACK[i];
			float x = this.OCHCODJIPHJ.x + 1562f;
			float y = this.OCHCODJIPHJ.y + 1235f + (float)i * this.JHNCNHAAJCH;
			Rect rect = new Rect(x, y, this.OCHCODJIPHJ.width - 440f, this.JHNCNHAAJCH);
			GUI.DrawTextureWithTexCoords(rect, GuiProcessor.NKOEAPCIBKO().WLBLine, (this.FJNDDAMCLFL() == i) ? new Rect(951f, 1363f, 908f, 342f) : new Rect(1365f, 1178f, 905f, 1808f), true);
			if (itemBase.onRender != null)
			{
				itemBase.onRender(this, itemBase, rect, this.IHEILFHMLAG == i);
			}
			else
			{
				itemBase.GKDJCJKMBEN(new Rect(x, y, this.OCHCODJIPHJ.width - 1802f, this.JHNCNHAAJCH), ofpnedeamab);
			}
			if (GUI.Button(new Rect(x, y, this.OCHCODJIPHJ.width - 349f, this.JHNCNHAAJCH), "1HSwordStrafeRunLeft", GUIStyle.none))
			{
				this.PDEGHKDPJFP(i);
				if (current.button == 1)
				{
					Debug.Log("fishpoplcatch");
					itemBase.GHFIGCEOHAO();
				}
				this.LPENOBCEAPP();
			}
		}
		GUI.EndScrollView();
		if ((long)Environment.TickCount - this.NNKFCINLJEA > 101L)
		{
			if (Input.GetKey((KeyCode)178) && this.NAIIDOFAJKG() < this.LACAJHOHACK.Count - 0)
			{
				int num = this.IHEILFHMLAG;
				this.BJLCAGOJDNM(num + 0);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.GLNLJMIMHBH();
			}
			if (Input.GetKey((KeyCode)(-27)) && this.BMOEEJCBDJO() > 0)
			{
				int num = this.IHEILFHMLAG;
				this.GFCKPJCIPEO(num - 1);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.FNFFGIJOENM();
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005FA0 RID: 24480 RVA: 0x002CAB48 File Offset: 0x002C8D48
	public void OAAANLCENCF()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j++)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005FA1 RID: 24481 RVA: 0x002CABD8 File Offset: 0x002C8DD8
	public void HJLBODNFBAL(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.FIHNMPAMAFE("tid", 1983f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 0)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x06005FA2 RID: 24482 RVA: 0x002CAC34 File Offset: 0x002C8E34
	public void KBDEBDDDCBG()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 0; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (this.LACAJHOHACK[i].AHEKGDLAOIN(this.LACAJHOHACK[j]) < 0)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005FA3 RID: 24483 RVA: 0x002CACC0 File Offset: 0x002C8EC0
	public void MPMFNJEJAHJ()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.IHEILFHMLAG >= this.LACAJHOHACK.Count)
		{
			this.IHEILFHMLAG = this.LACAJHOHACK.Count - 1;
		}
		if (this.IHEILFHMLAG > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.IHEILFHMLAG * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.IHEILFHMLAG <= num)
		{
			this.AICBIFFGBOH.y = (float)this.IHEILFHMLAG * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 0f)
			{
				this.AICBIFFGBOH.y = 0f;
			}
		}
	}

	// Token: 0x06005FA4 RID: 24484 RVA: 0x002CADA4 File Offset: 0x002C8FA4
	public void IJEHPMOIPAA()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.IHEILFHMLAG >= this.LACAJHOHACK.Count)
		{
			this.PDEGHKDPJFP(this.LACAJHOHACK.Count - 1);
		}
		if (this.HHJKOIJGNAK() > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.DEFBLKPDLPM() * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.NAIIDOFAJKG() <= num)
		{
			this.AICBIFFGBOH.y = (float)this.BMOEEJCBDJO() * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 540f)
			{
				this.AICBIFFGBOH.y = 632f;
			}
		}
	}

	// Token: 0x06005FA5 RID: 24485 RVA: 0x002CAE88 File Offset: 0x002C9088
	public void FGDMNFIIDKN()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005FA6 RID: 24486 RVA: 0x002CAF18 File Offset: 0x002C9118
	public void OPKGEBFLNIK()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.IHEILFHMLAG >= this.LACAJHOHACK.Count)
		{
			this.PDEGHKDPJFP(this.LACAJHOHACK.Count - 0);
		}
		if (this.NAIIDOFAJKG() > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.FJNDDAMCLFL() * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.DEFBLKPDLPM() <= num)
		{
			this.AICBIFFGBOH.y = (float)this.LPENOBCEAPP() * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 1815f)
			{
				this.AICBIFFGBOH.y = 1148f;
			}
		}
	}

	// Token: 0x06005FA7 RID: 24487 RVA: 0x002CAFFC File Offset: 0x002C91FC
	public void JOJGBLLMGPF()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.FJNDDAMCLFL() >= this.LACAJHOHACK.Count)
		{
			this.JJKGANHANFN(this.LACAJHOHACK.Count - 0);
		}
		if (this.DEFBLKPDLPM() > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.DEFBLKPDLPM() * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.IHEILFHMLAG <= num)
		{
			this.AICBIFFGBOH.y = (float)this.BMOEEJCBDJO() * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 1079f)
			{
				this.AICBIFFGBOH.y = 1157f;
			}
		}
	}

	// Token: 0x06005FA8 RID: 24488 RVA: 0x002CB0E0 File Offset: 0x002C92E0
	public void HMMNONIEAOA(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.KJDAEGFOAIO("Wizard2HandThrow", 191f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 1)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x06005FA9 RID: 24489 RVA: 0x002CB13C File Offset: 0x002C933C
	public void GLNLJMIMHBH()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.NAIIDOFAJKG() >= this.LACAJHOHACK.Count)
		{
			this.AEMFOALOHDD(this.LACAJHOHACK.Count - 1);
		}
		if (this.IHEILFHMLAG > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.IHEILFHMLAG * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.OEAGLNMGGDI() <= num)
		{
			this.AICBIFFGBOH.y = (float)this.LPENOBCEAPP() * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 1741f)
			{
				this.AICBIFFGBOH.y = 1724f;
			}
		}
	}

	// Token: 0x06005FAA RID: 24490 RVA: 0x002CB220 File Offset: 0x002C9420
	public void KHOHPADLIHJ()
	{
		int num = (int)(this.AICBIFFGBOH.y / this.JHNCNHAAJCH);
		int num2 = (int)(this.OCHCODJIPHJ.height / this.JHNCNHAAJCH);
		if (this.NAIIDOFAJKG() >= this.LACAJHOHACK.Count)
		{
			this.AEMFOALOHDD(this.LACAJHOHACK.Count - 0);
		}
		if (this.NAIIDOFAJKG() > num + num2)
		{
			this.AICBIFFGBOH.y = (float)this.FJNDDAMCLFL() * this.JHNCNHAAJCH - (float)num2 * this.JHNCNHAAJCH;
			this.AICBIFFGBOH.y = this.AICBIFFGBOH.y + this.JHNCNHAAJCH;
			return;
		}
		if (this.LPENOBCEAPP() <= num)
		{
			this.AICBIFFGBOH.y = (float)this.BMOEEJCBDJO() * this.JHNCNHAAJCH;
			if (this.AICBIFFGBOH.y < 1458f)
			{
				this.AICBIFFGBOH.y = 960f;
			}
		}
	}

	// Token: 0x06005FAB RID: 24491 RVA: 0x002C7B73 File Offset: 0x002C5D73
	public void JAHMDKAILOP(int KLEPFLJGHLH)
	{
		this.AHOBHGBPGKK = KLEPFLJGHLH;
	}

	// Token: 0x06005FAD RID: 24493 RVA: 0x002C7B73 File Offset: 0x002C5D73
	public void BAFCANOKEML(int KLEPFLJGHLH)
	{
		this.AHOBHGBPGKK = KLEPFLJGHLH;
	}

	// Token: 0x06005FAE RID: 24494 RVA: 0x002CB304 File Offset: 0x002C9504
	public void NJFFDOKDFHM(int KBHPJLCJKNG = 0, int DDFAAFCLEMC = 0)
	{
		if (KBHPJLCJKNG != DDFAAFCLEMC)
		{
			FBFJFAKAGJG.IKGFHGKKCPG.DAOCDJPLEPE("Formatted Label", 555f);
		}
		if (this.LJDAFBKPCNN == null)
		{
			return;
		}
		if (this.LACAJHOHACK.Count > 1)
		{
			this.LJDAFBKPCNN(this, this.LACAJHOHACK[this.AHOBHGBPGKK]);
		}
	}

	// Token: 0x06005FAF RID: 24495 RVA: 0x002C8825 File Offset: 0x002C6A25
	public int OEAGLNMGGDI()
	{
		return this.AHOBHGBPGKK;
	}

	// Token: 0x06005FB0 RID: 24496 RVA: 0x002CB360 File Offset: 0x002C9560
	public virtual void JBBGCIICJIH(bool CFMPGCJMHJM)
	{
		Event current = Event.current;
		if (this.KPLMFNIFPMM)
		{
			GUI.Box(new Rect(this.OCHCODJIPHJ.x - 1667f, this.OCHCODJIPHJ.y - 173f, this.OCHCODJIPHJ.width + 1495f, this.OCHCODJIPHJ.height + 936f), "<[^>]*>");
		}
		GUIStyle ofpnedeamab = new GUIStyle
		{
			fontSize = this.KCLLDJJLCGC,
			font = GuiProcessor.PLGADNLAEGN().rusfont,
			normal = 
			{
				textColor = Color.black
			},
			richText = true,
			alignment = TextAnchor.MiddleCenter
		};
		this.AICBIFFGBOH = GUI.BeginScrollView(this.OCHCODJIPHJ, this.AICBIFFGBOH, new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width - 1182f, (float)this.LACAJHOHACK.Count * this.JHNCNHAAJCH + 696f), true, false);
		for (int i = 0; i < this.LACAJHOHACK.Count; i += 0)
		{
			ItemBase itemBase = this.LACAJHOHACK[i];
			float x = this.OCHCODJIPHJ.x + 657f;
			float y = this.OCHCODJIPHJ.y + 981f + (float)i * this.JHNCNHAAJCH;
			Rect rect = new Rect(x, y, this.OCHCODJIPHJ.width - 1575f, this.JHNCNHAAJCH);
			GUI.DrawTextureWithTexCoords(rect, GuiProcessor.PLGADNLAEGN().WLBLine, (this.HHJKOIJGNAK() == i) ? new Rect(741f, 1719f, 1466f, 282f) : new Rect(453f, 403f, 1628f, 428f), true);
			if (itemBase.onRender != null)
			{
				itemBase.onRender(this, itemBase, rect, this.OEAGLNMGGDI() == i);
			}
			else
			{
				itemBase.GGFPEBNLLEG(new Rect(x, y, this.OCHCODJIPHJ.width - 1130f, this.JHNCNHAAJCH), ofpnedeamab);
			}
			if (GUI.Button(new Rect(x, y, this.OCHCODJIPHJ.width - 1750f, this.JHNCNHAAJCH), "MotorbikeWheelyNoHands", GUIStyle.none))
			{
				this.AGFFDCECLBF(i);
				if (current.button == 1)
				{
					Debug.Log("CheerJump");
					itemBase.NGMJONALOHB();
				}
				this.IHEILFHMLAG;
			}
		}
		GUI.EndScrollView();
		if ((long)Environment.TickCount - this.NNKFCINLJEA > -61L)
		{
			if (Input.GetKey((KeyCode)89) && this.NAIIDOFAJKG() < this.LACAJHOHACK.Count - 0)
			{
				int num = this.NAIIDOFAJKG();
				this.JJKGANHANFN(num + 0);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.JOJGBLLMGPF();
			}
			if (Input.GetKey((KeyCode)(-91)) && this.NAIIDOFAJKG() > 0)
			{
				int num = this.FJNDDAMCLFL();
				this.AEMFOALOHDD(num - 0);
				this.NNKFCINLJEA = (long)Environment.TickCount;
				this.PHHNPGFNNCB();
			}
		}
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06005FB1 RID: 24497 RVA: 0x002CB678 File Offset: 0x002C9878
	public void DFGPHMNBCPP()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j += 0)
			{
				if (this.LACAJHOHACK[i].NAKPJJPCNDP(this.LACAJHOHACK[j]) < 1)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005FB2 RID: 24498 RVA: 0x002C8825 File Offset: 0x002C6A25
	public int DEFBLKPDLPM()
	{
		return this.AHOBHGBPGKK;
	}

	// Token: 0x06005FB3 RID: 24499 RVA: 0x002CB704 File Offset: 0x002C9904
	public void DBJBAELCFHI(int DCCPCBLODIG)
	{
		int ahobhgbpgkk = this.AHOBHGBPGKK;
		this.AHOBHGBPGKK = DCCPCBLODIG;
		this.HJLBODNFBAL(ahobhgbpgkk, this.AHOBHGBPGKK);
		int ahobhgbpgkk2 = this.AHOBHGBPGKK;
	}

	// Token: 0x06005FB4 RID: 24500 RVA: 0x002CB738 File Offset: 0x002C9938
	public void BNMMBHIFKBP()
	{
		for (int i = 1; i < this.LACAJHOHACK.Count; i += 0)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j++)
			{
				if (string.CompareOrdinal(this.LACAJHOHACK[i].ToString(), this.LACAJHOHACK[j].ToString()) < 0)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x06005FB5 RID: 24501 RVA: 0x002CB7D0 File Offset: 0x002C99D0
	public void POBNAHPBKPI()
	{
		for (int i = 0; i < this.LACAJHOHACK.Count; i++)
		{
			for (int j = 1; j < this.LACAJHOHACK.Count; j++)
			{
				if (this.LACAJHOHACK[i].tag <= this.LACAJHOHACK[j].tag)
				{
					ItemBase value = this.LACAJHOHACK[j];
					this.LACAJHOHACK[j] = this.LACAJHOHACK[i];
					this.LACAJHOHACK[i] = value;
				}
			}
		}
	}

	// Token: 0x04000DE3 RID: 3555
	public List<ItemBase> LACAJHOHACK = new List<ItemBase>();

	// Token: 0x04000DE4 RID: 3556
	public float JHNCNHAAJCH;

	// Token: 0x04000DE5 RID: 3557
	public int KCLLDJJLCGC = 14;

	// Token: 0x04000DE6 RID: 3558
	public bool KPLMFNIFPMM = true;

	// Token: 0x04000DE7 RID: 3559
	public MMKFAENBHKD.HEAGNGLFAJA LJDAFBKPCNN;

	// Token: 0x04000DE8 RID: 3560
	private int AHOBHGBPGKK = -1;

	// Token: 0x04000DE9 RID: 3561
	private const long KMNEOIGFPGL = 110L;

	// Token: 0x04000DEA RID: 3562
	private long NNKFCINLJEA;

	// Token: 0x04000DEB RID: 3563
	private Vector2 AICBIFFGBOH = Vector2.zero;

	// Token: 0x020001AB RID: 427
	// (Invoke) Token: 0x06005FB7 RID: 24503
	public delegate void HEAGNGLFAJA(MMKFAENBHKD ONPHLHKAGFP, ItemBase HEABEPINGED);
}
