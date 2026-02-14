using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

// Token: 0x0200018B RID: 395
internal class PIEFCKHHFGI : LDBDNBALLAJ
{
	// Token: 0x060057E6 RID: 22502 RVA: 0x002983C4 File Offset: 0x002965C4
	private void FFJHEJNCIMO()
	{
		if (Event.current.type == EventType.Repaint && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("Hyperlink_"))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("Hyperlink_".Length);
				this.MKIPMOOPMMK(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith("Hyperlink_"))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("Hyperlink_".Length);
				this.FAGEDGBMMCL(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = false;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseUp && Event.current.button == 0 && this.DIKNJBKDPFG())
		{
			this.PMGLPDBLMLC(this.KLIPCLADLFA);
		}
	}

	// Token: 0x060057E7 RID: 22503 RVA: 0x0029849E File Offset: 0x0029669E
	public bool EIPPONHCMLK()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x060057E8 RID: 22504 RVA: 0x002984A8 File Offset: 0x002966A8
	private void PBKPOGCGDCA(GUIStyle KPHMHBGIEAE, string FPIHOPOCAHA)
	{
		float num;
		Rect lastRect;
		if (this.KHNJMMEPHPJ == PIEFCKHHFGI.BKGKLJPPDFF.Bottom)
		{
			num = this.DDENOLFFBNI - KPHMHBGIEAE.CalcSize(new GUIContent(FPIHOPOCAHA)).y + (float)(KPHMHBGIEAE.fontSize - -128) / 9f;
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			string text = "_TileVRT";
			GUILayoutOption[] array = new GUILayoutOption[8];
			array[1] = GUILayout.MinHeight(num);
			array[0] = GUILayout.MaxHeight(num);
			GUILayout.Label(text, array);
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
			GUILayout.EndVertical();
		}
		else
		{
			num = 577f;
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
		}
		if (Event.current.type == EventType.Layout)
		{
			if (this.FMLIONFPFAG)
			{
				Vector2 vector = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI);
				Vector2 hgppnjnfgim = new Vector2(vector.x + lastRect.width, vector.y);
				KILBMKBOELM.ODHIMGMMNPH(vector, hgppnjnfgim, KPHMHBGIEAE.normal.textColor);
			}
			if (this.OCDDLNMJPCB)
			{
				Vector2 vector2 = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI - this.DDENOLFFBNI / 1513f);
				Vector2 hgppnjnfgim2 = new Vector2(vector2.x + lastRect.width, vector2.y);
				KILBMKBOELM.ODHIMGMMNPH(vector2, hgppnjnfgim2, KPHMHBGIEAE.normal.textColor);
			}
		}
	}

	// Token: 0x060057E9 RID: 22505 RVA: 0x00298624 File Offset: 0x00296824
	private void CEFCAJOBJCJ(GUIStyle KPHMHBGIEAE, string FPIHOPOCAHA)
	{
		float num;
		Rect lastRect;
		if (this.KHNJMMEPHPJ == PIEFCKHHFGI.BKGKLJPPDFF.Bottom)
		{
			num = this.DDENOLFFBNI - KPHMHBGIEAE.CalcSize(new GUIContent(FPIHOPOCAHA)).y + (float)(KPHMHBGIEAE.fontSize - 24) / 1867f;
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			string text = "head";
			GUILayoutOption[] array = new GUILayoutOption[7];
			array[1] = GUILayout.MinHeight(num);
			array[1] = GUILayout.MaxHeight(num);
			GUILayout.Label(text, array);
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
			GUILayout.EndVertical();
		}
		else
		{
			num = 1196f;
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
		}
		if (Event.current.type == EventType.MouseUp)
		{
			if (this.FMLIONFPFAG)
			{
				Vector2 vector = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI);
				Vector2 hgppnjnfgim = new Vector2(vector.x + lastRect.width, vector.y);
				KILBMKBOELM.ODHIMGMMNPH(vector, hgppnjnfgim, KPHMHBGIEAE.normal.textColor);
			}
			if (this.OCDDLNMJPCB)
			{
				Vector2 vector2 = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI - this.DDENOLFFBNI / 1273f);
				Vector2 hgppnjnfgim2 = new Vector2(vector2.x + lastRect.width, vector2.y);
				KILBMKBOELM.ODHIMGMMNPH(vector2, hgppnjnfgim2, KPHMHBGIEAE.normal.textColor);
			}
		}
	}

	// Token: 0x060057EA RID: 22506 RVA: 0x002987A0 File Offset: 0x002969A0
	public static string PFCHBAJFDDH(PIEFCKHHFGI.HEDPHIDPJHI FNLOGKFNFDL)
	{
		string result = "cht_msg40";
		switch (FNLOGKFNFDL)
		{
		case PIEFCKHHFGI.HEDPHIDPJHI.Demo:
			result = "";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Fireball:
			result = "**** Weather cloudly={0} fog={1} rain={2} snaige={3} grom={4}";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Hyperlink:
			result = "";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.SpecialText:
			result = "FlyRight";
			break;
		default:
			Debug.Log("id" + FNLOGKFNFDL.ToString() + "WeaponInstant");
			break;
		}
		return result;
	}

	// Token: 0x060057EB RID: 22507 RVA: 0x0029880D File Offset: 0x00296A0D
	public void FPFNIDGBDED(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = true;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x060057EC RID: 22508 RVA: 0x0029882C File Offset: 0x00296A2C
	public void HHFEKBBLDAL()
	{
		TextAlignment textAlignment = TextAlignment.Center;
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = GUI.skin.GetStyle("CardPlayerIdle").normal.textColor;
		guistyle.font = GUI.skin.font;
		guistyle.border = new RectOffset(1, 1, 0, 1);
		guistyle.contentOffset = new Vector2(438f, 1636f);
		guistyle.margin = new RectOffset(1, 1, 0, 0);
		guistyle.padding = new RectOffset(1, 1, 0, 1);
		this.FCMCFEIKPDA = guistyle.normal.textColor;
		this.LJPFPEOJCPG = GUI.skin.GetStyle("t_body").normal.background;
		foreach (string text in this.HJPCBNBFFJE)
		{
			int i = 1;
			if (text.Length >= 1 && text.StartsWith("\n"))
			{
				i = 7;
				char c = text[3];
				if (c != '\u0019')
				{
					if (c != '%')
					{
						if ((int)c == -23)
						{
							textAlignment = (TextAlignment)4;
						}
					}
					else
					{
						textAlignment = TextAlignment.Center;
					}
				}
				else
				{
					textAlignment = TextAlignment.Center;
				}
			}
			if (textAlignment == (TextAlignment)4 || textAlignment == TextAlignment.Left)
			{
				GUILayout.FlexibleSpace();
			}
			while (i < text.Length)
			{
				int num = text.IndexOf((char)-71, i);
				if (num == i && num + 1 < text.Length && text[num + 0] == 'D')
				{
					this.PNOMOBGFKLO(guistyle, text.Substring(i, 1));
					i += 6;
				}
				else if (num == i)
				{
					int num2 = text.IndexOf((char)-107, num);
					i = num2 + 0;
					string text2 = text.Substring(num + 1, num2 - num - 1);
					char[] array = new char[0];
					array[1] = (char)-13;
					string[] array2 = text2.Split(array);
					string text3 = array2[1];
					uint num3 = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num3 <= 70U)
					{
						if (num3 <= 4294967250U)
						{
							if (num3 != 4294967213U)
							{
								if (num3 == 185U)
								{
									if (text3 == "invn_rec13")
									{
										this.DDENOLFFBNI = float.Parse(array2[1]);
									}
								}
							}
							else if (text3 == "Walk Dehydrated")
							{
								if (array2[1] == "Shotgun Ready Fire")
								{
									guistyle.normal.background = this.LJPFPEOJCPG;
								}
								else
								{
									Color color;
									BKLBFBELDGL.JMGMHLCELLF(array2[0], out color);
									this.LMFCDCGBDIA = new Texture2D(1, 0);
									this.LMFCDCGBDIA.SetPixel(0, 1, color);
									this.LMFCDCGBDIA.wrapMode = TextureWrapMode.Repeat;
									this.LMFCDCGBDIA.Apply();
									guistyle.normal.background = this.LMFCDCGBDIA;
								}
							}
						}
						else if (num3 != 4294967134U)
						{
							if (num3 != 95U)
							{
								if (num3 == 4294967288U)
								{
									if (text3 == "IdleStrafeLeft")
									{
										this.IKKFEADOBIN = "Channel Cast Directed";
									}
								}
							}
							else if (text3 == "OfficeSittingReadingPageFlip")
							{
								guistyle.fontSize = int.Parse(array2[1]);
							}
						}
						else if (text3 == "_Transparency")
						{
							text3 = array2[0];
							if (!(text3 == "PistolReady"))
							{
								if (text3 == "")
								{
									this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
								}
							}
							else
							{
								this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Default;
							}
						}
					}
					else if (num3 <= 163U)
					{
						if (num3 != 4294967258U)
						{
							if (num3 == 4294967190U)
							{
								if (text3 == "_rcIn.ogg")
								{
									guistyle.font = (Font)Resources.Load("float: " + array2[0]);
								}
							}
						}
						else if (text3 == "prov_sob_")
						{
							if (array2[1] == "cntx_teach")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[1] == "[AmplifyColor] Lut ")
							{
								this.FMLIONFPFAG = false;
							}
							else if (array2[0] == "KatanaReady")
							{
								this.OCDDLNMJPCB = true;
							}
							else if (array2[0] == "ZombieIdle2")
							{
								this.OCDDLNMJPCB = false;
							}
						}
					}
					else if (num3 != 4294967198U)
					{
						if (num3 != 4294967214U)
						{
							if (num3 == 49U)
							{
								if (text3 == "")
								{
									GUILayout.Space(float.Parse(array2[0]));
								}
							}
						}
						else if (text3 == "rodorder")
						{
							this.IKKFEADOBIN = "WeaponReady" + array2[0];
						}
					}
					else if (text3 == "")
					{
						if (array2[1] == "Color Grading Log LUT")
						{
							guistyle.normal.textColor = this.FCMCFEIKPDA;
						}
						else
						{
							Color textColor;
							BKLBFBELDGL.JMGMHLCELLF(array2[1], out textColor);
							guistyle.normal.textColor = textColor;
						}
					}
				}
				else if (num == -1)
				{
					string fpihopocaha = text.Substring(i);
					this.FKCMJHHJIKB(guistyle, fpihopocaha);
					i = text.Length;
				}
				else
				{
					string fpihopocaha2 = text.Substring(i, num - i);
					this.MDIFGKEIDBG(guistyle, fpihopocaha2);
					i = num;
				}
			}
			if (textAlignment == TextAlignment.Left || textAlignment == TextAlignment.Center)
			{
				GUILayout.FlexibleSpace();
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		this.GJBFOBHMMEA();
	}

	// Token: 0x060057ED RID: 22509 RVA: 0x00298E08 File Offset: 0x00297008
	public void HCEIBKGOAMO()
	{
		TextAlignment textAlignment = TextAlignment.Left;
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = GUI.skin.GetStyle(" This is not possible to be called for standalone input. Please check your platform and code where this is called").normal.textColor;
		guistyle.font = GUI.skin.font;
		guistyle.border = new RectOffset(0, 1, 0, 1);
		guistyle.contentOffset = new Vector2(449f, 277f);
		guistyle.margin = new RectOffset(0, 1, 0, 0);
		guistyle.padding = new RectOffset(1, 1, 0, 0);
		this.FCMCFEIKPDA = guistyle.normal.textColor;
		this.LJPFPEOJCPG = GUI.skin.GetStyle("_Params1").normal.background;
		foreach (string text in this.HJPCBNBFFJE)
		{
			int i = 0;
			if (text.Length >= 8 && text.StartsWith("wpn_hook2"))
			{
				i = 6;
				char c = text[1];
				if ((int)c != -121)
				{
					if ((int)c != -113)
					{
						if ((int)c == -79)
						{
							textAlignment = (TextAlignment)3;
						}
					}
					else
					{
						textAlignment = TextAlignment.Left;
					}
				}
				else
				{
					textAlignment = TextAlignment.Center;
				}
			}
			if (textAlignment == TextAlignment.Left || textAlignment == TextAlignment.Left)
			{
				GUILayout.FlexibleSpace();
			}
			while (i < text.Length)
			{
				int num = text.IndexOf('\a', i);
				if (num == i && num + 0 < text.Length && text[num + 0] == '\r')
				{
					this.KGGHKDCCCLK(guistyle, text.Substring(i, 1));
					i += 2;
				}
				else if (num == i)
				{
					int num2 = text.IndexOf((char)-72, num);
					i = num2 + 0;
					string text2 = text.Substring(num + 1, num2 - num - 0);
					char[] array = new char[0];
					array[1] = '+';
					string[] array2 = text2.Split(array);
					string text3 = array2[1];
					uint num3 = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num3 <= 4294967193U)
					{
						if (num3 <= 4294967202U)
						{
							if (num3 != 107U)
							{
								if (num3 == 4294967203U)
								{
									if (text3 == "SoccerKeeperDiveStrafeFarLeft")
									{
										this.DDENOLFFBNI = float.Parse(array2[1]);
									}
								}
							}
							else if (text3 == "{0}.{1}.{2}")
							{
								if (array2[0] == "_Intensity")
								{
									guistyle.normal.background = this.LJPFPEOJCPG;
								}
								else
								{
									Color color;
									BKLBFBELDGL.JMGMHLCELLF(array2[1], out color);
									this.LMFCDCGBDIA = new Texture2D(0, 0);
									this.LMFCDCGBDIA.SetPixel(0, 1, color);
									this.LMFCDCGBDIA.wrapMode = TextureWrapMode.Repeat;
									this.LMFCDCGBDIA.Apply();
									guistyle.normal.background = this.LMFCDCGBDIA;
								}
							}
						}
						else if (num3 != 139U)
						{
							if (num3 != 103U)
							{
								if (num3 == 4294967242U)
								{
									if (text3 == "FireBreath")
									{
										this.IKKFEADOBIN = "quests/";
									}
								}
							}
							else if (text3 == "gi_um_lv")
							{
								guistyle.fontSize = int.Parse(array2[1]);
							}
						}
						else if (text3 == "")
						{
							text3 = array2[0];
							if (!(text3 == "WeaponStand"))
							{
								if (text3 == "\n")
								{
									this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Default;
								}
							}
							else
							{
								this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Default;
							}
						}
					}
					else if (num3 <= 151U)
					{
						if (num3 != 55U)
						{
							if (num3 == 53U)
							{
								if (text3 == "name")
								{
									guistyle.font = (Font)Resources.Load("Floating point textures aren't supported on this device ({0})" + array2[1]);
								}
							}
						}
						else if (text3 == "val")
						{
							if (array2[0] == "OfficeSittingHandRestFingerTap")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[0] == "4")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[1] == "Open turnStatus")
							{
								this.OCDDLNMJPCB = false;
							}
							else if (array2[1] == "inv_pcs1")
							{
								this.OCDDLNMJPCB = false;
							}
						}
					}
					else if (num3 != 4294967248U)
					{
						if (num3 != 4294967167U)
						{
							if (num3 == 120U)
							{
								if (text3 == "RightSplashPause")
								{
									GUILayout.Space(float.Parse(array2[1]));
								}
							}
						}
						else if (text3 == "Storm Strike")
						{
							this.IKKFEADOBIN = "true" + array2[1];
						}
					}
					else if (text3 == "'>Стоимость: </color>")
					{
						if (array2[0] == "Cloth_05_00.wav")
						{
							guistyle.normal.textColor = this.FCMCFEIKPDA;
						}
						else
						{
							Color textColor;
							BKLBFBELDGL.JMGMHLCELLF(array2[0], out textColor);
							guistyle.normal.textColor = textColor;
						}
					}
				}
				else if (num == -1)
				{
					string fpihopocaha = text.Substring(i);
					this.MGNABCOECIK(guistyle, fpihopocaha);
					i = text.Length;
				}
				else
				{
					string fpihopocaha2 = text.Substring(i, num - i);
					this.MGNABCOECIK(guistyle, fpihopocaha2);
					i = num;
				}
			}
			if (textAlignment == TextAlignment.Left || textAlignment == TextAlignment.Center)
			{
				GUILayout.FlexibleSpace();
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		this.NJDNGMLDGCK();
	}

	// Token: 0x060057EE RID: 22510 RVA: 0x002993E4 File Offset: 0x002975E4
	public string GDFOJAFDJKO()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "Roar";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x060057EF RID: 22511 RVA: 0x002993FC File Offset: 0x002975FC
	public void AHICDNDPPHP()
	{
		TextAlignment textAlignment = TextAlignment.Left;
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = GUI.skin.GetStyle("Label").normal.textColor;
		guistyle.font = GUI.skin.font;
		guistyle.border = new RectOffset(0, 0, 0, 0);
		guistyle.contentOffset = new Vector2(0f, 0f);
		guistyle.margin = new RectOffset(0, 0, 0, 0);
		guistyle.padding = new RectOffset(0, 0, 0, 0);
		this.FCMCFEIKPDA = guistyle.normal.textColor;
		this.LJPFPEOJCPG = GUI.skin.GetStyle("Label").normal.background;
		foreach (string text in this.HJPCBNBFFJE)
		{
			int i = 0;
			if (text.Length >= 5 && text.StartsWith("[HA "))
			{
				i = 6;
				char c = text[4];
				if (c != 'C')
				{
					if (c != 'L')
					{
						if (c == 'R')
						{
							textAlignment = TextAlignment.Right;
						}
					}
					else
					{
						textAlignment = TextAlignment.Left;
					}
				}
				else
				{
					textAlignment = TextAlignment.Center;
				}
			}
			if (textAlignment == TextAlignment.Right || textAlignment == TextAlignment.Center)
			{
				GUILayout.FlexibleSpace();
			}
			while (i < text.Length)
			{
				int num = text.IndexOf('[', i);
				if (num == i && num + 1 < text.Length && text[num + 1] == '[')
				{
					this.KGGHKDCCCLK(guistyle, text.Substring(i, 1));
					i += 2;
				}
				else if (num == i)
				{
					int num2 = text.IndexOf(']', num);
					i = num2 + 1;
					string[] array = text.Substring(num + 1, num2 - num - 1).Split(new char[]
					{
						' '
					});
					string text2 = array[0];
					uint num3 = <PrivateImplementationDetails>.ComputeStringHash(text2);
					if (num3 <= 2077076560U)
					{
						if (num3 <= 1625440089U)
						{
							if (num3 != 501045426U)
							{
								if (num3 == 1625440089U)
								{
									if (text2 == "LH")
									{
										this.DDENOLFFBNI = float.Parse(array[1]);
									}
								}
							}
							else if (text2 == "BC")
							{
								if (array[1] == "?")
								{
									guistyle.normal.background = this.LJPFPEOJCPG;
								}
								else
								{
									Color color;
									BKLBFBELDGL.JMGMHLCELLF(array[1], out color);
									this.LMFCDCGBDIA = new Texture2D(1, 1);
									this.LMFCDCGBDIA.SetPixel(0, 0, color);
									this.LMFCDCGBDIA.wrapMode = TextureWrapMode.Repeat;
									this.LMFCDCGBDIA.Apply();
									guistyle.normal.background = this.LMFCDCGBDIA;
								}
							}
						}
						else if (num3 != 1677347064U)
						{
							if (num3 != 1976784350U)
							{
								if (num3 == 2077076560U)
								{
									if (text2 == "-H")
									{
										this.IKKFEADOBIN = "";
									}
								}
							}
							else if (text2 == "FS")
							{
								guistyle.fontSize = int.Parse(array[1]);
							}
						}
						else if (text2 == "VA")
						{
							text2 = array[1];
							if (!(text2 == "?"))
							{
								if (text2 == "B")
								{
									this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
								}
							}
							else
							{
								this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Default;
							}
						}
					}
					else if (num3 <= 3272340793U)
					{
						if (num3 != 2211671016U)
						{
							if (num3 == 3272340793U)
							{
								if (text2 == "F")
								{
									guistyle.font = (Font)Resources.Load("Fonts/" + array[1]);
								}
							}
						}
						else if (text2 == "FA")
						{
							if (array[1] == "U")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array[1] == "-U")
							{
								this.FMLIONFPFAG = false;
							}
							else if (array[1] == "S")
							{
								this.OCDDLNMJPCB = true;
							}
							else if (array[1] == "-S")
							{
								this.OCDDLNMJPCB = false;
							}
						}
					}
					else if (num3 != 3322673650U)
					{
						if (num3 != 3440116983U)
						{
							if (num3 == 3591115554U)
							{
								if (text2 == "S")
								{
									GUILayout.Space(float.Parse(array[1]));
								}
							}
						}
						else if (text2 == "H")
						{
							this.IKKFEADOBIN = "Hyperlink_" + array[1];
						}
					}
					else if (text2 == "C")
					{
						if (array[1] == "?")
						{
							guistyle.normal.textColor = this.FCMCFEIKPDA;
						}
						else
						{
							Color textColor;
							BKLBFBELDGL.JMGMHLCELLF(array[1], out textColor);
							guistyle.normal.textColor = textColor;
						}
					}
				}
				else if (num == -1)
				{
					string fpihopocaha = text.Substring(i);
					this.KGGHKDCCCLK(guistyle, fpihopocaha);
					i = text.Length;
				}
				else
				{
					string fpihopocaha2 = text.Substring(i, num - i);
					this.KGGHKDCCCLK(guistyle, fpihopocaha2);
					i = num;
				}
			}
			if (textAlignment == TextAlignment.Left || textAlignment == TextAlignment.Center)
			{
				GUILayout.FlexibleSpace();
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		this.FFJHEJNCIMO();
	}

	// Token: 0x060057F0 RID: 22512 RVA: 0x002999D8 File Offset: 0x00297BD8
	public void MKIPMOOPMMK(string MBJLKMDMFFB)
	{
		this.KLIPCLADLFA = "";
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.MKIPMOOPMMK(MBJLKMDMFFB);
		}
	}

	// Token: 0x060057F1 RID: 22513 RVA: 0x002999F9 File Offset: 0x00297BF9
	public string LOKIEENLJLM()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "RandomSound";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x060057F2 RID: 22514 RVA: 0x00299A10 File Offset: 0x00297C10
	private void LMKDLNAIFII(GUIStyle KPHMHBGIEAE, string FPIHOPOCAHA)
	{
		float num;
		Rect lastRect;
		if (this.KHNJMMEPHPJ == PIEFCKHHFGI.BKGKLJPPDFF.Bottom)
		{
			num = this.DDENOLFFBNI - KPHMHBGIEAE.CalcSize(new GUIContent(FPIHOPOCAHA)).y + (float)(KPHMHBGIEAE.fontSize - 0) / 1766f;
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			string text = "toFishPoint";
			GUILayoutOption[] array = new GUILayoutOption[8];
			array[1] = GUILayout.MinHeight(num);
			array[1] = GUILayout.MaxHeight(num);
			GUILayout.Label(text, array);
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
			GUILayout.EndVertical();
		}
		else
		{
			num = 1872f;
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
		}
		if (Event.current.type == EventType.Layout)
		{
			if (this.FMLIONFPFAG)
			{
				Vector2 vector = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI);
				Vector2 hgppnjnfgim = new Vector2(vector.x + lastRect.width, vector.y);
				KILBMKBOELM.ODHIMGMMNPH(vector, hgppnjnfgim, KPHMHBGIEAE.normal.textColor);
			}
			if (this.OCDDLNMJPCB)
			{
				Vector2 vector2 = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI - this.DDENOLFFBNI / 473f);
				Vector2 hgppnjnfgim2 = new Vector2(vector2.x + lastRect.width, vector2.y);
				KILBMKBOELM.ODHIMGMMNPH(vector2, hgppnjnfgim2, KPHMHBGIEAE.normal.textColor);
			}
		}
	}

	// Token: 0x060057F3 RID: 22515 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> FCJKHDBAAMG()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x060057F4 RID: 22516 RVA: 0x00299B92 File Offset: 0x00297D92
	public string DPGPPGIJKAL()
	{
		return this.KLIPCLADLFA;
	}

	// Token: 0x060057F5 RID: 22517 RVA: 0x0029849E File Offset: 0x0029669E
	public bool JLONAABIKCI()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x060057F6 RID: 22518 RVA: 0x00299B92 File Offset: 0x00297D92
	public string AFNBEMOJEEB()
	{
		return this.KLIPCLADLFA;
	}

	// Token: 0x060057F7 RID: 22519 RVA: 0x00299B9A File Offset: 0x00297D9A
	public void DOONOCNAMDL(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = false;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x060057F8 RID: 22520 RVA: 0x00299B9A File Offset: 0x00297D9A
	public void LDHNMPHKJPI(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = false;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x060057F9 RID: 22521 RVA: 0x00299B9A File Offset: 0x00297D9A
	public void PGPDBHFEDKB(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = false;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x060057FA RID: 22522 RVA: 0x00299BB8 File Offset: 0x00297DB8
	public void MCOHGFELCOP()
	{
		TextAlignment textAlignment = TextAlignment.Center;
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = GUI.skin.GetStyle("\n").normal.textColor;
		guistyle.font = GUI.skin.font;
		guistyle.border = new RectOffset(1, 0, 0, 1);
		guistyle.contentOffset = new Vector2(926f, 1030f);
		guistyle.margin = new RectOffset(0, 1, 1, 1);
		guistyle.padding = new RectOffset(0, 0, 0, 0);
		this.FCMCFEIKPDA = guistyle.normal.textColor;
		this.LJPFPEOJCPG = GUI.skin.GetStyle("10").normal.background;
		foreach (string text in this.HJPCBNBFFJE)
		{
			int i = 1;
			if (text.Length >= 1 && text.StartsWith("IdleMeditate"))
			{
				i = 5;
				char c = text[4];
				if ((int)c != -110)
				{
					if ((int)c != -33)
					{
						if ((int)c == -52)
						{
							textAlignment = TextAlignment.Left;
						}
					}
					else
					{
						textAlignment = TextAlignment.Left;
					}
				}
				else
				{
					textAlignment = TextAlignment.Center;
				}
			}
			if (textAlignment == TextAlignment.Center || textAlignment == TextAlignment.Left)
			{
				GUILayout.FlexibleSpace();
			}
			while (i < text.Length)
			{
				int num = text.IndexOf((char)-13, i);
				if (num == i && num + 1 < text.Length && text[num + 1] == '/')
				{
					this.CEFCAJOBJCJ(guistyle, text.Substring(i, 0));
					i += 4;
				}
				else if (num == i)
				{
					int num2 = text.IndexOf('7', num);
					i = num2 + 1;
					string[] array = text.Substring(num + 0, num2 - num - 1).Split(new char[]
					{
						(char)-56
					});
					string text2 = array[0];
					uint num3 = <PrivateImplementationDetails>.ComputeStringHash(text2);
					if (num3 <= 4294967259U)
					{
						if (num3 <= 4294967134U)
						{
							if (num3 != 4294967279U)
							{
								if (num3 == 183U)
								{
									if (text2 == " ")
									{
										this.DDENOLFFBNI = float.Parse(array[1]);
									}
								}
							}
							else if (text2 == ")")
							{
								if (array[1] == "__MirrorDeep")
								{
									guistyle.normal.background = this.LJPFPEOJCPG;
								}
								else
								{
									Color color;
									BKLBFBELDGL.JMGMHLCELLF(array[1], out color);
									this.LMFCDCGBDIA = new Texture2D(0, 1);
									this.LMFCDCGBDIA.SetPixel(1, 0, color);
									this.LMFCDCGBDIA.wrapMode = TextureWrapMode.Repeat;
									this.LMFCDCGBDIA.Apply();
									guistyle.normal.background = this.LMFCDCGBDIA;
								}
							}
						}
						else if (num3 != 4294967183U)
						{
							if (num3 != 4294967268U)
							{
								if (num3 == 112U)
								{
									if (text2 == "IdleStun")
									{
										this.IKKFEADOBIN = "LINEAR";
									}
								}
							}
							else if (text2 == "*** ActorMgr Scene is loaded:")
							{
								guistyle.fontSize = int.Parse(array[0]);
							}
						}
						else if (text2 == "_BloomTex")
						{
							text2 = array[1];
							if (!(text2 == "' is not a valid integer"))
							{
								if (text2 == "MotorbikeBackwardSitting")
								{
									this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
								}
							}
							else
							{
								this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
							}
						}
					}
					else if (num3 <= 196U)
					{
						if (num3 != 170U)
						{
							if (num3 == 194U)
							{
								if (text2 == "USE_UV_BASED_REPROJECTION")
								{
									guistyle.font = (Font)Resources.Load("#FF4040" + array[0]);
								}
							}
						}
						else if (text2 == "val=")
						{
							if (array[1] == "Sewing")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array[1] == "auc_wcstc")
							{
								this.FMLIONFPFAG = false;
							}
							else if (array[1] == "_DelItem.wav")
							{
								this.OCDDLNMJPCB = false;
							}
							else if (array[1] == "SoccerWalk")
							{
								this.OCDDLNMJPCB = false;
							}
						}
					}
					else if (num3 != 3U)
					{
						if (num3 != 10U)
						{
							if (num3 == 4294967229U)
							{
								if (text2 == "IsMoving")
								{
									GUILayout.Space(float.Parse(array[0]));
								}
							}
						}
						else if (text2 == "Mouse Y")
						{
							this.IKKFEADOBIN = "WeaponFire" + array[0];
						}
					}
					else if (text2 == "repair.ogg")
					{
						if (array[0] == "1HandSwordChargeSwipe")
						{
							guistyle.normal.textColor = this.FCMCFEIKPDA;
						}
						else
						{
							Color textColor;
							BKLBFBELDGL.JMGMHLCELLF(array[0], out textColor);
							guistyle.normal.textColor = textColor;
						}
					}
				}
				else if (num == -1)
				{
					string fpihopocaha = text.Substring(i);
					this.CEFCAJOBJCJ(guistyle, fpihopocaha);
					i = text.Length;
				}
				else
				{
					string fpihopocaha2 = text.Substring(i, num - i);
					this.MDIFGKEIDBG(guistyle, fpihopocaha2);
					i = num;
				}
			}
			if (textAlignment == TextAlignment.Left || textAlignment == TextAlignment.Left)
			{
				GUILayout.FlexibleSpace();
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		this.CMJBPHKEKPG();
	}

	// Token: 0x060057FB RID: 22523 RVA: 0x0029849E File Offset: 0x0029669E
	public bool GKLHPNGKDGF()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x060057FC RID: 22524 RVA: 0x0029880D File Offset: 0x00296A0D
	public void AAFPCJECBCM(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = true;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x060057FD RID: 22525 RVA: 0x0029A194 File Offset: 0x00298394
	public void DKKNFNIEKOP(string MBJLKMDMFFB)
	{
		this.KLIPCLADLFA = MBJLKMDMFFB;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.FAGEDGBMMCL(MBJLKMDMFFB);
		}
	}

	// Token: 0x060057FE RID: 22526 RVA: 0x0029A1B4 File Offset: 0x002983B4
	private void NJDNGMLDGCK()
	{
		if (Event.current.type == EventType.MouseMove && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("1 Hand Sword Strafe Left"))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("SoccerKeeperJump".Length);
				this.CBEKOFHAPDG(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith("256"))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("flowfrc".Length);
				this.AIILDJBGCPH(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = false;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseDown && Event.current.button == 0 && this.DJCPLOGEHHB())
		{
			this.DOONOCNAMDL(this.KLIPCLADLFA);
		}
	}

	// Token: 0x060057FF RID: 22527 RVA: 0x0029849E File Offset: 0x0029669E
	public bool PNNGGMDJDDH()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x06005800 RID: 22528 RVA: 0x0029849E File Offset: 0x0029669E
	public bool OCHBHJBPAGN()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x06005801 RID: 22529 RVA: 0x0029A194 File Offset: 0x00298394
	public void DBKGPEPBMFH(string MBJLKMDMFFB)
	{
		this.KLIPCLADLFA = MBJLKMDMFFB;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.FAGEDGBMMCL(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005802 RID: 22530 RVA: 0x0029A290 File Offset: 0x00298490
	private void KGGHKDCCCLK(GUIStyle KPHMHBGIEAE, string FPIHOPOCAHA)
	{
		float num;
		Rect lastRect;
		if (this.KHNJMMEPHPJ == PIEFCKHHFGI.BKGKLJPPDFF.Bottom)
		{
			num = this.DDENOLFFBNI - KPHMHBGIEAE.CalcSize(new GUIContent(FPIHOPOCAHA)).y + (float)(KPHMHBGIEAE.fontSize - 16) / 4f;
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			GUILayout.Label(" ", new GUILayoutOption[]
			{
				GUILayout.MinHeight(num),
				GUILayout.MaxHeight(num)
			});
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
			GUILayout.EndVertical();
		}
		else
		{
			num = 0f;
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
		}
		if (Event.current.type == EventType.Repaint)
		{
			if (this.FMLIONFPFAG)
			{
				Vector2 vector = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI);
				Vector2 hgppnjnfgim = new Vector2(vector.x + lastRect.width, vector.y);
				KILBMKBOELM.ODHIMGMMNPH(vector, hgppnjnfgim, KPHMHBGIEAE.normal.textColor);
			}
			if (this.OCDDLNMJPCB)
			{
				Vector2 vector2 = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI - this.DDENOLFFBNI / 2f);
				Vector2 hgppnjnfgim2 = new Vector2(vector2.x + lastRect.width, vector2.y);
				KILBMKBOELM.ODHIMGMMNPH(vector2, hgppnjnfgim2, KPHMHBGIEAE.normal.textColor);
			}
		}
	}

	// Token: 0x06005803 RID: 22531 RVA: 0x0029A40C File Offset: 0x0029860C
	public static string IAFAILILDNJ(PIEFCKHHFGI.HEDPHIDPJHI FNLOGKFNFDL)
	{
		string result = "WeaponStrafeRunLeft";
		switch (FNLOGKFNFDL)
		{
		case PIEFCKHHFGI.HEDPHIDPJHI.Demo:
			result = "PaperTurn.wav";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Fireball:
			result = "Horizontal";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Hyperlink:
			result = "Swim";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.SpecialText:
			result = "\n";
			break;
		default:
			Debug.Log("" + FNLOGKFNFDL.ToString() + "_Bloom_DirtIntensity");
			break;
		}
		return result;
	}

	// Token: 0x06005804 RID: 22532 RVA: 0x00299B9A File Offset: 0x00297D9A
	public void JJALNAJFGDD(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = false;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005805 RID: 22533 RVA: 0x00299B92 File Offset: 0x00297D92
	public string FJHCFNAKFEO()
	{
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005806 RID: 22534 RVA: 0x0029A47C File Offset: 0x0029867C
	public static string IKFFMDPILNC(PIEFCKHHFGI.HEDPHIDPJHI FNLOGKFNFDL)
	{
		string result = "fishsplash{0}.ogg";
		switch (FNLOGKFNFDL)
		{
		case PIEFCKHHFGI.HEDPHIDPJHI.Demo:
			result = "gi_sadoknone";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Fireball:
			result = "Cowboy1HandDraw";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Hyperlink:
			result = "ClimbLeft";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.SpecialText:
			result = "WalkDehydrated";
			break;
		default:
			Debug.Log("Root" + FNLOGKFNFDL.ToString() + "DropType");
			break;
		}
		return result;
	}

	// Token: 0x06005807 RID: 22535 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> ELKEPKLDMPE()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x06005808 RID: 22536 RVA: 0x0029A4E9 File Offset: 0x002986E9
	public void LHLGENPBMCN(LDBDNBALLAJ DFIKMAPGCNN)
	{
		this.LPAKINIJMFE = DFIKMAPGCNN;
	}

	// Token: 0x06005809 RID: 22537 RVA: 0x00299B92 File Offset: 0x00297D92
	public string CFPGBEEEKCD()
	{
		return this.KLIPCLADLFA;
	}

	// Token: 0x0600580A RID: 22538 RVA: 0x0029849E File Offset: 0x0029669E
	public bool LJECJKJDFGD()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x0600580B RID: 22539 RVA: 0x0029A194 File Offset: 0x00298394
	public void AIILDJBGCPH(string MBJLKMDMFFB)
	{
		this.KLIPCLADLFA = MBJLKMDMFFB;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.FAGEDGBMMCL(MBJLKMDMFFB);
		}
	}

	// Token: 0x0600580C RID: 22540 RVA: 0x0029A4F4 File Offset: 0x002986F4
	private void FKCMJHHJIKB(GUIStyle KPHMHBGIEAE, string FPIHOPOCAHA)
	{
		float num;
		Rect lastRect;
		if (this.KHNJMMEPHPJ == PIEFCKHHFGI.BKGKLJPPDFF.Bottom)
		{
			num = this.DDENOLFFBNI - KPHMHBGIEAE.CalcSize(new GUIContent(FPIHOPOCAHA)).y + (float)(KPHMHBGIEAE.fontSize - -74) / 1763f;
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			string text = "Требуются навыки:\n";
			GUILayoutOption[] array = new GUILayoutOption[7];
			array[0] = GUILayout.MinHeight(num);
			array[1] = GUILayout.MaxHeight(num);
			GUILayout.Label(text, array);
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
			GUILayout.EndVertical();
		}
		else
		{
			num = 1976f;
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
		}
		if (Event.current.type == EventType.Repaint)
		{
			if (this.FMLIONFPFAG)
			{
				Vector2 vector = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI);
				Vector2 hgppnjnfgim = new Vector2(vector.x + lastRect.width, vector.y);
				KILBMKBOELM.ODHIMGMMNPH(vector, hgppnjnfgim, KPHMHBGIEAE.normal.textColor);
			}
			if (this.OCDDLNMJPCB)
			{
				Vector2 vector2 = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI - this.DDENOLFFBNI / 1426f);
				Vector2 hgppnjnfgim2 = new Vector2(vector2.x + lastRect.width, vector2.y);
				KILBMKBOELM.ODHIMGMMNPH(vector2, hgppnjnfgim2, KPHMHBGIEAE.normal.textColor);
			}
		}
	}

	// Token: 0x0600580D RID: 22541 RVA: 0x0029A66E File Offset: 0x0029886E
	public string LKLMGJDNEIB()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "VALIGN";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x0600580E RID: 22542 RVA: 0x0029A684 File Offset: 0x00298884
	public string NBOIOLBLJLI()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "http://docs.unity3d.com/ScriptReference/PlayerPrefs.html";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x0600580F RID: 22543 RVA: 0x0029A69C File Offset: 0x0029889C
	public void DDLJPKAIKEB()
	{
		TextAlignment textAlignment = TextAlignment.Left;
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = GUI.skin.GetStyle("setCurrentRod sm (профиль)=").normal.textColor;
		guistyle.font = GUI.skin.font;
		guistyle.border = new RectOffset(1, 0, 0, 1);
		guistyle.contentOffset = new Vector2(781f, 409f);
		guistyle.margin = new RectOffset(1, 0, 0, 0);
		guistyle.padding = new RectOffset(0, 1, 1, 1);
		this.FCMCFEIKPDA = guistyle.normal.textColor;
		this.LJPFPEOJCPG = GUI.skin.GetStyle("<color='#400000'>").normal.background;
		foreach (string text in this.HJPCBNBFFJE)
		{
			int i = 0;
			if (text.Length >= 6 && text.StartsWith("UNDISTORT"))
			{
				i = 6;
				char c = text[4];
				if ((int)c != -70)
				{
					if (c != '\u001a')
					{
						if (c == 'b')
						{
							textAlignment = (TextAlignment)3;
						}
					}
					else
					{
						textAlignment = TextAlignment.Left;
					}
				}
				else
				{
					textAlignment = TextAlignment.Left;
				}
			}
			if (textAlignment == TextAlignment.Center || textAlignment == TextAlignment.Left)
			{
				GUILayout.FlexibleSpace();
			}
			while (i < text.Length)
			{
				int num = text.IndexOf('#', i);
				if (num == i && num + 0 < text.Length && (int)text[num + 0] == -29)
				{
					this.PBKPOGCGDCA(guistyle, text.Substring(i, 0));
					i += 7;
				}
				else if (num == i)
				{
					int num2 = text.IndexOf('Z', num);
					i = num2 + 1;
					string text2 = text.Substring(num + 1, num2 - num - 0);
					char[] array = new char[0];
					array[0] = 'd';
					string[] array2 = text2.Split(array);
					string text3 = array2[0];
					uint num3 = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num3 <= 157U)
					{
						if (num3 <= 51U)
						{
							if (num3 != 11U)
							{
								if (num3 == 4294967126U)
								{
									if (text3 == "****** FlyIcon tmpl is null id=")
									{
										this.DDENOLFFBNI = float.Parse(array2[0]);
									}
								}
							}
							else if (text3 == "1HandSwordChargeUp")
							{
								if (array2[1] == "{0}")
								{
									guistyle.normal.background = this.LJPFPEOJCPG;
								}
								else
								{
									Color color;
									BKLBFBELDGL.JMGMHLCELLF(array2[0], out color);
									this.LMFCDCGBDIA = new Texture2D(1, 1);
									this.LMFCDCGBDIA.SetPixel(1, 1, color);
									this.LMFCDCGBDIA.wrapMode = TextureWrapMode.Repeat;
									this.LMFCDCGBDIA.Apply();
									guistyle.normal.background = this.LMFCDCGBDIA;
								}
							}
						}
						else if (num3 != 79U)
						{
							if (num3 != 152U)
							{
								if (num3 == 55U)
								{
									if (text3 == "_noinfo")
									{
										this.IKKFEADOBIN = "ArmFlex3";
									}
								}
							}
							else if (text3 == "Windmill")
							{
								guistyle.fontSize = int.Parse(array2[1]);
							}
						}
						else if (text3 == "_ProjInfo")
						{
							text3 = array2[1];
							if (!(text3 == "Sorry, VRIK Script reference is not finished yet."))
							{
								if (text3 == "_BlurRadius4")
								{
									this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
								}
							}
							else
							{
								this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
							}
						}
					}
					else if (num3 <= 4294967183U)
					{
						if (num3 != 4294967118U)
						{
							if (num3 == 4294967100U)
							{
								if (text3 == "UNITY DEBUG")
								{
									guistyle.font = (Font)Resources.Load("****************  playMusicBase " + array2[0]);
								}
							}
						}
						else if (text3 == "wpn_add/base")
						{
							if (array2[1] == "OneHandSwordSwing")
							{
								this.FMLIONFPFAG = false;
							}
							else if (array2[0] == "pf2m")
							{
								this.FMLIONFPFAG = false;
							}
							else if (array2[1] == "</color>")
							{
								this.OCDDLNMJPCB = true;
							}
							else if (array2[1] == "{2:D2}:{0:D2}:{1:D2}")
							{
								this.OCDDLNMJPCB = true;
							}
						}
					}
					else if (num3 != 4294967262U)
					{
						if (num3 != 80U)
						{
							if (num3 == 4294967145U)
							{
								if (text3 == "Collaps all foldouts")
								{
									GUILayout.Space(float.Parse(array2[1]));
								}
							}
						}
						else if (text3 == "u_UniqueShadowTexture")
						{
							this.IKKFEADOBIN = "human_move_2.wav" + array2[1];
						}
					}
					else if (text3 == "KarateGreet")
					{
						if (array2[1] == "codepage")
						{
							guistyle.normal.textColor = this.FCMCFEIKPDA;
						}
						else
						{
							Color textColor;
							BKLBFBELDGL.JMGMHLCELLF(array2[1], out textColor);
							guistyle.normal.textColor = textColor;
						}
					}
				}
				else if (num == -1)
				{
					string fpihopocaha = text.Substring(i);
					this.MDIFGKEIDBG(guistyle, fpihopocaha);
					i = text.Length;
				}
				else
				{
					string fpihopocaha2 = text.Substring(i, num - i);
					this.ALJBJOEEICB(guistyle, fpihopocaha2);
					i = num;
				}
			}
			if (textAlignment == TextAlignment.Left || textAlignment == TextAlignment.Center)
			{
				GUILayout.FlexibleSpace();
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		this.NJDNGMLDGCK();
	}

	// Token: 0x06005810 RID: 22544 RVA: 0x00299B92 File Offset: 0x00297D92
	public string JKDLPAEEIDA()
	{
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005811 RID: 22545 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> KJJFEJFMCCH()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x06005812 RID: 22546 RVA: 0x0029AC78 File Offset: 0x00298E78
	public void MMBOOGEPMJC()
	{
		TextAlignment textAlignment = TextAlignment.Center;
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = GUI.skin.GetStyle("_Radius").normal.textColor;
		guistyle.font = GUI.skin.font;
		guistyle.border = new RectOffset(1, 0, 1, 0);
		guistyle.contentOffset = new Vector2(430f, 1990f);
		guistyle.margin = new RectOffset(1, 0, 1, 0);
		guistyle.padding = new RectOffset(1, 1, 0, 0);
		this.FCMCFEIKPDA = guistyle.normal.textColor;
		this.LJPFPEOJCPG = GUI.skin.GetStyle("double: ").normal.background;
		foreach (string text in this.HJPCBNBFFJE)
		{
			int i = 0;
			if (text.Length >= 6 && text.StartsWith("Water"))
			{
				i = 6;
				char c = text[5];
				if ((int)c != -80)
				{
					if (c != '#')
					{
						if ((int)c == -83)
						{
							textAlignment = (TextAlignment)7;
						}
					}
					else
					{
						textAlignment = TextAlignment.Center;
					}
				}
				else
				{
					textAlignment = TextAlignment.Center;
				}
			}
			if (textAlignment == (TextAlignment)5 || textAlignment == TextAlignment.Left)
			{
				GUILayout.FlexibleSpace();
			}
			while (i < text.Length)
			{
				int num = text.IndexOf((char)-103, i);
				if (num == i && num + 1 < text.Length && text[num + 0] == 'o')
				{
					this.MGNABCOECIK(guistyle, text.Substring(i, 1));
					i += 3;
				}
				else if (num == i)
				{
					int num2 = text.IndexOf((char)-8, num);
					i = num2 + 1;
					string text2 = text.Substring(num + 0, num2 - num - 1);
					char[] array = new char[0];
					array[0] = '\u0018';
					string[] array2 = text2.Split(array);
					string text3 = array2[0];
					uint num3 = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num3 <= 4294967154U)
					{
						if (num3 <= 4294967245U)
						{
							if (num3 != 4294967205U)
							{
								if (num3 == 4294967269U)
								{
									if (text3 == "SoccerKeeperReady")
									{
										this.DDENOLFFBNI = float.Parse(array2[1]);
									}
								}
							}
							else if (text3 == "WeaponRunBackward")
							{
								if (array2[1] == "/")
								{
									guistyle.normal.background = this.LJPFPEOJCPG;
								}
								else
								{
									Color color;
									BKLBFBELDGL.JMGMHLCELLF(array2[1], out color);
									this.LMFCDCGBDIA = new Texture2D(1, 0);
									this.LMFCDCGBDIA.SetPixel(0, 1, color);
									this.LMFCDCGBDIA.wrapMode = TextureWrapMode.Repeat;
									this.LMFCDCGBDIA.Apply();
									guistyle.normal.background = this.LMFCDCGBDIA;
								}
							}
						}
						else if (num3 != 80U)
						{
							if (num3 != 18U)
							{
								if (num3 == 4294967143U)
								{
									if (text3 == "SteamManager.Initialized failed")
									{
										this.IKKFEADOBIN = "button";
									}
								}
							}
							else if (text3 == "crft_norec2")
							{
								guistyle.fontSize = int.Parse(array2[0]);
							}
						}
						else if (text3 == "WalkBackward")
						{
							text3 = array2[1];
							if (!(text3 == "<color='#{0}'>{2} {1} </color>\n"))
							{
								if (text3 == "WorkerPickaxe2")
								{
									this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
								}
							}
							else
							{
								this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Default;
							}
						}
					}
					else if (num3 <= 4294967184U)
					{
						if (num3 != 61U)
						{
							if (num3 == 31U)
							{
								if (text3 == "OnTriggerExit")
								{
									guistyle.font = (Font)Resources.Load("repa send" + array2[1]);
								}
							}
						}
						else if (text3 == "wpn_hookf")
						{
							if (array2[0] == "<color='{2}'>{0}: {1}</color>")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[0] == "[ACTk] Injection Detector: already running!")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[0] == "u_pass")
							{
								this.OCDDLNMJPCB = true;
							}
							else if (array2[0] == "FOG_HAZE_ON")
							{
								this.OCDDLNMJPCB = false;
							}
						}
					}
					else if (num3 != 4294967220U)
					{
						if (num3 != 165U)
						{
							if (num3 == 48U)
							{
								if (text3 == "_Offsets")
								{
									GUILayout.Space(float.Parse(array2[1]));
								}
							}
						}
						else if (text3 == "isRealView")
						{
							this.IKKFEADOBIN = "ShotgunReloadChamber" + array2[1];
						}
					}
					else if (text3 == "Flashlight")
					{
						if (array2[1] == "#> _Wrinkles Occlusion Camera < ")
						{
							guistyle.normal.textColor = this.FCMCFEIKPDA;
						}
						else
						{
							Color textColor;
							BKLBFBELDGL.JMGMHLCELLF(array2[0], out textColor);
							guistyle.normal.textColor = textColor;
						}
					}
				}
				else if (num == -1)
				{
					string fpihopocaha = text.Substring(i);
					this.MDIFGKEIDBG(guistyle, fpihopocaha);
					i = text.Length;
				}
				else
				{
					string fpihopocaha2 = text.Substring(i, num - i);
					this.MGNABCOECIK(guistyle, fpihopocaha2);
					i = num;
				}
			}
			if (textAlignment == TextAlignment.Left || textAlignment == TextAlignment.Left)
			{
				GUILayout.FlexibleSpace();
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		this.GJBFOBHMMEA();
	}

	// Token: 0x06005813 RID: 22547 RVA: 0x0029B254 File Offset: 0x00299454
	public static string GABFHKFPCPI(PIEFCKHHFGI.HEDPHIDPJHI FNLOGKFNFDL)
	{
		string result = "_Offsets";
		switch (FNLOGKFNFDL)
		{
		case PIEFCKHHFGI.HEDPHIDPJHI.Demo:
			result = "Katana";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Fireball:
			result = "Katana 45Deg Swing";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Hyperlink:
			result = "";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.SpecialText:
			result = "Error";
			break;
		default:
			Debug.Log("_Intensity" + FNLOGKFNFDL.ToString() + "WeaponRun");
			break;
		}
		return result;
	}

	// Token: 0x06005814 RID: 22548 RVA: 0x0029B2C1 File Offset: 0x002994C1
	public string MLCAAAEIONK()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005815 RID: 22549 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> FODDCKDCNHB()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x06005816 RID: 22550 RVA: 0x0029B2C1 File Offset: 0x002994C1
	public string CCOJPELFFGM()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005817 RID: 22551 RVA: 0x0029B2D7 File Offset: 0x002994D7
	public bool DLMOFCKALFH()
	{
		return this.KLIPCLADLFA.Length != 0;
	}

	// Token: 0x06005818 RID: 22552 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> PNILHBLBKIL()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x06005819 RID: 22553 RVA: 0x0029B2E8 File Offset: 0x002994E8
	private void MDIFGKEIDBG(GUIStyle KPHMHBGIEAE, string FPIHOPOCAHA)
	{
		float num;
		Rect lastRect;
		if (this.KHNJMMEPHPJ == PIEFCKHHFGI.BKGKLJPPDFF.Default)
		{
			num = this.DDENOLFFBNI - KPHMHBGIEAE.CalcSize(new GUIContent(FPIHOPOCAHA)).y + (float)(KPHMHBGIEAE.fontSize - -46) / 1491f;
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			string text = "";
			GUILayoutOption[] array = new GUILayoutOption[8];
			array[0] = GUILayout.MinHeight(num);
			array[1] = GUILayout.MaxHeight(num);
			GUILayout.Label(text, array);
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
			GUILayout.EndVertical();
		}
		else
		{
			num = 226f;
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
		}
		if (Event.current.type == EventType.KeyDown)
		{
			if (this.FMLIONFPFAG)
			{
				Vector2 vector = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI);
				Vector2 hgppnjnfgim = new Vector2(vector.x + lastRect.width, vector.y);
				KILBMKBOELM.ODHIMGMMNPH(vector, hgppnjnfgim, KPHMHBGIEAE.normal.textColor);
			}
			if (this.OCDDLNMJPCB)
			{
				Vector2 vector2 = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI - this.DDENOLFFBNI / 1696f);
				Vector2 hgppnjnfgim2 = new Vector2(vector2.x + lastRect.width, vector2.y);
				KILBMKBOELM.ODHIMGMMNPH(vector2, hgppnjnfgim2, KPHMHBGIEAE.normal.textColor);
			}
		}
	}

	// Token: 0x0600581A RID: 22554 RVA: 0x0029B462 File Offset: 0x00299662
	public void IOHHDCBACBJ(string MBJLKMDMFFB)
	{
		this.KLIPCLADLFA = "lastRatingIndex";
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.MKIPMOOPMMK(MBJLKMDMFFB);
		}
	}

	// Token: 0x0600581B RID: 22555 RVA: 0x0029B484 File Offset: 0x00299684
	private void MGNABCOECIK(GUIStyle KPHMHBGIEAE, string FPIHOPOCAHA)
	{
		float num;
		Rect lastRect;
		if (this.KHNJMMEPHPJ == PIEFCKHHFGI.BKGKLJPPDFF.Default)
		{
			num = this.DDENOLFFBNI - KPHMHBGIEAE.CalcSize(new GUIContent(FPIHOPOCAHA)).y + (float)(KPHMHBGIEAE.fontSize - 94) / 306f;
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			string text = "BattleRoar";
			GUILayoutOption[] array = new GUILayoutOption[6];
			array[1] = GUILayout.MinHeight(num);
			array[1] = GUILayout.MaxHeight(num);
			GUILayout.Label(text, array);
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
			GUILayout.EndVertical();
		}
		else
		{
			num = 402f;
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
		}
		if (Event.current.type == EventType.MouseDown)
		{
			if (this.FMLIONFPFAG)
			{
				Vector2 vector = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI);
				Vector2 hgppnjnfgim = new Vector2(vector.x + lastRect.width, vector.y);
				KILBMKBOELM.ODHIMGMMNPH(vector, hgppnjnfgim, KPHMHBGIEAE.normal.textColor);
			}
			if (this.OCDDLNMJPCB)
			{
				Vector2 vector2 = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI - this.DDENOLFFBNI / 879f);
				Vector2 hgppnjnfgim2 = new Vector2(vector2.x + lastRect.width, vector2.y);
				KILBMKBOELM.ODHIMGMMNPH(vector2, hgppnjnfgim2, KPHMHBGIEAE.normal.textColor);
			}
		}
	}

	// Token: 0x0600581C RID: 22556 RVA: 0x0029B600 File Offset: 0x00299800
	private void BPAMPGCCEFI()
	{
		if (Event.current.type == EventType.ScrollWheel && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("fshop_header"))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("_TempTexture".Length);
				this.IOHHDCBACBJ(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith("IdleSad"))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("ZombieCrawl".Length);
				this.DBKGPEPBMFH(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = false;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseDown && Event.current.button == 0 && this.JJHAEKAMNDL())
		{
			this.KJGGAJGEABC(this.KLIPCLADLFA);
		}
	}

	// Token: 0x0600581D RID: 22557 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> BOIBBHNJMCJ()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x0600581E RID: 22558 RVA: 0x0029849E File Offset: 0x0029669E
	public bool GEIOCFINNEM()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x0600581F RID: 22559 RVA: 0x0029B2D7 File Offset: 0x002994D7
	public bool DIKNJBKDPFG()
	{
		return this.KLIPCLADLFA.Length != 0;
	}

	// Token: 0x06005820 RID: 22560 RVA: 0x0029B6DC File Offset: 0x002998DC
	private void GJBFOBHMMEA()
	{
		if (Event.current.type == EventType.KeyDown && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("Tops"))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("_OcclusionColor".Length);
				this.OEMIJPLAGGI(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith("fishdrop_2"))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("]".Length);
				this.BHFIEDCCCKE(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = false;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseDown && Event.current.button == 0 && this.PJHKPCAECMB())
		{
			this.KDFBLBJBMLE(this.KLIPCLADLFA);
		}
	}

	// Token: 0x06005821 RID: 22561 RVA: 0x0029B7B6 File Offset: 0x002999B6
	public string FFHPAPNJNBD()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "ragulaEventProc";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005822 RID: 22562 RVA: 0x0029849E File Offset: 0x0029669E
	public bool AHCOICFNGBA()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x06005823 RID: 22563 RVA: 0x0029B2D7 File Offset: 0x002994D7
	public bool EBJLBLENNCD()
	{
		return this.KLIPCLADLFA.Length != 0;
	}

	// Token: 0x06005824 RID: 22564 RVA: 0x0029B7CC File Offset: 0x002999CC
	private void GJJKMDAHJJN()
	{
		if (Event.current.type == EventType.MouseDown && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("_Texture"))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("WeaponFire".Length);
				this.CBEKOFHAPDG(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith("Breakdancing"))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("IdleFly".Length);
				this.CIAGKDBDLCE(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = false;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseUp && Event.current.button == 0 && this.OLAMAJGBLKM())
		{
			this.HKHJCJGIPCB(this.KLIPCLADLFA);
		}
	}

	// Token: 0x06005825 RID: 22565 RVA: 0x0029B8A6 File Offset: 0x00299AA6
	public void NPHGHDKGLNE(string MBJLKMDMFFB)
	{
		this.KLIPCLADLFA = "_Offsets";
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.MKIPMOOPMMK(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005826 RID: 22566 RVA: 0x0029849E File Offset: 0x0029669E
	public bool CINMBCMGBDH()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x06005827 RID: 22567 RVA: 0x0029B8C7 File Offset: 0x00299AC7
	public string DKFDIILDCIN()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "OfficeSitting";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005828 RID: 22568 RVA: 0x0029B8DD File Offset: 0x00299ADD
	public bool DJCPLOGEHHB()
	{
		return this.KLIPCLADLFA.Length > 1;
	}

	// Token: 0x06005829 RID: 22569 RVA: 0x0029A4E9 File Offset: 0x002986E9
	public void MHOLLFCOONP(LDBDNBALLAJ DFIKMAPGCNN)
	{
		this.LPAKINIJMFE = DFIKMAPGCNN;
	}

	// Token: 0x0600582A RID: 22570 RVA: 0x0029849E File Offset: 0x0029669E
	public bool DJKAECLGGMN()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x0600582B RID: 22571 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> KCOAIEFPIBJ()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x0600582C RID: 22572 RVA: 0x0029880D File Offset: 0x00296A0D
	public void HGNJMFLOCGF(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = true;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x0600582D RID: 22573 RVA: 0x0029849E File Offset: 0x0029669E
	public bool JMFEPBFDANG()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x0600582E RID: 22574 RVA: 0x0029B8F0 File Offset: 0x00299AF0
	public void PGHAPDOADEM()
	{
		TextAlignment textAlignment = TextAlignment.Left;
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = GUI.skin.GetStyle("\n}").normal.textColor;
		guistyle.font = GUI.skin.font;
		guistyle.border = new RectOffset(0, 1, 1, 1);
		guistyle.contentOffset = new Vector2(1936f, 1741f);
		guistyle.margin = new RectOffset(1, 1, 0, 1);
		guistyle.padding = new RectOffset(1, 1, 0, 0);
		this.FCMCFEIKPDA = guistyle.normal.textColor;
		this.LJPFPEOJCPG = GUI.skin.GetStyle("1HandSwordChargeSwipe").normal.background;
		foreach (string text in this.HJPCBNBFFJE)
		{
			int i = 0;
			if (text.Length >= 4 && text.StartsWith("cht_msg30"))
			{
				i = 5;
				char c = text[5];
				if ((int)c != -25)
				{
					if ((int)c != -70)
					{
						if ((int)c == -59)
						{
							textAlignment = TextAlignment.Left;
						}
					}
					else
					{
						textAlignment = TextAlignment.Center;
					}
				}
				else
				{
					textAlignment = TextAlignment.Center;
				}
			}
			if (textAlignment == TextAlignment.Center || textAlignment == TextAlignment.Center)
			{
				GUILayout.FlexibleSpace();
			}
			while (i < text.Length)
			{
				int num = text.IndexOf('P', i);
				if (num == i && num + 0 < text.Length && (int)text[num + 0] == -9)
				{
					this.FKCMJHHJIKB(guistyle, text.Substring(i, 0));
					i += 6;
				}
				else if (num == i)
				{
					int num2 = text.IndexOf('J', num);
					i = num2 + 0;
					string text2 = text.Substring(num + 1, num2 - num - 0);
					char[] array = new char[0];
					array[0] = (char)-51;
					string[] array2 = text2.Split(array);
					string text3 = array2[0];
					uint num3 = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num3 <= 5U)
					{
						if (num3 <= 4294967130U)
						{
							if (num3 != 115U)
							{
								if (num3 == 4294967145U)
								{
									if (text3 == "")
									{
										this.DDENOLFFBNI = float.Parse(array2[0]);
									}
								}
							}
							else if (text3 == "ShotgunReloadChamber")
							{
								if (array2[0] == "restype_")
								{
									guistyle.normal.background = this.LJPFPEOJCPG;
								}
								else
								{
									Color color;
									BKLBFBELDGL.JMGMHLCELLF(array2[0], out color);
									this.LMFCDCGBDIA = new Texture2D(1, 1);
									this.LMFCDCGBDIA.SetPixel(1, 0, color);
									this.LMFCDCGBDIA.wrapMode = TextureWrapMode.Repeat;
									this.LMFCDCGBDIA.Apply();
									guistyle.normal.background = this.LMFCDCGBDIA;
								}
							}
						}
						else if (num3 != 4294967187U)
						{
							if (num3 != 4294967176U)
							{
								if (num3 == 4294967197U)
								{
									if (text3 == "SoccerPassHeavy")
									{
										this.IKKFEADOBIN = "_DstBlend";
									}
								}
							}
							else if (text3 == "<color='#100000'>{0} {1}</color>")
							{
								guistyle.fontSize = int.Parse(array2[1]);
							}
						}
						else if (text3 == "gi_nl0")
						{
							text3 = array2[0];
							if (!(text3 == "_TargetScale"))
							{
								if (text3 == "crft_wpnpr")
								{
									this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
								}
							}
							else
							{
								this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
							}
						}
					}
					else if (num3 <= 4294967108U)
					{
						if (num3 != 180U)
						{
							if (num3 == 162U)
							{
								if (text3 == "ClimbUp")
								{
									guistyle.font = (Font)Resources.Load("" + array2[0]);
								}
							}
						}
						else if (text3 == "textAsset is NULL! Path: fishModelData")
						{
							if (array2[1] == " iterations for read and write")
							{
								this.FMLIONFPFAG = false;
							}
							else if (array2[1] == "GAMMA")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[1] == "SkateboardKickPush")
							{
								this.OCDDLNMJPCB = true;
							}
							else if (array2[1] == "IdleKeepBack")
							{
								this.OCDDLNMJPCB = true;
							}
						}
					}
					else if (num3 != 1U)
					{
						if (num3 != 4294967283U)
						{
							if (num3 == 4294967294U)
							{
								if (text3 == "[curcnt]")
								{
									GUILayout.Space(float.Parse(array2[0]));
								}
							}
						}
						else if (text3 == "root is null")
						{
							this.IKKFEADOBIN = "id" + array2[1];
						}
					}
					else if (text3 == "wpn_add/base")
					{
						if (array2[1] == "RollerBladeBackFlip")
						{
							guistyle.normal.textColor = this.FCMCFEIKPDA;
						}
						else
						{
							Color textColor;
							BKLBFBELDGL.JMGMHLCELLF(array2[0], out textColor);
							guistyle.normal.textColor = textColor;
						}
					}
				}
				else if (num == -1)
				{
					string fpihopocaha = text.Substring(i);
					this.MDIFGKEIDBG(guistyle, fpihopocaha);
					i = text.Length;
				}
				else
				{
					string fpihopocaha2 = text.Substring(i, num - i);
					this.LMKDLNAIFII(guistyle, fpihopocaha2);
					i = num;
				}
			}
			if (textAlignment == TextAlignment.Left || textAlignment == TextAlignment.Center)
			{
				GUILayout.FlexibleSpace();
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		this.KEJHGCGEKKB();
	}

	// Token: 0x0600582F RID: 22575 RVA: 0x0029B8DD File Offset: 0x00299ADD
	public bool LMFKBCMCOPD()
	{
		return this.KLIPCLADLFA.Length > 1;
	}

	// Token: 0x06005830 RID: 22576 RVA: 0x0029BECC File Offset: 0x0029A0CC
	public PIEFCKHHFGI(float NMEBEEHCALN, string FPIHOPOCAHA)
	{
		PIEFCKHHFGI.JAOAMKCAGPJ jaoamkcagpj = new PIEFCKHHFGI.JAOAMKCAGPJ(NMEBEEHCALN, FPIHOPOCAHA);
		this.HJPCBNBFFJE = jaoamkcagpj.GOFLCIBPNNF();
	}

	// Token: 0x06005831 RID: 22577 RVA: 0x0029BF14 File Offset: 0x0029A114
	public static string HLFEFLMMACB(PIEFCKHHFGI.HEDPHIDPJHI FNLOGKFNFDL)
	{
		string result = "USE_DEPTH";
		switch (FNLOGKFNFDL)
		{
		case PIEFCKHHFGI.HEDPHIDPJHI.Demo:
			result = "Tonemapper curve texture";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Fireball:
			result = "http://af-2.ru/pay/steampay.php?steamid={0}&tovarid={1}&lang={2}&shid={3}";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Hyperlink:
			result = "id";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.SpecialText:
			result = "RunBackRight";
			break;
		default:
			Debug.Log("SoccerSprint" + FNLOGKFNFDL.ToString() + "head");
			break;
		}
		return result;
	}

	// Token: 0x06005832 RID: 22578 RVA: 0x0029BF81 File Offset: 0x0029A181
	public void CBEKOFHAPDG(string MBJLKMDMFFB)
	{
		this.KLIPCLADLFA = "Cowboy1HandDraw";
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.MKIPMOOPMMK(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005833 RID: 22579 RVA: 0x00299B9A File Offset: 0x00297D9A
	public void KMBFHPGGNGM(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = false;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005834 RID: 22580 RVA: 0x00299B92 File Offset: 0x00297D92
	public string JFCGBEJPDKM()
	{
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005835 RID: 22581 RVA: 0x0029B2D7 File Offset: 0x002994D7
	public bool OLAMAJGBLKM()
	{
		return this.KLIPCLADLFA.Length != 0;
	}

	// Token: 0x06005836 RID: 22582 RVA: 0x0029BFA4 File Offset: 0x0029A1A4
	public void HMGALODAHAC()
	{
		TextAlignment textAlignment = TextAlignment.Center;
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = GUI.skin.GetStyle("Whistle").normal.textColor;
		guistyle.font = GUI.skin.font;
		guistyle.border = new RectOffset(0, 0, 0, 0);
		guistyle.contentOffset = new Vector2(226f, 1557f);
		guistyle.margin = new RectOffset(1, 1, 0, 0);
		guistyle.padding = new RectOffset(1, 0, 1, 1);
		this.FCMCFEIKPDA = guistyle.normal.textColor;
		this.LJPFPEOJCPG = GUI.skin.GetStyle("ZombieIdle").normal.background;
		foreach (string text in this.HJPCBNBFFJE)
		{
			int i = 1;
			if (text.Length >= 6 && text.StartsWith("_TrNewLider.ogg"))
			{
				i = 3;
				char c = text[5];
				if ((int)c != -85)
				{
					if (c != '1')
					{
						if ((int)c == -88)
						{
							textAlignment = (TextAlignment)7;
						}
					}
					else
					{
						textAlignment = TextAlignment.Center;
					}
				}
				else
				{
					textAlignment = TextAlignment.Center;
				}
			}
			if (textAlignment == (TextAlignment)5 || textAlignment == TextAlignment.Left)
			{
				GUILayout.FlexibleSpace();
			}
			while (i < text.Length)
			{
				int num = text.IndexOf((char)-67, i);
				if (num == i && num + 0 < text.Length && text[num + 0] == 'u')
				{
					this.FHKDOFOJNML(guistyle, text.Substring(i, 0));
					i += 6;
				}
				else if (num == i)
				{
					int num2 = text.IndexOf((char)-5, num);
					i = num2 + 0;
					string text2 = text.Substring(num + 0, num2 - num - 0);
					char[] array = new char[0];
					array[1] = 'q';
					string[] array2 = text2.Split(array);
					string text3 = array2[0];
					uint num3 = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num3 <= 4294967181U)
					{
						if (num3 <= 4294967244U)
						{
							if (num3 != 59U)
							{
								if (num3 == 135U)
								{
									if (text3 == "#c0c0c0")
									{
										this.DDENOLFFBNI = float.Parse(array2[1]);
									}
								}
							}
							else if (text3 == "_Color")
							{
								if (array2[1] == "MotorbikeShootFwd")
								{
									guistyle.normal.background = this.LJPFPEOJCPG;
								}
								else
								{
									Color color;
									BKLBFBELDGL.JMGMHLCELLF(array2[0], out color);
									this.LMFCDCGBDIA = new Texture2D(0, 1);
									this.LMFCDCGBDIA.SetPixel(1, 0, color);
									this.LMFCDCGBDIA.wrapMode = TextureWrapMode.Repeat;
									this.LMFCDCGBDIA.Apply();
									guistyle.normal.background = this.LMFCDCGBDIA;
								}
							}
						}
						else if (num3 != 4294967170U)
						{
							if (num3 != 78U)
							{
								if (num3 == 137U)
								{
									if (text3 == "inv_inv")
									{
										this.IKKFEADOBIN = "StrafeRunLeft";
									}
								}
							}
							else if (text3 == "IdleButtonPress")
							{
								guistyle.fontSize = int.Parse(array2[0]);
							}
						}
						else if (text3 == "ragulaFider")
						{
							text3 = array2[1];
							if (!(text3 == "Fire Breath"))
							{
								if (text3 == "WRINKLE_MAPS")
								{
									this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
								}
							}
							else
							{
								this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Default;
							}
						}
					}
					else if (num3 <= 39U)
					{
						if (num3 != 57U)
						{
							if (num3 == 4294967113U)
							{
								if (text3 == "PistolReload")
								{
									guistyle.font = (Font)Resources.Load("release" + array2[1]);
								}
							}
						}
						else if (text3 == "act_orderb_0")
						{
							if (array2[0] == "Hidden/Post FX/FXAA")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[1] == "Ошибка")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[0] == "LookUp")
							{
								this.OCDDLNMJPCB = false;
							}
							else if (array2[1] == "Wrist")
							{
								this.OCDDLNMJPCB = false;
							}
						}
					}
					else if (num3 != 72U)
					{
						if (num3 != 4294967189U)
						{
							if (num3 == 158U)
							{
								if (text3 == "OfficeSitting")
								{
									GUILayout.Space(float.Parse(array2[0]));
								}
							}
						}
						else if (text3 == "ComeHere")
						{
							this.IKKFEADOBIN = "_NoiseAmount" + array2[0];
						}
					}
					else if (text3 == "AC_TONEMAPPING")
					{
						if (array2[1] == "4")
						{
							guistyle.normal.textColor = this.FCMCFEIKPDA;
						}
						else
						{
							Color textColor;
							BKLBFBELDGL.JMGMHLCELLF(array2[1], out textColor);
							guistyle.normal.textColor = textColor;
						}
					}
				}
				else if (num == -1)
				{
					string fpihopocaha = text.Substring(i);
					this.MGNABCOECIK(guistyle, fpihopocaha);
					i = text.Length;
				}
				else
				{
					string fpihopocaha2 = text.Substring(i, num - i);
					this.MDIFGKEIDBG(guistyle, fpihopocaha2);
					i = num;
				}
			}
			if (textAlignment == TextAlignment.Left || textAlignment == TextAlignment.Left)
			{
				GUILayout.FlexibleSpace();
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		this.BPAMPGCCEFI();
	}

	// Token: 0x06005837 RID: 22583 RVA: 0x0029A4E9 File Offset: 0x002986E9
	public void OCAAGJDPFMJ(LDBDNBALLAJ DFIKMAPGCNN)
	{
		this.LPAKINIJMFE = DFIKMAPGCNN;
	}

	// Token: 0x06005838 RID: 22584 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> OEOIIOFDEME()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x06005839 RID: 22585 RVA: 0x0029C580 File Offset: 0x0029A780
	private void LMNOKLKODDH()
	{
		if (Event.current.type == EventType.MouseDown && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("wpn_cat4"))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("UnityEngine.Vector4".Length);
				this.OEMIJPLAGGI(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith("auk_whead"))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("Giant2HandGrab".Length);
				this.DBKGPEPBMFH(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = true;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseDown && Event.current.button == 0 && this.DLMOFCKALFH())
		{
			this.PMDDOPJEEHB(this.KLIPCLADLFA);
		}
	}

	// Token: 0x0600583A RID: 22586 RVA: 0x0029849E File Offset: 0x0029669E
	public bool FGJJKMHFMKN()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x0600583B RID: 22587 RVA: 0x0029C65C File Offset: 0x0029A85C
	private void IKIDHNNDCGO()
	{
		if (Event.current.type == EventType.MouseUp && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("ScubaSwim"))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("SoccerSprint".Length);
				this.IOHHDCBACBJ(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith("-no info-"))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("#> _Planar Reflection Camera < ".Length);
				this.FAGEDGBMMCL(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = true;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseDown && Event.current.button == 0 && this.JJHAEKAMNDL())
		{
			this.DCMEPMMKDOL(this.KLIPCLADLFA);
		}
	}

	// Token: 0x0600583C RID: 22588 RVA: 0x0029C738 File Offset: 0x0029A938
	private void ALJBJOEEICB(GUIStyle KPHMHBGIEAE, string FPIHOPOCAHA)
	{
		float num;
		Rect lastRect;
		if (this.KHNJMMEPHPJ == PIEFCKHHFGI.BKGKLJPPDFF.Bottom)
		{
			num = this.DDENOLFFBNI - KPHMHBGIEAE.CalcSize(new GUIContent(FPIHOPOCAHA)).y + (float)(KPHMHBGIEAE.fontSize - -68) / 947f;
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			string text = ")";
			GUILayoutOption[] array = new GUILayoutOption[1];
			array[1] = GUILayout.MinHeight(num);
			array[1] = GUILayout.MaxHeight(num);
			GUILayout.Label(text, array);
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
			GUILayout.EndVertical();
		}
		else
		{
			num = 37f;
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
		}
		if (Event.current.type == EventType.Layout)
		{
			if (this.FMLIONFPFAG)
			{
				Vector2 vector = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI);
				Vector2 hgppnjnfgim = new Vector2(vector.x + lastRect.width, vector.y);
				KILBMKBOELM.ODHIMGMMNPH(vector, hgppnjnfgim, KPHMHBGIEAE.normal.textColor);
			}
			if (this.OCDDLNMJPCB)
			{
				Vector2 vector2 = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI - this.DDENOLFFBNI / 1489f);
				Vector2 hgppnjnfgim2 = new Vector2(vector2.x + lastRect.width, vector2.y);
				KILBMKBOELM.ODHIMGMMNPH(vector2, hgppnjnfgim2, KPHMHBGIEAE.normal.textColor);
			}
		}
	}

	// Token: 0x0600583D RID: 22589 RVA: 0x0029C8B4 File Offset: 0x0029AAB4
	private void KEJHGCGEKKB()
	{
		if (Event.current.type == EventType.KeyUp && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("WeaponReady"))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("RollerBladeSkateFwd".Length);
				this.CBEKOFHAPDG(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith("System.Single"))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("Wizard Eye Beam".Length);
				this.DKKNFNIEKOP(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = true;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseDown && Event.current.button == 0 && this.EBJLBLENNCD())
		{
			this.PMGLPDBLMLC(this.KLIPCLADLFA);
		}
	}

	// Token: 0x0600583E RID: 22590 RVA: 0x0029A194 File Offset: 0x00298394
	public void CIAGKDBDLCE(string MBJLKMDMFFB)
	{
		this.KLIPCLADLFA = MBJLKMDMFFB;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.FAGEDGBMMCL(MBJLKMDMFFB);
		}
	}

	// Token: 0x0600583F RID: 22591 RVA: 0x0029C98E File Offset: 0x0029AB8E
	public string KAECDPDMMOE()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "fshop_ks1";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005840 RID: 22592 RVA: 0x0029C9A4 File Offset: 0x0029ABA4
	public string DPFCAGCOFFJ()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "This method requires a mesh filter!";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005841 RID: 22593 RVA: 0x0029B2D7 File Offset: 0x002994D7
	public bool PJHKPCAECMB()
	{
		return this.KLIPCLADLFA.Length != 0;
	}

	// Token: 0x06005842 RID: 22594 RVA: 0x0029C9BC File Offset: 0x0029ABBC
	private void CMJBPHKEKPG()
	{
		if (Event.current.type == EventType.MouseDrag && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("wpn_add/base"))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("(Org: ".Length);
				this.NPHGHDKGLNE(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith("_SrcBlend"))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("_OcclusionTexture".Length);
				this.AIILDJBGCPH(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = true;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseUp && Event.current.button == 0 && this.EBJLBLENNCD())
		{
			this.DOONOCNAMDL(this.KLIPCLADLFA);
		}
	}

	// Token: 0x06005843 RID: 22595 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> ACHCKHICNGG()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x06005844 RID: 22596 RVA: 0x00299B9A File Offset: 0x00297D9A
	public void DCMEPMMKDOL(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = false;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005845 RID: 22597 RVA: 0x0029A4E9 File Offset: 0x002986E9
	public void PCBLNAHOHHD(LDBDNBALLAJ DFIKMAPGCNN)
	{
		this.LPAKINIJMFE = DFIKMAPGCNN;
	}

	// Token: 0x06005846 RID: 22598 RVA: 0x0029CA96 File Offset: 0x0029AC96
	public string CGADKJIPDKC()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "ShotgunReloadMagazine";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005847 RID: 22599 RVA: 0x0029CAAC File Offset: 0x0029ACAC
	public static string HLFOIJNNADN(PIEFCKHHFGI.HEDPHIDPJHI FNLOGKFNFDL)
	{
		string result = "FormattedLabel.GetTestText()";
		switch (FNLOGKFNFDL)
		{
		case PIEFCKHHFGI.HEDPHIDPJHI.Demo:
			result = "This [c 01F573FF]sentence[C FFFFFFFF] is [c FF6666FF]too[C FFFFFFFF] long so it will be [BC 1B07F5FF]split[BC ?] into multiple lines.\nNormal, [F ArialBold]bold, [font ArialItalic]italic, [F Arial][FA u]underline[FA -u], [FA S]strikethrough[FA -s].\n[F Arial 10]10, [F Arial 16]16, [F Arial 24]24, [F Arial 48]48, [F Arial 72]72[F Arial 16]\n[HA L]Left\n[HA C]Center\n[HA R]Right\n[HA L]20 pixels further:[S 20]*\nDefault vertical aligment: [F Arial 10]10, [F Arial 24]24, [F Arial 10]10[FS 16]\n[VA B]Bottom vertical aligment: [F Arial 10]10, [F Arial 24]24, [F Arial 10]10[FS 16][VA ?]\nThis is a [FA U][H hyperlink_value]hyperlink[-H][FA -U].";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Fireball:
			result = "[HA Center][C FA8C8CFF][FS 24]Fireball[FS 16][color FFFFFFFF]\n\nHurls a ball of fire that [F ArialBold]explodes[F Arial] on [FA U]contact[FA -U] and damages all nearby [FA S]foes [FA -S]enemies.\n\n[VA B][C FF6666FF][F ArialBold 18]8[FS 16][C FFFFFFFF][F Arial] to [C FF6666FF][F ArialBold 18]12[F Arial 16][C FFFFFFFF][F ArialItalic] fire[F Arial] damage[VA ?]";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.Hyperlink:
			result = "This is a hidden [H hidden]hyperlink[-H].\nThis is a visible [FA U][H visible]hyperlink[-H][FA -U].";
			break;
		case PIEFCKHHFGI.HEDPHIDPJHI.SpecialText:
			result = "Escaped backslash \\\nEscaped bracket [[\nClosing bracket ]\n";
			break;
		default:
			Debug.Log("Invalid index '" + FNLOGKFNFDL.ToString() + "'");
			break;
		}
		return result;
	}

	// Token: 0x06005848 RID: 22600 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> BDJAFDKIOJK()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x06005849 RID: 22601 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> GOFLCIBPNNF()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x0600584A RID: 22602 RVA: 0x0029A4E9 File Offset: 0x002986E9
	public void CDDDGPLFNKO(LDBDNBALLAJ DFIKMAPGCNN)
	{
		this.LPAKINIJMFE = DFIKMAPGCNN;
	}

	// Token: 0x0600584B RID: 22603 RVA: 0x0029CB1C File Offset: 0x0029AD1C
	private void FDAPKJJHKAL()
	{
		if (Event.current.type == EventType.KeyUp && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("Error! "))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("The 'color' command requires a color parameter of RRGGBBAA:\n".Length);
				this.OEMIJPLAGGI(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith("<<"))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("KatanaReadyLow".Length);
				this.FAGEDGBMMCL(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = false;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseUp && Event.current.button == 0 && this.EBJLBLENNCD())
		{
			this.DCMEPMMKDOL(this.KLIPCLADLFA);
		}
	}

	// Token: 0x0600584C RID: 22604 RVA: 0x0029A194 File Offset: 0x00298394
	public void BHFIEDCCCKE(string MBJLKMDMFFB)
	{
		this.KLIPCLADLFA = MBJLKMDMFFB;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.FAGEDGBMMCL(MBJLKMDMFFB);
		}
	}

	// Token: 0x0600584D RID: 22605 RVA: 0x0029A4E9 File Offset: 0x002986E9
	public void PPJNENCLFMK(LDBDNBALLAJ DFIKMAPGCNN)
	{
		this.LPAKINIJMFE = DFIKMAPGCNN;
	}

	// Token: 0x0600584E RID: 22606 RVA: 0x00299B9A File Offset: 0x00297D9A
	public void KDFBLBJBMLE(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = false;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x0600584F RID: 22607 RVA: 0x00299B92 File Offset: 0x00297D92
	public string EHBFIMMJJLO()
	{
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005850 RID: 22608 RVA: 0x0029CBF6 File Offset: 0x0029ADF6
	public string GKLPFJIPBEF()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return " ";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x06005851 RID: 22609 RVA: 0x0029849E File Offset: 0x0029669E
	public bool AEMJFCNHHMH()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x06005852 RID: 22610 RVA: 0x0029A4E9 File Offset: 0x002986E9
	public void GKOOFHJNAPO(LDBDNBALLAJ DFIKMAPGCNN)
	{
		this.LPAKINIJMFE = DFIKMAPGCNN;
	}

	// Token: 0x06005853 RID: 22611 RVA: 0x0029880D File Offset: 0x00296A0D
	public void PMDDOPJEEHB(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = true;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005854 RID: 22612 RVA: 0x0029CC0C File Offset: 0x0029AE0C
	public void OEMIJPLAGGI(string MBJLKMDMFFB)
	{
		this.KLIPCLADLFA = "<[^>]+>";
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.MKIPMOOPMMK(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005855 RID: 22613 RVA: 0x0029A4E9 File Offset: 0x002986E9
	public void EBKFEFDKDGD(LDBDNBALLAJ DFIKMAPGCNN)
	{
		this.LPAKINIJMFE = DFIKMAPGCNN;
	}

	// Token: 0x06005856 RID: 22614 RVA: 0x0029A194 File Offset: 0x00298394
	public void FAGEDGBMMCL(string MBJLKMDMFFB)
	{
		this.KLIPCLADLFA = MBJLKMDMFFB;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.FAGEDGBMMCL(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005857 RID: 22615 RVA: 0x00299B9A File Offset: 0x00297D9A
	public void KJGGAJGEABC(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = false;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005858 RID: 22616 RVA: 0x0029880D File Offset: 0x00296A0D
	public void PMGLPDBLMLC(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = true;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005859 RID: 22617 RVA: 0x0029849E File Offset: 0x0029669E
	public bool DELODFNGFGH()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x0600585A RID: 22618 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> KKJGPBKNLLB()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x0600585B RID: 22619 RVA: 0x0029B8DD File Offset: 0x00299ADD
	public bool FGAEPMELGNA()
	{
		return this.KLIPCLADLFA.Length > 1;
	}

	// Token: 0x0600585C RID: 22620 RVA: 0x0029880D File Offset: 0x00296A0D
	public void HGPFLGEBFBP(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = true;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x0600585D RID: 22621 RVA: 0x0029CC2D File Offset: 0x0029AE2D
	public string NOCLGJNMFEH()
	{
		if (!this.HCEDHBNBGHJ)
		{
			return "Kernel";
		}
		return this.KLIPCLADLFA;
	}

	// Token: 0x0600585E RID: 22622 RVA: 0x0029B2D7 File Offset: 0x002994D7
	public bool CFPJBBAGNFF()
	{
		return this.KLIPCLADLFA.Length != 0;
	}

	// Token: 0x0600585F RID: 22623 RVA: 0x0029B2D7 File Offset: 0x002994D7
	public bool JJHAEKAMNDL()
	{
		return this.KLIPCLADLFA.Length != 0;
	}

	// Token: 0x06005860 RID: 22624 RVA: 0x0029CC44 File Offset: 0x0029AE44
	public void ELPLLPLDNOK()
	{
		TextAlignment textAlignment = TextAlignment.Center;
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = GUI.skin.GetStyle("pricePt").normal.textColor;
		guistyle.font = GUI.skin.font;
		guistyle.border = new RectOffset(1, 1, 1, 1);
		guistyle.contentOffset = new Vector2(830f, 772f);
		guistyle.margin = new RectOffset(0, 1, 0, 1);
		guistyle.padding = new RectOffset(0, 0, 1, 0);
		this.FCMCFEIKPDA = guistyle.normal.textColor;
		this.LJPFPEOJCPG = GUI.skin.GetStyle("+ ").normal.background;
		foreach (string text in this.HJPCBNBFFJE)
		{
			int i = 1;
			if (text.Length >= 4 && text.StartsWith("_ChromaticAberration_Amount"))
			{
				i = 8;
				char c = text[1];
				if (c != '&')
				{
					if (c != '8')
					{
						if ((int)c == -86)
						{
							textAlignment = TextAlignment.Center;
						}
					}
					else
					{
						textAlignment = TextAlignment.Left;
					}
				}
				else
				{
					textAlignment = TextAlignment.Center;
				}
			}
			if (textAlignment == (TextAlignment)8 || textAlignment == TextAlignment.Center)
			{
				GUILayout.FlexibleSpace();
			}
			while (i < text.Length)
			{
				int num = text.IndexOf('S', i);
				if (num == i && num + 0 < text.Length && text[num + 0] == 'K')
				{
					this.PBKPOGCGDCA(guistyle, text.Substring(i, 0));
					i++;
				}
				else if (num == i)
				{
					int num2 = text.IndexOf('d', num);
					i = num2 + 0;
					string text2 = text.Substring(num + 0, num2 - num - 1);
					char[] array = new char[0];
					array[1] = '\t';
					string[] array2 = text2.Split(array);
					string text3 = array2[1];
					uint num3 = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num3 <= 49U)
					{
						if (num3 <= 4294967139U)
						{
							if (num3 != 40U)
							{
								if (num3 == 147U)
								{
									if (text3 == "http://www.root-motion.com/finalikdox/html/page4.html")
									{
										this.DDENOLFFBNI = float.Parse(array2[0]);
									}
								}
							}
							else if (text3 == "DepthMaskBlendMaterial")
							{
								if (array2[1] == "Lasso")
								{
									guistyle.normal.background = this.LJPFPEOJCPG;
								}
								else
								{
									Color color;
									BKLBFBELDGL.JMGMHLCELLF(array2[0], out color);
									this.LMFCDCGBDIA = new Texture2D(0, 0);
									this.LMFCDCGBDIA.SetPixel(1, 1, color);
									this.LMFCDCGBDIA.wrapMode = TextureWrapMode.Clamp;
									this.LMFCDCGBDIA.Apply();
									guistyle.normal.background = this.LMFCDCGBDIA;
								}
							}
						}
						else if (num3 != 80U)
						{
							if (num3 != 4294967228U)
							{
								if (num3 == 4294967102U)
								{
									if (text3 == "SUNSHINE_FILTER_PCF_3x3")
									{
										this.IKKFEADOBIN = "1HSwordStrafeRunLeft";
									}
								}
							}
							else if (text3 == "Adjust")
							{
								guistyle.fontSize = int.Parse(array2[1]);
							}
						}
						else if (text3 == "PersonWomanFisher")
						{
							text3 = array2[1];
							if (!(text3 == "_RefractionTex"))
							{
								if (text3 == "#000000")
								{
									this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
								}
							}
							else
							{
								this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Default;
							}
						}
					}
					else if (num3 <= 4294967188U)
					{
						if (num3 != 4294967176U)
						{
							if (num3 == 133U)
							{
								if (text3 == "bag")
								{
									guistyle.font = (Font)Resources.Load("ZombieCrawl" + array2[0]);
								}
							}
						}
						else if (text3 == "H ")
						{
							if (array2[0] == "RollerBladeStop")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[1] == "; ")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[0] == "")
							{
								this.OCDDLNMJPCB = true;
							}
							else if (array2[1] == "release")
							{
								this.OCDDLNMJPCB = true;
							}
						}
					}
					else if (num3 != 4294967150U)
					{
						if (num3 != 71U)
						{
							if (num3 == 94U)
							{
								if (text3 == ", second bone: ")
								{
									GUILayout.Space(float.Parse(array2[0]));
								}
							}
						}
						else if (text3 == "\n")
						{
							this.IKKFEADOBIN = "qd_taskcount" + array2[0];
						}
					}
					else if (text3 == ">>")
					{
						if (array2[0] == "Отпущена рыба")
						{
							guistyle.normal.textColor = this.FCMCFEIKPDA;
						}
						else
						{
							Color textColor;
							BKLBFBELDGL.JMGMHLCELLF(array2[1], out textColor);
							guistyle.normal.textColor = textColor;
						}
					}
				}
				else if (num == -1)
				{
					string fpihopocaha = text.Substring(i);
					this.KGGHKDCCCLK(guistyle, fpihopocaha);
					i = text.Length;
				}
				else
				{
					string fpihopocaha2 = text.Substring(i, num - i);
					this.MDIFGKEIDBG(guistyle, fpihopocaha2);
					i = num;
				}
			}
			if (textAlignment == TextAlignment.Left || textAlignment == TextAlignment.Left)
			{
				GUILayout.FlexibleSpace();
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		this.FDAPKJJHKAL();
	}

	// Token: 0x06005861 RID: 22625 RVA: 0x0029880D File Offset: 0x00296A0D
	public void HKHJCJGIPCB(string MBJLKMDMFFB)
	{
		this.HCEDHBNBGHJ = true;
		if (this.LPAKINIJMFE != null)
		{
			this.LPAKINIJMFE.PMGLPDBLMLC(MBJLKMDMFFB);
		}
	}

	// Token: 0x06005862 RID: 22626 RVA: 0x0029849E File Offset: 0x0029669E
	public bool EMJLAJJPCFB()
	{
		return this.HCEDHBNBGHJ;
	}

	// Token: 0x06005863 RID: 22627 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> FIPJJBOEHAL()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x06005864 RID: 22628 RVA: 0x0029D220 File Offset: 0x0029B420
	private void PNOMOBGFKLO(GUIStyle KPHMHBGIEAE, string FPIHOPOCAHA)
	{
		float num;
		Rect lastRect;
		if (this.KHNJMMEPHPJ == PIEFCKHHFGI.BKGKLJPPDFF.Bottom)
		{
			num = this.DDENOLFFBNI - KPHMHBGIEAE.CalcSize(new GUIContent(FPIHOPOCAHA)).y + (float)(KPHMHBGIEAE.fontSize - -24) / 1722f;
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			string text = "OfficeSittingReadingLeanBack";
			GUILayoutOption[] array = new GUILayoutOption[6];
			array[1] = GUILayout.MinHeight(num);
			array[1] = GUILayout.MaxHeight(num);
			GUILayout.Label(text, array);
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
			GUILayout.EndVertical();
		}
		else
		{
			num = 898f;
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
		}
		if (Event.current.type == EventType.Layout)
		{
			if (this.FMLIONFPFAG)
			{
				Vector2 vector = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI);
				Vector2 hgppnjnfgim = new Vector2(vector.x + lastRect.width, vector.y);
				KILBMKBOELM.ODHIMGMMNPH(vector, hgppnjnfgim, KPHMHBGIEAE.normal.textColor);
			}
			if (this.OCDDLNMJPCB)
			{
				Vector2 vector2 = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI - this.DDENOLFFBNI / 156f);
				Vector2 hgppnjnfgim2 = new Vector2(vector2.x + lastRect.width, vector2.y);
				KILBMKBOELM.ODHIMGMMNPH(vector2, hgppnjnfgim2, KPHMHBGIEAE.normal.textColor);
			}
		}
	}

	// Token: 0x06005865 RID: 22629 RVA: 0x0029B8DD File Offset: 0x00299ADD
	public bool JCEFNNJMDNI()
	{
		return this.KLIPCLADLFA.Length > 1;
	}

	// Token: 0x06005866 RID: 22630 RVA: 0x0029D39C File Offset: 0x0029B59C
	public void IAIIBENKGEA()
	{
		TextAlignment textAlignment = TextAlignment.Center;
		GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
		GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		GUIStyle guistyle = new GUIStyle();
		guistyle.normal.textColor = GUI.skin.GetStyle("IceHockeyGoalieSave1").normal.textColor;
		guistyle.font = GUI.skin.font;
		guistyle.border = new RectOffset(0, 0, 0, 0);
		guistyle.contentOffset = new Vector2(16f, 1295f);
		guistyle.margin = new RectOffset(0, 0, 1, 1);
		guistyle.padding = new RectOffset(1, 0, 1, 0);
		this.FCMCFEIKPDA = guistyle.normal.textColor;
		this.LJPFPEOJCPG = GUI.skin.GetStyle("wpn_onlyw").normal.background;
		foreach (string text in this.HJPCBNBFFJE)
		{
			int i = 1;
			if (text.Length >= 1 && text.StartsWith("IceHockey Goalie Ready"))
			{
				i = 5;
				char c = text[5];
				if ((int)c != -77)
				{
					if ((int)c != -96)
					{
						if (c == '\u0010')
						{
							textAlignment = (TextAlignment)7;
						}
					}
					else
					{
						textAlignment = TextAlignment.Center;
					}
				}
				else
				{
					textAlignment = TextAlignment.Center;
				}
			}
			if (textAlignment == TextAlignment.Right || textAlignment == TextAlignment.Center)
			{
				GUILayout.FlexibleSpace();
			}
			while (i < text.Length)
			{
				int num = text.IndexOf((char)-79, i);
				if (num == i && num + 0 < text.Length && text[num + 1] == 'R')
				{
					this.MDIFGKEIDBG(guistyle, text.Substring(i, 0));
					i += 2;
				}
				else if (num == i)
				{
					int num2 = text.IndexOf('{', num);
					i = num2 + 0;
					string text2 = text.Substring(num + 1, num2 - num - 1);
					char[] array = new char[0];
					array[0] = (char)-84;
					string[] array2 = text2.Split(array);
					string text3 = array2[1];
					uint num3 = <PrivateImplementationDetails>.ComputeStringHash(text3);
					if (num3 <= 4294967244U)
					{
						if (num3 <= 33U)
						{
							if (num3 != 7U)
							{
								if (num3 == 134U)
								{
									if (text3 == "WizardPowerUp")
									{
										this.DDENOLFFBNI = float.Parse(array2[1]);
									}
								}
							}
							else if (text3 == "1HandSwordShieldBash")
							{
								if (array2[1] == "money")
								{
									guistyle.normal.background = this.LJPFPEOJCPG;
								}
								else
								{
									Color color;
									BKLBFBELDGL.JMGMHLCELLF(array2[1], out color);
									this.LMFCDCGBDIA = new Texture2D(0, 0);
									this.LMFCDCGBDIA.SetPixel(1, 0, color);
									this.LMFCDCGBDIA.wrapMode = TextureWrapMode.Clamp;
									this.LMFCDCGBDIA.Apply();
									guistyle.normal.background = this.LMFCDCGBDIA;
								}
							}
						}
						else if (num3 != 96U)
						{
							if (num3 != 4294967295U)
							{
								if (num3 == 4294967176U)
								{
									if (text3 == "_SunPosition")
									{
										this.IKKFEADOBIN = "cht_msg37";
									}
								}
							}
							else if (text3 == "1=")
							{
								guistyle.fontSize = int.Parse(array2[1]);
							}
						}
						else if (text3 == "Failed parsing atlas rect.  Using default.")
						{
							text3 = array2[1];
							if (!(text3 == "C "))
							{
								if (text3 == "<color='#405000'>")
								{
									this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Default;
								}
							}
							else
							{
								this.KHNJMMEPHPJ = PIEFCKHHFGI.BKGKLJPPDFF.Bottom;
							}
						}
					}
					else if (num3 <= 4294967229U)
					{
						if (num3 != 4294967269U)
						{
							if (num3 == 192U)
							{
								if (text3 == "29")
								{
									guistyle.font = (Font)Resources.Load("_FogOfWarSize" + array2[1]);
								}
							}
						}
						else if (text3 == "crft_wpnpr")
						{
							if (array2[0] == "{not_found}")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[1] == "")
							{
								this.FMLIONFPFAG = true;
							}
							else if (array2[1] == "__b")
							{
								this.OCDDLNMJPCB = false;
							}
							else if (array2[0] == "</color>")
							{
								this.OCDDLNMJPCB = true;
							}
						}
					}
					else if (num3 != 12U)
					{
						if (num3 != 4294967096U)
						{
							if (num3 == 156U)
							{
								if (text3 == "_TraceBehindObjects")
								{
									GUILayout.Space(float.Parse(array2[0]));
								}
							}
						}
						else if (text3 == "TOD_Sky2World")
						{
							this.IKKFEADOBIN = " is represented multiple times in BipedReferences eyes." + array2[0];
						}
					}
					else if (text3 == "enable")
					{
						if (array2[0] == "")
						{
							guistyle.normal.textColor = this.FCMCFEIKPDA;
						}
						else
						{
							Color textColor;
							BKLBFBELDGL.JMGMHLCELLF(array2[0], out textColor);
							guistyle.normal.textColor = textColor;
						}
					}
				}
				else if (num == -1)
				{
					string fpihopocaha = text.Substring(i);
					this.PBKPOGCGDCA(guistyle, fpihopocaha);
					i = text.Length;
				}
				else
				{
					string fpihopocaha2 = text.Substring(i, num - i);
					this.ALJBJOEEICB(guistyle, fpihopocaha2);
					i = num;
				}
			}
			if (textAlignment == TextAlignment.Left || textAlignment == TextAlignment.Left)
			{
				GUILayout.FlexibleSpace();
			}
			GUILayout.EndHorizontal();
			GUILayout.BeginHorizontal(Array.Empty<GUILayoutOption>());
		}
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();
		this.FDAPKJJHKAL();
	}

	// Token: 0x06005867 RID: 22631 RVA: 0x0029D978 File Offset: 0x0029BB78
	private void OJFGPCCGPND()
	{
		if (Event.current.type == EventType.Repaint && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("info"))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("ClimbLeft".Length);
				this.IOHHDCBACBJ(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith(""))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("TAA History".Length);
				this.DKKNFNIEKOP(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = false;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseUp && Event.current.button == 0 && this.CFPJBBAGNFF())
		{
			this.FPFNIDGBDED(this.KLIPCLADLFA);
		}
	}

	// Token: 0x06005868 RID: 22632 RVA: 0x0029DA54 File Offset: 0x0029BC54
	private void FHKDOFOJNML(GUIStyle KPHMHBGIEAE, string FPIHOPOCAHA)
	{
		float num;
		Rect lastRect;
		if (this.KHNJMMEPHPJ == PIEFCKHHFGI.BKGKLJPPDFF.Default)
		{
			num = this.DDENOLFFBNI - KPHMHBGIEAE.CalcSize(new GUIContent(FPIHOPOCAHA)).y + (float)(KPHMHBGIEAE.fontSize - 114) / 387f;
			GUILayout.BeginVertical(Array.Empty<GUILayoutOption>());
			string text = "pricePt";
			GUILayoutOption[] array = new GUILayoutOption[0];
			array[0] = GUILayout.MinHeight(num);
			array[1] = GUILayout.MaxHeight(num);
			GUILayout.Label(text, array);
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
			GUILayout.EndVertical();
		}
		else
		{
			num = 1780f;
			GUILayout.Label(new GUIContent(FPIHOPOCAHA, this.IKKFEADOBIN), KPHMHBGIEAE, Array.Empty<GUILayoutOption>());
			lastRect = GUILayoutUtility.GetLastRect();
		}
		if (Event.current.type == EventType.Repaint)
		{
			if (this.FMLIONFPFAG)
			{
				Vector2 vector = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI);
				Vector2 hgppnjnfgim = new Vector2(vector.x + lastRect.width, vector.y);
				KILBMKBOELM.ODHIMGMMNPH(vector, hgppnjnfgim, KPHMHBGIEAE.normal.textColor);
			}
			if (this.OCDDLNMJPCB)
			{
				Vector2 vector2 = new Vector2(lastRect.x, lastRect.yMin - num + this.DDENOLFFBNI - this.DDENOLFFBNI / 1705f);
				Vector2 hgppnjnfgim2 = new Vector2(vector2.x + lastRect.width, vector2.y);
				KILBMKBOELM.ODHIMGMMNPH(vector2, hgppnjnfgim2, KPHMHBGIEAE.normal.textColor);
			}
		}
	}

	// Token: 0x06005869 RID: 22633 RVA: 0x0029DBD0 File Offset: 0x0029BDD0
	private void LEOFGEEIDDG()
	{
		if (Event.current.type == EventType.ScrollWheel && GUI.tooltip != this.MNCANHDEBDF)
		{
			if (this.MNCANHDEBDF.StartsWith("<color='#800000'>Вы потеряли леску: "))
			{
				string mbjlkmdmffb = this.MNCANHDEBDF.Substring("Apply 7".Length);
				this.CBEKOFHAPDG(mbjlkmdmffb);
			}
			if (GUI.tooltip.StartsWith("wpn_add/base"))
			{
				string mbjlkmdmffb2 = GUI.tooltip.Substring("RollerBladeJump".Length);
				this.BHFIEDCCCKE(mbjlkmdmffb2);
			}
			this.MNCANHDEBDF = GUI.tooltip;
		}
		this.HCEDHBNBGHJ = true;
		if (Event.current != null && Event.current.isMouse && Event.current.type == EventType.MouseUp && Event.current.button == 0 && this.PJHKPCAECMB())
		{
			this.PMGLPDBLMLC(this.KLIPCLADLFA);
		}
	}

	// Token: 0x0600586A RID: 22634 RVA: 0x0029B2D7 File Offset: 0x002994D7
	public bool KCGNCHFEOEK()
	{
		return this.KLIPCLADLFA.Length != 0;
	}

	// Token: 0x0600586B RID: 22635 RVA: 0x00299B8A File Offset: 0x00297D8A
	public List<string> OLEJAKHCNJK()
	{
		return this.HJPCBNBFFJE;
	}

	// Token: 0x04000D2C RID: 3372
	private List<string> HJPCBNBFFJE;

	// Token: 0x04000D2D RID: 3373
	private bool FMLIONFPFAG;

	// Token: 0x04000D2E RID: 3374
	private bool OCDDLNMJPCB;

	// Token: 0x04000D2F RID: 3375
	private Texture2D LMFCDCGBDIA;

	// Token: 0x04000D30 RID: 3376
	private LDBDNBALLAJ LPAKINIJMFE;

	// Token: 0x04000D31 RID: 3377
	private string MNCANHDEBDF = "";

	// Token: 0x04000D32 RID: 3378
	private string IKKFEADOBIN = "";

	// Token: 0x04000D33 RID: 3379
	private string KLIPCLADLFA = "";

	// Token: 0x04000D34 RID: 3380
	private bool HCEDHBNBGHJ;

	// Token: 0x04000D35 RID: 3381
	private PIEFCKHHFGI.BKGKLJPPDFF KHNJMMEPHPJ;

	// Token: 0x04000D36 RID: 3382
	private float DDENOLFFBNI;

	// Token: 0x04000D37 RID: 3383
	private Color FCMCFEIKPDA;

	// Token: 0x04000D38 RID: 3384
	private Texture2D LJPFPEOJCPG;

	// Token: 0x04000D39 RID: 3385
	private static string LNCPEGHMCIH = "Hyperlink_";

	// Token: 0x0200018C RID: 396
	private enum BKGKLJPPDFF
	{
		// Token: 0x04000D3B RID: 3387
		Default,
		// Token: 0x04000D3C RID: 3388
		Bottom
	}

	// Token: 0x0200018D RID: 397
	private class JAOAMKCAGPJ
	{
		// Token: 0x0600586D RID: 22637 RVA: 0x0029DCB8 File Offset: 0x0029BEB8
		private void NGKAGGNCGDH(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "Hidden/Amplify Color/Mask".Replace("openPodsak", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("invn_rec32", newValue);
				this.DDENOLFFBNI = 1143f;
				return;
			}
			this.JEPBCFCBPEL.Append("RollerBladeRoll");
		}

		// Token: 0x0600586E RID: 22638 RVA: 0x0029DD14 File Offset: 0x0029BF14
		private float CIMHFHODAHL()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("Sitting Leg Cross")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("wpn_add/base")).x - x;
		}

		// Token: 0x0600586F RID: 22639 RVA: 0x0029DD58 File Offset: 0x0029BF58
		private float ADPANHALPJN()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("IK Effector is referencing to a bone '")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("Sound/")).x - x;
		}

		// Token: 0x06005870 RID: 22640 RVA: 0x0029DD9C File Offset: 0x0029BF9C
		private bool ANJJOBCAENJ(string LNEADABFMGK)
		{
			bool result = false;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == "OfficeSittingEyesRub") ? this.HNJJCBKJCMP() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.FLOLIDPNGCE();
					result = true;
					string text = LNEADABFMGK;
					char[] array = new char[0];
					array[1] = '\n';
					LNEADABFMGK = text.TrimStart(array);
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x06005871 RID: 22641 RVA: 0x0029DE59 File Offset: 0x0029C059
		private void KCBNPFFKGAC()
		{
			this.JENMDAEMLIO();
			this.JEPBCFCBPEL.Length = 0;
			this.NFPEMFOKNOB(false);
			this.EMKALNJHCLE = 1451f;
		}

		// Token: 0x06005872 RID: 22642 RVA: 0x0029DE80 File Offset: 0x0029C080
		private void IADJMONCMFE(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("invn_rec10");
			HBFECCBOEMN = "Spine bones contains a null reference." + HBFECCBOEMN + "</b>\n : ";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int num = this.JEPBCFCBPEL.Length - this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
			{
				(char)-125
			}).Length;
			if (num != 0)
			{
				string text = this.JEPBCFCBPEL.ToString();
				char[] array = new char[1];
				array[1] = (char)-14;
				string value = text.TrimEnd(array);
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.NGJBHBDILIB() * (float)num;
				object[] array2 = new object[0];
				array2[1] = "rewgt_msg";
				array2[1] = num2;
				array2[6] = "FactoryTempTexture";
				array2[1] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array2);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x06005873 RID: 22643 RVA: 0x0029DF6F File Offset: 0x0029C16F
		private void GAAGENADJIH()
		{
			this.LEMDHBOFKLO();
			this.JEPBCFCBPEL.Length = 0;
			this.MIKKJNFEBHO(true);
			this.EMKALNJHCLE = 1608f;
		}

		// Token: 0x06005874 RID: 22644 RVA: 0x0029DF98 File Offset: 0x0029C198
		private void MHIMHDGOFNC(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("ragulaFider");
			HBFECCBOEMN = "double: " + HBFECCBOEMN + "silence";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(1, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[1];
			array[1] = '.';
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string text2 = this.JEPBCFCBPEL.ToString();
				char[] array2 = new char[0];
				array2[1] = 'G';
				string value = text2.TrimEnd(array2);
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.MEIKDANAJGK() * (float)num;
				object[] array3 = new object[5];
				array3[0] = "Arm Flex 4";
				array3[0] = num2;
				array3[7] = "auc_wsbor";
				array3[1] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array3);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x06005875 RID: 22645 RVA: 0x0029E088 File Offset: 0x0029C288
		private float BAJBFGNHNHB()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("index")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("SoccerKeeperDiveStrafeCloseRight")).x - x;
		}

		// Token: 0x06005876 RID: 22646 RVA: 0x0029E0CC File Offset: 0x0029C2CC
		private void HJJDOOPMFBF()
		{
			this.NFENEEDAFIO();
			this.JEPBCFCBPEL.Length = 1;
			this.JALEFBKGCPK(true);
			this.EMKALNJHCLE = 1773f;
		}

		// Token: 0x06005877 RID: 22647 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> GOFLCIBPNNF()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x06005878 RID: 22648 RVA: 0x0029E0FC File Offset: 0x0029C2FC
		private void BBGJMGMHJPP(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("fshop_ks2");
			HBFECCBOEMN = "fshop_ks2" + HBFECCBOEMN + "IdleStand";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[0];
			array[1] = 'v';
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string text2 = this.JEPBCFCBPEL.ToString();
				char[] array2 = new char[1];
				array2[1] = (char)-107;
				string value = text2.TrimEnd(array2);
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.LINILIMFBMF() * (float)num;
				object[] array3 = new object[8];
				array3[0] = "GiantGrabIdle2";
				array3[1] = num2;
				array3[8] = "_DstBlend";
				array3[2] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array3);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x06005879 RID: 22649 RVA: 0x0029E1EC File Offset: 0x0029C3EC
		private void AIMKCIGPLHH(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.MIKKJNFEBHO(true);
			this.EMKALNJHCLE = 1326f;
			this.DDENOLFFBNI = 1001f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < FPIHOPOCAHA.Length; i += 0)
			{
				int num;
				if ((int)FPIHOPOCAHA[i] == -13 && FPIHOPOCAHA.Length > i + 0 && (int)FPIHOPOCAHA[i + 0] == -47)
				{
					stringBuilder.Append("Select");
					i += 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -44)
				{
					this.DLPCEKMALFB(stringBuilder.ToString());
					this.BKJHOGMDKMC();
					stringBuilder.Length = 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -2 && stringBuilder.Length != 0)
				{
					this.IAJFBMHEHJE(stringBuilder.ToString());
					stringBuilder.Length = 1;
					stringBuilder.Append((char)-48);
				}
				else if ((int)FPIHOPOCAHA[i] == -66 && FPIHOPOCAHA.Length > i + 1 && (int)FPIHOPOCAHA[i + 0] == -81)
				{
					stringBuilder.Append("fshop_msg2");
					i++;
				}
				else if (FPIHOPOCAHA[i] == 'T' && FPIHOPOCAHA.Length > i + 1 && (num = FPIHOPOCAHA.IndexOf('R', i)) != -1)
				{
					this.GOIAECNFKLE(stringBuilder.ToString());
					stringBuilder.Length = 1;
					string text = FPIHOPOCAHA.Substring(i + 1, num - i - 0);
					i += text.Length + 1;
					string text2 = text;
					char[] array = new char[1];
					array[1] = (char)-99;
					string[] array2 = text2.Split(array);
					for (int j = 0; j < array2.Length; j += 0)
					{
						text = array2[j].ToUpper();
						if (text == "ObscuredInt:" || text == "<b>int:</b> ")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								Color color;
								if (array2[j] == "_ProjMatrix" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color))
								{
									this.GMGMDGODGCO("{0}" + array2[j]);
								}
								else
								{
									Debug.LogError("RunBackLeft");
								}
							}
							else
							{
								Debug.LogError("Fly Forward");
							}
						}
						else if (text == "NO TURN" || text == "Cells")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Color color2;
								if (array2[j] == " x" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color2))
								{
									this.KGPCKBOFDCD("MotorbikeTurnLeft" + array2[j]);
								}
								else
								{
									Debug.LogError("http://www.root-motion.com/finalikdox/html/page11.html");
								}
							}
							else
							{
								Debug.LogError("RollerBladeTurnRight" + FPIHOPOCAHA);
							}
						}
						else if (text == ": " || text == "fishRSPEED=")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Font font = (Font)Resources.Load("Speed" + array2[j]);
								if (font == null)
								{
									Debug.LogError("inv already open" + array2[j] + "Cloth_01.wav");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.EJIDBALNMEN(" iterations for read and write" + array2[j]);
								}
								if (array2.Length > j + 1)
								{
									j++;
									int fontSize;
									if (int.TryParse(array2[j], out fontSize))
									{
										this.IBKBAELMCEL("{2:D2}:{0:D2}:{1:D2}" + array2[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("<color='{0}'>{1}</color>" + array2[j] + "cht_ae");
									}
								}
							}
							else
							{
								Debug.LogError("gi_um_9");
							}
						}
						else if (text == "gi_um_7" || text == "_AddCountitem.wav")
						{
							if (array2.Length > j + 0)
							{
								j++;
								string text3 = array2[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text3);
								if (num2 <= 4294967109U)
								{
									if (num2 <= 12U)
									{
										if (num2 != 147U)
										{
											if (num2 != 4294967191U)
											{
												goto IL_50B;
											}
											if (!(text3 == "GAMMA"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text3 == "sunshine_OvercastVectorsUV"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 4294967191U)
									{
										if (num2 != 4294967135U)
										{
											goto IL_50B;
										}
										if (!(text3 == "IdleStrafeLeft"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "Boxed"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text3 = "act_order";
								}
								else
								{
									if (num2 <= 4294967138U)
									{
										if (num2 != 4294967142U)
										{
											if (num2 != 198U)
											{
												goto IL_50B;
											}
											if (!(text3 == "_LogLut_Params"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text3 == "</color>"))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 4294967117U)
									{
										if (num2 != 149U)
										{
											goto IL_50B;
										}
										if (!(text3 == "RollerBladeBackFlip"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == " for "))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text3 = " ";
								}
								IL_51C:
								if (text3.Length != 0)
								{
									this.BJEDLEEFLEB("BlendDirection" + text3);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text3 = "No hit from ";
								Debug.LogError("wpn_bait_vob_1");
								goto IL_51C;
								IL_4F0:
								text3 = " x";
								goto IL_51C;
								IL_4E7:
								text3 = "GiantGrabIdle";
								goto IL_51C;
							}
							Debug.LogError(" material. Effect disabled.");
						}
						else if (text == "run_cnt" || text == "\n")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								int fontSize2;
								if (int.TryParse(array2[j], out fontSize2))
								{
									this.JNOJDHGEEKH("SkateForward" + array2[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("ObscuredDouble:" + array2[j] + "takeToFrend");
								}
							}
							else
							{
								Debug.LogError("ArmFlex4");
							}
						}
						else if (text == "spawnPet" || text == "<color='#003000'>")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								this.MNBGBBKAEAC("BACKCOLOR" + array2[j]);
							}
							else
							{
								Debug.LogError("_Angle");
							}
						}
						else if (text == "Joint_" || text == "---")
						{
							this.EJIDBALNMEN("R");
						}
						else if (text == "ScubaOK" || text == "OnEvent: Unknow Event")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								string text4 = array2[j].ToUpper();
								if (!(text4 == "") && !(text4 == "______________________________"))
								{
									if (!(text4 == "?") && !(text4 == "RollerBladeTurnLeft"))
									{
										if (!(text4 == "wpn_eat1") && !(text4 == "_MidGrey"))
										{
											text4 = "Biped's spine bone nr ";
											Debug.LogError("_ToneCurve");
										}
										else
										{
											text4 = "1HSwordStrafeRunLeft";
										}
									}
									else
									{
										text4 = "";
									}
								}
								else
								{
									text4 = "RunBackLeft";
								}
								if (text4.Length != 0)
								{
									this.BAIPLCGIBEM("UV2" + text4);
								}
							}
							else
							{
								Debug.LogError("Zombie Crawl");
							}
						}
						else if (text == "INTERFACE" || text == "{0}")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								int num3;
								if (int.TryParse(array2[j], out num3))
								{
									this.BAIPLCGIBEM("lineTENSIONKGFRIC=" + array2[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("money" + array2[j] + "");
								}
							}
							else
							{
								Debug.LogError("_camScale");
							}
						}
						else if (text == "" || text == "Object To Instantiate")
						{
							if (array2.Length > j + 0)
							{
								j++;
								string text5 = array2[j].ToUpper();
								if (!(text5 == "rollSoundIndex"))
								{
									if (!(text5 == "\n") && !(text5 == "VRIK needs a Humanoid Animator to auto-detect biped references. Please assign references manually."))
									{
										text5 = "1";
										Debug.LogError("  Balls Fired: ");
									}
									else
									{
										text5 = "_RampTex";
									}
								}
								else
								{
									text5 = "UNIQUE_SHADOW";
								}
								if (text5.Length != 0)
								{
									this.KGPCKBOFDCD("LockToDevice level" + text5);
								}
							}
							else
							{
								Debug.LogError(" is represented multiple times in a single IK chain. Can't initiate solver.");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.IAJFBMHEHJE(stringBuilder.ToString());
			this.KPGKJKIAGIE();
		}

		// Token: 0x0600587A RID: 22650 RVA: 0x0029EAC4 File Offset: 0x0029CCC4
		private void IMHPEFJJIAJ(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("Mouse X");
			HBFECCBOEMN = "MotorbikeLassoLeft" + HBFECCBOEMN + "https://www.youtube.com/watch?v=wT8fViZpLmQ";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(1, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[0];
			array[1] = '\u001f';
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string value = this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
				{
					'~'
				});
				this.JEPBCFCBPEL.Length = 1;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.DKAADEBJADA() * (float)num;
				object[] array2 = new object[5];
				array2[0] = "post_8";
				array2[0] = num2;
				array2[4] = "_BilateralUpsampling";
				array2[8] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array2);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x0600587B RID: 22651 RVA: 0x0029EBB4 File Offset: 0x0029CDB4
		private void GAGEBPHCCBM()
		{
			if (this.JEPBCFCBPEL.ToString() == "WorkerPickaxe")
			{
				this.JEPBCFCBPEL.Append("#ffffff");
			}
			this.NFPEMFOKNOB(false);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x0600587C RID: 22652 RVA: 0x0029EC08 File Offset: 0x0029CE08
		private float DJNELNLIHMP()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("**")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("* *")).x - x;
		}

		// Token: 0x0600587D RID: 22653 RVA: 0x0029EC4C File Offset: 0x0029CE4C
		private void KDNOLJENLEO()
		{
			this.LEMDHBOFKLO();
			this.JEPBCFCBPEL.Length = 0;
			this.IIMMFKJAOMP(true);
			this.EMKALNJHCLE = 345f;
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x0029EC72 File Offset: 0x0029CE72
		private void LCLOGLIIHAD()
		{
			this.BKFDICKFJHM();
			this.JEPBCFCBPEL.Length = 0;
			this.NGKAGGNCGDH(false);
			this.EMKALNJHCLE = 363f;
		}

		// Token: 0x0600587F RID: 22655 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> IBJKEDHMNPL()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x06005880 RID: 22656 RVA: 0x0029EC98 File Offset: 0x0029CE98
		private float MCLDOIJHCPE()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("The InteractionSystem has not been initiated yet.")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("Superman")).x - x;
		}

		// Token: 0x06005881 RID: 22657 RVA: 0x0029ECDC File Offset: 0x0029CEDC
		private void EPGDOPKALCN(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.NGKAGGNCGDH(true);
			this.EMKALNJHCLE = 612f;
			this.DDENOLFFBNI = 431f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < FPIHOPOCAHA.Length; i++)
			{
				int num;
				if ((int)FPIHOPOCAHA[i] == -60 && FPIHOPOCAHA.Length > i + 0 && FPIHOPOCAHA[i + 0] == 'o')
				{
					stringBuilder.Append("wpn_hookf");
					i += 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -107)
				{
					this.IAJFBMHEHJE(stringBuilder.ToString());
					this.LCLOGLIIHAD();
					stringBuilder.Length = 1;
				}
				else if (FPIHOPOCAHA[i] == '(' && stringBuilder.Length != 0)
				{
					this.PDLEKKOKMNJ(stringBuilder.ToString());
					stringBuilder.Length = 1;
					stringBuilder.Append((char)-50);
				}
				else if ((int)FPIHOPOCAHA[i] == -97 && FPIHOPOCAHA.Length > i + 0 && (int)FPIHOPOCAHA[i + 1] == -103)
				{
					stringBuilder.Append("IdleMeditate");
					i++;
				}
				else if ((int)FPIHOPOCAHA[i] == -8 && FPIHOPOCAHA.Length > i + 0 && (num = FPIHOPOCAHA.IndexOf('\\', i)) != -1)
				{
					this.IAJFBMHEHJE(stringBuilder.ToString());
					stringBuilder.Length = 1;
					string text = FPIHOPOCAHA.Substring(i + 0, num - i - 1);
					i += text.Length + 0;
					string text2 = text;
					char[] array = new char[0];
					array[0] = (char)-117;
					string[] array2 = text2.Split(array);
					for (int j = 0; j < array2.Length; j += 0)
					{
						text = array2[j].ToUpper();
						if (text == "tankfullmsg1" || text == ", ")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Color color;
								if (array2[j] == "body" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color))
								{
									this.JJKMFNEDHHL("_RgbBlendCacheTex" + array2[j]);
								}
								else
								{
									Debug.LogError("DENSITY");
								}
							}
							else
							{
								Debug.LogError("wpn_rec1");
							}
						}
						else if (text == "" || text == "cht_msg35")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								Color color2;
								if (array2[j] == "Mouse ScrollWheel" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color2))
								{
									this.KGPCKBOFDCD("Nade Throw" + array2[j]);
								}
								else
								{
									Debug.LogError("delcharmsg2");
								}
							}
							else
							{
								Debug.LogError("MotorbikeShootLeft" + FPIHOPOCAHA);
							}
						}
						else if (text == "_BlurVector" || text == "DrawDistanceFadeSize")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Font font = (Font)Resources.Load("close" + array2[j]);
								if (font == null)
								{
									Debug.LogError("<color='#808080'>[{2}]</color> <color='#a0ffa0'>{0}</color>: {1}" + array2[j] + " x");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.BBGJMGMHJPP("" + array2[j]);
								}
								if (array2.Length > j + 0)
								{
									j += 0;
									int fontSize;
									if (int.TryParse(array2[j], out fontSize))
									{
										this.MHIMHDGOFNC("ZombieIdle2" + array2[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("ProneIdle" + array2[j] + "Apply 5");
									}
								}
							}
							else
							{
								Debug.LogError("{0:F2}, {1:F2}, {2:F2}");
							}
						}
						else if (text == "offsets" || text == "UpHillWalkHandGrab")
						{
							if (array2.Length > j + 1)
							{
								j++;
								string text3 = array2[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text3);
								if (num2 <= 17U)
								{
									if (num2 <= 168U)
									{
										if (num2 != 4294967229U)
										{
											if (num2 != 4294967234U)
											{
												goto IL_50B;
											}
											if (!(text3 == "UI_MapWindow_b"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text3 == "MENU.WAV"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 76U)
									{
										if (num2 != 4294967200U)
										{
											goto IL_50B;
										}
										if (!(text3 == " L "))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "t_top"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text3 = "IdleFeedThrow";
								}
								else
								{
									if (num2 <= 4294967207U)
									{
										if (num2 != 74U)
										{
											if (num2 != 157U)
											{
												goto IL_50B;
											}
											if (!(text3 == "cht_msg39"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text3 == "change channek close"))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 4294967110U)
									{
										if (num2 != 126U)
										{
											goto IL_50B;
										}
										if (!(text3 == "error"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "Transforms is null."))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text3 = "Sound/";
								}
								IL_51C:
								if (text3.Length != 0)
								{
									this.BBGJMGMHJPP("Lasso Back" + text3);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text3 = "Loading Asset Bundle ";
								Debug.LogError("Put Out Cigarette");
								goto IL_51C;
								IL_4F0:
								text3 = "fshop_btn3";
								goto IL_51C;
								IL_4E7:
								text3 = "IdleMonster";
								goto IL_51C;
							}
							Debug.LogError("0_");
						}
						else if (text == "Scuba Swim" || text == "_FadeDistance")
						{
							if (array2.Length > j + 0)
							{
								j++;
								int fontSize2;
								if (int.TryParse(array2[j], out fontSize2))
								{
									this.PLJJCFOFGKE("auk_whead" + array2[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("wpn_book1" + array2[j] + "perk_");
								}
							}
							else
							{
								Debug.LogError("cntx_use");
							}
						}
						else if (text == "cht_msg1" || text == " B:")
						{
							if (array2.Length > j + 0)
							{
								j++;
								this.BNFIJCEKEBL("Player" + array2[j]);
							}
							else
							{
								Debug.LogError("auc_wcstc");
							}
						}
						else if (text == "Hidden/Post FX/Builtin Debug Views" || text == "XL")
						{
							this.EJIDBALNMEN("knopje.wav");
						}
						else if (text == ">>" || text == "FlyRight")
						{
							if (array2.Length > j + 1)
							{
								j++;
								string text4 = array2[j].ToUpper();
								if (!(text4 == " is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.") && !(text4 == ""))
								{
									if (!(text4 == "IdleFeedThrow") && !(text4 == "How your string is stored in memory when obscured:\n"))
									{
										if (!(text4 == "") && !(text4 == "Error via final request"))
										{
											text4 = "upRod";
											Debug.LogError("gi_tit_chy");
										}
										else
										{
											text4 = "{0} {1}";
										}
									}
									else
									{
										text4 = "UNDISTORT";
									}
								}
								else
								{
									text4 = "BowFire";
								}
								if (text4.Length != 0)
								{
									this.BNAOGCBCOGK("crft_cost" + text4);
								}
							}
							else
							{
								Debug.LogError("error: mainAsset is null");
							}
						}
						else if (text == "WeaponFire" || text == "Turn")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								int num3;
								if (int.TryParse(array2[j], out num3))
								{
									this.FGJFINIJPMI("Downsamp" + array2[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("altosad" + array2[j] + "KatanaReady");
								}
							}
							else
							{
								Debug.LogError("_MainTex");
							}
						}
						else if (text == "_" || text == "Wrist")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								string text5 = array2[j].ToUpper();
								if (!(text5 == "man_death.ogg"))
								{
									if (!(text5 == "Mouse X") && !(text5 == "file:///"))
									{
										text5 = "Flames";
										Debug.LogError("craft/stanok");
									}
									else
									{
										text5 = "R to reset fog.";
									}
								}
								else
								{
									text5 = "ObscuredPrefs";
								}
								if (text5.Length != 0)
								{
									this.IADJMONCMFE(" Collider" + text5);
								}
							}
							else
							{
								Debug.LogError("SkateForward");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.GOIAECNFKLE(stringBuilder.ToString());
			this.IICECKOCOKC();
		}

		// Token: 0x06005882 RID: 22658 RVA: 0x0029F5B4 File Offset: 0x0029D7B4
		private float OCCMJMPPALB()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("ok")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("")).x - x;
		}

		// Token: 0x06005883 RID: 22659 RVA: 0x0029F5F8 File Offset: 0x0029D7F8
		private bool MCFKOGCJICE(string LNEADABFMGK)
		{
			bool result = false;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == "time") ? this.AICMJCEALOH() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.IDHFBAECIPE();
					result = true;
					string text = LNEADABFMGK;
					char[] array = new char[0];
					array[1] = 'm';
					LNEADABFMGK = text.TrimStart(array);
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x06005884 RID: 22660 RVA: 0x0029F6B5 File Offset: 0x0029D8B5
		public JAOAMKCAGPJ(float NMEBEEHCALN, string FPIHOPOCAHA)
		{
			this.CIOFBPFBLJO = NMEBEEHCALN;
			this.HJPCBNBFFJE = new List<string>();
			this.LJCEDKCLBDB(FPIHOPOCAHA);
		}

		// Token: 0x06005885 RID: 22661 RVA: 0x0029F6D8 File Offset: 0x0029D8D8
		private void KBBGOJGCNON()
		{
			if (this.JEPBCFCBPEL.ToString() == "wpn_add/base")
			{
				this.JEPBCFCBPEL.Append("wpn_rod1");
			}
			this.CDMNIEFFIOK(false);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x06005886 RID: 22662 RVA: 0x0029F72C File Offset: 0x0029D92C
		private float MEIKDANAJGK()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("name")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("Katana Ready High")).x - x;
		}

		// Token: 0x06005887 RID: 22663 RVA: 0x0029F770 File Offset: 0x0029D970
		private void LJCEDKCLBDB(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.MIKKJNFEBHO(false);
			this.EMKALNJHCLE = 0f;
			this.DDENOLFFBNI = 0f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < FPIHOPOCAHA.Length; i++)
			{
				int num;
				if (FPIHOPOCAHA[i] == '\\' && FPIHOPOCAHA.Length > i + 1 && FPIHOPOCAHA[i + 1] == '\\')
				{
					stringBuilder.Append("\\");
					i++;
				}
				else if (FPIHOPOCAHA[i] == '\n')
				{
					this.CFPNCEFOIAN(stringBuilder.ToString());
					this.BKJHOGMDKMC();
					stringBuilder.Length = 0;
				}
				else if (FPIHOPOCAHA[i] == ' ' && stringBuilder.Length != 0)
				{
					this.CFPNCEFOIAN(stringBuilder.ToString());
					stringBuilder.Length = 0;
					stringBuilder.Append(' ');
				}
				else if (FPIHOPOCAHA[i] == '[' && FPIHOPOCAHA.Length > i + 1 && FPIHOPOCAHA[i + 1] == '[')
				{
					stringBuilder.Append("[[");
					i++;
				}
				else if (FPIHOPOCAHA[i] == '[' && FPIHOPOCAHA.Length > i + 1 && (num = FPIHOPOCAHA.IndexOf(']', i)) != -1)
				{
					this.CFPNCEFOIAN(stringBuilder.ToString());
					stringBuilder.Length = 0;
					string text = FPIHOPOCAHA.Substring(i + 1, num - i - 1);
					i += text.Length + 1;
					string[] array = text.Split(new char[]
					{
						' '
					});
					for (int j = 0; j < array.Length; j++)
					{
						text = array[j].ToUpper();
						if (text == "BC" || text == "BACKCOLOR")
						{
							if (array.Length > j + 1)
							{
								j++;
								Color color;
								if (array[j] == "?" || BKLBFBELDGL.JMGMHLCELLF(array[j], out color))
								{
									this.IBKBAELMCEL("BC " + array[j]);
								}
								else
								{
									Debug.LogError("The 'BackColor' command requires a color parameter of RRGGBBAA or '?'.");
								}
							}
							else
							{
								Debug.LogError("The 'BackColor' command requires a color parameter of RRGGBBAA or '?'.");
							}
						}
						else if (text == "C" || text == "COLOR")
						{
							if (array.Length > j + 1)
							{
								j++;
								Color color2;
								if (array[j] == "?" || BKLBFBELDGL.JMGMHLCELLF(array[j], out color2))
								{
									this.IBKBAELMCEL("C " + array[j]);
								}
								else
								{
									Debug.LogError("The 'color' command requires a color parameter of RRGGBBAA or '?'.");
								}
							}
							else
							{
								Debug.LogError("The 'color' command requires a color parameter of RRGGBBAA:\n" + FPIHOPOCAHA);
							}
						}
						else if (text == "F" || text == "FONT")
						{
							if (array.Length > j + 1)
							{
								j++;
								Font font = (Font)Resources.Load("Fonts/" + array[j]);
								if (font == null)
								{
									Debug.LogError("The font '" + array[j] + "' does not exist within Assets/Resources/Fonts/");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.IBKBAELMCEL("F " + array[j]);
								}
								if (array.Length > j + 1)
								{
									j++;
									int fontSize;
									if (int.TryParse(array[j], out fontSize))
									{
										this.IBKBAELMCEL("FS " + array[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("The font size '" + array[j] + "' is not a valid integer");
									}
								}
							}
							else
							{
								Debug.LogError("The 'font' command requires a font name parameter and an optional font size parameter.");
							}
						}
						else if (text == "FA" || text == "FONTATTRIBUTE")
						{
							if (array.Length > j + 1)
							{
								j++;
								string text2 = array[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text2);
								if (num2 <= 1993188465U)
								{
									if (num2 <= 1376765663U)
									{
										if (num2 != 983688779U)
										{
											if (num2 != 1376765663U)
											{
												goto IL_50B;
											}
											if (!(text2 == "UNDERLINE"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text2 == "-STRIKETHROUGH"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 1719394836U)
									{
										if (num2 != 1993188465U)
										{
											goto IL_50B;
										}
										if (!(text2 == "-S"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text2 == "-UNDERLINE"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text2 = "-S";
								}
								else
								{
									if (num2 <= 2724562404U)
									{
										if (num2 != 2026743703U)
										{
											if (num2 != 2724562404U)
											{
												goto IL_50B;
											}
											if (!(text2 == "STRIKETHROUGH"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text2 == "-U"))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 3490449840U)
									{
										if (num2 != 3591115554U)
										{
											goto IL_50B;
										}
										if (!(text2 == "S"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text2 == "U"))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text2 = "S";
								}
								IL_51C:
								if (text2.Length != 0)
								{
									this.IBKBAELMCEL("FA " + text2);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text2 = "";
								Debug.LogError("The 'font attribute' command requires a font parameter of U (underline on), -U (underline off), S (strikethrough on) or -S (strikethrough off).");
								goto IL_51C;
								IL_4F0:
								text2 = "-U";
								goto IL_51C;
								IL_4E7:
								text2 = "U";
								goto IL_51C;
							}
							Debug.LogError("The 'font attribute' command requires a font parameter of U (underline on), -U (underline off), S (strikethrough on) or -S (strikethrough off).");
						}
						else if (text == "FS" || text == "FONTSIZE")
						{
							if (array.Length > j + 1)
							{
								j++;
								int fontSize2;
								if (int.TryParse(array[j], out fontSize2))
								{
									this.IBKBAELMCEL("FS " + array[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("The font size '" + array[j] + "' is not a valid integer");
								}
							}
							else
							{
								Debug.LogError("The 'font size' command requires a font size parameter.");
							}
						}
						else if (text == "H" || text == "HYPERLINK")
						{
							if (array.Length > j + 1)
							{
								j++;
								this.IBKBAELMCEL("H " + array[j]);
							}
							else
							{
								Debug.LogError("The 'hyperlink' command requires an hyperlink id parameter.");
							}
						}
						else if (text == "-H" || text == "-HYPERLINK")
						{
							this.IBKBAELMCEL("-H");
						}
						else if (text == "HA" || text == "HALIGN")
						{
							if (array.Length > j + 1)
							{
								j++;
								string text3 = array[j].ToUpper();
								if (!(text3 == "L") && !(text3 == "LEFT"))
								{
									if (!(text3 == "R") && !(text3 == "RIGHT"))
									{
										if (!(text3 == "C") && !(text3 == "CENTER"))
										{
											text3 = "";
											Debug.LogError("The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center).");
										}
										else
										{
											text3 = "C";
										}
									}
									else
									{
										text3 = "R";
									}
								}
								else
								{
									text3 = "L";
								}
								if (text3.Length != 0)
								{
									this.IBKBAELMCEL("HA " + text3);
								}
							}
							else
							{
								Debug.LogError("The 'HAlign' command requires an alignment parameter of L (left), R (right), or C (center).");
							}
						}
						else if (text == "S" || text == "SPACE")
						{
							if (array.Length > j + 1)
							{
								j++;
								int num3;
								if (int.TryParse(array[j], out num3))
								{
									this.IBKBAELMCEL("S " + array[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("The space size '" + array[j] + "' is not a valid integer");
								}
							}
							else
							{
								Debug.LogError("The 'space' command requires a pixel count parameter.");
							}
						}
						else if (text == "VA" || text == "VALIGN")
						{
							if (array.Length > j + 1)
							{
								j++;
								string text4 = array[j].ToUpper();
								if (!(text4 == "?"))
								{
									if (!(text4 == "B") && !(text4 == "BOTTOM"))
									{
										text4 = "";
										Debug.LogError("The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).");
									}
									else
									{
										text4 = "B";
									}
								}
								else
								{
									text4 = "?";
								}
								if (text4.Length != 0)
								{
									this.IBKBAELMCEL("VA " + text4);
								}
							}
							else
							{
								Debug.LogError("The 'VAlign' command requires an alignment parameter of ? (default) or B (bottom).");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.CFPNCEFOIAN(stringBuilder.ToString());
			this.EGGPNKBFINJ();
		}

		// Token: 0x06005888 RID: 22664 RVA: 0x002A0048 File Offset: 0x0029E248
		private void FBDGCALLHBG(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "Assets/Weapons/bootsBase.unity3d".Replace("_ColorBuffer", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("_HitTime", newValue);
				this.DDENOLFFBNI = 221f;
				return;
			}
			this.JEPBCFCBPEL.Append("Detects cheating of any Obscured type (except ObscuredPrefs, it has own detection features) used in project.");
		}

		// Token: 0x06005889 RID: 22665 RVA: 0x002A00A2 File Offset: 0x0029E2A2
		private void EOGFKNCHJOD()
		{
			this.JENMDAEMLIO();
			this.JEPBCFCBPEL.Length = 0;
			this.NGKAGGNCGDH(true);
			this.EMKALNJHCLE = 1755f;
		}

		// Token: 0x0600588A RID: 22666 RVA: 0x002A00C8 File Offset: 0x0029E2C8
		private void JNOJDHGEEKH(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("<b>Vector3:</b> ");
			HBFECCBOEMN = "\n" + HBFECCBOEMN + "INTERFACE";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[0];
			array[0] = (char)-101;
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string text2 = this.JEPBCFCBPEL.ToString();
				char[] array2 = new char[0];
				array2[0] = ',';
				string value = text2.TrimEnd(array2);
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.CIMHFHODAHL() * (float)num;
				object[] array3 = new object[0];
				array3[0] = "Vertical";
				array3[0] = num2;
				array3[4] = "result_id";
				array3[2] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array3);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x0600588B RID: 22667 RVA: 0x002A01B8 File Offset: 0x0029E3B8
		private void KMKOIFAGJFM(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.HDPBGODGNEC(false);
			this.EMKALNJHCLE = 1807f;
			this.DDENOLFFBNI = 1875f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < FPIHOPOCAHA.Length; i += 0)
			{
				int num;
				if ((int)FPIHOPOCAHA[i] == -85 && FPIHOPOCAHA.Length > i + 1 && (int)FPIHOPOCAHA[i + 1] == -29)
				{
					stringBuilder.Append("{0:f2}");
					i++;
				}
				else if (FPIHOPOCAHA[i] == 'M')
				{
					this.DDGEKHJDJOL(stringBuilder.ToString());
					this.FLOLIDPNGCE();
					stringBuilder.Length = 1;
				}
				else if ((int)FPIHOPOCAHA[i] == -35 && stringBuilder.Length != 0)
				{
					this.PDLEKKOKMNJ(stringBuilder.ToString());
					stringBuilder.Length = 0;
					stringBuilder.Append((char)-74);
				}
				else if (FPIHOPOCAHA[i] == '\u0014' && FPIHOPOCAHA.Length > i + 0 && (int)FPIHOPOCAHA[i + 0] == -67)
				{
					stringBuilder.Append(" ");
					i++;
				}
				else if (FPIHOPOCAHA[i] == 'i' && FPIHOPOCAHA.Length > i + 0 && (num = FPIHOPOCAHA.IndexOf((char)-113, i)) != -1)
				{
					this.DOJJLLNOLGD(stringBuilder.ToString());
					stringBuilder.Length = 1;
					string text = FPIHOPOCAHA.Substring(i + 0, num - i - 0);
					i += text.Length + 1;
					string text2 = text;
					char[] array = new char[1];
					array[1] = '\u0003';
					string[] array2 = text2.Split(array);
					for (int j = 0; j < array2.Length; j += 0)
					{
						text = array2[j].ToUpper();
						if (text == "NadeThrow" || text == "teech_perk")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Color color;
								if (array2[j] == "KatanaHorizontalSwing" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color))
								{
									this.MHIMHDGOFNC("" + array2[j]);
								}
								else
								{
									Debug.LogError("_FogWaterLevel");
								}
							}
							else
							{
								Debug.LogError("RenderTextures are not supported on this platform.");
							}
						}
						else if (text == "fshop_btn2" || text == "WeaponReadyFire")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								Color color2;
								if (array2[j] == "Crouch180" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color2))
								{
									this.IMHPEFJJIAJ("signal_enable" + array2[j]);
								}
								else
								{
									Debug.LogError("true");
								}
							}
							else
							{
								Debug.LogError("_AdditiveReflection" + FPIHOPOCAHA);
							}
						}
						else if (text == "Pistol Fire" || text == "SneakLeft")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								Font font = (Font)Resources.Load("" + array2[j]);
								if (font == null)
								{
									Debug.LogError("OfficeSittingHandRestFingerTap" + array2[j] + "rem");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.MNBGBBKAEAC("" + array2[j]);
								}
								if (array2.Length > j + 1)
								{
									j++;
									int fontSize;
									if (int.TryParse(array2[j], out fontSize))
									{
										this.IBKBAELMCEL("change channek close" + array2[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("ACTk offers own collection of the secure types to let you protect your variables from <b>ANY</b> memory hacking tools (Cheat Engine, ArtMoney, GameCIH, Game Guardian, etc.)." + array2[j] + "name");
									}
								}
							}
							else
							{
								Debug.LogError("ElvisLegsLoop");
							}
						}
						else if (text == "_GuiProcessor" || text == "GestureCutThroat")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								string text3 = array2[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text3);
								if (num2 <= 4294967251U)
								{
									if (num2 <= 153U)
									{
										if (num2 != 77U)
										{
											if (num2 != 1U)
											{
												goto IL_50B;
											}
											if (!(text3 == "_MainTexBlurred"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text3 == "wpn_med2"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 4294967279U)
									{
										if (num2 != 4294967149U)
										{
											goto IL_50B;
										}
										if (!(text3 == "CraftProf.xml"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "gi_um_nosel"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text3 = "1HandHeavyOverhead";
								}
								else
								{
									if (num2 <= 71U)
									{
										if (num2 != 175U)
										{
											if (num2 != 192U)
											{
												goto IL_50B;
											}
											if (!(text3 == "▮▯▯"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text3 == "OneHandSwordSwing"))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 24U)
									{
										if (num2 != 4294967263U)
										{
											goto IL_50B;
										}
										if (!(text3 == "minimalLevel"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "25"))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text3 = "ApplePick";
								}
								IL_51C:
								if (text3.Length != 0)
								{
									this.BNAOGCBCOGK("1HandSwordChargeUp" + text3);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text3 = "IdleWalk";
								Debug.LogError("PistolFire");
								goto IL_51C;
								IL_4F0:
								text3 = "ApplePick";
								goto IL_51C;
								IL_4E7:
								text3 = "CardPlayerIdle";
								goto IL_51C;
							}
							Debug.LogError("Stand Up");
						}
						else if (text == "_Blurred" || text == ". ")
						{
							if (array2.Length > j + 0)
							{
								j++;
								int fontSize2;
								if (int.TryParse(array2[j], out fontSize2))
								{
									this.BAIPLCGIBEM(" " + array2[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError(">> 2 >>" + array2[j] + "Left arm 'Palm To Thumb Axis' needs to be set in VRIK. Please select the hand bone, set it to the axis that points from the palm towards the thumb. If the arrow points away from the thumb, axis must be negative.");
								}
							}
							else
							{
								Debug.LogError("Vertical");
							}
						}
						else if (text == "palm" || text == "MotorbikeBackwardStand")
						{
							if (array2.Length > j + 1)
							{
								j++;
								this.IBKBAELMCEL("SoccerWalk" + array2[j]);
							}
							else
							{
								Debug.LogError("id");
							}
						}
						else if (text == "wpn_eat7" || text == "MotorbikeShootLeft")
						{
							this.MAPLLADKCON("_Offsets");
						}
						else if (text == "Roll" || text == "CraftProf.xml")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								string text4 = array2[j].ToUpper();
								if (!(text4 == "gi_ach") && !(text4 == "IdleDie"))
								{
									if (!(text4 == "HA ") && !(text4 == "<color=\""))
									{
										if (!(text4 == "_FogAlpha") && !(text4 == "offsets"))
										{
											text4 = "Textures/Fish/";
											Debug.LogError(" has been disabled as it requires HDR.");
										}
										else
										{
											text4 = "stretchWidth";
										}
									}
									else
									{
										text4 = "WeaponStand";
									}
								}
								else
								{
									text4 = "ActorFish";
								}
								if (text4.Length != 0)
								{
									this.IMHPEFJJIAJ("SoccerKeeperReady" + text4);
								}
							}
							else
							{
								Debug.LogError("1HandSwordChargeHeavyBash");
							}
						}
						else if (text == "http://www.root-motion.com/finalikdox/html/page7.html" || text == "MotorbikeBackwardSittingCheer")
						{
							if (array2.Length > j + 1)
							{
								j++;
								int num3;
								if (int.TryParse(array2[j], out num3))
								{
									this.EJIDBALNMEN("Soccer" + array2[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("Assets/Weapons/wbootsBase.unity3d" + array2[j] + "1024");
								}
							}
							else
							{
								Debug.LogError("ProneLocomotion");
							}
						}
						else if (text == "100" || text == "FlyUp")
						{
							if (array2.Length > j + 0)
							{
								j++;
								string text5 = array2[j].ToUpper();
								if (!(text5 == "Giant2HandSlamIdle"))
								{
									if (!(text5 == "BackPress") && !(text5 == ""))
									{
										text5 = "WeaponStrafeRunRight";
										Debug.LogError("mouseLook not found");
									}
									else
									{
										text5 = "[ProBuilder Attachments] A pb_Object is missing, this is normally caused by pb_Objects being stripped.";
									}
								}
								else
								{
									text5 = "#FF4040";
								}
								if (text5.Length != 0)
								{
									this.MCNCFBHJGBB("VaderChoke" + text5);
								}
							}
							else
							{
								Debug.LogError("Отпущено {0} рыб, общим весом \n<color='#a000ff'>{1}</color>\nПолучено {2} опыта");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.PDLEKKOKMNJ(stringBuilder.ToString());
			this.EGGPNKBFINJ();
		}

		// Token: 0x0600588C RID: 22668 RVA: 0x002A0A90 File Offset: 0x0029EC90
		private void EIKPOGOBHMC(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.IIMMFKJAOMP(true);
			this.EMKALNJHCLE = 1120f;
			this.DDENOLFFBNI = 1721f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < FPIHOPOCAHA.Length; i++)
			{
				int num;
				if ((int)FPIHOPOCAHA[i] == -64 && FPIHOPOCAHA.Length > i + 1 && (int)FPIHOPOCAHA[i + 0] == -21)
				{
					stringBuilder.Append("WeaponRun");
					i++;
				}
				else if (FPIHOPOCAHA[i] == 'K')
				{
					this.DLPCEKMALFB(stringBuilder.ToString());
					this.MPBLDEDOFGH();
					stringBuilder.Length = 0;
				}
				else if (FPIHOPOCAHA[i] == '_' && stringBuilder.Length != 0)
				{
					this.GCHPKJELKLB(stringBuilder.ToString());
					stringBuilder.Length = 0;
					stringBuilder.Append((char)-104);
				}
				else if ((int)FPIHOPOCAHA[i] == -90 && FPIHOPOCAHA.Length > i + 1 && (int)FPIHOPOCAHA[i + 0] == -53)
				{
					stringBuilder.Append("remWpn=");
					i += 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -103 && FPIHOPOCAHA.Length > i + 1 && (num = FPIHOPOCAHA.IndexOf('r', i)) != -1)
				{
					this.DLPCEKMALFB(stringBuilder.ToString());
					stringBuilder.Length = 1;
					string text = FPIHOPOCAHA.Substring(i + 0, num - i - 1);
					i += text.Length + 0;
					string text2 = text;
					char[] array = new char[0];
					array[1] = (char)-30;
					string[] array2 = text2.Split(array);
					for (int j = 0; j < array2.Length; j += 0)
					{
						text = array2[j].ToUpper();
						if (text == "Cowboy1HandDraw" || text == "cht_msg38")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Color color;
								if (array2[j] == "wpn_chair3" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color))
								{
									this.GOKJENBLLPH("float:" + array2[j]);
								}
								else
								{
									Debug.LogError(" has been disabled as it's not supported on the current platform.");
								}
							}
							else
							{
								Debug.LogError("GiantGrabThrow2");
							}
						}
						else if (text == "" || text == "byte:")
						{
							if (array2.Length > j + 0)
							{
								j++;
								Color color2;
								if (array2[j] == "isRodInWater" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color2))
								{
									this.BBGJMGMHJPP("_NoiseScale" + array2[j]);
								}
								else
								{
									Debug.LogError("DataSize ");
								}
							}
							else
							{
								Debug.LogError("WateringCanWatering" + FPIHOPOCAHA);
							}
						}
						else if (text == "Assets/Weapons/" || text == "SneakBackward")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Font font = (Font)Resources.Load("" + array2[j]);
								if (font == null)
								{
									Debug.LogError("cntx_resauk" + array2[j] + "Idle Sand Cover");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.BAIPLCGIBEM("Отпущена рыба" + array2[j]);
								}
								if (array2.Length > j + 1)
								{
									j++;
									int fontSize;
									if (int.TryParse(array2[j], out fontSize))
									{
										this.EJIDBALNMEN("Noise & Grain effect failing as noise texture is not assigned. please assign." + array2[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("WorkerHammer" + array2[j] + "demoByteArray");
									}
								}
							}
							else
							{
								Debug.LogError("FlyForward");
							}
						}
						else if (text == "\n" || text == "</color>")
						{
							if (array2.Length > j + 0)
							{
								j++;
								string text3 = array2[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text3);
								if (num2 <= 4294967203U)
								{
									if (num2 <= 4294967171U)
									{
										if (num2 != 4294967269U)
										{
											if (num2 != 4294967200U)
											{
												goto IL_50B;
											}
											if (!(text3 == "[Y]"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text3 == "BlackSmithHammer"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 108U)
									{
										if (num2 != 149U)
										{
											goto IL_50B;
										}
										if (!(text3 == "_TileVRT"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "[wtemplid]"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text3 = "help";
								}
								else
								{
									if (num2 <= 4294967218U)
									{
										if (num2 != 4294967174U)
										{
											if (num2 != 4294967111U)
											{
												goto IL_50B;
											}
											if (!(text3 == ""))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text3 == "IKSolverLookAt eyes setup is invalid. Can't initiate solver."))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 4294967134U)
									{
										if (num2 != 4294967122U)
										{
											goto IL_50B;
										}
										if (!(text3 == "_Screen"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "_Cull"))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text3 = "spin_bell.ogg";
								}
								IL_51C:
								if (text3.Length != 0)
								{
									this.MAPLLADKCON("Titul" + text3);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text3 = "IdleEat";
								Debug.LogError("Hips");
								goto IL_51C;
								IL_4F0:
								text3 = "repair.ogg";
								goto IL_51C;
								IL_4E7:
								text3 = "<color='#300030'>{0}</color>";
								goto IL_51C;
							}
							Debug.LogError("WizardNeoBlock");
						}
						else if (text == "_FrustumCornersWS" || text == "1 Hand Sword Charge Up")
						{
							if (array2.Length > j + 0)
							{
								j++;
								int fontSize2;
								if (int.TryParse(array2[j], out fontSize2))
								{
									this.BNFIJCEKEBL("rodUpDelta=" + array2[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("Arm Flex 2" + array2[j] + "");
								}
							}
							else
							{
								Debug.LogError("#003080");
							}
						}
						else if (text == "Fishing" || text == "fider_Small_")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								this.BAIPLCGIBEM("No load asset " + array2[j]);
							}
							else
							{
								Debug.LogError("21,22,23");
							}
						}
						else if (text == "Clouds reference not set." || text == "gi_uinf_11")
						{
							this.MCNCFBHJGBB("emergencyMode");
						}
						else if (text == "craft_data/categories/category" || text == "[ACTk] <b>[ ObscuredInt test ]</b>")
						{
							if (array2.Length > j + 0)
							{
								j++;
								string text4 = array2[j].ToUpper();
								if (!(text4 == "[HA ") && !(text4 == "IceHockeyIdle"))
								{
									if (!(text4 == "Get post") && !(text4 == "teech_perk"))
									{
										if (!(text4 == "CrawlIdle") && !(text4 == "level"))
										{
											text4 = "fchair";
											Debug.LogError("");
										}
										else
										{
											text4 = "";
										}
									}
									else
									{
										text4 = "Select";
									}
								}
								else
								{
									text4 = "DeadmanFloat";
								}
								if (text4.Length != 0)
								{
									this.JLHBCFIFKLF("Clear reference not set." + text4);
								}
							}
							else
							{
								Debug.LogError("Cloth_07.wav");
							}
						}
						else if (text == "MB Down lot=" || text == "KatanaReadyHigh")
						{
							if (array2.Length > j + 1)
							{
								j++;
								int num3;
								if (int.TryParse(array2[j], out num3))
								{
									this.MHIMHDGOFNC("" + array2[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("name" + array2[j] + "Vertical");
								}
							}
							else
							{
								Debug.LogError("hgtDst=");
							}
						}
						else if (text == "msgClick" || text == "SexyDance3")
						{
							if (array2.Length > j + 1)
							{
								j++;
								string text5 = array2[j].ToUpper();
								if (!(text5 == "id"))
								{
									if (!(text5 == "_Angle") && !(text5 == "OfficeSittingBack"))
									{
										text5 = "_name";
										Debug.LogError("Invalid references, one or more Transforms are missing.");
									}
									else
									{
										text5 = "spin_bell.ogg";
									}
								}
								else
								{
									text5 = "1HandSwordRollAttack";
								}
								if (text5.Length != 0)
								{
									this.EJIDBALNMEN("MotorbikeLasso" + text5);
								}
							}
							else
							{
								Debug.LogError("WeaponReadyFire");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.MCFKOGCJICE(stringBuilder.ToString());
			this.JENMDAEMLIO();
		}

		// Token: 0x0600588D RID: 22669 RVA: 0x002A1368 File Offset: 0x0029F568
		private void PGPOMNIAGOD(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.MIKKJNFEBHO(false);
			this.EMKALNJHCLE = 221f;
			this.DDENOLFFBNI = 1920f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < FPIHOPOCAHA.Length; i += 0)
			{
				int num;
				if ((int)FPIHOPOCAHA[i] == -10 && FPIHOPOCAHA.Length > i + 1 && FPIHOPOCAHA[i + 0] == '\\')
				{
					stringBuilder.Append("http://www.root-motion.com/finalikdox/html/page10.html");
					i++;
				}
				else if (FPIHOPOCAHA[i] == 'Y')
				{
					this.IAJFBMHEHJE(stringBuilder.ToString());
					this.NGHAFABJDKH();
					stringBuilder.Length = 1;
				}
				else if ((int)FPIHOPOCAHA[i] == -107 && stringBuilder.Length != 0)
				{
					this.CDKPKJAAIEO(stringBuilder.ToString());
					stringBuilder.Length = 0;
					stringBuilder.Append((char)-9);
				}
				else if ((int)FPIHOPOCAHA[i] == -27 && FPIHOPOCAHA.Length > i + 0 && FPIHOPOCAHA[i + 0] == 'S')
				{
					stringBuilder.Append("root");
					i++;
				}
				else if ((int)FPIHOPOCAHA[i] == -128 && FPIHOPOCAHA.Length > i + 1 && (num = FPIHOPOCAHA.IndexOf((char)-8, i)) != -1)
				{
					this.MCFKOGCJICE(stringBuilder.ToString());
					stringBuilder.Length = 0;
					string text = FPIHOPOCAHA.Substring(i + 1, num - i - 0);
					i += text.Length + 0;
					string text2 = text;
					char[] array = new char[1];
					array[1] = (char)-73;
					string[] array2 = text2.Split(array);
					for (int j = 1; j < array2.Length; j += 0)
					{
						text = array2[j].ToUpper();
						if (text == "_NoiseTex" || text == "name")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								Color color;
								if (array2[j] == " on effect " || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color))
								{
									this.MAPLLADKCON("The image effect " + array2[j]);
								}
								else
								{
									Debug.LogError("gi_fridgiceno");
								}
							}
							else
							{
								Debug.LogError("_DstBlend");
							}
						}
						else if (text == ".png" || text == "[wtemplid]")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Color color2;
								if (array2[j] == "WalkDehydrated" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color2))
								{
									this.JLHBCFIFKLF("SoccerTackle" + array2[j]);
								}
								else
								{
									Debug.LogError("OneHandSwordIdle");
								}
							}
							else
							{
								Debug.LogError(" шт" + FPIHOPOCAHA);
							}
						}
						else if (text == "SearchTex" || text == "206000")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								Font font = (Font)Resources.Load("***My Lots event " + array2[j]);
								if (font == null)
								{
									Debug.LogError("GiantGrabIdle" + array2[j] + "</color>");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.BNFIJCEKEBL("PLANE_REFLECTION" + array2[j]);
								}
								if (array2.Length > j + 1)
								{
									j += 0;
									int fontSize;
									if (int.TryParse(array2[j], out fontSize))
									{
										this.PLJJCFOFGKE("" + array2[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("_Axis" + array2[j] + "\n");
									}
								}
							}
							else
							{
								Debug.LogError("StrafeRunRight");
							}
						}
						else if (text == "WandAttack" || text == "_WrinkleInfluences0")
						{
							if (array2.Length > j + 0)
							{
								j++;
								string text3 = array2[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text3);
								if (num2 <= 98U)
								{
									if (num2 <= 52U)
									{
										if (num2 != 4294967212U)
										{
											if (num2 != 188U)
											{
												goto IL_50B;
											}
											if (!(text3 == "FlyLeft"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text3 == "titul_"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 4294967241U)
									{
										if (num2 != 4294967119U)
										{
											goto IL_50B;
										}
										if (!(text3 == "spawnPet id="))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "<color='#200080'>"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text3 = "Run Jump";
								}
								else
								{
									if (num2 <= 122U)
									{
										if (num2 != 115U)
										{
											if (num2 != 4294967197U)
											{
												goto IL_50B;
											}
											if (!(text3 == "WeaponRun"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text3 == "Name: "))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 4294967120U)
									{
										if (num2 != 4294967140U)
										{
											goto IL_50B;
										}
										if (!(text3 == "\npb_Face: "))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "_AdaptTex"))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text3 = " cm";
								}
								IL_51C:
								if (text3.Length != 0)
								{
									this.BNAOGCBCOGK("C" + text3);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text3 = "\n";
								Debug.LogError("__a");
								goto IL_51C;
								IL_4F0:
								text3 = "}";
								goto IL_51C;
								IL_4E7:
								text3 = "KatanaReadyHigh";
								goto IL_51C;
							}
							Debug.LogError("sunshine_CameraVToSunVP");
						}
						else if (text == "turn_base1" || text == "cht_umsg10")
						{
							if (array2.Length > j + 0)
							{
								j++;
								int fontSize2;
								if (int.TryParse(array2[j], out fontSize2))
								{
									this.GOKJENBLLPH("Clavicle" + array2[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("minWgtBait" + array2[j] + "<color='{0}'> {1} ур {2}</color>\n");
								}
							}
							else
							{
								Debug.LogError("\n");
							}
						}
						else if (text == "onHyperLinkActivated: " || text == "ArmFlex6")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								this.JBNJLJEELLN("<color='#004000'>{0}</color>" + array2[j]);
							}
							else
							{
								Debug.LogError("WeaponFire");
							}
						}
						else if (text == "Error via final request" || text == "_ProjMatrix")
						{
							this.JLHBCFIFKLF("Data not loaded!");
						}
						else if (text == "_FogColor" || text == "Steam Overlay has been closed")
						{
							if (array2.Length > j + 0)
							{
								j++;
								string text4 = array2[j].ToUpper();
								if (!(text4 == "wpn_rem4") && !(text4 == "error.wav"))
								{
									if (!(text4 == "3") && !(text4 == "_Threshold"))
									{
										if (!(text4 == "") && !(text4 == "MotorbikeAirWalk"))
										{
											text4 = "";
											Debug.LogError("ObscuredBool vs bool, ");
										}
										else
										{
											text4 = "Button";
										}
									}
									else
									{
										text4 = "WizardBlock";
									}
								}
								else
								{
									text4 = "wpn_wgt";
								}
								if (text4.Length != 0)
								{
									this.PLJJCFOFGKE("_ReflectionTexture4" + text4);
								}
							}
							else
							{
								Debug.LogError("_FogAlpha");
							}
						}
						else if (text == "ClimbUp" || text == "GestureHandUp")
						{
							if (array2.Length > j + 1)
							{
								j++;
								int num3;
								if (int.TryParse(array2[j], out num3))
								{
									this.MCNCFBHJGBB("SkateboardKickPush" + array2[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("crft_from" + array2[j] + "128");
								}
							}
							else
							{
								Debug.LogError("onDisconnect PROCEDURE");
							}
						}
						else if (text == "https://www.youtube.com/watch?v=sQfB2RcT1T4&index=14&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6" || text == "_ArScale")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								string text5 = array2[j].ToUpper();
								if (!(text5 == "DealerIdle"))
								{
									if (!(text5 == "===== ObscuredFloatTest =====\n") && !(text5 == "qualityLevel"))
									{
										text5 = "</color>";
										Debug.LogError("1HandSwordChargeHeavyBash");
									}
									else
									{
										text5 = "isRealView";
									}
								}
								else
								{
									text5 = "bag";
								}
								if (text5.Length != 0)
								{
									this.BBGJMGMHJPP("SAMPLES_LOW" + text5);
								}
							}
							else
							{
								Debug.LogError("Near");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.CFPNCEFOIAN(stringBuilder.ToString());
			this.LEMDHBOFKLO();
		}

		// Token: 0x0600588E RID: 22670 RVA: 0x002A1C40 File Offset: 0x0029FE40
		private void BNFIJCEKEBL(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("error");
			HBFECCBOEMN = "1 Hand Sword" + HBFECCBOEMN + "Water";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(1, HBFECCBOEMN);
				return;
			}
			int num = this.JEPBCFCBPEL.Length - this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
			{
				'1'
			}).Length;
			if (num != 0)
			{
				string text = this.JEPBCFCBPEL.ToString();
				char[] array = new char[0];
				array[0] = (char)-99;
				string value = text.TrimEnd(array);
				this.JEPBCFCBPEL.Length = 1;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.MBBNMNMFALI() * (float)num;
				object[] array2 = new object[8];
				array2[0] = "PersonWomanFisher";
				array2[0] = num2;
				array2[6] = "{0}Textures/Shop/{1}.png";
				array2[2] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array2);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x0600588F RID: 22671 RVA: 0x002A1D30 File Offset: 0x0029FF30
		private bool CDKPKJAAIEO(string LNEADABFMGK)
		{
			bool result = true;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == "WeaponReady") ? this.MEIKDANAJGK() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.JLOHPGBHOKA();
					result = true;
					string text = LNEADABFMGK;
					char[] array = new char[0];
					array[1] = 'h';
					LNEADABFMGK = text.TrimStart(array);
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x002A1DF0 File Offset: 0x0029FFF0
		private void EJIDBALNMEN(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("sunshine_Lightmap");
			HBFECCBOEMN = "Right" + HBFECCBOEMN + "crft_crft";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(1, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[0];
			array[0] = 'u';
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string text2 = this.JEPBCFCBPEL.ToString();
				char[] array2 = new char[0];
				array2[1] = (char)-1;
				string value = text2.TrimEnd(array2);
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.MEIKDANAJGK() * (float)num;
				object[] array3 = new object[5];
				array3[1] = "******* playMusicBase  LocNewLogic";
				array3[1] = num2;
				array3[6] = "[X]";
				array3[0] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array3);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x002A1EE0 File Offset: 0x002A00E0
		private void JALEFBKGCPK(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "RollerBladeSkateFwd".Replace("1HandSwordStrafeLeft", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("_BlurRadius4", newValue);
				this.DDENOLFFBNI = 191f;
				return;
			}
			this.JEPBCFCBPEL.Append("IKMappingSpine is missing the right thigh bone.");
		}

		// Token: 0x06005892 RID: 22674 RVA: 0x002A1F3C File Offset: 0x002A013C
		private float JPGPJCNBEIO()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("<color='#60e0ff'>")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("MotorbikeTurnRight")).x - x;
		}

		// Token: 0x06005893 RID: 22675 RVA: 0x002A1F80 File Offset: 0x002A0180
		private bool GCHPKJELKLB(string LNEADABFMGK)
		{
			bool result = true;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == "ui_default_click.wav") ? this.DKAADEBJADA() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.KIKKDLHPPMB();
					result = false;
					string text = LNEADABFMGK;
					char[] array = new char[1];
					array[1] = (char)-119;
					LNEADABFMGK = text.TrimStart(array);
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x06005894 RID: 22676 RVA: 0x002A2040 File Offset: 0x002A0240
		private float GFJCGLPMDPI()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("fwgt_uniq_w")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("W")).x - x;
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x002A2084 File Offset: 0x002A0284
		private void CGLEGHOMJMC(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.HDPBGODGNEC(false);
			this.EMKALNJHCLE = 288f;
			this.DDENOLFFBNI = 1454f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < FPIHOPOCAHA.Length; i += 0)
			{
				int num;
				if (FPIHOPOCAHA[i] == '8' && FPIHOPOCAHA.Length > i + 1 && (int)FPIHOPOCAHA[i + 1] == -126)
				{
					stringBuilder.Append("_History1LumaTex");
					i++;
				}
				else if ((int)FPIHOPOCAHA[i] == -42)
				{
					this.GCHPKJELKLB(stringBuilder.ToString());
					this.JLOHPGBHOKA();
					stringBuilder.Length = 1;
				}
				else if (FPIHOPOCAHA[i] == 'q' && stringBuilder.Length != 0)
				{
					this.BDPDCGGCCNM(stringBuilder.ToString());
					stringBuilder.Length = 0;
					stringBuilder.Append((char)-64);
				}
				else if (FPIHOPOCAHA[i] == '\u0019' && FPIHOPOCAHA.Length > i + 0 && FPIHOPOCAHA[i + 0] == '\u0010')
				{
					stringBuilder.Append("_History1Weight");
					i += 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -75 && FPIHOPOCAHA.Length > i + 1 && (num = FPIHOPOCAHA.IndexOf((char)-101, i)) != -1)
				{
					this.DDGEKHJDJOL(stringBuilder.ToString());
					stringBuilder.Length = 0;
					string text = FPIHOPOCAHA.Substring(i + 0, num - i - 0);
					i += text.Length + 1;
					string text2 = text;
					char[] array = new char[1];
					array[1] = (char)-74;
					string[] array2 = text2.Split(array);
					for (int j = 0; j < array2.Length; j++)
					{
						text = array2[j].ToUpper();
						if (text == "SAMPLES_LOW" || text == "IdleSlide")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								Color color;
								if (array2[j] == "Loot" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color))
								{
									this.BJEDLEEFLEB("_AdditiveReflection" + array2[j]);
								}
								else
								{
									Debug.LogError("WateringCan");
								}
							}
							else
							{
								Debug.LogError("IceHockeyShotRight");
							}
						}
						else if (text == ": " || text == "WATER_VERTEX_DISPLACEMENT_ON")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								Color color2;
								if (array2[j] == "" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color2))
								{
									this.MCNCFBHJGBB("WallRunRight" + array2[j]);
								}
								else
								{
									Debug.LogError("QTask.xml");
								}
							}
							else
							{
								Debug.LogError("ProneLocomotion" + FPIHOPOCAHA);
							}
						}
						else if (text == "Yawn" || text == "Mouse ScrollWheel")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								Font font = (Font)Resources.Load("BowIdle" + array2[j]);
								if (font == null)
								{
									Debug.LogError("_Refraction" + array2[j] + "RollerBladeTurnLeft");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.MCNCFBHJGBB("ZombieIdle2" + array2[j]);
								}
								if (array2.Length > j + 0)
								{
									j++;
									int fontSize;
									if (int.TryParse(array2[j], out fontSize))
									{
										this.IMHPEFJJIAJ("level" + array2[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("error.wav" + array2[j] + "GrounderIK does not support AimIK, use CCDIK, FABRIK, LimbIK or TrigonometricIK instead.");
									}
								}
							}
							else
							{
								Debug.LogError(" r ");
							}
						}
						else if (text == "♼ " || text == "Transparent/Diffuse")
						{
							if (array2.Length > j + 0)
							{
								j++;
								string text3 = array2[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text3);
								if (num2 <= 33U)
								{
									if (num2 <= 71U)
									{
										if (num2 != 4294967243U)
										{
											if (num2 != 131U)
											{
												goto IL_50B;
											}
											if (!(text3 == "\n"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text3 == "\n}"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 4294967280U)
									{
										if (num2 != 28U)
										{
											goto IL_50B;
										}
										if (!(text3 == "▮▮▯"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == ""))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text3 = "1HandSwordJabFootPush";
								}
								else
								{
									if (num2 <= 183U)
									{
										if (num2 != 4294967284U)
										{
											if (num2 != 4294967282U)
											{
												goto IL_50B;
											}
											if (!(text3 == "error"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text3 == "SoccerSprint"))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 4294967203U)
									{
										if (num2 != 6U)
										{
											goto IL_50B;
										}
										if (!(text3 == "colorD"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "Internal LUT"))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text3 = "LUM_CONTRIB_OFF";
								}
								IL_51C:
								if (text3.Length != 0)
								{
									this.JNOJDHGEEKH(" " + text3);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text3 = "http://www.root-motion.com/finalikdox/html/page7.html";
								Debug.LogError("OneHandSwordReady");
								goto IL_51C;
								IL_4F0:
								text3 = "Katana";
								goto IL_51C;
								IL_4E7:
								text3 = "Depth textures aren't supported on this device ({0})";
								goto IL_51C;
							}
							Debug.LogError("_TapMedium");
						}
						else if (text == "cht_msg15" || text == "UpHillWalk")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								int fontSize2;
								if (int.TryParse(array2[j], out fontSize2))
								{
									this.JJKMFNEDHHL("" + array2[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("Tops" + array2[j] + "http://www.root-motion.com/finalikdox/html/page11.html");
								}
							}
							else
							{
								Debug.LogError("eat2.ogg");
							}
						}
						else if (text == "Clear all entries" || text == "Vertical")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								this.MAPLLADKCON("wpn_bait1" + array2[j]);
							}
							else
							{
								Debug.LogError("forFishes");
							}
						}
						else if (text == "targetColor" || text == "act_prof_{0}")
						{
							this.GOKJENBLLPH("https://groups.google.com/forum/#!forum/final-ik");
						}
						else if (text == "PaperTurn.wav" || text == "BaseLogic")
						{
							if (array2.Length > j + 0)
							{
								j++;
								string text4 = array2[j].ToUpper();
								if (!(text4 == "DITHERING") && !(text4 == "Soccer Pass Light"))
								{
									if (!(text4 == "RollerBladeTurnLeft") && !(text4 == " This is not possible to be called for standalone input. Please check your platform and code where this is called"))
									{
										if (!(text4 == "OfficeSittingHandRestFingerTap") && !(text4 == "crft_selwpn"))
										{
											text4 = "";
											Debug.LogError("<color='#400000'>");
										}
										else
										{
											text4 = "\nу вас есть ";
										}
									}
									else
									{
										text4 = "WizardOverhead";
									}
								}
								else
								{
									text4 = "------------------------------------------------------";
								}
								if (text4.Length != 0)
								{
									this.IBKBAELMCEL("" + text4);
								}
							}
							else
							{
								Debug.LogError("offsets");
							}
						}
						else if (text == "ShotgunReloadChamber" || text == "FlyBackward")
						{
							if (array2.Length > j + 1)
							{
								j++;
								int num3;
								if (int.TryParse(array2[j], out num3))
								{
									this.PLJJCFOFGKE("Attempting to set limb orientation to Vector3.zero axis" + array2[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("Smoking2" + array2[j] + "***My Lots event ");
								}
							}
							else
							{
								Debug.LogError("<color='#405000'>");
							}
						}
						else if (text == "error.wav" || text == "{0}, {1}, {2}")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								string text5 = array2[j].ToUpper();
								if (!(text5 == "gi_uinf_1i"))
								{
									if (!(text5 == "wpn_eat1") && !(text5 == ""))
									{
										text5 = "Sun Light was not configured, and couldn't find appropriate Direction Light...";
										Debug.LogError("Tangents");
									}
									else
									{
										text5 = "SatNightFever";
									}
								}
								else
								{
									text5 = "_FogScatteringData2";
								}
								if (text5.Length != 0)
								{
									this.MCNCFBHJGBB("WizardEyeBeam" + text5);
								}
							}
							else
							{
								Debug.LogError("ObscuredByte:");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.ANJJOBCAENJ(stringBuilder.ToString());
			this.BKFDICKFJHM();
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x002A295C File Offset: 0x002A0B5C
		private float LINILIMFBMF()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("Invalid ObscuredVector2 index!")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("Fly Down")).x - x;
		}

		// Token: 0x06005897 RID: 22679 RVA: 0x002A29A0 File Offset: 0x002A0BA0
		private void OKLEIFMEHFI()
		{
			if (this.JEPBCFCBPEL.ToString() == "Vertical")
			{
				this.JEPBCFCBPEL.Append("Bases/Base_1.unity3d");
			}
			this.JALEFBKGCPK(false);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x06005898 RID: 22680 RVA: 0x002A29F4 File Offset: 0x002A0BF4
		private void CPBCJKEAPLG(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.FAIAHFOOEKE(false);
			this.EMKALNJHCLE = 306f;
			this.DDENOLFFBNI = 1358f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < FPIHOPOCAHA.Length; i++)
			{
				int num;
				if ((int)FPIHOPOCAHA[i] == -88 && FPIHOPOCAHA.Length > i + 1 && (int)FPIHOPOCAHA[i + 1] == -121)
				{
					stringBuilder.Append("cht_msg10");
					i += 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -33)
				{
					this.GOIAECNFKLE(stringBuilder.ToString());
					this.BKJHOGMDKMC();
					stringBuilder.Length = 1;
				}
				else if (FPIHOPOCAHA[i] == '\u0019' && stringBuilder.Length != 0)
				{
					this.DLPCEKMALFB(stringBuilder.ToString());
					stringBuilder.Length = 1;
					stringBuilder.Append((char)-91);
				}
				else if ((int)FPIHOPOCAHA[i] == -35 && FPIHOPOCAHA.Length > i + 1 && FPIHOPOCAHA[i + 0] == '\u0001')
				{
					stringBuilder.Append("SUNSHINE_TWO_CASCADES");
					i++;
				}
				else if ((int)FPIHOPOCAHA[i] == -98 && FPIHOPOCAHA.Length > i + 1 && (num = FPIHOPOCAHA.IndexOf('\r', i)) != -1)
				{
					this.CDKPKJAAIEO(stringBuilder.ToString());
					stringBuilder.Length = 0;
					string text = FPIHOPOCAHA.Substring(i + 0, num - i - 0);
					i += text.Length + 1;
					string[] array = text.Split(new char[]
					{
						(char)-124
					});
					for (int j = 1; j < array.Length; j++)
					{
						text = array[j].ToUpper();
						if (text == "UnityEngine.Vector3" || text == "\n")
						{
							if (array.Length > j + 1)
							{
								j += 0;
								Color color;
								if (array[j] == "</color>" || BKLBFBELDGL.JMGMHLCELLF(array[j], out color))
								{
									this.MHIMHDGOFNC("+{0}" + array[j]);
								}
								else
								{
									Debug.LogError("_ReflectionBlur");
								}
							}
							else
							{
								Debug.LogError("");
							}
						}
						else if (text == "1" || text == "{0:F2}, {1:F2}, {2:F2}, {3:F2}")
						{
							if (array.Length > j + 1)
							{
								j++;
								Color color2;
								if (array[j] == "" || BKLBFBELDGL.JMGMHLCELLF(array[j], out color2))
								{
									this.PLJJCFOFGKE("Fishing" + array[j]);
								}
								else
								{
									Debug.LogError("Idle180");
								}
							}
							else
							{
								Debug.LogError("27" + FPIHOPOCAHA);
							}
						}
						else if (text == "name" || text == "Initiating IKSolver with null root Transform.")
						{
							if (array.Length > j + 1)
							{
								j++;
								Font font = (Font)Resources.Load("_FogPointLightPosition" + array[j]);
								if (font == null)
								{
									Debug.LogError("ShotgunReloadMagazine" + array[j] + "Atmosphere reference not set.");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.GMGMDGODGCO("MotorbikeWheely" + array[j]);
								}
								if (array.Length > j + 0)
								{
									j += 0;
									int fontSize;
									if (int.TryParse(array[j], out fontSize))
									{
										this.FGJFINIJPMI("craft/stanok" + array[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("Roar" + array[j] + "WizardPowerUp");
									}
								}
							}
							else
							{
								Debug.LogError("Backward Sitting Cheer");
							}
						}
						else if (text == "inv_wpers" || text == "buykey")
						{
							if (array.Length > j + 0)
							{
								j++;
								string text2 = array[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text2);
								if (num2 <= 136U)
								{
									if (num2 <= 157U)
									{
										if (num2 != 124U)
										{
											if (num2 != 123U)
											{
												goto IL_50B;
											}
											if (!(text2 == "#02C85F"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text2 == "WeaponReadyFire"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 168U)
									{
										if (num2 != 4294967239U)
										{
											goto IL_50B;
										}
										if (!(text2 == "wtype"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text2 == "null"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text2 = " ";
								}
								else
								{
									if (num2 <= 4294967237U)
									{
										if (num2 != 197U)
										{
											if (num2 != 60U)
											{
												goto IL_50B;
											}
											if (!(text2 == "non MonoBehaviour"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text2 == "act_orderb_0"))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 184U)
									{
										if (num2 != 4294967290U)
										{
											goto IL_50B;
										}
										if (!(text2 == "cntx_teach"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text2 == "Katana45DegSwing"))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text2 = "_Radius2";
								}
								IL_51C:
								if (text2.Length != 0)
								{
									this.MCNCFBHJGBB("bs_cost" + text2);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text2 = "category";
								Debug.LogError(",");
								goto IL_51C;
								IL_4F0:
								text2 = "_History2Weight";
								goto IL_51C;
								IL_4E7:
								text2 = "Smoking1";
								goto IL_51C;
							}
							Debug.LogError("IK Effector contains a null reference.");
						}
						else if (text == "_FogColor" || text == "Clear reference not set.")
						{
							if (array.Length > j + 1)
							{
								j += 0;
								int fontSize2;
								if (int.TryParse(array[j], out fontSize2))
								{
									this.BNAOGCBCOGK("SatNightFever" + array[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("_1.png" + array[j] + "null");
								}
							}
							else
							{
								Debug.LogError("[Attachments] Failed to find MeshFilter on the attachments object '{0}'.");
							}
						}
						else if (text == "[Attachments] Failed to find MeshFilter on the attachments object '{0}'." || text == "ZombieIdle2")
						{
							if (array.Length > j + 1)
							{
								j++;
								this.EJIDBALNMEN("" + array[j]);
							}
							else
							{
								Debug.LogError("Flap_08.wav");
							}
						}
						else if (text == "WATER_VERTEX_DISPLACEMENT_ON" || text == "S")
						{
							this.JBNJLJEELLN("isWoman");
						}
						else if (text == "qd_tasktime" || text == "MotorbikeBackwardSitting")
						{
							if (array.Length > j + 0)
							{
								j += 0;
								string text3 = array[j].ToUpper();
								if (!(text3 == "OfficeSittingMouseMovement") && !(text3 == "error"))
								{
									if (!(text3 == "Prone Idle") && !(text3 == "ankle"))
									{
										if (!(text3 == "HookPoint") && !(text3 == "ApplePick"))
										{
											text3 = "WeaponReady";
											Debug.LogError("Jump");
										}
										else
										{
											text3 = "\n";
										}
									}
									else
									{
										text3 = "USE_MASK";
									}
								}
								else
								{
									text3 = "aa=";
								}
								if (text3.Length != 0)
								{
									this.BAIPLCGIBEM("****** locid=" + text3);
								}
							}
							else
							{
								Debug.LogError("teech_perk");
							}
						}
						else if (text == "Apply 10" || text == "qd_taskcount")
						{
							if (array.Length > j + 0)
							{
								j++;
								int num3;
								if (int.TryParse(array[j], out num3))
								{
									this.GMGMDGODGCO(" гр " + array[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("ok" + array[j] + "JumpCurve");
								}
							}
							else
							{
								Debug.LogError("Idle Drink");
							}
						}
						else if (text == "loc" || text == "Assets/Heads/head_")
						{
							if (array.Length > j + 0)
							{
								j++;
								string text4 = array[j].ToUpper();
								if (!(text4 == "FS "))
								{
									if (!(text4 == "error") && !(text4 == "CrawlLocomotion"))
									{
										text4 = "_DebugWidth";
										Debug.LogError("M");
									}
									else
									{
										text4 = "Office";
									}
								}
								else
								{
									text4 = "CrouchWalk";
								}
								if (text4.Length != 0)
								{
									this.GMGMDGODGCO("RollerBladeFrontFlip" + text4);
								}
							}
							else
							{
								Debug.LogError("#2080ff");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.CDKPKJAAIEO(stringBuilder.ToString());
			this.EGGPNKBFINJ();
		}

		// Token: 0x06005899 RID: 22681 RVA: 0x002A32CC File Offset: 0x002A14CC
		private bool DDGEKHJDJOL(string LNEADABFMGK)
		{
			bool result = false;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == "inv_post") ? this.LINILIMFBMF() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.BKJHOGMDKMC();
					result = false;
					string text = LNEADABFMGK;
					char[] array = new char[0];
					array[0] = 'n';
					LNEADABFMGK = text.TrimStart(array);
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x002A338C File Offset: 0x002A158C
		private bool DOJJLLNOLGD(string LNEADABFMGK)
		{
			bool result = true;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == "donk.ogg") ? this.MBBNMNMFALI() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.EOGFKNCHJOD();
					result = true;
					string text = LNEADABFMGK;
					char[] array = new char[0];
					array[0] = '0';
					LNEADABFMGK = text.TrimStart(array);
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x002A3449 File Offset: 0x002A1649
		private void MPEHLDHLDON()
		{
			this.OKLEIFMEHFI();
			this.JEPBCFCBPEL.Length = 0;
			this.JALEFBKGCPK(true);
			this.EMKALNJHCLE = 339f;
		}

		// Token: 0x0600589C RID: 22684 RVA: 0x002A3470 File Offset: 0x002A1670
		private void DAAFLMNKMJF(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "TOD_CloudColor".Replace("t_beard", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("GestureChestPumpSalute", newValue);
				this.DDENOLFFBNI = 1129f;
				return;
			}
			this.JEPBCFCBPEL.Append("Transparent/Diffuse");
		}

		// Token: 0x0600589D RID: 22685 RVA: 0x002A34CC File Offset: 0x002A16CC
		private void PLJJCFOFGKE(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith(" length is zero, can not solve.");
			HBFECCBOEMN = "***Lots " + HBFECCBOEMN + "usrfrom_ignor";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(1, HBFECCBOEMN);
				return;
			}
			int num = this.JEPBCFCBPEL.Length - this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
			{
				(char)-66
			}).Length;
			if (num != 0)
			{
				string text = this.JEPBCFCBPEL.ToString();
				char[] array = new char[0];
				array[0] = 'm';
				string value = text.TrimEnd(array);
				this.JEPBCFCBPEL.Length = 1;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.LINILIMFBMF() * (float)num;
				object[] array2 = new object[5];
				array2[0] = "leg";
				array2[1] = num2;
				array2[2] = "shop_t6";
				array2[5] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array2);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x0600589E RID: 22686 RVA: 0x002A35BC File Offset: 0x002A17BC
		private void JJKMFNEDHHL(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("knopje.wav");
			HBFECCBOEMN = "<color='#{0}'>{1} {3} {2} </color>\n" + HBFECCBOEMN + "InterfaceLang.txt";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(1, HBFECCBOEMN);
				return;
			}
			int num = this.JEPBCFCBPEL.Length - this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
			{
				'|'
			}).Length;
			if (num != 0)
			{
				string text = this.JEPBCFCBPEL.ToString();
				char[] array = new char[0];
				array[1] = 'T';
				string value = text.TrimEnd(array);
				this.JEPBCFCBPEL.Length = 1;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.ADPANHALPJN() * (float)num;
				object[] array2 = new object[1];
				array2[0] = "x{0} {1}\n";
				array2[1] = num2;
				array2[6] = "QUEST CMD ";
				array2[7] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array2);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x0600589F RID: 22687 RVA: 0x002A36AC File Offset: 0x002A18AC
		private void IIMMFKJAOMP(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "RollerBladeCrossoverLeft".Replace("wpn_eat7", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("UNITY_COLORSPACE_GAMMA", newValue);
				this.DDENOLFFBNI = 606f;
				return;
			}
			this.JEPBCFCBPEL.Append("FOG_OFF");
		}

		// Token: 0x060058A0 RID: 22688 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> LDKLNNABNBA()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x060058A1 RID: 22689 RVA: 0x002A3708 File Offset: 0x002A1908
		private float BGHJNJIOHGI()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("invn_rec21")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("System.Boolean")).x - x;
		}

		// Token: 0x060058A2 RID: 22690 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> MAGOAHENALJ()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x002A374C File Offset: 0x002A194C
		private void DCIBOPMHGJE()
		{
			this.MNNGDJOAFID();
			this.JEPBCFCBPEL.Length = 0;
			this.MDCPDMEOAFO(false);
			this.EMKALNJHCLE = 985f;
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x002A3772 File Offset: 0x002A1972
		private void KIKKDLHPPMB()
		{
			this.KPGKJKIAGIE();
			this.JEPBCFCBPEL.Length = 1;
			this.MDCPDMEOAFO(true);
			this.EMKALNJHCLE = 1397f;
		}

		// Token: 0x060058A5 RID: 22693 RVA: 0x002A3798 File Offset: 0x002A1998
		private void GDJMNCNJEBN(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "_ReflectionTexture1".Replace("Z (B)", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("Name: ", newValue);
				this.DDENOLFFBNI = 388f;
				return;
			}
			this.JEPBCFCBPEL.Append("Biped");
		}

		// Token: 0x060058A6 RID: 22694 RVA: 0x002A37F4 File Offset: 0x002A19F4
		private void CGCHDEKKLBD(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.FAIAHFOOEKE(false);
			this.EMKALNJHCLE = 203f;
			this.DDENOLFFBNI = 569f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < FPIHOPOCAHA.Length; i++)
			{
				int num;
				if ((int)FPIHOPOCAHA[i] == -76 && FPIHOPOCAHA.Length > i + 1 && FPIHOPOCAHA[i + 0] == '2')
				{
					stringBuilder.Append("Katana Ready High");
					i++;
				}
				else if ((int)FPIHOPOCAHA[i] == -22)
				{
					this.DDGEKHJDJOL(stringBuilder.ToString());
					this.EOGFKNCHJOD();
					stringBuilder.Length = 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -14 && stringBuilder.Length != 0)
				{
					this.CFPNCEFOIAN(stringBuilder.ToString());
					stringBuilder.Length = 1;
					stringBuilder.Append('\u0014');
				}
				else if (FPIHOPOCAHA[i] == '~' && FPIHOPOCAHA.Length > i + 0 && FPIHOPOCAHA[i + 0] == '\u001d')
				{
					stringBuilder.Append("UpHillWalkHandGrab");
					i += 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -12 && FPIHOPOCAHA.Length > i + 0 && (num = FPIHOPOCAHA.IndexOf((char)-90, i)) != -1)
				{
					this.CDKPKJAAIEO(stringBuilder.ToString());
					stringBuilder.Length = 0;
					string text = FPIHOPOCAHA.Substring(i + 1, num - i - 1);
					i += text.Length + 1;
					string text2 = text;
					char[] array = new char[0];
					array[0] = (char)-66;
					string[] array2 = text2.Split(array);
					for (int j = 0; j < array2.Length; j += 0)
					{
						text = array2[j].ToUpper();
						if (text == "MENU.WAV" || text == "FlyDown")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Color color;
								if (array2[j] == "_Intensity" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color))
								{
									this.IADJMONCMFE("clavicle" + array2[j]);
								}
								else
								{
									Debug.LogError("reel_type2");
								}
							}
							else
							{
								Debug.LogError("Keeper Strafe Left");
							}
						}
						else if (text == "" || text == "titul_data/tituls/titul")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								Color color2;
								if (array2[j] == "Katana45DegSwing" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color2))
								{
									this.IBKBAELMCEL("Hidden/SESSAO" + array2[j]);
								}
								else
								{
									Debug.LogError("_EdgeThreshold");
								}
							}
							else
							{
								Debug.LogError("Hidden/DepthOfField/DepthOfField" + FPIHOPOCAHA);
							}
						}
						else if (text == "Foot" || text == "_History3ChromaTex")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Font font = (Font)Resources.Load("WATER_SIMPLE" + array2[j]);
								if (font == null)
								{
									Debug.LogError("demoVector2" + array2[j] + "Clear Screen");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.MCNCFBHJGBB(" " + array2[j]);
								}
								if (array2.Length > j + 1)
								{
									j += 0;
									int fontSize;
									if (int.TryParse(array2[j], out fontSize))
									{
										this.EJIDBALNMEN("MotorbikeBackwardSittingCheer" + array2[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("IdleStun" + array2[j] + "wpn_add/base");
									}
								}
							}
							else
							{
								Debug.LogError("часов");
							}
						}
						else if (text == "Blank Overcast Texture Missing..." || text == "ok")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								string text3 = array2[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text3);
								if (num2 <= 24U)
								{
									if (num2 <= 4294967176U)
									{
										if (num2 != 4294967154U)
										{
											if (num2 != 190U)
											{
												goto IL_50B;
											}
											if (!(text3 == ","))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text3 == "_Parameter"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 4294967182U)
									{
										if (num2 != 4294967236U)
										{
											goto IL_50B;
										}
										if (!(text3 == "?"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "FlyForward"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text3 = "Ошибка: ";
								}
								else
								{
									if (num2 <= 4294967125U)
									{
										if (num2 != 11U)
										{
											if (num2 != 42U)
											{
												goto IL_50B;
											}
											if (!(text3 == "heart.wav"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text3 == "_ScaleOffsetRes"))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 121U)
									{
										if (num2 != 89U)
										{
											goto IL_50B;
										}
										if (!(text3 == "txt"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "Antares Console"))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text3 = "[fish]";
								}
								IL_51C:
								if (text3.Length != 0)
								{
									this.MHIMHDGOFNC("fshop_hd1" + text3);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text3 = "_DepthOfFieldTex";
								Debug.LogError("_LensCoeff");
								goto IL_51C;
								IL_4F0:
								text3 = "' is not a valid integer";
								goto IL_51C;
								IL_4E7:
								text3 = "8 samples";
								goto IL_51C;
							}
							Debug.LogError("");
						}
						else if (text == "ProneIdle" || text == "autherror")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								int fontSize2;
								if (int.TryParse(array2[j], out fontSize2))
								{
									this.GOKJENBLLPH("ApplePick" + array2[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("Calf" + array2[j] + "Try Goscurry! Or better buy it!");
								}
							}
							else
							{
								Debug.LogError("Joint_");
							}
						}
						else if (text == "" || text == "No location found baseid=")
						{
							if (array2.Length > j + 1)
							{
								j++;
								this.MNBGBBKAEAC("WizardOverhead" + array2[j]);
							}
							else
							{
								Debug.LogError("The root node, the left thigh and the right thigh bones should ideally form a triangle that is as close to equilateral as possible. Currently the root node bone seems to be very close to the line between the left thigh and the right thigh bones. This might cause unwanted behaviour like the hip turning upside down when pulled by an effector.Please set the root node bone to be one of the higher bones in the spine.");
							}
						}
						else if (text == "MotorbikeBackwardSitting" || text == "wpn_popl1")
						{
							this.MCNCFBHJGBB("GiantGrabIdle");
						}
						else if (text == "Bip" || text == "_TrNewLider.ogg")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								string text4 = array2[j].ToUpper();
								if (!(text4 == "Worker Pickaxe") && !(text4 == "fider_big_"))
								{
									if (!(text4 == "AC_TONEMAPPING") && !(text4 == "_WorldToCameraMatrix"))
									{
										if (!(text4 == "https://groups.google.com/forum/#!forum/final-ik") && !(text4 == "HeelClick"))
										{
											text4 = "WalkBackward";
											Debug.LogError("Mouse X");
										}
										else
										{
											text4 = "FBBIKSettings is deprecated, you can now edit all the settings from the custom inspector of the FullBodyBipedIK component.";
										}
									}
									else
									{
										text4 = "";
									}
								}
								else
								{
									text4 = "repair.ogg";
								}
								if (text4.Length != 0)
								{
									this.MAPLLADKCON("" + text4);
								}
							}
							else
							{
								Debug.LogError("_Intensity");
							}
						}
						else if (text == "RGBA(" || text == "Jump")
						{
							if (array2.Length > j + 1)
							{
								j++;
								int num3;
								if (int.TryParse(array2[j], out num3))
								{
									this.MAPLLADKCON("autherror" + array2[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("MotorbikeHandlebarSit" + array2[j] + "System.Boolean");
								}
							}
							else
							{
								Debug.LogError("FlyRight");
							}
						}
						else if (text == "componentA=" || text == "CP3")
						{
							if (array2.Length > j + 1)
							{
								j++;
								string text5 = array2[j].ToUpper();
								if (!(text5 == "<color='#000000'>{0}</color>"))
								{
									if (!(text5 == "isWoman") && !(text5 == "TOD_kRadius"))
									{
										text5 = "31";
										Debug.LogError("PistolLeftHandStab");
									}
									else
									{
										text5 = "1HandSwordChargeUp";
									}
								}
								else
								{
									text5 = "isRodOpen";
								}
								if (text5.Length != 0)
								{
									this.JLHBCFIFKLF("rait_4" + text5);
								}
							}
							else
							{
								Debug.LogError("RollerBladeGrindRoyale");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.CFPNCEFOIAN(stringBuilder.ToString());
			this.JENMDAEMLIO();
		}

		// Token: 0x060058A7 RID: 22695 RVA: 0x002A40CC File Offset: 0x002A22CC
		private void KGPCKBOFDCD(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("CP0");
			HBFECCBOEMN = "human_move_2.wav" + HBFECCBOEMN + "RollerBladeCrossoverRight";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(1, HBFECCBOEMN);
				return;
			}
			int num = this.JEPBCFCBPEL.Length - this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
			{
				(char)-41
			}).Length;
			if (num != 0)
			{
				string text = this.JEPBCFCBPEL.ToString();
				char[] array = new char[0];
				array[0] = '-';
				string value = text.TrimEnd(array);
				this.JEPBCFCBPEL.Length = 1;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.MEIKDANAJGK() * (float)num;
				object[] array2 = new object[4];
				array2[0] = "ClimbIdle";
				array2[1] = num2;
				array2[6] = "_Offsets";
				array2[3] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array2);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x002A41BC File Offset: 0x002A23BC
		private float KMPIPBJCIFI()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("MotorbikeHeartAttack")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("_WrinkleMapBumpScales")).x - x;
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x002A4200 File Offset: 0x002A2400
		private void JPIGCEBKLEF(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.MIKKJNFEBHO(true);
			this.EMKALNJHCLE = 1633f;
			this.DDENOLFFBNI = 621f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < FPIHOPOCAHA.Length; i++)
			{
				int num;
				if ((int)FPIHOPOCAHA[i] == -77 && FPIHOPOCAHA.Length > i + 0 && FPIHOPOCAHA[i + 0] == '\r')
				{
					stringBuilder.Append(" x");
					i += 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -118)
				{
					this.ANJJOBCAENJ(stringBuilder.ToString());
					this.NGHAFABJDKH();
					stringBuilder.Length = 0;
				}
				else if (FPIHOPOCAHA[i] == '1' && stringBuilder.Length != 0)
				{
					this.DLPCEKMALFB(stringBuilder.ToString());
					stringBuilder.Length = 1;
					stringBuilder.Append('I');
				}
				else if ((int)FPIHOPOCAHA[i] == -89 && FPIHOPOCAHA.Length > i + 0 && (int)FPIHOPOCAHA[i + 0] == -111)
				{
					stringBuilder.Append("1,2,3,4,5");
					i += 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -52 && FPIHOPOCAHA.Length > i + 0 && (num = FPIHOPOCAHA.IndexOf('\u000f', i)) != -1)
				{
					this.CDKPKJAAIEO(stringBuilder.ToString());
					stringBuilder.Length = 0;
					string text = FPIHOPOCAHA.Substring(i + 0, num - i - 0);
					i += text.Length + 0;
					string text2 = text;
					char[] array = new char[1];
					array[1] = (char)-24;
					string[] array2 = text2.Split(array);
					for (int j = 0; j < array2.Length; j++)
					{
						text = array2[j].ToUpper();
						if (text == "IdleKeepBack" || text == "IK Effector is referencing to a bone '")
						{
							if (array2.Length > j + 0)
							{
								j++;
								Color color;
								if (array2[j] == "- none -" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color))
								{
									this.IADJMONCMFE("IdleFight" + array2[j]);
								}
								else
								{
									Debug.LogError("gameComplete");
								}
							}
							else
							{
								Debug.LogError("IdleMouthWipe");
							}
						}
						else if (text == "demoLong" || text == "_Transparency")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								Color color2;
								if (array2[j] == "" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color2))
								{
									this.MNBGBBKAEAC("0+100" + array2[j]);
								}
								else
								{
									Debug.LogError("_LerpAmount");
								}
							}
							else
							{
								Debug.LogError("Cheer Knees" + FPIHOPOCAHA);
							}
						}
						else if (text == "offsets" || text == "OfficeSittingBack")
						{
							if (array2.Length > j + 0)
							{
								j++;
								Font font = (Font)Resources.Load("byte[]: {" + array2[j]);
								if (font == null)
								{
									Debug.LogError("OnChatMessage" + array2[j] + "OfficeSitting");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.PLJJCFOFGKE("Crouch180" + array2[j]);
								}
								if (array2.Length > j + 1)
								{
									j++;
									int fontSize;
									if (int.TryParse(array2[j], out fontSize))
									{
										this.BBGJMGMHJPP("BC" + array2[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("CheerJump" + array2[j] + "Eyelashes");
									}
								}
							}
							else
							{
								Debug.LogError("SoccerKeeperDiveStrafeFarLeft");
							}
						}
						else if (text == "Apply 6" || text == "repair.ogg")
						{
							if (array2.Length > j + 1)
							{
								j++;
								string text3 = array2[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text3);
								if (num2 <= 168U)
								{
									if (num2 <= 126U)
									{
										if (num2 != 24U)
										{
											if (num2 != 165U)
											{
												goto IL_50B;
											}
											if (!(text3 == "Try Goscurry! Or better buy it!"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text3 == "http://www.root-motion.com/finalikdox/html/page2.html"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 4294967281U)
									{
										if (num2 != 4294967104U)
										{
											goto IL_50B;
										}
										if (!(text3 == "_Blur"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "Arm Flex 2"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text3 = "Move";
								}
								else
								{
									if (num2 <= 4294967146U)
									{
										if (num2 != 161U)
										{
											if (num2 != 4294967238U)
											{
												goto IL_50B;
											}
											if (!(text3 == "SoccerRun"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text3 == "CheerJump"))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 4294967125U)
									{
										if (num2 != 196U)
										{
											goto IL_50B;
										}
										if (!(text3 == "SatNightFever"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "get 1401 cmd"))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text3 = "name";
								}
								IL_51C:
								if (text3.Length != 0)
								{
									this.BNFIJCEKEBL("Hidden/Post FX/Temporal Anti-aliasing" + text3);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text3 = "ankle";
								Debug.LogError("StrafeRunLeft");
								goto IL_51C;
								IL_4F0:
								text3 = "Wizard2HandThrow";
								goto IL_51C;
								IL_4E7:
								text3 = "https://groups.google.com/forum/#!forum/final-ik";
								goto IL_51C;
							}
							Debug.LogError(" path=");
						}
						else if (text == "eye" || text == "wpn_add/addoptions")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								int fontSize2;
								if (int.TryParse(array2[j], out fontSize2))
								{
									this.BNAOGCBCOGK("_Offsets" + array2[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("BC" + array2[j] + "MENU.WAV");
								}
							}
							else
							{
								Debug.LogError("\n");
							}
						}
						else if (text == "OneHandSwordBlock" || text == "")
						{
							if (array2.Length > j + 1)
							{
								j++;
								this.BNAOGCBCOGK("Dealer Shuffle" + array2[j]);
							}
							else
							{
								Debug.LogError("\n");
							}
						}
						else if (text == "Face Hit" || text == "IdleSpew")
						{
							this.GMGMDGODGCO("Wheely");
						}
						else if (text == "OneHandSwordSwing" || text == "_RgbTex")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								string text4 = array2[j].ToUpper();
								if (!(text4 == "Weapon Ready Fire") && !(text4 == "auk_pbuykey"))
								{
									if (!(text4 == "Y") && !(text4 == "_Offset"))
									{
										if (!(text4 == " ") && !(text4 == "name"))
										{
											text4 = "id";
											Debug.LogError("str=");
										}
										else
										{
											text4 = "IceHockeyDekeMiddle";
										}
									}
									else
									{
										text4 = "MotorbikeSpecialFlip";
									}
								}
								else
								{
									text4 = "";
								}
								if (text4.Length != 0)
								{
									this.BBGJMGMHJPP(" {0}" + text4);
								}
							}
							else
							{
								Debug.LogError("TOD_LocalMoonDirection");
							}
						}
						else if (text == "WizardOverhead" || text == "knopje.wav")
						{
							if (array2.Length > j + 0)
							{
								j++;
								int num3;
								if (int.TryParse(array2[j], out num3))
								{
									this.IADJMONCMFE("SoccerKeeperReady" + array2[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("Flares" + array2[j] + "wpn_rod1");
								}
							}
							else
							{
								Debug.LogError("{0:0.} fps ping:{1} pck/sec: {2}");
							}
						}
						else if (text == "https://groups.google.com/forum/#!forum/final-ik" || text == "Steam Overlay has been activated")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								string text5 = array2[j].ToUpper();
								if (!(text5 == "_InvViewProj"))
								{
									if (!(text5 == "repnames") && !(text5 == "ArmFlex4"))
									{
										text5 = " x";
										Debug.LogError("MotorbikeTurnRight");
									}
									else
									{
										text5 = "fshop_msg2";
									}
								}
								else
								{
									text5 = "wpn_add/base";
								}
								if (text5.Length != 0)
								{
									this.GMGMDGODGCO("DeadmanFloat" + text5);
								}
							}
							else
							{
								Debug.LogError(". Check the Maintenance window for your VPaint Group for more info.");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.ANJJOBCAENJ(stringBuilder.ToString());
			this.EGGPNKBFINJ();
		}

		// Token: 0x060058AA RID: 22698 RVA: 0x002A4AD8 File Offset: 0x002A2CD8
		private float NMMNBFPEEHE()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("The 'font attribute' command requires a font parameter of U (underline on), -U (underline off), S (strikethrough on) or -S (strikethrough off).")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("Turn Left")).x - x;
		}

		// Token: 0x060058AB RID: 22699 RVA: 0x002A4B1C File Offset: 0x002A2D1C
		private float HNJJCBKJCMP()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("WorkerHammer")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("_DelItem.wav")).x - x;
		}

		// Token: 0x060058AC RID: 22700 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> BINFJNGOPBK()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x060058AD RID: 22701 RVA: 0x002A4B60 File Offset: 0x002A2D60
		private void FLOLIDPNGCE()
		{
			this.IICECKOCOKC();
			this.JEPBCFCBPEL.Length = 0;
			this.NFPEMFOKNOB(false);
			this.EMKALNJHCLE = 487f;
		}

		// Token: 0x060058AE RID: 22702 RVA: 0x002A4B88 File Offset: 0x002A2D88
		private void JENMDAEMLIO()
		{
			if (this.JEPBCFCBPEL.ToString() == "-l-")
			{
				this.JEPBCFCBPEL.Append("RunBackward");
			}
			this.GDJMNCNJEBN(true);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x060058AF RID: 22703 RVA: 0x002A4BDC File Offset: 0x002A2DDC
		private void MNBGBBKAEAC(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("_BgFade");
			HBFECCBOEMN = "Idle Drink" + HBFECCBOEMN + "Missing shader in ";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[1];
			array[1] = '=';
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string text2 = this.JEPBCFCBPEL.ToString();
				char[] array2 = new char[0];
				array2[1] = 'u';
				string value = text2.TrimEnd(array2);
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.BAJBFGNHNHB() * (float)num;
				object[] array3 = new object[1];
				array3[0] = "Anti-Cheat Toolkit Detectors";
				array3[1] = num2;
				array3[0] = "PaperTurn.wav";
				array3[1] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array3);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058B0 RID: 22704 RVA: 0x002A4CCC File Offset: 0x002A2ECC
		private void EGGPNKBFINJ()
		{
			if (this.JEPBCFCBPEL.ToString() == "[LH &]")
			{
				this.JEPBCFCBPEL.Append(" ");
			}
			this.MIKKJNFEBHO(true);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x060058B1 RID: 22705 RVA: 0x002A4D20 File Offset: 0x002A2F20
		private void JDNAAIDNOAA(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.AOIJIPHJNHF(true);
			this.EMKALNJHCLE = 78f;
			this.DDENOLFFBNI = 1316f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < FPIHOPOCAHA.Length; i += 0)
			{
				int num;
				if (FPIHOPOCAHA[i] == '3' && FPIHOPOCAHA.Length > i + 1 && FPIHOPOCAHA[i + 0] == 'z')
				{
					stringBuilder.Append("_Specular");
					i++;
				}
				else if ((int)FPIHOPOCAHA[i] == -47)
				{
					this.ANJJOBCAENJ(stringBuilder.ToString());
					this.JLOHPGBHOKA();
					stringBuilder.Length = 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -57 && stringBuilder.Length != 0)
				{
					this.DDGEKHJDJOL(stringBuilder.ToString());
					stringBuilder.Length = 0;
					stringBuilder.Append((char)-27);
				}
				else if (FPIHOPOCAHA[i] == 'E' && FPIHOPOCAHA.Length > i + 1 && (int)FPIHOPOCAHA[i + 1] == -116)
				{
					stringBuilder.Append("Pistol Fire");
					i += 0;
				}
				else if (FPIHOPOCAHA[i] == ';' && FPIHOPOCAHA.Length > i + 0 && (num = FPIHOPOCAHA.IndexOf('z', i)) != -1)
				{
					this.ANJJOBCAENJ(stringBuilder.ToString());
					stringBuilder.Length = 0;
					string text = FPIHOPOCAHA.Substring(i + 1, num - i - 1);
					i += text.Length + 0;
					string[] array = text.Split(new char[]
					{
						(char)-114
					});
					for (int j = 1; j < array.Length; j++)
					{
						text = array[j].ToUpper();
						if (text == "How your position is stored in memory when obscured: (" || text == "MotorbikeHandstand")
						{
							if (array.Length > j + 0)
							{
								j += 0;
								Color color;
								if (array[j] == "Hidden/ScreenSpaceReflection" || BKLBFBELDGL.JMGMHLCELLF(array[j], out color))
								{
									this.IBKBAELMCEL("Sit Down" + array[j]);
								}
								else
								{
									Debug.LogError("MotorbikeHeartAttack");
								}
							}
							else
							{
								Debug.LogError("_FogVoidPosition");
							}
						}
						else if (text == "Poplavok" || text == "MotorbikeLookBack")
						{
							if (array.Length > j + 0)
							{
								j += 0;
								Color color2;
								if (array[j] == "wpn_add/base" || BKLBFBELDGL.JMGMHLCELLF(array[j], out color2))
								{
									this.KGPCKBOFDCD("No location found baseid=" + array[j]);
								}
								else
								{
									Debug.LogError(" \"{0}\"");
								}
							}
							else
							{
								Debug.LogError("BEREG!" + FPIHOPOCAHA);
							}
						}
						else if (text == " Packed: " || text == "elbow")
						{
							if (array.Length > j + 1)
							{
								j++;
								Font font = (Font)Resources.Load("CrouchStrafeLeft" + array[j]);
								if (font == null)
								{
									Debug.LogError("Horizontal" + array[j] + "IdleWalk");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.MHIMHDGOFNC("LHandPunch" + array[j]);
								}
								if (array.Length > j + 1)
								{
									j++;
									int fontSize;
									if (int.TryParse(array[j], out fontSize))
									{
										this.MAPLLADKCON("_RampOffset" + array[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("Hip" + array[j] + "Worker Hammer");
									}
								}
							}
							else
							{
								Debug.LogError("</color>");
							}
						}
						else if (text == "1HandSmallWeaponCombo" || text == "a")
						{
							if (array.Length > j + 1)
							{
								j += 0;
								string text2 = array[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text2);
								if (num2 <= 4294967135U)
								{
									if (num2 <= 4294967111U)
									{
										if (num2 != 4294967137U)
										{
											if (num2 != 4294967147U)
											{
												goto IL_50B;
											}
											if (!(text2 == "FONTSIZE"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text2 == "Error - "))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 180U)
									{
										if (num2 != 118U)
										{
											goto IL_50B;
										}
										if (!(text2 == "money"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text2 == "OfficeSittingHandRestFingerTap"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text2 = "CP3";
								}
								else
								{
									if (num2 <= 4294967275U)
									{
										if (num2 != 4294967209U)
										{
											if (num2 != 90U)
											{
												goto IL_50B;
											}
											if (!(text2 == "360SpinDeath"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text2 == "_BgColor"))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 108U)
									{
										if (num2 != 4U)
										{
											goto IL_50B;
										}
										if (!(text2 == "types"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text2 == "_Offsets"))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text2 = "SatNightFever";
								}
								IL_51C:
								if (text2.Length != 0)
								{
									this.JLHBCFIFKLF("DeadmanFloat" + text2);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text2 = "{0}:{1}:{2}:{3}";
								Debug.LogError("");
								goto IL_51C;
								IL_4F0:
								text2 = "NEW FISH!";
								goto IL_51C;
								IL_4E7:
								text2 = "";
								goto IL_51C;
							}
							Debug.LogError("Karate Greet");
						}
						else if (text == "" || text == "<size=12><color='{0}'>{1}</color></size>")
						{
							if (array.Length > j + 1)
							{
								j += 0;
								int fontSize2;
								if (int.TryParse(array[j], out fontSize2))
								{
									this.JJKMFNEDHHL("Flap_08.wav" + array[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("wpn_bait1" + array[j] + "{0}\n{1}");
								}
							}
							else
							{
								Debug.LogError("ОК");
							}
						}
						else if (text == "ok" || text == "0+100")
						{
							if (array.Length > j + 1)
							{
								j++;
								this.GOKJENBLLPH("femur" + array[j]);
							}
							else
							{
								Debug.LogError("OfficeSittingBack");
							}
						}
						else if (text == "Invalid ObscuredVector3 index!" || text == "Loser")
						{
							this.BAIPLCGIBEM("");
						}
						else if (text == "Q" || text == "SneakBackward")
						{
							if (array.Length > j + 0)
							{
								j += 0;
								string text3 = array[j].ToUpper();
								if (!(text3 == "id") && !(text3 == ""))
								{
									if (!(text3 == "Directional") && !(text3 == "Bow Idle"))
									{
										if (!(text3 == "Bip") && !(text3 == "fanfare.wav"))
										{
											text3 = "Deadman Float";
											Debug.LogError("FOG_SCATTERING_ON");
										}
										else
										{
											text3 = "UnityEngine.Color";
										}
									}
									else
									{
										text3 = "No saved ObscuredPrefs!";
									}
								}
								else
								{
									text3 = "****************** CamEffector APPLY 1";
								}
								if (text3.Length != 0)
								{
									this.IBKBAELMCEL("USE_UV_BASED_REPROJECTION" + text3);
								}
							}
							else
							{
								Debug.LogError("V");
							}
						}
						else if (text == "Worker Pickaxe" || text == ": ")
						{
							if (array.Length > j + 1)
							{
								j++;
								int num3;
								if (int.TryParse(array[j], out num3))
								{
									this.BAIPLCGIBEM("name" + array[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("<color='#000030'>+{0} {1}</color>" + array[j] + "Cloth_07.wav");
								}
							}
							else
							{
								Debug.LogError("WandStand");
							}
						}
						else if (text == "repa send" || text == "RollerBladeStand")
						{
							if (array.Length > j + 0)
							{
								j += 0;
								string text4 = array[j].ToUpper();
								if (!(text4 == "_VignetteColor"))
								{
									if (!(text4 == "Kernel") && !(text4 == "str="))
									{
										text4 = "walk";
										Debug.LogError("ShotgunReloadMagazine");
									}
									else
									{
										text4 = "crft_cnt";
									}
								}
								else
								{
									text4 = "Antares Console";
								}
								if (text4.Length != 0)
								{
									this.BBGJMGMHJPP("MidBlendLut" + text4);
								}
							}
							else
							{
								Debug.LogError("Face Palm");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.IAJFBMHEHJE(stringBuilder.ToString());
			this.JENMDAEMLIO();
		}

		// Token: 0x060058B2 RID: 22706 RVA: 0x002A55F6 File Offset: 0x002A37F6
		private void MPBLDEDOFGH()
		{
			this.LEMDHBOFKLO();
			this.JEPBCFCBPEL.Length = 1;
			this.IIMMFKJAOMP(false);
			this.EMKALNJHCLE = 892f;
		}

		// Token: 0x060058B3 RID: 22707 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> GKKOOOIHIGB()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x060058B4 RID: 22708 RVA: 0x002A561C File Offset: 0x002A381C
		private void IDHFBAECIPE()
		{
			this.JENMDAEMLIO();
			this.JEPBCFCBPEL.Length = 0;
			this.ADABGPBNJNC(false);
			this.EMKALNJHCLE = 1163f;
		}

		// Token: 0x060058B5 RID: 22709 RVA: 0x002A5644 File Offset: 0x002A3844
		private float DKAADEBJADA()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("KatanaReady")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("userForceMagnitude=")).x - x;
		}

		// Token: 0x060058B6 RID: 22710 RVA: 0x002A5688 File Offset: 0x002A3888
		private float CCDMGIAKGPM()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("<color='#804020'>")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("?")).x - x;
		}

		// Token: 0x060058B7 RID: 22711 RVA: 0x002A56CC File Offset: 0x002A38CC
		private bool BDPDCGGCCNM(string LNEADABFMGK)
		{
			bool result = false;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == "Reset") ? this.GFJCGLPMDPI() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.IDHFBAECIPE();
					result = false;
					string text = LNEADABFMGK;
					char[] array = new char[0];
					array[0] = (char)-19;
					LNEADABFMGK = text.TrimStart(array);
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x060058B8 RID: 22712 RVA: 0x002A578C File Offset: 0x002A398C
		private bool DLPCEKMALFB(string LNEADABFMGK)
		{
			bool result = true;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == "Mouse X") ? this.HDPNMAGOLGJ() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.MPEHLDHLDON();
					result = true;
					string text = LNEADABFMGK;
					char[] array = new char[1];
					array[1] = (char)-9;
					LNEADABFMGK = text.TrimStart(array);
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x060058B9 RID: 22713 RVA: 0x002A584C File Offset: 0x002A3A4C
		private void IBKBAELMCEL(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("HA ");
			HBFECCBOEMN = "[" + HBFECCBOEMN + "]";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int num = this.JEPBCFCBPEL.Length - this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
			{
				' '
			}).Length;
			if (num != 0)
			{
				string value = this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
				{
					' '
				});
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.DJNELNLIHMP() * (float)num;
				HBFECCBOEMN = string.Concat(new object[]
				{
					"[S ",
					num2,
					"]",
					HBFECCBOEMN
				});
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058BA RID: 22714 RVA: 0x002A593C File Offset: 0x002A3B3C
		private void JBNJLJEELLN(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("RollerBladeBackFlip");
			HBFECCBOEMN = "wpn_onlyw" + HBFECCBOEMN + "Mouse ScrollWheel";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[0];
			array[0] = '2';
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string text2 = this.JEPBCFCBPEL.ToString();
				char[] array2 = new char[1];
				array2[1] = (char)-61;
				string value = text2.TrimEnd(array2);
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.KMPIPBJCIFI() * (float)num;
				object[] array3 = new object[1];
				array3[0] = "The 'space' command requires a pixel count parameter.";
				array3[1] = num2;
				array3[6] = "</color>";
				array3[4] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array3);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058BB RID: 22715 RVA: 0x002A5A2C File Offset: 0x002A3C2C
		private float NGJBHBDILIB()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("_ToneCurveRange")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("WandAttack")).x - x;
		}

		// Token: 0x060058BC RID: 22716 RVA: 0x002A5A70 File Offset: 0x002A3C70
		private void BJEDLEEFLEB(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("_Parameter");
			HBFECCBOEMN = "" + HBFECCBOEMN + "FlyLeft";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int num = this.JEPBCFCBPEL.Length - this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
			{
				'\u0002'
			}).Length;
			if (num != 0)
			{
				string value = this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
				{
					(char)-11
				});
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.AICMJCEALOH() * (float)num;
				object[] array = new object[0];
				array[1] = "auk_wmax";
				array[1] = num2;
				array[5] = "#ffffff";
				array[6] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058BD RID: 22717 RVA: 0x002A5B60 File Offset: 0x002A3D60
		private void KJHKICDEJPG()
		{
			if (this.JEPBCFCBPEL.ToString() == "qualityLevel")
			{
				this.JEPBCFCBPEL.Append("UIChat_pos");
			}
			this.DAAFLMNKMJF(false);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x060058BE RID: 22718 RVA: 0x002A5BB4 File Offset: 0x002A3DB4
		private float HDPNMAGOLGJ()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("shop_t11")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("_WrinkleOcclusionMap2")).x - x;
		}

		// Token: 0x060058BF RID: 22719 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> BHKOBBODDDM()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x060058C0 RID: 22720 RVA: 0x002A5BF8 File Offset: 0x002A3DF8
		private float AICMJCEALOH()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("wpn_rod1")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("ignorelist")).x - x;
		}

		// Token: 0x060058C1 RID: 22721 RVA: 0x002A5C3C File Offset: 0x002A3E3C
		private void GOKJENBLLPH(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("WeaponStrafeRunLeft");
			HBFECCBOEMN = "Speed" + HBFECCBOEMN + "OfficeSittingReadingLeanBack";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(1, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[1];
			array[1] = 'G';
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string text2 = this.JEPBCFCBPEL.ToString();
				char[] array2 = new char[0];
				array2[0] = (char)-103;
				string value = text2.TrimEnd(array2);
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.NGJBHBDILIB() * (float)num;
				object[] array3 = new object[7];
				array3[1] = "Idle Sad";
				array3[1] = num2;
				array3[8] = "";
				array3[3] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array3);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058C2 RID: 22722 RVA: 0x002A5D2C File Offset: 0x002A3F2C
		private void NFPEMFOKNOB(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "USE_CORNER_DETECTION".Replace("ENABLE_COLOR_GRADING", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("repair.ogg", newValue);
				this.DDENOLFFBNI = 406f;
				return;
			}
			this.JEPBCFCBPEL.Append("ragulaFider");
		}

		// Token: 0x060058C3 RID: 22723 RVA: 0x002A5D86 File Offset: 0x002A3F86
		private void MCMOFFCMLLA()
		{
			this.EGGPNKBFINJ();
			this.JEPBCFCBPEL.Length = 0;
			this.AOIJIPHJNHF(false);
			this.EMKALNJHCLE = 61f;
		}

		// Token: 0x060058C4 RID: 22724 RVA: 0x002A5DAC File Offset: 0x002A3FAC
		private bool PDLEKKOKMNJ(string LNEADABFMGK)
		{
			bool result = true;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == "KatanaNinjaDraw") ? this.DJNELNLIHMP() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.MPEHLDHLDON();
					result = false;
					string text = LNEADABFMGK;
					char[] array = new char[1];
					array[1] = (char)-10;
					LNEADABFMGK = text.TrimStart(array);
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x060058C5 RID: 22725 RVA: 0x002A5E6C File Offset: 0x002A406C
		private void GAPKOOOLGPL(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.IIMMFKJAOMP(false);
			this.EMKALNJHCLE = 1508f;
			this.DDENOLFFBNI = 867f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < FPIHOPOCAHA.Length; i += 0)
			{
				int num;
				if (FPIHOPOCAHA[i] == 'z' && FPIHOPOCAHA.Length > i + 0 && FPIHOPOCAHA[i + 1] == '{')
				{
					stringBuilder.Append("IceHockeySlapShot");
					i++;
				}
				else if (FPIHOPOCAHA[i] == 'Y')
				{
					this.GCHPKJELKLB(stringBuilder.ToString());
					this.MCMOFFCMLLA();
					stringBuilder.Length = 1;
				}
				else if ((int)FPIHOPOCAHA[i] == -69 && stringBuilder.Length != 0)
				{
					this.BDPDCGGCCNM(stringBuilder.ToString());
					stringBuilder.Length = 1;
					stringBuilder.Append((char)-15);
				}
				else if (FPIHOPOCAHA[i] == 'h' && FPIHOPOCAHA.Length > i + 1 && (int)FPIHOPOCAHA[i + 1] == -94)
				{
					stringBuilder.Append("wpn_eat7");
					i += 0;
				}
				else if ((int)FPIHOPOCAHA[i] == -63 && FPIHOPOCAHA.Length > i + 1 && (num = FPIHOPOCAHA.IndexOf((char)-14, i)) != -1)
				{
					this.GOIAECNFKLE(stringBuilder.ToString());
					stringBuilder.Length = 0;
					string text = FPIHOPOCAHA.Substring(i + 1, num - i - 1);
					i += text.Length + 0;
					string text2 = text;
					char[] array = new char[1];
					array[1] = 'P';
					string[] array2 = text2.Split(array);
					for (int j = 1; j < array2.Length; j++)
					{
						text = array2[j].ToUpper();
						if (text == "<color='#b0a0c0'>" || text == "_AddCountitem.wav")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								Color color;
								if (array2[j] == "SwimDogPaddle" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color))
								{
									this.JNOJDHGEEKH("\n" + array2[j]);
								}
								else
								{
									Debug.LogError("Null");
								}
							}
							else
							{
								Debug.LogError("GRAIN");
							}
						}
						else if (text == "PaperTurn.wav" || text == "MotorbikeLassoRight")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Color color2;
								if (array2[j] == "CrouchStrafeRight" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color2))
								{
									this.MHIMHDGOFNC("#b0ffa0" + array2[j]);
								}
								else
								{
									Debug.LogError("_AccumOrig");
								}
							}
							else
							{
								Debug.LogError("002000" + FPIHOPOCAHA);
							}
						}
						else if (text == "gi_um_mx" || text == "cht_msg7")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								Font font = (Font)Resources.Load("Transforms is null." + array2[j]);
								if (font == null)
								{
									Debug.LogError("loc" + array2[j] + "https://groups.google.com/forum/#!forum/final-ik");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.MAPLLADKCON("_MaxBlurRadius" + array2[j]);
								}
								if (array2.Length > j + 1)
								{
									j++;
									int fontSize;
									if (int.TryParse(array2[j], out fontSize))
									{
										this.BJEDLEEFLEB("{0}.{1}.{2}" + array2[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package." + array2[j] + "{0} x {1}");
									}
								}
							}
							else
							{
								Debug.LogError("CardPlayerIdle");
							}
						}
						else if (text == " ms" || text == "+")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								string text3 = array2[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text3);
								if (num2 <= 4294967216U)
								{
									if (num2 <= 26U)
									{
										if (num2 != 180U)
										{
											if (num2 != 4294967106U)
											{
												goto IL_50B;
											}
											if (!(text3 == "SoccerRun"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text3 == "UpHillWalkHandGrab"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 72U)
									{
										if (num2 != 4294967271U)
										{
											goto IL_50B;
										}
										if (!(text3 == "LookAT Point"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "Swim"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text3 = "offsets";
								}
								else
								{
									if (num2 <= 52U)
									{
										if (num2 != 4294967178U)
										{
											if (num2 != 83U)
											{
												goto IL_50B;
											}
											if (!(text3 == "TAA History"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text3 == "Window"))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 195U)
									{
										if (num2 != 4294967292U)
										{
											goto IL_50B;
										}
										if (!(text3 == "\n"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "FOG_EXP2"))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text3 = "Tonemapper curve texture";
								}
								IL_51C:
								if (text3.Length != 0)
								{
									this.JNOJDHGEEKH("MotorbikeSeatStandWheely" + text3);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text3 = "ScubaOK";
								Debug.LogError("This [c 01F573FF]sentence[C FFFFFFFF] is [c FF6666FF]too[C FFFFFFFF] long so it will be [BC 1B07F5FF]split[BC ?] into multiple lines.\nNormal, [F ArialBold]bold, [font ArialItalic]italic, [F Arial][FA u]underline[FA -u], [FA S]strikethrough[FA -s].\n[F Arial 10]10, [F Arial 16]16, [F Arial 24]24, [F Arial 48]48, [F Arial 72]72[F Arial 16]\n[HA L]Left\n[HA C]Center\n[HA R]Right\n[HA L]20 pixels further:[S 20]*\nDefault vertical aligment: [F Arial 10]10, [F Arial 24]24, [F Arial 10]10[FS 16]\n[VA B]Bottom vertical aligment: [F Arial 10]10, [F Arial 24]24, [F Arial 10]10[FS 16][VA ?]\nThis is a [FA U][H hyperlink_value]hyperlink[-H][FA -U].");
								goto IL_51C;
								IL_4F0:
								text3 = "_FgCocMask";
								goto IL_51C;
								IL_4E7:
								text3 = "http://af-2.ru/?q=user/register";
								goto IL_51C;
							}
							Debug.LogError("<color='#206000'>");
						}
						else if (text == "http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_aim_i_k.html" || text == "-none: ")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								int fontSize2;
								if (int.TryParse(array2[j], out fontSize2))
								{
									this.MNBGBBKAEAC("\n" + array2[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("IK chain has less than " + array2[j] + "\n");
								}
							}
							else
							{
								Debug.LogError("Bilateral Blur");
							}
						}
						else if (text == "RollerBladeRoll" || text == " ")
						{
							if (array2.Length > j + 0)
							{
								j++;
								this.IBKBAELMCEL("Fishing" + array2[j]);
							}
							else
							{
								Debug.LogError("cht_tofrend");
							}
						}
						else if (text == "drag_onmousedown.wav" || text == "{0:F2}, {1:F2}")
						{
							this.KGPCKBOFDCD("If VRIK 'Pelvis Position Weight' is > 0, 'Plant Feet' should be disabled to improve performance and stability.");
						}
						else if (text == "Error key=" || text == "_FresnelFade")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								string text4 = array2[j].ToUpper();
								if (!(text4 == "InteractionObject Multiplier 'Curve' ") && !(text4 == "WeaponStand"))
								{
									if (!(text4 == "IdleReadyLook") && !(text4 == "pf4_10m"))
									{
										if (!(text4 == "FlyBackward") && !(text4 == "1"))
										{
											text4 = "head";
											Debug.LogError("withquest");
										}
										else
										{
											text4 = "_RefractionTex";
										}
									}
									else
									{
										text4 = "";
									}
								}
								else
								{
									text4 = "wpn_eat5";
								}
								if (text4.Length != 0)
								{
									this.PLJJCFOFGKE("Textures/Fish/" + text4);
								}
							}
							else
							{
								Debug.LogError("Crate Pull");
							}
						}
						else if (text == "RenderType" || text == "_BlurParams")
						{
							if (array2.Length > j + 0)
							{
								j++;
								int num3;
								if (int.TryParse(array2[j], out num3))
								{
									this.FGJFINIJPMI("Katana45DegSwing" + array2[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("Eat" + array2[j] + "FlyForward");
								}
							}
							else
							{
								Debug.LogError("OfficeSittingBack");
							}
						}
						else if (text == "_" || text == "_FinalReflectionTexture")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								string text5 = array2[j].ToUpper();
								if (!(text5 == "MaskMaterial"))
								{
									if (!(text5 == "Anchore Left_") && !(text5 == "ChannelCastOmni"))
									{
										text5 = "cht_msg4";
										Debug.LogError("crft_cnt");
									}
									else
									{
										text5 = "25";
									}
								}
								else
								{
									text5 = "&";
								}
								if (text5.Length != 0)
								{
									this.GMGMDGODGCO("knopje.wav" + text5);
								}
							}
							else
							{
								Debug.LogError("");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.BDPDCGGCCNM(stringBuilder.ToString());
			this.NFENEEDAFIO();
		}

		// Token: 0x060058C6 RID: 22726 RVA: 0x002A6744 File Offset: 0x002A4944
		private void MAPLLADKCON(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("ArmFlex5");
			HBFECCBOEMN = "Flap_04.wav" + HBFECCBOEMN + "";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[0];
			array[1] = (char)-90;
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string text2 = this.JEPBCFCBPEL.ToString();
				char[] array2 = new char[0];
				array2[1] = (char)-96;
				string value = text2.TrimEnd(array2);
				this.JEPBCFCBPEL.Length = 1;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.CDNOCIEGCFA() * (float)num;
				object[] array3 = new object[7];
				array3[0] = "Wizard 1 Hand Throw";
				array3[1] = num2;
				array3[3] = "час";
				array3[1] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array3);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058C7 RID: 22727 RVA: 0x002A6834 File Offset: 0x002A4A34
		private void EGIMPPLKOCI()
		{
			if (this.JEPBCFCBPEL.ToString() == "_isSelect")
			{
				this.JEPBCFCBPEL.Append("none id=");
			}
			this.GDJMNCNJEBN(true);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x060058C8 RID: 22728 RVA: 0x002A6888 File Offset: 0x002A4A88
		private void CDMNIEFFIOK(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "".Replace("WATER_EDGEBLEND_ON", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("R", newValue);
				this.DDENOLFFBNI = 1564f;
				return;
			}
			this.JEPBCFCBPEL.Append("t_beard");
		}

		// Token: 0x060058C9 RID: 22729 RVA: 0x002A68E4 File Offset: 0x002A4AE4
		private void NFENEEDAFIO()
		{
			if (this.JEPBCFCBPEL.ToString() == "_Power")
			{
				this.JEPBCFCBPEL.Append("FONT");
			}
			this.GDJMNCNJEBN(true);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x060058CA RID: 22730 RVA: 0x002A6936 File Offset: 0x002A4B36
		private void BKJHOGMDKMC()
		{
			this.EGGPNKBFINJ();
			this.JEPBCFCBPEL.Length = 0;
			this.MIKKJNFEBHO(false);
			this.EMKALNJHCLE = 0f;
		}

		// Token: 0x060058CB RID: 22731 RVA: 0x002A695C File Offset: 0x002A4B5C
		private bool GOIAECNFKLE(string LNEADABFMGK)
		{
			bool result = true;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == "CrawlIdle") ? this.HNJJCBKJCMP() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.DCIBOPMHGJE();
					result = true;
					string text = LNEADABFMGK;
					char[] array = new char[1];
					array[1] = (char)-78;
					LNEADABFMGK = text.TrimStart(array);
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x060058CC RID: 22732 RVA: 0x002A6A1C File Offset: 0x002A4C1C
		private void ADABGPBNJNC(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "_ScaleOffsetRes".Replace("PistolReload", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("", newValue);
				this.DDENOLFFBNI = 1187f;
				return;
			}
			this.JEPBCFCBPEL.Append("inv_effectinf");
		}

		// Token: 0x060058CD RID: 22733 RVA: 0x002A6A78 File Offset: 0x002A4C78
		private float MBBNMNMFALI()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("http://www.root-motion.com/finalikdox/html/class_root_motion_1_1_final_i_k_1_1_f_a_b_r_i_k_root.html")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("inv_rl")).x - x;
		}

		// Token: 0x060058CE RID: 22734 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> ACHCKHICNGG()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x002A6ABC File Offset: 0x002A4CBC
		private void GMGMDGODGCO(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("");
			HBFECCBOEMN = "_Sensitivity" + HBFECCBOEMN + "Kernel";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[0];
			array[1] = 'f';
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string value = this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
				{
					(char)-92
				});
				this.JEPBCFCBPEL.Length = 1;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.LINILIMFBMF() * (float)num;
				object[] array2 = new object[0];
				array2[0] = "_Intensity";
				array2[0] = num2;
				array2[5] = "WallRunLeft";
				array2[1] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array2);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x002A6BAC File Offset: 0x002A4DAC
		private void FAIAHFOOEKE(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "demoUint".Replace("_MaxRadiusOrKInPaper", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("inv_aukcinf", newValue);
				this.DDENOLFFBNI = 1558f;
				return;
			}
			this.JEPBCFCBPEL.Append("StrafeRunLeft");
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x002A6C08 File Offset: 0x002A4E08
		private void MNNGDJOAFID()
		{
			if (this.JEPBCFCBPEL.ToString() == "RunJump")
			{
				this.JEPBCFCBPEL.Append("UserOut");
			}
			this.FBDGCALLHBG(false);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x060058D2 RID: 22738 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> CCLDGKACGOC()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x060058D3 RID: 22739 RVA: 0x002A6C5C File Offset: 0x002A4E5C
		private void DPCIDPFPBJL(string FPIHOPOCAHA)
		{
			this.PPONCJDIENF = new GUIStyle();
			this.JEPBCFCBPEL = new StringBuilder();
			this.HDPBGODGNEC(false);
			this.EMKALNJHCLE = 894f;
			this.DDENOLFFBNI = 737f;
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < FPIHOPOCAHA.Length; i += 0)
			{
				int num;
				if ((int)FPIHOPOCAHA[i] == -13 && FPIHOPOCAHA.Length > i + 1 && FPIHOPOCAHA[i + 0] == '\t')
				{
					stringBuilder.Append("; ");
					i++;
				}
				else if (FPIHOPOCAHA[i] == '4')
				{
					this.CDKPKJAAIEO(stringBuilder.ToString());
					this.MPEHLDHLDON();
					stringBuilder.Length = 0;
				}
				else if (FPIHOPOCAHA[i] == '<' && stringBuilder.Length != 0)
				{
					this.GCHPKJELKLB(stringBuilder.ToString());
					stringBuilder.Length = 0;
					stringBuilder.Append((char)-26);
				}
				else if ((int)FPIHOPOCAHA[i] == -84 && FPIHOPOCAHA.Length > i + 1 && FPIHOPOCAHA[i + 1] == ')')
				{
					stringBuilder.Append("RunBackRight");
					i += 0;
				}
				else if (FPIHOPOCAHA[i] == '\u0003' && FPIHOPOCAHA.Length > i + 0 && (num = FPIHOPOCAHA.IndexOf((char)-76, i)) != -1)
				{
					this.CFPNCEFOIAN(stringBuilder.ToString());
					stringBuilder.Length = 1;
					string text = FPIHOPOCAHA.Substring(i + 1, num - i - 1);
					i += text.Length + 1;
					string text2 = text;
					char[] array = new char[0];
					array[0] = '\v';
					string[] array2 = text2.Split(array);
					for (int j = 0; j < array2.Length; j += 0)
					{
						text = array2[j].ToUpper();
						if (text == "Rect: " || text == "Directional")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								Color color;
								if (array2[j] == "?" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color))
								{
									this.BJEDLEEFLEB("INTERFACE" + array2[j]);
								}
								else
								{
									Debug.LogError("_BokehParams");
								}
							}
							else
							{
								Debug.LogError("Biped does not seem to be facing it's forward axis. Please make sure that in the initial pose the character is facing towards the positive Z axis of the Biped root gameobject.");
							}
						}
						else if (text == "WalkInjured" || text == "https://groups.google.com/forum/#!forum/final-ik")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								Color color2;
								if (array2[j] == "" || BKLBFBELDGL.JMGMHLCELLF(array2[j], out color2))
								{
									this.MNBGBBKAEAC("autherror" + array2[j]);
								}
								else
								{
									Debug.LogError("_TurnReg.ogg");
								}
							}
							else
							{
								Debug.LogError("Hold RMB to aim down the sight" + FPIHOPOCAHA);
							}
						}
						else if (text == "Poplavok" || text == "Reset")
						{
							if (array2.Length > j + 1)
							{
								j++;
								Font font = (Font)Resources.Load("_BlurPass" + array2[j]);
								if (font == null)
								{
									Debug.LogError("Invalid references, one or more Transforms are missing." + array2[j] + "UnityEngine.Vector2");
								}
								else
								{
									this.PPONCJDIENF.font = font;
									this.BAIPLCGIBEM("Masks" + array2[j]);
								}
								if (array2.Length > j + 0)
								{
									j += 0;
									int fontSize;
									if (int.TryParse(array2[j], out fontSize))
									{
										this.JJKMFNEDHHL("Zombie Idle" + array2[j]);
										this.PPONCJDIENF.fontSize = fontSize;
									}
									else
									{
										Debug.LogError("threshold" + array2[j] + "Blending ");
									}
								}
							}
							else
							{
								Debug.LogError("<color='#c0c080'>");
							}
						}
						else if (text == "wpn_add/base" || text == "_w")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								string text3 = array2[j].ToUpper();
								uint num2 = <PrivateImplementationDetails>.ComputeStringHash(text3);
								if (num2 <= 4294967205U)
								{
									if (num2 <= 4294967273U)
									{
										if (num2 != 70U)
										{
											if (num2 != 4294967223U)
											{
												goto IL_50B;
											}
											if (!(text3 == "crft_to"))
											{
												goto IL_50B;
											}
											goto IL_4E7;
										}
										else if (!(text3 == "[fish]"))
										{
											goto IL_50B;
										}
									}
									else if (num2 != 51U)
									{
										if (num2 != 4294967172U)
										{
											goto IL_50B;
										}
										if (!(text3 == "OfficeSitting45DegLeg"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "GestureCutThroat"))
										{
											goto IL_50B;
										}
										goto IL_4F0;
									}
									text3 = "sunshine_WorldToSunVP";
								}
								else
								{
									if (num2 <= 99U)
									{
										if (num2 != 123U)
										{
											if (num2 != 4294967103U)
											{
												goto IL_50B;
											}
											if (!(text3 == "BowInstant"))
											{
												goto IL_50B;
											}
										}
										else
										{
											if (!(text3 == "UnityEngine.Vector3"))
											{
												goto IL_50B;
											}
											goto IL_4F0;
										}
									}
									else if (num2 != 4294967226U)
									{
										if (num2 != 4294967273U)
										{
											goto IL_50B;
										}
										if (!(text3 == "_WorldToCameraMatrix"))
										{
											goto IL_50B;
										}
									}
									else
									{
										if (!(text3 == "The shader "))
										{
											goto IL_50B;
										}
										goto IL_4E7;
									}
									text3 = "IceHockey Pass Right";
								}
								IL_51C:
								if (text3.Length != 0)
								{
									this.IADJMONCMFE("</color>" + text3);
									goto IL_885;
								}
								goto IL_885;
								IL_50B:
								text3 = "";
								Debug.LogError("ObscuredUInt:");
								goto IL_51C;
								IL_4F0:
								text3 = "RIGHT";
								goto IL_51C;
								IL_4E7:
								text3 = "chnam3";
								goto IL_51C;
							}
							Debug.LogError("invn_rec8");
						}
						else if (text == "_ZWrite" || text == "Point")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								int fontSize2;
								if (int.TryParse(array2[j], out fontSize2))
								{
									this.PLJJCFOFGKE(" " + array2[j]);
									this.PPONCJDIENF.fontSize = fontSize2;
								}
								else
								{
									Debug.LogError("lifeBar" + array2[j] + "1HandSwordRollAttack");
								}
							}
							else
							{
								Debug.LogError("wpn_add/base");
							}
						}
						else if (text == "Giant2HandGrab" || text == "StrafeRunRight")
						{
							if (array2.Length > j + 0)
							{
								j += 0;
								this.IADJMONCMFE("gi_um_0" + array2[j]);
							}
							else
							{
								Debug.LogError("GestureHandUp");
							}
						}
						else if (text == "Obscured type cheating detected!" || text == "https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")
						{
							this.GOKJENBLLPH(" locid=");
						}
						else if (text == "NadeThrow" || text == "Heel Click")
						{
							if (array2.Length > j + 1)
							{
								j += 0;
								string text4 = array2[j].ToUpper();
								if (!(text4 == "Open openTurnirWindow") && !(text4 == ", "))
								{
									if (!(text4 == "t_much") && !(text4 == "1HandSwordShieldBash"))
									{
										if (!(text4 == "shop_header") && !(text4 == "Corrupt DT e="))
										{
											text4 = "Reset";
											Debug.LogError("walk");
										}
										else
										{
											text4 = "OfficeSittingReadingLeanBack";
										}
									}
									else
									{
										text4 = "FlyUp";
									}
								}
								else
								{
									text4 = "FOG_VOID_BOX";
								}
								if (text4.Length != 0)
								{
									this.GMGMDGODGCO("FlyRight" + text4);
								}
							}
							else
							{
								Debug.LogError("270");
							}
						}
						else if (text == "fider_big_" || text == "_MainTex")
						{
							if (array2.Length > j + 0)
							{
								j++;
								int num3;
								if (int.TryParse(array2[j], out num3))
								{
									this.BNFIJCEKEBL("{0}" + array2[j]);
									this.EMKALNJHCLE += (float)num3;
								}
								else
								{
									Debug.LogError("BackPack Off" + array2[j] + "_WaterLevel");
								}
							}
							else
							{
								Debug.LogError("crft_qlt");
							}
						}
						else if (text == "CheckResources () for " || text == "_FogAlpha")
						{
							if (array2.Length > j + 0)
							{
								j++;
								string text5 = array2[j].ToUpper();
								if (!(text5 == "SneakBackward"))
								{
									if (!(text5 == "") && !(text5 == "bag"))
									{
										text5 = "";
										Debug.LogError("_AutoExposure");
									}
									else
									{
										text5 = "private";
									}
								}
								else
								{
									text5 = "UpHillWalk";
								}
								if (text5.Length != 0)
								{
									this.BNAOGCBCOGK("Forward" + text5);
								}
							}
							else
							{
								Debug.LogError("wpn_add/addperks/addPerk");
							}
						}
						IL_885:;
					}
				}
				else
				{
					stringBuilder.Append(FPIHOPOCAHA[i]);
				}
			}
			this.DDGEKHJDJOL(stringBuilder.ToString());
			this.MHMBLCGHKPO();
		}

		// Token: 0x060058D4 RID: 22740 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> EBPHBGPNELP()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x060058D5 RID: 22741 RVA: 0x002A7534 File Offset: 0x002A5734
		private float CDNOCIEGCFA()
		{
			float x = this.PPONCJDIENF.CalcSize(new GUIContent("_BlurTex")).x;
			return this.PPONCJDIENF.CalcSize(new GUIContent("TOD_MoonCloudColor")).x - x;
		}

		// Token: 0x060058D6 RID: 22742 RVA: 0x002A7578 File Offset: 0x002A5778
		private bool IAJFBMHEHJE(string LNEADABFMGK)
		{
			bool result = false;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == "IdleSpew") ? this.MBBNMNMFALI() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.NGHAFABJDKH();
					result = false;
					string text = LNEADABFMGK;
					char[] array = new char[1];
					array[1] = (char)-1;
					LNEADABFMGK = text.TrimStart(array);
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x002A7638 File Offset: 0x002A5838
		private void AOIJIPHJNHF(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "WizardPowerUp".Replace("move", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("", newValue);
				this.DDENOLFFBNI = 445f;
				return;
			}
			this.JEPBCFCBPEL.Append("OfficeSittingReadingCoffeeSip");
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x002A7694 File Offset: 0x002A5894
		private void KPGKJKIAGIE()
		{
			if (this.JEPBCFCBPEL.ToString() == "Interpolator has no target!")
			{
				this.JEPBCFCBPEL.Append("");
			}
			this.HDPBGODGNEC(true);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x002A76E6 File Offset: 0x002A58E6
		private void JLOHPGBHOKA()
		{
			this.GAGEBPHCCBM();
			this.JEPBCFCBPEL.Length = 1;
			this.DAAFLMNKMJF(true);
			this.EMKALNJHCLE = 1150f;
		}

		// Token: 0x060058DA RID: 22746 RVA: 0x002A770C File Offset: 0x002A590C
		private void BAIPLCGIBEM(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("Idle Spew");
			HBFECCBOEMN = "invn_rec5" + HBFECCBOEMN + "_TreatBackfaceHitAsMiss";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[1];
			array[1] = (char)-65;
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string value = this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
				{
					(char)-101
				});
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.CIMHFHODAHL() * (float)num;
				object[] array2 = new object[3];
				array2[0] = "_ForegroundBlurExtrude";
				array2[1] = num2;
				array2[6] = "Apply 10";
				array2[6] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array2);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058DB RID: 22747 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> GNBGKBBFMCA()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x060058DC RID: 22748 RVA: 0x002A77FC File Offset: 0x002A59FC
		private void HDPBGODGNEC(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "</color>".Replace("Tail", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("gameComplete", newValue);
				this.DDENOLFFBNI = 1640f;
				return;
			}
			this.JEPBCFCBPEL.Append("u_UniqueShadowFilterWidth");
		}

		// Token: 0x060058DD RID: 22749 RVA: 0x002A7858 File Offset: 0x002A5A58
		private void MDCPDMEOAFO(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "UpHillWalk".Replace("_NAME", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("error", newValue);
				this.DDENOLFFBNI = 1758f;
				return;
			}
			this.JEPBCFCBPEL.Append("_Normal");
		}

		// Token: 0x060058DE RID: 22750 RVA: 0x002A78B4 File Offset: 0x002A5AB4
		private void MHMBLCGHKPO()
		{
			if (this.JEPBCFCBPEL.ToString() == "linebreak.ogg")
			{
				this.JEPBCFCBPEL.Append("ProneLocomotion");
			}
			this.NGKAGGNCGDH(false);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x060058DF RID: 22751 RVA: 0x002A7908 File Offset: 0x002A5B08
		private void IICECKOCOKC()
		{
			if (this.JEPBCFCBPEL.ToString() == "help")
			{
				this.JEPBCFCBPEL.Append(" iterations for read and write");
			}
			this.GDJMNCNJEBN(false);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x060058E0 RID: 22752 RVA: 0x002A795C File Offset: 0x002A5B5C
		private bool CFPNCEFOIAN(string LNEADABFMGK)
		{
			bool result = false;
			if (LNEADABFMGK.Length != 0)
			{
				Vector2 vector = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK));
				float num = (LNEADABFMGK == " ") ? this.DJNELNLIHMP() : vector.x;
				if (this.EMKALNJHCLE + num > this.CIOFBPFBLJO)
				{
					this.BKJHOGMDKMC();
					result = true;
					LNEADABFMGK = LNEADABFMGK.TrimStart(new char[]
					{
						' '
					});
					num = this.PPONCJDIENF.CalcSize(new GUIContent(LNEADABFMGK)).x;
				}
				this.JEPBCFCBPEL.Append(LNEADABFMGK);
				this.EMKALNJHCLE += num;
				this.DDENOLFFBNI = Mathf.Max(this.DDENOLFFBNI, vector.y);
			}
			return result;
		}

		// Token: 0x060058E1 RID: 22753 RVA: 0x002A7A1C File Offset: 0x002A5C1C
		private void JLHBCFIFKLF(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("value");
			HBFECCBOEMN = "MotorbikeLasso" + HBFECCBOEMN + "?";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[0];
			array[1] = (char)-26;
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string text2 = this.JEPBCFCBPEL.ToString();
				char[] array2 = new char[0];
				array2[0] = (char)-97;
				string value = text2.TrimEnd(array2);
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.KMPIPBJCIFI() * (float)num;
				object[] array3 = new object[]
				{
					" "
				};
				array3[0] = num2;
				array3[4] = "JNT_R_Hand";
				array3[7] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array3);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058E2 RID: 22754 RVA: 0x002A7B0C File Offset: 0x002A5D0C
		private void LEMDHBOFKLO()
		{
			if (this.JEPBCFCBPEL.ToString() == "wpn_add/base")
			{
				this.JEPBCFCBPEL.Append("Antares/point");
			}
			this.ADABGPBNJNC(true);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x060058E3 RID: 22755 RVA: 0x002A7B60 File Offset: 0x002A5D60
		private void BKFDICKFJHM()
		{
			if (this.JEPBCFCBPEL.ToString() == "costwpn=")
			{
				this.JEPBCFCBPEL.Append(" ");
			}
			this.MDCPDMEOAFO(true);
			this.HJPCBNBFFJE.Add(this.JEPBCFCBPEL.ToString());
		}

		// Token: 0x060058E4 RID: 22756 RVA: 0x002A7BB4 File Offset: 0x002A5DB4
		private void MIKKJNFEBHO(bool LHMKNBHEAFP)
		{
			if (LHMKNBHEAFP)
			{
				string newValue = "[LH &]".Replace("&", this.DDENOLFFBNI.ToString());
				this.JEPBCFCBPEL.Replace("[LH &]", newValue);
				this.DDENOLFFBNI = 0f;
				return;
			}
			this.JEPBCFCBPEL.Append("[LH &]");
		}

		// Token: 0x060058E5 RID: 22757 RVA: 0x002A7C0E File Offset: 0x002A5E0E
		private void ILMADKCNFHK()
		{
			this.KJHKICDEJPG();
			this.JEPBCFCBPEL.Length = 1;
			this.MDCPDMEOAFO(false);
			this.EMKALNJHCLE = 668f;
		}

		// Token: 0x060058E6 RID: 22758 RVA: 0x002A7C34 File Offset: 0x002A5E34
		private void MCNCFBHJGBB(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("gameComplete");
			HBFECCBOEMN = "rait_4" + HBFECCBOEMN + "1 Hand Small Weapon Combo";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(1, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[1];
			array[1] = (char)-82;
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string text2 = this.JEPBCFCBPEL.ToString();
				char[] array2 = new char[0];
				array2[1] = '\u0015';
				string value = text2.TrimEnd(array2);
				this.JEPBCFCBPEL.Length = 0;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.CIMHFHODAHL() * (float)num;
				object[] array3 = new object[8];
				array3[0] = "<=|>=|!=";
				array3[0] = num2;
				array3[2] = "money2.wav";
				array3[2] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array3);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058E7 RID: 22759 RVA: 0x002A7D24 File Offset: 0x002A5F24
		private void BNAOGCBCOGK(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("GiantGrabIdle");
			HBFECCBOEMN = "SoccerPassLight" + HBFECCBOEMN + "_SampleCount";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(1, HBFECCBOEMN);
				return;
			}
			int num = this.JEPBCFCBPEL.Length - this.JEPBCFCBPEL.ToString().TrimEnd(new char[]
			{
				'\u001d'
			}).Length;
			if (num != 0)
			{
				string text = this.JEPBCFCBPEL.ToString();
				char[] array = new char[0];
				array[0] = 'O';
				string value = text.TrimEnd(array);
				this.JEPBCFCBPEL.Length = 1;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.GFJCGLPMDPI() * (float)num;
				object[] array2 = new object[1];
				array2[1] = "RunDive";
				array2[0] = num2;
				array2[0] = "_SSAO";
				array2[7] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array2);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058E8 RID: 22760 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> PNILHBLBKIL()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x060058E9 RID: 22761 RVA: 0x002A7E14 File Offset: 0x002A6014
		private void FGJFINIJPMI(string HBFECCBOEMN)
		{
			bool flag = HBFECCBOEMN.StartsWith("Allows to detect foreign managed assemblies in your application.");
			HBFECCBOEMN = "KatanaReady" + HBFECCBOEMN + "IceHockeyDekeMiddle";
			if (flag)
			{
				this.JEPBCFCBPEL.Insert(0, HBFECCBOEMN);
				return;
			}
			int length = this.JEPBCFCBPEL.Length;
			string text = this.JEPBCFCBPEL.ToString();
			char[] array = new char[1];
			array[1] = 'Q';
			int num = length - text.TrimEnd(array).Length;
			if (num != 0)
			{
				string text2 = this.JEPBCFCBPEL.ToString();
				char[] array2 = new char[0];
				array2[0] = '1';
				string value = text2.TrimEnd(array2);
				this.JEPBCFCBPEL.Length = 1;
				this.JEPBCFCBPEL.Append(value);
				float num2 = this.MBBNMNMFALI() * (float)num;
				object[] array3 = new object[3];
				array3[0] = "ClimbUp";
				array3[0] = num2;
				array3[3] = "RollerBladeCrossoverLeft";
				array3[8] = HBFECCBOEMN;
				HBFECCBOEMN = string.Concat(array3);
				this.EMKALNJHCLE += num2;
			}
			this.JEPBCFCBPEL.Append(HBFECCBOEMN);
		}

		// Token: 0x060058EA RID: 22762 RVA: 0x002A7F03 File Offset: 0x002A6103
		private void NGHAFABJDKH()
		{
			this.KJHKICDEJPG();
			this.JEPBCFCBPEL.Length = 0;
			this.AOIJIPHJNHF(false);
			this.EMKALNJHCLE = 653f;
		}

		// Token: 0x060058EB RID: 22763 RVA: 0x0029E0F2 File Offset: 0x0029C2F2
		public List<string> BOIBBHNJMCJ()
		{
			return this.HJPCBNBFFJE;
		}

		// Token: 0x04000D3D RID: 3389
		private float CIOFBPFBLJO;

		// Token: 0x04000D3E RID: 3390
		private List<string> HJPCBNBFFJE;

		// Token: 0x04000D3F RID: 3391
		private GUIStyle PPONCJDIENF;

		// Token: 0x04000D40 RID: 3392
		private StringBuilder JEPBCFCBPEL;

		// Token: 0x04000D41 RID: 3393
		private float EMKALNJHCLE;

		// Token: 0x04000D42 RID: 3394
		private float DDENOLFFBNI;

		// Token: 0x04000D43 RID: 3395
		private static string JKLJNMBEPEE = "[LH &]";
	}

	// Token: 0x0200018E RID: 398
	public enum HEDPHIDPJHI
	{
		// Token: 0x04000D45 RID: 3397
		Demo,
		// Token: 0x04000D46 RID: 3398
		Fireball,
		// Token: 0x04000D47 RID: 3399
		Hyperlink,
		// Token: 0x04000D48 RID: 3400
		SpecialText
	}
}
