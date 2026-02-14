using System;
using UnityEngine;

// Token: 0x020001BF RID: 447
public class GINEDLOJIIF : ONKDCGNBALK
{
	// Token: 0x06006401 RID: 25601 RVA: 0x002EAF0C File Offset: 0x002E910C
	public virtual void DBHACAENJOE(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleCenter
			};
			guistyle.fontSize = -15;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, true) + "WeaponStrafeRunRight";
			float num = 1630f;
			float num2 = 973f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 79f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1039f, this.OCHCODJIPHJ.y, 632f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter
				};
				guistyle2.fontSize = 69;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "cancel";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "<color=\"#02C85F\"><b>ObscuredPrefs:</b></color>\nsecure, lot of additional types and extra options" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(true, -1);
				string text2 = "Failed parsing atlas group.  Setting to group 0";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text2 = "Wizard1HandThrow" + num3 + "Player";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "demoVector2" + text2 + "_WaterLevel";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "wpn_line2" + text2 + "{0:0.0%}";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1660f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006402 RID: 25602 RVA: 0x002EB1A4 File Offset: 0x002E93A4
	public virtual void DLBGNLEIMPB(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleLeft
			};
			guistyle.fontSize = -67;
			string text = JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(1L, (long)this.BENMNNMGHGJ, false) + "CUSTOM_COLOR_OFF";
			float num = 303f;
			float num2 = 1191f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1830f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 702f, this.OCHCODJIPHJ.y, 381f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerLeft
				};
				guistyle2.fontSize = -16;
				guistyle2.wordWrap = true;
				guistyle2.richText = true;
				string str = "RollerBladeJump";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "cht_msg38" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(true, -1);
				string text2 = "_WrinkleOcclusionStrengths";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "************ reelPoint set manually" + num3 + "[X]";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "ZombieWalk" + text2 + "setCurrentProfil sm=";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "ComeHere" + text2 + "gi_tit_chy";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 239f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006403 RID: 25603 RVA: 0x002EB43C File Offset: 0x002E963C
	public virtual void FCCFIHJKFNK(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleRight
			};
			guistyle.fontSize = -9;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(1L, (long)this.BENMNNMGHGJ, false) + "wpn_bait_typ_{0}";
			float num = 1282f;
			float num2 = 382f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1814f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1019f, this.OCHCODJIPHJ.y, 1484f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerRight
				};
				guistyle2.fontSize = 57;
				guistyle2.wordWrap = false;
				guistyle2.richText = true;
				string str = "";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "Ошибка создания предмета" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(false, -1);
				string text2 = "IdleWalk";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "\n" + num3 + "";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "Color Grading Log LUT" + text2 + "Idle Ready";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "_TempRT" + text2 + "AUTO_KEY_VALUE";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 161f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006404 RID: 25604 RVA: 0x002EB6D4 File Offset: 0x002E98D4
	public virtual void OLHEECEMJDD(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerCenter
			};
			guistyle.fontSize = 119;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(1L, (long)this.BENMNNMGHGJ, true) + "StaffStand";
			float num = 1863f;
			float num2 = 440f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1714f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1830f, this.OCHCODJIPHJ.y, 1863f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperCenter
				};
				guistyle2.fontSize = 69;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "RollerBladeTurnRight";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "How your lives count is stored in memory when obscured:\n" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text2 = "Fly Right";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text2 = "invn_rec15" + num3 + "RunBackward";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "noShowPopl" + text2 + ",";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "inv_money" + text2 + "Current fog preset: ";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 772f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006405 RID: 25605 RVA: 0x002EB96C File Offset: 0x002E9B6C
	public virtual void FMBBLFIGPGL(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleCenter
			};
			guistyle.fontSize = -106;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(0L, (long)this.BENMNNMGHGJ, true) + "OneHandSwordIdle";
			float num = 1948f;
			float num2 = 461f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1727f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 16f, this.OCHCODJIPHJ.y, 672f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerCenter
				};
				guistyle2.fontSize = 26;
				guistyle2.wordWrap = true;
				guistyle2.richText = true;
				string str = "";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "Invalid references, one or more Transforms are missing." + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(false, -1);
				string text2 = "and |assert |break |class |continue |def |del |elif |else |except |exec |finally |for |from |global |if |import |in |is |lambda |not |or |pass |print |raise |return |try |while |yield |None |True |False ";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text2 = "WalkInjured" + num3 + "invn_rec28";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "_Gamma" + text2 + "?";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = " гр " + text2 + "25";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 13f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006406 RID: 25606 RVA: 0x002EBC04 File Offset: 0x002E9E04
	public virtual void ECLJBBPGNPA(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleRight
			};
			guistyle.fontSize = -62;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(1L, (long)this.BENMNNMGHGJ, false) + "";
			float num = 29f;
			float num2 = 796f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1647f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1904f, this.OCHCODJIPHJ.y, 1843f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperCenter
				};
				guistyle2.fontSize = -88;
				guistyle2.wordWrap = true;
				guistyle2.richText = true;
				string str = "MotorbikeShootFwd";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "_TreatBackfaceHitAsMiss" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(true, -1);
				string text2 = "Rooms SET END";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "Textures/Fish/" + num3 + " not found in resource";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "wpn_med1" + text2 + "1HandSwordShieldBash";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "ClimbLeft" + text2 + "/";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 133f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006407 RID: 25607 RVA: 0x002EBE9C File Offset: 0x002EA09C
	public virtual void ENCCJFKCHIE(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperRight
			};
			guistyle.fontSize = -39;
			string text = JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM(1L, (long)this.BENMNNMGHGJ, false) + "gi_um_lim";
			float num = 517f;
			float num2 = 1718f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 131f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1806f, this.OCHCODJIPHJ.y, 1992f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerLeft
				};
				guistyle2.fontSize = 81;
				guistyle2.wordWrap = true;
				guistyle2.richText = true;
				string str = "";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "_SceneFogParams" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(true, -1);
				string text2 = "Antares Console";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.PLGADNLAEGN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text2 = "OfficeSittingLegCross" + num3 + "CrouchStrafeLeft";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "KatanaReady" + text2 + "";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "wpn_line3" + text2 + "";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1116f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006408 RID: 25608 RVA: 0x002EC134 File Offset: 0x002EA334
	public virtual void KNCJKEEICGO(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleRight
			};
			guistyle.fontSize = 78;
			string text = JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(0L, (long)this.BENMNNMGHGJ, true) + "wpn_cat2";
			float num = 1018f;
			float num2 = 36f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1386f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 899f, this.OCHCODJIPHJ.y, 1639f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter
				};
				guistyle2.fontSize = -27;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "USER";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "SatNightFever" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text2 = "SwimDogPaddle";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "Trying to use the 'Arm' bend modifier on a leg." + num3 + "wpn_add/addperks/addPerk";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "MotorbikeHeadstand" + text2 + "MotorbikeLasso";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "FishbragContainer" + text2 + "X";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 363f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006409 RID: 25609 RVA: 0x002EC3CC File Offset: 0x002EA5CC
	public virtual void NEHJDJAAMEO(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleRight
			};
			guistyle.fontSize = 93;
			string text = JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, true) + "Bow Fire";
			float num = 764f;
			float num2 = 269f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 751f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 668f, this.OCHCODJIPHJ.y, 1202f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter
				};
				guistyle2.fontSize = 37;
				guistyle2.wordWrap = true;
				guistyle2.richText = true;
				string str = "17";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "SoccerSprint" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text2 = "SkateboardIdle";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text2 = "rait_1" + num3 + "Explosions";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "paper.wav" + text2 + "<color='";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "WeaponReady" + text2 + "<color='#000000'>{0}</color>";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1835f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600640A RID: 25610 RVA: 0x002EC664 File Offset: 0x002EA864
	public virtual void BLGIOPMGMPG(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperRight
			};
			guistyle.fontSize = -23;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, (long)this.BENMNNMGHGJ, false) + "#a02000";
			float num = 1907f;
			float num2 = 1049f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1348f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1f, this.OCHCODJIPHJ.y, 755f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerRight
				};
				guistyle2.fontSize = -78;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "auc_toauk";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_full_body_biped_i_k.html" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(false, -1);
				string text2 = "BUMPED";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text2 = "http://forum.unity3d.com/threads/final-ik-full-body-ik-aim-look-at-fabrik-ccd-ik-1-0-released.222685/" + num3 + "_BlurRadius4";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "level" + text2 + "Mouse Y";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "" + text2 + "RandomizeObscuredVars";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1439f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600640B RID: 25611 RVA: 0x002EC8FC File Offset: 0x002EAAFC
	public virtual void BFHPJCKICCE(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerCenter
			};
			guistyle.fontSize = 43;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, true) + "Card Player Idle";
			float num = 1746f;
			float num2 = 1558f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 790f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 912f, this.OCHCODJIPHJ.y, 1545f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerRight
				};
				guistyle2.fontSize = 62;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = "crft_from";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "\n" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(true, -1);
				string text2 = "Water Refl Camera id";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "id" + num3 + "47412";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "_AllowBackwardsRays" + text2 + " iterations for read and write";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "[Z]" + text2 + "invn_rec13";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 642f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600640C RID: 25612 RVA: 0x002ECB94 File Offset: 0x002EAD94
	public virtual void LCIKLFLKPEE(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperCenter
			};
			guistyle.fontSize = -7;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, true) + "[^а-яА-Я\\d_]";
			float num = 218f;
			float num2 = 934f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 206f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 619f, this.OCHCODJIPHJ.y, 1941f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleRight
				};
				guistyle2.fontSize = 121;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "catid" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(false, -1);
				string text2 = "id";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text2 = "_FogHeightData" + num3 + "isFishOnRod";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "Assets/Weapons/" + text2 + "SoccerKeeperReady";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = " " + text2 + "Biped's root Transform's position should be at ground level relative to the character (at the character's feet not at it's pelvis).";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1130f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600640D RID: 25613 RVA: 0x002ECE2C File Offset: 0x002EB02C
	public virtual void EGKHIENICMJ(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerLeft
			};
			guistyle.fontSize = 34;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(1L, (long)this.BENMNNMGHGJ, false) + "IceHockeyGoalieReady";
			float num = 1499f;
			float num2 = 149f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 681f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 168f, this.OCHCODJIPHJ.y, 645f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerLeft
				};
				guistyle2.fontSize = 38;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "_";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "bs_hilv" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(true, -1);
				string text2 = "CheerJump";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "WalkDehydrated" + num3 + "Development Server URL could not be found.";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "usr_inf_a4" + text2 + ")";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "Vector3:" + text2 + "</color>";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1461f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600640E RID: 25614 RVA: 0x002ED0C4 File Offset: 0x002EB2C4
	public virtual void JOBPKNNNEAD(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperCenter
			};
			guistyle.fontSize = 41;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, false) + "IdleReady";
			float num = 1333f;
			float num2 = 624f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1460f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 383f, this.OCHCODJIPHJ.y, 3f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle2.fontSize = 112;
				guistyle2.wordWrap = false;
				guistyle2.richText = true;
				string str = "MotorbikeLasso";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "usetime" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(false, -1);
				string text2 = "_Convolved_TexelSize";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "MotorbikeBackwardSitting" + num3 + "cht_msg35";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "wpn_eat4" + text2 + "UI_UserInfoWinow";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "MotorbikeTurnRight" + text2 + "_BlurTexture";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1917f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600640F RID: 25615 RVA: 0x002ED35C File Offset: 0x002EB55C
	public virtual void LNEKEJJIHHP(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleLeft
			};
			guistyle.fontSize = 43;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(0L, (long)this.BENMNNMGHGJ, true) + "_TapLowForeground";
			float num = 1775f;
			float num2 = 1396f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 953f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 165f, this.OCHCODJIPHJ.y, 696f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle2.fontSize = 29;
				guistyle2.wordWrap = false;
				guistyle2.richText = true;
				string str = "IceHockeyPassLeft";
				if (this.ILFHHDNJHNM > 1)
				{
					str = " x" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(true, -1);
				string text2 = "";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "buykey" + num3 + " ";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "Drop " + text2 + "<b>ObscuredString:</b> ";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "#a0a0a0" + text2 + "{0:F2}, {1:F2}, {2:F2}, {3:F2}";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1168f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006410 RID: 25616 RVA: 0x002ED5F4 File Offset: 0x002EB7F4
	public override void HFJFBDPNCCB(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleLeft
			};
			guistyle.fontSize = 22;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, false) + " +";
			float num = 30f;
			float num2 = 30f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 10f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 8f, this.OCHCODJIPHJ.y, 200f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle2.fontSize = 14;
				guistyle2.wordWrap = true;
				guistyle2.richText = true;
				string str = "";
				if (this.ILFHHDNJHNM > 0)
				{
					str = " x" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(false, -1);
				string text2 = "";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "\nу вас есть " + num3 + " шт.";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "<color='#400000'>" + text2 + "</color>";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "<color='#103000'>" + text2 + "</color>";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 0f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006411 RID: 25617 RVA: 0x002ED88C File Offset: 0x002EBA8C
	public virtual void OOKDJBCNEBH(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerLeft
			};
			guistyle.fontSize = 55;
			string text = JLFJEGIPIMM.PKGMBFEMKGP().MNMIJFNPIPI(0L, (long)this.BENMNNMGHGJ, false) + "IdleWalk";
			float num = 1045f;
			float num2 = 810f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 961f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1369f, this.OCHCODJIPHJ.y, 1694f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerLeft
				};
				guistyle2.fontSize = -106;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "_FinalReflectionTexture";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "FistPump2" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(false, -1);
				string text2 = "ambientVolume";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text2 = "UnityEngine.Vector4" + num3 + "USER";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "OneHandSwordSwing" + text2 + "CodeStage.AntiCheat.ObscuredTypes";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "FaceHit" + text2 + "Jump";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 487f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006412 RID: 25618 RVA: 0x002EDB24 File Offset: 0x002EBD24
	public virtual void JIGDBPIJDHE(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperRight
			};
			guistyle.fontSize = 126;
			string text = JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(1L, (long)this.BENMNNMGHGJ, false) + "<size=14><color='#00d0ff'>{0}</color></size>";
			float num = 716f;
			float num2 = 1643f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1691f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 367f, this.OCHCODJIPHJ.y, 1172f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerLeft
				};
				guistyle2.fontSize = 59;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = "_CenterRadius";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "\n" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(true, -1);
				string text2 = "[maxcnt]";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "S " + num3 + "\n";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "KatanaReadyLow" + text2 + "IdleStand";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "RollerBladeTurnLeft" + text2 + "leskaProc";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1353f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006413 RID: 25619 RVA: 0x002EDDBC File Offset: 0x002EBFBC
	public virtual void MBABINJIPDF(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleLeft
			};
			guistyle.fontSize = 125;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, false) + "fishcatch";
			float num = 653f;
			float num2 = 534f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 146f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 362f, this.OCHCODJIPHJ.y, 1147f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerRight
				};
				guistyle2.fontSize = -85;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = "";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "post_11" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(false, -1);
				string text2 = "Colors length of ";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text2 = "https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6" + num3 + "16 samples";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "GiantGrabThrow" + text2 + "wpn_add/base";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "_HSV" + text2 + "WeaponReload";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 89f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006414 RID: 25620 RVA: 0x002EE054 File Offset: 0x002EC254
	public virtual void JIAOONGONPM(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleLeft
			};
			guistyle.fontSize = 90;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, false) + "UnityEngine.Color";
			float num = 1090f;
			float num2 = 1305f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 17f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 339f, this.OCHCODJIPHJ.y, 1374f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerCenter
				};
				guistyle2.fontSize = -123;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = "]";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "BaseDataLoaderCoroutine" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text2 = "{not_found}";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "26" + num3 + "_Vignette_Settings";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "." + text2 + "crft_btn1";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "[wtemplid]" + text2 + "textAsset is NULL! Path: Weapons";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1645f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006415 RID: 25621 RVA: 0x002EE2EC File Offset: 0x002EC4EC
	public virtual void DKOEJJHKMHI(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerCenter
			};
			guistyle.fontSize = -77;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.OHNLAOJGCGC(1L, (long)this.BENMNNMGHGJ, false) + "Hidden/Post FX/Motion Blur";
			float num = 1102f;
			float num2 = 198f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1545f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1936f, this.OCHCODJIPHJ.y, 1206f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperCenter
				};
				guistyle2.fontSize = -17;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = "Lash";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "gi_um_4" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(true, -1);
				string text2 = "OnDestroy ";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "Elvis Legs" + num3 + "Crate Pull";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "TOD_LocalMoonDirection" + text2 + "Footsteps";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "tintColor" + text2 + "wpn_rod4";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1686f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006416 RID: 25622 RVA: 0x002EE584 File Offset: 0x002EC784
	public virtual void OFCJAMLCEPB(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleCenter
			};
			guistyle.fontSize = 79;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, (long)this.BENMNNMGHGJ, true) + "_Offsets";
			float num = 740f;
			float num2 = 570f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1215f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1557f, this.OCHCODJIPHJ.y, 679f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerRight
				};
				guistyle2.fontSize = 108;
				guistyle2.wordWrap = false;
				guistyle2.richText = true;
				string str = "offsets";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "Rebirth" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text2 = "GrounderIK does not support FABRIKRoot, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "wpn_rec4" + num3 + "";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "RollerBladeSkateFwd" + text2 + "";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "name" + text2 + "FrontKick";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1412f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006417 RID: 25623 RVA: 0x002EE81C File Offset: 0x002ECA1C
	public virtual void OAPAJJAJPEK(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleRight
			};
			guistyle.fontSize = -115;
			string text = JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(0L, (long)this.BENMNNMGHGJ, false) + "_Offsets";
			float num = 593f;
			float num2 = 720f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1492f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1082f, this.OCHCODJIPHJ.y, 40f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerRight
				};
				guistyle2.fontSize = 57;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "_Exponent";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "jamp" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(false, -1);
				string text2 = "_TreatBackfaceHitAsMiss";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text2 = "auc_wcswcp" + num3 + "offsets";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "\n" + text2 + "help";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "int\nfloat\nstring\n<color=\"#75C4EB\">uint\ndouble\ndecimal\nlong\nulong\nbool\nbyte[]\nVector2\nVector3\nQuaternion\nColor\nRect</color>" + text2 + "usr_inf_a4";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 413f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006418 RID: 25624 RVA: 0x002EEAB4 File Offset: 0x002ECCB4
	public virtual void KCHEILEJGPL(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleRight
			};
			guistyle.fontSize = 5;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(0L, (long)this.BENMNNMGHGJ, false) + "OfficeSittingReading";
			float num = 477f;
			float num2 = 14f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1607f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1262f, this.OCHCODJIPHJ.y, 1921f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleRight
				};
				guistyle2.fontSize = -110;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = "Finger";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "C" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(true, -1);
				string text2 = "";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text2 = "CardPlayerIdle" + num3 + "4";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = " " + text2 + "Reset";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "_NoiseTex" + text2 + "OneHandSwordBackSwing";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1264f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006419 RID: 25625 RVA: 0x002EED4C File Offset: 0x002ECF4C
	public virtual void ILHLJFHLJIH(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleLeft
			};
			guistyle.fontSize = -50;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(1L, (long)this.BENMNNMGHGJ, true) + "_Jitter";
			float num = 660f;
			float num2 = 977f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1498f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 608f, this.OCHCODJIPHJ.y, 1891f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperRight
				};
				guistyle2.fontSize = 102;
				guistyle2.wordWrap = true;
				guistyle2.richText = true;
				string str = "crft_crft";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "Lasso Left" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(true, -1);
				string text2 = "Flashlight";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text2 = "Motion Blur" + num3 + "IK Effector is referencing to a bone '";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "WizardOverhead" + text2 + "Отмена";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "IdleStand" + text2 + "ShotgunReadyFire";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 681f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600641A RID: 25626 RVA: 0x002EEFE4 File Offset: 0x002ED1E4
	public virtual void APOPIOPIFMP(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleCenter
			};
			guistyle.fontSize = 17;
			string text = JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM(1L, (long)this.BENMNNMGHGJ, false) + "\n";
			float num = 782f;
			float num2 = 174f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1953f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1934f, this.OCHCODJIPHJ.y, 1530f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerRight
				};
				guistyle2.fontSize = -5;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = "RunDive";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "\n" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(false, -1);
				string text2 = "_camHue";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "No hit from " + num3 + "Invalid references, one or more Transforms are missing.";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "Отпущена рыба" + text2 + "wgt_gr";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "IdleSlide" + text2 + "GetPoints() is not applicable to IKSolverVR.";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 320f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600641B RID: 25627 RVA: 0x002EF27C File Offset: 0x002ED47C
	public virtual void CMECHJMLPGD(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerCenter
			};
			guistyle.fontSize = 74;
			string text = JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(1L, (long)this.BENMNNMGHGJ, false) + "cntx_close";
			float num = 147f;
			float num2 = 1054f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1310f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 749f, this.OCHCODJIPHJ.y, 1696f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperLeft
				};
				guistyle2.fontSize = -88;
				guistyle2.wordWrap = true;
				guistyle2.richText = true;
				string str = "End";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "Anti-Cheat Toolkit Detectors" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text2 = " %\n";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "Horizontal" + num3 + "Idle Sad";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "WizardOverhead" + text2 + "_FgCocMask";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "soft" + text2 + "===== ObscuredIntTest =====\n";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1203f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600641C RID: 25628 RVA: 0x002EF514 File Offset: 0x002ED714
	public virtual void LPPKKCCKLJF(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperCenter
			};
			guistyle.fontSize = -61;
			string text = JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(1L, (long)this.BENMNNMGHGJ, false) + "id";
			float num = 908f;
			float num2 = 907f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1074f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 417f, this.OCHCODJIPHJ.y, 195f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperLeft
				};
				guistyle2.fontSize = 89;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "/";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "1HandSwordChargeUp" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(false, -1);
				string text2 = " assetbundle(s) in memory before unloading ";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "InteractionObject " + num3 + "invn_rec3";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "contrast" + text2 + "newHour";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "PrimaryCausticsProjector" + text2 + "OfficeSittingEyesRub";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 842f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600641D RID: 25629 RVA: 0x002EF7AC File Offset: 0x002ED9AC
	public virtual void JBBGCIICJIH(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerCenter
			};
			guistyle.fontSize = -39;
			string text = JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, true) + "calf";
			float num = 395f;
			float num2 = 735f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1046f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 374f, this.OCHCODJIPHJ.y, 809f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleRight
				};
				guistyle2.fontSize = 105;
				guistyle2.wordWrap = false;
				guistyle2.richText = true;
				string str = "knopje.wav";
				if (this.ILFHHDNJHNM > 1)
				{
					str = " " + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(true, -1);
				string text2 = "{{{{{0},{1}}}}}";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "[weight]" + num3 + "Empty Array.";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "Tops" + text2 + "_INFO";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "" + text2 + "Отпущено {0} рыб, общим весом \n<color='#a000ff'>{1}</color>\nПолучено {2} опыта";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 781f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600641E RID: 25630 RVA: 0x002EFA44 File Offset: 0x002EDC44
	public virtual void PHJEFJPDDDI(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleRight
			};
			guistyle.fontSize = 127;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, true) + "";
			float num = 800f;
			float num2 = 496f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1549f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1295f, this.OCHCODJIPHJ.y, 1863f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperRight
				};
				guistyle2.fontSize = 51;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = "MotorbikeLassoLeft";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "_WrinkleOcclusionStrengths" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(true, -1);
				string text2 = "AC_TONEMAPPING";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "wpn_hook3" + num3 + "Yawn";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "demoDouble" + text2 + "Skateboard Idle";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "CP1" + text2 + "post_9";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1307f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600641F RID: 25631 RVA: 0x002EFCDC File Offset: 0x002EDEDC
	public virtual void GMLICBKPPCC(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerCenter
			};
			guistyle.fontSize = 98;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().OHNLAOJGCGC(1L, (long)this.BENMNNMGHGJ, true) + "[sysname]";
			float num = 1923f;
			float num2 = 972f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 903f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 691f, this.OCHCODJIPHJ.y, 26f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter
				};
				guistyle2.fontSize = -39;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "_LayerThickness";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "En" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(false, -1);
				string text2 = "lifeBar";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text2 = "Idle Dodge Right" + num3 + "0";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = " x" + text2 + " value=";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "<color='#103000'>" + text2 + "  ";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 516f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006420 RID: 25632 RVA: 0x002EFF74 File Offset: 0x002EE174
	public virtual void OCCJHOPJHLG(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleRight
			};
			guistyle.fontSize = -47;
			string text = JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC(1L, (long)this.BENMNNMGHGJ, false) + "medium";
			float num = 399f;
			float num2 = 1527f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1130f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1826f, this.OCHCODJIPHJ.y, 105f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerLeft
				};
				guistyle2.fontSize = 34;
				guistyle2.wordWrap = false;
				guistyle2.richText = true;
				string str = "crft_to";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "Giant3HitCombo" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(false, -1);
				string text2 = "Swim";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "wgt_kg" + num3 + "wpn_line3";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "cntx_rem" + text2 + "/";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "WizardBlock" + text2 + "_GrainOffsetScale";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 786f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006421 RID: 25633 RVA: 0x002F020C File Offset: 0x002EE40C
	public virtual void HADLKLNMMNC(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleCenter
			};
			guistyle.fontSize = 6;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, false) + "";
			float num = 265f;
			float num2 = 247f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1065f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 189f, this.OCHCODJIPHJ.y, 220f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle2.fontSize = -87;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = "360SpinDeath";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "11" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(false, -1);
				string text2 = "";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "MotorbikeBackwardSittingCheer" + num3 + "Run Back Left";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "invn_rec31" + text2 + "cht_msg28";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "knopje.wav" + text2 + "Reset";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1874f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006422 RID: 25634 RVA: 0x002F04A4 File Offset: 0x002EE6A4
	public virtual void CGKPGCLLJHJ(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleRight
			};
			guistyle.fontSize = -126;
			string text = JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC(1L, (long)this.BENMNNMGHGJ, false) + "cond";
			float num = 142f;
			float num2 = 828f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 293f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 815f, this.OCHCODJIPHJ.y, 60f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle2.fontSize = -87;
				guistyle2.wordWrap = false;
				guistyle2.richText = true;
				string str = "_ReflectionTexture4";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "fishStamKF=" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(false, -1);
				string text2 = "error.wav";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.NPCAKEGNBHD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "_SSAO" + num3 + "";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "no recept " + text2 + "RunBackward";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "MotorbikeSpecialFlip" + text2 + "TOD_LightDirection";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 985f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006423 RID: 25635 RVA: 0x002F073C File Offset: 0x002EE93C
	public GINEDLOJIIF(ONKDCGNBALK OCBAOFLJBGP, float POFBHAEFJNE, float AIIFDJADHJP, float BBOODPCDKAJ, int HHOLFABGDJA, int KDIMEMOCJNM, int CCBDMNCIJJF) : base(OCBAOFLJBGP, POFBHAEFJNE, AIIFDJADHJP, BBOODPCDKAJ, BBOODPCDKAJ, "", 0, 7)
	{
		this.ILFHHDNJHNM = KDIMEMOCJNM;
		this.BENMNNMGHGJ = CCBDMNCIJJF;
		this.MBANOJNPAIC = IHFEDJEMJMB.IKGFHGKKCPG.GBKMHIGNKJA(HHOLFABGDJA);
	}

	// Token: 0x06006424 RID: 25636 RVA: 0x002F0794 File Offset: 0x002EE994
	public virtual void BNBECPLPKGM(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleLeft
			};
			guistyle.fontSize = 23;
			string text = JLFJEGIPIMM.MHFDIJGJGBJ().CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, true) + "Idle Feed Throw";
			float num = 371f;
			float num2 = 1936f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1094f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 385f, this.OCHCODJIPHJ.y, 1965f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperLeft
				};
				guistyle2.fontSize = 82;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "IdleDodgeLeft";
				if (this.ILFHHDNJHNM > 0)
				{
					str = ".unity3d" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text2 = "demoByteArray";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.BOKIOJFHNLD().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text2 = "ZombieWalk" + num3 + "Reveling";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "the Goscurry is not a lie ;)" + text2 + "null";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "sys" + text2 + "ENABLE_DITHERING";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 296f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006425 RID: 25637 RVA: 0x002F0A2C File Offset: 0x002EEC2C
	public virtual void AMEAHFNAHDC(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperRight
			};
			guistyle.fontSize = -114;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(1L, (long)this.BENMNNMGHGJ, false) + "https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6";
			float num = 325f;
			float num2 = 1464f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 467f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 261f, this.OCHCODJIPHJ.y, 1710f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperLeft
				};
				guistyle2.fontSize = 35;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = ": ";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "Отпущена рыба" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.JPBOPFNPNHC(false, -1);
				string text2 = "BC ";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.PFOLNEGNIPP().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "" + num3 + "";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "минуты" + text2 + "wpn_drop";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "Image effects aren't supported on this device ({0})" + text2 + "error.wav";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1181f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006426 RID: 25638 RVA: 0x002F0CC4 File Offset: 0x002EEEC4
	public virtual void GHGLBEBFGAP(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleLeft
			};
			guistyle.fontSize = 68;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.MNMIJFNPIPI(0L, (long)this.BENMNNMGHGJ, false) + "money";
			float num = 908f;
			float num2 = 1365f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1506f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1621f, this.OCHCODJIPHJ.y, 1785f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleCenter
				};
				guistyle2.fontSize = -15;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = "t_body";
				if (this.ILFHHDNJHNM > 1)
				{
					str = ". Check the Maintenance window for your VPaint Group for more info." + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(true, -1);
				string text2 = "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_rotation_limit_spline.html";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "\">Detected: " + num3 + "Mutilate";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "Prefabs/FogBoxArea" + text2 + "_BlurPass";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "cap" + text2 + "x {0}/{1}";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 416f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006427 RID: 25639 RVA: 0x002F0F5C File Offset: 0x002EF15C
	public virtual void FDCOFCOIHEH(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperLeft
			};
			guistyle.fontSize = -25;
			string text = JLFJEGIPIMM.PKGMBFEMKGP().CJKACKADMKM(1L, (long)this.BENMNNMGHGJ, false) + "OneHandSwordReady";
			float num = 1319f;
			float num2 = 204f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1433f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 118f, this.OCHCODJIPHJ.y, 1758f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerCenter
				};
				guistyle2.fontSize = 119;
				guistyle2.wordWrap = true;
				guistyle2.richText = true;
				string str = ")?";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "INTERFACE" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(true, -1);
				string text2 = "";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.EAJHPOJPPFA().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text2 = "FrontKick" + num3 + "";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "<< 1 <<" + text2 + "8 samples";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "GiantGrabIdle2" + text2 + "";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 509f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006428 RID: 25640 RVA: 0x002F11F4 File Offset: 0x002EF3F4
	public virtual void BIJMKMEPBIC(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerLeft
			};
			guistyle.fontSize = -7;
			string text = JLFJEGIPIMM.IKGFHGKKCPG.CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, false) + "withquest";
			float num = 959f;
			float num2 = 230f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1981f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1620f, this.OCHCODJIPHJ.y, 267f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleLeft
				};
				guistyle2.fontSize = -98;
				guistyle2.wordWrap = false;
				guistyle2.richText = true;
				string str = "PistolFire";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(true, -1);
				string text2 = "UpHillWalk";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "Sewing" + num3 + "_UserLutParams";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "perks/perk" + text2 + "droplinemsg1";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "ScubaSwim" + text2 + "TOD_SunMeshBrightness";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 443f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x06006429 RID: 25641 RVA: 0x002F148C File Offset: 0x002EF68C
	public virtual void HCHJHBGEGMP(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperLeft
			};
			guistyle.fontSize = -33;
			string text = JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(1L, (long)this.BENMNNMGHGJ, true) + "wpn_eat5";
			float num = 913f;
			float num2 = 632f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 661f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1070f, this.OCHCODJIPHJ.y, 1459f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerCenter
				};
				guistyle2.fontSize = 22;
				guistyle2.wordWrap = false;
				guistyle2.richText = true;
				string str = "";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.LFEJHHMDEHO(true, -1);
				string text2 = "WATER_REFRACTIVE";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text2 = " ms" + num3 + "<color='{0}'>{1}  {2}</color>";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "baseQuality" + text2 + "Reset";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "ANGLE=" + text2 + "RollerBladeFrontFlip";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1182f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600642A RID: 25642 RVA: 0x002F1724 File Offset: 0x002EF924
	public virtual void LNNEOFFJJJA(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperCenter
			};
			guistyle.fontSize = -9;
			string text = JLFJEGIPIMM.PKGMBFEMKGP().OHNLAOJGCGC(1L, (long)this.BENMNNMGHGJ, true) + "shop_t10";
			float num = 818f;
			float num2 = 1761f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 554f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1125f, this.OCHCODJIPHJ.y, 1695f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerRight
				};
				guistyle2.fontSize = 73;
				guistyle2.wordWrap = true;
				guistyle2.richText = true;
				string str = "_History1LumaTex";
				if (this.ILFHHDNJHNM > 1)
				{
					str = " iterations for read and write" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(false, -1);
				string text2 = "SpinReel.ogg";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 0);
					text2 = "Idle180" + num3 + "GetMouseButtonUp reboot";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "MotorbikeWheelyNoHands" + text2 + "R";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "LINEAR" + text2 + "wpn_rod4";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 253f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600642B RID: 25643 RVA: 0x002F19BC File Offset: 0x002EFBBC
	public virtual void FOGCOMNGOFB(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperLeft
			};
			guistyle.fontSize = 122;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(1L, (long)this.BENMNNMGHGJ, false) + "UnityEngine.Vector2";
			float num = 256f;
			float num2 = 560f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1877f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1038f, this.OCHCODJIPHJ.y, 1203f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperCenter
				};
				guistyle2.fontSize = 54;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "IdleEat" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(true, -1);
				string text2 = " %\n";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, false, 1);
					text2 = "WATER_SIMPLE" + num3 + " does not have any fingers, VRIK can not guess the hand bone's orientation.";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "connect already used" + text2 + "MotorbikeLassoLeft";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "BlackSmithHammer" + text2 + "WeaponRunBackward";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1825f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600642C RID: 25644 RVA: 0x002F1C54 File Offset: 0x002EFE54
	public virtual void LMIIDBOCFPI(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerLeft
			};
			guistyle.fontSize = 18;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().MNMIJFNPIPI(0L, (long)this.BENMNNMGHGJ, true) + "auc_wcstc";
			float num = 69f;
			float num2 = 1071f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1197f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 683f, this.OCHCODJIPHJ.y, 1101f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.LowerLeft
				};
				guistyle2.fontSize = 63;
				guistyle2.wordWrap = true;
				guistyle2.richText = true;
				string str = "Post Process Debug Shader Missing...";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "x" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.IGDKBMGKKDO(true, -1);
				string text2 = "_TexelOffsetScale";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 0);
					text2 = "<" + num3 + "no assemblies";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "cntx_close" + text2 + "_EdgeSharpness";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "SoccerPassLight" + text2 + "";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1791f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600642D RID: 25645 RVA: 0x002F1EEC File Offset: 0x002F00EC
	public virtual void OEGEMMPIIPC(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.LowerRight
			};
			guistyle.fontSize = 22;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().CJKACKADMKM(0L, (long)this.BENMNNMGHGJ, false) + "_SrcBlend";
			float num = 1690f;
			float num2 = 353f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1677f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 1);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1753f, this.OCHCODJIPHJ.y, 0f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.MiddleRight
				};
				guistyle2.fontSize = 117;
				guistyle2.wordWrap = false;
				guistyle2.richText = false;
				string str = "Hyperlink_";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "FrontKick" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(true, -1);
				string text2 = "The number of players playing your game: ";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.JKIFIBEPICO().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "Builtin Debug Views" + num3 + "CardPlayerLook";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "_NeutralTonemapperParams2" + text2 + "btn_cancel";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "ShootWireframeModule" + text2 + "_ExposureAdjustment";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 898f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600642E RID: 25646 RVA: 0x002F2184 File Offset: 0x002F0384
	public virtual void LCOKOEMNPEL(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 0)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.UpperLeft
			};
			guistyle.fontSize = 121;
			string text = JLFJEGIPIMM.MHFDIJGJGBJ().OHNLAOJGCGC(1L, (long)this.BENMNNMGHGJ, false) + "";
			float num = 1864f;
			float num2 = 364f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 1824f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.FCBHHPJLGLC(rect, this.MBANOJNPAIC.KBGHOIJIPJF, false, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 1682f, this.OCHCODJIPHJ.y, 407f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperCenter
				};
				guistyle2.fontSize = 73;
				guistyle2.wordWrap = false;
				guistyle2.richText = true;
				string str = "IKMappingBone's bone is null.";
				if (this.ILFHHDNJHNM > 0)
				{
					str = "fishcatch" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.CGMGBGABLFB(false, -1);
				string text2 = "inv_invheader";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.IKGFHGKKCPG.KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = "[quote]" + num3 + "languageid";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "" + text2 + ")";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "" + text2 + "";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 882f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x0600642F RID: 25647 RVA: 0x002F241C File Offset: 0x002F061C
	public virtual void FJNDHHDAGCI(bool CFMPGCJMHJM)
	{
		Rect rect = new Rect(this.OCHCODJIPHJ.x, this.OCHCODJIPHJ.y, this.OCHCODJIPHJ.width, this.OCHCODJIPHJ.height);
		if (this.BENMNNMGHGJ > 1)
		{
			GUIStyle guistyle = new GUIStyle
			{
				normal = 
				{
					textColor = Color.black
				},
				alignment = TextAnchor.MiddleRight
			};
			guistyle.fontSize = -69;
			string text = JLFJEGIPIMM.NNEAHAFBOHC().MNMIJFNPIPI(0L, (long)this.BENMNNMGHGJ, false) + "Curve texture";
			float num = 96f;
			float num2 = 1241f;
			guistyle.CalcMinMaxWidth(new GUIContent(text), out num, out num2);
			GUI.Label(new Rect(rect.x, rect.y, num, rect.height), text, guistyle);
			rect.x += num + 134f;
		}
		if (this.KPLMFNIFPMM)
		{
			GUI.DrawTexture(rect, GameInterface.getI.invEmptyCell);
		}
		if (this.MBANOJNPAIC != null)
		{
			this.MBANOJNPAIC.GDLELABHHFG(rect, this.MBANOJNPAIC.KBGHOIJIPJF, true, 0);
			if (this.MAKAFBBENPF)
			{
				Rect position = new Rect(rect.x + this.OCHCODJIPHJ.width + 450f, this.OCHCODJIPHJ.y, 753f, this.OCHCODJIPHJ.height);
				GUIStyle guistyle2 = new GUIStyle
				{
					normal = 
					{
						textColor = Color.black
					},
					alignment = TextAnchor.UpperLeft
				};
				guistyle2.fontSize = 32;
				guistyle2.wordWrap = true;
				guistyle2.richText = false;
				string str = "Error";
				if (this.ILFHHDNJHNM > 1)
				{
					str = "" + this.ILFHHDNJHNM;
				}
				string str2 = this.MBANOJNPAIC.MPKGPJJKCPK(false, -1);
				string text2 = "file://";
				if (this.HMHBAMDBJLI)
				{
					int num3 = JBEHMPDDMME.BPPFAOOCENN().KFHELHGLNMH.BJDIEKNHGLJ(this.MBANOJNPAIC.LPFKFNLHGBI, true, 1);
					text2 = " cm" + num3 + "post_msg2";
					if (this.ILFHHDNJHNM > num3)
					{
						text2 = "[AmplifyColor] Error creating " + text2 + "mouseLook not found";
					}
					if (this.ILFHHDNJHNM <= num3)
					{
						text2 = "\n" + text2 + "WalkDehydrated";
					}
				}
				GUI.Label(position, str2 + str + text2, guistyle2);
			}
			if (this.OHNAHKMBABD)
			{
				this.KMNEOIGFPGL += Time.deltaTime;
			}
			else
			{
				this.KMNEOIGFPGL = 1806f;
			}
		}
		bool ohnahkmbabd = this.OHNAHKMBABD;
		base.HFJFBDPNCCB(CFMPGCJMHJM);
	}

	// Token: 0x04000E68 RID: 3688
	public BEFCHFNGOMI MBANOJNPAIC;

	// Token: 0x04000E69 RID: 3689
	public int ILFHHDNJHNM;

	// Token: 0x04000E6A RID: 3690
	public int BENMNNMGHGJ;

	// Token: 0x04000E6B RID: 3691
	public bool MAKAFBBENPF = true;

	// Token: 0x04000E6C RID: 3692
	public bool HMHBAMDBJLI = true;

	// Token: 0x04000E6D RID: 3693
	public float KMNEOIGFPGL;

	// Token: 0x04000E6E RID: 3694
	public bool KPLMFNIFPMM = true;
}
